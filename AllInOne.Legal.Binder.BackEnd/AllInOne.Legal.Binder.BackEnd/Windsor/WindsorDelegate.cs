namespace AllInOne.Legal.Binder.BackEnd.Windsor
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Castle.Windsor;

    using AllInOne.Common.Library.Binder.Windsor;
    using AllInOne.Common.Library.MBean;

    using log4net;

    /// <summary>
    /// Description of WindsorDelegate.
    /// </summary>
    internal class WindsorDelegate : AbstractWindsorAdapter
    {
        #region Fields

        /// <summary>
        /// logging instance
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WindsorDelegate));

        private readonly List<IDisposable> disposableList = new List<IDisposable>();

        #endregion Fields

        #region Constructors

        public WindsorDelegate(MBeanServerExtension mbeanServerExtension)
        {
            if (Logger.IsDebugEnabled)
            {
                Logger.Debug("Initialising the BackEnd Windsor delegate...");
            }

            //Add an event listener in order to determine the component creation order
            Container.Kernel.ComponentCreated += (componentModel, instance) =>
                mbeanServerExtension.AddMBean(componentModel.Service.Name, instance);

            DoInitialise();
            Logger.Info("Created and initialised the Castle Windsor delegate!");
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Disposes a list of objects that have implemented the IDisposable interface but is not found in the container.
        /// </summary>
        public override void Cleanup()
        {
            base.Cleanup();

            disposableList.ForEach(disposable => disposable.Dispose());
            Logger.Info("Listed disposables have also been stopped inside the container!");
        }

        protected override FileInfo DoGetConfigFilePath()
        {
            Logger.InfoFormat("Looking for Castle configuration from the app.config/web.config file");
            return null;
        }

        protected override void DoInstall(IWindsorContainer container)
        {
            //ExternalExtension externalExtension = new ExternalExtension();
            //disposableList.Add(externalExtension);

            //Add more extensions here
            container.Install(
                
                new MediatorExtension(),
                new AllInOneExtension(),
                new BackEndExtension());
        }

        #endregion Methods
    }
}