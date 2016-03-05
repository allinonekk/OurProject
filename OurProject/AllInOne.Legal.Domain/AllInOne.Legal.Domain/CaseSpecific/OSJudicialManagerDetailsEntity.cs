#region Header

/*****************************************************************************************************
 * Description : This file represents a standard OSJudicialManagerDetailsEntity.
 *----
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * Sep 20 2010  2:39PM        Japheth             	 	Created
 *****************************************************************************************************
 *	                                    File Usage
 *	Module
 *	1. Case Conversion
 *
 *****************************************************************************************************/
// <summary>
// File: OSJudicialManagerDetailsEntity.cs
// Description: Represents a standard OSJudicialManagerDetailsEntity.
// </summary>
// <copyright file= "OSJudicialManagerDetailsEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for OSJudicialManagerDetails.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class OSJudicialManagerDetailsEntity : AbstractSubmissionGroup
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="OSJudicialManagerDetailsEntity"/> class.</summary> 
        public OSJudicialManagerDetailsEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public Int32 ItemNo
        {
            get;
            set;
        }

        public string JMIDNumber
        {
            get;
            set;
        }

        public string JMIDRemarks
        {
            get;
            set;
        }

        public string JMName
        {
            get;
            set;
        }

        public MCountryEntity MCountry
        {
            get;
            set;
        }

        public MPersonIDGroupEntity MPersonIDGroup
        {
            get;
            set;
        }

        public MPersonIDTypeEntity MPersonIDType
        {
            get;
            set;
        }

        public String OSJudicialManagerDetailId
        {
            get;
            set;
        }

        #endregion Properties
    }
}