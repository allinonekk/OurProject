#region Header

/*****************************************************************************************************
* Description : This file handles mapping for LAP from Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   11/10/2010   		        Yan Nai                 Created
*   27/10/2010                  Swaroop                 Added logging and comments.
*****************************************************************************************************/
// <summary>
// File: LAPMapping.cs
// Description: This file handles mapping for LAP from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "LAPMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain.LAP;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for LAP from Domain objects to NHibernate entities.
    /// </summary>
    internal class LAPMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LAPMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method which maps the <see cref="LABPartyAddressEntity"/> to <see cref="LABPartyAddress"/>.
        /// </summary>
        internal void MapLABPartyAddressEntityToLABPartyAddress()
        {
            try
            {
                Mapper.CreateMap<LABPartyAddressEntity, LABPartyAddress>()
                    .ForMember(dest => dest.Addr1, opts => opts.MapFrom(src => src.Addr1))
                    .ForMember(dest => dest.Addr2, opts => opts.MapFrom(src => src.Addr2))
                    .ForMember(dest => dest.Addr3, opts => opts.MapFrom(src => src.Addr3))
                    .ForMember(dest => dest.Addr4, opts => opts.MapFrom(src => src.Addr4))
                    .ForMember(dest => dest.Address, opts => opts.MapFrom(src => src.Address))
                    .ForMember(dest => dest.AddrType, opts => opts.ResolveUsing<AddressTypeToStringResolver>().FromMember(src => src.AddrType))
                    .ForMember(dest => dest.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                    .ForMember(dest => dest.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                    .ForMember(dest => dest.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
                    .ForMember(dest => dest.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                    .ForMember(dest => dest.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                    .ForMember(dest => dest.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(dest => dest.LABPartyAddressId, opts => opts.MapFrom(src => src.LABPartyAddressId))
                    .ForMember(dest => dest.LABPartyId, opts => opts.MapFrom(src => src.LABPartyId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MailingInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MailingInd))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                    .ForMember(dest => dest.StreetName, opts => opts.MapFrom(src => src.StreetName))
                    .ForMember(dest => dest.UnitNo, opts => opts.MapFrom(src => src.UnitNo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLABPartyAddressEntityToLABPartyAddress", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LABPartyAddressHistoryEntity"/> to <see cref="LABPartyAddressHistory"/>.
        /// </summary>
        internal void MapLABPartyAddressHistoryEntityToLABPartyAddressHistory()
        {
            try
            {
                Mapper.CreateMap<LABPartyAddressHistoryEntity, LABPartyAddressHistory>()
                    .ForMember(dest => dest.Addr1, opts => opts.MapFrom(src => src.Addr1))
                    .ForMember(dest => dest.Addr2, opts => opts.MapFrom(src => src.Addr2))
                    .ForMember(dest => dest.Addr3, opts => opts.MapFrom(src => src.Addr3))
                    .ForMember(dest => dest.Addr4, opts => opts.MapFrom(src => src.Addr4))
                    .ForMember(dest => dest.Address, opts => opts.MapFrom(src => src.Address))
                    .ForMember(dest => dest.AddrType, opts => opts.ResolveUsing<AddressTypeToStringResolver>().FromMember(src => src.AddrType))
                    .ForMember(dest => dest.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                    .ForMember(dest => dest.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                    .ForMember(dest => dest.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
                    .ForMember(dest => dest.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                    .ForMember(dest => dest.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                    .ForMember(dest => dest.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(dest => dest.LABPartyAddressHistoryId, opts => opts.MapFrom(src => src.LABPartyAddressHistoryId))
                    .ForMember(dest => dest.LABPartyId, opts => opts.MapFrom(src => src.LABPartyId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MailingInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MailingInd))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                    .ForMember(dest => dest.StreetName, opts => opts.MapFrom(src => src.StreetName))
                    .ForMember(dest => dest.UnitNo, opts => opts.MapFrom(src => src.UnitNo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLABPartyAddressHistoryEntityToLABPartyAddressHistory", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LABPartyEntity"/> to <see cref="LABParty"/>.
        /// </summary>
        internal void MapLABPartyEntityToLABParty()
        {
            try
            {
                Mapper.CreateMap<LABPartyEntity, LABParty>()
                    .ForMember(dest => dest.ContactTypeInd, opts => opts.ResolveUsing<ContactTypeToStringResolver>().FromMember(src => src.ContactTypeInd))
                    .ForMember(dest => dest.Email, opts => opts.MapFrom(src => src.Email))
                    .ForMember(dest => dest.FaxAreaCode, opts => opts.MapFrom(src => src.FaxAreaCode))
                    .ForMember(dest => dest.FaxCountryCode, opts => opts.MapFrom(src => src.FaxCountryCode))
                    .ForMember(dest => dest.FaxNumber, opts => opts.MapFrom(src => src.FaxNumber))
                    .ForMember(dest => dest.FullName, opts => opts.MapFrom(src => src.FullName))
                    .ForMember(dest => dest.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(dest => dest.LABPartyId, opts => opts.MapFrom(src => src.LABPartyId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MobileCountryCode, opts => opts.MapFrom(src => src.MobileCountryCode))
                    .ForMember(dest => dest.MobileNumber, opts => opts.MapFrom(src => src.MobileNumber))
                    .ForMember(dest => dest.TelAreaCode, opts => opts.MapFrom(src => src.TelAreaCode))
                    .ForMember(dest => dest.TelCountryCode, opts => opts.MapFrom(src => src.TelCountryCode))
                    .ForMember(dest => dest.TelNumber, opts => opts.MapFrom(src => src.TelNumber));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLABPartyEntityToLABParty", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LABPartyHistoryEntity"/> to <see cref="LABPartyHistory"/>.
        /// </summary>
        internal void MapLABPartyHistoryEntityToLABPartyHistory()
        {
            try
            {
                Mapper.CreateMap<LABPartyHistoryEntity, LABPartyHistory>()
                    .ForMember(dest => dest.ContactTypeInd, opts => opts.ResolveUsing<ContactTypeToStringResolver>().FromMember(src => src.ContactTypeInd))
                    .ForMember(dest => dest.Email, opts => opts.MapFrom(src => src.Email))
                    .ForMember(dest => dest.FaxAreaCode, opts => opts.MapFrom(src => src.FaxAreaCode))
                    .ForMember(dest => dest.FaxCountryCode, opts => opts.MapFrom(src => src.FaxCountryCode))
                    .ForMember(dest => dest.FaxNumber, opts => opts.MapFrom(src => src.FaxNumber))
                    .ForMember(dest => dest.FullName, opts => opts.MapFrom(src => src.FullName))
                    .ForMember(dest => dest.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(dest => dest.LABPartyId, opts => opts.MapFrom(src => src.LABPartyId))
                    .ForMember(dest => dest.LABPartyHistoryId, opts => opts.MapFrom(src => src.LABPartyHistoryId))
                    .ForMember(dest => dest.LACDocDetailId, opts => opts.MapFrom(src => src.LACDocDetailId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MobileCountryCode, opts => opts.MapFrom(src => src.MobileCountryCode))
                    .ForMember(dest => dest.MobileNumber, opts => opts.MapFrom(src => src.MobileNumber))
                    .ForMember(dest => dest.TelCountryCode, opts => opts.MapFrom(src => src.TelCountryCode))
                    .ForMember(dest => dest.TelNumber, opts => opts.MapFrom(src => src.TelCountryCode));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLABPartyHistoryEntityToLABPartyHistory", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LABPartySolicitorEntity"/> to <see cref="LABPartySolicitor"/>.
        /// </summary>
        internal void MapLABPartySolicitorEntityToLABPartySolicitor()
        {
            try
            {
                Mapper.CreateMap<LABPartySolicitorEntity, LABPartySolicitor>()
                    .ForMember(dest => dest.LABPartyId, opts => opts.MapFrom(src => src.LABPartyId))
                    .ForMember(dest => dest.LABPartySolicitorId, opts => opts.MapFrom(src => src.LABPartySolicitorId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(dest => dest.RepresentedBy, opts => opts.ResolveUsing<PartyRepresentedByToStringResolver>().FromMember(src => src.RepresentedBy))
                    .ForMember(dest => dest.SolicitorId, opts => opts.MapFrom(src=>src.SolicitorId))
                    .ForMember(dest => dest.SolicitorName, opts => opts.MapFrom(src => src.SolicitorName))
                    .ForMember(dest => dest.StartDate, opts => opts.MapFrom(src => src.StartDate))
                    .ForMember(dest => dest.UEN, opts => opts.MapFrom(src => src.UEN));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLABPartySolicitorEntityToLABPartySolicitor", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LABPartySolicitorHistoryEntity"/> to <see cref="LABPartySolicitorHistory"/>.
        /// </summary>
        internal void MapLABPartySolicitorHistoryEntityToLABPartySolicitorHistory()
        {
            try
            {
                Mapper.CreateMap<LABPartySolicitorHistoryEntity, LABPartySolicitorHistory>()
                    .ForMember(dest => dest.LABPartyHistoryId, opts => opts.MapFrom(src => src.LABPartyHistoryId))
                    .ForMember(dest => dest.LABPartyId, opts => opts.MapFrom(src => src.LABPartyId))
                    .ForMember(dest => dest.LABPartySolicitorHistoryId, opts => opts.MapFrom(src => src.LABPartySolicitorHistoryId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(dest => dest.RepresentedBy, opts => opts.ResolveUsing<PartyRepresentedByToStringResolver>().FromMember(src => src.RepresentedBy))
                    .ForMember(dest => dest.SolicitorId, opts => opts.MapFrom(src=>src.SolicitorId))
                    .ForMember(dest => dest.SolicitorName, opts => opts.MapFrom(src => src.SolicitorName))
                    .ForMember(dest => dest.UEN, opts => opts.MapFrom(src => src.UEN));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLABPartySolicitorHistoryEntityToLABPartySolicitorHistory", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LABSection17CertInfoEntity"/> to <see cref="LABSection17CertInfo"/>.
        /// </summary>
        internal void MapLABSection17CertInfoEntityToLABSection17CertInfo()
        {
            try
            {
                Mapper.CreateMap<LABSection17CertInfoEntity, LABSection17CertInfo>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.IsGAPGAFiled, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsGAPGAFiled))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.Section17CertId, opts => opts.MapFrom(src => src.Section17CertId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLABSection17CertInfoEntityToLABSection17CertInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LACCancellationInfoEntity"/> to <see cref="LACCancellationInfo"/>.
        /// </summary>
        internal void MapLACCancellationInfoEntityToLACCancellationInfo()
        {
            try
            {
                Mapper.CreateMap<LACCancellationInfoEntity, LACCancellationInfo>()
                    .ForMember(dest => dest.CancellationId, opts => opts.MapFrom(src => src.CancellationId))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.LACInfoId, opts => opts.MapFrom(src => src.LACInfoId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLACCancellationInfoEntityToLACCancellationInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LACDocumentDetailEntity"/> to <see cref="LACDocumentDetail"/>.
        /// </summary>
        internal void MapLACDocumentDetailEntityToLACDocumentDetail()
        {
            try
            {
                Mapper.CreateMap<LACDocumentDetailEntity, LACDocumentDetail>()
                    .ForMember(dest => dest.CasePartyLACDetails, opts => opts.Ignore())
                    .ForMember(dest => dest.CasePartyLACDetailsHistories, opts => opts.Ignore())
                    .ForMember(dest => dest.DocCasePartyLACDetails, opts => opts.Ignore())
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.ExpiredDateTime, opts => opts.MapFrom(src => src.ExpiredDateTime))
                    .ForMember(dest => dest.ExpiryDateTime, opts => opts.MapFrom(src => src.ExpiryDateTime))
                    .ForMember(dest => dest.IssuedDateTime, opts => opts.MapFrom(src => src.IssuedDateTime))
                    .ForMember(dest => dest.LABPartyHistories, opts => opts.Ignore())
                    .ForMember(dest => dest.LACDocDetailId, opts => opts.MapFrom(src => src.LACDocDetailId))
                    .ForMember(dest => dest.LACDocStatus, opts => opts.ResolveUsing<LACDocStatusToStringResolver>().FromMember(src => src.LACDocStatus))
                    .ForMember(dest => dest.LACDocumentDrafts, opts => opts.Ignore())
                    .ForMember(dest => dest.LACDocumentRemarks, opts => opts.Ignore())
                    .ForMember(dest => dest.LACInfoId, opts => opts.MapFrom(src => src.LACInfoId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.VersionNo, opts => opts.MapFrom(src => src.VersionNo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLACDocumentDetailEntityToLACDocumentDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LACDocumentDraftEntity"/> to <see cref="LACDocumentDraft"/>.
        /// </summary>
        internal void MapLACDocumentDraftEntityToLACDocumentDraft()
        {
            try
            {
                Mapper.CreateMap<LACDocumentDraftEntity, LACDocumentDraft>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(dest => dest.LACDocDetailId, opts => opts.MapFrom(src => src.LACDocDetailId))
                    .ForMember(dest => dest.LACDocDraftId, opts => opts.MapFrom(src => src.LACDocDraftId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLACDocumentDraftEntityToLACDocumentDraft", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LACDocumentRemarkEntity"/> to <see cref="LACDocumentRemark"/>.
        /// </summary>
        internal void MapLACDocumentRemarkEntityToLACDocumentRemark()
        {
            try
            {
                Mapper.CreateMap<LACDocumentRemarkEntity, LACDocumentRemark>()
                    .ForMember(dest => dest.LACDocDetailId, opts => opts.MapFrom(src => src.LACDocDetailId))
                    .ForMember(dest => dest.LACDocRemarkId, opts => opts.MapFrom(src => src.LACDocRemarkId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.Remarks, opts => opts.MapFrom(src => src.Remarks));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLACDocumentRemarkEntityToLACDocumentRemark", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LACInfoEntity"/> to <see cref="LACInfo"/>.
        /// </summary>
        internal void MapLACInfoEntityToLACInfo()
        {
            try
            {
                Mapper.CreateMap<LACInfoEntity, LACInfo>()
                    .ForMember(dest => dest.CancellationDateTime, opts => opts.MapFrom(src => src.CancellationDateTime))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.CasePartyLACDetails, opts => opts.Ignore())
                    .ForMember(dest => dest.CasePartyLACDetailsHistories, opts => opts.Ignore())
                    .ForMember(dest => dest.ClosedDateTime, opts => opts.MapFrom(src => src.ClosedDateTime))
                    .ForMember(dest => dest.ConcludedDateTime, opts => opts.MapFrom(src => src.ConcludedDateTime))
                    .ForMember(dest => dest.DocCasePartyLACDetails, opts => opts.Ignore())
                    .ForMember(dest => dest.ExpiredDateTime, opts => opts.MapFrom(src => src.ExpiredDateTime))
                    .ForMember(dest => dest.IssuedDateTime, opts => opts.MapFrom(src => src.IssuedDateTime))
                    .ForMember(dest => dest.LABPartyId, opts => opts.MapFrom(src => src.LABPartyId))
                    .ForMember(dest => dest.LACCancellationInfos, opts => opts.Ignore())
                    .ForMember(dest => dest.LACConcludedStatus, opts => opts.ResolveUsing<LACConcludedStatusToStringResolver>().FromMember(src => src.LACConcludedStatus))
                    .ForMember(dest => dest.LACDocumentDetails, opts => opts.Ignore())
                    .ForMember(dest => dest.LACInfoId, opts => opts.MapFrom(src => src.LACInfoId))
                    .ForMember(dest => dest.LACNo, opts => opts.MapFrom(src => src.LACNo))
                    .ForMember(dest => dest.LACStatus, opts => opts.ResolveUsing<LACStatusToStringResolver>().FromMember(src => src.LACStatus))
                    .ForMember(dest => dest.LACType, opts => opts.MapFrom(src => src.LACType))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.RevocationDateTime, opts => opts.MapFrom(src => src.RevocationDateTime));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLACInfoEntityToLACInfo", ex);
                throw;
            }
        }

        #endregion Methods
    }
}