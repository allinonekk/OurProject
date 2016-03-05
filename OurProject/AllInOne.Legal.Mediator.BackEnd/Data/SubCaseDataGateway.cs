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
*   16/12/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CaseSpecificGateway.cs
// Description: Represents a standard data access gateway for Case specific entities.
// </summary>
// <copyright file= "CaseSpecificDataGateway.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCaseData;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Class represents a standard data access gateway for Case specific entities.
    /// </summary>
    internal class SubCaseDataGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SubCaseDataGateway));

        /// <summary>
        /// <see cref="ISession"/> instance for Session context.
        /// </summary>
        private ISession applicationSession;

        /// <summary>
        /// <see cref="GenericGateway"/> instance.
        /// </summary>
        private GenericGateway genericGateway;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseSpecificGateway"/> class.
        /// </summary>
        internal SubCaseDataGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

            this.genericGateway = new GenericGateway();
            //AllInOne.Legal.DataMapper.FrontEnd.NHibernateToDomain.Mapping nHibernateToDomainMapping = new AllInOne.Legal.DataMapper.FrontEnd.NHibernateToDomain.Mapping();
            //nHibernateToDomainMapping.MapAll();

            //AllInOne.Legal.DataMapper.FrontEnd.DomainToNHibernate.Mapping domainToNHibernate = new AllInOne.Legal.DataMapper.FrontEnd.DomainToNHibernate.Mapping();
            //domainToNHibernate.MapAll();
        }

        #endregion Constructors

        #region Methods

        internal ISubCaseTypeInfo GetPracticeOfCertificateDataBySGID(string submissionGroupId)
        {
            PracticingCertificateData practicingCertificateData = null;
            try
            {
                practicingCertificateData = new PracticingCertificateData();

                CommonGateway commonGateway = new CommonGateway();
                SubCaseSpecificGateway subCaseSpecificGateway = new SubCaseSpecificGateway();

                practicingCertificateData.PCInfoEntity = subCaseSpecificGateway.GetPCInfoEntityBySGID(submissionGroupId);
                if (practicingCertificateData.PCInfoEntity != null)
                {
                    practicingCertificateData.ListPCInfoAccReportEntity = subCaseSpecificGateway.GetListPCInfoAccReportEntity(practicingCertificateData.PCInfoEntity.PCInfoId);
                }
                practicingCertificateData.ListAccountantsReportInfo = subCaseSpecificGateway.GetListAccountantsReportInfoBySGID(submissionGroupId);
                practicingCertificateData.ListAreaOfLegalPractice = subCaseSpecificGateway.GetListAreaOfLegalPracticeBySGID(submissionGroupId);
                practicingCertificateData.ListEmploymentInfo = commonGateway.GetListEmploymentInfoBySGID(submissionGroupId);
                practicingCertificateData.ListLPOthLegalOrgAddrInfo = subCaseSpecificGateway.GetListLPOthLegalOrgAddrInfoBySGID(submissionGroupId);
                practicingCertificateData.ListLPOthLegalOrgInfoEntity = subCaseSpecificGateway.GetListLPOthLegalOrgInfoBySGID(submissionGroupId);
                practicingCertificateData.ListPCConditionInfoEntity = commonGateway.GetListPCConditionBySGID(submissionGroupId);
                //practicingCertificateData.ListQualificationInfoEntity = commonGateway.GetListQualificationInfoBySGID(submissionGroupId);
                practicingCertificateData.ListTravelPassInfoEntity = commonGateway.GetListTravelPassInfoBySGID(submissionGroupId);
                practicingCertificateData.ListDegreeInfoEntity = commonGateway.GetListDegreeInfoBySGID(submissionGroupId);
                practicingCertificateData.ListLegalExperienceInfoEntity = commonGateway.GetListLegalExperienceInfoBySGID(submissionGroupId);
                practicingCertificateData.ListDocAppProcessByExAgencyEntity = commonGateway.GetListDocAppProcessByExAgencyBySGID(submissionGroupId);
                practicingCertificateData.ListForeignLPSolicitorRegEntity = commonGateway.GetListForeignLPSolicitorRegEntityBySGID(submissionGroupId);
                practicingCertificateData.ListNOCInfoEntity = subCaseSpecificGateway.GetListNOCInfoEntity(submissionGroupId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPracticeOfCertificateDataBySGId", ex);
                throw;
            }
            return practicingCertificateData;
        }

        internal ISubCaseTypeInfo GetSetDownDataBySGID(string submissionGroupId)
        {
            SetDownData setDownData = new SetDownData();
            try
            {
                SubCaseSpecificGateway subCaseSpecificGateway = new SubCaseSpecificGateway();
                SubsequentGateway subsequentGateway=new SubsequentGateway();
                CommonGateway commonGateway=new CommonGateway();

                setDownData.SetDownInfo = subCaseSpecificGateway.GetSetDownInfoBySGID(submissionGroupId);
                setDownData.PaymentHRGDatesDocDetailEntity = subsequentGateway.GetPaymentHRGDatesDocDetailBySGID(submissionGroupId);
                setDownData.ListRefOrderDetailEntity = commonGateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSetDownDataBySGID", ex);
                throw;
            }
            return setDownData;
        }

        internal ISubCaseTypeInfo GetSummonsDataBySGID(string submissionGroupId)
        {
            SummonsData summonsData = new SummonsData();
            try
            {
                CommonGateway commonGateway = new CommonGateway();

                summonsData.ListNatureOfApplicationEntity = commonGateway.GetListNatureOfApplicationEntityBySGID(submissionGroupId);
                summonsData.ListPrayerEntity = commonGateway.GetListPrayerEntityBySGID(submissionGroupId);
                summonsData.ListRefOrderDetailEntity = commonGateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSummonsDataBySGID", ex);
                throw;
            }
            return summonsData;
        }

        internal ISubCaseTypeInfo GetWarrantOfArrestDataBySGID(string submissionGroupId)
        {
            WarrantOfArrestData warrantOfArrestData = new WarrantOfArrestData();
            try
            {
                CommonGateway commonGateway = new CommonGateway();

                warrantOfArrestData.ADMWAInfo = GetADMWAInfoBySGID(submissionGroupId);
                warrantOfArrestData.ListRefCaveatCaseEntity = commonGateway.GetListRefCaveatCaseEntityBySGID(submissionGroupId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWarrantOfArrestDataBySGID", ex);
                throw;
            }
            return warrantOfArrestData as ISubCaseTypeInfo;
        }

        internal ISubCaseTypeInfo GetWOEDataBySGID(string SGID)
        {
            WOEData woeData = new WOEData();
            try
            {
                CaseSpecificGateway caseSpecificgateway = new CaseSpecificGateway();
                CommonGateway commonGateway = new CommonGateway();
                SubsequentGateway subsequentGateway = new SubsequentGateway();
                DocumentGateway docGateway = new DocumentGateway();

                woeData.WOEInfoEntity = subsequentGateway.GetWOEInfoEntityBySGID(SGID);
                woeData.ListWOEMOMSCTInfoEntity = caseSpecificgateway.GetListWOEMOMSCTInfoEntityBySGID(SGID);
                woeData.ListWOEExecutionAddressEntity = commonGateway.GetListWOEExecutionAddressBySGID(SGID);
                woeData.ListWOENCPEInfoEntity = subsequentGateway.GetListWOENCPEInfoEntityBySGID(SGID);
                woeData.ListWOENECPEInfoEntity = subsequentGateway.GetListWOENECPEInfoEntityBySGID(SGID);
                woeData.ListRefOrderDetailEntity = commonGateway.GetListRefOrderDetailEntityBySGID(SGID);

                List<DocumentInfoEntity> listDocInfo = docGateway.GetListDocumentInfoBySubmissinId(SGID);

                woeData.ListWOERequestEntity = subsequentGateway.GetListWOERequestBySubmissionGroupId(SGID);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWarrantOfArrestDataBySGID", ex);
                throw;
            }
            return woeData as ISubCaseTypeInfo;
        }

        /// <summary>
        /// Saves the or update case data.
        /// </summary>
        /// <param name="iCaseType">Type of the i case.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        internal void SaveOrUpdateSubCaseData(ISubCaseTypeInfo iSubCaseTypeInfo, bool isCopy)
        {
            if (iSubCaseTypeInfo.GetType().Equals(typeof(FamilyRelationChamberData)))
                SaveOrUpdateFamilyRelationChamberData(iSubCaseTypeInfo as FamilyRelationChamberData, isCopy);

            else if (iSubCaseTypeInfo.GetType().Equals(typeof(WarrantOfArrestData)))
                SaveOrUpdateWarrantOfArrestData(iSubCaseTypeInfo as WarrantOfArrestData, isCopy);

            else if (iSubCaseTypeInfo.GetType().Equals(typeof(SetDownData)))
                SaveOrUpdateSetDownData(iSubCaseTypeInfo as SetDownData, isCopy);

            else if (iSubCaseTypeInfo.GetType().Equals(typeof(RegistrarsAppealsData)))
                SaveOrUpdateRegistrarsAppealsData(iSubCaseTypeInfo as RegistrarsAppealsData, isCopy);

            else if (iSubCaseTypeInfo.GetType().Equals(typeof(SummonsData)))
                SaveOrUpdateSummonsData(iSubCaseTypeInfo as SummonsData, isCopy);

            else if (iSubCaseTypeInfo.GetType().Equals(typeof(PracticingCertificateData)))
                SaveOrUpdatePracticingCertificateData(iSubCaseTypeInfo as PracticingCertificateData, isCopy);

            else if (iSubCaseTypeInfo.GetType().Equals(typeof(WOEData)))
                SaveOrUpdateWOEData(iSubCaseTypeInfo as WOEData, isCopy);

            else if (iSubCaseTypeInfo.GetType().Equals(typeof(ServiceOfDocData)))
                SaveOrUpdateServiceOfDocData(iSubCaseTypeInfo as ServiceOfDocData, isCopy);

            else
                throw new ArgumentNullException("Object Sent was Wrong");
        }

        private List<ADMWAInfo> GetADMWAInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<ADMWAInfo> rARASInfoRepository = new RepositoryImpl<ADMWAInfo>(applicationSession);
            return rARASInfoRepository.GetAll(detachedCriteria).ToList();
        }

        private ADMWAInfoEntity GetADMWAInfoBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ADMWAInfo))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));

            List<ADMWAInfo> listADMWAInfo = GetADMWAInfo(detachedCriteria);
            if (listADMWAInfo != null && listADMWAInfo.Count > 0)
            {
                List<ADMWAInfoEntity> listADMInfoEntity = listADMWAInfo.Select(aDMInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetADMWAInfoEntity(aDMInfo)).ToList();
                return listADMInfoEntity[0];
            }
            else
                return null;
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
        /// Saves the or update family relation chamber data.
        /// </summary>
        /// <param name="familyRelationChamberData">The family relation chamber data.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        private void SaveOrUpdateFamilyRelationChamberData(FamilyRelationChamberData familyRelationChamberData, bool isCopy)
        {
            if (familyRelationChamberData.DivorceInfoEntity != null)
            {
                DivorceInfo divorceInfo = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDivorceInfo(familyRelationChamberData.DivorceInfoEntity);
                SaveOrUpdateData(divorceInfo, isCopy);
            }
            if (familyRelationChamberData.ListChildInfoEntity != null && familyRelationChamberData.ListChildInfoEntity.Count > 0)
            {
                List<ChildInfo> listChildInfo = familyRelationChamberData.ListChildInfoEntity.Select(childInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetChildInfo(childInfo)).ToList();
                foreach (ChildInfo childInfo in listChildInfo)
                {
                    SaveOrUpdateData(childInfo, isCopy);
                }
            }
            if (familyRelationChamberData.ListGroundInfo != null && familyRelationChamberData.ListGroundInfo.Count > 0)
            {
                List<GroundInfo> listGroundInfo = familyRelationChamberData.ListGroundInfo.Select(groundInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetGroundInfo(groundInfo)).ToList();
                foreach (GroundInfo groundInfo in listGroundInfo)
                {
                    SaveOrUpdateData(groundInfo, isCopy);
                }
            }
            if (familyRelationChamberData.ListPrayers != null && familyRelationChamberData.ListPrayers.Count > 0)
            {
                List<Prayer> listPrayer = familyRelationChamberData.ListPrayers.Select(prayers => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetPrayer(prayers)).ToList();
                foreach (Prayer prayer in listPrayer)
                {
                    SaveOrUpdateData(prayer, isCopy);
                }
            }

            if (familyRelationChamberData.ListRelatedProceedingEntity != null && familyRelationChamberData.ListRelatedProceedingEntity.Count > 0)
            {
                List<RelatedProceeding> listRelatedProceeding = familyRelationChamberData.ListRelatedProceedingEntity.Select(relatedProceeding => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRelatedProceeding(relatedProceeding)).ToList();
                foreach (RelatedProceeding relatedProceeding in listRelatedProceeding)
                {
                    SaveOrUpdateData(relatedProceeding, isCopy);
                }
            }
        }

        private void SaveOrUpdatePracticingCertificateData(PracticingCertificateData practicingCertificateData, bool isCopy)
        {
            if (practicingCertificateData.PCInfoEntity != null)
            {
                this.genericGateway.SaveOrUpdateEntity<PCInfo>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetPCInfo(practicingCertificateData.PCInfoEntity), isCopy);
            }
            if (practicingCertificateData.ListPCInfoAccReportEntity != null && practicingCertificateData.ListPCInfoAccReportEntity.Count > 0)
            {
                List<PCInfoAccReport> listPCInfoAccReport = practicingCertificateData.ListPCInfoAccReportEntity.Select(pCInfoAccReport => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetPCInfoAccReport(pCInfoAccReport)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<PCInfoAccReport>(listPCInfoAccReport, isCopy);
            }
            if (practicingCertificateData.ListAccountantsReportInfo != null && practicingCertificateData.ListAccountantsReportInfo.Count > 0)
            {
                List<AccountantsReportInfo> listAccountantsReportInfo = practicingCertificateData.ListAccountantsReportInfo.Select(accountantsReportInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetAccountantsReportInfo(accountantsReportInfo)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<AccountantsReportInfo>(listAccountantsReportInfo, isCopy);
            }

            if (practicingCertificateData.ListAreaOfLegalPractice != null && practicingCertificateData.ListAreaOfLegalPractice.Count > 0)
            {
                List<AreaOfLegalPractice> listAreaOfLegalPractice = practicingCertificateData.ListAreaOfLegalPractice.Select(areaOfLegalPractice => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetAreaOfLegalPractice(areaOfLegalPractice)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<AreaOfLegalPractice>(listAreaOfLegalPractice, isCopy);
            }

            if (practicingCertificateData.ListDegreeInfoEntity != null && practicingCertificateData.ListDegreeInfoEntity.Count > 0)
            {
                List<DegreeInfo> listDegreeInfo = practicingCertificateData.ListDegreeInfoEntity.Select(degreeInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDegreeInfo(degreeInfo)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<DegreeInfo>(listDegreeInfo, isCopy);
            }

            if (practicingCertificateData.ListEmploymentInfo != null && practicingCertificateData.ListEmploymentInfo.Count > 0)
            {
                List<EmploymentInfo> listEmploymentInfo = practicingCertificateData.ListEmploymentInfo.Select(employmentInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetEmploymentInfo(employmentInfo)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<EmploymentInfo>(listEmploymentInfo, isCopy);
            }

            if (practicingCertificateData.ListLPOthLegalOrgInfoEntity != null && practicingCertificateData.ListLPOthLegalOrgInfoEntity.Count > 0)
            {
                List<LPOthLegalOrgInfo> listLPOthLegalOrgInfo = practicingCertificateData.ListLPOthLegalOrgInfoEntity.Select(lPOthLegalOrgInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetLPOthLegalOrgInfo(lPOthLegalOrgInfo)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<LPOthLegalOrgInfo>(listLPOthLegalOrgInfo, isCopy);
            }
            if (practicingCertificateData.ListLPOthLegalOrgAddrInfo != null && practicingCertificateData.ListLPOthLegalOrgAddrInfo.Count > 0)
            {
                List<LPOthLegalOrgAddrInfo> listLPOthLegalOrgAddrInfo = practicingCertificateData.ListLPOthLegalOrgAddrInfo.Select(lPOthLegalOrgAddrInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetLPOthLegalOrgAddrInfo(lPOthLegalOrgAddrInfo)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<LPOthLegalOrgAddrInfo>(listLPOthLegalOrgAddrInfo, isCopy);
            }

            if (practicingCertificateData.ListPCConditionInfoEntity != null && practicingCertificateData.ListPCConditionInfoEntity.Count > 0)
            {
                List<PCConditionInfo> listPCConditionInfo = practicingCertificateData.ListPCConditionInfoEntity.Select(pCConditionInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetPCConditionInfo(pCConditionInfo)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<PCConditionInfo>(listPCConditionInfo, isCopy);
            }

            /*if (practicingCertificateData.ListQualificationInfoEntity != null && practicingCertificateData.ListQualificationInfoEntity.Count > 0)
            {
                List<QualificationInfo> listQualificationInfo = practicingCertificateData.ListQualificationInfoEntity.Select(qualificationInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetQualificationInfo(qualificationInfo)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<QualificationInfo>(listQualificationInfo, isCopy);
            }*/

            if (practicingCertificateData.ListTravelPassInfoEntity != null && practicingCertificateData.ListTravelPassInfoEntity.Count > 0)
            {
                List<TravelPassInfo> listTravelPassInfo = practicingCertificateData.ListTravelPassInfoEntity.Select(travelPassInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetTravelPassInfo(travelPassInfo)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<TravelPassInfo>(listTravelPassInfo, isCopy);
            }

            if (practicingCertificateData.ListLegalExperienceInfoEntity != null && practicingCertificateData.ListLegalExperienceInfoEntity.Count > 0)
            {
                List<LegalExperienceInfo> listLegalExperienceInfo = practicingCertificateData.ListLegalExperienceInfoEntity.Select(legalExperienceInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegalExperienceInfo(legalExperienceInfo)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<LegalExperienceInfo>(listLegalExperienceInfo, isCopy);
            }
            if (practicingCertificateData.ListDocAppProcessByExAgencyEntity != null && practicingCertificateData.ListDocAppProcessByExAgencyEntity.Count > 0)
            {
                List<DocAppProcessByExAgency> listDocAppProcessByExAgency = practicingCertificateData.ListDocAppProcessByExAgencyEntity.Select(docAppProcessByExAgency => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetDocAppProcessByExAgency(docAppProcessByExAgency)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<DocAppProcessByExAgency>(listDocAppProcessByExAgency, isCopy);
            }
            if (practicingCertificateData.ListForeignLPSolicitorRegEntity != null && practicingCertificateData.ListForeignLPSolicitorRegEntity.Count > 0)
            {
                List<ForeignLPSolicitorReg> listForeignLPSolicitorReg = practicingCertificateData.ListForeignLPSolicitorRegEntity.Select(foreignLPSolicitorReg => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetForeignLPSolicitorReg(foreignLPSolicitorReg)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<ForeignLPSolicitorReg>(listForeignLPSolicitorReg, isCopy);
            }
            if (practicingCertificateData.ListNOCInfoEntity != null && practicingCertificateData.ListNOCInfoEntity.Count > 0)
            {
                List<NOCInfo> listNOCInfo = practicingCertificateData.ListNOCInfoEntity.Select(nOCInfo =>
                    AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetNOCInfo(nOCInfo)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<NOCInfo>(listNOCInfo, isCopy);
            }
        }

        /// <summary>
        /// Saves the or update set down data.
        /// </summary>
        /// <param name="registrarsAppealsData">The registrars appeals data.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        private void SaveOrUpdateRegistrarsAppealsData(RegistrarsAppealsData registrarsAppealsData, bool isCopy)
        {
            if (registrarsAppealsData.ListLegislationProvisionsEntity != null && registrarsAppealsData.ListLegislationProvisionsEntity.Count > 0)
            {
                List<LegislationProvision> listLegislationProvision = registrarsAppealsData.ListLegislationProvisionsEntity.Select(legislationProvision => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLegislationProvision(legislationProvision)).ToList();
                foreach (LegislationProvision legislationProvision in listLegislationProvision)
                {
                    SaveOrUpdateData(legislationProvision, isCopy);
                }
            }
            if (registrarsAppealsData.ListNatureOfCaseEntity != null && registrarsAppealsData.ListNatureOfCaseEntity.Count > 0)
            {
                List<NatureOfCase> listNatureOfCase = registrarsAppealsData.ListNatureOfCaseEntity.Select(natureOfCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfCase(natureOfCase)).ToList();
                foreach (NatureOfCase natureOfCase in listNatureOfCase)
                {
                    SaveOrUpdateData(natureOfCase, isCopy);
                }
            }

            if (registrarsAppealsData.ListOtherITMOEntity != null && registrarsAppealsData.ListOtherITMOEntity.Count > 0)
            {
                List<OtherITMO> listOtherITMO = registrarsAppealsData.ListOtherITMOEntity.Select(otherITMO => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetOtherITMO(otherITMO)).ToList();
                foreach (OtherITMO otherITMO in listOtherITMO)
                {
                    SaveOrUpdateData(otherITMO, isCopy);
                }
            }

            if (registrarsAppealsData.ListRefOrderDetailEntity != null && registrarsAppealsData.ListRefOrderDetailEntity.Count > 0)
            {
                List<RefOrderDetail> listRefOrderDetail = registrarsAppealsData.ListRefOrderDetailEntity.Select(refOrderDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetail)).ToList();
                foreach (RefOrderDetail refOrderDetail in listRefOrderDetail)
                {
                    SaveOrUpdateData(refOrderDetail, isCopy);
                }
            }

            if (registrarsAppealsData.RARASInfoEntity != null)
            {
                SaveOrUpdateData(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetRARASInfo(registrarsAppealsData.RARASInfoEntity), isCopy);
            }

            if (registrarsAppealsData.ListNatureOfApplicationEntity != null && registrarsAppealsData.ListNatureOfApplicationEntity.Count > 0)
            {
                List<NatureOfApplication> listNatureOfApplication = registrarsAppealsData.ListNatureOfApplicationEntity.Select(natureOfApplication => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfApplication(natureOfApplication)).ToList();
                foreach (NatureOfApplication natureOfApplication in listNatureOfApplication)
                {
                    SaveOrUpdateData(natureOfApplication, isCopy);
                }
            }
        }

        /// <summary>
        /// Saves the or update set down data.
        /// </summary>
        /// <param name="setDownData">The set down data.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        private void SaveOrUpdateSetDownData(SetDownData setDownData, bool isCopy)
        {
            try
            {
                if (setDownData.SetDownInfo != null)
                {
                    SaveOrUpdateData(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetSetDownInfo(setDownData.SetDownInfo), isCopy);
                }
                if (setDownData.PaymentHRGDatesDocDetailEntity != null)
                {
                    SaveOrUpdateData(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubsequentMapper.GetPaymentHRGDatesDocDetail(setDownData.PaymentHRGDatesDocDetailEntity), isCopy);
                }
                if (setDownData.ListRefOrderDetailEntity != null && setDownData.ListRefOrderDetailEntity.Count > 0)
                {
                    List<RefOrderDetail>listRefOrderDetail=setDownData.ListRefOrderDetailEntity.Select(refOrderDetail=>AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetail)).ToList();
                    genericGateway.SaveOrUpdateEntityList<RefOrderDetail>(listRefOrderDetail, isCopy);
                }


            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateSetDownData", ex);
                throw;
            }
            

        }

        private void SaveOrUpdateSummonsData(SummonsData summonsData, bool isCopy)
        {
            try
            {
                if (summonsData.ListNatureOfApplicationEntity != null && summonsData.ListNatureOfApplicationEntity.Count > 0)
                {
                    List<NatureOfApplication> listNatureOfApplication = summonsData.ListNatureOfApplicationEntity.Select(natureOfApplication => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetNatureOfApplication(natureOfApplication)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<NatureOfApplication>(listNatureOfApplication, isCopy);
                }
                if (summonsData.ListPrayerEntity != null && summonsData.ListPrayerEntity.Count > 0)
                {
                    List<Prayer> listPrayer = summonsData.ListPrayerEntity.Select(prayer => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetPrayer(prayer)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<Prayer>(listPrayer, isCopy);
                }

                if (summonsData.ListRefOrderDetailEntity != null && summonsData.ListRefOrderDetailEntity.Count > 0)
                {
                    List<RefOrderDetail> listRefOrderDetail = summonsData.ListRefOrderDetailEntity.Select(refOrderDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetail)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<RefOrderDetail>(listRefOrderDetail, isCopy);
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateSummonsData", ex);

                throw;
            }
        }

        /// <summary>
        /// Saves the or update warrant of arrest data.
        /// </summary>
        /// <param name="warrantOfArrestData">The warrant of arrest data.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        private void SaveOrUpdateWarrantOfArrestData(WarrantOfArrestData warrantOfArrestData, bool isCopy)
        {
            if (warrantOfArrestData.ADMWAInfo != null)
            {
                ADMWAInfo aDMWAInfo = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetADMWAInfo(warrantOfArrestData.ADMWAInfo);
                SaveOrUpdateData(aDMWAInfo, isCopy);
            }
            if (warrantOfArrestData.ListRefCaveatCaseEntity != null && warrantOfArrestData.ListRefCaveatCaseEntity.Count > 0)
            {
                List<RefCaveatCase> listRefCaveatCase = warrantOfArrestData.ListRefCaveatCaseEntity.Select(refCaveatCase => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefCaveatCase(refCaveatCase)).ToList();
                this.genericGateway.SaveOrUpdateEntityList<RefCaveatCase>(listRefCaveatCase, isCopy);
            }
        }

        private void SaveOrUpdateServiceOfDocData(ServiceOfDocData serviceOfDocData, bool isCopy)
        {
            try
            {
                if (serviceOfDocData.ServiceOfDocInfoEntity != null)
                {
                    ServiceOfDocInfo serviceOfDocInfo = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocInfo(serviceOfDocData.ServiceOfDocInfoEntity);
                    this.genericGateway.SaveOrUpdateEntity<ServiceOfDocInfo>(serviceOfDocInfo, isCopy);
                }
                if (serviceOfDocData.ListServiceOfDocDocStatusHistoryEntity != null && serviceOfDocData.ListServiceOfDocDocStatusHistoryEntity.Count > 0)
                {
                    List<ServiceOfDocDocStatusHistory> listServiceOfDocDocStatusHistory = serviceOfDocData.ListServiceOfDocDocStatusHistoryEntity.Select(serviceOfDocDocStatusHistory => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocDocStatusHistory(serviceOfDocDocStatusHistory)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<ServiceOfDocDocStatusHistory>(listServiceOfDocDocStatusHistory, isCopy);
                }
                if (serviceOfDocData.ListServiceOfDocInfoDetailEntity != null && serviceOfDocData.ListServiceOfDocInfoDetailEntity.Count > 0)
                {
                    List<ServiceOfDocInfoDetail> listServiceOfDocInfoDetail = serviceOfDocData.ListServiceOfDocInfoDetailEntity.Select(serviceOfDocInfoDetail=> AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocInfoDetail(serviceOfDocInfoDetail)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<ServiceOfDocInfoDetail>(listServiceOfDocInfoDetail, isCopy);
                }
                if (serviceOfDocData.ListServiceOfDocDocumentEntity != null && serviceOfDocData.ListServiceOfDocDocumentEntity.Count > 0)
                {
                    List<ServiceOfDocDocument> listServiceOfDocDocument = serviceOfDocData.ListServiceOfDocDocumentEntity.Select(serviceOfDocDocument => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseSpecificMapper.GetServiceOfDocDocument(serviceOfDocDocument)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<ServiceOfDocDocument>(listServiceOfDocDocument, isCopy);
                }

                if (serviceOfDocData.ListRefOrderDetailEntity != null && serviceOfDocData.ListRefOrderDetailEntity.Count > 0)
                {
                    List<RefOrderDetail> listRefOrderDetail = serviceOfDocData.ListRefOrderDetailEntity.Select(refOrderDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetail)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<RefOrderDetail>(listRefOrderDetail, isCopy);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateServiceOfDocData", ex);
                throw;
            }
        }

        private void SaveOrUpdateWOEData(WOEData woeData, bool isCopy)
        {
            try
            {
                if (woeData.WOEInfoEntity != null)
                {
                    this.genericGateway.SaveOrUpdateEntity<WOEInfo>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubsequentMapper.GetWOEInfo(woeData.WOEInfoEntity), isCopy);
                }
                if (woeData.ListWOEExecutionAddressEntity != null && woeData.ListWOEExecutionAddressEntity.Count > 0)
                {
                    List<WOEExecutionAddress> listWOEExecutionAddress = woeData.ListWOEExecutionAddressEntity.Select(WOEExecutionAddress => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetWOEExecutionAddress(WOEExecutionAddress)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<WOEExecutionAddress>(listWOEExecutionAddress, isCopy);
                }
                if (woeData.ListWOEMOMSCTInfoEntity != null && woeData.ListWOEMOMSCTInfoEntity.Count > 0)
                {
                    List<WOEMOMSCTInfo> listWOEMOMSCTInfo = woeData.ListWOEMOMSCTInfoEntity.Select(WOEMOMSCTInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseSpecificMapper.GetWOEMOMSCTInfo(WOEMOMSCTInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<WOEMOMSCTInfo>(listWOEMOMSCTInfo, isCopy);
                }
                if (woeData.ListWOENCPEInfoEntity != null && woeData.ListWOENCPEInfoEntity.Count > 0)
                {
                    List<WOENCPEInfo> listWOENCPEInfo = woeData.ListWOENCPEInfoEntity.Select(WOENCPEInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubsequentMapper.GetWOENCPEInfo(WOENCPEInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<WOENCPEInfo>(listWOENCPEInfo, isCopy);
                }
                if (woeData.ListWOENECPEInfoEntity != null && woeData.ListWOENECPEInfoEntity.Count > 0)
                {
                    List<WOENECPEInfo> listWOENECPEInfo = woeData.ListWOENECPEInfoEntity.Select(WOENECPEInfo => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubsequentMapper.GetWOENECPEInfo(WOENECPEInfo)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<WOENECPEInfo>(listWOENECPEInfo, isCopy);
                }
                if (woeData.ListWOERequestEntity != null && woeData.ListWOERequestEntity.Count > 0)
                {
                    List<WOERequest> listWOERequest = woeData.ListWOERequestEntity.Select(WOERequest => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubsequentMapper.GetWOERequest(WOERequest)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<WOERequest>(listWOERequest, isCopy);
                }
                if (woeData.ListRequestDocDetailEntity != null && woeData.ListRequestDocDetailEntity.Count > 0)
                {
                    List<RequestDocDetail> listRequestDocDetail = woeData.ListRequestDocDetailEntity.Select(requestDocDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubsequentMapper.GetRequestDocDetail(requestDocDetail)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<RequestDocDetail>(listRequestDocDetail, isCopy);
                }
                if (woeData.ListRefOrderDetailEntity != null && woeData.ListRefOrderDetailEntity.Count > 0)
                {
                    List<RefOrderDetail> listRefOrderDetail = woeData.ListRefOrderDetailEntity.Select(refOrderDetail => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetRefOrderDetail(refOrderDetail)).ToList();
                    this.genericGateway.SaveOrUpdateEntityList<RefOrderDetail>(listRefOrderDetail, isCopy);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateWOEData", ex);

                throw;
            }
        }

        #endregion Methods
    }
}