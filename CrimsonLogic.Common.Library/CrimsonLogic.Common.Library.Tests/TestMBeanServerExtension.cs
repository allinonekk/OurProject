namespace CrimsonLogic.Common.Library.Tests
{
    using System.IO;

    using log4net;
    using log4net.Config;

    using MBean;

    using NetMX;

    using NUnit.Framework;

    [TestFixture]
    class TestMBeanServerExtension
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof (TestMBeanServerExtension));

        private MBeanServerExtension mbeanServerExtension;

        #endregion Fields

        #region Methods

        [TestFixtureSetUp]
        public void Init()
        {
            XmlConfigurator.Configure(new FileInfo("log4net_commonlibrary.config"));
            mbeanServerExtension = MBeanServerExtension.Instance;
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Assert.IsTrue(mbeanServerExtension.RemoveMBean("ValidMBean"));
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
        public void TestMBeanServer()
        {
            IMBeanServer mbeanServer = mbeanServerExtension.MBeanServer;

            var name = new ObjectName("MBeanServer:component=ValidMBean");
            MBeanInfo info = mbeanServer.GetMBeanInfo(name);
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

            object counter = mbeanServer.GetAttribute(name, "Counter");

            Assert.AreEqual(0, counter);

            mbeanServer.SetAttribute(name, "Counter", 5);
            counter = mbeanServer.GetAttribute(name, "Counter");

            Assert.AreEqual(5, counter);

            mbeanServer.Invoke(name, "AddAmount", new object[] { 5 });
            counter = mbeanServer.GetAttribute(name, "Counter");

            Assert.AreEqual(10, counter);

            mbeanServer.Invoke(name, "ResetCounter", new object[] { });
            counter = mbeanServer.GetAttribute(name, "Counter");

            Assert.AreEqual(0, counter);

            Logger.Debug("Completed testing the MBeanServer!");
        }

        #endregion Methods
    }
}