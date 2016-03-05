#region Header

/*****************************************************************************************************
* Description : This file handles mapper for LawFirm related from Domain entities to NHibernate objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   03/01/2011   		        Yan Nai                  Created
*****************************************************************************************************/
// <summary>
// File: LawFirmMapper.cs
// Description: This file handles mapper for LawFirm related from Domain entities to NHibernate objects.
// </summary>
// <copyright file= "LawFirmMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;
    using AllInOne.Legal.Domain.LawFirm;

    public class LawFirmMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LawFirmMapper));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the <see cref="Solicitor"/> from <see cref="SolicitorEntity"/> input.
        /// </summary>
        /// <param name="SolicitorEntity"><see cref="SolicitorEntity"/></param>
        /// <returns>Returns <see cref="Solicitor"/>, else null.</returns>
        public static Solicitor GetSolicitor(SolicitorEntity solicitorEntity)
        {
            Solicitor solicitor = null;

            try
            {
                if (solicitorEntity != null)
                {
                    solicitor = Mapper.Map<SolicitorEntity, Solicitor>(solicitorEntity);
                    solicitor.CountryOfBirth = Mapper.Map<MCountryEntity, MCountry>(solicitorEntity.CountryOfBirth);
                    solicitor.Gender = Mapper.Map<MGenderEntity, MGender>(solicitorEntity.Gender);
                    solicitor.IdCountryCode = Mapper.Map<MCountryEntity, MCountry>(solicitorEntity.IdCountryCode);
                    solicitor.IdTypeCode = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(solicitorEntity.IdTypeCode);
                    solicitor.MaritalStatusCode = Mapper.Map<MMaritalStatusEntity, MMaritalStatus>(solicitorEntity.MaritalStatusCode);
                    solicitor.MNationality = Mapper.Map<MNationalityEntity, MNationality>(solicitorEntity.MNationalityEntity);
                    solicitor.RaceCode = Mapper.Map<MRaceEntity, MRace>(solicitorEntity.RaceCode);
                    solicitor.ReligionCode = Mapper.Map<MReligionEntity, MReligion>(solicitorEntity.ReligionCode);
                    
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSolicitor", ex);
                throw;
            }

            return solicitor;
        }

        /// <summary>
        /// Gets the <see cref="LawFirmEntity"/> from <see cref="LawFirm"/> input.
        /// </summary>
        /// <param name="LawFirm"><see cref="LawFirm"/></param>
        /// <returns>Returns <see cref="LawFirmEntity"/>, else null.</returns>
        public static LawFirm GetLawFirm(LawFirmEntity lawFirmEntity)
        {
            LawFirm lawFirm = null;

            try
            {
                if (lawFirmEntity != null)
                {
                    lawFirm = Mapper.Map<LawFirmEntity, LawFirm>(lawFirmEntity);
                    lawFirm.MLawFirmGroup = Mapper.Map<MLawFirmGroupEntity, MLawFirmGroup>(lawFirmEntity.MLawFirmGroup);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetLawFirm", ex);
                throw;
            }

            return lawFirm;
        }

        /// <summary>
        /// Gets the <see cref="LawFirmEntity"/> from <see cref="LawFirm"/> input.
        /// </summary>
        /// <param name="LawFirm"><see cref="LawFirm"/></param>
        /// <returns>Returns <see cref="LawFirmEntity"/>, else null.</returns>
        public static LawFirmAddress GetLawFirmAddress(LawFirmAddressEntity lawFirmAddressEntity)
        {
            LawFirmAddress lawFirmAddress = null;

            try
            {
                if (lawFirmAddressEntity != null)
                {
                    lawFirmAddress = Mapper.Map<LawFirmAddressEntity, LawFirmAddress>(lawFirmAddressEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetLawFirmAddress", ex);
                throw;
            }

            return lawFirmAddress;
        }

        public static ILawFirm GetLawFirmEntity<T>(T lawFirmEntity)
        {
            try
            {
                if (lawFirmEntity.GetType().Equals(typeof(LawFirmEntity)))
                    return LawFirmMapper.GetLawFirm(lawFirmEntity as LawFirmEntity);

                else if (lawFirmEntity.GetType().Equals(typeof(LawFirmAddressEntity)))
                    return LawFirmMapper.GetLawFirmAddress(lawFirmEntity as LawFirmAddressEntity);

                else if (lawFirmEntity.GetType().Equals(typeof(SolicitorAddressEntity)))
                    return LawFirmMapper.GetSolicitorAddress(lawFirmEntity as SolicitorAddressEntity);

                else if (lawFirmEntity.GetType().Equals(typeof(SolicitorEntity)))
                    return LawFirmMapper.GetSolicitor(lawFirmEntity as SolicitorEntity);

                else
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetLawFirmEntity method in LawFirmMapper.");

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetLawFirmEntity", ex);
                throw;
            }
           
        }

        public static SolicitorAddress GetSolicitorAddress(SolicitorAddressEntity solicitorAddressEntity)
        {
            SolicitorAddress solicitorAddress = null;
            try
            {
                if (solicitorAddressEntity != null)
                {
                    solicitorAddress = Mapper.Map<SolicitorAddressEntity, SolicitorAddress>(solicitorAddressEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSolicitorAddress", ex);
                throw;
            }
            return solicitorAddress;
        }
        #endregion Methods
    }
}