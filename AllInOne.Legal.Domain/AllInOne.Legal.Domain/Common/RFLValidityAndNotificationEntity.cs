namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Common.RFLValidityAndNotificationEntity'</summary>
    [Serializable]
    public class RFLValidityAndNotificationEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        public string RFLValidityNotificationID { get; set; }
        public string SubmissionGroupID { get; set; }
        public string RFLCaseInfoId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public Int32 MonthsNotifiCation { get; set; }
        public Int32 WeeksNotifiCation { get; set; }
        public Int32 DaysNotifiCation { get; set; }
        public YesNo ObsInd { get; set; }
        public Int32 RFLVerNo { get; set; }

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
            RFLValidityAndNotificationEntity toCompareWith = obj as RFLValidityAndNotificationEntity;
            return toCompareWith == null ? false : ((this.RFLValidityNotificationID == toCompareWith.RFLValidityNotificationID) && (this.SubmissionGroupID == toCompareWith.SubmissionGroupID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RFLValidityNotificationID.GetHashCode();
            toReturn ^= this.SubmissionGroupID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}