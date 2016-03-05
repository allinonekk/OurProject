#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for RecId and CaseInfo details.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AbstractRecIdCaseInfo.cs
// Description: Represents a abstract class for RecId and CaseInfo details.
// </summary>
// <copyright file= "AbstractRecIdCaseInfo.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for RecId and CaseInfo details.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractRecIdCaseInfo : AbstractCaseInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the rec id.
        /// </summary>
        /// <value>The rec id.</value>
        public String RecId
        {
            get; set;
        }

        #endregion Properties
    }
}