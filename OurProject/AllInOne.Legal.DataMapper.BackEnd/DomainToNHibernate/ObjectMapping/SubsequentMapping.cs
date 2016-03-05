#region Header

/*****************************************************************************************************
* Description : This file handles mapping for Subsequent from Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   27/01/2010   		        Nithin                  Created
*****************************************************************************************************/
// <summary>
// File: SubsequentMapping.cs
// Description: This file handles mapping for Subsequent from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "SubsequentMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Subsequent from Domain objects to NHibernate entities.
    /// </summary>
    internal class SubsequentMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SubsequentMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method which maps the <see cref="ADMRSVCBBInfoEntity"/> to <see cref="ADMRSVCBBInfo"/>.
        /// </summary>
        internal void MapADMRSVCBBInfoEntityToADMRSVCBBInfo()
        {
            try
            {
                Mapper.CreateMap<ADMRSVCBBInfoEntity, ADMRSVCBBInfo>()
                    .ForMember(dest => dest.ADMBBDefInfos, opts => opts.Ignore())
                    .ForMember(dest => dest.ADMBBSecInfos, opts => opts.Ignore())
                    .ForMember(dest => dest.ADMRSVCBBInfoId, opts => opts.MapFrom(src => src.ADMRSVCBBInfoId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapADMRSVCBBInfoEntityToADMRSVCBBInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="BillOfSaleSubInfoEntity"/> to <see cref="BillOfSaleSubInfo"/>.
        /// </summary>
        internal void MapBillOfSaleSubInfoEntityToBillOfSaleSubInfo()
        {
            try
            {
                Mapper.CreateMap<BillOfSaleSubInfoEntity, BillOfSaleSubInfo>()
                    .ForMember(dest => dest.BillOfSaleSubInfoId, opts => opts.MapFrom(src => src.BillOfSaleSubInfoId))
                    .ForMember(dest => dest.InstrumentDate, opts => opts.MapFrom(src => src.InstrumentDate))
                    .ForMember(dest => dest.IsSeekingBorrower, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSeekingBorrower))
                    .ForMember(dest => dest.IsSeekingInstrumentDate, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSeekingInstrumentDate))
                    .ForMember(dest => dest.IsSeekingLeaveOfCourt, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSeekingLeaveOfCourt))
                    .ForMember(dest => dest.IsSeekingLender, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSeekingLender))
                    .ForMember(dest => dest.IsSeekingOthers, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSeekingOthers))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.OtherText, opts => opts.MapFrom(src => src.OtherText))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBillOfSaleSubInfoEntityToBillOfSaleSubInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CDRInfoEntity"/> to <see cref="CDRInfo"/>.
        /// </summary>
        internal void MapCDRInfoEntityToCDRInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CDRInfoEntity, CDRInfo>()
                    .ForMember(dest => dest.CDRInfoId, opts => opts.MapFrom(src => src.CDRInfoId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.NatureOfCDR, opts => opts.ResolveUsing<NatureOfCDRToStringResolver>().FromMember(src => src.NatureOfCDR))
                    .ForMember(dest => dest.Remarks, opts => opts.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCDRInfoEntityToCDRInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DivorceSubInfoEntity"/> to <see cref="DivorceSubInfo"/>.
        /// </summary>
        internal void MapDivorceSubInfoEntityToDivorceSubInfo()
        {
            try
            {
                Mapper.CreateMap<DivorceSubInfoEntity, DivorceSubInfo>()
                    .ForMember(dest => dest.IsBankrupt, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsBankrupt))
                    .ForMember(dest => dest.IntendToContest, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IntendToContest))
                    .ForMember(dest => dest.IntendToDefend, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IntendToDefend))
                    .ForMember(dest => dest.PartyAckStatus, opts => opts.ResolveUsing<AgreeOrNotAgreeToStringResolver>().FromMember(src => src.PartyAckStatus))
                    .ForMember(dest => dest.SettingDown, opts => opts.ResolveUsing<SettingDownStatusToStringResolver>().FromMember(src => src.SettingDown))
                    .ForMember(dest => dest.FilingFor, opts => opts.ResolveUsing<DivorceFilingForToStringResolver>().FromMember(src => src.FilingFor))
                     .ForMember(dest => dest.FilingDCOWithSetDown, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.FilingDCOWithSetDown))
                    .ForMember(dest => dest.FilingAffidavitWithSetDown, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.FilingAffidavitWithSetDown))
                    .ForMember(dest => dest.PendingBankruptcyInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PendingBankruptcyInd))
                    .ForMember(dest => dest.AdjudicationOrderInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.AdjudicationOrderInd))
                    .ForMember(dest => dest.FacingBankruptcy, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.FacingBankruptcy))
                    .ForMember(dest => dest.AgreementOnAMInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.AgreementOnAMInd))
                    .ForMember(dest => dest.CertificateOfAttendanceInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CertificateOfAttendanceInd))
                    .ForMember(dest => dest.ExemptionCertificateInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ExemptionCertificateInd))
                    .ForMember(dest => dest.LeaveOfCourtToClaimInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.LeaveOfCourtToClaimInd))
                    .ForMember(dest => dest.LeaveOfCourtToClaimCaseNo, opts => opts.MapFrom(src => src.LeaveOfCourtToClaimCaseNo))
                    .ForMember(dest => dest.LeaveOfCourtToClaimOrderDate, opts => opts.MapFrom(src => src.LeaveOfCourtToClaimOrderDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDivorceSubInfoEntityToDivorceSubInfo", ex);
                throw;
            }
        }

        internal void MapDocRequestDetailEntityToDocRequestDetail()
        {
            try
            {
                Mapper.CreateMap<DocRequestDetailEntity, DocRequestDetail>()
                    .ForMember(dest => dest.MetaData, opts => opts.MapFrom(src => src.MetaData))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocRequestDetailEntityToDocRequestDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RequestDocDetailEntity"/> to <see cref="RequestDocDetail"/>.
        /// </summary>
        internal void MapFileInspectionDocDetailToFileInspectionDocDetailEntity()
        {
            try
            {
                Mapper.CreateMap<FileInspectionDocDetailEntity, FileInspectionDocDetail>()
                    .ForMember(dest => dest.Status, opts => opts.ResolveUsing<FileInspectionDocStatusToStringResolver>().FromMember(src => src.Status))
                    .ForMember(dest => dest.SubCaseInfo, opts => opts.ResolveUsing<StringToSubCaseInfoResolver>().FromMember(src => src.SubCaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRequestDocDetailToRequestDocDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RequestDocDetailEntity"/> to <see cref="RequestDocDetail"/>.
        /// </summary>
        internal void MapFileInspectionToFileInspectionEntity()
        {
            try
            {
                Mapper.CreateMap<FileInspectionEntity, FileInspection>()
                       .ForMember(dest => dest.Status, opts => opts.ResolveUsing<FileInspectionStatusToStringResolver>().FromMember(src => src.Status));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRequestDocDetailToRequestDocDetailEntity", ex);
                throw;
            }
        }

        internal void MapFilingFeeRequestDetailEntityToFilingFeeRequestDetail()
        {
            try
            {
                Mapper.CreateMap<FilingFeeRequestDetailEntity, FilingFeeRequestDetail>()
                    .ForMember(dest => dest.Type, opts => opts.ResolveUsing<RequestTypeToStringResolver>().FromMember(src => src.Type))
                    .ForMember(dest => dest.IsInterfaced, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.isInterfaced));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapFilingFeeRequestDetailEntityToFilingFeeRequestDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PartyAmendmentEntity"/> to <see cref="PartyAmendment"/>.
        /// </summary>
        internal void MapPartyAmendmentDetailEntityToPartyAmendmentDetail()
        {
            try
            {
                Mapper.CreateMap<PartyAmendmentDetailEntity, PartyAmendmentDetail>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPartyAmendmentDetailEntityToPartyAmendmentDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PartyAmendmentEntity"/> to <see cref="PartyAmendment"/>.
        /// </summary>
        internal void MapPartyAmendmentEntityToPartyAmendment()
        {
            try
            {
                Mapper.CreateMap<PartyAmendmentEntity, PartyAmendment>()
                    .ForMember(dest => dest.AmendmentMode, opts => opts.ResolveUsing<ModeOfAmendmentToStringResolver>().FromMember(src => src.AmendmentMode))
                    .ForMember(dest => dest.CaseParty, opts => opts.ResolveUsing<StringToCasePartyResolver>().FromMember(src => src.CasePartyId))
                    .ForMember(dest => dest.DCPId, opts => opts.MapFrom(src => src.DCPId))
                    .ForMember(dest => dest.DocumentInfo, opts => opts.ResolveUsing<StringToDocumentInfoResolver>().FromMember(src => src.DocId))
                    .ForMember(dest => dest.InSupport, opts => opts.ResolveUsing<AmendmentInSupportToStringResolver>().FromMember(src => src.InSupport))
                    .ForMember(dest => dest.PerformedAt, opts => opts.ResolveUsing<AmendmentPerformedAtToStringResolver>().FromMember(src => src.PerformedAt))
                    .ForMember(dest => dest.Status, opts => opts.ResolveUsing<AmendmentStatusToStringResolver>().FromMember(src => src.Status));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPartyAmendmentEntityToPartyAmendment", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PartyAmendmentLeaveOfCourtEntity"/> to <see cref="PartyAmendmentLeaveOfCourt"/>.
        /// </summary>
        internal void MapPartyAmendmentLeaveOfCourtEntityToPartyAmendmentLeaveOfCourt()
        {
            try
            {
                Mapper.CreateMap<PartyAmendmentLeaveOfCourtEntity, PartyAmendmentLeaveOfCourt>()
                    .ForMember(dest => dest.CaseInfo, opts => opts.ResolveUsing<StringToCaseInfoResolver>().FromMember(src => src.CaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPartyAmendmentLeaveOfCourtEntityToPartyAmendmentLeaveOfCourt", ex);
                throw;
            }
        }

        internal void MapRAccusedStatementInfoEntityToRAccusedStatementInfo()
        {
            try
            {
                Mapper.CreateMap<RAccusedStatementInfoEntity, RAccusedStatementInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRAccusedStatementInfoEntityToRAccusedStatementInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RequestDocDetailEntity"/> to <see cref="RequestDocDetail"/>.
        /// </summary>
        internal void MapRequestDocDetailToRequestDocDetailEntity()
        {
            try
            {
                Mapper.CreateMap<RequestDocDetailEntity, RequestDocDetail>()
                    .ForMember(dest => dest.IsInterfaced, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInterfaced))
                    .ForMember(dest => dest.RefundFeeType, opts => opts.ResolveUsing<RefundFeeTypeToStringResolver>().FromMember(src => src.RefundFeeType))
                    .ForMember(dest => dest.RefundStatus, opts => opts.ResolveUsing<RefundStatusToStringResolver>().FromMember(src => src.RefundStatus))
                    .ForMember(dest => dest.RefundType, opts => opts.ResolveUsing<RefundTypeToStringResolver>().FromMember(src => src.RefundType))
                    .ForMember(dest => dest.Type, opts => opts.ResolveUsing<RequestTypeToStringResolver>().FromMember(src => src.Type));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRequestDocDetailToRequestDocDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RequestHearingAdminSupportEntity"/> to <see cref="RequestHearingAdminSupport"/>.
        /// </summary>
        internal void MapRequestHearingAdminSupportEntityToRequestHearingAdminSupport()
        {
            try
            {
                Mapper.CreateMap<RequestHearingAdminSupportEntity, RequestHearingAdminSupport>()
                 .ForMember(dest => dest.AudioPlaybackFacilities, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.AudioPlaybackFacilities))
                 .ForMember(dest => dest.DigitalTranscriptionService, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.DigitalTranscriptionService))
                 .ForMember(dest => dest.EnhancedSecurityAndPolice, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.EnhancedSecurityAndPolice))
                 .ForMember(dest => dest.InterpretationService, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.InterpretationService))
                 .ForMember(dest => dest.JusticeOnline, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.JusticeOnline))
                 .ForMember(dest => dest.MobileInfotechTrolley, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MobileInfotechTrolley))
                 .ForMember(dest => dest.OrderToBringPersonToCourt, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.OrderToBringPersonToCourt))
                 .ForMember(dest => dest.VideoPlaybackFacilities, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.VideoPlaybackFacilities));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapVacHRGDatesReqInfoEntityToVacHRGDatesReqInfo", ex);
                throw;
            }
        }

        internal void MapRequestHearingFeeDetailEntityToRequestHearingFeeDetail()
        {
            try
            {
                Mapper.CreateMap<RequestHearingFeeDetailEntity, RequestHearingFeeDetail>()
                    .ForMember(dest => dest.IsInterfaced, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInterfaced))
                    .ForMember(dest => dest.Status, opts => opts.ResolveUsing<RefundOrWaiverStatusToStringResolver>().FromMember(src => src.RefundOrWaiverStatus))
                    .ForMember(dest => dest.WaiverType, opts => opts.ResolveUsing<RefundOrWaiverTypeToStringResolver>().FromMember(src => src.RefundOrWaiverType));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRequestHearingFeeDetailEntityToRequestHearingFeeDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RequestNEGDDetailEntity"/> to <see cref="RequestNEGDDetail"/>.
        /// </summary>
        internal void MapRequestNEGDDetailEntityToRequestNEGDDetail()
        {
            try
            {
                Mapper.CreateMap<RequestNEGDDetailEntity, RequestNEGDDetail>()
                    .ForMember(dest => dest.ApprovedStatus, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ApprovedStatus));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRequestNEGDDetailEntityToRequestNEGDDetail", ex);
                throw;
            }
        }

        internal void MapSubpoenaDocDetailEntityToSubpoenaDocDetail()
        {
            try
            {
                Mapper.CreateMap<SubpoenaDocDetailEntity, SubpoenaDocDetail>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SubpoenaInfoEntityToSubpoenaInfoEntity", ex);
                throw;
            }
        }

        internal void MapSubpoenaInfoEntityToSubpoenaInfo()
        {
            try
            {
                Mapper.CreateMap<SubpoenaInfoEntity, SubpoenaInfo>()
                    .ForMember(dest => dest.HrgId, opts => opts.MapFrom(src => src.SelectedHrgId))
                    .ForMember(dest => dest.ModeOfAttendance, opts => opts.ResolveUsing<AttendanceModeToStringResolver>().FromMember(src => src.ModeOfAttendance))
                    .ForMember(dest => dest.PurposeOfSubpoena, opts => opts.ResolveUsing<SubpoenaPurposeToStringResolver>().FromMember(src => src.PurposeOfSubpoena));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SubpoenaInfoEntityToSubpoenaInfoEntity", ex);
                throw;
            }
        }

        internal void MapSubpoenaWitnessDetailEntityToSubpoenaWitnessDetail()
        {
            try
            {
                Mapper.CreateMap<SubpoenaWitnessDetailEntity, SubpoenaWitnessDetail>()
                    .ForMember(dest => dest.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SubpoenaInfoEntityToSubpoenaInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="VacHRGDatesReqInfoEntity"/> to <see cref="VacHRGDatesReqInfo"/>.
        /// </summary>
        internal void MapVacHRGDatesReqInfoEntityToVacHRGDatesReqInfo()
        {
            try
            {
                Mapper.CreateMap<VacHRGDatesReqInfoEntity, VacHRGDatesReqInfo>()
                    .ForMember(dest => dest.IsVacatingCDR, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsVacatingCDR))
                    .ForMember(dest => dest.IsVacatingWNewDate, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsVacatingWNewDate))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.VacHRGDatesReqInfoId, opts => opts.MapFrom(src => src.VacHRGDatesReqInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapVacHRGDatesReqInfoEntityToVacHRGDatesReqInfo", ex);
                throw;
            }
        }

        internal void MapWitnessInfoEntityToWitnessInfo()
        {
            try
            {
                Mapper.CreateMap<WitnessInfoEntity, WitnessInfo>()
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWitnessInfoEntityToWitnessInfo", ex);
                throw;
            }
        }

        internal void MapWOEInfoEntityToWOEInfo()
        {
            try
            {
                Mapper.CreateMap<WOEInfoEntity, WOEInfo>()
                    .ForMember(dest => dest.IsExecOutOffHour, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsExecOutOffHour))
                    .ForMember(dest => dest.IsAuthorisedBailiff, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAuthorisedBailiff))
                    .ForMember(dest => dest.IsWritSeizure, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsWritSeizure));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOEInfoEntityToWOEInfo", ex);
                throw;
            }
        }

        internal void MapWOENCPEInfoEntityToWOENCPEInfo()
        {
            try
            {
                Mapper.CreateMap<WOENCPEInfoEntity, WOENCPEInfo>()
                    .ForMember(dest => dest.ClaimObject, opts => opts.ResolveUsing<WOEInfoClaimTypeToStringResolver>().FromMember(src => src.ClaimObject));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOENCPEInfoEntityToWOENCPEInfo", ex);
                throw;
            }
        }

        internal void MapWOENECPEInfoEntityToWOENECPEInfo()
        {
            try
            {
                Mapper.CreateMap<WOENECPEInfoEntity, WOENECPEInfo>()
                    .ForMember(dest => dest.ClaimStatus, opts => opts.ResolveUsing<WOEInfoClaimStatusToStringResolver>().FromMember(src => src.ClaimStatus))
                    .ForMember(dest => dest.ClaimAdmitStatus, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ClaimAdmitStatus))
                    .ForMember(dest => dest.IsInterpleaderFiled, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInterpleaderFiled));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOENCPEInfoEntityToWOENCPEInfo", ex);
                throw;
            }
        }

        internal void MapWOERequestEntityToWOERequest()
        {
            try
            {
                Mapper.CreateMap<WOERequestEntity, WOERequest>()
                    .ForMember(dest => dest.IsExecOutOffHour, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsExecOutOffHour))
                    .ForMember(dest => dest.IsPursuantToClaim, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPursuantToClaim))
                    .ForMember(dest => dest.ReleaseType, opts => opts.ResolveUsing<CriminalReleaseTypeToStringResolver>().FromMember(src => src.ReleaseType));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOERequestEntityToWOERequest", ex);
                throw;
            }
        }

        internal void MapPaymentHRGDatesDocDetailEntityToPaymentHRGDatesDocDetail()
        {
            try
            {
                Mapper.CreateMap<PaymentHRGDatesDocDetailEntity, PaymentHRGDatesDocDetail>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPaymentHRGDatesDocDetailEntityToPaymentHRGDatesDocDetail", ex);
                throw;
            }
        }

        #endregion Methods
    }
}