namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for DocGCRDetails.
    /// </summary>
    [Serializable]
    public class DocGCRDetailsEntity : AbstractDocId, IDocumentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item number.</value>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFId field.
        /// </summary>
        /// <value>The LFId.</value>
        public String LFId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SentCopy field.
        /// </summary>
        /// <value>The SentCopy indicator.</value>
        public OutgoingCorrespondanceSentCopy SentCopy
        {
            get;
            set;
        }

        public string CasePartyId { get; set; }

        #endregion Properties
    }
}