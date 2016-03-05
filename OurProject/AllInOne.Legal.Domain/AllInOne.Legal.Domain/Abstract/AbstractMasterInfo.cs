#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for Master entity details.
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
// File: AbstractMasterInfo.cs
// Description: Represents a abstract class for Master entity details.
// </summary>
// <copyright file= "AbstractMasterInfo.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for Master entity details.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractMasterInfo : AbstractLastModified
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Description field.
        /// </summary>
        /// <value>The description.</value>
        public String Description
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get; set;
        }

        #endregion Properties
    }
}