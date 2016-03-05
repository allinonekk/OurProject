#region Header

/*****************************************************************************************************
* Description : This file handles mapper for PaymentInOut from Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   20/10/2010   		        Nithin                  Created
*   27/10/2010                  Swaroop                 Added logging and comments.
*****************************************************************************************************/
// <summary>
// File: PaymentInOutMapper.cs
// Description: This file handles mapper for PaymentInOut from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "PaymentInOutMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for PaymentInOut from Domain objects to NHibernate entities.
    /// </summary>
    public class PaymentInOutMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PaymentInOutMapper));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the <see cref="PaymentInDocDetail"/> from <see cref="PaymentInDocDetailEntity"/> input.
        /// </summary>
        /// <param name="paymentInDocDetailEntity"><see cref="PaymentInDocDetailEntity"/></param>
        /// <returns>Returns <see cref="PaymentInDocDetail"/>, else null.</returns>
        public static PaymentInDocDetail GetPaymentInDocDetail(PaymentInDocDetailEntity paymentInDocDetailEntity)
        {
            PaymentInDocDetail paymentInDocDetail = null;

            try
            {
                paymentInDocDetail = Mapper.Map<PaymentInDocDetailEntity, PaymentInDocDetail>(paymentInDocDetailEntity);
                paymentInDocDetail.MCurrency = Mapper.Map<MCurrencyEntity, MCurrency>(paymentInDocDetailEntity.MCurrency);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPaymentInDocDetail", ex);
                throw;
            }

            return paymentInDocDetail;
        }

        /// <summary>
        /// Gets the <see cref="PaymentInDocFSDetail"/> from <see cref="PaymentInDocFSDetailEntity"/> input.
        /// </summary>
        /// <param name="paymentInDocFSDetailEntity"><see cref="PaymentInDocFSDetailEntity"/></param>
        /// <returns>Returns <see cref="PaymentInDocFSDetail"/>, else null.</returns>
        public static PaymentInDocFSDetail GetPaymentInDocFSDetail(PaymentInDocFSDetailEntity paymentInDocFSDetailEntity)
        {
            PaymentInDocFSDetail paymentInDocFSDetail = null;

            try
            {
                paymentInDocFSDetail = Mapper.Map<PaymentInDocFSDetailEntity, PaymentInDocFSDetail>(paymentInDocFSDetailEntity);
                paymentInDocFSDetail.MCurrency = Mapper.Map<MCurrencyEntity, MCurrency>(paymentInDocFSDetailEntity.MCurrency);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPaymentInDocFSDetail", ex);
                throw;
            }

            return paymentInDocFSDetail;
        }

        /// <summary>
        /// Gets the <see cref="PaymentOutDocDetail"/> from <see cref="PaymentOutDocDetailEntity"/> input.
        /// </summary>
        /// <param name="paymentOutDocDetailEntity"><see cref="PaymentOutDocDetailEntity"/></param>
        /// <returns>Returns <see cref="PaymentOutDocDetail"/>, else null.</returns>
        public static PaymentOutDocDetail GetPaymentOutDocDetail(PaymentOutDocDetailEntity paymentOutDocDetailEntity)
        {
            PaymentOutDocDetail paymentOutDocDetail = null;

            try
            {
                paymentOutDocDetail = Mapper.Map<PaymentOutDocDetailEntity, PaymentOutDocDetail>(paymentOutDocDetailEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPaymentOutDocDetail", ex);
                throw;
            }

            return paymentOutDocDetail;
        }

        /// <summary>
        /// Gets the <see cref="PaymentOutPayInDetail"/> from <see cref="PaymentOutPayInDetailEntity"/> input.
        /// </summary>
        /// <param name="paymentOutPayInDetailEntity"><see cref="PaymentOutPayInDetailEntity"/></param>
        /// <returns>Returns <see cref="PaymentOutPayInDetail"/>, else null.</returns>
        public static PaymentOutPayInDetail GetPaymentOutPaymentInDetail(PaymentOutPayInDetailEntity paymentOutPayInDetailEntity)
        {
            PaymentOutPayInDetail paymentOutPayInDetail = null;

            try
            {
                paymentOutPayInDetail = Mapper.Map<PaymentOutPayInDetailEntity, PaymentOutPayInDetail>(paymentOutPayInDetailEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPaymentOutPaymentInDetail", ex);
                throw;
            }

            return paymentOutPayInDetail;
        }

        #endregion Methods
    }
}