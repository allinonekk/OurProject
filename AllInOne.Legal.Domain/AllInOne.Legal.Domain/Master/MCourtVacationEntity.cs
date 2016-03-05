namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Abstract;

    /// <summary>Class which represents the entity 'Master.MCourtVacationEntity'</summary>
    public class MCourtVacationEntity :AbstractLastModified, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the DescriptionNotes field. </summary>
        public string CourtVacationId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EndDate field. </summary>
        public MForumTypeEntity MForumType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HolidayId field. </summary>
        public DateTime FromDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HolidayName field. </summary>
        public DateTime ToDate
        {
            get;
            set;
        }

        public YesNo ObsInd
        {
            get;
            set;
        }

        public string Description
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
            MCourtVacationEntity toCompareWith = obj as MCourtVacationEntity;
            return toCompareWith == null ? false : ((this.CourtVacationId == toCompareWith.CourtVacationId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CourtVacationId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}