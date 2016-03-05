namespace AllInOne.Legal.Mediator.BackEnd
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Enforcement;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LAP;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.MRelationship;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Domain.Subsequent;

    /// <summary>
    /// 
    /// </summary>
    public interface IWorkflowEngineMediator : IMediator
    {
        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that 
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
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
        /// Commits the transaction.
        /// </summary>
        void CommitTransaction();

        /// <summary>
        /// Rollback the database transaction and close the session.
        /// </summary>
        void RollbackTransaction();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<RUserPAEntity> GetRUserPAEntityByUserId(string userId);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        List<AASInfoEntity> GetAASInfo<V>(string fieldName, V value);

        /// <summary>
        /// Gets the <see cref="sGID"/> and returns the BankruptcyInfoEntity.
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>Returns <see cref="BankruptcyInfoEntity"/> if found else null.</returns>
        BankruptcyInfoEntity GetBankruptcyInfoBySGID(string sGID);

        /// <summary>
        /// Gets the <see cref="CaseInfoId"/> and returns the CaseInfoEntity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns>Returns <see cref="CaseInfoEntity"/> if found else null.</returns>
        CaseInfoEntity GetCaseInfoEntity(string caseInfoId);

        /// <summary>
        /// Gets the CasePartyLACDetailEntity <see cref="CasePartyLACDetailEntity"/>
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        /// <returns> CasePartyLACDetailEntity </returns>        
        CasePartyLACDetailEntity GetCasePartyLACDetailByCasePartyId(string casePartyId);

        /// <summary>
        /// Gets the DCACA info entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        DCACAInfoEntity GetDCACAInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="DivorceInfoEntity "/>
        /// </summary>
        /// <param name="submissionGroupId">The SubmissionGroupId.</param>
        /// <returns></returns>
        DivorceInfoEntity GetDivorceInfoEntity(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="RefSubCaseEntity "/>
        /// </summary>
        /// <param name="submissionGroupId">The SubmissionGroupId.</param>
        /// <returns></returns>
        List<RefSubCaseEntity> GetRefSubCaseBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="DivorceInfoEntity "/>
        /// </summary>
        /// <param name="submissionGroupId">The SubmissionGroupId.</param>
        /// <returns></returns>
        List<OriginatingCaseEntity> GetListOriginatingCaseBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="DocCasePartyId"/>and returns <see cref="DocCasePartyEntity"/>
        /// </summary>
        /// <param name="DocCasePartyId">The case party id.</param>
        /// <returns></returns>
        DocCasePartyEntity GetDocCasePartyByPK(string primaryKey);

        /// <summary>
        /// Gets the DocCasePartyLACDetailEntity <see cref="DocCasePartyLACDetailEntity"/>
        /// </summary>
        /// <param name="dcpId">The dcpId.</param>
        /// <returns> DocCasePartyLACDetailEntity </returns>
        DocCasePartyLACDetailEntity GetDocCasePartyLACDetailByDCPId(string dcpId);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        List<DocCaseSolicitorEntity> GetDocCaseSolicitor<V>(string fieldName, V value);

        /// Gets the <see cref="docId"/>and returns <see cref="List<DocumentInfoEntity>"/>
        /// </summary>
        /// <param name="docId">The document Id.</param>
        /// <returns></returns>
        DocumentInfoEntity GetDocumentInfoByPK(string docId);

        /// <summary>
        /// Gets the hearing by pk.
        /// </summary>
        /// <param name="hrgId">The HRG id.</param>
        /// <returns></returns>
        HearingEntity GetHearingByPk(long hrgId);

        /// <summary>
        /// Gets the judicial user entity by PK.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        JudicialUserEntity GetJudicialUserEntityByPK(string userId);

        /// <summary>
        /// Gets the LACInfoEntity <see cref="CasePartyLACDetailEntity"/>
        /// </summary>
        /// <param name="lacInfoId">The lacInfoId.</param>
        /// <returns> LACInfoEntity </returns>   
        LACInfoEntity GetLACInfoByLACInfoId(string lacInfoId);

        /// <summary>
        /// Gets the list<see cref="CasePartyEntity "/>
        /// </summary>
        /// <param name="caseInfoId">The caseInfoId.</param>
        /// <returns></returns>
        List<CasePartyEntity> GetListCasePartyByCaseInfoID(string caseInfoId);

        /// <summary>
        /// Gets the list checklist submission entity by doc id.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<ChecklistSubmissionEntity> GetListChecklistSubmissionEntityByDocId(string docId);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        List<DCADetailEntity> GetListDCADetail<V>(string fieldName, V value);

        /// <summary>
        /// Gets the list document info by sub case info id.
        /// </summary>
        /// <param name="SubCaseInfoId">The sub case info id.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentInfoBySubCaseInfoId(string SubCaseInfoId);

        /// <summary>
        /// Gets the list document info by submission id.
        /// </summary>
        /// <param name="submissionId">The submission id.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentInfoBySubmissionId(string submissionId);

        /// <summary>
        /// Gets the list of <see cref="DocumentInfoEntity"/>
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentInfoEntityByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list document info entity by doc code.
        /// </summary>
        /// <param name="docCode">The doc code.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentInfoEntityByDocCode(string docCode);

        /// <summary>
        /// Gets the list document info entity by HRG id.
        /// </summary>
        /// <param name="hrgId">The HRG id.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentInfoEntityByHrgId(long hrgId);

        /// <summary>
        /// Gets the list document info entity by related doc id.
        /// </summary>
        /// <param name="relatedDocId">The related doc id.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentInfoEntityByRelatedDocId(string relatedDocId);

        /// <summary>
        /// Gets the list EMS team MGMT entity by assigned district.
        /// </summary>
        /// <param name="assignedDistrict">The assigned district.</param>
        /// <returns></returns>
        List<EMSTeamMgmtEntity> GetListEMSTeamMgmtEntityByAssignedDistrict(Int32 assignedDistrict);

        /// <summary>
        ///Gets the <see cref="HearingEntity"/>
        /// </summary>
        /// <param name="caseInfoId">The caseInfoId</param>
        /// <returns></returns>
        List<HearingEntity> GetListHearingByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list of <see cref="JudicialUserEntity"/>
        /// </summary>
        /// <param name="userName">The userName.</param>
        /// <returns></returns>
        /// 
        List<JudicialUserEntity> GetListJudicialUserByUserName(string userName);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        List<LegislationProvisionsEntity> GetListLegislationProvision<V>(string fieldName, V value);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        List<MinuteSheetInfoEntity> GetListMinuteSheetInfo<V>(string fieldName, V value);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        List<NatureOfCaseEntity> GetListNatureOfCase<V>(string fieldName, V value);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        List<RARASDetailEntity> GetListRARASDetail<V>(string fieldName, V value);

        /// <summary>
        /// Gets the List<see cref="RCaseSubmissionEntity "/>
        /// </summary>
        /// <param name="caseInfoId">The CaseInfoId</param>
        /// <returns></returns>
        List<RCaseSubmissionEntity> GetListRCaseSubmission(string caseInfoId);

        /// <summary>
        /// Gets the list R doc case entity by doc id.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<RDocCaseEntity> GetListRDocCaseEntityByDocId(string docId);

        /// Gets the <see cref="docId"/>and returns <see cref="List<RDocCasePartyEntity>"/>
        /// </summary>
        /// <param name="docId">The document Id.</param>
        /// <returns></returns>
        List<RDocCasePartyEntity> GetListRDocCasePartyByDocId(string docId);

        /// <summary>
        /// Gets the list ref order details by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<RefOrderDetailEntity> GetListRefOrderDetailsBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list WOE execution address entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<WOEExecutionAddressEntity> GetListWOEExecutionAddressEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list WOE info entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<WOEInfoEntity> GetListWOEInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="CaseTypeCode"/> and returns the MCaseTypeEntity.
        /// </summary>
        /// <param name="caseTypeCode">The case type code</param>
        /// <returns></returns>
        MCaseTypeEntity GetMCaseTypeEntity(string caseTypeCode);

        /// <summary>
        /// Gets the MEMS writ appt.
        /// </summary>
        /// <returns></returns>
        List<MEMSWritApptEntity> GetMEMSWritAppt();

        /// <summary>
        /// Gets the <see cref="ForumId"/> and returns the MForumTypeEntity.
        /// </summary>
        /// <param name="forumId">The forum Id</param>
        /// <returns></returns>
        MForumTypeEntity GetMForumTypeEntity(string forumId);

        /// <summary>
        /// Gets the <see cref="SectionCode"/> and returns the MSectionEntity.
        /// </summary>
        /// <param name="sectionCode">The section code</param>
        /// <returns></returns>
        MSectionEntity GetMSectionEntity(string sectionCode);

        /// <summary>
        /// Gets the <see cref="RoleCode"/> and returns the MUserRoleEntity.
        /// </summary>
        /// <param name="roleCode">The role code</param>
        /// <returns></returns>
        MUserRoleEntity GetMUserRoleEntity(string roleCode);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        List<NatureOfApplicationEntity> GetNatureOfApplication<V>(string fieldName, V value);

        /// <summary>
        /// Gets the OS info entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        OSInfoEntity GetOSInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the probate info entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ProbateInfoEntity GetProbateInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the RARA sinfo entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        RARASInfoEntity GetRARASinfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Get RASInfoEntity by Group Id
        /// </summary>
        /// <param name="submissionGroupId"></param>
        /// <returns></returns>
        RASInfoEntity GetRASInfoByGroupId(string groupId);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        List<RCaseSubmissionEntity> GetRCaseSubmission<V>(string fieldName, V value);

        /// <summary>
        /// Gets the RMCDR auto fix time line.
        /// </summary>
        /// <param name="CaseTypeCode">The case type code.</param>
        /// <param name="DocCode">The doc code.</param>
        /// <returns></returns>
        List<RMCDRAutoFixTimeLineEntity> GetRMCDRAutoFixTimeLine(string CaseTypeCode, string DocCode);

        /// <summary>
        ///Gets the <see cref="ForumId"/> and returns the RMRoutingSectionConfigEntity list.
        /// </summary>
        /// <param name="forumId">The forum Id</param>
        /// <returns></returns>
        List<RMRoutingSectionConfigEntity> GetRoutingSectionConfig(string forumId);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        List<RSubCaseSubmissionEntity> GetRSubCaseSubmission<V>(string fieldName, V value);

        /// <summary>
        /// Gets the sub case info entity by pk.
        /// </summary>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <returns></returns>
        SubCaseInfoEntity GetSubCaseInfoEntityByPk(string subCaseInfoId);

        TaskListEntity GetTaskListEntityByDocId(string docId);

        /// <summary>
        /// Gets the WOS info entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        WOSInfoEntity GetWOSInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Saves the or update back end specific entity.
        /// </summary>
        /// <param name="backEndSpecificEntity">The back end specific entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateBackEndSpecificEntity(IBackEndSpecificEntity backEndSpecificEntity, bool isCopy);

        /// <summary>
        /// Saves the or update case entity.
        /// </summary>
        /// <param name="caseEntity">The case entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateCaseEntity(ICaseEntity caseEntity, bool isCopy);

        /// <summary>
        /// Save or update <see cref="CaseInfoEntity"/>.
        /// </summary>
        /// <param name="caseInfoEntity">The case info entity</param>
        /// <returns></returns>
        void SaveOrUpdateCaseInfoEntity(CaseInfoEntity caseInfoEntity);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="IDocumentEntity"/> interface.
        /// </summary>
        /// <param name="iDocumentEntity"><see cref="IDocumentEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateDocumentEntity(IDocumentEntity iDocumentEntity, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubCaseEntity"/> interface.
        /// </summary>
        /// <param name="iSubCaseEntity"><see cref="ISubCaseEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateSubCaseEntity(ISubCaseEntity iSubCaseEntity, bool isCopy);

        /// <summary>
        /// Gets the list<see cref="RMUserPSEntity"/>
        /// </summary>
        /// <param name="JOUserId">The JOUserId.</param>
        /// <returns></returns>
        List<RMUserPSEntity> GetListRMUserPSByJOUserId(string JOUserId);

        /// <summary>
        /// Gets the list originating case by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<OriginatingCaseEntity> GetListOriginatingCaseByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the law firm entity by PK.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        ILawFirmEntity GetLawFirmEntityByPK<T>(string primaryKey);

        /// <summary>
        /// Gets the list sub case party by sub case info id.
        /// </summary>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <returns></returns>
        List<SubCasePartyEntity> GetListSubCasePartyBySubCaseInfoId(string subCaseInfoId);

        DCACAOriginatingCasePartyInfoEntity GetDCACAOriginatingCasePartyInfoEntity(string dcpId);


        List<LABSection17CertInfoEntity> GetListLABSection17CertInfoByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Saves the or update law firm entity.
        /// </summary>
        /// <param name="iLawFirmEntity">The i law firm entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateLawFirmEntity(ILawFirmEntity iLawFirmEntity, bool isCopy);

        /// <summary>
        /// Gets SolicitorId From MSequenceKey.
        /// </summary>
        /// <returns></returns>
        long GetSolicitorIdFromMSequenceKey();

        /// <summary>
        /// Increments SolicitorId By 1.
        /// </summary>
        void UpdateMSequenceKeySolicitorId();

        /// <summary>
        /// Saves the or update solicitor address entity.
        /// </summary>
        /// <param name="solicitorAddressEntity">The solicitor address entity.</param>
        void SaveOrUpdateSolicitorAddressEntity(SolicitorAddressEntity solicitorAddressEntity);

        /// <summary>
        /// Gets the <see cref="dCPID"/>and returns <see cref="List<DocCasePartyAddressEntity>"/>
        /// </summary>
        /// <param name="dCPID">The document case party Id.</param>
        /// <returns></returns>
        List<DocCasePartyAddressEntity> GetListDocCasePartyAddress(string dCPID);

        List<SolicitorEntity> GetListSolicitorByCaseInfoId(string caseInfoId);

        List<SolicitorAddressEntity> GetListSolicitorAddressBySolicitorId(long solicitorId);

        /// <summary>
        /// Gets the list OGC incoming queue entity by related doc id.
        /// </summary>
        /// <param name="relatedDocId">The related doc id.</param>
        /// <returns></returns>
        List<OGCIncomingQueueEntity> GetListOGCIncomingQueueByRelatedDocId(string relatedDocId);

        SystemParametersEntity GetSystemParametersEntity(string configKey);

        List<RequestHearingAdminSupportEntity> GetListRequestHearingAdminSupportEntityBySGID(string submissionGroupId);

        PCInfoEntity GetPCInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes the document info entity.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        void DeleteDocumentInfoEntity(string docId);

        /// <summary>
        /// Gets the AreaOfLegalPracticeEntitySGID entity by related SGID.
        /// </summary>
        /// <param name="submissionGroupId"></param>
        /// <returns></returns>
        List<AreaOfLegalPracticeEntity> GetaAreaOfLegalPracticeEntitySGID(string submissionGroupId);

        /// <summary>
        /// Saves the or update Area Of Legal Practice entity.
        /// </summary>
        /// <param name="areaOfLegalPracticeEntity"></param>
        void SaveOrUpdateAreaOfLegalPracticeEntity(AreaOfLegalPracticeEntity areaOfLegalPracticeEntity);

        #endregion Methods
    }
}