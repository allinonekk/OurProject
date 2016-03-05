#region Header

/*****************************************************************************************************
* Description : This file handles mapping for CustomType Converters from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   28/09/2010   		      	Yan Nai                	 	Created
*   15/01/2011                  Swaroop                 Added logging and comments.
*****************************************************************************************************/
// <summary>
// File: CustomTypeMapping.cs
// Description: This file handles mapping for CustomType Converters from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "CustomTypeMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Master;

    using log4net;

    /// <summary>
    /// Class handles mapping for CustomType Converters from NHibernate entities to Domain objects.
    /// </summary>
    internal class CustomTypeMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CustomTypeMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method which maps the CustomType Converters from NHibernate entities to Domain objects.
        /// </summary>
        internal void NHibernateToDomainCustomTypeMapping()
        {
            try
            {
                Mapper.CreateMap<String, OGCProcessType>().ConvertUsing<StringToOGCProcessTypeConverter>();
                Mapper.CreateMap<String, PurposeOfOrder>().ConvertUsing<StringToPurposeOfOrderConverter>();
                Mapper.CreateMap<String, DocCommentType>().ConvertUsing<StringToDocCommentTypeConverter>();
                Mapper.CreateMap<String, HearingModeInd>().ConvertUsing<StringToHearingModeIndConverter>();
                Mapper.CreateMap<String, AddressAvailabilityType>().ConvertUsing<StringToAddressAvailabilityTypeConverter>();
                Mapper.CreateMap<String, AppointmentOrganisationType>().ConvertUsing<StringToAppointmentOrganisationTypeConverter>();
                Mapper.CreateMap<String, AddressFormatType>().ConvertUsing<StringToAddressFormatTypeConverter>();
                Mapper.CreateMap<String, AddressType>().ConvertUsing<StringToAddressTypeConverter>();
                Mapper.CreateMap<String, AdmiralityType>().ConvertUsing<StringToAdmiralityTypeConverter>();
                Mapper.CreateMap<String, AdmiraltyWritType>().ConvertUsing<StringToAdmiraltyWritTypeConverter>();
                Mapper.CreateMap<String, AffidavitAEICType>().ConvertUsing<StringToAffidavitAEICTypeConverter>();
                Mapper.CreateMap<String, AutoTestingMode>().ConvertUsing<StringToAutoTestingModeConverter>();
                Mapper.CreateMap<String, BackdateStatus>().ConvertUsing<StringToBackdateStatusConverter>();
                Mapper.CreateMap<String, CasePartyRepresentedBy>().ConvertUsing<StringToCasePartyRepresentedByConverter>();
                Mapper.CreateMap<String, CaseTrack>().ConvertUsing<StringToCaseTrackConverter>();
                Mapper.CreateMap<String, ChecklistStatus>().ConvertUsing<StringToChecklistStatusConverter>();
                Mapper.CreateMap<String, ChecklistCommentType>().ConvertUsing<StringToChecklistCommentTypeConverter>();
                Mapper.CreateMap<String, ChecklistCommentStatus>().ConvertUsing<StringToChecklistCommentStatusConverter>();
                Mapper.CreateMap<String, ChildOf>().ConvertUsing<StringToChildOfConverter>();
                Mapper.CreateMap<String, CivilCriminalSaleConductedBy>().ConvertUsing<StringToCivilCriminalSaleConductedByConverter>();
                Mapper.CreateMap<String, ConsolidatedTypeInd>().ConvertUsing<StringToConsolidatedTypeIndConverter>();
                Mapper.CreateMap<String, ContactType>().ConvertUsing<StringToContactTypeConverter>();
                Mapper.CreateMap<String, DayInTheWeek>().ConvertUsing<StringToDayInTheWeekConverter>();
                Mapper.CreateMap<String, OtherPartyType>().ConvertUsing<StringToOtherPartyTypeConverter>();
                Mapper.CreateMap<String, DivorceCaseNature>().ConvertUsing<StringToDivorceCaseNatureConverter>();
                Mapper.CreateMap<String, DocCasePartyUpdateType>().ConvertUsing<StringToDocCasePartyUpdateTypeConverter>();
                Mapper.CreateMap<String, DocumentFileType>().ConvertUsing<StringToDocumentFileTypeConverter>();
                Mapper.CreateMap<String, DocumentFilingType>().ConvertUsing<StringToDocumentFilingTypeConverter>();
                Mapper.CreateMap<String, DocumentProcessType>().ConvertUsing<StringToDocumentProcessTypeConverter>();
                Mapper.CreateMap<String, EMSType>().ConvertUsing<StringToEMSTypeConverter>();
                Mapper.CreateMap<String, EndorsementType>().ConvertUsing<StringToEndorsementTypeConverter>();
                Mapper.CreateMap<String, ExecutionOutcome>().ConvertUsing<StringToExecutionOutcomeConverter>();
                Mapper.CreateMap<String, FilingOrderFor>().ConvertUsing<StringToFilingOrderForConverter>();
                Mapper.CreateMap<String, FilingPartyInd>().ConvertUsing<StringToFilingPartyIndConverter>();
                Mapper.CreateMap<String, ICAInterfaceStatus>().ConvertUsing<StringToICAInterfaceStatusConverter>();
                Mapper.CreateMap<String, Int64>().ConvertUsing<StringToInt64Converter>();
                Mapper.CreateMap<String, Int64?>().ConvertUsing<StringToNullableInt64Converter>();
                Mapper.CreateMap<String, InterpreterLanguage>().ConvertUsing<StringToInterpreterLanguageConverter>();
                Mapper.CreateMap<String, InvolvementInd>().ConvertUsing<StringToInvolvementIndConverter>();
                Mapper.CreateMap<String, JurisdictionDomicileForParty>().ConvertUsing<StringToJurisdictionDomicileForPartyConverter>();
                Mapper.CreateMap<String, JurisdictionInSingapore>().ConvertUsing<StringToJurisdictionInSingaporeConverter>();
                Mapper.CreateMap<String, LACConcludedStatus>().ConvertUsing<StringToLACConcludedStatusConverter>();
                Mapper.CreateMap<String, LACDocStatus>().ConvertUsing<StringToLACDocStatusConverter>();
                Mapper.CreateMap<String, LAPInterfaceFileStatus>().ConvertUsing<StringToLAPInterfaceFileStatusConverter>();
                Mapper.CreateMap<String, LPALPRSectionOrProvision>().ConvertUsing<StringToLPALPRSectionOrProvisionConverter>();
                Mapper.CreateMap<String, LACStatus>().ConvertUsing<StringToLACStatusConverter>();
                Mapper.CreateMap<String, LACType>().ConvertUsing<StringToLACTypeConverter>();
                Mapper.CreateMap<String, LogicalOperator>().ConvertUsing<StringToLogicalOperatorConverter>();
                Mapper.CreateMap<String, MailboxMessageType>().ConvertUsing<StringToMailboxMessageTypeConverter>();
                Mapper.CreateMap<String, MailboxStatus>().ConvertUsing<StringToMailboxStatusConverter>();
                Mapper.CreateMap<String, NatureOfCDR>().ConvertUsing<StringToNatureOfCDRConverter>();
                Mapper.CreateMap<String, NatureOfDeputyShip>().ConvertUsing<StringToNatureOfDeputyShipConverter>();
                Mapper.CreateMap<String, OCRStatus>().ConvertUsing<StringToOCRStatusConverter>();
                Mapper.CreateMap<String, OnlineEnquiryReportType>().ConvertUsing<StringToOnlineEnquiryReportTypeConverter>();
                Mapper.CreateMap<String, OnlineEnquirySchedulerInfo>().ConvertUsing<StringToOnlineEnquirySchedulerInfoConverter>();
                Mapper.CreateMap<String, OrderMadeIn>().ConvertUsing<StringToOrderMadeInConverter>();
                Mapper.CreateMap<String, OrderType>().ConvertUsing<StringToOrderTypeConverter>();
                Mapper.CreateMap<String, ParentingPlan>().ConvertUsing<StringToParentingPlanConverter>();
                Mapper.CreateMap<String, PartyRepresentedBy>().ConvertUsing<StringToPartyRepresentedByConverter>();
                Mapper.CreateMap<String, PartyUpdateInd>().ConvertUsing<StringToPartyUpdateIndConverter>();
                Mapper.CreateMap<String, PayingInType>().ConvertUsing<StringToPayingInTypeConverter>();
                Mapper.CreateMap<String, PaymentChequeStatus>().ConvertUsing<StringToPaymentChequeStatusConverter>();
                Mapper.CreateMap<String, PaymentInReasonType>().ConvertUsing<StringToPaymentInReasonTypeConverter>();
                Mapper.CreateMap<String, PaymentVoucherStatus>().ConvertUsing<StringToPaymentVoucherStatusConverter>();
                Mapper.CreateMap<String, PaymentVoucherType>().ConvertUsing<StringToPaymentVoucherTypeConverter>();
                Mapper.CreateMap<String, PropertyType>().ConvertUsing<StringToPropertyTypeConverter>();
                Mapper.CreateMap<String, ReceiptStatus>().ConvertUsing<StringToReceiptStatusConverter>();
                Mapper.CreateMap<String, ReleaseType>().ConvertUsing<StringToReleaseTypeConverter>();
                Mapper.CreateMap<String, SaleType>().ConvertUsing<StringToSaleTypeConverter>();
                Mapper.CreateMap<String, ServiceStatus>().ConvertUsing<StringToServiceStatusConverter>();
                Mapper.CreateMap<String, SetDownPursuantTo>().ConvertUsing<StringToSetDownPursuantToConverter>();
                Mapper.CreateMap<String, StatementOrEndorsementInWrit>().ConvertUsing<StringToStatementOrEndorsementInWritConverter>();
                Mapper.CreateMap<String, SubmissionStage>().ConvertUsing<StringToSubmissionStageConverter>();
                Mapper.CreateMap<String, SystemInd>().ConvertUsing<StringToSystemIndConverter>();
                Mapper.CreateMap<String, TransferTypeInd>().ConvertUsing<StringToTransferTypeIndConverter>();
                Mapper.CreateMap<String, BailiffClaimStatus>().ConvertUsing<StringToBailiffClaimStatusConverter>();
                Mapper.CreateMap<String, TypeOfArrest>().ConvertUsing<StringToTypeOfArrestConverter>();
                Mapper.CreateMap<String, TypeOfJurisdiction>().ConvertUsing<StringToTypeOfJurisdictionConverter>();
                Mapper.CreateMap<String, VesselIdType>().ConvertUsing<StringToVesselIdTypeConverter>();
                Mapper.CreateMap<String, UnliquidatedClaimType>().ConvertUsing<StringToUnliquidatedClaimTypeConverter>();
                Mapper.CreateMap<String, WaiverInd>().ConvertUsing<StringToWaiverIndConverter>();
                Mapper.CreateMap<String, WaiverStatus>().ConvertUsing<StringToWaiverStatusConverter>();
                Mapper.CreateMap<String, WaiverType>().ConvertUsing<StringToWaiverTypeConverter>();
                Mapper.CreateMap<String, WindingType>().ConvertUsing<StringToWindingTypeConverter>();
                Mapper.CreateMap<String, WOEInfoClaimStatus>().ConvertUsing<StringToWOEInfoClaimStatusConverter>();
                Mapper.CreateMap<String, WOEInfoClaimType>().ConvertUsing<StringToWOEInfoClaimTypeConverter>();
                Mapper.CreateMap<String, WOEType>().ConvertUsing<StringToWOETypeConverter>();
                Mapper.CreateMap<String, YesNo>().ConvertUsing<StringToYesNoConverter>();
                Mapper.CreateMap<Decimal, Int64>().ConvertUsing<DecimalToInt64Converter>();
                Mapper.CreateMap<String, CriminalCounselTypes>().ConvertUsing<StringToCriminalCounselTypesConverter>();
                Mapper.CreateMap<String, CrimeCase>().ConvertUsing<StringToCrimeCaseConverter>();
                Mapper.CreateMap<String, AmendmentStatus>().ConvertUsing<StringToAmendmentStatusConverter>();
                Mapper.CreateMap<String, AmendmentPerformedAt>().ConvertUsing<StringToAmendmentPerformedAtConverter>();
                Mapper.CreateMap<String, AmendmentInSupport>().ConvertUsing<StringToAmendmentInSupportConverter>();
                Mapper.CreateMap<String, ModeOfAmendment>().ConvertUsing<StringToModeOfAmendmentConverter>();
                Mapper.CreateMap<String, RequestType>().ConvertUsing<StringToRequestTypeConverter>();
                Mapper.CreateMap<String, RefundType>().ConvertUsing<StringToRefundTypeConverter>();
                Mapper.CreateMap<String, RefundFeeType>().ConvertUsing<StringToRefundFeeTypeConverter>();
                Mapper.CreateMap<String, FeeRuleType>().ConvertUsing<StringToFeeRuleTypeConverter>();
                Mapper.CreateMap<String, RefundStatus>().ConvertUsing<StringToRefundStatusConverter>();
                Mapper.CreateMap<String, FileInspectionStatus>().ConvertUsing<StringToFileInspectionStatusConverter>();
                Mapper.CreateMap<String, FileInspectionDocStatus>().ConvertUsing<StringToFileInspectionDocStatusConverter>();
                Mapper.CreateMap<String, AttendanceMode>().ConvertUsing<StringToAttendanceModeConverter>();
                Mapper.CreateMap<String, SubpoenaPurpose>().ConvertUsing<StringToSubpoenaPurposeConverter>();
                Mapper.CreateMap<String, FiledUserType>().ConvertUsing<StringToFiledUserTypeConverter>();
                Mapper.CreateMap<String, LACRefStatus>().ConvertUsing<StringToLACRefStatusConverter>();
                Mapper.CreateMap<String, LFGroupCode>().ConvertUsing<StringToLFGroupCodeConverter>();
                Mapper.CreateMap<String, CriminalNatureOfSentence>().ConvertUsing<StringToCriminalNatureOfSentenceConverter>();
                Mapper.CreateMap<String, CriminalStatusOfSentence>().ConvertUsing<StringToCriminalStatusOfSentenceConverter>();
                Mapper.CreateMap<String, CustodyRemand>().ConvertUsing<StringToCustodyRemandConverter>();
                Mapper.CreateMap<String, CriminalPartyInType>().ConvertUsing<StringToCriminalPartyInTypesConverter>();
                Mapper.CreateMap<String, LegalExperienceType>().ConvertUsing<StringToLegalExperienceTypeConverter>();
                Mapper.CreateMap<String, DegreeType>().ConvertUsing<StringToDegreeTypeConverter>();
                Mapper.CreateMap<String, LawPracticeType>().ConvertUsing<StringToLawPracticeTypeConverter>();
                Mapper.CreateMap<String, AppealsAgainst>().ConvertUsing<StringToAppealsAgainstConverter>();
                Mapper.CreateMap<String, AASPCPaidStatus>().ConvertUsing<StringToAASPCPaidStatusConverter>();
                Mapper.CreateMap<String, AASPCVoteStatus>().ConvertUsing<StringToAASPCVoteStatusConverter>();
                Mapper.CreateMap<String, ChargeStatusType>().ConvertUsing<StringToChargeStatusTypeConverter>();
                Mapper.CreateMap<String, AddLess>().ConvertUsing<StringToAddLessConverter>();
                Mapper.CreateMap<String, OutOfOfficeStatus>().ConvertUsing<StringToOutOfOfficeStatusConverter>();
                Mapper.CreateMap<String, ClaimType>().ConvertUsing<StringToClaimTypeConverter>();
                Mapper.CreateMap<String, AdmLetterUsed>().ConvertUsing<StringToAdmLetterUsedConverter>();
                Mapper.CreateMap<String, AgreeOrNotAgree>().ConvertUsing<StringToAgreeOrNotAgreeConverter>();
                Mapper.CreateMap<String, SettingDownStatus>().ConvertUsing<StringToSettingDownStatusConverter>();
                Mapper.CreateMap<String, WorkItemDetailsIndType>().ConvertUsing<StringToWorkItemDetailsIndTypeConverter>();
                Mapper.CreateMap<String, WorkItemRecipientStatus>().ConvertUsing<StringToWorkItemRecipientStatusConverter>();
                Mapper.CreateMap<String, TaskListStatus>().ConvertUsing<StringToTaskListStatusConverter>();
                Mapper.CreateMap<String, SettlementOutcomeType>().ConvertUsing<StringToSettlementOutcomeTypeConverter>();
                Mapper.CreateMap<String, CriminalClaimStatus>().ConvertUsing<StringToCriminalClaimStatusConverter>();
                Mapper.CreateMap<String, ClaimForPNOrDef>().ConvertUsing<StringToClaimForPNOrDefConverter>();
                Mapper.CreateMap<String, PartyRepresentationType>().ConvertUsing<StringToPartyRepresentationTypeConverter>();
                Mapper.CreateMap<String, WOEEmpActOrderType>().ConvertUsing<StringToWOEEmpActOrderTypeConverter>();
                Mapper.CreateMap<String, OrderEnforcedTypes>().ConvertUsing<StringToOrderEnforcedTypesConverter>();
                Mapper.CreateMap<String, InterfaceCriminalStatus>().ConvertUsing<StringToInterfaceCriminalStatusConverter>();
                Mapper.CreateMap<String, HearingCategory>().ConvertUsing<StringToHearingCategoryConverter>();
                Mapper.CreateMap<String, AttachmentType>().ConvertUsing<StringToAttachmentTypeConverter>();
                Mapper.CreateMap<String, ControlType>().ConvertUsing<StringToControlTypeConverter>();
                Mapper.CreateMap<String, MCurrencyEntity>().ConvertUsing<StringToMCurrencyEntityConverter>();//TODO: Need to Remove
                Mapper.CreateMap<String, ApplicationLimitation>().ConvertUsing<StringToApplicationLimitationConverter>();
                Mapper.CreateMap<String, ApplicantType>().ConvertUsing<StringToApplicantTypeConverter>();
                Mapper.CreateMap<String, Origin>().ConvertUsing<StringToOriginConverter>();
                Mapper.CreateMap<String, ProbateInfoType>().ConvertUsing<StringToProbateInfoTypeConverter>();
                Mapper.CreateMap<String, MHRGTypeEntity>().ConvertUsing<StringToMHRGTypeEntityConverter>();
                Mapper.CreateMap<String, MBasisForTaxationEntity>().ConvertUsing<StringToMBasisForTaxationEntityConverter>();
                Mapper.CreateMap<String, BizMonStatus>().ConvertUsing<StringToBizMonStatusConverter>();
                Mapper.CreateMap<String, EHearingStatus>().ConvertUsing<StringToEHearingStatusConverter>();
                Mapper.CreateMap<String, CashBookReconcileStatus>().ConvertUsing<StringToCaseBookReconcileStatusConverter>();
                Mapper.CreateMap<String, CashBookItemType>().ConvertUsing<StringToCashBookItemTypeConverter>();
                Mapper.CreateMap<String, DocInitiatedLocation>().ConvertUsing<StringToDocInitiatedLocationConverter>();
                Mapper.CreateMap<String, LegalOrganizationType>().ConvertUsing<StringToLegalOrganizationTypeConverter>();
                Mapper.CreateMap<String, OGCQueueStatus>().ConvertUsing<StringToOGCQueueStatusConverter>();
                Mapper.CreateMap<String, TransferStateFundStatus>().ConvertUsing<StringToTransferStateFundStatusConverter>();
                Mapper.CreateMap<String, FilingFrom>().ConvertUsing<StringToFilingFromConverter>();
                Mapper.CreateMap<String, JudgmentFor>().ConvertUsing<StringToJudgmentForConverter>();
                Mapper.CreateMap<String, SchedulerProcessStatus>().ConvertUsing<StringToSchedulerProcessStatusConverter>();
                Mapper.CreateMap<String, PartyFlippingCategory>().ConvertUsing<StringToPartyFlippingConverter>();
                Mapper.CreateMap<String, RoleCode>().ConvertUsing<StringToRoleCodeConverter>();
                Mapper.CreateMap<String, CriminalReleaseType>().ConvertUsing<StringToCriminalReleaseTypeConverter>();
                Mapper.CreateMap<String, YesNoMandatory>().ConvertUsing<StringToMandatoryYesNoConverter>();
                Mapper.CreateMap<String, DivorceFilingFor>().ConvertUsing<StringToDivorceFilingForConverter>();
                Mapper.CreateMap<String, JudgeAssignStatus>().ConvertUsing<StringToJudgeAssignStatusConverter>();
                Mapper.CreateMap<String, ReqDecision>().ConvertUsing<StringToReqDecisionConverter>();
                Mapper.CreateMap<string, RefundOrWaiverType>().ConvertUsing<StringToRefundOrWaiverTypeConverter>();
                Mapper.CreateMap<string, RejectionFeeType>().ConvertUsing<StringToRejectionFeeTypeConverter>();
                Mapper.CreateMap<string, FilingbrokerQueueStatus>().ConvertUsing<StringToFilingbrokerQueueStatusConverter>();
                Mapper.CreateMap<string, SubCaseRequestInd>().ConvertUsing<StringToSubCaseRequestIndConverter>();
                Mapper.CreateMap<string, IsConfidential>().ConvertUsing<StringToIsConfidentialConverter>();
                Mapper.CreateMap<string, ExecutorStatus>().ConvertUsing<StringToExecutorStatusConverter>();
                Mapper.CreateMap<String, AutionType>().ConvertUsing<StringToAutionTypeConverter>();//BUG-ENFPROD-SC-2013100702
                Mapper.CreateMap<String, CPDRequirements>().ConvertUsing<StringToCPDRequirementsConverter>();
                Mapper.CreateMap<String, VoteInfoValue>().ConvertUsing<StringToVoteInfoValueConverter>();
                Mapper.CreateMap<String, PaymentMode>().ConvertUsing<StringToPaymentModeConverter>();
                Mapper.CreateMap<String, InterfaceStatus>().ConvertUsing<StringToInterfaceStatusConverter>();
                Mapper.CreateMap<String, VerStatus>().ConvertUsing<StringToVerStatusConverter>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at NHibernateToDomainCustomTypeMapping", ex);
                throw;
            }
        }

        #endregion Methods
    }
}