#region Header

/*****************************************************************************************************
* Description : This file handles call to all the Map methods, mapping Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			            Description
*-----------------------------------------------------------------------------------------------------
*   27/09/2010   		        Yan Nai                	 	Created
*   27/10/2010                  Swaroop                     Added logging and comments.
*****************************************************************************************************/
// <summary>
// File: MapAllDomainToNHibernate.cs
// Description: This file handles call to all the Map methods, mapping Domain objects to NHibernate entities.
// </summary>
// <copyright file= "MapAllDomainToNHibernate.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate
{
    using System;

    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping;

    using log4net;

    /// <summary>
    /// Class implementing call to all the Map methods, mapping Domain objects to NHibernate entities.
    /// </summary>
    public class MapAllDomainToNHibernate
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MapAllDomainToNHibernate));

        /// <summary>
        /// Appeal mapping instance.
        /// </summary>
        AppealMapping appealMapping = null;

        /// <summary>
        /// BackEndSpecific mapping instance.
        /// </summary>
        BackEndSpecificMapping backEndSpecificMapping = null;

        /// <summary>
        /// Bankruptcy mapping instance.
        /// </summary>
        BankruptcyMapping bankruptcyMapping = null;

        /// <summary>
        /// Case mapping instance.
        /// </summary>
        CaseMapping caseMapping = null;
        CaseSpecificMapping caseSpecificMapping = null;

        /// <summary>
        /// Common mapping instance.
        /// </summary>
        CommonMapping commonMapping = null;

        /// <summary>
        /// CWU mapping instance.
        /// </summary>
        CWUMapping cWUMapping = null;

        /// <summary>
        /// Divorce mapping instance.
        /// </summary>
        DivorceMapping divorceMapping = null;

        /// <summary>
        /// Document mapping instance.
        /// </summary>
        DocumentMapping documentMapping = null;
        DomainMappingService domainMapping = null;

        /// <summary>
        /// Enforcement mapping instance.
        /// </summary>
        EnforcementMappingToDomain enforcementMapping = null;

        /// <summary>
        /// External mapping instance.
        /// </summary>
        ExternalMapping externalMapping = null;
        LAPMapping lAPMapping = null;

        /// <summary>
        /// LawFirm Mapping Instance
        /// </summary>
        LawFirmMapping lawFirmMapping = null;

        /// <summary>
        /// Master mapping instance.
        /// </summary>
        MasterMapping masterMapping = null;

        /// <summary>
        /// PaymentInOut Mapping instance
        /// </summary>
        PaymentInOutMapping paymentInOutMapping = null;

        /// <summary>
        /// Service Of Doc Mapping instance
        /// </summary>
        ServiceOfDocMapping serviceofDocMapping = null;

        /// <summary>
        /// SubCase Mapping instance
        /// </summary>
        SubCaseMapping subCaseMapping = null;

        /// <summary>
        /// SubCaseSpecific Mapping Instance
        /// </summary>
        SubCaseSpecificMapping subCaseSpecificMapping = null;

        /// <summary>
        /// Subsequent Mapping Instance
        /// </summary>
        SubsequentMapping subsequentMapping = null;

        /// <summary>
        /// Audit Mapping Instance
        /// </summary>
        AuditMapping auditMapping = null;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapAllDomainToNHibernate"/> class.
        /// </summary>
        public MapAllDomainToNHibernate()
        {
            appealMapping = new AppealMapping();
            backEndSpecificMapping = new BackEndSpecificMapping();
            bankruptcyMapping = new BankruptcyMapping();
            caseMapping = new CaseMapping();
            commonMapping = new CommonMapping();
            cWUMapping = new CWUMapping();
            divorceMapping = new DivorceMapping();
            documentMapping = new DocumentMapping();
            externalMapping = new ExternalMapping();
            masterMapping = new MasterMapping();
            enforcementMapping = new EnforcementMappingToDomain();
            //Service Of Doc Mapping
            serviceofDocMapping = new ServiceOfDocMapping();
            subCaseMapping = new SubCaseMapping();
            paymentInOutMapping = new PaymentInOutMapping();
            caseSpecificMapping = new CaseSpecificMapping();
            subCaseSpecificMapping = new SubCaseSpecificMapping();
            subsequentMapping = new SubsequentMapping();
            lAPMapping = new LAPMapping();
            lawFirmMapping = new LawFirmMapping();
            domainMapping = new DomainMappingService();
            auditMapping = new AuditMapping();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Method which calls to all the Map methods, mapping Domain objects to NHibernate entities.
        /// </summary>
        /// <exception cref="System.Exception">Error in Mapping, Domain to NHibernate. -  + exp.Message</exception>
        public void MapAll()
        {
            Logger.Debug("MapAll Initialised");
            try
            {
                //Appeal Mapping
                appealMapping.MapDCACAInfoEntityToDCACAInfo();
                appealMapping.MapRARASInfoEntityToRARASInfo();

                // BackEndSpecific Mapping
                backEndSpecificMapping.MapReportConfigInfoEntityToReportConfigInfo();
                backEndSpecificMapping.MapReportConfigUserEntityToReportConfigUser();
                backEndSpecificMapping.MapIndexDocDetailEntityToIndexDocDetail();
                backEndSpecificMapping.MapIndexDocInfoEntityToIndexDocInfo();
                backEndSpecificMapping.MapDisciplinaryActionInfoEntityToDisciplinaryActionInfo();
                backEndSpecificMapping.MapContinuingLegalEducationInfoEntityToContinuingLegalEducationInfo();
                backEndSpecificMapping.MapTaskListEntityToTaskList();
                backEndSpecificMapping.MapDCADetailEntityToDCADetail();
                backEndSpecificMapping.MapRARASDetailEntityToRARASDetail();
                backEndSpecificMapping.MapBankruptcyDRSInfoEntityToBankruptcyDRSInfo();
                backEndSpecificMapping.MapWorkitemDetailsEntityToWorkitemDetails();
                backEndSpecificMapping.MapWorkitemRecipientEntityToWorkitemRecipient();
                backEndSpecificMapping.MapInterfaceCriminalEntityToInterfaceCriminal();
                backEndSpecificMapping.MapBizMonitoringInfoEntityToBizMonitoringInfo();
                backEndSpecificMapping.MapWorkflowOnAcceptQueueEntityToWorkflowOnAcceptQueue();
                backEndSpecificMapping.MapWorkflowPostAcceptQueueEntityToWorkflowPostAcceptQueue();
                backEndSpecificMapping.MapOGCIncomingQueueEntityToOGCIncomingQueue();
                backEndSpecificMapping.MapRMUserPSEntityToRMUserPS();
                backEndSpecificMapping.MapAssessmentDamageEntityToAssessmentDamage();
                backEndSpecificMapping.MapRUserPAEntityToRUserPA();
                backEndSpecificMapping.MapNumberOfJudgeAssignDetailEntityToNumberOfJudgeAssignDetail();
                backEndSpecificMapping.MapNumberOfJudgeAssignDetailHistoryEntityToNumberOfJudgeAssignDetailHistory();
                backEndSpecificMapping.MapReportConfigTaskInfoEntityToReportConfigTaskInfo();
                backEndSpecificMapping.MapArchiveNumberOfJudgeAssignDetailEntityToArchiveNumberOfJudgeAssignDetail();
                backEndSpecificMapping.MapArchiveNumberOfJudgeAssignDetailHistoryEntityToArchiveNumberOfJudgeAssignDetailHistory();
                backEndSpecificMapping.MapArchiveWorkitemDetailsEntityToArchiveWorkitemDetails();
                backEndSpecificMapping.MapArchiveWorkitemRecipientEntityToArchiveWorkitemRecipient();
                backEndSpecificMapping.MapArchiveTaskListEntityToArchiveTaskList();
                backEndSpecificMapping.MapCaseStatusRuleInfoEntityToCaseStatusRuleInfo();
                backEndSpecificMapping.MapOGCProcessingInfoEntityToOGCProcessingInfo();
                backEndSpecificMapping.MapWorkFlowOutgoingQueueEntityToWorkFlowOutgoingQueue();
                backEndSpecificMapping.MapDutyJudgeAssignmentEntityToDutyJudgeAssignment();
                backEndSpecificMapping.MapUndoSerialNumberEntityToUndoSerialNumber();
                backEndSpecificMapping.MapJudicialUserEntityToJudicialUser();

                backEndSpecificMapping.MapRPTNOCGroupNOCEntityToRPTNOCGroupNOC();
                backEndSpecificMapping.MapRPTDisposalKPIConfigEntityToRPTDisposalKPIConfig();
                backEndSpecificMapping.MapRPTNOCGroupEntityToRPTNOCGroup();


                //Bankrupcy Mapping
                bankruptcyMapping.MapBankruptcyInfoEntityToBankruptcyInfo();
                bankruptcyMapping.BankruptcyOtherDefDetailEntityToBankruptcyOtherDefDetail();
                //Case Mapping
                caseMapping.MapCaseInfoEntityToCaseInfo();
                caseMapping.MapCasePartyAddressEntityToCasePartyAddress();
                caseMapping.MapCasePartyAICAddressEntityToCasePartyAICAddress();
                caseMapping.MapCasePartyAICAliasEntityToCasePartyAICAlias();
                caseMapping.MapCasePartyAICDetailEntityToCasePartyAICDetail();
                caseMapping.MapCasePartyAliasEntityToCasePartyAlias();
                caseMapping.MapCasePartyAuthorisedOfficerDetailEntityToCasePartyAuthorisedOfficerDetail();
                caseMapping.MapCasePartyEntityToCaseParty();
                caseMapping.MapCasePartyVesselDetailEntityToCasePartyVesselDetail();
                caseMapping.MapCaseSolicitorEntityToCaseSolicitor();
                caseMapping.MapCaseSolicitorHistoryEntityToCaseSolicitorHistory();
                caseMapping.MapLawFirmCaseFileRefNumberEntityToLawFirmCaseFileRefNumber();
                caseMapping.MapRCaseLawFirmEntityToRCaseLawFirm();
                caseMapping.MapRCaseSubmissionEntityToRCaseSubmission();
                caseMapping.MapCaseOriginatingCaseEntityToCaseOriginatingCase();
                caseMapping.MapCasePartyLACDetailEntityToCasePartyLACDetailEntity();
                caseMapping.MapCasePartyLACDetailHistoryEntityToCasePartyLACDetailHistoryEntity();
                caseMapping.MapCasePartyBailorAddressEntityToCasePartyBailorAddress();
                caseMapping.MapCasePartyBailorInfoEntityToCasePartyBailorInfo();
                caseMapping.MapCasePartyCriminalInfoEntityToCasePartyCriminalInfo();
                caseMapping.MapCasePartyCitizenshipEntityToCasePartyCitizenship();
                caseMapping.MapRCaseLinkedEntityToRCaseLinked();
                caseMapping.MapHearingAdminSupportEntityToHearingAdminSupport();
                caseMapping.MapHearingEntityToHearing();
                caseMapping.MapRLawFirmSolicitorsEntityToRLawFirmSolicitors();
                caseMapping.MapCaseIssueListEntityToCaseIssueList();
                caseMapping.MapRCaseTransferEntityToRCaseTransfer();
                caseMapping.MapCaseStatusHistoryEntityToCaseStatusHistory();
                caseMapping.MapCasePartyStatusHistoryEntityToCasePartyStatusHistory();
                caseMapping.MapRLawFirmSolicitorHistoryEntityToRLawFirmSolicitorHistory();
                caseMapping.MapCaseInfoNumberEntityToCaseInfoNumber();
                //SubCase Mapping
                caseMapping.MapSubCaseInfoEntityToSubCaseInfo();
                caseMapping.MapRCaseConsolidateEntityToRCaseConsolidate();
                caseMapping.MapRCaseTransferHistoryEntityToRCaseTransferHistory();
                caseMapping.MapTransferOrderOfCourtEntityToTransferOrderOfCourt();
                caseMapping.MapPartyCaseFileRefNumberEntityToPartyCaseFileRefNumber();

                //Common Mapping
                commonMapping.MapWOECaseExecutionAddressEntityToWOECaseExecutionAddress();
                commonMapping.MapBTSRoutingQueueEntityToBTSRoutingQueue();
                commonMapping.MapFilingFeeDetailEntityToFilingFeeDetail();
                commonMapping.MapLiquidatorEntityToLiquidator();
                commonMapping.MapOtherReliefsClaimEntityToOtherReliefsClaim();
                commonMapping.MapUnliquidatedClaimEntityToUnliquidatedClaim();
                commonMapping.MapLegislationProvisionEntityToLegislationProvision();
                commonMapping.MapLiquidatorAddressEntityToLiquidatorAddress();
                commonMapping.MapLiquidatorAliasEntityToLiquidatorAlias();
                commonMapping.MapLiquidatorPICAddressEntityToLiquidatorPICAddress();
                commonMapping.MapLiquidatorPICAliasEntityToLiquidatorPICAlias();
                commonMapping.MapLiquidatorPICEntityToLiquidatorPIC();
                commonMapping.MapNatureOfApplicationEntityToNatureOfApplication();
                commonMapping.MapNatureOfCaseEntityToNatureOfCase();
                //commonMapping.MapNoOfSupportingDocEntityToNoOfSupportingDoc();
                commonMapping.MapOriginatingCaseEntityToOriginatingCase();
                commonMapping.MapOtherITMOEntityToOtherITMO();
                commonMapping.MapRefOrderDetailEntityToRefOrderDetail();
                commonMapping.MapLiquidatedClaimEntityToLiquidatedClaim();
                commonMapping.MapDivorceInfoEntityToDivorceInfo();
                commonMapping.MapAffidavitDeponentDetailEntityToAffidavitDetail();
                commonMapping.MapAffidavitInfoEntityToAffidavitInfo();
                commonMapping.MapChecklistInstanceEntityToChecklistInstance();
                commonMapping.MapChecklistSubmissionEntityToChecklistSubmission();
                commonMapping.MapDivorceInfoEntityToDivorceInfo();
                commonMapping.MapChildInfoEntityToChildInfo();
                commonMapping.MapPrayerEntityToPrayer();
                commonMapping.MapGroundInfoEntityToGroundInfo();
                commonMapping.MapRelatedProceedingEntityToRelatedProceeding();
                commonMapping.MapBillOfSaleSubInfoEntityToBillOfSaleSubInfo();
                commonMapping.MapSubmissionInfoEntityToSubmissionInfo();
                commonMapping.MapNotPaymentToCourtDocDetailEntityToNotPaymentToCourtDocDetail();
                commonMapping.MapCertSecurityOfCostsInfoEntityToCertSecurityOfCostsInfo();
                commonMapping.MapEmploymentInfoEntityToEmploymentInfo();
                commonMapping.MapPCConditionInfoEntityToPCConditionInfo();
                //commonMapping.MapQualificationInfoEntityToQualificationInfo();
                commonMapping.MapTravelPassInfoEntityToTravelPassInfo();
                commonMapping.MapDegreeInfoEntityEntityToDegreeInfo();
                commonMapping.MapLegalExperienceInfoEntityToLegalExperienceInfo();
                commonMapping.MapForeignLPSolicitorRegDetailEntityToForeignLPSolicitorRegDetail();
                commonMapping.MapNatureOfAppealEntityToNatureOfAppeal();
                commonMapping.MapWOEExecutionAddressEntityToWOEExecutionAddress();
                commonMapping.MapMinuteSheetFamilyRelatedInfoEntityToMinuteSheetFamilyRelatedInfo();
                commonMapping.MapMinuteSheetGroundInfoEntityToMinuteSheetGroundInfo();
                commonMapping.MapMinuteSheetInfoEntityToMinuteSheetInfo();
                commonMapping.MapMinuteSheetPartyRepInfoEntityToMinuteSheetPartyRepInfo();
                commonMapping.MapMinuteSheetPartySolicitorInfoEntityToMinuteSheetPartySolicitorInfo();
                commonMapping.MapDeceasedAliasEntityToDeceasedAlias();
                commonMapping.MapDeceasedIdentificationsEntityToDeceasedIdentification();
                commonMapping.MapDeceasedInfoEntityToDeceasedInfo();
                commonMapping.MapInfantInfoEntityToInfantInfo();
                commonMapping.MapMinuteSheetDocListEntityToMinuteSheetDocList();
                commonMapping.MapRefSubCaseEntityToRefSubCase();
                commonMapping.MapOrdersMadeEntityToOrdersMade();
                commonMapping.MapRefCaveatCaseEntityToRefCaveatCase();
                commonMapping.MapDocAppProcessByExAgencyEntityToDocAppProcessByExAgency();
                commonMapping.MapApppealTimeEstimationDetailEntityToAppealTimeEstimationDetail();
                commonMapping.MapNoticeToReferAffidavitEntityToNoticeToReferAffidavit();
                commonMapping.MapPrintDocumentQueueEntityToPrintDocumentQueue();
                commonMapping.MapPrintDocumentQueueDetailEntityToPrintDocumentQueueDetail();
                commonMapping.MapClaimAmountEntityToClaimAmount();
                commonMapping.MapRespondentCaseDetailInfoEntityToRespondentCaseDetail();
                commonMapping.MapCheckListCommentEntityToCheckListComment();
                commonMapping.MapRefOrderJOInfoEntityToRefOrderJOInfo();
                commonMapping.MapForeignLPSolicitorRegEntityToForeignLPSolicitorReg();
                commonMapping.MapInterfaceNBSReportEntityToInterfaceNBSReport();
                commonMapping.MapReqExaminationFeedetailEntityToReqExaminationFeedetail();
                commonMapping.MapForeignUserRegAddressDetailsEntityToForeignUserRegAddressDetails();
                commonMapping.MapForeignUserPracticeInformationEntityToForeignUserPracticeInformation();
                commonMapping.MapRegistrationOfForeignLawyerEntityToRegistrationOfForeignLawyer();
                commonMapping.MapRFLValidityAndNotificationEntityToRFLValidityAndNotification();
                commonMapping.MapSICCFeeLedgerEntityToSICCFeeLedger();
                commonMapping.MapSystemParametersEntityToSystemParameters();
                commonMapping.MapPCAppDatesFromSALEntityToPCAppDatesFromSAL();
                commonMapping.MapRequestForExemptionEntityToRequestForExemption();
                commonMapping.MapFeeCollectionDetailEntityToFeeCollectionDetail();
                commonMapping.MapOutgoingCorrespondenceInfoEntityToOutgoingCorrespondenceInfo();
                commonMapping.MapOutgoingCorrespondenceCourtFeeEntityToOutgoingCorrespondenceCourtFee();
                commonMapping.MapLawFirmRegistrationEntityToLawFirmRegistration();
                commonMapping.MapDocLegalExperienceInfoEntityToDocLegalExperienceInfo();
                commonMapping.MapCaseLegalExperienceInfoEntityToCaseLegalExperienceInfo();
                commonMapping.MapCORSolicitorRegEntityToCORSolicitorReg();
                commonMapping.MapCORSolicitorRegDetailsEntityToCORSolicitorRegDetails();

                commonMapping.MapDocCaseCounterClaimDetailsEntityToDocCaseCounterClaimDetails();
                commonMapping.MapDocCaseCounterClaimEntityToDocCaseCounterClaim();
                commonMapping.MapCaseCounterClaimEntityToCaseCounterClaim();
                commonMapping.MapCaseCounterClaimDetailsEntityToCaseCounterClaimDetails();

                //CWU Mapping
                cWUMapping.MapCWUInfoEntityToCWUInfo();

                ////Divorce Mapping
                //divorceMapping.MapChildInfoEntityToChildInfo();
                //divorceMapping.MapDivorceInfoEntityToDivorceInfo();
                //divorceMapping.MapRelatedProceedingEntityToRelatedProceeding();

                //Document Mapping
                documentMapping.MapDocCasePartyAddressEntityToDocCasePartyAddress();
                documentMapping.MapDocCasePartyAICAddressToCasePartyAICAddressEntity();
                documentMapping.MapDocCasePartyAICAliasEntityToDocCasePartyAICAlias();
                documentMapping.MapDocCasePartyAICDetailEntityToDocCasePartyAICDetail();
                documentMapping.MapDocCasePartyAliasEntityToDocCasePartyAlias();
                documentMapping.MapDocCasePartyOfficerDetailEntityToDocCasePartyOfficerDetail();
                documentMapping.MapDocCasePartyToDocCasePartyEntity();
                documentMapping.MapDocCasePartyVesselDetailEntityToDocCasePartyVesselDetail();
                documentMapping.MapDocCaseSolicitorToCaseSolicitorEntity();
                documentMapping.MapDocumentInfoEntityToDocumentInfo();
                documentMapping.MapRDocCasePartyEntityToRDocCaseParty();
                documentMapping.MapRDocCaseEntityToRDocCase();
                documentMapping.MapDocCasePartyLACDetailEntityToDocCasePartyLACDetail();
                documentMapping.MapDocCasePartyBailorAddressEntityToDocCasePartyBailorAddress();
                documentMapping.MapDocCasePartyBailorInfoEntityToDocCasePartyBailorInfo();
                documentMapping.MapDocCasePartyCriminalInfoEntityToDocCasePartyCriminalInfo();
                documentMapping.MapDocCasePartyCitizenshipEntityToDocCasePartyCitizenship();
                documentMapping.MapDocOrderDetailEntityToDocOrderDetail();
                documentMapping.MapDocGCRDetailsEntityToDocGCRDetails();
                documentMapping.MapDocumentBatesListEntityToDocumentBatesList();
                documentMapping.MapDocCommentsEntityToDocComments();
                documentMapping.MapDocRequestDetailEntityToDocRequestDetail();
                documentMapping.MapDocumentInfoEntityToDocumentInfoSP();
                documentMapping.MapDocCaseTierTypeEntityToDocCaseTierType();
                documentMapping.MapLawFirmDocCaseFileRefNumberEntityToLawFirmDocCaseFileRefNumber();
                documentMapping.MapDocPartyCaseFileRefNumberEntityToDocPartyCaseFileRefNumber();
                documentMapping.MapTemp_ProcessingInfoEntityToTemp_ProcessingInfo();
                documentMapping.MapRDocCounterClaimFiledEntityToRDocCounterClaimFiled();

                //External Mapping
                externalMapping.MapInterfaceICAEntityToInterfaceICA();

                //Master Mapping
                masterMapping.MainDomainToNHibernate();
                masterMapping.MapMAlertEventEntityToMAlertEvent();
                masterMapping.MapMAlertTypeEntityToMAlertType();
                masterMapping.MapMChecklistDocumentEntityToMChecklistDocument();
                masterMapping.MapMCourtTypeEntityToMCourtType();
                masterMapping.MapMFilterGroupEntityToFilterGroup();
                masterMapping.MapMForumTypeEntityToMForumType();
                masterMapping.MapMHRGOutComeReasonEntityToMHRGOutComeReason();
                masterMapping.MapMPartyAmendmentConfigEntityToMPartyAmendmentConfig();
                masterMapping.MapMEMSAdvertInEntityToMEMSAdvertIn();
                masterMapping.MapMEMSAdvertiserEntityToMEMSAdvertiser();
                masterMapping.MapMEMSAppraiserEntityToMEMSAppraiser();
                masterMapping.MapMEMSApptOutcomeEntityToMEMSApptOutcome();
                masterMapping.MapMEMSApptReasonEntityToMEMSApptReason();
                masterMapping.MapMEMSApptTypeEntityToMEMSApptType();
                masterMapping.MapMEMSAuctioneerEntityToMEMSAuctioneer();
                masterMapping.MapMEMSFileMoveDescEntityToMEMSFileMoveDesc();
                masterMapping.MapMEMSRecBankEntityToMEMSRecBank();
                masterMapping.MapMEMSRecTransModeEntityToMEMSRecTransMode();
                masterMapping.MapMEMSRecTransTypeEntityToMEMSRecTransType();
                masterMapping.MapMEMSSalesAgentEntityToMEMSSalesAgent();
                masterMapping.MapMScheduleJobLegalInfoEntityToMScheduleJobLegalInfo();
                masterMapping.MapMScheduleJobLegalDetailEntityToMScheduleJobLegalDetail();
                masterMapping.MapRMHrgSlotNOCEntityToRMHrgSlotNOC();
                masterMapping.MapRMHrgSlotLegisEntityToRMHrgSlotLegis();
                masterMapping.MapRMDocControlExclusionEntityToRMDocControlExclusion();
                masterMapping.MapMHarassPlaceEntityToMHarassPlace();

                //Service Of Doc Mapping.
                serviceofDocMapping.MapServiceOfDocInfoEntityToServiceOfDocInfo();
                serviceofDocMapping.MapServiceOfDocDocStatusHistoryEntityToServiceOfDocDocStatusHistory();
                serviceofDocMapping.MapServiceOfDocDocumentEntityToServiceOfDocDocument();
                serviceofDocMapping.MapServiceOfDocInfoDetailEntityToServiceOfDocInfoDetail();

                //Enforcement
                enforcementMapping.MapEMSAccountEntityToEMSAccount();
                enforcementMapping.MapEMSAdmExecEntityToEMSAdmExec();
                enforcementMapping.MapEMSAdmPropertyEntityToEMSAdmProperty();
                enforcementMapping.MapEMSAdmReleaseEntityToEMSAdmRelease();
                enforcementMapping.MapEMSAppointmentEntityToEMSAppointment();
                enforcementMapping.MapEMSApptDateTimeEntityToEMSApptDateTime();
                enforcementMapping.MapEMSApptDebtorEntityToEMSApptDebtor();
                enforcementMapping.MapEMSCivCaseAbortEntityToEMSCivCaseAbort();
                enforcementMapping.MapEMSCrmCaseEntityToEMSCrmCase();
                enforcementMapping.MapEMSCivCrmMissingEntityToEMSCivCrmMissing();
                enforcementMapping.MapEMSCivCrmReleaseEntityToEMSCivCrmRelease();
                enforcementMapping.MapEMSCivCrmSeizureEntityToEMSCivCrmSeizure();
                enforcementMapping.MapEMSCivCrmSettlementEntityToEMSCivCrmSettlement();
                enforcementMapping.MapEMSDisburseClaimEntityToEMSDisburseClaim();
                enforcementMapping.MapEMSFileMovementEntityToEMSFileMovement();
                enforcementMapping.MapEMSPaymentEntityToEMSPayment();
                enforcementMapping.MapEMSPaymentVoucherAdmEntityToEMSPaymentVoucherAdm();
                enforcementMapping.MapEMSPaymentVoucherChequeEntityToEMSPaymentVoucherCheque();
                enforcementMapping.MapEMSPaymentVoucherEntityToEMSPaymentVoucher();
                enforcementMapping.MapEMSPaymentVoucherFinalEntityToEMSPaymentVoucherFinal();
                enforcementMapping.MapEMSReceiptEntityToEMSReceipt();
                enforcementMapping.MapEMSRecTransEntityToEMSRecTrans();
                enforcementMapping.MapEMSSaleAdvertEntityToEMSSaleAdvert();
                enforcementMapping.MapEMSSaleAgentEntityToEMSSaleAgent();
                enforcementMapping.MapEMSSaleAppraiserEntityToEMSSaleAppraiser();
                enforcementMapping.MapEMSSaleBuyerEntityToEMSSaleBuyer();
                enforcementMapping.MapEMSTeamMgmtEntityToEMSTeamMgmt();
                enforcementMapping.MapEMSTptClaimEntityToEMSTptClaim();
                enforcementMapping.MapLawFirmEntityToLawFirm();
                enforcementMapping.MapEMSSaleEntityToEMSSale();
                enforcementMapping.MapEMSCrmCaseWLDetEntityToEMSCrmCaseWLDet();
                enforcementMapping.MapEMSCrmCaseExecAddrEntityToEMSCrmCaseExecAddr();
                enforcementMapping.MapEMSMiscClaimEntityToEMSMiscClaim();
                enforcementMapping.MapEMSPaymentVoucherFinalOtherEntityToEMSPaymentVoucherFinalOther();
                enforcementMapping.MapEMSPaymentVoucherMiscEntityToEMSPaymentVoucherMisc();
                enforcementMapping.MapEMSAdmPropertyListEntityToEMSAdmPropertyList();
                enforcementMapping.MapEMSOutstandingPaymentEntityToEMSOutstandingPayment();
                enforcementMapping.MapEMSExecLedgerEntityToEMSExecLedger();
                enforcementMapping.MapEMSRecAuditEntityToEMSRecAudit();
                enforcementMapping.MapEMSRecChequeAuditEntityToEMSRecChequeAudit();
                enforcementMapping.MapEMSChequeEntityToEMSCheque();
                enforcementMapping.MapEMSPaymentChequeEntityToEMSPaymentCheque();
                enforcementMapping.MapEMSChequeHistoryEntityToEMSChequeHistory();
                enforcementMapping.MapEMSCourtCommissionEntityToEMSCourtCommission();
                enforcementMapping.MapEMSBailiffUnavailabilityEntityToEMSBailiffUnavailability();
                enforcementMapping.MapEMSRecapitulationEntityToEMSRecapitulation();
                enforcementMapping.MapEMSStateFundEntityToEMSStateFund();
                enforcementMapping.MapEMSAdmClaimEntityToEMSAdmClaim();
                //enforcementMapping.MapEMSAdmChargeEntityToEMSAdmCharge();
                enforcementMapping.MapEMSCashBookItemEntityToEMSCashBookItem();
                enforcementMapping.MapEMSCashBookReconcileEntityToEMSCashBookReconcile();
                enforcementMapping.MapTemp_EMSAppointmentEntityToTemp_EMSAppointment();
                enforcementMapping.MapEMSADMSaleOthersEntityToEMSADMSaleOthers();
                enforcementMapping.MapEMSRecapitDetailsEntityToEMSRecapitDetails();
                enforcementMapping.MapEMSRoundRobinAuctioneerEntityToEMSRoundRobinAuctioneer();
                enforcementMapping.MapEMSSaleAuctioneerEntityToEMSSaleAuctioneer();
                enforcementMapping.MapEMSAdmChargesEntityToEMSAdmCharges();
                enforcementMapping.MapEMSAttendanceFeeEntityToEMSAttendanceFee();

                //Subcase Mapping
                subCaseMapping.MapRSubCaseSubmissionEntityToRSubCaseSubmission();
                subCaseMapping.MapSubCaseInfoEntityToSubCaseInfo();
                subCaseMapping.MapSubCasePartyEntityToSubCaseParty();
                subCaseMapping.MapRelationalSubCaseInfoEntityToRelationalSubCaseInfo();
                subCaseMapping.MapSubCaseStatusHistoryEntityToSubCaseStatusHistory();

                //PaymentMapping
                paymentInOutMapping.MapPaymentInDocDetailEntityToPaymentInDocDetail();
                paymentInOutMapping.MapPaymentInDocFSDetailEntityToPaymentInDocFSDetail();
                paymentInOutMapping.MapPaymentOutDocDetailEntityToPaymentOutDocDetail();
                paymentInOutMapping.MapPOPIDetailEntityToPOPIDetail();

                //CaseSpecific Mapping
                caseSpecificMapping.BankruptcyOtherDefDetailEntityToBankruptcyOtherDefDetail();
                caseSpecificMapping.MapAdmInfoEntityToAdmInfo();
                caseSpecificMapping.MapBankruptcyInfoEntityToBankruptcyInfo();
                caseSpecificMapping.MapBillOfSaleInfoEntityToBillOfSaleInfo();
                caseSpecificMapping.MapCWUInfoEntityToCWUInfo();
                caseSpecificMapping.MapRefCaveatCaseEntityToRefCaveatCase();
                caseSpecificMapping.MapOSInfoEntityToOSInfo();
                caseSpecificMapping.MapChargeInfoEntityToChargeInfo();
                caseSpecificMapping.MapCriminalInfoEntityToCriminalInfo();
                caseSpecificMapping.MapCriminalOtherOrderInfoEntityToCriminalOtherOrderInfo();
                caseSpecificMapping.MapDrugInfoEntityToDrugInfo();
                caseSpecificMapping.MapInvestigatingOfficerInfoEntityToInvestigatingOfficerInfo();
                caseSpecificMapping.MapOffenceInfoEntityToOffenceInfo();
                caseSpecificMapping.MapRCriminalLegislationInfoEntityToRCriminalLegislationInfo();
                caseSpecificMapping.MapSentenceInfoEntityToSentenceInfo();
                caseSpecificMapping.MapAASInfoEntityToAASInfo();
                caseSpecificMapping.MapPracticeOfLawInfoEntityToPracticeOfLawInfo();
                caseSpecificMapping.MapPracticeTrainingPeriodInfoEntityToPracticeTrainingPeriodInfo();
                caseSpecificMapping.MapAASObjectionEntityToAASObjection();
                caseSpecificMapping.MapWOEMOMSCTInfoEntityToWOEMOMSCTInfo();
                caseSpecificMapping.MapWOSInfoEntityToWOSInfo();
                caseSpecificMapping.MapOSJudicialManagerDetailsEntityToOSJudicialManagerDetails();
                caseSpecificMapping.MapOSMADetailsEntityToOSMADetails();
                caseSpecificMapping.MapPBBeneficiaryDetailsEntityToPBBeneficiaryDetails();
                caseSpecificMapping.MapProbateInfoEntityToProbateInfo();
                caseSpecificMapping.MapPBCoAdminDetailsEntityToPBCoAdminDetail();
                caseSpecificMapping.MapPBExecutorDetailEntityToPBExecutorDetails();
                caseSpecificMapping.MapPBPrevGrantDetailEntityToPBPrevGrantDetails();
                caseSpecificMapping.MapPBWillCodicilEntityToPBWillCodicil();
                caseSpecificMapping.MapTaxationClaimEntityToTaxationClaim();
                caseSpecificMapping.MapBOTDetailEntityToBOTDetails();
                caseSpecificMapping.MapTaxationInfoEntityToTaxationInfo();
                caseSpecificMapping.MapCaveatAAInfoEntityToCaveatAAInfo();
                caseSpecificMapping.MapSentenceCriminalOrderInfoEntityToSentenceCriminalOrderInfo();
                caseSpecificMapping.MapCWUCheckListInfoEntityToCWUChecklistInfo();
                caseSpecificMapping.MapDCACAOriginatingCasePartyInfoEntityToDCACAOriginatingCasePartyInfo();
                caseSpecificMapping.MapRASInfoEntitytoRASInfo();
                caseSpecificMapping.MapBankruptcyDebtInfoEntityToBankruptcyDebtInfo();
                caseSpecificMapping.MapPBPADetailEntityToPBPADetails();
                caseSpecificMapping.MapPBSupNExmEntityToPBSupNExm();
                caseSpecificMapping.MapPBAdminBondEntityToPBAdminBond();
                caseSpecificMapping.MapCaseRegisterEntityToCaseRegister();
                caseSpecificMapping.MapCaseRegisterHistoryEntityToCaseRegisterHistory();
                caseSpecificMapping.MapDashboardCaseMilestoneDetailEntityToDashboardCaseMilestoneDetail();
                caseSpecificMapping.MapDashboardCaseMilestoneDetailHistoryEntityToDashboardCaseMilestoneDetailHistory();
                caseSpecificMapping.MapCaveatInfoEntityToCaveatInfo();
                caseSpecificMapping.MapJMChecklistInfoEntityToJMChecklistInfo();
                caseSpecificMapping.MapJMOtherInfoEntityToJMOtherInfo();
                caseSpecificMapping.MapDirectionDetailsEntityToDirectionDetails();

                //SubCaseSpecific Mapping
                subCaseSpecificMapping.MapSetDownInfoEntityToSetDownInfo();
                subCaseSpecificMapping.MapServiceOfDocInfoEntityToServiceOfDocInfo();
                subCaseSpecificMapping.MapServiceOfDocDocStatusHistoryEntityToServiceOfDocDocStatusHistory();
                subCaseSpecificMapping.MapServiceOfDocDocumentEntityToServiceOfDocDocument();
                subCaseSpecificMapping.MapServiceOfDocInfoDetailEntityToServiceOfDocInfoDetail();
                subCaseSpecificMapping.MapAccountantsReportInfoEntityToAccountantsReportInfo();
                subCaseSpecificMapping.MapAreaOfLegalPracticeEntityToAreaOfLegalPractice();
                subCaseSpecificMapping.MapLPOthLegalOrgAddrInfoEntityToLPOthLegalOrgAddrInfo();
                subCaseSpecificMapping.MapLPOthLegalOrgInfoEntityToLPOthLegalOrgInfo();
                subCaseSpecificMapping.MapPCInfoEntityToPCInfo();
                subCaseSpecificMapping.MapADMWAInfoEntityToADMWAInfo();
                subCaseSpecificMapping.MapNOCInfoEntityToNOCInfo();
                subCaseSpecificMapping.MapPCInfoAccReportEntityToPCInfoAccReport();
                subCaseSpecificMapping.MapVoteInfoDeltaEntityToVoteInfoDelta();
                subCaseSpecificMapping.MapVoteInfoEntityToVoteInfo();
                subCaseSpecificMapping.MapDashBoardSubCaseMilestoneDetailEntityToDashboardSubCaseMilestoneDetail();
                subCaseSpecificMapping.MapDashBoardSubCaseMilestoneDetailHistoryEntityToDashBoardSubCaseMilestoneDetailHistory();
                //Subsequent Mapping

                subsequentMapping.MapDocRequestDetailEntityToDocRequestDetail();
                subsequentMapping.MapFileInspectionDocDetailToFileInspectionDocDetailEntity();
                subsequentMapping.MapFileInspectionToFileInspectionEntity();
                subsequentMapping.MapPartyAmendmentDetailEntityToPartyAmendmentDetail();
                subsequentMapping.MapPartyAmendmentEntityToPartyAmendment();
                subsequentMapping.MapPartyAmendmentLeaveOfCourtEntityToPartyAmendmentLeaveOfCourt();
                subsequentMapping.MapRequestDocDetailToRequestDocDetailEntity();
                subsequentMapping.MapSubpoenaDocDetailEntityToSubpoenaDocDetail();
                subsequentMapping.MapSubpoenaInfoEntityToSubpoenaInfo();
                subsequentMapping.MapSubpoenaWitnessDetailEntityToSubpoenaWitnessDetail();
                subsequentMapping.MapCDRInfoEntityToCDRInfoEntity();
                subsequentMapping.MapVacHRGDatesReqInfoEntityToVacHRGDatesReqInfo();
                subsequentMapping.MapFilingFeeRequestDetailEntityToFilingFeeRequestDetail();
                subsequentMapping.MapBillOfSaleSubInfoEntityToBillOfSaleSubInfo();
                subsequentMapping.MapRequestHearingAdminSupportEntityToRequestHearingAdminSupport();
                subsequentMapping.MapWOERequestEntityToWOERequest();
                subsequentMapping.MapDivorceSubInfoEntityToDivorceSubInfo();
                subsequentMapping.MapRequestHearingFeeDetailEntityToRequestHearingFeeDetail();
                subsequentMapping.MapWitnessInfoEntityToWitnessInfo();
                subsequentMapping.MapRAccusedStatementInfoEntityToRAccusedStatementInfo();
                subsequentMapping.MapWOEInfoEntityToWOEInfo();
                subsequentMapping.MapWOENCPEInfoEntityToWOENCPEInfo();
                subsequentMapping.MapWOENECPEInfoEntityToWOENECPEInfo();
                subsequentMapping.MapADMRSVCBBInfoEntityToADMRSVCBBInfo();
                subsequentMapping.MapRequestNEGDDetailEntityToRequestNEGDDetail();
                subsequentMapping.MapPaymentHRGDatesDocDetailEntityToPaymentHRGDatesDocDetail();
                

                //LAP Mapping

                lAPMapping.MapLABPartyAddressEntityToLABPartyAddress();
                lAPMapping.MapLABPartyAddressHistoryEntityToLABPartyAddressHistory();
                lAPMapping.MapLABPartyEntityToLABParty();
                lAPMapping.MapLABPartyHistoryEntityToLABPartyHistory();
                lAPMapping.MapLABPartySolicitorEntityToLABPartySolicitor();
                lAPMapping.MapLABPartySolicitorHistoryEntityToLABPartySolicitorHistory();
                lAPMapping.MapLABSection17CertInfoEntityToLABSection17CertInfo();
                lAPMapping.MapLACCancellationInfoEntityToLACCancellationInfo();
                lAPMapping.MapLACDocumentDetailEntityToLACDocumentDetail();
                lAPMapping.MapLACDocumentDraftEntityToLACDocumentDraft();
                lAPMapping.MapLACDocumentRemarkEntityToLACDocumentRemark();
                lAPMapping.MapLACInfoEntityToLACInfo();

                //Criminal Finance Mapping
                backEndSpecificMapping.MapCriminalClaimHonorariumInfoEntityToCriminalClaimHonorariumInfo();
                backEndSpecificMapping.MapCriminalClaimInfoEntityToCriminalClaimInfo();
                backEndSpecificMapping.MapCriminalClaimInterpreterFeeInfoEntityToCriminalClaimInterpreterFeeInfo();
                backEndSpecificMapping.MapCriminalClaimMiscellaneousInfoEntityToCriminalClaimMiscellaneousInfo();
                backEndSpecificMapping.MapCriminalClaimProfessionalFeeInfoEntityToCriminalClaimProfessionalFeeInfo();
                backEndSpecificMapping.MapCriminalClaimWitnessInfoEntityToCriminalClaimWitnessInfo();

                //Lawfirm Mapping
                lawFirmMapping.MapSolicitorEntityToSolicitor();
                lawFirmMapping.MapSolicitorAddressEntityToSolicitorAddress();
                lawFirmMapping.MapLawFirmEntityToLawFirm();
                lawFirmMapping.MapLawFirmAddressEntityToLawFirmAddress();
                domainMapping.CreateMapping();

                auditMapping.CreateMapping();
            }
            catch (Exception exp)
            {
                throw new Exception("Error in Mapping, Domain to NHibernate. - " + exp.Message, exp);
            }
        }

        #endregion Methods
    }
}