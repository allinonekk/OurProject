namespace CrimsonLogic.Legal.Binder.BackEnd.Tests
{
    using System;
    using System.IO;
    using System.Threading;

    using Common.Library.Binder;

    using log4net.Config;

    using NUnit.Framework;

    using Quartz;

    [TestFixture]
    public class TestQuartzRuntime
    {
        #region Fields

        public static bool Triggered;

        private IBinder binder;

        #endregion Fields

        #region Methods

        [TestFixtureSetUp]
        public void Init()
        {
            XmlConfigurator.Configure(new FileInfo("log4net_binderbackend.config"));
            binder = BinderSingleton.Instance;
            binder.Init();
            binder.Start();
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            //Testing the Cleanup lifecycle
            binder.Stop();
            binder.Cleanup();
        }

        [Test]
        public void TestForQuartzTrigger()
        {
            IScheduler scheduler = binder.GetInstance<IScheduler>();

            JobDetail jobDetail = new JobDetail("TestQuartz", typeof(TestJob));
            DateTime dateTime = DateTime.UtcNow.AddSeconds(1);
            Trigger trigger = new SimpleTrigger("TestQuartzTrigger", dateTime);
            scheduler.ScheduleJob(jobDetail, trigger);

            Thread.Sleep(3000);

            Assert.IsTrue(Triggered);
        }

        #endregion Methods
    }

    class TestJob : IJob
    {
        #region Methods

        public void Execute(JobExecutionContext context)
        {
            TestQuartzRuntime.Triggered = true;
        }

        #endregion Methods
    }
}