#region Header

/*****************************************************************************************************
 * Description : This file represents a standard WOSADDetailsEntity.
 *----
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * Sep 20 2010  2:55PM        Japheth             	 	Created
 *****************************************************************************************************
 *	                                    File Usage
 *	Module
 *	1. Case Conversion
 *
 *****************************************************************************************************/
// <summary>
// File: WOSADDetailsEntity.cs
// Description: Represents a standard WOSADDetailsEntity.
// </summary>
// <copyright file= "WOSADDetailsEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for WOSADDetails.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class WOSADDetailsEntity : AbstractCaseInfo
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="WOSADDetailsEntity"/> class.</summary> 
        public WOSADDetailsEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public object AmountAwarded
        {
            get; set;
        }

        public string BodyPart
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public int WOSADDetailsID
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