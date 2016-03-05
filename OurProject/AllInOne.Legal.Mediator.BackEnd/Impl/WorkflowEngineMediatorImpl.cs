namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;
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
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Data;

    using log4net;

    public class WorkflowEngineMediatorImpl : IWorkflowEngineMediator
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WorkflowEngineMediatorImpl));

        /// <summary>
        /// ApplicationSessionManager instance for session.
        /// </summary>
        private ApplicationSessionManager applicationSessionManager = new ApplicationSessionManager();

        #endregion Fields

        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that 
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        /// <param name="sender"></param>
        public void BeginTransaction()
        {
            Logger.Info("WorkflowEngineMediatorImpl - BeginTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager.BeginTransaction();

            Logger.Info("WorkflowEngineMediatorImpl - BeginTransaction ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Close the session.
        /// </summary>
        public void CloseSession()
        {
            Logger.Info("WorkflowEngineMediatorImpl - CloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CloseSession();

            Logger.Info("WorkflowEngineMediatorImpl - CloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        public void CommitAndCloseSession()
        {
            Logger.Info("WorkflowEngineMediatorImpl - CommitAndCloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CommitAndCloseSession();

            Logger.Info("WorkflowEngineMediatorImpl - CommitAndCloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Commit the database transaction.
        /// </summary>
        public void CommitTransaction()
        {
            Logger.Info("WorkflowEngineMediatorImpl - CommitTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CommitTransaction();

            Logger.Info("WorkflowEngineMediatorImpl - CommitTransaction ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Rollback the database transaction and close the session.
        /// </summary>
        public void RollbackTransaction()
        {
            Logger.Info("WorkflowEngineMediatorImpl - RollbackTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager.RollBackTransaction();

            Logger.Info("WorkflowEngineMediatorImpl - RollbackTransaction ended at " + DateTime.Now.ToString());
        }

        public List<AASInfoEntity> GetAASInfo<V>(string fieldName, V value)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetAASInfo(fieldName, value);
        }

        public BankruptcyInfoEntity GetBankruptcyInfoBySGID(string sGID)
        {
            BankruptcyGateway bankruptcyGateway = new BankruptcyGateway();
            return bankruptcyGateway.GetBankruptcyInfoBySGID(sGID);
        }

        /// <summary>
        /// Gets the <see cref="caseInfoId"/>
        /// </summary>
        /// <param name="caseInfoId">Gets the CaseInfoId and Returns CaseInfo</param>
        /// <returns>Returns the CaseInfo if found Else Null</returns>
        public CaseInfoEntity GetCaseInfoEntity(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCaseInfoByPK(caseInfoId);
        }

        public CasePartyLACDetailEntity GetCasePartyLACDetailByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyLACDetail(casePartyId);
        }

        public DCACAInfoEntity GetDCACAInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetDCACAInfoEntityBySGID(submissionGroupId);
        }

        public DivorceInfoEntity GetDivorceInfoEntity(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetDivorceInfoEntityBySGID(submissionGroupId);
        }

        public List<RefSubCaseEntity> GetRefSubCaseBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetRefSubCaseBySGID(submissionGroupId);
        }

        public List<OriginatingCaseEntity> GetListOriginatingCaseBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetOriginatingCaseEntityBySGID(submissionGroupId);
        }

        public DocCasePartyEntity GetDocCasePartyByPK(string dCPID)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCaseParty(dCPID);
        }

        public DocCasePartyLACDetailEntity GetDocCasePartyLACDetailByDCPId(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCasePartyLACDetail(dcpId);
        }

        public List<DocCaseSolicitorEntity> GetDocCaseSolicitor<V>(string fieldName, V value)
        {
            DocumentGateway gateway = new DocumentGateway();
            return gateway.GetDocCaseSolicitor(fieldName, value);
        }

        public DocumentInfoEntity GetDocumentInfoByPK(string docId)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoByPK(docId);
        }

        public HearingEntity GetHearingByPk(long hrgId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetHearingByPK(hrgId.ToString()); //TODO: NEed to Change the dataType in GetHearingByPk for HrgId.
        }

        public JudicialUserEntity GetJudicialUserEntityByPK(string userId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetJudicialUserEntityByPK(userId);
        }

        public LACInfoEntity GetLACInfoByLACInfoId(string lacInfoId)
        {
            LAPGateway lapGateway = new LAPGateway();
            return lapGateway.GetLACInfoByPK(lacInfoId);
        }

        public List<RUserPAEntity> GetRUserPAEntityByUserId(string userId)
        {
            BackEndSpecificGateway gateway = new BackEndSpecificGateway();
            return gateway.GetRUserPAEntityByUserId(userId);
        }

        /// <summary>
        /// Gets the list<see cref="CasePartyEntity "/>
        /// </summary>
        /// <param name="caseInfoId">The caseInfoId.</param>
        /// <returns></returns>
        public List<CasePartyEntity> GetListCasePartyByCaseInfoID(string caseInfoId)
        {
            CaseGateway casegateway = new CaseGateway();
            return casegateway.GetCasePartyByCaseInfoId(caseInfoId);
        }

        public List<ChecklistSubmissionEntity> GetListChecklistSubmissionEntityByDocId(string docId)
        {
            var commonGateway = new CommonGateway();
            return commonGateway.GetListChecklistSubmissionEntityByDocId(docId);
        }

        public List<DCADetailEntity> GetListDCADetail<V>(string fieldName, V value)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListDCADetail(fieldName, value);
        }

        public List<DocumentInfoEntity> GetListDocumentInfoBySubCaseInfoId(string SubCaseInfoId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoBySubCaseInfoId(SubCaseInfoId);
        }

        public List<DocumentInfoEntity> GetListDocumentInfoBySubmissionId(string submissionId)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoBySubmissinId(submissionId);
        }

        public List<DocumentInfoEntity> GetListDocumentInfoEntityByCaseInfoId(string caseInfoId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoByCaseInfoId(caseInfoId);
        }

        public List<DocumentInfoEntity> GetListDocumentInfoEntityByDocCode(string docCode)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoByDocCode(docCode);
        }

        public List<DocumentInfoEntity> GetListDocumentInfoEntityByHrgId(long hrgId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoByHrgId(hrgId);
        }

        /// <summary>
        /// Gets the list document info entity by related doc id.
        /// </summary>
        /// <param name="relatedDocId">The related doc id.</param>
        /// <returns></returns>
        public List<DocumentInfoEntity> GetListDocumentInfoEntityByRelatedDocId(string relatedDocId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoByRelatedDocId(relatedDocId);
        }

        public List<EMSTeamMgmtEntity> GetListEMSTeamMgmtEntityByAssignedDistrict(Int32 assignedDistrict)
        {
            EnforcementGateway enforcementGateway = new EnforcementGateway();
            List<EMSTeamMgmt> listEMSTeamMgmt = enforcementGateway.GetEntity<EMSTeamMgmt, Int32>("AssignedDistrict", assignedDistrict, true);

            if (listEMSTeamMgmt.HasContent())
            {
                return listEMSTeamMgmt.Select(eMSTeamMgmt =>
                    AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.EnforcementMapperToDTO.GetEMSTeamMgmtEntity(eMSTeamMgmt)).ToList();
            }
            else
            { return null; }
        }

        public List<HearingEntity> GetListHearingByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListHearingByCaseInfoId(caseInfoId);
        }

        public List<JudicialUserEntity> GetListJudicialUserByUserName(string userName)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListJudicialUserEntityByUserName(userName);
        }

        public List<LegislationProvisionsEntity> GetListLegislationProvision<V>(string fieldName, V value)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListLegislationProvision(fieldName, value);
        }

        public List<MinuteSheetInfoEntity> GetListMinuteSheetInfo<V>(string fieldName, V value)
        {
            CommonGateway gateWay = new CommonGateway();
            return gateWay.GetListMinuteSheetInfo(fieldName, value);
        }

        public List<NatureOfCaseEntity> GetListNatureOfCase<V>(string fieldName, V value)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListNatureOfCase(fieldName, value);
        }

        public List<RARASDetailEntity> GetListRARASDetail<V>(string fieldName, V value)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListRARASDetail(fieldName, value);
        }

        public List<RCaseSubmissionEntity> GetListRCaseSubmission(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListRCaseSubmissionEntityByCaseInfoId(caseInfoId);
        }

        public List<RDocCaseEntity> GetListRDocCaseEntityByDocId(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListRDocCaseByDocId(docId);
        }

        public List<RDocCasePartyEntity> GetListRDocCasePartyByDocId(string docId)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListRDocCasePartyByDocId(docId);
        }

        public List<RefOrderDetailEntity> GetListRefOrderDetailsBySGID(string submissionGroupId)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);
        }

        public List<WOEExecutionAddressEntity> GetListWOEExecutionAddressEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListWOEExecutionAddressBySGID(submissionGroupId);
        }

        public List<WOEInfoEntity> GetListWOEInfoEntityBySGID(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListWOEInfoEntityBySGID(submissionGroupId);
        }

        public MCaseTypeEntity GetMCaseTypeEntity(string caseTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMCaseType(caseTypeCode);
        }

        public List<MEMSWritApptEntity> GetMEMSWritAppt()
        {
            EnforcementGateway enforcementGateway = new EnforcementGateway();
            List<MEMSWritAppt> listMEMSWritAppt = enforcementGateway.GetEntity<MEMSWritAppt>();

            if (listMEMSWritAppt.HasContent())
            {
                return listMEMSWritAppt.Select(mEMSWritAppt =>
                    AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMEMSWritApptDomain(mEMSWritAppt)).ToList();
            }
            else
            { return null; }
        }

        public MForumTypeEntity GetMForumTypeEntity(string forumId)
        {
            throw new NotImplementedException();
        }

        public MSectionEntity GetMSectionEntity(string sectionCode)
        {
            throw new NotImplementedException();
        }

        public MUserRoleEntity GetMUserRoleEntity(string roleCode)
        {
            throw new NotImplementedException();
        }

        public List<NatureOfApplicationEntity> GetNatureOfApplication<V>(string fieldName, V value)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetNatureOfApplication(fieldName, value);
        }

        public OSInfoEntity GetOSInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetOSInfoEntityBySGID(submissionGroupId);
        }

        public ProbateInfoEntity GetProbateInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetProbateInfoEntityBySGID(submissionGroupId);
        }

        public RARASInfoEntity GetRARASinfoEntityBySGID(string submissionGroupId)
        {
            AppealsGateway gateway = new AppealsGateway();
            return gateway.GetRARASInfoEntityBySGID(submissionGroupId);
        }

        public RASInfoEntity GetRASInfoByGroupId(string groupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetRASInfoEntityBySGID(groupId);
        }

        public List<RCaseSubmissionEntity> GetRCaseSubmission<V>(string fieldName, V value)
        {
            CaseGateway gateway = new CaseGateway();
            return gateway.GetRCaseSubmission(fieldName, value);
        }

        public List<RMCDRAutoFixTimeLineEntity> GetRMCDRAutoFixTimeLine(string caseTypeCode, string docCode)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetRMCDRAutoFixTimeLine(caseTypeCode, docCode);
        }

        public List<RMRoutingSectionConfigEntity> GetRoutingSectionConfig(string forumId)
        {
            throw new NotImplementedException();
        }

        public List<RSubCaseSubmissionEntity> GetRSubCaseSubmission<V>(string fieldName, V value)
        {
            SubCaseGateway gateway = new SubCaseGateway();
            return gateway.GetRSubCaseSubmission(fieldName, value);
        }

        public SubCaseInfoEntity GetSubCaseInfoEntityByPk(string subCaseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetSubCaseInfoEntityBySubCaseInfoId(Convert.ToInt64(subCaseInfoId));
        }

        public TaskListEntity GetTaskListEntityByDocId(string docId)
        {
            try
            {
                BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
                return backEndSpecificGateway.GetTaskListEntityByDocId(docId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at  GetTaskListEntityByDocId", ex);
                throw;
            }
        }

        public WOSInfoEntity GetWOSInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetWOSInfoEntityBySGID(submissionGroupId);
        }

        public void SaveOrUpdateBackEndSpecificEntity(IBackEndSpecificEntity backEndSpecificEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<IBackEndSpecific>(BackEndSpecificMapper.GetBackEndSpecificEntity<IBackEndSpecificEntity>(backEndSpecificEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateBackEndSpecificEntity", ex);
                Logger.Error("Error in SaveOrUpdateBackEndSpecificEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public void SaveOrUpdateCaseEntity(ICaseEntity caseEntity, bool isCopy)
        {
            CaseGateway caseGateway = new CaseGateway();
            if (isCopy)
                caseGateway.SaveOrUpdateInMemoryEntity<ICase>(CaseMapper.GetCaseEntity<ICaseEntity>(caseEntity));
            else
                caseGateway.SaveOrUpdateEntity<ICase>(CaseMapper.GetCaseEntity<ICaseEntity>(caseEntity));
        }

        public void SaveOrUpdateCaseInfoEntity(CaseInfoEntity caseInfoEntity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdateDocumentEntity(IDocumentEntity iDocumentEntity, bool isCopy)
        {
            DocumentGateway documentGateway = new DocumentGateway();

            if (iDocumentEntity.GetType().Equals(typeof(DocumentInfoEntity)))
            {
                documentGateway.SaveOrUpdateDocumentInfoSP(iDocumentEntity as DocumentInfoEntity);

            }
            else if (isCopy)
                documentGateway.SaveOrUpdateInMemoryEntity<IDocument>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocumentEntity<IDocumentEntity>(iDocumentEntity));
            else
                documentGateway.SaveOrUpdateEntity<IDocument>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocumentEntity<IDocumentEntity>(iDocumentEntity));
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubCaseEntity"/> interface.
        /// </summary>
        /// <param name="iSubCaseEntity"><see cref="ISubCaseEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateSubCaseEntity(ISubCaseEntity iSubCaseEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<ISubCase>(SubCaseMapper.GetSubCase<ISubCaseEntity>(iSubCaseEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateSubCaseEntity", ex);
                Logger.Error("Error in SaveOrUpdateSubCaseEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<RMUserPSEntity> GetListRMUserPSByJOUserId(string JOUserId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetRMUserPSEntity(JOUserId);
        }

        public List<OriginatingCaseEntity> GetListOriginatingCaseByCaseInfoId(string caseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListOriginatingCaseEntityByCaseInfoId(caseInfoId);
        }

        public ILawFirmEntity GetLawFirmEntityByPK<T>(string primaryKey)
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            return lawFirmGateway.GetLawFirmEntityByPK<T>(primaryKey);
        }

        public List<SubCasePartyEntity> GetListSubCasePartyBySubCaseInfoId(string subCaseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetSubCasePartyEntityEntityBySubCaseInfoId(Convert.ToInt64(subCaseInfoId));
        }

        public DCACAOriginatingCasePartyInfoEntity GetDCACAOriginatingCasePartyInfoEntity(string dcpId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetDCACAOriginatingCasePartyInfo(dcpId);
        }


        public List<LABSection17CertInfoEntity> GetListLABSection17CertInfoByCaseInfoId(string caseInfoId)
        {
            LAPGateway lAPGateway = new LAPGateway();
            return lAPGateway.GetListLABSection17CertInfoByCaseInfoId(caseInfoId);
        }

        public void SaveOrUpdateLawFirmEntity(ILawFirmEntity iLawFirmEntity, bool isCopy)
        {
            GenericGateway genericGateway = new GenericGateway();
            genericGateway.SaveOrUpdateEntity<ILawFirm>(LawFirmMapper.GetLawFirmEntity<ILawFirmEntity>(iLawFirmEntity), isCopy);
        }

        public long GetSolicitorIdFromMSequenceKey()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetSolicitorIdFromMSequenceKey();
        }

        public void UpdateMSequenceKeySolicitorId()
        {
            MasterGateway masterGateway = new MasterGateway();
            masterGateway.UpdateMSequenceKeySolicitorId();
        }

        public void SaveOrUpdateSolicitorAddressEntity(SolicitorAddressEntity solicitorAddressEntity)
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            lawFirmGateway.SaveOrUpdateSolicitorAddress(solicitorAddressEntity);
        }

        public List<DocCasePartyAddressEntity> GetListDocCasePartyAddress(string dCPID)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyAddressByDCPID(dCPID);
        }

        public List<SolicitorEntity> GetListSolicitorByCaseInfoId(string caseInfoId)
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            return lawFirmGateway.GetListSolicitorByCaseInfoId(caseInfoId);
        }

        public List<SolicitorAddressEntity> GetListSolicitorAddressBySolicitorId(long solicitorId)
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            return lawFirmGateway.GetListSolicitorAddressBySolicitorId(solicitorId);
        }

        public List<OGCIncomingQueueEntity> GetListOGCIncomingQueueByRelatedDocId(string relatedDocId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListOGCIncomingQueueByRelatedDocId(relatedDocId);
        }
        public SystemParametersEntity GetSystemParametersEntity(string configKey)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetSystemParameterEntity(configKey);
        }

        public List<RequestHearingAdminSupportEntity> GetListRequestHearingAdminSupportEntityBySGID(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListRequestHearingAdminSupport(submissionGroupId);
        }

        public PCInfoEntity GetPCInfoEntityBySGID(string submissionGroupId)
        {
            SubCaseSpecificGateway subCaseSpecificGateway = new SubCaseSpecificGateway();
            return subCaseSpecificGateway.GetPCInfoEntityBySGID(submissionGroupId);
        }

        public void DeleteDocumentInfoEntity(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocumentInfo(docId);
        }

        public List<AreaOfLegalPracticeEntity> GetaAreaOfLegalPracticeEntitySGID(string submissionGroupId)
        {
            SubCaseSpecificGateway subCaseSpecificGateway = new SubCaseSpecificGateway();
            return subCaseSpecificGateway.GetaAreaOfLegalPracticeEntitySGID(submissionGroupId);
        }

        public void SaveOrUpdateAreaOfLegalPracticeEntity(AreaOfLegalPracticeEntity areaOfLegalPracticeEntity)
        {
            SubCaseSpecificGateway gateway = new SubCaseSpecificGateway();
            gateway.SaveOrUpdateAreaOfLegalPracticeEntity(areaOfLegalPracticeEntity);
        }

        #endregion



    }
}