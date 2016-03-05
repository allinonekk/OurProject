namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.PracticeTrainingPeriodInfoEntity'</summary>
    [Serializable]
    public class PracticeTrainingPeriodInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the LFID field. </summary>
        public String LFID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NameOfPupilMaster field. </summary>
        public String NameOfPupilMaster
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OtherLawPractice field. </summary>
        public String OtherLawPractice
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PracticeTrainingPeriodInfoId field. </summary>
        public String PracticeTrainingPeriodInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PupillageFromDate field. </summary>
        public DateTime? PupillageFromDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PupillageToDate field. </summary>
        public DateTime? PupillageToDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the case information identifier.
        /// </summary>
        /// <value>
        /// The case information identifier.
        /// </value>
        public Int64? CaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the solicitor identifier.
        /// </summary>
        /// <value>
        /// The solicitor identifier.
        /// </value>
        public Int64? SolicitorId
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
            PracticeTrainingPeriodInfoEntity toCompareWith = obj as PracticeTrainingPeriodInfoEntity;
            return toCompareWith == null ? false : ((this.PracticeTrainingPeriodInfoId == toCompareWith.PracticeTrainingPeriodInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PracticeTrainingPeriodInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}