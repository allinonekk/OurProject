namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain.CaseData;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCaseData;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using NHibernate;
    using NHibernate.Criterion;

    internal class CommonGateway
    {
        #region Fields

        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        public CommonGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

            //MappingToDTO nHibernateToDomainMapping = new MappingToDTO();
            //nHibernateToDomainMapping.MapAll();

            //MappingToDomain DomainToNHibernateMapping = new MappingToDomain();
            //DomainToNHibernateMapping.MapAll();
        }

        #endregion Constructors

        #region Methods

        public void SaveOrUpdateOtherITMOList(List<OtherITMOEntity> listOtherITMOEntity)
        {
            if (listOtherITMOEntity != null && listOtherITMOEntity.Count > 0)
            {
                foreach (OtherITMOEntity otherITMOEntity in listOtherITMOEntity)
                {
                    SaveOrUpdateOtherITMOEntity(otherITMOEntity);
                }
            }
        }

        internal void DeleteAffidavitDeponentDetailList(string affidavitId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<AffidavitDeponentDetail>()
                   .Add(Expression.Eq("AffidavitId", affidavitId));
            List<AffidavitDeponentDetail> listAffidavitDeponentDetail = GetFromDetachedCriteria<AffidavitDeponentDetail>(detachedCriteria);
            if (listAffidavitDeponentDetail != null && listAffidavitDeponentDetail.Count > 0)
            {
                Repository<AffidavitDeponentDetail>().DeleteAll(listAffidavitDeponentDetail);
            }
        }

        internal void DeleteAffidavitInfoList(string caseInfoId, string subCaseInfoId, string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<AffidavitInfo>()
                   .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                   .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(subCaseInfoId)))
                   .Add(Expression.Eq("DocId", docId));
            List<AffidavitInfo> listAffidavitInfo = GetFromDetachedCriteria<AffidavitInfo>(detachedCriteria);
            if (listAffidavitInfo != null && listAffidavitInfo.Count > 0)
            {
                Repository<AffidavitInfo>().DeleteAll(listAffidavitInfo);
            }
        }

        internal void DeleteCertSecurityOfCostsInfoList(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CertSecurityOfCostsInfo>()
                   .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            Repository<CertSecurityOfCostsInfo>().DeleteAll(detachedCriteria);
        }

        internal void DeleteLegislationProvisionsList(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<LegislationProvision>()
                 .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            Repository<LegislationProvision>().DeleteAll(detachedCriteria);
        }

        internal void DeleteLiquidatorList(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<Liquidator>()
                  .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<Liquidator> listLiquidator = GetFromDetachedCriteria<Liquidator>(detachedCriteria);
            if (listLiquidator != null && listLiquidator.Count > 0)
            {
                Repository<Liquidator>().DeleteAll(listLiquidator);
            }
        }

        internal void DeleteNatureOfApplicationList(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<NatureOfApplication>()
                 .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<NatureOfApplication> listNatureOfApplication = GetFromDetachedCriteria<NatureOfApplication>(detachedCriteria);
            if (listNatureOfApplication != null && listNatureOfApplication.Count > 0)
            {
                Repository<NatureOfApplication>().DeleteAll(listNatureOfApplication);
            }
        }

        internal void DeleteNatureOfApplicationListByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<NatureOfApplication>()
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            Repository<NatureOfApplication>().DeleteAll(detachedCriteria);
        }

        internal void DeleteNatureOfCaseList(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<NatureOfCase>()
                 .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<NatureOfCase> listNatureOfCase = GetFromDetachedCriteria<NatureOfCase>(detachedCriteria);
            if (listNatureOfCase != null && listNatureOfCase.Count > 0)
            {
                Repository<NatureOfCase>().DeleteAll(listNatureOfCase);
            }
        }

        internal void DeleteNatureOfCaseListByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<NatureOfCase>()
                 .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            Repository<NatureOfCase>().DeleteAll(detachedCriteria);
        }

        internal void DeleteOriginatingCaseBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(OriginatingCase))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            IRepository<OriginatingCase> originatingCaseRepository = new RepositoryImpl<OriginatingCase>(applicationSession);

            IList<OriginatingCase> listOriginatingCase = originatingCaseRepository.GetAll(detachedCriteria) as IList<OriginatingCase>;
            if (listOriginatingCase != null && listOriginatingCase.Count > 0)
            {
                originatingCaseRepository.DeleteAll(listOriginatingCase);
            }
        }

        internal void DeleteOtherITMOList(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<OtherITMO>()
                 .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            Repository<OtherITMO>().DeleteAll(detachedCriteria);
        }

        internal void DeleteRefOrderDetailList(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RefOrderDetail>()
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<RefOrderDetail> listRefOrderDetail = GetFromDetachedCriteria<RefOrderDetail>(detachedCriteria);
            if (listRefOrderDetail != null && listRefOrderDetail.Count > 0)
            {
                Repository<RefOrderDetail>().DeleteAll(listRefOrderDetail);
            }
        }

        internal void DeleteRefSubCaseList(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RefSubCase>()
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<RefSubCase> listRefSubCase = GetFromDetachedCriteria<RefSubCase>(detachedCriteria);
            if (listRefSubCase != null && listRefSubCase.Count > 0)
            {
                Repository<RefSubCase>().DeleteAll(listRefSubCase);
            }
        }

        internal void DeleteSubmissionInfoList(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<SubmissionInfo>()
                     .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            Repository<SubmissionInfo>().DeleteAll(detachedCriteria);
        }

        internal void DeleteWOECaseExecutionAddress(long caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<WOECaseExecutionAddress>()
                .Add(Expression.Eq("CaseInfoId", caseInfoId));

            List<WOECaseExecutionAddress> listWOECaseExecutionAddress = GetFromDetachedCriteria<WOECaseExecutionAddress>(detachedCriteria);
            if (listWOECaseExecutionAddress != null && listWOECaseExecutionAddress.Count > 0)
            {
                Repository<WOECaseExecutionAddress>().DeleteAll(listWOECaseExecutionAddress);

            }
        }

        internal void DeleteWOECaseExecutionAddress(long caseInfoId, long? subCaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<WOECaseExecutionAddress>()
                 .Add(Expression.Eq("CaseInfoId", caseInfoId))
                 .Add(Expression.Eq("SubCaseInfoId", subCaseInfoId));

            List<WOECaseExecutionAddress> listWOECaseExecutionAddress = GetFromDetachedCriteria<WOECaseExecutionAddress>(detachedCriteria);
            if (listWOECaseExecutionAddress != null && listWOECaseExecutionAddress.Count > 0)
            {
                Repository<WOECaseExecutionAddress>().DeleteAll(listWOECaseExecutionAddress);

            }
        }

        internal void DeleteWOEExecutionAddressEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WOEExecutionAddress))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            IRepository<WOEExecutionAddress> WOEExecutionAddressRepository = new RepositoryImpl<WOEExecutionAddress>(applicationSession);
            WOEExecutionAddressRepository.DeleteAll(GetAllWOEExecutionAddress(detachedCriteria));
        }

        internal BTSRoutingQueueEntity GetBTSRoutingQueue(string messageId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<BTSRoutingQueue>()
                     .Add(Expression.Eq("MessageId", messageId));
            List<BTSRoutingQueue> listBTSRoutingQueue = GetFromDetachedCriteria<BTSRoutingQueue>(detachedCriteria);
            if (listBTSRoutingQueue != null && listBTSRoutingQueue.Count > 0)
            {
                return listBTSRoutingQueue.Select(bTSRoutingQueue => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetBTSRoutingQueueEntity(bTSRoutingQueue)).ToList()[0];
            }
            else
                return null;
        }

        internal List<ChildInfoEntity> GetChildInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ChildInfo))
                                                                  .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<ChildInfo> listChildInfo = GetFromDetachedCriteria<ChildInfo>(detachedCriteria);
            if (listChildInfo != null && listChildInfo.Count > 0)
            {
                return listChildInfo.Select(childInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetChildInfoEntity(childInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal CWUData GetCWUDataBySGID(string SGID)
        {
            CWUGateway gateway = new CWUGateway();
            CWUData cWUData = new CWUData();
            cWUData.CWUInfoEntity = gateway.GetCWUInfoBySGID(SGID);
            cWUData.LegislationProvisionsEntityList = GetListLegislationProvisionsEntityBySGID(SGID);
            cWUData.LiquidatorEntityList = GetListLiquidatorEntityBySGID(SGID);
            cWUData.NatureOfCaseEntityList = GetListNatureOfCaseEntityBySGID(SGID);
            cWUData.OtherITMOEntityList = GetListOtherITMOEntityBySGID(SGID);
            cWUData.PrayerEntityList = GetListPrayerEntityBySGID(SGID);
            return cWUData;
        }

        internal DivorceInfoEntity GetDivorceInfoEntityBySGID(string submissionGroupId)
        {
            DivorceInfoEntity divorceInfoEntity = null;
            List<DivorceInfo> listDivorceInfo = new List<DivorceInfo>();
            IRepository<DivorceInfo> divorceInfoRepository = new RepositoryImpl<DivorceInfo>(applicationSession);

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DivorceInfo))
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            listDivorceInfo = divorceInfoRepository.GetAll(detachedCriteria) as List<DivorceInfo>;
            if (listDivorceInfo != null && listDivorceInfo.Count > 0)
            {
                foreach (DivorceInfo divorceInfo in listDivorceInfo)
                {
                    divorceInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetDivorceInfoEntity(divorceInfo);
                }
            }
            return divorceInfoEntity;
        }

        internal List<RefSubCaseEntity> GetRefSubCaseBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RefSubCase))
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<RefSubCase> listRefSubCase = GetFromDetachedCriteria<RefSubCase>(detachedCriteria);
            if (listRefSubCase != null && listRefSubCase.Count > 0)
            {
                return listRefSubCase.Select(refSubCase => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRefSubCaseEntity(refSubCase)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<OriginatingCaseEntity> GetOriginatingCaseEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(OriginatingCase))
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<OriginatingCase> listOriginatingCase = GetFromDetachedCriteria<OriginatingCase>(detachedCriteria);
            if (listOriginatingCase != null && listOriginatingCase.Count > 0)
            {
                return listOriginatingCase.Select(originatingCase => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetOriginatingCaseEntity(originatingCase)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<FilingFeeDetailEntity> GetFilingFeeDetailBySGID(string submissionGroupId)
        {
            var subCriteria = DetachedCriteria.For(typeof(DocumentInfo));
            subCriteria.SetProjection(Projections.Property("DocId")).Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(FilingFeeDetail)).Add(Subqueries.PropertyIn("DocId", subCriteria));

            IRepository<FilingFeeDetail> filingFeeDetailRepository = new RepositoryImpl<FilingFeeDetail>(applicationSession);
            List<FilingFeeDetail> listFilingFeeDetail = filingFeeDetailRepository.FindAll(iCriterion).ToList();
            if (listFilingFeeDetail != null && listFilingFeeDetail.Count > 0)
            {
                return listFilingFeeDetail.Select(filingFeeDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetFilingFeeDetailEntity(filingFeeDetail)).ToList();
            }
            else
                return null;
        }

        internal List<GroundInfoEntity> GetGroundInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(GroundInfo))
                                                               .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<GroundInfo> listGroundInfo = GetFromDetachedCriteria<GroundInfo>(detachedCriteria);
            if (listGroundInfo != null && listGroundInfo.Count > 0)
            {
                return listGroundInfo.Select(groundInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetGroundInfoEntity(groundInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal LegislationProvisionsEntity GetLegislationProvisionsEntity(string legislationProvisionId)
        {
            Criteria criteria = new Criteria("LegislationProvisionId", legislationProvisionId);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetLegislationProvisionEntity(GetLegislationProvisions(criteria));
        }

        internal List<AffidavitDeponentDetailEntity> GetListAffidavitDeponentDetailEntityByAffidavitId(string AffidavitId)
        {
            List<AffidavitDeponentDetailEntity> listAffidavitDeponentDetailEntity = new List<AffidavitDeponentDetailEntity>();
            IRepository<AffidavitDeponentDetail> affidavitDeponentDetailRepository = new RepositoryImpl<AffidavitDeponentDetail>(applicationSession);
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(AffidavitDeponentDetail))
              .Add(Expression.Eq("AffidavitId", AffidavitId));
            List<AffidavitDeponentDetail> listAffidavitDeponentDetail = affidavitDeponentDetailRepository.GetAll(detachedCriteria) as List<AffidavitDeponentDetail>;
            if (listAffidavitDeponentDetail != null && listAffidavitDeponentDetail.Count > 0)
            {
                foreach (AffidavitDeponentDetail affidavitDeponentDetail in listAffidavitDeponentDetail)
                {
                    AffidavitDeponentDetailEntity affidavitDeponentDetailEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetAffidavitDeponentDetailEntity(affidavitDeponentDetail);

                    listAffidavitDeponentDetailEntity.Add(affidavitDeponentDetailEntity);
                }
                return listAffidavitDeponentDetailEntity;

            }
            return null;
        }

        internal List<AffidavitInfoEntity> GetListAffidavitInfoEntity(string caseInfoId, string subCaseInfoId, string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(AffidavitInfo))
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(subCaseInfoId)))
                .Add(Expression.Eq("DocId", docId));
            List<AffidavitInfo> listAffidavitInfo = GetFromDetachedCriteria<AffidavitInfo>(detachedCriteria);
            if (listAffidavitInfo != null && listAffidavitInfo.Count > 0)
            {
                return listAffidavitInfo.Select(affidavitInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetAffidavitInfoEntity(affidavitInfo)).ToList();
            }
            else
                return null;
        }

        internal List<AffidavitInfoEntity> GetListAffidavitInfoEntityBySGID(string submissionGroupId)
        {
            List<AffidavitInfoEntity> listAffidavitInfoEntity = new List<AffidavitInfoEntity>();
            IRepository<AffidavitInfo> affidavitInfoRepository = new RepositoryImpl<AffidavitInfo>(applicationSession);
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(AffidavitInfo))
              .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<AffidavitInfo> listAffidavitInfo = affidavitInfoRepository.GetAll(detachedCriteria) as List<AffidavitInfo>;
            if (listAffidavitInfo != null && listAffidavitInfo.Count > 0)
            {
                foreach (AffidavitInfo affidavitInfo in listAffidavitInfo)
                {
                    AffidavitInfoEntity affidavitInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetAffidavitInfoEntity(affidavitInfo);

                    listAffidavitInfoEntity.Add(affidavitInfoEntity);
                }
                return listAffidavitInfoEntity;

            }
            return null;
        }

        internal List<BTSRoutingQueueEntity> GetListBTSRoutingQueue(string messageId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BTSRoutingQueue))
                .Add(Expression.Eq("MessageId", messageId));
            List<BTSRoutingQueue> listBTSRoutingQueue = GetFromDetachedCriteria<BTSRoutingQueue>(detachedCriteria);
            if (listBTSRoutingQueue != null && listBTSRoutingQueue.Count > 0)
            {
                return listBTSRoutingQueue.Select(bTSRoutingQueue => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetBTSRoutingQueueEntity(bTSRoutingQueue)).ToList();
            }
            else
                return null;
        }

        internal List<BTSRoutingQueueEntity> GetListBTSRoutingQueueByStatus(string status)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BTSRoutingQueue))
                  .Add(Expression.Eq("Status", status));
            List<BTSRoutingQueue> listBTSRoutingQueue = GetFromDetachedCriteria<BTSRoutingQueue>(detachedCriteria);
            if (listBTSRoutingQueue != null && listBTSRoutingQueue.Count > 0)
            {
                return listBTSRoutingQueue.Select(bTSRoutingQueue => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetBTSRoutingQueueEntity(bTSRoutingQueue)).ToList();
            }
            else
                return null;
        }

        internal List<CDRInfoEntity> GetListCDRInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CDRInfo))
                                                                              .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<CDRInfo> listCDRInfo = GetCDRInfo(detachedCriteria);

            if (listCDRInfo != null && listCDRInfo.Count > 0)
            {
                return listCDRInfo.Select(cDRInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetCDRInfoEntity(cDRInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<CertSecurityOfCostsInfoEntity> GetListCertSecurityOfCostsInfo(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<CertSecurityOfCostsInfo>()
                   .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<CertSecurityOfCostsInfo> listCertSecurityOfCostsInfo = GetFromDetachedCriteria<CertSecurityOfCostsInfo>(detachedCriteria);
            if (listCertSecurityOfCostsInfo != null && listCertSecurityOfCostsInfo.Count > 0)
            {
                return listCertSecurityOfCostsInfo.Select(certSecurityOfCostsInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetCertSecurityOfCostsInfoEntity(certSecurityOfCostsInfo)).ToList();
            }
            else
                return null;
        }

        /// <summary>
        /// Gets the list checklist instance entity by case info id.
        /// </summary>
        /// <param name="caseInfoId">The case info id.</param>
        /// <returns></returns>
        internal List<ChecklistInstanceEntity> GetListChecklistInstanceEntityByCaseInfoId(string caseInfoId)
        {
            ChecklistInstanceEntity checklistInstanceEntity = null;
            List<ChecklistInstanceEntity> listChecklistInstanceEntity = new List<ChecklistInstanceEntity>();
            IRepository<CheckListInstance> checklistInstanceRepository = new RepositoryImpl<CheckListInstance>(applicationSession);

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CheckListInstance))
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            List<CheckListInstance> listChecklistInstance = checklistInstanceRepository.GetAll(detachedCriteria) as List<CheckListInstance>;
            if (listChecklistInstance != null && listChecklistInstance.Count > 0)
            {
                foreach (CheckListInstance checklistInstance in listChecklistInstance)
                {
                    checklistInstanceEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetChecklistInstanceEntity(checklistInstance);
                    listChecklistInstanceEntity.Add(checklistInstanceEntity);
                }
                return listChecklistInstanceEntity;
            }
            else
                return null;
        }

        internal ChecklistInstanceEntity GetListChecklistInstanceEntityByPK(string checkListInstanceId)
        {
            IRepository<CheckListInstance> checkListInstanceRepository = new RepositoryImpl<CheckListInstance>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetChecklistInstanceEntity(checkListInstanceRepository.Get(checkListInstanceId));
        }

        /// <summary>
        /// Gets the list checklist submission by submission group id.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        internal List<ChecklistSubmissionEntity> GetListChecklistSubmissionBySubmissionGroupId(string submissionGroupId)
        {
            ChecklistSubmissionEntity checklistSubmissionEntity = null;
            List<ChecklistSubmissionEntity> listChecklistSubmissionEntity = new List<ChecklistSubmissionEntity>();
            IRepository<CheckListSubmission> checklistSubmissionRepository = new RepositoryImpl<CheckListSubmission>(applicationSession);

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CheckListSubmission))
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<CheckListSubmission> listChecklistSubmission = checklistSubmissionRepository.GetAll(detachedCriteria) as List<CheckListSubmission>;
            if (listChecklistSubmission != null && listChecklistSubmission.Count > 0)
            {
                foreach (CheckListSubmission checklistSubmission in listChecklistSubmission)
                {
                    checklistSubmissionEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetChecklistSubmissionEntity(checklistSubmission);
                    listChecklistSubmissionEntity.Add(checklistSubmissionEntity);
                }
                return listChecklistSubmissionEntity;
            }
            else
                return null;
        }

        internal List<ChecklistSubmissionEntity> GetListChecklistSubmissionEntityByCheckListInstanceId(string checkListInstanceId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CheckListSubmission))
                                                               .Add(Expression.Eq("ChecklistInstanceId", checkListInstanceId));
            List<CheckListSubmission> listCheckListSubmission = GetAllCheckListSubmission(detachedCriteria);
            if (listCheckListSubmission != null && listCheckListSubmission.Count > 0)
            {
                return listCheckListSubmission.Select(checkListSubmission => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetChecklistSubmissionEntity(checkListSubmission)).ToList();
            }
            else
                return null;
        }

        internal List<ChecklistSubmissionEntity> GetListChecklistSubmissionEntityByDocId(string docId)
        {
            ChecklistSubmissionEntity checklistSubmissionEntity = null;
            List<ChecklistSubmissionEntity> listChecklistSubmissionEntity = new List<ChecklistSubmissionEntity>();
            IRepository<CheckListSubmission> checklistSubmissionRepository = new RepositoryImpl<CheckListSubmission>(applicationSession);

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CheckListSubmission))
                .Add(Expression.Eq("DocId", docId));

            List<CheckListSubmission> listChecklistSubmission = checklistSubmissionRepository.GetAll(detachedCriteria) as List<CheckListSubmission>;
            if (listChecklistSubmission != null && listChecklistSubmission.Count > 0)
            {
                foreach (CheckListSubmission checklistSubmission in listChecklistSubmission)
                {
                    checklistSubmissionEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetChecklistSubmissionEntity(checklistSubmission);
                    listChecklistSubmissionEntity.Add(checklistSubmissionEntity);
                }
                return listChecklistSubmissionEntity;
            }
            else
                return null;
        }

        internal List<DeceasedAliasEntity> GetListDeceasedAliasBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DeceasedAlias))
                   .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<DeceasedAlias> listDeceasedAlias = GetFromDetachedCriteria<DeceasedAlias>(detachedCriteria);
            if (listDeceasedAlias != null && listDeceasedAlias.Count > 0)
            {
                return listDeceasedAlias.Select(deceasedAlias => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetDeceasedAliasEntity(deceasedAlias)).ToList();

            }
            else
            {
                return null;
            }
        }

        internal List<DeceasedIdentificationsEntity> GetListDeceasedIdentificationBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DeceasedIdentification))
                  .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<DeceasedIdentification> listDeceasedIdentification = GetFromDetachedCriteria<DeceasedIdentification>(detachedCriteria);
            if (listDeceasedIdentification != null && listDeceasedIdentification.Count > 0)
            {
                return listDeceasedIdentification.Select(deceasedIdentification => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetDeceasedIdentificationsEntity(deceasedIdentification)).ToList();

            }
            else
            {
                return null;
            }
        }

        internal List<DeceasedInfoEntity> GetListDeceasedInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DeceasedInfo))
                  .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<DeceasedInfo> listDeceasedInfo = GetFromDetachedCriteria<DeceasedInfo>(detachedCriteria);
            if (listDeceasedInfo != null && listDeceasedInfo.Count > 0)
            {
                return listDeceasedInfo.Select(deceasedInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetDeceasedInfoEntity(deceasedInfo)).ToList();

            }
            else
            {
                return null;
            }
        }

        internal List<DegreeInfoEntity> GetListDegreeInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DegreeInfo>()
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<DegreeInfo> listDegreeInfo = GetFromDetachedCriteria<DegreeInfo>(detachedCriteria);
            if (listDegreeInfo != null && listDegreeInfo.Count > 0)
            {
                return listDegreeInfo.Select(degreeInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetDegreeInfoEntity(degreeInfo)).ToList();
            }
            else
                return null;
        }

        internal List<DocAppProcessByExAgencyEntity> GetListDocAppProcessByExAgencyBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DocAppProcessByExAgency>()
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<DocAppProcessByExAgency> listDocAppProcessByExAgency = GetFromDetachedCriteria<DocAppProcessByExAgency>(detachedCriteria);
            if (listDocAppProcessByExAgency != null && listDocAppProcessByExAgency.Count > 0)
            {
                return listDocAppProcessByExAgency.Select(docAppProcessByExAgency => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetDocAppProcessByExAgencyEntity(docAppProcessByExAgency)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<EmploymentInfoEntity> GetListEmploymentInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(EmploymentInfo))
                                                            .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<EmploymentInfo> listEmploymentInfo = GetAllEmploymentInfo(detachedCriteria);
            if (listEmploymentInfo != null && listEmploymentInfo.Count > 0)
            {
                return listEmploymentInfo.Select(employmentInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetEmploymentInfoEntity(employmentInfo)).ToList();
            }
            else
                return null;
        }

        internal List<FilingFeeDetailEntity> GetListFilingFeeDetailByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<FilingFeeDetail>()
                .Add(Expression.Eq("DocId", docId));

            List<FilingFeeDetail> listFilingFeeDetail = GetFromDetachedCriteria<FilingFeeDetail>(detachedCriteria);
            if (listFilingFeeDetail != null && listFilingFeeDetail.Count > 0)
            {
                return listFilingFeeDetail.Select(filingFeeDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetFilingFeeDetailEntity(filingFeeDetail)).ToList();
            }
            else

                return null;
        }

        internal List<FilingFeeRequestDetailEntity> GetListFilingFeeRequestDetailByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<FilingFeeRequestDetail>()
                 .Add(Expression.Eq("DocId", docId));

            List<FilingFeeRequestDetail> listFilingFeeRequestDetail = GetFromDetachedCriteria<FilingFeeRequestDetail>(detachedCriteria);
            if (listFilingFeeRequestDetail != null && listFilingFeeRequestDetail.Count > 0)
            {
                return listFilingFeeRequestDetail.Select(filingFeeRequestDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetFilingFeeRequestDetailEntity(filingFeeRequestDetail)).ToList();
            }
            else

                return null;
        }

        internal List<InfantInfoEntity> GetListInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(InfantInfo))
                   .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<InfantInfo> listInfantInfo = GetFromDetachedCriteria<InfantInfo>(detachedCriteria);
            if (listInfantInfo != null && listInfantInfo.Count > 0)
            {
                return listInfantInfo.Select(infantInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetInfantInfoEntity(infantInfo)).ToList();

            }
            else
            {
                return null;
            }
        }

        internal List<LegalExperienceInfoEntity> GetListLegalExperienceInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<LegalExperienceInfo>()
                 .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<LegalExperienceInfo> listLegalExperienceInfo = GetFromDetachedCriteria<LegalExperienceInfo>(detachedCriteria);
            if (listLegalExperienceInfo != null && listLegalExperienceInfo.Count > 0)
            {
                return listLegalExperienceInfo.Select(legalExperienceInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetLegalExperienceInfoEntity(legalExperienceInfo)).ToList();
            }
            else
                return null;
        }

        internal List<LegislationProvisionsEntity> GetListLegislationProvision<V>(string fieldName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LegislationProvision))
                .Add(Expression.Eq(fieldName, value));
            List<LegislationProvision> listLegislationProvision = GetFromDetachedCriteria<LegislationProvision>(detachedCriteria);
            if (listLegislationProvision != null && listLegislationProvision.Count > 0)
            {
                return listLegislationProvision.Select(legislationProvision => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetLegislationProvisionEntity(legislationProvision)).ToList();
            }
            else
                return null;
        }

        internal List<LegislationProvisionsEntity> GetListLegislationProvisionsEntityBySGID(string SGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LegislationProvision))
                                                                .Add(Expression.Eq("SubmissionGroupId", SGID));

            List<LegislationProvision> listLegislationProvision = GetFromDetachedCriteria<LegislationProvision>(detachedCriteria);
            if (listLegislationProvision != null && listLegislationProvision.Count > 0)
            {
                return listLegislationProvision.Select(legislationProvision => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetLegislationProvisionEntity(legislationProvision)).ToList();
            }
            else
                return null;
        }

        internal List<LiquidatedClaimEntity> GetListLiquidatedClaimBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LiquidatedClaim))
                  .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<LiquidatedClaim> listLiquidatedClaim = GetFromDetachedCriteria<LiquidatedClaim>(detachedCriteria);

            if (listLiquidatedClaim != null && listLiquidatedClaim.Count > 0)
            {
                return listLiquidatedClaim.Select(liquidatedClaim => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetLiquidatedClaimEntity(liquidatedClaim)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<LiquidatorEntity> GetListLiquidatorEntityBySGID(string SGID)
        {
            List<LiquidatorEntity> listLiquidatorEntity = new List<LiquidatorEntity>();
            LiquidatorEntity liquidatorEntity = new LiquidatorEntity();
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(Liquidator))
                                                                .Add(Expression.Eq("SubmissionGroupId", SGID));

            IRepository<Liquidator> liquidatorRepository = new RepositoryImpl<Liquidator>(applicationSession);

            List<Liquidator> listLiquidator = liquidatorRepository.GetAll(detachedCriteria) as List<Liquidator>;
            if (listLiquidator != null && listLiquidator.Count > 0)
            {
                foreach (Liquidator liquidator in listLiquidator)
                {
                    liquidatorEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetLiquidatorEntity(liquidator);
                    listLiquidatorEntity.Add(liquidatorEntity);
                }
            }
            return listLiquidatorEntity;
        }

        internal List<MinuteSheetDocListEntity> GetListMinuteSheetDocList(string minuteSheetInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MinuteSheetDocList))
                  .Add(Expression.Eq("MinuteSheetInfoId", minuteSheetInfoId));

            List<MinuteSheetDocList> listMinuteSheetDocList = GetFromDetachedCriteria<MinuteSheetDocList>(detachedCriteria);

            if (listMinuteSheetDocList != null && listMinuteSheetDocList.Count > 0)
            {
                return listMinuteSheetDocList.Select(minuteSheetDocList => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetMinuteSheetDocListEntity(minuteSheetDocList)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MinuteSheetDocListEntity> GetListMinuteSheetDocListByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<MinuteSheetDocList>()
                .Add(Expression.Eq("DocId", docId));
            List<MinuteSheetDocList> listMinuteSheetDocList = GetFromDetachedCriteria<MinuteSheetDocList>(detachedCriteria);
            if (listMinuteSheetDocList != null && listMinuteSheetDocList.Count > 0)
            {
                return listMinuteSheetDocList.Select(minuteSheetDocList => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetMinuteSheetDocListEntity(minuteSheetDocList)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MinuteSheetFamilyRelatedInfoEntity> GetListMinuteSheetFamilyRelatedInfo(string minuteSheetInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MinuteSheetFamilyRelatedInfo))
                  .Add(Expression.Eq("MinuteSheetInfoId", minuteSheetInfoId));

            List<MinuteSheetFamilyRelatedInfo> listMinuteSheetFamilyRelatedInfo = GetFromDetachedCriteria<MinuteSheetFamilyRelatedInfo>(detachedCriteria);

            if (listMinuteSheetFamilyRelatedInfo != null && listMinuteSheetFamilyRelatedInfo.Count > 0)
            {
                return listMinuteSheetFamilyRelatedInfo.Select(minuteSheetFamilyRelatedInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetMinuteSheetFamilyRelatedInfoEntity(minuteSheetFamilyRelatedInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MinuteSheetGroundInfoEntity> GetListMinuteSheetGroundInfo(string minuteSheetInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MinuteSheetGroundInfo))
                 .Add(Expression.Eq("MinuteSheetInfoId", minuteSheetInfoId));

            List<MinuteSheetGroundInfo> listMinuteSheetGroundInfo = GetFromDetachedCriteria<MinuteSheetGroundInfo>(detachedCriteria);

            if (listMinuteSheetGroundInfo != null && listMinuteSheetGroundInfo.Count > 0)
            {
                return listMinuteSheetGroundInfo.Select(minuteSheetGroundInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetMinuteSheetGroundInfoEntity(minuteSheetGroundInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MinuteSheetInfoEntity> GetListMinuteSheetInfo<V>(string fieldName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MinuteSheetInfo))
                .Add(Expression.Eq(fieldName, value));
            List<MinuteSheetInfo> listMinuteSheetInfo = GetFromDetachedCriteria<MinuteSheetInfo>(detachedCriteria);
            if (listMinuteSheetInfo != null && listMinuteSheetInfo.Count > 0)
            {
                return listMinuteSheetInfo.Select(minuteSheetInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetMinuteSheetInfoEntity(minuteSheetInfo)).ToList();
            }
            else
                return null;
        }

        internal List<MinuteSheetInfoEntity> GetListMinuteSheetInfoByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MinuteSheetInfo))
               .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<MinuteSheetInfo> listMinuteSheetInfo = GetFromDetachedCriteria<MinuteSheetInfo>(detachedCriteria);

            if (listMinuteSheetInfo != null && listMinuteSheetInfo.Count > 0)
            {
                return listMinuteSheetInfo.Select(minuteSheetInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetMinuteSheetInfoEntity(minuteSheetInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MinuteSheetPartyRepInfoEntity> GetListMinuteSheetPartyRepInfo(string minuteSheetInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MinuteSheetPartyRepInfo))
                .Add(Expression.Eq("MinuteSheetInfoId", minuteSheetInfoId));

            List<MinuteSheetPartyRepInfo> listMinuteSheetPartyRepInfo = GetFromDetachedCriteria<MinuteSheetPartyRepInfo>(detachedCriteria);

            if (listMinuteSheetPartyRepInfo != null && listMinuteSheetPartyRepInfo.Count > 0)
            {
                return listMinuteSheetPartyRepInfo.Select(minuteSheetPartyRepInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetMinuteSheetPartyRepInfoEntity(minuteSheetPartyRepInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MinuteSheetPartySolicitorInfoEntity> GetListMinuteSheetPartySolicitorInfo(string minuteSheetRepInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MinuteSheetPartySolicitorInfo))
                .Add(Expression.Eq("MinuteSheetPartyRepInfoId", minuteSheetRepInfoId));

            List<MinuteSheetPartySolicitorInfo> listMinuteSheetPartySolicitorInfo = GetFromDetachedCriteria<MinuteSheetPartySolicitorInfo>(detachedCriteria);

            if (listMinuteSheetPartySolicitorInfo != null && listMinuteSheetPartySolicitorInfo.Count > 0)
            {
                return listMinuteSheetPartySolicitorInfo.Select(minuteSheetPartySolicitorInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetMinuteSheetPartySolicitorInfoEntity(minuteSheetPartySolicitorInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<NatureOfApplicationEntity> GetListNatureOfApplicationEntityByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<NatureOfApplication>()
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<NatureOfApplication> listNatureOfApplication = GetFromDetachedCriteria<NatureOfApplication>(detachedCriteria);
            if (listNatureOfApplication != null && listNatureOfApplication.Count > 0)
            {
                return listNatureOfApplication.Select(natureOfApplication => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetNatureOfApplicationEntity(natureOfApplication)).ToList();
            }
            else
                return null;
        }

        internal List<NatureOfApplicationEntity> GetListNatureOfApplicationEntityByCaseSubCaseInfoId(string subcaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(NatureOfApplication))
                                                              .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(subcaseInfoId)));
            List<NatureOfApplication> listNatureOfApplication = GetNatureOfApplication(detachedCriteria);
            if (listNatureOfApplication != null && listNatureOfApplication.Count > 0)
            {
                return listNatureOfApplication.Select(natureOfApplication => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetNatureOfApplicationEntity(natureOfApplication)).ToList();
            }
            else
                return null;
        }

        internal List<NatureOfApplicationEntity> GetListNatureOfApplicationEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(NatureOfApplication))
                                                              .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<NatureOfApplication> listNatureOfApplication = GetNatureOfApplication(detachedCriteria);
            if (listNatureOfApplication != null && listNatureOfApplication.Count > 0)
            {
                return listNatureOfApplication.Select(natureOfApplication => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetNatureOfApplicationEntity(natureOfApplication)).ToList();
            }
            else
                return null;
        }

        internal List<NatureOfCaseEntity> GetListNatureOfCase<V>(string fieldName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(NatureOfCase))
                .Add(Expression.Eq(fieldName, value));
            List<NatureOfCase> listNatureOfCase = GetFromDetachedCriteria<NatureOfCase>(detachedCriteria);
            if (listNatureOfCase != null && listNatureOfCase.Count > 0)
            {
                return listNatureOfCase.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetNatureOfCaseEntity(natureOfCase)).ToList();
            }
            else
                return null;
        }

        internal List<NatureOfCaseEntity> GetListNatureOfCaseEntityByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<NatureOfCase>()
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            List<NatureOfCase> listNatureOfCase = GetFromDetachedCriteria<NatureOfCase>(detachedCriteria);
            if (listNatureOfCase != null && listNatureOfCase.Count > 0)
            {
                return listNatureOfCase.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetNatureOfCaseEntity(natureOfCase)).ToList();
            }
            else
                return null;
        }

        internal List<NatureOfCaseEntity> GetListNatureOfCaseEntityBySGID(string SGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(NatureOfCase))
                                                                .Add(Expression.Eq("SubmissionGroupId", SGID));
            List<NatureOfCase> listNatureOfCase = GetFromDetachedCriteria<NatureOfCase>(detachedCriteria);
            if (listNatureOfCase != null && listNatureOfCase.Count > 0)
            {
                return listNatureOfCase.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetNatureOfCaseEntity(natureOfCase)).ToList();
            }
            else
                return null;
        }

        internal List<NotPaymenttoCourtDocDetailEntity> GetListNotPaymenttoCourtyDocDetailBySGId(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(NotPaymentToCourtDocDetail))
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<NotPaymentToCourtDocDetail> listNotPaymentToCourtDocDetail = GetAllNotPaymentToCourtDocDetail(detachedCriteria);

            if (listNotPaymentToCourtDocDetail != null && listNotPaymentToCourtDocDetail.Count > 0)
            {
                return listNotPaymentToCourtDocDetail.Select(notPaymentToCourtDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetNotPaymenttoCourtDocDetailEntity(notPaymentToCourtDocDetail)).ToList();
            }
            else
                return null;
        }

        internal List<OrdersMadeEntity> GetListOrdersMadeByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<OrdersMade>()
                 .Add(Expression.Eq("DocId", docId));
            List<OrdersMade> listOrdersMade = GetFromDetachedCriteria<OrdersMade>(detachedCriteria);
            if (listOrdersMade != null && listOrdersMade.Count > 0)
            {
                return listOrdersMade.Select(ordersMade => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetOrdersMadeEntity(ordersMade)).ToList();
            }
            else
            {
                return null;
            }
        }

        //internal List<NoOfSupportingDocEntity> GetListNoOfSupportingDocEntityBySGID(string submissionGroupId)
        //{
        //    List<NoOfSupportingDocEntity> listNoOfSupportingDocEntity = new List<NoOfSupportingDocEntity>();
        //    NoOfSupportingDocEntity noOfSupportingDocEntity = new NoOfSupportingDocEntity();
        //    DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(NoOfSupportingDoc))
        //                                                        .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
        //    IRepository<NoOfSupportingDoc> noOfSupportingDocRepository = new RepositoryImpl<NoOfSupportingDoc>(applicationSession);
        //    List<NoOfSupportingDoc> listNoOfSupportingDoc = noOfSupportingDocRepository.GetAll(detachedCriteria) as List<NoOfSupportingDoc>;
        //    if (listNoOfSupportingDoc != null && listNoOfSupportingDoc.Count > 0)
        //    {
        //        foreach (NoOfSupportingDoc noOfSupportingDoc in listNoOfSupportingDoc)
        //        {
        //            noOfSupportingDocEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetNoOfSupportingDocEntity(noOfSupportingDoc);
        //            listNoOfSupportingDocEntity.Add(noOfSupportingDocEntity);
        //        }
        //    }
        //    else listNoOfSupportingDocEntity = null;
        //    return listNoOfSupportingDocEntity;
        //}
        internal List<OriginatingCaseEntity> GetListOriginatingCaseEntity(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(OriginatingCase))
                                                                              .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<OriginatingCase> listOriginatingCase = GetOriginatingCase(detachedCriteria);

            if (listOriginatingCase != null && listOriginatingCase.Count > 0)
            {
                return listOriginatingCase.Select(caseOriginatingCase => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetOriginatingCaseEntity(caseOriginatingCase)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<OriginatingCaseEntity> GetListOriginatingCaseEntityByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(OriginatingCase))
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            List<OriginatingCase> listOriginatingCase = GetFromDetachedCriteria<OriginatingCase>(detachedCriteria);
            if (listOriginatingCase != null && listOriginatingCase.Count > 0)
            {
                return listOriginatingCase.Select(originatingCase => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetOriginatingCaseEntity(originatingCase)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<OtherITMOEntity> GetListOtherITMOEntityBySGID(string SGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(OtherITMO))
                                                                .Add(Expression.Eq("SubmissionGroupId", SGID));
            List<OtherITMO> listOtherITMO = GetFromDetachedCriteria<OtherITMO>(detachedCriteria);
            if (listOtherITMO != null && listOtherITMO.Count > 0)
            {
                return listOtherITMO.Select(otherITMO => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetOtherITMOEntity(otherITMO)).ToList();
            }
            else
                return null;
        }

        internal List<OtherReliefsClaimEntity> GetListOtherReliefsClaimEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(OtherReliefsClaim))
                   .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<OtherReliefsClaim> listOtherReliefsClaim = GetFromDetachedCriteria<OtherReliefsClaim>(detachedCriteria);

            if (listOtherReliefsClaim != null && listOtherReliefsClaim.Count > 0)
            {
                return listOtherReliefsClaim.Select(otherReliefsClaim => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetOtherReliefsClaimEntity(otherReliefsClaim)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<OutgoingCorrespondenceCourtFeeEntity> GetListOutgoingCorrespondenceCourtFeeEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<OutgoingCorrespondenceCourtFee>()
                 .Add(Expression.Eq("SubmissionGroupId", sGID));
            List<OutgoingCorrespondenceCourtFee> listOutgoingCorrespondenceCourtFee = GetFromDetachedCriteria<OutgoingCorrespondenceCourtFee>(detachedCriteria);
            if (listOutgoingCorrespondenceCourtFee != null && listOutgoingCorrespondenceCourtFee.Count > 0)
            {
                return listOutgoingCorrespondenceCourtFee.Select(outgoingCorrespondenceCourtFee => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetOutgoingCorrespondenceCourtFeeEntity(outgoingCorrespondenceCourtFee)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<OutgoingCorrespondenceInfoEntity> GetListOutgoingCorrespondenceInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<OutgoingCorrespondenceInfo>()
                .Add(Expression.Eq("SubmissionGroupId", sGID));
            List<OutgoingCorrespondenceInfo> listOutgoingCorrespondenceInfo = GetFromDetachedCriteria<OutgoingCorrespondenceInfo>(detachedCriteria);
            if (listOutgoingCorrespondenceInfo != null && listOutgoingCorrespondenceInfo.Count > 0)
            {
                return listOutgoingCorrespondenceInfo.Select(outgoingCorrespondenceInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetOutgoingCorrespondenceInfoEntity(outgoingCorrespondenceInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<PCConditionInfoEntity> GetListPCConditionBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PCConditionInfo))
                                                              .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<PCConditionInfo> listPCConditionInfo = GetAllPCConditionInfo(detachedCriteria);
            if (listPCConditionInfo != null && listPCConditionInfo.Count > 0)
            {
                return listPCConditionInfo.Select(pCConditionInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetPCConditionInfoEntity(pCConditionInfo)).ToList();
            }
            else
                return null;
        }

        internal List<PrayerEntity> GetListPrayerEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(Prayer))
                                                               .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<Prayer> listPrayer = GetPrayers(detachedCriteria);
            if (listPrayer != null && listPrayer.Count > 0)
            {
                return listPrayer.Select(prayer => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetPrayerEntity(prayer)).ToList();
            }
            else
                return null;
        }

        internal List<RefCaveatCaseEntity> GetListRefCaveatCaseEntityBySGID(string SGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RefCaveatCase))
                                                                 .Add(Expression.Eq("SubmissionGroupId", SGID));
            List<RefCaveatCase> listRefCaveatCase = GetRefCaveatCase(detachedCriteria);
            if (listRefCaveatCase != null && listRefCaveatCase.Count > 0)
            {
                return listRefCaveatCase.Select(refCaveatCase => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRefCaveatCaseEntity(refCaveatCase)).ToList();
            }
            else
                return null;
        }

        internal List<RefOrderDetailEntity> GetListRefOrderDetailEntityBySGID(string SGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RefOrderDetail))
                                                             .Add(Expression.Eq("SubmissionGroupId", SGID));
            List<RefOrderDetail> listRefOrderDetail = GetRefOrderDetail(detachedCriteria);
            if (listRefOrderDetail != null && listRefOrderDetail.Count > 0)
            {
                List<RefOrderDetailEntity> listRefOrderDetailEntity = listRefOrderDetail.Select(refOrderDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRefOrderDetailEntity(refOrderDetail)).ToList();
                return listRefOrderDetailEntity;
            }
            else
                return null;
        }

        internal List<RefOrderJOInfoEntity> GetListRefOrderJOInfoEntityBySGID(string SGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RefOrderJOInfo))
                                                             .Add(Expression.Eq("SubmissionGroupID", SGID));
            List<RefOrderJOInfo> listRefOrderJOInfo = GetRefOrderJOInfo(detachedCriteria);
            if (listRefOrderJOInfo != null && listRefOrderJOInfo.Count > 0)
            {
                return listRefOrderJOInfo.Select(refOrderJOInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRefOrderJOInfoEntity(refOrderJOInfo)).ToList();
            }
            else
                return null;
        }

        internal List<RefSubCaseEntity> GetListRefSubCaseEntityBySGID(string SGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RefSubCase))
                                                             .Add(Expression.Eq("SubmissionGroupId", SGID));
            List<RefSubCase> listRefSubCase = GetRefSubCase(detachedCriteria);
            if (listRefSubCase != null && listRefSubCase.Count > 0)
            {
                List<RefSubCaseEntity> listRefSubCaseEntity = listRefSubCase.Select(refSubCase => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRefSubCaseEntity(refSubCase)).ToList();
                return listRefSubCaseEntity;
            }
            else
                return null;
        }

        internal List<RelatedProceedingEntity> GetListRelatedProceedingBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RelatedProceeding))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<RelatedProceeding> listRelatedProceeding = GetFromDetachedCriteria<RelatedProceeding>(detachedCriteria);
            if (listRelatedProceeding != null && listRelatedProceeding.Count > 0)
            {
                return listRelatedProceeding.Select(relatedProceeding => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRelatedProceedingEntity(relatedProceeding)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the list submission info entity.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        internal List<SubmissionInfoEntity> GetListSubmissionInfoEntity(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SubmissionInfo))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<SubmissionInfo> listSubmissionInfo = GetFromDetachedCriteria<SubmissionInfo>(detachedCriteria);
            if (listSubmissionInfo != null && listSubmissionInfo.Count > 0)
            {
                return listSubmissionInfo.Select(submissionInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetSubmissionInfoEntity(submissionInfo)).ToList();
            }
            else
                return null;
        }

        internal List<TravelPassInfoEntity> GetListTravelPassInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(TravelPassInfo))
                                                              .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<TravelPassInfo> listTravelPassInfo = GetAllTravelPassInfo(detachedCriteria);
            if (listTravelPassInfo != null && listTravelPassInfo.Count > 0)
            {
                return listTravelPassInfo.Select(travelPassInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetTravelPassInfoEntity(travelPassInfo)).ToList();
            }
            else
                return null;
        }

        internal List<UnliquidatedClaimEntity> GetListUnLiquidatedClaimEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(UnliquidatedClaim))
                    .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<UnliquidatedClaim> listUnliquidatedClaim = GetFromDetachedCriteria<UnliquidatedClaim>(detachedCriteria);

            if (listUnliquidatedClaim != null && listUnliquidatedClaim.Count > 0)
            {
                return listUnliquidatedClaim.Select(unliquidatedClaim => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetUnliquidatedClaimEntity(unliquidatedClaim)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<VacHRGDatesReqInfoEntity> GetListVacHRGDatesReqInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(VacHRGDatesReqInfo))
                                                                            .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<VacHRGDatesReqInfo> listVacHRGDatesReqInfo = GetVacHRGDatesReqInfo(detachedCriteria);

            if (listVacHRGDatesReqInfo != null && listVacHRGDatesReqInfo.Count > 0)
            {
                return listVacHRGDatesReqInfo.Select(vacHRGDatesReqInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetVacHRGDatesReqInfoEntity(vacHRGDatesReqInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<WOEExecutionAddressEntity> GetListWOEExecutionAddressBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WOEExecutionAddress))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<WOEExecutionAddress> listWOEExecutionAddress = GetAllWOEExecutionAddress(detachedCriteria);

            if (listWOEExecutionAddress != null && listWOEExecutionAddress.Count > 0)
            {
                return listWOEExecutionAddress.Select(woeExecutionAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetWOEExecutionAddressEntity(woeExecutionAddress)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal MinuteSheetInfoEntity GetMinuteSheetInfoEntityByHrgId(string HrgId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MinuteSheetInfo))
               .Add(Expression.Eq("HRGID", Convert.ToInt64(HrgId)));

            List<MinuteSheetInfo> listMinuteSheetInfo = GetFromDetachedCriteria<MinuteSheetInfo>(detachedCriteria);
            MinuteSheetInfoEntity minuteSheetInfoEntity = new MinuteSheetInfoEntity();

            if (listMinuteSheetInfo != null && listMinuteSheetInfo.Count > 0)
            {
                foreach (MinuteSheetInfo minuteSheetInfo in listMinuteSheetInfo)
                {
                    minuteSheetInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetMinuteSheetInfoEntity(minuteSheetInfo);
                }
            }
            else
                minuteSheetInfoEntity = null;

            return minuteSheetInfoEntity;
        }

        internal List<NatureOfApplicationEntity> GetNatureOfApplication<V>(string fieldName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(NatureOfApplication))
                .Add(Expression.Eq(fieldName, value));
            List<NatureOfApplication> listNatureOfApplication = GetFromDetachedCriteria<NatureOfApplication>(detachedCriteria);
            if (listNatureOfApplication != null && listNatureOfApplication.Count > 0)
            {
                return listNatureOfApplication.Select(natureOfApplication => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetNatureOfApplicationEntity(natureOfApplication)).ToList();
            }
            else
                return null;
        }

        internal OriginatingCaseEntity GetOriginatingCaseBySGID(string SGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(OriginatingCase))
                                                            .Add(Expression.Eq("SubmissionGroupId", SGID));
            OriginatingCaseEntity originatingCaseEntity = new OriginatingCaseEntity();
            OriginatingCase originatingCase = new OriginatingCase();

            IRepository<OriginatingCase> originatingCaseRepository = new RepositoryImpl<OriginatingCase>(applicationSession);

            List<OriginatingCase> listOriginatingCase = originatingCaseRepository.GetAll(detachedCriteria) as List<OriginatingCase>;
            if (listOriginatingCase != null && listOriginatingCase.Count > 0)
            {
                foreach (OriginatingCase orgCase in listOriginatingCase)
                {
                    originatingCase = orgCase;
                    originatingCaseEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetOriginatingCaseEntity(orgCase);
                }
            }
            else
                originatingCaseEntity = null;
            return originatingCaseEntity;
        }

        internal PaymentHRGDatesDocDetailEntity GetPaymentHRGDatesDocDetailEntity(string submissionGroupId)
        {
            PaymentHRGDatesDocDetailEntity paymentHRGDatesDocDetailEntity = new PaymentHRGDatesDocDetailEntity();

            IRepository<PaymentHRGDatesDocDetail> paymentHRGDatesDocDetailRepository = new RepositoryImpl<PaymentHRGDatesDocDetail>(applicationSession);

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PaymentHRGDatesDocDetail))
                                                               .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<PaymentHRGDatesDocDetail> listPaymentHRGDatesDocDetail = paymentHRGDatesDocDetailRepository.GetAll(detachedCriteria) as List<PaymentHRGDatesDocDetail>;
            if (listPaymentHRGDatesDocDetail != null && listPaymentHRGDatesDocDetail.Count > 0)
            {
                foreach (PaymentHRGDatesDocDetail paymentHRGDatesDocDetail in listPaymentHRGDatesDocDetail)
                {
                    paymentHRGDatesDocDetailEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetPaymentHRGDatesDocDetailEntity(paymentHRGDatesDocDetail);
                }
            }
            else
                paymentHRGDatesDocDetailEntity = null;
            return paymentHRGDatesDocDetailEntity;
        }

        internal RefOrderDetailEntity GetRefOrderDetailEntity(string refOrderDetailId)
        {
            IRepository<RefOrderDetail> refOrderDetailRepository = new RepositoryImpl<RefOrderDetail>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRefOrderDetailEntity(refOrderDetailRepository.Get(refOrderDetailId));
        }

        /*
        internal List<QualificationInfoEntity> GetListQualificationInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(QualificationInfo))
                                                               .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<QualificationInfo> listQualificationInfo = GetAllQualificationInfo(detachedCriteria);
            if (listQualificationInfo != null && listQualificationInfo.Count > 0)
            {
                return listQualificationInfo.Select(qualificationInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetQualificationInfoEntity(qualificationInfo)).ToList();
            }
            else
                return null;
        }*/
        internal RefOrderDetailEntity GetRefOrderDetailEntityBySGID(string SGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RefOrderDetail))
                                                              .Add(Expression.Eq("SubmissionGroupId", SGID));
            List<RefOrderDetail> listRefOrderDetail = GetFromDetachedCriteria<RefOrderDetail>(detachedCriteria);
            if (listRefOrderDetail != null && listRefOrderDetail.Count > 0)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRefOrderDetailEntity(listRefOrderDetail[0]);
            }
            else
            {
                return null;
            }
        }

        internal SolicitorEntity GetSolicitorEntityByPK(long solicitorId)
        {
            IRepository<Solicitor> solicitorRepository = new RepositoryImpl<Solicitor>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetSolicitorEntity(solicitorRepository.Get(solicitorId));
        }

        internal void SaveOrUpdateADData(ISubCaseTypeInfo subCaseTypeInfo)
        {
            ADData aDData = subCaseTypeInfo as ADData;
            if (aDData.PaymentHRGDatesDocDetailEntity != null)
            {
                SaveOrUpdatePaymentHRGDatesDocDetailEntity(aDData.PaymentHRGDatesDocDetailEntity);
            }
            if (aDData.RefOrderDetailEntity != null && aDData.RefOrderDetailEntity.Count > 0)
            {
                foreach (RefOrderDetailEntity refOrderDetailEntity in aDData.RefOrderDetailEntity)
                {
                    SaveOrUpdateRefOrderDetailEntity(refOrderDetailEntity);
                }
            }
        }

        internal void SaveOrUpdateAdmiraltyData(AdmiraltyData admiraltyData)
        {
            SaveOrUpdateLiquidatedClaimList(admiraltyData.LiquidatedClaimEntityList);
            SaveOrUpdateNatureOfCaseList(admiraltyData.NatureOfCaseEntityList);
            //SaveOrUpdateNoOfSupportingDocList(admiraltyData.ListNoOfSupportingDocEntity);
            SaveOrUpdateOtherReliefClaimsList(admiraltyData.OtherReliefsClaimEntityList);
            SaveOrUpdateRefCaveatCaseList(admiraltyData.RefCaveatCaseEntityList);
            SaveOrUpdateUnLiquidatedClaimList(admiraltyData.UnliquidatedClaimEntityList);
        }

        internal void SaveOrUpdateAffidavitDeponentDetailEntity(AffidavitDeponentDetailEntity affidavitDeponentDetailEntity)
        {
            IRepository<AffidavitDeponentDetail> affidavitDeponentDetailRepository = new RepositoryImpl<AffidavitDeponentDetail>(applicationSession);
            affidavitDeponentDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetAffidavitDeponentDetail(affidavitDeponentDetailEntity));
        }

        internal void SaveOrUpdateAffidavitInfoEntity(AffidavitInfoEntity affidavitInfoEntity)
        {
            IRepository<AffidavitInfo> affidavitInfoRepository = new RepositoryImpl<AffidavitInfo>(applicationSession);
            affidavitInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetAffidavitInfo(affidavitInfoEntity));
        }

        internal void SaveOrUpdateChecklistInstanceEntity(ChecklistInstanceEntity checklistInstanceEntity)
        {
            IRepository<CheckListInstance> checklistInstanceRepository = new RepositoryImpl<CheckListInstance>(applicationSession);
            checklistInstanceRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetChecklistInstance(checklistInstanceEntity));
        }

        internal void SaveOrUpdateChecklistSubmissionEntity(ChecklistSubmissionEntity checklistSubmissionEntity)
        {
            IRepository<CheckListSubmission> originatingChecklistSubmission = new RepositoryImpl<CheckListSubmission>(applicationSession);
            originatingChecklistSubmission.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetChecklistSubmission(checklistSubmissionEntity));
        }

        internal void SaveOrUpdateCopyOriginatingCaseEntity(OriginatingCaseEntity originatingCaseEntity)
        {
            IRepository<OriginatingCase> originatingCaseRepository = new RepositoryImpl<OriginatingCase>(applicationSession);
            originatingCaseRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOriginatingCase(originatingCaseEntity));
        }

        internal void SaveOrUpdateCopyRefOrderDetailEntity(RefOrderDetailEntity refOrderDetailEntity)
        {
            IRepository<RefOrderDetail> refOrderDetailRepository = new RepositoryImpl<RefOrderDetail>(applicationSession);
            refOrderDetailRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetailEntity));
        }

        internal void SaveOrUpdateCWUData(CWUData cWUData)
        {
            CWUGateway gateway = new CWUGateway();
            gateway.SaveOrUpdateCWUInfoEntity(cWUData.CWUInfoEntity);
            SaveOrUpdateLegislationProvisionsList(cWUData.LegislationProvisionsEntityList);
            SaveOrUpdateLiquidatorList(cWUData.LiquidatorEntityList);
            SaveOrUpdateNatureOfCaseList(cWUData.NatureOfCaseEntityList);
            SaveOrUpdateOtherITMOList(cWUData.OtherITMOEntityList);
        }

        /// <summary>
        /// Saves the or update divorce info entity.
        /// </summary>
        /// <param name="divorceInfoEntity">The divorce info entity.</param>
        internal void SaveOrUpdateDivorceInfoEntity(DivorceInfoEntity divorceInfoEntity)
        {
            IRepository<DivorceInfo> divorceInfoRepository = new RepositoryImpl<DivorceInfo>(applicationSession);
            divorceInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDivorceInfo(divorceInfoEntity));
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

        internal void SaveOrUpdateLegislationProvisionsEntity(LegislationProvisionsEntity legislationProvisionsEntity)
        {
            IRepository<LegislationProvision> legislationProvisionRepository = new RepositoryImpl<LegislationProvision>(applicationSession);
            legislationProvisionRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegislationProvision(legislationProvisionsEntity));
        }

        internal void SaveOrUpdateLegislationProvisionsList(List<LegislationProvisionsEntity> listLegislationProvisionsEntity)
        {
            if (listLegislationProvisionsEntity != null && listLegislationProvisionsEntity.Count > 0)
            {
                foreach (LegislationProvisionsEntity legislationProvisionsEntity in listLegislationProvisionsEntity)
                {
                    SaveOrUpdateLegislationProvisionsEntity(legislationProvisionsEntity);
                }
            }
        }

        internal void SaveOrUpdateLiquidatedClaimEntity(LiquidatedClaimEntity liquidatedClaimEntity)
        {
            IRepository<LiquidatedClaim> liquidatedClaimRepository = new RepositoryImpl<LiquidatedClaim>(applicationSession);
            liquidatedClaimRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLiquidatedClaim(liquidatedClaimEntity));
        }

        internal void SaveOrUpdateLiquidatorAddressEntity(LiquidatorAddressEntity liquidatorAddressEntity)
        {
            IRepository<LiquidatorAddress> liquidatorAddressRepository = new RepositoryImpl<LiquidatorAddress>(applicationSession);
            liquidatorAddressRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLiquidatorAddress(liquidatorAddressEntity));
        }

        internal void SaveOrUpdateLiquidatorAliasEntity(LiquidatorAliasEntity liquidatorAliasEntity)
        {
            IRepository<LiquidatorAlias> liquidatorAliasRepository = new RepositoryImpl<LiquidatorAlias>(applicationSession);
            liquidatorAliasRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLiquidatorAlias(liquidatorAliasEntity));
        }

        internal void SaveOrUpdateLiquidatorEntity(LiquidatorEntity liquidatorEntity)
        {
            IRepository<Liquidator> liquidatorRepository = new RepositoryImpl<Liquidator>(applicationSession);
            liquidatorRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLiquidator(liquidatorEntity));
        }

        internal void SaveOrUpdateLiquidatorPICAddressEntity(LiquidatorPICAddressEntity liquidatorPICAddressEntity)
        {
            IRepository<LiquidatorPICAddress> liquidatorPICAddressRepository = new RepositoryImpl<LiquidatorPICAddress>(applicationSession);
            liquidatorPICAddressRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLiquidatorPICAddress(liquidatorPICAddressEntity));
        }

        internal void SaveOrUpdateLiquidatorPICAliasEntity(LiquidatorPICAliasEntity liquidatorPICAliasEntity)
        {
            IRepository<LiquidatorPICAlias> liquidatorPICAliasRepository = new RepositoryImpl<LiquidatorPICAlias>(applicationSession);
            liquidatorPICAliasRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLiquidatorPICAlias(liquidatorPICAliasEntity));
        }

        internal void SaveOrUpdateLiquidatorPICEntity(LiquidatorPICEntity liquidatorPICEntity)
        {
            IRepository<LiquidatorPIC> liquidatorPICRepository = new RepositoryImpl<LiquidatorPIC>(applicationSession);
            liquidatorPICRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLiquidatorPIC(liquidatorPICEntity));
        }

        internal void SaveOrUpdateNatureOfCaseEntity(NatureOfCaseEntity natureOfCaseEntity)
        {
            IRepository<NatureOfCase> natureOfCaseRepository = new RepositoryImpl<NatureOfCase>(applicationSession);
            natureOfCaseRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCaseEntity(natureOfCaseEntity));
        }

        internal void SaveOrUpdateNatureOfCaseList(List<NatureOfCaseEntity> listNatureOfCase)
        {
            if (listNatureOfCase != null && listNatureOfCase.Count > 0)
            {
                foreach (NatureOfCaseEntity natureOfCaseEntity in listNatureOfCase)
                {
                    SaveOrUpdateNatureOfCaseEntity(natureOfCaseEntity);
                }
            }
        }

        //internal void SaveOrUpdateNoOfSupportingDocEntity(NoOfSupportingDocEntity noOfSupportingDocEntity)
        //{
        //    IRepository<NoOfSupportingDoc> noOfSupportingDocRepository = new RepositoryImpl<NoOfSupportingDoc>(applicationSession);
        //    noOfSupportingDocRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNoOfSupportingDoc(noOfSupportingDocEntity));
        //}
        internal void SaveorUpdateOriginatingCaseEntity(OriginatingCaseEntity originatingCaseEntity)
        {
            IRepository<OriginatingCase> originatingCaseRepository = new RepositoryImpl<OriginatingCase>(applicationSession);
            originatingCaseRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOriginatingCase(originatingCaseEntity));
        }

        internal void SaveOrUpdateOtherITMOEntity(OtherITMOEntity otherITMOEntity)
        {
            IRepository<OtherITMO> otherITMORepository = new RepositoryImpl<OtherITMO>(applicationSession);
            otherITMORepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherITMO(otherITMOEntity));
        }

        internal void SaveOrUpdateOtherReliefsClaim(OtherReliefsClaimEntity otherReliefsClaimEntity)
        {
            IRepository<OtherReliefsClaim> otherReliefsClaimRepository = new RepositoryImpl<OtherReliefsClaim>(applicationSession);
            otherReliefsClaimRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherReliefsClaimEntityEntity(otherReliefsClaimEntity));
        }

        internal void SaveOrUpdatePaymentHRGDatesDocDetailEntity(PaymentHRGDatesDocDetailEntity paymentHRGDatesDocDetailEntity)
        {
            IRepository<PaymentHRGDatesDocDetail> paymentHRGDatesDocDetailRepository = new RepositoryImpl<PaymentHRGDatesDocDetail>(applicationSession);
            paymentHRGDatesDocDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubsequentMapper.GetPaymentHRGDatesDocDetail(paymentHRGDatesDocDetailEntity));
        }

        internal void SaveOrUpdateRefOrderDetailEntity(RefOrderDetailEntity refOrderDetailEntity)
        {
            IRepository<RefOrderDetail> refOrderDetailRepository = new RepositoryImpl<RefOrderDetail>(applicationSession);
            refOrderDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetailEntity));
        }

        internal void SaveOrUpdateRefOrderDetailList(List<RefOrderDetailEntity> listRefOrderDetailEntity)
        {
            if (listRefOrderDetailEntity != null && listRefOrderDetailEntity.Count > 0)
            {
                foreach (RefOrderDetailEntity refOrderDetailEntity in listRefOrderDetailEntity)
                {
                    SaveOrUpdateRefOrderDetailEntity(refOrderDetailEntity);
                }
            }
        }

        internal void SaveOrUpdateUnliquidatedClaim(UnliquidatedClaimEntity unLiquidatedClaimEntity)
        {
            IRepository<UnliquidatedClaim> unliquidatedClaimRepository = new RepositoryImpl<UnliquidatedClaim>(applicationSession);
            unliquidatedClaimRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetUnliquidatedClaim(unLiquidatedClaimEntity));
        }

        private List<CheckListSubmission> GetAllCheckListSubmission(DetachedCriteria detachedCriteria)
        {
            IRepository<CheckListSubmission> checkListSubmissionRepository = new RepositoryImpl<CheckListSubmission>(applicationSession);
            return checkListSubmissionRepository.GetAll(detachedCriteria).ToList();
        }

        private List<EmploymentInfo> GetAllEmploymentInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<EmploymentInfo> employmentInfoRepository = new RepositoryImpl<EmploymentInfo>(applicationSession);
            return employmentInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<NotPaymentToCourtDocDetail> GetAllNotPaymentToCourtDocDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<NotPaymentToCourtDocDetail> notPaymentToCourtDocDetailRepository = new RepositoryImpl<NotPaymentToCourtDocDetail>(applicationSession);
            return notPaymentToCourtDocDetailRepository.GetAll(detachedCriteria).ToList();
        }

        private List<PCConditionInfo> GetAllPCConditionInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<PCConditionInfo> pCConditionInfoRepository = new RepositoryImpl<PCConditionInfo>(applicationSession);
            return pCConditionInfoRepository.GetAll(detachedCriteria).ToList();
        }

        /*
                private List<QualificationInfo> GetAllQualificationInfo(DetachedCriteria detachedCriteria)
                {
                    IRepository<QualificationInfo> qualificationInfoRepository = new RepositoryImpl<QualificationInfo>(applicationSession);
                    return qualificationInfoRepository.GetAll(detachedCriteria).ToList();
                }*/
        private List<TravelPassInfo> GetAllTravelPassInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<TravelPassInfo> travelPassInfoRepository = new RepositoryImpl<TravelPassInfo>(applicationSession);
            return travelPassInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<WOEExecutionAddress> GetAllWOEExecutionAddress(DetachedCriteria detachedCriteria)
        {
            IRepository<WOEExecutionAddress> woeExecutionRepository = new RepositoryImpl<WOEExecutionAddress>(applicationSession);
            return woeExecutionRepository.GetAll(detachedCriteria).ToList();
        }

        private List<CDRInfo> GetCDRInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<CDRInfo> cDRInfoRepository = new RepositoryImpl<CDRInfo>(applicationSession);
            return cDRInfoRepository.GetAll(detachedCriteria) as List<CDRInfo>;
        }

        private List<T> GetFromDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll(detachedCriteria).ToList();
        }

        private LegislationProvision GetLegislationProvisions(Criteria criteria)
        {
            IRepository<LegislationProvision> legislationProvisionRepository = new RepositoryImpl<LegislationProvision>(applicationSession);
            return legislationProvisionRepository.Get(criteria.Value);
        }

        private List<NatureOfApplication> GetNatureOfApplication(DetachedCriteria detachedCriteria)
        {
            IRepository<NatureOfApplication> natureOfApplicationRepository = new RepositoryImpl<NatureOfApplication>(applicationSession);
            return natureOfApplicationRepository.GetAll(detachedCriteria).ToList();
        }

        private List<OriginatingCase> GetOriginatingCase(DetachedCriteria detachedCriteria)
        {
            IRepository<OriginatingCase> originatingCaseRepository = new RepositoryImpl<OriginatingCase>(applicationSession);
            return originatingCaseRepository.GetAll(detachedCriteria) as List<OriginatingCase>;
        }

        private List<Prayer> GetPrayers(DetachedCriteria detachedCriteria)
        {
            IRepository<Prayer> prayerRepository = new RepositoryImpl<Prayer>(applicationSession);
            return prayerRepository.GetAll(detachedCriteria).ToList();
        }

        private List<RefCaveatCase> GetRefCaveatCase(DetachedCriteria detachedCriteria)
        {
            IRepository<RefCaveatCase> refCaveatCaseRepository = new RepositoryImpl<RefCaveatCase>(applicationSession);
            return refCaveatCaseRepository.GetAll(detachedCriteria) as List<RefCaveatCase>;
        }

        private List<RefOrderDetail> GetRefOrderDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<RefOrderDetail> refOrderDetailRepository = new RepositoryImpl<RefOrderDetail>(applicationSession);
            return refOrderDetailRepository.GetAll(detachedCriteria).ToList();
        }

        private List<RefOrderJOInfo> GetRefOrderJOInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<RefOrderJOInfo> refOrderJOInfoRepository = new RepositoryImpl<RefOrderJOInfo>(applicationSession);
            return refOrderJOInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<RefSubCase> GetRefSubCase(DetachedCriteria detachedCriteria)
        {
            IRepository<RefSubCase> refSubCaseRepository = new RepositoryImpl<RefSubCase>(applicationSession);
            return refSubCaseRepository.GetAll(detachedCriteria).ToList();
        }

        private List<VacHRGDatesReqInfo> GetVacHRGDatesReqInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<VacHRGDatesReqInfo> vacHRGDatesReqInfoRepository = new RepositoryImpl<VacHRGDatesReqInfo>(applicationSession);
            return vacHRGDatesReqInfoRepository.GetAll(detachedCriteria) as List<VacHRGDatesReqInfo>;
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

        private void SaveOrUpdateLiquidatedClaimList(List<LiquidatedClaimEntity> listLiquidatedClaim)
        {
            if (listLiquidatedClaim != null && listLiquidatedClaim.Count > 0)
            {
                foreach (LiquidatedClaimEntity liquidatedClaimEntity in listLiquidatedClaim)
                {
                    SaveOrUpdateLiquidatedClaimEntity(liquidatedClaimEntity);
                }
            }
        }

        private void SaveOrUpdateLiquidatorList(List<LiquidatorEntity> listLiquidatorEntity)
        {
            if (listLiquidatorEntity != null && listLiquidatorEntity.Count > 0)
            {
                foreach (LiquidatorEntity liquidatorEntity in listLiquidatorEntity)
                {
                    SaveOrUpdateLiquidatorEntity(liquidatorEntity);
                }
            }
        }

        //private void SaveOrUpdateNoOfSupportingDocList(List<NoOfSupportingDocEntity> listNoOfSupportingDoc)
        //{
        //    if (listNoOfSupportingDoc != null && listNoOfSupportingDoc.Count > 0)
        //    {
        //        foreach (NoOfSupportingDocEntity noOfSupportingDocEntity in listNoOfSupportingDoc)
        //        {
        //            SaveOrUpdateNoOfSupportingDocEntity(noOfSupportingDocEntity);
        //        }
        //    }
        //}
        private void SaveOrUpdateOtherReliefClaimsList(List<OtherReliefsClaimEntity> listOtherReliefsClaim)
        {
            if (listOtherReliefsClaim != null && listOtherReliefsClaim.Count > 0)
            {
                foreach (OtherReliefsClaimEntity otherReliefsClaimEntity in listOtherReliefsClaim)
                {
                    SaveOrUpdateOtherReliefsClaim(otherReliefsClaimEntity);
                }
            }
        }

        private void SaveOrUpdateRefCaveatCaseList(List<RefCaveatCaseEntity> listRefCaveatCase)
        {
            AdmiralityGateway admiralityGateway = new AdmiralityGateway();
            if (listRefCaveatCase != null && listRefCaveatCase.Count > 0)
            {
                foreach (RefCaveatCaseEntity refCaveatCaseEntity in listRefCaveatCase)
                {
                    admiralityGateway.SaveOrUpdateRefCaveatCaseEntity(refCaveatCaseEntity);
                }
            }
        }

        private void SaveOrUpdateUnLiquidatedClaimList(List<UnliquidatedClaimEntity> listUnliquidatedClaim)
        {
            if (listUnliquidatedClaim != null && listUnliquidatedClaim.Count > 0)
            {
                foreach (UnliquidatedClaimEntity unLiquidatedClaimEntity in listUnliquidatedClaim)
                {
                    SaveOrUpdateUnliquidatedClaim(unLiquidatedClaimEntity);
                }
            }
        }


        internal List<WOECaseExecutionAddressEntity> GetListWOECaseExecutionAddress(long caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<WOECaseExecutionAddress>()
                .Add(Expression.Eq("CaseInfoId", caseInfoId));

            List<WOECaseExecutionAddress> listWOECaseExecutionAddress = GetFromDetachedCriteria<WOECaseExecutionAddress>(detachedCriteria);
            if (listWOECaseExecutionAddress != null && listWOECaseExecutionAddress.Count > 0)
            {
                return listWOECaseExecutionAddress.Select(wOECaseExecutionAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetWOECaseExecutionAddressEntity(wOECaseExecutionAddress)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<WOECaseExecutionAddressEntity> GetListWOECaseExecutionAddress(long caseInfoId, long? subcaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<WOECaseExecutionAddress>()
                .Add(Expression.Eq("CaseInfoId", caseInfoId))
                .Add(Expression.Eq("SubCaseInfoId", subcaseInfoId));

            List<WOECaseExecutionAddress> listWOECaseExecutionAddress = GetFromDetachedCriteria<WOECaseExecutionAddress>(detachedCriteria);
            if (listWOECaseExecutionAddress != null && listWOECaseExecutionAddress.Count > 0)
            {
                return listWOECaseExecutionAddress.Select(wOECaseExecutionAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetWOECaseExecutionAddressEntity(wOECaseExecutionAddress)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<AppealTimeEstimationDetailEntity> GetListAppealTimeEstimationDetailBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<AppealTimeEstimationDetail>()
                 .Add(Expression.Eq("SubmissionGroupId", sGID));

            List<AppealTimeEstimationDetail> listAppealTimeEstimationDetail = GetFromDetachedCriteria<AppealTimeEstimationDetail>(detachedCriteria);

            if (listAppealTimeEstimationDetail != null && listAppealTimeEstimationDetail.Count > 0)
            {
                return listAppealTimeEstimationDetail.Select(appealTimeEstimationDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetAppealTimeEstimationDetailEntity(appealTimeEstimationDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Promotes the refer affidavit BE.
        /// </summary>
        /// <param name="referAffidavitDocID">The refer affidavit doc ID.</param>
        /// <param name="WOSNUO_DocID">The WOSNU o_ doc ID.</param>
        /// <param name="promotedDocID">The promoted doc ID.</param>
        /// <param name="isSameForum">The is same forum.</param>
        internal void PromoteReferAffidavitBE(string referAffidavitDocID, string WOSNUO_DocID, string promotedDocID, string isSameForum)
        {
            applicationSession.GetNamedQuery("ProcedureForPromotingBEAffidavit")
                 .SetParameter("ReferAffidavitDocID", referAffidavitDocID)
                    .SetParameter("DocID", WOSNUO_DocID)
                    .SetParameter("PromotedDocID", promotedDocID)
                    .SetParameter("IsSameForum", isSameForum)
                    .ExecuteUpdate();
        }


        /// <summary>
        /// Gets the list notice to refer affidavit entity by SGID.
        /// </summary>
        /// <param name="sGID">The s GID.</param>
        /// <returns></returns>
        internal List<NoticeToReferAffidavitEntity> GetListNoticeToReferAffidavitEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<NoticeToReferAffidavit>()
                .Add(Expression.Eq("SubmissionGroupId", sGID));
            List<NoticeToReferAffidavit> listNoticeToReferAffidavit = GetFromDetachedCriteria<NoticeToReferAffidavit>(detachedCriteria);

            if (listNoticeToReferAffidavit != null && listNoticeToReferAffidavit.Count > 0)
            {
                return listNoticeToReferAffidavit.Select(noticeToReferAffidavit => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetNoticeToReferAffidavitEntity(noticeToReferAffidavit)).ToList();
            }
            else
            {
                return null;
            }
        }


        internal List<ClaimAmountEntity> GetListClaimAmountByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<ClaimAmount>()
                .Add(Expression.Eq("DocId", docId));
            List<ClaimAmount> listClaimAmount = GetFromDetachedCriteria<ClaimAmount>(detachedCriteria);

            if (listClaimAmount != null && listClaimAmount.Count > 0)
            {
                return listClaimAmount.Select(claimAmount => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetClaimAmountEntity(claimAmount)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<SolicitorEntity> GetAllSolicitor()
        {
            List<Solicitor> listSolicitor = GetAllFromRepository<Solicitor>();
            if (listSolicitor != null && listSolicitor.Count > 0)
            {
                return listSolicitor.Select(solicitor => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetSolicitorEntity(solicitor)).ToList();
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



        internal List<PrayerEntity> GetListPrayerEntityByHrgId(long? hRGId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(Prayer))
                                                                .Add(Expression.Eq("HRGID", hRGId));
            List<Prayer> listPrayer = GetPrayers(detachedCriteria);
            if (listPrayer != null && listPrayer.Count > 0)
            {
                return listPrayer.Select(prayer => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetPrayerEntity(prayer)).ToList();
            }
            else
                return null;
        }


        internal List<OrdersMadeEntity> GetListOrdersMadeEntityByHrgId(long? HRGId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<OrdersMade>()
                   .Add(Expression.Eq("HRGId", HRGId));
            List<OrdersMade> listOrdersMade = GetFromDetachedCriteria<OrdersMade>(detachedCriteria);
            if (listOrdersMade != null && listOrdersMade.Count > 0)
            {
                return listOrdersMade.Select(ordersMade => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetOrdersMadeEntity(ordersMade)).ToList();
            }
            else
            {
                return null;
            }
        }
        internal List<CheckListCommentEntity> GetlistCheckListComment(string checkListSubmissionId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CheckListComments))
                                                                          .Add(Expression.Eq("CheckListSubmissionId", checkListSubmissionId));
            List<CheckListComments> listCheckListComments = GetFromDetachedCriteria<CheckListComments>(detachedCriteria);
            if (listCheckListComments != null && listCheckListComments.Count > 0)
            {
                return listCheckListComments.Select(checkListComments => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetCheckListCommentEntity(checkListComments)).ToList();
            }
            else
                return null;
        }

        internal List<RefOrderJOInfoEntity> GetListRefOrderJOInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RefOrderJOInfo>()
               .Add(Expression.Eq("SubmissionGroupID", submissionGroupId));
            List<RefOrderJOInfo> listRefOrderJOInfo = GetFromDetachedCriteria<RefOrderJOInfo>(detachedCriteria);
            if (listRefOrderJOInfo != null && listRefOrderJOInfo.Count > 0)
            {
                return listRefOrderJOInfo.Select(refOrderJOInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRefOrderJOInfoEntity(refOrderJOInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal SystemParametersEntity GetSystemParameterEntity(string configKey)
        {
            IRepository<SystemParameters> systemParametersRepository = new RepositoryImpl<SystemParameters>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetSystemParametersEntity(systemParametersRepository.Get(configKey));
       
        }

         internal List<SolicitorEntity> GetSolicitorEntityByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<Solicitor>()
                .Add(Expression.Eq("CaseInfoId",Convert.ToInt64( caseInfoId)));

            List<Solicitor> listSolicitor = GetFromDetachedCriteria<Solicitor>(detachedCriteria);

            if (listSolicitor != null && listSolicitor.Count > 0)
            {
                return listSolicitor.Select(solicitor => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetSolicitorEntity(solicitor)).ToList();
            }

            else
            {
                return null;
            }
        }


         internal List<SolicitorAddressEntity> GetListSolicitorAddressBySolicitorId(long solicitorId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<SolicitorAddress>()
               .Add(Expression.Eq("SolicitorID", solicitorId));

             List<SolicitorAddress> listSolicitorAddress = GetFromDetachedCriteria<SolicitorAddress>(detachedCriteria);

             if (listSolicitorAddress != null && listSolicitorAddress.Count > 0)
             {
                 return listSolicitorAddress.Select(solicitorAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LawFirmMapper.GetSolicitorAddressEntity(solicitorAddress)).ToList();
             }

             else
             {
                 return null;
             }
         }

         internal void SaveOrUpdateForeignLPSolicitorRegDetail(ForeignLPSolicitorRegDetailEntity foreignLPSolicitorRegDetailEntity)
         {
             if (foreignLPSolicitorRegDetailEntity != null)
             {
                 ForeignLPSolicitorRegDetail foreignLPSolicitorRegDetail = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetForeignLPSolicitorRegDetail(foreignLPSolicitorRegDetailEntity);

                 applicationSession.GetNamedQuery("SaveOrUpdateForeignLPSolicitorRegDetailProcedure")
                .SetParameter("ForeignLPSolicitorRegId", foreignLPSolicitorRegDetail.ForeignLPSolicitorRegId)
                   .SetParameter("ItemNo", foreignLPSolicitorRegDetail.ItemNo)
                   .SetParameter("LastModifiedBy", foreignLPSolicitorRegDetail.LastModifiedBy)
                   .SetParameter("LastModifiedDate", foreignLPSolicitorRegDetail.LastModifiedDate)
                    .SetParameter("ObsInd", foreignLPSolicitorRegDetail.ObsInd)
                   .SetParameter("ForeignLFID", foreignLPSolicitorRegDetail.ForeignLFID)
                   .SetParameter("SingaporeLFID", foreignLPSolicitorRegDetail.SingaporeLFID)
                   .SetParameter("ForeignLPTypeCode", foreignLPSolicitorRegDetail.MLawPracticeType != null ? foreignLPSolicitorRegDetail.MLawPracticeType.LawPracticeType : null)
                   .ExecuteUpdate();
             }
         }

         internal List<ForeignLPSolicitorRegEntity> GetListForeignLPSolicitorRegEntityByCaseInfoId(string CaseInfoId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<ForeignLPSolicitorReg>()
               .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(CaseInfoId)));
             List<ForeignLPSolicitorReg> listForeignLPSolicitorReg = GetFromDetachedCriteria<ForeignLPSolicitorReg>(detachedCriteria);
             if (listForeignLPSolicitorReg != null && listForeignLPSolicitorReg.Count > 0)
             {
                 return listForeignLPSolicitorReg.Select(foreignLPSolicitorReg => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetForeignLPSolicitorRegEntity(foreignLPSolicitorReg)).ToList();
             }
             else
             {
                 return null;
             }
         }

         internal List<ForeignLPSolicitorRegEntity> GetListForeignLPSolicitorRegEntityBySGID(string submissionGroupId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<ForeignLPSolicitorReg>()
               .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
             List<ForeignLPSolicitorReg> listForeignLPSolicitorReg = GetFromDetachedCriteria<ForeignLPSolicitorReg>(detachedCriteria);
             if (listForeignLPSolicitorReg != null && listForeignLPSolicitorReg.Count > 0)
             {
                 return listForeignLPSolicitorReg.Select(foreignLPSolicitorReg => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetForeignLPSolicitorRegEntity(foreignLPSolicitorReg)).ToList();
             }
             else
             {
                 return null;
             }
         }

         internal List<ForeignLPSolicitorRegDetailEntity> GetListForeignLPSolicitorRegDetailEntity(string foreignLPSolicitorRegId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<ForeignLPSolicitorRegDetail>()
              .Add(Expression.Eq("ForeignLPSolicitorRegId", foreignLPSolicitorRegId));
             List<ForeignLPSolicitorRegDetail> listForeignLPSolicitorRegDetail = GetFromDetachedCriteria<ForeignLPSolicitorRegDetail>(detachedCriteria);
             if (listForeignLPSolicitorRegDetail != null && listForeignLPSolicitorRegDetail.Count > 0)
             {
                 return listForeignLPSolicitorRegDetail.Select(foreignLPSolicitorRegDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetForeignLPSolicitorRegDetailEntity(foreignLPSolicitorRegDetail)).ToList();
             }
             else
             {
                 return null;
             }
         }


         internal List<ForeignUserRegistrationDetailsEntity> GetForeignUserRegistrationDetailsbySGID(string submissionGroupId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<ForeignUserRegistrationDetails>()
                 .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
             List<ForeignUserRegistrationDetails> listRegistrationDetails = GetFromDetachedCriteria<ForeignUserRegistrationDetails>(detachedCriteria);
             if (listRegistrationDetails != null && listRegistrationDetails.Count > 0)
             {
                 return listRegistrationDetails.Select(foreignUserRegistrationDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetForeignUserRegistrationDetailEntity(foreignUserRegistrationDetail)).ToList();
             }
             else
                 return null;
         }

         internal List<ForeignUserRegAddressDetailsEntity> GetForeignUserRegAddressDetailsbyRegistrationOfForeignLawyerId(string registrationOfForeignLawyerId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<ForeignUserRegAddressDetails>()
                 .Add(Expression.Eq("RegistrationOfForeignLawyerId", registrationOfForeignLawyerId));
             List<ForeignUserRegAddressDetails> listRegAddressDetails = GetFromDetachedCriteria<ForeignUserRegAddressDetails>(detachedCriteria);
             if (listRegAddressDetails != null && listRegAddressDetails.Count > 0)
             {
                 return listRegAddressDetails.Select(foreignUserAddrDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetForeignUserRegAddressDetailsEntity(foreignUserAddrDetail)).ToList();
             }
             else
                 return null;
         }

         internal List<ForeignUserPracticeInformationEntity> GetForeignUserPracticeInformationbyRegistrationOfForeignLawyerId(string registrationOfForeignLawyerId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<ForeignUserPracticeInformation>()
                 .Add(Expression.Eq("RegistrationOfForeignLawyerId", registrationOfForeignLawyerId));
             List<ForeignUserPracticeInformation> listPracticeInfo = GetFromDetachedCriteria<ForeignUserPracticeInformation>(detachedCriteria);
             if (listPracticeInfo != null && listPracticeInfo.Count > 0)
             {
                 return listPracticeInfo.Select(foreignUserPracticeInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetForeignUserPracticeInformationEntity(foreignUserPracticeInfo)).ToList();
             }
             else
                 return null;
         }

         internal List<ReqExaminationFeeDetailEntity> GetListReqExaminationFeedetailEntitybySGID(string submissionGroupId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<ReqExaminationFeeDetail>()
                            .Add(Expression.Eq("SubmissionGroupID", submissionGroupId));
             List<ReqExaminationFeeDetail> listReqExaminationFeedetail = GetFromDetachedCriteria<ReqExaminationFeeDetail>(detachedCriteria);
             if (listReqExaminationFeedetail != null && listReqExaminationFeedetail.Count > 0)
             {
                 return listReqExaminationFeedetail.Select(reqExaminationFeedetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetReqExaminationFeedetailEntity(reqExaminationFeedetail)).ToList();
             }
             else
                 return null;
         }

         internal List<CertSecurityOfCostsInfoEntity> GetListCertSecurityOfCostsInfoEntityBySGID(string submissionGroupId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<CertSecurityOfCostsInfo>()
                            .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
             List<CertSecurityOfCostsInfo> listCertSecurityOfCostsInfo = GetFromDetachedCriteria<CertSecurityOfCostsInfo>(detachedCriteria);
             if (listCertSecurityOfCostsInfo != null && listCertSecurityOfCostsInfo.Count > 0)
             {
                 return listCertSecurityOfCostsInfo.Select(certSecurityOfCostsInfoEntity => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetCertSecurityOfCostsInfoEntity(certSecurityOfCostsInfoEntity)).ToList();
             }
             else
                 return null;
         }


         internal List<RegistrationOfForeignLawyerEntity> GetRegistrationOfForeignLawyerBySGID(string submissionGroupId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<RegistrationOfForeignLawyer>()
                            .Add(Expression.Eq("SubmissionGroupID", submissionGroupId));
             List<RegistrationOfForeignLawyer> listRegistrationOfForeignLawyer = GetFromDetachedCriteria<RegistrationOfForeignLawyer>(detachedCriteria);
             if (listRegistrationOfForeignLawyer != null && listRegistrationOfForeignLawyer.Count > 0)
             {
                 return listRegistrationOfForeignLawyer.Select(registrationOfForeignLawyerEntity => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRegistrationOfForeignLawyerEntity(registrationOfForeignLawyerEntity)).ToList();
             }
             else
                 return null;
         }

         internal List<RFLValidityAndNotificationEntity> GetRFLValidityAndNotificationEntitybySGID(string submissionGroupId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<RFLValidityAndNotification>()
                            .Add(Expression.Eq("SubmissionGroupID", submissionGroupId));
             List<RFLValidityAndNotification> listRFLValidityAndNotification = GetFromDetachedCriteria<RFLValidityAndNotification>(detachedCriteria);
             if (listRFLValidityAndNotification != null && listRFLValidityAndNotification.Count > 0)
             {
                 return listRFLValidityAndNotification.Select(rFLValidityAndNotification => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRFLValidityAndNotificationEntity(rFLValidityAndNotification)).ToList();
             }
             else
                 return null;
         }

         internal List<SICCFeeLedgerEntity> GetSICCFeeLedgerBySGID(string submissionGroupId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<SICCFeeLedger>()
                            .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
             List<SICCFeeLedger> listSICCFeeLedger = GetFromDetachedCriteria<SICCFeeLedger>(detachedCriteria);
             if (listSICCFeeLedger != null && listSICCFeeLedger.Count > 0)
             {
                 return listSICCFeeLedger.Select(sICCFeeLedgerEntity => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetSICCFeeLedgerEntity(sICCFeeLedgerEntity)).ToList();
             }
             else
                 return null;
         }
         internal List<SystemParametersEntity> GetAllSystemParameters()
         {
             List<SystemParameters> listFromRepository = GetAllFromRepository<SystemParameters>();
             if (listFromRepository != null && listFromRepository.Count > 0)
             {
                 return listFromRepository.Select(systemParameters => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                     CommonMapper.GetSystemParametersEntity(systemParameters)).ToList();
             }
             else
             {
                 return null;
             }
         }
         /// <summary>
         /// Gets the pc application dates from sal.
         /// </summary>
         /// <param name="Caseinfoid">The caseinfoid.</param>
         /// <param name="PCCaseYear">The pc case year.</param>
         /// <returns></returns>
         internal List<PCAppDatesFromSALEntity> GetPCAppDatesFromSAL(string Caseinfoid, decimal PCCaseYear)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<PCAppDatesFromSAL>()
                            .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(Caseinfoid)))
                            .Add(Expression.Eq("PCCaseYear", PCCaseYear));
             List<PCAppDatesFromSAL> listPCAppDatesFromSAL = GetFromDetachedCriteria<PCAppDatesFromSAL>(detachedCriteria);
             if (listPCAppDatesFromSAL != null && listPCAppDatesFromSAL.Count > 0)
             {
                 return listPCAppDatesFromSAL.Select(pCAppDatesFromSAL => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetPCAppDatesFromSALEntity(pCAppDatesFromSAL)).ToList();
             }
             else
                 return null;
         }

         /// <summary>
         /// Gets the request for exemptionby sgid.
         /// </summary>
         /// <param name="SGID">The sgid.</param>
         /// <returns></returns>
         internal List<RequestForExemptionEntity> GetRequestForExemptionbySGID(string SGID)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<RequestForExemption>()
                            .Add(Expression.Eq("SubmissionGroupId", SGID));
             List<RequestForExemption> listRequestForExemption = GetFromDetachedCriteria<RequestForExemption>(detachedCriteria);
             if (listRequestForExemption != null && listRequestForExemption.Count > 0)
             {
                 return listRequestForExemption.Select(requestForExemption => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetRequestForExemptionEntity(requestForExemption)).ToList();
             }
             else
                 return null;
         }

         /// <summary>
         /// Gets the Fee Collection Detail by sgid.
         /// </summary>
         /// <param name="SGID">The sgid.</param>
         /// <returns></returns>
         internal List<FeeCollectionDetailEntity> GetFeeCollectionDetailBySGID(string SGID)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<FeeCollectionDetail>()
                            .Add(Expression.Eq("Submissiongroupid", SGID));
             List<FeeCollectionDetail> listFeeCollectionDetail = GetFromDetachedCriteria<FeeCollectionDetail>(detachedCriteria);
             if (listFeeCollectionDetail != null && listFeeCollectionDetail.Count > 0)
             {
                 return listFeeCollectionDetail.Select(feeCollectionDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetFeeCollectionDetailEntity(feeCollectionDetail)).ToList();
             }
             else
                 return null;
         }

         /// <summary>
         /// Gets the Fee Collection Detail by sgid.
         /// </summary>
         /// <param name="SGID">The Caseinfoid.</param>
         /// <returns></returns>
         internal List<FeeCollectionDetailEntity> GetFeeCollectionDetailByCaseinfoid(string Caseinfoid)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<FeeCollectionDetail>()
                            .Add(Expression.Eq("Caseinfoid", Convert.ToInt64(Caseinfoid)));
             List<FeeCollectionDetail> listFeeCollectionDetail = GetFromDetachedCriteria<FeeCollectionDetail>(detachedCriteria);
             if (listFeeCollectionDetail != null && listFeeCollectionDetail.Count > 0)
             {
                 return listFeeCollectionDetail.Select(feeCollectionDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetFeeCollectionDetailEntity(feeCollectionDetail)).ToList();
             }
             else
                 return null;
         }

         internal List<FeeCollectionDetailEntity> GetAllFeeCollectionDetail()
         {
             List<FeeCollectionDetail> listFeeCollectionDetail = GetAllFromRepository<FeeCollectionDetail>();
             if (listFeeCollectionDetail != null && listFeeCollectionDetail.Count > 0)
             {
                 return listFeeCollectionDetail.Select(feeCollectionDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                     CommonMapper.GetFeeCollectionDetailEntity(feeCollectionDetail)).ToList();
             }
             else
             {
                 return null;
             }
         }

         internal List<DocLegalExperienceInfoEntity> GetListDocLegalExperienceInfoBySGID(string submissionGroupId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<DocLegalExperienceInfo>()
                  .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
             List<DocLegalExperienceInfo> listDocLegalExperienceInfo = GetFromDetachedCriteria<DocLegalExperienceInfo>(detachedCriteria);
             if (listDocLegalExperienceInfo != null && listDocLegalExperienceInfo.Count > 0)
             {
                 return listDocLegalExperienceInfo.Select(docLegalExperienceInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetDocLegalExperienceInfoEntity(docLegalExperienceInfo)).ToList();
             }
             else
                 return null;
         }

         internal List<CaseLegalExperienceInfoEntity> GetListCaseLegalExperienceInfoByCaseInfoId(System.Int64 CaseInfoId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseLegalExperienceInfo>()
                  .Add(Expression.Eq("CaseInfoID", CaseInfoId));
             List<CaseLegalExperienceInfo> listCaseLegalExperienceInfo = GetFromDetachedCriteria<CaseLegalExperienceInfo>(detachedCriteria);
             if (listCaseLegalExperienceInfo != null && listCaseLegalExperienceInfo.Count > 0)
             {
                 return listCaseLegalExperienceInfo.Select(caseLegalExperienceInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetCaseLegalExperienceInfoEntity(caseLegalExperienceInfo)).ToList();
             }
             else
                 return null;
         }

         internal List<CaseLegalExperienceInfoEntity> GetListCaseLegalExperienceInfoByCaseInfoId(System.Int64 CaseInfoId, string LFID)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseLegalExperienceInfo>()
                  .Add(Expression.Eq("CaseInfoID", CaseInfoId))
                  .Add(Expression.Eq("LFID", LFID));
             List<CaseLegalExperienceInfo> listCaseLegalExperienceInfo = GetFromDetachedCriteria<CaseLegalExperienceInfo>(detachedCriteria);
             if (listCaseLegalExperienceInfo != null && listCaseLegalExperienceInfo.Count > 0)
             {
                 return listCaseLegalExperienceInfo.Select(caseLegalExperienceInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetCaseLegalExperienceInfoEntity(caseLegalExperienceInfo)).ToList();
             }
             else
                 return null;
         }

         internal List<CORSolicitorRegEntity> GetCORSolicitorRegByCaseInfoId(System.Int64 caseInfoId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<CORSolicitorReg>()
                  .Add(Expression.Eq("Caseinfoid", caseInfoId));
             List<CORSolicitorReg> listCORSolicitorReg = GetFromDetachedCriteria<CORSolicitorReg>(detachedCriteria);
             if (listCORSolicitorReg != null && listCORSolicitorReg.Count > 0)
             {
                 return listCORSolicitorReg.Select(cORSolicitorReg => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetCORSolicitorRegEntity(cORSolicitorReg)).ToList();
             }
             else
                 return null;
         }

         internal List<CORSolicitorRegDetailsEntity> GetCORSolicitorRegDetailsBySubCaseInfoId(System.Int64 subCaseInfoId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<CORSolicitorRegDetails>()
                  .Add(Expression.Eq("SubCaseInfoId", subCaseInfoId));
             List<CORSolicitorRegDetails> listCORSolicitorRegDetails = GetFromDetachedCriteria<CORSolicitorRegDetails>(detachedCriteria);
             if (listCORSolicitorRegDetails != null && listCORSolicitorRegDetails.Count > 0)
             {
                 return listCORSolicitorRegDetails.Select(cORSolicitorRegDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetCORSolicitorRegDetailsEntity(cORSolicitorRegDetails)).ToList();
             }
             else
                 return null;
         }

         internal List<DocCaseCounterClaimEntity> GetListDocCaseCounterClaimBySubmissionGroupID(System.String SGID)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<DocCaseCounterClaim>()
                  .Add(Expression.Eq("SubmissionGroupID", SGID));
             List<DocCaseCounterClaim> listDocCaseCounterClaim = GetFromDetachedCriteria<DocCaseCounterClaim>(detachedCriteria);
             if (listDocCaseCounterClaim != null && listDocCaseCounterClaim.Count > 0)
             {
                 return listDocCaseCounterClaim.Select(docCaseCounterClaim => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetDocCaseCounterClaimEntity(docCaseCounterClaim)).ToList();
             }
             else
                 return null;
         }

         internal List<DocCaseCounterClaimDetailsEntity> GetListDocCaseCounterClaimDetailsByDocCaseCounterClaimID(System.String docCaseCounterClaimID)
         {  
             DetachedCriteria detachedCriteria = DetachedCriteria.For<DocCaseCounterClaimDetails>()
                         .Add(Expression.Eq("DocCaseCounterClaimID", docCaseCounterClaimID));
             List<DocCaseCounterClaimDetails> listDocCaseCounterClaimDetails = GetFromDetachedCriteria<DocCaseCounterClaimDetails>(detachedCriteria);
             if (listDocCaseCounterClaimDetails != null && listDocCaseCounterClaimDetails.Count > 0)
             {
                 return listDocCaseCounterClaimDetails.Select(docCaseCounterClaimDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetDocCaseCounterClaimDetailsEntity(docCaseCounterClaimDetails)).ToList();
             }
             else
                 return null;
         }

         internal List<DocCaseCounterClaimDetailsEntity> GetListDocCaseCounterClaimDetailsBySubmissionGroupID(System.String SGID)
         {
             List<DocCaseCounterClaimEntity> listDocCaseCounterClaimEntity = GetListDocCaseCounterClaimBySubmissionGroupID(SGID);
             if (listDocCaseCounterClaimEntity != null && listDocCaseCounterClaimEntity.Count > 0)
             {
                 List<DocCaseCounterClaimDetailsEntity> listDocCaseCounterClaimDetailsBySGID = new List<DocCaseCounterClaimDetailsEntity>();
                 foreach (DocCaseCounterClaimEntity parentEntity in listDocCaseCounterClaimEntity)
                 {
                     List<DocCaseCounterClaimDetailsEntity> docCaseCounterClaimDetailsEntityList = GetListDocCaseCounterClaimDetailsByDocCaseCounterClaimID(parentEntity.DocCaseCounterClaimID);
                     if (docCaseCounterClaimDetailsEntityList != null && docCaseCounterClaimDetailsEntityList.Count > 0)
                     listDocCaseCounterClaimDetailsBySGID.AddRange(docCaseCounterClaimDetailsEntityList);
                 }
                 if (listDocCaseCounterClaimDetailsBySGID != null) return listDocCaseCounterClaimDetailsBySGID;
                 else return null;
             }
             else return null;

         }

         internal List<CaseCounterClaimEntity> GetListCaseCounterClaimByCaseCounterClaimID(System.String caseCounterClaimId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseCounterClaim>()
                         .Add(Expression.Eq("CaseCounterClaimID", caseCounterClaimId));
             List<CaseCounterClaim> listCaseCounterClaim = GetFromDetachedCriteria<CaseCounterClaim>(detachedCriteria);
             if (listCaseCounterClaim != null && listCaseCounterClaim.Count > 0)
             {
                 return listCaseCounterClaim.Select(caseCounterClaim => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetCaseCounterClaimEntity(caseCounterClaim)).ToList();
             }
             else
                 return null;
         }

         internal List<DocCaseCounterClaimEntity> GetListDocCaseCounterClaimByDocID(System.String docId)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<DocCaseCounterClaim>()
                  .Add(Expression.Eq("DocID", docId));
             List<DocCaseCounterClaim> listDocCaseCounterClaim = GetFromDetachedCriteria<DocCaseCounterClaim>(detachedCriteria);
             if (listDocCaseCounterClaim != null && listDocCaseCounterClaim.Count > 0)
             {
                 return listDocCaseCounterClaim.Select(docCaseCounterClaim => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetDocCaseCounterClaimEntity(docCaseCounterClaim)).ToList();
             }
             else
                 return null;
         }

         internal List<CaseCounterClaimDetailsEntity> GetListCaseCounterClaimDetailsByCaseCounterClaimID(System.String caseCounterClaimID)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseCounterClaimDetails>()
                  .Add(Expression.Eq("CaseCounterClaimID", caseCounterClaimID));
             List<CaseCounterClaimDetails> listCaseCounterClaimDetails = GetFromDetachedCriteria<CaseCounterClaimDetails>(detachedCriteria);
             if (listCaseCounterClaimDetails != null && listCaseCounterClaimDetails.Count > 0)
             {
                 return listCaseCounterClaimDetails.Select(caseCounterClaimDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetCaseCounterClaimDetailsEntity(caseCounterClaimDetails)).ToList();
             }
             else
                 return null;
         }

         internal void DeleteCaseCounterClaimDetailsByCaseCounterClaimID(System.String caseCounterClaimID)
         {
             DetachedCriteria detachedCriteria = DetachedCriteria.For<CaseCounterClaimDetails>()
                  .Add(Expression.Eq("CaseCounterClaimID", caseCounterClaimID));

             List<CaseCounterClaimDetails> listCaseCounterClaimDetails = GetFromDetachedCriteria<CaseCounterClaimDetails>(detachedCriteria);
             if (listCaseCounterClaimDetails != null && listCaseCounterClaimDetails.Count > 0)
             {
                 Repository<CaseCounterClaimDetails>().DeleteAll(listCaseCounterClaimDetails);
             }
         }

        #endregion Methods
         
    }
}