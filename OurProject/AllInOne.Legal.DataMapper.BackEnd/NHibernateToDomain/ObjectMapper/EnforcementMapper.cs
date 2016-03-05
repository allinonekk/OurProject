#region Header

/*****************************************************************************************************
* Description : This file represents a object to object mapping for Enforcement entities.
* This class will map the Domain Entitiy to DTO.
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

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Enforcement;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    public class EnforcementMapperToDTO
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(EnforcementMapperToDTO));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Map and get CaseParty.
        /// </summary>
        /// <param name="casePartyDomain"></param>
        /// <returns></returns>
        public static CasePartyEntity GetCasePartyEntity(CaseParty casePartyDomain)
        {
            CasePartyEntity casePartyDTO = null;

            try
            {
                casePartyDTO = Mapper.Map<CaseParty, CasePartyEntity>(casePartyDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return casePartyDTO;
        }

        /// <summary>
        /// Map and get EMSAccount.
        /// </summary>
        /// <param name="eMSAccountDomain"></param>
        /// <returns></returns>
        public static EMSAccountEntity GetEMSAccountEntity(EMSAccount eMSAccountDomain)
        {
            EMSAccountEntity eMSAccountDTO = null;

            try
            {
                eMSAccountDTO = Mapper.Map<EMSAccount, EMSAccountEntity>(eMSAccountDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAccountDTO;
        }

        ///// <summary>
        ///// Map and get EMSAdmCharge.
        ///// </summary>
        ///// <param name="EMSAdmChargeDomain"></param>
        ///// <returns></returns>
        //public static EMSAdmChargeEntity GetEMSAdmChargeEntity(EMSAdmCharge eMSAdmChargeDomain)
        //{
        //    EMSAdmChargeEntity eMSAdmChargeDTO = null;

        //    try
        //    {
        //        eMSAdmChargeDTO = Mapper.Map<EMSAdmCharge, EMSAdmChargeEntity>(eMSAdmChargeDomain);
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
        //        throw;
        //    }

        //    return eMSAdmChargeDTO;
        //}

        /// <summary>
        /// Map and get EMSAdmCharges.
        /// </summary>
        /// <param name="EMSAdmChargesDomain"></param>
        /// <returns></returns>
        public static EMSAdmChargesEntity GetEMSAdmChargesEntity(EMSAdmCharges eMSAdmChargesDomain)
        {
            EMSAdmChargesEntity eMSAdmChargesDTO = null;

            try
            {
                eMSAdmChargesDTO = Mapper.Map<EMSAdmCharges, EMSAdmChargesEntity>(eMSAdmChargesDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAdmChargesDTO;
        }

        /// <summary>
        /// Map and get EMSAdmClaim.
        /// </summary>
        /// <param name="EMSAdmClaimDomain"></param>
        /// <returns></returns>
        public static EMSAdmClaimEntity GetEMSAdmClaimEntity(EMSAdmClaim eMSAdmClaimDomain)
        {
            EMSAdmClaimEntity eMSAdmClaimDTO = null;

            try
            {
                eMSAdmClaimDTO = Mapper.Map<EMSAdmClaim, EMSAdmClaimEntity>(eMSAdmClaimDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAdmClaimDTO;
        }

        /// <summary>
        /// Map and get EMSAttendanceFee.
        /// </summary>
        /// <param name="eMSAttendanceFeeDomain"></param>
        /// <returns></returns>
        public static EMSAttendanceFeeEntity GetEMSAttendanceFeeEntity(EMSAttendanceFee eMSAttendanceFeeDomain)
        {
            EMSAttendanceFeeEntity eMSAttendanceFeeDTO = null;

            try
            {
                eMSAttendanceFeeDTO = Mapper.Map<EMSAttendanceFee, EMSAttendanceFeeEntity>(eMSAttendanceFeeDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAttendanceFeeDTO;
        }

        /// <summary>
        /// Map and get EMSAdmExec.
        /// </summary>
        /// <param name="EMSAdmExecDomain"></param>
        /// <returns></returns>
        public static EMSAdmExecEntity GetEMSAdmExecEntity(EMSAdmExec eMSAdmExecDomain)
        {
            EMSAdmExecEntity eMSAdmExecDTO = null;

            try
            {
                eMSAdmExecDTO = Mapper.Map<EMSAdmExec, EMSAdmExecEntity>(eMSAdmExecDomain);
                eMSAdmExecDTO.MEMSSecurityGuard=Mapper.Map<MEMSSecurityGuard,MEMSSecurityGuardEntity>(eMSAdmExecDomain.MEMSSecurityGuard);
                eMSAdmExecDTO.MEMSADMExecLocation = Mapper.Map<MEMSADMExecLocation, MEMSADMExecLocationEntity>(eMSAdmExecDomain.MEMSADMExecLocation);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAdmExecDTO;
        }

        /// <summary>
        /// Map and get EMSAdmProperty.
        /// </summary>
        /// <param name="EMSAdmPropertyDomain"></param>
        /// <returns></returns>
        public static EMSAdmPropertyEntity GetEMSAdmPropertyEntity(EMSAdmProperty eMSAdmPropertyDomain)
        {
            EMSAdmPropertyEntity eMSAdmPropertyDTO = null;

            try
            {
                eMSAdmPropertyDTO = Mapper.Map<EMSAdmProperty, EMSAdmPropertyEntity>(eMSAdmPropertyDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAdmPropertyDTO;
        }

        /// <summary>
        /// Map and get EMSAdmPropertyList.
        /// </summary>
        /// <param name="EMSAdmPropertyListDomain"></param>
        /// <returns></returns>
        public static EMSAdmPropertyListEntity GetEMSAdmPropertyListEntity(EMSAdmPropertyList eMSAdmPropertyListDomain)
        {
            EMSAdmPropertyListEntity eMSAdmPropertyListDTO = null;

            try
            {
                eMSAdmPropertyListDTO = Mapper.Map<EMSAdmPropertyList, EMSAdmPropertyListEntity>(eMSAdmPropertyListDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAdmPropertyListDTO;
        }

        /// <summary>
        /// Map and get EMSAdmRelease.
        /// </summary>
        /// <param name="EMSAdmReleaseDomain"></param>
        /// <returns></returns>
        public static EMSAdmReleaseEntity GetEMSAdmReleaseEntity(EMSAdmRelease eMSAdmReleaseDomain)
        {
            EMSAdmReleaseEntity eMSAdmReleaseDTO = null;

            try
            {
                eMSAdmReleaseDTO = Mapper.Map<EMSAdmRelease, EMSAdmReleaseEntity>(eMSAdmReleaseDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAdmReleaseDTO;
        }

        /// <summary>
        /// Map and get EMSADMSaleOthers.
        /// </summary>
        /// <param name="EMSADMSaleOthersDomain"></param>
        /// <returns></returns>
        public static EMSADMSaleOthersEntity GetEMSADMSaleOthersEntity(EMSADMSaleOthers eMSADMSaleOthersDomain)
        {
            EMSADMSaleOthersEntity eMSADMSaleOthersDTO = null;

            try
            {
                eMSADMSaleOthersDTO = Mapper.Map<EMSADMSaleOthers, EMSADMSaleOthersEntity>(eMSADMSaleOthersDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSADMSaleOthersDTO;
        }

        /// <summary>
        /// Map and get EMSAppointment.
        /// </summary>
        /// <param name="EMSAppointmentDomain"></param>
        /// <returns></returns>
        public static EMSAppointmentEntity GetEMSAppointmentEntity(EMSAppointment eMSAppointmentDomain)
        {
            EMSAppointmentEntity eMSAppointmentDTO = null;

            try
            {
                eMSAppointmentDTO = Mapper.Map<EMSAppointment, EMSAppointmentEntity>(eMSAppointmentDomain);
                eMSAppointmentDTO.MEMSApptOutcome = Mapper.Map<MEMSApptOutcome, MEMSApptOutcomeEntity>(eMSAppointmentDomain.MEMSApptOutcome);
                eMSAppointmentDTO.MEMSApptReason = Mapper.Map<MEMSApptReason, MEMSApptReasonEntity>(eMSAppointmentDomain.MEMSApptReason);
                eMSAppointmentDTO.MEMSApptType = Mapper.Map<MEMSApptType, MEMSApptTypeEntity>(eMSAppointmentDomain.MEMSApptType);
                eMSAppointmentDTO.MEMSAuctioneer = Mapper.Map<MEMSAuctioneer, MEMSAuctioneerEntity>(eMSAppointmentDomain.MEMSAuctioneer);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSAppointmentDTO;
        }

        /// <summary>
        /// Map and get EMSApptDateTime.
        /// </summary>
        /// <param name="EMSApptDateTimeDomain"></param>
        /// <returns></returns>
        public static EMSApptDateTimeEntity GetEMSApptDateTimeEntity(EMSApptDateTime eMSApptDateTimeDomain)
        {
            EMSApptDateTimeEntity eMSApptDateTimeDTO = null;

            try
            {
                eMSApptDateTimeDTO = Mapper.Map<EMSApptDateTime, EMSApptDateTimeEntity>(eMSApptDateTimeDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSApptDateTimeDTO;
        }

        /// <summary>
        /// Map and get EMSApptDebtor.
        /// </summary>
        /// <param name="EMSApptDebtorDomain"></param>
        /// <returns></returns>
        public static EMSApptDebtorEntity GetEMSApptDebtorEntity(EMSApptDebtor eMSApptDebtorDomain)
        {
            EMSApptDebtorEntity eMSApptDebtorDTO = null;

            try
            {
                eMSApptDebtorDTO = Mapper.Map<EMSApptDebtor, EMSApptDebtorEntity>(eMSApptDebtorDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSApptDebtorDTO;
        }

        /// <summary>
        /// Map and get EMSCashBookItem.
        /// </summary>
        /// <param name="EMSCashBookItem"></param>
        /// <returns></returns>
        public static EMSCashBookItemEntity GetEMSCashBookItemEntity(EMSCashBookItem eMSCashBookItem)
        {
            EMSCashBookItemEntity eMSCashBookItemDTO = null;

            try
            {
                eMSCashBookItemDTO = Mapper.Map<EMSCashBookItem, EMSCashBookItemEntity>(eMSCashBookItem);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCashBookItemDTO;
        }

        /// <summary>
        /// Map and get EMSCashBookReconcile.
        /// </summary>
        /// <param name="EMSCashBookReconcile"></param>
        /// <returns></returns>
        public static EMSCashBookReconcileEntity GetEMSCashBookReconcileEntity(EMSCashBookReconcile eMSCashBookReconcile)
        {
            EMSCashBookReconcileEntity eMSCashBookReconcileDTO = null;

            try
            {
                eMSCashBookReconcileDTO = Mapper.Map<EMSCashBookReconcile, EMSCashBookReconcileEntity>(eMSCashBookReconcile);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCashBookReconcileDTO;
        }

        /// <summary>
        /// Map and get EMSCheque.
        /// </summary>
        /// <param name="EMSCheque"></param>
        /// <returns></returns>
        public static EMSChequeEntity GetEMSChequeEntity(EMSCheque eMSCheque)
        {
            EMSChequeEntity eMSChequeDTO = null;

            try
            {
                eMSChequeDTO = Mapper.Map<EMSCheque, EMSChequeEntity>(eMSCheque);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSChequeDTO;
        }

        /// <summary>
        /// Map and get EMSChequeHistory.
        /// </summary>
        /// <param name="EMSChequeHistory"></param>
        /// <returns></returns>
        public static EMSChequeHistoryEntity GetEMSChequeHistoryEntity(EMSChequeHistory eMSChequeHistory)
        {
            EMSChequeHistoryEntity eMSChequeHistoryDTO = null;

            try
            {
                eMSChequeHistoryDTO = Mapper.Map<EMSChequeHistory, EMSChequeHistoryEntity>(eMSChequeHistory);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSChequeHistoryDTO;
        }

        /// <summary>
        /// Map and get EMSCivCaseAbort.
        /// </summary>
        /// <param name="EMSCivCaseAbortDomain"></param>
        /// <returns></returns>
        public static EMSCivCaseAbortEntity GetEMSCivCaseAbortEntity(EMSCivCaseAbort eMSCivCaseAbortDomain)
        {
            EMSCivCaseAbortEntity eMSCivCaseAbortDTO = null;

            try
            {
                eMSCivCaseAbortDTO = Mapper.Map<EMSCivCaseAbort, EMSCivCaseAbortEntity>(eMSCivCaseAbortDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCivCaseAbortDTO;
        }

        /// <summary>
        /// Map and get EMSCivCrmMissing.
        /// </summary>
        /// <param name="EMSCivCrmMissingDomain"></param>
        /// <returns></returns>
        public static EMSCivCrmMissingEntity GetEMSCivCrmMissingEntity(EMSCivCrmMissing eMSCivCrmMissingDomain)
        {
            EMSCivCrmMissingEntity eMSCivCrmMissingDTO = null;

            try
            {
                eMSCivCrmMissingDTO = Mapper.Map<EMSCivCrmMissing, EMSCivCrmMissingEntity>(eMSCivCrmMissingDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCivCrmMissingDTO;
        }

        /// <summary>
        /// Map and get EMSCivCrmRelease.
        /// </summary>
        /// <param name="EMSCivCrmReleaseDomain"></param>
        /// <returns></returns>
        public static EMSCivCrmReleaseEntity GetEMSCivCrmReleaseEntity(EMSCivCrmRelease eMSCivCrmReleaseDomain)
        {
            EMSCivCrmReleaseEntity eMSCivCrmReleaseDTO = null;

            try
            {
                eMSCivCrmReleaseDTO = Mapper.Map<EMSCivCrmRelease, EMSCivCrmReleaseEntity>(eMSCivCrmReleaseDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCivCrmReleaseDTO;
        }

        /// <summary>
        /// Map and get EMSCivCrmSeizure.
        /// </summary>
        /// <param name="EMSCivCrmSeizureDomain"></param>
        /// <returns></returns>
        public static EMSCivCrmSeizureEntity GetEMSCivCrmSeizureEntity(EMSCivCrmSeizure eMSCivCrmSeizureDomain)
        {
            EMSCivCrmSeizureEntity eMSCivCrmSeizureDTO = null;

            try
            {
                eMSCivCrmSeizureDTO = Mapper.Map<EMSCivCrmSeizure, EMSCivCrmSeizureEntity>(eMSCivCrmSeizureDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCivCrmSeizureDTO;
        }

        /// <summary>
        /// Map and get EMSCivCrmSettlement.
        /// </summary>
        /// <param name="EMSCivCrmSettlementDomain"></param>
        /// <returns></returns>
        public static EMSCivCrmSettlementEntity GetEMSCivCrmSettlementEntity(EMSCivCrmSettlement eMSCivCrmSettlementDomain)
        {
            EMSCivCrmSettlementEntity eMSCivCrmSettlementDTO = null;

            try
            {
                eMSCivCrmSettlementDTO = Mapper.Map<EMSCivCrmSettlement, EMSCivCrmSettlementEntity>(eMSCivCrmSettlementDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCivCrmSettlementDTO;
        }

        /// <summary>
        /// Map and get EMSCourtCommission.
        /// </summary>
        /// <param name="eMSCourtCommissionDomain"></param>
        /// <returns></returns>
        public static EMSCourtCommissionEntity GetEMSCourtCommissionEntity(EMSCourtCommission eMSCourtCommissionDomain)
        {
            EMSCourtCommissionEntity eMSCourtCommissionDTO = null;

            try
            {
                eMSCourtCommissionDTO = Mapper.Map<EMSCourtCommission, EMSCourtCommissionEntity>(eMSCourtCommissionDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCourtCommissionDTO;
        }

        /// <summary>
        /// Map and get EMSCrmCase.
        /// </summary>
        /// <param name="eMSCrmCaseDomain"></param>
        /// <returns></returns>
        public static EMSCrmCaseEntity GetEMSCrmCaseEntity(EMSCrmCase eMSCrmCaseDomain)
        {
            EMSCrmCaseEntity eMSCrmCaseDTO = null;

            try
            {
                eMSCrmCaseDTO = Mapper.Map<EMSCrmCase, EMSCrmCaseEntity>(eMSCrmCaseDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCrmCaseDTO;
        }

        /// <summary>
        /// Map and get EMSCrmCaseExecAddr.
        /// </summary>
        /// <param name="eMSCrmCaseExecAddrDomain"></param>
        /// <returns></returns>
        public static EMSCrmCaseExecAddrEntity GetEMSCrmCaseExecAddrEntity(EMSCrmCaseExecAddr eMSCrmCaseExecAddrDomain)
        {
            EMSCrmCaseExecAddrEntity eMSCrmCaseExecAddrDTO = null;

            try
            {
                eMSCrmCaseExecAddrDTO = Mapper.Map<EMSCrmCaseExecAddr, EMSCrmCaseExecAddrEntity>(eMSCrmCaseExecAddrDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCrmCaseExecAddrDTO;
        }

        /// <summary>
        /// Map and get EMSCrmCaseWLDet.
        /// </summary>
        /// <param name="eMSCrmCaseWLDetDomain"></param>
        /// <returns></returns>
        public static EMSCrmCaseWLDetEntity GetEMSCrmCaseWLDetEntity(EMSCrmCaseWLDet eMSCrmCaseWLDetDomain)
        {
            EMSCrmCaseWLDetEntity eMSCrmCaseWLDetDTO = null;

            try
            {
                eMSCrmCaseWLDetDTO = Mapper.Map<EMSCrmCaseWLDet, EMSCrmCaseWLDetEntity>(eMSCrmCaseWLDetDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSCrmCaseWLDetDTO;
        }

        /// <summary>
        /// Map and get EMSDisburseClaim.
        /// </summary>
        /// <param name="EMSDisburseClaimDomain"></param>
        /// <returns></returns>
        public static EMSDisburseClaimEntity GetEMSDisburseClaimEntity(EMSDisburseClaim eMSDisburseClaimDomain)
        {
            EMSDisburseClaimEntity eMSDisburseClaimDTO = null;

            try
            {
                eMSDisburseClaimDTO = Mapper.Map<EMSDisburseClaim, EMSDisburseClaimEntity>(eMSDisburseClaimDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSDisburseClaimDTO;
        }

        /// <summary>
        /// Map and get EMSExecLedger.
        /// </summary>
        /// <param name="EMSExecLedgerDomain"></param>
        /// <returns></returns>
        public static EMSExecLedgerEntity GetEMSExecLedgerEntity(EMSExecLedger eMSExecLedgerDomain)
        {
            EMSExecLedgerEntity eMSExecLedgerDTO = null;

            try
            {
                eMSExecLedgerDTO = Mapper.Map<EMSExecLedger, EMSExecLedgerEntity>(eMSExecLedgerDomain);
                eMSExecLedgerDTO.MEMSLedger = Mapper.Map<MEMSLedger, MEMSLedgerEntity>(eMSExecLedgerDomain.MEMSLedger);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSExecLedgerDTO;
        }

        /// <summary>
        /// Map and get EMSFileMovement.
        /// </summary>
        /// <param name="EMSFileMovementDomain"></param>
        /// <returns></returns>
        public static EMSFileMovementEntity GetEMSFileMovementEntity(EMSFileMovement eMSFileMovementDomain)
        {
            EMSFileMovementEntity eMSFileMovementDTO = null;

            try
            {
                eMSFileMovementDTO = Mapper.Map<EMSFileMovement, EMSFileMovementEntity>(eMSFileMovementDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSFileMovementDTO;
        }

        /// <summary>
        /// Map and get EMSMiscClaim.
        /// </summary>
        /// <param name="EMSMiscClaimDomain"></param>
        /// <returns></returns>
        public static EMSMiscClaimEntity GetEMSMiscClaimEntity(EMSMiscClaim eMSMiscClaimDomain)
        {
            EMSMiscClaimEntity eMSMiscClaimDTO = null;

            try
            {
                eMSMiscClaimDTO = Mapper.Map<EMSMiscClaim, EMSMiscClaimEntity>(eMSMiscClaimDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSMiscClaimDTO;
        }

        /// <summary>
        /// Map and get EMSOutstandingPayment.
        /// </summary>
        /// <param name="EMSOutstandingPaymentDomain"></param>
        /// <returns></returns>
        public static EMSOutstandingPaymentEntity GetEMSOutstandingPaymentEntity(EMSOutstandingPayment eMSOutstandingPaymentDomain)
        {
            EMSOutstandingPaymentEntity eMSOutstandingPaymentDTO = null;

            try
            {
                eMSOutstandingPaymentDTO = Mapper.Map<EMSOutstandingPayment, EMSOutstandingPaymentEntity>(eMSOutstandingPaymentDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSOutstandingPaymentDTO;
        }

        /// <summary>
        /// Map and get EMSPaymentCheque.
        /// </summary>
        /// <param name="EMSPaymentCheque"></param>
        /// <returns></returns>
        public static EMSPaymentChequeEntity GetEMSPaymentChequeEntity(EMSPaymentCheque eMSPaymentCheque)
        {
            EMSPaymentChequeEntity eMSPaymentChequeDTO = null;

            try
            {
                eMSPaymentChequeDTO = Mapper.Map<EMSPaymentCheque, EMSPaymentChequeEntity>(eMSPaymentCheque);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentChequeDTO;
        }

        /// <summary>
        /// Map and get EMSPayment.
        /// </summary>
        /// <param name="EMSPaymentDomain"></param>
        /// <returns></returns>
        public static EMSPaymentEntity GetEMSPaymentEntity(EMSPayment eMSPaymentDomain)
        {
            EMSPaymentEntity eMSPaymentDTO = null;

            try
            {
                eMSPaymentDTO = Mapper.Map<EMSPayment, EMSPaymentEntity>(eMSPaymentDomain);
                eMSPaymentDTO.MEMSLedger = Mapper.Map<MEMSLedger, MEMSLedgerEntity>(eMSPaymentDomain.MEMSLedger);
                eMSPaymentDTO.MEMSNatureOfPayment = Mapper.Map<MEMSNatureOfPayment, MEMSNatureOfPaymentEntity>(eMSPaymentDomain.MEMSNatureOfPayment);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentDTO;
        }

        /// <summary>
        /// Map and get EMSPaymentVoucherAdm.
        /// </summary>
        /// <param name="EMSPaymentVoucherAdmDomain"></param>
        /// <returns></returns>
        public static EMSPaymentVoucherAdmEntity GetEMSPaymentVoucherAdmEntity(EMSPaymentVoucherAdm eMSPaymentVoucherAdmDomain)
        {
            EMSPaymentVoucherAdmEntity eMSPaymentVoucherAdmDTO = null;

            try
            {
                eMSPaymentVoucherAdmDTO = Mapper.Map<EMSPaymentVoucherAdm, EMSPaymentVoucherAdmEntity>(eMSPaymentVoucherAdmDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentVoucherAdmDTO;
        }

        /// <summary>
        /// Map and get EMSPaymentVoucherCheque.
        /// </summary>
        /// <param name="EMSPaymentVoucherChequeDomain"></param>
        /// <returns></returns>
        public static EMSPaymentVoucherChequeEntity GetEMSPaymentVoucherChequeEntity(EMSPaymentVoucherCheque eMSPaymentVoucherChequeDomain)
        {
            EMSPaymentVoucherChequeEntity eMSPaymentVoucherChequeDTO = null;

            try
            {
                eMSPaymentVoucherChequeDTO = Mapper.Map<EMSPaymentVoucherCheque, EMSPaymentVoucherChequeEntity>(eMSPaymentVoucherChequeDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentVoucherChequeDTO;
        }

        /// <summary>
        /// Map and get EMSPaymentVoucher.
        /// </summary>
        /// <param name="EMSPaymentVoucherDomain"></param>
        /// <returns></returns>
        public static EMSPaymentVoucherEntity GetEMSPaymentVoucherEntity(EMSPaymentVoucher eMSPaymentVoucherDomain)
        {
            EMSPaymentVoucherEntity eMSPaymentVoucherDTO = null;

            try
            {
                eMSPaymentVoucherDTO = Mapper.Map<EMSPaymentVoucher, EMSPaymentVoucherEntity>(eMSPaymentVoucherDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentVoucherDTO;
        }

        /// <summary>
        /// Map and get EMSPaymentVoucherFinal.
        /// </summary>
        /// <param name="EMSPaymentVoucherFinalDomain"></param>
        /// <returns></returns>
        public static EMSPaymentVoucherFinalEntity GetEMSPaymentVoucherFinalEntity(EMSPaymentVoucherFinal eMSPaymentVoucherFinalDomain)
        {
            EMSPaymentVoucherFinalEntity eMSPaymentVoucherFinalDTO = null;

            try
            {
                eMSPaymentVoucherFinalDTO = Mapper.Map<EMSPaymentVoucherFinal, EMSPaymentVoucherFinalEntity>(eMSPaymentVoucherFinalDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentVoucherFinalDTO;
        }

        /// <summary>
        /// Map and get EMSPaymentVoucherFinal.
        /// </summary>
        /// <param name="EMSPaymentVoucherFinalOtherDomain"></param>
        /// <returns></returns>
        public static EMSPaymentVoucherFinalOtherEntity GetEMSPaymentVoucherFinalOtherEntity(EMSPaymentVoucherFinalOther eMSPaymentVoucherFinalOtherDomain)
        {
            EMSPaymentVoucherFinalOtherEntity eMSPaymentVoucherFinalOtherDTO = null;

            try
            {
                eMSPaymentVoucherFinalOtherDTO = Mapper.Map<EMSPaymentVoucherFinalOther, EMSPaymentVoucherFinalOtherEntity>(eMSPaymentVoucherFinalOtherDomain);
                eMSPaymentVoucherFinalOtherDTO.MEMSNatureOfPayment = Mapper.Map<MEMSNatureOfPayment, MEMSNatureOfPaymentEntity>(eMSPaymentVoucherFinalOtherDomain.MEMSNatureOfPayment);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentVoucherFinalOtherDTO;
        }

        /// <summary>
        /// Map and get EMSPaymentVoucherMisc.
        /// </summary>
        /// <param name="EMSPaymentVoucherMiscDomain"></param>
        /// <returns></returns>
        public static EMSPaymentVoucherMiscEntity GetEMSPaymentVoucherMiscEntity(EMSPaymentVoucherMisc eMSPaymentVoucherMiscDomain)
        {
            EMSPaymentVoucherMiscEntity eMSPaymentVoucherMiscDTO = null;

            try
            {
                eMSPaymentVoucherMiscDTO = Mapper.Map<EMSPaymentVoucherMisc, EMSPaymentVoucherMiscEntity>(eMSPaymentVoucherMiscDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSPaymentVoucherMiscDTO;
        }

        /// <summary>
        /// Map and get EMSRecapitDetails.
        /// </summary>
        /// <param name="EMSRecapitDetailsDomain"></param>
        /// <returns></returns>
        public static EMSRecapitDetailsEntity GetEMSRecapitDetailsEntity(EMSRecapitDetails eMSRecapitDetailsDomain)
        {
            EMSRecapitDetailsEntity eMSRecapitDetailsDTO = null;

            try
            {
                eMSRecapitDetailsDTO = Mapper.Map<EMSRecapitDetails, EMSRecapitDetailsEntity>(eMSRecapitDetailsDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSRecapitDetailsDTO;
        }

        /// <summary>
        /// Map and get EMSRecapitulation.
        /// </summary>
        /// <param name="EMSRecapitulationDomain"></param>
        /// <returns></returns>
        public static EMSRecapitulationEntity GetEMSRecapitulationEntity(EMSRecapitulation eMSRecapitulationDomain)
        {
            EMSRecapitulationEntity eMSRecapitulationDTO = null;

            try
            {
                eMSRecapitulationDTO = Mapper.Map<EMSRecapitulation, EMSRecapitulationEntity>(eMSRecapitulationDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSRecapitulationDTO;
        }

        /// <summary>
        /// Map and get EMSRecAudit.
        /// </summary>
        /// <param name="EMSRecAuditDomain"></param>
        /// <returns></returns>
        public static EMSRecAuditEntity GetEMSRecAuditEntity(EMSRecAudit eMSRecAuditDomain)
        {
            EMSRecAuditEntity eMSRecAuditDTO = null;

            try
            {
                eMSRecAuditDTO = Mapper.Map<EMSRecAudit, EMSRecAuditEntity>(eMSRecAuditDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSRecAuditDTO;
        }

        /// <summary>
        /// Map and get EMSRecChequeAuditEntity.
        /// </summary>
        /// <param name="eMSRecChequeAuditDomain"></param>
        /// <returns></returns>
        public static EMSRecChequeAuditEntity GetEMSRecChequeAuditEntity(EMSRecChequeAudit eMSRecChequeAuditDomain)
        {
            EMSRecChequeAuditEntity eMSRecChequeAuditDTO = null;

            try
            {
                eMSRecChequeAuditDTO = Mapper.Map<EMSRecChequeAudit, EMSRecChequeAuditEntity>(eMSRecChequeAuditDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSRecChequeAuditDTO;
        }

        /// <summary>
        /// Map and get EMSReceipt.
        /// </summary>
        /// <param name="EMSReceiptDomain"></param>
        /// <returns></returns>
        public static EMSReceiptEntity GetEMSReceiptEntity(EMSReceipt eMSReceiptDomain)
        {
            EMSReceiptEntity eMSReceiptDTO = null;

            try
            {
                eMSReceiptDTO = Mapper.Map<EMSReceipt, EMSReceiptEntity>(eMSReceiptDomain);
                eMSReceiptDTO.MEMSRecTransType = Mapper.Map<MEMSRecTransType, MEMSRecTransTypeEntity>(eMSReceiptDomain.MEMSRecTransType);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSReceiptDTO;
        }

        /// <summary>
        /// Map and get EMSRecTrans.
        /// </summary>
        /// <param name="EMSRecTransDomain"></param>
        /// <returns></returns>
        public static EMSRecTransEntity GetEMSRecTransEntity(EMSRecTrans eMSRecTransDomain)
        {
            EMSRecTransEntity eMSRecTransDTO = null;

            try
            {
                eMSRecTransDTO = Mapper.Map<EMSRecTrans, EMSRecTransEntity>(eMSRecTransDomain);
                eMSRecTransDTO.MEMSRecBank = Mapper.Map<MEMSRecBank, MEMSRecBankEntity>(eMSRecTransDomain.MEMSRecBank);
                eMSRecTransDTO.MEMSRecTransMode = Mapper.Map<MEMSRecTransMode, MEMSRecTransModeEntity>(eMSRecTransDomain.MEMSRecTransMode);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSRecTransDTO;
        }

        /// <summary>
        /// Map and get EMSRoundRobinAuctioneer.
        /// </summary>
        /// <param name="EMSRoundRobinAuctioneerDomain"></param>
        /// <returns></returns>
        public static EMSRoundRobinAuctioneerEntity GetEMSRoundRobinAuctioneerEntity(EMSRoundRobinAuctioneer eMSRoundRobinAuctioneerDomain)
        {
            EMSRoundRobinAuctioneerEntity eMSRoundRobinAuctioneerDTO = null;

            try
            {
                eMSRoundRobinAuctioneerDTO = Mapper.Map<EMSRoundRobinAuctioneer, EMSRoundRobinAuctioneerEntity>(eMSRoundRobinAuctioneerDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSRoundRobinAuctioneerDTO;
        }

        /// <summary>
        /// Map and get EMSSaleAdvert.
        /// </summary>
        /// <param name="EMSSaleAdvertDomain"></param>
        /// <returns></returns>
        public static EMSSaleAdvertEntity GetEMSSaleAdvertEntity(EMSSaleAdvert eMSSaleAdvertDomain)
        {
            EMSSaleAdvertEntity eMSSaleAdvertDTO = null;

            try
            {
                eMSSaleAdvertDTO = Mapper.Map<EMSSaleAdvert, EMSSaleAdvertEntity>(eMSSaleAdvertDomain);
                eMSSaleAdvertDTO.AdvertIn = Mapper.Map<MEMSAdvertIn, MEMSAdvertInEntity>(eMSSaleAdvertDomain.MEMSAdvertIn);
                eMSSaleAdvertDTO.Advertiser = Mapper.Map<MEMSAdvertiser, MEMSAdvertiserEntity>(eMSSaleAdvertDomain.MEMSAdvertiser);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSSaleAdvertDTO;
        }

        /// <summary>
        /// Map and get EMSSaleAgent.
        /// </summary>
        /// <param name="EMSSaleAgentDomain"></param>
        /// <returns></returns>
        public static EMSSaleAgentEntity GetEMSSaleAgentEntity(EMSSaleAgent eMSSaleAgentDomain)
        {
            EMSSaleAgentEntity eMSSaleAgentDTO = null;

            try
            {
                eMSSaleAgentDTO = Mapper.Map<EMSSaleAgent, EMSSaleAgentEntity>(eMSSaleAgentDomain);
                eMSSaleAgentDTO.SalesAgentName = Mapper.Map<MEMSSalesAgent, MEMSSalesAgentEntity>(eMSSaleAgentDomain.MEMSSalesAgent);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSSaleAgentDTO;
        }

        /// <summary>
        /// Map and get EMSSaleAppraiser.
        /// </summary>
        /// <param name="EMSSaleAppraiserDomain"></param>
        /// <returns></returns>
        public static EMSSaleAppraiserEntity GetEMSSaleAppraiserEntity(EMSSaleAppraiser eMSSaleAppraiserDomain)
        {
            EMSSaleAppraiserEntity eMSSaleAppraiserDTO = null;

            try
            {
                eMSSaleAppraiserDTO = Mapper.Map<EMSSaleAppraiser, EMSSaleAppraiserEntity>(eMSSaleAppraiserDomain);
                eMSSaleAppraiserDTO.AppraiserName = Mapper.Map<MEMSAppraiser, MEMSAppraiserEntity>(eMSSaleAppraiserDomain.MEMSAppraiser);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSSaleAppraiserDTO;
        }

        /// <summary>
        /// Map and get EMSSaleAppraiser.
        /// </summary>
        /// <param name="EMSSaleAppraiserDomain"></param>
        /// <returns></returns>
        public static EMSSaleAuctioneerEntity GetEMSSaleAuctioneerEntity(EMSSaleAuctioneer eMSSaleAuctioneer)
        {
            EMSSaleAuctioneerEntity eMSSaleAuctioneerDTO = null;

            try
            {
                eMSSaleAuctioneerDTO = Mapper.Map<EMSSaleAuctioneer, EMSSaleAuctioneerEntity>(eMSSaleAuctioneer);
                eMSSaleAuctioneerDTO.MEMSAuctioneer = Mapper.Map<MEMSAuctioneer, MEMSAuctioneerEntity>(eMSSaleAuctioneer.MEMSAuctioneer);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSSaleAuctioneerDTO;
        }

        /// <summary>
        /// Map and get EMSSaleBuyer.
        /// </summary>
        /// <param name="EMSSaleBuyerDomain"></param>
        /// <returns></returns>
        public static EMSSaleBuyerEntity GetEMSSaleBuyerEntity(EMSSaleBuyer eMSSaleBuyerDomain)
        {
            EMSSaleBuyerEntity eMSSaleBuyerDTO = null;

            try
            {
                eMSSaleBuyerDTO = Mapper.Map<EMSSaleBuyer, EMSSaleBuyerEntity>(eMSSaleBuyerDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSSaleBuyerDTO;
        }

        /// <summary>
        /// Map and get EMSSale.
        /// </summary>
        /// <param name="eMSSaleDomain"></param>
        /// <returns></returns>
        public static EMSSaleEntity GetEMSSaleEntity(EMSSale eMSSaleDomain)
        {
            EMSSaleEntity eMSSaleDTO = null;

            try
            {
                eMSSaleDTO = Mapper.Map<EMSSale, EMSSaleEntity>(eMSSaleDomain);
                eMSSaleDTO.MEMSAuctioneer = Mapper.Map<MEMSAuctioneer, MEMSAuctioneerEntity>(eMSSaleDomain.MEMSAuctioneer);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSSaleDTO;
        }

        /// <summary>
        /// Map and get EMSStateFund.
        /// </summary>
        /// <param name="EMSStateFundDomain"></param>
        /// <returns></returns>
        public static EMSStateFundEntity GetEMSStateFundEntity(EMSStateFund eMSStateFundDomain)
        {
            EMSStateFundEntity eMSStateFundDTO = null;

            try
            {
                eMSStateFundDTO = Mapper.Map<EMSStateFund, EMSStateFundEntity>(eMSStateFundDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSStateFundDTO;
        }

        /// <summary>
        /// Map and get EMSTeamMgmt.
        /// </summary>
        /// <param name="EMSTeamMgmtDomain"></param>
        /// <returns></returns>
        public static EMSTeamMgmtEntity GetEMSTeamMgmtEntity(EMSTeamMgmt eMSTeamMgmtDomain)
        {
            EMSTeamMgmtEntity eMSTeamMgmtDTO = null;

            try
            {
                eMSTeamMgmtDTO = Mapper.Map<EMSTeamMgmt, EMSTeamMgmtEntity>(eMSTeamMgmtDomain);
                eMSTeamMgmtDTO.MSection = Mapper.Map<MSection, MSectionEntity>(eMSTeamMgmtDomain.MSection);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSTeamMgmtDTO;
        }

        /// <summary>
        /// Map and get EMSTptClaim.
        /// </summary>
        /// <param name="EMSTptClaimDomain"></param>
        /// <returns></returns>
        public static EMSTptClaimEntity GetEMSTptClaimEntity(EMSTptClaim eMSTptClaimDomain)
        {
            EMSTptClaimEntity eMSTptClaimDTO = null;

            try
            {
                eMSTptClaimDTO = Mapper.Map<EMSTptClaim, EMSTptClaimEntity>(eMSTptClaimDomain);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return eMSTptClaimDTO;
        }

        /// <summary>
        /// Map and get IEnforcementEntity.
        /// </summary>
        /// <param name="iEnforcement"></param>
        /// <returns></returns>
        public static IEnforcementEntity GetEnforcement<T>(T iEnforcement)
        {
            if (iEnforcement.GetType().Equals(typeof(EMSAccount)))
                return EnforcementMapperToDTO.GetEMSAccountEntity(iEnforcement as EMSAccount);
            //else if (iEnforcement.GetType().Equals(typeof(EMSAdmCharge)))
            //    return EnforcementMapperToDTO.GetEMSAdmChargeEntity(iEnforcement as EMSAdmCharge);
            else if (iEnforcement.GetType().Equals(typeof(EMSAdmCharges)))
                return EnforcementMapperToDTO.GetEMSAdmChargesEntity(iEnforcement as EMSAdmCharges);
            else if (iEnforcement.GetType().Equals(typeof(EMSAdmClaim)))
                return EnforcementMapperToDTO.GetEMSAdmClaimEntity(iEnforcement as EMSAdmClaim);
            else if (iEnforcement.GetType().Equals(typeof(EMSAttendanceFee)))
                return EnforcementMapperToDTO.GetEMSAttendanceFeeEntity(iEnforcement as EMSAttendanceFee);
            else if (iEnforcement.GetType().Equals(typeof(EMSAdmExec)))
                return EnforcementMapperToDTO.GetEMSAdmExecEntity(iEnforcement as EMSAdmExec);
            else if (iEnforcement.GetType().Equals(typeof(EMSAdmProperty)))
                return EnforcementMapperToDTO.GetEMSAdmPropertyEntity(iEnforcement as EMSAdmProperty);
            else if (iEnforcement.GetType().Equals(typeof(EMSAdmPropertyList)))
                return EnforcementMapperToDTO.GetEMSAdmPropertyListEntity(iEnforcement as EMSAdmPropertyList);
            else if (iEnforcement.GetType().Equals(typeof(EMSAdmRelease)))
                return EnforcementMapperToDTO.GetEMSAdmReleaseEntity(iEnforcement as EMSAdmRelease);
            else if (iEnforcement.GetType().Equals(typeof(EMSAppointment)))
                return EnforcementMapperToDTO.GetEMSAppointmentEntity(iEnforcement as EMSAppointment);
            else if (iEnforcement.GetType().Equals(typeof(EMSApptDateTime)))
                return EnforcementMapperToDTO.GetEMSApptDateTimeEntity(iEnforcement as EMSApptDateTime);
            else if (iEnforcement.GetType().Equals(typeof(EMSApptDebtor)))
                return EnforcementMapperToDTO.GetEMSApptDebtorEntity(iEnforcement as EMSApptDebtor);
            //else if (iEnforcement.GetType().Equals(typeof(EMSBailiffUnavailability)))
            //    return EnforcementMapperToDTO.GetEMSBailiffUnavailabilityEntity(iEnforcement as EMSBailiffUnavailability);
            else if (iEnforcement.GetType().Equals(typeof(EMSCashBookItem)))
                return EnforcementMapperToDTO.GetEMSCashBookItemEntity(iEnforcement as EMSCashBookItem);
            else if (iEnforcement.GetType().Equals(typeof(EMSCashBookReconcile)))
                return EnforcementMapperToDTO.GetEMSCashBookReconcileEntity(iEnforcement as EMSCashBookReconcile);
            else if (iEnforcement.GetType().Equals(typeof(EMSCheque)))
                return EnforcementMapperToDTO.GetEMSChequeEntity(iEnforcement as EMSCheque);
            else if (iEnforcement.GetType().Equals(typeof(EMSChequeHistory)))
                return EnforcementMapperToDTO.GetEMSChequeHistoryEntity(iEnforcement as EMSChequeHistory);
            else if (iEnforcement.GetType().Equals(typeof(EMSCivCaseAbort)))
                return EnforcementMapperToDTO.GetEMSCivCaseAbortEntity(iEnforcement as EMSCivCaseAbort);
            else if (iEnforcement.GetType().Equals(typeof(EMSCivCrmMissing)))
                return EnforcementMapperToDTO.GetEMSCivCrmMissingEntity(iEnforcement as EMSCivCrmMissing);
            else if (iEnforcement.GetType().Equals(typeof(EMSCivCrmRelease)))
                return EnforcementMapperToDTO.GetEMSCivCrmReleaseEntity(iEnforcement as EMSCivCrmRelease);
            else if (iEnforcement.GetType().Equals(typeof(EMSCivCrmSeizure)))
                return EnforcementMapperToDTO.GetEMSCivCrmSeizureEntity(iEnforcement as EMSCivCrmSeizure);
            else if (iEnforcement.GetType().Equals(typeof(EMSCivCrmSettlement)))
                return EnforcementMapperToDTO.GetEMSCivCrmSettlementEntity(iEnforcement as EMSCivCrmSettlement);
            else if (iEnforcement.GetType().Equals(typeof(EMSCourtCommission)))
                return EnforcementMapperToDTO.GetEMSCourtCommissionEntity(iEnforcement as EMSCourtCommission);
            else if (iEnforcement.GetType().Equals(typeof(EMSCrmCase)))
                return EnforcementMapperToDTO.GetEMSCrmCaseEntity(iEnforcement as EMSCrmCase);
            else if (iEnforcement.GetType().Equals(typeof(EMSCrmCaseExecAddr)))
                return EnforcementMapperToDTO.GetEMSCrmCaseExecAddrEntity(iEnforcement as EMSCrmCaseExecAddr);
            else if (iEnforcement.GetType().Equals(typeof(EMSCrmCaseWLDet)))
                return EnforcementMapperToDTO.GetEMSCrmCaseWLDetEntity(iEnforcement as EMSCrmCaseWLDet);
            else if (iEnforcement.GetType().Equals(typeof(EMSDisburseClaim)))
                return EnforcementMapperToDTO.GetEMSDisburseClaimEntity(iEnforcement as EMSDisburseClaim);
            else if (iEnforcement.GetType().Equals(typeof(EMSExecLedger)))
                return EnforcementMapperToDTO.GetEMSExecLedgerEntity(iEnforcement as EMSExecLedger);
            else if (iEnforcement.GetType().Equals(typeof(EMSFileMovement)))
                return EnforcementMapperToDTO.GetEMSFileMovementEntity(iEnforcement as EMSFileMovement);
            else if (iEnforcement.GetType().Equals(typeof(EMSMiscClaim)))
                return EnforcementMapperToDTO.GetEMSMiscClaimEntity(iEnforcement as EMSMiscClaim);
            else if (iEnforcement.GetType().Equals(typeof(EMSOutstandingPayment)))
                return EnforcementMapperToDTO.GetEMSOutstandingPaymentEntity(iEnforcement as EMSOutstandingPayment);
            else if (iEnforcement.GetType().Equals(typeof(EMSPayment)))
                return EnforcementMapperToDTO.GetEMSPaymentEntity(iEnforcement as EMSPayment);
            else if (iEnforcement.GetType().Equals(typeof(EMSPaymentCheque)))
                return EnforcementMapperToDTO.GetEMSPaymentChequeEntity(iEnforcement as EMSPaymentCheque);
            else if (iEnforcement.GetType().Equals(typeof(EMSPaymentVoucher)))
                return EnforcementMapperToDTO.GetEMSPaymentVoucherEntity(iEnforcement as EMSPaymentVoucher);
            else if (iEnforcement.GetType().Equals(typeof(EMSPaymentVoucherAdm)))
                return EnforcementMapperToDTO.GetEMSPaymentVoucherAdmEntity(iEnforcement as EMSPaymentVoucherAdm);
            else if (iEnforcement.GetType().Equals(typeof(EMSPaymentVoucherCheque)))
                return EnforcementMapperToDTO.GetEMSPaymentVoucherChequeEntity(iEnforcement as EMSPaymentVoucherCheque);
            else if (iEnforcement.GetType().Equals(typeof(EMSPaymentVoucherFinal)))
                return EnforcementMapperToDTO.GetEMSPaymentVoucherFinalEntity(iEnforcement as EMSPaymentVoucherFinal);
            else if (iEnforcement.GetType().Equals(typeof(EMSPaymentVoucherFinalOther)))
                return EnforcementMapperToDTO.GetEMSPaymentVoucherFinalOtherEntity(iEnforcement as EMSPaymentVoucherFinalOther);
            else if (iEnforcement.GetType().Equals(typeof(EMSPaymentVoucherMisc)))
                return EnforcementMapperToDTO.GetEMSPaymentVoucherMiscEntity(iEnforcement as EMSPaymentVoucherMisc);
            else if (iEnforcement.GetType().Equals(typeof(EMSRecapitulation)))
                return EnforcementMapperToDTO.GetEMSRecapitulationEntity(iEnforcement as EMSRecapitulation);
            else if (iEnforcement.GetType().Equals(typeof(EMSRoundRobinAuctioneer)))
                return EnforcementMapperToDTO.GetEMSRoundRobinAuctioneerEntity(iEnforcement as EMSRoundRobinAuctioneer);
            else if (iEnforcement.GetType().Equals(typeof(EMSRecAudit)))
                return EnforcementMapperToDTO.GetEMSRecAuditEntity(iEnforcement as EMSRecAudit);
            else if (iEnforcement.GetType().Equals(typeof(EMSRecChequeAudit)))
                return EnforcementMapperToDTO.GetEMSRecChequeAuditEntity(iEnforcement as EMSRecChequeAudit);
            else if (iEnforcement.GetType().Equals(typeof(EMSReceipt)))
                return EnforcementMapperToDTO.GetEMSReceiptEntity(iEnforcement as EMSReceipt);
            else if (iEnforcement.GetType().Equals(typeof(EMSRecTrans)))
                return EnforcementMapperToDTO.GetEMSRecTransEntity(iEnforcement as EMSRecTrans);
            else if (iEnforcement.GetType().Equals(typeof(EMSSale)))
                return EnforcementMapperToDTO.GetEMSSaleEntity(iEnforcement as EMSSale);
            else if (iEnforcement.GetType().Equals(typeof(EMSSaleAdvert)))
                return EnforcementMapperToDTO.GetEMSSaleAdvertEntity(iEnforcement as EMSSaleAdvert);
            else if (iEnforcement.GetType().Equals(typeof(EMSSaleAgent)))
                return EnforcementMapperToDTO.GetEMSSaleAgentEntity(iEnforcement as EMSSaleAgent);
            else if (iEnforcement.GetType().Equals(typeof(EMSSaleAppraiser)))
                return EnforcementMapperToDTO.GetEMSSaleAppraiserEntity(iEnforcement as EMSSaleAppraiser);
            else if (iEnforcement.GetType().Equals(typeof(EMSSaleAuctioneer)))
                return EnforcementMapperToDTO.GetEMSSaleAuctioneerEntity(iEnforcement as EMSSaleAuctioneer);
            else if (iEnforcement.GetType().Equals(typeof(EMSSaleBuyer)))
                return EnforcementMapperToDTO.GetEMSSaleBuyerEntity(iEnforcement as EMSSaleBuyer);
            //else if (iEnforcement.GetType().Equals(typeof(EMSSerialReceipt)))
            //    return EnforcementMapperToDTO.GetEMSSerialReceiptEntity(iEnforcement as EMSSerialReceipt);
            else if (iEnforcement.GetType().Equals(typeof(EMSStateFund)))
                return EnforcementMapperToDTO.GetEMSStateFundEntity(iEnforcement as EMSStateFund);
            else if (iEnforcement.GetType().Equals(typeof(EMSTeamMgmt)))
                return EnforcementMapperToDTO.GetEMSTeamMgmtEntity(iEnforcement as EMSTeamMgmt);
            else if (iEnforcement.GetType().Equals(typeof(EMSTptClaim)))
                return EnforcementMapperToDTO.GetEMSTptClaimEntity(iEnforcement as EMSTptClaim);
            else if (iEnforcement.GetType().Equals(typeof(Temp_EMSAppointment)))
                return EnforcementMapperToDTO.GetTemp_EMSAppointmentEntity(iEnforcement as Temp_EMSAppointment);
            else if (iEnforcement.GetType().Equals(typeof(EMSADMSaleOthers)))
                return EnforcementMapperToDTO.GetEMSADMSaleOthersEntity(iEnforcement as EMSADMSaleOthers);
            else if (iEnforcement.GetType().Equals(typeof(EMSRecapitDetails)))
                return EnforcementMapperToDTO.GetEMSRecapitDetailsEntity(iEnforcement as EMSRecapitDetails);
            else if (iEnforcement.GetType().Equals(typeof(EMSRecapitulation)))
                return EnforcementMapperToDTO.GetEMSRecapitulationEntity(iEnforcement as EMSRecapitulation);

            throw new Exception("No Automatic Mapper for this entity (" + iEnforcement.GetType().ToString() + ")");
        }

        ///// <summary>
        ///// Map and get JudicialUser.
        ///// </summary>
        ///// <param name="judicialUserDomain"></param>
        ///// <returns></returns>
        //public static JudicialUserEntity GetJudicialUserEntity(JudicialUser judicialUserDomain)
        //{
        //    JudicialUserEntity judicialUserDTO = null;
        //    try
        //    {
        //        judicialUserDTO = Mapper.Map<JudicialUser, JudicialUserEntity>(judicialUserDomain);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    return judicialUserDTO;
        //}
        /// <summary>
        /// Map and get LawFirm.
        /// </summary>
        /// <param name="lawFirm"></param>
        /// <returns></returns>
        public static LawFirmEntity GetLawFirmEntity(LawFirm lawFirm)
        {
            LawFirmEntity lawFirmDTO = null;

            try
            {
                lawFirmDTO = Mapper.Map<LawFirm, LawFirmEntity>(lawFirm);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return lawFirmDTO;
        }

        /// <summary>
        /// Map and get Temp_EMSAppointment.
        /// </summary>
        /// <param name="Temp_EMSAppointment"></param>
        /// <returns></returns>
        public static Temp_EMSAppointmentEntity GetTemp_EMSAppointmentEntity(Temp_EMSAppointment temp_EMSAppointment)
        {
            Temp_EMSAppointmentEntity temp_EMSAppointmentEntity = null;

            try
            {
                temp_EMSAppointmentEntity = Mapper.Map<Temp_EMSAppointment, Temp_EMSAppointmentEntity>(temp_EMSAppointment);
            }
            catch (Exception ex)
            {
                Logger.Debug("EnforcementMapperToDomain. Message - " + ex.Message + ", Stack Trace - " + ex.StackTrace, ex);
                throw;
            }

            return temp_EMSAppointmentEntity;
        }

        #endregion Methods
    }
}