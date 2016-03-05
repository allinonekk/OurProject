namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class PBPADetails : ICaseSpecific
    {
        #region Properties

        public virtual int ItemNo { get; set; }

        public virtual string DonorName
        {
            get;
            set;
        }

        public virtual MGender MGender
        {
            get;
            set;
        }

        public virtual String PANumber
        {
            get;
            set;
        }

        public virtual DateTime? PADate
        {
            get;
            set;
        }

        public virtual string RelationshipCode
        {
            get;
            set;
        }

        public virtual String RelationshipRemarks
        {
            get;
            set;
        }

        public virtual String PBPADetailId
        {
            get;
            set;
        }

        public virtual MApplicantCapacity MApplicantCapacity
        {
            get;
            set;
        }

        public virtual string SubmissionGroupId
        {
            get;
            set;
        }

        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }
        public virtual string CapacityRemarks { get; set; }
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
            PBPADetails toCompareWith = obj as PBPADetails;
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