#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for CaseSolicitor details.
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
// File: AbstractBaseCaseSolicitor.cs
// Description: Represents a abstract class for CaseSolicitor details.
// </summary>
// <copyright file= "AbstractBaseCaseSolicitor.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for CaseSolicitor details.
    /// It inherits from <see cref="AbstractBaseCaseSolicitor"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractCaseSolicitor : AbstractBaseCaseSolicitor
    {
        #region Properties

        /// <summary>
        /// Gets or sets the case party id.
        /// </summary>
        /// <value>The case party id.</value>
        public string CasePartyId
        {
            get;
            set;
        }

        #endregion Properties
    }
}