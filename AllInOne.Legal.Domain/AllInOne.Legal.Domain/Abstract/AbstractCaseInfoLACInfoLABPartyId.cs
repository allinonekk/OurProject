#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for CaseInfo, LACInfo and LABPartyId details.
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
// File: AbstractCaseInfoLACInfoLABPartyId.cs
// Description: Represents a abstract class for CaseInfo, LACInfo and LABPartyId details.
// </summary>
// <copyright file= "AbstractCaseInfoLACInfoLABPartyId.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for CaseInfo, LACInfo and LABPartyId details.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractCaseInfoLACInfoLABPartyId : AbstractLastModified
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CaseInfoId field.
        /// </summary>
        /// <value>The case info id.</value>
        public string CaseInfoId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the LAB party id.
        /// </summary>
        /// <value>The LAB party id.</value>
        public string LABPartyId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LACInfoId field.
        /// </summary>
        /// <value>The LAC info id.</value>
        public String LACInfoId
        {
            get; set;
        }

        #endregion Properties
    }
}