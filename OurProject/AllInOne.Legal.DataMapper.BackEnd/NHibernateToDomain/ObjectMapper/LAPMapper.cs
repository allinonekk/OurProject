#region Header

/*****************************************************************************************************
* Description : This file handles mapper for LAP from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   11/10/2010   		        Yan Nai                 Created
*   31/10/2010                  Swaroop                 Added logging and comments.
*****************************************************************************************************/
// <summary>
// File: LAPMapper.cs
// Description: This file handles mapper for LAP from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "LAPMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LAP;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for LAP from NHibernate entities to Domain objects.
    /// </summary>
    public class LAPMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LAPMapper));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the <see cref="LABPartyAddressEntity"/> from <see cref="LABPartyAddress"/> input.
        /// </summary>
        /// <param name="lABPartyAddress"><see cref="LABPartyAddress"/></param>
        /// <returns>Returns <see cref="LABPartyAddressEntity"/>, else null.</returns>
        public static LABPartyAddressEntity GetLABPartyAddressEntity(LABPartyAddress lABPartyAddress)
        {
            LABPartyAddressEntity lABPartyAddressEntity = null;

            try
            {
                if (lABPartyAddress != null)
                {
                    lABPartyAddressEntity = Mapper.Map<LABPartyAddress, LABPartyAddressEntity>(lABPartyAddress);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABPartyAddressEntity", ex);
                throw;
            }

            return lABPartyAddressEntity;
        }

        /// <summary>
        /// Gets the <see cref="LABPartyAddressHistoryEntity"/> from <see cref="LABPartyAddressHistory"/> input.
        /// </summary>
        /// <param name="lABPartyAddressHistory"><see cref="LABPartyAddressHistory"/></param>
        /// <returns>Returns <see cref="LABPartyAddressHistoryEntity"/>, else null.</returns>
        public static LABPartyAddressHistoryEntity GetLABPartyAddressHistoryEntity(LABPartyAddressHistory lABPartyAddressHistory)
        {
            LABPartyAddressHistoryEntity lABPartyAddressHistoryEntity = null;

            try
            {
                if (lABPartyAddressHistory != null)
                {
                    lABPartyAddressHistoryEntity = Mapper.Map<LABPartyAddressHistory, LABPartyAddressHistoryEntity>(lABPartyAddressHistory);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABPartyAddressHistoryEntity", ex);
                throw;
            }

            return lABPartyAddressHistoryEntity;
        }

        /// <summary>
        /// Gets the <see cref="LABPartyEntity"/> from <see cref="LABParty"/> input.
        /// </summary>
        /// <param name="lABParty"><see cref="LABParty"/></param>
        /// <returns>Returns <see cref="LABPartyEntity"/>, else null.</returns>
        public static LABPartyEntity GetLABPartyEntity(LABParty lABParty)
        {
            LABPartyEntity lABPartyEntity = null;

            try
            {
                if (lABParty != null)
                {
                    lABPartyEntity = Mapper.Map<LABParty, LABPartyEntity>(lABParty);
                    lABPartyEntity.MPersonIDType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(lABParty.MPersonIDType);
                    lABPartyEntity.MGender = Mapper.Map<MGender, MGenderEntity>(lABParty.MGender);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABPartyEntity", ex);
                throw;
            }

            return lABPartyEntity;
        }

        /// <summary>
        /// Gets the <see cref="LABPartyHistoryEntity"/> from <see cref="LABPartyHistory"/> input.
        /// </summary>
        /// <param name="lABPartyHistory"><see cref="LABPartyHistory"/></param>
        /// <returns>Returns <see cref="LABPartyHistoryEntity"/>, else null.</returns>
        public static LABPartyHistoryEntity GetLABPartyHistoryEntity(LABPartyHistory lABPartyHistory)
        {
            LABPartyHistoryEntity lABPartyHistoryEntity = null;

            try
            {
                if (lABPartyHistory != null)
                {
                    lABPartyHistoryEntity = Mapper.Map<LABPartyHistory, LABPartyHistoryEntity>(lABPartyHistory);
                    lABPartyHistoryEntity.MPersonIDType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(lABPartyHistory.MPersonIDType);
                    lABPartyHistoryEntity.MGender = Mapper.Map<MGender, MGenderEntity>(lABPartyHistory.MGender);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABPartyHistoryEntity", ex);
                throw;
            }

            return lABPartyHistoryEntity;
        }

        /// <summary>
        /// Gets the <see cref="LABPartySolicitorEntity"/> from <see cref="LABPartySolicitor"/> input.
        /// </summary>
        /// <param name="lABPartySolicitor"><see cref="LABPartySolicitor"/></param>
        /// <returns>Returns <see cref="LABPartySolicitorEntity"/>, else null.</returns>
        public static LABPartySolicitorEntity GetLABPartySolicitorEntity(LABPartySolicitor lABPartySolicitor)
        {
            LABPartySolicitorEntity lABPartySolicitorEntity = null;

            try
            {
                if (lABPartySolicitor != null)
                {
                    lABPartySolicitorEntity = Mapper.Map<LABPartySolicitor, LABPartySolicitorEntity>(lABPartySolicitor);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABPartySolicitorEntity", ex);
                throw;
            }

            return lABPartySolicitorEntity;
        }

        /// <summary>
        /// Gets the <see cref="LABPartySolicitorHistoryEntity"/> from <see cref="LABPartySolicitorHistory"/> input.
        /// </summary>
        /// <param name="lABPartySolicitorHistory"><see cref="LABPartySolicitorHistory"/></param>
        /// <returns>Returns <see cref="LABPartySolicitorHistoryEntity"/>, else null.</returns>
        public static LABPartySolicitorHistoryEntity GetLABPartySolicitorHistoryEntity(LABPartySolicitorHistory lABPartySolicitorHistory)
        {
            LABPartySolicitorHistoryEntity lABPartySolicitorHistoryEntity = null;

            try
            {
                if (lABPartySolicitorHistory != null)
                {
                    lABPartySolicitorHistoryEntity = Mapper.Map<LABPartySolicitorHistory, LABPartySolicitorHistoryEntity>(lABPartySolicitorHistory);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABPartySolicitorHistoryEntity", ex);
                throw;
            }

            return lABPartySolicitorHistoryEntity;
        }

        /// <summary>
        /// Gets the <see cref="LABSection17CertInfoEntity"/> from <see cref="LABSection17CertInfo"/> input.
        /// </summary>
        /// <param name="lABSection17CertInfo"><see cref="LABSection17CertInfo"/></param>
        /// <returns>Returns <see cref="LABSection17CertInfoEntity"/>, else null.</returns>
        public static LABSection17CertInfoEntity GetLABSection17CertInfoEntity(LABSection17CertInfo lABSection17CertInfo)
        {
            LABSection17CertInfoEntity LABSection17CertInfoEntity = null;

            try
            {
                if (lABSection17CertInfo != null)
                {
                    LABSection17CertInfoEntity = Mapper.Map<LABSection17CertInfo, LABSection17CertInfoEntity>(lABSection17CertInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABSection17CertInfoEntity", ex);
                throw;
            }

            return LABSection17CertInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="LACCancellationInfoEntity"/> from <see cref="LACCancellationInfo"/> input.
        /// </summary>
        /// <param name="docCasePartyAddress"><see cref="LACCancellationInfo"/></param>
        /// <returns>Returns <see cref="LACCancellationInfoEntity"/>, else null.</returns>
        public static LACCancellationInfoEntity GetLACCancellationInfoEntity(LACCancellationInfo lACCancellationInfo)
        {
            LACCancellationInfoEntity LACCancellationInfoEntity = null;

            try
            {
                if (lACCancellationInfo != null)
                {
                    LACCancellationInfoEntity = Mapper.Map<LACCancellationInfo, LACCancellationInfoEntity>(lACCancellationInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLACCancellationInfoEntity", ex);
                throw;
            }

            return LACCancellationInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="LACDocumentDetailEntity"/> from <see cref="LACDocumentDetail"/> input.
        /// </summary>
        /// <param name="lACDocumentDetail"><see cref="LACDocumentDetail"/></param>
        /// <returns>Returns <see cref="LACDocumentDetailEntity"/>, else null.</returns>
        public static LACDocumentDetailEntity GetLACDocumentDetailEntity(LACDocumentDetail lACDocumentDetail)
        {
            LACDocumentDetailEntity lACDocumentDetailEntity = null;

            try
            {
                if (lACDocumentDetail != null)
                {
                    lACDocumentDetailEntity = Mapper.Map<LACDocumentDetail, LACDocumentDetailEntity>(lACDocumentDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLACDocumentDetailEntity", ex);
                throw;
            }

            return lACDocumentDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="LACDocumentDraftEntity"/> from <see cref="LACDocumentDraft"/> input.
        /// </summary>
        /// <param name="lACDocumentDraft"><see cref="LACDocumentDraft"/></param>
        /// <returns>Returns <see cref="LACDocumentDraftEntity"/>, else null.</returns>
        public static LACDocumentDraftEntity GetLACDocumentDraftEntity(LACDocumentDraft lACDocumentDraft)
        {
            LACDocumentDraftEntity lACDocumentDraftEntity = null;

            try
            {
                if (lACDocumentDraft != null)
                {
                    lACDocumentDraftEntity = Mapper.Map<LACDocumentDraft, LACDocumentDraftEntity>(lACDocumentDraft);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLACDocumentDraftEntity", ex);
                throw;
            }

            return lACDocumentDraftEntity;
        }

        /// <summary>
        /// Gets the <see cref="LACDocumentRemarkEntity"/> from <see cref="LACDocumentRemark"/> input.
        /// </summary>
        /// <param name="lACDocumentRemark"><see cref="LACDocumentRemark"/></param>
        /// <returns>Returns <see cref="LACDocumentRemarkEntity"/>, else null.</returns>
        public static LACDocumentRemarkEntity GetLACDocumentRemarkEntity(LACDocumentRemark lACDocumentRemark)
        {
            LACDocumentRemarkEntity lACDocumentRemarkEntity = null;

            try
            {
                if (lACDocumentRemark != null)
                {
                    lACDocumentRemarkEntity = Mapper.Map<LACDocumentRemark, LACDocumentRemarkEntity>(lACDocumentRemark);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLACDocumentRemarkEntity", ex);
                throw;
            }

            return lACDocumentRemarkEntity;
        }

        /// <summary>
        /// Gets the <see cref="LACInfoEntity"/> from <see cref="LACInfo"/> input.
        /// </summary>
        /// <param name="lACInfo"><see cref="LACInfo"/></param>
        /// <returns>Returns <see cref="LACInfoEntity"/>, else null.</returns>
        public static LACInfoEntity GetLACInfoEntity(LACInfo lACInfo)
        {
            LACInfoEntity lACInfoEntity = null;

            try
            {
                if (lACInfo != null)
                {
                    lACInfoEntity = Mapper.Map<LACInfo, LACInfoEntity>(lACInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLACInfoEntity", ex);
                throw;
            }

            return lACInfoEntity;
        }
                
        /// <summary>
        /// Method returns the <see cref="ILAP"/> tagged entity from <see cref="ILAPEntity"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="ILAPEntity"/> type</typeparam>
        /// <param name="lap"><see cref="ILAPEntity"/> object.</param>
        /// <returns>Returns the <see cref="ILAPEntity"/></returns>
        public static ILAPEntity GetLAPEntity<T>(T lap)
        {
            try
            {
                if (lap.GetType().Equals(typeof(LACInfo)))
                    return GetLACInfoEntity(lap as LACInfo);
                else if (lap.GetType().Equals(typeof(LACDocumentDetail)))
                    return GetLACDocumentDetailEntity(lap as LACDocumentDetail);

                return null;
            }
            catch
            { throw; }
        }

        #endregion Methods
    }
}