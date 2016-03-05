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
*   01/07/2011   		      Nithin             	 	Created
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
    /// Represents a standard data container object for OriginatingSummons case type.
    /// </summary>
    [Serializable]
    public class OriginatingSummonsData : ICaseTypeInfo
    {
        #region Properties

        public List<CertSecurityOfCostsInfoEntity> ListCertSecurityOfCostsInfoEntity
        {
            get;
            set;
        }

        public List<DeceasedAliasEntity> ListDeceasedAliasEntity
        {
            get;
            set;
        }

        public List<DeceasedIdentificationsEntity> ListDeceasedIdentificationsEntity
        {
            get;
            set;
        }

        public List<DeceasedInfoEntity> ListDeceasedInfoEntity
        {
            get;
            set;
        }

        public List<InfantInfoEntity> ListInfantInfoEntity
        {
            get;
            set;
        }

        public List<LegislationProvisionsEntity> ListLegislationProvisionsEntity
        {
            get;
            set;
        }

        public List<NatureOfCaseEntity> ListNatureOfCaseEntity
        {
            get;
            set;
        }

        public List<OSJudicialManagerDetailsEntity> ListOSJudicialManagerDetailsEntity
        {
            get;
            set;
        }

        public List<OSMADetailsEntity> ListOSMADetailsEntity
        {
            get;
            set;
        }

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

        public OSInfoEntity OSInfoEntity
        {
            get;
            set;
        }

        public List<LiquidatedClaimEntity> ListLiquidatedClaimEntity
        {
            get;
            set;
        }

        public List<UnliquidatedClaimEntity> ListUnliquidatedClaimEntity
        {
            get;
            set;
        }

        public WOSInfoEntity WOSInfoEntity
        {
            get;
            set;
        }

        public List<OtherReliefsClaimEntity> ListOtherReliefsClaimEntity
        {
            get;
            set;
        }
        #endregion Properties
    }
}