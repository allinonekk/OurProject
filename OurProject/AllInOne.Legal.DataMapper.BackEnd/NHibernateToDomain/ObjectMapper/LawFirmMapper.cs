#region Header

/*****************************************************************************************************
* Description : This file handles mapper for LawFirm related from NHibernate entities to Domain objects.
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
// Description: This file handles mapper for LawFirm related from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "LawFirmMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

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
        /// Gets the <see cref="LawFirmAddressEntity"/> from <see cref="LawFirmAddress"/> input.
        /// </summary>
        /// <param name="LawFirmAddress"><see cref="LawFirmAddress"/></param>
        /// <returns>Returns <see cref="LawFirmAddressEntity"/>, else null.</returns>
        public static LawFirmAddressEntity GetLawFirmAddressEntity(LawFirmAddress lawFirmAddress)
        {
            LawFirmAddressEntity lawFirmAddressEntity = null;

            try
            {
                if (lawFirmAddress != null)
                {
                    lawFirmAddressEntity = Mapper.Map<LawFirmAddress, LawFirmAddressEntity>(lawFirmAddress);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetLawFirmAddressEntity", ex);
                throw;
            }

            return lawFirmAddressEntity;
        }

        /// <summary>
        /// Gets the <see cref="LawFirmEntity"/> from <see cref="LawFirm"/> input.
        /// </summary>
        /// <param name="LawFirm"><see cref="LawFirm"/></param>
        /// <returns>Returns <see cref="LawFirmEntity"/>, else null.</returns>
        public static LawFirmEntity GetLawFirmEntity(LawFirm lawFirm)
        {
            LawFirmEntity lawFirmEntity = null;

            try
            {
                if (lawFirm != null)
                {
                    lawFirmEntity = Mapper.Map<LawFirm, LawFirmEntity>(lawFirm);
                    lawFirmEntity.MLawFirmGroup = Mapper.Map<MLawFirmGroup, MLawFirmGroupEntity>(lawFirm.MLawFirmGroup);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetLawFirmEntity", ex);
                throw;
            }

            return lawFirmEntity;
        }

        public static InterfaceLawSocLawFirmEntity GetInterfaceLawSocLawFirmEntity(InterfaceLawSocLawFirm interfaceLawSocLawFirm)
        {
            InterfaceLawSocLawFirmEntity interfaceLawSocLawFirmEntity = null;
            try
            {
                if (interfaceLawSocLawFirm != null)
                {
                    interfaceLawSocLawFirmEntity = Mapper.Map<InterfaceLawSocLawFirm, InterfaceLawSocLawFirmEntity>(interfaceLawSocLawFirm);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetInterfaceLawSocLawFirmEntity", ex);
                throw;
            }
            return interfaceLawSocLawFirmEntity;
        }

        public static InterfaceLawSocLawFirmAddressEntity GetInterfaceLawSocLawFirmAddressEntity(InterfaceLawSocLawFirmAddress interfaceLawSocLawFirmAddres)
        {
            InterfaceLawSocLawFirmAddressEntity interfaceLawSocLawFirmAddressEntity = null;
            try
            {
                if (interfaceLawSocLawFirmAddres != null)
                {
                    interfaceLawSocLawFirmAddressEntity = Mapper.Map<InterfaceLawSocLawFirmAddress, InterfaceLawSocLawFirmAddressEntity>(interfaceLawSocLawFirmAddres);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetInterfaceLawSocLawFirmAddressEntity", ex);
                throw;
            }
            return interfaceLawSocLawFirmAddressEntity;
        }
        /// <summary>
        /// Gets the <see cref="SolicitorEntity"/> from <see cref="Solicitor"/> input.
        /// </summary>
        /// <param name="Solicitor"><see cref="Solicitor"/></param>
        /// <returns>Returns <see cref="SolicitorEntity"/>, else null.</returns>
        public static SolicitorEntity GetSolicitorEntity(Solicitor solicitor)
        {
            SolicitorEntity solicitorEntity = null;

            try
            {
                if (solicitor != null)
                {
                    solicitorEntity = Mapper.Map<Solicitor, SolicitorEntity>(solicitor);
                    solicitorEntity.CountryOfBirth = Mapper.Map<MCountry, MCountryEntity>(solicitor.CountryOfBirth);
                    solicitorEntity.Gender = Mapper.Map<MGender, MGenderEntity>(solicitor.Gender);
                    solicitorEntity.IdCountryCode = Mapper.Map<MCountry, MCountryEntity>(solicitor.IdCountryCode);
                    solicitorEntity.IdTypeCode = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(solicitor.IdTypeCode);
                    solicitorEntity.MaritalStatusCode = Mapper.Map<MMaritalStatus, MMaritalStatusEntity>(solicitor.MaritalStatusCode);
                    solicitorEntity.MNationalityEntity = Mapper.Map<MNationality, MNationalityEntity>(solicitor.MNationality);
                    solicitorEntity.RaceCode = Mapper.Map<MRace, MRaceEntity>(solicitor.RaceCode);
                    solicitorEntity.ReligionCode = Mapper.Map<MReligion, MReligionEntity>(solicitor.ReligionCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSolicitorEntity", ex);
                throw;
            }

            return solicitorEntity;
        }

        public static SolicitorAddressEntity GetSolicitorAddressEntity(SolicitorAddress solicitorAddress)
        {
            SolicitorAddressEntity solicitorAddressEntity = null;

            try
            {
                if (solicitorAddress != null)
                {
                    solicitorAddressEntity = Mapper.Map<SolicitorAddress, SolicitorAddressEntity>(solicitorAddress);
                  
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSolicitorAddressEntity", ex);
                throw;
            }

            return solicitorAddressEntity;
        }

        

        public static ILawFirmEntity GetLawFirmEntity<T>(T lawFirm)
        {
            try
            {
                if (lawFirm.GetType().Equals(typeof(LawFirm)))
                    return LawFirmMapper.GetLawFirmEntity(lawFirm as LawFirm);

                else if (lawFirm.GetType().Equals(typeof(LawFirmAddress)))
                    return LawFirmMapper.GetLawFirmAddressEntity(lawFirm as LawFirmAddress);

                else if (lawFirm.GetType().Equals(typeof(InterfaceLawSocLawFirm)))
                    return LawFirmMapper.GetInterfaceLawSocLawFirmEntity(lawFirm as InterfaceLawSocLawFirm);

                else if (lawFirm.GetType().Equals(typeof(InterfaceLawSocLawFirmAddress)))
                    return LawFirmMapper.GetInterfaceLawSocLawFirmAddressEntity(lawFirm as InterfaceLawSocLawFirmAddress);

                else if (lawFirm.GetType().Equals(typeof(Solicitor)))
                    return LawFirmMapper.GetSolicitorEntity(lawFirm as Solicitor);

                else if (lawFirm.GetType().Equals(typeof(SolicitorAddress)))
                    return LawFirmMapper.GetSolicitorAddressEntity(lawFirm as SolicitorAddress);

                else
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetLawFirmEntity method in LawFirmMapper.");

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetLawFirmEntity", ex);
                throw;
            }

        }



        #endregion Methods
    }
}