namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain.CaseData;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using NHibernate;
    using NHibernate.Criterion;

    internal class BankruptcyGateway
    {
        #region Fields

        ISession applicationSession;

        #endregion Fields

        #region Constructors

        internal BankruptcyGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

            //MappingToDTO nHibernateToDomainMapping = new MappingToDTO();
            //nHibernateToDomainMapping.MapAll();

            //MappingToDomain domainToNHibernateMapping = new MappingToDomain();
            //domainToNHibernateMapping.MapAll();
        }

        #endregion Constructors

        #region Methods

        internal BankruptcyData GetBankruptcyDataBySGID(string submissionGroupId)
        {
            BankruptcyData bankruptcyData = new BankruptcyData();
            CommonGateway commongateway = new CommonGateway();
            bankruptcyData.BankruptcyInfoEntity = GetBankruptcyInfoBySGID(submissionGroupId);
            bankruptcyData.ListBankruptcyOtherDefDetailEntity = GetListBankruptcyOtherDefDetailBySGID(submissionGroupId);
            bankruptcyData.ListLegislationProvisionsEntity = commongateway.GetListLegislationProvisionsEntityBySGID(submissionGroupId);
            bankruptcyData.ListNatureOfCaseEntity = commongateway.GetListNatureOfCaseEntityBySGID(submissionGroupId);
            bankruptcyData.ListOtherITMOEntity = commongateway.GetListOtherITMOEntityBySGID(submissionGroupId);
            bankruptcyData.ListPrayerEntity = commongateway.GetListPrayerEntityBySGID(submissionGroupId);

            return bankruptcyData;
        }

        internal BankruptcyInfoEntity GetBankruptcyInfoBySGID(string submissionGroupId)
        {
            BankruptcyInfoEntity bankruptcyInfoEntity = new BankruptcyInfoEntity();
            IRepository<BankruptcyInfo> bankruptcyInfoRepository = new RepositoryImpl<BankruptcyInfo>(applicationSession);
            List<BankruptcyInfo> listBankruptcyInfo = new List<BankruptcyInfo>();
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BankruptcyInfo))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            listBankruptcyInfo = bankruptcyInfoRepository.GetAll(detachedCriteria) as List<BankruptcyInfo>;

            if (listBankruptcyInfo != null && listBankruptcyInfo.Count > 0)
            {
                foreach (BankruptcyInfo bankruptcyInfo in listBankruptcyInfo)
                {
                    bankruptcyInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetBankruptcyInfoEntity(bankruptcyInfo);
                }

            }
            else
                bankruptcyInfoEntity = null;
            return bankruptcyInfoEntity;
        }

        //internal BankruptcyInfoEntity GetBankruptcyInfoEntity(string bankruptcyInfoId)
        //{
        //    BankruptcyInfo bankruptcyInfo = new BankruptcyInfo();
        //    BankruptcyInfoEntity bankruptcyInfoEntity = new BankruptcyInfoEntity();
        //    Criteria criteria = new Criteria("BankruptcyInfoId", bankruptcyInfoId);
        //    bankruptcyInfo = GetBankruptcyInfo(criteria);
        //    bankruptcyInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetBankruptcyInfoEntity(bankruptcyInfo);
        //    return bankruptcyInfoEntity;
        //}
        //internal BankruptcyOtherDefDetailEntity GetBankruptcyOtherDefDetailEntity(string OtherDefendantId)
        //{
        //    BankruptcyOtherDefDetail bankruptcyOtherDefDetail = new BankruptcyOtherDefDetail();
        //    BankruptcyOtherDefDetailEntity bankruptcyOtherDefDetailEntity = new BankruptcyOtherDefDetailEntity();
        //    Criteria criteria = new Criteria("OtherDefendantId", OtherDefendantId);
        //    bankruptcyOtherDefDetail = GetBankruptcyOtherDefDetail(criteria);
        //    bankruptcyOtherDefDetailEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetBankruptcyOtherDefDetailEntity(bankruptcyOtherDefDetail);
        //    return bankruptcyOtherDefDetailEntity;
        //}
        internal List<BankruptcyOtherDefDetailEntity> GetListBankruptcyOtherDefDetailBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BankruptcyOtherDefDetail))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<BankruptcyOtherDefDetail> listBankruptcyOtherDefDetail = GetAllBankruptcyOtherDefDetail(detachedCriteria);

            if (listBankruptcyOtherDefDetail != null && listBankruptcyOtherDefDetail.Count > 0)
            {
                return listBankruptcyOtherDefDetail.Select(bankruptcyOtherDefDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetBankruptcyOtherDefDetailEntity(bankruptcyOtherDefDetail)).ToList();

            }
            else
            {
                return null;
            }
        }

        internal void SaveOrUpdateBankruptcyData(BankruptcyData bankruptcyData)
        {
            SaveOrUpdateBankruptcyInfoEntity(bankruptcyData.BankruptcyInfoEntity);
            SaveOrUpdateListBankruptcyOtherDefDetail(bankruptcyData.ListBankruptcyOtherDefDetailEntity);
            //SaveOrUpdateListNoOfSupportingDoc(bankruptcyData.ListNoOfSupportingDocEntity);
        }

        internal void SaveOrUpdateBankruptcyInfoEntity(BankruptcyInfoEntity bankruptcyInfoEntity)
        {
            IRepository<BankruptcyInfo> bankruptcyInfoRepository = new RepositoryImpl<BankruptcyInfo>(applicationSession);
            bankruptcyInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.BankruptcyMapper.GetBankruptcyInfo(bankruptcyInfoEntity));
        }

        internal void SaveOrUpdateBankruptcyOtherDefDetailEntity(BankruptcyOtherDefDetailEntity bankruptcyOtherDefDetailEntity)
        {
            IRepository<BankruptcyOtherDefDetail> bankruptcyOtherDefDetailRepository = new RepositoryImpl<BankruptcyOtherDefDetail>(applicationSession);
            bankruptcyOtherDefDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.BankruptcyMapper.GetBankruptcyOtherDefDetail(bankruptcyOtherDefDetailEntity));
        }

        private List<BankruptcyOtherDefDetail> GetAllBankruptcyOtherDefDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<BankruptcyOtherDefDetail> bankruptcyOtherDefDetailRepository = new RepositoryImpl<BankruptcyOtherDefDetail>(applicationSession);
            return bankruptcyOtherDefDetailRepository.GetAll(detachedCriteria) as List<BankruptcyOtherDefDetail>;
        }

        //private BankruptcyInfo GetBankruptcyInfo(Criteria criteria)
        //{
        //    BankruptcyInfo bankruptcyInfo = new BankruptcyInfo();
        //    IRepository<BankruptcyInfo> bankruptcyInfoRepository = new RepositoryImpl<BankruptcyInfo>(applicationSession);
        //    bankruptcyInfo = bankruptcyInfoRepository.Get(criteria.Value);
        //    return bankruptcyInfo;
        //}
        //private BankruptcyInfo GetBankruptcyInfo(DetachedCriteria detachedCriteria)
        //{
        //    BankruptcyInfo bankruptcyInfo = new BankruptcyInfo();
        //    List<BankruptcyInfo> listBankruptcyInfo = new List<BankruptcyInfo>();
        //    IRepository<BankruptcyInfo> bankruptcyInfoRepository = new RepositoryImpl<BankruptcyInfo>(applicationSession);
        //    listBankruptcyInfo = bankruptcyInfoRepository.GetAll(detachedCriteria)as List<BankruptcyInfo>;
        //    foreach (BankruptcyInfo bankruptcy in listBankruptcyInfo)
        //    {
        //        bankruptcyInfo = bankruptcy;
        //    }
        //    return bankruptcyInfo;
        //}
        //private BankruptcyOtherDefDetail GetBankruptcyOtherDefDetail(Criteria criteria)
        //{
        //    BankruptcyOtherDefDetail bankruptcyOtherDefDetail = new BankruptcyOtherDefDetail();
        //    IRepository<BankruptcyOtherDefDetail> bankruptcyOtherDefDetailRepository = new RepositoryImpl<BankruptcyOtherDefDetail>(applicationSession);
        //    bankruptcyOtherDefDetail = bankruptcyOtherDefDetailRepository.Get(criteria.Value);
        //    return bankruptcyOtherDefDetail;
        //}
        private void SaveOrUpdateListBankruptcyOtherDefDetail(List<BankruptcyOtherDefDetailEntity> listBankruptcyOtherDefDetail)
        {
            if (listBankruptcyOtherDefDetail != null && listBankruptcyOtherDefDetail.Count > 0)
            {
                foreach (BankruptcyOtherDefDetailEntity bankruptcyOtherDefDetailEntity in listBankruptcyOtherDefDetail)
                {
                    SaveOrUpdateBankruptcyOtherDefDetailEntity(bankruptcyOtherDefDetailEntity);
                }
            }
        }

        #endregion Methods

        #region Other

        //private void SaveOrUpdateListNoOfSupportingDoc(List<NoOfSupportingDocEntity> listNoOfSupportingDoc)
        //{
        //    CommonGateway gateway = new CommonGateway();
        //    if (listNoOfSupportingDoc != null && listNoOfSupportingDoc.Count > 0)
        //    {
        //        foreach (NoOfSupportingDocEntity noOfSupportingDocEntity in listNoOfSupportingDoc)
        //        {
        //            gateway.SaveOrUpdateNoOfSupportingDocEntity(noOfSupportingDocEntity);
        //        }
        //    }
        //}

        #endregion Other
    }
}