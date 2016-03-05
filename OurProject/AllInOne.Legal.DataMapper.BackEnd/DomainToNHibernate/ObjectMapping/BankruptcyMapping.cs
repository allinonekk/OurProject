#region Header

/*****************************************************************************************************
* Description : This file represents the mapping of objects for Bankruptcy entities. This class will map
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
// File: BankruptcyMapping.cs
// Description: This file represents the mapping of objects for Bankruptcy entities. This class will map
// Object to Entity.
// </summary>
// <copyright file= "BankruptcyMapping.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Entities.BackEnd;
using log4net;

    internal class BankruptcyMapping
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(BankruptcyMapping));
        #region Constructors

        internal BankruptcyMapping()
        {
            this.MapBankruptcyInfoEntityToBankruptcyInfo();
        }

        #endregion Constructors

        #region Methods

        internal void BankruptcyOtherDefDetailEntityToBankruptcyOtherDefDetail()
        {
            try
            {
                MasterMapping masterMapping = new MasterMapping();

                Mapper.CreateMap<BankruptcyOtherDefDetailEntity, BankruptcyOtherDefDetail>()
                    .ForMember(dest => dest.CompanyName, opts => opts.MapFrom(src => src.CompanyName))
                    .ForMember(dest => dest.DateOfRegistration, opts => opts.MapFrom(src => src.DateOfRegistration))
                    .ForMember(dest => dest.FullName, opts => opts.MapFrom(src => src.FullName))
                    .ForMember(dest => dest.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(dest => dest.IdRemarks, opts => opts.MapFrom(src => src.IdRemarks))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    //.ForMember(dest => dest.MCountryCountryOfRegistration, opts => opts.MapFrom(src => src.MCountryOfRegistration))
                    //.ForMember(dest=>dest.MCountryIdCountryCode,opts=>opts.MapFrom(src=>src.
                    .ForMember(dest => dest.MEntityType, opts => opts.MapFrom(src => src.MEntityType))
                    .ForMember(dest => dest.MPersonIDGroup, opts => opts.MapFrom(src => src.MPersonIdGroup));
                    //.ForMember(dest=>dest.MPersonIDTypeCompanyIdTypeCode,opts=>opts.MapFrom(src=>src.MPersonIdType.))
                   // .ForMember(dest=>dest.MPersonIDTypePersonIdTypeCode,opts=>opts.MapFrom(src=>src.

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBankruptcyInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="BankruptcyInfoEntity"/> to <see cref="BankruptcyInfo"/>.
        /// </summary>
        internal void MapBankruptcyInfoEntityToBankruptcyInfo()
        {
            try
            {
                MasterMapping masterMapping = new MasterMapping();

                Mapper.CreateMap<BankruptcyInfoEntity, BankruptcyInfo>()
                    .ForMember(dest => dest.BankruptcyInfoId, opts => opts.MapFrom(src => src.BankruptcyInfoId))
                    .ForMember(dest => dest.DeathFromDate, opts => opts.MapFrom(src => src.DeathFromDate))
                    .ForMember(dest => dest.DeathToDate, opts => opts.MapFrom(src => src.DeathToDate))
                    .ForMember(dest => dest.ExecutionCompDate, opts => opts.MapFrom(src => src.ExecutionCompDate))
                    .ForMember(dest => dest.IsAnotherBAFiled, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsAnotherBAFiled))
                    .ForMember(dest => dest.IsAnotherDefField, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src=>src.IsAnotherDefField))
                    .ForMember(dest => dest.IsServiceOutJur, opts => opts.ResolveUsing<JurisdictionInSingaporeToStringResolver>().FromMember(src=>src.IsServiceOutJur))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MCurrency, opts => opts.MapFrom(src => src.MCurrency))
                    .ForMember(dest => dest.ProbateCaseNo, opts => opts.MapFrom(src => src.ProbateCaseNo))
                    .ForMember(dest => dest.RevCertIssueDate, opts => opts.MapFrom(src => src.RevCertIssueDate))
                    .ForMember(dest => dest.StatuaryDemandDate, opts => opts.MapFrom(src => src.StatuaryDemandDate))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.TotalDebt, opts => opts.MapFrom(src => src.TotalDebt))
                    .ForMember(dest => dest.TotalDebtinSGD, opts => opts.MapFrom(src => src.TotalDebtInSGD));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBankruptcyInfoEntityToBankruptcyInfo", ex);
                throw;
            }
        }

        #endregion Methods
    }
}