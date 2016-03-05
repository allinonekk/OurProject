#region Header

/*****************************************************************************************************
* Description : This file represents a standard CasePartyBailorInfo entity.
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
// File: CasePartyBailorInfoEntity.cs
// Description: Represents a standard CasePartyBailorInfo entity.
// </summary>
// <copyright file= "CasePartyBailorInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Case.CasePartyBailorInfo'</summary>
    [Serializable]
    public class CasePartyBailorInfoEntity : AbstractCaseParty, ICaseEntity
    {
        #region Properties

        /// <summary>Gets or sets the BailAmount field. </summary>
        public Decimal? BailAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BailorName field. </summary>
        public String BailorName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BailRemarks field. </summary>
        public String BailRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyBailorAddress.CasePartyBailorInfo - Case.CasePartyBailorInfo.CasePartyBailorAddresses (m:1)'
        /// </summary>
        /// <value>The case party bailor addresses.</value>
        public List<CasePartyBailorAddressEntity> CasePartyBailorAddresses
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CasePartyBailorInfoId field. </summary>
        public String CasePartyBailorInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ContactTypeInd field. </summary>
        public ContactType ContactTypeInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateBailDischarged field. </summary>
        public DateTime? DateBailDischarged
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateBailFurnished field. </summary>
        public DateTime? DateBailFurnished
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateBailGranted field. </summary>
        public DateTime? DateBailGranted
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Email field. </summary>
        public String Email
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FaxAreaCode field. </summary>
        public String FaxAreaCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FaxCountryCode field. </summary>
        public String FaxCountryCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FaxNumber field. </summary>
        public String FaxNumber
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IDGroupCode field. </summary>
        public MPersonIDGroupEntity IDGroupCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IdNumber field. </summary>
        public String IdNumber
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyBailorInfo.MBailType - Master.MBailType.CasePartyBailorInfos (m:1)'</summary>
        public MBailTypeEntity MBailType
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyBailorInfo.MCountry - Master.MCountry.CasePartyBailorInfos (m:1)'</summary>
        public MCountryEntity MCountry
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MobileCountryCode field. </summary>
        public String MobileCountryCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MobileNumber field. </summary>
        public String MobileNumber
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyBailorInfo.MPersonIDType - Master.MPersonIDType.CasePartyBailorInfos (m:1)'</summary>
        public MIDTypeEntity MIDType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TelAreaCode field. </summary>
        public String TelAreaCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TelCountryCode field. </summary>
        public String TelCountryCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TelNumber field. </summary>
        public String TelNumber
        {
            get;
            set;
        }

        public String IdRemarks
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
            CasePartyBailorInfoEntity toCompareWith = obj as CasePartyBailorInfoEntity;
            return toCompareWith == null ? false : ((this.CasePartyBailorInfoId == toCompareWith.CasePartyBailorInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CasePartyBailorInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}