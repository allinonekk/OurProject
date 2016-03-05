namespace CrimsonLogic.Common.Library.Tests
{
    using System;
    using System.IO;

    using File;

    using log4net.Config;

    using NUnit.Framework;

    [TestFixture]
    public class TestConfigFileLocator
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
        public void TestAppConfigPath()
        {
            FileInfo fileInfo = ConfigFileLocator.GetFromAppConfigLocation("log4net_commonlibrary.config");

            Assert.NotNull(fileInfo);
            Assert.IsTrue(fileInfo.Exists);
        }

        [Test]
        public void TestBoundary()
        {
            Assert.Throws<ArgumentNullException>(() => ConfigFileLocator.GetFromAppConfigLocation(""));
            Assert.Throws<ArgumentNullException>(() => ConfigFileLocator.GetFromAppConfigLocation("", "HelloWorld"));
            Assert.Throws<ArgumentNullException>(() => ConfigFileLocator.GetFromAppConfigLocation("HelloWorld", ""));
        }

        /// <summary>
        /// For this test to work, there is a need to copy the log4net config file to the relative
        /// folder.
        /// </summary>
        [Test]
        public void TestRelativePath()
        {
            const string fileName = "log4net_commonlibrary.config";

            FileInfo fileInfo = ConfigFileLocator.GetFromAppConfigLocation(fileName);
            Assert.NotNull(fileInfo);

            //Copy the config file to the subfolder
            {
                string sourcePath = fileInfo.DirectoryName;
                string targetPath = sourcePath + @"\Config";
                // To copy a folder's contents to a new location:
                // Create a new target folder, if necessary.
                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }

                // Use Path class to manipulate file and directory paths.
                {
                    string sourceFile = Path.Combine(sourcePath, fileName);
                    string destFile = Path.Combine(targetPath, fileName);

                    // To copy a file to another location and
                    // overwrite the destination file if it already exists.
                    File.Copy(sourceFile, destFile, true);
                }
            }

            FileInfo configInfo = ConfigFileLocator.GetFromAppConfigLocation("Config", "log4net_commonlibrary.config");
            Assert.NotNull(configInfo);
            Assert.IsTrue(configInfo.Exists);

            configInfo = ConfigFileLocator.GetFromAppConfigLocation(@"\Config", "log4net_commonlibrary.config");
            Assert.NotNull(configInfo);
            Assert.IsTrue(configInfo.Exists);

            configInfo = ConfigFileLocator.GetFromAppConfigLocation(@"Config\", "log4net_commonlibrary.config");
            Assert.NotNull(configInfo);
            Assert.IsTrue(configInfo.Exists);

            configInfo = ConfigFileLocator.GetFromAppConfigLocation(@"\Config\", "log4net_commonlibrary.config");
            Assert.NotNull(configInfo);
            Assert.IsTrue(configInfo.Exists);
            Assert.AreEqual("log4net_commonlibrary.config", configInfo.Name);

            configInfo = ConfigFileLocator.GetFromAppConfigLocation(@"NonExist\", "log4net_commonlibrary.config");
            Assert.IsFalse(configInfo.Exists);
        }

        #endregion Methods
    }
}