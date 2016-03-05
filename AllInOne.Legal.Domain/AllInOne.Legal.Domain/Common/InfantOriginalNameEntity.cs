#region Header

/*****************************************************************************************************
 * Description : This file represents a standard InfantOriginalNameEntity.
 *----
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * Sep 20 2010  2:49PM        Japheth             	 	Created
 *****************************************************************************************************
 *	                                    File Usage
 *	Module
 *	1. Case Conversion
 *
 *****************************************************************************************************/
// <summary>
// File: InfantOriginalNameEntity.cs
// Description: Represents a standard InfantOriginalNameEntity.
// </summary>
// <copyright file= "InfantOriginalNameEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for InfantOriginalName.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class InfantOriginalNameEntity : AbstractCaseInfo
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="InfantOriginalNameEntity"/> class.</summary> 
        public InfantOriginalNameEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public string DocumentName
        {
            get; set;
        }

        public string IDNumber
        {
            get; set;
        }

        public string InfantInfoID
        {
            get; set;
        }

        public int ItemNo
        {
            get; set;
        }

        public string ObsInd
        {
            get; set;
        }

        public string OtherName
        {
            get; set;
        }

        #endregion Properties
    }
}