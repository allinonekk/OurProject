namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class PBBeneficiaryDetailEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        public string Age
        {
            get;
            set;
        }

        public DateTime? DateOfBirth
        {
            get;
            set;
        }

        public Int32 ItemNo
        {
            get;
            set;
        }

        public YesNo MCA
        {
            get;
            set;
        }

        public MGenderEntity MGender
        {
            get;
            set;
        }

        public YesNo MinorityInterestInd
        {
            get;
            set;
        }

        public MRelationshipEntity MRelationship
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public String PBBeneficiaryDetailId
        {
            get;
            set;
        }

        public String RelationshipRemarks
        {
            get;
            set;
        }

        public String ShareEntitlement
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
            PBBeneficiaryDetailEntity toCompareWith = obj as PBBeneficiaryDetailEntity;
            return toCompareWith == null ? false : ((this.PBBeneficiaryDetailId == toCompareWith.PBBeneficiaryDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PBBeneficiaryDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}