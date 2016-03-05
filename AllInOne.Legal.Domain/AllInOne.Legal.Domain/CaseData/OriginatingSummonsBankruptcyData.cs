#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for OriginatingCaseSummonsBankruptcyData case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   14/01/2011   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: OriginatingSummonsBankruptcyData.cs
// Description: Represents a standard data container object for OriginatingCaseSummonsBankruptcyData case type.
// </summary>
// <copyright file= "OriginatingSummonsBankruptcyData.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard data container object for Admiralty case type.
    /// </summary>
    [Serializable]
    public class OriginatingSummonsBankruptcyData : ICaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="LegislationProvisionsEntity"/> entity list.
        /// </summary>
        /// <value>The <see cref="LegislationProvisionsEntity"/> entity list.</value>
        public List<LegislationProvisionsEntity> ListLegislationProvisionsEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="NatureOfCaseEntity"/> entity list.
        /// </summary>
        /// <value>The <see cref="NatureOfCaseEntity"/> entity list.</value>
        public List<NatureOfCaseEntity> ListNatureOfCaseEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="OtherITMOEntity"/> entity list.
        /// </summary>
        /// <value>The <see cref="OtherITMOEntity"/> entity list.</value>
        public List<OtherITMOEntity> ListOtherITMOEntity
        {
            get;
            set;
        }

        public List<PrayerEntity> ListPrayerEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="OSInfoEntity"/>
        /// </summary>
        /// <value>The OS info entity.</value>
        public OSInfoEntity OSInfoEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}