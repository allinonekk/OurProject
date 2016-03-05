using NUnit.Framework;
using CrimsonLogic.Common.Library.Util;

namespace CrimsonLogic.Common.Library.Tests
{
    [TestFixture]
    class TestEncoding
    {
        [Test]
        public void Test1()
        {
            string encode = "<img src=\"http://www.iplcricketnow.com/wp-content/uploads/2011/04/Lasith_Malinga.jpg\" id=\"il_fi\" height=\"360\" width=\"300\" style=\"padding-right: 8px; padding-top: 8px; padding-bottom: 8px; \">";
            EncodeUtil encodeUtil = new EncodeUtil();
            string encodeResult = encodeUtil.HtmlEncode(encode);
        }

        [Test]
        public void Test2()
        {
            string encode = "<script>alert('Hi');</script>";
            EncodeUtil encodeUtil = new EncodeUtil();
            string encodeResult = encodeUtil.HtmlEncode(encode);
        }

        [Test]
        public void Test3()
        {
            string encode = "<script>window.location='www.google.com.sg'</script>";
            EncodeUtil encodeUtil = new EncodeUtil();
            string encodeResult = encodeUtil.HtmlEncode(encode);
        }

        [Test]
        public void Test4()
        {
            EncodeUtil encodeUtil = new EncodeUtil();
            string encodeResult = encodeUtil.HtmlEncode(null);
        }

        [Test]
        public void Test5()
        {
            EncodeUtil encodeUtil = new EncodeUtil();
            string encodeResult = encodeUtil.HtmlEncode(string.Empty);
        }
    }
}
