#region Header

/*****************************************************************************************************
* Description : This file represents a object mapper Case entities. This class will map Object to
* Entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   23/09/2010   		      Nai                	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CaseMapper.cs
// Description: This file represents a object mapper Case entities. This class will map Object to
// Entity.
// </summary>
// <copyright file= "CaseMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    public class CaseMapper
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(CaseMapper));

        private static CaseMapping caseMapping = new CaseMapping();

        #endregion Fields

        #region Constructors

        public CaseMapper()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the case entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="caseEntity">The case entity.</param>
        /// <returns></returns>
        public static ICase GetCaseEntity<T>(T caseEntity)
        {
            if (caseEntity.GetType().Equals(typeof(CaseInfoEntity)))
                return CaseMapper.GetCaseInfo(caseEntity as CaseInfoEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyEntity)))
                return CaseMapper.GetCaseParty(caseEntity as CasePartyEntity);

            else if (caseEntity.GetType().Equals(typeof(CaseInfoNumberEntity)))
                return CaseMapper.GetCaseInfoNumber(caseEntity as CaseInfoNumberEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyAddressEntity)))
                return CaseMapper.GetCasePartyAddress(caseEntity as CasePartyAddressEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyAICAddressEntity)))
                return CaseMapper.GetCasePartyAICAddress(caseEntity as CasePartyAICAddressEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyAICAliasEntity)))
                return CaseMapper.GetCasePartyAICAlias(caseEntity as CasePartyAICAliasEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyAICDetailsEntity)))
                return CaseMapper.GetCasePartyAICDetails(caseEntity as CasePartyAICDetailsEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyAliasEntity)))
                return CaseMapper.GetCasePartyAlias(caseEntity as CasePartyAliasEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyAuthorisedOfficerDetailsEntity)))
                return CaseMapper.GetCasePartyAuthorisedOfficerDetail(caseEntity as CasePartyAuthorisedOfficerDetailsEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyVesselDetailsEntity)))
                return CaseMapper.GetCasePartyVesselDetail(caseEntity as CasePartyVesselDetailsEntity);

            else if (caseEntity.GetType().Equals(typeof(CaseSolicitorEntity)))
                return CaseMapper.GetCaseSolicitor(caseEntity as CaseSolicitorEntity);

            else if (caseEntity.GetType().Equals(typeof(CaseSolicitorHistoryEntity)))
                return CaseMapper.GetCaseSolicitorHistory(caseEntity as CaseSolicitorHistoryEntity);

            else if (caseEntity.GetType().Equals(typeof(HearingAdminSupportEntity)))
                return CaseMapper.GetHearingAdminSupport(caseEntity as HearingAdminSupportEntity);

            else if (caseEntity.GetType().Equals(typeof(HearingEntity)))
                return CaseMapper.GetHearing(caseEntity as HearingEntity);

            else if (caseEntity.GetType().Equals(typeof(LawFirmCaseFileRefNumberEntity)))
                return CaseMapper.GetLawFirmCaseFileRefNumber(caseEntity as LawFirmCaseFileRefNumberEntity);

            else if (caseEntity.GetType().Equals(typeof(RCaseLawFirmEntity)))
                return CaseMapper.GetRCaseLawFirm(caseEntity as RCaseLawFirmEntity);

            else if (caseEntity.GetType().Equals(typeof(RCaseSubmissionEntity)))
                return CaseMapper.GetRCaseSubmission(caseEntity as RCaseSubmissionEntity);

            else if (caseEntity.GetType().Equals(typeof(CaseOriginatingCaseEntity)))
                return CaseMapper.GetCaseOriginatingCase(caseEntity as CaseOriginatingCaseEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyLACDetailEntity)))
                return CaseMapper.GetCasePartyLACDetail(caseEntity as CasePartyLACDetailEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyLACDetailHistoryEntity)))
                return CaseMapper.GetCasePartyLACDetailsHistory(caseEntity as CasePartyLACDetailHistoryEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyBailorAddressEntity)))
                return GetCasePartyBailorAddress(caseEntity as CasePartyBailorAddressEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyBailorInfoEntity)))
                return GetCasePartyBailorInfo(caseEntity as CasePartyBailorInfoEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyCriminalInfoEntity)))
                return GetCasePartyCriminalInfo(caseEntity as CasePartyCriminalInfoEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyCitizenshipEntity)))
                return GetCasePartyCitizenship(caseEntity as CasePartyCitizenshipEntity);

            else if (caseEntity.GetType().Equals(typeof(RCaseLinkedEntity)))
                return CaseMapper.GetRCaseLinked(caseEntity as RCaseLinkedEntity);

            else if (caseEntity.GetType().Equals(typeof(RCaseTransferEntity)))
                return CaseMapper.GetRCaseTransfer(caseEntity as RCaseTransferEntity);

            else if (caseEntity.GetType().Equals(typeof(RLawFirmSolicitorsEntity)))
                return CaseMapper.GetRLawFirmSolicitors(caseEntity as RLawFirmSolicitorsEntity);

            else if (caseEntity.GetType().Equals(typeof(CaseIssueListEntity)))
                return CaseMapper.GetCaseIssueList(caseEntity as CaseIssueListEntity);

            else if (caseEntity.GetType().Equals(typeof(CaseStatusHistoryEntity)))
                return CaseMapper.GetCaseStatusHistory(caseEntity as CaseStatusHistoryEntity);

            else if (caseEntity.GetType().Equals(typeof(CasePartyStatusHistoryEntity)))
                return CaseMapper.GetCasePartyStatusHistory(caseEntity as CasePartyStatusHistoryEntity);

            else if (caseEntity.GetType().Equals(typeof(RCaseConsolidateEntity)))
                return CaseMapper.GetRCaseConsolidate(caseEntity as RCaseConsolidateEntity);

            else if (caseEntity.GetType().Equals(typeof(RCaseTransferHistoryEntity)))
                return CaseMapper.GetRCaseTransferHistory(caseEntity as RCaseTransferHistoryEntity);

            else if (caseEntity.GetType().Equals(typeof(TransferOrderOfCourtEntity)))
                return CaseMapper.GetTransferOrderOfCourt(caseEntity as TransferOrderOfCourtEntity);

            else if (caseEntity.GetType().Equals(typeof(PartyCaseFileRefNumberEntity)))
                return CaseMapper.GetPartyCaseFileRefNumber(caseEntity as PartyCaseFileRefNumberEntity);

            else
                throw new ArgumentNullException("Invalid object sent.");
        }

        /// <summary>
        /// Maps the entities to domain.
        /// </summary>
        /// <param name="caseInfo">The case info.</param>
        /// <returns>Returns the <see cref="CaseInfoEntity"/>, else null.</returns>
        public static CaseInfo GetCaseInfo(CaseInfoEntity caseInfoEntity)
        {
            CaseInfo caseInfo = null;

            try
            {
                caseInfo = Mapper.Map<CaseInfoEntity, CaseInfo>(caseInfoEntity);
                caseInfo.MCaseSecurity = Mapper.Map<MCaseSecurityEntity, MCaseSecurity>(caseInfoEntity.CaseSecurity);
                caseInfo.MCaseStatus = Mapper.Map<MCaseStatusEntity, MCaseStatus>(caseInfoEntity.CaseStatus);
                caseInfo.MCaseType = Mapper.Map<MCaseTypeEntity, MCaseType>(caseInfoEntity.CaseType);
                caseInfo.MForumType = Mapper.Map<MForumTypeEntity, MForumType>(caseInfoEntity.ForumType);
                caseInfo.MSection = Mapper.Map<MSectionEntity, MSection>(caseInfoEntity.CaseOfficerAssignedSectionCode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseInfo",ex);
                throw;
            }

            return caseInfo;
        }

        /// <summary>
        /// Maps the entities to domain.
        /// </summary>
        /// <param name="CaseInfoNumberEntity">CaseInfoNumber Entity.</param>
        /// <returns>Returns the <see cref="CaseInfoNumber"/>, else null.</returns>
        public static CaseInfoNumber GetCaseInfoNumber(CaseInfoNumberEntity caseInfoNumberEntity)
        {
            CaseInfoNumber caseInfoNumber = null;

            try
            {
                caseInfoNumber = Mapper.Map<CaseInfoNumberEntity, CaseInfoNumber>(caseInfoNumberEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseInfoNumber", ex);
                throw;
            }

            return caseInfoNumber;
        }

        /// <summary>
        /// Maps the entities to domain.
        /// </summary>
        /// <param name="CaseIssueList">The Case Issue List.</param>
        /// <returns>Returns the <see cref="CaseIssueListEntity"/>, else null.</returns>
        public static CaseIssueList GetCaseIssueList(CaseIssueListEntity caseIssueListEntity)
        {
            CaseIssueList caseIssueList = null;

            try
            {
                caseIssueList = Mapper.Map<CaseIssueListEntity, CaseIssueList>(caseIssueListEntity);
                caseIssueList.MCaseIssue = Mapper.Map<MCaseIssueEntity, MCaseIssue>(caseIssueListEntity.MCaseIssue);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseIssueList", ex);
                throw;
            }

            return caseIssueList;
        }

        /// <summary>
        /// Get <see cref="CaseOriginatingCase "/>
        /// </summary>
        /// <param name="CaseOriginatingCaseEntity"></param>
        /// <returns></returns>
        public static CaseOriginatingCase GetCaseOriginatingCase(CaseOriginatingCaseEntity caseOriginatingCaseEntity)
        {
            CaseOriginatingCase caseOriginatingCase = null;

            try
            {
                caseOriginatingCase = Mapper.Map<CaseOriginatingCaseEntity, CaseOriginatingCase>(caseOriginatingCaseEntity);
                caseOriginatingCase.MCourtType = Mapper.Map<MCourtTypeEntity, MCourtType>(caseOriginatingCaseEntity.CourtId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseOriginatingCase", ex);
                throw;
            }

            return caseOriginatingCase;
        }

        /// <summary>
        /// Maps the entities to domain.
        /// </summary>
        /// <param name="CasePartyEntity">The case party.</param>
        /// <returns>Returns the <see cref="CasePartyEntity"/>, else null.</returns>
        public static CaseParty GetCaseParty(CasePartyEntity casePartyDomainEntity)
        {
            CaseParty casePartyNHibernateEntity = null;

            try
            {
                if (casePartyDomainEntity != null)
                {
                    casePartyNHibernateEntity = Mapper.Map<CasePartyEntity, CaseParty>(casePartyDomainEntity);
                    casePartyNHibernateEntity.MCPBirthCountry = Mapper.Map<MCountryEntity, MCountry>(casePartyDomainEntity.MBirthCountry);
                    casePartyNHibernateEntity.MCPCompanyIdType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(casePartyDomainEntity.MCompanyIdType);
                    casePartyNHibernateEntity.MCPCountryOfRegistration = Mapper.Map<MCountryEntity, MCountry>(casePartyDomainEntity.MCountryOfRegistration);
                    casePartyNHibernateEntity.MApplicantCapacity = Mapper.Map<MApplicantCapacityEntity, MApplicantCapacity>(casePartyDomainEntity.MApplicantCapacity);
                    casePartyNHibernateEntity.MCPIdCountry = Mapper.Map<MCountryEntity, MCountry>(casePartyDomainEntity.MIdCountry);
                    casePartyNHibernateEntity.MCPMarriageCountry = Mapper.Map<MCountryEntity, MCountry>(casePartyDomainEntity.MIdCountry);
                    casePartyNHibernateEntity.MCPPersonIdType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(casePartyDomainEntity.MPersonIdType);
                    casePartyNHibernateEntity.MDialect = Mapper.Map<MDialectEntity, MDialect>(casePartyDomainEntity.MDialect);
                    casePartyNHibernateEntity.MEntityType = Mapper.Map<MEntityTypeEntity, MEntityType>(casePartyDomainEntity.MEntityType);
                    casePartyNHibernateEntity.MGender = Mapper.Map<MGenderEntity, MGender>(casePartyDomainEntity.MGender);
                    casePartyNHibernateEntity.MMaritalStatus = Mapper.Map<MMaritalStatusEntity, MMaritalStatus>(casePartyDomainEntity.MMaritalStatus);
                    casePartyNHibernateEntity.MNationality = Mapper.Map<MNationalityEntity, MNationality>(casePartyDomainEntity.MNationality);
                    casePartyNHibernateEntity.MOccupation = Mapper.Map<MOccupationEntity, MOccupation>(casePartyDomainEntity.MOccupation);
                    casePartyNHibernateEntity.MPartyStatus = Mapper.Map<MPartyStatusEntity, MPartyStatus>(casePartyDomainEntity.MPartyStatus);
                    casePartyNHibernateEntity.MPartyType = Mapper.Map<MPartyTypeEntity, MPartyType>(casePartyDomainEntity.MPartyType);
                    casePartyNHibernateEntity.MPersonIDGroup = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(casePartyDomainEntity.MPersonIdGroup);
                    casePartyNHibernateEntity.MQualification = Mapper.Map<MQualificationEntity, MQualification>(casePartyDomainEntity.MQualification);
                    casePartyNHibernateEntity.MRace = Mapper.Map<MRaceEntity, MRace>(casePartyDomainEntity.MRace);
                    casePartyNHibernateEntity.MReligion = Mapper.Map<MReligionEntity, MReligion>(casePartyDomainEntity.MReligion);
                    casePartyNHibernateEntity.CounterClaimPartyTypeCode = Mapper.Map<MPartyTypeEntity, MPartyType>(casePartyDomainEntity.CounterClaimPartyTypeCode);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseParty", ex);
                throw;
            }

            return casePartyNHibernateEntity;
        }

        /// <summary>
        /// Get Document Case Party Address.
        /// </summary>
        /// <param name="casePartyAddressDomainEntity"></param>
        /// <returns></returns>
        public static CasePartyAddress GetCasePartyAddress(CasePartyAddressEntity casePartyAddressDomainEntity)
        {
            CasePartyAddress casePartyAddressNHibernateEntity = null;

            try
            {
                casePartyAddressNHibernateEntity = Mapper.Map<CasePartyAddressEntity, CasePartyAddress>(casePartyAddressDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCasePartyAddress", ex);
                throw;
            }

            return casePartyAddressNHibernateEntity;
        }

        /// <summary>
        /// Get Document Case Party Address.
        /// </summary>
        /// <param name="casePartyAICAddressDomainEntity"></param>
        /// <returns></returns>
        public static CasePartyAICAddress GetCasePartyAICAddress(CasePartyAICAddressEntity casePartyAICAddressDomainEntity)
        {
            CasePartyAICAddress casePartyAICAddressNHibernateEntity = null;

            try
            {
                casePartyAICAddressNHibernateEntity = Mapper.Map<CasePartyAICAddressEntity, CasePartyAICAddress>(casePartyAICAddressDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCasePartyAICAddress", ex);
                throw;
            }

            return casePartyAICAddressNHibernateEntity;
        }

        /// <summary>
        /// Get Document Case Party Alias.
        /// </summary>
        /// <param name="casePartyAICAliasDomainEntity"></param>
        /// <returns></returns>
        public static CasePartyAICAlias GetCasePartyAICAlias(CasePartyAICAliasEntity casePartyAICAliasDomainEntity)
        {
            CasePartyAICAlias casePartyAICAliasNHibernateEntity = null;

            try
            {
                casePartyAICAliasNHibernateEntity = Mapper.Map<CasePartyAICAliasEntity, CasePartyAICAlias>(casePartyAICAliasDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCasePartyAICAlias", ex);
                throw;
            }

            return casePartyAICAliasNHibernateEntity;
        }

        /// <summary>
        /// Get Document Case Party Detail.
        /// </summary>
        /// <param name="casePartyAICDetailsDetailsEntity"></param>
        /// <returns></returns>
        public static CasePartyAICDetail GetCasePartyAICDetails(CasePartyAICDetailsEntity casePartyAICDetailsDomainEntity)
        {
            CasePartyAICDetail casePartyAICNHibernateEntity = null;

            try
            {
                casePartyAICNHibernateEntity = Mapper.Map<CasePartyAICDetailsEntity, CasePartyAICDetail>(casePartyAICDetailsDomainEntity);
                casePartyAICNHibernateEntity.MActingInCapacity = Mapper.Map<MActingInCapacityEntity, MActingInCapacity>(casePartyAICDetailsDomainEntity.MActingInCapacity);
                casePartyAICNHibernateEntity.MCPAICDCompanyIdTypeCode = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(casePartyAICDetailsDomainEntity.MPersonIdType);
                casePartyAICNHibernateEntity.MCPAICDCountryOfRegistration = Mapper.Map<MCountryEntity, MCountry>(casePartyAICDetailsDomainEntity.MCountryOfRegistration);
                casePartyAICNHibernateEntity.MCPAICDIdCountryCode = Mapper.Map<MCountryEntity, MCountry>(casePartyAICDetailsDomainEntity.MIdCountry);
                casePartyAICNHibernateEntity.MEntityType = Mapper.Map<MEntityTypeEntity, MEntityType>(casePartyAICDetailsDomainEntity.MEntityType);
                casePartyAICNHibernateEntity.MGender = Mapper.Map<MGenderEntity, MGender>(casePartyAICDetailsDomainEntity.MGender);
                casePartyAICNHibernateEntity.MPersonIDGroup = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(casePartyAICDetailsDomainEntity.MPersonIdGroup);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCasePartyAICDetails", ex);
                throw;
            }

            return casePartyAICNHibernateEntity;
        }

        /// <summary>
        /// Maps the domain to entities.
        /// </summary>
        /// <param name="casePartyAliasDomainEntity">Case Party Alias</param>
        /// <returns>Returns the <see cref="casePartyAliasDomainEntity"/>, else null.</returns>
        public static CasePartyAlias GetCasePartyAlias(CasePartyAliasEntity casePartyAliasDomainEntity)
        {
            CasePartyAlias casePartyAliasNHibernateEntity = null;

            try
            {
                casePartyAliasNHibernateEntity = Mapper.Map<CasePartyAliasEntity, CasePartyAlias>(casePartyAliasDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCasePartyAlias", ex);
                throw;
            }

            return casePartyAliasNHibernateEntity;
        }

        /// <summary>
        /// Maps the domain to entities.
        /// </summary>
        /// <param name="casePartyAuthorisedOfficerDetailDomainEntity">Case Party Authorised Officer</param>
        /// <returns>Returns the <see cref="CasePartyAuthorisedOfficerDetail"/>, else null.</returns>
        public static CasePartyAuthorisedOfficerDetail GetCasePartyAuthorisedOfficerDetail(CasePartyAuthorisedOfficerDetailsEntity casePartyAuthorisedOfficerDetailDomainEntity)
        {
            CasePartyAuthorisedOfficerDetail casePartyAuthorisedOfficerDetailNHibernateEntity = null;

            try
            {
                casePartyAuthorisedOfficerDetailNHibernateEntity = Mapper.Map<CasePartyAuthorisedOfficerDetailsEntity, CasePartyAuthorisedOfficerDetail>(casePartyAuthorisedOfficerDetailDomainEntity);
                casePartyAuthorisedOfficerDetailNHibernateEntity.MCountry = Mapper.Map<MCountryEntity, MCountry>(casePartyAuthorisedOfficerDetailDomainEntity.MCountryEntity);
                casePartyAuthorisedOfficerDetailNHibernateEntity.MPersonIDGroup = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(casePartyAuthorisedOfficerDetailDomainEntity.MPersonIDGroupEntity);
                casePartyAuthorisedOfficerDetailNHibernateEntity.MPersonIDType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(casePartyAuthorisedOfficerDetailDomainEntity.MPersonIDTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCasePartyAuthorisedOfficerDetail", ex);
                throw;
            }

            return casePartyAuthorisedOfficerDetailNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyBailorAddress"/> from <see cref="CasePartyBailorAddressEntity"/> input.
        /// </summary>
        /// <param name="casePartyBailorAddressEntity"><see cref="CasePartyBailorAddressEntity"/></param>
        /// <returns>Returns <see cref="CasePartyBailorAddress"/>, else null.</returns>
        public static CasePartyBailorAddress GetCasePartyBailorAddress(CasePartyBailorAddressEntity casePartyBailorAddressEntity)
        {
            CasePartyBailorAddress casePartyBailorAddress = null;

            try
            {
                if (casePartyBailorAddressEntity != null)
                {
                    casePartyBailorAddress = Mapper.Map<CasePartyBailorAddressEntity, CasePartyBailorAddress>(casePartyBailorAddressEntity);
                    casePartyBailorAddress.MCountry = Mapper.Map<MCountryEntity, MCountry>(casePartyBailorAddressEntity.MCountry);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyBailorAddress", ex);
                throw;
            }

            return casePartyBailorAddress;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyBailorInfo"/> from <see cref="CasePartyBailorInfoEntity"/> input.
        /// </summary>
        /// <param name="casePartyBailorInfoEntity"><see cref="CasePartyBailorInfoEntity"/></param>
        /// <returns>Returns <see cref="CasePartyBailorInfo"/>, else null.</returns>
        public static CasePartyBailorInfo GetCasePartyBailorInfo(CasePartyBailorInfoEntity casePartyBailorInfoEntity)
        {
            CasePartyBailorInfo casePartyBailorInfo = null;

            try
            {
                if (casePartyBailorInfoEntity != null)
                {
                    casePartyBailorInfo = Mapper.Map<CasePartyBailorInfoEntity, CasePartyBailorInfo>(casePartyBailorInfoEntity);
                    casePartyBailorInfo.MCountry = Mapper.Map<MCountryEntity, MCountry>(casePartyBailorInfoEntity.MCountry);
                    casePartyBailorInfo.MBailType = Mapper.Map<MBailTypeEntity, MBailType>(casePartyBailorInfoEntity.MBailType);
                    casePartyBailorInfo.MIDType = Mapper.Map<MIDTypeEntity, MIDType>(casePartyBailorInfoEntity.MIDType);
                    casePartyBailorInfo.IDGroupCode = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(casePartyBailorInfoEntity.IDGroupCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyBailorInfo", ex);
                throw;
            }

            return casePartyBailorInfo;
        }

        /** End of For Criminal Entities **/
        /// <summary>
        /// Gets the <see cref="CasePartyCitizenship"/> from <see cref="CasePartyCitizenshipEntity"/> input.
        /// </summary>
        /// <param name="CasePartyCitizenshipEntity"><see cref="CasePartyCitizenshipEntity"/></param>
        /// <returns>Returns <see cref="CasePartyCitizenship"/>, else null.</returns>
        public static CasePartyCitizenship GetCasePartyCitizenship(CasePartyCitizenshipEntity casePartyCitizenshipEntity)
        {
            CasePartyCitizenship casePartyCitizenship = null;

            try
            {
                if (casePartyCitizenshipEntity != null)
                {
                    casePartyCitizenship = Mapper.Map<CasePartyCitizenshipEntity, CasePartyCitizenship>(casePartyCitizenshipEntity);
                    casePartyCitizenship.MCountry = Mapper.Map<MCountryEntity, MCountry>(casePartyCitizenshipEntity.MCountry);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyCitizenship", ex);
                throw;
            }

            return casePartyCitizenship;
        }

        /** For Criminal Entities **/
        /// <summary>
        /// Gets the <see cref="CasePartyCriminalInfo"/> from <see cref="CasePartyCriminalInfoEntity"/> input.
        /// </summary>
        /// <param name="casePartyCriminalInfoEntity"><see cref="CasePartyCriminalInfoEntity"/></param>
        /// <returns>Returns <see cref="CasePartyCriminalInfo"/>, else null.</returns>
        public static CasePartyCriminalInfo GetCasePartyCriminalInfo(CasePartyCriminalInfoEntity casePartyCriminalInfoEntity)
        {
            CasePartyCriminalInfo casePartyCriminalInfo = null;

            try
            {
                if (casePartyCriminalInfoEntity != null)
                {
                    casePartyCriminalInfo = Mapper.Map<CasePartyCriminalInfoEntity, CasePartyCriminalInfo>(casePartyCriminalInfoEntity);
                    casePartyCriminalInfo.MPrisonCustodyPrisonCode = Mapper.Map<MPrisonEntity, MPrison>(casePartyCriminalInfoEntity.MPrisonCustody);
                    casePartyCriminalInfo.MPrisonRemandPrisonCode = Mapper.Map<MPrisonEntity, MPrison>(casePartyCriminalInfoEntity.MPrisonRemand);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyCriminalInfo", ex);
                throw;
            }

            return casePartyCriminalInfo;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyLACDetail"/> from <see cref="CasePartyLACDetailEntity"/> input.
        /// </summary>
        /// <param name="casePartyLACDetailEntity"><see cref="CasePartyLACDetailEntity"/></param>
        /// <returns>Returns <see cref="CasePartyLACDetail"/>, else null.</returns>
        public static CasePartyLACDetail GetCasePartyLACDetail(CasePartyLACDetailEntity casePartyLACDetailEntity)
        {
            CasePartyLACDetail casePartyLACDetail = null;

            try
            {
                if (casePartyLACDetailEntity != null)
                {
                    casePartyLACDetail = Mapper.Map<CasePartyLACDetailEntity, CasePartyLACDetail>(casePartyLACDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyLACDetail", ex);
                throw;
            }

            return casePartyLACDetail;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyLACDetailsHistory"/> from <see cref="CasePartyLACDetailHistoryEntity"/> input.
        /// </summary>
        /// <param name="casePartyLACDetailHistoryEntity"><see cref="CasePartyLACDetailHistoryEntity"/></param>
        /// <returns>Returns <see cref="CasePartyLACDetailsHistory"/>, else null.</returns>
        public static CasePartyLACDetailsHistory GetCasePartyLACDetailsHistory(CasePartyLACDetailHistoryEntity casePartyLACDetailHistoryEntity)
        {
            CasePartyLACDetailsHistory casePartyLACDetailsHistory = null;

            try
            {
                if (casePartyLACDetailHistoryEntity != null)
                {
                    casePartyLACDetailsHistory = Mapper.Map<CasePartyLACDetailHistoryEntity, CasePartyLACDetailsHistory>(casePartyLACDetailHistoryEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyLACDetailsHistory", ex);
                throw;
            }

            return casePartyLACDetailsHistory;
        }

        public static CasePartyStatusHistory GetCasePartyStatusHistory(CasePartyStatusHistoryEntity casePartyStatusHistoryEntity)
        {
            CasePartyStatusHistory casePartyStatusHistory = null;
            try
            {
                casePartyStatusHistory = Mapper.Map<CasePartyStatusHistoryEntity, CasePartyStatusHistory>(casePartyStatusHistoryEntity);
                casePartyStatusHistory.MPartyStatus = Mapper.Map<MPartyStatusEntity, MPartyStatus>(casePartyStatusHistoryEntity.MPartyStatus);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCasePartyStatusHistory", ex);
                throw;
            }
            return casePartyStatusHistory;
        }

        /// <summary>
        /// Maps the domain to entities.
        /// </summary>
        /// <param name="casePartyVesselDetailDomainEntity">Case Party Alias</param>
        /// <returns>Returns the <see cref="CasePartyVesselDetail"/>, else null.</returns>
        public static CasePartyVesselDetail GetCasePartyVesselDetail(CasePartyVesselDetailsEntity casePartyVesselDetailDomainEntity)
        {
            CasePartyVesselDetail casePartyVesselDetailNHibernateEntity = null;

            try
            {
                casePartyVesselDetailNHibernateEntity = Mapper.Map<CasePartyVesselDetailsEntity, CasePartyVesselDetail>(casePartyVesselDetailDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCasePartyVesselDetail", ex);
                throw;
            }

            return casePartyVesselDetailNHibernateEntity;
        }

        /// <summary>
        /// Maps the domain to entities.
        /// </summary>
        /// <param name="caseSolicitorDomainEntity">Case Party Solicitor</param>
        /// <returns>Returns the <see cref="CaseSolicitor"/>, else null.</returns>
        public static CaseSolicitor GetCaseSolicitor(CaseSolicitorEntity caseSolicitorDomainEntity)
        {
            CaseSolicitor caseSolicitorNHibernateEntity = null;

            try
            {
                caseSolicitorNHibernateEntity = Mapper.Map<CaseSolicitorEntity, CaseSolicitor>(caseSolicitorDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseSolicitor", ex);
                throw;
            }

            return caseSolicitorNHibernateEntity;
        }

        /// <summary>
        /// Maps the domain to entities.
        /// </summary>
        /// <param name="caseSolicitorHistoryDomainEntity">Case Party Solicitor History</param>
        /// <returns>Returns the <see cref="CaseSolicitorHistory"/>, else null.</returns>
        public static CaseSolicitorHistory GetCaseSolicitorHistory(CaseSolicitorHistoryEntity caseSolicitorHistoryDomainEntity)
        {
            CaseSolicitorHistory caseSolicitorHistoryNHibernateEntity = null;

            try
            {
                caseSolicitorHistoryNHibernateEntity = Mapper.Map<CaseSolicitorHistoryEntity, CaseSolicitorHistory>(caseSolicitorHistoryDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseSolicitorHistory", ex);
                throw;
            }

            return caseSolicitorHistoryNHibernateEntity;
        }

        public static CaseStatusHistory GetCaseStatusHistory(CaseStatusHistoryEntity caseStatusHistoryEntity)
        {
            CaseStatusHistory caseStatusHistory = null;
            try
            {
                caseStatusHistory = Mapper.Map<CaseStatusHistoryEntity, CaseStatusHistory>(caseStatusHistoryEntity);
                caseStatusHistory.MCaseStatus = Mapper.Map<MCaseStatusEntity, MCaseStatus>(caseStatusHistoryEntity.MCaseStatus);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseStatusHistory", ex);
                throw;
            }
            return caseStatusHistory;
        }

        /// <summary>
        /// Gets the <see cref="HearingEntity"/> based on <see cref="Hearing"/>.
        /// </summary>
        /// <param name="hearing">The hearing object.</param>
        /// <returns>Returns <see cref="HearingEntity"/>, else null.</returns>
        public static Hearing GetHearing(HearingEntity hearingEntity)
        {
            Hearing hearing = null;

            try
            {
                hearing = Mapper.Map<HearingEntity, Hearing>(hearingEntity);
                hearing.MCourtType = Mapper.Map<MCourtTypeEntity, MCourtType>(hearingEntity.MCourtType);
                hearing.MDesignation = Mapper.Map<MDesignationEntity, MDesignation>(hearingEntity.MDesignation);
                hearing.MHRGBeforeTypeEstimatedHRGBeforeTypeCode = Mapper.Map<MHRGBeforeTypeEntity, MHRGBeforeType>(hearingEntity.MHRGBeforeTypeEstimatedHRGBeforeTypeCode);
                hearing.MHRGBeforeTypeHRGBeforeTypeCode = Mapper.Map<MHRGBeforeTypeEntity, MHRGBeforeType>(hearingEntity.MHRGBeforeType);
                hearing.MHRGOutCome = Mapper.Map<MHRGOutComeEntity, MHRGOutCome>(hearingEntity.MHRGOutCome);
                hearing.MCoram = Mapper.Map<MCoramEntity, MCoram>(hearingEntity.MCoram);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetHearing", ex);
                throw;
            }

            return hearing;
        }

        /// <summary>
        /// Gets the <see cref="HearingAdminSupportEntity"/> based on <see cref="HearingAdminSupport"/>.
        /// </summary>
        /// <param name="hearingAdminSupportEntity">The HearingAdminSupportEntity object.</param>
        /// <returns>Returns <see cref="HearingAdminSupport"/>, else null.</returns>
        public static HearingAdminSupport GetHearingAdminSupport(HearingAdminSupportEntity hearingAdminSupportEntity)
        {
            HearingAdminSupport hearingAdminSupport = null;

            try
            {
                hearingAdminSupport = Mapper.Map<HearingAdminSupportEntity, HearingAdminSupport>(hearingAdminSupportEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetHearingAdminSupport", ex);
                throw;
            }

            return hearingAdminSupport;
        }

        /// <summary>
        /// Maps the domain to entities.
        /// </summary>
        /// <param name="lawFirmCaseFileRefNumberEntity">Law Firm Case File Reference Number.</param>
        /// <returns>Returns the <see cref="LawFirmCaseFileRefNumber"/>, else null.</returns>
        public static LawFirmCaseFileRefNumber GetLawFirmCaseFileRefNumber(LawFirmCaseFileRefNumberEntity lawFirmCaseFileRefNumberEntity)
        {
            LawFirmCaseFileRefNumber lawFirmCaseFileRefNumber = null;

            try
            {
                lawFirmCaseFileRefNumber = Mapper.Map<LawFirmCaseFileRefNumberEntity, LawFirmCaseFileRefNumber>(lawFirmCaseFileRefNumberEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetLawFirmCaseFileRefNumber", ex);
                throw;
            }

            return lawFirmCaseFileRefNumber;
        }

        /// <summary>
        /// Maps the domain to entities.
        /// </summary>
        /// <param name="rCaseLawFirmEntity">Case Law Firm.</param>
        /// <returns>Returns the <see cref="RCaseLawFirm"/>, else null.</returns>
        public static RCaseLawFirm GetRCaseLawFirm(RCaseLawFirmEntity rCaseLawFirmEntity)
        {
            RCaseLawFirm rCaseLawFirm = null;

            try
            {
                rCaseLawFirm = Mapper.Map<RCaseLawFirmEntity, RCaseLawFirm>(rCaseLawFirmEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRCaseLawFirm", ex);
                throw;
            }

            return rCaseLawFirm;
        }

        /// <summary>
        /// Maps the entities to domain.
        /// </summary>
        /// <param name="RCaseLinked">The case info.</param>
        /// <returns>Returns the <see cref="RCaseLinkedEntity"/>, else null.</returns>
        public static RCaseLinked GetRCaseLinked(RCaseLinkedEntity rCaseLinkedEntity)
        {
            RCaseLinked rCaseLinked = null;

            try
            {
                rCaseLinked = Mapper.Map<RCaseLinkedEntity, RCaseLinked>(rCaseLinkedEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRCaseLinked", ex);
                throw;
            }

            return rCaseLinked;
        }

        /// <summary>
        /// Maps the domain to entities.
        /// </summary>
        /// <param name="rCaseSubmissionEntity">Case Submission.</param>
        /// <returns>Returns the <see cref="RCaseSubmission"/>, else null.</returns>
        public static RCaseSubmission GetRCaseSubmission(RCaseSubmissionEntity rCaseSubmissionEntity)
        {
            RCaseSubmission rCaseSubmission = null;

            try
            {
                rCaseSubmission = Mapper.Map<RCaseSubmissionEntity, RCaseSubmission>(rCaseSubmissionEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRCaseSubmission", ex);
                throw;
            }

            return rCaseSubmission;
        }

        /// <summary>
        /// Maps the entities to domain.
        /// </summary>
        /// <param name="RCaseLinked">The case info.</param>
        /// <returns>Returns the <see cref="RCaseLinkedEntity"/>, else null.</returns>
        public static RCaseTransfer GetRCaseTransfer(RCaseTransferEntity rCaseTransferEntity)
        {
            RCaseTransfer rCaseTransfer = null;

            try
            {
                rCaseTransfer = Mapper.Map<RCaseTransferEntity, RCaseTransfer>(rCaseTransferEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRCaseTransfer", ex);
                throw;
            }

            return rCaseTransfer;
        }

        /// <summary>
        /// Gets the <see cref="RLawFirmSolicitors"/> from <see cref="RLawFirmSolicitorsEntity"/> input.
        /// </summary>
        /// <param name="RLawFirmSolicitorsEntity"><see cref="RLawFirmSolicitorsEntity"/></param>
        /// <returns>Returns <see cref="RLawFirmSolicitors"/>, else null.</returns>
        public static RLawFirmSolicitors GetRLawFirmSolicitors(RLawFirmSolicitorsEntity rLawFirmSolicitorsEntity)
        {
            RLawFirmSolicitors rLawFirmSolicitors = null;

            try
            {
                if (rLawFirmSolicitorsEntity != null)
                {
                    rLawFirmSolicitors = Mapper.Map<RLawFirmSolicitorsEntity, RLawFirmSolicitors>(rLawFirmSolicitorsEntity);
                    rLawFirmSolicitors.MDesignation = Mapper.Map<MDesignationEntity, MDesignation>(rLawFirmSolicitorsEntity.MDesignation);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRLawFirmSolicitors", ex);
                throw;
            }

            return rLawFirmSolicitors;
        }

        /// <summary>
        /// Get Document Case Party Alias.
        /// </summary>
        /// <param name="cubCaseInfoNHibernateEntity"></param>
        /// <returns></returns>
        public static SubCaseInfo GetSubCaseInfo(SubCaseInfoEntity cubCaseInfoDomainEntity)
        {
            SubCaseInfo subCaseInfoNHibernateEntity = null;

            try
            {
                subCaseInfoNHibernateEntity = Mapper.Map<SubCaseInfoEntity, SubCaseInfo>(cubCaseInfoDomainEntity);
                subCaseInfoNHibernateEntity.MCaseStatus = Mapper.Map<MCaseStatusEntity, MCaseStatus>(cubCaseInfoDomainEntity.MCaseStatus);
                subCaseInfoNHibernateEntity.MCaseType = Mapper.Map<MCaseTypeEntity, MCaseType>(cubCaseInfoDomainEntity.MSubCaseType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSubCaseInfo", ex);
                throw;
            }

            return subCaseInfoNHibernateEntity;
        }

        /// <summary>
        /// Get Document Case Party Alias.
        /// </summary>
        /// <param name="cubCaseInfoNHibernateEntity"></param>
        /// <returns></returns>
        public static RCaseConsolidate GetRCaseConsolidate(RCaseConsolidateEntity rCaseConsolidateEntity)
        {
            RCaseConsolidate rCaseConsolidate = null;

            try
            {
                rCaseConsolidate = Mapper.Map<RCaseConsolidateEntity, RCaseConsolidate>(rCaseConsolidateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRCaseConsolidate", ex);
                throw;
            }

            return rCaseConsolidate;
        }

        /// <summary>
        /// Get Document Case Party Alias.
        /// </summary>
        /// <param name="cubCaseInfoNHibernateEntity"></param>
        /// <returns></returns>
        public static RCaseTransferHistory GetRCaseTransferHistory(RCaseTransferHistoryEntity rCaseTransferHistoryEntity)
        {
            RCaseTransferHistory rCaseTransferHistory = null;

            try
            {
                rCaseTransferHistory = Mapper.Map<RCaseTransferHistoryEntity, RCaseTransferHistory>(rCaseTransferHistoryEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRCaseTransferHistory", ex);
                throw;
            }

            return rCaseTransferHistory;
        }

        public static RLawFirmSolicitorHistory GetRLawFirmSolicitorHistory(RLawFirmSolicitorHistoryEntity rLawFirmSolicitorHistoryEntity)
        {
            RLawFirmSolicitorHistory rLawFirmSolicitorHistory = null;
            try
            {
                rLawFirmSolicitorHistory = Mapper.Map<RLawFirmSolicitorHistoryEntity, RLawFirmSolicitorHistory>(rLawFirmSolicitorHistoryEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRLawFirmSolicitorHistory", ex);
                throw;
            }

            return rLawFirmSolicitorHistory;
        }

        public static TransferOrderOfCourt GetTransferOrderOfCourt(TransferOrderOfCourtEntity transferOrderOfCourtEntity)
        {
            TransferOrderOfCourt transferOrderOfCourt = null;
            try
            {
                transferOrderOfCourt = Mapper.Map<TransferOrderOfCourtEntity, TransferOrderOfCourt>(transferOrderOfCourtEntity);
                transferOrderOfCourt.MDesignation = Mapper.Map<MDesignationEntity, MDesignation>(transferOrderOfCourtEntity.MDesignationEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetTransferOrderOfCourt", ex);
                throw;
            }

            return transferOrderOfCourt;
        }

        #endregion Methods

        /// <summary>
        /// Gets the party case file reference number.
        /// </summary>
        /// <param name="partyCaseFileRefNumberEntity">The party case file reference number entity.</param>
        /// <returns></returns>
        public static PartyCaseFileRefNumber GetPartyCaseFileRefNumber(PartyCaseFileRefNumberEntity partyCaseFileRefNumberEntity)
        {

            PartyCaseFileRefNumber partyCaseFileRefNumber = null;

            try
            {
                if (partyCaseFileRefNumberEntity != null)
                {
                    partyCaseFileRefNumber = Mapper.Map<PartyCaseFileRefNumberEntity, PartyCaseFileRefNumber>(partyCaseFileRefNumberEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPartyCaseFileRefNumber", ex);
                throw;
            }

            return partyCaseFileRefNumber;
        }
    }
}