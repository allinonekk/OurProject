namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.DegreeInfoEntity'</summary>
    [Serializable]
    public class DegreeInfoEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the AdmissionOn field. </summary>
        public DateTime? AdmissionOn
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ClassOfDegree field. </summary>
        public String ClassOfDegree
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ConfermentOfDegree field. </summary>
        public DateTime? ConfermentOfDegree
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CourseLength field. </summary>
        public String CourseLength
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DegreeInfoId field. </summary>
        public String DegreeInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DegreeType field. </summary>
        public DegreeType DegreeType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LawDegreeRemarks field. </summary>
        public String LawDegreeRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MAASLawDegree field. </summary>
        public MAASLawDegreeEntity MAASLawDegree
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MAASUniversity field. </summary>
        public MAASUniversityEntity MAASUniversity
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

        public String OtherDegree
        {
            get;
            set;
        }

        public String OtherUniversity
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public String Remarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UniversityRemarks field. </summary>
        public String UniversityRemarks
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
            DegreeInfoEntity toCompareWith = obj as DegreeInfoEntity;
            return toCompareWith == null ? false : ((this.DegreeInfoId == toCompareWith.DegreeInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DegreeInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}