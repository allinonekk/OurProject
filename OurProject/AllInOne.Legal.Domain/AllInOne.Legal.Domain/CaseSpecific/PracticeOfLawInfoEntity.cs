namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Case.AASCertificationEntity'</summary>
    [Serializable]
    public class PracticeOfLawInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the DescriptionOfQualification field. </summary>
        public String DescriptionOfQualification
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastPracticingCertDate field. </summary>
        public DateTime? LastPracticingCertDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MCountry field. </summary>
        public MCountryEntity MCountry
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PracticeOfLawInfoId field. </summary>
        public String PracticeOfLawInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the QualificationDate field. </summary>
        public DateTime? QualificationDate
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
            PracticeOfLawInfoEntity toCompareWith = obj as PracticeOfLawInfoEntity;
            return toCompareWith == null ? false : ((this.PracticeOfLawInfoId == toCompareWith.PracticeOfLawInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PracticeOfLawInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}