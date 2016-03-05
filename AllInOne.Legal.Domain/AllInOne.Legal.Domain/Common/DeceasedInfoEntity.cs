#region Header

/*****************************************************************************************************
 * Description : This file represents a standard DeceasedInfo entity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			        Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010               Japheth             	Created
 *****************************************************************************************************/
// <summary>
// File: DeceasedInfoEntity.cs
// Description: Represents a standard DeceasedInfo entity.
// </summary>
// <copyright file= "DeceasedInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for DeceasedInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class DeceasedInfoEntity : AbstractSubmissionGroup
    {
        #region Properties

        /// <summary>
        /// Gets or sets the addr1.
        /// </summary>
        /// <value>The addr1.</value>
        public String Addr1
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the addr2.
        /// </summary>
        /// <value>The addr2.</value>
        public String Addr2
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the addr3.
        /// </summary>
        /// <value>The addr3.</value>
        public String Addr3
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the addr4.
        /// </summary>
        /// <value>The addr4.</value>
        public String Addr4
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public String Address
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the BLK no.
        /// </summary>
        /// <value>The BLK no.</value>
        public String BlkNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the name of the building.
        /// </summary>
        /// <value>The name of the building.</value>
        public String BuildingName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the death from date.
        /// </summary>
        /// <value>The death from date.</value>
        public DateTime? DeathFromDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the death place.
        /// </summary>
        /// <value>The death place.</value>
        public String DeathPlace
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the death to date.
        /// </summary>
        /// <value>The death to date.</value>
        public DateTime? DeathToDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the deceased info id.
        /// </summary>
        /// <value>The deceased info id.</value>
        public String DeceasedInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the decsd.
        /// </summary>
        /// <value>The name of the decsd.</value>
        public String DecsdName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the state of the domicile.
        /// </summary>
        /// <value>The state of the domicile.</value>
        public String DomicileState
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the floor no.
        /// </summary>
        /// <value>The floor no.</value>
        public String FloorNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the FormatInd field.
        /// </summary>
        /// <value>The format ind.</value>
        public AddressFormatType FormatInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is address available.
        /// </summary>
        /// <value>The is address available.</value>
        public YesNo IsAddressAvailable
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the M country.
        /// </summary>
        /// <value>The M country.</value>
        public MCountryEntity MCountry
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the M domicile country.
        /// </summary>
        /// <value>The M domicile country.</value>
        public MCountryEntity MDomicileCountry
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the M gender.
        /// </summary>
        /// <value>The M gender.</value>
        public MGenderEntity MGender
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the M marital status.
        /// </summary>
        /// <value>The M marital status.</value>
        public MMaritalStatusEntity MMaritalStatus
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the M nationality.
        /// </summary>
        /// <value>The M nationality.</value>
        public MNationalityEntity MNationality
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the M person ID group.
        /// </summary>
        /// <value>The M person ID group.</value>
        public MPersonIDGroupEntity MPersonIdGroup
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the M religion.
        /// </summary>
        /// <value>The M religion.</value>
        public MReligionEntity MReligion
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the nationality RMK.
        /// </summary>
        /// <value>The nationality RMK.</value>
        public String NationalityRmk
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>The postal code.</value>
        public String PostalCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the relgn RMK.
        /// </summary>
        /// <value>The relgn RMK.</value>
        public String RelgnRmk
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the school relgn.
        /// </summary>
        /// <value>The school relgn.</value>
        public String SchoolRelgn
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the name of the street.
        /// </summary>
        /// <value>The name of the street.</value>
        public String StreetName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the unit no.
        /// </summary>
        /// <value>The unit no.</value>
        public String UnitNo
        {
            get; set;
        }

        public string DomicileCountryOtherText { get; set; }

        public string CountryOtherText { get; set; }

        public String EstateValueCode { get; set; }
        #endregion Properties
    }
}