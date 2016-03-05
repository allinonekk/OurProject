#region Header

/*****************************************************************************************************
* Description : This file represents a standard data access gateway for Case specific entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/12/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CaseSpecificGateway.cs
// Description: Represents a standard data access gateway for Case specific entities.
// </summary>
// <copyright file= "CaseSpecificDataGateway.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain.CaseData;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;

    /// <summary>
    /// Class represents a standard data access gateway for Case specific entities.
    /// </summary>
    internal class CaseDataGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CaseDataGateway));

        /// <summary>
        /// <see cref="ISession"/> instance for Session context.
        /// </summary>
        private ISession applicationSession;

        /// <summary>
        /// Generic Gateway for Saving Entities
        /// </summary>
        private GenericGateway genericGateway;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseSpecificGateway"/> class.
        /// </summary>
        internal CaseDataGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

            this.genericGateway = new GenericGateway();

            //AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.Mapping nHibernateToDomainMapping = new AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.Mapping();
            //nHibernateToDomainMapping.MapAll();

            //AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.Mapping domainToNHibernate = new AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.Mapping();
            //domainToNHibernate.MapAll();
        }

        #endregion Constructors

        #region Methods

        internal ApplicationAdvocatesSolicitorsData GetApplicationAdvocatesSolicitorsDataBySGID(string submissionGroupId)
        {
            ApplicationAdvocatesSolicitorsData aasData = new ApplicationAdvocatesSolicitorsData();
            try
            {
                CommonGateway commonGateway = new CommonGateway();
                CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
                SubCaseSpecificGateway subCaseSpecificGateway = new SubCaseSpecificGateway();

                aasData.AASInfoEntity = caseSpecificGateway.GetAASInfoEntityBySGID(submissionGroupId);
                aasData.ListAreaOfLegalPracticeEntity = subCaseSpecificGateway.GetListAreaOfLegalPracticeBySGID(submissionGroupId);
                aasData.ListDegreeInfoEntity = commonGateway.GetListDegreeInfoBySGID(submissionGroupId);
                aasData.ListEmploymentInfoEntity = commonGateway.GetListEmploymentInfoBySGID(submissionGroupId);
                aasData.ListLegalExperienceInfoEntity = commonGateway.GetListLegalExperienceInfoBySGID(submissionGroupId);
                aasData.ListTravelPassInfoEntity = commonGateway.GetListTravelPassInfoBySGID(submissionGroupId);
                aasData.ListDocAppProcessByExAgencyEntity = commonGateway.GetListDocAppProcessByExAgencyBySGID(submissionGroupId);
                aasData.PracticeOfLawInfoEntity = null; //returning null for now;
                aasData.ListPracticeTrainingPeriodInfoEntity = null; //returning null for now;
                aasData.ListForeignLPSolicitorRegEntity = commonGateway.GetListForeignLPSolicitorRegEntityBySGID(submissionGroupId);
                aasData.ListNOCInfoEntity = subCaseSpecificGateway.GetListNOCInfoEntity(submissionGroupId);
                if (aasData.ListForeignLPSolicitorRegEntity != null && aasData.ListForeignLPSolicitorRegEntity.Count > 0)
                {
                    foreach (ForeignLPSolicitorRegEntity ForeignLPSolicitorReg in aasData.ListForeignLPSolicitorRegEntity)
                    {
                        List<ForeignLPSolicitorRegDetailEntity> listForeignLPSolicitorRegDetailEntity = commonGateway.GetListForeignLPSolicitorRegDetailEntity(ForeignLPSolicitorReg.ForeignLPSolicitorRegId);

                        if (aasData.ListForeignLPSolicitorRegDetail == null)
                            aasData.ListForeignLPSolicitorRegDetail = new List<ForeignLPSolicitorRegDetailEntity>();
                        aasData.ListForeignLPSolicitorRegDetail.AddRange(listForeignLPSolicitorRegDetailEntity);

                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetApplicationAdvocatesSolicitorsDataBySGID", ex);
                throw;
            }
            return aasData;
        }

        /// <summary>
        /// Gets the bill of sale data.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        internal ICaseTypeInfo GetBillOfSaleData(string submissionGroupId)
        {
            BillOfSaleData billOfSaleData = new BillOfSaleData();
            try
            {
                CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
                SubsequentGateway subsequentGateway = new SubsequentGateway();
                CommonGateway commonGateway = new CommonGateway();

                billOfSaleData.BillOfSaleInfoEntity = caseSpecificGateway.GetBillOfSaleInfoBySGID(submissionGroupId);
                billOfSaleData.BillOfSaleSubInfoEntity = subsequentGateway.GetBillOfSaleSubInfoEntity(submissionGroupId);
                billOfSaleData.ListRefOrderDetailEntity = commonGateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);
                billOfSaleData.ListRefOrderJOInfoEntity = commonGateway.GetListRefOrderJOInfoBySGID(submissionGroupId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBillOfSaleData", ex);
                throw;
            }
            return billOfSaleData as ICaseTypeInfo;
        }

        internal CriminalData GetCriminalDataBySGID(string SGID)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            CommonGateway commonGateway = new CommonGateway();

            CriminalData criminalData = new CriminalData();

            criminalData.CriminalInfoEntity = gateway.GetCriminalInfoEntityBySGID(SGID);
            criminalData.ListChargeInfo = gateway.GetListChargeInfoEntityBySGID(SGID);
            criminalData.ListOffenceInfo = gateway.GetListOffenceInfoEntityBySGID(SGID);
            criminalData.ListSentenceInfo = gateway.GetListSentenceInfoEntityBySGID(SGID);
            criminalData.ListDrugInfo = gateway.GetListDrugInfoEntityBySGID(SGID);
            criminalData.ListRCriminalLegislationInfo = gateway.GetListRCriminalLegislationInfoEntityBySGID(SGID);
            criminalData.ListLegislationProvisionsInfo = commonGateway.GetListLegislationProvisionsEntityBySGID(SGID);
            criminalData.ListInvestigatingOfficerInfo = gateway.GetListInvestigatingOfficerInfoEntityBySGID(SGID);
            criminalData.ListCriminalOtherOrderInfo = gateway.GetListCriminalOtherOrderInfoEntityBySGID(SGID);
            criminalData.ListOriginatingCase = commonGateway.GetListOriginatingCaseEntity(SGID);
            criminalData.ListSentenceCriminalOrderInfo = gateway.GetSentenceCriminalOrderInfoEntity(SGID);
            return criminalData;
        }

        internal ICaseTypeInfo GetDivorceData(string submissionGroupId)
        {
            DivorceData divorceData = new DivorceData();

            try
            {
                CommonGateway commonGateway = new CommonGateway();
                SubsequentGateway subsequentGateway = new SubsequentGateway();
                divorceData.DivorceInfoEntity = commonGateway.GetDivorceInfoEntityBySGID(submissionGroupId);
                divorceData.ListDivorceSubInfoEntity = subsequentGateway.GetListDivorceSubInfoEntityBySGID(submissionGroupId);
                divorceData.ListChildInfoEntity = commonGateway.GetChildInfoEntityBySGID(submissionGroupId);
                divorceData.ListGroundInfo = commonGateway.GetGroundInfoEntityBySGID(submissionGroupId);
                divorceData.ListNatureOfCaseEntity = commonGateway.GetListNatureOfCaseEntityBySGID(submissionGroupId);
                divorceData.ListPrayers = commonGateway.GetListPrayerEntityBySGID(submissionGroupId);
                divorceData.ListRelatedProceedingEntity = commonGateway.GetListRelatedProceedingBySGID(submissionGroupId);
                divorceData.ListRefOrderDetailEntity = commonGateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDivorceData", ex);
                throw;
            }

            return divorceData as ICaseTypeInfo;
        }

        internal ICaseTypeInfo GetEnforcementDataBySGID(string submissionGroupId)
        {
            EnforcementData enforcementData = new EnforcementData();
            try
            {
                CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
                SubsequentGateway gateway = new SubsequentGateway();
                CommonGateway commonGateway = new CommonGateway();

                //enforcementData.ListWOEMOMSCTInfoEntity = caseSpecificGateway.GetListWOEMOMSCTInfoEntityBySGID(submissionGroupId);
                enforcementData.WOEMOMSCTInfoEntity = caseSpecificGateway.GetWOEMOMSCTInfoEntityBySGID(submissionGroupId);
                enforcementData.WOEInfoEntity = gateway.GetWOEInfoEntityBySGID(submissionGroupId);
                enforcementData.ListWOEExecutionAddressEntity = commonGateway.GetListWOEExecutionAddressBySGID(submissionGroupId);
                enforcementData.ListRefOrderDetailEntity = commonGateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);
                //enforcementData.RefOrderDetailEntity = commonGateway.GetRefOrderDetailEntityBySGID(submissionGroupId);
                enforcementData.ListRefOrderJOInfoEntity = commonGateway.GetListRefOrderJOInfoEntityBySGID(submissionGroupId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetEnforcementDataBySGID", ex);
                throw;
            }
            return enforcementData as ICaseTypeInfo;
        }

        internal MinuteSheetData GetMinuteSheetDataByHrgId(string HrgId)
        {
            CommonGateway commonGateway = new CommonGateway();

            MinuteSheetData minuteSheetData = new MinuteSheetData();
            minuteSheetData.MinuteSheetInfoEntity = commonGateway.GetMinuteSheetInfoEntityByHrgId(HrgId);
            string minuteSheetInfoId = "";

            List<string> ListMinuteSheetPartyRepInfoId = new List<string>();

            if (minuteSheetData.MinuteSheetInfoEntity != null && minuteSheetData.MinuteSheetInfoEntity.MinuteSheetInfoId != null)
                minuteSheetInfoId = minuteSheetData.MinuteSheetInfoEntity.MinuteSheetInfoId;

            minuteSheetData.ListMinuteSheetDocListEntity = commonGateway.GetListMinuteSheetDocList(minuteSheetInfoId);
            minuteSheetData.ListMinuteSheetFamilyRelatedInfoEntity = commonGateway.GetListMinuteSheetFamilyRelatedInfo(minuteSheetInfoId);
            minuteSheetData.ListMinuteSheetGroundInfoEntity = commonGateway.GetListMinuteSheetGroundInfo(minuteSheetInfoId);
            minuteSheetData.ListMinuteSheetPartyRepInfoEntity = commonGateway.GetListMinuteSheetPartyRepInfo(minuteSheetInfoId);

            if (minuteSheetData.ListMinuteSheetPartyRepInfoEntity != null && minuteSheetData.ListMinuteSheetPartyRepInfoEntity.Count > 0)
            {
                foreach (MinuteSheetPartyRepInfoEntity msPRIE in minuteSheetData.ListMinuteSheetPartyRepInfoEntity)
                {
                    if (msPRIE != null && msPRIE.MinuteSheetPartyRepInfoId != null)
                        ListMinuteSheetPartyRepInfoId.Add(msPRIE.MinuteSheetPartyRepInfoId);
                }
            }

            if (ListMinuteSheetPartyRepInfoId != null && ListMinuteSheetPartyRepInfoId.Count > 0)
            {
                foreach (string minuteSheetPartyRepInfoId in ListMinuteSheetPartyRepInfoId)
                    if (minuteSheetPartyRepInfoId != null)
                        minuteSheetData.ListMinuteSheetPartySolicitorInfoEntity = commonGateway.GetListMinuteSheetPartySolicitorInfo(minuteSheetPartyRepInfoId);
            }

            return minuteSheetData;
        }

        internal ICaseTypeInfo GetOriginatingSummonsBankruptcyDataBySGID(string submissionGroupId)
        {
            OriginatingSummonsBankruptcyData originatingSummonsBankruptcyData = new OriginatingSummonsBankruptcyData();
            try
            {
                CommonGateway commonGateway = new CommonGateway();
                CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
                originatingSummonsBankruptcyData.ListLegislationProvisionsEntity = commonGateway.GetListLegislationProvisionsEntityBySGID(submissionGroupId);
                originatingSummonsBankruptcyData.ListNatureOfCaseEntity = commonGateway.GetListNatureOfCaseEntityBySGID(submissionGroupId);
                originatingSummonsBankruptcyData.ListOtherITMOEntity = commonGateway.GetListOtherITMOEntityBySGID(submissionGroupId);
                originatingSummonsBankruptcyData.OSInfoEntity = caseSpecificGateway.GetOSInfoEntityBySGID(submissionGroupId);
                originatingSummonsBankruptcyData.ListPrayerEntity = commonGateway.GetListPrayerEntityBySGID(submissionGroupId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOriginatingSummonsBankruptcyDataBySGID", ex);
                throw;
            }
            return originatingSummonsBankruptcyData as ICaseTypeInfo;
        }

        internal ICaseTypeInfo GetOriginatingSummonsDataBySGID(string submissionGroupId)
        {
            OriginatingSummonsData originatingSummonsData = new OriginatingSummonsData();
            try
            {
                CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
                CommonGateway commonGateway = new CommonGateway();
                originatingSummonsData.OSInfoEntity = caseSpecificGateway.GetOSInfoEntityBySGID(submissionGroupId);
                originatingSummonsData.ListCertSecurityOfCostsInfoEntity = commonGateway.GetListCertSecurityOfCostsInfo(submissionGroupId);
                originatingSummonsData.ListDeceasedAliasEntity = commonGateway.GetListDeceasedAliasBySGID(submissionGroupId);
                originatingSummonsData.ListDeceasedIdentificationsEntity = commonGateway.GetListDeceasedIdentificationBySGID(submissionGroupId);
                originatingSummonsData.ListDeceasedInfoEntity = commonGateway.GetListDeceasedInfoBySGID(submissionGroupId);
                originatingSummonsData.ListInfantInfoEntity = commonGateway.GetListInfoEntityBySGID(submissionGroupId);
                originatingSummonsData.ListLegislationProvisionsEntity = commonGateway.GetListLegislationProvisionsEntityBySGID(submissionGroupId);
                originatingSummonsData.ListNatureOfCaseEntity = commonGateway.GetListNatureOfCaseEntityBySGID(submissionGroupId);
                originatingSummonsData.ListOSJudicialManagerDetailsEntity = caseSpecificGateway.GetListOSJudicialManagerDetailEntityBySGID(submissionGroupId);
                originatingSummonsData.ListOSMADetailsEntity = caseSpecificGateway.GetListOSMADetailsEntityBySGID(submissionGroupId);
                originatingSummonsData.ListOtherITMOEntity = commonGateway.GetListOtherITMOEntityBySGID(submissionGroupId);
                originatingSummonsData.ListPrayerEntity = commonGateway.GetListPrayerEntityBySGID(submissionGroupId);
                originatingSummonsData.WOSInfoEntity = caseSpecificGateway.GetWOSInfoEntityBySGID(submissionGroupId);
                originatingSummonsData.ListLiquidatedClaimEntity = commonGateway.GetListLiquidatedClaimBySGID(submissionGroupId);
                originatingSummonsData.ListUnliquidatedClaimEntity = commonGateway.GetListUnLiquidatedClaimEntityBySGID(submissionGroupId);
                originatingSummonsData.ListOtherReliefsClaimEntity = commonGateway.GetListOtherReliefsClaimEntityBySGID(submissionGroupId);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOriginatingSummonsDataBySGID", ex);
                throw;
            }
            return originatingSummonsData;
        }
        internal ICaseTypeInfo GetProbateDataBySGID(string submissionGroupId)
        {
            ProbateData probateData = new ProbateData();
            try
            {
                CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
                CommonGateway commonGateway = new CommonGateway();

                probateData.ProbateInfoEntity = caseSpecificGateway.GetProbateInfoEntityBySGID(submissionGroupId);
                probateData.ListDeceasedAliasEntity = commonGateway.GetListDeceasedAliasBySGID(submissionGroupId);
                probateData.ListDeceasedIdentificationsEntity = commonGateway.GetListDeceasedIdentificationBySGID(submissionGroupId);
                probateData.ListDeceasedInfoEntity = commonGateway.GetListDeceasedInfoBySGID(submissionGroupId);
                probateData.ListPBBeneficiaryDetailEntity = caseSpecificGateway.GetListPBBeneficiaryBySGID(submissionGroupId);
                probateData.ListPBCoAdminDetailEntity = caseSpecificGateway.GetListPBCoAdminDetailBySGID(submissionGroupId);
                probateData.ListPBExecutorDetailEntity = caseSpecificGateway.GetListPBExecutorBySGID(submissionGroupId);
                probateData.ListPBPrevGrantDetailEntity = caseSpecificGateway.GetListPBPrevGrantDetail(submissionGroupId);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetProbateDataBySGID", ex);
                throw;
            }
            return probateData;
        }

        internal ICaseTypeInfo GetCaveatDataBySGID(string submissionGroupId)
        {
            CaveatData caveatData = new CaveatData();
            try
            {
                CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
                CommonGateway commonGateway = new CommonGateway();

                caveatData.CaveatInfoEntity = caseSpecificGateway.GetCaveatInfoEntityBySGID(submissionGroupId);
                caveatData.CaveatAAInfoEntity= caseSpecificGateway.GetCaveatAAInfoEntityBySGID(submissionGroupId);
                caveatData.ListDeceasedAliasEntity = commonGateway.GetListDeceasedAliasBySGID(submissionGroupId);
                caveatData.ListDeceasedIdentificationsEntity = commonGateway.GetListDeceasedIdentificationBySGID(submissionGroupId);
                caveatData.ListDeceasedInfoEntity = commonGateway.GetListDeceasedInfoBySGID(submissionGroupId);
                caveatData.ListRefCaveatCaseEntity = commonGateway.GetListRefCaveatCaseEntityBySGID(submissionGroupId);
               

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetProbateDataBySGID", ex);
                throw;
            }
            return caveatData;
        }

        internal ICaseTypeInfo GetTaxationDataBySGID(string submissionGroupId)
        {
            TaxationData taxationData = new TaxationData();
            try
            {
                CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
                CommonGateway commonGateway = new CommonGateway();

                taxationData.TaxationInfoEntity = caseSpecificGateway.GetTaxationInfoBySGID(submissionGroupId);
                taxationData.ListTaxationClaimEntity = caseSpecificGateway.GetListTaxationClaimEntityBySGID(submissionGroupId);
                taxationData.ListBOTDetailEntity = caseSpecificGateway.GetListBOTDetailEntityBySGID(submissionGroupId);
                taxationData.ListLegislationProvisionsEntity = commonGateway.GetListLegislationProvisionsEntityBySGID(submissionGroupId);
                taxationData.ListNatureOfApplicationEntity = commonGateway.GetListNatureOfApplicationEntityBySGID(submissionGroupId);
                taxationData.ListRefOrderDetailEntity = commonGateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetTaxationDataBySGID", ex);
                throw;
            }

            return taxationData;
        }

        internal ICaseTypeInfo GetWOSDataBySGID(string submissionGroupId)
        {
            WOSData wOSData = new WOSData();
            try
            {
                CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
                CommonGateway commonGateway = new CommonGateway();

                wOSData.WOSInfoEntity = caseSpecificGateway.GetWOSInfoEntityBySGID(submissionGroupId);
                wOSData.ListLiquidatedClaimEntity = commonGateway.GetListLiquidatedClaimBySGID(submissionGroupId);
                wOSData.ListNatureOfCaseEntity = commonGateway.GetListNatureOfCaseEntityBySGID(submissionGroupId);
                wOSData.ListOtherReliefsClaimEntity = commonGateway.GetListOtherReliefsClaimEntityBySGID(submissionGroupId);
                wOSData.ListRefOrderDetailEntity = commonGateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);
                wOSData.ListUnliquidatedClaimEntity = commonGateway.GetListUnLiquidatedClaimEntityBySGID(submissionGroupId);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOSDataBySGID", ex);
                throw;
            }

            return wOSData;
        }

        //TODO : Need to change to Private once FB code is updated
        internal void SaveOrUpdateAdmiraltyData(AdmiraltyData admiraltyData, bool isCopy)
        {
            try
            {
                if (admiraltyData.ADMInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<ADMInfo>(
                        AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetAdmInfo(admiraltyData.ADMInfoEntity),
                        isCopy);
                }

                if (admiraltyData.LiquidatedClaimEntityList != null && admiraltyData.LiquidatedClaimEntityList.Count > 0)
                {
                    List<LiquidatedClaim> listLiquidatedClaim = admiraltyData.LiquidatedClaimEntityList.Select
                        (liquidatedClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLiquidatedClaim(liquidatedClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LiquidatedClaim>(listLiquidatedClaim, isCopy);
                }

                if (admiraltyData.NatureOfCaseEntityList != null && admiraltyData.NatureOfCaseEntityList.Count > 0)
                {
                    List<NatureOfCase> listNatureOfCase = admiraltyData.NatureOfCaseEntityList.Select
                        (natureOfCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCase(natureOfCase)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<NatureOfCase>(listNatureOfCase, isCopy);
                }

                if (admiraltyData.OtherReliefsClaimEntityList != null && admiraltyData.OtherReliefsClaimEntityList.Count > 0)
                {
                    List<OtherReliefsClaim> listOtherReliefsClaim = admiraltyData.OtherReliefsClaimEntityList.Select
                        (otherReliefsClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherReliefsClaim(otherReliefsClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OtherReliefsClaim>(listOtherReliefsClaim, isCopy);
                }

                if (admiraltyData.RefCaveatCaseEntityList != null && admiraltyData.RefCaveatCaseEntityList.Count > 0)
                {
                    List<RefCaveatCase> listRefCaveatCase = admiraltyData.RefCaveatCaseEntityList.Select
                        (refCaveatCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefCaveatCase(refCaveatCase)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<RefCaveatCase>(listRefCaveatCase, isCopy);
                }

                if (admiraltyData.UnliquidatedClaimEntityList != null && admiraltyData.UnliquidatedClaimEntityList.Count > 0)
                {
                    List<UnliquidatedClaim> listUnliquidatedClaim = admiraltyData.UnliquidatedClaimEntityList.Select(unliquidatedClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetUnliquidatedClaim(unliquidatedClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<UnliquidatedClaim>(listUnliquidatedClaim, isCopy);
                }

                if (admiraltyData.CaveatAAInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<CaveatAAInfo>(
                        AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetCaveatAAInfo(admiraltyData.CaveatAAInfoEntity),
                        isCopy);
                }

                if (admiraltyData.ADMRSVCBBInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<ADMRSVCBBInfo>(
                                       AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubsequentMapper.GetADMRSVCBBInfo(admiraltyData.ADMRSVCBBInfoEntity),
                                       isCopy);
                }

                if (admiraltyData.ADMWAInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<ADMWAInfo>(
                                     AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetADMWAInfo(admiraltyData.ADMWAInfoEntity),
                                     isCopy);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateAdmiraltyData", ex);
                throw;
            }
        }

        /// <summary>
        /// Saves the or update case data.
        /// </summary>
        /// <param name="iCaseType">Type of the i case.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        internal void SaveOrUpdateCaseData(ICaseTypeInfo iCaseType, bool isCopy)
        {
            if (iCaseType.GetType().Equals(typeof(AdmiraltyData)))
                SaveOrUpdateAdmiraltyData(iCaseType as AdmiraltyData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(DivorceData)))
                SaveOrUpdateDivorceData(iCaseType as DivorceData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(BillOfSaleData)))
                SaveOrUpdateBillOfSaleData(iCaseType as BillOfSaleData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(AppealsData)))
                SaveOrUpdateAppealsData(iCaseType as AppealsData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(BankruptcyData)))
                SaveOrUpdateBankruptcyData(iCaseType as BankruptcyData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(CriminalData)))
                SaveOrUpdateCriminalData(iCaseType as CriminalData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(OriginatingSummonsBankruptcyData)))
                SaveOrUpdateOriginatingSummonsBankruptcyData(iCaseType as OriginatingSummonsBankruptcyData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(ApplicationAdvocatesSolicitorsData)))
                SaveOrUpdateApplicationAdvocatesSolicitorsData(iCaseType as ApplicationAdvocatesSolicitorsData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(EnforcementData)))
                SaveOrUpdateEnforcementData(iCaseType as EnforcementData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(WOSData)))
                SaveOrUpdateWOSData(iCaseType as WOSData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(OriginatingSummonsData)))
                SaveOrUpdateOriginatingSummonsData(iCaseType as OriginatingSummonsData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(ProbateData)))
                SaveOrUpdateProbateData(iCaseType as ProbateData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(CaveatData)))
                SaveOrUpdateCaveatData(iCaseType as CaveatData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(TaxationData)))
                SaveOrUpdateTaxationData(iCaseType as TaxationData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(CWUData)))
                SaveOrUpdateCWUData(iCaseType as CWUData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(RASData)))
                SaveOrUpdateRASData(iCaseType as RASData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(SICCOSData)))
                SaveOrUpdateSICCOSData(iCaseType as SICCOSData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(SICCSData)))
                SaveOrUpdateSICCSData(iCaseType as SICCSData, isCopy);

            else if (iCaseType.GetType().Equals(typeof(RFLData)))
                SaveOrUpdateRFLData(iCaseType as RFLData, isCopy);
            

            else
                throw new ArgumentNullException("Object Sent was Wrong");
        }

        private void SaveOrUpdateCaveatData(CaveatData caveatData, bool isCopy)
        {
            try
            {
                if (caveatData.CaveatInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<CaveatInfo>(
                         AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetCaveatInfo(caveatData.CaveatInfoEntity),
                        isCopy);
                }

                if (caveatData.CaveatAAInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<CaveatAAInfo>(
                         AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetCaveatAAInfo(caveatData.CaveatAAInfoEntity),
                        isCopy);
                }

                if (caveatData.ListDeceasedAliasEntity != null && caveatData.ListDeceasedAliasEntity.Count > 0)
                {
                    List<DeceasedAlias> listDeceasedAlias = caveatData.ListDeceasedAliasEntity.Select(deceasedAlias => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDeceasedAlias(deceasedAlias)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DeceasedAlias>(listDeceasedAlias, isCopy);
                }

                if (caveatData.ListDeceasedIdentificationsEntity != null && caveatData.ListDeceasedIdentificationsEntity.Count > 0)
                {
                    List<DeceasedIdentification> listDeceasedIdentification = caveatData.ListDeceasedIdentificationsEntity.Select(deceasedIdentification => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDeceasedIdentification(deceasedIdentification)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DeceasedIdentification>(listDeceasedIdentification, isCopy);
                }

                if (caveatData.ListDeceasedInfoEntity != null && caveatData.ListDeceasedInfoEntity.Count > 0)
                {
                    List<DeceasedInfo> listDeceasedInfo = caveatData.ListDeceasedInfoEntity.Select(deceasedInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDeceasedInfo(deceasedInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DeceasedInfo>(listDeceasedInfo, isCopy);
                }

                if (caveatData.ListRefCaveatCaseEntity != null && caveatData.ListRefCaveatCaseEntity.Count > 0)
                {
                    List<RefCaveatCase> listRefCaveatCase = caveatData.ListRefCaveatCaseEntity.Select(refCaveatCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefCaveatCase(refCaveatCase)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<RefCaveatCase>(listRefCaveatCase, isCopy);
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateProbateData", ex);
                throw;
            }
        
        }

        /// <summary>
        /// Saves the or update appeals data.
        /// </summary>
        /// <param name="appealsData">The appeals data.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        private void SaveOrUpdateAppealsData(AppealsData appealsData, bool isCopy)
        {
            if (appealsData.DCACAInfoEntity != null)
            {
                SaveOrUpdateData(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetDCACAInfo(appealsData.DCACAInfoEntity), isCopy);
            }

            if (appealsData.ListCertSecurityOfCostsInfoEntity != null && appealsData.ListCertSecurityOfCostsInfoEntity.Count > 0)
            {
                List<CertSecurityOfCostsInfo> listCertSecurityOfCostsInfo = appealsData.ListCertSecurityOfCostsInfoEntity.Select(certSecurityOfCostsInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetCertSecurityOfCostsInfo(certSecurityOfCostsInfo)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<CertSecurityOfCostsInfo>(listCertSecurityOfCostsInfo, isCopy);
            }

            if (appealsData.ListLegislationProvisionsEntity != null && appealsData.ListLegislationProvisionsEntity.Count > 0)
            {
                List<LegislationProvision> listLegislationProvision = appealsData.ListLegislationProvisionsEntity.Select(legislationProvision => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegislationProvision(legislationProvision)).ToList();
                foreach (LegislationProvision legislationProvision in listLegislationProvision)
                {
                    SaveOrUpdateData(legislationProvision, isCopy);
                }
            }

            if (appealsData.ListAppealTimeEstimationDetailEntity != null && appealsData.ListAppealTimeEstimationDetailEntity.Count > 0)
            {
                List<AppealTimeEstimationDetail> listAppealTimeEstimationDetail = appealsData.ListAppealTimeEstimationDetailEntity.Select(appealTimeEstimationDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetAppealTimeEstimationDetail(appealTimeEstimationDetail)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<AppealTimeEstimationDetail>(listAppealTimeEstimationDetail, isCopy);
            }


            if (appealsData.ListNatureOfApplicationEntity != null && appealsData.ListNatureOfApplicationEntity.Count > 0)
            {
                List<NatureOfApplication> listNatureOfApplication = appealsData.ListNatureOfApplicationEntity.Select(natureOfApplication => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfApplication(natureOfApplication)).ToList();
                foreach (NatureOfApplication natureOfApplication in listNatureOfApplication)
                {
                    SaveOrUpdateData(natureOfApplication, isCopy);
                }
            }

            if (appealsData.ListNatureOfCaseEntity != null && appealsData.ListNatureOfCaseEntity.Count > 0)
            {
                List<NatureOfCase> listNatureOfCase = appealsData.ListNatureOfCaseEntity.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCase(natureOfCase)).ToList();
                foreach (NatureOfCase natureOfCase in listNatureOfCase)
                {
                    SaveOrUpdateData(natureOfCase, isCopy);
                }
            }

            if (appealsData.ListOtherITMOEntity != null && appealsData.ListOtherITMOEntity.Count > 0)
            {
                List<OtherITMO> listOtherITMO = appealsData.ListOtherITMOEntity.Select(otherITMO => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherITMO(otherITMO)).ToList();
                foreach (OtherITMO otherITMO in listOtherITMO)
                {
                    SaveOrUpdateData(otherITMO, isCopy);
                }
            }
            if (appealsData.ListRefOrderDetailEntity != null && appealsData.ListRefOrderDetailEntity.Count > 0)
            {
                List<RefOrderDetail> listRefOrderDetail = appealsData.ListRefOrderDetailEntity.Select(refOrderDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetail)).ToList();
                foreach (RefOrderDetail refOrderDetail in listRefOrderDetail)
                {
                    SaveOrUpdateData(refOrderDetail, isCopy);
                }
            }

            if (appealsData.ListDCACAOriginatingCasePartyInfoEntity != null && appealsData.ListDCACAOriginatingCasePartyInfoEntity.Count > 0)
            {
                List<DCACAOriginatingCasePartyInfo> listDCACAOriginatingCasePartyInfo = appealsData.ListDCACAOriginatingCasePartyInfoEntity.Select(dCACAOriginatingCasePartyInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetDCACAOriginatingCasePartyInfo(dCACAOriginatingCasePartyInfo)).ToList();
                foreach (DCACAOriginatingCasePartyInfo dCACAOriginatingCasePartyInfo in listDCACAOriginatingCasePartyInfo)
                {
                    SaveOrUpdateData(dCACAOriginatingCasePartyInfo, isCopy);
                }
            }

            if (appealsData.ListRespondentCaseDetailInfoEntity != null && appealsData.ListRespondentCaseDetailInfoEntity.Count > 0)
            {
                List<RespondentCaseDetailInfo> listRespondentCaseDetailInfo = appealsData.ListRespondentCaseDetailInfoEntity.Select(respondentCaseDetailInfo =>
                    AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRespondentCaseDetailInfo(respondentCaseDetailInfo)).ToList();
                foreach (RespondentCaseDetailInfo respondentCaseDetailInfo in listRespondentCaseDetailInfo)
                {
                    SaveOrUpdateData(respondentCaseDetailInfo, isCopy);
                }
            }

            if (appealsData.ListRefOrderJOInfoEntity != null && appealsData.ListRefOrderJOInfoEntity.Count > 0)
            {
                List<RefOrderJOInfo> listRefOrderJOInfo = appealsData.ListRefOrderJOInfoEntity.Select(refOrderJOInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderJOInfo(refOrderJOInfo)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<RefOrderJOInfo>(listRefOrderJOInfo, isCopy);
            }
        }

        /// <summary>
        /// Saves or updates the <see cref="ApplicationAdvocatesSolicitorsData"/>.
        /// </summary>
        /// <param name="applicationAdvocatesSolicitorsData">The <see cref="ApplicationAdvocatesSolicitorsData"/> object.</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy is used else SaveOrUpdate.</param>
        private void SaveOrUpdateApplicationAdvocatesSolicitorsData(ApplicationAdvocatesSolicitorsData applicationAdvocatesSolicitorsData, bool isCopy)
        {
            try
            {
                CommonGateway commonGateway = new CommonGateway();

                if (applicationAdvocatesSolicitorsData.AASInfoEntity != null)
                {
                    AASInfo aASInfo = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetAASInfo(applicationAdvocatesSolicitorsData.AASInfoEntity);
                    this.genericGateway.SaveOrUpdateEntity<AASInfo>(aASInfo, isCopy);
                }

                if (applicationAdvocatesSolicitorsData.ListAreaOfLegalPracticeEntity != null && applicationAdvocatesSolicitorsData.ListAreaOfLegalPracticeEntity.Count > 0)
                {
                    List<AreaOfLegalPractice> listAreaOfLegalPractice = applicationAdvocatesSolicitorsData.ListAreaOfLegalPracticeEntity.Select(areaOfLegalPractice => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetAreaOfLegalPractice(areaOfLegalPractice)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<AreaOfLegalPractice>(listAreaOfLegalPractice, isCopy);
                }

                if (applicationAdvocatesSolicitorsData.ListDegreeInfoEntity != null && applicationAdvocatesSolicitorsData.ListDegreeInfoEntity.Count > 0)
                {
                    List<DegreeInfo> listDegreeInfo = applicationAdvocatesSolicitorsData.ListDegreeInfoEntity.Select(degreeInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDegreeInfo(degreeInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DegreeInfo>(listDegreeInfo, isCopy);
                }

                if (applicationAdvocatesSolicitorsData.ListEmploymentInfoEntity != null && applicationAdvocatesSolicitorsData.ListEmploymentInfoEntity.Count > 0)
                {
                    List<EmploymentInfo> listEmploymentInfo = applicationAdvocatesSolicitorsData.ListEmploymentInfoEntity.Select(employmentInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetEmploymentInfo(employmentInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<EmploymentInfo>(listEmploymentInfo, isCopy);
                }
                if (applicationAdvocatesSolicitorsData.ListLegalExperienceInfoEntity != null && applicationAdvocatesSolicitorsData.ListLegalExperienceInfoEntity.Count > 0)
                {
                    List<LegalExperienceInfo> listLegalExperienceInfo = applicationAdvocatesSolicitorsData.ListLegalExperienceInfoEntity.Select(legalExperienceInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegalExperienceInfo(legalExperienceInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LegalExperienceInfo>(listLegalExperienceInfo, isCopy);
                }
                if (applicationAdvocatesSolicitorsData.ListTravelPassInfoEntity != null && applicationAdvocatesSolicitorsData.ListTravelPassInfoEntity.Count > 0)
                {
                    List<TravelPassInfo> listTravelPassInfo = applicationAdvocatesSolicitorsData.ListTravelPassInfoEntity.Select(travelPassInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetTravelPassInfo(travelPassInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<TravelPassInfo>(listTravelPassInfo, isCopy);
                }
                if (applicationAdvocatesSolicitorsData.PracticeOfLawInfoEntity != null)
                {
                    PracticeOfLawInfo practiceOfLawInfo = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetPracticeOfLawInfo(applicationAdvocatesSolicitorsData.PracticeOfLawInfoEntity);
                    this.genericGateway.SaveOrUpdateEntity<PracticeOfLawInfo>(practiceOfLawInfo, isCopy);
                }
                if (applicationAdvocatesSolicitorsData.ListPracticeTrainingPeriodInfoEntity != null && applicationAdvocatesSolicitorsData.ListPracticeTrainingPeriodInfoEntity.Count > 0)
                {
                    List<PracticeTrainingPeriodInfo> listPracticeTrainingPeriodInfo = applicationAdvocatesSolicitorsData.ListPracticeTrainingPeriodInfoEntity.Select(practiceTrainingPeriodInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetPracticeTrainingPeriodInfo(practiceTrainingPeriodInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<PracticeTrainingPeriodInfo>(listPracticeTrainingPeriodInfo, isCopy);
                }
                if (applicationAdvocatesSolicitorsData.ListDocAppProcessByExAgencyEntity != null && applicationAdvocatesSolicitorsData.ListDocAppProcessByExAgencyEntity.Count > 0)
                {
                    List<DocAppProcessByExAgency> listDocAppProcessByExAgency = applicationAdvocatesSolicitorsData.ListDocAppProcessByExAgencyEntity.Select(docAppProcessByExAgency => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDocAppProcessByExAgency(docAppProcessByExAgency)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DocAppProcessByExAgency>(listDocAppProcessByExAgency, isCopy);

                }
                if (applicationAdvocatesSolicitorsData.ListForeignLPSolicitorRegEntity != null && applicationAdvocatesSolicitorsData.ListForeignLPSolicitorRegEntity.Count > 0)
                {
                    List<ForeignLPSolicitorReg> listForeignLPSolicitorReg = applicationAdvocatesSolicitorsData.ListForeignLPSolicitorRegEntity.Select(foreignLPSolicitorReg => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetForeignLPSolicitorReg(foreignLPSolicitorReg)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<ForeignLPSolicitorReg>(listForeignLPSolicitorReg, isCopy);
                }
                if (applicationAdvocatesSolicitorsData.ListForeignLPSolicitorRegDetail != null && applicationAdvocatesSolicitorsData.ListForeignLPSolicitorRegDetail.Count > 0)
                {
                    foreach (var foreignLPSolicitorRegDetail in applicationAdvocatesSolicitorsData.ListForeignLPSolicitorRegDetail)
                    {
                        commonGateway.SaveOrUpdateForeignLPSolicitorRegDetail(foreignLPSolicitorRegDetail);

                    }
                }
                if (applicationAdvocatesSolicitorsData.ListNOCInfoEntity != null && applicationAdvocatesSolicitorsData.ListNOCInfoEntity.Count > 0)
                {
                    List<NOCInfo> listNOCInfo = applicationAdvocatesSolicitorsData.ListNOCInfoEntity.Select(nOCInfo =>
                        AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetNOCInfo(nOCInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<NOCInfo>(listNOCInfo, isCopy);
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateApplicationAdvocatesSolicitorsData", ex);
                throw;
            }
        }

        /// <summary>
        /// Saves or updates the <see cref="BankruptcyData"/>.
        /// </summary>
        /// <param name="bankruptcyData">The <see cref="BankruptcyData"/> object.</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy is used else SaveOrUpdate.</param>
        private void SaveOrUpdateBankruptcyData(BankruptcyData bankruptcyData, bool isCopy)
        {
            try
            {
                if (bankruptcyData.BankruptcyInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<BankruptcyInfo>(
                        AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetBankruptcyInfo(bankruptcyData.BankruptcyInfoEntity),
                        isCopy);
                }

                if (bankruptcyData.ListBankruptcyOtherDefDetailEntity != null && bankruptcyData.ListBankruptcyOtherDefDetailEntity.Count > 0)
                {
                    List<BankruptcyOtherDefDetail> listBankruptcyOtherDefDetail = bankruptcyData.ListBankruptcyOtherDefDetailEntity.Select(bankruptcyOtherDefDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetBankruptcyOtherDefDetail(bankruptcyOtherDefDetail)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<BankruptcyOtherDefDetail>(listBankruptcyOtherDefDetail, isCopy);
                }

                if (bankruptcyData.ListLegislationProvisionsEntity != null && bankruptcyData.ListLegislationProvisionsEntity.Count > 0)
                {
                    List<LegislationProvision> listLegislationProvision = bankruptcyData.ListLegislationProvisionsEntity.Select(legislationProvision => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegislationProvision(legislationProvision)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LegislationProvision>(listLegislationProvision, isCopy);
                }

                if (bankruptcyData.ListNatureOfCaseEntity != null && bankruptcyData.ListNatureOfCaseEntity.Count > 0)
                {
                    List<NatureOfCase> listNatureOfCase = bankruptcyData.ListNatureOfCaseEntity.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCase(natureOfCase)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<NatureOfCase>(listNatureOfCase, isCopy);
                }

                if (bankruptcyData.ListOtherITMOEntity != null && bankruptcyData.ListOtherITMOEntity.Count > 0)
                {
                    List<OtherITMO> listOtherITMO = bankruptcyData.ListOtherITMOEntity.Select(otherITMO => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherITMO(otherITMO)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OtherITMO>(listOtherITMO, isCopy);
                }
                if (bankruptcyData.ListPrayerEntity != null && bankruptcyData.ListPrayerEntity.Count > 0)
                {
                    List<Prayer> listPrayer = bankruptcyData.ListPrayerEntity.Select(prayer => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetPrayer(prayer)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<Prayer>(listPrayer, isCopy);
                }
                if (bankruptcyData.ListBankruptcyDebtInfoEntity != null && bankruptcyData.ListBankruptcyDebtInfoEntity.Count > 0)
                {
                    List<BankruptcyDebtInfo> listBankruptcyDebtInfo = bankruptcyData.ListBankruptcyDebtInfoEntity.Select(bankruptcyDebtInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetBankruptcyDebtInfo(bankruptcyDebtInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<BankruptcyDebtInfo>(listBankruptcyDebtInfo, isCopy);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateBankruptcyData", ex);
                throw;
            }
        }

        /// <summary>
        /// Saves the or update bill of sale data.
        /// </summary>
        /// <param name="billOfSaleData">The bill of sale data.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        private void SaveOrUpdateBillOfSaleData(BillOfSaleData billOfSaleData, bool isCopy)
        {
            if (billOfSaleData.BillOfSaleInfoEntity != null)
            {
                BillOfSaleInfo billOfSaleInfo = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetBillOfSaleInfo(billOfSaleData.BillOfSaleInfoEntity);
                SaveOrUpdateData(billOfSaleInfo, isCopy);
            }

            if (billOfSaleData.BillOfSaleSubInfoEntity != null)
            {
                BillOfSaleSubInfo billOfSaleSubInfo = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubsequentMapper.GetBillOfSaleSubInfo(billOfSaleData.BillOfSaleSubInfoEntity);
                SaveOrUpdateData(billOfSaleSubInfo, isCopy);
            }

            if (billOfSaleData.ListRefOrderDetailEntity != null && billOfSaleData.ListRefOrderDetailEntity.Count > 0)
            {
                List<RefOrderDetail> listRefOrderDetail = billOfSaleData.ListRefOrderDetailEntity.Select(refOrderDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetail)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<RefOrderDetail>(listRefOrderDetail, isCopy);
            }

            if (billOfSaleData.ListRefOrderJOInfoEntity != null && billOfSaleData.ListRefOrderJOInfoEntity.Count > 0)
            {
                List<RefOrderJOInfo> listRefOrderJOInfo = billOfSaleData.ListRefOrderJOInfoEntity.Select(refOrderJOInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderJOInfo(refOrderJOInfo)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<RefOrderJOInfo>(listRefOrderJOInfo, isCopy);
            }

        }

        /// <summary>
        /// Saves or updates the <see cref="CriminalData"/>.
        /// </summary>
        /// <param name="criminalData">The <see cref="CriminalData"/> object.</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy is used else SaveOrUpdate.</param>
        private void SaveOrUpdateCriminalData(CriminalData criminalData, bool isCopy)
        {
            try
            {
                if (criminalData.CriminalInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<CriminalInfo>(
                        AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetCriminalInfo(criminalData.CriminalInfoEntity),
                        isCopy);
                }

                if (criminalData.ListChargeInfo != null && criminalData.ListChargeInfo.Count > 0)
                {
                    List<ChargeInfo> listChargeInfo = criminalData.ListChargeInfo.Select(chargeInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetChargeInfo(chargeInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<ChargeInfo>(listChargeInfo, isCopy);
                }

                if (criminalData.ListOffenceInfo != null && criminalData.ListOffenceInfo.Count > 0)
                {
                    List<OffenceInfo> listOffenceInfo = criminalData.ListOffenceInfo.Select(chargeInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetOffenceInfo(chargeInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OffenceInfo>(listOffenceInfo, isCopy);
                }

                if (criminalData.ListDrugInfo != null && criminalData.ListDrugInfo.Count > 0)
                {
                    List<DrugInfo> listDrugInfo = criminalData.ListDrugInfo.Select(chargeInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetDrugInfo(chargeInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DrugInfo>(listDrugInfo, isCopy);
                }

                if (criminalData.ListSentenceInfo != null && criminalData.ListSentenceInfo.Count > 0)
                {
                    List<SentenceInfo> listSentenceInfo = criminalData.ListSentenceInfo.Select(chargeInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetSentenceInfo(chargeInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<SentenceInfo>(listSentenceInfo, isCopy);
                }

                if (criminalData.ListSentenceCriminalOrderInfo != null && criminalData.ListSentenceCriminalOrderInfo.Count > 0)
                {
                    List<SentenceCriminalOrderInfo> listSentenceCriminalOrderInfo = criminalData.ListSentenceCriminalOrderInfo.Select(sentenceCriminalOrderInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetSentenceCriminalOrderInfo(sentenceCriminalOrderInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<SentenceCriminalOrderInfo>(listSentenceCriminalOrderInfo, isCopy);
                }

                if (criminalData.ListInvestigatingOfficerInfo != null && criminalData.ListInvestigatingOfficerInfo.Count > 0)
                {
                    List<InvestigatingOfficerInfo> listInvestigatingOfficerInfo = criminalData.ListInvestigatingOfficerInfo.Select(chargeInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetInvestigatingOfficerInfo(chargeInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<InvestigatingOfficerInfo>(listInvestigatingOfficerInfo, isCopy);
                }

                if (criminalData.ListCriminalOtherOrderInfo != null && criminalData.ListCriminalOtherOrderInfo.Count > 0)
                {
                    List<CriminalOtherOrderInfo> listCriminalOtherOrderInfo = criminalData.ListCriminalOtherOrderInfo.Select(chargeInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetCriminalOtherOrderInfo(chargeInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<CriminalOtherOrderInfo>(listCriminalOtherOrderInfo, isCopy);
                }

                if (criminalData.ListLegislationProvisionsInfo != null && criminalData.ListLegislationProvisionsInfo.Count > 0)
                {
                    List<LegislationProvision> listLegislationProvision = criminalData.ListLegislationProvisionsInfo.Select(legislationProvision => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegislationProvision(legislationProvision)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LegislationProvision>(listLegislationProvision, isCopy);
                }

                if (criminalData.ListOriginatingCase != null && criminalData.ListOriginatingCase.Count > 0)
                {
                    List<OriginatingCase> listOriginatingCase = criminalData.ListOriginatingCase.Select(originatingCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOriginatingCase(originatingCase)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OriginatingCase>(listOriginatingCase, isCopy);
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateCriminalData", ex);
                throw;
            }
        }

        /// <summary>
        /// Saves or updates the <see cref="CWUData"/>.
        /// </summary>
        /// <param name="cwuData">The <see cref="CWUData"/> object.</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy is used else SaveOrUpdate.</param>
        private void SaveOrUpdateCWUData(CWUData cwuData, bool isCopy)
        {
            try
            {
                if (cwuData.CWUInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<CWUInfo>(
                        AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetCWUInfo(cwuData.CWUInfoEntity),
                        isCopy);
                }

                if (cwuData.LegislationProvisionsEntityList != null && cwuData.LegislationProvisionsEntityList.Count > 0)
                {
                    List<LegislationProvision> listLegislationProvision = cwuData.LegislationProvisionsEntityList.Select(legislationProvision => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegislationProvision(legislationProvision)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LegislationProvision>(listLegislationProvision, isCopy);
                }

                if (cwuData.NatureOfCaseEntityList != null && cwuData.NatureOfCaseEntityList.Count > 0)
                {
                    List<NatureOfCase> listNatureOfCase = cwuData.NatureOfCaseEntityList.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCase(natureOfCase)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<NatureOfCase>(listNatureOfCase, isCopy);
                }

                if (cwuData.OtherITMOEntityList != null && cwuData.OtherITMOEntityList.Count > 0)
                {
                    List<OtherITMO> listOtherITMO = cwuData.OtherITMOEntityList.Select(otherITMO => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherITMO(otherITMO)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OtherITMO>(listOtherITMO, isCopy);
                }

                if (cwuData.PrayerEntityList != null && cwuData.PrayerEntityList.Count > 0)
                {
                    List<Prayer> listPrayer = cwuData.PrayerEntityList.Select(prayer => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetPrayer(prayer)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<Prayer>(listPrayer, isCopy);
                }

                if (cwuData.LiquidatorEntityList != null && cwuData.LiquidatorEntityList.Count > 0)
                {
                    List<Liquidator> listLiquidator = cwuData.LiquidatorEntityList.Select(liquidator => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLiquidator(liquidator)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<Liquidator>(listLiquidator, isCopy);
                }

                if (cwuData.CWUCheckListInfoList != null && cwuData.CWUCheckListInfoList.Count > 0)
                {
                    List<CWUChecklistInfo> listCWUChecklistInfo = cwuData.CWUCheckListInfoList.Select(cwuCheckListInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetCWUChecklistInfo(cwuCheckListInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<CWUChecklistInfo>(listCWUChecklistInfo, isCopy);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateCWUData", ex);
                throw;
            }
        }

        /// <summary>
        /// Saves the or update data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataToSave">The data to save.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        private void SaveOrUpdateData<T>(T dataToSave, bool isCopy)
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            if (!isCopy)
                repository.SaveOrUpdate(dataToSave);
            else
                repository.SaveOrUpdateCopy(dataToSave);
        }

        /// <summary>
        /// Saves the or update divorce data.
        /// </summary>
        /// <param name="divorceData">The divorce data.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        private void SaveOrUpdateDivorceData(DivorceData divorceData, bool isCopy)
        {
            if (divorceData.DivorceInfoEntity != null)
            {
                DivorceInfo divorceInfo = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDivorceInfo(divorceData.DivorceInfoEntity);
                SaveOrUpdateData(divorceInfo, isCopy);
            }
            if (divorceData.ListDivorceSubInfoEntity != null && divorceData.ListDivorceSubInfoEntity.Count > 0)
            {
                List<DivorceSubInfo> listDivorceSubInfo = divorceData.ListDivorceSubInfoEntity.Select(divorceSubInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubsequentMapper.GetDivorceSubInfo(divorceSubInfo)).ToList();
                foreach (DivorceSubInfo divorceSubInfo in listDivorceSubInfo)
                    SaveOrUpdateData(divorceSubInfo, isCopy);
            }
            if (divorceData.ListChildInfoEntity != null && divorceData.ListChildInfoEntity.Count > 0)
            {
                List<ChildInfo> listChildInfo = divorceData.ListChildInfoEntity.Select(childInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetChildInfo(childInfo)).ToList();

                foreach (ChildInfo childInfo in listChildInfo)
                {
                    SaveOrUpdateData(childInfo, isCopy);
                }
            }

            if (divorceData.ListGroundInfo != null && divorceData.ListGroundInfo.Count > 0)
            {
                List<GroundInfo> listGroundInfo = divorceData.ListGroundInfo.Select(groundInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetGroundInfo(groundInfo)).ToList();
                foreach (GroundInfo groundInfo in listGroundInfo)
                {
                    SaveOrUpdateData(groundInfo, isCopy);
                }
            }

            if (divorceData.ListNatureOfCaseEntity != null && divorceData.ListNatureOfCaseEntity.Count > 0)
            {
                List<NatureOfCase> listNatureOfCase = divorceData.ListNatureOfCaseEntity.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCase(natureOfCase)).ToList();
                foreach (NatureOfCase natureOfCase in listNatureOfCase)
                {
                    SaveOrUpdateData(natureOfCase, isCopy);
                }
            }

            if (divorceData.ListPrayers != null && divorceData.ListPrayers.Count > 0)
            {
                List<Prayer> listPrayer = divorceData.ListPrayers.Select(prayers => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetPrayer(prayers)).ToList();
                foreach (Prayer prayer in listPrayer)
                {
                    SaveOrUpdateData(prayer, isCopy);
                }
            }

            if (divorceData.ListRelatedProceedingEntity != null && divorceData.ListRelatedProceedingEntity.Count > 0)
            {
                List<RelatedProceeding> listRelatedProceeding = divorceData.ListRelatedProceedingEntity.Select(relatedProceeding => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRelatedProceeding(relatedProceeding)).ToList();
                foreach (RelatedProceeding relatedProceeding in listRelatedProceeding)
                {
                    SaveOrUpdateData(relatedProceeding, isCopy);
                }
            }

            if (divorceData.ListRefOrderDetailEntity != null && divorceData.ListRefOrderDetailEntity.Count > 0)
            {
                List<RefOrderDetail> listRefOrderDetail = divorceData.ListRefOrderDetailEntity.Select(refOrderDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetail)).ToList();
                foreach (RefOrderDetail refOrderDetail in listRefOrderDetail)
                {
                    SaveOrUpdateData(refOrderDetail, isCopy);
                }
            }
        }

        /// <summary>
        /// Saves or updates the <see cref="EnforcementData"/>.
        /// </summary>
        /// <param name="applicationAdvocatesSolicitorsData">The <see cref="EnforcementData"/> object.</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy is used else SaveOrUpdate.</param>
        private void SaveOrUpdateEnforcementData(EnforcementData enforcementData, bool isCopy)
        {
            try
            {
                if (enforcementData.WOEInfoEntity != null)
                {
                    WOEInfo woeInfo = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubsequentMapper.GetWOEInfo(enforcementData.WOEInfoEntity);
                    this.genericGateway.SaveOrUpdateEntity<WOEInfo>(woeInfo, isCopy);
                }
                if (enforcementData.WOEMOMSCTInfoEntity != null)
                {
                    WOEMOMSCTInfo woeMOMSCTInfo = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetWOEMOMSCTInfo(enforcementData.WOEMOMSCTInfoEntity);
                    this.genericGateway.SaveOrUpdateEntity<WOEMOMSCTInfo>(woeMOMSCTInfo, isCopy);
                }/*
                if ((enforcementData.ListWOEMOMSCTInfoEntity != null) && (enforcementData.ListWOEMOMSCTInfoEntity.Count > 0))
                {
                    List<WOEMOMSCTInfo> listWOEMOMSCTInfo = enforcementData.ListWOEMOMSCTInfoEntity.Select(woeMOMSCTInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetWOEMOMSCTInfo(woeMOMSCTInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<WOEMOMSCTInfo>(listWOEMOMSCTInfo, isCopy);
                }*/
                if ((enforcementData.ListWOEExecutionAddressEntity != null) && (enforcementData.ListWOEExecutionAddressEntity.Count > 0))
                {
                    List<WOEExecutionAddress> listWOEExecutionAddress = enforcementData.ListWOEExecutionAddressEntity.Select(woeExecutionAddress => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetWOEExecutionAddress(woeExecutionAddress)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<WOEExecutionAddress>(listWOEExecutionAddress, isCopy);
                }
                /*if (enforcementData.RefOrderDetailEntity != null)
                {
                    RefOrderDetail refOrderDetail = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(enforcementData.RefOrderDetailEntity);
                    this.genericGateway.SaveOrUpdateEntity<RefOrderDetail>(refOrderDetail, isCopy);
                }*/
                if ((enforcementData.ListRefOrderDetailEntity != null) && (enforcementData.ListRefOrderDetailEntity.Count > 0))
                {
                    List<RefOrderDetail> listRefOrderDetail = enforcementData.ListRefOrderDetailEntity.Select(refOrderDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetail)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<RefOrderDetail>(listRefOrderDetail, isCopy);
                }
                if ((enforcementData.ListRefOrderJOInfoEntity != null) && (enforcementData.ListRefOrderJOInfoEntity.Count > 0))
                {
                    List<RefOrderJOInfo> listRefOrderJOInfo = enforcementData.ListRefOrderJOInfoEntity.Select(refOrderJOInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderJOInfo(refOrderJOInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<RefOrderJOInfo>(listRefOrderJOInfo, isCopy);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateEnforcementData", ex);
                throw;
            }
        }

        private void SaveOrUpdateOriginatingSummonsBankruptcyData(OriginatingSummonsBankruptcyData originatingSummonsBankruptcyData, bool isCopy)
        {
            try
            {
                if (originatingSummonsBankruptcyData.ListLegislationProvisionsEntity != null && originatingSummonsBankruptcyData.ListLegislationProvisionsEntity.Count > 0)
                {
                    List<LegislationProvision> listLegislationProvision = originatingSummonsBankruptcyData.ListLegislationProvisionsEntity.Select(legislationProvision => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegislationProvision(legislationProvision)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LegislationProvision>(listLegislationProvision, isCopy);
                }
                if (originatingSummonsBankruptcyData.ListNatureOfCaseEntity != null && originatingSummonsBankruptcyData.ListNatureOfCaseEntity.Count > 0)
                {
                    List<NatureOfCase> listNatureOfCase = originatingSummonsBankruptcyData.ListNatureOfCaseEntity.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCase(natureOfCase)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<NatureOfCase>(listNatureOfCase, isCopy);
                }
                if (originatingSummonsBankruptcyData.ListOtherITMOEntity != null && originatingSummonsBankruptcyData.ListOtherITMOEntity.Count > 0)
                {
                    List<OtherITMO> listOtherITMO = originatingSummonsBankruptcyData.ListOtherITMOEntity.Select(otherITMO => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherITMO(otherITMO)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OtherITMO>(listOtherITMO, isCopy);
                }
                if (originatingSummonsBankruptcyData.OSInfoEntity != null)
                {
                    OSInfo oSInfo = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetOSInfo(originatingSummonsBankruptcyData.OSInfoEntity);
                    this.genericGateway.SaveOrUpdateEntity<OSInfo>(oSInfo, isCopy);
                }
                if (originatingSummonsBankruptcyData.ListPrayerEntity != null && originatingSummonsBankruptcyData.ListPrayerEntity.Count > 0)
                {
                    List<Prayer> listPrayer = originatingSummonsBankruptcyData.ListPrayerEntity.Select(prayer => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetPrayer(prayer)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<Prayer>(listPrayer, isCopy);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at SaveOrUpdateOriginatingSummonsBankruptcyData", ex);
                throw;
            }
        }

        private void SaveOrUpdateOriginatingSummonsData(OriginatingSummonsData originatingSummonsData, bool isCopy)
        {
            try
            {
                if (originatingSummonsData.OSInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<OSInfo>(
                        AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetOSInfo(originatingSummonsData.OSInfoEntity),
                        isCopy);
                }

                if (originatingSummonsData.WOSInfoEntity != null)
                    this.genericGateway.SaveOrUpdateEntity<WOSInfo>(
                       AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetWOSInfo(originatingSummonsData.WOSInfoEntity),
                       isCopy);

                if (originatingSummonsData.ListCertSecurityOfCostsInfoEntity != null && originatingSummonsData.ListCertSecurityOfCostsInfoEntity.Count > 0)
                {
                    List<CertSecurityOfCostsInfo> listCertSecurityOfCostsInfo = originatingSummonsData.ListCertSecurityOfCostsInfoEntity.Select(certSecurityOfCostsInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetCertSecurityOfCostsInfo(certSecurityOfCostsInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<CertSecurityOfCostsInfo>(listCertSecurityOfCostsInfo, isCopy);
                }

                if (originatingSummonsData.ListDeceasedAliasEntity != null && originatingSummonsData.ListDeceasedAliasEntity.Count > 0)
                {
                    List<DeceasedAlias> listDeceasedAlias = originatingSummonsData.ListDeceasedAliasEntity.Select(deceasedAlias => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDeceasedAlias(deceasedAlias)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DeceasedAlias>(listDeceasedAlias, isCopy);
                }

                if (originatingSummonsData.ListDeceasedIdentificationsEntity != null && originatingSummonsData.ListDeceasedIdentificationsEntity.Count > 0)
                {
                    List<DeceasedIdentification> listDeceasedIdentification = originatingSummonsData.ListDeceasedIdentificationsEntity.Select(deceasedIdentification => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDeceasedIdentification(deceasedIdentification)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DeceasedIdentification>(listDeceasedIdentification, isCopy);
                }

                if (originatingSummonsData.ListDeceasedInfoEntity != null && originatingSummonsData.ListDeceasedInfoEntity.Count > 0)
                {
                    List<DeceasedInfo> listDeceasedInfo = originatingSummonsData.ListDeceasedInfoEntity.Select(deceasedInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDeceasedInfo(deceasedInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DeceasedInfo>(listDeceasedInfo, isCopy);
                }

                if (originatingSummonsData.ListInfantInfoEntity != null && originatingSummonsData.ListInfantInfoEntity.Count > 0)
                {
                    List<InfantInfo> listInfantInfo = originatingSummonsData.ListInfantInfoEntity.Select(infantInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetInfantInfo(infantInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<InfantInfo>(listInfantInfo, isCopy);
                }

                if (originatingSummonsData.ListLegislationProvisionsEntity != null && originatingSummonsData.ListLegislationProvisionsEntity.Count > 0)
                {
                    List<LegislationProvision> listLegislationProvision = originatingSummonsData.ListLegislationProvisionsEntity.Select(legislationProvision => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegislationProvision(legislationProvision)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LegislationProvision>(listLegislationProvision, isCopy);
                }

                if (originatingSummonsData.ListNatureOfCaseEntity != null && originatingSummonsData.ListNatureOfCaseEntity.Count > 0)
                {
                    List<NatureOfCase> listNatureOfCase = originatingSummonsData.ListNatureOfCaseEntity.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCase(natureOfCase)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<NatureOfCase>(listNatureOfCase, isCopy);
                }

                if (originatingSummonsData.ListOtherITMOEntity != null && originatingSummonsData.ListOtherITMOEntity.Count > 0)
                {
                    List<OtherITMO> listOtherITMO = originatingSummonsData.ListOtherITMOEntity.Select(otherITMO => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherITMO(otherITMO)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OtherITMO>(listOtherITMO, isCopy);
                }

                if (originatingSummonsData.ListPrayerEntity != null && originatingSummonsData.ListPrayerEntity.Count > 0)
                {
                    List<Prayer> listPrayer = originatingSummonsData.ListPrayerEntity.Select(prayer => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetPrayer(prayer)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<Prayer>(listPrayer, isCopy);
                }

                if (originatingSummonsData.ListOSJudicialManagerDetailsEntity != null && originatingSummonsData.ListOSJudicialManagerDetailsEntity.Count > 0)
                {
                    List<OSJudicialManagerDetails> listOSJudicialManagerDetails = originatingSummonsData.ListOSJudicialManagerDetailsEntity.Select(oSJudicialManagerDetails => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetOSJudicialManagerDetails(oSJudicialManagerDetails)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OSJudicialManagerDetails>(listOSJudicialManagerDetails, isCopy);
                }

                if (originatingSummonsData.ListOSMADetailsEntity != null && originatingSummonsData.ListOSMADetailsEntity.Count > 0)
                {
                    List<OSMADetails> listOSMADetails = originatingSummonsData.ListOSMADetailsEntity.Select(oSMADetails => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetOSMADetails(oSMADetails)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OSMADetails>(listOSMADetails, isCopy);
                }

                if (originatingSummonsData.ListLiquidatedClaimEntity != null && originatingSummonsData.ListLiquidatedClaimEntity.Count > 0)
                {
                    List<LiquidatedClaim> listLiquidatedClaim = originatingSummonsData.ListLiquidatedClaimEntity.Select(liquidatedClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLiquidatedClaim(liquidatedClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LiquidatedClaim>(listLiquidatedClaim, isCopy);
                }

                if (originatingSummonsData.ListUnliquidatedClaimEntity != null && originatingSummonsData.ListUnliquidatedClaimEntity.Count > 0)
                {
                    List<UnliquidatedClaim> listUnliquidatedClaim = originatingSummonsData.ListUnliquidatedClaimEntity.Select(unliquidatedClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetUnliquidatedClaim(unliquidatedClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<UnliquidatedClaim>(listUnliquidatedClaim, isCopy);
                }

                if (originatingSummonsData.ListOtherReliefsClaimEntity != null && originatingSummonsData.ListOtherReliefsClaimEntity.Count > 0)
                {
                    List<OtherReliefsClaim> listOtherReliefsClaim = originatingSummonsData.ListOtherReliefsClaimEntity.Select(otherReliefsClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherReliefsClaim(otherReliefsClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OtherReliefsClaim>(listOtherReliefsClaim, isCopy);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateOriginatingSummonsData", ex);
                throw;
            }
        }

        private void SaveOrUpdateProbateData(ProbateData probateData, bool isCopy)
        {
            try
            {
                if (probateData.ProbateInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<ProbateInfo>(
                         AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetProbateInfo(probateData.ProbateInfoEntity),
                        isCopy);
                }

                if (probateData.ListDeceasedAliasEntity != null && probateData.ListDeceasedAliasEntity.Count > 0)
                {
                    List<DeceasedAlias> listDeceasedAlias = probateData.ListDeceasedAliasEntity.Select(deceasedAlias => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDeceasedAlias(deceasedAlias)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DeceasedAlias>(listDeceasedAlias, isCopy);
                }

                if (probateData.ListDeceasedIdentificationsEntity != null && probateData.ListDeceasedIdentificationsEntity.Count > 0)
                {
                    List<DeceasedIdentification> listDeceasedIdentification = probateData.ListDeceasedIdentificationsEntity.Select(deceasedIdentification => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDeceasedIdentification(deceasedIdentification)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DeceasedIdentification>(listDeceasedIdentification, isCopy);
                }

                if (probateData.ListDeceasedInfoEntity != null && probateData.ListDeceasedInfoEntity.Count > 0)
                {
                    List<DeceasedInfo> listDeceasedInfo = probateData.ListDeceasedInfoEntity.Select(deceasedInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDeceasedInfo(deceasedInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DeceasedInfo>(listDeceasedInfo, isCopy);
                }

                if (probateData.ListPBBeneficiaryDetailEntity != null && probateData.ListPBBeneficiaryDetailEntity.Count > 0)
                {
                    List<PBBeneficiaryDetails> listPBBeneficiaryDetails = probateData.ListPBBeneficiaryDetailEntity.Select(pBBeneficiaryDetails => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetPBBeneficiaryDetails(pBBeneficiaryDetails)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<PBBeneficiaryDetails>(listPBBeneficiaryDetails, isCopy);
                }

                if (probateData.ListPBCoAdminDetailEntity != null && probateData.ListPBCoAdminDetailEntity.Count > 0)
                {
                    List<PBCoAdminDetails> listPBCoAdminDetails = probateData.ListPBCoAdminDetailEntity.Select(pBCoAdminDetails => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetPBCoAdminDetails(pBCoAdminDetails)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<PBCoAdminDetails>(listPBCoAdminDetails, isCopy);
                }

                if (probateData.ListPBExecutorDetailEntity != null && probateData.ListPBExecutorDetailEntity.Count > 0)
                {
                    List<PBExecutorDetails> listPBExecutorDetails = probateData.ListPBExecutorDetailEntity.Select(pBExecutorDetails => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetPBExecutorDetail(pBExecutorDetails)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<PBExecutorDetails>(listPBExecutorDetails, isCopy);
                }

                if (probateData.ListPBPrevGrantDetailEntity != null && probateData.ListPBPrevGrantDetailEntity.Count > 0)
                {
                    List<PBPrevGrantDetails> listPBPrevGrantDetail = probateData.ListPBPrevGrantDetailEntity.Select(pBPrevGrantDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetPBPrevGrantDetails(pBPrevGrantDetail)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<PBPrevGrantDetails>(listPBPrevGrantDetail, isCopy);
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateProbateData", ex);
                throw;
            }
        }

        private void SaveOrUpdateTaxationData(TaxationData taxationData, bool isCopy)
        {
            try
            {
                if (taxationData.TaxationInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<TaxationInfo>(
                                             AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetTaxationInfo(taxationData.TaxationInfoEntity),
                                            isCopy);
                }

                if (taxationData.ListTaxationClaimEntity != null && taxationData.ListTaxationClaimEntity.Count > 0)
                {

                    List<TaxationClaim> listTaxationClaim = taxationData.ListTaxationClaimEntity.Select(taxationClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetTaxationClaim(taxationClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<TaxationClaim>(listTaxationClaim, isCopy);
                }

                if (taxationData.ListBOTDetailEntity != null && taxationData.ListBOTDetailEntity.Count > 0)
                {

                    List<BOTDetails> listBOTDetails = taxationData.ListBOTDetailEntity.Select(bOTDetails => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetBOTDetails(bOTDetails)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<BOTDetails>(listBOTDetails, isCopy);
                }

                if (taxationData.ListLegislationProvisionsEntity != null && taxationData.ListLegislationProvisionsEntity.Count > 0)
                {

                    List<LegislationProvision> listLegislationProvision = taxationData.ListLegislationProvisionsEntity.Select(legislationProvision => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegislationProvision(legislationProvision)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LegislationProvision>(listLegislationProvision, isCopy);
                }

                if (taxationData.ListNatureOfApplicationEntity != null && taxationData.ListNatureOfApplicationEntity.Count > 0)
                {

                    List<NatureOfApplication> listNatureOfApplication = taxationData.ListNatureOfApplicationEntity.Select(natureOfApplication => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfApplication(natureOfApplication)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<NatureOfApplication>(listNatureOfApplication, isCopy);
                }

                if (taxationData.ListRefOrderDetailEntity != null && taxationData.ListRefOrderDetailEntity.Count > 0)
                {

                    List<RefOrderDetail> listRefOrderDetail = taxationData.ListRefOrderDetailEntity.Select(refOrderDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetail)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<RefOrderDetail>(listRefOrderDetail, isCopy);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateTaxationData", ex);
                throw;
            }
        }

        private void SaveOrUpdateWOSData(WOSData wOSData, bool isCopy)
        {
            try
            {
                if (wOSData.WOSInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<WOSInfo>(
                        AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetWOSInfo(wOSData.WOSInfoEntity),
                        isCopy);
                }
                if (wOSData.ListLiquidatedClaimEntity != null && wOSData.ListLiquidatedClaimEntity.Count > 0)
                {
                    List<LiquidatedClaim> listLiquidatedClaim = wOSData.ListLiquidatedClaimEntity.Select(liquidatedClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLiquidatedClaim(liquidatedClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LiquidatedClaim>(listLiquidatedClaim, isCopy);
                }
                if (wOSData.ListNatureOfCaseEntity != null && wOSData.ListNatureOfCaseEntity.Count > 0)
                {
                    List<NatureOfCase> listNatureOfCase = wOSData.ListNatureOfCaseEntity.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCase(natureOfCase)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<NatureOfCase>(listNatureOfCase, isCopy);
                }

                if (wOSData.ListOtherReliefsClaimEntity != null && wOSData.ListOtherReliefsClaimEntity.Count > 0)
                {
                    List<OtherReliefsClaim> listOtherReliefsClaim = wOSData.ListOtherReliefsClaimEntity.Select(otherReliefsClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherReliefsClaim(otherReliefsClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OtherReliefsClaim>(listOtherReliefsClaim, isCopy);
                }

                if (wOSData.ListRefOrderDetailEntity != null && wOSData.ListRefOrderDetailEntity.Count > 0)
                {
                    List<RefOrderDetail> listRefOrderDetail = wOSData.ListRefOrderDetailEntity.Select(refOrderDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetail)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<RefOrderDetail>(listRefOrderDetail, isCopy);
                }

                if (wOSData.ListUnliquidatedClaimEntity != null && wOSData.ListUnliquidatedClaimEntity.Count > 0)
                {
                    List<UnliquidatedClaim> listUnliquidatedClaim = wOSData.ListUnliquidatedClaimEntity.Select(unliquidatedClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetUnliquidatedClaim(unliquidatedClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<UnliquidatedClaim>(listUnliquidatedClaim, isCopy);
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateWOSData", ex);
                throw;
            }
        }

        internal ICaseTypeInfo GetRASDataBySGID(string submissionGroupId)
        {
            RASData rASData = null;

            try
            {
                CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
                CommonGateway commonGateway = new CommonGateway();

                rASData = new RASData();

                rASData.ListLegislationProvisionsEntity = commonGateway.GetListLegislationProvisionsEntityBySGID(submissionGroupId);
                rASData.ListNatureOfCaseEntity = commonGateway.GetListNatureOfCaseEntityBySGID(submissionGroupId);
                rASData.ListRefOrderDetailEntity = commonGateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);
                rASData.RASInfoEntity = caseSpecificGateway.GetRASInfoEntityBySGID(submissionGroupId);
                rASData.ListNatureOfApplicationEntity = commonGateway.GetListNatureOfApplicationEntityBySGID(submissionGroupId);
                rASData.ListDCACAOriginatingCasePartyInfoEntity = caseSpecificGateway.GetListDCACAOriginatingCasePartyInfoBySGID(submissionGroupId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRASDataBySGID", ex);
                throw;
            }

            return rASData;
        }

        private void SaveOrUpdateRASData(RASData rASData, bool isCopy)
        {
            try
            {
                if (rASData.RASInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<RASInfo>(
                                AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetRASInfo(rASData.RASInfoEntity),
                                isCopy);
                }

                if (rASData.ListLegislationProvisionsEntity != null && rASData.ListLegislationProvisionsEntity.Count > 0)
                {
                    List<LegislationProvision> listLegislationProvision = rASData.ListLegislationProvisionsEntity.Select(legislationProvision => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegislationProvision(legislationProvision)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LegislationProvision>(listLegislationProvision, isCopy);
                }

                if (rASData.ListNatureOfCaseEntity != null && rASData.ListNatureOfCaseEntity.Count > 0)
                {
                    List<NatureOfCase> listNatureOfCase = rASData.ListNatureOfCaseEntity.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCase(natureOfCase)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<NatureOfCase>(listNatureOfCase, isCopy);
                }

                if (rASData.ListOtherITMOEntity != null && rASData.ListOtherITMOEntity.Count > 0)
                {
                    List<OtherITMO> listOtherITMO = rASData.ListOtherITMOEntity.Select(otherITMO => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherITMO(otherITMO)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OtherITMO>(listOtherITMO, isCopy);
                }

                if (rASData.ListRefOrderDetailEntity != null && rASData.ListRefOrderDetailEntity.Count > 0)
                {
                    List<RefOrderDetail> listRefOrderDetail = rASData.ListRefOrderDetailEntity.Select(refOrderDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetail)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<RefOrderDetail>(listRefOrderDetail, isCopy);
                }

                if (rASData.ListNatureOfApplicationEntity != null && rASData.ListNatureOfApplicationEntity.Count > 0)
                {
                    List<NatureOfApplication> listNatureOfApplication = rASData.ListNatureOfApplicationEntity.Select(natureOfApplication => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfApplication(natureOfApplication)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<NatureOfApplication>(listNatureOfApplication, isCopy);
                }

                if (rASData.ListDCACAOriginatingCasePartyInfoEntity != null && rASData.ListDCACAOriginatingCasePartyInfoEntity.Count > 0)
                {
                    List<DCACAOriginatingCasePartyInfo> listDCACAOriginatingCasePartyInfo = rASData.ListDCACAOriginatingCasePartyInfoEntity.Select(dCACAOriginatingCasePartyInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetDCACAOriginatingCasePartyInfo(dCACAOriginatingCasePartyInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DCACAOriginatingCasePartyInfo>(listDCACAOriginatingCasePartyInfo, isCopy);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateRASData", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the siccos data by sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        /// <returns></returns>
        internal ICaseTypeInfo GetSICCOSDataBySGID(string submissionGroupId)
        {
            SICCOSData siccosData = new SICCOSData();
            try
            {
                CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
                CommonGateway commonGateway = new CommonGateway();
                siccosData.OSInfoEntity = caseSpecificGateway.GetOSInfoEntityBySGID(submissionGroupId);
                siccosData.ListCertSecurityOfCostsInfoEntity = commonGateway.GetListCertSecurityOfCostsInfo(submissionGroupId);
                siccosData.ListDeceasedAliasEntity = commonGateway.GetListDeceasedAliasBySGID(submissionGroupId);
                siccosData.ListDeceasedIdentificationsEntity = commonGateway.GetListDeceasedIdentificationBySGID(submissionGroupId);
                siccosData.ListDeceasedInfoEntity = commonGateway.GetListDeceasedInfoBySGID(submissionGroupId);
                siccosData.ListInfantInfoEntity = commonGateway.GetListInfoEntityBySGID(submissionGroupId);
                siccosData.ListLegislationProvisionsEntity = commonGateway.GetListLegislationProvisionsEntityBySGID(submissionGroupId);
                siccosData.ListNatureOfCaseEntity = commonGateway.GetListNatureOfCaseEntityBySGID(submissionGroupId);
                siccosData.ListOSJudicialManagerDetailsEntity = caseSpecificGateway.GetListOSJudicialManagerDetailEntityBySGID(submissionGroupId);
                siccosData.ListOSMADetailsEntity = caseSpecificGateway.GetListOSMADetailsEntityBySGID(submissionGroupId);
                siccosData.ListOtherITMOEntity = commonGateway.GetListOtherITMOEntityBySGID(submissionGroupId);
                siccosData.ListPrayerEntity = commonGateway.GetListPrayerEntityBySGID(submissionGroupId);
                siccosData.WOSInfoEntity = caseSpecificGateway.GetWOSInfoEntityBySGID(submissionGroupId);
                siccosData.ListLiquidatedClaimEntity = commonGateway.GetListLiquidatedClaimBySGID(submissionGroupId);
                siccosData.ListUnliquidatedClaimEntity = commonGateway.GetListUnLiquidatedClaimEntityBySGID(submissionGroupId);
                siccosData.ListOtherReliefsClaimEntity = commonGateway.GetListOtherReliefsClaimEntityBySGID(submissionGroupId);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSICCOSDataBySGID", ex);
                throw;
            }
            return siccosData;
        }

        /// <summary>
        /// Saves the or update siccos data.
        /// </summary>
        /// <param name="siccosData">The siccos data.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        private void SaveOrUpdateSICCOSData(SICCOSData siccosData, bool isCopy)
        {
            try
            {
                if (siccosData.OSInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<OSInfo>(
                        AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetOSInfo(siccosData.OSInfoEntity),
                        isCopy);
                }

                if (siccosData.WOSInfoEntity != null)
                    this.genericGateway.SaveOrUpdateEntity<WOSInfo>(
                       AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetWOSInfo(siccosData.WOSInfoEntity),
                       isCopy);

                if (siccosData.ListCertSecurityOfCostsInfoEntity != null && siccosData.ListCertSecurityOfCostsInfoEntity.Count > 0)
                {
                    List<CertSecurityOfCostsInfo> listCertSecurityOfCostsInfo = siccosData.ListCertSecurityOfCostsInfoEntity.Select(certSecurityOfCostsInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetCertSecurityOfCostsInfo(certSecurityOfCostsInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<CertSecurityOfCostsInfo>(listCertSecurityOfCostsInfo, isCopy);
                }

                if (siccosData.ListDeceasedAliasEntity != null && siccosData.ListDeceasedAliasEntity.Count > 0)
                {
                    List<DeceasedAlias> listDeceasedAlias = siccosData.ListDeceasedAliasEntity.Select(deceasedAlias => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDeceasedAlias(deceasedAlias)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DeceasedAlias>(listDeceasedAlias, isCopy);
                }

                if (siccosData.ListDeceasedIdentificationsEntity != null && siccosData.ListDeceasedIdentificationsEntity.Count > 0)
                {
                    List<DeceasedIdentification> listDeceasedIdentification = siccosData.ListDeceasedIdentificationsEntity.Select(deceasedIdentification => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDeceasedIdentification(deceasedIdentification)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DeceasedIdentification>(listDeceasedIdentification, isCopy);
                }

                if (siccosData.ListDeceasedInfoEntity != null && siccosData.ListDeceasedInfoEntity.Count > 0)
                {
                    List<DeceasedInfo> listDeceasedInfo = siccosData.ListDeceasedInfoEntity.Select(deceasedInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDeceasedInfo(deceasedInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<DeceasedInfo>(listDeceasedInfo, isCopy);
                }

                if (siccosData.ListInfantInfoEntity != null && siccosData.ListInfantInfoEntity.Count > 0)
                {
                    List<InfantInfo> listInfantInfo = siccosData.ListInfantInfoEntity.Select(infantInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetInfantInfo(infantInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<InfantInfo>(listInfantInfo, isCopy);
                }

                if (siccosData.ListLegislationProvisionsEntity != null && siccosData.ListLegislationProvisionsEntity.Count > 0)
                {
                    List<LegislationProvision> listLegislationProvision = siccosData.ListLegislationProvisionsEntity.Select(legislationProvision => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegislationProvision(legislationProvision)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LegislationProvision>(listLegislationProvision, isCopy);
                }

                if (siccosData.ListNatureOfCaseEntity != null && siccosData.ListNatureOfCaseEntity.Count > 0)
                {
                    List<NatureOfCase> listNatureOfCase = siccosData.ListNatureOfCaseEntity.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCase(natureOfCase)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<NatureOfCase>(listNatureOfCase, isCopy);
                }

                if (siccosData.ListOtherITMOEntity != null && siccosData.ListOtherITMOEntity.Count > 0)
                {
                    List<OtherITMO> listOtherITMO = siccosData.ListOtherITMOEntity.Select(otherITMO => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherITMO(otherITMO)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OtherITMO>(listOtherITMO, isCopy);
                }

                if (siccosData.ListPrayerEntity != null && siccosData.ListPrayerEntity.Count > 0)
                {
                    List<Prayer> listPrayer = siccosData.ListPrayerEntity.Select(prayer => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetPrayer(prayer)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<Prayer>(listPrayer, isCopy);
                }

                if (siccosData.ListOSJudicialManagerDetailsEntity != null && siccosData.ListOSJudicialManagerDetailsEntity.Count > 0)
                {
                    List<OSJudicialManagerDetails> listOSJudicialManagerDetails = siccosData.ListOSJudicialManagerDetailsEntity.Select(oSJudicialManagerDetails => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetOSJudicialManagerDetails(oSJudicialManagerDetails)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OSJudicialManagerDetails>(listOSJudicialManagerDetails, isCopy);
                }

                if (siccosData.ListOSMADetailsEntity != null && siccosData.ListOSMADetailsEntity.Count > 0)
                {
                    List<OSMADetails> listOSMADetails = siccosData.ListOSMADetailsEntity.Select(oSMADetails => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetOSMADetails(oSMADetails)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OSMADetails>(listOSMADetails, isCopy);
                }

                if (siccosData.ListLiquidatedClaimEntity != null && siccosData.ListLiquidatedClaimEntity.Count > 0)
                {
                    List<LiquidatedClaim> listLiquidatedClaim = siccosData.ListLiquidatedClaimEntity.Select(liquidatedClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLiquidatedClaim(liquidatedClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LiquidatedClaim>(listLiquidatedClaim, isCopy);
                }

                if (siccosData.ListUnliquidatedClaimEntity != null && siccosData.ListUnliquidatedClaimEntity.Count > 0)
                {
                    List<UnliquidatedClaim> listUnliquidatedClaim = siccosData.ListUnliquidatedClaimEntity.Select(unliquidatedClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetUnliquidatedClaim(unliquidatedClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<UnliquidatedClaim>(listUnliquidatedClaim, isCopy);
                }

                if (siccosData.ListOtherReliefsClaimEntity != null && siccosData.ListOtherReliefsClaimEntity.Count > 0)
                {
                    List<OtherReliefsClaim> listOtherReliefsClaim = siccosData.ListOtherReliefsClaimEntity.Select(otherReliefsClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherReliefsClaim(otherReliefsClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OtherReliefsClaim>(listOtherReliefsClaim, isCopy);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateSICCOSData", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the siccs data by sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        /// <returns></returns>
        internal ICaseTypeInfo GetSICCSDataBySGID(string submissionGroupId)
        {
            SICCSData siccsData = new SICCSData();
            try
            {
                CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
                CommonGateway commonGateway = new CommonGateway();

                siccsData.WOSInfoEntity = caseSpecificGateway.GetWOSInfoEntityBySGID(submissionGroupId);
                siccsData.ListLiquidatedClaimEntity = commonGateway.GetListLiquidatedClaimBySGID(submissionGroupId);
                siccsData.ListNatureOfCaseEntity = commonGateway.GetListNatureOfCaseEntityBySGID(submissionGroupId);
                siccsData.ListOtherReliefsClaimEntity = commonGateway.GetListOtherReliefsClaimEntityBySGID(submissionGroupId);
                siccsData.ListRefOrderDetailEntity = commonGateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);
                siccsData.ListUnliquidatedClaimEntity = commonGateway.GetListUnLiquidatedClaimEntityBySGID(submissionGroupId);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSICCSBySGID", ex);
                throw;
            }

            return siccsData;
        }

        /// <summary>
        /// Saves the or update siccs data.
        /// </summary>
        /// <param name="siccsData">The siccs data.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        private void SaveOrUpdateSICCSData(SICCSData siccsData, bool isCopy)
        {
            try
            {
                if (siccsData.WOSInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<WOSInfo>(
                        AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetWOSInfo(siccsData.WOSInfoEntity),
                        isCopy);
                }
                if (siccsData.ListLiquidatedClaimEntity != null && siccsData.ListLiquidatedClaimEntity.Count > 0)
                {
                    List<LiquidatedClaim> listLiquidatedClaim = siccsData.ListLiquidatedClaimEntity.Select(liquidatedClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLiquidatedClaim(liquidatedClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<LiquidatedClaim>(listLiquidatedClaim, isCopy);
                }
                if (siccsData.ListNatureOfCaseEntity != null && siccsData.ListNatureOfCaseEntity.Count > 0)
                {
                    List<NatureOfCase> listNatureOfCase = siccsData.ListNatureOfCaseEntity.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCase(natureOfCase)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<NatureOfCase>(listNatureOfCase, isCopy);
                }

                if (siccsData.ListOtherReliefsClaimEntity != null && siccsData.ListOtherReliefsClaimEntity.Count > 0)
                {
                    List<OtherReliefsClaim> listOtherReliefsClaim = siccsData.ListOtherReliefsClaimEntity.Select(otherReliefsClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherReliefsClaim(otherReliefsClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<OtherReliefsClaim>(listOtherReliefsClaim, isCopy);
                }

                if (siccsData.ListRefOrderDetailEntity != null && siccsData.ListRefOrderDetailEntity.Count > 0)
                {
                    List<RefOrderDetail> listRefOrderDetail = siccsData.ListRefOrderDetailEntity.Select(refOrderDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetail)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<RefOrderDetail>(listRefOrderDetail, isCopy);
                }

                if (siccsData.ListUnliquidatedClaimEntity != null && siccsData.ListUnliquidatedClaimEntity.Count > 0)
                {
                    List<UnliquidatedClaim> listUnliquidatedClaim = siccsData.ListUnliquidatedClaimEntity.Select(unliquidatedClaim => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetUnliquidatedClaim(unliquidatedClaim)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<UnliquidatedClaim>(listUnliquidatedClaim, isCopy);
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdatesiccsData", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the RFL data by sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        /// <returns></returns>
        internal ICaseTypeInfo GetRFLDataBySGID(string submissionGroupId)
        {
            RFLData rFLData = null;
            try
            {
                CommonGateway commonGateway = new CommonGateway();

                rFLData = new RFLData();
                rFLData.ListRegistrationOfForeignLawyerEntity = commonGateway.GetRegistrationOfForeignLawyerBySGID(submissionGroupId);
                if (rFLData.ListRegistrationOfForeignLawyerEntity != null)
                {
                    foreach (RegistrationOfForeignLawyerEntity frgnregdetail in rFLData.ListRegistrationOfForeignLawyerEntity)
                    {
                        List<ForeignUserRegAddressDetailsEntity> ForeignUserRegAddressDetailsEntityList = commonGateway.GetForeignUserRegAddressDetailsbyRegistrationOfForeignLawyerId(frgnregdetail.RegistrationOfForeignLawyerId);
                        if (ForeignUserRegAddressDetailsEntityList != null && ForeignUserRegAddressDetailsEntityList.Count > 0)
                        {
                            foreach (ForeignUserRegAddressDetailsEntity frgnaddrdetail in ForeignUserRegAddressDetailsEntityList)
                            {
                                if (rFLData.ListForeignUserRegAddressDetailsEntity == null)
                                    rFLData.ListForeignUserRegAddressDetailsEntity = new List<ForeignUserRegAddressDetailsEntity>();
                                rFLData.ListForeignUserRegAddressDetailsEntity.Add(frgnaddrdetail);
                            }
                        }
                        List<ForeignUserPracticeInformationEntity> ForeignUserPracticeInformationEntityList = commonGateway.GetForeignUserPracticeInformationbyRegistrationOfForeignLawyerId(frgnregdetail.RegistrationOfForeignLawyerId);
                        if (ForeignUserPracticeInformationEntityList != null && ForeignUserPracticeInformationEntityList.Count > 0)
                        {
                            foreach (ForeignUserPracticeInformationEntity frgnpracticeinfo in ForeignUserPracticeInformationEntityList)
                            {
                                if (rFLData.ListForeignUserPracticeInformationEntity == null)
                                    rFLData.ListForeignUserPracticeInformationEntity = new List<ForeignUserPracticeInformationEntity>();
                                rFLData.ListForeignUserPracticeInformationEntity.Add(frgnpracticeinfo);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRFLDataBySGID", ex);
                throw;
            }

            return rFLData;
        }

        /// <summary>
        /// Saves the or update RFL data.
        /// </summary>
        /// <param name="rFLData">The r fl data.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        private void SaveOrUpdateRFLData(RFLData rFLData, bool isCopy)
        {
            try
            {

                if (rFLData.ListRegistrationOfForeignLawyerEntity != null && rFLData.ListRegistrationOfForeignLawyerEntity.Count > 0)
                {
                    List<RegistrationOfForeignLawyer> listRegistrationOfForeignLawyer = rFLData.ListRegistrationOfForeignLawyerEntity.Select(registrationOfForeignLawyer => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRegistrationOfForeignLawyer(registrationOfForeignLawyer)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<RegistrationOfForeignLawyer>(listRegistrationOfForeignLawyer, isCopy);
                }

                if (rFLData.ListForeignUserRegAddressDetailsEntity != null && rFLData.ListForeignUserRegAddressDetailsEntity.Count > 0)
                {
                    List<ForeignUserRegAddressDetails> listForeignUserRegAddressDetails = rFLData.ListForeignUserRegAddressDetailsEntity.Select(foreignUserRegAddressDetails => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetForeignUserRegAddressDetails(foreignUserRegAddressDetails)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<ForeignUserRegAddressDetails>(listForeignUserRegAddressDetails, isCopy);
                }

                if (rFLData.ListForeignUserPracticeInformationEntity != null && rFLData.ListForeignUserPracticeInformationEntity.Count > 0)
                {
                    List<ForeignUserPracticeInformation> listForeignUserPracticeInfo = rFLData.ListForeignUserPracticeInformationEntity.Select(foreignUserPracticeInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetForeignUserPracticeInformation(foreignUserPracticeInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<ForeignUserPracticeInformation>(listForeignUserPracticeInfo, isCopy);
                }

               
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateRASData", ex);
                throw;
            }
        }

        #endregion Methods
    }
}