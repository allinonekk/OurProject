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

namespace AllInOne.Legal.Mediator.BackEnd
{
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Domain.Subsequent;

    public interface ITasklistMediator : IMediator
    {
        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that 
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        void CommitAndCloseSession();

        /// <summary>
        /// Deletes <see cref="PaymentOutPayInDetailEntity"/>
        /// </summary>
        /// <param name="paymentOutPayInDetailEntity">The paymentOutPayInDetailEntity.</param>
        void DeletePaymentOutPayInDetailEntityByPk(string paymentOutInId);

        /// <summary>
        /// Gets the bankruptcy info by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        BankruptcyInfoEntity GetBankruptcyInfoBySGID(string submissionGroupId);

        CaseInfoEntity GetCaseInfoEntityByPk(string caseInfoId);

        /// <summary>
        /// Gets the ref order detail entity by PK.
        /// </summary>
        /// <param name="refOrderDetailId">The ref order detail id.</param>
        /// <returns></returns>
        List<CasePartyEntity> GetCaseParty<T, V>(string fieldName, V value);

        /// <summary>
        /// Gets the ref order detail entity by PK.
        /// </summary> 
        /// <returns></returns>
        List<DCACAInfoEntity> GetDCACAInfo<V>(string fieldName, V value);

        /// <summary>
        /// Gets the ref order detail entity by PK.
        /// </summary>
        /// <param name="refOrderDetailId">The ref order detail id.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetDocumentInfo<T, V>(string fieldName, V value);

        /// <summary>
        /// Gets the <see cref="HearingEntity "/>
        /// </summary>
        /// <param name="hrgId">The hrgId.</param>
        /// <returns></returns>
        HearingEntity GetHearingByPk(long hrgId);

        List<AASInfoEntity> GetListAASInfoEntityBySGID(string submissionGroupId);

        List<BankruptcyDRSInfoEntity> GetListBankruptcyDRSInfoEntity(string caseInfoId, string docId);

        /// <summary>
        /// Gets the list of <see cref="DCADetailEntity "/>
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId.</param>
        /// <returns></returns>
        List<DCADetailEntity> GetListDCADetailEntityBySGID(string submissionGroupId);

        List<DisWithDocPtyDetailEntity> GetListDisWithDocPtyDetailEntityBySGID(string submissionGroupId);

        List<EmploymentInfoEntity> GetListEmploymentInfoEntityBySGId(string submissionGroupId);

        /// <summary>
        /// Gets the list of <see cref="NotPaymenttoCourtDocDetailEntity "/>
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId.</param>
        /// <returns></returns>
        List<NotPaymenttoCourtDocDetailEntity> GetListNotPaymenttoCourtDocDetailEntityBySGID(string submissionGroupId);

        List<OrdersMadeEntity> GetListOrdersMadeEntityByDocId(string docId);

        List<OSInfoEntity> GetListOSInfoEntityBySGID(string sGID);

        /// <summary>
        /// Gets the list of <see cref="RARASDetailEntity "/>
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId.</param>
        /// <returns></returns>
        List<RARASDetailEntity> GetListRARASDetailEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the <see cref="RefOrderDetailEntity "/>
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        List<RefOrderDetailEntity> GetListRefOrderDetailEntityBySGID(string submissionGroupId);

        List<TravelPassInfoEntity> GetListTravelPassInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Fetches all the PaymentIn data based on SubmissionGroupID.
        /// </summary>
        /// <param name="submissionGroupID">SubmissionGroupID as input</param>
        /// <returns></returns>
        ISubCaseTypeInfo GetPaymentInData(string submissionGroupID);

        /// <summary>
        /// Gets the ref order detail entity by PK.
        /// </summary>
        /// <param name="refOrderDetailId">The ref order detail id.</param>
        /// <returns></returns>
        List<PaymentInDocDetailEntity> GetPaymentInDocDetail<T, V>(string fieldName, V value);

        /// <summary>
        /// Gets the <see cref="PaymentInDocDetailEntity "/>
        /// </summary>
        /// <param name="PaymentInId">The paymentInId.</param>
        /// <returns></returns>
        PaymentInDocDetailEntity GetPaymentInDocDetailByPK(string paymentInId);

        /// <summary>
        /// Gets the ref order detail entity by PK.
        /// </summary>
        /// <param name="refOrderDetailId">The ref order detail id.</param>
        /// <returns></returns>
        List<PaymentInDocFSDetailEntity> GetPaymentInDocFSDetail<T, V>(string fieldName, V value);

        /// <summary>
        /// Fetches all the PaymentOut data based on SubmissionGroupID.
        /// </summary>
        /// <param name="submissionGroupID">SubmissionGroupID as input</param>
        /// <returns></returns>
        ISubCaseTypeInfo GetPaymentOutData(string submissionGroupID);

        /// <summary>
        /// Gets the <see cref="PaymentOutDocDetailEntity"/>
        /// </summary>
        /// <param name="PaymentOutId">The paymentOutId.</param>
        /// <returns></returns>
        PaymentOutDocDetailEntity GetPaymentOutDocDetailByPk(string paymentOutId);

        /// <summary>
        /// Gets the ref order detail entity by PK.
        /// </summary>
        /// <param name="refOrderDetailId">The ref order detail id.</param>
        /// <returns></returns>
        List<PaymentOutPayInDetailEntity> GetPaymentOutPayInDetail<T, V>(string fieldName, V value);

        /// <summary>
        /// Gets the ref order detail entity by PK.
        /// </summary> 
        /// <returns></returns>
        List<RARASInfoEntity> GetRARASInfo<V>(string fieldName, V value);

        /// <summary>
        /// Gets the ref order detail entity by group id.
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        RASInfoEntity GetRASInfoByGroupId(string groupId);

        /// <summary>
        /// Gets the ref order detail entity by PK.
        /// </summary>
        /// <param name="refOrderDetailId">The ref order detail id.</param>
        /// <returns></returns>
        RefOrderDetailEntity GetRefOrderDetailEntityByPK(string refOrderDetailId);

        /// <summary>
        /// Gets the ref order detail entity by PK.
        /// </summary>
        /// <param name="refOrderDetailId">The ref order detail id.</param>
        /// <returns></returns>
        List<ServiceOfDocDocumentEntity> GetServiceOfDocDocument<T, V>(string fieldName, V value);

        /// <summary>
        /// Gets the ref order detail entity by PK.
        /// </summary>
        /// <param name="refOrderDetailId">The ref order detail id.</param>
        /// <returns></returns>
        List<ServiceOfDocInfoEntity> GetServiceOfDocInfo<T, V>(string fieldName, V value);

        /// <summary>
        /// Gets the ref order detail entity by PK.
        /// </summary>
        /// <param name="refOrderDetailId">The ref order detail id.</param>
        /// <returns></returns>
        List<ServiceOfDocInfoDetailEntity> GetServiceOfDocInfoDetail<T, V>(string fieldName, V value);

        /// <summary>
        /// Gets the ref order detail entity by PK.
        /// </summary>
        /// <param name="refOrderDetailId">The ref order detail id.</param>
        /// <returns></returns>
        List<SubCaseInfoEntity> GetSubCaseInfo<T, V>(string fieldName, V value);

        SubCaseInfoEntity GetSubCaseInfoEntityByPK(string subcaseInfoId);

        /// <summary>
        /// Saves the or update back end specific entity.
        /// </summary>
        /// <param name="backEndSpecificEntity">The back end specific entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateBackEndSpecificEntity(IBackEndSpecificEntity backEndSpecificEntity, bool isCopy);

        /// <summary>
        /// Saves the or update entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="caseSpecificEntity">The case specific entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateCaseSpecificEntity(ICaseSpecificEntity iCaseSpecificEntity, bool isCopy);

        /// <summary>
        /// Saves Or Updates <see cref="PaymentOutDocDetailEntity"/>
        /// </summary>
        /// <param name="paymentOutPayInDetailEntity">The paymentOutPayInDetailEntity.</param>
        void SaveOrUpdateCopyPaymentOutDocDetailEntity(PaymentOutDocDetailEntity paymentOutDocDetailEntity);

        /// <summary>
        /// Saves Or Updates <see cref="PaymentOutPayInDetailEntity"/>
        /// </summary>
        /// <param name="paymentOutPayInDetailEntity">The paymentOutPayInDetailEntity.</param>
        void SaveOrUpdateCopyPaymentOutPayInDetailEntity(PaymentOutPayInDetailEntity paymentOutPayInDetailEntity);

        /// <summary>
        /// Saves Or Updates <see cref="PaymentOutDocDetailEntity"/>
        /// </summary>
        /// <param name="paymentOutPayInDetailEntity">The paymentOutPayInDetailEntity.</param>
        void SaveOrUpdatePaymentOutDocDetailEntity(PaymentOutDocDetailEntity paymentOutDocDetailEntity);

        /// <summary>
        /// Saves Or Updates <see cref="PaymentOutPayInDetailEntity"/>
        /// </summary>
        /// <param name="paymentOutPayInDetailEntity">The paymentOutPayInDetailEntity.</param>
        void SaveOrUpdatePaymentOutPayInDetailEntity(PaymentOutPayInDetailEntity paymentOutPayInDetailEntity);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubCaseSpecificEntity"/> interface.
        /// </summary>
        /// <param name="iSubCaseSpecificEntity"><see cref="ISubCaseSpecificEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateSubCaseSpecificEntity(ISubCaseSpecificEntity iSubCaseSpecificEntity, bool isCopy);

        List<DocAppProcessByExAgencyEntity> GetListDocAppProcessByExAgencyEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the bill of sale sub info entity.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        BillOfSaleSubInfoEntity GetBillOfSaleSubInfoEntity(string submissionGroupId);

        /// <summary>
        /// Gets the bill of sale info entity.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        BillOfSaleInfoEntity GetBillOfSaleInfoEntity(string submissionGroupId);

        /// <summary>
        /// Gets the List of <see cref="DegreeInfoEntity"/>
        /// </summary>
        /// <param name="sGID">The submission group id.</param>
        /// <returns>List<DegreeInfoEntity></returns>
        List<DegreeInfoEntity> GetListDegreeInfoEntityBySGID(string sGID);

        /// <summary>
        /// Gets the claim amount entity.
        /// </summary>
        /// <param name="docId">The doc id.</param>
        /// <returns></returns>
        List<ClaimAmountEntity> GetClaimAmountEntity(string docId);

        List<NumberOfJudgeAssignDetailEntity> GetListNumberOfJudgeAssignDetailEntityByWSNo(string workFlowSerialNo);

        List<NumberOfJudgeAssignDetailHistoryEntity> GetListNumberOfJudgeAssignDetailHistoryEntity(string NoOfJudgeAssignDetailId);

        NumberOfJudgeAssignDetailEntity GetNumberOfJudgeAssignDetailEntityByPK(string NoOfJudgeAssignDetailId);

        PCInfoEntity GetPCInfoEntityBySGID(string submissionGroupId);

        /// <summary>
        /// Gets the list cert security of costs information entity by sgid.
        /// </summary>
        /// <param name="submissionGroupId">The submission group identifier.</param>
        /// <returns></returns>
        List<CertSecurityOfCostsInfoEntity> GetListCertSecurityOfCostsInfoEntityBySGID(string submissionGroupId);

        #endregion Methods
    }
}