#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RCaseConversionEntity.
 *----
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * Oct 12 2010  3:39PM        Japheth             	 	Created
 *****************************************************************************************************
 *	                                    File Usage
 *	Module
 *	1. Case Conversion
 *
 *****************************************************************************************************/
// <summary>
// File: RCaseConversionEntity.cs
// Description: Represents a standard RCaseConversionEntity.
// </summary>
// <copyright file= "RCaseConversionEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for RCaseConversion.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class RCaseConversionEntity : AbstractCaseInfo
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="RCaseConversionEntity"/> class.</summary> 
        public RCaseConversionEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public string CaseConversionId
        {
            get; set;
        }

        public string ConCaseInfoID
        {
            get; set;
        }

        public YesNo ObsInd
        {
            get; set;
        }

        #endregion Properties
    }
}