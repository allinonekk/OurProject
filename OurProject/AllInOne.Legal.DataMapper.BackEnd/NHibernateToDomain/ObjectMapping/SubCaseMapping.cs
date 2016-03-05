#region Header

/*****************************************************************************************************
* Description : This file handles mapping for SubCase from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   11/11/2010   		        Nithin                  Created
*****************************************************************************************************/
// <summary>
// File: SubCaseMapping.cs
// Description: This file handles mapping for SubCase from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "SubCaseMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for SubCase from NHibernate entities to Domain objects.
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

        /// <summary>
        /// Method which maps the <see cref="RSubCaseSubmission"/> to <see cref="RSubCaseSubmissionEntity"/>.
        /// </summary>
        internal void MapRSubCaseSubmissionToRSubCaseSubmissionEntity()
        {
            try
            {
                Mapper.CreateMap<RSubCaseSubmission, RSubCaseSubmissionEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.Ignore())
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRSubCaseSubmissionToRSubCaseSubmissionEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="SubCaseInfo"/> to <see cref="SubCaseInfoEntity"/>.
        /// </summary>
        internal void MapSubCaseInfoToSubCaseInfoEntity()
        {
            try
            {
                Mapper.CreateMap<SubCaseInfo, SubCaseInfoEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId.ToString()))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId.ToString()))
                    .ForMember(desc => desc.SubCaseNo, opts => opts.MapFrom(src => src.SubCaseNo))
                    .ForMember(desc => desc.SubCaseSerialNo, opts => opts.MapFrom(src => src.SubCaseSerialNo))
                    .ForMember(desc => desc.SubCaseStatusDate, opts => opts.MapFrom(src => src.SubCaseStatusDate))
                    .ForMember(desc => desc.SubCaseYear, opts => opts.MapFrom(src => src.SubCaseYear));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSubCaseInfoToSubCaseInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="SubCaseParty"/> to <see cref="SubCasePartyEntity"/>.
        /// </summary>
        internal void MapSubCasePartyToSubCasePartyEntity()
        {
            try
            {
                Mapper.CreateMap<SubCaseParty, SubCasePartyEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(desc => desc.CasePartyId, opts => opts.MapFrom(src => src.CasePartyId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src=>src.ObsInd))
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(desc => desc.SubCaseOrdinalNumber, opts => opts.MapFrom(src => src.SubCaseOrdinalNumber))
                    .ForMember(desc => desc.SubCasePartyId, opts => opts.MapFrom(src => src.SubCasePartyId))
                    .ForMember(desc => desc.SubCasePartyNo, opts => opts.MapFrom(src => src.SubCasePartyNo))
                    .ForMember(desc => desc.RoleCode, opts => opts.MapFrom(src => src.RoleCode));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSubCasePartyToSubCasePartyEntity", ex);
                throw;
            }
        }

        internal void MapRelationSubCaseInfoToRelationalSubCaseInfoEntity()
        {
            try
            {
                Mapper.CreateMap<RelationalSubCaseInfo, RelationalSubCaseInfoEntity>()
                    .ForMember(dest => dest.RelSubCaseInfoId, opts => opts.MapFrom(src => src.RelSubCaseInfoId))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRelationSubCaseInfoToRelationalSubCaseInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the subcasestatushistory to subcasestatushistory entity.
        /// </summary>
        internal void MapSubCaseStatusHistoryToSubCaseStatusHistoryEntity()
        {
            try
            {
                Mapper.CreateMap<SubCaseStatusHistory, SubCaseStatusHistoryEntity>()
                    .ForMember(desc => desc.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoID.ToString()));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SubCaseStatusHistoryToSubCaseStatusHistoryEntity", ex);
                throw;
            }
        }

        #endregion Methods
    }
}