namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    internal class CaseGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CaseGateway));

        private ISession applicationSession;

        /// <summary>
        /// Save CasePartyData.
        /// </summary>
        /// <param name="iCaseParty">The case party data.</param>
        /// <returns></returns> 
        private object casePartyDataLock = new object();
        private object isCopyCasePartyLock = new object();

        #endregion Fields

        #region Constructors

        internal CaseGateway()
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

        internal void DeleteCaseInfoByPK(string caseInfoId)
        {
            CaseInfo caseInfo = new CaseInfo { CaseInfoId = Convert.ToInt64(caseInfoId) };
            IRepository<CaseInfo> repository = new RepositoryImpl<CaseInfo>(applicationSession);
            repository.Delete(caseInfo);
        }

        internal void DeleteCaseOriginatingCaseByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseOriginatingCase)).Add(Expression.Eq("CaseInfoId", caseInfoId));
            this.DeleteCaseOriginatingCase(detachedCriteria);
        }

        internal void DeleteCaseOriginatingCaseList(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseOriginatingCase>()
                    .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            Repository<CaseOriginatingCase>().DeleteAll(detachedCriteria);
        }

        internal void DeleteCasePartyAddressList(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CasePartyAddress>()
                .Add(Expression.Eq("CasePartyId", casePartyId));
            List<CasePartyAddress> listCasePartyAddress = GetFromDetachedCriteria<CasePartyAddress>(detachedCriteria);
            if (listCasePartyAddress != null && listCasePartyAddress.Count > 0)
            {
                Repository<CasePartyAddress>().DeleteAll(listCasePartyAddress);
            }
        }

        internal void DeleteCasePartyAICAddressEntity(string aICID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyAICAddress))
                                                                             .Add(Expression.Eq("AICID", aICID));

            this.DeleteCasePartyAICAddress(detachedCriteria);
        }

        internal void DeleteCasePartyAICAddressList(string aICID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CasePartyAICAddress>()
                 .Add(Expression.Eq("AICID", aICID));
            Repository<CasePartyAICAddress>().DeleteAll(detachedCriteria);
        }

        internal void DeleteCasePartyAICAddressListByCasePartyId(string casePartyId)
        {
            var subCriteria = DetachedCriteria.For(typeof(CasePartyAICDetail));
            subCriteria.SetProjection(Projections.Property("AICID")).Add(Expression.Eq("CasePartyId", casePartyId));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(CasePartyAICAddress)).Add(Subqueries.PropertyIn("AICID", subCriteria));

            IRepository<CasePartyAICAddress> casePartyAICAddressRepository = new RepositoryImpl<CasePartyAICAddress>(applicationSession);
            List<CasePartyAICAddress> listCasePartyAICAddress = casePartyAICAddressRepository.FindAll(iCriterion).ToList();
            casePartyAICAddressRepository.DeleteAll(listCasePartyAICAddress);
        }

        internal void DeleteCasePartyAICAliasByCasePartyId(string casePartyId)
        {
            var subCriteria = DetachedCriteria.For(typeof(CasePartyAICDetail));
            subCriteria.SetProjection(Projections.Property("AICID")).Add(Expression.Eq("CasePartyId", casePartyId));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(CasePartyAICAlias)).Add(Subqueries.PropertyIn("AICID", subCriteria));

            IRepository<CasePartyAICAlias> casePartyAICAliasRepository = new RepositoryImpl<CasePartyAICAlias>(applicationSession);
            List<CasePartyAICAlias> listCasePartyAICAlias = casePartyAICAliasRepository.FindAll(iCriterion).ToList();
            casePartyAICAliasRepository.DeleteAll(listCasePartyAICAlias);
        }

        internal void DeleteCasePartyAICAliasEntity(string aICID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyAICAlias))
                                                                             .Add(Expression.Eq("AICID", aICID));

            this.DeleteCasePartyAICAlias(detachedCriteria);
        }

        internal void DeleteCasePartyAICAliasList(string aICID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CasePartyAICAlias>()
                  .Add(Expression.Eq("AICID", aICID));
            Repository<CasePartyAICAlias>().DeleteAll(detachedCriteria);
        }

        internal void DeleteCasePartyAICDetailsList(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CasePartyAICDetail>()
                .Add(Expression.Eq("CasePartyId", casePartyId));
            Repository<CasePartyAICDetail>().DeleteAll(detachedCriteria);
        }

        internal void DeleteCasePartyAliasList(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CasePartyAlias>()
                 .Add(Expression.Eq("CasePartyId", casePartyId));
            Repository<CasePartyAlias>().DeleteAll(detachedCriteria);
        }

        internal void DeleteCasePartyAuthorisedOfficerDetailsList(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CasePartyAuthorisedOfficerDetail>()
                 .Add(Expression.Eq("CasePartyId", casePartyId));
            Repository<CasePartyAuthorisedOfficerDetail>().DeleteAll(detachedCriteria);
        }

        internal void DeleteCasePartyBailorAddressByCasePartyId(string casePartyId)
        {
            IRepository<CasePartyBailorAddress> casePartyBailorAddressRepository = new RepositoryImpl<CasePartyBailorAddress>(applicationSession);
            List<CasePartyBailorAddress> listCasePartyBailorAddress = GetListCasePartyBailorAddressByCasePartyId(casePartyId);

            if ((listCasePartyBailorAddress != null) && (listCasePartyBailorAddress.Count > 0))
                casePartyBailorAddressRepository.DeleteAll(listCasePartyBailorAddress);
        }

        internal void DeleteCasePartyBailorInfoByCasePartyId(string casePartyId)
        {
            IRepository<CasePartyBailorInfo> casePartyBailorInfoRepository = new RepositoryImpl<CasePartyBailorInfo>(applicationSession);
            List<CasePartyBailorInfo> listCasePartyBailorInfo = GetListCasePartyBailorInfoByCasePartyId(casePartyId);

            if ((listCasePartyBailorInfo != null) && (listCasePartyBailorInfo.Count > 0))
            {
                foreach (CasePartyBailorInfo objCasePartyBailorInfo in listCasePartyBailorInfo)
                {
                    IRepository<CasePartyBailorAddress> casePartyBailorAddressRepository = new RepositoryImpl<CasePartyBailorAddress>(applicationSession);
                    string bailorinfoid = objCasePartyBailorInfo.CasePartyBailorInfoId.ToString();
                    List<CasePartyBailorAddress> listCasePartyBailorAddress = GetListCasePartyBailorAddressByCasePartyBailorInfoId(bailorinfoid);
                    if ((listCasePartyBailorAddress != null) && (listCasePartyBailorAddress.Count > 0))
                        casePartyBailorAddressRepository.DeleteAll(listCasePartyBailorAddress);
                }
            }
            

            if ((listCasePartyBailorInfo != null) && (listCasePartyBailorInfo.Count > 0))
                casePartyBailorInfoRepository.DeleteAll(listCasePartyBailorInfo);
        }

        internal void DeleteCasePartyByPK(string casePartyId)
        {
            IRepository<CaseParty> casePartyRepository = new RepositoryImpl<CaseParty>(applicationSession);
            casePartyRepository.Delete(casePartyRepository.Get(casePartyId));
        }

        internal void DeleteCasepartyCitizenship(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CasePartyCitizenship>()
                         .Add(Expression.Eq("CasePartyId", casePartyId));
            Repository<CasePartyCitizenship>().DeleteAll(detachedCriteria);
        }

        internal void DeleteCasePartyCriminalInfoByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CasePartyCriminalInfo>()
                .Add(Expression.Eq("CasePartyId", casePartyId));

            Repository<CasePartyCriminalInfo>().DeleteAll(detachedCriteria);

        }

        internal void DeleteCasePartyData(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyVesselDetail))
                                                                   .Add(Expression.Eq("CasePartyId", casePartyId));
            this.DeleteCasePartyVesselDetail(detachedCriteria);

            detachedCriteria = DetachedCriteria.For(typeof(CasePartyAuthorisedOfficerDetailsEntity))
                                                                   .Add(Expression.Eq("CasePartyId", casePartyId));
            this.DeleteCasePartyAuthorisedOfficerDetail(detachedCriteria);

            detachedCriteria = DetachedCriteria.For(typeof(CasePartyAlias))
                                                                  .Add(Expression.Eq("CasePartyId", casePartyId));
            this.DeleteCasePartyAlias(detachedCriteria);

            detachedCriteria = DetachedCriteria.For(typeof(CasePartyAddress))
                                                                  .Add(Expression.Eq("CasePartyId", casePartyId));
            this.DeleteCasePartyAddress(detachedCriteria);

            detachedCriteria = DetachedCriteria.For(typeof(CaseSolicitor))
                                                                  .Add(Expression.Eq("CasePartyId", casePartyId));
            this.DeleteCaseSolicitor(detachedCriteria);

            detachedCriteria = DetachedCriteria.For(typeof(CasePartyAICDetail))
                                                                  .Add(Expression.Eq("CasePartyId", casePartyId));
            this.DeleteCasePartyAICDetail(detachedCriteria);

            detachedCriteria = DetachedCriteria.For(typeof(CasePartyCitizenship))
                                                                 .Add(Expression.Eq("CasePartyId", casePartyId));
            this.DeleteCasePartyCitizenship(detachedCriteria);

            this.DeleteCasePartyCriminalInfoByCasePartyId(casePartyId);
            this.DeleteCasePartyBailorInfoByCasePartyId(casePartyId);
            this.DeleteCasePartyBailorAddressByCasePartyId(casePartyId);
        }

        internal void DeleteCasePartyDataList(string caseInfoId)
        {
            //DeleteCasePartyLACDetail(caseInfoId);
            DeleteCaseSolicitor(caseInfoId);
            //DeleteCasePartyVesselDetail(caseInfoId);
            //DeleteCasePartyAuthorisedOfficerDetailsListByCaseInfoId(caseInfoId);
            //DeleteCasePartyAICAliasListByCaseInfoId(caseInfoId);
            //DeleteCasePartyAICAddressListByCaseInfoId(caseInfoId);
            //DeleteCasePartyAICDetailsListByCaseInfoId(caseInfoId);
            //DeleteCasePartyAliasListByCaseInfoId(caseInfoId);
            //DeleteCasePartyAddressListByCaseInfoId(caseInfoId);
            DeleteCaseParty(caseInfoId);
        }

        internal void DeleteCasePartyLACDetail(string casePartyId)
        {
            if (!string.IsNullOrEmpty(casePartyId))
            {
                CaseParty caseParty = new CaseParty { CasePartyId = casePartyId };
                DetachedCriteria detachedCriteria = DetachedCriteria.For<CasePartyLACDetail>()
                          .Add(Expression.Eq("CaseParty", caseParty));
                Repository<CasePartyLACDetail>().DeleteAll(detachedCriteria);
            }
        }

        internal void DeleteCasePartyList(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseParty>()
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            List<CaseParty> listCaseParty = GetFromDetachedCriteria<CaseParty>(detachedCriteria);
            if (listCaseParty != null && listCaseParty.Count > 0)
            {
                Repository<CaseParty>().DeleteAll(listCaseParty);
            }
        }

        internal void DeleteCasePartyVesselDetail(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CasePartyVesselDetail>()
                   .Add(Expression.Eq("CasePartyId", casePartyId));
            Repository<CasePartyVesselDetail>().DeleteAll(detachedCriteria);
        }

        internal void DeleteCaseSolicitorHistoryList(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseSolicitorHistory>()
                   .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            Repository<CaseSolicitorHistory>().DeleteAll(detachedCriteria);
        }

        internal void DeleteCaseSolicitorList(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseSolicitor>()
                    .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            Repository<CaseSolicitor>().DeleteAll(detachedCriteria);
        }

        internal void DeleteCaseSolicitorListByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseSolicitor>()
                        .Add(Expression.Eq("CasePartyId", casePartyId));
            Repository<CaseSolicitor>().DeleteAll(detachedCriteria);
        }

        internal void DeleteDocumentInfoList(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DocumentInfo>()
                      .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            Repository<DocumentInfo>().DeleteAll(detachedCriteria);
        }

        internal int DeleteEntity<T, V>(Type iCase, string fieldName, V value)
        {
            List<T> listEntityToDelete = this.GetEntity<T, V>(iCase, fieldName, value, false);
            if (listEntityToDelete.Count > 0)
            {
                IRepository<T> iEnforcementRepository = new RepositoryImpl<T>(applicationSession);
                iEnforcementRepository.DeleteAll(listEntityToDelete);
            }
            return listEntityToDelete.Count;
        }

        internal void DeleteLawFirmCaseFileRefNumberList(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<LawFirmCaseFileRefNumber>()
                   .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            Repository<LawFirmCaseFileRefNumber>().DeleteAll(detachedCriteria);
        }

        internal void DeleteOriginatingCaseList(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<OriginatingCase>()
                     .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            Repository<OriginatingCase>().DeleteAll(detachedCriteria);
        }

        internal void DeleteOSPDRelation(string caseInfoId, string dcpId)
        {
            var subCriteria = DetachedCriteria.For(typeof(DocCaseParty));
            subCriteria.SetProjection(Projections.Property("DCPID")).Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                                                                     .Add(Expression.Eq("DCPID", dcpId));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(OSPDRelation)).Add(Subqueries.PropertyIn("DocCaseParty.DCPID", subCriteria));

            IRepository<OSPDRelation> oSPDRelationRepository = new RepositoryImpl<OSPDRelation>(applicationSession);
            List<OSPDRelation> listOSPDRelation = oSPDRelationRepository.FindAll(iCriterion).ToList();
            oSPDRelationRepository.DeleteAll(listOSPDRelation);
        }

        internal void DeletePADeedRoles(string caseInfoId, string dcpId)
        {
            var subCriteria = DetachedCriteria.For(typeof(DocCaseParty));
            subCriteria.SetProjection(Projections.Property("DCPID")).Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                                                                     .Add(Expression.Eq("DCPID", dcpId));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(PADeedRole)).Add(Subqueries.PropertyIn("DocCaseParty.DCPID", subCriteria));

            IRepository<PADeedRole> pADeedRolesRepository = new RepositoryImpl<PADeedRole>(applicationSession);
            List<PADeedRole> listPADeedRoles = pADeedRolesRepository.FindAll(iCriterion).ToList();
            pADeedRolesRepository.DeleteAll(listPADeedRoles);
        }

        internal void DeleteRCaseLawFirmList(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RCaseLawFirm>()
                    .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            Repository<RCaseLawFirm>().DeleteAll(detachedCriteria);
        }

        internal void DeleteRCaseSubmissionList(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RCaseSubmission>()
                    .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            Repository<RCaseSubmission>().DeleteAll(detachedCriteria);
        }

        internal void DeleteRSubCaseSubmissionList(string subCaseInfoId, string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RSubCaseSubmission>()
                      .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(subCaseInfoId)))
                      .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            Repository<RSubCaseSubmission>().DeleteAll(detachedCriteria);
        }

        internal void DeleteSubCasePartyList(string caseInoId, string subCaseInfoId, string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<SubCaseParty>()
                      .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(subCaseInfoId)))
                      .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInoId)))
                      .Add(Expression.Eq("CasePartyId", casePartyId));
            Repository<RSubCaseSubmission>().DeleteAll(detachedCriteria);
        }

        /// <summary>
        /// Passes the CaseInfoId andGets the caseInfo
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        internal CaseInfoEntity GetCaseInfoByPK(String caseInfoId)
        {
            CaseInfo caseInfo = GetCaseInfo(caseInfoId);
            applicationSession.Evict(caseInfo);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseInfoEntity(caseInfo);
        }

        internal List<CaseIssueListEntity> GetCaseIssueListByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseIssueList))
                                                                             .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<CaseIssueList> listCaseIssueList = GetFromDetachedCriteria<CaseIssueList>(detachedCriteria);

            if (listCaseIssueList != null && listCaseIssueList.Count > 0)
            {
                return listCaseIssueList.Select(caseIssueList => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseIssueListEntity(caseIssueList)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the primary key and get the CasePartyAddressEntity.
        /// </summary>
        /// <param name="RecId">The primary key.</param>
        /// <returns></returns>
        internal CasePartyAddressEntity GetCasePartyAddress(String primaryKey)
        {
            IRepository<CasePartyAddress> casePartyAddressRepository = new RepositoryImpl<CasePartyAddress>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyAddressEntity(casePartyAddressRepository.Get(primaryKey));
        }

        /// <summary>
        /// Passes the RecId and get the CasePartyAICAddress.
        /// </summary>
        /// <param name="AICID">The case info id.</param>
        /// <returns></returns>
        internal CasePartyAICAddressEntity GetCasePartyAICAddress(String primaryKey)
        {
            IRepository<CasePartyAICAddress> casePartyAICAddressRepository = new RepositoryImpl<CasePartyAICAddress>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyAICAddressEntity(casePartyAICAddressRepository.Get(primaryKey));
        }

        /// <summary>
        /// Passes the RecId and get the CasePartyAICAlias.
        /// </summary>
        /// <param name="primaryKey">The Primary Key.</param>
        /// <returns></returns>
        internal CasePartyAICAliasEntity GetCasePartyAICAlias(String primaryKey)
        {
            IRepository<CasePartyAICAlias> casePartyAICAliasRepository = new RepositoryImpl<CasePartyAICAlias>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyAICAliasEntity(casePartyAICAliasRepository.Get(primaryKey));
        }

        /// <summary>
        /// Passes the RecId and get the CasePartyAICAddress.
        /// </summary>
        /// <param name="RecId">The primary Key.</param>
        /// <returns></returns>
        internal CasePartyAICDetailsEntity GetCasePartyAICDetails(String primaryKey)
        {
            IRepository<CasePartyAICDetail> casePartyAICDetailRepository = new RepositoryImpl<CasePartyAICDetail>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyAICDetailsEntity(casePartyAICDetailRepository.Get(primaryKey));
        }

        /// <summary>
        /// Passes the RecId and get the CasePartyAICAddress.
        /// </summary>
        /// <param name="RecId">The case info id.</param>
        /// <returns></returns>
        internal CasePartyAliasEntity GetCasePartyAlias(String primaryKey)
        {
            IRepository<CasePartyAlias> casePartyAliasRepository = new RepositoryImpl<CasePartyAlias>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyAliasEntity(casePartyAliasRepository.Get(primaryKey));
        }

        /// <summary>
        /// Passes the primary key and get the CasePartyAuthorisedOfficerDetailsEntity.
        /// </summary>
        /// <param name="primaryKey">The Primary Key.</param>
        /// <returns></returns>
        internal CasePartyAuthorisedOfficerDetailsEntity GetCasePartyAuthorisedOfficerDetail(String primaryKey)
        {
            IRepository<CasePartyAuthorisedOfficerDetail> casePartyAuthorisedOfficerDetailRepository = new RepositoryImpl<CasePartyAuthorisedOfficerDetail>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyAuthorisedOfficerDetailEntity(casePartyAuthorisedOfficerDetailRepository.Get(primaryKey));
        }

        internal List<CasePartyEntity> GetCasePartyByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseParty))
                                                                            .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<CaseParty> listCaseParty = GetCaseParty(detachedCriteria);

            if (listCaseParty != null && listCaseParty.Count > 0)
            {
                return listCaseParty.Select(caseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyEntity(caseParty)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the CasePartyId andGets the CasePartyEntity
        /// </summary>
        /// <param name="caseInfoId">The case party id.</param>
        /// <returns></returns>
        internal CasePartyEntity GetCasePartyByPK(string casePartyId)
        {
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyEntity(GetCaseParty(casePartyId));
        }

        internal CasePartyCriminalInfoEntity GetCasePartyCriminalInfoEntityByCasePartyId(string casePartyId)
        {
            CasePartyCriminalInfo casePartyCriminalInfo = GetCasePartyCriminalInfoByCasePartyId(casePartyId);

            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyCriminalInfoEntity(casePartyCriminalInfo);
        }

        /// <summary>
        /// Passes the casePartyId andGets the ICaseParty
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        internal ICasePartyData GetCasePartyData(string casePartyId)
        {
            CasePartyData casePartyData = new CasePartyData();
            try
            {
                casePartyData.CasePartyEntity = this.GetCasePartyByPK(casePartyId);
                casePartyData.CasePartyAddresses = this.GetListCasePartyAddress(casePartyId);
                casePartyData.CasePartyAICDetails = this.GetListCasePartyAICDetailsWithChildByCasePartyId(casePartyId);
                casePartyData.CasePartyAliases = this.GetListCasePartyAlias(casePartyId);
                casePartyData.CasePartyAuthorisedOfficerDetails = this.GetListCasePartyAuthorisedOfficerDetail(casePartyId);
                casePartyData.CasePartyVesselDetails = this.GetListCasePartyVesselDetail(casePartyId);
                casePartyData.CaseSolicitors = this.GetListCaseSolicitorByCasePartyId(casePartyId);
                casePartyData.CasePartyLACDetail = this.GetCasePartyLACDetail(casePartyId);
                casePartyData.CasePartyCitizenships = this.GetListCasePartyCitizenshipEntityByCasePartyId(casePartyId);
                casePartyData.CasePartyCriminalInfo = this.GetCasePartyCriminalInfoEntityByCasePartyId(casePartyId);
                casePartyData.CasePartyBailorInfos = this.GetListCasePartyBailorInfoEntityByCasePartyId(casePartyId);
                casePartyData.PartyCaseFileRefNumber = this.GetListPartyCaseFileRefNumberEntityByCasePartyId(casePartyId);

                casePartyData.CasePartyBailorAddresses = new List<CasePartyBailorAddressEntity>();

                List<CasePartyBailorInfoEntity> casePartyBailorInfos = new List<CasePartyBailorInfoEntity>();

                if (casePartyData.CasePartyBailorInfos != null)
                {
                    foreach (CasePartyBailorInfoEntity cpbi in casePartyData.CasePartyBailorInfos)
                    {
                        cpbi.CasePartyBailorAddresses = new List<CasePartyBailorAddressEntity>();
                        List<CasePartyBailorAddressEntity> lstCasePartyBailorAddressEntity = GetListCasePartyBailorAddressEntityByCasePartyBailorInfoId(cpbi.CasePartyBailorInfoId);

                        if (lstCasePartyBailorAddressEntity != null)
                        {
                            foreach (CasePartyBailorAddressEntity cpba in lstCasePartyBailorAddressEntity)
                                cpbi.CasePartyBailorAddresses.Add(cpba);
                            casePartyBailorInfos.Add(cpbi);
                        }
                    }
                }
                if (casePartyBailorInfos != null)
                    casePartyData.CasePartyBailorInfos = casePartyBailorInfos;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCasePartyData", ex);
                throw;
            }

            return casePartyData;
        }
        /// <summary>
        /// Gets the list party case file reference number entity by case party identifier.
        /// </summary>
        /// <param name="casePartyId">The case party identifier.</param>
        /// <returns></returns>
        private List<PartyCaseFileRefNumberEntity> GetListPartyCaseFileRefNumberEntityByCasePartyId(string casePartyId)
        {
            List<PartyCaseFileRefNumber> listPartyCaseFileRefNumber = this.GetListPartyCaseFileRefNumberByCasePartyId(casePartyId);

            if (listPartyCaseFileRefNumber != null && listPartyCaseFileRefNumber.Count > 0)
            {
                return listPartyCaseFileRefNumber.Select(partyCaseFileRefNumber => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetPartyCaseFileRefNumberEntity(partyCaseFileRefNumber)).ToList();
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Gets the list party case file reference number by case party identifier.
        /// </summary>
        /// <param name="casePartyId">The case party identifier.</param>
        /// <returns></returns>
        private List<PartyCaseFileRefNumber> GetListPartyCaseFileRefNumberByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PartyCaseFileRefNumber))
                                                                             .Add(Expression.Eq("CasePartyID", casePartyId));

            List<PartyCaseFileRefNumber> listPartyCaseFileRefNumber = GetListPartyCaseFileRefNumber(detachedCriteria);

            return listPartyCaseFileRefNumber;
        }
        /// <summary>
        /// Gets the list party case file reference number.
        /// </summary>
        /// <param name="detachedCriteria">The detached criteria.</param>
        /// <returns></returns>
        private List<PartyCaseFileRefNumber> GetListPartyCaseFileRefNumber(DetachedCriteria detachedCriteria)
        {
            IRepository<PartyCaseFileRefNumber> partyCaseFileRefNumberRepository = new RepositoryImpl<PartyCaseFileRefNumber>(applicationSession);
            return partyCaseFileRefNumberRepository.GetAll(detachedCriteria) as List<PartyCaseFileRefNumber>;
        }

        internal CasePartyLACDetailEntity GetCasePartyLACDetail(string casePartyId)
        {
            if (!string.IsNullOrEmpty(casePartyId))
            {
                CaseParty caseParty = new CaseParty { CasePartyId = casePartyId };
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyLACDetail))
                    .Add(Expression.Eq("CaseParty", caseParty));

                List<CasePartyLACDetail> listCasePartyLACDetail = GetFromDetachedCriteria<CasePartyLACDetail>(detachedCriteria);

                if (listCasePartyLACDetail != null && listCasePartyLACDetail.Count > 0)
                {
                    return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyLACDetailEntity(listCasePartyLACDetail[0]);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the RecId and get the CasePartyAICAddress.
        /// </summary>
        /// <param name="RecId">The case info id.</param>
        /// <returns></returns>
        internal CasePartyVesselDetailsEntity GetCasePartyVesselDetail(String primaryKey)
        {
            IRepository<CasePartyVesselDetail> casePartyVesselDetailRepository = new RepositoryImpl<CasePartyVesselDetail>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyVesselDetailsEntity(casePartyVesselDetailRepository.Get(primaryKey));
        }

        /// <summary>
        /// Passes the RecId and get the CaseSolicitor.
        /// </summary>
        /// <param name="RecId">The case info id.</param>
        /// <returns></returns>
        internal CaseSolicitorEntity GetCaseSolicitor(String primaryKey)
        {
            IRepository<CaseSolicitor> caseSolicitorRepository = new RepositoryImpl<CaseSolicitor>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseSolicitorEntity(caseSolicitorRepository.Get(primaryKey));
        }

        /// <summary>
        /// Passes the primaryKey and get the CaseSolicitorHistoryEntity.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        internal CaseSolicitorHistoryEntity GetCaseSolicitorHistory(String primaryKey)
        {
            IRepository<CaseSolicitorHistory> caseSolicitorHistoryRepository = new RepositoryImpl<CaseSolicitorHistory>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseSolicitorHistoryEntity(caseSolicitorHistoryRepository.Get(primaryKey));
        }

        /*
        /// <summary>
        /// Deletes the CasePartyData by CasePartyId
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        internal void DeleteCasePartyDataByCasePartyId(string casePartyId)
        {

            try
            {
                casePartyData.CasePartyEntity = this.GetCasePartyByPK(casePartyId);
                casePartyData.CasePartyAddresses = this.GetListCasePartyAddress(casePartyId);
                casePartyData.CasePartyAICDetails = this.GetListCasePartyAICDetailsWithChildByCasePartyId(casePartyId);
                casePartyData.CasePartyAliases = this.GetListCasePartyAlias(casePartyId);
                casePartyData.CasePartyAuthorisedOfficerDetails = this.GetListCasePartyAuthorisedOfficerDetail(casePartyId);
                casePartyData.CasePartyVesselDetails = this.GetListCasePartyVesselDetail(casePartyId);
                casePartyData.CaseSolicitors = this.GetListCaseSolicitorByCasePartyId(casePartyId);
                casePartyData.CasePartyLACDetail = this.GetCasePartyLACDetail(casePartyId);
                casePartyData.CasePartyCriminalInfo = this.GetCasePartyCriminalInfoEntityByCasePartyId(casePartyId);
                casePartyData.CasePartyBailorInfos = this.GetListCasePartyBailorInfoEntityByCasePartyId(casePartyId);
                casePartyData.CasePartyBailorAddresses = new List<CasePartyBailorAddressEntity>();
                if (casePartyData.CasePartyBailorInfos != null)
                {
                    foreach (CasePartyBailorInfoEntity cpbi in casePartyData.CasePartyBailorInfos)
                        foreach (CasePartyBailorAddressEntity cpba in GetListCasePartyBailorAddressEntityByCasePartyBailorInfoId(cpbi.CasePartyBailorInfoId))
                            casePartyData.CasePartyBailorAddresses.Add(cpba);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCasePartyData", ex);
                throw;
            }

            return casePartyData;
        }*/
        internal ICasePartyData GetCriminalCasePartyData(string casePartyId)
        {
            CriminalCasePartyData criminalCasePartyData = new CriminalCasePartyData();
            try
            {

                criminalCasePartyData.ListCasePartyCriminalInfo = this.GetListCasePartyCriminalInfoEntityByCasePartyId(casePartyId);
                criminalCasePartyData.ListCasePartyBailorInfo = this.GetListCasePartyBailorInfoEntityByCasePartyId(casePartyId);
                criminalCasePartyData.ListCasePartyBailorAddress = new List<CasePartyBailorAddressEntity>();

                if (criminalCasePartyData.ListCasePartyBailorInfo != null)
                {
                    foreach (CasePartyBailorInfoEntity cpbi in criminalCasePartyData.ListCasePartyBailorInfo)
                        foreach (CasePartyBailorAddressEntity cpba in GetListCasePartyBailorAddressEntityByCasePartyBailorInfoId(cpbi.CasePartyBailorInfoId))
                            criminalCasePartyData.ListCasePartyBailorAddress.Add(cpba);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCriminalCasePartyData", ex);
                throw;
            }

            return criminalCasePartyData;
        }

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

        internal List<T> GetEntity<T, V>(Type iNhibernateType, string fieldName, V value, bool hasObsInd)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            return iRepository.GetAll(this.GetDetachedCriteria<V>(iNhibernateType, fieldName, value, hasObsInd)) as List<T>;
        }

        //TODO: Need to remove this as hrgId is Long
        /// <summary>
        /// Gets the hearing by PK.
        /// </summary>
        /// <param name="hrgId">The HRG id.</param>
        /// <returns></returns>
        internal HearingEntity GetHearingByPK(string hrgId)
        {
            IRepository<Hearing> hearingRepository = new RepositoryImpl<Hearing>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetHearingEntity(hearingRepository.Get(Convert.ToInt64(hrgId)));
        }

        /// <summary>
        /// Gets the hearing by PK.
        /// </summary>
        /// <param name="hrgId">The HRG id.</param>
        /// <returns></returns>
        internal HearingEntity GetHearingByPK(long hrgId)
        {
            IRepository<Hearing> hearingRepository = new RepositoryImpl<Hearing>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetHearingEntity(hearingRepository.Get(hrgId));
        }

        internal List<HearingEntity> GetHearingEntityList(DateTime startDateTime, DateTime endDateTime)
        {
            List<HearingEntity> listHearingEntity = new List<HearingEntity>();
            HearingEntity hearingEntity = new HearingEntity();
            IHearingRepository hearingRepository = new HearingRepositoryImpl(applicationSession);
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(Hearing))
                                 .Add(Expression.Between("HRGDateTime", startDateTime, endDateTime));
            List<Hearing> listHearing = hearingRepository.GetAll(detachedCriteria) as List<Hearing>;
            if (listHearing != null && listHearing.Count > 0)
            {
                foreach (Hearing hrg in listHearing)
                {
                    hearingEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetHearingEntity(hrg);
                    listHearingEntity.Add(hearingEntity);
                }
            }
            else
                listHearingEntity = null;
            return listHearingEntity;
        }

        /// <summary>
        /// Passes the RCLFId and get the LawFirmCaseFileRefNumberEntity.
        /// </summary>
        /// <param name="RCLFId">The /// <returns></returns>.</param>
        /// <returns></returns>
        internal LawFirmCaseFileRefNumberEntity GetLawFirmCaseFileRefNumberEntityByPK(string RCLFId)
        {
            IRepository<LawFirmCaseFileRefNumber> lawFirmCaseFileRefNumberRepository = new RepositoryImpl<LawFirmCaseFileRefNumber>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetLawFirmCaseFileRefNumberEntity(lawFirmCaseFileRefNumberRepository.Get(RCLFId));
        }

        internal List<CaseInfoEntity> GetListCaseInfoByTrimCaseNo(string caseNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseInfo))
                                                .Add(Expression.Eq("CaseNo", caseNo));

            List<CaseInfo> listCaseInfo = GetAllCaseInfoEntity(detachedCriteria);

            if (listCaseInfo != null && listCaseInfo.Count > 0)
            {
                return listCaseInfo.Select(caseInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseInfoEntity(caseInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        //Added by narayan
        /// <summary>
        /// Get Case Info Detail  based on CaseName & CaseNo
        /// </summary>
        /// <param name="CaseName OR CaseNo"></param>
        /// <returns>ServiceOfDocInfoDetailEntity</returns>
        internal List<CaseInfoEntity> GetListCaseInfoEntityByCaseNameORCaseNo(string caseNo, string caseName)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseInfo))
                                                                            .Add(Expression.Or((Expression.Like("CaseNo", caseNo, MatchMode.Anywhere)), Expression.Like("CaseName", caseName, MatchMode.Anywhere)))
                                                                             .Add(Expression.Eq("ObsInd", "N")); ;
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
        /// Get Case Info Detail  based on CaseNo
        /// </summary>
        /// <param name="CaseName OR CaseNo"></param>
        /// <returns>ServiceOfDocInfoDetailEntity</returns>
        internal List<CaseInfoEntity> GetListCaseInfoEntityCaseNo(string caseNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseInfo))
                 .Add(Expression.Like("CaseNo", caseNo, MatchMode.Anywhere))
                 .Add(Expression.Eq("ObsInd","N"));
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

        internal List<CaseInfoEntity> GetListCaseInfoEntityByExactCaseNo(string caseNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseInfo))
                 .Add(Expression.Like("CaseNo", caseNo))
                  .Add(Expression.Eq("ObsInd", "N"));
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

        internal List<CaseOriginatingCaseEntity> GetListCaseOriginatingCase(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseOriginatingCase))
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            List<CaseOriginatingCase> listCaseOriginatingCase = GetFromDetachedCriteria<CaseOriginatingCase>(detachedCriteria);

            if (listCaseOriginatingCase != null && listCaseOriginatingCase.Count > 0)
            {
                return listCaseOriginatingCase.Select(caseOriginatingCase => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseOriginatingCaseEntity(caseOriginatingCase)).ToList();
            }
            else
                return null;
        }

        internal List<CasePartyEntity> GetListCaseParty(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseParty))
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            List<CaseParty> listCaseParty = GetFromDetachedCriteria<CaseParty>(detachedCriteria);
            if (listCaseParty != null && listCaseParty.Count > 0)
            {
                return listCaseParty.Select(caseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyEntity(caseParty)).ToList();
            }
            else
                return null;
        }

        /// <summary>
        /// Passes the casePartyId and get a list CasePartyAddressEntity.
        /// </summary>
        /// <param name="casePartyId">The case party Id.</param>
        /// <returns></returns>
        internal List<CasePartyAddressEntity> GetListCasePartyAddress(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyAddress))
                                                                            .Add(Expression.Eq("CasePartyId", casePartyId));

            List<CasePartyAddress> listCasePartyAddress = GetCasePartyAddress(detachedCriteria);
            if (listCasePartyAddress != null && listCasePartyAddress.Count > 0)
            {
                return listCasePartyAddress.Select(casePartyAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyAddressEntity(casePartyAddress)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the AICID and get a list CasePartyAICAddressEntity.
        /// </summary>
        /// <param name="AICID">The AIC id.</param>
        /// <returns></returns>
        internal List<CasePartyAICAddressEntity> GetListCasePartyAICAddress(string AICID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyAICAddress))
                                                                            .Add(Expression.Eq("AICID", AICID));

            List<CasePartyAICAddress> listcasePartyAICAddress = GetCasePartyAICAddress(detachedCriteria);

            if (listcasePartyAICAddress != null && listcasePartyAICAddress.Count > 0)
            {
                return listcasePartyAICAddress.Select(casePartyAICAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyAICAddressEntity(casePartyAICAddress)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the AICID and get a list CasePartyAICAliasEntity.
        /// </summary>
        /// <param name="AICID">The AIC ID.</param>
        /// <returns></returns> 
        internal List<CasePartyAICAliasEntity> GetListCasePartyAICAlias(string AICID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyAICAlias))
                                                                            .Add(Expression.Eq("AICID", AICID));

            List<CasePartyAICAlias> listCasePartyAICAlias = GetCasePartyAICAlias(detachedCriteria);

            if (listCasePartyAICAlias != null && listCasePartyAICAlias.Count > 0)
            {
                return listCasePartyAICAlias.Select(casePartyAICAlias => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyAICAliasEntity(casePartyAICAlias)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the casePartyID and get the CasePartyAICDetailsEntity.
        /// </summary>
        /// <param name="casePartyID">The CaseParty ID.</param>
        /// <returns></returns>
        internal List<CasePartyAICDetailsEntity> GetListCasePartyAICDetail(string casePartyID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyAICDetail))
                                                                            .Add(Expression.Eq("CasePartyId", casePartyID));

            List<CasePartyAICDetail> listCasePartyAICDetail = GetCasePartyAICDetail(detachedCriteria);

            if (listCasePartyAICDetail != null && listCasePartyAICDetail.Count > 0)
            {
                return listCasePartyAICDetail.Select(casePartyAICDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyAICDetailsEntity(casePartyAICDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the List of <see cref="CasePartyAICDetailsEntity "/>Along with CasePartyAICAddress & CasePartyAICAliases
        /// </summary>
        /// <param name="casePartyId">The casePartyId.</param>
        /// <returns></returns>
        internal List<CasePartyAICDetailsEntity> GetListCasePartyAICDetailsWithChildByCasePartyId(string casePartyId)
        {
            List<CasePartyAICDetailsEntity> listCasePartyAICDetailsEntity = GetListCasePartyAICDetail(casePartyId);
            if (listCasePartyAICDetailsEntity != null && listCasePartyAICDetailsEntity.Count > 0)
            {
                for (int i = 0; i < listCasePartyAICDetailsEntity.Count; i++)
                {
                    listCasePartyAICDetailsEntity[i].CasePartyAICAddresses = GetListCasePartyAICAddress(listCasePartyAICDetailsEntity[i].AICID);
                    listCasePartyAICDetailsEntity[i].CasePartyAICAliases = GetListCasePartyAICAlias(listCasePartyAICDetailsEntity[i].AICID);
                }
                return listCasePartyAICDetailsEntity;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the CasePartyId and get a list CasePartyAliasEntity.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        internal List<CasePartyAliasEntity> GetListCasePartyAlias(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyAlias))
                                                                            .Add(Expression.Eq("CasePartyId", casePartyId));

            List<CasePartyAlias> listCasePartyAlias = GetCasePartyAlias(detachedCriteria);
            if (listCasePartyAlias != null && listCasePartyAlias.Count > 0)
            {
                return listCasePartyAlias.Select(casePartyAlias => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyAliasEntity(casePartyAlias)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the primary key and get a list CasePartyAuthorisedOfficerDetailsEntity.
        /// </summary>
        /// <param name="casePartyId">The Case Party Id.</param>
        /// <returns></returns>
        internal List<CasePartyAuthorisedOfficerDetailsEntity> GetListCasePartyAuthorisedOfficerDetail(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyAuthorisedOfficerDetail))
                                                                            .Add(Expression.Eq("CasePartyId", casePartyId));

            List<CasePartyAuthorisedOfficerDetail> listCasePartyAuthorisedOfficerDetail = GetCasePartyAuthorisedOfficerDetail(detachedCriteria);

            if (listCasePartyAuthorisedOfficerDetail != null && listCasePartyAuthorisedOfficerDetail.Count > 0)
            {
                return listCasePartyAuthorisedOfficerDetail.Select(casePartyAuthorisedOfficerDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyAuthorisedOfficerDetailEntity(casePartyAuthorisedOfficerDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<CasePartyBailorAddressEntity> GetListCasePartyBailorAddressEntityByCasePartyId(string casePartyId)
        {
            List<CasePartyBailorInfoEntity> casePartyBailorInfoEntity = GetListCasePartyBailorInfoEntityByCasePartyId(casePartyId);
            List<CasePartyBailorAddressEntity> casePartyBailorAddressEntity = new List<CasePartyBailorAddressEntity>();

            foreach (CasePartyBailorInfoEntity cpbie in casePartyBailorInfoEntity)
            {
                if (cpbie != null)
                {
                    foreach (CasePartyBailorAddressEntity cpbae in GetListCasePartyBailorAddressEntityByCasePartyBailorInfoId(cpbie.CasePartyBailorInfoId))
                        casePartyBailorAddressEntity.Add(cpbae);
                }
            }
            if (casePartyBailorAddressEntity != null && casePartyBailorAddressEntity.Count > 0)
                return casePartyBailorAddressEntity;
            else
                return null;
        }

        internal List<CasePartyBailorInfoEntity> GetListCasePartyBailorInfoEntityByCasePartyId(string casePartyId)
        {
            List<CasePartyBailorInfo> listCasePartyBailorInfo = GetListCasePartyBailorInfoByCasePartyId(casePartyId);

            if (listCasePartyBailorInfo != null && listCasePartyBailorInfo.Count > 0)
            {
                return listCasePartyBailorInfo.Select(casePartyBailorInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyBailorInfoEntity(casePartyBailorInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the caseInfoId andGets the a list CasePartyEntity
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        internal List<CasePartyEntity> GetListCasePartyByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseParty))
                                                                            .Add(Expression.Eq("CaseInfoId", caseInfoId));

            List<CaseParty> listCaseParty = GetCaseParty(detachedCriteria);

            if (listCaseParty != null && listCaseParty.Count > 0)
            {
                return listCaseParty.Select(caseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyEntity(caseParty)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<CasePartyEntity> GetListCasePartyByTrimCaseNo(string caseNo)
        {
            List<CasePartyEntity> listCaseParty = null;
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseInfo))
                                                                            .Add(Expression.Eq("CaseNo", caseNo));

            List<CaseInfo> listCaseInfo = GetFromDetachedCriteria<CaseInfo>(detachedCriteria);

            if (listCaseInfo != null && listCaseInfo.Count > 0)
            {
                listCaseParty = new List<CasePartyEntity>();


                foreach (CaseInfo caseInfo in listCaseInfo)
                {
                    List<CasePartyEntity> casePartyList = GetListCaseParty(caseInfo.CaseInfoId.ToString());
                    if (casePartyList != null && casePartyList.Count > 0)
                    {
                        listCaseParty.AddRange(casePartyList);
                    }
                }
                return listCaseParty;

            }
            else
                return null;
        }

        internal List<CasePartyCitizenshipEntity> GetListCasePartyCitizenshipEntityByCasePartyId(string casePartyId)
        {
            List<CasePartyCitizenship> listCasePartyCitizenship = GetListCasePartyCitizenshipByCasePartyId(casePartyId);

            if (listCasePartyCitizenship != null && listCasePartyCitizenship.Count > 0)
            {
                return listCasePartyCitizenship.Select(casePartyCitizenship => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyCitizenshipEntity(casePartyCitizenship)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<CasePartyCriminalInfoEntity> GetListCasePartyCriminalInfoEntityByCasePartyId(string casePartyId)
        {
            List<CasePartyCriminalInfo> listCasePartyCriminalInfo = GetListCasePartyCriminalInfoByCasePartyId(casePartyId);

            if (listCasePartyCriminalInfo != null && listCasePartyCriminalInfo.Count > 0)
            {
                return listCasePartyCriminalInfo.Select(casePartyCriminalInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyCriminalInfoEntity(casePartyCriminalInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<CasePartyData> GetListCasePartyData(string caseInfoId)
        {
            List<CasePartyData> listCasePartyData = null;

            List<CasePartyEntity> listCaseParty = GetListCaseParty(caseInfoId);

            if (listCaseParty != null && listCaseParty.Count > 0)
            {
                listCasePartyData = new List<CasePartyData>();

                foreach (CasePartyEntity caseParty in listCaseParty)
                {
                    listCasePartyData.Add((CasePartyData)GetCasePartyData(caseParty.CasePartyId));
                }
            }

            return listCasePartyData;
        }

        internal List<CasePartyEntity> GetListCasePartyEntityByCaseNumber(string caseNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseInfo))
                .Add(Expression.Like("CaseNo", caseNo, MatchMode.Anywhere));

            List<CaseInfo> listCaseInfoEntity = GetAllCaseInfoEntity(detachedCriteria);
            List<CasePartyEntity> listCaseParty = new List<CasePartyEntity>();

            if (listCaseInfoEntity != null && listCaseInfoEntity.Count > 0)
            {
                foreach (CaseInfo caseInfo in listCaseInfoEntity)
                {
                    listCaseParty.AddRange(GetListCaseParty(Convert.ToString(caseInfo.CaseInfoId)));
                }
                return listCaseParty;
            }
            else
                return null;
        }

        internal List<CasePartyLACDetailHistoryEntity> GetListCasePartyLACDetailHistory(string casePartyId)
        {
            if (!string.IsNullOrEmpty(casePartyId))
            {
                CaseParty caseParty = new CaseParty { CasePartyId = casePartyId };
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyLACDetailsHistory))
                    .Add(Expression.Eq("CaseParty", caseParty));
                List<CasePartyLACDetailsHistory> listCasePartyLACDetailsHistory = GetFromDetachedCriteria<CasePartyLACDetailsHistory>(detachedCriteria);

                if (listCasePartyLACDetailsHistory != null && listCasePartyLACDetailsHistory.Count > 0)
                {
                    return listCasePartyLACDetailsHistory.Select(casePartyLACDetailsHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyLACDetailHistoryEntity(casePartyLACDetailsHistory)).ToList();
                }
                else
                {
                    return null;
                }
            }
            else
                return null;
        }

        internal List<CasePartyStatusHistoryEntity> GetListCasePartyStatusHistory(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyStatusHistory))
                                                                  .Add(Expression.Eq("CasePartyId", casePartyId));
            List<CasePartyStatusHistory> listCasePartyStatusHistory = GetFromDetachedCriteria<CasePartyStatusHistory>(detachedCriteria);
            if (listCasePartyStatusHistory != null && listCasePartyStatusHistory.Count > 0)
            {
                return listCasePartyStatusHistory.Select(casePartyStatusHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
                    .CaseMapper.GetCasePartyStatusHistory(casePartyStatusHistory)).ToList();
            }
            else
                return null;
        }

        /// <summary>
        /// Passes the casePartyId and get a list CasePartyVesselDetailsEntity.
        /// </summary>
        /// <param name="casePartyId">The case Party id.</param>
        /// <returns></returns>
        internal List<CasePartyVesselDetailsEntity> GetListCasePartyVesselDetail(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyVesselDetail))
                                                                            .Add(Expression.Eq("CasePartyId", casePartyId));

            List<CasePartyVesselDetail> listCasePartyVesselDetail = GetCasePartyVesselDetail(detachedCriteria);

            if (listCasePartyVesselDetail != null && listCasePartyVesselDetail.Count > 0)
            {
                return listCasePartyVesselDetail.Select(casePartyVesselDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyVesselDetailsEntity(casePartyVesselDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<CaseSolicitorEntity> GetListCaseSolicitor(string caseInfoId, string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseSolicitor))
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                .Add(Expression.Eq("CasePartyId", casePartyId));

            List<CaseSolicitor> listCaseSolicitor = GetFromDetachedCriteria<CaseSolicitor>(detachedCriteria);
            if (listCaseSolicitor != null && listCaseSolicitor.Count > 0)
            {
                return listCaseSolicitor.Select(caseSolicitor => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseSolicitorEntity(caseSolicitor)).ToList();
            }
            else
                return null;
        }

        /// <summary>
        /// Passes the caseInfoId and get a list CaseSolicitorEntity.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        internal List<CaseSolicitorEntity> GetListCaseSolicitorByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseSolicitor))
                                                                            .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<CaseSolicitor> listCaseSolicitor = GetCaseSolicitor(detachedCriteria);

            if (listCaseSolicitor != null && listCaseSolicitor.Count > 0)
            {
                return listCaseSolicitor.Select(caseSolicitor => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseSolicitorEntity(caseSolicitor)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the casePartyId and get a list CaseSolicitorEntity.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        internal List<CaseSolicitorEntity> GetListCaseSolicitorByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseSolicitor))
                                                                            .Add(Expression.Eq("CasePartyId", casePartyId));

            List<CaseSolicitor> listCaseSolicitor = GetCaseSolicitor(detachedCriteria);

            if (listCaseSolicitor != null && listCaseSolicitor.Count > 0)
            {
                return listCaseSolicitor.Select(caseSolicitor => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseSolicitorEntity(caseSolicitor)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<CaseSolicitorHistoryEntity> GetListCaseSolicitorHistory(string caseInfoId, string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseSolicitorHistory))
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                .Add(Expression.Eq("CasePartyId", casePartyId));
            List<CaseSolicitorHistory> listCaseSolicitorHistory = GetFromDetachedCriteria<CaseSolicitorHistory>(detachedCriteria);

            if (listCaseSolicitorHistory != null && listCaseSolicitorHistory.Count > 0)
            {
                return listCaseSolicitorHistory.Select(caseSolicitorHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseSolicitorHistoryEntity(caseSolicitorHistory)).ToList();
            }
            else
                return null;
        }

        /// <summary>
        /// Passes the caseInfoId and get a list CaseSolicitorHistoryEntity.
        /// </summary>
        /// <param name="caseInfoId">The case info key.</param>
        /// <returns></returns>
        internal List<CaseSolicitorHistoryEntity> GetListCaseSolicitorHistoryByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseSolicitorHistory))
                                                                            .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<CaseSolicitorHistory> listCaseSolicitorHistory = GetCaseSolicitorHistory(detachedCriteria);

            if (listCaseSolicitorHistory != null && listCaseSolicitorHistory.Count > 0)
            {
                return listCaseSolicitorHistory.Select(caseSolicitorHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseSolicitorHistoryEntity(caseSolicitorHistory)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the casePartyId and get a list CaseSolicitorHistoryEntity.
        /// </summary>
        /// <param name="casePartyId">The case party key.</param>
        /// <returns></returns>
        internal List<CaseSolicitorHistoryEntity> GetListCaseSolicitorHistoryByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseSolicitorHistory))
                                                                            .Add(Expression.Eq("CasePartyId", casePartyId));

            List<CaseSolicitorHistory> listCaseSolicitorHistory = GetCaseSolicitorHistory(detachedCriteria);

            if (listCaseSolicitorHistory != null && listCaseSolicitorHistory.Count > 0)
            {
                return listCaseSolicitorHistory.Select(caseSolicitorHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseSolicitorHistoryEntity(caseSolicitorHistory)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<HearingEntity> GetListHearingByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(Hearing))
               .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            List<Hearing> listHearing = GetFromDetachedCriteria<Hearing>(detachedCriteria);

            if (listHearing != null && listHearing.Count > 0)
            {
                return listHearing.Select(hearing => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetHearingEntity(hearing)).ToList();
            }
            else
                return null;
        }

        internal List<HearingEntity> GetListHearingByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(Hearing))
                .Add(Expression.Eq("DocId", docId));
            List<Hearing> listHearing = GetHearing(detachedCriteria);
            if (listHearing != null && listHearing.Count > 0)
            {
                return listHearing.Select(hearing => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetHearingEntity(hearing)).ToList();

            }
            else
                return null;
        }

        internal List<LawFirmCaseFileRefNumberEntity> GetListLawFirmCaseFileRefNumberEntity(string lFID, string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LawFirmCaseFileRefNumber))
                .Add(Expression.Eq("LFID", lFID))
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            List<LawFirmCaseFileRefNumber> listLawFirmCaseFileRefNumber = GetFromDetachedCriteria<LawFirmCaseFileRefNumber>(detachedCriteria);
            if (listLawFirmCaseFileRefNumber != null && listLawFirmCaseFileRefNumber.Count > 0)
            {
                return listLawFirmCaseFileRefNumber.Select(lawFirmCaseFileRefNumber => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetLawFirmCaseFileRefNumberEntity(lawFirmCaseFileRefNumber)).ToList();
            }
            else
                return null;
        }

        /// <summary>
        /// Passes the caseInfoID and get the LawFirmCaseFileRefNumberEntity.
        /// </summary>
        /// <param name="caseInfoID">The ase info id.</param>
        /// <returns></returns>
        internal List<LawFirmCaseFileRefNumberEntity> GetListLawFirmCaseFileRefNumberEntityByCaseInfoId(string caseInfoID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LawFirmCaseFileRefNumber))
                                                                            .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoID)));

            List<LawFirmCaseFileRefNumber> listLawFirmCaseFileRefNumber = GetlawFirmCaseFileRefNumber(detachedCriteria);

            if (listLawFirmCaseFileRefNumber != null && listLawFirmCaseFileRefNumber.Count > 0)
            {
                return listLawFirmCaseFileRefNumber.Select(lawFirmCaseFileRefNumber => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetLawFirmCaseFileRefNumberEntity(lawFirmCaseFileRefNumber)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the caseInfoID and get the RCaseLawFirmEntity.
        /// </summary>
        /// <param name="caseInfoID">The case info entitiY"</param>
        /// <returns></returns>
        internal List<RCaseLawFirmEntity> GetListRCaseLawFirmEntityByCaseInfoId(string caseInfoID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RCaseLawFirm))
                                                                            .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoID)));

            List<RCaseLawFirm> listRCaseLawFirm = GetRCaseLawFirm(detachedCriteria);

            if (listRCaseLawFirm != null && listRCaseLawFirm.Count > 0)
            {
                return listRCaseLawFirm.Select(rCaseLawFirm => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseLawFirmEntity(rCaseLawFirm)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the caseInfoID and LawFirm Id to get the RCaseLawFirmEntity.
        /// </summary>
        /// <param name="caseInfoID">The case info entitiY"</param>
        /// <param name="LFId">The Lawfirm Id</param>
        /// <returns></returns>
        internal List<RCaseLawFirmEntity> GetListRCaseLawFirmEntityByCaseInfoIdAndLFId(string caseInfoID, string LFId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RCaseLawFirm))
                                                                            .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoID)))
                                                                            .Add(Expression.Eq("LFID", LFId));

            List<RCaseLawFirm> listRCaseLawFirm = GetRCaseLawFirm(detachedCriteria);

            if (listRCaseLawFirm != null && listRCaseLawFirm.Count > 0)
            {
                return listRCaseLawFirm.Select(rCaseLawFirm => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseLawFirmEntity(rCaseLawFirm)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RCaseLinkedEntity> GetListRCaseLinkedByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RCaseLinked))
                                                                             .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<RCaseLinked> listRCaseLinked = GetFromDetachedCriteria<RCaseLinked>(detachedCriteria);

            if (listRCaseLinked != null && listRCaseLinked.Count > 0)
            {
                return listRCaseLinked.Select(rCaseLinked => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseLinkedEntity(rCaseLinked)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RCaseSubmissionEntity> GetListRCaseSubmissionEntity(string caseInfoId, string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RCaseSubmission))
               .Add(Expression.Eq("SubmissionGroupId", submissionGroupId))
               .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            List<RCaseSubmission> listRCaseSubmission = GetFromDetachedCriteria<RCaseSubmission>(detachedCriteria);
            if (listRCaseSubmission != null && listRCaseSubmission.Count > 0)
            {
                return listRCaseSubmission.Select(rCaseSubmission => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseSubmissionEntity(rCaseSubmission)).ToList();
            }
            else
                return null;
        }

        /// <summary>
        /// Passes the caseInfoID and get a list RCaseSubmissionEntity.
        /// </summary>
        /// <param name="caseInfoID">The Case Info Id."</param>
        /// <returns></returns>
        internal List<RCaseSubmissionEntity> GetListRCaseSubmissionEntityByCaseInfoId(string caseInfoID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RCaseSubmission))
                                                                            .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoID)));

            List<RCaseSubmission> listRCaseSubmission = GetRCaseSubmission(detachedCriteria);

            if (listRCaseSubmission != null && listRCaseSubmission.Count > 0)
            {
                return listRCaseSubmission.Select(rCaseSubmission => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseSubmissionEntity(rCaseSubmission)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RCaseSubmissionEntity> GetListRCaseSubmissionEntityBySGID(string SGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RCaseSubmission))
                                                                            .Add(Expression.Eq("SubmissionGroupId", SGID));

            List<RCaseSubmission> listRCaseSubmission = GetRCaseSubmission(detachedCriteria);

            if (listRCaseSubmission != null && listRCaseSubmission.Count > 0)
            {
                return listRCaseSubmission.Select(rCaseSubmission => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseSubmissionEntity(rCaseSubmission)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RCaseTransferEntity> GetListRCaseTransferByFrCaseInfoId(string frCaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RCaseTransfer))
                                                                  .Add(Expression.Eq("FrCaseInfoID", Convert.ToInt64(frCaseInfoId)));

            List<RCaseTransfer> listRCaseTransfer = GetFromDetachedCriteria<RCaseTransfer>(detachedCriteria);

            if (listRCaseTransfer != null && listRCaseTransfer.Count > 0)
            {
                return listRCaseTransfer.Select(rCaseTransfer => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseTransferEntity(rCaseTransfer)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the rCLFId and get a list RCaseLawFirmEntity.
        /// </summary>
        /// <param name="rCLFId">The R Case Law Firm Id."</param>
        /// <returns></returns>
        internal RCaseLawFirmEntity GetRCaseLawFirmEntityByPK(string rCLFId)
        {
            IRepository<RCaseLawFirm> rCaseLawFirmRepository = new RepositoryImpl<RCaseLawFirm>(applicationSession);

            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseLawFirmEntity(rCaseLawFirmRepository.Get(rCLFId));
        }

        internal List<RCaseSubmissionEntity> GetRCaseSubmission<V>(string fieldName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RCaseSubmission))
               .Add(Expression.Eq(fieldName, value));
            List<RCaseSubmission> listRCaseSubmission = GetFromDetachedCriteria<RCaseSubmission>(detachedCriteria);
            if (listRCaseSubmission != null && listRCaseSubmission.Count > 0)
            {
                return listRCaseSubmission.Select(rCaseSubmission => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseSubmissionEntity(rCaseSubmission)).ToList();
            }
            else
                return null;
        }

        /// <summary>
        /// Passes the RCaseSubmissionId and get a list RCaseSubmissionEntity.
        /// </summary>
        /// <param name="rCaseSubmissionId">The R Case Submission Id."</param>
        /// <returns></returns>
        internal RCaseSubmissionEntity GetRCaseSubmissionEntityByPK(string rCaseSubmissionId)
        {
            IRepository<RCaseSubmission> rCaseSubmissionRepository = new RepositoryImpl<RCaseSubmission>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseSubmissionEntity(rCaseSubmissionRepository.Get(rCaseSubmissionId));
        }

        /// <summary>
        /// Save the CasePartyAuthorisedOfficerDetailsEntity(for Testing).
        /// </summary>
        /// <param name="casePartyAuthorisedOfficerDetailsEntity">The Case Party Authorised Officer Details Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCaseCopyPartyAuthorisedOfficerDetailEntity(CasePartyAuthorisedOfficerDetailsEntity casePartyAuthorisedOfficerDetailsEntity)
        {
            IRepository<CasePartyAuthorisedOfficerDetail> casePartyAuthorisedOfficerDetailRepository = new RepositoryImpl<CasePartyAuthorisedOfficerDetail>(applicationSession);
            casePartyAuthorisedOfficerDetailRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyAuthorisedOfficerDetail(casePartyAuthorisedOfficerDetailsEntity));
        }

        /// <summary>
        /// Save CaseInfoEntity.
        /// </summary>
        /// <param name="caseInfoEntity">The case info.</param>
        /// <returns></returns> 
        internal void SaveOrUpdateCaseInfoEntity(CaseInfoEntity caseInfoEntity)
        {
            IRepository<CaseInfo> caseInfoRepository = new RepositoryImpl<CaseInfo>(applicationSession);
            caseInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseInfo(caseInfoEntity));
        }

        /// <summary>
        /// Svae the casePartyAddressEntity.
        /// </summary>
        /// <param name="casePartyAddressEntity">The Case Party Address Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCasePartyAddressEntity(CasePartyAddressEntity casePartyAddressEntity)
        {
            IRepository<CasePartyAddress> casePartyAddressRepository = new RepositoryImpl<CasePartyAddress>(applicationSession);
            casePartyAddressRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyAddress(casePartyAddressEntity));
        }

        /// <summary>
        /// Save the CasePartyAICAddressEntity.
        /// </summary>
        /// <param name="casePartyAICAddressEntity">Case Party AIC Address Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCasePartyAICAddressEntity(CasePartyAICAddressEntity casePartyAICAddressEntity)
        {
            IRepository<CasePartyAICAddress> casePartyAICAddressRepository = new RepositoryImpl<CasePartyAICAddress>(applicationSession);
            casePartyAICAddressRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyAICAddress(casePartyAICAddressEntity));
        }

        /// <summary>
        /// Save the CasePartyAICAliasEntity.
        /// </summary>
        /// <param name="casePartyAICAliasEntity">Case Party AIC Alias Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCasePartyAICAliasEntity(CasePartyAICAliasEntity casePartyAICAliasEntity)
        {
            IRepository<CasePartyAICAlias> casePartyAICAliasRepository = new RepositoryImpl<CasePartyAICAlias>(applicationSession);
            casePartyAICAliasRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyAICAlias(casePartyAICAliasEntity));
        }

        /// <summary>
        /// Save the CasePartyAICDetailsEntity.
        /// </summary>
        /// <param name="casePartyAICDetailsEntity">The Case Party AIC Details Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCasePartyAICDetailsEntity(CasePartyAICDetailsEntity casePartyAICDetailsEntity)
        {
            IRepository<CasePartyAICDetail> casePartyAICDetailRepository = new RepositoryImpl<CasePartyAICDetail>(applicationSession);
            casePartyAICDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyAICDetails(casePartyAICDetailsEntity));
        }

        /// <summary>
        /// Save the CasePartyAliasEntity.
        /// </summary>
        /// <param name="casePartyAliasEntity">The Case Party Alias Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCasePartyAliasEntity(CasePartyAliasEntity casePartyAliasEntity)
        {
            IRepository<CasePartyAlias> casePartyAliasRepository = new RepositoryImpl<CasePartyAlias>(applicationSession);
            casePartyAliasRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyAlias(casePartyAliasEntity));
        }

        /// <summary>
        /// Save the CasePartyAuthorisedOfficerDetailsEntity.
        /// </summary>
        /// <param name="casePartyAuthorisedOfficerDetailsEntity">The Case Party Authorised Officer Details Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCasePartyAuthorisedOfficerDetailEntity(CasePartyAuthorisedOfficerDetailsEntity casePartyAuthorisedOfficerDetailsEntity)
        {
            IRepository<CasePartyAuthorisedOfficerDetail> casePartyAuthorisedOfficerDetailRepository = new RepositoryImpl<CasePartyAuthorisedOfficerDetail>(applicationSession);
            casePartyAuthorisedOfficerDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyAuthorisedOfficerDetail(casePartyAuthorisedOfficerDetailsEntity));
        }

        internal void SaveOrUpdateCasePartyBailorAddressEntity(CasePartyBailorAddressEntity casePartyBailorAddressEntity)
        {
            IRepository<CasePartyBailorAddress> casePartyBailorAddressRepository = new RepositoryImpl<CasePartyBailorAddress>(applicationSession);
            casePartyBailorAddressRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyBailorAddress(casePartyBailorAddressEntity));
        }

        internal void SaveOrUpdateCasePartyBailorInfoEntity(CasePartyBailorInfoEntity casePartyBailorInfoEntity)
        {
            IRepository<CasePartyBailorInfo> casePartyBailorInfoRepository = new RepositoryImpl<CasePartyBailorInfo>(applicationSession);
            casePartyBailorInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyBailorInfo(casePartyBailorInfoEntity));
        }

        internal void SaveOrUpdateCasePartyCitizenshipEntity(CasePartyCitizenshipEntity casePartyCitizenshipEntity)
        {
            IRepository<CasePartyCitizenship> casePartyCitizenshipRepository = new RepositoryImpl<CasePartyCitizenship>(applicationSession);
            casePartyCitizenshipRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyCitizenship(casePartyCitizenshipEntity));
        }

        internal void SaveOrUpdateCasePartyCriminalInfoEntity(CasePartyCriminalInfoEntity casePartyCriminalInfoEntity)
        {
            IRepository<CasePartyCriminalInfo> casePartyCriminalInfoRepository = new RepositoryImpl<CasePartyCriminalInfo>(applicationSession);
            casePartyCriminalInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyCriminalInfo(casePartyCriminalInfoEntity));
        }

        internal void SaveOrUpdateCasePartyData(ICasePartyData iCaseParty)
        {
            lock (casePartyDataLock)
            {
                CasePartyData casePartyData = iCaseParty as CasePartyData;
                try
                {
                    if (casePartyData.CasePartyEntity != null)
                    {
                        this.SaveOrUpdateCasePartyEntity(casePartyData.CasePartyEntity);
                    }

                    if (casePartyData.CasePartyAddresses != null && casePartyData.CasePartyAddresses.Count > 0)
                    {

                        foreach (CasePartyAddressEntity cpAddressEntity in casePartyData.CasePartyAddresses)
                        {
                            this.SaveOrUpdateCasePartyAddressEntity(cpAddressEntity);
                        }
                    }
                    if (casePartyData.CasePartyAliases != null && casePartyData.CasePartyAliases.Count > 0)
                    {
                        foreach (CasePartyAliasEntity cpAliasEntity in casePartyData.CasePartyAliases)
                        {
                            this.SaveOrUpdateCasePartyAliasEntity(cpAliasEntity);
                        }
                    }
                    if (casePartyData.CasePartyAICDetails != null && casePartyData.CasePartyAICDetails.Count > 0)
                    {
                        foreach (CasePartyAICDetailsEntity cpAICDetailEntity in casePartyData.CasePartyAICDetails)
                        {
                            this.SaveOrUpdateCasePartyAICDetailsEntity(cpAICDetailEntity);
                            if (cpAICDetailEntity.CasePartyAICAddresses != null && cpAICDetailEntity.CasePartyAICAddresses.Count > 0)
                            {
                                foreach (CasePartyAICAddressEntity casePartyAICAddressEntity in cpAICDetailEntity.CasePartyAICAddresses)
                                {
                                    this.SaveOrUpdateCasePartyAICAddressEntity(casePartyAICAddressEntity);
                                }
                            }
                            if (cpAICDetailEntity.CasePartyAICAliases != null && cpAICDetailEntity.CasePartyAICAliases.Count > 0)
                            {
                                foreach (CasePartyAICAliasEntity casePartyAICAliasEntity in cpAICDetailEntity.CasePartyAICAliases)
                                {
                                    this.SaveOrUpdateCasePartyAICAliasEntity(casePartyAICAliasEntity);
                                }
                            }
                        }

                    }
                    if (casePartyData.CasePartyAuthorisedOfficerDetails != null && casePartyData.CasePartyAuthorisedOfficerDetails.Count > 0)
                    {
                        foreach (CasePartyAuthorisedOfficerDetailsEntity cpAuthorisedOfficerDetailsEntity in casePartyData.CasePartyAuthorisedOfficerDetails)
                        {
                            this.SaveOrUpdateCasePartyAuthorisedOfficerDetailEntity(cpAuthorisedOfficerDetailsEntity);
                        }
                    }

                    if (casePartyData.CasePartyVesselDetails != null && casePartyData.CasePartyVesselDetails.Count > 0)
                    {
                        foreach (CasePartyVesselDetailsEntity cpVesselDetailEntity in casePartyData.CasePartyVesselDetails)
                        {
                            this.SaveOrUpdateCasePartyVesselDetailEntity(cpVesselDetailEntity);
                        }
                    }

                    if (casePartyData.CaseSolicitors != null && casePartyData.CaseSolicitors.Count > 0)
                    {
                        foreach (CaseSolicitorEntity cpSolicitorEntity in casePartyData.CaseSolicitors)
                        {
                            this.SaveOrUpdateCaseSolicitorEntity(cpSolicitorEntity);
                        }
                    }

                    if (casePartyData.CasePartyLACDetail != null)
                    {
                        this.SaveOrUpdateCasePartyLACDetailEntity(casePartyData.CasePartyLACDetail);
                    }

                    if (casePartyData.CasePartyCitizenships != null && casePartyData.CasePartyCitizenships.Count > 0)
                    {
                        foreach (CasePartyCitizenshipEntity cpCitizenshipEntity in casePartyData.CasePartyCitizenships)
                        {
                            this.SaveOrUpdateCasePartyCitizenshipEntity(cpCitizenshipEntity);
                        }
                    }

                    if (casePartyData.CasePartyCriminalInfo != null)
                    {
                        this.SaveOrUpdateCasePartyCriminalInfoEntity(casePartyData.CasePartyCriminalInfo);
                    }

                    if (casePartyData.CasePartyBailorInfos != null && casePartyData.CasePartyBailorInfos.Count > 0)
                    {
                        foreach (CasePartyBailorInfoEntity cpBailorInfoEntity in casePartyData.CasePartyBailorInfos)
                        {
                            this.SaveOrUpdateCasePartyBailorInfoEntity(cpBailorInfoEntity);


                            if (cpBailorInfoEntity.CasePartyBailorAddresses != null && cpBailorInfoEntity.CasePartyBailorAddresses.Count > 0)
                            {
                                foreach (CasePartyBailorAddressEntity casePartyBailorAddressEntity in cpBailorInfoEntity.CasePartyBailorAddresses)
                                {
                                    this.SaveOrUpdateCasePartyBailorAddressEntity(casePartyBailorAddressEntity);
                                }
                            }
                        }
                    }
                    if (casePartyData.PartyCaseFileRefNumber != null && casePartyData.PartyCaseFileRefNumber.Count > 0)
                    {
                        foreach (PartyCaseFileRefNumberEntity partyCaseFileRefNumberEntity in casePartyData.PartyCaseFileRefNumber)
                        {
                            this.SaveOrUpdatePartyCaseFileRefNumberEntity(partyCaseFileRefNumberEntity);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Logger.Error("Error encountered at SaveOrUpdateCasePartyData", ex);
                    throw;
                }
            }
        }

        /// <summary>
        /// Save CasePartyEntity.
        /// </summary>
        /// <param name="casePartyEntity">The case party.</param>
        /// <returns></returns> 
        internal void SaveOrUpdateCasePartyEntity(CasePartyEntity casePartyEntity)
        {
            IRepository<CaseParty> casePartyRepository = new RepositoryImpl<CaseParty>(applicationSession);
            casePartyRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseParty(casePartyEntity));
        }

        /// <summary>
        /// Save the CasePartyVesselDetailsEntity.
        /// </summary>
        /// <param name="casePartyVesselDetailsEntity">The Case Party Vessel Details Entity</param>
        /// <returns></returns>
        internal void SaveOrUpdateCasePartyVesselDetailEntity(CasePartyVesselDetailsEntity casePartyVesselDetailsEntity)
        {
            IRepository<CasePartyVesselDetail> casePartyVesselDetailRepository = new RepositoryImpl<CasePartyVesselDetail>(applicationSession);
            casePartyVesselDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyVesselDetail(casePartyVesselDetailsEntity));
        }

        /// <summary>
        /// Save the CaseSolicitorEntity.
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCaseSolicitorEntity(CaseSolicitorEntity caseSolicitorEntity)
        {
            IRepository<CaseSolicitor> caseSolicitorRepository = new RepositoryImpl<CaseSolicitor>(applicationSession);
            caseSolicitorRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseSolicitor(caseSolicitorEntity));
        }

        /// <summary>
        /// Save the CaseSolicitorHistoryEntity.
        /// </summary>
        /// <param name="caseSolicitorHistoryEntity">The Case Solicitor History Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCaseSolicitorHistoryEntity(CaseSolicitorHistoryEntity caseSolicitorHistoryEntity)
        {
            IRepository<CaseSolicitorHistory> caseSolicitorHistoryRepository = new RepositoryImpl<CaseSolicitorHistory>(applicationSession);
            caseSolicitorHistoryRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseSolicitorHistory(caseSolicitorHistoryEntity));
        }

        /// <summary>
        /// Save CaseInfoEntity (for Testing).
        /// </summary>
        /// <param name="caseInfoEntity">The case info.</param>
        /// <returns></returns> 
        internal void SaveOrUpdateCopyCaseInfoEntity(CaseInfoEntity caseInfoEntity)
        {
            IRepository<CaseInfo> caseInfoRepository = new RepositoryImpl<CaseInfo>(applicationSession);
            caseInfoRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseInfo(caseInfoEntity));
        }

        /// <summary>
        /// Svae the casePartyAddressEntity(for Testing).
        /// </summary>
        /// <param name="casePartyAddressEntity">The Case Party Address Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCopyCasePartyAddressEntity(CasePartyAddressEntity casePartyAddressEntity)
        {
            IRepository<CasePartyAddress> casePartyAddressRepository = new RepositoryImpl<CasePartyAddress>(applicationSession);
            casePartyAddressRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyAddress(casePartyAddressEntity));
        }

        /// <summary>
        /// Save the CasePartyAICAddressEntity(for Testing).
        /// </summary>
        /// <param name="casePartyAICAddressEntity">Case Party AIC Address Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCopyCasePartyAICAddressEntity(CasePartyAICAddressEntity casePartyAICAddressEntity)
        {
            IRepository<CasePartyAICAddress> casePartyAICAddressRepository = new RepositoryImpl<CasePartyAICAddress>(applicationSession);
            casePartyAICAddressRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyAICAddress(casePartyAICAddressEntity));
        }

        /// <summary>
        /// Save the CasePartyAICAliasEntity (for Testing).
        /// </summary>
        /// <param name="casePartyAICAliasEntity">Case Party AIC Alias Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCopyCasePartyAICAliasEntity(CasePartyAICAliasEntity casePartyAICAliasEntity)
        {
            IRepository<CasePartyAICAlias> casePartyAICAliasRepository = new RepositoryImpl<CasePartyAICAlias>(applicationSession);
            casePartyAICAliasRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyAICAlias(casePartyAICAliasEntity));
        }

        /// <summary>
        /// Save the CasePartyAICDetailsEntity(for Testing).
        /// </summary>
        /// <param name="casePartyAICDetailsEntity">The Case Party AIC Details Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCopyCasePartyAICDetailsEntity(CasePartyAICDetailsEntity casePartyAICDetailsEntity)
        {
            IRepository<CasePartyAICDetail> casePartyAICDetailRepository = new RepositoryImpl<CasePartyAICDetail>(applicationSession);
            casePartyAICDetailRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyAICDetails(casePartyAICDetailsEntity));
        }

        /// <summary>
        /// Save the CasePartyAliasEntity(for Testing).
        /// </summary>
        /// <param name="casePartyAliasEntity">The Case Party Alias Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCopyCasePartyAliasEntity(CasePartyAliasEntity casePartyAliasEntity)
        {
            IRepository<CasePartyAlias> casePartyAliasRepository = new RepositoryImpl<CasePartyAlias>(applicationSession);
            casePartyAliasRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyAlias(casePartyAliasEntity));
        }

        /// <summary>
        /// Save the CasePartyAuthorisedOfficerDetailsEntity.
        /// </summary>
        /// <param name="casePartyAuthorisedOfficerDetailsEntity">The Case Party Authorised Officer Details Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCopyCasePartyAuthorisedOfficerDetailEntity(CasePartyAuthorisedOfficerDetailsEntity casePartyAuthorisedOfficerDetailsEntity)
        {
            IRepository<CasePartyAuthorisedOfficerDetail> casePartyAuthorisedOfficerDetailRepository = new RepositoryImpl<CasePartyAuthorisedOfficerDetail>(applicationSession);
            casePartyAuthorisedOfficerDetailRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyAuthorisedOfficerDetail(casePartyAuthorisedOfficerDetailsEntity));
        }

        internal void SaveOrUpdateCopyCasePartyCitizenshipEntity(CasePartyCitizenshipEntity casePartyCitizenshipEntity)
        {
            IRepository<CasePartyCitizenship> casePartyCitizenshipRepository = new RepositoryImpl<CasePartyCitizenship>(applicationSession);
            casePartyCitizenshipRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyCitizenship(casePartyCitizenshipEntity));
        }

        /// <summary>
        /// Save CasePartyData.
        /// </summary>
        /// <param name="iCaseParty">The case party data.</param>
        /// <returns></returns> 
        internal void SaveOrUpdateCopyCasePartyData(ICasePartyData iCaseParty)
        {
            lock (isCopyCasePartyLock)
            {
                CasePartyData casePartyData = iCaseParty as CasePartyData;
                try
                {
                    if (casePartyData.CasePartyEntity != null)
                    {
                        this.SaveOrUpdateCopyCasePartyEntity(casePartyData.CasePartyEntity);
                    }
                    #region -- Test Code

                    //IEnumerator<CasePartyAddressEntity> iCPAddressEnumerator = casePartyData.CasePartyAddresses.GetEnumerator();

                    //while (iCPAddressEnumerator.MoveNext())
                    //    this.SaveOrUpdateCopyCasePartyAddressEntity(iCPAddressEnumerator.Current);

                    #endregion Test Code

                    if (casePartyData.CasePartyAddresses != null && casePartyData.CasePartyAddresses.Count > 0)
                    {
                        foreach (CasePartyAddressEntity cpAddressEntity in casePartyData.CasePartyAddresses)
                        {
                            this.SaveOrUpdateCopyCasePartyAddressEntity(cpAddressEntity);
                        }
                    }
                    if (casePartyData.CasePartyAliases != null && casePartyData.CasePartyAliases.Count > 0)
                    {
                        foreach (CasePartyAliasEntity cpAliasEntity in casePartyData.CasePartyAliases)
                        {
                            this.SaveOrUpdateCopyCasePartyAliasEntity(cpAliasEntity);
                        }
                    }
                    if (casePartyData.CasePartyAICDetails != null && casePartyData.CasePartyAICDetails.Count > 0)
                    {
                        foreach (CasePartyAICDetailsEntity cpAICDetailEntity in casePartyData.CasePartyAICDetails)
                        {
                            this.SaveOrUpdateCopyCasePartyAICDetailsEntity(cpAICDetailEntity);

                            if (cpAICDetailEntity.CasePartyAICAddresses != null && cpAICDetailEntity.CasePartyAICAddresses.Count > 0)
                            {
                                foreach (CasePartyAICAddressEntity casePartyAICAddressEntity in cpAICDetailEntity.CasePartyAICAddresses)
                                {
                                    this.SaveOrUpdateCopyCasePartyAICAddressEntity(casePartyAICAddressEntity);
                                }
                            }
                            if (cpAICDetailEntity.CasePartyAICAliases != null && cpAICDetailEntity.CasePartyAICAliases.Count > 0)
                            {
                                foreach (CasePartyAICAliasEntity casePartyAICAliasEntity in cpAICDetailEntity.CasePartyAICAliases)
                                {
                                    this.SaveOrUpdateCopyCasePartyAICAliasEntity(casePartyAICAliasEntity);
                                }
                            }
                        }
                    }
                    if (casePartyData.CasePartyAuthorisedOfficerDetails != null && casePartyData.CasePartyAuthorisedOfficerDetails.Count > 0)
                    {
                        foreach (CasePartyAuthorisedOfficerDetailsEntity cpAuthorisedOfficerDetailsEntity in casePartyData.CasePartyAuthorisedOfficerDetails)
                        {
                            this.SaveOrUpdateCopyCasePartyAuthorisedOfficerDetailEntity(cpAuthorisedOfficerDetailsEntity);
                        }
                    }
                    if (casePartyData.CasePartyVesselDetails != null && casePartyData.CasePartyVesselDetails.Count > 0)
                    {
                        foreach (CasePartyVesselDetailsEntity cpVesselDetailEntity in casePartyData.CasePartyVesselDetails)
                        {
                            this.SaveOrUpdateCopyCasePartyVesselDetailEntity(cpVesselDetailEntity);
                        }
                    }
                    if (casePartyData.CaseSolicitors != null && casePartyData.CaseSolicitors.Count > 0)
                    {
                        foreach (CaseSolicitorEntity cpSolicitorEntity in casePartyData.CaseSolicitors)
                        {
                            this.SaveOrUpdateCopyCaseSolicitorEntity(cpSolicitorEntity);
                        }
                    }

                    if (casePartyData.CasePartyLACDetail != null)
                    {
                        this.SaveOrUpdateCopyCasePartyLACDetailEntity(casePartyData.CasePartyLACDetail);
                    }

                    if (casePartyData.CasePartyCitizenships != null && casePartyData.CasePartyCitizenships.Count > 0)
                    {
                        foreach (CasePartyCitizenshipEntity cpCitizenshipEntity in casePartyData.CasePartyCitizenships)
                        {
                            this.SaveOrUpdateCopyCasePartyCitizenshipEntity(cpCitizenshipEntity);
                        }
                    }

                    if (casePartyData.CasePartyCriminalInfo != null)
                    {
                        this.SaveOrUpdateCopyCasePartyCriminalInfoEntity(casePartyData.CasePartyCriminalInfo);
                    }

                    if (casePartyData.CasePartyBailorInfos != null && casePartyData.CasePartyBailorInfos.Count > 0)
                    {
                        foreach (CasePartyBailorInfoEntity casePartyBailorInfoEntity in casePartyData.CasePartyBailorInfos)
                        {
                            this.SaveOrUpdateCopyCasePartyBailorInfoEntity(casePartyBailorInfoEntity);

                            if (casePartyBailorInfoEntity.CasePartyBailorAddresses != null && casePartyBailorInfoEntity.CasePartyBailorAddresses.Count > 0)
                            {
                                foreach (CasePartyBailorAddressEntity casePartyBailorAddressEntity in casePartyBailorInfoEntity.CasePartyBailorAddresses)
                                {
                                    this.SaveOrUpdateCopyCasePartyBailorAddressEntity(casePartyBailorAddressEntity);
                                }
                            }
                        }
                    }

                    if (casePartyData.PartyCaseFileRefNumber != null && casePartyData.PartyCaseFileRefNumber.Count > 0)
                    {
                        foreach (PartyCaseFileRefNumberEntity partyCaseFileRefNumberEntity in casePartyData.PartyCaseFileRefNumber)
                        {
                            this.SaveOrUpdateCopyPartyCaseFileRefNumberEntity(partyCaseFileRefNumberEntity);
                            //SaveOrUpdatePartyCasefileRefNumberSP(partyCaseFileRefNumberEntity);
                        }
                    }
                }
                catch
                { throw; }
            }
        }

        /// <summary>
        /// Save CasePartyEntity(for Testing).
        /// </summary>
        /// <param name="casePartyEntity">The case party.</param>
        /// <returns></returns> 
        internal void SaveOrUpdateCopyCasePartyEntity(CasePartyEntity casePartyEntity)
        {
            IRepository<CaseParty> casePartyRepository = new RepositoryImpl<CaseParty>(applicationSession);
            casePartyRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseParty(casePartyEntity));
        }

        /// <summary>
        /// Save the CasePartyVesselDetailsEntity(for Testing).
        /// </summary>
        /// <param name="casePartyVesselDetailsEntity">The Case Party Vessel Details Entity</param>
        /// <returns></returns>
        internal void SaveOrUpdateCopyCasePartyVesselDetailEntity(CasePartyVesselDetailsEntity casePartyVesselDetailsEntity)
        {
            IRepository<CasePartyVesselDetail> casePartyVesselDetailRepository = new RepositoryImpl<CasePartyVesselDetail>(applicationSession);
            casePartyVesselDetailRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyVesselDetail(casePartyVesselDetailsEntity));
        }

        /// <summary>
        /// Save the CaseSolicitorEntity (for Testing).
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCopyCaseSolicitorEntity(CaseSolicitorEntity caseSolicitorEntity)
        {
            IRepository<CaseSolicitor> caseSolicitorRepository = new RepositoryImpl<CaseSolicitor>(applicationSession);
            caseSolicitorRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseSolicitor(caseSolicitorEntity));
        }

        /// <summary>
        /// Save the CaseSolicitorHistoryEntity (for Testing).
        /// </summary>
        /// <param name="caseSolicitorHistoryEntity">The Case Solicitor History Entity.</param>
        /// <returns></returns>
        internal void SaveOrUpdateCopyCaseSolicitorHistoryEntity(CaseSolicitorHistoryEntity caseSolicitorHistoryEntity)
        {
            IRepository<CaseSolicitorHistory> caseSolicitorHistoryRepository = new RepositoryImpl<CaseSolicitorHistory>(applicationSession);
            caseSolicitorHistoryRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseSolicitorHistory(caseSolicitorHistoryEntity));
        }

        //TODO:Need to Implement GEneric Method
        /// <summary>
        /// Save CriminalCasePartyData.
        /// </summary>
        /// <param name="iCaseParty">The case party data.</param>
        /// <returns></returns> 
        internal void SaveOrUpdateCopyCriminalCasePartyData(ICasePartyData iCaseParty)
        {
            CriminalCasePartyData criminalCasePartyData = iCaseParty as CriminalCasePartyData;

            if (criminalCasePartyData.ListCasePartyCriminalInfo != null && criminalCasePartyData.ListCasePartyCriminalInfo.Count > 0)
            {
                foreach (CasePartyCriminalInfoEntity casePartyCriminalInfoEntity in criminalCasePartyData.ListCasePartyCriminalInfo)
                {
                    this.SaveOrUpdateCopyCasePartyCriminalInfoEntity(casePartyCriminalInfoEntity);
                }
            }

            if (criminalCasePartyData.ListCasePartyBailorInfo != null && criminalCasePartyData.ListCasePartyBailorInfo.Count > 0)
            {
                foreach (CasePartyBailorInfoEntity casePartyBailorInfoEntity in criminalCasePartyData.ListCasePartyBailorInfo)
                {
                    this.SaveOrUpdateCopyCasePartyBailorInfoEntity(casePartyBailorInfoEntity);
                }
            }

            if (criminalCasePartyData.ListCasePartyBailorAddress != null && criminalCasePartyData.ListCasePartyBailorAddress.Count > 0)
            {
                foreach (CasePartyBailorAddressEntity casePartyBailorAddressEntity in criminalCasePartyData.ListCasePartyBailorAddress)
                {
                    this.SaveOrUpdateCopyCasePartyBailorAddressEntity(casePartyBailorAddressEntity);
                }
            }
        }

        /// <summary>
        /// Passes the rCLFId and get a list RCaseLawFirmEntity (for Testing).
        /// </summary>
        /// <param name="rCLFId">The R Case Law Firm Id."</param>
        /// <returns></returns>
        internal void SaveOrUpdateCopyLawFirmCaseFileRefNumberEntity(LawFirmCaseFileRefNumberEntity rCaseLawFirmEntity)
        {
            IRepository<LawFirmCaseFileRefNumber> lawFirmCaseFileRefNumberRepository = new RepositoryImpl<LawFirmCaseFileRefNumber>(applicationSession);
            lawFirmCaseFileRefNumberRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetLawFirmCaseFileRefNumber(rCaseLawFirmEntity));
        }

        /// <summary>
        /// Save RCaseLawFirmEntity (for Testing).
        /// </summary>
        /// <param name="rCaseLawFirmEntity">The R Case Law Firm Entity."</param>
        /// <returns></returns>
        internal void SaveOrUpdateCopyRCaseLawFirmEntity(RCaseLawFirmEntity rCaseLawFirmEntity)
        {
            IRepository<RCaseLawFirm> rCaseLawFirmRepository = new RepositoryImpl<RCaseLawFirm>(applicationSession);
            rCaseLawFirmRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetRCaseLawFirm(rCaseLawFirmEntity));
        }

        /// <summary>
        /// Save the RCaseSubmissionEntity (for Testing).
        /// </summary>
        /// <param name="rCaseSubmissionEntity">The R Case Submission Entity."</param>
        /// <returns></returns>
        internal void SaveOrUpdateCopyRCaseSubmissionEntity(RCaseSubmissionEntity rCaseSubmissionEntity)
        {
            IRepository<RCaseSubmission> rCaseSubmissionRepository = new RepositoryImpl<RCaseSubmission>(applicationSession);
            rCaseSubmissionRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetRCaseSubmission(rCaseSubmissionEntity));
        }

        //TODO:Need to Implement GEneric Method
        internal void SaveOrUpdateCriminalCasePartyData(ICasePartyData iCasePartyData)
        {
            CriminalCasePartyData criminalCasePartyData = iCasePartyData as CriminalCasePartyData;

            if (criminalCasePartyData.ListCasePartyCriminalInfo != null)
            {
                foreach (CasePartyCriminalInfoEntity cpCriminalInfoEntity in criminalCasePartyData.ListCasePartyCriminalInfo)
                {
                    this.SaveOrUpdateCasePartyCriminalInfoEntity(cpCriminalInfoEntity);
                }
            }

            if (criminalCasePartyData.ListCasePartyBailorInfo != null)
            {
                foreach (CasePartyBailorInfoEntity cpBailorInfoEntity in criminalCasePartyData.ListCasePartyBailorInfo)
                {
                    this.SaveOrUpdateCasePartyBailorInfoEntity(cpBailorInfoEntity);

                    if (cpBailorInfoEntity.CasePartyBailorAddresses != null)
                    {
                        foreach (CasePartyBailorAddressEntity cpBailorAddressEntity in cpBailorInfoEntity.CasePartyBailorAddresses)
                        {
                            this.SaveOrUpdateCasePartyBailorAddressEntity(cpBailorAddressEntity);
                        }
                    }
                }
            }
        }

        internal void SaveOrUpdateEntity<T>(T entityToSave)
        {
            IRepository<T> caseRepository = new RepositoryImpl<T>(applicationSession);
            caseRepository.SaveOrUpdate(entityToSave);
        }

        internal void SaveOrUpdateInMemoryEntity<T>(T entityToSave)
        {
            IRepository<T> caseRepository = new RepositoryImpl<T>(applicationSession);
            caseRepository.SaveOrUpdateCopy(entityToSave);
        }

        /// <summary>
        /// Passes the rCLFId and get a list RCaseLawFirmEntity.
        /// </summary>
        /// <param name="rCLFId">The R Case Law Firm Id."</param>
        /// <returns></returns>
        internal void SaveOrUpdateLawFirmCaseFileRefNumberEntity(LawFirmCaseFileRefNumberEntity rCaseLawFirmEntity)
        {
            IRepository<LawFirmCaseFileRefNumber> lawFirmCaseFileRefNumberRepository = new RepositoryImpl<LawFirmCaseFileRefNumber>(applicationSession);
            lawFirmCaseFileRefNumberRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetLawFirmCaseFileRefNumber(rCaseLawFirmEntity));
        }

        /// <summary>
        /// Save RCaseLawFirmEntity.
        /// </summary>
        /// <param name="rCaseLawFirmEntity">The R Case Law Firm Entity."</param>
        /// <returns></returns>
        internal void SaveOrUpdateRCaseLawFirmEntity(RCaseLawFirmEntity rCaseLawFirmEntity)
        {
            IRepository<RCaseLawFirm> rCaseLawFirmRepository = new RepositoryImpl<RCaseLawFirm>(applicationSession);
            rCaseLawFirmRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetRCaseLawFirm(rCaseLawFirmEntity));
        }

        /// <summary>
        /// Save the RCaseSubmissionEntity.
        /// </summary>
        /// <param name="rCaseSubmissionEntity">The R Case Submission Entity."</param>
        /// <returns></returns>
        internal void SaveOrUpdateRCaseSubmissionEntity(RCaseSubmissionEntity rCaseSubmissionEntity)
        {
            IRepository<RCaseSubmission> rCaseSubmissionRepository = new RepositoryImpl<RCaseSubmission>(applicationSession);
            rCaseSubmissionRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetRCaseSubmission(rCaseSubmissionEntity));
        }

        internal Type TypeMapper<T>()
        {
            if (typeof(T) == typeof(CaseInfoEntity))
                return typeof(CaseInfo);
            else if (typeof(T) == typeof(CasePartyEntity))
                return typeof(CaseParty);

            else if (typeof(T) == typeof(CasePartyAddressEntity))
                return typeof(CasePartyAddress);

            //else
            throw new Exception("Error in converting Domain to NHibernate Type. Parsing Type is not a valid for Case Mediator. " + typeof(T).FullName);
        }

        private void DeleteCaseOriginatingCase(DetachedCriteria detachedCriteria)
        {
            List<CaseOriginatingCase> listCaseOriginatingCase = GetCaseOriginatingCase(detachedCriteria);
            IRepository<CaseOriginatingCase> caseOriginatingCaseRepository = new RepositoryImpl<CaseOriginatingCase>(applicationSession);
            caseOriginatingCaseRepository.DeleteAll(listCaseOriginatingCase);
        }

        private void DeleteCaseParty(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseParty>()
                  .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            Repository<CaseParty>().DeleteAll(detachedCriteria);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the CasePartyAddress
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteCasePartyAddress(DetachedCriteria detachedCriteria)
        {
            List<CasePartyAddress> listCasePartyAddressToDelete = this.GetCasePartyAddress(detachedCriteria);
            IRepository<CasePartyAddress> casePartyAddressRepository = new RepositoryImpl<CasePartyAddress>(applicationSession);

            casePartyAddressRepository.DeleteAll(listCasePartyAddressToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the CasePartyAICAddress
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteCasePartyAICAddress(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyAICAddress> casePartyAICAddressRepository = new RepositoryImpl<CasePartyAICAddress>(applicationSession);
            List<CasePartyAICAddress> listCasePartyAICAddressToDelete = this.GetCasePartyAICAddress(detachedCriteria);

            casePartyAICAddressRepository.DeleteAll(listCasePartyAICAddressToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the CasePartyAICAlias
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteCasePartyAICAlias(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyAICAlias> casePartyAICAliasRepository = new RepositoryImpl<CasePartyAICAlias>(applicationSession);
            List<CasePartyAICAlias> listCasePartyAICAliasToDelete = this.GetCasePartyAICAlias(detachedCriteria);

            casePartyAICAliasRepository.DeleteAll(listCasePartyAICAliasToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the CasePartyAICDetail
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteCasePartyAICDetail(DetachedCriteria detachedCriteria)
        {
            List<CasePartyAICDetail> listCasePartyAICDetailToDelete = this.GetCasePartyAICDetail(detachedCriteria);
            IRepository<CasePartyAICDetail> casePartyAICDetailRepository = new RepositoryImpl<CasePartyAICDetail>(applicationSession);

            //Refactor - search NHibernate feature to solve this requirement (deleting child) in better way.
            //Delete childs data first if there are some.
            foreach (CasePartyAICDetail aicAddress in listCasePartyAICDetailToDelete)
            {
                if (aicAddress.CasePartyAICAddresses.Count > 0)
                {
                    this.DeleteCasePartyAICAddressEntity(aicAddress.AICID);
                }

                if (aicAddress.CasePartyAICAliases.Count > 0)
                {
                    this.DeleteCasePartyAICAliasEntity(aicAddress.AICID);
                }
            }

            //Delete the parents records finally.
            casePartyAICDetailRepository.DeleteAll(listCasePartyAICDetailToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the CasePartyAlias
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteCasePartyAlias(DetachedCriteria detachedCriteria)
        {
            List<CasePartyAlias> listCasePartyAliasToDelete = this.GetCasePartyAlias(detachedCriteria);
            IRepository<CasePartyAlias> casePartyAliasRepository = new RepositoryImpl<CasePartyAlias>(applicationSession);

            casePartyAliasRepository.DeleteAll(listCasePartyAliasToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the CasePartyAuthorisedOfficerDetail
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteCasePartyAuthorisedOfficerDetail(DetachedCriteria detachedCriteria)
        {
            List<CasePartyAuthorisedOfficerDetail> listCasePartyAuthorisedOfficerDetailToDelete = this.GetCasePartyAuthorisedOfficerDetail(detachedCriteria);
            IRepository<CasePartyAuthorisedOfficerDetail> casePartyAuthorisedOfficerDetailRepository = new RepositoryImpl<CasePartyAuthorisedOfficerDetail>(applicationSession);

            casePartyAuthorisedOfficerDetailRepository.DeleteAll(listCasePartyAuthorisedOfficerDetailToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the CasePartyCitizenship
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteCasePartyCitizenship(DetachedCriteria detachedCriteria)
        {
            List<CasePartyCitizenship> listCasePartyCitizenshipToDelete = this.GetCasePartyCitizenship(detachedCriteria);
            IRepository<CasePartyCitizenship> casePartyCitizenshipRepository = new RepositoryImpl<CasePartyCitizenship>(applicationSession);

            casePartyCitizenshipRepository.DeleteAll(listCasePartyCitizenshipToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the CasePartyVesselDetail
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteCasePartyVesselDetail(DetachedCriteria detachedCriteria)
        {
            List<CasePartyVesselDetail> listCasePartyVesselDetailToDelete = this.GetCasePartyVesselDetail(detachedCriteria);
            IRepository<CasePartyVesselDetail> casePartyVesselDetailRepository = new RepositoryImpl<CasePartyVesselDetail>(applicationSession);

            casePartyVesselDetailRepository.DeleteAll(listCasePartyVesselDetailToDelete);
        }

        private void DeleteCaseSolicitor(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseSolicitor>()
                  .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            Repository<CaseSolicitor>().DeleteAll(detachedCriteria);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the CaseSolicitor
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteCaseSolicitor(DetachedCriteria detachedCriteria)
        {
            List<CaseSolicitor> listCaseSolicitorToDelete = this.GetCaseSolicitor(detachedCriteria);
            IRepository<CaseSolicitor> caseSolicitorRepository = new RepositoryImpl<CaseSolicitor>(applicationSession);

            caseSolicitorRepository.DeleteAll(listCaseSolicitorToDelete);
        }

        private List<CaseInfo> GetAllCaseInfoEntity(DetachedCriteria detachedCriteria)
        {
            IRepository<CaseInfo> caseInfoRepository = new RepositoryImpl<CaseInfo>(applicationSession);
            return caseInfoRepository.GetAll(detachedCriteria) as List<CaseInfo>;
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
                Logger.Error("Get " + typeof(T).ToString() + ". Constructing the query criteria have some error.", e);
                throw;
            }

            return detachedCriteria;
        }

        /// <summary>
        /// Passes the caseInfoId andGets the CaseInfo
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        private CaseInfo GetCaseInfo(string caseInfoId)
        {
            IRepository<CaseInfo> caseInfoRepository = new RepositoryImpl<CaseInfo>(applicationSession);
            return caseInfoRepository.Get(Convert.ToInt64(caseInfoId));

        }

        private List<CaseOriginatingCase> GetCaseOriginatingCase(DetachedCriteria detachedCriteria)
        {
            IRepository<CaseOriginatingCase> caseOriginatingCaseRepository = new RepositoryImpl<CaseOriginatingCase>(applicationSession);
            return caseOriginatingCaseRepository.GetAll(detachedCriteria).ToList();
        }

        /// <summary>
        /// Passes the casePartyId andGets the CaseParty
        /// </summary>
        /// <param name="casePartyId">The case party id.</param>
        /// <returns></returns>
        private CaseParty GetCaseParty(string casePartyId)
        {
            IRepository<CaseParty> casePartyRepository = new RepositoryImpl<CaseParty>(applicationSession);
            return casePartyRepository.Get(casePartyId);
        }

        /// <summary>
        /// Passes the detachedCriteria and get the CaseParty
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate detached Criteria.</param>
        /// <returns></returns>
        private List<CaseParty> GetCaseParty(DetachedCriteria detachedCriteria)
        {
            IRepository<CaseParty> casePartyRepository = new RepositoryImpl<CaseParty>(applicationSession);
            return casePartyRepository.GetAll(detachedCriteria) as List<CaseParty>;
        }

        /// <summary>
        /// Passes the detachedCriteria and get the CasePartyAddress.
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate DetachedCriteria.</param>
        /// <returns></returns>
        private List<CasePartyAddress> GetCasePartyAddress(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyAddress> casePartyAddressRepository = new RepositoryImpl<CasePartyAddress>(applicationSession);
            return casePartyAddressRepository.GetAll(detachedCriteria) as List<CasePartyAddress>;
        }

        /// <summary>
        /// Passes the DetachedCriteria and get a list CasePartyAICAddress.
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate DetachedCriteria.</param>
        /// <returns></returns>
        private List<CasePartyAICAddress> GetCasePartyAICAddress(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyAICAddress> casePartyAICAddressRepository = new RepositoryImpl<CasePartyAICAddress>(applicationSession);
            return casePartyAICAddressRepository.GetAll(detachedCriteria) as List<CasePartyAICAddress>;
        }

        /// <summary>
        /// Passes the DetachedCriteria and get a list CasePartyAICAlias.
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate DetachedCriteria.</param>
        /// <returns></returns>
        private List<CasePartyAICAlias> GetCasePartyAICAlias(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyAICAlias> casePartyAICAliasRepository = new RepositoryImpl<CasePartyAICAlias>(applicationSession);
            return casePartyAICAliasRepository.GetAll(detachedCriteria) as List<CasePartyAICAlias>;
        }

        /// <summary>
        /// Passes the DetachedCriteria and get a list CasePartyAICDetail.
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate DetachedCriteria.</param>
        /// <returns></returns> 
        private List<CasePartyAICDetail> GetCasePartyAICDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyAICDetail> casePartyAICDetailRepository = new RepositoryImpl<CasePartyAICDetail>(applicationSession);
            return casePartyAICDetailRepository.GetAll(detachedCriteria) as List<CasePartyAICDetail>;
        }

        /// <summary>
        /// Passes the DetachedCriteria and get a list CasePartyAlias.
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate DetachedCriteria.</param>
        /// <returns></returns>
        private List<CasePartyAlias> GetCasePartyAlias(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyAlias> casePartyAliasRepository = new RepositoryImpl<CasePartyAlias>(applicationSession);
            return casePartyAliasRepository.GetAll(detachedCriteria) as List<CasePartyAlias>;
        }

        /// <summary>
        /// Passes the DetachedCriteria and get the CasePartyAuthorisedOfficerDetail.
        /// </summary>
        /// <param name="detachedCriteria">The Detached Criteria.</param>
        /// <returns></returns>
        private List<CasePartyAuthorisedOfficerDetail> GetCasePartyAuthorisedOfficerDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyAuthorisedOfficerDetail> casePartyAuthorisedOfficerDetailRepository = new RepositoryImpl<CasePartyAuthorisedOfficerDetail>(applicationSession);
            return casePartyAuthorisedOfficerDetailRepository.GetAll(detachedCriteria) as List<CasePartyAuthorisedOfficerDetail>;
        }

        /// <summary>
        /// Passes the DetachedCriteria and get a list CasePartyCitizenship.
        /// </summary>
        /// <param name="DetachedCriteria">The NHibernate DetachedCriteria.</param>
        /// <returns></returns>
        private List<CasePartyCitizenship> GetCasePartyCitizenship(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyCitizenship> casePartyCitizenshipRepository = new RepositoryImpl<CasePartyCitizenship>(applicationSession);
            return casePartyCitizenshipRepository.GetAll(detachedCriteria) as List<CasePartyCitizenship>;
        }

        private CasePartyCriminalInfo GetCasePartyCriminalInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyCriminalInfo> casePartyCriminalInfoRepository = new RepositoryImpl<CasePartyCriminalInfo>(applicationSession);
            return casePartyCriminalInfoRepository.Get(detachedCriteria) as CasePartyCriminalInfo;
        }

        private CasePartyCriminalInfo GetCasePartyCriminalInfoByCasePartyId(string casePartyId)
        {
            List<CasePartyCriminalInfo> listCasePartyCriminalInfo = GetListCasePartyCriminalInfoByCasePartyId(casePartyId);
            if (listCasePartyCriminalInfo != null && listCasePartyCriminalInfo.Count > 0)
                return listCasePartyCriminalInfo[0];
            else
                return null;
        }

        /// <summary>
        /// Passes the DetachedCriteria and get a list CasePartyVesselDetail.
        /// </summary>
        /// <param name="DetachedCriteria">The NHibernate DetachedCriteria.</param>
        /// <returns></returns>
        private List<CasePartyVesselDetail> GetCasePartyVesselDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyVesselDetail> casePartyVesselDetailRepository = new RepositoryImpl<CasePartyVesselDetail>(applicationSession);
            return casePartyVesselDetailRepository.GetAll(detachedCriteria) as List<CasePartyVesselDetail>;
        }

        /// <summary>
        /// Passes the DetachedCriteria and get a list CaseSolicitor.
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate DetachedCriteria.</param>
        /// <returns></returns>
        private List<CaseSolicitor> GetCaseSolicitor(DetachedCriteria detachedCriteria)
        {
            IRepository<CaseSolicitor> caseSolicitorRepository = new RepositoryImpl<CaseSolicitor>(applicationSession);
            return caseSolicitorRepository.GetAll(detachedCriteria) as List<CaseSolicitor>;
        }

        /// <summary>
        /// Passes the DetachedCriteria and get the CaseSolicitorHistory.
        /// </summary>
        /// <param name="DetachedCriteria">The NHibernate DetachedCriteria.</param>
        /// <returns></returns>
        private List<CaseSolicitorHistory> GetCaseSolicitorHistory(DetachedCriteria detachedCriteria)
        {
            IRepository<CaseSolicitorHistory> caseSolicitorHistoryRepository = new RepositoryImpl<CaseSolicitorHistory>(applicationSession);
            return caseSolicitorHistoryRepository.GetAll(detachedCriteria) as List<CaseSolicitorHistory>;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="iEnforcement"></param>
        /// <param name="fieldName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private DetachedCriteria GetDetachedCriteria<V>(Type iCase, string fieldName, V value, bool hasObsInd)
        {
            DetachedCriteria detachedCriteria = null;
            if (typeof(V).IsGenericType && typeof(V).GetGenericTypeDefinition() == typeof(Nullable<>) && value == null && hasObsInd)
            {
                detachedCriteria = DetachedCriteria.For(Type.GetType(iCase.AssemblyQualifiedName))
                                                                     .Add(Expression.IsNull(fieldName))
                                                                     .Add(Expression.Eq("ObsInd", "N"));

            }
            else if (typeof(V).IsGenericType && typeof(V).GetGenericTypeDefinition() == typeof(Nullable<>) && value == null && !hasObsInd)
            {
                detachedCriteria = DetachedCriteria.For(Type.GetType(iCase.AssemblyQualifiedName))
                                                                     .Add(Expression.IsNull(fieldName));
            }
            else if (hasObsInd)
            {
                detachedCriteria = DetachedCriteria.For(Type.GetType(iCase.AssemblyQualifiedName))
                                                                     .Add(Expression.Eq(fieldName, value))
                                                                     .Add(Expression.Eq("ObsInd", "N"));
            }
            else
            {
                detachedCriteria = DetachedCriteria.For(Type.GetType(iCase.AssemblyQualifiedName))
                                                                     .Add(Expression.Eq(fieldName, value));
            }

            if (detachedCriteria == null)
            {
                throw new Exception("Constructing the query criteria have some error.");
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

        private List<T> GetFromDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll(detachedCriteria) as List<T>;
        }

        private List<Hearing> GetHearing(DetachedCriteria detachedCriteria)
        {
            IRepository<Hearing> hearingRepository = new RepositoryImpl<Hearing>(applicationSession);
            return hearingRepository.GetAll(detachedCriteria) as List<Hearing>;
        }

        /// <summary>
        /// Passes the DetachedCriteria and get the LawFirmCaseFileRefNumber.
        /// </summary>
        /// <param name="DetachedCriteria">The NHibernate DetachedCriteria.</param>
        /// <returns></returns>
        private List<LawFirmCaseFileRefNumber> GetlawFirmCaseFileRefNumber(DetachedCriteria detachedCriteria)
        {
            IRepository<LawFirmCaseFileRefNumber> lawFirmCaseFileRefNumberRepository = new RepositoryImpl<LawFirmCaseFileRefNumber>(applicationSession);
            return lawFirmCaseFileRefNumberRepository.GetAll(detachedCriteria) as List<LawFirmCaseFileRefNumber>;
        }

        private List<CasePartyBailorAddress> GetListCasePartyBailorAddress(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyBailorAddress> casePartyBailorAddressRepository = new RepositoryImpl<CasePartyBailorAddress>(applicationSession);
            return casePartyBailorAddressRepository.GetAll(detachedCriteria) as List<CasePartyBailorAddress>;
        }

        private List<CasePartyBailorAddress> GetListCasePartyBailorAddressByCasePartyBailorInfoId(string casePartyBailorInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyBailorAddress))
                                                                            .Add(Expression.Eq("CasePartyBailorInfoId", casePartyBailorInfoId));

            List<CasePartyBailorAddress> listCasePartyBailorAddress = GetListCasePartyBailorAddress(detachedCriteria);
            return listCasePartyBailorAddress;
        }

        private List<CasePartyBailorAddress> GetListCasePartyBailorAddressByCasePartyId(string casePartyId)
        {
            List<CasePartyBailorInfo> casePartyBailorInfo = GetListCasePartyBailorInfoByCasePartyId(casePartyId);
            List<CasePartyBailorAddress> casePartyBailorAddress = new List<CasePartyBailorAddress>();
            //TODO : Include a NULL checker
            foreach (CasePartyBailorInfo cpbie in casePartyBailorInfo)
            {
                if (cpbie != null)
                {
                    foreach (CasePartyBailorAddress cpbae in GetListCasePartyBailorAddressByCasePartyBailorInfoId(cpbie.CasePartyBailorInfoId))
                        casePartyBailorAddress.Add(cpbae);
                }
            }

            if (casePartyBailorAddress != null && casePartyBailorAddress.Count > 0)
                return casePartyBailorAddress;
            else
                return null;
        }

        private List<CasePartyBailorAddressEntity> GetListCasePartyBailorAddressEntityByCasePartyBailorInfoId(string casePartyBailorInfoId)
        {
            List<CasePartyBailorAddress> listCasePartyBailorAddress = GetListCasePartyBailorAddressByCasePartyBailorInfoId(casePartyBailorInfoId);

            if (listCasePartyBailorAddress != null && listCasePartyBailorAddress.Count > 0)
            {
                return listCasePartyBailorAddress.Select(casePartyBailorAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyBailorAddressEntity(casePartyBailorAddress)).ToList();
            }
            else
            {
                return null;
            }
        }

        private List<CasePartyBailorInfo> GetListCasePartyBailorInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyBailorInfo> casePartyBailorInfoRepository = new RepositoryImpl<CasePartyBailorInfo>(applicationSession);
            return casePartyBailorInfoRepository.GetAll(detachedCriteria) as List<CasePartyBailorInfo>;
        }

        private List<CasePartyBailorInfo> GetListCasePartyBailorInfoByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyBailorInfo))
                                                                             .Add(Expression.Eq("CasePartyId", casePartyId));

            List<CasePartyBailorInfo> listCasePartyBailorInfo = GetListCasePartyBailorInfo(detachedCriteria);

            return listCasePartyBailorInfo;
        }

        private List<CasePartyCitizenship> GetListCasePartyCitizenship(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyCitizenship> casePartyCitizenshipRepository = new RepositoryImpl<CasePartyCitizenship>(applicationSession);
            return casePartyCitizenshipRepository.GetAll(detachedCriteria) as List<CasePartyCitizenship>;
        }

        private List<CasePartyCitizenship> GetListCasePartyCitizenshipByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyCitizenship))
                                                                            .Add(Expression.Eq("CasePartyId", casePartyId));

            List<CasePartyCitizenship> listCasePartyCitizenship = GetListCasePartyCitizenship(detachedCriteria);

            return listCasePartyCitizenship;
        }

        private List<CasePartyCriminalInfo> GetListCasePartyCriminalInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<CasePartyCriminalInfo> casePartyCriminalInfoRepository = new RepositoryImpl<CasePartyCriminalInfo>(applicationSession);
            return casePartyCriminalInfoRepository.GetAll(detachedCriteria) as List<CasePartyCriminalInfo>;
        }

        private List<CasePartyCriminalInfo> GetListCasePartyCriminalInfoByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CasePartyCriminalInfo))
                                                                            .Add(Expression.Eq("CasePartyId", casePartyId));

            List<CasePartyCriminalInfo> listCasePartyCriminalInfo = GetListCasePartyCriminalInfo(detachedCriteria);

            return listCasePartyCriminalInfo;
        }

        /// <summary>
        /// Passes the DetachedCriteria and get a list RCaseLawFirm.
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate DetachedCriteria."</param>
        /// <returns></returns>
        private List<RCaseLawFirm> GetRCaseLawFirm(DetachedCriteria detachedCriteria)
        {
            IRepository<RCaseLawFirm> rCaseLawFirmRepository = new RepositoryImpl<RCaseLawFirm>(applicationSession);
            return rCaseLawFirmRepository.GetAll(detachedCriteria) as List<RCaseLawFirm>;
        }

        /// <summary>
        /// Passes the DetachedCriteria and get a list RCaseSubmission.
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate DetachedCriteria."</param>
        /// <returns></returns>
        private List<RCaseSubmission> GetRCaseSubmission(DetachedCriteria detachedCriteria)
        {
            IRepository<RCaseSubmission> rCaseSubmissionRepository = new RepositoryImpl<RCaseSubmission>(applicationSession);
            return rCaseSubmissionRepository.GetAll(detachedCriteria) as List<RCaseSubmission>;
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

        private void SaveOrUpdateCasePartyLACDetailEntity(CasePartyLACDetailEntity casePartyLACDetailEntity)
        {
            IRepository<CasePartyLACDetail> casePartyLACDetailRepository = new RepositoryImpl<CasePartyLACDetail>(applicationSession);
            casePartyLACDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyLACDetail(casePartyLACDetailEntity));
        }

        //TODO:Need to Implement GEneric Method
        private void SaveOrUpdateCasePartyLACDetailHistoryEntity(CasePartyLACDetailHistoryEntity casePartyLACDetailHistoryEntity)
        {
            IRepository<CasePartyLACDetailsHistory> casePartyLACDetailsHistoryRepository = new RepositoryImpl<CasePartyLACDetailsHistory>(applicationSession);
            casePartyLACDetailsHistoryRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyLACDetailsHistory(casePartyLACDetailHistoryEntity));
        }

        //TODO:Need to Implement GEneric Method
        //TODO:Need to Implement GEneric Method
        private void SaveOrUpdateCopyCasePartyBailorAddressEntity(CasePartyBailorAddressEntity casePartyBailorAddressEntity)
        {
            IRepository<CasePartyBailorAddress> casePartyBailorAddressRepository = new RepositoryImpl<CasePartyBailorAddress>(applicationSession);
            casePartyBailorAddressRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyBailorAddress(casePartyBailorAddressEntity));
        }

        //TODO:Need to Implement GEneric Method
        //TODO:Need to Implement GEneric Method
        private void SaveOrUpdateCopyCasePartyBailorInfoEntity(CasePartyBailorInfoEntity casePartyBailorInfoEntity)
        {
            IRepository<CasePartyBailorInfo> casePartyBailorInfoRepository = new RepositoryImpl<CasePartyBailorInfo>(applicationSession);
            casePartyBailorInfoRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyBailorInfo(casePartyBailorInfoEntity));
        }

        //TODO:Need to Implement GEneric Method
        //TODO:Need to Implement GEneric Method
        private void SaveOrUpdateCopyCasePartyCriminalInfoEntity(CasePartyCriminalInfoEntity casePartyCriminalInfoEntity)
        {
            IRepository<CasePartyCriminalInfo> casePartyCriminalInfoRepository = new RepositoryImpl<CasePartyCriminalInfo>(applicationSession);
            casePartyCriminalInfoRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyCriminalInfo(casePartyCriminalInfoEntity));
        }

        private void SaveOrUpdateCopyCasePartyLACDetailEntity(CasePartyLACDetailEntity casePartyLACDetailEntity)
        {
            IRepository<CasePartyLACDetail> casePartyLACDetailRepository = new RepositoryImpl<CasePartyLACDetail>(applicationSession);
            casePartyLACDetailRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyLACDetail(casePartyLACDetailEntity));
        }

        //TODO:Need to Implement GEneric Method
        private void SaveOrUpdateCopyCasePartyLACDetailHistoryEntity(CasePartyLACDetailHistoryEntity casePartyLACDetailHistoryEntity)
        {
            IRepository<CasePartyLACDetailsHistory> casePartyLACDetailsHistoryRepository = new RepositoryImpl<CasePartyLACDetailsHistory>(applicationSession);
            casePartyLACDetailsHistoryRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCasePartyLACDetailsHistory(casePartyLACDetailHistoryEntity));
        }
        
        /// <summary>
        /// Save Or Update Copy PartyCaseFileRefNumberEntity
        /// </summary>
        /// <param name="PartyCaseFileRefNumberEntity"></param>
        private void SaveOrUpdateCopyPartyCaseFileRefNumberEntity(PartyCaseFileRefNumberEntity partyCaseFileRefNumberEntity)
        {
            IRepository<PartyCaseFileRefNumber> partyCaseFileRefNumberRepository = new RepositoryImpl<PartyCaseFileRefNumber>(applicationSession);
            partyCaseFileRefNumberRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetPartyCaseFileRefNumber(partyCaseFileRefNumberEntity));
        }

        internal List<CaseInfoEntity> GetListCaseInfoByCaseType(string caseType)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseInfo>()
                .Add(Expression.Eq("MCaseType.CaseTypeCode", caseType));

            List<CaseInfo> listCaseInfo = GetFromDetachedCriteria<CaseInfo>(detachedCriteria);
            if (listCaseInfo != null && listCaseInfo.Count > 0)
            {
                return listCaseInfo.Select(caseInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseInfoEntity(caseInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<CasePartyLACDetailEntity> GetCasePartyLACDetailByLacInfoId(string LacInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CasePartyLACDetail>()
                .Add(Expression.Eq("LACInfoId", LacInfoId));

            List<CasePartyLACDetail> listCasePartyLACDetail = GetFromDetachedCriteria<CasePartyLACDetail>(detachedCriteria);
            if (listCasePartyLACDetail != null && listCasePartyLACDetail.Count > 0)
            {
                return listCasePartyLACDetail.Select(casePartyLACDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCasePartyLACDetailEntity(casePartyLACDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RCaseLinkedEntity> GetListRCaseLinkedFromGroupId(string linkGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RCaseLinked))
                                                                             .Add(Expression.Eq("LinkGroupId", linkGroupId));

            List<RCaseLinked> listRCaseLinked = GetFromDetachedCriteria<RCaseLinked>(detachedCriteria);

            if (listRCaseLinked != null && listRCaseLinked.Count > 0)
            {
                return listRCaseLinked.Select(rCaseLinked => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseLinkedEntity(rCaseLinked)).ToList();
            }
            else
            {
                return null;
            }
        }
        internal RCaseTransferEntity GetRCaseTransferByPK(string rCaseTransferId)
        {
            IRepository<RCaseTransfer> rCaseTransferRepository = new RepositoryImpl<RCaseTransfer>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetRCaseTransferEntity(rCaseTransferRepository.Get(rCaseTransferId));

        }

        internal List<RCaseConsolidateEntity> GetListRCaseConsolidate(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RCaseConsolidate>()
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<RCaseConsolidate> listRCaseConsolidate = GetFromDetachedCriteria<RCaseConsolidate>(detachedCriteria);
            if (listRCaseConsolidate != null && listRCaseConsolidate.Count > 0)
            {
                return listRCaseConsolidate.Select(rcaseConsolidate => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                        CaseMapper.GetRCaseConsolidateEntity(rcaseConsolidate)).ToList();
            }
            else
            {
                return null;
            }

        }

        internal void SaveOrUpdateRCaseConsolidateSP(ICaseEntity iCaseEntity)
        {
            Logger.Debug("Flushing Session to Sync With DB");
            applicationSession.Flush();
            Logger.Debug("Flushing Session Completed");

            Logger.Debug("SaveOrUpdateRCaseConsolidateSP");
            try
            {
                RCaseConsolidateEntity rCaseConsolidateEntity = (RCaseConsolidateEntity)iCaseEntity;

                RCaseConsolidate rCaseConsolidate = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetRCaseConsolidate(rCaseConsolidateEntity);


                applicationSession.GetNamedQuery("SaveOrUpdateRCaseConsolidate")
                    .SetParameter("CaseInfoID", rCaseConsolidate.CaseInfoId)
                     .SetParameter("ConCaseInfoID", rCaseConsolidate.ConCaseInfoID)
                      .SetParameter("ConsolidateDate", rCaseConsolidate.ConsolidateDate)
                       .SetParameter("ObsInd", rCaseConsolidate.ObsInd)
                        .SetParameter("LastModifiedBy", rCaseConsolidate.LastModifiedBy)
                         .SetParameter("LastModifiedDate", rCaseConsolidate.LastModifiedDate)
                          .ExecuteUpdate();

                Logger.Debug("SaveOrUpdateDocumentInfoSP Ended");

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateRCaseConsolidateSP", ex);
                throw ex;
            }
        }
        #endregion Methods


        internal void SaveRCaseLinked(RCaseLinkedEntity rCaseLinkedEntity)
        {
            Logger.Debug("Flushing Session to Sync With DB");
            applicationSession.Flush();
            Logger.Debug("Flushing Session Completed");

            Logger.Debug("SaveRCaseLinkedSP");
            try
            {
                if (rCaseLinkedEntity != null)
                {
                    RCaseLinked rCaseLinked = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetRCaseLinked(rCaseLinkedEntity);

                    applicationSession.GetNamedQuery("Procedure")
                        .SetParameter("LinkGroupID", rCaseLinked.LinkGroupId)
                        .SetParameter("CaseInfoID", rCaseLinked.CaseInfoId)
                        .SetParameter("LinkedDate", rCaseLinked.LinkedDate)
                        .SetParameter("CrossCourtInd", rCaseLinked.CrossCourtInd)
                        .SetParameter("ObsInd", rCaseLinked.ObsInd)
                        .SetParameter("LastModifiedBy", rCaseLinked.LastModifiedBy)
                        .ExecuteUpdate();

                    Logger.Debug("SaveRCaseLinkedSP Ended");
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveRCaseLinked", ex);
                throw ex;
            }
        }

        internal RLawFirmSolicitorsEntity GetRLawFirmSolicitorsEntity(long solicitorId, string lFID)
        {
            RLawFirmSolicitors rlawFirm = new RLawFirmSolicitors { LFID = lFID, SolicitorID = solicitorId };

            IRepository<RLawFirmSolicitors> repository = new RepositoryImpl<RLawFirmSolicitors>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
                .CaseMapper.GetRLawFirmSolicitorsEntity(repository.Get(rlawFirm));
        }

        internal void SaveOrUpdateRLawFirmSolicitor(RLawFirmSolicitorsEntity rLawFirmSolicitorEntity)
        {
            Logger.Debug("Flushing Session to Sync With DB");
            applicationSession.Flush();
            Logger.Debug("Flushing Session Completed");
            try
            {
                if (rLawFirmSolicitorEntity != null)
                {
                    RLawFirmSolicitors rLawFirmSolicitors = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetRLawFirmSolicitors(rLawFirmSolicitorEntity);

                    applicationSession.GetNamedQuery("SaveOrUpdateRLawFirmSolicitorProcedure")
                   .SetParameter("LastModifiedBy", rLawFirmSolicitors.LastModifiedBy)
                      .SetParameter("LastModifiedDate", rLawFirmSolicitors.LastModifiedDate)
                      .SetParameter("LFID", rLawFirmSolicitors.LFID)
                      .SetParameter("SolicitorID", rLawFirmSolicitors.SolicitorID)
                      .SetParameter("StartDate", rLawFirmSolicitors.StartDate)
                      .SetParameter("PCID", rLawFirmSolicitors.PCID)
                      .SetParameter("DSGCode", rLawFirmSolicitors.MDesignation != null ? rLawFirmSolicitors.MDesignation.DSGCode : null)
                      .SetParameter("UserID", rLawFirmSolicitors.UserID)
                      .ExecuteUpdate();
                }
            }
            catch (Exception ex)
            {

                Logger.Error("Error encountered at SaveOrUpdateRLawFirmSolicitor", ex);
                throw;
            }
           
        }

        internal void SaveOrUpdateRLawFirmSolicitorHistory(RLawFirmSolicitorHistoryEntity rLawFirmSolicitorHistoryEntity)
        {
            Logger.Debug("Flushing Session to Sync With DB");
            applicationSession.Flush();
            Logger.Debug("Flushing Session Completed");
            try
            {
                if (rLawFirmSolicitorHistoryEntity != null)
                {
                    RLawFirmSolicitorHistory rLawFirmSolicitorHistory = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetRLawFirmSolicitorHistory(rLawFirmSolicitorHistoryEntity);

                    applicationSession.GetNamedQuery("SaveOrUpdateRLawFirmSolicitorHistoryProcedure")
                   .SetParameter("LastModifiedBy", rLawFirmSolicitorHistory.LastModifiedBy)
                      .SetParameter("LastModifiedDate", rLawFirmSolicitorHistory.LastModifiedDate)
                      .SetParameter("LFID", rLawFirmSolicitorHistory.LFID)
                      .SetParameter("SolicitorID", rLawFirmSolicitorHistory.SolicitorId)
                      .SetParameter("StartDate", rLawFirmSolicitorHistory.StartDate)
                      .SetParameter("EndDate", rLawFirmSolicitorHistory.EndDate)
                      .ExecuteUpdate();
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateRLawFirmSolicitorHistory", ex);
                throw;
            }
            
        }

        internal void DeleteRLawFirmSolicitors(long SolicitorId, string lFID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RLawFirmSolicitors>()
                                        .Add(Expression.Eq("SolicitorID", SolicitorId))
                                        .Add(Expression.Eq("LFID", lFID));


            Repository<RLawFirmSolicitors>().DeleteAll(detachedCriteria);
        }

        internal void DeleteCasePartyCitizenshipByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CasePartyCitizenship>()
                    .Add(Expression.Eq("CasePartyId", casePartyId));

            Repository<CasePartyCitizenship>().DeleteAll(detachedCriteria);
        }

        internal void DeleteCasePartyBailorAddressByCasePartyBailorInfoId(string casePartyBailorInfoId)
        {
            CasePartyBailorAddress casePartyBailorAddress = Repository<CasePartyBailorAddress>().Get(casePartyBailorInfoId);
            if (casePartyBailorAddress != null)
            {
                Repository<CasePartyBailorAddress>().Delete(casePartyBailorAddress);
            }
        }

        internal List<HearingCoramEntity> GetListHearingCoramByHrgId(long hrgId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<HearingCoram>()
                .Add(Expression.Eq("HRGId",hrgId));

            List<HearingCoram> listHearingCoram = GetFromDetachedCriteria<HearingCoram>(detachedCriteria);
            if (listHearingCoram != null && listHearingCoram.Count > 0)
            {
                return listHearingCoram.Select(hearingCoram => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                        CaseMapper.GetHearingCoramEntity(hearingCoram)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<InterimCasePartyStatusEntity> GetListInterimCasePartyStatusEntityByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<InterimCasePartyStatus>()
               .Add(Expression.Eq("DocId", docId));

            List<InterimCasePartyStatus> listInterimCasePartyStatus = GetFromDetachedCriteria<InterimCasePartyStatus>(detachedCriteria);
            if (listInterimCasePartyStatus != null && listInterimCasePartyStatus.Count > 0)
            {
                return listInterimCasePartyStatus.Select(interimCasePartyStatus => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                        CaseMapper.GetInterimCasePartyStatusEntity(interimCasePartyStatus)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<HearingOutcomeFlagEntity> GetListHearingOutcomeFlagByHRGId(long hrgId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<HearingOutcomeFlag>()
                 .Add(Expression.Eq("HRGID", hrgId));

            List<HearingOutcomeFlag> listHearingOutcomeFlag = GetFromDetachedCriteria<HearingOutcomeFlag>(detachedCriteria);
            if (listHearingOutcomeFlag != null && listHearingOutcomeFlag.Count > 0)
            {
                return listHearingOutcomeFlag.Select(hearingOutcomeFlag => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                      CaseMapper.GetHearingOutcomeFlagEntity(hearingOutcomeFlag)).ToList();
            }
            else
            {
                return null;
            }
        }


        internal void DeleteCasePartyLACDetailByCasePartyId(string casePartyId)
        {
            CaseParty cp = new CaseParty { CasePartyId = casePartyId };

            DetachedCriteria detachedCriteria = DetachedCriteria.For<CasePartyLACDetail>()
                    .Add(Expression.Eq("CaseParty", cp));

            Repository<CasePartyLACDetail>().DeleteAll(detachedCriteria);
        }

        internal void DeleteLawFirmCaseFileRefNumber(string LFCFRNId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<LawFirmCaseFileRefNumber>()
                  .Add(Expression.Eq("LFCFRNId", LFCFRNId));

            Repository<LawFirmCaseFileRefNumber>().DeleteAll(detachedCriteria);
        }

        internal TransferOrderOfCourtEntity GetTransferOrderOfCourt(string transferOrderOfCourtId)
        {
            IRepository<TransferOrderOfCourt> transferOrderOfCourtRepository = new RepositoryImpl<TransferOrderOfCourt>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetTransferOrderOfCourtEntity(transferOrderOfCourtRepository.Get(transferOrderOfCourtId));

        }

        /// <summary>
        /// Saves the or update party case file reference number entity.
        /// </summary>
        /// <param name="partyCaseFileRefNumberEntity">The party case file reference number entity.</param>
        private void SaveOrUpdatePartyCaseFileRefNumberEntity(PartyCaseFileRefNumberEntity partyCaseFileRefNumberEntity)
        {
            IRepository<PartyCaseFileRefNumber> partyCaseFileRefNumberRepository = new RepositoryImpl<PartyCaseFileRefNumber>(applicationSession);
            partyCaseFileRefNumberRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetPartyCaseFileRefNumber(partyCaseFileRefNumberEntity));
        }

        /// <summary>
        /// Save the RCaseSubmissionEntity (for Testing).
        /// </summary>
        /// <param name="rCaseSubmissionEntity">The R Case Submission Entity."</param>
        /// <returns></returns>
        internal void SaveOrUpdateRCaseTransferEntity(RCaseTransferEntity rCaseTransferEntity)
        {
            IRepository<RCaseTransfer> rCaseTransfer = new RepositoryImpl<RCaseTransfer>(applicationSession);
            rCaseTransfer.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetRCaseTransfer(rCaseTransferEntity));
        }

        /// <summary>
        /// Gets the list party case file reference number entity by case party id and Case info id.
        /// </summary>
        /// <param name="casePartyId">The case party identifier.</param>
        /// <param name="CaseInfoId">The CaseInfoId.</param>
        /// <returns></returns>
        internal List<PartyCaseFileRefNumberEntity> GetListPartyCaseFileRefNumberByCaseInfoIDAndPartyID(string casePartyId, string caseInfoId, string lFID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PartyCaseFileRefNumber))
                                                .Add(Expression.Eq("CasePartyID", casePartyId))
                                                .Add(Expression.Eq("CaseInfoID", Convert.ToInt64(caseInfoId)))
                                                .Add(string.IsNullOrEmpty(lFID) ? Expression.IsNull("LFID"): Expression.Eq("LFID", lFID));
            List<PartyCaseFileRefNumber> listPartyCaseFileRefNumber = GetListPartyCaseFileRefNumber(detachedCriteria);

            if (listPartyCaseFileRefNumber != null && listPartyCaseFileRefNumber.Count > 0)
            {
                return listPartyCaseFileRefNumber.Select(partyCaseFileRefNumber => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetPartyCaseFileRefNumberEntity(partyCaseFileRefNumber)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal void DeletePartyCaseFileRefNumberByCasePartyID(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<PartyCaseFileRefNumber>()
                  .Add(Expression.Eq("CasePartyID", casePartyId));

            Repository<PartyCaseFileRefNumber>().DeleteAll(detachedCriteria);
        }

        internal void SaveOrUpdatePartyCasefileRefNumberSP(PartyCaseFileRefNumberEntity partyCaseFileRefNumberEntity)
        { 
            Logger.Debug("----SaveOrUpdatePartyCasefileReferenceNumberSP----");
            try
            {
                if (partyCaseFileRefNumberEntity != null)
                {
                    string obsInd = null;
                    if (partyCaseFileRefNumberEntity.ObsInd == null)
                    {
                        obsInd = null;
                    }
                    else if (Domain.YesNo.N == partyCaseFileRefNumberEntity.ObsInd)
                    {
                        obsInd = "N";
                    }
                    else
                    {
                        obsInd = "Y";
                    }
                    
                    applicationSession.GetNamedQuery("SaveOrUpdatePartyCaseFileRefNumber")
                        .SetParameter("PartyCaseFileRefNumberId", partyCaseFileRefNumberEntity.PartyCaseFileRefNumberId)
                        .SetParameter("CaseInfoID", Convert.ToInt64(partyCaseFileRefNumberEntity.CaseInfoID))
                        .SetParameter("CasePartyID", partyCaseFileRefNumberEntity.CasePartyID)
                        .SetParameter("LFFileRefNumber", partyCaseFileRefNumberEntity.LFFileRefNumber)
                        .SetParameter("ObsInd", obsInd)
                        .SetParameter("LastModifiedBy", partyCaseFileRefNumberEntity.LastModifiedBy)
                        .SetParameter("LastModifiedDate", partyCaseFileRefNumberEntity.LastModifiedDate)
                        .SetParameter("LFID", partyCaseFileRefNumberEntity.LFID)
                        .ExecuteUpdate();
                    Logger.Debug("SaveOrUpdatePartyCasefileRefNumberSP Ended");
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdatePartyCasefileRefNumberSP", ex);
                throw;
            }
        }
    }
}