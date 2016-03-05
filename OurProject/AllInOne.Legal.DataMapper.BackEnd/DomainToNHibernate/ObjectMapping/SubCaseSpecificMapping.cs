#region Header

/*****************************************************************************************************
* Description : This file handles mapping for SubCase Specific related from Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/12/2010   		        Swaroop                  Created

*****************************************************************************************************/
// <summary>
// File: SubCaseSpecificMapping.cs
// Description: This file handles mapping for SubCase Specific related from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "SubCaseSpecificMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for SubCase Specific related from Domain objects to NHibernate entities.
    /// </summary>
    internal class SubCaseSpecificMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SubCaseSpecificMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method which maps the <see cref="AccountantsReportInfoEntity"/> to <see cref="AccountantsReportInfo"/>.
        /// </summary>
        internal void MapAccountantsReportInfoEntityToAccountantsReportInfo()
        {
            try
            {
                Mapper.CreateMap<AccountantsReportInfoEntity, AccountantsReportInfo>()
                    .ForMember(dest => dest.CertainTrivialBreaches, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CertainTrivialBreaches))
                    .ForMember(dest => dest.DoesAcctRptComplyS73LPA, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.DoesAcctRptComplyS73LPA))
                    .ForMember(dest => dest.DoesHaveDiffInComparision, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.DoesHaveDiffInComparision))
                    .ForMember(dest => dest.DoesAcctRptComplyS73LPA, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.DoesAcctRptComplyS73LPA))
                    .ForMember(dest => dest.MatterSetOutFirstSection, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MatterSetOutFirstSection))
                    .ForMember(dest => dest.MatterSetOutSecondSection, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MatterSetOutSecondSection));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapAccountantsReportInfoEntityToAccountantsReportInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ServiceOfDocDocStatusHistoryEntity"/> to <see cref="ServiceOfDocDocStatusHistory"/>.
        /// </summary>
        internal void MapADMWAInfoEntityToADMWAInfo()
        {
            try
            {
                Mapper.CreateMap<ADMWAInfoEntity, ADMWAInfo>()
                    .ForMember(dest => dest.ADMWAInfoId, opts => opts.MapFrom(src => src.ADMWAInfoId))
                    .ForMember(dest => dest.AICID, opts => opts.MapFrom(src => src.AICID))

                    .ForMember(dest => dest.DCPAICID, opts => opts.MapFrom(src => src.DCPAICID))
                    .ForMember(dest => dest.WAType, opts => opts.ResolveUsing<TypeOfArrestToStringResolver>().FromMember(src => src.WAType))
                    .ForMember(dest => dest.IsExecOutOffHour, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsExecOutOffHour));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapServiceOfDocDocStatusHistoryEntityToServiceOfDocDocStatusHistory", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="AreaOfLegalPracticeEntity"/> to <see cref="AreaOfLegalPractice"/>.
        /// </summary>
        internal void MapAreaOfLegalPracticeEntityToAreaOfLegalPractice()
        {
            try
            {
                Mapper.CreateMap<AreaOfLegalPracticeEntity, AreaOfLegalPractice>()
                .ForMember(desc => desc.IsForeignLawPractice, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsForeignLawPractice));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapAreaOfLegalPracticeEntityToAreaOfLegalPractice", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LPOthLegalOrgAddrInfoEntity"/> to <see cref="LPOthLegalOrgAddrInfo"/>.
        /// </summary>
        internal void MapLPOthLegalOrgAddrInfoEntityToLPOthLegalOrgAddrInfo()
        {
            try
            {
                Mapper.CreateMap<LPOthLegalOrgAddrInfoEntity, LPOthLegalOrgAddrInfo>()

                    .ForMember(desc => desc.AddrType, opt => opt.ResolveUsing<AddressTypeToStringResolver>().FromMember(src => src.AddrType))
                    .ForMember(desc => desc.FormatInd, opt => opt.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLPOthLegalOrgAddrInfoEntityToLPOthLegalOrgAddrInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LPOthLegalOrgInfoEntity"/> to <see cref="LPOthLegalOrgInfo"/>.
        /// </summary>
        internal void MapLPOthLegalOrgInfoEntityToLPOthLegalOrgInfo()
        {
            try
            {
                Mapper.CreateMap<LPOthLegalOrgInfoEntity, LPOthLegalOrgInfo>()
                    .ForMember(dest => dest.ContactTypeInd, opts => opts.ResolveUsing<ContactTypeToStringResolver>().FromMember(src => src.ContactTypeInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLPOthLegalOrgInfoEntityToLPOthLegalOrgInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PCInfoEntity"/> to <see cref="PCInfo"/>.
        /// </summary>
        internal void MapPCInfoEntityToPCInfo()
        {
            try
            {
                Mapper.CreateMap<PCInfoEntity, PCInfo>()
                    //.ForMember(desc => desc.LawFirm, opt => opt.ResolveUsing<StringToLawFirmResolver>().FromMember(src => src.LFID))
                    .ForMember(desc => desc.AnyAdvrOrdersInForeignJuri, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.AnyAdvrOrdersInForeignJuri))
                    .ForMember(desc => desc.DoesPracticeIncludeLitigation, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.DoesPracticeIncludeLitigation))
                    .ForMember(desc => desc.FinalConfirmation, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.FinalConfirmation))
                    .ForMember(desc => desc.HasSection251bSatisfied, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasSection251bSatisfied))
                    .ForMember(desc => desc.HasSection251cSatisfied, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasSection251cSatisfied))
                    .ForMember(desc => desc.HasSection251dSatisfied, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasSection251dSatisfied))
                    .ForMember(desc => desc.IDoNotNeedToVote, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IDoNotNeedToVote))
                    .ForMember(desc => desc.IsAreaOfLPDisclosed, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAreaOfLPDisclosed))
                    .ForMember(desc => desc.IsConditionalPC, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsConditionalPC))
                    .ForMember(desc => desc.IsDisqualifiedBySection261, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsDisqualifiedBySection261))
                    .ForMember(desc => desc.IsDisqualifiedBySection262, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsDisqualifiedBySection262))
                    .ForMember(desc => desc.IsDisqualifiedBySection263, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsDisqualifiedBySection263))
                    .ForMember(desc => desc.IsNotHoldClientMoney, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsNotHoldClientMoney))
                    .ForMember(desc => desc.IsNotPeriodOfFiveYears, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsNotPeriodOfFiveYears))
                    .ForMember(desc => desc.IsOnRollOfAdvsSolicitors, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsOnRollOfAdvsSolicitors))
                    .ForMember(desc => desc.IsPCPossessedLPA261, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPCPossessedLPA261))
                    .ForMember(desc => desc.IsPeriodOfFiveYears, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPeriodOfFiveYears))
                    .ForMember(desc => desc.IsProfIndemnityInsur, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsProfIndemnityInsur))
                    .ForMember(desc => desc.IsSatisfiedSec130N, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSatisfiedSec130N))
                    .ForMember(desc => desc.IsSection25AApplicable, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSection25AApplicable))
                    .ForMember(desc => desc.IsVoted, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsVoted))
                    .ForMember(desc => desc.LegalOfficerExperience, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.LegalOfficerExperience))
                    .ForMember(desc => desc.LocumSolicitorPosition, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.LocumSolicitorPosition))
                    .ForMember(desc => desc.OrgAccReportSection73OfLPA, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.OrgAccReportSection73OfLPA))
                    .ForMember(desc => desc.QualifiedForPractice, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.QualifiedForPractice))
                    .ForMember(desc => desc.SALfeePaidStatus, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SALfeePaidStatus))
                    .ForMember(desc => desc.LawSocCompFundStatus, opts => opts.ResolveUsing<AASPCPaidStatusToStringResolver>().FromMember(src => src.LawSocCompFundStatus))
                    .ForMember(desc => desc.LawSocAnnualSubPaidStatus, opts => opts.ResolveUsing<AASPCPaidStatusToStringResolver>().FromMember(src => src.LawSocAnnualSubPaidStatus))
                    .ForMember(desc => desc.LawSocVoteInfo, opts => opts.ResolveUsing<AASPCVoteStatusToStringResolver>().FromMember(src => src.LawSocVoteInfo))
                    .ForMember(desc => desc.SALfeePaidStatus, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SALfeePaidStatus))
                    .ForMember(desc => desc.IsRequiredVote, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsRequiredVote))
                    .ForMember(desc => desc.ApptOrgType, opts => opts.ResolveUsing<AppointmentOrganisationTypeToStringResolver>().FromMember(src => src.ApptOrgType))
                     .ForMember(desc => desc.PbnoTrg, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PbnoTrg))
                    .ForMember(desc => desc.PbnoMentor, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PbnoMentor))
                    .ForMember(desc => desc.PbnoScheme, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PbnoScheme))
                    .ForMember(desc => desc.PbnoBillableHrs, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PbnoBillableHrs))
                    .ForMember(desc => desc.PbnoOppurtunity, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PbnoOppurtunity))
                    .ForMember(desc => desc.PbnoQualified, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PbnoQualified))
                    .ForMember(desc => desc.PbnoNotime, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PbnoNotime))
                    .ForMember(desc => desc.PbnoLegalPractice, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PbnoLegalPractice))
                    .ForMember(desc => desc.PbnoHighbillable, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PbnoHighbillable))
                    .ForMember(desc => desc.PbnoMoreothers, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PbnoMoreothers))
                    .ForMember(desc => desc.Pbnochq, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.Pbnochq))
                    .ForMember(desc => desc.PbnoLawsoc, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PbnoLawsoc))
                    .ForMember(desc => desc.CPDReq, opt => opt.ResolveUsing<CPDRequirementsToStringResolver>().FromMember(src => src.CPDReq))
                    .ForMember(desc => desc.Sec73LPA, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.Sec73LPA))
                    .ForMember(desc => desc.Sec73Trivual, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.Sec73Trivual))
                    .ForMember(desc => desc.Sec731stSection, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.Sec731stSection))
                    .ForMember(desc => desc.Sec732ndSection, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.Sec732ndSection))
                    .ForMember(desc => desc.AccRep41f, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.AccRep41f))
                    .ForMember(desc => desc.LSGIRORPTST, opt => opt.ResolveUsing<YesNoMandatoryToStringResolver>().FromMember(src => src.LSGIRORPTST))
                    .ForMember(desc => desc.LSHCRPTST, opts => opts.ResolveUsing<YesNoMandatoryToStringResolver>().FromMember(src => src.LSHCRPTST))
                    .ForMember(desc => desc.PbnoencOthers, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PbnoencOthers));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPCInfoEntityToPCInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ServiceOfDocDocStatusHistoryEntity"/> to <see cref="ServiceOfDocDocStatusHistory"/>.
        /// </summary>
        internal void MapServiceOfDocDocStatusHistoryEntityToServiceOfDocDocStatusHistory()
        {
            try
            {
                Mapper.CreateMap<ServiceOfDocDocStatusHistoryEntity, ServiceOfDocDocStatusHistory>()
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapServiceOfDocDocStatusHistoryEntityToServiceOfDocDocStatusHistory", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ServiceOfDocDocumentEntityEntity"/> to <see cref="ServiceOfDocDocument"/>.
        /// </summary>
        internal void MapServiceOfDocDocumentEntityToServiceOfDocDocument()
        {
            try
            {
                Mapper.CreateMap<ServiceOfDocDocumentEntity, ServiceOfDocDocument>()
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapServiceOfDocDocumentEntityToServiceOfDocDocument", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ServiceOfDocInfoDetailEntity"/> to <see cref="ServiceOfDocInfoDetail"/>.
        /// </summary>
        internal void MapServiceOfDocInfoDetailEntityToServiceOfDocInfoDetail()
        {
            try
            {
                Mapper.CreateMap<ServiceOfDocInfoDetailEntity, ServiceOfDocInfoDetail>()
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapServiceOfDocInfoDetailEntityToServiceOfDocInfoDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="SServiceOfDocInfoEntity"/> to <see cref="ServiceOfDocInfo"/>.
        /// </summary>
        internal void MapServiceOfDocInfoEntityToServiceOfDocInfo()
        {
            try
            {
                Mapper.CreateMap<ServiceOfDocInfoEntity, ServiceOfDocInfo>()
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(desc => desc.ServiceSatus, opts => opts.ResolveUsing<ServiceStatusToStringResolver>().FromMember(src => src.ServiceStatus))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapSetDownInfoEntityToSetDownInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="SetDownInfoEntity"/> to <see cref="SetDownInfo"/>.
        /// </summary>
        internal void MapSetDownInfoEntityToSetDownInfo()
        {
            try
            {
                Mapper.CreateMap<SetDownInfoEntity, SetDownInfo>()
                    .ForMember(desc => desc.IsCertExcAEICFiled, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCertExcAEICFiled))
                    .ForMember(desc => desc.IsHearingFeePayable, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsHearingFeePayable))
                    .ForMember(desc => desc.IsOrder25R8Complied, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsOrder25R8Complied))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.NoOfHRGDays, opts => opts.MapFrom(src => src.NoOfHRGDays))
                    .ForMember(desc => desc.SDPursuantTo, opts => opts.ResolveUsing<SetDownPursuantToStringResolver>().FromMember(src => src.SDPursuantTo))
                    .ForMember(desc => desc.SetDownId, opts => opts.MapFrom(src => src.SetDownId))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapSetDownInfoEntityToSetDownInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="AccountantsReportInfoEntity"/> to <see cref="AccountantsReportInfo"/>.
        /// </summary>
        internal void MapNOCInfoEntityToNOCInfo()
        {
            try
            {
                Mapper.CreateMap<NOCInfoEntity, NOCInfo>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.CeasedDate, opts => opts.MapFrom(src => src.CeasedDate))
                    .ForMember(dest => dest.CeasedRemarks, opts => opts.MapFrom(src => src.CeasedRemarks))
                    .ForMember(dest => dest.CertificateRegNumber, opts => opts.MapFrom(src => src.CertificateRegNumber))
                    .ForMember(dest => dest.CertificateRegPeriodFrom, opts => opts.MapFrom(src => src.CertificateRegPeriodFrom))
                    .ForMember(dest => dest.CertificateRegPeriodTo, opts => opts.MapFrom(src => src.CertificateRegPeriodTo))
                    .ForMember(dest => dest.CertificateRegYear, opts => opts.MapFrom(src => src.CertificateRegYear))
                    .ForMember(dest => dest.DOCID, opts => opts.MapFrom(src => src.DOCID))
                    .ForMember(dest => dest.IsCeased, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCeased))
                    .ForMember(dest => dest.IsDisqualifiedR26, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsDisqualifiedR26))
                    .ForMember(dest => dest.IsDisqualifiedRemarks, opts => opts.MapFrom(src => src.IsDisqualifiedRemarks))
                    .ForMember(dest => dest.PCCERT_IND, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PCCERT_IND))
                   .ForMember(dest => dest.IsPresentlyEmployed, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPresentlyEmployeed))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.SubCaseInfoID, opts => opts.MapFrom(src => src.SubCaseInfoID));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapNOCInfoEntityToNOCInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PCInfoAccReportEntity"/> to <see cref="PCInfoAccReport"/>.
        /// </summary>
        internal void MapPCInfoAccReportEntityToPCInfoAccReport()
        {
            try
            {
                Mapper.CreateMap<PCInfoAccReportEntity, PCInfoAccReport>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPCInfoAccReportEntityToPCInfoAccReport", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="AccountantsReportInfoEntity"/> to <see cref="AccountantsReportInfo"/>.
        /// </summary>
        internal void MapVoteInfoEntityToVoteInfo()
        {
            try
            {
                Mapper.CreateMap<VoteInfoEntity, VoteInfo>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
              .ForMember(dest => dest.ReqExemVoting, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ReqExemVoting))
                    .ForMember(dest => dest.PenaltyPaidStatus, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PenaltyPaidStatus))
                    .ForMember(dest => dest.VoteInfoValue, opts => opts.ResolveUsing<VoteInfoValueToStringResolver>().FromMember(src => src.VoteInfoValue))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));


            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapVoteInfoEntityToVoteInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="AccountantsReportInfoEntity"/> to <see cref="AccountantsReportInfo"/>.
        /// </summary>
        internal void MapVoteInfoDeltaEntityToVoteInfoDelta()
        {
            try
            {
                Mapper.CreateMap<VoteInfoDeltaEntity, VoteInfoDelta>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
              .ForMember(dest => dest.ReqExemVoting, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ReqExemVoting))
                    .ForMember(dest => dest.PenaltyPaidStatus, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PenaltyPaidStatus))
                    .ForMember(dest => dest.VoteInfoDeltaValue, opts => opts.ResolveUsing<VoteInfoValueToStringResolver>().FromMember(src => src.VoteInfoDeltaValue))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));


            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapVoteInfoDeltaEntityToVoteInfoDelta", ex);
                throw;
            }
        }

        internal void MapDashBoardSubCaseMilestoneDetailEntityToDashboardSubCaseMilestoneDetail()
        {
            try
            {
                Mapper.CreateMap<DashboardSubCaseMilestoneDetailEntity, DashboardSubCaseMilestoneDetail>()
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDashboardCaseMilestoneDetailEntityToDashboardCaseMilestoneDetail", ex);
                throw;
            }
        }

        internal void MapDashBoardSubCaseMilestoneDetailHistoryEntityToDashBoardSubCaseMilestoneDetailHistory()
        {
            try
            {
                Mapper.CreateMap<DashboardSubCaseMilestoneDetailHistoryEntity, DashboardSubCaseMilestoneDetailHistory>()
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDashBoardSubCaseMilestoneDetailHistoryEntityToDashBoardSubCaseMilestoneDetailHistory", ex);
                throw;
            }
        }
        #endregion Methods
    }
}