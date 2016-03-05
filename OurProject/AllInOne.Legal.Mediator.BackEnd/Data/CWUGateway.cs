namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using NHibernate;
    using NHibernate.Criterion;

    internal class CWUGateway
    {
        #region Fields

        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        internal CWUGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

            //MappingToDTO nHibernateToDomainMapping = new MappingToDTO();
            //nHibernateToDomainMapping.MapAll();

            //MappingToDomain domainToNHibernate = new MappingToDomain();
            //domainToNHibernate.MapAll();
        }

        #endregion Constructors

        #region Methods

        internal void DeleteCWUInfo(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CWUInfo>()
                 .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<CWUInfo> listCWUInfo = GetFromDetachedCriteria<CWUInfo>(detachedCriteria);
            if (listCWUInfo != null && listCWUInfo.Count > 0)
            {
                Repository<CWUInfo>().DeleteAll(listCWUInfo);
            }
        }

        internal CWUInfoEntity GetCWUInfoByPK(string cWUInfoId)
        {
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetCWUInfoEntity(GetCWUInfo(cWUInfoId));
        }

        internal CWUInfoEntity GetCWUInfoBySGID(string SGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CWUInfo))
                                                             .Add(Expression.Eq("SubmissionGroupId", SGID));
            CWUInfoEntity cWUInfoEntity = new CWUInfoEntity();
            CWUInfo cWUInfo = new CWUInfo();
            IRepository<CWUInfo> cWUInfoRepository = new RepositoryImpl<CWUInfo>(applicationSession);
            List<CWUInfo> listCWUInfo = cWUInfoRepository.GetAll(detachedCriteria) as List<CWUInfo>;
            if (listCWUInfo != null && listCWUInfo.Count > 0)
            {
                foreach (CWUInfo cwUInfo in listCWUInfo)
                {
                    cWUInfo = cwUInfo;
                    cWUInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetCWUInfoEntity(cWUInfo);
                }
            }
            else
                cWUInfoEntity = null;
            return cWUInfoEntity;
        }

        internal void SaveOrUpdateCWUInfoEntity(CWUInfoEntity cWUInfoEntity)
        {
            IRepository<CWUInfo> cWUInfoRepository = new RepositoryImpl<CWUInfo>(applicationSession);
            cWUInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CWUMapper.GetCWUInfo(cWUInfoEntity));
        }

        private CWUInfo GetCWUInfo(string cWUInfoId)
        {
            IRepository<CWUInfo> cWUInfoRepository = new RepositoryImpl<CWUInfo>(applicationSession);
            return cWUInfoRepository.Get(cWUInfoId);
        }

        private List<T> GetFromDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll(detachedCriteria).ToList();
        }

        /// <summary>
        /// Gets the repository.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private IRepository<T> Repository<T>()
        {
            return new RepositoryImpl<T>(applicationSession);
        }

        #endregion Methods
    }
}