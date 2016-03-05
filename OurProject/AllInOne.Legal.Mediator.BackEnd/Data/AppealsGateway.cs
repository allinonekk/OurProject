namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain.CaseData;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.SubCaseData;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using NHibernate;
    using NHibernate.Criterion;

    internal class AppealsGateway
    {
        #region Fields

        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        internal AppealsGateway()
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

        internal void DeleteAppealsDataBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            commonGateway.DeleteRefOrderDetailList(submissionGroupId);
            commonGateway.DeleteNatureOfCaseList(submissionGroupId);
            commonGateway.DeleteLegislationProvisionsList(submissionGroupId);
            DeleteDCACAInfo(submissionGroupId);
        }

        internal void DeleteRegistrarsAppealsDataBySGID(string submissionGroupId)
        {
            CommonGateway commonGateway = new CommonGateway();
            SubCaseSpecificGateway subCaseSpecificGateway = new SubCaseSpecificGateway();

            commonGateway.DeleteNatureOfApplicationList(submissionGroupId);
            subCaseSpecificGateway.DeleteRARASInfo(submissionGroupId);
            commonGateway.DeleteRefOrderDetailList(submissionGroupId);
            commonGateway.DeleteOtherITMOList(submissionGroupId);
            commonGateway.DeleteNatureOfCaseList(submissionGroupId);
            commonGateway.DeleteLegislationProvisionsList(submissionGroupId);
        }

        internal AppealsData GetAppealsData(string SGID)
        {
            CommonGateway gateway = new CommonGateway();
            AppealsData appealsData = new AppealsData();
            appealsData.DCACAInfoEntity = this.GetDCACAInfoEntityBySGID(SGID);
            appealsData.ListLegislationProvisionsEntity = gateway.GetListLegislationProvisionsEntityBySGID(SGID);
            appealsData.ListNatureOfApplicationEntity = gateway.GetListNatureOfApplicationEntityBySGID(SGID);
            appealsData.ListNatureOfCaseEntity = gateway.GetListNatureOfCaseEntityBySGID(SGID);
            appealsData.ListRefOrderDetailEntity = gateway.GetListRefOrderDetailEntityBySGID(SGID);
            appealsData.ListOtherITMOEntity = gateway.GetListOtherITMOEntityBySGID(SGID);
            appealsData.ListAppealTimeEstimationDetailEntity = gateway.GetListAppealTimeEstimationDetailBySGID(SGID);

            return appealsData;
        }

        //internal DCACAInfoEntity GetDCACAInfoEntity(string dCACAInfoId)
        //{
        //    DCACAInfo dCACAInfo = new DCACAInfo();
        //    DCACAInfoEntity dCACAInfoEntity = new DCACAInfoEntity();
        //    Criteria criteria = new Criteria("DCACAInfoId", dCACAInfoId);
        //    dCACAInfo = GetDCACAInfo(criteria);
        //    dCACAInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetDCACAInfoEntity(dCACAInfo);
        //    return dCACAInfoEntity;
        //}
        internal DCACAInfoEntity GetDCACAInfoEntityBySGID(string SGID)
        {
            DCACAInfoEntity dCACAInfoEntity = new DCACAInfoEntity();
            DCACAInfo dCACAInfo = new DCACAInfo();
            IRepository<DCACAInfo> dCACAInfoRepository = new RepositoryImpl<DCACAInfo>(applicationSession);

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DCACAInfo))
                                                               .Add(Expression.Eq("SubmissionGroupId", SGID));
            List<DCACAInfo> listDCACAInfo = dCACAInfoRepository.GetAll(detachedCriteria) as List<DCACAInfo>;
            if (listDCACAInfo != null && listDCACAInfo.Count > 0)
            {
                foreach (DCACAInfo dcACAInfo in listDCACAInfo)
                {
                    dCACAInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetDCACAInfoEntity(dcACAInfo);

                }
            }
            else
                dCACAInfoEntity = null;
            return dCACAInfoEntity;
        }

        //internal RARASInfoEntity GetRARASInfoEntity(string rARASInfoId)
        //{
        //    RARASInfo rARASInfo = new RARASInfo();
        //    RARASInfoEntity rARASInfoEntity = new RARASInfoEntity();
        //    Criteria criteria = new Criteria("RARASInfoId", rARASInfoId);
        //    rARASInfo = GerRARASInfo(criteria);
        //    rARASInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetRARAInfoEntity(rARASInfo);
        //    return rARASInfoEntity;
        //}
        internal RARASInfoEntity GetRARASInfoEntityBySGID(string SGID)
        {
            RARASInfoEntity rARASInfoEntity = new RARASInfoEntity();

            IRepository<RARASInfo> rARASInfoRepository = new RepositoryImpl<RARASInfo>(applicationSession);

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RARASInfo))
                                                               .Add(Expression.Eq("SubmissionGroupId", SGID));
            List<RARASInfo> listRARASInfo = rARASInfoRepository.GetAll(detachedCriteria) as List<RARASInfo>;
            if (listRARASInfo != null && listRARASInfo.Count > 0)
            {
                foreach (RARASInfo raRASInfo in listRARASInfo)
                {
                    rARASInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetRARAInfoEntity(raRASInfo);
                }
            }
            else
                rARASInfoEntity = null;
            return rARASInfoEntity;
        }

        internal void SaveOrUpdateAppealsData(AppealsData appealsData)
        {
            CommonGateway gateway = new CommonGateway();
            SaveOrUpdateDCACAInfoEntity(appealsData.DCACAInfoEntity);
            SaveorUpdateListRefOrderDetails(appealsData.ListRefOrderDetailEntity);
            gateway.SaveOrUpdateLegislationProvisionsList(appealsData.ListLegislationProvisionsEntity);
            gateway.SaveOrUpdateNatureOfCaseList(appealsData.ListNatureOfCaseEntity);
            gateway.SaveOrUpdateRefOrderDetailList(appealsData.ListRefOrderDetailEntity);
        }

        internal void SaveOrUpdateCopyAppealsData(AppealsData appealsData)
        {
            CommonGateway gateway = new CommonGateway();
            SaveOrUpdateCopyDCACAInfoEntity(appealsData.DCACAInfoEntity);
            SaveorUpdateCopyListRefOrderDetails(appealsData.ListRefOrderDetailEntity);
            SaveOrUpdateCopyLegislationProvisionsList(appealsData.ListLegislationProvisionsEntity);
            SaveOrUpdateCopyNatureOfCaseList(appealsData.ListNatureOfCaseEntity);
        }

        internal void SaveOrUpdateCopyDCACAInfoEntity(DCACAInfoEntity dCACAInfoEntity)
        {
            IRepository<DCACAInfo> dCACAInfoRepository = new RepositoryImpl<DCACAInfo>(applicationSession);

            dCACAInfoRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.AppealsMapper.GetDCACAInfoEntity(dCACAInfoEntity));
        }

        internal void SaveorUpdateCopyListRefOrderDetails(List<RefOrderDetailEntity> listRefOrderDetail)
        {
            CommonGateway gateway = new CommonGateway();
            if (listRefOrderDetail != null && listRefOrderDetail.Count > 0)
            {
                foreach (RefOrderDetailEntity refOrderDetail in listRefOrderDetail)
                {
                    gateway.SaveOrUpdateCopyRefOrderDetailEntity(refOrderDetail);
                }
            }
        }

        //internal void SaveOrUpdateCopyRARASInfoEntity(RARASInfoEntity rARASInfoEntity)
        //{
        //    if (rARASInfoEntity != null)
        //    {
        //        IRepository<RARASInfo> rARASInfoRepository = new RepositoryImpl<RARASInfo>(applicationSession);
        //        rARASInfoRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.AppealsMapper.GetRARASInfoEntity(rARASInfoEntity));
        //    }
        //}
        internal void SaveOrUpdateDCACAInfoEntity(DCACAInfoEntity dCACAInfoEntity)
        {
            IRepository<DCACAInfo> dCACAInfoRepository = new RepositoryImpl<DCACAInfo>(applicationSession);

            dCACAInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.AppealsMapper.GetDCACAInfoEntity(dCACAInfoEntity));
        }

        internal void SaveorUpdateListRefOrderDetails(List<RefOrderDetailEntity> listRefOrderDetail)
        {
            CommonGateway gateway = new CommonGateway();
            if (listRefOrderDetail != null && listRefOrderDetail.Count > 0)
            {
                foreach (RefOrderDetailEntity refOrderDetail in listRefOrderDetail)
                {
                    gateway.SaveOrUpdateRefOrderDetailEntity(refOrderDetail);
                }
            }
        }

        internal void SaveOrUpdateRARASInfoEntity(RARASInfoEntity rARASInfoEntity)
        {
            if (rARASInfoEntity != null)
            {
                IRepository<RARASInfo> rARASInfoRepository = new RepositoryImpl<RARASInfo>(applicationSession);

                rARASInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.AppealsMapper.GetRARASInfoEntity(rARASInfoEntity));
            }
        }

        private void DeleteDCACAInfo(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DCACAInfo>()
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<DCACAInfo> listDCACAInfo = GetFromDetachedCriteria<DCACAInfo>(detachedCriteria);
            if (listDCACAInfo != null && listDCACAInfo.Count > 0)
            {
                Repository<DCACAInfo>().DeleteAll(listDCACAInfo);
            }
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

        //private RARASInfo GerRARASInfo(Criteria criteria)
        //{
        //    try
        //    {
        //        RARASInfo rARASInfo = new RARASInfo();
        //        IRepository<RARASInfo> rARASInfoRepository = new RepositoryImpl<RARASInfo>(applicationSession);
        //        rARASInfo = rARASInfoRepository.Get(criteria.Value);
        //        return rARASInfo;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
        //private DCACAInfo GetDCACAInfo(Criteria criteria)
        //{
        //    try
        //    {
        //        DCACAInfo dCACAInfo = new DCACAInfo();
        //        IRepository<DCACAInfo> dCACAInfoRepository = new RepositoryImpl<DCACAInfo>(applicationSession);
        //        dCACAInfo = dCACAInfoRepository.Get(criteria.Value);
        //        return dCACAInfo;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
        private void SaveOrUpdateCopyLegislationProvisionsList(List<LegislationProvisionsEntity> listLegislationProvisionsEntity)
        {
            IRepository<LegislationProvision> legislationProvisionRepository = new RepositoryImpl<LegislationProvision>(applicationSession);
            if (listLegislationProvisionsEntity != null && listLegislationProvisionsEntity.Count > 0)
            {
                foreach (LegislationProvisionsEntity legislationProvisionsEntity in listLegislationProvisionsEntity)
                {
                    legislationProvisionRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegislationProvision(legislationProvisionsEntity));

                }
            }
        }

        private void SaveOrUpdateCopyNatureOfCaseList(List<NatureOfCaseEntity> listNatureOfCaseEntity)
        {
            IRepository<NatureOfCase> natureOfCaseEntityRepository = new RepositoryImpl<NatureOfCase>(applicationSession);
            if (listNatureOfCaseEntity != null && listNatureOfCaseEntity.Count > 0)
            {
                foreach (NatureOfCaseEntity natureOfCaseEntity in listNatureOfCaseEntity)
                {
                    natureOfCaseEntityRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCase(natureOfCaseEntity));

                }
            }
        }

        #endregion Methods
    }
}