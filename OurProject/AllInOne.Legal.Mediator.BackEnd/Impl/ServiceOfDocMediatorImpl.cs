#region Header

/*****************************************************************************************************
* Description : This file represents a mediator interface for Service of Document File module.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   27/10/2010   		      Narayan             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: IServiceOfDocMediator.cs
// Description: Represents a mediator interface for Service Of Doc module.
// </summary>
// <copyright file= "IServiceOfDocMediator.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Data;

    using log4net;

    public class ServiceOfDocMediatorImpl : IServiceOfDocMediator
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ServiceOfDocMediatorImpl));

        /// <summary>
        /// ApplicationSessionManager instance for session.
        /// </summary>
        private ApplicationSessionManager applicationSessionManager;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        public void CommitAndCloseSession()
        {
            Logger.Info("ServiceOfDocMediatorImpl - CommitAndCloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager = new ApplicationSessionManager();
            this.applicationSessionManager.CommitAndCloseSession();

            Logger.Info("ServiceOfDocMediatorImpl - CommitAndCloseSession ended at " + DateTime.Now.ToString());
        }

        //By Yan Nai - Jan 13, 2011
        /// <summary>
        /// Get CaseInfoEntity by criteria.
        /// </summary>
        /// <typeparam name="T">Type which to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<CaseInfoEntity></returns>
        public List<CaseInfoEntity> GetCaseInfo<V>(string fieldName, V value)
        {
            try
            {
                if (string.IsNullOrEmpty(fieldName))
                    throw new Exception("The field name is null or empty.");

                CaseGateway gateway = new CaseGateway();
                List<CaseInfo> listcaseInfo = gateway.GetEntity<CaseInfo, V>(fieldName, value);

                if (listcaseInfo != null && listcaseInfo.Count > 0)
                    return listcaseInfo.Select(caseInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseInfoEntity(caseInfo)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetCaseInfo: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        //By Yan Nai - Jan 17, 2011
        /// <summary>
        /// Get CaseInfo by SubmissionGroupId of RCaseSubmission object.
        /// </summary> 
        /// <param name="submissionGroupID">The value of Submission Group Id.</param>
        /// <returns>List<CaseInfoEntity></returns>
        public List<CaseInfoEntity> GetCaseInfoBySubmissionGroupId(string submissionGroupID)
        {
            try
            {
                if (string.IsNullOrEmpty(submissionGroupID))
                    throw new Exception("The field name is null or empty.");

                SubCaseGateway gateway = new SubCaseGateway();
                List<RCaseSubmission> listRCaseSubmission = gateway.GetEntity<RCaseSubmission, string>("SubmissionGroupID", submissionGroupID);

                if (listRCaseSubmission == null || listRCaseSubmission.Count < 1)
                    return null;

                List<CaseInfo> listCaseInfo = gateway.GetEntity<CaseInfo, Int64>("CaseInfoId", listRCaseSubmission.FirstOrDefault().CaseInfoId);

                if (listCaseInfo != null && listCaseInfo.Count > 0)
                    return listCaseInfo.Select(caseInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseInfoEntity(caseInfo)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetCaseInfoBySubmissionGroupId: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Don't Use this anymore. Gets the CaseInfo Entity
        /// </summary>
        /// <param name="caseInfoId">Gets the caseInfoId and Returns CaseInfo</param>
        /// <returns>Returns the CaseInfo if found Else Null</returns>
        public CaseInfoEntity GetCaseInfoEntity(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCaseInfoByPK(caseInfoId);
        }

        /// <summary>
        /// Gets the case party details based on casePartyId
        /// </summary>
        /// <param name="casePartyId">string contains casePartyId</param>
        /// <returns>CasePartyEntity</returns>
        public CasePartyEntity GetCasePartyEntityByPK(string casePartyId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyByPK(casePartyId);
        }

        //By Yan Nai - Feb 08, 2011
        /// <summary>
        /// Get DocumentInfoEntity by criteria.
        /// </summary> 
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<DocumentInfoEntity></returns>
        public List<DocumentInfoEntity> GetDocumentInfo<V>(string fieldName, V value)
        {
            try
            {
                if (string.IsNullOrEmpty(fieldName))
                    throw new Exception("The field name is null or empty.");

                DocumentGateway gateway = new DocumentGateway();
                List<DocumentInfo> listDocumentInfo = gateway.GetEntity<DocumentInfo, V>(fieldName, value);

                if (listDocumentInfo != null && listDocumentInfo.Count > 0)
                    return listDocumentInfo.Select(documentInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfo)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetDocumentInfo: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Gets the list case info entity.
        /// </summary>
        /// <param name="caseNo">The case no.</param>
        /// <param name="caseName">Name of the case.</param>
        /// <returns></returns>
        public List<CaseInfoEntity> GetListCaseInfoEntity(string caseNo, string caseName)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListCaseInfoEntityByCaseNameORCaseNo(caseNo, caseName);
        }

        /// <summary>
        /// Gets the case party details based on caseInfoId
        /// </summary>
        /// <param name="criteria">Criteria contains caseInfoId</param>
        /// <returns>CasePartyEntity List</returns>
        public List<CasePartyEntity> GetListCasePartyEntityByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyByCaseInfoId(caseInfoId);
        }

        /// <summary>
        /// Get ServiceOfDocDocStatusHistoryEntity List based on serviceOfDocInfoId
        /// </summary>
        /// <param name="serviceOfDocInfoId"></param>
        /// <returns>List<ServiceOfDocDocStatusHistoryEntity> </returns>
        public List<ServiceOfDocDocStatusHistoryEntity> GetListServiceOfDocDocStatusHistoryEntityByServiceOfDocInfoId(string serviceOfDocInfoId)
        {
            ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            return serviceOfDocGateway.GetListServiceOfDocDocStatusHistoryByServiceOfDocInfoID(serviceOfDocInfoId);
        }

        /// <summary>
        /// Get ServiceOfDocInfoDetailEntity List based on serviceOfDocInfoId
        /// </summary>
        /// <param name="serviceOfDocInfoId"></param>
        /// <returns>List<ServiceOfDocInfoDetailEntity> </returns>
        public List<ServiceOfDocInfoDetailEntity> GetListServiceOfDocInfoDetailEntityByServiceOfDocInfoId(string serviceOfDocInfoId)
        {
            ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            return serviceOfDocGateway.GetListServiceOfDocInfoDetailByServiceOfDocInfoID(serviceOfDocInfoId);
        }

        /// <summary>
        ///  GetServiceOfDocInfo list By caseInfoId
        /// </summary>
        /// <param name="caseInfoId"></param>
        /// <returns>List<ServiceOfDocInfo></returns>
        public List<ServiceOfDocInfoEntity> GetListServiceOfDocInfoEntityByCaseInfoId(long caseInfoId)
        {
            ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            return serviceOfDocGateway.GetListServiceOfDocInfoByCaseInfoID(caseInfoId);
        }

        /// <summary>
        ///  GetServiceOfDocInfo list By serviceStatus
        /// </summary>
        /// <param name="serviceStatus"></param>
        /// <returns>List<ServiceOfDocInfo></returns>
        public List<ServiceOfDocInfoEntity> GetListServiceOfDocInfoEntityByServiceSatus(ServiceStatus serviceStatus)
        {
            ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            return serviceOfDocGateway.GetListServiceOfDocInfoByServiceStatus(serviceStatus);
        }

        public List<SubCaseInfoEntity> GetListSubCaseInfoEntityByCaseInfoId(string caseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetSubCaseInfoEntityByCaseInfoId(caseInfoId);
        }

        public List<SubCaseInfoEntity> GetListSubCaseInfoEntityBySubCaseNo(string subCaseNo)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetSubCaseInfoEntityBySubCaseNo(subCaseNo);
        }

        //By Yan Nai - Jan 13, 2011
        /// <summary>
        /// Get PaymentInDocDetailEntity by criteria.
        /// </summary>
        /// <typeparam name="T">Type which to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<PaymentInDocDetailEntity></returns>
        public List<PaymentInDocDetailEntity> GetPaymentInDocDetail()
        {
            try
            {
                SubCaseGateway gateway = new SubCaseGateway();
                List<PaymentInDocDetail> listPaymentInDocDetail = gateway.GetEntity<PaymentInDocDetail, string>("", "");

                if (listPaymentInDocDetail != null && listPaymentInDocDetail.Count > 0)
                    return listPaymentInDocDetail.Select(paymentInDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetPaymentInDocDetailEntity(paymentInDocDetail)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetPaymentInDocDetail: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        //By Yan Nai - Jan 13, 2011
        /// <summary>
        /// Get GetPaymentOutDocDetail by criteria.
        /// </summary>
        /// <typeparam name="T">Type which to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<PaymentOutDocDetailEntity></returns>
        public List<PaymentOutDocDetailEntity> GetPaymentOutDocDetail<V>(string fieldName, V value)
        {
            try
            {
                if (string.IsNullOrEmpty(fieldName))
                    throw new Exception("The field name is null or empty.");

                PaymentInOutGateway gateway = new PaymentInOutGateway();
                List<PaymentOutDocDetail> listPaymentOutDocDetail = gateway.GetEntity<PaymentOutDocDetail, V>(fieldName, value);

                if (listPaymentOutDocDetail != null && listPaymentOutDocDetail.Count > 0)
                    return listPaymentOutDocDetail.Select(paymentOutDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetPaymentOutDocEntity(paymentOutDocDetail)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetPaymentOutDocDetail: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        //By Yan Nai - Jan 13, 2011
        /// <summary>
        /// Get PaymentOutDocDetailEntity by criteria.
        /// </summary>
        /// <typeparam name="T">Type which to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<PaymentOutDocDetailEntity></returns>
        public List<PaymentOutDocDetailEntity> GetPaymentOutDocDetail()
        {
            try
            {
                SubCaseGateway gateway = new SubCaseGateway();
                List<PaymentOutDocDetail> listPaymentOutDocDetail = gateway.GetEntity<PaymentOutDocDetail, string>("", "");

                if (listPaymentOutDocDetail != null && listPaymentOutDocDetail.Count > 0)
                    return listPaymentOutDocDetail.Select(paymentOutDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetPaymentOutDocEntity(paymentOutDocDetail)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetPaymentOutDocDetail: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        //By Yan Nai - Jan 13, 2011
        /// <summary>
        /// Get PaymentOutPayInDetail by criteria.
        /// </summary>
        /// <typeparam name="T">Type which to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<PaymentOutPayInDetailEntity></returns>
        public List<PaymentOutPayInDetailEntity> GetPaymentOutPayInDetail<V>(string fieldName, V value)
        {
            try
            {
                if (string.IsNullOrEmpty(fieldName))
                    throw new Exception("The field name is null or empty.");

                PaymentInOutGateway gateway = new PaymentInOutGateway();
                List<PaymentOutPayInDetail> listPaymentOutPayInDetail = gateway.GetEntity<PaymentOutPayInDetail, V>(fieldName, value);

                if (listPaymentOutPayInDetail != null && listPaymentOutPayInDetail.Count > 0)
                    return listPaymentOutPayInDetail.Select(paymentOutPayInDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetPaymentOutPaymentInDetail(paymentOutPayInDetail)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetPaymentOutPayInDetail: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        //By Yan Nai - Jan 13, 2011
        /// <summary>
        /// Get all PaymentOutPayInDetail
        /// </summary> 
        /// <returns>List<PaymentOutPayInDetailEntity></returns>
        public List<PaymentOutPayInDetailEntity> GetPaymentOutPayInDetail()
        {
            try
            {
                PaymentInOutGateway gateway = new PaymentInOutGateway();
                List<PaymentOutPayInDetail> listPaymentOutPayInDetail = gateway.GetEntity<PaymentOutPayInDetail, string>("", "");

                if (listPaymentOutPayInDetail != null && listPaymentOutPayInDetail.Count > 0)
                    return listPaymentOutPayInDetail.Select(paymentOutPayInDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetPaymentOutPaymentInDetail(paymentOutPayInDetail)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetPaymentOutPayInDetail: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Get ServiceOfDocDocStatusHistoryEntity by primaryKey ServiceOfDocDocStatusID
        /// </summary>
        /// <param name="ServiceOfDocDocStatusID"></param>
        /// <returns></returns>
        public ServiceOfDocDocStatusHistoryEntity GetServiceOfDocDocStatusHistoryEntityByPK(string serviceOfDocDocStatusId)
        {
            ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            return serviceOfDocGateway.GetServiceOfDocDocStatusHistoryByPK(serviceOfDocDocStatusId);
        }

        /// <summary>
        /// Gets the Service of Doc Info based on serviceOfDocInfoId
        /// </summary>
        /// <param name="serviceOfDocInfoId">string contains serviceOfDocInfoId</param>
        /// <returns>ServiceOfDocInfoEntity</returns>
        public ServiceOfDocInfoEntity GetServiceOfDocInfoEntityByPK(string serviceOfDocInfoId)
        {
            ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            return serviceOfDocGateway.GetServiceOfDocInfoByPK(serviceOfDocInfoId);
        }

        //By Yan Nai - Jan 13, 2011
        /// <summary>
        /// Get SubCaseInfoEntity by criteria.
        /// </summary>
        /// <typeparam name="T">Type which to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<SubCaseInfoEntity></returns>
        public List<SubCaseInfoEntity> GetSubCaseInfo<V>(string fieldName, V value)
        {
            try
            {
                if (string.IsNullOrEmpty(fieldName))
                    throw new Exception("The field name is null or empty.");

                SubCaseGateway gateway = new SubCaseGateway();
                List<SubCaseInfo> listcSubCaseInfo = gateway.GetEntity<SubCaseInfo, V>(fieldName, value);

                if (listcSubCaseInfo != null && listcSubCaseInfo.Count > 0)
                    return listcSubCaseInfo.Select(subCaseInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCaseInfoEntity(subCaseInfo)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetSubCaseInfo: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        //By Yan Nai - Jan 17, 2011
        /// <summary>
        /// Get SubCaseInfo by SubmissionGroupId of RSubCaseSubmission object.
        /// </summary> 
        /// <param name="submissionGroupID">The value of Submission Group Id.</param>
        /// <returns>List<SubCaseInfoEntity></returns>
        public List<SubCaseInfoEntity> GetSubCaseInfoBySubmissionGroupId(string submissionGroupID)
        {
            try
            {
                if (string.IsNullOrEmpty(submissionGroupID))
                    throw new Exception("The field name is null or empty.");

                SubCaseGateway gateway = new SubCaseGateway();
                List<RSubCaseSubmission> listRSubCaseSubmission = gateway.GetEntity<RSubCaseSubmission, string>("SubmissionGroupID", submissionGroupID);

                if (listRSubCaseSubmission == null || listRSubCaseSubmission.Count < 1)
                    return null;

                List<SubCaseInfo> listSubCaseInfo = gateway.GetEntity<SubCaseInfo, Int64>("SubCaseInfoId", listRSubCaseSubmission.FirstOrDefault().SubCaseInfoId);

                if (listSubCaseInfo != null && listSubCaseInfo.Count > 0)
                    return listSubCaseInfo.Select(subCaseInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCaseInfoEntity(subCaseInfo)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetSubCaseInfoBySubmissionGroupId: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// It will save data in ServiceOfDocDocStatusHistory Entity
        /// </summary>
        /// <param name="serviceOfDocDocStatusHistoryEntity"></param>
        public void SaveOrUpdateDocDocStatusHistoryEntity(ServiceOfDocDocStatusHistoryEntity serviceOfDocDocStatusHistoryEntity)
        {
            ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            serviceOfDocGateway.SaveOrUpdateServiceOfDocDocStatusHistoryEntity(serviceOfDocDocStatusHistoryEntity);
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="IDocumentEntity"/> interface.
        /// </summary>
        /// <param name="iDocumentEntity"><see cref="ISubCaseSpecificEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateDocumentEntity(IDocumentEntity iDocumentEntity, bool isCopy)
        {
            DocumentGateway documentGateway = null;
            try
            {
                documentGateway = new DocumentGateway();

                if (iDocumentEntity.GetType().Equals(typeof(DocumentInfoEntity)))
                {
                    documentGateway.SaveOrUpdateDocumentInfoSP(iDocumentEntity);
                }
                else if (isCopy)
                    documentGateway.SaveOrUpdateInMemoryEntity<IDocument>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocumentEntity<IDocumentEntity>(iDocumentEntity));
                else
                    documentGateway.SaveOrUpdateEntity<IDocument>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocumentEntity<IDocumentEntity>(iDocumentEntity));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateDocumentEntity", ex);
                Logger.Error("Error in SaveOrUpdateDocumentEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// It will save data in ServiceDocInfo Entity
        /// </summary>
        /// <param name="serviceOfDocInfoEntity"></param>
        public void SaveOrUpdateServiceDocInfoEntity(ServiceOfDocInfoEntity serviceOfDocInfoEntity)
        {
            ServiceOfDocGateway serviceOfDocGateway = new ServiceOfDocGateway();
            serviceOfDocGateway.SaveOrUpdateServiceOfDocInfoEntity(serviceOfDocInfoEntity);
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
                genericGateway.SaveOrUpdateEntity<ISubCaseSpecific>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetSubCaseSpecific<ISubCaseSpecificEntity>(iSubCaseSpecificEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateSubCaseSpecificEntity", ex);
                Logger.Error("Error in SaveOrUpdateSubCaseSpecificEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }



        public List<DocumentInfoEntity> GetListDocumentInfo(string SubCaseInfoId, string docCode)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentByDocCodeAndSubCaseInfoId(SubCaseInfoId, docCode);

        }

        #endregion Methods
    }
}