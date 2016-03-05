#region Header

/*****************************************************************************************************
* Description : This file represents a standard class for Last Modified details.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   16/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LastModified.cs
// Description: Represents a standard class for Last Modified details.
// </summary>
// <copyright file= "LastModified.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a standard class for Last Modified details.
    /// </summary>
    [Serializable]
    public abstract class AbstractLastModified
    {
        #region Properties

        /// <summary>
        /// Gets or sets the LastModifiedBy field.
        /// </summary>
        /// <value>The last modified by.</value>
        public String LastModifiedBy
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedDate field.
        /// </summary>
        /// <value>The last modified date.</value>
        public DateTime LastModifiedDate
        {
            get; set;
        }

        #endregion Properties
    }
}