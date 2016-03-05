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
    public class PBPADetailEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        public int ItemNo { get; set; }

        public string DonorName
        {
            get;
            set;
        }

        public MGenderEntity MGenderEntity
        {
            get;
            set;
        }

        public String PANumber
        {
            get;
            set;
        }

        public DateTime? PADate
        {
            get;
            set;
        }

        public string RelationshipCode
        {
            get;
            set;
        }

        public String RelationshipRemarks
        {
            get;
            set;
        }

        public String PBPADetailId
        {
            get;
            set;
        }

        public MApplicantCapacityEntity MApplicantCapacityEntity
        {
            get;
            set;
        }

        public String SubmissionGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedBy field.
        /// </summary>
        /// <value>The last modified by.</value>
        public String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedDate field.
        /// </summary>
        /// <value>The last modified date.</value>
        public DateTime LastModifiedDate
        {
            get;
            set;
        }
        public string CapacityRemarks { get; set; }
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
            PBPADetailEntity toCompareWith = obj as PBPADetailEntity;
            return toCompareWith == null ? false : ((this.PBPADetailId == toCompareWith.PBPADetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PBPADetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}