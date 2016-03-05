namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;
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
    using AllInOne.Legal.Domain.SubCaseData;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Data;
    using AllInOne.Legal.Domain.MRelationship;
    using log4net;
    using AllInOne.Legal.Domain.Master;


    public class FilingBrokerMediatorImpl : IFilingBrokerMediator
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(FilingBrokerMediatorImpl));

        /// <summary>
        /// ApplicationSessionManager instance for session.
        /// </summary>
        private ApplicationSessionManager applicationSessionManager = new ApplicationSessionManager();
        private ApplicationSessionManager applicationSessionManagerFRCCase = new ApplicationSessionManager();
        private object caseSpecificLock = new object();
        private object isDocumentLock = new object();

        #endregion Fields

        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that 
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        /// <param name="sender"></param>
        public void BeginTransaction()
        {
            Logger.Info("FilingBrokerMediatorImpl - BeginTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManagerFRCCase.BeginTransaction();

            Logger.Info("FilingBrokerMediatorImpl - BeginTransaction ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Close the session.
        /// </summary>
        public void CloseSession()
        {
            Logger.Info("FilingBrokerMediatorImpl - CloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CloseSession();

            Logger.Info("FilingBrokerMediatorImpl - CloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        public void CommitAndCloseSession()
        {
            Logger.Info("FilingBrokerMediatorImpl - CommitAndCloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CommitAndCloseSession();

            Logger.Info("FilingBrokerMediatorImpl - CommitAndCloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        public void CommitAndCloseSessionFRCCase()
        {
            Logger.Info("FilingBrokerMediatorImpl - CommitAndCloseSessionFRCCase started at " + DateTime.Now.ToString());

            this.applicationSessionManagerFRCCase.CommitAndCloseSession();

            Logger.Info("FilingBrokerMediatorImpl - CommitAndCloseSessionFRCCase ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Deletes <see cref="CaseInfoEntity "/>
        /// </summary>
        /// <param name="caseInfoEntity"></param>
        public void DeleteCaseInfoEntity(CaseInfoEntity caseInfoEntity)
        {
            throw new NotImplementedException();
        }

        public void DeleteCaseOriginatingCase(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCaseOriginatingCaseByCaseInfoId(caseInfoId);
        }

        public void DeleteCaseSolicitorByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCaseSolicitorListByCasePartyId(casePartyId);
        }

        public void DeleteDivorceSubInfoBySGID(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            subsequentGateway.DeleteDivorceSubInfoEntityBySGID(submissionGroupId);
        }

        /// <summary>
        /// Deletes <see cref="DocCasePartyAddressEntity"/>
        /// </summary>
        /// <param name="docCasePartyAddressEntity">The doc case party address entity.</param>
        public void DeleteDocCasePartyAddressEntity(DocCasePartyAddressEntity docCasePartyAddressEntity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes <see cref="DocCasePartyAICAddressEntity "/>
        /// </summary>
        /// <param name="docCasePartyAICAddressEntity">The doc case party AIC address entity.</param>
        public void DeleteDocCasePartyAICAddressEntity(DocCasePartyAICAddressEntity docCasePartyAICAddressEntity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes <see cref="DocCasePartyAICAliasEntity"/>
        /// </summary>
        /// <param name="docCasePartyAICAliasEntity">The doc case party AIC alias entity.</param>
        public void DeleteDocCasePartyAICAliasEntity(DocCasePartyAICAliasEntity docCasePartyAICAliasEntity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes <see cref="DocCasePartyAICDetailsEntity"/>
        /// </summary>
        /// <param name="docCasePartyAICDetailsEntity">The doc case party AIC details entity.</param>
        public void DeleteDocCasePartyAICDetailsEntity(DocCasePartyAICDetailsEntity docCasePartyAICDetailsEntity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes <see cref="DocCasePartyAliasEntity"/>
        /// </summary>
        /// <param name="docCasePartyAliasEntity">The doc case party alias entity.</param>
        public void DeleteDocCasePartyAliasEntity(DocCasePartyAliasEntity docCasePartyAliasEntity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes <see cref="DocCasePartyAuthorisedOfficerDetailsEntity"/>
        /// </summary>
        /// <param name="docCasePartyAuthorisedOfficerDetailsEntity">The doc case party authorised officer details entity.</param>
        public void DeleteDocCasePartyAuthorisedOfficerDetailsEntity(DocCasePartyAuthorisedOfficerDetailsEntity docCasePartyAuthorisedOfficerDetailsEntity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes <see cref="DocCasePartyEntity"/>.
        /// </summary>
        /// <param name="docCasePartyEntity">The doc case party entity.</param>
        public void DeleteDocCasePartyEntity(DocCasePartyEntity docCasePartyEntity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes <see cref="CasePartyVesselDetailsEntity"/>
        /// </summary>
        /// <param name="casePartyVesselDetailsEntity">The case party vessel details entity.</param>
        public void DeleteDocCasePartyVesselDetailsEntity(CasePartyVesselDetailsEntity casePartyVesselDetailsEntity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes <see cref="SubCaseInfoEntity"/>
        /// </summary>
        /// <param name="subCaseInfoEntity"></param>
        public void DeleteSubCaseInfoEntity(SubCaseInfoEntity subCaseInfoEntity)
        {
            throw new NotImplementedException();
        }

        public void DeleteWOECaseExecutionAddress(long caseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteWOECaseExecutionAddress(caseInfoId);
        }

        public void DeleteWOECaseExecutionAddress(long caseInfoId, long? subCaseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteWOECaseExecutionAddress(caseInfoId, subCaseInfoId);
        }

        public ISubCaseTypeInfo GetADDataBySGID(string submissionGroupId)
        {
            ADData aDData = new ADData();
            aDData.PaymentHRGDatesDocDetailEntity = GetPaymentHRGDatesDocDetailEntityBySGID(submissionGroupId);
            aDData.RefOrderDetailEntity = GetListRefOrderDetailsBySGID(submissionGroupId);

            return aDData as ISubCaseTypeInfo;
        }

        public ADMInfoEntity GetADMInfoEntity(string aDMInfoId)
        {
            AdmiralityGateway admiralityGateway = new AdmiralityGateway();
            return admiralityGateway.GetADMInfoEntity(aDMInfoId);
        }

        public ADMInfoEntity GetADMInfoEntityByPK(string aDMInfoId)
        {
            AdmiralityGateway admiralityGateway = new AdmiralityGateway();
            return admiralityGateway.GetADMInfoEntity(aDMInfoId);
        }

        public AppealsData GetAppealsDataBySGID(string SGID)
        {
            AppealsGateway gateway = new AppealsGateway();
            return gateway.GetAppealsData(SGID);
        }

        public ApplicationAdvocatesSolicitorsData GetApplicationAdvocatesSolicitorsDataBySGID(string submissionGroupId)
        {
            CaseDataGateway gateway = new CaseDataGateway();
            return gateway.GetApplicationAdvocatesSolicitorsDataBySGID(submissionGroupId);
        }

        public BankruptcyData GetBankruptcyDataBySGID(string submissionGroupId)
        {
            BankruptcyGateway gateway = new BankruptcyGateway();
            return gateway.GetBankruptcyDataBySGID(submissionGroupId);
        }

        public BankruptcyInfoEntity GetBankruptcyInfoBySGID(string submissionGroupId)
        {
            BankruptcyGateway gateway = new BankruptcyGateway();
            return gateway.GetBankruptcyInfoBySGID(submissionGroupId);
        }

        /// <summary>
        /// Gets the <see cref="submissionGroupId"/>and returns the ICaseTypeInfo
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId.</param>
        /// <returns>ICaseTypeInfo</returns>
        public ICaseTypeInfo GetBillOfSaleData(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetBillOfSaleData(submissionGroupId);
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

        public CasePartyEntity GetCaseParty(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyByPK(casePartyId);
        }

        public CasePartyAddressEntity GetCasePartyAddressByPK(string primaryKey)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyAddress(primaryKey);
        }

        public CasePartyAICAddressEntity GetCasePartyAICAddressByPK(string primaryKey)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyAICAddress(primaryKey);
        }

        public CasePartyAICAliasEntity GetCasePartyAICAliasByPK(string primaryKey)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyAICAlias(primaryKey);
        }

        public CasePartyAICDetailsEntity GetCasePartyAICDetailsByPK(string primaryKey)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyAICDetails(primaryKey);
        }

        public CasePartyAliasEntity GetCasePartyAliasByPK(string primaryKey)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyAlias(primaryKey);
        }

        public CasePartyAuthorisedOfficerDetailsEntity GetCasePartyAuthorisedOfficerDetailsByPK(string primaryKey)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyAuthorisedOfficerDetail(primaryKey);
        }

        public ICasePartyData GetCasePartyData(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyData(casePartyId);
        }

        /// <summary>
        /// Get a list of CasePartyLACDetailEntity by passing the column name and its value.
        /// </summary>
        /// <typeparam name="V">The type for the parameter "value"</typeparam>
        /// <param name="fieldName">The name of the column in database. (Name of property of object).</param>
        /// <param name="value">The value used to filter.</param>
        /// <returns>A list of CasePartyLACDetailEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 28, 2011)</remarks>
        public List<CasePartyLACDetailEntity> GetCasePartyLACDetail<V>(string fieldName, V value)
        {
            try
            {
                Logger.Debug("GetCasePartyLACDetail<V>: The system is trying to get CaseParty LACDetail by ColumnName:" + fieldName + " & Value:" + value.ToString());

                CaseGateway caseGateway = new CaseGateway();
                List<CasePartyLACDetail> listCasePartyLACDetail = caseGateway.GetEntity<CasePartyLACDetail, V>(fieldName, value);

                if (listCasePartyLACDetail != null && listCasePartyLACDetail.Count > 0)
                    return listCasePartyLACDetail.Select(casePartyLACDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyLACDetailEntity(casePartyLACDetail)).ToList();
                else
                    return null;
            }
            catch (Exception exp)
            {
                Logger.Error("Error in GetCasePartyLACDetail<V>. " + exp.Message);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of <see cref="CasePartyLACDetailEntity "/>
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        /// <returns></returns>
        public CasePartyLACDetailEntity GetCasePartyLACDetailEntity(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyLACDetail(casePartyId);
        }

        public CasePartyVesselDetailsEntity GetCasePartyVesselDetailsByPK(string primaryKey)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyVesselDetail(primaryKey);
        }

        public CaseSolicitorEntity GetCaseSolicitorByPK(string primaryKey)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCaseSolicitor(primaryKey);
        }

        public CaseSolicitorHistoryEntity GetCaseSolicitorHistoryByPK(string primaryKey)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCaseSolicitorHistory(primaryKey);
        }

        public ChecklistInstanceEntity GetChecklistInstanceEntityByPK(string checkListInstanceId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListChecklistInstanceEntityByPK(checkListInstanceId);
        }

        public ICasePartyData GetCriminalCasePartyData(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCriminalCasePartyData(casePartyId);
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

        public CWUData GetCWUDataBySGID(string SGID)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetCWUDataBySGID(SGID);
        }

        public CWUInfoEntity GetCWUInfoEntity(string cWUInfoId)
        {
            CWUGateway gateway = new CWUGateway();
            return gateway.GetCWUInfoByPK(cWUInfoId);
        }

        public CWUInfoEntity GetCWUInfoEntityBySGID(string submissionGroupId)
        {
            CWUGateway gateway = new CWUGateway();
            return gateway.GetCWUInfoBySGID(submissionGroupId);
        }

        public DCACAInfoEntity GetDCACAInfoEntityBySGID(string submissionGroupId)
        {
            AppealsGateway gateway = new AppealsGateway();
            return gateway.GetDCACAInfoEntityBySGID(submissionGroupId);
        }

        public DivorceInfoEntity GetDivorceInfoEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetDivorceInfoEntityBySGID(submissionGroupId);
        }

        public DocCasePartyAICAddressEntity GetDocCasePartyAICAddressByPK(string primaryKey)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCasePartyAICAddressByPK(primaryKey);
        }

        public DocCasePartyAICAliasEntity GetDocCasePartyAICAliasByPK(string primaryKey)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetDocCasePartyAICAliasByPK(primaryKey);
        }

        public DocCasePartyAICDetailsEntity GetDocCasePartyAICDetailsByPK(string primaryKey)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCasePartyAICDetailsByPK(primaryKey);
        }

        public DocCasePartyAliasEntity GetDocCasePartyAliasByPK(string primaryKey)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCasePartyAliasByPK(primaryKey);
        }

        public DocCasePartyAuthorisedOfficerDetailsEntity GetDocCasePartyAuthorisedOfficerDetailsByPK(string primaryKey)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCasePartyAuthorisedOfficerDetailsByPK(primaryKey);
        }

        public DocCasePartyEntity GetDocCasePartyByPK(string dCPID)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCaseParty(dCPID);
        }

        public IDocCasePartyData GetDocCasePartyData(string dCPID)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCasePartyData(dCPID);
        }

        /// <summary>
        /// Gets the list of <see cref="DocCasePartyLACDetailEntity "/>
        /// </summary>
        /// <param name="dcpId">The dcpId.</param>
        /// <returns></returns>
        public DocCasePartyLACDetailEntity GetDocCasePartyLACDetailEntity(string dcpId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCasePartyLACDetail(dcpId);
        }

        public DocCasePartyVesselDetailsEntity GetDocCasePartyVesselDetailsByPK(string primaryKey)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCasePartyVesselDetailsyPK(primaryKey);
        }

        /// <summary>
        /// Gets the <see cref="DocOrderDetailsEntity"/>
        /// </summary>
        /// <param name="docId">The docId.</param>
        /// <returns></returns>
        public DocOrderDetailsEntity GetDocOrderDetailsByDocId(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocOrderDetailsByDocId(docId);
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

        public HearingEntity GetHearingEntityByPK(string hrgId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetHearingByPK(hrgId);
        }

        public ILABPartyData GetLABPartyDataByLABPartyId(string lABPartyId)
        {
            LAPGateway lAPGateway = new LAPGateway();
            return lAPGateway.GetLABPartyData(lABPartyId);
        }

        public ILABPartyHistoryData GetLABPartyHistoryDataByLABPartyId(string lABPartyId)
        {
            LAPGateway lAPGateway = new LAPGateway();
            return lAPGateway.GetLABPartyHistoryDataByLABPartyId(lABPartyId);
        }

        public LACCancellationInfoEntity GetLACCancellationInfoByDocId(string docId)
        {
            LAPGateway lAPGateway = new LAPGateway();
            return lAPGateway.GetLACCancellationInfoByDocId(docId);
        }

        /// <summary>
        /// Get a list of LACDocumentDetailEntity by passing the column name and its value.
        /// </summary>
        /// <typeparam name="V">The type for the parameter "value"</typeparam>
        /// <param name="fieldName">The name of the column in database. (Name of property of object).</param>
        /// <param name="value">The value used to filter.</param>
        /// <returns>A list of LACDocumentDetailEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 28, 2011)</remarks>
        public List<LACDocumentDetailEntity> GetLACDocumentDetail<V>(string fieldName, V value)
        {
            try
            {
                Logger.Debug("GetLACDocumentDetail<V>: The system is trying to get LAC Document Detail by ColumnName:" + fieldName + " & Value:" + value.ToString());

                LAPGateway lAPGateway = new LAPGateway();
                List<LACDocumentDetail> listLACDocumentDetail = lAPGateway.GetEntity<LACDocumentDetail, V>(fieldName, value);

                if (listLACDocumentDetail != null && listLACDocumentDetail.Count > 0)
                    return listLACDocumentDetail.Select(lACDocumentDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACDocumentDetailEntity(lACDocumentDetail)).ToList();
                else
                    return null;
            }
            catch (Exception exp)
            {
                Logger.Error("Error in GetLACDocumentDetail<V>. " + exp.Message);
                throw;
            }
        }

        public LACInfoEntity GetLACInfoByPK(string lACInfoId)
        {
            try
            {
                //Logging
                Logger.Debug("GetLACInfoByPK: The system is trying to get LAC Info by " + lACInfoId);
                //Logging

                LAPGateway lAPGateway = new LAPGateway();
                return lAPGateway.GetLACInfoByPK(lACInfoId);
            }
            catch (Exception exp)
            {
                Logger.Error("Error in GetLACInfoByPK. " + exp.Message);
                throw;
            }
        }

        public LawFirmCaseFileRefNumberEntity GetLawFirmCaseFileRefNumberByPK(string primaryKey)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetLawFirmCaseFileRefNumberEntityByPK(primaryKey);
        }

        public List<AASInfoEntity> GetListAASInfoEntityBySGID(string sGID)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListAASInfoBySGID(sGID);
        }

        public List<AffidavitDeponentDetailEntity> GetListAffidavitDeponentDetailEntityByAffidavitId(string AffidavitId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListAffidavitDeponentDetailEntityByAffidavitId(AffidavitId);
        }

        public List<AffidavitInfoEntity> GetListAffidavitInfoEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListAffidavitInfoEntityBySGID(submissionGroupId);
        }

        public List<AreaOfLegalPracticeEntity> GetListAreaOfLegalPracticeEntityBySGID(string sGID)
        {
            SubCaseSpecificGateway gateway = new SubCaseSpecificGateway();
            return gateway.GetListAreaOfLegalPracticeBySGID(sGID);
        }

        public List<BankruptcyOtherDefDetailEntity> GetListBankruptcyOtherDefDetail(string submissionGroupId)
        {
            BankruptcyGateway gateway = new BankruptcyGateway();
            return gateway.GetListBankruptcyOtherDefDetailBySGID(submissionGroupId);
        }

        public List<BankruptcyOtherDefDetailEntity> GetListBankruptcyOtherDefDetailBySGID(string submissionGroupId)
        {
            BankruptcyGateway gateway = new BankruptcyGateway();
            return gateway.GetListBankruptcyOtherDefDetailBySGID(submissionGroupId);
        }

        public List<BTSRoutingQueueEntity> GetListBTSRoutingQueueEntity(string messageId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListBTSRoutingQueue(messageId);
        }

        public List<BTSRoutingQueueEntity> GetListBTSRoutingQueueEntityByStatus(string status)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListBTSRoutingQueueByStatus(status);
        }

        public List<CasePartyAddressEntity> GetListCasePartyAddress(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyAddress(casePartyId);
        }

        public List<CasePartyAICAddressEntity> GetListCasePartyAICAddress(string AICID)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyAICAddress(AICID);
        }

        public List<CasePartyAICAliasEntity> GetListCasePartyAICAlias(string AICID)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyAICAlias(AICID);
        }

        public List<CasePartyAICDetailsEntity> GetListCasePartyAICDetails(string AICID)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyAICDetail(AICID);
        }

        public List<CasePartyAICDetailsEntity> GetListCasePartyAICDetailsByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyAICDetail(casePartyId);
        }

        public List<CasePartyAliasEntity> GetListCasePartyAlias(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyAlias(casePartyId);
        }

        public List<CasePartyAuthorisedOfficerDetailsEntity> GetListCasePartyAuthorisedOfficerDetail(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyAuthorisedOfficerDetail(casePartyId);
        }

        public List<CasePartyEntity> GetListCasePartyByCaseInfoID(string caseInfoId)
        {
            CaseGateway casegateway = new CaseGateway();
            return casegateway.GetCasePartyByCaseInfoId(caseInfoId);
        }

        public List<CasePartyCitizenshipEntity> GetListCasePartyCitizenshipEntityByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyCitizenshipEntityByCasePartyId(casePartyId);
        }

        public List<CasePartyEntity> GetListCasePartyEntityByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseParty(caseInfoId);
        }

        public List<CasePartyLACDetailHistoryEntity> GetListCasePartyLACDetailHistoryByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyLACDetailHistory(casePartyId);
        }

        /// <summary>
        /// Gets the list of <see cref="CasePartyLACDetailHistoryEntity "/>
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        /// <returns></returns>
        public List<CasePartyLACDetailHistoryEntity> GetListCasePartyLACDetailHistoryEntity(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyLACDetailHistory(casePartyId);
        }

        public List<CasePartyVesselDetailsEntity> GetListCasePartyVesselDetail(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCasePartyVesselDetail(casePartyId);
        }

        public List<CaseSolicitorEntity> GetListCaseSolicitorByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseSolicitorByCaseInfoId(caseInfoId);
        }

        public List<CaseSolicitorEntity> GetListCaseSolicitorByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseSolicitorByCasePartyId(casePartyId);
        }

        public List<CaseSolicitorHistoryEntity> GetListCaseSolicitorHistoryByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseSolicitorHistoryByCaseInfoId(caseInfoId);
        }

        public List<CaseSolicitorHistoryEntity> GetListCaseSolicitorHistoryByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseSolicitorHistoryByCasePartyId(casePartyId);
        }

        public List<CDRInfoEntity> GetListCDRInfoEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListCDRInfoEntityBySGID(submissionGroupId);
        }

        public List<ChargeInfoEntity> GetListChargeInfoBySGID(string submissionGroupId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetListChargeInfoEntityBySGID(submissionGroupId);
        }

        public List<ChecklistInstanceEntity> GetListChecklistInstanceEntityByCaseInfoId(string caseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListChecklistInstanceEntityByCaseInfoId(caseInfoId);
        }

        public List<ChecklistSubmissionEntity> GetListCheckListSubmission(string checkListInstanceId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListChecklistSubmissionEntityByCheckListInstanceId(checkListInstanceId);
        }

        public List<ChecklistSubmissionEntity> GetListChecklistSubmissionEntityByDocId(string docId)
        {
            var commonGateway = new CommonGateway();
            return commonGateway.GetListChecklistSubmissionEntityByDocId(docId);
        }

        public List<ChecklistSubmissionEntity> GetListChecklistSubmissionEntityBySubmissionGroupId(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListChecklistSubmissionBySubmissionGroupId(submissionGroupId);
        }

        public List<DegreeInfoEntity> GetListDegreeInfoEntityBySGID(string sGID)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListDegreeInfoBySGID(sGID);
        }

        public List<DivorceSubInfoEntity> GetListDivorceSubInfoEntityBySGID(string submissionGroupId)
        {
            var gateway = new SubsequentGateway();
            return gateway.GetListDivorceSubInfoEntityBySGID(submissionGroupId);
        }

        public List<DocCasePartyAddressEntity> GetListDocCasePartyAddress(string dCPID)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyAddressByDCPID(dCPID);
        }

        public List<DocCasePartyAICAddressEntity> GetListDocCasePartyAICAddress(string DCPAICID)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyAICAddressByDCPAICID(DCPAICID);
        }

        public List<DocCasePartyAICAliasEntity> GetListDocCasePartyAICAlias(string DCPAICID)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyAICAliasByDCPAICID(DCPAICID);
        }

        public List<DocCasePartyAICDetailsEntity> GetListDocCasePartyAICDetails(string dCPID)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyAICDetailsByDCPID(dCPID);
        }

        public List<DocCasePartyAliasEntity> GetListDocCasePartyAlias(string dCPID)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyAliasByDCPID(dCPID);
        }

        public List<DocCasePartyAuthorisedOfficerDetailsEntity> GetListDocCasePartyAuthorisedOfficerDetails(string dCPID)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyAuthorisedOfficerDetailByDCPID(dCPID);
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

        public List<DocCasePartyVesselDetailsEntity> GetListDocCasePartyVesselDetails(string dCPID)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCasePartyVesselDetailsByDCPID(dCPID);
        }

        public List<DocCaseSolicitorEntity> GetListDocCaseSolicitor(string dCPID)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListDocCaseSolicitorByDCPID(dCPID);
        }

        public List<DocGCRDetailsEntity> GetListDocGCRDetailsByDocId(string docId)
        {
            DocumentGateway documentGateWay = new DocumentGateway();
            return documentGateWay.GetListDocGCRDetailsByDocId(docId);
        }

        public List<DocRequestDetailEntity> GetListDocRequestDetailEntity(string docId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListDocRequestDetail(docId);
        }

        /// <summary>
        /// Gets the list document info by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        public List<DocumentInfoEntity> GetListDocumentInfoByCaseInfoId(string caseInfoId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoByCaseInfoId(caseInfoId);
        }

        public List<DocumentInfoEntity> GetListDocumentInfoBySubCaseInfoId(long subCaseInfoId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoBySubCaseInfoId(subCaseInfoId);
        }

        public List<DocumentInfoEntity> GetListDocumentInfoBySubmissionId(string submissionId)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoBySubmissinId(submissionId);
        }

        public List<EmploymentInfoEntity> GetListEmploymentInfoEntityBySGID(string sGID)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListEmploymentInfoBySGID(sGID);
        }

        public List<FileInspectionDocDetailEntity> GetListFileInspectionDocDetailEntityByDocId(string docId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetFileInspectionDocDetailEntity(docId);
        }

        public List<FileInspectionEntity> GetListFileInspectionEntityByDocId(string docId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListFileInspectionEntity(docId);
        }

        public List<FilingFeeDetailEntity> GetListFilingFeeDetailEntityByDocId(string docId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListFilingFeeDetailByDocId(docId);
        }

        /// <summary>
        /// Gets the <see cref="FilingFeeDetailEntity"/>
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        public List<FilingFeeDetailEntity> GetListFilingFeeDetailEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetFilingFeeDetailBySGID(submissionGroupId);
        }

        public List<FilingFeeRequestDetailEntity> GetListFilingFeeRequestDetailEntity(string docId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListFilingFeeRequestDetailEntityByDocId(docId);
        }

        public List<HearingEntity> GetListHearingByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListHearingByCaseInfoId(caseInfoId);
        }

        public List<HearingEntity> GetListHearingByDocId(string docId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListHearingByDocId(docId);
        }

        public List<LABSection17CertInfoEntity> GetListLABSection17CertInfoByDocId(string docId)
        {
            try
            {
                //Logging
                Logger.Debug("GetListLABSection17CertInfoByDocId: The system is trying to get LAB Section17 Cert Info by " + docId);
                //Logging

                LAPGateway lAPGateway = new LAPGateway();
                return lAPGateway.GetListLABSection17CertInfoByDocId(docId);
            }
            catch (Exception exp)
            {
                Logger.Error("Error in GetListLABSection17CertInfoByDocId. " + exp.Message);
                throw;
            }
        }

        public List<LACDocumentDetailEntity> GetListLACDocumentDetailByDocId(string docId)
        {
            try
            {
                //Logging
                Logger.Debug("GetListLACDocumentDetailByDocId: The system is trying to get LAC Document Detail by " + docId);
                //Logging

                LAPGateway lAPGateway = new LAPGateway();
                return lAPGateway.GetListLACDocumentDetailByDocId(docId);
            }
            catch (Exception exp)
            {
                Logger.Error("Error in GetListLACDocumentDetailByDocId. " + exp.Message);
                throw;
            }
        }

        public List<LawFirmCaseFileRefNumberEntity> GetListLawFirmCaseFileRefNumber(string caseInfoID)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListLawFirmCaseFileRefNumberEntityByCaseInfoId(caseInfoID);
        }

        public List<LegalExperienceInfoEntity> GetListLegalExperienceInfoEntityBySGID(string sGID)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListLegalExperienceInfoBySGID(sGID);
        }

        public List<LegislationProvisionsEntity> GetListLegislationProvisionsEntityBySGId(string SGId)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListLegislationProvisionsEntityBySGID(SGId);
        }

        public List<MinuteSheetDocListEntity> GetListMinuteSheetDocListEntityByDocId(string docId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListMinuteSheetDocListByDocId(docId);
        }

        public List<NatureOfCaseEntity> GetListNatureOfCaseEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListNatureOfCaseEntityBySGID(submissionGroupId);
        }

        public List<NotPaymenttoCourtDocDetailEntity> GetListNotPaymenttoCourtDocDetailEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListNotPaymenttoCourtyDocDetailBySGId(submissionGroupId);
        }

        public List<OrdersMadeEntity> GetListOrdersMadeEntityByDocId(string docId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListOrdersMadeByDocId(docId);
        }

        //public List<NoOfSupportingDocEntity> GetListNoOfSupportingDocBySGID(string submissionGroupId)
        //{
        //    CommonGateway gateway = new CommonGateway();
        //    return gateway.GetListNoOfSupportingDocEntityBySGID(submissionGroupId);
        //}
        public List<OriginatingCaseEntity> GetListOriginatingCaseEntityBySGID(string submissionGroupId)
        {
            CommonGateway caseGateway = new CommonGateway();
            return caseGateway.GetListOriginatingCaseEntity(submissionGroupId);
        }

        public List<OSInfoEntity> GetListOSInfoEntityBySGID(string sGID)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetListOSInfoEntityBySGID(sGID);
        }

        public List<OutgoingCorrespondenceCourtFeeEntity> GetListOutgoingCorrespondenceCourtFeeEntityBySGID(string sGID)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListOutgoingCorrespondenceCourtFeeEntityBySGID(sGID);
        }

        public List<OutgoingCorrespondenceInfoEntity> GetListOutgoingCorrespondenceInfoEntityBySGID(string sGID)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListOutgoingCorrespondenceInfoEntityBySGID(sGID);
        }

        public List<PartyAmendmentEntity> GetListPartyAmendmentByDocId(string docId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListPartyAmendmentByDocId(docId);
        }

        public List<PartyAmendmentDetailEntity> GetListPartyAmendmentDetailByAmendmentId(string amendmentId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListPartyAmendmentDetailByAmendmentId(amendmentId);
        }

        public List<PartyAmendmentLeaveOfCourtEntity> GetListPartyAmendmentLeaveOfCourtByAmendmentId(string amendmentId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListPartyAmendmentLeaveOfCourtByAmendmentID(amendmentId);
        }

        public List<RCaseLawFirmEntity> GetListRCaseLawFirmEntity(string caseInfoID)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListRCaseLawFirmEntityByCaseInfoId(caseInfoID);
        }

        public List<RCaseSubmissionEntity> GetListRCaseSubmissionEntity(string caseInfoID)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListRCaseSubmissionEntityByCaseInfoId(caseInfoID);
        }

        public List<RCaseSubmissionEntity> GetListRCaseSubmissionEntityBySGID(string SGID)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListRCaseSubmissionEntityBySGID(SGID);
        }

        public List<RDocCasePartyEntity> GetListRDocCaseParty(string dCPID)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListRDocCasePartyByDCPID(dCPID);
        }

        public List<RDocCasePartyEntity> GetListRDocCasePartyByDocId(string docId)
        {
            var documentGateway = new DocumentGateway();
            return documentGateway.GetListRDocCasePartyByDocId(docId);
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

        public List<RelationalSubCaseInfoEntity> GetListRelationalSubCaseInfoBySubCaseInfoId(string subCaseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetListRelationalSubCaseInfoBySubCaseInfoId(subCaseInfoId);
        }

        public List<RequestDocDetailEntity> GetListRequestDocDetailByRequesrDocId(string requestDocId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListRequestDocDetailByRequestDocId(requestDocId);
        }

        public List<RequestHearingAdminSupportEntity> GetListRequestHearingAdminSupportEntityBySGID(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListRequestHearingAdminSupport(submissionGroupId);
        }

        public List<RequestNEGDDetailEntity> GetListRequestNEGDDetailEntityBySGID(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListRequestNEGDDetailEntityBySGID(submissionGroupId);
        }

        public List<RSubCaseSubmissionEntity> GetListRSubCaseSubmissionEntityBySubCaseInfoId(string subCaseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetListRSubCaseSubmissionEntityBySubCaseInfoId(Convert.ToInt64(subCaseInfoId));
        }

        public List<SubCasePartyEntity> GetListSubCasePartyBySubCaseInfoId(string subCaseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetSubCasePartyEntityEntityBySubCaseInfoId(Convert.ToInt64(subCaseInfoId));
        }

        /// <summary>
        /// Gets the list submission info entity.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        public List<SubmissionInfoEntity> GetListSubmissionInfoEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListSubmissionInfoEntity(submissionGroupId);
        }

        public List<SubpoenaDocDetailEntity> GetListSubpoenaDocDetailsBySGID(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListSubpoenaDocDetailsBySGID(submissionGroupId);
        }

        public List<SubpoenaInfoEntity> GetListSubpoenaInfoEntitySGID(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListSubpoenaInfoEntityBySGId(submissionGroupId);
        }

        public List<SubpoenaWitnessDetailEntity> GetListSubpoenaWitnessDetailEntityBySGID(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListSubpoenaWitnessDetailBySGID(submissionGroupId);
        }

        public List<TravelPassInfoEntity> GetListTravelPassInfoEntityBySGID(string sGID)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListTravelPassInfoBySGID(sGID);
        }

        public List<VacHRGDatesReqInfoEntity> GetListVacHRGDatesReqInfoEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListVacHRGDatesReqInfoEntityBySGID(submissionGroupId);
        }

        public List<WOEExecutionAddressEntity> GetListWOEExecutionAddressEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListWOEExecutionAddressBySGID(submissionGroupId);
        }

        public List<WOEInfoEntity> GetListWOEInfoEntityBySGID(string sGID)
        {
            SubsequentGateway gateway = new SubsequentGateway();
            return gateway.GetListWOEInfoEntityBySGID(sGID);
        }

        public List<WOEMOMSCTInfoEntity> GetListWOEMOMSCTInfoEntityBySGID(string sGID)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetListWOEMOMSCTInfoEntityBySGID(sGID);
        }

        public List<WOENCPEInfoEntity> GetListWOENCPEInfoEntityBySGID(string sGID)
        {
            SubsequentGateway gateway = new SubsequentGateway();
            return gateway.GetListWOENCPEInfoEntityBySGID(sGID);
        }

        public List<WOENECPEInfoEntity> GetListWOENECPEInfoEntityBySGID(string sGID)
        {
            SubsequentGateway gateway = new SubsequentGateway();
            return gateway.GetListWOENECPEInfoEntityBySGID(sGID);
        }

        public List<BEWorkitemDetailsEntity> GetListWorkItemDetailsEntityByWorkflowSerialNo(string workflowSerialNo)
        {
            BackEndSpecificGateway beSpecificGateway = new BackEndSpecificGateway();
            return beSpecificGateway.GetListWorkItemDetailsEntityByWorkflowSerialNo(workflowSerialNo);
        }

        public List<BEWorkitemRecipientEntity> GetListWorkItemRecipientEntityByWorkflowSerialNo(string workflowSerialNo)
        {
            BackEndSpecificGateway beSpecificGateway = new BackEndSpecificGateway();
            return beSpecificGateway.GetListWorkItemRecipientEntityByWorkflowSerialNo(workflowSerialNo);
        }

        public ICaseTypeInfo GetOriginatingSummonsBankruptcyDataBySGID(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetOriginatingSummonsBankruptcyDataBySGID(submissionGroupId);
        }

        public PaymentHRGDatesDocDetailEntity GetPaymentHRGDatesDocDetailEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetPaymentHRGDatesDocDetailEntity(submissionGroupId);
        }

        public ISubCaseTypeInfo GetPracticeOfCertificateDataBySGID(string submissionGroupId)
        {
            SubCaseDataGateway SubCaseDataGateway = new SubCaseDataGateway();
            return SubCaseDataGateway.GetPracticeOfCertificateDataBySGID(submissionGroupId);
        }

        public RARASInfoEntity GetRARASinfoEntityBySGID(string submissionGroupId)
        {
            AppealsGateway gateway = new AppealsGateway();
            return gateway.GetRARASInfoEntityBySGID(submissionGroupId);
        }

        /// <summary>
        /// Gets the <see cref="rCaseLawFirmEntity"/>
        /// </summary>
        /// <param name="rCaseLawFirmEntity">Gets the rCaseLawFirmEntity and returns Case Law Firm</param>
        /// <returns>Returns the Case Law Firm if found Else Null</returns>
        public RCaseLawFirmEntity GetRCaseLawFirm(string rCaseLawFirmEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetRCaseLawFirmEntityByPK(rCaseLawFirmEntity);
        }

        /// <summary>
        /// Get a list of RCaseLinkedEntity by passing the column name and its value.
        /// </summary>
        /// <typeparam name="V">The type for the parameter "value"</typeparam>
        /// <param name="fieldName">The name of the column in database. (Name of property of object).</param>
        /// <param name="value">The value used to filter.</param>
        /// <returns>A list of RCaseLinkedEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 29, 2011)</remarks>
        public List<RCaseLinkedEntity> GetRCaseLinked<V>(string fieldName, V value)
        {
            try
            {
                Logger.Debug("GetRCaseLinked<V>: The system is trying to get RCaseLinked by ColumnName:" + fieldName + " & Value:" + value.ToString());

                CaseGateway caseGateway = new CaseGateway();
                List<RCaseLinked> listRCaseLinked = caseGateway.GetEntity<RCaseLinked, V>(fieldName, value);

                if (listRCaseLinked != null && listRCaseLinked.Count > 0)
                    return listRCaseLinked.Select(rCaseLinked => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseLinkedEntity(rCaseLinked)).ToList();
                else
                    return null;
            }
            catch (Exception exp)
            {
                Logger.Error("Error in GetRCaseLinked<V>. " + exp.Message);
                throw;
            }
        }

        /// <summary>
        /// Gets the <see cref="rCaseSubmissionId"/>
        /// </summary>
        /// <param name="rCaseSubmissionId">Gets the rCaseSubmissionId and returns Case Submission</param>
        /// <returns>Returns the Case Submission if found Else Null</returns>
        public RCaseSubmissionEntity GetRCaseSubmissionByPK(string rCaseSubmissionId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetRCaseSubmissionEntityByPK(rCaseSubmissionId);
        }

        public RDocCaseEntity GetRDocCaseEntityByDocId(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.RDocCaseEntityByDocId(docId);
        }

        public RDocCasePartyEntity GetRDocCasePartyByPK(string primaryKey)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetRDocCaseParty(primaryKey);
        }

        public RefCaveatCaseEntity GetRefCaveatCaseEntity(string aDMCavetNoId)
        {
            AdmiralityGateway admiralityGateway = new AdmiralityGateway();
            return admiralityGateway.GetRefCaveatCaseEntity(aDMCavetNoId);
        }

        public ISubCaseTypeInfo GetRegistrarsAppealsDataBySGID(string submissionGroupId)
        {
            GenericDataGateway genericDataGateway = new GenericDataGateway();
            return genericDataGateway.GetRegistrarsAppealsDataBySGID(submissionGroupId);
        }

        public ServiceOfDocDocStatusHistoryEntity GetServiceOfDocDocStatusHistoryByPK(string primaryKey)
        {
            ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            return serviceOfDocGateway.GetServiceOfDocDocStatusHistoryByPK(primaryKey);
        }

        public ServiceOfDocDocumentEntity GetServiceOfDocDocumentEntityByPK(string primaryKey)
        {
            ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            return serviceOfDocGateway.GetServiceOfDocDocumentEntityByPK(primaryKey);

            // throw new NotImplementedException();
        }

        public ServiceOfDocInfoDetailEntity GetServiceOfDocInfoDetailByPK(string primaryKey)
        {
            ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            return serviceOfDocGateway.GetServiceOfDocInfoDetailEntityByPK(primaryKey);

            // throw new NotImplementedException();
        }

        public ServiceOfDocInfoEntity GetServiceOfDocInfoEntityBySGID(string submissionGroupId)
        {
            //ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            //return serviceOfDocGateway.GetServiceOfDocInfoEntityBySGID(submissionGroupId);

            throw new NotImplementedException();
        }

        public ISubCaseTypeInfo GetSetDownDataBySGID(string submissionGroupId)
        {
            SubCaseDataGateway subCaseDataGateway = new SubCaseDataGateway();
            return subCaseDataGateway.GetSetDownDataBySGID(submissionGroupId);
        }

        public SubCaseInfoEntity GetSubCaseInfoEntityBySubCaseInfoId(string subCaseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetSubCaseInfoEntityBySubCaseInfoId(Convert.ToInt64(subCaseInfoId));
        }

        public SubCasePartyEntity GetSubCasePartyEntity(string subCasePartyId)
        {
            SubCaseGateway subcaseGateway = new SubCaseGateway();
            return subcaseGateway.GetSubCasePartyEntityEntityByPK(subCasePartyId);
        }

        /// <summary>
        /// Gets the <see cref="SummonsData "/>
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        public ISubCaseTypeInfo GetSummonsData(string submissionGroupId)
        {
            SubCaseDataGateway subCaseDataGateway = new SubCaseDataGateway();
            return subCaseDataGateway.GetSummonsDataBySGID(submissionGroupId);
        }

        public TaskListEntity GetTaskListEntityByWorkflowSerialNo(string workflowSerialNo)
        {
            BackEndSpecificGateway beSpecificGateway = new BackEndSpecificGateway();
            return beSpecificGateway.GetTaskListEntityByWorkflowSerialNo(workflowSerialNo);
        }

        /// <summary>
        /// Gets the <see cref="WarrantOfArrest "/>
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        public ISubCaseTypeInfo GetWarrantOfArrestDataBySGID(string submissionGroupId)
        {
            SubCaseDataGateway subCaseDataGateway = new SubCaseDataGateway();
            return subCaseDataGateway.GetWarrantOfArrestDataBySGID(submissionGroupId);
        }

        /// <summary>
        /// Gets the <see cref="WOEData "/>
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        public ISubCaseTypeInfo GetWOEData(string submissionGroupId)
        {
            SubCaseDataGateway subCaseDataGateway = new SubCaseDataGateway();
            return subCaseDataGateway.GetWOEDataBySGID(submissionGroupId);
        }

        public WOEInfoEntity GetWOEInfoEntityByWOEInfoId(string woeInfoId)
        {
            SubsequentGateway gateway = new SubsequentGateway();
            return gateway.GetWOEInfoEntity(woeInfoId);
        }

        public WOEMOMSCTInfoEntity GetWOEMOMSCTInfoEntityByWOEMOMSCTInfoId(string woeMOMSCTInfoId)
        {
            CaseSpecificGateway gateway = new CaseSpecificGateway();
            return gateway.GetWOEMOMSCTInfoEntity(woeMOMSCTInfoId);
        }

        public WOENCPEInfoEntity GetWOENCPEInfoEntityByWOENCPEInfoId(string woeNCPEInfoId)
        {
            SubsequentGateway gateway = new SubsequentGateway();
            return gateway.GetWOENCPEInfoEntity(woeNCPEInfoId);
        }

        public WOENECPEInfoEntity GetWOENECPEInfoEntityByWOENECPEInfoId(string woeNECPEInfoId)
        {
            SubsequentGateway gateway = new SubsequentGateway();
            return gateway.GetWOENECPEInfoEntity(woeNECPEInfoId);
        }

        public void SaveOrUpdateADData(ISubCaseTypeInfo subCaseTypeInfo)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.SaveOrUpdateADData(subCaseTypeInfo);
        }

        public void SaveOrUpdateADMInfoEntity(ADMInfoEntity aDMInfoEntity)
        {
            AdmiralityGateway admiralityGateway = new AdmiralityGateway();
            admiralityGateway.SaveOrUpdateADMInfoEntity(aDMInfoEntity);
        }

        public void SaveOrUpdateAffidavitDeponentDetailEntity(AffidavitDeponentDetailEntity affidavitDeponentDetailEntity)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.SaveOrUpdateAffidavitDeponentDetailEntity(affidavitDeponentDetailEntity);
        }

        public void SaveOrUpdateAffidavitInfoEntity(AffidavitInfoEntity affidavitInfoEntity)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.SaveOrUpdateAffidavitInfoEntity(affidavitInfoEntity);
        }

        public void SaveOrUpdateAppealsData(AppealsData appealsData)
        {
            AppealsGateway appealsGateway = new AppealsGateway();
            appealsGateway.SaveOrUpdateAppealsData(appealsData);
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

        public void SaveOrUpdateBankruptcyData(ICaseTypeInfo iCaseTypeInfo)
        {
            BankruptcyData bankruptcyData = (BankruptcyData)iCaseTypeInfo;
            BankruptcyGateway gateway = new BankruptcyGateway();
            gateway.SaveOrUpdateBankruptcyData(bankruptcyData);
        }

        public void SaveOrUpdateBankruptcyOtherDefDetail(BankruptcyOtherDefDetailEntity bankruptcyOtherDefDetailEntity)
        {
            var gateway = new BankruptcyGateway();
            gateway.SaveOrUpdateBankruptcyOtherDefDetailEntity(bankruptcyOtherDefDetailEntity);
        }

        public void SaveOrUpdateBankyuptcyInfoEntity(BankruptcyInfoEntity bankruptcyEntity)
        {
            var gateway = new BankruptcyGateway();
            gateway.SaveOrUpdateBankruptcyInfoEntity(bankruptcyEntity);
        }

        public void SaveOrUpdateCaseData(ICaseTypeInfo iCaseTypeInfo, bool isCopy)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            caseDataGateway.SaveOrUpdateCaseData(iCaseTypeInfo, isCopy);
        }

        public void SaveOrUpdateCaseEntity(ICaseEntity caseEntity, bool isCopy)
        {
            CaseGateway caseGateway = new CaseGateway();
            if (isCopy)
                caseGateway.SaveOrUpdateInMemoryEntity<ICase>(CaseMapper.GetCaseEntity<ICaseEntity>(caseEntity));
            else
                caseGateway.SaveOrUpdateEntity<ICase>(CaseMapper.GetCaseEntity<ICaseEntity>(caseEntity));
        }

        /// <summary>
        /// Saves or Updates <see cref="CaseInfoEntity "/>
        /// </summary>
        /// <param name="caseInfoEntity"></param>
        public void SaveOrUpdateCaseInfoEntity(CaseInfoEntity caseInfoEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCaseInfoEntity(caseInfoEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="CasePartyAddress "/>
        /// </summary>
        /// <param name="casePartyAddressEntity"></param>
        public void SaveOrUpdateCasePartyAddressEntity(CasePartyAddressEntity casePartyAddressEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCasePartyAddressEntity(casePartyAddressEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="CasePartyAICAddress "/>
        /// </summary>
        /// <param name="casePartyAICAddressEntity"></param>
        public void SaveOrUpdateCasePartyAICAddressEntity(CasePartyAICAddressEntity casePartyAICAddressEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCasePartyAICAddressEntity(casePartyAICAddressEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="CasePartyAICAlias"/>
        /// </summary>
        /// <param name="casePartyAICAliasEntity"></param>
        public void SaveOrUpdateCasePartyAICAliasEntity(CasePartyAICAliasEntity casePartyAICAliasEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCasePartyAICAliasEntity(casePartyAICAliasEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="CasePartyAICDetail"/>
        /// </summary>
        /// <param name="casePartyAICDetailsEntity"></param>
        public void SaveOrUpdateCasePartyAICDetailsEntity(CasePartyAICDetailsEntity casePartyAICDetailsEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCasePartyAICDetailsEntity(casePartyAICDetailsEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="CasePartyAlias"/>
        /// </summary>
        /// <param name="casePartyAliasEntity"></param>
        public void SaveOrUpdateCasePartyAliasEntity(CasePartyAliasEntity casePartyAliasEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCasePartyAliasEntity(casePartyAliasEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="casePartyAuthorisedOfficerDetailsEntity"/>
        /// </summary>
        /// <param name="CasePartyAuthorisedOfficerDetailsEntity"></param>
        public void SaveOrUpdateCasePartyAuthorisedOfficerDetailEntity(CasePartyAuthorisedOfficerDetailsEntity casePartyAuthorisedOfficerDetailsEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCasePartyAuthorisedOfficerDetailEntity(casePartyAuthorisedOfficerDetailsEntity);
        }

        /// <summary>
        /// Saves or Updates (Test Purpose) <see cref="ICaseParty"/>
        /// </summary>
        /// <param name="iCaseParty"></param>
        public void SaveOrUpdateCasePartyData(ICasePartyData iCaseParty)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCasePartyData(iCaseParty);
        }

        /// <summary>
        /// Saves or Updates <see cref="CasePartyEntity "/>
        /// </summary>
        /// <param name="casePartyEntity"></param>
        public void SaveOrUpdateCasePartyEntity(CasePartyEntity casePartyEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCasePartyEntity(casePartyEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="CasePartyVesselDetails"/>
        /// </summary>
        /// <param name="casePartyVesselDetailsEntity"></param>
        public void SaveOrUpdateCasePartyVesselDetailEntity(CasePartyVesselDetailsEntity casePartyVesselDetailsEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCasePartyVesselDetailEntity(casePartyVesselDetailsEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="CaseSolicitor"/>
        /// </summary>
        /// <param name="caseSolicitorEntity"></param>
        public void SaveOrUpdateCaseSolicitorEntity(CaseSolicitorEntity caseSolicitorEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCaseSolicitorEntity(caseSolicitorEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="CaseSolicitorHistoryEntity"/>
        /// </summary>
        /// <param name="caseSolicitorHistoryEntity"></param>
        public void SaveOrUpdateCaseSolicitorHistoryEntity(CaseSolicitorHistoryEntity caseSolicitorHistoryEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCaseSolicitorHistoryEntity(caseSolicitorHistoryEntity);
        }

        public void SaveOrUpdateCaseSpecificEntity(ICaseSpecificEntity iCaseSpecificEntity, bool isCopy)
        {
            lock (caseSpecificLock)
            {
                CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
                if (isCopy)
                    caseSpecificGateway.SaveOrUpdateInMemoryEntity<ICaseSpecific>(CaseSpecificMapper.GetCaseSpecificEntity<ICaseSpecificEntity>(iCaseSpecificEntity));
                else
                    caseSpecificGateway.SaveOrUpdateEntity<ICaseSpecific>(CaseSpecificMapper.GetCaseSpecificEntity<ICaseSpecificEntity>(iCaseSpecificEntity));
            }
        }

        public void SaveOrUpdateChecklistInstanceEntity(ChecklistInstanceEntity checklistInstanceEntity)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.SaveOrUpdateChecklistInstanceEntity(checklistInstanceEntity);
        }

        public void SaveOrUpdateChecklistSubmissionEntity(ChecklistSubmissionEntity checklistSubmissionEntity)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.SaveOrUpdateChecklistSubmissionEntity(checklistSubmissionEntity);
        }

        public void SaveOrUpdateCommonEntity(ICommonEntity iCommonEntity, bool isCopy)
        {
            CommonGateway commonGateway = new CommonGateway();
            if (isCopy)
                commonGateway.SaveOrUpdateInMemoryEntity<ICommon>(CommonMapper.GetCommonEntity<ICommonEntity>(iCommonEntity));
            else
                commonGateway.SaveOrUpdateEntity<ICommon>(CommonMapper.GetCommonEntity<ICommonEntity>(iCommonEntity));
        }

        public void SaveOrUpdateCopyAppealsData(AppealsData appealsData)
        {
            AppealsGateway appealsGateway = new AppealsGateway();
            appealsGateway.SaveOrUpdateCopyAppealsData(appealsData);
        }

        /// <summary>
        /// Saves or Updates Copy (Test Purpose) <see cref="CasePartyAddress "/>
        /// </summary>
        /// <param name="casePartyAddressEntity"></param>
        public void SaveOrUpdateCopyCasePartyAddressEntity(CasePartyAddressEntity casePartyAddressEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCopyCasePartyAddressEntity(casePartyAddressEntity);
        }

        /// <summary>
        /// Saves or Updates Copy (Test Purpose) <see cref="CasePartyAICAddress "/>
        /// </summary>
        /// <param name="casePartyAICAddressEntity"></param>
        public void SaveOrUpdateCopyCasePartyAICAddressEntity(CasePartyAICAddressEntity casePartyAICAddressEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCopyCasePartyAICAddressEntity(casePartyAICAddressEntity);
        }

        /// <summary>
        /// Saves or Updates Copy (Test Purpose) <see cref="CasePartyAICAliasEntity"/>
        /// </summary>
        /// <param name="casePartyAICAliasEntity"></param>
        public void SaveOrUpdateCopyCasePartyAICAliasEntity(CasePartyAICAliasEntity casePartyAICAliasEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCopyCasePartyAICAliasEntity(casePartyAICAliasEntity);
        }

        /// <summary>
        /// Saves or Updates Copy (Test Purpose) <see cref="CasePartyAICDetail"/>
        /// </summary>
        /// <param name="casePartyAICDetailsEntity"></param>
        public void SaveOrUpdateCopyCasePartyAICDetailsEntity(CasePartyAICDetailsEntity casePartyAICDetailsEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCopyCasePartyAICDetailsEntity(casePartyAICDetailsEntity);
        }

        /// <summary>
        /// Saves or Updates Copy (Test Purpose) <see cref="CasePartyAlias"/>
        /// </summary>
        /// <param name="casePartyAliasEntity"></param>
        public void SaveOrUpdateCopyCasePartyAliasEntity(CasePartyAliasEntity casePartyAliasEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCopyCasePartyAliasEntity(casePartyAliasEntity);
        }

        /// <summary>
        /// Saves or Updates Copy (Test Purpose) <see cref="casePartyAuthorisedOfficerDetailsEntity"/>
        /// </summary>
        /// <param name="CasePartyAuthorisedOfficerDetailsEntity"></param>
        public void SaveOrUpdateCopyCasePartyAuthorisedOfficerDetailEntity(CasePartyAuthorisedOfficerDetailsEntity casePartyAuthorisedOfficerDetailsEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCaseCopyPartyAuthorisedOfficerDetailEntity(casePartyAuthorisedOfficerDetailsEntity);
        }

        public void SaveOrUpdateCopyCasePartyData(ICasePartyData iCaseParty)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCopyCasePartyData(iCaseParty);
        }

        /// <summary>
        /// Saves or Updates Copy (Test Purpose) <see cref="CasePartyVesselDetails"/>
        /// </summary>
        /// <param name="casePartyVesselDetailsEntity"></param>
        public void SaveOrUpdateCopyCasePartyVesselDetailEntity(CasePartyVesselDetailsEntity casePartyVesselDetailsEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCopyCasePartyVesselDetailEntity(casePartyVesselDetailsEntity);
        }

        /// <summary>
        /// Saves or Updates Copy (Test Purpose) <see cref="CaseSolicitor"/>
        /// </summary>
        /// <param name="caseSolicitorEntity"></param>
        public void SaveOrUpdateCopyCaseSolicitorEntity(CaseSolicitorEntity caseSolicitorEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCopyCaseSolicitorEntity(caseSolicitorEntity);
        }

        /// <summary>
        /// Saves or Updates Copy (Test Purpose) <see cref="CaseSolicitorHistoryEntity"/>
        /// </summary>
        /// <param name="caseSolicitorHistoryEntity"></param>
        public void SaveOrUpdateCopyCaseSolicitorHistoryEntity(CaseSolicitorHistoryEntity caseSolicitorHistoryEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCopyCaseSolicitorHistoryEntity(caseSolicitorHistoryEntity);
        }

        public void SaveOrUpdateCopyCriminalCasePartyData(ICasePartyData iCaseParty)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCopyCriminalCasePartyData(iCaseParty);
        }

        public void SaveOrUpdateCopyRCaseSubmissionEntity(RCaseSubmissionEntity rCaseSubmissionEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCopyRCaseSubmissionEntity(rCaseSubmissionEntity);
        }

        /// <summary>
        /// Saves or Updates (Test Purpose) <see cref="ICaseParty"/>
        /// </summary>
        /// <param name="iCaseParty"></param>
        public void SaveOrUpdateCriminalCasePartyData(ICasePartyData iCaseParty)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateCriminalCasePartyData(iCaseParty);
        }

        public void SaveOrUpdateCriminalDocCasePartyData(IDocCasePartyData iDocCaseParty)
        {
            DocumentGateway documentGateway = new DocumentGateway();//To Refactor the usage
            documentGateway.SaveOrUpdateCriminalDocCasePartyData(iDocCaseParty);
        }

        public void SaveOrUpdateCriminalDocCasePartyData(IDocCasePartyData docCasePartyData, bool isCopy)
        {
            DocumentGateway documentGateway = new DocumentGateway();//To Refactor the usage
            documentGateway.SaveOrUpdateCopyCriminalDocCasePartyData(docCasePartyData, isCopy);
        }

        public void SaveOrUpdateCWUData(CWUData cWUData)
        {
            CommonGateway gateway = new CommonGateway();
            gateway.SaveOrUpdateCWUData(cWUData);
        }

        public void SaveOrUpdateCWUInfoEntity(CWUInfoEntity cWUInfoEntity)
        {
            CWUGateway cWUGateway = new CWUGateway();
            cWUGateway.SaveOrUpdateCWUInfoEntity(cWUInfoEntity);
        }

        public void SaveOrUpdateDCACAInfoEntity(DCACAInfoEntity dCACAInfoEntity)
        {
            var gateway = new AppealsGateway();
            gateway.SaveOrUpdateDCACAInfoEntity(dCACAInfoEntity);
        }

        public void SaveOrUpdateDivorceInfoEntity(DivorceInfoEntity divorceInfoEntity)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.SaveOrUpdateDivorceInfoEntity(divorceInfoEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="DocCasePartyAddressEntity "/>
        /// </summary>
        /// <param name="docCasePartyAddressEntity">The doc case party address entity.</param>
        public void SaveOrUpdateDocCasePartyAddressEntity(DocCasePartyAddressEntity docCasePartyAddressEntity)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.SaveOrUpdateDocCasePartyAddressEntity(docCasePartyAddressEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="DocCasePartyAICAddressEntity "/>
        /// </summary>
        /// <param name="docCasePartyAICAddressEntity">The doc case party AIC address entity.</param>
        public void SaveOrUpdateDocCasePartyAICAddressEntity(DocCasePartyAICAddressEntity docCasePartyAICAddressEntity)
        {
            var documentGateway = new DocumentGateway();
            documentGateway.SaveOrUpdateDocCasePartyAICAddressEntity(docCasePartyAICAddressEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="DocCasePartyAICAliasEntity"/>
        /// </summary>
        /// <param name="docCasePartyAICAliasEntity">The doc case party AIC alias entity.</param>
        public void SaveOrUpdateDocCasePartyAICAliasEntity(DocCasePartyAICAliasEntity docCasePartyAICAliasEntity)
        {
            var documentGateway = new DocumentGateway();
            documentGateway.SaveOrUpdateDocCasePartyAICAliasEntity(docCasePartyAICAliasEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="DocCasePartyAICDetailsEntity"/>
        /// </summary>
        /// <param name="docCasePartyAICDetailsEntity">The doc case party AIC details entity.</param>
        public void SaveOrUpdateDocCasePartyAICDetailsEntity(DocCasePartyAICDetailsEntity docCasePartyAICDetailsEntity)
        {
            var documentGateway = new DocumentGateway();
            documentGateway.SaveOrUpdateDocCasePartyAICDetailsEntity(docCasePartyAICDetailsEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="DocCasePartyAliasEntity"/>
        /// </summary>
        /// <param name="docCasePartyAliasEntity">The doc case party alias entity.</param>
        public void SaveOrUpdateDocCasePartyAliasEntity(DocCasePartyAliasEntity docCasePartyAliasEntity)
        {
            var documentGateway = new DocumentGateway();
            documentGateway.SaveOrUpdateDocCasePartyAliasEntity(docCasePartyAliasEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="DocCasePartyAuthorisedOfficerDetailsEntity"/>
        /// </summary>
        /// <param name="docCasePartyAuthorisedOfficerDetailsEntity">The doc case party authorised officer details entity.</param>
        public void SaveOrUpdateDocCasePartyAuthorisedOfficerDetailsEntity(DocCasePartyAuthorisedOfficerDetailsEntity docCasePartyAuthorisedOfficerDetailsEntity)
        {
            var documentGateway = new DocumentGateway();
            documentGateway.SaveOrUpdateDocCasePartyAuthorisedOfficerDetailsEntity(docCasePartyAuthorisedOfficerDetailsEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="IDocCaseParty "/>
        /// </summary>
        /// <param name="iDocCaseParty">The iDocCaseParty.</param>
        public void SaveOrUpdateDocCasePartyData(IDocCasePartyData iDocCaseParty)
        {
            DocumentGateway documentGateway = new DocumentGateway();//To Refactor the usage
            documentGateway.SaveOrUpdateDocCasePartyData(iDocCaseParty);
        }

        public void SaveOrUpdateDocCasePartyData(IDocCasePartyData docCasePartyData, bool isCopy)
        {
            DocumentGateway documentGateway = new DocumentGateway();//To Refactor the usage
            documentGateway.SaveOrUpdateCopyDocCasePartyData(docCasePartyData, isCopy);
        }

        /// <summary>
        /// Saves or Updates <see cref="DocCasePartyEntity "/>
        /// </summary>
        /// <param name="docCasePartyEntity">The doc case party entity.</param>
        public void SaveOrUpdateDocCasePartyEntity(DocCasePartyEntity docCasePartyEntity)
        {
            var documentGateway = new DocumentGateway();
            documentGateway.SaveOrUpdateDocCasePartyEntity(docCasePartyEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="CasePartyVesselDetailsEntity"/>
        /// </summary>
        /// <param name="casePartyVesselDetailsEntity">The case party vessel details entity.</param>
        public void SaveOrUpdateDocCasePartyVesselDetailsEntity(DocCasePartyVesselDetailsEntity docCasePartyVesselDetailsEntity)
        {
            var documentGateway = new DocumentGateway();
            documentGateway.SaveOrUpdateDocCasePartyVesselDetailsEntity(docCasePartyVesselDetailsEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="DocCaseSolicitorEntity "/>
        /// </summary>
        /// <param name="docCaseSolicitorEntity">The doc Case Solicitor Entity.</param>
        public void SaveOrUpdateDocCaseSolicitorEntity(DocCaseSolicitorEntity docCaseSolicitorEntity)
        {
            var documentGateway = new DocumentGateway();
            documentGateway.SaveOrUpdateDocCaseSolicitorEntity(docCaseSolicitorEntity);
        }

        public void SaveOrUpdateDocumentEntity(IDocumentEntity iDocumentEntity, bool isCopy)
        {
            lock (isDocumentLock)
            {
                DocumentGateway documentGateway = new DocumentGateway();

                if (iDocumentEntity.GetType().Equals(typeof(DocumentInfoEntity)))
                {
                    documentGateway.SaveOrUpdateDocumentInfoSP((iDocumentEntity));
                }
                else if (isCopy)
                    documentGateway.SaveOrUpdateInMemoryEntity<IDocument>(DocumentMapper.GetDocumentEntity<IDocumentEntity>(iDocumentEntity));
                else
                    documentGateway.SaveOrUpdateEntity<IDocument>(DocumentMapper.GetDocumentEntity<IDocumentEntity>(iDocumentEntity));
            }
        }

        /// <summary>
        /// Saves or Updates <see cref="documentInfoEntity "/>
        /// </summary>
        /// <param name="documentInfoEntity">The r Document Infomation.</param>
        public void SaveOrUpdateDocumentInfoEntity(DocumentInfoEntity documentInfoEntity)
        {
            DocumentGateway documentGateway = new DocumentGateway();//To Refactor the usage
            documentGateway.SaveOrUpdateDocumentInfoEntity(documentInfoEntity);
        }

        public void SaveOrUpdateLABPartyData(ILABPartyData iLABParty)
        {
            LAPGateway lAPGateway = new LAPGateway();
            lAPGateway.SaveOrUpdateLABPartyData(iLABParty);
        }

        public void SaveOrUpdateLABPartyHistoryData(ILABPartyHistoryData iLABPartyHistory)
        {
            LAPGateway lAPGateway = new LAPGateway();
            lAPGateway.SaveOrUpdateLABPartyHistoryData(iLABPartyHistory);
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
        /// Saves or Updates <see cref="lawFirmCaseFileRefNumberEntity "/>
        /// </summary>
        /// <param name="lawFirmCaseFileRefNumberEntity"></param>
        public void SaveOrUpdateLawFirmCaseFileRefNumberEntity(LawFirmCaseFileRefNumberEntity lawFirmCaseFileRefNumberEntity)
        {
            CaseGateway caseGateway = new CaseGateway();//To Refactor the usage
            caseGateway.SaveOrUpdateLawFirmCaseFileRefNumberEntity(lawFirmCaseFileRefNumberEntity);
        }

        public void SaveOrUpdateLegislationProviosionsEntity(LegislationProvisionsEntity legislationProvisionsEntity)
        {
            CommonGateway commongateway = new CommonGateway();
            commongateway.SaveOrUpdateLegislationProvisionsEntity(legislationProvisionsEntity);
        }

        public void SaveOrUpdateLegislationProvisionsList(List<LegislationProvisionsEntity> legislationProvisionsList)
        {
            CommonGateway commongateway = new CommonGateway();
            commongateway.SaveOrUpdateLegislationProvisionsList(legislationProvisionsList);
        }

        public void SaveOrUpdateLiquidatedClaimEntity(LiquidatedClaimEntity liquidatedClaimEntity)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.SaveOrUpdateLiquidatedClaimEntity(liquidatedClaimEntity);
        }

        public void SaveOrUpdateLiquidatorAddressEntity(LiquidatorAddressEntity liquidatorAddressEntity)
        {
            CommonGateway gateway = new CommonGateway();
            gateway.SaveOrUpdateLiquidatorAddressEntity(liquidatorAddressEntity);
        }

        public void SaveOrUpdateLiquidatorAliasEntity(LiquidatorAliasEntity liquidatorAliasEntity)
        {
            CommonGateway gateway = new CommonGateway();
            gateway.SaveOrUpdateLiquidatorAliasEntity(liquidatorAliasEntity);
        }

        public void SaveOrUpdateLiquidatorEntity(LiquidatorEntity liquidatorEntity)
        {
            CommonGateway gateway = new CommonGateway();
            gateway.SaveOrUpdateLiquidatorEntity(liquidatorEntity);
        }

        public void SaveOrUpdateLiquidatorPICAddressEntity(LiquidatorPICAddressEntity liquidatorPICAddressEntity)
        {
            CommonGateway gateway = new CommonGateway();
            gateway.SaveOrUpdateLiquidatorPICAddressEntity(liquidatorPICAddressEntity);
        }

        public void SaveOrUpdateLiquidatorPICAliasEntity(LiquidatorPICAliasEntity liquidatorPICAliasEntity)
        {
            CommonGateway gateway = new CommonGateway();
            gateway.SaveOrUpdateLiquidatorPICAliasEntity(liquidatorPICAliasEntity);
        }

        public void SaveOrUpdateLiquidatorPICEntity(LiquidatorPICEntity liquidatorPICEntity)
        {
            CommonGateway gateway = new CommonGateway();
            gateway.SaveOrUpdateLiquidatorPICEntity(liquidatorPICEntity);
        }

        public void SaveOrUpdateNatureOfCaseEntity(NatureOfCaseEntity natureOfCaseEntity)
        {
            CommonGateway commongateway = new CommonGateway();
            commongateway.SaveOrUpdateNatureOfCaseEntity(natureOfCaseEntity);
        }

        //public void SaveOrUpdateNoOfSupportingDoc(NoOfSupportingDocEntity noOfSupportingDocEntity)
        //{
        //    var gateway = new CommonGateway();
        //    gateway.SaveOrUpdateNoOfSupportingDocEntity(noOfSupportingDocEntity);
        //}
        public void SaveOrUpdateOriginatingCaseEntity(OriginatingCaseEntity originatingCaseEntity)
        {
            var gateway = new CommonGateway();
            gateway.SaveorUpdateOriginatingCaseEntity(originatingCaseEntity);
        }

        public void SaveOrUpdateOtherITMOEntity(OtherITMOEntity otherITMOEntity)
        {
            CommonGateway gateway = new CommonGateway();
            gateway.SaveOrUpdateOtherITMOEntity(otherITMOEntity);
        }

        public void SaveOrUpdateOtherReliefsClaimEntity(OtherReliefsClaimEntity otherReliefsClaimEntity)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.SaveOrUpdateOtherReliefsClaim(otherReliefsClaimEntity);
        }

        public void SaveOrUpdatePaymentHRGDatesDocDetailEntity(PaymentHRGDatesDocDetailEntity paymentHRGDatesDocDetailEntity)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.SaveOrUpdatePaymentHRGDatesDocDetailEntity(paymentHRGDatesDocDetailEntity);
        }

        public void SaveOrUpdatePaymentInData(ISubCaseTypeInfo subCaseTypeInfo)
        {
            PaymentInData paymentInData = subCaseTypeInfo as PaymentInData;

            if (paymentInData.ListRefOrderDetailEntity != null && paymentInData.ListRefOrderDetailEntity.Count > 0)
            {
                foreach (RefOrderDetailEntity refOrderDetailEntity in paymentInData.ListRefOrderDetailEntity)
                {
                    SaveOrUpdateRefOrderDetailEntity(refOrderDetailEntity);
                }
            }

            if (paymentInData.ListPaymentInDocDetailEntity != null)
            {
                foreach (var item in paymentInData.ListPaymentInDocDetailEntity )
                {
                    SaveOrUpdatePaymentInDocDetailEntity(item);
                }
               
            }

            if (paymentInData.ListPaymentInDocFSDetailEntity != null && paymentInData.ListPaymentInDocFSDetailEntity.Count > 0)
            {
                foreach (PaymentInDocFSDetailEntity paymentInDocFSDetailEntity in paymentInData.ListPaymentInDocFSDetailEntity)
                {
                    SaveOrUpdatePaymentInDocFSDetail(paymentInDocFSDetailEntity);
                }
            }
           
        }

        public void SaveOrUpdatePaymentInDocDetailEntity(PaymentInDocDetailEntity paymentInDocDetailEntity)
        {
            PaymentInOutGateway paymentInOutGateway = new PaymentInOutGateway();
            paymentInOutGateway.SaveOrUpdatePaymentInDocDetail(paymentInDocDetailEntity);
        }

        public void SaveOrUpdatePaymentInDocFSDetail(PaymentInDocFSDetailEntity paymentInDocFSDetailEntity)
        {
            PaymentInOutGateway paymentInOutGateway = new PaymentInOutGateway();
            paymentInOutGateway.SaveOrUpdatePaymentInDocFSDetail(paymentInDocFSDetailEntity);
        }

        public void SaveOrUpdatePaymentOutData(ISubCaseTypeInfo subCaseTypeInfo)
        {
            PaymentOutData paymentOutData = subCaseTypeInfo as PaymentOutData;

            if (paymentOutData.ListRefOrderDetailEntity != null && paymentOutData.ListRefOrderDetailEntity.Count > 0)
            {
                foreach (RefOrderDetailEntity refOrderDetailEntity in paymentOutData.ListRefOrderDetailEntity)
                {
                    SaveOrUpdateRefOrderDetailEntity(refOrderDetailEntity);
                }
            }

            if (paymentOutData.ListPaymentOutDocDetailEntity != null)
            {
                foreach (var item in paymentOutData.ListPaymentOutDocDetailEntity)
                {
                    SaveOrUpdatePaymentOutDocDetailEntity(item);
                }
               
            }

            if (paymentOutData.ListPaymentOutPayInDetailEntity != null && paymentOutData.ListPaymentOutPayInDetailEntity.Count > 0)
            {
                foreach (PaymentOutPayInDetailEntity paymentOutPayInDetailEntity in paymentOutData.ListPaymentOutPayInDetailEntity)
                {
                    SaveOrUpdatePaymentOutPayInDetailEntity(paymentOutPayInDetailEntity);
                }
            }
        }

        public void SaveOrUpdatePaymentOutDocDetailEntity(PaymentOutDocDetailEntity paymentOutDocDetailEntity)
        {
            PaymentInOutGateway paymentInOutGateway = new PaymentInOutGateway();
            paymentInOutGateway.SaveOrUpdatePaymentOutDocDetail(paymentOutDocDetailEntity);
        }

        public void SaveOrUpdatePaymentOutPayInDetailEntity(PaymentOutPayInDetailEntity paymentOutPayInDetailEntity)
        {
            PaymentInOutGateway paymentInOutGateway = new PaymentInOutGateway();
            paymentInOutGateway.SaveOrUpdatePaymentOutPayInDetail(paymentOutPayInDetailEntity);
        }

        public void SaveOrUpdateRARASInfoEntity(RARASInfoEntity rARASInfoEntity)
        {
            var gateway = new AppealsGateway();
            gateway.SaveOrUpdateRARASInfoEntity(rARASInfoEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="rCaseLawFirmEntity "/>
        /// </summary>
        /// <param name="rCaseLawFirmEntity">The r Case Law Firm entity.</param>
        public void SaveOrUpdateRCaseLawFirmEntity(RCaseLawFirmEntity rCaseLawFirmEntity)
        {
            CaseGateway caseGateway = new CaseGateway();//To Refactor the usage
            caseGateway.SaveOrUpdateRCaseLawFirmEntity(rCaseLawFirmEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="RCaseSubmissionEntity "/>
        /// </summary>
        /// <param name="rCaseSubmissionEntity">The R Case Submisstin entity.</param>
        public void SaveOrUpdateRCaseSubmissionEntity(RCaseSubmissionEntity rCaseSubmissionEntity)
        {
            CaseGateway caseGateway = new CaseGateway();//To Refactor the usage
            caseGateway.SaveOrUpdateRCaseSubmissionEntity(rCaseSubmissionEntity);
        }

        public void SaveOrUpdateRDocCaseEntity(RDocCaseEntity rDOCCaseEntity)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            documentGateway.SaveOrUpdateRDocCaseEntity(rDOCCaseEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="rDocCasePartyEntity "/>
        /// </summary>
        /// <param name="rDocCasePartyEntity">The r document case party entity.</param>
        public void SaveOrUpdateRDocCasePartyEntity(RDocCasePartyEntity rDocCasePartyEntity)
        {
            DocumentGateway documentGateway = new DocumentGateway();//To Refactor the usage
            documentGateway.SaveOrUpdateRDocCasePartyEntity(rDocCasePartyEntity);
        }

        public void SaveOrUpdateRefCaveatCaseEntity(RefCaveatCaseEntity refCaveatCaseEntity)
        {
            AdmiralityGateway admiralityGateway = new AdmiralityGateway();
            admiralityGateway.SaveOrUpdateRefCaveatCaseEntity(refCaveatCaseEntity);
        }

        public void SaveOrUpdateRefOrderDetailEntity(RefOrderDetailEntity refOrderEntity)
        {
            var gateway = new CommonGateway();
            gateway.SaveOrUpdateRefOrderDetailEntity(refOrderEntity);
        }

        /// <summary>
        /// Saves the or update RSubCaseSubmission entity.
        /// </summary>
        /// <param name="rSubCaseSubmissionEntity">The RSubCaseSubmissionEntity.</param>
        public void SaveOrUpdateRSubCaseSubmissionEntity(RSubCaseSubmissionEntity rSubCaseSubmissionEntity)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            subCaseGateway.SaveOrUpdateRSubCaseSubmissionEntity(rSubCaseSubmissionEntity);
        }

        public void SaveOrUpdateServiceOfDocData(ISubCaseTypeInfo subCaseTypeInfo)
        {
            ServiceOfDocData serviceOfDocData = subCaseTypeInfo as ServiceOfDocData;

            if (serviceOfDocData.ListRefOrderDetailEntity != null && serviceOfDocData.ListRefOrderDetailEntity.Count > 0)
            {
                foreach (RefOrderDetailEntity refOrderDetailEntity in serviceOfDocData.ListRefOrderDetailEntity)
                {
                    SaveOrUpdateRefOrderDetailEntity(refOrderDetailEntity);
                }
            }

            if (serviceOfDocData.ServiceOfDocInfoEntity != null)
            {
                SaveOrUpdateServiceOfDocInfoEntity(serviceOfDocData.ServiceOfDocInfoEntity);
            }
            if (serviceOfDocData.ListServiceOfDocDocStatusHistoryEntity != null && serviceOfDocData.ListServiceOfDocDocStatusHistoryEntity.Count > 0)
            {
                foreach (ServiceOfDocDocStatusHistoryEntity serviceOfDocDocStatusHistoryEntity in serviceOfDocData.ListServiceOfDocDocStatusHistoryEntity)
                {
                    SaveOrUpdateServiceOfDocDocStatusHistoryEntity(serviceOfDocDocStatusHistoryEntity);
                }
            }
            if (serviceOfDocData.ListServiceOfDocInfoDetailEntity != null && serviceOfDocData.ListServiceOfDocInfoDetailEntity.Count > 0)
            {
                foreach (ServiceOfDocInfoDetailEntity serviceOfDocInfoDetailEntity in serviceOfDocData.ListServiceOfDocInfoDetailEntity)
                {
                    SaveOrUpdateServiceOfDocInfoDetailEntity(serviceOfDocInfoDetailEntity);
                }
            }

            if (serviceOfDocData.ListServiceOfDocDocumentEntity != null && serviceOfDocData.ListServiceOfDocDocumentEntity.Count > 0)
            {
                foreach (ServiceOfDocDocumentEntity serviceOfDocDocument in serviceOfDocData.ListServiceOfDocDocumentEntity)
                {
                    SaveOrUpdateServiceOfDocDocumentEntity(serviceOfDocDocument);
                }
            }
        }

        public void SaveOrUpdateServiceOfDocDocStatusHistoryEntity(ServiceOfDocDocStatusHistoryEntity serviceOfDocDocStatusHistoryEntity)
        {
            ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            serviceOfDocGateway.SaveOrUpdateServiceOfDocDocStatusHistoryEntity(serviceOfDocDocStatusHistoryEntity);
        }

        public void SaveOrUpdateServiceOfDocDocumentEntity(ServiceOfDocDocumentEntity serviceOfDocDocumentEntity)
        {
            ServiceOfDocGateway serviceGateway = new ServiceOfDocGateway();
            serviceGateway.SaveOrUpdateServiceOfDocDocumentEntity(serviceOfDocDocumentEntity);
        }

        public void SaveOrUpdateServiceOfDocInfoDetailEntity(ServiceOfDocInfoDetailEntity serviceOfDocInfoDetailEntity)
        {
            ServiceOfDocGateway serviceGateway = new ServiceOfDocGateway();
            serviceGateway.SaveOrUpdateServiceOfDocInfoDetailEntity(serviceOfDocInfoDetailEntity);
        }

        public void SaveOrUpdateServiceOfDocInfoEntity(ServiceOfDocInfoEntity serviceOfDocInfoEntity)
        {
            ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            serviceOfDocGateway.SaveOrUpdateServiceOfDocInfoEntity(serviceOfDocInfoEntity);
        }

        /// <summary>
        /// Saves the or update sub case data.
        /// </summary>
        /// <param name="iSubCaseTypeInfo">The i sub case type info.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        public void SaveOrUpdateSubCaseData(ISubCaseTypeInfo iSubCaseTypeInfo, bool isCopy)
        {
            SubCaseDataGateway subCaseDataGateway = new SubCaseDataGateway();
            subCaseDataGateway.SaveOrUpdateSubCaseData(iSubCaseTypeInfo, isCopy);
        }

        public void SaveOrUpdateSubCaseEntity(ISubCaseEntity iSubCaseEntity, bool isCopy)
        {
            GenericGateway genericGateway = new GenericGateway();
            genericGateway.SaveOrUpdateEntity<ISubCase>(SubCaseMapper.GetSubCase<ISubCaseEntity>(iSubCaseEntity), isCopy);
        }

        /// <summary>
        /// Saves or Updates <see cref="SubCaseInfoEntity "/>
        /// </summary>
        /// <param name="subCaseInfoEntity">The SubCaseInfoEntity.</param>
        public void SaveOrUpdateSubCaseInfoEntity(SubCaseInfoEntity subCaseInfoEntity)
        {
            var gateway = new SubCaseGateway();
            gateway.SaveOrUpdateSubCaseInfoEntity(subCaseInfoEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="SubCaseInfoEntity"/>
        /// </summary>
        /// <param name="subCaseInfoEntity"></param>
        public void SaveOrUpdateSubCaseInfoEntity(ISubCaseEntity iSubCaseInfo)
        {
            SubCaseInfoEntity subCaseInfoEntity = (SubCaseInfoEntity)iSubCaseInfo;
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            subCaseGateway.SaveOrUpdateSubCaseInfoEntity(subCaseInfoEntity);
        }

        /// <summary>
        /// Saves or Updates <see cref="SubCasePartyEntity"/>
        /// </summary>
        /// <param name="subCaseInfoEntity"></param>
        public void SaveOrUpdateSubCasePartyEntity(SubCasePartyEntity subCasePartyEntity)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            subCaseGateway.SaveOrUpdateSubCasePartyEntity(subCasePartyEntity);
        }

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

        public void SaveOrUpdateUnliquidatedClaimEntity(UnliquidatedClaimEntity UnliquidatedClaimEntity)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.SaveOrUpdateUnliquidatedClaim(UnliquidatedClaimEntity);
        }


        public List<WOECaseExecutionAddressEntity> GetListWOECaseExecutionAddress(long caseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListWOECaseExecutionAddress(caseInfoId);
        }

        public List<WOECaseExecutionAddressEntity> GetListWOECaseExecutionAddress(long caseInfoId, long? subcaseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListWOECaseExecutionAddress(caseInfoId, subcaseInfoId);
        }

        public List<RefSubCaseEntity> GetListRefSubCaseEntity(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListRefSubCaseEntityBySGID(submissionGroupId);
        }


        public ADMWAInfoEntity GetADMWAInfoEntityBySGID(string submissionGroupId)
        {
            SubCaseSpecificGateway subCaseSpecificGateway = new SubCaseSpecificGateway();
            return subCaseSpecificGateway.GetADMWAInfoEntityBySGID(submissionGroupId);
        }


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


        public List<DocCommentsEntity> GetListDocCommentsEntityByDocId(string docId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocComments(docId);
        }

        public List<RequestDocDetailEntity> GetListRequestDocDetailEntityByDocId(string docId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListRequestDocDetailByDocId(docId);
        }


        public void CommitTransaction()
        {
            Logger.Info("FilingBrokerMediatorImpl - CommitTransaction started.");

            this.applicationSessionManager.CommitTransaction();

            Logger.Info("FilingBrokerMediatorImpl - CommitTransaction ended.");
        }


        public void RollbackTransaction()
        {
            Logger.Info("FilingBrokerMediatorImpl - RollBackTransaction started");

            this.applicationSessionManager.RollBackTransaction();

            Logger.Info("FilingBrokerMediatorImpl - RollBackTransaction ended");
        }

        public List<WOERequestEntity> GetListWOERequestEntityBySGID(string sGID)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListWOERequestBySubmissionGroupId(sGID);
        }

        public List<CasePartyLACDetailEntity> GetListCasePartyLACDetailEntityByLACInfoId(string LacInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyLACDetailByLacInfoId(LacInfoId);

        }

        /// <summary>
        /// Gets the list appeal time estimation detail entity by SGID.
        /// </summary>
        /// <param name="sGID">The s GID.</param>
        /// <returns></returns>
        public List<AppealTimeEstimationDetailEntity> GetListAppealTimeEstimationDetailEntityBySGID(string sGID)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListAppealTimeEstimationDetailBySGID(sGID);
        }

        public void DeleteCasePartyCriminalInfo(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyCriminalInfoByCasePartyId(casePartyId);
        }

        /// <summary>
        /// Promotes the refer affidavit BE.
        /// </summary>
        /// <param name="referAffidavitDocID">The refer affidavit doc ID.</param>
        /// <param name="WOSNUO_DocID">The WOSNU o_ doc ID.</param>
        /// <param name="promotedDocID">The promoted doc ID.</param>
        /// <param name="isSameForum">The is same forum.</param>
        public void PromoteReferAffidavitBE(string referAffidavitDocID, string WOSNUO_DocID, string promotedDocID, string isSameForum)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.PromoteReferAffidavitBE(referAffidavitDocID, WOSNUO_DocID, promotedDocID, isSameForum);
        }


        /// <summary>
        /// Gets the list notice to refer affidavit entity by SGID.
        /// </summary>
        /// <param name="sGID">The s GID.</param>
        /// <returns></returns>
        public List<NoticeToReferAffidavitEntity> GetListNoticeToReferAffidavitEntityBySGID(string sGID)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListNoticeToReferAffidavitEntityBySGID(sGID);
        }

        public List<PrayerEntity> GetListPrayerEntityBySGID(string sGID)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListPrayerEntityBySGID(sGID);
        }

        public List<PrayerEntity> GetListPrayerEntityByHrgId(long? hRGId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListPrayerEntityByHrgId(hRGId);
        }


        public List<OrdersMadeEntity> GetListOrdersMadeEntityByHrgId(long? HRGId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListOrdersMadeEntityByHrgId(HRGId);
        }

        public List<SubCasePartyEntity> GetListSubCasePartyEntityByCasePartyId(string casePartyId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetListSubCasePartyByCasePartyId(casePartyId);
        }

        public List<LABSection17CertInfoEntity> GetListLABSection17CertInfo(string caseInfoId, string casePartyId)
        {
            LAPGateway lapGateway = new LAPGateway();
            return lapGateway.GetListLABSection17CertInfo(caseInfoId, casePartyId);
        }

        public List<SubCasePartyEntity> GetListSubCasePartyEntity(string casePartyId, string caseInfoId, string subCaseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetListSubCaseParty(casePartyId, caseInfoId, subCaseInfoId);
        }

        public ICaseTypeInfo GetRASDataBySGID(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetRASDataBySGID(submissionGroupId);
        }

        public List<NatureOfApplicationEntity> GetListNatureOfApplicationBySGID(string sGID)
        {

            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListNatureOfApplicationEntityBySGID(sGID);
        }

        public List<MSensitiveFilingACLEntity> GetAllMSensitiveFilingACL()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMSensitiveFilingACL();
        }

        public RSubCaseSubmissionEntity GetRSubCaseSubmissionEntityBySubCaseInfoId(string subCaseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetRSubCaseSubmission(subCaseInfoId).FirstOrDefault();
        }

        public List<RefOrderJOInfoEntity> GetListRefOrderJOInfoBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListRefOrderJOInfoBySGID(submissionGroupId);
        }

        public List<RequestHearingFeeDetailEntity> GetListRequestHearingFeeDetailBySGID(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListRequestHearingFeeDetail(submissionGroupId);
        }

        public List<LACInfoEntity> GetLacInfoByCaseInfoId(string caseInfoId)
        {
            LAPGateway lapGateway = new LAPGateway();
            return lapGateway.GetListLACInfoByCaseInfoId(caseInfoId);
        }

        public List<SolicitorEntity> GetListSolicitorByCaseInfoId(string caseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetSolicitorEntityByCaseInfoId(caseInfoId);
        }

        public List<SolicitorAddressEntity> GetListSolicitorAddressBySolicitorId(long solicitorId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListSolicitorAddressBySolicitorId(solicitorId);
        }

        public void DeleteSolicitorAddress(long solicitorId)
        {
            LAPGateway lapGateway = new LAPGateway();
            lapGateway.DeleteSolicitorAddress(solicitorId);
        }

        public void SaveOrUpdateLawFirmEntity(ILawFirmEntity iLawFirmEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<ILawFirm>(LawFirmMapper.GetLawFirmEntity<ILawFirmEntity>(iLawFirmEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateLawFirmEntity", ex);
                Logger.Error("Error in SaveOrUpdateLawFirmEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public RLawFirmSolicitorsEntity GetRLawFirmSolicitorsEntity(long solicitorId, string lFID)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetRLawFirmSolicitorsEntity(solicitorId, lFID);
        }

        public void SaveOrUpdateSolicitorAddress(SolicitorAddressEntity solicitorAddressEntity)
        {
            LawFirmGateway lawfirmGateway = new LawFirmGateway();
            lawfirmGateway.SaveOrUpdateSolicitorAddress(solicitorAddressEntity);
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

        public void DeleteCasePartyCitizenshipByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyCitizenshipByCasePartyId(casePartyId);
        }


        public void DeleteCasePartyBailorAddressesByCasePartyBailorInfoId(string casePartyBailorInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyBailorAddressByCasePartyBailorInfoId(casePartyBailorInfoId);
        }

        public void DeleteCasePartyBailorInfoByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyBailorInfoByCasePartyId(casePartyId);
        }
        
        public DocCaseTierTypeEntity GetDocCaseTierTypeEntityBySGID(string submissionGroupId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocCaseTierTypeEntityBySGID(submissionGroupId);
        }

        public ICaseTypeInfo GetDivorceDataBySubmissionGroupId(string submissionGroupId)
        {
            CaseDataGateway caseDataGateway = new CaseDataGateway();
            return caseDataGateway.GetDivorceData(submissionGroupId);
        }

        public List<ForeignLPSolicitorRegEntity> GetListForeignLPSolicitorRegEntityByCaseInfoId(string CaseInfoId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListForeignLPSolicitorRegEntityByCaseInfoId(CaseInfoId);
        }

        public List<ForeignLPSolicitorRegEntity> GetListForeignLPSolicitorRegEntityBySGID(string sGID)
        {
          CommonGateway commonGateway = new CommonGateway();
          return commonGateway.GetListForeignLPSolicitorRegEntityBySGID(sGID);
        }

        public List<VoteInfoEntity> GetListVoteInfoEntity(string caseInfoId)
        {
            SubCaseSpecificGateway subCaseSpecificGateway = new SubCaseSpecificGateway();
            return subCaseSpecificGateway.GetListVoteInfoEntity(caseInfoId);
        }

        public List<VoteInfoDeltaEntity> GetListVoteInfoDeltaEntity(string caseInfoId)
        {
            SubCaseSpecificGateway subCaseSpecificGateway = new SubCaseSpecificGateway();
            return subCaseSpecificGateway.GetListVoteInfoDeltaEntity(caseInfoId);
        }

        public List<LawFirmDocCaseFileRefNumberEntity> GetListLawFirmDocCaseFileRefNumberEntity(string SGID)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetLawFirmDocCaseFileRefNumberEntity(SGID);
        }

        public void DeleteCasePartyLACDetailByCasePartyId(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteCasePartyLACDetailByCasePartyId(casePartyId);
        }

        public void DeleteLawFirmCaseFileRefNumber(string LFCFRNId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeleteLawFirmCaseFileRefNumber(LFCFRNId);
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

        public long GetSolicitorIdFromMSequenceKey()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetSolicitorIdFromMSequenceKey();
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

        public void UpdateMSequenceKeySolicitorId()
        {
            MasterGateway masterGateway = new MasterGateway();
            masterGateway.UpdateMSequenceKeySolicitorId();
        }

        /// <summary>
        /// Gets the m document control forum entity by pk.
        /// </summary>
        /// <param name="primarykey">The primarykey.</param>
        /// <returns></returns>
        public IMasterEntity GetMDocControlForumEntityByPK(string primarykey)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMDocControlForumEntityByPK(primarykey);
        }

        /// <summary>
        /// Gets the list m document control forum by document code.
        /// </summary>
        /// <param name="docCode">The document code.</param>
        /// <returns></returns>
        public List<MDocControlForumEntity> GetListMDocControlForumByDocCode(string docCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListMDocControlForumByDocCode(docCode);
        }

        /// <summary>
        /// Gets the sicc fee ledger by sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        public List<SICCFeeLedgerEntity> GetSICCFeeLedgerBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetSICCFeeLedgerBySGID(submissionGroupId);
        }

        /// <summary>
        /// Gets the rm document tier sensitive entity.
        /// </summary>
        /// <param name="forumID">The forum identifier.</param>
        /// <param name="casetypeCode">The casetype code.</param>
        /// <param name="docCode">The document code.</param>
        /// <returns></returns>
        public RMDocTierSensitiveEntity GetRMDocTierSensitiveEntity(string forumID, string casetypeCode, string docCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetRMDocTierSensitiveEntity(forumID, casetypeCode, docCode);
        }

        /// <summary>
        /// Gets the pc application dates from sal.
        /// </summary>
        /// <param name="Caseinfoid">The caseinfoid.</param>
        /// <param name="PCCaseYear">The pc case year.</param>
        /// <returns></returns>
        public List<PCAppDatesFromSALEntity> GetPCAppDatesFromSAL(string Caseinfoid, decimal PCCaseYear)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetPCAppDatesFromSAL(Caseinfoid, PCCaseYear);
        }

        /// <summary>
        /// Gets the pc Request For Exemption from SGID.
        /// </summary>
        /// <param name="SGID"></param>
        /// <returns></returns>
        public List<RequestForExemptionEntity> GetRequestForExemptionbySGID(string SGID)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetRequestForExemptionbySGID(SGID);
        }

        /// <summary>
        /// Gets the pc JMCheck list Info from DocId.
        /// </summary>
        /// <param name="docId"></param>
        /// <returns></returns>
        public List<JMChecklistInfoEntity> GetListJMChecklistInfoEntityByDocId(string docId)
        {
            CaseSpecificGateway caseSpcGateway = new CaseSpecificGateway();
            return caseSpcGateway.GetListJMChecklistInfo(docId);
        }

        public List<JMOtherInfoEntity> GetListJMOtherInfo(string CaseInfoId)
        {
            CaseSpecificGateway caseSpcGateway = new CaseSpecificGateway();
            return caseSpcGateway.GetListJMOtherInfo(CaseInfoId);
        }

        public List<RMDocControlExclusionEntity> GetListRMDocControlExclusionByDocCode(string DocCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRMDocControlExclusionByDocCode(DocCode);
        }

        public List<FeeCollectionDetailEntity> GetFeeCollectionDetailBySGID(string SGID)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetFeeCollectionDetailBySGID(SGID);
        }

        public List<FeeCollectionDetailEntity> GetFeeCollectionDetailByCaseinfoid(string Caseinfoid)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetFeeCollectionDetailByCaseinfoid(Caseinfoid);
        }
        public List<FeeCollectionDetailEntity> GetAllFeeCollectionDetail()
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetAllFeeCollectionDetail();
        }

        public List<DirectionDetailsEntity> GetAllDirectionDetails()
        {
            CaseSpecificGateway caseSpcGateway = new CaseSpecificGateway();
            return caseSpcGateway.GetAllDirectionDetails();
        }

        public List<DirectionDetailsEntity> GetListDirectionDetailsByCaseInfoId(string Caseinfoid)
        {
            CaseSpecificGateway caseSpcGateway = new CaseSpecificGateway();
            return caseSpcGateway.GetListDirectionDetailsByCaseInfoId(Caseinfoid);
        }

        public void SaveOrUpdateRCaseTransferEntity(RCaseTransferEntity rCaseTransferEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdateRCaseTransferEntity(rCaseTransferEntity);
        }

        public List<LawFirmRegistrationEntity> GetListLawFirmRegistrationEntityByLFID(string lfid)
        {
            LawFirmGateway LfGateway = new LawFirmGateway();
            return LfGateway.GetListLawFirmRegistrationEntityByLFID(lfid);
        }
        public void UpdateListOfLawFirmRegistration(IList<LawFirmRegistrationEntity> lstLawFirmRegistrationEntity)
        {
            LawFirmGateway LfGateway = new LawFirmGateway();
            LfGateway.UpdateListOfLawFirmRegistration(lstLawFirmRegistrationEntity);
        }

        public List<DocLegalExperienceInfoEntity> GetListDocLegalExperienceInfoEntityBySGID(string sGID)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListDocLegalExperienceInfoBySGID(sGID);
        }

        public List<CaseLegalExperienceInfoEntity> GetListCaseLegalExperienceInfoByCaseInfoId(System.Int64 CaseInfoId)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListCaseLegalExperienceInfoByCaseInfoId(CaseInfoId);
        }

        public List<CaseLegalExperienceInfoEntity> GetListCaseLegalExperienceInfoByCaseInfoId(System.Int64 CaseInfoId, string LFID)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListCaseLegalExperienceInfoByCaseInfoId(CaseInfoId, LFID);
        }

        public List<CORSolicitorRegEntity> GetCORSolicitorRegByCaseInfoId(System.Int64 caseInfoId)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetCORSolicitorRegByCaseInfoId(caseInfoId);
        }

        public List<CORSolicitorRegDetailsEntity> GetCORSolicitorRegDetailsBySubCaseInfoId(System.Int64 subCaseInfoId)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetCORSolicitorRegDetailsBySubCaseInfoId(subCaseInfoId);
        }

        public List<ChildInfoEntity> GetChildInfoEntityBySGID(string submissionGroupId)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetChildInfoEntityBySGID(submissionGroupId);
        }

        public List<PartyCaseFileRefNumberEntity> GetListPartyCaseFileRefNumberByCaseInfoIDAndPartyID(string casePartyId, string caseInfoId, string LFID)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListPartyCaseFileRefNumberByCaseInfoIDAndPartyID(casePartyId, caseInfoId, LFID );
        }

        public void DeletePartyCaseFileRefNumberByCasePartyID(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.DeletePartyCaseFileRefNumberByCasePartyID(casePartyId);
        }

        public DocPartyCaseFileRefNumberEntity GetDocPartyCaseFileRefNumberEntityByDCPID(string dcpid)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetDocPartyCaseFileRefNumberEntityByDCPID(dcpid);
        }

        public void SaveOrUpdatePartyCasefileRefNumberSP(PartyCaseFileRefNumberEntity partyCaseFileRefNumberEntity)
        {
            CaseGateway caseGateway = new CaseGateway();
            caseGateway.SaveOrUpdatePartyCasefileRefNumberSP(partyCaseFileRefNumberEntity);
        }

        public List<DocCaseCounterClaimEntity> GetListDocCaseCounterClaimBySubmissionGroupID(System.String SGID)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListDocCaseCounterClaimBySubmissionGroupID(SGID);
        }

        public List<DocCaseCounterClaimDetailsEntity> GetListDocCaseCounterClaimDetailsBySubmissionGroupID(System.String SGID)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListDocCaseCounterClaimDetailsBySubmissionGroupID(SGID);
        }

        public void DeleteCaseCounterClaimDetailsByCaseCounterClaimID(System.String caseCounterClaimID)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteCaseCounterClaimDetailsByCaseCounterClaimID(caseCounterClaimID);
        }

        public List<CaseCounterClaimDetailsEntity> GetListCaseCounterClaimDetailsByCaseCounterClaimID(System.String caseCounterClaimID)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListCaseCounterClaimDetailsByCaseCounterClaimID(caseCounterClaimID);
        }

        public List<DocCaseCounterClaimEntity> GetListDocCaseCounterClaimByDocID(System.String docId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListDocCaseCounterClaimByDocID(docId);
        }

        public List<CaseCounterClaimEntity> GetListCaseCounterClaimByCaseCounterClaimID(System.String caseCounterClaimId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListCaseCounterClaimByCaseCounterClaimID(caseCounterClaimId);
        }

        public List<DocCaseCounterClaimDetailsEntity> GetListDocCaseCounterClaimDetailsByDocCaseCounterClaimID(System.String docCaseCounterClaimID)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListDocCaseCounterClaimDetailsByDocCaseCounterClaimID(docCaseCounterClaimID);
        }

        public List<RDocCounterClaimFiledEntity> GetRDocCounterClaimFiledEntityBySubmissionGroupID(String submissionGroupID)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetRDocCounterClaimFiledEntityBySubmissionGroupID(submissionGroupID);
        }

        #endregion

    }
}