#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for CaseParty details.
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
// File: AbstractCaseParty.cs
// Description: Represents a abstract class for CaseParty details.
// </summary>
// <copyright file= "AbstractCaseParty.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for CaseParty details.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractCaseParty : AbstractLastModified
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