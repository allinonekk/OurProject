#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for DocId details with CaseInfo and SubCaseInfo.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   14/11/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AbstractCaseInfoSubCaseInfoDocId.cs
// Description: Represents a abstract class for DocId details with CaseInfo and SubCaseInfo.
// </summary>
// <copyright file= "AbstractCaseInfoSubCaseInfoDocId.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for DocId details with CaseInfo and SubCaseInfo.
    /// It inherits from <see cref="AbstractSubCaseInfo"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractCaseInfoSubCaseInfoDocId : AbstractSubCaseInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the doc id.
        /// </summary>
        /// <value>The doc id.</value>
        public String DocId
        {
            get; set;
        }

        #endregion Properties
    }
}