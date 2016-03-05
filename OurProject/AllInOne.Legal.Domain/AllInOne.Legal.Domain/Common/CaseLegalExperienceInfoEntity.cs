namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.CaseLegalExperienceInfoEntity'</summary>
    [Serializable]
    public class CaseLegalExperienceInfoEntity : AbstractLastModified,  ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the EmploymentEndDate field. </summary>
        public DateTime? EmploymentEndDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EmploymentStartDate field. </summary>
        public DateTime? EmploymentStartDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExperienceLength field. </summary>
        public String ExperienceLength
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseLegalExperienceInfoId field. </summary>
        public String CaseLegalExperienceInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LegalExperienceType field. </summary>
        public LegalExperienceType LegalExperienceType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LFID field. </summary>
        public String LFID
        {
            get;
            set;
        }

        public String OrganisationName
        {
            get;
            set;
        }

        public LegalOrganizationType TypeofOrganization
        {
            get;
            set;
        }

        public String Designation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the CaseInfoId field.
        /// </summary>
        /// <value>The case info id.</value>
        public Int64 CaseInfoId
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
            CaseLegalExperienceInfoEntity toCompareWith = obj as CaseLegalExperienceInfoEntity;
            return toCompareWith == null ? false : ((this.CaseLegalExperienceInfoId == toCompareWith.CaseLegalExperienceInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseLegalExperienceInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}