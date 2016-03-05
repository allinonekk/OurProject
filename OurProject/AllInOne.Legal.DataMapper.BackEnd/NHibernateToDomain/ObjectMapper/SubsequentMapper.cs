#region Header

/*****************************************************************************************************
* Description : This file handles mapper for Subsequent from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   27/01/2011   		        Nithin                  Created
*****************************************************************************************************/
// <summary>
// File: SubsequentMapper.cs
// Description: This file handles mapper for Subsequent from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "SubsequentMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Subsequent from NHibernate entities to Domain objects.
    /// </summary>
    public class SubsequentMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SubsequentMapper));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the <see cref="ADMBBDefInfoEntity"/> from <see cref="ADMBBDefInfo"/> input.
        /// </summary>
        /// <param name="aDMBBDefInfo"><see cref="ADMBBDefInfo"/></param>
        /// <returns>Returns <see cref="ADMBBDefInfoEntity"/>, else null.</returns>
        public static ADMBBDefInfoEntity GetADMBBDefInfoEntity(ADMBBDefInfo aDMBBDefInfo)
        {
            ADMBBDefInfoEntity aDMBBDefInfoEntity = null;

            try
            {
                if (aDMBBDefInfo != null)
                {
                    aDMBBDefInfoEntity = Mapper.Map<ADMBBDefInfo, ADMBBDefInfoEntity>(aDMBBDefInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetADMBBDefInfoEntity", ex);
                throw;
            }

            return aDMBBDefInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="ADMBBSecInfoEntity"/> from <see cref="ADMBBSecInfo"/> input.
        /// </summary>
        /// <param name="aDMBBSecInfo"><see cref="ADMBBSecInfo"/></param>
        /// <returns>Returns <see cref="ADMBBSecInfoEntity"/>, else null.</returns>
        public static ADMBBSecInfoEntity GetADMBBSecInfoEntity(ADMBBSecInfo aDMBBSecInfo)
        {
            ADMBBSecInfoEntity aDMBBSecInfoEntity = null;

            try
            {
                if (aDMBBSecInfo != null)
                {
                    aDMBBSecInfoEntity = Mapper.Map<ADMBBSecInfo, ADMBBSecInfoEntity>(aDMBBSecInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetADMBBSecInfo", ex);
                throw;
            }

            return aDMBBSecInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="ADMRSVCBBInfoEntity"/> from <see cref="ADMRSVCBBInfo"/> input.
        /// </summary>
        /// <param name="aDMRSVCBBInfo"><see cref="ADMRSVCBBInfo"/></param>
        /// <returns>Returns <see cref="ADMRSVCBBInfoEntity"/>, else null.</returns>
        public static ADMRSVCBBInfoEntity GetADMRSVCBBInfoEntity(ADMRSVCBBInfo aDMRSVCBBInfo)
        {
            ADMRSVCBBInfoEntity aDMRSVCBBInfoEntity = null;

            try
            {
                if (aDMRSVCBBInfo != null)
                {
                    aDMRSVCBBInfoEntity = Mapper.Map<ADMRSVCBBInfo, ADMRSVCBBInfoEntity>(aDMRSVCBBInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetADMRSVCBBInfoEntity", ex);
                throw;
            }

            return aDMRSVCBBInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="BillOfSaleSubInfoEntity"/> from <see cref="BillOfSaleSubInfo"/> input.
        /// </summary>
        /// <param name="billOfSaleSubInfo"><see cref="BillOfSaleSubInfo"/></param>
        /// <returns>Returns <see cref="BillOfSaleSubInfoEntity"/>, else null.</returns>
        public static BillOfSaleSubInfoEntity GetBillOfSaleSubInfoEntity(BillOfSaleSubInfo billOfSaleSubInfo)
        {
            BillOfSaleSubInfoEntity billOfSaleSubInfoEntity = null;

            try
            {
                if (billOfSaleSubInfo != null)
                {
                    billOfSaleSubInfoEntity = Mapper.Map<BillOfSaleSubInfo, BillOfSaleSubInfoEntity>(billOfSaleSubInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBillOfSaleSubInfoEntity", ex);
                throw;
            }

            return billOfSaleSubInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CDRInfoEntity"/> from <see cref="CDRInfo"/> input.
        /// </summary>
        /// <param name="cDRInfo"><see cref="CDRInfo"/></param>
        /// <returns>Returns <see cref="CDRInfoEntity"/>, else null.</returns>
        public static CDRInfoEntity GetCDRInfoEntity(CDRInfo cDRInfo)
        {
            CDRInfoEntity cDRInfoEntity = null;

            try
            {
                if (cDRInfo != null)
                {
                    cDRInfoEntity = Mapper.Map<CDRInfo, CDRInfoEntity>(cDRInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCDRInfoEntity", ex);
                throw;
            }

            return cDRInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="FilingFeeRequestDetail"/> from <see cref="FilingFeeRequestDetailEntity"/> input.
        /// </summary>
        /// <param name="filingFeeRequestDetailEntity"><see cref="FilingFeeRequestDetailEntity"/></param>
        /// <returns>Returns <see cref="FilingFeeRequestDetail"/>, else null.</returns>
        public static DisWithDocPtyDetailEntity GetDisWithDocPtyDetailEntity(DisWithDocPtyDetail disWithDocPtyDetail)
        {
            DisWithDocPtyDetailEntity disWithDocPtyDetailEntity = null;

            try
            {
                if (disWithDocPtyDetail != null)
                {
                    disWithDocPtyDetailEntity = Mapper.Map<DisWithDocPtyDetail, DisWithDocPtyDetailEntity>(disWithDocPtyDetail);
                    disWithDocPtyDetailEntity.MWithDrawalInTypeEntity = Mapper.Map<MWithDrawalInType, MWithDrawalInTypeEntity>(disWithDocPtyDetail.MWithDrawalInType);
                    disWithDocPtyDetailEntity.MWithDrawalOfTypeEntity = Mapper.Map<MWithDrawalOfType, MWithDrawalOfTypeEntity>(disWithDocPtyDetail.MWithdrawalOfType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDisWithDocPtyDetailEntity", ex);
                throw;
            }

            return disWithDocPtyDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="DivorceSubInfoEntity"/> from <see cref="DivorceSubInfo"/> input.
        /// </summary>
        /// <param name="divorceSubInfo"><see cref="DivorceSubInfo"/></param>
        /// <returns>Returns <see cref="DivorceSubInfoEntity"/>, else null.</returns>
        public static DivorceSubInfoEntity GetDivorceSubInfoEntity(DivorceSubInfo divorceSubInfo)
        {
            DivorceSubInfoEntity divorceSubInfoEntity = null;

            try
            {
                if (divorceSubInfo != null)
                {
                    divorceSubInfoEntity = Mapper.Map<DivorceSubInfo, DivorceSubInfoEntity>(divorceSubInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDivorceSubInfoEntity", ex);
                throw;
            }

            return divorceSubInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocRequestDetailEntity"/> from <see cref="DocRequestDetail"/> input.
        /// </summary>
        /// <param name="docRequestDetail"><see cref="DocRequestDetail"/></param>
        /// <returns>Returns <see cref="DocRequestDetailEntity"/>, else null.</returns>
        public static DocRequestDetailEntity GetDocRequestDetailEntity(DocRequestDetail docRequestDetail)
        {
            DocRequestDetailEntity docRequestDetailEntity = null;

            try
            {
                if (docRequestDetail != null)
                {
                    docRequestDetailEntity = Mapper.Map<DocRequestDetail, DocRequestDetailEntity>(docRequestDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocRequestDetailEntity", ex);
                throw;
            }

            return docRequestDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="FileInspectionDocDetailEntity"/> from <see cref="FileInspectionDocDetail"/> input.
        /// </summary>
        /// <param name="fileInspectionDocDetail"><see cref="FileInspectionDocDetail"/></param>
        /// <returns>Returns <see cref="FileInspectionDocDetailEntity"/>, else null.</returns>
        public static FileInspectionDocDetailEntity GetFileInspectionDocDetailEntity(FileInspectionDocDetail fileInspectionDocDetail)
        {
            FileInspectionDocDetailEntity fileInspectionDocDetailEntity = null;

            try
            {
                if (fileInspectionDocDetail != null)
                {
                    fileInspectionDocDetailEntity = Mapper.Map<FileInspectionDocDetail, FileInspectionDocDetailEntity>(fileInspectionDocDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetFileInspectionDocDetailEntity", ex);
                throw;
            }

            return fileInspectionDocDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="FileInspectionEntity"/> from <see cref="FileInspection"/> input.
        /// </summary>
        /// <param name="fileInspection"><see cref="FileInspection"/></param>
        /// <returns>Returns <see cref="FileInspectionEntity"/>, else null.</returns>
        public static FileInspectionEntity GetFileInspectionEntity(FileInspection fileInspection)
        {
            FileInspectionEntity fileInspectionEntity = null;

            try
            {
                if (fileInspection != null)
                {
                    fileInspectionEntity = Mapper.Map<FileInspection, FileInspectionEntity>(fileInspection);
                    fileInspectionEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(fileInspection.MCountry);
                    fileInspectionEntity.MPersonIDType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(fileInspection.MPersonIDType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetFileInspectionEntity", ex);
                throw;
            }

            return fileInspectionEntity;
        }

        /// <summary>
        /// Gets the <see cref="FilingFeeRequestDetail"/> from <see cref="FilingFeeRequestDetailEntity"/> input.
        /// </summary>
        /// <param name="filingFeeRequestDetailEntity"><see cref="FilingFeeRequestDetailEntity"/></param>
        /// <returns>Returns <see cref="FilingFeeRequestDetail"/>, else null.</returns>
        public static FilingFeeRequestDetailEntity GetFilingFeeRequestDetailEntity(FilingFeeRequestDetail filingFeeRequestDetail)
        {
            FilingFeeRequestDetailEntity filingFeeRequestDetailEntity = null;

            try
            {
                if (filingFeeRequestDetail != null)
                {
                    filingFeeRequestDetailEntity = Mapper.Map<FilingFeeRequestDetail, FilingFeeRequestDetailEntity>(filingFeeRequestDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetFilingFeeRequestDetailEntity", ex);
                throw;
            }

            return filingFeeRequestDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="PartyAmendmentDetailEntity"/> from <see cref="PartyAmendmentDetail"/> input.
        /// </summary>
        /// <param name="partyAmendmentDetailEntity"><see cref="PartyAmendmentDetail"/></param>
        /// <returns>Returns <see cref="PartyAmendmentDetailEntity"/>, else null.</returns>
        public static PartyAmendmentDetailEntity GetPartyAmendmentDetailEntity(PartyAmendmentDetail partyAmendmentDetail)
        {
            PartyAmendmentDetailEntity partyAmendmentDetailEntity = null;

            try
            {
                if (partyAmendmentDetail != null)
                {
                    partyAmendmentDetailEntity = Mapper.Map<PartyAmendmentDetail, PartyAmendmentDetailEntity>(partyAmendmentDetail);
                    partyAmendmentDetailEntity.MPartyAmendmentConfig = Mapper.Map<MPartyAmendmentConfig, MPartyAmendmentConfigEntity>(partyAmendmentDetail.MPartyAmendmentConfig);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPartyAmendmentDetailEntity", ex);
                throw;
            }

            return partyAmendmentDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="PartyAmendmentEntity"/> from <see cref="PartyAmendment"/> input.
        /// </summary>
        /// <param name="partyAmendment"><see cref="PartyAmendment"/></param>
        /// <returns>Returns <see cref="PartyAmendmentEntity"/>, else null.</returns>
        public static PartyAmendmentEntity GetPartyAmendmentEntity(PartyAmendment partyAmendment)
        {
            PartyAmendmentEntity partyAmendmentEntity = null;

            try
            {
                if (partyAmendment != null)
                {
                    partyAmendmentEntity = Mapper.Map<PartyAmendment, PartyAmendmentEntity>(partyAmendment);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetpartyAmendmentEntity", ex);
                throw;
            }

            return partyAmendmentEntity;
        }

        /// <summary>
        /// Gets the <see cref="PartyAmendmentLeaveOfCourtEntity"/> from <see cref="PartyAmendmentLeaveOfCourt"/> input.
        /// </summary>
        /// <param name="partyAmendmentLeaveOfCourt"><see cref="PartyAmendmentLeaveOfCourt"/></param>
        /// <returns>Returns <see cref="PartyAmendmentLeaveOfCourtEntity"/>, else null.</returns>
        public static PartyAmendmentLeaveOfCourtEntity GetPartyAmendmentLeaveOfCourtEntity(PartyAmendmentLeaveOfCourt partyAmendmentLeaveOfCourt)
        {
            PartyAmendmentLeaveOfCourtEntity partyAmendmentLeaveOfCourtEntity = null;

            try
            {
                if (partyAmendmentLeaveOfCourt != null)
                {
                    partyAmendmentLeaveOfCourtEntity = Mapper.Map<PartyAmendmentLeaveOfCourt, PartyAmendmentLeaveOfCourtEntity>(partyAmendmentLeaveOfCourt);
                    partyAmendmentLeaveOfCourtEntity.MDesignation = Mapper.Map<MDesignation, MDesignationEntity>(partyAmendmentLeaveOfCourt.MDesignation);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPartyAmendmentLeaveOfCourtEntity", ex);
                throw;
            }

            return partyAmendmentLeaveOfCourtEntity;
        }

        /// <summary>
        /// Gets the <see cref="PaymentHRGDatesDocDetailEntity"/> from <see cref="PaymentHRGDatesDocDetail"/> input.
        /// </summary>
        /// <param name="paymentHRGDatesDocDetail"><see cref="PaymentHRGDatesDocDetail"/></param>
        /// <returns>Returns <see cref="PaymentHRGDatesDocDetailEntity"/>, else null.</returns>
        public static PaymentHRGDatesDocDetailEntity GetPaymentHRGDatesDocDetailEntity(PaymentHRGDatesDocDetail paymentHRGDatesDocDetail)
        {
            PaymentHRGDatesDocDetailEntity paymentHRGDatesDocDetailEntity = null;

            try
            {
                if (paymentHRGDatesDocDetail != null)
                {
                    paymentHRGDatesDocDetailEntity = Mapper.Map<PaymentHRGDatesDocDetail, PaymentHRGDatesDocDetailEntity>(paymentHRGDatesDocDetail);
                    paymentHRGDatesDocDetailEntity.MHRGBeforeType = Mapper.Map<MHRGBeforeType, MHRGBeforeTypeEntity>(paymentHRGDatesDocDetail.MHRGBeforeType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPaymentHRGDatesDocDetailEntity", ex);
                throw;
            }

            return paymentHRGDatesDocDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="RAccusedStatementInfo"/> from <see cref="RAccusedStatementInfoEntity"/> 
        /// </summary>
        /// <param name="rAccusedStatementInfo"><see cref="RAccusedStatementInfo"/></param>
        /// <returns>Returns <see cref="RAccusedStatementInfoEntity"/>, else null.</returns>
        public static RAccusedStatementInfoEntity GetRAccusedStatementInfoEntity(RAccusedStatementInfo rAccusedStatementInfo)
        {
            RAccusedStatementInfoEntity rAccusedStatementInfoEntity = null;

            try
            {
                if (rAccusedStatementInfo != null)
                {
                    rAccusedStatementInfoEntity = Mapper.Map<RAccusedStatementInfo, RAccusedStatementInfoEntity>(rAccusedStatementInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRAccusedStatementInfoEntity", ex);
                throw;
            }

            return rAccusedStatementInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="RequestDocDetailEntity"/> from <see cref="RequestDocDetail"/> input.
        /// </summary>
        /// <param name="requestDocDetail"><see cref="RequestDocDetail"/></param>
        /// <returns>Returns <see cref="RequestDocDetailEntity"/>, else null.</returns>
        public static RequestDocDetailEntity GetRequestDocDetailEntity(RequestDocDetail requestDocDetail)
        {
            RequestDocDetailEntity requestDocDetailEntity = null;

            try
            {
                if (requestDocDetail != null)
                {
                    requestDocDetailEntity = Mapper.Map<RequestDocDetail, RequestDocDetailEntity>(requestDocDetail);
                    requestDocDetailEntity.MFilingFee = Mapper.Map<MFilingFee, MFilingFeeEntity>(requestDocDetail.MFilingFee);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRequestDocDetailEntity", ex);
                throw;
            }

            return requestDocDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="RequestHearingAdminSupport"/> from <see cref="RequestHearingAdminSupportEntity"/> 
        /// </summary>
        /// <param name="requestHearingAdminSupport"><see cref="RequestHearingAdminSupport"/></param>
        /// <returns>Returns <see cref="RequestHearingAdminSupportEntity"/>, else null.</returns>
        public static RequestHearingAdminSupportEntity GetRequestHearingAdminSupportEntity(RequestHearingAdminSupport requestHearingAdminSupport)
        {
            RequestHearingAdminSupportEntity requestHearingAdminSupportEntity = null;

            try
            {
                if (requestHearingAdminSupport != null)
                {
                    requestHearingAdminSupportEntity = Mapper.Map<RequestHearingAdminSupport, RequestHearingAdminSupportEntity>(requestHearingAdminSupport);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRequestHearingAdminSupportEntity", ex);
                throw;
            }

            return requestHearingAdminSupportEntity;
        }

        /// <summary>
        /// Gets the <see cref="RequestNEGDDetailEntity"/> from <see cref="RequestNEGDDetail"/> input.
        /// </summary>
        /// <param name="requestNEGDDetail"><see cref="RequestNEGDDetail"/></param>
        /// <returns>Returns <see cref="RequestNEGDDetailEntity"/>, else null.</returns>
        public static RequestNEGDDetailEntity GetRequestNEGDDetail(RequestNEGDDetail requestNEGDDetail)
        {
            RequestNEGDDetailEntity requestNEGDDetailEntity = null;

            try
            {
                if (requestNEGDDetail != null)
                {
                    requestNEGDDetailEntity = Mapper.Map<RequestNEGDDetail, RequestNEGDDetailEntity>(requestNEGDDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRequestNEGDDetail", ex);
                throw;
            }

            return requestNEGDDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="SubpoenaDocDetailEntity"/> from <see cref="SubpoenaDocDetail"/> input.
        /// </summary>
        /// <param name="subpoenaDocDetail"><see cref="SubpoenaDocDetail"/></param>
        /// <returns>Returns <see cref="SubpoenaDocDetailEntity"/>, else null.</returns>
        public static SubpoenaDocDetailEntity GetSubpoenaDocDetailEntity(SubpoenaDocDetail subpoenaDocDetail)
        {
            SubpoenaDocDetailEntity subpoenaDocDetailEntity = null;

            try
            {
                if (subpoenaDocDetail != null)
                {
                    subpoenaDocDetailEntity = Mapper.Map<SubpoenaDocDetail, SubpoenaDocDetailEntity>(subpoenaDocDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSubpoenaDocDetailEntity", ex);
                throw;
            }

            return subpoenaDocDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="SubpoenaInfoEntity"/> from <see cref="SubpoenaInfo"/> input.
        /// </summary>
        /// <param name="subpoenaInfo"><see cref="SubpoenaInfo"/></param>
        /// <returns>Returns <see cref="SubpoenaInfoEntity"/>, else null.</returns>
        public static SubpoenaInfoEntity GetSubpoenaInfoEntity(SubpoenaInfo subpoenaInfo)
        {
            SubpoenaInfoEntity subpoenaInfoEntity = null;

            try
            {
                if (subpoenaInfo != null)
                {
                    subpoenaInfoEntity = Mapper.Map<SubpoenaInfo, SubpoenaInfoEntity>(subpoenaInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSubpoenaInfoEntity", ex);
                throw;
            }

            return subpoenaInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="SubpoenaWitnessDetailEntity"/> from <see cref="SubpoenaWitnessDetail"/> input.
        /// </summary>
        /// <param name="subpoenaWitnessDetail"><see cref="SubpoenaWitnessDetail"/></param>
        /// <returns>Returns <see cref="SubpoenaWitnessDetailEntity"/>, else null.</returns>
        public static SubpoenaWitnessDetailEntity GetSubpoenaWitnessDetailEntity(SubpoenaWitnessDetail subpoenaWitnessDetail)
        {
            SubpoenaWitnessDetailEntity subpoenaWitnessDetailEntity = null;

            try
            {
                if (subpoenaWitnessDetail != null)
                {
                    subpoenaWitnessDetailEntity = Mapper.Map<SubpoenaWitnessDetail, SubpoenaWitnessDetailEntity>(subpoenaWitnessDetail);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSubpoenaWitnessDetailEntity", ex);
                throw;
            }

            return subpoenaWitnessDetailEntity;
        }

        /// <summary>
        /// Method returns the <see cref="ISubsequentEntity"/> tagged entity from <see cref="ISubsequentEntity"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="ISubsequentEntity"/> type</typeparam>
        /// <param name="subsequentEntity"><see cref="ISubsequentEntity"/> object.</param>
        /// <returns>Returns the <see cref="ISubsequentEntity"/></returns>
        public static ISubsequentEntity GetSubsequentEntity<T>(T subsequentEntity)
        {
            try
            {
                if (subsequentEntity.GetType().Equals(typeof(ADMBBDefInfo)))
                    return (GetADMBBDefInfoEntity(subsequentEntity as ADMBBDefInfo));

                else if (subsequentEntity.GetType().Equals(typeof(ADMBBSecInfo)))
                    return (GetADMBBSecInfoEntity(subsequentEntity as ADMBBSecInfo));

                else if (subsequentEntity.GetType().Equals(typeof(ADMRSVCBBInfo)))
                    return (GetADMRSVCBBInfoEntity(subsequentEntity as ADMRSVCBBInfo));

                else if (subsequentEntity.GetType().Equals(typeof(BillOfSaleSubInfo)))
                    return (GetBillOfSaleSubInfoEntity(subsequentEntity as BillOfSaleSubInfo));

                else if (subsequentEntity.GetType().Equals(typeof(CDRInfo)))
                    return (GetCDRInfoEntity(subsequentEntity as CDRInfo));

                else if (subsequentEntity.GetType().Equals(typeof(PaymentHRGDatesDocDetail)))
                    return (GetPaymentHRGDatesDocDetailEntity(subsequentEntity as PaymentHRGDatesDocDetail));

                else if (subsequentEntity.GetType().Equals(typeof(VacHRGDatesReqInfo)))
                    return (GetVacHRGDatesReqInfoEntity(subsequentEntity as VacHRGDatesReqInfo));

                else if (subsequentEntity.GetType().Equals(typeof(DisWithDocPtyDetail)))
                    return (GetDisWithDocPtyDetailEntity(subsequentEntity as DisWithDocPtyDetail));

                else if (subsequentEntity.GetType().Equals(typeof(DivorceSubInfo)))
                    return (GetDivorceSubInfoEntity(subsequentEntity as DivorceSubInfo));

                else if (subsequentEntity.GetType().Equals(typeof(WOERequest)))
                    return (GetWOERequestEntity(subsequentEntity as WOERequest));

                else if (subsequentEntity.GetType().Equals(typeof(WOEInfo)))
                    return GetWOEInfoEntity(subsequentEntity as WOEInfo);

                else if (subsequentEntity.GetType().Equals(typeof(WOENCPEInfo)))
                    return GetWOENCPEInfoEntity(subsequentEntity as WOENCPEInfo);

                else if (subsequentEntity.GetType().Equals(typeof(WOENECPEInfo)))
                    return GetWOENECPEInfoEntity(subsequentEntity as WOENECPEInfo);

                else if (subsequentEntity.GetType().Equals(typeof(RequestHearingFeeDetail)))
                    return GetRequestHearingFeeDetailEntity(subsequentEntity as RequestHearingFeeDetail);

                else
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetSubsequentEntity method in SubsequentMapper.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSubsequentEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the <see cref="VacHRGDatesReqInfoEntity"/> from <see cref="VacHRGDatesReqInfo"/> input.
        /// </summary>
        /// <param name="vacHRGDatesReqInfo"><see cref="VacHRGDatesReqInfo"/></param>
        /// <returns>Returns <see cref="VacHRGDatesReqInfoEntity"/>, else null.</returns>
        public static VacHRGDatesReqInfoEntity GetVacHRGDatesReqInfoEntity(VacHRGDatesReqInfo vacHRGDatesReqInfo)
        {
            VacHRGDatesReqInfoEntity vacHRGDatesReqInfoEntity = null;

            try
            {
                if (vacHRGDatesReqInfo != null)
                {
                    vacHRGDatesReqInfoEntity = Mapper.Map<VacHRGDatesReqInfo, VacHRGDatesReqInfoEntity>(vacHRGDatesReqInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetVacHRGDatesReqInfoEntity", ex);
                throw;
            }

            return vacHRGDatesReqInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="WitnessInfo"/> from <see cref="WitnessInfoEntity"/> 
        /// </summary>
        /// <param name="witnessInfo"><see cref="WitnessInfo"/></param>
        /// <returns>Returns <see cref="WitnessInfoEntity"/>, else null.</returns>
        public static WitnessInfoEntity GetWitnessInfoEntity(WitnessInfo witnessInfo)
        {
            WitnessInfoEntity witnessInfoEntity = null;

            try
            {
                if (witnessInfo != null)
                {
                    witnessInfoEntity = Mapper.Map<WitnessInfo, WitnessInfoEntity>(witnessInfo);
                    witnessInfoEntity.IdCountryTypeCode = Mapper.Map<MCountry, MCountryEntity>(witnessInfo.IdCountryTypeCode);
                    witnessInfoEntity.IdGroupCode = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(witnessInfo.IdGroupCode);
                    witnessInfoEntity.IdTypeCode = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(witnessInfo.IdTypeCode);
                    witnessInfoEntity.WitnessType = Mapper.Map<MCriminalClaimantType, MCriminalClaimantTypeEntity>(witnessInfo.WitnessType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetWitnessInfoEntity", ex);
                throw;
            }

            return witnessInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="WOEInfoEntity"/>
        /// </summary>
        /// <param name="woeInfo">The WOEInfo.</param>
        /// <returns></returns>
        public static WOEInfoEntity GetWOEInfoEntity(WOEInfo woeInfo)
        {
            WOEInfoEntity woeInfoEntity = null;
            try
            {
                woeInfoEntity = Mapper.Map<WOEInfo, WOEInfoEntity>(woeInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOEInfoEntity", ex);
                throw;
            }
            return woeInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="WOENCPEInfoEntity"/>
        /// </summary>
        /// <param name="woeNCPEInfo">The WOENCPEInfo.</param>
        /// <returns></returns>
        public static WOENCPEInfoEntity GetWOENCPEInfoEntity(WOENCPEInfo woeNCPEInfo)
        {
            WOENCPEInfoEntity woeNCPEInfoEntity = null;
            try
            {
                woeNCPEInfoEntity = Mapper.Map<WOENCPEInfo, WOENCPEInfoEntity>(woeNCPEInfo);
                woeNCPEInfoEntity.CurrencyCode = Mapper.Map<MCurrency, MCurrencyEntity>(woeNCPEInfo.CurrencyCode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOENCPEInfoEntity", ex);
                throw;
            }
            return woeNCPEInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="WOENECPEInfoEntity"/>
        /// </summary>
        /// <param name="woeNECPEInfo">The WOENECPEInfo.</param>
        /// <returns></returns>
        public static WOENECPEInfoEntity GetWOENECPEInfoEntity(WOENECPEInfo woeNECPEInfo)
        {
            WOENECPEInfoEntity woeNECPEInfoEntity = null;
            try
            {
                woeNECPEInfoEntity = Mapper.Map<WOENECPEInfo, WOENECPEInfoEntity>(woeNECPEInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOENECPEInfoEntity", ex);
                throw;
            }
            return woeNECPEInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="WOERequestEntity"/>
        /// </summary>
        /// <param name="woeRequest">The WOERequest.</param>
        /// <returns></returns>
        public static WOERequestEntity GetWOERequestEntity(WOERequest woeRequest)
        {
            WOERequestEntity woeRequestEntity = null;
            try
            {
                woeRequestEntity = Mapper.Map<WOERequest, WOERequestEntity>(woeRequest);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOERequestEntity", ex);
                throw;
            }
            return woeRequestEntity;
        }

        public static RequestHearingFeeDetailEntity GetRequestHearingFeeDetailEntity(RequestHearingFeeDetail requestHearingFeeDetail)
        {
            RequestHearingFeeDetailEntity requestHearingFeeDetailEntity = null;
            try
            {
                requestHearingFeeDetailEntity = Mapper.Map<RequestHearingFeeDetail, RequestHearingFeeDetailEntity>(requestHearingFeeDetail);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRequestHearingFeeDetailEntity", ex);
                throw;
            }
            return requestHearingFeeDetailEntity;
        }

        #endregion Methods
    }
}