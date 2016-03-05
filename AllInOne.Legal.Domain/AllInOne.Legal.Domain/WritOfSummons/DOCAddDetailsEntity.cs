#region Header

/*****************************************************************************************************
 * Description : This file represents a standard DOCAddDetailsEntity.
 *----
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * Sep 20 2010  2:57PM        Japheth             	 	Created
 *****************************************************************************************************
 *	                                    File Usage
 *	Module
 *	1. Case Conversion
 *
 *****************************************************************************************************/
// <summary>
// File: DOCAddDetailsEntity.cs
// Description: Represents a standard DOCAddDetailsEntity.
// </summary>
// <copyright file= "DOCAddDetailsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.WritOfSummons
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for DOCAddDetails.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class DOCAddDetailsEntity : AbstractCaseInfo
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="DOCAddDetailsEntity"/> class.</summary> 
        public DOCAddDetailsEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public DateTime DateOfHRGOrJDG
        {
            get; set;
        }

        public string DocID
        {
            get; set;
        }

        public string ExtractOrder
        {
            get; set;
        }

        public string JDGType
        {
            get; set;
        }

        public string JudForClaimType
        {
            get; set;
        }

        public int NoOfHRGDays
        {
            get; set;
        }

        public int NOOfWit
        {
            get; set;
        }

        public string OfficerName
        {
            get; set;
        }

        public DateTime RenewalEffectiveDate
        {
            get; set;
        }

        public object RenewalPeriod
        {
            get; set;
        }

        #endregion Properties
    }
}