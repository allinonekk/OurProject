namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    public class MHolidayEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the HolidayDate field. </summary>
        public System.DateTime HolidayDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Year field. </summary>
        public System.Int32 Year
        {
            get;
            set;
        }

        public string HolidayType { get; set; }
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
            MHolidayEntity toCompareWith = obj as MHolidayEntity;
            return toCompareWith == null ? false : ((this.HolidayDate == toCompareWith.HolidayDate));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HolidayDate.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}