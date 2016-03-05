namespace AllInOne.Legal.Mediator.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Enforcement;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.SubCase;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Interface of Enforcement Mediator.
    /// </summary>
    public interface IEnforcementMediator : IMasterMediator
    {
        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that 
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        new void BeginTransaction();

        /// <summary>
        /// 
        /// </summary>
        void CommitTransaction();

        /// <summary>
        /// 
        /// </summary>
        void RollBackTransaction();

        /// <summary>
        /// 
        /// </summary>
        new void CloseSession();

        /// <summary>
        /// (Obsolete! Don't Use.) Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        new void CommitAndCloseSession();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRetrievalSqlQuery"></param>
        /// <returns></returns>
        DataTable GetDataOnSQLQuery(string dataRetrievalSqlQuery);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRetrievalSqlQuery"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        DataTable GetDataOnSQLQuery(string dataRetrievalSqlQuery, CommandType commandType);

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
        /// <param name="courtId"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        List<object> BindAssignBailiffsGrid(string fromDate, string toDate, string apptType, string bailiffId, string team, bool isNoAppt, int currentPageNo, int pageRecordsCount, string courtId, out int count);
        
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
        List<object> BindAssignBailiffsGrid(string fromDate, string toDate, string apptType, string bailiffId, string team, bool isNoAppt, int currentPageNo, int pageRecordsCount, out int count);

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
        List<object> GetEnquiryDetails(string key, string caseInfoId, string subCaseInfoId, int currentPageNo, int pageRecordsCount, out int count, List<string> ISSubCaseIds);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subCaseInfoId"></param>
        /// <returns></returns>
        List<object> GetExecutionAddressDetails(string subCaseInfoId, int currentPageNo, int pageRecordsCount, out int count);

        /// <summary>
        /// Binds the MOM register grid.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <param name="currentPageNo">The current page no.</param>
        /// <param name="pageRecordsCount">The page records count.</param>
        /// <param name="count">The count.</param>
        /// <returns></returns>
        List<object> BindMOMRegisterGrid(int year, int currentPageNo, int pageRecordsCount, out int count);

        /// <summary>
        /// Delete the entity by passing query list.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <param name="queryList">The NHibernate ICriterion List.</param>
        /// <returns>Total number of deleted entity.</returns>
        Int32 DeleteEntity<T>(ICollection<ICriterion> queryList);

        /// <summary>
        /// Delete the records by passing field name and its value
        /// </summary>
        /// <typeparam name="T">Type of Entity to be deleted.</typeparam>
        /// <typeparam name="V">Type of the value of parameter</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">Value of the field.</param>
        /// <returns>Number of records deleted.</returns>
        int DeleteCaseEntity<T, V>(string fieldName, V value);

        /// <summary>
        /// Delete the records by passing field name and its value
        /// </summary>
        /// <typeparam name="T">Type of Entity to be deleted.</typeparam>
        /// <typeparam name="V">Type of the value of parameter</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">Value of the field.</param>
        /// <returns>Number of records deleted.</returns>
        int DeleteCommonEntity<T, V>(string fieldName, V value);

        /// <summary>
        /// Delete the records by passing field name and its value
        /// </summary>
        /// <typeparam name="T">Type of Entity to be deleted.</typeparam>
        /// <typeparam name="V">Type of the value of parameter</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">Value of the field.</param>
        /// <returns>Number of records deleted.</returns>
        int DeleteEntity<T, V>(string fieldName, V value);

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
        int DeleteEntity<T, V, V2>(string fieldName, V value, string secondFieldName, V2 secondValue, LogicalOperator logicalOperator);
        
        /// <summary>
        /// Delete the records by passing field name and its value
        /// </summary>
        /// <typeparam name="T">Type of Entity to be deleted.</typeparam>
        /// <param name="entityToBeDeleted">The entity to be deleted.</param>
        /// <returns>Number of records deleted.</returns>
        void DeleteEntity<T>(T entityToBeDeleted);

        /// <summary>
        /// Get SubcaseInfo data by case number.
        /// </summary> 
        /// <param name="caseNo">The Case Number.</param>
        /// <returns>EMSSubCaseInfoData</returns>
        EMSSubCaseInfoData GetEMSSubCaseInfoDataByCaseNo(string caseNo);

        /// <summary>
        /// Get the entities by passing query list.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <param name="queryList">The NHibernate ICriterion List.</param>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        List<T> GetEntity<T>(ICollection<ICriterion> queryList);

        /// <summary>
        /// Retrieve the defined number of records base on filed and value.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the value to use as the filter while retrieving.</typeparam>
        /// <param name="queryList">List of Query Criteria.</param>
        /// <param name="sortFiledName">Name of the field to use for sorting.</param>
        /// <param name="sortDirection">Sort direction (ASC or DESC).</param>
        /// <param name="rows">Number of rows to retrieve.</param>
        /// <param name="pageIndex">Current page index.</param>
        /// <param name="totalResult">To get back the total number of record.</param>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        List<T> GetEntity<T>(ICollection<ICriterion> queryList, string sortFiledName, SortingDirection sortDirection, Int32 rows, Int32 pageIndex, ref Int32 totalResult);
          
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
        List<T> GetEntity<T>(ICollection<ICriterion> queryList
            , List<string> groupByFields
            , string sortFiledName
            , SortingDirection sortDirection
            , Int32 rows
            , Int32 pageIndex
            , ref Int32 totalResult);

        /// <summary>
        /// Get the entities by passing query list.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <param name="queryList">The NHibernate ICriterion List.</param>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        List<T> GetEntityObsIndIgnore<T>(ICollection<ICriterion> queryList);

        /// <summary>
        /// Retrieve all records of the specific entity.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        List<T> GetEntity<T>();

        /// <summary>
        /// Retrieve all records which is equal to the value passed.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the value of the parameter.</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">Value of the field.</param>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        List<T> GetEntity<T, V>(string fieldName, V value);

        /// <summary>
        /// Retrieve all records which fall between the two values.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the value of parameter.</typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="valueFrom">Start Value of the field.</param>
        /// <param name="valueTo">End Value of the field.</param>
        /// <returns>List of <typeparamref name="T"/>.</returns>
        List<T> GetEntity<T, V>(string fieldName, V valueFrom, V valueTo);
        
        /// <summary>
        /// Retrieve all records which is 'like' the value passed.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <param name="fieldName">Name of the 'like'n field.</param>
        /// <param name="value">Value of the 'like' field.</param> 
        /// <returns>List of <typeparamref name="T"/>.</returns>
        List<T> GetEntityLike<T>(string fieldName, string value);

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
        List<T> GetEntity<T, V, V1>(string fieldName, V value, string secondFieldName, V1 secondValue, LogicalOperator logicOperator);

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
        List<EnfrocementMaintainChequeQREntity> GetMaintainCheque(string chequeNoFrom, string chequeNoTo, DateTime payDateFrom, DateTime payDateTo, string subCaseNo, string accountNo, string chequeStatus, string chequeId, bool isMainTainCheque, List<string> listForumId);

        /// <summary>
        /// Gets the paged MOM register view entity.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <param name="currentPageNo">The current page no.</param>
        /// <param name="pageRecordsCount">The page records count.</param>
        /// <param name="count">The count.</param>
        /// <returns></returns>
        List<MOMRegisterViewEntity> GetPagedMOMRegisterViewEntity(int year, int currentPageNo, int pageRecordsCount, out int count);

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
        List<EnfrocementProcessPaymentQREntity> GetProcessPayment(string paymentVoucherNo, DateTime voucherDateFrom, DateTime voucherDateTo, string subCaseNo, string payeeName, string accountNo, bool isCase, List<string> listForumId);

        /// <summary>
        /// Insert and update a group of Parent/Child of CashBookReconciliation.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        void SaveCashBookReconciliationPayment(EnforcementParentChildInsert parentChildInsert);

        /// <summary>
        /// Insert and update a group of Parent/Child of ChequePayment.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        void SaveChequePayment(EnforcementParentChildInsert parentChildInsert);

        /// <summary>
        /// Insert and update a group of Parent/Child of EMSAccount.
        /// </summary>
        /// <param name="parentChildInsert"></param>
        void SaveEMSAccountGroup(EnforcementParentChildInsert parentChildInsert);

        /// <summary>
        /// Insert and update a group of Parent/Child of EMSAdmProperty.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        void SaveEMSAdmPropertyGroup(EnforcementParentChildInsert parentChildInsert);

        /// <summary>
        /// Insert and update a group of Parent/Child of EMSRecapitulation.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        void SaveEMSCrmCaseGroup(EnforcementParentChildInsert parentChildInsert);

        /// <summary>
        /// Insert and update a group of Parent/Child of EMSRecapitulation.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        void SaveEMSRecapitulationGroup(EnforcementParentChildInsert parentChildInsert);

        /// <summary>
        /// Insert and update a group of Parent/Child of EMSReceipt.
        /// </summary>
        /// <param name="parentChildInsert"></param>
        void SaveEMSReceiptGroup(EnforcementParentChildInsert parentChildInsert);

        /// <summary>
        /// Insert and update a group of Parent/Child of EMSSale.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        void SaveEMSSaleGroup(EnforcementParentChildInsert parentChildInsert);

        /// <summary>
        /// Save all Enforcement entities. Only for Enforcement entities.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be saved.</typeparam>
        /// <param name="iEnforcementEntity">Object that is to be saved.</param>
        /// <param name="isCopy">Indicator that this is to use Cache in NHibernate or not.</param>
        void SaveOrUpdateEntity<T>(T iEnforcementEntity, bool isCopy)
            where T : IEnforcementEntity;

        /// <summary>
        /// Save all kinds of entity specified in the Type parameter.
        /// </summary>
        /// <typeparam name="TSource">Type of the entity to be saved.</typeparam>
        /// <param name="objectToSave">Object that is to be saved.</param>
        /// <param name="isCopy">Indicator that this is to use Cache in NHibernate or not.</param>
        void SaveOrUpdateGenericEntity<TSource>(TSource objectToSave, bool isCopy);

        /// <summary>
        /// Save or Update the MEMSParam.
        /// </summary> 
        /// <param name="mEMSParamEntity">MEMSParam Object that is to be saved.</param>
        /// <param name="isCopy">Indicator that this is to use Cache in NHibernate or not.</param>
        void SaveOrUpdateMEMSParam(MEMSParamEntity mEMSParamEntity, bool isCopy);

        /// <summary>
        /// Insert and update a group of Parent/Child of PaymentVoucher for AdHoc.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        void SavePaymentVoucherAdHoc(EnforcementParentChildInsert parentChildInsert);

        /// <summary>
        /// Insert and update a group of Parent/Child of PaymentVoucher for Admiralty.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        void SavePaymentVoucherAdmAdHoc(EnforcementParentChildInsert parentChildInsert);

        /// <summary>
        /// Insert and update a group of Parent/Child of PaymentVoucher for Final.
        /// </summary> 
        /// <param name="parentChildInsert">Enforcement Parent Child Insert object which is to be saved.</param> 
        void SavePaymentVoucherFinal(EnforcementParentChildInsert parentChildInsert);

        List<EMSAppointmentEntity> GetListEMSAppointmentEntity(string EMSAccountId);
        #endregion Methods
    }
}