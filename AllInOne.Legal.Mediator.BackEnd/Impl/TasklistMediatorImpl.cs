#region Header

/*****************************************************************************************************
* Description : This file represents a mediator interface for TaskList module.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   15/11/2010   		      Rajeev             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: IPreFetchMediator.cs
// Description: Represents a mediator interface for TaskList module.
// </summary>
// <copyright file= "ITasklistMediator.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

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
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Domain.SubCaseData;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Data;

    using log4net;

    public class TasklistMediatorImpl : ITasklistMediator
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(TasklistMediatorImpl));

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
            Logger.Info("TaskListMediatorImpl - BeginTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager = new ApplicationSessionManager();
            this.applicationSessionManager.BeginTransaction();

            Logger.Info("TaskListMediatorImpl - BeginTransaction ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        public void CommitAndCloseSession()
        {
            Logger.Info("FilingBrokerMediatorImpl - CommitAndCloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager = new ApplicationSessionManager();
            this.applicationSessionManager.CommitAndCloseSession();

            Logger.Info("FilingBrokerMediatorImpl - CommitAndCloseSession ended at " + DateTime.Now.ToString());
        }

        public void DeletePaymentOutPayInDetailEntityByPk(string paymentOutInId)
        {
            PaymentInOutGateway paymentInOutGateway = new PaymentInOutGateway();
            paymentInOutGateway.DeletePaymentOutPayInDetail(paymentOutInId);
        }

        public BankruptcyInfoEntity GetBankruptcyInfoBySGID(string submissionGroupId)
        {
            BankruptcyGateway gateway = new BankruptcyGateway();
            return gateway.GetBankruptcyInfoBySGID(submissionGroupId);
        }

        public CaseInfoEntity GetCaseInfoEntityByPk(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCaseInfoByPK(caseInfoId);
        }

        public List<CasePartyEntity> GetCaseParty<T, V>(string fieldName, V value)
        {
            try
            {
                CaseGateway gateway = new CaseGateway();
                List<CaseParty> listCaseParty = gateway.GetEntity<CaseParty, V>(fieldName, value);

                if (listCaseParty != null && listCaseParty.Count > 0)
                    return listCaseParty.Select(caseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyEntity(caseParty)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetCaseParty: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        public List<DCACAInfoEntity> GetDCACAInfo<V>(string fieldName, V value)
        {
            try
            {
                DocumentGateway gateway = new DocumentGateway();
                List<DCACAInfo> listDCACAInfo = gateway.GetEntity<DCACAInfo, V>(fieldName, value);

                if (listDCACAInfo != null && listDCACAInfo.Count > 0)
                    return listDCACAInfo.Select(dCACAInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetDCACAInfoEntity(dCACAInfo)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetDCACAInfo: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        public List<DocumentInfoEntity> GetDocumentInfo<T, V>(string fieldName, V value)
        {
            try
            {
                DocumentGateway gateway = new DocumentGateway();
                List<DocumentInfo> listDocumentInfo = gateway.GetEntity<DocumentInfo, V>(fieldName, value);

                if (listDocumentInfo != null && listDocumentInfo.Count > 0)
                    return listDocumentInfo.Select(doucment => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(doucment)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetDocumentInfo: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        public HearingEntity GetHearingByPk(long hrgId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetHearingByPK(hrgId.ToString()); //TODO: NEed to Change the dataType in GetHearingByPk for HrgId.
        }

        public List<AASInfoEntity> GetListAASInfoEntityBySGID(string submissionGroupId)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetListAASInfoEntityBySGID(submissionGroupId);
        }

        public List<BankruptcyDRSInfoEntity> GetListBankruptcyDRSInfoEntity(string caseInfoId, string docId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListBankruptcyDRSInfo(caseInfoId, docId);
        }

        public List<DCADetailEntity> GetListDCADetailEntityBySGID(string submissionGroupId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListDCADetailEntityBySGID(submissionGroupId);
        }

        public List<DisWithDocPtyDetailEntity> GetListDisWithDocPtyDetailEntityBySGID(string submissionGroupId)
        {
            SubsequentGateway subsequentGateway = new SubsequentGateway();
            return subsequentGateway.GetListDisWithDocPtyDetailBySGID(submissionGroupId);
        }

        public List<EmploymentInfoEntity> GetListEmploymentInfoEntityBySGId(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListEmploymentInfoBySGID(submissionGroupId);
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

        public List<OSInfoEntity> GetListOSInfoEntityBySGID(string sGID)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            return caseSpecificGateway.GetListOSInfoEntityBySGID(sGID);
        }

        public List<RARASDetailEntity> GetListRARASDetailEntityBySGID(string submissionGroupId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetlistRARASInfoDetailBySGID(submissionGroupId);
        }

        public List<RefOrderDetailEntity> GetListRefOrderDetailEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);
        }

        public List<TravelPassInfoEntity> GetListTravelPassInfoEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListTravelPassInfoBySGID(submissionGroupId);
        }

        /// <summary>
        /// Fetches all the PaymentIn data based on SubmissionGroupID.
        /// </summary>
        /// <param name="submissionGroupID">SubmissionGroupID as input</param>
        /// <returns></returns>
        public ISubCaseTypeInfo GetPaymentInData(string submissionGroupID)
        {
            try
            {
                PaymentInOutGateway objPaymentInOutGateway = new PaymentInOutGateway();

                List<PaymentInDocDetailEntity> objPaymentInDocDetailEntity =
                objPaymentInOutGateway.GetListPaymentInDocDetailEntityBySGID(submissionGroupID);

                List<PaymentInDocFSDetailEntity> listPaymentInDocFSDetailEntity =
                objPaymentInOutGateway.GetListPaymentInDocFSDetailEntityBySGID(submissionGroupID);

                PaymentInData objPaymentInData = new PaymentInData();
                objPaymentInData.ListPaymentInDocDetailEntity = objPaymentInDocDetailEntity;
                objPaymentInData.ListPaymentInDocFSDetailEntity = listPaymentInDocFSDetailEntity;

                return objPaymentInData as ISubCaseTypeInfo;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaymentInData", ex);
                throw;
            }
        }

        public List<PaymentInDocDetailEntity> GetPaymentInDocDetail<T, V>(string fieldName, V value)
        {
            try
            {
                PaymentInOutGateway gateway = new PaymentInOutGateway();
                List<PaymentInDocDetail> listPaymentInDocDetail = gateway.GetEntity<PaymentInDocDetail, V>(fieldName, value);

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

        public PaymentInDocDetailEntity GetPaymentInDocDetailByPK(string PaymentInId)
        {
            PaymentInOutGateway paymentInOutGateway = new PaymentInOutGateway();
            return paymentInOutGateway.GetPaymentInDocDetailEntityByPK(PaymentInId);
        }

        public List<PaymentInDocFSDetailEntity> GetPaymentInDocFSDetail<T, V>(string fieldName, V value)
        {
            try
            {
                PaymentInOutGateway gateway = new PaymentInOutGateway();
                List<PaymentInDocFSDetail> listPaymentInDocFSDetail = gateway.GetEntity<PaymentInDocFSDetail, V>(fieldName, value);

                if (listPaymentInDocFSDetail != null && listPaymentInDocFSDetail.Count > 0)
                    return listPaymentInDocFSDetail.Select(paymentInDocFSDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetPaymentInDocFSDetail(paymentInDocFSDetail)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetPaymentInDocDetail: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        public ISubCaseTypeInfo GetPaymentOutData(string submissionGroupID)
        {
            try
            {
                PaymentInOutGateway objPaymentInOutGateway = new PaymentInOutGateway();

                List<PaymentOutDocDetailEntity> objPaymentOutDocDetailEntity =
                objPaymentInOutGateway.GetListPaymentOutDocDetailEntityBySGID(submissionGroupID);

                List<PaymentOutPayInDetailEntity> listPaymentOutPayInDetailEntity =
                objPaymentInOutGateway.GetListPaymentOutPayInDetailEntityBySGID(submissionGroupID);

                PaymentOutData objPaymentOutData = new PaymentOutData();
                objPaymentOutData.ListPaymentOutDocDetailEntity = objPaymentOutDocDetailEntity;
                objPaymentOutData.ListPaymentOutPayInDetailEntity = listPaymentOutPayInDetailEntity;

                return objPaymentOutData as ISubCaseTypeInfo;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaymentOutData", ex);
                throw;
            }
        }

        public PaymentOutDocDetailEntity GetPaymentOutDocDetailByPk(string PaymentOutId)
        {
            PaymentInOutGateway paymentInOutGateway = new PaymentInOutGateway();
            return paymentInOutGateway.GetPaymentOutDocDetailEntityByPk(PaymentOutId);
        }

        public List<PaymentOutPayInDetailEntity> GetPaymentOutPayInDetail<T, V>(string fieldName, V value)
        {
            try
            {
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

        public List<RARASInfoEntity> GetRARASInfo<V>(string fieldName, V value)
        {
            try
            {
                DocumentGateway gateway = new DocumentGateway();
                List<RARASInfo> listRARASInfo = gateway.GetEntity<RARASInfo, V>(fieldName, value);

                if (listRARASInfo != null && listRARASInfo.Count > 0)
                    return listRARASInfo.Select(rARASInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetRARAInfoEntity(rARASInfo)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetRARASInfo: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        public RASInfoEntity GetRASInfoByGroupId(string groupId)
        {
            try
            {
                CaseSpecificGateway gateway = new CaseSpecificGateway();
                return gateway.GetRASInfoEntityBySGID(groupId);
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetRASInfo: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        public RefOrderDetailEntity GetRefOrderDetailEntityByPK(string refOrderDetailId)
        {
            try
            {
                CommonGateway commonGateway = new CommonGateway();
                return commonGateway.GetRefOrderDetailEntity(refOrderDetailId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRefOrderDetailEntityByPK", ex);
                throw;
            }
        }

        public List<ServiceOfDocDocumentEntity> GetServiceOfDocDocument<T, V>(string fieldName, V value)
        {
            try
            {
                ServiceOfDocGateway gateway = new ServiceOfDocGateway();
                List<ServiceOfDocDocument> listServiceOfDocDocument = gateway.GetEntity<ServiceOfDocDocument, V>(fieldName, value);

                if (listServiceOfDocDocument != null && listServiceOfDocDocument.Count > 0)
                    return listServiceOfDocDocument.Select(serviceOfDocDocument => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocDocumentEntity(serviceOfDocDocument)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetServiceOfDocDocument: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        public List<ServiceOfDocInfoEntity> GetServiceOfDocInfo<T, V>(string fieldName, V value)
        {
            try
            {
                ServiceOfDocGateway gateway = new ServiceOfDocGateway();
                List<ServiceOfDocInfo> listServiceOfDocInfo = gateway.GetEntity<ServiceOfDocInfo, V>(fieldName, value);

                if (listServiceOfDocInfo != null && listServiceOfDocInfo.Count > 0)
                    return listServiceOfDocInfo.Select(serviceDocInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocInfoEntity(serviceDocInfo)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetServiceOfDocInfo: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        public List<ServiceOfDocInfoDetailEntity> GetServiceOfDocInfoDetail<T, V>(string fieldName, V value)
        {
            try
            {
                ServiceOfDocGateway gateway = new ServiceOfDocGateway();
                List<ServiceOfDocInfoDetail> listServiceOfDocInfoDetail = gateway.GetEntity<ServiceOfDocInfoDetail, V>(fieldName, value);

                if (listServiceOfDocInfoDetail != null && listServiceOfDocInfoDetail.Count > 0)
                    return listServiceOfDocInfoDetail.Select(serviceDocInfoDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocInfoDetailEntity(serviceDocInfoDetail)).ToList();
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetServiceOfDocInfoDetail: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        public List<SubCaseInfoEntity> GetSubCaseInfo<T, V>(string fieldName, V value)
        {
            try
            {
                DocumentGateway gateway = new DocumentGateway();
                List<RSubCaseSubmission> listRSubCaseSubmission = gateway.GetEntity<RSubCaseSubmission, V>(fieldName, value);

                if (listRSubCaseSubmission != null && listRSubCaseSubmission.Count > 0)
                {
                    SubCaseGateway gateway2 = new SubCaseGateway();
                    List<SubCaseInfo> listSubCaseInfo = gateway2.GetEntity<SubCaseInfo, Int64>("SubCaseInfoId", listRSubCaseSubmission.FirstOrDefault().SubCaseInfoId);

                    if (listSubCaseInfo != null && listSubCaseInfo.Count > 0)
                        return listSubCaseInfo.Select(subCase => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCaseInfoEntity(subCase)).ToList();
                    else
                        return null;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                Logger.Error("Error in GetDocumentInfo: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        public SubCaseInfoEntity GetSubCaseInfoEntityByPK(string subcaseInfoId)
        {
            SubCaseGateway subCaseGateway = new SubCaseGateway();
            return subCaseGateway.GetSubCaseInfoEntityBySubCaseInfoId(Convert.ToInt64(subcaseInfoId));
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

        public void SaveOrUpdateCaseSpecificEntity(ICaseSpecificEntity iCaseSpecificEntity, bool isCopy)
        {
            CaseSpecificGateway caseSpecificGateway = new CaseSpecificGateway();
            if (isCopy)
                caseSpecificGateway.SaveOrUpdateInMemoryEntity<ICaseSpecific>(CaseSpecificMapper.GetCaseSpecificEntity<ICaseSpecificEntity>(iCaseSpecificEntity));
            else
                caseSpecificGateway.SaveOrUpdateEntity<ICaseSpecific>(CaseSpecificMapper.GetCaseSpecificEntity<ICaseSpecificEntity>(iCaseSpecificEntity));
        }

        public void SaveOrUpdateCopyPaymentOutDocDetailEntity(PaymentOutDocDetailEntity paymentOutDocDetailEntity)
        {
            PaymentInOutGateway paymentInOutGateway = new PaymentInOutGateway();
            paymentInOutGateway.SaveOrUpdatePaymentOutDocDetailCopy(paymentOutDocDetailEntity);
        }

        public void SaveOrUpdateCopyPaymentOutPayInDetailEntity(PaymentOutPayInDetailEntity paymentOutPayInDetailEntity)
        {
            PaymentInOutGateway paymentInOutGateway = new PaymentInOutGateway();
            paymentInOutGateway.SaveOrUpdateCopyPaymentOutPayInDetail(paymentOutPayInDetailEntity);
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

        public List<DocAppProcessByExAgencyEntity> GetListDocAppProcessByExAgencyEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListDocAppProcessByExAgencyBySGID(submissionGroupId);
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

        public List<DegreeInfoEntity> GetListDegreeInfoEntityBySGID(string sGID)
        {
            CommonGateway gateway = new CommonGateway();
            return gateway.GetListDegreeInfoBySGID(sGID);
        }

        public List<ClaimAmountEntity> GetClaimAmountEntity(string docId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListClaimAmountByDocId(docId);
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


        public PCInfoEntity GetPCInfoEntityBySGID(string submissionGroupId)
        {
            SubCaseSpecificGateway subCaseSpecificGateway = new SubCaseSpecificGateway();
            return subCaseSpecificGateway.GetPCInfoEntityBySGID(submissionGroupId);
        }

        /// <summary>
        /// Gets the list cert security of costs information entity by sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        /// <returns></returns>
        public List<CertSecurityOfCostsInfoEntity> GetListCertSecurityOfCostsInfoEntityBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            return commonGateway.GetListCertSecurityOfCostsInfoEntityBySGID(submissionGroupId);
        }

        #endregion Methods
    }
}