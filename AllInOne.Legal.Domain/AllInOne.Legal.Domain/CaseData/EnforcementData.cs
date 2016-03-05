#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for Enforcement case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   30/06/2010   		      CJ             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: EnforcementData.cs
// Description: Represents a standard data container object for Enforcement case type.
// </summary>
// <copyright file= "EnforcementData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseData
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Subsequent;

    /// <summary>
    /// Represents a standard data container object for Enforcement case type.
    /// </summary>
    [Serializable]
    public class EnforcementData : ICaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the RefOrderDetailEntity Entity.
        /// </summary>
        /// <value>The RefOrderDetailEntity Entity.</value>
        public List<RefOrderDetailEntity> ListRefOrderDetailEntity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the List of WOEExecutionAddress entity.
        /// </summary>
        /// <value>The List of WOEExecutionAddress entity.</value>
        public List<WOEExecutionAddressEntity> ListWOEExecutionAddressEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WOEInfo Entity.
        /// </summary>
        /// <value>The WOEInfo Entity.</value>
        public WOEInfoEntity WOEInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WOEMOMSCTInfo Entity.
        /// </summary>
        /// <value>The WOEMOMSCTInfo Entity.</value>
        public WOEMOMSCTInfoEntity WOEMOMSCTInfoEntity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the RefOrderJOInfo Entity.
        /// </summary>
        /// <value>The RefOrderJOInfo Entity.</value>
        public List<RefOrderJOInfoEntity> ListRefOrderJOInfoEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}