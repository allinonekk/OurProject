namespace CrimsonLogic.Legal.Binder.BackEnd.Tests
{
    using System.IO;

    using Custom;

    using log4net.Config;

    using NUnit.Framework;

    [TestFixture]
    class TestConfigurationExtension
    {
        #region Methods

        [SetUp]
        public void Setup()
        {
            XmlConfigurator.Configure(new FileInfo("log4net_binderbackend.config"));
        }

        [Test]
        public void TestDatabaseExtension()
        {
            DatabaseConfigurationExtension extension = new DatabaseConfigurationExtension();
            Assert.AreEqual(196, extension.Values.Count);
        }

        #endregion Methods
    }
}