namespace AllInOne.Legal.Binder.BackEnd.Windsor
{
    //Need to be uncommented upon launch of AppMon
    //using AppMon;
    //using AppMon.Impl;
    //using AppMon.Repository;

    using Castle.MicroKernel;
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;

    

    using Custom;

   

    

    using log4net;

    /// <summary>
    /// Description of AllInOneExtension.
    /// </summary>
    internal class AllInOneExtension : IWindsorInstaller
    {
        #region Fields

        /// <summary>
        /// logging instance
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AllInOneExtension));

        #endregion Fields

        #region Methods

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            if (Logger.IsDebugEnabled)
            {
                Logger.Debug("Adding the AllInOne components now...");
            }

            //FIXME - Remove the reference to IELS.BackEnd.DMS once the refactoring is complete.

            //container.Register(
            //    Component.For<IKeyValueExtension>().Instance(new DatabaseConfigurationExtension()).Named("dbextension"),
            //    Component.For<IDMSMediator>().ImplementedBy<DocumentServiceMediator>().LifeStyle.Singleton
            //    //Uncomment below lines for AppMon
            //    //,Component.For<IRepository>().ImplementedBy<SubsonicRepository>().Parameters(
            //    //Parameter.ForKey("runMigrations").Eq("true")).LifeStyle.Singleton
            //    );

            //container.Register(
            //    Component.For<IConfiguration>().ImplementedBy<DefaultConfigurationImpl>()
            //        .ServiceOverrides(ServiceOverride.ForKey("extensions").Eq(new[] { "dbextension" })).LifeStyle.Singleton,
            //    Component.For<Kernel.IKernel>().ImplementedBy<DefaultKernelImpl>().LifeStyle.Singleton,
            //    Component.For<IUserMessageStore>().ImplementedBy<DefaultUserMessageStoreImpl>().LifeStyle.Singleton,
            //    Component.For<IBarcodeUtil>().ImplementedBy<DefaultBarcodeUtilImpl>().LifeStyle.Singleton,
            //    Component.For<IPDFUtil>().ImplementedBy<DefaultPDFUtilImpl>().LifeStyle.Singleton,
            //    Component.For<IDocServices>().ImplementedBy<DocServices>().LifeStyle.Singleton
            //    //Uncomment below lines for AppMon
            //    //,Component.For<IAppMon>().ImplementedBy<DefaultAppMonImpl>().LifeStyle.Singleton
            //    );
        }

        #endregion Methods
    }
}