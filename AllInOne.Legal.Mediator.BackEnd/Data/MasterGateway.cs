#region Header

/*****************************************************************************************************
* Description : This file handles calls Repository for database transaction.
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
// File: MasterGateway.cs
// Description: This file handles calls Repository for database transaction.
// </summary>
// <copyright file= "MasterGateway.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.MRelationship;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using NHibernate;
    using NHibernate.Criterion;
    using AllInOne.Legal.Domain.LawFirm;
    using System.Text;
    using log4net;
    internal class MasterGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MasterGateway));
        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        internal MasterGateway()
        {
            ApplicationSessionManager applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Passes the NHibernate DetachedCriteria and delete the entity.
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        internal int DeleteEntityByDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            List<T> listEntityToDelete = this.GetEntityByDetachedCriteria<T>(detachedCriteria);

            if (listEntityToDelete.Count > 0)
            {
                IRepository<T> iMasterRepository = new RepositoryImpl<T>(applicationSession);
                iMasterRepository.DeleteAll(listEntityToDelete);
            }

            return listEntityToDelete.Count;
        }

        internal List<MBailTypeEntity> GetAllMBailType()
        {
            List<MBailType> listMBailType = GetAllFromRepository<MBailType>();
            if (listMBailType != null && listMBailType.Count > 0)
            {
                return listMBailType.Select(mBailType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMBailTypeEntity(mBailType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MCaseTypeEntity> GetAllMCaseType()
        {
            List<MCaseType> listMCaseType = GetAllFromRepository<MCaseType>();
            if (listMCaseType != null && listMCaseType.Count > 0)
            {
                return listMCaseType.Select(mCaseType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCaseTypeEntity(mCaseType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MChargeTypeEntity> GetAllMChargeType()
        {
            List<MChargeType> listMChargeType = GetAllFromRepository<MChargeType>();
            if (listMChargeType != null && listMChargeType.Count > 0)
            {
                return listMChargeType.Select(mChargeType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMChargeTypeEntity(mChargeType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MCoramEntity> GetAllMCoram()
        {
            List<MCoram> listMCoram = GetAllFromRepository<MCoram>();
            if (listMCoram != null && listMCoram.Count > 0)
            {
                return listMCoram.Select(mCoram => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCoramEntity(mCoram)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MCountryEntity> GetAllMCountry()
        {
            List<MCountry> listMCountry = GetAllFromRepository<MCountry>();
            if (listMCountry != null && listMCountry.Count > 0)
            {
                return listMCountry.Select(mcountry => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCountryEntity(mcountry)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MCourtTypeEntity> GetAllMCourtType()
        {
            List<MCourtType> listMCourtType = GetAllFromRepository<MCourtType>();
            if (listMCourtType != null && listMCourtType.Count > 0)
            {
                return listMCourtType.Select(mCourtType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCourtTypeEntity(mCourtType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MCriminalClaimantTypeEntity> GetAllMCriminalClaimantType()
        {
            List<MCriminalClaimantType> listMCriminalClaimantType = GetAllFromRepository<MCriminalClaimantType>();
            if (listMCriminalClaimantType != null && listMCriminalClaimantType.Count > 0)
            {
                return listMCriminalClaimantType.Select(mCriminalClaimantType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCriminalClaimantTypeEntity(mCriminalClaimantType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MCriminalClaimTypeEntity> GetAllMCriminalClaimType()
        {
            List<MCriminalClaimType> listMCriminalClaimType = GetAllFromRepository<MCriminalClaimType>();
            if (listMCriminalClaimType != null && listMCriminalClaimType.Count > 0)
            {
                return listMCriminalClaimType.Select(mCriminalClaimType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCriminalClaimTypeEntity(mCriminalClaimType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MCriminalOrderEntity> GetAllMCriminalOrder()
        {
            List<MCriminalOrder> listMCriminalOrder = GetAllFromRepository<MCriminalOrder>();
            if (listMCriminalOrder != null && listMCriminalOrder.Count > 0)
            {
                return listMCriminalOrder.Select(mCriminalOrder => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCriminalOrderEntity(mCriminalOrder)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MCurrencyEntity> GetAllMCurrency()
        {
            List<MCurrency> listMCurrency = GetAllFromRepository<MCurrency>();
            if (listMCurrency != null && listMCurrency.Count > 0)
            {
                return listMCurrency.Select(mCurrency => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCurrencyEntity(mCurrency)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MDialectEntity> GetAllMDialect()
        {
            List<MDialect> listMDialect = GetAllFromRepository<MDialect>();
            if (listMDialect != null && listMDialect.Count > 0)
            {
                return listMDialect.Select(mDialect => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDialectEntity(mDialect)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MDocCategoryEntity> GetAllMDocCategory()
        {
            List<MDocCategory> listMDocCategory = GetAllFromRepository<MDocCategory>();
            if (listMDocCategory != null && listMDocCategory.Count > 0)
            {
                return listMDocCategory.Select(mDocCategory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocCategoryEntity(mDocCategory)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MDocSecurityEntity> GetAllMDocSecurity()
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<MDocSecurity>()
                .Add(Expression.Eq("ObsInd", "N"));

            List<MDocSecurity> listMDocSecurity = GetFromDetachedCriteria<MDocSecurity>(detachedCriteria);
            if (listMDocSecurity != null && listMDocSecurity.Count > 0)
            {
                return listMDocSecurity.Select(mDocSecurity => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocSecurityEntity(mDocSecurity)).ToList();
            }
            else
                return null;
        }

        internal List<MDrivingLicenseEntity> GetAllMDrivingLicense()
        {
            List<MDrivingLicense> listMDrivingLicense = GetAllFromRepository<MDrivingLicense>();
            if (listMDrivingLicense != null && listMDrivingLicense.Count > 0)
            {
                return listMDrivingLicense.Select(mDrivingLicense => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDrivingLicenseEntity(mDrivingLicense)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MDrugEntity> GetAllMDrug()
        {
            List<MDrug> listMDrug = GetAllFromRepository<MDrug>();
            if (listMDrug != null && listMDrug.Count > 0)
            {
                return listMDrug.Select(mDrug => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDrugEntity(mDrug)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MEMSWritApptEntity> GetAllMEMSWritApptEntity()
        {
            List<MEMSWritAppt> listMEMSWritAppt = GetAllFromRepository<MEMSWritAppt>();
            if (listMEMSWritAppt != null && listMEMSWritAppt.Count > 0)
            {
                return listMEMSWritAppt.Select(mEMSWritAppt => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMEMSWritApptDomain(mEMSWritAppt)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MEntityTypeEntity> GetAllMEntityType()
        {
            List<MEntityType> listMEntityType = GetAllFromRepository<MEntityType>();
            if (listMEntityType != null && listMEntityType.Count > 0)
            {
                return listMEntityType.Select(mEntityType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMEntityTypeEntity(mEntityType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MFormTemplateLocationEntity> GetAllMFormTemplateLocationEntity()
        {
            List<MFormTemplateLocation> listMFormTemplateLocation = GetAllFromRepository<MFormTemplateLocation>();
            if (listMFormTemplateLocation != null && listMFormTemplateLocation.Count > 0)
            {
                return listMFormTemplateLocation.Select(mFormTemplateLocation => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFormTemplateLocationEntity(mFormTemplateLocation)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MForumTypeEntity> GetAllMForumType()
        {
            List<MForumType> listMForumType = GetAllFromRepository<MForumType>();
            if (listMForumType != null && listMForumType.Count > 0)
            {
                return listMForumType.Select(mForumType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMForumTypeEntity(mForumType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MGenderEntity> GetAllMGender()
        {
            List<MGender> listMGender = GetAllFromRepository<MGender>();
            if (listMGender != null && listMGender.Count > 0)
            {
                return listMGender.Select(mGender => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMGenderEntity(mGender)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MHolidayEntity> GetAllMHoliday()
        {
            List<MHoliday> listMHoliday = GetAllFromRepository<MHoliday>();
            if (listMHoliday != null && listMHoliday.Count > 0)
            {
                return listMHoliday.Select(mHoliday => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHolidayEntity(mHoliday)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MHRGTypeEntity> GetAllMHrgType()
        {
            List<MHRGType> listMHRGType = GetAllFromRepository<MHRGType>();
            if (listMHRGType != null && listMHRGType.Count > 0)
            {
                return listMHRGType.Select(mHrgType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHRGTypeEntity(mHrgType)).ToList();
            }
            else
                return null;
        }

        internal List<MHRGUserAvailabilityEntity> GetAllMHRGUserAvailability()
        {
            List<MHRGUserAvailability> listMHRGUserAvailability = GetAllFromRepository<MHRGUserAvailability>();
            if (listMHRGUserAvailability != null && listMHRGUserAvailability.Count > 0)
            {
                return listMHRGUserAvailability.Select(mHRGUserAvailability => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHRGUserAvailabilityEntity(mHRGUserAvailability)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MIOOrganisationEntity> GetAllMIOOrganisation()
        {
            List<MIOOrganisation> listMIOOrganisation = GetAllFromRepository<MIOOrganisation>();
            if (listMIOOrganisation != null && listMIOOrganisation.Count > 0)
            {
                return listMIOOrganisation.Select(mIOOrganisation => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMIOOrganisationEntity(mIOOrganisation)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MLegalPracticeEntity> GetAllMLegalPractice()
        {
            List<MLegalPractice> listMLegalPractice = GetAllFromRepository<MLegalPractice>();
            if (listMLegalPractice != null && listMLegalPractice.Count > 0)
            {
                return listMLegalPractice.Select(mLegalPractice => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMLegalPracticeEntity(mLegalPractice)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MLegislationActEntity> GetAllMLegislationAct()
        {
            List<MLegislationAct> listMLegislationAct = GetAllFromRepository<MLegislationAct>();
            if (listMLegislationAct != null && listMLegislationAct.Count > 0)
            {
                return listMLegislationAct.Select(mLegislationAct => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMLegislationActEntity(mLegislationAct)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MLimitationsEntity> GetAllMLimitationsEntity()
        {
            List<MLimitations> listMLimitations = GetAllFromRepository<MLimitations>();
            if (listMLimitations != null && listMLimitations.Count > 0)
            {
                return listMLimitations.Select(mLimitations => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMLimitationsEntity(mLimitations)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MMaritalStatusEntity> GetAllMMaritalStatusEntity()
        {
            List<MMaritalStatus> listMMaritalStatus = GetAllFromRepository<MMaritalStatus>();
            if (listMMaritalStatus != null && listMMaritalStatus.Count > 0)
            {
                return listMMaritalStatus.Select(mMaritalStatus => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMMaritalStatusEntity(mMaritalStatus)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MModeOfTraffickingEntity> GetAllMModeOfTrafficking()
        {
            List<MModeOfTrafficking> listMModeOfTrafficking = GetAllFromRepository<MModeOfTrafficking>();
            if (listMModeOfTrafficking != null && listMModeOfTrafficking.Count > 0)
            {
                return listMModeOfTrafficking.Select(mModeOfTrafficking => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMModeOfTraffickingEntity(mModeOfTrafficking)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MNationalityEntity> GetAllMNationality()
        {
            List<MNationality> listMNationality = GetAllFromRepository<MNationality>();
            if (listMNationality != null && listMNationality.Count > 0)
            {
                return listMNationality.Select(mNationality => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMNationalityEntity(mNationality)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MNatureOfAppealEntity> GetAllMNatureOfAppeal()
        {
            List<MNatureOfAppeal> listMNatureOfAppeal = GetAllFromRepository<MNatureOfAppeal>();
            if (listMNatureOfAppeal != null && listMNatureOfAppeal.Count > 0)
            {
                return listMNatureOfAppeal.Select(mNatureOfAppeal => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMNatureOfAppealEntity(mNatureOfAppeal)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MNatureOfOffenceEntity> GetAllMNatureOfOffence()
        {
            List<MNatureOfOffence> listMNatureOfOffence = GetAllFromRepository<MNatureOfOffence>();
            if (listMNatureOfOffence != null && listMNatureOfOffence.Count > 0)
            {
                return listMNatureOfOffence.Select(mNatureOfOffence => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMNatureOfOffenceEntity(mNatureOfOffence)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MNOACodeEntity> GetAllMNOACode()
        {
            List<MNOACode> listMNOA = GetAllFromRepository<MNOACode>();
            if (listMNOA != null && listMNOA.Count > 0)
            {
                return listMNOA.Select(mNOA => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMNOACodeEntity(mNOA)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MOccupationEntity> GetAllMOccupation()
        {
            List<MOccupation> listMOccupation = GetAllFromRepository<MOccupation>();
            if (listMOccupation != null && listMOccupation.Count > 0)
            {
                return listMOccupation.Select(mOccupation => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMOccupationEntity(mOccupation)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MPartyStatusEntity> GetAllMPartyStatus()
        {
            List<MPartyStatus> listMPartyStatus = GetAllFromRepository<MPartyStatus>();
            if (listMPartyStatus != null && listMPartyStatus.Count > 0)
            {
                return listMPartyStatus.Select(mPartyStatus => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMPartyStatusEntity(mPartyStatus)).ToList();
            }
            else
                return null;
        }

        internal List<MPrisonEntity> GetAllMPrison()
        {
            List<MPrison> listMPrison = GetAllFromRepository<MPrison>();
            if (listMPrison != null && listMPrison.Count > 0)
            {
                return listMPrison.Select(mPrison => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMPrisonEntity(mPrison)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MProvisionEntity> GetAllMProvision()
        {
            List<MProvision> listMProvision = GetAllFromRepository<MProvision>();
            if (listMProvision != null && listMProvision.Count > 0)
            {
                return listMProvision.Select(mProvision => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMProvisionEntity(mProvision)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MQualificationEntity> GetAllMQualification()
        {
            List<MQualification> listMQualification = GetAllFromRepository<MQualification>();
            if (listMQualification != null && listMQualification.Count > 0)
            {
                return listMQualification.Select(mQualification => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMQualificationEntity(mQualification)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MRaceEntity> GetAllMRace()
        {
            List<MRace> listMRace = GetAllFromRepository<MRace>();
            if (listMRace != null && listMRace.Count > 0)
            {
                return listMRace.Select(mRace => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMRaceEntity(mRace)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MReligionEntity> GetAllMReligion()
        {
            List<MReligion> listMReligion = GetAllFromRepository<MReligion>();
            if (listMReligion != null && listMReligion.Count > 0)
            {
                return listMReligion.Select(mReligion => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMReligionEntity(mReligion)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MSentenceEntity> GetAllMSentence()
        {
            List<MSentence> listMSentence = GetAllFromRepository<MSentence>();
            if (listMSentence != null && listMSentence.Count > 0)
            {
                return listMSentence.Select(mSentence => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSentenceEntity(mSentence)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MSubProvisionEntity> GetAllMSubProvision()
        {
            List<MSubProvision> listMSubProvision = GetAllFromRepository<MSubProvision>();
            if (listMSubProvision != null && listMSubProvision.Count > 0)
            {
                return listMSubProvision.Select(mSubProvision => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSubProvisionEntity(mSubProvision)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MTaskListTypeEntity> GetAllMTaskListType()
        {
            List<MTaskListType> listMTaskListType = GetAllFromRepository<MTaskListType>();
            if (listMTaskListType != null && listMTaskListType.Count > 0)
            {
                return listMTaskListType.Select(mTaskListType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMTaskListTypeEntity(mTaskListType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMCaseTypeForumEntity> GetAllRMCaseTypeForumEntity()
        {
            List<RMCaseTypeForum> listRMCaseTypeForum = GetAllFromRepository<RMCaseTypeForum>();
            if (listRMCaseTypeForum != null && listRMCaseTypeForum.Count > 0)
            {
                return listRMCaseTypeForum.Select(rMCaseTypeForum => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMCaseTypeForumEntity(rMCaseTypeForum)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMCaseTypeNOAEntity> GetAllRMCaseTypeNOA(string caseTypeCode)
        {
            IRepository<RMCaseTypeNOA> rmCaseTypeNOARepository = new RepositoryImpl<RMCaseTypeNOA>(applicationSession);

            List<RMCaseTypeNOA> listRMCaseTypeNOA = GetListRMCaseTypeNOAByCaseTypeCode(caseTypeCode); //listRMCaseTypeNOA = GetAllFromRepository<RMCaseTypeNOA>();
            if (listRMCaseTypeNOA != null && listRMCaseTypeNOA.Count > 0)
            {
                return listRMCaseTypeNOA.Select(rmCaseTypeNOA => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMCaseTypeNOAEntity(rmCaseTypeNOA)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMCaseTypeNOAEntity> GetAllRMCaseTypeNOA()
        {
            List<RMCaseTypeNOA> listRMCaseTypeNOA = GetAllFromRepository<RMCaseTypeNOA>();

            if (listRMCaseTypeNOA != null && listRMCaseTypeNOA.Count > 0)
            {
                return listRMCaseTypeNOA.Select(rmCaseTypeNOA => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMCaseTypeNOAEntity(rmCaseTypeNOA)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets all data in the entity
        /// </summary>
        /// <returns>List<typeparam name="T"></typeparam></returns>
        internal List<T> GetEntity<T>()
        {
            IRepository<T> iMasterRepository = new RepositoryImpl<T>(applicationSession);
            return iMasterRepository.GetAll() as List<T>;
        }

        /// <summary>
        /// Passes the <paramref name="columnName"/> and <paramref name="value"/>. Get the <typeparam name="T"></typeparam> back.
        /// </summary>
        /// <typeparam name="V">Type of the value to use as a filter.</typeparam>
        /// <param name="columnName">The name of the filed to filter while retrieving objects.</param>
        /// <param name="value">The value of the filed to filter while retrieving objects.</param>
        /// <returns>List<T></returns>
        internal List<T> GetEntity<T, V>(string columnName, V value)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            return iRepository.GetAll(this.GetDetachedCriteria<T, V>(columnName, value)) as List<T>;
        }

        /// <summary>
        /// Passes the NHibernate DetachedCriteria and gets the entity
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns>List<typeparam name="T"></typeparam></returns>
        internal List<T> GetEntityByDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> iMasterRepository = new RepositoryImpl<T>(applicationSession);
            return iMasterRepository.GetAll(detachedCriteria) as List<T>;
        }

        internal List<MBusinessJobLegalDetailEntity> GetListMBusinessJobLegalDetailEntity(string businessJobLegalInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MBusinessJobLegalDetail))
                .Add(Expression.Eq("BusinessJobLegalInfoId", businessJobLegalInfoId));
            List<MBusinessJobLegalDetail> listMBusinessJobLegalDetail = GetFromDetachedCriteria<MBusinessJobLegalDetail>(detachedCriteria);
            if (listMBusinessJobLegalDetail != null && listMBusinessJobLegalDetail.Count > 0)
            {
                return listMBusinessJobLegalDetail.Select(mBusinessJobLegalDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMBusinessJobLegalDetailEntity(mBusinessJobLegalDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MChecklistEntity> GetListMChecklist(string caseType)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MChecklist)).Add(Expression.Eq("CaseType", caseType));
            List<MChecklist> listMChecklist = GetMCheckList(detachedCriteria);
            if (listMChecklist != null && listMChecklist.Count > 0)
            {
                return listMChecklist.Select(mcheckList => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMChecklistEntity(mcheckList)).ToList();
            }
            else
                return null;
        }

        internal List<MChecklistDocumentEntity> GetListMChecklistDocument(long checkListId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MChecklistDocument)).Add(Expression.Eq("ChecklistId", checkListId));
            List<MChecklistDocument> listMChecklistDocument = GetMChecklistDocument(detachedCriteria);
            if (listMChecklistDocument != null && listMChecklistDocument.Count > 0)
            {
                return listMChecklistDocument.Select(mChecklistDocument => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMChecklistDocumentEntity(mChecklistDocument)).ToList();
            }
            else
                return null;
        }

        internal List<MDocControlEntity> GetListMDocControlByDocCode(string docCode)
        {
            if (!string.IsNullOrEmpty(docCode))
            {
                MDocCode mMDocCode = new MDocCode { DOCCode = docCode };
                DetachedCriteria detachedCriteria = DetachedCriteria.For<MDocControl>()
                              .Add(Expression.Eq("MDocCode", mMDocCode));
                List<MDocControl> listMDocControl = GetFromDetachedCriteria<MDocControl>(detachedCriteria);
                if (listMDocControl != null && listMDocControl.Count > 0)
                {
                    return listMDocControl.Select(mDocControl => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocControlEntity(mDocControl)).ToList();
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

        internal List<MFunctionsEntity> GetListMFunctionsEntity(string roleCode)
        {
            var subCriteria = DetachedCriteria.For(typeof(RRoleFunctions));
            subCriteria.SetProjection(Projections.Property("FunctionCode")).Add(Expression.Eq("RoleCode", roleCode))
               .Add(Expression.Eq("ObsInd", "N"));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(MFunctions)).Add(Subqueries.PropertyIn("FunctionCode", subCriteria));

            IRepository<MFunctions> mFunctionsRepository = new RepositoryImpl<MFunctions>(applicationSession);
            List<MFunctions> listMFunctions = mFunctionsRepository.FindAll(iCriterion).ToList();
            if (listMFunctions != null && listMFunctions.Count > 0)
            {
                return listMFunctions.Select(mFunctions => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFunctionsEntity(mFunctions)).ToList();
            }
            else
                return null;
        }

        internal List<MHRGTypeEntity> GetListMHRGTypeEntity(string hRGTypeCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<MHRGType>()
                                              .Add(Expression.Eq("HRGTypeCode", hRGTypeCode));
            List<MHRGType> listMHRGType = GetEntityByDetachedCriteria<MHRGType>(detachedCriteria);
            if (listMHRGType != null && listMHRGType.Count > 0)
            {
                return listMHRGType.Select(mHRGType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHRGTypeEntity(mHRGType)).ToList();
            }
            else
                return null;
        }

        internal List<MPersonIDGroupEntity> GetListMPersonIDGroupOrderBySeqNo()
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<MPersonIDGroup>().AddOrder(Order.Asc("SeqNo"));
            List<MPersonIDGroup> listMPersonIDGroup = GetEntityByDetachedCriteria<MPersonIDGroup>(detachedCriteria);
            if (listMPersonIDGroup != null && listMPersonIDGroup.Count > 0)
            {
                return listMPersonIDGroup.Select(mPersonIDGroup => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMPersonIDGroupEntity(mPersonIDGroup)).ToList();
            }
            else
                return null;
        }

        internal List<MPersonIDTypeEntity> GetListMPersonIDTypeEntityByEntityType(string entityTypeCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<MPersonIDType>()
                                              .Add(Expression.Eq("EntityTypeCode", entityTypeCode));
            List<MPersonIDType> listMPersonIDType = GetEntityByDetachedCriteria<MPersonIDType>(detachedCriteria);
            if (listMPersonIDType != null && listMPersonIDType.Count > 0)
            {
                return listMPersonIDType.Select(mPersonIDType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMPersonIDTypeEntity(mPersonIDType)).ToList();
            }
            else
                return null;
        }

        internal List<MSectionEntity> GetListMsectionByUser(string userId)
        {
            var subCriteria = DetachedCriteria.For(typeof(RUserRoleSection));
            subCriteria.SetProjection(Projections.Property("SectionCode")).Add(Expression.Eq("UserId", userId));

            NHibernate.ICriteria iCriterion = applicationSession.CreateCriteria(typeof(MSection)).Add(Subqueries.PropertyIn("SectionCode", subCriteria));

            IRepository<MSection> mSectionRepository = new RepositoryImpl<MSection>(applicationSession);
            List<MSection> listMSection = mSectionRepository.FindAll(iCriterion).ToList();
            if (listMSection != null && listMSection.Count > 0)
            {
                return listMSection.Select(mSection => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSectionEntity(mSection)).ToList();
            }
            else
                return null;
        }

        internal List<RMDocCodeHrgTypeEntity> GetListRMDocCodeHrgType(string docCode, string caseTypeCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMDocCodeHRGType>()
                                              .Add(Expression.Eq("DocCode", docCode))
                                              .Add(Expression.Eq("CaseTypeCode", caseTypeCode));

            List<RMDocCodeHRGType> listRMDocCodeHRGType = GetEntityByDetachedCriteria<RMDocCodeHRGType>(detachedCriteria);
            if (listRMDocCodeHRGType != null && listRMDocCodeHRGType.Count > 0)
            {
                return listRMDocCodeHRGType.Select(rMDocCodeHRGType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMDocCodeHrgTypeEntity(rMDocCodeHRGType)).ToList();
            }
            else
                return null;
        }

        internal List<RMDocCodeHrgTypeEntity> GetListRMDocCodeHrgType(string docCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMDocCodeHRGType>()
                                               .Add(Expression.Eq("DocCode", docCode));

            List<RMDocCodeHRGType> listRMDocCodeHRGType = GetEntityByDetachedCriteria<RMDocCodeHRGType>(detachedCriteria);
            if (listRMDocCodeHRGType != null && listRMDocCodeHRGType.Count > 0)
            {
                return listRMDocCodeHRGType.Select(rMDocCodeHRGType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMDocCodeHrgTypeEntity(rMDocCodeHRGType)).ToList();
            }
            else
                return null;
        }

        internal List<RMHRGTypeHRGSlotEntity> GetListRMHrgTypeHrgSlot(string CourtInd, string HRGTypeCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMHRGTypeHRGSlot>()
                                                .Add(Expression.Eq("CourtInd", CourtInd))
                                                .Add(Expression.Eq("HRGTypeCode", HRGTypeCode));

            List<RMHRGTypeHRGSlot> listRMHRGTypeHRGSlot = GetEntityByDetachedCriteria<RMHRGTypeHRGSlot>(detachedCriteria);
            if (listRMHRGTypeHRGSlot != null && listRMHRGTypeHRGSlot.Count > 0)
            {
                return listRMHRGTypeHRGSlot.Select(rMHRGTypeHRGSlot => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMHRGTypeHRGSlotEntity(rMHRGTypeHRGSlot)).ToList();
            }
            else
                return null;
        }

        internal List<RMNOAForumHrgTypeEntity> GetListRMNOAForumHrgType(string NOACode, string ForumId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMNOAForumHrgType>()
                                               .Add(Expression.Eq("NOACode", NOACode))
                                               .Add(Expression.Eq("ForumID", ForumId));

            List<RMNOAForumHrgType> listRMNOAForumHrgType = GetEntityByDetachedCriteria<RMNOAForumHrgType>(detachedCriteria);
            if (listRMNOAForumHrgType != null && listRMNOAForumHrgType.Count > 0)
            {
                return listRMNOAForumHrgType.Select(rMNOAForumHrgType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMNOAForumHrgTypeEntity(rMNOAForumHrgType)).ToList();
            }
            else
                return null;
        }

        internal List<RMNOAForumHrgTypeEntity> GetListRMNOAForumHrgType(string NOACode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMNOAForumHrgType>()
                                               .Add(Expression.Eq("NOACode", NOACode));

            List<RMNOAForumHrgType> listRMNOAForumHrgType = GetEntityByDetachedCriteria<RMNOAForumHrgType>(detachedCriteria);
            if (listRMNOAForumHrgType != null && listRMNOAForumHrgType.Count > 0)
            {
                return listRMNOAForumHrgType.Select(rMNOAForumHrgType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMNOAForumHrgTypeEntity(rMNOAForumHrgType)).ToList();
            }
            else
                return null;
        }

        internal List<RMPartyStatusCaseTypeEntity> GetListRMPartyStatusCaseTypeEntity(string caseTypeCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMPartyStatusCaseType>()
               .Add(Expression.Eq("CaseTypeCode", caseTypeCode));
            List<RMPartyStatusCaseType> listRMPartyStatusCaseType = GetFromDetachedCriteria<RMPartyStatusCaseType>(detachedCriteria);
            if (listRMPartyStatusCaseType != null && listRMPartyStatusCaseType.Count > 0)
            {
                return listRMPartyStatusCaseType.Select(rMPartyStatusCaseType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMPartyStatusCaseTypeEntity(rMPartyStatusCaseType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMRoutingSectionConfigEntity> GetListRMRoutingSectionConfig(string forumId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMRoutingSectionConfig>()
                .Add(Expression.Eq("ForumId", forumId));

            List<RMRoutingSectionConfig> listRMRoutingSectionConfig = GetFromDetachedCriteria<RMRoutingSectionConfig>(detachedCriteria);

            if (listRMRoutingSectionConfig != null && listRMRoutingSectionConfig.Count > 0)
            {
                return listRMRoutingSectionConfig.Select(rmRoutingSectionConfig => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMRoutingSectionConfigEntity(rmRoutingSectionConfig)).ToList();
            }
            else
                return null;
        }

        internal List<RUserRoleSectionEntity> GetListRUserRoleSection(string roleCode, string sectionCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RUserRoleSection))
                .Add(Expression.And(Expression.Eq("RoleCode", roleCode), Expression.Eq("SectionCode", sectionCode)));
            List<RUserRoleSection> listRUserRoleSection = GetEntityByDetachedCriteria<RUserRoleSection>(detachedCriteria);
            if (listRUserRoleSection != null && listRUserRoleSection.Count > 0)
            {
                return listRUserRoleSection.Select(ruserRoleSection => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRUserRoleSectionEntity(ruserRoleSection)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RUserRoleSectionEntity> GetListRUserRoleSectionByRoleCode(string roleCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RUserRoleSection))
                .Add(Expression.Eq("RoleCode", roleCode));
            List<RUserRoleSection> listRUserRoleSection = GetEntityByDetachedCriteria<RUserRoleSection>(detachedCriteria);
            if (listRUserRoleSection != null && listRUserRoleSection.Count > 0)
            {
                return listRUserRoleSection.Select(ruserRoleSection => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRUserRoleSectionEntity(ruserRoleSection)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RUserRoleSectionEntity> GetListRUserRoleSectionBySectionCode(string sectionCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RUserRoleSection))
                .Add(Expression.Eq("SectionCode", sectionCode));
            List<RUserRoleSection> listRUserRoleSection = GetEntityByDetachedCriteria<RUserRoleSection>(detachedCriteria);
            if (listRUserRoleSection != null && listRUserRoleSection.Count > 0)
            {
                return listRUserRoleSection.Select(ruserRoleSection => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRUserRoleSectionEntity(ruserRoleSection)).ToList();
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Gets the master entity by PK.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        internal IMasterEntity GetMasterEntityByPK<T>(string primaryKey)
        {
            string entityName = typeof(T).Name;

            switch (entityName)
            {
                case ("MCountryEntity"):
                    return GetMCountryByPK(primaryKey);
                case ("MCurrencyEntity"):
                    return GetMCurrencyByPK(primaryKey);
                case ("MDialectEntity"):
                    return GetMDialectByPK(primaryKey);
                case ("MGenderEntity"):
                    return GetMGenderByPK(primaryKey);
                case ("MReligionEntity"):
                    return GetMReligionByPK(primaryKey);
                case ("MHolidayEntity"):
                    return GetMHolidayByPK(primaryKey);
                case ("MLegalPracticeEntity"):
                    return GetMLegalPracticeByPK(primaryKey);
                case ("MLegislationActEntity"):
                    return GetMLegislationAct(primaryKey);
                case ("MLimitationsEntity"):
                    return GetMLimitationsByPK(primaryKey);
                case ("MMaritalStatusEntity"):
                    return GetMMaritalStatusByPK(primaryKey);
                case ("MNationalityEntity"):
                    return GetMNationalityByPK(primaryKey);
                case ("MQualificationEntity"):
                    return GetMQualificationByPK(primaryKey);
                case ("MRaceEntity"):
                    return GetMRaceByPK(primaryKey);
                case ("MCaseTypeEntity"):
                    return GetMCaseType(primaryKey);
                case ("MFormTemplateLocationEntity"):
                    return GetMFormTemplateLocationByPK(primaryKey);
                case ("MForumTypeEntity"):
                    return GetMForumTypeByPK(primaryKey);
                case ("MCourtTypeEntity"):
                    return GetMCourtTypeByPK(primaryKey);
                case ("MNOACodeEntity"):
                    return GetMNOACodeByPK(primaryKey);
                case ("MCoramEntity"):
                    return GetMCoramByPK(primaryKey);
                case ("MDocCategoryEntity"):
                    return GetMDocCategoryByPK(primaryKey);
                case ("MDesignationEntity"):
                    return GetMDesignationByPK(primaryKey);
                case ("MHearingTypeEntity"):
                    return GetMHearingTypeByPK(primaryKey);
                case ("MHRGRoomEntity"):
                    return GetMHRGRoomByPK(primaryKey);
                case ("RMHRGTypeHRGOutComeHRGOutComeFlagEntity"):
                    return GetRMHRGTypeHRGOutComeHRGOutComeFlagByPK(primaryKey);
                case ("MHRGOutComeFlagEntity"):
                    return GetMHRGOutComeFlagEntityByPK(primaryKey);
                case ("MHRGOutComeReasonEntity"):
                    return GetMHRGOutComeReasonEntityByPK(primaryKey);
                case ("RMNOAForumHrgTypeEntity"):
                    return GetRMNOAForumHrgTypeEntityByPK(primaryKey);
                case ("MDocCodeEntity"):
                    return GetMDocCodeEntityByPK(primaryKey);
                case ("MDocControlEntity"):
                    return GetMDocControlEntityByPK(primaryKey);
                case ("MFilingFeeEntity"):
                    return GetMFilingFeeEntityByPK(primaryKey);
                case ("MFilterGroupEntity"):
                    return GetMFilterGroupEntityByPK(primaryKey);
                case ("MSummonsParamEntity"):
                    return GetMSummonsParamEntityByPK(primaryKey);
                case ("MAASLawDegreeEntity"):
                    return GetMAASLawDegreeEntityByPK(primaryKey);
                case ("MMassCallHrgDateEntity"):
                    return GetMMassCallHrgDateEntityByPK(primaryKey);
                case ("MChargeOutcomeEntity"):
                    return GetMChargeOutcomeEntityByPK(primaryKey);
                case ("MPrinterEntity"):
                    return GetMPrinterEntityByPK(primaryKey);
                case ("MLawFirmGroupEntity"):
                    return GetMLawFirmGroupEntityByPK(primaryKey);

                case ("MVSAConfigDetailEntity"):
                    return GetMVSAConfigDetailEntityByPK(primaryKey);

                case ("MVSAConfigGroundEntity"):
                    return GetMVSAConfigGroundEntityByPK(primaryKey);

                case ("MVSAConfigPrayerEntity"):
                    return GetMVSAConfigPrayerEntityByPK(primaryKey);

                case ("MFilingFeeChargingMechanismEntity"):
                    return GetMFilingFeeChargingMechanismEntityByPK(primaryKey);

                case ("RMSectionAccessCtrlEntity"):
                    return GetRMSectionAccessCtrlEntityByPK(primaryKey);

                case ("MHRGPredefinedDateEntity"):
                    return GetMHRGPredefinedDateEntityByPK(primaryKey);

                case ("RMCaseTypeHRGTypeJOLEntity"):
                    return GetRMCaseTypeHRGTypeJOLEntityByPK(primaryKey);

                case ("MSensitiveFilingACLEntity"):
                    return GetMSensitiveFilingACLEntityByPK(primaryKey);

                case ("MNatureOfOffenceEntity"):
                    return GetMNatureOfOffence(primaryKey);

                case ("MAlertEventTypeEntity"):
                    return GetMAlertEventTypeEntityByPK(primaryKey);

                case ("RMAlertEventTypeRoleEntity"):
                    return GetRMAlertEventTypeRoleEntityPK(primaryKey);

                case ("RAlertEventSubscribersEntity"):
                    return GetRAlertEventSubscribersEntityByPK(primaryKey);

                case ("MBusinessJobLegalInfoEntity"):
                    return GetMBusinessJobLegalInfoEntity(primaryKey);

                case ("MBusinessJobLegalDetailEntity"):
                    return GetMBusinessJobLegalInfoEntity(primaryKey);

                case ("MEMSParamEntity"):
                    return GetMEMSParamEntity(primaryKey);

                case ("RMHearingRoutingSectionConfigEntity"):
                    return GetRMHearingRoutingSectionConfigEntity(primaryKey);

                case ("MPaperMinuteSheetTypeEntity"):
                    return GetMPaperMinuteSheetEntity(primaryKey);

                case ("MFilingFeeLegislationActEntity"):
                    return GetMFilingFeeLegislationActEntity(primaryKey);

                case ("MCourtVacationEntity"):
                    return GetMCourtVacationEntity(primaryKey);
                
                case ("MEMSRecTransModeEntity"):
                    return GetMEMSRecTransModeEntity(primaryKey);

                case("MEMSAdvertiserEntity"):
                    return GetMEMSAdvertiserEntity(primaryKey);

                case("MEMSAppraiserEntity"):
                    return GetMEMSAppraiserEntity(primaryKey);

                case("MEMSAuctioneerEntity"):
                    return GetMEMSAuctioneerEntity(primaryKey);

                case("MEMSSalesAgentEntity"):
                    return GetMEMSSalesAgentEntity(primaryKey);
                    
                case("MAASDisciplinaryTypeEntity"):
                    return GetMAASDisciplinaryTypeEntity(primaryKey);

                case ("MAASDisciplinaryResultTypeEntity"):
                    return GetMAASDisciplinaryResultTypeEntity(primaryKey);

                case ("MAASUniversityEntity"):
                    return GetMAASUniversityEntity(primaryKey);
                default:
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetMasterEntityByPK");

            }
        }

        private IMasterEntity GetMAASUniversityEntity(string primaryKey)
        {
            IRepository<MAASUniversity> repository = new RepositoryImpl<MAASUniversity>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMAASUniversityEntity(repository.Get(primaryKey));

        }

        private IMasterEntity GetMAASDisciplinaryResultTypeEntity(string primaryKey)
        {
       
            IRepository<MAASDisciplinaryResultType> repository = new RepositoryImpl<MAASDisciplinaryResultType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMAASDisciplinaryResultTypeEntity(repository.Get(primaryKey));

        }

        private IMasterEntity GetMAASDisciplinaryTypeEntity(string primaryKey)
        {
            IRepository<MAASDisciplinaryType> repository = new RepositoryImpl<MAASDisciplinaryType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMAASDisciplinaryTypeEntity(repository.Get(primaryKey));

        }

        private IMasterEntity GetMEMSSalesAgentEntity(string primaryKey)
        {
            IRepository<MEMSSalesAgent> repository = new RepositoryImpl<MEMSSalesAgent>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMEMSSalesAgentDomain(repository.Get(primaryKey));

        }

        private IMasterEntity GetMEMSAuctioneerEntity(string primaryKey)
        {
            IRepository<MEMSAuctioneer> repository = new RepositoryImpl<MEMSAuctioneer>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMEMSAuctioneerDomain(repository.Get(primaryKey));

        }

        private IMasterEntity GetMEMSAppraiserEntity(string primaryKey)
        {
            IRepository<MEMSAppraiser> repository = new RepositoryImpl<MEMSAppraiser>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMEMSAppraiserDomain(repository.Get(primaryKey));

        }

        private IMasterEntity GetMEMSAdvertiserEntity(string primaryKey)
        {
            IRepository<MEMSAdvertiser> repository = new RepositoryImpl<MEMSAdvertiser>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMEMSAdvertiserDomain(repository.Get(primaryKey));

        }

        private IMasterEntity GetMEMSRecTransModeEntity(string primaryKey)
        {
            IRepository<MEMSRecTransMode> repository = new RepositoryImpl<MEMSRecTransMode>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMEMSRecTransModeDomain(repository.Get(primaryKey));

        }

        private IMasterEntity GetMCourtVacationEntity(string primaryKey)
        {
            IRepository<MCourtVacation> repository = new RepositoryImpl<MCourtVacation>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCourtVacationEntity(repository.Get(primaryKey));

        }

        private IMasterEntity GetMFilingFeeLegislationActEntity(string primaryKey)
        {
            IRepository<MFilingFeeLegislationAct> repository = new RepositoryImpl<MFilingFeeLegislationAct>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFilingFeeLegislationActEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMPaperMinuteSheetEntity(string primaryKey)
        {
            IRepository<MPaperMinuteSheetType> repository = new RepositoryImpl<MPaperMinuteSheetType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMPaperMinuteSheetTypeEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetRMHearingRoutingSectionConfigEntity(string primaryKey)
        {
            IRepository<RMHearingRoutingSectionConfig> repository = new RepositoryImpl<RMHearingRoutingSectionConfig>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMHearingRoutingSectionConfigEntity(repository.Get(primaryKey));

        }

        private MEMSParamEntity GetMEMSParamEntity(string primaryKey)
        {
            IRepository<MEMSParam> repository = new RepositoryImpl<MEMSParam>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMEMSParamDomain(repository.Get(primaryKey));

        }

        private IMasterEntity GetMAlertEventTypeEntityByPK(string primaryKey)
        {
            IRepository<MAlertEventType> repository = new RepositoryImpl<MAlertEventType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMAlertEventTypeEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetRMAlertEventTypeRoleEntityPK(string primaryKey)
        {
            IRepository<RMAlertEventTypeRole> repository = new RepositoryImpl<RMAlertEventTypeRole>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMAlertEventTypeRoleEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetRAlertEventSubscribersEntityByPK(string primaryKey)
        {
            IRepository<RAlertEventSubscribers> repository = new RepositoryImpl<RAlertEventSubscribers>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRAlertEventSubscribersEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMSensitiveFilingACLEntityByPK(string primaryKey)
        {
            IRepository<MSensitiveFilingACL> repository = new RepositoryImpl<MSensitiveFilingACL>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSensitiveFilingACLEntity(repository.Get(primaryKey));

        }

        private IMasterEntity GetRMCaseTypeHRGTypeJOLEntityByPK(string primaryKey)
        {
            IRepository<RMCaseTypeHRGTypeJOL> repository = new RepositoryImpl<RMCaseTypeHRGTypeJOL>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMCaseTypeHRGTypeJOLEntity(repository.Get(primaryKey));

        }

        private IMasterEntity GetMHRGPredefinedDateEntityByPK(string primaryKey)
        {
            IRepository<MHRGPredefinedDate> repository = new RepositoryImpl<MHRGPredefinedDate>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHRGPredefinedDateEntity(repository.Get(primaryKey));

        }

        private IMasterEntity GetRMSectionAccessCtrlEntityByPK(string primaryKey)
        {
            IRepository<RMSectionAccessCtrl> repository = new RepositoryImpl<RMSectionAccessCtrl>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMSectionAccessCtrlEntity(repository.Get(primaryKey));

        }

        private IMasterEntity GetMFilingFeeChargingMechanismEntityByPK(string primaryKey)
        {
            IRepository<MFilingFeeChargingMechanism> repository = new RepositoryImpl<MFilingFeeChargingMechanism>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFilingFeeChargingMechanismEntity(repository.Get(primaryKey));

        }

        private IMasterEntity GetMVSAConfigPrayerEntityByPK(string primaryKey)
        {
            IRepository<MVSAConfigPrayer> repository = new RepositoryImpl<MVSAConfigPrayer>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMVSAConfigPrayerEntity(repository.Get(primaryKey));

        }

        private IMasterEntity GetMVSAConfigGroundEntityByPK(string primaryKey)
        {
            IRepository<MVSAConfigGround> repository = new RepositoryImpl<MVSAConfigGround>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMVSAConfigGroundEntity(repository.Get(primaryKey));

        }

        private IMasterEntity GetMVSAConfigDetailEntityByPK(string primaryKey)
        {
            IRepository<MVSAConfigDetail> repository = new RepositoryImpl<MVSAConfigDetail>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMVSAConfigDetailEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the M law firm group entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetMLawFirmGroupEntityByPK(string primaryKey)
        {
            IRepository<MLawFirmGroup> repository = new RepositoryImpl<MLawFirmGroup>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMLawFirmGroupEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the M printer entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetMPrinterEntityByPK(string primaryKey)
        {
            IRepository<MPrinter> repository = new RepositoryImpl<MPrinter>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMPrinterEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the M charge outcome entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetMChargeOutcomeEntityByPK(string primaryKey)
        {
            IRepository<MChargeOutcome> repository = new RepositoryImpl<MChargeOutcome>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMChargeOutcomeEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the M mass call HRG date entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetMMassCallHrgDateEntityByPK(string primaryKey)
        {
            IRepository<MMassCallHrgDate> repository = new RepositoryImpl<MMassCallHrgDate>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMMassCallHrgDateEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the MAAS law degree entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetMAASLawDegreeEntityByPK(string primaryKey)
        {
            IRepository<MAASLawDegree> repository = new RepositoryImpl<MAASLawDegree>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMAASLawDegreeEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the M summons param entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetMSummonsParamEntityByPK(string primaryKey)
        {
            IRepository<MSummonsParam> repository = new RepositoryImpl<MSummonsParam>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSummonsParamEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the M filter group entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetMFilterGroupEntityByPK(string primaryKey)
        {
            IRepository<MFilterGroup> repository = new RepositoryImpl<MFilterGroup>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFilterGroupEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the M filing fee entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetMFilingFeeEntityByPK(string primaryKey)
        {
            IRepository<MFilingFee> repository = new RepositoryImpl<MFilingFee>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFilingFeeEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the M doc control entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetMDocControlEntityByPK(string primaryKey)
        {
            IRepository<MDocControl> repository = new RepositoryImpl<MDocControl>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocControlEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the M doc code entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetMDocCodeEntityByPK(string primaryKey)
        {
            IRepository<MDocCode> repository = new RepositoryImpl<MDocCode>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocCodeEntity(repository.Get(primaryKey));

        }


        /// <summary>
        /// Gets all M doc control.
        /// </summary>
        /// <returns></returns>
        internal List<MDocControlEntity> GetAllMDocControl()
        {
            List<MDocControl> listMDocControl = GetAllFromRepository<MDocControl>();
            if (listMDocControl != null && listMDocControl.Count > 0)
            {
                return listMDocControl.Select(mDocControl => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
                    .MasterMapper.GetMDocControlEntity(mDocControl)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the RMNOA forum HRG type entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetRMNOAForumHrgTypeEntityByPK(string primaryKey)
        {
            IRepository<RMNOAForumHrgType> repository = new RepositoryImpl<RMNOAForumHrgType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMNOAForumHrgTypeEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the MHRG out come reason entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetMHRGOutComeReasonEntityByPK(string primaryKey)
        {
            IRepository<MHRGOutComeReason> repository = new RepositoryImpl<MHRGOutComeReason>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHRGOutComeReasonEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the MHRG out come flag entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetMHRGOutComeFlagEntityByPK(string primaryKey)
        {
            IRepository<MHRGOutComeFlag> repository = new RepositoryImpl<MHRGOutComeFlag>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHRGOutComeFlagEntity(repository.Get(primaryKey));
        }

        /// <summary>
        /// Gets the RMHRG type HRG out come HRG out come flag by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private IMasterEntity GetRMHRGTypeHRGOutComeHRGOutComeFlagByPK(string primaryKey)
        {
            IRepository<RMHRGTypeHRGOutComeHRGOutComeFlag> repository = new RepositoryImpl<RMHRGTypeHRGOutComeHRGOutComeFlag>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMHRGTypeHRGOutComeHRGOutComeFlagEntity(repository.Get(primaryKey));
        }


        private IMasterEntity GetMHRGRoomByPK(string primaryKey)
        {
            IRepository<MHRGRoom> repository = new RepositoryImpl<MHRGRoom>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHRGRoomEntity(repository.Get(primaryKey));

        }

        private IMasterEntity GetMHearingTypeByPK(string primaryKey)
        {
            IRepository<MHearingType> repository = new RepositoryImpl<MHearingType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHearingTypeEntity(repository.Get(primaryKey));

        }

        internal MBailTypeEntity GetMBailType(string bailTypeCode)
        {
            IRepository<MBailType> mBailTypeEntityRepository = new RepositoryImpl<MBailType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMBailTypeEntity(mBailTypeEntityRepository.Get(bailTypeCode));
        }

        internal MBusinessJobLegalInfoEntity GetMBusinessJobLegalInfoEntity(string businessJobLegalInfoId)
        {
            IRepository<MBusinessJobLegalInfo> mBusinessJobLegalInfoRepository = new RepositoryImpl<MBusinessJobLegalInfo>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMBusinessJobLegalInfoEntity(mBusinessJobLegalInfoRepository.Get(businessJobLegalInfoId));
        }

        internal MBusinessJobLegalDetailEntity GetMBusinessJobLegalDetailEntity(string businessJobLegalDetailId)
        {
            IRepository<MBusinessJobLegalDetail> mBusinessJobLegalDetailRepository = new RepositoryImpl<MBusinessJobLegalDetail>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMBusinessJobLegalDetailEntity(mBusinessJobLegalDetailRepository.Get(businessJobLegalDetailId));
        }

        internal List<MCaseIssueEntity> GetMCaseIssue()
        {
            List<MCaseIssue> listMCaseIssue = GetAllFromRepository<MCaseIssue>();
            if (listMCaseIssue != null && listMCaseIssue.Count > 0)
            {
                return listMCaseIssue.Select(mCaseIssue => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCaseIssueDomain(mCaseIssue)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MCaseIssueEntity> GetMCaseIssue<V>(string fieldName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MCaseIssue))
                                                                            .Add(Expression.Eq(fieldName, value.ToString()));

            List<MCaseIssue> listMCaseIssue = GetEntityByDetachedCriteria<MCaseIssue>(detachedCriteria);
            if (listMCaseIssue != null && listMCaseIssue.Count > 0)
            {
                return listMCaseIssue.Select(mCaseIssue => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCaseIssueDomain(mCaseIssue)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal MCaseTypeEntity GetMCaseType(string caseTypeCode)
        {
            IRepository<MCaseType> mCaseTypeRepository = new RepositoryImpl<MCaseType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCaseTypeEntity(mCaseTypeRepository.Get(caseTypeCode));
        }

        internal MChargeTypeEntity GetMChargeType(string chargeTypeCode)
        {
            IRepository<MChargeType> mChargeTypeEntityRepository = new RepositoryImpl<MChargeType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMChargeTypeEntity(mChargeTypeEntityRepository.Get(chargeTypeCode));
        }

        internal MCriminalClaimantTypeEntity GetMCriminalClaimantType(string criminalClaimantTypeCode)
        {
            IRepository<MCriminalClaimantType> mCriminalClaimantTypeRepository = new RepositoryImpl<MCriminalClaimantType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCriminalClaimantTypeEntity(mCriminalClaimantTypeRepository.Get(criminalClaimantTypeCode));
        }

        internal MCriminalClaimTypeEntity GetMCriminalClaimType(string criminalClaimTypeCode)
        {
            IRepository<MCriminalClaimType> mCriminalClaimTypeRepository = new RepositoryImpl<MCriminalClaimType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCriminalClaimTypeEntity(mCriminalClaimTypeRepository.Get(criminalClaimTypeCode));
        }

        internal MCriminalOrderEntity GetMCriminalOrder(string criminalOrderCode)
        {
            IRepository<MCriminalOrder> mCriminalOrderEntityRepository = new RepositoryImpl<MCriminalOrder>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCriminalOrderEntity(mCriminalOrderEntityRepository.Get(criminalOrderCode));
        }

        internal List<MDocCodeEntity> GetMDocCode(string mainGroup, string subCategory)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MDocCode))
                .Add(Expression.And(Expression.Eq("MainGroup", mainGroup), Expression.Eq("SubCategory", subCategory)));

            List<MDocCode> listMDocCode = GetEntityByDetachedCriteria<MDocCode>(detachedCriteria);
            if (listMDocCode != null && listMDocCode.Count > 0)
            {
                return listMDocCode.Select(mDocCode => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocCodeEntity(mDocCode)).ToList();
            }
            else
                return null;
        }

        internal MDocCodeEntity GetMDocCodeByDocCode(string docCode)
        {
            IRepository<MDocCode> mDocCodeRepository = new RepositoryImpl<MDocCode>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocCodeEntity(mDocCodeRepository.Get(docCode));
        }

        internal MDrivingLicenseEntity GetMDrivingLicense(string drivingLicenseCode)
        {
            IRepository<MDrivingLicense> mDrivingLicenseEntityRepository = new RepositoryImpl<MDrivingLicense>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDrivingLicenseEntity(mDrivingLicenseEntityRepository.Get(drivingLicenseCode));
        }

        internal MDrugEntity GetMDrug(string drugCode)
        {
            IRepository<MDrug> mDrugEntityRepository = new RepositoryImpl<MDrug>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDrugEntity(mDrugEntityRepository.Get(drugCode));
        }

        internal MHRGRoomEntity GetMHrgRoomEntity(string hRGRoomCode)
        {
            IRepository<MHRGRoom> mHRGRoomRepository = new RepositoryImpl<MHRGRoom>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHRGRoomEntity(mHRGRoomRepository.Get(hRGRoomCode));
        }

        internal MHRGTypeEntity GetMHrgTypeEntity(string courtInd, string hrgTypeCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MHRGType))
                .Add(Expression.Eq("CourtInd", courtInd))
                .Add(Expression.Eq("HRGTypeCode", hrgTypeCode));

            List<MHRGType> listMHRGType = GetEntityByDetachedCriteria<MHRGType>(detachedCriteria);
            if (listMHRGType != null && listMHRGType.Count > 0)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHRGTypeEntity(listMHRGType[0]);
            }
            else
                return null;
        }

        internal MIOOrganisationEntity GetMIOOrganisation(string ioOrganisationCode)
        {
            IRepository<MIOOrganisation> mIOOrganisationEntityRepository = new RepositoryImpl<MIOOrganisation>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMIOOrganisationEntity(mIOOrganisationEntityRepository.Get(ioOrganisationCode));
        }

        internal MLegislationActEntity GetMLegislationAct(string actCode)
        {
            IRepository<MLegislationAct> mLegislationActRepository = new RepositoryImpl<MLegislationAct>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMLegislationActEntity(mLegislationActRepository.Get(actCode));
        }

        internal MModeOfTraffickingEntity GetMModeOfTrafficking(string modeOfTraffickingCode)
        {
            IRepository<MModeOfTrafficking> mModeOfTraffickingEntityRepository = new RepositoryImpl<MModeOfTrafficking>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMModeOfTraffickingEntity(mModeOfTraffickingEntityRepository.Get(modeOfTraffickingCode));
        }

        internal MNAAAlertEventsTemplateEntity GetMNAAAlertEventsTemplateByPK(int alertEventTemplateId)
        {
            IRepository<MNAAAlertEventsTemplate> mNAAAlertEventsTemplateRepository = new RepositoryImpl<MNAAAlertEventsTemplate>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMNAAAlertEventsTemplateEntity(mNAAAlertEventsTemplateRepository.Get(alertEventTemplateId));
        }

        internal MNatureOfAppealEntity GetMNatureOfAppeal(string natureOfAppealCode)
        {
            IRepository<MNatureOfAppeal> mNatureOfAppealEntityRepository = new RepositoryImpl<MNatureOfAppeal>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMNatureOfAppealEntity(mNatureOfAppealEntityRepository.Get(natureOfAppealCode));
        }

        internal MNatureOfOffenceEntity GetMNatureOfOffence(string natureOfOffenceCode)
        {
            IRepository<MNatureOfOffence> mNatureOfOffenceEntityRepository = new RepositoryImpl<MNatureOfOffence>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMNatureOfOffenceEntity(mNatureOfOffenceEntityRepository.Get(natureOfOffenceCode));
        }

        internal MNOACodeEntity GetMNOACode(string noaCode)
        {
            IRepository<MNOACode> mNOAEntityRepository = new RepositoryImpl<MNOACode>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMNOACodeEntity(mNOAEntityRepository.Get(noaCode));
        }

        internal MPartyStatusEntity GetMPartyStatusEntityByPK(string partyStatusCode)
        {
            IRepository<MPartyStatus> mPartyStatusRepository = new RepositoryImpl<MPartyStatus>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMPartyStatusEntity(mPartyStatusRepository.Get(partyStatusCode));
        }

        internal MPrisonEntity GetMPrison(string prisonCode)
        {
            IRepository<MPrison> mPrisonEntityRepository = new RepositoryImpl<MPrison>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMPrisonEntity(mPrisonEntityRepository.Get(prisonCode));
        }

        internal MProvisionEntity GetMProvision(string provisionCode)
        {
            IRepository<MProvision> mProvisionRepository = new RepositoryImpl<MProvision>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMProvisionEntity(mProvisionRepository.Get(provisionCode));
        }

        internal MSentenceEntity GetMSentence(string sentenceCode)
        {
            IRepository<MSentence> mSentenceEntityRepository = new RepositoryImpl<MSentence>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSentenceEntity(mSentenceEntityRepository.Get(sentenceCode));
        }

        internal MSubProvisionEntity GetMSubProvision(string subProvisionCode)
        {
            IRepository<MSubProvision> mSubProvisionRepository = new RepositoryImpl<MSubProvision>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSubProvisionEntity(mSubProvisionRepository.Get(subProvisionCode));
        }

        internal MTaskListTypeEntity GetMTaskListType(string provisionCode)
        {
            IRepository<MTaskListType> mTaskListTypeRepository = new RepositoryImpl<MTaskListType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMTaskListTypeEntity(mTaskListTypeRepository.Get(provisionCode));
        }

        internal List<MNOACodeEntity> GetNOACodeByCaseType(string caseTypeCode)
        {
            List<RMCaseTypeNOAEntity> listRMCaseTypeNOAEntity = GetAllRMCaseTypeNOA(caseTypeCode);
            List<MNOACodeEntity> listMNOACodeEntity = new List<MNOACodeEntity>();

            foreach (RMCaseTypeNOAEntity rmCaseTypeNOAEntity in listRMCaseTypeNOAEntity)
            {
                listMNOACodeEntity.Add(GetMNOACode(rmCaseTypeNOAEntity.NOACode));
            }

            return listMNOACodeEntity;
        }

        internal List<MLegislationActEntity> GetPagedMLegislationAct(int currentPageNo, int pageRecordsCount, out int Count)
        {
            IQuery queryCount = applicationSession.CreateSQLQuery(
                @"select ActCode,
                                    Description,
                                    IsInterfaced,
                                    ObsInd
                                    from MLegislationAct");
            Count = queryCount.List().Count;

            IQuery query = applicationSession.CreateSQLQuery(
                            @"select ActCode,
                                    Description,
                                    IsInterfaced,
                                    ObsInd
                                    from MLegislationAct")
                             .SetFirstResult((currentPageNo - 1) * pageRecordsCount)
                             .SetMaxResults(pageRecordsCount);
            List<object> listMLegislationAct = query.List<object>().ToList();
            if (listMLegislationAct.Count > 0 && listMLegislationAct != null)
            {
                return this.TransformToMLegislationActEntity(listMLegislationAct);
                //listMLegislationAct.Select(mLegislationAct => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMLegislationActEntity(mLegislationAct)).ToList();
            }
            else
                return null;
        }

        /// <summary>
        /// Gets the paged M legislation act entity.
        /// </summary>
        /// <param name="pageNo">The page no.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="totalRecords">The total records.</param>
        /// <returns></returns>
        internal List<MLegislationActEntity> GetPagedMLegislationActEntity(int pageNo, int pageSize, out int totalRecords)
        {
            var rowCount = this.applicationSession.CreateCriteria<MLegislationAct>()
                                    .SetProjection(Projections.RowCount())
                                    .FutureValue<Int32>();

            var results = this.applicationSession.CreateCriteria<MLegislationAct>()
                    .SetFirstResult((pageNo - 1) * pageSize)
                    .SetMaxResults(pageSize)
                    .Future<MLegislationAct>()
                    .ToList<MLegislationAct>();

            totalRecords = rowCount.Value;

            if (results != null && results.Count > 0)
            {
                return results.Select(legislationAct => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMLegislationActEntity(legislationAct)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal RMPartyStatusCaseTypeEntity GetRMPartyStatusCaseTypeEntity(string caseTypeCode, string partyStatus)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMPartyStatusCaseType>()
               .Add(Expression.Eq("CaseTypeCode", caseTypeCode))
               .Add(Expression.Eq("PartyStatusCode", partyStatus));
            List<RMPartyStatusCaseType> listRMPartyStatusCaseType = GetFromDetachedCriteria<RMPartyStatusCaseType>(detachedCriteria);
            if (listRMPartyStatusCaseType != null && listRMPartyStatusCaseType.Count > 0)
            {
                return listRMPartyStatusCaseType.Select(rMPartyStatusCaseType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMPartyStatusCaseTypeEntity(rMPartyStatusCaseType)).ToList().SingleOrDefault();
            }
            else
            {
                return null;
            }
        }

        internal RRoleFunctionsEntity GetRRoleFunctions(string roleCode, string functionCode)
        {
            IRepository<RRoleFunctions> repository = new RepositoryImpl<RRoleFunctions>(applicationSession);
            RRoleFunctions rRoleFunctions = repository.Get(new RRoleFunctions()
            {
                FunctionCode = functionCode,
                RoleCode = roleCode
            });

            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRRoleFunctionsEntity(rRoleFunctions);
        }

        internal RUserRoleSectionEntity GetRUserRoleSection(string sectionCode, string userId, string roleCode)
        {
            IRepository<RUserRoleSection> repository = new RepositoryImpl<RUserRoleSection>(applicationSession);
            RUserRoleSection rUserRoleSection = repository.Get(new RUserRoleSection()
                 {
                     SectionCode = sectionCode,
                     UserId = userId,
                     RoleCode = roleCode
                 });

            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRUserRoleSectionEntity(rUserRoleSection);
        }

        /// <summary>
        /// Passes the domain object and save it.
        /// </summary>
        /// <param name="entityToSave">The domain object to be saved.<param>
        /// <returns></returns>
        internal void SaveOrUpdateEntity<T>(T entityToSave, bool isCopy)
        {
            IRepository<T> iMasterRepository = new RepositoryImpl<T>(applicationSession);
            iMasterRepository.SaveOrUpdate(entityToSave, isCopy);
        }

        /// <summary>
        /// Passes the domain object and save it.
        /// </summary>
        /// <param name="entityToSave">The domain object to be saved.<param>
        /// <returns></returns>
        internal void SaveOrUpdateInMemoryEntity<T>(T entityToSave)
        {
            IRepository<T> iMasterRepository = new RepositoryImpl<T>(applicationSession);
            iMasterRepository.SaveOrUpdateCopy(entityToSave);
        }

        private List<T> GetAllFromRepository<T>()
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll() as List<T>;
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria
        /// </summary>
        /// <typeparam name="T">Type to delete.</typeparam>
        /// <param name="columneNames">The fields name and values of domain entity to use for deletion.</param>
        /// <param name="value">The value to filter.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteria<T, V>(string columnName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(T))
                                                                 .Add(Expression.Eq(columnName, value));

            return detachedCriteria;
        }

        private List<T> GetFromDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll(detachedCriteria) as List<T>;
        }

        private List<RMCaseTypeNOA> GetListRMCaseTypeNOA(DetachedCriteria detachedCriteria)
        {
            IRepository<RMCaseTypeNOA> rmCaseTypeNOARepository = new RepositoryImpl<RMCaseTypeNOA>(applicationSession);
            return rmCaseTypeNOARepository.GetAll(detachedCriteria) as List<RMCaseTypeNOA>;
        }

        private List<RMCaseTypeNOA> GetListRMCaseTypeNOAByCaseTypeCode(string caseTypeCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RMCaseTypeNOA))
                                                                            .Add(Expression.Eq("CaseTypeCode", caseTypeCode));

            List<RMCaseTypeNOA> listRMCaseTypeNOA = GetListRMCaseTypeNOA(detachedCriteria);

            return listRMCaseTypeNOA;
        }

        private List<MChecklist> GetMCheckList(DetachedCriteria detachedCriteria)
        {
            IRepository<MChecklist> mChecklistRepository = new RepositoryImpl<MChecklist>(applicationSession);
            return mChecklistRepository.GetAll(detachedCriteria).ToList();
        }

        private List<MChecklistDocument> GetMChecklistDocument(DetachedCriteria detachedCriteria)
        {
            IRepository<MChecklistDocument> mChecklistDocumentRepository = new RepositoryImpl<MChecklistDocument>(applicationSession);
            return mChecklistDocumentRepository.GetAll(detachedCriteria).ToList();
        }

        private IMasterEntity GetMCoramByPK(string primaryKey)
        {
            IRepository<MCoram> repository = new RepositoryImpl<MCoram>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCoramEntity(repository.Get(primaryKey));
        }

        private MCountryEntity GetMCountryByPK(string primaryKey)
        {
            IRepository<MCountry> repository = new RepositoryImpl<MCountry>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCountryEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMCourtTypeByPK(string primaryKey)
        {
            IRepository<MCourtType> repository = new RepositoryImpl<MCourtType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCourtTypeEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMCurrencyByPK(string primaryKey)
        {
            IRepository<MCurrency> repository = new RepositoryImpl<MCurrency>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCurrencyEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMDesignationByPK(string primaryKey)
        {
            IRepository<MDesignation> repository = new RepositoryImpl<MDesignation>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDesignationEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMDialectByPK(string primaryKey)
        {
            IRepository<MDialect> repository = new RepositoryImpl<MDialect>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDialectEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMDocCategoryByPK(string primaryKey)
        {
            IRepository<MDocCategory> repository = new RepositoryImpl<MDocCategory>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocCategoryEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMFormTemplateLocationByPK(string primaryKey)
        {
            IRepository<MFormTemplateLocation> repository = new RepositoryImpl<MFormTemplateLocation>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFormTemplateLocationEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMForumTypeByPK(string primaryKey)
        {
            IRepository<MForumType> repository = new RepositoryImpl<MForumType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMForumTypeEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMGenderByPK(string primaryKey)
        {
            IRepository<MGender> repository = new RepositoryImpl<MGender>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMGenderEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMHolidayByPK(string primaryKey)
        {
            IRepository<MHoliday> repository = new RepositoryImpl<MHoliday>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHolidayEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMLegalPracticeByPK(string primaryKey)
        {
            IRepository<MLegalPractice> repository = new RepositoryImpl<MLegalPractice>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMLegalPracticeEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMLimitationsByPK(string primaryKey)
        {
            IRepository<MLimitations> repository = new RepositoryImpl<MLimitations>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMLimitationsEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMMaritalStatusByPK(string primaryKey)
        {
            IRepository<MMaritalStatus> repository = new RepositoryImpl<MMaritalStatus>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMMaritalStatusEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMNationalityByPK(string primaryKey)
        {
            IRepository<MNationality> repository = new RepositoryImpl<MNationality>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMNationalityEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMNOACodeByPK(string primaryKey)
        {
            IRepository<MNOACode> repository = new RepositoryImpl<MNOACode>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMNOACodeEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMQualificationByPK(string primaryKey)
        {
            IRepository<MQualification> repository = new RepositoryImpl<MQualification>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMQualificationEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMRaceByPK(string primaryKey)
        {
            IRepository<MRace> repository = new RepositoryImpl<MRace>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMRaceEntity(repository.Get(primaryKey));
        }

        private IMasterEntity GetMReligionByPK(string primaryKey)
        {
            IRepository<MReligion> repository = new RepositoryImpl<MReligion>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMReligionEntity(repository.Get(primaryKey));
        }

        private List<MLegislationActEntity> TransformToMLegislationActEntity(List<object> listMLegislationAct)
        {
            List<MLegislationActEntity> listMLegislationActEntity = new List<MLegislationActEntity>();
            foreach (object[] item in listMLegislationAct)
            {
                listMLegislationActEntity.Add(new MLegislationActEntity(
                      item[0] != null ? item[0].ToString() : null,
                       item[1] != null ? item[1].ToString() : null,
                        item[2] != null ? item[2].ToString() : null,
                         item[3] != null ? item[3].ToString() : null));
            }
            return listMLegislationActEntity;
        }


        internal List<MHearingTypeEntity> GetAllMHearingType()
        {
            List<MHearingType> listMHearingType = GetAllFromRepository<MHearingType>();
            if (listMHearingType != null && listMHearingType.Count > 0)
            {
                return listMHearingType.Select(mHearingType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHearingTypeEntity(mHearingType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MHRGRoomEntity> GetAllMHRGRoomEntity()
        {
            List<MHRGRoom> listMHRGRoom = GetAllFromRepository<MHRGRoom>();
            if (listMHRGRoom != null && listMHRGRoom.Count > 0)
            {
                return listMHRGRoom.Select(mHRGRoom => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHRGRoomEntity(mHRGRoom)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets all RM case type HRG type MS type entity.
        /// </summary>
        /// <returns></returns>
        internal List<RMCaseTypeHRGTypeMSTypeEntity> GetAllRMCaseTypeHRGTypeMSTypeEntity()
        {
            List<RMCaseTypeHRGTypeMSType> listRMCaseTypeHRGTypeMSType = GetAllFromRepository<RMCaseTypeHRGTypeMSType>();
            if (listRMCaseTypeHRGTypeMSType != null && listRMCaseTypeHRGTypeMSType.Count > 0)
            {
                return listRMCaseTypeHRGTypeMSType.Select(rMCaseTypeHRGTypeMSType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMCaseTypeHRGTypeMSTypeEntity(rMCaseTypeHRGTypeMSType)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets all RM case type HRG type MS type entity.
        /// </summary>
        /// <returns></returns>
        internal List<RMCaseTypeForumHRGTypeMSTypeEntity> GetAllRMCaseTypeForumHRGTypeMSTypeEntity()
        {
            List<RMCaseTypeForumHRGTypeMSType> listRMCaseTypeForumHRGTypeMSType = GetAllFromRepository<RMCaseTypeForumHRGTypeMSType>();
            if (listRMCaseTypeForumHRGTypeMSType != null && listRMCaseTypeForumHRGTypeMSType.Count > 0)
            {
                return listRMCaseTypeForumHRGTypeMSType.Select(rMCaseTypeForumHRGTypeMSType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMCaseTypeForumHRGTypeMSTypeEntity(rMCaseTypeForumHRGTypeMSType)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets all RM forum coram DSG entity.
        /// </summary>
        /// <returns></returns>
        internal List<RMForumCoramDSGEntity> GetAllRMForumCoramDSGEntity()
        {
            List<RMForumCoramDSG> listRMForumCoramDSG = GetAllFromRepository<RMForumCoramDSG>();
            if (listRMForumCoramDSG != null && listRMForumCoramDSG.Count > 0)
            {
                return listRMForumCoramDSG.Select(rMForumCoramDSG => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMForumCoramDSGEntity(rMForumCoramDSG)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMHearingTypeCourtTypeEntity> GetAllRMHearingTypeCourtTypeEntity()
        {
            List<RMHearingTypeCourtType> listRMHearingTypeCourtType = GetAllFromRepository<RMHearingTypeCourtType>();
            if (listRMHearingTypeCourtType != null && listRMHearingTypeCourtType.Count > 0)
            {
                return listRMHearingTypeCourtType.Select(rMHearingTypeCourtType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMHearingTypeCourtTypeEntity(rMHearingTypeCourtType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMHRGTypeHRGOutComeHRGOutComeFlagEntity> GetAllRMHRGTypeHRGOutComeHRGOutComeFlagEntity()
        {
            List<RMHRGTypeHRGOutComeHRGOutComeFlag> listRMHRGTypeHRGOutComeHRGOutComeFlag = GetAllFromRepository<RMHRGTypeHRGOutComeHRGOutComeFlag>();
            if (listRMHRGTypeHRGOutComeHRGOutComeFlag != null && listRMHRGTypeHRGOutComeHRGOutComeFlag.Count > 0)
            {
                return listRMHRGTypeHRGOutComeHRGOutComeFlag.Select(rMHRGTypeHRGOutComeHRGOutComeFlag => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMHRGTypeHRGOutComeHRGOutComeFlagEntity(rMHRGTypeHRGOutComeHRGOutComeFlag)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal RMCaseTypeHRGTypeMSTypeEntity GetRMCaseTypeHRGMSTypeEntity(string courdId, string CaseTypeCode, string HRGTypeCode, string MSType)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMCaseTypeHRGTypeMSType>()
                .Add(Expression.Eq("CourtId", courdId))
                .Add(Expression.Eq("CaseTypeCode", CaseTypeCode))
                .Add(Expression.Eq("HRGTypeCode", HRGTypeCode))
                .Add(Expression.Eq("MSType", MSType));

            RMCaseTypeHRGTypeMSType rMCaseTypeHRGTypeMSType = GetFromDetachedCriteria<RMCaseTypeHRGTypeMSType>(detachedCriteria).SingleOrDefault();
            if (rMCaseTypeHRGTypeMSType != null)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMCaseTypeHRGTypeMSTypeEntity(rMCaseTypeHRGTypeMSType);
            }
            else
            {
                return null;
            }
        }

        internal RMCaseTypeForumHRGTypeMSTypeEntity GetRMCaseTypeForumHRGMSTypeEntity(string ForumId, string CaseTypeCode, string HRGTypeCode, string MSType)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMCaseTypeForumHRGTypeMSType>()
                .Add(Expression.Eq("ForumId", ForumId))
                .Add(Expression.Eq("CaseTypeCode", CaseTypeCode))
                .Add(Expression.Eq("HRGTypeCode", HRGTypeCode))
                .Add(Expression.Eq("MSType", MSType));

            RMCaseTypeForumHRGTypeMSType rMCaseTypeForumHRGTypeMSType = GetFromDetachedCriteria<RMCaseTypeForumHRGTypeMSType>(detachedCriteria).SingleOrDefault();
            if (rMCaseTypeForumHRGTypeMSType != null)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMCaseTypeForumHRGTypeMSTypeEntity(rMCaseTypeForumHRGTypeMSType);
            }
            else
            {
                return null;
            }
        }



        internal RMForumCoramDSGEntity GetRMForumCoramDSGEntity(string ForumId, string CoramCode, string DSGCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMForumCoramDSG>()
               .Add(Expression.Eq("ForumID", ForumId))
               .Add(Expression.Eq("CoramCode", CoramCode))
               .Add(Expression.Eq("DSGCode", DSGCode));


            RMForumCoramDSG rMForumCoramDSG = GetFromDetachedCriteria<RMForumCoramDSG>(detachedCriteria).SingleOrDefault();
            if (rMForumCoramDSG != null)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMForumCoramDSGEntity(rMForumCoramDSG);
            }
            else
            {
                return null;
            }
        }

        internal RMHearingTypeCourtTypeEntity GetRMHearingTypeCourtTypeEntity(string courtId, string hRGTypeCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMHearingTypeCourtType>()
               .Add(Expression.Eq("CourtId", courtId))
               .Add(Expression.Eq("HRGTypeCode", hRGTypeCode));

            RMHearingTypeCourtType rMHearingTypeCourtType = GetFromDetachedCriteria<RMHearingTypeCourtType>(detachedCriteria).SingleOrDefault();
            if (rMHearingTypeCourtType != null)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMHearingTypeCourtTypeEntity(rMHearingTypeCourtType);
            }
            else
            {
                return null;
            }
        }

        internal RMDocCodeHrgTypeEntity GetRMHearingTypeCourtTypeEntity(string docCode, string hrgTypeCode, string caseTypeCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMDocCodeHRGType>()
                .Add(Expression.Eq("DocCode", docCode))
                .Add(Expression.Eq("HRGTypeCode", hrgTypeCode))
                .Add(Expression.Eq("CaseTypeCode", caseTypeCode));

            RMDocCodeHRGType rMDocCodeHRGType = GetFromDetachedCriteria<RMDocCodeHRGType>(detachedCriteria).SingleOrDefault();
            if (rMDocCodeHRGType != null)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMDocCodeHrgTypeEntity(rMDocCodeHRGType);
            }
            else
            {
                return null;
            }
        }



        internal List<MHRGOutComeFlagEntity> GetAllMHRGOutComeFlagEntity()
        {
            List<MHRGOutComeFlag> listMHRGOutComeFlag = GetAllFromRepository<MHRGOutComeFlag>();
            if (listMHRGOutComeFlag != null && listMHRGOutComeFlag.Count > 0)
            {
                return listMHRGOutComeFlag.Select(mHRGOutComeFlag => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHRGOutComeFlagEntity(mHRGOutComeFlag)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MHRGOutComeReasonEntity> GetAllMHRGOutComeReasonEntity()
        {
            List<MHRGOutComeReason> listMHRGOutComeReason = GetAllFromRepository<MHRGOutComeReason>();
            if (listMHRGOutComeReason != null && listMHRGOutComeReason.Count > 0)
            {
                return listMHRGOutComeReason.Select(mHRGOutComeReason => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHRGOutComeReasonEntity(mHRGOutComeReason)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MEMSOldSCTCasePrefixEntity> GetAllMEMSOldSCTCasePrefixEntity()
        {
            List<MEMSOldSCTCasePrefix> listMEMSOldSCTCasePrefix = GetAllFromRepository<MEMSOldSCTCasePrefix>();
            if (listMEMSOldSCTCasePrefix != null && listMEMSOldSCTCasePrefix.Count > 0)
            {
                return listMEMSOldSCTCasePrefix.Select(mEMSOldSCTCasePrefix => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMEMSOldSCTCasePrefixEntity(mEMSOldSCTCasePrefix)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMNOAForumHrgTypeEntity> GetAllRMNOAForumHrgType()
        {
            List<RMNOAForumHrgType> listRMNOAForumHrgType = GetAllFromRepository<RMNOAForumHrgType>();
            if (listRMNOAForumHrgType != null && listRMNOAForumHrgType.Count > 0)
            {
                return listRMNOAForumHrgType.Select(rMNOAForumHrgType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMNOAForumHrgTypeEntity(rMNOAForumHrgType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMPartyTypeCaseTypeEntity> GetListRMPartyTypeCaseTypeEntity(string caseTypeCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMPartyTypeCaseType>()
                .Add(Expression.Eq("CaseTypeCode", caseTypeCode));

            List<RMPartyTypeCaseType> listRMPartyTypeCaseType = GetFromDetachedCriteria<RMPartyTypeCaseType>(detachedCriteria);
            if (listRMPartyTypeCaseType != null && listRMPartyTypeCaseType.Count > 0)
            {
                return listRMPartyTypeCaseType.Select(rMPartyTypeCaseType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMPartyTypeCaseTypeEntity(rMPartyTypeCaseType)).ToList();
            }
            else
                return null;
        }

        internal List<MFilingFeeEntity> GetAllMFilingFee()
        {
            List<MFilingFee> listMFilingFee = GetAllFromRepository<MFilingFee>();
            if (listMFilingFee != null && listMFilingFee.Count > 0)
            {
                return listMFilingFee.Select(mFilingFee => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFilingFeeEntity(mFilingFee)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MFilterGroupEntity> GetAllMFilterGroup()
        {
            List<MFilterGroup> listMFilterGroup = GetAllFromRepository<MFilterGroup>();
            if (listMFilterGroup != null && listMFilterGroup.Count > 0)
            {
                return listMFilterGroup.Select(mFilterGroup => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFilterGroupEntity(mFilterGroup)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MSummonsParamEntity> GetAllMSummonsParam()
        {
            List<MSummonsParam> listMSummonsParam = GetAllFromRepository<MSummonsParam>();
            if (listMSummonsParam != null && listMSummonsParam.Count > 0)
            {
                return listMSummonsParam.Select(mSummonsParam => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSummonsParamEntity(mSummonsParam)).ToList();
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Gets all M mass call HRG date.
        /// </summary>
        /// <returns></returns>
        internal List<MMassCallHrgDateEntity> GetAllMMassCallHrgDate()
        {
            List<MMassCallHrgDate> listMMassCallHrgDate = GetAllFromRepository<MMassCallHrgDate>();
            if (listMMassCallHrgDate != null && listMMassCallHrgDate.Count > 0)
            {
                return listMMassCallHrgDate.Select(mMassCallHrgDate => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMMassCallHrgDateEntity(mMassCallHrgDate)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets all M charge outcome.
        /// </summary>
        /// <returns></returns>
        internal List<MChargeOutcomeEntity> GetAllMChargeOutcome()
        {
            List<MChargeOutcome> listMChargeOutcome = GetAllFromRepository<MChargeOutcome>();
            if (listMChargeOutcome != null && listMChargeOutcome.Count > 0)
            {
                return listMChargeOutcome.Select(mChargeOutcome => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMChargeOutcomeEntity(mChargeOutcome)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal void DeleteRMHRGTypeHRGSlot(string courtInd, string hrgTypeCode, string hrgSlotCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMHRGTypeHRGSlot>()
                .Add(Expression.Eq("CourtInd", courtInd))
                .Add(Expression.Eq("HRGTypeCode", hrgTypeCode))
                .Add(Expression.Eq("HRGSlotCode", hrgSlotCode));

            Repository<RMHRGTypeHRGSlot>().DeleteAll(detachedCriteria);

        }
        internal void DeleteRMRoutingSectionConfig(RMRoutingSectionConfigEntity rmRoutingSectionConfigEntity)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMRoutingSectionConfig>()
               .Add(Expression.Eq("RMRoutingSectionConfigId", rmRoutingSectionConfigEntity.RMRoutingSectionConfigId));
            Repository<RMRoutingSectionConfig>().DeleteAll(detachedCriteria);
        }

        internal void DeleteRMNOAForumHrgType(RMNOAForumHrgTypeEntity rMNOAForumHrgTypeEntity)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMNOAForumHrgType>()
               .Add(Expression.Eq("CaseTypeCode", rMNOAForumHrgTypeEntity.CaseTypeCode))
               .Add(Expression.Eq("ForumID", rMNOAForumHrgTypeEntity.ForumID))
               .Add(Expression.Eq("NOACode", rMNOAForumHrgTypeEntity.NOACode));

            Repository<RMNOAForumHrgType>().DeleteAll(detachedCriteria);
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
        /// Gets all M law firm group.
        /// </summary>
        /// <returns></returns>
        internal List<MLawFirmGroupEntity> GetAllMLawFirmGroup()
        {
            List<MLawFirmGroup> listMLawFirmGroup = GetAllFromRepository<MLawFirmGroup>();
            if (listMLawFirmGroup != null && listMLawFirmGroup.Count > 0)
            {
                return listMLawFirmGroup.Select(mLawFirmGroup => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMLawFirmGroupEntity(mLawFirmGroup)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MVSAConfigDetailEntity> GetAllMVSAConfigDetail()
        {
            List<MVSAConfigDetail> listMVSAConfigDetail = GetAllFromRepository<MVSAConfigDetail>();
            if (listMVSAConfigDetail != null && listMVSAConfigDetail.Count > 0)
            {
                return listMVSAConfigDetail.Select(mVSAConfigDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMVSAConfigDetailEntity(mVSAConfigDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MVSAConfigGroundEntity> GetAllMVSAConfigGround()
        {
            List<MVSAConfigGround> listMVSAConfigGround = GetAllFromRepository<MVSAConfigGround>();
            if (listMVSAConfigGround != null && listMVSAConfigGround.Count > 0)
            {
                return listMVSAConfigGround.Select(mVSAConfigGround => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMVSAConfigGroundEntity(mVSAConfigGround)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MVSAConfigPrayerEntity> GetAllMVSAConfigPrayer()
        {
            List<MVSAConfigPrayer> listMVSAConfigPrayer = GetAllFromRepository<MVSAConfigPrayer>();
            if (listMVSAConfigPrayer != null && listMVSAConfigPrayer.Count > 0)
            {
                return listMVSAConfigPrayer.Select(mVSAConfigPrayer => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMVSAConfigPrayerEntity(mVSAConfigPrayer)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MFilingFeeChargingMechanismEntity> GetAllMFilingFeeChargingMechanism()
        {
            List<MFilingFeeChargingMechanism> listMFilingFeeChargingMechanism = GetAllFromRepository<MFilingFeeChargingMechanism>();
            if (listMFilingFeeChargingMechanism != null && listMFilingFeeChargingMechanism.Count > 0)
            {
                return listMFilingFeeChargingMechanism.Select(mFilingFeeChargingMechanism => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFilingFeeChargingMechanismEntity(mFilingFeeChargingMechanism)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RUserRoleSectionEntity> GetListRUserRoleSectionByUserId(string userId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RUserRoleSection))
               .Add(Expression.Eq("UserId", userId));
            List<RUserRoleSection> listRUserRoleSection = GetEntityByDetachedCriteria<RUserRoleSection>(detachedCriteria);
            if (listRUserRoleSection != null && listRUserRoleSection.Count > 0)
            {
                return listRUserRoleSection.Select(ruserRoleSection => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRUserRoleSectionEntity(ruserRoleSection)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MSummonsGroundsEntity> GetAllMSummonsGrounds()
        {
            List<MSummonsGrounds> listMSummonsGrounds = GetAllFromRepository<MSummonsGrounds>();
            if (listMSummonsGrounds != null && listMSummonsGrounds.Count > 0)
            {
                return listMSummonsGrounds.Select(mSummonsGrounds => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSummonsGroundsEntity(mSummonsGrounds)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MSummonsPrayersEntity> GetAllMSummonsPrayers()
        {
            List<MSummonsPrayers> listMSummonsPrayers = GetAllFromRepository<MSummonsPrayers>();
            if (listMSummonsPrayers != null && listMSummonsPrayers.Count > 0)
            {
                return listMSummonsPrayers.Select(mSummonsPrayers => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSummonsPrayersEntity(mSummonsPrayers)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal MSummonsGroundsEntity GetMSummonsGrounds(string paramId, int itemNo)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<MSummonsGrounds>()
                .Add(Expression.Eq("ParamID", paramId))
                .Add(Expression.Eq("ItemNo", itemNo));

            MSummonsGrounds mSummonsGrounds = GetFromDetachedCriteria<MSummonsGrounds>(detachedCriteria).FirstOrDefault();

            if (mSummonsGrounds != null)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSummonsGroundsEntity(mSummonsGrounds);
            }
            else
                return null;
        }

        internal MSummonsPrayersEntity GetMSummonsPrayers(string paramId, int level, int subLevel)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<MSummonsPrayers>()
                .Add(Expression.Eq("ParamID", paramId))
                .Add(Expression.Eq("Level", level))
                .Add(Expression.Eq("SubLevel", subLevel));

            MSummonsPrayers mSummonsPrayers = GetFromDetachedCriteria<MSummonsPrayers>(detachedCriteria).FirstOrDefault();

            if (mSummonsPrayers != null)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSummonsPrayersEntity(mSummonsPrayers);
            }
            else
                return null;
        }

        internal RMDocFilterGroupEntity GetRMDocFilterGroupEntity(string docCode, string filterGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMDocFilterGroup>()
                .Add(Expression.Eq("DocCode", docCode))
                .Add(Expression.Eq("FilterGroupId", filterGroupId));

            RMDocFilterGroup rMDocFilterGroup = GetFromDetachedCriteria<RMDocFilterGroup>(detachedCriteria).FirstOrDefault();

            if (rMDocFilterGroup != null)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMDocFilterGroupEntity(rMDocFilterGroup);
            }
            else
                return null;
        }

        internal List<RMDocFilterGroupEntity> GetAllRMDocFilterGroup()
        {
            List<RMDocFilterGroup> listRMDocFilterGroup = GetAllFromRepository<RMDocFilterGroup>();
            if (listRMDocFilterGroup != null && listRMDocFilterGroup.Count > 0)
            {
                return listRMDocFilterGroup.Select(rMDocFilterGroup => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMDocFilterGroupEntity(rMDocFilterGroup)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal void SaveOrUpdateRMDocFilterGroup(RMDocFilterGroupEntity rMDocFilterGroupEntity)
        {
            if (rMDocFilterGroupEntity != null)
            {
                RMDocFilterGroup rMDocFilterGroup = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.MasterMapper.GetRMDocFilterGroup(rMDocFilterGroupEntity);

                applicationSession.GetNamedQuery("SaveOrUpdateRMDocFilterGroupProcedure")
                .SetParameter("DocCode", rMDocFilterGroup.DocCode)
                   .SetParameter("FilterGroupID", rMDocFilterGroup.FilterGroupId)
                   .SetParameter("ObsInd", rMDocFilterGroup.ObsInd)
                   .SetParameter("LastModifiedDate", rMDocFilterGroup.LastModifiedDate)
                   .SetParameter("LastModifiedBy", rMDocFilterGroup.LastModifiedBy)
                   .ExecuteUpdate();
            }
        }

        internal void SaveOrUpdateMSummonsGrounds(MSummonsGroundsEntity mSummonsGroundsEntity)
        {
            if (mSummonsGroundsEntity != null)
            {
                MSummonsGrounds mSummonsGrounds = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.MasterMapper.GetMSummonsGrounds(mSummonsGroundsEntity);

                applicationSession.GetNamedQuery("SaveOrUpdateMSummonsGroundsProcedure")
               .SetParameter("ItemNo", mSummonsGrounds.ItemNo)
                  .SetParameter("GroundsText", mSummonsGrounds.GroundsText)
                  .SetParameter("ObsInd", mSummonsGrounds.ObsInd)
                  .SetParameter("LastModifiedBy", mSummonsGrounds.LastModifiedBy)
                  .SetParameter("LastModifiedDate", mSummonsGrounds.LastModifiedDate)
                  .SetParameter("ParamID", mSummonsGrounds.ParamID)
                  .ExecuteUpdate();
            }
        }

        internal void SaveOrUpdateMSummonsPrayers(MSummonsPrayersEntity mSummonsPrayersEntity)
        {
            if (mSummonsPrayersEntity != null)
            {
                MSummonsPrayers mSummonsPrayers = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.MasterMapper.GetMSummonsPrayers(mSummonsPrayersEntity);

                applicationSession.GetNamedQuery("SaveOrUpdateMSummonsPrayersProcedure")
               .SetParameter("Level", mSummonsPrayers.Level)
                  .SetParameter("PrayersText", mSummonsPrayers.PrayersText)
                  .SetParameter("ObsInd", mSummonsPrayers.ObsInd)
                  .SetParameter("LastModifiedBy", mSummonsPrayers.LastModifiedBy)
                  .SetParameter("LastModifiedDate", mSummonsPrayers.LastModifiedDate)
                  .SetParameter("SubLevel", mSummonsPrayers.SubLevel)
                  .SetParameter("ParamID", mSummonsPrayers.ParamID)
                  .ExecuteUpdate();
            }
        }

        internal List<RMSectionAccessCtrlEntity> GetAllRMSectionAccessCtrl()
        {
            List<RMSectionAccessCtrl> listRMSectionAccessCtrl = GetAllFromRepository<RMSectionAccessCtrl>();
            if (listRMSectionAccessCtrl != null && listRMSectionAccessCtrl.Count > 0)
            {
                return listRMSectionAccessCtrl.Select(rMSectionAccessCtrl => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMSectionAccessCtrlEntity(rMSectionAccessCtrl)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MHRGPredefinedDateEntity> GetAllMHRGPredefinedDate()
        {
            List<MHRGPredefinedDate> listMHRGPredefinedDate = GetAllFromRepository<MHRGPredefinedDate>();
            if (listMHRGPredefinedDate != null && listMHRGPredefinedDate.Count > 0)
            {
                return listMHRGPredefinedDate.Select(mHRGPredefinedDate => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHRGPredefinedDateEntity(mHRGPredefinedDate)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMCaseTypeHRGTypeJOLEntity> GetAllRMCaseTypeHRGTypeJOL()
        {
            List<RMCaseTypeHRGTypeJOL> listMHRGPredefinedDate = GetAllFromRepository<RMCaseTypeHRGTypeJOL>();
            if (listMHRGPredefinedDate != null && listMHRGPredefinedDate.Count > 0)
            {
                return listMHRGPredefinedDate.Select(rMCaseTypeHRGTypeJOL => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMCaseTypeHRGTypeJOLEntity(rMCaseTypeHRGTypeJOL)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<InterfaceLawSocLawFirmEntity> GetAllInterfaceLawSocLawFirm()
        {
            List<InterfaceLawSocLawFirm> listInterfaceLawSocLawFirm = GetAllFromRepository<InterfaceLawSocLawFirm>();
            if (listInterfaceLawSocLawFirm != null && listInterfaceLawSocLawFirm.Count > 0)
            {
                return listInterfaceLawSocLawFirm.Select(interfaceLawSocLawFirm => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LawFirmMapper.GetInterfaceLawSocLawFirmEntity(interfaceLawSocLawFirm)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<InterfaceLawSocLawFirmAddressEntity> GetAllInterfaceLawSocLawFirmAddress()
        {
            List<InterfaceLawSocLawFirmAddress> listInterfaceLawSocLawFirmAddress = GetAllFromRepository<InterfaceLawSocLawFirmAddress>();
            if (listInterfaceLawSocLawFirmAddress != null && listInterfaceLawSocLawFirmAddress.Count > 0)
            {
                return listInterfaceLawSocLawFirmAddress.Select(interfaceLawSocLawFirmAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LawFirmMapper.GetInterfaceLawSocLawFirmAddressEntity(interfaceLawSocLawFirmAddress)).ToList();
            }
            else
            {
                return null;
            }
        }


        internal long GetSolicitorIdFromMSequenceKey()
        {

            IRepository<MSequenceKey> repository = new RepositoryImpl<MSequenceKey>(applicationSession);


            MSequenceKey mSequence = repository.Get(new MSequenceKey()
            {
                Sequence = "Solicitor",
                SequenceName = "SolicitorId",
                SequencePrefix = "BE"
            });

            applicationSession.Evict(mSequence);// removed MSequence from session so that next fetch will be from db and not from session.

            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSequenceKeyEntity(mSequence).SequenceNumber;
        }

        internal void UpdateMSequenceKeySolicitorId()
        {
            StringBuilder sqlQuery = new StringBuilder();
            sqlQuery.Append("DECLARE @SequenceNumber BIGINT ");
            sqlQuery.Append(@"SELECT @SequenceNumber =[SequenceNumber] from MSequenceKey Where Sequence='Solicitor' AND SequenceName='SolicitorId' AND SequencePrefix ='BE' ");
            sqlQuery.Append(@"SET @SequenceNumber=@SequenceNumber+1 ");
            sqlQuery.Append(@"UPDATE MSequenceKey SET SequenceNumber=@SequenceNumber Where Sequence='Solicitor' AND SequenceName='SolicitorId' AND SequencePrefix ='BE'");

            IQuery query = applicationSession.CreateSQLQuery(sqlQuery.ToString());
            query.ExecuteUpdate();
        }

        public List<RMSubCaseTypeHRGTypeMSTypeEntity> GetAllRMSubCaseTypeHRGTypeMSType()
        {
            List<RMSubCaseTypeHRGTypeMSType> listRMSubCaseTypeHRGTypeMSType = GetAllFromRepository<RMSubCaseTypeHRGTypeMSType>();
            if (listRMSubCaseTypeHRGTypeMSType != null && listRMSubCaseTypeHRGTypeMSType.Count > 0)
            {
                return listRMSubCaseTypeHRGTypeMSType.Select(rMSubCaseTypeHRGTypeMSType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMSubCaseTypeHRGTypeMSTypeEntity(rMSubCaseTypeHRGTypeMSType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal RMSubCaseTypeHRGTypeMSTypeEntity GetRMSubCaseTypeHRGTypeMSTypeEntity(string forumId, string subCaseTypeCode, string hRGTypeCode, string mSType)
        {

            RMSubCaseTypeHRGTypeMSType rMSubCaseTypeHRGTypeMSType = new RMSubCaseTypeHRGTypeMSType
            {
                ForumId = forumId,
                SubCaseTypeCode = subCaseTypeCode,
                HRGTypeCode = hRGTypeCode,
                MSType = mSType
            };

            IRepository<RMSubCaseTypeHRGTypeMSType> repository = new RepositoryImpl<RMSubCaseTypeHRGTypeMSType>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMSubCaseTypeHRGTypeMSTypeEntity(repository.Get(rMSubCaseTypeHRGTypeMSType));



        }

        internal void SaveOrUpdateRMSubCaseTypeHRGTypeMSType(RMSubCaseTypeHRGTypeMSTypeEntity rMSubCaseTypeHRGTypeMSTypeEntity)
        {
            if (rMSubCaseTypeHRGTypeMSTypeEntity != null)
            {
                RMSubCaseTypeHRGTypeMSType rMSubCaseTypeHRGTypeMSType = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.MasterMapper.GetRMSubCaseTypeHRGTypeMSType(rMSubCaseTypeHRGTypeMSTypeEntity);

                applicationSession.GetNamedQuery("SaveOrUpdateRMSubCaseTypeHRGTypeMSType")
               .SetParameter("ForumId", rMSubCaseTypeHRGTypeMSType.ForumId)
                  .SetParameter("SubCaseTypeCode", rMSubCaseTypeHRGTypeMSType.SubCaseTypeCode)
                  .SetParameter("HRGTypeCode", rMSubCaseTypeHRGTypeMSType.HRGTypeCode)
                  .SetParameter("MSType", rMSubCaseTypeHRGTypeMSType.MSType)
                  .SetParameter("LastModifiedBy", rMSubCaseTypeHRGTypeMSType.LastModifiedBy)
                  .SetParameter("LastModifiedDate", rMSubCaseTypeHRGTypeMSType.LastModifiedDate)
                  .SetParameter("ObsInd", rMSubCaseTypeHRGTypeMSType.ObsInd)
                  .ExecuteUpdate();
            }
        }

        internal List<MSensitiveFilingACLEntity> GetAllMSensitiveFilingACL()
        {
            List<MSensitiveFilingACL> listMSensitiveFilingACL = GetAllFromRepository<MSensitiveFilingACL>();
            if (listMSensitiveFilingACL != null && listMSensitiveFilingACL.Count > 0)
            {
                return listMSensitiveFilingACL.Select(mSensitiveFilingACL => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMSensitiveFilingACLEntity(mSensitiveFilingACL)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMHearingRoutingSectionConfigEntity> GetListRMHearingRoutingSectionConfig(string forumId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMHearingRoutingSectionConfig>()
                           .Add(Expression.Eq("ForumID", forumId));

            List<RMHearingRoutingSectionConfig> listRMHearingRoutingSectionConfig = GetFromDetachedCriteria<RMHearingRoutingSectionConfig>(detachedCriteria);

            if (listRMHearingRoutingSectionConfig != null && listRMHearingRoutingSectionConfig.Count > 0)
            {
                return listRMHearingRoutingSectionConfig.Select(rmHearingRoutingSection => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMHearingRoutingSectionConfigEntity(rmHearingRoutingSection)).ToList();
            }
            else
                return null;
        }

        internal List<MAlertEventTypeEntity> GetAllMAlertEventType()
        {
            List<MAlertEventType> listMAlertEventType = GetAllFromRepository<MAlertEventType>();
            if (listMAlertEventType != null && listMAlertEventType.Count > 0)
            {
                return listMAlertEventType.Select(mAlertEventType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMAlertEventTypeEntity(mAlertEventType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMAlertEventTypeRoleEntity> GetAllRMAlertEventTypeRole()
        {
            List<RMAlertEventTypeRole> listFromRepository = GetAllFromRepository<RMAlertEventTypeRole>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(rMAlertEventTypeRole => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMAlertEventTypeRoleEntity(rMAlertEventTypeRole)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RAlertEventSubscribersEntity> GetAllRAlertEventSubscribers()
        {
            List<RAlertEventSubscribers> listFromRepository = GetAllFromRepository<RAlertEventSubscribers>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(rAlertEventSubscribers => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRAlertEventSubscribersEntity(rAlertEventSubscribers)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MBusinessJobLegalInfoEntity> GetAllMBusinessJobLegalInfo()
        {
            List<MBusinessJobLegalInfo> listFromRepository = GetAllFromRepository<MBusinessJobLegalInfo>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mBusinessJobLegalInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMBusinessJobLegalInfoEntity(mBusinessJobLegalInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MBusinessJobLegalDetailEntity> GetAllMBusinessJobLegalDetail()
        {
            List<MBusinessJobLegalDetail> listFromRepository = GetAllFromRepository<MBusinessJobLegalDetail>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mBusinessJobLegalDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMBusinessJobLegalDetailEntity(mBusinessJobLegalDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MEMSParamEntity> GetAllMEMSParamEntity()
        {
            List<MEMSParam> listFromRepository = GetAllFromRepository<MEMSParam>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(emsParam => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMEMSParamDomain(emsParam)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMHearingRoutingSectionConfigEntity> GetAllRMHearingRoutingSectionConfig()
        {
            List<RMHearingRoutingSectionConfig> listFromRepository = GetAllFromRepository<RMHearingRoutingSectionConfig>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(rmHearingRoutingSectionConfig => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMHearingRoutingSectionConfigEntity(rmHearingRoutingSectionConfig)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MPaperMinuteSheetTypeEntity> GetAllMPaperMinuteSheetType()
        {
            List<MPaperMinuteSheetType> listFromRepository = GetAllFromRepository<MPaperMinuteSheetType>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mPaperMinuteSheetType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMPaperMinuteSheetTypeEntity(mPaperMinuteSheetType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RAlertEventSubscribersEntity> GetListRAlertEventSubscribersByAlertEventType(string alertEventTypeCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RAlertEventSubscribers>()
                           .Add(Expression.Eq("AlertEventTypeCode", alertEventTypeCode));

            List<RAlertEventSubscribers> listRAlertEventSubscribers = GetFromDetachedCriteria<RAlertEventSubscribers>(detachedCriteria);
            if (listRAlertEventSubscribers != null && listRAlertEventSubscribers.Count > 0)
            {
                return listRAlertEventSubscribers.Select(rAlertEventSubscribersEntity => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRAlertEventSubscribersEntity(rAlertEventSubscribersEntity)).ToList();
            }
            else
                return null;
        }

        internal List<MFilingFeeTypeEntity> GetAllMFilingFeeType()
        {
            List<MFilingFeeType> listFromRepository = GetAllFromRepository<MFilingFeeType>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mFilingFeeType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFilingFeeTypeEntity(mFilingFeeType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MFilingFeeChargingMechanismEntity> GetListMFilingFeeChargingMechanism(string feeRuleCode)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<MFilingFeeChargingMechanism>()
                          .Add(Expression.Eq("MFilingFee.FeeRuleCode", feeRuleCode));

            List<MFilingFeeChargingMechanism> listFromRepository = GetFromDetachedCriteria<MFilingFeeChargingMechanism>(detachedCriteria);
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mFilingFeeChargingMechanism => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFilingFeeChargingMechanismEntity(mFilingFeeChargingMechanism)).ToList();
            }
            else
                return null;
        }


        internal List<MFilingFeeLegislationActEntity> GetAllMFilingFeeLegislationAct()
        {
            List<MFilingFeeLegislationAct> listFromRepository = GetAllFromRepository<MFilingFeeLegislationAct>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mFilingFeeLegislationAct => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMFilingFeeLegislationActEntity(mFilingFeeLegislationAct)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal void SaveOrUpdateRRoleFunctionEntity(RRoleFunctionsEntity rRoleFunctionsEntity)
        {
            try
            {
                Logger.Debug("Flushing Session to Sync With DB");
                applicationSession.Flush();
                Logger.Debug("Flushing Session Completed");

                Logger.Debug("SaveOrUpdateRRoleFunctionEntity");
                if (rRoleFunctionsEntity != null)
                {
                    RRoleFunctions rRoleFunctions = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.MasterMapper.GetRRoleFunctions(rRoleFunctionsEntity);

                    applicationSession.GetNamedQuery("SaveOrUpdateRRoleFunctionsProcedure")
                   .SetParameter("LastModifiedBy", rRoleFunctions.LastModifiedBy)
                      .SetParameter("LastModifiedDate", rRoleFunctions.LastModifiedDate)
                      .SetParameter("FunctionCode", rRoleFunctions.FunctionCode)
                      .SetParameter("RoleCode", rRoleFunctions.RoleCode)
                      .SetParameter("ObsInd", rRoleFunctions.ObsInd)


                      .ExecuteUpdate();

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateRRoleFunctionEntity", ex);
                throw;
            }
        }

        internal SerialNumberEntity GetSerialNumber(string docPrefix, int year)
        {
            IRepository<SerialNumber> repository = new RepositoryImpl<SerialNumber>(applicationSession);
            SerialNumber serialNumber = repository.Get(new SerialNumber()
            {
                DocPrefix = docPrefix,
                Year = year
            });

            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetSerialNumberEntity(serialNumber);

        }

        internal SerialNumberEntity GetNewCaseNumber(string caseType, int year)
        {
            try
            {
                applicationSession.Flush();

                SerialNumberEntity serialNumberEntity = GetSerialNumber(caseType, year);
                int serialNo = int.Parse(serialNumberEntity.SNo);

                serialNo += 1;

                string saveSQL = string.Format("UPDATE SerialNumber SET SNo = {0} WHERE DocPrefix = '{1}' and Year = {2}", serialNo,
                   caseType, year);
                applicationSession.CreateSQLQuery(saveSQL).ExecuteUpdate();

                serialNumberEntity.SNo = serialNo.ToString();

                return serialNumberEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at UpdateSerialNumber", ex);
                throw;
            }
        }

        internal List<MCourtVacationEntity> GetAllMCourtVacation()
        {
            List<MCourtVacation> listFromRepository = GetAllFromRepository<MCourtVacation>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mCourtVacation => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMCourtVacationEntity(mCourtVacation)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MForumTypeEntity> GetAllMForumTypeForSystemAdmin(string courtId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<MForumType>();
            if (courtId == "HC")
            {
                detachedCriteria.Add(Expression.Eq("CourtID", "HC"));
            }
            else
            {
                detachedCriteria.Add(Expression.Or(Expression.Eq("CourtID", "SU")
                                                  , Expression.Eq("CourtID", "FJ")));
            }

            List<MForumType> MForumTypeList = GetFromDetachedCriteria<MForumType>(detachedCriteria);
            if (MForumTypeList != null && MForumTypeList.Count > 0)
            {
                return MForumTypeList.Select(mForumType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.
                    GetMForumTypeEntity(mForumType)).ToList();
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Ms the document control forum entity by pk.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        internal IMasterEntity GetMDocControlForumEntityByPK(string primaryKey)
        {
            IRepository<MDocControlForum> repository = new RepositoryImpl<MDocControlForum>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocControlForumEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the list m document control forum by document code.
        /// </summary>
        /// <param name="docCode">The document code.</param>
        /// <returns></returns>
        internal List<MDocControlForumEntity> GetListMDocControlForumByDocCode(string docCode)
        {
            if (!string.IsNullOrEmpty(docCode))
            {
                MDocCode mMDocCode = new MDocCode { DOCCode = docCode };
                DetachedCriteria detachedCriteria = DetachedCriteria.For<MDocControlForum>()
                              .Add(Expression.Eq("MDocCode", mMDocCode));
                List<MDocControlForum> listMDocControlForum = GetFromDetachedCriteria<MDocControlForum>(detachedCriteria);
                if (listMDocControlForum != null && listMDocControlForum.Count > 0)
                {
                    return listMDocControlForum.Select(mDocControlForum => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDocControlForumEntity(mDocControlForum)).ToList();
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

        internal List<MEMSRecTransModeEntity> GetAllMEMSRecTransModeEntity()
        {
            List<MEMSRecTransMode> listFromRepository = GetAllFromRepository<MEMSRecTransMode>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mEMSRecTransMode => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMEMSRecTransModeDomain(mEMSRecTransMode)).ToList();
            }
            else
            {
                return null;
            }
        }


        internal List<MEMSAdvertiserEntity> GetAllMEMSAdvertiserEntity()
        {
            List<MEMSAdvertiser> listFromRepository = GetAllFromRepository<MEMSAdvertiser>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mEMSAdvertiser => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                    MasterMapper.GetMEMSAdvertiserDomain(mEMSAdvertiser)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MEMSAppraiserEntity> GetAllMEMSAppraiserEntity()
        {
            List<MEMSAppraiser> listFromRepository = GetAllFromRepository<MEMSAppraiser>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mEMSAppraiser => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                    MasterMapper.GetMEMSAppraiserDomain(mEMSAppraiser)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MEMSAuctioneerEntity> GetAllMEMSAuctioneerEntity()
        {
            List<MEMSAuctioneer> listFromRepository = GetAllFromRepository<MEMSAuctioneer>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mEMSAuctioneer => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                    MasterMapper.GetMEMSAuctioneerDomain(mEMSAuctioneer)).ToList();
            }
            else
            {
                return null;
            }
        }
        internal List<MEMSSalesAgentEntity> GetAllMEMSSalesAgentEntity()
        {
            List<MEMSSalesAgent> listFromRepository = GetAllFromRepository<MEMSSalesAgent>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mEMSSalesAgent => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                    MasterMapper.GetMEMSSalesAgentDomain(mEMSSalesAgent)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MAASDisciplinaryTypeEntity> GetAllMAASDisciplinaryTypeEntity()
        {
            List<MAASDisciplinaryType> listFromRepository = GetAllFromRepository<MAASDisciplinaryType>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mAASDisciplinaryType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                    MasterMapper.GetMAASDisciplinaryTypeEntity(mAASDisciplinaryType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MAASDisciplinaryResultTypeEntity> GetAllMAASDisciplinaryResultTypeEntity()
        {
            List<MAASDisciplinaryResultType> listFromRepository = GetAllFromRepository<MAASDisciplinaryResultType>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mAASDisciplinaryResultType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                    MasterMapper.GetMAASDisciplinaryResultTypeEntity(mAASDisciplinaryResultType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MAASUniversityEntity> GetAllMAASUniversityEntity()
        {
            List<MAASUniversity> listFromRepository = GetAllFromRepository<MAASUniversity>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(mAASUniversity => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                    MasterMapper.GetMAASUniversityEntity(mAASUniversity)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal RMDocTierSensitiveEntity GetRMDocTierSensitiveEntity(string forumID, string caseTypeCode, string docCode)
        {
            MCaseType mCaseType = new MCaseType {CaseTypeCode= caseTypeCode };
            MDocCode mDocCode = new MDocCode { DOCCode = docCode };

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RMDocTierSensitive))
                .Add(Expression.Eq("ForumID", forumID))
                .Add(Expression.Eq("CaseTypeCode", mCaseType))
                .Add(Expression.Eq("MDocCode", mDocCode));

            List<RMDocTierSensitive> listRMDocTierSensitive = GetEntityByDetachedCriteria<RMDocTierSensitive>(detachedCriteria);
            if (listRMDocTierSensitive != null && listRMDocTierSensitive.Count > 0)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMDocTierSensitiveEntity(listRMDocTierSensitive[0]);
            }
            else
                return null;
        }

        internal List<RMHrgSlotNOCEntity> GetAllRMHrgSlotNOCEntity()
        {
            List<RMHrgSlotNOC> listFromRepository = GetAllFromRepository<RMHrgSlotNOC>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(rMHrgSlotNOC => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                    MasterMapper.GetRMHrgSlotNOCEntity(rMHrgSlotNOC)).ToList();
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
        internal void SaveOrUpdateRMRoutingSectionConfigEntity<T>(T entityToSave, bool isCopy)
        {
            IRepository<T> iMasterRepository = new RepositoryImpl<T>(applicationSession);
            iMasterRepository.SaveOrUpdate(entityToSave, isCopy);
        }


        /// <summary>
        /// Gets all m default login page.
        /// </summary>
        /// <returns></returns>
        internal List<MDefaultLoginPageEntity> GetAllMDefaultLoginPage()
        {
            List<MDefaultLoginPage> listMDefaultLoginPage = GetAllFromRepository<MDefaultLoginPage>();
            if (listMDefaultLoginPage != null && listMDefaultLoginPage.Count > 0)
            {
                return listMDefaultLoginPage.Select(mCourtType => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDefaultLoginPageEntity(mCourtType)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMHrgSlotLegisEntity> GetAllRMHrgSlotLegisEntity()
        {
            List<RMHrgSlotLegis> listFromRepository = GetAllFromRepository<RMHrgSlotLegis>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(rMHrgSlotLegis => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                    MasterMapper.GetRMHrgSlotLegisEntity(rMHrgSlotLegis)).ToList();
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Deletes the rm HRG slot noc.
        /// </summary>
        /// <param name="rMHrgSlotNOCEntity">The r m HRG slot noc entity.</param>
        internal void DeleteRMHrgSlotNOC(RMHrgSlotNOCEntity rMHrgSlotNOCEntity)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RMHrgSlotNOC>()
              .Add(Expression.Eq("RMHrgSlotNocID", rMHrgSlotNOCEntity.RMHrgSlotNocID));

            Repository<RMHrgSlotNOC>().DeleteAll(detachedCriteria);

        }

        internal List<RMHrgSlotNOCEntity> GetListRMHrgSlotNOCEntityByForumID(string forumID)
        {
            if (!string.IsNullOrEmpty(forumID))
            {
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RMHrgSlotNOC))
                    .Add(Expression.Eq("ForumID", forumID));
                List<RMHrgSlotNOC> listrMHrgSlotNOC = GetFromDetachedCriteria<RMHrgSlotNOC>(detachedCriteria);
                if (listrMHrgSlotNOC != null && listrMHrgSlotNOC.Count > 0)
                {
                    return listrMHrgSlotNOC.Select(rMHrgSlotNOC => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMHrgSlotNOCEntity(rMHrgSlotNOC)).ToList();
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

        internal List<RMDocControlExclusionEntity> GetListRMDocControlExclusionByDocCode(string docCode)
        {
            if (!string.IsNullOrEmpty(docCode))
            {
                MDocCode mDocCode = new MDocCode { DOCCode = docCode };
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RMDocControlExclusion))
                    .Add(Expression.Eq("MDocCode", mDocCode));

                List<RMDocControlExclusion> listRMDocControlExclusion = GetFromDetachedCriteria<RMDocControlExclusion>(detachedCriteria);
                if (listRMDocControlExclusion != null && listRMDocControlExclusion.Count > 0)
                {
                    return listRMDocControlExclusion.Select(rMDocControlExclusion => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMDocControlExclusionEntity(rMDocControlExclusion)).ToList();
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

        internal List<RMDocControlExclusionEntity> GetAllRMDocControlExclusion()
        {
            List<RMDocControlExclusion> listFromRepository = GetAllFromRepository<RMDocControlExclusion>();
            if (listFromRepository != null && listFromRepository.Count > 0)
            {
                return listFromRepository.Select(rMDocControlExclusion => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                    MasterMapper.GetRMDocControlExclusionEntity(rMDocControlExclusion)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MResidentialEntity> GetAllMResidential()
        {
            List<MResidential> listMResidential = GetAllFromRepository<MResidential>();
            if (listMResidential != null && listMResidential.Count > 0)
            {
                return listMResidential.Select(mResidential => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMResidentialEntity(mResidential)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MIncomeEntity> GetAllMIncome()
        {
            List<MIncome> listMIncome = GetAllFromRepository<MIncome>();
            if (listMIncome != null && listMIncome.Count > 0)
            {
                return listMIncome.Select(mIncome => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMIncomeEntity(mIncome)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MDirectionsEntity> GetAllMDirections()
        {
            List<MDirections> listMDirections = GetAllFromRepository<MDirections>();
            if (listMDirections != null && listMDirections.Count > 0)
            {
                return listMDirections.Select(mDirections => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMDirectionsEntity(mDirections)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<MHarassPlaceEntity> GetAllMHarassPlace()
        {
            List<MHarassPlace> listMHarassPlace = GetAllFromRepository<MHarassPlace>();
            if (listMHarassPlace != null && listMHarassPlace.Count > 0)
            {
                return listMHarassPlace.Select(mHarassPlace => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMHarassPlaceEntity(mHarassPlace)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<RMHrgSlotLegisEntity> GetListRMHrgSlotLegisEntityByForumID(string forumID)
        {

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RMHrgSlotLegis))
                   .Add(Expression.Eq("ForumID", forumID));
            List<RMHrgSlotLegis> listrMHrgSlotLigis = GetFromDetachedCriteria<RMHrgSlotLegis>(detachedCriteria);
            if (listrMHrgSlotLigis != null && listrMHrgSlotLigis.Count > 0)
            {
                return listrMHrgSlotLigis.Select(rMHrgSlotLegis => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetRMHrgSlotLegisEntity(rMHrgSlotLegis)).ToList();
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}

