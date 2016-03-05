#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for SubCaseInfo details.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   30/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AbstractSubCaseInfo.cs
// Description: Represents a abstract class for SubCaseInfo details.
// </summary>
// <copyright file= "AbstractSubCaseInfo.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for SubCaseInfo details.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractSubCaseInfoLastModified : AbstractLastModified
    {
        #region Properties

        /// <summary>
        /// Gets or sets the sub case info id.
        /// </summary>
        /// <value>The sub case info id.</value>
        public string SubCaseInfoId
        {
            get; set;
        }

        #endregion Properties
    }
}