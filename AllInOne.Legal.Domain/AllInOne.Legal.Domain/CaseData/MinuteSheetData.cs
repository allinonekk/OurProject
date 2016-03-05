#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for MinuteSheet case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   28/06/2011   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MinuteSheetData.cs
// Description: Represents a standard data container object for Divorce case type.
// </summary>
// <copyright file= "MinuteSheetData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseData
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Subsequent;

    /// <summary>
    /// Represents a standard data container object for MinuteSheet case type.
    /// </summary>
    [Serializable]
    public class MinuteSheetData : ICaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the list of MinuteSheetDocList Entity.
        /// </summary>
        /// <value>The MinuteSheetDocList entity.</value>
        public List<MinuteSheetDocListEntity> ListMinuteSheetDocListEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list MinuteSheetFamilyRelatedInfo entity.
        /// </summary>
        /// <value>The MinuteSheetFamilyRelatedInfo entity.</value>
        public List<MinuteSheetFamilyRelatedInfoEntity> ListMinuteSheetFamilyRelatedInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list of MinuteSheetGroundInfo Entity.
        /// </summary>
        /// <value>The MinuteSheetGroundInfo entity.</value>
        public List<MinuteSheetGroundInfoEntity> ListMinuteSheetGroundInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MinuteSheetPartyRepInfo Entity.
        /// </summary>
        /// <value>The MinuteSheetPartyRepInfo Entity.</value>
        public List<MinuteSheetPartyRepInfoEntity> ListMinuteSheetPartyRepInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MinuteSheetPartySolicitorInfo Entity.
        /// </summary>
        /// <value>The MinuteSheetPartySolicitorInfo Entity.</value>
        public List<MinuteSheetPartySolicitorInfoEntity> ListMinuteSheetPartySolicitorInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MinuteSheetInfo Entity.
        /// </summary>
        /// <value>The MinuteSheetInfo Entity.</value>
        public MinuteSheetInfoEntity MinuteSheetInfoEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}