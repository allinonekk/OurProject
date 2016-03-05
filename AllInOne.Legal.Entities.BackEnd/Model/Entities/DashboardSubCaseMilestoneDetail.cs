namespace AllInOne.Legal.Entities.BackEnd
{
    
    using System;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class DashboardSubCaseMilestoneDetail :  ISubCaseSpecific
    {
        #region Properties

        public virtual string DashboardSubCaseMilestoneDetailId { get; set; }

        public virtual long SubCaseInfoId { get; set; }

        public virtual string DashboardMilestoneCode //TODO: Need to do as object mapping
        {
            get;
            set;
        }
        public virtual DateTime? MilestoneDate
        {
            get;
            set;
        }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedDate
        {
            get;
            set;
        }


        public virtual string ObsInd
        {
            get;
            set;
        }

        public virtual string Remarks
        {
            get;
            set;
        }
        public virtual int SeqNo { get; set; }

        public virtual string LastModifiedBy { get; set; }

        public virtual DateTime LastModifiedDate { get; set; }
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
            DashboardSubCaseMilestoneDetail toCompareWith = obj as DashboardSubCaseMilestoneDetail;
            return toCompareWith == null ? false : ((this.DashboardSubCaseMilestoneDetailId == toCompareWith.DashboardSubCaseMilestoneDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DashboardSubCaseMilestoneDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}