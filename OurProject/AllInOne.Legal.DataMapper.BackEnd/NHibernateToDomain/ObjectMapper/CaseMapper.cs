#region Header

/*****************************************************************************************************
* Description : This file handles mapper for Case from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   23/09/2010   		      	Nai                	 	Created
*   12/02/2011                  Swaroop                 Updated for alinging with FE.
*****************************************************************************************************/
// <summary>
// File: CaseMapper.cs
// Description: This file handles mapper for Case from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "CaseMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Case from NHibernate entities to Domain objects.
    /// </summary>
    public class CaseMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CaseMapper));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method returns the <see cref="ICase"/> tagged entity from <see cref="ICaseEntity"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="ICaseEntity"/> type</typeparam>
        /// <param name="caseEntity"><see cref="ICaseEntity"/> object.</param>
        /// <returns>Returns the <see cref="ICaseEntity"/></returns>
        public static ICaseEntity GetCaseEntity<T>(T caseEntity)
        {
            try
            {
                if (caseEntity.GetType().Equals(typeof(CaseInfo)))
                    return (GetCaseInfoEntity(caseEntity as CaseInfo));

                else if (caseEntity.GetType().Equals(typeof(CaseInfoNumber)))
                    return (GetCaseInfoNumberEntity(caseEntity as CaseInfoNumber));

                else if (caseEntity.GetType().Equals(typeof(CaseOriginatingCase)))
                    return (GetCaseOriginatingCaseEntity(caseEntity as CaseOriginatingCase));

                else if (caseEntity.GetType().Equals(typeof(CasePartyAddress)))
                    return (GetCasePartyAddressEntity(caseEntity as CasePartyAddress));

                else if (caseEntity.GetType().Equals(typeof(CasePartyAICAddress)))
                    return (GetCasePartyAICAddressEntity(caseEntity as CasePartyAICAddress));

                else if (caseEntity.GetType().Equals(typeof(CasePartyAICAlias)))
                    return (GetCasePartyAICAliasEntity(caseEntity as CasePartyAICAlias));

                else if (caseEntity.GetType().Equals(typeof(CasePartyAICDetail)))
                    return (GetCasePartyAICDetailsEntity(caseEntity as CasePartyAICDetail));

                else if (caseEntity.GetType().Equals(typeof(CasePartyAlias)))
                    return (GetCasePartyAliasEntity(caseEntity as CasePartyAlias));

                else if (caseEntity.GetType().Equals(typeof(CasePartyAuthorisedOfficerDetail)))
                    return (GetCasePartyAuthorisedOfficerDetailEntity(caseEntity as CasePartyAuthorisedOfficerDetail));

                else if (caseEntity.GetType().Equals(typeof(CaseParty)))
                    return (GetCasePartyEntity(caseEntity as CaseParty));

                else if (caseEntity.GetType().Equals(typeof(CasePartyVesselDetail)))
                    return (GetCasePartyVesselDetailsEntity(caseEntity as CasePartyVesselDetail));

                else if (caseEntity.GetType().Equals(typeof(CaseSolicitorHistory)))
                    return (GetCaseSolicitorHistoryEntity(caseEntity as CaseSolicitorHistory));

                else if (caseEntity.GetType().Equals(typeof(CaseSolicitor)))
                    return (GetCaseSolicitorEntity(caseEntity as CaseSolicitor));

                else if (caseEntity.GetType().Equals(typeof(HearingAdminSupport)))
                    return (GetHearingAdminSupportEntity(caseEntity as HearingAdminSupport));

                else if (caseEntity.GetType().Equals(typeof(Hearing)))
                    return (GetHearingEntity(caseEntity as Hearing));

                else if (caseEntity.GetType().Equals(typeof(LawFirmCaseFileRefNumber)))
                    return (GetLawFirmCaseFileRefNumberEntity(caseEntity as LawFirmCaseFileRefNumber));

                else if (caseEntity.GetType().Equals(typeof(RCaseLawFirm)))
                    return (GetRCaseLawFirmEntity(caseEntity as RCaseLawFirm));

                else if (caseEntity.GetType().Equals(typeof(RCaseSubmission)))
                    return (GetRCaseSubmissionEntity(caseEntity as RCaseSubmission));

                else if (caseEntity.GetType().Equals(typeof(CasePartyLACDetail)))
                    return (GetCasePartyLACDetailEntity(caseEntity as CasePartyLACDetail));

                else if (caseEntity.GetType().Equals(typeof(CasePartyLACDetailsHistory)))
                    return (GetCasePartyLACDetailHistoryEntity(caseEntity as CasePartyLACDetailsHistory));

                else if (caseEntity.GetType().Equals(typeof(RCaseLinked)))
                    return (GetRCaseLinkedEntity(caseEntity as RCaseLinked));

                else if (caseEntity.GetType().Equals(typeof(RLawFirmSolicitors)))
                    return (GetRLawFirmSolicitorsEntity(caseEntity as RLawFirmSolicitors));

                else if (caseEntity.GetType().Equals(typeof(CasePartyBailorAddress)))
                    return GetCasePartyBailorAddressEntity(caseEntity as CasePartyBailorAddress);

                else if (caseEntity.GetType().Equals(typeof(CasePartyBailorInfo)))
                    return GetCasePartyBailorInfoEntity(caseEntity as CasePartyBailorInfo);

                else if (caseEntity.GetType().Equals(typeof(CasePartyCriminalInfo)))
                    return GetCasePartyCriminalInfoEntity(caseEntity as CasePartyCriminalInfo);

                else if (caseEntity.GetType().Equals(typeof(CaseIssueList)))
                    return GetCaseIssueListEntity(caseEntity as CaseIssueList);

                else if (caseEntity.GetType().Equals(typeof(RCaseConsolidate)))
                    return GetRCaseConsolidateEntity(caseEntity as RCaseConsolidate);

                else if (caseEntity.GetType().Equals(typeof(PartyCaseFileRefNumber)))
                    return GetPartyCaseFileRefNumberEntity(caseEntity as PartyCaseFileRefNumber);

                else
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetCaseEntity method in CaseMapper.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCaseEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the <see cref="CaseInfoEntity"/> from <see cref="CaseInfo"/> input.
        /// </summary>
        /// <param name="caseInfo"><see cref="CaseInfo"/></param>
        /// <returns>Returns <see cref="CaseInfoEntity"/>, else null.</returns>
        public static CaseInfoEntity GetCaseInfoEntity(CaseInfo caseInfo)
        {
            CaseInfoEntity caseInfoEntity = null;

            try
            {
                if (caseInfo != null)
                {
                    caseInfoEntity = Mapper.Map<CaseInfo, CaseInfoEntity>(caseInfo);
                    caseInfoEntity.CaseSecurity = Mapper.Map<MCaseSecurity, MCaseSecurityEntity>(caseInfo.MCaseSecurity);
                    caseInfoEntity.CaseStatus = Mapper.Map<MCaseStatus, MCaseStatusEntity>(caseInfo.MCaseStatus);
                    caseInfoEntity.CaseType = Mapper.Map<MCaseType, MCaseTypeEntity>(caseInfo.MCaseType);
                    caseInfoEntity.ForumType = Mapper.Map<MForumType, MForumTypeEntity>(caseInfo.MForumType);
                    caseInfoEntity.CaseOfficerAssignedSectionCode = Mapper.Map<MSection, MSectionEntity>(caseInfo.MSection);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCaseInfoEntity", ex);
                throw;
            }

            return caseInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CaseInfoNumberEntity"/> from <see cref="CaseInfoNumber"/> input.
        /// </summary>
        /// <param name="caseInfoNumber"><see cref="CaseInfoNumber"/></param>
        /// <returns>Returns <see cref="CaseInfoNumberEntity"/>, else null.</returns>
        public static CaseInfoNumberEntity GetCaseInfoNumberEntity(CaseInfoNumber caseInfoNumber)
        {
            CaseInfoNumberEntity caseInfoNumberEntity = null;

            try
            {
                if (caseInfoNumber != null)
                {
                    caseInfoNumberEntity = Mapper.Map<CaseInfoNumber, CaseInfoNumberEntity>(caseInfoNumber);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCaseInfoNumberEntity", ex);
                throw;
            }

            return caseInfoNumberEntity;
        }

        /// <summary>
        /// Gets the <see cref="CaseIssueListEntity"/> from <see cref="CaseIssueList"/> input.
        /// </summary>
        /// <param name="caseIssueList"><see cref="CaseIssueList"/></param>
        /// <returns>Returns <see cref="CaseIssueListEntity"/>, else null.</returns>
        public static CaseIssueListEntity GetCaseIssueListEntity(CaseIssueList caseIssueList)
        {
            CaseIssueListEntity caseIssueListEntity = null;

            try
            {
                if (caseIssueList != null)
                {
                    caseIssueListEntity = Mapper.Map<CaseIssueList, CaseIssueListEntity>(caseIssueList);
                    caseIssueListEntity.MCaseIssue = Mapper.Map<MCaseIssue, MCaseIssueEntity>(caseIssueList.MCaseIssue);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCaseIssueListEntity", ex);
                throw;
            }

            return caseIssueListEntity;
        }

        /// <summary>
        /// Gets the <see cref="CaseOriginatingCaseEntity"/> from <see cref="CaseOriginatingCase"/> input.
        /// </summary>
        /// <param name="CaseOriginatingCase"><see cref="CaseOriginatingCase"/></param>
        /// <returns>Returns <see cref="CaseOriginatingCaseEntity"/>, else null.</returns>
        public static CaseOriginatingCaseEntity GetCaseOriginatingCaseEntity(CaseOriginatingCase caseOriginatingCase)
        {
            CaseOriginatingCaseEntity caseOriginatingCaseEntity = null;

            try
            {
                caseOriginatingCaseEntity = Mapper.Map<CaseOriginatingCase, CaseOriginatingCaseEntity>(caseOriginatingCase);
                caseOriginatingCaseEntity.CourtId = Mapper.Map<MCourtType, MCourtTypeEntity>(caseOriginatingCase.MCourtType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCaseOriginatingCaseEntity", ex);
                throw;
            }

            return caseOriginatingCaseEntity;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyAddressEntity"/> from <see cref="CasePartyAddress"/> input.
        /// </summary>
        /// <param name="casePartyAddress"><see cref="CasePartyAddress"/></param>
        /// <returns>Returns <see cref="CasePartyAddressEntity"/>, else null.</returns>
        public static CasePartyAddressEntity GetCasePartyAddressEntity(CasePartyAddress casePartyAddress)
        {
            CasePartyAddressEntity casePartyAddressEntity = null;

            try
            {
                if (casePartyAddress != null)
                {
                    casePartyAddressEntity = Mapper.Map<CasePartyAddress, CasePartyAddressEntity>(casePartyAddress);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyAddressEntity", ex);
                throw;
            }

            return casePartyAddressEntity;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyAICAddressEntity"/> from <see cref="CasePartyAICAddress"/> input.
        /// </summary>
        /// <param name="casePartyAICAddress"><see cref="CasePartyAICAddress"/></param>
        /// <returns>Returns <see cref="CasePartyAICAddressEntity"/>, else null.</returns>
        public static CasePartyAICAddressEntity GetCasePartyAICAddressEntity(CasePartyAICAddress casePartyAICAddress)
        {
            CasePartyAICAddressEntity casePartyAICAddressEntity = null;

            try
            {
                if (casePartyAICAddress != null)
                {
                    casePartyAICAddressEntity = Mapper.Map<CasePartyAICAddress, CasePartyAICAddressEntity>(casePartyAICAddress);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyAICAddressEntity", ex);
                throw;
            }

            return casePartyAICAddressEntity;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyAICAliasEntity"/> from <see cref="CasePartyAICAlias"/> input.
        /// </summary>
        /// <param name="casePartyAICAlias"><see cref="CasePartyAICAlias"/></param>
        /// <returns>Returns <see cref="CasePartyAICAliasEntity"/>, else null.</returns>
        public static CasePartyAICAliasEntity GetCasePartyAICAliasEntity(CasePartyAICAlias casePartyAICAlias)
        {
            CasePartyAICAliasEntity casePartyAICAliasEntity = null;

            try
            {
                if (casePartyAICAlias != null)
                {
                    casePartyAICAliasEntity = Mapper.Map<CasePartyAICAlias, CasePartyAICAliasEntity>(casePartyAICAlias);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyAICAliasEntity", ex);
                throw;
            }

            return casePartyAICAliasEntity;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyAICDetailsEntity"/> from <see cref="CasePartyAICDetail"/> input.
        /// </summary>
        /// <param name="casePartyAICDetails"><see cref="CasePartyAICDetail"/></param>
        /// <returns>Returns <see cref="CasePartyAICDetailsEntity"/>, else null.</returns>
        public static CasePartyAICDetailsEntity GetCasePartyAICDetailsEntity(CasePartyAICDetail casePartyAICDetails)
        {
            CasePartyAICDetailsEntity casePartyAICDetailsEntity = null;

            try
            {
                if (casePartyAICDetails != null)
                {
                    casePartyAICDetailsEntity = Mapper.Map<CasePartyAICDetail, CasePartyAICDetailsEntity>(casePartyAICDetails);
                    casePartyAICDetailsEntity.MActingInCapacity = Mapper.Map<MActingInCapacity, MActingInCapacityEntity>(casePartyAICDetails.MActingInCapacity);
                    casePartyAICDetailsEntity.MCompanyIdTypeCode = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(casePartyAICDetails.MCPAICDCompanyIdTypeCode);
                    casePartyAICDetailsEntity.MCountryOfRegistration = Mapper.Map<MCountry, MCountryEntity>(casePartyAICDetails.MCPAICDCountryOfRegistration);
                    casePartyAICDetailsEntity.MEntityType = Mapper.Map<MEntityType, MEntityTypeEntity>(casePartyAICDetails.MEntityType);
                    casePartyAICDetailsEntity.MGender = Mapper.Map<MGender, MGenderEntity>(casePartyAICDetails.MGender);
                    casePartyAICDetailsEntity.MIdCountry = Mapper.Map<MCountry, MCountryEntity>(casePartyAICDetails.MCPAICDIdCountryCode);
                    casePartyAICDetailsEntity.MPersonIdGroup = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(casePartyAICDetails.MPersonIDGroup);
                    casePartyAICDetailsEntity.MPersonIdType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(casePartyAICDetails.MCPAICDPersonIdTypeCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyAICDetailsEntity", ex);
                throw;
            }

            return casePartyAICDetailsEntity;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyAliasEntity"/> from <see cref="CasePartyAlias"/> input.
        /// </summary>
        /// <param name="casePartyAlias"><see cref="CasePartyAlias"/></param>
        /// <returns>Returns <see cref="CasePartyAliasEntity"/>, else null.</returns>
        public static CasePartyAliasEntity GetCasePartyAliasEntity(CasePartyAlias casePartyAlias)
        {
            CasePartyAliasEntity casePartyAliasEntity = null;

            try
            {
                if (casePartyAlias != null)
                {
                    casePartyAliasEntity = Mapper.Map<CasePartyAlias, CasePartyAliasEntity>(casePartyAlias);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyAliasEntity", ex);
                throw;
            }

            return casePartyAliasEntity;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyAuthorisedOfficerDetailsEntity"/> from <see cref="CasePartyAuthorisedOfficerDetail"/> input.
        /// </summary>
        /// <param name="casePartyAuthorisedOfficerDetail"><see cref="CasePartyAuthorisedOfficerDetail"/></param>
        /// <returns>Returns <see cref="CasePartyAuthorisedOfficerDetailsEntity"/>, else null.</returns>
        public static CasePartyAuthorisedOfficerDetailsEntity GetCasePartyAuthorisedOfficerDetailEntity(CasePartyAuthorisedOfficerDetail casePartyAuthorisedOfficerDetail)
        {
            CasePartyAuthorisedOfficerDetailsEntity casePartyAuthorisedOfficerDetailEntity = null;

            try
            {
                if (casePartyAuthorisedOfficerDetail != null)
                {
                    casePartyAuthorisedOfficerDetailEntity = Mapper.Map<CasePartyAuthorisedOfficerDetail, CasePartyAuthorisedOfficerDetailsEntity>(casePartyAuthorisedOfficerDetail);
                    casePartyAuthorisedOfficerDetailEntity.MCountryEntity = Mapper.Map<MCountry, MCountryEntity>(casePartyAuthorisedOfficerDetail.MCountry);
                    casePartyAuthorisedOfficerDetailEntity.MPersonIDGroupEntity = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(casePartyAuthorisedOfficerDetail.MPersonIDGroup);
                    casePartyAuthorisedOfficerDetailEntity.MPersonIDTypeEntity = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(casePartyAuthorisedOfficerDetail.MPersonIDType);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CasePartyAuthorisedOfficerDetailsEntity", ex);
                throw;
            }

            return casePartyAuthorisedOfficerDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyBailorAddressEntity"/> from <see cref="CasePartyBailorAddress"/> input.
        /// </summary>
        /// <param name="casePartyBailorAddress"><see cref="CasePartyBailorAddress"/></param>
        /// <returns>Returns <see cref="CasePartyBailorAddressEntity"/>, else null.</returns>
        public static CasePartyBailorAddressEntity GetCasePartyBailorAddressEntity(CasePartyBailorAddress casePartyBailorAddress)
        {
            CasePartyBailorAddressEntity casePartyBailorAddressEntity = null;

            try
            {
                if (casePartyBailorAddress != null)
                {
                    casePartyBailorAddressEntity = Mapper.Map<CasePartyBailorAddress, CasePartyBailorAddressEntity>(casePartyBailorAddress);
                    casePartyBailorAddressEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(casePartyBailorAddress.MCountry);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyBailorAddressEntity", ex);
                throw;
            }

            return casePartyBailorAddressEntity;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyBailorInfoEntity"/> from <see cref="CasePartyBailorInfo"/> input.
        /// </summary>
        /// <param name="casePartyBailorInfo"><see cref="CasePartyBailorInfo"/></param>
        /// <returns>Returns <see cref="CasePartyBailorInfoEntity"/>, else null.</returns>
        public static CasePartyBailorInfoEntity GetCasePartyBailorInfoEntity(CasePartyBailorInfo casePartyBailorInfo)
        {
            CasePartyBailorInfoEntity casePartyBailorInfoEntity = null;
            try
            {
                if (casePartyBailorInfo != null)
                {
                    casePartyBailorInfoEntity = Mapper.Map<CasePartyBailorInfo, CasePartyBailorInfoEntity>(casePartyBailorInfo);
                    casePartyBailorInfoEntity.MIDType = Mapper.Map<MIDType, MIDTypeEntity>(casePartyBailorInfo.MIDType);
                    casePartyBailorInfoEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(casePartyBailorInfo.MCountry);
                    casePartyBailorInfoEntity.MBailType = Mapper.Map<MBailType, MBailTypeEntity>(casePartyBailorInfo.MBailType);
                    casePartyBailorInfoEntity.IDGroupCode = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(casePartyBailorInfo.IDGroupCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyBailorInfoEntity", ex);
                throw;
            }

            return casePartyBailorInfoEntity;
        }

        /** End of For Criminal Entities **/
        /// <summary>
        /// Gets the <see cref="CasePartyCitizenshipEntity"/> from <see cref="CasePartyCitizenship"/> input.
        /// </summary>
        /// <param name="casePartyCitizenship"><see cref="CasePartyCitizenship"/></param>
        /// <returns>Returns <see cref="CasePartyCitizenshipEntity"/>, else null.</returns>
        public static CasePartyCitizenshipEntity GetCasePartyCitizenshipEntity(CasePartyCitizenship casePartyCitizenship)
        {
            CasePartyCitizenshipEntity casePartyCitizenshipEntity = null;

            try
            {
                if (casePartyCitizenship != null)
                {
                    casePartyCitizenshipEntity = Mapper.Map<CasePartyCitizenship, CasePartyCitizenshipEntity>(casePartyCitizenship);
                    casePartyCitizenshipEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(casePartyCitizenship.MCountry);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyCitizenshipEntity", ex);
                throw;
            }

            return casePartyCitizenshipEntity;
        }

        /** For Criminal Entities **/
        /// <summary>
        /// Gets the <see cref="CasePartyCriminalInfo"/> from <see cref="CasePartyCriminalInfoEntity"/> input.
        /// </summary>
        /// <param name="casePartyCriminalInfoEntity"><see cref="CasePartyCriminalInfoEntity"/></param>
        /// <returns>Returns <see cref="CasePartyCriminalInfo"/>, else null.</returns>
        public static CasePartyCriminalInfoEntity GetCasePartyCriminalInfoEntity(CasePartyCriminalInfo casePartyCriminalInfo)
        {
            CasePartyCriminalInfoEntity casePartyCriminalInfoEntity = null;

            try
            {
                if (casePartyCriminalInfo != null)
                {
                    casePartyCriminalInfoEntity = Mapper.Map<CasePartyCriminalInfo, CasePartyCriminalInfoEntity>(casePartyCriminalInfo);
                    casePartyCriminalInfoEntity.MPrisonCustody = Mapper.Map<MPrison, MPrisonEntity>(casePartyCriminalInfo.MPrisonCustodyPrisonCode);
                    casePartyCriminalInfoEntity.MPrisonRemand = Mapper.Map<MPrison, MPrisonEntity>(casePartyCriminalInfo.MPrisonRemandPrisonCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyCriminalInfoEntity", ex);
                throw;
            }

            return casePartyCriminalInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyEntity"/> from <see cref="CaseParty"/> input.
        /// </summary>
        /// <param name="caseParty"><see cref="CaseParty"/></param>
        /// <returns>Returns <see cref="CasePartyEntity"/>, else null.</returns>
        public static CasePartyEntity GetCasePartyEntity(CaseParty caseParty)
        {
            CasePartyEntity casePartyEntity = null;

            try
            {
                if (caseParty != null)
                {
                    casePartyEntity = Mapper.Map<CaseParty, CasePartyEntity>(caseParty);
                    casePartyEntity.MApplicantCapacity = Mapper.Map<MApplicantCapacity, MApplicantCapacityEntity>(caseParty.MApplicantCapacity);
                    casePartyEntity.MBirthCountry = Mapper.Map<MCountry, MCountryEntity>(caseParty.MCPBirthCountry);
                    casePartyEntity.MCompanyIdType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(caseParty.MCPCompanyIdType);
                    casePartyEntity.MCountryOfRegistration = Mapper.Map<MCountry, MCountryEntity>(caseParty.MCPCountryOfRegistration);
                    casePartyEntity.MDialect = Mapper.Map<MDialect, MDialectEntity>(caseParty.MDialect);
                    casePartyEntity.MEntityType = Mapper.Map<MEntityType, MEntityTypeEntity>(caseParty.MEntityType);
                    casePartyEntity.MGender = Mapper.Map<MGender, MGenderEntity>(caseParty.MGender);
                    casePartyEntity.MIdCountry = Mapper.Map<MCountry, MCountryEntity>(caseParty.MCPIdCountry);
                    casePartyEntity.MMaritalStatus = Mapper.Map<MMaritalStatus, MMaritalStatusEntity>(caseParty.MMaritalStatus);
                    casePartyEntity.MMarriageCountry = Mapper.Map<MCountry, MCountryEntity>(caseParty.MCPMarriageCountry);
                    casePartyEntity.MNationality = Mapper.Map<MNationality, MNationalityEntity>(caseParty.MNationality);
                    casePartyEntity.MOccupation = Mapper.Map<MOccupation, MOccupationEntity>(caseParty.MOccupation);
                    casePartyEntity.MPartyStatus = Mapper.Map<MPartyStatus, MPartyStatusEntity>(caseParty.MPartyStatus);
                    casePartyEntity.MPartyType = Mapper.Map<MPartyType, MPartyTypeEntity>(caseParty.MPartyType);
                    casePartyEntity.MPersonIdGroup = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(caseParty.MPersonIDGroup);
                    casePartyEntity.MPersonIdType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(caseParty.MCPPersonIdType);
                    casePartyEntity.MQualification = Mapper.Map<MQualification, MQualificationEntity>(caseParty.MQualification);
                    casePartyEntity.MRace = Mapper.Map<MRace, MRaceEntity>(caseParty.MRace);
                    casePartyEntity.MRelationship = Mapper.Map<MRelationship, MRelationshipEntity>(caseParty.MRelationship);
                    casePartyEntity.MReligion = Mapper.Map<MReligion, MReligionEntity>(caseParty.MReligion);
                    casePartyEntity.CounterClaimPartyTypeCode = Mapper.Map<MPartyType, MPartyTypeEntity>(caseParty.CounterClaimPartyTypeCode);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyEntity", ex);
                throw;
            }

            return casePartyEntity;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyLACDetailEntity"/> from <see cref="CasePartyLACDetail"/> input.
        /// </summary>
        /// <param name="casePartyLACDetail"><see cref="CasePartyLACDetail"/></param>
        /// <returns>Returns <see cref="CasePartyLACDetailEntity"/>, else null.</returns>
        public static CasePartyLACDetailEntity GetCasePartyLACDetailEntity(CasePartyLACDetail casePartyLACDetail)
        {
            CasePartyLACDetailEntity casePartyLACDetailEntity = null;

            try
            {
                if (casePartyLACDetail != null)
                {
                    casePartyLACDetailEntity = Mapper.Map<CasePartyLACDetail, CasePartyLACDetailEntity>(casePartyLACDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyLACDetailEntity", ex);
                throw;
            }

            return casePartyLACDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyLACDetailHistoryEntity"/> from <see cref="CasePartyLACDetailsHistory"/> input.
        /// </summary>
        /// <param name="casePartyLACDetailsHistory"><see cref="CasePartyLACDetailsHistory"/></param>
        /// <returns>Returns <see cref="CasePartyLACDetailHistoryEntity"/>, else null.</returns>
        public static CasePartyLACDetailHistoryEntity GetCasePartyLACDetailHistoryEntity(CasePartyLACDetailsHistory casePartyLACDetailsHistory)
        {
            CasePartyLACDetailHistoryEntity casePartyLACDetailHistoryEntity = null;

            try
            {
                if (casePartyLACDetailsHistory != null)
                {
                    casePartyLACDetailHistoryEntity = Mapper.Map<CasePartyLACDetailsHistory, CasePartyLACDetailHistoryEntity>(casePartyLACDetailsHistory);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCasePartyLACDetailHistoryEntity", ex);
                throw;
            }

            return casePartyLACDetailHistoryEntity;
        }

        public static CasePartyStatusHistoryEntity GetCasePartyStatusHistory(CasePartyStatusHistory casePartyStatusHistory)
        {
            CasePartyStatusHistoryEntity casePartyStatusHistoryEntity = null;
            try
            {
                if (casePartyStatusHistory != null)
                {
                    casePartyStatusHistoryEntity = Mapper.Map<CasePartyStatusHistory, CasePartyStatusHistoryEntity>(casePartyStatusHistory);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCasePartyStatusHistory", ex);
                throw;
            }
            return casePartyStatusHistoryEntity;
        }

        /// <summary>
        /// Gets the <see cref="CasePartyVesselDetailsEntity"/> from <see cref="CasePartyVesselDetail"/> input.
        /// </summary>
        /// <param name="casePartyVesselDetail"><see cref="CasePartyVesselDetail"/></param>
        /// <returns>Returns <see cref="CasePartyVesselDetailsEntity"/>, else null.</returns>
        public static CasePartyVesselDetailsEntity GetCasePartyVesselDetailsEntity(CasePartyVesselDetail casePartyVesselDetail)
        {
            CasePartyVesselDetailsEntity casePartyVesselDetailEntity = null;

            try
            {
                if (casePartyVesselDetail != null)
                {
                    casePartyVesselDetailEntity = Mapper.Map<CasePartyVesselDetail, CasePartyVesselDetailsEntity>(casePartyVesselDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBankruptcyInfoEntity", ex);
                throw;
            }

            return casePartyVesselDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="CaseSolicitorEntity"/> from <see cref="CaseSolicitor"/> input.
        /// </summary>
        /// <param name="caseSolicitor"><see cref="CaseSolicitor"/></param>
        /// <returns>Returns <see cref="CaseSolicitorEntity"/>, else null.</returns>
        public static CaseSolicitorEntity GetCaseSolicitorEntity(CaseSolicitor caseSolicitor)
        {
            CaseSolicitorEntity caseSolicitorEntity = null;

            try
            {
                if (caseSolicitor != null)
                {
                    caseSolicitorEntity = Mapper.Map<CaseSolicitor, CaseSolicitorEntity>(caseSolicitor);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCaseSolicitorEntity", ex);
                throw;
            }

            return caseSolicitorEntity;
        }

        /// <summary>
        /// Gets the <see cref="CaseSolicitorHistoryEntity"/> from <see cref="CaseSolicitorHistory"/> input.
        /// </summary>
        /// <param name="caseSolicitorHistory"><see cref="CaseSolicitorHistory"/></param>
        /// <returns>Returns <see cref="CaseSolicitorHistoryEntity"/>, else null.</returns>
        public static CaseSolicitorHistoryEntity GetCaseSolicitorHistoryEntity(CaseSolicitorHistory caseSolicitorHistory)
        {
            CaseSolicitorHistoryEntity caseSolicitorHistoryEntity = null;

            try
            {
                if (caseSolicitorHistory != null)
                {
                    caseSolicitorHistoryEntity = Mapper.Map<CaseSolicitorHistory, CaseSolicitorHistoryEntity>(caseSolicitorHistory);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCaseSolicitorHistoryEntity", ex);
                throw;
            }

            return caseSolicitorHistoryEntity;
        }

        /// <summary>
        /// Gets the <see cref="HearingAdminSupportEntity"/> from <see cref="HearingAdminSupport"/> input.
        /// </summary>
        /// <param name="hearingAdminSupport"><see cref="HearingAdminSupport"/></param>
        /// <returns>Returns <see cref="HearingAdminSupportEntity"/>, else null.</returns>
        public static HearingAdminSupportEntity GetHearingAdminSupportEntity(HearingAdminSupport hearingAdminSupport)
        {
            HearingAdminSupportEntity hearingAdminSupportEntity = null;

            try
            {
                if (hearingAdminSupport != null)
                {
                    hearingAdminSupportEntity = Mapper.Map<HearingAdminSupport, HearingAdminSupportEntity>(hearingAdminSupport);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetHearingAdminSupportEntity", ex);
                throw;
            }

            return hearingAdminSupportEntity;
        }

        /// <summary>
        /// Gets the <see cref="HearingEntity"/> from <see cref="Hearing"/> input.
        /// </summary>
        /// <param name="hearing"><see cref="Hearing"/></param>
        /// <returns>Returns <see cref="HearingEntity"/>, else null.</returns>
        public static HearingEntity GetHearingEntity(Hearing hearing)
        {
            HearingEntity hearingEntity = null;

            try
            {
                if (hearing != null)
                {
                    hearingEntity = Mapper.Map<Hearing, HearingEntity>(hearing);
                    hearingEntity.MCourtType = Mapper.Map<MCourtType, MCourtTypeEntity>(hearing.MCourtType);
                    hearingEntity.MDesignation = Mapper.Map<MDesignation, MDesignationEntity>(hearing.MDesignation);
                    hearingEntity.MHRGBeforeTypeEstimatedHRGBeforeTypeCode = Mapper.Map<MHRGBeforeType, MHRGBeforeTypeEntity>(hearing.MHRGBeforeTypeEstimatedHRGBeforeTypeCode);
                    hearingEntity.MHRGBeforeType = Mapper.Map<MHRGBeforeType, MHRGBeforeTypeEntity>(hearing.MHRGBeforeTypeHRGBeforeTypeCode);
                    hearingEntity.MHRGOutCome = Mapper.Map<MHRGOutCome, MHRGOutComeEntity>(hearing.MHRGOutCome);
                    hearingEntity.MCoram = Mapper.Map<MCoram, MCoramEntity>(hearing.MCoram);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetHearingEntity", ex);
                throw;
            }

            return hearingEntity;
        }

        public static HearingCoramEntity GetHearingCoramEntity(HearingCoram hearingCoram)
        {
            HearingCoramEntity hearingCoramEntity = null;
            try
            {
                if (hearingCoram != null)
                {
                    hearingCoramEntity = Mapper.Map<HearingCoram, HearingCoramEntity>(hearingCoram);
                    hearingCoramEntity.MDesignationEntity = Mapper.Map<MDesignation, MDesignationEntity>(hearingCoram.MDesignation);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetHearingCoramEntity", ex);
                throw;
            }
            return hearingCoramEntity;
        }

        /// <summary>
        /// Gets the <see cref="LawFirmCaseFileRefNumber"/> from <see cref="LawFirmCaseFileRefNumberEntity"/> input.
        /// </summary>
        /// <param name="lawFirmCaseFileRefNumber"><see cref="LawFirmCaseFileRefNumberEntity"/></param>
        /// <returns>Returns <see cref="LawFirmCaseFileRefNumber"/>, else null.</returns>
        public static LawFirmCaseFileRefNumberEntity GetLawFirmCaseFileRefNumberEntity(LawFirmCaseFileRefNumber lawFirmCaseFileRefNumber)
        {
            LawFirmCaseFileRefNumberEntity lawFirmCaseFileRefNumberEntity = null;

            try
            {
                if (lawFirmCaseFileRefNumber != null)
                {
                    lawFirmCaseFileRefNumberEntity = Mapper.Map<LawFirmCaseFileRefNumber, LawFirmCaseFileRefNumberEntity>(lawFirmCaseFileRefNumber);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLawFirmCaseFileRefNumberEntity", ex);
                throw;
            }

            return lawFirmCaseFileRefNumberEntity;
        }

        /// <summary>
        /// Gets the <see cref="RCaseLawFirmEntity"/> from <see cref="RCaseLawFirm"/> input.
        /// </summary>
        /// <param name="rCaseLawFirm"><see cref="RCaseLawFirm"/></param>
        /// <returns>Returns <see cref="RCaseLawFirmEntity"/>, else null.</returns>
        public static RCaseLawFirmEntity GetRCaseLawFirmEntity(RCaseLawFirm rCaseLawFirm)
        {
            RCaseLawFirmEntity rCaseLawFirmEntity = null;

            try
            {
                if (rCaseLawFirm != null)
                {
                    rCaseLawFirmEntity = Mapper.Map<RCaseLawFirm, RCaseLawFirmEntity>(rCaseLawFirm);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRCaseLawFirmEntity", ex);
                throw;
            }

            return rCaseLawFirmEntity;
        }

        /// <summary>
        /// Gets the <see cref="RCaseLinkedEntity"/> from <see cref="RCaseLinked"/> input.
        /// </summary>
        /// <param name="rCaseLinked"><see cref="RCaseLinked"/></param>
        /// <returns>Returns <see cref="RCaseLinkedEntity"/>, else null.</returns>
        public static RCaseLinkedEntity GetRCaseLinkedEntity(RCaseLinked rCaseLinked)
        {
            RCaseLinkedEntity rCaseLinkedEntity = null;

            try
            {
                if (rCaseLinked != null)
                {
                    rCaseLinkedEntity = Mapper.Map<RCaseLinked, RCaseLinkedEntity>(rCaseLinked);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRCaseLinkedEntity", ex);
                throw;
            }

            return rCaseLinkedEntity;
        }

        /// <summary>
        /// Gets the <see cref="RCaseSubmissionEntity"/> from <see cref="RCaseSubmission"/> input.
        /// </summary>
        /// <param name="rCaseSubmission"><see cref="RCaseSubmission"/></param>
        /// <returns>Returns <see cref="RCaseSubmissionEntity"/>, else null.</returns>
        public static RCaseSubmissionEntity GetRCaseSubmissionEntity(RCaseSubmission rCaseSubmission)
        {
            RCaseSubmissionEntity rCaseSubmissionEntity = null;

            try
            {
                if (rCaseSubmission != null)
                {
                    rCaseSubmissionEntity = Mapper.Map<RCaseSubmission, RCaseSubmissionEntity>(rCaseSubmission);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRCaseSubmissionEntity", ex);
                throw;
            }

            return rCaseSubmissionEntity;
        }

        /// <summary>
        /// Gets the <see cref="RCaseTransferEntity"/> from <see cref="RCaseTransfer"/> input.
        /// </summary>
        /// <param name="rCaseTransfer"><see cref="RCaseTransfer"/></param>
        /// <returns>Returns <see cref="RCaseTransferEntity"/>, else null.</returns>
        public static RCaseTransferEntity GetRCaseTransferEntity(RCaseTransfer rCaseTransfer)
        {
            RCaseTransferEntity rCaseTransferEntity = null;

            try
            {
                if (rCaseTransfer != null)
                {
                    rCaseTransferEntity = Mapper.Map<RCaseTransfer, RCaseTransferEntity>(rCaseTransfer);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRCaseTransferEntity", ex);
                throw;
            }

            return rCaseTransferEntity;
        }

        /// <summary>
        /// Gets the <see cref="RLawFirmSolicitorsEntity"/> from <see cref="RLawFirmSolicitors"/> input.
        /// </summary>
        /// <param name="rLawFirmSolicitors"><see cref="RLawFirmSolicitors"/></param>
        /// <returns>Returns <see cref="RLawFirmSolicitorsEntity"/>, else null.</returns>
        public static RLawFirmSolicitorsEntity GetRLawFirmSolicitorsEntity(RLawFirmSolicitors rLawFirmSolicitors)
        {
            RLawFirmSolicitorsEntity rLawFirmSolicitorsEntity = null;

            try
            {
                if (rLawFirmSolicitors != null)
                {
                    rLawFirmSolicitorsEntity = Mapper.Map<RLawFirmSolicitors, RLawFirmSolicitorsEntity>(rLawFirmSolicitors);
                    rLawFirmSolicitorsEntity.MDesignation = Mapper.Map<MDesignation, MDesignationEntity>(rLawFirmSolicitors.MDesignation);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRLawFirmSolicitorsEntity", ex);
                throw;
            }

            return rLawFirmSolicitorsEntity;
        }

        /// <summary>
        /// Gets the <see cref="RLawFirmSolicitorsEntity"/> from <see cref="RLawFirmSolicitors"/> input.
        /// </summary>
        /// <param name="rLawFirmSolicitors"><see cref="RLawFirmSolicitors"/></param>
        /// <returns>Returns <see cref="RLawFirmSolicitorsEntity"/>, else null.</returns>
        public static RCaseConsolidateEntity GetRCaseConsolidateEntity(RCaseConsolidate rCaseConsolidate)
        {
            RCaseConsolidateEntity rCaseConsolidateEntity = null;

            try
            {
                if (rCaseConsolidate != null)
                {
                    rCaseConsolidateEntity = Mapper.Map<RCaseConsolidate, RCaseConsolidateEntity>(rCaseConsolidate);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRCaseConsolidateEntity", ex);
                throw;
            }

            return rCaseConsolidateEntity;
        }

        public static InterimCasePartyStatusEntity GetInterimCasePartyStatusEntity(InterimCasePartyStatus interimCasePartyStatus)
        {
            InterimCasePartyStatusEntity interimCasePartyStatusEntity = null;
            try
            {
                if (interimCasePartyStatus != null)
                {
                    interimCasePartyStatusEntity = Mapper.Map<InterimCasePartyStatus, InterimCasePartyStatusEntity>(interimCasePartyStatus);
                    interimCasePartyStatusEntity.PartyStatusCode = Mapper.Map<MPartyStatus, MPartyStatusEntity>(interimCasePartyStatus.PartyStatusCode);
                    interimCasePartyStatusEntity.CounterClaimPartyStatusCode = Mapper.Map<MPartyStatus, MPartyStatusEntity>(interimCasePartyStatus.CounterClaimPartyStatusCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetInterimCasePartyStatusEntity", ex);
                throw;
            }
            return interimCasePartyStatusEntity;
        }

        /// <summary>
        /// Gets the bankruptcy debt info entity.
        /// </summary>
        /// <param name="hearingOutcomeFlag">The hearing outcome flag.</param>
        /// <returns></returns>
        public static HearingOutcomeFlagEntity GetHearingOutcomeFlagEntity(HearingOutcomeFlag hearingOutcomeFlag)
        {
            HearingOutcomeFlagEntity hearingOutcomeFlagEntity = null;

            try
            {
                if (hearingOutcomeFlag != null)
                {
                    hearingOutcomeFlagEntity = Mapper.Map<HearingOutcomeFlag, HearingOutcomeFlagEntity>(hearingOutcomeFlag);
                    hearingOutcomeFlagEntity.MHRGOutComeFlagEntity = Mapper.Map<MHRGOutComeFlag, MHRGOutComeFlagEntity>(hearingOutcomeFlag.MHRGOutComeFlag);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }

            return hearingOutcomeFlagEntity;
        }

        public static TransferOrderOfCourtEntity GetTransferOrderOfCourtEntity(TransferOrderOfCourt transferOrderOfCourt)
        {
            TransferOrderOfCourtEntity transferOrderOfCourtEntity = null;

            try
            {
                if (transferOrderOfCourt != null)
                {
                    transferOrderOfCourtEntity = Mapper.Map<TransferOrderOfCourt, TransferOrderOfCourtEntity>(transferOrderOfCourt);
                    transferOrderOfCourtEntity.MDesignationEntity = Mapper.Map<MDesignation, MDesignationEntity>(transferOrderOfCourt.MDesignation);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetTransferOrderOfCourtEntity", ex);
                throw;
            }

            return transferOrderOfCourtEntity;
        }
        #endregion Methods


        /// <summary>
        /// Gets the party case file reference number entity.
        /// </summary>
        /// <param name="partyCaseFileRefNumber">The party case file reference number.</param>
        /// <returns></returns>
        public static PartyCaseFileRefNumberEntity GetPartyCaseFileRefNumberEntity(PartyCaseFileRefNumber partyCaseFileRefNumber)
        {
            PartyCaseFileRefNumberEntity partyCaseFileRefNumberEntity = null;
            try
            {
                if (partyCaseFileRefNumber != null)
                {
                    partyCaseFileRefNumberEntity = Mapper.Map<PartyCaseFileRefNumber, PartyCaseFileRefNumberEntity>(partyCaseFileRefNumber);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPartyCaseFileRefNumberEntity", ex);
                throw;
            }

            return partyCaseFileRefNumberEntity;
        }
    }
}