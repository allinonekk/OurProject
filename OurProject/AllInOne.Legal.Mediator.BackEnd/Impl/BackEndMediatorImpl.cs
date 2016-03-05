namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;
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
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Data;

    using log4net;
    using NHibernate;
    using AllInOne.Legal.Domain.LAP;

    public class BackEndMediatorImpl : IBackEndMediator
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(BackEndMediatorImpl));

        /// <summary>
        /// ApplicationSessionManager instance for session.
        /// </summary>
        private ApplicationSessionManager applicationSessionManager;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that 
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        /// <param name="sender"></param>
        public void BeginTransaction()
        {
            Logger.Info("BeginTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager = new ApplicationSessionManager();
            this.applicationSessionManager.BeginTransaction();

            Logger.Info("BeginTransaction ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Close the session.
        /// </summary>
        public void CloseSession()
        {
            Logger.Info("WorkflowEngineMediatorImpl - CloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager = new ApplicationSessionManager();
            this.applicationSessionManager.CloseSession();

            Logger.Info("WorkflowEngineMediatorImpl - CloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        public void CommitAndCloseSession()
        {
            Logger.Info("BackEndMediatorImpl - CommitAndCloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager = new ApplicationSessionManager();
            this.applicationSessionManager.CommitAndCloseSession();

            Logger.Info("BackEndMediatorImpl - CommitAndCloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Commit the transaction.
        /// </summary>
        public void CommitTransaction()
        {
            Logger.Info("WorkflowEngineMediatorImpl - CommitTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager = new ApplicationSessionManager();
            this.applicationSessionManager.CommitTransaction();

            Logger.Info("WorkflowEngineMediatorImpl - CommitTransaction ended at " + DateTime.Now.ToString());
        }

        public void DeleteAffidavitDeponentDetailList(string affidavitId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteAffidavitDeponentDetailList(affidavitId);
        }

        public void DeleteAffidavitInfoList(string caseInfoId, string subCaseInfoId, string docId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteAffidavitInfoList(caseInfoId, subCaseInfoId, docId);
        }

        public void DeleteAppealsDataBySGID(string submissionGroupId)
        {
            AppealsGateway appealsGateway = new AppealsGateway();
            appealsGateway.DeleteAppealsDataBySGID(submissionGroupId);
        }

        /* End of Criminal Case Specifics Delete */
        /* Start of Criminal Specifics SaveOrUpdate*/
        /*
        /// <summary>
        /// Save or Update CasePartyCriminalInfoEntity ;
        /// </summary>
        /// <param name="casePartyCriminalInfoEntity">The entity object to be saved into DB</param>
        public void SaveOrUpdateCasePartyCriminalInfoEntity(CasePartyCriminalInfoEntity casePartyCriminalInfoEntity)
        {
            CaseGateway gateway = new CaseGateway();
            gateway.SaveOrUpdateCasePartyCriminalInfoEntity(casePartyCriminalInfoEntity);

        }

        /// <summary>
        /// Save or Update CasePartyBailorInfoEntity ;
        /// </summary>
        /// <param name="casePartyBailorInfoEntity">The entity object to be saved into DB</param>
        public void SaveOrUpdateCasePartyBailorInfoEntity(CasePartyBailorInfoEntity casePartyBailorInfoEntity)
        {
            CaseGateway gateway = new CaseGateway();
            gateway.SaveOrUpdateCasePartyBailorInfoEntity(casePartyBailorInfoEntity);

        }

        /// <summary>
        /// Save or Update CasePartyBailorAddressEntity ;
        /// </summary>
        /// <param name="casePartyBailorAddressEntity">The entity object to be saved into DB</param>
        public void SaveOrUpdateCasePartyBailorAddressEntity(CasePartyBailorAddressEntity casePartyBailorAddressEntity)
        {
            CaseGateway gateway = new CaseGateway();
            gateway.SaveOrUpdateCasePartyBailorAddressEntity(casePartyBailorAddressEntity);

        }

        /// <summary>
        /// Save or Update DocCasePartyCriminalInfoEntity ;
        /// </summary>
        /// <param name="docCasePartyCriminalInfoEntity">The entity object to be saved into DB</param>
        public void SaveOrUpdateDocCasePartyCriminalInfoEntity(DocCasePartyCriminalInfoEntity docCasePartyCriminalInfoEntity)
        {
            DocumentGateway gateway = new DocumentGateway();
            gateway.SaveOrUpdateDocCasePartyCriminalInfoEntity(docCasePartyCriminalInfoEntity);

        }

        /// <summary>
        /// Save or Update DocCasePartyBailorInfoEntity ;
        /// </summary>
        /// <param name="docCasePartyBailorInfoEntity">The entity object to be saved into DB</param>
        public void SaveOrUpdateDocCasePartyBailorInfoEntity(DocCasePartyBailorInfoEntity docCasePartyBailorInfoEntity)
        {
            DocumentGateway gateway = new DocumentGateway();
            gateway.SaveOrUpdateDocCasePartyBailorInfoEntity(docCasePartyBailorInfoEntity);

        }

        /// <summary>
        /// Save or Update DocCasePartyBailorAddressEntity ;
        /// </summary>
        /// <param name="docCasePartyBailorAddressEntity">The entity object to be saved into DB</param>
        public void SaveOrUpdateDocCasePartyBailorAddressEntity(DocCasePartyBailorAddressEntity docCasePartyBailorAddressEntity)
        {
            DocumentGateway gateway = new DocumentGateway();
            gateway.SaveOrUpdateDocCasePartyBailorAddressEntity(docCasePartyBailorAddressEntity);

        }
        */
        /* End of Criminal Specifics SaveOrUpdate*/
        public void DeleteCaseInfoByPK(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCaseInfoByPK(caseInfoId);
        }

        public void DeleteCaseOriginatingCaseList(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCaseOriginatingCaseList(caseInfoId);
        }

        public void DeleteCasePartyAddressList(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyAddressList(casePartyId);
        }

        public void DeleteCasePartyAICAddressList(string aICID)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyAICAddressList(aICID);
        }

        public void DeleteCasePartyAICAliasList(string aICID)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyAICAliasList(aICID);
        }

        public void DeleteCasePartyAICDetailsList(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyAICDetailsList(casePartyId);
        }

        public void DeleteCasePartyAliasList(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyAliasList(casePartyId);
        }

        public void DeleteCasePartyAuthorisedOfficerDetailsList(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyAuthorisedOfficerDetailsList(casePartyId);
        }

        public void DeleteCasePartyBailorAddress(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyBailorAddressByCasePartyId(casePartyId);
        }

        public void DeleteCasePartyBailorInfo(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyBailorInfoByCasePartyId(casePartyId);
        }

        public void DeleteCasePartyCriminalInfo(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyCriminalInfoByCasePartyId(casePartyId);
        }

        public void DeleteCasePartyDataList(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyDataList(caseInfoId);
        }

        public void DeleteCasePartyList(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyList(caseInfoId);
        }

        public void DeleteCasePartyNodes(string casePartyId)
        {
            DeleteCasePartyAddressList(casePartyId);
            DeleteCaseSolicitor(casePartyId);
            DeleteCasePartyAliasList(casePartyId);
            DeleteCasePartyAICAliasListByCasePartyId(casePartyId);
            DeleteCasePartyAICAddressListByCasePartyId(casePartyId);//TODO:Check
            DeleteCasePartyAICDetailsList(casePartyId);
            DeleteCasePartyLACDetail(casePartyId);
            DeleteCasePartyCitizenship(casePartyId);
            DeleteCasePartyBailorAddress(casePartyId);
            DeleteCasePartyBailorInfo(casePartyId);
            DeleteCasePartyCriminalInfo(casePartyId);
            DeleteCaseParty(casePartyId);
        }

        public void DeleteCasePartyVesselDetail(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyVesselDetail(casePartyId);
        }

        public void DeleteCaseSolicitorHistoryList(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCaseSolicitorHistoryList(caseInfoId);
        }

        public void DeleteCaseSolicitorList(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCaseSolicitorList(caseInfoId);
        }

        public void DeleteCaseSolicitorListByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCaseSolicitorListByCasePartyId(casePartyId);
        }

        public void DeleteCertSecurityOfCostsInfoList(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteCertSecurityOfCostsInfoList(submissionGroupId);
        }

        public void DeleteChargeInfoEntityByObject(ChargeInfoEntity chargeInfoEntity)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteChargeInfoEntityByObject(chargeInfoEntity);
        }

        public void DeleteChargeInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteChargeInfoEntityBySGID(submissionGroupId);
        }

        public void DeleteCriminalInfoEntityByObject(CriminalInfoEntity criminalInfoEntity)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteCriminalInfoEntityByObject(criminalInfoEntity);
        }

        /* End of Criminal Doc Case Data */
        /* Criminal Case Specifics Delete */
        public void DeleteCriminalInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteCriminalInfoEntityBySGID(submissionGroupId);
        }

        public void DeleteCriminalOtherOrderInfoEntityByObject(CriminalOtherOrderInfoEntity criminalOtherOrderInfoEntity)
        {
            ;
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteCriminalOtherOrderInfoEntityByObject(criminalOtherOrderInfoEntity);
        }

        public void DeleteCriminalOtherOrderInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteCriminalOtherOrderInfoEntityBySGID(submissionGroupId);
        }

        public void DeleteCWUDataBySGID(string submissionGroupId)
        {
            CWUGateway cWUGateway = new CWUGateway();
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteOtherITMOList(submissionGroupId);
            commonGateway.DeleteNatureOfCaseList(submissionGroupId);
            commonGateway.DeleteLiquidatorList(submissionGroupId);
            commonGateway.DeleteLegislationProvisionsList(submissionGroupId);
            cWUGateway.DeleteCWUInfo(submissionGroupId);
        }

        public void DeleteDCACAInfoBySGID(string submissionGroupId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            caseSpecificGateway.DeleteDCACAInfo(submissionGroupId);
        }

        public void DeleteDocCasePartyBailorAddress(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCasePartyBailorAddressByDCPId(dcpId);
        }

        public void DeleteDocCasePartyBailorInfo(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCasePartyBailorInfoByDCPId(dcpId);
        }

        public void DeleteDocCasePartyCriminalInfo(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCasePartyCriminalInfoByDCPId(dcpId);
        }

        public void DeleteDocCasePartyNodes(string caseInfoId, string dcpId)
        {
            //DeleteADMWAInfo(caseInfoId, dcpId);
            DeletePADeedRoles(caseInfoId, dcpId);
            DeleteOSPDRelation(caseInfoId, dcpId);
            DeleteDocCasePartyAddress(caseInfoId, dcpId);
            DeleteDocCaseSolicitor(caseInfoId, dcpId);
            DeleteDocCasePartyAlias(caseInfoId, dcpId);
            DeleteDocCasePartyAICAlias(caseInfoId, dcpId);
            DeleteDocCasePartyAICAddress(caseInfoId, dcpId);
            DeleteDocCasePartyAICDetails(caseInfoId, dcpId);
            DeleteRDocCaseParty(caseInfoId, dcpId);
            DeleteDocCasePartyLACDetail(dcpId);
            DeleteDocCasePartyCitizenshipByDcpId(dcpId);
            DeleteDocCasePartyBailorAddress(dcpId);
            DeleteDocCasePartyBailorInfo(dcpId);
            DeleteDocCasePartyCriminalInfo(dcpId);
            DeleteDocCaseParty(caseInfoId, dcpId);
        }

        public void DeleteDocCaseSolicitorList(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCaseSolicitorByDcpId(dcpId);
        }

        public void DeleteDocOrderDetailsList(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocOrderDetails(docId);
        }

        public void DeleteDocRequestDetailsList(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocRequestDetailsList(docId);
        }

        public void DeleteDocumentInfo(string caseInfoId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocumentInfoByCaseInfoId(caseInfoId);
        }

        public void DeleteDocumentInfoEntity(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocumentInfo(docId);
        }

        public void DeleteDocumentInfoList(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteDocumentInfoList(caseInfoId);
        }

        public void DeleteDrugInfoEntityByObject(DrugInfoEntity drugInfoEntity)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteDrugInfoEntityByObject(drugInfoEntity);
        }

        public void DeleteDrugInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteDrugInfoEntityBySGID(submissionGroupId);
        }

        public void DeleteIndexDocDetailEntity(string indexDocInfoId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            backEndSpecificGateway.DeleteIndexDocDetail(indexDocInfoId);
        }

        public void DeleteIndexDocInfoEntity(string docId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            backEndSpecificGateway.DeleteIndexDocInfo(docId);
        }

        public void DeleteInterfaceCriminalEntityByCaseNo(string caseNo)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            backEndSpecificGateway.DeleteInterfaceCriminalEntityByCaseNo(caseNo);
        }

        public void DeleteInvestigatingOfficerInfoEntityByObject(InvestigatingOfficerInfoEntity investigatingOfficerInfoEntity)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteInvestigatingOfficerInfoEntityByObject(investigatingOfficerInfoEntity);
        }

        public void DeleteInvestigatingOfficerInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteInvestigatingOfficerInfoEntityBySGID(submissionGroupId);
        }

        public void DeleteLawFirmCaseFileRefNumberList(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteLawFirmCaseFileRefNumberList(caseInfoId);
        }

        public void DeleteLegislationProvisionsList(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteLegislationProvisionsList(submissionGroupId);
        }

        public void DeleteNatureOfApplicationListByCaseInfoId(string caseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteNatureOfApplicationListByCaseInfoId(caseInfoId);
        }

        public void DeleteNatureOfApplicationListBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteNatureOfApplicationList(submissionGroupId);
        }

        public void DeleteNatureOfCaseByCaseInfoId(string caseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteNatureOfCaseListByCaseInfoId(caseInfoId);
        }

        public void DeleteNatureOfCaseBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteNatureOfCaseList(submissionGroupId);
        }

        public void DeleteOffenceInfoEntityByObject(OffenceInfoEntity offenceInfoEntity)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteOffenceInfoEntityByObject(offenceInfoEntity);
        }

        public void DeleteOffenceInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteOffenceInfoEntityBySGID(submissionGroupId);
        }

        public void DeleteOGCIncomingQueueEntity(string oGCIncomingQueueId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            backEndSpecificGateway.DeleteOGCIncomingQueueEntity(oGCIncomingQueueId);
        }

        public void DeleteOriginatingCaseList(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteOriginatingCaseList(caseInfoId);
        }

        public void DeleteOriginatingCaseListBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteOriginatingCaseBySGID(submissionGroupId);
        }

        public void DeleteOtherITMOList(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteOtherITMOList(submissionGroupId);
        }

        public void DeletePADeedRoles(string caseInfoId, string dcpId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeletePADeedRoles(caseInfoId, dcpId);
        }

        public void DeleteRAccusedStatementInfoEntityByCasePartyId(string casePartyId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            subsequentGateway.DeleteRAccusedStatementInfoEntityByCasePartyId(casePartyId);
        }

        public void DeleteRAccusedStatementInfoEntityByDocId(string docId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            subsequentGateway.DeleteRAccusedStatementInfoEntityByDocId(docId);
        }

        public void DeleteRAccusedStatementInfoEntityByDocIdsCasePartyIds(List<string> docIds, List<string> casePartyIds)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            subsequentGateway.DeleteRAccusedStatementInfoEntityByDocIdsCasePartyIds(docIds, casePartyIds);
        }

        public void DeleteRCaseLawFirmList(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteRCaseLawFirmList(caseInfoId);
        }

        public void DeleteRCaseSubmissionList(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteRCaseSubmissionList(caseInfoId);
        }

        public void DeleteRCaseTransfer(string forCaseInfoId)
        {
        }

        public void DeleteRCriminalLegislationInfoEntityByObject(RCriminalLegislationInfoEntity rCriminalLegislationInfoEntity)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteRCriminalLegislationInfoEntityByObject(rCriminalLegislationInfoEntity);
        }

        public void DeleteRCriminalLegislationInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteRCriminalLegislationInfoEntityBySGID(submissionGroupId);
        }

        public void DeleteRDocCaseList(string docId, string caseInfoId, string subCaseInfoId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteRDocCaseList(docId, caseInfoId, subCaseInfoId);
        }

        public void DeleteRDocCasePartyList(string dcpId, string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteRDocCasePartyList(dcpId, docId);
        }

        public void DeleteRefOrderDetailBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteRefOrderDetailList(submissionGroupId);
        }

        public void DeleteRefSubCaseBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteRefSubCaseList(submissionGroupId);
        }

        public void DeleteRegistrarsAppealsDataBySGID(string submissionGroupId)
        {
            AppealsGateway appealsGateway = new AppealsGateway();
            appealsGateway.DeleteRegistrarsAppealsDataBySGID(submissionGroupId);
        }

        public void DeleteRSubCaseSubmissionList(string subCaseInfoId, string submissionGroupId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteRSubCaseSubmissionList(subCaseInfoId, submissionGroupId);
        }

        public void DeleteSentenceInfoEntityByObject(SentenceInfoEntity sentenceInfoEntity)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteSentenceInfoEntityByObject(sentenceInfoEntity);
        }

        public void DeleteSentenceInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            gateway.DeleteSentenceInfoEntityBySGID(submissionGroupId);
        }

        public void DeleteSubCaseInfoList(string caseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            subCaseGateway.DeleteSubCaseInfoList(caseInfoId);
        }

        public void DeleteSubCasePartyList(string caseInoId, string subCaseInfoId, string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteSubCasePartyList(caseInoId, subCaseInfoId, casePartyId);
        }

        public void DeleteSubmissionInfoList(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteSubmissionInfoList(submissionGroupId);
        }

        public void DeleteWitnessInfoEntityBySubmissionGroupId(string submissionGroupId)
        {
            DocumentGateway docGateway = new DocumentGateway();
            List<DocumentInfoEntity> listDocInfo = docGateway.GetListDocumentInfoBySubmissinId(submissionGroupId);

            List<string> docIds = new List<string>();
            if ((listDocInfo != null) && (listDocInfo.Count > 0))
            {
                foreach (DocumentInfoEntity docEntity in listDocInfo)
                    docIds.Add(docEntity.DocId);
            }

            SubsequentGateway subsequentGateway = new SubsequentGateway();
            subsequentGateway.DeleteWitnessInfoEntityByDocIds(docIds);
        }

        public void DeleteWOEExecutionAddressEntityBySGID(string submissionGroupId)
        {
            CommonGateway gateway = new CommonGateway();
            gateway.DeleteWOEExecutionAddressEntityBySGID(submissionGroupId);
        }

        public void DeleteWOERequestEntityBySubmissionGroupId(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            subsequentGateway.DeleteWOERequestEntityBySubmissionGroupId(submissionGroupId);
        }

        public List<RUserPAEntity> GetRUserPAEntityByUserId(string userId)
        {
            BackEndSpecificGateway gateway = new BackEndSpecificGateway();
            return gateway.GetRUserPAEntityByUserId(userId);
        }

        public List<OGCIncomingQueueEntity> GetAllOGCIncomingQueueEntity()
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetAllOGCIncomingQueueEntity();
        }

        public ICaseTypeInfo GetAppealsDataBySGID(string SGID)
        {
            AppealsGateway gateway = new AppealsGateway();
            return gateway.GetAppealsData(SGID);
        }

        public BTSRoutingQueueEntity GetBTSRoutingQueueEntityByMessageId(string messageId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetBTSRoutingQueue(messageId);
        }

        public ICaseEntity GetByPK<T>(string value)
        {
            GenericGateway genericGateway = new GenericGateway();
            return genericGateway.GetEntity<T>(value);
        }

        public CaseInfoEntity GetCaseInfoEntityByPk(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCaseInfoByPK(caseInfoId);
        }

        public List<CaseIssueListEntity> GetCaseIssueListByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCaseIssueListByCaseInfoId(caseInfoId);
        }

        public CaseLatestDocumentsEntity GetCaseLatestDocumentsEntity(string caseInfoId, string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetCaseLatestDocuments(caseInfoId, docId);
        }

        public List<CaseNoteEntity> GetCaseNoteEntity(string caseInfoId)
        {
            throw new NotImplementedException();
        }

        public CasePartyData GetCasePartyDataByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return (CasePartyData)caseGateway.GetCasePartyData(casePartyId);
        }

        public List<CaseReminderEntity> GetCaseReminderEntity(string caseInfoId)
        {
            throw new NotImplementedException();
        }

        public List<CaseSealingInstructionEntity> GetCaseSealingInstructionEntity(string caseInfoId)
        {
            throw new NotImplementedException();
        }

        public ICasePartyData GetCriminalCasePartyData(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCriminalCasePartyData(casePartyId);
        }

        public CriminalCasePartyData GetCriminalCasePartyDataByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return (CriminalCasePartyData)caseGateway.GetCriminalCasePartyData(casePartyId);
        }

        public CriminalData GetCriminalDataBySGID(string SGID)
        {
            CaseDataGateway gateway = new CaseDataGateway();
            return gateway.GetCriminalDataBySGID(SGID);
        }

        public IDocCasePartyData GetCriminalDocCasePartyData(string dCPID)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetCriminalDocCasePartyData(dCPID);
        }

        /* End of Criminal Finance Getters*/
        /* Start of Criminal Specifics Getters */
        public CriminalInfoEntity GetCriminalInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetCriminalInfoEntityBySGID(submissionGroupId);
        }

        public ICaseTypeInfo GetCWUDataBySGID(string SGID)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetCWUDataBySGID(SGID);
        }

        public DCACAInfoEntity GetDCACAInfoEntityBySGID(string submissionGroupId)
        {
            AppealsGateway gateway = new AppealsGateway();
            return gateway.GetDCACAInfoEntityBySGID(submissionGroupId);
        }

        public ICaseTypeInfo GetDivorceDataBySubmissionGroupId(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetDivorceData(submissionGroupId);
        }

        public DocCasePartyEntity GetDocCasePartyByPK(string DCPId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCaseParty(DCPId);
        }

        public IDocCasePartyData GetDocCasePartyData(string dCPID)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCasePartyData(dCPID);
        }

        public DocumentInfoEntity GetDocumentInfoByPK(string docId)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoByPK(docId);
        }

        public ICaseTypeInfo GetEnforcementDataBySubmissionGroupId(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetEnforcementDataBySGID(submissionGroupId);
        }

        public HearingEntity GetHearingEntityByPk(long hrgId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetHearingByPK(hrgId);
        }

        public IndexDocInfoEntity GetIndexDocInfoEntityByPK(string indexDocInfoId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetIndexDocInfoByPK(indexDocInfoId);
        }

        public List<IndexDocInfoEntity> GetIndexDocInfoEntityList(string indexDocInfoId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetGetIndexDocInfoEntity(indexDocInfoId);
        }

        public InterfaceCriminalEntity GetInterfaceCriminalEntityByCaseNo(string caseNo)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetInterfaceCriminalEntityByCaseNo(caseNo);
        }

        public JudicialUserEntity GetJudicialUserByPK(string userId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetJudicialUserEntityByPK(userId);
        }

        public LawFirmEntity GetLawFirmEntityByPK(string LFId)
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            return lawFirmGateway.GetLawFirmByPK(LFId);
        }

        public List<AffidavitDeponentDetailEntity> GetListAffidavitDeponentDetail(string affidavitId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListAffidavitDeponentDetailEntityByAffidavitId(affidavitId);
        }

        public List<AffidavitInfoEntity> GetListAffidavitInfoEntity(string caseInfoId, string subCaseInfoId, string docId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListAffidavitInfoEntity(caseInfoId, subCaseInfoId, docId);
        }

        public List<ICaseEntity> GetListCaseEntity<T>(Dictionary<string, object> values)
        {
            GenericGateway genericGateway = new GenericGateway();
            return genericGateway.GetListCaseEntity<T>(values);
        }

        public List<CaseHearingAccessibilityHistoryEntity> GetListCaseHearingAccessibilityHistoryEntity(string caseInfoId)
        {
            throw new NotImplementedException();
        }

        public List<CaseInfoEntity> GetListCaseInfoByTrimCaseNo(string caseNo)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseInfoByTrimCaseNo(caseNo);
        }

        /// <summary>
        /// Gets the list case info entity.
        /// </summary>
        /// <param name="caseNo">The case no.</param>
        /// <returns></returns>
        public List<CaseInfoEntity> GetListCaseInfoEntity(string caseNo)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseInfoEntityCaseNo(caseNo);
        }

        public List<CaseInfoEntity> GetListCaseInfoEntityByExactCaseNo(string caseNo)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseInfoEntityByExactCaseNo(caseNo);
        }

        public List<CaseNameIndHistoryEntity> GetListCaseNameIndHistoryEntity(string caseInfoId)
        {
            throw new NotImplementedException();
        }

        public List<CaseOriginatingCaseEntity> GetListCaseOriginatingCaseByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseOriginatingCase(caseInfoId);
        }

        public List<CasePartyAddressEntity> GetListCasePartyAddressEntity(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyAddress(casePartyId);
        }

        public List<CasePartyAICAddressEntity> GetListCasePartyAICAddressEntity(string aICId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyAICAddress(aICId);
        }

        public List<CasePartyAICAliasEntity> GetListCasePartyAICAliasEntity(string aICId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyAICAlias(aICId);
        }

        public List<CasePartyAICDetailsEntity> GetListCasePartyAICDetailsEntity(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyAICDetailsWithChildByCasePartyId(casePartyId);
        }

        public List<CasePartyAliasEntity> GetListCasePartyAliasEntity(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyAlias(casePartyId);
        }

        public List<CasePartyAuthorisedOfficerDetailsEntity> GetListCasePartyAuthorisedOfficerDetailsEntity(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyAuthorisedOfficerDetail(casePartyId);
        }

        public List<CasePartyBailorAddressEntity> GetListCasePartyBailorAddressEntityByCasePartyId(string casePartyId)
        {
            CaseGateway gateway = new CaseGateway();
            return gateway.GetListCasePartyBailorAddressEntityByCasePartyId(casePartyId);
        }

        public List<CasePartyBailorInfoEntity> GetListCasePartyBailorInfoEntityByCasePartyId(string casePartyId)
        {
            CaseGateway gateway = new CaseGateway();
            return gateway.GetListCasePartyBailorInfoEntityByCasePartyId(casePartyId);
        }

        public List<CasePartyEntity> GetListCasePartyByCaseNumber(string caseNo)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyEntityByCaseNumber(caseNo);
        }

        public List<CasePartyEntity> GetListCasePartyByTrimCaseNo(string caseNo)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyByTrimCaseNo(caseNo);
        }

        /* End of Criminal Specifics Getters */
        /* Criminal Case Data */
        public List<CasePartyCriminalInfoEntity> GetListCasePartyCriminalInfoEntityByCasePartyId(string casePartyId)
        {
            CaseGateway gateway = new CaseGateway();
            return gateway.GetListCasePartyCriminalInfoEntityByCasePartyId(casePartyId);
        }

        public List<CasePartyData> GetListCasePartyData(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyData(caseInfoId);
        }

        public List<CasePartyEntity> GetListCasePartyEntityByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyByCaseInfoId(caseInfoId);
        }

        public List<CasePartyStatusHistoryEntity> GetListCasePartyStatusHistoryEntity(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyStatusHistory(casePartyId);
        }

        public List<CasePartyVesselDetailsEntity> GetListCasePartyVesselDetailsEntity(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyVesselDetail(casePartyId);
        }

        public List<CaseSolicitorEntity> GetListCaseSolicitorEntity(string caseInfoId, string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseSolicitor(caseInfoId, casePartyId);
        }

        public List<CaseSolicitorEntity> GetListCaseSolicitorEntityByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseSolicitorByCaseInfoId(caseInfoId);
        }

        public List<CaseSolicitorHistoryEntity> GetListCaseSolicitorHistoryEntity(string caseInfoId, string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseSolicitorHistory(caseInfoId, casePartyId);
        }

        public List<CaseSolicitorHistoryEntity> GetListCaseSolicitorHistoryEntityByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseSolicitorHistoryByCaseInfoId(caseInfoId);
        }

        //TODO: CaseStatusHistory NHibernate Entity
        public List<CaseStatusHistoryEntity> GetListCaseStatusHistoryByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            //caseGateway .GetListCaseSatusHis
            return null;
        }

        public List<CertSecurityOfCostsInfoEntity> GetListCertSecurityOfCostsInfo(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListCertSecurityOfCostsInfo(submissionGroupId);
        }

        public List<ChargeInfoEntity> GetListChargeInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListChargeInfoEntityBySGID(submissionGroupId);
        }

        public List<ChecklistInstanceEntity> GetListCheckListInstanceByCaseInfoId(string caseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListChecklistInstanceEntityByCaseInfoId(caseInfoId);
        }

        public List<ChecklistSubmissionEntity> GetListChecklistSubmissionEntityByCaseInfoId(string checkListInstanceId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListChecklistSubmissionEntityByCheckListInstanceId(checkListInstanceId);
        }

        /* Criminal Finance Getters*/
        /// <summary>
        /// Get a list of CriminalClaimHonorariumInfoEntity> by criminalClaimHonorariumInfoId;
        /// </summary>
        /// <param name="criminalClaimHonorariumInfoId">The criminalClaimHonorariumInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimHonorariumInfoEntity></returns>
        public List<CriminalClaimHonorariumInfoEntity> GetListCriminalClaimHonorariumInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId)
        {
            BackEndSpecificGateway gateway = new BackEndSpecificGateway();
            return gateway.GetListCriminalClaimHonorariumInfoEntityByCriminalClaimInfoId(criminalClaimInfoId);
        }

        /// <summary>
        /// Get a list of CriminalClaimInfoEntity> by caseInfoId;
        /// </summary>
        /// <param name="caseInfoId">The caseInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimInfoEntity></returns>
        public List<CriminalClaimInfoEntity> GetListCriminalClaimInfoEntityByCaseInfoId(long caseInfoId)
        {
            BackEndSpecificGateway gateway = new BackEndSpecificGateway();
            return gateway.GetListCriminalClaimInfoEntityByCaseInfoId(caseInfoId);
        }

        /// <summary>
        /// Get a list of CriminalClaimInfoEntity> by criminalClaimInfoId;
        /// </summary>
        /// <param name="criminalClaimInfoId">The criminalClaimInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimInfoEntity></returns>
        public List<CriminalClaimInfoEntity> GetListCriminalClaimInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId)
        {
            BackEndSpecificGateway gateway = new BackEndSpecificGateway();
            return gateway.GetListCriminalClaimInfoEntityByCriminalClaimInfoId(criminalClaimInfoId);
        }

        /// <summary>
        /// Get a list of CriminalClaimInterpreterFeeInfoEntity> by criminalClaimInterpreterFeeInfoId;
        /// </summary>
        /// <param name="criminalClaimInterpreterFeeInfoId">The criminalClaimInterpreterFeeInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimInterpreterFeeInfoEntity></returns>
        public List<CriminalClaimInterpreterFeeInfoEntity> GetListCriminalClaimInterpreterFeeInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId)
        {
            BackEndSpecificGateway gateway = new BackEndSpecificGateway();
            return gateway.GetListCriminalClaimInterpreterFeeInfoEntityByCriminalClaimInfoId(criminalClaimInfoId);
        }

        /// <summary>
        /// Get a list of CriminalClaimMiscellaneousInfoEntity> by criminalClaimMiscellaneousInfoId;
        /// </summary>
        /// <param name="criminalClaimMiscellaneousInfoId">The criminalClaimMiscellaneousInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimMiscellaneousInfoEntity></returns>
        public List<CriminalClaimMiscellaneousInfoEntity> GetListCriminalClaimMiscellaneousInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId)
        {
            BackEndSpecificGateway gateway = new BackEndSpecificGateway();
            return gateway.GetListCriminalClaimMiscellaneousInfoEntityByCriminalClaimInfoId(criminalClaimInfoId);
        }

        /// <summary>
        /// Get a list of CriminalClaimProfessionalFeeInfoEntity> by criminalClaimProfessionalFeeInfoId;
        /// </summary>
        /// <param name="criminalClaimProfessionalFeeInfoId">The criminalClaimProfessionalFeeInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimProfessionalFeeInfoEntity></returns>
        public List<CriminalClaimProfessionalFeeInfoEntity> GetListCriminalClaimProfessionalFeeInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId)
        {
            BackEndSpecificGateway gateway = new BackEndSpecificGateway();
            return gateway.GetListCriminalClaimProfessionalFeeInfoEntityByCriminalClaimInfoId(criminalClaimInfoId);
        }

        /// <summary>
        /// Get a list of CriminalClaimWitnessInfoEntity> by criminalClaimWitnessInfoId;
        /// </summary>
        /// <param name="criminalClaimWitnessInfoId">The criminalClaimWitnessInfoId of the field to filter while retrieving the objects.</param>
        /// <returns>List<CriminalClaimWitnessInfoEntity></returns>
        public List<CriminalClaimWitnessInfoEntity> GetListCriminalClaimWitnessInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId)
        {
            BackEndSpecificGateway gateway = new BackEndSpecificGateway();
            return gateway.GetListCriminalClaimWitnessInfoEntityByCriminalClaimInfoId(criminalClaimInfoId);
        }

        public List<CriminalInfoEntity> GetListCriminalInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListCriminalInfoEntityBySGID(submissionGroupId);
        }

        public List<CriminalOtherOrderInfoEntity> GetListCriminalOtherOrderInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListCriminalOtherOrderInfoEntityBySGID(submissionGroupId);
        }

        public List<DisWithDocPtyDetailEntity> GetListDisWithDocPtyDetailEntityBySGID(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListDisWithDocPtyDetailBySGID(submissionGroupId);
        }

        public List<DocCasePartyAddressEntity> GetListDocCasePartyAddressByDcpId(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyAddressByDCPID(dcpId);
        }

        public List<DocCasePartyAICAddressEntity> GetListDocCasePartyAICAddressEntity(string dCPAICId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyAICAddressByDCPAICID(dCPAICId);
        }

        public List<DocCasePartyAICAliasEntity> GetListDocCasePartyAICAliasEntity(string dCPAICId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyAICAliasByDCPAICID(dCPAICId);
        }

        public List<DocCasePartyAICDetailsEntity> GetListDocCasePartyAICDetailsEntityByDcpId(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyAICDetailsByDCPID(dcpId);
        }

        public List<DocCasePartyAliasEntity> GetListDocCasePartyAliasByDcpId(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyAliasByDCPID(dcpId);
        }

        public List<DocCasePartyAuthorisedOfficerDetailsEntity> GetListDocCasePartyAuthorisedOfficerDetailsEntityByDcpId(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyAuthorisedOfficerDetailByDCPID(dcpId);
        }

        public List<DocCasePartyBailorAddressEntity> GetListDocCasePartyBailorAddressEntityByDCPId(string dCPId)
        {
            DocumentGateway gateway = new DocumentGateway();
            return gateway.GetListDocCasePartyBailorAddressEntityByDCPId(dCPId);
        }

        public List<DocCasePartyBailorInfoEntity> GetListDocCasePartyBailorInfoEntityByDCPId(string dCPId)
        {
            DocumentGateway gateway = new DocumentGateway();
            return gateway.GetListDocCasePartyBailorInfoEntityByDCPId(dCPId);
        }

        /* End of Criminal Case Data */
        /* Start of Criminal Doc Case Data */
        public List<DocCasePartyCriminalInfoEntity> GetListDocCasePartyCriminalInfoEntityByDCPId(string dCPId)
        {
            DocumentGateway gateway = new DocumentGateway();
            return gateway.GetListDocCasePartyCriminalInfoEntityByDCPId(dCPId);
        }

        public List<DocCasePartyData> GetListDocCasePartyDataByDocId(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            List<RDocCasePartyEntity> ListRDocCaseParty = documentGateway.GetListRDocCaseParty(docId);

            List<DocCasePartyData> listDocCasePartyData = new List<DocCasePartyData>();

            foreach (RDocCasePartyEntity rdcpEntity in ListRDocCaseParty)
            {
                if (rdcpEntity != null && rdcpEntity.DCPID != null)
                    listDocCasePartyData.Add((DocCasePartyData)documentGateway.GetDocCasePartyData(rdcpEntity.DCPID));
            }

            return listDocCasePartyData;
        }

        public List<DocCasePartyEntity> GetListDocCasePartyEntityByCaseInfoId(string caseInfoId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyByCaseInfoId(caseInfoId);
        }

        public List<DocCasePartyVesselDetailsEntity> GetListDocCasePartyVesselDetailsEntityByDcpId(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyVesselDetailsByDCPID(dcpId);
        }

        public List<DocCaseSolicitorEntity> GetListDocCaseSolicitorByDcpId(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCaseSolicitorByDCPID(dcpId);
        }

        public List<DocCommentsEntity> GetListDocCommentsEntityByDocId(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocComments(docId);
        }

        public List<DocOrderDetailsEntity> GetListDocOrderDetailsEntityByDocId(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocOrderDetailsByDocId(docId);
        }

        public List<DocRequestDetailsEntity> GetListDocRequestDetailsEntityByDocId(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocRequestDetailsByDocId(docId);
        }

        public List<IDocumentEntity> GetListDocumentEntity<T>(Dictionary<string, object> values)
        {
            GenericGateway genericGateway = new GenericGateway();
            return genericGateway.GetListDocumentEntity<T>(values);
        }

        public List<DocumentInfoEntity> GetListDocumentInfoByCaseInfoId(string caseInfoId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoByCaseInfoId(caseInfoId);
        }

        public List<DocumentInfoEntity> GetListDocumentInfoBySGID(string SGId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoBySubmissinId(SGId);
        }

        public List<DrugInfoEntity> GetListDrugInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListDrugInfoEntityBySGID(submissionGroupId);
        }

        public List<FilingFeeDetailEntity> GetListFilingFeeDetailByDocId(string docId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListFilingFeeDetailByDocId(docId);
        }

        public List<FilingFeeRequestDetailEntity> GetListFilingFeeRequestDetailByDocId(string docId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListFilingFeeRequestDetailByDocId(docId);
        }

        public List<HearingEntity> GetListHearingByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListHearingByCaseInfoId(caseInfoId);
        }

        public List<IndexDocDetailEntity> GetListIndexDocDetailEntity(string indexDocInfoId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetGetIndexDocDetail(indexDocInfoId);
        }

        public List<InvestigatingOfficerInfoEntity> GetListInvestigatingOfficerInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListInvestigatingOfficerInfoEntityBySGID(submissionGroupId);
        }

        public List<LawFirmAddressEntity> GetListLawFirmAddressEntityByLFId(string LFId)
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            return lawFirmGateway.GetListLawFirmAddressByLFID(LFId);
        }

        public List<LawFirmCaseFileRefNumberEntity> GetListLawFirmCaseFileRefNumberEntity(string lFID, string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListLawFirmCaseFileRefNumberEntity(lFID, caseInfoId);
        }

        public List<LawFirmCaseFileRefNumberEntity> GetListLawFirmCaseFileRefNumberEntityByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListLawFirmCaseFileRefNumberEntityByCaseInfoId(caseInfoId);
        }

        public List<LawFirmEntity> GetListLawFirmEntity()
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            return lawFirmGateway.GetSortedLawFirm();
        }

        public List<LegislationProvisionsEntity> GetListLegislationProvisions(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListLegislationProvisionsEntityBySGID(submissionGroupId);
        }

        public List<MinuteSheetFamilyRelatedInfoEntity> GetListMinuteSheetFamilyRelatedInfo(string minuteSheetInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListMinuteSheetFamilyRelatedInfo(minuteSheetInfoId);
        }

        public List<MinuteSheetGroundInfoEntity> GetListMinuteSheetGroundInfo(string minuteSheetInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListMinuteSheetGroundInfo(minuteSheetInfoId);
        }

        public List<MinuteSheetInfoEntity> GetListMinuteSheetInfoByCaseInfoId(string caseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListMinuteSheetInfoByCaseInfoId(caseInfoId);
        }

        public List<MinuteSheetPartyRepInfoEntity> GetListMinuteSheetPartyRepInfo(string minuteSheetInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListMinuteSheetPartyRepInfo(minuteSheetInfoId);
        }

        public List<MinuteSheetPartySolicitorInfoEntity> GetListMinuteSheetPartySolicitorInfo(string minuteSheetPartyRepInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListMinuteSheetPartySolicitorInfo(minuteSheetPartyRepInfoId);
        }

        public List<NatureOfApplicationEntity> GetListNatureOfApplicationByCaseInfoId(string caseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListNatureOfApplicationEntityByCaseInfoId(caseInfoId);
        }

        public List<NatureOfApplicationEntity> GetListNatureOfApplicationBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListNatureOfApplicationEntityBySGID(submissionGroupId);
        }

        public List<NatureOfApplicationEntity> GetListNatureOfApplicationEntityBySubCaseInfoId(string subcaseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListNatureOfApplicationEntityByCaseSubCaseInfoId(subcaseInfoId);
        }

        public List<NatureOfCaseEntity> GetListNatureOfCaseByCaseInfoId(string caseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListNatureOfCaseEntityByCaseInfoId(caseInfoId);
        }

        public List<NatureOfCaseEntity> GetListNatureOfCaseBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListNatureOfCaseEntityBySGID(submissionGroupId);
        }

        public List<OffenceInfoEntity> GetListOffenceInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListOffenceInfoEntityBySGID(submissionGroupId);
        }

        public List<OriginatingCaseEntity> GetListOriginatingCaseByCaseInfoId(string caseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListOriginatingCaseEntityByCaseInfoId(caseInfoId);
        }

        public List<OriginatingCaseEntity> GetListOriginatingCaseEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListOriginatingCaseEntity(submissionGroupId);
        }

        public List<OtherITMOEntity> GetListOtherITMOBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListOtherITMOEntityBySGID(submissionGroupId);
        }

        public List<PBWillCodicilEntity> GetListPBWillCodicilEntityByCaseInfoId(string caseInfoId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetListPBWillCodicil(caseInfoId);
        }

        public List<RAccusedStatementInfoEntity> GetListRAccusedStatementInfoByDocIdsCasePartyIds(List<string> docIds, List<string> casePartyIds)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListRAccusedStatementInfoByDocIdsCasePartyIds(docIds, casePartyIds);
        }

        public List<RCaseLawFirmEntity> GetListRCaseLawFirmEntityByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListRCaseLawFirmEntityByCaseInfoId(caseInfoId);
        }

        public List<RCaseLawFirmEntity> GetListRCaseLawFirmEntityByCaseInfoIdAndLFId(string caseInfoId, string LFId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListRCaseLawFirmEntityByCaseInfoIdAndLFId(caseInfoId, LFId);
        }

        public List<RCaseLinkedEntity> GetListRCaseLinkedByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListRCaseLinkedByCaseInfoId(caseInfoId);
        }

        public List<RCaseSubmissionEntity> GetListRCaseSubmissionEntity(string caseInfoId, string submissionGroupId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListRCaseSubmissionEntity(caseInfoId, submissionGroupId);
        }

        public List<RCaseSubmissionEntity> GetListRCaseSubmissionEntityByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListRCaseSubmissionEntityByCaseInfoId(caseInfoId);
        }

        public List<RCaseTransferEntity> GetListRCaseTransferByFrCaseInfoId(string frCaseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListRCaseTransferByFrCaseInfoId(frCaseInfoId);
        }

        public List<RCriminalLegislationInfoEntity> GetListRCriminalLegislationInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListRCriminalLegislationInfoEntityBySGID(submissionGroupId);
        }

        public List<RDocCaseEntity> GetListRDocCaseEntity(string docId, string caseInfoId, string subCaseInfoId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListRDocCase(docId, caseInfoId, subCaseInfoId);
        }

        public List<RDocCasePartyEntity> GetListRDocCaseParty(string dcpId, string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListRDocCaseParty(dcpId, docId);
        }

        public List<RDocCasePartyEntity> GetListRDocCaseParty(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListRDocCaseParty(docId);
        }

        //TODO:Create RDOcLaWFirm NHibernate Entity
        public List<RDocLawFirmEntity> GetListRDocLawFirmEntity(string docId, string lFId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            // return documentGateway.GetRDocLawFirm(docId, lFId);
            return null;
        }

        public List<RefCaveatCaseEntity> GetListRefCaveatCaseEntityBySGID(string SGID)
        {
            AdmiralityGateway gateway = new AdmiralityGateway();
            return gateway.GetListRefCaveatCaseEntityBySGID(SGID);
        }

        public List<RefOrderDetailEntity> GetListRefOrderDetailsBySGID(string submissionGroupId)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);
        }

        public List<RefSubCaseEntity> GetListRefSubCasesBySGID(string submissionGroupId)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListRefSubCaseEntityBySGID(submissionGroupId);
        }

        public List<RequestDocDetailEntity> GetListRequestDocDetailEntityByDocId(string docId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListRequestDocDetailByDocId(docId);
        }

        public List<SentenceInfoEntity> GetListSentenceInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListSentenceInfoEntityBySGID(submissionGroupId);
        }

        public List<SolicitorEntity> GetListSolicitorEntityByLFId(string LFId)
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            return lawFirmGateway.GetListSolicitorEntityByLFId(LFId);
        }

        public List<SubCaseInfoEntity> GetListSubCaseInfoEntity(string caseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetSubCaseInfoEntityByCaseInfoId(caseInfoId);
        }

        public List<SubCaseInfoEntity> GetListSubCaseInfoEntityBySubCaseNo(string subCaseNo)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetSubCaseInfoEntityBySubCaseNo(subCaseNo);
        }

        public List<SubCasePartyEntity> GetListSubCasePartyEntity(string caseInfoId, string subCaseInfoId, string casePartyId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            //subCaseGateway .
            return null;
        }

        public List<WOEExecutionAddressEntity> GetListWOEExecutionAddressEntityBySGID(string submissionGroupId)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListWOEExecutionAddressBySGID(submissionGroupId);
        }

        public ICaseTypeInfo GetMinuteSheetDataByHrgId(string HrgId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetMinuteSheetDataByHrgId(HrgId);
        }

        public MinuteSheetInfoEntity GetMinuteSheetInfoEntityByHrgId(string hrgId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetMinuteSheetInfoEntityByHrgId(hrgId);
        }

        public OGCIncomingQueueEntity GetOGCIncomingQueueEntity(string OGCIncomingQueueId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetOGCIncomingQueue(OGCIncomingQueueId);
        }

        public ICaseTypeInfo GetOriginatingSummonsBankruptcyDataBySGID(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetOriginatingSummonsBankruptcyDataBySGID(submissionGroupId);
        }

        public ICaseTypeInfo GetOriginatingSummonsDataBySGID(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetOriginatingSummonsDataBySGID(submissionGroupId);
        }

        public PaymentInDocDetailEntity GetPaymentInDocDetailByPK(string paymentInId)
        {
            PaymentInOutGateway paymentInOutGateway = new PaymentInOutGateway();
            return paymentInOutGateway.GetPaymentInDocDetailEntityByPK(paymentInId);
        }

        public PaymentOutDocDetailEntity GetPaymentOutDocDetailByPk(string paymentOutId)
        {
            PaymentInOutGateway paymentInOutGateway = new PaymentInOutGateway();
            return paymentInOutGateway.GetPaymentOutDocDetailEntityByPk(paymentOutId);
        }

        public ICaseTypeInfo GetProbateDataBySGID(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetProbateDataBySGID(submissionGroupId);
        }

        public ICaseTypeInfo GetCaveatDataBySGID(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetCaveatDataBySGID(submissionGroupId);
        }

        public RAccusedStatementInfoEntity GetRAccusedStatementInfoEntityByCasePartyId(string casePartyId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetRAccusedStatementInfoEntityByCasePartyId(casePartyId);
        }

        public RAccusedStatementInfoEntity GetRAccusedStatementInfoEntityByDocId(string docId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetRAccusedStatementInfoEntityByDocId(docId);
        }

        public ISubCaseTypeInfo GetRegistrarsAppealsDataBySGID(string submissionGroupId)
        {
            GenericDataGateway genericDataGateway = new GenericDataGateway();
            return genericDataGateway.GetRegistrarsAppealsDataBySGID(submissionGroupId);
        }

        public List<RSubCaseSubmissionEntity> GetRSubCaseSubmissionEntity(string subCaseInfoId, string sGId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetListRSubCaseSubmission(subCaseInfoId, sGId);
        }

        public SolicitorEntity GetSolicitorEntityByPK(long solicitorId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetSolicitorEntityByPK(solicitorId);
        }

        public SubCaseInfoEntity GetSubCaseInfoEntityByPk(string subCaseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetSubCaseInfoEntityBySubCaseInfoId(Convert.ToInt64(subCaseInfoId));
        }

        public SubmissionInfoEntity GetSubmissionInfoEntityBySGId(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            List<SubmissionInfoEntity> listSubmissionInfoEntity = commonGateway.GetListSubmissionInfoEntity(submissionGroupId);
            if (listSubmissionInfoEntity != null && listSubmissionInfoEntity.Count > 0)
                return listSubmissionInfoEntity[0];
            else
                return null;
        }

        public ISubCaseTypeInfo GetSummonsData(string submissionGroupId)
        {
            SubCaseDataGateway subCaseDataGateway = new SubCaseDataGateway();
            return subCaseDataGateway.GetSummonsDataBySGID(submissionGroupId);
        }

        public TaskListEntity GetTaskListEntityByWorkFlowSerialNo(string workFlowSerialNo)
        {

            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetTaskListEntityByWorkflowSerialNo(workFlowSerialNo);
        }

        public ICaseTypeInfo GetTaxationDataBySGID(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetTaxationDataBySGID(submissionGroupId);
        }

        public List<WitnessInfoEntity> GetWitnessInfoEntityBySubmissionGroupId(string submissionGroupId)
        {
            DocumentGateway docGateway = new DocumentGateway();
            List<DocumentInfoEntity> listDocInfo = docGateway.GetListDocumentInfoBySubmissinId(submissionGroupId);

            List<string> docIds = new List<string>();
            if ((listDocInfo != null) && (listDocInfo.Count > 0))
            {
                foreach (DocumentInfoEntity docEntity in listDocInfo)
                    docIds.Add(docEntity.DocId);
            }

            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListWitnessInfoByDocIds(docIds);
        }

        public List<WOERequestEntity> GetWOERequestEntityBySubmissionGroupId(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListWOERequestBySubmissionGroupId(submissionGroupId);
        }

        public WorkflowOnAcceptQueueEntity GetWorkflowOnAcceptQueueEntityByPK(string WorkflowOnAcceptQueueId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetWorkflowOnAcceptQueueEntityByPK(WorkflowOnAcceptQueueId);
        }

        public WorkflowPostAcceptQueueEntity GetWorkflowPostAcceptQueueEntityByPK(string WorkflowPostAcceptQueueId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetWorkflowPostAcceptQueueEntityByPK(WorkflowPostAcceptQueueId);
        }

        public ICaseTypeInfo GetWOSDataBySGID(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetWOSDataBySGID(submissionGroupId);
        }

        public void SaveOrUpdateAppealsData(ICaseTypeInfo iCaseTypeInfo)
        {
            AppealsData appealsData = iCaseTypeInfo as AppealsData;

            AppealsGateway appealsGateway = new AppealsGateway();
            appealsGateway.SaveOrUpdateAppealsData(appealsData);
        }

        public void SaveOrUpdateBackEndSpecificEntity(IBackEndSpecificEntity iBackEndSpecificEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<IBackEndSpecific>(BackEndSpecificMapper.GetBackEndSpecificEntity<IBackEndSpecificEntity>(iBackEndSpecificEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateBackEndSpecificEntity", ex);
                Logger.Error("Error in SaveOrUpdateBackEndSpecificEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public void SaveOrUpdateBankruptcyData(ICaseTypeInfo iCaseTypeInfo)
        {
            BankruptcyData bankruptcyData = (BankruptcyData)iCaseTypeInfo;
            BankruptcyGateway gateway = new BankruptcyGateway();
            gateway.SaveOrUpdateBankruptcyData(bankruptcyData);
        }

        public void SaveOrUpdateCaseData(ICaseTypeInfo iCaseTypeInfo, bool isCopy)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            caseDataGateway.SaveOrUpdateCaseData(iCaseTypeInfo, isCopy);
        }

        public void SaveOrUpdateCaseEntity(ICaseEntity caseEntity, bool isCopy)
        {
            CaseGateway caseGateway = new CaseGateway();
            if (caseEntity.GetType().Equals(typeof(RCaseConsolidateEntity)))
            {
                caseGateway.SaveOrUpdateRCaseConsolidateSP(caseEntity);
            }

            else if (isCopy)
                caseGateway.SaveOrUpdateInMemoryEntity<ICase>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseEntity<ICaseEntity>(caseEntity));
            else
                caseGateway.SaveOrUpdateEntity<ICase>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseEntity<ICaseEntity>(caseEntity));
        }

        public void SaveOrUpdateCasePartyData(ICasePartyData iCaseParty)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCasePartyData(iCaseParty);
        }

        public void SaveOrUpdateCaseSpecificEntity(ICaseSpecificEntity iCaseSpecificEntity, bool isCopy)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            if (isCopy)
                caseSpecificGateway.SaveOrUpdateInMemoryEntity<ICaseSpecific>(CaseSpecificMapper.GetCaseSpecificEntity<ICaseSpecificEntity>(iCaseSpecificEntity));
            else
                caseSpecificGateway.SaveOrUpdateEntity<ICaseSpecific>(CaseSpecificMapper.GetCaseSpecificEntity<ICaseSpecificEntity>(iCaseSpecificEntity));
        }

        public void SaveOrUpdateCommonEntity(ICommonEntity iCommonEntity, bool isCopy)
        {
            GenericGateway genericGateway = new GenericGateway();
            genericGateway.SaveOrUpdateEntity<ICommon>(CommonMapper.GetCommonEntity<ICommonEntity>(iCommonEntity), isCopy);
        }

        public void SaveOrUpdateCopyAppealsData(Domain.CaseData.AppealsData appealsData)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ICaseParty"/> interface.
        /// </summary>
        /// <param name="iCaseParty"><see cref="ICaseParty"/> interface</param>
        public void SaveOrUpdateCriminalCasePartyData(ICasePartyData iCaseParty)
        {
            try
            {
                CaseGateway caseGateway = new CaseGateway();
                caseGateway.SaveOrUpdateCriminalCasePartyData(iCaseParty);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateCriminalCasePartyData", ex);
                Logger.Error("Error in SaveOrUpdateCriminalCasePartyData: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Saves or Updates <see cref="IDocCaseParty"/>
        /// </summary>
        /// <param name="docCasePartyData">The IDocCaseParty.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        public void SaveOrUpdateCriminalDocCasePartyData(IDocCasePartyData docCasePartyData, bool isCopy)
        {
            try
            {
                DocumentGateway documentGateway = new DocumentGateway();
                documentGateway.SaveOrUpdateCopyCriminalDocCasePartyData(docCasePartyData, isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateDocCasePartyData", ex);
                Logger.Error("Error in SaveOrUpdateDocCasePartyData: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public void SaveOrUpdateDocCasePartyData(IDocCasePartyData docCasePartyData, bool isCopy)
        {
            DocumentGateway documentGateway = new DocumentGateway();//To Refactor the usage
            documentGateway.SaveOrUpdateCopyDocCasePartyData(docCasePartyData, isCopy);
        }

        public void SaveOrUpdateDocumentEntity(IDocumentEntity iDocumentEntity, bool isCopy)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            if (iDocumentEntity.GetType().Equals(typeof(DocumentInfoEntity)))
            {
                documentGateway.SaveOrUpdateDocumentInfoSP(iDocumentEntity);
            }
            else if (isCopy)
                documentGateway.SaveOrUpdateInMemoryEntity<IDocument>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocumentEntity<IDocumentEntity>(iDocumentEntity));
            else
                documentGateway.SaveOrUpdateEntity<IDocument>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocumentEntity<IDocumentEntity>(iDocumentEntity));
        }



        public void SaveOrUpdateSubCaseData(ISubCaseTypeInfo iSubCaseTypeInfo, bool isCopy)
        {
            SubCaseDataGateway subCaseDataGateway = new SubCaseDataGateway();
            subCaseDataGateway.SaveOrUpdateSubCaseData(iSubCaseTypeInfo, isCopy);
        }

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

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubCaseSpecificEntity"/> interface.
        /// </summary>
        /// <param name="iSubCaseSpecificEntity"><see cref="ISubCaseSpecificEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateSubCaseSpecificEntity(ISubCaseSpecificEntity iSubCaseSpecificEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<ISubCaseSpecific>(SubCaseSpecificMapper.GetSubCaseSpecific<ISubCaseSpecificEntity>(iSubCaseSpecificEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateSubCaseSpecificEntity", ex);
                Logger.Error("Error in SaveOrUpdateSubCaseSpecificEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubsequentEntity"/> interface.
        /// </summary>
        /// <param name="iSubsequentEntity"><see cref="ISubsequentEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateSubsequentEntity(ISubsequentEntity iSubsequentEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<ISubsequent>(SubsequentMapper.GetSubsequent<ISubsequentEntity>(iSubsequentEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateSubsequentEntity", ex);
                Logger.Error("Error in SaveOrUpdateSubsequentEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        private void DeleteCaseParty(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyByPK(casePartyId);
        }

        private void DeleteCasePartyAICAddressListByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyAICAddressListByCasePartyId(casePartyId);
        }

        private void DeleteCasePartyAICAliasListByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyAICAliasByCasePartyId(casePartyId);
        }

        private void DeleteCasePartyCitizenship(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasepartyCitizenship(casePartyId);
        }

        private void DeleteCasePartyLACDetail(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyLACDetail(casePartyId);
        }

        private void DeleteCaseSolicitor(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCaseSolicitorListByCasePartyId(casePartyId);
        }

        private void DeleteDocCaseParty(string caseInfoId, string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCaseParty(caseInfoId, dcpId);
        }

        private void DeleteDocCasePartyAddress(string caseInfoId, string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCasePartyAddress(caseInfoId, dcpId);
        }

        private void DeleteDocCasePartyAICAddress(string caseInfoId, string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCasePartyAICAddress(caseInfoId, dcpId);
        }

        private void DeleteDocCasePartyAICAlias(string caseInfoId, string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCasePartyAICAlias(caseInfoId, dcpId);
        }

        private void DeleteDocCasePartyAICDetails(string caseInfoId, string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCasePartyAICDetails(caseInfoId, dcpId);
        }

        private void DeleteDocCasePartyAlias(string caseInfoId, string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCasePartyAICAddress(caseInfoId, dcpId);
        }

        private void DeleteDocCasePartyCitizenshipByDcpId(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCasePartyCitizenship(dcpId);
        }

        private void DeleteDocCasePartyLACDetail(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCasePartyLACDetail(dcpId);
        }

        private void DeleteDocCaseSolicitor(string caseInfoId, string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCaseSolicitor(caseInfoId, dcpId);
        }

        private void DeleteOSPDRelation(string caseInfoId, string dcpId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteOSPDRelation(caseInfoId, dcpId);
        }

        private void DeleteRDocCaseParty(string caseInfoId, string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteRDocCaseParty(caseInfoId, dcpId);
        }


        public List<DocAppProcessByExAgencyEntity> GetListDocAppProcessByExAgencyEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListDocAppProcessByExAgencyBySGID(submissionGroupId);
        }


        public void DeleteDocCasePartyAddress(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCasePartyAddress(dcpId);
        }


        public List<SubCasePartyEntity> GetListSubCasePartyEntity(string subcaseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetSubCasePartyEntityEntityBySubCaseInfoId(Convert.ToInt64(subcaseInfoId));
        }


        public CasePartyEntity GetCasePartyEntityByPK(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyByPK(casePartyId);
        }


        public List<DocCasePartyEntity> GetListDocCasePartyBySubCaseInfoId(string subcaseInfoId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCasePartyEntityBySubCaseInfoId(subcaseInfoId);
        }


        public void DeleteDocCasePartyAlias(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.DeleteDocCasePartyAlias(dcpId);
        }


        public List<CaseInfoEntity> GetListCaseInfoEntityByCaseType(string caseType)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseInfoByCaseType(caseType);
        }


        public List<DocumentInfoEntity> GetListDocumentInfoEntityByDocCode(string docCode)
        {

            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoByDocCode(docCode);
        }

        public BillOfSaleSubInfoEntity GetBillOfSaleSubInfoEntity(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetBillOfSaleSubInfoEntity(submissionGroupId);
        }


        public BillOfSaleInfoEntity GetBillOfSaleInfoEntity(string submissionGroupId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetBillOfSaleInfoBySGID(submissionGroupId);
        }


        public List<RSubCaseSubmissionEntity> GetRSubCasesubmissionEntity(string subCaseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetRSubCaseSubmission(subCaseInfoId);
        }


        public void RollBackTransaction()
        {
            Logger.Info("BackEndMediator - RollBackTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager = new ApplicationSessionManager();
            this.applicationSessionManager.RollBackTransaction();

            Logger.Info("BackEndMediator - RollBackTransaction ended at " + DateTime.Now.ToString());
        }

        public List<CaseInfoEntity> PendingOneYearOldDocs()
        {
            BackEndSpecificGateway bac = new BackEndSpecificGateway();
            return bac.PendingOneYearOldDocs();

        }

        /// <summary>
        /// Gets the <see cref="docId"/>and returns <see cref="List<DocCasePartyEntity>"/>
        /// </summary>
        /// <param name="docId">The DocId.</param>
        /// <returns></returns>
        public List<DocCasePartyEntity> GetListDocCasePartyByDocId(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyByDocId(docId);
        }

        public List<DegreeInfoEntity> GetListDegreeInfoEntityBySGID(string sGID)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListDegreeInfoBySGID(sGID);
        }

        public List<RMUserPSEntity> GetListRMUserPSByJOUserId(string JOUserId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetRMUserPSEntity(JOUserId);
        }

        public List<ClaimAmountEntity> GetClaimAmountEntity(string docId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListClaimAmountByDocId(docId);
        }

        public List<LawFirmEntity> GetAllLawFirmEntity()
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            return lawFirmGateway.GetAllLawFirm();
        }

        public List<LawFirmAddressEntity> GetAllListLawFirmAddressEntity()
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            return lawFirmGateway.GetAllLawFirmAddress();
        }

        public List<SolicitorEntity> GetAllSolicitorEntity()
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetAllSolicitor();
        }

        public void SaveOrUpdateLawFirmEntity(ILawFirmEntity iLawFirmEntity, bool isCopy)
        {
            GenericGateway genericGateway = new GenericGateway();
            genericGateway.SaveOrUpdateEntity<ILawFirm>(LawFirmMapper.GetLawFirmEntity<ILawFirmEntity>(iLawFirmEntity), isCopy);
        }



        public List<NumberOfJudgeAssignDetailEntity> GetListNumberOfJudgeAssignDetailEntityByWSNo(string workFlowSerialNo)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListNumberOfJudgeAssignDetailEntityByWSNo(workFlowSerialNo);
        }

        public List<NumberOfJudgeAssignDetailHistoryEntity> GetListNumberOfJudgeAssignDetailHistoryEntity(string NoOfJudgeAssignDetailId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListNumberOfJudgeAssignDetailHistoryEntity(NoOfJudgeAssignDetailId);
        }

        public NumberOfJudgeAssignDetailEntity GetNumberOfJudgeAssignDetailEntityByPK(string NoOfJudgeAssignDetailId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetNumberOfJudgeAssignDetailEntityByPK(NoOfJudgeAssignDetailId);
        }


        public List<DocumentInfoEntity> GetDocumentInfoEntityBySubCaseInfoId(string subCaseInfoId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoBySubCaseInfoId(subCaseInfoId);
        }


        public ReportConfigTaskInfoEntity GetReportConfigTaskInfoEntityByPK(string ReportConfigTaskInfoId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetReportConfigTaskInfoByPK(ReportConfigTaskInfoId);
        }

        public List<BEWorkitemDetailsEntity> GetListBEWorkitemDetailsEntity(string WFSNo)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListBEWorkItemDetailsEntity(WFSNo);
        }

        public List<BEWorkitemRecipientEntity> GetListBEWorkitemRecipientEntity(string WFSNo)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListBEWorkitemRecipientEntity(WFSNo);
        }

        public void DeleteTaskList(string WFSNo)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            backEndSpecificGateway.DeleteTaskList(WFSNo);
        }

        public void DeleteBEWorkitemDetails(string WFSNo)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            backEndSpecificGateway.DeleteBEWorkitemDetails(WFSNo);

        }

        public void DeleteBEWorkitemRecipient(string WFSNo)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            backEndSpecificGateway.DeleteBEWorkitemRecipient(WFSNo);
        }

        public void DeleteNumberOfJudgeAssignDetail(string WFSNo)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            backEndSpecificGateway.DeleteNumberOfJudgeAssignDetail(WFSNo);
        }

        public void DeleteNumberOfJudgeAssignDetailHistory(string NumberOfJudgeAssignDetailId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            backEndSpecificGateway.DeleteNumberOfJudgeAssignDetailHistory(NumberOfJudgeAssignDetailId);
        }

        public List<DocumentInfoEntity> GetCaveatList(string caseTypeCode)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetCaveatList(caseTypeCode);
        }

        public List<RCaseLinkedEntity> GetListRCaseLinkedFromGroupId(string linkGroupId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListRCaseLinkedFromGroupId(linkGroupId);
        }

        public RCaseTransferEntity GetRCaseTransferByPK(string rCaseTransferId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetRCaseTransferByPK(rCaseTransferId);
        }

        public List<ReportConfigInfoEntity> GetListReportConfigInfo(string jobType)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListReportConfigInfo(jobType);
        }

        public void DeleteSentenceCriminalOrderInfo(string submissionGroupId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            caseSpecificGateway.DeleteSentenceCriminalOrderInfo(submissionGroupId);
        }

        public ICaseTypeInfo GetRASDataBySGID(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetRASDataBySGID(submissionGroupId);
        }


        public List<CheckListCommentEntity> GetCheckListCommentEntity(string checkListSubmissionId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetlistCheckListComment(checkListSubmissionId);
        }

        public List<RCaseConsolidateEntity> GetListRCaseConsolidate(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListRCaseConsolidate(caseInfoId);
        }

        public void SaveRCaseLinkedEntity(RCaseLinkedEntity rCaseLinkedEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveRCaseLinked(rCaseLinkedEntity);
        }

        public List<RefOrderJOInfoEntity> GetListRefOrderJOInfoBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListRefOrderJOInfoBySGID(submissionGroupId);
        }

        public WOSInfoEntity GetWOSInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetWOSInfoEntityBySGID(submissionGroupId);
        }

        public List<CaseStatusRuleInfoEntity> GetListCaseStatusRuleInfoEntity(string caseInfoId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetCaseStatusRuleInfoEntity(caseInfoId);
        }

        public List<TaskListEntity> GetListTaskListEntityByHRGId(long? hrgId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListTaskListByHRGId(hrgId);
        }

        public List<JudicialUserEntity> GetAllJudicialUserEntity()
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetAllJudicialUserEntity();
        }


        public OSInfoEntity GetOSInfoEntity(string sGID)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetOSInfoEntityBySGID(sGID);
        }


        public FileInspectionEntity GetFileInspectionEntityByPK(string fileInspectionId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetFileInspectionEntityByPK(fileInspectionId);
        }

        public List<FileInspectionDocDetailEntity> GetListFileInspectionDocDetailByFileInspectionId(string fileInspectionId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListFileInspectionDocDetailByFileInspectionId(fileInspectionId);
        }

        public DocCasePartyLACDetailEntity GetDocCasePartyLACDetailByDCPId(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCasePartyLACDetail(dcpId);
        }

        public WorkflowOutgoingQueueEntity GetWorkflowOutgoingQueueByPK(string workflowOutgoingQueueId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetWorkflowOutgoingQueueByPK(workflowOutgoingQueueId);
        }

        public WorkflowOutgoingQueueEntity GetWorkflowOutgoingQueueEntityByDocId(string docId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetWorkflowOutgoingQueueEntityByDocId(docId);
        }

        public DutyJudgeAssignmentEntity GetDutyJudgeAssignmentByPK(string dutyJudgeAssignmentId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetDutyJudgeAssignmentEntityByPK(dutyJudgeAssignmentId);
        }

        public List<DutyJudgeAssignmentEntity> GetAllDutyJudgementEntity()
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetAllDutyJudgeAssignmentEntity();
        }

        public SystemParametersEntity GetSystemParametersEntity(string configKey)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetSystemParameterEntity(configKey);
        }

        public List<JudicialUserEntity> GetUsersEntityLikeUserName(string userName)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetUsersEntityLikeUserName(userName);
        }

        public ProbateInfoEntity GetProbateInfoBySGID(string submissionGroupId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetProbateInfoEntityBySGID(submissionGroupId);
        }

        public List<LiquidatedClaimEntity> GetListLiquidatedClaimEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListLiquidatedClaimBySGID(submissionGroupId);
        }

        public List<UnliquidatedClaimEntity> GetListUnLiquidatedClaimEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListUnLiquidatedClaimEntityBySGID(submissionGroupId);
        }

        public List<CaseSolicitorEntity> GetListCaseSolicitorByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseSolicitorByCasePartyId(casePartyId);
        }

        public List<HearingCoramEntity> GetListHearingCoramByHrgId(long hrgId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListHearingCoramByHrgId(hrgId);
        }

        public SerialNumberEntity GetSerialNumber(string docPrefix, int year)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetSerialNumber(docPrefix, year);
        }

        public SerialNumberEntity GetNewCaseNumber(string caseType, int year)
        {
            MasterGateway masterGateway = new MasterGateway();
          return  masterGateway.GetNewCaseNumber(caseType, year);
        }

        public List<DocGCRDetailsEntity> GetDocGCRDetailsEntity(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocGCRDetailsByDocId(docId);
        }

        public List<SolicitorEntity> GetListSolicitorEntityByCaseInfoId(string caseInfoId)
        {
        CommonGateway commonGateway=new CommonGateway ();
        return commonGateway.GetSolicitorEntityByCaseInfoId(caseInfoId);
        }

        public List<InterimCasePartyStatusEntity> GetListInterimCasePartyStatusEntityByDocId(string docId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListInterimCasePartyStatusEntityByDocId(docId);
        }

        public List<RPTDisposalKPIConfigEntity> GetAllRPTDisposalKPIConfigEntity()
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetAllRPTDisposalKPIConfigEntity();
        }

        public List<RPTNOCGroupNOCEntity> GetAllRPTNOCGroupNOCEntity()
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetAllRPTNOCGroupNOCEntity();
        }

        public RPTDisposalKPIConfigEntity GetRPTDisposalKPIConfigEntity(int rptDisposalKPIConfigId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetRPTDisposalKPIConfigEntity(rptDisposalKPIConfigId);
        }

        public RPTNOCGroupNOCEntity GetRPTNOCGroupNOCEntity(string rptNOCGroupNOCCode)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetRPTNOCGroupNOCEntity(rptNOCGroupNOCCode);
        }

        public RPTNOCGroupEntity GetRPTNOCGroupEntity(string NocGroupCode)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetRPTNOCGroupEntity(NocGroupCode);
        }

        public List<RPTNOCGroupEntity> GetAllRPTNOCGroupEntity()
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetAllRPTNOCGroupEntity();
        }

        public List<HearingOutcomeFlagEntity> GetListHearingOutcomeFlagByHRGId(long hrgId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListHearingOutcomeFlagByHRGId(hrgId);
        }

        public void SaveOrUpdateRLawFirmSolicitor(RLawFirmSolicitorsEntity rLawFirmSolicitors)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateRLawFirmSolicitor(rLawFirmSolicitors);
        }

        public void SaveOrUpdateRLawFirmSolicitorHistory(RLawFirmSolicitorHistoryEntity rLawFirmSolicitorHistoryEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateRLawFirmSolicitorHistory(rLawFirmSolicitorHistoryEntity);
        }


        public void DeleteRLawFirmSolicitors(long SolicitorId, string lFID)
        {
            try
            {
                CaseGateway caseGateway = new CaseGateway();
                caseGateway.DeleteRLawFirmSolicitors(SolicitorId, lFID);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at DeleteRLawFirmSolicitors", ex);
                throw;
            }
        }

        public void RollbackTransaction()
        {
            Logger.Info("BackEndMediatorImpl - RollBackTransaction started");

            this.applicationSessionManager.RollBackTransaction();

            Logger.Info("BackEndMediatorImpl  - RollBackTransaction ended");
        }

        public TransferOrderOfCourtEntity GetTransferOrderOfCourt(string transferOrderOfCourtId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetTransferOrderOfCourt(transferOrderOfCourtId);
        }

        public CasePartyLACDetailEntity GetCasePartyLACDetailEntity(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyLACDetail(casePartyId);
        }

        public List<LACInfoEntity> GetLacInfoByCaseInfoId(string caseInfoId)
        {
            LAPGateway lapGateway = new LAPGateway();
            return lapGateway.GetListLACInfoByCaseInfoId(caseInfoId);
        }

        public List<LACDocumentDetailEntity> GetListLACDocumentDetail(string LacInfoId)
        {
            LAPGateway lapGateway = new LAPGateway();
            return lapGateway.GetListLACDocumentDetailByLACInfoId(LacInfoId);
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ILAPEntity"/> interface.
        /// </summary>
        /// <param name="iLAPEntity"><see cref="ILAPEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateLAPEntity(ILAPEntity iLAPEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<ILAP>(LAPMapper.GetLAP<ILAPEntity>(iLAPEntity), isCopy);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateLAPEntity", ex);
                Logger.Error("Error encountered at SaveOrUpdateLAPEntity : Message --> " + ex.Message + " Inner Exception - " + ex.InnerException.Message);
                throw;
            }
        }

        /// <summary>
        /// Gets the siccos data by sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        /// <returns></returns>
        public ICaseTypeInfo GetSICCOSDataBySGID(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetSICCOSDataBySGID(submissionGroupId);
        }

        /// <summary>
        /// Gets the siccs data by sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        /// <returns></returns>
        public ICaseTypeInfo GetSICCSDataBySGID(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetSICCSDataBySGID(submissionGroupId);
        }

        /// <summary>
        /// Gets the RFL data by sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        /// <returns></returns>
        public ICaseTypeInfo GetRFLDataBySGID(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetRFLDataBySGID(submissionGroupId);
        }

        /// <summary>
        /// Gets the list req examination feedetail entityby sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        /// <returns></returns>
        public List<ReqExaminationFeeDetailEntity> GetListReqExaminationFeedetailEntitybySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListReqExaminationFeedetailEntitybySGID(submissionGroupId);
        }

        /// <summary>
        /// Gets the RFL validity and notification entityby sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        /// <returns></returns>
        public List<RFLValidityAndNotificationEntity> GetRFLValidityAndNotificationEntitybySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetRFLValidityAndNotificationEntitybySGID(submissionGroupId);
        }

        /// <summary>
        /// Gets the list sub case status history entity.
        /// </summary>
        /// <param name="SubCaseStatusHistoryId">The sub case status history identifier.</param>
        /// <returns></returns>
        public List<SubCaseStatusHistoryEntity> GetListSubCaseStatusHistoryEntity(string SubCaseStatusHistoryId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetSubCaseStatusHistoryEntityBySubCaseStatusHistoryId(SubCaseStatusHistoryId);
        }

        public List<SystemParametersEntity> GetAllSystemParameters()
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetAllSystemParameters();
        }

        public List<PBPADetailEntity> GetListPBPADetailEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListPBPADetailEntityBySGID(submissionGroupId);
        }

        public List<PBSupNExmEntity> GetListPBSupNExmEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListPBSupNExmEntityBySGID(submissionGroupId);
        }

        public List<PBAdminBondEntity> GetListPBAdminBondEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListPBAdminBondEntityBySGID(submissionGroupId);
        }
       
        public List<CaseRegisterEntity> GetListCaseRegisterEntity(long caseInfoId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListCaseRegisterEntity(caseInfoId);
        }

        public List<CaseRegisterHistoryEntity> GetListCaseRegisterHistoryEntity(long caseInfoId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListCaseRegisterHistoryEntity(caseInfoId);
        }

        public List<DashboardCaseMilestoneDetailEntity> GetListDashboardCaseMilestoneDetailEntity(string caseRegisterId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListDashboardCaseMilestoneDetailEntity(caseRegisterId);
        }

        public List<DashboardCaseMilestoneDetailHistoryEntity> GetListDashboardCaseMilestoneDetailHistoryEntity(string caseRegisterId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListDashboardCaseMilestoneDetailHistoryEntity(caseRegisterId);
        }

        public List<DashboardSubCaseMilestoneDetailEntity> GetListDashboardSubCaseMilestoneDetailEntity(long subCaseInfoId)
        {
            SubCaseSpecificGateway gateway = new SubCaseSpecificGateway();
            return gateway.GetListDashboardSubCaseMilestoneDetailEntity(subCaseInfoId);
        }

        public List<DashboardSubCaseMilestoneDetailHistoryEntity> GetListDashboardSubCaseMilestoneDetailHistoryEntity(long subCaseInfoId)
        {
            SubCaseSpecificGateway gateway = new SubCaseSpecificGateway();
            return gateway.GetListDashboardSubCaseMilestoneDetailHistoryEntity(subCaseInfoId);
        }

        public CaveatAAInfoEntity GetCaveatAAInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetCaveatAAInfoEntityBySGID(submissionGroupId);
        }

        public CaveatInfoEntity GetCaveatInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetCaveatInfoEntityBySGID(submissionGroupId);
        }

        public Temp_ProcessingInfoEntity GetTemp_ProcessingInfoEntityByDocId(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetTemp_ProcessingInfoEntityByDocId(docId);
        }

        public List<TaskListEntity> GetListTaskListEntityByDocId(string docId)
        {
            BackEndSpecificGateway gateway = new BackEndSpecificGateway();
            return gateway.GetListTaskListEntityByDocId(docId);
        }

        public List<LawFirmRegistrationEntity> GetListLawFirmRegistrationEntityByLFID(string lfid)
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            return lawFirmGateway.GetListLawFirmRegistrationEntityByLFID (lfid);
        }
        #endregion


      
    }
}