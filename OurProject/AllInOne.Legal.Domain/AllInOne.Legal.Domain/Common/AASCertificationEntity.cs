namespace AllInOne.Legal.Domain.Common
{
    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Case.AASCertificationEntity'</summary>
    public class AASCertificationEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the AASCertificationId field. </summary>
        public System.String AASCertificationId
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.AASCertification.CaseInfo - Case.CaseInfo.AASCertifications (m:1)'</summary>
        //public  CaseInfoEntity CaseInfo
        //{
        //    get;
        //    set;
        //}
        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public System.String CaseInfoId
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.AASCertification.MAASBLECertification - Master.MAASBLECertification.AASCertifications (m:1)'</summary>
        public MAASBLECertificationEntity MAASBLECertification
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public YesNo ObsInd
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
            AASCertificationEntity toCompareWith = obj as AASCertificationEntity;
            return toCompareWith == null ? false : ((this.AASCertificationId == toCompareWith.AASCertificationId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AASCertificationId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}