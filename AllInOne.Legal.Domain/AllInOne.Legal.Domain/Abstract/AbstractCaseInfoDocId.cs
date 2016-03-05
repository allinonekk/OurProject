#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for CaseInfoId and DocId details.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   18/02/2011   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AbstractCaseInfoDocId.cs
// Description: Represents a abstract class for CaseInfoId and DocId details.
// </summary>
// <copyright file= "AbstractCaseInfoDocId.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for CaseInfoId and DocId details.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractCaseInfoDocId : AbstractCaseInfo
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