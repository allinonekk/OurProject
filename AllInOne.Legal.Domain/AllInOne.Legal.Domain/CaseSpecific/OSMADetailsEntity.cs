#region Header

/*****************************************************************************************************
 * Description : This file represents a standard OSMADetailsEntity.
 *----
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * Sep 20 2010  2:42PM        Japheth             	 	Created
 *****************************************************************************************************
 *	                                    File Usage
 *	Module
 *	1. Case Conversion
 *
 *****************************************************************************************************/
// <summary>
// File: OSMADetailsEntity.cs
// Description: Represents a standard OSMADetailsEntity.
// </summary>
// <copyright file= "OSMADetailsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for OSMADetails.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class OSMADetailsEntity : AbstractSubmissionGroup
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="OSMADetailsEntity"/> class.</summary> 
        public OSMADetailsEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public String Addr1
        {
            get; set;
        }

        public String Addr2
        {
            get; set;
        }

        public String Addr3
        {
            get; set;
        }

        public String Addr4
        {
            get; set;
        }

        public String Address
        {
            get; set;
        }

        public String BlkNo
        {
            get; set;
        }

        public String BuildingName
        {
            get; set;
        }

        public String FloorNo
        {
            get; set;
        }

        public AddressFormatType FormatInd
        {
            get; set;
        }

        public Int32 ItemNo
        {
            get; set;
        }

        public MCountryEntity MCountry
        {
            get; set;
        }

        public MPropertyTypeEntity MPropertyType
        {
            get; set;
        }

        public String OSMADetailId
        {
            get;
            set;
        }

        public String PostalCode
        {
            get; set;
        }

        public String PRopertyTypeRemarks
        {
            get; set;
        }

        public String StreetName
        {
            get; set;
        }

        public String UnitNo
        {
            get; set;
        }

        #endregion Properties
    }
}