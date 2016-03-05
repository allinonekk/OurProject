#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for Divorce case type.
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
// File: DivorceData.cs
// Description: Represents a standard data container object for Divorce case type.
// </summary>
// <copyright file= "DivorceData.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard data container object for Divorce case type.
    /// </summary>
    [Serializable]
    public class DivorceData : ICaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the divorce info entity.
        /// </summary>
        /// <value>The divorce info entity.</value>
        public DivorceInfoEntity DivorceInfoEntity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the child info entity.
        /// </summary>
        /// <value>The child info entity.</value>
        public List<ChildInfoEntity> ListChildInfoEntity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the divorce Sub info entity.
        /// </summary>
        /// <value>The divorce Sub info entity.</value>
        public List<DivorceSubInfoEntity> ListDivorceSubInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list ground info.
        /// </summary>
        /// <value>The list ground info.</value>
        public List<GroundInfoEntity> ListGroundInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list of NatureOfCase Entity.
        /// </summary>
        /// <value>The NatureOfCase entity.</value>
        public List<NatureOfCaseEntity> ListNatureOfCaseEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list prayers.
        /// </summary>
        /// <value>The list prayers.</value>
        public List<PrayerEntity> ListPrayers
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the related proceeding entity.
        /// </summary>
        /// <value>The related proceeding entity.</value>
        public List<RelatedProceedingEntity> ListRelatedProceedingEntity
        {
            get; set;
        }

        public List<RefOrderDetailEntity> ListRefOrderDetailEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}