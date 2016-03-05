#region Header

/*****************************************************************************************************
* Description : This file represents the mapping of objects for Common entities. This class will map
* Object to Entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   23/09/2010   		      Nai                	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CommonMapping.cs
// Description: This file represents the mapping of objects for Common entities. This class will map
// Object to Entity.
// </summary>
// <copyright file= "CommonMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

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
        /// Maps the PrintDocumentQueue entity to PrintDocumentQueue.
        /// </summary>
        internal void MapPrintDocumentQueueEntityToPrintDocumentQueue()
        {
            try
            {
                Mapper.CreateMap<PrintDocumentQueueEntity, PrintDocumentQueue>()
                    .ForMember(desc => desc.Status, opts => opts.ResolveUsing<PrintStatusToStringResolver>().FromMember(src => src.Status))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPrintDocumentQueueEntityToPrintDocumentQueue", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the PrintDocumentQueueDetail entity to PrintDocumentQueueDetail.
        /// </summary>
        internal void MapPrintDocumentQueueDetailEntityToPrintDocumentQueueDetail()
        {
            try
            {
                Mapper.CreateMap<PrintDocumentQueueDetailEntity, PrintDocumentQueueDetail>()
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPrintDocumentQueueDetailEntityToPrintDocumentQueueDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the affidavit deponent detail entity to affidavit detail.
        /// </summary>
        internal void MapAffidavitDeponentDetailEntityToAffidavitDetail()
        {
            try
            {
                Mapper.CreateMap<AffidavitDeponentDetailEntity, AffidavitDeponentDetail>()
                    .ForMember(desc => desc.AffidavitDeponentDetailId, opts => opts.MapFrom(src => src.AffidavitDeponentDetailId))
                    .ForMember(desc => desc.AffidavitId, opts => opts.MapFrom(src => src.AffidavitId))
                    .ForMember(desc => desc.DeponentId, opts => opts.MapFrom(src => src.DeponentId))
                    .ForMember(desc => desc.DeponentName, opts => opts.MapFrom(src => src.DeponentName))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAffidavitDeponentDetailEntityToAffidavitDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="UnliquidatedClaimEntity"/> to <see cref="UnliquidatedClaim"/>.
        /// </summary>
        internal void MapAffidavitInfoEntityToAffidavitInfo()
        {
            try
            {
                Mapper.CreateMap<AffidavitInfoEntity, AffidavitInfo>()
                    .ForMember(desc => desc.AEICType, opts => opts.ResolveUsing<AffidavitAEICTypeToStringResolver>().FromMember(src => src.AEICType))
                    .ForMember(desc => desc.AffidavitDeponentDetails, opts => opts.Ignore())
                    .ForMember(desc => desc.AffidavitId, opts => opts.MapFrom(src => src.AffidavitId))
                    .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.SwornDate, opts => opts.MapFrom(src => src.SwornDate))
                    .ForMember(desc => desc.HasFiledSummons, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasFiledSummons));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapAffidavitInfoEntityToAffidavitInfo", ex);
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
        /// Maps objects from <see cref="BTSRoutingQueue"/> to <see cref="BTSRoutingQueueEntity"/>.
        /// </summary>
        internal void MapBTSRoutingQueueEntityToBTSRoutingQueue()
        {
            try
            {
                Mapper.CreateMap<BTSRoutingQueueEntity, BTSRoutingQueue>()
                    .ForMember(dest => dest.CreatedDateTime, opts => opts.MapFrom(src => src.CreatedDateTime))
                    .ForMember(dest => dest.LastModifiedDateTime, opts => opts.MapFrom(src => src.LastModifiedDateTime))
                    .ForMember(dest => dest.MessageId, opts => opts.MapFrom(src => src.MessageId))
                    .ForMember(dest => dest.MessageXML, opts => opts.MapFrom(src => src.MessageXml))
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
                Logger.Error("Error encountered at MapBTSRoutingQueueEntityToBTSRoutingQueue", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CertSecurityOfCostsInfoEntity"/> to <see cref="CertSecurityOfCostsInfo"/>.
        /// </summary>
        internal void MapCertSecurityOfCostsInfoEntityToCertSecurityOfCostsInfo()
        {
            try
            {
                Mapper.CreateMap<CertSecurityOfCostsInfoEntity, CertSecurityOfCostsInfo>()
                    .ForMember(desc => desc.DocumentInfo, opts => opts.ResolveUsing<StringToDocumentInfoResolver>().FromMember(src => src.DocId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCertSecurityOfCostsInfoEntityToCertSecurityOfCostsInfo", ex);
                throw;
            }
        }

        internal void MapChecklistInstanceEntityToChecklistInstance()
        {
            try
            {
                Mapper.CreateMap<ChecklistInstanceEntity, CheckListInstance>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.CheckListInstanceId, opts => opts.MapFrom(src => src.ChecklistInstanceId))
                    .ForMember(dest => dest.CheckListSubmissions, opts => opts.Ignore())
                    .ForMember(dest => dest.CurrentStage, opts => opts.MapFrom(src => src.CurrentStage))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MChecklist, opts => opts.MapFrom(src => src.MChecklist))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.ProcessedBy, opts => opts.MapFrom(src => src.ProcessedBy))
                    .ForMember(dest => dest.CreateDate, opts => opts.MapFrom(src => src.CreateDate));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapChecklistInstanceEntityToChecklistInstance", ex);
                throw;
            }
        }

        internal void MapChecklistSubmissionEntityToChecklistSubmission()
        {
            try
            {
                Mapper.CreateMap<ChecklistSubmissionEntity, CheckListSubmission>()
                    .ForMember(dest => dest.CheckListDocId, opts => opts.MapFrom(src => src.ChecklistDocId))
                    .ForMember(dest => dest.ChecklistInstanceId, opts => opts.MapFrom(src => src.ChecklistInstanceId))
                    .ForMember(dest => dest.CheckListSubmissionId, opts => opts.MapFrom(src => src.ChecklistSubmissionId))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.DocName, opts => opts.MapFrom(src => src.DocName))
                    .ForMember(dest => dest.EFormInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.EformInd))
                    .ForMember(dest => dest.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MandatoryInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MandatoryInd))
                    .ForMember(dest => dest.MDocCode, opts => opts.MapFrom(src => src.MDocCode))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                     .ForMember(dest => dest.ProcessedInd, opts => opts.MapFrom(src => src.ProcessedInd))
                    .ForMember(dest => dest.Remarks, opts => opts.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.TemplateId, opts => opts.MapFrom(src => src.TemplateId))
                    .ForMember(dest => dest.Version, opts => opts.MapFrom(src => src.Version))
                    .ForMember(dest => dest.WFInstanceId, opts => opts.MapFrom(src => src.WFInstanceId))
                    .ForMember(dest => dest.WFStatus, opts => opts.MapFrom(src => src.WFstatus));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapChecklistSubmissionEntityToChecklistSubmission", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ChildInfoEntity"/> to <see cref="ChildInfo"/>.
        /// </summary>
        internal void MapChildInfoEntityToChildInfo()
        {
            try
            {
                Mapper.CreateMap<ChildInfoEntity, ChildInfo>()
                    .ForMember(dest => dest.Age, opts => opts.MapFrom(src => src.Age))
                    .ForMember(dest => dest.ArrangementDetails, opts => opts.MapFrom(src => src.ArrangementDetails))
                    .ForMember(dest => dest.ChildDisableDetail, opts => opts.MapFrom(src => src.ChildDisableDetail))
                    .ForMember(dest => dest.ChildInfoId, opts => opts.MapFrom(src => src.ChildInfoId))
                    .ForMember(dest => dest.ChildOf, opts => opts.ResolveUsing<ChildOfToStringResolver>().FromMember(src => src.ChildOf))
                    .ForMember(dest => dest.ChildTrainingDetails, opts => opts.MapFrom(src => src.ChildTrainingDetails))
                    .ForMember(dest => dest.DateOfBirth, opts => opts.MapFrom(src => src.DateOfBirth))
                    .ForMember(dest => dest.DisputeDetails, opts => opts.MapFrom(src => src.DisputeDetails))
                    .ForMember(dest => dest.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(dest => dest.IsChildOfCurrentMarriageInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsChildOfCurrentMarriageInd))
                    .ForMember(dest => dest.Itemno, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.OtherFacts, opts => opts.MapFrom(src => src.OtherFacts))
                    .ForMember(dest => dest.ProtectionDetails, opts => opts.MapFrom(src => src.ProtectionDetails))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapChildInfoEntityToChildInfo", ex);
                throw;
            }
        }

        internal void MapDeceasedAliasEntityToDeceasedAlias()
        {
            try
            {
                Mapper.CreateMap<DeceasedAliasEntity, DeceasedAlias>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDeceasedAliasEntityToDeceasedAlias", ex);
                throw;
            }
        }

        internal void MapDeceasedIdentificationsEntityToDeceasedIdentification()
        {
            try
            {
                Mapper.CreateMap<DeceasedIdentificationsEntity, DeceasedIdentification>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDeceasedIdentificationsEntityToDeceasedIdentification", ex);
                throw;
            }
        }

        internal void MapDeceasedInfoEntityToDeceasedInfo()
        {
            try
            {
                Mapper.CreateMap<DeceasedInfoEntity, DeceasedInfo>()
                    .ForMember(dest => dest.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                    .ForMember(dest => dest.IsAddressAvailable, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAddressAvailable));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDeceasedInfoEntityToDeceasedInfo", ex);
                throw;
            }
        }

        internal void MapDegreeInfoEntityEntityToDegreeInfo()
        {
            try
            {
                Mapper.CreateMap<DegreeInfoEntity, DegreeInfo>()
                    .ForMember(dest => dest.DegreeType, opts => opts.ResolveUsing<DegreeTypeToStringResolver>().FromMember(src => src.DegreeType));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDegreeInfoEntityEntityToDegreeInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the divorce info entity to divorce info.
        /// </summary>
        internal void MapDivorceInfoEntityToDivorceInfo()
        {
            try
            {
                Mapper.CreateMap<DivorceInfoEntity, DivorceInfo>()
                    .ForMember(dest => dest.CaseNatureInd, opts => opts.ResolveUsing<DivorceCaseNatureToStringResolver>().FromMember(src => src.CaseNatureInd))
                    .ForMember(dest => dest.DateOfEnquiryCPFB, opts => opts.MapFrom(src => src.DateOfEnquiryCPFB))
                    .ForMember(dest => dest.DateOfEnquiryHDB, opts => opts.MapFrom(src => src.DateOfEnquiryHDB))
                    .ForMember(dest => dest.DateOfMarriage, opts => opts.MapFrom(src => src.DateOfMarriage))
                    .ForMember(dest => dest.DateOfOrder, opts => opts.MapFrom(src => src.DateOfOrder))
                    .ForMember(dest => dest.DateOfSolemnization, opts => opts.MapFrom(src => src.DateOfSolemnization))
                    .ForMember(dest => dest.DivorceInfoId, opts => opts.MapFrom(src => src.DivorceInfoId))
                    .ForMember(dest => dest.IsConsentFiled, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsConsentFiled))
                    .ForMember(dest => dest.IsDivorceWrit, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsDivorceWrit))
                    .ForMember(dest => dest.IsJudicialSeperationWrit, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsJudicialSeparationWrit))
                    .ForMember(dest => dest.IsNullityOfMarriageWrit, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsNullityOfMarriageWrit))
                    .ForMember(dest => dest.IsOrderExists, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsOrderExists))
                    .ForMember(dest => dest.IsPreDeathDivorce, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPreDeathDivorce))
                    .ForMember(dest => dest.IsResJudicialSeperation, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsResJudicialSeparation))
                    .ForMember(dest => dest.JurDomicileInfoForDefendant, opts => opts.ResolveUsing<JurisdictionDominicleForPartyToStringResolver>().FromMember(src => src.JurDomicileInfoForDefendant))
                    .ForMember(dest => dest.JurDomicileInfoForPlaintiff, opts => opts.ResolveUsing<JurisdictionDominicleForPartyToStringResolver>().FromMember(src => src.JurDomicileInfoForPlaintiff))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MarriageCertNo, opts => opts.MapFrom(src => src.MarriageCertNo))
                    .ForMember(dest => dest.MatrimonialPropInd, opts => opts.ResolveUsing<ParentingPlanToStringResolver>().FromMember(src => src.MatrimonialPropInd))
                    .ForMember(dest => dest.NOAFiledwithin, opts => opts.MapFrom(src => src.NOAFiledWithin))
                    .ForMember(dest => dest.OrderNumber, opts => opts.MapFrom(src => src.OrderNumber))
                    .ForMember(dest => dest.OSCaseNo, opts => opts.MapFrom(src => src.OSCaseNo))
                    .ForMember(dest => dest.ParentingPlanInd, opts => opts.ResolveUsing<ParentingPlanToStringResolver>().FromMember(src => src.ParentingPlanInd))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.TypeofJurDefendant, opts => opts.ResolveUsing<TypeOfJurisdictionToStringResolver>().FromMember(src => src.TypeofJurDefendant))
                    .ForMember(dest => dest.TypeofJurPlaintiff, opts => opts.ResolveUsing<TypeOfJurisdictionToStringResolver>().FromMember(src => src.TypeofJurPlaintiff))
                    .ForMember(dest => dest.HDBPropertyInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HDBPropertyInd))
                    .ForMember(dest => dest.RelatedProceedingInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.RelatedProceedingInd))
                    .ForMember(dest => dest.AgreementOnAMInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.AgreementOnAMInd))
                    .ForMember(dest => dest.CertificateOfAttendanceInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CertificateOfAttendanceInd))
                    .ForMember(dest => dest.ExemptionCertificateInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ExemptionCertificateInd))
                    .ForMember(dest => dest.LeaveOfCourtToClaimInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.LeaveOfCourtToClaimInd))
                    .ForMember(dest => dest.LeaveOfCourtToClaimCaseNo, opts => opts.MapFrom(src => src.LeaveOfCourtToClaimCaseNo))
                    .ForMember(dest => dest.LeaveOfCourtToClaimOrderDate, opts => opts.MapFrom(src => src.LeaveOfCourtToClaimOrderDate))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDivorceInfoEntityToDivorceInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocAppProcessByExAgencyEntity"/> to <see cref="DocAppProcessByExAgency"/>.
        /// </summary>
        internal void MapDocAppProcessByExAgencyEntityToDocAppProcessByExAgency()
        {
            try
            {
                Mapper.CreateMap<DocAppProcessByExAgencyEntity, DocAppProcessByExAgency>()
                    .ForMember(desc => desc.CaseInfo, opts => opts.ResolveUsing<StringToCaseInfoResolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.LawFirmDAPBEALFIDToDisplay, opts => opts.ResolveUsing<StringToLawFirmResolver>().FromMember(src => src.LFIDToDisplay))
                    .ForMember(desc => desc.VerifiedApplicantDetail, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.VerifiedApplicantDetail))
                    .ForMember(desc => desc.VerifiedAppointmentDetail, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.VerifiedAppointmentDetail))
                    .ForMember(desc => desc.IsD1Saved, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsD1Saved))
                    .ForMember(desc => desc.IsD2Saved, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsD2Saved))
                    .ForMember(desc => desc.IsD3Saved, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsD3Saved))
                    .ForMember(desc => desc.IsAccRptLawSoc, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAccRptLawSoc));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocAppProcessByExAgencyEntityToDocAppProcessByExAgency", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="EmploymentInfoEntity"/> to <see cref="EmploymentInfo"/>.
        /// </summary>
        internal void MapEmploymentInfoEntityToEmploymentInfo()
        {
            try
            {
                Mapper.CreateMap<EmploymentInfoEntity, EmploymentInfo>();
                //.ForMember(desc => desc.LawFirm, opt => opt.ResolveUsing<StringToLawFirmResolver>().FromMember(src => src.LFID));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapEmploymentInfoEntityToEmploymentInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="FilingFeeDetailEntity"/> to <see cref="FilingFeeDetail"/>.
        /// </summary>
        internal void MapFilingFeeDetailEntityToFilingFeeDetail()
        {
            try
            {
                Mapper.CreateMap<FilingFeeDetailEntity, FilingFeeDetail>()
                 .ForMember(desc => desc.LawSocietyRejFeeType, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.LawSocietyRejFeeType))
                 .ForMember(desc => desc.SALRejFeeType, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SALRejFeeType))
                 .ForMember(desc => desc.SALWaiverAppInd, opts => opts.ResolveUsing<WaiverIndToStringResolver>().FromMember(src => src.SALWaiverAppInd))
                 .ForMember(desc => desc.LawSocietyWaiverAppInd, opts => opts.ResolveUsing<WaiverIndToStringResolver>().FromMember(src => src.LawSocietyWaiverAppInd))
                 .ForMember(desc => desc.SILERejFeeType, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SILERejFeeType))
                 .ForMember(desc => desc.IsUrgentHandling, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsUrgentHandling))
                 .ForMember(desc => desc.IsInterfaced, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInterfaced))
                 .ForMember(desc => desc.IsEstimated, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsEstimated))
                 .ForMember(desc => desc.WaiverType, opts => opts.ResolveUsing<WaiverTypeToStringResolver>().FromMember(src => src.WaiverType))
                 .ForMember(desc => desc.IsPaymentCollected, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPaymentCollected))
                .ForMember(desc => desc.IsPOHARelated, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPOHARelated));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapUnliquidatedClaimEntityToUnliquidatedClaim", ex);
                throw;
            }
        }

        internal void MapForeignLPSolicitorRegDetailEntityToForeignLPSolicitorRegDetail()
        {
            try
            {
                Mapper.CreateMap<ForeignLPSolicitorRegDetailEntity, ForeignLPSolicitorRegDetail>()
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapForeignLPSolicitorRegDetailEntityToForeignLPSolicitorRegDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ForeignLPSolicitorRegEntity"/> to <see cref="ForeignLPSolicitorReg"/>.
        /// </summary>
        internal void MapForeignLPSolicitorRegEntityToForeignLPSolicitorReg()
        {
            try
            {
                Mapper.CreateMap<ForeignLPSolicitorRegEntity, ForeignLPSolicitorReg>()
                    .ForMember(desc => desc.CaseInfoId, opt => opt.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(desc => desc.IsAccRptstatus, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAccRptstatus));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapForeignLPSolicitorRegEntityToForeignLPSolicitorReg", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="GroundInfoEntity"/> to <see cref="GroundInfo"/>.
        /// </summary>
        internal void MapGroundInfoEntityToGroundInfo()
        {
            try
            {
                Mapper.CreateMap<GroundInfoEntity, GroundInfo>()
                    .ForMember(dest => dest.GroundInfoId, opts => opts.MapFrom(src => src.GroundInfoId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.Level, opts => opts.MapFrom(src => src.Level))
                    .ForMember(dest => dest.RequestedGrounds, opts => opts.MapFrom(src => src.RequestedGrounds))
                    .ForMember(dest => dest.SubLevel, opts => opts.MapFrom(src => src.SubLevel))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapGroundsEntityToGrounds", ex);
                throw;
            }
        }

        internal void MapInfantInfoEntityToInfantInfo()
        {
            try
            {
                Mapper.CreateMap<InfantInfoEntity, InfantInfo>()
                    .ForMember(dest => dest.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                    .ForMember(dest => dest.IsInfantMarried, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInfantMarried))
                    .ForMember(dest => dest.IsInfantProperty, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInfantProperty))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapInfantInfoEntityToInfantInfo", ex);
                throw;
            }
        }

        internal void MapLegalExperienceInfoEntityToLegalExperienceInfo()
        {
            try
            {
                Mapper.CreateMap<LegalExperienceInfoEntity, LegalExperienceInfo>()
                    .ForMember(dest => dest.LegalExperienceType, opts => opts.ResolveUsing<LegalExperienceTypeToStringResolver>().FromMember(src => src.LegalExperienceType))
                .ForMember(dest => dest.TypeofOrganization, opts => opts.ResolveUsing<LegalOrganizationTypeToStringResolver>().FromMember(src => src.TypeofOrganization));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapLegalExperienceInfoEntityToLegalExperienceInfo", ex);
                throw;
            }
        }

        internal void MapLegislationProvisionEntityToLegislationProvision()
        {
            try
            {
                Mapper.CreateMap<LegislationProvisionsEntity, LegislationProvision>()
                    .ForMember(desc => desc.MainLegInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MainLegInd))
                    .ForMember(desc => desc.CrimeCaseInd, opts => opts.ResolveUsing<CrimeCaseToStringResolver>().FromMember(src => src.CrimeCaseInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLegislationProvisionEntityToLegislationProvision", ex);
                throw;
            }
        }

        internal void MapLiquidatedClaimEntityToLiquidatedClaim()
        {
            Mapper.CreateMap<LiquidatedClaimEntity, LiquidatedClaim>()
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.LIQAmount, opts => opts.MapFrom(src => src.LIQAmount))
                .ForMember(desc => desc.LIQAwardedAmount, opts => opts.MapFrom(src => src.LIQAwardedAmount))
                .ForMember(desc => desc.LIQSGDAmount, opts => opts.MapFrom(src => src.LIQSGDAmount))
                .ForMember(desc => desc.LiquidatedClaimId, opts => opts.MapFrom(src => src.LiquidatedClaimId))
                .ForMember(desc => desc.LIQCurrencyCode, opts => opts.ResolveUsing<MCurrencyEntityToStringResolver>().FromMember(src => src.MCurrency))
                .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
        }

        ///// <summary>
        ///// Maps objects from <see cref="ADMInfo"/> to <see cref="AdmInfoEntity"/>.
        ///// </summary>
        //internal void MapLiquidatedClaimTLiquidatedClaimEntity()
        //{
        //    try
        //    {
        //        Mapper.CreateMap<LiquidatedClaim, LiquidatedClaimEntity>()
        //            .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
        //            .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
        //            .ForMember(dest => dest.LIQAmount, opts => opts.MapFrom(src => src.LIQAmount))
        //            .ForMember(dest => dest.LIQAwardedAmount, opts => opts.MapFrom(src => src.LIQAwardedAmount))
        //            .ForMember(dest => dest.LIQSGDAmount, opts => opts.MapFrom(src => src.LIQSGDAmount))
        //            .ForMember(dest => dest.LiquidatedClaimId, opts => opts.MapFrom(src => src.LiquidatedClaimId))
        //            .ForMember(dest => dest.MCurrency, opts => opts.MapFrom(src => src.MCurrency))
        //            .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
        internal void MapLiquidatorAddressEntityToLiquidatorAddress()
        {
            try
            {
                Mapper.CreateMap<LiquidatorAddressEntity, LiquidatorAddress>()
                    .ForMember(desc => desc.Addr1, opts => opts.MapFrom(src => src.Addr1))
                    .ForMember(desc => desc.Addr2, opts => opts.MapFrom(src => src.Addr2))
                    .ForMember(desc => desc.Addr3, opts => opts.MapFrom(src => src.Addr3))
                    .ForMember(desc => desc.Addr4, opts => opts.MapFrom(src => src.Addr4))
                    .ForMember(desc => desc.Address, opts => opts.MapFrom(src => src.Address))
                    .ForMember(desc => desc.AddrType, opts => opts.ResolveUsing<AddressTypeToStringResolver>().FromMember(src => src.AddrType))
                    .ForMember(desc => desc.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                    .ForMember(desc => desc.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                    .ForMember(desc => desc.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
                    .ForMember(desc => desc.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                    .ForMember(desc => desc.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                    .ForMember(desc => desc.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LiquidatorAddressId, opts => opts.MapFrom(src => src.LiquidatorAddressId))
                    .ForMember(desc => desc.MailingInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MailingInd))
                    .ForMember(desc => desc.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                    .ForMember(desc => desc.StreetName, opts => opts.MapFrom(src => src.StreetName))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.LiquidatorId, opts => opts.MapFrom(src => src.LiquidatorId))
                    .ForMember(desc => desc.UnitNo, opts => opts.MapFrom(src => src.UnitNo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLiquidatorAddressEntityToLiquidatorAddress", ex);
                throw;
            }
        }

        internal void MapLiquidatorAliasEntityToLiquidatorAlias()
        {
            try
            {
                Mapper.CreateMap<LiquidatorAliasEntity, LiquidatorAlias>()
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
                Logger.Error("Error at MapLiquidatorAliasEntityToLiquidatorAlias", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LiquidatorEntity"/> to <see cref="Liquidator"/>.
        /// </summary>
        internal void MapLiquidatorEntityToLiquidator()
        {
            try
            {
                Mapper.CreateMap<LiquidatorEntity, Liquidator>()
                    .ForMember(desc => desc.CompanyName, opts => opts.MapFrom(src => src.CompanyName))
                    .ForMember(desc => desc.ContactTypeInd, opts => opts.ResolveUsing<ContactTypeToStringResolver>().FromMember(src => src.ContactTypeInd))
                    .ForMember(desc => desc.DateOfRegistration, opts => opts.MapFrom(src => src.DateOfRegistration))
                    .ForMember(desc => desc.Email, opts => opts.MapFrom(src => src.Email))
                    .ForMember(desc => desc.FaxAreaCode, opts => opts.MapFrom(src => src.FaxAreaCode))
                    .ForMember(desc => desc.FaxCountryCode, opts => opts.MapFrom(src => src.FaxCountryCode))
                    .ForMember(desc => desc.FaxNumber, opts => opts.MapFrom(src => src.FaxNumber))
                    .ForMember(desc => desc.FormerCompanyName, opts => opts.MapFrom(src => src.FormerCompanyName))
                    .ForMember(desc => desc.FormerPersonName, opts => opts.MapFrom(src => src.FormerPersonName))
                    .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(desc => desc.FullName, opts => opts.MapFrom(src => src.FullName))
                    .ForMember(desc => desc.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LiquidatorAddresses, opts => opts.Ignore())
                    .ForMember(desc => desc.LiquidatorAliases, opts => opts.Ignore())
                    .ForMember(desc => desc.LiquidatorId, opts => opts.MapFrom(src => src.LiquidatorId))
                    .ForMember(desc => desc.LiquidatorPICs, opts => opts.Ignore())
                    .ForMember(desc => desc.MobileCountryCode, opts => opts.MapFrom(src => src.MobileCountryCode))
                    .ForMember(desc => desc.MobileNumber, opts => opts.MapFrom(src => src.MobileNumber))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.TelAreaCode, opts => opts.MapFrom(src => src.TelAreaCode))
                    .ForMember(desc => desc.TelCountryCode, opts => opts.MapFrom(src => src.TelCountryCode))
                    .ForMember(desc => desc.TelNumber, opts => opts.MapFrom(src => src.TelNumber))
                    .ForMember(desc => desc.UEN, opts => opts.MapFrom(src => src.UEN));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLiquidatorEntityToLiquidator", ex);
                throw;
            }
        }

        internal void MapLiquidatorPICAddressEntityToLiquidatorPICAddress()
        {
            try
            {
                Mapper.CreateMap<LiquidatorPICAddressEntity, LiquidatorPICAddress>()
                    .ForMember(desc => desc.Addr1, opts => opts.MapFrom(src => src.Addr1))
                    .ForMember(desc => desc.Addr2, opts => opts.MapFrom(src => src.Addr2))
                    .ForMember(desc => desc.Addr3, opts => opts.MapFrom(src => src.Addr3))
                    .ForMember(desc => desc.Addr4, opts => opts.MapFrom(src => src.Addr4))
                    .ForMember(desc => desc.Address, opts => opts.MapFrom(src => src.Address))
                    .ForMember(desc => desc.AddrType, opts => opts.ResolveUsing<AddressTypeToStringResolver>().FromMember(src => src.AddrType))
                    .ForMember(desc => desc.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                    .ForMember(desc => desc.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                    .ForMember(desc => desc.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
                     .ForMember(desc => desc.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                    .ForMember(desc => desc.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
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
                Logger.Error("Error at MapLiquidatorPICAddressEntityToLiquidatorPICAddress", ex);
                throw;
            }
        }

        internal void MapLiquidatorPICAliasEntityToLiquidatorPICAlias()
        {
            try
            {
                Mapper.CreateMap<LiquidatorPICAliasEntity, LiquidatorPICAlias>()
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
                Logger.Error("Error at MapLiquidatorPICAliasEntityToLiquidatorPICAlias", ex);
                throw;
            }
        }

        internal void MapLiquidatorPICEntityToLiquidatorPIC()
        {
            try
            {
                Mapper.CreateMap<LiquidatorPICEntity, LiquidatorPIC>()
                    .ForMember(desc => desc.AddressAvailabilityInd, opts => opts.ResolveUsing<AddressAvailabilityTypeToStringResolver>().FromMember(src => src.AddressAvailabilityInd))
                    .ForMember(desc => desc.AICRemarks, opts => opts.MapFrom(src => src.AICRemarks))
                    .ForMember(desc => desc.FormerName, opts => opts.MapFrom(src => src.FormerName))
                    .ForMember(desc => desc.FullName, opts => opts.MapFrom(src => src.FullName))
                    .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(desc => desc.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                    .ForMember(desc => desc.LiquidatorPICAddresses, opts => opts.Ignore())
                    .ForMember(desc => desc.LiquidatorPICAliases, opts => opts.Ignore())
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LiquidatorPICId, opts => opts.MapFrom(src => src.LiquidatorId))
                    .ForMember(desc => desc.LiquidatorPICId, opts => opts.MapFrom(src => src.LiquidatorPICId))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLiquidatorPICEntityToLiquidatorPIC", ex);
                throw;
            }
        }

        internal void MapMinuteSheetDocListEntityToMinuteSheetDocList()
        {
            try
            {
                Mapper.CreateMap<MinuteSheetDocListEntity, MinuteSheetDocList>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMinuteSheetDocListEntityToMinuteSheetDocList", ex);
                throw;
            }
        }

        internal void MapMinuteSheetFamilyRelatedInfoEntityToMinuteSheetFamilyRelatedInfo()
        {
            try
            {
                Mapper.CreateMap<MinuteSheetFamilyRelatedInfoEntity, MinuteSheetFamilyRelatedInfo>()
                    .ForMember(dest => dest.IsHRGOutComeForCC, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsHRGOutComeForCC))
                    .ForMember(dest => dest.IsHRGOutComeForWrit, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsHRGOutComeForWrit))
                    .ForMember(dest => dest.IsIJMadeForCC, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsIJMadeForCC))
                    .ForMember(dest => dest.IsIJMadeForSOC, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsIJMadeForSOC))
                    .ForMember(dest => dest.IsStandardCPFOrderGenerated, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsStandardCPFOrderGenerated));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMinuteSheetFamilyRelatedInfoEntityToMinuteSheetFamilyRelatedInfo", ex);
                throw;
            }
        }

        internal void MapMinuteSheetGroundInfoEntityToMinuteSheetGroundInfo()
        {
            try
            {
                Mapper.CreateMap<MinuteSheetGroundInfoEntity, MinuteSheetGroundInfo>()
                    .ForMember(dest => dest.ClaimForPNOrDef, opts => opts.ResolveUsing<ClaimForPNOrDefToStringResolver>().FromMember(src => src.ClaimForPNOrDef))
                    .ForMember(dest => dest.Is3YearsSeparationWithConsent, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.Is3YearsSeparationWithConsent))
                    .ForMember(dest => dest.Is4YearsSeparation, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.Is4YearsSeparation))
                    .ForMember(dest => dest.IsAdultery, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAdultery))
                    .ForMember(dest => dest.IsDesertionFor2Years, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsDesertionFor2Years))
                    .ForMember(dest => dest.IsNonConsummationFor, opts => opts.ResolveUsing<ClaimForPNOrDefToStringResolver>().FromMember(src => src.IsNonConsummationFor))
                    .ForMember(dest => dest.IsNonConsummationOwingToInCap, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsNonConsummationOwingToInCap))
                    .ForMember(dest => dest.IsNonConsummationRefused, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsNonConsummationRefused))
                    .ForMember(dest => dest.IsUnreasonableBehavior, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsUnreasonableBehavior))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMinuteSheetGroundInfoEntityToMinuteSheetGroundInfo", ex);
                throw;
            }
        }

        internal void MapMinuteSheetInfoEntityToMinuteSheetInfo()
        {
            try
            {
                Mapper.CreateMap<MinuteSheetInfoEntity, MinuteSheetInfo>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.OrderMadeIn, opts => opts.ResolveUsing<OrderMadeInToStringResolver>().FromMember(src => src.OrderMadeIn))
                    .ForMember(dest => dest.HearingCategory, opts => opts.ResolveUsing<HearingCategoryToStringResolver>().FromMember(src => src.HearingCategory))
                     .ForMember(dest => dest.RequestForSubCaseInd, opts => opts.ResolveUsing<SubCaseRequestIndToStringResolver>().FromMember(src => src.RequestForSubCaseInd))
                    .ForMember(dest => dest.RequestForSplLetterInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.RequestForSplLetterInd));
                

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMinuteSheetInfoEntityToMinuteSheetInfo", ex);
                throw;
            }
        }

        internal void MapMinuteSheetPartyRepInfoEntityToMinuteSheetPartyRepInfo()
        {
            try
            {
                Mapper.CreateMap<MinuteSheetPartyRepInfoEntity, MinuteSheetPartyRepInfo>()
                    .ForMember(dest => dest.PartyRepresentationType, opts => opts.ResolveUsing<PartyRepresentationTypeToStringResolver>().FromMember(src => src.PartyRepresentationType));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMinuteSheetPartyRepInfoEntityToMinuteSheetPartyRepInfo", ex);
                throw;
            }
        }

        internal void MapMinuteSheetPartySolicitorInfoEntityToMinuteSheetPartySolicitorInfo()
        {
            try
            {
                Mapper.CreateMap<MinuteSheetPartySolicitorInfoEntity, MinuteSheetPartySolicitorInfo>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMinuteSheetPartySolicitorInfoEntityToMinuteSheetPartySolicitorInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="NatureOfAppeal"/> to <see cref="NatureOfAppealEntity"/>.
        /// </summary>
        internal void MapNatureOfAppealEntityToNatureOfAppeal()
        {
            try
            {
                Mapper.CreateMap<NatureOfAppealEntity, NatureOfAppeal>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapNatureOfAppealEntityToNatureOfAppeal", ex);
                throw;
            }
        }

        /// Method which maps the <see cref="NatureOfCaseEntity"/> to <see cref="NatureOfCase"/>.
        /// </summary>
        internal void MapNatureOfApplicationEntityToNatureOfApplication()
        {
            try
            {
                Mapper.CreateMap<NatureOfApplicationEntity, NatureOfApplication>()
                   .ForMember(desc => desc.MainInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MainInd))
                   .ForMember(desc => desc.MNOACode, opts => opts.MapFrom(src => src.MNOACodeEntity))
                   .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                   .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapNatureOfApplicationEntityToNatureOfApplication", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="NatureOfCase"/> to <see cref="NatureOfCaseEntity"/>.
        /// </summary>
        internal void MapNatureOfCaseEntityToNatureOfCase()
        {
            try
            {
                Mapper.CreateMap<NatureOfCaseEntity, NatureOfCase>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.MainNOCInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src=>src.MainNOCInd))
                    .ForMember(dest => dest.MNOC, opts => opts.MapFrom(src => src.MNatureOfCase))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.OtherText, opts => opts.MapFrom(src => src.OtherText))
                    .ForMember(dest => dest.NatureOfCaseId, opts => opts.MapFrom(src => src.NatureOfCaseId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapNatureOfCaseEntityToNatureOfCase", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="NotPaymenttoCourtDocDetailEntity"/> to <see cref="NotPaymentToCourtDocDetail"/>.
        /// </summary>
        internal void MapNotPaymentToCourtDocDetailEntityToNotPaymentToCourtDocDetail()
        {
            try
            {
                Mapper.CreateMap<NotPaymenttoCourtDocDetailEntity, NotPaymentToCourtDocDetail>()
                    .ForMember(dest => dest.Amount, opts => opts.MapFrom(src => src.Amount))
                    .ForMember(dest => dest.AmountSGD, opts => opts.MapFrom(src => src.AmountSGD))
                    .ForMember(dest => dest.NotPayeCourtDetailId, opts => opts.MapFrom(src => src.NotPayeCourtDetailId))
                    .ForMember(dest => dest.PaymentInDocDetail, opts => opts.ResolveUsing<StringToPaymentInDocDetailResolver>().FromMember(src => src.PaymentInId))
                    .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapNotPaymentToCourtDocDetailEntityToNotPaymentToCourtDocDetail", ex);
                throw;
            }
        }

        internal void MapOrdersMadeEntityToOrdersMade()
        {
            try
            {
                Mapper.CreateMap<OrdersMadeEntity, OrdersMade>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOrdersMadeEntityToOrdersMade", ex);
                throw;
            }
        }

        //internal void MapNoOfSupportingDocEntityToNoOfSupportingDoc()
        //{
        //    Mapper.CreateMap<NoOfSupportingDocEntity, NoOfSupportingDoc>()
        //       .ForMember(desc => desc.Count, opts => opts.MapFrom(src => src.Count))
        //        //.ForMember(desc => desc.DocCode, opts => opts.MapFrom(src => src.DocCode))
        //       .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
        //       .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
        //       .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
        //       .ForMember(desc => desc.SupdocId, opts => opts.MapFrom(src => src.SupdocId));
        //}
        internal void MapOriginatingCaseEntityToOriginatingCase()
        {
            Mapper.CreateMap<OriginatingCaseEntity, OriginatingCase>()
                .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId))
                .ForMember(desc => desc.OriginatingCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.OriginatingCaseInfoId))
                .ForMember(desc => desc.OriginatingCaseNo, opts => opts.MapFrom(src => src.OriginatingCaseNo))
                .ForMember(desc => desc.MCourtType, opts => opts.MapFrom(src => src.CourtId));
        }

        internal void MapOtherITMOEntityToOtherITMO()
        {
            try
            {
                Mapper.CreateMap<OtherITMOEntity, OtherITMO>()
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
                Logger.Error("Error at MapOtherITMOEntityToOtherITMO", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="OtherReliefsClaim"/> to <see cref="OtherReliefsClaimEntity"/>.
        /// </summary>
        internal void MapOtherReliefsClaimEntityToOtherReliefsClaim()
        {
            try
            {
                Mapper.CreateMap<OtherReliefsClaimEntity, OtherReliefsClaim>()
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MRelief, opts => opts.MapFrom(src => src.MRelief))
                    .ForMember(dest => dest.ReliefRemarks, opts => opts.MapFrom(src => src.ReliefRemarks))
                    .ForMember(dest => dest.OtherReliefsClaimId, opts => opts.MapFrom(src => src.OtherReliefsClaimId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOtherReliefsClaimEntityToOtherReliefsClaim", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PCAppDatesFromSALEntity"/> to <see cref="PCAppDatesFromSAL"/>.
        /// </summary>
        internal void MapPCAppDatesFromSALEntityToPCAppDatesFromSAL()
        {
            try
            {
                Mapper.CreateMap<PCAppDatesFromSALEntity, PCAppDatesFromSAL>()
                    .ForMember(desc => desc.CaseInfoId, opt => opt.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(desc => desc.SubCaseInfoId, opt => opt.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPCAppDatesFromSALEntityToPCAppDatesFromSAL", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PCAppDetailsFromSALEntity"/> to <see cref="PCAppDetailsFromSAL"/>.
        /// </summary>
        internal void MapPCAppDetailsFromSALEntityToPCAppDetailsFromSAL()
        {
            try
            {
                Mapper.CreateMap<PCAppDetailsFromLawSocEntity, PCAppDetailsFromLawSoc>()
                    .ForMember(desc => desc.CaseInfo, opt => opt.ResolveUsing<StringToCaseInfoResolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(desc => desc.SubCaseInfo, opt => opt.ResolveUsing<StringToSubCaseInfoResolver>().FromMember(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPCAppDetailsFromSALEntityToPCAppDetailsFromSAL", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PCConditionInfoEntity"/> to <see cref="PCConditionInfo"/>.
        /// </summary>
        internal void MapPCConditionInfoEntityToPCConditionInfo()
        {
            try
            {
                Mapper.CreateMap<PCConditionInfoEntity, PCConditionInfo>()
                    .ForMember(dest => dest.HasJudicialOffUpdated, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasJudicialOffUpdated))
                    .ForMember(dest => dest.IsAGCApproved, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAGCApproved))
                    .ForMember(dest => dest.IsLAWSOCApproved, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsLAWSOCApproved))
                    .ForMember(dest => dest.IsSALApproved, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSALApproved));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPCConditionInfoEntityToPCConditionInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PrayerEntity"/> to <see cref="Prayer"/>.
        /// </summary>
        internal void MapPrayerEntityToPrayer()
        {
            try
            {
                Mapper.CreateMap<PrayerEntity, Prayer>()
                    .ForMember(dest => dest.GrantedPara, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.GrantedPara))
                    .ForMember(dest => dest.GrantedPrayer, opts => opts.MapFrom(src => src.GrantedPrayer))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.Level, opts => opts.MapFrom(src => src.Level))
                    .ForMember(dest => dest.MPrayerOutcome, opts => opts.MapFrom(src => src.MPrayerOutcome))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.PrayerParaNo, opts => opts.MapFrom(src => src.PrayerParaNo))
                    .ForMember(dest => dest.PrayersId, opts => opts.MapFrom(src => src.PrayersId))
                    .ForMember(dest => dest.RequestedPrayer, opts => opts.MapFrom(src => src.RequestedPrayer))
                    .ForMember(dest => dest.SubLevel, opts => opts.MapFrom(src => src.SubLevel))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPrayersEntityToPrayers", ex);
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
                    .ForMember(dest => dest.ADMCavetNoId, opts => opts.MapFrom(src => src.ADMCaveatNoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRefCaveatCaseToRefCaveatCaseEntity", ex);
                throw;
            }
        }

        /*
        /// <summary>
        /// Method which maps the <see cref="QualificationInfoEntity"/> to <see cref="QualificationInfo"/>.
        /// </summary>
        internal void MapQualificationInfoEntityToQualificationInfo()
        {
            try
            {
                Mapper.CreateMap<QualificationInfoEntity, QualificationInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapQualificationInfoEntityToQualificationInfo", ex);
                throw;
            }
        }
        */
        internal void MapRefOrderDetailEntityToRefOrderDetail()
        {
            Mapper.CreateMap<RefOrderDetailEntity, RefOrderDetail>()
                .ForMember(desc => desc.AdditionalDetails, opts => opts.MapFrom(src => src.AdditionalDetails))
                .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.MDesignation, opts => opts.MapFrom(src => src.MDesignation))
                .ForMember(desc => desc.OrderCoram, opts => opts.MapFrom(src => src.OrderCoram))
                .ForMember(desc => desc.OrderDate, opts => opts.MapFrom(src => src.OrderDate))
                .ForMember(desc => desc.OrderNumber, opts => opts.MapFrom(src => src.OrderNumber))
                .ForMember(desc => desc.RefOrderDetailId, opts => opts.MapFrom(src => src.RefOrderDetailId))
                .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                .ForMember(desc => desc.OrderType, opts => opts.ResolveUsing<OrderTypeToStringResolver>().FromMember(src => src.OrderType))
                .ForMember(desc => desc.OrderMadeIn, opts => opts.ResolveUsing<OrderMadeInToStringResolver>().FromMember(src => src.OrderMadeIn))
                .ForMember(desc => desc.HasObtainedLOC, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasObtainedLOC))
                .ForMember(desc => desc.OrderOfCourtNotshownOrderNO, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.OrderOfCourtNotshownOrderNO))
                .ForMember(desc => desc.PurposeOfOrder, opts => opts.ResolveUsing<PurposeOfOrderToStringResolver>().FromMember(src => src.PurposeOfOrder));
        }

        internal void MapRefSubCaseEntityToRefSubCase()
        {
            Mapper.CreateMap<RefSubCaseEntity, RefSubCase>()
                .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.CaseInfoId))
                .ForMember(desc => desc.SubCaseInfoId, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.RefSubCaseId, opts => opts.MapFrom(src => src.RefSubCaseId))
                .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
        }

        /// <summary>
        /// Method which maps the <see cref="RelatedProceedingEntity"/> to <see cref="RelatedProceeding"/>.
        /// </summary>
        internal void MapRelatedProceedingEntityToRelatedProceeding()
        {
            try
            {
                Mapper.CreateMap<RelatedProceedingEntity, RelatedProceeding>()
                    .ForMember(dest => dest.CaseNo, opts => opts.MapFrom(src => src.CaseNo))
                    .ForMember(dest => dest.DateOfOrder, opts => opts.MapFrom(src => src.DateOfOrder))
                    .ForMember(dest => dest.DetailsOfOrder, opts => opts.MapFrom(src => src.DetailsOfOrder))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.OtherProceedingInfo, opts => opts.MapFrom(src => src.OtherProceedingInfo))
                    .ForMember(dest => dest.RelatedCaseId, opts => opts.MapFrom(src => src.RelatedCaseId))
                    .ForMember(dest => dest.StatusOfProceedings, opts => opts.MapFrom(src => src.StatusOfProceedings))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRelatedProceedingEntityToRelatedProceeding", ex);
                throw;
            }
        }



        /// <summary>
        /// Method which maps the <see cref="SubmissionInfoEntity"/> to <see cref="SubmissionInfo"/>.
        /// </summary>
        internal void MapSubmissionInfoEntityToSubmissionInfo()
        {
            try
            {
                Mapper.CreateMap<SubmissionInfoEntity, SubmissionInfo>()
                    .ForMember(dest => dest.AccountId, opts => opts.MapFrom(src => src.AccountId))
                    .ForMember(dest => dest.ETA, opts => opts.MapFrom(src => src.ETA))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(dest => dest.Stage, opts => opts.ResolveUsing<SubmissionStageToStringResolver>().FromMember(src => src.Stage))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.SubmissionNumber, opts => opts.MapFrom(src => src.SubmissionNumber))
                    .ForMember(dest=>dest.IsCaseArchived,opts=>opts.ResolveUsing<YesNoToStringResolver>().FromMember(src=>src.IsCaseArchived))
                    .ForMember(dest => dest.LFAccountIdToCharge, opts => opts.MapFrom(src => src.LFAccountIdToCharge));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSubmissionInfoEntityToSubmissionInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="TravelPassInfoEntity"/> to <see cref="TravelPassInfo"/>.
        /// </summary>
        internal void MapTravelPassInfoEntityToTravelPassInfo()
        {
            try
            {
                Mapper.CreateMap<TravelPassInfoEntity, TravelPassInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapTravelPassInfoEntityToTravelPassInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="UnliquidatedClaim"/> to <see cref="UnliquidatedClaimEntity"/>.
        /// </summary>
        internal void MapUnliquidatedClaimEntityToUnliquidatedClaim()
        {
            try
            {
                Mapper.CreateMap<UnliquidatedClaimEntity, UnliquidatedClaim>()
                    .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.UnLIQClaimType, opts => opts.MapFrom(src => src.UnLIQClaimType))
                    .ForMember(dest => dest.UnliquidatedClaimId, opts => opts.MapFrom(src => src.UnliquidatedClaimId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapUnliquidatedClaimEntityToUnliquidatedClaim", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the WOECaseExecutionAddress entity to WOECaseExecutionAddress.
        /// </summary>
        internal void MapWOECaseExecutionAddressEntityToWOECaseExecutionAddress()
        {
            try
            {
                Mapper.CreateMap<WOECaseExecutionAddressEntity, WOECaseExecutionAddress>()
                    .ForMember(dest=>dest.SyncRequired,opts=>opts.ResolveUsing<YesNoToStringResolver>().FromMember(src=>src.SyncRequired));
            }
            catch(Exception ex)
            {
                Logger.Error("Error encountered at MapWOECaseExecutionAddressEntityToWOECaseExecutionAddress", ex);
                throw;
            }
        }

        internal void MapWOEExecutionAddressEntityToWOEExecutionAddress()
        {
            try
            {
                Mapper.CreateMap<WOEExecutionAddressEntity, WOEExecutionAddress>()
                    .ForMember(dest => dest.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWOEExecutionAddressEntityToWOEExecutionAddress", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the apppeal time estimation detail entity to appeal time estimation detail.
        /// </summary>
        internal void MapApppealTimeEstimationDetailEntityToAppealTimeEstimationDetail()
        {
            try
            {
                Mapper.CreateMap<AppealTimeEstimationDetailEntity, AppealTimeEstimationDetail>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.CaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapApppelTimeEstimationDetailEntityToAppealTimeEstimationDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the notice to refer affidavit entity to notice to refer affidavit.
        /// </summary>
        internal void MapNoticeToReferAffidavitEntityToNoticeToReferAffidavit()
        {
            try
            {
                Mapper.CreateMap<NoticeToReferAffidavitEntity, NoticeToReferAffidavit>()
                    .ForMember(desc => desc.IsDocArchived, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsDocArchived));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapNoticeToReferAffidavitEntityToNoticeToReferAffidavit", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the notice to refer affidavit entity to notice to refer affidavit.
        /// </summary>
        internal void MapClaimAmountEntityToClaimAmount()
        {
            try
            {
                Mapper.CreateMap<ClaimAmountEntity, ClaimAmount>()
                    .ForMember(dest => dest.Amount, opts => opts.MapFrom(src => src.ClaimAmount))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapClaimAmountEntityToClaimAmount", ex);
                throw;
            }
        }

        internal void MapRespondentCaseDetailInfoEntityToRespondentCaseDetail()
        {
            try
            {
                Mapper.CreateMap<RespondentCaseDetailInfoEntity, RespondentCaseDetailInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRespondentCaseDetailInfoEntityToRespondentCaseDetail", ex);
                throw;
            }
        }

        internal void MapCheckListCommentEntityToCheckListComment()
        {
            try
            {
                Mapper.CreateMap<CheckListCommentEntity, CheckListComments>()
                    .ForMember(dest => dest.Status, opts => opts.ResolveUsing<ChecklistCommentStatusToStringResolver>().FromMember(src => src.Status))
                    .ForMember(dest => dest.Type, opts => opts.ResolveUsing<ChecklistCommentTypeToStringResolver>().FromMember(src => src.Type));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRespondentCaseDetailInfoEntityToRespondentCaseDetail", ex);
                throw;
            }
        }

        internal void MapRefOrderJOInfoEntityToRefOrderJOInfo()
        {
            try
            {
                Mapper.CreateMap<RefOrderJOInfoEntity, RefOrderJOInfo>()
                     .ForMember(desc => desc.OrderType, opts => opts.ResolveUsing<OrderTypeToStringResolver>().FromMember(src => src.OrderType));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRefOrderJOInfoEntityToRefOrderJOInfo", ex);
                throw;
            }
        }

        internal void MapInterfaceNBSReportEntityToInterfaceNBSReport()
        {
            try
            {
                Mapper.CreateMap<InterfaceNBSReportEntity, InterfaceNBSReport>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapInterfaceNBSReportEntityToInterfaceNBSReport", ex);
                throw;
            }
        }

        internal void MapReqExaminationFeedetailEntityToReqExaminationFeedetail()
        {
            try
            {
                Mapper.CreateMap<ReqExaminationFeeDetailEntity, ReqExaminationFeeDetail>()
                      .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                      .ForMember(desc => desc.IsNBSInterfaced, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsNBSInterfaced));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapReqExaminationFeedetailEntityToReqExaminationFeedetail", ex);
                throw;
            }
        }

        internal void MapForeignUserRegAddressDetailsEntityToForeignUserRegAddressDetails()
        {
            try
            {
                Mapper.CreateMap<ForeignUserRegAddressDetailsEntity, ForeignUserRegAddressDetails>()
                      .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
                      
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapForeignUserRegAddressDetailsEntityToForeignUserRegAddressDetails", ex);
                throw;
            }
        }

        internal void MapForeignUserPracticeInformationEntityToForeignUserPracticeInformation()
        {
            try
            {
                Mapper.CreateMap<ForeignUserPracticeInformationEntity, ForeignUserPracticeInformation>()
                      .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapForeignUserPracticeInformationEntityToForeignUserPracticeInformation", ex);
                throw;
            }
        }

        internal void MapRegistrationOfForeignLawyerEntityToRegistrationOfForeignLawyer()
        {
            try
            {
                Mapper.CreateMap<RegistrationOfForeignLawyerEntity, RegistrationOfForeignLawyer>()
                      .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRegistrationOfForeignLawyerEntityToRegistrationOfForeignLawyer", ex);
                throw;
            }
        }

        internal void MapRFLValidityAndNotificationEntityToRFLValidityAndNotification()
        {
            try
            {
                Mapper.CreateMap<RFLValidityAndNotificationEntity, RFLValidityAndNotification>()
                      .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                      .ForMember(desc=>desc.RFLCaseInfoId,opts=>opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src=>src.RFLCaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRFLValidityAndNotificationEntityToRFLValidityAndNotification", ex);
                throw;
            }
        }


        internal void MapSICCFeeLedgerEntityToSICCFeeLedger()
        {
            try
            {
                Mapper.CreateMap<SICCFeeLedgerEntity, SICCFeeLedger>()
                      .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                      .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.CaseInfoId))
                      .ForMember(desc => desc.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                      .ForMember(dest => dest.Fees, opts => opts.MapFrom(src => src.Fees));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSICCFeeLedgerEntityToSICCFeeLedger", ex);
                throw;
            }
        }


        internal void MapSystemParametersEntityToSystemParameters()
        {
            try
            {
                Mapper.CreateMap<SystemParametersEntity, SystemParameters>()
                      .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSystemParametersEntityToSystemParameters", ex);
                throw;
            }
        }

        internal void MapRequestForExemptionEntityToRequestForExemption()
        {
            try
            {
                Mapper.CreateMap<RequestForExemptionEntity, RequestForExemption>()
                .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.CaseinfoId, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.CaseinfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRequestForExemptionEntityToRequestForExemption", ex);
                throw;
            }
        }

        internal void MapFeeCollectionDetailEntityToFeeCollectionDetail()
        {
            try
            {
                Mapper.CreateMap<FeeCollectionDetailEntity, FeeCollectionDetail>()
                      .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                      .ForMember(desc => desc.Collectionstatus, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.Collectionstatus))
                      ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapFeeCollectionDetailEntityToFeeCollectionDetail", ex);
                throw;
            }
        }

        internal void MapOutgoingCorrespondenceInfoEntityToOutgoingCorrespondenceInfo()
        {
            try
            {
                Mapper.CreateMap<OutgoingCorrespondenceInfoEntity, OutgoingCorrespondenceInfo>()
                    .ForMember(dest => dest.IsInterfaced, opts => opts.ResolveUsing<InterfaceStatusToStringResolver>().FromMember(src => src.IsInterfaced));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOutgoingCorrespondenceInfoEntityToOutgoingCorrespondenceInfo", ex);
                throw;
            }
        }

        internal void MapOutgoingCorrespondenceCourtFeeEntityToOutgoingCorrespondenceCourtFee()
        {
            try
            {
                Mapper.CreateMap<OutgoingCorrespondenceCourtFeeEntity, OutgoingCorrespondenceCourtFee>()
                    .ForMember(dest => dest.IsNBSInterfaced, opts => opts.ResolveUsing<InterfaceStatusToStringResolver>().FromMember(src => src.IsNBSInterfaced));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOutgoingCorrespondenceCourtFeeEntityToOutgoingCorrespondenceCourtFee", ex);
                throw;
            }
        }

        internal void MapLawFirmRegistrationEntityToLawFirmRegistration()
        {
            try
            {
                Mapper.CreateMap<LawFirmRegistrationEntity, LawFirmRegistration>()
                      .ForMember(desc => desc.LFRegId, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.LFRegID))
                      .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                      .ForMember(desc => desc.WaivedAccount, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.WaivedAccount))
                      .ForMember(desc => desc.JOLInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.JOLInd))
                      .ForMember(desc => desc.VerStatus, opts => opts.ResolveUsing<VerStatusToStringResolver>().FromMember(src => src.VerStatus))
                      ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapFeeCollectionDetailEntityToFeeCollectionDetail", ex);
                throw;
            }
        }

        internal void MapDocLegalExperienceInfoEntityToDocLegalExperienceInfo()
        {
            try
            {
                Mapper.CreateMap<DocLegalExperienceInfoEntity, DocLegalExperienceInfo>()
                    .ForMember(dest => dest.LegalExperienceType, opts => opts.ResolveUsing<LegalExperienceTypeToStringResolver>().FromMember(src => src.LegalExperienceType))
                    .ForMember(dest => dest.TypeofOrganization, opts => opts.ResolveUsing<LegalOrganizationTypeToStringResolver>().FromMember(src => src.TypeofOrganization))
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocLegalExperienceInfoEntityToDocLegalExperienceInfo", ex);
                throw;
            }
        }
        internal void MapCaseLegalExperienceInfoEntityToCaseLegalExperienceInfo()
        {
            try
            {
                Mapper.CreateMap<CaseLegalExperienceInfoEntity, CaseLegalExperienceInfo>()
                    .ForMember(dest => dest.LegalExperienceType, opts => opts.ResolveUsing<LegalExperienceTypeToStringResolver>().FromMember(src => src.LegalExperienceType))
                    .ForMember(dest => dest.TypeofOrganization, opts => opts.ResolveUsing<LegalOrganizationTypeToStringResolver>().FromMember(src => src.TypeofOrganization))
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocLegalExperienceInfoEntityToDocLegalExperienceInfo", ex);
                throw;
            }
        }

        internal void MapCORSolicitorRegEntityToCORSolicitorReg()
        {
            try
            {
                Mapper.CreateMap<CORSolicitorRegEntity, CORSolicitorReg>()
                    .ForMember(dest => dest.IsAccRptStatus, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAccRptStatus))
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCORSolicitorRegEntityToCORSolicitorReg", ex);
                throw;
            }
        }

        internal void MapCORSolicitorRegDetailsEntityToCORSolicitorRegDetails()
        {
            try
            {
                Mapper.CreateMap<CORSolicitorRegDetailsEntity, CORSolicitorRegDetails>()
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCORSolicitorRegDetailsEntityToCORSolicitorRegDetails", ex);
                throw;
            }
        }


        internal void MapDocCaseCounterClaimDetailsEntityToDocCaseCounterClaimDetails()
        {
            try
            {
                Mapper.CreateMap<DocCaseCounterClaimDetailsEntity, DocCaseCounterClaimDetails>()
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocCaseCounterClaimDetailsEntityToDocCaseCounterClaimDetails", ex);
                throw;
            }
        }

        internal void MapDocCaseCounterClaimEntityToDocCaseCounterClaim()
        {
            try
            {
                Mapper.CreateMap<DocCaseCounterClaimEntity, DocCaseCounterClaim>()
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(desc => desc.UpdateInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.UpdateInd))
                    .ForMember(desc => desc.CaseInfoID, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.CaseInfoID));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocCaseCounterClaimEntityToDocCaseCounterClaim", ex);
                throw;
            }
        }

        internal void MapCaseCounterClaimEntityToCaseCounterClaim()
        {
            try
            {
                Mapper.CreateMap<CaseCounterClaimEntity, CaseCounterClaim>()
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(desc => desc.CaseInfoID, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src => src.CaseInfoID));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseCounterClaimEntityToCaseCounterClaim", ex);
                throw;
            }
        }

        internal void MapCaseCounterClaimDetailsEntityToCaseCounterClaimDetails()
        {
            try
            {
                Mapper.CreateMap<CaseCounterClaimDetailsEntity, CaseCounterClaimDetails>()
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseCounterClaimDetailsEntityToCaseCounterClaimDetails", ex);
                throw;
            }
        }

        #endregion Methods
    }
}