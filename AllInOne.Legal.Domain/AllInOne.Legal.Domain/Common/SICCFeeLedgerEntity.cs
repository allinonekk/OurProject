
namespace AllInOne.Legal.Domain.Common
{
    using System;
    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for SICCFeeLedger.
    /// </summary>
    [Serializable]
    public class SICCFeeLedgerEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="SICCFeeLedgerEntity"/> class.</summary> 
        public SICCFeeLedgerEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public string FeeLedgerId {get;set;}
        public string CaseInfoId{get;set;}
        public string SubCaseInfoId{get;set;}
        public string CasePartyId{get;set;}
        public string MilestoneCode{get;set;}
        public string FeeDetails{get;set;}
        public decimal? Fees { get; set; }
        public string TransactionType{get;set;}
        public string TrasactionStatus{get;set;}
        public YesNo ObsInd{get;set;}

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            SICCFeeLedgerEntity toCompareWith = obj as SICCFeeLedgerEntity;
            return toCompareWith == null ? false : ((this.FeeLedgerId == toCompareWith.FeeLedgerId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FeeLedgerId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}