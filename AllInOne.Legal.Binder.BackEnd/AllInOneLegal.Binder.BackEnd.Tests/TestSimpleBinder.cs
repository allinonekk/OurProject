namespace CrimsonLogic.Legal.Binder.BackEnd.Tests
{
    using System.IO;

    using Common.Library.Binder;

    using log4net;
    using log4net.Config;

    using Mediator.BackEnd;

    using NUnit.Framework;

    [TestFixture]
    public class TestSimpleBinder
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(TestSimpleBinder));

        private IBinder binder;

        #endregion Fields

        #region Methods

        [SetUp]
        public void Setup()
        {
            XmlConfigurator.Configure(new FileInfo("log4net_binderfrontend.config"));
            BinderSingleton.Simple = true;
            binder = BinderSingleton.Instance;
            //Testing the Init lifecycle
            binder.Init();
        }

        [TearDown]
        public void TearDown()
        {
            //No teardown because the binder instance will be a null reference once this TestSimpleBinder is run in succession after TestBinder.
            //binder.Stop();
            //binder.Cleanup();
        }

        [Test]
        public void TestConfigFile()
        {
            Logger.Debug("Testing for components loaded from the config file.");
            Assert.NotNull(binder.GetInstance<ITestComponent>());          
            //Make sure that the programmatic configuration was excluded.
            Assert.Throws<BinderException>(() => binder.GetInstance<ITasklistMediator>());
        }

        #endregion Methods
    }
}