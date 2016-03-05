

namespace AllInOne.Legal.Domain.Common
{
    using System;

    /// <summary>
    /// Represents a standard domain entity for SICCFeeDocDetails.
    /// </summary>
    [Serializable]
    public class SICCFeeDocDetailsEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="SICCFeeDocDetailsEntity"/> class.</summary> 
        public SICCFeeDocDetailsEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the fee document identifier.
        /// </summary>
        /// <value>
        /// The fee document identifier.
        /// </value>
        public string FeeDocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the fee ledger identifier.
        /// </summary>
        /// <value>
        /// The fee ledger identifier.
        /// </value>
        public string FeeLedgerId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the document identifier.
        /// </summary>
        /// <value>
        /// The document identifier.
        /// </value>
        public string DocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is transaction document.
        /// </summary>
        /// <value>
        /// The is transaction document.
        /// </value>
        public Int32 IsTransactionDocument
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the obs ind.
        /// </summary>
        /// <value>
        /// The obs ind.
        /// </value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified date.
        /// </summary>
        /// <value>The last modified date.</value>
        public DateTime LastModifiedDate
        {
            get;
            set;
        }

        #endregion Properties
    }
}