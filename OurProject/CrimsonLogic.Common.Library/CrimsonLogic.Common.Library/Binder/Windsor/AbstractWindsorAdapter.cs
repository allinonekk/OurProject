namespace AllInOne.Common.Library.Binder.Windsor
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Castle.MicroKernel;
    using Castle.Windsor;
    using Castle.Windsor.Installer;

    using log4net;

    using Object;

    /// <summary>
    /// Implementation for the IBinder interface but adapting it for the Castle Windsor Container.
    /// Upon the instantiation of subclasses to <see cref="AbstractWindsorAdapter"/>, the Windsor 
    /// container will be created and subclasses are expected to invoke the <see cref="DoInitialise"/> method.
    /// </summary>
    public abstract class AbstractWindsorAdapter : IBinder, AbstractWindsorAdapterMBean
    {
        #region Fields

        /// <summary>
        /// Standard file for the Castle Windsor component configuration file.
        /// </summary>
        protected const string ConfigFile = "CastleWindsor.config";

        /// <summary>
        /// Instance of the WindsorContainer.
        /// </summary>
        protected IWindsorContainer Container;

        /// <summary>
        /// Logging instance.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AbstractWindsorAdapter));

        /// <summary>
        /// List of all instantiated objects in the order of component creation.
        /// </summary>
        private readonly List<object> instances = new List<object>();
        private readonly ObjectLifeCycler lifeCycleHandler;

        /// <summary>
        /// Flag to indicate whether the configuration of the Windsor container should be taken from the app.config/web.config.
        /// </summary>
        private bool appConfig;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Base class for using the Castle Windsor Container.
        /// </summary>
        protected AbstractWindsorAdapter()
        {
            lifeCycleHandler = new ObjectLifeCycler();

            //define the Container that will house all the various components
            Container = DoCreateContainer();
        }

        #endregion Constructors

        #region Properties

        public int ComponentInstanceCount
        {
            get { return instances.Count; }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Cleans up or releases all the resources prior to application cessation.
        /// Default method used for invocation is 'Cleanup'.
        /// Methods must have this signature 'public void Cleanup()'.
        /// </summary>
        public virtual void Cleanup()
        {
            instances.ForEach(instance => lifeCycleHandler.Cleanup(instance));
            Logger.Info("Object instances have been cleaned up inside the container!");

            Container.Dispose();
            Logger.Info("Castle Windsor container has been disposed!!");
        }

        /// <summary>
        /// Gets an instance of the supplied interface paramter.
        /// </summary>
        /// <typeparam name="T">Interface class.</typeparam>
        /// <returns>Instance of the interface class.</returns>
        public T GetInstance<T>()
        {
            try
            {
                T instance = Container.Resolve<T>();

                if (Logger.IsDebugEnabled)
                {
                    Logger.DebugFormat("Returning the instance: {0}", instance);
                }

                return instance;
            }
            catch (Exception exception)
            {
                string msg = string.Format("Problem encountered resolving type {0} because {1}", typeof (T), exception.Message);
                Logger.Error(msg, exception);
                throw new BinderException(msg);
            }
        }



        /// <summary>
        /// Initialises all the components.
        /// This method is anticipated to be rarely used since most components should suffice with a Start method invocation.
        /// However, there could be conceivable situations where a component must be initialised prior to any invocation of the Start method.
        /// Default method used for invocation is 'Init'.
        /// Methods must have this signature 'public void Init()'.
        /// </summary>
        public virtual void Init()
        {
            instances.ForEach(instance => lifeCycleHandler.Init(instance));
            Logger.Info("Object instances have been initialised inside the container!");
        }

        /// <summary>
        /// Starts all the components.
        /// Default method used for invocation is 'Start'.
        /// Methods must have this signature 'public void Start()'.
        /// </summary>
        public virtual void Start()
        {
            instances.ForEach(instance => lifeCycleHandler.Start(instance));
            Logger.Info("Object instances have been started inside the container!");
        }

        /// <summary>
        /// Stops all the components.
        /// Default method used for invocation is 'Stop'.
        /// Methods must have this signature 'public void Stop()'.
        /// </summary>
        public virtual void Stop()
        {
            instances.ForEach(instance => lifeCycleHandler.Stop(instance));
            Logger.Info("Object instances have been stopped inside the container!");
        }

        /// <summary>
        /// Creates the Castle Windsor Container.
        /// </summary>
        /// <returns></returns>
        protected IWindsorContainer DoCreateContainer()
        {
            IWindsorContainer windsorContainer;

            if (Logger.IsDebugEnabled)
            {
                Logger.Debug("Before creating the Container, we need to find the config file first...");
            }

            FileInfo configFileInfo = DoGetConfigFilePath();
            if (configFileInfo == null || !configFileInfo.Exists)
            {
                try
                {
                    Logger.Info("No config file supplied! Reverting to a standard Container, expecting to get configuration from either app.config/web.config");
                    appConfig = true;
                    windsorContainer = new WindsorContainer();
                }
                catch (Exception exception)
                {
                    Logger.InfoFormat("Since app.config/web.config was not configured, just creating a standard container! Reason-{0}",
                        exception.Message);
                    windsorContainer = new WindsorContainer();
                }
            }
            else
            {
                string filePath = configFileInfo.FullName;
                Logger.InfoFormat("Found the config file: {0}, augmenting the Container now...", filePath);
                windsorContainer = new WindsorContainer().Install(Configuration.FromXmlFile(filePath));
            }

            return windsorContainer;
        }

        /// <summary>
        /// Gets config file path.
        /// </summary>
        /// <returns>Null return will force the retrieval of configuration from the App.Config/Web.Config.</returns>
        protected abstract FileInfo DoGetConfigFilePath();

        /// <summary>
        /// Initialises the Windsor adapter.
        /// </summary>
        protected void DoInitialise()
        {
            //Create a list of component abstractions that are created by Windsor
            var handlers = new List<IHandler>();

            //Add an event listener in order to catch the registration events
            Container.Kernel.ComponentRegistered += (name, handler) => handlers.Add(handler);

            //Subclasses have to provide implementation to these component installation step
            DoInstall(Container);

            if (appConfig)
            {
                try
                {
                    Container.Install(Configuration.FromAppConfig());
                }
                catch (Exception exception)
                {
                    Logger.Error("Make sure that the app.config/web.config has the castle configuration!", exception);
                }
            }

            //From here on, we will attempt to resolve all the components and manage its lifecycle
            //Add an event listener in order to determine the component creation order
            Container.Kernel.ComponentCreated += (componentModel, instance) => instances.Add(instance);

            if (Logger.IsDebugEnabled)
            {
                Logger.DebugFormat("Attempting to resolve {0} component abstractions", handlers.Count);
            }

            try
            {
                // If the Container (kernel) cannot resolve the instance
                // an exception will be thrown and the test will fail
                handlers.ForEach(handler =>
                                     {
                                         var componentName = handler.ComponentModel.Service.Name;
                                         var type = handler.Service;
                                         var state = handler.CurrentState;

                                         if (Logger.IsDebugEnabled)
                                         {
                                             Logger.DebugFormat("Handler state for component: {0} is {1}", componentName, state);
                                         }

                                         if (state == HandlerState.Valid)
                                         {
                                             if (Logger.IsDebugEnabled)
                                             {
                                                 Logger.DebugFormat("Resolving component: {0} using {1}", componentName, type);
                                             }

                                             try
                                             {
                                                 Container.Kernel.Resolve(type);
                                             }
                                             catch (Exception exception)
                                             {
                                                 var msg = string.Format("Problem encountered while resolving component: {0} when using {1}",
                                                     componentName, type);
                                                 Logger.Error(msg, exception);
                                             }
                                         }
                                     });
            }
            catch (Exception exception)
            {
                Logger.Error("Problem encountered while dynamically resolving the components", exception);
            }

            //If we can get this far, it means there were no problems with component/service resolution.
            Logger.Info("Component/service resolution is completed. Awaiting lifecycle method invocation!");
            Logger.InfoFormat("Instances created: {0}", instances.Count);
        }

        /// <summary>
        /// Subclasses are expected to override this method and to install the components/services.
        /// </summary>
        /// <param name="container">Instance of the IWindsorContainer.</param>
        protected abstract void DoInstall(IWindsorContainer container);

        #endregion Methods


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Object"></param>
        public void ReleaseInstance<T>(T Object)
        {
            try
            {
                Container.Release(Object);
            }
            catch (Exception exception)
            {
                string msg = string.Format("Problem encountered release object of type {0} because {1}", typeof(T), exception.Message);
                Logger.Error(msg, exception);
                throw new BinderException(msg);
            }
        }
    }
}