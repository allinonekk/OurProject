#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for CWU case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   01/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CWUData.cs
// Description: Represents a standard data container object for CWU case type.
// </summary>
// <copyright file= "CWUData.cs" company="AllInOne Pte Ltd">
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

    /// <summary>
    /// Represents a standard data container object for CWU case type.
    /// </summary>
    [Serializable]
    public class CWUData : ICaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the other <see cref="CWUCheckListInfoEntity"/> list.
        /// </summary>
        /// <value>The <see cref="CWUCheckListInfoEntity"/> list.</value>
        public List<CWUCheckListInfoEntity> CWUCheckListInfoList
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="CWUInfoEntity"/> entity.
        /// </summary>
        /// <value>The AAS employment info entity.</value>
        public CWUInfoEntity CWUInfoEntity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the <see cref="LegislationProvisionsEntity"/> list.
        /// </summary>
        /// <value>The <see cref="LegislationProvisionsEntity"/> list.</value>
        public List<LegislationProvisionsEntity> LegislationProvisionsEntityList
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the other <see cref="LiquidatorEntity"/> list.
        /// </summary>
        /// <value>The <see cref="LiquidatorEntity"/> list.</value>
        public List<LiquidatorEntity> LiquidatorEntityList
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the other <see cref="NatureOfCaseEntity"/> list.
        /// </summary>
        /// <value>The <see cref="NatureOfCaseEntity"/> list.</value>
        public List<NatureOfCaseEntity> NatureOfCaseEntityList
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the other <see cref="OtherITMOEntity"/> list.
        /// </summary>
        /// <value>The <see cref="OtherITMOEntity"/> list.</value>
        public List<OtherITMOEntity> OtherITMOEntityList
        {
            get; set;
        }

        public List<PrayerEntity> PrayerEntityList
        {
            get;
            set;
        }

        #endregion Properties
    }
}