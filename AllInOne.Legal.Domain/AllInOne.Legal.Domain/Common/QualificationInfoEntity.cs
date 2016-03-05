namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.QualificationInfo'</summary>
    public class QualificationInfoEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the AASQualificationRemarks field. </summary>
        public System.String AASQualificationRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfAdmission field. </summary>
        public Nullable<System.DateTime> DateOfAdmission
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfCompletion field. </summary>
        public Nullable<System.DateTime> DateOfCompletion
        {
            get;
            set;
        }

        /// <summary>Gets or sets the InstitutionName field. </summary>
        public System.String InstitutionName
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.QualificationInfo.MAASQualification - Master.MAASQualification.QualificationInfos (m:1)'</summary>
        public MAASQualificationEntity MAASQualification
        {
            get;
            set;
        }

        /// <summary>Gets or sets the QualificationInfoId field. </summary>
        public System.String QualificationInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the QualificationRemarks field. </summary>
        public System.String QualificationRemarks
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
            QualificationInfoEntity  toCompareWith = obj as QualificationInfoEntity;
            return toCompareWith == null ? false : ((this.QualificationInfoId == toCompareWith.QualificationInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.QualificationInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}