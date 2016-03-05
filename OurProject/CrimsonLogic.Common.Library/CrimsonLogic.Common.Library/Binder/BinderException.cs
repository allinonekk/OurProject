namespace AllInOne.Common.Library.Binder
{
    using System;

    /// <summary>
    /// Exception thrown when a problem exists during the component binding process.
    /// </summary>
    public class BinderException : Exception
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BinderException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public BinderException(string message)
            : base(message)
        {
            //do nothing
        }

        #endregion Constructors
    }
}