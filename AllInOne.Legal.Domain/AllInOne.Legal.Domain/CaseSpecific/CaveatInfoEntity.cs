namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'CaseSpecific.CaveatAAInfo'</summary>
    [Serializable]
    public class CaveatInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the CaveatAAInfoId field. </summary>
        public String CaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IMONumber field. </summary>
        public String CaveatType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MCountry field. </summary>
        public DateTime? CaveatLapsedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MPersonIDGroup field. </summary>
        public string CaseNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PortOfRegistration field. </summary>
        public DateTime? CaveatWithdrawnDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the RegistrationNumber field. </summary>
        public string ForumId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the VesselIdType field. </summary>
        public string CaveatInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the VesselOrPropertyName field. </summary>
        public long? SubCaseInfoId
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
            CaveatInfoEntity toCompareWith = obj as CaveatInfoEntity;
            return toCompareWith == null ? false : ((this.CaveatInfoId == toCompareWith.CaveatInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaveatInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}