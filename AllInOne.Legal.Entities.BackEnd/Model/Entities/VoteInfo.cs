using System;
namespace AllInOne.Legal.Entities.BackEnd
{
    public class VoteInfo: ISubCaseSpecific
    {
        #region Properties
        public virtual string VoteInfoId { get; set; }

        public virtual string CaseNo
        {
            get;
            set;
        }
        public virtual string CaseInfoId
        {
            get;
            set;
        }

        public virtual string ReqExemVoting
        {
            get;
            set;
        }

        public virtual string PenaltyPaidStatus
        {
            get;
            set;
        }

        public virtual string VoteInfoValue
        {
            get;
            set;
        }

        public virtual string ObsInd
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

        public virtual DateTime PCStartYear
        {
            get;
            set;
        }

        public virtual DateTime PCEndYear
        {
            get;
            set;
        }



        #endregion

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
            VoteInfo toCompareWith = obj as VoteInfo;
            return toCompareWith == null ? false : ((this.VoteInfoId == toCompareWith.VoteInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.VoteInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods


    }
}
