#region Header

/*****************************************************************************************************
 * Description : This file represents a standard JudDocDetailsEntity.
 *----
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * Sep 20 2010  2:59PM        Japheth             	 	Created
 *****************************************************************************************************
 *	                                    File Usage
 *	Module
 *	1. Case Conversion
 *
 *****************************************************************************************************/
// <summary>
// File: JudDocDetailsEntity.cs
// Description: Represents a standard JudDocDetailsEntity.
// </summary>
// <copyright file= "JudDocDetailsEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for JudDocDetails.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class JudDocDetailsEntity : AbstractCaseInfo
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="JudDocDetailsEntity"/> class.</summary> 
        public JudDocDetailsEntity()
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

        public string JudForClaimTypeQ
        {
            get; set;
        }

        public string OfficerName
        {
            get; set;
        }

        #endregion Properties
    }
}