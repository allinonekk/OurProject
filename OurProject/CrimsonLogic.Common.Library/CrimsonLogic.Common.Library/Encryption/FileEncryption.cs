namespace AllInOne.Common.Library.Encryption
{
    using System.IO;
    using System.Linq;
    using System.Security.Cryptography;

    /// <summary>
    /// Class specialising in symmetric file encryption and decryption.
    /// </summary>
    internal class FileEncryption
    {
        #region Fields

        /// <summary>
        /// The amount of bytes to read from the file.
        /// </summary>
        private const int BufferSize = 128 * 1024;

        /// <summary>
        /// Tag to make sure this file is readable/decryptable by this class.
        /// </summary>
        private const ulong FileTag = 0xFC010203040506CF;

        /// <summary>
        /// Crypto Random number generator for use in EncryptFile.
        /// </summary>
        private static readonly RandomNumberGenerator Rand = new RNGCryptoServiceProvider();

        #endregion Fields

        #region Constructors

        private FileEncryption()
        {
            //do nothing - simply to prevent instantiation.
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Takes an input file and decrypts it to the output file.
        /// </summary>
        /// <param name="inFile">File for decryption.</param>
        /// <param name="outFile">File for writing the decrypted data to.</param>
        /// <param name="password">Password used as the key.</param>
        public static void DecryptFile(string inFile, string outFile, string password)
        {
            // create and open the file streams
            using (FileStream fin = File.OpenRead(inFile),
                              fout = File.OpenWrite(outFile))
            {
                byte[] bytes = new byte[BufferSize]; // byte buffer
                int outValue = 0; // the amount of bytes written out

                // read off the IV and Salt
                byte[] iv = new byte[16];
                fin.Read(iv, 0, 16);
                byte[] salt = new byte[16];
                fin.Read(salt, 0, 16);

                // create the crypting stream
                SymmetricAlgorithm sma = CreateRijndael(password, salt);
                sma.IV = iv;

                long lSize; // the size stored in the input stream

                // create the hashing object, so that we can verify the file
                HashAlgorithm hasher = SHA256.Create();

                try
                {
                    // create the cryptostreams that will process the file
                    using (CryptoStream cin = new CryptoStream(fin, sma.CreateDecryptor(), CryptoStreamMode.Read),
                                        chash = new CryptoStream(Stream.Null, hasher, CryptoStreamMode.Write))
                    {
                        // read size from file
                        BinaryReader br = new BinaryReader(cin);
                        lSize = br.ReadInt64();
                        ulong tag = br.ReadUInt64();

                        if (FileTag != tag)
                            throw new DecryptionException("File corrupted and decryption cannot proceed!");

                        //determine number of reads to process on the file
                        long numReads = lSize/BufferSize;

                        // determine what is left of the file, after numReads
                        long slack = lSize%BufferSize;

                        // read the buffer_sized chunks
                        int read; // the amount of bytes read from the stream
                        for (int i = 0; i < numReads; ++i)
                        {
                            read = cin.Read(bytes, 0, bytes.Length);
                            fout.Write(bytes, 0, read);
                            chash.Write(bytes, 0, read);
                            outValue += read;
                        }

                        // now read the slack
                        if (slack > 0)
                        {
                            read = cin.Read(bytes, 0, (int) slack);
                            fout.Write(bytes, 0, read);
                            chash.Write(bytes, 0, read);
                            outValue += read;
                        }
                        // flush and close the hashing stream
                        chash.Flush();
                        chash.Close();

                        // flush and close the output file
                        fout.Flush();
                        fout.Close();

                        // read the current hash value
                        byte[] curHash = hasher.Hash;

                        // get and compare the current and old hash values
                        byte[] oldHash = new byte[hasher.HashSize/8];
                        read = cin.Read(oldHash, 0, oldHash.Length);
                        if ((oldHash.Length != read) || (!CheckByteArrays(oldHash, curHash)))
                            throw new DecryptionException("File Corrupted!");
                    }
                }
                catch (CryptographicException exception)
                {
                    throw new DecryptionException(exception.Message);
                }

                // make sure the written and stored size are equal
                if (outValue != lSize)
                    throw new DecryptionException("File Sizes don't match!");
            }
        }

        /// <summary>
        /// This takes an input file and encrypts it into the output file.
        /// </summary>
        /// <param name="inFile">The file to encrypt.</param>
        /// <param name="outFile">The file to write the encrypted data to.</param>
        /// <param name="password">The password for use as the key.</param>
        public static void EncryptFile(string inFile, string outFile, string password)
        {
            using (FileStream fin = File.OpenRead(inFile),
                              fout = File.OpenWrite(outFile))
            {
                long lSize = fin.Length; // the size of the input file for storing
                byte[] bytes = new byte[BufferSize]; // the buffer

                // generate IV and Salt
                byte[] iv = GenerateRandomBytes(16);
                byte[] salt = GenerateRandomBytes(16);

                // create the crypting object
                SymmetricAlgorithm sma = CreateRijndael(password, salt);
                sma.IV = iv;

                // write the IV and salt to the beginning of the file
                fout.Write(iv, 0, iv.Length);
                fout.Write(salt, 0, salt.Length);

                // create the hashing and crypto streams
                HashAlgorithm hasher = SHA256.Create();
                using (CryptoStream cout = new CryptoStream(fout, sma.CreateEncryptor(), CryptoStreamMode.Write),
                                    chash = new CryptoStream(Stream.Null, hasher, CryptoStreamMode.Write))
                {
                    // write the size of the file to the output file
                    BinaryWriter bw = new BinaryWriter(cout);
                    bw.Write(lSize);

                    // write the file cryptor tag to the file
                    bw.Write(FileTag);

                    // read and the write the bytes to the crypto stream in BUFFER_SIZEd chunks
                    int read; // the amount of bytes read from the input file
                    while ((read = fin.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        cout.Write(bytes, 0, read);
                        chash.Write(bytes, 0, read);
                    }
                    // flush and close the hashing object
                    chash.Flush();
                    chash.Close();

                    // read the hash
                    byte[] hash = hasher.Hash;

                    // write the hash to the end of the file
                    cout.Write(hash, 0, hash.Length);

                    // flush and close the cryptostream
                    cout.Flush();
                    cout.Close();
                }
            }
        }

        /// <summary>
        /// Checks to see if two byte array are equal.
        /// </summary>
        /// <param name="b1">The first byte array.</param>
        /// <param name="b2">The second byte array.</param>
        /// <returns>
        ///     <c>true</c> if b1.Length == b2.Length and each byte in b1 is
        /// equal to the corresponding byte in b2.</returns>
        private static bool CheckByteArrays(byte[] b1, byte[] b2)
        {
            if (b1.Length == b2.Length)
            {
                return !b1.Where((t, i) => t != b2[i]).Any();
            }
            return false;
        }

        /// <summary>
        /// Creates a Rijndael SymmetricAlgorithm for use in EncryptFile and DecryptFile.
        /// </summary>
        /// <param name="password">The string to use as the password.</param>
        /// <param name="salt">The salt to use with the password.</param>
        /// <returns>A SymmetricAlgorithm for encrypting/decrypting with Rijndael.</returns>
        private static SymmetricAlgorithm CreateRijndael(string password, byte[] salt)
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(password, salt);

            SymmetricAlgorithm sma = Rijndael.Create();
            sma.KeySize = 256;
            sma.Key = pdb.GetBytes(32);
            sma.Padding = PaddingMode.PKCS7;
            return sma;
        }

        /// <summary>
        /// Generates a specified amount of random bytes.
        /// </summary>
        /// <param name="count">The number of bytes to return.</param>
        /// <returns>A byte array of count size filled with random bytes.</returns>
        private static byte[] GenerateRandomBytes(int count)
        {
            byte[] bytes = new byte[count];
            Rand.GetBytes(bytes);
            return bytes;
        }

        #endregion Methods
    }
}