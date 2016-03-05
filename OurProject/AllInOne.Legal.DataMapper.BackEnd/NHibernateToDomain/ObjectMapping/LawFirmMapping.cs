#region Header

/*****************************************************************************************************
* Description : This file handles mapping for LawFirm related from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   29/12/2010                  Yan Nai                 Created.
*****************************************************************************************************/
// <summary>
// File: LawFirmMapping.cs
// Description:  This file handles mapping for LawFirm related from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "LawFirmMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    public class LawFirmMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LawFirmMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method which maps the <see cref="LawFirmAddress"/> to <see cref="LawFirmAddressEntity"/>.
        /// </summary>
        internal void MapLawFirmAddressToLawFirmAddressEntity()
        {
            try
            {
                Mapper.CreateMap<LawFirmAddress, LawFirmAddressEntity>()
                      .ForMember(desc => desc.AddrType, opts => opts.MapFrom(src => src.AddrType))
                      .ForMember(desc => desc.FormatInd, opts => opts.MapFrom(src => src.FormatInd))
                      .ForMember(desc => desc.LFID, opts => opts.MapFrom(src => src.LawFirm.LFID))
                      .ForMember(desc => desc.MailingInd, opts => opts.MapFrom(src => src.MailingInd))
                      .ForMember(desc => desc.UpdateByBEInd, opts => opts.MapFrom(src => src.UpdateByBEInd))
                      .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                      .ForMember(desc => desc.MinLawInd, opts => opts.MapFrom(src => src.MinLawInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapLawFirmAddressToLawFirmAddressEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LawFirm"/> to <see cref="LawFirmEntity"/>.
        /// </summary>
        internal void MapLawFirmToLawFirmEntity()
        {
            try
            {
                Mapper.CreateMap<LawFirm, LawFirmEntity>()
                      .ForMember(desc => desc.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                      .ForMember(desc => desc.LawPracticeType, opts => opts.MapFrom(src => src.LawPracticeType));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapLawFirmToLawFirmEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="Solicitor"/> to <see cref="SolicitorEntity"/>.
        /// </summary>
        internal void MapSolicitorToSolicitorEntity()
        {
            try
            {
                Mapper.CreateMap<Solicitor, SolicitorEntity>()
                    .ForMember(desc => desc.BLERegistrationInd, opt => opt.MapFrom(src => src.BLERegistrationInd))
                    .ForMember(desc => desc.AdmittedToBarInd, opt => opt.MapFrom(src => src.AdmittedToBarInd))
                    .ForMember(desc => desc.ObsInd, opt => opt.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapSolicitorToSolicitorEntity", ex);
                throw;
            }
        }

        internal void MapSolicitorAddressToSolicitorAddressEntity()
        {
            try
            {
                 Mapper.CreateMap<SolicitorAddress, SolicitorAddressEntity>()
                  .ForMember(desc => desc.AddrType, opt => opt.MapFrom(src => src.AddrType))
                    .ForMember(desc => desc.FormatInd, opt => opt.MapFrom(src => src.FormatInd))
                    .ForMember(desc => desc.ObsInd, opt => opt.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSolicitorAddressToSolicitorAddressEntity", ex);
                throw;
            }
        }


        internal void MapInterfaceLawSocLawFirmToInterfaceLawSocLawFirmEntity()
        {
            try
            {
                Mapper.CreateMap<InterfaceLawSocLawFirm, InterfaceLawSocLawFirmEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapInterfaceLawSocLawFirmToInterfaceLawSocLawFirmEntity", ex);
                throw;
            }
        }

        internal void MapInterfaceLawSocLawFirmAddressToInterfaceLawSocLawFirmAddressEntity()
        {
            try
            {
                Mapper.CreateMap<InterfaceLawSocLawFirmAddress, InterfaceLawSocLawFirmAddressEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapInterfaceLawSocLawFirmAddressToInterfaceLawSocLawFirmAddressEntity", ex);
                throw;
            }
        }

        #endregion Methods
    }
}