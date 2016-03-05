#region Header

/*****************************************************************************************************
* Description : This file handles mapping for SubCase from Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/11/2010   		        Nithin                  Created
*****************************************************************************************************/
// <summary>
// File: CWUMapping.cs
// Description: This file handles mapping for SubCase from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "SubCaseMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for SubCase from Domain objects to NHibernate entities.
    /// </summary>
    internal class SubCaseMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SubCaseMapping));

        #endregion Fields

        #region Methods

        internal void MapRelationalSubCaseInfoEntityToRelationalSubCaseInfo()
        {
            try
            {
                Mapper.CreateMap<RelationalSubCaseInfoEntity, RelationalSubCaseInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRelationalSubCaseInfoEntityToRelationalSubCaseInfo", ex);
                throw;
            }
        }

        internal void MapRSubCaseSubmissionEntityToRSubCaseSubmission()
        {
            try
            {
                Mapper.CreateMap<RSubCaseSubmissionEntity, RSubCaseSubmission>()
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at RSubCaseSubmissionEntityToRSubCaseSubmission", ex);
                throw;
            }
        }

        internal void MapSubCaseInfoEntityToSubCaseInfo()
        {
            try
            {
                Mapper.CreateMap<SubCaseInfoEntity, SubCaseInfo>()
                    .ForMember(desc => desc.ADMRSVCBBInfos, opts => opts.Ignore())
                    .ForMember(desc => desc.AffidavitInfos, opts => opts.Ignore())
                   .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.DocCaseParties, opts => opts.Ignore())
                    .ForMember(desc => desc.DocOrderDetails, opts => opts.Ignore())
                    .ForMember(desc => desc.DocumentInfos, opts => opts.Ignore())
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.NatureOfApplications, opts => opts.Ignore())
                    .ForMember(desc => desc.RSubCaseSubmissions, opts => opts.Ignore())
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.SubCaseNo, opts => opts.MapFrom(src => src.SubCaseNo))
                    .ForMember(desc => desc.SubCaseParties, opts => opts.Ignore())
                    .ForMember(desc => desc.SubCaseSerialNo, opts => opts.MapFrom(src => src.SubCaseSerialNo))
                    .ForMember(desc => desc.SubCaseStatusDate, opts => opts.MapFrom(src => src.SubCaseStatusDate))
                    .ForMember(desc => desc.SubCaseYear, opts => opts.MapFrom(src => src.SubCaseYear));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SubCaseInfoEntityTOSubCaseInfo", ex);
                throw;
            }
        }

        internal void MapSubCasePartyEntityToSubCaseParty()
        {
            try
            {
                Mapper.CreateMap<SubCasePartyEntity, SubCaseParty>()
                 .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                   .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                   .ForMember(desc => desc.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.SubCaseOrdinalNumber, opts => opts.MapFrom(src => src.SubCaseOrdinalNumber))
                    .ForMember(desc => desc.SubCasePartyId, opts => opts.MapFrom(src => src.SubCasePartyId))
                    .ForMember(desc => desc.SubCasePartyNo, opts => opts.MapFrom(src => src.SubCasePartyNo))
                    .ForMember(desc => desc.RoleCode, opts => opts.ResolveUsing<RoleCodeToStringResolver>().FromMember(src => src.RoleCode));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SubCasePartyEntityToSubCaseParty", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the subcasestatushistory entity to subcasestatushistory.
        /// </summary>
        internal void MapSubCaseStatusHistoryEntityToSubCaseStatusHistory()
        {
            try
            {
                Mapper.CreateMap<SubCaseStatusHistoryEntity, SubCaseStatusHistory>()
                 .ForMember(desc => desc.SubCaseInfoID, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSubCaseStatusHistoryEntityToSubCaseStatusHistory", ex);
                throw;
            }
        }
        #endregion Methods
    }
}