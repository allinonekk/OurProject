
namespace AllInOne.Legal.Domain.Common
{
    using System;

    /// <summary>
    /// Represents a standard domain entity for SICCFeeTransDetails.
    /// </summary>
    [Serializable]
    public class SICCFeeTransDetailsEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="SICCFeeTransDetailsEntity"/> class.</summary> 
        public SICCFeeTransDetailsEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties


        /// <summary>
        /// Gets or sets the fee trans details.
        /// </summary>
        /// <value>
        /// The fee trans details.
        /// </value>
        public string FeeTransDetails
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
        /// Gets or sets the date of action.
        /// </summary>
        /// <value>
        /// The date of action.
        /// </value>
        public DateTime DateOfAction
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the action by.
        /// </summary>
        /// <value>
        /// The action by.
        /// </value>
        public string ActionBy
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the remarks.
        /// </summary>
        /// <value>
        /// The remarks.
        /// </value>
        public string Remarks
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the trans process status.
        /// </summary>
        /// <value>
        /// The trans process status.
        /// </value>
        public string TransProcessStatus
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