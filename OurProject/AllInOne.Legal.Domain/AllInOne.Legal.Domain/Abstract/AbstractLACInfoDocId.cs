#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for LACInfo and DocId details.
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
// File: AbstractLACInfoDocId.cs
// Description: Represents a abstract class for LACInfo and DocId details.
// </summary>
// <copyright file= "AbstractLACInfoDocId.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for LACInfo and DocId details.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractLACInfoDocId : AbstractLastModified
    {
        #region Properties

        /// <summary>
        /// Gets or sets the doc id.
        /// </summary>
        /// <value>The doc id.</value>
        public String DocId
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
            get;
            set;
        }

        #endregion Properties
    }
}