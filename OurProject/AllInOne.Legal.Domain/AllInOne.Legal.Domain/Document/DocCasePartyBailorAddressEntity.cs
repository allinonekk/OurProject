#region Header

/*****************************************************************************************************
* Description : This file represents a standard DocCasePartyBailorAddress entity.
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
// File: DocCasePartyBailorAddressEntity.cs
// Description: Represents a standard DocCasePartyBailorAddress entity.
// </summary>
// <copyright file= "DocCasePartyBailorAddressEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Document.DocCasePartyBailorAddress'</summary>
    [Serializable]
    public class DocCasePartyBailorAddressEntity : AbstractLastModified, IDocumentEntity
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

        /// <summary>Gets or sets the DocCasePartyBailorAddressId field. </summary>
        public String DocCasePartyBailorAddressId
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyBailorAddress.DocCasePartyBailorInfo - Document.DocCasePartyBailorInfo.DocCasePartyBailorAddresses (m:1)'</summary>
        public String DocCasePartyBailorInfoId
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

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyBailorAddress.MCountry - Master.MCountry.DocCasePartyBailorAddresses (m:1)'</summary>
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
            DocCasePartyBailorAddressEntity toCompareWith = obj as DocCasePartyBailorAddressEntity;
            return toCompareWith == null ? false : ((this.DocCasePartyBailorAddressId == toCompareWith.DocCasePartyBailorAddressId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocCasePartyBailorAddressId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}