#region Header

/*****************************************************************************************************
* Description : This file handles mapper for SubCase Specific from Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   26/11/2010   		        Nithin                  Created

*****************************************************************************************************/
// <summary>
// File: SubCaseSpecificMapper.cs
// Description: This file handles mapper for SubCase Specific from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "SubCaseSpecificMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for SubCase Specific from Domain objects to NHibernate entities.
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
        /// Gets the <see cref="AccountantsReportInfo"/> from <see cref="AccountantsReportInfoEntity"/> input.
        /// </summary>
        /// <param name="accountantsReportInfoEntity"><see cref="AccountantsReportInfoEntity"/></param>
        /// <returns>Returns <see cref="AccountantsReportInfo"/>, else null.</returns>
        public static AccountantsReportInfo GetAccountantsReportInfo(AccountantsReportInfoEntity accountantsReportInfoEntity)
        {
            AccountantsReportInfo accountantsReportInfo = null;

            try
            {
                if (accountantsReportInfoEntity != null)
                {
                    accountantsReportInfo = Mapper.Map<AccountantsReportInfoEntity, AccountantsReportInfo>(accountantsReportInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetAccountantsReportInfo", ex);
                throw;
            }

            return accountantsReportInfo;
        }

        public static ADMWAInfo GetADMWAInfo(ADMWAInfoEntity aDMWAInfoEntity)
        {
            ADMWAInfo aDMWAInfo = null;
            try
            {
                aDMWAInfo = Mapper.Map<ADMWAInfoEntity, ADMWAInfo>(aDMWAInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetADMWAInfo", ex);
                throw;
            }
            return aDMWAInfo;
        }

        /// <summary>
        /// Gets the <see cref="AreaOfLegalPractice"/> from <see cref="AreaOfLegalPracticeEntity"/> input.
        /// </summary>
        /// <param name="areaOfLegalPracticeEntity"><see cref="AreaOfLegalPracticeEntity"/></param>
        /// <returns>Returns <see cref="AreaOfLegalPractice"/>, else null.</returns>
        public static AreaOfLegalPractice GetAreaOfLegalPractice(AreaOfLegalPracticeEntity areaOfLegalPracticeEntity)
        {
            AreaOfLegalPractice areaOfLegalPractice = null;

            try
            {
                if (areaOfLegalPracticeEntity != null)
                {
                    areaOfLegalPractice = Mapper.Map<AreaOfLegalPracticeEntity, AreaOfLegalPractice>(areaOfLegalPracticeEntity);
                    areaOfLegalPractice.MLegalPractice = Mapper.Map<MLegalPracticeEntity, MLegalPractice>(areaOfLegalPracticeEntity.MLegalPractice);
                    areaOfLegalPractice.MCountry = Mapper.Map<MCountryEntity, MCountry>(areaOfLegalPracticeEntity.MCountry);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetAreaOfLegalPractice", ex);
                throw;
            }

            return areaOfLegalPractice;
        }

        /// <summary>
        /// Gets the <see cref="LPOthLegalOrgAddrInfo"/> from <see cref="LPOthLegalOrgAddrInfoEntity"/> input.
        /// </summary>
        /// <param name="lPOthLegalOrgAddrInfoEntity"><see cref="LPOthLegalOrgAddrInfoEntity"/></param>
        /// <returns>Returns <see cref="LPOthLegalOrgAddrInfo"/>, else null.</returns>
        public static LPOthLegalOrgAddrInfo GetLPOthLegalOrgAddrInfo(LPOthLegalOrgAddrInfoEntity lPOthLegalOrgAddrInfoEntity)
        {
            LPOthLegalOrgAddrInfo lPOthLegalOrgAddrInfo = null;

            try
            {
                if (lPOthLegalOrgAddrInfoEntity != null)
                {
                    lPOthLegalOrgAddrInfo = Mapper.Map<LPOthLegalOrgAddrInfoEntity, LPOthLegalOrgAddrInfo>(lPOthLegalOrgAddrInfoEntity);
                    lPOthLegalOrgAddrInfo.MCountry = Mapper.Map<MCountryEntity, MCountry>(lPOthLegalOrgAddrInfoEntity.MCountry);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLPOthLegalOrgAddrInfo", ex);
                throw;
            }

            return lPOthLegalOrgAddrInfo;
        }

        /// <summary>
        /// Gets the <see cref="LPOthLegalOrgInfo"/> from <see cref="LPOthLegalOrgInfoEntity"/> input.
        /// </summary>
        /// <param name="lPOthLegalOrgInfoEntity"><see cref="LPOthLegalOrgInfoEntity"/></param>
        /// <returns>Returns <see cref="LPOthLegalOrgInfo"/>, else null.</returns>
        public static LPOthLegalOrgInfo GetLPOthLegalOrgInfo(LPOthLegalOrgInfoEntity lPOthLegalOrgInfoEntity)
        {
            LPOthLegalOrgInfo lPOthLegalOrgInfo = null;

            try
            {
                if (lPOthLegalOrgInfoEntity != null)
                {
                    lPOthLegalOrgInfo = Mapper.Map<LPOthLegalOrgInfoEntity, LPOthLegalOrgInfo>(lPOthLegalOrgInfoEntity);
                    lPOthLegalOrgInfo.MAASOrganisationType = Mapper.Map<MAASOrganisationTypeEntity, MAASOrganisationType>(lPOthLegalOrgInfoEntity.MAASOrganisationType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLPOthLegalOrgInfo", ex);
                throw;
            }

            return lPOthLegalOrgInfo;
        }

        public static PaymentHRGDatesDocDetail GetPaymentHRGDatesDocDetail(PaymentHRGDatesDocDetailEntity paymentHRGDatesDocDetailEntity)
        {
            PaymentHRGDatesDocDetail paymentHRGDatesDocDetail = null;

            try
            {
                paymentHRGDatesDocDetail = Mapper.Map<PaymentHRGDatesDocDetailEntity, PaymentHRGDatesDocDetail>(paymentHRGDatesDocDetailEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPaymentHRGDatesDocDetail", ex);
                throw;
            }

            return paymentHRGDatesDocDetail;
        }

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
                paymentOutDocDetail.MCurrency = Mapper.Map<MCurrencyEntity, MCurrency>(paymentOutDocDetailEntity.MCurrency);
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
                paymentOutPayInDetail.MCourtType = Mapper.Map<MCourtTypeEntity, MCourtType>(paymentOutPayInDetailEntity.MCourtType);
                paymentOutPayInDetail.MCurrency = Mapper.Map<MCurrencyEntity, MCurrency>(paymentOutPayInDetailEntity.MCurrency);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPaymentOutPaymentInDetail", ex);
                throw;
            }

            return paymentOutPayInDetail;
        }

        /// <summary>
        /// Gets the <see cref="PCInfo"/> from <see cref="PCInfoEntity"/> input.
        /// </summary>
        /// <param name="pCInfoEntity"><see cref="PCInfoEntity"/></param>
        /// <returns>Returns <see cref="PCInfo"/>, else null.</returns>
        public static PCInfo GetPCInfo(PCInfoEntity pCInfoEntity)
        {
            PCInfo pCInfo = null;

            try
            {
                if (pCInfoEntity != null)
                {
                    pCInfo = Mapper.Map<PCInfoEntity, PCInfo>(pCInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPCInfo", ex);
                throw;
            }

            return pCInfo;
        }

        /// <summary>
        /// Gets the <see cref="RARASInfo"/> from <see cref="RARASInfoEntity"/> input.
        /// </summary>
        /// <param name="rARASInfoEntity"><see cref="RARASInfoEntity"/></param>
        /// <returns>Returns <see cref="RARASInfo"/>, else null.</returns>
        public static RARASInfo GetRARASInfo(RARASInfoEntity rARASInfoEntity)
        {
            RARASInfo rARASInfoNHibernateEntity = null;

            try
            {
                rARASInfoNHibernateEntity = Mapper.Map<RARASInfoEntity, RARASInfo>(rARASInfoEntity);
                rARASInfoNHibernateEntity.MDesignation = Mapper.Map<MDesignationEntity, MDesignation>(rARASInfoEntity.MDesignation);
                rARASInfoNHibernateEntity.MCoram = Mapper.Map<MCoramEntity, MCoram>(rARASInfoEntity.MCoram);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRARASInfo", ex);
                throw;
            }

            return rARASInfoNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="ServiceOfDocDocStatusHistory"/> from <see cref="ServiceOfDocDocStatusHistoryEntity"/> input.
        /// </summary>
        /// <param name="serviceOfDocDocStatusHistoryEntity"><see cref="ServiceOfDocDocStatusHistoryEntity"/></param>
        /// <returns>Returns <see cref="ServiceOfDocDocStatusHistory"/>, else null.</returns>
        public static ServiceOfDocDocStatusHistory GetServiceOfDocDocStatusHistory(ServiceOfDocDocStatusHistoryEntity serviceOfDocDocStatusHistoryEntity)
        {
            ServiceOfDocDocStatusHistory serviceOfDocDocStatusHistory = null;

            try
            {
                serviceOfDocDocStatusHistory = Mapper.Map<ServiceOfDocDocStatusHistoryEntity, ServiceOfDocDocStatusHistory>(serviceOfDocDocStatusHistoryEntity);
                serviceOfDocDocStatusHistory.MServeStatus = Mapper.Map<MServeStatusEntity, MServeStatus>(serviceOfDocDocStatusHistoryEntity.MServeStatus);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetServiceOfDocDocStatusHistory", ex);
                throw;
            }

            return serviceOfDocDocStatusHistory;
        }

        /// <summary>
        /// Gets the <see cref="ServiceOfDocDocument"/> from <see cref="ServiceOfDocDocumentEntity"/> input.
        /// </summary>
        /// <param name="serviceOfDocDocumentEntity"><see cref="ServiceOfDocDocumentEntity"/></param>
        /// <returns>Returns <see cref="ServiceOfDocDocument"/>, else null.</returns>
        public static ServiceOfDocDocument GetServiceOfDocDocument(ServiceOfDocDocumentEntity serviceOfDocDocumentEntity)
        {
            ServiceOfDocDocument serviceOfDocDocument = null;

            try
            {
                serviceOfDocDocument = Mapper.Map<ServiceOfDocDocumentEntity, ServiceOfDocDocument>(serviceOfDocDocumentEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetServiceOfDocDocument", ex);
                throw;
            }

            return serviceOfDocDocument;
        }

        /// <summary>
        /// Gets the <see cref="ServiceOfDocInfo"/> from <see cref="ServiceOfDocInfoEntity"/> input.
        /// </summary>
        /// <param name="serviceOfDocInfoEntity"><see cref="ServiceOfDocInfoEntity"/></param>
        /// <returns>Returns <see cref="ServiceOfDocInfo"/>, else null.</returns>
        public static ServiceOfDocInfo GetServiceOfDocInfo(ServiceOfDocInfoEntity serviceOfDocInfoEntity)
        {
            ServiceOfDocInfo serviceOfDocInfo = null;

            try
            {
                serviceOfDocInfo = Mapper.Map<ServiceOfDocInfoEntity, ServiceOfDocInfo>(serviceOfDocInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetServiceOfDocInfo", ex);
                throw;
            }

            return serviceOfDocInfo;
        }

        /// <summary>
        /// Gets the <see cref="ServiceOfDocInfoDetail"/> from <see cref="ServiceOfDocInfoDetailEntity"/> input.
        /// </summary>
        /// <param name="serviceOfDocInfoDetailEntity"><see cref="ServiceOfDocInfoDetailEntity"/></param>
        /// <returns>Returns <see cref="ServiceOfDocInfoDetail"/>, else null.</returns>
        public static ServiceOfDocInfoDetail GetServiceOfDocInfoDetail(ServiceOfDocInfoDetailEntity serviceOfDocInfoDetailEntity)
        {
            ServiceOfDocInfoDetail serviceOfDocInfoDetail = null;

            try
            {
                serviceOfDocInfoDetail = Mapper.Map<ServiceOfDocInfoDetailEntity, ServiceOfDocInfoDetail>(serviceOfDocInfoDetailEntity);
                serviceOfDocInfoDetail.MCountry = Mapper.Map<MCountryEntity, MCountry>(serviceOfDocInfoDetailEntity.MCountry);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetServiceOfDocInfoDetail", ex);
                throw;
            }

            return serviceOfDocInfoDetail;
        }

        /// <summary>
        /// Gets the <see cref="SetDownInfo"/> from <see cref="SetDownInfoEntity"/> input.
        /// </summary>
        /// <param name="setDownInfoEntity"><see cref="SetDownInfoEntity"/></param>
        /// <returns>Returns <see cref="SetDownInfo"/>, else null.</returns>
        public static SetDownInfo GetSetDownInfo(SetDownInfoEntity setDownInfoEntity)
        {
            SetDownInfo setDownInfo = null;

            try
            {
                if (setDownInfoEntity != null)
                {
                    setDownInfo = Mapper.Map<SetDownInfoEntity, SetDownInfo>(setDownInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSetDownInfo", ex);
                throw;
            }

            return setDownInfo;
        }

        public static ISubCaseSpecific GetSubCaseSpecific<T>(T subCaseSpecificEntity)
        {
            if (subCaseSpecificEntity.GetType().Equals(typeof(ADMWAInfoEntity)))
                return (SubCaseSpecificMapper.GetADMWAInfo(subCaseSpecificEntity as ADMWAInfoEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(PaymentInDocDetailEntity)))
                return (SubCaseSpecificMapper.GetPaymentInDocDetail(subCaseSpecificEntity as PaymentInDocDetailEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(PaymentInDocFSDetailEntity)))
                return (SubCaseSpecificMapper.GetPaymentInDocFSDetail(subCaseSpecificEntity as PaymentInDocFSDetailEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(PaymentOutDocDetailEntity)))
                return (SubCaseSpecificMapper.GetPaymentOutDocDetail(subCaseSpecificEntity as PaymentOutDocDetailEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(PaymentOutPayInDetailEntity)))
                return (SubCaseSpecificMapper.GetPaymentOutPaymentInDetail(subCaseSpecificEntity as PaymentOutPayInDetailEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(RARASInfoEntity)))
                return (SubCaseSpecificMapper.GetRARASInfo(subCaseSpecificEntity as RARASInfoEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(ServiceOfDocDocStatusHistoryEntity)))
                return (SubCaseSpecificMapper.GetServiceOfDocDocStatusHistory(subCaseSpecificEntity as ServiceOfDocDocStatusHistoryEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(ServiceOfDocDocumentEntity)))
                return (SubCaseSpecificMapper.GetServiceOfDocDocument(subCaseSpecificEntity as ServiceOfDocDocumentEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(ServiceOfDocInfoEntity)))
                return (SubCaseSpecificMapper.GetServiceOfDocInfo(subCaseSpecificEntity as ServiceOfDocInfoEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(ServiceOfDocInfoDetailEntity)))
                return (SubCaseSpecificMapper.GetServiceOfDocInfoDetail(subCaseSpecificEntity as ServiceOfDocInfoDetailEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(SetDownInfoEntity)))
                return (SubCaseSpecificMapper.GetSetDownInfo(subCaseSpecificEntity as SetDownInfoEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(NOCInfoEntity)))
                return (SubCaseSpecificMapper.GetNOCInfo(subCaseSpecificEntity as NOCInfoEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(PCInfoAccReportEntity)))
                return (SubCaseSpecificMapper.GetPCInfoAccReport(subCaseSpecificEntity as PCInfoAccReportEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(VoteInfoEntity)))
                return (SubCaseSpecificMapper.GetVoteInfo(subCaseSpecificEntity as VoteInfoEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(VoteInfoDeltaEntity)))
                return (SubCaseSpecificMapper.GetVoteInfoDelta(subCaseSpecificEntity as VoteInfoDeltaEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(DashboardSubCaseMilestoneDetailEntity)))
                return (SubCaseSpecificMapper.GetDashboardSubCaseMilestoneDetail(subCaseSpecificEntity as DashboardSubCaseMilestoneDetailEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(DashboardSubCaseMilestoneDetailHistoryEntity)))
                return (SubCaseSpecificMapper.GetDashboardSubCaseMilestoneDetailHistory(subCaseSpecificEntity as DashboardSubCaseMilestoneDetailHistoryEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(PCInfoEntity)))
                return (SubCaseSpecificMapper.GetPCInfo(subCaseSpecificEntity as PCInfoEntity));

            else if (subCaseSpecificEntity.GetType().Equals(typeof(AreaOfLegalPracticeEntity)))
                return (SubCaseSpecificMapper.GetAreaOfLegalPractice(subCaseSpecificEntity as AreaOfLegalPracticeEntity));

            else
                throw new ArgumentNullException("Invalid object sent.");
        }

        /// <summary>
        /// Gets the <see cref="SetDownInfo"/> from <see cref="SetDownInfoEntity"/> input.
        /// </summary>
        /// <param name="setDownInfoEntity"><see cref="SetDownInfoEntity"/></param>
        /// <returns>Returns <see cref="SetDownInfo"/>, else null.</returns>
        public static NOCInfo GetNOCInfo(NOCInfoEntity nOCInfoEntity)
        {
            NOCInfo nOCInfo = null;

            try
            {
                if (nOCInfoEntity != null)
                {
                    nOCInfo = Mapper.Map<NOCInfoEntity, NOCInfo>(nOCInfoEntity);
                    nOCInfo.MLawPracticeType = Mapper.Map<MLawPracticeTypeEntity, MLawPracticeType>(nOCInfoEntity.MLawPracticeTypeEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetNOCInfo", ex);
                throw;
            }

            return nOCInfo;
        }

        public static PCInfoAccReport GetPCInfoAccReport(PCInfoAccReportEntity PCInfoAccReportEntity)
        {
            PCInfoAccReport PCInfoAccReport = null;

            try
            {
                if (PCInfoAccReportEntity != null)
                {
                    PCInfoAccReport = Mapper.Map<PCInfoAccReportEntity, PCInfoAccReport>(PCInfoAccReportEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPCInfoAccReport", ex);
                throw;
            }

            return PCInfoAccReport;
        }

        /// <summary>
        /// Gets the <see cref="SetDownInfoEntity"/> from <see cref="SetDownInfo"/> input.
        /// </summary>
        /// <param name="setDownInfo"><see cref="SetDownInfo"/></param>
        /// <returns>Returns <see cref="SetDownInfoEntity"/>, else null.</returns>
        public static VoteInfo GetVoteInfo(VoteInfoEntity voteInfoEntity)
        {
            VoteInfo voteInfo = null;

            try
            {
                if (voteInfoEntity != null)
                {
                    voteInfo = Mapper.Map<VoteInfoEntity, VoteInfo>(voteInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetVoteInfo", ex);
                throw;
            }

            return voteInfo;
        }

        /// <summary>
        /// Gets the <see cref="SetDownInfoEntity"/> from <see cref="SetDownInfo"/> input.
        /// </summary>
        /// <param name="setDownInfo"><see cref="SetDownInfo"/></param>
        /// <returns>Returns <see cref="SetDownInfoEntity"/>, else null.</returns>
        public static VoteInfoDelta GetVoteInfoDelta(VoteInfoDeltaEntity voteInfoDeltaEntity)
        {
            VoteInfoDelta voteInfoDelta = null;

            try
            {
                if (voteInfoDeltaEntity != null)
                {
                    voteInfoDelta = Mapper.Map<VoteInfoDeltaEntity, VoteInfoDelta>(voteInfoDeltaEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetVoteInfo", ex);
                throw;
            }

            return voteInfoDelta;
        }

        public static DashboardSubCaseMilestoneDetail GetDashboardSubCaseMilestoneDetail(DashboardSubCaseMilestoneDetailEntity dashboardSubCaseMilestoneDetailEntity)
        {
            DashboardSubCaseMilestoneDetail dashboardSubCaseMilestoneDetail = null;
            try
            {
                if (dashboardSubCaseMilestoneDetailEntity != null)
                {
                    dashboardSubCaseMilestoneDetail = Mapper.Map<DashboardSubCaseMilestoneDetailEntity, DashboardSubCaseMilestoneDetail>(dashboardSubCaseMilestoneDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDashboardSubCaseMilestoneDetail", ex);
                throw;
            }
            return dashboardSubCaseMilestoneDetail;
        }

        public static DashboardSubCaseMilestoneDetailHistory GetDashboardSubCaseMilestoneDetailHistory(DashboardSubCaseMilestoneDetailHistoryEntity dashboardSubCaseMilestoneDetailHistoryEntity)
        {
            DashboardSubCaseMilestoneDetailHistory dashboardSubCaseMilestoneDetailHistory = null;
            try
            {
                if (dashboardSubCaseMilestoneDetailHistoryEntity != null)
                {
                    dashboardSubCaseMilestoneDetailHistory = Mapper.Map<DashboardSubCaseMilestoneDetailHistoryEntity, DashboardSubCaseMilestoneDetailHistory>(dashboardSubCaseMilestoneDetailHistoryEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDashboardSubCaseMilestoneDetailHistory", ex);
                throw;
            }
            return dashboardSubCaseMilestoneDetailHistory;
        }
        #endregion Methods
    }
}