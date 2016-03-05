#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for LABParty details.
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
// File: AbstractLABParty.cs
// Description: Represents a abstract class for LABParty details.
// </summary>
// <copyright file= "AbstractLABParty.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for LABParty details.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractLABParty : AbstractLastModified
    {
        #region Properties

        /// <summary>
        /// Gets or sets the LAB party id.
        /// </summary>
        /// <value>The LAB party id.</value>
        public string LABPartyId
        {
            get; set;
        }

        #endregion Properties
    }
}