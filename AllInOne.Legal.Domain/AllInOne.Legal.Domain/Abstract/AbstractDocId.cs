#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for DocId details.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   04/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AbstractDocId.cs
// Description: Represents a abstract class for DocId details.
// </summary>
// <copyright file= "AbstractDocId.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for DocId details.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractDocId : AbstractLastModified
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