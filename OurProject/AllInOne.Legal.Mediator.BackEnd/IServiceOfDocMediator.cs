#region Header

/*****************************************************************************************************
* Description : This file represents a mediator interface for PreFetch module.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*  26/10/2010   		      Narayan             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: IServiceOfDocMediator.cs
// Description: Represents a mediator interface for Service Of Documents module.
// </summary>
// <copyright file= "IServiceOfDocMediator.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd
{
    using System.Collections.Generic;

    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Domain.SubCaseSpecific;

    public interface IServiceOfDocMediator : IMediator
    {
        #region Methods

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        void CommitAndCloseSession();

        //By Yan Nai - Jan 17, 2011
        /// <summary>
        /// Get CaseInfoEntity by criteria.
        /// </summary>
        /// <typeparam name="T">Type which to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<CaseInfoEntity></returns>
        List<CaseInfoEntity> GetCaseInfo<V>(string fieldName, V value);

        //By Yan Nai - Jan 17, 2011
        /// <summary>
        /// Get CaseInfo by SubmissionGroupId of RCaseSubmission object.
        /// </summary> 
        /// <param name="submissionGroupID">The value of Submission Group Id.</param>
        /// <returns>List<CaseInfoEntity></returns>
        List<CaseInfoEntity> GetCaseInfoBySubmissionGroupId(string submissionGroupID);

        CaseInfoEntity GetCaseInfoEntity(string caseInfoId);

        CasePartyEntity GetCasePartyEntityByPK(string casePartyId);

        //By Yan Nai - Feb 08, 2011
        /// <summary>
        /// Get DocumentInfoEntity by criteria.
        /// </summary> 
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<DocumentInfoEntity></returns>
        List<DocumentInfoEntity> GetDocumentInfo<V>(string fieldName, V value);

        List<CaseInfoEntity> GetListCaseInfoEntity(string caseNo, string caseName);

        List<CasePartyEntity> GetListCasePartyEntityByCaseInfoId(string caseInfoId);

        List<ServiceOfDocDocStatusHistoryEntity> GetListServiceOfDocDocStatusHistoryEntityByServiceOfDocInfoId(string serviceOfDocInfoId);

        List<ServiceOfDocInfoDetailEntity> GetListServiceOfDocInfoDetailEntityByServiceOfDocInfoId(string serviceOfDocInfoId);

        List<ServiceOfDocInfoEntity> GetListServiceOfDocInfoEntityByCaseInfoId(long caseInfoId);

        List<ServiceOfDocInfoEntity> GetListServiceOfDocInfoEntityByServiceSatus(ServiceStatus serviceStatus);

        /// <summary>
        /// Gets the list of <see cref="SubCaseInfoEntity "/>
        /// </summary>
        /// <param name="subCaseNo">The CaseInfoId.</param>
        /// <returns></returns>
        List<SubCaseInfoEntity> GetListSubCaseInfoEntityByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list of <see cref="SubCaseInfoEntity "/>
        /// </summary>
        /// <param name="subCaseNo">The SubCaseNo.</param>
        /// <returns></returns>
        List<SubCaseInfoEntity> GetListSubCaseInfoEntityBySubCaseNo(string subCaseNo);

        //By Yan Nai - Jan 17, 2011
        /// <summary>
        /// Get PaymentInDocDetailEntity by criteria.
        /// </summary>
        /// <typeparam name="T">Type which to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<PaymentInDocDetailEntity></returns>
        List<PaymentInDocDetailEntity> GetPaymentInDocDetail();

        //By Yan Nai - Jan 17, 2011
        /// <summary>
        /// Get GetPaymentOutDocDetail by criteria.
        /// </summary>
        /// <typeparam name="T">Type which to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<PaymentOutDocDetailEntity></returns>
        List<PaymentOutDocDetailEntity> GetPaymentOutDocDetail<V>(string fieldName, V value);

        //By Yan Nai - Jan 17, 2011
        /// <summary>
        /// Get PaymentOutDocDetailEntity by criteria.
        /// </summary>
        /// <typeparam name="T">Type which to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<PaymentOutDocDetailEntity></returns>
        List<PaymentOutDocDetailEntity> GetPaymentOutDocDetail();

        //By Yan Nai - Jan 17, 2011
        /// <summary>
        /// Get PaymentOutPayInDetail by criteria.
        /// </summary>
        /// <typeparam name="T">Type which to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<PaymentOutPayInDetailEntity></returns>
        List<PaymentOutPayInDetailEntity> GetPaymentOutPayInDetail<V>(string fieldName, V value);

        //By Yan Nai - Jan 17, 2011
        /// <summary>
        /// Get all PaymentOutPayInDetail
        /// </summary> 
        /// <returns>List<PaymentOutPayInDetailEntity></returns>
        List<PaymentOutPayInDetailEntity> GetPaymentOutPayInDetail();

        ServiceOfDocDocStatusHistoryEntity GetServiceOfDocDocStatusHistoryEntityByPK(string serviceOfDocDocStatusId);

        ServiceOfDocInfoEntity GetServiceOfDocInfoEntityByPK(string serviceOfDocInfoId);

        //By Yan Nai - Jan 17, 2011
        /// <summary>
        /// Get SubCaseInfoEntity by criteria.
        /// </summary>
        /// <typeparam name="T">Type which to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the parameter value to be passed by.</typeparam>
        /// <param name="fieldName">The field name to use as filter while querying.</param>
        /// <param name="value">The value to use as filter while querying.</param>
        /// <returns>List<SubCaseInfoEntity></returns>
        List<SubCaseInfoEntity> GetSubCaseInfo<V>(string fieldName, V value);

        //By Yan Nai - Jan 17, 2011
        /// <summary>
        /// Get SubCaseInfo by SubmissionGroupId of RSubCaseSubmission object.
        /// </summary> 
        /// <param name="submissionGroupID">The value of Submission Group Id.</param>
        /// <returns>List<SubCaseInfoEntity></returns>
        List<SubCaseInfoEntity> GetSubCaseInfoBySubmissionGroupId(string submissionGroupID);

        void SaveOrUpdateDocDocStatusHistoryEntity(ServiceOfDocDocStatusHistoryEntity serviceOfDocDocStatusHistoryEntity);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="IDocumentEntity"/> interface.
        /// </summary>
        /// <param name="iDocumentEntity"><see cref="ISubCaseSpecificEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateDocumentEntity(IDocumentEntity iDocumentEntity, bool isCopy);

        void SaveOrUpdateServiceDocInfoEntity(ServiceOfDocInfoEntity serviceOfDocInfoEntity);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubCaseSpecificEntity"/> interface.
        /// </summary>
        /// <param name="iSubCaseSpecificEntity"><see cref="ISubCaseSpecificEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateSubCaseSpecificEntity(ISubCaseSpecificEntity iSubCaseSpecificEntity, bool isCopy);

        /// <summary>
        /// Gets the list document info.
        /// </summary>
        /// <param name="SubCaseInfoId">The sub case info id.</param>
        /// <param name="docCode">The doc code.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentInfo(string SubCaseInfoId, string docCode);
        #endregion Methods
    }
}