namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Common.ReqExaminationFeedetailEntity'</summary>
    [Serializable]
    public class ReqExaminationFeeDetailEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        public string ReqExaminationFeeDetailID { get; set; }
        public long CaseInfoID { get; set; }
        public string SubmissionGroupID { get; set; }
        public int NoOfparties { get; set; }
        public int TimeNeeded { get; set; }
        public Nullable<System.Decimal> FeeAmount { get; set; }
        public YesNo IsNBSInterfaced { get; set; }
        public YesNo ObsInd { get; set; }

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
            ReqExaminationFeeDetailEntity toCompareWith = obj as ReqExaminationFeeDetailEntity;
            return toCompareWith == null ? false : ((this.ReqExaminationFeeDetailID == toCompareWith.ReqExaminationFeeDetailID) && (this.CaseInfoID == toCompareWith.CaseInfoID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ReqExaminationFeeDetailID.GetHashCode();
            toReturn ^= this.CaseInfoID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}