#region Header

/*****************************************************************************************************
* Description : This file represents the mapping of objects for Case entities. This class will map
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
// File: CaseMapping.cs
// Description: This file represents the mapping of objects for Case entities. This class will map
// Object to Entity.
// </summary>
// <copyright file= "CaseMapping.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    internal class CaseMapping
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(CaseMapping));

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseToCaseEntityMapping"/> class.
        /// </summary>
        internal CaseMapping()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Maps objects from <see cref="CaseInfoEntity"/> to <s    ee cref="CaseInfo"/>.
        /// </summary>
        internal void MapCaseInfoEntityToCaseInfo()
        {
            try
            {
                Mapper.CreateMap<CaseInfoEntity, CaseInfo>()
                    //.ForMember(desc => desc.AASCertifications, opts => opts.Ignore())
              .ForMember(desc => desc.AffidavitInfos, opts => opts.Ignore())
              .ForMember(desc => desc.CannotCaneInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CannotCaneInd))
              .ForMember(desc => desc.CaseFiledDate, opts => opts.MapFrom(src => src.CaseFiledDate))
              .ForMember(desc => desc.CaseFileLocation, opts => opts.MapFrom(src => src.CaseFileLocation))
              .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
              .ForMember(desc => desc.CaseName, opts => opts.MapFrom(src => src.CaseName))
              .ForMember(desc => desc.CaseNo, opts => opts.MapFrom(src => src.CaseNo))
              .ForMember(desc => desc.CaseOriginatingCases, opts => opts.Ignore())
              .ForMember(desc => desc.CaseParties, opts => opts.Ignore())
              .ForMember(desc => desc.CaseSerialNo, opts => opts.MapFrom(src => src.CaseSerialNo))
              .ForMember(desc => desc.CaseSolicitorHistories, opts => opts.Ignore())
              .ForMember(desc => desc.CaseSolicitors, opts => opts.Ignore())
              .ForMember(desc => desc.CaseStatusDate, opts => opts.MapFrom(src => src.CaseStatusDate))
              .ForMember(desc => desc.CaseSummary, opts => opts.MapFrom(src => src.CaseSummary))
              .ForMember(desc => desc.CaseYear, opts => opts.MapFrom(src => src.CaseYear))
                    //.ForMember(desc => desc.CaveatInfos, opts => opts.Ignore())
              .ForMember(desc => desc.ConsolidatedTypeInd, opts => opts.ResolveUsing<ConsolidatedTypeIndToStringResolver>().FromMember(src => src.ConsolidatedTypeInd))
              .ForMember(desc => desc.ConvertedTypeInd, opts => opts.MapFrom(src => src.ConvertedTypeInd))
              .ForMember(desc => desc.DCMInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.DCMInd))
              .ForMember(desc => desc.DocCaseParties, opts => opts.Ignore())
              .ForMember(desc => desc.DocCaseSolicitors, opts => opts.Ignore())
              .ForMember(desc => desc.DocOrderDetails, opts => opts.Ignore())
              .ForMember(desc => desc.DocPhysicalLoc, opts => opts.MapFrom(src => src.DocPhysicalLoc))
              .ForMember(desc => desc.DocumentInfos, opts => opts.Ignore())
              .ForMember(desc => desc.ForeignInterpreterInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ForeignInterpreterInd))
              .ForMember(desc => desc.FSCaseFileLocation, opts => opts.MapFrom(src => src.FileSystemCaseFileLocation))
              .ForMember(desc => desc.HandicapInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HandicapInd))
              .ForMember(desc => desc.HighProfileInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HighProfileInd))
              .ForMember(desc => desc.InterpreterLanguage, opts => opts.ResolveUsing<InterpreterLanguageToStringResolver>().FromMember(src => src.InterpreterLanguage))
              .ForMember(desc => desc.IsReviewed, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsReviewed))
              .ForMember(desc => desc.LABSection17CertInfos, opts => opts.Ignore())
              .ForMember(desc => desc.LACDocumentDrafts, opts => opts.Ignore())
              .ForMember(desc => desc.LACInfos, opts => opts.Ignore())
              .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
              .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
              .ForMember(desc => desc.LawFirmCaseFileRefNumbers, opts => opts.Ignore())
              .ForMember(desc => desc.MinorInvolvedInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MinorInvolvedInd))
              .ForMember(desc => desc.MRUCounter, opts => opts.MapFrom(src => src.MRUCounter))
              .ForMember(desc => desc.MuslimInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MuslimInd))
              .ForMember(desc => desc.NatureOfApplications, opts => opts.Ignore())
              .ForMember(desc => desc.NatureOfCases, opts => opts.Ignore())
              .ForMember(desc => desc.NIMAInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.NIMAInd))
              .ForMember(desc => desc.NoDeathSentenceInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.NoDeathSentenceInd))
              .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    //.ForMember(desc => desc.OriginatingCases, opts => opts.Ignore())
              .ForMember(desc => desc.PoliceAssistReqInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PoliceAssistReqInd))
              .ForMember(desc => desc.RCaseLawFirms, opts => opts.Ignore())
              .ForMember(desc => desc.RCaseSubmissions, opts => opts.Ignore())
              .ForMember(desc => desc.RefOrderDetails, opts => opts.Ignore())
              .ForMember(desc => desc.RelatedTypeInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.RelatedTypeInd))
              .ForMember(desc => desc.ROCInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ROCInd))
              .ForMember(desc => desc.ServiceOfDocInfos, opts => opts.Ignore())
              .ForMember(desc => desc.SMCLInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SMCLInd))
              .ForMember(desc => desc.SubCaseInfos, opts => opts.Ignore())
              .ForMember(desc => desc.SystemInd, opts => opts.ResolveUsing<SystemIndToStringResolver>().FromMember(src => src.SystemInd))
              .ForMember(desc => desc.TempCaseNo, opts => opts.MapFrom(src => src.TempCaseNo))
              .ForMember(desc => desc.Track, opts => opts.ResolveUsing<CaseTrackToStringResolver>().FromMember(src => src.Track))
              .ForMember(desc => desc.TransferTypeInd, opts => opts.ResolveUsing<TransferTypeIndToStringResolver>().FromMember(src => src.TransferTypeInd))
              .ForMember(desc => desc.TribunalCaseNo, opts => opts.MapFrom(src => src.TribunalCaseNo))
              .ForMember(desc => desc.TribunalType, opts => opts.MapFrom(src => src.TribunalType))
              .ForMember(desc => desc.WithdrawnDate, opts => opts.MapFrom(src => src.WithdrawnDate))
              .ForMember(dest => dest.CapitalCaseInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CapitalCaseInd))
              .ForMember(dest => dest.HasObjection, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasObjection))
              .ForMember(dest => dest.IsCrossCourt, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCrossCourt))
              .ForMember(dest => dest.IsInstrumentGenerated, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsInstrumentGenerated))
              .ForMember(dest => dest.IsRegistrarNoticeSent, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsRegistrarNoticeSent))
              .ForMember(dest => dest.CFRCInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CFRCInd))
              .ForMember(dest => dest.Order2bringupaprisonerInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.Order2BringUpAPrisonerInd))
              .ForMember(dest => dest.DigitaltranscriptionservicesInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.DigitalTranscriptionServicesInd))
              .ForMember(dest => dest.JOLIND, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.JOLInd))
              .ForMember(dest => dest.BankruptInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.BankruptInd))
              .ForMember(dest => dest.SimplifiedTrackInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SimplifiedTrackInd))
              .ForMember(dest => dest.ChildTrackInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ChildTrackInd))
              .ForMember(dest => dest.ViolenceTrackInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ViolenceTrackInd))
              .ForMember(dest => dest.InternationalTrackInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.InternationalTrackInd))
              .ForMember(dest => dest.HighConflictTrackInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HighConflictTrackInd))
              .ForMember(dest => dest.CFRCnFRCInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CFRCnFRCInd))
              .ForMember(dest => dest.ChildRepresentativeInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ChildRepresentativeInd))
              .ForMember(dest => dest.PaymentMode, opts => opts.ResolveUsing<PaymentModeToStringResolver>().FromMember(src => src.PaymentMode));
              //.ForMember(dest => dest.IsPOHAPOIssued, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPOHAPOIssued));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseInfoEntityToCaseInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="CaseIssueListEntity"/> to <see cref="CaseIssueList"/>.
        /// </summary>
        internal void MapCaseIssueListEntityToCaseIssueList()
        {
            try
            {
                Mapper.CreateMap<CaseIssueListEntity, CaseIssueList>()
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                    .ForMember(dest => dest.HRGID, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.HRGID))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseIssueListEntityToCaseIssueList", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="CaseOriginatingCaseEntity"/> to <see cref="CaseOriginatingCase"/>.
        /// </summary>
        internal void MapCaseOriginatingCaseEntityToCaseOriginatingCase()
        {
            try
            {
                Mapper.CreateMap<CaseOriginatingCaseEntity, CaseOriginatingCase>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.OriginatingCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.OriginatingCaseInfoId))
                    .ForMember(dest => dest.OriginatingCaseName, opts => opts.MapFrom(src => src.OriginatingCaseName))
                    .ForMember(dest => dest.OriginatingCaseNo, opts => opts.MapFrom(src => src.OriginatingCaseNo))
                    .ForMember(dest => dest.RecId, opts => opts.MapFrom(src => src.RecId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseOriginatingCaseEntityToCaseOriginatingCase", ex);
                throw;
            }
        }

        /// <summary>
        /// Map Case Party Address domain object to NHibernate entity 
        /// </summary>
        internal void MapCasePartyAddressEntityToCasePartyAddress()
        {
            Mapper.CreateMap<CasePartyAddressEntity, CasePartyAddress>()
                .ForMember(desc => desc.Addr1, opts => opts.MapFrom(src => src.Addr1))
                .ForMember(desc => desc.Addr2, opts => opts.MapFrom(src => src.Addr2))
                .ForMember(desc => desc.Addr3, opts => opts.MapFrom(src => src.Addr3))
                .ForMember(desc => desc.Addr4, opts => opts.MapFrom(src => src.Addr4))
                .ForMember(desc => desc.Address, opts => opts.MapFrom(src => src.Address))
                .ForMember(desc => desc.AddrType, opts => opts.ResolveUsing<AddressTypeToStringResolver>().FromMember(src => src.AddrType))
                .ForMember(desc => desc.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                .ForMember(desc => desc.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                .ForMember(desc => desc.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
                .ForMember(desc => desc.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                .ForMember(desc => desc.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.LastStayedInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.LastStayedInd))
                .ForMember(desc => desc.MailingInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MailingInd))
                .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId))
                .ForMember(desc => desc.StreetName, opts => opts.MapFrom(src => src.StreetName))
                .ForMember(desc => desc.UnitNo, opts => opts.MapFrom(src => src.UnitNo));
        }

        /// <summary>
        /// Map Case Party AIC Address domain object to NHibernate entity 
        /// </summary>
        internal void MapCasePartyAICAddressEntityToCasePartyAICAddress()
        {
            Mapper.CreateMap<CasePartyAICAddressEntity, CasePartyAICAddress>()
                .ForMember(desc => desc.Addr1, opts => opts.MapFrom(src => src.Addr1))
                .ForMember(desc => desc.Addr2, opts => opts.MapFrom(src => src.Addr2))
                .ForMember(desc => desc.Addr3, opts => opts.MapFrom(src => src.Addr3))
                .ForMember(desc => desc.Addr4, opts => opts.MapFrom(src => src.Addr4))
                .ForMember(desc => desc.Address, opts => opts.MapFrom(src => src.Address))
                .ForMember(desc => desc.AddrType, opts => opts.ResolveUsing<AddressTypeToStringResolver>().FromMember(src => src.AddrType))
                .ForMember(desc => desc.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                .ForMember(desc => desc.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                .ForMember(desc => desc.AICID, opts => opts.MapFrom(src => src.AICID))
                .ForMember(desc => desc.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
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
        /// Map Case Party AIC Alias domain object to NHibernate entity 
        /// </summary>
        internal void MapCasePartyAICAliasEntityToCasePartyAICAlias()
        {
            Mapper.CreateMap<CasePartyAICAliasEntity, CasePartyAICAlias>()
                .ForMember(desc => desc.AICID, opts => opts.MapFrom(src => src.AICID))
                .ForMember(desc => desc.AliasName, opts => opts.MapFrom(src => src.AliasName))
                .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
        }

        /// <summary>
        /// Map Case Party AIC Details domain object to NHibernate entity 
        /// </summary>
        internal void MapCasePartyAICDetailEntityToCasePartyAICDetail()
        {
            Mapper.CreateMap<CasePartyAICDetailsEntity, CasePartyAICDetail>()
                .ForMember(desc => desc.AICID, opts => opts.MapFrom(src => src.AICID))
                .ForMember(desc => desc.AddressAvailabilityInd, opts => opts.ResolveUsing<AddressAvailabilityTypeToStringResolver>().FromMember(src => src.AddressAvailabilityInd))
                .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                .ForMember(desc => desc.CasePartyAICAddresses, opts => opts.Ignore())
                .ForMember(desc => desc.CasePartyAICAliases, opts => opts.Ignore())
                //.ForMember(desc => desc.MEntityType, opts => opts.MapFrom(src => src.EntityTypeCode))
                .ForMember(desc => desc.FullName, opts => opts.MapFrom(src => src.FullName))
                .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                .ForMember(desc => desc.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                //.ForMember(desc => desc.MActingInCapacity, opts => opts.MapFrom(src => src.MActingInCapacity))
                //.ForMember(desc => desc.MCountry, opts => opts.MapFrom(src => src.))
                //.ForMember(desc => desc.MGender, opts => opts.MapFrom(src => src.))
                //.ForMember(desc => desc.MPersonIDGroup, opts => opts.MapFrom(src => src.))
                //.ForMember(desc => desc.MPersonIDType, opts => opts.MapFrom(src => src.))
                .ForMember(desc => desc.PortOfRegistration, opts => opts.MapFrom(src => src.PortOfRegistration))
                .ForMember(desc => desc.RegistrationNumber, opts => opts.MapFrom(src => src.RegistrationNumber))
                .ForMember(desc => desc.VesselName, opts => opts.MapFrom(src => src.VesselName))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.VesselIdType, opts => opts.ResolveUsing<VesselIdTypeToStringResolver>().FromMember(src => src.VesselIdType));
        }

        /// <summary>
        /// Map Case Party Alias domain object to NHibernate entity 
        /// </summary>
        internal void MapCasePartyAliasEntityToCasePartyAlias()
        {
            Mapper.CreateMap<CasePartyAliasEntity, CasePartyAlias>()
                .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                .ForMember(desc => desc.AliasName, opts => opts.MapFrom(src => src.AliasName))
                .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
        }

        /// <summary>
        /// Map Case Party Authorised Officer domain object to NHibernate entity 
        /// </summary>
        internal void MapCasePartyAuthorisedOfficerDetailEntityToCasePartyAuthorisedOfficerDetail()
        {
            Mapper.CreateMap<CasePartyAuthorisedOfficerDetailsEntity, CasePartyAuthorisedOfficerDetail>()
                .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.Name, opts => opts.MapFrom(src => src.Name))
                .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
        }

        /// <summary>
        /// Maps objects from <see cref="CasePartyBailorAddressEntity"/> to <see cref="CasePartyBailorAddress"/>.
        /// </summary>
        internal void MapCasePartyBailorAddressEntityToCasePartyBailorAddress()
        {
            try
            {
                Mapper.CreateMap<CasePartyBailorAddressEntity, CasePartyBailorAddress>()
                    .ForMember(desc => desc.MailingInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MailingInd))
                    .ForMember(desc => desc.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                    .ForMember(desc => desc.AddrType, opts => opts.ResolveUsing<AddressTypeToStringResolver>().FromMember(src => src.AddrType));
                //.ForMember(desc => desc.CasePartyBailorInfo, opts => opts.ResolveUsing<StringToCasePartyBailorInfoResolver>().FromMember(src => src.CasePartyBailorInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyBailorAddressEntityToCasePartyBailorAddress", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="CasePartyBailorInfoEntity"/> to <see cref="CasePartyBailorInfo"/>.
        /// </summary>
        internal void MapCasePartyBailorInfoEntityToCasePartyBailorInfo()
        {
            try
            {
                Mapper.CreateMap<CasePartyBailorInfoEntity, CasePartyBailorInfo>()
                    .ForMember(desc => desc.ContactTypeInd, opts => opts.ResolveUsing<ContactTypeToStringResolver>().FromMember(src => src.ContactTypeInd));
                //.ForMember(desc => desc.CaseParty, opts => opts.ResolveUsing<StringToCasePartyResolver>().FromMember(src => src.CasePartyId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyBailorInfoEntityToCasePartyBailorInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="CasePartyCitizenshipEntity"/> to <see cref="CasePartyCitizenship"/>.
        /// </summary>
        internal void MapCasePartyCitizenshipEntityToCasePartyCitizenship()
        {
            try
            {
                Mapper.CreateMap<CasePartyCitizenshipEntity, CasePartyCitizenship>()
                    .ForMember(desc => desc.CitizenshipStatus, opts => opts.ResolveUsing<CitizenshipStatusToStringResolver>().FromMember(src => src.CitizenshipStatus));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyCitizenshipEntityToCasePartyCitizenship", ex);
                throw;
            }
        }

        /** For Criminal Entities **/
        /// <summary>
        /// Maps objects from <see cref="CasePartyCriminalInfoEntity"/> to <see cref="CasePartyCriminalInfo"/>.
        /// </summary>
        internal void MapCasePartyCriminalInfoEntityToCasePartyCriminalInfo()
        {
            try
            {
                Mapper.CreateMap<CasePartyCriminalInfoEntity, CasePartyCriminalInfo>()
                    .ForMember(desc => desc.PartyInType, opts => opts.ResolveUsing<PartyInTypeToStringResolver>().FromMember(src => src.PartyInType))
                    //.ForMember(desc => desc.CaseParty, opts => opts.ResolveUsing<StringToCasePartyResolver>().FromMember(src => src.CasePartyId))
                    .ForMember(desc => desc.MPrisonCustodyPrisonCode, opts => opts.MapFrom(src => src.MPrisonCustody))
                    .ForMember(desc => desc.MPrisonRemandPrisonCode, opts => opts.MapFrom(src => src.MPrisonRemand));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyCriminalInfoEntityToCasePartyCriminalInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Map Document Case Party domain object to NHibernate entity 
        /// </summary>
        internal void MapCasePartyEntityToCaseParty()
        {
            Mapper.CreateMap<CasePartyEntity, CaseParty>()
                .ForMember(desc => desc.ApplicantCapacityRemarks, opts => opts.MapFrom(src => src.ApplicantCapacityRemarks))
                .ForMember(desc => desc.AssessmentDamages, opts => opts.Ignore())
                .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                .ForMember(desc => desc.BirthCountryRemarks, opts => opts.MapFrom(src => src.BirthCountryRemarks))
                .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                .ForMember(desc => desc.CasePartyAddresses, opts => opts.Ignore())
                .ForMember(desc => desc.CasePartyAICDetails, opts => opts.Ignore())
                .ForMember(desc => desc.CasePartyAliases, opts => opts.Ignore())
                .ForMember(desc => desc.CasePartyAuthorisedOfficerDetails, opts => opts.Ignore())
                .ForMember(desc => desc.CasePartyLACDetails, opts => opts.Ignore())
                .ForMember(desc => desc.CasePartyLACDetailsHistories, opts => opts.Ignore())
                .ForMember(desc => desc.CasePartyVesselDetails, opts => opts.Ignore())
                .ForMember(desc => desc.CaseSolicitorHistories, opts => opts.Ignore())
                .ForMember(desc => desc.CaseSolicitors, opts => opts.Ignore())
                .ForMember(desc => desc.CompanyName, opts => opts.MapFrom(src => src.CompanyName))
                .ForMember(desc => desc.DocCaseParties, opts => opts.Ignore())
                .ForMember(desc => desc.IsActiveInd, opts => opts.MapFrom(src => src.IsActiveInd))
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
                .ForMember(desc => desc.IsDraft, opts => opts.Ignore())
                .ForMember(desc => desc.FormerCompanyName, opts => opts.MapFrom(src => src.FormerCompanyName))
                .ForMember(desc => desc.FormerPersonName, opts => opts.MapFrom(src => src.FormerPersonName))
                .ForMember(desc => desc.FullName, opts => opts.MapFrom(src => src.FullName))
                .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                .ForMember(desc => desc.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                .ForMember(desc => desc.IsPartyServiedWrit, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPartyServiedWrit))
                .ForMember(desc => desc.HasLAC, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasLAC))
                .ForMember(desc => desc.IsPartyServiedWrit, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPartyServiedWrit))
                .ForMember(desc => desc.IsSingaporePR, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSingaporeanPR))
                .ForMember(desc => desc.LanguageCode, opts => opts.MapFrom(src => src.LanguageCode))
                .ForMember(desc => desc.LanguageRemarks, opts => opts.MapFrom(src => src.LanguageRemarks))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.LFAddressId, opts => opts.MapFrom(src => src.LFAddressId))
                .ForMember(desc => desc.LABSection17CertInfos, opts => opts.Ignore())//Check
                .ForMember(desc => desc.MobileCountryCode, opts => opts.MapFrom(src => src.MobileCountryCode))
                .ForMember(desc => desc.MarriageDt, opts => opts.MapFrom(src => src.MarriageDt))
                .ForMember(desc => desc.NationalityRemarks, opts => opts.MapFrom(src => src.NationalityRemarks))
                .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.PartyStatusDate, opts => opts.MapFrom(src => src.PartyStatusDate))
                .ForMember(desc => desc.RedActName, opts => opts.MapFrom(src => src.RedActName))
                .ForMember(desc => desc.MobileNumber, opts => opts.MapFrom(src => src.MobileNumber))
                .ForMember(desc => desc.NationalityRemarks, opts => opts.MapFrom(src => src.NationalityRemarks))
                .ForMember(desc => desc.OccupationRemarks, opts => opts.MapFrom(src => src.OccupationRemarks))
                .ForMember(desc => desc.OrdinalNumber, opts => opts.MapFrom(src => src.OrdinalNumber))
                .ForMember(desc => desc.PartyNo, opts => opts.MapFrom(src => src.PartyNo))
                .ForMember(desc => desc.RaceRemarks, opts => opts.MapFrom(src => src.RaceRemarks))
                .ForMember(desc => desc.LACDocumentDrafts, opts => opts.Ignore())
                .ForMember(desc => desc.RelationshipRemarks, opts => opts.MapFrom(src => src.RelationshipRemarks))
                .ForMember(desc => desc.ReligionRemarks, opts => opts.MapFrom(src => src.ReligionRemarks))
                .ForMember(desc => desc.TelAreaCode, opts => opts.MapFrom(src => src.TelAreaCode))
                .ForMember(desc => desc.TelCountryCode, opts => opts.MapFrom(src => src.TelCountryCode))
                .ForMember(desc => desc.TelNumber, opts => opts.MapFrom(src => src.TelNumber))
                .ForMember(desc => desc.MarriageCertNo, opts => opts.MapFrom(src => src.MarriageCertNo))
                .ForMember(desc => desc.UEN, opts => opts.MapFrom(src => src.UEN))
                .ForMember(desc => desc.CapacityInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CapacityInd))
                .ForMember(desc => desc.VesselIDType, opts => opts.ResolveUsing<VesselIdTypeToStringResolver>().FromMember(src => src.VesselIDType))
                 .ForMember(desc => desc.IsSubCaseOnlyParty, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSubCaseOnlyParty));
        }

        /// <summary>
        /// Maps objects from <see cref="CasePartyLACDetailEntity"/> to <see cref="CasePartyLACDetail"/>.
        /// </summary>
        internal void MapCasePartyLACDetailEntityToCasePartyLACDetailEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyLACDetailEntity, CasePartyLACDetail>()
                    .ForMember(dest => dest.CaseParty, opts => opts.ResolveUsing<StringToCasePartyResolver>().FromMember(src => src.CasePartyId))
                    .ForMember(dest => dest.CPLACDetailId, opts => opts.MapFrom(src => src.CPLACDetailId))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.FiledUserType, opts => opts.ResolveUsing<FiledUserTypeToStringResolver>().FromMember(src => src.FiledUserType))
                    .ForMember(dest => dest.LACDocDetailId, opts => opts.MapFrom(src => src.LACDocDetailId))
                    .ForMember(dest => dest.LACInfoId, opts => opts.MapFrom(src => src.LACInfoId))
                    .ForMember(dest => dest.LACRefStatus, opts => opts.ResolveUsing<LACRefStatusToStringResolver>().FromMember(src => src.LACRefStatus))
                    .ForMember(dest => dest.LFGroupCode, opts => opts.ResolveUsing<LFGroupCodeToStringResolver>().FromMember(src => src.LFGroupCode));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCasePartyLACDetailEntityToCasePartyLACDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="CasePartyLACDetailHistoryEntity"/> to <see cref="CasePartyLACDetailsHistory"/>.
        /// </summary>
        internal void MapCasePartyLACDetailHistoryEntityToCasePartyLACDetailHistoryEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyLACDetailHistoryEntity, CasePartyLACDetailsHistory>()
                    .ForMember(dest => dest.CaseParty, opts => opts.ResolveUsing<StringToCasePartyResolver>().FromMember(src => src.CasePartyId))
                    .ForMember(dest => dest.CPLACDetailHistoryId, opts => opts.MapFrom(src => src.CPLACDetailHistoryId))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.FiledUserType, opts => opts.ResolveUsing<FiledUserTypeToStringResolver>().FromMember(src => src.FiledUserType))
                    .ForMember(dest => dest.LACDocDetailId, opts => opts.MapFrom(src => src.LACDocDetailId))
                    .ForMember(dest => dest.LACInfoId, opts => opts.MapFrom(src => src.LACInfoId))
                    .ForMember(dest => dest.LACRefStatus, opts => opts.ResolveUsing<LACRefStatusToStringResolver>().FromMember(src => src.LACRefStatus))
                    .ForMember(dest => dest.LFGroupCode, opts => opts.ResolveUsing<LFGroupCodeToStringResolver>().FromMember(src => src.LFGroupCode));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCasePartyLACDetailEntityToCasePartyLACDetailEntity", ex);
                throw;
            }
        }

        internal void MapCasePartyStatusHistoryEntityToCasePartyStatusHistory()
        {
            try
            {
                Mapper.CreateMap<CasePartyStatusHistoryEntity, CasePartyStatusHistory>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCasePartyStatusHistoryEntityToCasePartyStatusHistory", ex);
                throw;
            }
        }

        /// <summary>
        /// Map Case Party Vessel Detail domain object to NHibernate entity 
        /// </summary>
        internal void MapCasePartyVesselDetailEntityToCasePartyVesselDetail()
        {
            Mapper.CreateMap<CasePartyVesselDetailsEntity, CasePartyVesselDetail>()
                .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                .ForMember(desc => desc.Description, opts => opts.MapFrom(src => src.Description))
                .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
        }

        /// <summary>
        /// Map Case Solicitor domain object to NHibernate entity 
        /// </summary>
        internal void MapCaseSolicitorEntityToCaseSolicitor()
        {
            Mapper.CreateMap<CaseSolicitorEntity, CaseSolicitor>()
                .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src=>src.CaseInfoId))
                .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFId))
                .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId))
                .ForMember(desc => desc.SolicitorId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SolicitorId))
                .ForMember(desc => desc.StartDate, opts => opts.MapFrom(src => src.StartDate))
                .ForMember(desc => desc.RepresentedBy, opts => opts.ResolveUsing<CasePartyRepresentedByToStringResolver>().FromMember(src => src.RepresentedBy))
                .ForMember(desc => desc.RepresentedBy, opts => opts.ResolveUsing<CasePartyRepresentedByToStringResolver>().FromMember(src => src.RepresentedBy))
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

        /// <summary>
        /// Map Case Solicitor History domain object to NHibernate entity 
        /// </summary>
        internal void MapCaseSolicitorHistoryEntityToCaseSolicitorHistory()
        {
            Mapper.CreateMap<CaseSolicitorHistoryEntity, CaseSolicitorHistory>()
                .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                .ForMember(desc => desc.ChangeType, opts => opts.MapFrom(src => src.ChangeType))
                .ForMember(desc => desc.EndDate, opts => opts.MapFrom(src => src.EndDate))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFId))
                .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId))
                .ForMember(desc => desc.SolicitorId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SolicitorId))
                .ForMember(desc => desc.StartDate, opts => opts.MapFrom(src => src.StartDate))
                .ForMember(desc => desc.RepresentedBy, opts => opts.ResolveUsing<CasePartyRepresentedByToStringResolver>().FromMember(src => src.RepresentedBy))
                .ForMember(desc => desc.RepresentedBy, opts => opts.ResolveUsing<CasePartyRepresentedByToStringResolver>().FromMember(src => src.RepresentedBy))
                .ForMember(desc => desc.JACInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.JACInd))
                .ForMember(desc => desc.LASCOInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.LASCOInd))
                .ForMember(desc => desc.CLASInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.CLASInd))
                .ForMember(desc => desc.ACLASInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ACLASInd))
                .ForMember(desc => desc.DateAppointed, opts => opts.MapFrom(src => src.DateAppointed))
                .ForMember(desc => desc.DateDischarged, opts => opts.MapFrom(src => src.DateDischarged))
                .ForMember(desc => desc.CounselInd, opts => opts.ResolveUsing<CriminalCounselTypesToStringResolver>().FromMember(src => src.CounselInd));
        }

        internal void MapCaseStatusHistoryEntityToCaseStatusHistory()
        {
            try
            {
                Mapper.CreateMap<CaseStatusHistoryEntity, CaseStatusHistory>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseStatusHistoryEntityToCaseStatusHistory", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="HearingAdminSupportEntity"/> to <see cref="HearingAdminSupport"/>.
        /// </summary>
        internal void MapHearingAdminSupportEntityToHearingAdminSupport()
        {
            try
            {
                Mapper.CreateMap<HearingAdminSupportEntity, HearingAdminSupport>()
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapHearingAdminSupportEntityToHearingAdminSupport", ex);
                throw;
            }
        }

        /// <summary>
        /// Map Hearing domain object to NHibernate entity 
        /// </summary>
        internal void MapHearingEntityToHearing()
        {
            try
            {
                Mapper.CreateMap<HearingEntity, Hearing>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.ComputedHearingFee, opts => opts.MapFrom(src => src.ComputedHearingFee))
                    .ForMember(dest => dest.ComputedHearingFeeDatetime, opts => opts.MapFrom(src => src.ComputedHearingFeeDatetime))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.DsgName, opts => opts.MapFrom(src => src.DsgName))
                    .ForMember(dest => dest.EHearingInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.eHearingInd))
                    .ForMember(dest => dest.EHearingStatus, opts => opts.ResolveUsing<EHearingStatusToStringResolver>().FromMember(src => src.eHearingStatus))
                    .ForMember(dest => dest.EndDateTime, opts => opts.MapFrom(src => src.EndDateTime))
                    .ForMember(dest => dest.EstimatedHearingFee, opts => opts.MapFrom(src => src.EstimatedHearingFee))
                    .ForMember(dest => dest.EstimatedHearingFeeDatetime, opts => opts.MapFrom(src => src.EstimatedHearingFeeDatetime))
                    .ForMember(dest => dest.FinalAdjournment, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.FinalAdjournment))
                    .ForMember(dest => dest.HearingModeInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HearingModeInd))
                    .ForMember(dest => dest.HRGApproveInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HRGApproveInd))
                    .ForMember(dest => dest.HRGDateTime, opts => opts.MapFrom(src => src.HRGDateTime))
                    .ForMember(dest => dest.HRGID, opts => opts.MapFrom(src => src.HRGID))
                    .ForMember(dest => dest.HRGInstructions, opts => opts.MapFrom(src => src.HRGInstructions))
                    .ForMember(dest => dest.HRGLockInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HRGLockInd))
                    .ForMember(dest => dest.HRGOutcomeApprInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HRGOutcomeApprInd))
                    //.ForMember(dest => dest.HRGOutComeCode, opts => opts.MapFrom(src => src.HRGOutComeCode))
                    .ForMember(dest => dest.HRGOutcomeRemarks, opts => opts.MapFrom(src => src.HRGOutcomeRemarks))
                    .ForMember(dest => dest.HRGOutComeRSNCode, opts => opts.MapFrom(src => src.HRGOutComeRSNCode))
                    .ForMember(dest => dest.HRGRoomCode, opts => opts.MapFrom(src => src.HRGRoomCode))
                    .ForMember(dest => dest.HRGSlotcode, opts => opts.MapFrom(src => src.HRGSlotcode))
                    .ForMember(dest => dest.HRGTrench, opts => opts.MapFrom(src => src.HRGTrench))
                    .ForMember(dest => dest.HRGTypeCode, opts => opts.MapFrom(src => src.HRGTypeCode))
                    .ForMember(dest => dest.IndicationsGiven, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IndicationsGiven))
                    .ForMember(dest => dest.Indicator, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IndicationsGiven))//TODO: Check
                    .ForMember(dest => dest.IsPartiesAbsent, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsPartiesAbsent))
                    .ForMember(dest => dest.MultiDayInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MultiDayInd))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.PartHeardInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PartHeardInd))
                    .ForMember(dest => dest.RequestHearingFeeDetails, opts => opts.Ignore())
                    .ForMember(dest => dest.SCInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SCInd))
                    .ForMember(dest => dest.SpecialHrgDateInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SpecialHrgDateInd))
                    .ForMember(dest => dest.StartDateTime, opts => opts.MapFrom(src => src.StartDateTime))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                    .ForMember(dest => dest.SubpoenaInfos, opts => opts.Ignore())
                    .ForMember(dest => dest.ToShow, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ToShow))
                    .ForMember(dest => dest.IsCDRRefixed, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCDRRefixed))
                    .ForMember(dest => dest.MHRGBeforeTypeEstimatedHRGBeforeTypeCode, opts => opts.MapFrom(src => src.MHRGBeforeTypeEstimatedHRGBeforeTypeCode))
                    .ForMember(dest => dest.MHRGBeforeTypeHRGBeforeTypeCode, opts => opts.MapFrom(src => src.MHRGBeforeType));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapHearingEntityToHearing", ex);
                throw;
            }
        }

        /// <summary>
        /// Map Case Law Firm domain object to NHibernate entity 
        /// </summary>
        internal void MapLawFirmCaseFileRefNumberEntityToLawFirmCaseFileRefNumber()
        {
            Mapper.CreateMap<LawFirmCaseFileRefNumberEntity, LawFirmCaseFileRefNumber>()
                .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFID))
                .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                .ForMember(desc => desc.LFFileRefNumber, opts => opts.MapFrom(src => src.LFFileRefNumber))
                .ForMember(desc => desc.LFCFRNId, opts => opts.MapFrom(src => src.LFCFRNId));
        }

        /// <summary>
        /// Map Case Law Firm domain object to NHibernate entity 
        /// </summary>
        internal void MapRCaseLawFirmEntityToRCaseLawFirm()
        {
            Mapper.CreateMap<RCaseLawFirmEntity, RCaseLawFirm>()
                .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToInt64Resolver>().FromMember(src=>src.CaseInfoId))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFID))
                .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.RCLFId, opts => opts.MapFrom(src => src.RCLFId));
        }

        /** End of For Criminal Entities **/
        /// <summary>
        /// Maps objects from <see cref="RCaseLinkedEntity"/> to <see cref="RCaseLinked"/>.
        /// </summary>
        internal void MapRCaseLinkedEntityToRCaseLinked()
        {
            try
            {
                Mapper.CreateMap<RCaseLinkedEntity, RCaseLinked>()
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => Convert.ToInt64(src.CaseInfoId)))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRCaseLinkedEntityToRCaseLinked", ex);
                throw;
            }
        }

        /// <summary>
        /// Map Case Party Address domain object to NHibernate entity 
        /// </summary>
        internal void MapRCaseSubmissionEntityToRCaseSubmission()
        {
            Mapper.CreateMap<RCaseSubmissionEntity, RCaseSubmission>()
                .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.RCaseSubmissionId, opts => opts.MapFrom(src => src.RCaseSubmissionId))
                .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
        }

        /// <summary>
        /// Maps objects from <see cref="RCaseLinkedEntity"/> to <see cref="RCaseLinked"/>.
        /// </summary>
        internal void MapRCaseTransferEntityToRCaseTransfer()
        {
            try
            {
                Mapper.CreateMap<RCaseTransferEntity, RCaseTransfer>()
                    .ForMember(desc => desc.FrCaseInfoID, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.FrCaseInfoId))
                    .ForMember(desc => desc.ToCaseInfoID, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.ToCaseInfoId))
                    .ForMember(dest => dest.FrCasePaymentMode, opts => opts.ResolveUsing<PaymentModeToStringResolver>().FromMember(src => src.FrCasePaymentMode)); ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRCaseTransferEntityToRCaseTransfer", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="RCaseLinkedEntity"/> to <see cref="RCaseLinked"/>.
        /// </summary>
        internal void MapRCaseTransferHistoryEntityToRCaseTransferHistory()
        {
            try
            {
                Mapper.CreateMap<RCaseTransferHistoryEntity, RCaseTransferHistory>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(desc => desc.ActionType, opts => opts.ResolveUsing<TransferActionTypeToStringResolver>().FromMember(src => src.ActionType))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRCaseTransferHistoryEntityToRCaseTransferHistory", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="RLawFirmSolicitorsEntity"/> to <see cref="RLawFirmSolicitors"/>.
        /// </summary>
        internal void MapRLawFirmSolicitorsEntityToRLawFirmSolicitors()
        {
            try
            {
                Mapper.CreateMap<RLawFirmSolicitorsEntity, RLawFirmSolicitors>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRLawFirmSolicitorsEntityToRLawFirmSolicitors", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="SubCaseInfoEntity"/> to <see cref="SubCaseInfo"/>.
        /// </summary>
        internal void MapSubCaseInfoEntityToSubCaseInfo()
        {
            try
            {
                Mapper.CreateMap<SubCaseInfoEntity, SubCaseInfo>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.SubCaseSerialNo, opts => opts.MapFrom(src => src.SubCaseSerialNo))
                    .ForMember(dest => dest.SubCaseStatusDate, opts => opts.MapFrom(src => src.SubCaseStatusDate))
                    .ForMember(dest => dest.SubCaseYear, opts => opts.MapFrom(src => src.SubCaseYear));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSubCaseInfoEntityToSubCaseInfo", ex);
                throw;
            }
        }

        internal void MapRCaseConsolidateEntityToRCaseConsolidate()
        {
            try
            {
                Mapper.CreateMap<RCaseConsolidateEntity, RCaseConsolidate>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoID))
                    .ForMember(dest => dest.ConCaseInfoID, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.ConCaseInfoID));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRCaseConsolidateEntityToRCaseConsolidate", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="RLawFirmSolicitorsEntity"/> to <see cref="RLawFirmSolicitors"/>.
        /// </summary>
        internal void MapRLawFirmSolicitorHistoryEntityToRLawFirmSolicitorHistory()
        {
            try
            {
                Mapper.CreateMap<RLawFirmSolicitorHistoryEntity, RLawFirmSolicitorHistory>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRLawFirmSolicitorHistoryEntityToRLawFirmSolicitorHistory", ex);
                throw;
            }
        }


        internal void MapTransferOrderOfCourtEntityToTransferOrderOfCourt()
        {
            try
            {
                Mapper.CreateMap<TransferOrderOfCourtEntity, TransferOrderOfCourt>()
                    .ForMember(dest => dest.CaseInfoID, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoID))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRCaseConsolidateEntityToRCaseConsolidate", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the party case file reference number entity to party case file reference number.
        /// </summary>
        internal void MapPartyCaseFileRefNumberEntityToPartyCaseFileRefNumber()
        {
            try
            {
                Mapper.CreateMap<PartyCaseFileRefNumberEntity, PartyCaseFileRefNumber>()
                    .ForMember(desc => desc.CaseInfoID, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoID))
                    .ForMember(desc => desc.CasePartyID, opts => opts.MapFrom(src => src.CasePartyID))
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
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

        internal void MapCaseInfoNumberEntityToCaseInfoNumber()
        {
            try
            {
                Mapper.CreateMap<CaseInfoNumberEntity, CaseInfoNumber>()
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseInfoNumberEntityToCaseInfoNumber", ex);
                throw;
            }
        }

        #endregion Methods
    }
}