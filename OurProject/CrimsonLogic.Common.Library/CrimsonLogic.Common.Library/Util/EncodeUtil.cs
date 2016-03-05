namespace AllInOne.Common.Library.Util
{
    using System;
    using System.Web;

    /// <summary>
    /// Encode utility for Elit.
    /// </summary>
    public class EncodeUtil
    {
        /// <summary>
        /// HTMLs the encode.
        /// Uses HttpUtility.HtmlEncode(string) method for encoding.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public string HtmlEncode(string value)
        {
            return HttpUtility.HtmlEncode(value);
        }
    }
}