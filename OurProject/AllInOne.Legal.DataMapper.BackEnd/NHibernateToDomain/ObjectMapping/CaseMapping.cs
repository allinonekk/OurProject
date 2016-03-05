#region Header

/*****************************************************************************************************
* Description : This file handles mapping for Case from NHibernate entities to Domain objects.
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
// File: CaseMapping.cs
// Description: This file handles mapping for Case from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "CaseMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Case from NHibernate entities to Domain objects.
    /// </summary>
    internal class CaseMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CaseMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method which maps the <see cref="CaseInfo"/> to <see cref="CaseInfoEntity"/>.
        /// </summary>
        internal void MapCaseInfoToCaseInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CaseInfo, CaseInfoEntity>()
                    .ForMember(dest => dest.CannotCaneInd, opts => opts.Ignore())
                    .ForMember(dest => dest.CaseFiledDate, opts => opts.MapFrom(src => src.CaseFiledDate))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.CaseFileLocation, opts => opts.MapFrom(src => src.CaseFileLocation))
                    .ForMember(dest => dest.CaseName, opts => opts.MapFrom(src => src.CaseName))
                    .ForMember(dest => dest.CaseNo, opts => opts.MapFrom(src => src.CaseNo))
                    .ForMember(dest => dest.CaseSerialNo, opts => opts.MapFrom(src => src.CaseSerialNo))
                    .ForMember(dest => dest.CaseStatusDate, opts => opts.MapFrom(src => src.CaseStatusDate))
                    .ForMember(dest => dest.CaseYear, opts => opts.MapFrom(src => src.CaseYear))
                    .ForMember(dest => dest.CaseSummary, opts => opts.Ignore())
                    .ForMember(dest => dest.ConsolidatedTypeInd, opts => opts.MapFrom(src => src.ConsolidatedTypeInd))
                    .ForMember(dest => dest.ConvertedTypeInd, opts => opts.MapFrom(src => src.ConvertedTypeInd))
                    .ForMember(dest => dest.DCMInd, opts => opts.MapFrom(src => src.DCMInd))
                    .ForMember(dest => dest.DocPhysicalLoc, opts => opts.Ignore())
                    .ForMember(dest => dest.FileSystemCaseFileLocation, opts => opts.MapFrom(src => src.FSCaseFileLocation))
                    .ForMember(dest => dest.ForeignInterpreterInd, opts => opts.MapFrom(src => src.ForeignInterpreterInd))
                    .ForMember(dest => dest.HandicapInd, opts => opts.MapFrom(src => src.HandicapInd))
                    .ForMember(dest => dest.HighProfileInd, opts => opts.MapFrom(src => src.HighProfileInd))
                    .ForMember(dest => dest.InterpreterLanguage, opts => opts.Ignore())
                    .ForMember(dest => dest.IsReviewed, opts => opts.Ignore())
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MinorInvolvedInd, opts => opts.MapFrom(src => src.MinorInvolvedInd))
                    .ForMember(dest => dest.MRUCounter, opts => opts.MapFrom(src => src.MRUCounter))
                    .ForMember(dest => dest.MuslimInd, opts => opts.MapFrom(src => src.MuslimInd))
                    .ForMember(dest => dest.NIMAInd, opts => opts.MapFrom(src => src.NIMAInd))
                    .ForMember(dest => dest.NoDeathSentenceInd, opts => opts.MapFrom(src => src.NoDeathSentenceInd))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.PoliceAssistReqInd, opts => opts.MapFrom(src => src.PoliceAssistReqInd))
                    .ForMember(dest => dest.RelatedTypeInd, opts => opts.MapFrom(src => src.RelatedTypeInd))
                    //.ForMember(dest => dest.RedActCaseName, opts => opts.MapFrom(src => src.RedActCaseName))
                    .ForMember(dest => dest.ROCInd, opts => opts.MapFrom(src => src.ROCInd))
                    .ForMember(dest => dest.SMCLInd, opts => opts.MapFrom(src => src.SMCLInd))
                    .ForMember(dest => dest.SystemInd, opts => opts.MapFrom(src => src.SystemInd))
                    .ForMember(dest => dest.TempCaseNo, opts => opts.MapFrom(src => src.TempCaseNo))
                    .ForMember(dest => dest.Track, opts => opts.Ignore())
                    .ForMember(dest => dest.TransferTypeInd, opts => opts.MapFrom(src => src.TransferTypeInd))
                    .ForMember(dest => dest.TribunalCaseNo, opts => opts.MapFrom(src => src.TribunalCaseNo))
                    .ForMember(dest => dest.TribunalType, opts => opts.MapFrom(src => src.TribunalType))
                    .ForMember(dest => dest.WithdrawnDate, opts => opts.MapFrom(src => src.WithdrawnDate))
                    .ForMember(dest => dest.CapitalCaseInd, opts => opts.MapFrom(src => src.CapitalCaseInd))
                    .ForMember(dest => dest.HasObjection, opts => opts.MapFrom(src => src.HasObjection))
                    .ForMember(dest => dest.IsInstrumentGenerated, opts => opts.MapFrom(src => src.IsInstrumentGenerated))
                    .ForMember(dest => dest.IsRegistrarNoticeSent, opts => opts.MapFrom(src => src.IsRegistrarNoticeSent))
                    .ForMember(dest => dest.CFRCInd, opts => opts.MapFrom(src => src.CFRCInd))
                     .ForMember(dest => dest.Order2BringUpAPrisonerInd, opts => opts.MapFrom(src => src.Order2bringupaprisonerInd))
                    .ForMember(dest => dest.DigitalTranscriptionServicesInd, opts => opts.MapFrom(src => src.DigitaltranscriptionservicesInd))
                    .ForMember(dest => dest.JOLInd, opts => opts.MapFrom(src => src.JOLIND))
                    .ForMember(dest => dest.BankruptInd, opts => opts.MapFrom(src => src.BankruptInd))
                    .ForMember(dest => dest.SimplifiedTrackInd, opts => opts.MapFrom(src => src.SimplifiedTrackInd))
                    .ForMember(dest => dest.ChildTrackInd, opts => opts.MapFrom(src => src.ChildTrackInd))
                    .ForMember(dest => dest.ViolenceTrackInd, opts => opts.MapFrom(src => src.ViolenceTrackInd))
                    .ForMember(dest => dest.InternationalTrackInd, opts => opts.MapFrom(src => src.InternationalTrackInd))
                    .ForMember(dest => dest.HighConflictTrackInd, opts => opts.MapFrom(src => src.HighConflictTrackInd))
                    .ForMember(dest => dest.CFRCnFRCInd, opts => opts.MapFrom(src => src.CFRCnFRCInd))
                    .ForMember(dest => dest.ChildRepresentativeInd, opts => opts.MapFrom(src => src.ChildRepresentativeInd))
                    .ForMember(dest => dest.PaymentMode, opts => opts.MapFrom(src => src.PaymentMode));
                    //.ForMember(dest => dest.IsPOHAPOIssued, opts => opts.MapFrom(src => src.IsPOHAPOIssued));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCaseInfoToCaseInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="CaseIssueList"/> to <see cref="CaseIssueListEntity"/>.
        /// </summary>
        internal void MapCaseIssueListToCaseIssueListEntity()
        {
            try
            {
                Mapper.CreateMap<CaseIssueList, CaseIssueListEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.HRGID, opts => opts.MapFrom(src => src.HRGID));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCaseIssueListToCaseIssueListEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CaseOriginatingCase"/> to <see cref="CaseOriginatingCaseEntity"/>.
        /// </summary>
        internal void MapCaseOriginatingCaseToCaseOriginatingCaseEntity()
        {
            try
            {
                Mapper.CreateMap<CaseOriginatingCase, CaseOriginatingCaseEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.OriginatingCaseInfoId, opts => opts.MapFrom(src => src.OriginatingCaseInfoId))
                    .ForMember(dest => dest.OriginatingCaseName, opts => opts.MapFrom(src => src.OriginatingCaseName))
                    .ForMember(dest => dest.OriginatingCaseNo, opts => opts.MapFrom(src => src.OriginatingCaseNo))
                    .ForMember(dest => dest.RecId, opts => opts.MapFrom(src => src.RecId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseOriginatingCaseToCaseOriginatingCaseEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CasePartyAddress"/> to <see cref="CasePartyAddressEntity"/>.
        /// </summary>
        internal void MapCasePartyAddressToCasePartyAddressEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyAddress, CasePartyAddressEntity>()
                    .ForMember(desc => desc.AddrType, opts => opts.MapFrom(src => src.AddrType))
                    .ForMember(desc => desc.FormatInd, opts => opts.MapFrom(src => src.FormatInd))
                    .ForMember(desc => desc.LastStayedInd, opts => opts.MapFrom(src => src.LastStayedInd))
                    .ForMember(desc => desc.MailingInd, opts => opts.MapFrom(src => src.MailingInd))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyAddressToCasePartyAddressEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CasePartyAICAddress"/> to <see cref="CasePartyAICAddressEntity"/>.
        /// </summary>
        internal void MapCasePartyAICAddressToCasePartyAICAddressEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyAICAddress, CasePartyAICAddressEntity>()
                    .ForMember(desc => desc.Addr1, opts => opts.MapFrom(src => src.Addr1))
                    .ForMember(desc => desc.Addr2, opts => opts.MapFrom(src => src.Addr2))
                    .ForMember(desc => desc.Addr3, opts => opts.MapFrom(src => src.Addr3))
                    .ForMember(desc => desc.Addr4, opts => opts.MapFrom(src => src.Addr4))
                    .ForMember(desc => desc.Address, opts => opts.MapFrom(src => src.Address))
                    .ForMember(desc => desc.AddrType, opts => opts.MapFrom(src => src.AddrType))
                    .ForMember(desc => desc.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                    .ForMember(desc => desc.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                    .ForMember(desc => desc.AICID, opts => opts.MapFrom(src => src.AICID))
                    .ForMember(desc => desc.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
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
                Logger.Error("Error at MapCasePartyAICAddressToCasePartyAICAddressEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CasePartyAICAlias"/> to <see cref="CasePartyAICAliasEntity"/>.
        /// </summary>
        internal void MapCasePartyAICAliasToCasePartyAICAliasEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyAICAlias, CasePartyAICAliasEntity>()
                    .ForMember(desc => desc.AICID, opts => opts.MapFrom(src => src.AICID))
                    .ForMember(desc => desc.AliasName, opts => opts.MapFrom(src => src.AliasName))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyAICAliasToCasePartyAICAliasEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CasePartyAICDetail"/> to <see cref="CasePartyAICDetailsEntity"/>.
        /// </summary>
        internal void MapCasePartyAICDetailToCasePartyAICDetailEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyAICDetail, CasePartyAICDetailsEntity>()
                    .ForMember(desc => desc.AICID, opts => opts.MapFrom(src => src.AICID))
                    .ForMember(desc => desc.AddressAvailabilityInd, opts => opts.MapFrom(src => src.AddressAvailabilityInd))
                    .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(desc => desc.CasePartyAICAddresses, opts => opts.Ignore())
                    .ForMember(desc => desc.CasePartyAICAliases, opts => opts.Ignore())
                    .ForMember(desc => desc.FormerCompanyName, opts => opts.MapFrom(src => src.FormerCompanyName))
                    .ForMember(desc => desc.FormerPersonName, opts => opts.MapFrom(src => src.FormerPersonName))
                    .ForMember(desc => desc.FullName, opts => opts.MapFrom(src => src.FullName))
                    .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(desc => desc.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                    .ForMember(desc => desc.MActingInCapacity, opts => opts.MapFrom(src => src.MActingInCapacity))
                    .ForMember(desc => desc.PortOfRegistration, opts => opts.MapFrom(src => src.PortOfRegistration))
                    .ForMember(desc => desc.RegistrationNumber, opts => opts.MapFrom(src => src.RegistrationNumber))
                    .ForMember(desc => desc.VesselName, opts => opts.MapFrom(src => src.VesselName))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyAICDetailToCasePartyAICDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CasePartyAlias"/> to <see cref="CasePartyAliasEntity"/>.
        /// </summary>
        internal void MapCasePartyAliasToCasePartyAliasEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyAlias, CasePartyAliasEntity>()
                    .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(desc => desc.AliasName, opts => opts.MapFrom(src => src.AliasName))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyAliasToCasePartyAliasEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CasePartyAuthorisedOfficerDetail"/> to <see cref="CasePartyAuthorisedOfficerDetailsEntity"/>.
        /// </summary>
        internal void MapCasePartyAuthorisedOfficerDetailToCasePartyAuthorisedOfficerDetailEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyAuthorisedOfficerDetail, CasePartyAuthorisedOfficerDetailsEntity>()
                    .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyAuthorisedOfficerDetailToCasePartyAuthorisedOfficerDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="CasePartyBailorAddress"/> to <see cref="CasePartyBailorAddressEntity"/>.
        /// </summary>
        internal void MapCasePartyBailorAddressToCasePartyBailorAddressEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyBailorAddress, CasePartyBailorAddressEntity>()
                    //.ForMember(desc => desc.CasePartyBailorInfoId, opts => opts.MapFrom(src => src.CasePartyBailorInfo.CasePartyBailorInfoId))
                    .ForMember(desc => desc.FormatInd, opts => opts.MapFrom(src => src.FormatInd))
                    .ForMember(desc => desc.AddrType, opts => opts.MapFrom(src => src.AddrType))
                    .ForMember(desc => desc.MailingInd, opts => opts.MapFrom(src => src.MailingInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyBailorAddressToCasePartyBailorAddressEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="CasePartyBailorInfo"/> to <see cref="CasePartyBailorInfoEntity"/>.
        /// </summary>
        internal void MapCasePartyBailorInfoToCasePartyBailorInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyBailorInfo, CasePartyBailorInfoEntity>()
                    //.ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CaseParty.CasePartyId))
                    .ForMember(desc => desc.ContactTypeInd, opts => opts.MapFrom(src => src.ContactTypeInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyBailorInfoToCasePartyBailorInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="CasePartyCitizenship"/> to <see cref="CasePartyCitizenshipEntity"/>.
        /// </summary>
        internal void MapCasePartyCitizenshipToCasePartyCitizenshipEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyCitizenship, CasePartyCitizenshipEntity>()
                    .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(desc => desc.CitizenshipStatus, opts => opts.MapFrom(src => src.CitizenshipStatus));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyCitizenshipToCasePartyCitizenshipEntity", ex);
                throw;
            }
        }

        /** For Criminal Entities **/
        /// <summary>
        /// Maps objects from <see cref="CasePartyCriminalInfo"/> to <see cref="CasePartyCriminalInfoEntity"/>.
        /// </summary>
        internal void MapCasePartyCriminalInfoToCasePartyCriminalInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyCriminalInfo, CasePartyCriminalInfoEntity>()
                    //.ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CaseParty.CasePartyId))
                    .ForMember(desc => desc.PartyInType, opts => opts.MapFrom(src => src.PartyInType))
                    .ForMember(desc => desc.MPrisonCustody, opts => opts.MapFrom(src => src.MPrisonCustodyPrisonCode))
                    .ForMember(desc => desc.MPrisonRemand, opts => opts.MapFrom(src => src.MPrisonRemandPrisonCode));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyCriminalInfoToCasePartyCriminalInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CasePartyLACDetail"/> to <see cref="CasePartyLACDetailEntity"/>.
        /// </summary>
        internal void MapCasePartyLACDetailsHistoryToCasePartyLACDetailHistoryEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyLACDetailsHistory, CasePartyLACDetailHistoryEntity>()
                    .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CaseParty.CasePartyId))
                    .ForMember(dest => dest.CPLACDetailHistoryId, opts => opts.MapFrom(src => src.CPLACDetailHistoryId))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.FiledUserType, opts => opts.MapFrom(src => src.FiledUserType))
                    .ForMember(dest => dest.LACDocDetailId, opts => opts.MapFrom(src => src.LACDocDetailId))
                    .ForMember(dest => dest.LACInfoId, opts => opts.MapFrom(src => src.LACInfoId))
                    .ForMember(dest => dest.LACRefStatus, opts => opts.MapFrom(src => src.LACRefStatus))
                    .ForMember(dest => dest.LFGroupCode, opts => opts.MapFrom(src => src.LFGroupCode));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCasePartyLACDetailToCasePartyLACDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CasePartyLACDetail"/> to <see cref="CasePartyLACDetailEntity"/>.
        /// </summary>
        internal void MapCasePartyLACDetailToCasePartyLACDetailEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyLACDetail, CasePartyLACDetailEntity>()
                    .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CaseParty.CasePartyId))
                    .ForMember(dest => dest.CPLACDetailId, opts => opts.MapFrom(src => src.CPLACDetailId))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.FiledUserType, opts => opts.MapFrom(src => src.FiledUserType))
                    .ForMember(dest => dest.LACDocDetailId, opts => opts.MapFrom(src => src.LACDocDetailId))
                    .ForMember(dest => dest.LACInfoId, opts => opts.MapFrom(src => src.LACInfoId))
                    .ForMember(dest => dest.LACRefStatus, opts => opts.MapFrom(src => src.LACRefStatus))
                    .ForMember(dest => dest.LFGroupCode, opts => opts.MapFrom(src => src.LFGroupCode));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCasePartyLACDetailToCasePartyLACDetailEntity", ex);
                throw;
            }
        }

        internal void MapCasePartyStatusHistoryToCasePartyStatusHistoryEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyStatusHistory, CasePartyStatusHistoryEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCasePartyStatusHistoryToCasePartyStatusHistoryEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CaseParty"/> to <see cref="CasePartyEntity"/>.
        /// </summary>
        internal void MapCasePartyToCasePartyEntity()
        {
            try
            {
                Mapper.CreateMap<CaseParty, CasePartyEntity>()
                    .ForMember(desc => desc.ApplicantCapacityRemarks, opts => opts.MapFrom(src => src.ApplicantCapacityRemarks))
                    .ForMember(desc => desc.BirthCountryRemarks, opts => opts.MapFrom(src => src.BirthCountryRemarks))
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(desc => desc.CompanyName, opts => opts.MapFrom(src => src.CompanyName))
                    .ForMember(desc => desc.ContactTypeInd, opts => opts.MapFrom(src => src.ContactTypeInd))
                    .ForMember(desc => desc.DateOfBirth, opts => opts.MapFrom(src => src.DateOfBirth))
                    .ForMember(desc => desc.DateOfRegistration, opts => opts.MapFrom(src => src.DateOfRegistration))
                    .ForMember(desc => desc.DateofService, opts => opts.MapFrom(src => src.DateofService))
                    .ForMember(desc => desc.DialectRemarks, opts => opts.MapFrom(src => src.DialectRemarks))
                    .ForMember(desc => desc.DisablePersonInd, opts => opts.MapFrom(src => src.DisablePersonInd))
                    .ForMember(desc => desc.DisablePersonRemarks, opts => opts.MapFrom(src => src.DisablePersonRemarks))
                    .ForMember(desc => desc.Email, opts => opts.MapFrom(src => src.Email))
                    .ForMember(desc => desc.FaxAreaCode, opts => opts.MapFrom(src => src.FaxAreaCode))
                    .ForMember(desc => desc.FaxCountryCode, opts => opts.MapFrom(src => src.FaxCountryCode))
                    .ForMember(desc => desc.FaxNumber, opts => opts.MapFrom(src => src.FaxNumber))
                    .ForMember(desc => desc.FormerCompanyName, opts => opts.MapFrom(src => src.FormerCompanyName))
                    .ForMember(desc => desc.FormerPersonName, opts => opts.MapFrom(src => src.FormerPersonName))
                    .ForMember(desc => desc.FullName, opts => opts.MapFrom(src => src.FullName))
                    .ForMember(desc => desc.HasLAC, opts => opts.MapFrom(src => src.HasLAC))
                    .ForMember(desc => desc.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(desc => desc.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                    .ForMember(desc => desc.IsActiveInd, opts => opts.MapFrom(src => src.IsActiveInd))
                    .ForMember(desc => desc.IsPartyServiedWrit, opts => opts.MapFrom(src => src.IsPartyServiedWrit))
                    .ForMember(desc => desc.IsSingaporeanPR, opts => opts.MapFrom(src => src.IsSingaporePR))
                    .ForMember(desc => desc.LanguageCode, opts => opts.MapFrom(src => src.LanguageCode))
                    .ForMember(desc => desc.LanguageRemarks, opts => opts.MapFrom(src => src.LanguageRemarks))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LFAddressId, opts => opts.MapFrom(src => src.LFAddressId))
                    .ForMember(desc => desc.MobileCountryCode, opts => opts.MapFrom(src => src.MobileCountryCode))
                    .ForMember(desc => desc.MarriageDt, opts => opts.MapFrom(src => src.MarriageDt))
                    .ForMember(desc => desc.NationalityRemarks, opts => opts.MapFrom(src => src.NationalityRemarks))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.PartyStatusDate, opts => opts.MapFrom(src => src.PartyStatusDate))
                    .ForMember(desc => desc.RedActName, opts => opts.MapFrom(src => src.RedActName))
                    .ForMember(desc => desc.MobileNumber, opts => opts.MapFrom(src => src.MobileNumber))
                    .ForMember(desc => desc.NationalityRemarks, opts => opts.MapFrom(src => src.NationalityRemarks))
                    .ForMember(desc => desc.OccupationRemarks, opts => opts.MapFrom(src => src.OccupationRemarks))
                    .ForMember(desc => desc.OrdinalNumber, opts => opts.MapFrom(src => src.OrdinalNumber))
                    .ForMember(desc => desc.PartyNo, opts => opts.MapFrom(src => src.PartyNo))
                    .ForMember(desc => desc.RaceRemarks, opts => opts.MapFrom(src => src.RaceRemarks))
                    .ForMember(desc => desc.RelationshipRemarks, opts => opts.MapFrom(src => src.RelationshipRemarks))
                    .ForMember(desc => desc.ReligionRemarks, opts => opts.MapFrom(src => src.ReligionRemarks))
                    .ForMember(desc => desc.TelAreaCode, opts => opts.MapFrom(src => src.TelAreaCode))
                    .ForMember(desc => desc.TelCountryCode, opts => opts.MapFrom(src => src.TelCountryCode))
                    .ForMember(desc => desc.TelNumber, opts => opts.MapFrom(src => src.TelNumber))
                    .ForMember(desc => desc.MarriageCertNo, opts => opts.MapFrom(src => src.MarriageCertNo))
                    .ForMember(desc => desc.UEN, opts => opts.MapFrom(src => src.UEN))
                    .ForMember(desc => desc.VesselName, opts => opts.MapFrom(src => src.VesselName))
                    .ForMember(desc => desc.CapacityInd, opts => opts.MapFrom(src => src.CapacityInd))
                     .ForMember(desc => desc.VesselIDType, opts => opts.MapFrom(src => src.VesselIDType))
                     .ForMember(desc => desc.IsSubCaseOnlyParty, opts => opts.MapFrom(src => src.IsSubCaseOnlyParty));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyToCasePartyEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CasePartyVesselDetail"/> to <see cref="CasePartyVesselDetailsEntity"/>.
        /// </summary>
        internal void MapCasePartyVesselDetailToCasePartyVesselDetailEntity()
        {
            try
            {
                Mapper.CreateMap<CasePartyVesselDetail, CasePartyVesselDetailsEntity>()
                    .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(desc => desc.Description, opts => opts.MapFrom(src => src.Description))
                    .ForMember(desc => desc.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCasePartyVesselDetailToCasePartyVesselDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CaseSolicitorHistory"/> to <see cref="CaseSolicitorHistoryEntity"/>.
        /// </summary>
        internal void MapCaseSolicitorHistoryToCaseSolicitorHistoryEntity()
        {
            try
            {
                Mapper.CreateMap<CaseSolicitorHistory, CaseSolicitorHistoryEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(desc => desc.ChangeType, opts => opts.MapFrom(src => src.ChangeType))
                    .ForMember(desc => desc.EndDate, opts => opts.MapFrom(src => src.EndDate))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LFId, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId))
                    .ForMember(desc => desc.SolicitorId, opts => opts.MapFrom(src => src.SolicitorId))
                    .ForMember(desc => desc.StartDate, opts => opts.MapFrom(src => src.StartDate))
                    .ForMember(desc => desc.RepresentedBy, opts => opts.MapFrom(src => src.RepresentedBy))
                    .ForMember(desc => desc.JACInd, opts => opts.MapFrom(src => src.JACInd))
                    .ForMember(desc => desc.LASCOInd, opts => opts.MapFrom(src => src.LASCOInd))
                    .ForMember(desc => desc.CLASInd, opts => opts.MapFrom(src => src.CLASInd))
                    .ForMember(desc => desc.ACLASInd, opts => opts.MapFrom(src => src.ACLASInd))
                    .ForMember(desc => desc.DateAppointed, opts => opts.MapFrom(src => src.DateAppointed))
                    .ForMember(desc => desc.DateDischarged, opts => opts.MapFrom(src => src.DateDischarged))
                    .ForMember(desc => desc.CounselInd, opts => opts.MapFrom(src => src.CounselInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCaseSolicitorHistoryToCaseSolicitorHistoryEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CaseSolicitor"/> to <see cref="CaseSolicitorEntity"/>.
        /// </summary>
        internal void MapCaseSolicitorToCaseSolicitorEntity()
        {
            try
            {
                Mapper.CreateMap<CaseSolicitor, CaseSolicitorEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LFId, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(desc => desc.RecId, opts => opts.MapFrom(src => src.RecId))
                    .ForMember(desc => desc.SolicitorId, opts => opts.MapFrom(src => src.SolicitorId))
                    .ForMember(desc => desc.StartDate, opts => opts.MapFrom(src => src.StartDate))
                    .ForMember(desc => desc.RepresentedBy, opts => opts.MapFrom(src => src.RepresentedBy))
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
                Logger.Error("Error at MapCaseSolicitorToCaseSolicitorEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="HearingAdminSupport"/> to <see cref="HearingAdminSupportEntity"/>.
        /// </summary>
        internal void MapHearingAdminSupportToHearingAdminSupportEntity()
        {
            try
            {
                Mapper.CreateMap<HearingAdminSupport, HearingAdminSupportEntity>()
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapHearingAdminSupportToHearingAdminSupportEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="Hearing"/> to <see cref="HearingEntity"/>.
        /// </summary>
        internal void MapHearingToHearingEntity()
        {
            try
            {
                Mapper.CreateMap<Hearing, HearingEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.ComputedHearingFee, opts => opts.MapFrom(src => src.ComputedHearingFee))
                    .ForMember(dest => dest.ComputedHearingFeeDatetime, opts => opts.MapFrom(src => src.ComputedHearingFeeDatetime))
                    .ForMember(dest => dest.CountAsCDRSession, opts => opts.MapFrom(src => src.CountAsCDRSession))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.DsgName, opts => opts.MapFrom(src => src.DsgName))
                    .ForMember(dest => dest.eHearingInd, opts => opts.MapFrom(src => src.EHearingInd))
                    .ForMember(dest => dest.eHearingStatus, opts => opts.MapFrom(src => src.EHearingStatus))
                    .ForMember(dest => dest.EndDateTime, opts => opts.MapFrom(src => src.EndDateTime))
                    .ForMember(dest => dest.EstimatedHearingFee, opts => opts.MapFrom(src => src.EstimatedHearingFee))
                    .ForMember(dest => dest.EstimatedHearingFeeDatetime, opts => opts.MapFrom(src => src.EstimatedHearingFeeDatetime))
                    .ForMember(dest => dest.FinalAdjournment, opts => opts.MapFrom(src => src.FinalAdjournment))
                    .ForMember(dest => dest.HearingModeInd, opts => opts.MapFrom(src => src.HearingModeInd))
                    .ForMember(dest => dest.HRGApproveInd, opts => opts.MapFrom(src => src.HRGApproveInd))
                    .ForMember(dest => dest.HRGDateTime, opts => opts.MapFrom(src => src.HRGDateTime))
                    .ForMember(dest => dest.HRGID, opts => opts.MapFrom(src => src.HRGID))
                    .ForMember(dest => dest.HRGInstructions, opts => opts.MapFrom(src => src.HRGInstructions))
                    .ForMember(dest => dest.HRGLockInd, opts => opts.MapFrom(src => src.HRGLockInd))
                    .ForMember(dest => dest.HRGOutcomeApprInd, opts => opts.MapFrom(src => src.HRGOutcomeApprInd))
                    //.ForMember(dest => dest.HRGOutComeCode, opts => opts.MapFrom(src => src.HRGOutComeCode))
                    .ForMember(dest => dest.HRGOutcomeRemarks, opts => opts.MapFrom(src => src.HRGOutcomeRemarks))
                    .ForMember(dest => dest.HRGOutComeRSNCode, opts => opts.MapFrom(src => src.HRGOutComeRSNCode))
                    .ForMember(dest => dest.HRGRoomCode, opts => opts.MapFrom(src => src.HRGRoomCode))
                    .ForMember(dest => dest.HRGSlotcode, opts => opts.MapFrom(src => src.HRGSlotcode))
                    .ForMember(dest => dest.HRGTrench, opts => opts.MapFrom(src => src.HRGTrench))
                    .ForMember(dest => dest.HRGTypeCode, opts => opts.MapFrom(src => src.HRGTypeCode))
                    .ForMember(dest => dest.IndicationsGiven, opts => opts.MapFrom(src => src.IndicationsGiven))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MultiDayInd, opts => opts.MapFrom(src => src.MultiDayInd))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.PartHeardInd, opts => opts.MapFrom(src => src.PartHeardInd))
                    .ForMember(dest => dest.QueueNo, opts => opts.MapFrom(src => src.QueueNo))
                    .ForMember(dest => dest.SCInd, opts => opts.MapFrom(src => src.SCInd))
                    .ForMember(dest => dest.SpecialHrgDateInd, opts => opts.MapFrom(src => src.SpecialHrgDateInd))
                    .ForMember(dest => dest.StartDateTime, opts => opts.MapFrom(src => src.StartDateTime))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(dest => dest.ToShow, opts => opts.MapFrom(src => src.ToShow))
                    .ForMember(dest => dest.UserId, opts => opts.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.UserName, opts => opts.MapFrom(src => src.USERNAME))
                    .ForMember(dest => dest.WorkflowSerialNo, opts => opts.MapFrom(src => src.WorkflowSerialNo))
                    .ForMember(dest => dest.IsCDRRefixed, opts => opts.MapFrom(src => src.IsCDRRefixed));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapHearingToHearingEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LawFirmCaseFileRefNumber"/> to <see cref="LawFirmCaseFileRefNumberEntity"/>.
        /// </summary>
        internal void MapLawFirmCaseFileRefNumberToLawFirmCaseFileRefNumberEntity()
        {
            try
            {
                Mapper.CreateMap<LawFirmCaseFileRefNumber, LawFirmCaseFileRefNumberEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.LFFileRefNumber, opts => opts.MapFrom(src => src.LFFileRefNumber))
                    .ForMember(desc => desc.LFCFRNId, opts => opts.MapFrom(src => src.LFCFRNId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLawFirmCaseFileRefNumberToLawFirmCaseFileRefNumberEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RCaseLawFirm"/> to <see cref="RCaseLawFirmEntity"/>.
        /// </summary>
        internal void MapRCaseLawFirmToRCaseLawFirmEntity()
        {
            try
            {
                Mapper.CreateMap<RCaseLawFirm, RCaseLawFirmEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.RCLFId, opts => opts.MapFrom(src => src.RCLFId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRCaseLawFirmToRCaseLawFirmEntity", ex);
                throw;
            }
        }

        /** End of For Criminal Entities **/
        /// <summary>
        /// Maps objects from <see cref="RCaseLinked"/> to <see cref="RCaseLinkedEntity"/>.
        /// </summary>
        internal void MapRCaseLinkedToRCaseLinkedEntity()
        {
            try
            {
                Mapper.CreateMap<RCaseLinked, RCaseLinkedEntity>()
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRCaseLinkedToRCaseLinkedEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RCaseSubmission"/> to <see cref="RCaseSubmissionEntity"/>.
        /// </summary>
        internal void MapRCaseSubmissionToRCaseSubmissionEntity()
        {
            try
            {
                Mapper.CreateMap<RCaseSubmission, RCaseSubmissionEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.RCaseSubmissionId, opts => opts.MapFrom(src => src.RCaseSubmissionId))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRCaseSubmissionToRCaseSubmissionEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="RCaseTransfer"/> to <see cref="RCaseTransferEntity"/>.
        /// </summary>
        internal void MapRCaseTransferToRCaseTransferEntity()
        {
            try
            {
                Mapper.CreateMap<RCaseTransfer, RCaseTransferEntity>()
                    .ForMember(dest => dest.FrCaseInfoId, opts => opts.MapFrom(src => src.FrCaseInfoID))
                    .ForMember(dest => dest.ToCaseInfoId, opts => opts.MapFrom(src => src.ToCaseInfoID))
                    .ForMember(dest => dest.FrCasePaymentMode, opts => opts.MapFrom(src => src.FrCasePaymentMode));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRCaseTransferToRCaseTransferEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="RLawFirmSolicitors"/> to <see cref="RLawFirmSolicitorsEntity"/>.
        /// </summary>
        internal void MapRLawFirmSolicitorsToRLawFirmSolicitorsEntity()
        {
            try
            {
                Mapper.CreateMap<RLawFirmSolicitors, RLawFirmSolicitorsEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRLawFirmSolicitorsToRLawFirmSolicitorsEntity", ex);
                throw;
            }
        }

        internal void MapRCaseConsolidateToRCaseConsolidateEntity()
        {
            try
            {
                Mapper.CreateMap<RCaseConsolidate, RCaseConsolidateEntity>()
                    .ForMember(dest => dest.CaseInfoID, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.ConCaseInfoID, opts => opts.MapFrom(src => src.ConCaseInfoID));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRCaseConsolidateToRCaseConsolidateEntity", ex);
                throw;
            }
        }

        internal void MapHearingCoramToHearingCoramEntity()
        {
            try
            {
                Mapper.CreateMap<HearingCoram, HearingCoramEntity>()
                    .ForMember(dest => dest.HearingCoramId, opts => opts.MapFrom(src => src.HearingCoramId))
                    .ForMember(dest => dest.HRGId, opts => opts.MapFrom(src => src.HRGId))
                    .ForMember(dest => dest.MainCoramIndicator, opts => opts.MapFrom(src => src.MainCoramIndicator))
                    .ForMember(dest => dest.UserId, opts => opts.MapFrom(src => src.UserId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapHearingCoramToHearingCoramEntity", ex);
                throw;
            }
        }
        internal void MapInterimCasePartyStatusToInterimCasePartyStatusEntity()
        {
            try
            {
                Mapper.CreateMap<InterimCasePartyStatus, InterimCasePartyStatusEntity>();
                    
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapInterimCasePartyStatusToInterimCasePartyStatusEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Map Hearings the outcome flag to hearing outcome flag entity.
        /// </summary>
        internal void MapHearingOutcomeFlagToHearingOutcomeFlagEntity()
        {
            try
            {
                Mapper.CreateMap<HearingOutcomeFlag, HearingOutcomeFlagEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }
        }

        internal void MapTransferOrderOfCourtToTransferOrderOfCourtEntity()
        {
            try
            {
                Mapper.CreateMap<TransferOrderOfCourt, TransferOrderOfCourtEntity>()
                    .ForMember(dest => dest.CaseInfoID, opts => opts.MapFrom(src => src.CaseInfoID))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
                  
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapTransferOrderOfCourtToTransferOrderOfCourtEntity", ex);
                throw;
            }
        }

        internal void MapPartyCaseFileRefNumberToPartyCaseFileRefNumberEntity()
        {
            try
            {
                Mapper.CreateMap<PartyCaseFileRefNumber, PartyCaseFileRefNumberEntity>()
                    .ForMember(dest => dest.CaseInfoID, opts => opts.MapFrom(src => src.CaseInfoID))
                    .ForMember(desc => desc.CasePartyID, opts => opts.MapFrom(src => src.CasePartyID))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.LFFileRefNumber, opts => opts.MapFrom(src => src.LFFileRefNumber));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPartyCaseFileRefNumberToPartyCaseFileRefNumberEntity", ex);
                throw;
            }
        }

        internal void MapCaseInfoNumberToCaseInfoNumberEntity()
        {
            try
            {
                Mapper.CreateMap<CaseInfoNumber, CaseInfoNumberEntity>()
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseInfoNumberToCaseInfoNumberEntity", ex);
                throw;
            }
        }

        #endregion Methods
    }
}