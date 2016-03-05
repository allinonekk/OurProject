#region Header

/*****************************************************************************************************
* Description : The mediator for Master Entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			            Description
*-----------------------------------------------------------------------------------------------------
*   30/11/2010   		        Yan Nai                	 	Created
*****************************************************************************************************/
// <summary>
// File: MasterMediatorImpl.cs
// Description: The mediator for Master Entities.
// </summary>
// <copyright file= "MasterMediatorImpl.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.MRelationship;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Data;

    using log4net;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Common;

    public class MasterMediatorImpl : IMasterMediator
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(MasterMediatorImpl));

        /// </summary>
        private ApplicationSessionManager applicationSessionManager = new ApplicationSessionManager();
        MasterGateway gateWay;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        /// <param name="sender"></param>
        public void BeginTransaction()
        {
            Logger.Info("MasterMediatorImpl - BeginTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager.BeginTransaction();

            Logger.Info("MasterMediatorImpl - BeginTransaction ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Close the session.
        /// </summary>
        public void CloseSession()
        {
            Logger.Info("MasterMediatorImpl - CloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CloseSession();

            Logger.Info("MasterMediatorImpl - CloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        public void CommitAndCloseSession()
        {
            Logger.Info("MasterMediatorImpl - CommitAndCloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CommitAndCloseSession();

            Logger.Info("MasterMediatorImpl - CommitAndCloseSession ended at " + DateTime.Now.ToString());
        }

        public void CreateMasterEntity(IMasterEntity masterEntity)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.CreateEntity<IMaster>(MasterMapper.GetMasterEntity<IMasterEntity>(masterEntity));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at CreateMasterEntity", ex);
                throw;
            }
        }

        public List<MBailTypeEntity> GetAllMBailType()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMBailType();
        }

        public List<MCaseTypeEntity> GetAllMCaseTypeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMCaseType();
        }

        public List<MChargeTypeEntity> GetAllMChargeType()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMChargeType();
        }

        public List<MCoramEntity> GetAllMCoramEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMCoram();
        }

        public List<MCountryEntity> GetAllMCountry()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMCountry();
        }

        public List<MCourtTypeEntity> GetAllMCourtTypeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMCourtType();
        }

        public List<MCriminalClaimantTypeEntity> GetAllMCriminalClaimantType()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMCriminalClaimantType();
        }

        public List<MCriminalClaimTypeEntity> GetAllMCriminalClaimType()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMCriminalClaimType();
        }

        public List<MCriminalOrderEntity> GetAllMCriminalOrder()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMCriminalOrder();
        }

        public List<MCurrencyEntity> GetAllMCurrencyEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMCurrency();
        }

        public List<MDialectEntity> GetAllMDialectEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMDialect();
        }

        public List<MDocCategoryEntity> GetAllMDocCategory()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMDocCategory();
        }

        /// <summary>
        /// Gets the List of MDocCodeEntity
        /// </summary>
        /// <returns></returns>
        public List<MDocCodeEntity> GetAllMDocCodeEntity()
        {
            gateWay = new MasterGateway();
            List<MDocCode> listMDocCode = gateWay.GetEntity<MDocCode>();
            return listMDocCode.Select(mDocCode => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocCodeEntity(mDocCode)).ToList();
        }

        /// <summary>
        /// Gets the List of MDocNatureEntity
        /// </summary>
        /// <returns></returns>
        public List<MDocNatureEntity> GetAllMDocNatureEntity()
        {
            gateWay = new MasterGateway();
            List<MDocNature> listMDocNature = gateWay.GetEntity<MDocNature>();
            return listMDocNature.Select(mDocNature => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocNatureEntity(mDocNature)).ToList();
        }

        public List<MDocSecurityEntity> GetAllMDocSecurity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMDocSecurity();
        }

        public List<MDrivingLicenseEntity> GetAllMDrivingLicense()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMDrivingLicense();
        }

        public List<MDrugEntity> GetAllMDrug()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMDrug();
        }

        public List<MEMSWritApptEntity> GetAllMEMSWritApptEntity()
        {
            try
            {
                MasterGateway masterGateway = new MasterGateway();
                return masterGateway.GetAllMEMSWritApptEntity();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAllMEMSWritApptEntity", ex);
                throw;
            }
        }

        public List<MEntityTypeEntity> GetAllMEntityType()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMEntityType();
        }

        public List<MFormTemplateLocationEntity> GetAllMFormTemplateLocationEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMFormTemplateLocationEntity();
        }

        public List<MForumTypeEntity> GetAllMForumTypeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMForumType();
        }

        public List<MGenderEntity> GetAllMGender()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMGender();
        }

        public List<MHolidayEntity> GetAllMHolidayEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMHoliday();
        }

        /// <summary>
        /// Gets all <see cref="MHRGTypeEntity"/>
        /// </summary>
        /// <returns></returns>
        public List<MHRGTypeEntity> GetAllMHRGTypeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMHrgType();
        }

        public List<MHRGUserAvailabilityEntity> GetAllMHRGUserAvailability()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMHRGUserAvailability();
        }

        public List<MIOOrganisationEntity> GetAllMIOOrganisation()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMIOOrganisation();
        }

        public List<MLegalPracticeEntity> GetAllMLegalPracticeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMLegalPractice();
        }

        public List<MLegislationActEntity> GetAllMLegislationAct()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMLegislationAct();
        }

        public List<MLimitationsEntity> GetAllMLimitationsEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMLimitationsEntity();
        }

        public List<MMaritalStatusEntity> GetAllMMaritalStatusEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMMaritalStatusEntity();
        }

        public List<MModeOfTraffickingEntity> GetAllMModeOfTrafficking()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMModeOfTrafficking();
        }

        public List<MNationalityEntity> GetAllMNationality()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMNationality();
        }

        public List<MNatureOfAppealEntity> GetAllMNatureOfAppeal()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMNatureOfAppeal();
        }

        public List<MNatureOfOffenceEntity> GetAllMNatureOfOffence()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMNatureOfOffence();
        }

        public List<MNOACodeEntity> GetAllMNOACode()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMNOACode();
        }

        public List<MOccupationEntity> GetAllMOccupation()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMOccupation();
        }

        public List<MPartyStatusEntity> GetAllMPartyStatus()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMPartyStatus();
        }

        public List<MPrisonEntity> GetAllMPrison()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMPrison();
        }

        public List<MProvisionEntity> GetAllMProvision()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMProvision();
        }

        public List<MQualificationEntity> GetAllMQualification()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMQualification();
        }

        public List<MRaceEntity> GetAllMRace()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMRace();
        }

        public List<MReligionEntity> GetAllMReligion()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMReligion();
        }

        /// <summary>
        /// Gets the List of MSectionEntity
        /// </summary>
        /// <returns></returns>
        public List<MSectionEntity> GetAllMSectionEntity()
        {
            gateWay = new MasterGateway();
            List<MSection> listMSection = gateWay.GetEntity<MSection>();
            return listMSection.Select(mSection => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSectionEntity(mSection)).ToList();
        }

        public List<MSentenceEntity> GetAllMSentence()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMSentence();
        }

        public List<MSubProvisionEntity> GetAllMSubProvision()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMSubProvision();
        }

        public List<MTaskListTypeEntity> GetAllMTaskListType()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMTaskListType();
        }

        public List<RMCaseTypeForumEntity> GetAllRMCaseTypeForumEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMCaseTypeForumEntity();
        }

        public List<RMCaseTypeNOAEntity> GetAllRMCaseTypeNOAEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMCaseTypeNOA();
        }

        public List<MBusinessJobLegalDetailEntity> GetListMBusinessJobLegalDetailEntity(string businessJobLegalInfoId)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListMBusinessJobLegalDetailEntity(businessJobLegalInfoId);
        }

        public List<MChecklistEntity> GetListMCheckListByCaseType(string caseType)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListMChecklist(caseType);
        }

        public List<MChecklistDocumentEntity> GetListMChecklistDocument(long checkListId)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListMChecklistDocument(checkListId);
        }

        public List<MDocCodeEntity> GetListMDocCode(string mainGroup, string subCategory)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMDocCode(mainGroup, subCategory);
        }

        public List<MDocControlEntity> GetListMDocControlByDocCode(string docCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListMDocControlByDocCode(docCode);
        }

        public List<MFunctionsEntity> GetListMFunctionsEntity(string roleCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListMFunctionsEntity(roleCode);
        }

        public List<MHRGTypeEntity> GetListMHrgType(string hRGTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListMHRGTypeEntity(hRGTypeCode);
        }

        public List<MNOACodeEntity> GetListMNOACodeEntityByCaseType(string caseTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetNOACodeByCaseType(caseTypeCode);
        }

        public List<MPersonIDGroupEntity> GetListMPersonIDGroupOrderBySeqNo()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListMPersonIDGroupOrderBySeqNo();
        }

        public List<MPersonIDTypeEntity> GetListMPersonIDTypeEntityByEntityType(string entityTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListMPersonIDTypeEntityByEntityType(entityTypeCode);
        }

        public List<RMDocCodeHrgTypeEntity> GetListRMDocCodeHrgType(string docCode, string caseTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRMDocCodeHrgType(docCode, caseTypeCode);
        }

        public List<RMDocCodeHrgTypeEntity> GetListRMDocCodeHrgType(string docCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRMDocCodeHrgType(docCode);
        }

        public List<RMHRGTypeHRGSlotEntity> GetListRMHrgTypeHrgSlot(string CourtInd, string HRGTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRMHrgTypeHrgSlot(CourtInd, HRGTypeCode);
        }

        public List<RMNOAForumHrgTypeEntity> GetListRMNOAForumHrgType(string NOACode, string ForumId)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRMNOAForumHrgType(NOACode, ForumId);
        }

        public List<RMNOAForumHrgTypeEntity> GetListRMNOAForumHrgType(string NOACode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRMNOAForumHrgType(NOACode);
        }

        public List<RMPartyStatusCaseTypeEntity> GetListRMPartyStatusCaseTypeEntity(string caseTypeCode)
        {
            try
            {
                MasterGateway masterGateway = new MasterGateway();
                return masterGateway.GetListRMPartyStatusCaseTypeEntity(caseTypeCode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMPartyStatusCaseTypeEntity", ex);
                throw;
            }
        }

        public List<RMRoutingSectionConfigEntity> GetListRMRoutingSectionConfigEntity(string forumId)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRMRoutingSectionConfig(forumId);
        }

        public List<RUserRoleSectionEntity> GetListRUserRoleSection(string roleCode, string sectionCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRUserRoleSection(roleCode, sectionCode);
        }

        public List<RUserRoleSectionEntity> GetListRUserRoleSectionByRoleCode(string roleCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRUserRoleSectionByRoleCode(roleCode);
        }

        public List<RUserRoleSectionEntity> GetListRUserRoleSectionBySectionCode(string sectionCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRUserRoleSectionBySectionCode(sectionCode);
        }



        public IMasterEntity GetMasterEntityByPK<T>(string primaryKey)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMasterEntityByPK<T>(primaryKey);
        }

        public MBailTypeEntity GetMBailTypeEntity(string bailTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMBailType(bailTypeCode);
        }

        public MBusinessJobLegalInfoEntity GetMBusinessJobLegalInfoEntityByPK(string businessJobLegalInfoId)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMBusinessJobLegalInfoEntity(businessJobLegalInfoId);
        }

        public List<MCaseIssueEntity> GetMCaseIssue()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMCaseIssue();
        }

        public List<MCaseIssueEntity> GetMCaseIssue<V>(string fieldName, V value)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMCaseIssue<V>(fieldName, value);
        }

        public MChargeTypeEntity GetMChargeTypeEntity(string chargeTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMChargeType(chargeTypeCode);
        }

        public MCriminalClaimantTypeEntity GetMCriminalClaimantTypeEntityByCriminalClaimantTypeCode(string criminalClaimantTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMCriminalClaimantType(criminalClaimantTypeCode);
        }

        public MCriminalClaimTypeEntity GetMCriminalClaimTypeEntityByCriminalClaimaTypeCode(string criminalClaimTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMCriminalClaimType(criminalClaimTypeCode);
        }

        public MCriminalOrderEntity GetMCriminalOrderEntity(string criminalOrderCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMCriminalOrder(criminalOrderCode);
        }

        public MDocCodeEntity GetMDocCodeEntityByPK(string docCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMDocCodeByDocCode(docCode);
        }

        public MDrivingLicenseEntity GetMDrivingLicenseEntity(string drivingLicenseCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMDrivingLicense(drivingLicenseCode);
        }

        public MDrugEntity GetMDrugEntity(string drugCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMDrug(drugCode);
        }

        public List<MFunctionsEntity> GetMFunctions<V>(string fieldName, V value)
        {
            MasterGateway masterGateway = new MasterGateway();
            List<MFunctions> listMFunctions = masterGateway.GetEntity<MFunctions, V>(fieldName, value);

            if (listMFunctions != null && listMFunctions.Count > 0)
                return listMFunctions.Select(mFunctions =>
                        AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFunctionsEntity(mFunctions)).ToList();
            else
                return null;
        }

        public MHRGRoomEntity GetMHRGRoomEntityByPK(string hRGRoomCode)
        {
            try
            {
                MasterGateway masterGateway = new MasterGateway();
                return masterGateway.GetMHrgRoomEntity(hRGRoomCode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHRGRoomEntityByPK", ex);
                throw;
            }
        }

        public MHRGTypeEntity GetMHrgTypeEntity(string courtInd, string hrgTypeCode)
        {
            gateWay = new MasterGateway();
            return gateWay.GetMHrgTypeEntity(courtInd, hrgTypeCode);
        }

        public MIOOrganisationEntity GetMIOOrganisationEntity(string ioOrganisationCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMIOOrganisation(ioOrganisationCode);
        }

        public MLegislationActEntity GetMLegislationActEntity(string actCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMLegislationAct(actCode);
        }

        public MModeOfTraffickingEntity GetMModeOfTraffickingEntity(string modeOfTraffickingCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMModeOfTrafficking(modeOfTraffickingCode);
        }

        public MNAAAlertEventsTemplateEntity GetMNAAAlertEventsTemplateByPK(int alertEventTemplateId)
        {
            try
            {
                MasterGateway masterGateway = new MasterGateway();
                return masterGateway.GetMNAAAlertEventsTemplateByPK(alertEventTemplateId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMNAAAlertEventsTemplateByPK", ex);
                throw;
            }
        }

        public MNatureOfAppealEntity GetMNatureOfAppealEntity(string natureOfAppealCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMNatureOfAppeal(natureOfAppealCode);
        }

        public MNatureOfOffenceEntity GetMNatureOfOffenceEntity(string natureOfOffenceCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMNatureOfOffence(natureOfOffenceCode);
        }

        public MNOACodeEntity GetMNOACodeEntity(string noaCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMNOACode(noaCode);
        }

        public MPartyStatusEntity GetMPartyStatusEntityByPK(string partyStatusCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMPartyStatusEntityByPK(partyStatusCode);
        }

        public MPrisonEntity GetMPrisonEntity(string prisonCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMPrison(prisonCode);
        }

        public MProvisionEntity GetMProvisionEntity(string provisionCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMProvision(provisionCode);
        }

        /// <summary>
        /// Get a list of all MScheduleJobLegalInfoEntity.
        /// </summary>
        /// <returns>A list of MScheduleJobLegalInfoEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 30, 2011)</remarks>
        public List<MScheduleJobLegalDetailEntity> GetMScheduleJobLegalDetail()
        {
            MasterGateway masterGateway = new MasterGateway();
            return this.GetMScheduleJobLegalDetail<string>(string.Empty, string.Empty, true);
        }

        /// <summary>
        /// Get a list of MScheduleJobLegalDetailEntity by passing the column name and its value.
        /// </summary>
        /// <typeparam name="V">The type for the parameter "value"</typeparam>
        /// <param name="fieldName">The name of the column in database. (Name of property of object).</param>
        /// <param name="value">The value used to filter.</param>
        /// <param name="isGetAll">Boolean to indicate if retrieve all.</param>
        /// <returns>A list of MScheduleJobLegalDetailEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 30, 2011)</remarks>
        public List<MScheduleJobLegalDetailEntity> GetMScheduleJobLegalDetail<V>(string fieldName, V value, bool isGetAll)
        {
            MasterGateway masterGateway = new MasterGateway();
            List<MScheduleJobLegalDetail> listMScheduleJobLegalDetail = new List<MScheduleJobLegalDetail>();
            if (isGetAll)
            {
                listMScheduleJobLegalDetail = masterGateway.GetEntity<MScheduleJobLegalDetail>();
            }
            else
            {
                listMScheduleJobLegalDetail = masterGateway.GetEntity<MScheduleJobLegalDetail, V>(fieldName, value);
            }
            return listMScheduleJobLegalDetail.Select(mScheduleJobLegalDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMScheduleJobLegalDetailDomain(mScheduleJobLegalDetail)).ToList();
        }

        /// <summary>
        /// Get a list of all MScheduleJobLegalInfoEntity.
        /// </summary>
        /// <returns>A list of MScheduleJobLegalInfoEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 30, 2011)</remarks>
        public List<MScheduleJobLegalInfoEntity> GetMScheduleJobLegalInfo()
        {
            MasterGateway masterGateway = new MasterGateway();
            return this.GetMScheduleJobLegalInfo<string>(string.Empty, string.Empty, true);
        }

        /// <summary>
        /// Get a list of MScheduleJobLegalInfoEntity by passing the column name and its value.
        /// </summary>
        /// <typeparam name="V">The type for the parameter "value"</typeparam>
        /// <param name="fieldName">The name of the column in database. (Name of property of object).</param>
        /// <param name="value">The value used to filter.</param>
        /// <param name="isGetAll">Boolean to indicate if retrieve all.</param>
        /// <returns>A list of MScheduleJobLegalInfoEntity</returns>
        /// <remarks>This Method is developed by Yan Nai (April 30, 2011)</remarks>
        public List<MScheduleJobLegalInfoEntity> GetMScheduleJobLegalInfo<V>(string fieldName, V value, bool isGetAll)
        {
            MasterGateway masterGateway = new MasterGateway();
            List<MScheduleJobLegalInfo> listMScheduleJobLegalInfo = new List<MScheduleJobLegalInfo>();
            if (isGetAll)
            {
                listMScheduleJobLegalInfo = masterGateway.GetEntity<MScheduleJobLegalInfo>();
            }
            else
            {
                listMScheduleJobLegalInfo = masterGateway.GetEntity<MScheduleJobLegalInfo, V>(fieldName, value);
            }
            return listMScheduleJobLegalInfo.Select(mScheduleJobLegalInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMScheduleJobLegalInfoDomain(mScheduleJobLegalInfo)).ToList();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldNames"></param>
        /// <param name="opertr"></param>
        /// <returns></returns>
        public List<MSectionEntity> GetMSection<V>(string fieldName, V value)
        {
            MasterGateway masterGateway = new MasterGateway();
            List<MSection> listMSection = masterGateway.GetEntity<MSection, V>(fieldName, value);

            if (listMSection != null && listMSection.Count > 0)
                return listMSection.Select(mSection =>
                        AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSectionEntity(mSection)).ToList();
            else
                return null;
        }

        public MSentenceEntity GetMSentenceEntity(string sentenceCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMSentence(sentenceCode);
        }

        public MSubProvisionEntity GetMSubProvisionEntity(string subProvisonCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMSubProvision(subProvisonCode);
        }

        public MTaskListTypeEntity GetMTaskListTypeEntity(string taskListTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMTaskListType(taskListTypeCode);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldNames"></param>
        /// <param name="opertr"></param>
        /// <returns></returns>
        public List<MUserRoleEntity> GetMUserRole<V>(string fieldName, V value)
        {
            MasterGateway masterGateway = new MasterGateway();
            List<MUserRole> listMUserRole = masterGateway.GetEntity<MUserRole, V>(fieldName, value);

            if (listMUserRole != null && listMUserRole.Count > 0)
                return listMUserRole.Select(mUserRole =>
                        AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMUserRoleDomain(mUserRole)).ToList();
            else
                return null;
        }

        public List<MLegislationActEntity> GetPagedMLegislationAct(int currentPageNo, int pageRecordsCount, out int count)
        {
            int totalCount = 0;
            MasterGateway masterGateway = new MasterGateway();
            List<MLegislationActEntity> listMLegislationActEntity = masterGateway.GetPagedMLegislationAct(currentPageNo, pageRecordsCount, out totalCount);
            count = totalCount;
            return listMLegislationActEntity;
        }

        /// <summary>
        /// Gets the paged M legislation act entity.
        /// </summary>
        /// <param name="pageNo">The page no.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="totalRecords">The total records.</param>
        /// <returns></returns>
        public List<MLegislationActEntity> GetPagedMLegislationActEntity(int pageNo, int pageSize, out int totalRecords)
        {
            int totalCount = 0;
            MasterGateway masterGateway = new MasterGateway();
            List<MLegislationActEntity> listMLegislationActEntity = masterGateway.GetPagedMLegislationActEntity(pageNo, pageSize, out totalCount);
            totalRecords = totalCount;
            return listMLegislationActEntity;
        }

        public List<RMHRGOutComePartyStatusEntity> GetRMHRGOutComePartyStatus<V>(string fieldName, V value)
        {
            MasterGateway masterGateway = new MasterGateway();
            List<RMHRGOutComePartyStatus> listRMHRGOutComePartyStatus = masterGateway.GetEntity<RMHRGOutComePartyStatus, V>(fieldName, value);

            if (listRMHRGOutComePartyStatus != null && listRMHRGOutComePartyStatus.Count > 0)
                return listRMHRGOutComePartyStatus.Select(rMHRGOutComePartyStatus => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMHRGOutComePartyStatusEntity(rMHRGOutComePartyStatus)).ToList();
            else
                return null;
        }

        public RMPartyStatusCaseTypeEntity GetRMPartyStatusCaseTypeEntity(string caseTypeCode, string partyStatus)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetRMPartyStatusCaseTypeEntity(caseTypeCode, partyStatus);
        }

        public RRoleFunctionsEntity GetRRoleFunctions(string roleCode, string functionCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetRRoleFunctions(roleCode, functionCode);
        }

        public RUserRoleSectionEntity GetRUserRoleSection(string sectionCode, string userId, string roleCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetRUserRoleSection(sectionCode, userId, roleCode);
        }

        public List<RUserRoleSectionEntity> GetListRUserRoleSectionByUserId(string userId)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRUserRoleSectionByUserId(userId);
        }

        public void SaveOrUpdateMasterEntity(IMasterEntity masterEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<IMaster>(MasterMapper.GetMasterEntity<IMasterEntity>(masterEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMasterEntity", ex);
                Logger.Error("Error in SaveOrUpdateMasterEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public void UpdateMasterEntity(IMasterEntity masterEntity)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.UpdateEntity<IMaster>(MasterMapper.GetMasterEntity<IMasterEntity>(masterEntity));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at UpdateMasterEntity", ex);
                throw;
            }
        }

        public List<MHearingTypeEntity> GetAllMHearingTypeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMHearingType();
        }

        public List<MHRGRoomEntity> GetAllMHRGRoomEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMHRGRoomEntity();
        }


        public List<RMCaseTypeHRGTypeMSTypeEntity> GetAllRMCaseTypeHRGTypeMSTypeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMCaseTypeHRGTypeMSTypeEntity();
        }

        public List<RMForumCoramDSGEntity> GetAllRMForumCoramDSGEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMForumCoramDSGEntity();

        }


        public List<RMHearingTypeCourtTypeEntity> GetAllRMHearingTypeCourtTypeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMHearingTypeCourtTypeEntity();
        }


        public List<RMHRGTypeHRGOutComeHRGOutComeFlagEntity> GetAllRMHRGTypeHRGOutComeHRGOutComeFlagEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMHRGTypeHRGOutComeHRGOutComeFlagEntity();
        }


        public RMCaseTypeHRGTypeMSTypeEntity GetRMCaseTypeHRGTypeMSTypeEntity(string courdId, string CaseTypeCode, string HRGTypeCode, string MSType)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetRMCaseTypeHRGMSTypeEntity(courdId, CaseTypeCode, HRGTypeCode, MSType);
        }


        public RMForumCoramDSGEntity GetRMForumCoramDSGEntity(string ForumId, string CoramCode, string DSGCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetRMForumCoramDSGEntity(ForumId, CoramCode, DSGCode);
        }


        public RMHearingTypeCourtTypeEntity GetRMHearingTypeCourtTypeEntity(string courtId, string hRGTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetRMHearingTypeCourtTypeEntity(courtId, hRGTypeCode);
        }


        public RMDocCodeHrgTypeEntity GetRMDocCodeHRGTypeEntity(string docCode, string hrgTypeCode, string caseTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetRMHearingTypeCourtTypeEntity(docCode, hrgTypeCode, caseTypeCode);
        }

        public List<MHRGOutComeFlagEntity> GetAllMHRGOutComeFlagEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMHRGOutComeFlagEntity();
        }

        public List<MHRGOutComeReasonEntity> GetAllMHRGOutComeReasonEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMHRGOutComeReasonEntity();
        }


        public List<MEMSOldSCTCasePrefixEntity> GetAllMEMSOldSCTCasePrefixEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMEMSOldSCTCasePrefixEntity();
        }


        public List<RMNOAForumHrgTypeEntity> GetAllRMNOAForumHrgTypeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMNOAForumHrgType();
        }


        public List<RMPartyTypeCaseTypeEntity> GetListRMPartyTypeCaseTypeEntity(string caseTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRMPartyTypeCaseTypeEntity(caseTypeCode);
        }


        public List<MDocControlEntity> GetAllMDocControlEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMDocControl();
        }

        public List<MFilingFeeEntity> GetAllMFilingFeeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMFilingFee();
        }

        public List<MFilterGroupEntity> GetAllMFilterGroupEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMFilterGroup();
        }

        public List<MSummonsParamEntity> GetAllMSummonsParamsEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMSummonsParam();
        }


        public List<MMassCallHrgDateEntity> GetAllMMassCallHrgDateEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMMassCallHrgDate();
        }

        public List<MChargeOutcomeEntity> GetAllMChargeOutcomeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMChargeOutcome();
        }

        public void DeleteRMHRGTypeHRGSlotEntity(string courtInd, string hrgTypeCode, string hrgSlotCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            masterGateway.DeleteRMHRGTypeHRGSlot(courtInd, hrgTypeCode, hrgSlotCode);
        }


        public List<MLawFirmGroupEntity> GetAllMLawFirmGroupEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMLawFirmGroup();
        }

        public void SaveOrUpdateLawFirmEntity(ILawFirmEntity iLawFirmEntity, bool isCopy)
        {
            GenericGateway genericGateway = new GenericGateway();
            genericGateway.SaveOrUpdateEntity<ILawFirm>(LawFirmMapper.GetLawFirmEntity<ILawFirmEntity>(iLawFirmEntity), isCopy);
        }

        public ILawFirmEntity GetLawFirmEntityByPK<T>(string primaryKey)
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            return lawFirmGateway.GetLawFirmEntityByPK<T>(primaryKey);
        }

        public List<LawFirmEntity> GetAllLawFirmEntity()
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            return lawFirmGateway.GetAllLawFirm();
        }

        public List<LawFirmAddressEntity> GetAllLawFirmAddressEntity()
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            return lawFirmGateway.GetAllLawFirmAddress();
        }

        public List<MVSAConfigDetailEntity> GetAllMVSAConfigDetailEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMVSAConfigDetail();
        }

        public List<MVSAConfigGroundEntity> GetAllMVSAConfigGroundEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMVSAConfigGround();
        }

        public List<MVSAConfigPrayerEntity> GetAllMVSAConfigPrayerEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMVSAConfigPrayer();
        }

        public List<MFilingFeeChargingMechanismEntity> GetAllMFilingFeeChargingMechanismEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMFilingFeeChargingMechanism();
        }

        public List<MSummonsGroundsEntity> GetAllMSummonsGroundsEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMSummonsGrounds();
        }

        public List<MSummonsPrayersEntity> GetAllMSummonsPrayersEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMSummonsPrayers();
        }

        public MSummonsGroundsEntity GetMSummonsGroundsEntity(string paramId, int itemNo)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMSummonsGrounds(paramId, itemNo);

        }

        public MSummonsPrayersEntity GetMSummonsPrayersEntity(string paramId, int level, int subLevel)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetMSummonsPrayers(paramId, level, subLevel);
        }

        public RMDocFilterGroupEntity GetRMDocFilterGroupEntity(string docCode, string filterGroupId)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetRMDocFilterGroupEntity(docCode, filterGroupId);
        }

        public List<RMDocFilterGroupEntity> GetAllRMDocFilterGroupEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMDocFilterGroup();
        }

        public void SaveOrUpdateRMDocFilterGroupEntity(RMDocFilterGroupEntity rMDocFilterGroupEntity)
        {
            MasterGateway masterGateway = new MasterGateway();
            masterGateway.SaveOrUpdateRMDocFilterGroup(rMDocFilterGroupEntity);
        }

        public void SaveOrUpdateMSummonsGroundsEntity(MSummonsGroundsEntity mSummonsGroundsEntity)
        {
            MasterGateway masterGateway = new MasterGateway();
            masterGateway.SaveOrUpdateMSummonsGrounds(mSummonsGroundsEntity);
        }

        public void SaveOrUpdateMSummonsPrayersEntity(MSummonsPrayersEntity mSummonsPrayersEntity)
        {
            MasterGateway masterGateway = new MasterGateway();
            masterGateway.SaveOrUpdateMSummonsPrayers(mSummonsPrayersEntity);
        }

        public void SaveOrUpdateSolicitorAddressEntity(SolicitorAddressEntity solicitorAddressEntity)
        {
            LawFirmGateway lawFirmGateway = new LawFirmGateway();
            lawFirmGateway.SaveOrUpdateSolicitorAddress(solicitorAddressEntity);
        }

        public List<RMSectionAccessCtrlEntity> GetAllRMSectionAccessCtrlEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMSectionAccessCtrl();
        }


        public List<MHRGPredefinedDateEntity> GetAllMHRGPredefinedDate()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMHRGPredefinedDate();
        }


        public List<RMCaseTypeHRGTypeJOLEntity> GetAllRMCaseTypeHRGTypeJOL()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMCaseTypeHRGTypeJOL();
        }


        public List<InterfaceLawSocLawFirmEntity> GetAllInterfaceLawSocLawFirm()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllInterfaceLawSocLawFirm();
        }

        public List<InterfaceLawSocLawFirmAddressEntity> GetAllInterfaceLawSocLawFirmAddress()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllInterfaceLawSocLawFirmAddress();
        }

        public List<RMSubCaseTypeHRGTypeMSTypeEntity> GetAllRMSubCaseTypeHRGTypeMSType()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMSubCaseTypeHRGTypeMSType();
        }

        public RMSubCaseTypeHRGTypeMSTypeEntity GetRMSubCaseTypeHRGTypeMSTypeEntity(string forumId, string SubCaseTypeCode, string HRGTypeCode, string MSType)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetRMSubCaseTypeHRGTypeMSTypeEntity(forumId, SubCaseTypeCode, HRGTypeCode, MSType);
        }

        public void SaveOrUpdateRMSubCaseTypeHRGTypeMSType(RMSubCaseTypeHRGTypeMSTypeEntity rMSubCaseTypeHRGTypeMSTypeEntity)
        {
            MasterGateway masterGateway = new MasterGateway();
            masterGateway.SaveOrUpdateRMSubCaseTypeHRGTypeMSType(rMSubCaseTypeHRGTypeMSTypeEntity);
        }

        public List<MSensitiveFilingACLEntity> GetAllMSensitiveFilingACL()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMSensitiveFilingACL();
        }

        public List<RMHearingRoutingSectionConfigEntity> GetListRMHearingRoutingSectionConfigEntity(string forumId)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRMHearingRoutingSectionConfig(forumId);
        }

        public List<MAlertEventTypeEntity> GetAllMAlertEventType()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMAlertEventType();
        }

        public List<RMAlertEventTypeRoleEntity> GetAllRMAlertEventTypeRole()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMAlertEventTypeRole();
        }

        public List<RAlertEventSubscribersEntity> GetAllRAlertEventSubscribers()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRAlertEventSubscribers();
        }

        public List<MBusinessJobLegalInfoEntity> GetAllMBusinessJobLegalInfo()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMBusinessJobLegalInfo();
        }

        public List<MBusinessJobLegalDetailEntity> GetAllMBusinessJobLegalDetail()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMBusinessJobLegalDetail();
        }

        public List<MEMSParamEntity> GetAllMEMSParam()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMEMSParamEntity();
        }

        public List<RMHearingRoutingSectionConfigEntity> GetAllRMHearingRoutingSectionConfig()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMHearingRoutingSectionConfig();
        }

        public List<MPaperMinuteSheetTypeEntity> GetAllMPaperMinuteSheetType()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMPaperMinuteSheetType();
        }

        public List<RAlertEventSubscribersEntity> GetListRAlertEventSubscribersByAlertEventType(string alertEventTypeCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRAlertEventSubscribersByAlertEventType(alertEventTypeCode);

        }

        public List<MFilingFeeTypeEntity> GetAllMFilingFeeType()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMFilingFeeType();
        }


        public List<MFilingFeeChargingMechanismEntity> GetListMFilingFeeChargingMechanism(string feeRuleCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListMFilingFeeChargingMechanism(feeRuleCode);
        }


        public List<MFilingFeeLegislationActEntity> GetAllMFilingFeeLegislationAct()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMFilingFeeLegislationAct();
        }

        public void SaveOrUpdateRRoleFunctionEntity(RRoleFunctionsEntity rRoleFunctionsEntity)
        {
            MasterGateway masterGateway = new MasterGateway();
            masterGateway.SaveOrUpdateRRoleFunctionEntity(rRoleFunctionsEntity);
        }


        public List<MCourtVacationEntity> GetAllMCourtVacation()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMCourtVacation();
        }

        public List<MForumTypeEntity> GetAllMForumTypeForSystemAdmin(string courtId)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMForumTypeForSystemAdmin(courtId);
        }
        public void DeleteRMRoutingSectionConfig(RMRoutingSectionConfigEntity rmRoutingSectionConfigEntity)
        {
            MasterGateway masterGateway = new MasterGateway();
            masterGateway.DeleteRMRoutingSectionConfig(rmRoutingSectionConfigEntity);
        }

        public void DeleteRMNOAForumHrgType(RMNOAForumHrgTypeEntity rMNOAForumHrgTypeEntity)
        {
            MasterGateway masterGateway = new MasterGateway();
            masterGateway.DeleteRMNOAForumHrgType(rMNOAForumHrgTypeEntity);
        }
        
        public List<MEMSRecTransModeEntity> GetAllMEMSRecTransModeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMEMSRecTransModeEntity();
        }

        public List<MEMSAdvertiserEntity> GetAllMEMSAdvertiserEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMEMSAdvertiserEntity();
        }

        public List<MEMSAppraiserEntity> GetAllMEMSAppraiserEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMEMSAppraiserEntity();
        }

        public List<MEMSAuctioneerEntity> GetAllMEMSAuctioneerEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMEMSAuctioneerEntity();
        }

        public List<MEMSSalesAgentEntity> GetAllMEMSSalesAgentEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMEMSSalesAgentEntity();
        }

        public List<MAASDisciplinaryTypeEntity> GetAllMAASDisciplinaryTypeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMAASDisciplinaryTypeEntity();
        }

        public List<MAASDisciplinaryResultTypeEntity> GetAllMAASDisciplinaryResultTypeEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMAASDisciplinaryResultTypeEntity();
        }

        public List<MAASUniversityEntity> GetAllMAASUniversityEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMAASUniversityEntity();
        }

        public List<RMHrgSlotNOCEntity> GetAllRMHrgSlotNOCEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMHrgSlotNOCEntity();
        }

        public void SaveOrUpdateRMRoutingSectionConfigEntity(RMRoutingSectionConfigEntity rmRoutingSectionConfigEntity, bool isCopy)
        {
            try
            {
                MasterGateway masterGateway = new MasterGateway();
                masterGateway.SaveOrUpdateRMRoutingSectionConfigEntity<IMaster>(MasterMapper.GetMasterEntity<IMasterEntity>(rmRoutingSectionConfigEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMasterEntity", ex);
                Logger.Error("Error in SaveOrUpdateMasterEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<MDefaultLoginPageEntity> GetAllMDefaultLoginPageEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMDefaultLoginPage();
        }

        public List<RMHrgSlotLegisEntity> GetAllRMHrgSlotLegisEntity()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMHrgSlotLegisEntity();
        }

        public void DeleteRMHrgSlotNOC(RMHrgSlotNOCEntity rMHrgSlotNOCEntity)
        {
            MasterGateway masterGateway = new MasterGateway();
            masterGateway.DeleteRMHrgSlotNOC(rMHrgSlotNOCEntity);
        }

        public List<RMHrgSlotNOCEntity> GetListRMHrgSlotNOCEntityByForumID(string forumID)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRMHrgSlotNOCEntityByForumID(forumID);
        }

        public List<RMDocControlExclusionEntity> GetListRMDocControlExclusionByDocCode(string DocCode)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRMDocControlExclusionByDocCode(DocCode);
        }

        public List<RMDocControlExclusionEntity> GetAllRMDocControlExclusion()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllRMDocControlExclusion();
        }

        public List<MResidentialEntity> GetAllMResidential()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMResidential();
        }

        public List<MIncomeEntity> GetAllMIncome()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMIncome();
        }

        public List<MDirectionsEntity> GetAllMDirections()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMDirections();
        }

        public List<MHarassPlaceEntity> GetAllMHarassPlace()
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetAllMHarassPlace();
        }

        public List<RMHrgSlotLegisEntity> GetListRMHrgSlotLegisEntityByForumID(string forumID)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListRMHrgSlotLegisEntityByForumID(forumID);
        }

        #endregion
    }
}