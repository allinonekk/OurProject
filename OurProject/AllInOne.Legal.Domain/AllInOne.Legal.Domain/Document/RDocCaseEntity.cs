namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for RDocCase.
    /// </summary>
    [Serializable]
    public class RDocCaseEntity : AbstractCaseInfoSubCaseInfoDocId, IDocumentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the IsOriginal field.
        /// </summary>
        /// <value>The is original.</value>
        public YesNo IsOriginal
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsPreceding field.
        /// </summary>
        /// <value>The is preceding.</value>
        public YesNo IsPreceding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RefDocId field.
        /// </summary>
        /// <value>The ref doc id.</value>
        public String RefDocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RefDocNumber field.
        /// </summary>
        /// <value>The ref doc number.</value>
        public String RefDocNumber
        {
            get;
            set;
        }

        #endregion Properties
    }
}