#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for PracticingCertificate sub case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   06/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: PracticingCertificateData.cs
// Description: Represents a standard data container object for PracticingCertificate sub case type.
// </summary>
// <copyright file= "PracticingCertificateData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseData
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.FrontEndSpecific;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCaseSpecific;

    /// <summary>
    /// Represents a standard data container object for PracticingCertificate sub case type.
    /// </summary>
    [Serializable]
    public class PracticingCertificateData : ISubCaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="AccountantsReportInfoEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="AccountantsReportInfoEntity"/> entity.</value>
        public List<AccountantsReportInfoEntity> ListAccountantsReportInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="AreaOfLegalPracticeEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="AreaOfLegalPracticeEntity"/> entity.</value>
        public List<AreaOfLegalPracticeEntity> ListAreaOfLegalPractice
        {
            get;
            set;
        }

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
        /// Gets or sets the <see cref="EmploymentInfoEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="EmploymentInfoEntity"/> entity.</value>
        public List<EmploymentInfoEntity> ListEmploymentInfo
        {
            get;
            set;
        }

        public List<LegalExperienceInfoEntity> ListLegalExperienceInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="LPOthLegalOrgAddrInfoEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="LPOthLegalOrgAddrInfoEntity"/> entity.</value>
        public List<LPOthLegalOrgAddrInfoEntity> ListLPOthLegalOrgAddrInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="LPOthLegalOrgInfoEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="LPOthLegalOrgInfoEntity"/> entity.</value>
        public List<LPOthLegalOrgInfoEntity> ListLPOthLegalOrgInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="PCConditionInfoEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="PCConditionInfoEntity"/> entity.</value>
        public List<PCConditionInfoEntity> ListPCConditionInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="QualificationInfoEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="QualificationInfoEntity"/> entity.</value>
        public List<QualificationInfoEntity> ListQualificationInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="TravelPassInfoEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="TravelPassInfoEntity"/> entity.</value>
        public List<TravelPassInfoEntity> ListTravelPassInfoEntity
        {
            get;
            set;
        }

        public List<ForeignLPSolicitorRegEntity> ListForeignLPSolicitorRegEntity
        {
            get;
            set;
        }

        public List<PCInfoAccReportEntity> ListPCInfoAccReportEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list NOC info entity.
        /// </summary>
        /// <value>The list NOC info entity.</value>
        public List<NOCInfoEntity> ListNOCInfoEntity
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the <see cref="PCInfoEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="PCInfoEntity"/> entity.</value>
        public PCInfoEntity PCInfoEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}