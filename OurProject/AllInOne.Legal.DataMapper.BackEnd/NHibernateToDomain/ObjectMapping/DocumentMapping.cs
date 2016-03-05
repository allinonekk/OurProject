#region Header

/*****************************************************************************************************
* Description : This file handles mapping for Document from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   23/09/2010   		      	Nai                	 	Created
*
*****************************************************************************************************/
// <summary>
// File: DocumentMapping.cs
// Description: This file handles mapping for Document from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "DocumentMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Document from NHibernate entities to Domain objects.
    /// </summary>
    internal class DocumentMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DocumentMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Maps objects from <see cref="CaseLatestDocuments"/> to <see cref="CaseLatestDocumentsEntity"/>.
        /// </summary>
        internal void MapCaseLatestDocumentsToCaseLatestDocumentsEntity()
        {
            try
            {
                Mapper.CreateMap<CaseLatestDocuments, CaseLatestDocumentsEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCaseLatestDocumentsToCaseLatestDocumentsEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocCasePartyAddress"/> to <see cref="DocCasePartyAddressEntity"/>.
        /// </summary>
        internal void MapDocCasePartyAddressToDocCasePartyAddressEntity()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyAddress, DocCasePartyAddressEntity>()
                    .ForMember(desc => desc.Addr1, opts => opts.MapFrom(src => src.Addr1))
                    .ForMember(desc => desc.Addr2, opts => opts.MapFrom(src => src.Addr2))
                    .ForMember(desc => desc.Addr3, opts => opts.MapFrom(src => src.Addr3))
                    .ForMember(desc => desc.Addr4, opts => opts.MapFrom(src => src.Addr4))
                    .ForMember(desc => desc.Address, opts => opts.MapFrom(src => src.Address))
                    .ForMember(desc => desc.AddrType, opts => opts.MapFrom(src => src.AddrType))
                    .ForMember(desc => desc.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                    .ForMember(desc => desc.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                    .ForMember(desc => desc.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
                    .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                    .ForMember(desc => desc.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                    .ForMember(desc => desc.FormatInd, opts => opts.MapFrom(src => src.FormatInd))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LastStayedInd, opts => opts.MapFrom(src => src.LastStayedInd))
                    .ForMember(desc => desc.MailingInd, opts => opts.MapFrom(src => src.MailingInd))
                    .ForMember(desc => desc.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                    .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId))
                    .ForMember(desc => desc.StreetName, opts => opts.MapFrom(src => src.StreetName))
                    .ForMember(desc => desc.UnitNo, opts => opts.MapFrom(src => src.UnitNo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyAddressToDocCasePartyAddressEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocCasePartyAICAddress"/> to <see cref="DocCasePartyAICAddressEntity"/>.
        /// </summary>
        internal void MapDocCasePartyAICAddressToCasePartyAICAddressEntity()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyAICAddress, DocCasePartyAICAddressEntity>()
                    .ForMember(desc => desc.Addr1, opts => opts.MapFrom(src => src.Addr1))
                    .ForMember(desc => desc.Addr2, opts => opts.MapFrom(src => src.Addr2))
                    .ForMember(desc => desc.Addr3, opts => opts.MapFrom(src => src.Addr3))
                    .ForMember(desc => desc.Addr4, opts => opts.MapFrom(src => src.Addr4))
                    .ForMember(desc => desc.Address, opts => opts.MapFrom(src => src.Address))
                    .ForMember(desc => desc.AddrType, opts => opts.MapFrom(src => src.AddrType))
                    .ForMember(desc => desc.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                    .ForMember(desc => desc.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                    .ForMember(desc => desc.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
                    .ForMember(desc => desc.DCPAICID, opts => opts.MapFrom(src => src.DCPAICID))
                    .ForMember(desc => desc.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                    .ForMember(desc => desc.FormatInd, opts => opts.MapFrom(src => src.FormatInd))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                    .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId))
                    .ForMember(desc => desc.StreetName, opts => opts.MapFrom(src => src.StreetName))
                    .ForMember(desc => desc.UnitNo, opts => opts.MapFrom(src => src.UnitNo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyAICAddressToCasePartyAICAddressEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocCasePartyAICAlias"/> to <see cref="DocCasePartyAICAliasEntity"/>.
        /// </summary>
        internal void MapDocCasePartyAICAliasToDocCasePartyAICAliasEntity()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyAICAlias, DocCasePartyAICAliasEntity>()
                    .ForMember(desc => desc.AliasName, opts => opts.MapFrom(src => src.AliasName))
                    .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                    .ForMember(desc => desc.DCPAICID, opts => opts.MapFrom(src => src.DCPAICID))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyAICAliasToDocCasePartyAICAliasEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocCasePartyAICDetail"/> to <see cref="DocCasePartyAICDetailsEntity"/>.
        /// </summary>
        internal void MapDocCasePartyAICDetailToDocCasePartyAICDetailEntity()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyAICDetail, DocCasePartyAICDetailsEntity>()
                    .ForMember(desc => desc.AddressAvailabilityInd, opts => opts.MapFrom(src => src.AddressAvailabilityInd))
                    .ForMember(desc => desc.CompanyName, opts => opts.MapFrom(src => src.CompanyName))
                    .ForMember(desc => desc.DateOfRegistration, opts => opts.MapFrom(src => src.DateOfRegistration))
                    .ForMember(desc => desc.DCPAICID, opts => opts.MapFrom(src => src.DCPAICID))
                    .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                    .ForMember(desc => desc.DocCasePartyAICAddresses, opts => opts.Ignore())
                    .ForMember(desc => desc.DocCasePartyAICAliases, opts => opts.Ignore())
                    .ForMember(desc => desc.FormerCompanyName, opts => opts.MapFrom(src => src.FormerCompanyName))
                    .ForMember(desc => desc.FormerPersonName, opts => opts.MapFrom(src => src.FormerPersonName))
                    .ForMember(desc => desc.FullName, opts => opts.MapFrom(src => src.FullName))
                    .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(desc => desc.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                    .ForMember(desc => desc.IMONumber, opts => opts.MapFrom(src => src.IMONumber))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.PortOfRegistration, opts => opts.MapFrom(src => src.PortOfRegistration))
                    .ForMember(desc => desc.RegistrationNumber, opts => opts.MapFrom(src => src.RegistrationNumber))
                    .ForMember(desc => desc.UEN, opts => opts.MapFrom(src => src.UEN))
                    .ForMember(desc => desc.VesselIdType, opts => opts.MapFrom(src => src.VesselIdType))
                    .ForMember(desc => desc.VesselName, opts => opts.MapFrom(src => src.VesselName));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyAICDetailToDocCasePartyAICDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocCasePartyAlias"/> to <see cref="DocCasePartyAliasEntity"/>.
        /// </summary>
        internal void MapDocCasePartyAliasToDocCasePartyAliasEntity()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyAlias, DocCasePartyAliasEntity>()
                    .ForMember(desc => desc.AliasName, opts => opts.MapFrom(src => src.AliasName))
                    .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyAliasToDocCasePartyAliasEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocCasePartyAuthorisedOfficerDetail"/> to <see cref="DocCasePartyAuthorisedOfficerDetailsEntity"/>.
        /// </summary>
        internal void MapDocCasePartyAuthorisedOfficerDetailToDocCasePartyAuthorisedOfficerDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyAuthorisedOfficerDetail, DocCasePartyAuthorisedOfficerDetailsEntity>()
                   .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                   .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                   .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                   .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                   .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                   .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                   .ForMember(desc => desc.Name, opts => opts.MapFrom(src => src.Name))
                   .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyAuthorisedOfficerDetailToDocCasePartyAuthorisedOfficerDetailsEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="DocCasePartyBailorAddress"/> to <see cref="DocCasePartyBailorAddressEntity"/>.
        /// </summary>
        internal void MapDocCasePartyBailorAddressToDocCasePartyBailorAddressEntity()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyBailorAddress, DocCasePartyBailorAddressEntity>()
                    //.ForMember(desc => desc.DocCasePartyBailorInfoId, opts => opts.MapFrom(src => src.DocCasePartyBailorInfo.DocCasePartyBailorInfoId))
                    .ForMember(desc => desc.FormatInd, opts => opts.MapFrom(src => src.FormatInd))
                    .ForMember(desc => desc.AddrType, opts => opts.MapFrom(src => src.AddrType))
                    .ForMember(desc => desc.MailingInd, opts => opts.MapFrom(src => src.MailingInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyBailorAddressToDocCasePartyBailorAddressEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="DocCasePartyBailorInfo"/> to <see cref="DocCasePartyBailorInfoEntity"/>.
        /// </summary>
        internal void MapDocCasePartyBailorInfoToDocCasePartyBailorInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyBailorInfo, DocCasePartyBailorInfoEntity>()
                    //.ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DocCaseParty.DCPID))
                    .ForMember(desc => desc.ContactTypeInd, opts => opts.MapFrom(src => src.ContactTypeInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyBailorInfoToDocCasePartyBailorInfoEntity", ex);
                throw;
            }
        }

        /** End of For Criminal Entities **/
        /// <summary>
        /// Maps objects from <see cref="DocCasePartyCitizenship"/> to <see cref="DocCasePartyCitizenshipEntity"/>.
        /// </summary>
        internal void MapDocCasePartyCitizenshipToDocCasePartyCitizenshipEntity()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyCitizenship, DocCasePartyCitizenshipEntity>()
                    .ForMember(dest => dest.DocCasePartyCitizenshipId, opts => opts.MapFrom(src => src.DCPCitizenshipId))
                    //.ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DocCaseParty.DCPID))
                    .ForMember(desc => desc.CitizenshipStatus, opts => opts.MapFrom(src => src.CitizenshipStatus));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyCitizenshipToDocCasePartyCitizenshipEntity", ex);
                throw;
            }
        }

        /** For Criminal Entities **/
        /// <summary>
        /// Maps objects from <see cref="DocCasePartyCriminalInfo"/> to <see cref="DocCasePartyCriminalInfoEntity"/>.
        /// </summary>
        internal void MapDocCasePartyCriminalInfoToDocCasePartyCriminalInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyCriminalInfo, DocCasePartyCriminalInfoEntity>()
                    //.ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DocCaseParty.DCPID))
                    .ForMember(desc => desc.PartyInType, opts => opts.MapFrom(src => src.PartyInType))
                    .ForMember(desc => desc.MPrisonCustody, opts => opts.MapFrom(src => src.MPrisonCustodyPrisonCode))
                    .ForMember(desc => desc.MPrisonRemand, opts => opts.MapFrom(src => src.MPrisonRemandPrisonCode));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyCriminalInfoToDocCasePartyCriminalInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocCasePartyLACDetail"/> to <see cref="DocCasePartyLACDetailEntity"/>.
        /// </summary>
        internal void MapDocCasePartyLACDetailToDocCasePartyLACDetailEntity()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyLACDetail, DocCasePartyLACDetailEntity>()
                    .ForMember(desc => desc.DCPLACDetailId, opts => opts.MapFrom(src => src.DCPLACDetailId))
                    .ForMember(dest => dest.DCPID, opts => opts.MapFrom(src => src.DocCaseParty.DCPID))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.FiledUserType, opts => opts.MapFrom(src => src.FiledUserType))
                    .ForMember(dest => dest.LACDocDetailId, opts => opts.MapFrom(src => src.LACDocDetailId))
                    .ForMember(dest => dest.LACInfoId, opts => opts.MapFrom(src => src.LACInfoId))
                    .ForMember(dest => dest.LACRefStatus, opts => opts.MapFrom(src => src.LACRefStatus))
                    .ForMember(dest => dest.LFGroupCode, opts => opts.MapFrom(src => src.LFGroupCode));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocCasePartyLACDetailToDocCasePartyLACDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocCaseParty"/> to <see cref="DocCasePartyEntity"/>.
        /// </summary>
        internal void MapDocCasePartyToDocCasePartyEntity()
        {
            try
            {
                Mapper.CreateMap<DocCaseParty, DocCasePartyEntity>()
                    .ForMember(desc => desc.ApplicantCapacityRemarks, opts => opts.MapFrom(src => src.ApplicantCapacityRemarks))
                    .ForMember(desc => desc.BirthCountryRemarks, opts => opts.MapFrom(src => src.BirthCountryRemarks))
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(desc => desc.CompanyName, opts => opts.MapFrom(src => src.CompanyName))
                    .ForMember(desc => desc.ContactTypeInd, opts => opts.MapFrom(src => src.ContactTypeInd))
                    .ForMember(desc => desc.DateOfBirth, opts => opts.MapFrom(src => src.DateOfBirth))
                    .ForMember(desc => desc.DateOfRegistration, opts => opts.MapFrom(src => src.DateOfRegistration))
                    .ForMember(desc => desc.DateofService, opts => opts.MapFrom(src => src.DateofService))
                    .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                    .ForMember(desc => desc.DialectRemarks, opts => opts.MapFrom(src => src.DialectRemarks))
                    .ForMember(desc => desc.DisablePersonInd, opts => opts.MapFrom(src => src.DisablePersonInd))
                    .ForMember(desc => desc.DisablePersonRemarks, opts => opts.MapFrom(src => src.DisablePersonRemarks))
                    .ForMember(desc => desc.Email, opts => opts.MapFrom(src => src.Email))
                    .ForMember(desc => desc.FaxAreaCode, opts => opts.MapFrom(src => src.FaxAreaCode))
                    .ForMember(desc => desc.FaxCountryCode, opts => opts.MapFrom(src => src.FaxCountryCode))
                    .ForMember(desc => desc.FaxNumber, opts => opts.MapFrom(src => src.FaxNumber))
                    .ForMember(desc => desc.FilingInd, opts => opts.MapFrom(src => src.FilingInd))
                    .ForMember(desc => desc.FormerCompanyName, opts => opts.MapFrom(src => src.FormerCompanyName))
                    .ForMember(desc => desc.FormerPersonName, opts => opts.MapFrom(src => src.FormerPersonName))
                    .ForMember(desc => desc.FullName, opts => opts.MapFrom(src => src.FullName))
                    .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(desc => desc.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                    .ForMember(desc => desc.InvolvementInd, opts => opts.MapFrom(src => src.InvolvementInd))
                    .ForMember(desc => desc.HasLAC, opts => opts.MapFrom(src => src.HasLAC))
                    .ForMember(desc => desc.IsPartyServiedWrit, opts => opts.MapFrom(src => src.IsPartyServiedWrit))
                    .ForMember(desc => desc.IsSingaporeanPR, opts => opts.MapFrom(src => src.IsSingaporePR))
                    .ForMember(desc => desc.LanguageCode, opts => opts.MapFrom(src => src.LanguageCode))
                    .ForMember(desc => desc.LanguageRemarks, opts => opts.MapFrom(src => src.LanguageRemarks))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LFAddressId, opts => opts.MapFrom(src => src.LFAddressId))
                    .ForMember(desc => desc.MarriageCertNo, opts => opts.MapFrom(src => src.MarriageCertNo))
                    .ForMember(desc => desc.MarriageDt, opts => opts.MapFrom(src => src.MarriageDt))
                    .ForMember(desc => desc.MobileCountryCode, opts => opts.MapFrom(src => src.MobileCountryCode))
                    .ForMember(desc => desc.MobileNumber, opts => opts.MapFrom(src => src.MobileNumber))
                    .ForMember(desc => desc.NationalityRemarks, opts => opts.MapFrom(src => src.NationalityRemarks))
                    .ForMember(desc => desc.OccupationRemarks, opts => opts.MapFrom(src => src.OccupationRemarks))
                    .ForMember(desc => desc.OrdinalNumber, opts => opts.MapFrom(src => src.OrdinalNumber))
                    .ForMember(desc => desc.PartyNo, opts => opts.MapFrom(src => src.PartyNo))
                    .ForMember(desc => desc.RaceRemarks, opts => opts.MapFrom(src => src.RaceRemarks))
                    .ForMember(desc => desc.RefDCPID, opts => opts.MapFrom(src => src.RefDCPID))
                    .ForMember(desc => desc.RelationshipRemarks, opts => opts.MapFrom(src => src.RelationshipRemarks))
                    .ForMember(desc => desc.ReligionRemarks, opts => opts.MapFrom(src => src.ReligionRemarks))
                    .ForMember(desc => desc.TelAreaCode, opts => opts.MapFrom(src => src.TelAreaCode))
                    .ForMember(desc => desc.TelCountryCode, opts => opts.MapFrom(src => src.TelCountryCode))
                    .ForMember(desc => desc.TelNumber, opts => opts.MapFrom(src => src.TelNumber))
                    .ForMember(desc => desc.UpdateInd, opts => opts.MapFrom(src => src.UpdateInd))
                    .ForMember(desc => desc.UEN, opts => opts.MapFrom(src => src.UEN))
                    .ForMember(desc => desc.VesselName, opts => opts.MapFrom(src => src.VesselName))
                    .ForMember(desc => desc.CapacityInd, opts => opts.MapFrom(src => src.CapacityInd))
                    .ForMember(desc => desc.VesselIDType, opts => opts.MapFrom(src => src.VesselIDType))
                    .ForMember(desc => desc.RoleCode, opts => opts.MapFrom(src => src.RoleCode))
                    .ForMember(desc => desc.IsSubCaseOnlyParty, opts => opts.MapFrom(src => src.IsSubCaseOnlyParty))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyToDocCasePartyEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocCasePartyVesselDetail"/> to <see cref="DocCasePartyVesselDetailsEntity"/>.
        /// </summary>
        internal void MapDocCasePartyVesselDetailToDocCasePartyVesselDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyVesselDetail, DocCasePartyVesselDetailsEntity>()
                   .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                   .ForMember(desc => desc.Description, opts => opts.MapFrom(src => src.Description))
                   .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                   .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                   .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                   .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyVesselDetailToDocCasePartyVesselDetailsEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocCaseSolicitor"/> to <see cref="DocCaseSolicitorEntity"/>.
        /// </summary>
        internal void MapDocCaseSolicitorToCaseSolicitorEntity()
        {
            try
            {
                Mapper.CreateMap<DocCaseSolicitor, DocCaseSolicitorEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                    .ForMember(desc => desc.LFId, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(desc => desc.RefRecId, opts => opts.MapFrom(src => src.RefRecId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.RepresentedBy, opts => opts.MapFrom(src => src.RepresentedBy))
                    .ForMember(desc => desc.SolicitorId, opts => opts.MapFrom(src => src.SolicitorId))
                    .ForMember(desc => desc.StartDate, opts => opts.MapFrom(src => src.StartDate))
                    .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId))
                    .ForMember(desc => desc.JACInd, opts => opts.MapFrom(src => src.JACInd))
                    .ForMember(desc => desc.LASCOInd, opts => opts.MapFrom(src => src.LASCOInd))
                    .ForMember(desc => desc.CLASInd, opts => opts.MapFrom(src => src.CLASInd))
                    .ForMember(desc => desc.ACLASInd, opts => opts.MapFrom(src => src.ACLASInd))
                    .ForMember(desc => desc.DateAppointed, opts => opts.MapFrom(src => src.DateAppointed))
                    .ForMember(desc => desc.DateDischarged, opts => opts.MapFrom(src => src.DateDischarged))
                    .ForMember(desc => desc.CounselInd, opts => opts.MapFrom(src => src.CounselInd))
                    .ForMember(desc => desc.BriefInd, opts => opts.MapFrom(src => src.BriefInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCaseSolicitorToCaseSolicitorEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocGCRDetails"/> to <see cref="DocGCRDetailsEntity"/>.
        /// </summary>
        internal void MapDocGCRDetailsToDocGCRDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<DocGCRDetails, DocGCRDetailsEntity>()
                    .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(desc => desc.LFId, opts => opts.MapFrom(src => src.LFId))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.SentCopy, opts => opts.MapFrom(src => src.SentCopy))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRDocCasePartyToRDocCasePartyEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocOrderDetail"/> to <see cref="DocOrderDetailsEntity"/>.
        /// </summary>
        internal void MapDocOrderDetailToDocOrderDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<DocOrderDetail, DocOrderDetailsEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.DateOfConsent, opts => opts.MapFrom(src => src.DateOfConsent))
                    .ForMember(desc => desc.DateOfOrder, opts => opts.MapFrom(src => src.DateOfOrder))
                    .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(desc => desc.DocOrderDetailId, opts => opts.MapFrom(src => src.DocOrderDetailId))
                    .ForMember(desc => desc.FilingOrderFor, opts => opts.MapFrom(src => src.FilingOrderFor))
                    .ForMember(desc => desc.HRGID, opts => opts.MapFrom(src => (src.HRGID)))
                    .ForMember(desc => desc.IsAutoOrManual, opts => opts.MapFrom(src => src.IsAutoOrManual))
                    .ForMember(desc => desc.JudgeName, opts => opts.MapFrom(src => src.JudgeName))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.OrderMadeIn, opts => opts.MapFrom(src => src.OrderMadeIn))
                    .ForMember(desc => desc.OrderNumber, opts => opts.MapFrom(src => src.OrderNumber))
                    .ForMember(desc => desc.OtherHearingDate, opts => opts.MapFrom(src => src.OtherHearingDate))
                    .ForMember(desc => desc.OtherHearingMadeBy, opts => opts.MapFrom(src => src.OtherHearingMadeBy))
                    .ForMember(desc => desc.PenalNotice, opts => opts.MapFrom(src => src.PenalNotice))
                    .ForMember(desc => desc.PrepopulateOOC, opts => opts.MapFrom(src => src.PrepopulateOOC))
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.WelfareOFFName, opts => opts.MapFrom(src => src.WelfareOFFName))
                    .ForMember(desc => desc.JudgmentFor, opts => opts.MapFrom(src => src.JudgmentFor))
                    .ForMember(desc => desc.FilingFrom, opts => opts.MapFrom(src => src.FilingFrom))
                    .ForMember(desc => desc.SchedulerProcessStatus, opts => opts.MapFrom(src => src.SchedulerProcessStatus))
                    .ForMember(desc => desc.ConsentOrder, opts => opts.MapFrom(src => src.ConsentOrder))
                    .ForMember(desc => desc.OrderForExamination, opts => opts.MapFrom(src => src.OrderForExamination))
                    .ForMember(desc => desc.ReqAvailableDateForOtherParty, opts => opts.MapFrom(src => src.ReqAvailableDateForOtherParty))
                    .ForMember(desc => desc.IsCWUOrder, opts => opts.MapFrom(src => src.IsCWUOrder));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocOrderDetailToDocOrderDetailsEntity", ex);
                throw;
            }
        }

        internal void MapDocRequestDetailToDocRequestDetailEntity()
        {
            try
            {
                Mapper.CreateMap<DocRequestDetail, DocRequestDetailsEntity>()
                  .ForMember(dest => dest.MetaData, opts => opts.MapFrom(src => src.MetaData));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocRequestDetailToDocRequestDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocumentInfo"/> to <see cref="DocumentInfoEntity"/>.
        /// </summary>
        internal void MapDocumentInfoToDocumentInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DocumentInfo, DocumentInfoEntity>()
                    .ForMember(desc => desc.ActualFilingDateTime, opts => opts.MapFrom(src => src.ActualFilingDateTime))
                    .ForMember(desc => desc.BackdateApprInd, opts => opts.MapFrom(src => src.BackDateApprInd))
                    .ForMember(desc => desc.BackDateReasonFrCourt, opts => opts.MapFrom(src => src.BackDateReasonFrCourt))
                    .ForMember(desc => desc.BackDateReasonFrLawFirm, opts => opts.MapFrom(src => src.BackDateReasonFrLawFirm))
                    .ForMember(desc => desc.BackDateTime, opts => opts.MapFrom(src => src.BackDateTime))
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.DisplayName, opts => opts.MapFrom(src => src.DisplayName))
                    .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(desc => desc.DocSerialNo, opts => opts.MapFrom(src => src.DocSerialNo))
                    .ForMember(desc => desc.DocSystemInd, opts => opts.MapFrom(src => src.DocSystemInd))
                    .ForMember(desc => desc.DocTitle, opts => opts.MapFrom(src => src.DocTitle))
                    .ForMember(desc => desc.DocType, opts => opts.MapFrom(src => src.DocType))
                    .ForMember(desc => desc.DocYear, opts => opts.MapFrom(src => src.DocYear))
                    .ForMember(desc => desc.DraftDateTime, opts => opts.MapFrom(src => src.DraftDateTime))
                    .ForMember(desc => desc.DraftFileName, opts => opts.MapFrom(src => src.DraftFileName))
                    .ForMember(desc => desc.DraftFormName, opts => opts.MapFrom(src => src.DraftFormName))
                    .ForMember(desc => desc.DraftLocation, opts => opts.MapFrom(src => src.DraftLocation))
                    .ForMember(desc => desc.EndorsementType, opts => opts.MapFrom(src => src.EndorsementType))
                    .ForMember(desc => desc.EServiceInd, opts => opts.Ignore())
                    .ForMember(desc => desc.ExpungeInd, opts => opts.MapFrom(src => src.ExpungeInd))
                    .ForMember(desc => desc.FiledBy, opts => opts.MapFrom(src => src.FiledBy))
                    .ForMember(desc => desc.FileType, opts => opts.MapFrom(src => src.FileType))
                    .ForMember(desc => desc.FilingDateTime, opts => opts.MapFrom(src => src.FilingDateTime))
                    .ForMember(desc => desc.FilingType, opts => opts.MapFrom(src => src.FilingType))
                    .ForMember(desc => desc.HRGID, opts => opts.MapFrom(src => src.HRGID))
                    .ForMember(desc => desc.HearingDateTime, opts => opts.MapFrom(src => src.HearingDateTime))
                    .ForMember(desc => desc.HideInd, opts => opts.MapFrom(src => src.HideInd))
                    .ForMember(desc => desc.InTrayDateTime, opts => opts.MapFrom(src => src.InTrayDateTime))
                    .ForMember(desc => desc.IsReplyProcessed, opts => opts.MapFrom(src => src.IsReplyProcessed))
                    .ForMember(desc => desc.IsUrgent, opts => opts.MapFrom(src => src.IsUrgent))
                    .ForMember(desc => desc.IsValidated, opts => opts.MapFrom(src => src.Isvalidated))
                    .ForMember(desc => desc.JOUserIdApprBackDate, opts => opts.MapFrom(src => src.JOUserIdApprBackDate))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(desc => desc.LFWaiverReqFee, opts => opts.MapFrom(src => src.LFWaiverReqFee))
                    .ForMember(desc => desc.LFWaiverReqReason, opts => opts.MapFrom(src => src.LFWaiverReqReason))
                    .ForMember(desc => desc.MailBoxId, opts => opts.Ignore())
                    .ForMember(desc => desc.NoOfAttachments, opts => opts.MapFrom(src => src.NoOfAttachments))
                    .ForMember(desc => desc.NumberOfPages, opts => opts.MapFrom(src => src.NumberOfPages))
                    .ForMember(desc => desc.OCRInd, opts => opts.MapFrom(src => src.OCRInd))
                    .ForMember(desc => desc.ParentDocId, opts => opts.MapFrom(src => src.ParentDocId))
                    .ForMember(desc => desc.ProcessedBy, opts => opts.MapFrom(src => src.ProcessedBy))
                    .ForMember(desc => desc.ProcessedTime, opts => opts.MapFrom(src => src.ProcessedTime))
                    .ForMember(desc => desc.ProcessType, opts => opts.MapFrom(src => src.ProcessType))
                    .ForMember(desc => desc.RecDateTime, opts => opts.MapFrom(src => src.RecDateTime))
                    .ForMember(desc => desc.RecFileName, opts => opts.MapFrom(src => src.RecFileName))
                    .ForMember(desc => desc.RecFormName, opts => opts.MapFrom(src => src.RecFormName))
                    .ForMember(desc => desc.RecLocation, opts => opts.MapFrom(src => src.RecLocation))
                    .ForMember(desc => desc.RelatedDocId, opts => opts.MapFrom(src => src.RelatedDocId))
                    .ForMember(desc => desc.Remarks, opts => opts.MapFrom(src => src.Remarks))
                    .ForMember(desc => desc.RequestDocId, opts => opts.MapFrom(src => src.RequestDocId))
                    .ForMember(desc => desc.SentDateTime, opts => opts.MapFrom(src => src.SentDateTime))
                    .ForMember(desc => desc.SentFileName, opts => opts.MapFrom(src => src.SentFileName))
                    .ForMember(desc => desc.SentFormName, opts => opts.MapFrom(src => src.SentFormName))
                    .ForMember(desc => desc.SentLocation, opts => opts.MapFrom(src => src.SentLocation))
                    .ForMember(desc => desc.SpecHandlingReqInd, opts => opts.MapFrom(src => src.SpecHandlingReqInd))
                    .ForMember(desc => desc.SpecHandlingReqRem, opts => opts.MapFrom(src => src.SpecHandlingReqRem))
                    .ForMember(desc => desc.SpecHandlingReqRsn, opts => opts.MapFrom(src => src.SpecHandlingReqRsn))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.SubmissionSignature, opts => opts.MapFrom(src => src.SubmSignature))
                    .ForMember(desc => desc.Version, opts => opts.MapFrom(src => src.Version))
                    .ForMember(desc => desc.WaiverApprFee, opts => opts.MapFrom(src => src.WaiverApprFee))
                    .ForMember(desc => desc.WaiverApproveInd, opts => opts.MapFrom(src => src.WaiverApproveInd))
                    //.ForMember(desc => desc.WaiverApproveUserId, opts => opts.MapFrom(src => src.WaiverApproveUserId))
                    .ForMember(desc => desc.WaiverApprReason, opts => opts.MapFrom(src => src.WaiverApprReason))
                    .ForMember(desc => desc.WaiverInd, opts => opts.MapFrom(src => src.WaiverInd))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.AutoTestingMode, opts => opts.MapFrom(src => src.AutoTestingMode))
                    .ForMember(desc => desc.JOLInd, opts => opts.MapFrom(src => src.JOLInd))
                     .ForMember(desc => desc.HrgDateToBeFixedInd, opts => opts.MapFrom(src => src.HrgDateToBeFixedInd))
                     .ForMember(desc => desc.IsCrossCourt, opts => opts.MapFrom(src => src.IsCrossCourt))
                     .ForMember(desc => desc.ReqDecision, opts => opts.MapFrom(src => src.ReqDecision))
                     .ForMember(desc => desc.RejectionFeeActionType, opts => opts.MapFrom(src => src.RejectionFeeActionType))
                     .ForMember(desc => desc.IsConfidential, opts => opts.MapFrom(src => src.IsConfidential))
                     .ForMember(desc => desc.DIYSelectbyUser, opts => opts.MapFrom(src => src.DIYSelectbyUser));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocumentInfoEntityToDocumentInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocumentInfo"/> to <see cref="DocumentInfoEntity"/>.
        /// </summary>
        internal void MapDocumentInfoSPToDocumentInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DocumentInfoSP, DocumentInfoEntity>()
                    .ForMember(desc => desc.ActualFilingDateTime, opts => opts.MapFrom(src => src.ActualFilingDateTime))
                    .ForMember(desc => desc.BackdateApprInd, opts => opts.MapFrom(src => src.BackdateApprInd))
                    .ForMember(desc => desc.BackDateReasonFrCourt, opts => opts.MapFrom(src => src.BackDateReasonFrCourt))
                    .ForMember(desc => desc.BackDateReasonFrLawFirm, opts => opts.MapFrom(src => src.BackDateReasonFrLawFirm))
                    .ForMember(desc => desc.BackDateTime, opts => opts.MapFrom(src => src.BackDateTime))
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.DisplayName, opts => opts.MapFrom(src => src.DisplayName))
                    .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DOCID))
                    .ForMember(desc => desc.DocSerialNo, opts => opts.MapFrom(src => src.DocSerialNo))
                    .ForMember(desc => desc.DocSystemInd, opts => opts.MapFrom(src => src.DocSystemInd))
                    .ForMember(desc => desc.DocTitle, opts => opts.MapFrom(src => src.DocTitle))
                    .ForMember(desc => desc.DocType, opts => opts.MapFrom(src => src.DocType))
                    .ForMember(desc => desc.DocYear, opts => opts.MapFrom(src => src.DocYear))
                    .ForMember(desc => desc.DraftDateTime, opts => opts.MapFrom(src => src.DraftDateTime))
                    .ForMember(desc => desc.DraftFileName, opts => opts.MapFrom(src => src.DraftFileName))
                    .ForMember(desc => desc.DraftFormName, opts => opts.MapFrom(src => src.DraftFormName))
                    .ForMember(desc => desc.DraftLocation, opts => opts.MapFrom(src => src.DraftLocation))
                    .ForMember(desc => desc.EndorsementType, opts => opts.MapFrom(src => src.EndorsementType))
                    .ForMember(desc => desc.EServiceInd, opts => opts.Ignore())
                    .ForMember(desc => desc.ExpungeInd, opts => opts.MapFrom(src => src.ExpungeInd))
                    .ForMember(desc => desc.FiledBy, opts => opts.MapFrom(src => src.FiledBy))
                    .ForMember(desc => desc.FileType, opts => opts.MapFrom(src => src.FileType))
                    .ForMember(desc => desc.FilingDateTime, opts => opts.MapFrom(src => src.FilingDateTime))
                    .ForMember(desc => desc.FilingType, opts => opts.MapFrom(src => src.FilingType))
                    .ForMember(desc => desc.HRGID, opts => opts.MapFrom(src => src.HRGID))
                    .ForMember(desc => desc.HearingDateTime, opts => opts.MapFrom(src => src.HearingDateTime))
                    .ForMember(desc => desc.HideInd, opts => opts.MapFrom(src => src.HideInd))
                    .ForMember(desc => desc.InTrayDateTime, opts => opts.MapFrom(src => src.InTrayDateTime))
                    .ForMember(desc => desc.IsReplyProcessed, opts => opts.MapFrom(src => src.IsReplyProcessed))
                    .ForMember(desc => desc.IsUrgent, opts => opts.MapFrom(src => src.IsUrgent))
                    .ForMember(desc => desc.IsValidated, opts => opts.MapFrom(src => src.IsValidated))
                    .ForMember(desc => desc.JOUserIdApprBackDate, opts => opts.MapFrom(src => src.JOUserIdApprBackDate))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(desc => desc.LFWaiverReqFee, opts => opts.MapFrom(src => src.LFWaiverReqFee))
                    .ForMember(desc => desc.LFWaiverReqReason, opts => opts.MapFrom(src => src.LFWaiverReqReason))
                    .ForMember(desc => desc.MailBoxId, opts => opts.Ignore())
                    .ForMember(desc => desc.NoOfAttachments, opts => opts.MapFrom(src => src.NoOfAttachments))
                    .ForMember(desc => desc.NumberOfPages, opts => opts.MapFrom(src => src.NumberOfPages))
                    .ForMember(desc => desc.OCRInd, opts => opts.MapFrom(src => src.OCRInd))
                    .ForMember(desc => desc.ParentDocId, opts => opts.MapFrom(src => src.ParentDocId))
                    .ForMember(desc => desc.ProcessedBy, opts => opts.MapFrom(src => src.ProcessedBy))
                    .ForMember(desc => desc.ProcessedTime, opts => opts.MapFrom(src => src.ProcessedTime))
                    .ForMember(desc => desc.ProcessType, opts => opts.MapFrom(src => src.ProcessType))
                    .ForMember(desc => desc.RecDateTime, opts => opts.MapFrom(src => src.RecDateTime))
                    .ForMember(desc => desc.RecFileName, opts => opts.MapFrom(src => src.RecFileName))
                    .ForMember(desc => desc.RecFormName, opts => opts.MapFrom(src => src.RecFormName))
                    .ForMember(desc => desc.RecLocation, opts => opts.MapFrom(src => src.RecLocation))
                    .ForMember(desc => desc.RelatedDocId, opts => opts.MapFrom(src => src.RelatedDocID))
                    .ForMember(desc => desc.Remarks, opts => opts.MapFrom(src => src.Remarks))
                    .ForMember(desc => desc.RequestDocId, opts => opts.MapFrom(src => src.RequestDocID))
                    .ForMember(desc => desc.SentDateTime, opts => opts.MapFrom(src => src.SentDateTime))
                    .ForMember(desc => desc.SentFileName, opts => opts.MapFrom(src => src.SentFileName))
                    .ForMember(desc => desc.SentFormName, opts => opts.MapFrom(src => src.SentFormName))
                    .ForMember(desc => desc.SentLocation, opts => opts.MapFrom(src => src.SentLocation))
                    .ForMember(desc => desc.SpecHandlingReqInd, opts => opts.MapFrom(src => src.SpecHandlingReqInd))
                    .ForMember(desc => desc.SpecHandlingReqRem, opts => opts.MapFrom(src => src.SpecHandlingReqRem))
                    .ForMember(desc => desc.SpecHandlingReqRsn, opts => opts.MapFrom(src => src.SpecHandlingReqRsn))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupID))
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.SubmissionSignature, opts => opts.MapFrom(src => src.SubmSignature))
                    .ForMember(desc => desc.Version, opts => opts.MapFrom(src => src.Version))
                    .ForMember(desc => desc.WaiverApprFee, opts => opts.MapFrom(src => src.WaiverApprFee))
                    .ForMember(desc => desc.WaiverApproveInd, opts => opts.MapFrom(src => src.WaiverApproveInd))

                    .ForMember(desc => desc.WaiverApprReason, opts => opts.MapFrom(src => src.WaiverApprReason))
                    .ForMember(desc => desc.WaiverInd, opts => opts.MapFrom(src => src.WaiverInd))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.AutoTestingMode, opts => opts.MapFrom(src => src.AutoTestingMode))
                    .ForMember(desc => desc.JOLInd, opts => opts.MapFrom(src => src.JOLInd))
                     .ForMember(desc => desc.HrgDateToBeFixedInd, opts => opts.MapFrom(src => src.HrgDateToBeFixedInd))
                     .ForMember(desc => desc.IsCrossCourt, opts => opts.MapFrom(src => src.IsCrossCourt))
                     .ForMember(desc => desc.ReqDecision, opts => opts.MapFrom(src => src.ReqDecision))
                     .ForMember(desc => desc.RejectionFeeActionType, opts => opts.MapFrom(src => src.RejectionFeeActionType))
                     .ForMember(desc => desc.IsConfidential, opts => opts.MapFrom(src => src.IsConfidential))
                     .ForMember(desc => desc.DIYSelectbyUser, opts => opts.MapFrom(src => src.DIYSelectbyUser));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocumentInfoEntityToDocumentInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RDocCaseParty"/> to <see cref="RDocCasePartyEntity"/>.
        /// </summary>
        internal void MapRDocCasePartyToRDocCasePartyEntity()
        {
            try
            {
                Mapper.CreateMap<RDocCaseParty, RDocCasePartyEntity>()
                   .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                   .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
                   .ForMember(desc => desc.RDCPId, opts => opts.MapFrom(src => src.RDCPId))
                   .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                   .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                   .ForMember(desc => desc.UpdateInd, opts => opts.MapFrom(src => src.UpdateInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRDocCasePartyToRDocCasePartyEntity", ex);
                throw;
            }
        }

        internal void MapRDocCaseToRDocCaseEntity()
        {
            try
            {
                Mapper.CreateMap<RDocCase, RDocCaseEntity>()

                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(desc => desc.IsOriginal, opts => opts.MapFrom(src => src.IsOriginal))
                    .ForMember(desc => desc.IsPreceding, opts => opts.MapFrom(src => src.IsPreceding))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.RefDocId, opts => opts.MapFrom(src => src.RefDocId))
                    .ForMember(desc => desc.RefDocNumber, opts => opts.MapFrom(src => src.RefDocNumber))
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRDocCaseToRDocCaseEntity", ex);
                throw;
            }
        }

        internal void MapDocCommentsToDocCommentsEntity()
        {
            try
            {
                Mapper.CreateMap<DocComments, DocCommentsEntity>()
                    .ForMember(dest => dest.CommentId, opts => opts.MapFrom(src => src.CommentID))
                    .ForMember(dest => dest.CommentType, opts => opts.MapFrom(src=>src.CommentType))
                    .ForMember(dest => dest.LocationId, opts => opts.MapFrom(src => src.LocationID));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocCommentsToDocCommentsEntity", ex);
                throw;
            }
        }

        internal void MapDocCaseTierTypeToDocCaseTierTypeEntity()
        {
            try
            {
                Mapper.CreateMap<DocCaseTierType, DocCaseTierTypeEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocCaseTierTypeToDocCaseTierTypeEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LawFirmDocCaseFileRefNumber"/> to <see cref="LawFirmDocCaseFileRefNumberEntity"/>.
        /// </summary>
        internal void MapLawFirmDocCaseFileRefNumberToLawFirmDocCaseFileRefNumberEntity()
        {
            try
            {
                Mapper.CreateMap<LawFirmDocCaseFileRefNumber, LawFirmDocCaseFileRefNumberEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.LFFileRefNumber, opts => opts.MapFrom(src => src.LFFileRefNumber))
                    .ForMember(desc => desc.LFDCFRNId, opts => opts.MapFrom(src => src.LFDCFRNId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLawFirmDocCaseFileRefNumberToLawFirmDocCaseFileRefNumberEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the document party case file reference number to document party case file reference number entity.
        /// </summary>
        internal void MapDocPartyCaseFileRefNumberToDocPartyCaseFileRefNumberEntity()
        {
            try
            {
                Mapper.CreateMap<DocPartyCaseFileRefNumber, DocPartyCaseFileRefNumberEntity>()
                    .ForMember(desc => desc.CaseInfoID, opts => opts.MapFrom(src => src.CaseInfoID))
                    .ForMember(desc => desc.DocPartyCaseFileRefNumberId, opts => opts.MapFrom(src => src.DocPartyCaseFileRefNumberId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LFFileRefNumber, opts => opts.MapFrom(src => src.LFFileRefNumber));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocPartyCaseFileRefNumberToDocPartyCaseFileRefNumberEntity", ex);
                throw;
            }
        }

        internal void MapTemp_ProcessingInfoToTemp_ProcessingInfoEntity()
        {
            try
            {
                Mapper.CreateMap<Temp_ProcessingInfo, Temp_ProcessingInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapTemp_ProcessingInfoToTemp_ProcessingInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// RDocCounterClaimFiled.
        /// </summary>
        internal void MapRDocCounterClaimFiledToRDocCounterClaimFiledEntity()
        {
            try
            {
                Mapper.CreateMap<RDocCounterClaimFiled, RDocCounterClaimFiledEntity>()
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocPartyCaseFileRefNumberToDocPartyCaseFileRefNumberEntity", ex);
                throw;
            }
        }

        #endregion Methods
    }
}