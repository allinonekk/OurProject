namespace AllInOne.Common.Library.Encryption
{
    using System;

    /// <summary>
    /// This is the exception class that is thrown throughout the Decryption process.
    /// </summary>
    public class DecryptionException : Exception
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptionException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public DecryptionException(string message)
            : base(message)
        {
            //do nothing
        }

        #endregion Constructors
    }
}