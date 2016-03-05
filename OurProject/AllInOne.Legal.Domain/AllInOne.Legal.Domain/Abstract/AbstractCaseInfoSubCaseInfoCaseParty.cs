#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for SubCaseParty details.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/11/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AbstractCaseInfoSubCaseInfoCaseParty.cs
// Description: Represents a abstract class for SubCaseParty details.
// </summary>
// <copyright file= "AbstractCaseInfoSubCaseInfoCaseParty.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for SubCaseParty details.
    /// It inherits from <see cref="AbstractSubCaseInfo"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractCaseInfoSubCaseInfoCaseParty : AbstractSubCaseInfo
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