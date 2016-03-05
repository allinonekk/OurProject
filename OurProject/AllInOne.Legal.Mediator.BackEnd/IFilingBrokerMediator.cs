namespace AllInOne.Legal.Mediator.BackEnd
{
    using System.Collections.Generic;

    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.CaseData;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LAP;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Domain.MRelationship;

    using NHibernate;
    using AllInOne.Legal.Domain.Master;

    public interface IFilingBrokerMediator
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
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        void CommitAndCloseSessionFRCCase();


        /// <summary>
        /// Commits the transaction only.
        /// </summary>
        void CommitTransaction();


        /// <summary>
        /// Rollbacks the transaction.
        /// </summary>
        void RollbackTransaction();
        /// <summary>
        /// Deletes the CaseOriginatingCase.
        /// </summary>
        /// <param name="caseInfoId">The caseInfoId.</param>
        void DeleteCaseOriginatingCase(string caseInfoId);

        /// <summary>
        /// Deletes the<see cref="CaseSolicitor"/>
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        void DeleteCaseSolicitorByCasePartyId(string casePartyId);

        /// <summary>
        /// Deletes <see cref="DivorceSubInfoEntities"/>
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId.</param>
        void DeleteDivorceSubInfoBySGID(string submissionGroupId);

        void DeleteWOECaseExecutionAddress(long caseInfoId);

        void DeleteWOECaseExecutionAddress(long caseInfoId, long? subCaseInfoId);

        /// <summary>
        /// Gets the AD data by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ISubCaseTypeInfo GetADDataBySGID(string submissionGroupId);

        /// <summary>
        /// Gets ADMInfoEntityByPK
        /// </summary>
        /// <param name="aDMInfoId">A DM info id.</param>
        /// <returns></returns>
        ADMInfoEntity GetADMInfoEntityByPK(string aDMInfoId);

        /// <summary>
        /// Gets the appeals data by SGID.
        /// </summary>
        /// <param name="SGID">The SGID.</param>
        AppealsData GetAppealsDataBySGID(string SGID);

        /// <summary>
        /// Gets the AAS data by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ApplicationAdvocatesSolicitorsData GetApplicationAdvocatesSolicitorsDataBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the bankruptcy data by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        BankruptcyData GetBankruptcyDataBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the bankruptcy info by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        BankruptcyInfoEntity GetBankruptcyInfoBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="submissionGroupId"/>and returns the ICaseTypeInfo
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId.</param>
        /// <returns>ICaseTypeInfo</returns>
        ICaseTypeInfo GetBillOfSaleData(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="CaseInfoId"/> and returns the CaseInfoEntity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns>Returns <see cref="CaseInfoEntity"/> if found else null.</returns>
        CaseInfoEntity GetCaseInfoEntity(string caseInfoId);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns the CasePartyEntity
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns>CasePartyEntity</returns>
        CasePartyEntity GetCaseParty(string casePartyId);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns the CasePartyAddressEntity
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns>CasePartyAddressEntity</returns>
        CasePartyAddressEntity GetCasePartyAddressByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns the CasePartyAICAddressEntity
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns>CasePartyAICAddressEntity</returns>
        CasePartyAICAddressEntity GetCasePartyAICAddressByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns the CasePartyAICAliasEntity
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns>CasePartyAICAliasEntity</returns>
        CasePartyAICAliasEntity GetCasePartyAICAliasByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns the CasePartyAICDetailsEntity
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns>CasePartyAICDetailsEntity</returns>
        CasePartyAICDetailsEntity GetCasePartyAICDetailsByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns the CasePartyAliasEntity
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns>CasePartyAliasEntity</returns>
        CasePartyAliasEntity GetCasePartyAliasByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns the CasePartyAuthorisedOfficerDetailsEntity
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns>CasePartyAuthorisedOfficerDetailsEntity</returns>
        CasePartyAuthorisedOfficerDetailsEntity GetCasePartyAuthorisedOfficerDetailsByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns the ICaseParty
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns>ICaseParty</returns>
        ICasePartyData GetCasePartyData(string casePartyId);

        /// <summary>
        /// Get a list of CasePartyLACDetailEntity by passing the column name and its value.
        /// </summary>
        /// <typeparam name="V">The type for the parameter "value"</typeparam>
        /// <param name="fieldName">The name of the column in database. (Name of property of object).</param>
        /// <param name="value">The value used to filter.</param>
        /// <returns>A list of CasePartyLACDetailEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 28, 2011)</remarks>
        List<CasePartyLACDetailEntity> GetCasePartyLACDetail<V>(string fieldName, V value);

        /// <summary>
        /// Gets the <see cref="CasePartyLACDetailEntity "/>
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        /// <returns></returns>
        CasePartyLACDetailEntity GetCasePartyLACDetailEntity(string casePartyId);

        /// <summary>
        /// Gets the <see cref="CasePartyLACDetailEntity "/>
        /// </summary>
        /// <param name="casePartyId">The LacInfoId.</param>
        /// <returns></returns>
        List<CasePartyLACDetailEntity> GetListCasePartyLACDetailEntityByLACInfoId(string LacInfoId);
        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns the CasePartyVesselDetailsEntity
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns>CasePartyVesselDetailsEntity</returns>
        CasePartyVesselDetailsEntity GetCasePartyVesselDetailsByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns the CaseSolicitorEntity
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns>CaseSolicitorEntity</returns>
        CaseSolicitorEntity GetCaseSolicitorByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns the CaseSolicitorHistoryEntity
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns>CaseSolicitorHistoryEntity</returns>
        CaseSolicitorHistoryEntity GetCaseSolicitorHistoryByPK(string primaryKey);

        ChecklistInstanceEntity GetChecklistInstanceEntityByPK(string checkListInstanceId);

        ICasePartyData GetCriminalCasePartyData(string casePartyId);

        /// <summary>
        /// Gets the <see cref="SGID"/>and returns the CriminalData - Criminal
        /// </summary>
        /// <param name="SGID">The submission group id.</param>
        /// <returns>CriminalData</returns>
        CriminalData GetCriminalDataBySGID(string SGID);

        // <summary>
        /// Gets the <see cref="dCPID"/>and returns the IDocCasePartyData - Criminal
        /// </summary>
        /// <param name="dCPID">The dcpid.</param>
        /// <returns>IDocCasePartyData</returns>
        IDocCasePartyData GetCriminalDocCasePartyData(string dCPID);

        //TODO: ADInfo to BackEnd
        /// <summary>
        /// Gets the CWU data by SGID.
        /// </summary>
        /// <param name="SGID">The SGID.</param>
        /// <returns></returns>
        CWUData GetCWUDataBySGID(string SGID);

        /// <summary>
        /// Gets the CWU info entity.
        /// </summary>
        /// <param name="cWUInfoId">The c WU info id.</param>
        /// <returns></returns>
        CWUInfoEntity GetCWUInfoEntity(string cWUInfoId);

        /// <summary>
        /// Gets the CWUInfo entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        CWUInfoEntity GetCWUInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the DCACA info entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        DCACAInfoEntity GetDCACAInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the divorce info entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        DivorceInfoEntity GetDivorceInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="DocCasePartyId"/>and returns <see cref="DocCasePartyAddressEntity"/>
        /// </summary>
        /// <param name="DocCasePartyId">The case party id.</param>
        /// <returns></returns>
        //DocCasePartyAddressEntity GetDocCasePartyAddressByPK(string primaryKey);
        /// <summary>
        /// Gets the <see cref="DocCasePartyId"/>and returns <see cref="DocCasePartyAICAddressEntity"/>
        /// </summary>
        /// <param name="DocCasePartyId">The case party id.</param>
        /// <returns></returns>
        DocCasePartyAICAddressEntity GetDocCasePartyAICAddressByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="DocCasePartyId"/>and returns <see cref="DocCasePartyAICAliasEntity"/>
        /// </summary>
        /// <param name="DocCasePartyId">The case party id.</param>
        /// <returns></returns>
        DocCasePartyAICAliasEntity GetDocCasePartyAICAliasByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="DocCasePartyId"/>and returns <see cref="DocCasePartyAICDetailsEntity"/>
        /// </summary>
        /// <param name="DocCasePartyId">The case party id.</param>
        /// <returns></returns>
        DocCasePartyAICDetailsEntity GetDocCasePartyAICDetailsByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="DocCasePartyId"/>and returns <see cref="DocCasePartyAliasEntity"/>
        /// </summary>
        /// <param name="DocCasePartyId">The case party id.</param>
        /// <returns></returns>
        DocCasePartyAliasEntity GetDocCasePartyAliasByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="DocCasePartyId"/>and returns <see cref="DocCasePartyAuthorisedOfficerDetailsEntity"/>
        /// </summary>
        /// <param name="DocCasePartyId">The case party id.</param>
        /// <returns></returns>
        DocCasePartyAuthorisedOfficerDetailsEntity GetDocCasePartyAuthorisedOfficerDetailsByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="DocCasePartyId"/>and returns <see cref="DocCasePartyEntity"/>
        /// </summary>
        /// <param name="DocCasePartyId">The case party id.</param>
        /// <returns></returns>
        DocCasePartyEntity GetDocCasePartyByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="dCPID"/>and returns the IDocCaseParty
        /// </summary>
        /// <param name="dCPID">The Doc case party id.</param>
        /// <returns>IDocCaseParty</returns>
        IDocCasePartyData GetDocCasePartyData(string dCPID);

        /// <summary>
        /// Gets the <see cref="DocCasePartyLACDetailEntity "/>
        /// </summary>
        /// <param name="dcpId">The dcpId.</param>
        /// <returns></returns>
        DocCasePartyLACDetailEntity GetDocCasePartyLACDetailEntity(string dcpId);

        /// <summary>
        /// Gets the <see cref="LFCFRNId"/>and returns <see cref="DocCasePartyVesselDetailsEntity"/>
        /// </summary>
        /// <param name="LFCFRNId">The case party id.</param>
        /// <returns></returns>
        DocCasePartyVesselDetailsEntity GetDocCasePartyVesselDetailsByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="DocOrderDetailsEntity"/>
        /// </summary>
        /// <param name="docId">The docId.</param>
        /// <returns></returns>
        DocOrderDetailsEntity GetDocOrderDetailsByDocId(string docId);

        /// Gets the <see cref="docId"/>and returns <see cref="List<DocumentInfoEntity>"/>
        /// </summary>
        /// <param name="docId">The document Id.</param>
        /// <returns></returns>
        DocumentInfoEntity GetDocumentInfoByPK(string docId);

        /// <summary>
        /// Gets the enforcement data by submission group id.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ICaseTypeInfo GetEnforcementDataBySubmissionGroupId(string submissionGroupId);

        /// <summary>
        /// Gets the hearing entity by PK.
        /// </summary>
        /// <param name="hrgId">The HRG id.</param>
        /// <returns></returns>
        HearingEntity GetHearingEntityByPK(string hrgId);

        /// <summary>
        /// Gets the LAB party data by LAB party id.
        /// </summary>
        /// <param name="lABPartyId">The l AB party id.</param>
        /// <returns></returns>
        ILABPartyData GetLABPartyDataByLABPartyId(string lABPartyId);

        /// <summary>
        /// Gets the LAB party history data by LAB party id.
        /// </summary>
        /// <param name="lABPartyId">The l AB party id.</param>
        /// <returns></returns>
        ILABPartyHistoryData GetLABPartyHistoryDataByLABPartyId(string lABPartyId);

        /// <summary>
        /// Gets the <see cref="LACCancellationInfoEntity"/>
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        LACCancellationInfoEntity GetLACCancellationInfoByDocId(string docId);

        /// <summary>
        /// Get a list of LACDocumentDetailEntity by passing the column name and its value.
        /// </summary>
        /// <typeparam name="V">The type for the parameter "value"</typeparam>
        /// <param name="fieldName">The name of the column in database. (Name of property of object).</param>
        /// <param name="value">The value used to filter.</param>
        /// <returns>A list of LACDocumentDetailEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 28, 2011)</remarks>
        List<LACDocumentDetailEntity> GetLACDocumentDetail<V>(string fieldName, V value);

        /// <summary>
        /// Passes the primaryKey and gets the LACInfoEntity
        /// </summary>
        /// <param name="lABPartyAddressId">The primary key of LAC Info.<param>
        /// <returns></returns>
        LACInfoEntity GetLACInfoByPK(string lACInfoId);

        List<LACInfoEntity> GetLacInfoByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the <see cref="DocCasePartyId"/>and returns <see cref="LawFirmCaseFileRefNumberEntity"/>
        /// </summary>
        /// <param name="DocCasePartyId">The case party id.</param>
        /// <returns></returns>
        LawFirmCaseFileRefNumberEntity GetLawFirmCaseFileRefNumberByPK(string primaryKey);

        /// <summary>
        /// Gets the List of <see cref="AASInfoEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<AASInfoEntity></returns>
        List<AASInfoEntity> GetListAASInfoEntityBySGID(string sGID);

        /// <summary>
        /// Gets the list affidavit deponent detail entity by affidavit id.
        /// </summary>
        /// <param name="AffidavitId">The affidavit id.</param>
        /// <returns></returns>
        List<AffidavitDeponentDetailEntity> GetListAffidavitDeponentDetailEntityByAffidavitId(string AffidavitId);

        /// <summary>
        /// Gets the list affidavit info entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<AffidavitInfoEntity> GetListAffidavitInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the List of <see cref="AreaOfLegalPracticeEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<AreaOfLegalPracticeEntity></returns>
        List<AreaOfLegalPracticeEntity> GetListAreaOfLegalPracticeEntityBySGID(string sGID);

        List<BankruptcyOtherDefDetailEntity> GetListBankruptcyOtherDefDetail(string submissionGroupId);

        /// <summary>
        /// Gets the list bankruptcy other def detail by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<BankruptcyOtherDefDetailEntity> GetListBankruptcyOtherDefDetailBySGID(string submissionGroupId);

        List<BTSRoutingQueueEntity> GetListBTSRoutingQueueEntity(string messageId);

        List<BTSRoutingQueueEntity> GetListBTSRoutingQueueEntityByStatus(string status);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns <see cref="List<CasePartyAddressEntity>"/>
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CasePartyAddressEntity> GetListCasePartyAddress(string casePartyId);

        /// <summary>
        /// Gets the <see cref="AICID"/>and returns <see cref="List<CasePartyAICAddressEntity>"/>
        /// </summary>
        /// <param name="AICID">The AIC case party id.</param>
        /// <returns></returns>
        List<CasePartyAICAddressEntity> GetListCasePartyAICAddress(string AICID);

        /// <summary>
        /// Gets the <see cref="AICID"/>and returns <see cref="List<CasePartyAICAliasEntity>"/>
        /// </summary>
        /// <param name="AICID">The AIC case party id.</param>
        /// <returns></returns>
        List<CasePartyAICAliasEntity> GetListCasePartyAICAlias(string AICID);

        /// <summary>
        /// Gets the <see cref="CasePartyId"/>and returns <see cref="List<CasePartyAICDetailsEntity>"/>
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CasePartyAICDetailsEntity> GetListCasePartyAICDetails(string casePartyId);

        /// <summary>
        /// Gets the <see cref="CasePartyAICDetailsEntity"/>
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        /// <returns></returns>
        List<CasePartyAICDetailsEntity> GetListCasePartyAICDetailsByCasePartyId(string casePartyId);

        /// <summary>
        /// Gets the <see cref="AICID"/>and returns <see cref="List<CasePartyAliasEntity>"/>
        /// </summary>
        /// <param name="AICID">The AIC case party id.</param>
        /// <returns></returns>
        List<CasePartyAliasEntity> GetListCasePartyAlias(string casePartyId);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns <see cref="List<CasePartyAuthorisedOfficerDetailsEntity>"/>
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CasePartyAuthorisedOfficerDetailsEntity> GetListCasePartyAuthorisedOfficerDetail(string casePartyId);

        List<CasePartyEntity> GetListCasePartyByCaseInfoID(string caseInfoId);

        /// <summary>
        /// Gets the List of <see cref="AreaOfLegalPracticeEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<AreaOfLegalPracticeEntity></returns>
        List<CasePartyCitizenshipEntity> GetListCasePartyCitizenshipEntityByCasePartyId(string casePartyId);

        /// <summary>
        /// Gets the List of <see cref="AreaOfLegalPracticeEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<AreaOfLegalPracticeEntity></returns>
        List<CasePartyEntity> GetListCasePartyEntityByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the <see cref="CasePartyLACDetailHistoryEntity"/>
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        /// <returns></returns>
        List<CasePartyLACDetailHistoryEntity> GetListCasePartyLACDetailHistoryByCasePartyId(string casePartyId);

        /// <summary>
        /// Gets the list of <see cref="CasePartyLACDetailHistoryEntity "/>
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        /// <returns></returns>
        List<CasePartyLACDetailHistoryEntity> GetListCasePartyLACDetailHistoryEntity(string casePartyId);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns <see cref="List<CasePartyVesselDetailsEntity>"/>
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CasePartyVesselDetailsEntity> GetListCasePartyVesselDetail(string casePartyId);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns <see cref="List<CaseSolicitorEntity>"/>
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CaseSolicitorEntity> GetListCaseSolicitorByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns <see cref="List<CaseSolicitorEntity>"/>
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CaseSolicitorEntity> GetListCaseSolicitorByCasePartyId(string casePartyId);

        /// <summary>
        /// Gets the <see cref="caseInfoId"/>and returns <see cref="List<CaseSolicitorHistoryEntity>"/>
        /// </summary>
        /// <param name="caseInfoId">The case info Id.</param>
        /// <returns></returns>
        List<CaseSolicitorHistoryEntity> GetListCaseSolicitorHistoryByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the <see cref="casePartyId"/>and returns <see cref="List<CaseSolicitorHistoryEntity>"/>
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<CaseSolicitorHistoryEntity> GetListCaseSolicitorHistoryByCasePartyId(string casePartyId);

        /// <summary>
        /// Gets the <see cref="CDRInfoEntity"/>by SGID.
        /// </summary>
        /// <param name="SGID">The SGID.</param>
        /// <returns></returns>
        List<CDRInfoEntity> GetListCDRInfoEntityBySGID(string submissionGroupId);

        List<ChargeInfoEntity> GetListChargeInfoBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list checklist instance entity by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<ChecklistInstanceEntity> GetListChecklistInstanceEntityByCaseInfoId(string caseInfoId);

        List<ChecklistSubmissionEntity> GetListCheckListSubmission(string checkListInstanceId);

        /// <summary>
        /// Gets the list checklist submission entity by doc id.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<ChecklistSubmissionEntity> GetListChecklistSubmissionEntityByDocId(string docId);

        /// <summary>
        /// Gets the list checklist submission entity by submission group id.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<ChecklistSubmissionEntity> GetListChecklistSubmissionEntityBySubmissionGroupId(string submissionGroupId);

        /// <summary>
        /// Gets the List of <see cref="DegreeInfoEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<DegreeInfoEntity></returns>
        List<DegreeInfoEntity> GetListDegreeInfoEntityBySGID(string sGID);

        /// <summary>
        /// Gets the list of divorce sub info entities by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<DivorceSubInfoEntity> GetListDivorceSubInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="dCPID"/>and returns <see cref="List<DocCasePartyAddressEntity>"/>
        /// </summary>
        /// <param name="dCPID">The document case party Id.</param>
        /// <returns></returns>
        List<DocCasePartyAddressEntity> GetListDocCasePartyAddress(string dCPID);

        /// <summary>
        /// Gets the <see cref="DCPAICID"/>and returns <see cref="List<DocCasePartyAICAddressEntity>"/>
        /// </summary>
        /// <param name="DCPAICID">The document case party AIC Id.</param>
        /// <returns></returns>
        List<DocCasePartyAICAddressEntity> GetListDocCasePartyAICAddress(string DCPAICID);

        /// <summary>
        /// Gets the <see cref="DCPAICID"/>and returns <see cref="List<DocCasePartyAICAliasEntity>"/>
        /// </summary>
        /// <param name="DCPAICID">The document case party AIC Id.</param>
        /// <returns></returns>
        List<DocCasePartyAICAliasEntity> GetListDocCasePartyAICAlias(string DCPAICID);

        /// <summary>
        /// Gets the <see cref="dCPID"/>and returns <see cref="List<DocCasePartyAICDetailsEntity>"/>
        /// </summary>
        /// <param name="dCPID">The document case party Id.</param>
        /// <returns></returns>
        List<DocCasePartyAICDetailsEntity> GetListDocCasePartyAICDetails(string dCPID);

        /// Gets the <see cref="dCPID"/>and returns <see cref="List<DocCasePartyAliasEntity>"/>
        /// </summary>
        /// <param name="dCPID">The document case party Id.</param>
        /// <returns></returns>
        List<DocCasePartyAliasEntity> GetListDocCasePartyAlias(string dCPID);

        /// Gets the <see cref="dCPID"/>and returns <see cref="List<DocCasePartyAuthorisedOfficerDetailsEntity>"/>
        /// </summary>
        /// <param name="dCPID">The document case party Id.</param>
        /// <returns></returns>
        List<DocCasePartyAuthorisedOfficerDetailsEntity> GetListDocCasePartyAuthorisedOfficerDetails(string dCPID);

        /// <summary>
        /// Gets the <see cref="docId"/>and returns <see cref="List<DocCasePartyAICDetailsEntity>"/>
        /// </summary>
        /// <param name="docId">The document case party Id.</param>
        /// <returns></returns>
        List<DocCasePartyEntity> GetListDocCasePartyByDocId(string docId);

        /// Gets the <see cref="dCPID"/>and returns <see cref="List<DocCasePartyVesselDetailsEntity>"/>
        /// </summary>
        /// <param name="dCPID">The document case party Id.</param>
        /// <returns></returns>
        List<DocCasePartyVesselDetailsEntity> GetListDocCasePartyVesselDetails(string dCPID);

        /// Gets the <see cref="dCPID"/>and returns <see cref="List<DocCaseSolicitorEntity>"/>
        /// </summary>
        /// <param name="dCPID">The document case party Id.</param>
        /// <returns></returns>
        List<DocCaseSolicitorEntity> GetListDocCaseSolicitor(string dCPID);

        /// <summary>
        /// Gets the <see cref="DocGCRDetailsEntity"/>by docId.
        /// </summary>
        /// <param name="docId">The docId.</param>
        /// <returns></returns>
        List<DocGCRDetailsEntity> GetListDocGCRDetailsByDocId(string docId);

        List<DocRequestDetailEntity> GetListDocRequestDetailEntity(string docId);

        /// <summary>
        /// Gets the list document info by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentInfoByCaseInfoId(string caseInfoId);

        List<DocumentInfoEntity> GetListDocumentInfoBySubCaseInfoId(long subcaseInfoId);

        /// Gets the <see cref="submissionId"/>and returns <see cref="List<DocumentInfoEntity>"/>
        /// </summary>
        /// <param name="submissionId">The Submission Group Id.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentInfoBySubmissionId(string submissionId);

        /// <summary>
        /// Gets the List of <see cref="EmploymentInfoEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<EmploymentInfoEntity></returns>
        List<EmploymentInfoEntity> GetListEmploymentInfoEntityBySGID(string sGID);

        List<FileInspectionDocDetailEntity> GetListFileInspectionDocDetailEntityByDocId(string docId);

        List<FileInspectionEntity> GetListFileInspectionEntityByDocId(string docId);

        /// <summary>
        /// Gets the <see cref="FilingFeeDetailEntity"/>
        /// </summary>
        /// <param name="docId">The docId.</param>
        /// <returns></returns>
        List<FilingFeeDetailEntity> GetListFilingFeeDetailEntityByDocId(string docId);

        /// <summary>
        /// Gets the <see cref="FilingFeeDetailEntity"/>
        /// </summary>
        /// <param name="submissionGroupId">The SubmissionGroupId.</param>
        /// <returns></returns>
        List<FilingFeeDetailEntity> GetListFilingFeeDetailEntityBySGID(string submissionGroupId);

        List<FilingFeeRequestDetailEntity> GetListFilingFeeRequestDetailEntity(string docId);

        List<HearingEntity> GetListHearingByCaseInfoId(string caseInfoId);

        List<HearingEntity> GetListHearingByDocId(string docId);

        /// <summary>
        /// Passes the Document Id and gets the LABSection17CertInfoEntity
        /// </summary>
        /// <param name="docId">The Document Id.<param>
        /// <returns></returns>
        List<LABSection17CertInfoEntity> GetListLABSection17CertInfoByDocId(string docId);

        /// <summary>
        /// Gets the list LAB section17 cert info.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        List<LABSection17CertInfoEntity> GetListLABSection17CertInfo(string caseInfoId,string casePartyId);

        /// <summary>
        /// Passes the Doc Id and gets the LACDocumentDetailEntity
        /// </summary>
        /// <param name="docId">The Document Id.<param>
        /// <returns></returns>
        List<LACDocumentDetailEntity> GetListLACDocumentDetailByDocId(string docId);

        /// Gets the <see cref="caseInfoID"/>and returns <see cref="List<LawFirmCaseFileRefNumberEntity>"/>
        /// </summary>
        /// <param name="caseInfoID">The document Info Id.</param>
        /// <returns></returns>
        List<LawFirmCaseFileRefNumberEntity> GetListLawFirmCaseFileRefNumber(string caseInfoID);

        /// <summary>
        /// Gets the List of <see cref="LegalExperienceInfoEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<LegalExperienceInfoEntity></returns>
        List<LegalExperienceInfoEntity> GetListLegalExperienceInfoEntityBySGID(string sGID);

        /// <summary>
        /// Gets the List of <see cref="LegislationProvisionsEntity"/>
        /// </summary>
        /// <param name="SGId">The submission group id.</param>
        /// <returns></returns>
        List<LegislationProvisionsEntity> GetListLegislationProvisionsEntityBySGId(string SGId);

        List<MinuteSheetDocListEntity> GetListMinuteSheetDocListEntityByDocId(string docId);

        List<NatureOfCaseEntity> GetListNatureOfCaseEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list of <see cref="NotPaymenttoCourtDocDetailEntity "/>
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId.</param>
        /// <returns></returns>
        List<NotPaymenttoCourtDocDetailEntity> GetListNotPaymenttoCourtDocDetailEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list orders made entity by doc id.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<OrdersMadeEntity> GetListOrdersMadeEntityByDocId(string docId);

        /// <summary>
        /// Gets the list no of supporting doc by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        //List<NoOfSupportingDocEntity> GetListNoOfSupportingDocBySGID(string submissionGroupId);
        /// <summary>
        /// Gets the list case originating case entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<OriginatingCaseEntity> GetListOriginatingCaseEntityBySGID(string submissionGroupId);

        List<OSInfoEntity> GetListOSInfoEntityBySGID(string sGID);

        List<OutgoingCorrespondenceCourtFeeEntity> GetListOutgoingCorrespondenceCourtFeeEntityBySGID(string sGID);

        List<OutgoingCorrespondenceInfoEntity> GetListOutgoingCorrespondenceInfoEntityBySGID(string sGID);

        List<PartyAmendmentEntity> GetListPartyAmendmentByDocId(string docId);

        List<PartyAmendmentDetailEntity> GetListPartyAmendmentDetailByAmendmentId(string amendmentId);

        List<PartyAmendmentLeaveOfCourtEntity> GetListPartyAmendmentLeaveOfCourtByAmendmentId(string amendmentId);

        /// Gets the <see cref="caseInfoID"/>and returns <see cref="List<RCaseLawFirmEntity>"/>
        /// </summary>
        /// <param name="caseInfoID">The document Info Id.</param>
        /// <returns></returns>
        List<RCaseLawFirmEntity> GetListRCaseLawFirmEntity(string caseInfoID);

        /// Gets the <see cref="caseInfoID"/>and returns <see cref="List<RCaseSubmissionEntity>"/>
        /// </summary>
        /// <param name="caseInfoID">The document Info Id.</param>
        /// <returns></returns>
        List<RCaseSubmissionEntity> GetListRCaseSubmissionEntity(string caseInfoID);

        /// Gets the <see cref="caseInfoID"/>and returns <see cref="List<RCaseSubmissionEntity>"/>
        /// </summary>
        /// <param name="caseInfoID">The document Info Id.</param>
        /// <returns></returns>
        List<RCaseSubmissionEntity> GetListRCaseSubmissionEntityBySGID(string SGID);

        /// Gets the <see cref="dCPID"/>and returns <see cref="List<RDocCasePartyEntity>"/>
        /// </summary>
        /// <param name="dCPID">The document case party Id.</param>
        /// <returns></returns>
        List<RDocCasePartyEntity> GetListRDocCaseParty(string dCPID);

        /// Gets the <see cref="docId"/>and returns <see cref="List<RDocCasePartyEntity>"/>
        /// </summary>
        /// <param name="docId">The document Id.</param>
        /// <returns></returns>
        List<RDocCasePartyEntity> GetListRDocCasePartyByDocId(string docId);

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
        /// Gets the list RelationSubCaseInfo
        /// </summary>
        /// <param name="SGID">SubCaseInfoId.</param>
        /// <returns></returns>
        List<RelationalSubCaseInfoEntity> GetListRelationalSubCaseInfoBySubCaseInfoId(string subCaseInfoId);

        List<RequestDocDetailEntity> GetListRequestDocDetailByRequesrDocId(string requestDocId);

        List<RequestHearingAdminSupportEntity> GetListRequestHearingAdminSupportEntityBySGID(string submissionGroupId);

        List<RequestNEGDDetailEntity> GetListRequestNEGDDetailEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the R sub case submission entity by sub case info id.
        /// </summary>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <returns></returns>
        List<RSubCaseSubmissionEntity> GetListRSubCaseSubmissionEntityBySubCaseInfoId(string subCaseInfoId);

        /// <summary>
        /// Gets the list sub case party by sub case info id.
        /// </summary>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <returns></returns>
        List<SubCasePartyEntity> GetListSubCasePartyBySubCaseInfoId(string subCaseInfoId);

        /// <summary>
        /// Gets the list submission info entity.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<SubmissionInfoEntity> GetListSubmissionInfoEntityBySGID(string submissionGroupId);

        List<SubpoenaDocDetailEntity> GetListSubpoenaDocDetailsBySGID(string submissionGroupId);

        List<SubpoenaInfoEntity> GetListSubpoenaInfoEntitySGID(string submissionGroupId);

        List<SubpoenaWitnessDetailEntity> GetListSubpoenaWitnessDetailEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the List of <see cref="TravelPassInfoEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<TravelPassInfoEntity></returns>
        List<TravelPassInfoEntity> GetListTravelPassInfoEntityBySGID(string sGID);

        /// <summary>
        /// Gets the <see cref="VacHRGDatesReqInfoEntity"/>by SGID.
        /// </summary>
        /// <param name="SGID">The SGID.</param>
        /// <returns></returns>
        List<VacHRGDatesReqInfoEntity> GetListVacHRGDatesReqInfoEntityBySGID(string submissionGroupId);

        List<WOEExecutionAddressEntity> GetListWOEExecutionAddressEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the List of <see cref="WOEInfoEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<WOEInfoEntity></returns>
        List<WOEInfoEntity> GetListWOEInfoEntityBySGID(string sGID);

        /// <summary>
        /// Gets the List of <see cref="WOEMOMSCTInfoEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<WOEMOMSCTInfoEntity></returns>
        List<WOEMOMSCTInfoEntity> GetListWOEMOMSCTInfoEntityBySGID(string sGID);

        /// <summary>
        /// Gets the List of <see cref="WOENCPEInfoEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<WOENCPEInfoEntity></returns>
        List<WOENCPEInfoEntity> GetListWOENCPEInfoEntityBySGID(string sGID);

        /// <summary>
        /// Gets the List of <see cref="WOENECPEInfoEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<WOENECPEInfoEntity></returns>
        List<WOENECPEInfoEntity> GetListWOENECPEInfoEntityBySGID(string sGID);

        /// <summary>
        /// Gets the <see cref="BEWorkitemDetailsEntity"/>
        /// </summary>
        /// <param name="workflowSerialNo">The workflowSerialNo.</param>
        /// <returns></returns>
        List<BEWorkitemDetailsEntity> GetListWorkItemDetailsEntityByWorkflowSerialNo(string workflowSerialNo);

        /// <summary>
        /// Gets the <see cref="BEWorkitemRecipientEntity"/>
        /// </summary>
        /// <param name="workflowSerialNo">The workflowSerialNo.</param>
        /// <returns></returns>
        List<BEWorkitemRecipientEntity> GetListWorkItemRecipientEntityByWorkflowSerialNo(string workflowSerialNo);

        /// <summary>
        /// Gets the <see cref="OriginatingSummonsBankruptcyData "/>
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ICaseTypeInfo GetOriginatingSummonsBankruptcyDataBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the payment HRG dates doc detail entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        PaymentHRGDatesDocDetailEntity GetPaymentHRGDatesDocDetailEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="PracticeOfCertificateData"/>
        /// </summary>
        /// <param name="submissionGroupId">The SubmissionGroupId.</param>
        /// <returns></returns>
        ISubCaseTypeInfo GetPracticeOfCertificateDataBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the RARA sinfo entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        RARASInfoEntity GetRARASinfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Get a list of RCaseLinkedEntity by passing the column name and its value.
        /// </summary>
        /// <typeparam name="V">The type for the parameter "value"</typeparam>
        /// <param name="fieldName">The name of the column in database. (Name of property of object).</param>
        /// <param name="value">The value used to filter.</param>
        /// <returns>A list of RCaseLinkedEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 29, 2011)</remarks>
        List<RCaseLinkedEntity> GetRCaseLinked<V>(string fieldName, V value);

        /// Gets the <see cref="rCaseSubmissionId"/>and returns <see cref="RCaseSubmissionEntity"/>
        /// </summary>
        /// <param name="rCaseSubmissionId">The case submission Id.</param>
        /// <returns></returns>
        RCaseSubmissionEntity GetRCaseSubmissionByPK(string rCaseSubmissionId);

        /// <summary>
        /// Gets the R doc case entity by doc id.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        RDocCaseEntity GetRDocCaseEntityByDocId(string docId);

        /// Gets the <see cref="RDCPId"/>and returns <see cref="RDocCasePartyEntity"/>
        /// </summary>
        /// <param name="RDCPId">The R document case party Id.</param>
        /// <returns></returns>
        RDocCasePartyEntity GetRDocCasePartyByPK(string primaryKey);

        /// <summary>
        /// Gets the ref caveat case entity.
        /// </summary>
        /// <param name="aDMCavetNoId">A DM cavet no id.</param>
        /// <returns></returns>
        RefCaveatCaseEntity GetRefCaveatCaseEntity(string aDMCavetNoId);

        /// <summary>
        /// Gets the registrars appeals data by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ISubCaseTypeInfo GetRegistrarsAppealsDataBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="ServiceOfDocDocStatusHistoryEntity"/>by SGID
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ServiceOfDocDocStatusHistoryEntity GetServiceOfDocDocStatusHistoryByPK(string primaryKey);

        /// <summary>
        /// Gets the service of doc document entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        ServiceOfDocDocumentEntity GetServiceOfDocDocumentEntityByPK(string primaryKey);

        /// <summary>
        /// Gets the <see cref="ServiceOfDocInfoDetailEntity"/>by SGID
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ServiceOfDocInfoDetailEntity GetServiceOfDocInfoDetailByPK(string primaryKey);

        /// <summary>
        /// Gets the service of doc info entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ServiceOfDocInfoEntity GetServiceOfDocInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the set down data by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ISubCaseTypeInfo GetSetDownDataBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the sub case info entity by sub case info id.
        /// </summary>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <returns></returns>
        SubCaseInfoEntity GetSubCaseInfoEntityBySubCaseInfoId(string subCaseInfoId);

        /// <summary>
        /// Gets the sub case party entity.
        /// </summary>
        /// <param name="subCasePartyId">The sub case party id.</param>
        /// <returns></returns>
        SubCasePartyEntity GetSubCasePartyEntity(string subCasePartyId);

        /// <summary>
        /// Gets the <see cref="SummonsData "/>
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ISubCaseTypeInfo GetSummonsData(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="TaskListEntity"/>
        /// </summary>
        /// <param name="workflowSerialNo">The workflowSerialNo.</param>
        /// <returns></returns>
        TaskListEntity GetTaskListEntityByWorkflowSerialNo(string workflowSerialNo);

        /// <summary>
        /// Gets the warrant of arrest data by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ISubCaseTypeInfo GetWarrantOfArrestDataBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="WOEData "/>
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ISubCaseTypeInfo GetWOEData(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="WOEInfoEntity"/>
        /// </summary>
        /// <param name="woeInfoId">The woeInfoId.</param>
        /// <returns>WOEInfoEntity</returns>
        WOEInfoEntity GetWOEInfoEntityByWOEInfoId(string woeInfoId);

        /// <summary>
        /// Gets the <see cref="WOEMOMSCTInfoEntity"/>
        /// </summary>
        /// <param name="woeMOMSCTInfoId">The woeMOMSCTInfoId.</param>
        /// <returns>WOEMOMSCTInfoEntity</returns>
        WOEMOMSCTInfoEntity GetWOEMOMSCTInfoEntityByWOEMOMSCTInfoId(string woeMOMSCTInfoId);

        /// <summary>
        /// Gets the <see cref="WOENCPEInfoEntity"/>
        /// </summary>
        /// <param name="woeNCPEInfoId">The woeNCPEInfoId.</param>
        /// <returns>WOENCPEInfoEntity</returns>
        WOENCPEInfoEntity GetWOENCPEInfoEntityByWOENCPEInfoId(string woeNCPEInfoId);

        /// <summary>
        /// Gets the <see cref="WOENECPEInfoEntity"/>
        /// </summary>
        /// <param name="woeNECPEInfoId">The woeNECPEInfoId.</param>
        /// <returns>WOENECPEInfoEntity</returns>
        WOENECPEInfoEntity GetWOENECPEInfoEntityByWOENECPEInfoId(string woeNECPEInfoId);

        /// <summary>
        /// Saves the or update AD data.
        /// </summary>
        /// <param name="iSubCaseTypeInfo">The i sub case type info.</param>
        void SaveOrUpdateADData(ISubCaseTypeInfo iSubCaseTypeInfo);

        /// <summary>
        /// Saves the or update ADM info entity.
        /// </summary>
        /// <param name="aDMInfoEntity">A DM info entity.</param>
        void SaveOrUpdateADMInfoEntity(ADMInfoEntity aDMInfoEntity);

        /// <summary>
        /// Saves the or update affidavit deponent detail entity.
        /// </summary>
        /// <param name="affidavitDeponentDetailEntity">The affidavit deponent detail entity.</param>
        void SaveOrUpdateAffidavitDeponentDetailEntity(AffidavitDeponentDetailEntity affidavitDeponentDetailEntity);

        /// <summary>
        /// Saves the or update affidavit info entity.
        /// </summary>
        /// <param name="affidavitInfoEntity">The affidavit info entity.</param>
        void SaveOrUpdateAffidavitInfoEntity(AffidavitInfoEntity affidavitInfoEntity);

        /// <summary>
        /// Saves the or update appeals data.
        /// </summary>
        /// <param name="appealsData">The appeals data.</param>
        void SaveOrUpdateAppealsData(AppealsData appealsData);

        /// <summary>
        /// Saves the or update back end specific entity.
        /// </summary>
        /// <param name="backEndSpecificEntity">The back end specific entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateBackEndSpecificEntity(IBackEndSpecificEntity backEndSpecificEntity, bool isCopy);

        /// <summary>
        /// Saves the or update bankruptcy data.
        /// </summary>
        /// <param name="iCaseTypeInfo">The i case type info.</param>
        void SaveOrUpdateBankruptcyData(ICaseTypeInfo iCaseTypeInfo);

        /// <summary>
        /// Saves the or update bankruptcy other def detail.
        /// </summary>
        /// <param name="bankruptcyOtherDefDetailEntity">The bankruptcy other def detail entity.</param>
        void SaveOrUpdateBankruptcyOtherDefDetail(BankruptcyOtherDefDetailEntity bankruptcyOtherDefDetailEntity);

        /// <summary>
        /// Saves or Updates <see cref="BankruptcyInfoEntity"/>
        /// </summary>
        /// <param name="bankruptcyEntity">The bankruptcy entity.</param>
        void SaveOrUpdateBankyuptcyInfoEntity(BankruptcyInfoEntity bankruptcyEntity);

        /// <summary>
        /// Saves the or update case specific data.
        /// </summary>
        /// <param name="caseSpecificData">The case specific data.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateCaseData(ICaseTypeInfo iCaseTypeInfo, bool isCopy);

        void SaveOrUpdateCaseEntity(ICaseEntity caseEntity, bool isCopy);

        /// <summary>
        /// Saves or Updates <see cref="CaseInfoEntity "/>
        /// </summary>
        /// <param name="caseInfoEntity"></param>
        void SaveOrUpdateCaseInfoEntity(CaseInfoEntity caseInfoEntity);

        /// <summary>
        /// Saves or Updates <see cref="CasePartyAddressEntity "/>
        /// </summary>
        /// <param name="casePartyAddressEntity"></param>
        void SaveOrUpdateCasePartyAddressEntity(CasePartyAddressEntity casePartyAddressEntity);

        /// <summary>
        /// Saves or Updates <see cref="CasePartyAICAddressEntity "/>
        /// </summary>
        /// <param name="casePartyAICAddressEntity"></param>
        void SaveOrUpdateCasePartyAICAddressEntity(CasePartyAICAddressEntity casePartyAICAddressEntity);

        /// <summary>
        /// Saves or Updates <see cref="CasePartyAICAddressEntity "/>
        /// </summary>
        /// <param name="casePartyAICAddressEntity"></param>
        void SaveOrUpdateCasePartyAICAliasEntity(CasePartyAICAliasEntity casePartyAICAliasEntity);

        /// <summary>
        /// Saves or Updates <see cref="CasePartyAICDetailsEntity "/>
        /// </summary>
        /// <param name="casePartyAICDetailsEntity"></param>
        void SaveOrUpdateCasePartyAICDetailsEntity(CasePartyAICDetailsEntity casePartyAICDetailsEntity);

        /// <summary>
        /// Saves or Updates <see cref="CasePartyAliasEntity "/>
        /// </summary>
        /// <param name="casePartyAliasEntity"></param>
        void SaveOrUpdateCasePartyAliasEntity(CasePartyAliasEntity casePartyAliasEntity);

        /// <summary>
        /// Saves or Updates <see cref="CasePartyAuthorisedOfficerDetailsEntity "/>
        /// </summary>
        /// <param name="casePartyAuthorisedOfficerDetailsEntity"></param>
        void SaveOrUpdateCasePartyAuthorisedOfficerDetailEntity(CasePartyAuthorisedOfficerDetailsEntity casePartyAuthorisedOfficerDetailsEntity);

        /// <summary>
        /// Saves or Updates (Test Purpose) <see cref="ICaseParty"/>
        /// </summary>
        /// <param name="iCaseParty"></param>
        void SaveOrUpdateCasePartyData(ICasePartyData iCaseParty);

        /// <summary>
        /// Saves or Updates <see cref="CasePartyEntity "/>
        /// </summary>
        /// <param name="casePartyEntity"></param>
        void SaveOrUpdateCasePartyEntity(CasePartyEntity casePartyEntity);

        /// <summary>
        /// Saves or Updates <see cref="CasePartyVesselDetailsEntity "/>
        /// </summary>
        /// <param name="casePartyVesselDetailsEntity"></param>
        void SaveOrUpdateCasePartyVesselDetailEntity(CasePartyVesselDetailsEntity casePartyVesselDetailsEntity);

        /// <summary>
        /// Saves or Updates <see cref="CaseSolicitorEntity "/>
        /// </summary>
        /// <param name="caseSolicitorEntity"></param>
        void SaveOrUpdateCaseSolicitorEntity(CaseSolicitorEntity caseSolicitorEntity);

        /// <summary>
        /// Saves or Updates <see cref="CaseSolicitorHistoryEntity "/>
        /// </summary>
        /// <param name="caseSolicitorHistoryEntity"></param>
        void SaveOrUpdateCaseSolicitorHistoryEntity(CaseSolicitorHistoryEntity caseSolicitorHistoryEntity);

        /// <summary>
        /// Saves the or update entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="caseSpecificEntity">The case specific entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateCaseSpecificEntity(ICaseSpecificEntity iCaseSpecificEntity, bool isCopy);

        /// <summary>
        /// Saves the or update checklist instance entity.
        /// </summary>
        /// <param name="checklistInstanceEntity">The checklist instance entity.</param>
        void SaveOrUpdateChecklistInstanceEntity(ChecklistInstanceEntity checklistInstanceEntity);

        /// <summary>
        /// Saves the or update checklist submission entity.
        /// </summary>
        /// <param name="checklistSubmissionEntity">The checklist submission entity.</param>
        void SaveOrUpdateChecklistSubmissionEntity(ChecklistSubmissionEntity checklistSubmissionEntity);

        /// <summary>
        /// Saves the or update common entity.
        /// </summary>
        /// <param name="iCommonEntity">The i common entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateCommonEntity(ICommonEntity iCommonEntity, bool isCopy);

        void SaveOrUpdateCopyAppealsData(AppealsData appealsData);

        /// <summary>
        /// Saves or Updates Copy<see cref="CasePartyAddressEntity "/>
        /// </summary>
        /// <param name="casePartyAddressEntity"></param>
        void SaveOrUpdateCopyCasePartyAddressEntity(CasePartyAddressEntity casePartyAddressEntity);

        /// <summary>
        /// Saves or Updates Copy<see cref="CasePartyAICAddressEntity "/>
        /// </summary>
        /// <param name="casePartyAICAddressEntity"></param>
        void SaveOrUpdateCopyCasePartyAICAddressEntity(CasePartyAICAddressEntity casePartyAICAddressEntity);

        /// <summary>
        /// Saves or Updates Copy<see cref="CasePartyAICAddressEntity "/>
        /// </summary>
        /// <param name="casePartyAICAddressEntity"></param>
        void SaveOrUpdateCopyCasePartyAICAliasEntity(CasePartyAICAliasEntity casePartyAICAliasEntity);

        /// <summary>
        /// Saves or Updates Copy<see cref="CasePartyAICDetailsEntity "/>
        /// </summary>
        /// <param name="casePartyAICDetailsEntity"></param>
        void SaveOrUpdateCopyCasePartyAICDetailsEntity(CasePartyAICDetailsEntity casePartyAICDetailsEntity);

        //Others
        /// <summary>
        /// Saves or Updates Copy (Test Purpose) <see cref="CasePartyAliasEntity "/>
        /// </summary>
        /// <param name="casePartyAliasEntity"></param>
        void SaveOrUpdateCopyCasePartyAliasEntity(CasePartyAliasEntity casePartyAliasEntity);

        /// <summary>
        /// Saves or Updates  Copy (Test Purpose) <see cref="CasePartyAuthorisedOfficerDetailsEntity "/>
        /// </summary>
        /// <param name="casePartyAuthorisedOfficerDetailsEntity"></param>
        void SaveOrUpdateCopyCasePartyAuthorisedOfficerDetailEntity(CasePartyAuthorisedOfficerDetailsEntity casePartyAuthorisedOfficerDetailsEntity);

        /// <summary>
        /// Saves the or update copy case party data.
        /// </summary>
        /// <param name="iCaseParty">The i case party.</param>
        void SaveOrUpdateCopyCasePartyData(ICasePartyData iCaseParty);

        /// <summary>
        /// Saves or Updates Copy<see cref="CasePartyVesselDetailsEntity "/>
        /// </summary>
        /// <param name="casePartyVesselDetailsEntity"></param>
        void SaveOrUpdateCopyCasePartyVesselDetailEntity(CasePartyVesselDetailsEntity casePartyVesselDetailsEntity);

        /// <summary>
        /// Saves or Updates Copy<see cref="CaseSolicitorEntity "/>
        /// </summary>
        /// <param name="caseSolicitorEntity"></param>
        void SaveOrUpdateCopyCaseSolicitorEntity(CaseSolicitorEntity caseSolicitorEntity);

        /// <summary>
        /// Saves or Updates Copy<see cref="CaseSolicitorHistoryEntity "/>
        /// </summary>
        /// <param name="caseSolicitorHistoryEntity"></param>
        void SaveOrUpdateCopyCaseSolicitorHistoryEntity(CaseSolicitorHistoryEntity caseSolicitorHistoryEntity);

        void SaveOrUpdateCopyCriminalCasePartyData(ICasePartyData iCaseParty);

        /// <summary>
        /// Saves or UpdatesCopy <see cref="RCaseSubmissionEntity"/>
        /// </summary>
        /// <param name="rCaseSubmissionEntity"></param>
        void SaveOrUpdateCopyRCaseSubmissionEntity(RCaseSubmissionEntity rCaseSubmissionEntity);

        void SaveOrUpdateCriminalCasePartyData(ICasePartyData iCaseParty);

        void SaveOrUpdateCriminalDocCasePartyData(IDocCasePartyData iDocCaseParty);

        void SaveOrUpdateCriminalDocCasePartyData(IDocCasePartyData docCasePartyData, bool isCopy);

        /// <summary>
        /// Saves the or update CWU data.
        /// </summary>
        /// <param name="cWUData">The c WU data.</param>
        void SaveOrUpdateCWUData(CWUData cWUData);

        /// <summary>
        /// Saves or Updates<see cref="CWUInfoEntity"/>
        /// </summary>
        /// <param name="cWUInfoEntity"></param>
        void SaveOrUpdateCWUInfoEntity(CWUInfoEntity cWUInfoEntity);

        /// <summary>
        /// Saves the or updates <see cref="DCACAInfoEntity "/>
        /// </summary>
        /// <param name="dCACAInfoEntity"></param>
        void SaveOrUpdateDCACAInfoEntity(DCACAInfoEntity dCACAInfoEntity);

        /// <summary>
        /// Saves the or update divorce info entity.
        /// </summary>
        /// <param name="divorceInfoEntity">The divorce info entity.</param>
        void SaveOrUpdateDivorceInfoEntity(DivorceInfoEntity divorceInfoEntity);

        /// <summary>
        /// Saves or updates <see cref="DocCasePartyAddressEntity"/>
        /// </summary>
        /// <param name="docCasePartyAddressEntity">The doc case party address entity.</param>
        void SaveOrUpdateDocCasePartyAddressEntity(DocCasePartyAddressEntity docCasePartyAddressEntity);

        /// <summary>
        /// Saves or Updates <see cref="DocCasePartyAICAddressEntity "/>
        /// </summary>
        /// <param name="docCasePartyAICAddressEntity">The doc case party AIC address entity.</param>
        void SaveOrUpdateDocCasePartyAICAddressEntity(DocCasePartyAICAddressEntity docCasePartyAICAddressEntity);

        /// <summary>
        /// Saves or updates <see cref="DocCasePartyAICAliasEntity"/>
        /// </summary>
        /// <param name="docCasePartyAICAliasEntity">The doc case party AIC alias entity.</param>
        void SaveOrUpdateDocCasePartyAICAliasEntity(DocCasePartyAICAliasEntity docCasePartyAICAliasEntity);

        /// <summary>
        /// Saves or Updates <see cref="DocCasePartyAICDetailsEntity"/>
        /// </summary>
        /// <param name="docCasePartyAICDetailsEntity">The doc case party AIC details entity.</param>
        void SaveOrUpdateDocCasePartyAICDetailsEntity(DocCasePartyAICDetailsEntity docCasePartyAICDetailsEntity);

        /// <summary>
        /// Saves or updates <see cref="DocCasePartyAliasEntity"/>
        /// </summary>
        /// <param name="docCasePartyAliasEntity">The doc case party alias entity.</param>
        void SaveOrUpdateDocCasePartyAliasEntity(DocCasePartyAliasEntity docCasePartyAliasEntity);

        /// <summary>
        /// Saves or Updates <see cref="DocCasePartyAuthorisedOfficerDetailsEntity"/>
        /// </summary>
        /// <param name="docCasePartyAuthorisedOfficerDetailsEntity">The doc case party authorised officer details entity.</param>
        void SaveOrUpdateDocCasePartyAuthorisedOfficerDetailsEntity(DocCasePartyAuthorisedOfficerDetailsEntity docCasePartyAuthorisedOfficerDetailsEntity);

        /// <summary>
        /// Saves or Updates <see cref="IDocCaseParty "/>
        /// </summary>
        /// <param name="iDocCaseParty">The iDocCaseParty.</param>
        void SaveOrUpdateDocCasePartyData(IDocCasePartyData iDocCaseParty);

        /// <summary>
        /// Saves or Updates <see cref="IDocCaseParty"/>
        /// </summary>
        /// <param name="docCasePartyData">The IDocCaseParty.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateDocCasePartyData(IDocCasePartyData docCasePartyData, bool isCopy);

        /// <summary>
        /// Saves or updates <see cref="DocCasePartyEntity"/>.
        /// </summary>
        /// <param name="docCasePartyEntity">The doc case party entity.</param>
        void SaveOrUpdateDocCasePartyEntity(DocCasePartyEntity docCasePartyEntity);

        /// <summary>
        /// Saves or Updates <see cref="CasePartyVesselDetailsEntity"/>
        /// </summary>
        /// <param name="casePartyVesselDetailsEntity">The case party vessel details entity.</param>
        void SaveOrUpdateDocCasePartyVesselDetailsEntity(DocCasePartyVesselDetailsEntity docCasePartyVesselDetailsEntity);

        /// <summary>
        /// Saves or Updates <see cref="DocCaseSolicitorEntity "/>
        /// </summary>
        /// <param name="docCaseSolicitorEntity">The doc Case Solicitor Entity.</param>
        void SaveOrUpdateDocCaseSolicitorEntity(DocCaseSolicitorEntity docCaseSolicitorEntity);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="IDocumentEntity"/> interface.
        /// </summary>
        /// <param name="iDocumentEntity"><see cref="IDocumentEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateDocumentEntity(IDocumentEntity iDocumentEntity, bool isCopy);

        /// <summary>
        /// Saves or Updates <see cref="DocumentInfoEntity"/>
        /// </summary>
        /// <param name="documentInfoEntity"></param>
        void SaveOrUpdateDocumentInfoEntity(DocumentInfoEntity documentInfoEntity);

        void SaveOrUpdateLABPartyData(ILABPartyData iLABParty);

        void SaveOrUpdateLABPartyHistoryData(ILABPartyHistoryData iLABPartyHistory);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ILAPEntity"/> interface.
        /// </summary>
        /// <param name="iLAPEntity"><see cref="ILAPEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateLAPEntity(ILAPEntity iLAPEntity, bool isCopy);

        /// <summary>
        /// Saves or Updates <see cref="LawFirmCaseFileRefNumberEntity"/>
        /// </summary>
        /// <param name="lawFirmCaseFileRefNumberEntity"></param>
        void SaveOrUpdateLawFirmCaseFileRefNumberEntity(LawFirmCaseFileRefNumberEntity lawFirmCaseFileRefNumberEntity);

        /// <summary>
        /// Saves the or update legislation proviosions entity.
        /// </summary>
        /// <param name="legislationProvisionsEntity">The legislation provisions entity.</param>
        void SaveOrUpdateLegislationProviosionsEntity(LegislationProvisionsEntity legislationProvisionsEntity);

        /// <summary>
        /// Saves the or update liquidated claim entity.
        /// </summary>
        /// <param name="liquidatedClaimEntity">The liquidated claim entity.</param>
        void SaveOrUpdateLiquidatedClaimEntity(LiquidatedClaimEntity liquidatedClaimEntity);

        /// <summary>
        /// Saves the or update liquidator address entity.
        /// </summary>
        /// <param name="liquidatorAddressEntity">The liquidator address entity.</param>
        void SaveOrUpdateLiquidatorAddressEntity(LiquidatorAddressEntity liquidatorAddressEntity);

        /// <summary>
        /// Saves the or update liquidator alias entity.
        /// </summary>
        /// <param name="liquidatorAliasEntity">The liquidator alias entity.</param>
        void SaveOrUpdateLiquidatorAliasEntity(LiquidatorAliasEntity liquidatorAliasEntity);

        /// <summary>
        /// Saves the or update liquidator entity.
        /// </summary>
        /// <param name="liquidatorEntity">The liquidator entity.</param>
        void SaveOrUpdateLiquidatorEntity(LiquidatorEntity liquidatorEntity);

        /// <summary>
        /// Saves the or update liquidator PIC address entity.
        /// </summary>
        /// <param name="liquidatorPICAddressEntity">The liquidator PIC address entity.</param>
        void SaveOrUpdateLiquidatorPICAddressEntity(LiquidatorPICAddressEntity liquidatorPICAddressEntity);

        /// <summary>
        /// Saves the or update liquidator PIC alias entity.
        /// </summary>
        /// <param name="liquidatorPICAliasEntity">The liquidator PIC alias entity.</param>
        void SaveOrUpdateLiquidatorPICAliasEntity(LiquidatorPICAliasEntity liquidatorPICAliasEntity);

        /// <summary>
        /// Saves the or update liquidator PIC entity.
        /// </summary>
        /// <param name="liquidatorPICEntity">The liquidator PIC entity.</param>
        void SaveOrUpdateLiquidatorPICEntity(LiquidatorPICEntity liquidatorPICEntity);

        /// <summary>
        /// Saves the or update nature of case entity.
        /// </summary>
        /// <param name="natureOfCaseEntity">The nature of case entity.</param>
        void SaveOrUpdateNatureOfCaseEntity(NatureOfCaseEntity natureOfCaseEntity);

        /// <summary>
        /// Saves the or update no of supporting doc.
        /// </summary>
        /// <param name="noOfSupportingDocEntity">The no of supporting doc entity.</param>
        //void SaveOrUpdateNoOfSupportingDoc(NoOfSupportingDocEntity noOfSupportingDocEntity);
        void SaveOrUpdateOriginatingCaseEntity(OriginatingCaseEntity originatingCaseEntity);

        /// <summary>
        /// Saves the or update other ITMO entity.
        /// </summary>
        /// <param name="otherITMOEntity">The other ITMO entity.</param>
        void SaveOrUpdateOtherITMOEntity(OtherITMOEntity otherITMOEntity);

        /// <summary>
        /// Saves the or update other reliefs claim entity.
        /// </summary>
        /// <param name="otherReliefsClaimEntity">The other reliefs claim entity.</param>
        void SaveOrUpdateOtherReliefsClaimEntity(OtherReliefsClaimEntity otherReliefsClaimEntity);

        /// <summary>
        /// Saves the or update payment HRG dates doc detail entity.
        /// </summary>
        /// <param name="paymentHRGDatesDocDetailEntity">The payment HRG dates doc detail entity.</param>
        void SaveOrUpdatePaymentHRGDatesDocDetailEntity(PaymentHRGDatesDocDetailEntity paymentHRGDatesDocDetailEntity);

        /// <summary>
        /// Saves the or update <see cref="PaymentInData "/>
        /// </summary>
        /// <param name="subCaseTypeInfo">ISubCaseTypeInfo</param>
        void SaveOrUpdatePaymentInData(ISubCaseTypeInfo subCaseTypeInfo);

        /// <summary>
        /// Saves the or update payment in doc detail entity.
        /// </summary>
        /// <param name="paymentInDocDetailEntity">The payment in doc detail entity.</param>
        void SaveOrUpdatePaymentInDocDetailEntity(PaymentInDocDetailEntity paymentInDocDetailEntity);

        /// <summary>
        /// Saves the or update payment in doc FS detail.
        /// </summary>
        /// <param name="paymentInDocFSDetailEntity">The payment in doc FS detail entity.</param>
        void SaveOrUpdatePaymentInDocFSDetail(PaymentInDocFSDetailEntity paymentInDocFSDetailEntity);

        /// <summary>
        /// Saves the or update <see cref="PaymentOutData "/>
        /// </summary>
        /// <param name="subCaseTypeInfo">ISubCaseTypeInfo</param>
        void SaveOrUpdatePaymentOutData(ISubCaseTypeInfo subCaseTypeInfo);

        /// <summary>
        /// Saves the or update payment out doc detail entity.
        /// </summary>
        /// <param name="paymentOutDocDetailEntity">The payment out doc detail entity.</param>
        void SaveOrUpdatePaymentOutDocDetailEntity(PaymentOutDocDetailEntity paymentOutDocDetailEntity);

        /// <summary>
        /// Saves the or update payment out pay in detail entity.
        /// </summary>
        /// <param name="paymentOutPayInDetailEntity">The payment out pay in detail entity.</param>
        void SaveOrUpdatePaymentOutPayInDetailEntity(PaymentOutPayInDetailEntity paymentOutPayInDetailEntity);

        void SaveOrUpdateRARASInfoEntity(RARASInfoEntity rARASInfoEntity);

        /// <summary>
        /// Saves or Updates <see cref="RCaseLawFirmEntity"/>
        /// </summary>
        /// <param name="rCaseLawFirmEntity"></param>
        void SaveOrUpdateRCaseLawFirmEntity(RCaseLawFirmEntity rCaseLawFirmEntity);

        /// <summary>
        /// Saves or Updates <see cref="RCaseSubmissionEntity"/>
        /// </summary>
        /// <param name="rCaseSubmissionEntity"></param>
        void SaveOrUpdateRCaseSubmissionEntity(RCaseSubmissionEntity rCaseSubmissionEntity);

        /// <summary>
        /// Saves the or update R doc case entity.
        /// </summary>
        /// <param name="rDOCCaseEntity">The r DOC case entity.</param>
        void SaveOrUpdateRDocCaseEntity(RDocCaseEntity rDOCCaseEntity);

        /// <summary>
        /// Saves or Updates <see cref="RDocCasePartyEntity"/>
        /// </summary>
        /// <param name="rDocCasePartyEntity"></param>
        void SaveOrUpdateRDocCasePartyEntity(RDocCasePartyEntity rDocCasePartyEntity);

        /// <summary>
        /// Saves the or update ref caveat case entity.
        /// </summary>
        /// <param name="refCaveatCaseEntity">The ref caveat case entity.</param>
        void SaveOrUpdateRefCaveatCaseEntity(RefCaveatCaseEntity refCaveatCaseEntity);

        /// <summary>
        /// Saves or updates <see cref="RefOrderDetailEntity"/>
        /// </summary>
        /// <param name="refOrderEntity">The ref order entity.</param>
        void SaveOrUpdateRefOrderDetailEntity(RefOrderDetailEntity refOrderEntity);

        /// <summary>
        /// Saves the or update RSubCaseSubmission entity.
        /// </summary>
        /// <param name="rCaseSubmissionEntity">The r case submission entity.</param>
        void SaveOrUpdateRSubCaseSubmissionEntity(RSubCaseSubmissionEntity rSubCaseSubmissionEntity);

        /// <summary>
        /// Saves the or update <see cref="PaymentOutData "/>
        /// </summary>
        /// <param name="subCaseTypeInfo">The sub case type info.</param>
        void SaveOrUpdateServiceOfDocData(ISubCaseTypeInfo subCaseTypeInfo);

        /// <summary>
        /// Saves Or Update <see cref="ServiceOfDocDocStatusHistoryEntity"/>
        /// </summary>
        /// <param name="serviceOfDocDocStatusHistoryEntity">ServiceOfDocDocStatusHistoryEntity.</param>
        void SaveOrUpdateServiceOfDocDocStatusHistoryEntity(ServiceOfDocDocStatusHistoryEntity serviceOfDocDocStatusHistoryEntity);

        /// <summary>
        /// Saves or update ServiceOfDocDocumentEntity.
        /// </summary>
        /// <param name="serviceOfDocDocumentEntity">The service of doc document entity.</param>
        void SaveOrUpdateServiceOfDocDocumentEntity(ServiceOfDocDocumentEntity serviceOfDocDocumentEntity);

        /// <summary>
        /// Saves the or update service of doc info detail entity.
        /// </summary>
        /// <param name="serviceOfDocInfoDetailEntity">The service of doc info detail entity.</param>
        void SaveOrUpdateServiceOfDocInfoDetailEntity(ServiceOfDocInfoDetailEntity serviceOfDocInfoDetailEntity);

        /// <summary>
        /// Saves Or Update <see cref="ServiceOfDocInfoEntity"/>
        /// </summary>
        /// <param name="ServiceOfDocInfoEntity">ServiceOfDocInfoEntity.</param>
        void SaveOrUpdateServiceOfDocInfoEntity(ServiceOfDocInfoEntity serviceOfDocInfoEntity);

        /// <summary>
        /// Saves the or update sub case data.
        /// </summary>
        /// <param name="iSubCaseTypeInfo">The i sub case type info.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateSubCaseData(ISubCaseTypeInfo iSubCaseTypeInfo, bool isCopy);

        void SaveOrUpdateSubCaseEntity(ISubCaseEntity iSubCaseEntity, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubCaseSpecificEntity"/> interface.
        /// </summary>
        /// <param name="iSubCaseSpecificEntity"><see cref="ISubCaseSpecificEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateSubCaseSpecificEntity(ISubCaseSpecificEntity iSubCaseSpecificEntity, bool isCopy);


        /// <summary>
        /// Saves or updates <see cref="SubCaseInfoEntity"/>
        /// </summary>
        /// <param name="subCaseInfoEntity"></param>
        void SaveOrUpdateSubCaseInfoEntity(ISubCaseEntity iSubCaseInfo);

        /// <summary>
        /// Saves the or update sub case party entity.
        /// </summary>
        /// <param name="subCasePartyEntity">The sub case party entity.</param>
        void SaveOrUpdateSubCasePartyEntity(SubCasePartyEntity subCasePartyEntity);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubsequentEntity"/> interface.
        /// </summary>
        /// <param name="iSubsequentEntity"><see cref="ISubsequentEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateSubsequentEntity(ISubsequentEntity iSubsequentEntity, bool isCopy);

        /// <summary>
        /// Saves the or update unliquidated claim entity.
        /// </summary>
        /// <param name="UnliquidatedClaimEntity">The unliquidated claim entity.</param>
        void SaveOrUpdateUnliquidatedClaimEntity(UnliquidatedClaimEntity UnliquidatedClaimEntity);

        /// <summary>
        /// Gets the list WOE case execution address.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<WOECaseExecutionAddressEntity> GetListWOECaseExecutionAddress(long caseInfoId);

        /// <summary>
        /// Gets the list WOE case execution address.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <param name="subcaseInfoId">The subcase info id.</param>
        /// <returns></returns>
        List<WOECaseExecutionAddressEntity> GetListWOECaseExecutionAddress(long caseInfoId,long? subcaseInfoId);

        /// <summary>
        /// Gets the list ref sub case entity.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<RefSubCaseEntity> GetListRefSubCaseEntity(string submissionGroupId);

        /// <summary>
        /// Gets the ADMWA info entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ADMWAInfoEntity GetADMWAInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list doc comments entity by doc id.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<DocCommentsEntity> GetListDocCommentsEntityByDocId(string docId);

        /// <summary>
        /// Gets the list request doc detail entity by doc id.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<RequestDocDetailEntity> GetListRequestDocDetailEntityByDocId(string docId);

        /// <summary>
        /// Gets the list WOE request entity by SGID.
        /// </summary>
        /// <param name="sGID">The s GID.</param>
        /// <returns></returns>
        List<WOERequestEntity> GetListWOERequestEntityBySGID(string sGID);

        /// <summary>
        /// Gets the list appeal time estimation detail entity by SGID.
        /// </summary>
        /// <param name="sGID">The s GID.</param>
        /// <returns></returns>
        List<AppealTimeEstimationDetailEntity> GetListAppealTimeEstimationDetailEntityBySGID(string sGID);

        /// <summary>
        /// Deletes <see cref="CasePartyCriminalInfo"/>
        /// </summary>
        /// <param name="casePartyId">The CasePartyId.</param>
        void DeleteCasePartyCriminalInfo(string casePartyId);


        /// <summary>
        /// Promotes the refer affidavit BE.
        /// </summary>
        /// <param name="referAffidavitDocID">The refer affidavit doc ID.</param>
        /// <param name="WOSNUO_DocID">The WOSNU o_ doc ID.</param>
        /// <param name="promotedDocID">The promoted doc ID.</param>
        /// <param name="isSameForum">The is same forum.</param>
        void PromoteReferAffidavitBE(string referAffidavitDocID, string WOSNUO_DocID, string promotedDocID,string isSameForum);

        /// <summary>
        /// Gets the list notice to refer affidavit entity by SGID.
        /// </summary>
        /// <param name="sGID">The s GID.</param>
        /// <returns></returns>
        List<NoticeToReferAffidavitEntity> GetListNoticeToReferAffidavitEntityBySGID(string sGID);

        /// <summary>
        /// Gets the list prayer entity by SGID.
        /// </summary>
        /// <param name="sGID">The s GID.</param>
        /// <returns></returns>
        List<PrayerEntity> GetListPrayerEntityBySGID(string sGID);

        List<PrayerEntity> GetListPrayerEntityByHrgId(long? HRGId);

        List<OrdersMadeEntity> GetListOrdersMadeEntityByHrgId(long? HRGId);

        List<SubCasePartyEntity> GetListSubCasePartyEntityByCasePartyId(string casePartyId);

        List<SubCasePartyEntity> GetListSubCasePartyEntity(string casePartyId, string caseInfoId, string subCaseInfoId);

        ICaseTypeInfo GetRASDataBySGID(string submissionGroupId);

        List<NatureOfApplicationEntity> GetListNatureOfApplicationBySGID(string sGID);

        List<MSensitiveFilingACLEntity> GetAllMSensitiveFilingACL();

        /// <summary>
        /// Gets the R sub case submission entity by sub case info id.
        /// </summary>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <returns></returns>
        RSubCaseSubmissionEntity GetRSubCaseSubmissionEntityBySubCaseInfoId(string subCaseInfoId);

        /// <summary>
        /// Gets the list ref order JO info by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<RefOrderJOInfoEntity> GetListRefOrderJOInfoBySGID(string submissionGroupId);

        List<RequestHearingFeeDetailEntity> GetListRequestHearingFeeDetailBySGID(string submissionGroupId);


        List<SolicitorEntity> GetListSolicitorByCaseInfoId(string caseInfoId);

        List<SolicitorAddressEntity> GetListSolicitorAddressBySolicitorId(long solicitorId);

        void DeleteSolicitorAddress(long solicitorId);

        void SaveOrUpdateLawFirmEntity(ILawFirmEntity iLawFirmEntity, bool isCopy);

        RLawFirmSolicitorsEntity GetRLawFirmSolicitorsEntity(long solicitorId, string lFID);

        void SaveOrUpdateSolicitorAddress(SolicitorAddressEntity solicitorAddressEntity);

        void SaveOrUpdateRLawFirmSolicitor(RLawFirmSolicitorsEntity rLawFirmSolicitors);

        void SaveOrUpdateRLawFirmSolicitorHistory(RLawFirmSolicitorHistoryEntity rLawFirmSolicitorHistoryEntity);

        void DeleteRLawFirmSolicitors(long SolicitorId, string lFID);

        /// <summary>
        /// Deletes the case party citizenship by case party id.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        void DeleteCasePartyCitizenshipByCasePartyId(string casePartyId);


        /// <summary>
        /// Deletes the case party bailor addresses by case party bailor info id.
        /// </summary>
        /// <param name="casePartyBailorInfoId">The case party bailor info id.</param>
        void DeleteCasePartyBailorAddressesByCasePartyBailorInfoId(string casePartyBailorInfoId);


        /// <summary>
        /// Deletes the case party bailor info by case party id.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        void DeleteCasePartyBailorInfoByCasePartyId(string casePartyId);

        /// <summary>
        /// Gets the doc case tier type entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        DocCaseTierTypeEntity GetDocCaseTierTypeEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the divorce data by submission group id.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        ICaseTypeInfo GetDivorceDataBySubmissionGroupId(string submissionGroupId);

        List<ForeignLPSolicitorRegEntity> GetListForeignLPSolicitorRegEntityByCaseInfoId(string CaseInfoId);

        List<ForeignLPSolicitorRegEntity> GetListForeignLPSolicitorRegEntityBySGID(string sGID);

        /// <summary>
        /// Get the List<see cref="VoteInfoEntity"/>
        /// </summary>
        /// <param name="caseInfoId"></param>
        /// <returns>List<VoteInfoEntity></returns>
        List<VoteInfoEntity> GetListVoteInfoEntity(string caseInfoId);

        /// <summary>
        /// Get the List<see cref="VoteInfoDeltaEntity"/>
        /// </summary>
        /// <param name="caseInfoId"></param>
        /// <returns>List<VoteInfoDeltaEntity></returns>
        List<VoteInfoDeltaEntity> GetListVoteInfoDeltaEntity(string caseInfoId);

        /// <summary>
        /// Get the List<see cref="LawFirmDocCaseFileRefNumberEntity"/>
        /// </summary>
        /// <param name="SGID"></param>
        /// <returns>List<LawFirmDocCaseFileRefNumberEntity></returns>
        List<LawFirmDocCaseFileRefNumberEntity> GetListLawFirmDocCaseFileRefNumberEntity(string SGID);

        /// <summary>
        /// Deletes the CasePartyLacDetail
        /// </summary>
        /// <param name="casePartyId"></param>
        void DeleteCasePartyLACDetailByCasePartyId(string casePartyId);

        /// <summary>
        /// Deletes the <see cref="LawFirmCaseFileRefNumber"/>
        /// </summary>
        /// <param name="LFCFRNId"></param>
        void DeleteLawFirmCaseFileRefNumber(string LFCFRNId);

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
        /// Gets SolicitorId From MSequenceKey.
        /// </summary>
        /// <returns></returns>
        long GetSolicitorIdFromMSequenceKey();


        /// <summary>
        /// Increments SolicitorId By 1.
        /// </summary>
        void UpdateMSequenceKeySolicitorId();
                /// <summary>
        /// Gets the RFL validity and notification entityby sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        /// <returns></returns>
        List<RFLValidityAndNotificationEntity> GetRFLValidityAndNotificationEntitybySGID(string submissionGroupId);

        /// <summary>
        /// Gets the m document control forum entity by pk.
        /// </summary>
        /// <param name="primarykey">The primarykey.</param>
        /// <returns></returns>
        IMasterEntity GetMDocControlForumEntityByPK(string primarykey);

        /// <summary>
        /// Gets the list m document control forum by document code.
        /// </summary>
        /// <param name="docCode">The document code.</param>
        /// <returns></returns>
        List<MDocControlForumEntity> GetListMDocControlForumByDocCode(string docCode);

        /// <summary>
        /// Gets the sicc fee ledger by sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        List<SICCFeeLedgerEntity> GetSICCFeeLedgerBySGID(string submissionGroupId);

                /// <summary>
        /// Gets the rm document tier sensitive entity.
        /// </summary>
        /// <param name="forumID">The forum identifier.</param>
        /// <param name="casetypeCode">The casetype code.</param>
        /// <param name="docCode">The document code.</param>
        /// <returns></returns>
        RMDocTierSensitiveEntity GetRMDocTierSensitiveEntity(string forumID, string casetypeCode, string docCode);

                /// <summary>
        /// Gets the pc application dates from sal.
        /// </summary>
        /// <param name="Caseinfoid">The caseinfoid.</param>
        /// <param name="PCCaseYear">The pc case year.</param>
        /// <returns></returns>
        List<PCAppDatesFromSALEntity> GetPCAppDatesFromSAL(string Caseinfoid, decimal PCCaseYear);

        /// <summary>
        /// Gets the pc Request For Exemption from SGID.
        /// </summary>
        /// <param name="SGID"></param>
        /// <returns></returns>
        List<RequestForExemptionEntity> GetRequestForExemptionbySGID(string SGID);

        /// <summary>
        /// Gets the pc JMCheck list Info from DocId.
        /// </summary>
        /// <param name="docId"></param>
        /// <returns></returns>
        List<JMChecklistInfoEntity> GetListJMChecklistInfoEntityByDocId(string docId);

        /// <summary>
        /// Saves or UpdatesCopy <see cref="RCaseTransferEntity"/>
        /// </summary>
        /// <param name="rCaseTransferEntity"></param>
        void SaveOrUpdateRCaseTransferEntity(RCaseTransferEntity rCaseTransferEntity );

        /// <summary>
        /// Gets the pc JMCheck list Info from DocId.
        /// </summary>
        /// <param name="docId"></param>
        /// <returns></returns>
        List<JMOtherInfoEntity> GetListJMOtherInfo(string CaseInfoId);

        /// <summary>
        /// Gets the pc RMDocControlExclusion list Info from DocId.
        /// </summary>
        /// <param name="docId"></param>
        /// <returns></returns>
        List<RMDocControlExclusionEntity> GetListRMDocControlExclusionByDocCode(string DocCode);

        /// <summary>
        /// Gets the Fee Collection Detail SGID list Info from DocId.
        /// </summary>
        /// <param name="SGID"></param>
        /// <returns></returns>
        List<FeeCollectionDetailEntity> GetFeeCollectionDetailBySGID(string SGID);

        /// <summary>
        /// Gets the Fee Collection Detail Caseinfoid list Info from DocId.
        /// </summary>
        /// <param name="Caseinfoid"></param>
        /// <returns></returns>
        List<FeeCollectionDetailEntity> GetFeeCollectionDetailByCaseinfoid(string Caseinfoid);

        /// <summary>
        /// Gets the Fee Collection Detail list Info from DocId.
        /// </summary>
        /// <returns></returns>
        List<FeeCollectionDetailEntity> GetAllFeeCollectionDetail();

        /// <summary>
        /// Gets all Direction Details Entity.
        /// </summary>
        /// <returns></returns>
        List<DirectionDetailsEntity> GetAllDirectionDetails();

        /// <summary>
        /// Gets the Direction Details.
        /// </summary>
        /// <param name="optCaseInfoId"></param>
        /// <param name="optSubCaseinfoId"></param>
        /// <param name="optHrgId"></param>
        /// <param name="optDocId"></param>
        /// <param name="optDirCode"></param>
        /// <returns></returns>
        List<DirectionDetailsEntity> GetListDirectionDetailsByCaseInfoId(string Caseinfoid);

        /// <summary>
        /// Get List of LawFirmRegistrationEntity By LFID
        /// </summary>
        /// <param name="lfid"></param>
        /// <returns></returns>
        List<LawFirmRegistrationEntity> GetListLawFirmRegistrationEntityByLFID(string lfid);

        /// <summary>
        /// Get List of UpdateListOfLawFirmRegistration 
        /// </summary>
        /// <param name="lstLawFirmRegistrationEntity"></param>
        /// <returns></returns>
        void UpdateListOfLawFirmRegistration(IList<LawFirmRegistrationEntity> lstLawFirmRegistrationEntity);

        /// <summary>
        /// Gets the List of <see cref="DocLegalExperienceInfoEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<docLegalExperienceInfoEntity></returns>
        List<DocLegalExperienceInfoEntity> GetListDocLegalExperienceInfoEntityBySGID(string sGID);
       
        /// <summary>
        /// Gets the List of <see cref="CaseLegalExperienceInfoEntity"/>
        /// </summary>
        /// <param name="CaseInfoId">The case info id.</param>
        /// <returns>List<CaseLegalExperienceInfoEntity></returns>
        List<CaseLegalExperienceInfoEntity> GetListCaseLegalExperienceInfoByCaseInfoId(System.Int64 CaseInfoId);

        /// <summary>
        /// Gets the List of <see cref="CaseLegalExperienceInfoEntity"/>
        /// </summary>
        /// <param name="CaseInfoId">The case info id.</param>
        /// <param name="LFID">The case info id.</param>
        /// <returns>List<CaseLegalExperienceInfoEntity></returns>
        List<CaseLegalExperienceInfoEntity> GetListCaseLegalExperienceInfoByCaseInfoId(System.Int64 CaseInfoId, string LFID);

        /// <summary>
        /// Gets the List of <see cref="CORSolicitorRegEntity"/>
        /// </summary>
        /// <param name="CaseInfoId">The case info id.</param>
        /// <returns>List<CORSolicitorRegEntity></returns>
        List<CORSolicitorRegEntity> GetCORSolicitorRegByCaseInfoId(System.Int64 caseInfoId);

        /// <summary>
        /// Gets the List of <see cref="CORSolicitorRegDetailsEntity"/>
        /// </summary>
        /// <param name="CaseInfoId">The case info id.</param>
        /// <returns>List<CORSolicitorRegDetailsEntity></returns>
        List<CORSolicitorRegDetailsEntity> GetCORSolicitorRegDetailsBySubCaseInfoId(System.Int64 subCaseInfoId);

        /// <summary>
        /// Gets the List of <see cref="ChildInfoEntity"/>
        /// </summary>
        /// <param name="submissionGroupId">The submission Group id.</param>
        /// <returns>List<ChildInfoEntity></returns>
        List<ChildInfoEntity> GetChildInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list party case file reference number entity by case party id and Case info id.
        /// </summary>
        /// <param name="casePartyId">The case party identifier.</param>
        /// <param name="CaseInfoId">The CaseInfoId.</param>
        /// <returns></returns>
        List<PartyCaseFileRefNumberEntity> GetListPartyCaseFileRefNumberByCaseInfoIDAndPartyID(string casePartyId, string caseInfoId, string LFID);

        /// <summary>
        /// delete party case file reference number entity by case party id .
        /// </summary>
        /// <param name="casePartyId">The case party identifier.</param>
        /// <returns></returns>
        void DeletePartyCaseFileRefNumberByCasePartyID(string casePartyId);

        DocPartyCaseFileRefNumberEntity GetDocPartyCaseFileRefNumberEntityByDCPID(string dcpid);

        void SaveOrUpdatePartyCasefileRefNumberSP(PartyCaseFileRefNumberEntity partyCaseFileRefNumberEntity);

        List<DocCaseCounterClaimEntity> GetListDocCaseCounterClaimBySubmissionGroupID(System.String SGID);

        List<DocCaseCounterClaimDetailsEntity> GetListDocCaseCounterClaimDetailsBySubmissionGroupID(System.String SGID);
        
        void DeleteCaseCounterClaimDetailsByCaseCounterClaimID(System.String caseCounterClaimID);

        List<CaseCounterClaimDetailsEntity> GetListCaseCounterClaimDetailsByCaseCounterClaimID(System.String caseCounterClaimID);

        List<DocCaseCounterClaimEntity> GetListDocCaseCounterClaimByDocID(System.String docId);

        List<CaseCounterClaimEntity> GetListCaseCounterClaimByCaseCounterClaimID(System.String caseCounterClaimId);

        List<DocCaseCounterClaimDetailsEntity> GetListDocCaseCounterClaimDetailsByDocCaseCounterClaimID(System.String docCaseCounterClaimID);

        List<RDocCounterClaimFiledEntity> GetRDocCounterClaimFiledEntityBySubmissionGroupID(System.String submissionGroupID);
        
        #endregion Methods
    }
}