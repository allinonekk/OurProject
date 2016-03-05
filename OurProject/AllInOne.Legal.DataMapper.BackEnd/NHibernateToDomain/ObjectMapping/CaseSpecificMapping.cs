#region Header

/*****************************************************************************************************
* Description : This file handles mapping for CaseSpecific from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   14/01/2011   		        Nithin                 Created
*
*****************************************************************************************************/
// <summary>
// File: CaseSpecificMapping.cs
// Description: This file handles mapping for CaseSpecific from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "CaseSpecificMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for CaseSpecific from NHibernate entities to Domain objects.
    /// </summary>
    internal class CaseSpecificMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CaseSpecificMapping));

        #endregion Fields

        #region Methods

        /**End of Criminal Mapping**/
        internal void MapAASInfoToAASInfoEntity()
        {
            try
            {
                Mapper.CreateMap<AASInfo, AASInfoEntity>()
                    .ForMember(dest => dest.IsMLawExemptionApproved, opts => opts.MapFrom(src => src.IsMLawExemptionApproved))
                    .ForMember(dest => dest.LPALPRSectionType, opts => opts.MapFrom(src => src.LPALPRSectionType));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAASInfoToAASInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ADMInfo"/> to <see cref="ADMInfoEntity"/>.
        /// </summary>
        internal void MapADMInfoToADMInfoEntity()
        {
            try
            {
                Mapper.CreateMap<ADMInfo, ADMInfoEntity>()
                .ForMember(dest => dest.ADMInfoId, opts => opts.MapFrom(src => src.ADMInfoId))
                .ForMember(dest => dest.AdmiraltyWritType, opts => opts.MapFrom(src => src.AdmiraltyWritType))
                .ForMember(dest => dest.AttachmentType, opts => opts.MapFrom(src => src.AttachmentType))
                .ForMember(dest => dest.CaveatSearchDateTime, opts => opts.MapFrom(src => src.CaveatSearchDateTime))
                .ForMember(dest => dest.CaveatSearchResult, opts => opts.MapFrom(src => src.CaveatSearchResult))
                .ForMember(dest => dest.IsInjunctionFiled, opts => opts.MapFrom(src => src.IsInjunctionFiled))
                .ForMember(dest => dest.IsManagedEWT, opts => opts.MapFrom(src => src.IsManagedEWT))
                .ForMember(dest => dest.IsPartnerInFirm, opts => opts.MapFrom(src => src.IsPartnerInFirm))
                .ForMember(dest => dest.IsServeOutJDC, opts => opts.MapFrom(src => src.IsServeOutJDC))
                .ForMember(dest => dest.IsWOARequired, opts => opts.MapFrom(src => src.IsWOARequired))
                .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(SRC => SRC.LastModifiedBy))
                .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                .ForMember(dest => dest.TotalLIQAwardedAmount, opts => opts.MapFrom(src => src.TotalLIQAwardedAmount))
                .ForMember(dest => dest.TotalLIQClaimAmount, opts => opts.MapFrom(src => src.TotalLIQClaimAmount))
                .ForMember(dest => dest.TotalUnLIQESTAmount, opts => opts.MapFrom(src => src.TotalUnLIQESTAmount))
                .ForMember(dest => dest.TotalUnLIQAwardedAmount, opts => opts.MapFrom(src => src.TotlaUnLIQAwardedAmount));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapADMInfoToADMInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="BankruptcyInfo"/> to <see cref="BankruptcyInfoEntity"/>.
        /// </summary>
        internal void MapBankruptcyInfoToBankruptcyInfoEntity()
        {
            try
            {
                Mapper.CreateMap<BankruptcyInfo, BankruptcyInfoEntity>()
                    .ForMember(dest => dest.DeathFromDate, opts => opts.MapFrom(src => src.DeathFromDate))
                    .ForMember(dest => dest.DeathToDate, opts => opts.MapFrom(src => src.DeathToDate))
                    .ForMember(dest => dest.ExecutionCompDate, opts => opts.MapFrom(src => src.ExecutionCompDate))
                    .ForMember(dest => dest.IsAnotherDefField, opts => opts.MapFrom(src => src.IsAnotherDefField))
                    .ForMember(dest => dest.IsServiceOutJur, opts => opts.MapFrom(src => src.IsServiceOutJur))
                    .ForMember(dest => dest.IsAnotherBAFiled, opts => opts.MapFrom(src => src.IsAnotherBAFiled))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.ProbateCaseNo, opts => opts.MapFrom(src => src.ProbateCaseNo))
                    .ForMember(dest => dest.RevCertIssueDate, opts => opts.MapFrom(src => src.RevCertIssueDate))
                    .ForMember(dest => dest.StatuaryDemandDate, opts => opts.MapFrom(src => src.StatuaryDemandDate))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.TotalDebt, opts => opts.MapFrom(src => src.TotalDebt))
                    .ForMember(dest => dest.TotalDebtInSGD, opts => opts.MapFrom(src => src.TotalDebtinSGD));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapBankruptcyInfoToBankruptcyInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="BankruptcyOtherDefDetail"/> to <see cref="BankruptcyOtherDefDetailEntity"/>.
        /// </summary>
        internal void MapBankruptcyOtherDefDetailToBankruptcyOtherDefDetailEntity()
        {
            try
            {
                Mapper.CreateMap<BankruptcyOtherDefDetail, BankruptcyOtherDefDetailEntity>()
                    .ForMember(dest => dest.CompanyName, opts => opts.MapFrom(src => src.CompanyName))
                    .ForMember(dest => dest.DateOfRegistration, opts => opts.MapFrom(src => src.DateOfRegistration))
                    .ForMember(dest => dest.FullName, opts => opts.MapFrom(src => src.FullName))
                    .ForMember(dest => dest.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(dest => dest.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MCompanyIdType, opts => opts.MapFrom(src => src.MBODDCompanyIdType))
                    .ForMember(dest => dest.MCountryOfRegistration, opts => opts.MapFrom(src => src.MBODDCountryOfRegistration))
                    .ForMember(dest => dest.MEntityType, opts => opts.MapFrom(src => src.MEntityType))
                    .ForMember(dest => dest.MIdCountry, opts => opts.MapFrom(src => src.MBODDIdCountry))
                    .ForMember(dest => dest.MPersonIdGroup, opts => opts.MapFrom(src => src.MPersonIDGroup))
                    .ForMember(dest => dest.MPersonIdType, opts => opts.MapFrom(src => src.MBODDPersonIdType))
                    .ForMember(dest => dest.OtherDefendantId, opts => opts.MapFrom(src => src.OtherDefendantId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.UEN, opts => opts.MapFrom(src => src.UEN));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapBankruptcyOtherDefDetailToBankruptcyOtherDefDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="BillOfSaleInfo"/> to <see cref="BillOfSaleInfoEntity"/>.
        /// </summary>
        internal void MapBillOfSaleInfoToBillOfSaleInfoEntity()
        {
            try
            {
                Mapper.CreateMap<BillOfSaleInfo, BillOfSaleInfoEntity>()
                    .ForMember(desc => desc.BillOfSaleInfoId, opts => opts.MapFrom(src => src.BillOfSaleInfoId))
                    .ForMember(desc => desc.InstrumentDate, opts => opts.MapFrom(src => src.InstrumentDate))
                    .ForMember(desc => desc.InstrumentName, opts => opts.MapFrom(src => src.InstrumentName))
                    .ForMember(desc => desc.IsAbsoluteBillOfSale, opts => opts.MapFrom(src => src.IsAbsoluteBillOfSale))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBillOfSaleInfoToBillOfSaleInfoEntity", ex);
                throw;
            }
        }

        internal void MapBOTDetailToBOTDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<BOTDetails, BOTDetailEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBOTDetailToBOTDetailsEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ChargeInfo"/> to <see cref="ChargeInfoEntity"/>.
        /// </summary>
        internal void MapChargeInfoToChargeInfoEntity()
        {
            try
            {
                Mapper.CreateMap<ChargeInfo, ChargeInfoEntity>()
                    .ForMember(desc => desc.PIChargeInd, opts => opts.MapFrom(src => src.PIChargeInd))
                    .ForMember(desc => desc.CoronerNoticeInd, opts => opts.MapFrom(src => src.CoronerNoticeInd))
                    .ForMember(desc => desc.CapitalChargeInd, opts => opts.MapFrom(src => src.CapitalChargeInd))
                    .ForMember(desc => desc.MainChargeInd, opts => opts.MapFrom(src => src.MainChargeInd))
                    //.ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CaseParty.CasePartyId))
                    //.ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DocCaseParty.DCPID))
                    .ForMember(desc => desc.ChargeStatus, opts => opts.MapFrom(src => src.ChargeStatus));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapChargeInfoToChargeInfoEntity", ex);
                throw;
            }
        }

        /**Criminal Mapping**/
        /// <summary>
        /// Method which maps the <see cref="CriminalInfo"/> to <see cref="CriminalInfoEntity"/>.
        /// </summary>
        internal void MapCriminalInfoToCriminalInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CriminalInfo, CriminalInfoEntity>()
                    .ForMember(desc => desc.CoronerNoticeInd, opts => opts.MapFrom(src => src.CoronerNoticeInd))
                    .ForMember(desc => desc.RevisionFromCCDC, opts => opts.MapFrom(src => src.RevisionFromCCDC))
                    .ForMember(desc => desc.CCDCFromHC, opts => opts.MapFrom(src => src.CCDCFromHC));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalInfoEntityToCriminalInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CriminalOtherOrderInfo"/> to <see cref="CriminalOtherOrderInfoEntity"/>.
        /// </summary>
        internal void MapCriminalOtherOrderInfoToCriminalOtherOrderInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CriminalOtherOrderInfo, CriminalOtherOrderInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalOtherOrderInfoToCriminalOtherOrderInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CWUChecklistInfo"/> to <see cref="CWUCheckListInfoEntity"/>.
        /// </summary>
        internal void MapCWUCheckListInfoToCWUCheckListInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CWUChecklistInfo, CWUCheckListInfoEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCWUCheckListInfoToCWUCheckListInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CWUInfo"/> to <see cref="CWUInfoEntity"/>.
        /// </summary>
        internal void MapCWUInfoToCWUInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CWUInfo, CWUInfoEntity>()
                    .ForMember(desc => desc.CWUInfoId, opts => opts.MapFrom(src => src.CWUInfoId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.WindingType, opts => opts.MapFrom(src => src.WindingType));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCWUInfoToCWUInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DCACAInfo"/> to <see cref="DCACAInfoEntity"/>.
        /// </summary>
        internal void MapDCACAInfoToDCACAInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DCACAInfo, DCACAInfoEntity>()
                     .ForMember(dest => dest.AppealAgainstJudOrder, opts => opts.MapFrom(src => src.AppealAgainstJudOrder))
                     .ForMember(dest => dest.AppealAgainstME, opts => opts.MapFrom(src => src.AppealAgainstME))
                     .ForMember(dest => dest.DateofOrder, opts => opts.MapFrom(src => src.DateofOrder))
                     .ForMember(dest => dest.DCACAInfoId, opts => opts.MapFrom(src => src.DCACAInfoId))
                     .ForMember(dest => dest.IsDCANOnIELS, opts => opts.MapFrom(src => src.IsDCANonIELS))
                     .ForMember(dest => dest.IsEOTOrderObtained, opts => opts.MapFrom(src => src.IsEOTOrderObtained))
                     .ForMember(dest => dest.IsLOCOrderObtainted, opts => opts.MapFrom(src => src.IsLOCOrderObtainted))
                     .ForMember(dest => dest.IsSecurityByUndertaking, opts => opts.MapFrom(src => src.IsSecurityByUndertaking))
                     .ForMember(dest => dest.IsSecurityCertFiled, opts => opts.MapFrom(src => src.IsSecurityCertFiled))
                     .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                     .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                     .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                      .ForMember(dest => dest.AppealIsAgainst, opts => opts.MapFrom(src => src.AppealIsAgainst))
                 .ForMember(dest => dest.SeekDirectionInd, opts => opts.MapFrom(src => src.SeekDirectionInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDCACAInfoToDCACAInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DrugInfo"/> to <see cref="DrugInfoEntity"/>.
        /// </summary>
        internal void MapDrugInfoToDrugInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DrugInfo, DrugInfoEntity>();
                //.ForMember(desc => desc.ChargeInfoId, opts => opts.MapFrom(src => src.ChargeInfo.ChargeInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDrugInfoToDrugInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="InvestigatingOfficerInfo"/> to <see cref="InvestigatingOfficerInfoEntity"/>.
        /// </summary>
        internal void MapInvestigatingOfficerInfoToInvestigatingOfficerInfoEntity()
        {
            try
            {
                Mapper.CreateMap<InvestigatingOfficerInfo, InvestigatingOfficerInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapInvestigatingOfficerInfoToInvestigatingOfficerInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="OffenceInfo"/> to <see cref="OffenceInfoEntity"/>.
        /// </summary>
        internal void MapOffenceInfoToOffenceInfoEntity()
        {
            try
            {
                Mapper.CreateMap<OffenceInfo, OffenceInfoEntity>()
                .ForMember(desc => desc.MainOffenceInd, opts => opts.MapFrom(src => src.MainOffenceInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapOffenceInfoToOffenceInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="OSInfoEntity"/> to <see cref="OSInfo"/>.
        /// </summary>
        internal void MapOSInfoToOSInfoEntity()
        {
            try
            {
                Mapper.CreateMap<OSInfo, OSInfoEntity>()
                    .ForMember(desc => desc.AppAgstDecOf, opts => opts.MapFrom(src => src.AppAgstDecOf))
                    .ForMember(desc => desc.AppAgstJudOrderDate, opts => opts.MapFrom(src => src.AppAgstJudOrderDate))
                    .ForMember(desc => desc.CompanyName, opts => opts.MapFrom(src => src.CompanyName))
                    .ForMember(desc => desc.DateOfCommCertIssued, opts => opts.MapFrom(src => src.DateOfCommCertIssued))
                    .ForMember(desc => desc.DateOfMarriage, opts => opts.MapFrom(src => src.DateOfMarriage))
                    .ForMember(desc => desc.DIRAmount, opts => opts.MapFrom(src => src.DIRAmount))
                    .ForMember(desc => desc.ESCOSubNOC, opts => opts.MapFrom(src => src.ESCOSubNOC))
                    .ForMember(desc => desc.EstAccBillClaimed, opts => opts.MapFrom(src => src.EstAccBillClaimed))
                    .ForMember(desc => desc.IsAppealToHC, opts => opts.MapFrom(src => src.IsAppeaToHC))
                    .ForMember(desc => desc.IsCommCertIssued, opts => opts.MapFrom(src => src.IsCommCertIssued))
                    .ForMember(desc => desc.IsCourtPermissionReq, opts => opts.MapFrom(src => src.IsCourtPermissionReq))
                    .ForMember(desc => desc.IsFilingCOSSFCWNOA, opts => opts.MapFrom(src => src.IsFilingCOSSFCWNOA))
                    .ForMember(desc => desc.IsFilingForHRGBef3Judges, opts => opts.MapFrom(src => src.IsFilingForHRGBef3Judges))
                    .ForMember(desc => desc.IsFilingtoEnfSCT, opts => opts.MapFrom(src => src.IsFilingtoEnfSCT))
                    .ForMember(desc => desc.IsInjunctionFiled, opts => opts.MapFrom(src => src.IsInjunctionFiled))
                    .ForMember(desc => desc.IsMuslimMarriage, opts => opts.MapFrom(src => src.IsMuslimMarriage))
                    .ForMember(desc => desc.IsSceurityByUndertaking, opts => opts.MapFrom(src => src.IsSceurityByUndertaking))
                    .ForMember(desc => desc.IsServiceOutJur, opts => opts.MapFrom(src => src.IsServiceOutJur))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.MCASubNOC, opts => opts.MapFrom(src => src.MCASubNOC))
                    .ForMember(desc => desc.OSInfoId, opts => opts.MapFrom(src => src.OSInfoId))
                    .ForMember(desc => desc.ProceedingInSyariahCourt, opts => opts.MapFrom(src => src.ProceedingInSyariahCourt))
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.UENNumber, opts => opts.MapFrom(src => src.UENNumber))
                    .ForMember(desc => desc.IsProbateOSP, opts => opts.MapFrom(src => src.IsProbateOSP))
                    .ForMember(desc => desc.IsJudicialManagement, opts => opts.MapFrom(src => src.IsJudicialManagement))
                    .ForMember(desc => desc.PHAType, opts => opts.MapFrom(src => src.PHAType))
                    .ForMember(desc => desc.HasPendingMCCases, opts => opts.MapFrom(src => src.HasPendingMCCases))
                    .ForMember(desc => desc.HasPendingFJCCases, opts => opts.MapFrom(src => src.HasPendingFJCCases))
                    .ForMember(desc => desc.HasPendingCJDCases, opts => opts.MapFrom(src => src.HasPendingCJDCases))
                    .ForMember(desc => desc.HasPendingSCTCases, opts => opts.MapFrom(src => src.HasPendingSCTCases))
                    .ForMember(desc => desc.HasPendingCDRACases, opts => opts.MapFrom(src => src.HasPendingCDRACases));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapOSInfoToOSInfoEntity", ex);
                throw;
            }
        }

        internal void MapOSJudicialManagerDetailsToOSJudicialManagerDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<OSJudicialManagerDetails, OSJudicialManagerDetailsEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOSJudicialManagerDetailsToOSJudicialManagerDetailsEntity", ex);
                throw;
            }
        }

        internal void MapOSMADetailsToOSMADetailsEntity()
        {
            try
            {
                Mapper.CreateMap<OSMADetails, OSMADetailsEntity>()
                    .ForMember(dest => dest.FormatInd, opts => opts.MapFrom(src => src.FormatInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOSMADetailsToOSMADetailsEntity", ex);
                throw;
            }
        }

        internal void MapPBBeneficiaryDetailsToPBBeneficiaryDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<PBBeneficiaryDetails, PBBeneficiaryDetailEntity>()
                    .ForMember(dest => dest.MCA, opts => opts.MapFrom(src => src.MCA))
                    .ForMember(dest => dest.MinorityInterestInd, opts => opts.MapFrom(src => src.MinorityInterestInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBBeneficiaryDetailsToPBBeneficiaryDetailsEntity", ex);
                throw;
            }
        }

        internal void MapPBCoAdminDetailsToPBCoAdminDetailEntity()
        {
            try
            {
                Mapper.CreateMap<PBCoAdminDetails, PBCoAdminDetailEntity>()
                    .ForMember(dest => dest.AddrInd, opts => opts.MapFrom(src => src.AddrInd))
                    .ForMember(dest => dest.FormatInd, opts => opts.MapFrom(src => src.FormatInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBCoAdminDetailsToPBCoAdminDetailEntity", ex);
                throw;
            }
        }

        internal void MapPBExecutorDetailsToPBExecutorDetailEntity()
        {
            try
            {
                Mapper.CreateMap<PBExecutorDetails, PBExecutorDetailEntity>()
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBExecutorDetailsToPBExecutorDetailEntity", ex);
                throw;
            }
        }

        internal void MapPBPrevGrantDetailsToPBPrevGrantDetailEntity()
        {
            try
            {
                Mapper.CreateMap<PBPrevGrantDetails, PBPrevGrantDetailEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBPrevGrantDetailsToPBPrevGrantDetailEntity", ex);
                throw;
            }
        }

        internal void MapPBWillCodicilToPBWillCodicilEntity()
        {
            try
            {
                Mapper.CreateMap<PBWillCodicil, PBWillCodicilEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBWillCodicilToPBWillCodicilEntity", ex);
                throw;
            }
        }

        internal void MapPracticeOfLawInfoToPracticeOfLawInfoEntity()
        {
            try
            {
                Mapper.CreateMap<PracticeOfLawInfo, PracticeOfLawInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPracticeOfLawInfoToPracticeOfLawInfoEntity", ex);
                throw;
            }
        }

        internal void MapPracticeTrainingPeriodInfoToPracticeTrainingPeriodInfoEntity()
        {
            try
            {
                Mapper.CreateMap<PracticeTrainingPeriodInfo, PracticeTrainingPeriodInfoEntity>()
                      .ForMember(dest => dest.LFID, opts => opts.MapFrom(src => src.LawFirm.LFID));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPracticeTrainingPeriodInfoToPracticeTrainingPeriodInfoEntity", ex);
                throw;
            }
        }

        internal void MapProbateInfoToProbateInfoEntity()
        {
            try
            {
                Mapper.CreateMap<ProbateInfo, ProbateInfoEntity>()
                    .ForMember(dest => dest.ApplicantType, opts => opts.MapFrom(src => src.ApplicantType))
                    .ForMember(dest => dest.ApplicationWithin6Months, opts => opts.MapFrom(src => src.ApplicationWithin6Months))
                    .ForMember(dest => dest.CaveatInd, opts => opts.MapFrom(src => src.CaveatInd))
                    .ForMember(dest => dest.DeceasedResided, opts => opts.MapFrom(src => src.DeceasedResided))
                    .ForMember(dest => dest.DuefromDeceased, opts => opts.MapFrom(src => src.DuefromDeceased))
                    .ForMember(dest => dest.EstateValue3M, opts => opts.MapFrom(src => src.EstateValue3M))
                    .ForMember(dest => dest.ExecutorDied, opts => opts.MapFrom(src => src.ExecutorDied))
                    .ForMember(dest => dest.ExecutorRenounced, opts => opts.MapFrom(src => src.ExecutorRenounced))
                    .ForMember(dest => dest.FirstCertification, opts => opts.MapFrom(src => src.FirstCertification))
                    .ForMember(dest => dest.HasCodicil, opts => opts.MapFrom(src => src.HasCodicil))
                    .ForMember(dest => dest.HasOtherApplicant, opts => opts.MapFrom(src => src.HasOtherApplicant))
                    .ForMember(dest => dest.IsApplyingLAAnnexed, opts => opts.MapFrom(src => src.IsApplyingLAAnnexed))
                    .ForMember(dest => dest.IsApplyingLAInfant, opts => opts.MapFrom(src => src.IsApplyingLAInfant))
                    .ForMember(dest => dest.IsApplyingLAWithPA, opts => opts.MapFrom(src => src.IsApplyingLAWithPA))
                    .ForMember(dest => dest.IsApplyingLAWithUE, opts => opts.MapFrom(src => src.IsApplyingLAWithUE))
                    .ForMember(dest => dest.IsWrittenWill, opts => opts.MapFrom(src => src.IsWrittenWill))
                    .ForMember(dest => dest.Limitations, opts => opts.MapFrom(src => src.Limitations))
                    .ForMember(dest => dest.Origin, opts => opts.MapFrom(src => src.Origin))
                    .ForMember(dest => dest.OSRelevantInfo, opts => opts.MapFrom(src => src.OSRelevantInfo))
                    .ForMember(dest => dest.OtherAnnexed, opts => opts.MapFrom(src => src.OtherAnnexed))
                    .ForMember(dest => dest.OtherAnnexedReason, opts => opts.MapFrom(src => src.OtherAnnexedReason))
                    .ForMember(dest => dest.ProbateInfoType, opts => opts.MapFrom(src => src.ProbateInfoType))
                    .ForMember(dest => dest.SecondCertification, opts => opts.MapFrom(src => src.SecondCertification))
                    .ForMember(dest => dest.TstDidNotNameExec, opts => opts.MapFrom(src => src.TstDidNotNameExec))
                    .ForMember(dest => dest.TstDidNotNameRL, opts => opts.MapFrom(src => src.TstDidNotNameRL))
                    .ForMember(dest => dest.SOAHardCopyInd, opts => opts.MapFrom(src => src.SOAHardCopyInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapProbateInfoToProbateInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RCriminalLegislationInfo"/> to <see cref="RCriminalLegislationInfoEntity"/>.
        /// </summary>
        internal void MapRCriminalLegislationInfoToRCriminalLegislationInfoEntity()
        {
            try
            {
                Mapper.CreateMap<RCriminalLegislationInfo, RCriminalLegislationInfoEntity>();
                //.ForMember(desc => desc.ChargeInfoId, opts => opts.MapFrom(src => src.ChargeInfo.ChargeInfoId))
                //.ForMember(desc => desc.LegislationProvisionsId, opts => opts.MapFrom(src => src.LegislationProvision.LegislationProvisionId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRCriminalLegislationInfoToRCriminalLegislationInfoEntity", ex);
                throw;
            }
        }

        internal void MapSentenceCriminalOrderInfoToSentenceCriminalOrderInfoEntity()
        {
            try
            {
                Mapper.CreateMap<SentenceCriminalOrderInfo, SentenceCriminalOrderInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSentenceCriminalOrderInfoToSentenceCriminalOrderInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="SentenceInfo"/> to <see cref="SentenceInfoEntity"/>.
        /// </summary>
        internal void MapSentenceInfoToSentenceInfoEntity()
        {
            try
            {
                Mapper.CreateMap<SentenceInfo, SentenceInfoEntity>()
                    //.ForMember(desc => desc.ChargeInfoId, opts => opts.MapFrom(src => src.ChargeInfo.ChargeInfoId))
                    .ForMember(desc => desc.FinePaidInd, opts => opts.MapFrom(src => src.FinePaidInd))
                    .ForMember(desc => desc.PenaltyPaidInd, opts => opts.MapFrom(src => src.PenaltyPaidInd))
                    .ForMember(desc => desc.NatureOfSentence, opts => opts.MapFrom(src => src.NatureOfSentence))
                    .ForMember(desc => desc.StatusOfSentence, opts => opts.MapFrom(src => src.StatusOfSentence));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapSentenceInfoToSentenceInfoEntity", ex);
                throw;
            }
        }

        internal void MapTaxationClaimToTaxationClaimEntity()
        {
            try
            {
                Mapper.CreateMap<TaxationClaim, TaxationClaimEntity>()
                    .ForMember(dest => dest.IsCorrectInd, opts => opts.MapFrom(src => src.IsCorrectInd))
                .ForMember(dest => dest.MHRGType, opts => opts.MapFrom(src => src.HRGTypeCode));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapTaxationClaimEntityToTaxationClaim", ex);
                throw;
            }
        }

        internal void MapTaxationInfoToTaxationInfoEntity()
        {
            try
            {
                Mapper.CreateMap<TaxationInfo, TaxationInfoEntity>()
                    .ForMember(dest => dest.DirectorConsented, opts => opts.MapFrom(src=>src.DirectorConsented))
                    .ForMember(dest => dest.IssueCOC, opts => opts.MapFrom(src => src.IssueCOC))
                    .ForMember(dest => dest.PublicTrusteeConsented, opts => opts.MapFrom(src => src.PublicTrusteeConsented))
                    .ForMember(dest => dest.WithdrawalFeeInd, opts => opts.MapFrom(src => src.WithdrawalFeeInd))
                    .ForMember(dest => dest.MBasisForTaxation, opts => opts.MapFrom(src => src.BFTCode));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapTaxationInfoToTaxationInfoEntity", ex);
                throw;
            }
        }

        internal void MapWOEMOMSCTInfoToWOEMOMSCTInfoEntity()
        {
            try
            {
                Mapper.CreateMap<WOEMOMSCTInfo, WOEMOMSCTInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOEMOMSCTInfoToWOEMOMSCTInfoEntity", ex);
                throw;
            }
        }

        internal void MapWOSInfoToWOSInfoEntity()
        {
            try
            {
                Mapper.CreateMap<WOSInfo, WOSInfoEntity>()
                    .ForMember(dest => dest.AttachmentType, opts => opts.MapFrom(src => src.AttachmentType))
                    .ForMember(dest => dest.ControlType, opts => opts.MapFrom(src => src.ControlType))
                    .ForMember(dest => dest.IsInjunctionFiled, opts => opts.MapFrom(src => src.IsInjunctionFiled))
                    .ForMember(dest => dest.IsManagedEWT, opts => opts.MapFrom(src => src.IsManagedEWT))
                     .ForMember(dest => dest.IsPartnerInFirm, opts => opts.MapFrom(src => src.IsPartnerInFirm))
                    .ForMember(dest => dest.IsServeOutJDC, opts => opts.MapFrom(src => src.IsServeOutJDC))
                     .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.TotalLIQAwardedAmount, opts => opts.MapFrom(src => src.TotalLIQAwardedAmount))
                    .ForMember(dest => dest.TotalLIQClaimAmount, opts => opts.MapFrom(src => src.TotalLIQClaimAmount))
                    .ForMember(dest => dest.TotlaUnLIQAwardedAmount, opts => opts.MapFrom(src => src.TotalUnLIQAwardedAmount))
                    .ForMember(dest => dest.TotalUnLIQESTAmount, opts => opts.MapFrom(src => src.TotalUnLIQESTAmount))
                    .ForMember(dest => dest.WOSInfoId, opts => opts.MapFrom(src => src.WOSInfoId))
                    .ForMember(dest => dest.WritExpiryDate, opts => opts.MapFrom(src => src.WritExpiryDate))
                    .ForMember(dest => dest.IsPOHA, opts => opts.MapFrom(src => src.IsPOHA));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOSInfoToWOSInfoEntity", ex);
                throw;
            }
        }

        internal void MapDCACAOriginatingCasePartyInfoToDCACAOriginatingCasePartyInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DCACAOriginatingCasePartyInfo, DCACAOriginatingCasePartyInfoEntity>()
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDCACAOriginatingCasePartyInfoToDCACAOriginatingCasePartyInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RARASInfo"/> to <see cref="RARASInfoEntity"/>.
        /// </summary>
        internal void MapRASInfoToRASInfoEntity()
        {
            try
            {
                Mapper.CreateMap<RASInfo, RASInfoEntity>()
                    .ForMember(dest => dest.AppealAgainstJudOrder, opts => opts.MapFrom(src => src.AppealAgainstJudOrder))
                    .ForMember(dest => dest.AppealAgainstME, opts => opts.MapFrom(src => src.AppealAgainstME))
                    .ForMember(dest => dest.DateofOrder, opts => opts.MapFrom(src => src.DateofOrder))
                    .ForMember(dest => dest.IsEOTOrderObtained, opts => opts.MapFrom(src => src.IsEOTOrderObtained))
                    .ForMember(dest => dest.IsLOCOrderObtainted, opts => opts.MapFrom(src => src.IsLOCOrderObtainted))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.RASInfoId, opts => opts.MapFrom(src => src.RASInfoId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.SeekDirectionInd, opts => opts.MapFrom(src => src.SeekDirectionInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRASInfoToRASInfoEntity", ex);
                throw;
            }
        }

        internal void MapBankruptcyDebtInfoToBankruptcyDebtInfoEntity()
        {
            try
            {
                Mapper.CreateMap<BankruptcyDebtInfo, BankruptcyDebtInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBankruptcyDebtInfoEntityToBankruptcyDebtInfoEntity", ex);
                throw;
            }
        }

        internal void MapPBPADetailToPBPADetailsEntity()
        {
            try
            {
                Mapper.CreateMap<PBPADetails, PBPADetailEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBPADetailToPBPADetailsEntity", ex);
                throw;
            }
        }

        internal void MapPBSupNExmToPBSupNExmEntity()
        {
            try
            {
                Mapper.CreateMap<PBSupNExm, PBSupNExmEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBSupNExmToPBSupNExmEntity", ex);
                throw;
            }
        }

        internal void MapPBAdminBondToPBAdminBondEntity()
        {
            try
            {
                Mapper.CreateMap<PBAdminBond, PBAdminBondEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBAdminBondToPBAdminBondEntity", ex);
                throw;
            }
        }

        internal void MapCaseRegisterToCaseRegisterEntity()
        {
            try
            {
                Mapper.CreateMap<CaseRegister, CaseRegisterEntity>()
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.IsCurrentLife, opts => opts.MapFrom(src => src.IsCurrentLife));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseRegisterToCaseRegisterEntity", ex);
                throw;
            }
        }
        internal void MapCaseRegisterHistoryToCaseRegisterHistoryEntity()
        {
            try
            {
                Mapper.CreateMap<CaseRegisterHistory, CaseRegisterHistoryEntity>()
                  .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.IsCurrentLife, opts => opts.MapFrom(src => src.IsCurrentLife));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseRegisterHistoryToCaseRegisterHistoryEntity", ex);
                throw;
            }
        }
        internal void MapDashboardCaseMilestoneDetailToDashboardCaseMilestoneDetailEntity()
        {
            try
            {
                Mapper.CreateMap<DashboardCaseMilestoneDetail, DashboardCaseMilestoneDetailEntity>()
                      .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDashboardCaseMilestoneDetailToDashboardCaseMilestoneDetailEntity", ex);
                throw;
            }
        }

        internal void MapDashboardCaseMilestoneDetailHistoryToDashboardCaseMilestoneDetailHistoryEntity()
        {
            try
            {
                Mapper.CreateMap<DashboardCaseMilestoneDetailHistory, DashboardCaseMilestoneDetailHistoryEntity>()
                      .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDashboardCaseMilestoneDetailHistoryToDashboardCaseMilestoneDetailHistoryEntity", ex);
                throw;
            }
        }

        internal void MapCaveatInfoToCaveatInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CaveatInfo, CaveatInfoEntity>()
                     .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId));
                    
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaveatInfoEntityToCaveatInfo", ex);
                throw;
            }
        }

        internal void MapCaveatAAInfoToCaveatInfoAAEntity()
        {
            try
            {
                Mapper.CreateMap<CaveatAAInfo, CaveatAAInfoEntity>()
                     .ForMember(dest => dest.VesselIdType, opts => opts.MapFrom(src => src.VesselIdType));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaveatAAInfoToCaveatInfoAAEntity", ex);
                throw;
            }
        }

        internal void MapJMChecklistInfoToJMChecklistInfoEntity()
        {
            try
            {
                Mapper.CreateMap<JMChecklistInfo, JMChecklistInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapJMChecklistInfoToJMChecklistInfoEntity", ex);
                throw;
            }
        }

        internal void MapJMOtherInfoToJMOtherInfoEntity()
        {
            try
            {
                Mapper.CreateMap<JMOtherInfo, JMOtherInfoEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.caseinfoid))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.IsPCRCompliedWith, opts => opts.MapFrom(src => src.IsPCRCompliedWith))
                    .ForMember(dest => dest.IsInfoSent, opts => opts.MapFrom(src => src.IsInfoSent))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapJMOtherInfoEntityToJMOtherInfo", ex);
                throw;
            }
        }

        internal void MapDirectionDetailsToDirectionDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<DirectionDetails, DirectionDetailsEntity>()
                    .ForMember(desc => desc.CaseInfoID, opts => opts.MapFrom(src => src.CaseInfoID))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.SubCaseInfoID, opts => opts.MapFrom(src => src.SubCaseInfoID))
                    .ForMember(dest => dest.HRGID, opts => opts.MapFrom(src => src.HRGID))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDirectionDetailsToDirectionDetailsEntity", ex);
                throw;
            }
        }
        #endregion Methods
    }
}