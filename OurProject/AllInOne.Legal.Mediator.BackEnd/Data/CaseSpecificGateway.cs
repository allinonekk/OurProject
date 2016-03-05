#region Header

/*****************************************************************************************************
* Description : This file represents a standard data access gateway for Case specific entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   14/12/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CaseSpecificGateway.cs
// Description: Represents a standard data access gateway for Case specific entities.
// </summary>
// <copyright file= "CaseSpecificGateway.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Class represents a standard data access gateway for Case specific entities.
    /// </summary>
    internal class CaseSpecificGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CaseSpecificGateway));

        /// <summary>
        /// <see cref="ISession"/> instance for Session context.
        /// </summary>
        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseSpecificGateway"/> class.
        /// </summary>
        internal CaseSpecificGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

            //AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.Mapping nHibernateToDomainMapping = new AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.Mapping();
            //nHibernateToDomainMapping.MapAll();

            //AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.Mapping domainToNHibernate = new AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.Mapping();
            //domainToNHibernate.MapAll();
        }

        #endregion Constructors

        #region Methods

        internal void DeleteChargeInfoEntityByObject(ChargeInfoEntity criminalInfoEntity)
        {
            IRepository<ChargeInfo> ChargeInfoRepository = new RepositoryImpl<ChargeInfo>(applicationSession);
            ChargeInfoRepository.Delete(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetChargeInfo(criminalInfoEntity));
        }

        internal void DeleteChargeInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ChargeInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            IRepository<ChargeInfo> ChargeInfoRepository = new RepositoryImpl<ChargeInfo>(applicationSession);
            ChargeInfoRepository.DeleteAll(GetAllChargeInfo(detachedCriteria));
        }

        internal void DeleteCriminalInfoEntityByObject(CriminalInfoEntity criminalInfoEntity)
        {
            IRepository<CriminalInfo> CriminalInfoRepository = new RepositoryImpl<CriminalInfo>(applicationSession);
            CriminalInfoRepository.Delete(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetCriminalInfo(criminalInfoEntity));
        }

        internal void DeleteCriminalInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CriminalInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            IRepository<CriminalInfo> CriminalInfoRepository = new RepositoryImpl<CriminalInfo>(applicationSession);
            CriminalInfoRepository.DeleteAll(GetAllCriminalInfo(detachedCriteria));
        }

        internal void DeleteCriminalOtherOrderInfoEntityByObject(CriminalOtherOrderInfoEntity criminalInfoEntity)
        {
            IRepository<CriminalOtherOrderInfo> CriminalOtherOrderInfoRepository = new RepositoryImpl<CriminalOtherOrderInfo>(applicationSession);
            CriminalOtherOrderInfoRepository.Delete(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetCriminalOtherOrderInfo(criminalInfoEntity));
        }

        internal void DeleteCriminalOtherOrderInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CriminalOtherOrderInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            IRepository<CriminalOtherOrderInfo> CriminalOtherOrderInfoRepository = new RepositoryImpl<CriminalOtherOrderInfo>(applicationSession);
            CriminalOtherOrderInfoRepository.DeleteAll(GetAllCriminalOtherOrderInfo(detachedCriteria));
        }

        internal void DeleteDCACAInfo(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DCACAInfo>()
             .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            Repository<DCACAInfo>().DeleteAll(detachedCriteria);
        }

        internal void DeleteDrugInfoEntityByObject(DrugInfoEntity criminalInfoEntity)
        {
            IRepository<DrugInfo> DrugInfoRepository = new RepositoryImpl<DrugInfo>(applicationSession);
            DrugInfoRepository.Delete(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetDrugInfo(criminalInfoEntity));
        }

        internal void DeleteDrugInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DrugInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            IRepository<DrugInfo> DrugInfoRepository = new RepositoryImpl<DrugInfo>(applicationSession);
            DrugInfoRepository.DeleteAll(GetAllDrugInfo(detachedCriteria));
        }

        internal void DeleteInvestigatingOfficerInfoEntityByObject(InvestigatingOfficerInfoEntity criminalInfoEntity)
        {
            IRepository<InvestigatingOfficerInfo> InvestigatingOfficerInfoRepository = new RepositoryImpl<InvestigatingOfficerInfo>(applicationSession);
            InvestigatingOfficerInfoRepository.Delete(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetInvestigatingOfficerInfo(criminalInfoEntity));
        }

        internal void DeleteInvestigatingOfficerInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(InvestigatingOfficerInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            IRepository<InvestigatingOfficerInfo> InvestigatingOfficerInfoRepository = new RepositoryImpl<InvestigatingOfficerInfo>(applicationSession);
            InvestigatingOfficerInfoRepository.DeleteAll(GetAllInvestigatingOfficerInfo(detachedCriteria));
        }

        internal void DeleteOffenceInfoEntityByObject(OffenceInfoEntity criminalInfoEntity)
        {
            IRepository<OffenceInfo> OffenceInfoRepository = new RepositoryImpl<OffenceInfo>(applicationSession);
            OffenceInfoRepository.Delete(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetOffenceInfo(criminalInfoEntity));
        }

        internal void DeleteOffenceInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(OffenceInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            IRepository<OffenceInfo> OffenceInfoRepository = new RepositoryImpl<OffenceInfo>(applicationSession);
            OffenceInfoRepository.DeleteAll(GetAllOffenceInfo(detachedCriteria));
        }

        internal void DeleteRCriminalLegislationInfoEntityByObject(RCriminalLegislationInfoEntity criminalInfoEntity)
        {
            IRepository<RCriminalLegislationInfo> RCriminalLegislationInfoRepository = new RepositoryImpl<RCriminalLegislationInfo>(applicationSession);
            RCriminalLegislationInfoRepository.Delete(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetRCriminalLegislationInfo(criminalInfoEntity));
        }

        internal void DeleteRCriminalLegislationInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RCriminalLegislationInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            IRepository<RCriminalLegislationInfo> RCriminalLegislationInfoRepository = new RepositoryImpl<RCriminalLegislationInfo>(applicationSession);
            RCriminalLegislationInfoRepository.DeleteAll(GetAllRCriminalLegislationInfo(detachedCriteria));
        }

        internal void DeleteSentenceInfoEntityByObject(SentenceInfoEntity criminalInfoEntity)
        {
            IRepository<SentenceInfo> SentenceInfoRepository = new RepositoryImpl<SentenceInfo>(applicationSession);
            SentenceInfoRepository.Delete(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetSentenceInfo(criminalInfoEntity));
        }

        internal void DeleteSentenceInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SentenceInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            IRepository<SentenceInfo> SentenceInfoRepository = new RepositoryImpl<SentenceInfo>(applicationSession);
            SentenceInfoRepository.DeleteAll(GetAllSentenceInfo(detachedCriteria));
        }

        internal List<AASInfoEntity> GetAASInfo<V>(string fieldName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(AASInfo))
                                                                .Add(Expression.Eq(fieldName, value));

            List<AASInfo> listAASInfo = GetAllAASInfo(detachedCriteria);

            if (listAASInfo != null && listAASInfo.Count > 0)
            {
                return listAASInfo.Select(aasInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetAASInfoEntity(aasInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Method to Get <see cref="RARASInfoEntity"/> based on submissionGroupId.
        /// </summary>
        /// <param name="submissionGroupId">The submissionGroupId.</param>
        /// <returns>Returns <see cref="RARASInfoEntity"/> if exists, else null.</returns>
        internal AASInfoEntity GetAASInfoEntityBySGID(string submissionGroupId)
        {
            AASInfoEntity aASInfoEntity = new AASInfoEntity();
            AASInfo aASInfo = new AASInfo();
            IRepository<AASInfo> aASInfoRepository = new RepositoryImpl<AASInfo>(applicationSession);

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(AASInfo))
                                            .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<AASInfo> listAASInfo = aASInfoRepository.GetAll(detachedCriteria) as List<AASInfo>;
            if (listAASInfo != null && listAASInfo.Count > 0)
            {
                foreach (AASInfo dcACAInfo in listAASInfo)
                {
                    aASInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetAASInfoEntity(dcACAInfo);
                }
            }
            else
            {
                return null;
            }

            return aASInfoEntity;
        }

        internal BillOfSaleInfoEntity GetBillOfSaleInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BillOfSaleInfo))
                                                            .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<BillOfSaleInfo> listBillOfSaleInfo = GetFromDetachedCriteria<BillOfSaleInfo>(detachedCriteria);
            if (listBillOfSaleInfo != null && listBillOfSaleInfo.Count > 0)
            {
                return listBillOfSaleInfo.Select(billOfSaleInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetBillOfSaleInfoEntity(billOfSaleInfo)).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        internal CriminalInfoEntity GetCriminalInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CriminalInfo))
                                                             .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            CriminalInfoEntity criminalInfoEntity = new CriminalInfoEntity();
            CriminalInfo criminalInfo = new CriminalInfo();
            IRepository<CriminalInfo> criminalInfoRepository = new RepositoryImpl<CriminalInfo>(applicationSession);
            List<CriminalInfo> listCriminalInfo = criminalInfoRepository.GetAll(detachedCriteria) as List<CriminalInfo>;
            if (listCriminalInfo != null && listCriminalInfo.Count > 0)
            {
                foreach (CriminalInfo cInfo in listCriminalInfo)
                {
                    criminalInfo = cInfo;
                    criminalInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetCriminalInfoEntity(criminalInfo);
                }
            }
            else
                criminalInfoEntity = null;
            return criminalInfoEntity;
        }

        internal DCACAInfoEntity GetDCACAInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DCACAInfo))
                     .Add(Expression.Eq("SubmissionGroupId", sGID));

            List<DCACAInfo> listDCACAInfo = GetFromDetachedCriteria<DCACAInfo>(detachedCriteria);

            if (listDCACAInfo != null && listDCACAInfo.Count > 0)
            {
                return listDCACAInfo.Select(dCACAInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetDCACAInfoEntity(dCACAInfo)).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        internal List<AASInfoEntity> GetListAASInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(AASInfo))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<AASInfo> listAASInfo = GetAllAASInfo(detachedCriteria);

            if (listAASInfo != null && listAASInfo.Count > 0)
            {
                return listAASInfo.Select(aasInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetAASInfoEntity(aasInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<AASInfoEntity> GetListAASInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(AASInfo))
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<AASInfo> listAASInfo = GetFromDetachedCriteria<AASInfo>(detachedCriteria);
            if (listAASInfo != null && listAASInfo.Count > 0)
            {
                return listAASInfo.Select(aasInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetAASInfoEntity(aasInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<BOTDetailEntity> GetListBOTDetailEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BOTDetails))
                    .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<BOTDetails> listBOTDetails = GetFromDetachedCriteria<BOTDetails>(detachedCriteria);

            if (listBOTDetails != null && listBOTDetails.Count > 0)
            {
                return listBOTDetails.Select(bOTDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetBOTDetails(bOTDetails)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<ChargeInfoEntity> GetListChargeInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ChargeInfo))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<ChargeInfo> listChargeInfo = GetAllChargeInfo(detachedCriteria);
            if (listChargeInfo != null && listChargeInfo.Count > 0)
            {
                return listChargeInfo.Select(chargeInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetChargeInfoEntity(chargeInfo)).ToList();
            }
            else
                return null;
        }

        internal List<CriminalInfoEntity> GetListCriminalInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CriminalInfo))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<CriminalInfo> listCriminalInfo = GetAllCriminalInfo(detachedCriteria);
            if (listCriminalInfo != null && listCriminalInfo.Count > 0)
            {
                return listCriminalInfo.Select(criminalInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetCriminalInfoEntity(criminalInfo)).ToList();
            }
            else
                return null;
        }

        internal List<CriminalOtherOrderInfoEntity> GetListCriminalOtherOrderInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CriminalOtherOrderInfo))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<CriminalOtherOrderInfo> listCriminalOtherOrderInfo = GetAllCriminalOtherOrderInfo(detachedCriteria);
            if (listCriminalOtherOrderInfo != null && listCriminalOtherOrderInfo.Count > 0)
            {
                return listCriminalOtherOrderInfo.Select(criminalOtherOrderInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetCriminalOtherOrderInfoEntity(criminalOtherOrderInfo)).ToList();
            }
            else
                return null;
        }

        internal List<DrugInfoEntity> GetListDrugInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DrugInfo))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<DrugInfo> listDrugInfo = GetAllDrugInfo(detachedCriteria);
            if (listDrugInfo != null && listDrugInfo.Count > 0)
            {
                return listDrugInfo.Select(drugInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetDrugInfoEntity(drugInfo)).ToList();
            }
            else
                return null;
        }

        internal List<InvestigatingOfficerInfoEntity> GetListInvestigatingOfficerInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(InvestigatingOfficerInfo))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<InvestigatingOfficerInfo> listInvestigatingOfficerInfo = GetAllInvestigatingOfficerInfo(detachedCriteria);
            if (listInvestigatingOfficerInfo != null && listInvestigatingOfficerInfo.Count > 0)
            {
                return listInvestigatingOfficerInfo.Select(investigatingOfficerInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetInvestigatingOfficerInfoEntity(investigatingOfficerInfo)).ToList();
            }
            else
                return null;
        }

        internal List<OffenceInfoEntity> GetListOffenceInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(OffenceInfo))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<OffenceInfo> listOffenceInfo = GetAllOffenceInfo(detachedCriteria);
            if (listOffenceInfo != null && listOffenceInfo.Count > 0)
            {
                return listOffenceInfo.Select(offenceInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetOffenceInfoEntity(offenceInfo)).ToList();
            }
            else
                return null;
        }

        internal List<OSInfoEntity> GetListOSInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(OSInfo))
                     .Add(Expression.Eq("SubmissionGroupId", sGID));

            List<OSInfo> listOSInfo = GetFromDetachedCriteria<OSInfo>(detachedCriteria);

            if (listOSInfo != null && listOSInfo.Count > 0)
            {
                return listOSInfo.Select(oSInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetOSInfoEntity(oSInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<OSJudicialManagerDetailsEntity> GetListOSJudicialManagerDetailEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(OSJudicialManagerDetails))
               .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<OSJudicialManagerDetails> listOSJudicialManagerDetails = GetFromDetachedCriteria<OSJudicialManagerDetails>(detachedCriteria);

            if (listOSJudicialManagerDetails != null && listOSJudicialManagerDetails.Count > 0)
            {
                return listOSJudicialManagerDetails.Select(oSJudicialManagerDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetOSJudicialManagerDetailEntity(oSJudicialManagerDetails)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<OSMADetailsEntity> GetListOSMADetailsEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(OSMADetails))
                  .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<OSMADetails> listOSMADetails = GetFromDetachedCriteria<OSMADetails>(detachedCriteria);

            if (listOSMADetails != null && listOSMADetails.Count > 0)
            {
                return listOSMADetails.Select(oSMADetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetOSMADetailsEntity(oSMADetails)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<PBBeneficiaryDetailEntity> GetListPBBeneficiaryBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PBBeneficiaryDetails))
                  .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<PBBeneficiaryDetails> listPBBeneficiaryDetails = GetFromDetachedCriteria<PBBeneficiaryDetails>(detachedCriteria);

            if (listPBBeneficiaryDetails != null && listPBBeneficiaryDetails.Count > 0)
            {
                return listPBBeneficiaryDetails.Select(pBBeneficiaryDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetPBBeneficiaryDetailEntity(pBBeneficiaryDetails)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<PBCoAdminDetailEntity> GetListPBCoAdminDetailBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PBCoAdminDetails))
                  .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<PBCoAdminDetails> listPBCoAdminDetails = GetFromDetachedCriteria<PBCoAdminDetails>(detachedCriteria);

            if (listPBCoAdminDetails != null && listPBCoAdminDetails.Count > 0)
            {
                return listPBCoAdminDetails.Select(pBCoAdminDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetPBCoAdminDetailEntity(pBCoAdminDetails)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<PBExecutorDetailEntity> GetListPBExecutorBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PBExecutorDetails))
                 .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<PBExecutorDetails> listPBExecutorDetails = GetFromDetachedCriteria<PBExecutorDetails>(detachedCriteria);

            if (listPBExecutorDetails != null && listPBExecutorDetails.Count > 0)
            {
                return listPBExecutorDetails.Select(pBExecutorDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetPBExecutorDetailEntity(pBExecutorDetails)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<PBPrevGrantDetailEntity> GetListPBPrevGrantDetail(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PBPrevGrantDetails))
                   .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<PBPrevGrantDetails> listPBPrevGrantDetails = GetFromDetachedCriteria<PBPrevGrantDetails>(detachedCriteria);

            if (listPBPrevGrantDetails != null && listPBPrevGrantDetails.Count > 0)
            {
                return listPBPrevGrantDetails.Select(pBPrevGrantDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetPBPrevGrantDetailEntity(pBPrevGrantDetails)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<PBWillCodicilEntity> GetListPBWillCodicil(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PBWillCodicil))
                   .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<PBWillCodicil> listPBWillCodicil = GetFromDetachedCriteria<PBWillCodicil>(detachedCriteria);

            if (listPBWillCodicil != null && listPBWillCodicil.Count > 0)
            {
                return listPBWillCodicil.Select(pBWillCodicil => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetPBWillCodicilEntity(pBWillCodicil)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RCriminalLegislationInfoEntity> GetListRCriminalLegislationInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RCriminalLegislationInfo))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<RCriminalLegislationInfo> listRCriminalLegislationInfo = GetAllRCriminalLegislationInfo(detachedCriteria);
            if (listRCriminalLegislationInfo != null && listRCriminalLegislationInfo.Count > 0)
            {
                return listRCriminalLegislationInfo.Select(rCriminalLegislationInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetRCriminalLegislationInfoEntity(rCriminalLegislationInfo)).ToList();
            }
            else
                return null;
        }

        internal List<SentenceInfoEntity> GetListSentenceInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SentenceInfo))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<SentenceInfo> listSentenceInfo = GetAllSentenceInfo(detachedCriteria);
            if (listSentenceInfo != null && listSentenceInfo.Count > 0)
            {
                return listSentenceInfo.Select(sentenceInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetSentenceInfoEntity(sentenceInfo)).ToList();
            }
            else
                return null;
        }

        internal List<TaxationClaimEntity> GetListTaxationClaimEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(TaxationClaim))
                    .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<TaxationClaim> listTaxationClaim = GetFromDetachedCriteria<TaxationClaim>(detachedCriteria);

            if (listTaxationClaim != null && listTaxationClaim.Count > 0)
            {
                return listTaxationClaim.Select(taxationClaim => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetTaxationClaimEntity(taxationClaim)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<WOEMOMSCTInfoEntity> GetListWOEMOMSCTInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WOEMOMSCTInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            List<WOEMOMSCTInfo> listWOEMOMSCTInfo = GetAllWOEMOMSCTInfo(detachedCriteria);

            if (listWOEMOMSCTInfo != null && listWOEMOMSCTInfo.Count > 0)
            {
                return listWOEMOMSCTInfo.Select(woeMOMSCTInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetWOEMOMSCTInfoEntity(woeMOMSCTInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal OSInfoEntity GetOSInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(OSInfo))
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<OSInfo> listOSInfo = GetAllOSInfoEntity(detachedCriteria).ToList();
            if (listOSInfo != null && listOSInfo.Count > 0)
            {
                List<OSInfoEntity> listOsInfoEntity = listOSInfo.Select(oSInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetOSInfoEntity(oSInfo)).ToList();
                return listOsInfoEntity[0];
            }
            else

                return null;
        }

        internal ProbateInfoEntity GetProbateInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ProbateInfo))
                  .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<ProbateInfo> listProbateInfo = GetFromDetachedCriteria<ProbateInfo>(detachedCriteria);

            if (listProbateInfo != null && listProbateInfo.Count > 0)
            {
                return listProbateInfo.Select(probateInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetProbateInfoEntity(probateInfo)).ToList()[0]; //TODO: Need to replace using FindOne
            }
            else
            {
                return null;
            }
        }

        internal List<SentenceCriminalOrderInfoEntity> GetSentenceCriminalOrderInfoEntity(string SGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SentenceCriminalOrderInfo))
                     .Add(Expression.Eq("SubmissionGroupId", SGID));

            List<SentenceCriminalOrderInfo> listSentenceCriminalOrderInfo = GetFromDetachedCriteria<SentenceCriminalOrderInfo>(detachedCriteria);

            if (listSentenceCriminalOrderInfo != null && listSentenceCriminalOrderInfo.Count > 0)
            {
                return listSentenceCriminalOrderInfo.Select(sentenceCriminalOrderInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetSentenceCriminalOrderInfoEntity(sentenceCriminalOrderInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal TaxationInfoEntity GetTaxationInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(TaxationInfo))
                    .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<TaxationInfo> listTaxationInfo = GetFromDetachedCriteria<TaxationInfo>(detachedCriteria);

            if (listTaxationInfo != null && listTaxationInfo.Count > 0)
            {
                return listTaxationInfo.Select(taxationInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetTaxationInfoEntity(taxationInfo)).ToList()[0];
            }
            else
            {
                return null;
            }
        }

        internal WOEMOMSCTInfoEntity GetWOEMOMSCTInfoEntity(string woeMOMSCTInfoId)
        {
            IRepository<WOEMOMSCTInfo> mCWOEMOMSCTInfoRepository = new RepositoryImpl<WOEMOMSCTInfo>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetWOEMOMSCTInfoEntity(mCWOEMOMSCTInfoRepository.Get(woeMOMSCTInfoId));
        }

        internal WOEMOMSCTInfoEntity GetWOEMOMSCTInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WOEMOMSCTInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            List<WOEMOMSCTInfo> listWOEMOMSCTInfo = GetAllWOEMOMSCTInfo(detachedCriteria);
            WOEMOMSCTInfoEntity woeMOMSCTInfoEntity = new WOEMOMSCTInfoEntity();

            if (listWOEMOMSCTInfo != null && listWOEMOMSCTInfo.Count > 0)
            {
                foreach (WOEMOMSCTInfo woeMOMSCTInfo in listWOEMOMSCTInfo)
                {
                    woeMOMSCTInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetWOEMOMSCTInfoEntity(woeMOMSCTInfo);
                }

                return woeMOMSCTInfoEntity;
            }
            else
            {
                return null;
            }
        }

        internal WOSInfoEntity GetWOSInfoEntityBySGID(string sGID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(WOSInfo))
               .Add(Expression.Eq("SubmissionGroupId", sGID));

            List<WOSInfo> listWOSInfo = GetFromDetachedCriteria<WOSInfo>(detachedCriteria);

            if (listWOSInfo != null && listWOSInfo.Count > 0)
            {
                return listWOSInfo.Select(wOSInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetWOSInfoEntity(wOSInfo)).ToList()[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the domain object and save it.
        /// </summary>
        /// <param name="entityToSave">The domain object to be saved.<param>
        /// <returns></returns>
        internal void SaveOrUpdateEntity<T>(T entityToSave)
        {
            IRepository<T> caseSpecificRepository = new RepositoryImpl<T>(applicationSession);
            caseSpecificRepository.SaveOrUpdate(entityToSave);
        }

        /// <summary>
        /// Passes the domain object and save it.
        /// </summary>
        /// <param name="entityToSave">The domain object to be saved.<param>
        /// <returns></returns>
        internal void SaveOrUpdateInMemoryEntity<T>(T entityToSave)
        {
            IRepository<T> caseSpecificRepository = new RepositoryImpl<T>(applicationSession);
            caseSpecificRepository.SaveOrUpdateCopy(entityToSave);
        }

        private List<AASInfo> GetAllAASInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<AASInfo> oSInfoRepository = new RepositoryImpl<AASInfo>(applicationSession);
            return oSInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<ChargeInfo> GetAllChargeInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<ChargeInfo> chargeInfoRepository = new RepositoryImpl<ChargeInfo>(applicationSession);
            return chargeInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<CriminalInfo> GetAllCriminalInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<CriminalInfo> criminalInfoRepository = new RepositoryImpl<CriminalInfo>(applicationSession);
            return criminalInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<CriminalOtherOrderInfo> GetAllCriminalOtherOrderInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<CriminalOtherOrderInfo> criminalOtherOrderInfoRepository = new RepositoryImpl<CriminalOtherOrderInfo>(applicationSession);
            return criminalOtherOrderInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<DrugInfo> GetAllDrugInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<DrugInfo> drugInfoRepository = new RepositoryImpl<DrugInfo>(applicationSession);
            return drugInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<InvestigatingOfficerInfo> GetAllInvestigatingOfficerInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<InvestigatingOfficerInfo> investigatingOfficerInfoRepository = new RepositoryImpl<InvestigatingOfficerInfo>(applicationSession);
            return investigatingOfficerInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<OffenceInfo> GetAllOffenceInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<OffenceInfo> offenceInfoRepository = new RepositoryImpl<OffenceInfo>(applicationSession);
            return offenceInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<OSInfo> GetAllOSInfoEntity(DetachedCriteria detachedCriteria)
        {
            IRepository<OSInfo> oSInfoRepository = new RepositoryImpl<OSInfo>(applicationSession);
            return oSInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<RCriminalLegislationInfo> GetAllRCriminalLegislationInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<RCriminalLegislationInfo> rCriminalLegislationInfoRepository = new RepositoryImpl<RCriminalLegislationInfo>(applicationSession);
            return rCriminalLegislationInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<SentenceInfo> GetAllSentenceInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<SentenceInfo> sentenceInfoRepository = new RepositoryImpl<SentenceInfo>(applicationSession);
            return sentenceInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private List<WOEMOMSCTInfo> GetAllWOEMOMSCTInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<WOEMOMSCTInfo> woeRepository = new RepositoryImpl<WOEMOMSCTInfo>(applicationSession);
            return woeRepository.GetAll(detachedCriteria).ToList();
        }

        private List<T> GetFromDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll(detachedCriteria) as List<T>;
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



        internal DCACAOriginatingCasePartyInfoEntity GetDCACAOriginatingCasePartyInfo(string dcpId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DCACAOriginatingCasePartyInfo>()
                .Add(Expression.Eq("DCPID", dcpId));

            List<DCACAOriginatingCasePartyInfo> listDCACAOriginatingCasePartyInfo = GetFromDetachedCriteria<DCACAOriginatingCasePartyInfo>(detachedCriteria);
            if (listDCACAOriginatingCasePartyInfo != null && listDCACAOriginatingCasePartyInfo.Count > 0)
            {
                return listDCACAOriginatingCasePartyInfo.Select(dCACAOriginatingCasePartyInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
                    .CaseSpecificMapper.GetDCACAOriginatingCasePartyInfoEntity(dCACAOriginatingCasePartyInfo)).FirstOrDefault();
            }
            else
            {
                return null;
            }

        }


        internal void DeleteSentenceCriminalOrderInfo(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<SentenceCriminalOrderInfo>()
                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            IRepository<SentenceCriminalOrderInfo> sentenceCriminalOrderInfoRepository = new RepositoryImpl<SentenceCriminalOrderInfo>(applicationSession);
            sentenceCriminalOrderInfoRepository.DeleteAll(detachedCriteria);
        }

        internal RASInfoEntity GetRASInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RASInfo))
                           .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<RASInfo> listRASInfo = GetFromDetachedCriteria<RASInfo>(detachedCriteria);

            if (listRASInfo != null && listRASInfo.Count > 0)
            {
                return listRASInfo.Select(rASInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetRASInfoEntity(rASInfo)).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        internal List<DCACAOriginatingCasePartyInfoEntity> GetListDCACAOriginatingCasePartyInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DCACAOriginatingCasePartyInfo))
                          .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<DCACAOriginatingCasePartyInfo> listDCACAOriginatingCasePartyInfo = GetFromDetachedCriteria<DCACAOriginatingCasePartyInfo>(detachedCriteria);

            if (listDCACAOriginatingCasePartyInfo != null && listDCACAOriginatingCasePartyInfo.Count > 0)
            {
                return listDCACAOriginatingCasePartyInfo.Select(dCACAOriginatingCasePartyInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetDCACAOriginatingCasePartyInfoEntity(dCACAOriginatingCasePartyInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<PBPADetailEntity> GetListPBPADetailEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PBPADetails))
                           .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<PBPADetails> listPBPADetails = GetFromDetachedCriteria<PBPADetails>(detachedCriteria);

            if (listPBPADetails != null && listPBPADetails.Count > 0)
            {
                return listPBPADetails.Select(pBPADetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
                    .ObjectMapper.CaseSpecificMapper.GetPBPADetailEntity(pBPADetails)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<PBSupNExmEntity> GetListPBSupNExmEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PBSupNExm))
                           .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<PBSupNExm> listPBSupNExm = GetFromDetachedCriteria<PBSupNExm>(detachedCriteria);

            if (listPBSupNExm != null && listPBSupNExm.Count > 0)
            {
                return listPBSupNExm.Select(pBSupNExm => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
                    .ObjectMapper.CaseSpecificMapper.GetPBSupNExmEntity(pBSupNExm)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<PBAdminBondEntity> GetListPBAdminBondEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PBAdminBond))
                           .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<PBAdminBond> lisPBAdminBond = GetFromDetachedCriteria<PBAdminBond>(detachedCriteria);

            if (lisPBAdminBond != null && lisPBAdminBond.Count > 0)
            {
                return lisPBAdminBond.Select(pBAdminBond => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
                    .ObjectMapper.CaseSpecificMapper.GetPBAdminBondEntity(pBAdminBond)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<CaseRegisterEntity> GetListCaseRegisterEntity(long caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseRegister))
                           .Add(Expression.Eq("CaseInfoId", caseInfoId));

            List<CaseRegister> lisCaseRegister = GetFromDetachedCriteria<CaseRegister>(detachedCriteria);

            if (lisCaseRegister != null && lisCaseRegister.Count > 0)
            {
                return lisCaseRegister.Select(caseRegister => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
                    .ObjectMapper.CaseSpecificMapper.GetCaseRegisterEntity(caseRegister)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<CaseRegisterHistoryEntity> GetListCaseRegisterHistoryEntity(long caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaseRegisterHistory))
                           .Add(Expression.Eq("CaseInfoId", caseInfoId));

            List<CaseRegisterHistory> lisCaseRegisterHistory = GetFromDetachedCriteria<CaseRegisterHistory>(detachedCriteria);

            if (lisCaseRegisterHistory != null && lisCaseRegisterHistory.Count > 0)
            {
                return lisCaseRegisterHistory.Select(caseRegisterHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
                    .ObjectMapper.CaseSpecificMapper.GetCaseRegisterHistoryEntity(caseRegisterHistory)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DashboardCaseMilestoneDetailEntity> GetListDashboardCaseMilestoneDetailEntity(string caseRegisterId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DashboardCaseMilestoneDetail))
                           .Add(Expression.Eq("CaseRegisterId", caseRegisterId));

            List<DashboardCaseMilestoneDetail> listDashboardCaseMilestoneDetail = GetFromDetachedCriteria<DashboardCaseMilestoneDetail>(detachedCriteria);

            if (listDashboardCaseMilestoneDetail != null && listDashboardCaseMilestoneDetail.Count > 0)
            {
                return listDashboardCaseMilestoneDetail.Select(dashboardCaseMilestoneDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
                    .ObjectMapper.CaseSpecificMapper.GetDashboardCaseMilestoneDetailEntity(dashboardCaseMilestoneDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DashboardCaseMilestoneDetailHistoryEntity> GetListDashboardCaseMilestoneDetailHistoryEntity(string caseRegisterId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DashboardCaseMilestoneDetailHistory))
                           .Add(Expression.Eq("CaseRegisterId", caseRegisterId));

            List<DashboardCaseMilestoneDetailHistory> listDashboardCaseMilestoneDetailHistory = GetFromDetachedCriteria<DashboardCaseMilestoneDetailHistory>(detachedCriteria);

            if (listDashboardCaseMilestoneDetailHistory != null && listDashboardCaseMilestoneDetailHistory.Count > 0)
            {
                return listDashboardCaseMilestoneDetailHistory.Select(dashboardCaseMilestoneDetailHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
                    .ObjectMapper.CaseSpecificMapper.GetDashboardCaseMilestoneDetailHistoryEntity(dashboardCaseMilestoneDetailHistory)).ToList();
            }
            else
            {
                return null;
            }
        }
        internal CaveatAAInfoEntity GetCaveatAAInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaveatAAInfo))
                            .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<CaveatAAInfo> listCaveatAAInfo = GetFromDetachedCriteria<CaveatAAInfo>(detachedCriteria);

            if (listCaveatAAInfo != null && listCaveatAAInfo.Count > 0)
            {
                return listCaveatAAInfo.Select(caveatAAInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
                    .ObjectMapper.CaseSpecificMapper.GetCaveatAAInfoEntity(caveatAAInfo)).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        internal CaveatInfoEntity GetCaveatInfoEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CaveatInfo))
                              .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<CaveatInfo> listCaveatInfo = GetFromDetachedCriteria<CaveatInfo>(detachedCriteria);

            if (listCaveatInfo != null && listCaveatInfo.Count > 0)
            {
                return listCaveatInfo.Select(caveatInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
                    .ObjectMapper.CaseSpecificMapper.GetCaveatInfoEntity(caveatInfo)).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        internal List<JMChecklistInfoEntity> GetListJMChecklistInfo(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<JMChecklistInfo>()
                .Add(Expression.Eq("DocId", docId));
            List<JMChecklistInfo> listJMChecklistInfo = GetFromDetachedCriteria<JMChecklistInfo>(detachedCriteria);
            if (listJMChecklistInfo != null && listJMChecklistInfo.Count > 0)
            {
                return listJMChecklistInfo.Select(jMChecklistInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetJMChecklistInfoEntity(jMChecklistInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<JMOtherInfoEntity> GetListJMOtherInfo(string CaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<JMOtherInfo>()
                .Add(Expression.Eq("caseinfoid", Convert.ToInt64(CaseInfoId)));
            List<JMOtherInfo> listJMOtherInfo = GetFromDetachedCriteria<JMOtherInfo>(detachedCriteria);
            if (listJMOtherInfo != null && listJMOtherInfo.Count > 0)
            {
                return listJMOtherInfo.Select(jMOtherInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetJMOtherInfoEntity(jMOtherInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DirectionDetailsEntity> GetListDirectionDetailsByCaseInfoId(string Caseinfoid)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DirectionDetails>();
            detachedCriteria.Add(Expression.Eq("CaseInfoID", Convert.ToInt64(Caseinfoid)));
            //if (!optSubCaseinfoId.Equals("0"))
            //    detachedCriteria.Add(Expression.Eq("SubCaseInfoID", Convert.ToInt64(optSubCaseinfoId)));
            //if (!optHrgId.Equals("0"))
            //    detachedCriteria.Add(Expression.Eq("HRGID", Convert.ToInt64(optHrgId)));
            //if (!optDocId.Equals("DOCID"))
            //    detachedCriteria.Add(Expression.Eq("DocID", optDocId));
            //if (!optDirCode.Equals("DIRCode"))
            //    detachedCriteria.Add(Expression.Eq("DirCode", optDirCode));

            List<DirectionDetails> listDirectionDetails = GetFromDetachedCriteria<DirectionDetails>(detachedCriteria);
            if (listDirectionDetails != null && listDirectionDetails.Count > 0)
            {
                return listDirectionDetails.Select(directionDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetDirectionDetailsEntity(directionDetails)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<DirectionDetailsEntity> GetAllDirectionDetails()
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<DirectionDetails>();
            List<DirectionDetails> listDirectionDetails = GetFromDetachedCriteria<DirectionDetails>(detachedCriteria);
            if (listDirectionDetails != null && listDirectionDetails.Count > 0)
            {
                return listDirectionDetails.Select(directionDetails => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetDirectionDetailsEntity(directionDetails)).ToList();
            }
            else
            {
                return null;
            }
        }
        #endregion Methods
    }
}