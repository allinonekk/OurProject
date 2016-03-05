namespace AllInOne.Legal.Binder.BackEnd
{
    using System;

    using AllInOne.Common.Library.Binder;
    using AllInOne.Common.Library.Binder.Windsor;
    using AllInOne.Common.Library.MBean;

    using Custom;

    using log4net;

    using Windsor;

    /// <summary>
    /// Singleton instance of the IBinder interface.
    /// <br/>
    /// The list of BackEnd services available:
    /// <ol>
    /// <li>Quartz.IScheduler</li>
    /// <li>AllInOne.AllInOne.UserMessageStore.IUserMessageStore</li>
    /// <li>AllInOne.AllInOne.Configuration.IConfiguration</li>
    /// <li>AllInOne.AllInOne.BarcodeUtil.IBarcodeUtil</li>
    /// <li>AllInOne.AllInOne.PDFUtil.IPDFUtil</li>
    /// <li>AllInOne.AllInOne.DMS.IDocServices</li>
    /// <li>AllInOne.AllInOne.DMS.IDMSMediator</li>
    /// <li>AllInOne.Legal.CaseConverter.BackEnd.ICaseConverter</li>
    /// <li>AllInOne.Legal.Mediator.BackEnd.ICaseConverterMediator</li>
    /// <li>AllInOne.Legal.Mediator.BackEnd.IICAInterfaceMediator</li>
    /// <li>AllInOne.Legal.Mediator.BackEnd.ITasklistMediator</li>
    /// <li>AllInOne.Legal.Mediator.BackEnd.IFilingBrokerMediator</li>
    /// <li>AllInOne.Legal.Mediator.BackEnd.IWorkflowEngineMediator</li>
    /// <li>AllInOne.Legal.Mediator.BackEnd.IDataSyncMediator</li>
    /// <li>AllInOne.Legal.Tasklist.BackEnd.ITasklist</li>
    /// <li>AllInOne.Legal.FilingBroker.BackEnd.IFilingBrokerBackEnd</li>
    /// <li>AllInOne.Legal.ExternalInterface.BackEnd.IIcaInterface</li>
    /// <li>AllInOne.Legal.WorkFlowEngine.BackEnd.IWorkFlowEngine</li>
    /// <li>AllInOne.Legal.DataSync.BackEnd.IDataSyncBackEnd</li>
    /// <li>AllInOne.Legal.AppMon.IAppMon</li>
    /// </ol>
    /// <br/>
    /// This Binder instance will incorporate a runtime instance of the NetMX MBeanServer.
    /// In effect, all components realized by the binding process are also injected into the NetMX MBeanServer.
    /// If the instances are MBean-compliant, then it shall be made available for external management and access.
    /// Access to the hosted MBeans is currently only available via the JSR262-standards - i.e., via the JConsole
    /// using the Web Service standard for invoking of MBean instances. The URL for the hosted MBeanServer is
    /// <c>service:jmx:ws://localhost:8888/MBeanServer</c>.
    /// </summary>
    public sealed class BinderSingleton : IBinder
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof (BinderSingleton));
        private static readonly object SyncRoot = new Object();

        private readonly IBinder binderDelegate;

        private static volatile BinderSingleton instance;

        #endregion Fields

        #region Constructors

        private BinderSingleton()
        {
            try
            {
                if (Simple)
                {
                    Logger.Info("BackEnd Binder is using the Simple Windsor Delegate.");
                    binderDelegate = new SimpleWindsorAdapter();
                }
                else
                {
                    Logger.Info("BackEnd Binder is using the Windsor Delegate...");
                    MBeanServerExtension mbeanServerExtension = MBeanServerExtension.Instance;
                    binderDelegate = new WindsorDelegate(mbeanServerExtension);

                    mbeanServerExtension.AddMBean("WindsorContainer", binderDelegate);

                    //Stopped exporting the MBeanServer via the JSR262 connection because of inability to make it work!
                    //It was working but due to some configuration change on the MOSS, this stopped.
                    //Given this, reverted to the WCF exported service of the MBeanServer!
                    //jsr262Exporter = new MBeanServerJsr262Exporter(mbeanServerExtension.MBeanServer);
                    //jsr262Exporter.Start();
                    Logger.Info("Added windsor container to the MBeanServer and started server!");
                }
            }
            catch (Exception exception)
            {
                Logger.Fatal("Something serious happened!", exception);
            }
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        public static BinderSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new BinderSingleton();
                        }
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BinderSingleton"/> is simple.
        /// When set to simple, the BinderSingleton will switch to the simplest implementation of the Castle Windsor adapter.
        /// This simple adapter will bypass the Fluent registration and expect all the components to be registered from the web.config or app.config.
        /// </summary>
        /// <value><c>true</c> if simple; otherwise, <c>false</c>.</value>
        public static bool Simple
        {
            private get; set;
        }

        #endregion Properties

        #region Methods

        public void Cleanup()
        {
            binderDelegate.Cleanup();
            instance = null;
        }

        public T GetInstance<T>()
        {
            if (Logger.IsDebugEnabled)
            {
                Logger.DebugFormat("Requesting instance of type: {0}", typeof(T));
            }
            return binderDelegate.GetInstance<T>();
        }

        public void Init()
        {
            binderDelegate.Init();
        }

        public void Start()
        {
            binderDelegate.Start();
           // AppDomainHandler.Init(binderDelegate);
        }

        public void Stop()
        {
            binderDelegate.Stop();
        }

        #endregion Methods


        public void ReleaseInstance<T>(T Object)
        {
            binderDelegate.ReleaseInstance<T>(Object);
        }
    }
}