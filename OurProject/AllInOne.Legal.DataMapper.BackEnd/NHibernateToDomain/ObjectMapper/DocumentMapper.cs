#region Header

/*****************************************************************************************************
* Description : This file handles mapper for Document from NHibernate entities to Domain objects.
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
// File: DocumentMapper.cs
// Description: This file handles mapper for Document from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "DocumentMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Document from NHibernate entities to Domain objects.
    /// </summary>
    public class DocumentMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DocumentMapper));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the <see cref="CaseLatestDocumentsEntity"/> from <see cref="CaseLatestDocuments"/> input.
        /// </summary>
        /// <param name="caseLatestDocuments"><see cref="CaseLatestDocuments"/></param>
        /// <returns>Returns <see cref="CaseLatestDocumentsEntity"/>, else null.</returns>
        public static CaseLatestDocumentsEntity GetCaseLatestDocumentsEntity(CaseLatestDocuments caseLatestDocuments)
        {
            CaseLatestDocumentsEntity caseLatestDocumentsEntity = null;

            try
            {
                if (caseLatestDocuments != null)
                {
                    caseLatestDocumentsEntity = Mapper.Map<CaseLatestDocuments, CaseLatestDocumentsEntity>(caseLatestDocuments);
                    caseLatestDocumentsEntity.MDocCode = Mapper.Map<MDocCode, MDocCodeEntity>(caseLatestDocuments.MDocCode);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCaseLatestDocumentsEntity", ex);
                throw;
            }

            return caseLatestDocumentsEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyAddressEntity"/> from <see cref="DocCasePartyAddress"/> input.
        /// </summary>
        /// <param name="docCasePartyAddress"><see cref="DocCasePartyAddress"/></param>
        /// <returns>Returns <see cref="DocCasePartyAddressEntity"/>, else null.</returns>
        public static DocCasePartyAddressEntity GetDocCasePartyAddressEntity(DocCasePartyAddress docCasePartyAddress)
        {
            DocCasePartyAddressEntity docCasePartyAddressEntity = null;

            try
            {
                if (docCasePartyAddress != null)
                {
                    docCasePartyAddressEntity = Mapper.Map<DocCasePartyAddress, DocCasePartyAddressEntity>(docCasePartyAddress);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyAddressEntity", ex);
                throw;
            }

            return docCasePartyAddressEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyAICAddressEntity"/> from <see cref="DocCasePartyAICAddress"/> input.
        /// </summary>
        /// <param name="docCasePartyAICAddress"><see cref="DocCasePartyAICAddress"/></param>
        /// <returns>Returns <see cref="DocCasePartyAICAddressEntity"/>, else null.</returns>
        public static DocCasePartyAICAddressEntity GetDocCasePartyAICAddressEntity(DocCasePartyAICAddress docCasePartyAICAddress)
        {
            DocCasePartyAICAddressEntity docCasePartyAICAddressEntity = null;

            try
            {
                if (docCasePartyAICAddress != null)
                {
                    docCasePartyAICAddressEntity = Mapper.Map<DocCasePartyAICAddress, DocCasePartyAICAddressEntity>(docCasePartyAICAddress);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyAICAddressEntity", ex);
                throw;
            }

            return docCasePartyAICAddressEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyAICAliasEntity"/> from <see cref="DocCasePartyAICAlias"/> input.
        /// </summary>
        /// <param name="docCasePartyAICAlias"><see cref="DocCasePartyAICAlias"/></param>
        /// <returns>Returns <see cref="DocCasePartyAICAliasEntity"/>, else null.</returns>
        public static DocCasePartyAICAliasEntity GetDocCasePartyAICAliasEntity(DocCasePartyAICAlias docCasePartyAICAlias)
        {
            DocCasePartyAICAliasEntity docCasePartyAICAliasEntity = null;

            try
            {
                if (docCasePartyAICAlias != null)
                {
                    docCasePartyAICAliasEntity = Mapper.Map<DocCasePartyAICAlias, DocCasePartyAICAliasEntity>(docCasePartyAICAlias);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyAICAliasEntity", ex);
                throw;
            }

            return docCasePartyAICAliasEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyAICDetailsEntity"/> from <see cref="DocCasePartyAICDetail"/> input.
        /// </summary>
        /// <param name="docCasePartyAICDetail"><see cref="DocCasePartyAICDetail"/></param>
        /// <returns>Returns <see cref="DocCasePartyAICDetailsEntity"/>, else null.</returns>
        public static DocCasePartyAICDetailsEntity GetDocCasePartyAICDetailEntity(DocCasePartyAICDetail docCasePartyAICDetail)
        {
            DocCasePartyAICDetailsEntity docCasePartyAICDetailEntity = null;

            try
            {
                if (docCasePartyAICDetail != null)
                {
                    docCasePartyAICDetailEntity = Mapper.Map<DocCasePartyAICDetail, DocCasePartyAICDetailsEntity>(docCasePartyAICDetail);
                    docCasePartyAICDetailEntity.MActingInCapacity = Mapper.Map<MActingInCapacity, MActingInCapacityEntity>(docCasePartyAICDetail.MActingInCapacity);
                    docCasePartyAICDetailEntity.MCompanyIdTypeCode = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(docCasePartyAICDetail.MDCPAICDCompanyIdTypeCode);
                    docCasePartyAICDetailEntity.MCountryOfRegistration = Mapper.Map<MCountry, MCountryEntity>(docCasePartyAICDetail.MDCPAICDCountryOfRegistration);
                    docCasePartyAICDetailEntity.MEntityType = Mapper.Map<MEntityType, MEntityTypeEntity>(docCasePartyAICDetail.MEntityType);
                    docCasePartyAICDetailEntity.MGender = Mapper.Map<MGender, MGenderEntity>(docCasePartyAICDetail.MGender);
                    docCasePartyAICDetailEntity.MIdCountry = Mapper.Map<MCountry, MCountryEntity>(docCasePartyAICDetail.MDCPAICDIdCountryCode);
                    docCasePartyAICDetailEntity.MPersonIdGroup = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(docCasePartyAICDetail.MPersonIDGroup);
                    docCasePartyAICDetailEntity.MPersonIdType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(docCasePartyAICDetail.MDCPAICDPersonIdTypeCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyAICDetailEntity", ex);
                throw;
            }

            return docCasePartyAICDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyAliasEntity"/> from <see cref="DocCasePartyAlias"/> input.
        /// </summary>
        /// <param name="docCasePartyAlias"><see cref="DocCasePartyAlias"/></param>
        /// <returns>Returns <see cref="DocCasePartyAliasEntity"/>, else null.</returns>
        public static DocCasePartyAliasEntity GetDocCasePartyAliasEntity(DocCasePartyAlias docCasePartyAlias)
        {
            DocCasePartyAliasEntity docCasePartyAliasEntity = null;

            try
            {
                if (docCasePartyAlias != null)
                {
                    docCasePartyAliasEntity = Mapper.Map<DocCasePartyAlias, DocCasePartyAliasEntity>(docCasePartyAlias);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyAliasEntity", ex);
                throw;
            }

            return docCasePartyAliasEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyAuthorisedOfficerDetailsEntity"/> from <see cref="DocCasePartyAuthorisedOfficerDetail"/> input.
        /// </summary>
        /// <param name="docCasePartyOfficerDetail"><see cref="DocCasePartyAuthorisedOfficerDetail"/></param>
        /// <returns>Returns <see cref="DocCasePartyAuthorisedOfficerDetailsEntity"/>, else null.</returns>
        public static DocCasePartyAuthorisedOfficerDetailsEntity GetDocCasePartyAuthorisedOfficerDetailEntity(DocCasePartyAuthorisedOfficerDetail docCasePartyOfficerDetail)
        {
            DocCasePartyAuthorisedOfficerDetailsEntity docCasePartyAuthorisedOfficerDetailsEntity = null;

            try
            {
                if (docCasePartyOfficerDetail != null)
                {
                    docCasePartyAuthorisedOfficerDetailsEntity = Mapper.Map<DocCasePartyAuthorisedOfficerDetail, DocCasePartyAuthorisedOfficerDetailsEntity>(docCasePartyOfficerDetail);
                    docCasePartyAuthorisedOfficerDetailsEntity.MCountryEntity = Mapper.Map<MCountry, MCountryEntity>(docCasePartyOfficerDetail.MCountry);
                    docCasePartyAuthorisedOfficerDetailsEntity.MPersonIDGroupEntity = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(docCasePartyOfficerDetail.MPersonIDGroup);
                    docCasePartyAuthorisedOfficerDetailsEntity.MPersonIDTypeEntity = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(docCasePartyOfficerDetail.MPersonIDType);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyAuthorisedOfficerDetailEntity", ex);
                throw;
            }

            return docCasePartyAuthorisedOfficerDetailsEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyBailorAddressEntity"/> from <see cref="DocCasePartyBailorAddress"/> input.
        /// </summary>
        /// <param name="docCasePartyBailorAddress"><see cref="DocCasePartyBailorAddress"/></param>
        /// <returns>Returns <see cref="DocCasePartyBailorAddressEntity"/>, else null.</returns>
        public static DocCasePartyBailorAddressEntity GetDocCasePartyBailorAddressEntity(DocCasePartyBailorAddress docCasePartyBailorAddress)
        {
            DocCasePartyBailorAddressEntity docCasePartyBailorAddressEntity = null;

            try
            {
                if (docCasePartyBailorAddress != null)
                {
                    docCasePartyBailorAddressEntity = Mapper.Map<DocCasePartyBailorAddress, DocCasePartyBailorAddressEntity>(docCasePartyBailorAddress);
                    docCasePartyBailorAddressEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(docCasePartyBailorAddress.MCountry);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyBailorAddressEntity", ex);
                throw;
            }

            return docCasePartyBailorAddressEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyBailorInfoEntity"/> from <see cref="DocCasePartyBailorInfo"/> input.
        /// </summary>
        /// <param name="docCasePartyBailorInfo"><see cref="DocCasePartyBailorInfo"/></param>
        /// <returns>Returns <see cref="DocCasePartyBailorInfoEntity"/>, else null.</returns>
        public static DocCasePartyBailorInfoEntity GetDocCasePartyBailorInfoEntity(DocCasePartyBailorInfo docCasePartyBailorInfo)
        {
            DocCasePartyBailorInfoEntity docCasePartyBailorInfoEntity = null;

            try
            {
                if (docCasePartyBailorInfo != null)
                {
                    docCasePartyBailorInfoEntity = Mapper.Map<DocCasePartyBailorInfo, DocCasePartyBailorInfoEntity>(docCasePartyBailorInfo);
                    docCasePartyBailorInfoEntity.MIDType = Mapper.Map<MIDType, MIDTypeEntity>(docCasePartyBailorInfo.MIDType);
                    docCasePartyBailorInfoEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(docCasePartyBailorInfo.MCountry);
                    docCasePartyBailorInfoEntity.MBailType = Mapper.Map<MBailType, MBailTypeEntity>(docCasePartyBailorInfo.MBailType);
                    docCasePartyBailorInfoEntity.IDGroupCode = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(docCasePartyBailorInfo.IDGroupCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyBailorInfoEntity", ex);
                throw;
            }

            return docCasePartyBailorInfoEntity;
        }

        /** End of For Criminal Entities **/
        /// <summary>
        /// Gets the <see cref="DocCasePartyCitizenshipEntity"/> from <see cref="DocCasePartyCitizenship"/> input.
        /// </summary>
        /// <param name="docCasePartyCitizenship"><see cref="DocCasePartyCitizenship"/></param>
        /// <returns>Returns <see cref="DocCasePartyCitizenshipEntity"/>, else null.</returns>
        public static DocCasePartyCitizenshipEntity GetDocCasePartyCitizenshipEntity(DocCasePartyCitizenship docCasePartyCitizenship)
        {
            DocCasePartyCitizenshipEntity docCasePartyCitizenshipEntity = null;

            try
            {
                if (docCasePartyCitizenship != null)
                {
                    docCasePartyCitizenshipEntity = Mapper.Map<DocCasePartyCitizenship, DocCasePartyCitizenshipEntity>(docCasePartyCitizenship);
                    docCasePartyCitizenshipEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(docCasePartyCitizenship.MCountry);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyCitizenshipEntity", ex);
                throw;
            }

            return docCasePartyCitizenshipEntity;
        }

        /** For Criminal Entities **/
        /// <summary>
        /// Gets the <see cref="DocCasePartyCriminalInfo"/> from <see cref="DocCasePartyCriminalInfoEntity"/> input.
        /// </summary>
        /// <param name="docCasePartyCriminalInfoEntity"><see cref="DocCasePartyCriminalInfoEntity"/></param>
        /// <returns>Returns <see cref="DocCasePartyCriminalInfo"/>, else null.</returns>
        public static DocCasePartyCriminalInfoEntity GetDocCasePartyCriminalInfoEntity(DocCasePartyCriminalInfo docCasePartyCriminalInfo)
        {
            DocCasePartyCriminalInfoEntity docCasePartyCriminalInfoEntity = null;

            try
            {
                if (docCasePartyCriminalInfo != null)
                {
                    docCasePartyCriminalInfoEntity = Mapper.Map<DocCasePartyCriminalInfo, DocCasePartyCriminalInfoEntity>(docCasePartyCriminalInfo);
                    docCasePartyCriminalInfoEntity.MPrisonCustody = Mapper.Map<MPrison, MPrisonEntity>(docCasePartyCriminalInfo.MPrisonCustodyPrisonCode);
                    docCasePartyCriminalInfoEntity.MPrisonRemand = Mapper.Map<MPrison, MPrisonEntity>(docCasePartyCriminalInfo.MPrisonRemandPrisonCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyCriminalInfoEntity", ex);
                throw;
            }

            return docCasePartyCriminalInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyEntity"/> from <see cref="DocCaseParty"/> input.
        /// </summary>
        /// <param name="docCaseParty"><see cref="DocCaseParty"/></param>
        /// <returns>Returns <see cref="DocCasePartyEntity"/>, else null.</returns>
        public static DocCasePartyEntity GetDocCasePartyEntity(DocCaseParty docCaseParty)
        {
            DocCasePartyEntity docCasePartyEntity = null;

            try
            {
                if (docCaseParty != null)
                {
                    docCasePartyEntity = Mapper.Map<DocCaseParty, DocCasePartyEntity>(docCaseParty);
                    docCasePartyEntity.MApplicantCapacity = Mapper.Map<MApplicantCapacity, MApplicantCapacityEntity>(docCaseParty.MApplicantCapacity);
                    docCasePartyEntity.MBirthCountry = Mapper.Map<MCountry, MCountryEntity>(docCaseParty.MDCPBirthCountry);
                    docCasePartyEntity.MCompanyIdType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(docCaseParty.MDCPCompanyIdType);
                    docCasePartyEntity.MCountryOfRegistration = Mapper.Map<MCountry, MCountryEntity>(docCaseParty.MDCPCountryOfRegistration);
                    docCasePartyEntity.MDialect = Mapper.Map<MDialect, MDialectEntity>(docCaseParty.MDialect);
                    docCasePartyEntity.MEntityType = Mapper.Map<MEntityType, MEntityTypeEntity>(docCaseParty.MEntityType);
                    docCasePartyEntity.MGender = Mapper.Map<MGender, MGenderEntity>(docCaseParty.MGender);
                    docCasePartyEntity.MIdCountry = Mapper.Map<MCountry, MCountryEntity>(docCaseParty.MDCPIdCountry);
                    docCasePartyEntity.MMaritalStatus = Mapper.Map<MMaritalStatus, MMaritalStatusEntity>(docCaseParty.MMaritalStatus);
                    docCasePartyEntity.MMarriageCountry = Mapper.Map<MCountry, MCountryEntity>(docCaseParty.MDCPMarriageCountry);
                    docCasePartyEntity.MNationality = Mapper.Map<MNationality, MNationalityEntity>(docCaseParty.MNationality);
                    docCasePartyEntity.MOccupation = Mapper.Map<MOccupation, MOccupationEntity>(docCaseParty.MOccupation);
                    docCasePartyEntity.MPartyType = Mapper.Map<MPartyType, MPartyTypeEntity>(docCaseParty.MCasePartyTypeCode);
                    docCasePartyEntity.MPersonIdGroup = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(docCaseParty.MPersonIDGroup);
                    docCasePartyEntity.MPersonIdType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(docCaseParty.MDCPPersonIdType);
                    docCasePartyEntity.MQualification = Mapper.Map<MQualification, MQualificationEntity>(docCaseParty.MQualification);
                    docCasePartyEntity.MRace = Mapper.Map<MRace, MRaceEntity>(docCaseParty.MRace);
                    docCasePartyEntity.MRelationship = Mapper.Map<MRelationship, MRelationshipEntity>(docCaseParty.MRelationship);
                    docCasePartyEntity.MReligion = Mapper.Map<MReligion, MReligionEntity>(docCaseParty.MReligion);
                    docCasePartyEntity.MSubCasePartyType = Mapper.Map<MPartyType, MPartyTypeEntity>(docCaseParty.MSubCasePartyTypeCode);
                    docCasePartyEntity.CounterClaimPartyTypeCode = Mapper.Map<MPartyType, MPartyTypeEntity>(docCaseParty.CounterClaimPartyTypeCode);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyEntity", ex);
                throw;
            }

            return docCasePartyEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyLACDetail"/> from <see cref="DocCasePartyLACDetailEntity"/> input.
        /// </summary>
        /// <param name="docCasePartyLACDetailEntity"><see cref="DocCasePartyLACDetailEntity"/></param>
        /// <returns>Returns <see cref="DocCasePartyLACDetail"/>, else null.</returns>
        public static DocCasePartyLACDetailEntity GetDocCasePartyLACDetailEntity(DocCasePartyLACDetail docCasePartyLACDetail)
        {
            DocCasePartyLACDetailEntity docCasePartyLACDetailEntity = null;

            try
            {
                if (docCasePartyLACDetail != null)
                {
                    docCasePartyLACDetailEntity = Mapper.Map<DocCasePartyLACDetail, DocCasePartyLACDetailEntity>(docCasePartyLACDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyLACDetailEntity", ex);
                throw;
            }

            return docCasePartyLACDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyVesselDetailsEntity"/> from <see cref="DocCasePartyVesselDetail"/> input.
        /// </summary>
        /// <param name="docCasePartyVesselDetail"><see cref="DocCasePartyVesselDetail"/></param>
        /// <returns>Returns <see cref="DocCasePartyVesselDetailsEntity"/>, else null.</returns>
        public static DocCasePartyVesselDetailsEntity GetDocCasePartyVesselDetailsEntity(DocCasePartyVesselDetail docCasePartyVesselDetail)
        {
            DocCasePartyVesselDetailsEntity docCasePartyVesselDetailsEntity = null;

            try
            {
                if (docCasePartyVesselDetail != null)
                {
                    docCasePartyVesselDetailsEntity = Mapper.Map<DocCasePartyVesselDetail, DocCasePartyVesselDetailsEntity>(docCasePartyVesselDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyVesselDetailsEntity", ex);
                throw;
            }

            return docCasePartyVesselDetailsEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCaseSolicitorEntity"/> from <see cref="DocCaseSolicitor"/> input.
        /// </summary>
        /// <param name="docCaseSolicitor"><see cref="DocCaseSolicitor"/></param>
        /// <returns>Returns <see cref="DocCaseSolicitorEntity"/>, else null.</returns>
        public static DocCaseSolicitorEntity GetDocCaseSolicitorEntity(DocCaseSolicitor docCaseSolicitor)
        {
            DocCaseSolicitorEntity docCaseSolicitorEntity = null;

            try
            {
                if (docCaseSolicitor != null)
                {
                    docCaseSolicitorEntity = Mapper.Map<DocCaseSolicitor, DocCaseSolicitorEntity>(docCaseSolicitor);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCaseSolicitorEntity", ex);
                throw;
            }

            return docCaseSolicitorEntity;
        }

        public static DocGCRDetailsEntity GetDocGCRDetailsEntity(DocGCRDetails docGCRDetails)
        {
            DocGCRDetailsEntity docGCRDetailsEntity = null;

            try
            {
                docGCRDetailsEntity = Mapper.Map<DocGCRDetails, DocGCRDetailsEntity>(docGCRDetails);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocGCRDetailsEntity", ex);
                throw;
            }

            return docGCRDetailsEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocOrderDetailsEntity"/> from <see cref="DocOrderDetail"/> input.
        /// </summary>
        /// <param name="docOrderDetail"><see cref="DocOrderDetail"/></param>
        /// <returns>Returns <see cref="DocOrderDetailsEntity"/>, else null.</returns>
        public static DocOrderDetailsEntity GetDocOrderDetailsEntity(DocOrderDetail docOrderDetail)
        {
            DocOrderDetailsEntity dOCOrderDetailsEntity = null;

            try
            {
                if (docOrderDetail != null)
                {
                    dOCOrderDetailsEntity = Mapper.Map<DocOrderDetail, DocOrderDetailsEntity>(docOrderDetail);
                    dOCOrderDetailsEntity.MDesignation = Mapper.Map<MDesignation, MDesignationEntity>(docOrderDetail.MDesignation);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocOrderDetailsEntity", ex);
                throw;
            }

            return dOCOrderDetailsEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocRequestDetail"/> from <see cref="DocRequestDetailsEntity"/> input.
        /// </summary>
        /// <param name="docRequestDetailsEntity"><see cref="DocRequestDetailsEntity"/></param>
        /// <returns>Returns <see cref="DocRequestDetail"/>, else null.</returns>
        public static DocRequestDetailsEntity GetDocRequestDetails(DocRequestDetail docRequestDetail)
        {
            DocRequestDetailsEntity docRequestDetailsEntity = null;
            try
            {
                if (docRequestDetail != null)
                {
                    docRequestDetailsEntity = Mapper.Map<DocRequestDetail, DocRequestDetailsEntity>(docRequestDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocRequestDetails", ex);
                throw;
            }
            return docRequestDetailsEntity;
        }

        /// <summary>
        /// Method returns the <see cref="IDocumentEntity"/> tagged entity from <see cref="IDocumentEntity"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="IDocumentEntity"/> type</typeparam>
        /// <param name="documentEntity"><see cref="IDocumentEntity"/> object.</param>
        /// <returns>Returns the <see cref="ISubCaseSpecific"/></returns>
        public static IDocumentEntity GetDocumentEntity<T>(T documentEntity)
        {
            try
            {
                if (documentEntity.GetType().Equals(typeof(DocCasePartyAddress)))
                    return (GetDocCasePartyAddressEntity(documentEntity as DocCasePartyAddress));

                else if (documentEntity.GetType().Equals(typeof(DocCasePartyAICAddress)))
                    return (GetDocCasePartyAICAddressEntity(documentEntity as DocCasePartyAICAddress));

                else if (documentEntity.GetType().Equals(typeof(DocCasePartyAICAlias)))
                    return (GetDocCasePartyAICAliasEntity(documentEntity as DocCasePartyAICAlias));

                else if (documentEntity.GetType().Equals(typeof(DocCasePartyAICDetail)))
                    return (GetDocCasePartyAICDetailEntity(documentEntity as DocCasePartyAICDetail));

                else if (documentEntity.GetType().Equals(typeof(DocCasePartyAlias)))
                    return (GetDocCasePartyAliasEntity(documentEntity as DocCasePartyAlias));

                else if (documentEntity.GetType().Equals(typeof(DocCasePartyAuthorisedOfficerDetail)))
                    return (GetDocCasePartyAuthorisedOfficerDetailEntity(documentEntity as DocCasePartyAuthorisedOfficerDetail));

                else if (documentEntity.GetType().Equals(typeof(DocCaseParty)))
                    return (GetDocCasePartyEntity(documentEntity as DocCaseParty));

                else if (documentEntity.GetType().Equals(typeof(DocCasePartyVesselDetail)))
                    return (GetDocCasePartyVesselDetailsEntity(documentEntity as DocCasePartyVesselDetail));

                else if (documentEntity.GetType().Equals(typeof(DocCaseSolicitor)))
                    return (GetDocCaseSolicitorEntity(documentEntity as DocCaseSolicitor));

                else if (documentEntity.GetType().Equals(typeof(DocOrderDetail)))
                    return (GetDocOrderDetailsEntity(documentEntity as DocOrderDetail));

                else if (documentEntity.GetType().Equals(typeof(DocumentInfo)))
                    return (GetDocumentInfoEntity(documentEntity as DocumentInfo));

                else if (documentEntity.GetType().Equals(typeof(RDocCaseParty)))
                    return (GetRDocCasePartyEntity(documentEntity as RDocCaseParty));

                else if (documentEntity.GetType().Equals(typeof(RDocCase)))
                    return (GetRDocCaseEntity(documentEntity as RDocCase));

                else if (documentEntity.GetType().Equals(typeof(DocGCRDetails)))
                    return (GetDocGCRDetailsEntity(documentEntity as DocGCRDetails));

                else if (documentEntity.GetType().Equals(typeof(DocCasePartyLACDetail)))
                    return (GetDocCasePartyLACDetailEntity(documentEntity as DocCasePartyLACDetail));

                else if (documentEntity.GetType().Equals(typeof(DocCasePartyBailorAddress)))
                    return GetDocCasePartyBailorAddressEntity(documentEntity as DocCasePartyBailorAddress);

                else if (documentEntity.GetType().Equals(typeof(DocCasePartyBailorInfo)))
                    return GetDocCasePartyBailorInfoEntity(documentEntity as DocCasePartyBailorInfo);

                else if (documentEntity.GetType().Equals(typeof(DocCasePartyCriminalInfo)))
                    return GetDocCasePartyCriminalInfoEntity(documentEntity as DocCasePartyCriminalInfo);

                else if (documentEntity.GetType().Equals(typeof(LawFirmDocCaseFileRefNumber)))
                    return GetLawFirmDocCaseFileRefNumberEntity(documentEntity as LawFirmDocCaseFileRefNumber);

                else if (documentEntity.GetType().Equals(typeof(DocPartyCaseFileRefNumber)))
                    return GetDocPartyCaseFileRefNumberEntity(documentEntity as DocPartyCaseFileRefNumber);

                else if (documentEntity.GetType().Equals(typeof(RDocCounterClaimFiled)))
                    return GetRDocCounterClaimFiledEntity(documentEntity as RDocCounterClaimFiled);

                else
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetDocumentEntity method in DocumentMapper.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocumentEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the <see cref="DocumentInfoEntity"/> from <see cref="DocumentInfo"/> input.
        /// </summary>
        /// <param name="documentInfo"><see cref="DocumentInfo"/></param>
        /// <returns>Returns <see cref="DocumentInfoEntity"/>, else null.</returns>
        public static DocumentInfoEntity GetDocumentInfoEntity(DocumentInfo documentInfo)
        {
            DocumentInfoEntity documentInfoEntity = null;

            try
            {
                if (documentInfo != null)
                {
                    documentInfoEntity = Mapper.Map<DocumentInfo, DocumentInfoEntity>(documentInfo);
                    documentInfoEntity.MCurrency = Mapper.Map<MCurrency, MCurrencyEntity>(documentInfo.MCurrency);
                    documentInfoEntity.MDocCode = Mapper.Map<MDocCode, MDocCodeEntity>(documentInfo.MDocCode);
                    documentInfoEntity.MDocNature = Mapper.Map<MDocNature, MDocNatureEntity>(documentInfo.MDocNature);
                    documentInfoEntity.MDocSecurity = Mapper.Map<MDocSecurity, MDocSecurityEntity>(documentInfo.MDocSecurity);
                    documentInfoEntity.MDocStatus = Mapper.Map<MDocStatus, MDocStatusEntity>(documentInfo.MDocStatus);
                    documentInfoEntity.MForumType = Mapper.Map<MForumType, MForumTypeEntity>(documentInfo.MForumType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocumentInfoEntity", ex);
                throw;
            }

            return documentInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocumentInfoEntity"/> from <see cref="DocumentInfo"/> input.
        /// </summary>
        /// <param name="documentInfo"><see cref="DocumentInfo"/></param>
        /// <returns>Returns <see cref="DocumentInfoEntity"/>, else null.</returns>
        public static DocumentInfoEntity GetDocumentInfoEntity(DocumentInfoSP documentInfo)
        {
            DocumentInfoEntity documentInfoEntity = null;

            try
            {
                if (documentInfo != null)
                {
                    documentInfoEntity = Mapper.Map<DocumentInfoSP, DocumentInfoEntity>(documentInfo);
                   
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocumentInfoEntity", ex);
                throw;
            }

            return documentInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="RDocCaseEntity"/> from <see cref="RDocCase"/> input.
        /// </summary>
        /// <param name="rDOCCase"><see cref="RDocCase"/></param>
        /// <returns>Returns <see cref="RDocCaseEntity"/>, else null.</returns>
        public static RDocCaseEntity GetRDocCaseEntity(RDocCase rDOCCase)
        {
            RDocCaseEntity rDocCaseEntity = null;

            try
            {
                if (rDOCCase != null)
                {
                    rDocCaseEntity = Mapper.Map<RDocCase, RDocCaseEntity>(rDOCCase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRDocCaseEntity", ex);
                throw;
            }

            return rDocCaseEntity;
        }

        /// <summary>
        /// Gets the <see cref="RDocCasePartyEntity"/> from <see cref="RDocCaseParty"/> input.
        /// </summary>
        /// <param name="rDocCaseParty"><see cref="RDocCaseParty"/></param>
        /// <returns>Returns <see cref="RDocCasePartyEntity"/>, else null.</returns>
        public static RDocCasePartyEntity GetRDocCasePartyEntity(RDocCaseParty rDocCaseParty)
        {
            RDocCasePartyEntity rDocCasePartyEntity = null;

            try
            {
                if (rDocCaseParty != null)
                {
                    rDocCasePartyEntity = Mapper.Map<RDocCaseParty, RDocCasePartyEntity>(rDocCaseParty);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRDocCasePartyEntity", ex);
                throw;
            }

            return rDocCasePartyEntity;
        }

        public static DocCommentsEntity GetDocCommentsEntity(DocComments docComments)
        {
            DocCommentsEntity docCommentsEntity = null;

            try
            {
                docCommentsEntity = Mapper.Map<DocComments, DocCommentsEntity>(docComments);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCommentsEntity", ex);
                throw;
            }

            return docCommentsEntity;
        }

        public static DocCaseTierTypeEntity GetDocCaseTierTypeEntity(DocCaseTierType docCaseTierType)
        {
            DocCaseTierTypeEntity docCaseTierTypeEntity = null;

            try
            {
                docCaseTierTypeEntity = Mapper.Map<DocCaseTierType, DocCaseTierTypeEntity>(docCaseTierType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCaseTierTypeEntity", ex);
                throw;
            }

            return docCaseTierTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="LawFirmDocCaseFileRefNumber"/> from <see cref="LawFirmDocCaseFileRefNumberEntity"/> input.
        /// </summary>
        /// <param name="lawFirmDocCaseFileRefNumber"><see cref="LawFirmDocCaseFileRefNumberEntity"/></param>
        /// <returns>Returns <see cref="LawFirmDocCaseFileRefNumberEntity"/>, else null.</returns>
        public static LawFirmDocCaseFileRefNumberEntity GetLawFirmDocCaseFileRefNumberEntity(LawFirmDocCaseFileRefNumber lawFirmDocCaseFileRefNumber)
        {
            LawFirmDocCaseFileRefNumberEntity lawFirmDocCaseFileRefNumberEntity = null;

            try
            {
                if (lawFirmDocCaseFileRefNumber != null)
                {
                    lawFirmDocCaseFileRefNumberEntity = Mapper.Map<LawFirmDocCaseFileRefNumber, LawFirmDocCaseFileRefNumberEntity>(lawFirmDocCaseFileRefNumber);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLawFirmDocCaseFileRefNumberEntity", ex);
                throw;
            }

            return lawFirmDocCaseFileRefNumberEntity;
        }

        /// <summary>
        /// Gets the document party case file reference number entity.
        /// </summary>
        /// <param name="docPartyCaseFileRefNumber">The document party case file reference number.</param>
        /// <returns></returns>
        public static DocPartyCaseFileRefNumberEntity GetDocPartyCaseFileRefNumberEntity(DocPartyCaseFileRefNumber docPartyCaseFileRefNumber)
        {
            DocPartyCaseFileRefNumberEntity docPartyCaseFileRefNumberEntity = null;

            try
            {
                if (docPartyCaseFileRefNumber != null)
                {
                    docPartyCaseFileRefNumberEntity = Mapper.Map<DocPartyCaseFileRefNumber, DocPartyCaseFileRefNumberEntity>(docPartyCaseFileRefNumber);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocPartyCaseFileRefNumberEntity", ex);
                throw;
            }

            return docPartyCaseFileRefNumberEntity;
        }

        public static Temp_ProcessingInfoEntity GetTemp_ProcessingInfoEntity(Temp_ProcessingInfo temp_ProcessingInfo)
        {
            Temp_ProcessingInfoEntity temp_ProcessingInfoEntity = null;

            try
            {
                if (temp_ProcessingInfo != null)
                {
                    temp_ProcessingInfoEntity = Mapper.Map<Temp_ProcessingInfo, Temp_ProcessingInfoEntity>(temp_ProcessingInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetTemp_ProcessingInfoEntity", ex);
                throw;
            }

            return temp_ProcessingInfoEntity;
        }

        public static RDocCounterClaimFiledEntity GetRDocCounterClaimFiledEntity(RDocCounterClaimFiled rDocCounterClaimFiled)
        {
            RDocCounterClaimFiledEntity rDocCounterClaimFiledEntity = null;

            try
            {
                if (rDocCounterClaimFiled != null)
                {
                    rDocCounterClaimFiledEntity = Mapper.Map<RDocCounterClaimFiled, RDocCounterClaimFiledEntity>(rDocCounterClaimFiled);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRDocCounterClaimFiledEntity", ex);
                throw;
            }

            return rDocCounterClaimFiledEntity;
        }

        #endregion Methods
        
    }
}