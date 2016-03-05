namespace CrimsonLogic.Common.Library.Tests
{
    using System;

    using NUnit.Framework;

    using Validator;

    [TestFixture]
    public class TestValidator
    {
        #region Methods

        [Test]
        public void TestIsEmail()
        {
            String email = "Test@crimsonlogic.com";
            Assert.IsTrue(CommonValidator.IsEmail(email));
            email = "Test23434.com";
            Assert.IsFalse(CommonValidator.IsEmail(email));
            email = "Test@23434com";
            Assert.IsFalse(CommonValidator.IsEmail(email));
        }

        #endregion Methods
    }
}