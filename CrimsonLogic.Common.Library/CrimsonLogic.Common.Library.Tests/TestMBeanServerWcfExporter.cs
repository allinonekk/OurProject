namespace CrimsonLogic.Common.Library.Tests
{
    using System;
    using System.IO;
    using System.Threading;

    using log4net;
    using log4net.Config;

    using MBean;

    using NetMX;
    using NetMX.Remote;
    using NetMX.Remote.ServiceModel;

    using NUnit.Framework;

    [TestFixture]
    class TestMBeanServerWcfExporter
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof (TestMBeanServerExtension));

        private MBeanServerExtension mbeanServerExtension;
        private MBeanServerWcfExporter wcfExporter;

        #endregion Fields

        #region Methods

        [TestFixtureSetUp]
        public void Init()
        {
            XmlConfigurator.Configure(new FileInfo("log4net_commonlibrary.config"));
            mbeanServerExtension = MBeanServerExtension.Instance;

            wcfExporter = new MBeanServerWcfExporter(new MBeanServerService(mbeanServerExtension.MBeanServer));
            wcfExporter.Start();

            mbeanServerExtension.AddMBean("ValidMBean", new ValidInstance());

            Thread.Sleep(500);
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Assert.IsTrue(mbeanServerExtension.RemoveMBean("ValidMBean"));
            wcfExporter.Stop();
        }

        [Test]
        public void TestWcfConnector()
        {
            INetMXConnector connector = null;
            const string clientConfig = "remoteServer";
            Logger.DebugFormat("Client config used to connect to the MBeanServer: {0}", clientConfig);
            try
            {
                connector = new WcfServiceModelConnector(clientConfig);
            }
            catch (Exception)
            {
                string msg = string.Format("Unable to create a client connection to the MBeanServer: Client Config-{0}", clientConfig);
                Logger.Error(msg);
                Assert.Fail(msg);
            }
            connector.Connect(null);

            using (connector)
            {
                Logger.Debug("Starting the connection...");
                IMBeanServerConnection remoteServer = connector.MBeanServerConnection;
                Assert.AreEqual(2, remoteServer.GetMBeanCount());

                var name = new ObjectName("MBeanServer:component=ValidMBean");
                MBeanInfo info = remoteServer.GetMBeanInfo(name);
                Assert.AreEqual("MBean", info.Description);
                Assert.AreEqual("CrimsonLogic.Common.Library.Tests.ValidInstanceMBean, CrimsonLogic.Common.Library.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=5fb9aab394206ec1", info.ClassName);
                foreach (MBeanAttributeInfo attributeInfo in info.Attributes)
                {
                    string attribute = string.Format("Attribute {0} ({1}) [{2}{3}]: {4}", attributeInfo.Name,
                                      attributeInfo.Description,
                                      attributeInfo.Readable ? "r" : "", attributeInfo.Writable ? "w" : "",
                                      attributeInfo.Type);
                    Assert.AreEqual("Attribute Counter (Counter value) [rw]: System.Int32, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", attribute);
                }
                int index = 0;
                foreach (MBeanOperationInfo operationInfo in info.Operations)
                {
                    string operation = string.Format("Operation {0} ({1}) [{2}]", operationInfo.Name, operationInfo.Description,
                                      operationInfo.Impact);
                    Assert.AreEqual(
                        index == 0
                            ? "Operation AddAmount (Adds specified value to value of the counter) [Unknown]"
                            : "Operation ResetCounter (Sets counter value to 0) [Unknown]", operation);

                    index++;
                }

                object counter = remoteServer.GetAttribute(name, "Counter");

                Assert.AreEqual(0, counter);

                remoteServer.SetAttribute(name, "Counter", 5);
                counter = remoteServer.GetAttribute(name, "Counter");

                Assert.AreEqual(5, counter);

                remoteServer.Invoke(name, "AddAmount", new object[] { 5 });
                counter = remoteServer.GetAttribute(name, "Counter");

                Assert.AreEqual(10, counter);

                remoteServer.Invoke(name, "ResetCounter", new object[] { });
                counter = remoteServer.GetAttribute(name, "Counter");

                Assert.AreEqual(0, counter);

                Logger.Debug("Completed the WCF server-side tests!");
            }
        }

        #endregion Methods
    }
}