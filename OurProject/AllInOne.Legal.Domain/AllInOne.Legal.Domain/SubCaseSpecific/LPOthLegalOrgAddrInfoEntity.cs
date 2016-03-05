namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.LPOthLegalOrgAddrInfoEntity'</summary>
    public class LPOthLegalOrgAddrInfoEntity : AbstractSubmissionGroup, ISubCaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the Addr1 field. </summary>
        public System.String Addr1
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr2 field. </summary>
        public System.String Addr2
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr3 field. </summary>
        public System.String Addr3
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr4 field. </summary>
        public System.String Addr4
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Address field. </summary>
        public System.String Address
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AddrType field. </summary>
        public AddressType AddrType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BlkNo field. </summary>
        public System.String BlkNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BuildingName field. </summary>
        public System.String BuildingName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FloorNo field. </summary>
        public System.String FloorNo
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

        /// <summary>Gets or sets the LPOthLegalOrgAddrInfoId field. </summary>
        public System.String LPOthLegalOrgAddrInfoId
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.LPOthLegalOrgAddrInfo.LPOthLegalOrgInfo - Common.LPOthLegalOrgInfo.LPOthLegalOrgAddrInfos (m:1)'</summary>
        //public  LPOthLegalOrgInfoEntity LPOthLegalOrgInfo
        //{
        //    get;
        //    set;
        //}
        /// <summary>Gets or sets the LPOthLegalOrgInfoId field. </summary>
        public System.String LPOthLegalOrgInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CountryCode field. </summary>
        public MCountryEntity MCountry
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PostalCode field. </summary>
        public System.String PostalCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the StreetName field. </summary>
        public System.String StreetName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UnitNo field. </summary>
        public System.String UnitNo
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
            LPOthLegalOrgAddrInfoEntity toCompareWith = obj as LPOthLegalOrgAddrInfoEntity;
            return toCompareWith == null ? false : ((this.LPOthLegalOrgAddrInfoId == toCompareWith.LPOthLegalOrgAddrInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LPOthLegalOrgAddrInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}