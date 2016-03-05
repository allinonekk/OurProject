namespace AllInOne.Common.Library.Validator
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Utility class containing common validations. 
    /// </summary>
    public static class CommonValidator
    {
        #region Methods

        /// <summary>
        /// This method is used to validate the email address string.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsEmail(string email)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            var re = new Regex(strRegex);
            if (re.IsMatch(email))
            {
                return (true);
            }
            return (false);
        }

        #endregion Methods
    }
}