#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for Admiralty case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AdmiraltyData.cs
// Description: Represents a standard data container object for Admiralty case type.
// </summary>
// <copyright file= "AdmiraltyData.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Domain.Subsequent;

    /// <summary>
    /// Represents a standard data container object for Admiralty case type.
    /// </summary>
    [Serializable]
    public class AdmiraltyData : ICaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="ADMInfoEntity"/> entity
        /// </summary>
        /// <value>The <see cref="ADMInfoEntity"/> entity.</value>
        public ADMInfoEntity ADMInfoEntity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the <see cref="UnliquidatedClaimEntity"/> list.
        /// </summary>
        /// <value>The <see cref="UnliquidatedClaimEntity"/> entity list.</value>
        public ADMRSVCBBInfoEntity ADMRSVCBBInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="UnliquidatedClaimEntity"/> list.
        /// </summary>
        /// <value>The <see cref="UnliquidatedClaimEntity"/> entity list.</value>
        public ADMWAInfoEntity ADMWAInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="UnliquidatedClaimEntity"/> list.
        /// </summary>
        /// <value>The <see cref="UnliquidatedClaimEntity"/> entity list.</value>
        public CaveatAAInfoEntity CaveatAAInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="LiquidatedClaimEntity"/> list.
        /// </summary>
        /// <value>The <see cref="LiquidatedClaimEntity"/> entity list.</value>
        public List<LiquidatedClaimEntity> LiquidatedClaimEntityList
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="NatureOfCaseEntity"/> list.
        /// </summary>
        /// <value>The <see cref="NatureOfCaseEntity"/> entity list.</value>
        public List<NatureOfCaseEntity> NatureOfCaseEntityList
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the <see cref="OtherReliefsClaimEntity"/> list.
        /// </summary>
        /// <value>The <see cref="OtherReliefsClaimEntity"/> entity list.</value>
        public List<OtherReliefsClaimEntity> OtherReliefsClaimEntityList
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the <see cref="RefCaveatCaseEntity"/> list.
        /// </summary>
        /// <value>The <see cref="RefCaveatCaseEntity"/> entity list.</value>
        public List<RefCaveatCaseEntity> RefCaveatCaseEntityList
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the <see cref="UnliquidatedClaimEntity"/> list.
        /// </summary>
        /// <value>The <see cref="UnliquidatedClaimEntity"/> entity list.</value>
        public List<UnliquidatedClaimEntity> UnliquidatedClaimEntityList
        {
            get; set;
        }

        #endregion Properties
    }
}