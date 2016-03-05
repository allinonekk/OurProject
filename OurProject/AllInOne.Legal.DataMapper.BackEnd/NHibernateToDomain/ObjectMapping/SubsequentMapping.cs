#region Header

/*****************************************************************************************************
* Description : This file handles mapping for Subsequent from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   27/01/2011   		        Nithin                  Created
*****************************************************************************************************/
// <summary>
// File: SubsequentMapping.cs
// Description: This file handles mapping for Subsequent from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "SubsequentMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Subsequent from NHibernate entities to Domain objects.
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
        /// Method which maps the <see cref="ADMBBDefInfo"/> to <see cref="ADMBBDefInfoEntity"/>.
        /// </summary>
        internal void MapADMBBDefInfoToADMBBDefInfoEntity()
        {
            try
            {
                Mapper.CreateMap<ADMBBDefInfo, ADMBBDefInfoEntity>()
                    .ForMember(dest => dest.ADMBBDefInfoId, opts => opts.MapFrom(src => src.ADMBBDefInfoId))
                    .ForMember(dest => dest.ADMRSVCBBInfoId, opts => opts.MapFrom(src => src.ADMRSVCBBInfoId))
                    .ForMember(dest => dest.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapADMBBDefInfoToADMBBDefInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ADMBBSecInfo"/> to <see cref="ADMBBSecInfoEntity"/>.
        /// </summary>
        internal void MapADMBBSecInfoToADMBBSecInfoEntity()
        {
            try
            {
                Mapper.CreateMap<ADMBBSecInfo, ADMBBSecInfoEntity>()
                    .ForMember(dest => dest.ADMBBSecInfoId, opts => opts.MapFrom(src => src.ADMBBSecInfoId))
                    .ForMember(dest => dest.ADMRSVCBBInfoId, opts => opts.MapFrom(src => src.ADMRSVCBBInfoId))
                    .ForMember(dest => dest.IsMainSurety, opts => opts.MapFrom(src => src.IsMainSurety))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.SecurityAddress, opts => opts.MapFrom(src => src.SecurityAddress))
                    .ForMember(dest => dest.SecurityName, opts => opts.MapFrom(src => src.SecurityName))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapADMBBSecInfoToADMBBSecInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ADMRSVCBBInfo"/> to <see cref="ADMRSVCBBInfoEntity"/>.
        /// </summary>
        internal void MapADMRSVCBBInfoToADMRSVCBBInfoEntity()
        {
            try
            {
                Mapper.CreateMap<ADMRSVCBBInfo, ADMRSVCBBInfoEntity>()
                    .ForMember(dest => dest.ADMRSVCBBInfoId, opts => opts.MapFrom(src => src.ADMRSVCBBInfoId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapADMRSVCBBInfoToADMRSVCBBInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="BillOfSaleSubInfo"/> to <see cref="BillOfSaleSubInfoEntity"/>.
        /// </summary>
        internal void MapBillOfSaleSubInfoToBillOfSaleSubInfoEntity()
        {
            try
            {
                Mapper.CreateMap<BillOfSaleSubInfo, BillOfSaleSubInfoEntity>()
                    .ForMember(dest => dest.BillOfSaleSubInfoId, opts => opts.MapFrom(src => src.BillOfSaleSubInfoId))
                    .ForMember(dest => dest.InstrumentDate, opts => opts.MapFrom(src => src.InstrumentDate))
                    .ForMember(dest => dest.IsSeekingBorrower, opts => opts.MapFrom(src => src.IsSeekingBorrower))
                    .ForMember(dest => dest.IsSeekingInstrumentDate, opts => opts.MapFrom(src => src.IsSeekingInstrumentDate))
                    .ForMember(dest => dest.IsSeekingLeaveOfCourt, opts => opts.MapFrom(src => src.IsSeekingLeaveOfCourt))
                    .ForMember(dest => dest.IsSeekingLender, opts => opts.MapFrom(src => src.IsSeekingLender))
                    .ForMember(dest => dest.IsSeekingOthers, opts => opts.MapFrom(src => src.IsSeekingOthers))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.OtherText, opts => opts.MapFrom(src => src.OtherText))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBillOfSaleSubInfoToBillOfSaleSubInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CDRInfo"/> to <see cref="CDRInfoEntity"/>.
        /// </summary>
        internal void MapCDRInfoToCDRInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CDRInfo, CDRInfoEntity>()
                    .ForMember(dest => dest.CDRInfoId, opts => opts.MapFrom(src => src.CDRInfoId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.NatureOfCDR, opts => opts.MapFrom(src => src.NatureOfCDR))
                    .ForMember(dest => dest.Remarks, opts => opts.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCDRInfoToCDRInfoEntity", ex);
                throw;
            }
        }

        internal void MapDisWithDocPtyDetailToDisWithDocPtyDetailEntity()
        {
            try
            {
                Mapper.CreateMap<DisWithDocPtyDetail, DisWithDocPtyDetailEntity>()
                    .ForMember(dest => dest.ConsentInd, opts => opts.MapFrom(src => src.ConsentInd))
                    .ForMember(dest => dest.CasePartyIdAgainstWithdrawn, opts => opts.MapFrom(src => src.WithPartyAgainst))
                    .ForMember(dest => dest.CasePartyIdWithdrawing, opts => opts.MapFrom(src => src.WithPartyID));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapFilingFeeRequestDetailEntityToFilingFeeRequestDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DivorceSubInfo"/> to <see cref="DivorceSubInfoEntity"/>.
        /// </summary>
        internal void MapDivorceSubInfoToDivorceSubInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DivorceSubInfo, DivorceSubInfoEntity>()
                    .ForMember(dest => dest.IsBankrupt, opts => opts.MapFrom(src => src.IsBankrupt))
                    .ForMember(dest => dest.IntendToContest, opts => opts.MapFrom(src => src.IntendToContest))
                    .ForMember(dest => dest.IntendToDefend, opts => opts.MapFrom(src => src.IntendToDefend))
                    .ForMember(dest => dest.PartyAckStatus, opts => opts.MapFrom(src => src.PartyAckStatus))
                    .ForMember(dest => dest.SettingDown, opts => opts.MapFrom(src => src.SettingDown))
                    .ForMember(dest => dest.FilingFor, opts => opts.MapFrom(src => src.FilingFor))
                    .ForMember(dest => dest.FilingDCOWithSetDown, opts => opts.MapFrom(src => src.FilingDCOWithSetDown))
                    .ForMember(dest => dest.FilingAffidavitWithSetDown, opts => opts.MapFrom(src => src.FilingAffidavitWithSetDown))
                    .ForMember(dest => dest.AdjudicationOrderInd, opts => opts.MapFrom(src => src.AdjudicationOrderInd))
                    .ForMember(dest => dest.FacingBankruptcy, opts => opts.MapFrom(src => src.FacingBankruptcy))
                    .ForMember(dest => dest.PendingBankruptcyInd, opts => opts.MapFrom(src => src.PendingBankruptcyInd))
                    .ForMember(desc => desc.AgreementOnAMInd, opts => opts.MapFrom(src => src.AgreementOnAMInd))
                    .ForMember(desc => desc.CertificateOfAttendanceInd, opts => opts.MapFrom(src => src.CertificateOfAttendanceInd))
                    .ForMember(desc => desc.ExemptionCertificateInd, opts => opts.MapFrom(src => src.ExemptionCertificateInd))
                    .ForMember(desc => desc.LeaveOfCourtToClaimInd, opts => opts.MapFrom(src => src.LeaveOfCourtToClaimInd))
                    .ForMember(desc => desc.LeaveOfCourtToClaimCaseNo, opts => opts.MapFrom(src => src.LeaveOfCourtToClaimCaseNo))
                    .ForMember(desc => desc.LeaveOfCourtToClaimOrderDate, opts => opts.MapFrom(src => src.LeaveOfCourtToClaimOrderDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDivorceSubInfoToDivorceSubInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocRequestDetail"/> to <see cref="DocRequestDetailEntity"/>.
        /// </summary>
        internal void MapDocRequestDetailToDocRequestDetailEntity()
        {
            try
            {
                Mapper.CreateMap<DocRequestDetail, DocRequestDetailEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocRequestDetailToDocRequestDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="FileInspectionDocDetail"/> to <see cref="FileInspectionDocDetailEntity"/>.
        /// </summary>
        internal void MapFileInspectionDocDetailToFileInspectionDocDetailEntity()
        {
            try
            {
                Mapper.CreateMap<FileInspectionDocDetail, FileInspectionDocDetailEntity>()
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapFileInspectionDocDetailToFileInspectionDocDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="FileInspection"/> to <see cref="FileInspectionEntity"/>.
        /// </summary>
        internal void MapFileInspectionToFileInspectionEntity()
        {
            try
            {
                Mapper.CreateMap<FileInspection, FileInspectionEntity>()
                   .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapFileInspectionToFileInspectionEntity", ex);
                throw;
            }
        }

        internal void MapFilingFeeRequestDetailToFilingFeeRequestDetailEntity()
        {
            try
            {
                Mapper.CreateMap<FilingFeeRequestDetail, FilingFeeRequestDetailEntity>()
                    .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
                    .ForMember(dest => dest.isInterfaced, opts => opts.MapFrom(src => src.IsInterfaced));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapFilingFeeRequestDetailEntityToFilingFeeRequestDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PartyAmendmentDetail"/> to <see cref="PartyAmendmentDetailEntity"/>.
        /// </summary>
        internal void MapPartyAmendmentDetailToPartyAmendmentDetailEntity()
        {
            try
            {
                Mapper.CreateMap<PartyAmendmentDetail, PartyAmendmentDetailEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPartyAmendmentDetailToPartyAmendmentDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PartyAmendmentLeaveOfCourt"/> to <see cref="PartyAmendmentLeaveOfCourtEntity"/>.
        /// </summary>
        internal void MapPartyAmendmentLeaveOfCourtToPartyAmendmentLeaveOfCourtEntity()
        {
            try
            {
                Mapper.CreateMap<PartyAmendmentLeaveOfCourt, PartyAmendmentLeaveOfCourtEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfo.CaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPartyAmendmentLeaveOfCourtEntityToPartyAmendmentLeaveOfCourt", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PartyAmendment"/> to <see cref="PartyAmendmentEntity"/>.
        /// </summary>
        internal void MapPartyAmendmentToPartyAmendmentEntity()
        {
            try
            {
                Mapper.CreateMap<PartyAmendment, PartyAmendmentEntity>()
                    .ForMember(dest => dest.CasePartyId, opts => opts.MapFrom(src => src.CaseParty.CasePartyId))
                    .ForMember(dest => dest.DCPId, opts => opts.MapFrom(src => src.DCPId))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocumentInfo.DocId))
                    .ForMember(dest => dest.InSupport, opts => opts.MapFrom(src => src.InSupport))
                    .ForMember(dest => dest.PerformedAt, opts => opts.MapFrom(src => src.PerformedAt))
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPartyAmendmentToPartyAmendmentEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PaymentHRGDatesDocDetail"/> to <see cref="PaymentHRGDatesDocDetailEntity"/>.
        /// </summary>
        internal void MapPaymentHRGDatesDocDetailToPaymentHRGDatesDocDetailEntity()
        {
            try
            {
                Mapper.CreateMap<PaymentHRGDatesDocDetail, PaymentHRGDatesDocDetailEntity>()
                    .ForMember(dest => dest.Amount, opts => opts.MapFrom(src => src.Amount))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.NoOfHRGDays, opts => opts.MapFrom(src => src.NoOfHRGDays))
                    .ForMember(dest => dest.NoOfUsedHRGDays, opts => opts.MapFrom(src => src.NoOfUsedHRGDays))
                    .ForMember(dest => dest.PayHRGDocId, opts => opts.MapFrom(src => src.PayHRGDocId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPaymentHRGDatesDocDetailToPaymentHRGDatesDocDetailEntity", ex);
                throw;
            }
        }

        internal void MapRAccusedStatementInfoToRAccusedStatementInfoEntity()
        {
            try
            {
                Mapper.CreateMap<RAccusedStatementInfo, RAccusedStatementInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRAccusedStatementInfoToRAccusedStatementInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RequestDocDetail"/> to <see cref="RequestDocDetailEntity"/>.
        /// </summary>
        internal void MapRequestDocDetailToRequestDocDetailEntity()
        {
            try
            {
                Mapper.CreateMap<RequestDocDetail, RequestDocDetailEntity>()
                    .ForMember(dest => dest.IsInterfaced, opts => opts.MapFrom(src => src.IsInterfaced))
                    .ForMember(dest => dest.RefundStatus, opts => opts.MapFrom(src => src.RefundStatus))
                    .ForMember(dest => dest.RefundType, opts => opts.MapFrom(src => src.RefundType))
                    .ForMember(dest => dest.MFilingFee, opts => opts.MapFrom(src => src.MFilingFee))
                    .ForMember(dest => dest.RefundFeeType, opts => opts.MapFrom(src => src.RefundFeeType))
                    .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRequestDocDetailToRequestDocDetailEntity", ex);
                throw;
            }
        }

        internal void MapRequestHearingAdminSupportToRequestHearingAdminSupportEntity()
        {
            try
            {
                Mapper.CreateMap<RequestHearingAdminSupport, RequestHearingAdminSupportEntity>()

                    .ForMember(dest => dest.HRGID, opts => opts.MapFrom(src => src.HRGID))
                    .ForMember(dest => dest.AudioPlaybackFacilities, opts => opts.MapFrom(src => src.AudioPlaybackFacilities))
                    .ForMember(dest => dest.DigitalTranscriptionService, opts => opts.MapFrom(src => src.DigitalTranscriptionService))
                    .ForMember(dest => dest.EnhancedSecurityAndPolice, opts => opts.MapFrom(src => src.EnhancedSecurityAndPolice))
                    .ForMember(dest => dest.InterpretationService, opts => opts.MapFrom(src => src.InterpretationService))
                    .ForMember(dest => dest.JusticeOnline, opts => opts.MapFrom(src => src.JusticeOnline))
                    .ForMember(dest => dest.MobileInfotechTrolley, opts => opts.MapFrom(src => src.MobileInfotechTrolley))
                    .ForMember(dest => dest.OrderToBringPersonToCourt, opts => opts.MapFrom(src => src.OrderToBringPersonToCourt))
                    .ForMember(dest => dest.VideoPlaybackFacilities, opts => opts.MapFrom(src => src.VideoPlaybackFacilities));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRequestHearingAdminSupportToRequestHearingAdminSupportEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RequestNEGDDetail"/> to <see cref="RequestNEGDDetailEntity"/>.
        /// </summary>
        internal void MapRequestNEGDDetailToRequestNEGDDetailEntity()
        {
            try
            {
                Mapper.CreateMap<RequestNEGDDetail, RequestNEGDDetailEntity>()
                    .ForMember(dest => dest.ApprovedStatus, opts => opts.MapFrom(src => src.ApprovedStatus));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRequestNEGDDetailToRequestNEGDDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="SubpoenaDocDetail"/> to <see cref="SubpoenaDocDetailEntity"/>.
        /// </summary>
        internal void MapSubpoenaDocDetailToSubpoenaDocDetailEntity()
        {
            try
            {
                Mapper.CreateMap<SubpoenaDocDetail, SubpoenaDocDetailEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSubpoenaDocDetailToSubpoenaDocDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="SubpoenaInfo"/> to <see cref="SubpoenaInfoEntity"/>.
        /// </summary>
        internal void MapSubpoenaInfoToSubpoenaInfoEntity()
        {
            try
            {
                Mapper.CreateMap<SubpoenaInfo, SubpoenaInfoEntity>()
                    .ForMember(dest => dest.ModeOfAttendance, opts => opts.MapFrom(src => src.ModeOfAttendance))
                    .ForMember(dest => dest.PurposeOfSubpoena, opts => opts.MapFrom(src => src.PurposeOfSubpoena));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSubpoenaInfoToSubpoenaInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="SubpoenaWitnessDetail"/> to <see cref="SubpoenaWitnessDetailEntity"/>.
        /// </summary>
        internal void MapSubpoenaWitnessDetailToSubpoenaWitnessDetailEntity()
        {
            try
            {
                Mapper.CreateMap<SubpoenaWitnessDetail, SubpoenaWitnessDetailEntity>()
                    .ForMember(dest => dest.FormatInd, opts => opts.MapFrom(src => src.FormatInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSubpoenaWitnessDetailToSubpoenaWitnessDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="VacHRGDatesReqInfo"/> to <see cref="VacHRGDatesReqInfoEntity"/>.
        /// </summary>
        internal void MapVacHRGDatesReqInfoToVacHRGDatesReqInfoEntity()
        {
            try
            {
                Mapper.CreateMap<VacHRGDatesReqInfo, VacHRGDatesReqInfoEntity>()
                    .ForMember(dest => dest.IsVacatingCDR, opts => opts.MapFrom(src => src.IsVacatingCDR))
                    .ForMember(dest => dest.IsVacatingWNewDate, opts => opts.MapFrom(src => src.IsVacatingWNewDate))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.VacHRGDatesReqInfoId, opts => opts.MapFrom(src => src.VacHRGDatesReqInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapVacHRGDatesReqInfoToVacHRGDatesReqInfoEntity", ex);
                throw;
            }
        }

        internal void MapWitnessInfoToWitnessInfoEntity()
        {
            try
            {
                Mapper.CreateMap<WitnessInfo, WitnessInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWitnessInfoToWitnessInfoEntity", ex);
                throw;
            }
        }

        internal void MapWOEInfoToWOEInfoEntity()
        {
            try
            {
                Mapper.CreateMap<WOEInfo, WOEInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOEInfoToWOEInfoEntity", ex);
                throw;
            }
        }

        internal void MapWOENCPEInfoToWOENCPEInfoEntity()
        {
            try
            {
                Mapper.CreateMap<WOENCPEInfo, WOENCPEInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOENCPEInfoToWOENCPEInfoEntity", ex);
                throw;
            }
        }

        internal void MapWOENECPEInfoToWOENECPEInfoEntity()
        {
            try
            {
                Mapper.CreateMap<WOENECPEInfo, WOENECPEInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOENECPEInfoToWOENECPEInfoEntity", ex);
                throw;
            }
        }

        internal void MapWOERequestToWOERequestEntity()
        {
            try
            {
                Mapper.CreateMap<WOERequest, WOERequestEntity>()
                    .ForMember(dest => dest.IsExecOutOffHour, opts => opts.MapFrom(src => src.IsExecOutOffHour))
                    .ForMember(dest => dest.IsPursuantToClaim, opts => opts.MapFrom(src => src.IsPursuantToClaim))
                    .ForMember(dest => dest.ReleaseType, opts => opts.MapFrom(src => src.ReleaseType))
                    .ForMember(dest => dest.IsExecOutOffHour, opts => opts.MapFrom(src => src.IsExecOutOffHour));
                    
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOERequestToWOERequestEntity", ex);
                throw;
            }
        }

        internal void MapRequestHearingFeeDetailToRequestHearingFeeDetailEntity()
        {
            try
            {
                Mapper.CreateMap<RequestHearingFeeDetail, RequestHearingFeeDetailEntity>()
                    .ForMember(dest => dest.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                     .ForMember(dest => dest.HRGID, opts => opts.MapFrom(src => src.HRGID))
                      .ForMember(dest => dest.IsInterfaced, opts => opts.MapFrom(src => src.IsInterfaced))
                       .ForMember(dest => dest.RefundOrWaiverStatus, opts => opts.MapFrom(src => src.Status))
                        .ForMember(dest => dest.RefundOrWaiverType, opts => opts.MapFrom(src => src.WaiverType));

                
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRequestHearingFeeDetailEntityToRequestHearingFeeDetail", ex);
                throw;
            }
        }

        #endregion Methods
    }
}