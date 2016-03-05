namespace CrimsonLogic.Common.Library.Tests
{
    using System;
    using System.IO;

    using Encryption;

    using File;

    using log4net.Config;

    using NUnit.Framework;

    [TestFixture]
    public class TestEncryptionUtil
    {
        #region Methods

        /// <summary>
        /// 
        /// </summary>
        [TestFixtureSetUp]
        public void Init()
        {
            XmlConfigurator.Configure(new FileInfo("log4net_commonlibrary.Config"));
        }

        [Test]
        public void TestDecryptCorruptedFile()
        {
            TestEncryptFile();

            const string toDecryptFile = "post-decryption_test_commonlibrary.txt";
            const string encryptedFile = "post-encryption_test_commonlibrary.txt";
            FileInfo encryptedFileInfo = ConfigFileLocator.GetFromAppConfigLocation(encryptedFile);

            Assert.NotNull(encryptedFileInfo);

            FileInfo decryptedFileInfo = new FileInfo(encryptedFileInfo.DirectoryName + @"\" + toDecryptFile);
            EncryptionUtil.DecryptFile(encryptedFileInfo, decryptedFileInfo.FullName);

            Assert.IsTrue(decryptedFileInfo.Exists);
        }

        [Test]
        [ExpectedException(typeof(DecryptionException))]
        public void TestDecryptFile()
        {
            TestEncryptFile();

            const string encryptedFile = "encryption_corrupted_test_commonlibrary.txt";
            const string toDecryptFile = "post-encryption_corrupted_test_commonlibrary.txt";
            FileInfo encryptedFileInfo = ConfigFileLocator.GetFromAppConfigLocation(encryptedFile);

            FileInfo decryptedFileInfo = new FileInfo(encryptedFileInfo.DirectoryName + @"\" + toDecryptFile);
            EncryptionUtil.DecryptFile(encryptedFileInfo, decryptedFileInfo.FullName);
        }

        [Test]
        public void TestDecryptInvalidByteArray()
        {
            byte[] notParent = new byte[] { 1, 3, 4, 6, 8};

            Parent decryptedParent = (Parent)EncryptionUtil.Decrypt(notParent);
            Assert.Null(decryptedParent);
        }

        [Test]
        public void TestDecryptValidEncryptedByteArray()
        {
            Parent parent = new Parent { Name = "Hello", Child = new Child { Name = "World" } };
            byte[] encryptedParent = EncryptionUtil.Encrypt(parent);

            Parent decryptedParent = (Parent)EncryptionUtil.Decrypt(encryptedParent);
            Assert.NotNull(decryptedParent);
            Assert.AreEqual("Hello", decryptedParent.Name);
            Assert.AreEqual("World", decryptedParent.Child.Name);
        }

        [Test]
        public void TestEncryptFile()
        {
            const string toEncryptFile = "encryption_test_commonlibrary.txt";
            const string encryptedFile = "post-encryption_test_commonlibrary.txt";
            FileInfo toEncryptFileInfo = ConfigFileLocator.GetFromAppConfigLocation(toEncryptFile);

            Assert.NotNull(toEncryptFileInfo);

            FileInfo encryptedFileInfo = new FileInfo(toEncryptFileInfo.DirectoryName + @"\" + encryptedFile);
            EncryptionUtil.EncryptFile(toEncryptFileInfo, encryptedFileInfo.FullName);

            Assert.IsTrue(encryptedFileInfo.Exists);
        }

        [Test]
        public void TestEncryptionBoundary()
        {
            Assert.Null(EncryptionUtil.Encrypt(""));
            Assert.Null(EncryptionUtil.Decrypt(""));

            Assert.Null(EncryptionUtil.Encrypt(null));
            Assert.Null(EncryptionUtil.Decrypt((byte[])null));
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEncryptionBoundaryFileDecryptEmptyString()
        {
            const string toEncryptFile = "encryption_test_commonlibrary.txt";
            FileInfo toEncryptFileInfo = ConfigFileLocator.GetFromAppConfigLocation(toEncryptFile);

            const string toDecryptFile = "post-decryption_test_commonlibrary.txt";
            FileInfo decryptedFileInfo = new FileInfo(toEncryptFileInfo.DirectoryName + @"\" + toDecryptFile);
            EncryptionUtil.DecryptFile(decryptedFileInfo, "");
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEncryptionBoundaryFileDecryptNullFile()
        {
            EncryptionUtil.DecryptFile(null, "");
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEncryptionBoundaryFileEncryptEmptyString()
        {
            const string toEncryptFile = "encryption_test_commonlibrary.txt";
            FileInfo toEncryptFileInfo = ConfigFileLocator.GetFromAppConfigLocation(toEncryptFile);
            EncryptionUtil.EncryptFile(toEncryptFileInfo, "");
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEncryptionBoundaryFileEncryptNullFile()
        {
            EncryptionUtil.EncryptFile(null, "");
        }

        [Test]
        public void TestEncryptNonSerializableObjectInstance()
        {
            Stranger parent = new Stranger { Name = "Hello", Orphan = new Orphan { Name = "World" } };
            byte[] encryptedParent = EncryptionUtil.Encrypt(parent);

            Assert.Null(encryptedParent);
        }

        [Test]
        public void TestEncryptObjectInstance()
        {
            Parent parent = new Parent { Name = "Hello", Child = new Child { Name = "World" } };
            byte[] encryptedParent = EncryptionUtil.Encrypt(parent);

            Assert.NotNull(encryptedParent);
            Assert.IsTrue(encryptedParent.LongLength > 0);
            Assert.AreEqual(384, encryptedParent.LongLength);
        }

        [Test]
        public void TestEncryptStringInstance()
        {
            string encryptedHello = EncryptionUtil.Encrypt("hello");

            Assert.NotNull(encryptedHello);
            Assert.AreEqual("5ow9IiHrgxf70OPplWItuQ==", encryptedHello);

            string decryptedHello = EncryptionUtil.Decrypt(encryptedHello);
            Assert.AreEqual("hello", decryptedHello);
        }

        #endregion Methods
    }
}