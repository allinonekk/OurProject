namespace AllInOne.Common.Library.MBean
{
    using System;
    using System.Threading;

    using log4net;

    using NetMX;
    using NetMX.Remote;
    using NetMX.Remote.Jsr262;

    ///<summary>
    ///</summary>
    public class MBeanServerJsr262Exporter
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof (MBeanServerJsr262Exporter));

        private readonly IMBeanServer mbeanServer;

        private static bool serverStarted;

        private INetMXConnectorServer jsr262ConnectorServer;

        #endregion Fields

        #region Constructors

        ///<summary>
        ///</summary>
        ///<param name="mbeanServer"></param>
        public MBeanServerJsr262Exporter(IMBeanServer mbeanServer)
        {
            this.mbeanServer = mbeanServer;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Starts this MBeanServer.
        /// </summary>
        public void Start()
        {
            jsr262ConnectorServer = DoCreateJsr262Server(mbeanServer);

            // A thread must be spawned else the flow will block here when the server starts!
            Logger.Info("Spawning a thread to non-block the application when MBeanServer is started...");
            var thread = new Thread(() =>
            {
                try
                {
                    serverStarted = true;
                    Logger.Info("Started the MBeanServer with the JSR262 connector!");
                    jsr262ConnectorServer.Start();
                }
                catch (Exception exception)
                {
                    Logger.Error("Problem starting the MBeanServer with the JSR262 connector!", exception);
                    serverStarted = false;
                }
            });
            thread.Start();
        }

        /// <summary>
        /// Stops this MBeanServer.
        /// </summary>
        public void Stop()
        {
            try
            {
                if (serverStarted)
                {
                    jsr262ConnectorServer.Stop();
                    jsr262ConnectorServer.Dispose();
                    Logger.Info("Stopped the MBeanServer!");
                }
            }
            catch (Exception exception)
            {
                Logger.Error("Problem with stopping the MBeanServer!", exception);
            }
        }

        private static INetMXConnectorServer DoCreateJsr262Server(IMBeanServer server)
        {
            const string uri = "http://localhost:8888/MBeanServer";
            Logger.InfoFormat("URI used to establish the JSR262 MBeanServer: {0}", uri);

            var serviceUrl = new Uri(uri);
            return new Jsr262ConnectorServerProvider().NewNetMXConnectorServer(serviceUrl, server);
        }

        #endregion Methods
    }
}