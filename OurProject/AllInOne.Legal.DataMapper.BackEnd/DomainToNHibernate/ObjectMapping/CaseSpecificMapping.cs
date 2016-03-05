#region Header

/*****************************************************************************************************
* Description : This file handles mapping for Case Specific related from Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   29/11/2010   		        Nithin                  Created

*****************************************************************************************************/
// <summary>
// File: CaseSpecificMapping.cs
// Description: This file handles mapping for Case Specific related from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "CaseSpecificMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.WritOfSummons;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Case Specific related from Domain objects to NHibernate entities.
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

        internal void BankruptcyOtherDefDetailEntityToBankruptcyOtherDefDetail()
        {
            try
            {
                MasterMapping masterMapping = new MasterMapping();

                Mapper.CreateMap<BankruptcyOtherDefDetailEntity, BankruptcyOtherDefDetail>()
                    .ForMember(dest => dest.CompanyName, opts => opts.MapFrom(src => src.CompanyName))
                    .ForMember(dest => dest.DateOfRegistration, opts => opts.MapFrom(src => src.DateOfRegistration))
                    .ForMember(dest => dest.FullName, opts => opts.MapFrom(src => src.FullName))
                    .ForMember(dest => dest.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(dest => dest.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    //.ForMember(dest => dest.MCountryCountryOfRegistration, opts => opts.MapFrom(src => src.MCountryOfRegistration))
                    //.ForMember(dest=>dest.MCountryIdCountryCode,opts=>opts.MapFrom(src=>src.
                    .ForMember(dest => dest.MEntityType, opts => opts.MapFrom(src => src.MEntityType))
                    .ForMember(dest => dest.MPersonIDGroup, opts => opts.MapFrom(src => src.MPersonIdGroup));
                //.ForMember(dest=>dest.MPersonIDTypeCompanyIdTypeCode,opts=>opts.MapFrom(src=>src.MPersonIdType.))
                // .ForMember(dest=>dest.MPersonIDTypePersonIdTypeCode,opts=>opts.MapFrom(src=>src.

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at BankruptcyOtherDefDetailEntityToBankruptcyOtherDefDetail", ex);
                throw;
            }
        }

        /**End of Criminal Mapping**/
        internal void MapAASInfoEntityToAASInfo()
        {
            try
            {
                Mapper.CreateMap<AASInfoEntity, AASInfo>()
                    .ForMember(dest => dest.IsMLawExemptionApproved, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsMLawExemptionApproved))
                    .ForMember(dest => dest.LPALPRSectionType, opts => opts.ResolveUsing<LPALPRSectionOrProvisionToStringResolver>().FromMember(src => src.LPALPRSectionType));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAASInfoEntityToAASInfo", ex);
                throw;
            }
        }

        internal void MapAASObjectionEntityToAASObjection()
        {
            try
            {
                Mapper.CreateMap<AASObjectionEntity, AASObjection>()
                    .ForMember(dest => dest.BLEObjection, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.BLEObjection))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.LawSocObjection, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.LawSocObjection))
                    .ForMember(dest => dest.PublicObjection, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PublicObjection))
                    .ForMember(dest => dest.SALObjection, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SALObjection));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAASObjectionEntityToAASObjection", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="ADMInfo"/> to <see cref="ADMInfoEntity"/>.
        /// </summary>
        internal void MapAdmInfoEntityToAdmInfo()
        {
            try
            {
                Mapper.CreateMap<ADMInfoEntity, ADMInfo>()
                    .ForMember(dest => dest.ADMInfoId, opts => opts.MapFrom(src => src.ADMInfoId))
                    .ForMember(dest => dest.AdmiraltyWritType, opts => opts.ResolveUsing<AdmiraltyWritTypeToStringResolver>().FromMember(src => src.AdmiraltyWritType))
                    .ForMember(dest => dest.AttachmentType, opts => opts.ResolveUsing<StatementOrEndorsementInWritToStringResolver>().FromMember(src => src.AttachmentType))
                    .ForMember(dest => dest.CaveatSearchDateTime, opts => opts.MapFrom(src => src.CaveatSearchDateTime))
                    .ForMember(dest => dest.CaveatSearchResult, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CaveatSearchResult))
                    .ForMember(dest => dest.IsInjunctionFiled, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInjunctionFiled))
                    .ForMember(dest => dest.IsManagedEWT, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsManagedEWT))
                    .ForMember(dest => dest.IsPartnerInFirm, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPartnerInFirm))
                    .ForMember(dest => dest.IsServeOutJDC, opts => opts.ResolveUsing<JurisdictionInSingaporeToStringResolver>().FromMember(src => src.IsServeOutJDC))
                    .ForMember(dest => dest.IsWOARequired, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsWOARequired))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(SRC => SRC.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.TotalLIQAwardedAmount, opts => opts.MapFrom(src => src.TotalLIQAwardedAmount))
                    .ForMember(dest => dest.TotalLIQClaimAmount, opts => opts.MapFrom(src => src.TotalLIQClaimAmount))
                    .ForMember(dest => dest.TotalUnLIQESTAmount, opts => opts.MapFrom(src => src.TotalUnLIQESTAmount))
                    .ForMember(dest => dest.TotlaUnLIQAwardedAmount, opts => opts.MapFrom(src => src.TotalUnLIQAwardedAmount));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapADMInfoEntityToADMInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="BankruptcyInfoEntity"/> to <see cref="BankruptcyInfo"/>.
        /// </summary>
        internal void MapBankruptcyInfoEntityToBankruptcyInfo()
        {
            try
            {
                MasterMapping masterMapping = new MasterMapping();

                Mapper.CreateMap<BankruptcyInfoEntity, BankruptcyInfo>()
                    .ForMember(dest => dest.BankruptcyInfoId, opts => opts.MapFrom(src => src.BankruptcyInfoId))
                    .ForMember(dest => dest.DeathFromDate, opts => opts.MapFrom(src => src.DeathFromDate))
                    .ForMember(dest => dest.DeathToDate, opts => opts.MapFrom(src => src.DeathToDate))
                    .ForMember(dest => dest.ExecutionCompDate, opts => opts.MapFrom(src => src.ExecutionCompDate))
                    .ForMember(dest => dest.IsAnotherBAFiled, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAnotherBAFiled))
                    .ForMember(dest => dest.IsAnotherDefField, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAnotherDefField))
                    .ForMember(dest => dest.IsServiceOutJur, opts => opts.ResolveUsing<JurisdictionInSingaporeToStringResolver>().FromMember(src => src.IsServiceOutJur))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MCurrency, opts => opts.MapFrom(src => src.MCurrency))
                    .ForMember(dest => dest.ProbateCaseNo, opts => opts.MapFrom(src => src.ProbateCaseNo))
                    .ForMember(dest => dest.RevCertIssueDate, opts => opts.MapFrom(src => src.RevCertIssueDate))
                    .ForMember(dest => dest.StatuaryDemandDate, opts => opts.MapFrom(src => src.StatuaryDemandDate))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.TotalDebt, opts => opts.MapFrom(src => src.TotalDebt))
                    .ForMember(dest => dest.TotalDebtinSGD, opts => opts.MapFrom(src => src.TotalDebtInSGD));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBankruptcyInfoEntityToBankruptcyInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="BillOfSaleInfoEntity"/> to <see cref="BillOfSaleInfo"/>.
        /// </summary>
        internal void MapBillOfSaleInfoEntityToBillOfSaleInfo()
        {
            try
            {
                Mapper.CreateMap<BillOfSaleInfoEntity, BillOfSaleInfo>()
                    .ForMember(desc => desc.BillOfSaleInfoId, opts => opts.MapFrom(src => src.BillOfSaleInfoId))
                    .ForMember(desc => desc.InstrumentDate, opts => opts.MapFrom(src => src.InstrumentDate))
                    .ForMember(desc => desc.InstrumentName, opts => opts.MapFrom(src => src.InstrumentName))
                    .ForMember(desc => desc.IsAbsoluteBillOfSale, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAbsoluteBillOfSale))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBillOfSaleInfoEntityToBillOfSaleInfo", ex);
                throw;
            }
        }

        internal void MapBOTDetailEntityToBOTDetails()
        {
            try
            {
                Mapper.CreateMap<BOTDetailEntity, BOTDetails>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBOTDetailEntityToBOTDetails", ex);
                throw;
            }
        }

        internal void MapCaveatAAInfoEntityToCaveatAAInfo()
        {
            try
            {
                Mapper.CreateMap<CaveatAAInfoEntity, CaveatAAInfo>()
                    .ForMember(dest => dest.VesselIdType, opts => opts.ResolveUsing<VesselIdTypeToStringResolver>().FromMember(src => src.VesselIdType));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaveatAAInfoEntityToCaveatAAInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ChargeInfoEntity"/> to <see cref="ChargeInfo"/>.
        /// </summary>
        internal void MapChargeInfoEntityToChargeInfo()
        {
            try
            {
                Mapper.CreateMap<ChargeInfoEntity, ChargeInfo>()
                    .ForMember(desc => desc.DrugInfos, opts => opts.Ignore())
                    .ForMember(desc => desc.OffenceInfos, opts => opts.Ignore())
                    .ForMember(desc => desc.RCriminalLegislationInfos, opts => opts.Ignore())
                    //.ForMember(desc => desc.SentenceInfos, opts => opts.Ignore())
                    .ForMember(desc => desc.PIChargeInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PIChargeInd))
                    .ForMember(desc => desc.CoronerNoticeInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CoronerNoticeInd))
                    .ForMember(desc => desc.CapitalChargeInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CapitalChargeInd))
                    .ForMember(desc => desc.MainChargeInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MainChargeInd))
                    //.ForMember(desc => desc.CaseParty, opts => opts.ResolveUsing<StringToCasePartyResolver>().FromMember(src => src.CasePartyId))
                    //.ForMember(desc => desc.DocCaseParty, opts => opts.ResolveUsing<StringToDocCasePartyResolver>().FromMember(src => src.DCPID))
                    .ForMember(desc => desc.ChargeStatus, opts => opts.ResolveUsing<ChargeStatusTypeToStringResolver>().FromMember(src => src.ChargeStatus));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapChargeInfoEntityToChargeInfo", ex);
                throw;
            }
        }

        /**Criminal Mapping**/
        /// <summary>
        /// Method which maps the <see cref="CriminalInfoEntity"/> to <see cref="CriminalInfo"/>.
        /// </summary>
        internal void MapCriminalInfoEntityToCriminalInfo()
        {
            try
            {
                Mapper.CreateMap<CriminalInfoEntity, CriminalInfo>()
                    .ForMember(desc => desc.CoronerNoticeInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CoronerNoticeInd))
                    .ForMember(desc => desc.RevisionFromCCDC, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.RevisionFromCCDC))
                    .ForMember(desc => desc.CCDCFromHC, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CCDCFromHC));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalInfoToCriminalInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CriminalOtherOrderInfoEntity"/> to <see cref="CriminalOtherOrderInfo"/>.
        /// </summary>
        internal void MapCriminalOtherOrderInfoEntityToCriminalOtherOrderInfo()
        {
            try
            {
                Mapper.CreateMap<CriminalOtherOrderInfoEntity, CriminalOtherOrderInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalOtherOrderInfoEntityToCriminalOtherOrderInfo", ex);
                throw;
            }
        }

        internal void MapCWUCheckListInfoEntityToCWUChecklistInfo()
        {
            try
            {
                Mapper.CreateMap<CWUCheckListInfoEntity, CWUChecklistInfo>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCWUCheckListInfoEntityToCWUChecklistInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CWUInfoEntity"/> to <see cref="CWUInfo"/>.
        /// </summary>
        internal void MapCWUInfoEntityToCWUInfo()
        {
            try
            {
                Mapper.CreateMap<CWUInfoEntity, CWUInfo>()
                    .ForMember(desc => desc.CWUInfoId, opts => opts.MapFrom(src => src.CWUInfoId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.WindingType, opts => opts.ResolveUsing<WindingTypeToStringResolver>().FromMember(src => src.WindingType));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCWUInfoEntityToCWUInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DrugInfoEntity"/> to <see cref="DrugInfo"/>.
        /// </summary>
        internal void MapDrugInfoEntityToDrugInfo()
        {
            try
            {
                Mapper.CreateMap<DrugInfoEntity, DrugInfo>();
                //.ForMember(desc => desc.ChargeInfo, opts => opts.ResolveUsing<StringToChargeInfoResolver>().FromMember(src => src.ChargeInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDrugInfoEntityToDrugInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="InvestigatingOfficerInfoEntity"/> to <see cref="InvestigatingOfficerInfo"/>.
        /// </summary>
        internal void MapInvestigatingOfficerInfoEntityToInvestigatingOfficerInfo()
        {
            try
            {
                Mapper.CreateMap<InvestigatingOfficerInfoEntity, InvestigatingOfficerInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapInvestigatingOfficerInfoEntityToInvestigatingOfficerInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="OffenceInfoEntity"/> to <see cref="OffenceInfo"/>.
        /// </summary>
        internal void MapOffenceInfoEntityToOffenceInfo()
        {
            try
            {
                Mapper.CreateMap<OffenceInfoEntity, OffenceInfo>()
                .ForMember(desc => desc.MainOffenceInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MainOffenceInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapOffenceInfoEntityToOffenceInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="OSInfoEntity"/> to <see cref="OSInfo"/>.
        /// </summary>
        internal void MapOSInfoEntityToOSInfo()
        {
            try
            {
                Mapper.CreateMap<OSInfoEntity, OSInfo>()
                    .ForMember(desc => desc.AppAgstDecOf, opts => opts.MapFrom(src => src.AppAgstDecOf))
                    .ForMember(desc => desc.AppAgstJudOrderDate, opts => opts.MapFrom(src => src.AppAgstJudOrderDate))
                    .ForMember(desc => desc.CompanyName, opts => opts.MapFrom(src => src.CompanyName))
                    .ForMember(desc => desc.DateOfCommCertIssued, opts => opts.MapFrom(src => src.DateOfCommCertIssued))
                    .ForMember(desc => desc.DateOfMarriage, opts => opts.MapFrom(src => src.DateOfMarriage))
                    .ForMember(desc => desc.DIRAmount, opts => opts.MapFrom(src => src.DIRAmount))
                    .ForMember(desc => desc.ESCOSubNOC, opts => opts.MapFrom(src => src.ESCOSubNOC))
                    .ForMember(desc => desc.EstAccBillClaimed, opts => opts.MapFrom(src => src.EstAccBillClaimed))
                    .ForMember(desc => desc.IsAppeaToHC, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAppealToHC))
                    .ForMember(desc => desc.IsCommCertIssued, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCommCertIssued))
                    .ForMember(desc => desc.IsCourtPermissionReq, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCourtPermissionReq))
                    .ForMember(desc => desc.IsFilingCOSSFCWNOA, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsFilingCOSSFCWNOA))
                    .ForMember(desc => desc.IsFilingForHRGBef3Judges, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsFilingForHRGBef3Judges))
                    .ForMember(desc => desc.IsFilingtoEnfSCT, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsFilingtoEnfSCT))
                    .ForMember(desc => desc.IsInjunctionFiled, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInjunctionFiled))
                    .ForMember(desc => desc.IsMuslimMarriage, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsMuslimMarriage))
                    .ForMember(desc => desc.IsSceurityByUndertaking, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSceurityByUndertaking))
                    .ForMember(desc => desc.IsServiceOutJur, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsServiceOutJur))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.MCASubNOC, opts => opts.MapFrom(src => src.MCASubNOC))
                    .ForMember(desc => desc.OSInfoId, opts => opts.MapFrom(src => src.OSInfoId))
                    .ForMember(desc => desc.ProceedingInSyariahCourt, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ProceedingInSyariahCourt))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.UENNumber, opts => opts.MapFrom(src => src.UENNumber))
                    //.ForMember(desc => desc.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.IsProbateOSP, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsProbateOSP))
                    .ForMember(desc => desc.IsJudicialManagement, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsJudicialManagement))
                    .ForMember(desc => desc.HasPendingMCCases, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasPendingMCCases))
                    .ForMember(desc => desc.HasPendingFJCCases, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasPendingFJCCases))
                    .ForMember(desc => desc.HasPendingCJDCases, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasPendingCJDCases))
                    .ForMember(desc => desc.HasPendingSCTCases, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasPendingSCTCases))
                    .ForMember(desc => desc.HasPendingCDRACases, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasPendingCDRACases));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOSInfoEntityToOSInfo", ex);
                throw;
            }
        }

        internal void MapOSJudicialManagerDetailsEntityToOSJudicialManagerDetails()
        {
            try
            {
                Mapper.CreateMap<OSJudicialManagerDetailsEntity, OSJudicialManagerDetails>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOSJudicialManagerDetailsEntityToOSJudicialManagerDetails", ex);
                throw;
            }
        }

        internal void MapOSMADetailsEntityToOSMADetails()
        {
            try
            {
                Mapper.CreateMap<OSMADetailsEntity, OSMADetails>()
                    .ForMember(dest => dest.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOSJudicialManagerDetailsEntityToOSJudicialManagerDetails", ex);
                throw;
            }
        }

        internal void MapPBBeneficiaryDetailsEntityToPBBeneficiaryDetails()
        {
            try
            {
                Mapper.CreateMap<PBBeneficiaryDetailEntity, PBBeneficiaryDetails>()
                    .ForMember(dest => dest.MCA, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MCA))
                    .ForMember(dest => dest.MinorityInterestInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MinorityInterestInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBBeneficiaryDetailsEntityToPBBeneficiaryDetails", ex);
                throw;
            }
        }

        internal void MapPBCoAdminDetailsEntityToPBCoAdminDetail()
        {
            try
            {
                Mapper.CreateMap<PBCoAdminDetailEntity, PBCoAdminDetails>()
                    .ForMember(dest => dest.AddrInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.AddrInd))
                    .ForMember(dest => dest.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBCoAdminDetailsEntityToPBCoAdminDetail", ex);
                throw;
            }
        }

        internal void MapPBExecutorDetailEntityToPBExecutorDetails()
        {
            try
            {
                Mapper.CreateMap<PBExecutorDetailEntity, PBExecutorDetails>()
                    .ForMember(dest => dest.Status, opts => opts.ResolveUsing<ExecutorStatusToStringResolver>().FromMember(src => src.Status));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBExecutorDetailEntityToPBExecutorDetails", ex);
                throw;
            }
        }

        internal void MapPBPrevGrantDetailEntityToPBPrevGrantDetails()
        {
            try
            {
                Mapper.CreateMap<PBPrevGrantDetailEntity, PBPrevGrantDetails>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBPrevGrantDetailEntityToPBPrevGrantDetails", ex);
                throw;
            }
        }

        internal void MapPBWillCodicilEntityToPBWillCodicil()
        {
            try
            {
                Mapper.CreateMap<PBWillCodicilEntity, PBWillCodicil>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBWillCodicilEntityToPBWillCodicil", ex);
                throw;
            }
        }

        internal void MapPracticeOfLawInfoEntityToPracticeOfLawInfo()
        {
            try
            {
                Mapper.CreateMap<PracticeOfLawInfoEntity, PracticeOfLawInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPracticeOfLawInfoEntityToPracticeOfLawInfo", ex);
                throw;
            }
        }

        internal void MapPracticeTrainingPeriodInfoEntityToPracticeTrainingPeriodInfo()
        {
            try
            {
                Mapper.CreateMap<PracticeTrainingPeriodInfoEntity, PracticeTrainingPeriodInfo>()
                      .ForMember(dest => dest.LawFirm, opts => opts.ResolveUsing<StringToLawFirmResolver>().FromMember(src => src.LFID));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPracticeTrainingPeriodInfoEntityToPracticeTrainingPeriodInfo", ex);
                throw;
            }
        }

        internal void MapProbateInfoEntityToProbateInfo()
        {
            try
            {
                Mapper.CreateMap<ProbateInfoEntity, ProbateInfo>()
                     .ForMember(dest => dest.ApplicantType, opts => opts.ResolveUsing<ApplicantTypeToStringResolver>().FromMember(src => src.ApplicantType))
                    .ForMember(dest => dest.ApplicationWithin6Months, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ApplicationWithin6Months))
                    .ForMember(dest => dest.CaveatInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CaveatInd))
                    .ForMember(dest => dest.DeceasedResided, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.DeceasedResided))
                    .ForMember(dest => dest.DuefromDeceased, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.DuefromDeceased))
                    .ForMember(dest => dest.EstateValue3M, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.EstateValue3M))
                    .ForMember(dest => dest.ExecutorDied, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ExecutorDied))
                    .ForMember(dest => dest.ExecutorRenounced, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ExecutorRenounced))
                    .ForMember(dest => dest.FirstCertification, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.FirstCertification))
                    .ForMember(dest => dest.HasCodicil, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasCodicil))
                    .ForMember(dest => dest.HasOtherApplicant, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasOtherApplicant))
                    .ForMember(dest => dest.IsApplyingLAAnnexed, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsApplyingLAAnnexed))
                    .ForMember(dest => dest.IsApplyingLAInfant, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsApplyingLAInfant))
                    .ForMember(dest => dest.IsApplyingLAWithPA, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsApplyingLAWithPA))
                    .ForMember(dest => dest.IsApplyingLAWithUE, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsApplyingLAWithUE))
                    .ForMember(dest => dest.IsWrittenWill, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsWrittenWill))
                    .ForMember(dest => dest.Limitations, opts => opts.ResolveUsing<ApplicationLimitationToStringResolver>().FromMember(src => src.Limitations))
                    .ForMember(dest => dest.Origin, opts => opts.ResolveUsing<OriginToStringResolver>().FromMember(src => src.Origin))
                    .ForMember(dest => dest.OtherAnnexed, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.OtherAnnexed))
                   // .ForMember(dest => dest.OtherAnnexedReason, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.OtherAnnexedReason))
                    .ForMember(dest => dest.ProbateInfoType, opts => opts.ResolveUsing<ProbateInfoTypeToStringResolver>().FromMember(src => src.ProbateInfoType))
                    .ForMember(dest => dest.SecondCertification, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SecondCertification))
                    .ForMember(dest => dest.TstDidNotNameExec, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.TstDidNotNameExec))
                    .ForMember(dest => dest.TstDidNotNameRL, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.TstDidNotNameRL))
                    .ForMember(dest => dest.SOAHardCopyInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SOAHardCopyInd)); ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapProbateInfoEntityToProbateInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RCriminalLegislationInfoEntity"/> to <see cref="RCriminalLegislationInfo"/>.
        /// </summary>
        internal void MapRCriminalLegislationInfoEntityToRCriminalLegislationInfo()
        {
            try
            {
                Mapper.CreateMap<RCriminalLegislationInfoEntity, RCriminalLegislationInfo>();
                //.ForMember(desc => desc.ChargeInfo, opts => opts.ResolveUsing<StringToChargeInfoResolver>().FromMember(src => src.ChargeInfoId))
                //.ForMember(desc => desc.LegislationProvision, opts => opts.ResolveUsing<StringToLegislationProvisionResolver>().FromMember(src => src.LegislationProvisionsId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRCriminalLegislationInfoEntityToRCriminalLegislationInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="RefCaveatCase"/> to <see cref="RefCaveatCaseEntity"/>.
        /// </summary>
        internal void MapRefCaveatCaseEntityToRefCaveatCase()
        {
            try
            {
                Mapper.CreateMap<RefCaveatCaseEntity, RefCaveatCase>()
                    .ForMember(dest => dest.ADMCavetNoId, opts => opts.MapFrom(src => src.ADMCaveatNoId))
                    .ForMember(dest => dest.CaseNo, opts => opts.MapFrom(src => src.CaseNo))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRefCaveatCaseEntityToRefCaveatCase", ex);
                throw;
            }
        }

        internal void MapSentenceCriminalOrderInfoEntityToSentenceCriminalOrderInfo()
        {
            try
            {
                Mapper.CreateMap<SentenceCriminalOrderInfoEntity, SentenceCriminalOrderInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSentenceCriminalOrderInfoEntityToSentenceCriminalOrderInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="SentenceInfoEntity"/> to <see cref="SentenceInfo"/>.
        /// </summary>
        internal void MapSentenceInfoEntityToSentenceInfo()
        {
            try
            {
                Mapper.CreateMap<SentenceInfoEntity, SentenceInfo>()
                    //.ForMember(desc => desc.ChargeInfo, opts => opts.ResolveUsing<StringToChargeInfoResolver>().FromMember(src => src.ChargeInfoId))
                    .ForMember(desc => desc.FinePaidInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.FinePaidInd))
                    .ForMember(desc => desc.PenaltyPaidInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PenaltyPaidInd))
                    .ForMember(desc => desc.NatureOfSentence, opts => opts.ResolveUsing<CriminalNatureOfSentenceToStringResolver>().FromMember(src => src.NatureOfSentence))
                    .ForMember(desc => desc.StatusOfSentence, opts => opts.ResolveUsing<CriminalStatusOfSentenceToStringResolver>().FromMember(src => src.StatusOfSentence));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapSentenceInfoEntityToSentenceInfo", ex);
                throw;
            }
        }

        internal void MapTaxationClaimEntityToTaxationClaim()
        {
            try
            {
                Mapper.CreateMap<TaxationClaimEntity, TaxationClaim>()
                    .ForMember(dest => dest.IsCorrectInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCorrectInd))
                .ForMember(dest => dest.HRGTypeCode, opts => opts.ResolveUsing<MHRGTypeEntityToStringResolver>().FromMember(src => src.MHRGType));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapTaxationClaimEntityToTaxationClaim", ex);
                throw;
            }
        }

        internal void MapTaxationInfoEntityToTaxationInfo()
        {
            try
            {
                Mapper.CreateMap<TaxationInfoEntity, TaxationInfo>()
                    .ForMember(dest => dest.DirectorConsented, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.DirectorConsented))
                    .ForMember(dest => dest.IssueCOC, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IssueCOC))
                    .ForMember(dest => dest.PublicTrusteeConsented, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PublicTrusteeConsented))
                    .ForMember(dest => dest.WithdrawalFeeInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.WithdrawalFeeInd))
                    .ForMember(dest => dest.BFTCode, opts => opts.ResolveUsing<MBasisForTaxationEntityToStringResolver>().FromMember(src => src.MBasisForTaxation));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapTaxationInfoEntityToTaxationInfo", ex);
                throw;
            }
        }

        internal void MapWOEMOMSCTInfoEntityToWOEMOMSCTInfo()
        {
            try
            {
                Mapper.CreateMap<WOEMOMSCTInfoEntity, WOEMOMSCTInfo>()
                    .ForMember(dest => dest.IsExecOutOffHour, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsExecOutOffHour))
                    .ForMember(dest => dest.IsAuthorisedBailiff, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAuthorisedBailiff))
                    .ForMember(dest => dest.EmpActOrderType, opts => opts.ResolveUsing<WOEEmpActOrderTypeToStringResolver>().FromMember(src => src.EmpActOrderType))
                    .ForMember(dest => dest.OrderEnforced, opts => opts.ResolveUsing<OrderEnforcedTypesToStringResolver>().FromMember(src => src.OrderEnforced));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOEMOMSCTInfoEntityToWOEMOMSCTInfo", ex);
                throw;
            }
        }

        internal void MapWOSInfoEntityToWOSInfo()
        {
            try
            {
                Mapper.CreateMap<WOSInfoEntity, WOSInfo>()
                    .ForMember(dest => dest.AttachmentType, opts => opts.ResolveUsing<AttachmentTypeToStringResolver>().FromMember(src => src.AttachmentType))
                    .ForMember(dest => dest.ControlType, opts => opts.ResolveUsing<ControlTypeToStringResolver>().FromMember(src => src.ControlType))
                    .ForMember(dest => dest.IsInjunctionFiled, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInjunctionFiled))
                    .ForMember(dest => dest.IsManagedEWT, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsManagedEWT))
                    .ForMember(dest => dest.IsPartnerInFirm, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPartnerInFirm))
                    .ForMember(dest => dest.IsServeOutJDC, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsServeOutJDC))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.TotalLIQAwardedAmount, opts => opts.MapFrom(src => src.TotalLIQAwardedAmount))
                    .ForMember(dest => dest.TotalLIQClaimAmount, opts => opts.MapFrom(src => src.TotalLIQClaimAmount))
                    .ForMember(dest => dest.TotalUnLIQAwardedAmount, opts => opts.MapFrom(src => src.TotlaUnLIQAwardedAmount))
                    .ForMember(dest => dest.TotalUnLIQESTAmount, opts => opts.MapFrom(src => src.TotalUnLIQESTAmount))
                    .ForMember(dest => dest.WOSInfoId, opts => opts.MapFrom(src => src.WOSInfoId))
                    .ForMember(dest => dest.WritExpiryDate, opts => opts.MapFrom(src => src.WritExpiryDate))
                    .ForMember(dest => dest.IsPOHA, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPOHA));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOSInfoEntityToWOSInfo", ex);
                throw;
            }
        }

        internal void MapDCACAOriginatingCasePartyInfoEntityToDCACAOriginatingCasePartyInfo()
        {
            try
            {
                Mapper.CreateMap<DCACAOriginatingCasePartyInfoEntity, DCACAOriginatingCasePartyInfo>()
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDCACAOriginatingCasePartyInfoEntityToDCACAOriginatingCasePartyInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RARASInfoEntity"/> to <see cref="RARASInfo"/>.
        /// </summary>
        internal void MapRASInfoEntitytoRASInfo()
        {
            try
            {
                Mapper.CreateMap<RASInfoEntity, RASInfo>()
                    .ForMember(desc => desc.AppealAgainstJudOrder, opts => opts.MapFrom(src => src.AppealAgainstJudOrder))
                    .ForMember(desc => desc.AppealAgainstME, opts => opts.MapFrom(src => src.AppealAgainstME))
                    .ForMember(desc => desc.DateofOrder, opts => opts.MapFrom(src => src.DateofOrder))
                    .ForMember(desc => desc.IsEOTOrderObtained, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsEOTOrderObtained))
                    .ForMember(desc => desc.IsLOCOrderObtainted, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsLOCOrderObtainted))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.RASInfoId, opts => opts.MapFrom(src => src.RASInfoId))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.SeekDirectionInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SeekDirectionInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRARAInfoEntitytoRARAInfo", ex);
                throw;
            }
        }

        internal void MapBankruptcyDebtInfoEntityToBankruptcyDebtInfo()
        {
            try
            {
                Mapper.CreateMap<BankruptcyDebtInfoEntity, BankruptcyDebtInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBankruptcyDebtInfoEntityToBankruptcyDebtInfo", ex);
                throw;
            }
        }
        internal void MapPBPADetailEntityToPBPADetails()
        {
            try
            {
                Mapper.CreateMap<PBPADetailEntity, PBPADetails>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBPADetailEntityToPBPADetails", ex);
                throw;
            }
        }
        internal void MapPBSupNExmEntityToPBSupNExm()
        {
            try
            {
                Mapper.CreateMap<PBSupNExmEntity, PBSupNExm>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBSupNExmEntityToPBSupNExm", ex);
                throw;
            }
        }

        internal void MapPBAdminBondEntityToPBAdminBond()
        {
            try
            {
                Mapper.CreateMap<PBAdminBondEntity, PBAdminBond>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPBAdminBondEntityToPBAdminBond", ex);
                throw;
            }
        }
        internal void MapCaseRegisterEntityToCaseRegister()
        {
            try
            {
                Mapper.CreateMap<CaseRegisterEntity, CaseRegister>()
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.IsCurrentLife, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCurrentLife));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseRegisterEntityToCaseRegister", ex);
                throw;
            }
        }
        internal void MapCaseRegisterHistoryEntityToCaseRegisterHistory()
        {
            try
            {
                Mapper.CreateMap<CaseRegisterHistoryEntity, CaseRegisterHistory>()
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.IsCurrentLife, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCurrentLife));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseRegisterHistoryEntityToCaseRegisterHistory", ex);
                throw;
            }
        }
        internal void MapDashboardCaseMilestoneDetailEntityToDashboardCaseMilestoneDetail()
        {
            try
            {
                Mapper.CreateMap<DashboardCaseMilestoneDetailEntity, DashboardCaseMilestoneDetail>()
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDashboardCaseMilestoneDetailEntityToDashboardCaseMilestoneDetail", ex);
                throw;
            }
        }

        internal void MapDashboardCaseMilestoneDetailHistoryEntityToDashboardCaseMilestoneDetailHistory()
        {
            try
            {
                Mapper.CreateMap<DashboardCaseMilestoneDetailHistoryEntity, DashboardCaseMilestoneDetailHistory>()
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDashboardCaseMilestoneDetailHistoryEntityToDashboardCaseMilestoneDetailHistory", ex);
                throw;
            }
        }

        internal void MapCaveatInfoEntityToCaveatInfo()
        {
            try
            {
                Mapper.CreateMap<CaveatInfoEntity, CaveatInfo>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.CaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaveatInfoEntityToCaveatInfo", ex);
                throw;
            }
        }

        internal void MapJMChecklistInfoEntityToJMChecklistInfo()
        {
            try
            {
                Mapper.CreateMap<JMChecklistInfoEntity, JMChecklistInfo>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at JMChecklistInfoEntityToJMChecklistInfo", ex);
                throw;
            }
        }
        internal void MapJMOtherInfoEntityToJMOtherInfo()
        {
            try
            {
                Mapper.CreateMap<JMOtherInfoEntity, JMOtherInfo>()
                    .ForMember(dest => dest.caseinfoid, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.IsPCRCompliedWith, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPCRCompliedWith))
                    .ForMember(dest => dest.IsInfoSent, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInfoSent))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapJMOtherInfoEntityToJMOtherInfo", ex);
                throw;
            }
        }

        internal void MapDirectionDetailsEntityToDirectionDetails()
        {
            try
            {
                Mapper.CreateMap<DirectionDetailsEntity, DirectionDetails>()
                    .ForMember(dest => dest.CaseInfoID, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.CaseInfoID))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.SubCaseInfoID, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoID))
                    .ForMember(dest => dest.HRGID, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.HRGID))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapJMOtherInfoEntityToJMOtherInfo", ex);
                throw;
            }
        }
        #endregion Methods
    }
}