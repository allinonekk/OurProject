namespace AllInOne.Legal.Binder.BackEnd.Windsor
{
    //using CaseConverter.BackEnd;
    //using CaseConverter.BackEnd.Impl;

    using Castle.MicroKernel;
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;

    //using DataSync.BackEnd;

    //using ExternalInterface.BackEnd;
    //using ExternalInterface.BackEnd.Impl;

    using log4net;

    
   
    /// <summary>
    /// Description of BackEndExtension.
    /// </summary>
    public  class BackEndExtension : IWindsorInstaller
    {
        #region Fields

        /// <summary>
        /// logging instance
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(BackEndExtension));

        #endregion Fields

        #region Methods

        public virtual void Install(IWindsorContainer container, IConfigurationStore store)
        {
            if (Logger.IsDebugEnabled)
            {
                Logger.Debug("Adding the BackEnd components now...");
            }

            //container.Register(
            //    Component.For<ITasklist>().ImplementedBy<DefaultTasklistImpl>().LifeStyle.Singleton,
            //    Component.For<ICaseConverter>().ImplementedBy<DefaultCaseConverterImpl>().LifeStyle.Singleton,
            //    Component.For<IFilingBroker, IFilingBrokerBackEnd>().ImplementedBy<DefaultFilingBrokerBackEndImpl>().LifeStyle.Singleton,
            //   // Component.For<IICAInterface>().ImplementedBy<DefaultICAInterfaceImpl>().LifeStyle.Singleton,//commented to get binder.backend used in Externalinterface
            //    //Component.For<IWorkFlowEngine>().ImplementedBy<DefaultWorkFlowEngineImpl>().LifeStyle.Singleton,
            //    Component.For<IDataSyncBackEnd>().ImplementedBy<DefaultDataSyncBackEndImpl>().LifeStyle.Singleton,
            //    Component.For<IOutgoingCorrespondence>().ImplementedBy<OutgoingCorrespondenceImpl>().LifeStyle.Singleton,
            //    Component.For<IEnforcementFactory>().ImplementedBy<EnforcementFactoryImpl>().LifeStyle.Singleton,
            //    Component.For<IQuerySpectification>().ImplementedBy<QuerySpecification>().LifeStyle.Singleton            
            //    );
        }

        #endregion Methods
    }
}