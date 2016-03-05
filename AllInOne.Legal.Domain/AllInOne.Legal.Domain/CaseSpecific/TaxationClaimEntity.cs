namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Case.TaxationClaim'</summary>
    [Serializable]
    public class TaxationClaimEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        public Decimal? AwardedAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MBasisOfTaxationType field. </summary>
        public Decimal? ClaimAmount
        {
            get;
            set;
        }

        public String Instructions
        {
            get;
            set;
        }

        public YesNo IsCorrectInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BOTRemarks field. </summary>
        public MHRGTypeEntity MHRGType
        {
            get;
            set;
        }

        public String Remarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public String SectionNumber
        {
            get;
            set;
        }

        public Decimal? SumAwardedAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TaxationBOTDetailId field. </summary>
        public String TaxationClaimId
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
            TaxationClaimEntity toCompareWith = obj as TaxationClaimEntity;
            return toCompareWith == null ? false : ((this.TaxationClaimId == toCompareWith.TaxationClaimId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.TaxationClaimId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}