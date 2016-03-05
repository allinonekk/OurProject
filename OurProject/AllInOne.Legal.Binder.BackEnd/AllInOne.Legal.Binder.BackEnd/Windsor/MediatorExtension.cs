namespace AllInOne.Legal.Binder.BackEnd.Windsor
{
    using Castle.MicroKernel;
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;

    using log4net;

  
    /// <summary>
    /// Description of MediatorExtension.
    /// </summary>
    internal class MediatorExtension : IWindsorInstaller
    {
        #region Fields

        /// <summary>
        /// logging instance
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MediatorExtension));

        #endregion Fields

        #region Methods

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            if (Logger.IsDebugEnabled)
            {
                Logger.Debug("Adding the BackEnd mediator components now...");
            }

            //These are Mediators used by other services.
            //container.Register(
            //    Component.For<ICaseConverterMediator>().ImplementedBy<CaseConverterMediatorImpl>().LifeStyle.Singleton,
            //    Component.For<ITasklistMediator>().ImplementedBy<TasklistMediatorImpl>().LifeStyle.Singleton,
            //    Component.For<IFilingBrokerMediator>().ImplementedBy<FilingBrokerMediatorImpl>().LifeStyle.Singleton,
            //    Component.For<IICAInterfaceMediator>().ImplementedBy<ICAInterfaceMediatorImpl>().LifeStyle.Singleton,
            //    Component.For<IWorkflowEngineMediator>().ImplementedBy<WorkflowEngineMediatorImpl>().LifeStyle.Singleton,
            //    Component.For<IDataSyncMediator>().ImplementedBy<DataSyncMediatorImpl>().LifeStyle.Singleton,
            //    Component.For<IEnforcementMediator>().ImplementedBy<EnforcementMediatorImpl>().LifeStyle.Singleton,
            //    Component.For<IBackEndMediator>().ImplementedBy<BackEndMediatorImpl>().LifeStyle.Singleton
            //    );

            //These are services used internal by the Mediators.
            //container.Register(
            //    Component.For<IDocumentInfo>().ImplementedBy<DocumentInfoImpl>().LifeStyle.Singleton,
            //    );
        }

        #endregion Methods
    }
}