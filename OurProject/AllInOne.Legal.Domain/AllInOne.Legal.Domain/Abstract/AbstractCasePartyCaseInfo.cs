#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for CaseParty and CaseInfo details.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AbstractCasePartyCaseInfo.cs
// Description: Represents a abstract class for CaseParty and CaseInfo details.
// </summary>
// <copyright file= "AbstractCasePartyCaseInfo.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for CaseParty and CaseInfo details.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractCasePartyCaseInfo : AbstractCaseInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the case party id.
        /// </summary>
        /// <value>The case party id.</value>
        public string CasePartyId
        {
            get;
            set;
        }

        #endregion Properties
    }
}