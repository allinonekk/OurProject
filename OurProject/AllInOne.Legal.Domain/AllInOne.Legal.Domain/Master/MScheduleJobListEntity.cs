namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MScheduleJobListEntity'</summary>
    public class MScheduleJobListEntity : AbstractMasterInfo, IMasterEntity
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

        /// <summary>
        /// Gets or sets the name of the job class.
        /// </summary>
        /// <value>The name of the job class.</value>
        public String JobClassName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the job group.
        /// </summary>
        /// <value>The job group.</value>
        public String JobGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the job.
        /// </summary>
        /// <value>The name of the job.</value>
        public String JobName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the schedule job code.
        /// </summary>
        /// <value>The schedule job code.</value>
        public String ScheduleJobCode
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
            MScheduleJobListEntity toCompareWith = obj as MScheduleJobListEntity;
            return toCompareWith == null ? false : ((this.ScheduleJobCode == toCompareWith.ScheduleJobCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ScheduleJobCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}