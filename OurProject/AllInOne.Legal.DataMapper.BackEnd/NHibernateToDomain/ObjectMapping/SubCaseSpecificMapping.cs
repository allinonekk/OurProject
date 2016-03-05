#region Header

/*****************************************************************************************************
* Description : This file handles mapping for SubCaseSpecific from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/12/2010   		        Swaroop                 Created

*****************************************************************************************************/
// <summary>
// File: SubCaseSpecificMapping.cs
// Description: This file handles mapping for SubCaseSpecific from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "SubCaseSpecificMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for SubCaseSpecific from NHibernate entities to Domain objects.
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
        /// Method which maps the <see cref="AccountantsReportInfo"/> to <see cref="AccountantsReportInfoEntity"/>.
        /// </summary>
        internal void MapAccountantsReportInfoToAccountantsReportInfoEntity()
        {
            try
            {
                Mapper.CreateMap<AccountantsReportInfo, AccountantsReportInfoEntity>()
                    .ForMember(dest => dest.CertainTrivialBreaches, opts => opts.MapFrom(src => src.CertainTrivialBreaches))
                    .ForMember(dest => dest.DoesAcctRptComplyS73LPA, opts => opts.MapFrom(src => src.DoesAcctRptComplyS73LPA))
                    .ForMember(dest => dest.DoesHaveDiffInComparision, opts => opts.MapFrom(src => src.DoesHaveDiffInComparision))
                    .ForMember(dest => dest.DoesAcctRptComplyS73LPA, opts => opts.MapFrom(src => src.DoesAcctRptComplyS73LPA))
                    .ForMember(dest => dest.MatterSetOutFirstSection, opts => opts.MapFrom(src => src.MatterSetOutFirstSection))
                    .ForMember(dest => dest.MatterSetOutSecondSection, opts => opts.MapFrom(src => src.MatterSetOutSecondSection));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapAccountantsReportInfotoAccountantsReportInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ADMWAInfo"/> to <see cref="ADMWAInfoEntity"/>.
        /// </summary>
        internal void MapADMWAInfoToADMWAInfoEntity()
        {
            try
            {
                Mapper.CreateMap<ADMWAInfo, ADMWAInfoEntity>()
                    .ForMember(dest => dest.ADMWAInfoId, opts => opts.MapFrom(src => src.ADMWAInfoId))
                    .ForMember(dest => dest.AICID, opts => opts.MapFrom(src => src.AICID))
                    .ForMember(dest => dest.DCPAICID, opts => opts.MapFrom(src => src.DCPAICID))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.WAType, opts => opts.MapFrom(src => src.WAType))
                    .ForMember(dest => dest.IsExecOutOffHour, opts => opts.MapFrom(src => src.IsExecOutOffHour));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapADMWAInfoToADMWAInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="AreaOfLegalPractice"/> to <see cref="AreaOfLegalPracticeEntity"/>.
        /// </summary>
        internal void MapAreaOfLegalPracticetoAreaOfLegalPracticeEntity()
        {
            try
            {
                Mapper.CreateMap<AreaOfLegalPractice, AreaOfLegalPracticeEntity>()
                .ForMember(desc => desc.IsForeignLawPractice, opt => opt.MapFrom(src => src.IsForeignLawPractice));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapAreaOfLegalPracticetoAreaOfLegalPracticeEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LPOthLegalOrgAddrInfo"/> to <see cref="LPOthLegalOrgAddrInfoEntity"/>.
        /// </summary>
        internal void MapLPOthLegalOrgAddrInfotoLPOthLegalOrgAddrInfoEntity()
        {
            try
            {
                Mapper.CreateMap<LPOthLegalOrgAddrInfo, LPOthLegalOrgAddrInfoEntity>()
                  .ForMember(desc => desc.AddrType, opt => opt.MapFrom(src => src.AddrType))
                    .ForMember(desc => desc.FormatInd, opt => opt.MapFrom(src => src.FormatInd));

                ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLPOthLegalOrgAddrInfotoLPOthLegalOrgAddrInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LPOthLegalOrgInfo"/> to <see cref="LPOthLegalOrgInfoEntity"/>.
        /// </summary>
        internal void MapLPOthLegalOrgInfotoLPOthLegalOrgInfoEntity()
        {
            try
            {
                Mapper.CreateMap<LPOthLegalOrgInfo, LPOthLegalOrgInfoEntity>()
                    .ForMember(dest => dest.ContactTypeInd, opts => opts.MapFrom(src => src.ContactTypeInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLPOthLegalOrgInfotoLPOthLegalOrgInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PaymentInDocDetail"/> to <see cref="PaymentInDocDetailEntity"/>.
        /// </summary>
        internal void MapPaymentInDocDetailToPaymentInDocDetailEntity()
        {
            try
            {
                Mapper.CreateMap<PaymentInDocDetail, PaymentInDocDetailEntity>()
                    .ForMember(desc => desc.Amount, opts => opts.MapFrom(src => src.Amount))
                    .ForMember(desc => desc.AmountSGD, opts => opts.MapFrom(src => src.AmountSGD))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.MCurrency, opts => opts.MapFrom(src => src.MCurrency))
                    .ForMember(desc => desc.PayingInType, opts => opts.MapFrom(src => src.PayingInType))
                    .ForMember(desc => desc.PaymentInId, opts => opts.MapFrom(src => src.PaymentInId))
                    .ForMember(desc => desc.PaymentInReason, opts => opts.MapFrom(src => src.PaymentInReason))
                    .ForMember(desc => desc.Reason, opts => opts.MapFrom(src => src.Reason))
                    .ForMember(desc => desc.RefOrderDetailId, opts => opts.MapFrom(src => src.RefOrderDetailId))
                    .ForMember(desc => desc.RuleNo, opts => opts.MapFrom(src => src.RuleNo))
                    .ForMember(desc => desc.RuleOrderNo, opts => opts.MapFrom(src => src.RuleOrderNo))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPaymentInDocDetailToPaymentInDocDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PaymentInDocFSDetail"/> to <see cref="PaymentInDocFSDetailEntity"/>.
        /// </summary>
        internal void MapPaymentInDocFSDetailToPaymentInDocFSDetailEntity()
        {
            try
            {
                Mapper.CreateMap<PaymentInDocFSDetail, PaymentInDocFSDetailEntity>()
                    .ForMember(desc => desc.Amount, opts => opts.MapFrom(src => src.Amount))
                    .ForMember(desc => desc.AmountSGD, opts => opts.MapFrom(src => src.AmountSGD))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.MCurrency, opts => opts.MapFrom(src => src.MCurrency))
                    .ForMember(desc => desc.Particulars, opts => opts.MapFrom(src => src.Particulars))
                    .ForMember(desc => desc.PaymentInFSID, opts => opts.MapFrom(src => src.PaymentInFSId))
                    .ForMember(desc => desc.PersonsDirected, opts => opts.MapFrom(src => src.PersonsDirected))
                    .ForMember(desc => desc.Securities, opts => opts.MapFrom(src => src.Securities))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
                //.ForMember(desc => desc.PaymentInId, opts => opts.MapFrom(src => src.PaymentInId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPaymentInDocFSDetailToPaymentInDocFSDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PaymentOutDocDetail"/> to <see cref="PaymentOutDocDetailEntity"/>.
        /// </summary>
        internal void MapPaymentOutDocDetailToPaymentOutDocDetailEntity()
        {
            try
            {
                Mapper.CreateMap<PaymentOutDocDetail, PaymentOutDocDetailEntity>()
                    .ForMember(desc => desc.Amount, opts => opts.MapFrom(src => src.Amount))
                    .ForMember(desc => desc.Designation, opts => opts.MapFrom(src => src.Designation))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.PartyName, opts => opts.MapFrom(src => src.PartyName))
                    .ForMember(desc => desc.PaymentOutID, opts => opts.MapFrom(src => src.PaymentOutId))
                    .ForMember(desc => desc.POReason, opts => opts.MapFrom(src => src.POReason))
                    .ForMember(desc => desc.RefOrderDetailId, opts => opts.MapFrom(src => src.RefOrderDetailId))
                    .ForMember(desc => desc.Remarks, opts => opts.MapFrom(src => src.Remarks))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPaymentOutDocDetailToPaymentOutDocDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PaymentOutPayInDetail"/> to <see cref="PaymentOutPayInDetailEntity"/>.
        /// </summary>
        internal void MapPaymentOutPayInDetailToPaymentOutPayInDetailEntity()
        {
            try
            {
                Mapper.CreateMap<PaymentOutPayInDetail, PaymentOutPayInDetailEntity>()
                    .ForMember(desc => desc.AmountOut, opts => opts.Ignore())
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.MCourtType, opts => opts.MapFrom(src => src.MCourtType))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.PaymentInId, opts => opts.MapFrom(src => src.PaymentInId))
                    .ForMember(desc => desc.PaymentOutID, opts => opts.MapFrom(src => src.PaymentOutId))
                    .ForMember(desc => desc.PaymentOutInID, opts => opts.MapFrom(src => src.PaymentOutInId))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.IsBackEndUserAdded, opts => opts.MapFrom(src => src.IsBackEndUserAdded));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPaymentOutPayInDetailToPaymentOutPayInDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PCInfo"/> to <see cref="PCInfoEntity"/>.
        /// </summary>
        internal void MapPCInfoToPCInfoEntity()
        {
            try
            {
                Mapper.CreateMap<PCInfo, PCInfoEntity>()
                    //.ForMember(desc => desc.LFID, opt => opt.MapFrom(src => src.LawFirm.LFID))
                    .ForMember(desc => desc.AnyAdvrOrdersInForeignJuri, opt => opt.MapFrom(src => src.AnyAdvrOrdersInForeignJuri))
                    .ForMember(desc => desc.DoesPracticeIncludeLitigation, opt => opt.MapFrom(src => src.DoesPracticeIncludeLitigation))
                    .ForMember(desc => desc.FinalConfirmation, opt => opt.MapFrom(src => src.FinalConfirmation))
                    .ForMember(desc => desc.HasSection251bSatisfied, opt => opt.MapFrom(src => src.HasSection251bSatisfied))
                    .ForMember(desc => desc.HasSection251cSatisfied, opt => opt.MapFrom(src => src.HasSection251cSatisfied))
                    .ForMember(desc => desc.HasSection251dSatisfied, opt => opt.MapFrom(src => src.HasSection251dSatisfied))
                    .ForMember(desc => desc.IDoNotNeedToVote, opt => opt.MapFrom(src => src.IDoNotNeedToVote))
                    .ForMember(desc => desc.IsAreaOfLPDisclosed, opt => opt.MapFrom(src => src.IsAreaOfLPDisclosed))
                    .ForMember(desc => desc.IsConditionalPC, opt => opt.MapFrom(src => src.IsConditionalPC))
                    .ForMember(desc => desc.IsDisqualifiedBySection261, opt => opt.MapFrom(src => src.IsDisqualifiedBySection261))
                    .ForMember(desc => desc.IsDisqualifiedBySection262, opt => opt.MapFrom(src => src.IsDisqualifiedBySection262))
                    .ForMember(desc => desc.IsDisqualifiedBySection263, opt => opt.MapFrom(src => src.IsDisqualifiedBySection263))
                    .ForMember(desc => desc.IsNotHoldClientMoney, opt => opt.MapFrom(src => src.IsNotHoldClientMoney))
                    .ForMember(desc => desc.IsNotPeriodOfFiveYears, opt => opt.MapFrom(src => src.IsNotPeriodOfFiveYears))
                    .ForMember(desc => desc.IsOnRollOfAdvsSolicitors, opt => opt.MapFrom(src => src.IsOnRollOfAdvsSolicitors))
                    .ForMember(desc => desc.IsPCPossessedLPA261, opt => opt.MapFrom(src => src.IsPCPossessedLPA261))
                    .ForMember(desc => desc.IsPeriodOfFiveYears, opt => opt.MapFrom(src => src.IsPeriodOfFiveYears))
                    .ForMember(desc => desc.IsProfIndemnityInsur, opt => opt.MapFrom(src => src.IsProfIndemnityInsur))
                    .ForMember(desc => desc.IsSatisfiedSec130N, opt => opt.MapFrom(src => src.IsSatisfiedSec130N))
                    .ForMember(desc => desc.IsSection25AApplicable, opt => opt.MapFrom(src => src.IsSection25AApplicable))
                    .ForMember(desc => desc.IsVoted, opt => opt.MapFrom(src => src.IsVoted))
                    .ForMember(desc => desc.LegalOfficerExperience, opt => opt.MapFrom(src => src.LegalOfficerExperience))
                    .ForMember(desc => desc.LocumSolicitorPosition, opt => opt.MapFrom(src => src.LocumSolicitorPosition))
                    .ForMember(desc => desc.OrgAccReportSection73OfLPA, opt => opt.MapFrom(src => src.OrgAccReportSection73OfLPA))
                    .ForMember(desc => desc.QualifiedForPractice, opt => opt.MapFrom(src => src.QualifiedForPractice))
                    .ForMember(desc => desc.SALfeePaidStatus, opt => opt.MapFrom(src => src.SALfeePaidStatus))
                    .ForMember(desc => desc.LawSocAnnualSubPaidStatus, opt => opt.MapFrom(src => src.LawSocAnnualSubPaidStatus))
                    .ForMember(desc => desc.LawSocCompFundStatus, opt => opt.MapFrom(src => src.LawSocCompFundStatus))
                    .ForMember(desc => desc.LawSocVoteInfo, opt => opt.MapFrom(src => src.LawSocVoteInfo))
                    .ForMember(desc => desc.IsRequiredVote, opts => opts.MapFrom(src => src.IsRequiredVote))
                    .ForMember(desc => desc.ApptOrgType, opts => opts.MapFrom(src => src.ApptOrgType))
                     .ForMember(desc => desc.ProBonoStateHours, opt => opt.MapFrom(src => src.ProBonoStateHours))
                    .ForMember(desc => desc.PbnoTrg, opt => opt.MapFrom(src => src.PbnoTrg))
                    .ForMember(desc => desc.PbnoMentor, opt => opt.MapFrom(src => src.PbnoMentor))
                    .ForMember(desc => desc.PbnoScheme, opt => opt.MapFrom(src => src.PbnoScheme))
                    .ForMember(desc => desc.PbnoBillableHrs, opt => opt.MapFrom(src => src.PbnoBillableHrs))
                    .ForMember(desc => desc.PbnoencOthersremarks, opt => opt.MapFrom(src => src.PbnoencOthersremarks))
                    .ForMember(desc => desc.PbnoOppurtunity, opt => opt.MapFrom(src => src.PbnoOppurtunity))
                    .ForMember(desc => desc.PbnoQualified, opt => opt.MapFrom(src => src.PbnoQualified))
                    .ForMember(desc => desc.PbnoNotime, opt => opt.MapFrom(src => src.PbnoNotime))
                    .ForMember(desc => desc.PbnoLegalPractice, opt => opt.MapFrom(src => src.PbnoLegalPractice))
                    .ForMember(desc => desc.PbnoHighbillable, opt => opt.MapFrom(src => src.PbnoHighbillable))
                    .ForMember(desc => desc.PbnoMoreothers, opt => opt.MapFrom(src => src.PbnoMoreothers))
                    .ForMember(desc => desc.PbnoMorehrsOthers, opt => opt.MapFrom(src => src.PbnoMorehrsOthers))
                    .ForMember(desc => desc.PbnoLegalservices, opt => opt.MapFrom(src => src.PbnoLegalservices))
                    .ForMember(desc => desc.PbnoDonations, opt => opt.MapFrom(src => src.PbnoDonations))
                    .ForMember(desc => desc.Pbnochq, opt => opt.MapFrom(src => src.Pbnochq))
                    .ForMember(desc => desc.PbnoLawsoc, opt => opt.MapFrom(src => src.PbnoLawsoc))
                    .ForMember(desc => desc.CPDReq, opt => opt.MapFrom(src => src.CPDReq))
                    .ForMember(desc => desc.Sec73LPA, opt => opt.MapFrom(src => src.Sec73LPA))
                    .ForMember(desc => desc.Sec73Trivual, opts => opts.MapFrom(src => src.Sec73Trivual))
                    .ForMember(desc => desc.Sec731stSection, opts => opts.MapFrom(src => src.Sec731stSection))
                    .ForMember(desc => desc.Sec732ndSection, opts => opts.MapFrom(src => src.Sec732ndSection))
                    .ForMember(desc => desc.AccRep41f, opts => opts.MapFrom(src => src.AccRep41f))
                    .ForMember(desc => desc.LSGIRORPTST, opts => opts.MapFrom(src => src.LSGIRORPTST))
                    .ForMember(desc => desc.LSHCRPTST, opts => opts.MapFrom(src => src.LSHCRPTST));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPCInfoToPCInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RARASInfo"/> to <see cref="RARASInfoEntity"/>.
        /// </summary>
        internal void MapRARASInfoToRARASInfoEntity()
        {
            try
            {
                Mapper.CreateMap<RARASInfo, RARASInfoEntity>()
                    .ForMember(dest => dest.AppealAgainstJudOrder, opts => opts.MapFrom(src => src.AppealAgainstJudOrder))
                    .ForMember(dest => dest.AppealAgainstME, opts => opts.MapFrom(src => src.AppealAgainstME))
                    .ForMember(dest => dest.DateofOrder, opts => opts.MapFrom(src => src.DateofOrder))
                    .ForMember(dest => dest.IsEOTOrderObtained, opts => opts.MapFrom(src => src.IsEOTOrderObtained))
                    .ForMember(dest => dest.IsLOCOrderObtainted, opts => opts.MapFrom(src => src.IsLOCOrderObtainted))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.RARASInfoId, opts => opts.MapFrom(src => src.RARASInfoId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.SeekDirectionInd, opts => opts.MapFrom(src => src.SeekDirectionInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRARASInfoToRARASInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ServiceOfDocDocStatusHistory"/> to <see cref="ServiceOfDocDocStatusHistoryEntity"/>.
        /// </summary>
        internal void MapServiceOfDocDocStatusHistoryToServiceOfDocDocStatusHistoryEntity()
        {
            try
            {
                Mapper.CreateMap<ServiceOfDocDocStatusHistory, ServiceOfDocDocStatusHistoryEntity>()
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.MServeStatus, opts => opts.MapFrom(src => src.MServeStatus))
                    .ForMember(desc => desc.RemainderMessage, opts => opts.MapFrom(src => src.RemainderMessage))
                    .ForMember(desc => desc.RemainderSubject, opts => opts.MapFrom(src => src.RemainderSubject))
                    .ForMember(desc => desc.RemainderTo, opts => opts.MapFrom(src => src.RemainderTo))
                    .ForMember(desc => desc.ServiceOfDocDocStatusId, opts => opts.MapFrom(src => src.ServiceOfDocDocStatusId))
                    .ForMember(desc => desc.ServiceOfDocInfoId, opts => opts.MapFrom(src => src.ServiceOfDocInfoId))
                    .ForMember(desc => desc.StatusDate, opts => opts.MapFrom(src => src.StatusDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapServiceOfDocDocStatusHistoryToServiceOfDocDocStatusHistoryEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ServiceOfDocDocument"/> to <see cref="ServiceOfDocDocumentEntity"/>.
        /// </summary>
        internal void MapServiceOfDocDocumentToServiceOfDocDocumentEntity()
        {
            try
            {
                Mapper.CreateMap<ServiceOfDocDocument, ServiceOfDocDocumentEntity>()
                    .ForMember(desc => desc.CreatedBy, opts => opts.MapFrom(src => src.CreatedBy))
                    .ForMember(desc => desc.CreatedDate, opts => opts.MapFrom(src => src.CreatedDate))
                    .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.ServiceOfDocDocStatusId, opts => opts.MapFrom(src => src.ServiceOfDocDocStatusId))
                    .ForMember(desc => desc.ServiceOfDocInfoDetailId, opts => opts.MapFrom(src => src.ServiceOfDocInfoDetailId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapServiceOfDocDocumentToServiceOfDocDocumentEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ServiceOfDocInfoDetail"/> to <see cref="ServiceOfDocInfoDetailEntity"/>.
        /// </summary>
        internal void MapServiceOfDocInfoDetailToServiceOfDocInfoDetailEntity()
        {
            try
            {
                Mapper.CreateMap<ServiceOfDocInfoDetail, ServiceOfDocInfoDetailEntity>()
                    .ForMember(desc => desc.Addr1, opts => opts.MapFrom(src => src.Addr1))
                    .ForMember(desc => desc.Addr2, opts => opts.MapFrom(src => src.Addr2))
                    .ForMember(desc => desc.Addr3, opts => opts.MapFrom(src => src.Addr3))
                    .ForMember(desc => desc.Addr4, opts => opts.MapFrom(src => src.Addr4))
                    .ForMember(desc => desc.FeeAmount, opts => opts.MapFrom(src => src.FeeAmount))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                    .ForMember(desc => desc.ServiceOfDocInfoId, opts => opts.MapFrom(src => src.ServiceOfDocInfoId))
                    .ForMember(desc => desc.ServiceOfDocInfoDetailId, opts => opts.MapFrom(src => src.ServiceOfDocInfoDetailId))
                    .ForMember(desc => desc.ToBeServiedCPID, opts => opts.MapFrom(src => src.ToBeServedCPID));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapServiceOfDocInfoDetailToServiceOfDocInfoDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ServiceOfDocInfo"/> to <see cref="ServiceOfDocInfoEntity"/>.
        /// </summary>
        internal void MapServiceOfDocInfoToServiceOfDocInfoEntity()
        {
            try
            {
                Mapper.CreateMap<ServiceOfDocInfo, ServiceOfDocInfoEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.MFARefNo, opts => opts.MapFrom(src => src.MFARefNo))
                    .ForMember(desc => desc.MServeStatus, opts => opts.MapFrom(src => src.MServeStatus))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.RefOrderDetailId, opts => opts.MapFrom(src => src.RefOrderDetailId))
                    .ForMember(desc => desc.RequestDate, opts => opts.MapFrom(src => src.RequestDate))
                    .ForMember(desc => desc.RequestId, opts => opts.MapFrom(src => src.RequestId))
                    .ForMember(desc => desc.ServiceOfDocInfoId, opts => opts.MapFrom(src => src.ServiceOfDocInfoId))
                    .ForMember(desc => desc.ServiceStatus, opts => opts.MapFrom(src => src.ServiceSatus))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapServiceOfDocInfoToServiceOfDocInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="SetDownInfo"/> to <see cref="SetDownInfoEntity"/>.
        /// </summary>
        internal void MapSetDownInfoToSetDownInfoEntity()
        {
            try
            {
                Mapper.CreateMap<SetDownInfo, SetDownInfoEntity>()
                     .ForMember(desc => desc.IsCertExcAEICFiled, opts => opts.MapFrom(src => src.IsCertExcAEICFiled))
                     .ForMember(desc => desc.IsHearingFeePayable, opts => opts.MapFrom(src => src.IsHearingFeePayable))
                     .ForMember(desc => desc.IsOrder25R8Complied, opts => opts.MapFrom(src => src.IsOrder25R8Complied))
                     .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                     .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                     .ForMember(desc => desc.NoOfHRGDays, opts => opts.MapFrom(src => src.NoOfHRGDays))
                     .ForMember(desc => desc.SDPursuantTo, opts => opts.MapFrom(src => src.SDPursuantTo))
                     .ForMember(desc => desc.SetDownId, opts => opts.MapFrom(src => src.SetDownId))
                     .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapSetDownInfoToSetDownInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="AccountantsReportInfoEntity"/> to <see cref="AccountantsReportInfo"/>.
        /// </summary>
        internal void MapNOCInfoToNOCInfoEntity()
        {
            try
            {
                Mapper.CreateMap<NOCInfo, NOCInfoEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.CeasedDate, opts => opts.MapFrom(src => src.CeasedDate))
                    .ForMember(dest => dest.CeasedRemarks, opts => opts.MapFrom(src => src.CeasedRemarks))
                    .ForMember(dest => dest.CertificateRegNumber, opts => opts.MapFrom(src => src.CertificateRegNumber))
                    .ForMember(dest => dest.CertificateRegPeriodFrom, opts => opts.MapFrom(src => src.CertificateRegPeriodFrom))
                    .ForMember(dest => dest.CertificateRegPeriodTo, opts => opts.MapFrom(src => src.CertificateRegPeriodTo))
                    .ForMember(dest => dest.CertificateRegYear, opts => opts.MapFrom(src => src.CertificateRegYear))
                    .ForMember(dest => dest.DOCID, opts => opts.MapFrom(src => src.DOCID))
                    .ForMember(dest => dest.IsCeased, opts => opts.MapFrom(src => src.IsCeased))
                    .ForMember(dest => dest.IsDisqualifiedR26, opts => opts.MapFrom(src => src.IsDisqualifiedR26))
                    .ForMember(dest => dest.IsDisqualifiedRemarks, opts => opts.MapFrom(src => src.IsDisqualifiedRemarks))
                    .ForMember(dest => dest.PCCERT_IND, opts => opts.MapFrom(src => src.PCCERT_IND))
                   .ForMember(dest => dest.IsPresentlyEmployeed, opts => opts.MapFrom(src => src.IsPresentlyEmployed))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.SubCaseInfoID, opts => opts.MapFrom(src => src.SubCaseInfoID));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapNOCInfoToNOCInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PCInfoAccReportEntity"/> to <see cref="PCInfoAccReport"/>.
        /// </summary>
        internal void MapPCInfoAccReportToPCInfoAccReportEntity()
        {
            try
            {
                Mapper.CreateMap<PCInfoAccReport, PCInfoAccReportEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapNOCInfoToNOCInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="AccountantsReportInfoEntity"/> to <see cref="AccountantsReportInfo"/>.
        /// </summary>
        internal void MapVoteInfoToVoteInfoEntity()
        {
            try
            {
                Mapper.CreateMap<VoteInfo, VoteInfoEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.PenaltyPaidStatus, opts => opts.MapFrom(src => src.PenaltyPaidStatus))
                    .ForMember(dest => dest.VoteInfoValue, opts => opts.MapFrom(src => src.VoteInfoValue))
                    .ForMember(dest => dest.ReqExemVoting, opts => opts.MapFrom(src => src.ReqExemVoting))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));


            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapVoteInfoToVoteInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="AccountantsReportInfoEntity"/> to <see cref="AccountantsReportInfo"/>.
        /// </summary>
        internal void MapVoteInfoDeltaToVoteInfoDeltaEntity()
        {
            try
            {
                Mapper.CreateMap<VoteInfoDelta, VoteInfoDeltaEntity>()
              .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.PenaltyPaidStatus, opts => opts.MapFrom(src => src.PenaltyPaidStatus))
                    .ForMember(dest => dest.VoteInfoDeltaValue, opts => opts.MapFrom(src => src.VoteInfoDeltaValue))
                    .ForMember(dest => dest.ReqExemVoting, opts => opts.MapFrom(src => src.ReqExemVoting))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapVoteInfoDeltaToVoteInfoDeltaEntity", ex);
                throw;
            }
        }

        internal void MapDashBoardSubCaseMilestoneDetailToDashboardSubCaseMilestoneDetailEntity()
        {
            try
            {
                Mapper.CreateMap<DashboardSubCaseMilestoneDetail, DashboardSubCaseMilestoneDetailEntity>()
                     .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDashboardCaseMilestoneDetailToDashboardCaseMilestoneDetailEntity", ex);
                throw;
            }
        }

        internal void MapDashBoardSubCaseMilestoneDetailHistoryToDashBoardSubCaseMilestoneDetailHistoryEntity()
        {
            try
            {
                Mapper.CreateMap<DashboardSubCaseMilestoneDetailHistory, DashboardSubCaseMilestoneDetailHistoryEntity>()
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDashBoardSubCaseMilestoneDetailHistoryToDashBoardSubCaseMilestoneDetailHistoryEntity", ex);
                throw;
            }
        }
        #endregion Methods
    }
}