namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'CaseSpecific.CaveatAAInfo'</summary>
    [Serializable]
    public class CaveatAAInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the CaveatAAInfoId field. </summary>
        public String CaveatAAInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IMONumber field. </summary>
        public String IMONumber
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

        /// <summary>Gets or sets the MPersonIDGroup field. </summary>
        public MPersonIDGroupEntity MPersonIDGroup
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PortOfRegistration field. </summary>
        public String PortOfRegistration
        {
            get;
            set;
        }

        /// <summary>Gets or sets the RegistrationNumber field. </summary>
        public String RegistrationNumber
        {
            get;
            set;
        }

        /// <summary>Gets or sets the VesselIdType field. </summary>
        public VesselIdType VesselIdType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the VesselOrPropertyName field. </summary>
        public String VesselOrPropertyName
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
            CaveatAAInfoEntity toCompareWith = obj as CaveatAAInfoEntity;
            return toCompareWith == null ? false : ((this.CaveatAAInfoId == toCompareWith.CaveatAAInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaveatAAInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}