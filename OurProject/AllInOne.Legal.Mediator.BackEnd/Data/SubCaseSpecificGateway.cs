#region Header

/*****************************************************************************************************
* Description : This file represents a standard data access gateway for SubCaseSpecific.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   17/01/2011   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: SubCaseGateway.cs
// Description: Represents a standard data access gateway for SubCaseSpecific.
// </summary>
// <copyright file= "SubCaseSpecificGateway.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Class represents a standard data access gateway for SubCase.
    /// </summary>
    internal class SubCaseSpecificGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SubCaseSpecificGateway));

        /// <summary>
        /// <see cref="ISession"/> instance for Session context.
        /// </summary>
        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOfDocGateway"/> class.
        /// </summary>
        internal SubCaseSpecificGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

            //AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.MappingToDTO nHibernateToDomainMapping = new AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.MappingToDTO();
            //nHibernateToDomainMapping.MapAll();

            //AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.MappingToDomain domainToNHibernateMapping = new AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.MappingToDomain();
            //domainToNHibernateMapping.MapAll();
        }

        #endregion Constructors

        #region Methods

        internal void DeleteRARASInfo(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RARASInfo>()
                 .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<RARASInfo> listRARASInfo = GetFromDetachedCriteria<RARASInfo>(detachedCriteria);
            if (listRARASInfo != null && listRARASInfo.Count > 0)
            {
                Repository<RARASInfo>().DeleteAll(listRARASInfo);
            }
        }

        internal List<AccountantsReportInfoEntity> GetListAccountantsReportInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(AccountantsReportInfo))
                                                            .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<AccountantsReportInfo> listAccountantsReportInfo = GetAllAccountantsReportInfo(detachedCriteria);
            if (listAccountantsReportInfo != null && listAccountantsReportInfo.Count > 0)
            {
                return listAccountantsReportInfo.Select(accountantsReportInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetAccountantsReportInfoEntity(accountantsReportInfo)).ToList();
            }
            else
                return null;
        }

        internal List<AreaOfLegalPracticeEntity> GetListAreaOfLegalPracticeBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(AreaOfLegalPractice))
                                                              .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<AreaOfLegalPractice> listAreaOfLegalPractice = GetAllAreaOfLegalPractice(detachedCriteria);
            if (listAreaOfLegalPractice != null && listAreaOfLegalPractice.Count > 0)
            {
                return listAreaOfLegalPractice.Select(areaOfLegalPractice => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetAreaOfLegalPracticeEntity(areaOfLegalPractice)).ToList();
            }
            else
                return null;
        }

        internal List<LPOthLegalOrgAddrInfoEntity> GetListLPOthLegalOrgAddrInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LPOthLegalOrgAddrInfo))
                                                            .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<LPOthLegalOrgAddrInfo> listLPOthLegalOrgAddrInfo = GetAllLPOthLegalOrgAddrInfo(detachedCriteria);
            if (listLPOthLegalOrgAddrInfo != null && listLPOthLegalOrgAddrInfo.Count > 0)
            {
                return listLPOthLegalOrgAddrInfo.Select(lPOthLegalOrgAddrInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetLPOthLegalOrgAddrInfoEntity(lPOthLegalOrgAddrInfo)).ToList();
            }
            else
                return null;
        }

        internal List<LPOthLegalOrgInfoEntity> GetListLPOthLegalOrgInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LPOthLegalOrgInfo))
                                                             .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<LPOthLegalOrgInfo> listLPOthLegalOrgInfo = GetAllLPOthLegalOrgInfo(detachedCriteria);
            if (listLPOthLegalOrgInfo != null && listLPOthLegalOrgInfo.Count > 0)
            {
                return listLPOthLegalOrgInfo.Select(lPOthLegalOrgInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetLPOthLegalOrgInfoEntity(lPOthLegalOrgInfo)).ToList();
            }
            else
                return null;
        }

        internal PCInfoEntity GetPCInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PCInfo))
                                                              .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<PCInfo> listPCInfo = GetAllPCInfo(detachedCriteria);
            if (listPCInfo != null && listPCInfo.Count > 0)
            {
                List<PCInfoEntity> listPCInfoEntity = listPCInfo.Select(pCInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetPCInfoEntity(pCInfo)).ToList();
                return listPCInfoEntity[0];
            }
            else
                return null;
        }

        private List<AccountantsReportInfo> GetAllAccountantsReportInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<AccountantsReportInfo> accountantsReportInfoRepository = new RepositoryImpl<AccountantsReportInfo>(applicationSession);
            return accountantsReportInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<AreaOfLegalPractice> GetAllAreaOfLegalPractice(DetachedCriteria detachedCriteria)
        {
            IRepository<AreaOfLegalPractice> areaOfLegalPracticeRepository = new RepositoryImpl<AreaOfLegalPractice>(applicationSession);
            return areaOfLegalPracticeRepository.GetAll(detachedCriteria).ToList();
        }

        private List<LPOthLegalOrgAddrInfo> GetAllLPOthLegalOrgAddrInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<LPOthLegalOrgAddrInfo> lPOthLegalOrgAddrInfoRepository = new RepositoryImpl<LPOthLegalOrgAddrInfo>(applicationSession);
            return lPOthLegalOrgAddrInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<LPOthLegalOrgInfo> GetAllLPOthLegalOrgInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<LPOthLegalOrgInfo> lPOthLegalOrgInfoRepository = new RepositoryImpl<LPOthLegalOrgInfo>(applicationSession);
            return lPOthLegalOrgInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<PCInfo> GetAllPCInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<PCInfo> pCInfoRepository = new RepositoryImpl<PCInfo>(applicationSession);
            return pCInfoRepository.GetAll(detachedCriteria).ToList();
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

        /// <summary>
        /// Gets the set down info by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        internal SetDownInfoEntity GetSetDownInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SetDownInfo))
                                                              .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<SetDownInfo> listSetDownInfo = GetFromDetachedCriteria<SetDownInfo>(detachedCriteria);
            if (listSetDownInfo != null && listSetDownInfo.Count > 0)
            {
                return listSetDownInfo.Select(setDownInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetSetDownInfoEntity(setDownInfo)).FirstOrDefault();
            }
            else
                return null;
        }

        /// <summary>
        /// Gets the ADMWA info entity by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        internal ADMWAInfoEntity GetADMWAInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<ADMWAInfo>()
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<ADMWAInfo> listADMWAInfo = GetFromDetachedCriteria<ADMWAInfo>(detachedCriteria);

            if (listADMWAInfo != null && listADMWAInfo.Count > 0)
            {
                return listADMWAInfo.Select(aDMWAInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetADMWAInfoEntity(aDMWAInfo)).FirstOrDefault();
            }
            else
                return null;
        }
       


        internal List<PCInfoAccReportEntity> GetListPCInfoAccReportEntity(string pcInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<PCInfoAccReport>()
                         .Add(Expression.Eq("PCInfoId", pcInfoId));
            List<PCInfoAccReport> listPCInfoAccReport = GetFromDetachedCriteria<PCInfoAccReport>(detachedCriteria);
            if (listPCInfoAccReport != null && listPCInfoAccReport.Count > 0)
            {
                return listPCInfoAccReport.Select(pCInfoAccReport => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
                    .SubCaseSpecificMapper.GetPCInfoAccReportEntity(pCInfoAccReport)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<NOCInfoEntity> GetListNOCInfoEntity(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<NOCInfo>()
                        .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<NOCInfo> listNOCInfo = GetFromDetachedCriteria<NOCInfo>(detachedCriteria);
            if (listNOCInfo != null && listNOCInfo.Count > 0)
            {
                return listNOCInfo.Select(nOCInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
                    .SubCaseSpecificMapper.GetNOCInfoEntity(nOCInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<VoteInfoEntity> GetListVoteInfoEntity(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(VoteInfo))
                                                             .Add(Expression.Eq("CaseInfoId", caseInfoId));
            List<VoteInfo> listVoteInfo = GetFromDetachedCriteria<VoteInfo>(detachedCriteria);
            if (listVoteInfo != null && listVoteInfo.Count > 0)
            {
                return listVoteInfo.Select(voteInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
                    .SubCaseSpecificMapper.GetVoteInfoEntity(voteInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<VoteInfoDeltaEntity> GetListVoteInfoDeltaEntity(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(VoteInfoDelta))
                                                             .Add(Expression.Eq("CaseInfoId", caseInfoId));
            List<VoteInfoDelta> listVoteInfoDelta = GetFromDetachedCriteria<VoteInfoDelta>(detachedCriteria);
            if (listVoteInfoDelta != null && listVoteInfoDelta.Count > 0)
            {
                return listVoteInfoDelta.Select(voteInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
                    .SubCaseSpecificMapper.GetVoteInfoDeltaEntity(voteInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DashboardSubCaseMilestoneDetailEntity> GetListDashboardSubCaseMilestoneDetailEntity(long subCaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DashboardSubCaseMilestoneDetail))
                           .Add(Expression.Eq("SubCaseInfoId", subCaseInfoId));

            List<DashboardSubCaseMilestoneDetail> listDashboardSubCaseMilestoneDetail = GetFromDetachedCriteria<DashboardSubCaseMilestoneDetail>(detachedCriteria);

            if (listDashboardSubCaseMilestoneDetail != null && listDashboardSubCaseMilestoneDetail.Count > 0)
            {
                return listDashboardSubCaseMilestoneDetail.Select(dashboardSubCaseMilestoneDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
                    .ObjectMapper.SubCaseSpecificMapper.GetDashboardSubCaseMilestoneDetailEntity(dashboardSubCaseMilestoneDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DashboardSubCaseMilestoneDetailHistoryEntity> GetListDashboardSubCaseMilestoneDetailHistoryEntity(long subCaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DashboardSubCaseMilestoneDetailHistory))
                           .Add(Expression.Eq("SubCaseInfoId", subCaseInfoId));

            List<DashboardSubCaseMilestoneDetailHistory> listDashboardSubCaseMilestoneDetailHistory = GetFromDetachedCriteria<DashboardSubCaseMilestoneDetailHistory>(detachedCriteria);

            if (listDashboardSubCaseMilestoneDetailHistory != null && listDashboardSubCaseMilestoneDetailHistory.Count > 0)
            {
                return listDashboardSubCaseMilestoneDetailHistory.Select(dashboardSubCaseMilestoneDetailHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
                    .ObjectMapper.SubCaseSpecificMapper.GetDashboardSubCaseMilestoneDetailHistoryEntity(dashboardSubCaseMilestoneDetailHistory)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<AreaOfLegalPracticeEntity> GetaAreaOfLegalPracticeEntitySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(AreaOfLegalPractice))
                                                              .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<AreaOfLegalPractice> listAreaOfLegalPractice = GetAllAreaOfLegalPractice(detachedCriteria);
            if (listAreaOfLegalPractice != null && listAreaOfLegalPractice.Count > 0)
            {
                List<AreaOfLegalPracticeEntity> listAreaOfLegalPracticeEntity = listAreaOfLegalPractice.Select(areaOfLegalPractice => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetAreaOfLegalPracticeEntity(areaOfLegalPractice)).ToList();
                return listAreaOfLegalPracticeEntity;
            }
            else
                return null;
        }

        internal void SaveOrUpdateAreaOfLegalPracticeEntity(AreaOfLegalPracticeEntity areaOfLegalPracticeEntity)
        {
            IRepository<AreaOfLegalPractice> iRepository = new RepositoryImpl<AreaOfLegalPractice>(applicationSession);
            iRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetAreaOfLegalPractice(areaOfLegalPracticeEntity));
        }
        #endregion Methods
    }
}