namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Case.TaxationInfo'</summary>
    [Serializable]
    public class TaxationInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        public Decimal? AmountInvolved
        {
            get;
            set;
        }

        public String BFTRemarks
        {
            get;
            set;
        }

        public String BillNatureRemarks
        {
            get;
            set;
        }

        public YesNo DirectorConsented
        {
            get;
            set;
        }

        public Decimal? GstAmount
        {
            get;
            set;
        }

        public Decimal? GstPercentage
        {
            get;
            set;
        }

        public Int32? HrgDays
        {
            get;
            set;
        }

        public Decimal? HrgHours
        {
            get;
            set;
        }

        public YesNo IssueCOC
        {
            get;
            set;
        }

        public MBasisForTaxationEntity MBasisForTaxation
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public MBillNatureEntity MBillNature
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MBasisOfTaxationType field. </summary>
        public MBillTypeEntity MBillType
        {
            get;
            set;
        }

        public MCurrencyEntity MCurrency
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BOTRemarks field. </summary>
        public MNatureOfWorkEntity MNatureOfWork
        {
            get;
            set;
        }

        public String NatureOfWork
        {
            get;
            set;
        }

        public Decimal? NoOfDaysOfTrial
        {
            get;
            set;
        }

        public String NOWRemarks
        {
            get;
            set;
        }

        public Decimal? OGAwardedAmount
        {
            get;
            set;
        }

        public DateTime? PeriodOfWorkFrom
        {
            get;
            set;
        }

        public DateTime? PeriodOfWorkTo
        {
            get;
            set;
        }

        public YesNo PublicTrusteeConsented
        {
            get;
            set;
        }

        public String ReliefClaimed
        {
            get;
            set;
        }

        public String ScopeOfBrief
        {
            get;
            set;
        }

        public Decimal? SGDEquivalent
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TaxationBOTDetailId field. </summary>
        public String TaxationInfoId
        {
            get;
            set;
        }

        public Decimal? TimeSpentGetUp
        {
            get;
            set;
        }

        public YesNo WithdrawalFeeInd
        {
            get;
            set;
        }

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
            TaxationInfoEntity toCompareWith = obj as TaxationInfoEntity;
            return toCompareWith == null ? false : ((this.TaxationInfoId == toCompareWith.TaxationInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.TaxationInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}