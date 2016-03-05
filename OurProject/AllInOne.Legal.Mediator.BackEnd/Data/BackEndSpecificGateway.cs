namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;
    using AllInOne.Legal.Domain.Case;
    using NHibernate.SqlCommand;
    using AllInOne.Legal.Domain.SubCaseSpecific;

    internal class BackEndSpecificGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(BackEndSpecificGateway));

        ISession applicationSession;

        #endregion Fields

        #region Constructors

        internal BackEndSpecificGateway()
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

        internal void DeleteIndexDocDetail(string indexDocInfoId)
        {
            IRepository<IndexDocDetail> indexDocDetailRepository = new RepositoryImpl<IndexDocDetail>(applicationSession);
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(IndexDocDetail))
                                                              .Add(Expression.Eq("IndexDocInfoId", indexDocInfoId));
            List<IndexDocDetail> listIndexDocDetail = GetFromDetachedCriteria<IndexDocDetail>(detachedCriteria);
            if (listIndexDocDetail != null && listIndexDocDetail.Count > 0)
            {
                indexDocDetailRepository.DeleteAll(listIndexDocDetail);
            }
        }

        internal void DeleteIndexDocInfo(string docId)
        {
            IRepository<IndexDocInfo> indexDocInfoRepository = new RepositoryImpl<IndexDocInfo>(applicationSession);
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(IndexDocInfo))
                                                              .Add(Expression.Eq("DocId", docId));
            List<IndexDocInfo> listIndexDocInfo = GetFromDetachedCriteria<IndexDocInfo>(detachedCriteria);
            if (listIndexDocInfo != null && listIndexDocInfo.Count > 0)
            {
                indexDocInfoRepository.DeleteAll(listIndexDocInfo);
            }
        }

        internal void DeleteInterfaceCriminalEntityByCaseNo(string CaseNo)
        {
            InterfaceCriminalEntity iTCriminalEntity = new InterfaceCriminalEntity();
            IRepository<InterfaceCriminal> iTCriminalRepository = new RepositoryImpl<InterfaceCriminal>(applicationSession);
            List<InterfaceCriminal> listInterfaceCriminal = new List<InterfaceCriminal>();
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(InterfaceCriminal))
                                                                .Add(Expression.Eq("CaseNo", CaseNo));

            listInterfaceCriminal = iTCriminalRepository.GetAll(detachedCriteria) as List<InterfaceCriminal>;

            if (listInterfaceCriminal != null && listInterfaceCriminal.Count > 0)
            {
                iTCriminalRepository.DeleteAll(listInterfaceCriminal);
            }
        }

        internal void DeleteOGCIncomingQueueEntity(string oGCIncomingQueueId)
        {
            IRepository<OGCIncomingQueue> oGCIncomingQueueRepository = new RepositoryImpl<OGCIncomingQueue>(applicationSession);
            oGCIncomingQueueRepository.Delete(oGCIncomingQueueRepository.Get(oGCIncomingQueueId));
        }

        internal List<JudicialUserEntity> GetAllJudicialUserEntity()
        {
            IRepository<JudicialUser> judicialUserRepository = new RepositoryImpl<JudicialUser>(applicationSession);
            List<JudicialUser> listJudicialUser = judicialUserRepository.GetAll().ToList();
            if (listJudicialUser != null && listJudicialUser.Count > 0)
            {
                return listJudicialUser.Select(judicialUser => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetJudicialUserEntity(judicialUser)).ToList();
            }
            else
                return null;
        }

        internal List<OGCIncomingQueueEntity> GetAllOGCIncomingQueueEntity()
        {
            IRepository<OGCIncomingQueue> oGCIncomingQueueRepository = new RepositoryImpl<OGCIncomingQueue>(applicationSession);
            List<OGCIncomingQueue> listOGCIncomingQueue = oGCIncomingQueueRepository.GetAll().ToList();

            if (listOGCIncomingQueue != null && listOGCIncomingQueue.Count > 0)
            {
                return listOGCIncomingQueue.Select(oGCIncomingQueue => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetOGCIncomingQueueEntity(oGCIncomingQueue)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<IndexDocDetailEntity> GetGetIndexDocDetail(string indexDocInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(IndexDocDetail))
                .Add(Expression.Eq("IndexDocInfoId", indexDocInfoId));
            List<IndexDocDetail> listIndexDocDetail = GetFromDetachedCriteria<IndexDocDetail>(detachedCriteria);

            if (listIndexDocDetail != null && listIndexDocDetail.Count > 0)
            {
                return listIndexDocDetail.Select(indexDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetIndexDocDetailEntity(indexDocDetail)).ToList();
            }
            else
                return null;
        }

        internal List<IndexDocInfoEntity> GetGetIndexDocInfoEntity(string indexDocInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(IndexDocInfo))
                .Add(Expression.Eq("IndexDocInfoId", indexDocInfoId));
            List<IndexDocInfo> listIndexDocInfo = GetFromDetachedCriteria<IndexDocInfo>(detachedCriteria);
            if (listIndexDocInfo != null && listIndexDocInfo.Count > 0)
            {
                return listIndexDocInfo.Select(indexDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetIndexDocInfoEntity(indexDocDetail)).ToList();
            }
            else
                return null;
        }


        internal IndexDocInfoEntity GetIndexDocInfoByPK(string indexDocInfoId)
        {
            IRepository<IndexDocInfo> irepositoryIndexDocInfo = new RepositoryImpl<IndexDocInfo>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetIndexDocInfoEntity(irepositoryIndexDocInfo.Get(indexDocInfoId));
        }

        internal InterfaceCriminalEntity GetInterfaceCriminalEntityByCaseNo(string CaseNo)
        {
            InterfaceCriminalEntity iTCriminalEntity = new InterfaceCriminalEntity();
            IRepository<InterfaceCriminal> iTCriminalRepository = new RepositoryImpl<InterfaceCriminal>(applicationSession);
            List<InterfaceCriminal> listInterfaceCriminal = new List<InterfaceCriminal>();
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(InterfaceCriminal))
                                                                .Add(Expression.Eq("CaseNo", CaseNo));

            listInterfaceCriminal = iTCriminalRepository.GetAll(detachedCriteria) as List<InterfaceCriminal>;

            if (listInterfaceCriminal != null && listInterfaceCriminal.Count > 0)
            {
                foreach (InterfaceCriminal iTCriminal in listInterfaceCriminal)
                {
                    iTCriminalEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetInterfaceCriminalEntity(iTCriminal);
                }
            }
            else
                iTCriminalEntity = null;
            return iTCriminalEntity;
        }

        internal JudicialUserEntity GetJudicialUserEntityByPK(string userId)
        {
            IRepository<JudicialUser> judicialUserRepository = new RepositoryImpl<JudicialUser>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetJudicialUserEntity(judicialUserRepository.Get(userId));
        }

        internal List<RUserPAEntity> GetRUserPAEntityByUserId(string userId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RUserPA))
                .Add(Expression.Eq("UserId", userId));
            List<RUserPA> listRUserPA = GetFromDetachedCriteria<RUserPA>(detachedCriteria);

            if (listRUserPA != null && listRUserPA.Count > 0)
            {
                return listRUserPA.Select(rUserPA =>
                    AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetRUserPAEntity(rUserPA)).ToList();
            }
            else
                return null;
        }

        internal List<BankruptcyDRSInfoEntity> GetListBankruptcyDRSInfo(string caseInfoId, string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<BankruptcyDRSInfo>()
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                .Add(Expression.Eq("DocId", docId));
            List<BankruptcyDRSInfo> listBankruptcyDRSInfo = GetFromDetachedCriteria<BankruptcyDRSInfo>(detachedCriteria);
            if (listBankruptcyDRSInfo != null && listBankruptcyDRSInfo.Count > 0)
            {
                return listBankruptcyDRSInfo.Select(bankruptcyDRSInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetBankruptcyDRSInfoEntity(bankruptcyDRSInfo)).ToList();
            }
            else
                return null;
        }

        internal List<CriminalClaimHonorariumInfoEntity> GetListCriminalClaimHonorariumInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CriminalClaimHonorariumInfo))
                                                                .Add(Expression.Eq("CriminalClaimInfoId", criminalClaimInfoId));

            List<CriminalClaimHonorariumInfo> listCriminalClaimHonorariumInfo = GetAllCriminalClaimHonorariumInfo(detachedCriteria);
            if (listCriminalClaimHonorariumInfo != null && listCriminalClaimHonorariumInfo.Count > 0)
            {
                return listCriminalClaimHonorariumInfo.Select(criminalClaimHonorariumInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetCriminalClaimHonorariumInfoEntity(criminalClaimHonorariumInfo)).ToList();
            }
            else
                return null;
        }

        internal List<CriminalClaimInfoEntity> GetListCriminalClaimInfoEntityByCaseInfoId(long caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CriminalClaimInfo))
                                                                .Add(Expression.Eq("CaseInfoId", caseInfoId));

            List<CriminalClaimInfo> listCriminalClaimInfo = GetAllCriminalClaimInfo(detachedCriteria);
            if (listCriminalClaimInfo != null && listCriminalClaimInfo.Count > 0)
            {
                return listCriminalClaimInfo.Select(criminalClaimInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetCriminalClaimInfoEntity(criminalClaimInfo)).ToList();
            }
            else
                return null;
        }

        /* Start of Criminal Finance */
        internal List<CriminalClaimInfoEntity> GetListCriminalClaimInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CriminalClaimInfo))
                                                                .Add(Expression.Eq("CriminalClaimInfoId", criminalClaimInfoId));

            List<CriminalClaimInfo> listCriminalClaimInfo = GetAllCriminalClaimInfo(detachedCriteria);
            if (listCriminalClaimInfo != null && listCriminalClaimInfo.Count > 0)
            {
                return listCriminalClaimInfo.Select(criminalClaimInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetCriminalClaimInfoEntity(criminalClaimInfo)).ToList();
            }
            else
                return null;
        }

        internal List<CriminalClaimInterpreterFeeInfoEntity> GetListCriminalClaimInterpreterFeeInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CriminalClaimInterpreterFeeInfo))
                                                                .Add(Expression.Eq("CriminalClaimInfoId", criminalClaimInfoId));

            List<CriminalClaimInterpreterFeeInfo> listCriminalClaimInterpreterFeeInfo = GetAllCriminalClaimInterpreterFeeInfo(detachedCriteria);
            if (listCriminalClaimInterpreterFeeInfo != null && listCriminalClaimInterpreterFeeInfo.Count > 0)
            {
                return listCriminalClaimInterpreterFeeInfo.Select(criminalClaimInterpreterFeeInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetCriminalClaimInterpreterFeeInfoEntity(criminalClaimInterpreterFeeInfo)).ToList();
            }
            else
                return null;
        }

        internal List<CriminalClaimMiscellaneousInfoEntity> GetListCriminalClaimMiscellaneousInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CriminalClaimMiscellaneousInfo))
                                                                .Add(Expression.Eq("CriminalClaimInfoId", criminalClaimInfoId));

            List<CriminalClaimMiscellaneousInfo> listCriminalClaimMiscellaneousInfo = GetAllCriminalClaimMiscellaneousInfo(detachedCriteria);
            if (listCriminalClaimMiscellaneousInfo != null && listCriminalClaimMiscellaneousInfo.Count > 0)
            {
                return listCriminalClaimMiscellaneousInfo.Select(criminalClaimMiscellaneousInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetCriminalClaimMiscellaneousInfoEntity(criminalClaimMiscellaneousInfo)).ToList();
            }
            else
                return null;
        }

        internal List<CriminalClaimProfessionalFeeInfoEntity> GetListCriminalClaimProfessionalFeeInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CriminalClaimProfessionalFeeInfo))
                                                                .Add(Expression.Eq("CriminalClaimInfoId", criminalClaimInfoId));

            List<CriminalClaimProfessionalFeeInfo> listCriminalClaimProfessionalFeeInfo = GetAllCriminalClaimProfessionalFeeInfo(detachedCriteria);
            if (listCriminalClaimProfessionalFeeInfo != null && listCriminalClaimProfessionalFeeInfo.Count > 0)
            {
                return listCriminalClaimProfessionalFeeInfo.Select(criminalClaimProfessionalFeeInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetCriminalClaimProfessionalFeeInfoEntity(criminalClaimProfessionalFeeInfo)).ToList();
            }
            else
                return null;
        }

        internal List<CriminalClaimWitnessInfoEntity> GetListCriminalClaimWitnessInfoEntityByCriminalClaimInfoId(string criminalClaimInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CriminalClaimWitnessInfo))
                                                                .Add(Expression.Eq("CriminalClaimInfoId", criminalClaimInfoId));

            List<CriminalClaimWitnessInfo> listCriminalClaimWitnessInfo = GetAllCriminalClaimWitnessInfo(detachedCriteria);
            if (listCriminalClaimWitnessInfo != null && listCriminalClaimWitnessInfo.Count > 0)
            {
                return listCriminalClaimWitnessInfo.Select(criminalClaimWitnessInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetCriminalClaimWitnessInfoEntity(criminalClaimWitnessInfo)).ToList();
            }
            else
                return null;
        }

        internal List<DCADetailEntity> GetListDCADetail<V>(string fieldName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DCADetail))
                .Add(Expression.Eq(fieldName, value));
            List<DCADetail> listDCADetail = GetFromDetachedCriteria<DCADetail>(detachedCriteria);
            if (listDCADetail != null && listDCADetail.Count > 0)
            {
                return listDCADetail.Select(dCADetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetDCADetailEntity(dCADetail)).ToList();
            }
            else
                return null;
        }

        /* End of Criminal Finance */
        internal List<DCADetailEntity> GetListDCADetailEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DCADetail>()
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<DCADetail> listDCADetail = GetFromDetachedCriteria<DCADetail>(detachedCriteria);
            if (listDCADetail != null && listDCADetail.Count > 0)
            {
                return listDCADetail.Select(dCADetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetDCADetailEntity(dCADetail)).ToList();
            }
            else
                return null;
        }

        internal List<JudicialUserEntity> GetListJudicialUserEntity(string sectionCode)
        {
            var subCriteria = DetachedCriteria.For(typeof(RUserRoleSection));
            subCriteria.SetProjection(Projections.Property("UserId"))
                .Add(Expression.Eq("SectionCode", sectionCode))
                .Add(Expression.Eq("ObsInd", "N"));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(JudicialUser)).Add(Subqueries.PropertyIn("UserId", subCriteria));

            IRepository<JudicialUser> reportConfigInfoRepository = new RepositoryImpl<JudicialUser>(applicationSession);
            List<JudicialUser> listJudicialUser = reportConfigInfoRepository.FindAll(iCriterion).ToList();
            if (listJudicialUser != null && listJudicialUser.Count > 0)
            {
                return listJudicialUser.Select(judicialUser => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetJudicialUserEntity(judicialUser)).ToList();
            }
            else
                return null;
        }

        internal List<JudicialUserEntity> GetListJudicialUserEntityByUserName(string userName)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(JudicialUser))
                .Add(Expression.Eq("UserName", userName));
            List<JudicialUser> listJudicialUser = GetFromDetachedCriteria<JudicialUser>(detachedCriteria);
            if (listJudicialUser != null && listJudicialUser.Count > 0)
            {

                return listJudicialUser.Select(judicialUser => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetJudicialUserEntity(judicialUser)).ToList();
            }
            else
                return null;
        }

        internal List<RARASDetailEntity> GetListRARASDetail<V>(string fieldName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RARASDetail))
                .Add(Expression.Eq(fieldName, value));
            List<RARASDetail> listRARASDetail = GetFromDetachedCriteria<RARASDetail>(detachedCriteria);
            if (listRARASDetail != null && listRARASDetail.Count > 0)
            {
                return listRARASDetail.Select(rARASDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetRARASDetailEntity(rARASDetail)).ToList();
            }
            else
                return null;
        }

        internal List<RARASDetailEntity> GetlistRARASInfoDetailBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RARASDetail>()
                 .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<RARASDetail> listRARASDetail = GetFromDetachedCriteria<RARASDetail>(detachedCriteria);
            if (listRARASDetail != null && listRARASDetail.Count > 0)
            {
                return listRARASDetail.Select(rARASDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetRARASDetailEntity(rARASDetail)).ToList();
            }
            else
                return null;
        }

        internal List<ReportConfigUserEntity> GetListReportConfigUserEntityByReportConfigInfoId(string reportConfigInfoId)
        {
            DetachedCriteria detachecCriteria = DetachedCriteria.For(typeof(ReportConfigUser)).Add(Expression.Eq("ReportConfigInfoId", reportConfigInfoId))
                .Add(Expression.Eq("ObsInd", "N"));

            List<ReportConfigUser> listReportConfigUser = GetReportConfigUser(detachecCriteria);
            if (listReportConfigUser != null && listReportConfigUser.Count > 0)
            {
                return listReportConfigUser.Select(reportConfigUser => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetReportConfigUserEntity(reportConfigUser)).ToList();
            }
            else
                return null;
        }

        internal List<BEWorkitemDetailsEntity> GetListWorkItemDetailsEntityByWorkflowSerialNo(string workflowSerialNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WorkitemDetails))
               .Add(Expression.Eq("WorkflowSerialNo", workflowSerialNo));

            List<WorkitemDetails> listWorkitemDetails = GetAllWorkitemDetails(detachedCriteria);

            if (listWorkitemDetails != null && listWorkitemDetails.Count > 0)
            {
                return listWorkitemDetails.Select(workitemDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetWorkitemDetailsEntity(workitemDetails)).ToList();
            }
            else
                return null;
        }

        internal List<BEWorkitemRecipientEntity> GetListWorkItemRecipientEntityByWorkflowSerialNo(string workflowSerialNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WorkitemRecipient))
               .Add(Expression.Eq("WorkflowSerialNo", workflowSerialNo));

            List<WorkitemRecipient> listWorkitemRecipient = GetAllWorkitemRecipient(detachedCriteria);

            if (listWorkitemRecipient != null && listWorkitemRecipient.Count > 0)
            {
                return listWorkitemRecipient.Select(workitemDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetWorkitemRecipientEntity(workitemDetails)).ToList();
            }
            else
                return null;
        }

        internal OGCIncomingQueueEntity GetOGCIncomingQueue(string OGCIncomingQueueId)
        {
            IRepository<OGCIncomingQueue> oGCIncomingQueueRepository = new RepositoryImpl<OGCIncomingQueue>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetOGCIncomingQueueEntity(oGCIncomingQueueRepository.Get(OGCIncomingQueueId));
        }

        internal List<ReportConfigInfoEntity> GetReportConfigInfo(string reportTitle, OnlineEnquiryReportType reportType)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ReportConfigInfo));
            if (string.IsNullOrEmpty(reportTitle) || reportType == OnlineEnquiryReportType.Null)
            {
                if (string.IsNullOrEmpty(reportTitle))
                {
                    detachedCriteria = detachedCriteria.Add(Expression.Eq("ReportType", reportType.ToString()));
                }
                else if (reportType == OnlineEnquiryReportType.Null)
                {
                    detachedCriteria = detachedCriteria.Add(Expression.Like("ReportTitle", reportTitle, MatchMode.Anywhere));

                }
            }
            else
            {
                detachedCriteria = detachedCriteria.Add(Restrictions.Conjunction()
                                                                                 .Add(Expression.Like("ReportTitle", reportTitle, MatchMode.Anywhere))
                                                                                 .Add(Expression.Eq("ReportType", reportType.ToString())));
            }

            List<ReportConfigInfo> listReportConfigInfo = GetReportConfigInfo(detachedCriteria);
            if (listReportConfigInfo != null && listReportConfigInfo.Count > 0)
            {
                return listReportConfigInfo.Select(reportConfigInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetReportConfigInfoEntity(reportConfigInfo)).ToList();
            }
            else
                return null;
        }

        internal ReportConfigInfoEntity GetReportConfigInfoByPK(string reportConfigInfoId)
        {
            IRepository<ReportConfigInfo> reportConfigInfoRepository = new RepositoryImpl<ReportConfigInfo>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetReportConfigInfoEntity(reportConfigInfoRepository.Get(reportConfigInfoId));
        }

        internal List<RMCDRAutoFixTimeLineEntity> GetRMCDRAutoFixTimeLine(string caseTypeCode, string docCode)
        {
            MCaseType mCaseType = new MCaseType { CaseTypeCode = caseTypeCode };
            MDocCode mDocCode = new MDocCode { DOCCode = docCode };

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RMCDRAutoFixTimeLine))
                .Add(Expression.Eq("CaseTypeCode", mCaseType))
                .Add(Expression.Eq("DocCode", mDocCode));
            List<RMCDRAutoFixTimeLine> listRMCDRAutoFixTimeLine = GetRMCDRAutoFixTimeLine(detachedCriteria);

            if (listRMCDRAutoFixTimeLine != null && listRMCDRAutoFixTimeLine.Count > 0)
            {
                return listRMCDRAutoFixTimeLine.Select(rMCDRAutoFixTimeLine => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetRMCDRAutoFixTimeLineEntity(rMCDRAutoFixTimeLine)).ToList();
            }
            else
                return null;
        }

        internal TaskListEntity GetTaskListEntityByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<TaskList>()
                .Add(Expression.Eq("DocID", docId));
            List<TaskList> listTaskList = GetFromDetachedCriteria<TaskList>(detachedCriteria);
            if (listTaskList.Count > 0)
            {
                return listTaskList.Select(taskList => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetTaskListEntity(taskList)).ToList()[0];
            }
            else
            {
                return null;
            }
        }

        internal List<TaskListEntity> GetListTaskListEntityByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<TaskList>()
                .Add(Expression.Eq("DocID", docId));
            List<TaskList> listTaskList = GetFromDetachedCriteria<TaskList>(detachedCriteria);
            if (listTaskList.Count > 0)
            {
                return listTaskList.Select(taskList => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetTaskListEntity(taskList)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal TaskListEntity GetTaskListEntityByWorkflowSerialNo(string workflowSerialNo)
        {
            IRepository<TaskList> taskListRepository = new RepositoryImpl<TaskList>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetTaskListEntity(taskListRepository.Get(workflowSerialNo));
        }

        internal WorkflowOnAcceptQueueEntity GetWorkflowOnAcceptQueueEntityByPK(string WorkflowOnAcceptQueueId)
        {
            IRepository<WorkflowOnAcceptQueue> workflowOnAcceptQueueRepository = new RepositoryImpl<WorkflowOnAcceptQueue>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetWorkflowOnAcceptQueueEntity(workflowOnAcceptQueueRepository.Get(WorkflowOnAcceptQueueId));
        }

        internal WorkflowPostAcceptQueueEntity GetWorkflowPostAcceptQueueEntityByPK(string WorkflowPostAcceptQueueId)
        {
            IRepository<WorkflowPostAcceptQueue> workflowPostAcceptQueueRepository = new RepositoryImpl<WorkflowPostAcceptQueue>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetWorkflowPostAcceptQueueEntity(workflowPostAcceptQueueRepository.Get(WorkflowPostAcceptQueueId));
        }

        /// <summary>
        /// Passes the domain object and save it.
        /// </summary>
        /// <param name="entityToSave">The domain object to be saved.<param>
        /// <returns></returns>
        internal void SaveOrUpdateEntity<T>(T entityToSave)
        {
            IRepository<T> caseRepository = new RepositoryImpl<T>(applicationSession);
            caseRepository.SaveOrUpdate(entityToSave);
        }

        /// <summary>
        /// Passes the domain object and save it.
        /// </summary>
        /// <param name="entityToSave">The domain object to be saved.<param>
        /// <returns></returns>
        internal void SaveOrUpdateInMemoryEntity<T>(T entityToSave)
        {
            IRepository<T> caseRepository = new RepositoryImpl<T>(applicationSession);
            caseRepository.SaveOrUpdateCopy(entityToSave);
        }

        internal void SaveOrUpdateWorkitemDetailsEntity(BEWorkitemDetailsEntity workitemDetailsEntity)
        {
            IRepository<WorkitemDetails> workitemDetailsRepository = new RepositoryImpl<WorkitemDetails>(applicationSession);
            workitemDetailsRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.BackEndSpecificMapper.GetWorkitemDetails(workitemDetailsEntity));
        }

        internal void SaveOrUpdateWorkitemRecipientEntity(BEWorkitemRecipientEntity workitemDetailsEntity)
        {
            IRepository<WorkitemRecipient> workitemDetailsRepository = new RepositoryImpl<WorkitemRecipient>(applicationSession);
            workitemDetailsRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.BackEndSpecificMapper.GetWorkitemRecipient(workitemDetailsEntity));
        }

        private List<CriminalClaimHonorariumInfo> GetAllCriminalClaimHonorariumInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<CriminalClaimHonorariumInfo> criminalClaimHonorariumRepository = new RepositoryImpl<CriminalClaimHonorariumInfo>(applicationSession);
            return criminalClaimHonorariumRepository.GetAll(detachedCriteria).ToList();
        }

        private List<CriminalClaimInfo> GetAllCriminalClaimInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<CriminalClaimInfo> criminalClaimRepository = new RepositoryImpl<CriminalClaimInfo>(applicationSession);
            return criminalClaimRepository.GetAll(detachedCriteria).ToList();
        }

        private List<CriminalClaimInterpreterFeeInfo> GetAllCriminalClaimInterpreterFeeInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<CriminalClaimInterpreterFeeInfo> criminalClaimInterpreterFeeRepository = new RepositoryImpl<CriminalClaimInterpreterFeeInfo>(applicationSession);
            return criminalClaimInterpreterFeeRepository.GetAll(detachedCriteria).ToList();
        }

        private List<CriminalClaimMiscellaneousInfo> GetAllCriminalClaimMiscellaneousInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<CriminalClaimMiscellaneousInfo> criminalClaimMiscellaneousRepository = new RepositoryImpl<CriminalClaimMiscellaneousInfo>(applicationSession);
            return criminalClaimMiscellaneousRepository.GetAll(detachedCriteria).ToList();
        }

        private List<CriminalClaimProfessionalFeeInfo> GetAllCriminalClaimProfessionalFeeInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<CriminalClaimProfessionalFeeInfo> criminalClaimProfessionalFeeRepository = new RepositoryImpl<CriminalClaimProfessionalFeeInfo>(applicationSession);
            return criminalClaimProfessionalFeeRepository.GetAll(detachedCriteria).ToList();
        }

        private List<CriminalClaimWitnessInfo> GetAllCriminalClaimWitnessInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<CriminalClaimWitnessInfo> criminalClaimWitnessRepository = new RepositoryImpl<CriminalClaimWitnessInfo>(applicationSession);
            return criminalClaimWitnessRepository.GetAll(detachedCriteria).ToList();
        }

        private List<WorkitemDetails> GetAllWorkitemDetails(DetachedCriteria detachedCriteria)
        {
            IRepository<WorkitemDetails> workitemDetailsRepository = new RepositoryImpl<WorkitemDetails>(applicationSession);
            return workitemDetailsRepository.GetAll(detachedCriteria).ToList();
        }

        private List<WorkitemRecipient> GetAllWorkitemRecipient(DetachedCriteria detachedCriteria)
        {
            IRepository<WorkitemRecipient> workitemDetailsRepository = new RepositoryImpl<WorkitemRecipient>(applicationSession);
            return workitemDetailsRepository.GetAll(detachedCriteria).ToList();
        }

        private List<T> GetFromDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> irepository = new RepositoryImpl<T>(applicationSession);
            return irepository.GetAll(detachedCriteria) as List<T>;
        }

        private List<JudicialUser> GetJudicialUser(DetachedCriteria subCriteria)
        {
            IRepository<JudicialUser> reportConfigInfoRepository = new RepositoryImpl<JudicialUser>(applicationSession);
            return reportConfigInfoRepository.GetAll(subCriteria).ToList();
        }

        private List<ReportConfigInfo> GetReportConfigInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<ReportConfigInfo> reportConfigInfoRepository = new RepositoryImpl<ReportConfigInfo>(applicationSession);
            return reportConfigInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<ReportConfigUser> GetReportConfigUser(DetachedCriteria detachedCriteria)
        {
            IRepository<ReportConfigUser> reportConfigUserRepository = new RepositoryImpl<ReportConfigUser>(applicationSession);
            return reportConfigUserRepository.GetAll(detachedCriteria).ToList();
        }

        private List<RMCDRAutoFixTimeLine> GetRMCDRAutoFixTimeLine(DetachedCriteria detachedCriteria)
        {
            IRepository<RMCDRAutoFixTimeLine> rMCDRAutoFixTimeLineRepository = new RepositoryImpl<RMCDRAutoFixTimeLine>(applicationSession);
            return rMCDRAutoFixTimeLineRepository.GetAll(detachedCriteria).ToList();
        }

        #endregion Methods

        internal List<CaseInfoEntity> PendingOneYearOldDocs()
        {
            DateTime targetDateTime = DateTime.Now.AddYears(-1);
            DateTime d = new DateTime(targetDateTime.Year, targetDateTime.Month, targetDateTime.Day, 0, 0, 0, 0);
            DateTime d1 = new DateTime(targetDateTime.Year, targetDateTime.Month, targetDateTime.Day, 23, 59, 59, 999);
            var subCriteria = DetachedCriteria.For(typeof(DocumentInfo));
            subCriteria.SetProjection(Projections.Property("CaseInfoId"))
                .Add(Expression.And(Expression.Gt("FilingDateTime", d), Expression.Lt("FilingDateTime", d1)))
                .Add(Expression.Or(Expression.Eq("MDocStatus.DocStatus", "A"), Expression.Eq("MDocStatus.DocStatus", "R")));


            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(CaseInfo)).Add(Expression.Eq("MCaseStatus.CaseStatusCode", "P"))
                .Add(Subqueries.PropertyIn("CaseInfoId", subCriteria));



            IRepository<CaseInfo> caseInfoRepository = new RepositoryImpl<CaseInfo>(applicationSession);
            List<CaseInfo> listCaseInfo = caseInfoRepository.FindAll(iCriterion).ToList();
            if (listCaseInfo != null && listCaseInfo.Count > 0)
            {
                return listCaseInfo.Select(caseInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseInfoEntity(caseInfo)).ToList();
            }
            else
                return null;
        }

        internal List<JudicialUserEntity> GetListReportConfigUserEntity(string reportConfigInfoId, string sectionCode)
        {

            try
            {

                //TODO: Need to Modify SQL Query to Criteria API

                IQuery query = applicationSession.CreateSQLQuery(
                                @"SElect distinct Users.UserId,Users.UserName from ReportConfigInfo
                                  INNER Join ReportConfigUser ON  ReportConfigInfo.ReportConfigInfoId=ReportConfigUser.ReportConfigInfoId
                                  INNER JOIN RUserRoleSection ON ReportConfigUser.UserId=RUserRoleSection.UserId
                                  INNER JOIN  Users  ON  RUserRoleSection.UserId= Users.UserId
                                  WHERE RUserRoleSection.SectionCode= '" + sectionCode + @"'
                                  AND  ReportConfigUser.ObsInd='N'
                                  AND ReportConfigInfo.ReportConfigInfoId='" + reportConfigInfoId + @"'");

                List<object> listUsers = query.List<object>().ToList();
                if (listUsers != null && listUsers.Count > 0)
                {
                    return this.TransformToJudicialUser(listUsers);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetListReportConfigUserEntity", ex);
                throw;
            }



            #region JoinWithDetachedCriteria
            /*

            MSection mSection = null;
            if (!string.IsNullOrEmpty(sectionCode))
            {
                mSection = new MSection { SectionCode = sectionCode };
            }
            else
            {
                throw new NullReferenceException("SectionCode is null");
            }

            var subCriteria = DetachedCriteria.For<ReportConfigInfo>();
            subCriteria.SetProjection(Projections.Property("ReportConfigInfoId"))
                .Add(Expression.Eq("ReportConfigInfoId", reportConfigInfoId))
                .Add(Expression.Eq("MSection", mSection));

            ICriteria iCriterion = applicationSession.CreateCriteria(typeof(ReportConfigUser))
                .Add(Expression.Eq("ObsInd", "N"))
                .Add(Subqueries.PropertyIn("ReportConfigInfoId", subCriteria));

            IRepository<ReportConfigUser> reportConfigUserRepository = new RepositoryImpl<ReportConfigUser>(applicationSession);
            List<ReportConfigUser> listReportConfigUser = reportConfigUserRepository.FindAll(iCriterion).ToList();

            if (listReportConfigUser != null && listReportConfigUser.Count > 0)
            {
                return GetUsersList(listReportConfigUser);
            }
            else
            {
                return null;

            } */

            #endregion

        }

        private List<JudicialUserEntity> TransformToJudicialUser(List<object> listUsers)
        {
            List<JudicialUserEntity> listJudicialUserEntity = new List<JudicialUserEntity>();
            foreach (object[] item in listUsers)
            {

                listJudicialUserEntity.Add(new JudicialUserEntity(
                    item[0] != null ? item[0].ToString() : null,
                    item[1] != null ? item[1].ToString() : null));


            }
            return listJudicialUserEntity;

        }

        private List<JudicialUserEntity> GetUsersList(List<ReportConfigUser> listReportConfigUser)
        {

            List<JudicialUser> listJudicialUser = new List<JudicialUser>();

            foreach (ReportConfigUser report in listReportConfigUser)
            {

                IRepository<JudicialUser> userRepository = new RepositoryImpl<JudicialUser>(applicationSession);
                listJudicialUser.Add(userRepository.Get(report.UserId));

            }
            if (listJudicialUser != null && listJudicialUser.Count > 0)
            {
                return listJudicialUser.Select(users => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetJudicialUserEntity(users)).ToList();

            }

            else
            {
                return null;
            }
        }

        internal List<RMUserPSEntity> GetRMUserPSEntity(string JOUserId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMUserPS>()
                .Add(Expression.Eq("JOUserId", JOUserId));
            List<RMUserPS> listRMUserPS = GetFromDetachedCriteria<RMUserPS>(detachedCriteria);
            if (listRMUserPS != null && listRMUserPS.Count > 0)
            {
                return listRMUserPS.Select(rmUserPS => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetRMUserPSEntity(rmUserPS)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<NumberOfJudgeAssignDetailEntity> GetListNumberOfJudgeAssignDetailEntityByWSNo(string workFlowSerialNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<NumberOfJudgeAssignDetail>()
                .Add(Expression.Eq("WorkflowSerialNo", workFlowSerialNo));
            List<NumberOfJudgeAssignDetail> listNumberOfJudgeAssignDetail = GetFromDetachedCriteria<NumberOfJudgeAssignDetail>(detachedCriteria);
            if (listNumberOfJudgeAssignDetail != null && listNumberOfJudgeAssignDetail.Count > 0)
            {
                return listNumberOfJudgeAssignDetail.Select(numberOfJudgeAssignDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetNumberOfJudgeAssignDetailEntity(numberOfJudgeAssignDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<NumberOfJudgeAssignDetailHistoryEntity> GetListNumberOfJudgeAssignDetailHistoryEntity(string NoOfJudgeAssignDetailId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<NumberOfJudgeAssignDetailHistory>()
               .Add(Expression.Eq("NumberOfJudgeAssignDetailId", NoOfJudgeAssignDetailId));
            List<NumberOfJudgeAssignDetailHistory> listNumberOfJudgeAssignDetailHistory = GetFromDetachedCriteria<NumberOfJudgeAssignDetailHistory>(detachedCriteria);
            if (listNumberOfJudgeAssignDetailHistory != null && listNumberOfJudgeAssignDetailHistory.Count > 0)
            {
                return listNumberOfJudgeAssignDetailHistory.Select(numberOfJudgeAssignDetailHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetNumberOfJudgeAssignDetailHistoryEntity(numberOfJudgeAssignDetailHistory)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal NumberOfJudgeAssignDetailEntity GetNumberOfJudgeAssignDetailEntityByPK(string NoOfJudgeAssignDetailId)
        {
            IRepository<NumberOfJudgeAssignDetail> repository = new RepositoryImpl<NumberOfJudgeAssignDetail>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetNumberOfJudgeAssignDetailEntity(repository.Get(NoOfJudgeAssignDetailId));
        }

        internal ReportConfigTaskInfoEntity GetReportConfigTaskInfoByPK(string ReportConfigTaskInfoId)
        {
            IRepository<ReportConfigTaskInfo> repository = new RepositoryImpl<ReportConfigTaskInfo>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetReportConfigTaskInfoEntity(repository.Get(ReportConfigTaskInfoId));
        }

        /// <summary>
        /// Gets the list BE work item details entity.
        /// </summary>
        /// <param name="WFSNo">The WFS no.</param>
        /// <returns></returns>
        internal List<BEWorkitemDetailsEntity> GetListBEWorkItemDetailsEntity(string WFSNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<WorkitemDetails>()
                .Add(Expression.Eq("WorkflowSerialNo", WFSNo));

            List<WorkitemDetails> listBEWorkitemDetails = GetFromDetachedCriteria<WorkitemDetails>(detachedCriteria);

            if (listBEWorkitemDetails != null && listBEWorkitemDetails.Count > 0)
            {
                return listBEWorkitemDetails.Select(workItemDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetWorkitemDetailsEntity(workItemDetails)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<BEWorkitemRecipientEntity> GetListBEWorkitemRecipientEntity(string WFSNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<WorkitemRecipient>()
               .Add(Expression.Eq("WorkflowSerialNo", WFSNo));

            List<WorkitemRecipient> listWorkitemRecipient = GetFromDetachedCriteria<WorkitemRecipient>(detachedCriteria);

            if (listWorkitemRecipient != null && listWorkitemRecipient.Count > 0)
            {
                return listWorkitemRecipient.Select(workitemRecipient => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetWorkitemRecipientEntity(workitemRecipient)).ToList();
            }
            else
            {
                return null;
            }
        }

        private IRepository<T> Repository<T>()
        {
            return new RepositoryImpl<T>(applicationSession);
        }

        internal void DeleteTaskList(string WFSNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<TaskList>()
                .Add(Expression.Eq("WorkflowSerialNo", WFSNo));

            Repository<TaskList>().DeleteAll(detachedCriteria);
        }



        internal void DeleteBEWorkitemDetails(string WFSNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<WorkitemDetails>()
               .Add(Expression.Eq("WorkflowSerialNo", WFSNo));

            Repository<WorkitemDetails>().DeleteAll(detachedCriteria);
        }

        internal void DeleteBEWorkitemRecipient(string WFSNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<WorkitemRecipient>()
              .Add(Expression.Eq("WorkflowSerialNo", WFSNo));

            Repository<WorkitemRecipient>().DeleteAll(detachedCriteria);
        }

        internal void DeleteNumberOfJudgeAssignDetail(string WFSNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<NumberOfJudgeAssignDetail>()
              .Add(Expression.Eq("WorkflowSerialNo", WFSNo));

            Repository<NumberOfJudgeAssignDetail>().DeleteAll(detachedCriteria);
        }

        internal void DeleteNumberOfJudgeAssignDetailHistory(string NumberOfJudgeAssignDetailId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<NumberOfJudgeAssignDetailHistory>()
             .Add(Expression.Eq("NumberOfJudgeAssignDetailId", NumberOfJudgeAssignDetailId));

            Repository<NumberOfJudgeAssignDetailHistory>().DeleteAll(detachedCriteria);
        }

        internal List<ReportConfigInfoEntity> GetListReportConfigInfo(string jobType)
        {
            DateTime date = DateTime.Now;
            DateTime StartDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59, 999);
            DateTime EndDate = new DateTime(date.Year, date.Month, date.Day, 00, 00, 00, 000);

            DetachedCriteria detachedCriteria = DetachedCriteria.For<ReportConfigInfo>()
                .Add(Expression.Eq("ObsInd", "N"))
                .Add(Expression.Eq("SchedulerInfo", jobType))
                .Add(Expression.Le("SchedulerStartDate", StartDate))
                .Add(Expression.Or(Expression.IsNull("SchedularEndDate"), Expression.Ge("SchedularEndDate", EndDate)));

            List<ReportConfigInfo> listReportConfigInfo = GetFromDetachedCriteria<ReportConfigInfo>(detachedCriteria);
            if (listReportConfigInfo != null && listReportConfigInfo.Count > 0)
            {
                return listReportConfigInfo.Select(reportConfigInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetReportConfigInfoEntity(reportConfigInfo)).ToList();
            }
            else
                return null;

        }

        internal List<OGCIncomingQueueEntity> GetListOGCIncomingQueueByRelatedDocId(string relatedDocId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<OGCIncomingQueue>()
                 .Add(Expression.Eq("RelatedDocId", relatedDocId));

            List<OGCIncomingQueue> listOGCIncomingQueue = GetFromDetachedCriteria<OGCIncomingQueue>(detachedCriteria);

            if (listOGCIncomingQueue != null && listOGCIncomingQueue.Count > 0)
            {
                return listOGCIncomingQueue.Select(oGCIncomingQueue => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetOGCIncomingQueueEntity(oGCIncomingQueue)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<JudicialUserEntity> GetListJudicialUserEntityByReportConfigInfoId(string reportConfigInfoId)
        {
            try
            {

                //TODO: Need to Modify SQL Query to Criteria API

                IQuery query = applicationSession.CreateSQLQuery(
                                @"SElect distinct Users.UserId,Users.UserName from ReportConfigInfo
                                  INNER Join ReportConfigUser ON  ReportConfigInfo.ReportConfigInfoId=ReportConfigUser.ReportConfigInfoId
                                  INNER JOIN RUserRoleSection ON ReportConfigUser.UserId=RUserRoleSection.UserId
                                  INNER JOIN  Users  ON  RUserRoleSection.UserId= Users.UserId
                                  WHERE ReportConfigInfo.ReportConfigInfoId= '" + reportConfigInfoId + @"'
                                  AND  ReportConfigUser.ObsInd='N'");

                List<object> listUsers = query.List<object>().ToList();
                if (listUsers != null && listUsers.Count > 0)
                {
                    return this.TransformToJudicialUser(listUsers);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetListReportConfigUserEntity", ex);
                throw;
            }
        }

        internal List<CaseStatusRuleInfoEntity> GetCaseStatusRuleInfoEntity(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseStatusRuleInfo>()
                 .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<CaseStatusRuleInfo> listCaseStatusRuleInfo = GetFromDetachedCriteria<CaseStatusRuleInfo>(detachedCriteria);

            if (listCaseStatusRuleInfo != null && listCaseStatusRuleInfo.Count > 0)
            {
                return listCaseStatusRuleInfo.Select(caseStatusRuleInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetCaseStatusRuleInfoEntity(caseStatusRuleInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<TaskListEntity> GetListTaskListByHRGId(long? hrgId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<TaskList>()
                .Add(Expression.Eq("HrgID", hrgId));
            List<TaskList> listTaskList = GetFromDetachedCriteria<TaskList>(detachedCriteria);

            if (listTaskList != null && listTaskList.Count > 0)
            {
                return listTaskList.Select(taskList => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
                    .BackEndSpecificMapper.GetTaskListEntity(taskList)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal WorkflowOutgoingQueueEntity GetWorkflowOutgoingQueueByPK(string workflowOutgoingQueueId)
        {
            IRepository<WorkflowOutgoingQueue> repository = new RepositoryImpl<WorkflowOutgoingQueue>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetWorkflowOutgoingQueueEntity(repository.Get(workflowOutgoingQueueId));
        }

        internal WorkflowOutgoingQueueEntity GetWorkflowOutgoingQueueEntityByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<WorkflowOutgoingQueue>()
               .Add(Expression.Eq("DocId", docId));
            List<WorkflowOutgoingQueue> listWorkflowOutgoingQueue = GetFromDetachedCriteria<WorkflowOutgoingQueue>(detachedCriteria);

            if (listWorkflowOutgoingQueue != null && listWorkflowOutgoingQueue.Count > 0)
            {
                return listWorkflowOutgoingQueue.Select(workFlowOutgoingQueue => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
                    .BackEndSpecificMapper.GetWorkflowOutgoingQueueEntity(workFlowOutgoingQueue)).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        internal DutyJudgeAssignmentEntity GetDutyJudgeAssignmentEntityByPK(string dutyJudgeAssignmentId)
        {
            IRepository<DutyJudgeAssignment> repository = new RepositoryImpl<DutyJudgeAssignment>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetDutyJudgeAssignmentEntity(repository.Get(dutyJudgeAssignmentId));
       
        }

        internal List<DutyJudgeAssignmentEntity> GetAllDutyJudgeAssignmentEntity()
        {
            List<DutyJudgeAssignment> listDutyJudgeAssignment = GetAllFromRepository<DutyJudgeAssignment>();
            if (listDutyJudgeAssignment != null && listDutyJudgeAssignment.Count > 0)
            {
                return listDutyJudgeAssignment.Select(dutyJudgeAssignment => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetDutyJudgeAssignmentEntity(dutyJudgeAssignment)).ToList();
            }
            else
            {
                return null;
            }
        }

        private List<T> GetAllFromRepository<T>()
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll() as List<T>;
        }

        internal List<JudicialUserEntity> GetUsersEntityLikeUserName(string userName)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<JudicialUser>()
                                    .Add(Expression.Like("UserName", userName, MatchMode.Anywhere));

            List<JudicialUser> listUsers = GetFromDetachedCriteria<JudicialUser>(detachedCriteria);

            if (listUsers != null && listUsers.Count > 0)
            {
                return listUsers.Select(user => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetJudicialUserEntity(user)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the RPT disposal KPI config entity.
        /// </summary>
        /// <returns></returns>
        internal List<RPTDisposalKPIConfigEntity> GetAllRPTDisposalKPIConfigEntity()
        {
            List<RPTDisposalKPIConfig> listRPTDisposalKPIConfig = GetAllFromRepository<RPTDisposalKPIConfig>();
            if (listRPTDisposalKPIConfig != null && listRPTDisposalKPIConfig.Count > 0)
            {
                return listRPTDisposalKPIConfig.Select(rptDisposalKPIConfig => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetRPTDisposalKPIConfigEntity(rptDisposalKPIConfig)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the RPTNOC group NOC entity.
        /// </summary>
        /// <returns></returns>
        internal List<RPTNOCGroupNOCEntity> GetAllRPTNOCGroupNOCEntity()
        {
            List<RPTNOCGroupNOC> listRPTNOCGroupNOC = GetAllFromRepository<RPTNOCGroupNOC>();
            if (listRPTNOCGroupNOC != null && listRPTNOCGroupNOC.Count > 0)
            {
                return listRPTNOCGroupNOC.Select(rptNOCGroupNOC => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetRPTNOCGroupNOCEntity(rptNOCGroupNOC)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets all RPTNOC group entity.
        /// </summary>
        /// <returns></returns>
        internal List<RPTNOCGroupEntity> GetAllRPTNOCGroupEntity()
        {
            List<RPTNOCGroup> listRPTNOCGroup = GetAllFromRepository<RPTNOCGroup>();
            if (listRPTNOCGroup != null && listRPTNOCGroup.Count > 0)
            {
                return listRPTNOCGroup.Select(rptNOCGroup => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetRPTNOCGroupEntity(rptNOCGroup)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the RPT disposal KPI config entity.
        /// </summary>
        /// <returns></returns>
        internal RPTDisposalKPIConfigEntity GetRPTDisposalKPIConfigEntity(int rptDisposalKPIConfigId)
        {
            IRepository<RPTDisposalKPIConfig> rptDisposalKPIConfigRepository = new RepositoryImpl<RPTDisposalKPIConfig>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetRPTDisposalKPIConfigEntity(rptDisposalKPIConfigRepository.Get(rptDisposalKPIConfigId));
     
        }

        /// <summary>
        /// Gets the RPTNOC group NOC entity.
        /// </summary>
        /// <returns></returns>
        internal RPTNOCGroupNOCEntity GetRPTNOCGroupNOCEntity(string rptNOCGroupNOCCode)
        {
            IRepository<RPTNOCGroupNOC> rptNOCGroupNOCRepository = new RepositoryImpl<RPTNOCGroupNOC>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetRPTNOCGroupNOCEntity(rptNOCGroupNOCRepository.Get(rptNOCGroupNOCCode));
   
        }

        /// <summary>
        /// Gets the RPTNOC group entity.
        /// </summary>
        /// <param name="NocGroupCode">The noc group code.</param>
        /// <returns></returns>
        internal RPTNOCGroupEntity GetRPTNOCGroupEntity(string NocGroupCode)
        {
            IRepository<RPTNOCGroup> rptNOCGroupRepository = new RepositoryImpl<RPTNOCGroup>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetRPTNOCGroupEntity(rptNOCGroupRepository.Get(NocGroupCode));
        }



       
    }
}