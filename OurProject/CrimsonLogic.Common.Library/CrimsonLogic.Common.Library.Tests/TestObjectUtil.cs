namespace CrimsonLogic.Common.Library.Tests
{
    using System.IO;

    using log4net.Config;

    using NUnit.Framework;

    using Object;

    [TestFixture]
    public class TestObjectUtil
    {
        #region Methods

        /// <summary>
        /// 
        /// </summary>
        [TestFixtureSetUp]
        public void Init()
        {
            XmlConfigurator.Configure(new FileInfo("log4net_commonlibrary.Config"));
        }

        [Test]
        public void TestBoundaryConvertToByteArray()
        {
            Assert.Null(ObjectUtil.ConvertToByteArray(new NonSerializableClass()));
        }

        [Test]
        public void TestBoundaryConvertToObject()
        {
            Assert.Null(ObjectUtil.ConvertToObject(null));

            Assert.Null(ObjectUtil.ConvertToObject(new byte[]{ 1, 2, 3, 4 }));
        }

        /// <summary>
        /// Tests the serialize complex object where the object does not completely encapsulate serializable
        /// objects
        /// </summary>
        [Test]
        public void TestSerializeComplexObjectBad()
        {
            Stranger parent = new Stranger { Name = "Hello", Orphan = new Orphan { Name = "World" } };
            byte[] serialized = ObjectUtil.ConvertToByteArray(parent);

            Assert.Null(serialized);
        }

        [Test]
        public void TestSerializeComplexObjectGood()
        {
            Parent parent = new Parent { Name = "Hello", Child = new Child { Name = "World" } };
            byte[] serialized = ObjectUtil.ConvertToByteArray(parent);

            Assert.NotNull(serialized);
            Assert.IsTrue(serialized.LongLength > 0);
            Assert.AreEqual(372, serialized.LongLength);

            Parent deserialized = (Parent)ObjectUtil.ConvertToObject(serialized);

            Assert.NotNull(deserialized);
            Assert.AreEqual("Hello", deserialized.Name);
            Assert.AreEqual("World", deserialized.Child.Name);
        }

        #endregion Methods
    }

    class NonSerializableClass
    {
    }
}