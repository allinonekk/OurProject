namespace AllInOne.Common.Library.MBean
{
    using System;

    using log4net;

    using NetMX;

    /// <summary>
    /// A convenience class to add an MBeanServer capability to an application.
    /// </summary>
    public sealed class MBeanServerExtension
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(MBeanServerExtension));
        private static readonly object SyncRoot = new Object();

        private static volatile MBeanServerExtension instance;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new objectInstance of the <see cref="MBeanServerExtension"/> class.
        /// </summary>
        private MBeanServerExtension()
        {
            MBeanServer = new NetMX.Server.MBeanServerBuilder().NewMBeanServer("iELS");

            Logger.Info("Created the MBeanServer Extension!");
        }

        #endregion Constructors

        #region Properties

        ///<summary>
        ///</summary>
        public static MBeanServerExtension Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new MBeanServerExtension();
                        }
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Gets or sets an objectInstance of the MBean server.
        /// </summary>
        /// <value>The MBean server.</value>
        public IMBeanServer MBeanServer
        {
            get; private set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Adds the MBean objectInstance.
        /// </summary>
        /// <param name="componentName">Name of the component.</param>
        /// <param name="objectInstance">The objectInstance.</param>
        /// <returns>
        ///     <c>true</c> if registration was successful inside the MBeanServer and false for otherwise.
        /// </returns>
        public bool AddMBean(string componentName, object objectInstance)
        {
            if (string.IsNullOrEmpty(componentName))
            {
                Logger.Warn("Problem exists - component name is either a null or empty string!");
                return false;
            }

            if (objectInstance == null)
            {
                Logger.Warn("Problem exists - MBean objectInstance cannot be a null!");
                return false;
            }
            try
            {
                var name = new ObjectName("MBeanServer:component=" + componentName);
                MBeanServer.RegisterMBean(objectInstance, name);
                Logger.InfoFormat("Registered MBean {0} using {1} into the server.",
                    componentName, objectInstance);
                return true;
            }
            catch (Exception)
            {
                // Even though exceptions have been thrown it is not considered as show-stoppers or issues.
                // Making components as MBean-compliant interfaces is currently optional.
                Logger.InfoFormat("Problem registering {0} using {1} into the MBeanServer!",
                    componentName, objectInstance);
            }
            return false;
        }

        /// <summary>
        /// Removes the MBean instance.
        /// </summary>
        /// <param name="componentName">Name of the component.</param>
        /// <returns></returns>
        public bool RemoveMBean(string componentName)
        {
            if (string.IsNullOrEmpty(componentName))
            {
                Logger.Warn("Problem exists - component name is either a null or empty string!");
                return false;
            }

            try
            {
                var name = new ObjectName("MBeanServer:component=" + componentName);
                MBeanServer.UnregisterMBean(name);
                Logger.InfoFormat("Unregistered MBean {0} from the server.", componentName);
                return true;
            }
            catch (Exception)
            {
                // Even though exceptions have been thrown it is not considered as show-stoppers or issues.
                // Making components as MBean-compliant interfaces is currently optional.
                Logger.InfoFormat("Problem unregistering {0} from the MBeanServer!", componentName);
            }
            return false;
        }

        #endregion Methods
    }
}