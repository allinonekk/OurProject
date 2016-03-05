#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for DocCaseSolicitor details.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AbstractDocCaseSolicitor.cs
// Description: Represents a abstract class for DocCaseSolicitor details.
// </summary>
// <copyright file= "AbstractDocCaseSolicitor.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for DocCaseSolicitor details.
    /// It inherits from <see cref="AbstractBaseCaseSolicitor"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractDocCaseSolicitor : AbstractBaseCaseSolicitor
    {
        #region Properties

        /// <summary>
        /// Gets or sets the DCPID.
        /// </summary>
        /// <value>The DCPID.</value>
        public string DCPID
        {
            get;
            set;
        }

        #endregion Properties
    }
}