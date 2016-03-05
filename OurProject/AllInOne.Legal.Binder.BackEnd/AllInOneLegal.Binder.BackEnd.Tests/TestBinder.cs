namespace CrimsonLogic.Legal.Binder.BackEnd.Tests
{
    using System;
    using System.IO;
    using System.Reflection;

    using AppMon;

    using CaseConverter.BackEnd;

    using Common.BarcodeUtility;
    using Common.Configuration;
    using Common.DMS;
    using Common.Library.Binder;
    using Common.PDFUtility;
    using Common.UserMessageStore;

    using DataSync.BackEnd;

    //using ExternalInterface.BackEnd;

    using FilingBroker.BackEnd;

    using Kernel;

    using log4net;
    using log4net.Config;

    using Mediator.BackEnd;

    using NUnit.Framework;

    using Quartz;

    using TaskList.BackEnd;

    //using IELS.BackEnd.Notification;
    [TestFixture]
    public class TestBinder
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(TestBinder));

        private IBinder binder;

        #endregion Fields

        #region Nested Interfaces

        interface IUnboundInstance
        {
        }

        #endregion Nested Interfaces

        #region Methods

        [TestFixtureSetUp]
        public void Init()
        {
            XmlConfigurator.Configure(new FileInfo("log4net_binderbackend.config"));
            LoadSqlLiteAssembly();
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
        public void TestBoundary()
        {
            Assert.Throws<BinderException>(() => binder.GetInstance<IUnboundInstance>());
        }

        [Test]
        public void TestForAppMon()
        {
            Logger.Debug("Testing for AppMon...");
            Assert.IsNotNull(binder.GetInstance<IAppMon>());
        }

        [Test]
        public void TestForBarcodeUtil()
        {
            Logger.Debug("Testing for BarcodeUtil...");
            Assert.IsNotNull(binder.GetInstance<IBarcodeUtil>());
        }

        [Test]
        public void TestForCaseConverter()
        {
            Logger.Debug("Testing for CaseConverter...");
            Assert.IsNotNull(binder.GetInstance<ICaseConverter>());
        }

        [Test]
        public void TestForCaseConverterMediator()
        {
            Logger.Debug("Testing for CaseConverterMediator...");
            Assert.IsNotNull(binder.GetInstance<ICaseConverterMediator>());
        }

        [Test]
        public void TestForConfiguration()
        {
            Logger.Debug("Testing for Configuration...");
            Assert.IsNotNull(binder.GetInstance<IConfiguration>());
        }

        [Test]
        public void TestForDataSync()
        {
            Logger.Debug("Testing for DataSync...");
            Assert.IsNotNull(binder.GetInstance<IDataSyncBackEnd>());
        }

        [Test]
        public void TestForDataSyncMediator()
        {
            Logger.Debug("Testing for DataSyncMediator..");
            Assert.IsNotNull(binder.GetInstance<IDataSyncMediator>());
        }

        [Test]
        public void TestForDms()
        {
            Logger.Debug("Testing for DMS...");
            Assert.IsNotNull(binder.GetInstance<IDocServices>());
        }

        [Test]
        public void TestForDmsMediator()
        {
            Logger.Debug("Testing for DMS Mediator...");
            Assert.IsNotNull(binder.GetInstance<IDMSMediator>());
        }

        [Test]
        public void TestForFilingBroker()
        {
            Logger.Debug("Testing for FilingBroker (BackEnd)...");
            Assert.IsNotNull(binder.GetInstance<IFilingBrokerBackEnd>());
        }

        [Test]
        public void TestForFilingBrokerMediator()
        {
            Logger.Debug("Testing for FilingBroker Mediator...");
            Assert.IsNotNull(binder.GetInstance<IFilingBrokerMediator>());
        }

        //[Test]
        //public void TestForIcaInterface()
        //{
        //    Logger.Debug("Testing for ICA Interface...");
        //    Assert.IsNotNull(binder.GetInstance<IICAInterface>());
        //}

        [Test]
        public void TestForKernel()
        {
            Logger.Debug("Testing for Kernel...");
            Assert.IsNotNull(binder.GetInstance<IKernel>());
        }

        [Test]
        public void TestForPdfUtil()
        {
            Logger.Debug("Testing for PdfUtil...");
            Assert.IsNotNull(binder.GetInstance<IPDFUtil>());
        }

        [Test]
        public void TestForQuartz()
        {
            Logger.Debug("Testing for Quartz...");
            Assert.IsNotNull(binder.GetInstance<IScheduler>());
        }

        [Test]
        public void TestForTasklist()
        {
            Logger.Debug("Testing for Tasklist...");
            Assert.IsNotNull(binder.GetInstance<ITasklist>());
        }

        [Test]
        public void TestForTasklistMediator()
        {
            Logger.Debug("Testing for TasklistMediator...");
            Assert.IsNotNull(binder.GetInstance<ITasklistMediator>());
        }

        [Test]
        public void TestForUserMessageStore()
        {
            Logger.Debug("Testing for UserMessageStore...");
            Assert.IsNotNull(binder.GetInstance<IUserMessageStore>());
        }

        //[Test]
        //public void TestForWorkflowEngine()
        //{
        //    Logger.Debug("Testing for WorkflowEngine...");
        //    Assert.IsNotNull(binder.GetInstance<IWorkFlowEngine>());
        //}

        [Test]
        public void TestForWorkflowEngineMediator()
        {
            Logger.Debug("Testing for WorkflowEngineMediator..");
            Assert.IsNotNull(binder.GetInstance<IWorkflowEngineMediator>());
        }

        private static string GetAppropriateSqlLiteAssembly()
        {
            string pa = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            string arch = ((String.IsNullOrEmpty(pa) || String.Compare(pa, 0, "x86", 0, 3, true) == 0) ? "86" : "64");

            // Since the Bin/External/System.Data.SQLite.dll assembly is already x64, let's avoid the copy.
            if (arch == "64")
            {
                return string.Empty;
            }
            return "System.Data.SQLite.x" + arch + ".DLL";
        }

        private static void LoadSqlLiteAssembly()
        {
            try
            {
                var dir = new Uri(Assembly.GetExecutingAssembly().CodeBase);
                var fi = new FileInfo(dir.AbsolutePath);
                string binFile = fi.Directory.FullName + "\\System.Data.SQLite.DLL";
                var appropriateAssembly = GetAppropriateSqlLiteAssembly();
                if (!string.IsNullOrEmpty(appropriateAssembly))
                {
                    File.Copy(GetAppropriateSqlLiteAssembly(), Uri.UnescapeDataString(binFile), true);
                }
            }
            catch (Exception exception)
            {
                Logger.Error("Problem encountered while loading the correct assembly!", exception);
            }
        }

        #endregion Methods
    }
}