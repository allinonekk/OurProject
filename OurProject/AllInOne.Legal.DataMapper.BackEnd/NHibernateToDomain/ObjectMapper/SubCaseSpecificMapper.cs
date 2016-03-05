#region Header

/*****************************************************************************************************
* Description : This file handles mapper for SubCaseSpecific from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/12/2010   		        Swaroop                  Created
*****************************************************************************************************/
// <summary>
// File: SubCaseSpecificMapper.cs
// Description: This file handles mapper for SubCaseSpecific from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "SubCaseSpecificMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;
using System.Runtime.CompilerServices;

    /// <summary>
    /// Class handles mapping for SubCaseSpecific from NHibernate entities to Domain objects.
    /// </summary>
    public class SubCaseSpecificMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SubCaseSpecificMapper));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the <see cref="AccountantsReportInfoEntity"/> from <see cref="AccountantsReportInfo"/> input.
        /// </summary>
        /// <param name="accountantsReportInfoEntity"><see cref="AccountantsReportInfo"/></param>
        /// <returns>Returns <see cref="AccountantsReportInfoEntity"/>, else null.</returns>
        public static AccountantsReportInfoEntity GetAccountantsReportInfoEntity(AccountantsReportInfo accountantsReportInfo)
        {
            AccountantsReportInfoEntity accountantsReportInfoEntity = null;

            try
            {
                if (accountantsReportInfo != null)
                {
                    accountantsReportInfoEntity = Mapper.Map<AccountantsReportInfo, AccountantsReportInfoEntity>(accountantsReportInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetAccountantsReportInfoEntity", ex);
                throw;
            }

            return accountantsReportInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="ADMWAInfoEntity"/> from <see cref="ADMWAInfo"/> input.
        /// </summary>
        /// <param name="aDMWAInfo"><see cref="ADMWAInfo"/></param>
        /// <returns>Returns <see cref="ADMWAInfoEntity"/>, else null.</returns>
        public static ADMWAInfoEntity GetADMWAInfoEntity(ADMWAInfo aDMWAInfo)
        {
            ADMWAInfoEntity aDMWAInfoEntity = null;

            try
            {
                if (aDMWAInfo != null)
                {
                    aDMWAInfoEntity = Mapper.Map<ADMWAInfo, ADMWAInfoEntity>(aDMWAInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetADMWAInfoEntity", ex);
                throw;
            }

            return aDMWAInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="AreaOfLegalPracticeEntity"/> from <see cref="AreaOfLegalPractice"/> input.
        /// </summary>
        /// <param name="areaOfLegalPracticeEntity"><see cref="AreaOfLegalPractice"/></param>
        /// <returns>Returns <see cref="AreaOfLegalPracticeEntity"/>, else null.</returns>
        public static AreaOfLegalPracticeEntity GetAreaOfLegalPracticeEntity(AreaOfLegalPractice areaOfLegalPractice)
        {
            AreaOfLegalPracticeEntity areaOfLegalPracticeEntity = null;

            try
            {
                if (areaOfLegalPractice != null)
                {
                    areaOfLegalPracticeEntity = Mapper.Map<AreaOfLegalPractice, AreaOfLegalPracticeEntity>(areaOfLegalPractice);
                    areaOfLegalPracticeEntity.MLegalPractice = Mapper.Map<MLegalPractice, MLegalPracticeEntity>(areaOfLegalPractice.MLegalPractice);
                    areaOfLegalPracticeEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(areaOfLegalPractice.MCountry);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetAreaOfLegalPracticeEntity", ex);
                throw;
            }

            return areaOfLegalPracticeEntity;
        }

        /// <summary>
        /// Gets the <see cref="LPOthLegalOrgAddrInfoEntity"/> from <see cref="LPOthLegalOrgAddrInfo"/> input.
        /// </summary>
        /// <param name="lPOthLegalOrgAddrInfo"><see cref="LPOthLegalOrgAddrInfo"/></param>
        /// <returns>Returns <see cref="LPOthLegalOrgAddrInfoEntity"/>, else null.</returns>
        public static LPOthLegalOrgAddrInfoEntity GetLPOthLegalOrgAddrInfoEntity(LPOthLegalOrgAddrInfo lPOthLegalOrgAddrInfo)
        {
            LPOthLegalOrgAddrInfoEntity lPOthLegalOrgAddrInfoEntity = null;

            try
            {
                if (lPOthLegalOrgAddrInfo != null)
                {
                    lPOthLegalOrgAddrInfoEntity = Mapper.Map<LPOthLegalOrgAddrInfo, LPOthLegalOrgAddrInfoEntity>(lPOthLegalOrgAddrInfo);
                    lPOthLegalOrgAddrInfoEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(lPOthLegalOrgAddrInfo.MCountry);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLPOthLegalOrgAddrInfoEntity", ex);
                throw;
            }

            return lPOthLegalOrgAddrInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="LPOthLegalOrgInfoEntity"/> from <see cref="LPOthLegalOrgInfo"/> input.
        /// </summary>
        /// <param name="lPOthLegalOrgInfo"><see cref="LPOthLegalOrgInfo"/></param>
        /// <returns>Returns <see cref="LPOthLegalOrgInfoEntity"/>, else null.</returns>
        public static LPOthLegalOrgInfoEntity GetLPOthLegalOrgInfoEntity(LPOthLegalOrgInfo lPOthLegalOrgInfo)
        {
            LPOthLegalOrgInfoEntity lPOthLegalOrgInfoEntity = null;

            try
            {
                if (lPOthLegalOrgInfo != null)
                {
                    lPOthLegalOrgInfoEntity = Mapper.Map<LPOthLegalOrgInfo, LPOthLegalOrgInfoEntity>(lPOthLegalOrgInfo);
                    lPOthLegalOrgInfoEntity.MAASOrganisationType = Mapper.Map<MAASOrganisationType, MAASOrganisationTypeEntity>(lPOthLegalOrgInfo.MAASOrganisationType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLPOthLegalOrgInfoEntity", ex);
                throw;
            }

            return lPOthLegalOrgInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="PaymentInDocDetailEntity"/> from <see cref="PaymentInDocDetail"/> input.
        /// </summary>
        /// <param name="paymentInDocDetail"><see cref="PaymentInDocDetail"/></param>
        /// <returns>Returns <see cref="PaymentInDocDetailEntity"/>, else null.</returns>
        public static PaymentInDocDetailEntity GetPaymentInDocDetailEntity(PaymentInDocDetail paymentInDocDetail)
        {
            PaymentInDocDetailEntity paymentInDocDetailEntity = null;

            try
            {
                if (paymentInDocDetail != null)
                {
                    paymentInDocDetailEntity = Mapper.Map<PaymentInDocDetail, PaymentInDocDetailEntity>(paymentInDocDetail);
                    paymentInDocDetailEntity.MCurrency = Mapper.Map<MCurrency, MCurrencyEntity>(paymentInDocDetail.MCurrency);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPaymentInDocDetailEntity", ex);
                throw;
            }

            return paymentInDocDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="PaymentInDocFSDetailEntity"/> from <see cref="PaymentInDocFSDetail"/> input.
        /// </summary>
        /// <param name="paymentInDocFSDetail"><see cref="PaymentInDocFSDetail"/></param>
        /// <returns>Returns <see cref="PaymentInDocFSDetailEntity"/>, else null.</returns>
        public static PaymentInDocFSDetailEntity GetPaymentInDocFSDetail(PaymentInDocFSDetail paymentInDocFSDetail)
        {
            PaymentInDocFSDetailEntity paymentInDocFSDetailEntity = null;

            try
            {
                if (paymentInDocFSDetail != null)
                {
                    paymentInDocFSDetailEntity = Mapper.Map<PaymentInDocFSDetail, PaymentInDocFSDetailEntity>(paymentInDocFSDetail);
                    paymentInDocFSDetailEntity.MCurrency = Mapper.Map<MCurrency, MCurrencyEntity>(paymentInDocFSDetail.MCurrency);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPaymentInDocFSDetail", ex);
                throw;
            }

            return paymentInDocFSDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="PaymentOutDocDetailEntity"/> from <see cref="PaymentOutDocDetail"/> input.
        /// </summary>
        /// <param name="paymentOutDocDetail"><see cref="PaymentOutDocDetail"/></param>
        /// <returns>Returns <see cref="PaymentOutDocDetailEntity"/>, else null.</returns>
        public static PaymentOutDocDetailEntity GetPaymentOutDocEntity(PaymentOutDocDetail paymentOutDocDetail)
        {
            PaymentOutDocDetailEntity paymentOutDocDetailEntity = null;

            try
            {
                if (paymentOutDocDetail != null)
                {
                    paymentOutDocDetailEntity = Mapper.Map<PaymentOutDocDetail, PaymentOutDocDetailEntity>(paymentOutDocDetail);
                    paymentOutDocDetailEntity.MCurrency = Mapper.Map<MCurrency, MCurrencyEntity>(paymentOutDocDetail.MCurrency);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPaymentOutDocEntity", ex);
                throw;
            }

            return paymentOutDocDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="PaymentOutPayInDetailEntity"/> from <see cref="PaymentOutPayInDetail"/> input.
        /// </summary>
        /// <param name="paymentOutPayInDetail"><see cref="PaymentOutPayInDetail"/></param>
        /// <returns>Returns <see cref="PaymentOutPayInDetailEntity"/>, else null.</returns>
        public static PaymentOutPayInDetailEntity GetPaymentOutPaymentInDetail(PaymentOutPayInDetail paymentOutPayInDetail)
        {
            PaymentOutPayInDetailEntity paymentOutPayInDetailEntity = null;

            try
            {
                if (paymentOutPayInDetail != null)
                {
                    paymentOutPayInDetailEntity = Mapper.Map<PaymentOutPayInDetail, PaymentOutPayInDetailEntity>(paymentOutPayInDetail);
                    paymentOutPayInDetailEntity.MCourtType = Mapper.Map<MCourtType, MCourtTypeEntity>(paymentOutPayInDetail.MCourtType);
                    paymentOutPayInDetailEntity.MCurrency = Mapper.Map<MCurrency, MCurrencyEntity>(paymentOutPayInDetail.MCurrency);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPaymentOutPaymentInDetail", ex);
                throw;
            }

            return paymentOutPayInDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="PCInfoEntity"/> from <see cref="PCInfo"/> input.
        /// </summary>
        /// <param name="pCInfo"><see cref="PCInfo"/></param>
        /// <returns>Returns <see cref="PCInfoEntity"/>, else null.</returns>
        public static PCInfoEntity GetPCInfoEntity(PCInfo pCInfo)
        {
            PCInfoEntity pCInfoEntity = null;

            try
            {
                if (pCInfo != null)
                {
                    pCInfoEntity = Mapper.Map<PCInfo, PCInfoEntity>(pCInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPCInfoEntity", ex);
                throw;
            }

            return pCInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="RARASInfoEntity"/> from <see cref="RARASInfo"/> input.
        /// </summary>
        /// <param name="rARASInfo"><see cref="RARASInfo"/></param>
        /// <returns>Returns <see cref="RARASInfoEntity"/>, else null.</returns>
        public static RARASInfoEntity GetRARAInfoEntity(RARASInfo rARASInfo)
        {
            RARASInfoEntity rARASInfoEntity = null;

            try
            {
                if (rARASInfo != null)
                {
                    rARASInfoEntity = Mapper.Map<RARASInfo, RARASInfoEntity>(rARASInfo);
                    rARASInfoEntity.MDesignation = Mapper.Map<MDesignation, MDesignationEntity>(rARASInfo.MDesignation);
                    rARASInfoEntity.MCoram = Mapper.Map<MCoram, MCoramEntity>(rARASInfo.MCoram);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRARAInfoEntity", ex);
                throw;
            }

            return rARASInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="ServiceOfDocDocStatusHistoryEntity"/> from <see cref="ServiceOfDocDocStatusHistory"/> input.
        /// </summary>
        /// <param name="serviceOfDocDocStatusHistory"><see cref="ServiceOfDocDocStatusHistory"/></param>
        /// <returns>Returns <see cref="ServiceOfDocDocStatusHistoryEntity"/>, else null.</returns>
        public static ServiceOfDocDocStatusHistoryEntity GetServiceOfDocDocStatusHistoryEntity(ServiceOfDocDocStatusHistory serviceOfDocDocStatusHistory)
        {
            ServiceOfDocDocStatusHistoryEntity serviceOfDocDocStatusHistoryEntity = null;

            try
            {
                if (serviceOfDocDocStatusHistory != null)
                {
                    serviceOfDocDocStatusHistoryEntity = Mapper.Map<ServiceOfDocDocStatusHistory, ServiceOfDocDocStatusHistoryEntity>(serviceOfDocDocStatusHistory);
                    serviceOfDocDocStatusHistoryEntity.MServeStatus = Mapper.Map<MServeStatus, MServeStatusEntity>(serviceOfDocDocStatusHistory.MServeStatus);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetServiceOfDocDocStatusHistoryEntity", ex);
                throw;
            }

            return serviceOfDocDocStatusHistoryEntity;
        }

        /// <summary>
        /// Gets the <see cref="ServiceOfDocDocumentEntity"/> from <see cref="ServiceOfDocDocument"/> input.
        /// </summary>
        /// <param name="serviceOfDocDocument"><see cref="ServiceOfDocDocument"/></param>
        /// <returns>Returns <see cref="ServiceOfDocDocumentEntity"/>, else null.</returns>
        public static ServiceOfDocDocumentEntity GetServiceOfDocDocumentEntity(ServiceOfDocDocument serviceOfDocDocument)
        {
            ServiceOfDocDocumentEntity serviceOfDocDocumentEntity = null;

            try
            {
                if (serviceOfDocDocument != null)
                {
                    serviceOfDocDocumentEntity = Mapper.Map<ServiceOfDocDocument, ServiceOfDocDocumentEntity>(serviceOfDocDocument);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetServiceOfDocDocumentEntity", ex);
                throw;
            }

            return serviceOfDocDocumentEntity;
        }

        /// <summary>
        /// Gets the <see cref="ServiceOfDocInfoDetailEntity"/> from <see cref="ServiceOfDocInfoDetail"/> input.
        /// </summary>
        /// <param name="serviceOfDocInfoDetail"><see cref="ServiceOfDocInfoDetail"/></param>
        /// <returns>Returns <see cref="ServiceOfDocInfoDetailEntity"/>, else null.</returns>
        public static ServiceOfDocInfoDetailEntity GetServiceOfDocInfoDetailEntity(ServiceOfDocInfoDetail serviceOfDocInfoDetail)
        {
            ServiceOfDocInfoDetailEntity serviceOfDocInfoDetailEntity = null;

            try
            {
                if (serviceOfDocInfoDetail != null)
                {
                    serviceOfDocInfoDetailEntity = Mapper.Map<ServiceOfDocInfoDetail, ServiceOfDocInfoDetailEntity>(serviceOfDocInfoDetail);
                    serviceOfDocInfoDetailEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(serviceOfDocInfoDetail.MCountry);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetServiceOfDocInfoDetailEntity", ex);
                throw;
            }

            return serviceOfDocInfoDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="ServiceOfDocInfoEntity"/> from <see cref="ServiceOfDocInfo"/> input.
        /// </summary>
        /// <param name="serviceOfDocInfo"><see cref="ServiceOfDocInfo"/></param>
        /// <returns>Returns <see cref="ServiceOfDocInfoEntity"/>, else null.</returns>
        public static ServiceOfDocInfoEntity GetServiceOfDocInfoEntity(ServiceOfDocInfo serviceOfDocInfo)
        {
            ServiceOfDocInfoEntity serviceOfDocInfoEntity = null;

            try
            {
                if (serviceOfDocInfo != null)
                {
                    serviceOfDocInfoEntity = Mapper.Map<ServiceOfDocInfo, ServiceOfDocInfoEntity>(serviceOfDocInfo);
                    serviceOfDocInfoEntity.MServeStatus = Mapper.Map<MServeStatus, MServeStatusEntity>(serviceOfDocInfo.MServeStatus);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetServiceOfDocInfoEntity", ex);
                throw;
            }

            return serviceOfDocInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="SetDownInfoEntity"/> from <see cref="SetDownInfo"/> input.
        /// </summary>
        /// <param name="setDownInfo"><see cref="SetDownInfo"/></param>
        /// <returns>Returns <see cref="SetDownInfoEntity"/>, else null.</returns>
        public static SetDownInfoEntity GetSetDownInfoEntity(SetDownInfo setDownInfo)
        {
            SetDownInfoEntity setDownInfoEntity = null;

            try
            {
                if (setDownInfo != null)
                {
                    setDownInfoEntity = Mapper.Map<SetDownInfo, SetDownInfoEntity>(setDownInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSetDownInfoEntity", ex);
                throw;
            }

            return setDownInfoEntity;
        }

        /// <summary>
        /// Method returns the <see cref="ISubCaseSpecific"/> tagged entity from <see cref="ISubCaseSpecificEntity"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="ISubCaseSpecificEntity"/> type</typeparam>
        /// <param name="subCaseSpecificEntity"><see cref="ISubCaseSpecificEntity"/> object.</param>
        /// <returns>Returns the <see cref="ISubCaseSpecific"/></returns>
        public static ISubCaseSpecificEntity GetSubCaseSpecificEntity<T>(T subCaseSpecificEntity)
        {
            try
            {
                if (subCaseSpecificEntity.GetType().Equals(typeof(AccountantsReportInfo)))
                    return (GetAccountantsReportInfoEntity(subCaseSpecificEntity as AccountantsReportInfo));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(ADMWAInfo)))
                    return (GetADMWAInfoEntity(subCaseSpecificEntity as ADMWAInfo));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(AreaOfLegalPractice)))
                    return (GetAreaOfLegalPracticeEntity(subCaseSpecificEntity as AreaOfLegalPractice));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(LPOthLegalOrgAddrInfo)))
                    return (GetLPOthLegalOrgAddrInfoEntity(subCaseSpecificEntity as LPOthLegalOrgAddrInfo));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(LPOthLegalOrgInfo)))
                    return (GetLPOthLegalOrgInfoEntity(subCaseSpecificEntity as LPOthLegalOrgInfo));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(PaymentInDocDetail)))
                    return (GetPaymentInDocDetailEntity(subCaseSpecificEntity as PaymentInDocDetail));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(PaymentInDocFSDetail)))
                    return (GetPaymentInDocFSDetail(subCaseSpecificEntity as PaymentInDocFSDetail));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(PaymentOutDocDetail)))
                    return (GetPaymentOutDocEntity(subCaseSpecificEntity as PaymentOutDocDetail));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(PaymentOutPayInDetail)))
                    return (GetPaymentOutPaymentInDetail(subCaseSpecificEntity as PaymentOutPayInDetail));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(PCInfo)))
                    return (GetPCInfoEntity(subCaseSpecificEntity as PCInfo));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(RARASInfo)))
                    return (GetRARAInfoEntity(subCaseSpecificEntity as RARASInfo));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(ServiceOfDocDocStatusHistory)))
                    return (GetServiceOfDocDocStatusHistoryEntity(subCaseSpecificEntity as ServiceOfDocDocStatusHistory));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(ServiceOfDocDocument)))
                    return (GetServiceOfDocDocumentEntity(subCaseSpecificEntity as ServiceOfDocDocument));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(ServiceOfDocInfoDetail)))
                    return (GetServiceOfDocInfoDetailEntity(subCaseSpecificEntity as ServiceOfDocInfoDetail));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(ServiceOfDocInfo)))
                    return (GetServiceOfDocInfoEntity(subCaseSpecificEntity as ServiceOfDocInfo));

                else if (subCaseSpecificEntity.GetType().Equals(typeof(SetDownInfo)))
                    return (GetSetDownInfoEntity(subCaseSpecificEntity as SetDownInfo));

                else
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetSubCaseSpecificEntity method in SubCaseSpecificMapper.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSubCaseSpecificEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the <see cref="SetDownInfoEntity"/> from <see cref="SetDownInfo"/> input.
        /// </summary>
        /// <param name="setDownInfo"><see cref="SetDownInfo"/></param>
        /// <returns>Returns <see cref="SetDownInfoEntity"/>, else null.</returns>
        public static NOCInfoEntity GetNOCInfoEntity(NOCInfo nOCInfo)
        {
            NOCInfoEntity nOCInfoEntity = null;

            try
            {
                if (nOCInfo != null)
                {
                    nOCInfoEntity = Mapper.Map<NOCInfo, NOCInfoEntity>(nOCInfo);
                    nOCInfoEntity.MLawPracticeTypeEntity = Mapper.Map<MLawPracticeType, MLawPracticeTypeEntity>(nOCInfo.MLawPracticeType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetNOCInfoEntity", ex);
                throw;
            }

            return nOCInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="SetDownInfoEntity"/> from <see cref="SetDownInfo"/> input.
        /// </summary>
        /// <param name="setDownInfo"><see cref="SetDownInfo"/></param>
        /// <returns>Returns <see cref="SetDownInfoEntity"/>, else null.</returns>
        public static PCInfoAccReportEntity GetPCInfoAccReportEntity(PCInfoAccReport PCInfoAccReport)
        {
            PCInfoAccReportEntity pCInfoAccReportEntity = null;

            try
            {
                if (PCInfoAccReport != null)
                {
                    pCInfoAccReportEntity = Mapper.Map<PCInfoAccReport, PCInfoAccReportEntity>(PCInfoAccReport);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPCInfoAccReportEntity", ex);
                throw;
            }

            return pCInfoAccReportEntity;
        }

        /// <summary>
        /// Gets the <see cref="SetDownInfoEntity"/> from <see cref="SetDownInfo"/> input.
        /// </summary>
        /// <param name="setDownInfo"><see cref="SetDownInfo"/></param>
        /// <returns>Returns <see cref="SetDownInfoEntity"/>, else null.</returns>
        public static VoteInfoEntity GetVoteInfoEntity(VoteInfo voteInfo)
        {
            VoteInfoEntity voteInfoEntity = null;

            try
            {
                if (voteInfo != null)
                {
                    voteInfoEntity = Mapper.Map<VoteInfo, VoteInfoEntity>(voteInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetVoteInfoEntity", ex);
                throw;
            }

            return voteInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="SetDownInfoEntity"/> from <see cref="SetDownInfo"/> input.
        /// </summary>
        /// <param name="setDownInfo"><see cref="SetDownInfo"/></param>
        /// <returns>Returns <see cref="SetDownInfoEntity"/>, else null.</returns>
        public static VoteInfoDeltaEntity GetVoteInfoDeltaEntity(VoteInfoDelta voteInfoDelta)
        {
            VoteInfoDeltaEntity voteInfoDeltaEntity = null;

            try
            {
                if (voteInfoDelta != null)
                {
                    voteInfoDeltaEntity = Mapper.Map<VoteInfoDelta, VoteInfoDeltaEntity>(voteInfoDelta);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetVoteInfoDeltaEntity", ex);
                throw;
            }

            return voteInfoDeltaEntity;
        }

        public static DashboardSubCaseMilestoneDetailEntity GetDashboardSubCaseMilestoneDetailEntity(DashboardSubCaseMilestoneDetail dashboardSubCaseMilestoneDetail)
        {
            DashboardSubCaseMilestoneDetailEntity dashboardSubCaseMilestoneDetailEntity = null;
            try
            {
                if (dashboardSubCaseMilestoneDetail != null)
                {
                    dashboardSubCaseMilestoneDetailEntity = Mapper.Map<DashboardSubCaseMilestoneDetail, DashboardSubCaseMilestoneDetailEntity>(dashboardSubCaseMilestoneDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDashboardSubCaseMilestoneDetailEntity", ex);
                throw;
            }
            return dashboardSubCaseMilestoneDetailEntity;
        }

        public static DashboardSubCaseMilestoneDetailHistoryEntity GetDashboardSubCaseMilestoneDetailHistoryEntity(DashboardSubCaseMilestoneDetailHistory dashboardSubCaseMilestoneDetailHistory)
        {
            DashboardSubCaseMilestoneDetailHistoryEntity dashboardSubCaseMilestoneDetailHistoryEntity = null;
            try
            {
                if (dashboardSubCaseMilestoneDetailHistory != null)
                {
                    dashboardSubCaseMilestoneDetailHistoryEntity = Mapper.Map<DashboardSubCaseMilestoneDetailHistory, DashboardSubCaseMilestoneDetailHistoryEntity>(dashboardSubCaseMilestoneDetailHistory);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDashboardSubCaseMilestoneDetailHistoryEntity", ex);
                throw;
            }
            return dashboardSubCaseMilestoneDetailHistoryEntity;
        }

        #endregion Methods
    }
}