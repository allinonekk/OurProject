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
    using AllInOne.Legal.Domain.FrontEndSpecific;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCaseSpecific;

    /// <summary>
    /// Represents a standard data container object for Admiralty case type.
    /// </summary>
    [Serializable]
    public class ApplicationAdvocatesSolicitorsData : ICaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="AASInfoEntity"/> entity
        /// </summary>
        /// <value>The <see cref="AASInfoEntity"/> entity.</value>
        public AASInfoEntity AASInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="AreaOfLegalPracticeEntity"/> list.
        /// </summary>
        /// <value>The <see cref="AreaOfLegalPracticeEntity"/> entity list.</value>
        public List<AreaOfLegalPracticeEntity> ListAreaOfLegalPracticeEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="DegreeInfoEntity"/> list.
        /// </summary>
        /// <value>The <see cref="DegreeInfoEntity"/> entity list.</value>
        public List<DegreeInfoEntity> ListDegreeInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="DocAppProcessByExAgencyEntity"/> list.
        /// </summary>
        /// <value>The <see cref="DocAppProcessByExAgencyEntity"/> entity list.</value>
        public List<DocAppProcessByExAgencyEntity> ListDocAppProcessByExAgencyEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="EmploymentInfoEntity"/> list.
        /// </summary>
        /// <value>The <see cref="EmploymentInfoEntity"/> entity list.</value>
        public List<EmploymentInfoEntity> ListEmploymentInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="LegalExperienceInfoEntity"/> list.
        /// </summary>
        /// <value>The <see cref="LegalExperienceInfoEntity"/> entity list.</value>
        public List<LegalExperienceInfoEntity> ListLegalExperienceInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="PracticeTrainingPeriodInfoEntity"/> list.
        /// </summary>
        /// <value>The <see cref="PracticeTrainingPeriodInfoEntity"/> entity list.</value>
        public List<PracticeTrainingPeriodInfoEntity> ListPracticeTrainingPeriodInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="TravelPassInfoEntity"/> list.
        /// </summary>
        /// <value>The <see cref="TravelPassInfoEntity"/> entity list.</value>
        public List<TravelPassInfoEntity> ListTravelPassInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="PracticeOfLawInfoEntity"/> list.
        /// </summary>
        /// <value>The <see cref="PracticeOfLawInfoEntity"/> entity list.</value>
        public PracticeOfLawInfoEntity PracticeOfLawInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list foreign LP solicitor reg entity.
        /// </summary>
        /// <value>The list foreign LP solicitor reg entity.</value>
        public List<ForeignLPSolicitorRegEntity>ListForeignLPSolicitorRegEntity{ get; set; }

        /// <summary>
        /// Gets or sets the list foreign LP solicitor reg detail.
        /// </summary>
        /// <value>The list foreign LP solicitor reg detail.</value>
        public List<ForeignLPSolicitorRegDetailEntity>ListForeignLPSolicitorRegDetail{ get; set; }

        /// <summary>
        /// Gets or sets the list of NOC Info.
        /// </summary>
        /// <value>The list of NOC Info.</value>
        public List<NOCInfoEntity> ListNOCInfoEntity { get; set; }

        #endregion Properties
    }
}