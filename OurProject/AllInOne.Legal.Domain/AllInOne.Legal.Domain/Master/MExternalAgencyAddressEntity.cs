namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MExternalAgencyAddressEntity'</summary>
    [Serializable]
    public class MExternalAgencyAddressEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the Address field. </summary>
        public String Address
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BlkNo field. </summary>
        public String BlkNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BuildingName field. </summary>
        public String BuildingName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExternalAgencyCode field. </summary>
        public String ExternalAgencyAddressId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExternalAgencyCode field. </summary>
        public System.String ExternalAgencyCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FloorNo field. </summary>
        public String FloorNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FormatInd field. </summary>
        public AddressFormatType FormatInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PostalCode field. </summary>
        public String PostalCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the StreetName field. </summary>
        public String StreetName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UnitNo field. </summary>
        public String UnitNo
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
            MExternalAgencyAddressEntity toCompareWith = obj as MExternalAgencyAddressEntity;
            return toCompareWith == null ? false : ((this.ExternalAgencyCode == toCompareWith.ExternalAgencyCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ExternalAgencyCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}