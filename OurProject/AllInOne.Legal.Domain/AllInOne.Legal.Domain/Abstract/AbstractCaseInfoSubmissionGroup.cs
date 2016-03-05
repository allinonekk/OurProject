#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for CaseInfo and SubmissionGroup details.
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
// File: AbstractCaseInfoSubmissionGroup.cs
// Description: Represents a abstract class for CaseInfo and SubmissionGroup details.
// </summary>
// <copyright file= "AbstractCaseInfoSubmissionGroup.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for CaseInfo and SubmissionGroup details.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractCaseInfoSubmissionGroup : AbstractCaseInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group id.</value>
        public String SubmissionGroupId
        {
            get;
            set;
        }

        #endregion Properties
    }
}