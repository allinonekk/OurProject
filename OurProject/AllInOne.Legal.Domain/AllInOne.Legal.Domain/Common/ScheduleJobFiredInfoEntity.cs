namespace AllInOne.Legal.Domain.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Common.ScheduleJobFiredInfoEntity'</summary>
    [Serializable]
    public class ScheduleJobFiredInfoEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the LastFailureDateTime.
        /// </summary>
        /// <value>The LastFailureDateTime.</value>
        public DateTime? LastFailureDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastStartedDateTime field.
        /// </summary>
        /// <value>The last started date time.</value>
        public DateTime? LastStartedDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastSuccessDateTime field.
        /// </summary>
        /// <value>The last success date time.</value>
        public DateTime? LastSuccessDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastTriggeredDateTime field.
        /// </summary>
        /// <value>The last triggered date time.</value>
        public DateTime? LastTriggeredDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ScheduleJobFiredInfoId field.
        /// </summary>
        /// <value>The ScheduleJobFiredInfoId.</value>
        public String ScheduleJobFiredInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ScheduleJobTriggerInfoId field.
        /// </summary>
        /// <value>The ScheduleJobTriggerInfoId.</value>
        public String ScheduleJobTriggerInfoId
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

            ScheduleJobFiredInfoEntity toCompareWith = obj as ScheduleJobFiredInfoEntity;
            return toCompareWith == null ? false : ((this.ScheduleJobFiredInfoId == toCompareWith.ScheduleJobFiredInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ScheduleJobTriggerInfoId.GetHashCode();
            return toReturn;
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("ScheduleJobFiredInfoId: {0}, ScheduleJobTriggerInfoId: {1}, LastTriggeredDateTime: {2}, LastStartedDateTime: {3}, LastSuccessDateTime: {4}, LastFailureDateTime: {5}, LastModifiedBy: {6}, LastModifiedDate: {7}",
                                this.ScheduleJobFiredInfoId, this.ScheduleJobTriggerInfoId, this.LastStartedDateTime.ToString(), this.LastSuccessDateTime.ToString(), this.LastFailureDateTime.ToString(), this.LastModifiedBy, this.LastModifiedDate.ToString());
        }

        #endregion Methods
    }
}