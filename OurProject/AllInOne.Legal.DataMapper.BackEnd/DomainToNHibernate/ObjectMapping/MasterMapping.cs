#region Header

/*****************************************************************************************************
* Description : This file represents a object mapper Master entities. This class will map Object to
* Entity.
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
// File: MasterMapper.cs
// Description: This file represents a object mapper Master entities. This class will map Object to
// Entity.
// </summary>
// <copyright file= "MasterMapper.cs" company="AllInOne Pte Ltd">
// Copyright (CNHibernateEntity) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.MRelationship;
    using AllInOne.Legal.Entities.BackEnd;

    internal class MasterMapping
    {
        #region Constructors

        internal MasterMapping()
        {
        }

        #endregion Constructors

        #region Methods

        internal void MainDomainToNHibernate()
        {
            Mapper.CreateMap<RMHRGTypePaperMinuteSheetTypeEntity, RMHRGTypePaperMinuteSheetType>();
            Mapper.CreateMap<MBusinessJobLegalInfoEntity, MBusinessJobLegalInfo>();
            Mapper.CreateMap<MPaperMinuteSheetTypeEntity, MPaperMinuteSheetType>();
            Mapper.CreateMap<MTypeOfForeignLawPracticeEntity, MTypeOfForeignLawPractice>();
            Mapper.CreateMap<MBusinessJobLegalDetailEntity, MBusinessJobLegalDetail>();
            Mapper.CreateMap<MAlertEventTypeEntity, MAlertEventType>();
            Mapper.CreateMap<RMAlertEventTypeRoleEntity, RMAlertEventTypeRole>();
            Mapper.CreateMap<RAlertEventSubscribersEntity, RAlertEventSubscribers>();
            Mapper.CreateMap<RMSubCaseTypeHRGTypeMSTypeEntity, RMSubCaseTypeHRGTypeMSType>();
            Mapper.CreateMap<MHRGBeforeTypeEntity, MHRGBeforeType>();
            Mapper.CreateMap<RMCaseTypeHRGTypeJOLEntity, RMCaseTypeHRGTypeJOL>();
            Mapper.CreateMap<MHRGPredefinedDateEntity, MHRGPredefinedDate>();
            Mapper.CreateMap<MSummonsGroundsEntity, MSummonsGrounds>();
            Mapper.CreateMap<MSummonsPrayersEntity, MSummonsPrayers>();
            Mapper.CreateMap<RMDocFilterGroupEntity, RMDocFilterGroup>();
            Mapper.CreateMap<MVSAConfigDetailEntity, MVSAConfigDetail>();
            Mapper.CreateMap<MVSAConfigGroundEntity, MVSAConfigGround>();
            Mapper.CreateMap<MVSAConfigPrayerEntity, MVSAConfigPrayer>();
            Mapper.CreateMap<MFilingFeeChargingMechanismEntity, MFilingFeeChargingMechanism>();
            Mapper.CreateMap<MFilingFeeLegislationActEntity, MFilingFeeLegislationAct>();
            Mapper.CreateMap<MLawFirmGroupEntity, MLawFirmGroup>();
            Mapper.CreateMap<MPrinterEntity, MPrinter>();
            Mapper.CreateMap<MEMSADMExecLocationEntity, MEMSADMExecLocation>();
            Mapper.CreateMap<MChargeOutcomeEntity, MChargeOutcome>();
            Mapper.CreateMap<MMassCallHrgDateEntity, MMassCallHrgDate>();
            Mapper.CreateMap<RMHRGTypeHRGSlotEntity, RMHRGTypeHRGSlot>();
            Mapper.CreateMap<MSummonsParamEntity, MSummonsParam>();
            Mapper.CreateMap<MDocControlEntity, MDocControl>();
            Mapper.CreateMap<RMCaseTypeNOCEntity, RMCaseTypeNOC>();
            Mapper.CreateMap<MIDTypeEntity, MIDType>();
            Mapper.CreateMap<RMNOAForumHrgTypeEntity, RMNOAForumHrgType>();
            Mapper.CreateMap<MEMSOldSCTCasePrefixEntity, MEMSOldSCTCasePrefix>();
            Mapper.CreateMap<MHRGOutComeFlagEntity, MHRGOutComeFlag>();
            Mapper.CreateMap<RMHRGTypeHRGOutComeHRGOutComeFlagEntity, RMHRGTypeHRGOutComeHRGOutComeFlag>();
            Mapper.CreateMap<RMHearingTypeCourtTypeEntity, RMHearingTypeCourtType>();
            Mapper.CreateMap<RMForumCoramDSGEntity, RMForumCoramDSG>();
            Mapper.CreateMap<MCoramEntity, MCoram>();
            Mapper.CreateMap<MMinuteSheetTypeEntity, MMinuteSheetType>();
            Mapper.CreateMap<RMCaseTypeHRGTypeMSTypeEntity, RMCaseTypeHRGTypeMSType>()
                .ForMember(dest => dest.IsMSConfidential, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsMSConfidential));
            Mapper.CreateMap<RMCaseTypeForumHRGTypeMSTypeEntity, RMCaseTypeForumHRGTypeMSType>()
                .ForMember(dest => dest.IsMSConfidential, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsMSConfidential));
            Mapper.CreateMap<RMCaseTypeForumEntity, RMCaseTypeForum>();
            Mapper.CreateMap<MFormTemplateLocationEntity, MFormTemplateLocation>();
            Mapper.CreateMap<MLimitationsEntity, MLimitations>();
            Mapper.CreateMap<MHolidayEntity, MHoliday>();
            Mapper.CreateMap<RMRoutingSectionConfigEntity, RMRoutingSectionConfig>()
                .ForMember(desc => desc.ByPassCaseOfficerSection, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ByPassCaseOfficerSection));
            Mapper.CreateMap<SerialNumberEntity, SerialNumber>();
            Mapper.CreateMap<MApptOrganisationEntity, MApptOrganisation>();
            Mapper.CreateMap<MCaseIssueEntity, MCaseIssue>();
            Mapper.CreateMap<MLegalPracticeEntity, MLegalPractice>();
            Mapper.CreateMap<MAASQualificationEntity, MAASQualification>();
            Mapper.CreateMap<MAASDisciplinaryTypeEntity, MAASDisciplinaryType>();
            Mapper.CreateMap<MAASLawDegreeEntity, MAASLawDegree>();
            Mapper.CreateMap<MAASSectionEntity, MAASSection>();
            Mapper.CreateMap<MAASUniversityEntity, MAASUniversity>();
            Mapper.CreateMap<MExternalAgencyEntity, MExternalAgency>();
            Mapper.CreateMap<MExternalAgencyAddressEntity, MExternalAgencyAddress>();
            Mapper.CreateMap<MCaseSecurityEntity, MCaseSecurity>();
            Mapper.CreateMap<MCaseStatusEntity, MCaseStatus>();
            Mapper.CreateMap<MCaseTypeEntity, MCaseType>();
            Mapper.CreateMap<MForumTypeEntity, MForumType>();
            Mapper.CreateMap<MBankruptcyBasisEntity, MBankruptcyBasis>();
            Mapper.CreateMap<MBankruptcyTypeEntity, MBankruptcyType>();
            Mapper.CreateMap<MActingInCapacityEntity, MActingInCapacity>();
            Mapper.CreateMap<MActingInCapacityGroupEntity, MActingInCapacityGroup>();
            Mapper.CreateMap<MAdpPrayerEntity, MAdpPrayer>();
            Mapper.CreateMap<MApplicantCapacityEntity, MApplicantCapacity>();
            Mapper.CreateMap<MBasisForTaxationEntity, MBasisForTaxation>();
            Mapper.CreateMap<MBasisOfTaxationTypeEntity, MBasisOfTaxationType>();
            Mapper.CreateMap<MBillNatureEntity, MBillNature>();
            Mapper.CreateMap<MBillTypeEntity, MBillType>();
            Mapper.CreateMap<MCaseSecurityEntity, MCaseSecurity>();
            Mapper.CreateMap<MCaseStatusEntity, MCaseStatus>();
            Mapper.CreateMap<MCaseTypeEntity, MCaseType>();
            Mapper.CreateMap<MCaseTypeGroupEntity, MCaseTypeGroup>();
            Mapper.CreateMap<MChecklistEntity, MChecklist>();
            Mapper.CreateMap<MClaimTypeEntity, MClaimType>();
            Mapper.CreateMap<MCountryEntity, MCountry>();
            Mapper.CreateMap<MCurrencyEntity, MCurrency>();
            Mapper.CreateMap<MDamageEntity, MDamage>();
            Mapper.CreateMap<MDeedTypeEntity, MDeedType>();
            Mapper.CreateMap<MDesignationEntity, MDesignation>();
            Mapper.CreateMap<MDialectEntity, MDialect>();
            Mapper.CreateMap<MDocCodeEntity, MDocCode>();
            Mapper.CreateMap<MDocLegislationEntity, MDocLegislation>();
            Mapper.CreateMap<MDocNatureEntity, MDocNature>();
            Mapper.CreateMap<MDocSecurityEntity, MDocSecurity>();
            Mapper.CreateMap<MDocStatusEntity, MDocStatus>();
            Mapper.CreateMap<MGenderEntity, MGender>();
            Mapper.CreateMap<MEntityTypeEntity, MEntityType>();
            Mapper.CreateMap<MFilingFeeEntity, MFilingFee>()
                .ForMember(dest=>dest.ROCReferences,opts=>opts.MapFrom(src=>src.ROCReference));
            Mapper.CreateMap<MFilingFeeTypeEntity, MFilingFeeType>();
            Mapper.CreateMap<MFunctionsEntity, MFunctions>();
            Mapper.CreateMap<MCaseSecurityEntity, MCaseSecurity>();
            Mapper.CreateMap<MCaseStatusEntity, MCaseStatus>();
            Mapper.CreateMap<MCaseTypeEntity, MCaseType>();
            Mapper.CreateMap<MFormSignatureEntity, MFormSignature>();
            //Mapper.CreateMap<MForumTypeEntity, MForumType>()
            //    .ForMember(desc => desc.ForumID, opts => opts.MapFrom(src => src.ForumId)) //different
            //    .ForMember(desc => desc.MCourtType, opts => opts.Ignore());
            Mapper.CreateMap<MBankruptcyBasisEntity, MBankruptcyBasis>();
            Mapper.CreateMap<MBankruptcyTypeEntity, MBankruptcyType>();
            Mapper.CreateMap<MHRGOutComeEntity, MHRGOutCome>();
            //Mapper.CreateMap<MHRGOutComeReasonEntity, MHRGOutComeReason>()
            //    .ForMember(desc => desc.LastModifiedBY, opts => opts.MapFrom(src => src.LastModifiedBy)) ;
            Mapper.CreateMap<MHRGRoomEntity, MHRGRoom>();
            Mapper.CreateMap<MHRGRoomTypeEntity, MHRGRoomType>();
            Mapper.CreateMap<MHRGSlotEntity, MHRGSlot>();
            //Mapper.CreateMap<MHRGSlotExceptione, MHRGSlotException>();
            Mapper.CreateMap<MHRGTimeLineEntity, MHRGTimeLine>();
            Mapper.CreateMap<MHRGTypeEntity, MHRGType>();
            //Mapper.CreateMap<MhrgUserAvailability, MhrgUserAvailability>();
            Mapper.CreateMap<MIconItemEntity, MIconItem>();
            //Mapper.CreateMap<MinuteSheete, MinuteSheet>();
            Mapper.CreateMap<MJudGDCatchWordEntity, MJudGDCatchWord>();
            //Mapper.CreateMap<MJudicialOfficer, MJudicialOfficer>();
            //Mapper.CreateMap<MLawFirmGroup, MLawFirmGroup>();
            Mapper.CreateMap<MLegislationActEntity, MLegislationAct>();
            //Mapper.CreateMap<MLinkedCaseTypee, MLinkedCaseType>();
            Mapper.CreateMap<MLocationEntity, MLocation>();
            Mapper.CreateMap<MNatureofDeputyshipEntity, MNatureOfDeputyShip>();
            Mapper.CreateMap<MMaritalStatusEntity, MMaritalStatus>();
            Mapper.CreateMap<MMessageTypeEntity, MMessageType>();
            Mapper.CreateMap<MNAAAlertEventRecipientEntity, MNAAAlertEventRecipient>();
            Mapper.CreateMap<MNAAAlertEventsTemplateEntity, MNAAAlertEventsTemplate>();
            Mapper.CreateMap<MNAACategoryEntity, MNAACategory>();
            Mapper.CreateMap<MNAAPlaceHolderEntity, MNAAPlaceHolder>();
            Mapper.CreateMap<MNAASubCategoryEntity, MNAASubCategory>();
            Mapper.CreateMap<MNationalityEntity, MNationality>();
            Mapper.CreateMap<MNatureOfProceedingEntity, MNatureOfProceeding>();
            Mapper.CreateMap<MNOACodeEntity, MNOACode>();
            Mapper.CreateMap<MNOCEntity, MNOC>();
            Mapper.CreateMap<MOccupationEntity, MOccupation>();
            //Mapper.CreateMap<MOrganizationEntity, MOrganization>();
            //Mapper.CreateMap<MOrganizationAddrEntity, MOrganizationAddr>();
            Mapper.CreateMap<MOSDocDetailEntity, MOSDocDetail>();
            Mapper.CreateMap<MOSTypeEntity, MOSType>();
            Mapper.CreateMap<MParameterListEntity, MParameterList>();
            //Mapper.CreateMap<MPartyAmendmentConfigEntity , MPartyAmendmentConfig>();//Different**
            //Mapper.CreateMap<MPartyAmendmente, MPartyAmendmentFieldConfig>();
            Mapper.CreateMap<MPartySectionEntity, MPartySection>();
            Mapper.CreateMap<MPartyStatusEntity, MPartyStatus>();
            Mapper.CreateMap<MPartyTypeEntity, MPartyType>();
            //Mapper.CreateMap<MPersonalFoldere, MPersonalFolder>();
            Mapper.CreateMap<MPersonIDGroupEntity, MPersonIDGroup>();
            Mapper.CreateMap<MPersonIDTypeEntity, MPersonIDType>();
            //Mapper.CreateMap<MPrayer, MPrayer>();
            Mapper.CreateMap<MPrayerOutcomeEntity, MPrayerOutcome>();
            //.ForMember(desc => desc.CaseTypeCode, opts => opts.Ignore());
            Mapper.CreateMap<MProbateNatureEntity, MProbateNature>();
            Mapper.CreateMap<MProbatePrayerEntity, MProbatePrayer>();
            Mapper.CreateMap<MPropertyTypeEntity, MPropertyType>();
            Mapper.CreateMap<MProvisionEntity, MProvision>();
            Mapper.CreateMap<MPTCMilestoneEntity, MPTCMilestone>();
            Mapper.CreateMap<MQualificationEntity, MQualification>();
            //Mapper.CreateMap<MQuickLink, MQuickLink>();
            Mapper.CreateMap<MRaceEntity, MRace>();
            Mapper.CreateMap<MCourtVacationEntity, MCourtVacation>();
            Mapper.CreateMap<MRDocCategoryCaseTypeEntity, MRDocCategoryCaseType>();
            //Mapper.CreateMap<MRDocCodeHearingOutComee, MRDocCodeHearingOutCome>();
            //Mapper.CreateMap<MRegReason, MRegReason>();
            Mapper.CreateMap<MRelationshipEntity, MRelationship>();
            Mapper.CreateMap<MReliefEntity, MRelief>();
            Mapper.CreateMap<MReligionEntity, MReligion>();
            //Mapper.CreateMap<MRNAAAlertEventsMailBox, MRNAAAlertEventsMailBox>();
            //Mapper.CreateMap<MRNAAHearingAlerts, MRNAAHearingAlerts>();
            //Mapper.CreateMap<MRNAAHorizontalsTemplatee, MRNAAHorizontalsTemplate>();
            Mapper.CreateMap<MRoutingTypeEntity, MRoutingType>();
            Mapper.CreateMap<MSalutationEntity, MSalutation>();
            Mapper.CreateMap<MSectionEntity, MSection>();
            Mapper.CreateMap<MSequenceKeyEntity, MSequenceKey>();
            //Mapper.CreateMap<MServiceType, MServiceType>();
            //Mapper.CreateMap<MSpecificRoutingRule, MSpecificRoutingRule>();
            //Mapper.CreateMap<Mstatus, Mstatus>();
            Mapper.CreateMap<MSubProvisionEntity, MSubProvision>();
            Mapper.CreateMap<MTaskListTypeEntity, MTaskListType>();
            //Mapper.CreateMap<MSupportingDocuments, MSupportingDocuments>();
            Mapper.CreateMap<MUserGroupEntity, MUserGroup>();
            Mapper.CreateMap<MUserRoleEntity, MUserRole>();
            Mapper.CreateMap<MWorkFlowEntity, MWorkFlow>();
            //Mapper.CreateMap<MWorkFLowProcessing, MWorkFLowProcessing>();
            Mapper.CreateMap<MWorkPeriodEntity, MWorkPeriod>();
            Mapper.CreateMap<MServeStatusEntity, MServeStatus>();
            Mapper.CreateMap<RMSectionAccessCtrlEntity, RMSectionAccessCtrl>();
            Mapper.CreateMap<RMPartyTypeCaseTypeEntity, RMPartyTypeCaseType>()
                .ForMember(dest => dest.ComTypeInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ComTypeInd))
                .ForMember(dest => dest.IsInterfaced, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInterfaced))
                .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(dest => dest.PartyFlippingCategory, opts => opts.ResolveUsing<PartyFlippingCategoryToStringResolver>().FromMember(src => src.PartyFlippingCategory));
            Mapper.CreateMap<RMDocCodeHrgTypeEntity, RMDocCodeHRGType>()
                .ForMember(dest => dest.EndorsementType, opts => opts.ResolveUsing<EndorsementTypeToStringResolver>().FromMember(src => src.EndorsementType))
                .ForMember(dest => dest.WeekEndInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.WeekEndInd))
                .ForMember(dest => dest.ROCInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ROCInd))
                .ForMember(dest => dest.UsedInAutoFix, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.UsedInAutoFix));
            //Enforcement

            Mapper.CreateMap<MEMSAttendanceFeeEntity, MEMSAttendanceFee>()
                .ForMember(dest => dest.EMSType, opts => opts.ResolveUsing<EMSTypeToStringResolver>().FromMember(src => src.EMSType))
                ;
            Mapper.CreateMap<MEMSWritApptEntity, MEMSWritAppt>();
            Mapper.CreateMap<MEMSAdvertInEntity, MEMSAdvertIn>();
            Mapper.CreateMap<MEMSCourtCommEntity, MEMSCourtComm>()
                .ForMember(dest => dest.EMStype, opts => opts.ResolveUsing<EMSTypeToStringResolver>().FromMember(src => src.EMStype));
            Mapper.CreateMap<MEMSAdvertiserEntity, MEMSAdvertiser>();
            Mapper.CreateMap<MEMSAppraiserEntity, MEMSAppraiser>();
            Mapper.CreateMap<MEMSApptOutcomeEntity, MEMSApptOutcome>();
            Mapper.CreateMap<MEMSApptReasonEntity, MEMSApptReason>();
            Mapper.CreateMap<MEMSApptTypeEntity, MEMSApptType>();
            Mapper.CreateMap<MEMSFileMoveDescEntity, MEMSFileMoveDesc>();
            Mapper.CreateMap<MEMSRecBankEntity, MEMSRecBank>();
            Mapper.CreateMap<MEMSRecTransModeEntity, MEMSRecTransMode>();
            Mapper.CreateMap<MEMSRecTransTypeEntity, MEMSRecTransType>();
            Mapper.CreateMap<MEMSSalesAgentEntity, MEMSSalesAgent>();
            Mapper.CreateMap<MEMSParamEntity, MEMSParam>();
            Mapper.CreateMap<MEMSNatureOfPaymentEntity, MEMSNatureOfPayment>();
            Mapper.CreateMap<MEMSSecurityGuardEntity, MEMSSecurityGuard>();
            Mapper.CreateMap<MEMSLedgerEntity, MEMSLedger>()
                .ForMember(dest => dest.IsDebitCredit, opts => opts.ResolveUsing<CreditDebitToStringResolver>().FromMember(src => src.IsDebitCredit))
                ;
            Mapper.CreateMap<MEMSDisburseRateEntity, MEMSDisburseRate>()
                .ForMember(dest => dest.EMSType, opts => opts.ResolveUsing<EMSTypeToStringResolver>().FromMember(src => src.EMSType))
                ;

            Mapper.CreateMap<MPrisonEntity, MPrison>();
            Mapper.CreateMap<MChargeTypeEntity, MChargeType>();
            Mapper.CreateMap<MCriminalOrderEntity, MCriminalOrder>();
            Mapper.CreateMap<MDrugEntity, MDrug>();
            Mapper.CreateMap<MModeOfTraffickingEntity, MModeOfTrafficking>();
            Mapper.CreateMap<MSentenceEntity, MSentence>();
            Mapper.CreateMap<MIOOrganisationEntity, MIOOrganisation>();
            Mapper.CreateMap<MNatureOfAppealEntity, MNatureOfAppeal>();
            Mapper.CreateMap<MNatureOfOffenceEntity, MNatureOfOffence>();
            Mapper.CreateMap<MBailTypeEntity, MBailType>();
            Mapper.CreateMap<MDrivingLicenseEntity, MDrivingLicense>();

            Mapper.CreateMap<MCriminalClaimantTypeEntity, MCriminalClaimantType>();
            Mapper.CreateMap<MCriminalClaimTypeEntity, MCriminalClaimType>();
            Mapper.CreateMap<RMAASSectionExternalAgencyEntity, RMAASSectionExternalAgency>();
            Mapper.CreateMap<RUserRoleSectionEntity, RUserRoleSection>();
            Mapper.CreateMap<RRoleFunctionsEntity, RRoleFunctions>();

            Mapper.CreateMap<RMCaseTypeNOAEntity, RMCaseTypeNOA>();
            Mapper.CreateMap<RMHRGOutComePartyStatusEntity, RMHRGOutComePartyStatus>();
            Mapper.CreateMap<MNatureOfWorkEntity, MNatureOfWork>();
            Mapper.CreateMap<MMonitoringTypeEntity, MMonitoringType>();
            Mapper.CreateMap<MProbateNatureGroupEntity, MProbateNatureGroup>();
            Mapper.CreateMap<RUserFunctionsEntity, RUserFunctions>();
            Mapper.CreateMap<RUserFunctionsEntity, RUserFunctions>();
            Mapper.CreateMap<MAASDisciplinaryResultTypeEntity, MAASDisciplinaryResultType>()
                .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            Mapper.CreateMap<MDocCategoryEntity, MDocCategory>()
                .ForMember(dest => dest.ForSubsequentFiling, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ForSubsequentFiling));
            Mapper.CreateMap<MHearingTypeEntity, MHearingType>()
                 .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                 .ForMember(dest => dest.HearingModeInd, opts => opts.ResolveUsing<HearingModeIndToStringResolver>().FromMember(src => src.HearingModeInd))
                 .ForMember(dest => dest.IsInterfaced, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInterfaced));
            Mapper.CreateMap<MHRGOutComeReasonEntity, MHRGOutComeReason>();
            Mapper.CreateMap<MLawPracticeTypeEntity, MLawPracticeType>();
            Mapper.CreateMap<MEMSCrmCasePrefixEntity, MEMSCrmCasePrefix>()
                .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            Mapper.CreateMap<RMHearingRoutingSectionConfigEntity, RMHearingRoutingSectionConfig>();
            Mapper.CreateMap<RMDocTierSensitiveEntity, RMDocTierSensitive>();
            Mapper.CreateMap<RMHrgSlotNOCEntity, RMHrgSlotNOC>();
            Mapper.CreateMap<RMHrgSlotLegisEntity, RMHrgSlotLegis>();
            Mapper.CreateMap<RMDocControlExclusionEntity, RMDocControlExclusion>();
            Mapper.CreateMap<MResidentialEntity, MResidential>();
            Mapper.CreateMap<MIncomeEntity, MIncome>();
            Mapper.CreateMap<MDirectionsEntity, MDirections>()
                .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            Mapper.CreateMap<MHarassPlaceEntity, MHarassPlace>();
        }

        internal void MapMAlertEventEntityToMAlertEvent()
        {
            Mapper.CreateMap<MAlertEventEntity, MAlertEvent>()
                .ForMember(dest => dest.AlertEventId, opts => opts.MapFrom(src => src.AlertEventId))
                .ForMember(dest => dest.AlertTypeId, opts => opts.MapFrom(src => src.AlertTypeId));
        }

        internal void MapMAlertTypeEntityToMAlertType()
        {
            Mapper.CreateMap<MAlertTypeEntity, MAlertType>()
                .ForMember(dest => dest.AlertTypeId, opts => opts.MapFrom(src => src.AlertTypeId));
        }

        internal void MapMChecklistDocumentEntityToMChecklistDocument()
        {
            Mapper.CreateMap<MChecklistDocumentEntity, MChecklistDocument>()
                .ForMember(dest => dest.ChecklistDocId, opts => opts.MapFrom(src => src.ChecklistDocId));
        }

        internal void MapMCourtTypeEntityToMCourtType()
        {
            Mapper.CreateMap<MCourtTypeEntity, MCourtType>()
                .ForMember(dest => dest.CourtId, opts => opts.MapFrom(src => src.CourtId));
        }

        internal void MapMEMSAdvertInEntityToMEMSAdvertIn()
        {
            Mapper.CreateMap<MEMSAdvertInEntity, MEMSAdvertIn>()
                .ForMember(dest => dest.EMSAdvertInCode, opts => opts.MapFrom(src => src.EMSAdvertInCode));
        }

        internal void MapMEMSAdvertiserEntityToMEMSAdvertiser()
        {
            Mapper.CreateMap<MEMSAdvertiserEntity, MEMSAdvertiser>()
                .ForMember(dest => dest.EMSAdvertiserCode, opts => opts.MapFrom(src => src.EMSAdvertiserCode));
        }

        internal void MapMEMSAppraiserEntityToMEMSAppraiser()
        {
            Mapper.CreateMap<MEMSAppraiserEntity, MEMSAppraiser>()
                .ForMember(dest => dest.EMSAppraiserCode, opts => opts.MapFrom(src => src.EMSAppraiserCode));
        }

        internal void MapMEMSApptOutcomeEntityToMEMSApptOutcome()
        {
            Mapper.CreateMap<MEMSApptOutcomeEntity, MEMSApptOutcome>()
                .ForMember(dest => dest.EMSApptOutcomeCode, opts => opts.MapFrom(src => src.EMSApptOutcomeCode));
        }

        internal void MapMEMSApptReasonEntityToMEMSApptReason()
        {
            Mapper.CreateMap<MEMSApptReasonEntity, MEMSApptReason>()
                .ForMember(dest => dest.EMSApptReasonCode, opts => opts.MapFrom(src => src.EMSApptReasonCode));
        }

        internal void MapMEMSApptTypeEntityToMEMSApptType()
        {
            Mapper.CreateMap<MEMSApptTypeEntity, MEMSApptType>()
                .ForMember(dest => dest.EMSApptTypeCode, opts => opts.MapFrom(src => src.EMSApptTypeCode));
        }

        internal void MapMEMSAuctioneerEntityToMEMSAuctioneer()
        {
            Mapper.CreateMap<MEMSAuctioneerEntity, MEMSAuctioneer>()
                .ForMember(dest => dest.EMSAuctioneerCode, opts => opts.MapFrom(src => src.EMSAuctioneerCode))
                .ForMember(dest => dest.IsRoundRobin, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsRoundRobin))
                //.ForMember(dest => dest.IsLastRRSequenceNo, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsLastRRSequenceNo))
                ;
        }

        internal void MapMEMSFileMoveDescEntityToMEMSFileMoveDesc()
        {
            Mapper.CreateMap<MEMSFileMoveDescEntity, MEMSFileMoveDesc>()
                .ForMember(dest => dest.EMSFileMoveDescCode, opts => opts.MapFrom(src => src.EMSFileMoveDescCode));
        }

        internal void MapMEMSRecBankEntityToMEMSRecBank()
        {
            Mapper.CreateMap<MEMSRecBankEntity, MEMSRecBank>()
                .ForMember(dest => dest.EMSRecBankCode, opts => opts.MapFrom(src => src.EMSRecBankCode));
        }

        internal void MapMEMSRecTransModeEntityToMEMSRecTransMode()
        {
            Mapper.CreateMap<MEMSRecTransModeEntity, MEMSRecTransMode>()
                .ForMember(dest => dest.EMSRecTransModeCode, opts => opts.MapFrom(src => src.EMSRecTransModeCode));
        }

        internal void MapMEMSRecTransTypeEntityToMEMSRecTransType()
        {
            Mapper.CreateMap<MEMSRecTransTypeEntity, MEMSRecTransType>()
                .ForMember(dest => dest.EMSRecTransTypeCode, opts => opts.MapFrom(src => src.EMSRecTransTypeCode));
        }

        internal void MapMEMSSalesAgentEntityToMEMSSalesAgent()
        {
            Mapper.CreateMap<MEMSSalesAgentEntity, MEMSSalesAgent>()
                .ForMember(dest => dest.EMSSalesAgentCode, opts => opts.MapFrom(src => src.EMSSalesAgentCode));
        }

        internal void MapMFilterGroupEntityToFilterGroup()
        {
            Mapper.CreateMap<MFilterGroupEntity, MFilterGroup>()
                .ForMember(dest => dest.FilterGroupId, opts => opts.MapFrom(src => src.FilterGroupId));
        }

        internal void MapMForumTypeEntityToMForumType()
        {
            Mapper.CreateMap<MForumTypeEntity, MForumType>()
                .ForMember(desc => desc.ForumId, opts => opts.MapFrom(src => src.ForumId));
        }

        internal void MapMHRGOutComeReasonEntityToMHRGOutComeReason()
        {
            Mapper.CreateMap<MHRGOutComeReasonEntity, MHRGOutComeReason>()
               .ForMember(desc => desc.LastModifiedBY, opts => opts.MapFrom(src => src.LastModifiedBy));
        }

        internal void MapMPartyAmendmentConfigEntityToMPartyAmendmentConfig()
        {
            Mapper.CreateMap<MPartyAmendmentConfigEntity, MPartyAmendmentConfig>()
                .ForMember(dest => dest.AmendmentConfigId, opts => opts.MapFrom(src => src.AmendmentConfigId));
        }

        internal void MapMScheduleJobLegalDetailEntityToMScheduleJobLegalDetail()
        {
            Mapper.CreateMap<MScheduleJobLegalDetailEntity, MScheduleJobLegalDetail>()
                .ForMember(dest => dest.IsActive, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsActive))
                ;
        }

        internal void MapMScheduleJobLegalInfoEntityToMScheduleJobLegalInfo()
        {
            Mapper.CreateMap<MScheduleJobLegalInfoEntity, MScheduleJobLegalInfo>()
                .ForMember(dest => dest.IsActive, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsActive))
                ;
        }

        internal void MapRMHrgSlotNOCEntityToRMHrgSlotNOC()
        {
            Mapper.CreateMap<RMHrgSlotNOCEntity, RMHrgSlotNOC>()
                .ForMember(dest => dest.RMHrgSlotNocID, opts => opts.MapFrom(src => src.RMHrgSlotNocID));
        }

        internal void MapRMHrgSlotLegisEntityToRMHrgSlotLegis()
        {
            Mapper.CreateMap<RMHrgSlotLegisEntity, RMHrgSlotLegis>()
                .ForMember(dest => dest.RMHrgSlotLegisId, opts => opts.MapFrom(src => src.RMHrgSlotLegisId));
        }

        internal void MapRMDocControlExclusionEntityToRMDocControlExclusion()
        {
            Mapper.CreateMap<RMDocControlExclusionEntity, RMDocControlExclusion>()
                .ForMember(dest => dest.RMDocControlExclusionId, opts => opts.MapFrom(src => src.RMDocControlExclusionId))
                .ForMember(dest => dest.IsInterfaced, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInterfaced))
                .ForMember(dest => dest.MDocCode, opts => opts.MapFrom(src => src.DocCode))
                .ForMember(dest => dest.MCaseType, opts => opts.MapFrom(src => src.CaseTypeCode))
                .ForMember(dest => dest.MSubCaseType, opts => opts.MapFrom(src => src.CaseTypeCode))
                .ForMember(dest => dest.MForumType, opts => opts.MapFrom(src => src.ForumID))
                ;
        }

        internal void MapMHarassPlaceEntityToMHarassPlace()
        {
            Mapper.CreateMap<MHarassPlaceEntity, MHarassPlace>()
                .ForMember(dest => dest.HarassPlaceCode, opts => opts.MapFrom(src => src.HarassPlaceCode));
        }

        #endregion Methods
    }
}