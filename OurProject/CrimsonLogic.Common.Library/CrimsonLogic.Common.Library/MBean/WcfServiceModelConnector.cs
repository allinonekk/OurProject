namespace AllInOne.Common.Library.MBean
{
    using System;
    using System.ServiceModel;

    using NetMX;
    using NetMX.Remote;
    using NetMX.Remote.ServiceModel;

    ///<summary>
    ///</summary>
    public class WcfServiceModelConnector : INetMXConnector
    {
        #region Fields

        private readonly string configurationName;

        private WcfServiceModelMBeanServerConnection connection;
        private Guid connectionId;
        private bool disposed;
        private IMBeanServerContract proxy;

        #endregion Fields

        #region Constructors

        ///<summary>
        ///</summary>
        ///<param name="configurationName"></param>
        public WcfServiceModelConnector(string configurationName)
        {
            this.configurationName = configurationName;
        }

        #endregion Constructors

        #region Properties

        ///<summary>
        ///</summary>
        public string ConnectionId
        {
            get { return connectionId.ToString(); }
        }

        ///<summary>
        ///</summary>
        public IMBeanServerConnection MBeanServerConnection
        {
            get { return connection; }
        }

        #endregion Properties

        #region Methods

        ///<summary>
        ///</summary>
        public void Close()
        {
            var co = (ICommunicationObject)proxy;
            if (co != null)
            {
                try
                {
                    if (co.State != CommunicationState.Faulted)
                    {
                        co.Close();
                    }
                    else
                    {
                        co.Abort();
                    }
                }
                catch (CommunicationException)
                {
                    co.Abort();
                }
                catch (TimeoutException)
                {
                    co.Abort();
                }
                catch (Exception)
                {
                    co.Abort();
                    throw;
                }
                finally
                {
                    proxy = null;
                    connection = null;
                }
            }
        }

        ///<summary>
        ///</summary>
        ///<param name="credentials"></param>
        public void Connect(object credentials)
        {
            // Create a channel factory.
            var factory = new ChannelFactory<IMBeanServerContract>(configurationName);

            // Create a channel.
            proxy = factory.CreateChannel();
            connectionId = Guid.NewGuid();
            connection = new WcfServiceModelMBeanServerConnection(proxy);
        }

        public void Dispose()
        {
            if (!disposed)
            {
                try
                {
                    Close();
                }
                finally
                {
                    disposed = true;
                }
            }
        }

        #endregion Methods
    }
}