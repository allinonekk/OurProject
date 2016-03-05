#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for DocCaseParty details.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   26/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AbstractDocCaseParty.cs
// Description: Represents a abstract class for DocCaseParty details.
// </summary>
// <copyright file= "AbstractDocCaseParty.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for DocCaseParty details.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractDocCaseParty : AbstractLastModified
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