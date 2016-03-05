#region Header

/*****************************************************************************************************
* Description : This file represents the mapping of objects for Appeal entities. This class will map
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
// File: AppealMapping.cs
// Description: This file represents the mapping of objects for Appeal entities. This class will map
// Object to Entity.
// </summary>
// <copyright file= "AppealMapping.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using log4net;

    internal class AppealMapping
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AppealMapping));


        #region Constructors

        internal AppealMapping()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Maps objects from <see cref="DCACAInfo"/> to <see cref="DCACAInfoEntity"/>.
        /// </summary>
        internal void MapDCACAInfoEntityToDCACAInfo()
        {
            try
            {
                Mapper.CreateMap<DCACAInfoEntity, DCACAInfo>()
                    .ForMember(dest => dest.AppealAgainstJudOrder, opts => opts.MapFrom(src => src.AppealAgainstJudOrder))
                    .ForMember(dest => dest.AppealAgainstME, opts => opts.MapFrom(src => src.AppealAgainstME))
                    .ForMember(dest => dest.DateofOrder, opts => opts.MapFrom(src => src.DateofOrder))
                    .ForMember(dest => dest.DCACAInfoId, opts => opts.MapFrom(src => src.DCACAInfoId))
                    .ForMember(desc => desc.IsDCANonIELS, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsDCANOnIELS))
                    .ForMember(desc => desc.IsEOTOrderObtained, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsEOTOrderObtained))
                    .ForMember(desc => desc.IsLOCOrderObtainted, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsLOCOrderObtainted))
                    .ForMember(desc => desc.IsSecurityCertFiled, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSecurityCertFiled))
                    .ForMember(desc => desc.IsSecurityByUndertaking, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsSecurityByUndertaking))
                     .ForMember(desc => desc.AppealIsAgainst, opts => opts.ResolveUsing<AppealsAgainstToStringResolver>().FromMember(src => src.AppealIsAgainst))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                     .ForMember(desc => desc.SeekDirectionInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SeekDirectionInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDCACAInfoEntityToDCAInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="RARASInfo"/> to <see cref="RARASInfoEntity"/>.
        /// </summary>
        internal void MapRARASInfoEntityToRARASInfo()
        {
            try
            {
                Mapper.CreateMap<RARASInfoEntity, RARASInfo>()
                    .ForMember(dest => dest.AppealAgainstJudOrder, opts => opts.MapFrom(src => src.AppealAgainstJudOrder))
                    .ForMember(dest => dest.AppealAgainstME, opts => opts.MapFrom(src => src.AppealAgainstME))
                    .ForMember(dest => dest.DateofOrder, opts => opts.MapFrom(src => src.DateofOrder))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.IsEOTOrderObtained, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsEOTOrderObtained))
                    .ForMember(dest => dest.IsLOCOrderObtainted, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src=>src.IsLOCOrderObtainted))
                    .ForMember(dest => dest.RARASInfoId, opts => opts.MapFrom(src => src.RARASInfoId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.SeekDirectionInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SeekDirectionInd))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at AppealMapping", ex);
                throw;
            }
        }

        #endregion Methods
    }
}