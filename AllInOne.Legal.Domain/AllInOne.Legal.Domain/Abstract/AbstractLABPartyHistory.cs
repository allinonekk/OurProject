#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for LABPartyHistory details.
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
// File: AbstractLABPartyHistory.cs
// Description: Represents a abstract class for LABPartyHistory details.
// </summary>
// <copyright file= "AbstractLABPartyHistory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for LABPartyHistory details.
    /// It inherits from <see cref="AbstractLABParty"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractLABPartyHistory : AbstractLABParty
    {
        #region Properties

        /// <summary>
        /// Gets or sets the LAB party history id.
        /// </summary>
        /// <value>The LAB party history id.</value>
        public String LABPartyHistoryId
        {
            get; set;
        }

        #endregion Properties
    }
}