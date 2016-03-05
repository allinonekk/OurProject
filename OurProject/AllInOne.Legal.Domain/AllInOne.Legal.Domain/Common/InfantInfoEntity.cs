#region Header

/*****************************************************************************************************
 * Description : This file represents a standard InfantInfoEntity.
 *----
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * Sep 20 2010  2:48PM        Japheth             	 	Created
 *****************************************************************************************************
 *	                                    File Usage
 *	Module
 *	1. Case Conversion
 *
 *****************************************************************************************************/
// <summary>
// File: InfantInfoEntity.cs
// Description: Represents a standard InfantInfoEntity.
// </summary>
// <copyright file= "InfantInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for InfantInfo.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class InfantInfoEntity : AbstractSubmissionGroup
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="InfantInfoEntity"/> class.</summary> 
        public InfantInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public string Address
        {
            get;
            set;
        }

        public Decimal? AgeInMonths
        {
            get;
            set;
        }

        public Decimal? AgeInYears
        {
            get;
            set;
        }

        public String BCNumber
        {
            get;
            set;
        }

        public MCountryEntity BirthCountry
        {
            get;
            set;
        }

        public String BirthCountryRemarks
        {
            get;
            set;
        }

        public String BlkNo
        {
            get;
            set;
        }

        public String BuildingName
        {
            get;
            set;
        }

        public DateTime DateOfBirth
        {
            get;
            set;
        }

        public String FloorNo
        {
            get;
            set;
        }

        public AddressFormatType FormatInd
        {
            get;
            set;
        }

        public String InfantInfoId
        {
            get;
            set;
        }

        public YesNo IsInfantMarried
        {
            get;
            set;
        }

        public YesNo IsInfantProperty
        {
            get;
            set;
        }

        public Int32 ItemNo
        {
            get;
            set;
        }

        public MCountryEntity MCountry
        {
            get;
            set;
        }

        public MGenderEntity MGender
        {
            get;
            set;
        }

        public MNationalityEntity MNationality
        {
            get;
            set;
        }

        public MRaceEntity MRace
        {
            get;
            set;
        }

        public String NameInBC
        {
            get;
            set;
        }

        public String NationalityRemarks
        {
            get;
            set;
        }

        public YesNo ObsInd
        {
            get;
            set;
        }

        public DateTime? PassExpiryDate
        {
            get;
            set;
        }

        public String PName
        {
            get;
            set;
        }

        public String PostalCode
        {
            get;
            set;
        }

        public String PropertyDetails
        {
            get;
            set;
        }

        public String RaceRemarks
        {
            get;
            set;
        }

        public MCountryEntity ResidenceCountry
        {
            get;
            set;
        }

        public String ResidenceCtryRemarks
        {
            get;
            set;
        }

        public String StreetName
        {
            get;
            set;
        }

        public String UnitNo
        {
            get;
            set;
        }

        #endregion Properties
    }
}