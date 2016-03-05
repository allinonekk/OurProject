#region Header

/*****************************************************************************************************
* Description : This file handles mapper for Subsequent from Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/12/2010   		        Swaroop                  Created

*****************************************************************************************************/
// <summary>
// File: SubsequentMapper.cs
// Description: This file handles mapper for Subsequent from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "SubsequentMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Subsequent from Domain objects to NHibernate entities.
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
        /// Gets the <see cref="ADMRSVCBBInfo"/> from <see cref="ADMRSVCBBInfoEntity"/> input.
        /// </summary>
        /// <param name="aDMRSVCBBInfoEntity"><see cref="ADMRSVCBBInfoEntity"/></param>
        /// <returns>Returns <see cref="ADMRSVCBBInfo"/>, else null.</returns>
        public static ADMRSVCBBInfo GetADMRSVCBBInfo(ADMRSVCBBInfoEntity aDMRSVCBBInfoEntity)
        {
            ADMRSVCBBInfo aDMRSVCBBInfo = null;

            try
            {
                if (aDMRSVCBBInfoEntity != null)
                {
                    aDMRSVCBBInfo = Mapper.Map<ADMRSVCBBInfoEntity, ADMRSVCBBInfo>(aDMRSVCBBInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetADMRSVCBBInfo", ex);
                throw;
            }

            return aDMRSVCBBInfo;
        }

        /// <summary>
        /// Gets the <see cref="BillOfSaleSubInfo"/> from <see cref="BillOfSaleSubInfoEntity"/> input.
        /// </summary>
        /// <param name="billOfSaleSubInfoEntity"><see cref="BillOfSaleSubInfoEntity"/></param>
        /// <returns>Returns <see cref="BillOfSaleSubInfo"/>, else null.</returns>
        public static BillOfSaleSubInfo GetBillOfSaleSubInfo(BillOfSaleSubInfoEntity billOfSaleSubInfoEntity)
        {
            BillOfSaleSubInfo billOfSaleSubInfo = null;

            try
            {
                if (billOfSaleSubInfoEntity != null)
                {
                    billOfSaleSubInfo = Mapper.Map<BillOfSaleSubInfoEntity, BillOfSaleSubInfo>(billOfSaleSubInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBillOfSaleSubInfo", ex);
                throw;
            }

            return billOfSaleSubInfo;
        }

        /// <summary>
        /// Gets the <see cref="CDRInfo"/> from <see cref="cDRInfoEntity"/> input.
        /// </summary>
        /// <param name="cDRInfoEntity"><see cref="cDRInfoEntity"/></param>
        /// <returns>Returns <see cref="CDRInfo"/>, else null.</returns>
        public static CDRInfo GetCDRInfo(CDRInfoEntity cDRInfoEntity)
        {
            CDRInfo cDRInfo = null;

            try
            {
                cDRInfo = Mapper.Map<CDRInfoEntity, CDRInfo>(cDRInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCDRInfo", ex);
                throw;
            }

            return cDRInfo;
        }

        /// <summary>
        /// Gets the <see cref="DivorceSubInfo"/> from <see cref="DivorceSubInfoEntity"/> input.
        /// </summary>
        /// <param name="divorceSubInfoEntity"><see cref="DivorceSubInfoEntity"/></param>
        /// <returns>Returns <see cref="DivorceSubInfo"/>, else null.</returns>
        public static DivorceSubInfo GetDivorceSubInfo(DivorceSubInfoEntity divorceSubInfoEntity)
        {
            DivorceSubInfo divorceSubInfo = null;

            try
            {
                if (divorceSubInfoEntity != null)
                {
                    divorceSubInfo = Mapper.Map<DivorceSubInfoEntity, DivorceSubInfo>(divorceSubInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDivorceSubInfo", ex);
                throw;
            }

            return divorceSubInfo;
        }

        /// <summary>
        /// Gets the <see cref="DocRequestDetail"/> from <see cref="DocRequestDetailEntity"/> input.
        /// </summary>
        /// <param name="DocRequestDetailEntity"><see cref="DocRequestDetailEntity"/></param>
        /// <returns>Returns <see cref="DocRequestDetail"/>, else null.</returns>
        public static DocRequestDetail GetDocRequestDetail(DocRequestDetailEntity docRequestDetailEntity)
        {
            DocRequestDetail docRequestDetail = null;

            try
            {
                if (docRequestDetailEntity != null)
                {
                    docRequestDetail = Mapper.Map<DocRequestDetailEntity, DocRequestDetail>(docRequestDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocRequestDetail", ex);
                throw;
            }

            return docRequestDetail;
        }

        /// <summary>
        /// Gets the <see cref="PartyAmendmentDetail"/> from <see cref="PartyAmendmentDetailEntity"/> input.
        /// </summary>
        /// <param name="partyAmendmentDetailEntity"><see cref="PartyAmendmentDetailEntity"/></param>
        /// <returns>Returns <see cref="PartyAmendmentDetail"/>, else null.</returns>
        public static FileInspection GetFileInspection(FileInspectionEntity fileInspectionEntity)
        {
            FileInspection fileInspection = null;

            try
            {
                if (fileInspectionEntity != null)
                {
                    fileInspection = Mapper.Map<FileInspectionEntity, FileInspection>(fileInspectionEntity);
                    fileInspection.MCountry = Mapper.Map<MCountryEntity, MCountry>(fileInspectionEntity.MCountry);
                    fileInspection.MPersonIDType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(fileInspectionEntity.MPersonIDType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRequestDocDetail", ex);
                throw;
            }

            return fileInspection;
        }

        /// <summary>
        /// Gets the <see cref="FileInspectionDocDetail"/> from <see cref="FileInspectionDocDetailEntity"/> input.
        /// </summary>
        /// <param name="fileInspectionDocDetailEntity"><see cref="FileInspectionDocDetailEntity"/></param>
        /// <returns>Returns <see cref="FileInspectionDocDetail"/>, else null.</returns>
        public static FileInspectionDocDetail GetFileInspectionDocDetail(FileInspectionDocDetailEntity fileInspectionDocDetailEntity)
        {
            FileInspectionDocDetail fileInspectionDocDetail = null;

            try
            {
                if (fileInspectionDocDetailEntity != null)
                {
                    fileInspectionDocDetail = Mapper.Map<FileInspectionDocDetailEntity, FileInspectionDocDetail>(fileInspectionDocDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetFileInspectionDocDetail", ex);
                throw;
            }

            return fileInspectionDocDetail;
        }

        /// <summary>
        /// Gets the <see cref="FilingFeeRequestDetail"/> from <see cref="FilingFeeRequestDetailEntity"/> input.
        /// </summary>
        /// <param name="filingFeeRequestDetailEntity"><see cref="FilingFeeRequestDetailEntity"/></param>
        /// <returns>Returns <see cref="FilingFeeRequestDetail"/>, else null.</returns>
        public static FilingFeeRequestDetail GetFilingFeeRequestDetail(FilingFeeRequestDetailEntity filingFeeRequestDetailEntity)
        {
            FilingFeeRequestDetail filingFeeRequestDetail = null;

            try
            {
                if (filingFeeRequestDetailEntity != null)
                {
                    filingFeeRequestDetail = Mapper.Map<FilingFeeRequestDetailEntity, FilingFeeRequestDetail>(filingFeeRequestDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetFilingFeeRequestDetail", ex);
                throw;
            }

            return filingFeeRequestDetail;
        }

        /// <summary>
        /// Gets the <see cref="PartyAmendment"/> from <see cref="PartyAmendmentEntity"/> input.
        /// </summary>
        /// <param name="partyAmendmentEntity"><see cref="PartyAmendmentEntity"/></param>
        /// <returns>Returns <see cref="PartyAmendment"/>, else null.</returns>
        public static PartyAmendment GetPartyAmendment(PartyAmendmentEntity partyAmendmentEntity)
        {
            PartyAmendment partyAmendment = null;

            try
            {
                if (partyAmendmentEntity != null)
                {
                    partyAmendment = Mapper.Map<PartyAmendmentEntity, PartyAmendment>(partyAmendmentEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPartyAmendment", ex);
                throw;
            }

            return partyAmendment;
        }

        /// <summary>
        /// Gets the <see cref="PartyAmendmentDetail"/> from <see cref="PartyAmendmentDetailEntity"/> input.
        /// </summary>
        /// <param name="partyAmendmentDetailEntity"><see cref="PartyAmendmentDetailEntity"/></param>
        /// <returns>Returns <see cref="PartyAmendmentDetail"/>, else null.</returns>
        public static PartyAmendmentDetail GetPartyAmendmentDetail(PartyAmendmentDetailEntity partyAmendmentDetailEntity)
        {
            PartyAmendmentDetail partyAmendmentDetail = null;

            try
            {
                if (partyAmendmentDetailEntity != null)
                {
                    partyAmendmentDetail = Mapper.Map<PartyAmendmentDetailEntity, PartyAmendmentDetail>(partyAmendmentDetailEntity);
                } partyAmendmentDetail.MPartyAmendmentConfig = Mapper.Map<MPartyAmendmentConfigEntity, MPartyAmendmentConfig>(partyAmendmentDetailEntity.MPartyAmendmentConfig);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPartyAmendmentDetail", ex);
                throw;
            }

            return partyAmendmentDetail;
        }

        /// <summary>
        /// Gets the <see cref="PartyAmendmentDetail"/> from <see cref="PartyAmendmentDetailEntity"/> input.
        /// </summary>
        /// <param name="partyAmendmentDetailEntity"><see cref="PartyAmendmentDetailEntity"/></param>
        /// <returns>Returns <see cref="PartyAmendmentDetail"/>, else null.</returns>
        public static PartyAmendmentLeaveOfCourt GetPartyAmendmentLeaveOfCourt(PartyAmendmentLeaveOfCourtEntity partyAmendmentLeaveOfCourtEntity)
        {
            PartyAmendmentLeaveOfCourt partyAmendmentLeaveOfCourt = null;

            try
            {
                if (partyAmendmentLeaveOfCourtEntity != null)
                {
                    partyAmendmentLeaveOfCourt = Mapper.Map<PartyAmendmentLeaveOfCourtEntity, PartyAmendmentLeaveOfCourt>(partyAmendmentLeaveOfCourtEntity);
                    partyAmendmentLeaveOfCourt.MDesignation = Mapper.Map<MDesignationEntity, MDesignation>(partyAmendmentLeaveOfCourtEntity.MDesignation);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPartyAmendmentLeaveOfCourt", ex);
                throw;
            }

            return partyAmendmentLeaveOfCourt;
        }

        /// <summary>
        /// Gets the <see cref="RAccusedStatementInfo"/> from <see cref="RAccusedStatementInfoEntity"/> input.
        /// </summary>
        /// <param name="rAccusedStatementInfoEntity"><see cref="rAccusedStatementInfoEntity"/></param>
        /// <returns>Returns <see cref="RAccusedStatementInfo"/>, else null.</returns>
        public static RAccusedStatementInfo GetRAccusedStatementInfo(RAccusedStatementInfoEntity rAccusedStatementInfoEntity)
        {
            RAccusedStatementInfo rAccusedStatementInfo = null;

            try
            {
                if (rAccusedStatementInfoEntity != null)
                {
                    rAccusedStatementInfo = Mapper.Map<RAccusedStatementInfoEntity, RAccusedStatementInfo>(rAccusedStatementInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRAccusedStatementInfo", ex);
                throw;
            }

            return rAccusedStatementInfo;
        }

        /// <summary>
        /// Gets the <see cref="PartyAmendmentDetail"/> from <see cref="PartyAmendmentDetailEntity"/> input.
        /// </summary>
        /// <param name="partyAmendmentDetailEntity"><see cref="PartyAmendmentDetailEntity"/></param>
        /// <returns>Returns <see cref="PartyAmendmentDetail"/>, else null.</returns>
        public static RequestDocDetail GetRequestDocDetail(RequestDocDetailEntity requestDocDetailEntity)
        {
            RequestDocDetail requestDocDetail = null;

            try
            {
                if (requestDocDetailEntity != null)
                {
                    requestDocDetail = Mapper.Map<RequestDocDetailEntity, RequestDocDetail>(requestDocDetailEntity);
                    requestDocDetail.MFilingFee = Mapper.Map<MFilingFeeEntity, MFilingFee>(requestDocDetailEntity.MFilingFee);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRequestDocDetail", ex);
                throw;
            }

            return requestDocDetail;
        }

        /// <summary>
        /// Gets the <see cref="RequestHearingAdminSupport"/> from <see cref="RequestHearingAdminSupportEntity"/> input.
        /// </summary>
        /// <param name="requestHearingAdminSupportEntity"><see cref="requestHearingAdminSupportEntity"/></param>
        /// <returns>Returns <see cref="RequestHearingAdminSupport"/>, else null.</returns>
        public static RequestHearingAdminSupport GetRequestHearingAdminSupport(RequestHearingAdminSupportEntity requestHearingAdminSupportEntity)
        {
            RequestHearingAdminSupport requestHearingAdminSupport = null;

            try
            {
                if (requestHearingAdminSupportEntity != null)
                {
                    requestHearingAdminSupport = Mapper.Map<RequestHearingAdminSupportEntity, RequestHearingAdminSupport>(requestHearingAdminSupportEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRequestHearingAdminSupport", ex);
                throw;
            }

            return requestHearingAdminSupport;
        }

        /// <summary>
        /// Gets the <see cref="RequestHearingFeeDetail"/>
        /// </summary>
        /// <param name="requestHearingFeeDetailEntity">The RequestHearingFeeDetailEntity.</param>
        /// <returns></returns>
        public static RequestHearingFeeDetail GetRequestHearingFeeDetail(RequestHearingFeeDetailEntity requestHearingFeeDetailEntity)
        {
            RequestHearingFeeDetail requestHearingFeeDetail = null;
            try
            {
                requestHearingFeeDetail = Mapper.Map<RequestHearingFeeDetailEntity, RequestHearingFeeDetail>(requestHearingFeeDetailEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRequestHearingFeeDetail", ex);
                throw;
            }
            return requestHearingFeeDetail;
        }

        /// <summary>
        /// Gets the <see cref="RequestNEGDDetail"/> from <see cref="RequestNEGDDetailEntity"/> input.
        /// </summary>
        /// <param name="RequestNEGDDetailEntity"><see cref="RequestNEGDDetailEntity"/></param>
        /// <returns>Returns <see cref="RequestNEGDDetail"/>, else null.</returns>
        public static RequestNEGDDetail GetRequestNEGDDetail(RequestNEGDDetailEntity requestNEGDDetailEntity)
        {
            RequestNEGDDetail requestNEGDDetail = null;

            try
            {
                if (requestNEGDDetailEntity != null)
                {
                    requestNEGDDetail = Mapper.Map<RequestNEGDDetailEntity, RequestNEGDDetail>(requestNEGDDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRequestNEGDDetail", ex);
                throw;
            }

            return requestNEGDDetail;
        }

        /// <summary>
        /// Gets the <see cref="SubpoenaDocDetail"/> from <see cref="SubpoenaDocDetailEntity"/> input.
        /// </summary>
        /// <param name="SubpoenaDocDetailEntity"><see cref="SubpoenaDocDetailEntity"/></param>
        /// <returns>Returns <see cref="SubpoenaDocDetail"/>, else null.</returns>
        public static SubpoenaDocDetail GetSubpoenaDocDetail(SubpoenaDocDetailEntity subpoenaDocDetailEntity)
        {
            SubpoenaDocDetail subpoenaDocDetail = null;

            try
            {
                if (subpoenaDocDetailEntity != null)
                {
                    subpoenaDocDetail = Mapper.Map<SubpoenaDocDetailEntity, SubpoenaDocDetail>(subpoenaDocDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSubpoenaDocDetail", ex);
                throw;
            }

            return subpoenaDocDetail;
        }

        /// <summary>
        /// Gets the <see cref="FileInspectionDocDetail"/> from <see cref="FileInspectionDocDetailEntity"/> input.
        /// </summary>
        /// <param name="fileInspectionDocDetailEntity"><see cref="FileInspectionDocDetailEntity"/></param>
        /// <returns>Returns <see cref="FileInspectionDocDetail"/>, else null.</returns>
        public static SubpoenaInfo GetSubpoenaInfo(SubpoenaInfoEntity subpoenaInfoEntity)
        {
            SubpoenaInfo subpoenaInfo = null;

            try
            {
                if (subpoenaInfoEntity != null)
                {
                    subpoenaInfo = Mapper.Map<SubpoenaInfoEntity, SubpoenaInfo>(subpoenaInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSubpoenaInfo", ex);
                throw;
            }

            return subpoenaInfo;
        }

        /// <summary>
        /// Gets the <see cref="SubpoenaWitnessDetail"/> from <see cref="SubpoenaWitnessDetailEntity"/> input.
        /// </summary>
        /// <param name="SubpoenaWitnessDetailEntity"><see cref="SubpoenaWitnessDetailEntity"/></param>
        /// <returns>Returns <see cref="SubpoenaWitnessDetail"/>, else null.</returns>
        public static SubpoenaWitnessDetail GetSubpoenaWitnessDetail(SubpoenaWitnessDetailEntity subpoenaWitnessDetailEntity)
        {
            SubpoenaWitnessDetail subpoenaWitnessDetail = null;

            try
            {
                if (subpoenaWitnessDetailEntity != null)
                {
                    subpoenaWitnessDetail = Mapper.Map<SubpoenaWitnessDetailEntity, SubpoenaWitnessDetail>(subpoenaWitnessDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSubpoenaWitnessDetail", ex);
                throw;
            }

            return subpoenaWitnessDetail;
        }

        /// <summary>
        /// Method returns the <see cref="ISubsequent"/> tagged entity from <see cref="ISubsequentEntity"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="ISubsequentEntity"/> type</typeparam>
        /// <param name="subsequentEntity"><see cref="ISubsequentEntity"/> object.</param>
        /// <returns>Returns the <see cref="ISubsequent"/></returns>
        public static ISubsequent GetSubsequent<T>(T subsequentEntity)
        {
            try
            {
                if (subsequentEntity.GetType().Equals(typeof(PartyAmendmentEntity)))
                    return GetPartyAmendment(subsequentEntity as PartyAmendmentEntity);

                else if (subsequentEntity.GetType().Equals(typeof(ADMRSVCBBInfoEntity)))
                    return GetADMRSVCBBInfo(subsequentEntity as ADMRSVCBBInfoEntity);

                else if (subsequentEntity.GetType().Equals(typeof(PartyAmendmentDetailEntity)))
                    return GetPartyAmendmentDetail(subsequentEntity as PartyAmendmentDetailEntity);

                else if (subsequentEntity.GetType().Equals(typeof(PartyAmendmentLeaveOfCourtEntity)))
                    return GetPartyAmendmentLeaveOfCourt(subsequentEntity as PartyAmendmentLeaveOfCourtEntity);

                else if (subsequentEntity.GetType().Equals(typeof(RequestDocDetailEntity)))
                    return GetRequestDocDetail(subsequentEntity as RequestDocDetailEntity);

                else if (subsequentEntity.GetType().Equals(typeof(FileInspectionEntity)))
                    return GetFileInspection(subsequentEntity as FileInspectionEntity);

                else if (subsequentEntity.GetType().Equals(typeof(FileInspectionDocDetailEntity)))
                    return GetFileInspectionDocDetail(subsequentEntity as FileInspectionDocDetailEntity);

                else if (subsequentEntity.GetType().Equals(typeof(SubpoenaDocDetailEntity)))
                    return GetSubpoenaDocDetail(subsequentEntity as SubpoenaDocDetailEntity);

                else if (subsequentEntity.GetType().Equals(typeof(SubpoenaInfoEntity)))
                    return GetSubpoenaInfo(subsequentEntity as SubpoenaInfoEntity);

                else if (subsequentEntity.GetType().Equals(typeof(SubpoenaWitnessDetailEntity)))
                    return GetSubpoenaWitnessDetail(subsequentEntity as SubpoenaWitnessDetailEntity);

                else if (subsequentEntity.GetType().Equals(typeof(CDRInfoEntity)))
                    return GetCDRInfo(subsequentEntity as CDRInfoEntity);

                else if (subsequentEntity.GetType().Equals(typeof(VacHRGDatesReqInfoEntity)))
                    return GetVacHRGDatesReqInfo(subsequentEntity as VacHRGDatesReqInfoEntity);

                else if (subsequentEntity.GetType().Equals(typeof(DocRequestDetailEntity)))
                    return GetDocRequestDetail(subsequentEntity as DocRequestDetailEntity);

                else if (subsequentEntity.GetType().Equals(typeof(FilingFeeRequestDetailEntity)))
                    return GetFilingFeeRequestDetail(subsequentEntity as FilingFeeRequestDetailEntity);

                else if (subsequentEntity.GetType().Equals(typeof(RequestHearingAdminSupportEntity)))
                    return GetRequestHearingAdminSupport(subsequentEntity as RequestHearingAdminSupportEntity);

                else if (subsequentEntity.GetType().Equals(typeof(DivorceSubInfoEntity)))
                    return GetDivorceSubInfo(subsequentEntity as DivorceSubInfoEntity);

                else if (subsequentEntity.GetType().Equals(typeof(WOERequestEntity)))
                    return GetWOERequest(subsequentEntity as WOERequestEntity);

                else if (subsequentEntity.GetType().Equals(typeof(RequestHearingFeeDetailEntity)))
                    return GetRequestHearingFeeDetail(subsequentEntity as RequestHearingFeeDetailEntity);

                else if (subsequentEntity.GetType().Equals(typeof(WitnessInfoEntity)))
                    return GetWitnessInfo(subsequentEntity as WitnessInfoEntity);

                else if (subsequentEntity.GetType().Equals(typeof(RAccusedStatementInfoEntity)))
                    return GetRAccusedStatementInfo(subsequentEntity as RAccusedStatementInfoEntity);

                else if (subsequentEntity.GetType().Equals(typeof(WOEInfoEntity)))
                    return GetWOEInfo(subsequentEntity as WOEInfoEntity);

                else if (subsequentEntity.GetType().Equals(typeof(WOENCPEInfoEntity)))
                    return GetWOENCPEInfo(subsequentEntity as WOENCPEInfoEntity);

                else if (subsequentEntity.GetType().Equals(typeof(WOENECPEInfoEntity)))
                    return GetWOENECPEInfo(subsequentEntity as WOENECPEInfoEntity);

                else if (subsequentEntity.GetType().Equals(typeof(RequestNEGDDetailEntity)))
                    return GetRequestNEGDDetail(subsequentEntity as RequestNEGDDetailEntity);

                else if (subsequentEntity.GetType().Equals(typeof(PaymentHRGDatesDocDetailEntity)))
                    return GetPaymentHRGDatesDocDetail(subsequentEntity as PaymentHRGDatesDocDetailEntity);

                else
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetSubsequent method in SubsequentMapper.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSubsequent", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the <see cref="VacHRGDatesReqInfo"/> from <see cref="VacHRGDatesReqInfoEntity"/> input.
        /// </summary>
        /// <param name="vacHRGDatesReqInfoEntity"><see cref="VacHRGDatesReqInfoEntity"/></param>
        /// <returns>Returns <see cref="VacHRGDatesReqInfo"/>, else null.</returns>
        public static VacHRGDatesReqInfo GetVacHRGDatesReqInfo(VacHRGDatesReqInfoEntity vacHRGDatesReqInfoEntity)
        {
            VacHRGDatesReqInfo vacHRGDatesReqInfo = null;

            try
            {
                if (vacHRGDatesReqInfoEntity != null)
                {
                    vacHRGDatesReqInfo = Mapper.Map<VacHRGDatesReqInfoEntity, VacHRGDatesReqInfo>(vacHRGDatesReqInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetVacHRGDatesReqInfo", ex);
                throw;
            }

            return vacHRGDatesReqInfo;
        }

        /// <summary>
        /// Gets the <see cref="WitnessInfo"/> from <see cref="WitnessInfoEntity"/> input.
        /// </summary>
        /// <param name="witnessInfoEntity"><see cref="witnessInfoEntity"/></param>
        /// <returns>Returns <see cref="WitnessInfo"/>, else null.</returns>
        public static WitnessInfo GetWitnessInfo(WitnessInfoEntity witnessInfoEntity)
        {
            WitnessInfo witnessInfo = null;

            try
            {
                if (witnessInfoEntity != null)
                {
                    witnessInfo = Mapper.Map<WitnessInfoEntity, WitnessInfo>(witnessInfoEntity);
                    witnessInfo.IdCountryTypeCode = Mapper.Map<MCountryEntity, MCountry>(witnessInfoEntity.IdCountryTypeCode);
                    witnessInfo.IdGroupCode = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(witnessInfoEntity.IdGroupCode);
                    witnessInfo.IdTypeCode = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(witnessInfoEntity.IdTypeCode);
                    witnessInfo.WitnessType = Mapper.Map<MCriminalClaimantTypeEntity, MCriminalClaimantType>(witnessInfoEntity.WitnessType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetWitnessInfo", ex);
                throw;
            }

            return witnessInfo;
        }

        /// <summary>
        /// Gets the <see cref="WOEInfo"/>
        /// </summary>
        /// <param name="woeInfoEntity">The WOEInfoEntity.</param>
        /// <returns></returns>
        public static WOEInfo GetWOEInfo(WOEInfoEntity woeInfoEntity)
        {
            WOEInfo woeInfo = null;
            try
            {
                woeInfo = Mapper.Map<WOEInfoEntity, WOEInfo>(woeInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOEInfo", ex);
                throw;
            }
            return woeInfo;
        }

        /// <summary>
        /// Gets the <see cref="WOENCPEInfo"/>
        /// </summary>
        /// <param name="woeNCPEInfoEntity">The WOENCPEInfoEntity.</param>
        /// <returns></returns>
        public static WOENCPEInfo GetWOENCPEInfo(WOENCPEInfoEntity woeNCPEInfoEntity)
        {
            WOENCPEInfo woeNCPEInfo = null;
            try
            {
                woeNCPEInfo = Mapper.Map<WOENCPEInfoEntity, WOENCPEInfo>(woeNCPEInfoEntity);
                woeNCPEInfo.CurrencyCode = Mapper.Map<MCurrencyEntity, MCurrency>(woeNCPEInfoEntity.CurrencyCode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOENCPEInfo", ex);
                throw;
            }
            return woeNCPEInfo;
        }

        /// <summary>
        /// Gets the <see cref="WOENECPEInfo"/>
        /// </summary>
        /// <param name="woeNECPEInfoEntity">The WOENECPEInfoEntity.</param>
        /// <returns></returns>
        public static WOENECPEInfo GetWOENECPEInfo(WOENECPEInfoEntity woeNECPEInfoEntity)
        {
            WOENECPEInfo woeNECPEInfo = null;
            try
            {
                woeNECPEInfo = Mapper.Map<WOENECPEInfoEntity, WOENECPEInfo>(woeNECPEInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOENECPEInfo", ex);
                throw;
            }
            return woeNECPEInfo;
        }

        /// <summary>
        /// Gets the <see cref="WOERequest"/>
        /// </summary>
        /// <param name="woeRequestEntity">The WOERequestEntity.</param>
        /// <returns></returns>
        public static WOERequest GetWOERequest(WOERequestEntity woeRequestEntity)
        {
            WOERequest woeRequest = null;
            try
            {
                woeRequest = Mapper.Map<WOERequestEntity, WOERequest>(woeRequestEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOERequest", ex);
                throw;
            }
            return woeRequest;
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

        #endregion Methods
    }
}