namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using AllInOne.Legal.Domain.Interfaces;
using AllInOne.Legal.Domain.Abstract;
using System;
using AllInOne.Legal.Domain.Master;

    public class VoteInfoDeltaEntity : ISubCaseSpecificEntity
    {
        #region Properties
        public string VoteInfoDeltaId { get; set; }

        public string CaseNo
        {
            get;
            set;
        }
        public string CaseInfoId
        {
            get;
            set;
        }

        public YesNo ReqExemVoting
        {
            get;
            set;
        }

        public YesNo PenaltyPaidStatus
        {
            get;
            set;
        }

        public VoteInfoValue VoteInfoDeltaValue
        {
            get;
            set;
        }

        public YesNo ObsInd
        {
            get;
            set;
        }

        public string LastModifiedBy
        {
            get;
            set;
        }

        public DateTime LastModifiedDate
        {
            get;
            set;
        }

        public DateTime PCStartYear
        {
            get;
            set;
        }

        public DateTime PCEndYear
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
            VoteInfoDeltaEntity toCompareWith = obj as VoteInfoDeltaEntity;
            return toCompareWith == null ? false : ((this.VoteInfoDeltaId == toCompareWith.VoteInfoDeltaId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.VoteInfoDeltaId.GetHashCode();
            return toReturn;
        }

        #endregion Methods


    }
}
