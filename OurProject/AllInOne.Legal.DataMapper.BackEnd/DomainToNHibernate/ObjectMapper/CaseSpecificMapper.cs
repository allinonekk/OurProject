#region Header

/*****************************************************************************************************
* Description : This file handles mapper for Case Specific from Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   09/12/2010   		        Nithin                  Created

*****************************************************************************************************/
// <summary>
// File: CaseSpecificMapper.cs
// Description: This file handles mapper for Case Specific from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "CaseSpecificMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.WritOfSummons;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    //TODO :Nithin-BillOfSale -BE
    /// <summary>
    /// Class handles mapping for Case Specific from Domain objects to NHibernate entities.
    /// </summary>
    public class CaseSpecificMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CaseSpecificMapper));

        #endregion Fields

        #region Methods

        /** End of Criminal Entities **/
        /// <summary>
        /// Gets the <see cref="AASInfo"/>
        /// </summary>
        /// <param name="aASInfoEntity">The AASInfoEntity.</param>
        /// <returns></returns>
        public static AASInfo GetAASInfo(AASInfoEntity aASInfoEntity)
        {
            AASInfo aASInfo = null;
            try
            {
                aASInfo = Mapper.Map<AASInfoEntity, AASInfo>(aASInfoEntity);
                aASInfo.MAASLawDegree = Mapper.Map<MAASLawDegreeEntity, MAASLawDegree>(aASInfoEntity.MAASLawDegree);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAASInfo", ex);
                throw;
            }
            return aASInfo;
        }

        /// <summary>
        /// Gets the <see cref="AASObjection"/>
        /// </summary>
        /// <param name="aASObjectionEntity">The AASObjectionEntity.</param>
        /// <returns></returns>
        public static AASObjection GetAASObjection(AASObjectionEntity aASObjectionEntity)
        {
            AASObjection aASObjection = null;
            try
            {
                aASObjection = Mapper.Map<AASObjectionEntity, AASObjection>(aASObjectionEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAASObjection", ex);
                throw;
            }
            return aASObjection;
        }

        /// <summary>
        /// Get ADM Info.
        /// </summary>
        /// <param name="admInfoDomainEntity"></param>
        /// <returns></returns>
        public static ADMInfo GetAdmInfo(ADMInfoEntity admInfoDomainEntity)
        {
            ADMInfo admInfoNHibernateEntity = null;

            try
            {
                //admiralityMapping.MapAdmInfoToAdmInfoEntity();
                admInfoNHibernateEntity = Mapper.Map<ADMInfoEntity, ADMInfo>(admInfoDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAdmInfoEntity", ex);
                throw;
            }

            return admInfoNHibernateEntity;
        }

        /// <summary>
        /// Gets the bankruptcy info.
        /// </summary>
        /// <param name="bankruptcyInfoEntity">The bankruptcy info entity.</param>
        /// <returns></returns>
        public static BankruptcyInfo GetBankruptcyInfo(BankruptcyInfoEntity bankruptcyInfoEntity)
        {
            BankruptcyInfo bankruptcyInfo = null;

            try
            {
                bankruptcyInfo = Mapper.Map<BankruptcyInfoEntity, BankruptcyInfo>(bankruptcyInfoEntity);
                bankruptcyInfo.MBankruptcyBasis = Mapper.Map<MBankruptcyBasisEntity, MBankruptcyBasis>(bankruptcyInfoEntity.BankruptcyBasis);
                bankruptcyInfo.MBankruptcyType = Mapper.Map<MBankruptcyTypeEntity, MBankruptcyType>(bankruptcyInfoEntity.BankruptcyType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBankruptcyInfo", ex);
                throw;
            }

            return bankruptcyInfo;
        }

        /// <summary>
        /// Gets the <see cref="BankruptcyOtherDefDetail"/> from <see cref="BankruptcyOtherDefDetailEntity"/> input.
        /// </summary>
        /// <param name="bankruptcyOtherDefDetailEntity"><see cref="BankruptcyOtherDefDetailEntity"/></param>
        /// <returns>Returns <see cref="BankruptcyOtherDefDetail"/>, else null.</returns>
        public static BankruptcyOtherDefDetail GetBankruptcyOtherDefDetail(BankruptcyOtherDefDetailEntity bankruptcyOtherDefDetailEntity)
        {
            BankruptcyOtherDefDetail bankruptcyOtherDefDetail = null;

            try
            {
                bankruptcyOtherDefDetail = Mapper.Map<BankruptcyOtherDefDetailEntity, BankruptcyOtherDefDetail>(bankruptcyOtherDefDetailEntity);
                bankruptcyOtherDefDetail.MEntityType = Mapper.Map<MEntityTypeEntity, MEntityType>(bankruptcyOtherDefDetailEntity.MEntityType);
                bankruptcyOtherDefDetail.MPersonIDGroup = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(bankruptcyOtherDefDetailEntity.MPersonIdGroup);
                bankruptcyOtherDefDetail.MBODDIdCountry = Mapper.Map<MCountryEntity, MCountry>(bankruptcyOtherDefDetailEntity.MIdCountry);
                bankruptcyOtherDefDetail.MBODDPersonIdType = Mapper.Map<MPersonIDTypeEntity,MPersonIDType>(bankruptcyOtherDefDetailEntity.MPersonIdType);
                bankruptcyOtherDefDetail.MBODDCompanyIdType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(bankruptcyOtherDefDetailEntity.MCompanyIdType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBankruptcyOtherDefDetail", ex);
                throw;
            }

            return bankruptcyOtherDefDetail;
        }

        /// <summary>
        /// Gets the <see cref="BillOfSaleInfo"/> from <see cref="BillOfSaleInfoEntity"/> input.
        /// </summary>
        /// <param name="billOfSaleInfoEntity"><see cref="BillOfSaleInfoEntity"/></param>
        /// <returns>Returns <see cref="BillOfSaleInfo"/>, else null.</returns>
        public static BillOfSaleInfo GetBillOfSaleInfo(BillOfSaleInfoEntity billOfSaleInfoEntity)
        {
            BillOfSaleInfo billOfSaleInfo = null;

            try
            {
                if (billOfSaleInfoEntity != null)
                {
                    billOfSaleInfo = Mapper.Map<BillOfSaleInfoEntity, BillOfSaleInfo>(billOfSaleInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBillOfSaleInfo", ex);
                throw;
            }

            return billOfSaleInfo;
        }

        /// <summary>
        /// Gets the <see cref="BOTDetails"/>
        /// </summary>
        /// <param name="bOTDetailEntity">The BOTDetailEntity.</param>
        /// <returns></returns>
        public static BOTDetails GetBOTDetails(BOTDetailEntity bOTDetailEntity)
        {
            BOTDetails bOTDetails = null;
            try
            {
                bOTDetails = Mapper.Map<BOTDetailEntity, BOTDetails>(bOTDetailEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBOTDetailEntity", ex);
                throw;
            }
            return bOTDetails;
        }

        /// <summary>
        /// Maps and gets <see cref="CaseSpecific"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iCaseSpecificEntity"></param>
        /// <returns></returns>
        public static ICaseSpecific GetCaseSpecificEntity<T>(ICaseSpecificEntity iCaseSpecificEntity)
        {
            if (iCaseSpecificEntity.GetType().Equals(typeof(ADMInfoEntity)))
                return CaseSpecificMapper.GetAdmInfo(iCaseSpecificEntity as ADMInfoEntity);
            else if (iCaseSpecificEntity.GetType().Equals(typeof(BankruptcyInfoEntity)))
                return CaseSpecificMapper.GetBankruptcyInfo(iCaseSpecificEntity as BankruptcyInfoEntity);
            else if (iCaseSpecificEntity.GetType().Equals(typeof(BankruptcyOtherDefDetailEntity)))
                return CaseSpecificMapper.GetBankruptcyOtherDefDetail(iCaseSpecificEntity as BankruptcyOtherDefDetailEntity);
            //else if (iCaseSpecificEntity.GetType().Equals(typeof(BillOfSaleInfoEntity)))
            //    return CaseSpecificMapper.GetBillOfSaleInfo(iCaseSpecificEntity as BillOfSaleInfoEntity); //TODO :Nithin BillOfSaleInfo
            else if (iCaseSpecificEntity.GetType().Equals(typeof(CWUInfoEntity)))
                return CaseSpecificMapper.GetCWUInfo(iCaseSpecificEntity as CWUInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(CWUCheckListInfoEntity)))
                return CaseSpecificMapper.GetCWUChecklistInfo(iCaseSpecificEntity as CWUCheckListInfoEntity);
            else if (iCaseSpecificEntity.GetType().Equals(typeof(DCACAInfoEntity)))
                return CaseSpecificMapper.GetDCACAInfo(iCaseSpecificEntity as DCACAInfoEntity);
            else if (iCaseSpecificEntity.GetType().Equals(typeof(RefCaveatCaseEntity)))
                return CaseSpecificMapper.GetRefCaveatCase(iCaseSpecificEntity as RefCaveatCaseEntity);
            else if (iCaseSpecificEntity.GetType().Equals(typeof(OSInfoEntity)))
                return CaseSpecificMapper.GetOSInfo(iCaseSpecificEntity as OSInfoEntity);
            else if (iCaseSpecificEntity.GetType().Equals(typeof(CriminalInfoEntity)))
                return GetCriminalInfo(iCaseSpecificEntity as CriminalInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(ChargeInfoEntity)))
                return GetChargeInfo(iCaseSpecificEntity as ChargeInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(CriminalOtherOrderInfoEntity)))
                return GetCriminalOtherOrderInfo(iCaseSpecificEntity as CriminalOtherOrderInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(DrugInfoEntity)))
                return GetDrugInfo(iCaseSpecificEntity as DrugInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(OffenceInfoEntity)))
                return GetOffenceInfo(iCaseSpecificEntity as OffenceInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(SentenceInfoEntity)))
                return GetSentenceInfo(iCaseSpecificEntity as SentenceInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(InvestigatingOfficerInfoEntity)))
                return GetInvestigatingOfficerInfo(iCaseSpecificEntity as InvestigatingOfficerInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(RCriminalLegislationInfoEntity)))
                return GetRCriminalLegislationInfo(iCaseSpecificEntity as RCriminalLegislationInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(AASInfoEntity)))
                return GetAASInfo(iCaseSpecificEntity as AASInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(PracticeOfLawInfoEntity)))
                return GetPracticeOfLawInfo(iCaseSpecificEntity as PracticeOfLawInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(PracticeTrainingPeriodInfoEntity)))
                return GetPracticeTrainingPeriodInfo(iCaseSpecificEntity as PracticeTrainingPeriodInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(AASObjectionEntity)))
                return GetAASObjection(iCaseSpecificEntity as AASObjectionEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(WOEMOMSCTInfoEntity)))
                return GetWOEMOMSCTInfo(iCaseSpecificEntity as WOEMOMSCTInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(WOSInfoEntity)))
                return GetWOSInfo(iCaseSpecificEntity as WOSInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(PBBeneficiaryDetailEntity)))
                return GetPBBeneficiaryDetails(iCaseSpecificEntity as PBBeneficiaryDetailEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(PBCoAdminDetailEntity)))
                return GetPBCoAdminDetails(iCaseSpecificEntity as PBCoAdminDetailEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(PBExecutorDetailEntity)))
                return GetPBExecutorDetail(iCaseSpecificEntity as PBExecutorDetailEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(PBPrevGrantDetailEntity)))
                return GetPBPrevGrantDetails(iCaseSpecificEntity as PBPrevGrantDetailEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(PBWillCodicilEntity)))
                return GetPBWillCodicil(iCaseSpecificEntity as PBWillCodicilEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(TaxationClaimEntity)))
                return GetTaxationClaim(iCaseSpecificEntity as TaxationClaimEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(TaxationInfoEntity)))
                return GetTaxationInfo(iCaseSpecificEntity as TaxationInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(BOTDetailEntity)))
                return GetBOTDetails(iCaseSpecificEntity as BOTDetailEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(SentenceCriminalOrderInfoEntity)))
                return GetSentenceCriminalOrderInfo(iCaseSpecificEntity as SentenceCriminalOrderInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(DCACAOriginatingCasePartyInfoEntity)))
                return GetDCACAOriginatingCasePartyInfo(iCaseSpecificEntity as DCACAOriginatingCasePartyInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(RASInfoEntity)))
                return GetRASInfo(iCaseSpecificEntity as RASInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(BankruptcyDebtInfoEntity)))
                return GetBankruptcyDebtInfo(iCaseSpecificEntity as BankruptcyDebtInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(PBPADetailEntity)))
                return GetPBPADetails(iCaseSpecificEntity as PBPADetailEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(PBSupNExmEntity)))
                return GetPBSupNExm(iCaseSpecificEntity as PBSupNExmEntity);
            
            else if (iCaseSpecificEntity.GetType().Equals(typeof(PBAdminBondEntity)))
                return GetPBAdminBond(iCaseSpecificEntity as PBAdminBondEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(CaseRegisterEntity)))
                return GetCaseRegister(iCaseSpecificEntity as CaseRegisterEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(CaseRegisterHistoryEntity)))
                return GetCaseRegisterHistory(iCaseSpecificEntity as CaseRegisterHistoryEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(DashboardCaseMilestoneDetailEntity)))
                return GetDashboardCaseMilestoneDetail(iCaseSpecificEntity as DashboardCaseMilestoneDetailEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(DashboardCaseMilestoneDetailHistoryEntity)))
                return GetDashboardCaseMilestoneDetailHistory(iCaseSpecificEntity as DashboardCaseMilestoneDetailHistoryEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(CaveatInfoEntity)))
                return GetCaveatInfo(iCaseSpecificEntity as CaveatInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(CaveatAAInfoEntity)))
                return GetCaveatAAInfo(iCaseSpecificEntity as CaveatAAInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(JMChecklistInfoEntity)))
                return GetJMChecklistInfo(iCaseSpecificEntity as JMChecklistInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(JMOtherInfoEntity)))
                return GetJMOtherInfo(iCaseSpecificEntity as JMOtherInfoEntity);

            else if (iCaseSpecificEntity.GetType().Equals(typeof(DirectionDetailsEntity)))
                return GetDirectionDetails(iCaseSpecificEntity as DirectionDetailsEntity);

            else
                throw new ArgumentNullException("Invalid object sent.");
        }

        /// <summary>
        /// Gets the <see cref="WOEMOMSCTInfo"/>
        /// </summary>
        /// <param name="woeMOMSCTInfoEntity">The WOEMOMSCTInfoEntity.</param>
        /// <returns></returns>
        public static CaveatAAInfo GetCaveatAAInfo(CaveatAAInfoEntity caveatAAInfoEntity)
        {
            CaveatAAInfo caveatAAInfo = null;
            try
            {
                caveatAAInfo = Mapper.Map<CaveatAAInfoEntity, CaveatAAInfo>(caveatAAInfoEntity);
                caveatAAInfo.MCountry = Mapper.Map<MCountryEntity, MCountry>(caveatAAInfoEntity.MCountry);
                caveatAAInfo.MPersonIDGroup = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(caveatAAInfoEntity.MPersonIDGroup);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaveatAAInfo", ex);
                throw;
            }
            return caveatAAInfo;
        }

        /// <summary>
        /// Gets the <see cref="ChargeInfo"/> from <see cref="ChargeInfoEntity"/> input.
        /// </summary>
        /// <param name="chargeInfoEntity"><see cref="ChargeInfoEntity"/></param>
        /// <returns>Returns <see cref="ChargeInfo"/>, else null.</returns>
        public static ChargeInfo GetChargeInfo(ChargeInfoEntity chargeInfoEntity)
        {
            ChargeInfo chargeInfo = null;

            try
            {
                if (chargeInfoEntity != null)
                {
                    chargeInfo = Mapper.Map<ChargeInfoEntity, ChargeInfo>(chargeInfoEntity);
                    chargeInfo.MChargeType = Mapper.Map<MChargeTypeEntity, MChargeType>(chargeInfoEntity.MChargeType);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetChargeInfo", ex);
                throw;
            }

            return chargeInfo;
        }

        /** Start of Criminal Entities**/
        /// <summary>
        /// Gets the <see cref="CriminalInfo"/> from <see cref="CriminalInfoEntity"/> input.
        /// </summary>
        /// <param name="criminalInfoEntity"><see cref="CriminalInfoEntity"/></param>
        /// <returns>Returns <see cref="CriminalInfo"/>, else null.</returns>
        public static CriminalInfo GetCriminalInfo(CriminalInfoEntity criminalInfoEntity)
        {
            CriminalInfo criminalInfo = null;

            try
            {
                if (criminalInfoEntity != null)
                {
                    criminalInfo = Mapper.Map<CriminalInfoEntity, CriminalInfo>(criminalInfoEntity);
                    criminalInfo.MNatureOfAppeal = Mapper.Map<MNatureOfAppealEntity, MNatureOfAppeal>(criminalInfoEntity.MNatureOfAppeal);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalInfo", ex);
                throw;
            }

            return criminalInfo;
        }

        /// <summary>
        /// Gets the <see cref="CriminalOtherOrderInfo"/> from <see cref="CriminalOtherOrderInfoEntity"/> input.
        /// </summary>
        /// <param name="CriminalOtherOrderInfoEntity"><see cref="CriminalOtherOrderInfoEntity"/></param>
        /// <returns>Returns <see cref="CriminalOtherOrderInfo"/>, else null.</returns>
        public static CriminalOtherOrderInfo GetCriminalOtherOrderInfo(CriminalOtherOrderInfoEntity criminalOtherOrderInfoEntity)
        {
            CriminalOtherOrderInfo criminalOtherOrderInfo = null;

            try
            {
                if (criminalOtherOrderInfoEntity != null)
                {
                    criminalOtherOrderInfo = Mapper.Map<CriminalOtherOrderInfoEntity, CriminalOtherOrderInfo>(criminalOtherOrderInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalOtherOrderInfo", ex);
                throw;
            }

            return criminalOtherOrderInfo;
        }

        /// <summary>
        /// Gets the <see cref="CWUInfo"/> from <see cref="CWUInfoEntity"/> input.
        /// </summary>
        /// <param name="cWUInfoEntity"><see cref="CWUInfoEntity"/></param>
        /// <returns>Returns <see cref="CWUInfo"/>, else null.</returns>
        public static CWUChecklistInfo GetCWUChecklistInfo(CWUCheckListInfoEntity cWUCheckListInfoEntity)
        {
            CWUChecklistInfo cWUChecklistInfo = null;

            try
            {
                if (cWUCheckListInfoEntity != null)
                {
                    cWUChecklistInfo = Mapper.Map<CWUCheckListInfoEntity, CWUChecklistInfo>(cWUCheckListInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCWUChecklistInfo", ex);
                throw;
            }

            return cWUChecklistInfo;
        }

        /// <summary>
        /// Gets the <see cref="CWUInfo"/> from <see cref="CWUInfoEntity"/> input.
        /// </summary>
        /// <param name="cWUInfoEntity"><see cref="CWUInfoEntity"/></param>
        /// <returns>Returns <see cref="CWUInfo"/>, else null.</returns>
        public static CWUInfo GetCWUInfo(CWUInfoEntity cWUInfoEntity)
        {
            CWUInfo cWUInfo = null;

            try
            {

                cWUInfo = Mapper.Map<CWUInfoEntity, CWUInfo>(cWUInfoEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCWUInfo", ex);
                throw;
            }

            return cWUInfo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="admInfoDomainEntity"></param>
        /// <returns></returns>
        public static DCACAInfo GetDCACAInfo(DCACAInfoEntity dcacaInfoDomainEntity)
        {
            DCACAInfo dcacaInfoNHibernateEntity = null;

            try
            {
                //appealMapping.MapDCACAInfoToDCACAInfoEntity();
                dcacaInfoNHibernateEntity = Mapper.Map<DCACAInfoEntity, DCACAInfo>(dcacaInfoDomainEntity);
                dcacaInfoNHibernateEntity.MDesignation = Mapper.Map<MDesignationEntity, MDesignation>(dcacaInfoDomainEntity.MDesignation);
                dcacaInfoNHibernateEntity.MCoram = Mapper.Map<MCoramEntity, MCoram>(dcacaInfoDomainEntity.MCoram);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDCACAInfo", ex);
                throw;
            }

            return dcacaInfoNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="DrugInfo"/> from <see cref="DrugInfoEntity"/> input.
        /// </summary>
        /// <param name="drugInfoEntity"><see cref="DrugInfoEntity"/></param>
        /// <returns>Returns <see cref="DrugInfo"/>, else null.</returns>
        public static DrugInfo GetDrugInfo(DrugInfoEntity drugInfoEntity)
        {
            DrugInfo drugInfo = null;

            try
            {
                if (drugInfoEntity != null)
                {
                    drugInfo = Mapper.Map<DrugInfoEntity, DrugInfo>(drugInfoEntity);
                    drugInfo.MDrug = Mapper.Map<MDrugEntity, MDrug>(drugInfoEntity.MDrug);
                    drugInfo.MModeOfTrafficking = Mapper.Map<MModeOfTraffickingEntity, MModeOfTrafficking>(drugInfoEntity.MModeOfTrafficking);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDrugInfo", ex);
                throw;
            }

            return drugInfo;
        }

        /// <summary>
        /// Gets the <see cref="InvestigatingOfficerInfo"/> from <see cref="InvestigatingOfficerInfoEntity"/> input.
        /// </summary>
        /// <param name="InvestigatingOfficerInfoEntity"><see cref="InvestigatingOfficerInfoEntity"/></param>
        /// <returns>Returns <see cref="InvestigatingOfficerInfo"/>, else null.</returns>
        public static InvestigatingOfficerInfo GetInvestigatingOfficerInfo(InvestigatingOfficerInfoEntity investigatingOfficerInfoEntity)
        {
            InvestigatingOfficerInfo investigatingOfficerInfo = null;

            try
            {
                if (investigatingOfficerInfoEntity != null)
                {
                    investigatingOfficerInfo = Mapper.Map<InvestigatingOfficerInfoEntity, InvestigatingOfficerInfo>(investigatingOfficerInfoEntity);
                    investigatingOfficerInfo.MIOOrganisation = Mapper.Map<MIOOrganisationEntity, MIOOrganisation>(investigatingOfficerInfoEntity.MIOOrganisation);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetInvestigatingOfficerInfo", ex);
                throw;
            }

            return investigatingOfficerInfo;
        }

        /// <summary>
        /// Gets the <see cref="OffenceInfo"/> from <see cref="OffenceInfoEntity"/> input.
        /// </summary>
        /// <param name="offenceInfoEntity"><see cref="OffenceInfoEntity"/></param>
        /// <returns>Returns <see cref="OffenceInfo"/>, else null.</returns>
        public static OffenceInfo GetOffenceInfo(OffenceInfoEntity offenceInfoEntity)
        {
            OffenceInfo offenceInfo = null;

            try
            {
                if (offenceInfoEntity != null)
                {
                    offenceInfo = Mapper.Map<OffenceInfoEntity, OffenceInfo>(offenceInfoEntity);
                    offenceInfo.MNatureOfOffence = Mapper.Map<MNatureOfOffenceEntity, MNatureOfOffence>(offenceInfoEntity.MNatureOfOffence);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetOffenceInfo", ex);
                throw;
            }

            return offenceInfo;
        }

        /// <summary>
        /// Gets the <see cref="OSInfo"/> from <see cref="OSInfoEntity"/> input.
        /// </summary>
        /// <param name="OSInfoEntity"><see cref="OSInfoEntity"/></param>
        /// <returns>Returns <see cref="OSInfo"/>, else null.</returns>
        public static OSInfo GetOSInfo(OSInfoEntity oSInfoEntity)
        {
            OSInfo oSInfo = null;

            try
            {
                if (oSInfoEntity != null)
                {
                    oSInfo = Mapper.Map<OSInfoEntity, OSInfo>(oSInfoEntity);
                    oSInfo.MCountry = Mapper.Map<MCountryEntity, MCountry>(oSInfoEntity.CountryOfIssue);
                    oSInfo.MNatureOfDeputyShip = Mapper.Map<MNatureofDeputyshipEntity, MNatureOfDeputyShip>(oSInfoEntity.NatureOfDeputyShip);
                    oSInfo.MEntityType = Mapper.Map<MEntityTypeEntity, MEntityType>(oSInfoEntity.CompanyRegType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetOSInfo", ex);
                throw;
            }

            return oSInfo;
        }

        /// <summary>
        /// Gets the <see cref="OSJudicialManagerDetails"/>
        /// </summary>
        /// <param name="oSJudicialManagerDetailsEntity">The OSJudicialManagerDetailsEntity.</param>
        /// <returns></returns>
        public static OSJudicialManagerDetails GetOSJudicialManagerDetails(OSJudicialManagerDetailsEntity oSJudicialManagerDetailsEntity)
        {
            OSJudicialManagerDetails oSJudicialManagerDetails = null;
            try
            {
                oSJudicialManagerDetails = Mapper.Map<OSJudicialManagerDetailsEntity, OSJudicialManagerDetails>(oSJudicialManagerDetailsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOSJudicialManagerDetails", ex);
                throw;
            }
            return oSJudicialManagerDetails;
        }

        /// <summary>
        /// Gets the <see cref="OSJudicialManagerDetails"/>
        /// </summary>
        /// <param name="oSJudicialManagerDetailsEntity">The OSJudicialManagerDetailsEntity.</param>
        /// <returns></returns>
        public static OSMADetails GetOSMADetails(OSMADetailsEntity oSMADetailsEntity)
        {
            OSMADetails oSMADetails = null;
            try
            {
                oSMADetails = Mapper.Map<OSMADetailsEntity, OSMADetails>(oSMADetailsEntity);
                oSMADetails.MCountry = Mapper.Map<MCountryEntity, MCountry>(oSMADetailsEntity.MCountry);
                oSMADetails.MPropertyType = Mapper.Map<MPropertyTypeEntity, MPropertyType>(oSMADetailsEntity.MPropertyType);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOSMADetails", ex);
                throw;
            }
            return oSMADetails;
        }

        /// <summary>
        /// Gets the <see cref="PBBeneficiaryDetails"/>
        /// </summary>
        /// <param name="pBBeneficiaryDetailEntity">The PBBeneficiaryDetailEntity.</param>
        /// <returns></returns>
        public static PBBeneficiaryDetails GetPBBeneficiaryDetails(PBBeneficiaryDetailEntity pBBeneficiaryDetailEntity)
        {
            PBBeneficiaryDetails pBBeneficiaryDetails = null;
            try
            {
                pBBeneficiaryDetails = Mapper.Map<PBBeneficiaryDetailEntity, PBBeneficiaryDetails>(pBBeneficiaryDetailEntity);
                pBBeneficiaryDetails.MGender = Mapper.Map<MGenderEntity, MGender>(pBBeneficiaryDetailEntity.MGender);
                pBBeneficiaryDetails.MRelationship = Mapper.Map<MRelationshipEntity, MRelationship>(pBBeneficiaryDetailEntity.MRelationship);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPBBeneficiaryDetails", ex);
                throw;
            }
            return pBBeneficiaryDetails;
        }

        /// <summary>
        /// Gets the <see cref="PBCoAdminDetails"/>
        /// </summary>
        /// <param name="pBCoAdminDetailEntity">The PBCoAdminDetailEntity.</param>
        /// <returns></returns>
        public static PBCoAdminDetails GetPBCoAdminDetails(PBCoAdminDetailEntity pBCoAdminDetailEntity)
        {
            PBCoAdminDetails pBCoAdminDetails = null;
            try
            {
                pBCoAdminDetails = Mapper.Map<PBCoAdminDetailEntity, PBCoAdminDetails>(pBCoAdminDetailEntity);
                pBCoAdminDetails.MCountry = Mapper.Map<MCountryEntity, MCountry>(pBCoAdminDetailEntity.MCountry);
                pBCoAdminDetails.MGender = Mapper.Map<MGenderEntity, MGender>(pBCoAdminDetailEntity.MGender);
                pBCoAdminDetails.MPersonIDGroup = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(pBCoAdminDetailEntity.MPersonIDGroup);
                pBCoAdminDetails.MPersonIDType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(pBCoAdminDetailEntity.MPersonIDType);
                pBCoAdminDetails.MRelationship = Mapper.Map<MRelationshipEntity, MRelationship>(pBCoAdminDetailEntity.MRelationship);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPBCoAdminDetails", ex);
                throw;
            }
            return pBCoAdminDetails;
        }

        /// <summary>
        /// Gets the <see cref="PBExecutorDetails"/>
        /// </summary>
        /// <param name="pBExecutorDetailEntity">The PBExecutorDetailEntity.</param>
        /// <returns></returns>
        public static PBExecutorDetails GetPBExecutorDetail(PBExecutorDetailEntity pBExecutorDetailEntity)
        {
            PBExecutorDetails pBExecutorDetails = null;
            try
            {
                pBExecutorDetails = Mapper.Map<PBExecutorDetailEntity, PBExecutorDetails>(pBExecutorDetailEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPBExecutorDetail", ex);
                throw;
            }
            return pBExecutorDetails;
        }

        /// <summary>
        /// Gets the <see cref="PBPrevGrantDetails"/>
        /// </summary>
        /// <param name="pBPrevGrantDetailEntity">The PBPrevGrantDetailEntity.</param>
        /// <returns></returns>
        public static PBPrevGrantDetails GetPBPrevGrantDetails(PBPrevGrantDetailEntity pBPrevGrantDetailEntity)
        {
            PBPrevGrantDetails pBPrevGrantDetail = null;
            try
            {
                pBPrevGrantDetail = Mapper.Map<PBPrevGrantDetailEntity, PBPrevGrantDetails>(pBPrevGrantDetailEntity);
                pBPrevGrantDetail.MCourtType = Mapper.Map<MCourtTypeEntity, MCourtType>(pBPrevGrantDetailEntity.MCourtType);
                pBPrevGrantDetail.MGender = Mapper.Map<MGenderEntity, MGender>(pBPrevGrantDetailEntity.MGender);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPBPrevGrantDetails", ex);
                throw;
            }
            return pBPrevGrantDetail;
        }

        /// <summary>
        /// Gets the <see cref="PBWillCodicil"/>
        /// </summary>
        /// <param name="pBWillCodicilEntity">The PBWillCodicilEntity.</param>
        /// <returns></returns>
        public static PBWillCodicil GetPBWillCodicil(PBWillCodicilEntity pBWillCodicilEntity)
        {
            PBWillCodicil pBWillCodicil = null;
            try
            {
                pBWillCodicil = Mapper.Map<PBWillCodicilEntity, PBWillCodicil>(pBWillCodicilEntity);
                pBWillCodicil.MDocCode = Mapper.Map<MDocCodeEntity, MDocCode>(pBWillCodicilEntity.MDocCode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPBWillCodicil", ex);
                throw;
            }
            return pBWillCodicil;
        }

        /// <summary>
        /// Gets the <see cref="PracticeOfLawInfo"/>
        /// </summary>
        /// <param name="practiceOfLawInfoEntity">The PracticeOfLawInfoEntity.</param>
        /// <returns></returns>
        public static PracticeOfLawInfo GetPracticeOfLawInfo(PracticeOfLawInfoEntity practiceOfLawInfoEntity)
        {
            PracticeOfLawInfo practiceOfLawInfo = null;
            try
            {
                practiceOfLawInfo = Mapper.Map<PracticeOfLawInfoEntity, PracticeOfLawInfo>(practiceOfLawInfoEntity);
                practiceOfLawInfo.MCountry = Mapper.Map<MCountryEntity, MCountry>(practiceOfLawInfoEntity.MCountry);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPracticeOfLawInfo", ex);
                throw;
            }
            return practiceOfLawInfo;
        }

        /// <summary>
        /// Gets the <see cref="PracticeTrainingPeriodInfo"/>
        /// </summary>
        /// <param name="practiceTrainingPeriodInfoEntity">The PracticeTrainingPeriodInfoEntity.</param>
        /// <returns></returns>
        public static PracticeTrainingPeriodInfo GetPracticeTrainingPeriodInfo(PracticeTrainingPeriodInfoEntity practiceTrainingPeriodInfoEntity)
        {
            PracticeTrainingPeriodInfo practiceTrainingPeriodInfo = null;
            try
            {
                practiceTrainingPeriodInfo = Mapper.Map<PracticeTrainingPeriodInfoEntity, PracticeTrainingPeriodInfo>(practiceTrainingPeriodInfoEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPracticeTrainingPeriodInfo", ex);
                throw;
            }
            return practiceTrainingPeriodInfo;
        }

        /// <summary>
        /// Gets the <see cref="ProbateInfo"/>
        /// </summary>
        /// <param name="probateInfoEntity">The ProbateInfoEntity.</param>
        /// <returns></returns>
        public static ProbateInfo GetProbateInfo(ProbateInfoEntity probateInfoEntity)
        {
            ProbateInfo probateInfo = null;
            try
            {
                probateInfo = Mapper.Map<ProbateInfoEntity, ProbateInfo>(probateInfoEntity);
                probateInfo.MCountry = Mapper.Map<MCountryEntity, MCountry>(probateInfoEntity.MCountry);
                probateInfo.MProbateNature = Mapper.Map<MProbateNatureEntity, MProbateNature>(probateInfoEntity.MProbateNature);
                probateInfo.MProbateNatureGroup = Mapper.Map<MProbateNatureGroupEntity, MProbateNatureGroup>(probateInfoEntity.MProbateNatureGroup);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetProbateInfo", ex);
                throw;
            }
            return probateInfo;
        }

        /// <summary>
        /// Gets the <see cref="RCriminalLegislationInfo"/> from <see cref="RCriminalLegislationInfoEntity"/> input.
        /// </summary>
        /// <param name="RCriminalLegislationInfoEntity"><see cref="RCriminalLegislationInfoEntity"/></param>
        /// <returns>Returns <see cref="RCriminalLegislationInfo"/>, else null.</returns>
        public static RCriminalLegislationInfo GetRCriminalLegislationInfo(RCriminalLegislationInfoEntity rCriminalLegislationInfoEntity)
        {
            RCriminalLegislationInfo rCriminalLegislationInfo = null;

            try
            {
                if (rCriminalLegislationInfoEntity != null)
                {
                    rCriminalLegislationInfo = Mapper.Map<RCriminalLegislationInfoEntity, RCriminalLegislationInfo>(rCriminalLegislationInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRCriminalLegislationInfo", ex);
                throw;
            }

            return rCriminalLegislationInfo;
        }

        /// <summary>
        /// Get Ref Caveat Case.
        /// </summary>
        /// <param name="refCaveatCaseDomainEntity"></param>
        /// <returns></returns>
        public static RefCaveatCase GetRefCaveatCase(RefCaveatCaseEntity refCaveatCaseDomainEntity)
        {
            RefCaveatCase refCaveatCaseNHibernateEntity = null;

            try
            {
                //admiralityMapping.MapRefCaveatCaseToRefCaveatCaseEntity();
                refCaveatCaseNHibernateEntity = Mapper.Map<RefCaveatCaseEntity, RefCaveatCase>(refCaveatCaseDomainEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRefCaveatCase", ex);
                throw;
            }

            return refCaveatCaseNHibernateEntity;
        }

        public static SentenceCriminalOrderInfo GetSentenceCriminalOrderInfo(SentenceCriminalOrderInfoEntity sentenceCriminalOrderInfoEntity)
        {
            SentenceCriminalOrderInfo sentenceCriminalOrderInfo = null;
            try
            {
                sentenceCriminalOrderInfo = Mapper.Map<SentenceCriminalOrderInfoEntity, SentenceCriminalOrderInfo>(sentenceCriminalOrderInfoEntity);
                sentenceCriminalOrderInfo.MCriminalOrder = Mapper.Map<MCriminalOrderEntity, MCriminalOrder>(sentenceCriminalOrderInfoEntity.MCriminalOrder);
                sentenceCriminalOrderInfo.MSentence = Mapper.Map<MSentenceEntity, MSentence>(sentenceCriminalOrderInfoEntity.MSentence);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSentenceCriminalOrderInfo", ex);
                throw;
            }
            return sentenceCriminalOrderInfo;
        }

        /// <summary>
        /// Gets the <see cref="SentenceInfo"/> from <see cref="SentenceInfoEntity"/> input.
        /// </summary>
        /// <param name="sentenceInfoEntity"><see cref="SentenceInfoEntity"/></param>
        /// <returns>Returns <see cref="SentenceInfo"/>, else null.</returns>
        public static SentenceInfo GetSentenceInfo(SentenceInfoEntity sentenceInfoEntity)
        {
            SentenceInfo sentenceInfo = null;

            try
            {
                if (sentenceInfoEntity != null)
                {
                    sentenceInfo = Mapper.Map<SentenceInfoEntity, SentenceInfo>(sentenceInfoEntity);
                    sentenceInfo.MDrivingLicense = Mapper.Map<MDrivingLicenseEntity, MDrivingLicense>(sentenceInfoEntity.MDrivingLicense);
                    sentenceInfo.MCriminalOrder = Mapper.Map<MCriminalOrderEntity, MCriminalOrder>(sentenceInfoEntity.MCriminalOrder);
                    sentenceInfo.MSentence = Mapper.Map<MSentenceEntity, MSentence>(sentenceInfoEntity.MSentence);
                    sentenceInfo.MCourtType = Mapper.Map<MCourtTypeEntity, MCourtType>(sentenceInfoEntity.MCourtType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSentenceInfo", ex);
                throw;
            }

            return sentenceInfo;
        }

        /// <summary>
        /// Gets the <see cref="TaxationClaim"/>
        /// </summary>
        /// <param name="taxationClaimEntity">The TaxationClaimEntity.</param>
        /// <returns></returns>
        public static TaxationClaim GetTaxationClaim(TaxationClaimEntity taxationClaimEntity)
        {
            TaxationClaim taxationClaim = null;
            try
            {
                taxationClaim = Mapper.Map<TaxationClaimEntity, TaxationClaim>(taxationClaimEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetTaxationClaim", ex);
                throw;
            }
            return taxationClaim;
        }

        /// <summary>
        /// Gets the <see cref="BOTDetails"/>
        /// </summary>
        /// <param name="bOTDetailEntity">The BOTDetailEntity.</param>
        /// <returns></returns>
        public static TaxationInfo GetTaxationInfo(TaxationInfoEntity taxationInfoEntity)
        {
            TaxationInfo taxationInfo = null;
            try
            {
                taxationInfo = Mapper.Map<TaxationInfoEntity, TaxationInfo>(taxationInfoEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetTaxationInfo", ex);
                throw;
            }
            return taxationInfo;
        }

        /// <summary>
        /// Gets the <see cref="WOEMOMSCTInfo"/>
        /// </summary>
        /// <param name="woeMOMSCTInfoEntity">The WOEMOMSCTInfoEntity.</param>
        /// <returns></returns>
        public static WOEMOMSCTInfo GetWOEMOMSCTInfo(WOEMOMSCTInfoEntity woeMOMSCTInfoEntity)
        {
            WOEMOMSCTInfo woeMOMSCTInfo = null;
            try
            {
                woeMOMSCTInfo = Mapper.Map<WOEMOMSCTInfoEntity, WOEMOMSCTInfo>(woeMOMSCTInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOEMOMSCTInfo", ex);
                throw;
            }
            return woeMOMSCTInfo;
        }

        /// <summary>
        /// Gets the <see cref="WOSInfo"/>
        /// </summary>
        /// <param name="wOSInfoEntity">The WOSInfoEntity.</param>
        /// <returns></returns>
        public static WOSInfo GetWOSInfo(WOSInfoEntity wOSInfoEntity)
        {
            WOSInfo wOSInfo = null;
            try
            {
                wOSInfo = Mapper.Map<WOSInfoEntity, WOSInfo>(wOSInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOSInfo", ex);
                throw;
            }
            return wOSInfo;
        }

        public static DCACAOriginatingCasePartyInfo GetDCACAOriginatingCasePartyInfo(DCACAOriginatingCasePartyInfoEntity dCACAOriginatingCasePartyInfoEntity)
        {
            DCACAOriginatingCasePartyInfo dCACAOriginatingCasePartyInfo = null;
            try
            {
                dCACAOriginatingCasePartyInfo = Mapper.Map<DCACAOriginatingCasePartyInfoEntity, DCACAOriginatingCasePartyInfo>(dCACAOriginatingCasePartyInfoEntity);
                dCACAOriginatingCasePartyInfo.MPartyType = Mapper.Map<MPartyTypeEntity, MPartyType>(dCACAOriginatingCasePartyInfoEntity.MPartyType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDCACAOriginatingCasePartyInfo", ex);
                throw;
            }
            return dCACAOriginatingCasePartyInfo;
        }

        /// <summary>
        /// Gets the <see cref="RARASInfo"/> from <see cref="RARASInfoEntity"/> input.
        /// </summary>
        /// <param name="rARASInfoEntity"><see cref="RARASInfoEntity"/></param>
        /// <returns>Returns <see cref="RARASInfo"/>, else null.</returns>
        public static RASInfo GetRASInfo(RASInfoEntity rASInfoEntity)
        {
            RASInfo rASInfo = null;

            try
            {
                if (rASInfoEntity != null)
                {
                    rASInfo = Mapper.Map<RASInfoEntity, RASInfo>(rASInfoEntity);
                    rASInfo.MDesignation = Mapper.Map<MDesignationEntity, MDesignation>(rASInfoEntity.MDesignation);
                    rASInfo.MCoram = Mapper.Map<MCoramEntity, MCoram>(rASInfoEntity.MCoram);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRARASInfo", ex);
                throw;
            }

            return rASInfo;
        }

        /// <summary>
        /// Gets the bankruptcy debt info.
        /// </summary>
        /// <param name="bankruptcyDebtInfoEntity">The bankruptcy debt info entity.</param>
        /// <returns></returns>
        public static BankruptcyDebtInfo GetBankruptcyDebtInfo(BankruptcyDebtInfoEntity bankruptcyDebtInfoEntity)
        {
            BankruptcyDebtInfo bankruptcyDebtInfo = null;
            try
            {
                if (bankruptcyDebtInfoEntity != null)
                {
                    bankruptcyDebtInfo = Mapper.Map<BankruptcyDebtInfoEntity, BankruptcyDebtInfo>(bankruptcyDebtInfoEntity);
                    bankruptcyDebtInfo.MCurrency = Mapper.Map<MCurrencyEntity, MCurrency>(bankruptcyDebtInfoEntity.BKYDebtCurrencyCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBankruptcyDebtInfo", ex);
                throw;
            }
            return bankruptcyDebtInfo;
        }

        public static PBPADetails GetPBPADetails(PBPADetailEntity pBPADetailEntity)
        {
            PBPADetails pBPADetails = null;
            try
            {
                if (pBPADetailEntity != null)
                {
                    pBPADetails = Mapper.Map<PBPADetailEntity, PBPADetails>(pBPADetailEntity);
                    pBPADetails.MGender = Mapper.Map<MGenderEntity, MGender>(pBPADetailEntity.MGenderEntity);
                    pBPADetails.MApplicantCapacity = Mapper.Map<MApplicantCapacityEntity, MApplicantCapacity>(pBPADetailEntity.MApplicantCapacityEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPBPADetails", ex);
                throw;
            }
            return pBPADetails;
        }

        public static PBSupNExm GetPBSupNExm(PBSupNExmEntity pBSupNExmEntity)
        {
            PBSupNExm pBSupNExm = null;
            try
            {
                if (pBSupNExmEntity != null)
                {
                    pBSupNExm = Mapper.Map<PBSupNExmEntity, PBSupNExm>(pBSupNExmEntity);
                    
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPBSupNExm", ex);
                throw;
            }
            return pBSupNExm;
        }

        public static PBAdminBond GetPBAdminBond(PBAdminBondEntity PBAdminBondEntity)
        {
            PBAdminBond PBAdminBond = null;
            try
            {
                if (PBAdminBondEntity != null)
                {
                    PBAdminBond = Mapper.Map<PBAdminBondEntity, PBAdminBond>(PBAdminBondEntity);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPBAdminBond", ex);
                throw;
            }
            return PBAdminBond;
        }

        public static CaseRegister GetCaseRegister(CaseRegisterEntity caseRegisterEntity)
        {
            CaseRegister caseRegister = null;
            try
            {
                if (caseRegisterEntity != null)
                {
                    caseRegister = Mapper.Map<CaseRegisterEntity, CaseRegister>(caseRegisterEntity);
                    caseRegister.MForumType = Mapper.Map<MForumTypeEntity, MForumType>(caseRegisterEntity.MForumTypeEntity);
                    caseRegister.MPartyStatus = Mapper.Map<MPartyStatusEntity, MPartyStatus>(caseRegisterEntity.MPartyStatusEntity);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseRegister", ex);
                throw;
            }
            return caseRegister;
        }

        public static CaseRegisterHistory GetCaseRegisterHistory(CaseRegisterHistoryEntity caseRegisterHistoryEntity)
        {
            CaseRegisterHistory caseRegisterHistory = null;
            try
            {
                if (caseRegisterHistoryEntity != null)
                {
                    caseRegisterHistory = Mapper.Map<CaseRegisterHistoryEntity, CaseRegisterHistory>(caseRegisterHistoryEntity);
                    caseRegisterHistory.MForumType = Mapper.Map<MForumTypeEntity, MForumType>(caseRegisterHistoryEntity.MForumTypeEntity);
                    caseRegisterHistory.MPartyStatus = Mapper.Map<MPartyStatusEntity, MPartyStatus>(caseRegisterHistoryEntity.MPartyStatusEntity);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseRegisterHistory", ex);
                throw;
            }
            return caseRegisterHistory;
        }

        public static DashboardCaseMilestoneDetail GetDashboardCaseMilestoneDetail(DashboardCaseMilestoneDetailEntity dashboardCaseMilestoneDetailEntity)
        {
            DashboardCaseMilestoneDetail dashboardCaseMilestoneDetail = null;
            try
            {
                if (dashboardCaseMilestoneDetailEntity != null)
                {
                    dashboardCaseMilestoneDetail = Mapper.Map<DashboardCaseMilestoneDetailEntity, DashboardCaseMilestoneDetail>(dashboardCaseMilestoneDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDashboardCaseMilestoneDetail", ex);
                throw;
            }
            return dashboardCaseMilestoneDetail;
        }

        public static DashboardCaseMilestoneDetailHistory GetDashboardCaseMilestoneDetailHistory(DashboardCaseMilestoneDetailHistoryEntity dashboardCaseMilestoneDetailHistoryEntity)
        {
            DashboardCaseMilestoneDetailHistory dashboardCaseMilestoneDetailHistory = null;
            try
            {
                if (dashboardCaseMilestoneDetailHistoryEntity != null)
                {
                    dashboardCaseMilestoneDetailHistory = Mapper.Map<DashboardCaseMilestoneDetailHistoryEntity, DashboardCaseMilestoneDetailHistory>(dashboardCaseMilestoneDetailHistoryEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDashboardCaseMilestoneDetailHistory", ex);
                throw;
            }
            return dashboardCaseMilestoneDetailHistory;
        }

        public static CaveatInfo GetCaveatInfo(CaveatInfoEntity caveatInfoEntity)
        {
            CaveatInfo caveatInfo = null;
            try
            {
                if (caveatInfoEntity != null)
                {
                    caveatInfo = Mapper.Map<CaveatInfoEntity, CaveatInfo>(caveatInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaveatInfo", ex);
                throw;
            }
            return caveatInfo;
        }

        public static JMChecklistInfo GetJMChecklistInfo(JMChecklistInfoEntity jMChecklistInfoEntity)
        {
            JMChecklistInfo jMChecklistInfo = null;

            try
            {
                jMChecklistInfo = Mapper.Map<JMChecklistInfoEntity, JMChecklistInfo>(jMChecklistInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at JMChecklistInfo", ex);
                throw;
            }

            return jMChecklistInfo;
        }

        public static JMOtherInfo GetJMOtherInfo(JMOtherInfoEntity jMOtherInfoEntity)
        {
            JMOtherInfo jMOtherInfo = null;

            try
            {
                jMOtherInfo = Mapper.Map<JMOtherInfoEntity, JMOtherInfo>(jMOtherInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at JMOtherInfo", ex);
                throw;
            }

            return jMOtherInfo;
        }

        public static DirectionDetails GetDirectionDetails(DirectionDetailsEntity directionDetailsEntity)
        {
            DirectionDetails directionDetails = null;

            try
            {
                directionDetails = Mapper.Map<DirectionDetailsEntity, DirectionDetails>(directionDetailsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GETdirectionDetails", ex);
                throw;
            }

            return directionDetails;
        }

        #endregion Methods
    }
}