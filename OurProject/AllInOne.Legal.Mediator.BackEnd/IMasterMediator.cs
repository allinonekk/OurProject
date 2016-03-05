namespace AllInOne.Legal.Mediator.BackEnd
{
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.MRelationship;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Common;

    public interface IMasterMediator
    {
        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        /// <param name="sender"></param>
        void BeginTransaction();

        /// <summary>
        /// Method to Close the session.
        /// </summary>
        void CloseSession();

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        void CommitAndCloseSession();

        /// <summary>
        /// Creates the master entity.
        /// </summary>
        /// <param name="masterEntity">The master entity.</param>
        void CreateMasterEntity(IMasterEntity masterEntity);

        /// <summary>
        /// Gets all <see cref="MBailTypeEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MBailTypeEntity> GetAllMBailType();

        List<MCaseTypeEntity> GetAllMCaseTypeEntity();

        /// <summary>
        /// Gets all <see cref="MChargeTypeEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MChargeTypeEntity> GetAllMChargeType();

        List<MCoramEntity> GetAllMCoramEntity();

        /// <summary>
        /// Gets the list of <see cref="MCountryEntity"/>
        /// </summary>
        /// <returns></returns>
        List<MCountryEntity> GetAllMCountry();

        List<MCourtTypeEntity> GetAllMCourtTypeEntity();

        /// <summary>
        /// Gets the list of <see cref="MCriminalClaimantTypeEntity"/>
        /// </summary>
        /// /// <returns>List<MCriminalClaimantTypeEntity></returns>
        List<MCriminalClaimantTypeEntity> GetAllMCriminalClaimantType();

        /// <summary>
        /// Gets the list of <see cref="MCriminalClaimTypeEntity"/>
        /// </summary>
        /// /// <returns>List<MCriminalClaimTypeEntity></returns>
        List<MCriminalClaimTypeEntity> GetAllMCriminalClaimType();

        /// <summary>
        /// Gets all <see cref="MCriminalOrderEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MCriminalOrderEntity> GetAllMCriminalOrder();

        /// <summary>
        /// Gets all M currency entity.
        /// </summary>
        /// <returns></returns>
        List<MCurrencyEntity> GetAllMCurrencyEntity();

        /// <summary>
        /// Gets all M dialect entity.
        /// </summary>
        /// <returns></returns>
        List<MDialectEntity> GetAllMDialectEntity();

        /// <summary>
        /// Gets all M doc category.
        /// </summary>
        /// <returns></returns>
        List<MDocCategoryEntity> GetAllMDocCategory();

        /// <summary>
        /// Gets all M doc code entity.
        /// </summary>
        /// <returns></returns>
        List<MDocCodeEntity> GetAllMDocCodeEntity();

        /// <summary>
        /// Gets all M doc nature entity.
        /// </summary>
        /// <returns></returns>
        List<MDocNatureEntity> GetAllMDocNatureEntity();

        /// <summary>
        /// Gets all M doc security.
        /// </summary>
        /// <returns></returns>
        List<MDocSecurityEntity> GetAllMDocSecurity();

        /// <summary>
        /// Gets all M law firm group entity.
        /// </summary>
        /// <returns></returns>
        List<MLawFirmGroupEntity> GetAllMLawFirmGroupEntity();
        /// <summary>
        /// Gets all <see cref="MDrivingLicenseEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MDrivingLicenseEntity> GetAllMDrivingLicense();

        /// <summary>
        /// Gets all <see cref="MDrugEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MDrugEntity> GetAllMDrug();

        List<MEMSWritApptEntity> GetAllMEMSWritApptEntity();

        /// <summary>
        /// Gets the list of <see cref="MEntityTypeEntity"/>
        /// </summary>
        /// <returns></returns>
        List<MEntityTypeEntity> GetAllMEntityType();

        List<MFormTemplateLocationEntity> GetAllMFormTemplateLocationEntity();

        List<MForumTypeEntity> GetAllMForumTypeEntity();

        /// <summary>
        /// Gets the list of <see cref="MGenderEntity"/>
        /// </summary>
        /// <returns></returns>
        List<MGenderEntity> GetAllMGender();

        List<MHolidayEntity> GetAllMHolidayEntity();

        /// <summary>
        /// Gets all <see cref="MHRGTypeEntity"/>
        /// </summary>
        /// <returns></returns>
        List<MHRGTypeEntity> GetAllMHRGTypeEntity();

        List<MHRGUserAvailabilityEntity> GetAllMHRGUserAvailability();

        /// <summary>
        /// Gets all <see cref="MIOOrganisationEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MIOOrganisationEntity> GetAllMIOOrganisation();

        List<MLegalPracticeEntity> GetAllMLegalPracticeEntity();

        /// <summary>
        /// Gets all <see cref="MLegislationActEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MLegislationActEntity> GetAllMLegislationAct();

        List<MLimitationsEntity> GetAllMLimitationsEntity();

        List<MMaritalStatusEntity> GetAllMMaritalStatusEntity();

        /// <summary>
        /// Gets all <see cref="MModeOfTraffickingEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MModeOfTraffickingEntity> GetAllMModeOfTrafficking();

        /// <summary>
        /// Gets the list of <see cref="MNationalityEntity"/>
        /// </summary>
        /// <returns></returns>
        List<MNationalityEntity> GetAllMNationality();

        /// <summary>
        /// Gets all <see cref="MNatureOfAppealEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MNatureOfAppealEntity> GetAllMNatureOfAppeal();

        /// <summary>
        /// Gets all <see cref="MNatureOfOffenceEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MNatureOfOffenceEntity> GetAllMNatureOfOffence();

        /// <summary>
        /// Gets all <see cref="MNOACodeEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MNOACodeEntity> GetAllMNOACode();

        /// <summary>
        /// Gets the list of <see cref="MOccupationEntity"/>
        /// </summary>
        /// <returns></returns>
        List<MOccupationEntity> GetAllMOccupation();

        List<MPartyStatusEntity> GetAllMPartyStatus();

        /// <summary>
        /// Gets all <see cref="MPrisonEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MPrisonEntity> GetAllMPrison();

        /// <summary>
        /// Gets all <see cref="MProvisionEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MProvisionEntity> GetAllMProvision();

        /// <summary>
        /// Gets the list of <see cref="MQualificationEntity"/>
        /// </summary>
        /// <returns></returns>
        List<MQualificationEntity> GetAllMQualification();

        /// <summary>
        /// Gets the list of <see cref="MRaceEntity"/>
        /// </summary>
        /// <returns></returns>
        List<MRaceEntity> GetAllMRace();

        /// <summary>
        /// Gets the list of <see cref="MReligionEntity"/>
        /// </summary>
        /// <returns></returns>
        List<MReligionEntity> GetAllMReligion();

        /// <summary>
        /// Gets the List of MSectionEntity
        /// </summary>
        /// <returns></returns>
        List<MSectionEntity> GetAllMSectionEntity();

        /// <summary>
        /// Gets all <see cref="MSentenceEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MSentenceEntity> GetAllMSentence();

        /// <summary>
        /// Gets all <see cref="MSubProvisionEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MSubProvisionEntity> GetAllMSubProvision();

        /// <summary>
        /// Gets List of<see cref="MTaskListTypeEntity"/>
        /// </summary>
        /// <returns></returns>
        List<MTaskListTypeEntity> GetAllMTaskListType();

        List<RMCaseTypeForumEntity> GetAllRMCaseTypeForumEntity();

        List<RMCaseTypeNOAEntity> GetAllRMCaseTypeNOAEntity();

        List<MBusinessJobLegalDetailEntity> GetListMBusinessJobLegalDetailEntity(string businessJobLegalInfoId);

        List<MChecklistEntity> GetListMCheckListByCaseType(string caseType);

        List<MChecklistDocumentEntity> GetListMChecklistDocument(long checkListId);

        List<MDocCodeEntity> GetListMDocCode(string mainGroup, string subCategory);

        List<MDocControlEntity> GetListMDocControlByDocCode(string docCode);

        List<MFunctionsEntity> GetListMFunctionsEntity(string roleCode);

        /// <summary>
        /// Gets the list of <see cref="MHRGTypeEntity "/>
        /// </summary>
        /// <param name="roleCode">The hRGTypeCode.</param>
        /// <returns></returns>
        List<MHRGTypeEntity> GetListMHrgType(string hRGTypeCode);

        /// <summary>
        /// Get a list of MNOACodeEntity by caseTypeCode;
        /// </summary>
        /// <param name="caseTypeCode">The caseTypeCode of the field to filter while retrieving the objects.</param>
        /// <returns>List<MNOACodeEntity></returns>
        List<MNOACodeEntity> GetListMNOACodeEntityByCaseType(string caseTypeCode);

        /// <summary>
        /// Gets the list of <see cref="MPersonIDGroupEntity"/>
        /// </summary>
        /// <returns></returns>
        List<MPersonIDGroupEntity> GetListMPersonIDGroupOrderBySeqNo();

        /// <summary>
        /// Gets the list of <see cref="MPersonIDTypeEntity"/> based on the entityTypeCode
        /// </summary>
        /// <param name="entityTypeCode"></param>
        /// <returns></returns>
        List<MPersonIDTypeEntity> GetListMPersonIDTypeEntityByEntityType(string entityTypeCode);

        /// <summary>
        /// Gets the list of <see cref="RMDocCodeHrgTypeEntity "/>
        /// </summary>
        /// <param name="docCode">The doc code.</param>
        /// <param name="caseTypeCode">The case type code.</param>
        /// <returns></returns>
        List<RMDocCodeHrgTypeEntity> GetListRMDocCodeHrgType(string docCode, string caseTypeCode);

        /// <summary>
        /// Gets the list of <see cref="RMDocCodeHrgTypeEntity "/>
        /// </summary>
        /// <param name="docCode">The doc code.</param>
        /// <returns></returns>
        List<RMDocCodeHrgTypeEntity> GetListRMDocCodeHrgType(string docCode);

        /// <summary>
        /// Gets the list of <see cref="RMHRGTypeHRGSlotEntity "/>
        /// </summary>
        /// <param name="CourtInd">The court ind.</param>
        /// <param name="HRGTypeCode">The HRG type code.</param>
        /// <returns></returns>
        List<RMHRGTypeHRGSlotEntity> GetListRMHrgTypeHrgSlot(string CourtInd, string HRGTypeCode);

        /// <summary>
        /// Gets the list of <see cref="RMNOAForumHrgTypeEntity"/>
        /// </summary>
        /// <param name="NOACode">The NOA code.</param>
        /// <param name="ForumId">The forum id.</param>
        /// <returns></returns>
        List<RMNOAForumHrgTypeEntity> GetListRMNOAForumHrgType(string NOACode, string ForumId);

        /// <summary>
        /// Gets the list of <see cref="RMNOAForumHrgTypeEntity"/>
        /// </summary>
        /// <param name="NOACode">The NOA code.</param>
        /// <returns></returns>
        List<RMNOAForumHrgTypeEntity> GetListRMNOAForumHrgType(string NOACode);

        List<RMPartyStatusCaseTypeEntity> GetListRMPartyStatusCaseTypeEntity(string caseTypeCode);

        List<RMRoutingSectionConfigEntity> GetListRMRoutingSectionConfigEntity(string forumId);


        /// <summary>
        /// Gets the list RM hearing routing section config entity.
        /// </summary>
        /// <param name="forumId">The forum id.</param>
        /// <returns></returns>
        List<RMHearingRoutingSectionConfigEntity> GetListRMHearingRoutingSectionConfigEntity(string forumId);
        /// <summary>
        /// Gets the list of <see cref="RUserRoleSectionEntity "/>
        /// </summary>
        /// <param name="roleCode">The roleCode.</param>
        /// <param name="sectionCode">The sectionCode.</param>
        /// <returns></returns>
        List<RUserRoleSectionEntity> GetListRUserRoleSection(string roleCode, string sectionCode);

        /// <summary>
        /// Gets the list of <see cref="RUserRoleSectionEntity "/>
        /// </summary>
        /// <param name="roleCode">The roleCode.</param>
        /// <returns></returns>
        List<RUserRoleSectionEntity> GetListRUserRoleSectionByRoleCode(string roleCode);

        /// <summary>
        /// Gets the list of <see cref="RUserRoleSectionEntity "/>
        /// </summary>
        /// <param name="roleCode">The sectionCode.</param>
        /// <returns></returns>
        List<RUserRoleSectionEntity> GetListRUserRoleSectionBySectionCode(string sectionCode);

        IMasterEntity GetMasterEntityByPK<T>(string primaryKey);

        /// <summary>
        /// Gets <see cref="MBailTypeEntity "/>
        /// </summary>
        /// <param name="bailTypeCode"></param>
        /// <returns></returns>
        MBailTypeEntity GetMBailTypeEntity(string bailTypeCode);

        MBusinessJobLegalInfoEntity GetMBusinessJobLegalInfoEntityByPK(string businessJobLegalInfoId);

        /// <summary>
        /// Gets all <see cref="MCaseIssueEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MCaseIssueEntity> GetMCaseIssue();

        /// <summary>
        /// Gets all <see cref="MCaseIssueEntity "/>
        /// </summary>
        /// <returns></returns>
        List<MCaseIssueEntity> GetMCaseIssue<V>(string fieldName, V value);

        /// <summary>
        /// Gets <see cref="MChargeTypeEntity "/>
        /// </summary>
        /// <param name="chargeTypeCode"></param>
        /// <returns></returns>
        MChargeTypeEntity GetMChargeTypeEntity(string chargeTypeCode);

        /// <summary>
        /// Gets MCriminalClaimantTypeEntity by criminalClaimantTypeCode;
        /// </summary>
        /// <param name="caseTypeCode">The criminalClaimantTypeCode of the field to filter while retrieving the objects.</param>
        /// /// <returns><MCriminalClaimantTypeEntity></returns>
        MCriminalClaimantTypeEntity GetMCriminalClaimantTypeEntityByCriminalClaimantTypeCode(string criminalClaimantTypeCode);

        /// <summary>
        /// Gets MCriminalClaimTypeEntity by criminalClaimTypeCode;
        /// </summary>
        /// <param name="criminalClaimTypeCode">The criminalClaimTypeCode of the field to filter while retrieving the objects.</param>
        /// /// <returns><MCriminalClaimTypeEntity></returns>
        MCriminalClaimTypeEntity GetMCriminalClaimTypeEntityByCriminalClaimaTypeCode(string criminalClaimTypeCode);

        /// <summary>
        /// Gets <see cref="MCriminalOrderEntity "/>
        /// </summary>
        /// <param name="criminalOrderCode"></param>
        /// <returns></returns>
        MCriminalOrderEntity GetMCriminalOrderEntity(string criminalOrderCode);

        MDocCodeEntity GetMDocCodeEntityByPK(string docCode);

        /// <summary>
        /// Gets <see cref="MDrivingLicenseEntity "/>
        /// </summary>
        /// <param name="drivingLicenseCode"></param>
        /// <returns></returns>
        MDrivingLicenseEntity GetMDrivingLicenseEntity(string drivingLicenseCode);

        /// <summary>
        /// Gets <see cref="MDrugEntity "/>
        /// </summary>
        /// <param name="drugCode"></param>
        /// <returns></returns>
        MDrugEntity GetMDrugEntity(string drugCode);

        /// <summary>
        /// Gets the list of <see cref="MFunctionsEntity "/>
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        List<MFunctionsEntity> GetMFunctions<V>(string fieldName, V value);

        MHRGRoomEntity GetMHRGRoomEntityByPK(string hRGRoomCode);

        MHRGTypeEntity GetMHrgTypeEntity(string courtInd, string hrgTypeCode);

        /// <summary>
        /// Gets <see cref="MIOOrganisationEntity "/>
        /// </summary>
        /// <param name="ioOrganisationCode"></param>
        /// <returns></returns>
        MIOOrganisationEntity GetMIOOrganisationEntity(string ioOrganisationCode);

        /// <summary>
        /// Gets <see cref="MLegislationActEntity "/>
        /// </summary>
        /// <param name="drivingLicenseCode"></param>
        /// <returns></returns>
        MLegislationActEntity GetMLegislationActEntity(string actCode);

        /// <summary>
        /// Gets <see cref="MModeOfTraffickingEntity "/>
        /// </summary>
        /// <param name="modeOfTraffickingCode"></param>
        /// <returns></returns>
        MModeOfTraffickingEntity GetMModeOfTraffickingEntity(string modeOfTraffickingCode);

        MNAAAlertEventsTemplateEntity GetMNAAAlertEventsTemplateByPK(int alertEventTemplateId);

        /// <summary>
        /// Gets <see cref="MNatureOfAppealEntity "/>
        /// </summary>
        /// <param name="natureOfAppealCode"></param>
        /// <returns></returns>
        MNatureOfAppealEntity GetMNatureOfAppealEntity(string natureOfAppealCode);

        /// <summary>
        /// Gets <see cref="MNatureOfOffenceEntity "/>
        /// </summary>
        /// <param name="natureOfOffenceCode"></param>
        /// <returns></returns>
        MNatureOfOffenceEntity GetMNatureOfOffenceEntity(string natureOfOffenceCode);

        /// <summary>
        /// Gets <see cref="MNOACodeEntity "/>
        /// </summary>
        /// <param name="noaCode"></param>
        /// <returns></returns>
        MNOACodeEntity GetMNOACodeEntity(string noaCode);

        MPartyStatusEntity GetMPartyStatusEntityByPK(string partyStatusCode);

        /// <summary>
        /// Gets <see cref="MPrisonEntity "/>
        /// </summary>
        /// <param name="prisonCode"></param>
        /// <returns></returns>
        MPrisonEntity GetMPrisonEntity(string prisonCode);

        /// <summary>
        /// Gets <see cref="MProvisionEntity "/>
        /// </summary>
        /// <param name="drivingLicenseCode"></param>
        /// <returns></returns>
        MProvisionEntity GetMProvisionEntity(string provisionCode);

        /// <summary>
        /// Get a list of all MScheduleJobLegalInfoEntity.
        /// </summary>
        /// <returns>A list of MScheduleJobLegalInfoEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 30, 2011)</remarks>
        List<MScheduleJobLegalDetailEntity> GetMScheduleJobLegalDetail();

        /// <summary>
        /// Get a list of MScheduleJobLegalDetailEntity by passing the column name and its value.
        /// </summary>
        /// <typeparam name="V">The type for the parameter "value"</typeparam>
        /// <param name="fieldName">The name of the column in database. (Name of property of object).</param>
        /// <param name="value">The value used to filter.</param>
        /// <param name="isGetAll">Boolean to indicate if retrieve all.</param>
        /// <returns>A list of MScheduleJobLegalDetailEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 30, 2011)</remarks>
        List<MScheduleJobLegalDetailEntity> GetMScheduleJobLegalDetail<V>(string fieldName, V value, bool isGetAll);

        /// <summary>
        /// Get a list of all MScheduleJobLegalInfoEntity.
        /// </summary>
        /// <returns>A list of MScheduleJobLegalInfoEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 30, 2011)</remarks>
        List<MScheduleJobLegalInfoEntity> GetMScheduleJobLegalInfo();

        /// <summary>
        /// Get a list of MScheduleJobLegalInfoEntity by passing the column name and its value.
        /// </summary>
        /// <typeparam name="V">The type for the parameter "value"</typeparam>
        /// <param name="fieldName">The name of the column in database. (Name of property of object).</param>
        /// <param name="value">The value used to filter.</param>
        /// <param name="isGetAll">Boolean to indicate if retrieve all.</param>
        /// <returns>A list of MScheduleJobLegalInfoEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 30, 2011)</remarks>
        List<MScheduleJobLegalInfoEntity> GetMScheduleJobLegalInfo<V>(string fieldName, V value, bool isGetAll);

        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldNames"></param>
        /// <param name="opertr"></param>
        /// <returns></returns>
        List<MSectionEntity> GetMSection<V>(string fieldName, V value);

        /// <summary>
        /// Gets <see cref="MSentenceEntity "/>
        /// </summary>
        /// <param name="sentenceCode"></param>
        /// <returns></returns>
        MSentenceEntity GetMSentenceEntity(string sentenceCode);

        /// <summary>
        /// Gets <see cref="MSubProvisionEntity "/>
        /// </summary>
        /// <param name="subProvisionCode"></param>
        /// <returns></returns>
        MSubProvisionEntity GetMSubProvisionEntity(string subProvisionCode);

        /// <summary>
        /// Gets <see cref="MTaskListTypeEntity"/>
        /// </summary>
        /// <param name="taskListTypeCode"></param>
        /// <returns></returns>
        MTaskListTypeEntity GetMTaskListTypeEntity(string taskListTypeCode);

        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldNames"></param>
        /// <param name="opertr"></param>
        /// <returns></returns>
        List<MUserRoleEntity> GetMUserRole<V>(string fieldName, V value);

        /// <summary>
        /// Binds the MOM register grid.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <param name="currentPageNo">The current page no.</param>
        /// <param name="pageRecordsCount">The page records count.</param>
        /// <param name="count">The count.</param>
        /// <returns></returns>
        List<MLegislationActEntity> GetPagedMLegislationAct(int currentPageNo, int pageRecordsCount, out int count);

        /// <summary>
        /// Gets the paged M legislation act entity.
        /// </summary>
        /// <param name="pageNo">The page no.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="totalRecords">The total records.</param>
        /// <returns></returns>
        List<MLegislationActEntity> GetPagedMLegislationActEntity(int pageNo, int pageSize, out int totalRecords);

        /// <summary>
        /// Gets the list of <see cref="RMHRGOutComePartyStatusEntity "/>
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        List<RMHRGOutComePartyStatusEntity> GetRMHRGOutComePartyStatus<V>(string fieldName, V value);

        RMPartyStatusCaseTypeEntity GetRMPartyStatusCaseTypeEntity(string caseTypeCode, string partyStatus);

        /// <summary>
        /// Gets the <see cref="RRoleFunctionsEntity"/>
        /// </summary>
        /// <param name="roleCode"></param>
        /// <param name="functionCode"></param>
        /// <returns></returns>
        RRoleFunctionsEntity GetRRoleFunctions(string roleCode, string functionCode);

        /// <summary>
        /// Gets the <see cref="RUserRoleSectionEntity"/>
        /// </summary>
        /// <param name="sectionCode">The section code.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="roleCode">The role code.</param>
        /// <returns></returns>
        RUserRoleSectionEntity GetRUserRoleSection(string sectionCode, string userId, string roleCode);

        /// <summary>
        /// Saves the or update masterEntity.
        /// </summary>
        /// <param name="masterEntity">The masterEntity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateMasterEntity(IMasterEntity masterEntity, bool isCopy);

        /// <summary>
        /// Updates the master entity.
        /// </summary>
        /// <param name="masterEntity">The master entity.</param>
        void UpdateMasterEntity(IMasterEntity masterEntity);

        /// <summary>
        /// Gets all M hearing type entity.
        /// </summary>
        /// <returns></returns>
        List<MHearingTypeEntity> GetAllMHearingTypeEntity();

        /// <summary>
        /// Gets all MHRG room entity.
        /// </summary>
        /// <returns></returns>
        List<MHRGRoomEntity> GetAllMHRGRoomEntity();

        /// <summary>
        /// Gets all RM case type HRG type MS type entity.
        /// </summary>
        /// <returns></returns>
        List<RMCaseTypeHRGTypeMSTypeEntity> GetAllRMCaseTypeHRGTypeMSTypeEntity();

        /// <summary>
        /// Gets all RM forum coram DSG entity.
        /// </summary>
        /// <returns></returns>
        List<RMForumCoramDSGEntity> GetAllRMForumCoramDSGEntity();

        /// <summary>
        /// Gets all RM hearing type court type entity.
        /// </summary>
        /// <returns></returns>
        List<RMHearingTypeCourtTypeEntity> GetAllRMHearingTypeCourtTypeEntity();

        /// <summary>
        /// Gets all RMHRG type HRG out come HRG out come flag entity.
        /// </summary>
        /// <returns></returns>
        List<RMHRGTypeHRGOutComeHRGOutComeFlagEntity> GetAllRMHRGTypeHRGOutComeHRGOutComeFlagEntity();

        /// <summary>
        /// Gets the RM case type HRG type MS type entity.
        /// </summary>
        /// <param name="courdId">The courd id.</param>
        /// <param name="CaseTypeCode">The case type code.</param>
        /// <param name="HRGTypeCode">The HRG type code.</param>
        /// <param name="MSType">Type of the MS.</param>
        /// <returns></returns>
        RMCaseTypeHRGTypeMSTypeEntity GetRMCaseTypeHRGTypeMSTypeEntity(string courdId
                                                                       , string CaseTypeCode
                                                                        , string HRGTypeCode
                                                                        , string MSType);

        /// <summary>
        /// Gets the RM forum coram DSG entity.
        /// </summary>
        /// <param name="ForumId">The forum id.</param>
        /// <param name="CoramCode">The coram code.</param>
        /// <param name="DSGCode">The DSG code.</param>
        /// <returns></returns>
        RMForumCoramDSGEntity GetRMForumCoramDSGEntity(string ForumId, string CoramCode, string DSGCode);

        /// <summary>
        /// Gets the RM hearing type court type entity.
        /// </summary>
        /// <param name="courtId">The court id.</param>
        /// <param name="hRGTypeCode">The h RG type code.</param>
        /// <returns></returns>
        RMHearingTypeCourtTypeEntity GetRMHearingTypeCourtTypeEntity(string courtId, string hRGTypeCode);

        /// <summary>
        /// Gets the RM doc code HRG type entity.
        /// </summary>
        /// <param name="docCode">The doc code.</param>
        /// <param name="hrgTypeCode">The HRG type code.</param>
        /// <param name="caseTypeCode">The case type code.</param>
        /// <returns></returns>
        RMDocCodeHrgTypeEntity GetRMDocCodeHRGTypeEntity(string docCode, string hrgTypeCode, string caseTypeCode);

        /// <summary>
        /// Gets all MHRG out come flag entity.
        /// </summary>
        /// <returns></returns>
        List<MHRGOutComeFlagEntity> GetAllMHRGOutComeFlagEntity();

        /// <summary>
        /// Gets all MHRG out come reason entity.
        /// </summary>
        /// <returns></returns>
        List<MHRGOutComeReasonEntity> GetAllMHRGOutComeReasonEntity();

        /// <summary>
        /// Gets all MEMS old SCT case prefix entity.
        /// </summary>
        /// <returns></returns>
        List<MEMSOldSCTCasePrefixEntity> GetAllMEMSOldSCTCasePrefixEntity();

        /// <summary>
        /// Gets all RMNOA forum HRG type entity.
        /// </summary>
        /// <returns></returns>
        List<RMNOAForumHrgTypeEntity> GetAllRMNOAForumHrgTypeEntity();

        /// <summary>
        /// Gets the list RM party type case type entity.
        /// </summary>
        /// <param name="caseTypeCode">The case type code.</param>
        /// <returns></returns>
        List<RMPartyTypeCaseTypeEntity> GetListRMPartyTypeCaseTypeEntity(string caseTypeCode);

        /// <summary>
        /// Gets all M doc control entity.
        /// </summary>
        /// <returns></returns>
        List<MDocControlEntity> GetAllMDocControlEntity();

        /// <summary>
        /// Gets all M filing fee entity.
        /// </summary>
        /// <returns></returns>
        List<MFilingFeeEntity> GetAllMFilingFeeEntity();

        /// <summary>
        /// Gets all M filter group entity.
        /// </summary>
        /// <returns></returns>
        List<MFilterGroupEntity> GetAllMFilterGroupEntity();

        /// <summary>
        /// Gets all M summons params entity.
        /// </summary>
        /// <returns></returns>
        List<MSummonsParamEntity> GetAllMSummonsParamsEntity();

        /// <summary>
        /// Gets all M mass call HRG date entity.
        /// </summary>
        /// <returns></returns>
        List<MMassCallHrgDateEntity> GetAllMMassCallHrgDateEntity();


        /// <summary>
        /// Gets all M charge outcome entity.
        /// </summary>
        /// <returns></returns>
        List<MChargeOutcomeEntity> GetAllMChargeOutcomeEntity();

        void DeleteRMHRGTypeHRGSlotEntity(string courtInd, string hrgTypeCode, string hrgSlotCode);

        /// <summary>
        /// Saves the or update law firm entity.
        /// </summary>
        /// <param name="iLawFirmEntity">The i law firm entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateLawFirmEntity(ILawFirmEntity iLawFirmEntity, bool isCopy);

        /// <summary>
        /// Gets the law firm entity by PK.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        ILawFirmEntity GetLawFirmEntityByPK<T>(string primaryKey);

        /// <summary>
        /// Gets all law firm entity.
        /// </summary>
        /// <returns></returns>
        List<LawFirmEntity> GetAllLawFirmEntity();

        /// <summary>
        /// Gets all law firm address entity.
        /// </summary>
        /// <returns></returns>
        List<LawFirmAddressEntity> GetAllLawFirmAddressEntity();

        List<MVSAConfigDetailEntity> GetAllMVSAConfigDetailEntity();

        List<MVSAConfigGroundEntity> GetAllMVSAConfigGroundEntity();

        List<MVSAConfigPrayerEntity> GetAllMVSAConfigPrayerEntity();

        List<MFilingFeeChargingMechanismEntity> GetAllMFilingFeeChargingMechanismEntity();

        List<RUserRoleSectionEntity> GetListRUserRoleSectionByUserId(string userId);

        /// <summary>
        /// Gets all M summons grounds entity.
        /// </summary>
        /// <returns></returns>
        List<MSummonsGroundsEntity> GetAllMSummonsGroundsEntity();

        /// <summary>
        /// Gets all M summons prayers entity.
        /// </summary>
        /// <returns></returns>
        List<MSummonsPrayersEntity> GetAllMSummonsPrayersEntity();

        /// <summary>
        /// Gets all RM section access CTRL entity.
        /// </summary>
        /// <returns></returns>
        List<RMSectionAccessCtrlEntity> GetAllRMSectionAccessCtrlEntity();
        /// <summary>
        /// Gets the M summons grounds entity.
        /// </summary>
        /// <param name="paramId">The param id.</param>
        /// <param name="itemNo">The item no.</param>
        /// <returns></returns>
        MSummonsGroundsEntity GetMSummonsGroundsEntity(string paramId, int itemNo);

        /// <summary>
        /// Gets the M summons prayers entity.
        /// </summary>
        /// <param name="paramId">The param id.</param>
        /// <param name="level">The level.</param>
        /// <param name="subLevel">The sub level.</param>
        /// <returns></returns>
        MSummonsPrayersEntity GetMSummonsPrayersEntity(string paramId, int level, int subLevel);

        /// <summary>
        /// Gets the RM doc filter group entity.
        /// </summary>
        /// <param name="docCode">The doc code.</param>
        /// <param name="filterGroupId">The filter group id.</param>
        /// <returns></returns>
        RMDocFilterGroupEntity GetRMDocFilterGroupEntity(string docCode, string filterGroupId);

        /// <summary>
        /// Gets all RM doc filter group entity.
        /// </summary>
        /// <returns></returns>
        List<RMDocFilterGroupEntity> GetAllRMDocFilterGroupEntity();

        /// <summary>
        /// Saves the or update RM doc filter group entity.
        /// </summary>
        /// <param name="rMDocFilterGroupEntity">The r M doc filter group entity.</param>
        void SaveOrUpdateRMDocFilterGroupEntity(RMDocFilterGroupEntity rMDocFilterGroupEntity);

        /// <summary>
        /// Saves the or update M summons grounds entity.
        /// </summary>
        /// <param name="mSummonsGroundsEntity">The m summons grounds entity.</param>
        void SaveOrUpdateMSummonsGroundsEntity(MSummonsGroundsEntity mSummonsGroundsEntity);

        /// <summary>
        /// Saves the or update M summons prayers entity.
        /// </summary>
        /// <param name="mSummonsPrayersEntity">The m summons prayers entity.</param>
        void SaveOrUpdateMSummonsPrayersEntity(MSummonsPrayersEntity mSummonsPrayersEntity);

        /// <summary>
        /// Saves the or update solicitor address entity.
        /// </summary>
        /// <param name="solicitorAddressEntity">The solicitor address entity.</param>
        void SaveOrUpdateSolicitorAddressEntity(SolicitorAddressEntity solicitorAddressEntity);

        List<MHRGPredefinedDateEntity> GetAllMHRGPredefinedDate();

        List<RMCaseTypeHRGTypeJOLEntity> GetAllRMCaseTypeHRGTypeJOL();

        List<InterfaceLawSocLawFirmEntity> GetAllInterfaceLawSocLawFirm();

        List<InterfaceLawSocLawFirmAddressEntity> GetAllInterfaceLawSocLawFirmAddress();

        List<RMSubCaseTypeHRGTypeMSTypeEntity> GetAllRMSubCaseTypeHRGTypeMSType();

        RMSubCaseTypeHRGTypeMSTypeEntity GetRMSubCaseTypeHRGTypeMSTypeEntity(string forumId,
            string SubCaseTypeCode, string HRGTypeCode, string MSType);

        void SaveOrUpdateRMSubCaseTypeHRGTypeMSType(RMSubCaseTypeHRGTypeMSTypeEntity rMSubCaseTypeHRGTypeMSTypeEntity);


        /// <summary>
        /// Gets all M sensitive filing ACL.
        /// </summary>
        /// <returns></returns>
        List<MSensitiveFilingACLEntity> GetAllMSensitiveFilingACL();

        /// <summary>
        /// Gets the type of all M alert event.
        /// </summary>
        /// <returns></returns>
        List<MAlertEventTypeEntity> GetAllMAlertEventType();

        /// <summary>
        /// Gets all RM alert event type role.
        /// </summary>
        /// <returns></returns>
        List<RMAlertEventTypeRoleEntity> GetAllRMAlertEventTypeRole();

        /// <summary>
        /// Gets all R alert event subscribers.
        /// </summary>
        /// <returns></returns>
        List<RAlertEventSubscribersEntity> GetAllRAlertEventSubscribers();
        /// <summary>
        /// Gets all M business job legal info.
        /// </summary>
        /// <returns></returns>
        List<MBusinessJobLegalInfoEntity> GetAllMBusinessJobLegalInfo();
        /// <summary>
        /// Gets all M business job legal detail.
        /// </summary>
        /// <returns></returns>
        List<MBusinessJobLegalDetailEntity> GetAllMBusinessJobLegalDetail();

        List<MEMSParamEntity> GetAllMEMSParam();

        List<RMHearingRoutingSectionConfigEntity> GetAllRMHearingRoutingSectionConfig();

        List<MPaperMinuteSheetTypeEntity> GetAllMPaperMinuteSheetType();

        List<RAlertEventSubscribersEntity> GetListRAlertEventSubscribersByAlertEventType(string alertEventTypeCode);

        List<MFilingFeeTypeEntity> GetAllMFilingFeeType();


        List<MFilingFeeChargingMechanismEntity> GetListMFilingFeeChargingMechanism(string feeRuleCode);


        List<MFilingFeeLegislationActEntity> GetAllMFilingFeeLegislationAct();

        void SaveOrUpdateRRoleFunctionEntity(RRoleFunctionsEntity rRoleFunctionsEntity);

        List<MCourtVacationEntity> GetAllMCourtVacation();
        /// <summary>
        /// Returns the forums tied to <paramref name="courtId"/>
        /// This is used as a replacement method where CourtId is fetched from Sysparameter table 
        /// which fails to get FJ Forums
        /// If HC returns all HC Forums
        /// If SU it returns both SU and FJ
        /// </summary>
        /// <param name="courtId"></param>
        /// <returns>List<MForumTypeEntity></returns>
        List<MForumTypeEntity> GetAllMForumTypeForSystemAdmin(string courtId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rmRoutingSectionConfigEntity"></param>
        void DeleteRMRoutingSectionConfig(RMRoutingSectionConfigEntity rmRoutingSectionConfigEntity);

        void DeleteRMNOAForumHrgType(RMNOAForumHrgTypeEntity rMNOAForumHrgTypeEntity);
        
        List<MEMSRecTransModeEntity> GetAllMEMSRecTransModeEntity();

        List<MEMSAdvertiserEntity> GetAllMEMSAdvertiserEntity();

        List<MEMSAppraiserEntity> GetAllMEMSAppraiserEntity();

        List<MEMSAuctioneerEntity> GetAllMEMSAuctioneerEntity();

        List<MEMSSalesAgentEntity> GetAllMEMSSalesAgentEntity();

        List<MAASDisciplinaryTypeEntity> GetAllMAASDisciplinaryTypeEntity();

        List<MAASDisciplinaryResultTypeEntity> GetAllMAASDisciplinaryResultTypeEntity();

        List<MAASUniversityEntity> GetAllMAASUniversityEntity();

        List<RMHrgSlotNOCEntity> GetAllRMHrgSlotNOCEntity();

        void SaveOrUpdateRMRoutingSectionConfigEntity(RMRoutingSectionConfigEntity rmRoutingSectionConfigEntity, bool isCopy);

        List<MDefaultLoginPageEntity> GetAllMDefaultLoginPageEntity();

        List<RMHrgSlotLegisEntity> GetAllRMHrgSlotLegisEntity();

        void DeleteRMHrgSlotNOC(RMHrgSlotNOCEntity rMHrgSlotNOCEntity);

        List<RMHrgSlotNOCEntity> GetListRMHrgSlotNOCEntityByForumID(string forumID);

        List<RMDocControlExclusionEntity> GetListRMDocControlExclusionByDocCode(string DocCode);

        List<RMDocControlExclusionEntity> GetAllRMDocControlExclusion();

        List<MResidentialEntity> GetAllMResidential();

        List<MIncomeEntity> GetAllMIncome();

        List<MDirectionsEntity> GetAllMDirections();

        List<MHarassPlaceEntity> GetAllMHarassPlace();

        List<RMHrgSlotLegisEntity> GetListRMHrgSlotLegisEntityByForumID(string forumID);

        #endregion Methods
    }
}