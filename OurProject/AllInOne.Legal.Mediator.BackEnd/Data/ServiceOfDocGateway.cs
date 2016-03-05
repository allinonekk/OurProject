namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    internal class ServiceOfDocGateway
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(ServiceOfDocGateway));

        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        internal ServiceOfDocGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

            //AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.Mapping nHibernateToDomainMapping = new AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.Mapping();
            //nHibernateToDomainMapping.MapAll();
            //MappingToDTO nHibernateToDomainMapping = new MappingToDTO();
            //nHibernateToDomainMapping.MapAll();

            //MappingToDomain domainToNHibernate = new MappingToDomain();
            //domainToNHibernate.MapAll();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Passes the <paramref name="columnName"/> and <paramref name="value"/>. Get the <typeparam name="T"></typeparam> back.
        /// </summary>
        /// <typeparam name="V">Type of the value to use as a filter.</typeparam>
        /// <param name="columnName">The name of the filed to filter while retrieving objects.</param>
        /// <param name="value">The value of the filed to filter while retrieving objects.</param>
        /// <returns>List<T></returns>
        internal List<T> GetEntity<T, V>(string fieldName, V value)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            return iRepository.GetAll(this.GetDetachedCriteriaGeneric<T, V>(fieldName, value)) as List<T>;
        }

        /// <summary>
        /// Passes the <paramref name="columnName"/> and <paramref name="value"/>. Get the <typeparam name="T"></typeparam> back.
        /// </summary>
        /// <typeparam name="V">Type of the value to use as a filter.</typeparam>
        /// <param name="columnName">The name of the filed to filter while retrieving objects.</param>
        /// <param name="value">The value of the filed to filter while retrieving objects.</param>
        /// <returns>List<T></returns>
        internal List<T> GetEntity<T, V>(string fieldName, V value, string fullNameOfChildObj)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            return iRepository.GetAll(this.GetDetachedCriteriaGeneric<T, V>(fieldName, value, fullNameOfChildObj)) as List<T>;
        }

        /// <summary>
        /// Passes the <paramref name="columnName"/> and <paramref name="value"/>. Get the <typeparam name="T"></typeparam> back.
        /// </summary>
        /// <typeparam name="V">Type of the value to use as a filter.</typeparam>
        /// <param name="columnName">The name of the filed to filter while retrieving objects.</param>
        /// <param name="value">The value of the filed to filter while retrieving objects.</param>
        /// <returns>List<T></returns>
        internal List<T> GetEntity<T, V1, V2>(string firstFieldName, V1 firstValue, string sencondFieldName, V2 secondValue, LogicalOperator logicOperator)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            return iRepository.GetAll(this.GetDetachedCriteriaGeneric<T, V1, V2>(firstFieldName, firstValue, sencondFieldName, secondValue, logicOperator)) as List<T>;
        }

        /// <summary>
        /// Get Case Info Detail  based on CaseName & CaseNo
        /// </summary>
        /// <param name="CaseName OR CaseNo"></param>
        /// <returns>ServiceOfDocInfoDetailEntity</returns>
        internal List<CaseInfoEntity> GetListCaseInfoEntityByCaseNameORCaseNo(string CaseNo, string caseName)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ServiceOfDocDocStatusHistory))
                                                                            .Add(Expression.Or((Expression.Like("CaseNo", CaseNo, MatchMode.Anywhere)), Expression.Like("CaseName", caseName, MatchMode.Anywhere)));
            List<CaseInfo> listCaseInfoEntity = GetAllCaseInfoEntity(detachedCriteria);

            if (listCaseInfoEntity != null && listCaseInfoEntity.Count > 0)
            {
                return listCaseInfoEntity.Select(caseInfoEntity => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseInfoEntity(caseInfoEntity)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get Service of Doc status history based on serviceOfDocInfoId
        /// </summary>
        /// <param name="serviceOfDocInfoId"></param>
        /// <returns>ServiceOfDocDocStatusHistoryEntity</returns>
        internal List<ServiceOfDocDocStatusHistoryEntity> GetListServiceOfDocDocStatusHistoryByServiceOfDocInfoID(string serviceOfDocInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ServiceOfDocDocStatusHistory))
                                                                            .Add(Expression.Eq("ServiceOfDocInfoId", serviceOfDocInfoId));

            List<ServiceOfDocDocStatusHistory> listServiceOfDocDocStatusHistory = GetAllServiceOfDocDocStatusHistory(detachedCriteria);

            if (listServiceOfDocDocStatusHistory != null && listServiceOfDocDocStatusHistory.Count > 0)
            {
                return listServiceOfDocDocStatusHistory.Select(serviceOfDocDocStatusHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocDocStatusHistoryEntity(serviceOfDocDocStatusHistory)).ToList();

            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get Service of Doc Info  based on caseInfoId
        /// </summary>
        /// <param name="caseInfoId"></param>
        /// <returns>ServiceOfDocInfoEntity</returns>
        internal List<ServiceOfDocInfoEntity> GetListServiceOfDocInfoByCaseInfoID(long CaseInfoId)
        {
            //System.Int32 CaseInfoId=Convert.ToInt32(_CaseInfoId);
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ServiceOfDocInfo))
                                                                            .Add(Expression.Eq("CaseInfoId", CaseInfoId));

            List<ServiceOfDocInfo> listServiceOfDocInfo = GetAllServiceOfDocInfoByCaseInfoID(detachedCriteria);

            if (listServiceOfDocInfo != null && listServiceOfDocInfo.Count > 0)
            {
                return listServiceOfDocInfo.Select(serviceOfDocInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocInfoEntity(serviceOfDocInfo)).ToList();

            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get Service of Doc Info  based on ServiceSatus
        /// </summary>
        /// <param name="ServiceSatus"></param>
        /// <returns>ServiceOfDocInfoEntity</returns>
        internal List<ServiceOfDocInfoEntity> GetListServiceOfDocInfoByServiceStatus(ServiceStatus serviceStatus)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ServiceOfDocInfo))
                                                                            .Add(Expression.Eq("ServiceSatus", serviceStatus.ToString()));

            List<ServiceOfDocInfo> listServiceOfDocInfo = GetAllServiceOfDocInfoByStatus(detachedCriteria);

            if (listServiceOfDocInfo != null && listServiceOfDocInfo.Count > 0)
            {
                return listServiceOfDocInfo.Select(serviceOfDocInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocInfoEntity(serviceOfDocInfo)).ToList();

            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get Service of Doc Info Detail  based on serviceOfDocInfoId
        /// </summary>
        /// <param name="serviceOfDocInfoId"></param>
        /// <returns>ServiceOfDocInfoDetailEntity</returns>
        internal List<ServiceOfDocInfoDetailEntity> GetListServiceOfDocInfoDetailByServiceOfDocInfoID(string serviceOfDocInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ServiceOfDocInfoDetail))
                                                                            .Add(Expression.Eq("ServiceOfDocInfoId", serviceOfDocInfoId));

            List<ServiceOfDocInfoDetail> listServiceOfDocInfoDetail = GetAllServiceOfDocInfoDetail(detachedCriteria);

            if (listServiceOfDocInfoDetail != null && listServiceOfDocInfoDetail.Count > 0)
            {
                return listServiceOfDocInfoDetail.Select(serviceOfDocInfoDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocInfoDetailEntity(serviceOfDocInfoDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get Service of Doc status history based on ServiceOfDocDocStatusID
        /// </summary>
        /// <param name="ServiceOfDocDocStatusID"></param>
        /// <returns>ServiceOfDocDocStatusHistoryEntity</returns>
        internal ServiceOfDocDocStatusHistoryEntity GetServiceOfDocDocStatusHistoryByPK(string serviceOfDocDocStatusId)
        {
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocDocStatusHistoryEntity(GetServiceOfDocDocStatusHistory(serviceOfDocDocStatusId));
        }

        internal ServiceOfDocDocumentEntity GetServiceOfDocDocumentEntityByPK(string primaryKey)
        {
            ServiceOfDocDocumentEntity serviceOfDocDocumentEntity = new ServiceOfDocDocumentEntity();

            IRepository<ServiceOfDocDocument> serviceOfDocDocumentRepository = new RepositoryImpl<ServiceOfDocDocument>(applicationSession);
            return serviceOfDocDocumentEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocDocumentEntity(serviceOfDocDocumentRepository.Get(primaryKey));
        }

        /// <summary>
        /// Passes the serviceOfDocInfoId and Gets the serviceOfDocInfo Entity
        /// </summary>
        /// <param name="serviceOfDocInfoId">The service Of serviceOfDocInfoId .</param>
        /// <returns></returns>
        internal ServiceOfDocInfoEntity GetServiceOfDocInfoByPK(string serviceOfDocInfoId)
        {
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocInfoEntity(GetServiceOfDocInfo(serviceOfDocInfoId));
        }

        internal ServiceOfDocInfoDetailEntity GetServiceOfDocInfoDetailEntityByPK(string primaryKey)
        {
            ServiceOfDocInfoDetailEntity serviceOfDocInfoDetailEntity = new ServiceOfDocInfoDetailEntity();

            IRepository<ServiceOfDocInfoDetail> serviceOfDocInfoDetailRepository = new RepositoryImpl<ServiceOfDocInfoDetail>(applicationSession);
            return serviceOfDocInfoDetailEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocInfoDetailEntity(serviceOfDocInfoDetailRepository.Get(primaryKey));
        }

        /// <summary>
        /// Passes the domain object and save it.
        /// </summary>
        /// <param name="entityToSave">The domain object to be saved.<param>
        /// <returns></returns>
        internal void SaveOrUpdateEntity<T>(T entityToSave)
        {
            IRepository<T> fESpecificRepository = new RepositoryImpl<T>(applicationSession);
            fESpecificRepository.SaveOrUpdate(entityToSave);
        }

        /// <summary>
        /// Passes the domain object and save it.
        /// </summary>
        /// <param name="entityToSave">The domain object to be saved.<param>
        /// <returns></returns>
        internal void SaveOrUpdateInMemoryEntity<T>(T entityToSave)
        {
            IRepository<T> fESpecificRepository = new RepositoryImpl<T>(applicationSession);
            fESpecificRepository.SaveOrUpdateCopy(entityToSave);
        }

        /// <summary>
        /// Save ServiceOfDocDocStatusHistory.
        /// </summary>
        /// <param name="ServiceOfDocDocStatusHistoryEntity">The ServiceOfDocDocStatusHistory Entity."</param>
        /// <returns></returns>
        internal void SaveOrUpdateServiceOfDocDocStatusHistoryEntity(ServiceOfDocDocStatusHistoryEntity serviceOfDocDocStatusHistoryEntity)
        {
            IRepository<ServiceOfDocDocStatusHistory> serviceOfDocDocStatusHistoryRepository = new RepositoryImpl<ServiceOfDocDocStatusHistory>(applicationSession);
            serviceOfDocDocStatusHistoryRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.ServiceOfDocMapper.GetServiceOfDocDocStatusHistory(serviceOfDocDocStatusHistoryEntity));
        }

        internal void SaveOrUpdateServiceOfDocDocumentEntity(ServiceOfDocDocumentEntity serviceOfDocDocumentEntity)
        {
            IRepository<ServiceOfDocDocument> serviceOfDocDocumentRepository = new RepositoryImpl<ServiceOfDocDocument>(applicationSession);
            serviceOfDocDocumentRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.ServiceOfDocMapper.GetServiceOfDocDocument(serviceOfDocDocumentEntity));
        }

        internal void SaveOrUpdateServiceOfDocInfoDetailEntity(ServiceOfDocInfoDetailEntity serviceOfDocInfoDetailEntity)
        {
            IRepository<ServiceOfDocInfoDetail> serviceOfDocInfoDetailRepository = new RepositoryImpl<ServiceOfDocInfoDetail>(applicationSession);
            serviceOfDocInfoDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.ServiceOfDocMapper.GetServiceOfDocInfoDetail(serviceOfDocInfoDetailEntity));
        }

        /// <summary>
        /// Save ServiceOfDocInfoEntity.
        /// </summary>
        /// <param name="ServiceOfDocInfoEntity">The ServiceOfDocInfo Entity."</param>
        /// <returns></returns>
        internal void SaveOrUpdateServiceOfDocInfoEntity(ServiceOfDocInfoEntity serviceOfDocInfoEntity)
        {
            IRepository<ServiceOfDocInfo> serviceOfDocInfoRepository = new RepositoryImpl<ServiceOfDocInfo>(applicationSession);
            serviceOfDocInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.ServiceOfDocMapper.GetServiceOfDocInfo(serviceOfDocInfoEntity));
        }

        private List<CaseInfo> GetAllCaseInfoEntity(DetachedCriteria detachedCriteria)
        {
            IRepository<CaseInfo> caseInfoRepository = new RepositoryImpl<CaseInfo>(applicationSession);
            return caseInfoRepository.GetAll(detachedCriteria) as List<CaseInfo>;
        }

        private List<ServiceOfDocDocStatusHistory> GetAllServiceOfDocDocStatusHistory(DetachedCriteria detachedCriteria)
        {
            IRepository<ServiceOfDocDocStatusHistory> serviceOfDocDocStatusHistoryRepository = new RepositoryImpl<ServiceOfDocDocStatusHistory>(applicationSession);
            return serviceOfDocDocStatusHistoryRepository.GetAll(detachedCriteria) as List<ServiceOfDocDocStatusHistory>;
        }

        private List<ServiceOfDocInfo> GetAllServiceOfDocInfoByCaseInfoID(DetachedCriteria detachedCriteria)
        {
            IRepository<ServiceOfDocInfo> serviceOfDocInfoRepository = new RepositoryImpl<ServiceOfDocInfo>(applicationSession);
            return serviceOfDocInfoRepository.GetAll(detachedCriteria) as List<ServiceOfDocInfo>;
        }

        private List<ServiceOfDocInfo> GetAllServiceOfDocInfoByStatus(DetachedCriteria detachedCriteria)
        {
            IRepository<ServiceOfDocInfo> serviceOfDocInfoRepository = new RepositoryImpl<ServiceOfDocInfo>(applicationSession);
            return serviceOfDocInfoRepository.GetAll(detachedCriteria) as List<ServiceOfDocInfo>;
        }

        private List<ServiceOfDocInfoDetail> GetAllServiceOfDocInfoDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<ServiceOfDocInfoDetail> serviceOfDocInfoDetailRepository = new RepositoryImpl<ServiceOfDocInfoDetail>(applicationSession);
            return serviceOfDocInfoDetailRepository.GetAll(detachedCriteria) as List<ServiceOfDocInfoDetail>;
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria for "between" values
        /// </summary>
        /// <typeparam name="T">Type to search.</typeparam>
        /// <typeparam name="V">Type to use for between.</typeparam>
        /// <param name="fieldName">The fields name of domain entity to use for deletion.</param>
        /// <param name="fromValue">The start value</param>
        /// <param name="toValue">The end value</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetBetweenDetachedCriteria<T, V>(string fieldName, V fromValue, V toValue)
        {
            Logger.Info("Get " + typeof(T).ToString() + " between: start - " + fieldName + " => end -" + toValue);

            DetachedCriteria detachedCriteria = null;
            try
            {
                detachedCriteria = DetachedCriteria.For(typeof(T)).Add(Expression.Between(fieldName, fromValue, toValue));

                if (detachedCriteria == null)
                {
                    Logger.Error("Get " + typeof(T).ToString() + ". Property names to query are not provided");
                    throw new Exception("Constructing the query criteria have some error.");
                }
            }
            catch (Exception e)
            {
                Logger.Error("Get " + typeof(T).ToString() + ". Constructing the query criteria have some error.",e);
                throw;
            }

            return detachedCriteria;
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria 
        /// </summary>
        /// <typeparam name="T">The type of the object to get.</typeparam> 
        /// <typeparam name="V">The type of the parameter 'value'.</typeparam>
        /// <param name="columneNames">The name of the field to filter while retrieving the object.</param>
        /// <param name="value">The value of the field to filter while retrieving the object.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteriaGeneric<T, V>(string fieldName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(T))
                                                                 .Add(Expression.Eq(fieldName, value));

            return detachedCriteria;
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria 
        /// </summary>
        /// <typeparam name="T">The type of the object to get.</typeparam> 
        /// <typeparam name="V1">The type of the parameter of 'firsValue'.</typeparam>
        /// <typeparam name="V2">The type of the parameter of 'secondValue'.</typeparam>
        /// <param name="firstFieldName">The name of the first field to filter while retrieving the object.</param>
        /// <param name="firstValue">The value of the first field to filter while retrieving the object.</param>
        /// <param name="sencondFieldName">The name of the second field to filter while retrieving the object.</param>
        /// <param name="secondValue">The value of the second field to filter while retrieving the object.</param>
        /// <param name="logicOperator">The logical operator used for query.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteriaGeneric<T, V1, V2>(string firstFieldName, V1 firstValue, string sencondFieldName, V2 secondValue, LogicalOperator logicOperator)
        {
            DetachedCriteria detachedCriteria = null;
            switch (logicOperator)
            {
                case LogicalOperator.AND:
                    detachedCriteria = DetachedCriteria.For(typeof(T))
                                            .Add(Expression.And(Expression.Eq(firstFieldName, firstValue), Expression.Eq(sencondFieldName, secondValue)));
                    break;
                case LogicalOperator.OR:
                    detachedCriteria = DetachedCriteria.For(typeof(T))
                                            .Add(Expression.Or(Expression.Eq(firstFieldName, firstValue), Expression.Eq(sencondFieldName, secondValue)));
                    break;
                //case LogicalOperator.NOT:
                //    detachedCriteria = DetachedCriteria.For(typeof(T))
                //                            .Add(Expression.Not(Expression.Eq(firstFieldName, firstValue), Expression.Eq(sencondFieldName, secondValue)));
                default:
                    detachedCriteria = null;
                    break;
            }

            return detachedCriteria;
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria which filter on the field of the child object.
        /// </summary>
        /// <typeparam name="T">The type of the object to get.</typeparam> 
        /// <typeparam name="V">The type of the parameter 'value'.</typeparam>
        /// <param name="columneNames">The name of the field to filter while retrieving the object.</param>
        /// <param name="value">The value of the field to filter while retrieving the object.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteriaGeneric<T, V>(string fieldName, V value, string fullNameOfChildObj)
        {
            return DetachedCriteria.For(typeof(T))
                                        .CreateCriteria(fullNameOfChildObj)
                                        .Add(Expression.Eq(fieldName, value));
        }

        private ServiceOfDocDocStatusHistory GetServiceOfDocDocStatusHistory(string serviceOfDocDocStatusId)
        {
            IRepository<ServiceOfDocDocStatusHistory> serviceOfDocDocStatusHistoryRepository = new RepositoryImpl<ServiceOfDocDocStatusHistory>(applicationSession);
            return serviceOfDocDocStatusHistoryRepository.Get(serviceOfDocDocStatusId);
        }

        private ServiceOfDocInfo GetServiceOfDocInfo(string serviceOfDocInfoId)
        {
            IRepository<ServiceOfDocInfo> serviceOfDocInfoRepository = new RepositoryImpl<ServiceOfDocInfo>(applicationSession);
            return serviceOfDocInfoRepository.Get(serviceOfDocInfoId);
        }

        #endregion Methods
    }
}