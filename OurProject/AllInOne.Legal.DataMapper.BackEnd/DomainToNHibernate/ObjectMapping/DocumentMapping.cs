#region Header

/*****************************************************************************************************
* Description : This file represents the mapping of objects for Document entities. This class will map
* Object to Entity.
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
// File: DocumentMapping.cs
// Description: This file represents the mapping of objects for Document entities. This class will map
// Object to Entity.
// </summary>
// <copyright file= "DocumentMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    internal class DocumentMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DocumentMapping));

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseToCaseEntityMapping"/> class.
        /// </summary>
        internal DocumentMapping()
        {
            //this.DomainToNHibernateEntityMapping();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Map Document Party Address domain object to NHibernate entity 
        /// </summary>
        internal void MapDocCasePartyAddressEntityToDocCasePartyAddress()
        {
            Mapper.CreateMap<DocCasePartyAddressEntity, DocCasePartyAddress>()
                .ForMember(desc => desc.Addr1, opts => opts.MapFrom(src => src.Addr1))
                .ForMember(desc => desc.Addr2, opts => opts.MapFrom(src => src.Addr2))
                .ForMember(desc => desc.Addr3, opts => opts.MapFrom(src => src.Addr3))
                .ForMember(desc => desc.Addr4, opts => opts.MapFrom(src => src.Addr4))
                .ForMember(desc => desc.Address, opts => opts.MapFrom(src => src.Address))
                .ForMember(desc => desc.AddrType, opts => opts.ResolveUsing<AddressTypeToStringResolver>().FromMember(src => src.AddrType))
                .ForMember(desc => desc.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                .ForMember(desc => desc.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                .ForMember(desc => desc.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
                .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                .ForMember(desc => desc.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                .ForMember(desc => desc.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.LastStayedInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.LastStayedInd))
                .ForMember(desc => desc.MailingInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MailingInd))
                .ForMember(desc => desc.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId))
                .ForMember(desc => desc.StreetName, opts => opts.MapFrom(src => src.StreetName))
                .ForMember(desc => desc.UnitNo, opts => opts.MapFrom(src => src.UnitNo));
        }

        /// <summary>
        /// Map Document Party Address domain object to NHibernate entity 
        /// </summary>
        internal void MapDocCasePartyAICAddressToCasePartyAICAddressEntity()
        {
            Mapper.CreateMap<DocCasePartyAICAddressEntity, DocCasePartyAICAddress>()
                .ForMember(desc => desc.Addr1, opts => opts.MapFrom(src => src.Addr1))
                .ForMember(desc => desc.Addr2, opts => opts.MapFrom(src => src.Addr2))
                .ForMember(desc => desc.Addr3, opts => opts.MapFrom(src => src.Addr3))
                .ForMember(desc => desc.Addr4, opts => opts.MapFrom(src => src.Addr4))
                .ForMember(desc => desc.Address, opts => opts.MapFrom(src => src.Address))
                .ForMember(desc => desc.AddrType, opts => opts.ResolveUsing<AddressTypeToStringResolver>().FromMember(src => src.AddrType))
                .ForMember(desc => desc.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                .ForMember(desc => desc.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                .ForMember(desc => desc.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
                .ForMember(desc => desc.DCPAICID, opts => opts.MapFrom(src => src.DCPAICID))
                .ForMember(desc => desc.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                .ForMember(desc => desc.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId))
                .ForMember(desc => desc.StreetName, opts => opts.MapFrom(src => src.StreetName))
                .ForMember(desc => desc.UnitNo, opts => opts.MapFrom(src => src.UnitNo));
        }

        /// <summary>
        /// Map Document Party AIC Alias domain object to NHibernate entity 
        /// </summary>
        internal void MapDocCasePartyAICAliasEntityToDocCasePartyAICAlias()
        {
            Mapper.CreateMap<DocCasePartyAICAliasEntity, DocCasePartyAICAlias>()
                .ForMember(desc => desc.AliasName, opts => opts.MapFrom(src => src.AliasName))
                .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                .ForMember(desc => desc.DCPAICID, opts => opts.MapFrom(src => src.DCPAICID))
                .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
        }

        /// <summary>
        /// Map Document Party AIC Detail domain object to NHibernate entity 
        /// </summary>
        internal void MapDocCasePartyAICDetailEntityToDocCasePartyAICDetail()
        {
            Mapper.CreateMap<DocCasePartyAICDetailsEntity, DocCasePartyAICDetail>()
                .ForMember(desc => desc.AddressAvailabilityInd, opts => opts.ResolveUsing<AddressAvailabilityTypeToStringResolver>().FromMember(src => src.AddressAvailabilityInd))
                .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                .ForMember(desc => desc.DCPAICID, opts => opts.MapFrom(src => src.DCPAICID))
                .ForMember(desc => desc.DocCasePartyAICAddresses, opts => opts.Ignore())
                .ForMember(desc => desc.DocCasePartyAICAliases, opts => opts.Ignore())
                .ForMember(desc => desc.FormerCompanyName, opts => opts.MapFrom(src => src.FormerCompanyName))
                .ForMember(desc => desc.FormerPersonName, opts => opts.MapFrom(src => src.FormerPersonName))
                .ForMember(desc => desc.FullName, opts => opts.MapFrom(src => src.FullName))
                .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                .ForMember(desc => desc.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                .ForMember(desc => desc.PortOfRegistration, opts => opts.MapFrom(src => src.PortOfRegistration))
                .ForMember(desc => desc.VesselName, opts => opts.MapFrom(src => src.VesselName))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.VesselIdType, opts => opts.ResolveUsing<VesselIdTypeToStringResolver>().FromMember(src => src.VesselIdType));
        }

        /// <summary>
        /// Map Document Party Alias domain object to NHibernate entity 
        /// </summary>
        internal void MapDocCasePartyAliasEntityToDocCasePartyAlias()
        {
            Mapper.CreateMap<DocCasePartyAliasEntity, DocCasePartyAlias>()
                .ForMember(desc => desc.AliasName, opts => opts.MapFrom(src => src.AliasName))
                .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
        }

        /// <summary>
        /// Maps objects from <see cref="DocCasePartyBailorAddressEntity"/> to <see cref="DocCasePartyBailorAddress"/>.
        /// </summary>
        internal void MapDocCasePartyBailorAddressEntityToDocCasePartyBailorAddress()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyBailorAddressEntity, DocCasePartyBailorAddress>()
                    .ForMember(desc => desc.MailingInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MailingInd))
                    .ForMember(desc => desc.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                    .ForMember(desc => desc.AddrType, opts => opts.ResolveUsing<AddressTypeToStringResolver>().FromMember(src => src.AddrType));
                //.ForMember(desc => desc.DocCasePartyBailorInfo, opts => opts.ResolveUsing<StringToDocCasePartyBailorInfoResolver>().FromMember(src => src.DocCasePartyBailorInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyBailorAddressEntityToDocCasePartyBailorAddress", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="DocCasePartyBailorInfoEntity"/> to <see cref="DocCasePartyBailorInfo"/>.
        /// </summary>
        internal void MapDocCasePartyBailorInfoEntityToDocCasePartyBailorInfo()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyBailorInfoEntity, DocCasePartyBailorInfo>()
                    .ForMember(desc => desc.ContactTypeInd, opts => opts.ResolveUsing<ContactTypeToStringResolver>().FromMember(src => src.ContactTypeInd));
                //.ForMember(desc => desc.DocCaseParty, opts => opts.ResolveUsing<StringToDocCasePartyResolver>().FromMember(src => src.DCPID));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyBailorInfoEntityToDocCasePartyBailorInfo", ex);
                throw;
            }
        }

        /** End of For Criminal Entities **/
        /// <summary>
        /// Maps objects from <see cref="DocCasePartyCitizenshipEntity"/> to <see cref="DocCasePartyCitizenship"/>.
        /// </summary>
        internal void MapDocCasePartyCitizenshipEntityToDocCasePartyCitizenship()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyCitizenshipEntity, DocCasePartyCitizenship>()
                    .ForMember(dest => dest.DCPCitizenshipId, opts => opts.MapFrom(src => src.DocCasePartyCitizenshipId))
                    //.ForMember(desc => desc.DocCaseParty, opts => opts.ResolveUsing<StringToDocCasePartyResolver>().FromMember(src => src.DCPID))
                    .ForMember(desc => desc.CitizenshipStatus, opts => opts.ResolveUsing<CitizenshipStatusToStringResolver>().FromMember(src => src.CitizenshipStatus));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyDocCitizenshipEntityToDocCasePartyCitizenship", ex);
                throw;
            }
        }

        /** For Criminal Entities **/
        /// <summary>
        /// Maps objects from <see cref="DocCasePartyCriminalInfoEntity"/> to <see cref="DocCasePartyCriminalInfo"/>.
        /// </summary>
        internal void MapDocCasePartyCriminalInfoEntityToDocCasePartyCriminalInfo()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyCriminalInfoEntity, DocCasePartyCriminalInfo>()
                    .ForMember(desc => desc.PartyInType, opts => opts.ResolveUsing<PartyInTypeToStringResolver>().FromMember(src => src.PartyInType))
                    //.ForMember(desc => desc.DocCaseParty, opts => opts.ResolveUsing<StringToDocCasePartyResolver>().FromMember(src => src.DCPID))
                    .ForMember(desc => desc.MPrisonCustodyPrisonCode, opts => opts.MapFrom(src => src.MPrisonCustody))
                    .ForMember(desc => desc.MPrisonRemandPrisonCode, opts => opts.MapFrom(src => src.MPrisonRemand));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocCasePartyCriminalInfoEntityToDocCasePartyCriminalInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DocCasePartyLACDetailEntity"/> to <see cref="DocCasePartyLACDetail"/>.
        /// </summary>
        internal void MapDocCasePartyLACDetailEntityToDocCasePartyLACDetail()
        {
            try
            {
                Mapper.CreateMap<DocCasePartyLACDetailEntity, DocCasePartyLACDetail>()
                    .ForMember(desc => desc.DCPLACDetailId, opts => opts.MapFrom(src => src.DCPLACDetailId))
                    .ForMember(dest => dest.DocCaseParty, opts => opts.ResolveUsing<StringToDocCasePartyResolver>().FromMember(src => src.DCPID))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.FiledUserType, opts => opts.ResolveUsing<FiledUserTypeToStringResolver>().FromMember(src => src.FiledUserType))
                    .ForMember(dest => dest.LACDocDetailId, opts => opts.MapFrom(src => src.LACDocDetailId))
                    .ForMember(dest => dest.LACInfoId, opts => opts.MapFrom(src => src.LACInfoId))
                    .ForMember(dest => dest.LACRefStatus, opts => opts.ResolveUsing<LACRefStatusToStringResolver>().FromMember(src => src.LACRefStatus))
                    .ForMember(dest => dest.LFGroupCode, opts => opts.ResolveUsing<LFGroupCodeToStringResolver>().FromMember(src => src.LFGroupCode));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocCasePartyLACDetailEntityToDocCasePartyLACDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Map Document Party AIC Detail domain object to NHibernate entity 
        /// </summary>
        internal void MapDocCasePartyOfficerDetailEntityToDocCasePartyOfficerDetail()
        {
            Mapper.CreateMap<DocCasePartyAuthorisedOfficerDetailsEntity, DocCasePartyAuthorisedOfficerDetail>()
               .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
               .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
               .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
               .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
               .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
               .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
               .ForMember(desc => desc.Name, opts => opts.MapFrom(src => src.Name))
               .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
        }

        /// <summary>
        /// Map Document Case Party domain object to NHibernate entity 
        /// </summary>
        internal void MapDocCasePartyToDocCasePartyEntity()
        {
            Mapper.CreateMap<DocCasePartyEntity, DocCaseParty>()
                .ForMember(desc => desc.ApplicantCapacityRemarks, opts => opts.MapFrom(src => src.ApplicantCapacityRemarks))
                .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                .ForMember(desc => desc.BirthCountryRemarks, opts => opts.MapFrom(src => src.BirthCountryRemarks))
                .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                .ForMember(desc => desc.CompanyName, opts => opts.MapFrom(src => src.CompanyName))
                .ForMember(desc => desc.ContactTypeInd, opts => opts.ResolveUsing<ContactTypeToStringResolver>().FromMember(src => src.ContactTypeInd))
                .ForMember(desc => desc.DateOfBirth, opts => opts.MapFrom(src => src.DateOfBirth))
                .ForMember(desc => desc.DateOfRegistration, opts => opts.MapFrom(src => src.DateOfRegistration))
                .ForMember(desc => desc.DateofService, opts => opts.MapFrom(src => src.DateofService))
                .ForMember(desc => desc.DialectRemarks, opts => opts.MapFrom(src => src.DialectRemarks))
                .ForMember(desc => desc.DisablePersonInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.DisablePersonInd))
                .ForMember(desc => desc.DisablePersonRemarks, opts => opts.MapFrom(src => src.DisablePersonRemarks))
                .ForMember(desc => desc.Email, opts => opts.MapFrom(src => src.Email))
                .ForMember(desc => desc.FaxAreaCode, opts => opts.MapFrom(src => src.FaxAreaCode))
                .ForMember(desc => desc.FaxCountryCode, opts => opts.MapFrom(src => src.FaxCountryCode))
                .ForMember(desc => desc.FaxNumber, opts => opts.MapFrom(src => src.FaxNumber))
                .ForMember(desc => desc.FilingInd, opts => opts.ResolveUsing<FilingPartyIndToStringResolver>().FromMember(src => src.FilingInd))
                .ForMember(desc => desc.FormerCompanyName, opts => opts.MapFrom(src => src.FormerCompanyName))
                .ForMember(desc => desc.FormerPersonName, opts => opts.MapFrom(src => src.FormerPersonName))
                .ForMember(desc => desc.FullName, opts => opts.MapFrom(src => src.FullName))
                .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                .ForMember(desc => desc.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                .ForMember(desc => desc.InvolvementInd, opts => opts.ResolveUsing<InvolvementIndToStringResolver>().FromMember(src => src.InvolvementInd))
                .ForMember(desc => desc.HasLAC, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasLAC)) //Check
                .ForMember(desc => desc.IsPartyServiedWrit, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPartyServiedWrit))
                .ForMember(desc => desc.IsSingaporePR, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSingaporeanPR))
                .ForMember(desc => desc.LanguageCode, opts => opts.MapFrom(src => src.LanguageCode))
                .ForMember(desc => desc.LanguageRemarks, opts => opts.MapFrom(src => src.LanguageRemarks))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.LFAddressId, opts => opts.MapFrom(src => src.LFAddressId))
                .ForMember(desc => desc.LFId, opts => opts.Ignore())//Check
                .ForMember(desc => desc.MobileCountryCode, opts => opts.MapFrom(src => src.MobileCountryCode))
                .ForMember(desc => desc.MobileNumber, opts => opts.MapFrom(src => src.MobileNumber))
                .ForMember(desc => desc.NationalityRemarks, opts => opts.MapFrom(src => src.NationalityRemarks))
                .ForMember(desc => desc.OccupationRemarks, opts => opts.MapFrom(src => src.OccupationRemarks))
                .ForMember(desc => desc.OrdinalNumber, opts => opts.MapFrom(src => src.OrdinalNumber))
                .ForMember(desc => desc.PartyNo, opts => opts.MapFrom(src => src.PartyNo))
                .ForMember(desc => desc.RaceRemarks, opts => opts.MapFrom(src => src.RaceRemarks))
                .ForMember(desc => desc.RefDCPID, opts => opts.MapFrom(src => src.RefDCPID))
                //.ForMember(desc => desc.MRelationship, opts => opts.MapFrom(src => src.MRelationship))
                .ForMember(desc => desc.RelationshipRemarks, opts => opts.MapFrom(src => src.RelationshipRemarks))
                .ForMember(desc => desc.ReligionRemarks, opts => opts.MapFrom(src => src.ReligionRemarks))
                .ForMember(desc => desc.TelAreaCode, opts => opts.MapFrom(src => src.TelAreaCode))
                .ForMember(desc => desc.TelCountryCode, opts => opts.MapFrom(src => src.TelCountryCode))
                .ForMember(desc => desc.TelNumber, opts => opts.MapFrom(src => src.TelNumber))
                .ForMember(desc => desc.UpdateInd, opts => opts.ResolveUsing<PartyUpdateIndToStringResolver>().FromMember(src => src.UpdateInd))
                .ForMember(desc => desc.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                .ForMember(desc => desc.SubCaseOrdinalNumber, opts => opts.MapFrom(src => src.SubCaseOrdinalNumber))
                .ForMember(desc => desc.SubCasePartyUpdateInd, opts => opts.ResolveUsing<PartyUpdateIndToStringResolver>().FromMember(src => src.SubCasePartyUpdateInd))
                .ForMember(desc => desc.MSubCasePartyTypeCode, opts => opts.MapFrom(src => src.MSubCasePartyType))

                .ForMember(desc => desc.UEN, opts => opts.MapFrom(src => src.UEN))
                .ForMember(desc => desc.CapacityInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CapacityInd))
                 .ForMember(desc => desc.VesselIDType, opts => opts.ResolveUsing<VesselIdTypeToStringResolver>().FromMember(src => src.VesselIDType))
                 .ForMember(desc => desc.RoleCode, opts => opts.ResolveUsing<RoleCodeToStringResolver>().FromMember(src => src.RoleCode))
                 .ForMember(desc => desc.IsSubCaseOnlyParty, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSubCaseOnlyParty))
                 .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd)); 
        }

        /// <summary>
        /// Map Document Party Vesse Detail domain object to NHibernate entity 
        /// </summary>
        internal void MapDocCasePartyVesselDetailEntityToDocCasePartyVesselDetail()
        {
            Mapper.CreateMap<DocCasePartyVesselDetailsEntity, DocCasePartyVesselDetail>()
               .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
               .ForMember(desc => desc.Description, opts => opts.MapFrom(src => src.Description))
               .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
               .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
               .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
               .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
        }

        /// <summary>
        /// Map Case Party Solicitor domain entity to NHibernate object
        /// </summary>
        internal void MapDocCaseSolicitorToCaseSolicitorEntity()
        {
            Mapper.CreateMap<DocCaseSolicitorEntity, DocCaseSolicitor>()
                .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src=>src.CaseInfoId))
                .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
                .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFId))
                .ForMember(desc => desc.RefRecId, opts => opts.MapFrom(src => src.RefRecId))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.RepresentedBy, opts => opts.ResolveUsing<CasePartyRepresentedByToStringResolver>().FromMember(src => src.RepresentedBy))
                .ForMember(desc => desc.SolicitorId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SolicitorId))
                .ForMember(desc => desc.StartDate, opts => opts.MapFrom(src => src.StartDate))
                .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId))
                .ForMember(desc => desc.JACInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.JACInd))
                .ForMember(desc => desc.LASCOInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.LASCOInd))
                .ForMember(desc => desc.CLASInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CLASInd))
                .ForMember(desc => desc.ACLASInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ACLASInd))
                .ForMember(desc => desc.DateAppointed, opts => opts.MapFrom(src => src.DateAppointed))
                .ForMember(desc => desc.DateDischarged, opts => opts.MapFrom(src => src.DateDischarged))
                .ForMember(desc => desc.CounselInd, opts => opts.ResolveUsing<CriminalCounselTypesToStringResolver>().FromMember(src => src.CounselInd))
                .ForMember(desc => desc.BriefInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.BriefInd))
                ;
        }

        internal void MapDocGCRDetailsEntityToDocGCRDetails()
        {
            try
            {
                Mapper.CreateMap<DocGCRDetailsEntity, DocGCRDetails>()
                    .ForMember(desc => desc.LawFirm, opts => opts.Ignore())
                    .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(desc => desc.LFId, opts => opts.MapFrom(src => src.LFId))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.DocumentInfo, opts => opts.Ignore())
                    .ForMember(desc => desc.SentCopy, opts => opts.ResolveUsing<OutgoingCorrespondanceSentCopyToStringResolver>().FromMember(src => src.SentCopy))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRDocCaseEntityToRDocCase", ex);
                throw;
            }
        }

        internal void MapDocOrderDetailEntityToDocOrderDetail()
        {
            try
            {
                Mapper.CreateMap<DocOrderDetailsEntity, DocOrderDetail>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.FilingOrderFor, opts => opts.ResolveUsing<FilingOrderForToStringResolver>().FromMember(src => src.FilingOrderFor))
                    .ForMember(dest => dest.IsAutoOrManual, opts => opts.MapFrom(src => src.IsAutoOrManual))
                    .ForMember(dest => dest.OrderMadeIn, opts => opts.ResolveUsing<OrderMadeInToStringResolver>().FromMember(src => src.OrderMadeIn))
                     .ForMember(dest => dest.PenalNotice, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PenalNotice))
                     .ForMember(dest => dest.PrepopulateOOC, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PrepopulateOOC))
                     .ForMember(dest => dest.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                      .ForMember(dest => dest.JudgmentFor, opts => opts.ResolveUsing<JudgmentForToStringResolver>().FromMember(src => src.JudgmentFor))
                     .ForMember(dest => dest.FilingFrom, opts => opts.ResolveUsing<FilingFromToStringResolver>().FromMember(src => src.FilingFrom))
                     .ForMember(dest => dest.SchedulerProcessStatus, opts => opts.ResolveUsing<SchedulerProcessStatusToStringResolver>().FromMember(src => src.SchedulerProcessStatus))
                     .ForMember(dest => dest.ConsentOrder, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ConsentOrder))
                     .ForMember(dest => dest.OrderForExamination, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.OrderForExamination))
                     .ForMember(dest => dest.IsCWUOrder, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCWUOrder));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocOrderDetailEntityToDocOrderDetail", ex);
                throw;
            }
        }

        internal void MapDocumentBatesListEntityToDocumentBatesList()
        {
            try
            {
                Mapper.CreateMap<DocumentBatesListEntity, DocumentBatesList>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src=>src.CaseInfoId))
                    .ForMember(dest => dest.Submissiongroupid, opts => opts.MapFrom(src => src.SubmissiongroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocumentBatesListEntityToDocumentBatesList", ex);
                throw;
            }
        }

        /// <summary>
        /// Map Document Info domain object to NHibernate entity 
        /// </summary>
        internal void MapDocumentInfoEntityToDocumentInfo()
        {
            Mapper.CreateMap<DocumentInfoEntity, DocumentInfo>()

                .ForMember(desc => desc.ActualFilingDateTime, opts => opts.MapFrom(src => src.ActualFilingDateTime))

                .ForMember(desc => desc.BackDateApprInd, opts => opts.ResolveUsing<BackdateStatusToStringResolver>().FromMember(src => src.BackdateApprInd))
                .ForMember(desc => desc.BackDateReasonFrCourt, opts => opts.MapFrom(src => src.BackDateReasonFrCourt))
                .ForMember(desc => desc.BackDateReasonFrLawFirm, opts => opts.MapFrom(src => src.BackDateReasonFrLawFirm))
                .ForMember(desc => desc.BackDateTime, opts => opts.MapFrom(src => src.BackDateTime))
                .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))


                .ForMember(desc => desc.DisplayName, opts => opts.MapFrom(src => src.DisplayName))

                .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))

                .ForMember(desc => desc.DocSerialNo, opts => opts.MapFrom(src => src.DocSerialNo))
                .ForMember(desc => desc.DocSystemInd, opts => opts.ResolveUsing<SystemIndToStringResolver>().FromMember(src => src.DocSystemInd))
                .ForMember(desc => desc.DocTitle, opts => opts.MapFrom(src => src.DocTitle))
                .ForMember(desc => desc.DocType, opts => opts.MapFrom(src => src.DocType))
                .ForMember(desc => desc.DocYear, opts => opts.MapFrom(src => src.DocYear))
                .ForMember(desc => desc.DraftDateTime, opts => opts.MapFrom(src => src.DraftDateTime))
                .ForMember(desc => desc.DraftFileName, opts => opts.MapFrom(src => src.DraftFileName))
                .ForMember(desc => desc.DraftFileSize, opts => opts.MapFrom(src => src.DraftFileSize))
                .ForMember(desc => desc.DraftFNID, opts => opts.MapFrom(src => src.DraftFNID))
                .ForMember(desc => desc.DraftFormName, opts => opts.MapFrom(src => src.DraftFormName))
                .ForMember(desc => desc.DraftLocation, opts => opts.MapFrom(src => src.DraftLocation))
                .ForMember(desc => desc.DraftProcessType, opts => opts.Ignore())//MapFrom(src => src.DraftProcessType))
                .ForMember(desc => desc.EndorsementType, opts => opts.ResolveUsing<EndorsementTypeToStringResolver>().FromMember(src => src.EndorsementType))
                 .ForMember(desc => desc.ExpungeInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ExpungeInd))
                .ForMember(desc => desc.FECopy, opts => opts.MapFrom(src => src.FECopy))
                .ForMember(desc => desc.FiledBy, opts => opts.MapFrom(src => src.FiledBy))
                .ForMember(desc => desc.FileType, opts => opts.ResolveUsing<DocumentFileTypeToStringResolver>().FromMember(src => src.FileType))
                .ForMember(desc => desc.FilingDateTime, opts => opts.MapFrom(src => src.FilingDateTime))
                .ForMember(desc => desc.FilingType, opts => opts.ResolveUsing<DocumentFilingTypeToStringResolver>().FromMember(src => src.FilingType))



                .ForMember(desc => desc.HRGID, opts => opts.MapFrom(src => src.HRGID))
                //.ForMember(desc => desc.HRGID, opts => opts.ResolveUsing<Int64ToStringHearingResolver>().FromMember(src => src.HRGID))
                .ForMember(desc => desc.HearingDateTime, opts => opts.MapFrom(src => src.HearingDateTime))
                .ForMember(desc => desc.HideInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HideInd))
                .ForMember(desc => desc.InTrayDateTime, opts => opts.MapFrom(src => src.InTrayDateTime))
                .ForMember(desc => desc.IsReplyProcessed, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsReplyProcessed))
                .ForMember(desc => desc.IsUrgent, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsUrgent))
                .ForMember(desc => desc.Isvalidated, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsValidated))
                .ForMember(desc => desc.JOUserIdApprBackDate, opts => opts.MapFrom(src => src.JOUserIdApprBackDate))



                 .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFID))
                .ForMember(desc => desc.LFWaiverReqFee, opts => opts.MapFrom(src => src.LFWaiverReqFee))
                .ForMember(desc => desc.LFWaiverReqReason, opts => opts.MapFrom(src => src.LFWaiverReqReason))

                .ForMember(desc => desc.NoOfAttachments, opts => opts.MapFrom(src => src.NoOfAttachments))
                .ForMember(desc => desc.NumberOfPages, opts => opts.MapFrom(src => src.NumberOfPages))
                .ForMember(desc => desc.OCRInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.OCRInd))
                .ForMember(desc => desc.ParentDocId, opts => opts.MapFrom(src => src.ParentDocId))
                .ForMember(desc => desc.MOSDocDetail, opts => opts.Ignore())
                .ForMember(desc => desc.ProcessedBy, opts => opts.MapFrom(src => src.ProcessedBy))
                .ForMember(desc => desc.ProcessedTime, opts => opts.MapFrom(src => src.ProcessedTime))
                .ForMember(desc => desc.ProcessType, opts => opts.ResolveUsing<DocumentProcessTypeToStringResolver>().FromMember(src => src.ProcessType))
                .ForMember(desc => desc.RecDateTime, opts => opts.MapFrom(src => src.RecDateTime))
                .ForMember(desc => desc.RecFileName, opts => opts.MapFrom(src => src.RecFileName))
                .ForMember(desc => desc.RecFileSize, opts => opts.MapFrom(src => src.RecFileSize))
                .ForMember(desc => desc.RecFNID, opts => opts.MapFrom(src => src.RecFNID))
                 .ForMember(desc => desc.RecFormName, opts => opts.MapFrom(src => src.RecFormName))
                .ForMember(desc => desc.RecLocation, opts => opts.MapFrom(src => src.RecLocation))
                .ForMember(desc => desc.RecProcessType, opts => opts.Ignore())//MapFrom(src => src.RecProcessType))
                .ForMember(desc => desc.RelatedDocId, opts => opts.MapFrom(src => src.RelatedDocId))
                .ForMember(desc => desc.Remarks, opts => opts.MapFrom(src => src.Remarks))
                 .ForMember(desc => desc.SentDateTime, opts => opts.MapFrom(src => src.SentDateTime))
                .ForMember(desc => desc.SentFileName, opts => opts.MapFrom(src => src.SentFileName))
                .ForMember(desc => desc.SentFileSize, opts => opts.MapFrom(src => src.SentFileSize))
                .ForMember(desc => desc.SentFNID, opts => opts.MapFrom(src => src.SentFNID))
                 .ForMember(desc => desc.SentFormName, opts => opts.MapFrom(src => src.SentFormName))
                .ForMember(desc => desc.SentLocation, opts => opts.MapFrom(src => src.SentLocation))
                .ForMember(desc => desc.SentProcessType, opts => opts.Ignore())
                //.ForMember(desc => desc.ServiceOfDocDocStatusHistories, opts => opts.Ignore())

                 .ForMember(desc => desc.SpecHandlingReqInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SpecHandlingReqInd))
                .ForMember(desc => desc.SpecHandlingReqRem, opts => opts.MapFrom(src => src.SpecHandlingReqRem))
                .ForMember(desc => desc.SpecHandlingReqRsn, opts => opts.MapFrom(src => src.SpecHandlingReqRsn))
                .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                .ForMember(desc => desc.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember((src => src.SubCaseInfoId)))
                .ForMember(desc => desc.SubmSignature, opts => opts.MapFrom(src => src.SubmissionSignature))
                .ForMember(desc => desc.Version, opts => opts.MapFrom(src => src.Version))
                .ForMember(desc => desc.WaiverApprFee, opts => opts.MapFrom(src => src.WaiverApprFee))
                .ForMember(desc => desc.WaiverApproveInd, opts => opts.ResolveUsing<WaiverStatusToStringResolver>().FromMember(src => src.WaiverApproveInd))
                //.ForMember(desc => desc.WaiverApproveUserId, opts => opts.MapFrom(src => src.WaiverApproveUserId))
                .ForMember(desc => desc.WaiverApprReason, opts => opts.MapFrom(src => src.WaiverApprReason))
                .ForMember(desc => desc.WaiverInd, opts => opts.ResolveUsing<WaiverTypeToStringResolver>().FromMember(src => src.WaiverInd))
                .ForMember(desc => desc.WorkflowSerialNo, opts => opts.MapFrom(src => src.WorkflowSerialNo))
                .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.OCRPdfFNID, opts => opts.MapFrom(src => src.OCRPdfFNID))
                .ForMember(desc => desc.PrivateAnnoPdfFNID, opts => opts.MapFrom(src => src.PrivateAnnoPdfFNID))
                .ForMember(desc => desc.OCRStatus, opts => opts.ResolveUsing<OCRStatusToStringResolver>().FromMember(src => src.OCRStatus))
                .ForMember(desc => desc.JOLInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.JOLInd))
                .ForMember(desc => desc.DocInitiated, opts => opts.ResolveUsing<DocInitiatedLocationToStringResolver>().FromMember(src => src.DocInitiated))
                .ForMember(desc => desc.HrgDateToBeFixedInd, opts => opts.ResolveUsing<YesNoMandatoryToStringResolver>().FromMember(src => src.HrgDateToBeFixedInd))
                .ForMember(desc => desc.IsCrossCourt, opts => opts.ResolveUsing<YesNoMandatoryToStringResolver>().FromMember(src => src.IsCrossCourt))
                .ForMember(desc => desc.ReqDecision, opts => opts.ResolveUsing<ReqDecisionToStringResolver>().FromMember(src => src.ReqDecision))
                .ForMember(desc => desc.RejectionFeeActionType, opts => opts.ResolveUsing<RejectionFeeTypeToStringResolver>().FromMember(src => src.RejectionFeeActionType))
                .ForMember(desc => desc.IsConfidential, opts => opts.ResolveUsing<IsConfidentialToStringResolver>().FromMember(src => src.IsConfidential))
                .ForMember(desc => desc.DIYSelectbyUser, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.DIYSelectbyUser));
            
        }

        internal void MapDocumentInfoEntityToDocumentInfoSP()
        {
            Mapper.CreateMap<DocumentInfoEntity, DocumentInfoSP>()

                .ForMember(desc => desc.ActualFilingDateTime, opts => opts.MapFrom(src => src.ActualFilingDateTime))
                .ForMember(desc => desc.BackdateApprInd, opts => opts.ResolveUsing<BackdateStatusToStringResolver>().FromMember(src => src.BackdateApprInd))
                .ForMember(desc => desc.BackDateReasonFrCourt, opts => opts.MapFrom(src => src.BackDateReasonFrCourt))
                .ForMember(desc => desc.BackDateReasonFrLawFirm, opts => opts.MapFrom(src => src.BackDateReasonFrLawFirm))
                .ForMember(desc => desc.BackDateTime, opts => opts.MapFrom(src => src.BackDateTime))
                .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                .ForMember(desc => desc.DisplayName, opts => opts.MapFrom(src => src.DisplayName))
                .ForMember(desc => desc.DOCID, opts => opts.MapFrom(src => src.DocId))
                .ForMember(desc => desc.DocSerialNo, opts => opts.MapFrom(src => src.DocSerialNo))
                .ForMember(desc => desc.DocSystemInd, opts => opts.ResolveUsing<SystemIndToStringResolver>().FromMember(src => src.DocSystemInd))
                .ForMember(desc => desc.DocTitle, opts => opts.MapFrom(src => src.DocTitle))
                .ForMember(desc => desc.DocType, opts => opts.MapFrom(src => src.DocType))
                .ForMember(desc => desc.DocYear, opts => opts.MapFrom(src => src.DocYear))
                .ForMember(desc => desc.DraftDateTime, opts => opts.MapFrom(src => src.DraftDateTime))
                .ForMember(desc => desc.DraftFileName, opts => opts.MapFrom(src => src.DraftFileName))
                .ForMember(desc => desc.DraftFileSize, opts => opts.MapFrom(src => src.DraftFileSize))
                .ForMember(desc => desc.DraftFNID, opts => opts.MapFrom(src => src.DraftFNID))
                .ForMember(desc => desc.DraftFormName, opts => opts.MapFrom(src => src.DraftFormName))
                .ForMember(desc => desc.DraftLocation, opts => opts.MapFrom(src => src.DraftLocation))
                .ForMember(desc => desc.DraftProcessType, opts => opts.Ignore())//MapFrom(src => src.DraftProcessType))
                .ForMember(desc => desc.EndorsementType, opts => opts.ResolveUsing<EndorsementTypeToStringResolver>().FromMember(src => src.EndorsementType))
                 .ForMember(desc => desc.ExpungeInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ExpungeInd))
                .ForMember(desc => desc.FECopy, opts => opts.MapFrom(src => src.FECopy))
                .ForMember(desc => desc.FiledBy, opts => opts.MapFrom(src => src.FiledBy))
                .ForMember(desc => desc.FileType, opts => opts.ResolveUsing<DocumentFileTypeToStringResolver>().FromMember(src => src.FileType))
                .ForMember(desc => desc.FilingDateTime, opts => opts.MapFrom(src => src.FilingDateTime))
                .ForMember(desc => desc.FilingType, opts => opts.ResolveUsing<DocumentFilingTypeToStringResolver>().FromMember(src => src.FilingType))
                .ForMember(desc => desc.HRGID, opts => opts.MapFrom(src => src.HRGID))
                //.ForMember(desc => desc.HRGID, opts => opts.ResolveUsing<Int64ToStringHearingResolver>().FromMember(src => src.HRGID))
                .ForMember(desc => desc.HearingDateTime, opts => opts.MapFrom(src => src.HearingDateTime))
                .ForMember(desc => desc.HideInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HideInd))
                .ForMember(desc => desc.InTrayDateTime, opts => opts.MapFrom(src => src.InTrayDateTime))
                .ForMember(desc => desc.IsReplyProcessed, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsReplyProcessed))
                .ForMember(desc => desc.IsUrgent, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsUrgent))
                .ForMember(desc => desc.IsValidated, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsValidated))
                .ForMember(desc => desc.JOUserIdApprBackDate, opts => opts.MapFrom(src => src.JOUserIdApprBackDate))
                 .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFID))
                .ForMember(desc => desc.LFWaiverReqFee, opts => opts.MapFrom(src => src.LFWaiverReqFee))
                .ForMember(desc => desc.LFWaiverReqReason, opts => opts.MapFrom(src => src.LFWaiverReqReason))
                .ForMember(desc => desc.NoOfAttachments, opts => opts.MapFrom(src => src.NoOfAttachments))
                .ForMember(desc => desc.NumberOfPages, opts => opts.MapFrom(src => src.NumberOfPages))
                .ForMember(desc => desc.OCRInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.OCRInd))
                .ForMember(desc => desc.ParentDocId, opts => opts.MapFrom(src => src.ParentDocId))
                .ForMember(desc => desc.ProcessedBy, opts => opts.MapFrom(src => src.ProcessedBy))
                .ForMember(desc => desc.ProcessedTime, opts => opts.MapFrom(src => src.ProcessedTime))
                .ForMember(desc => desc.ProcessType, opts => opts.ResolveUsing<DocumentProcessTypeToStringResolver>().FromMember(src => src.ProcessType))
                .ForMember(desc => desc.RecDateTime, opts => opts.MapFrom(src => src.RecDateTime))
                .ForMember(desc => desc.RecFileName, opts => opts.MapFrom(src => src.RecFileName))
                .ForMember(desc => desc.RecFileSize, opts => opts.MapFrom(src => src.RecFileSize))
                .ForMember(desc => desc.RecFNID, opts => opts.MapFrom(src => src.RecFNID))
                 .ForMember(desc => desc.RecFormName, opts => opts.MapFrom(src => src.RecFormName))
                .ForMember(desc => desc.RecLocation, opts => opts.MapFrom(src => src.RecLocation))
                .ForMember(desc => desc.RecProcessType, opts => opts.Ignore())//MapFrom(src => src.RecProcessType))
                .ForMember(desc => desc.RelatedDocID, opts => opts.MapFrom(src => src.RelatedDocId))
                .ForMember(desc => desc.Remarks, opts => opts.MapFrom(src => src.Remarks))
                 .ForMember(desc => desc.SentDateTime, opts => opts.MapFrom(src => src.SentDateTime))
                .ForMember(desc => desc.SentFileName, opts => opts.MapFrom(src => src.SentFileName))
                .ForMember(desc => desc.SentFileSize, opts => opts.MapFrom(src => src.SentFileSize))
                .ForMember(desc => desc.SentFNID, opts => opts.MapFrom(src => src.SentFNID))
                 .ForMember(desc => desc.SentFormName, opts => opts.MapFrom(src => src.SentFormName))
                .ForMember(desc => desc.SentLocation, opts => opts.MapFrom(src => src.SentLocation))
                .ForMember(desc => desc.SentProcessType, opts => opts.Ignore())
                //.ForMember(desc => desc.ServiceOfDocDocStatusHistories, opts => opts.Ignore())
                 .ForMember(desc => desc.SpecHandlingReqInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SpecHandlingReqInd))
                .ForMember(desc => desc.SpecHandlingReqRem, opts => opts.MapFrom(src => src.SpecHandlingReqRem))
                .ForMember(desc => desc.SpecHandlingReqRsn, opts => opts.MapFrom(src => src.SpecHandlingReqRsn))
                .ForMember(desc => desc.SubmissionGroupID, opts => opts.MapFrom(src => src.SubmissionGroupId))
                .ForMember(desc => desc.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember((src => src.SubCaseInfoId)))
                .ForMember(desc => desc.SubmSignature, opts => opts.MapFrom(src => src.SubmissionSignature))
                .ForMember(desc => desc.Version, opts => opts.MapFrom(src => src.Version))
                .ForMember(desc => desc.WaiverApprFee, opts => opts.MapFrom(src => src.WaiverApprFee))
                .ForMember(desc => desc.WaiverApproveInd, opts => opts.ResolveUsing<WaiverStatusToStringResolver>().FromMember(src => src.WaiverApproveInd))
                //.ForMember(desc => desc.WaiverApproveUserId, opts => opts.MapFrom(src => src.WaiverApproveUserId))
                .ForMember(desc => desc.WaiverApprReason, opts => opts.MapFrom(src => src.WaiverApprReason))
                .ForMember(desc => desc.WaiverInd, opts => opts.ResolveUsing<WaiverTypeToStringResolver>().FromMember(src => src.WaiverInd))
                .ForMember(desc => desc.WorkflowSerialNo, opts => opts.MapFrom(src => src.WorkflowSerialNo))
                .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.OCRPdfFNId, opts => opts.MapFrom(src => src.OCRPdfFNID))
                .ForMember(desc => desc.PrivateAnnoPdfFNID, opts => opts.MapFrom(src => src.PrivateAnnoPdfFNID))
                .ForMember(desc => desc.OCRStatus, opts => opts.ResolveUsing<OCRStatusToStringResolver>().FromMember(src => src.OCRStatus))
                .ForMember(desc => desc.JOLInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.JOLInd))
                .ForMember(desc => desc.DocInitiated, opts => opts.ResolveUsing<DocInitiatedLocationToStringResolver>().FromMember(src => src.DocInitiated))
                .ForMember(desc => desc.HrgDateToBeFixedInd, opts => opts.ResolveUsing<YesNoMandatoryToStringResolver>().FromMember(src => src.HrgDateToBeFixedInd))
                .ForMember(desc => desc.IsCrossCourt, opts => opts.ResolveUsing<YesNoMandatoryToStringResolver>().FromMember(src => src.IsCrossCourt))
                .ForMember(desc => desc.ReqDecision, opts => opts.ResolveUsing<ReqDecisionToStringResolver>().FromMember(src => src.ReqDecision))
                .ForMember(desc => desc.RejectionFeeActionType, opts => opts.ResolveUsing<RejectionFeeTypeToStringResolver>().FromMember(src => src.RejectionFeeActionType))
                .ForMember(desc => desc.IsConfidential, opts => opts.ResolveUsing<IsConfidentialToStringResolver>().FromMember(src => src.IsConfidential))
                .ForMember(desc => desc.DIYSelectbyUser, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.DIYSelectbyUser));
        }

        internal void MapRDocCaseEntityToRDocCase()
        {
            try
            {
                Mapper.CreateMap<RDocCaseEntity, RDocCase>()
                    .ForMember(desc => desc.CaseInfo, opts => opts.Ignore())
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(desc => desc.DocumentInfo, opts => opts.Ignore())
                    .ForMember(desc => desc.IsOriginal, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsOriginal))
                    .ForMember(desc => desc.IsPreceding, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPreceding))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.RefDocId, opts => opts.MapFrom(src => src.RefDocId))
                    .ForMember(desc => desc.RefDocNumber, opts => opts.MapFrom(src => src.RefDocNumber))
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRDocCaseEntityToRDocCase", ex);
                throw;
            }
        }

        /// <summary>
        /// Map Document R Document Case Party domain object to NHibernate entity 
        /// </summary>
        internal void MapRDocCasePartyEntityToRDocCaseParty()
        {
            Mapper.CreateMap<RDocCasePartyEntity, RDocCaseParty>()
               .ForMember(desc => desc.DCPID, opts => opts.MapFrom(src => src.DCPID))
               .ForMember(desc => desc.RDCPId, opts => opts.MapFrom(src => src.RDCPId))
               .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
               .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
               .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
               .ForMember(desc => desc.UpdateInd, opts => opts.MapFrom(src => src.UpdateInd));
        }

        internal void MapDocCommentsEntityToDocComments()
        {
            try
            {
                Mapper.CreateMap<DocCommentsEntity, DocComments>()
                    .ForMember(dest => dest.CommentID, opts => opts.MapFrom(src => src.CommentId))
                    .ForMember(dest => dest.CommentType, opts => opts.ResolveUsing<DocCommentTypeToStringResolver>().FromMember(src => src.CommentType))
                    .ForMember(dest => dest.LocationID, opts => opts.MapFrom(src => src.LocationId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocCommentsEntityToDocComments", ex);
                throw;
            }
        }

        internal void MapDocRequestDetailEntityToDocRequestDetail()
        {
            try
            {
                Mapper.CreateMap<DocRequestDetailsEntity, DocRequestDetail>()
                    .ForMember(dest => dest.MetaData, opts => opts.MapFrom(src => src.MetaData))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocRequestDetailEntityToDocRequestDetail", ex);
                throw;
            }
        }

        internal void MapDocCaseTierTypeEntityToDocCaseTierType()
        {
            try
            {
                Mapper.CreateMap<DocCaseTierTypeEntity, DocCaseTierType>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDocCaseTierTypeEntityToDocCaseTierType", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="LawFirmDocCaseFileRefNumberEntity"/> to <see cref="LawFirmDocCaseFileRefNumber"/>.
        /// </summary>
        internal void MapLawFirmDocCaseFileRefNumberEntityToLawFirmDocCaseFileRefNumber()
        {
            try
            {
                Mapper.CreateMap<LawFirmDocCaseFileRefNumberEntity, LawFirmDocCaseFileRefNumber>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(desc => desc.LFFileRefNumber, opts => opts.MapFrom(src => src.LFFileRefNumber))
                    .ForMember(desc => desc.LFDCFRNId, opts => opts.MapFrom(src => src.LFDCFRNId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLawFirmDocCaseFileRefNumberEntityToLawFirmDocCaseFileRefNumber", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the document party case file reference number entity to document party case file reference number.
        /// </summary>
        internal void MapDocPartyCaseFileRefNumberEntityToDocPartyCaseFileRefNumber()
        {
            try
            {
                Mapper.CreateMap<DocPartyCaseFileRefNumberEntity, DocPartyCaseFileRefNumber>()
                    .ForMember(desc => desc.CaseInfoID, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoID))
                    .ForMember(desc => desc.DocPartyCaseFileRefNumberId, opts => opts.MapFrom(src => src.DocPartyCaseFileRefNumberId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LFFileRefNumber, opts => opts.MapFrom(src => src.LFFileRefNumber));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDocPartyCaseFileRefNumberEntityToDocPartyCaseFileRefNumber", ex);
                throw;
            }
        }      
        
        internal void MapTemp_ProcessingInfoEntityToTemp_ProcessingInfo()
        {
            try
            {
                Mapper.CreateMap<Temp_ProcessingInfoEntity,Temp_ProcessingInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapTemp_ProcessingInfoEntityToTemp_ProcessingInfo", ex);
                throw;
            }
        }

        internal void MapRDocCounterClaimFiledEntityToRDocCounterClaimFiled()
        {
            try
            {
                Mapper.CreateMap<RDocCounterClaimFiledEntity, RDocCounterClaimFiled>()
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRDocCounterClaimFiledEntityToRDocCounterClaimFiled", ex);
                throw;
            }
        }

        #endregion Methods

        #region Other

        /// <summary>
        /// Map Document R Document Law Firm domain object to NHibernate entity 
        /// </summary>
        /// No RDocLawFirm in BE
        //internal void MapRDocLawFirmEntityToRDocLawFirm()
        //{
        //    Mapper.CreateMap<RDocLawFirmEntity, RDocLawFirm>()
        //       .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
        //       .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFID))
        //       .ForMember(desc => desc.OwnerInd, opts => opts.MapFrom(src => src.OwnerInd))
        //       .ForMember(desc => desc.RDLFId, opts => opts.MapFrom(src => src.RDLFId))
        //       .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
        //}

        #endregion Other
    }
}