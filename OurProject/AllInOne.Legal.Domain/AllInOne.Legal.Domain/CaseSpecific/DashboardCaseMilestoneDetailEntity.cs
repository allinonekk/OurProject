﻿namespace AllInOne.Legal.Domain.CaseSpecific
{
    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using System;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class DashboardCaseMilestoneDetailEntity : AbstractLastModified, ICaseSpecificEntity
    {
        #region Properties

        public string DashboardCaseMilestoneDetailId { get; set; }

        public string CaseRegisterId { get; set; }

        public string DashboardMilestoneCode //TODO: Need to do as object mapping
        {
            get;
            set;
        }
        public DateTime? MilestoneDate
        {
            get;
            set;
        }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate
        {
            get;
            set;
        }
        
       
        public YesNo ObsInd
        {
            get;
            set;
        }

        public string Remarks
        {
            get;
            set;
        }
        public int SeqNo { get; set; }
       
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
            DashboardCaseMilestoneDetailEntity toCompareWith = obj as DashboardCaseMilestoneDetailEntity;
            return toCompareWith == null ? false : ((this.DashboardCaseMilestoneDetailId == toCompareWith.DashboardCaseMilestoneDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DashboardCaseMilestoneDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}