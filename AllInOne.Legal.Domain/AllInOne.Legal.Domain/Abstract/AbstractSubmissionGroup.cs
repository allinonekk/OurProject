#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for SubmissionGroup details.
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
// File: AbstractSubmissionGroup.cs
// Description: Represents a abstract class for SubmissionGroup details.
// </summary>
// <copyright file= "AbstractSubmissionGroup.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for SubmissionGroup details.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractSubmissionGroup : AbstractLastModified
    {
        #region Properties

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