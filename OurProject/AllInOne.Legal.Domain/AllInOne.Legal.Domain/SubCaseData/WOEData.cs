#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for WOE case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   29/06/2011   		      CJ             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: WOEData.cs
// Description: Represents a standard data container object for WOE case type.
// </summary>
// <copyright file= "WOEData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseData
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Domain.Subsequent;

    /// <summary>
    /// Represents a standard data container object for WOE sub case type.
    /// </summary>
    [Serializable]
    public class WOEData : ISubCaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="RefOrderDetailEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="RefOrderDetailEntity"/> entity.</value>
        public List<RefOrderDetailEntity> ListRefOrderDetailEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="RequestDocDetailEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="RequestDocDetailEntity"/> entity.</value>
        public List<RequestDocDetailEntity> ListRequestDocDetailEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="WOEExecutionAddressEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="WOEExecutionAddressEntity"/> entity.</value>
        public List<WOEExecutionAddressEntity> ListWOEExecutionAddressEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="WOEMOMSCTInfoEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="WOEMOMSCTInfoEntity"/> entity.</value>
        public List<WOEMOMSCTInfoEntity> ListWOEMOMSCTInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="WOENCPEInfoEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="WOENCPEInfoEntity"/> entity.</value>
        public List<WOENCPEInfoEntity> ListWOENCPEInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="WOENECPEInfoEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="WOENECPEInfoEntity"/> entity.</value>
        public List<WOENECPEInfoEntity> ListWOENECPEInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="WOERequestEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="WOERequestEntity"/> entity.</value>
        public List<WOERequestEntity> ListWOERequestEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="WOEInfoEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="WOEInfoEntity"/> entity.</value>
        public WOEInfoEntity WOEInfoEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}