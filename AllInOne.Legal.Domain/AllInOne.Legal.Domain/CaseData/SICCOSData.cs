namespace AllInOne.Legal.Domain.CaseData
{
    using System;

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Common;
    using System.Collections.Generic;
    using AllInOne.Legal.Domain.CaseSpecific;

    /// <summary>
    /// Represents a standard data container object for SICCOS case type.
    /// </summary>
    [Serializable]
    public class SICCOSData : ICaseTypeInfo
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