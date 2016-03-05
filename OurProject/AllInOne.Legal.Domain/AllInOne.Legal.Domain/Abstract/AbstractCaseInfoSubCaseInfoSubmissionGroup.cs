#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for RecId, CaseInfo and SubmissionGroup details.
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
// File: AbstractRecIdCaseInfoSubmissionGroup.cs
// Description: Represents a abstract class for RecId, CaseInfo and SubmissionGroup details.
// </summary>
// <copyright file= "AbstractRecIdCaseInfoSubmissionGroup.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for RecId, CaseInfo and SubmissionGroup details.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractCaseInfoSubCaseInfoIdSubmissionGroup : AbstractCaseInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the rec id.
        /// </summary>
        /// <value>The rec id.</value>
        public String SubCaseInfoId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group id.</value>
        public String SubmissionGroupId
        {
            get; set;
        }

        #endregion Properties
    }
}