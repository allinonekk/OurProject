#region Header

/*****************************************************************************************************
* Description : This file represents a standard CasePartyBailorAddress entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   20/01/2011   		      CJ                 	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CasePartyBailorAddressEntity.cs
// Description: Represents a standard CasePartyBailorAddress entity.
// </summary>
// <copyright file= "CasePartyBailorAddressEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Case.CasePartyBailorAddress'</summary>
    [Serializable]
    public class CasePartyBailorAddressEntity : AbstractLastModified, ICaseEntity
    {
        #region Properties

        /// <summary>Gets or sets the Addr1 field. </summary>
        public String Addr1
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr2 field. </summary>
        public String Addr2
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr3 field. </summary>
        public String Addr3
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr4 field. </summary>
        public String Addr4
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Address field. </summary>
        public String Address
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

        /// <summary>Gets or sets the CasePartyBailorAddressId field. </summary>
        public String CasePartyBailorAddressId
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyBailorAddress.CasePartyBailorInfo - Case.CasePartyBailorInfo.CasePartyBailorAddresses (m:1)'</summary>
        public String CasePartyBailorInfoId
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

        /// <summary>Gets or sets the MailingInd field. </summary>
        public YesNo MailingInd
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyBailorAddress.MCountry - Master.MCountry.CasePartyBailorAddresses (m:1)'</summary>
        public MCountryEntity MCountry
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
            if(obj == null)
            {
                return false;
            }
            CasePartyBailorAddressEntity toCompareWith = obj as CasePartyBailorAddressEntity;
            return toCompareWith == null ? false : ((this.CasePartyBailorAddressId == toCompareWith.CasePartyBailorAddressId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CasePartyBailorAddressId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}