namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Case.ScheduleJobTriggerDetailEntity'</summary>
    public class ScheduleJobTriggerDetailEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the DayInTheMonth field.
        /// </summary>
        /// <value>The day in the month.</value>
        public Int32? DayInTheMonth
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.DayInTheWeek- Master.DayInTheWeek(m:1)'
        /// </summary>
        /// <value>The day in the week.</value>
        public DayInTheWeek DayInTheWeek
        {
            get;
            set;
        }

        public Int32? MonthInTheYear
        {
            get;
            set;
        }

        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ScheduleJobTriggerDetailId field. </summary>
        public String ScheduleJobTriggerDetailId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ScheduleJobTriggerInfoId field. </summary>
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
            ScheduleJobTriggerDetailEntity toCompareWith = obj as ScheduleJobTriggerDetailEntity;
            return toCompareWith == null ? false : ((this.ScheduleJobTriggerDetailId == toCompareWith.ScheduleJobTriggerDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ScheduleJobTriggerDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}