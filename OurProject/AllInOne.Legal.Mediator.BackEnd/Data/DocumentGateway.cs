namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;
    using System.Collections;

    internal class DocumentGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DocumentGateway));

        private ISession applicationSession;
        private object doCasePartyLock = new object();
        SQLGatewayService sqlGateway = null;
        #endregion Fields

        #region Constructors

        internal DocumentGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

            sqlGateway = new SQLGatewayService();
            //MappingToDTO mappingToDTO = new MappingToDTO();
            //mappingToDTO.MapAll();

            //MappingToDomain mappingToDomain = new MappingToDomain();
            //mappingToDomain.MapAll();
        }

        #endregion Constructors

        #region Methods

        internal void DeleteDocCaseParty(string caseInfoId, string dcpId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCaseParty))
                 .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                 .Add(Expression.Eq("DCPID", dcpId));
            IRepository<DocCaseParty> docCasePartyRepository = new RepositoryImpl<DocCaseParty>(applicationSession);
            docCasePartyRepository.DeleteAll(docCasePartyRepository.GetAll(detachedCriteria).ToList());
        }

        internal void DeleteDocCasePartyAddress(string caseInfoId, string dcpId)
        {
            var subCriteria = DetachedCriteria.For(typeof(DocCaseParty));
            subCriteria.SetProjection(Projections.Property("DCPID")).Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                                                                     .Add(Expression.Eq("DCPID", dcpId));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(DocCasePartyAddress)).Add(Subqueries.PropertyIn("DCPID", subCriteria));

            IRepository<DocCasePartyAddress> docCasePartyAddressRepository = new RepositoryImpl<DocCasePartyAddress>(applicationSession);
            List<DocCasePartyAddress> listDocCasePartyAddress = docCasePartyAddressRepository.FindAll(iCriterion).ToList();
            docCasePartyAddressRepository.DeleteAll(listDocCasePartyAddress);
        }

        internal void DeleteDocCasePartyAICAddress(string caseInfoId, string dcpId)
        {
            var subCriteria = DetachedCriteria.For(typeof(DocCaseParty));
            subCriteria.SetProjection(Projections.Property("DCPID")).Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                                                                     .Add(Expression.Eq("DCPID", dcpId));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(DocCasePartyAICDetail)).Add(Subqueries.PropertyIn("DCPID", subCriteria));

            IRepository<DocCasePartyAICDetail> docCasePartyAICDetailRepository = new RepositoryImpl<DocCasePartyAICDetail>(applicationSession);
            List<DocCasePartyAICDetail> listDocCasePartyAICDetail = docCasePartyAICDetailRepository.FindAll(iCriterion).ToList();
            List<DocCasePartyAICAddress> listDocCasePartyAICAddress = new List<DocCasePartyAICAddress>();
            if (listDocCasePartyAICAddress != null && listDocCasePartyAICAddress.Count > 0)
            {
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAICAddress))
                    .Add(Expression.Eq("DCPAICID", listDocCasePartyAICAddress[0].DCPAICID));
                IRepository<DocCasePartyAICAddress> docCasePartyAICAddressRepository = new RepositoryImpl<DocCasePartyAICAddress>(applicationSession);
                listDocCasePartyAICAddress = docCasePartyAICAddressRepository.GetAll(detachedCriteria).ToList();
                docCasePartyAICAddressRepository.DeleteAll(listDocCasePartyAICAddress);
            }
        }

        internal void DeleteDocCasePartyAICAddressEntity(string aICID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAICAddress))
                                                                             .Add(Expression.Eq("AICID", aICID));

            this.DeleteDocCasePartyAICAddress(detachedCriteria);
        }

        internal void DeleteDocCasePartyAICAlias(string caseInfoId, string dcpId)
        {
            var subCriteria = DetachedCriteria.For(typeof(DocCaseParty));
            subCriteria.SetProjection(Projections.Property("DCPID")).Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                                                                     .Add(Expression.Eq("DCPID", dcpId));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(DocCasePartyAICDetail)).Add(Subqueries.PropertyIn("DCPID", subCriteria));

            IRepository<DocCasePartyAICDetail> docCasePartyAICDetailRepository = new RepositoryImpl<DocCasePartyAICDetail>(applicationSession);
            List<DocCasePartyAICDetail> listDocCasePartyAICDetail = docCasePartyAICDetailRepository.FindAll(iCriterion).ToList();
            List<DocCasePartyAICAlias> listDocCasePartyAICAlias = new List<DocCasePartyAICAlias>();
            if (listDocCasePartyAICDetail != null && listDocCasePartyAICDetail.Count > 0)
            {
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAICAlias))
                    .Add(Expression.Eq("DCPAICID", listDocCasePartyAICDetail[0].DCPAICID));
                IRepository<DocCasePartyAICAlias> docCasePartyAICAliasRepository = new RepositoryImpl<DocCasePartyAICAlias>(applicationSession);
                listDocCasePartyAICAlias = docCasePartyAICAliasRepository.GetAll(detachedCriteria).ToList();
                docCasePartyAICAliasRepository.DeleteAll(listDocCasePartyAICAlias);
            }
        }

        internal void DeleteDocCasePartyAICAliasEntity(string aICID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAICAlias))
                                                                             .Add(Expression.Eq("AICID", aICID));

            this.DeleteDocCasePartyAICAlias(detachedCriteria);
        }

        internal void DeleteDocCasePartyAICDetails(string caseInfoId, string dcpId)
        {
            var subCriteria = DetachedCriteria.For(typeof(DocCaseParty));
            subCriteria.SetProjection(Projections.Property("DCPID")).Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                                                                     .Add(Expression.Eq("DCPID", dcpId));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(DocCasePartyAICDetail)).Add(Subqueries.PropertyIn("DCPID", subCriteria));

            IRepository<DocCasePartyAICDetail> docCasePartyAICDetailRepository = new RepositoryImpl<DocCasePartyAICDetail>(applicationSession);
            List<DocCasePartyAICDetail> listDocCasePartyAICDetail = docCasePartyAICDetailRepository.FindAll(iCriterion).ToList();
            docCasePartyAICDetailRepository.DeleteAll(listDocCasePartyAICDetail);
        }

        internal void DeleteDocCasePartyBailorAddressByDCPId(string dCPId)
        {
            var subCriteria = DetachedCriteria.For(typeof(DocCasePartyBailorInfo));
            subCriteria.SetProjection(Projections.Property("DocCasePartyBailorInfoId"))
                .Add(Expression.Eq("DCPID", dCPId));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(DocCasePartyBailorAddress)).Add(Subqueries.PropertyIn("DocCasePartyBailorInfoId", subCriteria));

            IRepository<DocCasePartyBailorAddress> docCasePartyBailorAddressRepository = new RepositoryImpl<DocCasePartyBailorAddress>(applicationSession);
            List<DocCasePartyBailorAddress> listDocCasePartyBailorAddress = docCasePartyBailorAddressRepository.FindAll(iCriterion).ToList();
            docCasePartyBailorAddressRepository.DeleteAll(listDocCasePartyBailorAddress);

        }

        internal void DeleteDocCasePartyBailorInfoByDCPId(string dCPId)
        {
            IRepository<DocCasePartyBailorInfo> casePartyBailorInfoRepository = new RepositoryImpl<DocCasePartyBailorInfo>(applicationSession);
            List<DocCasePartyBailorInfo> listDocCasePartyBailorInfo = GetListDocCasePartyBailorInfoByDCPId(dCPId);

            if ((listDocCasePartyBailorInfo != null) && (listDocCasePartyBailorInfo.Count > 0))
                casePartyBailorInfoRepository.DeleteAll(listDocCasePartyBailorInfo);
        }

        internal void DeleteDocCasePartyCitizenship(string dcpId)
        {
            if (!string.IsNullOrEmpty(dcpId))
            {
                DetachedCriteria detachedCriteria = DetachedCriteria.For<DocCasePartyCitizenship>()
                    .Add(Expression.Eq("DCPID", dcpId));
                Repository<DocCasePartyCitizenship>().DeleteAll(detachedCriteria);
            }
        }

        internal void DeleteDocCasePartyCriminalInfoByDCPId(string dCPId)
        {
            IRepository<DocCasePartyCriminalInfo> casePartyCriminalInfoRepository = new RepositoryImpl<DocCasePartyCriminalInfo>(applicationSession);
            List<DocCasePartyCriminalInfo> listDocCasePartyCriminalInfo = GetListDocCasePartyCriminalInfoByDCPId(dCPId);

            if ((listDocCasePartyCriminalInfo != null) && (listDocCasePartyCriminalInfo.Count > 0))
                casePartyCriminalInfoRepository.DeleteAll(listDocCasePartyCriminalInfo);
        }

        internal void DeleteDocCasePartyData(string dcpId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyVesselDetail))
                                                                   .Add(Expression.Eq("DCPId", dcpId));
            this.DeleteDocCasePartyVesselDetail(detachedCriteria);

            detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAuthorisedOfficerDetailsEntity))
                                                                   .Add(Expression.Eq("DCPId", dcpId));
            this.DeleteDocCasePartyAuthorisedOfficerDetail(detachedCriteria);

            detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAlias))
                                                                  .Add(Expression.Eq("DCPId", dcpId));
            this.DeleteDocCasePartyAlias(detachedCriteria);

            detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAddress))
                                                                  .Add(Expression.Eq("DCPId", dcpId));
            this.DeleteDocCasePartyAddress(detachedCriteria);

            detachedCriteria = DetachedCriteria.For(typeof(DocCaseSolicitor))
                                                                  .Add(Expression.Eq("DCPId", dcpId));
            this.DeleteDocCaseSolicitor(detachedCriteria);

            detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAICDetail))
                                                                  .Add(Expression.Eq("DCPId", dcpId));
            this.DeleteDocCasePartyAICDetail(detachedCriteria);

            detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyCitizenship))
                                                                 .Add(Expression.Eq("DCPId", dcpId));
            this.DeleteDocCasePartyCitizenship(detachedCriteria);

            this.DeleteDocCasePartyCriminalInfoByDCPId(dcpId);
            this.DeleteDocCasePartyBailorInfoByDCPId(dcpId);
            this.DeleteDocCasePartyBailorAddressByDCPId(dcpId);
        }

        internal void DeleteDocCasePartyLACDetail(string dcpId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyLACDetail))
                .Add(Expression.Eq("DocCaseParty.DCPID", dcpId));
            DeleteFromDetachedCriteria<DocCasePartyLACDetail>(detachedCriteria);
        }

        internal void DeleteDocCaseSolicitor(string caseInfoId, string dcpId)
        {
            var subCriteria = DetachedCriteria.For(typeof(DocCaseParty));
            subCriteria.SetProjection(Projections.Property("DCPID")).Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                                                                     .Add(Expression.Eq("DCPID", dcpId));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(DocCaseSolicitor)).Add(Subqueries.PropertyIn("DCPID", subCriteria));

            IRepository<DocCaseSolicitor> docCaseSolicitorRepository = new RepositoryImpl<DocCaseSolicitor>(applicationSession);
            List<DocCaseSolicitor> listDocCaseSolicitor = docCaseSolicitorRepository.FindAll(iCriterion).ToList();
            docCaseSolicitorRepository.DeleteAll(listDocCaseSolicitor);
        }

        internal void DeleteDocCaseSolicitorByDcpId(string dcpId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DocCaseSolicitor>()
                .Add(Expression.Eq("DCPID", dcpId));
            Repository<DocCaseSolicitor>().DeleteAll(detachedCriteria);
        }

        internal void DeleteDocOrderDetails(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DocOrderDetail>()
                .Add(Expression.Eq("DocId", docId));
            Repository<DocOrderDetail>().DeleteAll(detachedCriteria);
        }

        internal void DeleteDocRequestDetailsList(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DocRequestDetail>()
                .Add(Expression.Eq("DocId", docId));
            Repository<DocRequestDetail>().DeleteAll(detachedCriteria);
        }

        internal void DeleteDocumentInfo(string docId)
        {
            IRepository<DocumentInfo> documentInfoRepository = new RepositoryImpl<DocumentInfo>(applicationSession);
            documentInfoRepository.Delete(documentInfoRepository.Get(docId));
        }

        internal void DeleteDocumentInfoByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DocumentInfo>()
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            List<DocumentInfo> listDocumentInfo = GetFromDetachedCriteria<DocumentInfo>(detachedCriteria);
            if (listDocumentInfo != null && listDocumentInfo.Count > 0)
            {
                Repository<DocumentInfo>().DeleteAll(listDocumentInfo);
            }
        }

        internal void DeleteRDocCaseList(string docId, string caseInfoId, string subCaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RDocCase>()
                .Add(Expression.Eq("DocId", docId))
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(subCaseInfoId)));
            Repository<RDocCase>().DeleteAll(detachedCriteria);
        }

        internal void DeleteRDocCaseParty(string caseInfoId, string dcpId)
        {
            var subCriteria = DetachedCriteria.For(typeof(DocCaseParty));
            subCriteria.SetProjection(Projections.Property("DCPID")).Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                                                                     .Add(Expression.Eq("DCPID", dcpId));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(RDocCaseParty)).Add(Subqueries.PropertyIn("DCPID", subCriteria));

            IRepository<RDocCaseParty> rDocCasePartyRepository = new RepositoryImpl<RDocCaseParty>(applicationSession);
            List<RDocCaseParty> listRDocCaseParty = rDocCasePartyRepository.FindAll(iCriterion).ToList();
            rDocCasePartyRepository.DeleteAll(listRDocCaseParty);
        }

        internal void DeleteRDocCasePartyList(string dcpId, string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RDocCaseParty>()
               .Add(Expression.Eq("DocId", docId))
               .Add(Expression.Eq("DCPID", dcpId));
            Repository<RDocCaseParty>().DeleteAll(detachedCriteria);
        }

        internal CaseLatestDocumentsEntity GetCaseLatestDocuments(string caseInfoId, string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseLatestDocuments>()
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                .Add(Expression.Eq("DocId", docId));

            List<CaseLatestDocuments> listCaseLatestDocuments = GetFromDetachedCriteria<CaseLatestDocuments>(detachedCriteria);
            if (listCaseLatestDocuments != null && listCaseLatestDocuments.Count > 0)
            {
                return listCaseLatestDocuments.Select(caseLatestDocuments => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper
                    .GetCaseLatestDocumentsEntity(caseLatestDocuments)).ToList()[0];//TODO:Need to implement FindOne
            }
            else
                return null;
        }

        internal IDocCasePartyData GetCriminalDocCasePartyData(string dcpId)
        {
            CriminalDocCasePartyData criminalDocCasePartyData = new CriminalDocCasePartyData();
            try
            {
                criminalDocCasePartyData.ListDocCasePartyCriminalInfo = this.GetListDocCasePartyCriminalInfoEntityByDCPId(dcpId);
                criminalDocCasePartyData.ListDocCasePartyBailorInfo = this.GetListDocCasePartyBailorInfoEntityByDCPId(dcpId);
                criminalDocCasePartyData.ListDocCasePartyBailorAddress = new List<DocCasePartyBailorAddressEntity>();

                if (criminalDocCasePartyData.ListDocCasePartyBailorInfo != null)
                {
                    foreach (DocCasePartyBailorInfoEntity cpbi in criminalDocCasePartyData.ListDocCasePartyBailorInfo)
                        foreach (DocCasePartyBailorAddressEntity cpba in GetListDocCasePartyBailorAddressEntityByDocCasePartyBailorInfoId(cpbi.DocCasePartyBailorInfoId))
                            criminalDocCasePartyData.ListDocCasePartyBailorAddress.Add(cpba);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCriminalDocCasePartyData", ex);
                throw;
            }
            return criminalDocCasePartyData;
        }

        internal DocCasePartyEntity GetDocCaseParty(string dCPID)
        {
            IRepository<DocCaseParty> repository = new RepositoryImpl<DocCaseParty>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyEntity(repository.Get(dCPID));
        }

        internal DocCasePartyAICAddressEntity GetDocCasePartyAICAddressByPK(string primaryKey)
        {
            Criteria criteria = new Criteria("RecId", primaryKey);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyAICAddressEntity(GetDocCasePartyAICAddress(criteria));
        }

        internal DocCasePartyAICAliasEntity GetDocCasePartyAICAliasByPK(string primaryKey)
        {
            Criteria criteria = new Criteria("RecId", primaryKey);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyAICAliasEntity(GetDocCasePartyAICAlias(criteria));
        }

        internal DocCasePartyAICDetailsEntity GetDocCasePartyAICDetailsByPK(string primaryKey)
        {
            Criteria criteria = new Criteria("DCPAICID", primaryKey);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyAICDetailEntity(GetDocCasePartyAICDetail(criteria));
        }

        internal DocCasePartyAliasEntity GetDocCasePartyAliasByPK(string primaryKey)
        {
            Criteria criteria = new Criteria("RecId", primaryKey);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyAliasEntity(GetDocCasePartyAlias(criteria));
        }

        internal DocCasePartyAuthorisedOfficerDetailsEntity GetDocCasePartyAuthorisedOfficerDetailsByPK(string primaryKey)
        {
            Criteria criteria = new Criteria("RecId", primaryKey);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyAuthorisedOfficerDetailEntity(GetDocCasePartyAuthorisedOfficerDetail(criteria));
        }

        internal DocCasePartyCriminalInfoEntity GetDocCasePartyCriminalInfoEntityByDCPId(string DCPId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyCriminalInfo))
                                                                            .Add(Expression.Eq("DCPID", DCPId));

            List<DocCasePartyCriminalInfo> listDocCasePartyCriminalInfo = GetListDocCasePartyCriminalInfo(detachedCriteria);

            if (listDocCasePartyCriminalInfo != null && listDocCasePartyCriminalInfo.Count > 0)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyCriminalInfoEntity(listDocCasePartyCriminalInfo[0]);
            }
            else
            {
                return null;
            }
        }

        internal IDocCasePartyData GetDocCasePartyData(string dCPID)
        {
            DocCasePartyData docCasePartyData = new DocCasePartyData();
            try
            {
                docCasePartyData.DocCasePartyEntity = this.GetDocCaseParty(dCPID);
                docCasePartyData.DocCasePartyAddresses = this.GetListDocCasePartyAddressByDCPID(dCPID);
                docCasePartyData.DocCasePartyAICDetails = this.GetListDocCasePartyAICDetailsByDCPID(dCPID);
                docCasePartyData.DocCasePartyAliases = this.GetListDocCasePartyAliasByDCPID(dCPID);
                docCasePartyData.DocCasePartyAuthorisedOfficerDetails = this.GetListDocCasePartyAuthorisedOfficerDetailByDCPID(dCPID);
                docCasePartyData.DocCasePartyVesselDetails = this.GetListDocCasePartyVesselDetailsByDCPID(dCPID);
                docCasePartyData.DocCaseSolicitors = this.GetListDocCaseSolicitorByDCPID(dCPID);
                docCasePartyData.DocCasePartyCitizenships = this.GetListDocCasePartyCitizenshipEntityByDCPId(dCPID);
                docCasePartyData.DocCasePartyCriminalInfo = this.GetDocCasePartyCriminalInfoEntityByDCPId(dCPID);
                docCasePartyData.DocCasePartyBailorInfos = this.GetListDocCasePartyBailorInfoEntityByDCPId(dCPID);
                docCasePartyData.DocCasePartyLACDetail = this.GetDocCasePartyLACDetail(dCPID);
                docCasePartyData.DocPartyCaseFileRefNumberEntity = this.GetDocPartyCaseFileRefNumberEntityByDCPID(dCPID);
                if (docCasePartyData.DocCasePartyBailorInfos != null)
                {
                    foreach (DocCasePartyBailorInfoEntity docCasePartyBailorInfo in docCasePartyData.DocCasePartyBailorInfos)
                    {
                        docCasePartyBailorInfo.DocCasePartyBailorAddresses = GetListDocCasePartyBailorAddressEntityByDocCasePartyBailorInfoId(docCasePartyBailorInfo.DocCasePartyBailorInfoId);


                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCasePartyData", ex);
                throw;
            }
            return docCasePartyData;
        }

        

        internal DocCasePartyLACDetailEntity GetDocCasePartyLACDetail(string dcpId)
        {
            DocCaseParty docCaseParty = new DocCaseParty { DCPID = dcpId };
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyLACDetail))
                .Add(Expression.Eq("DocCaseParty", docCaseParty));

            List<DocCasePartyLACDetail> listDocCasePartyLACDetail = GetFromDetachedCriteria<DocCasePartyLACDetail>(detachedCriteria);

            if (listDocCasePartyLACDetail != null && listDocCasePartyLACDetail.Count > 0)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyLACDetailEntity(listDocCasePartyLACDetail[0]);
            }
            else
                return null;
        }

        internal DocCasePartyVesselDetailsEntity GetDocCasePartyVesselDetailsyPK(string primaryKey)
        {
            Criteria criteria = new Criteria("RecId", primaryKey);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyVesselDetailsEntity(GetDocCasePartyVesselDetail(criteria));
        }

        internal List<DocCaseSolicitorEntity> GetDocCaseSolicitor<V>(string fieldName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCaseSolicitor))
                                                                            .Add(Expression.Eq(fieldName, value));

            List<DocCaseSolicitor> listDocCaseSolicitorEntity = GetAllDocCaseSolicitor(detachedCriteria);

            if (listDocCaseSolicitorEntity != null && listDocCaseSolicitorEntity.Count > 0)
            {
                return listDocCaseSolicitorEntity.Select(docCaseSolicitorEntity => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCaseSolicitorEntity(docCaseSolicitorEntity)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the <see cref="DocOrderDetailsEntity"/>
        /// </summary>
        /// <param name="docId">The docId.</param>
        /// <returns></returns>
        internal DocOrderDetailsEntity GetDocOrderDetailsByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DocOrderDetail>()
                 .Add(Expression.Eq("DocId", docId));
            List<DocOrderDetail> listDocOrderDetail = GetFromDetachedCriteria<DocOrderDetail>(detachedCriteria);

            if (listDocOrderDetail != null && listDocOrderDetail.Count > 0)
            {
                return listDocOrderDetail.Select(docOrderDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocOrderDetailsEntity(docOrderDetail)).ToList()[0];
            }
            else
            {
                return null;
            }
        }

        internal List<DocumentInfoEntity> GetDocumentInfoEntity(string docCode, object documentStatus, int someDay)
        {
            try
            {
                MDocCode mDocCode = new MDocCode { DOCCode = docCode };
                MDocStatus MDocStatus = new MDocStatus { DocStatus = documentStatus.ToString() };
                DateTime date = DateTime.Now.AddDays(-someDay);

                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocumentInfo))
                        .Add(Expression.Eq("MDocCode", mDocCode))
                        .Add(Expression.Eq("MDocStatus", MDocStatus))
                        .Add(Expression.Gt("ProcessedTime", date));

                IRepository<DocumentInfo> documentInfoRepository = new RepositoryImpl<DocumentInfo>(applicationSession);

                List<DocumentInfo> listDocumentInfo = documentInfoRepository.GetAll(detachedCriteria) as List<DocumentInfo>;
                List<DocumentInfoEntity> listDocumenInfoEntity = null;

                if (listDocumentInfo != null && listDocumentInfo.Count > 0)
                {
                    listDocumenInfoEntity = new List<DocumentInfoEntity>();
                    foreach (DocumentInfo documentInfo in listDocumentInfo)
                    {
                        listDocumenInfoEntity.Add(AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfo));
                    }
                }

                return listDocumenInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocumentInfoEntity", ex);
                throw;
            }
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

        internal List<DocCasePartyAddressEntity> GetListDocCasePartyAddressByDCPID(string dCPID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAddress))
                                                                            .Add(Expression.Eq("DCPID", dCPID));

            List<DocCasePartyAddress> listDocCasePartyAddress = GetAllDocCasePartyAddress(detachedCriteria);

            if (listDocCasePartyAddress != null && listDocCasePartyAddress.Count > 0)
            {
                return listDocCasePartyAddress.Select(docCasePartyAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyAddressEntity(docCasePartyAddress)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocCasePartyAICAddressEntity> GetListDocCasePartyAICAddressByDCPAICID(string DCPAICID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAICAddress))
                                                                            .Add(Expression.Eq("DCPAICID", DCPAICID));

            List<DocCasePartyAICAddress> listDocCasePartyAICAddress = GetDocCasePartyAICAddress(detachedCriteria);

            if (listDocCasePartyAICAddress != null && listDocCasePartyAICAddress.Count > 0)
            {
                return listDocCasePartyAICAddress.Select(docCasePartyAICAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyAICAddressEntity(docCasePartyAICAddress)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocCasePartyAICAliasEntity> GetListDocCasePartyAICAliasByDCPAICID(string DCPAICID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAICAlias))
                                                                            .Add(Expression.Eq("DCPAICID", DCPAICID));

            List<DocCasePartyAICAlias> listDocCasePartyAICAlias = GetDocCasePartyAICAlias(detachedCriteria);

            if (listDocCasePartyAICAlias != null && listDocCasePartyAICAlias.Count > 0)
            {
                return listDocCasePartyAICAlias.Select(docCasePartyAICAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyAICAliasEntity(docCasePartyAICAddress)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocCasePartyAICDetailsEntity> GetListDocCasePartyAICDetailsByDCPID(string dCPID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAICDetail))
                                                                            .Add(Expression.Eq("DCPID", dCPID));

            List<DocCasePartyAICDetail> listDocCasePartyAICDetail = GetDocCasePartyAICDetail(detachedCriteria);

            if (listDocCasePartyAICDetail != null && listDocCasePartyAICDetail.Count > 0)
            {
                return listDocCasePartyAICDetail.Select(docCasePartyAICDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyAICDetailEntity(docCasePartyAICDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocCasePartyAICDetailsEntity> GetListDocCasePartyAICDetailsWithChildByDCPID(string dCPID)
        {
            List<DocCasePartyAICDetailsEntity> listDocCasePartyAICDetailsEntity = GetListDocCasePartyAICDetailsByDCPID(dCPID);

            if (listDocCasePartyAICDetailsEntity != null && listDocCasePartyAICDetailsEntity.Count > 0)
            {
                for (int i = 0; i < listDocCasePartyAICDetailsEntity.Count; i++)
                {
                    listDocCasePartyAICDetailsEntity[i].DocCasePartyAICAddresses = GetListDocCasePartyAICAddressByDCPAICID(listDocCasePartyAICDetailsEntity[i].DCPAICID);
                    listDocCasePartyAICDetailsEntity[i].DocCasePartyAICAliases = GetListDocCasePartyAICAliasByDCPAICID(listDocCasePartyAICDetailsEntity[i].DCPAICID);
                }

                return listDocCasePartyAICDetailsEntity;
            }
            else
            {
                return null;
            }
        }

        internal List<DocCasePartyAliasEntity> GetListDocCasePartyAliasByDCPID(string dCPID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAlias))
                                                                            .Add(Expression.Eq("DCPID", dCPID));

            List<DocCasePartyAlias> listDocCasePartyAliasEntity = GetDocCasePartyAlias(detachedCriteria);

            if (listDocCasePartyAliasEntity != null && listDocCasePartyAliasEntity.Count > 0)
            {
                return listDocCasePartyAliasEntity.Select(docCasePartyAliasEntity => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyAliasEntity(docCasePartyAliasEntity)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocCasePartyAuthorisedOfficerDetailsEntity> GetListDocCasePartyAuthorisedOfficerDetailByDCPID(string dCPID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAuthorisedOfficerDetail))
                                                                            .Add(Expression.Eq("DCPID", dCPID));

            List<DocCasePartyAuthorisedOfficerDetail> listDocCasePartyAuthorisedOfficerDetailEntity = GetAllDocCasePartyAuthorisedOfficerDetail(detachedCriteria);

            if (listDocCasePartyAuthorisedOfficerDetailEntity != null && listDocCasePartyAuthorisedOfficerDetailEntity.Count > 0)
            {
                return listDocCasePartyAuthorisedOfficerDetailEntity.Select(docCasePartyAuthorisedOfficerDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyAuthorisedOfficerDetailEntity(docCasePartyAuthorisedOfficerDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocCasePartyBailorAddressEntity> GetListDocCasePartyBailorAddressEntityByDCPId(string DCPId)
        {
            List<DocCasePartyBailorAddressEntity> listDocCasePartyBailorAddressEntity = new List<DocCasePartyBailorAddressEntity>();

            List<DocCasePartyBailorInfoEntity> listDocCasePartyBailorInfo = GetListDocCasePartyBailorInfoEntityByDCPId(DCPId);
            foreach (DocCasePartyBailorInfoEntity dcpbie in listDocCasePartyBailorInfo)
            {
                if (dcpbie != null)
                    listDocCasePartyBailorAddressEntity.AddRange(GetListDocCasePartyBailorAddressEntityByDocCasePartyBailorInfoId(dcpbie.DocCasePartyBailorInfoId));
            }

            if (listDocCasePartyBailorAddressEntity != null && listDocCasePartyBailorAddressEntity.Count > 0)
            {
                return listDocCasePartyBailorAddressEntity;
            }
            else
            {
                return null;
            }
        }

        internal List<DocCasePartyBailorAddressEntity> GetListDocCasePartyBailorAddressEntityByDocCasePartyBailorInfoId(string DocCasePartyBailorInfoId)
        {
            List<DocCasePartyBailorAddress> listDocCasePartyBailorAddress = GetListDocCasePartyBailorAddressByDocCasePartyBailorInfoId(DocCasePartyBailorInfoId);

            if (listDocCasePartyBailorAddress != null && listDocCasePartyBailorAddress.Count > 0)
            {
                return listDocCasePartyBailorAddress.Select(docCasePartyBailorAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyBailorAddressEntity(docCasePartyBailorAddress)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocCasePartyBailorInfoEntity> GetListDocCasePartyBailorInfoEntityByDCPId(string DCPId)
        {
            List<DocCasePartyBailorInfo> listDocCasePartyBailorInfo = GetListDocCasePartyBailorInfoByDCPId(DCPId);

            if (listDocCasePartyBailorInfo != null && listDocCasePartyBailorInfo.Count > 0)
            {
                return listDocCasePartyBailorInfo.Select(docCasePartyBailorInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyBailorInfoEntity(docCasePartyBailorInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocCasePartyEntity> GetListDocCasePartyByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCaseParty))
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<DocCaseParty> listDocCaseParty = GetFromDetachedCriteria<DocCaseParty>(detachedCriteria);

            if (listDocCaseParty != null && listDocCaseParty.Count > 0)
            {
                return listDocCaseParty.Select(docCaseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyEntity(docCaseParty)).ToList();
            }
            else
                return null;
        }

        internal List<DocCasePartyEntity> GetListDocCasePartyByDocId(string docId)
        {
            DetachedCriteria subCriteria = DetachedCriteria.For(typeof(RDocCaseParty));
            subCriteria.SetProjection(Projections.Property("DCPID")).Add(Expression.Eq("DocId", docId));

            ICriteria criteria = applicationSession.CreateCriteria(typeof(DocCaseParty)).Add(Subqueries.PropertyIn("DCPID", subCriteria));

            IRepository<DocCaseParty> docCasePartyRepository = new RepositoryImpl<DocCaseParty>(applicationSession);
            List<DocCaseParty> listDocCaseParty = docCasePartyRepository.FindAll(criteria).ToList();
            if (listDocCaseParty != null && listDocCaseParty.Count > 0)
            {
                return listDocCaseParty.Select(docCaseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyEntity(docCaseParty)).ToList();
            }
            else
                return null;
        }

        internal List<DocCasePartyCitizenshipEntity> GetListDocCasePartyCitizenshipEntityByDCPId(string DCPId)
        {
            List<DocCasePartyCitizenship> listDocCasePartyCitizenship = GetListDocCasePartyCitizenshipByDCPId(DCPId);

            if (listDocCasePartyCitizenship != null && listDocCasePartyCitizenship.Count > 0)
            {
                return listDocCasePartyCitizenship.Select(docCasePartyCitizenship => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyCitizenshipEntity(docCasePartyCitizenship)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocCasePartyCriminalInfoEntity> GetListDocCasePartyCriminalInfoEntityByDCPId(string DCPId)
        {
            List<DocCasePartyCriminalInfo> listDocCasePartyCriminalInfo = GetListDocCasePartyCriminalInfoByDCPId(DCPId);

            if (listDocCasePartyCriminalInfo != null && listDocCasePartyCriminalInfo.Count > 0)
            {
                return listDocCasePartyCriminalInfo.Select(docCasePartyCriminalInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyCriminalInfoEntity(docCasePartyCriminalInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocCasePartyVesselDetailsEntity> GetListDocCasePartyVesselDetailsByDCPID(string dCPID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyVesselDetail))
                                                                            .Add(Expression.Eq("DCPID", dCPID));

            List<DocCasePartyVesselDetail> listDocCasePartyVesselDetail = GetAllDocCasePartyVesselDetail(detachedCriteria);

            if (listDocCasePartyVesselDetail != null && listDocCasePartyVesselDetail.Count > 0)
            {
                return listDocCasePartyVesselDetail.Select(docCasePartyVesselDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCasePartyVesselDetailsEntity(docCasePartyVesselDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocCaseSolicitorEntity> GetListDocCaseSolicitorByDCPID(string dCPID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCaseSolicitor))
                                                                            .Add(Expression.Eq("DCPID", dCPID));

            List<DocCaseSolicitor> listDocCaseSolicitorEntity = GetAllDocCaseSolicitor(detachedCriteria);

            if (listDocCaseSolicitorEntity != null && listDocCaseSolicitorEntity.Count > 0)
            {
                return listDocCaseSolicitorEntity.Select(docCaseSolicitorEntity => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCaseSolicitorEntity(docCaseSolicitorEntity)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocGCRDetailsEntity> GetListDocGCRDetails(string docId, int itemNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocGCRDetails))
                 .Add(Expression.Eq("DocId", docId))
                 .Add(Expression.Eq("ItemNo", Convert.ToInt32(itemNo)));

            List<DocGCRDetails> listDocGCRDetails = GetFromDetachedCriteria<DocGCRDetails>(detachedCriteria);
            if (listDocGCRDetails != null && listDocGCRDetails.Count > 0)
            {
                return listDocGCRDetails.Select(docGCRDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocGCRDetailsEntity(docGCRDetails)).ToList();
            }
            else
                return null;
        }

        internal List<DocGCRDetailsEntity> GetListDocGCRDetailsByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocGCRDetails))
                .Add(Expression.Eq("DocId", docId));

            List<DocGCRDetails> listDocGCRDetails = GetFromDetachedCriteria<DocGCRDetails>(detachedCriteria);
            if (listDocGCRDetails != null && listDocGCRDetails.Count > 0)
            {
                return listDocGCRDetails.Select(docGCRDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocGCRDetailsEntity(docGCRDetails)).ToList();
            }
            else
                return null;
        }

        internal List<DocOrderDetailsEntity> GetListDocOrderDetailsByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocOrderDetail))
                .Add(Expression.Eq("DocId", docId));

            List<DocOrderDetail> listDocOrderDetail = GetFromDetachedCriteria<DocOrderDetail>(detachedCriteria);
            if (listDocOrderDetail != null && listDocOrderDetail.Count > 0)
            {
                return listDocOrderDetail.Select(docOrderDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocOrderDetailsEntity(docOrderDetail)).ToList();
            }
            else
                return null;
        }

        internal List<DocRequestDetailsEntity> GetListDocRequestDetailsByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocRequestDetail))
                .Add(Expression.Eq("DocId", docId));
            List<DocRequestDetail> listDocRequestDetail = GetFromDetachedCriteria<DocRequestDetail>(detachedCriteria);

            if (listDocRequestDetail != null && listDocRequestDetail.Count > 0)
            {
                return listDocRequestDetail.Select(docRequestDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocRequestDetails(docRequestDetail)).ToList();
            }
            else
                return null;
        }

        internal List<DocumentInfoEntity> GetListDocumentInfoByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocumentInfo))
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<DocumentInfo> listDocumentInfo = GetAllDocumentInfo(detachedCriteria);
            if (listDocumentInfo != null && listDocumentInfo.Count > 0)
            {
                return listDocumentInfo.Select(documentInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfo)).ToList();
            }
            else
                return null;
        }

        internal List<DocumentInfoEntity> GetListDocumentInfoBySubCaseInfoId(long SubCaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocumentInfo))
                .Add(Expression.Eq("SubCaseInfoId", SubCaseInfoId));

            List<DocumentInfo> listDocumentInfo = GetAllDocumentInfo(detachedCriteria);
            if (listDocumentInfo != null && listDocumentInfo.Count > 0)
            {
                return listDocumentInfo.Select(documentInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfo)).ToList();
            }
            else
                return null;
        }

        internal List<DocumentInfoEntity> GetListDocumentInfoByDocCode(string docCode)
        {
            //Nesting If is used Just because of the wrong db values
            //DocumentInfo table contains '' values for DocCode which is wrong(which will lead to Mapper Error).
            if (!string.IsNullOrEmpty(docCode))
            {
                MDocCode mDocCode = new MDocCode();
                mDocCode.DOCCode = docCode;
                DetachedCriteria detachedCriteria = DetachedCriteria.For<DocumentInfo>()
                  .Add(Expression.Eq("MDocCode", mDocCode));
                List<DocumentInfo> listDocumentInfo = GetFromDetachedCriteria<DocumentInfo>(detachedCriteria);
                if (listDocumentInfo != null && listDocumentInfo.Count > 0)
                {
                    return listDocumentInfo.Select(documentInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfo)).ToList();
                }
                else
                    return null;

            }
            else
                return null;
        }

        internal List<DocumentInfoEntity> GetListDocumentInfoByHrgId(long hrgId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocumentInfo))
                .Add(Expression.Eq("HRGID", hrgId));

            List<DocumentInfo> listDocumentInfo = GetAllDocumentInfo(detachedCriteria);
            if (listDocumentInfo != null && listDocumentInfo.Count > 0)
            {
                return listDocumentInfo.Select(documentInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfo)).ToList();
            }
            else
                return null;
        }

        internal DocumentInfoEntity GetListDocumentInfoByPK(string docID)
        {
            Logger.Debug("DocumentInfo Called thro SP");
            DocumentInfoEntity documentInfoEntity = null;
            try
            {
                if (!string.IsNullOrEmpty(docID))
                {

                    ArrayList value = new ArrayList();
                    value.Add(docID);

                    Dictionary<String, ArrayList> ParamDic = new Dictionary<string, ArrayList>();

                    ParamDic.Add("DocId", value);

                    DocumentInfoSP documentInfoSP = sqlGateway.FindAll<DocumentInfoSP>("GetDocumentByDocId", ParamDic).FirstOrDefault();

                    documentInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfoSP);



                    //IQuery query = applicationSession.GetNamedQuery("GetDocumentByDocId").SetParameter("DocId", docID);


                    //List<object> DocList = query.List<object>().ToList();

                    //if (DocList != null && DocList.Count > 0)
                    //{
                    //    documentInfoEntity = TransformToDocumentInfo(DocList);

                    //}
                    if (documentInfoEntity != null)
                    {

                        #region MDocStatus
                        if (documentInfoSP.DocStatusCode != null)
                        {

                            ArrayList valueMDocStatus = new ArrayList();
                            valueMDocStatus.Add(documentInfoSP.DocStatusCode);

                            // IQuery QueryDocStatus = applicationSession.GetNamedQuery("GetMDocStatus");

                            Dictionary<String, ArrayList> ParamDicMDocStatus = new Dictionary<string, ArrayList>();

                            ParamDicMDocStatus.Add("DocStatus", valueMDocStatus);

                            MDocStatus mdocStaus = sqlGateway.FindAll<MDocStatus>("GetMDocStatus", ParamDicMDocStatus).FirstOrDefault();
                            documentInfoEntity.MDocStatus = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocStatusEntity(mdocStaus);
                        }

                        #endregion

                        #region MCurrency
                        if (documentInfoSP.CurrencyCode != null)
                        {
                            string CurrencyCode = documentInfoSP.CurrencyCode;

                            ArrayList valueMCurrency = new ArrayList();
                            valueMCurrency.Add(CurrencyCode);

                            IQuery QueryMCurrency = applicationSession.GetNamedQuery("GetMCurrency");

                            Dictionary<String, ArrayList> ParamDicMCurrency = new Dictionary<string, ArrayList>();

                            ParamDicMCurrency.Add("CurrencyCode", valueMCurrency);

                            MCurrency mCurrency = sqlGateway.FindAll<MCurrency>("GetMCurrency", ParamDicMCurrency).FirstOrDefault();
                            documentInfoEntity.MCurrency = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCurrencyEntity(mCurrency);
                        }
                        #endregion

                        #region DocCode
                        if (documentInfoSP.DOCCode != null)
                        {
                            string DOCCode = documentInfoSP.DOCCode;

                            ArrayList valueMDocCode = new ArrayList();
                            valueMDocCode.Add(DOCCode);

                            IQuery QueryMCurrency = applicationSession.GetNamedQuery("GetMDocCode");

                            Dictionary<String, ArrayList> ParamDicMDocCode = new Dictionary<string, ArrayList>();

                            ParamDicMDocCode.Add("DocCode", valueMDocCode);

                            MDocCode mDocCode = sqlGateway.FindAll<MDocCode>("GetMDocCode", ParamDicMDocCode).FirstOrDefault();
                            documentInfoEntity.MDocCode = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocCodeEntity(mDocCode);
                        }
                        #endregion

                        #region MDocNature

                        if (documentInfoSP.DocNatureCode != null)
                        {
                            string docNatureCode = documentInfoSP.DocNatureCode;

                            ArrayList valueMDocNature = new ArrayList();
                            valueMDocNature.Add(docNatureCode);

                            IQuery QueryDocNature = applicationSession.GetNamedQuery("GetMDocNature");

                            Dictionary<String, ArrayList> ParamDicMDocNature = new Dictionary<string, ArrayList>();

                            ParamDicMDocNature.Add("DocNatureCode", valueMDocNature);

                            MDocNature mDocNature = sqlGateway.FindAll<MDocNature>("GetMDocNature", ParamDicMDocNature).FirstOrDefault();
                            documentInfoEntity.MDocNature = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocNatureEntity(mDocNature);
                        }
                        #endregion

                        #region MDocSecurity

                        if (documentInfoSP.DocSecurityCode != null)
                        {
                            string docSecurityCode = documentInfoSP.DocSecurityCode;

                            ArrayList valueMDocSecurity = new ArrayList();
                            valueMDocSecurity.Add(docSecurityCode);

                            //  IQuery QueryDocSecurity = applicationSession.GetNamedQuery("GetMDocsecurity");

                            Dictionary<String, ArrayList> ParamDicMDocSecurity = new Dictionary<string, ArrayList>();

                            ParamDicMDocSecurity.Add("DocSecurityCode", valueMDocSecurity);

                            MDocSecurity mDocSecurity = sqlGateway.FindAll<MDocSecurity>("GetMDocSecurity", ParamDicMDocSecurity).FirstOrDefault();
                            documentInfoEntity.MDocSecurity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocSecurityEntity(mDocSecurity);
                        }
                        #endregion

                        #region MForumType

                        if (documentInfoSP.ForumID != null)
                        {
                            string mForumId = documentInfoSP.ForumID;

                            ArrayList valueMForumType = new ArrayList();
                            valueMForumType.Add(mForumId);

                            //  IQuery QueryDocSecurity = applicationSession.GetNamedQuery("GetMDocsecurity");

                            Dictionary<String, ArrayList> ParamDicMForumType = new Dictionary<string, ArrayList>();

                            ParamDicMForumType.Add("ForumId", valueMForumType);

                            MForumType mForumType = sqlGateway.FindAll<MForumType>("GetMForumType", ParamDicMForumType).FirstOrDefault();
                            documentInfoEntity.MForumType = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMForumTypeEntity(mForumType);
                        }
                        #endregion

                    }



                }
                Logger.Debug("DocumentInfo Completed Callin thro SP");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetListDocumentInfoByPK", ex);
                throw;
            }
            return documentInfoEntity;

        }
        //    IRepository<DocumentInfo> documentInfoRepository = new RepositoryImpl<DocumentInfo>(applicationSession);
        //    return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfoRepository.Get(docID));
        //


        private DocumentInfoEntity TransformToDocumentInfo(List<object> DocList)
        {
            DocumentInfoEntity documentInfo = new DocumentInfoEntity();
            foreach (object[] item in DocList)
            {

                documentInfo = new DocumentInfoEntity(

                    Convert.ToString(item[0]),
                    Convert.ToString(item[1]),
                    Convert.ToString(item[2]),
                    item[3] != null ? Convert.ToDecimal(item[3]) : (decimal?)null,
                    item[4] != null ? Convert.ToDecimal(item[4]) : (decimal?)null,
                    Convert.ToString(item[5]),
                    Convert.ToString(item[6]),
                    item[7] != null ? Convert.ToDecimal(item[7]) : (decimal?)null,
                    Convert.ToString(item[8]),
                    Convert.ToString(item[9]),
                    item[10] != null ? Convert.ToDateTime(item[10]) : (DateTime?)null,
                    item[11] != null ? Convert.ToDateTime(item[11]) : (DateTime?)null,
                    item[12] != null ? Convert.ToDateTime(item[12]) : (DateTime?)null,
                     Convert.ToString(item[13]),
                      Convert.ToDateTime(item[14]),
                      Convert.ToString(item[15]),
                      Convert.ToString(item[16]),
                      Convert.ToString(item[17]),
                      item[18] != null ? Convert.ToDecimal(item[18]) : (decimal?)null,
                        Convert.ToString(item[19]),
                      Convert.ToString(item[20]),
                      Convert.ToString(item[21]),
                      item[22] != null ? Convert.ToDateTime(item[22]) : (DateTime?)null,
                        Convert.ToString(item[23]),
                      Convert.ToString(item[24]),
                      Convert.ToString(item[25]),
                       item[26] != null ? Convert.ToDateTime(item[26]) : (DateTime?)null,
                         Convert.ToString(item[27]),
                      Convert.ToString(item[28]),
                      Convert.ToString(item[29]),
                        Convert.ToString(item[30]),
                      Convert.ToString(item[31]),
                       item[32] != null ? Convert.ToDecimal(item[32]) : (decimal?)null,
                        Convert.ToString(item[33]),
                      Convert.ToString(item[34]),
                      Convert.ToString(item[35]),
                       item[36] != null ? Convert.ToDecimal(item[36]) : (decimal?)null,
                         Convert.ToString(item[37]),
                      Convert.ToString(item[38]),
                      Convert.ToString(item[39]),
                        Convert.ToString(item[40]),
                      Convert.ToString(item[41]),
                      Convert.ToString(item[42]),
                        Convert.ToString(item[43]),
                      Convert.ToString(item[44]),
                       item[45] != null ? Convert.ToDateTime(item[45]) : (DateTime?)null,
                         Convert.ToString(item[46]),
                      Convert.ToString(item[47]),
                        Convert.ToString(item[48]),
                      Convert.ToString(item[49]),
                       item[50] != null ? Convert.ToDateTime(item[50]) : (DateTime?)null,
                        Convert.ToString(item[51]),
                      Convert.ToString(item[52]),
                        Convert.ToString(item[53]),
                      Convert.ToString(item[54]),
                       item[55] != null ? Convert.ToDateTime(item[55]) : (DateTime?)null,
                        Convert.ToString(item[56]),
                      Convert.ToString(item[57]),
                       Convert.ToDateTime(item[58]),
                         Convert.ToString(item[59]),
                        Convert.ToString(item[60]),
                      Convert.ToString(item[61]),
                       item[62] != null ? Convert.ToInt64(item[62]) : (long?)null,
                         Convert.ToString(item[63]),
                      Convert.ToString(item[64]),
                      Convert.ToString(item[65]),
                        Convert.ToString(item[66]),
                      Convert.ToString(item[67]),
                      Convert.ToString(item[68]),
                        Convert.ToString(item[69]),
                      Convert.ToString(item[70]),
                      Convert.ToString(item[71]),
                        item[72] != null ? Convert.ToInt32(item[72]) : (int?)null,
                         Convert.ToString(item[73]),
                          item[74] != null ? Convert.ToInt64(item[74]) : (long?)null,
                           item[75] != null ? Convert.ToInt64(item[75]) : (long?)null,
                            item[76] != null ? Convert.ToInt64(item[76]) : (long?)null,
                             Convert.ToString(item[77]),
                      Convert.ToString(item[78]),
                      Convert.ToString(item[79]),
                        Convert.ToString(item[80]),
                      Convert.ToString(item[81]),
                       item[82] != null ? Convert.ToInt64(item[82]) : (long?)null,
                            item[83] != null ? Convert.ToInt64(item[83]) : (long?)null,
                            Convert.ToString(item[84]),
                            null, null,
                      Convert.ToString(item[87]),
                      Convert.ToString(item[88]),
                        Convert.ToString(item[89]),
                      Convert.ToString(item[90]),
                      Convert.ToString(item[91]),
                        Convert.ToString(item[92]),
                      Convert.ToString(item[93]),
                      Convert.ToString(item[94]),
                       Convert.ToString(item[95]),
                      Convert.ToString(item[96])
                       );


            }
            return documentInfo;
        }

        internal List<DocumentInfoEntity> GetListDocumentInfoByRelatedDocId(string relatedDocId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocumentInfo))
                .Add(Expression.Eq("RelatedDocId", relatedDocId));

            List<DocumentInfo> listDocumentInfo = GetAllDocumentInfo(detachedCriteria);
            if (listDocumentInfo != null && listDocumentInfo.Count > 0)
            {
                return listDocumentInfo.Select(documentInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfo)).ToList();
            }
            else
                return null;
        }

        internal List<DocumentInfoEntity> GetListDocumentInfoBySubCaseInfoId(string SubCaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocumentInfo))
                .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(SubCaseInfoId)));

            List<DocumentInfo> listDocumentInfo = GetFromDetachedCriteria<DocumentInfo>(detachedCriteria);
            if (listDocumentInfo != null && listDocumentInfo.Count > 0)
            {
                return listDocumentInfo.Select(documentInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfo)).ToList();
            }
            else
                return null;
        }

        internal List<DocumentInfoEntity> GetListDocumentInfoBySubmissinId(string submissinId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocumentInfo))
                                                                            .Add(Expression.Eq("SubmissionGroupId", submissinId));

            List<DocumentInfo> listDocumentInfoEntity = GetDocumentInfo(detachedCriteria);

            if (listDocumentInfoEntity != null && listDocumentInfoEntity.Count > 0)
            {
                return listDocumentInfoEntity.Select(documentInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocumentInfoEntity> GetListDocumentInfoEntityByDocCode(string docCode)
        {
            try
            {
                MDocCode docCodeEntity = new MDocCode { DOCCode = docCode };

                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocumentInfo))
                        .Add(Expression.Eq("MDocCode", docCodeEntity));

                IRepository<DocumentInfo> documentInfoRepository = new RepositoryImpl<DocumentInfo>(applicationSession);

                List<DocumentInfo> listDocumentInfo = documentInfoRepository.GetAll(detachedCriteria) as List<DocumentInfo>;
                List<DocumentInfoEntity> listDocumenInfoEntity = null;

                if (listDocumentInfo != null && listDocumentInfo.Count > 0)
                {
                    listDocumenInfoEntity = new List<DocumentInfoEntity>();
                    foreach (DocumentInfo documentInfo in listDocumentInfo)
                    {
                        listDocumenInfoEntity.Add(AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfo));
                    }
                }

                return listDocumenInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetListDocumentInfoEntityByDocCode", ex);
                throw;
            }
        }

        internal List<RDocCaseEntity> GetListRDocCase(string docId, string caseInfoId, string subCaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RDocCase))
                 .Add(Expression.Eq("DocId", docId))
                 .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                 .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(subCaseInfoId)));

            List<RDocCase> listRDocCase = GetFromDetachedCriteria<RDocCase>(detachedCriteria);
            if (listRDocCase != null && listRDocCase.Count > 0)
            {
                return listRDocCase.Select(rDocCase => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetRDocCaseEntity(rDocCase)).ToList();
            }
            else
                return null;
        }

        internal List<RDocCaseEntity> GetListRDocCaseByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RDocCase))
                .Add(Expression.Eq("DocId", docId));

            List<RDocCase> listRDocCase = GetAllRDocCase(detachedCriteria);
            if (listRDocCase != null && listRDocCase.Count > 0)
            {
                return listRDocCase.Select(rDocCase => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetRDocCaseEntity(rDocCase)).ToList();
            }
            else
                return null;
        }

        internal List<RDocCasePartyEntity> GetListRDocCaseParty(string dcpId, string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RDocCaseParty))
                .Add(Expression.Eq("DocId", docId))
                .Add(Expression.Eq("DCPID", dcpId));

            List<RDocCaseParty> listDocCaseParty = GetFromDetachedCriteria<RDocCaseParty>(detachedCriteria);

            applicationSession.Evict(listDocCaseParty);
            if (listDocCaseParty != null && listDocCaseParty.Count > 0)
            {
                listDocCaseParty.ForEach(rdocCase => applicationSession.Evict(rdocCase));
                return listDocCaseParty.Select(rDocCaseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetRDocCasePartyEntity(rDocCaseParty)).ToList();
            }
            else
                return null;
        }

        internal List<RDocCasePartyEntity> GetListRDocCaseParty(string docId)
        {
            /*
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RDocCaseParty))
                .Add(Expression.Eq("DocId", docId));

            List<RDocCaseParty> listDocCaseParty = GetFromDetachedCriteria<RDocCaseParty>(detachedCriteria);
            
           
            if (listDocCaseParty != null && listDocCaseParty.Count > 0)
            {
                listDocCaseParty.ForEach(rdocCase => applicationSession.Evict(rdocCase));
                return listDocCaseParty.Select(rDocCaseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetRDocCasePartyEntity(rDocCaseParty)).ToList();
            }
            else
                return null;
             }
             */
            SQLGatewayService sqlGateway = null;
            try
            {
                sqlGateway = new SQLGatewayService();
                if (!string.IsNullOrEmpty(docId))
                {
                    ArrayList value = new ArrayList();
                    value.Add(docId);

                    Dictionary<String, ArrayList> ParamDic = new Dictionary<string, ArrayList>();

                    ParamDic.Add("DocId", value);

                    List<RDocCaseParty> listRDocCaseParty = sqlGateway.FindAll<RDocCaseParty>("GetRDocCaseParty", ParamDic);
                    if (listRDocCaseParty != null && listRDocCaseParty.Count > 0)
                    {
                        return listRDocCaseParty.Select(rDocCaseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetRDocCasePartyEntity(rDocCaseParty)).ToList();
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
            catch (Exception ex)
            {
                Logger.Error("ERror encountered at GetListRDocCasePartyByDocId ", ex);
                throw ex;
            }
        }

        internal List<RDocCasePartyEntity> GetListRDocCasePartyByDCPID(string dCPID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RDocCaseParty))
                                                                            .Add(Expression.Eq("DCPID", dCPID));

            List<RDocCaseParty> listRDocCasePartyEntity = GetAllRDocCaseParty(detachedCriteria);

            if (listRDocCasePartyEntity != null && listRDocCasePartyEntity.Count > 0)
            {
                listRDocCasePartyEntity.ForEach(rdocCase => applicationSession.Evict(rdocCase));
                return listRDocCasePartyEntity.Select(rDocCaseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetRDocCasePartyEntity(rDocCaseParty)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RDocCasePartyEntity> GetListRDocCasePartyByDocId(string docId)
        {
            /*
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RDocCaseParty))
                                                                            .Add(Expression.Eq("DocId", docId));

            List<RDocCaseParty> listRDocCasePartyEntity = GetAllRDocCaseParty(detachedCriteria);

            if (listRDocCasePartyEntity != null && listRDocCasePartyEntity.Count > 0)
            {
                listRDocCasePartyEntity.ForEach(rdocCase => applicationSession.Evict(rdocCase));
                return listRDocCasePartyEntity.Select(rDocCaseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetRDocCasePartyEntity(rDocCaseParty)).ToList();
            }
            else
            {
                return null;
            }*/

            SQLGatewayService sqlGateway = null;
            try
            {
                sqlGateway = new SQLGatewayService();
                if (!string.IsNullOrEmpty(docId))
                {
                    ArrayList value = new ArrayList();
                    value.Add(docId);

                    Dictionary<String, ArrayList> ParamDic = new Dictionary<string, ArrayList>();

                    ParamDic.Add("DocId", value);

                    List<RDocCaseParty> listRDocCaseParty = sqlGateway.FindAll<RDocCaseParty>("GetRDocCaseParty", ParamDic);
                    if (listRDocCaseParty != null && listRDocCaseParty.Count > 0)
                    {
                        return listRDocCaseParty.Select(rDocCaseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetRDocCasePartyEntity(rDocCaseParty)).ToList();
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
            catch (Exception ex)
            {
                Logger.Error("ERror encountered at GetListRDocCasePartyByDocId ", ex);
                throw ex;
            }
        }

        internal RDocCasePartyEntity GetRDocCaseParty(string primaryKey)
        {
            Criteria criteria = new Criteria("RDCPId", primaryKey);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetRDocCasePartyEntity(GetRDocCaseParty(criteria));
        }

        internal RDocCaseEntity RDocCaseEntityByDocId(string docId)
        {
            RDocCaseEntity rDocCaseEntity = null;
            List<RDocCase> listRDocCase = new List<RDocCase>();
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RDocCase))
                .Add(Expression.Eq("DocId", docId));
            IRepository<RDocCase> rDocCaseRepository = new RepositoryImpl<RDocCase>(applicationSession);
            listRDocCase = rDocCaseRepository.GetAll(detachedCriteria) as List<RDocCase>;
            if (listRDocCase != null && listRDocCase.Count > 0)
            {
                foreach (RDocCase rDocCase in listRDocCase)
                {
                    rDocCaseEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetRDocCaseEntity(rDocCase);
                }
            }
            return rDocCaseEntity;
        }

        internal void SaveOrUpdateCopyCriminalDocCasePartyData(IDocCasePartyData iDocCaseParty)
        {
            CriminalDocCasePartyData criminalDocCasePartyData = iDocCaseParty as CriminalDocCasePartyData;

            if (criminalDocCasePartyData.ListDocCasePartyCriminalInfo != null)
            {
                foreach (DocCasePartyCriminalInfoEntity cpCriminalInfoEntity in criminalDocCasePartyData.ListDocCasePartyCriminalInfo)
                {
                    this.SaveOrUpdateDocCasePartyCriminalInfoEntity(cpCriminalInfoEntity);
                }
            }

            if (criminalDocCasePartyData.ListDocCasePartyBailorInfo != null)
            {
                foreach (DocCasePartyBailorInfoEntity cpBailorInfoEntity in criminalDocCasePartyData.ListDocCasePartyBailorInfo)
                {
                    this.SaveOrUpdateDocCasePartyBailorInfoEntity(cpBailorInfoEntity);

                    if (cpBailorInfoEntity.DocCasePartyBailorAddresses != null)
                    {
                        foreach (DocCasePartyBailorAddressEntity cpBailorAddressEntity in cpBailorInfoEntity.DocCasePartyBailorAddresses)
                        {
                            this.SaveOrUpdateDocCasePartyBailorAddressEntity(cpBailorAddressEntity);
                        }
                    }
                }
            }
        }

        internal void SaveOrUpdateCopyCriminalDocCasePartyData(IDocCasePartyData iDocCasePartyData, bool isCopy)
        {
            if (iDocCasePartyData.GetType().Equals(typeof(CriminalDocCasePartyData)))
                SaveOrUpdateCriminalDocCasePartyData(iDocCasePartyData as CriminalDocCasePartyData, isCopy);
            else
                throw new ArgumentNullException("Object Sent was Wrong");
        }

        internal void SaveOrUpdateCopyDocCasePartyData(IDocCasePartyData iDocCaseParty, bool isCopy)
        {
            if (iDocCaseParty.GetType().Equals(typeof(DocCasePartyData)))
                SaveOrUpdateDocCasePartyData(iDocCaseParty as DocCasePartyData, isCopy);
            else
                throw new ArgumentNullException("Object Sent was Wrong");
        }

        internal void SaveOrUpdateCriminalDocCasePartyData(IDocCasePartyData iDocCaseParty)
        {
            CriminalDocCasePartyData criminalDocCasePartyData = iDocCaseParty as CriminalDocCasePartyData;

            if (criminalDocCasePartyData.ListDocCasePartyCriminalInfo != null && criminalDocCasePartyData.ListDocCasePartyCriminalInfo.Count > 0)
            {
                foreach (DocCasePartyCriminalInfoEntity docCasePartyCriminalInfoEntity in criminalDocCasePartyData.ListDocCasePartyCriminalInfo)
                {
                    this.SaveOrUpdateDocCasePartyCriminalInfoEntity(docCasePartyCriminalInfoEntity);
                }
            }
            if (criminalDocCasePartyData.ListDocCasePartyBailorInfo != null && criminalDocCasePartyData.ListDocCasePartyBailorInfo.Count > 0)
            {
                foreach (DocCasePartyBailorInfoEntity docCasePartyBailorInfoEntity in criminalDocCasePartyData.ListDocCasePartyBailorInfo)
                {
                    this.SaveOrUpdateDocCasePartyBailorInfoEntity(docCasePartyBailorInfoEntity);
                }
            }
            if (criminalDocCasePartyData.ListDocCasePartyBailorAddress != null && criminalDocCasePartyData.ListDocCasePartyBailorAddress.Count > 0)
            {
                foreach (DocCasePartyBailorAddressEntity docCasePartyBailorAddressEntity in criminalDocCasePartyData.ListDocCasePartyBailorAddress)
                {
                    this.SaveOrUpdateDocCasePartyBailorAddressEntity(docCasePartyBailorAddressEntity);
                }
            }
        }

        internal void SaveOrUpdateDCACAInfoEntity(DCACAInfoEntity dCACAInfoEntity)
        {
            IRepository<DCACAInfo> dCACAInfoRepository = new RepositoryImpl<DCACAInfo>(applicationSession);
        }

        internal void SaveOrUpdateDocCasePartyAddressEntity(DocCasePartyAddressEntity docCasePartyAddressEntity)
        {
            IRepository<DocCasePartyAddress> docCasePartyAddressRepository = new RepositoryImpl<DocCasePartyAddress>(applicationSession);
            docCasePartyAddressRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAddress(docCasePartyAddressEntity));
        }

        internal void SaveOrUpdateDocCasePartyAICAddressEntity(DocCasePartyAICAddressEntity docCasePartyAICAddressEntity)
        {
            IRepository<DocCasePartyAICAddress> docCasePartyAICAddressRepository = new RepositoryImpl<DocCasePartyAICAddress>(applicationSession);
            docCasePartyAICAddressRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAICAddress(docCasePartyAICAddressEntity));
        }

        internal void SaveOrUpdateDocCasePartyAICAliasEntity(DocCasePartyAICAliasEntity docCasePartyAICAliasEntity)
        {
            IRepository<DocCasePartyAICAlias> docCasePartyAICAliasRepository = new RepositoryImpl<DocCasePartyAICAlias>(applicationSession);
            docCasePartyAICAliasRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAICAlias(docCasePartyAICAliasEntity));
        }

        internal void SaveOrUpdateDocCasePartyAICDetailsEntity(DocCasePartyAICDetailsEntity docCasePartyAICDetailsEntity)
        {
            IRepository<DocCasePartyAICDetail> docCasePartyAICDetailRepository = new RepositoryImpl<DocCasePartyAICDetail>(applicationSession);
            docCasePartyAICDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAICDetail(docCasePartyAICDetailsEntity));

            if (docCasePartyAICDetailsEntity.DocCasePartyAICAddresses != null && docCasePartyAICDetailsEntity.DocCasePartyAICAddresses.Count > 0)
            {
                foreach (DocCasePartyAICAddressEntity docCasePartyAICAddressEntity in docCasePartyAICDetailsEntity.DocCasePartyAICAddresses)
                {
                    IRepository<DocCasePartyAICAddress> docCasePartyAICAddressRepository = new RepositoryImpl<DocCasePartyAICAddress>(applicationSession);
                    docCasePartyAICAddressRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAICAddress(docCasePartyAICAddressEntity));
                }
            }

            if (docCasePartyAICDetailsEntity.DocCasePartyAICAliases != null && docCasePartyAICDetailsEntity.DocCasePartyAICAliases.Count > 0)
            {
                foreach (DocCasePartyAICAliasEntity docCasePartyAICAliasEntity in docCasePartyAICDetailsEntity.DocCasePartyAICAliases)
                {
                    IRepository<DocCasePartyAICAlias> docCasePartyAICAliasRepository = new RepositoryImpl<DocCasePartyAICAlias>(applicationSession);
                    docCasePartyAICAliasRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAICAlias(docCasePartyAICAliasEntity));
                }
            }
        }

        internal void SaveOrUpdateDocCasePartyAICDetailsEntityWithChild(DocCasePartyAICDetailsEntity docCasePartyAICDetailsEntity, bool isCopy)
        {
            IRepository<DocCasePartyAICDetail> docCasePartyAICDetailRepository = new RepositoryImpl<DocCasePartyAICDetail>(applicationSession);
            docCasePartyAICDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAICDetail(docCasePartyAICDetailsEntity), isCopy);

            if (docCasePartyAICDetailsEntity.DocCasePartyAICAddresses != null && docCasePartyAICDetailsEntity.DocCasePartyAICAddresses.Count > 0)
            {
                foreach (DocCasePartyAICAddressEntity docCasePartyAICAddressEntity in docCasePartyAICDetailsEntity.DocCasePartyAICAddresses)
                {
                    IRepository<DocCasePartyAICAddress> docCasePartyAICAddressRepository = new RepositoryImpl<DocCasePartyAICAddress>(applicationSession);
                    docCasePartyAICAddressRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAICAddress(docCasePartyAICAddressEntity), isCopy);
                }
            }

            if (docCasePartyAICDetailsEntity.DocCasePartyAICAliases != null && docCasePartyAICDetailsEntity.DocCasePartyAICAliases.Count > 0)
            {
                foreach (DocCasePartyAICAliasEntity docCasePartyAICAliasEntity in docCasePartyAICDetailsEntity.DocCasePartyAICAliases)
                {
                    IRepository<DocCasePartyAICAlias> docCasePartyAICAliasRepository = new RepositoryImpl<DocCasePartyAICAlias>(applicationSession);
                    docCasePartyAICAliasRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAICAlias(docCasePartyAICAliasEntity), isCopy);
                }
            }
        }

        internal void SaveOrUpdateDocCasePartyAliasEntity(DocCasePartyAliasEntity docCasePartyAliasEntity)
        {
            IRepository<DocCasePartyAlias> docCasePartyAliasRepository = new RepositoryImpl<DocCasePartyAlias>(applicationSession);
            docCasePartyAliasRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAlias(docCasePartyAliasEntity));
        }

        internal void SaveOrUpdateDocCasePartyAuthorisedOfficerDetailsEntity(DocCasePartyAuthorisedOfficerDetailsEntity docCasePartyAuthorisedOfficerDetailEntity)
        {
            IRepository<DocCasePartyAuthorisedOfficerDetail> docCasePartyAuthorisedOfficerDetailRepository = new RepositoryImpl<DocCasePartyAuthorisedOfficerDetail>(applicationSession);
            docCasePartyAuthorisedOfficerDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAuthorisedOfficerDetail(docCasePartyAuthorisedOfficerDetailEntity));
        }

        internal void SaveOrUpdateDocCasePartyBailorAddressEntity(DocCasePartyBailorAddressEntity docCasePartyBailorAddressEntity)
        {
            IRepository<DocCasePartyBailorAddress> docCasePartyBailorAddressRepository = new RepositoryImpl<DocCasePartyBailorAddress>(applicationSession);
            docCasePartyBailorAddressRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyBailorAddress(docCasePartyBailorAddressEntity));
        }

        internal void SaveOrUpdateDocCasePartyBailorInfoEntity(DocCasePartyBailorInfoEntity docCasePartyBailorInfoEntity)
        {
            IRepository<DocCasePartyBailorInfo> docCasePartyBailorInfoRepository = new RepositoryImpl<DocCasePartyBailorInfo>(applicationSession);
            docCasePartyBailorInfoRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyBailorInfo(docCasePartyBailorInfoEntity));
        }

        internal void SaveOrUpdateDocCasePartyCitizenshipEntity(DocCasePartyCitizenshipEntity docCasePartyCitizenshipEntity)
        {
            IRepository<DocCasePartyCitizenship> docCasePartyCitizenshipRepository = new RepositoryImpl<DocCasePartyCitizenship>(applicationSession);
            docCasePartyCitizenshipRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyCitizenship(docCasePartyCitizenshipEntity));
        }

        internal void SaveOrUpdateDocCasePartyCriminalInfoEntity(DocCasePartyCriminalInfoEntity docCasePartyCriminalInfoEntity)
        {
            IRepository<DocCasePartyCriminalInfo> docCasePartyCriminalInfoRepository = new RepositoryImpl<DocCasePartyCriminalInfo>(applicationSession);
            docCasePartyCriminalInfoRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyCriminalInfo(docCasePartyCriminalInfoEntity));
        }

        internal void SaveOrUpdateDocCasePartyData(IDocCasePartyData iDocCaseParty)
        {
            lock (doCasePartyLock)
            {
                DocCasePartyData docCasePartyData = iDocCaseParty as DocCasePartyData;

                if (docCasePartyData.DocCasePartyEntity != null)
                {
                    this.SaveOrUpdateDocCasePartyEntity(docCasePartyData.DocCasePartyEntity);
                }
                if (docCasePartyData.DocCasePartyAddresses != null && docCasePartyData.DocCasePartyAddresses.Count > 0)
                {
                    foreach (DocCasePartyAddressEntity docCPAddress in docCasePartyData.DocCasePartyAddresses)
                    {
                        this.SaveOrUpdateDocCasePartyAddressEntity(docCPAddress);
                    }
                }
                if (docCasePartyData.DocCasePartyAliases != null && docCasePartyData.DocCasePartyAliases.Count > 0)
                {
                    foreach (DocCasePartyAliasEntity docCPAlias in docCasePartyData.DocCasePartyAliases)
                    {
                        this.SaveOrUpdateDocCasePartyAliasEntity(docCPAlias);
                    }
                }
                if (docCasePartyData.DocCasePartyAICDetails != null && docCasePartyData.DocCasePartyAICDetails.Count > 0)
                {
                    foreach (DocCasePartyAICDetailsEntity docCPAICDetail in docCasePartyData.DocCasePartyAICDetails)
                    {
                        this.SaveOrUpdateDocCasePartyAICDetailsEntity(docCPAICDetail);
                    }
                }
                if (docCasePartyData.DocCasePartyAuthorisedOfficerDetails != null && docCasePartyData.DocCasePartyAuthorisedOfficerDetails.Count > 0)
                {
                    foreach (DocCasePartyAuthorisedOfficerDetailsEntity docCPAuthorisedOfficerDetail in docCasePartyData.DocCasePartyAuthorisedOfficerDetails)
                    {
                        this.SaveOrUpdateDocCasePartyAuthorisedOfficerDetailsEntity(docCPAuthorisedOfficerDetail);
                    }
                }
                if (docCasePartyData.DocCasePartyVesselDetails != null && docCasePartyData.DocCasePartyVesselDetails.Count > 0)
                {
                    foreach (DocCasePartyVesselDetailsEntity docCPVesselDetail in docCasePartyData.DocCasePartyVesselDetails)
                    {
                        this.SaveOrUpdateDocCasePartyVesselDetailsEntity(docCPVesselDetail);
                    }
                }
                if (docCasePartyData.DocCaseSolicitors != null && docCasePartyData.DocCaseSolicitors.Count > 0)
                {
                    foreach (DocCaseSolicitorEntity docCPSolicitor in docCasePartyData.DocCaseSolicitors)
                    {
                        this.SaveOrUpdateDocCaseSolicitorEntity(docCPSolicitor);
                    }
                }
                if (docCasePartyData.DocCasePartyCriminalInfo != null)
                {
                    this.SaveOrUpdateDocCasePartyCriminalInfoEntity(docCasePartyData.DocCasePartyCriminalInfo);
                }
                if (docCasePartyData.DocCasePartyBailorInfos != null && docCasePartyData.DocCasePartyBailorInfos.Count > 0)
                {
                    foreach (DocCasePartyBailorInfoEntity docCasePartyBailorInfoEntity in docCasePartyData.DocCasePartyBailorInfos)
                    {
                        this.SaveOrUpdateDocCasePartyBailorInfoEntity(docCasePartyBailorInfoEntity);

                        if (docCasePartyBailorInfoEntity.DocCasePartyBailorAddresses != null && docCasePartyBailorInfoEntity.DocCasePartyBailorAddresses.Count > 0)
                        {
                            foreach (DocCasePartyBailorAddressEntity docCasePartyBailorAddressEntity in docCasePartyBailorInfoEntity.DocCasePartyBailorAddresses)
                            {
                                this.SaveOrUpdateDocCasePartyBailorAddressEntity(docCasePartyBailorAddressEntity);
                            }
                        }
                    }
                }
                if (docCasePartyData.DocCasePartyCitizenships != null && docCasePartyData.DocCasePartyCitizenships.Count > 0)
                {
                    foreach (DocCasePartyCitizenshipEntity docCasePartyCitizenshipEntity in docCasePartyData.DocCasePartyCitizenships)
                    {
                        this.SaveOrUpdateDocCasePartyCitizenshipEntity(docCasePartyCitizenshipEntity);
                    }
                }

                if (docCasePartyData.DocPartyCaseFileRefNumberEntity != null)
                {
                    this.SaveOrUpdateDocPartyCaseFileRefNumberEntity(docCasePartyData.DocPartyCaseFileRefNumberEntity);
                }
            }
        }

        internal void SaveOrUpdateDocCasePartyEntity(DocCasePartyEntity docCasePartyEntity)
        {
            IRepository<DocCaseParty> docCasePartyRepository = new RepositoryImpl<DocCaseParty>(applicationSession);

            docCasePartyRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCaseParty(docCasePartyEntity));
        }

        internal void SaveOrUpdateDocCasePartyVesselDetailsEntity(DocCasePartyVesselDetailsEntity docCasePartyVesselDetailsEntity)
        {
            IRepository<DocCasePartyVesselDetail> docCasePartyVesselDetailRepository = new RepositoryImpl<DocCasePartyVesselDetail>(applicationSession);
            docCasePartyVesselDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyVesselDetails(docCasePartyVesselDetailsEntity));
        }

        internal void SaveOrUpdateDocCaseSolicitorEntity(DocCaseSolicitorEntity docCaseSolicitorEntity)
        {
            IRepository<DocCaseSolicitor> docCaseSolicitorRepository = new RepositoryImpl<DocCaseSolicitor>(applicationSession);
            docCaseSolicitorRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCaseSolicitor(docCaseSolicitorEntity));
        }

        internal void SaveOrUpdateDocumentInfoEntity(DocumentInfoEntity documentInfoEntity)
        {
            SaveOrUpdateDocumentInfoSP(documentInfoEntity);
            //IRepository<DocumentInfo> documentInfoRepository = new RepositoryImpl<DocumentInfo>(applicationSession);
            //documentInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocumentInfo(documentInfoEntity));

        }

        /// <summary>
        /// Passes the domain object and save it.
        /// </summary>
        /// <param name="entityToSave">The domain object to be saved.<param>
        /// <returns></returns>
        internal void SaveOrUpdateEntity<T>(T entityToSave)
        {
            IRepository<T> commonRepository = new RepositoryImpl<T>(applicationSession);
            commonRepository.SaveOrUpdate(entityToSave);
        }

        /// <summary>
        /// Passes the domain object and save it.
        /// </summary>
        /// <param name="entityToSave">The domain object to be saved.<param>
        /// <returns></returns>
        internal void SaveOrUpdateInMemoryEntity<T>(T entityToSave)
        {
            IRepository<T> commonRepository = new RepositoryImpl<T>(applicationSession);
            commonRepository.SaveOrUpdateCopy(entityToSave);
        }

        internal void SaveOrUpdateRDocCaseEntity(RDocCaseEntity rDOCCaseEntity)
        {
            IRepository<RDocCase> rDocCaseRepository = new RepositoryImpl<RDocCase>(applicationSession);
            rDocCaseRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetRDocCase(rDOCCaseEntity));
        }

        internal void SaveOrUpdateRDocCasePartyEntity(RDocCasePartyEntity rDocCasePartyEntity)
        {
            IRepository<RDocCaseParty> rDocCasePartyRepository = new RepositoryImpl<RDocCaseParty>(applicationSession);
            rDocCasePartyRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetRDocCaseParty(rDocCasePartyEntity));
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the DocCasePartyAddress
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteDocCasePartyAddress(DetachedCriteria detachedCriteria)
        {
            List<DocCasePartyAddress> listDocCasePartyAddressToDelete = this.GetDocCasePartyAddress(detachedCriteria);
            IRepository<DocCasePartyAddress> docDocCasePartyAddressRepository = new RepositoryImpl<DocCasePartyAddress>(applicationSession);

            docDocCasePartyAddressRepository.DeleteAll(listDocCasePartyAddressToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the DocCasePartyAICAddress
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteDocCasePartyAICAddress(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyAICAddress> docCasePartyAICAddressRepository = new RepositoryImpl<DocCasePartyAICAddress>(applicationSession);
            List<DocCasePartyAICAddress> listDocCasePartyAICAddressToDelete = this.GetDocCasePartyAICAddress(detachedCriteria);

            docCasePartyAICAddressRepository.DeleteAll(listDocCasePartyAICAddressToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the DocCasePartyAICAlias
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteDocCasePartyAICAlias(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyAICAlias> docCasePartyAICAliasRepository = new RepositoryImpl<DocCasePartyAICAlias>(applicationSession);
            List<DocCasePartyAICAlias> listDocCasePartyAICAliasToDelete = this.GetDocCasePartyAICAlias(detachedCriteria);

            docCasePartyAICAliasRepository.DeleteAll(listDocCasePartyAICAliasToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the DocCasePartyAICDetail
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteDocCasePartyAICDetail(DetachedCriteria detachedCriteria)
        {
            List<DocCasePartyAICDetail> listDocCasePartyAICDetailToDelete = this.GetDocCasePartyAICDetail(detachedCriteria);
            IRepository<DocCasePartyAICDetail> docCasePartyAICDetailRepository = new RepositoryImpl<DocCasePartyAICDetail>(applicationSession);

            //Refactor - search NHibernate feature to solve this requirement (deleting child) in better way.
            //Delete childs data first if there are some.
            foreach (DocCasePartyAICDetail aicAddress in listDocCasePartyAICDetailToDelete)
            {
                if (aicAddress.DocCasePartyAICAddresses.Count > 0)
                {
                    this.DeleteDocCasePartyAICAddressEntity(aicAddress.DCPAICID);
                }

                if (aicAddress.DocCasePartyAICAliases.Count > 0)
                {
                    this.DeleteDocCasePartyAICAliasEntity(aicAddress.DCPAICID);
                }
            }

            //Delete the parents records finally.
            docCasePartyAICDetailRepository.DeleteAll(listDocCasePartyAICDetailToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the DocCasePartyAlias
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteDocCasePartyAlias(DetachedCriteria detachedCriteria)
        {
            List<DocCasePartyAlias> listDocCasePartyAliasToDelete = this.GetDocCasePartyAlias(detachedCriteria);
            IRepository<DocCasePartyAlias> docCasePartyAliasRepository = new RepositoryImpl<DocCasePartyAlias>(applicationSession);

            docCasePartyAliasRepository.DeleteAll(listDocCasePartyAliasToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the DocCasePartyAuthorisedOfficerDetail
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteDocCasePartyAuthorisedOfficerDetail(DetachedCriteria detachedCriteria)
        {
            List<DocCasePartyAuthorisedOfficerDetail> listDocCasePartyAuthorisedOfficerDetailToDelete = this.GetListDocCasePartyAuthorisedOfficerDetail(detachedCriteria);
            IRepository<DocCasePartyAuthorisedOfficerDetail> docCasePartyAuthorisedOfficerDetailRepository = new RepositoryImpl<DocCasePartyAuthorisedOfficerDetail>(applicationSession);

            docCasePartyAuthorisedOfficerDetailRepository.DeleteAll(listDocCasePartyAuthorisedOfficerDetailToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the DocCasePartyCitizenship
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteDocCasePartyCitizenship(DetachedCriteria detachedCriteria)
        {
            List<DocCasePartyCitizenship> listDocCasePartyCitizenshipToDelete = this.GetDocCasePartyCitizenship(detachedCriteria);
            IRepository<DocCasePartyCitizenship> docDocCasePartyCitizenshipRepository = new RepositoryImpl<DocCasePartyCitizenship>(applicationSession);

            docDocCasePartyCitizenshipRepository.DeleteAll(listDocCasePartyCitizenshipToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the DocCasePartyVesselDetail
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteDocCasePartyVesselDetail(DetachedCriteria detachedCriteria)
        {
            List<DocCasePartyVesselDetail> listDocCasePartyVesselDetailToDelete = this.GetListDocCasePartyVesselDetail(detachedCriteria);
            IRepository<DocCasePartyVesselDetail> docCasePartyVesselDetailRepository = new RepositoryImpl<DocCasePartyVesselDetail>(applicationSession);

            docCasePartyVesselDetailRepository.DeleteAll(listDocCasePartyVesselDetailToDelete);
        }

        /// <summary>
        /// Passes the DetachedCriteria and delete the DocCaseSolicitor
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private void DeleteDocCaseSolicitor(DetachedCriteria detachedCriteria)
        {
            List<DocCaseSolicitor> listDocCaseSolicitorToDelete = this.GetDocCaseSolicitor(detachedCriteria);
            IRepository<DocCaseSolicitor> docCaseSolicitorRepository = new RepositoryImpl<DocCaseSolicitor>(applicationSession);

            docCaseSolicitorRepository.DeleteAll(listDocCaseSolicitorToDelete);
        }

        private void DeleteFromDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            repository.DeleteAll(repository.GetAll(detachedCriteria).ToList());
        }

        private List<DocCasePartyAddress> GetAllDocCasePartyAddress(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyAddress> docCasePartyAddressRepository = new RepositoryImpl<DocCasePartyAddress>(applicationSession);
            return docCasePartyAddressRepository.GetAll(detachedCriteria) as List<DocCasePartyAddress>;
        }

        private List<DocCasePartyAuthorisedOfficerDetail> GetAllDocCasePartyAuthorisedOfficerDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyAuthorisedOfficerDetail> docCasePartyAuthorisedOfficerDetailRepository = new RepositoryImpl<DocCasePartyAuthorisedOfficerDetail>(applicationSession);
            return docCasePartyAuthorisedOfficerDetailRepository.GetAll(detachedCriteria) as List<DocCasePartyAuthorisedOfficerDetail>;
        }

        private List<DocCasePartyVesselDetail> GetAllDocCasePartyVesselDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyVesselDetail> docCasePartyVesselDetailRepository = new RepositoryImpl<DocCasePartyVesselDetail>(applicationSession);
            return docCasePartyVesselDetailRepository.GetAll(detachedCriteria) as List<DocCasePartyVesselDetail>;
        }

        private List<DocCaseSolicitor> GetAllDocCaseSolicitor(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCaseSolicitor> docCaseSolicitorRepository = new RepositoryImpl<DocCaseSolicitor>(applicationSession);
            return docCaseSolicitorRepository.GetAll(detachedCriteria) as List<DocCaseSolicitor>;
        }

        private List<DocumentInfo> GetAllDocumentInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<DocumentInfo> documentInfoRepository = new RepositoryImpl<DocumentInfo>(applicationSession);
            return documentInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<RDocCase> GetAllRDocCase(DetachedCriteria detachedCriteria)
        {
            IRepository<RDocCase> rDocCaseRepository = new RepositoryImpl<RDocCase>(applicationSession);
            return rDocCaseRepository.GetAll(detachedCriteria).ToList();
        }

        private List<RDocCaseParty> GetAllRDocCaseParty(DetachedCriteria detachedCriteria)
        {
            IRepository<RDocCaseParty> rDocCasePartyRepository = new RepositoryImpl<RDocCaseParty>(applicationSession);
            return rDocCasePartyRepository.GetAll(detachedCriteria) as List<RDocCaseParty>;
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

        private DocCaseParty GetDocCaseParty(Criteria criteria)
        {
            IRepository<DocCaseParty> docCasePartyRepository = new RepositoryImpl<DocCaseParty>(applicationSession);
            return docCasePartyRepository.Get(criteria.Value);
        }

        private List<DocCasePartyAddress> GetDocCasePartyAddress(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyAddress> docCasePartyAddressRepository = new RepositoryImpl<DocCasePartyAddress>(applicationSession);
            return docCasePartyAddressRepository.GetAll(detachedCriteria) as List<DocCasePartyAddress>;
        }

        private DocCasePartyAICAddress GetDocCasePartyAICAddress(Criteria criteria)
        {
            DocCasePartyAICAddress docCasePartyAICAddress = new DocCasePartyAICAddress();
            IRepository<DocCasePartyAICAddress> docCasePartyAICAddressRepository = new RepositoryImpl<DocCasePartyAICAddress>(applicationSession);

            docCasePartyAICAddress = docCasePartyAICAddressRepository.Get(criteria.Value);

            return docCasePartyAICAddress;
        }

        private List<DocCasePartyAICAddress> GetDocCasePartyAICAddress(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyAICAddress> docCasePartyAICAddressRepository = new RepositoryImpl<DocCasePartyAICAddress>(applicationSession);
            return docCasePartyAICAddressRepository.GetAll(detachedCriteria) as List<DocCasePartyAICAddress>;
        }

        private DocCasePartyAICAlias GetDocCasePartyAICAlias(Criteria criteria)
        {
            DocCasePartyAICAlias docCasePartyAICAlias = new DocCasePartyAICAlias();
            IRepository<DocCasePartyAICAlias> docCasePartyAICAliasRepository = new RepositoryImpl<DocCasePartyAICAlias>(applicationSession);

            docCasePartyAICAlias = docCasePartyAICAliasRepository.Get(criteria.Value);

            return docCasePartyAICAlias;
        }

        private List<DocCasePartyAICAlias> GetDocCasePartyAICAlias(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyAICAlias> docCasePartyAICAliasRepository = new RepositoryImpl<DocCasePartyAICAlias>(applicationSession);
            return docCasePartyAICAliasRepository.GetAll(detachedCriteria) as List<DocCasePartyAICAlias>;
        }

        private DocCasePartyAICDetail GetDocCasePartyAICDetail(Criteria criteria)
        {
            DocCasePartyAICDetail docCasePartyAICDetail = new DocCasePartyAICDetail();
            IRepository<DocCasePartyAICDetail> docCasePartyAICDetailRepository = new RepositoryImpl<DocCasePartyAICDetail>(applicationSession);

            docCasePartyAICDetail = docCasePartyAICDetailRepository.Get(criteria.Value);

            return docCasePartyAICDetail;
        }

        private List<DocCasePartyAICDetail> GetDocCasePartyAICDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyAICDetail> docCasePartyAICDetailRepository = new RepositoryImpl<DocCasePartyAICDetail>(applicationSession);
            return docCasePartyAICDetailRepository.GetAll(detachedCriteria) as List<DocCasePartyAICDetail>;
        }

        private DocCasePartyAlias GetDocCasePartyAlias(Criteria criteria)
        {
            DocCasePartyAlias docCasePartyAlias = new DocCasePartyAlias();
            IRepository<DocCasePartyAlias> docCasePartyAliasRepository = new RepositoryImpl<DocCasePartyAlias>(applicationSession);
            docCasePartyAlias = docCasePartyAliasRepository.Get(criteria.Value);

            return docCasePartyAlias;
        }

        private List<DocCasePartyAlias> GetDocCasePartyAlias(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyAlias> docCasePartyAliasRepository = new RepositoryImpl<DocCasePartyAlias>(applicationSession);
            return docCasePartyAliasRepository.GetAll(detachedCriteria) as List<DocCasePartyAlias>;
        }

        private DocCasePartyAuthorisedOfficerDetail GetDocCasePartyAuthorisedOfficerDetail(Criteria criteria)
        {
            DocCasePartyAuthorisedOfficerDetail docCasePartyAuthorisedOfficerDetail = new DocCasePartyAuthorisedOfficerDetail();
            IRepository<DocCasePartyAuthorisedOfficerDetail> docCasePartyAuthorisedOfficerDetailRepository = new RepositoryImpl<DocCasePartyAuthorisedOfficerDetail>(applicationSession);
            docCasePartyAuthorisedOfficerDetail = docCasePartyAuthorisedOfficerDetailRepository.Get(criteria.Value);

            return docCasePartyAuthorisedOfficerDetail;
        }

        /*
        private DocCasePartyCriminalInfo GetDocCasePartyCriminalInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyCriminalInfo> docCasePartyCriminalInfoRepository = new RepositoryImpl<DocCasePartyCriminalInfo>(applicationSession);
            return docCasePartyCriminalInfoRepository.Get(detachedCriteria) as DocCasePartyCriminalInfo;
        }*/
        private List<DocCasePartyBailorAddress> GetDocCasePartyBailorAddress(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyBailorAddress> docCasePartyBailorAddressRepository = new RepositoryImpl<DocCasePartyBailorAddress>(applicationSession);
            return docCasePartyBailorAddressRepository.GetAll(detachedCriteria) as List<DocCasePartyBailorAddress>;
        }

        private List<DocCasePartyBailorInfo> GetDocCasePartyBailorInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyBailorInfo> docCasePartyBailorInfoRepository = new RepositoryImpl<DocCasePartyBailorInfo>(applicationSession);
            return docCasePartyBailorInfoRepository.GetAll(detachedCriteria) as List<DocCasePartyBailorInfo>;
        }

        /// <summary>
        /// Passes the DetachedCriteria and get a list DocCasePartyCitizenship.
        /// </summary>
        /// <param name="DetachedCriteria">The NHibernate DetachedCriteria.</param>
        /// <returns></returns>
        private List<DocCasePartyCitizenship> GetDocCasePartyCitizenship(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyCitizenship> docCasePartyCitizenshipRepository = new RepositoryImpl<DocCasePartyCitizenship>(applicationSession);
            return docCasePartyCitizenshipRepository.GetAll(detachedCriteria) as List<DocCasePartyCitizenship>;
        }

        private DocCasePartyVesselDetail GetDocCasePartyVesselDetail(Criteria criteria)
        {
            DocCasePartyVesselDetail docCasePartyVesselDetail = new DocCasePartyVesselDetail();
            IRepository<DocCasePartyVesselDetail> docCasePartyVesselDetailRepository = new RepositoryImpl<DocCasePartyVesselDetail>(applicationSession);

            docCasePartyVesselDetail = docCasePartyVesselDetailRepository.Get(criteria.Value);

            return docCasePartyVesselDetail;
        }

        private List<DocCaseSolicitor> GetDocCaseSolicitor(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCaseSolicitor> docCaseSolicitorRepository = new RepositoryImpl<DocCaseSolicitor>(applicationSession);
            return docCaseSolicitorRepository.GetAll(detachedCriteria) as List<DocCaseSolicitor>;
        }

        private List<DocumentInfo> GetDocumentInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<DocumentInfo> documentInfoRepository = new RepositoryImpl<DocumentInfo>(applicationSession);
            return documentInfoRepository.GetAll(detachedCriteria) as List<DocumentInfo>;
        }

        private List<T> GetFromDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll(detachedCriteria).ToList();
        }

        private List<DocCasePartyAuthorisedOfficerDetail> GetListDocCasePartyAuthorisedOfficerDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyAuthorisedOfficerDetail> docDocCasePartyAuthorisedOfficerDetailRepository = new RepositoryImpl<DocCasePartyAuthorisedOfficerDetail>(applicationSession);
            return docDocCasePartyAuthorisedOfficerDetailRepository.GetAll(detachedCriteria) as List<DocCasePartyAuthorisedOfficerDetail>;
        }

        private List<DocCasePartyBailorAddress> GetListDocCasePartyBailorAddressByDCPId(string DCPId)
        {
            List<DocCasePartyBailorAddress> listDocCasePartyBailorAddress = new List<DocCasePartyBailorAddress>();

            List<DocCasePartyBailorInfo> listDocCasePartyBailorInfo = GetListDocCasePartyBailorInfoByDCPId(DCPId);
            foreach (DocCasePartyBailorInfo dcpbie in listDocCasePartyBailorInfo)
            {
                if (dcpbie != null)
                    listDocCasePartyBailorAddress.AddRange(GetListDocCasePartyBailorAddressByDocCasePartyBailorInfoId(dcpbie.DocCasePartyBailorInfoId));
            }

            //if (listDocCasePartyBailorAddress != null && listDocCasePartyBailorAddress.Count > 0)
            //{
            return listDocCasePartyBailorAddress;
            //}
            //else
            //{
            //    return null;
            //}
        }

        private List<DocCasePartyBailorAddress> GetListDocCasePartyBailorAddressByDocCasePartyBailorInfoId(string DocCasePartyBailorInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyBailorAddress))
                                                                            .Add(Expression.Eq("DocCasePartyBailorInfoId", DocCasePartyBailorInfoId));

            List<DocCasePartyBailorAddress> listDocCasePartyBailorAddress = GetDocCasePartyBailorAddress(detachedCriteria);
            return listDocCasePartyBailorAddress;
        }

        private List<DocCasePartyBailorInfo> GetListDocCasePartyBailorInfoByDCPId(string DCPId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyBailorInfo))
                                                                            .Add(Expression.Eq("DCPID", DCPId));

            List<DocCasePartyBailorInfo> listDocCasePartyBailorInfo = GetDocCasePartyBailorInfo(detachedCriteria);

            return listDocCasePartyBailorInfo;
        }

        private List<DocCasePartyCitizenship> GetListDocCasePartyCitizenship(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyCitizenship> docCasePartyCitizenshipRepository = new RepositoryImpl<DocCasePartyCitizenship>(applicationSession);
            return docCasePartyCitizenshipRepository.GetAll(detachedCriteria) as List<DocCasePartyCitizenship>;
        }

        private List<DocCasePartyCitizenship> GetListDocCasePartyCitizenshipByDCPId(string DCPId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyCitizenship))
                                                                            .Add(Expression.Eq("DCPID", DCPId));

            List<DocCasePartyCitizenship> listDocCasePartyCitizenship = GetListDocCasePartyCitizenship(detachedCriteria);
            return listDocCasePartyCitizenship;
        }

        private List<DocCasePartyCriminalInfo> GetListDocCasePartyCriminalInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyCriminalInfo> docCasePartyCriminalInfoRepository = new RepositoryImpl<DocCasePartyCriminalInfo>(applicationSession);
            return docCasePartyCriminalInfoRepository.GetAll(detachedCriteria) as List<DocCasePartyCriminalInfo>;
        }

        private List<DocCasePartyCriminalInfo> GetListDocCasePartyCriminalInfoByDCPId(string DCPId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyCriminalInfo))
                                                                            .Add(Expression.Eq("DCPID", DCPId));

            List<DocCasePartyCriminalInfo> listDocCasePartyCriminalInfo = GetListDocCasePartyCriminalInfo(detachedCriteria);
            return listDocCasePartyCriminalInfo;
        }

        private List<DocCasePartyVesselDetail> GetListDocCasePartyVesselDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<DocCasePartyVesselDetail> docCasePartyVesselDetailRepository = new RepositoryImpl<DocCasePartyVesselDetail>(applicationSession);
            return docCasePartyVesselDetailRepository.GetAll(detachedCriteria) as List<DocCasePartyVesselDetail>;
        }

        private RDocCaseParty GetRDocCaseParty(Criteria criteria)
        {
            IRepository<RDocCaseParty> rDocCasePartyRepository = new RepositoryImpl<RDocCaseParty>(applicationSession);
            return rDocCasePartyRepository.Get(criteria.Value);
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

        private void SaveOrUpdateCriminalDocCasePartyData(CriminalDocCasePartyData criminalDocCasePartyData, bool isCopy)
        {
            if (criminalDocCasePartyData.ListDocCasePartyCriminalInfo != null && criminalDocCasePartyData.ListDocCasePartyCriminalInfo.Count > 0)
            {
                List<DocCasePartyCriminalInfo> listDocCasePartyCriminalInfo = criminalDocCasePartyData.ListDocCasePartyCriminalInfo.Select(docCasePartyCriminalInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyCriminalInfo(docCasePartyCriminalInfo)).ToList();
                foreach (DocCasePartyCriminalInfo docCasePartyCriminalInfo in listDocCasePartyCriminalInfo)
                {
                    SaveOrUpdateData(docCasePartyCriminalInfo, isCopy);
                }
            }

            if (criminalDocCasePartyData.ListDocCasePartyBailorInfo != null && criminalDocCasePartyData.ListDocCasePartyBailorInfo.Count > 0)
            {
                List<DocCasePartyBailorInfo> listDocCasePartyBailorInfo = criminalDocCasePartyData.ListDocCasePartyBailorInfo.Select(docCasePartyBailorInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyBailorInfo(docCasePartyBailorInfo)).ToList();
                foreach (DocCasePartyBailorInfo docCasePartyBailorInfo in listDocCasePartyBailorInfo)
                {
                    SaveOrUpdateData(docCasePartyBailorInfo, isCopy);
                }
            }

            if (criminalDocCasePartyData.ListDocCasePartyBailorAddress != null && criminalDocCasePartyData.ListDocCasePartyBailorAddress.Count > 0)
            {
                List<DocCasePartyBailorAddress> listDocCasePartyBailorAddress = criminalDocCasePartyData.ListDocCasePartyBailorAddress.Select(docCasePartyBailorAddress => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyBailorAddress(docCasePartyBailorAddress)).ToList();
                foreach (DocCasePartyBailorAddress docCasePartyBailorAddress in listDocCasePartyBailorAddress)
                {
                    SaveOrUpdateData(docCasePartyBailorAddress, isCopy);
                }
            }
        }

        /// <summary>
        /// Saves the or update data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataToSave">The data to save.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        private void SaveOrUpdateData<T>(T dataToSave, bool isCopy)
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            if (!isCopy)
                repository.SaveOrUpdate(dataToSave);
            else
                repository.SaveOrUpdateCopy(dataToSave);
        }

        /// <summary>
        /// Saves or Updates <see cref="DocCasePartyData"/>
        /// </summary>
        /// <param name="docCasePartyData">The DocCasePartyData.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        private void SaveOrUpdateDocCasePartyData(DocCasePartyData docCasePartyData, bool isCopy)
        {
            if (docCasePartyData.DocCasePartyEntity != null)
            {
                DocCaseParty docCaseParty = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCaseParty(docCasePartyData.DocCasePartyEntity);
                SaveOrUpdateData(docCaseParty, isCopy);
            }

            if (docCasePartyData.DocCasePartyAddresses != null && docCasePartyData.DocCasePartyAddresses.Count > 0)
            {
                List<DocCasePartyAddress> listDocCasePartyAddress = docCasePartyData.DocCasePartyAddresses.Select(docCasePartyAddress => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAddress(docCasePartyAddress)).ToList();
                foreach (DocCasePartyAddress docCasePartyAddress in listDocCasePartyAddress)
                {
                    SaveOrUpdateData(docCasePartyAddress, isCopy);
                }

            }

            if (docCasePartyData.DocCasePartyAliases != null && docCasePartyData.DocCasePartyAliases.Count > 0)
            {
                List<DocCasePartyAlias> listDocCasePartyAlias = docCasePartyData.DocCasePartyAliases.Select(docCasePartyAlias => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAlias(docCasePartyAlias)).ToList();
                foreach (DocCasePartyAlias docCasePartyAlias in listDocCasePartyAlias)
                {
                    SaveOrUpdateData(docCasePartyAlias, isCopy);
                }
            }

            if (docCasePartyData.DocCasePartyAICDetails != null && docCasePartyData.DocCasePartyAICDetails.Count > 0)
            {
                foreach (DocCasePartyAICDetailsEntity docCasePartyAICDetails in docCasePartyData.DocCasePartyAICDetails)
                {
                    this.SaveOrUpdateDocCasePartyAICDetailsEntityWithChild(docCasePartyAICDetails, isCopy);

                }

            }

            if (docCasePartyData.DocCasePartyAuthorisedOfficerDetails != null && docCasePartyData.DocCasePartyAuthorisedOfficerDetails.Count > 0)
            {
                List<DocCasePartyAuthorisedOfficerDetail> listDocCasePartyAuthorisedOfficerDetail = docCasePartyData.DocCasePartyAuthorisedOfficerDetails.Select(docCasePartyAuthorisedOfficerDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyAuthorisedOfficerDetail(docCasePartyAuthorisedOfficerDetail)).ToList();
                foreach (DocCasePartyAuthorisedOfficerDetail docCasePartyAuthorisedOfficerDetail in listDocCasePartyAuthorisedOfficerDetail)
                {
                    SaveOrUpdateData(docCasePartyAuthorisedOfficerDetail, isCopy);
                }
            }

            if (docCasePartyData.DocCasePartyVesselDetails != null && docCasePartyData.DocCasePartyVesselDetails.Count > 0)
            {
                List<DocCasePartyVesselDetail> listDocCasePartyVesselDetail = docCasePartyData.DocCasePartyVesselDetails.Select(docCasePartyVesselDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyVesselDetails(docCasePartyVesselDetail)).ToList();
                foreach (DocCasePartyVesselDetail docCasePartyVesselDetail in listDocCasePartyVesselDetail)
                {
                    SaveOrUpdateData(docCasePartyVesselDetail, isCopy);
                }
            }

            if (docCasePartyData.DocCaseSolicitors != null && docCasePartyData.DocCaseSolicitors.Count > 0)
            {
                List<DocCaseSolicitor> listDocCaseSolicitor = docCasePartyData.DocCaseSolicitors.Select(docCaseSolicitor => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCaseSolicitor(docCaseSolicitor)).ToList();
                foreach (DocCaseSolicitor docCaseSolicitor in listDocCaseSolicitor)
                {
                    SaveOrUpdateData(docCaseSolicitor, isCopy);
                }
            }

            if (docCasePartyData.DocCasePartyLACDetail != null)
            {
                SaveOrUpdateData(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyLACDetail(docCasePartyData.DocCasePartyLACDetail), isCopy);
            }

            if (docCasePartyData.DocCasePartyCitizenships != null && docCasePartyData.DocCasePartyCitizenships.Count > 0)
            {
                List<DocCasePartyCitizenship> listDocCasePartyCitizenship = docCasePartyData.DocCasePartyCitizenships.Select(docCasePartyCitizenship => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyCitizenship(docCasePartyCitizenship)).ToList();
                foreach (DocCasePartyCitizenship docCasePartyCitizenship in listDocCasePartyCitizenship)
                {
                    SaveOrUpdateData(docCasePartyCitizenship, isCopy);
                }
            }
            if (docCasePartyData.DocCasePartyCriminalInfo != null)
            {
                SaveOrUpdateData(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyCriminalInfo(docCasePartyData.DocCasePartyCriminalInfo), isCopy);
            }

            if (docCasePartyData.DocCasePartyBailorInfos != null && docCasePartyData.DocCasePartyBailorInfos.Count > 0)
            {
                foreach (DocCasePartyBailorInfoEntity docCasePartyBailorInfoEntity in docCasePartyData.DocCasePartyBailorInfos)
                {
                    SaveOrUpdateData(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyBailorInfo(docCasePartyBailorInfoEntity), isCopy);

                    if (docCasePartyBailorInfoEntity.DocCasePartyBailorAddresses != null && docCasePartyBailorInfoEntity.DocCasePartyBailorAddresses.Count > 0)
                    {
                        foreach (DocCasePartyBailorAddressEntity docCasePartyBailorAddressEntity in docCasePartyBailorInfoEntity.DocCasePartyBailorAddresses)
                        {
                            SaveOrUpdateData(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocCasePartyBailorAddress(docCasePartyBailorAddressEntity), isCopy);
                        }
                    }
                }
            }
            if (docCasePartyData.DocPartyCaseFileRefNumberEntity != null)
            {
                this.SaveOrUpdateDocPartyCaseFileRefNumberEntity(docCasePartyData.DocPartyCaseFileRefNumberEntity);
            }
        }

        internal void DeleteDocCasePartyAddress(string dcpId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAddress))
              .Add(Expression.Eq("DCPID", dcpId));

            IRepository<DocCasePartyAddress> docCasePartyAddressRepository = new RepositoryImpl<DocCasePartyAddress>(applicationSession);
            docCasePartyAddressRepository.DeleteAll(docCasePartyAddressRepository.GetAll(detachedCriteria).ToList());

        }

        internal List<DocCasePartyEntity> GetDocCasePartyEntityBySubCaseInfoId(string subcaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DocCaseParty>()
                .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(subcaseInfoId)));

            List<DocCaseParty> listDocCaseParty = GetFromDetachedCriteria<DocCaseParty>(detachedCriteria);
            if (listDocCaseParty != null && listDocCaseParty.Count > 0)
            {
                return listDocCaseParty.Select(docCaseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
                    .ObjectMapper.DocumentMapper.GetDocCasePartyEntity(docCaseParty)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal void DeleteDocCasePartyAlias(string dcpId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCasePartyAlias))
               .Add(Expression.Eq("DCPID", dcpId));
            DeleteFromDetachedCriteria<DocCasePartyAlias>(detachedCriteria);
        }



        internal List<DocCommentsEntity> GetListDocComments(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DocComments>()
                .Add(Expression.Eq("DocID", docId));
            List<DocComments> listDocComments = GetFromDetachedCriteria<DocComments>(detachedCriteria);
            if (listDocComments != null && listDocComments.Count > 0)
            {
                return listDocComments.Select(docComments => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCommentsEntity(docComments)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DocumentInfoEntity> GetListDocumentByDocCodeAndSubCaseInfoId(string SubCaseInfoId, string docCode)
        {
            MDocCode mDocCode = new MDocCode { DOCCode = docCode };
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocumentInfo))
                                .Add(Expression.Eq("MDocCode", mDocCode))
                                .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(SubCaseInfoId)));

            List<DocumentInfo> listDocumentInfo = GetFromDetachedCriteria<DocumentInfo>(detachedCriteria);
            if (listDocumentInfo != null && listDocumentInfo.Count > 0)
            {
                return listDocumentInfo.Select(documentInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentInfoEntity(documentInfo)).ToList();
            }
            else
                return null;
        }


        internal List<DocumentInfoEntity> GetCaveatList(string caseTypeCode)
        {
            List<DocumentInfoEntity> listDocumentInfoEntity = null;
            try
            {

                IQuery query = applicationSession.GetNamedQuery("SP_PartyStatusFlip_GetCaveatList")
                     .SetParameter("CaseTypeCode", caseTypeCode);
                List<object> CaveatDocList = query.List<object>().ToList();

                if (CaveatDocList != null && CaveatDocList.Count > 0)
                {
                    listDocumentInfoEntity = new List<DocumentInfoEntity>();
                    foreach (object[] obj in CaveatDocList)
                    {
                        string docId = obj[0].ToString();
                        listDocumentInfoEntity.Add(GetListDocumentInfoByPK(docId)); //TODO: Need to remove this, Temp solution to convert Obj to DocEntity
                    }

                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaveatList", ex);
                throw;
            }

            return listDocumentInfoEntity;

        }

        public DocCaseTierTypeEntity GetDocCaseTierTypeEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocCaseTierType))
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<DocCaseTierType> listDocCaseTierType = GetFromDetachedCriteria<DocCaseTierType>(detachedCriteria);

            if (listDocCaseTierType != null && listDocCaseTierType.Count > 0)
            {
                return listDocCaseTierType.Select(docCaseTierType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocCaseTierTypeEntity(docCaseTierType)).FirstOrDefault();
            }
            else
                return null;
        }

        #endregion Methods


        internal void SaveOrUpdateDocumentInfoSP(IDocumentEntity iDocumentEntity)
        {
            Logger.Debug("Flushing Session to Sync With DB");
            applicationSession.Flush();
            Logger.Debug("Flushing Session Completed");

            Logger.Debug("SaveOrUpdateDocumentInfoSP");
            try
            {
                DocumentInfoEntity docInfoEntity = (DocumentInfoEntity)iDocumentEntity;

                DocumentInfoSP documentInfoSP = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocumentInfoSP(docInfoEntity);

                if (docInfoEntity.MCurrency != null)
                    documentInfoSP.CurrencyCode = docInfoEntity.MCurrency.CurrencyCode;
                if (docInfoEntity.MDocCode != null)
                    documentInfoSP.DOCCode = docInfoEntity.MDocCode.DOCCode;
                if (docInfoEntity.MDocNature != null)
                    documentInfoSP.DocNatureCode = docInfoEntity.MDocNature.DocNatureCode;
                if (docInfoEntity.MDocSecurity != null)
                    documentInfoSP.DocSecurityCode = docInfoEntity.MDocSecurity.DocSecurityCode;
                if (docInfoEntity.MDocStatus != null)
                    documentInfoSP.DocStatusCode = docInfoEntity.MDocStatus.DocStatus;
                if (docInfoEntity.MForumType != null)
                    documentInfoSP.ForumID = docInfoEntity.MForumType.ForumId;


                applicationSession.GetNamedQuery("SaveOrUpdateDocumentInfo")
                        .SetParameter("DOCID", documentInfoSP.DOCID)
                        .SetParameter("DOCCode", documentInfoSP.DOCCode)
                        .SetParameter("DocType", documentInfoSP.DocType)
                        .SetParameter("DocSerialNo", documentInfoSP.DocSerialNo)
                        .SetParameter("DocYear", documentInfoSP.DocYear)
                        .SetParameter("DocTitle", documentInfoSP.DocTitle)
                         .SetParameter("ParentDocId", documentInfoSP.ParentDocId)
                        .SetParameter("Version", documentInfoSP.Version)
                        .SetParameter("FilingType", documentInfoSP.FilingType)
                        .SetParameter("DocNatureCode", documentInfoSP.DocNatureCode)
                        .SetParameter("FilingDateTime", documentInfoSP.FilingDateTime)
                        .SetParameter("ActualFilingDateTime", documentInfoSP.ActualFilingDateTime)
                         .SetParameter("InTrayDateTime", documentInfoSP.InTrayDateTime)
                        .SetParameter("ProcessedBy", documentInfoSP.ProcessedBy)
                        .SetParameter("ProcessedTime", documentInfoSP.ProcessedTime)
                        .SetParameter("ForumID", documentInfoSP.ForumID)
                        .SetParameter("SubmissionGroupID", documentInfoSP.SubmissionGroupID)
                        .SetParameter("DocStatusCode", documentInfoSP.DocStatusCode)
                         .SetParameter("NumberOfPages", documentInfoSP.NumberOfPages)
                        .SetParameter("ExpungeInd", documentInfoSP.ExpungeInd)
                        .SetParameter("DocSecurityCode", documentInfoSP.DocSecurityCode)
                        .SetParameter("BackdateApprInd", documentInfoSP.BackdateApprInd)
                        .SetParameter("BackDateTime", documentInfoSP.BackDateTime)
                        .SetParameter("JOUserIdApprBackDate", documentInfoSP.JOUserIdApprBackDate)
                         .SetParameter("BackDateReasonFrLawFirm", documentInfoSP.BackDateReasonFrLawFirm)
                        .SetParameter("BackDateReasonFrCourt", documentInfoSP.BackDateReasonFrCourt)
                        .SetParameter("HearingDateTime", documentInfoSP.HearingDateTime)
                        .SetParameter("SpecHandlingReqInd", documentInfoSP.SpecHandlingReqInd)
                        .SetParameter("SpecHandlingReqRsn", documentInfoSP.SpecHandlingReqRsn)
                        .SetParameter("SpecHandlingReqRem", documentInfoSP.SpecHandlingReqRem)
                         .SetParameter("WaiverInd", documentInfoSP.WaiverInd)
                        .SetParameter("CurrencyCode", documentInfoSP.CurrencyCode)
                        .SetParameter("LFWaiverReqFee", documentInfoSP.LFWaiverReqFee)
                        .SetParameter("LFWaiverReqReason", documentInfoSP.LFWaiverReqReason)
                        .SetParameter("WaiverApproveInd", documentInfoSP.WaiverApproveInd)
                        .SetParameter("WaiverApproveUserId", documentInfoSP.WaiverApproveUserId)

                        .SetParameter("WaiverApprFee", documentInfoSP.WaiverApprFee)
                        .SetParameter("WaiverApprReason", documentInfoSP.WaiverApprReason)
                        .SetParameter("Remarks", documentInfoSP.Remarks)
                        .SetParameter("LFID", documentInfoSP.LFID)
                        .SetParameter("EndorsementType", documentInfoSP.EndorsementType)
                        .SetParameter("DraftFileName", documentInfoSP.DraftFileName)
                         .SetParameter("DraftLocation", documentInfoSP.DraftLocation)
                        .SetParameter("DraftProcessType", documentInfoSP.DraftProcessType)
                        .SetParameter("DraftFormName", documentInfoSP.DraftFormName)
                        .SetParameter("DraftDateTime", documentInfoSP.DraftDateTime)
                        .SetParameter("SentFileName", documentInfoSP.SentFileName)
                        .SetParameter("SentLocation", documentInfoSP.SentLocation)
                         .SetParameter("SentProcessType", documentInfoSP.SentProcessType)
                        .SetParameter("SentFormName", documentInfoSP.SentFormName)
                        .SetParameter("SentDateTime", documentInfoSP.SentDateTime)
                        .SetParameter("RecFileName", documentInfoSP.RecFileName)
                        .SetParameter("RecLocation", documentInfoSP.RecLocation)
                        .SetParameter("RecProcessType", documentInfoSP.RecProcessType)
                         .SetParameter("RecFormName", documentInfoSP.RecFormName)
                        .SetParameter("RecDateTime", documentInfoSP.RecDateTime)
                        .SetParameter("ObsInd", documentInfoSP.ObsInd)
                        .SetParameter("LastModifiedBy", documentInfoSP.LastModifiedBy)
                        .SetParameter("LastModifiedDate", documentInfoSP.LastModifiedDate)
                        .SetParameter("Isvalidated", documentInfoSP.IsValidated)
                         .SetParameter("ProcessType", documentInfoSP.ProcessType)
                        .SetParameter("FiledBy", documentInfoSP.FiledBy)
                        .SetParameter("HRGID", documentInfoSP.HRGID)
                        .SetParameter("IsUrgent", documentInfoSP.IsUrgent)
                        .SetParameter("RelatedDocID", documentInfoSP.RelatedDocID)
                        .SetParameter("FECopy", documentInfoSP.FECopy)
                         .SetParameter("OCRInd", documentInfoSP.OCRInd)
                        .SetParameter("DraftFNID", documentInfoSP.DraftFNID)
                        .SetParameter("SentFNID", documentInfoSP.SentFNID)
                        .SetParameter("RecFNID", documentInfoSP.RecFNID)
                        .SetParameter("IsReplyProcessed", documentInfoSP.IsReplyProcessed)
                        .SetParameter("DisplayName", documentInfoSP.DisplayName)

                         .SetParameter("NoOfAttachments", documentInfoSP.NoOfAttachments)
                        .SetParameter("HideInd", documentInfoSP.HideInd)
                        .SetParameter("DraftFileSize", documentInfoSP.DraftFileSize)
                        .SetParameter("SentFileSize", documentInfoSP.SentFileSize)
                        .SetParameter("RecFileSize", documentInfoSP.RecFileSize)
                        .SetParameter("RequestDocID", documentInfoSP.RequestDocID)
                         .SetParameter("FileType", documentInfoSP.FileType)
                        .SetParameter("DocSystemInd", documentInfoSP.DocSystemInd)
                        .SetParameter("WorkflowSerialNo", documentInfoSP.WorkflowSerialNo)
                        .SetParameter("SubmSignature", documentInfoSP.SubmSignature)
                        .SetParameter("CaseInfoId", documentInfoSP.CaseInfoId)
                        .SetParameter("SubCaseInfoId", documentInfoSP.SubCaseInfoId)
                         .SetParameter("AutoTestingMode", documentInfoSP.AutoTestingMode)
                        .SetParameter("OCRPdfFNID", documentInfoSP.OCRPdfFNId)
                        .SetParameter("PrivateAnnoPdfFNID", documentInfoSP.PrivateAnnoPdfFNID)
                        .SetParameter("OCRStatus", documentInfoSP.OCRStatus)
                        .SetParameter("DIYHrgTypeCode", documentInfoSP.DIYHrgTypeCode)
                        .SetParameter("DIYHrgslotcode", documentInfoSP.DIYHrgslotcode)
                         .SetParameter("JOLInd", documentInfoSP.JOLInd)
                        .SetParameter("DocInitiated", documentInfoSP.DocInitiated)
                    //.SetParameter("EFormContentRetain", documentInfoSP.EFormContentRetain)
                        .SetParameter("ReqDecision", documentInfoSP.ReqDecision)
                        .SetParameter("ReqDecisionRemark", documentInfoSP.ReqDecisionRemark)
                        .SetParameter("HrgDateToBeFixedInd", documentInfoSP.HrgDateToBeFixedInd)
                         .SetParameter("IsCrossCourt", documentInfoSP.IsCrossCourt)
                         .SetParameter("RejectionFeeActionType", documentInfoSP.RejectionFeeActionType)
                         .SetParameter("IsConfidential", documentInfoSP.IsConfidential)
                         .SetParameter("HashCode", documentInfoSP.HashCode)
                        .SetParameter("FiledByLoginId", documentInfoSP.FiledByLoginId)
                        .SetParameter("Step4TermAndConditionVersion", documentInfoSP.Step4TermAndConditionVersion)
                        .SetParameter("DocNo", documentInfoSP.DocNo)
                        .SetParameter("DIYSelectbyUser", documentInfoSP.DIYSelectbyUser)
                        .ExecuteUpdate();

                Logger.Debug("SaveOrUpdateDocumentInfoSP Ended");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateDocumentInfoSP", ex);
                throw;
            }
        }

        internal List<LawFirmDocCaseFileRefNumberEntity> GetLawFirmDocCaseFileRefNumberEntity(string SGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LawFirmDocCaseFileRefNumber))
              .Add(Expression.Eq("SubmissionGroupId", SGID));

            List<LawFirmDocCaseFileRefNumber> listLawFirmDocCaseFileRefNumber = GetFromDetachedCriteria<LawFirmDocCaseFileRefNumber>(detachedCriteria);

            if (listLawFirmDocCaseFileRefNumber != null && listLawFirmDocCaseFileRefNumber.Count > 0)
            {
                return listLawFirmDocCaseFileRefNumber.Select(lawFirmDocCaseFileRefNumber => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetLawFirmDocCaseFileRefNumberEntity(lawFirmDocCaseFileRefNumber)).ToList();
            }
            else
                return null;
        }

        /// <summary>
        /// Gets the list document party case file reference number entity by dcpid.
        /// </summary>
        /// <param name="dCPID">The d cpid.</param>
        /// <returns></returns>
        internal DocPartyCaseFileRefNumberEntity GetDocPartyCaseFileRefNumberEntityByDCPID(string dCPID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocPartyCaseFileRefNumber))
                                                                            .Add(Expression.Eq("DCPID", dCPID));

            List<DocPartyCaseFileRefNumber> listDocPartyCaseFileRefNumber = GetAllDocPartyCaseFileRefNumber(detachedCriteria);

            if (listDocPartyCaseFileRefNumber != null && listDocPartyCaseFileRefNumber.Count > 0)
            {
                return listDocPartyCaseFileRefNumber.Select(docPartyCaseFileRefNumber => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocPartyCaseFileRefNumberEntity(docPartyCaseFileRefNumber)).ToList()[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets all document party case file reference number.
        /// </summary>
        /// <param name="detachedCriteria">The detached criteria.</param>
        /// <returns></returns>
        private List<DocPartyCaseFileRefNumber> GetAllDocPartyCaseFileRefNumber(DetachedCriteria detachedCriteria)
        {
            IRepository<DocPartyCaseFileRefNumber> docPartyCaseFileRefNumberRepository = new RepositoryImpl<DocPartyCaseFileRefNumber>(applicationSession);
            return docPartyCaseFileRefNumberRepository.GetAll(detachedCriteria) as List<DocPartyCaseFileRefNumber>;
        }

        /// <summary>
        /// Saves the or update document party case file reference number entity.
        /// </summary>
        /// <param name="docPartyCaseFileRefNumberEntity">The document party case file reference number entity.</param>
        internal void SaveOrUpdateDocPartyCaseFileRefNumberEntity(DocPartyCaseFileRefNumberEntity docPartyCaseFileRefNumberEntity)
        {
            IRepository<DocPartyCaseFileRefNumber> docPartyCaseFileRefNumberRepository = new RepositoryImpl<DocPartyCaseFileRefNumber>(applicationSession);
            docPartyCaseFileRefNumberRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocPartyCaseFileRefNumber(docPartyCaseFileRefNumberEntity));
        }


        internal Temp_ProcessingInfoEntity GetTemp_ProcessingInfoEntityByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(Temp_ProcessingInfo))
                                                                            .Add(Expression.Eq("DocID", docId));

            List<Temp_ProcessingInfo> listTemp_ProcessingInfo = GetFromDetachedCriteria<Temp_ProcessingInfo>(detachedCriteria);

            if (listTemp_ProcessingInfo != null && listTemp_ProcessingInfo.Count > 0)
            {
                return listTemp_ProcessingInfo.Select(temp_ProcessingInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetTemp_ProcessingInfoEntity(temp_ProcessingInfo)).ToList()[0];
            }
            else
            {
                return null;
            }
        }

        internal List<RDocCounterClaimFiledEntity> GetRDocCounterClaimFiledEntityBySubmissionGroupID(System.String submissionGroupID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RDocCounterClaimFiled))
                .Add(Expression.Eq("SubmissionGroupID", submissionGroupID));

            List<RDocCounterClaimFiled> listRDocCounterClaimFiled = GetFromDetachedCriteria<RDocCounterClaimFiled>(detachedCriteria);

            if (listRDocCounterClaimFiled != null && listRDocCounterClaimFiled.Count > 0)
            {
                return listRDocCounterClaimFiled.Select(rDocCounterClaimFiled => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetRDocCounterClaimFiledEntity(rDocCounterClaimFiled)).ToList();
            }
            else
            {
                return null;
            }
        }
       

    }
}