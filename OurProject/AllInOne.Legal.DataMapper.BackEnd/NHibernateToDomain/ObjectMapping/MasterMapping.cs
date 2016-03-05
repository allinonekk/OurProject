#region Header

/*****************************************************************************************************
* Description : This file handles mapping for Master from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   23/09/2010   		        Nithin                  Created
*   15/01/2011                  Swaroop                 Added logging and comments.
*****************************************************************************************************/
// <summary>
// File: MasterMapping.cs
// Description: This file handles mapping for Master from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "MasterMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.MRelationship;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Master from NHibernate entities to Domain objects.
    /// </summary>
    internal class MasterMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MasterMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method which maps the master entities to master domain objects.
        /// </summary>
        internal void MasterToMasterEntityMapping()
        {
            try
            {
                Mapper.CreateMap<RMHRGTypePaperMinuteSheetType, RMHRGTypePaperMinuteSheetTypeEntity>();
                Mapper.CreateMap<MPaperMinuteSheetType,MPaperMinuteSheetTypeEntity>();
                Mapper.CreateMap<MSensitiveFilingACL, MSensitiveFilingACLEntity>();
                Mapper.CreateMap<RMSubCaseTypeHRGTypeMSType, RMSubCaseTypeHRGTypeMSTypeEntity>();
                Mapper.CreateMap<RMCaseTypeHRGTypeJOL, RMCaseTypeHRGTypeJOLEntity>();
                Mapper.CreateMap<MHRGPredefinedDate, MHRGPredefinedDateEntity>();
                Mapper.CreateMap<RMDocFilterGroup, RMDocFilterGroupEntity>();
                Mapper.CreateMap<MSummonsGrounds, MSummonsGroundsEntity>();
                Mapper.CreateMap<MSummonsPrayers, MSummonsPrayersEntity>();
                Mapper.CreateMap<MVSAConfigDetail, MVSAConfigDetailEntity>();
                Mapper.CreateMap<MVSAConfigGround, MVSAConfigGroundEntity>();
                Mapper.CreateMap<MVSAConfigPrayer, MVSAConfigPrayerEntity>();
                Mapper.CreateMap<MVSAConfigPrayer, MVSAConfigPrayerEntity>();
                Mapper.CreateMap<MFilingFeeChargingMechanism, MFilingFeeChargingMechanismEntity>();
                Mapper.CreateMap<MFilingFeeLegislationAct, MFilingFeeLegislationActEntity>();
                Mapper.CreateMap<MEMSADMExecLocation, MEMSADMExecLocationEntity>();
                Mapper.CreateMap<MPrinter, MPrinterEntity>();
                Mapper.CreateMap<MChargeOutcome, MChargeOutcomeEntity>();
                Mapper.CreateMap<MMassCallHrgDate, MMassCallHrgDateEntity>();
                Mapper.CreateMap<MSummonsParam, MSummonsParamEntity>();
                Mapper.CreateMap<MIDType, MIDTypeEntity>();
                Mapper.CreateMap<MEMSOldSCTCasePrefix, MEMSOldSCTCasePrefixEntity>();
                Mapper.CreateMap<MHRGOutComeFlag, MHRGOutComeFlagEntity>();
                Mapper.CreateMap<RMHRGTypeHRGOutComeHRGOutComeFlag, RMHRGTypeHRGOutComeHRGOutComeFlagEntity>();
                Mapper.CreateMap<RMHearingTypeCourtType, RMHearingTypeCourtTypeEntity>();
                Mapper.CreateMap<RMForumCoramDSG, RMForumCoramDSGEntity>();
                Mapper.CreateMap<MMinuteSheetType, MMinuteSheetTypeEntity>();
                Mapper.CreateMap<RMCaseTypeHRGTypeMSType, RMCaseTypeHRGTypeMSTypeEntity>();
                Mapper.CreateMap<RMCaseTypeForumHRGTypeMSType, RMCaseTypeForumHRGTypeMSTypeEntity>();
                Mapper.CreateMap<MDocCategory, MDocCategoryEntity>();
                Mapper.CreateMap<MCoram, MCoramEntity>();
                Mapper.CreateMap<RMCaseTypeForum, RMCaseTypeForumEntity>();
                Mapper.CreateMap<MLimitations, MLimitationsEntity>();
                Mapper.CreateMap<MFormTemplateLocation, MFormTemplateLocationEntity>();
                Mapper.CreateMap<MAASDisciplinaryResultType, MAASDisciplinaryResultTypeEntity>();
                Mapper.CreateMap<MAASDisciplinaryType, MAASDisciplinaryTypeEntity>();
                Mapper.CreateMap<RMSectionAccessCtrl, RMSectionAccessCtrlEntity>();
                Mapper.CreateMap<MHoliday, MHolidayEntity>();
                Mapper.CreateMap<SerialNumber, SerialNumberEntity>();
                Mapper.CreateMap<MApptOrganisation, MApptOrganisationEntity>();
                Mapper.CreateMap<MCaseIssue, MCaseIssueEntity>();
                //Mapper.CreateMap<MAASBLECertification, MAASBLECertificationEntity>();
                Mapper.CreateMap<MAASLawDegree, MAASLawDegreeEntity>();
                Mapper.CreateMap<MAASOrganisationType, MAASOrganisationTypeEntity>();
                Mapper.CreateMap<MAASQualification, MAASQualificationEntity>();
                //Mapper.CreateMap<MAccess, MAccessEntity>();
                //Mapper.CreateMap<MAccomodationType, MAccomodationTypeEntity>();
                Mapper.CreateMap<MActingInCapacity, MActingInCapacityEntity>();
                Mapper.CreateMap<MActingInCapacityGroup, MActingInCapacityGroupEntity>();
                //Mapper.CreateMap<MAdpChecklistGroup, MAdpChecklistGroupEntity>();
                //Mapper.CreateMap<MAdpChecklistItem, MAdpChecklistItemEntity>();
                Mapper.CreateMap<MAdpPrayer, MAdpPrayerEntity>();
                Mapper.CreateMap<MAlertEvent, MAlertEventEntity>();
                Mapper.CreateMap<MAlertType, MAlertTypeEntity>();
                Mapper.CreateMap<MApplicantCapacity, MApplicantCapacityEntity>();
                Mapper.CreateMap<MBankruptcyBasis, MBankruptcyBasisEntity>();
                Mapper.CreateMap<MBankruptcyType, MBankruptcyTypeEntity>();
                Mapper.CreateMap<MBasisForTaxation, MBasisForTaxationEntity>();
                Mapper.CreateMap<MBasisOfTaxationType, MBasisOfTaxationTypeEntity>();
                Mapper.CreateMap<MBillNature, MBillNatureEntity>();
                Mapper.CreateMap<MBillType, MBillTypeEntity>();
                //Mapper.CreateMap<MBodyPart, MBodyPartEntity>();
                //Mapper.CreateMap<MCalendarType, MCalendarTypeEntity>();
                Mapper.CreateMap<MCaseSecurity, MCaseSecurityEntity>();
                Mapper.CreateMap<MCaseStatus, MCaseStatusEntity>();
                Mapper.CreateMap<MCaseType, MCaseTypeEntity>();
                Mapper.CreateMap<MCaseTypeGroup, MCaseTypeGroupEntity>();
                Mapper.CreateMap<MChecklistDocument, MChecklistDocumentEntity>();
                Mapper.CreateMap<MChecklist, MChecklistEntity>();
                Mapper.CreateMap<MClaimType, MClaimTypeEntity>();
                Mapper.CreateMap<MCountry, MCountryEntity>();
                Mapper.CreateMap<MCourtType, MCourtTypeEntity>();
                Mapper.CreateMap<MCurrency, MCurrencyEntity>();
                Mapper.CreateMap<MDamage, MDamageEntity>();
                Mapper.CreateMap<MDeedType, MDeedTypeEntity>();
                Mapper.CreateMap<MDesignation, MDesignationEntity>();
                Mapper.CreateMap<MDialect, MDialectEntity>();
                Mapper.CreateMap<MDocCategory, MDocCategoryEntity>();
                Mapper.CreateMap<MDocCode, MDocCodeEntity>();
                Mapper.CreateMap<MCourtVacation, MCourtVacationEntity>();
                //Mapper.CreateMap<MDocControl, MDocControlEntity>();
                Mapper.CreateMap<MDocLegislation, MDocLegislationEntity>();
                Mapper.CreateMap<MDocNature, MDocNatureEntity>();
                Mapper.CreateMap<MDocSecurity, MDocSecurityEntity>();
                Mapper.CreateMap<MDocStatus, MDocStatusEntity>();
                Mapper.CreateMap<MEMSAdvertIn, MEMSAdvertInEntity>();
                Mapper.CreateMap<MEMSAdvertiser, MEMSAdvertiserEntity>();
                Mapper.CreateMap<MEMSAppraiser, MEMSAppraiserEntity>();
                Mapper.CreateMap<MEMSApptOutcome, MEMSApptOutcomeEntity>();
                Mapper.CreateMap<MEMSApptReason, MEMSApptReasonEntity>();
                Mapper.CreateMap<MEMSApptType, MEMSApptTypeEntity>();
                Mapper.CreateMap<MEMSAuctioneer, MEMSAuctioneerEntity>();
                Mapper.CreateMap<MEMSFileMoveDesc, MEMSFileMoveDescEntity>();
                Mapper.CreateMap<MEMSNatureOfPayment, MEMSNatureOfPaymentEntity>();
                Mapper.CreateMap<MEMSCourtComm, MEMSCourtCommEntity>();
                Mapper.CreateMap<MEMSDisburseRate, MEMSDisburseRateEntity>();
                Mapper.CreateMap<MEMSAttendanceFee, MEMSAttendanceFeeEntity>();
                Mapper.CreateMap<MEMSParam, MEMSParamEntity>();
                Mapper.CreateMap<MEMSRecBank, MEMSRecBankEntity>();
                Mapper.CreateMap<MEMSRecTransMode, MEMSRecTransModeEntity>();
                Mapper.CreateMap<MEMSSecurityGuard, MEMSSecurityGuardEntity>();
                Mapper.CreateMap<MEMSRecTransType, MEMSRecTransTypeEntity>();
                Mapper.CreateMap<MEMSLedger, MEMSLedgerEntity>();
                Mapper.CreateMap<MEMSSalesAgent, MEMSSalesAgentEntity>();
                Mapper.CreateMap<MEMSWritAppt, MEMSWritApptEntity>();
                Mapper.CreateMap<MEntityType, MEntityTypeEntity>();
                Mapper.CreateMap<MExternalAgency, MExternalAgencyEntity>();
                Mapper.CreateMap<MExternalAgencyAddress, MExternalAgencyAddressEntity>();
                Mapper.CreateMap<MFilingFee, MFilingFeeEntity>().ForMember(dest => dest.ROCReference, opts => opts.MapFrom(src => src.ROCReferences));
                Mapper.CreateMap<MFilingFeeType, MFilingFeeTypeEntity>();
                Mapper.CreateMap<MFormSignature, MFormSignatureEntity>();
                Mapper.CreateMap<MFilterGroup, MFilterGroupEntity>();
                //Mapper.CreateMap<MFormTemplateLocation, MFormTemplateLocationEntity>();
                Mapper.CreateMap<MForumType, MForumTypeEntity>();
                Mapper.CreateMap<MFunctions, MFunctionsEntity>();
                Mapper.CreateMap<MGender, MGenderEntity>();
                Mapper.CreateMap<MHRGBeforeType, MHRGBeforeTypeEntity>();
                Mapper.CreateMap<MHRGOutCome, MHRGOutComeEntity>();
                Mapper.CreateMap<MHRGOutComeReason, MHRGOutComeReasonEntity>();
                Mapper.CreateMap<MHRGRoom, MHRGRoomEntity>();
                Mapper.CreateMap<MHRGRoomType, MHRGRoomTypeEntity>();
                Mapper.CreateMap<MHRGSlot, MHRGSlotEntity>();
                Mapper.CreateMap<MHRGTimeLine, MHRGTimeLineEntity>();
                Mapper.CreateMap<MHRGType, MHRGTypeEntity>();
                Mapper.CreateMap<MIconItem, MIconItemEntity>();
                Mapper.CreateMap<MJudGDCatchWord, MJudGDCatchWordEntity>();
                Mapper.CreateMap<MLegalPractice, MLegalPracticeEntity>();
                Mapper.CreateMap<MLegislationAct, MLegislationActEntity>();
                Mapper.CreateMap<MLocation, MLocationEntity>();
                Mapper.CreateMap<MMaritalStatus, MMaritalStatusEntity>();
                Mapper.CreateMap<MMessageType, MMessageTypeEntity>();
                Mapper.CreateMap<MNatureOfDeputyShip, MNatureofDeputyshipEntity>();
                Mapper.CreateMap<MNAAAlertEventRecipient, MNAAAlertEventRecipientEntity>();
                Mapper.CreateMap<MNAAAlertEventsTemplate, MNAAAlertEventsTemplateEntity>();
                Mapper.CreateMap<MNAACategory, MNAACategoryEntity>();
                Mapper.CreateMap<MNAAPlaceHolder, MNAAPlaceHolderEntity>();
                Mapper.CreateMap<MNAASubCategory, MNAASubCategoryEntity>();
                Mapper.CreateMap<MNationality, MNationalityEntity>();
                Mapper.CreateMap<MNatureOfInjury, MNatureOfInjuryEntity>();
                Mapper.CreateMap<MNatureOfProceeding, MNatureOfProceedingEntity>();
                Mapper.CreateMap<MNatureOfWork, MNatureOfWorkEntity>();
                Mapper.CreateMap<MNOACode, MNOACodeEntity>();
                Mapper.CreateMap<MNOC, MNOCEntity>();
                Mapper.CreateMap<MOccupation, MOccupationEntity>();
                //Mapper.CreateMap<MOrganization, MOrganizationEntity>();
                //Mapper.CreateMap<MOrganizationAddr, MOrganizationAddrEntity>();
                Mapper.CreateMap<MOSType, MOSTypeEntity>();
                Mapper.CreateMap<MParameterList, MParameterListEntity>();
                Mapper.CreateMap<MPartyAmendmentConfig, MPartyAmendmentConfigEntity>();
                Mapper.CreateMap<MPartySection, MPartySectionEntity>();
                Mapper.CreateMap<MPartyStatus, MPartyStatusEntity>();
                Mapper.CreateMap<MPartyType, MPartyTypeEntity>();
                Mapper.CreateMap<MPCCondition, MPCConditionEntity>();
                Mapper.CreateMap<MPersonIDGroup, MPersonIDGroupEntity>();
                Mapper.CreateMap<MPersonIDType, MPersonIDTypeEntity>();
                Mapper.CreateMap<MPrayerOutcome, MPrayerOutcomeEntity>();
                Mapper.CreateMap<MProbateNature, MProbateNatureEntity>();
                Mapper.CreateMap<MProbatePrayer, MProbatePrayerEntity>();
                Mapper.CreateMap<MPropertyType, MPropertyTypeEntity>();
                Mapper.CreateMap<MProvision, MProvisionEntity>();
                Mapper.CreateMap<MTaskListType, MTaskListTypeEntity>();
                Mapper.CreateMap<MPTCMilestone, MPTCMilestoneEntity>();
                Mapper.CreateMap<MQualification, MQualificationEntity>();
                Mapper.CreateMap<MRace, MRaceEntity>();
                Mapper.CreateMap<MRelationship, MRelationshipEntity>();
                Mapper.CreateMap<MRelief, MReliefEntity>();
                Mapper.CreateMap<MReligion, MReligionEntity>();
                Mapper.CreateMap<MRoutingType, MRoutingTypeEntity>();
                Mapper.CreateMap<MRulesOfCourtOrder, MRulesOfCourtOrderEntity>();
                Mapper.CreateMap<MSalutation, MSalutationEntity>();
                Mapper.CreateMap<MSection, MSectionEntity>();
                Mapper.CreateMap<MServeStatus, MServeStatusEntity>();
                //Mapper.CreateMap<MServiceType, MServiceTypeEntity>();
                Mapper.CreateMap<MSubProvision, MSubProvisionEntity>();
                Mapper.CreateMap<MTypeOfForeignLawPractice, MTypeOfForeignLawPracticeEntity>();
                Mapper.CreateMap<MUserGroup, MUserGroupEntity>();
                Mapper.CreateMap<MUserRole, MUserRoleEntity>();
                Mapper.CreateMap<MWorkFlow, MWorkFlowEntity>();
                Mapper.CreateMap<MWorkPeriod, MWorkPeriodEntity>();
                Mapper.CreateMap<MPrison, MPrisonEntity>();
                Mapper.CreateMap<MChargeType, MChargeTypeEntity>();
                Mapper.CreateMap<MCriminalOrder, MCriminalOrderEntity>();
                Mapper.CreateMap<MDrug, MDrugEntity>();
                Mapper.CreateMap<MModeOfTrafficking, MModeOfTraffickingEntity>();
                Mapper.CreateMap<MSentence, MSentenceEntity>();
                Mapper.CreateMap<MIOOrganisation, MIOOrganisationEntity>();
                Mapper.CreateMap<MNatureOfAppeal, MNatureOfAppealEntity>();
                Mapper.CreateMap<MNatureOfOffence, MNatureOfOffenceEntity>();
                Mapper.CreateMap<MBailType, MBailTypeEntity>();
                Mapper.CreateMap<MDrivingLicense, MDrivingLicenseEntity>();
                Mapper.CreateMap<MCriminalClaimantType, MCriminalClaimantTypeEntity>();
                Mapper.CreateMap<MCriminalClaimType, MCriminalClaimTypeEntity>();
                Mapper.CreateMap<RUserRoleSection, RUserRoleSectionEntity>();
                Mapper.CreateMap<RRoleFunctions, RRoleFunctionsEntity>();
                Mapper.CreateMap<RMDocCodeHRGType, RMDocCodeHrgTypeEntity>();
                Mapper.CreateMap<RMHRGTypeHRGSlot, RMHRGTypeHRGSlotEntity>();
                Mapper.CreateMap<RMHRGOutComePartyStatus, RMHRGOutComePartyStatusEntity>();
                Mapper.CreateMap<RMNOAForumHrgType, RMNOAForumHrgTypeEntity>();
                Mapper.CreateMap<MScheduleJobLegalInfo, MScheduleJobLegalInfoEntity>();
                Mapper.CreateMap<MScheduleJobLegalDetail, MScheduleJobLegalDetailEntity>();
                Mapper.CreateMap<RMCaseTypeNOA, RMCaseTypeNOAEntity>();
                Mapper.CreateMap<MWithDrawalInType, MWithDrawalInTypeEntity>();
                Mapper.CreateMap<MWithDrawalOfType, MWithDrawalOfTypeEntity>();
                Mapper.CreateMap<MProbateNatureGroup, MProbateNatureGroupEntity>();
                Mapper.CreateMap<MBusinessJobLegalInfo, MBusinessJobLegalInfoEntity>();
                Mapper.CreateMap<MBusinessJobLegalDetail, MBusinessJobLegalDetailEntity>();
                Mapper.CreateMap<MMonitoringType, MMonitoringTypeEntity>();
                Mapper.CreateMap<RMPartyStatusCaseType, RMPartyStatusCaseTypeEntity>();
                Mapper.CreateMap<MDocControl, MDocControlEntity>();
                Mapper.CreateMap<RUserFunctions, RUserFunctionsEntity>();
                Mapper.CreateMap<MHRGUserAvailability, MHRGUserAvailabilityEntity>();
                Mapper.CreateMap<RMRoutingSectionConfig, RMRoutingSectionConfigEntity>();
                Mapper.CreateMap<MSequenceKey, MSequenceKeyEntity>();
                Mapper.CreateMap<MHearingType, MHearingTypeEntity>();
                Mapper.CreateMap<RMCaseTypeNOC, RMCaseTypeNOCEntity>();
                Mapper.CreateMap<RMPartyTypeCaseType, RMPartyTypeCaseTypeEntity>();
                Mapper.CreateMap<MLawFirmGroup, MLawFirmGroupEntity>();
                Mapper.CreateMap<MEMSCrmCasePrefix, MEMSCrmCasePrefixEntity>();
                Mapper.CreateMap<RMHearingRoutingSectionConfig, RMHearingRoutingSectionConfigEntity>();
                Mapper.CreateMap<MAlertEventType, MAlertEventTypeEntity>();
                Mapper.CreateMap<RMAlertEventTypeRole, RMAlertEventTypeRoleEntity>();
                Mapper.CreateMap<RAlertEventSubscribers, RAlertEventSubscribersEntity>();
                Mapper.CreateMap<MDocControlForum, MDocControlForumEntity>();
                Mapper.CreateMap<MAASUniversity, MAASUniversityEntity>();
                Mapper.CreateMap<RMDocTierSensitive, RMDocTierSensitiveEntity>();
                Mapper.CreateMap<RMHrgSlotNOC, RMHrgSlotNOCEntity>();
                Mapper.CreateMap<MDefaultLoginPage, MDefaultLoginPageEntity>();
                Mapper.CreateMap<RMHrgSlotLegis, RMHrgSlotLegisEntity>();
                Mapper.CreateMap<RMDocControlExclusion, RMDocControlExclusionEntity>();
                Mapper.CreateMap<MResidential, MResidentialEntity>();
                Mapper.CreateMap<MIncome, MIncomeEntity>();
                Mapper.CreateMap<MDirections, MDirectionsEntity>();
                Mapper.CreateMap<MHarassPlace, MHarassPlaceEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MasterToMasterEntityMapping", ex);
                throw;
            }
        }

        #endregion Methods
    }
}