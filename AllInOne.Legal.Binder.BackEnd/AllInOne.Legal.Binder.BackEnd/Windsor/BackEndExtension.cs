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
    using AllInOne.Legal.Mediator.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Impl;
    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;

    
   
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

            container.Register(
                Component.For<IPatientInfoMapper>().ImplementedBy<PatientInfoMapper>().LifeStyle.Singleton,
                Component.For<IPatientMediator>().ImplementedBy<PatientMediatorImpl>().LifeStyle.Singleton           
                );
        }

        #endregion Methods
    }
}