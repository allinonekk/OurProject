namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
{
    using System;

    using AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping;

    using log4net;

    /// <summary>
    /// Class implementing call to all the Map methods, mapping NHibernate entities to Domain objects.
    /// </summary>
    public class MapAllNHibernateToDomain
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MapAllNHibernateToDomain));

        /// <summary>
        /// BackEndSpecific mapping instance.
        /// </summary>
        BackEndSpecificMapping backEndSpecificMapping = null;

        /// <summary>
        /// Case mapping instance.
        /// </summary>
        CaseMapping caseMapping = null;

        /// <summary>
        /// CaseSpecific Mapping Instance.
        /// </summary>
        CaseSpecificMapping caseSpecificMapping = null;

        /// <summary>
        /// Common mapping instance.
        /// </summary>
        CommonMapping commonMapping = null;

        /// <summary>
        /// CustomType mapping instance.
        /// </summary>
        CustomTypeMapping customTypeMapping = null;

        /// <summary>
        /// Document mapping instance.
        /// </summary>
        DocumentMapping documentMapping = null;

        /// <summary>
        /// FrontEndSpecific mapping instance.
        /// </summary>
        EnforcementMappingToDTO enforcementMapping = null;
        HibernateMappingService hibernateMapping = null;

        /// <summary>
        /// LAP mapping instance.
        /// </summary>
        LAPMapping lAPMapping = null;

        /// <summary>
        /// LawFirm mapping instance.
        /// </summary>
        LawFirmMapping lawFirmMapping = null;

        /// <summary>
        /// Master mapping instance.
        /// </summary>
        MasterMapping masterMapping = null;

        /// <summary>
        /// SubCase mapping instance.
        /// </summary>
        SubCaseMapping subCaseMapping = null;

        /// <summary>
        /// SubCaseSpecific Mapping Instance.
        /// </summary>
        SubCaseSpecificMapping subCaseSpecificMapping = null;

        /// <summary>
        /// Subsequent Mapping Instance.
        /// </summary>
        SubsequentMapping subsequentMapping = null;

        /// <summary>
        /// AuditMapping Instance
        /// </summary>
        AuditMapping audtiMapping = null;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapAllNHibernateToDomain"/> class.
        /// </summary>
        /// <remarks>Initializes all the mapping.</remarks>
        public MapAllNHibernateToDomain()
        {
            backEndSpecificMapping = new BackEndSpecificMapping();
            caseMapping = new CaseMapping();
            caseSpecificMapping = new CaseSpecificMapping();
            commonMapping = new CommonMapping();
            customTypeMapping = new CustomTypeMapping();
            documentMapping = new DocumentMapping();
            enforcementMapping = new EnforcementMappingToDTO();
            lAPMapping = new LAPMapping();
            lawFirmMapping = new LawFirmMapping();
            masterMapping = new MasterMapping();
            subCaseMapping = new SubCaseMapping();
            subCaseSpecificMapping = new SubCaseSpecificMapping();
            subsequentMapping = new SubsequentMapping();
            hibernateMapping = new HibernateMappingService();
            audtiMapping = new AuditMapping();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Method which calls to all the Map methods, mapping Domain objects to NHibernate entities. 
        /// </summary>
        public void MapAll()
        {
            Logger.Debug("Initialised MapAll");
            try
            {
                //BackEndSpecific Mapping
                backEndSpecificMapping.MapInterfaceICAToInterfaceICAEntity();
                backEndSpecificMapping.MapJudicialUserToJudicialUserEntity();
                backEndSpecificMapping.MapReportConfigInfoToReportConfigInfoEntity();
                backEndSpecificMapping.MapReportConfigUserToReportConfigUserEntity();
                backEndSpecificMapping.MapRMCDRAutoFixTimeLineToRMCDRAutoFixTimeLineEntity();
                backEndSpecificMapping.MapIndexDocDetailToIndexDocDetailEntity();
                backEndSpecificMapping.MapIndexDocInfoToIndexDocInfoEntity();
                backEndSpecificMapping.MapDCADetailToDCADetailEntity();
                backEndSpecificMapping.MapRARASDetailToRARASDetailEntity();
                backEndSpecificMapping.MapBankruptcyDRSInfoToBankruptcyDRSInfoEntity();
                backEndSpecificMapping.MapInterfaceCriminalToInterfaceCriminalEntity();
                backEndSpecificMapping.MapWorkflowOnAcceptQueueToWorkflowOnAcceptQueueEntity();
                backEndSpecificMapping.MapWorkflowPostAcceptQueueToWorkflowPostAcceptQueueEntity();
                backEndSpecificMapping.MapOGCIncomingQueueToOGCIncomingQueueEntity();
                backEndSpecificMapping.MapRMUserPSToRMUserPSEntity();
                backEndSpecificMapping.MapRUserPATRUserPAEntity();
                backEndSpecificMapping.MapNumberOfJudgeAssignDetailHistoryToNumberOfJudgeAssignDetailHistoryEntity();
                backEndSpecificMapping.MapNumberOfJudgeAssignDetailToNumberOfJudgeAssignDetailEntity();
                backEndSpecificMapping.MapReportConfigTaskInfoToReportConfigTaskInfoEntity();
                backEndSpecificMapping.MapBizMonitoringInfoToBizMonitoringInfoEntity();
                backEndSpecificMapping.MapCaseStatusRuleInfoToCaseStatusRuleInfoEntity();
                backEndSpecificMapping.MapWorkflowOutgoingQueueToWorkflowOutgoingQueueEntity();
                backEndSpecificMapping.MapDutyJudgeAssignmentToDutyJudgeAssignmentEntity();
                backEndSpecificMapping.MapRPTDisposalKPIConfigToRPTDisposalKPIConfigEntity();
                backEndSpecificMapping.MapRPTNOCGroupNOCToRPTNOCGroupNOCEntity();
                backEndSpecificMapping.MapRPTNOCGroupToRPTNOCGroupEntity();


                // Case Mapping
                caseMapping.MapCaseInfoToCaseInfoEntity();
                caseMapping.MapCaseOriginatingCaseToCaseOriginatingCaseEntity();
                caseMapping.MapCasePartyAddressToCasePartyAddressEntity();
                caseMapping.MapCasePartyAICAddressToCasePartyAICAddressEntity();
                caseMapping.MapCasePartyAICAliasToCasePartyAICAliasEntity();
                caseMapping.MapCasePartyAICDetailToCasePartyAICDetailEntity();
                caseMapping.MapCasePartyAliasToCasePartyAliasEntity();
                caseMapping.MapCasePartyAuthorisedOfficerDetailToCasePartyAuthorisedOfficerDetailEntity();
                caseMapping.MapCasePartyToCasePartyEntity();
                caseMapping.MapCasePartyVesselDetailToCasePartyVesselDetailEntity();
                caseMapping.MapCaseSolicitorHistoryToCaseSolicitorHistoryEntity();
                caseMapping.MapCaseSolicitorToCaseSolicitorEntity();
                caseMapping.MapHearingAdminSupportToHearingAdminSupportEntity();
                caseMapping.MapHearingToHearingEntity();
                caseMapping.MapLawFirmCaseFileRefNumberToLawFirmCaseFileRefNumberEntity();
                caseMapping.MapRCaseLawFirmToRCaseLawFirmEntity();
                caseMapping.MapRCaseSubmissionToRCaseSubmissionEntity();
                caseMapping.MapCasePartyLACDetailsHistoryToCasePartyLACDetailHistoryEntity();
                caseMapping.MapCasePartyLACDetailToCasePartyLACDetailEntity();
                caseMapping.MapCasePartyBailorAddressToCasePartyBailorAddressEntity();
                caseMapping.MapCasePartyBailorInfoToCasePartyBailorInfoEntity();
                caseMapping.MapCasePartyCriminalInfoToCasePartyCriminalInfoEntity();
                caseMapping.MapCasePartyCitizenshipToCasePartyCitizenshipEntity();
                caseMapping.MapRCaseLinkedToRCaseLinkedEntity();
                caseMapping.MapRLawFirmSolicitorsToRLawFirmSolicitorsEntity();
                caseMapping.MapCaseIssueListToCaseIssueListEntity();
                caseMapping.MapRCaseTransferToRCaseTransferEntity();
                caseMapping.MapCasePartyStatusHistoryToCasePartyStatusHistoryEntity();
                caseMapping.MapRCaseConsolidateToRCaseConsolidateEntity();
                caseMapping.MapHearingCoramToHearingCoramEntity();
                caseMapping.MapInterimCasePartyStatusToInterimCasePartyStatusEntity();
                caseMapping.MapHearingOutcomeFlagToHearingOutcomeFlagEntity();
                caseMapping.MapTransferOrderOfCourtToTransferOrderOfCourtEntity();
                caseMapping.MapPartyCaseFileRefNumberToPartyCaseFileRefNumberEntity();
                caseMapping.MapCaseInfoNumberToCaseInfoNumberEntity();

                // CaseSpecific Mapping
                caseSpecificMapping.MapADMInfoToADMInfoEntity();
                caseSpecificMapping.MapBankruptcyInfoToBankruptcyInfoEntity();
                caseSpecificMapping.MapBankruptcyOtherDefDetailToBankruptcyOtherDefDetailEntity();
                caseSpecificMapping.MapBillOfSaleInfoToBillOfSaleInfoEntity();
                caseSpecificMapping.MapCWUCheckListInfoToCWUCheckListInfoEntity();
                caseSpecificMapping.MapCWUInfoToCWUInfoEntity();
                caseSpecificMapping.MapDCACAInfoToDCACAInfoEntity();
                caseSpecificMapping.MapOSInfoToOSInfoEntity();
                caseSpecificMapping.MapChargeInfoToChargeInfoEntity();
                caseSpecificMapping.MapCriminalInfoToCriminalInfoEntity();
                caseSpecificMapping.MapCriminalOtherOrderInfoToCriminalOtherOrderInfoEntity();
                caseSpecificMapping.MapDrugInfoToDrugInfoEntity();
                caseSpecificMapping.MapInvestigatingOfficerInfoToInvestigatingOfficerInfoEntity();
                caseSpecificMapping.MapOffenceInfoToOffenceInfoEntity();
                caseSpecificMapping.MapRCriminalLegislationInfoToRCriminalLegislationInfoEntity();
                caseSpecificMapping.MapSentenceInfoToSentenceInfoEntity();
                caseSpecificMapping.MapAASInfoToAASInfoEntity();
                caseSpecificMapping.MapPracticeOfLawInfoToPracticeOfLawInfoEntity();
                caseSpecificMapping.MapPracticeTrainingPeriodInfoToPracticeTrainingPeriodInfoEntity();
                caseSpecificMapping.MapWOEMOMSCTInfoToWOEMOMSCTInfoEntity();
                caseSpecificMapping.MapWOSInfoToWOSInfoEntity();
                caseSpecificMapping.MapOSJudicialManagerDetailsToOSJudicialManagerDetailsEntity();
                caseSpecificMapping.MapOSMADetailsToOSMADetailsEntity();
                caseSpecificMapping.MapPBBeneficiaryDetailsToPBBeneficiaryDetailsEntity();
                caseSpecificMapping.MapProbateInfoToProbateInfoEntity();
                caseSpecificMapping.MapPBCoAdminDetailsToPBCoAdminDetailEntity();
                caseSpecificMapping.MapPBExecutorDetailsToPBExecutorDetailEntity();
                caseSpecificMapping.MapPBWillCodicilToPBWillCodicilEntity();
                caseSpecificMapping.MapPBPrevGrantDetailsToPBPrevGrantDetailEntity();
                caseSpecificMapping.MapTaxationClaimToTaxationClaimEntity();
                caseSpecificMapping.MapTaxationInfoToTaxationInfoEntity();
                caseSpecificMapping.MapBOTDetailToBOTDetailsEntity();
                caseSpecificMapping.MapSentenceCriminalOrderInfoToSentenceCriminalOrderInfoEntity();
                caseSpecificMapping.MapDCACAOriginatingCasePartyInfoToDCACAOriginatingCasePartyInfoEntity();
                caseSpecificMapping.MapRASInfoToRASInfoEntity();
                caseSpecificMapping.MapBankruptcyDebtInfoToBankruptcyDebtInfoEntity();
                caseSpecificMapping.MapPBPADetailToPBPADetailsEntity();
                caseSpecificMapping.MapPBSupNExmToPBSupNExmEntity();
                caseSpecificMapping.MapPBAdminBondToPBAdminBondEntity();
                caseSpecificMapping.MapCaseRegisterHistoryToCaseRegisterHistoryEntity();
                caseSpecificMapping.MapCaseRegisterToCaseRegisterEntity();
                caseSpecificMapping.MapDashboardCaseMilestoneDetailToDashboardCaseMilestoneDetailEntity();
                caseSpecificMapping.MapDashboardCaseMilestoneDetailHistoryToDashboardCaseMilestoneDetailHistoryEntity();
                caseSpecificMapping.MapCaveatInfoToCaveatInfoEntity();
                caseSpecificMapping.MapCaveatAAInfoToCaveatInfoAAEntity();
                caseSpecificMapping.MapJMChecklistInfoToJMChecklistInfoEntity();
                caseSpecificMapping.MapJMOtherInfoToJMOtherInfoEntity();
                caseSpecificMapping.MapDirectionDetailsToDirectionDetailsEntity();

                // Common Mapping
                //commonMapping.MapAASCertificationToAASCertificationEntity();
                commonMapping.MapDocAppProcessByExAgencyToDocAppProcessByExAgencyEntity();
                commonMapping.MapWOECaseExecutionAddressToWOECaseExecutionAddressEntity();
                commonMapping.MapAffidavitDeponentDetailToAffidavitDeponentDetailEntity();
                commonMapping.MapAffidavitInfoToAffidavitInfoEntity();
                commonMapping.MapBTSRoutingQueueEntityToBTSRoutingQueue();
                commonMapping.MapCertSecurityOfCostsInfoToCertSecurityOfCostsInfoEntity();
                commonMapping.MapChecklistInstanceToChecklistInstanceEntity();
                commonMapping.MapChecklistSubmissionToChecklistSubmissionEntity();
                commonMapping.MapChildInfoToChildInfoEntity();
                commonMapping.MapDivorceInfoToDivorceInfoEntity();
                commonMapping.MapEmploymentInfoToEmploymentInfoEntity();
                commonMapping.MapFilingFeeDetailToFilingFeeDetailEntity();
                commonMapping.MapForeignLawPracticeRegAddressToForeignLawPracticeRegAddressEntity();
                commonMapping.MapForeignLawPracticeRegToForeignLawPracticeRegEntity();
                //commonMapping.MapForeignLawPracticeToForeignLawPracticeEntity();
                commonMapping.MapForeignLPSolicitorRegToForeignLPSolicitorRegEntity();
                commonMapping.MapGroundInfoToGroundInfoEntity();
                commonMapping.MapLegislationProvisionsToLegislationProvisionsEntity();
                commonMapping.MapLiquidatedClaimToLiquidatedClaimEntity();
                commonMapping.MapLiquidatorAddressToLiquidatorAddressEntity();
                commonMapping.MapLiquidatorAliasToLiquidatorAliasEntity();
                commonMapping.MapLiquidatorPICAddressToLiquidatorPICAddressEntity();
                commonMapping.MapLiquidatorPICAliasToLiquidatorPICAliasEntity();
                commonMapping.MapLiquidatorPICToLiquidatorPICEntity();
                commonMapping.MapLiquidatorToLiquidatorEntity();
                commonMapping.MapNatureOfApplicationToNatureOfApplicationEntity();
                commonMapping.MapNatureOfCaseToNatureOfCaseEntity();
                commonMapping.MapOriginatingCaseToOriginatingCaseEntity();
                commonMapping.MapOtherITMOToOtherITMOEntity();
                commonMapping.MapOtherReliefsClaimToOtherReliefsClaimEntity();
                commonMapping.MapPCAppDatesFromSALToPCAppDatesFromSALEntity();
                commonMapping.MapPCAppDetailsFromSALToPCAppDetailsFromSALEntity();
                commonMapping.MapPCConditionInfoToPCConditionInfoEntity();
                commonMapping.MapPrayersToPrayersEntity();
                //commonMapping.MapQualificationInfoToQualificationInfoEntity();
                commonMapping.MapRefCaveatCaseToRefCaveatCaseEntity();
                commonMapping.MapRefOrderDetailToRefOrderDetailEntity();
                commonMapping.MapRelatedProceedingToRelatedProceedingEntity();
                commonMapping.MapSolicitorToSolicitorEntity();
                commonMapping.MapSubmissionInfoToSubmissionInfoEntity();
                commonMapping.MapTravelPassInfoToTravelPassInfoEntity();
                commonMapping.MapUnliquidatedClaimToUnliquidatedClaimEntity();
                commonMapping.MapNotPaymenttoCourtDocDetailToNotPaymenttoCourtDocDetailEntity();
                commonMapping.MapDegreeInfoToDegreeInfoEntity();
                commonMapping.MapLegalExperienceInfoToLegalExperienceInfoEntity();
                commonMapping.MapForeignLPSolicitorRegDetailToForeignLPSolicitorRegDetailEntity();
                commonMapping.MapNatureOfAppealToNatureOfAppealEntity();
                commonMapping.MapWOEExecutionAddressToWOEExecutionAddressEntity();
                commonMapping.MapMinuteSheetFamilyRelatedInfoToMinuteSheetFamilyRelatedInfoEntity();
                commonMapping.MapMinuteSheetGroundInfoToMinuteSheetGroundInfoEntity();
                commonMapping.MapMinuteSheetInfoToMinuteSheetInfoEntity();
                commonMapping.MapMinuteSheetPartyRepInfoToMinuteSheetPartyRepInfoEntity();
                commonMapping.MapMinuteSheetPartySolicitorInfoToMinuteSheetPartySolicitorInfoEntity();
                commonMapping.MapDeceasedAliasToDeceasedAliasEntity();
                commonMapping.MapDeceasedIdentificationsToDeceasedIdentificationsEntity();
                commonMapping.MapDeceasedInfoToDeceasedInfoEntity();
                commonMapping.MapInfantInfoToInfantInfoEntity();
                commonMapping.MapMinuteSheetDocListToMinuteSheetDocListEntity();
                commonMapping.MapRefSubCaseToRefSubCaseEntity();
                commonMapping.MapOutgoingCorrespondenceInfoToOutgoingCorrespondenceInfoEntity();
                commonMapping.MapOutgoingCorrespondenceCourtFeeToOutgoingCorrespondenceCourtFeeEntity();
                commonMapping.MapOrdersMadeToOrdersMadeEntity();
                commonMapping.MapApppealTimeEstimationDetailToAppealTimeEstimationDetailEntity();
                commonMapping.MapNoticeToReferAffidavitToNoticeToReferAffidavitEntity();
                commonMapping.MapClaimAmountToClaimAmountEntity();
                commonMapping.MapPrintDocumentQueueToPrintDocumentQueueEntity();
                commonMapping.MapPrintDocumentQueueDetailToPrintDocumentQueueDetailEntity();
                commonMapping.MapCheckListCommentsToCheckListCommentEntity();
                commonMapping.MapRefOrderJOInfoToRefOrderJOInfoEntity();
                commonMapping.MapSystemParametersToSystemParametersEntity();
                commonMapping.MapInterfaceNBSReportToInterfaceNBSReportEntity();
                commonMapping.MapReqExaminationFeedetailToReqExaminationFeedetailEntity();
                commonMapping.MapForeignUserRegAddressDetailsToForeignUserRegAddressDetailsEntity();
                commonMapping.MapForeignUserPracticeInformationToForeignUserPracticeInformationEntity();
                commonMapping.MapRegistrationOfForeignLawyerToRegistrationOfForeignLawyerEntity();
                commonMapping.MapRFLValidityAndNotificationToRFLValidityAndNotificationEntity();
                commonMapping.MapSICCFeeLedgerToSICCFeeLedgerEntity();
                commonMapping.MapRequestForExemptionToRequestForExemptionEntity();
                commonMapping.MapFeeCollectionDetailToFeeCollectionDetailEntity();
                commonMapping.MapLawfirmRegistrationToLawfirmRegistrationEntity();
                commonMapping.MapDocLegalExperienceInfoToDocLegalExperienceInfoEntity();
                commonMapping.MapCaseLegalExperienceInfoToCaseLegalExperienceInfoEntity();
                commonMapping.MapCORSolicitorRegToCORSolicitorRegEntity();
                commonMapping.MapCORSolicitorRegDetailsToCORSolicitorRegDetailsEntity();

                commonMapping.MapDocCaseCounterClaimDetailsToDocCaseCounterClaimDetailsEntity();
                commonMapping.MapDocCaseCounterClaimToDocCaseCounterClaimEntity();
                commonMapping.MapCaseCounterClaimToCaseCounterClaimEntity();
                commonMapping.CaseCounterClaimDetailsToCaseCounterClaimDetailsEntity();

                // CustomType Mapping
                customTypeMapping.NHibernateToDomainCustomTypeMapping();

                // Document Mapping
                documentMapping.MapDocCasePartyAddressToDocCasePartyAddressEntity();
                documentMapping.MapDocCasePartyAICAddressToCasePartyAICAddressEntity();
                documentMapping.MapDocCasePartyAICAliasToDocCasePartyAICAliasEntity();
                documentMapping.MapDocCasePartyAICDetailToDocCasePartyAICDetailEntity();
                documentMapping.MapDocCasePartyAliasToDocCasePartyAliasEntity();
                documentMapping.MapDocCasePartyAuthorisedOfficerDetailToDocCasePartyAuthorisedOfficerDetailsEntity();
                documentMapping.MapDocCasePartyToDocCasePartyEntity();
                documentMapping.MapDocCasePartyVesselDetailToDocCasePartyVesselDetailsEntity();
                documentMapping.MapDocCaseSolicitorToCaseSolicitorEntity();
                documentMapping.MapDocOrderDetailToDocOrderDetailsEntity();
                documentMapping.MapDocumentInfoToDocumentInfoEntity();
                documentMapping.MapRDocCasePartyToRDocCasePartyEntity();
                documentMapping.MapRDocCaseToRDocCaseEntity();
                documentMapping.MapDocCasePartyLACDetailToDocCasePartyLACDetailEntity();
                documentMapping.MapDocRequestDetailToDocRequestDetailEntity();
                documentMapping.MapDocCasePartyBailorAddressToDocCasePartyBailorAddressEntity();
                documentMapping.MapDocCasePartyBailorInfoToDocCasePartyBailorInfoEntity();
                documentMapping.MapDocCasePartyCriminalInfoToDocCasePartyCriminalInfoEntity();
                documentMapping.MapDocCasePartyCitizenshipToDocCasePartyCitizenshipEntity();
                documentMapping.MapDocGCRDetailsToDocGCRDetailsEntity();
                documentMapping.MapCaseLatestDocumentsToCaseLatestDocumentsEntity();
                documentMapping.MapDocCommentsToDocCommentsEntity();
                documentMapping.MapDocumentInfoSPToDocumentInfoEntity();
                documentMapping.MapDocCaseTierTypeToDocCaseTierTypeEntity();
                documentMapping.MapLawFirmDocCaseFileRefNumberToLawFirmDocCaseFileRefNumberEntity();
                documentMapping.MapDocPartyCaseFileRefNumberToDocPartyCaseFileRefNumberEntity();
                documentMapping.MapTemp_ProcessingInfoToTemp_ProcessingInfoEntity();
                documentMapping.MapRDocCounterClaimFiledToRDocCounterClaimFiledEntity();
               
                // Enforcement Mapping
                enforcementMapping.MapEMSAccountToEMSAccountEntity();
                enforcementMapping.MapEMSAdmExecToEMSAdmExecEntity();
                enforcementMapping.MapEMSAdmPropertyToEMSAdmPropertyEntity();
                enforcementMapping.MapEMSAdmReleaseToEMSAdmReleaseEntity();
                enforcementMapping.MapEMSAppointmentToEMSAppointmentEntity();
                enforcementMapping.MapEMSApptDateTimeToEMSApptDateTimeEntity();
                enforcementMapping.MapEMSApptDebtorToEMSApptDebtorEntity();
                enforcementMapping.MapEMSCivCaseAbortToEMSCivCaseAbortEntity();
                enforcementMapping.MapEMSCrmCaseToEMSCrmCaseEntity();
                enforcementMapping.MapEMSCivCrmMissingToEMSCivCrmMissingEntity();
                enforcementMapping.MapEMSCivCrmReleaseToEMSCivCrmReleaseEntity();
                enforcementMapping.MapEMSCivCrmSeizureToEMSCivCrmSeizureEntity();
                enforcementMapping.MapEMSCivCrmSettlementToEMSCivCrmSettlementEntity();
                enforcementMapping.MapEMSDisburseClaimToEMSDisburseClaimEntity();
                enforcementMapping.MapEMSFileMovementToEMSFileMovementEntity();
                enforcementMapping.MapEMSPaymentToEMSPaymentEntity();
                enforcementMapping.MapEMSPaymentVoucherAdmToEMSPaymentVoucherAdmEntity();
                enforcementMapping.MapEMSPaymentVoucherChequeToEMSPaymentVoucherChequeEntity();
                enforcementMapping.MapEMSPaymentVoucherFinalToEMSPaymentVoucherFinalEntity();
                enforcementMapping.MapEMSPaymentVoucherToEMSPaymentVoucherEntity();
                enforcementMapping.MapEMSReceiptToEMSReceiptEntity();
                enforcementMapping.MapEMSRecTransToEMSRecTransEntity();
                enforcementMapping.MapEMSSaleAdvertToEMSSaleAdvertEntity();
                enforcementMapping.MapEMSSaleAgentToEMSSaleAgentEntity();
                enforcementMapping.MapEMSSaleAppraiserToEMSSaleAppraiserEntity();
                enforcementMapping.MapEMSSaleBuyerToEMSSaleBuyerEntity();
                enforcementMapping.MapEMSTeamMgmtToEMSTeamMgmtEntity();
                enforcementMapping.MapEMSTptClaimToEMSTptClaimEntity();
                enforcementMapping.MapLawFirmToLawFirmEntity();
                enforcementMapping.MapEMSSaleToEMSSaleEntity();
                enforcementMapping.MapEMSCrmCaseWLDetToEMSCrmCaseWLDetEntity();
                enforcementMapping.MapEMSCrmCaseExecAddrToEMSCrmCaseExecAddrEntity();
                enforcementMapping.MapEMSMiscClaimToEMSMiscClaimEntity();
                enforcementMapping.MapEMSPaymentVoucherFinalOtherToEMSPaymentVoucherFinalOtherEntity();
                enforcementMapping.MapEMSPaymentVoucherMiscToEMSPaymentVoucherMiscEntity();
                enforcementMapping.MapEMSAdmPropertyListToEMSAdmPropertyListEntity();
                enforcementMapping.MapEMSOutstandingPaymentToEMSOutstandingPaymentEntity();
                enforcementMapping.MapEMSExecLedgerToEMSExecLedgerEntity();
                enforcementMapping.MapEMSRecAuditToEMSRecAuditEntity();
                enforcementMapping.MapEMSRecChequeAuditToEMSRecChequeAuditEntity();
                enforcementMapping.MapEMSChequeToEMSChequeEntity();
                enforcementMapping.MapEMSPaymentChequeToEMSPaymentChequeEntity();
                enforcementMapping.MapEMSChequeHistoryToEMSChequeHistoryEntity();
                enforcementMapping.MapEMSCourtCommissionToEMSCourtCommissionEntity();
                enforcementMapping.MapEMSBailiffUnavailabilityToEMSBailiffUnavailabilityEntity();
                enforcementMapping.MapEMSRecapitulationToEMSRecapitulationEntity();
                enforcementMapping.MapEMSStateFundToEMSStateFundEntity();
                enforcementMapping.MapEMSAdmClaimToEMSAdmClaimEntity();
                //enforcementMapping.MapEMSAdmChargeToEMSAdmChargeEntity();
                enforcementMapping.MapEMSCashBookItemToEMSCashBookItemEntity();
                enforcementMapping.MapEMSCashBookReconcileToEMSCashBookReconcileEntity();
                enforcementMapping.MapTemp_EMSAppointmentToTemp_EMSAppointmentEntity();
                enforcementMapping.MapEMSADMSaleOthersToEMSADMSaleOthersEntity();
                enforcementMapping.MapEMSRecapitDetailsToEMSRecapitDetailsEntity();
                enforcementMapping.MapEMSRoundRobinAuctioneerToEMSRoundRobinAuctioneerEntity();
                enforcementMapping.MapEMSSaleAuctioneerToEMSSaleAuctioneerEntity();
                enforcementMapping.MapEMSAdmChargesToEMSAdmChargesEntity();
                enforcementMapping.MapEMSAttendanceFeeToEMSAttendanceFeeEntity();

                // LAP Mapping
                lAPMapping.MapLABPartyAddressHistoryToLABPartyAddressHistoryEntity();
                lAPMapping.MapLABPartyAddressToLABPartyAddressEntity();
                lAPMapping.MapLABPartyHistoryToLABPartyHistoryEntity();
                lAPMapping.MapLABPartySolicitorHistoryToLABPartySolicitorHistoryEntity();
                lAPMapping.MapLABPartySolicitorToLABPartySolicitorEntity();
                lAPMapping.MapLABPartyToLABPartyEntity();
                lAPMapping.MapLABSection17CertInfoToLABSection17CertInfoEntity();
                lAPMapping.MapLACCancellationInfoToLACCancellationInfoEntity();
                lAPMapping.MapLACDocumentDetailToLACDocumentDetailEntity();
                lAPMapping.MapLACDocumentDraftToLACDocumentDraftEntity();
                lAPMapping.MapLACDocumentRemarkToLACDocumentRemarkEntity();
                lAPMapping.MapLACInfoToLACInfoEntity();

                // Law Firm Mapping
                lawFirmMapping.MapLawFirmAddressToLawFirmAddressEntity();
                lawFirmMapping.MapLawFirmToLawFirmEntity();
                lawFirmMapping.MapSolicitorToSolicitorEntity();
                lawFirmMapping.MapSolicitorAddressToSolicitorAddressEntity();
                lawFirmMapping.MapInterfaceLawSocLawFirmToInterfaceLawSocLawFirmEntity();
                lawFirmMapping.MapInterfaceLawSocLawFirmAddressToInterfaceLawSocLawFirmAddressEntity();
                // Master Mapping
                masterMapping.MasterToMasterEntityMapping();

                // SubCase Mapping
                subCaseMapping.MapRSubCaseSubmissionToRSubCaseSubmissionEntity();
                subCaseMapping.MapSubCaseInfoToSubCaseInfoEntity();
                subCaseMapping.MapSubCasePartyToSubCasePartyEntity();
                subCaseMapping.MapRelationSubCaseInfoToRelationalSubCaseInfoEntity();
                subCaseMapping.MapSubCaseStatusHistoryToSubCaseStatusHistoryEntity();
                

                // SubCaseSpecific Mapping
                subCaseSpecificMapping.MapAccountantsReportInfoToAccountantsReportInfoEntity();
                subCaseSpecificMapping.MapADMWAInfoToADMWAInfoEntity();
                subCaseSpecificMapping.MapAreaOfLegalPracticetoAreaOfLegalPracticeEntity();
                subCaseSpecificMapping.MapLPOthLegalOrgAddrInfotoLPOthLegalOrgAddrInfoEntity();
                subCaseSpecificMapping.MapLPOthLegalOrgInfotoLPOthLegalOrgInfoEntity();
                subCaseSpecificMapping.MapPaymentInDocDetailToPaymentInDocDetailEntity();
                subCaseSpecificMapping.MapPaymentInDocFSDetailToPaymentInDocFSDetailEntity();
                subCaseSpecificMapping.MapPaymentOutDocDetailToPaymentOutDocDetailEntity();
                subCaseSpecificMapping.MapPaymentOutPayInDetailToPaymentOutPayInDetailEntity();
                subCaseSpecificMapping.MapPCInfoToPCInfoEntity();
                subCaseSpecificMapping.MapRARASInfoToRARASInfoEntity();
                subCaseSpecificMapping.MapServiceOfDocDocStatusHistoryToServiceOfDocDocStatusHistoryEntity();
                subCaseSpecificMapping.MapServiceOfDocDocumentToServiceOfDocDocumentEntity();
                subCaseSpecificMapping.MapServiceOfDocInfoDetailToServiceOfDocInfoDetailEntity();
                subCaseSpecificMapping.MapServiceOfDocInfoToServiceOfDocInfoEntity();
                subCaseSpecificMapping.MapSetDownInfoToSetDownInfoEntity();
                subCaseSpecificMapping.MapNOCInfoToNOCInfoEntity();
                subCaseSpecificMapping.MapPCInfoAccReportToPCInfoAccReportEntity();
                subCaseSpecificMapping.MapVoteInfoDeltaToVoteInfoDeltaEntity();
                subCaseSpecificMapping.MapVoteInfoToVoteInfoEntity();
                subCaseSpecificMapping.MapDashBoardSubCaseMilestoneDetailHistoryToDashBoardSubCaseMilestoneDetailHistoryEntity();
                subCaseSpecificMapping.MapDashBoardSubCaseMilestoneDetailToDashboardSubCaseMilestoneDetailEntity();

                // Subsequent Mapping
                subsequentMapping.MapADMBBDefInfoToADMBBDefInfoEntity();
                subsequentMapping.MapADMBBSecInfoToADMBBSecInfoEntity();
                subsequentMapping.MapADMRSVCBBInfoToADMRSVCBBInfoEntity();
                subsequentMapping.MapBillOfSaleSubInfoToBillOfSaleSubInfoEntity();
                subsequentMapping.MapCDRInfoToCDRInfoEntity();
                subsequentMapping.MapDocRequestDetailToDocRequestDetailEntity();
                subsequentMapping.MapFileInspectionDocDetailToFileInspectionDocDetailEntity();
                subsequentMapping.MapFileInspectionToFileInspectionEntity();
                subsequentMapping.MapPartyAmendmentDetailToPartyAmendmentDetailEntity();
                subsequentMapping.MapPartyAmendmentLeaveOfCourtToPartyAmendmentLeaveOfCourtEntity();
                subsequentMapping.MapPartyAmendmentToPartyAmendmentEntity();
                subsequentMapping.MapPaymentHRGDatesDocDetailToPaymentHRGDatesDocDetailEntity();
                subsequentMapping.MapRequestDocDetailToRequestDocDetailEntity();
                subsequentMapping.MapSubpoenaDocDetailToSubpoenaDocDetailEntity();
                subsequentMapping.MapSubpoenaInfoToSubpoenaInfoEntity();
                subsequentMapping.MapSubpoenaWitnessDetailToSubpoenaWitnessDetailEntity();
                subsequentMapping.MapVacHRGDatesReqInfoToVacHRGDatesReqInfoEntity();
                subsequentMapping.MapFilingFeeRequestDetailToFilingFeeRequestDetailEntity();
                subsequentMapping.MapDisWithDocPtyDetailToDisWithDocPtyDetailEntity();
                subsequentMapping.MapRequestHearingAdminSupportToRequestHearingAdminSupportEntity();
                subsequentMapping.MapDivorceSubInfoToDivorceSubInfoEntity();
                subsequentMapping.MapWOERequestToWOERequestEntity();
                subsequentMapping.MapWitnessInfoToWitnessInfoEntity();
                subsequentMapping.MapRAccusedStatementInfoToRAccusedStatementInfoEntity();
                subsequentMapping.MapWOEInfoToWOEInfoEntity();
                subsequentMapping.MapWOENCPEInfoToWOENCPEInfoEntity();
                subsequentMapping.MapWOENECPEInfoToWOENECPEInfoEntity();
                subsequentMapping.MapRequestNEGDDetailToRequestNEGDDetailEntity();
                subsequentMapping.MapRequestHearingFeeDetailToRequestHearingFeeDetailEntity();

                // Criminal Finance Mapping
                backEndSpecificMapping.MapCriminalClaimHonorariumInfoToCriminalClaimHonorariumInfoEntity();
                backEndSpecificMapping.MapCriminalClaimInfoToCriminalClaimInfoEntity();
                backEndSpecificMapping.MapCriminalClaimInterpreterFeeInfoToCriminalClaimInterpreterFeeInfoEntity();
                backEndSpecificMapping.MapCriminalClaimMiscellaneousInfoToCriminalClaimMiscellaneousInfoEntity();
                backEndSpecificMapping.MapCriminalClaimProfessionalFeeInfoToCriminalClaimProfessionalFeeInfoEntity();
                backEndSpecificMapping.MapCriminalClaimWitnessInfoToCriminalClaimWitnessInfoEntity();
                backEndSpecificMapping.MapWorkitemDetailsToWorkitemDetailsEntity();
                backEndSpecificMapping.MapWorkitemRecipientToWorkitemRecipientEntity();
                backEndSpecificMapping.MapTaskListToTaskListEntity();

                hibernateMapping.CreateMapping();

                audtiMapping.CreateMapping();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at NHibernateToDomain>> Mapping >> MapAll", ex);
                throw;
            }
        }

        #endregion Methods
    }
}