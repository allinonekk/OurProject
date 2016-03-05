namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Enforcement;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Data;

    using log4net;

    public class BizMonitoringMediatorImpl : IBizMonitoringMediator
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(BizMonitoringMediatorImpl));

        /// <summary>
        /// ApplicationSessionManager instance for session.
        /// </summary>
        private ApplicationSessionManager applicationSessionManager;

        #endregion Fields

        #region Methods

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
            Logger.Info("FilingBrokerMediatorImpl - CloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CloseSession();

            Logger.Info("FilingBrokerMediatorImpl - CloseSession ended at " + DateTime.Now.ToString());
        }

        public void CommitAndCloseSession()
        {
            Logger.Info("BackEndMediatorImpl - CommitAndCloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager = new ApplicationSessionManager();
            this.applicationSessionManager.CommitAndCloseSession();

            Logger.Info("BackEndMediatorImpl - CommitAndCloseSession ended at " + DateTime.Now.ToString());
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

        //where T : IEnforcementEntity, IMasterEntity
        /// <summary>
        /// Retrieve all records of the specific entity in the Type Parameter.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <returns>List of specified entity in the Type Parameter.</returns>
        public IEnumerable<T> GetEnforcementEntity<T>()
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type nhibernateType = gateWay.TypeMapper<T>();
            if (gateWay.HasObsInd(nhibernateType))
            {
                List<object> listNHibernateEntity = gateWay.GetEntity<object>(nhibernateType, gateWay.HasObsInd(nhibernateType));
                return gateWay.MapToDomainObject<T>(listNHibernateEntity);
            }
            else
            {
                List<T> listNHibernateEntity = gateWay.GetEntity<T>(nhibernateType, gateWay.HasObsInd(nhibernateType));
                return gateWay.MapToDomainObject<T>(listNHibernateEntity.Select(ent => (object)ent).ToList());
            }
        }

        //where T : IEnforcementEntity, IMasterEntity
        /// <summary>
        /// Retrieve all records which is equal to the value passed.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the value to use as the filter while retrieving.</typeparam>
        /// <param name="fieldName">Name of the field (column).</param>
        /// <param name="value">Value of the field (column).</param>
        /// <returns>List of specified entity in the Type Parameter.</returns>
        public IEnumerable<T> GetEnforcementEntity<T, V>(string fieldName, V value)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type nhibernateType = gateWay.TypeMapper<T>();
            List<object> listNHibernateEntity = gateWay.GetEntity<object, V>(nhibernateType, fieldName, value, gateWay.HasObsInd(nhibernateType));

            return gateWay.MapToDomainObject<T>(listNHibernateEntity);
        }

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
        public IEnumerable<T> GetEnforcementEntityBetween<T, V>(string fieldName, V startValue, V endValue)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type nhibernateType = gateWay.TypeMapper<T>();
            List<object> listNHibernateEntity = gateWay.GetEntity<object, V>(nhibernateType, fieldName, startValue, endValue, gateWay.HasObsInd(nhibernateType));

            return gateWay.MapToDomainObject<T>(listNHibernateEntity);
        }

        //where T : IEnforcementEntity, IMasterEntity
        /// <summary>
        /// Retrieve all records which is in the list of values passed.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be retrieved.</typeparam>
        /// <typeparam name="V">Type of the value to use as the filter while retrieving.</typeparam>
        /// <param name="fieldName">Name of the field (column).</param>
        /// <param name="value">A list values of the field (column).</param>
        /// <returns>List of specified entity in the Type Parameter.</returns>
        public IEnumerable<T> GetEnforcementEntityIn<T, V>(string fieldName, List<V> value)
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            Type iNhibernateType = gateWay.TypeMapper<T>();
            List<object> listNHibernateEntity = gateWay.GetEntityIn<object, V>(iNhibernateType, fieldName, value, gateWay.HasObsInd(iNhibernateType));

            return gateWay.MapToDomainObject<T>(listNHibernateEntity);
        }

        public JudicialUserEntity GetJudicialUserByPK(string userId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetJudicialUserEntityByPK(userId);
        }

        public List<CasePartyEntity> GetListCasePartyEntityByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetCasePartyByCaseInfoId(caseInfoId);
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

        /// <summary>
        /// Get list document info by hearing Id
        /// </summary>
        /// <param name="hrgId"></param>
        /// <returns></returns>
        public List<DocumentInfoEntity> GetListDocumentInfoEntityByHrgId(long hrgId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoByHrgId(hrgId);
        }

        public List<HearingEntity> GetListHearingByCaseInfoId(string caseInfoId)
        {
            CaseGateway caseGateway = new CaseGateway();
            return caseGateway.GetListHearingByCaseInfoId(caseInfoId);
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

        public void SaveOrUpdateCaseEntity(ICaseEntity caseEntity, bool isCopy)
        {
            CaseGateway caseGateway = new CaseGateway();
            if (isCopy)
                caseGateway.SaveOrUpdateInMemoryEntity<ICase>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseEntity<ICaseEntity>(caseEntity));
            else
                caseGateway.SaveOrUpdateEntity<ICase>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseEntity<ICaseEntity>(caseEntity));
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
        /// Save all Enforcement entities. Only for Enforcement entities.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be saved.</typeparam>
        /// <param name="iEnforcementEntity">Object that is to be saved.</param>
        /// <param name="isCopy">Indicator that this is to use Cache in NHibernate or not.</param>
        public void SaveOrUpdateEnforcementEntity<T>(T iEnforcementEntity, bool isCopy)
            where T : IEnforcementEntity
        {
            EnforcementGateway gateWay = new EnforcementGateway();
            gateWay.SaveOrUpdateEntity<IEnforcement>(EnforcementMapperToDomain.GetEnforcementEntity<T>(iEnforcementEntity), isCopy);
        }

        public List<DocumentInfoEntity> GetListDocumentByDocCodeAndSubCaseInfoId(string subCaseInfoId, string docCode)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentByDocCodeAndSubCaseInfoId(subCaseInfoId, docCode);
        }

        public List<DocumentInfoEntity> GetListDocumentInfoBySubCaseInfoId(string subCaseInfoId)
        {
            DocumentGateway documentGateway = new DocumentGateway();
            return documentGateway.GetListDocumentInfoBySubCaseInfoId(subCaseInfoId);
        }

        #endregion Methods

    }
}