namespace AllInOne.Legal.Mediator.BackEnd
{
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.CaseData;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Domain.LAP;

    public interface IBackEndMediator
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
        /// Method to Commit the transaction.
        /// </summary>
        void CommitTransaction();

        /// <summary>
        /// Rollsback transaction.
        /// </summary>
        void RollBackTransaction();
        /// <summary>
        /// Deletes the affidavit deponent detail list.
        /// </summary>
        /// <param name="affidavitId">The affidavit id.</param>
        void DeleteAffidavitDeponentDetailList(string affidavitId);

        /// <summary>
        /// Deletes the affidavit info list.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <param name="docId">The doc id.</param>
        void DeleteAffidavitInfoList(string caseInfoId, string subCaseInfoId, string docId);

        /// <summary>
        /// Deletes the appeals data by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        void DeleteAppealsDataBySGID(string submissionGroupId);

        /* End of Criminal Specific Getters*/
        /* Criminal Specifics SaveOrUpdate*/
        /*
        /// <summary>
        /// Save or Update CasePartyCriminalInfoEntity ;
        /// </summary>
        /// <param name="casePartyCriminalInfoEntity">The entity object to be saved into DB</param>
        void SaveOrUpdateCasePartyCriminalInfoEntity(CasePartyCriminalInfoEntity casePartyCriminalInfoEntity);

        /// <summary>
        /// Save or Update CasePartyBailorInfoEntity ;
        /// </summary>
        /// <param name="casePartyBailorInfoEntity">The entity object to be saved into DB</param>
        void SaveOrUpdateCasePartyBailorInfoEntity(CasePartyBailorInfoEntity casePartyBailorInfoEntity);

        /// <summary>
        /// Save or Update CasePartyBailorAddressEntity ;
        /// </summary>
        /// <param name="casePartyBailorAddressEntity">The entity object to be saved into DB</param>
        void SaveOrUpdateCasePartyBailorAddressEntity(CasePartyBailorAddressEntity casePartyBailorAddressEntity);

        /// <summary>
        /// Save or Update DocCasePartyCriminalInfoEntity ;
        /// </summary>
        /// <param name="docCasePartyCriminalInfoEntity">The entity object to be saved into DB</param>
        void SaveOrUpdateDocCasePartyCriminalInfoEntity(DocCasePartyCriminalInfoEntity docCasePartyCriminalInfoEntity);

        /// <summary>
        /// Save or Update DocCasePartyBailorInfoEntity ;
        /// </summary>
        /// <param name="docCasePartyBailorInfoEntity">The entity object to be saved into DB</param>
        void SaveOrUpdateDocCasePartyBailorInfoEntity(DocCasePartyBailorInfoEntity docCasePartyBailorInfoEntity);

        /// <summary>
        /// Save or Update DocCasePartyBailorAddressEntity ;
        /// </summary>
        /// <param name="docCasePartyBailorAddressEntity">The entity object to be saved into DB</param>
        void SaveOrUpdateDocCasePartyBailorAddressEntity(DocCasePartyBailorAddressEntity docCasePartyBailorAddressEntity);
        */
        /*End of Criminal Specifics SaveOrUpdate*/
        //Delete Methods for CaseBroker
        /// <summary>
        /// Deletes the case info by PK.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteCaseInfoByPK(string caseInfoId);

        /// <summary>
        /// Deletes the case originating case list.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteCaseOriginatingCaseList(string caseInfoId);

        /// <summary>
        /// Deletes the case party address list.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        void DeleteCasePartyAddressList(string casePartyId);

        /// <summary>
        /// Deletes the case party AIC address list.
        /// </summary>
        /// <param name="aICID">A ICID.</param>
        void DeleteCasePartyAICAddressList(string aICID);

        /// <summary>
        /// Deletes the case party AIC alias list.
        /// </summary>
        /// <param name="aICID">A ICID.</param>
        void DeleteCasePartyAICAliasList(string aICID);

        /// <summary>
        /// Deletes the case party AIC details list.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        void DeleteCasePartyAICDetailsList(string casePartyId);

        /// <summary>
        /// Deletes the case party alias list.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        void DeleteCasePartyAliasList(string casePartyId);

        /// <summary>
        /// Deletes the case party authorised officer details list.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        void DeleteCasePartyAuthorisedOfficerDetailsList(string casePartyId);

        // <summary>
        /// Deletes the CasePartyBailorAddress
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        void DeleteCasePartyBailorAddress(string casePartyId);

        // <summary>
        /// Deletes the CasePartyBailorInfo
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        void DeleteCasePartyBailorInfo(string casePartyId);

        // <summary>
        /// Deletes the CasePartyCriminalInfo
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        void DeleteCasePartyCriminalInfo(string casePartyId);

        /// <summary>
        /// Deletes the case party data list.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteCasePartyDataList(string caseInfoId);

        /// <summary>
        /// Deletes the case party list.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteCasePartyList(string caseInfoId);

        /// <summary>
        /// Deletes the case party nodes.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        void DeleteCasePartyNodes(string casePartyId);

        /// <summary>
        /// Deletes the case party vessel detail.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        void DeleteCasePartyVesselDetail(string casePartyId);

        /// <summary>
        /// Deletes the case solicitor history list.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteCaseSolicitorHistoryList(string caseInfoId);

        /// <summary>
        /// Deletes the case solicitor list.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteCaseSolicitorList(string caseInfoId);

        /// <summary>
        /// Deletes the case solicitor list.
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        void DeleteCaseSolicitorListByCasePartyId(string casePartyId);

        /// <summary>
        /// Deletes the cert security of costs info list.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        void DeleteCertSecurityOfCostsInfoList(string submissionGroupId);

        /// <summary>
        /// Deletes Charge Info Entities by object
        /// </summary>
        /// <param name="chargeInfoEntity">The ChargeInfoEntity object itself.</param>
        void DeleteChargeInfoEntityByObject(ChargeInfoEntity chargeInfoEntity);

        /// <summary>
        /// Deletes Charge Info Entities by SGID
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the object to filter while retrieving the objects.</param>
        void DeleteChargeInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes Criminal Info Entities by object
        /// </summary>
        /// <param name="criminalInfoEntity">The CriminalInfoEntity object itself.</param>
        void DeleteCriminalInfoEntityByObject(CriminalInfoEntity criminalInfoEntity);

        /* Criminal Case Specifics Delete */
        /// <summary>
        /// Deletes Criminal Info Entities by SGID
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the object to filter while retrieving the objects.</param>
        void DeleteCriminalInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes CriminalOtherOrder Info Entities by object
        /// </summary>
        /// <param name="criminalOtherOrderInfoEntity">The CriminalOtherOrderInfoEntity object itself.</param>
        void DeleteCriminalOtherOrderInfoEntityByObject(CriminalOtherOrderInfoEntity criminalOtherOrderInfoEntity);

        /// <summary>
        /// Deletes Criminal Other Info Entities by SGID
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the object to filter while retrieving the objects.</param>
        void DeleteCriminalOtherOrderInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes the CWU data by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        void DeleteCWUDataBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes the DCACA info by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        void DeleteDCACAInfoBySGID(string submissionGroupId);

        // <summary>
        /// Deletes the DocCasePartyCriminalInfo
        /// </summary>
        /// <param name="dcpId">The dcpId.</param>
        void DeleteDocCasePartyBailorAddress(string dcpId);

        // <summary>
        /// Deletes the DocCasePartyCriminalInfo
        /// </summary>
        /// <param name="dcpId">The dcpId.</param>
        void DeleteDocCasePartyBailorInfo(string dcpId);

        // <summary>
        /// Deletes the DocCasePartyCriminalInfo
        /// </summary>
        /// <param name="dcpId">The dcpId.</param>
        void DeleteDocCasePartyCriminalInfo(string dcpId);

        void DeleteDocCasePartyAddress(string dcpId);
        /// <summary>
        /// Deletes the doc case party nodes.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <param name="dcpId">The DCP id.</param>
        void DeleteDocCasePartyNodes(string caseInfoId, string dcpId);

        /// <summary>
        /// Deletes the doc case solicitor list.
        /// </summary>
        /// <param name="dcpId">The DCP id.</param>
        void DeleteDocCaseSolicitorList(string dcpId);

        /// <summary>
        /// Deletes the doc order details list.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        void DeleteDocOrderDetailsList(string docId);

        /// <summary>
        /// Deletes the doc request details list.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        void DeleteDocRequestDetailsList(string docId);

        /// <summary>
        /// Deletes the document info.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteDocumentInfo(string caseInfoId);

        /// <summary>
        /// Deletes the document info entity.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        void DeleteDocumentInfoEntity(string docId);

        /// <summary>
        /// Deletes the document info list.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteDocumentInfoList(string caseInfoId);

        /// <summary>
        /// Deletes Drug Info Entities by object
        /// </summary>
        /// <param name="drugInfoEntity">The DrugInfoEntity object itself.</param>
        void DeleteDrugInfoEntityByObject(DrugInfoEntity drugInfoEntity);

        /// <summary>
        /// Deletes Drug Info Entities by SGID
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the object to filter while retrieving the objects.</param>
        void DeleteDrugInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes the index doc detail entity.
        /// </summary>
        /// <param name="indexDocInfoId">The index doc info id.</param>
        void DeleteIndexDocDetailEntity(string indexDocInfoId);

        /// <summary>
        /// Deletes the index doc info entity.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        void DeleteIndexDocInfoEntity(string docId);

        /// <summary>
        ///Deletes the <see cref="InterfaceCriminal"/>
        /// </summary>
        /// <param name="caseNo">The caseNo</param>
        void DeleteInterfaceCriminalEntityByCaseNo(string caseNo);

        /// <summary>
        /// Deletes InvestigatingOfficer Info Entities by object
        /// </summary>
        /// <param name="investigatingOfficerInfoEntity">The InvestigatingOfficerInfoEntity object itself.</param>
        void DeleteInvestigatingOfficerInfoEntityByObject(InvestigatingOfficerInfoEntity investigatingOfficerInfoEntity);

        /// <summary>
        /// Deletes Investigating Officer Info Entities by SGID
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the object to filter while retrieving the objects.</param>
        void DeleteInvestigatingOfficerInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes the law firm case file ref number list.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteLawFirmCaseFileRefNumberList(string caseInfoId);

        /// <summary>
        /// Deletes the legislation provisions list.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        void DeleteLegislationProvisionsList(string submissionGroupId);

        /// <summary>
        /// Deletes the nature of application list by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteNatureOfApplicationListByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Deletes the nature of application list by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        void DeleteNatureOfApplicationListBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes the nature of case by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteNatureOfCaseByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Deletes the nature of case by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        void DeleteNatureOfCaseBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes Offence Info Entities by object
        /// </summary>
        /// <param name="offenceInfoEntity">The OffenceInfoEntity object itself.</param>
        void DeleteOffenceInfoEntityByObject(OffenceInfoEntity offenceInfoEntity);

        /// <summary>
        /// Deletes Offence Info Entities by SGID
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the object to filter while retrieving the objects.</param>
        void DeleteOffenceInfoEntityBySGID(string submissionGroupId);

        void DeleteOGCIncomingQueueEntity(string oGCIncomingQueueId);

        /// <summary>
        /// Deletes the originating case list.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteOriginatingCaseList(string caseInfoId);

        /// <summary>
        /// Deletes the originating case list.
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId.</param>
        void DeleteOriginatingCaseListBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes the other ITMO list.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        void DeleteOtherITMOList(string submissionGroupId);

        /// <summary>
        /// Deletes all RAccusedStatementInfoEntity Entity by casePartyId;
        /// </summary>
        /// <param name="casePartyId">The submissionGroupId of the field to filter while retrieving the objects. </param>
        void DeleteRAccusedStatementInfoEntityByCasePartyId(string casePartyId);

        /// <summary>
        /// Deletes all RAccusedStatementInfoEntity Entity by docId;
        /// </summary>
        /// <param name="docId">The submissionGroupId of the field to filter while retrieving the objects. </param>
        void DeleteRAccusedStatementInfoEntityByDocId(string docId);

        /// <summary>
        /// Deletes all RAccusedStatementInfoEntity Entity by docIds and casePartyIds;
        /// </summary>
        /// <param name="List<string> docIds">The docIds of the field to filter while retrieving the objects.</param>
        /// <param name="List<string> casePartyIds">The casePartyIds of the field to filter while retrieving the objects.</param>
        void DeleteRAccusedStatementInfoEntityByDocIdsCasePartyIds(List<string> docIds, List<string> casePartyIds);

        /// <summary>
        /// Deletes the R case law firm list.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteRCaseLawFirmList(string caseInfoId);

        /// <summary>
        /// Deletes the R case submission list.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteRCaseSubmissionList(string caseInfoId);

        void DeleteRCaseTransfer(string forCaseInfoId);

        /// <summary>
        /// Deletes RCriminalLegislation Info Entities by object
        /// </summary>
        /// <param name="rCriminalLegislationInfoEntity">The RCriminalLegislationInfoEntity object itself.</param>
        void DeleteRCriminalLegislationInfoEntityByObject(RCriminalLegislationInfoEntity rCriminalLegislationInfoEntity);

        /// <summary>
        /// Deletes RCriminalLegislation Entities by SGID
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the object to filter while retrieving the objects.</param>
        void DeleteRCriminalLegislationInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes the R doc case list.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <param name="caseInfoId">The case info id.</param>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        void DeleteRDocCaseList(string docId, string caseInfoId, string subCaseInfoId);

        /// <summary>
        /// Deletes the R doc case party list.
        /// </summary>
        /// <param name="dcpId">The DCP id.</param>
        /// <param name="docId">The doc id.</param>
        void DeleteRDocCasePartyList(string dcpId, string docId);

        /// <summary>
        /// Deletes the ref order detail by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        void DeleteRefOrderDetailBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes the ref sub case by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        void DeleteRefSubCaseBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes the registrars appeals data by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        void DeleteRegistrarsAppealsDataBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes the R sub case submission list.
        /// </summary>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <param name="submissionGroupId">The submission group id.</param>
        void DeleteRSubCaseSubmissionList(string subCaseInfoId, string submissionGroupId);

        /// <summary>
        /// Deletes Sentence Info Entities by object
        /// </summary>
        /// <param name="sentenceInfoEntity">The SentenceInfoEntity object itself.</param>
        void DeleteSentenceInfoEntityByObject(SentenceInfoEntity sentenceInfoEntity);

        /// <summary>
        /// Deletes Sentence Info Entities by SGID
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the object to filter while retrieving the objects.</param>
        void DeleteSentenceInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes the sub case info list.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        void DeleteSubCaseInfoList(string caseInfoId);

        /// <summary>
        /// Deletes the sub case party list.
        /// </summary>
        /// <param name="caseInoId">The case ino id.</param>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <param name="casePartyId">The case party id.</param>
        void DeleteSubCasePartyList(string caseInoId, string subCaseInfoId, string casePartyId);

        /// <summary>
        /// Deletes the submission info list.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        void DeleteSubmissionInfoList(string submissionGroupId);

        /// <summary>
        /// Deletes all WitnessInfoEntity Entity by submissionGroupId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects. </param>
        void DeleteWitnessInfoEntityBySubmissionGroupId(string submissionGroupId);

        /// <summary>
        /// Deletes all WOEExecutionAddress Entity by submissionGroupId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        void DeleteWOEExecutionAddressEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Deletes all WOERequest Entity by DocId and requestDocId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        void DeleteWOERequestEntityBySubmissionGroupId(string submissionGroupId);

        List<RUserPAEntity> GetRUserPAEntityByUserId(string userId);

        List<OGCIncomingQueueEntity> GetAllOGCIncomingQueueEntity();

        /// <summary>
        /// Gets the appeals data by SGID.
        /// </summary>
        /// <param name="SGID">The SGID.</param>
        ICaseTypeInfo GetAppealsDataBySGID(string SGID);

        /// <summary>
        /// Gets the <see cref="BTSRoutingQueueEntity"/>
        /// </summary>
        /// <param name="messageId">The messageId.</param>
        /// <returns></returns>
        BTSRoutingQueueEntity GetBTSRoutingQueueEntityByMessageId(string messageId);

        //  List<ICaseEntity> Get<T>(List<Properties> list);
        ICaseEntity GetByPK<T>(string value);

        /// <summary>
        /// Gets the case info entity by pk.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        CaseInfoEntity GetCaseInfoEntityByPk(string caseInfoId);

        List<CaseIssueListEntity> GetCaseIssueListByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list case latest documents entity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        CaseLatestDocumentsEntity GetCaseLatestDocumentsEntity(string caseInfoId, string docId);

        /// <summary>
        /// Gets the case note entity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<CaseNoteEntity> GetCaseNoteEntity(string caseInfoId);

        /// <summary>
        /// Gets the CaseParty Data by case party Id.
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        /// <returns></returns>
        CasePartyData GetCasePartyDataByCasePartyId(string casePartyId);

        /// <summary>
        /// Gets the case reminder entity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<CaseReminderEntity> GetCaseReminderEntity(string caseInfoId);

        /// <summary>
        /// Gets the case sealing instruction entity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<CaseSealingInstructionEntity> GetCaseSealingInstructionEntity(string caseInfoId);

        /// <summary>
        /// Get a ICasePartyData by casePartyId;
        /// </summary>
        /// <param name="casePartyId">The casePartyId of the field to filter while retrieving the objects.</param>
        ICasePartyData GetCriminalCasePartyData(string casePartyId);

        /// <summary>
        /// Gets the Criminal CaseParty Data by case party Id.
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        /// <returns></returns>
        CriminalCasePartyData GetCriminalCasePartyDataByCasePartyId(string casePartyId);

        /// Gets the Criminal data by SGID.
        /// </summary>
        /// <param name="SGID">The SGID.</param>
        /// <returns></returns>
        CriminalData GetCriminalDataBySGID(string SGID);

        /// <summary>
        /// Get a list of CriminalInfoEntity by submissionGroupId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        CriminalInfoEntity GetCriminalInfoEntityBySGID(string submissionGroupId);

        /// Gets the CWU data by SGID.
        /// </summary>
        /// <param name="SGID">The SGID.</param>
        /// <returns></returns>
        ICaseTypeInfo GetCWUDataBySGID(string SGID);

        /// <summary>
        /// Gets the DCACA info entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        DCACAInfoEntity GetDCACAInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the divorce data by submission group id.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ICaseTypeInfo GetDivorceDataBySubmissionGroupId(string submissionGroupId);

        /// <summary>
        /// Gets the doc case party by PK.
        /// </summary>
        /// <param name="DCPId">The DCP id.</param>
        /// <returns></returns>
        DocCasePartyEntity GetDocCasePartyByPK(string DCPId);

        /// <summary>
        /// Gets the <see cref="dCPID"/>and returns the IDocCaseParty
        /// </summary>
        /// <param name="dCPID">The Doc case party id.</param>
        /// <returns>IDocCaseParty</returns>
        IDocCasePartyData GetDocCasePartyData(string dCPID);

        /// Gets the <see cref="docId"/>and returns <see cref="List<DocumentInfoEntity>"/>
        /// </summary>
        /// <param name="docId">The document Id.</param>
        /// <returns></returns>
        DocumentInfoEntity GetDocumentInfoByPK(string docId);

        /// <summary>
        /// Gets the enforcement data by submissionGroupId.
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId.</param>
        ICaseTypeInfo GetEnforcementDataBySubmissionGroupId(string submissionGroupId);

        HearingEntity GetHearingEntityByPk(long hrgId);

        /// <summary>
        /// Gets the index doc info entity by PK.
        /// </summary>
        /// <param name="indexDocInfoId">The index doc info id.</param>
        /// <returns></returns>
        IndexDocInfoEntity GetIndexDocInfoEntityByPK(string indexDocInfoId);

         /// <summary>
        /// Gets the index doc info entity.
        /// </summary>
        /// <param name="indexDocInfoId">The index doc info id.</param>
        /// <returns></returns>
        List<IndexDocInfoEntity> GetIndexDocInfoEntityList(string indexDocInfoId);

        /// <summary>
        ///Gets the <see cref="InterfaceCriminal"/>
        /// </summary>
        /// <param name="caseNo">The caseNo</param>
        /// <returns>InterfaceCriminal</returns>
        InterfaceCriminalEntity GetInterfaceCriminalEntityByCaseNo(string caseNo);

        JudicialUserEntity GetJudicialUserByPK(string userId);

        /// <summary>
        /// Gets the list LawFirm entity by LF Id;
        /// </summary>
        /// <param name="LFId">The LFId</param>
        /// <returns></returns>
        LawFirmEntity GetLawFirmEntityByPK(string LFId);

        /// <summary>
        /// Gets the list affidavit deponent detail.
        /// </summary>
        /// <param name="affidavitId">The affidavit id.</param>
        /// <returns></returns>
        List<AffidavitDeponentDetailEntity> GetListAffidavitDeponentDetail(string affidavitId);

        /// <summary>
        /// Gets the list affidavit info entity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<AffidavitInfoEntity> GetListAffidavitInfoEntity(string caseInfoId, string subCaseInfoId, string docId);

        /// <summary>
        /// Gets the list case entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        List<ICaseEntity> GetListCaseEntity<T>(Dictionary<string, object> values);

        /// <summary>
        /// Gets the list case hearing accessibility history entity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<CaseHearingAccessibilityHistoryEntity> GetListCaseHearingAccessibilityHistoryEntity(string caseInfoId);

        /// <summary>
        /// Gets the list case info entity.
        /// </summary>
        /// <param name="caseNo">The trimmed case no.</param>
        /// <returns></returns>
        List<CaseInfoEntity> GetListCaseInfoByTrimCaseNo(string caseNo);

        /// <summary>
        /// Gets the list case info entity.
        /// </summary>
        /// <param name="caseNo">The case no.</param>
        /// <returns></returns>
        List<CaseInfoEntity> GetListCaseInfoEntity(string caseNo);

        List<CaseInfoEntity> GetListCaseInfoEntityByExactCaseNo(string caseNo);

        /// <summary>
        /// Gets the list case name ind history entity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<CaseNameIndHistoryEntity> GetListCaseNameIndHistoryEntity(string caseInfoId);

        /// <summary>
        /// Gets the list case originating case by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<CaseOriginatingCaseEntity> GetListCaseOriginatingCaseByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list case party address entity.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CasePartyAddressEntity> GetListCasePartyAddressEntity(string casePartyId);

        /// <summary>
        /// Gets the list case party AIC address entity.
        /// </summary>
        /// <param name="aICId">A IC id.</param>
        /// <returns></returns>
        List<CasePartyAICAddressEntity> GetListCasePartyAICAddressEntity(string aICId);

        /// <summary>
        /// Gets the list case party AIC alias entity.
        /// </summary>
        /// <param name="aICId">A IC id.</param>
        /// <returns></returns>
        List<CasePartyAICAliasEntity> GetListCasePartyAICAliasEntity(string aICId);

        /// <summary>
        /// Gets the list case party AIC details entity.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CasePartyAICDetailsEntity> GetListCasePartyAICDetailsEntity(string casePartyId);

        /// <summary>
        /// Gets the list case party alias entity.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CasePartyAliasEntity> GetListCasePartyAliasEntity(string casePartyId);

        /// <summary>
        /// Gets the list case party authorised officer details entity.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CasePartyAuthorisedOfficerDetailsEntity> GetListCasePartyAuthorisedOfficerDetailsEntity(string casePartyId);

        /// <summary>
        /// Get a list of CasePartyBailorAddressEntity by casePartyId;
        /// </summary>
        /// <param name="casePartyId">The casePartyId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CasePartyBailorAddressEntity></returns>
        List<CasePartyBailorAddressEntity> GetListCasePartyBailorAddressEntityByCasePartyId(string casePartyId);

        /// <summary>
        /// Get a list of CasePartyBailorInfoEntity by casePartyId;
        /// </summary>
        /// <param name="casePartyId">The casePartyId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CasePartyEntity></returns>
        List<CasePartyBailorInfoEntity> GetListCasePartyBailorInfoEntityByCasePartyId(string casePartyId);

        /// <summary>
        /// Gets the list CasePartyData entity by caseNo.
        /// </summary>
        /// <param name="caseNo">The caseNo.</param>
        /// <returns></returns>
        List<CasePartyEntity> GetListCasePartyByCaseNumber(string caseNo);

        /// <summary>
        /// Gets the list CasePartyData entity by trimmed caseNo.
        /// </summary>
        /// <param name="caseNo">The caseNo.</param>
        /// <returns></returns>
        List<CasePartyEntity> GetListCasePartyByTrimCaseNo(string caseNo);

        /// <summary>
        /// Get a list of CasePartyCriminalInfoEntity by casePartyId;
        /// </summary>
        /// <param name="casePartyId">The casePartyId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CasePartyEntity></returns>
        List<CasePartyCriminalInfoEntity> GetListCasePartyCriminalInfoEntityByCasePartyId(string casePartyId);

        /// <summary>
        /// Gets the list case party data.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<CasePartyData> GetListCasePartyData(string caseInfoId);

        /// <summary>
        /// Gets the list case party entity by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<CasePartyEntity> GetListCasePartyEntityByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list case party status history entity.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CasePartyStatusHistoryEntity> GetListCasePartyStatusHistoryEntity(string casePartyId);

        /// <summary>
        /// Gets the list case party vessel details entity.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CasePartyVesselDetailsEntity> GetListCasePartyVesselDetailsEntity(string casePartyId);

        /// <summary>
        /// Gets the list case solicitor entity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CaseSolicitorEntity> GetListCaseSolicitorEntity(string caseInfoId, string casePartyId);

        /// <summary>
        /// Gets the list case solicitor entity by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<CaseSolicitorEntity> GetListCaseSolicitorEntityByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list case solicitor history entity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CaseSolicitorHistoryEntity> GetListCaseSolicitorHistoryEntity(string caseInfoId, string casePartyId);

        /// <summary>
        /// Gets the list case solicitor history entity by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<CaseSolicitorHistoryEntity> GetListCaseSolicitorHistoryEntityByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list case status history by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<CaseStatusHistoryEntity> GetListCaseStatusHistoryByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list cert security of costs info.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<CertSecurityOfCostsInfoEntity> GetListCertSecurityOfCostsInfo(string submissionGroupId);

        /// <summary>
        /// Get a list of ChargeInfoEntity by submissionGroupId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CasePartyEntity></returns>
        List<ChargeInfoEntity> GetListChargeInfoEntityBySGID(string submissionGroupId);

        List<ChecklistInstanceEntity> GetListCheckListInstanceByCaseInfoId(string caseInfoId);

        List<ChecklistSubmissionEntity> GetListChecklistSubmissionEntityByCaseInfoId(string checkListInstanceId);

        /* Criminal Finance Getters*/
        /// <summary>
        /// Get a list of CriminalClaimHonorariumInfoEntity> by criminalClaimHonorariumInfoId;
        /// </summary>
        /// <param name="criminalClaimHonorariumInfoId">The criminalClaimHonorariumInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimHonorariumInfoEntity></returns>
        List<CriminalClaimHonorariumInfoEntity> GetListCriminalClaimHonorariumInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId);

        /// Get a list of CriminalClaimInfoEntity> by caseInfoId;
        /// </summary>
        /// <param name="caseInfoId">The caseInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimInfoEntity></returns>
        List<CriminalClaimInfoEntity> GetListCriminalClaimInfoEntityByCaseInfoId(long caseInfoId);

        /// <summary>
        /// Get a list of CriminalClaimInfoEntity> by criminalClaimInfoId;
        /// </summary>
        /// <param name="criminalClaimInfoId">The criminalClaimInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimInfoEntity></returns>
        List<CriminalClaimInfoEntity> GetListCriminalClaimInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId);

        /// <summary>
        /// Get a list of CriminalClaimInterpreterFeeInfoEntity> by criminalClaimInterpreterFeeInfoId;
        /// </summary>
        /// <param name="criminalClaimInterpreterFeeInfoId">The criminalClaimInterpreterFeeInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimInterpreterFeeInfoEntity></returns>
        List<CriminalClaimInterpreterFeeInfoEntity> GetListCriminalClaimInterpreterFeeInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId);

        /// <summary>
        /// Get a list of CriminalClaimMiscellaneousInfoEntity> by criminalClaimMiscellaneousInfoId;
        /// </summary>
        /// <param name="criminalClaimMiscellaneousInfoId">The criminalClaimMiscellaneousInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimMiscellaneousInfoEntity></returns>
        List<CriminalClaimMiscellaneousInfoEntity> GetListCriminalClaimMiscellaneousInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId);

        /// <summary>
        /// Get a list of CriminalClaimProfessionalFeeInfoEntity> by criminalClaimProfessionalFeeInfoId;
        /// </summary>
        /// <param name="criminalClaimProfessionalFeeInfoId">The criminalClaimProfessionalFeeInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimProfessionalFeeInfoEntity></returns>
        List<CriminalClaimProfessionalFeeInfoEntity> GetListCriminalClaimProfessionalFeeInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId);

        /// <summary>
        /// Get a list of CriminalClaimWitnessInfoEntity> by criminalClaimWitnessInfoId;
        /// </summary>
        /// <param name="criminalClaimWitnessInfoId">The criminalClaimWitnessInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimWitnessInfoEntity></returns>
        List<CriminalClaimWitnessInfoEntity> GetListCriminalClaimWitnessInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId);

        /* End of Criminal Finance Getters*/
        /* Criminal Specific Getters*/
        /// <summary>
        /// Get a list of CriminalInfoEntity> by submissionGroupId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CaseInfoEntity></returns>
        List<CriminalInfoEntity> GetListCriminalInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Get a list of CriminalOtherOrderInfoEntity by submissionGroupId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CasePartyEntity></returns>
        List<CriminalOtherOrderInfoEntity> GetListCriminalOtherOrderInfoEntityBySGID(string submissionGroupId);

        List<DisWithDocPtyDetailEntity> GetListDisWithDocPtyDetailEntityBySGID(string submissionGroupId);

        //  List<DocumentInfoFileHistoryEntity
        //  List<SecureDocAccessDetailEntity
        // List<DocSealingInstructionEntity
        /// <summary>
        /// Gets the list doc case party address by DCP id.
        /// </summary>
        /// <param name="dcpId">The DCP id.</param>
        /// <returns></returns>
        List<DocCasePartyAddressEntity> GetListDocCasePartyAddressByDcpId(string dcpId);

        /// <summary>
        /// Gets the list doc case party AIC address entity.
        /// </summary>
        /// <param name="dCPAICId">The d CPAIC id.</param>
        /// <returns></returns>
        List<DocCasePartyAICAddressEntity> GetListDocCasePartyAICAddressEntity(string dCPAICId);

        /// <summary>
        /// Gets the list doc case party AIC alias entity.
        /// </summary>
        /// <param name="dCPAICId">The d CPAIC id.</param>
        /// <returns></returns>
        List<DocCasePartyAICAliasEntity> GetListDocCasePartyAICAliasEntity(string dCPAICId);

        /// <summary>
        /// Gets the list doc case party AIC details entity by DCP id.
        /// </summary>
        /// <param name="dcpId">The DCP id.</param>
        /// <returns></returns>
        List<DocCasePartyAICDetailsEntity> GetListDocCasePartyAICDetailsEntityByDcpId(string dcpId);

        /// <summary>
        /// Gets the list doc case party alias by DCP id.
        /// </summary>
        /// <param name="dcpId">The DCP id.</param>
        /// <returns></returns>
        List<DocCasePartyAliasEntity> GetListDocCasePartyAliasByDcpId(string dcpId);

        /// <summary>
        /// Gets the list doc case party authorised officer details entity by DCP id.
        /// </summary>
        /// <param name="dcpId">The DCP id.</param>
        /// <returns></returns>
        List<DocCasePartyAuthorisedOfficerDetailsEntity> GetListDocCasePartyAuthorisedOfficerDetailsEntityByDcpId(string dcpId);

        /// <summary>
        /// Get a list of DocCasePartyBailorAddressEntity by dCPId;
        /// </summary>
        /// <param name="dCPId">The dCPId of the field to filter while retrieving the objects.</param>
        /// <returns>List<DocCasePartyEntity></returns>
        List<DocCasePartyBailorAddressEntity> GetListDocCasePartyBailorAddressEntityByDCPId(string dCPId);

        /// <summary>
        /// Get a list of DocCasePartyBailorInfoEntity by dCPId;
        /// </summary>
        /// <param name="dCPId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        /// <returns>List<DocCasePartyEntity></returns>
        List<DocCasePartyBailorInfoEntity> GetListDocCasePartyBailorInfoEntityByDCPId(string dCPId);

        /// <summary>
        /// Get a list of CasePartyBailorAddressEntity by casePartyBailorInfoId; A helper method to GetListCasePartyBailorAddressEntityByCasePartyId
        /// </summary>
        /// <param name="casePartyBailorInfoId">The casePartyId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CasePartyBailorAddressEntity></returns>
        //List<CasePartyBailorAddressEntity> GetListCasePartyBailorAddressEntityByCasePartyBailorInfoId(string casePartyBailorInfoId);
        /// <summary>
        /// Get a list of DocCasePartyCriminalInfoEntity by dCPId;
        /// </summary>
        /// <param name="dCPId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        /// <returns>List<DocCasePartyEntity></returns>
        List<DocCasePartyCriminalInfoEntity> GetListDocCasePartyCriminalInfoEntityByDCPId(string dCPId);

        /// <summary>
        /// Gets the list doc case party data.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<DocCasePartyData> GetListDocCasePartyDataByDocId(string docId);

        /// <summary>
        /// Gets the list doc case party entity by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<DocCasePartyEntity> GetListDocCasePartyEntityByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list doc case party vessel details entity by DCP id.
        /// </summary>
        /// <param name="dcpId">The DCP id.</param>
        /// <returns></returns>
        List<DocCasePartyVesselDetailsEntity> GetListDocCasePartyVesselDetailsEntityByDcpId(string dcpId);

        /// <summary>
        /// Gets the list doc case solicitor by DCP id.
        /// </summary>
        /// <param name="dcpId">The DCP id.</param>
        /// <returns></returns>
        List<DocCaseSolicitorEntity> GetListDocCaseSolicitorByDcpId(string dcpId);

        /// <summary>
        /// Gets the list doc comments entity by doc id.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<DocCommentsEntity> GetListDocCommentsEntityByDocId(string docId);

        /// <summary>
        /// Gets the list doc order details entity by doc id.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<DocOrderDetailsEntity> GetListDocOrderDetailsEntityByDocId(string docId);

        // List<DocRemarkEntity> GetListRCDetailsEntityByDocId(string docId);
        /// <summary>
        /// Gets the list doc request details entity by doc id.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<DocRequestDetailsEntity> GetListDocRequestDetailsEntityByDocId(string docId);

        List<IDocumentEntity> GetListDocumentEntity<T>(Dictionary<string, object> values);

        /// <summary>
        /// Gets the list document info by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentInfoByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the document info entity by sub case info id.
        /// </summary>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetDocumentInfoEntityBySubCaseInfoId(string subCaseInfoId);
        /// <summary>
        /// Gets the list DocumentInfo entity by SubmissionGroupId;
        /// </summary>
        /// <param name="LFId">The SGId</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentInfoBySGID(string SGId);

        /// <summary>
        /// Get a list of DrugInfoEntity by submissionGroupId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CasePartyEntity></returns>
        List<DrugInfoEntity> GetListDrugInfoEntityBySGID(string submissionGroupId);

        /* End of Criminal Case Specifics Delete */
        /// <summary>
        /// Gets the list of <see cref="FilingFeeDetailEntity"/>
        /// </summary>
        /// <param name="docId">The docId.</param>
        /// <returns></returns>
        List<FilingFeeDetailEntity> GetListFilingFeeDetailByDocId(string docId);

        /// <summary>
        /// Gets the list of <see cref="FilingFeeRequestDetailEntity"/>
        /// </summary>
        /// <param name="docId">The docId.</param>
        /// <returns></returns>
        List<FilingFeeRequestDetailEntity> GetListFilingFeeRequestDetailByDocId(string docId);

        /// <summary>
        ///Gets the <see cref="HearingEntity"/>
        /// </summary>
        /// <param name="caseInfoId">The caseInfoId</param>
        /// <returns></returns>
        List<HearingEntity> GetListHearingByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list index doc detail entity.
        /// </summary>
        /// <param name="indexDocInfoId">The index doc info id.</param>
        /// <returns></returns>
        List<IndexDocDetailEntity> GetListIndexDocDetailEntity(string indexDocInfoId);

        /// <summary>
        /// Get a list of LegislationProvisionsEntity by submissionGroupId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CasePartyEntity></returns>
        //List<LegislationProvisionsEntity> GetListLegislationProvisionsEntityBySGID(string submissionGroupId);
        /// <summary>
        /// Get a list of InvestigatingOfficerInfoEntity by submissionGroupId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CasePartyEntity></returns>
        List<InvestigatingOfficerInfoEntity> GetListInvestigatingOfficerInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list LawFirmAddress entity by LF Id;
        /// </summary>
        /// <param name="LFId">The LFId</param>
        /// <returns></returns>
        List<LawFirmAddressEntity> GetListLawFirmAddressEntityByLFId(string LFId);

        List<LawFirmAddressEntity> GetAllListLawFirmAddressEntity();

        /// <summary>
        /// Gets the list law firm case file ref number entity.
        /// </summary>
        /// <param name="LFID">The LFID.</param>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<LawFirmCaseFileRefNumberEntity> GetListLawFirmCaseFileRefNumberEntity(string LFID, string caseInfoId);

        /// <summary>
        /// Gets the list law firm case file ref number entity by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<LawFirmCaseFileRefNumberEntity> GetListLawFirmCaseFileRefNumberEntityByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list LawFirm entity;
        /// </summary>
        /// <returns></returns>
        List<LawFirmEntity> GetListLawFirmEntity();

        /// <summary>
        /// Gets all law firm entity.
        /// </summary>
        /// <returns></returns>
        List<LawFirmEntity> GetAllLawFirmEntity();
        /// <summary>
        /// Gets the list legislation provisions.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<LegislationProvisionsEntity> GetListLegislationProvisions(string submissionGroupId);

        List<MinuteSheetFamilyRelatedInfoEntity> GetListMinuteSheetFamilyRelatedInfo(string minuteSheetInfoId);

        List<MinuteSheetGroundInfoEntity> GetListMinuteSheetGroundInfo(string minuteSheetInfoId);

        List<MinuteSheetInfoEntity> GetListMinuteSheetInfoByCaseInfoId(string caseInfoId);

        List<MinuteSheetPartyRepInfoEntity> GetListMinuteSheetPartyRepInfo(string minuteSheetInfoId);

        List<MinuteSheetPartySolicitorInfoEntity> GetListMinuteSheetPartySolicitorInfo(string minuteSheetPartyRepInfoId);

        /// <summary>
        /// Gets the list nature of application by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<NatureOfApplicationEntity> GetListNatureOfApplicationByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list nature of application by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<NatureOfApplicationEntity> GetListNatureOfApplicationBySGID(string submissionGroupId);

        List<NatureOfApplicationEntity> GetListNatureOfApplicationEntityBySubCaseInfoId(string subcaseInfoId);

        /// <summary>
        /// Gets the list nature of case by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<NatureOfCaseEntity> GetListNatureOfCaseByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list nature of case by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<NatureOfCaseEntity> GetListNatureOfCaseBySGID(string submissionGroupId);

        /// <summary>
        /// Get a list of OffenceInfoEntity by submissionGroupId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CasePartyEntity></returns>
        List<OffenceInfoEntity> GetListOffenceInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list originating case by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<OriginatingCaseEntity> GetListOriginatingCaseByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list originating case by submissionGroupId id.
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId.</param>
        /// <returns></returns>
        List<OriginatingCaseEntity> GetListOriginatingCaseEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list other ITMO by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<OtherITMOEntity> GetListOtherITMOBySGID(string submissionGroupId);

        List<PBWillCodicilEntity> GetListPBWillCodicilEntityByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Get a list of RAccusedStatementInfoEntity by docIds and casePartyIds;
        /// </summary>
        /// <param name="List<string> docIds">The docIds of the field to filter while retrieving the objects.</param>
        /// <param name="List<string> casePartyIds">The casePartyIds of the field to filter while retrieving the objects.</param>
        /// <returns>List<RAccusedStatementInfoEntity></returns>
        List<RAccusedStatementInfoEntity> GetListRAccusedStatementInfoByDocIdsCasePartyIds(List<string> docIds, List<string> casePartyIds);

        /// <summary>
        /// Gets the list R case law firm entity by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<RCaseLawFirmEntity> GetListRCaseLawFirmEntityByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list R case submission entity by case info id & LF Id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <param name="LFId">The LF Id</param>
        /// <returns></returns>
        List<RCaseLawFirmEntity> GetListRCaseLawFirmEntityByCaseInfoIdAndLFId(string caseInfoId, string LFId);

        List<RCaseLinkedEntity> GetListRCaseLinkedByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list R case submission entity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<RCaseSubmissionEntity> GetListRCaseSubmissionEntity(string caseInfoId, string submissionGroupId);

        /// <summary>
        /// Gets the list R case submission entity by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<RCaseSubmissionEntity> GetListRCaseSubmissionEntityByCaseInfoId(string caseInfoId);

        List<RCaseTransferEntity> GetListRCaseTransferByFrCaseInfoId(string frCaseInfoId);

        /// <summary>
        /// Gets the R sub case submission entity.
        /// </summary>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <param name="sGId">The s G id.</param>
        /// <returns></returns>
        List<RCriminalLegislationInfoEntity> GetListRCriminalLegislationInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list R doc case entity.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <param name="caseInfoId">The case info id.</param>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <returns></returns>
        List<RDocCaseEntity> GetListRDocCaseEntity(string docId, string caseInfoId, string subCaseInfoId);

        /// <summary>
        /// Gets the list R doc case party.
        /// </summary>
        /// <param name="dcpId">The DCP id.</param>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<RDocCasePartyEntity> GetListRDocCaseParty(string dcpId, string docId);

        /// <summary>
        /// Gets the list R doc case party.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<RDocCasePartyEntity> GetListRDocCaseParty(string docId);

        /// <summary>
        /// Gets the list R doc law firm entity.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <param name="lFId">The l F id.</param>
        /// <returns></returns>
        List<RDocLawFirmEntity> GetListRDocLawFirmEntity(string docId, string lFId);

        /// <summary>
        /// Gets the list ref caveat case entity by SGID.
        /// </summary>
        /// <param name="SGID">The SGID.</param>
        /// <returns></returns>
        List<RefCaveatCaseEntity> GetListRefCaveatCaseEntityBySGID(string SGID);

        /// <summary>
        /// Gets the list ref order details by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<RefOrderDetailEntity> GetListRefOrderDetailsBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list ref sub case details by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<RefSubCaseEntity> GetListRefSubCasesBySGID(string submissionGroupId);

        List<RequestDocDetailEntity> GetListRequestDocDetailEntityByDocId(string docId);

        /// <summary>
        /// Get a list of SentenceInfoEntity by submissionGroupId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CasePartyEntity></returns>
        List<SentenceInfoEntity> GetListSentenceInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list Solicitor entity by LF Id.
        /// </summary>
        /// <param name="LFId">The LFId.</param>
        /// <returns></returns>
        List<SolicitorEntity> GetListSolicitorEntityByLFId(string LFId);

        /// <summary>
        /// Gets the list sub case info entity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<SubCaseInfoEntity> GetListSubCaseInfoEntity(string caseInfoId);

        /// <summary>
        /// Gets the list of <see cref="SubCaseInfoEntity "/>
        /// </summary>
        /// <param name="subCaseNo">The SubCaseNo.</param>
        /// <returns></returns>
        List<SubCaseInfoEntity> GetListSubCaseInfoEntityBySubCaseNo(string subCaseNo);

        /// <summary>
        /// Gets the list sub case party entity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<SubCasePartyEntity> GetListSubCasePartyEntity(string caseInfoId, string subCaseInfoId, string casePartyId);

        /// <summary>
        /// Get a list of WOEExecutionAddressEntity by submissionGroupId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        /// <returns>List<WOEExecutionAddressEntity></returns>
        List<WOEExecutionAddressEntity> GetListWOEExecutionAddressEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the minute sheet data by HrgId.
        /// </summary>
        /// <param name="HrgId">The HrgId.</param>
        ICaseTypeInfo GetMinuteSheetDataByHrgId(string HrgId);

        MinuteSheetInfoEntity GetMinuteSheetInfoEntityByHrgId(string hrgId);

        OGCIncomingQueueEntity GetOGCIncomingQueueEntity(string OGCIncomingQueueId);

        /// <summary>
        /// Gets the <see cref="OriginatingSummonsBankruptcyData "/>
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ICaseTypeInfo GetOriginatingSummonsBankruptcyDataBySGID(string submissionGroupId);

        ICaseTypeInfo GetOriginatingSummonsDataBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="PaymentInDocDetailEntity "/>
        /// </summary>
        /// <param name="PaymentInId">The paymentInId.</param>
        /// <returns></returns>
        PaymentInDocDetailEntity GetPaymentInDocDetailByPK(string paymentInId);

        /// <summary>
        /// Gets the <see cref="PaymentOutDocDetailEntity"/>
        /// </summary>
        /// <param name="PaymentOutId">The paymentOutId.</param>
        /// <returns></returns>
        PaymentOutDocDetailEntity GetPaymentOutDocDetailByPk(string paymentOutId);

        ICaseTypeInfo GetProbateDataBySGID(string submissionGroupId);

        ICaseTypeInfo GetCaveatDataBySGID(string submissionGroupId);

        /// <summary>
        /// Get RAccusedStatementInfoEntity by casePartyId;
        /// </summary>
        /// <param name="casePartyId">The casePartyId of the field to filter while retrieving the objects.</param>
        /// <returns>RAccusedStatementInfoEntity</returns>
        RAccusedStatementInfoEntity GetRAccusedStatementInfoEntityByCasePartyId(string casePartyId);

        /// <summary>
        /// Get RAccusedStatementInfoEntity by docId;
        /// </summary>
        /// <param name="docId">The docId of the field to filter while retrieving the objects.</param>
        /// <returns>RAccusedStatementInfoEntity</returns>
        RAccusedStatementInfoEntity GetRAccusedStatementInfoEntityByDocId(string docId);

        /// <summary>
        /// Gets the registrars appeals data by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ISubCaseTypeInfo GetRegistrarsAppealsDataBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the R sub case submission entity.
        /// </summary>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <param name="sGId">The s G id.</param>
        /// <returns></returns>
        List<RSubCaseSubmissionEntity> GetRSubCaseSubmissionEntity(string subCaseInfoId, string sGId);

        /// <summary>
        /// Gets the R sub casesubmission entity.
        /// </summary>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <returns></returns>
        List<RSubCaseSubmissionEntity> GetRSubCasesubmissionEntity(string subCaseInfoId);
        /// <summary>
        /// Gets the Solicitor entity by solicitor Id.
        /// </summary>
        /// <param name="solicitorId">The solicitorId.</param>
        /// <returns></returns>
        SolicitorEntity GetSolicitorEntityByPK(long solicitorId);

        /// <summary>
        /// Gets the list solicitor entity by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<SolicitorEntity> GetListSolicitorEntityByCaseInfoId(string caseInfoId);
        /// <summary>
        /// Gets the sub case info entity by pk.
        /// </summary>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <returns></returns>
        SubCaseInfoEntity GetSubCaseInfoEntityByPk(string subCaseInfoId);

        /// <summary>
        /// Gets the submission info entity by SG id.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        SubmissionInfoEntity GetSubmissionInfoEntityBySGId(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="SummonsData "/>
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ISubCaseTypeInfo GetSummonsData(string submissionGroupId);

        TaskListEntity GetTaskListEntityByWorkFlowSerialNo(string workFlowSerialNo);

        List<TaskListEntity> GetListTaskListEntityByDocId(string docId);
        ICaseTypeInfo GetTaxationDataBySGID(string submissionGroupId);

        /// <summary>
        /// Get a list of WitnessInfoEntity by submissionGroupId;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        /// <returns>List<WitnessInfoEntity></returns>
        List<WitnessInfoEntity> GetWitnessInfoEntityBySubmissionGroupId(string submissionGroupId);

        /// <summary>
        /// Get a list of WOERequestEntity by submissionGroupId and DocCode;
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId of the field to filter while retrieving the objects.</param>
        /// <returns>List<WOERequestEntity></returns>
        List<WOERequestEntity> GetWOERequestEntityBySubmissionGroupId(string submissionGroupId);

        WorkflowOnAcceptQueueEntity GetWorkflowOnAcceptQueueEntityByPK(string WorkflowOnAcceptQueueId);

        WorkflowPostAcceptQueueEntity GetWorkflowPostAcceptQueueEntityByPK(string WorkflowPostAcceptQueueId);

        ICaseTypeInfo GetWOSDataBySGID(string submissionGroupId);

        /// <summary>
        /// Saves the or update appeals data.
        /// </summary>
        /// <param name="appealsData">The appeals data.</param>
        void SaveOrUpdateAppealsData(ICaseTypeInfo iCaseTypeInfo);

        /// <summary>
        /// Saves the or update back end specific entity.
        /// </summary>
        /// <param name="iBackEndSpecificEntity">The i back end specific entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateBackEndSpecificEntity(IBackEndSpecificEntity iBackEndSpecificEntity, bool isCopy);

        /// <summary>
        /// Saves the or update bankruptcy data.
        /// </summary>
        /// <param name="iCaseTypeInfo">The i case type info.</param>
        void SaveOrUpdateBankruptcyData(ICaseTypeInfo iCaseTypeInfo);

        /// <summary>
        /// Saves the or update case specific data.
        /// </summary>
        /// <param name="caseSpecificData">The case specific data.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateCaseData(ICaseTypeInfo iCaseTypeInfo, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ICaseEntity"/> interface.
        /// </summary>
        /// <param name="ICaseEntity"><see cref="ICaseEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateCaseEntity(ICaseEntity caseEntity, bool isCopy);

        /// <summary>
        /// Saves or Updates (Test Purpose) <see cref="ICaseParty"/>
        /// </summary>
        /// <param name="iCaseParty"></param>
        void SaveOrUpdateCasePartyData(ICasePartyData iCaseParty);

        /// <summary>
        /// Saves the or update entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="caseSpecificEntity">The case specific entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateCaseSpecificEntity(ICaseSpecificEntity iCaseSpecificEntity, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ICommonEntity"/> interface.
        /// </summary>
        /// <param name="iCommonEntity"><see cref="ICommonEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateCommonEntity(ICommonEntity iCommonEntity, bool isCopy);

        void SaveOrUpdateCopyAppealsData(AppealsData appealsData);

        /// <summary>
        /// Saves or Updates CriminalCasePartyData <see cref="ICaseParty"/>
        /// </summary>
        /// <param name="iCaseParty"></param>
        void SaveOrUpdateCriminalCasePartyData(ICasePartyData iCaseParty);

        /// <summary>
        /// Saves or Updates CriminalDocCasePartyData <see cref="ICaseParty"/>
        /// </summary>
        /// <param name="docCasePartyData"></param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateCriminalDocCasePartyData(IDocCasePartyData docCasePartyData, bool isCopy);

        /// <summary>
        /// Saves or Updates <see cref="IDocCaseParty"/>
        /// </summary>
        /// <param name="docCasePartyData">The IDocCaseParty.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateDocCasePartyData(IDocCasePartyData docCasePartyData, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="IDocumentEntity"/> interface.
        /// </summary>
        /// <param name="iDocumentEntity"><see cref="IDocumentEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateDocumentEntity(IDocumentEntity iDocumentEntity, bool isCopy);

        /// <summary>
        /// Saves the or update sub case data.
        /// </summary>
        /// <param name="iSubCaseTypeInfo">The i sub case type info.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateSubCaseData(ISubCaseTypeInfo iSubCaseTypeInfo, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubCaseEntity"/> interface.
        /// </summary>
        /// <param name="iSubCaseEntity"><see cref="ISubCaseEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateSubCaseEntity(ISubCaseEntity iSubCaseEntity, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubCaseSpecificEntity"/> interface.
        /// </summary>
        /// <param name="iSubCaseSpecificEntity"><see cref="ISubCaseSpecificEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateSubCaseSpecificEntity(ISubCaseSpecificEntity iSubCaseSpecificEntity, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubsequentEntity"/> interface.
        /// </summary>
        /// <param name="iSubsequentEntity"><see cref="ISubsequentEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateSubsequentEntity(ISubsequentEntity iSubsequentEntity, bool isCopy);

        List<DocAppProcessByExAgencyEntity> GetListDocAppProcessByExAgencyEntityBySGID(string submissionGroupId);

        List<SubCasePartyEntity> GetListSubCasePartyEntity(string subcaseInfoId);

        CasePartyEntity GetCasePartyEntityByPK(string casePartyId);

        List<DocCasePartyEntity> GetListDocCasePartyBySubCaseInfoId(string subcaseInfoId);

        void DeleteDocCasePartyAlias(string dcpId);

        List<CaseInfoEntity> GetListCaseInfoEntityByCaseType(string caseType);

        List<DocumentInfoEntity> GetListDocumentInfoEntityByDocCode(string docCode);

        BillOfSaleSubInfoEntity GetBillOfSaleSubInfoEntity(string submissionGroupId);

        BillOfSaleInfoEntity GetBillOfSaleInfoEntity(string submissionGroupId);

        List<CaseInfoEntity> PendingOneYearOldDocs();

        /// <summary>
        /// Gets the <see cref="docId"/>and returns <see cref="List<DocCasePartyAICDetailsEntity>"/>
        /// </summary>
        /// <param name="docId">The document case party Id.</param>
        /// <returns></returns>
        List<DocCasePartyEntity> GetListDocCasePartyByDocId(string docId);


        /// <summary>
        /// Gets the List of <see cref="DegreeInfoEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<DegreeInfoEntity></returns>
        List<DegreeInfoEntity> GetListDegreeInfoEntityBySGID(string sGID);

        /// <summary>
        /// Gets the list<see cref="RMUserPSEntity"/>
        /// </summary>
        /// <param name="JOUserId">The JOUserId.</param>
        /// <returns></returns>
        List<RMUserPSEntity> GetListRMUserPSByJOUserId(string JOUserId);

        /// <summary>
        /// Gets the claim amount entity.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<ClaimAmountEntity> GetClaimAmountEntity(string docId);

        List<SolicitorEntity> GetAllSolicitorEntity();


        /// <summary>
        /// Saves the or update law firm entity.
        /// </summary>
        /// <param name="iLawFirmEntity">The i law firm entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateLawFirmEntity(ILawFirmEntity iLawFirmEntity, bool isCopy);

        /// <summary>
        /// Gets the list number of judge assign detail entity by WS no.
        /// </summary>
        /// <param name="workFlowSerialNo">The work flow serial no.</param>
        /// <returns></returns>
        List<NumberOfJudgeAssignDetailEntity> GetListNumberOfJudgeAssignDetailEntityByWSNo(string workFlowSerialNo);

        /// <summary>
        /// Gets the list number of judge assign detail history entity.
        /// </summary>
        /// <param name="NoOfJudgeAssignDetailId">The no of judge assign detail id.</param>
        /// <returns></returns>
        List<NumberOfJudgeAssignDetailHistoryEntity> GetListNumberOfJudgeAssignDetailHistoryEntity(string NoOfJudgeAssignDetailId);

        /// <summary>
        /// Gets the number of judge assign detail entity by PK.
        /// </summary>
        /// <param name="NoOfJudgeAssignDetailId">The no of judge assign detail id.</param>
        /// <returns></returns>
        NumberOfJudgeAssignDetailEntity GetNumberOfJudgeAssignDetailEntityByPK(string NoOfJudgeAssignDetailId);

        /// <summary>
        /// Gets the report config task info entity by PK.
        /// </summary>
        /// <param name="ReportConfigTaskInfoId">The report config task info id.</param>
        /// <returns></returns>
        ReportConfigTaskInfoEntity GetReportConfigTaskInfoEntityByPK(string ReportConfigTaskInfoId);

        /// <summary>
        /// Gets the list BE workitem details entity.
        /// </summary>
        /// <param name="WFSNo">The WFS no.</param>
        /// <returns></returns>
        List<BEWorkitemDetailsEntity> GetListBEWorkitemDetailsEntity(string WFSNo);

        /// <summary>
        /// Gets the list BE workitem recipient entity.
        /// </summary>
        /// <param name="WFSNo">The WFS no.</param>
        /// <returns></returns>
        List<BEWorkitemRecipientEntity> GetListBEWorkitemRecipientEntity(string WFSNo);

        /// <summary>
        /// Deletes the task list.
        /// </summary>
        /// <param name="WFSNo">The WFS no.</param>
        void DeleteTaskList(string WFSNo);

        /// <summary>
        /// Deletes the BE workitem details.
        /// </summary>
        /// <param name="WFSNo">The WFS no.</param>
        void DeleteBEWorkitemDetails(string WFSNo);

        /// <summary>
        /// Deletes the BE workitem recipient.
        /// </summary>
        /// <param name="WFSNo">The WFS no.</param>
        void DeleteBEWorkitemRecipient(string WFSNo);

        /// <summary>
        /// Deletes the number of judge assign detail.
        /// </summary>
        /// <param name="WFSNo">The WFS no.</param>
        void DeleteNumberOfJudgeAssignDetail(string WFSNo);

        /// <summary>
        /// Deletes the number of judge assign detail history.
        /// </summary>
        /// <param name="WFSNo">The WFS no.</param>
        void DeleteNumberOfJudgeAssignDetailHistory(string NumberOfJudgeAssignDetailId);

        /// <summary>
        /// Gets the caveat list  that has been filed > 6 months.
        /// </summary>
        /// <param name="caseTypeCode">The case type code.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetCaveatList(string caseTypeCode);

        List<RCaseLinkedEntity> GetListRCaseLinkedFromGroupId(string linkGroupId);

        RCaseTransferEntity GetRCaseTransferByPK(string rCaseTransferId);

        List<ReportConfigInfoEntity> GetListReportConfigInfo(string jobType);

        void DeleteSentenceCriminalOrderInfo(string submissionGroupId);

        /// <summary>
        /// Gets the RAS data by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ICaseTypeInfo GetRASDataBySGID(string submissionGroupId);

        List<CheckListCommentEntity> GetCheckListCommentEntity(string checkListSubmissionId);

        /// <summary>
        /// Gets the list R case consolidate.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<RCaseConsolidateEntity> GetListRCaseConsolidate(string caseInfoId);

        void SaveRCaseLinkedEntity(RCaseLinkedEntity rCaseLinkedEntity);

        /// <summary>
        /// Gets the list ref order JO info by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<RefOrderJOInfoEntity> GetListRefOrderJOInfoBySGID(string submissionGroupId);

        WOSInfoEntity GetWOSInfoEntityBySGID(string submissionGroupId);

        List<CaseStatusRuleInfoEntity> GetListCaseStatusRuleInfoEntity(string caseInfoId);

        List<TaskListEntity> GetListTaskListEntityByHRGId(long? hrgId);

        List<JudicialUserEntity> GetAllJudicialUserEntity();

        OSInfoEntity GetOSInfoEntity(string sGID);

        /// <summary>
        /// Gets the file inspection entity by PK.
        /// </summary>
        /// <param name="fileInspectionId">The file inspection id.</param>
        /// <returns></returns>
        FileInspectionEntity GetFileInspectionEntityByPK(string fileInspectionId);

        /// <summary>
        /// Gets the list file inspection doc detail by file inspection id.
        /// </summary>
        /// <param name="fileInspectionId">The file inspection id.</param>
        /// <returns></returns>
        List<FileInspectionDocDetailEntity> GetListFileInspectionDocDetailByFileInspectionId(string fileInspectionId);

        /// <summary>
        /// Gets the DocCasePartyLACDetailEntity <see cref="DocCasePartyLACDetailEntity"/>
        /// </summary>
        /// <param name="dcpId">The dcpId.</param>
        /// <returns> DocCasePartyLACDetailEntity </returns>
        DocCasePartyLACDetailEntity GetDocCasePartyLACDetailByDCPId(string dcpId);

        /// <summary>
        /// Gets the workflow outgoing queue by PK.
        /// </summary>
        /// <param name="workflowOutgoingQueueId">The workflow outgoing queue id.</param>
        /// <returns></returns>
        WorkflowOutgoingQueueEntity GetWorkflowOutgoingQueueByPK(string workflowOutgoingQueueId);

        /// <summary>
        /// Gets the workflow outgoing queue entity by doc id.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        WorkflowOutgoingQueueEntity GetWorkflowOutgoingQueueEntityByDocId(string docId);

        /// <summary>
        /// Gets the duty judge assignment by PK.
        /// </summary>
        /// <param name="dutyJudgeAssignmentId">The duty judge assignment id.</param>
        /// <returns></returns>
        DutyJudgeAssignmentEntity GetDutyJudgeAssignmentByPK(string dutyJudgeAssignmentId);

        List<DutyJudgeAssignmentEntity> GetAllDutyJudgementEntity();

        SystemParametersEntity GetSystemParametersEntity(string configKey);

        List<JudicialUserEntity> GetUsersEntityLikeUserName(string userName);

        ProbateInfoEntity GetProbateInfoBySGID(string submissionGroupId);

        List<LiquidatedClaimEntity> GetListLiquidatedClaimEntityBySGID(string submissionGroupId);

        List<UnliquidatedClaimEntity> GetListUnLiquidatedClaimEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns <see cref="List<CaseSolicitorEntity>"/>
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CaseSolicitorEntity> GetListCaseSolicitorByCasePartyId(string casePartyId);

        List<HearingCoramEntity> GetListHearingCoramByHrgId(long hrgId);

        SerialNumberEntity GetSerialNumber(string docPrefix, int year);

        SerialNumberEntity GetNewCaseNumber(string caseType, int year);

        List<DocGCRDetailsEntity> GetDocGCRDetailsEntity(string docId);

        /// <summary>
        /// Gets the list interim case party status entity by doc id.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<InterimCasePartyStatusEntity> GetListInterimCasePartyStatusEntityByDocId(string docId);

        List<RPTDisposalKPIConfigEntity> GetAllRPTDisposalKPIConfigEntity();

        List<RPTNOCGroupNOCEntity> GetAllRPTNOCGroupNOCEntity();

        RPTDisposalKPIConfigEntity GetRPTDisposalKPIConfigEntity(int RPTDisposalKPIConfigId);

        RPTNOCGroupNOCEntity GetRPTNOCGroupNOCEntity(string RPTNOCGroupNOCCode);

        RPTNOCGroupEntity GetRPTNOCGroupEntity(string NocGroupCode);

        List<RPTNOCGroupEntity> GetAllRPTNOCGroupEntity();

        List<HearingOutcomeFlagEntity> GetListHearingOutcomeFlagByHRGId(long hrgId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rLawFirmSolicitorHistoryEntity"></param>
        void SaveOrUpdateRLawFirmSolicitorHistory(RLawFirmSolicitorHistoryEntity rLawFirmSolicitorHistoryEntity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SolicitorId"></param>
        /// <param name="lFID"></param>
        void DeleteRLawFirmSolicitors(long SolicitorId, string lFID);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rLawFirmSolicitors"></param>
        void SaveOrUpdateRLawFirmSolicitor(RLawFirmSolicitorsEntity rLawFirmSolicitors);

        /// <summary>
        /// Rollsback the current Transaction
        /// </summary>
        void RollbackTransaction();
        /// <summary>
        /// Gets the <see cref="TransferOrderOfCourt"/>
        /// </summary>
        /// <param name="transferOrderOfCourtId"></param>
        /// <returns></returns>
        TransferOrderOfCourtEntity GetTransferOrderOfCourt(string transferOrderOfCourtId);

        CasePartyLACDetailEntity GetCasePartyLACDetailEntity(string casePartyId);

        List<LACInfoEntity> GetLacInfoByCaseInfoId(string caseInfoId);

        List<LACDocumentDetailEntity> GetListLACDocumentDetail(string LacInfoId);

        void SaveOrUpdateLAPEntity(ILAPEntity iLAPEntity, bool isCopy);

        ICaseTypeInfo GetSICCOSDataBySGID(string submissionGroupId);

        ICaseTypeInfo GetSICCSDataBySGID(string submissionGroupId);

        ICaseTypeInfo GetRFLDataBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list req examination feedetail entityby sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        /// <returns></returns>
        List<ReqExaminationFeeDetailEntity> GetListReqExaminationFeedetailEntitybySGID(string submissionGroupId);

                /// <summary>
        /// Gets the RFL validity and notification entityby sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        /// <returns></returns>
        List<RFLValidityAndNotificationEntity> GetRFLValidityAndNotificationEntitybySGID(string submissionGroupId);

               /// <summary>
        /// Gets the list sub case status history entity.
        /// </summary>
        /// <param name="SubCaseStatusHistoryId">The sub case status history identifier.</param>
        /// <returns></returns>
        List<SubCaseStatusHistoryEntity> GetListSubCaseStatusHistoryEntity(string SubCaseStatusHistoryId);

        List<SystemParametersEntity> GetAllSystemParameters();

        List<PBPADetailEntity> GetListPBPADetailEntityBySGID(string submissionGroupId);

        List<PBSupNExmEntity> GetListPBSupNExmEntityBySGID(string submissionGroupId);

        List<PBAdminBondEntity> GetListPBAdminBondEntityBySGID(string submissionGroupId);

        List<CaseRegisterEntity> GetListCaseRegisterEntity(long caseInfoId);
        List<CaseRegisterHistoryEntity> GetListCaseRegisterHistoryEntity(long caseInfoId);

        List<DashboardCaseMilestoneDetailEntity> GetListDashboardCaseMilestoneDetailEntity(string caseRegisterId);

        List<DashboardCaseMilestoneDetailHistoryEntity> GetListDashboardCaseMilestoneDetailHistoryEntity(string caseRegisterId);

        List<DashboardSubCaseMilestoneDetailEntity> GetListDashboardSubCaseMilestoneDetailEntity(long subCaseInfoId);

        List<DashboardSubCaseMilestoneDetailHistoryEntity> GetListDashboardSubCaseMilestoneDetailHistoryEntity(long subCaseInfoId);

        CaveatAAInfoEntity GetCaveatAAInfoEntityBySGID(string submissionGroupId);

        CaveatInfoEntity GetCaveatInfoEntityBySGID(string submissionGroupId);


        Temp_ProcessingInfoEntity GetTemp_ProcessingInfoEntityByDocId(string docId);

        List<LawFirmRegistrationEntity> GetListLawFirmRegistrationEntityByLFID(string lfid);
        #endregion Methods
    }
}
