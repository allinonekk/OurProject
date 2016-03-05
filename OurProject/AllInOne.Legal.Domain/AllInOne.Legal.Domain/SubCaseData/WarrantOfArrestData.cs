#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for WarrantOfArrest sub case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   08/11/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: WarrantOfArrestData.cs
// Description: Represents a standard data container object for WarrantOfArrest sub case type.
// </summary>
// <copyright file= "WarrantOfArrestData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseData
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCaseSpecific;

    /// <summary>
    /// Represents a standard data container object for WarrantOfArrest sub case type.
    /// </summary>
    [Serializable]
    public class WarrantOfArrestData : ISubCaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ADMWA info.
        /// </summary>
        /// <value>The ADMWA info.</value>
        public ADMWAInfoEntity ADMWAInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="RefCaveatCaseEntity"/> list.
        /// </summary>
        /// <value>The <see cref="RefCaveatCaseEntity"/> entity list.</value>
        public List<RefCaveatCaseEntity> ListRefCaveatCaseEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}