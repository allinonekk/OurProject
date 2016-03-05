#region Header

/*****************************************************************************************************
* Description : This file represents a standard data access gateway for Subsequent entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   27/01/2011   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: SubsequentGateway.cs
// Description: Represents a standard data access gateway for Subsequent entities.
// </summary>
// <copyright file= "SubsequentGateway.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Class represents a standard data access gateway for Subsequent entities.
    /// </summary>
    internal class SubsequentGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SubsequentGateway));

        /// <summary>
        /// <see cref="ISession"/> instance for Session context.
        /// </summary>
        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SubsequentGateway"/> class.
        /// </summary>
        internal SubsequentGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;
        }

        #endregion Constructors

        #region Methods

        internal void DeleteDivorceSubInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DivorceSubInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            IRepository<DivorceSubInfo> DivorceSubInfoRepository = new RepositoryImpl<DivorceSubInfo>(applicationSession);
            IList<DivorceSubInfo> listDivorceSubInfo = DivorceSubInfoRepository.GetAll(detachedCriteria) as IList<DivorceSubInfo>;
            DivorceSubInfoRepository.DeleteAll(listDivorceSubInfo);
        }

        internal void DeleteRAccusedStatementInfoEntityByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RAccusedStatementInfo))
               .Add(Expression.Eq("CasePartyId", casePartyId));

            IRepository<RAccusedStatementInfo> RAccusedStatementInfoRepository = new RepositoryImpl<RAccusedStatementInfo>(applicationSession);
            IList<RAccusedStatementInfo> listRAccusedStatementInfo = RAccusedStatementInfoRepository.GetAll(detachedCriteria) as IList<RAccusedStatementInfo>;
            RAccusedStatementInfoRepository.DeleteAll(listRAccusedStatementInfo);
        }

        internal void DeleteRAccusedStatementInfoEntityByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RAccusedStatementInfo))
               .Add(Expression.Eq("DocId", docId));

            IRepository<RAccusedStatementInfo> RAccusedStatementInfoRepository = new RepositoryImpl<RAccusedStatementInfo>(applicationSession);
            IList<RAccusedStatementInfo> listRAccusedStatementInfo = RAccusedStatementInfoRepository.GetAll(detachedCriteria) as IList<RAccusedStatementInfo>;
            RAccusedStatementInfoRepository.DeleteAll(listRAccusedStatementInfo);
        }

        internal void DeleteRAccusedStatementInfoEntityByDocIdsCasePartyIds(List<string> docId, List<string> casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RAccusedStatementInfo))
               .Add(Expression.In("DocId", docId))
               .Add(Expression.In("CasePartyId", casePartyId));

            IRepository<RAccusedStatementInfo> rAccusedStatementInfoRepository = new RepositoryImpl<RAccusedStatementInfo>(applicationSession);
            rAccusedStatementInfoRepository.DeleteAll(GetAllRAccusedStatementInfo(detachedCriteria));
        }

        internal void DeleteWitnessInfoEntityByDocIds(List<string> docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WitnessInfo))
               .Add(Expression.In("DocId", docId));

            IRepository<WitnessInfo> witnessInfoRepository = new RepositoryImpl<WitnessInfo>(applicationSession);
            witnessInfoRepository.DeleteAll(GetAllWitnessInfo(detachedCriteria));
        }

        internal void DeleteWOERequestEntityBySubmissionGroupId(string SubmissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WOERequest))
               .Add(Expression.Eq("SubmissionGroupId", SubmissionGroupId));

            IRepository<WOERequest> WOERequestRepository = new RepositoryImpl<WOERequest>(applicationSession);
            WOERequestRepository.DeleteAll(GetAllWOERequest(detachedCriteria));
        }

        internal BillOfSaleSubInfoEntity GetBillOfSaleSubInfoEntity(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<BillOfSaleSubInfo>()
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<BillOfSaleSubInfo> listBillOfSaleSubInfo = GetFromDetachedCriteria<BillOfSaleSubInfo>(detachedCriteria);
            if (listBillOfSaleSubInfo != null && listBillOfSaleSubInfo.Count > 0)
            {
                return listBillOfSaleSubInfo.Select(billOfSaleSubInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetBillOfSaleSubInfoEntity(billOfSaleSubInfo)).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        internal List<FileInspectionDocDetailEntity> GetFileInspectionDocDetailEntity(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(FileInspectionDocDetail))
                                                          .Add(Expression.Eq("DocId", docId));
            List<FileInspectionDocDetail> listFileInspectionDocDetail = GetFileInspectionDocDetail(detachedCriteria);

            if (listFileInspectionDocDetail != null && listFileInspectionDocDetail.Count > 0)
            {
                return listFileInspectionDocDetail.Select(fileInspectionDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetFileInspectionDocDetailEntity(fileInspectionDocDetail)).ToList();
            }

            return null;
        }

        internal List<DisWithDocPtyDetailEntity> GetListDisWithDocPtyDetailBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DisWithDocPtyDetail>()
                 .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<DisWithDocPtyDetail> listDisWithDocPtyDetail = GetFromDetachedCriteria<DisWithDocPtyDetail>(detachedCriteria);
            if (listDisWithDocPtyDetail != null && listDisWithDocPtyDetail.Count > 0)
            {
                return listDisWithDocPtyDetail.Select(disWithDocPtyDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetDisWithDocPtyDetailEntity(disWithDocPtyDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DivorceSubInfoEntity> GetListDivorceSubInfoEntityBySGID(string submissionGroupId)
        {
            List<DivorceSubInfoEntity> listDivorceSubInfoEntity = new List<DivorceSubInfoEntity>();

            DivorceSubInfoEntity divorceSubInfoEntity = null;
            List<DivorceSubInfo> listDivorceSubInfo = new List<DivorceSubInfo>();
            IRepository<DivorceSubInfo> divorceSubInfoRepository = new RepositoryImpl<DivorceSubInfo>(applicationSession);

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DivorceSubInfo))
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            listDivorceSubInfo = divorceSubInfoRepository.GetAll(detachedCriteria) as List<DivorceSubInfo>;

            if (listDivorceSubInfo != null && listDivorceSubInfo.Count > 0)
            {
                foreach (DivorceSubInfo divorceSubInfo in listDivorceSubInfo)
                {
                    divorceSubInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetDivorceSubInfoEntity(divorceSubInfo);
                    listDivorceSubInfoEntity.Add(divorceSubInfoEntity);
                }
            }
            return listDivorceSubInfoEntity;
        }

        internal List<DocRequestDetailEntity> GetListDocRequestDetail(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DocRequestDetail))
                                                         .Add(Expression.Eq("DocId", docId));
            List<DocRequestDetail> listDocRequestDetail = GetDocRequestDetail(detachedCriteria);

            if (listDocRequestDetail != null && listDocRequestDetail.Count > 0)
            {
                return listDocRequestDetail.Select(docRequestDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetDocRequestDetailEntity(docRequestDetail)).ToList();
            }

            return null;
        }

        internal List<FileInspectionEntity> GetListFileInspectionEntity(string docId)
        {
            DocumentInfo documentInfo = new DocumentInfo();
            documentInfo.DocId = docId;
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(FileInspection))
                                                           .Add(Expression.Eq("DocumentInfo", documentInfo));
            List<FileInspection> listFileInspection = GetFileInspection(detachedCriteria);

            if (listFileInspection != null && listFileInspection.Count > 0)
            {
                return listFileInspection.Select(fileInspection => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetFileInspectionEntity(fileInspection)).ToList();
            }

            return null;
        }

        internal List<FilingFeeRequestDetailEntity> GetListFilingFeeRequestDetailEntityByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<FilingFeeRequestDetail>()
                .Add(Expression.Eq("DocId", docId));
            List<FilingFeeRequestDetail> listFilingFeeRequestDetail = GetFromDetachedCriteria<FilingFeeRequestDetail>(detachedCriteria);
            if (listFilingFeeRequestDetail != null && listFilingFeeRequestDetail.Count > 0)
            {
                return listFilingFeeRequestDetail.Select(filingFeeRequestDetailEntity => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetFilingFeeRequestDetailEntity(filingFeeRequestDetailEntity)).ToList();

            }
            else
            {
                return null;
            }
        }

        internal List<PartyAmendmentEntity> GetListPartyAmendmentByDocId(string docId)
        {
            DocumentInfo documentInfo = new DocumentInfo();
            documentInfo.DocId = docId;
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PartyAmendment))
                .Add(Expression.Eq("DocumentInfo", documentInfo));

            List<PartyAmendment> listPartyAmendment = GetFromDetachedCriteria(detachedCriteria);
            if (listPartyAmendment != null && listPartyAmendment.Count > 0)
            {
                return listPartyAmendment.Select(partyAmendment => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetPartyAmendmentEntity(partyAmendment)).ToList();
            }
            else
                return null;
        }

        internal List<PartyAmendmentDetailEntity> GetListPartyAmendmentDetailByAmendmentId(string amendmentId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PartyAmendmentDetail))
              .Add(Expression.Eq("AmendmentId", amendmentId));
            List<PartyAmendmentDetail> listPartyAmendmentDetail = GetPartyAmendmentDetail(detachedCriteria);
            if (listPartyAmendmentDetail != null && listPartyAmendmentDetail.Count > 0)
            {
                return listPartyAmendmentDetail.Select(partyAmendmentDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetPartyAmendmentDetailEntity(partyAmendmentDetail)).ToList();
            }
            else
                return null;
        }

        internal List<PartyAmendmentLeaveOfCourtEntity> GetListPartyAmendmentLeaveOfCourtByAmendmentID(string amendmentId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PartyAmendmentLeaveOfCourt))
             .Add(Expression.Eq("AmendmentId", amendmentId));
            List<PartyAmendmentLeaveOfCourt> listPartyAmendmentLeaveOfCourt = GetPartyAmendmentLeaveOfCourt(detachedCriteria);
            if (listPartyAmendmentLeaveOfCourt != null && listPartyAmendmentLeaveOfCourt.Count > 0)
            {
                return listPartyAmendmentLeaveOfCourt.Select(partyAmendmentLeaveOfCourt => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetPartyAmendmentLeaveOfCourtEntity(partyAmendmentLeaveOfCourt)).ToList();
            }
            else
                return null;
        }

        internal List<RAccusedStatementInfoEntity> GetListRAccusedStatementInfoByDocIdsCasePartyIds(List<string> docId, List<string> casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RAccusedStatementInfo))
                .Add(Expression.In("DocId", docId))
                .Add(Expression.In("CasePartyId", casePartyId));

            List<RAccusedStatementInfo> listRAccusedStatementInfo = GetAllRAccusedStatementInfo(detachedCriteria);

            if (listRAccusedStatementInfo != null && listRAccusedStatementInfo.Count > 0)
            {
                return listRAccusedStatementInfo.Select(item => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetRAccusedStatementInfoEntity(item)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RequestDocDetailEntity> GetListRequestDocDetailByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RequestDocDetail))
                                                            .Add(Expression.Eq("DocId", docId));
            List<RequestDocDetail> listRequestDocDetail = GetFromDetachedCriteria<RequestDocDetail>(detachedCriteria);

            if (listRequestDocDetail != null && listRequestDocDetail.Count > 0)
            {
                return listRequestDocDetail.Select(requestDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetRequestDocDetailEntity(requestDocDetail)).ToList();
            }

            return null;
        }

        internal List<RequestDocDetailEntity> GetListRequestDocDetailByRequestDocId(string requestDocId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RequestDocDetail))
                                                            .Add(Expression.Eq("RequestDocId", requestDocId));
            List<RequestDocDetail> listRequestDocDetail = GetRequestDocDetail(detachedCriteria);

            if (listRequestDocDetail != null && listRequestDocDetail.Count > 0)
            {
                return listRequestDocDetail.Select(requestDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetRequestDocDetailEntity(requestDocDetail)).ToList();
            }

            return null;
        }

        internal List<RequestHearingAdminSupportEntity> GetListRequestHearingAdminSupport(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RequestHearingAdminSupport>()
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<RequestHearingAdminSupport> listRequestHearingAdminSupport = GetFromDetachedCriteria<RequestHearingAdminSupport>(detachedCriteria);
            if (listRequestHearingAdminSupport != null && listRequestHearingAdminSupport.Count > 0)
            {
                return listRequestHearingAdminSupport.Select(requestHearingAdminSupport => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetRequestHearingAdminSupportEntity(requestHearingAdminSupport)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RequestNEGDDetailEntity> GetListRequestNEGDDetailEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RequestNEGDDetail>()
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<RequestNEGDDetail> listRequestNEGDDetail = GetFromDetachedCriteria<RequestNEGDDetail>(detachedCriteria);

            if (listRequestNEGDDetail != null && listRequestNEGDDetail.Count > 0)
            {
                return listRequestNEGDDetail.Select(requestNEGDDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetRequestNEGDDetail(requestNEGDDetail)).ToList();
            }
            else
                return null;
        }

        internal List<SubpoenaDocDetailEntity> GetListSubpoenaDocDetailsBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SubpoenaDocDetail))
                                                         .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<SubpoenaDocDetail> listSubpoenaDocDetail = GetSubpoenaDocDetail(detachedCriteria);

            if (listSubpoenaDocDetail != null && listSubpoenaDocDetail.Count > 0)
            {
                return listSubpoenaDocDetail.Select(subpoenaDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetSubpoenaDocDetailEntity(subpoenaDocDetail)).ToList();
            }

            return null;
        }

        internal List<SubpoenaInfoEntity> GetListSubpoenaInfoEntityBySGId(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SubpoenaInfo))
                                                         .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<SubpoenaInfo> listSubpoenaInfo = GetSubpoenaInfo(detachedCriteria);

            if (listSubpoenaInfo != null && listSubpoenaInfo.Count > 0)
            {
                return listSubpoenaInfo.Select(subpoenaInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetSubpoenaInfoEntity(subpoenaInfo)).ToList();
            }

            return null;
        }

        internal List<SubpoenaWitnessDetailEntity> GetListSubpoenaWitnessDetailBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SubpoenaWitnessDetail))
                                                         .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<SubpoenaWitnessDetail> listSubpoenaWitnessDetail = GetSubpoenaWitnessDetail(detachedCriteria);

            if (listSubpoenaWitnessDetail != null && listSubpoenaWitnessDetail.Count > 0)
            {
                return listSubpoenaWitnessDetail.Select(subpoenaWitnessDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetSubpoenaWitnessDetailEntity(subpoenaWitnessDetail)).ToList();
            }

            return null;
        }

        internal List<WitnessInfoEntity> GetListWitnessInfoByDocIds(List<string> docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WitnessInfo))
                .Add(Expression.In("DocId", docId));

            List<WitnessInfo> listWitnessInfo = GetAllWitnessInfo(detachedCriteria);

            if (listWitnessInfo != null && listWitnessInfo.Count > 0)
            {
                return listWitnessInfo.Select(item => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetWitnessInfoEntity(item)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<WOEInfoEntity> GetListWOEInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WOEInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            List<WOEInfo> listWOEInfo = GetAllWOEInfo(detachedCriteria);

            if (listWOEInfo != null && listWOEInfo.Count > 0)
            {
                return listWOEInfo.Select(woeInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetWOEInfoEntity(woeInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<WOENCPEInfoEntity> GetListWOENCPEInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WOENCPEInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            List<WOENCPEInfo> listWOENCPEInfo = GetAllWOENCPEInfo(detachedCriteria);

            if (listWOENCPEInfo != null && listWOENCPEInfo.Count > 0)
            {
                return listWOENCPEInfo.Select(woeNCPEInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetWOENCPEInfoEntity(woeNCPEInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<WOENECPEInfoEntity> GetListWOENECPEInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WOENECPEInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            List<WOENECPEInfo> listWOENECPEInfo = GetAllWOENECPEInfo(detachedCriteria);

            if (listWOENECPEInfo != null && listWOENECPEInfo.Count > 0)
            {
                return listWOENECPEInfo.Select(woeNECPEInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetWOENECPEInfoEntity(woeNECPEInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<WOERequestEntity> GetListWOERequestBySubmissionGroupId(string SubmissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WOERequest))
                .Add(Expression.Eq("SubmissionGroupId", SubmissionGroupId));

            List<WOERequest> listWOERequest = GetAllWOERequest(detachedCriteria);

            if (listWOERequest != null && listWOERequest.Count > 0)
            {
                return listWOERequest.Select(woeRequest => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetWOERequestEntity(woeRequest)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal RAccusedStatementInfoEntity GetRAccusedStatementInfoEntityByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RAccusedStatementInfo))
                .Add(Expression.Eq("CasePartyId", casePartyId));

            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetRAccusedStatementInfoEntity(GetRAccusedStatementInfo(detachedCriteria));
        }

        internal RAccusedStatementInfoEntity GetRAccusedStatementInfoEntityByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RAccusedStatementInfo))
                .Add(Expression.Eq("DocId", docId));
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetRAccusedStatementInfoEntity(GetRAccusedStatementInfo(detachedCriteria));
        }

        internal WOEInfoEntity GetWOEInfoEntity(string woeInfoId)
        {
            IRepository<WOEInfo> mCWOEInfoRepository = new RepositoryImpl<WOEInfo>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetWOEInfoEntity(mCWOEInfoRepository.Get(woeInfoId));
        }

        internal WOEInfoEntity GetWOEInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WOEInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            List<WOEInfo> listWOEInfo = GetAllWOEInfo(detachedCriteria);

            if (listWOEInfo != null && listWOEInfo.Count > 0)
            {
                return listWOEInfo.Select(woeInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetWOEInfoEntity(woeInfo)).ToList()[0];
            }
            else
            {
                return null;
            }
        }

        internal WOENCPEInfoEntity GetWOENCPEInfoEntity(string woeNCPEInfoId)
        {
            IRepository<WOENCPEInfo> mCWOENCPEInfoRepository = new RepositoryImpl<WOENCPEInfo>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetWOENCPEInfoEntity(mCWOENCPEInfoRepository.Get(woeNCPEInfoId));
        }

        internal WOENECPEInfoEntity GetWOENECPEInfoEntity(string woeNECPEInfoId)
        {
            IRepository<WOENECPEInfo> mCWOENECPEInfoRepository = new RepositoryImpl<WOENECPEInfo>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetWOENECPEInfoEntity(mCWOENECPEInfoRepository.Get(woeNECPEInfoId));
        }

        private List<RAccusedStatementInfo> GetAllRAccusedStatementInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<RAccusedStatementInfo> rAccusedStatementInfoRepository = new RepositoryImpl<RAccusedStatementInfo>(applicationSession);
            return rAccusedStatementInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<WitnessInfo> GetAllWitnessInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<WitnessInfo> repository = new RepositoryImpl<WitnessInfo>(applicationSession);
            return repository.GetAll(detachedCriteria).ToList();
        }

        private List<WOEInfo> GetAllWOEInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<WOEInfo> woeRepository = new RepositoryImpl<WOEInfo>(applicationSession);
            return woeRepository.GetAll(detachedCriteria).ToList();
        }

        private List<WOENCPEInfo> GetAllWOENCPEInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<WOENCPEInfo> woeRepository = new RepositoryImpl<WOENCPEInfo>(applicationSession);
            return woeRepository.GetAll(detachedCriteria).ToList();
        }

        private List<WOENECPEInfo> GetAllWOENECPEInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<WOENECPEInfo> woeRepository = new RepositoryImpl<WOENECPEInfo>(applicationSession);
            return woeRepository.GetAll(detachedCriteria).ToList();
        }

        private List<WOERequest> GetAllWOERequest(DetachedCriteria detachedCriteria)
        {
            IRepository<WOERequest> woeRequestRepository = new RepositoryImpl<WOERequest>(applicationSession);
            return woeRequestRepository.GetAll(detachedCriteria).ToList();
        }

        private List<DocRequestDetail> GetDocRequestDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<DocRequestDetail> docRequestDetailRepository = new RepositoryImpl<DocRequestDetail>(applicationSession);
            return docRequestDetailRepository.GetAll(detachedCriteria).ToList();
        }

        private List<FileInspection> GetFileInspection(DetachedCriteria detachedCriteria)
        {
            IRepository<FileInspection> fileInspectionRepository = new RepositoryImpl<FileInspection>(applicationSession);
            return fileInspectionRepository.GetAll(detachedCriteria).ToList();
        }

        private List<FileInspectionDocDetail> GetFileInspectionDocDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<FileInspectionDocDetail> fileInspectionDocDetailRepository = new RepositoryImpl<FileInspectionDocDetail>(applicationSession);
            return fileInspectionDocDetailRepository.GetAll(detachedCriteria).ToList();
        }

        private List<PartyAmendment> GetFromDetachedCriteria(DetachedCriteria detachedCriteria)
        {
            IRepository<PartyAmendment> partyAmendmentRepository = new RepositoryImpl<PartyAmendment>(applicationSession);
            return partyAmendmentRepository.GetAll(detachedCriteria).ToList();
        }

        private List<T> GetFromDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll(detachedCriteria) as List<T>;
        }

        private List<PartyAmendmentDetail> GetPartyAmendmentDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<PartyAmendmentDetail> partyAmendmentDetailRepository = new RepositoryImpl<PartyAmendmentDetail>(applicationSession);
            return partyAmendmentDetailRepository.GetAll(detachedCriteria).ToList();
        }

        private List<PartyAmendmentLeaveOfCourt> GetPartyAmendmentLeaveOfCourt(DetachedCriteria detachedCriteria)
        {
            IRepository<PartyAmendmentLeaveOfCourt> partyAmendmentLeaveOfCourtRepository = new RepositoryImpl<PartyAmendmentLeaveOfCourt>(applicationSession);
            return partyAmendmentLeaveOfCourtRepository.GetAll(detachedCriteria).ToList();
        }

        private RAccusedStatementInfo GetRAccusedStatementInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<RAccusedStatementInfo> iRAccusedStatementInfoRepository = new RepositoryImpl<RAccusedStatementInfo>(applicationSession);
            List<RAccusedStatementInfo> test = iRAccusedStatementInfoRepository.GetAll(detachedCriteria).ToList();
            //This seems like a bad way to retrieve. But there is only 1 data at a time. Please check on the best way to resolve this.
            return test[0];
        }

        private List<RequestDocDetail> GetRequestDocDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<RequestDocDetail> requestDocDetailRepository = new RepositoryImpl<RequestDocDetail>(applicationSession);
            return requestDocDetailRepository.GetAll(detachedCriteria).ToList();
        }

        private List<SubpoenaDocDetail> GetSubpoenaDocDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<SubpoenaDocDetail> subpoenaDocDetailRepository = new RepositoryImpl<SubpoenaDocDetail>(applicationSession);
            return subpoenaDocDetailRepository.GetAll(detachedCriteria).ToList();
        }

        private List<SubpoenaInfo> GetSubpoenaInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<SubpoenaInfo> subpoenaInfoRepository = new RepositoryImpl<SubpoenaInfo>(applicationSession);
            return subpoenaInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<SubpoenaWitnessDetail> GetSubpoenaWitnessDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<SubpoenaWitnessDetail> subpoenaWitnessDetailRepository = new RepositoryImpl<SubpoenaWitnessDetail>(applicationSession);
            return subpoenaWitnessDetailRepository.GetAll(detachedCriteria).ToList();
        }

        internal PaymentHRGDatesDocDetailEntity GetPaymentHRGDatesDocDetailBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<PaymentHRGDatesDocDetail>()
                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<PaymentHRGDatesDocDetail> listPaymentHRGDatesDocDetail = GetFromDetachedCriteria<PaymentHRGDatesDocDetail>(detachedCriteria);
            if (listPaymentHRGDatesDocDetail != null
                && listPaymentHRGDatesDocDetail.Count > 0)
            {
                return listPaymentHRGDatesDocDetail.Select(paymentHRGDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetPaymentHRGDatesDocDetailEntity(paymentHRGDocDetail)).FirstOrDefault();

            }
            else
                return null;
        }

       


        internal List<RequestHearingFeeDetailEntity> GetListRequestHearingFeeDetail(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RequestHearingFeeDetail>()
                                                 .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<RequestHearingFeeDetail> listRequestHearingFeeDetail = GetFromDetachedCriteria<RequestHearingFeeDetail>(detachedCriteria);
            if (listRequestHearingFeeDetail != null
                && listRequestHearingFeeDetail.Count > 0)
            {
                return listRequestHearingFeeDetail.Select(requestHearingFeeDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetRequestHearingFeeDetailEntity(requestHearingFeeDetail)).ToList();

            }
            else
                return null;
        }

        internal FileInspectionEntity GetFileInspectionEntityByPK(string fileInspectionId)
        {
            IRepository<FileInspection> fileInspectionRepository = new RepositoryImpl<FileInspection>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetFileInspectionEntity(fileInspectionRepository.Get(fileInspectionId));
        }


        internal List<FileInspectionDocDetailEntity> GetListFileInspectionDocDetailByFileInspectionId(string fileInspectionId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<FileInspectionDocDetail>()
                                                  .Add(Expression.Eq("FileInspectionId", fileInspectionId));
            List<FileInspectionDocDetail> listFileInspectionDocDetail = GetFromDetachedCriteria<FileInspectionDocDetail>(detachedCriteria);
            if (listFileInspectionDocDetail != null                && listFileInspectionDocDetail.Count > 0)
            {
                return listFileInspectionDocDetail.Select(fFileInspectionDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetFileInspectionDocDetailEntity(fFileInspectionDocDetail)).ToList();

            }
            else
                return null;
        }

        #endregion Methods

    }
}