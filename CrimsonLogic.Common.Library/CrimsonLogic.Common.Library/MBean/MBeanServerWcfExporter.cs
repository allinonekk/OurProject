namespace AllInOne.Common.Library.MBean
{
    using System;
    using System.ServiceModel;
    using System.Threading;

    using log4net;

    using NetMX.Remote.ServiceModel;

    ///<summary>
    ///</summary>
    public class MBeanServerWcfExporter
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof (MBeanServerWcfExporter));

        private readonly ServiceHost host;

        #endregion Fields

        #region Constructors

        ///<summary>
        ///</summary>
        ///<param name="exportedMBeanServer"></param>
        public MBeanServerWcfExporter(IMBeanServerContract exportedMBeanServer)
        {
            host = new ServiceHost(exportedMBeanServer);
        }

        #endregion Constructors

        #region Methods

        ///<summary>
        ///</summary>
        public void Start()
        {
            new Thread(() =>
                           {
                               try
                               {
                                   Logger.Debug("Spawned a thread to start the WCF service for MBeanServer!");
                                   host.Open();
                               }
                               catch (Exception exception)
                               {
                                   Logger.Error("Problem starting the MBeanServer WCF ServiceHost!", exception);
                               }
                           }
                ).Start();
        }

        ///<summary>
        ///</summary>
        public void Stop()
        {
            if (host != null)
            {
                try
                {
                    host.Close();
                }
                catch (Exception exception)
                {
                    Logger.Error("Problem stopping the MBeanServer WCF ServiceHost!", exception);
                }
            }
        }

        #endregion Methods
    }
}