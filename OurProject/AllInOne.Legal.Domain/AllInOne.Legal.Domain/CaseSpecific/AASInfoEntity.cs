namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Case.AASCertificationEntity'</summary>
    [Serializable]
    public class AASInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the AASInfoId field. </summary>
        public String AASInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AASQualificationRemarks field. </summary>
        public String AASQualificationRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BLEDocExemptionRemarks field. </summary>
        public String BLEDocExemptionRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsMLawExemptionApproved field. </summary>
        public YesNo IsMLawExemptionApproved
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LPALPRSectionType field. </summary>
        public LPALPRSectionOrProvision LPALPRSectionType
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

        /// <summary>Gets or sets the QualifiedPersonDate field. </summary>
        public DateTime? QualifiedPersonDate
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
            AASInfoEntity toCompareWith = obj as AASInfoEntity;
            return toCompareWith == null ? false : ((this.AASInfoId == toCompareWith.AASInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AASInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}