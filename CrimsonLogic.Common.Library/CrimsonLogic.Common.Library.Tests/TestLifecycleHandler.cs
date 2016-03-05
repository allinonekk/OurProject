namespace CrimsonLogic.Common.Library.Tests
{
    using System.IO;

    using CrimsonLogic.Common.Library.Object;

    using log4net.Config;

    using Moq;

    using NUnit.Framework;

    public interface ILifecycle
    {
        #region Methods

        void Cleanup();

        void Init();

        void Start();

        void Stop();

        #endregion Methods
    }

    [TestFixture]
    public class TestLifecycleHandler
    {
        #region Fields

        private Mock<ILifecycle> mockLifecycleHandler;
        private ObjectLifeCycler objectLifeCycler;

        #endregion Fields

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        [TestFixtureSetUp]
        public void Init()
        {
            XmlConfigurator.Configure(new FileInfo("log4net_commonlibrary.Config"));
        }

        [SetUp]
        public void Setup()
        {
            mockLifecycleHandler = new Mock<ILifecycle>();
            objectLifeCycler = new ObjectLifeCycler();
        }

        [Test]
        public void TestBoundary()
        {
            //No exceptions are expected if there are null values put in...

            objectLifeCycler.Init(null);
            objectLifeCycler.Start(null);
            objectLifeCycler.Stop(null);
            objectLifeCycler.Cleanup(null);
        }

        [Test]
        public void TestObjectCleanup()
        {
            objectLifeCycler.Cleanup(mockLifecycleHandler.Object);

            mockLifecycleHandler.Verify(lifeCycle => lifeCycle.Cleanup(), Times.AtMostOnce());
        }

        [Test]
        public void TestObjectInit()
        {
            objectLifeCycler.Init(mockLifecycleHandler.Object);

            mockLifecycleHandler.Verify(lifeCycle => lifeCycle.Init(), Times.AtMostOnce());
        }

        [Test]
        public void TestObjectStart()
        {
            objectLifeCycler.Start(mockLifecycleHandler.Object);

            mockLifecycleHandler.Verify(lifeCycle => lifeCycle.Start(), Times.AtMostOnce());
        }

        [Test]
        public void TestObjectStop()
        {
            objectLifeCycler.Stop(mockLifecycleHandler.Object);

            mockLifecycleHandler.Verify(lifeCycle => lifeCycle.Stop(), Times.AtMostOnce());
        }

        #endregion Methods
    }
}