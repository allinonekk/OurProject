#region Header

/*****************************************************************************************************
* Description : This file handles mapping for PaymentInOut from Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   19/11/2010   		        Nithin                  Created
*  *****************************************************************************************************/
// <summary>
// File: CWUMapping.cs
// Description: This file handles mapping for PaymentInOut from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "CWUMapping.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.LAP;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for PaymentInOut from Domain objects to NHibernate entities.
    /// </summary>
    internal class PaymentInOutMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PaymentInOutMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method which maps the <see cref="PaymentInDocDetailEntity"/> to <see cref="PaymentInDocDetail"/>.
        /// </summary>
        internal void MapPaymentInDocDetailEntityToPaymentInDocDetail()
        {
            try
            {
                Mapper.CreateMap<PaymentInDocDetailEntity, PaymentInDocDetail>()
                    .ForMember(desc => desc.Amount, opts => opts.MapFrom(src => src.Amount))
                    .ForMember(desc => desc.AmountSGD, opts => opts.MapFrom(src => src.AmountSGD))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.MCurrency, opts => opts.MapFrom(src => src.MCurrency))
                    .ForMember(desc => desc.PayingInType, opts => opts.MapFrom(src => src.PayingInType))
                    .ForMember(desc => desc.PaymentInDocFSDetails, opts => opts.Ignore())
                    .ForMember(desc => desc.PaymentInId, opts => opts.MapFrom(src => src.PaymentInId))
                    .ForMember(desc => desc.PaymentInReason, opts => opts.MapFrom(src => src.PaymentInReason))
                    .ForMember(desc => desc.PaymentOutPayInDetails, opts => opts.Ignore())
                    .ForMember(desc => desc.Reason, opts => opts.MapFrom(src => src.Reason))
                    .ForMember(desc => desc.RefOrderDetailId, opts => opts.MapFrom(src => src.RefOrderDetailId))
                    .ForMember(desc => desc.RuleNo, opts => opts.MapFrom(src => src.RuleNo))
                    .ForMember(desc => desc.RuleOrderNo, opts => opts.MapFrom(src => src.RuleOrderNo))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.HasTransferredOut, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.HasTransferredOut));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPaymentInDocDetailEntityToPaymentInDocDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PaymentInDocFSDetailEntity"/> to <see cref="PaymentInDocFSDetail"/>.
        /// </summary>
        internal void MapPaymentInDocFSDetailEntityToPaymentInDocFSDetail()
        {
            try
            {
                Mapper.CreateMap<PaymentInDocFSDetailEntity, PaymentInDocFSDetail>()
                    .ForMember(desc => desc.Amount, opts => opts.MapFrom(src => src.Amount))
                    .ForMember(desc => desc.AmountSGD, opts => opts.MapFrom(src => src.AmountSGD))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.MCurrency, opts => opts.MapFrom(src => src.MCurrency))
                    .ForMember(desc => desc.Particulars, opts => opts.MapFrom(src => src.Particulars))
                    .ForMember(desc => desc.PaymentInFSId, opts => opts.MapFrom(src => src.PaymentInFSID))
                    .ForMember(desc => desc.PersonsDirected, opts => opts.MapFrom(src => src.PersonsDirected))
                    .ForMember(desc => desc.Securities, opts => opts.MapFrom(src => src.Securities))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));
                    //.ForMember(desc => desc.PaymentInId, opts => opts.MapFrom(src => src.PaymentInId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPaymentInDocFSDetailEntityToPaymentInDocFSDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PaymentOutDocDetailEntity"/> to <see cref="PaymentOutDocDetail"/>.
        /// </summary>
        internal void MapPaymentOutDocDetailEntityToPaymentOutDocDetail()
        {
            try
            {
                Mapper.CreateMap<PaymentOutDocDetailEntity, PaymentOutDocDetail>()
                    .ForMember(desc => desc.Amount, opts => opts.MapFrom(src => src.Amount))
                    .ForMember(desc => desc.Designation, opts => opts.MapFrom(src => src.Designation))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.PartyName, opts => opts.MapFrom(src => src.PartyName))
                    .ForMember(desc => desc.PaymentOutId, opts => opts.MapFrom(src => src.PaymentOutID))
                    .ForMember(desc => desc.PaymentOutPayInDetails, opts => opts.Ignore())
                    .ForMember(desc => desc.POReason, opts => opts.MapFrom(src => src.POReason))
                    .ForMember(desc => desc.RefOrderDetailId, opts => opts.MapFrom(src => src.RefOrderDetailId))
                    .ForMember(desc => desc.Remarks, opts => opts.MapFrom(src => src.Remarks))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPaymentOutDocDetailEntityToPaymentOutDocDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="PaymentOutPayInDetailEntity"/> to <see cref="PaymentOutPayInDetail"/>.
        /// </summary>
        internal void MapPOPIDetailEntityToPOPIDetail()
        {
            try
            {
                Mapper.CreateMap<PaymentOutPayInDetailEntity, PaymentOutPayInDetail>()
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                   .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.MCourtType, opts => opts.MapFrom(src => src.MCourtType))
                    .ForMember(desc => desc.PaymentInId, opts => opts.MapFrom(src => src.PaymentInId))
                    .ForMember(desc => desc.PaymentOutId, opts => opts.MapFrom(src => src.PaymentOutID))
                    .ForMember(desc => desc.PaymentOutInId, opts => opts.MapFrom(src => src.PaymentOutInID))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.IsBackEndUserAdded, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsBackEndUserAdded));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapPOPIDetailEntityToPOPIDetail", ex);
                throw;
            }
        }

        #endregion Methods
    }
}