namespace AllInOne.Common.Library.MBean
{
    using System.Collections.Generic;

    using log4net;

    using NetMX;
    using NetMX.Remote.ServiceModel;

    /// <summary>
    /// 
    /// </summary>
    public class ManagedMBeanServerWcfService : IMBeanServerContract
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof (ManagedMBeanServerWcfService));

        private readonly IMBeanServerContract contractDelegate;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedMBeanServerWcfService"/> class.
        /// </summary>
        public ManagedMBeanServerWcfService()
        {
            var mbeanServer = MBeanServerExtension.Instance.MBeanServer;
            contractDelegate = new MBeanServerService(mbeanServer);
            Logger.InfoFormat("Created a WCF service based on the MBeanServer contract: {0}", mbeanServer);
        }

        #endregion Constructors

        #region Methods

        public void AddNotificationListener(ObjectName name, ObjectName listener)
        {
            contractDelegate.AddNotificationListener(name, listener);
        }

        public ObjectInstance CreateMBean(string className, ObjectName name, object[] arguments)
        {
            return contractDelegate.CreateMBean(className, name, arguments);
        }

        public object GetAttribute(ObjectName name, string attributeName)
        {
            return contractDelegate.GetAttribute(name, attributeName);
        }

        public IList<AttributeValue> GetAttributes(ObjectName name, string[] attributeNames)
        {
            return contractDelegate.GetAttributes(name, attributeNames);
        }

        public string GetDefaultDomain()
        {
            return contractDelegate.GetDefaultDomain();
        }

        public IList<string> GetDomains()
        {
            return contractDelegate.GetDomains();
        }

        public int GetMBeanCount()
        {
            return contractDelegate.GetMBeanCount();
        }

        public MBeanInfo GetMBeanInfo(ObjectName name)
        {
            return contractDelegate.GetMBeanInfo(name);
        }

        public object Invoke(ObjectName name, string operationName, object[] arguments)
        {
            return contractDelegate.Invoke(name, operationName, arguments);
        }

        public bool IsInstanceOf(ObjectName name, string className)
        {
            return contractDelegate.IsInstanceOf(name, className);
        }

        public bool IsRegistered(ObjectName name)
        {
            return contractDelegate.IsRegistered(name);
        }

        public IEnumerable<ObjectName> QueryNames(ObjectName name, QueryExp query)
        {
            return contractDelegate.QueryNames(name, query);
        }

        public void RemoveNotificationListener(ObjectName name, ObjectName listener)
        {
            contractDelegate.RemoveNotificationListener(name, listener);
        }

        public void SetAttribute(ObjectName name, string attributeName, object value)
        {
            contractDelegate.SetAttribute(name, attributeName, value);
        }

        public IList<AttributeValue> SetAttributes(ObjectName name, IEnumerable<AttributeValue> namesAndValues)
        {
            return contractDelegate.SetAttributes(name, namesAndValues);
        }

        public void UnregisterMBean(ObjectName name)
        {
            contractDelegate.UnregisterMBean(name);
        }

        #endregion Methods
    }
}