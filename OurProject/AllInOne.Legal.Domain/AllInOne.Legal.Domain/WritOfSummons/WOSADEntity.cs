#region Header

/*****************************************************************************************************
 * Description : This file represents a standard WOSADEntity.
 *----
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * Sep 20 2010  2:53PM        Japheth             	 	Created
 *****************************************************************************************************
 *	                                    File Usage
 *	Module
 *	1. Case Conversion
 *
 *****************************************************************************************************/
// <summary>
// File: WOSADEntity.cs
// Description: Represents a standard WOSADEntity.
// </summary>
// <copyright file= "WOSADEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for WOSAD.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class WOSADEntity : AbstractCaseInfo
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="WOSADEntity"/> class.</summary> 
        public WOSADEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public DateTime AwardDate
        {
            get; set;
        }

        public string CasePartyAccessed
        {
            get; set;
        }

        public string Comments
        {
            get; set;
        }

        public string Coram
        {
            get; set;
        }

        public object LOAAmountAwarded
        {
            get; set;
        }

        public object LOELAmountAwarded
        {
            get; set;
        }

        public object LOFEAmount
        {
            get; set;
        }

        public object LOFEAmountAwarded
        {
            get; set;
        }

        public int Multiplier
        {
            get; set;
        }

        public string NANumber
        {
            get; set;
        }

        public int PartyAge
        {
            get; set;
        }

        public object PSAmountAwarded
        {
            get; set;
        }

        public string SubmissionGroupID
        {
            get; set;
        }

        public int WOSADID
        {
            get; set;
        }

        #endregion Properties
    }
}