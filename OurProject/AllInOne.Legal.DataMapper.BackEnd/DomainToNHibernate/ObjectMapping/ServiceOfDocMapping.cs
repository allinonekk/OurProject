#region Header

/*****************************************************************************************************
* Description : This file represents the mapping of objects for serviceofDoc entities. This class will map
* Object to Entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   29/10/2010   		      Narayan                	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ServiceOfDocMapping.cs
// Description: This file represents the mapping of objects for ServicOfDoc. This class will map
// Object to Entity.
// </summary>
// <copyright file= "ServiceOfDocMapping.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using log4net;

    internal class ServiceOfDocMapping
    {
        #region Fields
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ServiceOfDocMapping));
        #endregion Fields
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOfDocMapping"/> class.
        /// </summary>
        internal ServiceOfDocMapping()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Method which maps the <see cref="ServiceOfDocDocStatusHistoryEntity"/> to <see cref="ServiceOfDocDocStatusHistory"/>.
        /// </summary>
        internal void MapServiceOfDocDocStatusHistoryEntityToServiceOfDocDocStatusHistory()
        {
            try
            {
                Mapper.CreateMap<ServiceOfDocDocStatusHistoryEntity, ServiceOfDocDocStatusHistory>()
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.RemainderAttDocId, opts => opts.MapFrom(src => src.RemainderAttDocId))
                    .ForMember(desc => desc.RemainderMessage, opts => opts.MapFrom(src => src.RemainderMessage))
                    .ForMember(desc => desc.RemainderSubject, opts => opts.MapFrom(src => src.RemainderSubject))
                    .ForMember(desc => desc.RemainderTo, opts => opts.MapFrom(src => src.RemainderTo))
                    .ForMember(desc => desc.ServiceOfDocDocStatusId, opts => opts.MapFrom(src => src.ServiceOfDocDocStatusId))
                    .ForMember(desc => desc.ServiceOfDocInfoId, opts => opts.MapFrom(src => src.ServiceOfDocInfoId))
                    .ForMember(desc => desc.StatusDate, opts => opts.MapFrom(src => src.StatusDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MappingServiceOfDocDocStatusHistoryEntityToServiceOfDocDocStatusHistory", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ServiceOfDocDocument"/> to <see cref="ServiceOfDocDocumentEntity"/>.
        /// </summary>
        internal void MapServiceOfDocDocumentEntityToServiceOfDocDocument()
        {
            try
            {
                Mapper.CreateMap<ServiceOfDocDocumentEntity, ServiceOfDocDocument>()
                    .ForMember(desc => desc.CreatedBy, opts => opts.MapFrom(src => src.CreatedBy))
                    .ForMember(desc => desc.CreatedDate, opts => opts.MapFrom(src => src.CreatedDate))
                    .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(desc => desc.ServiceOfDocDocStatusId, opts => opts.MapFrom(src => src.ServiceOfDocDocStatusId))
                    .ForMember(desc => desc.ServiceOfDocInfoDetailId, opts => opts.MapFrom(src => src.ServiceOfDocInfoDetailId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapServiceOfDocDocumentToServiceOfDocDocumentEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ServiceOfDocInfoDetail"/> to <see cref="ServiceOfDocInfoDetailEntity"/>.
        /// </summary>
        internal void MapServiceOfDocInfoDetailEntityToServiceOfDocInfoDetail()
        {
            try
            {
                Mapper.CreateMap<ServiceOfDocInfoDetailEntity, ServiceOfDocInfoDetail>()
                    .ForMember(desc => desc.Addr1, opts => opts.MapFrom(src => src.Addr1))
                    .ForMember(desc => desc.Addr2, opts => opts.MapFrom(src => src.Addr2))
                    .ForMember(desc => desc.Addr3, opts => opts.MapFrom(src => src.Addr3))
                    .ForMember(desc => desc.Addr4, opts => opts.MapFrom(src => src.Addr4))
                    .ForMember(desc => desc.FeeAmount, opts => opts.MapFrom(src => src.FeeAmount))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(desc => desc.PostalCode, opts => opts.MapFrom(src => src.PostalCode))
                    .ForMember(desc => desc.ServiceOfDocInfoId, opts => opts.MapFrom(src => src.ServiceOfDocInfoId))
                    .ForMember(desc => desc.ServiceOfDocInfoDetailId, opts => opts.MapFrom(src => src.ServiceOfDocInfoDetailId))
                    .ForMember(desc => desc.ToBeServedCPID, opts => opts.MapFrom(src => src.ToBeServiedCPID));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapServiceOfDocInfoDetailToServiceOfDocInfoDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="CaseInfoEntity"/> to <s    ee cref="CaseInfo"/>.
        /// </summary>
        internal void MapServiceOfDocInfoEntityToServiceOfDocInfo()
        {
            try
            {
                Mapper.CreateMap<ServiceOfDocInfoEntity, ServiceOfDocInfo>()
                    .ForMember(dest => dest.ServiceOfDocInfoId, opts => opts.MapFrom(src => src.ServiceOfDocInfoId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.RequestId, opts => opts.MapFrom(src => src.RequestId))
                    .ForMember(dest => dest.RequestDate, opts => opts.MapFrom(src => src.RequestDate))
                    //.ForMember(dest => dest.MServeStatu.SerStatusCode, opts => opts.MapFrom(src => src.MServeStatus.SerStatusCode))
                     .ForMember(dest => dest.RefOrderDetailId, opts => opts.MapFrom(src => src.RefOrderDetailId))
                    .ForMember(dest => dest.MFARefNo, opts => opts.MapFrom(src => src.MFARefNo))
                    .ForMember(dest => dest.ServiceSatus, opts => opts.ResolveUsing<ServiceStatusToStringResolver>().FromMember(src=>src.ServiceStatus))
                    .ForMember(dest => dest.RefOrderDetailId, opts => opts.MapFrom(src => src.RefOrderDetailId))
                    .ForMember(dest => dest.ServiceDate, opts => opts.MapFrom(src => src.ServiceDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapServiceOfDocInfoEntityToServiceOfDocInfo", ex);
                throw;
            }
        }

        #endregion Methods
    }
}