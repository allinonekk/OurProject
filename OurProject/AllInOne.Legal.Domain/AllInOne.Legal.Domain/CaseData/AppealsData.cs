#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for Appeals case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   23/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AppealsData.cs
// Description: Represents a standard data container object for Appeals case type.
// </summary>
// <copyright file= "AppealsData.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard data container object for Appeals case type.
    /// </summary>
    [Serializable]
    public class AppealsData : ICaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the DCACA info entity.
        /// </summary>
        /// <value>The DCACA info entity.</value>
        public DCACAInfoEntity DCACAInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list cert security of costs info entity.
        /// </summary>
        /// <value>The list cert security of costs info entity.</value>
        public List<CertSecurityOfCostsInfoEntity> ListCertSecurityOfCostsInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list legislation provisions entity.
        /// </summary>
        /// <value>The list legislation provisions entity.</value>
        public List<LegislationProvisionsEntity> ListLegislationProvisionsEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Nature Of Application details.
        /// </summary>
        /// <value>Nature Of Application details.</value>
        public List<NatureOfApplicationEntity> ListNatureOfApplicationEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list nature of case entity.
        /// </summary>
        /// <value>The list nature of case entity.</value>
        public List<NatureOfCaseEntity> ListNatureOfCaseEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list other ITMO entity.
        /// </summary>
        /// <value>The list other ITMO entity.</value>
        public List<OtherITMOEntity> ListOtherITMOEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ref order details.
        /// </summary>
        /// <value>The ref order details.</value>
        public List<RefOrderDetailEntity> ListRefOrderDetailEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list respondent case detail info entity.
        /// </summary>
        /// <value>The list respondent case detail info entity.</value>
        public List<RespondentCaseDetailInfoEntity> ListRespondentCaseDetailInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list appeal time estimation detail entity.
        /// </summary>
        /// <value>The list appeal time estimation detail entity.</value>
        public List<AppealTimeEstimationDetailEntity> ListAppealTimeEstimationDetailEntity
        {
            get;
            set;
        }

        public List<DCACAOriginatingCasePartyInfoEntity> ListDCACAOriginatingCasePartyInfoEntity
        {
            get;
            set;
        }

        public List<RefOrderJOInfoEntity> ListRefOrderJOInfoEntity
        {
            get;
            set;
        }
        #endregion Properties
    }
}