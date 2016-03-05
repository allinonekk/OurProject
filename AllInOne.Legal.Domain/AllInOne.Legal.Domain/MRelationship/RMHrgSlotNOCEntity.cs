namespace AllInOne.Legal.Domain.MRelationship
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using System.Collections.Generic;

    /// <summary>Class which represents the entity 'Master.RMHrgSlotNOCEntity'</summary>
    [Serializable]
    public class RMHrgSlotNOCEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

        public string RMHrgSlotNocID { get; set; }
        public string ForumID { get; set; }
        public string HrgSlotCode { get; set; }
        public string NocCode { get; set; }
        public YesNo ObsInd { get; set; }
        public string HRGTypeCode { get; set; }
        public string SectionCode { get; set; }
        public string CaseType { get; set; }
        public DateTime? LastSectionAssignedDate{get;set;}

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
            RMHrgSlotNOCEntity toCompareWith = obj as RMHrgSlotNOCEntity;
            return toCompareWith == null ? false : ((this.RMHrgSlotNocID == toCompareWith.RMHrgSlotNocID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RMHrgSlotNocID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}