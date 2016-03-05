#region Header

/*****************************************************************************************************
* Description : This file represents the mapping of objects for Divorce entities. This class will map
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
// File: DivorceMapping.cs
// Description: This file represents the mapping of objects for Divorce entities. This class will map
// Object to Entity.
// </summary>
// <copyright file= "DivorceMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Entities.BackEnd;
    using log4net;

    internal class DivorceMapping
    {
        #region Constructors

        internal DivorceMapping()
        {
            //this.MapChildInfoEntityToChildInfo();
            //this.MapDivorceInfoEntityToDivorceInfo();
            //this.MapRelatedProceedingEntityToRelatedProceeding();
        }

        #endregion Constructors

        #region Fields
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DivorceMapping));
        #endregion Fields
        #region Methods

        /// <summary>
        /// Maps objects from <see cref="ChildInfo"/> to <see cref="ChildInfoEntity"/>.
        /// </summary>
        internal void MapChildInfoEntityToChildInfo()
        {
            try
            {
                Mapper.CreateMap<ChildInfoEntity, ChildInfo>()
                    .ForMember(dest => dest.Age, opts => opts.MapFrom(src => src.Age))
                    .ForMember(dest => dest.ArrangementDetails, opts => opts.MapFrom(src => src.ArrangementDetails))
                    .ForMember(dest => dest.ChildDisableDetail, opts => opts.MapFrom(src => src.ChildDisableDetail))
                    .ForMember(dest => dest.ChildInfoId, opts => opts.MapFrom(src => src.ChildInfoId))
                    .ForMember(dest => dest.ChildOf, opts => opts.MapFrom(src => src.ChildOf))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.ChildTrainingDetails, opts => opts.MapFrom(src => src.ChildTrainingDetails))
                    .ForMember(dest => dest.DateOfBirth, opts => opts.MapFrom(src => src.DateOfBirth))
                    .ForMember(dest => dest.DisputeDetails, opts => opts.MapFrom(src => src.DisputeDetails))
                    .ForMember(dest => dest.MGender.GenderCode, opts => opts.MapFrom(src => src.Gender.GenderCode))
                    .ForMember(dest => dest.MCountry.CountryCode, opts => opts.MapFrom(src => src.IdCountry))
                    .ForMember(dest => dest.IdNumber, opts => opts.MapFrom(src => src.IdNumber))
                    .ForMember(dest => dest.IsChildOfCurrentMarriageInd, opts => opts.MapFrom(src => src.IsChildOfCurrentMarriageInd))
                    .ForMember(dest => dest.Itemno, opts => opts.MapFrom(src => src.ItemNo))
                    .ForMember(dest => dest.MMaritalStatus.MaritalStatusCode, opts => opts.MapFrom(src => src.MaritalStatus.MaritalStatusCode))
                    .ForMember(dest => dest.MOccupation.OccupationCode, opts => opts.MapFrom(src => src.MOccupation.OccupationCode))
                    //.ForMember(dest => dest.MPersonIDType.EntityTypeCode, opts => opts.MapFrom(src => src.MPersonIdType.EntityTypeCode))
                    .ForMember(dest => dest.MQualification.QualificationCode, opts => opts.MapFrom(src => src.MQualification.QualificationCode))
                    .ForMember(dest => dest.MRace.RaceCode, opts => opts.MapFrom(src => src.MRace.RaceCode))
                    .ForMember(dest => dest.MReligion.ReligionCode, opts => opts.MapFrom(src => src.MReligion.ReligionCode))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.MNationality.NationalityCode, opts => opts.MapFrom(src => src.Nationality.NationalityCode))
                    .ForMember(dest => dest.OtherFacts, opts => opts.MapFrom(src => src.OtherFacts))
                    .ForMember(dest => dest.ProtectionDetails, opts => opts.MapFrom(src => src.ProtectionDetails))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapChildInfoEntityToChildInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="DivorceInfo"/> to <see cref="DivorceInfoEntity"/>.
        /// </summary>
        internal void MapDivorceInfoEntityToDivorceInfo()
        {
            try
            {
                Mapper.CreateMap<DivorceInfoEntity, DivorceInfo>()
                    .ForMember(dest => dest.DateOfEnquiryCPFB, opts => opts.MapFrom(src => src.DateOfEnquiryCPFB))
                    .ForMember(dest => dest.DateOfEnquiryHDB, opts => opts.MapFrom(src => src.DateOfEnquiryHDB))
                    .ForMember(dest => dest.DateOfMarriage, opts => opts.MapFrom(src => src.DateOfMarriage))
                    .ForMember(dest => dest.DateOfSolemnization, opts => opts.MapFrom(src => src.DateOfSolemnization))
                    .ForMember(dest => dest.DivorceInfoId, opts => opts.MapFrom(src => src.DivorceInfoId))
                    .ForMember(dest => dest.IsConsentFiled, opts => opts.MapFrom(src => src.IsConsentFiled))
                    .ForMember(dest => dest.IsDivorceWrit, opts => opts.MapFrom(src => src.IsDivorceWrit))
                    .ForMember(dest => dest.IsJudicialSeperationWrit, opts => opts.MapFrom(src => src.IsJudicialSeparationWrit))
                    .ForMember(dest => dest.IsNullityOfMarriageWrit, opts => opts.MapFrom(src => src.IsNullityOfMarriageWrit))
                    .ForMember(dest => dest.IsOrderExists, opts => opts.MapFrom(src => src.IsOrderExists))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.IsPreDeathDivorce, opts => opts.MapFrom(src => src.IsPreDeathDivorce))
                    .ForMember(dest => dest.IsResJudicialSeperation, opts => opts.MapFrom(src => src.IsResJudicialSeparation))
                    .ForMember(dest => dest.MarriageCertNo, opts => opts.MapFrom(src => src.MarriageCertNo))
                    .ForMember(dest => dest.MatrimonialPropInd, opts => opts.MapFrom(src => src.MatrimonialPropInd))//Check
                    .ForMember(dest => dest.OrderNumber, opts => opts.MapFrom(src => src.OrderNumber))
                    .ForMember(dest => dest.OSCaseNo, opts => opts.MapFrom(src => src.OSCaseNo))
                    .ForMember(dest => dest.ParentingPlanInd, opts => opts.MapFrom(src => src.ParentingPlanInd))
                    .ForMember(dest => dest.MCountryPlaceOfMarriage.CountryCode, opts => opts.MapFrom(src => src.PlaceOfMarriage))
                    .ForMember(dest => dest.MCountryPlaceOfSolemnization.CountryCode, opts => opts.MapFrom(src => src.PlaceOfSolemnization))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.TypeofJurDefendant, opts => opts.MapFrom(src => src.TypeofJurDefendant))
                    .ForMember(dest => dest.TypeofJurPlaintiff, opts => opts.MapFrom(src => src.TypeofJurPlaintiff))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDivorceInfoEntityToDivorceInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps objects from <see cref="RelatedProceeding"/> to <see cref="RelatedProceedingEntity"/>.
        /// </summary>
        internal void MapRelatedProceedingEntityToRelatedProceeding()
        {
            try
            {
                Mapper.CreateMap<RelatedProceedingEntity, RelatedProceeding>()
                    .ForMember(dest => dest.CaseNo, opts => opts.MapFrom(src => src.CaseNo))
                    //.ForMember(dest => dest.DateOfFiling, opts => opts.MapFrom(src => src.DateOfFiling))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.MCountry.CountryCode, opts => opts.MapFrom(src => src.MCountry.CountryCode))
                    .ForMember(dest => dest.MNatureOfProceeding.NOPCode, opts => opts.MapFrom(src => src.NatureOfProceeding))
                    //.ForMember(dest => dest.OtherFacts, opts => opts.MapFrom(src => src.OtherProceedingInfo))
                    .ForMember(dest => dest.OtherProceedingInfo, opts => opts.MapFrom(src => src.OtherProceedingInfo))
                    .ForMember(dest => dest.RelatedCaseId, opts => opts.MapFrom(src => src.RelatedCaseId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRelatedProceedingEntityToRelatedProceeding", ex);
                throw;
            }
        }

        #endregion Methods
    }
}