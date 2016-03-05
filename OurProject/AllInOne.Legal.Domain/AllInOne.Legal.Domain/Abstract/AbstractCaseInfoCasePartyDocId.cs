#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for DocId details with CaseParty and CaseInfo.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AbstractCaseInfoCasePartyDocId.cs
// Description: Represents a abstract class for DocId details with CaseParty and CaseInfo.
// </summary>
// <copyright file= "AbstractCaseInfoCasePartyDocId.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for DocId details with CaseParty and CaseInfo.
    /// It inherits from <see cref="AbstractCasePartyCaseInfo"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractCaseInfoCasePartyDocId : AbstractCasePartyCaseInfo
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