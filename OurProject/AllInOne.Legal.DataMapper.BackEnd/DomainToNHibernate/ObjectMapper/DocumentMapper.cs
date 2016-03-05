#region Header

/*****************************************************************************************************
* Description : This file represents a object mapper Document entities. This class will map Object to
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
// File: DocumentMapper.cs
// Description: This file represents a object mapper Document entities. This class will map Object to
// Entity.
// </summary>
// <copyright file= "DocumentMapper.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    public class DocumentMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DocumentMapper));

        private static DocumentMapping documentMapping = new DocumentMapping();

        #endregion Fields

        #region Methods

        /// <summary>
        /// Get Document Case Party.
        /// </summary>
        /// <param name="docCasePartyDomainEntity"></param>
        /// <returns></returns>
        public static DocCaseParty GetDocCaseParty(DocCasePartyEntity docCasePartyDomainEntity)
        {
            DocCaseParty docCasePartyNHibernateEntity = null;

            try
            {
                docCasePartyNHibernateEntity = Mapper.Map<DocCasePartyEntity, DocCaseParty>(docCasePartyDomainEntity);
                docCasePartyNHibernateEntity.MApplicantCapacity = Mapper.Map<MApplicantCapacityEntity, MApplicantCapacity>(docCasePartyDomainEntity.MApplicantCapacity);
                docCasePartyNHibernateEntity.MDCPBirthCountry = Mapper.Map<MCountryEntity, MCountry>(docCasePartyDomainEntity.MBirthCountry);
                docCasePartyNHibernateEntity.MDCPCompanyIdType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(docCasePartyDomainEntity.MCompanyIdType);
                docCasePartyNHibernateEntity.MDCPCountryOfRegistration = Mapper.Map<MCountryEntity, MCountry>(docCasePartyDomainEntity.MCountryOfRegistration);
                docCasePartyNHibernateEntity.MDCPIdCountry = Mapper.Map<MCountryEntity, MCountry>(docCasePartyDomainEntity.MIdCountry);
                docCasePartyNHibernateEntity.MDCPMarriageCountry = Mapper.Map<MCountryEntity, MCountry>(docCasePartyDomainEntity.MMarriageCountry);
                docCasePartyNHibernateEntity.MDCPPersonIdType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(docCasePartyDomainEntity.MPersonIdType);
                docCasePartyNHibernateEntity.MDialect = Mapper.Map<MDialectEntity, MDialect>(docCasePartyDomainEntity.MDialect);
                docCasePartyNHibernateEntity.MEntityType = Mapper.Map<MEntityTypeEntity, MEntityType>(docCasePartyDomainEntity.MEntityType);
                docCasePartyNHibernateEntity.MGender = Mapper.Map<MGenderEntity, MGender>(docCasePartyDomainEntity.MGender);
                docCasePartyNHibernateEntity.MMaritalStatus = Mapper.Map<MMaritalStatusEntity, MMaritalStatus>(docCasePartyDomainEntity.MMaritalStatus);
                docCasePartyNHibernateEntity.MNationality = Mapper.Map<MNationalityEntity, MNationality>(docCasePartyDomainEntity.MNationality);
                docCasePartyNHibernateEntity.MOccupation = Mapper.Map<MOccupationEntity, MOccupation>(docCasePartyDomainEntity.MOccupation);
                docCasePartyNHibernateEntity.MCasePartyTypeCode = Mapper.Map<MPartyTypeEntity, MPartyType>(docCasePartyDomainEntity.MPartyType);
                docCasePartyNHibernateEntity.MPersonIDGroup = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(docCasePartyDomainEntity.MPersonIdGroup);
                docCasePartyNHibernateEntity.MQualification = Mapper.Map<MQualificationEntity, MQualification>(docCasePartyDomainEntity.MQualification);
                docCasePartyNHibernateEntity.MRace = Mapper.Map<MRaceEntity, MRace>(docCasePartyDomainEntity.MRace);
                docCasePartyNHibernateEntity.MReligion = Mapper.Map<MReligionEntity, MReligion>(docCasePartyDomainEntity.MReligion);
                docCasePartyNHibernateEntity.CounterClaimPartyTypeCode = Mapper.Map<MPartyTypeEntity, MPartyType>(docCasePartyDomainEntity.CounterClaimPartyTypeCode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCaseParty", ex);
                throw;
            }

            return docCasePartyNHibernateEntity;
        }

        /// <summary>
        /// Get Document Case Party Address.
        /// </summary>
        /// <param name="docCasePartyAddressEntity"></param>
        /// <returns></returns>
        public static DocCasePartyAddress GetDocCasePartyAddress(DocCasePartyAddressEntity docCasePartyAddressDomainEntity)
        {
            DocCasePartyAddress docCasePartyAddressNHibernateEntity = null;

            try
            {
                docCasePartyAddressNHibernateEntity = Mapper.Map<DocCasePartyAddressEntity, DocCasePartyAddress>(docCasePartyAddressDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCasePartyAddress", ex);
                throw;
            }

            return docCasePartyAddressNHibernateEntity;
        }

        /// <summary>
        /// Get Document Case Party AIC Address.
        /// </summary>
        /// <param name="docCasePartyAICAddressDomainEntity"></param>
        /// <returns></returns>
        public static DocCasePartyAICAddress GetDocCasePartyAICAddress(DocCasePartyAICAddressEntity docCasePartyAICAddressDomainEntity)
        {
            DocCasePartyAICAddress docCasePartyAICAddressNHibernateEntity = null;

            try
            {
                docCasePartyAICAddressNHibernateEntity = Mapper.Map<DocCasePartyAICAddressEntity, DocCasePartyAICAddress>(docCasePartyAICAddressDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCasePartyAICAddress", ex);
                throw;
            }

            return docCasePartyAICAddressNHibernateEntity;
        }

        /// <summary>
        /// Get Document Case Party AIC Alias.
        /// </summary>
        /// <param name="docCasePartyAICAliasDomainEntity"></param>
        /// <returns></returns>
        public static DocCasePartyAICAlias GetDocCasePartyAICAlias(DocCasePartyAICAliasEntity docCasePartyAICAliasDomainEntity)
        {
            DocCasePartyAICAlias docCasePartyAICAliasNHibernateEntity = null;

            try
            {
                docCasePartyAICAliasNHibernateEntity = Mapper.Map<DocCasePartyAICAliasEntity, DocCasePartyAICAlias>(docCasePartyAICAliasDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCasePartyAICAlias", ex);
                throw;
            }

            return docCasePartyAICAliasNHibernateEntity;
        }

        /// <summary>
        /// Get Document Case Party AIC Detail.
        /// </summary>
        /// <param name="docCasePartyAICDetailDomainEntity"></param>
        /// <returns></returns>
        public static DocCasePartyAICDetail GetDocCasePartyAICDetail(DocCasePartyAICDetailsEntity docCasePartyAICDetailDomainEntity)
        {
            DocCasePartyAICDetail docCasePartyAICDetailNHibernateEntity = null;

            try
            {
                docCasePartyAICDetailNHibernateEntity = Mapper.Map<DocCasePartyAICDetailsEntity, DocCasePartyAICDetail>(docCasePartyAICDetailDomainEntity);
                docCasePartyAICDetailNHibernateEntity.MActingInCapacity = Mapper.Map<MActingInCapacityEntity, MActingInCapacity>(docCasePartyAICDetailDomainEntity.MActingInCapacity);
                docCasePartyAICDetailNHibernateEntity.MDCPAICDIdCountryCode = Mapper.Map<MCountryEntity, MCountry>(docCasePartyAICDetailDomainEntity.MIdCountry);
                docCasePartyAICDetailNHibernateEntity.MDCPAICDCountryOfRegistration = Mapper.Map<MCountryEntity, MCountry>(docCasePartyAICDetailDomainEntity.MCountryOfRegistration);
                docCasePartyAICDetailNHibernateEntity.MGender = Mapper.Map<MGenderEntity, MGender>(docCasePartyAICDetailDomainEntity.MGender);
                docCasePartyAICDetailNHibernateEntity.MPersonIDGroup = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(docCasePartyAICDetailDomainEntity.MPersonIdGroup);
                docCasePartyAICDetailNHibernateEntity.MDCPAICDCompanyIdTypeCode = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(docCasePartyAICDetailDomainEntity.MCompanyIdTypeCode);
                docCasePartyAICDetailNHibernateEntity.MDCPAICDPersonIdTypeCode = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(docCasePartyAICDetailDomainEntity.MPersonIdType);
                docCasePartyAICDetailNHibernateEntity.MEntityType = Mapper.Map<MEntityTypeEntity, MEntityType>(docCasePartyAICDetailDomainEntity.MEntityType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCasePartyAICDetail", ex);
                throw;
            }

            return docCasePartyAICDetailNHibernateEntity;
        }

        /// <summary>
        /// Get Document Case Party Alias. 
        /// </summary>
        /// <param name="docCasePartyAliasDomainEntity"></param>
        /// <returns></returns>
        public static DocCasePartyAlias GetDocCasePartyAlias(DocCasePartyAliasEntity docCasePartyAliasDomainEntity)
        {
            DocCasePartyAlias docCasePartyAliasNHibernateEntity = null;

            try
            {
                docCasePartyAliasNHibernateEntity = Mapper.Map<DocCasePartyAliasEntity, DocCasePartyAlias>(docCasePartyAliasDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCasePartyAlias", ex);
                throw;
            }

            return docCasePartyAliasNHibernateEntity;
        }

        /// <summary>
        /// Get Document Case Party Officer Detail.
        /// </summary>
        /// <param name="docCasePartyOfficerDetailDomainEntity"></param>
        /// <returns></returns>
        public static DocCasePartyAuthorisedOfficerDetail GetDocCasePartyAuthorisedOfficerDetail(DocCasePartyAuthorisedOfficerDetailsEntity docCasePartyOfficerDetailDomainEntity)
        {
            DocCasePartyAuthorisedOfficerDetail docCasePartyOfficerDetailNHibernateEntity = null;

            try
            {
                docCasePartyOfficerDetailNHibernateEntity = Mapper.Map<DocCasePartyAuthorisedOfficerDetailsEntity, DocCasePartyAuthorisedOfficerDetail>(docCasePartyOfficerDetailDomainEntity);
                docCasePartyOfficerDetailNHibernateEntity.MCountry = Mapper.Map<MCountryEntity, MCountry>(docCasePartyOfficerDetailDomainEntity.MCountryEntity);
                docCasePartyOfficerDetailNHibernateEntity.MPersonIDGroup = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(docCasePartyOfficerDetailDomainEntity.MPersonIDGroupEntity);
                docCasePartyOfficerDetailNHibernateEntity.MPersonIDType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(docCasePartyOfficerDetailDomainEntity.MPersonIDTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCasePartyAuthorisedOfficerDetail", ex);
                throw;
            }

            return docCasePartyOfficerDetailNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyBailorAddress"/> from <see cref="DocCasePartyBailorAddressEntity"/> input.
        /// </summary>
        /// <param name="docCasePartyBailorAddressEntity"><see cref="DocCasePartyBailorAddressEntity"/></param>
        /// <returns>Returns <see cref="DocCasePartyBailorAddress"/>, else null.</returns>
        public static DocCasePartyBailorAddress GetDocCasePartyBailorAddress(DocCasePartyBailorAddressEntity docCasePartyBailorAddressEntity)
        {
            DocCasePartyBailorAddress docCasePartyBailorAddress = null;

            try
            {
                if (docCasePartyBailorAddressEntity != null)
                {
                    docCasePartyBailorAddress = Mapper.Map<DocCasePartyBailorAddressEntity, DocCasePartyBailorAddress>(docCasePartyBailorAddressEntity);
                    docCasePartyBailorAddress.MCountry = Mapper.Map<MCountryEntity, MCountry>(docCasePartyBailorAddressEntity.MCountry);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyBailorAddress", ex);
                throw;
            }

            return docCasePartyBailorAddress;
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyBailorInfo"/> from <see cref="DocCasePartyBailorInfoEntity"/> input.
        /// </summary>
        /// <param name="docCasePartyBailorInfoEntity"><see cref="DocCasePartyBailorInfoEntity"/></param>
        /// <returns>Returns <see cref="DocCasePartyBailorInfo"/>, else null.</returns>
        public static DocCasePartyBailorInfo GetDocCasePartyBailorInfo(DocCasePartyBailorInfoEntity docCasePartyBailorInfoEntity)
        {
            DocCasePartyBailorInfo docCasePartyBailorInfo = null;

            try
            {
                if (docCasePartyBailorInfoEntity != null)
                {
                    docCasePartyBailorInfo = Mapper.Map<DocCasePartyBailorInfoEntity, DocCasePartyBailorInfo>(docCasePartyBailorInfoEntity);
                    docCasePartyBailorInfo.MIDType = Mapper.Map<MIDTypeEntity, MIDType>(docCasePartyBailorInfoEntity.MIDType);
                    docCasePartyBailorInfo.MCountry = Mapper.Map<MCountryEntity, MCountry>(docCasePartyBailorInfoEntity.MCountry);
                    docCasePartyBailorInfo.MBailType = Mapper.Map<MBailTypeEntity, MBailType>(docCasePartyBailorInfoEntity.MBailType);
                    docCasePartyBailorInfo.IDGroupCode = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(docCasePartyBailorInfoEntity.IDGroupCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyBailorInfo", ex);
                throw;
            }

            return docCasePartyBailorInfo;
        }

        /** End of For Criminal Entities **/
        /// <summary>
        /// Gets the <see cref="DocCasePartyCitizenship"/> from <see cref="DocCasePartyCitizenshipEntity"/> input.
        /// </summary>
        /// <param name="DocCasePartyCitizenshipEntity"><see cref="DocCasePartyCitizenshipEntity"/></param>
        /// <returns>Returns <see cref="DocCasePartyCitizenship"/>, else null.</returns>
        public static DocCasePartyCitizenship GetDocCasePartyCitizenship(DocCasePartyCitizenshipEntity docCasePartyCitizenshipEntity)
        {
            DocCasePartyCitizenship docCasePartyCitizenship = null;

            try
            {
                if (docCasePartyCitizenshipEntity != null)
                {
                    docCasePartyCitizenship = Mapper.Map<DocCasePartyCitizenshipEntity, DocCasePartyCitizenship>(docCasePartyCitizenshipEntity);
                    docCasePartyCitizenship.MCountry = Mapper.Map<MCountryEntity, MCountry>(docCasePartyCitizenshipEntity.MCountry);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyCitizenship", ex);
                throw;
            }

            return docCasePartyCitizenship;
        }

        /** For Criminal Entities **/
        /// <summary>
        /// Gets the <see cref="DocCasePartyCriminalInfo"/> from <see cref="DocCasePartyCriminalInfoEntity"/> input.
        /// </summary>
        /// <param name="docCasePartyCriminalInfoEntity"><see cref="DocCasePartyCriminalInfoEntity"/></param>
        /// <returns>Returns <see cref="DocCasePartyCriminalInfo"/>, else null.</returns>
        public static DocCasePartyCriminalInfo GetDocCasePartyCriminalInfo(DocCasePartyCriminalInfoEntity docCasePartyCriminalInfoEntity)
        {
            DocCasePartyCriminalInfo docCasePartyCriminalInfo = null;

            try
            {
                if (docCasePartyCriminalInfoEntity != null)
                {
                    docCasePartyCriminalInfo = Mapper.Map<DocCasePartyCriminalInfoEntity, DocCasePartyCriminalInfo>(docCasePartyCriminalInfoEntity);
                    docCasePartyCriminalInfo.MPrisonCustodyPrisonCode = Mapper.Map<MPrisonEntity, MPrison>(docCasePartyCriminalInfoEntity.MPrisonCustody);
                    docCasePartyCriminalInfo.MPrisonRemandPrisonCode = Mapper.Map<MPrisonEntity, MPrison>(docCasePartyCriminalInfoEntity.MPrisonRemand);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyCriminalInfo", ex);
                throw;
            }

            return docCasePartyCriminalInfo;
        }

        /// <summary>
        /// Gets the <see cref="RDocLawFirm"/> from <see cref="RDocLawFirmEntity"/> input.
        /// </summary>
        /// <param name="rDocLawFirmEntityEntity"><see cref="RDocLawFirmEntity"/></param>
        /// <returns>Returns <see cref="RDocLawFirm"/>, else null.</returns>
        public static DocCasePartyLACDetail GetDocCasePartyLACDetail(DocCasePartyLACDetailEntity docCasePartyLACDetailEntity)
        {
            DocCasePartyLACDetail docCasePartyLACDetail = null;

            try
            {
                if (docCasePartyLACDetailEntity != null)
                {
                    docCasePartyLACDetail = Mapper.Map<DocCasePartyLACDetailEntity, DocCasePartyLACDetail>(docCasePartyLACDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocCasePartyLACDetail", ex);
                throw;
            }

            return docCasePartyLACDetail;
        }

        /// <summary>
        /// Get Document Case Party Vessel Detail.
        /// </summary>
        /// <param name="docCasePartyVesselDetailDomainEntity"></param>
        /// <returns></returns>
        public static DocCasePartyVesselDetail GetDocCasePartyVesselDetails(DocCasePartyVesselDetailsEntity docCasePartyVesselDetailDomainEntity)
        {
            DocCasePartyVesselDetail docCasePartyVesselDetailNHibernateEntity = null;

            try
            {
                docCasePartyVesselDetailNHibernateEntity = Mapper.Map<DocCasePartyVesselDetailsEntity, DocCasePartyVesselDetail>(docCasePartyVesselDetailDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCasePartyVesselDetails", ex);
                throw;
            }

            return docCasePartyVesselDetailNHibernateEntity;
        }

        /// <summary>
        /// Get Document Case Party Solicitor.
        /// </summary>
        /// <param name="docCaseSolicitorDomainEntity"></param>
        /// <returns></returns>
        public static DocCaseSolicitor GetDocCaseSolicitor(DocCaseSolicitorEntity docCaseSolicitorDomainEntity)
        {
            DocCaseSolicitor docCaseSolicitorNHibernateEntity = null;

            try
            {
                docCaseSolicitorNHibernateEntity = Mapper.Map<DocCaseSolicitorEntity, DocCaseSolicitor>(docCaseSolicitorDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCaseSolicitor", ex);
                throw;
            }

            return docCaseSolicitorNHibernateEntity;
        }

        public static DocGCRDetails GetDocGCRDetails(DocGCRDetailsEntity docGCRDetailsEntity)
        {
            DocGCRDetails docGCRDetails = null;

            try
            {
                docGCRDetails = Mapper.Map<DocGCRDetailsEntity, DocGCRDetails>(docGCRDetailsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocGCRDetails", ex);
                throw;
            }

            return docGCRDetails;
        }

        /// <summary>
        /// Gets the <see cref="DocOrderDetail"/> from <see cref="DocOrderDetailsEntity"/> input.
        /// </summary>
        /// <param name="docOrderDetailsEntity"><see cref="DocOrderDetailsEntity"/></param>
        /// <returns>Returns <see cref="DocOrderDetail"/>, else null.</returns>
        public static DocOrderDetail GetDocOrderDetailsEntity(DocOrderDetailsEntity docOrderDetailsEntity)
        {
            DocOrderDetail docOrderDetail = null;
            try
            {
                if (docOrderDetailsEntity != null)
                {
                    docOrderDetail = Mapper.Map<DocOrderDetailsEntity, DocOrderDetail>(docOrderDetailsEntity);
                    docOrderDetail.MDesignation = Mapper.Map<MDesignationEntity, MDesignation>(docOrderDetailsEntity.MDesignation);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocOrderDetailsEntity", ex);
                throw;
            }
            return docOrderDetail;
        }

        public static DocumentBatesList GetDocumentBatesList(DocumentBatesListEntity DocumentBatesListEntity)
        {
            DocumentBatesList documentBatesList = null;
            try
            {
                documentBatesList = Mapper.Map<DocumentBatesListEntity, DocumentBatesList>(DocumentBatesListEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocumentBatesList", ex);
                throw;
            }
            return documentBatesList;
        }

        /// <summary>
        /// Gets the document entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="documentEntity">The document entity.</param>
        /// <returns></returns>
        public static IDocument GetDocumentEntity<T>(T documentEntity)
        {
            if (documentEntity.GetType().Equals(typeof(DocCasePartyEntity)))
                return DocumentMapper.GetDocCaseParty(documentEntity as DocCasePartyEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCasePartyAddressEntity)))
                return DocumentMapper.GetDocCasePartyAddress(documentEntity as DocCasePartyAddressEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCasePartyAICAddressEntity)))
                return DocumentMapper.GetDocCasePartyAICAddress(documentEntity as DocCasePartyAICAddressEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCasePartyAICAliasEntity)))
                return DocumentMapper.GetDocCasePartyAICAlias(documentEntity as DocCasePartyAICAliasEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCasePartyAICDetailsEntity)))
                return DocumentMapper.GetDocCasePartyAICDetail(documentEntity as DocCasePartyAICDetailsEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCasePartyAliasEntity)))
                return DocumentMapper.GetDocCasePartyAlias(documentEntity as DocCasePartyAliasEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCasePartyAuthorisedOfficerDetailsEntity)))
                return DocumentMapper.GetDocCasePartyAuthorisedOfficerDetail(documentEntity as DocCasePartyAuthorisedOfficerDetailsEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCasePartyVesselDetailsEntity)))
                return DocumentMapper.GetDocCasePartyVesselDetails(documentEntity as DocCasePartyVesselDetailsEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCaseSolicitorEntity)))
                return DocumentMapper.GetDocCaseSolicitor(documentEntity as DocCaseSolicitorEntity);

            else if (documentEntity.GetType().Equals(typeof(DocumentInfoEntity)))
                return DocumentMapper.GetDocumentInfo(documentEntity as DocumentInfoEntity);

            else if (documentEntity.GetType().Equals(typeof(RDocCaseEntity)))
                return DocumentMapper.GetRDocCase(documentEntity as RDocCaseEntity);

            else if (documentEntity.GetType().Equals(typeof(DocGCRDetailsEntity)))
                return DocumentMapper.GetDocGCRDetails(documentEntity as DocGCRDetailsEntity);

            else if (documentEntity.GetType().Equals(typeof(RDocCasePartyEntity)))
                return DocumentMapper.GetRDocCaseParty(documentEntity as RDocCasePartyEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCasePartyLACDetailEntity)))
                return DocumentMapper.GetDocCasePartyLACDetail(documentEntity as DocCasePartyLACDetailEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCasePartyBailorInfoEntity)))
                return GetDocCasePartyBailorInfo(documentEntity as DocCasePartyBailorInfoEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCasePartyBailorAddressEntity)))
                return GetDocCasePartyBailorAddress(documentEntity as DocCasePartyBailorAddressEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCasePartyCriminalInfoEntity)))
                return GetDocCasePartyCriminalInfo(documentEntity as DocCasePartyCriminalInfoEntity);

            else if (documentEntity.GetType().Equals(typeof(DocOrderDetailsEntity)))
                return GetDocOrderDetailsEntity(documentEntity as DocOrderDetailsEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCasePartyCitizenshipEntity)))
                return GetDocCasePartyCitizenship(documentEntity as DocCasePartyCitizenshipEntity);

            else if (documentEntity.GetType().Equals(typeof(DocumentBatesListEntity)))
                return GetDocumentBatesList(documentEntity as DocumentBatesListEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCommentsEntity)))
                return GetDocComments(documentEntity as DocCommentsEntity);

            else if (documentEntity.GetType().Equals(typeof(DocRequestDetailsEntity)))
                return GetDocRequestDetail(documentEntity as DocRequestDetailsEntity);

            else if (documentEntity.GetType().Equals(typeof(DocCaseTierTypeEntity)))
                return GetDocCaseTierType(documentEntity as DocCaseTierTypeEntity);

            else if (documentEntity.GetType().Equals(typeof(LawFirmDocCaseFileRefNumberEntity)))
                return GetLawFirmDocCaseFileRefNumber(documentEntity as LawFirmDocCaseFileRefNumberEntity);

            else if (documentEntity.GetType().Equals(typeof(DocPartyCaseFileRefNumberEntity)))
                return GetDocPartyCaseFileRefNumber(documentEntity as DocPartyCaseFileRefNumberEntity);

            else if (documentEntity.GetType().Equals(typeof(Temp_ProcessingInfoEntity)))
                return GetTemp_ProcessingInfo(documentEntity as Temp_ProcessingInfoEntity);

            else if (documentEntity.GetType().Equals(typeof(RDocCounterClaimFiledEntity)))
                return GetRDocCounterClaimFiled(documentEntity as RDocCounterClaimFiledEntity);

            else
                throw new ArgumentNullException("Invalid object sent.");
        }

        /// <summary>
        /// Get Document Info.
        /// </summary>
        /// <param name="cocumentInfoDomainEntity"></param>
        /// <returns></returns>
        public static DocumentInfo GetDocumentInfo(DocumentInfoEntity cocumentInfoDomainEntity)
        {
            DocumentInfo cocumentInfoNHibernateEntity = null;

            try
            {
                cocumentInfoNHibernateEntity = Mapper.Map<DocumentInfoEntity, DocumentInfo>(cocumentInfoDomainEntity);
                cocumentInfoNHibernateEntity.MCurrency = Mapper.Map<MCurrencyEntity, MCurrency>(cocumentInfoDomainEntity.MCurrency);
                cocumentInfoNHibernateEntity.MDocCode = Mapper.Map<MDocCodeEntity, MDocCode>(cocumentInfoDomainEntity.MDocCode);
                cocumentInfoNHibernateEntity.MDocNature = Mapper.Map<MDocNatureEntity, MDocNature>(cocumentInfoDomainEntity.MDocNature);
                cocumentInfoNHibernateEntity.MDocSecurity = Mapper.Map<MDocSecurityEntity, MDocSecurity>(cocumentInfoDomainEntity.MDocSecurity);
                cocumentInfoNHibernateEntity.MDocStatus = Mapper.Map<MDocStatusEntity, MDocStatus>(cocumentInfoDomainEntity.MDocStatus);
                cocumentInfoNHibernateEntity.MForumType = Mapper.Map<MForumTypeEntity, MForumType>(cocumentInfoDomainEntity.MForumType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocumentInfo", ex);
                throw;
            }

            return cocumentInfoNHibernateEntity;
        }

        public static DocumentInfoSP GetDocumentInfoSP(DocumentInfoEntity documentInfoDomainEntity)
        {
            DocumentInfoSP documentInfoNHibernateEntity = null;

            try
            {
                documentInfoNHibernateEntity = Mapper.Map<DocumentInfoEntity, DocumentInfoSP>(documentInfoDomainEntity);
               
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocumentInfoSP", ex);
                throw;
            }

            return documentInfoNHibernateEntity;
        }

        public static RDocCase GetRDocCase(RDocCaseEntity rDOCCaseEntity)
        {
            RDocCase rDocCase = null;

            try
            {
                rDocCase = Mapper.Map<RDocCaseEntity, RDocCase>(rDOCCaseEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRDocCase", ex);
                throw;
            }

            return rDocCase;
        }

        /// <summary>
        /// Get Document R Doc Case Party.
        /// </summary>
        /// <param name="rDocCasePartyDomainEntity"></param>
        /// <returns></returns>
        public static RDocCaseParty GetRDocCaseParty(RDocCasePartyEntity rDocCasePartyDomainEntity)
        {
            RDocCaseParty rDocCasePartyNHibernateEntity = null;

            try
            {
                rDocCasePartyNHibernateEntity = Mapper.Map<RDocCasePartyEntity, RDocCaseParty>(rDocCasePartyDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRDocCaseParty", ex);
                throw;
            }

            return rDocCasePartyNHibernateEntity;
        }

        public static DocComments GetDocComments(DocCommentsEntity docCommentsEntity)
        {
            DocComments docComments = null;

            try
            {
                docComments = Mapper.Map<DocCommentsEntity, DocComments>(docCommentsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocComments", ex);
                throw;
            }

            return docComments;
        }

        /// <summary>
        /// Gets the <see cref="DocRequestDetail"/> from <see cref="DocRequestDetailEntity"/> input.
        /// </summary>
        /// <param name="DocRequestDetailEntity"><see cref="DocRequestDetailEntity"/></param>
        /// <returns>Returns <see cref="DocRequestDetail"/>, else null.</returns>
        public static DocRequestDetail GetDocRequestDetail(DocRequestDetailsEntity docRequestDetailEntity)
        {
            DocRequestDetail docRequestDetail = null;

            try
            {
                if (docRequestDetailEntity != null)
                {
                    docRequestDetail = Mapper.Map<DocRequestDetailsEntity, DocRequestDetail>(docRequestDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocRequestDetail", ex);
                throw;
            }

            return docRequestDetail;
        }

        public static DocCaseTierType GetDocCaseTierType(DocCaseTierTypeEntity docCaseTierTypeEntity)
        {
            DocCaseTierType docCaseTierType = null;

            try
            {
                docCaseTierType = Mapper.Map<DocCaseTierTypeEntity, DocCaseTierType>(docCaseTierTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCaseTierType", ex);
                throw;
            }

            return docCaseTierType;
        }

        /// <summary>
        /// Gets the <see cref="LawFirmDocCaseFileRefNumber"/> from <see cref="LawFirmDocCaseFileRefNumberEntity"/> input.
        /// </summary>
        /// <param name="LawFirmDocCaseFileRefNumberEntity"><see cref="LawFirmDocCaseFileRefNumberEntity"/></param>
        /// <returns>Returns <see cref="LawFirmDocCaseFileRefNumber"/>, else null.</returns>
        public static LawFirmDocCaseFileRefNumber GetLawFirmDocCaseFileRefNumber(LawFirmDocCaseFileRefNumberEntity lawFirmDocCaseFileRefNumberEntity)
        {
            LawFirmDocCaseFileRefNumber lawFirmDocCaseFileRefNumber = null;

            try
            {
                if (lawFirmDocCaseFileRefNumberEntity != null)
                {
                    lawFirmDocCaseFileRefNumber = Mapper.Map<LawFirmDocCaseFileRefNumberEntity, LawFirmDocCaseFileRefNumber>(lawFirmDocCaseFileRefNumberEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLawFirmDocCaseFileRefNumber", ex);
                throw;
            }

            return lawFirmDocCaseFileRefNumber;
        }

        /// <summary>
        /// Gets the document party case file reference number.
        /// </summary>
        /// <param name="docPartyCaseFileRefNumberEntity">The document party case file reference number entity.</param>
        /// <returns></returns>
        public static DocPartyCaseFileRefNumber GetDocPartyCaseFileRefNumber(DocPartyCaseFileRefNumberEntity docPartyCaseFileRefNumberEntity)
        {
            DocPartyCaseFileRefNumber docPartyCaseFileRefNumber = null;

            try
            {
                if (docPartyCaseFileRefNumberEntity != null)
                {
                    docPartyCaseFileRefNumber = Mapper.Map<DocPartyCaseFileRefNumberEntity, DocPartyCaseFileRefNumber>(docPartyCaseFileRefNumberEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocPartyCaseFileRefNumber", ex);
                throw;
            }

            return docPartyCaseFileRefNumber;
        }

        public static Temp_ProcessingInfo GetTemp_ProcessingInfo(Temp_ProcessingInfoEntity temp_ProcessingInfoEntity)
        {
            Temp_ProcessingInfo temp_ProcessingInfo = null;

            try
            {
                if (temp_ProcessingInfoEntity != null)
                {
                    temp_ProcessingInfo = Mapper.Map<Temp_ProcessingInfoEntity, Temp_ProcessingInfo>(temp_ProcessingInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetTemp_ProcessingInfo", ex);
                throw;
            }

            return temp_ProcessingInfo;
        }

        public static RDocCounterClaimFiled GetRDocCounterClaimFiled(RDocCounterClaimFiledEntity rDocCounterClaimFiledEntity)
        {
            RDocCounterClaimFiled rDocCounterClaimFiled = null;

            try
            {
                if (rDocCounterClaimFiledEntity != null)
                {
                    rDocCounterClaimFiled = Mapper.Map<RDocCounterClaimFiledEntity, RDocCounterClaimFiled>(rDocCounterClaimFiledEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRDocCounterClaimFiled", ex);
                throw;
            }

            return rDocCounterClaimFiled;
        }

        #endregion Methods

        #region Other

        ///// <summary>
        ///// Get Document R Doc Law Firm.
        ///// </summary>
        ///// <param name="rDocLawFirmEntityDomainEntity"></param>
        ///// <returns></returns>
        //public static RDocLawFirm GetRDocLawFirm(RDocLawFirmEntity rDocLawFirmEntityDomainEntity)
        //{
        //    RDocLawFirm rDocLawFirmNHibernateEntity = null;
        //    try
        //    {
        //        rDocLawFirmNHibernateEntity = Mapper.Map<RDocLawFirmEntity, RDocLawFirm>(rDocLawFirmEntityDomainEntity);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    return rDocLawFirmNHibernateEntity;
        //}

        #endregion Other

        
    }
}