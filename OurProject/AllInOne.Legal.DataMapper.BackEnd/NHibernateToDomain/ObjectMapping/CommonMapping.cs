#region Header

/*****************************************************************************************************
* Description : This file handles mapping for Common from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   23/09/2010   		      Nai                	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CommonMapping.cs
// Description: This file handles mapping for Common from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "CommonMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Common from NHibernate entities to Domain objects.
    /// </summary>
    internal class CommonMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CommonMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method which maps the <see cref="PrintDocumentQueue"/> to <see cref="PrintDocumentQueueEntity"/>.
        /// </summary>
        internal void MapPrintDocumentQueueToPrintDocumentQueueEntity()
        {
            try
            {
                Mapper.CreateMap<PrintDocumentQueue, PrintDocumentQueueEntity>()
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPrintDocumentQueueToPrintDocumentQueueEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PrintDocumPrintDocumentQueueDetailentQueue"/> to <see cref="PrintDocumentQueueDetailEntity"/>.
        /// </summary>
        internal void MapPrintDocumentQueueDetailToPrintDocumentQueueDetailEntity()
        {
            try
            {
                Mapper.CreateMap<PrintDocumentQueueDetail, PrintDocumentQueueDetailEntity>()
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPrintDocumentQueueDetailToPrintDocumentQueueDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="AffidavitDeponentDetail"/> to <see cref="AffidavitDeponentDetailEntity"/>.
        /// </summary>
        internal void MapAffidavitDeponentDetailToAffidavitDeponentDetailEntity()
        {
            try
            {
                Mapper.CreateMap<AffidavitDeponentDetail, AffidavitDeponentDetailEntity>()
                    .ForMember(dest => dest.AffidavitDeponentDetailId, opts => opts.MapFrom(src => src.AffidavitDeponentDetailId))
                    .ForMember(dest => dest.AffidavitId, opts => opts.MapFrom(src => src.AffidavitId))
                    .ForMember(dest => dest.DeponentId, opts => opts.MapFrom(src => src.DeponentId))
                    .ForMember(dest => dest.DeponentName, opts => opts.MapFrom(src => src.DeponentName))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAffidavitDeponentDetailToAffidavitDeponentDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="AffidavitInfo"/> to <see cref="AffidavitInfoEntity"/>.
        /// </summary>
        internal void MapAffidavitInfoToAffidavitInfoEntity()
        {
            try
            {
                Mapper.CreateMap<AffidavitInfo, AffidavitInfoEntity>()
                    .ForMember(desc => desc.AEICType, opts => opts.MapFrom(src => src.AEICType))
                    .ForMember(desc => desc.AffidavitId, opts => opts.MapFrom(src => src.AffidavitId))
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.SwornDate, opts => opts.MapFrom(src => src.SwornDate))
                    .ForMember(desc => desc.HasFiledSummons, opts => opts.MapFrom(src => src.HasFiledSummons));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAffidavitInfoToAffidavitInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="BTSRoutingQueue"/> to <see cref="BTSRoutingQueueEntity"/>.
        /// </summary>
        internal void MapBTSRoutingQueueEntityToBTSRoutingQueue()
        {
            try
            {
                Mapper.CreateMap<BTSRoutingQueue, BTSRoutingQueueEntity>()
                    .ForMember(dest => dest.CreatedDateTime, opts => opts.MapFrom(src => src.CreatedDateTime))
                    .ForMember(dest => dest.LastModifiedDateTime, opts => opts.MapFrom(src => src.LastModifiedDateTime))
                    .ForMember(dest => dest.MessageId, opts => opts.MapFrom(src => src.MessageId))
                    .ForMember(dest => dest.MessageXml, opts => opts.MapFrom(src => src.MessageXML))
                    .ForMember(dest => dest.ProcessingStatus, opts => opts.MapFrom(src => src.ProcessingStatus))
                    .ForMember(dest => dest.Recipient, opts => opts.MapFrom(src => src.Recipient))
                    .ForMember(dest => dest.RecoveryCount, opts => opts.MapFrom(src => src.RecoveryCount))
                    .ForMember(dest => dest.RetryCount, opts => opts.MapFrom(src => src.RetryCount))
                    .ForMember(dest => dest.RoutingTypeId, opts => opts.MapFrom(src => src.RoutingTypeId))
                    .ForMember(dest => dest.Sender, opts => opts.MapFrom(src => src.Sender))
                    .ForMember(dest => dest.SourcePayloadURI, opts => opts.MapFrom(src => src.SourcePayloadURI))
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                    .ForMember(dest => dest.StatusCode, opts => opts.MapFrom(src => src.StatusCode))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBTSRoutingQueueToBTSRoutingQueueEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CertSecurityOfCostsInfo"/> to <see cref="CertSecurityOfCostsInfoEntity"/>.
        /// </summary>
        internal void MapCertSecurityOfCostsInfoToCertSecurityOfCostsInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CertSecurityOfCostsInfo, CertSecurityOfCostsInfoEntity>()
                    .ForMember(desc => desc.DocId, opt => opt.MapFrom(src => src.DocumentInfo.DocId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCertSecurityOfCostsInfoToCertSecurityOfCostsInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ChecklistInstance"/> to <see cref="ChecklistInstanceEntity"/>.
        /// </summary>
        internal void MapChecklistInstanceToChecklistInstanceEntity()
        {
            try
            {
                Mapper.CreateMap<CheckListInstance, ChecklistInstanceEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.ChecklistInstanceId, opts => opts.MapFrom(src => src.CheckListInstanceId))
                    .ForMember(dest => dest.CurrentStage, opts => opts.MapFrom(src => src.CurrentStage))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MChecklist, opts => opts.MapFrom(src => src.MChecklist))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.ProcessedBy, opts => opts.MapFrom(src => src.ProcessedBy))
                    .ForMember(dest => dest.CreateDate, opts => opts.MapFrom(src => src.CreateDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapChecklistInstanceToChecklistInstanceEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ChecklistSubmission"/> to <see cref="ChecklistSubmissionEntity"/>.
        /// </summary>
        internal void MapChecklistSubmissionToChecklistSubmissionEntity()
        {
            try
            {
                Mapper.CreateMap<CheckListSubmission, ChecklistSubmissionEntity>()
                    .ForMember(dest => dest.ChecklistDocId, opts => opts.MapFrom(src => src.CheckListDocId))
                    .ForMember(dest => dest.ChecklistInstanceId, opts => opts.MapFrom(src => src.ChecklistInstanceId))
                    .ForMember(dest => dest.ChecklistSubmissionId, opts => opts.MapFrom(src => src.CheckListSubmissionId))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.DocName, opts => opts.MapFrom(src => src.DocName))
                    .ForMember(dest => dest.EformInd, opts => opts.MapFrom(src => src.EFormInd))
                    .ForMember(dest => dest.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MandatoryInd, opts => opts.MapFrom(src => src.MandatoryInd))
                    .ForMember(dest => dest.MDocCode, opts => opts.MapFrom(src => src.MDocCode))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.ProcessedInd, opts => opts.MapFrom(src => src.ProcessedInd))
                    .ForMember(dest => dest.Remarks, opts => opts.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.TemplateId, opts => opts.MapFrom(src => src.TemplateId))
                    .ForMember(dest => dest.Version, opts => opts.MapFrom(src => src.Version))
                    .ForMember(dest => dest.WFInstanceId, opts => opts.MapFrom(src => src.WFInstanceId))
                    .ForMember(dest => dest.WFstatus, opts => opts.MapFrom(src => src.WFStatus));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapChecklistSubmissionToChecklistSubmissionEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ChildInfo"/> to <see cref="ChildInfoEntity"/>.
        /// </summary>
        internal void MapChildInfoToChildInfoEntity()
        {
            try
            {
                Mapper.CreateMap<ChildInfo, ChildInfoEntity>()
                    .ForMember(dest => dest.Age, opts => opts.MapFrom(src => src.Age))
                    .ForMember(dest => dest.ArrangementDetails, opts => opts.MapFrom(src => src.ArrangementDetails))
                    .ForMember(dest => dest.ChildDisableDetail, opts => opts.MapFrom(src => src.ChildDisableDetail))
                    .ForMember(dest => dest.ChildInfoId, opts => opts.MapFrom(src => src.ChildInfoId))
                    .ForMember(dest => dest.ChildOf, opts => opts.MapFrom(src => src.ChildOf))
                    .ForMember(dest => dest.ChildTrainingDetails, opts => opts.MapFrom(src => src.ChildTrainingDetails))
                    .ForMember(dest => dest.DateOfBirth, opts => opts.MapFrom(src => src.DateOfBirth))
                    .ForMember(dest => dest.DisputeDetails, opts => opts.MapFrom(src => src.DisputeDetails))
                    .ForMember(dest => dest.Gender, opts => opts.MapFrom(src => src.MGender))
                    .ForMember(dest => dest.IdCountry, opts => opts.MapFrom(src => src.MCountry))
                    .ForMember(dest => dest.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(dest => dest.IsChildOfCurrentMarriageInd, opts => opts.MapFrom(src => src.IsChildOfCurrentMarriageInd))
                    .ForMember(dest => dest.ItemNo, opts => opts.MapFrom(src => src.Itemno))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MaritalStatus, opts => opts.MapFrom(src => src.MMaritalStatus))
                    .ForMember(dest => dest.MOccupation, opts => opts.MapFrom(src => src.MOccupation))
                    .ForMember(dest => dest.MPersonIdType, opts => opts.MapFrom(src => src.MPersonIDType))
                    .ForMember(dest => dest.MQualification, opts => opts.MapFrom(src => src.MQualification))
                    .ForMember(dest => dest.MRace, opts => opts.MapFrom(src => src.MRace))
                    .ForMember(dest => dest.MReligion, opts => opts.MapFrom(src => src.MReligion))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Nationality, opts => opts.MapFrom(src => src.MNationality))
                    .ForMember(dest => dest.OtherFacts, opts => opts.MapFrom(src => src.OtherFacts))
                    .ForMember(dest => dest.ProtectionDetails, opts => opts.MapFrom(src => src.ProtectionDetails))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapChildInfoToChildInfoEntity", ex);
                throw;
            }
        }

        internal void MapDeceasedAliasToDeceasedAliasEntity()
        {
            try
            {
                Mapper.CreateMap<DeceasedAlias, DeceasedAliasEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDeceasedAliasToDeceasedAliasEntity", ex);
                throw;
            }
        }

        internal void MapDeceasedIdentificationsToDeceasedIdentificationsEntity()
        {
            try
            {
                Mapper.CreateMap<DeceasedIdentification, DeceasedIdentificationsEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDeceasedIdentificationsToDeceasedIdentificationsEntity", ex);
                throw;
            }
        }

        internal void MapDeceasedInfoToDeceasedInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DeceasedInfo, DeceasedInfoEntity>()
                .ForMember(dest => dest.FormatInd, opts => opts.MapFrom(src => src.FormatInd))
                .ForMember(dest => dest.IsAddressAvailable, opts => opts.MapFrom(src => src.IsAddressAvailable));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDeceasedInfoToDeceasedInfoEntity", ex);
                throw;
            }
        }

        internal void MapDegreeInfoToDegreeInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DegreeInfo, DegreeInfoEntity>()
                    .ForMember(dest => dest.DegreeType, opts => opts.MapFrom(src => src.DegreeType));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDegreeInfoToDegreeInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DivorceInfo"/> to <see cref="DivorceInfoEntity"/>.
        /// </summary>
        internal void MapDivorceInfoToDivorceInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DivorceInfo, DivorceInfoEntity>()
                    .ForMember(desc => desc.CaseNatureInd, opts => opts.MapFrom(src => src.CaseNatureInd))
                    .ForMember(desc => desc.DateOfEnquiryCPFB, opts => opts.MapFrom(src => src.DateOfEnquiryCPFB))
                    .ForMember(desc => desc.DateOfEnquiryHDB, opts => opts.MapFrom(src => src.DateOfEnquiryHDB))
                    .ForMember(desc => desc.DateOfMarriage, opts => opts.MapFrom(src => src.DateOfMarriage))
                    .ForMember(desc => desc.DateOfOrder, opts => opts.MapFrom(src => src.DateOfOrder))
                    .ForMember(desc => desc.DateOfSolemnization, opts => opts.MapFrom(src => src.DateOfSolemnization))
                    .ForMember(desc => desc.DivorceInfoId, opts => opts.MapFrom(src => src.DivorceInfoId))
                    .ForMember(desc => desc.IsConsentFiled, opts => opts.MapFrom(src => src.IsConsentFiled))
                    .ForMember(desc => desc.IsJudicialSeparationWrit, opts => opts.MapFrom(src => src.IsJudicialSeperationWrit))
                    .ForMember(desc => desc.IsDivorceWrit, opts => opts.MapFrom(src => src.IsDivorceWrit))
                    .ForMember(desc => desc.IsNullityOfMarriageWrit, opts => opts.MapFrom(src => src.IsNullityOfMarriageWrit))
                    .ForMember(desc => desc.IsOrderExists, opts => opts.MapFrom(src => src.IsOrderExists))
                    .ForMember(desc => desc.IsPreDeathDivorce, opts => opts.MapFrom(src => src.IsPreDeathDivorce))
                    .ForMember(desc => desc.IsResJudicialSeparation, opts => opts.MapFrom(src => src.IsResJudicialSeperation))
                    .ForMember(desc => desc.JurDomicileInfoForDefendant, opts => opts.MapFrom(src => src.JurDomicileInfoForDefendant))
                    .ForMember(desc => desc.JurDomicileInfoForPlaintiff, opts => opts.MapFrom(src => src.JurDomicileInfoForPlaintiff))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.MarriageCertNo, opts => opts.MapFrom(src => src.MarriageCertNo))
                    .ForMember(desc => desc.MatrimonialPropInd, opts => opts.MapFrom(src => src.MatrimonialPropInd))
                    .ForMember(desc => desc.NOAFiledWithin, opts => opts.MapFrom(src => src.NOAFiledwithin))
                    .ForMember(desc => desc.OrderNumber, opts => opts.MapFrom(src => src.OrderNumber))
                    .ForMember(desc => desc.OSCaseNo, opts => opts.MapFrom(src => src.OSCaseNo))
                    .ForMember(desc => desc.ParentingPlanInd, opts => opts.MapFrom(src => src.ParentingPlanInd))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.TypeofJurDefendant, opts => opts.MapFrom(src => src.TypeofJurDefendant))
                    .ForMember(desc => desc.TypeofJurPlaintiff, opts => opts.MapFrom(src => src.TypeofJurPlaintiff))
                    .ForMember(desc => desc.HDBPropertyInd, opts => opts.MapFrom(src => src.HDBPropertyInd))
                    .ForMember(desc => desc.RelatedProceedingInd, opts => opts.MapFrom(src => src.RelatedProceedingInd))
                    .ForMember(desc => desc.AgreementOnAMInd, opts => opts.MapFrom(src => src.AgreementOnAMInd))
                    .ForMember(desc => desc.CertificateOfAttendanceInd, opts => opts.MapFrom(src => src.CertificateOfAttendanceInd))
                    .ForMember(desc => desc.ExemptionCertificateInd, opts => opts.MapFrom(src => src.ExemptionCertificateInd))
                    .ForMember(desc => desc.LeaveOfCourtToClaimInd, opts => opts.MapFrom(src => src.LeaveOfCourtToClaimInd))
                    .ForMember(desc => desc.LeaveOfCourtToClaimCaseNo, opts => opts.MapFrom(src => src.LeaveOfCourtToClaimCaseNo))
                    .ForMember(desc => desc.LeaveOfCourtToClaimOrderDate, opts => opts.MapFrom(src => src.LeaveOfCourtToClaimOrderDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDivorceInfoToDivorceInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocAppProcessByExAgency"/> to <see cref="DocAppProcessByExAgencyEntity"/>.
        /// </summary>
        internal void MapDocAppProcessByExAgencyToDocAppProcessByExAgencyEntity()
        {
            try
            {
                Mapper.CreateMap<DocAppProcessByExAgency, DocAppProcessByExAgencyEntity>()
                    .ForMember(desc => desc.DocId, opt => opt.MapFrom(src => src.DocId))
                    .ForMember(desc => desc.CaseInfoId, opt => opt.MapFrom(src => src.CaseInfo.CaseInfoId))
                    .ForMember(desc => desc.SubCaseInfoId, opt => opt.MapFrom(src => src.SubCaseInfoId))
                    //.ForMember(desc => desc.LFID, opt => opt.MapFrom(src => src.LawFirmDAPBEALFID.LFID))
                    .ForMember(desc => desc.LFIDToDisplay, opt => opt.MapFrom(src => src.LawFirmDAPBEALFIDToDisplay.LFID))
                    .ForMember(desc => desc.VerifiedApplicantDetail, opts => opts.MapFrom(src => src.VerifiedApplicantDetail))
                    .ForMember(desc => desc.VerifiedAppointmentDetail, opts => opts.MapFrom(src => src.VerifiedAppointmentDetail))
                    .ForMember(desc => desc.IsD1Saved, opts => opts.MapFrom(src => src.IsD1Saved))
                    .ForMember(desc => desc.IsD2Saved, opts => opts.MapFrom(src => src.IsD2Saved))
                    .ForMember(desc => desc.IsD3Saved, opts => opts.MapFrom(src => src.IsD3Saved))
                    .ForMember(desc => desc.IsAccRptLawSoc, opts => opts.MapFrom(src => src.IsAccRptLawSoc));
                ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocAppProcessByExAgencyToDocAppProcessByExAgencyEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="EmploymentInfo"/> to <see cref="EmploymentInfoEntity"/>.
        /// </summary>
        internal void MapEmploymentInfoToEmploymentInfoEntity()
        {
            try
            {
                Mapper.CreateMap<EmploymentInfo, EmploymentInfoEntity>();
                //.ForMember(desc => desc.LFID, opt => opt.MapFrom(src => src.LawFirm.LFID));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapEmploymentInfoToEmploymentInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="FilingFeeDetail "/>to <see cref="FilingFeeDetailEntity "/>
        /// </summary>
        internal void MapFilingFeeDetailToFilingFeeDetailEntity()
        {
            try
            {
                Mapper.CreateMap<FilingFeeDetail, FilingFeeDetailEntity>()
                    .ForMember(dest => dest.AdminFee, opts => opts.MapFrom(src => src.AdminFee))
                    .ForMember(dest => dest.BilledDate, opts => opts.MapFrom(src => src.BilledDate))
                    .ForMember(dest => dest.DocFee, opts => opts.MapFrom(src => src.DocFee))
                    .ForMember(dest => dest.DocFeeWaiverReq, opts => opts.MapFrom(src => src.DocFeeWaiverReq))
                    .ForMember(dest => dest.DocFeeWaived, opts => opts.MapFrom(src => src.DocFeeWaived))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.FeeCode, opts => opts.MapFrom(src => src.FeeCode))
                    .ForMember(dest => dest.FeePaid, opts => opts.MapFrom(src => src.FeePaid))
                    .ForMember(dest => dest.FilingFeeDetailId, opts => opts.MapFrom(src => src.FilingFeeDetailId))
                    .ForMember(dest => dest.IsEstimated, opts => opts.MapFrom(src => src.IsEstimated))
                    .ForMember(dest => dest.IsInterfaced, opts => opts.MapFrom(src => src.IsInterfaced))
                    .ForMember(dest => dest.IsUrgentHandling, opts => opts.MapFrom(src => src.IsUrgentHandling))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.ProcFee, opts => opts.MapFrom(src => src.ProcFee))
                    .ForMember(dest => dest.ProcFeeWaived, opts => opts.MapFrom(src => src.ProcFeeWaived))
                    .ForMember(dest => dest.ProcFeeWaiverReq, opts => opts.MapFrom(src => src.ProcFeeWaiverReq))
                    .ForMember(dest => dest.ReasonForDeduction, opts => opts.MapFrom(src => src.ReasonForDeduction))
                    .ForMember(dest => dest.SBFee, opts => opts.MapFrom(src => src.SBFee))
                    .ForMember(dest => dest.SBFeeWaived, opts => opts.MapFrom(src => src.SBFeeWaived))
                    .ForMember(dest => dest.SBFeeWaiverReq, opts => opts.MapFrom(src => src.SBFeeWaiverReq))
                    .ForMember(dest => dest.TotalFeeComp, opts => opts.MapFrom(src => src.TotalFeeComp))
                    .ForMember(dest => dest.TotalPayable, opts => opts.MapFrom(src => src.TotalPayable))
                    .ForMember(dest => dest.TotalWaived, opts => opts.MapFrom(src => src.TotalWaived))
                    .ForMember(dest => dest.TotalWaiverReq, opts => opts.MapFrom(src => src.TotalWaiverReq))
                    .ForMember(dest => dest.TransFee, opts => opts.MapFrom(src => src.TransFee))
                    .ForMember(dest => dest.TransFeeWaived, opts => opts.MapFrom(src => src.TransFeeWaived))
                    .ForMember(dest => dest.TransFeeWaiverReq, opts => opts.MapFrom(src => src.TransFeeWaiverReq))
                    .ForMember(dest => dest.UrgFee, opts => opts.MapFrom(src => src.UrgFee))
                    .ForMember(dest => dest.UrgFeeWaived, opts => opts.MapFrom(src => src.UrgFeeWaived))
                    .ForMember(dest => dest.UrgFeeWaiverReq, opts => opts.MapFrom(src => src.UrgFeeWaiverReq))
                    .ForMember(dest => dest.WaiverType, opts => opts.MapFrom(src => src.WaiverType))
                    .ForMember(dest => dest.IsPOHARelated, opts => opts.MapFrom(src => src.IsPOHARelated));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapFilingFeeDetailToFilingFeeDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ForeignLawPracticeRegAddress"/> to <see cref="ForeignLawPracticeRegAddressEntity"/>.
        /// </summary>
        internal void MapForeignLawPracticeRegAddressToForeignLawPracticeRegAddressEntity()
        {
            try
            {
                Mapper.CreateMap<ForeignLawPracticeRegAddress, ForeignLawPracticeRegAddressEntity>()
                    .ForMember(desc => desc.ForeignLawPracticeRegId, opt => opt.MapFrom(src => src.ForeignLawPracticeReg.ForeignLawPracticeRegId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapForeignLawPracticeRegAddressToForeignLawPracticeRegAddressEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ForeignLawPracticeReg"/> to <see cref="ForeignLawPracticeRegEntity"/>.
        /// </summary>
        internal void MapForeignLawPracticeRegToForeignLawPracticeRegEntity()
        {
            try
            {
                Mapper.CreateMap<ForeignLawPracticeReg, ForeignLawPracticeRegEntity>()
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
                   
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapForeignLawPracticeRegToForeignLawPracticeRegEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ForeignLPSolicitorReg"/> to <see cref="ForeignLPSolicitorRegEntity"/>.
        /// </summary>
        internal void MapForeignLPSolicitorRegDetailToForeignLPSolicitorRegDetailEntity()
        {
            try
            {
                Mapper.CreateMap<ForeignLPSolicitorRegDetail, ForeignLPSolicitorRegDetailEntity>()
                         .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd)); ;
                  
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapForeignLPSolicitorRegToForeignLPSolicitorRegEntity", ex);
                throw;
            }
        }

        /*
                /// <summary>
                /// Method which maps the <see cref="ForeignLawPractice"/> to <see cref="ForeignLawPracticeEntity"/>.
                /// </summary>
                internal void MapForeignLawPracticeToForeignLawPracticeEntity()
                {
                    try
                    {
                        Mapper.CreateMap<ForeignLawPractice, ForeignLawPracticeEntity>();
                    }
                    catch (Exception ex)
                    {
                        Logger.Error("Error encountered at MapForeignLawPracticeToForeignLawPracticeEntity", ex);
                        throw;
                    }
                }*/
        /// <summary>
        /// Method which maps the <see cref="ForeignLPSolicitorReg"/> to <see cref="ForeignLPSolicitorRegEntity"/>.
        /// </summary>
        internal void MapForeignLPSolicitorRegToForeignLPSolicitorRegEntity()
        {
            try
            {
                Mapper.CreateMap<ForeignLPSolicitorReg, ForeignLPSolicitorRegEntity>()
                    .ForMember(desc => desc.CaseInfoId, opt => opt.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.IsAccRptstatus, opt => opt.MapFrom(src => src.IsAccRptstatus));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapForeignLPSolicitorRegToForeignLPSolicitorRegEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="GroundInfo "/>to <see cref="GroundInfoEntity "/>
        /// </summary>
        internal void MapGroundInfoToGroundInfoEntity()
        {
            try
            {
                Mapper.CreateMap<GroundInfo, GroundInfoEntity>()
                    .ForMember(dest => dest.GroundInfoId, opts => opts.MapFrom(src => src.GroundInfoId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.GroundInfoId, opts => opts.MapFrom(src => src.GroundInfoId))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.Level, opts => opts.MapFrom(src => src.Level))
                    .ForMember(dest => dest.RequestedGrounds, opts => opts.MapFrom(src => src.RequestedGrounds))
                    .ForMember(dest => dest.SubLevel, opts => opts.MapFrom(src => src.SubLevel))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapGroundInfoToGroundInfoEntity", ex);
                throw;
            }
        }

        internal void MapInfantInfoToInfantInfoEntity()
        {
            try
            {
                Mapper.CreateMap<InfantInfo, InfantInfoEntity>()
                    .ForMember(dest => dest.FormatInd, opts => opts.MapFrom(src => src.FormatInd))
                    .ForMember(dest => dest.IsInfantMarried, opts => opts.MapFrom(src => src.IsInfantMarried))
                    .ForMember(dest => dest.IsInfantProperty, opts => opts.MapFrom(src => src.IsInfantProperty))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapInfantInfoToInfantInfoEntity", ex);
                throw;
            }
        }

        internal void MapLegalExperienceInfoToLegalExperienceInfoEntity()
        {
            try
            {
                Mapper.CreateMap<LegalExperienceInfo, LegalExperienceInfoEntity>()
                    .ForMember(dest => dest.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(dest => dest.LegalExperienceType, opts => opts.MapFrom(src => src.LegalExperienceType))
                 .ForMember(dest => dest.TypeofOrganization, opts => opts.MapFrom(src => src.TypeofOrganization));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapLegalExperienceInfoToLegalExperienceInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LegislationProvision"/> to <see cref="LegislationProvisionsEntity"/>.
        /// </summary>
        internal void MapLegislationProvisionsToLegislationProvisionsEntity()
        {
            try
            {
                Mapper.CreateMap<LegislationProvision, LegislationProvisionsEntity>()
                   .ForMember(dest => dest.MainLegInd, opts => opts.MapFrom(src => src.MainLegInd))
                   .ForMember(dest => dest.CrimeCaseInd, opts => opts.MapFrom(src => src.CrimeCaseInd))
                   .ForMember(dest => dest.MLegislationAct, opts => opts.Ignore())
                   ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLegislationProvisionsToLegislationProvisionsEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LiquidatedClaim"/> to <see cref="LiquidatedClaimEntity"/>.
        /// </summary>
        internal void MapLiquidatedClaimToLiquidatedClaimEntity()
        {
            try
            {
                Mapper.CreateMap<LiquidatedClaim, LiquidatedClaimEntity>()
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LIQAmount, opts => opts.MapFrom(src => src.LIQAmount))
                    .ForMember(desc => desc.LIQAwardedAmount, opts => opts.MapFrom(src => src.LIQAwardedAmount))
                    .ForMember(desc => desc.LIQSGDAmount, opts => opts.MapFrom(src => src.LIQSGDAmount))
                    .ForMember(desc => desc.LiquidatedClaimId, opts => opts.MapFrom(src => src.LiquidatedClaimId))
                    .ForMember(desc => desc.MCurrency, opts => opts.MapFrom(src => src.LIQCurrencyCode))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLiquidatedClaimToLiquidatedClaimEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LiquidatorAddress"/> to <see cref="LiquidatorAddressEntity"/>.
        /// </summary>
        internal void MapLiquidatorAddressToLiquidatorAddressEntity()
        {
            try
            {
                Mapper.CreateMap<LiquidatorAddress, LiquidatorAddressEntity>()
                    .ForMember(desc => desc.Addr1, opts => opts.MapFrom(src => src.Addr1))
                    .ForMember(desc => desc.Addr2, opts => opts.MapFrom(src => src.Addr2))
                    .ForMember(desc => desc.Addr3, opts => opts.MapFrom(src => src.Addr3))
                    .ForMember(desc => desc.Addr4, opts => opts.MapFrom(src => src.Addr4))
                    .ForMember(desc => desc.Address, opts => opts.MapFrom(src => src.Address))
                    .ForMember(desc => desc.AddrType, opts => opts.MapFrom(src => src.AddrType))
                    .ForMember(desc => desc.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                    .ForMember(desc => desc.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                    .ForMember(desc => desc.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
                    .ForMember(desc => desc.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                    .ForMember(desc => desc.FormatInd, opts => opts.MapFrom(src => src.FormatInd))
                    .ForMember(desc => desc.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LiquidatorAddressId, opts => opts.MapFrom(src => src.LiquidatorAddressId))
                    .ForMember(desc => desc.MailingInd, opts => opts.MapFrom(src => src.MailingInd))
                    .ForMember(desc => desc.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                    .ForMember(desc => desc.StreetName, opts => opts.MapFrom(src => src.StreetName))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.UnitNo, opts => opts.MapFrom(src => src.UnitNo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLiquidatorAddressToLiquidatorAddressEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LiquidatorAlias"/> to <see cref="LiquidatorAliasEntity"/>.
        /// </summary>
        internal void MapLiquidatorAliasToLiquidatorAliasEntity()
        {
            try
            {
                Mapper.CreateMap<LiquidatorAlias, LiquidatorAliasEntity>()
                    .ForMember(desc => desc.AliasName, opts => opts.MapFrom(src => src.AliasName))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LiquidatorId, opts => opts.MapFrom(src => src.LiquidatorId))
                    .ForMember(desc => desc.LiquidatorAliasId, opts => opts.MapFrom(src => src.LiquidatorAliasId))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLiquidatorAliasToLiquidatorAliasEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LiquidatorPICAddress"/> to <see cref="LiquidatorPICAddressEntity"/>.
        /// </summary>
        internal void MapLiquidatorPICAddressToLiquidatorPICAddressEntity()
        {
            try
            {
                Mapper.CreateMap<LiquidatorPICAddress, LiquidatorPICAddressEntity>()
                    .ForMember(desc => desc.Addr1, opts => opts.MapFrom(src => src.Addr1))
                    .ForMember(desc => desc.Addr2, opts => opts.MapFrom(src => src.Addr2))
                    .ForMember(desc => desc.Addr3, opts => opts.MapFrom(src => src.Addr3))
                    .ForMember(desc => desc.Addr4, opts => opts.MapFrom(src => src.Addr4))
                    .ForMember(desc => desc.Address, opts => opts.MapFrom(src => src.Address))
                    .ForMember(desc => desc.AddrType, opts => opts.MapFrom(src => src.AddrType))
                    .ForMember(desc => desc.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                    .ForMember(desc => desc.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                    .ForMember(desc => desc.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
                    .ForMember(desc => desc.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                    .ForMember(desc => desc.FormatInd, opts => opts.MapFrom(src => src.FormatInd))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LiquidatorPICId, opts => opts.MapFrom(src => src.LiquidatorPICId))
                    .ForMember(desc => desc.LiquidatorPICAddressId, opts => opts.MapFrom(src => src.LiquidatorPICAddressId))
                    .ForMember(desc => desc.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                    .ForMember(desc => desc.StreetName, opts => opts.MapFrom(src => src.StreetName))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.UnitNo, opts => opts.MapFrom(src => src.UnitNo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLiquidatorPICAddressToLiquidatorPICAddressEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LiquidatorPICAlias"/> to <see cref="LiquidatorPICAliasEntity"/>.
        /// </summary>
        internal void MapLiquidatorPICAliasToLiquidatorPICAliasEntity()
        {
            try
            {
                Mapper.CreateMap<LiquidatorPICAlias, LiquidatorPICAliasEntity>()
                    .ForMember(desc => desc.AliasName, opts => opts.MapFrom(src => src.AliasName))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LiquidatorPICAliasId, opts => opts.MapFrom(src => src.LiquidatorPICAliasId))
                    .ForMember(desc => desc.LiquidatorPICId, opts => opts.MapFrom(src => src.LiquidatorPICId))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLiquidatorPICAliasToLiquidatorPICAliasEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LiquidatorPIC"/> to <see cref="LiquidatorPICEntity"/>.
        /// </summary>
        internal void MapLiquidatorPICToLiquidatorPICEntity()
        {
            try
            {
                Mapper.CreateMap<LiquidatorPIC, LiquidatorPICEntity>()
                    .ForMember(desc => desc.AddressAvailabilityInd, opts => opts.MapFrom(src => src.AddressAvailabilityInd))
                    .ForMember(desc => desc.AICRemarks, opts => opts.MapFrom(src => src.AICRemarks))
                    .ForMember(desc => desc.FormerName, opts => opts.MapFrom(src => src.FormerName))
                    .ForMember(desc => desc.FullName, opts => opts.MapFrom(src => src.FullName))
                    .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(desc => desc.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LiquidatorId, opts => opts.MapFrom(src => src.LiquidatorId))
                    .ForMember(desc => desc.LiquidatorPICAddresses, opts => opts.Ignore())
                    .ForMember(desc => desc.LiquidatorPICAliases, opts => opts.Ignore())
                    .ForMember(desc => desc.LiquidatorPICId, opts => opts.MapFrom(src => src.LiquidatorPICId))
                    .ForMember(desc => desc.MActingInCapacity, opts => opts.MapFrom(src => src.MActingInCapacity))
                    .ForMember(desc => desc.MCountry, opts => opts.MapFrom(src => src.MCountry))
                    .ForMember(desc => desc.MEntityType, opts => opts.MapFrom(src => src.MEntityType))
                    .ForMember(desc => desc.MGender, opts => opts.MapFrom(src => src.MGender))
                    .ForMember(desc => desc.MPersonIdGroup, opts => opts.MapFrom(src => src.MPersonIDGroup))
                    .ForMember(desc => desc.MPersonIdType, opts => opts.MapFrom(src => src.MPersonIDType))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLiquidatorPICToLiquidatorPICEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="Liquidator"/> to <see cref="LiquidatorEntity"/>.
        /// </summary>
        internal void MapLiquidatorToLiquidatorEntity()
        {
            try
            {
                Mapper.CreateMap<Liquidator, LiquidatorEntity>()
                    .ForMember(desc => desc.CompanyName, opts => opts.MapFrom(src => src.CompanyName))
                    .ForMember(desc => desc.ContactTypeInd, opts => opts.MapFrom(src => src.ContactTypeInd))
                    .ForMember(desc => desc.DateOfRegistration, opts => opts.MapFrom(src => src.DateOfRegistration))
                    .ForMember(desc => desc.Email, opts => opts.MapFrom(src => src.Email))
                    .ForMember(desc => desc.FaxAreaCode, opts => opts.MapFrom(src => src.FaxAreaCode))
                    .ForMember(desc => desc.FaxCountryCode, opts => opts.MapFrom(src => src.FaxCountryCode))
                    .ForMember(desc => desc.FaxNumber, opts => opts.MapFrom(src => src.FaxNumber))
                    .ForMember(desc => desc.FormerCompanyName, opts => opts.MapFrom(src => src.FormerCompanyName))
                    .ForMember(desc => desc.FormerPersonName, opts => opts.MapFrom(src => src.FormerPersonName))
                    .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(desc => desc.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LiquidatorAddresses, opts => opts.Ignore())
                    .ForMember(desc => desc.LiquidatorAliases, opts => opts.Ignore())
                    .ForMember(desc => desc.LiquidatorId, opts => opts.MapFrom(src => src.LiquidatorId))
                    .ForMember(desc => desc.LiquidatorPICs, opts => opts.Ignore())
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.TelAreaCode, opts => opts.MapFrom(src => src.TelAreaCode))
                    .ForMember(desc => desc.TelCountryCode, opts => opts.MapFrom(src => src.TelCountryCode))
                    .ForMember(desc => desc.TelNumber, opts => opts.MapFrom(src => src.TelNumber))
                    .ForMember(desc => desc.UEN, opts => opts.MapFrom(src => src.UEN));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLiquidatorToLiquidatorEntity", ex);
                throw;
            }
        }

        internal void MapMinuteSheetDocListToMinuteSheetDocListEntity()
        {
            try
            {
                Mapper.CreateMap<MinuteSheetDocList, MinuteSheetDocListEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMinuteSheetDocListToMinuteSheetDocListEntity", ex);
                throw;
            }
        }

        internal void MapMinuteSheetFamilyRelatedInfoToMinuteSheetFamilyRelatedInfoEntity()
        {
            try
            {
                Mapper.CreateMap<MinuteSheetFamilyRelatedInfo, MinuteSheetFamilyRelatedInfoEntity>()
                     .ForMember(desc => desc.IsStandardCPFOrderGenerated, opt => opt.MapFrom(src => src.IsStandardCPFOrderGenerated))
                     .ForMember(desc => desc.IsIJMadeForSOC, opt => opt.MapFrom(src => src.IsIJMadeForSOC))
                     .ForMember(desc => desc.IsIJMadeForCC, opt => opt.MapFrom(src => src.IsIJMadeForCC))
                     .ForMember(desc => desc.IsHRGOutComeForWrit, opt => opt.MapFrom(src => src.IsHRGOutComeForWrit))
                     .ForMember(desc => desc.IsHRGOutComeForCC, opt => opt.MapFrom(src => src.IsHRGOutComeForCC))
                     .ForMember(desc => desc.IJMadeFinalAfter, opt => opt.MapFrom(src => src.IJMadeFinalAfter));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMinuteSheetFamilyRelatedInfoToMinuteSheetFamilyRelatedInfoEntity", ex);
                throw;
            }
        }

        internal void MapMinuteSheetGroundInfoToMinuteSheetGroundInfoEntity()
        {
            try
            {
                Mapper.CreateMap<MinuteSheetGroundInfo, MinuteSheetGroundInfoEntity>()
                     .ForMember(desc => desc.ClaimForPNOrDef, opt => opt.MapFrom(src => src.ClaimForPNOrDef))
                     .ForMember(desc => desc.Is3YearsSeparationWithConsent, opt => opt.MapFrom(src => src.Is3YearsSeparationWithConsent))
                     .ForMember(desc => desc.Is4YearsSeparation, opt => opt.MapFrom(src => src.Is4YearsSeparation))
                     .ForMember(desc => desc.IsAdultery, opt => opt.MapFrom(src => src.IsAdultery))
                     .ForMember(desc => desc.IsDesertionFor2Years, opt => opt.MapFrom(src => src.IsDesertionFor2Years))
                     .ForMember(desc => desc.IsNonConsummationFor, opt => opt.MapFrom(src => src.IsNonConsummationFor))
                     .ForMember(desc => desc.IsNonConsummationOwingToInCap, opt => opt.MapFrom(src => src.IsNonConsummationOwingToInCap))
                     .ForMember(desc => desc.IsNonConsummationRefused, opt => opt.MapFrom(src => src.IsNonConsummationRefused))
                     .ForMember(desc => desc.IsUnreasonableBehavior, opt => opt.MapFrom(src => src.IsUnreasonableBehavior));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMinuteSheetGroundInfoToMinuteSheetGroundInfoEntity", ex);
                throw;
            }
        }

        internal void MapMinuteSheetInfoToMinuteSheetInfoEntity()
        {
            try
            {
                Mapper.CreateMap<MinuteSheetInfo, MinuteSheetInfoEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.OrderMadeIn, opts => opts.MapFrom(src => src.OrderMadeIn))
                    .ForMember(dest => dest.HearingCategory, opts => opts.MapFrom(src => src.HearingCategory))
                    .ForMember(dest => dest.RegistryInstruction, opts => opts.MapFrom(src => src.RegistryInstruction))
                    .ForMember(dest => dest.RequestForSubCaseInd, opts => opts.MapFrom(src => src.RequestForSubCaseInd))
                    .ForMember(dest => dest.RequestForSplLetterInd, opts => opts.MapFrom(src => src.RequestForSplLetterInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMinuteSheetInfoToMinuteSheetInfoEntity", ex);
                throw;
            }
        }

        internal void MapMinuteSheetPartyRepInfoToMinuteSheetPartyRepInfoEntity()
        {
            try
            {
                Mapper.CreateMap<MinuteSheetPartyRepInfo, MinuteSheetPartyRepInfoEntity>()
                    .ForMember(dest => dest.PartyRepresentationType, opts => opts.MapFrom(src => src.PartyRepresentationType));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMinuteSheetPartyRepInfoToMinuteSheetPartyRepInfoEntity", ex);
                throw;
            }
        }

        internal void MapMinuteSheetPartySolicitorInfoToMinuteSheetPartySolicitorInfoEntity()
        {
            try
            {
                Mapper.CreateMap<MinuteSheetPartySolicitorInfo, MinuteSheetPartySolicitorInfoEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMinuteSheetPartySolicitorInfoToMinuteSheetPartySolicitorInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="NatureOfAppealEntity"/> to <see cref="NatureOfAppeal"/>.
        /// </summary>
        internal void MapNatureOfAppealToNatureOfAppealEntity()
        {
            try
            {
                Mapper.CreateMap<NatureOfAppeal, NatureOfAppealEntity>()
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapNatureOfAppealToNatureOfAppealEntity", ex);
                throw;
            }
        }

        /// Method which maps the <see cref="NatureOfCase"/> to <see cref="NatureOfCaseEntity"/>.
        /// </summary>
        internal void MapNatureOfApplicationToNatureOfApplicationEntity()
        {
            try
            {
                Mapper.CreateMap<NatureOfApplication, NatureOfApplicationEntity>()
                   .ForMember(desc => desc.MainInd, opts => opts.MapFrom(src => src.MainInd))
                   .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapNatureOfApplicationToNatureOfApplicationEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="NatureOfCase"/> to <see cref="NatureOfCaseEntity"/>.
        /// </summary>
        internal void MapNatureOfCaseToNatureOfCaseEntity()
        {
            try
            {
                Mapper.CreateMap<NatureOfCase, NatureOfCaseEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.MainNOCInd, opts => opts.MapFrom(src => src.MainNOCInd))
                    .ForMember(desc => desc.MNatureOfCase, opts => opts.MapFrom(src => src.MNOC))
                    .ForMember(desc => desc.NatureOfCaseId, opts => opts.MapFrom(src => src.NatureOfCaseId))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.OtherText, opts => opts.MapFrom(src => src.OtherText))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapNatureOfCaseToNatureOfCaseEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="NotPaymentToCourtDocDetail"/> to <see cref="NotPaymenttoCourtDocDetailEntity"/>.
        /// </summary>
        internal void MapNotPaymenttoCourtDocDetailToNotPaymenttoCourtDocDetailEntity()
        {
            try
            {
                Mapper.CreateMap<NotPaymentToCourtDocDetail, NotPaymenttoCourtDocDetailEntity>()
                    .ForMember(dest => dest.Amount, opts => opts.MapFrom(src => src.Amount))
                    .ForMember(dest => dest.AmountSGD, opts => opts.MapFrom(src => src.AmountSGD))
                    .ForMember(dest => dest.NotPayeCourtDetailId, opts => opts.MapFrom(src => src.NotPayeCourtDetailId))
                    .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
                    .ForMember(dest => dest.PaymentInId, opts => opts.MapFrom(src => src.PaymentInDocDetail.PaymentInId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapNotPaymenttoCourtDocDetailToNotPaymenttoCourtDocDetailEntity", ex);
                throw;
            }
        }

        internal void MapOrdersMadeToOrdersMadeEntity()
        {
            try
            {
                Mapper.CreateMap<OrdersMade, OrdersMadeEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOrdersMadeToOrdersMadeEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="OriginatingCase"/> to <see cref="OriginatingCaseEntity"/>.
        /// </summary>
        internal void MapOriginatingCaseToOriginatingCaseEntity()
        {
            try
            {
                Mapper.CreateMap<OriginatingCase, OriginatingCaseEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId))
                    .ForMember(desc => desc.OriginatingCaseInfoId, opts => opts.MapFrom(src => src.OriginatingCaseInfoId))
                    .ForMember(desc => desc.OriginatingCaseNo, opts => opts.MapFrom(src => src.OriginatingCaseNo))
                    .ForMember(desc => desc.OriginatingCaseName, opts => opts.MapFrom(src => src.OriginatingCaseName));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapOriginatingCaseToOriginatingCaseEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="OtherITMO"/> to <see cref="OtherITMOEntity"/>.
        /// </summary>
        internal void MapOtherITMOToOtherITMOEntity()
        {
            try
            {
                Mapper.CreateMap<OtherITMO, OtherITMOEntity>()
               .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
               .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
               .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
               .ForMember(desc => desc.OtherITMOId, opts => opts.MapFrom(src => src.OtherITMOId))
               .ForMember(desc => desc.OtherText, opts => opts.MapFrom(src => src.OtherText))
               .ForMember(desc => desc.SeqNo, opts => opts.MapFrom(src => src.SeqNo))
               .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapOtherITMOToOtherITMOEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="OtherReliefsClaim"/> to <see cref="OtherReliefsClaimEntity"/>.
        /// </summary>
        internal void MapOtherReliefsClaimToOtherReliefsClaimEntity()
        {
            try
            {
                Mapper.CreateMap<OtherReliefsClaim, OtherReliefsClaimEntity>()
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.MRelief, opts => opts.MapFrom(src => src.MRelief))
                    .ForMember(desc => desc.OtherReliefsClaimId, opts => opts.MapFrom(src => src.OtherReliefsClaimId))
                    .ForMember(desc => desc.ReliefRemarks, opts => opts.MapFrom(src => src.ReliefRemarks))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapOtherReliefsClaimToOtherReliefsClaimEntity", ex);
                throw;
            }
        }

        internal void MapOutgoingCorrespondenceCourtFeeToOutgoingCorrespondenceCourtFeeEntity()
        {
            try
            {
                Mapper.CreateMap<OutgoingCorrespondenceCourtFee, OutgoingCorrespondenceCourtFeeEntity>()
                    .ForMember(dest => dest.IsNBSInterfaced, opts => opts.MapFrom(src => src.IsNBSInterfaced))
                    .ForMember(dest => dest.CollectedAmount, opts => opts.MapFrom(src => src.CollectedAmount))
                    .ForMember(dest => dest.ShortFallUrgentFee, opts => opts.MapFrom(src => src.ShortFallUrgentFee))
                    .ForMember(dest => dest.ShortFallTransmissionFee, opts => opts.MapFrom(src => src.ShortFallTransmissionFee))
                    .ForMember(dest => dest.ShortFallProcessingFee, opts => opts.MapFrom(src => src.ShortFallProcessingFee))
                    .ForMember(dest => dest.ShortFallDocumentFee, opts => opts.MapFrom(src => src.ShortFallDocumentFee))
                    .ForMember(dest => dest.ShortFallAmount, opts => opts.MapFrom(src => src.ShortFallAmount))
                    .ForMember(dest => dest.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(dest => dest.ShortFallServiceBureauFee, opts => opts.MapFrom(src => src.ShortFallServiceBureauFee));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOutgoingCorrespondenceCourtFeeToOutgoingCorrespondenceCourtFeeEntity", ex);
                throw;
            }
        }

        internal void MapOutgoingCorrespondenceInfoToOutgoingCorrespondenceInfoEntity()
        {
            try
            {
                Mapper.CreateMap<OutgoingCorrespondenceInfo, OutgoingCorrespondenceInfoEntity>()
                    .ForMember(dest => dest.IsInterfaced, opts => opts.MapFrom(src => src.IsInterfaced))
                    .ForMember(dest => dest.FeePayable, opts => opts.MapFrom(src => src.FeePayable))
                    .ForMember(dest => dest.CollectedAmount, opts => opts.MapFrom(src => src.CollectedAmount));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOutgoingCorrespondenceInfoToOutgoingCorrespondenceInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PCAppDatesFromSAL"/> to <see cref="PCAppDatesFromSALEntity"/>.
        /// </summary>
        internal void MapPCAppDatesFromSALToPCAppDatesFromSALEntity()
        {
            try
            {
                Mapper.CreateMap<PCAppDatesFromSAL, PCAppDatesFromSALEntity>()
                    .ForMember(desc => desc.CaseInfoId, opt => opt.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.SubCaseInfoId, opt => opt.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.ObsInd, opt => opt.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPCAppDatesFromSALToPCAppDatesFromSALEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PCAppDetailsFromSAL"/> to <see cref="PCAppDetailsFromSALEntity"/>.
        /// </summary>
        internal void MapPCAppDetailsFromSALToPCAppDetailsFromSALEntity()
        {
            try
            {
                Mapper.CreateMap<PCAppDetailsFromLawSoc, PCAppDetailsFromLawSocEntity>()
                    .ForMember(desc => desc.CaseInfoId, opt => opt.MapFrom(src => src.CaseInfo.CaseInfoId))
                    .ForMember(desc => desc.SubCaseInfoId, opt => opt.MapFrom(src => src.SubCaseInfo.SubCaseInfoId))
                    .ForMember(desc => desc.ObsInd, opt => opt.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPCAppDetailsFromSALToPCAppDetailsFromSALEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PCConditionInfo"/> to <see cref="PCConditionInfoEntity"/>.
        /// </summary>
        internal void MapPCConditionInfoToPCConditionInfoEntity()
        {
            try
            {
                Mapper.CreateMap<PCConditionInfo, PCConditionInfoEntity>()
                    .ForMember(dest => dest.HasJudicialOffUpdated, opts => opts.MapFrom(src => src.HasJudicialOffUpdated))
                    .ForMember(dest => dest.IsAGCApproved, opts => opts.MapFrom(src => src.IsAGCApproved))
                    .ForMember(dest => dest.IsLAWSOCApproved, opts => opts.MapFrom(src => src.IsLAWSOCApproved))
                    .ForMember(dest => dest.IsSALApproved, opts => opts.MapFrom(src => src.IsSALApproved));
                ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPCConditionInfoToPCConditionInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="Prayer"/> to <see cref="PrayerEntity"/>.
        /// </summary>
        internal void MapPrayersToPrayersEntity()
        {
            try
            {
                Mapper.CreateMap<Prayer, PrayerEntity>()
                    .ForMember(dest => dest.GrantedPara, opts => opts.MapFrom(src => src.GrantedPara))
                    .ForMember(dest => dest.GrantedPrayer, opts => opts.MapFrom(src => src.GrantedPrayer))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.Level, opts => opts.MapFrom(src => src.Level))
                    .ForMember(dest => dest.MPrayerOutcome, opts => opts.MapFrom(src => src.MPrayerOutcome))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.PrayerParaNo, opts => opts.MapFrom(src => src.PrayerParaNo))
                    .ForMember(dest => dest.PrayersId, opts => opts.MapFrom(src => src.PrayersId))
                    .ForMember(dest => dest.RequestedPrayer, opts => opts.MapFrom(src => src.RequestedPrayer))
                    .ForMember(dest => dest.SubLevel, opts => opts.MapFrom(src => src.SubLevel))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPrayersToPrayersEntity", ex);
                throw;
            }
        }

        /*
        /// <summary>
        /// Method which maps the <see cref="QualificationInfo"/> to <see cref="QualificationInfoEntity"/>.
        /// </summary>
        internal void MapQualificationInfoToQualificationInfoEntity()
        {
            try
            {
                Mapper.CreateMap<QualificationInfo, QualificationInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapQualificationInfoToQualificationInfoEntity", ex);
                throw;
            }
        }
        */
        /// <summary>
        /// Method which maps the <see cref="RefCaveatCase"/> to <see cref="RefCaveatCaseEntity"/>.
        /// </summary>
        internal void MapRefCaveatCaseToRefCaveatCaseEntity()
        {
            try
            {
                Mapper.CreateMap<RefCaveatCase, RefCaveatCaseEntity>()
                    .ForMember(dest => dest.ADMCaveatNoId, opts => opts.MapFrom(src => src.ADMCavetNoId))
                    .ForMember(dest => dest.CaseNo, opts => opts.MapFrom(src => src.CaseNo))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRefCaveatCaseToRefCaveatCaseEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RefOrderDetail"/> to <see cref="RefOrderDetailEntity"/>.
        /// </summary>
        internal void MapRefOrderDetailToRefOrderDetailEntity()
        {
            try
            {
                Mapper.CreateMap<RefOrderDetail, RefOrderDetailEntity>()
                    .ForMember(dest => dest.AdditionalDetails, opts => opts.MapFrom(src => src.AdditionalDetails))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MDesignation, opts => opts.MapFrom(src => src.MDesignation))
                    .ForMember(dest => dest.OrderCoram, opts => opts.MapFrom(src => src.OrderCoram))
                    .ForMember(dest => dest.OrderDate, opts => opts.MapFrom(src => src.OrderDate))
                    .ForMember(dest => dest.OrderNumber, opts => opts.MapFrom(src => src.OrderNumber))
                    .ForMember(dest => dest.RefOrderDetailId, opts => opts.MapFrom(src => src.RefOrderDetailId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.OrderType, opts => opts.MapFrom(src => src.OrderType))
                    .ForMember(dest => dest.OrderMadeIn, opts => opts.MapFrom(src => src.OrderMadeIn))
                    .ForMember(dest => dest.HasObtainedLOC, opts => opts.MapFrom(src => src.HasObtainedLOC))
                    .ForMember(dest => dest.OrderOfCourtNotshownOrderNO, opts => opts.MapFrom(src => src.OrderOfCourtNotshownOrderNO))
                    .ForMember(dest => dest.PurposeOfOrder, opts => opts.MapFrom(src => src.PurposeOfOrder));}
            catch (Exception ex)
            {
                Logger.Error("Error at MapRefOrderDetailToRefOrderDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RefSubCase"/> to <see cref="RefSubCaseEntity"/>.
        /// </summary>
        internal void MapRefSubCaseToRefSubCaseEntity()
        {
            try
            {
                Mapper.CreateMap<RefSubCase, RefSubCaseEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(dest => dest.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.RefSubCaseId, opts => opts.MapFrom(src => src.RefSubCaseId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRefSubCaseToRefSubCaseEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RelatedProceeding"/> to <see cref="RelatedProceedingEntity"/>.
        /// </summary>
        internal void MapRelatedProceedingToRelatedProceedingEntity()
        {
            try
            {
                Mapper.CreateMap<RelatedProceeding, RelatedProceedingEntity>()
                    .ForMember(dest => dest.CaseNo, opts => opts.MapFrom(src => src.CaseNo))
                    .ForMember(dest => dest.DateOfOrder, opts => opts.MapFrom(src => src.DateOfOrder))
                    .ForMember(dest => dest.DetailsOfOrder, opts => opts.MapFrom(src => src.DetailsOfOrder))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MCountry, opts => opts.MapFrom(src => src.MCountry))
                    .ForMember(dest => dest.NatureOfProceeding, opts => opts.MapFrom(src => src.MNatureOfProceeding))
                    .ForMember(dest => dest.OtherProceedingInfo, opts => opts.MapFrom(src => src.OtherProceedingInfo))
                    .ForMember(dest => dest.RelatedCaseId, opts => opts.MapFrom(src => src.RelatedCaseId))
                    .ForMember(dest => dest.StatusOfProceedings, opts => opts.MapFrom(src => src.StatusOfProceedings))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRelatedProceedingToRelatedProceedingEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="Solicitor"/> to <see cref="SolicitorEntity"/>.
        /// </summary>
        internal void MapSolicitorToSolicitorEntity()
        {
            try
            {
                Mapper.CreateMap<Solicitor, SolicitorEntity>()
                    //.ForMember(dest => dest.AdmissionDate, opts => opts.MapFrom(src => src.AdmissionDate))
                    //.ForMember(dest => dest.AdmissionQualification, opts => opts.MapFrom(src => src.AdmissionQualification))
                    //.ForMember(dest => dest.AdmittedToBarInd, opts => opts.MapFrom(src => src.AdmittedToBarInd))
                    //.ForMember(dest => dest.AffidavitFilingDate, opts => opts.MapFrom(src => src.AffidavitFilingDate))
                    //.ForMember(dest => dest.Alias, opts => opts.MapFrom(src => src.Alias))
                    //.ForMember(dest => dest.BLERegistrationInd, opts => opts.MapFrom(src => src.BLERegistrationInd))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    //.ForMember(dest => dest.CountryOfBirth, opts => opts.MapFrom(src => src.CountryOfBirth))
                    .ForMember(dest => dest.DateOfBirth, opts => opts.MapFrom(src => src.DateOfBirth))
                    //.ForMember(dest => dest.DeceasedDate, opts => opts.MapFrom(src => src.DeceasedDate))
                    //.ForMember(dest => dest.Degree, opts => opts.MapFrom(src => src.Degree))
                    //.ForMember(dest => dest.DegreeClass, opts => opts.MapFrom(src => src.Degreeclass))
                    .ForMember(dest => dest.Email, opts => opts.MapFrom(src => src.Email))
                    .ForMember(dest => dest.FaxAreaCode, opts => opts.MapFrom(src => src.FaxAreaCode))
                    .ForMember(dest => dest.FaxCountryCode, opts => opts.MapFrom(src => src.FaxCountryCode))
                    .ForMember(dest => dest.FaxNumber, opts => opts.MapFrom(src => src.FaxNumber))
                    //.ForMember(dest => dest.Gender, opts => opts.MapFrom(src => src.Gender))
                    //.ForMember(dest => dest.IdCountryCode, opts => opts.MapFrom(src => src.IdCountryCode))
                    .ForMember(dest => dest.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    //.ForMember(dest => dest.IdTypeCode, opts => opts.MapFrom(src => src.IdTypeCode))
                    //.ForMember(dest => dest.MaritalStatusCode, opts => opts.MapFrom(src => src.MaritalStatusCode))
                    .ForMember(dest => dest.MobileCountryCode, opts => opts.MapFrom(src => src.MobileCountryCode))
                    .ForMember(dest => dest.MobileNumber, opts => opts.MapFrom(src => src.MobileNumber))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.NationalityRemarks, opts => opts.MapFrom(src => src.NationalityRemarks))
                    .ForMember(dest => dest.NoticePostingDate, opts => opts.MapFrom(src => src.NoticePostingDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.OSFilingDate, opts => opts.MapFrom(src => src.OSFilingDate))
                    .ForMember(dest => dest.QualifiedPersonDate, opts => opts.MapFrom(src => src.QualifiedPersonDate))
                    //.ForMember(dest => dest.RaceCode, opts => opts.MapFrom(src => src.RaceCode))
                    .ForMember(dest => dest.RaceRemarks, opts => opts.MapFrom(src => src.RaceRemarks))
                    //.ForMember(dest => dest.ReligionCode, opts => opts.MapFrom(src => src.ReligionCode))
                    .ForMember(dest => dest.ReligionRemarks, opts => opts.MapFrom(src => src.ReligionRemarks))
                    //.ForMember(dest => dest.RulesCode, opts => opts.MapFrom(src => src.RulesCode))
                    .ForMember(dest => dest.SolicitorId, opts => opts.MapFrom(src => src.SolicitorId))
                    .ForMember(dest => dest.TelAreaCode, opts => opts.MapFrom(src => src.TelAreaCode))
                    .ForMember(dest => dest.TelCountryCode, opts => opts.MapFrom(src => src.TelCountryCode))
                    .ForMember(dest => dest.TelNumber, opts => opts.MapFrom(src => src.TelNumber));
                //.ForMember(dest => dest.UniversityName, opts => opts.MapFrom(src => src.UniversityName));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSolicitorToSolicitorEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="SubmissionInfo"/> to <see cref="SubmissionInfoEntity"/>.
        /// </summary>
        internal void MapSubmissionInfoToSubmissionInfoEntity()
        {
            try
            {
                Mapper.CreateMap<SubmissionInfo, SubmissionInfoEntity>()
                    .ForMember(dest => dest.AccountId, opts => opts.MapFrom(src => src.AccountId))
                    .ForMember(dest => dest.ETA, opts => opts.MapFrom(src => src.ETA))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(dest => dest.Stage, opts => opts.MapFrom(src => src.Stage))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.SubmissionNumber, opts => opts.MapFrom(src => src.SubmissionNumber))
                    .ForMember(dest => dest.IsCaseArchived, opts => opts.MapFrom(src => src.IsCaseArchived))
                    .ForMember(dest => dest.LFAccountIdToCharge, opts => opts.MapFrom(src => src.LFAccountIdToCharge));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSubmissionInfoToSubmissionInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="TravelPassInfo"/> to <see cref="TravelPassInfoEntity"/>.
        /// </summary>
        internal void MapTravelPassInfoToTravelPassInfoEntity()
        {
            try
            {
                Mapper.CreateMap<TravelPassInfo, TravelPassInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapTravelPassInfoToTravelPassInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="UnliquidatedClaim"/> to <see cref="UnliquidatedClaimEntity"/>.
        /// </summary>
        internal void MapUnliquidatedClaimToUnliquidatedClaimEntity()
        {
            try
            {
                Mapper.CreateMap<UnliquidatedClaim, UnliquidatedClaimEntity>()
                    .ForMember(desc => desc.Description, opts => opts.MapFrom(src => src.Description))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.UnliquidatedClaimId, opts => opts.MapFrom(src => src.UnliquidatedClaimId))
                    .ForMember(desc => desc.UnLIQClaimType, opts => opts.MapFrom(src => src.UnLIQClaimType));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapUnliquidatedClaimToUnliquidatedClaimEntity", ex);
                throw;
            }
        }

        /*
        /// <summary>
        /// Method which maps the <see cref="AASCertification"/> to <see cref="AASCertificationEntity"/>.
        /// </summary>
        internal void MapAASCertificationToAASCertificationEntity()
        {
            try
            {
                Mapper.CreateMap<AASCertification, AASCertificationEntity>()
                    .ForMember(desc => desc.CaseInfoId, opt => opt.MapFrom(src => src.CaseInfo.CaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAASCertificationToAASCertificationEntity", ex);
                throw;
            }
        }*/
        /// <summary>
        /// Method which maps the <see cref="WOECaseExecutionAddress"/> to <see cref="WOECaseExecutionAddressEntity"/>.
        /// </summary>
        internal void MapWOECaseExecutionAddressToWOECaseExecutionAddressEntity()
        {
            try
            {
                Mapper.CreateMap<WOECaseExecutionAddress, WOECaseExecutionAddressEntity>()
                    .ForMember(dest => dest.SyncRequired, opts => opts.MapFrom(src => src.SyncRequired));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOECaseExecutionAddressToWOECaseExecutionAddressEntity", ex);
                throw;
            }
        }

        internal void MapWOEExecutionAddressToWOEExecutionAddressEntity()
        {
            try
            {
                Mapper.CreateMap<WOEExecutionAddress, WOEExecutionAddressEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOEExecutionAddressToWOEExecutionAddressEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the apppeal time estimation detail to appeal time estimation detail entity.
        /// </summary>
        internal void MapApppealTimeEstimationDetailToAppealTimeEstimationDetailEntity()
        {
            try
            {
                Mapper.CreateMap<AppealTimeEstimationDetail, AppealTimeEstimationDetailEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapApppealTimeEstimationDetailToAppealTimeEstimationDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the notice to refer affidavit to notice to refer affidavit entity.
        /// </summary>
        internal void MapNoticeToReferAffidavitToNoticeToReferAffidavitEntity()
        {
            try
            {
                Mapper.CreateMap<NoticeToReferAffidavit, NoticeToReferAffidavitEntity>()
                      .ForMember(dest => dest.IsDocArchived, opts => opts.MapFrom(src => src.IsDocArchived));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapNoticeToReferAffidavitToNoticeToReferAffidavitEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the claim amount to claim amount entity.
        /// </summary>
        internal void MapClaimAmountToClaimAmountEntity()
        {
            try
            {
                Mapper.CreateMap<ClaimAmount, ClaimAmountEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.ClaimAmount, opts => opts.MapFrom(src => src.Amount));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapClaimAmountToClaimAmountEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the claim amount to claim amount entity.
        /// </summary>
        internal void MapCheckListCommentsToCheckListCommentEntity()
        {
            try
            {
                Mapper.CreateMap<CheckListComments, CheckListCommentEntity>()
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                    .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapClaimAmountToClaimAmountEntity", ex);
                throw;
            }
        }

        internal void MapRefOrderJOInfoToRefOrderJOInfoEntity()
        {
            try
            {
                Mapper.CreateMap<RefOrderJOInfo, RefOrderJOInfoEntity>()
                      .ForMember(dest => dest.OrderType, opts => opts.MapFrom(src => src.OrderType));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRefOrderJOInfoToRefOrderJOInfoEntity", ex);
                throw;
            }
        }

        internal void MapSystemParametersToSystemParametersEntity()
        {
            try
            {
                Mapper.CreateMap<SystemParameters, SystemParametersEntity>()
                      .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSystemParametersToSystemParametersEntity", ex);
                throw;
            }
        }

        internal void MapInterfaceNBSReportToInterfaceNBSReportEntity()
        {
            try
            {
                Mapper.CreateMap<InterfaceNBSReport, InterfaceNBSReportEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapInterfaceNBSReportToInterfaceNBSReportEntity", ex);
                throw;
            }
        }

        internal void MapReqExaminationFeedetailToReqExaminationFeedetailEntity()
        {
            try
            {
                Mapper.CreateMap<ReqExaminationFeeDetail, ReqExaminationFeeDetailEntity>()
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.IsNBSInterfaced, opts => opts.MapFrom(src => src.IsNBSInterfaced));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapInterfaceNBSReportToInterfaceNBSReportEntity", ex);
                throw;
            }
        }

        internal void MapForeignUserRegAddressDetailsToForeignUserRegAddressDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<ForeignUserRegAddressDetails, ForeignUserRegAddressDetailsEntity>()
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
                    

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapForeignUserRegAddressDetailsToForeignUserRegAddressDetailsEntity", ex);
                throw;
            }
        }

        internal void MapForeignUserPracticeInformationToForeignUserPracticeInformationEntity()
        {
            try
            {
                Mapper.CreateMap<ForeignUserPracticeInformation, ForeignUserPracticeInformationEntity>()
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));


            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapForeignUserPracticeInformationToForeignUserPracticeInformationEntity", ex);
                throw;
            }
        }

        internal void MapRegistrationOfForeignLawyerToRegistrationOfForeignLawyerEntity()
        {
            try
            {
                Mapper.CreateMap<RegistrationOfForeignLawyer, RegistrationOfForeignLawyerEntity>()
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));


            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRegistrationOfForeignLawyerToRegistrationOfForeignLawyerEntity", ex);
                throw;
            }
        }

        internal void MapRFLValidityAndNotificationToRFLValidityAndNotificationEntity()
        {
            try
            {
                Mapper.CreateMap<RFLValidityAndNotification, RFLValidityAndNotificationEntity>()
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));


            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRFLValidityAndNotificationToRFLValidityAndNotificationEntity", ex);
                throw;
            }
        }

        internal void MapSICCFeeLedgerToSICCFeeLedgerEntity()
        {
            try
            {
                Mapper.CreateMap<SICCFeeLedger, SICCFeeLedgerEntity>()
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(dest => dest.Fees, opts => opts.MapFrom(src => src.Fees));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSICCFeeLedgerToSICCFeeLedgerEntity", ex);
                throw;
            }
        }

        internal void MapRequestForExemptionToRequestForExemptionEntity()
        {
            try
            {
                Mapper.CreateMap<RequestForExemption, RequestForExemptionEntity>()
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.CaseinfoId, opts => opts.MapFrom(src => src.CaseinfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRequestForExemptionToRequestForExemptionEntity", ex);
                throw;
            }
        }

        internal void MapFeeCollectionDetailToFeeCollectionDetailEntity()
        {
            try
            {
                Mapper.CreateMap<FeeCollectionDetail, FeeCollectionDetailEntity>()
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.Collectionstatus, opts => opts.MapFrom(src => src.Collectionstatus));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapFeeCollectionDetailToFeeCollectionDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LawfirmRegistrationEntity"/> to <see cref="LawfirmRegistration"/>.
        /// </summary>
        internal void MapLawfirmRegistrationToLawfirmRegistrationEntity()
        {
            try
            {
                Mapper.CreateMap<LawFirmRegistration, LawFirmRegistrationEntity>()
                    .ForMember(dest => dest.AccountID, opts => opts.MapFrom(src => src.AccountId))
                    .ForMember(dest => dest.AuthorizedSignatoryURL, opts => opts.MapFrom(src => src.AuthorizedSignatoryURL))
                    .ForMember(dest => dest.DDANo, opts => opts.MapFrom(src => src.DDANo))
                    .ForMember(dest => dest.DREffectiveDate, opts => opts.MapFrom(src => src.DREffectiveDate))
                    .ForMember(dest => dest.EffectiveDate, opts => opts.MapFrom(src => src.EffectiveDate))
                    .ForMember(dest => dest.JOLInd, opts => opts.MapFrom(src => src.JOLInd))
                    .ForMember(dest => dest.LFRegID, opts => opts.MapFrom(src => src.LFRegId))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                     .ForMember(dest => dest.OrganizationName, opts => opts.MapFrom(src => src.OrganizationName))
                      .ForMember(dest => dest.OutboxLibraryName, opts => opts.MapFrom(src => src.OutboxLibraryName))
                     .ForMember(dest => dest.RREffectiveDate, opts => opts.MapFrom(src => src.RREffectiveDate))
                      .ForMember(dest => dest.SentLibraryName, opts => opts.MapFrom(src => src.SentLibraryName))
                     .ForMember(dest => dest.SiteURL, opts => opts.MapFrom(src => src.SiteURL))
                        .ForMember(dest => dest.StatusCode, opts => opts.MapFrom(src => src.StatusCode))
                     .ForMember(dest => dest.SubmissionDate, opts => opts.MapFrom(src => src.SubmissionDate))
                      .ForMember(dest => dest.SubmissionSeqNo, opts => opts.MapFrom(src => src.SubmissionSeqNo))
                     .ForMember(dest => dest.UEN, opts => opts.MapFrom(src => src.UEN))
                      .ForMember(dest => dest.VerComments, opts => opts.MapFrom(src => src.VerComments))
                      .ForMember(dest => dest.VerStatus, opts => opts.MapFrom(src => src.VerStatus))
                     .ForMember(dest => dest.WebURL, opts => opts.MapFrom(src => src.WebURL))
                     .ForMember(dest => dest.WaivedAccount, opts => opts.MapFrom(src => src.WaivedAccount))
                     .ForMember(dest => dest.WaivedBy, opts => opts.MapFrom(src => src.WaivedBy))
                     .ForMember(dest => dest.AccountName, opts => opts.MapFrom(src => src.AccountName))
                     .ForMember(dest => dest.StartDate, opts => opts.MapFrom(src => src.StartDate))
                     .ForMember(dest => dest.Remarks, opts => opts.MapFrom(src => src.Remarks));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapLawfirmRegistrationToLawfirmRegistrationEntity", ex);
                throw;
            }
        }

        internal void MapDocLegalExperienceInfoToDocLegalExperienceInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DocLegalExperienceInfo, DocLegalExperienceInfoEntity>()
                    .ForMember(dest => dest.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(dest => dest.LegalExperienceType, opts => opts.MapFrom(src => src.LegalExperienceType))
                 .ForMember(dest => dest.TypeofOrganization, opts => opts.MapFrom(src => src.TypeofOrganization))
                 .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocLegalExperienceInfoToDocLegalExperienceInfoEntity", ex);
                throw;
            }
        }

        internal void MapCaseLegalExperienceInfoToCaseLegalExperienceInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CaseLegalExperienceInfo, CaseLegalExperienceInfoEntity>()
                    .ForMember(dest => dest.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(dest => dest.LegalExperienceType, opts => opts.MapFrom(src => src.LegalExperienceType))
                 .ForMember(dest => dest.TypeofOrganization, opts => opts.MapFrom(src => src.TypeofOrganization))
                 .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocLegalExperienceInfoToDocLegalExperienceInfoEntity", ex);
                throw;
            }
        }

        internal void MapCORSolicitorRegToCORSolicitorRegEntity()
        {
            try
            {
                Mapper.CreateMap<CORSolicitorReg, CORSolicitorRegEntity>()
                    .ForMember(dest => dest.IsAccRptStatus, opts => opts.MapFrom(src => src.IsAccRptStatus))
                 .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCORSolicitorRegToCORSolicitorRegEntity", ex);
                throw;
            }
        }

        internal void MapCORSolicitorRegDetailsToCORSolicitorRegDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<CORSolicitorRegDetails, CORSolicitorRegDetailsEntity>()
                 .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCORSolicitorRegDetailsToCORSolicitorRegDetailsEntity", ex);
                throw;
            }
        }

        internal void MapDocCaseCounterClaimDetailsToDocCaseCounterClaimDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<DocCaseCounterClaimDetails, DocCaseCounterClaimDetailsEntity>()
                 .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocCaseCounterClaimDetailsToDocCaseCounterClaimDetailsEntity", ex);
                throw;
            }
        }

        internal void MapDocCaseCounterClaimToDocCaseCounterClaimEntity()
        {
            try
            {
                Mapper.CreateMap<DocCaseCounterClaim, DocCaseCounterClaimEntity>()
                 .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                 .ForMember(dest => dest.UpdateInd, opts => opts.MapFrom(src => src.UpdateInd))
                 .ForMember(dest => dest.CaseInfoID, opts => opts.MapFrom(src => src.CaseInfoID));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocCaseCounterClaimToDocCaseCounterClaimEntity", ex);
                throw;
            }
        }

        internal void MapCaseCounterClaimToCaseCounterClaimEntity()
        {
            try
            {
                Mapper.CreateMap<CaseCounterClaim, CaseCounterClaimEntity>()
                 .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                 .ForMember(dest => dest.CaseInfoID, opts => opts.MapFrom(src => src.CaseInfoID));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseCounterClaimToCaseCounterClaimEntity", ex);
                throw;
            }
        }

        internal void CaseCounterClaimDetailsToCaseCounterClaimDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<CaseCounterClaimDetails, CaseCounterClaimDetailsEntity>()
                 .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                 ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at CaseCounterClaimDetailsToCaseCounterClaimDetailsEntity", ex);
                throw;
            }
        }

        #endregion Methods
    }
}