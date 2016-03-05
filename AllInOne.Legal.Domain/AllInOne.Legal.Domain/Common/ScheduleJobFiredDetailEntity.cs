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
    public class ScheduleJobFiredDetailEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the LastSuccessDateTime field.
        /// </summary>
        /// <value>The completion date time.</value>
        public DateTime? CompletionDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ScheduleJobFiredInfoId field.
        /// </summary>
        /// <value>The ScheduleJobFiredInfoId.</value>
        public String Remarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastFailureDateTime.
        /// </summary>
        /// <value>The LastFailureDateTime.</value>
        public String ScheduleJobFiredDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedBy field.
        /// </summary>
        /// <value>The LastModifiedBy.</value>
        public String ScheduleJobTriggerInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastStartedDateTime field.
        /// </summary>
        /// <value>The start date time.</value>
        public DateTime StartDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedDate.
        /// </summary>
        /// <value>The LastModifiedDate.</value>
        public String StartedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Status field.
        /// </summary>
        /// <value>The status.</value>
        public ScheduleJobFiredStatus Status
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

            ScheduleJobFiredDetailEntity toCompareWith = obj as ScheduleJobFiredDetailEntity;
            return toCompareWith == null ? false : ((this.ScheduleJobFiredDetailId == toCompareWith.ScheduleJobFiredDetailId));
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
            return string.Format("ScheduleJobFiredDetailId: {0}, ScheduleJobTriggerInfoId: {1}, StartedBy: {2}, StartDateTime: {3}, CompletionDateTime:{4}, Status: {5}, Remarks: {6}, LastModifiedBy: {7}, LastModifiedDate: {8}",
                                this.ScheduleJobFiredDetailId, this.ScheduleJobTriggerInfoId, this.StartedBy, this.StartDateTime.ToString(), this.CompletionDateTime.ToString(), this.Status.ToString(), this.Remarks.ToString(), this.LastModifiedBy, this.LastModifiedDate.ToString());
        }

        #endregion Methods
    }
}