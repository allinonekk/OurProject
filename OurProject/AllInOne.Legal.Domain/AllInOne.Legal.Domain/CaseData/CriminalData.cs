#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for any Criminal case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   07/01/2011   		      Chun Jie             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CriminalData.cs
// Description: Represents a standard data container object for Criminal case types.
// </summary>
// <copyright file= "CriminalData.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard data container object for Preliminary Inquiry case type.
    /// </summary>
    [Serializable]
    public class CriminalData : ICaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the criminal info entity.
        /// </summary>
        /// <value>The criminal info entity.</value>
        public CriminalInfoEntity CriminalInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the criminal charge info data.
        /// </summary>
        /// <value>The criminal charge info data.</value>
        public List<ChargeInfoEntity> ListChargeInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the other order info data.
        /// </summary>
        /// <value>The criminal other order info data.</value>
        public List<CriminalOtherOrderInfoEntity> ListCriminalOtherOrderInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the criminal drug info data.
        /// </summary>
        /// <value>The criminal drug info data.</value>
        public List<DrugInfoEntity> ListDrugInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the criminal investigating officer info data.
        /// </summary>
        /// <value>The criminal investigating officer info data.</value>
        public List<InvestigatingOfficerInfoEntity> ListInvestigatingOfficerInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the criminal legislation provision info data.
        /// </summary>
        /// <value>The criminal legislation provision info data.</value>
        public List<LegislationProvisionsEntity> ListLegislationProvisionsInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the criminal offence info data.
        /// </summary>
        /// <value>The criminal offence info data.</value>
        public List<OffenceInfoEntity> ListOffenceInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the originating case relationship for criminal cases.
        /// </summary>
        /// <value>The list of originating case relations.</value>
        public List<OriginatingCaseEntity> ListOriginatingCase
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the relation data for criminal info and legislation provisions.
        /// </summary>
        /// <value>The list of CriminalInfo-LegislationProvisions relations.</value>
        public List<RCriminalLegislationInfoEntity> ListRCriminalLegislationInfo
        {
            get;
            set;
        }

        public List<SentenceCriminalOrderInfoEntity> ListSentenceCriminalOrderInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the criminal sentence info data.
        /// </summary>
        /// <value>The criminal sentence info data.</value>
        public List<SentenceInfoEntity> ListSentenceInfo
        {
            get;
            set;
        }

        #endregion Properties
    }
}