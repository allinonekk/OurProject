namespace AllInOne.Common.Library.MBean
{
    using System;
    using System.Collections.Generic;

    using NetMX;
    using NetMX.Remote.ServiceModel;

    internal sealed class WcfServiceModelMBeanServerConnection : IMBeanServerConnection
    {
        #region Fields

        private readonly IMBeanServerContract proxy;

        #endregion Fields

        #region Constructors

        public WcfServiceModelMBeanServerConnection(IMBeanServerContract proxy)
        {
            this.proxy = proxy;
        }

        #endregion Constructors

        #region Methods

        public void AddNotificationListener(ObjectName name, NotificationCallback callback, NotificationFilterCallback filterCallback, object handback)
        {
            throw new InvalidOperationException("This operation is not supported by ServiceModel connector.");
        }

        public void AddNotificationListener(ObjectName name, ObjectName listener, NotificationFilterCallback filterCallback, object handback)
        {
            throw new InvalidOperationException("This operation is not supported by ServiceModel connector.");
        }

        public ObjectInstance CreateMBean(string className, ObjectName name, object[] arguments)
        {
            return proxy.CreateMBean(className, name, arguments);
        }

        public object GetAttribute(ObjectName name, string attributeName)
        {
            return proxy.GetAttribute(name, attributeName);
        }

        public IList<AttributeValue> GetAttributes(ObjectName name, string[] attributeNames)
        {
            return proxy.GetAttributes(name, attributeNames);
        }

        public string GetDefaultDomain()
        {
            return proxy.GetDefaultDomain();
        }

        public IList<string> GetDomains()
        {
            return proxy.GetDomains();
        }

        public int GetMBeanCount()
        {
            return proxy.GetMBeanCount();
        }

        public MBeanInfo GetMBeanInfo(ObjectName name)
        {
            return proxy.GetMBeanInfo(name);
        }

        public object Invoke(ObjectName name, string operationName, object[] arguments)
        {
            return proxy.Invoke(name, operationName, arguments);
        }

        public bool IsInstanceOf(ObjectName name, string className)
        {
            return proxy.IsInstanceOf(name, className);
        }

        public bool IsRegistered(ObjectName name)
        {
            return proxy.IsRegistered(name);
        }

        public IEnumerable<ObjectName> QueryNames(ObjectName name, QueryExp query)
        {
            return proxy.QueryNames(name, query);
        }

        public void RemoveNotificationListener(ObjectName name, NotificationCallback callback, NotificationFilterCallback filterCallback, object handback)
        {
            throw new InvalidOperationException("This operation is not supported by ServiceModel connector.");
        }

        public void RemoveNotificationListener(ObjectName name, ObjectName listener, NotificationFilterCallback filterCallback, object handback)
        {
            throw new InvalidOperationException("This operation is not supported by ServiceModel connector.");
        }

        public void RemoveNotificationListener(ObjectName name, NotificationCallback callback)
        {
            throw new InvalidOperationException("This operation is not supported by ServiceModel connector.");
        }

        public void RemoveNotificationListener(ObjectName name, ObjectName listener)
        {
            proxy.RemoveNotificationListener(name, listener);
        }

        public void SetAttribute(ObjectName name, string attributeName, object value)
        {
            proxy.SetAttribute(name, attributeName, value);
        }

        public IList<AttributeValue> SetAttributes(ObjectName name, IEnumerable<AttributeValue> namesAndValues)
        {
            return proxy.SetAttributes(name, namesAndValues);
        }

        public void UnregisterMBean(ObjectName name)
        {
            proxy.UnregisterMBean(name);
        }

        #endregion Methods
    }
}