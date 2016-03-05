namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'BackEndSpecific.ContinuingLegalEducationInfoEntity'</summary>
    public class ContinuingLegalEducationInfoEntity : AbstractSubmissionGroup, IBackEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the DACCaseNumber.
        /// </summary>
        public String AreaOfLaw
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Remarks.
        /// </summary>
        public Int32? CLEPoint
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PeriodStartDate.
        /// </summary>
        public String CLEProvider
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DisciplinaryActionInfoId.
        /// </summary>
        public String ContinuingLegalEducationInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Result.
        /// </summary>
        public DateTime? Date
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Remarks.
        /// </summary>
        public String Duration
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DisciplinaryTypeRemarks.
        /// </summary>
        public String NameOfCourse
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PeriodEndDate.
        /// </summary>
        public String Venue
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

            ContinuingLegalEducationInfoEntity toCompareWith = obj as ContinuingLegalEducationInfoEntity;
            return toCompareWith == null ? false : ((this.ContinuingLegalEducationInfoId == toCompareWith.ContinuingLegalEducationInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ContinuingLegalEducationInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}