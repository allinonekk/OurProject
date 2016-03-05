namespace CrimsonLogic.Legal.Binder.BackEnd.Tests
{
    using System;
    using System.IO;
    using System.Threading;

    using Common.Library.Binder;

    using log4net;
    using log4net.Config;

    using NUnit.Framework;

    using Quartz;

    public class DummyJob : IJob
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(DummyJob));

        #endregion Fields

        #region Methods

        public void Execute(JobExecutionContext context)
        {
            Logger.Debug("Executed dummy job!");
        }

        #endregion Methods
    }

    [TestFixture]
    class TestScheduler
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(TestScheduler));

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
        public void TestQuartzDataStore()
        {
            try
            {
                IScheduler scheduler = binder.GetInstance<IScheduler>();
                Logger.Debug("Using scheduler: " + scheduler);

                JobDetail jobDetail = new JobDetail("Test", null, typeof(DummyJob));
                Trigger trigger = TriggerUtils.MakeSecondlyTrigger();
                trigger.Name = "TestTrigger";
                scheduler.ScheduleJob(jobDetail, trigger);

                string[] jobs = scheduler.GetJobNames(null);
                bool exists = false;
                foreach (string job in jobs)
                {
                    if (job == "Test")
                    {
                        exists = true;
                    }
                }
                if (!exists)
                    scheduler.ScheduleJob(jobDetail, trigger);

                Logger.Debug("Scheduled job...");

                Thread.Sleep(10000);

                Logger.Debug("Deleting job...");
                scheduler.DeleteJob("Test", null);
            }
            catch (Exception exception)
            {
                Logger.Error("Exception encountered testing the Quartz datastore!", exception);
                Assert.Fail();
            }
        }

        #endregion Methods
    }
}