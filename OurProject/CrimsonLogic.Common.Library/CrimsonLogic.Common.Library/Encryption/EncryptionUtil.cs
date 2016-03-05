namespace AllInOne.Common.Library.Encryption
{
    using System;
    using System.IO;
    using System.Text;

    using log4net;

    using Object;

    /// <summary>
    /// Convenience class to performing encryption on string and object instances.
    /// </summary>
    public sealed class EncryptionUtil
    {
        #region Fields

        private const string PassPhrase = "Pas5pr@se";

        private static readonly ILog Logger = LogManager.GetLogger(typeof (EncryptionUtil));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Decrypts the specified instance byte array.
        /// </summary>
        /// <param name="instanceArray">Instance byte array submitted for decryption.</param>
        /// <returns>Object if decryption was successful; null for otherwise.</returns>
        public static object Decrypt(byte[] instanceArray)
        {
            if (instanceArray == null || instanceArray.LongLength == 0)
            {
                Logger.Warn("Unable to decrypt null or empty byte array!");
                return null;
            }

            if (Logger.IsDebugEnabled)
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                Logger.DebugFormat("Decrypting instance: {0}", encoding.GetString(instanceArray));
            }

            byte[] decryptedInstance;

            try
            {
                decryptedInstance = SimpleEncryption.Decrypt(instanceArray, PassPhrase);
            }
            catch (Exception exception)
            {
                Logger.Error("Problem encountered decrypting the byte array!", exception);
                return null;
            }

            return ObjectUtil.ConvertToObject(decryptedInstance);
        }

        /// <summary>
        /// Decrypts the specified to decrypt.
        /// </summary>
        /// <param name="toDecrypt">To decrypt.</param>
        /// <returns></returns>
        public static string Decrypt(string toDecrypt)
        {
            if (string.IsNullOrEmpty(toDecrypt))
            {
                Logger.Warn("Unable to decrypt null or empty string instance");
                return null;
            }

            return SimpleEncryption.Decrypt(toDecrypt, PassPhrase);
        }

        /// <summary>
        /// Decrypts the file.
        /// </summary>
        /// <param name="toDecryptFile">To decrypt file.</param>
        /// <param name="decryptedFilePath">The decrypted file path.</param>
        /// <exception cref="ArgumentNullException">Exception thrown when <paramref name="toDecryptFile"/> 
        /// is null or non-existent</exception>
        /// <exception cref="ArgumentNullException">Exception thrown when <paramref name="decryptedFilePath"/> 
        /// is null or empty string</exception>
        /// <exception cref="DecryptionException">Exception thrown when an error is encountered during the decryption process</exception>
        public static void DecryptFile(FileInfo toDecryptFile, string decryptedFilePath)
        {
            if (toDecryptFile == null || !toDecryptFile.Exists)
            {
                string message = string.Format("Unable to output to {0} when decrypted file is either a NULL or non-existent!", decryptedFilePath);
                Logger.ErrorFormat(message);
                throw new ArgumentNullException(message);
            }

            if (string.IsNullOrEmpty(decryptedFilePath))
            {
                string message = string.Format("Unable to decrypt file {0} when output path is either null or empty string!", toDecryptFile.Name);
                Logger.ErrorFormat(message);
                throw new ArgumentNullException(message);
            }

            FileEncryption.DecryptFile(toDecryptFile.FullName, decryptedFilePath, PassPhrase);
        }

        /// <summary>
        /// Encrypts the specified instance.
        /// </summary>
        /// <param name="instance">Object instance submitted for encryption.</param>
        /// <returns>The value byte[] will be returned if encryption was successful; 
        /// null for otherwise.</returns>
        public static byte[] Encrypt(object instance)
        {
            if (instance == null)
            {
                Logger.Warn("Unable to encrypt NULL instance");
                return null;
            }

            if (Logger.IsDebugEnabled)
            {
               Logger.DebugFormat("Encrypting instance: {0}", instance);
            }

            byte[] serializedInstance = ObjectUtil.ConvertToByteArray(instance);

            if (serializedInstance == null)
            {
                return null;
            }

            return SimpleEncryption.Encrypt(serializedInstance, PassPhrase);
        }

        /// <summary>
        /// Encrypts the specified to encrypt.
        /// </summary>
        /// <param name="toEncrypt">To encrypt.</param>
        /// <returns></returns>
        public static string Encrypt(string toEncrypt)
        {
            if (string.IsNullOrEmpty(toEncrypt))
            {
                Logger.Warn("Unable to encrypt null or empty string instance");
                return null;
            }

            return SimpleEncryption.Encrypt(toEncrypt, PassPhrase);
        }

        /// <summary>
        /// Encrypts the file.
        /// </summary>
        /// <param name="toEncryptFile">To encrypt file.</param>
        /// <param name="encryptedFilePath">The encrypted file path.</param>
        /// <exception cref="ArgumentNullException">Exception thrown when <paramref name="toEncryptFile"/> 
        /// is null or non-existent</exception>
        /// <exception cref="ArgumentNullException">Exception thrown when <paramref name="encryptedFilePath"/> 
        /// is null or empty string</exception>
        public static void EncryptFile(FileInfo toEncryptFile, string encryptedFilePath)
        {
            if (toEncryptFile == null || !toEncryptFile.Exists)
            {
                string message = string.Format("Unable to output to {0} when encrypted file is either a NULL or non-existent!", encryptedFilePath);
                Logger.ErrorFormat(message);
                throw new ArgumentNullException(message);
            }

            if (string.IsNullOrEmpty(encryptedFilePath))
            {
                string message = string.Format("Unable to encrypt file {0} when output path is either null or empty string!", toEncryptFile.Name);
                Logger.ErrorFormat(message);
                throw new ArgumentNullException(message);
            }

            Logger.InfoFormat("Encrypting file: {0} to path: {1}", toEncryptFile, encryptedFilePath);

            FileEncryption.EncryptFile(toEncryptFile.FullName, encryptedFilePath, PassPhrase);
        }

        #endregion Methods
    }
}