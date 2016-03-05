#region Header

/*****************************************************************************************************
* Description : This file handles mapper for LAP from Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   11/10/2010   		        Yan Nai                 Created
*   27/10/2010                  Swaroop                 Added logging and comments.
*****************************************************************************************************/
// <summary>
// File: LAPMapper.cs
// Description: This file handles mapper for LAP from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "LAPMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.LAP;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for LAP from Domain objects to NHibernate entities.
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
        /// Gets the <see cref="LABParty"/> from <see cref="LABPartyEntity"/> input.
        /// </summary>
        /// <param name="lABPartyEntity"><see cref="LABPartyEntity"/></param>
        /// <returns>Returns <see cref="LABParty"/>, else null.</returns>
        public static LABParty GetLABParty(LABPartyEntity lABPartyEntity)
        {
            LABParty lABParty = null;

            try
            {
                if (lABPartyEntity != null)
                {
                    lABParty = Mapper.Map<LABPartyEntity, LABParty>(lABPartyEntity);
                    lABParty.MPersonIDType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(lABPartyEntity.MPersonIDType);
                    lABParty.MGender = Mapper.Map<MGenderEntity, MGender>(lABPartyEntity.MGender);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABParty", ex);
                throw;
            }

            return lABParty;
        }

        /// <summary>
        /// Gets the <see cref="LABPartyAddress"/> from <see cref="LABPartyAddressEntity"/> input.
        /// </summary>
        /// <param name="lABPartyAddressEntity"><see cref="LABPartyAddressEntity"/></param>
        /// <returns>Returns <see cref="LABPartyAddress"/>, else null.</returns>
        public static LABPartyAddress GetLABPartyAddress(LABPartyAddressEntity lABPartyAddressEntity)
        {
            LABPartyAddress lABPartyAddress = null;

            try
            {
                lABPartyAddress = Mapper.Map<LABPartyAddressEntity, LABPartyAddress>(lABPartyAddressEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABPartyAddress", ex);
                throw;
            }

            return lABPartyAddress;
        }

        /// <summary>
        /// Gets the <see cref="LABPartyAddressHistory"/> from <see cref="LABPartyAddressHistoryEntity"/> input.
        /// </summary>
        /// <param name="lABPartyAddressHistoryEntity"><see cref="LABPartyAddressHistoryEntity"/></param>
        /// <returns>Returns <see cref="LABPartyAddressHistory"/>, else null.</returns>
        public static LABPartyAddressHistory GetLABPartyAddressHistory(LABPartyAddressHistoryEntity lABPartyAddressHistoryEntity)
        {
            LABPartyAddressHistory lABPartyAddressHistory = null;

            try
            {
                lABPartyAddressHistory = Mapper.Map<LABPartyAddressHistoryEntity, LABPartyAddressHistory>(lABPartyAddressHistoryEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABPartyAddressHistory", ex);
                throw;
            }

            return lABPartyAddressHistory;
        }

        /// <summary>
        /// Gets the <see cref="LABPartyHistory"/> from <see cref="LABPartyHistoryEntity"/> input.
        /// </summary>
        /// <param name="lABPartyHistoryEntity"><see cref="LABPartyHistoryEntity"/></param>
        /// <returns>Returns <see cref="LABPartyHistory"/>, else null.</returns>
        public static LABPartyHistory GetLABPartyHistory(LABPartyHistoryEntity lABPartyHistoryEntity)
        {
            LABPartyHistory lABPartyHistory = null;

            try
            {
                lABPartyHistory = Mapper.Map<LABPartyHistoryEntity, LABPartyHistory>(lABPartyHistoryEntity);
                lABPartyHistory.MPersonIDType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(lABPartyHistoryEntity.MPersonIDType);
                lABPartyHistory.MGender = Mapper.Map<MGenderEntity, MGender>(lABPartyHistoryEntity.MGender);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABPartyHistory", ex);
                throw;
            }

            return lABPartyHistory;
        }

        /// <summary>
        /// Gets the <see cref="LABPartySolicitor"/> from <see cref="LABPartySolicitorEntity"/> input.
        /// </summary>
        /// <param name="lABPartySolicitorEntity"><see cref="LABPartySolicitorEntity"/></param>
        /// <returns>Returns <see cref="LABPartySolicitor"/>, else null.</returns>
        public static LABPartySolicitor GetLABPartySolicitor(LABPartySolicitorEntity lABPartySolicitorEntity)
        {
            LABPartySolicitor lABPartySolicitor = null;

            try
            {
                lABPartySolicitor = Mapper.Map<LABPartySolicitorEntity, LABPartySolicitor>(lABPartySolicitorEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABPartySolicitor", ex);
                throw;
            }

            return lABPartySolicitor;
        }

        /// <summary>
        /// Gets the <see cref="LABPartySolicitorHistory"/> from <see cref="LABPartySolicitorHistoryEntity"/> input.
        /// </summary>
        /// <param name="lABPartySolicitorHistoryEntity"><see cref="LABPartySolicitorHistoryEntity"/></param>
        /// <returns>Returns <see cref="LABPartySolicitorHistory"/>, else null.</returns>
        public static LABPartySolicitorHistory GetLABPartySolicitorHistory(LABPartySolicitorHistoryEntity lABPartySolicitorHistoryEntity)
        {
            LABPartySolicitorHistory lABPartySolicitorHistory = null;

            try
            {
                lABPartySolicitorHistory = Mapper.Map<LABPartySolicitorHistoryEntity, LABPartySolicitorHistory>(lABPartySolicitorHistoryEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABPartySolicitorHistory", ex);
                throw;
            }

            return lABPartySolicitorHistory;
        }

        /// <summary>
        /// Gets the <see cref="LABSection17CertInfo"/> from <see cref="LABSection17CertInfoEntity"/> input.
        /// </summary>
        /// <param name="LABSection17CertInfoEntity"><see cref="LABSection17CertInfoEntity"/></param>
        /// <returns>Returns <see cref="LABSection17CertInfo"/>, else null.</returns>
        public static LABSection17CertInfo GetLABSection17CertInfo(LABSection17CertInfoEntity LABSection17CertInfoEntity)
        {
            LABSection17CertInfo LABSection17CertInfo = null;

            try
            {
                LABSection17CertInfo = Mapper.Map<LABSection17CertInfoEntity, LABSection17CertInfo>(LABSection17CertInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLABSection17CertInfo", ex);
                throw;
            }

            return LABSection17CertInfo;
        }

        /// <summary>
        /// Gets the <see cref="LACCancellationInfo"/> from <see cref="LACCancellationInfoEntity"/> input.
        /// </summary>
        /// <param name="LACCancellationInfoEntity"><see cref="LACCancellationInfoEntity"/></param>
        /// <returns>Returns <see cref="LACCancellationInfo"/>, else null.</returns>
        public static LACCancellationInfo GetLACCancellationInfo(LACCancellationInfoEntity LACCancellationInfoEntity)
        {
            LACCancellationInfo LACCancellationInfo = null;

            try
            {
                LACCancellationInfo = Mapper.Map<LACCancellationInfoEntity, LACCancellationInfo>(LACCancellationInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLACCancellationInfo", ex);
                throw;
            }

            return LACCancellationInfo;
        }

        /// <summary>
        /// Gets the <see cref="LACDocumentDetail"/> from <see cref="LACDocumentDetailEntity"/> input.
        /// </summary>
        /// <param name="lACDocumentDetailEntity"><see cref="LACDocumentDetailEntity"/></param>
        /// <returns>Returns <see cref="LACDocumentDetail"/>, else null.</returns>
        public static LACDocumentDetail GetLACDocumentDetail(LACDocumentDetailEntity lACDocumentDetailEntity)
        {
            LACDocumentDetail lACDocumentDetail = null;

            try
            {
                lACDocumentDetail = Mapper.Map<LACDocumentDetailEntity, LACDocumentDetail>(lACDocumentDetailEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLACDocumentDetail", ex);
                throw;
            }

            return lACDocumentDetail;
        }

        /// <summary>
        /// Gets the <see cref="LACDocumentDraft"/> from <see cref="LACDocumentDraftEntity"/> input.
        /// </summary>
        /// <param name="lACDocumentDraftEntity"><see cref="LACDocumentDraftEntity"/></param>
        /// <returns>Returns <see cref="LACDocumentDraft"/>, else null.</returns>
        public static LACDocumentDraft GetLACDocumentDraft(LACDocumentDraftEntity lACDocumentDraftEntity)
        {
            LACDocumentDraft lACDocumentDraft = null;

            try
            {
                lACDocumentDraft = Mapper.Map<LACDocumentDraftEntity, LACDocumentDraft>(lACDocumentDraftEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLACDocumentDraft", ex);
                throw;
            }

            return lACDocumentDraft;
        }

        /// <summary>
        /// Gets the <see cref="LACDocumentRemark"/> from <see cref="LACDocumentRemarkEntity"/> input.
        /// </summary>
        /// <param name="lACDocumentRemarkEntity"><see cref="LACDocumentRemarkEntity"/></param>
        /// <returns>Returns <see cref="LACDocumentRemark"/>, else null.</returns>
        public static LACDocumentRemark GetLACDocumentRemark(LACDocumentRemarkEntity lACDocumentRemarkEntity)
        {
            LACDocumentRemark lACDocumentRemark = null;

            try
            {
                lACDocumentRemark = Mapper.Map<LACDocumentRemarkEntity, LACDocumentRemark>(lACDocumentRemarkEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLACDocumentRemark", ex);
                throw;
            }

            return lACDocumentRemark;
        }

        /// <summary>
        /// Gets the <see cref="LACInfo"/> from <see cref="LACInfoEntity"/> input.
        /// </summary>
        /// <param name="lACInfoEntity"><see cref="LACInfoEntity"/></param>
        /// <returns>Returns <see cref="LACInfo"/>, else null.</returns>
        public static LACInfo GetLACInfo(LACInfoEntity lACInfoEntity)
        {
            LACInfo lACInfo = null;

            try
            {
                lACInfo = Mapper.Map<LACInfoEntity, LACInfo>(lACInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLACInfo", ex);
                throw;
            }

            return lACInfo;
        }

        /// <summary>
        /// Method returns the <see cref="ILAP"/> tagged entity from <see cref="ILAPEntity"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="ILAPEntity"/> type</typeparam>
        /// <param name="lapEntity"><see cref="ILAPEntity"/> object.</param>
        /// <returns>Returns the <see cref="ILAP"/></returns>
        public static ILAP GetLAP<T>(T lapEntity)
        {
            try
            {
                if (lapEntity.GetType().Equals(typeof(LABPartyEntity)))
                    return GetLABParty(lapEntity as LABPartyEntity);

                if (lapEntity.GetType().Equals(typeof(LABPartyHistoryEntity)))
                    return GetLABPartyHistory(lapEntity as LABPartyHistoryEntity);

                if (lapEntity.GetType().Equals(typeof(LABPartyAddressEntity)))
                    return GetLABPartyAddress(lapEntity as LABPartyAddressEntity);

                if (lapEntity.GetType().Equals(typeof(LABPartyAddressHistoryEntity)))
                    return GetLABPartyAddressHistory(lapEntity as LABPartyAddressHistoryEntity);

                if (lapEntity.GetType().Equals(typeof(LABPartySolicitorEntity)))
                    return GetLABPartySolicitor(lapEntity as LABPartySolicitorEntity);

                if (lapEntity.GetType().Equals(typeof(LABPartySolicitorHistoryEntity)))
                    return GetLABPartySolicitorHistory(lapEntity as LABPartySolicitorHistoryEntity);

                if (lapEntity.GetType().Equals(typeof(LABSection17CertInfoEntity)))
                    return GetLABSection17CertInfo(lapEntity as LABSection17CertInfoEntity);

                if (lapEntity.GetType().Equals(typeof(LACCancellationInfoEntity)))
                    return GetLACCancellationInfo(lapEntity as LACCancellationInfoEntity);

                if (lapEntity.GetType().Equals(typeof(LACDocumentDetailEntity)))
                    return GetLACDocumentDetail(lapEntity as LACDocumentDetailEntity);

                if (lapEntity.GetType().Equals(typeof(LACDocumentDraftEntity)))
                    return GetLACDocumentDraft(lapEntity as LACDocumentDraftEntity);

                if (lapEntity.GetType().Equals(typeof(LACDocumentRemarkEntity)))
                    return GetLACDocumentRemark(lapEntity as LACDocumentRemarkEntity);

                if (lapEntity.GetType().Equals(typeof(LACDocumentRemarkEntity)))
                    return GetLACDocumentRemark(lapEntity as LACDocumentRemarkEntity);

                if (lapEntity.GetType().Equals(typeof(LACInfoEntity)))
                    return GetLACInfo(lapEntity as LACInfoEntity);

               else
                    throw new ArgumentException("The referenced object is invalid or not implemented at GetLAP method in LAPMapper.");

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetLAP", ex);
                throw;
            }
        }

        #endregion Methods
    }
}