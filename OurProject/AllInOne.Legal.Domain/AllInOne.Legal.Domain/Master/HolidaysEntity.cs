namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.HolidaysEntity'</summary>
    public class HolidaysEntity : IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the DescriptionNotes field. </summary>
        public String DescriptionNotes
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EndDate field. </summary>
        public DateTime EndDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HolidayId field. </summary>
        public String HolidayId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HolidayName field. </summary>
        public String HolidayName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the StartDate field. </summary>
        public DateTime StartDate
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
            HolidaysEntity toCompareWith = obj as HolidaysEntity;
            return toCompareWith == null ? false : ((this.HolidayId == toCompareWith.HolidayId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HolidayId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}