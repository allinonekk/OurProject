#region Header

/************************************************************************************************************************************************
* Description : The mediator for Enforcement module.
*
*------------------------------------------------------------------------------------------------------------------------------------------------
*	                                    File History
*------------------------------------------------------------------------------------------------------------------------------------------------
*
*	Date			            Author			            Description
*------------------------------------------------------------------------------------------------------------------------------------------------
*   04/11/2010   		        Yan Nai                	 	Created
*   13/12/2010                  Yan Nai                     Refactor (more exception handling, conditional checking, logging)
*************************************************************************************************************************************************/
// <summary>
// File: EnforcementMediatorImpl.cs
// Description: The mediator for Enforcement module.
// </summary>
// <copyright file= "EnforcementMediatorImpl.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Data;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;
    using AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Enforcement;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Data;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Implementation of Enforcement mediator for database operation such as Create, Update, Delete, and Retrieve.
    /// </summary>
    public class EnforcementMediatorImpl : MasterMediatorImpl, IEnforcementMediator
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(EnforcementMediatorImpl));

        private ApplicationSessionManager applicationSessionManager = new ApplicationSessionManager();
        private HQueryEnforcementGateway hQueryGateWay;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Ctor
        /// </summary>
        public EnforcementMediatorImpl()
        {
            //ApplicationSessionManager applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            //applicationSession = applicationSessionManager.Session;

            //gateWay = new EnforcementGateway(applicationSession);

            //To avoid Session Timeout, move instantiation of ApplicationSessionManager to GateWay. -- Aug 11, 2011
            //gateWay = new EnforcementGateway();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that 
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        public new void BeginTransaction()
        {
            Logger.Info("EnforcementMediatorImpl - BeginTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager.BeginTransaction();

            Logger.Info("EnforcementMediatorImpl - BeginTransaction ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        public void CommitTransaction()
        {
            Logger.Info("EnforcementMediatorImpl - CommitTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CommitTransaction();

            Logger.Info("EnforcementMediatorImpl - CommitTransaction ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        public void RollBackTransaction()
        {
            Logger.Info("EnforcementMediatorImpl - RollBackTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager.RollBackTransaction();

            Logger.Info("EnforcementMediatorImpl - RollBackTransaction ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        public new void CloseSession()
        {
            Logger.Info("EnforcementMediatorImpl - CloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CloseSession();

            Logger.Info("EnforcementMediatorImpl - CloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// (Obsolete! Don't Use.) Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        public new void CommitAndCloseSession()
        {
            Logger.Info("EnforcementMediatorImpl - CommitAndCloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CommitAndCloseSession();

            Logger.Info("EnforcementMediatorImpl  - CommitAndCloseSession ended at " + DateTime.Now.ToString());
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRetrievalSqlQuery"></param>
        /// <returns></returns>
        public DataTable GetDataOnSQLQuery(string dataRetrievalSqlQuery)
        {//BUG-ENFUAT-2013082002 - Mantis:0010073
            EnforcementGateway enforcementGateway = new EnforcementGateway();
            return enforcementGateway.GetDataOnSQLQuery(dataRetrievalSqlQuery);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRetrievalSqlQuery"></param>
        /// <returns></returns>
        public DataTable GetDataOnSQLQuery(string dataRetrievalSqlQuery, CommandType commandType)
        {//BUG-ENFUAT-2013082002 - Mantis:0010073
            EnforcementGateway enforcementGateway = new EnforcementGateway();
            return enforcementGateway.GetDataOnSQLQuery(dataRetrievalSqlQuery, commandType);
        }
        
        /// <summary>
        /// Bind Bailiff Activity --> assign Bailiff's grid
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="apptType"></param>
        /// <param name="bailiffId"></param>
        /// <param name="team"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<object> BindAssignBailiffsGrid(string fromDate, string toDate, string apptType, string bailiffId, string team, bool isNoAppt, int currentPageNo, int pageRecordsCount, out int count)
        {
            int totalCount = 0;
            EnforcementGateway enforcementGateway = new EnforcementGateway();
            List<object> obj = enforcementGateway.BindAssignBailiffsGrid(fromDate, toDate, apptType, bailiffId, team, isNoAppt, currentPageNo, pageRecordsCount, out totalCount);
            count = totalCount;
            return obj;
        }

        /// <summary>
        /// Bind Bailiff Activity --> assign Bailiff's grid
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="apptType"></param>
        /// <param name="bailiffId"></param>
        /// <param name="team"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<object> BindAssignBailiffsGrid(string fromDate, string toDate, string apptType, string bailiffId, string team, bool isNoAppt, int currentPageNo, int pageRecordsCount, string courtId, out int count)
        {
            int totalCount = 0;
            EnforcementGateway enforcementGateway = new EnforcementGateway();
            List<object> obj = enforcementGateway.BindAssignBailiffsGrid(fromDate, toDate, apptType, bailiffId, team, isNoAppt, currentPageNo, pageRecordsCount, courtId, out totalCount);
            count = totalCount;
            return obj;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="caseInfoId"></param>
        /// <param name="subCaseInfoId"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<object> GetEnquiryDetails(string key, string caseInfoId, string subCaseInfoId, int currentPageNo, int pageRecordsCount, out int count, List<string> ISSubCaseIds)
        {
            int totalCount = 0;
            EnforcementGateway enforcementGateway = new EnforcementGateway();
            List<object> obj = enforcementGateway.GetEnquiryDetails(key, caseInfoId, subCaseInfoId, currentPageNo, pageRecordsCount, out totalCount, ISSubCaseIds);
            count = totalCount;
            return obj;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="caseInfoId"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<object> GetNOADetails(string caseInfoId, int currentPageNo, int pageRecordsCount, out int count)
        {       
            int totalCount = 0;     
            EnforcementGateway enforcementGateway = new EnforcementGateway();
            List<object> obj = enforcementGateway.GetNOADetails(caseInfoId, currentPageNo, pageRecordsCount, out count);
            totalCount = count;
            return obj;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subCaseInfoId"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<object> GetExecutionAddressDetails(string subCaseInfoId, int currentPageNo, int pageRecordsCount, out int count)
        {
            
            EnforcementGateway enforcementGateway = new EnforcementGateway();
            List<object> obj = enforcementGateway.GetExecutionAddressDetails(subCaseInfoId, currentPageNo, pageRecordsCount, out count);          
            return obj;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<object> BindMOMRegisterGrid(int year, int currentPageNo, int pageRecordsCount, out int count)
        {
            int totalCount = 0;
            EnforcementGateway enforcementGateway = new EnforcementGateway();
            List<object> obj = enforcementGateway.BindMOMRegisterGridTemp(year, currentPageNo, pageRecordsCount, out totalCount);
            count = totalCount;
            return obj;
        }

        /// <summary>
        /// Delete the records by passing field name and its value
        /// </summary>
        /// <typeparam name="T">Type of Entity to be deleted.</typeparam>
        /// <typeparam name="V">Type of the value of parameter</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">Value of the field.</param>
        /// <returns>Number of records deleted.</returns>
        public int DeleteCommonEntity<T, V>(string fieldName, V value)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iEnfocementNhibernateType = gateWay.TypeMapper<T>();
            return gateWay.DeleteEntity<ICommon, V>(iEnfocementNhibernateType, fieldName, value);
        }

        /// <summary>
        /// Delete the records by passing field name and its value
        /// </summary>
        /// <typeparam name="T">Type of Entity to be deleted.</typeparam>
        /// <typeparam name="V">Type of the value of parameter</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">Value of the field.</param>
        /// <returns>Number of records deleted.</returns>
        public int DeleteCaseEntity<T, V>(string fieldName, V value)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iEnfocementNhibernateType = gateWay.TypeMapper<T>();
            return gateWay.DeleteEntity<ICase, V>(iEnfocementNhibernateType, fieldName, value);
        }

        /// <summary>
        /// Delete the records by passing field name and its value
        /// </summary>
        /// <typeparam name="T">Type of Entity to be deleted.</typeparam>
        /// <typeparam name="V">Type of the value of parameter</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">Value of the field.</param>
        /// <returns>Number of records deleted.</returns>
        public int DeleteEntity<T, V>(string fieldName, V value)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iEnfocementNhibernateType = gateWay.TypeMapper<T>();
            return gateWay.DeleteEntity<IEnforcement, V>(iEnfocementNhibernateType, fieldName, value);
        }

        /// <summary>
        /// Delete the records by passing field name and its value
        /// </summary>
        /// <typeparam name="T">Type of Entity to be deleted.</typeparam>
        /// <param name="entityToBeDeleted">The entity to be deleted.</param>
        /// <returns>Number of records deleted.</returns>
        public void DeleteEntity<T>(T entityToBeDeleted)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            gateWay.DeleteEntity<IEnforcement>((EnforcementMapperToDomain.GetEnforcementEntity<T>(entityToBeDeleted)));
        }

        /// <summary>
        /// Delete the records from table by passing 2 field names and their values
        /// </summary>
        /// <typeparam name="T">Type of Entity to be deleted.</typeparam>
        /// <typeparam name="V">Type of the first value of parameter</typeparam>
        /// <typeparam name="V2">Type of the second value of parameter</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">Value of the field.</param>
        /// <param name="secondFieldName">Name of the second field.</param>
        /// <param name="secondValue">Value of the second field.</param>
        /// <param name="logicalOperator">Indicator of AND or OR.</param>
        /// <returns>Number of records deleted.</returns>
        public int DeleteEntity<T, V, V2>(string fieldName, V value, string secondFieldName, V2 secondValue, LogicalOperator logicalOperator)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iEnfocementNhibernateType = gateWay.TypeMapper<T>();
            return gateWay.DeleteEntity<IEnforcement, V, V2>(iEnfocementNhibernateType, fieldName, value, secondFieldName, secondValue, logicalOperator);
        }

        /// <summary>
        /// Delete the entity by passing query list.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <param name="queryList">The NHibernate ICriterion List.</param>
        /// <returns>Total number of deleted entity.</returns>
        public Int32 DeleteEntity<T>(ICollection<ICriterion> queryList)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iNhibernateType = gateWay.TypeMapper<T>();
            DetachedCriteria detachedCriteria = gateWay.GetDetachedCriteriaOfSpecificType(iNhibernateType);
            gateWay.TranformToDetachedCriteria(detachedCriteria, queryList);

            return gateWay.DeleteEntity<object>(detachedCriteria);
        }

        /// <summary>
        /// Retrieving a group of CaseParty by SubCaseInfoId
        /// </summary> 
        /// <param name="subCaseInfoId">The ID of SubcaseInfo</param>
        /// <returns>List of EMSCasePartyData.</returns>
        public List<EMSCasePartyData> GetEMSCasePartyData(Int64 subCaseInfoId)
        {
            EnforcementGateway gateWay = new EnforcementGateway();

            List<EMSCasePartyData> listEMSCasePartyData = new List<EMSCasePartyData>();
            List<SubCaseParty> listSubCaseParty = new List<SubCaseParty>();
            List<CaseParty> listCaseParty = new List<CaseParty>();
            List<CasePartyAICDetail> listCasePartyAICDetail = new List<CasePartyAICDetail>();

            listSubCaseParty = gateWay.GetEntity<SubCaseParty, Int64>("SubCaseInfoId", subCaseInfoId, gateWay.HasObsInd(typeof(SubCaseParty)));

            foreach (SubCaseParty scParty in listSubCaseParty)
            {
                EMSCasePartyData eMSCasePartyData = new EMSCasePartyData();

                listCaseParty = gateWay.GetEntity<CaseParty, string>("CasePartyId", scParty.CasePartyId, gateWay.HasObsInd(typeof(CaseParty)));
                listCasePartyAICDetail = gateWay.GetEntity<CasePartyAICDetail, string>("CasePartyId", scParty.CasePartyId, gateWay.HasObsInd(typeof(CasePartyAICDetail)));

                eMSCasePartyData.CaseParty = listCaseParty
                    .Select(cP => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyEntity(cP)).ToList();

                eMSCasePartyData.SubCaseParty = listSubCaseParty
                    .Where(sCP => sCP.SubCasePartyId == scParty.SubCasePartyId)
                    .Select(sCP =>
                            AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCasePartyEntity(sCP)).ToList();

                eMSCasePartyData.CasePartyAICDetails = listCasePartyAICDetail
                    .Where(cPAICDetails => cPAICDetails.CasePartyId == scParty.CasePartyId)
                    .Select(cPAICDetails =>
                            AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyAICDetailsEntity(cPAICDetails)).ToList();

                listEMSCasePartyData.Add(eMSCasePartyData);
            }
            return listEMSCasePartyData;
        }

        /// <summary>
        /// Retrieving a group of SubCaseInfo by SubCaseNo
        /// </summary> 
        /// <param name="subCaseNo">The Subcase number.</param>
        /// <returns>EMSCasePartyData.</returns>
        public EMSSubCaseInfoData GetEMSSubCaseInfoData(string subCaseNo)
        {
            try
            {
                EnforcementGateway gateWay = new EnforcementGateway();

                if (Logger.IsDebugEnabled)
                    Logger.Debug("Parameters: SubCaseNo: " + subCaseNo);

                EMSSubCaseInfoData eMSSubCaseInfoData = null;
                List<SubCaseInfo> listSubCaseInfo = gateWay.GetEntity<SubCaseInfo, string>("SubCaseNo", subCaseNo, gateWay.HasObsInd(typeof(SubCaseInfo)));

                if (listSubCaseInfo != null && listSubCaseInfo.Count == 1)// SubCaseNo is Unique
                {
                    eMSSubCaseInfoData = new EMSSubCaseInfoData();
                    List<EMSAccount> listEMSAccount = new List<EMSAccount>();
                    List<CaseInfo> listCaseInfo = new List<CaseInfo>();
                    List<RCaseSubmission> listRCaseSubmission = new List<RCaseSubmission>();
                    List<DocumentInfo> listDocumentInfo = new List<DocumentInfo>();
                    List<EMSCasePartyData> listCaseParty = new List<EMSCasePartyData>();

                    SubCaseInfo subCaseInfo = listSubCaseInfo.FirstOrDefault();//this list was retrieve by SubCaseNo which is unique.

                    listEMSAccount = subCaseInfo.EMSAccounts.ToList();
                    listCaseInfo = gateWay.GetEntity<CaseInfo, Int64>("CaseInfoId", subCaseInfo.CaseInfoId, gateWay.HasObsInd(typeof(CaseInfo)));

                    listRCaseSubmission = gateWay.GetEntity<RCaseSubmission, Int64>("CaseInfoId", subCaseInfo.CaseInfoId, gateWay.HasObsInd(typeof(RCaseSubmission)));
                    string submissionGroupId = listRCaseSubmission != null && listRCaseSubmission.Count > 0 ? listRCaseSubmission.FirstOrDefault().SubmissionGroupId : String.Empty;
                    //RCaseSubmission rCaseSubmission = listRCaseSubmission != null && listRCaseSubmission.Count > 0 ? listRCaseSubmission.FirstOrDefault() : null;
                    listDocumentInfo = gateWay.GetEntity<DocumentInfo, string>("SubmissionGroupId", submissionGroupId, gateWay.HasObsInd(typeof(DocumentInfo)));

                    eMSSubCaseInfoData.EMSAccount = listEMSAccount.Select(eMSAccount => EnforcementMapperToDTO.GetEMSAccountEntity(eMSAccount)).ToList();
                    eMSSubCaseInfoData.CaseInfo = listCaseInfo.Select(caseInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseInfoEntity(caseInfo)).ToList();
                    eMSSubCaseInfoData.SubCaseInfo = listSubCaseInfo.Select(scInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCaseInfoEntity(scInfo)).ToList();
                    eMSSubCaseInfoData.EMSCasePartyData = this.GetEMSCasePartyData(subCaseInfo.SubCaseInfoId);
                    eMSSubCaseInfoData.RCaseSubmissions = listRCaseSubmission.Select(rcaseSubmission => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseSubmissionEntity(rcaseSubmission)).ToList();
                    eMSSubCaseInfoData.DocumentInfos = listDocumentInfo.Select(documentInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfo)).ToList();

                    return eMSSubCaseInfoData;
                }
                else if (listSubCaseInfo != null && listSubCaseInfo.Count == 0)
                {
                    Logger.Error("In GetEMSSubCaseInfoData: No data had retrieved by SubCaseNo.");
                    return null;
                }
                else
                {
                    Logger.Error("In GetEMSSubCaseInfoData: SubcaseNo must not be duplicated. There is now more than one record with the SubcaseNo - " + subCaseNo);
                    throw new Exception("SubcaseNo must not be duplicated. There are now more than one records with the SubcaseNo - " + subCaseNo);
                }
            }
            catch (Exception e)
            {
                Logger.Error("Error In GetEMSSubCaseInfoData: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Retrieving of a group of SubCaseInfo by CaseNo
        /// </summary> 
        /// <param name="caseNo">The case number.</param>
        /// <returns>EMSCasePartyData</returns>
        public EMSSubCaseInfoData GetEMSSubCaseInfoDataByCaseNo(string caseNo)
        {
            try
            {
                EnforcementGateway gateWay = new EnforcementGateway();

                if (Logger.IsDebugEnabled)
                    Logger.Debug("Parameters: SubCaseNo: " + caseNo);

                EMSSubCaseInfoData eMSSubCaseInfoData = null;
                List<CaseInfo> listCaseInfo = gateWay.GetEntity<CaseInfo, string>("CaseNo", caseNo, gateWay.HasObsInd(typeof(CaseInfo)));

                if (listCaseInfo != null && listCaseInfo.Count == 1)// CaseNo is Unique
                {
                    eMSSubCaseInfoData = new EMSSubCaseInfoData();
                    List<EMSAccount> listEMSAccount = new List<EMSAccount>();
                    List<SubCaseInfo> listSubCaseInfo = new List<SubCaseInfo>();
                    List<RCaseSubmission> listRCaseSubmission = new List<RCaseSubmission>();
                    List<DocumentInfo> listDocumentInfo = new List<DocumentInfo>();
                    List<EMSCasePartyData> listCaseParty = new List<EMSCasePartyData>();

                    CaseInfo caseInfo = listCaseInfo.FirstOrDefault();//this list was retrieve by CaseNo which is unique.
                    listEMSAccount = caseInfo.EMSAccounts.ToList();
                    listSubCaseInfo = caseInfo.SubCaseInfos.ToList(); //gateWay.GetEntity<CaseInfo, Int64>("CaseInfoId", caseInfo.sCaseInfoId, this.HasObsInd(typeof(CaseInfo)));

                    listRCaseSubmission = gateWay.GetEntity<RCaseSubmission, Int64>("CaseInfoId", caseInfo.CaseInfoId, gateWay.HasObsInd(typeof(RCaseSubmission)));
                    string submissionGroupId = listRCaseSubmission != null && listRCaseSubmission.Count > 0 ? listRCaseSubmission.FirstOrDefault().SubmissionGroupId : String.Empty;
                    //RCaseSubmission rCaseSubmission = listRCaseSubmission != null && listRCaseSubmission.Count > 0 ? listRCaseSubmission.FirstOrDefault() : null;
                    listDocumentInfo = gateWay.GetEntity<DocumentInfo, string>("SubmissionGroupId", submissionGroupId, gateWay.HasObsInd(typeof(DocumentInfo)));

                    eMSSubCaseInfoData.EMSAccount = listEMSAccount.Select(eMSAccount => EnforcementMapperToDTO.GetEMSAccountEntity(eMSAccount)).ToList();
                    eMSSubCaseInfoData.CaseInfo = listCaseInfo.Select(cInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseInfoEntity(cInfo)).ToList();
                    eMSSubCaseInfoData.SubCaseInfo = listSubCaseInfo.Select(scInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCaseInfoEntity(scInfo)).ToList();
                    eMSSubCaseInfoData.RCaseSubmissions = listRCaseSubmission.Select(rcaseSubmission => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseSubmissionEntity(rcaseSubmission)).ToList();
                    eMSSubCaseInfoData.DocumentInfos = listDocumentInfo.Select(documentInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfo)).ToList();
                    //eMSSubCaseInfoData.EMSCasePartyData = this.GetEMSCasePartyData(subCaseInfo.SubCaseInfoId);
                    foreach (SubCaseInfo subCaseInfo in listSubCaseInfo)
                    {
                        if (!eMSSubCaseInfoData.EMSCasePartyData.HasContent())
                            eMSSubCaseInfoData.EMSCasePartyData = new List<EMSCasePartyData>();
                        eMSSubCaseInfoData.EMSCasePartyData.AddRange(this.GetEMSCasePartyData(subCaseInfo.SubCaseInfoId));
                    }

                    return eMSSubCaseInfoData;
                }
                else if (listCaseInfo != null && listCaseInfo.Count == 0)
                {
                    Logger.Error("In GetEMSSubCaseInfoDataByCaseNo: No data had retrieved by CaseNo.");
                    return null;
                }
                else
                {
                    Logger.Error("In GetEMSSubCaseInfoDataByCaseNo: Data retrieved by CaseNo has some invalid objects.");
                    throw new Exception("In GetEMSSubCaseInfoDataByCaseNo: Data retrieved by CaseNo has some invalid objects.");
                }
            }
            catch (Exception e)
            {
                Logger.Error("Error In GetEMSSubCaseInfoDataByCaseNo: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Get the entities by passing query list.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <param name="queryList">The NHibernate ICriterion List.</param>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        public List<T> GetEntity<T>(ICollection<ICriterion> queryList)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iNhibernateType = gateWay.TypeMapper<T>();
            DetachedCriteria detachedCriteria = gateWay.GetDetachedCriteriaOfSpecificType(iNhibernateType);
            gateWay.TranformToDetachedCriteria(detachedCriteria, queryList);

            //Add ObsInd = N 
            if (gateWay.HasObsInd(iNhibernateType))
                gateWay.AddObsInd(detachedCriteria, string.Empty);

            List<object> listNHibernateEntity = gateWay.GetEntity<object>(detachedCriteria);
            return gateWay.MapToDomainObject<T>(listNHibernateEntity).ToList();
        }

        /// <summary>
        /// Retrieve the defined number of records base on filed and value.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the value to use as the filter while retrieving.</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">Value of the field.</param>
        /// <param name="sortFiledName">Name of the field to use for sorting.</param>
        /// <param name="sortDirection">Sort direction (ASC or DESC).</param>
        /// <param name="rows">Number of rows to retrieve.</param>
        /// <param name="pageIndex">Current page index.</param>
        /// <param name="totalResult">To get back the total number of record.</param>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        public List<T> GetEntity<T>(ICollection<ICriterion> queryList, string sortFiledName, SortingDirection sortDirection, Int32 rows, Int32 pageIndex, ref Int32 totalResult)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iNhibernateType = gateWay.TypeMapper<T>();
            DetachedCriteria detachedCriteria = gateWay.GetDetachedCriteriaOfSpecificType(iNhibernateType);

            //Add Criteria
            if (queryList.HasContent())
                gateWay.TranformToDetachedCriteria(detachedCriteria, queryList);

            //Add ObsInd = N 
            if (gateWay.HasObsInd(iNhibernateType))
                gateWay.AddObsInd(detachedCriteria, string.Empty);

            //Add Paging
            if (pageIndex >= 0)
                gateWay.AddPaging(detachedCriteria, rows, pageIndex);

            //Add Sorting
            if (!string.IsNullOrEmpty(sortFiledName))
                gateWay.AddOrderBy(detachedCriteria, sortFiledName, sortDirection);

            List<object> listNHibernateEntity = gateWay.GetEntity<object>(detachedCriteria, ref totalResult);
            return gateWay.MapToDomainObject<T>(listNHibernateEntity).ToList();
        }

        /// <summary>
        /// Retrieve the defined number of records base on filed and value.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the value to use as the filter while retrieving.</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">Value of the field.</param>
        /// <param name="sortFiledName">Name of the field to use for sorting.</param>
        /// <param name="sortDirection">Sort direction (ASC or DESC).</param>
        /// <param name="rows">Number of rows to retrieve.</param>
        /// <param name="pageIndex">Current page index.</param>
        /// <param name="totalResult">To get back the total number of record.</param>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        public List<T> GetEntity<T>(ICollection<ICriterion> queryList
            , List<string> groupByFields
            , string sortFiledName
            , SortingDirection sortDirection
            , Int32 rows
            , Int32 pageIndex
            , ref Int32 totalResult)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iNhibernateType = gateWay.TypeMapper<T>();
            DetachedCriteria detachedCriteria = gateWay.GetDetachedCriteriaOfSpecificType(iNhibernateType);

            //Add Criteria
            if (queryList.HasContent())
                gateWay.TranformToDetachedCriteria(detachedCriteria, queryList);

            //Add ObsInd = N 
            if (gateWay.HasObsInd(iNhibernateType))
                gateWay.AddObsInd(detachedCriteria, string.Empty);

            //Add Paging
            if (pageIndex >= 0)
                gateWay.AddPaging(detachedCriteria, rows, pageIndex);

            //Add Sorting
            if (!string.IsNullOrEmpty(sortFiledName))
                gateWay.AddOrderBy(detachedCriteria, sortFiledName, sortDirection);

            //Add Grouping
            if (groupByFields.HasContent())
                gateWay.AddGroupBy(detachedCriteria, groupByFields);

            List<object> listNHibernateEntity = gateWay.GetEntity<object>(detachedCriteria, ref totalResult);
            return gateWay.MapToDomainObject<T>(listNHibernateEntity).ToList();
        }

        /// <summary>
        /// Get the entities by passing query list.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <param name="queryList">The NHibernate ICriterion List.</param>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        public List<T> GetEntityObsIndIgnore<T>(ICollection<ICriterion> queryList)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iNhibernateType = gateWay.TypeMapper<T>();
            DetachedCriteria detachedCriteria = gateWay.GetDetachedCriteriaOfSpecificType(iNhibernateType);
            gateWay.TranformToDetachedCriteria(detachedCriteria, queryList);

            List<object> listNHibernateEntity = gateWay.GetEntity<object>(detachedCriteria);
            return gateWay.MapToDomainObject<T>(listNHibernateEntity).ToList();
        }

        /// <summary>
        /// Retrieve all records of the specific entity.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        public List<T> GetEntity<T>()
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iNhibernateType = gateWay.TypeMapper<T>();
            List<object> listNHibernateEntity = gateWay.GetEntity<object>(iNhibernateType, gateWay.HasObsInd(iNhibernateType));
            return gateWay.MapToDomainObject<T>(listNHibernateEntity).ToList();
        }

        /// <summary>
        /// Retrieve all records which is equal to the value passed.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the value of the parameter.</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">Value of the field.</param>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        public List<T> GetEntity<T, V>(string fieldName, V value)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iNhibernateType = gateWay.TypeMapper<T>();
            List<object> listNHibernateEntity = gateWay.GetEntity<object, V>(iNhibernateType, fieldName, value, gateWay.HasObsInd(iNhibernateType));

            return gateWay.MapToDomainObject<T>(listNHibernateEntity).ToList();
        }

        /// <summary>
        /// Retrieve all records which fall between the two values.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the value of parameter.</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="valueFrom">Start Value of the field.</param>
        /// <param name="valueTo">End Value of the field.</param>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        public List<T> GetEntity<T, V>(string fieldName, V valueFrom, V valueTo)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iNhibernateType = gateWay.TypeMapper<T>();
            List<object> listNHibernateEntity = gateWay.GetEntity<object, V>(iNhibernateType, fieldName, valueFrom, valueTo, gateWay.HasObsInd(iNhibernateType));

            return gateWay.MapToDomainObject<T>(listNHibernateEntity).ToList();
        }
        
        /// <summary>
        /// Retrieve all records which is 'like' the value passed.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <param name="fieldName">Name of the 'like'n field.</param>
        /// <param name="value">Value of the 'like' field.</param> 
        /// <returns>List of <typeparamref name="T"/>.</returns>
        public List<T> GetEntityLike<T>(string fieldName, string value)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type nhibernateType = gateWay.TypeMapper<T>();
            List<object> listNHibernateEntity = gateWay.GetEntityLike<object>(nhibernateType, fieldName, value, gateWay.HasObsInd(nhibernateType));

            return gateWay.MapToDomainObject<T>(listNHibernateEntity).ToList();
        }
        
        /// <summary>
        /// Retrieve all records which is equal to the first and second value passed.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the first value.</typeparam>
        /// <typeparam name="V1">Type of the second value.</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">Start Value of the field.</param>
        /// <param name="secondFieldName">Name of the second field.</param>
        /// <param name="secondValue">Value of the second field.</param>
        /// <param name="logicOperator">Operator (AND || OR) which will apply on the 2 values.</param>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        public List<T> GetEntity<T, V, V1>(string fieldName, V value, string secondFieldName, V1 secondValue, LogicalOperator logicOperator)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iNhibernateType = gateWay.TypeMapper<T>();
            List<object> listNHibernateEntity = gateWay.GetEntity<object, V, V1>(iNhibernateType, fieldName, value, secondFieldName, secondValue, logicOperator, gateWay.HasObsInd(iNhibernateType));

            return gateWay.MapToDomainObject<T>(listNHibernateEntity).ToList();
        }

        /// <summary>
        /// Gets the Maintain Cheque
        /// </summary>
        /// <param name="chequeNoFrom">Start Cheque Number.</param>
        /// <param name="chequeNoTo">End Cheque Number.</param>
        /// <param name="payDateFrom">Payment Date From.</param>
        /// <param name="payDateTo">Payment Date To.</param>
        /// <param name="subCaseNo">Subcase number.</param>
        /// <param name="accountNo">Account Number.</param>
        /// <param name="chequeStatus">Status of the Cheque.</param>
        /// <param name="chequeId">The ID of Cheque.</param>
        /// <param name="isMainTainCheque">Indicate if it is used for Maintain Cheque.</param>
        /// <returns>Returns the List of EnfrocementProcessPaymentQREntity</returns>
        public List<EnfrocementMaintainChequeQREntity> GetMaintainCheque(string chequeNoFrom, string chequeNoTo, DateTime payDateFrom, DateTime payDateTo, string subCaseNo, string accountNo, string chequeStatus, string chequeId, bool isMainTainCheque, List<string> listForumId)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            hQueryGateWay = new HQueryEnforcementGateway();// (applicationSession);
            return hQueryGateWay.GetMaintainCheque(chequeNoFrom, chequeNoTo, payDateFrom, payDateTo, subCaseNo, accountNo, chequeStatus, chequeId, isMainTainCheque, listForumId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<MOMRegisterViewEntity> GetPagedMOMRegisterViewEntity(int year, int currentPageNo, int pageRecordsCount, out int count)
        {
            EnforcementGateway enforcementGateway = new EnforcementGateway();
            return enforcementGateway.BindMOMRegisterGrid(year, currentPageNo, pageRecordsCount, out count);
        }

        /// <summary>
        /// Gets the ProcessPayment
        /// </summary>
        /// <param name="paymentVoucherNo">The payment voucher number.</param>
        /// <param name="voucherDateFrom">The start date of payment voucher.</param>
        /// <param name="voucherDateTo">Ther end date of payment voucher.</param>
        /// <param name="subCaseNo">The subcase number.</param>
        /// <param name="payeeName">The name of Payee.</param>
        /// <param name="accountNo">The account number.</param>
        /// <param name="isCase">Indicate if it is case or subcase.</param>
        /// <returns>Returns the List of EnfrocementProcessPaymentQREntity</returns>
        public List<EnfrocementProcessPaymentQREntity> GetProcessPayment(string paymentVoucherNo, DateTime voucherDateFrom, DateTime voucherDateTo, string subCaseNo, string payeeName, string accountNo, bool isCase, List<string> listForumId)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            hQueryGateWay = new HQueryEnforcementGateway();// (applicationSession);
            return hQueryGateWay.GetProcessPayment(paymentVoucherNo, voucherDateFrom, voucherDateTo, subCaseNo, payeeName, accountNo, listForumId);
        }

        /// <summary>
        /// Insert and update a group of Parent/Child of CashBookReconciliation.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        public void SaveCashBookReconciliationPayment(EnforcementParentChildInsert parentChildInsert)
        {
            if (parentChildInsert.listParent.HasContent())
            {
                EnforcementGateway gateWay = new EnforcementGateway();
                foreach (EMSCashBookReconcileEntity iEnforcementEntity in parentChildInsert.listParent)
                {
                    EMSCashBookReconcile cbReconcile = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(iEnforcementEntity) as EMSCashBookReconcile;
                    gateWay.SaveOrUpdateEntity<IEnforcement>(cbReconcile, false);

                    if (parentChildInsert.listChild.HasContent())
                    {
                        List<IEnforcementEntity> listCBReconcileToSave = parentChildInsert.listChild.Where(paymentChequeDomain =>
                                    (paymentChequeDomain as EMSCashBookItemEntity).EMSCashBookReconcileId == cbReconcile.EMSCashBookReconcileId).ToList();

                        foreach (EMSCashBookItemEntity paymentChequeDomain in listCBReconcileToSave)
                        {
                            EMSCashBookItem cbItem = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(paymentChequeDomain) as EMSCashBookItem;
                            cbItem.EMSCashBookReconcile = cbReconcile;
                            gateWay.SaveOrUpdateEntity<IEnforcement>(cbItem, false);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Insert and update a group of Parent/Child of ChequePayment.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        public void SaveChequePayment(EnforcementParentChildInsert parentChildInsert)
        {
            if (parentChildInsert.listParent.HasContent())
            {
                EnforcementGateway gateWay = new EnforcementGateway();
                foreach (EMSChequeEntity iEnforcementEntity in parentChildInsert.listParent)
                {
                    EMSCheque chq = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(iEnforcementEntity) as EMSCheque;
                    gateWay.SaveOrUpdateEntity<IEnforcement>(chq, true);

                    if (parentChildInsert.listChild.HasContent())
                    {
                        foreach (IEnforcementEntity entityToSave in parentChildInsert.listChild)
                        {
                            if (entityToSave.GetType() == typeof(EMSPaymentChequeEntity) && (entityToSave as EMSPaymentChequeEntity).EMSChequeId == chq.EMSChequeId)
                            {
                                EMSPaymentCheque paymentCheque = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSPaymentCheque;
                                paymentCheque.EMSCheque = chq;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(paymentCheque, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSStateFundEntity) && (entityToSave as EMSStateFundEntity).EMSChequeId == chq.EMSChequeId)
                            {
                                EMSStateFund eMSStateFund = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSStateFund;
                                eMSStateFund.EMSCheque = chq;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSStateFund, true);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Insert and update a group of Parent/Child of EMSAccount.
        /// </summary>
        /// <param name="parentChildInsert"></param>
        public void SaveEMSAccountGroup(EnforcementParentChildInsert parentChildInsert)
        {
            if (parentChildInsert.listParent.HasContent())
            {
                EnforcementGateway gateWay = new EnforcementGateway();
                foreach (EMSAccountEntity iEnforcementEntity in parentChildInsert.listParent)
                {
                    EMSAccount eMSAccount = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(iEnforcementEntity) as EMSAccount;
                    gateWay.SaveOrUpdateEntity<IEnforcement>(eMSAccount, true);

                    if (parentChildInsert.listChild.HasContent())
                    {
                        foreach (IEnforcementEntity entityChildToSave in parentChildInsert.listChild)
                        {
                            if (entityChildToSave.GetType() == typeof(EMSAppointmentEntity) && (entityChildToSave as EMSAppointmentEntity).EMSAccountId == eMSAccount.EMSAccountId)
                            {
                                EMSAppointment eMSAppointment = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityChildToSave) as EMSAppointment;
                                eMSAppointment.EMSAccount = eMSAccount;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSAppointment, true);

                                if (parentChildInsert.listGrandChild.HasContent())
                                {
                                    foreach (IEnforcementEntity entityGrandChildToSave in parentChildInsert.listGrandChild)
                                    {
                                        if (entityGrandChildToSave.GetType() == typeof(EMSApptDebtorEntity)
                                                && (entityGrandChildToSave as EMSApptDebtorEntity).EMSAppointmentId == eMSAppointment.EMSAppointmentId)
                                        {
                                            EMSApptDebtor eMSApptDebtor = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityGrandChildToSave) as EMSApptDebtor;
                                            eMSApptDebtor.EMSAppointment = eMSAppointment;
                                            gateWay.SaveOrUpdateEntity<IEnforcement>(eMSApptDebtor, true);
                                        }
                                    }
                                }
                            }
                            else if (entityChildToSave.GetType() == typeof(EMSFileMovementEntity) && (entityChildToSave as EMSFileMovementEntity).EMSAccountId == eMSAccount.EMSAccountId)
                            {
                                EMSFileMovement eMSFileMovement = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityChildToSave) as EMSFileMovement;
                                eMSFileMovement.EMSAccount = eMSAccount;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSFileMovement, true);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Insert and update a group of Parent/Child of EMSAdmProperty.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        public void SaveEMSAdmPropertyGroup(EnforcementParentChildInsert parentChildInsert)
        {
            if (parentChildInsert.listParent.HasContent())
            {
                EnforcementGateway gateWay = new EnforcementGateway();
                foreach (EMSAdmPropertyEntity iEnforcementEntity in parentChildInsert.listParent)
                {
                    EMSAdmProperty property = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(iEnforcementEntity) as EMSAdmProperty;
                    gateWay.SaveOrUpdateEntity<IEnforcement>(property, false);

                    if (parentChildInsert.listChild.HasContent())
                    {
                        foreach (IEnforcementEntity entityToSave in parentChildInsert.listChild)
                        {
                            if (entityToSave.GetType() == typeof(EMSAdmPropertyListEntity) && (entityToSave as EMSAdmPropertyListEntity).EMSAdmPropertyId == property.EMSAdmPropertyId)
                            {
                                EMSAdmPropertyList propertyList = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSAdmPropertyList;
                                propertyList.EMSAdmProperty = property;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(propertyList, false);
                            }
                            else if (entityToSave.GetType() == typeof(EMSAdmReleaseEntity) && (entityToSave as EMSAdmReleaseEntity).EMSAdmPropertyId == property.EMSAdmPropertyId)
                            {
                                EMSAdmRelease eMSAdmRelease = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSAdmRelease;
                                eMSAdmRelease.EMSAdmProperty = property;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSAdmRelease, false);
                            }
                            else if (entityToSave.GetType() == typeof(EMSAdmExecEntity) && (entityToSave as EMSAdmExecEntity).EMSAdmPropertyId == property.EMSAdmPropertyId)
                            {
                                EMSAdmExec eMSAdmExec = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSAdmExec;
                                eMSAdmExec.EMSAdmProperty = property;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSAdmExec, false);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Insert and update a group of Parent/Child of EMSRecapitulation.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        public void SaveEMSCrmCaseGroup(EnforcementParentChildInsert parentChildInsert)
        {
            if (parentChildInsert.listParent.HasContent())
            {
                EnforcementGateway gateWay = new EnforcementGateway();
                foreach (EMSCrmCaseEntity iEnforcementEntity in parentChildInsert.listParent)
                {
                    EMSCrmCase eMSCrmCase = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(iEnforcementEntity) as EMSCrmCase;
                    gateWay.SaveOrUpdateEntity<IEnforcement>(eMSCrmCase, true);

                    if (parentChildInsert.listChild.HasContent())
                    {
                        foreach (IEnforcementEntity childEntityToSave in parentChildInsert.listChild)
                        {
                            if (childEntityToSave.GetType() == typeof(EMSCrmCaseExecAddrEntity)
                                && (childEntityToSave as EMSCrmCaseExecAddrEntity).EMSCrmCaseId == eMSCrmCase.EMSCrmCaseId)
                            {
                                EMSCrmCaseExecAddr eMSCrmCaseExecAddr = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(childEntityToSave) as EMSCrmCaseExecAddr;
                                eMSCrmCaseExecAddr.EMSCrmCase = eMSCrmCase;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSCrmCaseExecAddr, true);
                            }
                            else if (childEntityToSave.GetType() == typeof(EMSCrmCaseWLDetEntity)
                                && (childEntityToSave as EMSCrmCaseWLDetEntity).EMSCrmCaseId == eMSCrmCase.EMSCrmCaseId)
                            {
                                EMSCrmCaseWLDet eMSCrmCaseWLDet = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(childEntityToSave) as EMSCrmCaseWLDet;
                                eMSCrmCaseWLDet.EMSCrmCase = eMSCrmCase;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSCrmCaseWLDet, true);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Insert and update a group of Parent/Child of EMSRecapitulation.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        public void SaveEMSRecapitulationGroup(EnforcementParentChildInsert parentChildInsert)
        {
            if (parentChildInsert.listParent.HasContent())
            {
                EnforcementGateway gateWay = new EnforcementGateway();
                foreach (EMSRecapitulationEntity iEnforcementEntity in parentChildInsert.listParent)
                {
                    EMSRecapitulation eMSRecapitulation = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(iEnforcementEntity) as EMSRecapitulation;
                    gateWay.SaveOrUpdateEntity<IEnforcement>(eMSRecapitulation, true);

                    if (parentChildInsert.listChild.HasContent())
                    {
                        foreach (IEnforcementEntity entityToSave in parentChildInsert.listChild)
                        {
                            if (entityToSave.GetType() == typeof(EMSRecapitDetailsEntity) && (entityToSave as EMSRecapitDetailsEntity).EMSRecapitulationId == eMSRecapitulation.EMSRecapitulationId)
                            {
                                EMSRecapitDetails eMSRecapitDetails = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSRecapitDetails;
                                eMSRecapitDetails.EMSRecapitulation = eMSRecapitulation;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSRecapitDetails, true);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Insert and update a group of Parent/Child of EMSReceipt.
        /// </summary>
        /// <param name="parentChildInsert"></param>
        public void SaveEMSReceiptGroup(EnforcementParentChildInsert parentChildInsert)
        {
            if (parentChildInsert.listParent.HasContent())
            {
                EnforcementGateway gateWay = new EnforcementGateway();
                foreach (EMSReceiptEntity iEnforcementEntity in parentChildInsert.listParent)
                {
                    EMSReceipt eMSReceipt = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(iEnforcementEntity) as EMSReceipt;
                    gateWay.SaveOrUpdateEntity<IEnforcement>(eMSReceipt, true);

                    if (parentChildInsert.listChild.HasContent())
                    {
                        foreach (IEnforcementEntity childEntityToSave in parentChildInsert.listChild)
                        {
                            if (childEntityToSave.GetType() == typeof(EMSRecTransEntity) && (childEntityToSave as EMSRecTransEntity).EMSReceiptId == eMSReceipt.EMSReceiptId)
                            {
                                EMSRecTrans eMSRecTrans = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(childEntityToSave) as EMSRecTrans;
                                eMSRecTrans.EMSReceipt = eMSReceipt;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSRecTrans, true);

                                if (parentChildInsert.listGrandChild.HasContent())
                                {
                                    foreach (IEnforcementEntity grandChildEntityToSave in parentChildInsert.listGrandChild)
                                    {
                                        if (grandChildEntityToSave.GetType() == typeof(EMSExecLedgerEntity) && (grandChildEntityToSave as EMSExecLedgerEntity).EMSRecTransId == eMSRecTrans.EMSRecTransId)
                                        {
                                            EMSExecLedger eMSExecLedger = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(grandChildEntityToSave) as EMSExecLedger;
                                            eMSExecLedger.EMSRecTrans = eMSRecTrans;
                                            gateWay.SaveOrUpdateEntity<IEnforcement>(eMSExecLedger, true);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Insert and update a group of Parent/Child of EMSSale.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        public void SaveEMSSaleGroup(EnforcementParentChildInsert parentChildInsert)
        {
            if (parentChildInsert.listParent.HasContent())
            {
                EnforcementGateway gateWay = new EnforcementGateway();
                foreach (EMSSaleEntity iEnforcementEntity in parentChildInsert.listParent)
                {
                    EMSSale eMSSale = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(iEnforcementEntity) as EMSSale;
                    gateWay.SaveOrUpdateEntity<IEnforcement>(eMSSale, true);

                    if (parentChildInsert.listChild.HasContent())
                    {
                        foreach (IEnforcementEntity entityToSave in parentChildInsert.listChild)
                        {
                            if (entityToSave.GetType() == typeof(EMSSaleAdvertEntity) && (entityToSave as EMSSaleAdvertEntity).EMSSaleId == eMSSale.EMSSaleId)
                            {
                                EMSSaleAdvert eMSSaleAdvert = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSSaleAdvert;
                                eMSSaleAdvert.EMSSale = eMSSale;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSSaleAdvert, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSSaleAuctioneerEntity) && (entityToSave as EMSSaleAuctioneerEntity).EMSSaleId == eMSSale.EMSSaleId)
                            {
                                EMSSaleAuctioneer eMSSaleAuctioneer = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSSaleAuctioneer;
                                eMSSaleAuctioneer.EMSSale = eMSSale;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSSaleAuctioneer, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSSaleAgentEntity) && (entityToSave as EMSSaleAgentEntity).EMSSaleId == eMSSale.EMSSaleId)
                            {
                                EMSSaleAgent eMSSaleAgent = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSSaleAgent;
                                eMSSaleAgent.EMSSale = eMSSale;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSSaleAgent, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSSaleAppraiserEntity) && (entityToSave as EMSSaleAppraiserEntity).EMSSaleId == eMSSale.EMSSaleId)
                            {
                                EMSSaleAppraiser eMSSaleAppraiser = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSSaleAppraiser;
                                eMSSaleAppraiser.EMSSale = eMSSale;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSSaleAppraiser, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSSaleBuyerEntity) && (entityToSave as EMSSaleBuyerEntity).EMSSaleId == eMSSale.EMSSaleId)
                            {
                                EMSSaleBuyer eMSSaleBuyer = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSSaleBuyer;
                                eMSSaleBuyer.EMSSale = eMSSale;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSSaleBuyer, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSADMSaleOthersEntity) && (entityToSave as EMSADMSaleOthersEntity).EMSSaleId == eMSSale.EMSSaleId)
                            {
                                EMSADMSaleOthers eMSADMSaleOthers = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSADMSaleOthers;
                                eMSADMSaleOthers.EMSSale = eMSSale;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSADMSaleOthers, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSAdmChargesEntity) && (entityToSave as EMSAdmChargesEntity).EMSSaleId == eMSSale.EMSSaleId)
                            {
                                EMSAdmCharges eMSAdmCharges = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSAdmCharges;
                                eMSAdmCharges.EMSSale = eMSSale;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSAdmCharges, true);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Save all Enforcement entities. Only for Enforcement entities.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be saved.</typeparam>
        /// <param name="iEnforcementEntity">Object that is to be saved.</param>
        /// <param name="isCopy">Indicator that this is to use Cache in NHibernate or not.</param>
        public void SaveOrUpdateEntity<T>(T iEnforcementEntity, bool isCopy)
            where T : IEnforcementEntity
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            gateWay.SaveOrUpdateEntity<IEnforcement>(EnforcementMapperToDomain.GetEnforcementEntity<T>(iEnforcementEntity), isCopy);
        }

        /// <summary>
        /// Save all kinds of entity specified in the Type parameter.
        /// </summary>
        /// <typeparam name="TSource">Type of the entity to be saved.</typeparam>
        /// <param name="objectToSave">Object that is to be saved.</param>
        /// <param name="isCopy">Indicator that this is to use Cache in NHibernate or not.</param>
        public void SaveOrUpdateGenericEntity<TSource>(TSource objectToSave, bool isCopy)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            if (typeof(TSource).IsInterfaceImplementOf(typeof(IEnforcementEntity)))
                gateWay.SaveOrUpdateEntity<IEnforcement>(gateWay.MapToNHibernateObject<TSource, IEnforcement>(objectToSave), isCopy);
            else if (typeof(TSource).IsInterfaceImplementOf(typeof(ICaseEntity)))
                gateWay.SaveOrUpdateEntity<ICase>(gateWay.MapToNHibernateObject<TSource, ICase>(objectToSave), isCopy);
            else if (typeof(TSource).IsInterfaceImplementOf(typeof(IBackEndSpecificEntity)))
                gateWay.SaveOrUpdateEntity<IBackEndSpecific>(gateWay.MapToNHibernateObject<TSource, IBackEndSpecific>(objectToSave), isCopy);
            else if (typeof(TSource).IsInterfaceImplementOf(typeof(IMasterEntity)))
                gateWay.SaveOrUpdateEntity<IMaster>(gateWay.MapToNHibernateObject<TSource, IMaster>(objectToSave), isCopy);
            else if (typeof(TSource).IsInterfaceImplementOf(typeof(IDocumentEntity)))
                gateWay.SaveOrUpdateEntity<IDocument>(gateWay.MapToNHibernateObject<TSource, IDocument>(objectToSave), isCopy);
            else if (typeof(TSource).IsInterfaceImplementOf(typeof(ISubCaseEntity)))
                gateWay.SaveOrUpdateEntity<ISubCase>(gateWay.MapToNHibernateObject<TSource, ISubCase>(objectToSave), isCopy);
            else if (typeof(TSource).IsInterfaceImplementOf(typeof(ICommonEntity)))
                gateWay.SaveOrUpdateEntity<ICommon>(gateWay.MapToNHibernateObject<TSource, ICommon>(objectToSave), isCopy);
        }

        /// <summary>
        /// Save or Update the MEMSParam.
        /// </summary> 
        /// <param name="mEMSParamEntity">MEMSParam Object that is to be saved.</param>
        /// <param name="isCopy">Indicator that this is to use Cache in NHibernate or not.</param>
        public void SaveOrUpdateMEMSParam(MEMSParamEntity mEMSParamEntity, bool isCopy)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            MasterGateway masterGateWay = new MasterGateway();
            masterGateWay.SaveOrUpdateEntity<MEMSParam>(DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.MasterMapper.GetMEMSParam(mEMSParamEntity), isCopy);
        }

        /// <summary>
        /// Insert and update a group of Parent/Child of PaymentVoucher for AdHoc.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        public void SavePaymentVoucherAdHoc(EnforcementParentChildInsert parentChildInsert)
        {
            if (parentChildInsert.listParent.HasContent())
            {
                EnforcementGateway gateWay = new EnforcementGateway();
                foreach (EMSPaymentVoucherEntity iEnforcementEntity in parentChildInsert.listParent)
                {
                    EMSPaymentVoucher pV = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(iEnforcementEntity) as EMSPaymentVoucher;
                    gateWay.SaveOrUpdateEntity<IEnforcement>(pV, false);

                    if (parentChildInsert.listChild.HasContent())
                    {
                        foreach (IEnforcementEntity entityToSave in parentChildInsert.listChild)
                        {
                            if (entityToSave.GetType() == typeof(EMSTptClaimEntity) && (entityToSave as EMSTptClaimEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSTptClaim tptClaim = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSTptClaim;
                                tptClaim.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(tptClaim, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSDisburseClaimEntity) && (entityToSave as EMSDisburseClaimEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSDisburseClaim disbClaim = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSDisburseClaim;
                                disbClaim.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(disbClaim, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSMiscClaimEntity) && (entityToSave as EMSMiscClaimEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSMiscClaim miscClaim = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSMiscClaim;
                                miscClaim.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(miscClaim, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSSaleAuctioneerEntity) && (entityToSave as EMSSaleAuctioneerEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSSaleAuctioneer auctioneer = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSSaleAuctioneer;
                                auctioneer.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(auctioneer, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSSaleAppraiserEntity) && (entityToSave as EMSSaleAppraiserEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSSaleAppraiser appraiser = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSSaleAppraiser;
                                appraiser.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(appraiser, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSSaleAdvertEntity) && (entityToSave as EMSSaleAdvertEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSSaleAdvert advertiser = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSSaleAdvert;
                                advertiser.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(advertiser, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSSaleAgentEntity) && (entityToSave as EMSSaleAgentEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSSaleAgent agent = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSSaleAgent;
                                agent.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(agent, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSAttendanceFeeEntity) && (entityToSave as EMSAttendanceFeeEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSAttendanceFee attFee = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSAttendanceFee;
                                attFee.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(attFee, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSCourtCommissionEntity) && (entityToSave as EMSCourtCommissionEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSCourtCommission cc = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSCourtCommission;
                                cc.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(cc, true);
                            }
                            else if (entityToSave.GetType() == typeof(EMSPaymentVoucherFinalOtherEntity) && (entityToSave as EMSPaymentVoucherFinalOtherEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSPaymentVoucherFinalOther cc = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityToSave) as EMSPaymentVoucherFinalOther;
                                cc.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(cc, true);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Insert and update a group of Parent/Child of PaymentVoucher for Admiralty.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        public void SavePaymentVoucherAdmAdHoc(EnforcementParentChildInsert parentChildInsert)
        {
            if (parentChildInsert.listParent.HasContent())
            {
                EnforcementGateway gateWay = new EnforcementGateway();
                foreach (EMSPaymentVoucherEntity iEnforcementEntity in parentChildInsert.listParent)
                {
                    EMSPaymentVoucher pV = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(iEnforcementEntity) as EMSPaymentVoucher;
                    gateWay.SaveOrUpdateEntity<IEnforcement>(pV, false);

                    if (parentChildInsert.listChild.HasContent())
                    {
                        //Child
                        foreach (IEnforcementEntity childEntityToSave in parentChildInsert.listChild)
                        {
                            if (childEntityToSave.GetType() == typeof(EMSAdmClaimEntity)
                                && (childEntityToSave as EMSAdmClaimEntity).PaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSAdmClaim admClaim = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(childEntityToSave) as EMSAdmClaim;
                                admClaim.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(admClaim, true);
                            }
                            else if (childEntityToSave.GetType() == typeof(EMSAdmChargesEntity)
                                && (childEntityToSave as EMSAdmChargesEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSAdmCharges admCharges = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(childEntityToSave) as EMSAdmCharges;
                                admCharges.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(admCharges, true);
                            }
                            else if (childEntityToSave.GetType() == typeof(EMSADMSaleOthersEntity)
                                && (childEntityToSave as EMSADMSaleOthersEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSADMSaleOthers saleOther = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(childEntityToSave) as EMSADMSaleOthers;
                                saleOther.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(saleOther, true);
                            }
                            else if (childEntityToSave.GetType() == typeof(EMSPaymentVoucherFinalOtherEntity)
                                && (childEntityToSave as EMSPaymentVoucherFinalOtherEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSPaymentVoucherFinalOther finalOther = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(childEntityToSave) as EMSPaymentVoucherFinalOther;
                                finalOther.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(finalOther, true);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Insert and update a group of Parent/Child of PaymentVoucher for Final.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        public void SavePaymentVoucherFinal(EnforcementParentChildInsert parentChildInsert)
        {
            if (parentChildInsert.listParent.HasContent())
            {
                EnforcementGateway gateWay = new EnforcementGateway();
                //Parent
                foreach (EMSPaymentVoucherEntity iEnforcementEntity in parentChildInsert.listParent)
                {
                    EMSPaymentVoucher pV = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(iEnforcementEntity) as EMSPaymentVoucher;
                    gateWay.SaveOrUpdateEntity<IEnforcement>(pV, false);

                    if (parentChildInsert.listChild.HasContent())
                    {
                        //Child
                        foreach (IEnforcementEntity childEntityToSave in parentChildInsert.listChild)
                        {
                            if (childEntityToSave.GetType() == typeof(EMSPaymentVoucherFinalEntity)
                                && (childEntityToSave as EMSPaymentVoucherFinalEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSPaymentVoucherFinal pVF = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(childEntityToSave) as EMSPaymentVoucherFinal;
                                pVF.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(pVF, false);

                                if (parentChildInsert.listGrandChild.HasContent())
                                {
                                    //GrandChild
                                    foreach (IEnforcementEntity grandChildEntityToSave in parentChildInsert.listGrandChild)
                                    {
                                        if (grandChildEntityToSave.GetType() == typeof(EMSPaymentVoucherMiscEntity)
                                           && (grandChildEntityToSave as EMSPaymentVoucherMiscEntity).EMSPaymentVoucherFinalId == pVF.EMSPaymentVoucherFinalId)
                                        {
                                            EMSPaymentVoucherMisc pVMisc = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(grandChildEntityToSave) as EMSPaymentVoucherMisc;
                                            pVMisc.EMSPaymentVoucherFinal = pVF;
                                            gateWay.SaveOrUpdateEntity<IEnforcement>(pVMisc, false);
                                        }
                                    }
                                }
                            }
                            else if (childEntityToSave.GetType() == typeof(EMSCourtCommissionEntity)
                               && (childEntityToSave as EMSCourtCommissionEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSCourtCommission cc = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(childEntityToSave) as EMSCourtCommission;
                                cc.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(cc, false);
                            }
                            else if (childEntityToSave.GetType() == typeof(EMSAttendanceFeeEntity)
                               && (childEntityToSave as EMSAttendanceFeeEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSAttendanceFee attFee = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(childEntityToSave) as EMSAttendanceFee;
                                attFee.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(attFee, false);
                            }
                            else if (childEntityToSave.GetType() == typeof(EMSPaymentVoucherFinalOtherEntity)
                                && (childEntityToSave as EMSPaymentVoucherFinalOtherEntity).EMSPaymentVoucherId == pV.EMSPaymentVoucherId)
                            {
                                EMSPaymentVoucherFinalOther pVFO = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(childEntityToSave) as EMSPaymentVoucherFinalOther;
                                pVFO.EMSPaymentVoucher = pV;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(pVFO, false);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Insert and update a group of Parent/Child of PaymentVoucher for Final.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        private void SaveCaseRegistration(CaseRegirestrationParentChildInsert parentChildInsert)
        {
            #region -- Save CaseInfo, CaseParty, RCaseSubmission, SubCaseParty, DocumentInfo
            //Save CaseInfo
            CaseGateway caseGateWay = new CaseGateway();
            if (parentChildInsert.listCaseInfo.HasContent())
            {
                foreach (CaseInfoEntity caseInfo in parentChildInsert.listCaseInfo)
                {
                    caseGateWay.SaveOrUpdateEntity(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseInfo(caseInfo));
                }
            }
            //Save CaseParty
            if (parentChildInsert.listCaseParty.HasContent())
            {
                foreach (CasePartyEntity caseParty in parentChildInsert.listCaseParty)
                {
                    caseGateWay.SaveOrUpdateEntity(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseParty(caseParty));
                }
            }
            //Save RCaseSubmission
            if (parentChildInsert.listRCaseSubmission.HasContent())
            {
                foreach (RCaseSubmissionEntity rCaseSubmission in parentChildInsert.listRCaseSubmission)
                {
                    caseGateWay.SaveOrUpdateEntity(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetRCaseSubmission(rCaseSubmission));
                }
            }
            //Save SubCaseParty
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            if (parentChildInsert.listSubCaseParty.HasContent())
            {
                foreach (SubCasePartyEntity subCaseParty in parentChildInsert.listSubCaseParty)
                {
                    subCaseGateway.SaveOrUpdateSubCasePartyEntity(subCaseParty);
                }
            }
            //Save Document
            DocumentGateway documentGateway = new DocumentGateway();
            if (parentChildInsert.listDocumentInfo.HasContent())
            {
                foreach (DocumentInfoEntity documentInfo in parentChildInsert.listDocumentInfo)
                {
                    documentGateway.SaveOrUpdateDocumentInfoEntity(documentInfo);
                }
            }
            #endregion

            #region -- Save EMSAccount, EMSAppointment, EMSApptDebtor
            EnforcementGateway gateWay = new EnforcementGateway();
            if (parentChildInsert.listParent.HasContent())
            {
                foreach (EMSAccountEntity eMSAccountEntity in parentChildInsert.listParent
                    .Where(entity => entity.GetType() == typeof(EMSAccountEntity)))
                {
                    //Saving EMSAccount
                    EMSAccount eMSAccount = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(eMSAccountEntity) as EMSAccount;
                    if (parentChildInsert.listSubCaseInfo.HasContent() && !string.IsNullOrEmpty(eMSAccountEntity.SubCaseInfoId)
                        && parentChildInsert.listSubCaseInfo.Where(subCaseInfo => subCaseInfo.SubCaseInfoId == eMSAccountEntity.SubCaseInfoId).Count() == 1)
                    {
                        eMSAccount.SubCaseInfo = gateWay.MapToNHibernateObject<SubCaseInfoEntity, SubCaseInfo>(
                            parentChildInsert.listSubCaseInfo.Where(subCaseInfo => subCaseInfo.SubCaseInfoId == eMSAccountEntity.SubCaseInfoId).First());
                    }
                    if (parentChildInsert.listCaseInfo.HasContent() && !string.IsNullOrEmpty(eMSAccountEntity.CaseInfoId)
                        && parentChildInsert.listCaseInfo.Where(caseInfo => caseInfo.CaseInfoId == eMSAccountEntity.CaseInfoId).Count() == 1)
                    {
                        eMSAccount.CaseInfo = gateWay.MapToNHibernateObject<CaseInfoEntity, CaseInfo>(
                            parentChildInsert.listCaseInfo.Where(caseInfo => caseInfo.CaseInfoId == eMSAccountEntity.CaseInfoId).First());
                    }
                    gateWay.SaveOrUpdateEntity<IEnforcement>(eMSAccount, false);

                    //Saving EMSAppointment
                    if (parentChildInsert.listChild.HasContent())
                    {
                        foreach (IEnforcementEntity entityChildToSave in parentChildInsert.listChild)
                        {
                            if (entityChildToSave.GetType() == typeof(EMSAppointmentEntity)
                                && (entityChildToSave as EMSAppointmentEntity).EMSAccountId == eMSAccount.EMSAccountId)
                            {
                                EMSAppointment eMSAppointment = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityChildToSave) as EMSAppointment;
                                eMSAppointment.EMSAccount = eMSAccount;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSAppointment, true);

                                //Saving EMSApptDebtor
                                if (parentChildInsert.listGrandChild.HasContent())
                                {
                                    foreach (IEnforcementEntity entityGrandChildToSave in parentChildInsert.listGrandChild)
                                    {
                                        if (entityGrandChildToSave.GetType() == typeof(EMSApptDebtorEntity)
                                                && (entityGrandChildToSave as EMSApptDebtorEntity).EMSAppointmentId == eMSAppointment.EMSAppointmentId)
                                        {
                                            EMSApptDebtor eMSApptDebtor = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(entityGrandChildToSave) as EMSApptDebtor;
                                            eMSApptDebtor.EMSAppointment = eMSAppointment;
                                            gateWay.SaveOrUpdateEntity<IEnforcement>(eMSApptDebtor, true);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region -- Save EMSCrmCase, EMSCrmCaseWLDet, EMSCrmCaseExecAddr
            if (parentChildInsert.listParent.HasContent())
            {
                foreach (EMSCrmCaseEntity iEnforcementEntity in parentChildInsert.listParent
                    .Where(entity => entity.GetType().AssemblyQualifiedName == typeof(EMSCrmCaseEntity).AssemblyQualifiedName))
                {
                    EMSCrmCase eMSCrmCase = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(iEnforcementEntity) as EMSCrmCase;
                    gateWay.SaveOrUpdateEntity<IEnforcement>(eMSCrmCase, true);

                    if (parentChildInsert.listParent.HasContent())
                    {
                        foreach (IEnforcementEntity childEntityToSave in parentChildInsert.listChild)
                        {
                            if (childEntityToSave.GetType() == typeof(EMSCrmCaseExecAddrEntity)
                                && (childEntityToSave as EMSCrmCaseExecAddrEntity).EMSCrmCaseId == eMSCrmCase.EMSCrmCaseId)
                            {
                                EMSCrmCaseExecAddr eMSCrmCaseExecAddr = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(childEntityToSave) as EMSCrmCaseExecAddr;
                                eMSCrmCaseExecAddr.EMSCrmCase = eMSCrmCase;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSCrmCaseExecAddr, true);
                            }
                            else if (childEntityToSave.GetType() == typeof(EMSCrmCaseWLDetEntity)
                                && (childEntityToSave as EMSCrmCaseWLDetEntity).EMSCrmCaseId == eMSCrmCase.EMSCrmCaseId)
                            {
                                EMSCrmCaseWLDet eMSCrmCaseWLDet = EnforcementMapperToDomain.GetEnforcementEntity<IEnforcementEntity>(childEntityToSave) as EMSCrmCaseWLDet;
                                eMSCrmCaseWLDet.EMSCrmCase = eMSCrmCase;
                                gateWay.SaveOrUpdateEntity<IEnforcement>(eMSCrmCaseWLDet, true);
                            }
                        }
                    }
                }
            }
            #endregion
        }

        public List<EMSAppointmentEntity> GetListEMSAppointmentEntity(string EMSAccountId)
        {
            EnforcementGateway enforcementGateway = new EnforcementGateway();
          return  enforcementGateway.GetListEMSAppointmentEntity(EMSAccountId);
        }
        #endregion Methods


       
    }
}