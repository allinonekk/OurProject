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
    public class PBPrevGrantDetailEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        public String Capacity
        {
            get;
            set;
        }

        public String CapacityRemarks
        {
            get;
            set;
        }

        public DateTime? DateOfDeath
        {
            get;
            set;
        }

        public DateTime? GrantDate
        {
            get;
            set;
        }

        public String GrantNumber
        {
            get;
            set;
        }

        public Int32 ItemNo
        {
            get;
            set;
        }

        public MCourtTypeEntity MCourtType
        {
            get;
            set;
        }

        public MGenderEntity MGender
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public String PBPrevGrantDetailId
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
            PBPrevGrantDetailEntity toCompareWith = obj as PBPrevGrantDetailEntity;
            return toCompareWith == null ? false : ((this.PBPrevGrantDetailId == toCompareWith.PBPrevGrantDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PBPrevGrantDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}