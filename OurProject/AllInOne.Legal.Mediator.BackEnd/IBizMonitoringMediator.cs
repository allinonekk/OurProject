namespace AllInOne.Legal.Mediator.BackEnd
{
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Enforcement;
    using AllInOne.Legal.Domain.Interfaces;

    public interface IBizMonitoringMediator
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
        /// Gets the <see cref="CaseInfoId"/> and returns the CaseInfoEntity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns>Returns <see cref="CaseInfoEntity"/> if found else null.</returns>
        CaseInfoEntity GetCaseInfoEntity(string caseInfoId);

        /// <summary>
        /// Retrieve all records of the specific entity in the Type Parameter.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <returns>List of specified entity in the Type Parameter.</returns>
        IEnumerable<T> GetEnforcementEntity<T>();

        //where T : IEnforcementEntity, IMasterEntity
        /// <summary>
        /// Retrieve all records which is equal to the value passed.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the value to use as the filter while retrieving.</typeparam>
        /// <param name="fieldName">Name of the field (column).</param>
        /// <param name="value">Value of the field (column).</param>
        /// <returns>List of specified entity in the Type Parameter.</returns>
        IEnumerable<T> GetEnforcementEntity<T, V>(string fieldName, V value);

        //where T : IEnforcementEntity, IMasterEntity
        /// <summary>
        /// Retrieve all records which is between the 2 values passed.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the value to use as the filter while retrieving.</typeparam>
        /// <param name="fieldName">Name of the field (column).</param>
        /// <param name="startValue">Start Value of the field (column).</param>
        /// <param name="endValue">End Value of the field (column).</param>
        /// <returns>List of specified entity in the Type Parameter.</returns>
        IEnumerable<T> GetEnforcementEntityBetween<T, V>(string fieldName, V startValue, V endValue);

        //where T : IEnforcementEntity, IMasterEntity
        /// <summary>
        /// Retrieve all records which is in the list of values passed.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the value to use as the filter while retrieving.</typeparam>
        /// <param name="fieldName">Name of the field (column).</param>
        /// <param name="value">A list values of the field (column).</param>
        /// <returns>List of specified entity in the Type Parameter.</returns>
        IEnumerable<T> GetEnforcementEntityIn<T, V>(string fieldName, List<V> value);

        JudicialUserEntity GetJudicialUserByPK(string userId);

        /// <summary>
        /// Gets the list case party entity by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<CasePartyEntity> GetListCasePartyEntityByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the <see cref="docId"/>and returns <see cref="List<DocCasePartyAICDetailsEntity>"/>
        /// </summary>
        /// <param name="docId">The document case party Id.</param>
        /// <returns></returns>
        List<DocCasePartyEntity> GetListDocCasePartyByDocId(string docId);

        /// <summary>
        /// Gets the list document info by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentInfoByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Gets the list document info by sub case info id.
        /// </summary>
        /// <param name="subCaseInfoId">The sub case info id.</param>
        /// <param name="docCode">The doc code.</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentByDocCodeAndSubCaseInfoId(string subCaseInfoId, string docCode);

        List<DocumentInfoEntity>GetListDocumentInfoBySubCaseInfoId(string subCaseInfoId);

        /// <summary>
        /// Gets the <see cref="HearingEntity"/>
        /// </summary>
        /// <param name="hrgId"></param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetListDocumentInfoEntityByHrgId(long hrgId);

        /// <summary>
        /// Gets the list document info by caseInfoId
        /// </summary>
        /// <param name="caseInfoId">The caseInfoId</param>
        /// <returns></returns>
        List<HearingEntity> GetListHearingByCaseInfoId(string caseInfoId);

        /// <summary>
        /// Saves the or update back end specific entity.
        /// </summary>
        /// <param name="iBackEndSpecificEntity">The i back end specific entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateBackEndSpecificEntity(IBackEndSpecificEntity iBackEndSpecificEntity, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ICaseEntity"/> interface.
        /// </summary>
        /// <param name="ICaseEntity"><see cref="ICaseEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateCaseEntity(ICaseEntity caseEntity, bool isCopy);

        /// <summary>
        /// Saves or Updates <see cref="CasePartyEntity "/>
        /// </summary>
        /// <param name="casePartyEntity"></param>
        void SaveOrUpdateCasePartyEntity(CasePartyEntity casePartyEntity);

        // where T : IEnforcementEntity, IMasterEntity
        /// <summary>
        /// Save all Enforcement entities. Only for Enforcement entities.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be saved.</typeparam>
        /// <param name="iEnforcementEntity">Object that is to be saved.</param>
        /// <param name="isCopy">Indicator that this is to use Cache in NHibernate or not.</param>
        void SaveOrUpdateEnforcementEntity<T>(T iEnforcementEntity, bool isCopy)
            where T : IEnforcementEntity;

        #endregion Methods
    }
}