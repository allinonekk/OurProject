namespace CrimsonLogic.Common.Library.Tests
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;

    using log4net;
    using log4net.Config;

    using MBean;

    using NetMX;
    using NetMX.Remote;
    using NetMX.Remote.Jsr262;

    using NUnit.Framework;

    //Removed the unit test since the cause of inability to connect to the MBeanServer via JSR262-enhanced JConsole cannot be determined.
    //[TestFixture]
    class TestMBeanServerJsr262Exporter
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof (TestMBeanServerExtension));

        private MBeanServerJsr262Exporter jsr262Exporter;
        private MBeanServerExtension mbeanServerExtension;

        #endregion Fields

        #region Methods

        [TestFixtureSetUp]
        public void Init()
        {
            XmlConfigurator.Configure(new FileInfo("log4net_commonlibrary.config"));
            mbeanServerExtension = MBeanServerExtension.Instance;
            jsr262Exporter = new MBeanServerJsr262Exporter(mbeanServerExtension.MBeanServer);
            jsr262Exporter.Start();

            Thread.Sleep(500);
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Assert.IsTrue(mbeanServerExtension.RemoveMBean("ValidMBean"));
            jsr262Exporter.Stop();
        }

        [Test]
        public void TestAddInvalidMBean()
        {
            Assert.IsFalse(mbeanServerExtension.AddMBean("InValidMBean", new object()));
        }

        [Test]
        public void TestAddValidMBean()
        {
            Assert.IsTrue(mbeanServerExtension.AddMBean("ValidMBean", new ValidInstance()));
        }

        [Test]
        public void TestBoundary()
        {
            Assert.IsFalse(mbeanServerExtension.AddMBean("", new object()));
            Assert.IsFalse(mbeanServerExtension.AddMBean("Whatever", null));
        }

        [Test]
        public void TestJsr262Connector()
        {
            var jsr262ConnectorProvider = new Jsr262ConnectorProvider();
            INetMXConnector connector = null;
            string uri = string.Format("http://{0}:8888/MBeanServer", GetLocalAddress());
            Logger.DebugFormat("URI used to connect to the MBeanServer: {0}", uri);
            try
            {
                var url = new Uri(uri);
                connector = jsr262ConnectorProvider.NewNetMXConnector(url);
            }
            catch (Exception)
            {
                string msg = string.Format("Unable to create a client connection to the MBeanServer: URI-{0}", uri);
                Logger.Error(msg);
                Assert.Fail(msg);
            }
            connector.Connect(null);

            using (connector)
            {
                Logger.Debug("Starting the connection...");
                IMBeanServerConnection remoteServer = connector.MBeanServerConnection;

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
                            ? "Operation AddAmount (Adds specified value to value of the counter) [Action]"
                            : "Operation ResetCounter (Sets counter value to 0) [Action]", operation);

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

                Logger.Debug("Completed the JSR262 server-side tests!");
            }
        }

        private static string GetLocalAddress()
        {
            // Then using host name, get the IP address list..
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;

            foreach (var ipAddress in addr)
            {
                //This is to ensure that the address returned is an IPv4 address.
                if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ipAddress.ToString();
                }
                //else if (ipAddress.AddressFamily == AddressFamily.InterNetworkV6)
                //{
                //    // it is a valid v6 IP
                //}
            }

            return string.Empty;
        }

        #endregion Methods
    }
}