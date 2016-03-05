namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using NHibernate;
    using NHibernate.Criterion;
    using log4net;

    internal class AdmiralityGateway
    {
        #region Fields

        private ISession applicationSession;

        private static readonly ILog Logger = LogManager.GetLogger(typeof(AdmiralityGateway));

        #endregion Fields

        #region Constructors

        internal AdmiralityGateway()
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

        internal ADMInfoEntity GetADMInfoEntity(string aDMInfoId)
        {
            ADMInfo aDMInfo = new ADMInfo();
            ADMInfoEntity aDMInfoEntity = new ADMInfoEntity();

            Criteria criteria = new Criteria("ADMInfoId", aDMInfoId);
            aDMInfo = GetADMInfo(criteria);
            aDMInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetADMInfoEntity(aDMInfo);
            return aDMInfoEntity;
        }

        internal ADMInfoEntity GetADMInfoEntityBySGID(string SGID)
        {
            ADMInfoEntity aDMInfoEntity = new ADMInfoEntity();

            IRepository<ADMInfo> aDMInfoRepository = new RepositoryImpl<ADMInfo>(applicationSession);

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ADMInfo))
                                                               .Add(Expression.Eq("SubmissionGroupId", SGID));
            List<ADMInfo> listADMInfo = aDMInfoRepository.GetAll(detachedCriteria) as List<ADMInfo>;
            if (listADMInfo != null && listADMInfo.Count > 0)
            {
                foreach (ADMInfo adMInfo in listADMInfo)
                {
                    aDMInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetADMInfoEntity(adMInfo);
                }
            }
            else
                aDMInfoEntity = null;
            return aDMInfoEntity;
        }

        internal List<RefCaveatCaseEntity> GetListRefCaveatCaseEntityBySGID(string SGID)
        {
            List<RefCaveatCaseEntity> listRefCaveatCaseEntity = new List<RefCaveatCaseEntity>();
            RefCaveatCaseEntity refCaveatCaseEntity = new RefCaveatCaseEntity();
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RefCaveatCase))
                                                                .Add(Expression.Eq("SubmissionGroupId", SGID));
            IRepository<RefCaveatCase> refCaveatCaseRepository = new RepositoryImpl<RefCaveatCase>(applicationSession);

            List<RefCaveatCase> listRefCaveatCase = refCaveatCaseRepository.GetAll(detachedCriteria) as List<RefCaveatCase>;
            if (listRefCaveatCase != null && listRefCaveatCase.Count > 0)
            {
                foreach (RefCaveatCase refCaveatCase in listRefCaveatCase)
                {
                    refCaveatCaseEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRefCaveatCaseEntity(refCaveatCase);
                    listRefCaveatCaseEntity.Add(refCaveatCaseEntity);
                }
            }
            return listRefCaveatCaseEntity;
        }

        internal RefCaveatCaseEntity GetRefCaveatCaseEntity(string aDMCavetNoId)
        {
            Criteria criteria = new Criteria("ADMCavetNoId", aDMCavetNoId);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRefCaveatCaseEntity(GetRefCaveatCaseEntity(criteria));
        }

        internal void SaveOrUpdateADMInfoEntity(ADMInfoEntity aDMInfoEntity)
        {
            IRepository<ADMInfo> iADMInfoRepository = new RepositoryImpl<ADMInfo>(applicationSession);
            iADMInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetAdmInfo(aDMInfoEntity));
        }

        internal void SaveOrUpdateRefCaveatCaseEntity(RefCaveatCaseEntity refCaveatCaseEntity)
        {
            IRepository<RefCaveatCase> refCaveatCaseRepository = new RepositoryImpl<RefCaveatCase>(applicationSession);
            refCaveatCaseRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefCaveatCase(refCaveatCaseEntity));
        }

        private ADMInfo GetADMInfo(Criteria criteria)
        {
            try
            {
                ADMInfo aDMInfo = new ADMInfo();

                IRepository<ADMInfo> iADMInfoRepository = new RepositoryImpl<ADMInfo>(applicationSession);
                aDMInfo = iADMInfoRepository.Get(criteria.Value);
                return aDMInfo;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetADMInfo", ex);
                throw;
            }
        }

        private RefCaveatCase GetRefCaveatCaseEntity(Criteria criteria)
        {
            IRepository<RefCaveatCase> refCaveatCaseRepository = new RepositoryImpl<RefCaveatCase>(applicationSession);
            return refCaveatCaseRepository.Get(criteria.Value);
        }

        #endregion Methods
    }
}