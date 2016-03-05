#region Header

/*****************************************************************************************************
* Description : This file handles mapper for Criminal Finance from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   30/03/2011   		        Chun Jie                 Created
*
*****************************************************************************************************/
// <summary>
// File: CriminalFinanceMapper.cs
// Description: This file handles mapper for Criminal Finance from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "CriminalFinanceMapper.cs" company="CrimsonLogic Pte Ltd">
// Copyright (C) 2010 CrimsonLogic Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace CrimsonLogic.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;

    using AutoMapper;

    using CrimsonLogic.Legal.Domain.CriminalFinance;
    using CrimsonLogic.Legal.Domain.Interfaces;
    using CrimsonLogic.Legal.Entities.BackEnd;

    using log4net;
    using CrimsonLogic.Legal.Domain.Common;
    using CrimsonLogic.Legal.Domain.Master;

    /// <summary>
    /// Class handles mapping for Criminal Finance from NHibernate entities to Domain objects.
    /// </summary>
    public class CriminalFinanceMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CaseSpecificMapper));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the <see cref="CriminalClaimHonorariumInfoEntity"/> from <see cref="CriminalClaimHonorariumInfo"/> input.
        /// </summary>
        /// <param name="criminalClaimHonorariumInfo"><see cref="CriminalClaimHonorariumInfo"/></param>
        /// <returns>Returns <see cref="CriminalClaimHonorariumInfoEntity"/>, else null.</returns>
        public static CriminalClaimHonorariumInfoEntity GetCriminalClaimHonorariumInfoEntity(CriminalClaimHonorariumInfo criminalClaimHonorariumInfo)
        {
            CriminalClaimHonorariumInfoEntity criminalClaimHonorariumInfoEntity = null;

            try
            {
                if (criminalClaimHonorariumInfo != null)
                {
                    criminalClaimHonorariumInfoEntity = Mapper.Map<CriminalClaimHonorariumInfo, CriminalClaimHonorariumInfoEntity>(criminalClaimHonorariumInfo);
                    criminalClaimHonorariumInfoEntity.CriminalClaimInfoEntity = Mapper.Map<CriminalClaimInfo, CriminalClaimInfoEntity>(criminalClaimHonorariumInfo.CriminalClaimInfo);
                    criminalClaimHonorariumInfoEntity.SolicitorEntity = Mapper.Map<Solicitor, SolicitorEntity>(criminalClaimHonorariumInfo.Solicitor);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalClaimHonorariumInfoEntity", ex);
                throw ex;
            }

            return criminalClaimHonorariumInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimInfoEntity"/> from <see cref="CriminalClaimInfo"/> input.
        /// </summary>
        /// <param name="criminalClaimInfo"><see cref="CriminalClaimInfo"/></param>
        /// <returns>Returns <see cref="CriminalClaimInfoEntity"/>, else null.</returns>
        public static CriminalClaimInfoEntity GetCriminalClaimInfoEntity(CriminalClaimInfo criminalClaimInfo)
        {
            CriminalClaimInfoEntity criminalClaimInfoEntity = null;

            try
            {
                if (criminalClaimInfo != null)
                {
                    criminalClaimInfoEntity = Mapper.Map<CriminalClaimInfo, CriminalClaimInfoEntity>(criminalClaimInfo);
                    criminalClaimInfoEntity.MCriminalClaimTypeEntity = Mapper.Map<MCriminalClaimType, MCriminalClaimTypeEntity>(criminalClaimInfo.MCriminalClaimType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalClaimInfoEntity", ex);
                throw ex;
            }

            return criminalClaimInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimInterpreterFeeInfoEntity"/> from <see cref="CriminalClaimInterpreterFeeInfo"/> input.
        /// </summary>
        /// <param name="criminalClaimInterpreterFeeInfo"><see cref="CriminalClaimInterpreterFeeInfo"/></param>
        /// <returns>Returns <see cref="CriminalClaimInterpreterFeeInfoEntity"/>, else null.</returns>
        public static CriminalClaimInterpreterFeeInfoEntity GetCriminalClaimInterpreterFeeInfoEntity(CriminalClaimInterpreterFeeInfo criminalClaimInterpreterFeeInfo)
        {
            CriminalClaimInterpreterFeeInfoEntity criminalClaimInterpreterFeeInfoEntity = null;

            try
            {
                if (criminalClaimInterpreterFeeInfo != null)
                {
                    criminalClaimInterpreterFeeInfoEntity = Mapper.Map<CriminalClaimInterpreterFeeInfo, CriminalClaimInterpreterFeeInfoEntity>(criminalClaimInterpreterFeeInfo);
                    criminalClaimInterpreterFeeInfoEntity.CriminalClaimInfoEntity = Mapper.Map<CriminalClaimInfo, CriminalClaimInfoEntity>(criminalClaimInterpreterFeeInfo.CriminalClaimInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalClaimInterpreterFeeInfoEntity", ex);
                throw ex;
            }

            return criminalClaimInterpreterFeeInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimProfessionalFeeInfoEntity"/> from <see cref="CriminalClaimProfessionalFeeInfo"/> input.
        /// </summary>
        /// <param name="criminalClaimProfessionalFeeInfo"><see cref="CriminalClaimProfessionalFeeInfo"/></param>
        /// <returns>Returns <see cref="CriminalClaimProfessionalFeeInfoEntity"/>, else null.</returns>
        public static CriminalClaimProfessionalFeeInfoEntity GetCriminalClaimProfessionalFeeInfoEntity(CriminalClaimProfessionalFeeInfo criminalClaimProfessionalFeeInfo)
        {
            CriminalClaimProfessionalFeeInfoEntity criminalClaimProfessionalFeeInfoEntity = null;

            try
            {
                if (criminalClaimProfessionalFeeInfo != null)
                {
                    criminalClaimProfessionalFeeInfoEntity = Mapper.Map<CriminalClaimProfessionalFeeInfo, CriminalClaimProfessionalFeeInfoEntity>(criminalClaimProfessionalFeeInfo);
                    criminalClaimProfessionalFeeInfoEntity.CriminalClaimInfoEntity = Mapper.Map<CriminalClaimInfo, CriminalClaimInfoEntity>(criminalClaimProfessionalFeeInfo.CriminalClaimInfo);
                    criminalClaimProfessionalFeeInfoEntity.MCriminalClaimantTypeEntity = Mapper.Map<MCriminalClaimantType, MCriminalClaimantTypeEntity>(criminalClaimProfessionalFeeInfo.MCriminalClaimantType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalClaimProfessionalFeeInfoEntity", ex);
                throw ex;
            }

            return criminalClaimProfessionalFeeInfoEntity;
        }
        
        /// <summary>
        /// Gets the <see cref="CriminalClaimMiscellaneousInfoEntity"/> from <see cref="CriminalClaimMiscellaneousInfo"/> input.
        /// </summary>
        /// <param name="criminalClaimMiscellaneousInfo"><see cref="CriminalClaimMiscellaneousInfo"/></param>
        /// <returns>Returns <see cref="CriminalClaimMiscellaneousInfoEntity"/>, else null.</returns>
        public static CriminalClaimMiscellaneousInfoEntity GetCriminalClaimMiscellaneousInfoEntity(CriminalClaimMiscellaneousInfo criminalClaimMiscellaneousInfo)
        {
            CriminalClaimMiscellaneousInfoEntity criminalClaimMiscellaneousInfoEntity = null;

            try
            {
                if (criminalClaimMiscellaneousInfo != null)
                {
                    criminalClaimMiscellaneousInfoEntity = Mapper.Map<CriminalClaimMiscellaneousInfo, CriminalClaimMiscellaneousInfoEntity>(criminalClaimMiscellaneousInfo);
                    criminalClaimMiscellaneousInfoEntity.CriminalClaimInfoEntity = Mapper.Map<CriminalClaimInfo, CriminalClaimInfoEntity>(criminalClaimMiscellaneousInfo.CriminalClaimInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalClaimMiscellaneousInfoEntity", ex);
                throw ex;
            }

            return criminalClaimMiscellaneousInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimWitnessInfoEntity"/> from <see cref="CriminalClaimWitnessInfo"/> input.
        /// </summary>
        /// <param name="criminalClaimWitnessInfo"><see cref="CriminalClaimWitnessInfo"/></param>
        /// <returns>Returns <see cref="CriminalClaimWitnessInfoEntity"/>, else null.</returns>
        public static CriminalClaimWitnessInfoEntity GetCriminalClaimWitnessInfoEntity(CriminalClaimWitnessInfo criminalClaimWitnessInfo)
        {
            CriminalClaimWitnessInfoEntity criminalClaimWitnessInfoEntity = null;

            try
            {
                if (criminalClaimWitnessInfo != null)
                {
                    criminalClaimWitnessInfoEntity = Mapper.Map<CriminalClaimWitnessInfo, CriminalClaimWitnessInfoEntity>(criminalClaimWitnessInfo);
                    criminalClaimWitnessInfoEntity.CriminalClaimInfoEntity = Mapper.Map<CriminalClaimInfo, CriminalClaimInfoEntity>(criminalClaimWitnessInfo.CriminalClaimInfo);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalClaimWitnessInfoEntity", ex);
                throw ex;
            }

            return criminalClaimWitnessInfoEntity;
        }

        /// <summary>
        /// Method returns the <see cref="ICaseSpecific"/> tagged entity from <see cref="ICaseSpecificEntity"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="ICaseSpecificEntity"/> type</typeparam>
        /// <param name="caseSpecificEntity"><see cref="ICaseSpecificEntity"/> object.</param>
        /// <returns>Returns the <see cref="ICaseSpecificEntity"/></returns>
        public static ICriminalFinanceEntity GetCriminalFinanceEntity<T>(T criminalFinanceEntity)
        {
            try
            {
                if (criminalFinanceEntity.GetType().Equals(typeof(CriminalClaimHonorariumInfo)))
                    return (GetCriminalClaimHonorariumInfoEntity(criminalFinanceEntity as CriminalClaimHonorariumInfo));

                else if (criminalFinanceEntity.GetType().Equals(typeof(CriminalClaimInfo)))
                    return (GetCriminalClaimInfoEntity(criminalFinanceEntity as CriminalClaimInfo));

                else if (criminalFinanceEntity.GetType().Equals(typeof(CriminalClaimInterpreterFeeInfo)))
                    return (GetCriminalClaimInterpreterFeeInfoEntity(criminalFinanceEntity as CriminalClaimInterpreterFeeInfo));

                else if (criminalFinanceEntity.GetType().Equals(typeof(CriminalClaimMiscellaneousInfo)))
                    return (GetCriminalClaimMiscellaneousInfoEntity(criminalFinanceEntity as CriminalClaimMiscellaneousInfo));

                else if (criminalFinanceEntity.GetType().Equals(typeof(CriminalClaimProfessionalFeeInfo)))
                    return (GetCriminalClaimProfessionalFeeInfoEntity(criminalFinanceEntity as CriminalClaimProfessionalFeeInfo));

                else if (criminalFinanceEntity.GetType().Equals(typeof(CriminalClaimWitnessInfo)))
                    return (GetCriminalClaimWitnessInfoEntity(criminalFinanceEntity as CriminalClaimWitnessInfo));

                else
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetCriminalFinanceEntity method in CriminalFinanceMapper.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalFinanceEntity", ex);
                throw ex;
            }
        }
        
        #endregion Methods
    }
}