namespace CrimsonLogic.Common.Library.Tests
{
    using System.IO;

    using Binder.Windsor;

    using Castle.Windsor;

    using log4net.Config;

    using NUnit.Framework;

    public interface ITestObject
    {
        #region Methods

        void SayHello();

        #endregion Methods
    }

    public class TestObject : ITestObject
    {
        #region Properties

        public bool CleanedUp
        {
            get; private set;
        }

        public bool Inited
        {
            get; private set;
        }

        public bool Started
        {
            get; private set;
        }

        public bool Stopped
        {
            get; private set;
        }

        #endregion Properties

        #region Methods

        public void Cleanup()
        {
            CleanedUp = true;
        }

        public void Init()
        {
            Inited = true;
        }

        public void SayHello()
        {
            //do nothing
        }

        public void Start()
        {
            Started = true;
        }

        public void Stop()
        {
            Stopped = true;
        }

        #endregion Methods
    }

    [TestFixture]
    public class TestWindsorContainer
    {
        #region Fields

        private TestContainer testContainer;

        #endregion Fields

        #region Methods

        [SetUp]
        public void Setup()
        {
            XmlConfigurator.Configure(new FileInfo("log4net_commonlibrary.Config"));
            testContainer = new TestContainer();
        }

        [Test]
        public void TestLifeCycle()
        {
            ITestObject resolvedInstance = testContainer.GetInstance<ITestObject>();
            TestObject testObject = resolvedInstance as TestObject;
            Assert.IsNotNull(testObject);

            //Test that the instance was initialised.
            testContainer.Init();
            Assert.IsTrue(testObject.Inited);

            //Test that the instance was started.
            testContainer.Start();
            Assert.IsTrue(testObject.Started);

            //Test that the instance was stopped.
            testContainer.Stop();
            Assert.IsTrue(testObject.Stopped);

            //Test that the instance was cleaned up.
            testContainer.Cleanup();
            Assert.IsTrue(testObject.CleanedUp);

            Assert.AreEqual(1, testContainer.ComponentInstanceCount);
        }

        #endregion Methods
    }

    class TestContainer : AbstractWindsorAdapter
    {
        #region Constructors

        public TestContainer()
        {
            //this is absolutely required!
            DoInitialise();
        }

        #endregion Constructors

        #region Methods

        protected override FileInfo DoGetConfigFilePath()
        {
            return null;
        }

        protected override void DoInstall(IWindsorContainer container)
        {
            container.AddComponent("TestObject", typeof (ITestObject), typeof (TestObject));
        }

        #endregion Methods
    }
}