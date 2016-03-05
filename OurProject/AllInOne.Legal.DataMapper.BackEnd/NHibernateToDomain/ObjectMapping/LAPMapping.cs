#region Header

/*****************************************************************************************************
* Description : This file handles mapping for LAP from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   11/10/2010   		        Yan Nai                 Created
*   01/11/2010                  Swaroop                 Added logging and comments.
*****************************************************************************************************/
// <summary>
// File: LAPMapping.cs
// Description: This file handles mapping for LAP from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "LAPMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.LAP;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for LAP from NHibernate entities to Domain objects.
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
        /// Method which maps the <see cref="LABPartyAddressHistory"/> to <see cref="LABPartyAddressHistoryEntity"/>.
        /// </summary>
        internal void MapLABPartyAddressHistoryToLABPartyAddressHistoryEntity()
        {
            try
            {
                Mapper.CreateMap<LABPartyAddressHistory, LABPartyAddressHistoryEntity>()
                    .ForMember(dest => dest.Addr1, opts => opts.MapFrom(src => src.Addr1))
                    .ForMember(dest => dest.Addr2, opts => opts.MapFrom(src => src.Addr2))
                    .ForMember(dest => dest.Addr3, opts => opts.MapFrom(src => src.Addr3))
                    .ForMember(dest => dest.Addr4, opts => opts.MapFrom(src => src.Addr4))
                    .ForMember(dest => dest.Address, opts => opts.MapFrom(src => src.Address))
                    .ForMember(dest => dest.AddrType, opts => opts.MapFrom(src => src.AddrType))
                    .ForMember(dest => dest.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                    .ForMember(dest => dest.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                    .ForMember(dest => dest.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
                    .ForMember(dest => dest.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                    .ForMember(dest => dest.FormatInd, opts => opts.MapFrom(src => src.FormatInd))
                    .ForMember(dest => dest.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(dest => dest.LABPartyAddressHistoryId, opts => opts.MapFrom(src => src.LABPartyAddressHistoryId))
                    .ForMember(dest => dest.LABPartyId, opts => opts.MapFrom(src => src.LABPartyId))
                    .ForMember(dest => dest.LABPartyHistoryId, opts => opts.MapFrom(src => src.LABPartyHistoryId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MailingInd, opts => opts.MapFrom(src => src.MailingInd))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                    .ForMember(dest => dest.StreetName, opts => opts.MapFrom(src => src.StreetName))
                    .ForMember(dest => dest.UnitNo, opts => opts.MapFrom(src => src.UnitNo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLABPartyAddressHistoryToLABPartyAddressHistoryEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LABPartyAddress"/> to <see cref="LABPartyAddressEntity"/>.
        /// </summary>
        internal void MapLABPartyAddressToLABPartyAddressEntity()
        {
            try
            {
               Mapper.CreateMap<LABPartyAddress, LABPartyAddressEntity>()
                    .ForMember(dest => dest.Addr1, opts => opts.MapFrom(src => src.Addr1))
                    .ForMember(dest => dest.Addr2, opts => opts.MapFrom(src => src.Addr2))
                    .ForMember(dest => dest.Addr3, opts => opts.MapFrom(src => src.Addr3))
                    .ForMember(dest => dest.Addr4, opts => opts.MapFrom(src => src.Addr4))
                    .ForMember(dest => dest.Address, opts => opts.MapFrom(src => src.Address))
                    .ForMember(dest => dest.AddrType, opts => opts.MapFrom(src => src.AddrType))
                    .ForMember(dest => dest.BlkNo, opts => opts.MapFrom(src => src.BlkNo))
                    .ForMember(dest => dest.BuildingName, opts => opts.MapFrom(src => src.BuildingName))
                    .ForMember(dest => dest.CountryCode, opts => opts.MapFrom(src => src.CountryCode))
                    .ForMember(dest => dest.FloorNo, opts => opts.MapFrom(src => src.FloorNo))
                    .ForMember(dest => dest.FormatInd, opts => opts.MapFrom(src => src.FormatInd))
                    .ForMember(dest => dest.ItemNo, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(dest => dest.LABPartyAddressId, opts => opts.MapFrom(src => src.LABPartyAddressId))
                    .ForMember(dest => dest.LABPartyId, opts => opts.MapFrom(src => src.LABPartyId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MailingInd, opts => opts.MapFrom(src => src.MailingInd))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                    .ForMember(dest => dest.StreetName, opts => opts.MapFrom(src => src.StreetName))
                    .ForMember(dest => dest.UnitNo, opts => opts.MapFrom(src => src.UnitNo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLABPartyAddressToLABPartyAddressEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LABPartyHistory"/> to <see cref="LABPartyHistoryEntity"/>.
        /// </summary>
        internal void MapLABPartyHistoryToLABPartyHistoryEntity()
        {
            try
            {
                Mapper.CreateMap<LABPartyHistory, LABPartyHistoryEntity>()
                    .ForMember(dest => dest.ContactTypeInd, opts => opts.MapFrom(src => src.ContactTypeInd))
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
                Logger.Error("Error at MapLABPartyHistoryToLABPartyHistoryEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LABPartySolicitorHistory"/> to <see cref="LABPartySolicitorHistoryEntity"/>.
        /// </summary>
        internal void MapLABPartySolicitorHistoryToLABPartySolicitorHistoryEntity()
        {
            try
            {
                Mapper.CreateMap<LABPartySolicitorHistory, LABPartySolicitorHistoryEntity>()
                    .ForMember(dest => dest.LABPartyHistoryId, opts => opts.MapFrom(src => src.LABPartyHistoryId))
                    .ForMember(dest => dest.LABPartyId, opts => opts.MapFrom(src => src.LABPartyId))
                    .ForMember(dest => dest.LABPartySolicitorHistoryId, opts => opts.MapFrom(src => src.LABPartySolicitorHistoryId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(dest => dest.RepresentedBy, opts => opts.MapFrom(src => src.RepresentedBy))
                    .ForMember(dest => dest.SolicitorId, opts => opts.MapFrom(src => src.SolicitorId))
                    .ForMember(dest => dest.SolicitorName, opts => opts.MapFrom(src => src.SolicitorName))
                    .ForMember(dest => dest.UEN, opts => opts.MapFrom(src => src.UEN));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLABPartySolicitorHistoryToLABPartySolicitorHistoryEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LABPartySolicitor"/> to <see cref="LABPartySolicitorEntity"/>.
        /// </summary>
        internal void MapLABPartySolicitorToLABPartySolicitorEntity()
        {
            try
            {
                Mapper.CreateMap<LABPartySolicitor, LABPartySolicitorEntity>()
                    .ForMember(dest => dest.LABPartyId, opts => opts.MapFrom(src => src.LABPartyId))
                    .ForMember(dest => dest.LABPartySolicitorId, opts => opts.MapFrom(src => src.LABPartySolicitorId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.LFID, opts => opts.MapFrom(src => src.LFID))
                    .ForMember(dest => dest.RepresentedBy, opts => opts.MapFrom(src => src.RepresentedBy))
                    .ForMember(dest => dest.SolicitorId, opts => opts.MapFrom(src => src.SolicitorId))
                    .ForMember(dest => dest.SolicitorName, opts => opts.MapFrom(src => src.SolicitorName))
                    .ForMember(dest => dest.StartDate, opts => opts.MapFrom(src => src.StartDate))
                    .ForMember(dest => dest.UEN, opts => opts.MapFrom(src => src.UEN));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLABPartySolicitorToLABPartySolicitorEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LABParty"/> to <see cref="LABPartyEntity"/>.
        /// </summary>
        internal void MapLABPartyToLABPartyEntity()
        {
            try
            {
                Mapper.CreateMap<LABParty, LABPartyEntity>()
                    .ForMember(dest => dest.ContactTypeInd, opts => opts.MapFrom(src => src.ContactTypeInd))
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
                Logger.Error("Error at MapLABPartyToLABPartyEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LABSection17CertInfo"/> to <see cref="LABSection17CertInfoEntity"/>.
        /// </summary>
        internal void MapLABSection17CertInfoToLABSection17CertInfoEntity()
        {
            try
            {
                Mapper.CreateMap<LABSection17CertInfo, LABSection17CertInfoEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.IsGAPGAFiled, opts => opts.MapFrom(src => src.IsGAPGAFiled))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.Section17CertId, opts => opts.MapFrom(src => src.Section17CertId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLABSection17CertInfoToLABSection17CertInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LACCancellationInfo"/> to <see cref="LACCancellationInfoEntity"/>.
        /// </summary>
        internal void MapLACCancellationInfoToLACCancellationInfoEntity()
        {
            try
            {
                Mapper.CreateMap<LACCancellationInfo, LACCancellationInfoEntity>()
                    .ForMember(dest => dest.CancellationId, opts => opts.MapFrom(src => src.CancellationId))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.LACInfoId, opts => opts.MapFrom(src => src.LACInfoId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLACCancellationInfoToLACCancellationInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LACDocumentDetail"/> to <see cref="LACDocumentDetailEntity"/>.
        /// </summary>
        internal void MapLACDocumentDetailToLACDocumentDetailEntity()
        {
            try
            {
                Mapper.CreateMap<LACDocumentDetail, LACDocumentDetailEntity>()
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.ExpiredDateTime, opts => opts.MapFrom(src => src.ExpiredDateTime))
                    .ForMember(dest => dest.ExpiryDateTime, opts => opts.MapFrom(src => src.ExpiryDateTime))
                    .ForMember(dest => dest.IssuedDateTime, opts => opts.MapFrom(src => src.IssuedDateTime))
                    .ForMember(dest => dest.LACDocDetailId, opts => opts.MapFrom(src => src.LACDocDetailId))
                    .ForMember(dest => dest.LACDocStatus, opts => opts.MapFrom(src => src.LACDocStatus))
                    .ForMember(dest => dest.LACInfoId, opts => opts.MapFrom(src => src.LACInfoId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.VersionNo, opts => opts.MapFrom(src => src.VersionNo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLACDocumentDetailToLACDocumentDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LACDocumentDraft"/> to <see cref="LACDocumentDraftEntity"/>.
        /// </summary>
        internal void MapLACDocumentDraftToLACDocumentDraftEntity()
        {
            try
            {
                Mapper.CreateMap<LACDocumentDraft, LACDocumentDraftEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(dest => dest.LACDocDetailId, opts => opts.MapFrom(src => src.LACDocDetailId))
                    .ForMember(dest => dest.LACDocDraftId, opts => opts.MapFrom(src => src.LACDocDraftId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLACDocumentDraftToLACDocumentDraftEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LACDocumentRemark"/> to <see cref="LACDocumentRemarkEntity"/>.
        /// </summary>
        internal void MapLACDocumentRemarkToLACDocumentRemarkEntity()
        {
            try
            {
                Mapper.CreateMap<LACDocumentRemark, LACDocumentRemarkEntity>()
                    .ForMember(dest => dest.LACDocDetailId, opts => opts.MapFrom(src => src.LACDocDetailId))
                    .ForMember(dest => dest.LACDocRemarkId, opts => opts.MapFrom(src => src.LACDocRemarkId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.Remarks, opts => opts.MapFrom(src => src.Remarks));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLACDocumentRemarkToLACDocumentRemarkEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LACInfo"/> to <see cref="LACInfoEntity"/>.
        /// </summary>
        internal void MapLACInfoToLACInfoEntity()
        {
            try
            {
                Mapper.CreateMap<LACInfo, LACInfoEntity>()
                    .ForMember(dest => dest.CancellationDateTime, opts => opts.MapFrom(src => src.CancellationDateTime))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.ClosedDateTime, opts => opts.MapFrom(src => src.ClosedDateTime))
                    .ForMember(dest => dest.ConcludedDateTime, opts => opts.MapFrom(src => src.ConcludedDateTime))
                    .ForMember(dest => dest.ExpiredDateTime, opts => opts.MapFrom(src => src.ExpiredDateTime))
                    .ForMember(dest => dest.IssuedDateTime, opts => opts.MapFrom(src => src.IssuedDateTime))
                    .ForMember(dest => dest.LABPartyId, opts => opts.MapFrom(src => src.LABPartyId))
                    .ForMember(dest => dest.LACConcludedStatus, opts => opts.MapFrom(src => src.LACConcludedStatus))
                    .ForMember(dest => dest.LACInfoId, opts => opts.MapFrom(src => src.LACInfoId))
                    .ForMember(dest => dest.LACNo, opts => opts.MapFrom(src => src.LACNo))
                    .ForMember(dest => dest.LACStatus, opts => opts.MapFrom(src => src.LACStatus))
                    .ForMember(dest => dest.LACType, opts => opts.MapFrom(src => src.LACType))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.RevocationDateTime, opts => opts.MapFrom(src => src.RevocationDateTime));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapLACInfoToLACInfoEntity", ex);
                throw;
            }
        }

        #endregion Methods
    }
}