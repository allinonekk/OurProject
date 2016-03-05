namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.ScheduleJobTriggerInfoEntity'</summary>
    public class ScheduleJobTriggerInfoEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>The created by.</value>
        public String CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the created date time.
        /// </summary>
        /// <value>The created date time.</value>
        public DateTime CreatedDateTime
        {
            get;
            set;
        }

        /// <summary>Gets or sets the JobFrequency field. </summary>
        public Int32? JobFrequency
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the job run time.
        /// </summary>
        /// <value>The job run time.</value>
        public String JobRunTime
        {
            get;
            set;
        }

        /// <summary>Gets or sets the JobStartDate field. </summary>
        public DateTime JobStartDate
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.AASCertification.MAASBLECertification - Master.MAASBLECertification.AASCertifications (m:1)'</summary>
        public ScheduleJobType JobType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the obs ind.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ScheduleJobCode field.
        /// </summary>
        /// <value>The schedule job code.</value>
        public String ScheduleJobCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ScheduleJobTriggerInfoId field.
        /// </summary>
        /// <value>The schedule job trigger info id.</value>
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
            if(obj == null)
            {
                return false;
            }
            ScheduleJobTriggerInfoEntity toCompareWith = obj as ScheduleJobTriggerInfoEntity;
            return toCompareWith == null ? false : ((this.ScheduleJobTriggerInfoId == toCompareWith.ScheduleJobTriggerInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ScheduleJobTriggerInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}