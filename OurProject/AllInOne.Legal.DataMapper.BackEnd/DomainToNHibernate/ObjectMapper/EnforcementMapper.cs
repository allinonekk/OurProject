#region Header

/*****************************************************************************************************
* Description : This file represents a object to object mapping for Enforcement entities.
* This class will map the DTO to Domain Entitiy.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   01/11/2010   		      Nai                	 	Created
*
*****************************************************************************************************/
// <summary>
// File: EnforcementMapper.cs
// Description: his file represents a object to object mapping for Enforcement entities.
// </summary>
// <copyright file= "EnforcementMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Enforcement;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    public class EnforcementMapperToDomain
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(EnforcementMapperToDomain));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Map and get EMSAccount E.
        /// </summary>
        /// <param name="eMSAccountDTO"></param>
        /// <returns></returns>
        public static EMSAccount GetEMSAccount(EMSAccountEntity eMSAccountDTO)
        {
            EMSAccount eMSAccountDomain = null;

            try
            {
                eMSAccountDomain = Mapper.Map<EMSAccountEntity, EMSAccount>(eMSAccountDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAccountDomain;
        }

        ///// <summary>
        ///// Map and get EMSAdmCharge.
        ///// </summary>
        ///// <param name="eMSAdmChargeDTO"></param>
        ///// <returns></returns>
        //public static EMSAdmCharge GetEMSAdmCharge(EMSAdmChargeEntity eMSAdmChargeDTO)
        //{
        //    EMSAdmCharge eMSAdmChargeDomain = null;

        //    try
        //    {
        //        eMSAdmChargeDomain = Mapper.Map<EMSAdmChargeEntity, EMSAdmCharge>(eMSAdmChargeDTO);
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
        //        throw;
        //    }

        //    return eMSAdmChargeDomain;
        //}

        /// <summary>
        /// Map and get EMSAdmCharges.
        /// </summary>
        /// <param name="eMSAdmChargesDTO"></param>
        /// <returns></returns>
        public static EMSAdmCharges GetEMSAdmCharges(EMSAdmChargesEntity eMSAdmChargesDTO)
        {
            EMSAdmCharges eMSAdmChargesDomain = null;

            try
            {
                eMSAdmChargesDomain = Mapper.Map<EMSAdmChargesEntity, EMSAdmCharges>(eMSAdmChargesDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAdmChargesDomain;
        }

        /// <summary>
        /// Map and get EMSAttendanceFee.
        /// </summary>
        /// <param name="eMSAttendanceFeeDTO"></param>
        /// <returns></returns>
        public static EMSAttendanceFee GetEMSAttendanceFee(EMSAttendanceFeeEntity eMSAttendanceFeeDTO)
        {
            EMSAttendanceFee eMSAttendanceFeeDomain = null;

            try
            {
                eMSAttendanceFeeDomain = Mapper.Map<EMSAttendanceFeeEntity, EMSAttendanceFee>(eMSAttendanceFeeDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAttendanceFeeDomain;
        }

        /// <summary>
        /// Map and get EMSAdmClaim.
        /// </summary>
        /// <param name="eMSAdmClaimDTO"></param>
        /// <returns></returns>
        public static EMSAdmClaim GetEMSAdmClaim(EMSAdmClaimEntity eMSAdmClaimDTO)
        {
            EMSAdmClaim eMSAdmClaimDomain = null;

            try
            {
                eMSAdmClaimDomain = Mapper.Map<EMSAdmClaimEntity, EMSAdmClaim>(eMSAdmClaimDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAdmClaimDomain;
        }

        /// <summary>
        /// Map and get EMSAdmExec.
        /// </summary>
        /// <param name="eMSAdmExecDTO"></param>
        /// <returns></returns>
        public static EMSAdmExec GetEMSAdmExec(EMSAdmExecEntity eMSAdmExecDTO)
        {
            EMSAdmExec eMSAdmExecDomain = null;

            try
            {
                eMSAdmExecDomain = Mapper.Map<EMSAdmExecEntity, EMSAdmExec>(eMSAdmExecDTO);
                eMSAdmExecDomain.MEMSSecurityGuard = Mapper.Map<MEMSSecurityGuardEntity, MEMSSecurityGuard>(eMSAdmExecDTO.MEMSSecurityGuard);
                eMSAdmExecDomain.MEMSADMExecLocation = Mapper.Map<MEMSADMExecLocationEntity, MEMSADMExecLocation>(eMSAdmExecDTO.MEMSADMExecLocation);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAdmExecDomain;
        }

        /// <summary>
        /// Map and get EMSAdmProperty.
        /// </summary>
        /// <param name="eMSAdmPropertyDTO"></param>
        /// <returns></returns>
        public static EMSAdmProperty GetEMSAdmProperty(EMSAdmPropertyEntity eMSAdmPropertyDTO)
        {
            EMSAdmProperty eMSAdmPropertycDomain = null;

            try
            {
                eMSAdmPropertycDomain = Mapper.Map<EMSAdmPropertyEntity, EMSAdmProperty>(eMSAdmPropertyDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAdmPropertycDomain;
        }

        /// <summary>
        /// Map and get EMSAdmPropertyList.
        /// </summary>
        /// <param name="eMSAdmPropertyListDTO"></param>
        /// <returns></returns>
        public static EMSAdmPropertyList GetEMSAdmPropertyList(EMSAdmPropertyListEntity eMSAdmPropertyListDTO)
        {
            EMSAdmPropertyList eMSAdmPropertyListcDomain = null;

            try
            {
                eMSAdmPropertyListcDomain = Mapper.Map<EMSAdmPropertyListEntity, EMSAdmPropertyList>(eMSAdmPropertyListDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAdmPropertyListcDomain;
        }

        /// <summary>
        /// Map and get EMSAdmRelease.
        /// </summary>
        /// <param name="eMSAdmReleaseDTO"></param>
        /// <returns></returns>
        public static EMSAdmRelease GetEMSAdmRelease(EMSAdmReleaseEntity eMSAdmReleaseDTO)
        {
            EMSAdmRelease eMSAdmReleaseDomain = null;

            try
            {
                eMSAdmReleaseDomain = Mapper.Map<EMSAdmReleaseEntity, EMSAdmRelease>(eMSAdmReleaseDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAdmReleaseDomain;
        }

        /// <summary>
        /// Map and get EMSADMSaleOthers E.
        /// </summary>
        /// <param name="eMSADMSaleOthersDTO"></param>
        /// <returns></returns>
        public static EMSADMSaleOthers GetEMSADMSaleOthers(EMSADMSaleOthersEntity eMSADMSaleOthersDTO)
        {
            EMSADMSaleOthers eMSADMSaleOthersDomain = null;

            try
            {
                eMSADMSaleOthersDomain = Mapper.Map<EMSADMSaleOthersEntity, EMSADMSaleOthers>(eMSADMSaleOthersDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSADMSaleOthersDomain;
        }

        /// <summary>
        /// Map and get EMSAppointment.
        /// </summary>
        /// <param name="eMSAppointmentDTO"></param>
        /// <returns></returns>
        public static EMSAppointment GetEMSAppointment(EMSAppointmentEntity eMSAppointmentDTO)
        {
            EMSAppointment eMSAppointmentDomain = null;

            try
            {
                eMSAppointmentDomain = Mapper.Map<EMSAppointmentEntity, EMSAppointment>(eMSAppointmentDTO);
                eMSAppointmentDomain.MEMSApptOutcome = Mapper.Map<MEMSApptOutcomeEntity, MEMSApptOutcome>(eMSAppointmentDTO.MEMSApptOutcome);
                eMSAppointmentDomain.MEMSApptReason = Mapper.Map<MEMSApptReasonEntity, MEMSApptReason>(eMSAppointmentDTO.MEMSApptReason);
                eMSAppointmentDomain.MEMSApptType = Mapper.Map<MEMSApptTypeEntity, MEMSApptType>(eMSAppointmentDTO.MEMSApptType);
                eMSAppointmentDomain.MEMSAuctioneer = Mapper.Map<MEMSAuctioneerEntity, MEMSAuctioneer>(eMSAppointmentDTO.MEMSAuctioneer);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAppointmentDomain;
        }

        /// <summary>
        /// Map and get EMSApptDateTime.
        /// </summary>
        /// <param name="eMSApptDateTimeDTO"></param>
        /// <returns></returns>
        public static EMSApptDateTime GetEMSApptDateTime(EMSApptDateTimeEntity eMSApptDateTimeDTO)
        {
            EMSApptDateTime eMSApptDateTimeDomain = null;

            try
            {
                eMSApptDateTimeDomain = Mapper.Map<EMSApptDateTimeEntity, EMSApptDateTime>(eMSApptDateTimeDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSApptDateTimeDomain;
        }

        /// <summary>
        /// Map and get EMSApptDebtor.
        /// </summary>
        /// <param name="eMSApptDebtorDTO"></param>
        /// <returns></returns>
        public static EMSApptDebtor GetEMSApptDebtor(EMSApptDebtorEntity eMSApptDebtorDTO)
        {
            EMSApptDebtor eMSApptDebtorDomain = null;

            try
            {
                eMSApptDebtorDomain = Mapper.Map<EMSApptDebtorEntity, EMSApptDebtor>(eMSApptDebtorDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSApptDebtorDomain;
        }

        /// <summary>
        /// Map and get EMSCashBookItem.
        /// </summary>
        /// <param name="EMSCashBookItem"></param>
        /// <returns></returns>
        public static EMSCashBookItem GetEMSCashBookItem(EMSCashBookItemEntity eMSCashBookItemDTO)
        {
            EMSCashBookItem eMSCashBookItemDomain = null;

            try
            {
                eMSCashBookItemDomain = Mapper.Map<EMSCashBookItemEntity, EMSCashBookItem>(eMSCashBookItemDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCashBookItemDomain;
        }

        /// <summary>
        /// Map and get EMSCashBookItem.
        /// </summary>
        /// <param name="EMSCashBookItem"></param>
        /// <returns></returns>
        public static EMSCashBookReconcile GetEMSCashBookReconcile(EMSCashBookReconcileEntity eMSCashBookReconcileDTO)
        {
            EMSCashBookReconcile eMSCashBookReconcileDomain = null;

            try
            {
                eMSCashBookReconcileDomain = Mapper.Map<EMSCashBookReconcileEntity, EMSCashBookReconcile>(eMSCashBookReconcileDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCashBookReconcileDomain;
        }

        /// <summary>
        /// Map and get EMSCheque.
        /// </summary>
        /// <param name="EMSCheque"></param>
        /// <returns></returns>
        public static EMSCheque GetEMSCheque(EMSChequeEntity eMSChequeDTO)
        {
            EMSCheque eMSChequeDomain = null;

            try
            {
                eMSChequeDomain = Mapper.Map<EMSChequeEntity, EMSCheque>(eMSChequeDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSChequeDomain;
        }

        /// <summary>
        /// Map and get EMSChequeHistory.
        /// </summary>
        /// <param name="EMSChequeHistory"></param>
        /// <returns></returns>
        public static EMSChequeHistory GetEMSChequeHistory(EMSChequeHistoryEntity eMSChequeHistoryDTO)
        {
            EMSChequeHistory eMSChequeHistoryDomain = null;

            try
            {
                eMSChequeHistoryDomain = Mapper.Map<EMSChequeHistoryEntity, EMSChequeHistory>(eMSChequeHistoryDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSChequeHistoryDomain;
        }

        /// <summary>
        /// Map and get EMSCivCaseAbort.
        /// </summary>
        /// <param name="eMSCivCaseAbortDTO"></param>
        /// <returns></returns>
        public static EMSCivCaseAbort GetEMSCivCaseAbort(EMSCivCaseAbortEntity eMSCivCaseAbortDTO)
        {
            EMSCivCaseAbort eMSCivCaseAbortDomain = null;

            try
            {
                eMSCivCaseAbortDomain = Mapper.Map<EMSCivCaseAbortEntity, EMSCivCaseAbort>(eMSCivCaseAbortDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCivCaseAbortDomain;
        }

        /// <summary>
        /// Map and get EMSCivCrmMissing.
        /// </summary>
        /// <param name="eMSCivCrmMissingDTO"></param>
        /// <returns></returns>
        public static EMSCivCrmMissing GetEMSCivCrmMissing(EMSCivCrmMissingEntity eMSCivCrmMissingDTO)
        {
            EMSCivCrmMissing eMSCivCrmMissingDomain = null;

            try
            {
                eMSCivCrmMissingDomain = Mapper.Map<EMSCivCrmMissingEntity, EMSCivCrmMissing>(eMSCivCrmMissingDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCivCrmMissingDomain;
        }

        /// <summary>
        /// Map and get EMSCivCrmRelease.
        /// </summary>
        /// <param name="eMSCivCrmReleaseDTO"></param>
        /// <returns></returns>
        public static EMSCivCrmRelease GetEMSCivCrmRelease(EMSCivCrmReleaseEntity eMSCivCrmReleaseDTO)
        {
            EMSCivCrmRelease eMSCivCrmReleaseDomain = null;

            try
            {
                eMSCivCrmReleaseDomain = Mapper.Map<EMSCivCrmReleaseEntity, EMSCivCrmRelease>(eMSCivCrmReleaseDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCivCrmReleaseDomain;
        }

        /// <summary>
        /// Map and get EMSCivCrmSeizure.
        /// </summary>
        /// <param name="eMSCivCrmSeizureDTO"></param>
        /// <returns></returns>
        public static EMSCivCrmSeizure GetEMSCivCrmSeizure(EMSCivCrmSeizureEntity eMSCivCrmSeizureDTO)
        {
            EMSCivCrmSeizure eMSCivCrmSeizureDomain = null;

            try
            {
                eMSCivCrmSeizureDomain = Mapper.Map<EMSCivCrmSeizureEntity, EMSCivCrmSeizure>(eMSCivCrmSeizureDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCivCrmSeizureDomain;
        }

        /// <summary>
        /// Map and get EMSCivCrmSettlement.
        /// </summary>
        /// <param name="eMSCivCrmSettlementDTO"></param>
        /// <returns></returns>
        public static EMSCivCrmSettlement GetEMSCivCrmSettlement(EMSCivCrmSettlementEntity eMSCivCrmSettlementDTO)
        {
            EMSCivCrmSettlement eMSCivCrmSettlementDomain = null;

            try
            {
                eMSCivCrmSettlementDomain = Mapper.Map<EMSCivCrmSettlementEntity, EMSCivCrmSettlement>(eMSCivCrmSettlementDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCivCrmSettlementDomain;
        }

        /// <summary>
        /// Map and get EMSCourtCommission.
        /// </summary>
        /// <param name="eMSCourtCommissionDTO"></param>
        /// <returns></returns>
        public static EMSCourtCommission GetEMSCourtCommissionEntity(EMSCourtCommissionEntity eMSCourtCommissionDTO)
        {
            EMSCourtCommission eMSCourtCommissionDomain = null;

            try
            {
                eMSCourtCommissionDomain = Mapper.Map<EMSCourtCommissionEntity, EMSCourtCommission>(eMSCourtCommissionDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCourtCommissionDomain;
        }

        /// <summary>
        /// Map and get EMSCrmCase.
        /// </summary>
        /// <param name="eMSCrmCaseDTO"></param>
        /// <returns></returns>
        public static EMSCrmCase GetEMSCrmCase(EMSCrmCaseEntity eMSCrmCaseDTO)
        {
            EMSCrmCase eMSCrmCaseDomain = null;

            try
            {
                eMSCrmCaseDomain = Mapper.Map<EMSCrmCaseEntity, EMSCrmCase>(eMSCrmCaseDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCrmCaseDomain;
        }

        /// <summary>
        /// Map and get EMSCrmCaseExecAddr.
        /// </summary>
        /// <param name="eMSCrmCaseExecAddrDTO"></param>
        /// <returns></returns>
        public static EMSCrmCaseExecAddr GetEMSCrmCaseExecAddr(EMSCrmCaseExecAddrEntity eMSCrmCaseExecAddrDTO)
        {
            EMSCrmCaseExecAddr eMSCrmCaseExecAddrDomain = null;

            try
            {
                eMSCrmCaseExecAddrDomain = Mapper.Map<EMSCrmCaseExecAddrEntity, EMSCrmCaseExecAddr>(eMSCrmCaseExecAddrDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCrmCaseExecAddrDomain;
        }

        /// <summary>
        /// Map and get EMSCrmCaseWLDet.
        /// </summary>
        /// <param name="eMSCrmCaseWLDetDTO"></param>
        /// <returns></returns>
        public static EMSCrmCaseWLDet GetEMSCrmCaseWLDet(EMSCrmCaseWLDetEntity eMSCrmCaseWLDetDTO)
        {
            EMSCrmCaseWLDet eMSCrmCaseWLDetDomain = null;

            try
            {
                eMSCrmCaseWLDetDomain = Mapper.Map<EMSCrmCaseWLDetEntity, EMSCrmCaseWLDet>(eMSCrmCaseWLDetDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCrmCaseWLDetDomain;
        }

        /// <summary>
        /// Map and get EMSDisburseClaim.
        /// </summary>
        /// <param name="eMSDisburseClaimDTO"></param>
        /// <returns></returns>
        public static EMSDisburseClaim GetEMSDisburseClaim(EMSDisburseClaimEntity eMSDisburseClaimDTO)
        {
            EMSDisburseClaim eMSDisburseClaimDomain = null;

            try
            {
                eMSDisburseClaimDomain = Mapper.Map<EMSDisburseClaimEntity, EMSDisburseClaim>(eMSDisburseClaimDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSDisburseClaimDomain;
        }

        /// <summary>
        /// Map and get EMSExecLedger.
        /// </summary>
        /// <param name="eMSExecLedgerDTO"></param>
        /// <returns></returns>
        public static EMSExecLedger GetEMSExecLedger(EMSExecLedgerEntity eMSExecLedgerDTO)
        {
            EMSExecLedger eMSExecLedgerDomain = null;

            try
            {
                eMSExecLedgerDomain = Mapper.Map<EMSExecLedgerEntity, EMSExecLedger>(eMSExecLedgerDTO);
                eMSExecLedgerDomain.MEMSLedger = Mapper.Map<MEMSLedgerEntity, MEMSLedger>(eMSExecLedgerDTO.MEMSLedger);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSExecLedgerDomain;
        }

        /// <summary>
        /// Map and get EMSFileMovement.
        /// </summary>
        /// <param name="EMSFileMovementDTO"></param>
        /// <returns></returns>
        public static EMSFileMovement GetEMSFileMovement(EMSFileMovementEntity eMSFileMovementDTO)
        {
            EMSFileMovement eMSFileMovementDomain = null;

            try
            {
                eMSFileMovementDomain = Mapper.Map<EMSFileMovementEntity, EMSFileMovement>(eMSFileMovementDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSFileMovementDomain;
        }

        /// <summary>
        /// Map and get EMSMiscClaim.
        /// </summary>
        /// <param name="EMSMiscClaimDTO"></param>
        /// <returns></returns>
        public static EMSMiscClaim GetEMSMiscClaim(EMSMiscClaimEntity eMSMiscClaimDTO)
        {
            EMSMiscClaim eMSMiscClaimDomain = null;

            try
            {
                eMSMiscClaimDomain = Mapper.Map<EMSMiscClaimEntity, EMSMiscClaim>(eMSMiscClaimDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSMiscClaimDomain;
        }

        /// <summary>
        /// Map and get EMSOutstandingPayment.
        /// </summary>
        /// <param name="EMSOutstandingPaymentDTO"></param>
        /// <returns></returns>
        public static EMSOutstandingPayment GetEMSOutstandingPayment(EMSOutstandingPaymentEntity eMSOutstandingPaymentDTO)
        {
            EMSOutstandingPayment eMSOutstandingPaymentDomain = null;

            try
            {
                eMSOutstandingPaymentDomain = Mapper.Map<EMSOutstandingPaymentEntity, EMSOutstandingPayment>(eMSOutstandingPaymentDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSOutstandingPaymentDomain;
        }

        /// <summary>
        /// Map and get EMSPayment.
        /// </summary>
        /// <param name="EMSPaymentDTO"></param>
        /// <returns></returns>
        public static EMSPayment GetEMSPayment(EMSPaymentEntity eMSPaymentDTO)
        {
            EMSPayment eMSPaymentDomain = null;

            try
            {
                eMSPaymentDomain = Mapper.Map<EMSPaymentEntity, EMSPayment>(eMSPaymentDTO);
                eMSPaymentDomain.MEMSLedger = Mapper.Map<MEMSLedgerEntity, MEMSLedger>(eMSPaymentDTO.MEMSLedger);
                eMSPaymentDomain.MEMSNatureOfPayment = Mapper.Map<MEMSNatureOfPaymentEntity, MEMSNatureOfPayment>(eMSPaymentDTO.MEMSNatureOfPayment);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentDomain;
        }

        /// <summary>
        /// Map and get EMSPaymentCheque.
        /// </summary>
        /// <param name="EMSPaymentCheque"></param>
        /// <returns></returns>
        public static EMSPaymentCheque GetEMSPaymentCheque(EMSPaymentChequeEntity eMSPaymentChequeDTO)
        {
            EMSPaymentCheque eMSPaymentChequeDomain = null;

            try
            {
                eMSPaymentChequeDomain = Mapper.Map<EMSPaymentChequeEntity, EMSPaymentCheque>(eMSPaymentChequeDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentChequeDomain;
        }

        /// <summary>
        /// Map and get EMSPaymentVoucher.
        /// </summary>
        /// <param name="EMSPaymentVoucherDTO"></param>
        /// <returns></returns>
        public static EMSPaymentVoucher GetEMSPaymentVoucher(EMSPaymentVoucherEntity eMSPaymentVoucherDTO)
        {
            EMSPaymentVoucher eMSPaymentVoucherDomain = null;

            try
            {
                eMSPaymentVoucherDomain = Mapper.Map<EMSPaymentVoucherEntity, EMSPaymentVoucher>(eMSPaymentVoucherDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentVoucherDomain;
        }

        /// <summary>
        /// Map and get EMSPaymentVoucherAdm.
        /// </summary>
        /// <param name="EMSPaymentVoucherAdmDTO"></param>
        /// <returns></returns>
        public static EMSPaymentVoucherAdm GetEMSPaymentVoucherAdm(EMSPaymentVoucherAdmEntity eMSPaymentVoucherAdmDTO)
        {
            EMSPaymentVoucherAdm eMSPaymentVoucherAdmDomain = null;

            try
            {
                eMSPaymentVoucherAdmDomain = Mapper.Map<EMSPaymentVoucherAdmEntity, EMSPaymentVoucherAdm>(eMSPaymentVoucherAdmDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentVoucherAdmDomain;
        }

        /// <summary>
        /// Map and get EMSPaymentVoucherCheque.
        /// </summary>
        /// <param name="EMSPaymentVoucherChequeDTO"></param>
        /// <returns></returns>
        public static EMSPaymentVoucherCheque GetEMSPaymentVoucherCheque(EMSPaymentVoucherChequeEntity eMSPaymentVoucherChequeDTO)
        {
            EMSPaymentVoucherCheque eMSPaymentVoucherChequeDomain = null;

            try
            {
                eMSPaymentVoucherChequeDomain = Mapper.Map<EMSPaymentVoucherChequeEntity, EMSPaymentVoucherCheque>(eMSPaymentVoucherChequeDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentVoucherChequeDomain;
        }

        /// <summary>
        /// Map and get EMSPaymentVoucherFinal.
        /// </summary>
        /// <param name="EMSPaymentVoucherFinalDTO"></param>
        /// <returns></returns>
        public static EMSPaymentVoucherFinal GetEMSPaymentVoucherFinal(EMSPaymentVoucherFinalEntity eMSPaymentVoucherFinalDTO)
        {
            EMSPaymentVoucherFinal eMSPaymentVoucherFinalDomain = null;

            try
            {
                eMSPaymentVoucherFinalDomain = Mapper.Map<EMSPaymentVoucherFinalEntity, EMSPaymentVoucherFinal>(eMSPaymentVoucherFinalDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentVoucherFinalDomain;
        }

        /// <summary>
        /// Map and get EMSPaymentVoucherFinalOther.
        /// </summary>
        /// <param name="EMSPaymentVoucherFinalOtherDTO"></param>
        /// <returns></returns>
        public static EMSPaymentVoucherFinalOther GetEMSPaymentVoucherFinalOther(EMSPaymentVoucherFinalOtherEntity eMSPaymentVoucherFinalOtherDTO)
        {
            EMSPaymentVoucherFinalOther eMSPaymentVoucherFinalOtherDomain = null;

            try
            {
                eMSPaymentVoucherFinalOtherDomain = Mapper.Map<EMSPaymentVoucherFinalOtherEntity, EMSPaymentVoucherFinalOther>(eMSPaymentVoucherFinalOtherDTO);
                eMSPaymentVoucherFinalOtherDomain.MEMSNatureOfPayment = Mapper.Map<MEMSNatureOfPaymentEntity, MEMSNatureOfPayment>(eMSPaymentVoucherFinalOtherDTO.MEMSNatureOfPayment);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentVoucherFinalOtherDomain;
        }

        /// <summary>
        /// Map and get EMSPaymentVoucherMisc.
        /// </summary>
        /// <param name="EMSPaymentVoucherMiscDTO"></param>
        /// <returns></returns>
        public static EMSPaymentVoucherMisc GetEMSPaymentVoucherMisc(EMSPaymentVoucherMiscEntity eMSPaymentVoucherMiscDTO)
        {
            EMSPaymentVoucherMisc eMSPaymentVoucherMiscDomain = null;

            try
            {
                eMSPaymentVoucherMiscDomain = Mapper.Map<EMSPaymentVoucherMiscEntity, EMSPaymentVoucherMisc>(eMSPaymentVoucherMiscDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentVoucherMiscDomain;
        }

        /// <summary>
        /// Map and get EMSRecapitDetails.
        /// </summary>
        /// <param name="EMSRecapitDetailsDTO"></param>
        /// <returns></returns>
        public static EMSRecapitDetails GetEMSRecapitDetails(EMSRecapitDetailsEntity eMSRecapitDetailsDTO)
        {
            EMSRecapitDetails eMSRecapitDetailsDomain = null;

            try
            {
                eMSRecapitDetailsDomain = Mapper.Map<EMSRecapitDetailsEntity, EMSRecapitDetails>(eMSRecapitDetailsDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSRecapitDetailsDomain;
        }

        /// <summary>
        /// Map and get EMSRecapitulation.
        /// </summary>
        /// <param name="EMSRecapitulationDTO"></param>
        /// <returns></returns>
        public static EMSRecapitulation GetEMSRecapitulation(EMSRecapitulationEntity eMSRecapitulationDTO)
        {
            EMSRecapitulation eMSRecapitulationDomain = null;

            try
            {
                eMSRecapitulationDomain = Mapper.Map<EMSRecapitulationEntity, EMSRecapitulation>(eMSRecapitulationDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSRecapitulationDomain;
        }

        /// <summary>
        /// Map and get EMSRecAudit.
        /// </summary>
        /// <param name="EMSRecAuditDTO"></param>
        /// <returns></returns>
        public static EMSRecAudit GetEMSRecAudit(EMSRecAuditEntity eMSRecAuditDTO)
        {
            EMSRecAudit eMSRecAuditDomain = null;

            try
            {
                eMSRecAuditDomain = Mapper.Map<EMSRecAuditEntity, EMSRecAudit>(eMSRecAuditDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSRecAuditDomain;
        }

        /// <summary>
        /// Map and get EMSRecChequeAudit.
        /// </summary>
        /// <param name="eMSRecChequeAuditDTO"></param>
        /// <returns></returns>
        public static EMSRecChequeAudit GetEMSRecChequeAudit(EMSRecChequeAuditEntity eMSRecChequeAuditDTO)
        {
            EMSRecChequeAudit eMSRecChequeAuditDomain = null;

            try
            {
                eMSRecChequeAuditDomain = Mapper.Map<EMSRecChequeAuditEntity, EMSRecChequeAudit>(eMSRecChequeAuditDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSRecChequeAuditDomain;
        }

        /// <summary>
        /// Map and get EMSReceipt.
        /// </summary>
        /// <param name="EMSReceiptDTO"></param>
        /// <returns></returns>
        public static EMSReceipt GetEMSReceipt(EMSReceiptEntity eMSReceiptDTO)
        {
            EMSReceipt eMSReceiptDomain = null;

            try
            {
                eMSReceiptDomain = Mapper.Map<EMSReceiptEntity, EMSReceipt>(eMSReceiptDTO);
                eMSReceiptDomain.MEMSRecTransType = Mapper.Map<MEMSRecTransTypeEntity, MEMSRecTransType>(eMSReceiptDTO.MEMSRecTransType);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSReceiptDomain;
        }

        /// <summary>
        /// Map and get EMSRecTrans.
        /// </summary>
        /// <param name="EMSRecTransDTO"></param>
        /// <returns></returns>
        public static EMSRecTrans GetEMSRecTrans(EMSRecTransEntity eMSRecTransDTO)
        {
            EMSRecTrans eMSRecTransDomain = null;

            try
            {
                eMSRecTransDomain = Mapper.Map<EMSRecTransEntity, EMSRecTrans>(eMSRecTransDTO);
                eMSRecTransDomain.MEMSRecBank = Mapper.Map<MEMSRecBankEntity, MEMSRecBank>(eMSRecTransDTO.MEMSRecBank);
                eMSRecTransDomain.MEMSRecTransMode = Mapper.Map<MEMSRecTransModeEntity, MEMSRecTransMode>(eMSRecTransDTO.MEMSRecTransMode);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSRecTransDomain;
        }

        /// <summary>
        /// Map and get EMSRoundRobinAuctioneer.
        /// </summary>
        /// <param name="EMSRoundRobinAuctioneerDTO"></param>
        /// <returns></returns>
        public static EMSRoundRobinAuctioneer GetEMSRoundRobinAuctioneer(EMSRoundRobinAuctioneerEntity eMSRoundRobinAuctioneerDTO)
        {
            EMSRoundRobinAuctioneer eMSRoundRobinAuctioneerDomain = null;

            try
            {
                eMSRoundRobinAuctioneerDomain = Mapper.Map<EMSRoundRobinAuctioneerEntity, EMSRoundRobinAuctioneer>(eMSRoundRobinAuctioneerDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSRoundRobinAuctioneerDomain;
        }

        /// <summary>
        /// Map and get EMSSale.
        /// </summary>
        /// <param name="EMSSaleDTO"></param>
        /// <returns></returns>
        public static EMSSale GetEMSSale(EMSSaleEntity eMSSaleDTO)
        {
            EMSSale eMSSaleDomain = null;

            try
            {
                eMSSaleDomain = Mapper.Map<EMSSaleEntity, EMSSale>(eMSSaleDTO);
                eMSSaleDomain.MEMSAuctioneer = Mapper.Map<MEMSAuctioneerEntity, MEMSAuctioneer>(eMSSaleDTO.MEMSAuctioneer);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSSaleDomain;
        }

        /// <summary>
        /// Map and get EMSSaleAdvert.
        /// </summary>
        /// <param name="EMSSaleAdvertDTO"></param>
        /// <returns></returns>
        public static EMSSaleAdvert GetEMSSaleAdvert(EMSSaleAdvertEntity eMSSaleAdvertDTO)
        {
            EMSSaleAdvert eMSSaleAdvertDomain = null;

            try
            {
                eMSSaleAdvertDomain = Mapper.Map<EMSSaleAdvertEntity, EMSSaleAdvert>(eMSSaleAdvertDTO);
                eMSSaleAdvertDomain.MEMSAdvertIn = Mapper.Map<MEMSAdvertInEntity, MEMSAdvertIn>(eMSSaleAdvertDTO.AdvertIn);
                eMSSaleAdvertDomain.MEMSAdvertiser = Mapper.Map<MEMSAdvertiserEntity, MEMSAdvertiser>(eMSSaleAdvertDTO.Advertiser);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSSaleAdvertDomain;
        }

        /// <summary>
        /// Map and get EMSSaleAgent.
        /// </summary>
        /// <param name="EMSSaleAgentDTO"></param>
        /// <returns></returns>
        public static EMSSaleAgent GetEMSSaleAgent(EMSSaleAgentEntity eMSSaleAgentDTO)
        {
            EMSSaleAgent eMSSaleAgentDomain = null;

            try
            {
                eMSSaleAgentDomain = Mapper.Map<EMSSaleAgentEntity, EMSSaleAgent>(eMSSaleAgentDTO);
                eMSSaleAgentDomain.MEMSSalesAgent = Mapper.Map<MEMSSalesAgentEntity, MEMSSalesAgent>(eMSSaleAgentDTO.SalesAgentName);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSSaleAgentDomain;
        }

        /// <summary>
        /// Map and get EMSSaleAppraiser.
        /// </summary>
        /// <param name="EMSSaleAppraiserDTO"></param>
        /// <returns></returns>
        public static EMSSaleAppraiser GetEMSSaleAppraiser(EMSSaleAppraiserEntity eMSSaleAppraiserDTO)
        {
            EMSSaleAppraiser eMSSaleAppraiserDomain = null;

            try
            {
                eMSSaleAppraiserDomain = Mapper.Map<EMSSaleAppraiserEntity, EMSSaleAppraiser>(eMSSaleAppraiserDTO);
                eMSSaleAppraiserDomain.MEMSAppraiser = Mapper.Map<MEMSAppraiserEntity, MEMSAppraiser>(eMSSaleAppraiserDTO.AppraiserName);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSSaleAppraiserDomain;
        }

        /// <summary>
        /// Map and get EMSSaleAuctioneer.
        /// </summary>
        /// <param name="EMSSaleAuctioneerEntity"></param>
        /// <returns></returns>
        public static EMSSaleAuctioneer GetEMSSaleAuctioneer(EMSSaleAuctioneerEntity eMSSaleAuctioneerDTO)
        {
            EMSSaleAuctioneer eMSSaleAuctioneerDomain = null;

            try
            {
                eMSSaleAuctioneerDomain = Mapper.Map<EMSSaleAuctioneerEntity, EMSSaleAuctioneer>(eMSSaleAuctioneerDTO);
                eMSSaleAuctioneerDomain.MEMSAuctioneer = Mapper.Map<MEMSAuctioneerEntity, MEMSAuctioneer>(eMSSaleAuctioneerDTO.MEMSAuctioneer);
            }
            catch (Exception ex)
            {
                Logger.Debug("GetEMSSaleAppraiser. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSSaleAuctioneerDomain;
        }

        /// <summary>
        /// Map and get EMSSaleBuyer.
        /// </summary>
        /// <param name="EMSSaleBuyerDTO"></param>
        /// <returns></returns>
        public static EMSSaleBuyer GetEMSSaleBuyer(EMSSaleBuyerEntity eMSSaleBuyerDTO)
        {
            EMSSaleBuyer eMSSaleBuyerDomain = null;

            try
            {
                eMSSaleBuyerDomain = Mapper.Map<EMSSaleBuyerEntity, EMSSaleBuyer>(eMSSaleBuyerDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSSaleBuyerDomain;
        }

        /// <summary>
        /// Map and get EMSStateFund.
        /// </summary>
        /// <param name="EMSStateFundDTO"></param>
        /// <returns></returns>
        public static EMSStateFund GetEMSStateFund(EMSStateFundEntity eMSStateFundDTO)
        {
            EMSStateFund eMSStateFundDomain = null;

            try
            {
                eMSStateFundDomain = Mapper.Map<EMSStateFundEntity, EMSStateFund>(eMSStateFundDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSStateFundDomain;
        }

        /// <summary>
        /// Map and get EMSTeamMgmt.
        /// </summary>
        /// <param name="EMSTeamMgmtDTO"></param>
        /// <returns></returns>
        public static EMSTeamMgmt GetEMSTeamMgmt(EMSTeamMgmtEntity eMSTeamMgmtDTO)
        {
            EMSTeamMgmt eMSTeamMgmtDomain = null;

            try
            {
                eMSTeamMgmtDomain = Mapper.Map<EMSTeamMgmtEntity, EMSTeamMgmt>(eMSTeamMgmtDTO);
                eMSTeamMgmtDomain.MSection = Mapper.Map<MSectionEntity, MSection>(eMSTeamMgmtDTO.MSection);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSTeamMgmtDomain;
        }

        /// <summary>
        /// Map and get EMSTptClaim.
        /// </summary>
        /// <param name="EMSTptClaimDTO"></param>
        /// <returns></returns>
        public static EMSTptClaim GetEMSTptClaim(EMSTptClaimEntity eMSTptClaimDTO)
        {
            EMSTptClaim eMSTptClaimDomain = null;

            try
            {
                eMSTptClaimDomain = Mapper.Map<EMSTptClaimEntity, EMSTptClaim>(eMSTptClaimDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSTptClaimDomain;
        }

        /// <summary>
        /// Map and get IEnforcement.
        /// </summary>
        /// <param name="iEnforcementEntity"></param>
        /// <returns></returns>
        public static IEnforcement GetEnforcementEntity<T>(T iEnforcementEntity)
        {
            if (iEnforcementEntity.GetType().Equals(typeof(EMSAccountEntity)))
                return EnforcementMapperToDomain.GetEMSAccount(iEnforcementEntity as EMSAccountEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSAdmClaimEntity)))
                return EnforcementMapperToDomain.GetEMSAdmClaim(iEnforcementEntity as EMSAdmClaimEntity);
            //else if (iEnforcementEntity.GetType().Equals(typeof(EMSAdmChargeEntity)))
            //    return EnforcementMapperToDomain.GetEMSAdmCharge(iEnforcementEntity as EMSAdmChargeEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSAdmChargesEntity)))
                return EnforcementMapperToDomain.GetEMSAdmCharges(iEnforcementEntity as EMSAdmChargesEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSAttendanceFeeEntity)))
                return EnforcementMapperToDomain.GetEMSAttendanceFee(iEnforcementEntity as EMSAttendanceFeeEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSAdmExecEntity)))
                return EnforcementMapperToDomain.GetEMSAdmExec(iEnforcementEntity as EMSAdmExecEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSAdmPropertyEntity)))
                return EnforcementMapperToDomain.GetEMSAdmProperty(iEnforcementEntity as EMSAdmPropertyEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSAdmPropertyListEntity)))
                return EnforcementMapperToDomain.GetEMSAdmPropertyList(iEnforcementEntity as EMSAdmPropertyListEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSAdmReleaseEntity)))
                return EnforcementMapperToDomain.GetEMSAdmRelease(iEnforcementEntity as EMSAdmReleaseEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSAppointmentEntity)))
                return EnforcementMapperToDomain.GetEMSAppointment(iEnforcementEntity as EMSAppointmentEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSApptDateTimeEntity)))
                return EnforcementMapperToDomain.GetEMSApptDateTime(iEnforcementEntity as EMSApptDateTimeEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSApptDebtorEntity)))
                return EnforcementMapperToDomain.GetEMSApptDebtor(iEnforcementEntity as EMSApptDebtorEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSCashBookItemEntity)))
                return EnforcementMapperToDomain.GetEMSCashBookItem(iEnforcementEntity as EMSCashBookItemEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSCashBookReconcileEntity)))
                return EnforcementMapperToDomain.GetEMSCashBookReconcile(iEnforcementEntity as EMSCashBookReconcileEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSCivCaseAbortEntity)))
                return EnforcementMapperToDomain.GetEMSCivCaseAbort(iEnforcementEntity as EMSCivCaseAbortEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSCrmCaseEntity)))
                return EnforcementMapperToDomain.GetEMSCrmCase(iEnforcementEntity as EMSCrmCaseEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSCrmCaseExecAddrEntity)))
                return EnforcementMapperToDomain.GetEMSCrmCaseExecAddr(iEnforcementEntity as EMSCrmCaseExecAddrEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSCrmCaseWLDetEntity)))
                return EnforcementMapperToDomain.GetEMSCrmCaseWLDet(iEnforcementEntity as EMSCrmCaseWLDetEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSCivCrmMissingEntity)))
                return EnforcementMapperToDomain.GetEMSCivCrmMissing(iEnforcementEntity as EMSCivCrmMissingEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSCivCrmReleaseEntity)))
                return EnforcementMapperToDomain.GetEMSCivCrmRelease(iEnforcementEntity as EMSCivCrmReleaseEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSCivCrmSeizureEntity)))
                return EnforcementMapperToDomain.GetEMSCivCrmSeizure(iEnforcementEntity as EMSCivCrmSeizureEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSCourtCommissionEntity)))
                return EnforcementMapperToDomain.GetEMSCourtCommissionEntity(iEnforcementEntity as EMSCourtCommissionEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSCivCrmSettlementEntity)))
                return EnforcementMapperToDomain.GetEMSCivCrmSettlement(iEnforcementEntity as EMSCivCrmSettlementEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSDisburseClaimEntity)))
                return EnforcementMapperToDomain.GetEMSDisburseClaim(iEnforcementEntity as EMSDisburseClaimEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSFileMovementEntity)))
                return EnforcementMapperToDomain.GetEMSFileMovement(iEnforcementEntity as EMSFileMovementEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSPaymentEntity)))
                return EnforcementMapperToDomain.GetEMSPayment(iEnforcementEntity as EMSPaymentEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSPaymentVoucherEntity)))
                return EnforcementMapperToDomain.GetEMSPaymentVoucher(iEnforcementEntity as EMSPaymentVoucherEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSPaymentVoucherAdmEntity)))
                return EnforcementMapperToDomain.GetEMSPaymentVoucherAdm(iEnforcementEntity as EMSPaymentVoucherAdmEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSPaymentVoucherChequeEntity)))
                return EnforcementMapperToDomain.GetEMSPaymentVoucherCheque(iEnforcementEntity as EMSPaymentVoucherChequeEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSPaymentVoucherFinalEntity)))
                return EnforcementMapperToDomain.GetEMSPaymentVoucherFinal(iEnforcementEntity as EMSPaymentVoucherFinalEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSPaymentVoucherFinalOtherEntity)))
                return EnforcementMapperToDomain.GetEMSPaymentVoucherFinalOther(iEnforcementEntity as EMSPaymentVoucherFinalOtherEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSPaymentVoucherMiscEntity)))
                return EnforcementMapperToDomain.GetEMSPaymentVoucherMisc(iEnforcementEntity as EMSPaymentVoucherMiscEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSExecLedgerEntity)))
                return EnforcementMapperToDomain.GetEMSExecLedger(iEnforcementEntity as EMSExecLedgerEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSReceiptEntity)))
                return EnforcementMapperToDomain.GetEMSReceipt(iEnforcementEntity as EMSReceiptEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSRecTransEntity)))
                return EnforcementMapperToDomain.GetEMSRecTrans(iEnforcementEntity as EMSRecTransEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSRoundRobinAuctioneerEntity)))
                return EnforcementMapperToDomain.GetEMSRoundRobinAuctioneer(iEnforcementEntity as EMSRoundRobinAuctioneerEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSRecAuditEntity)))
                return EnforcementMapperToDomain.GetEMSRecAudit(iEnforcementEntity as EMSRecAuditEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSRecChequeAuditEntity)))
                return EnforcementMapperToDomain.GetEMSRecChequeAudit(iEnforcementEntity as EMSRecChequeAuditEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSSaleAdvertEntity)))
                return EnforcementMapperToDomain.GetEMSSaleAdvert(iEnforcementEntity as EMSSaleAdvertEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSSaleAppraiserEntity)))
                return EnforcementMapperToDomain.GetEMSSaleAppraiser(iEnforcementEntity as EMSSaleAppraiserEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSSaleAuctioneerEntity)))
                return EnforcementMapperToDomain.GetEMSSaleAuctioneer(iEnforcementEntity as EMSSaleAuctioneerEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSSaleEntity)))
                return EnforcementMapperToDomain.GetEMSSale(iEnforcementEntity as EMSSaleEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSSaleAgentEntity)))
                return EnforcementMapperToDomain.GetEMSSaleAgent(iEnforcementEntity as EMSSaleAgentEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSSaleBuyerEntity)))
                return EnforcementMapperToDomain.GetEMSSaleBuyer(iEnforcementEntity as EMSSaleBuyerEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSTeamMgmtEntity)))
                return EnforcementMapperToDomain.GetEMSTeamMgmt(iEnforcementEntity as EMSTeamMgmtEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSTptClaimEntity)))
                return EnforcementMapperToDomain.GetEMSTptClaim(iEnforcementEntity as EMSTptClaimEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSMiscClaimEntity)))
                return EnforcementMapperToDomain.GetEMSMiscClaim(iEnforcementEntity as EMSMiscClaimEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSChequeEntity)))
                return EnforcementMapperToDomain.GetEMSCheque(iEnforcementEntity as EMSChequeEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSChequeHistoryEntity)))
                return EnforcementMapperToDomain.GetEMSChequeHistory(iEnforcementEntity as EMSChequeHistoryEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSPaymentChequeEntity)))
                return EnforcementMapperToDomain.GetEMSPaymentCheque(iEnforcementEntity as EMSPaymentChequeEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSOutstandingPaymentEntity)))
                return EnforcementMapperToDomain.GetEMSOutstandingPayment(iEnforcementEntity as EMSOutstandingPaymentEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(Temp_EMSAppointmentEntity)))
                return EnforcementMapperToDomain.GetTemp_EMSAppointment(iEnforcementEntity as Temp_EMSAppointmentEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSStateFundEntity)))
                return EnforcementMapperToDomain.GetEMSStateFund(iEnforcementEntity as EMSStateFundEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSADMSaleOthersEntity)))
                return EnforcementMapperToDomain.GetEMSADMSaleOthers(iEnforcementEntity as EMSADMSaleOthersEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSRecapitDetailsEntity)))
                return EnforcementMapperToDomain.GetEMSRecapitDetails(iEnforcementEntity as EMSRecapitDetailsEntity);
            else if (iEnforcementEntity.GetType().Equals(typeof(EMSRecapitulationEntity)))
                return EnforcementMapperToDomain.GetEMSRecapitulation(iEnforcementEntity as EMSRecapitulationEntity);

            throw new Exception("No Automatic Mapper for this entity (" + iEnforcementEntity.GetType().ToString() + ")");
        }

        /// <summary>
        /// Map and get LawFirm.
        /// </summary>
        /// <param name="LawFirmEntity"></param>
        /// <returns></returns>
        public static LawFirm GetLawFirm(LawFirmEntity lawFirmDTO)
        {
            LawFirm lawFirmDomain = null;

            try
            {
                lawFirmDomain = Mapper.Map<LawFirmEntity, LawFirm>(lawFirmDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return lawFirmDomain;
        }

        /// <summary>
        /// Map and get Temp_EMSAppointment E.
        /// </summary>
        /// <param name="temp_EMSAppointmentDTO"></param>
        /// <returns></returns>
        public static Temp_EMSAppointment GetTemp_EMSAppointment(Temp_EMSAppointmentEntity temp_EMSAppointmentDTO)
        {
            Temp_EMSAppointment temp_EMSAppointment = null;

            try
            {
                temp_EMSAppointment = Mapper.Map<Temp_EMSAppointmentEntity, Temp_EMSAppointment>(temp_EMSAppointmentDTO);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return temp_EMSAppointment;
        }

        #endregion Methods
    }
}