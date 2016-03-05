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
// File: EnforcementMapping.cs
// Description: his file represents a object to object mapping for Enforcement entities.
// </summary>
// <copyright file= "EnforcementMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Enforcement;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    internal class EnforcementMappingToDTO
    {
        #region Methods
        
        /// <summary>
        /// Map EMSAccount DTOs to EMSAccount Domain
        /// </summary>
        internal void MapEMSAccountToEMSAccountEntity()
        {
            Mapper.CreateMap<EMSAccount, EMSAccountEntity>()
                .ForMember(desc => desc.EMSType, opt => opt.MapFrom(src => src.EMSType))
                .ForMember(desc => desc.BailiffId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.JudicialUser)))
                .ForMember(desc => desc.CaseInfoId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetCaseInfoId(src.CaseInfo)))
                .ForMember(desc => desc.SubCaseInfoId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetSubCaseInfoId(src.SubCaseInfo)))
                .ForMember(desc => desc.SyncRequired, opt => opt.MapFrom(src => src.SyncRequired))
                ;
        }

        ///// <summary>
        ///// Map EMSAdmCharge DTOs to EMSAdmCharge Domain
        ///// </summary>
        //internal void MapEMSAdmChargeToEMSAdmChargeEntity()
        //{
        //    Mapper.CreateMap<EMSAdmCharge, EMSAdmChargeEntity>()
        //        .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
        //        .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))//CR-ENFUAT-2012071001 - Mantis: 0005505
        //        ;
        //}

        /// <summary>
        /// Map EMSAdmCharge DTOs to EMSAdmCharge Domain
        /// </summary>
        internal void MapEMSAdmChargesToEMSAdmChargesEntity()
        {//CR-ENFUAT-2012071001 - Mantis: 0005505
            Mapper.CreateMap<EMSAdmCharges, EMSAdmChargesEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))
                .ForMember(desc => desc.EMSSaleId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSSaleId(src.EMSSale)))
                ;
        }

        /// <summary>
        /// Map EMSAdmClaim DTOs to EMSAdmClaim Domain
        /// </summary>
        internal void MapEMSAdmClaimToEMSAdmClaimEntity()
        {
            Mapper.CreateMap<EMSAdmClaim, EMSAdmClaimEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.BailiffId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.Bailiff)))
                .ForMember(desc => desc.EMSAdmExecId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAdmExecId(src.EMSAdmExec)))
                .ForMember(desc => desc.EMSAdmReleaseId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAdmReleaseId(src.EMSAdmRelease)))
                .ForMember(desc => desc.EMSSaleId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSSaleId(src.EMSSale)))
                .ForMember(desc => desc.PaymentVoucherId , opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))
                ;
        }

        /// <summary>
        /// Map EMSAdmCharge DTOs to EMSAttendanceFee Domain
        /// </summary>
        internal void MapEMSAttendanceFeeToEMSAttendanceFeeEntity()
        {//CR-ENFUAT-2012071001 - Mantis: 0005505
            Mapper.CreateMap<EMSAttendanceFee, EMSAttendanceFeeEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))
                .ForMember(desc => desc.EMSAppointmentId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAppointmentId(src.EMSAppointment)))
                ;
        }

        /// <summary>
        /// Map EMSAdmExec DTOs to EMSAdmExec Domain
        /// </summary>
        internal void MapEMSAdmExecToEMSAdmExecEntity()
        {
            Mapper.CreateMap<EMSAdmExec, EMSAdmExecEntity>()
                .ForMember(desc => desc.BailiffId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.Bailiff)))
                .ForMember(desc => desc.EMSAdmPropertyId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAdmPropertyId(src.EMSAdmProperty)))
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc=>desc.SyncRequired,opts=>opts.MapFrom(src=>src.SyncRequired))
                ;
        }

        /// <summary>
        /// Map EMSAdmPropertyList DTOs to EMSAdmPropertyList Domain
        /// </summary>
        internal void MapEMSAdmPropertyListToEMSAdmPropertyListEntity()
        {
            Mapper.CreateMap<EMSAdmPropertyList, EMSAdmPropertyListEntity>()
                .ForMember(desc => desc.EMSAdmPropertyId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAdmPropertyId(src.EMSAdmProperty)))
                ;
        }

        /// <summary>
        /// Map EMSAdmProperty DTOs to EMSAdmProperty Domain
        /// </summary>
        internal void MapEMSAdmPropertyToEMSAdmPropertyEntity()
        {
            Mapper.CreateMap<EMSAdmProperty, EMSAdmPropertyEntity>()
                ;
        }

        /// <summary>
        /// Map EMSAdmRelease DTOs to EMSAdmRelease Domain
        /// </summary>
        internal void MapEMSAdmReleaseToEMSAdmReleaseEntity()
        {
            Mapper.CreateMap<EMSAdmRelease, EMSAdmReleaseEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.EMSReceiptId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSReceiptId(src.EMSReceipt)))
                .ForMember(desc => desc.EMSAdmPropertyId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAdmPropertyId(src.EMSAdmProperty)))
                .ForMember(desc => desc.ReleaseRequester, opt => opt.MapFrom(src => src.ReleaseRequester))
                .ForMember(desc => desc.SyncRequired, opt => opt.MapFrom(src => src.SyncRequired))
                ;
        }

        /// <summary>
        /// Map EMSADMSaleOthers DTOs to EMSADMSaleOthers Domain
        /// </summary>
        internal void MapEMSADMSaleOthersToEMSADMSaleOthersEntity()
        {
            Mapper.CreateMap<EMSADMSaleOthers, EMSADMSaleOthersEntity>()
                .ForMember(desc => desc.EMSSaleId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSSaleId(src.EMSSale)))
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))
                ;
        }

        /// <summary>
        /// Map EMSAppointment DTOs to EMSAppointment Domain
        /// </summary>
        internal void MapEMSAppointmentToEMSAppointmentEntity()
        {
            Mapper.CreateMap<EMSAppointment, EMSAppointmentEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.BailiffId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.Bailiff)))
                .ForMember(desc => desc.SyncRequired, opt => opt.MapFrom(src => src.SyncRequired))

                ;
        }

        /// <summary>
        /// Map EMSApptDateTime DTOs to EMSApptDateTime Domain
        /// </summary>
        internal void MapEMSApptDateTimeToEMSApptDateTimeEntity()
        {
            Mapper.CreateMap<EMSApptDateTime, EMSApptDateTimeEntity>()
                .ForMember(desc => desc.EMSAppointmentId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAppointmentId(src.EMSAppointment)))
                ;
        }

        /// <summary>
        /// Map EMSApptDebtor DTOs to EMSApptDebtor Domain
        /// </summary>
        internal void MapEMSApptDebtorToEMSApptDebtorEntity()
        {
            Mapper.CreateMap<EMSApptDebtor, EMSApptDebtorEntity>()
                .ForMember(desc => desc.EMSAppointmentId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAppointmentId(src.EMSAppointment)))
                .ForMember(desc => desc.CasePartyId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetCasePartyId(src.CaseParty)))
                ;
        }

        /// <summary>
        /// Map EMSBailiffUnavailability DTOs to EMSBailiffUnavailability Domain
        /// </summary>
        internal void MapEMSBailiffUnavailabilityToEMSBailiffUnavailabilityEntity()
        {
            Mapper.CreateMap<EMSBailiffUnavailability, EMSBailiffUnavailabilityEntity>()
                .ForMember(desc => desc.BailiffId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.Bailiff)))
                ;
        }

        /// <summary>
        /// Map EMSCashBookItem DTOs to EMSCashBookItem Domain
        /// </summary>
        internal void MapEMSCashBookItemToEMSCashBookItemEntity()
        {
            Mapper.CreateMap<EMSCashBookItem, EMSCashBookItemEntity>()
                .ForMember(desc => desc.EMSCashBookReconcileId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSCashBookReconcileId(src.EMSCashBookReconcile)))
                ;
        }

        /// <summary>
        /// Map EMSCashBookItem DTOs to EMSCashBookItem Domain
        /// </summary>
        internal void MapEMSCashBookReconcileToEMSCashBookReconcileEntity()
        {
            Mapper.CreateMap<EMSCashBookReconcile, EMSCashBookReconcileEntity>()

                ;
        }

        /// <summary>
        /// Map EMSChequeHistory DTOs to EMSChequeHistory Domain
        /// </summary>
        internal void MapEMSChequeHistoryToEMSChequeHistoryEntity()
        {
            Mapper.CreateMap<EMSChequeHistory, EMSChequeHistoryEntity>()
                .ForMember(desc => desc.EMSChequeId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSChequeId(src.EMSCheque)))
                .ForMember(desc => desc.OrgPaymentOfficerID, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.OrgPaymentOfficer)))
                ;
        }

        /// <summary>
        /// Map EMSCheque DTOs to EMSCheque Domain
        /// </summary>
        internal void MapEMSChequeToEMSChequeEntity()
        {
            Mapper.CreateMap<EMSCheque, EMSChequeEntity>()
                .ForMember(desc => desc.PaymentOfficerID, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.PaymentOfficer)))
                ;
        }

        /// <summary>
        /// Map EMSCivCaseAbort DTOs to EMSCivCaseAbort Domain
        /// </summary>
        internal void MapEMSCivCaseAbortToEMSCivCaseAbortEntity()
        {
            Mapper.CreateMap<EMSCivCaseAbort, EMSCivCaseAbortEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                ;
        }

        /// <summary>
        /// Map EMSCivCrmMissing DTOs to EMSCivCrmMissing Domain
        /// </summary>
        internal void MapEMSCivCrmMissingToEMSCivCrmMissingEntity()
        {
            Mapper.CreateMap<EMSCivCrmMissing, EMSCivCrmMissingEntity>()
                .ForMember(desc => desc.EMSCivCrmSeizureId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSCivCrmSeizureId(src.EMSCivCrmSeizure)))
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.DRId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.User)))
                ;
        }

        /// <summary>
        /// Map EMSCivCrmRelease DTOs to EMSCivCrmRelease Domain
        /// </summary>
        internal void MapEMSCivCrmReleaseToEMSCivCrmReleaseEntity()
        {
            Mapper.CreateMap<EMSCivCrmRelease, EMSCivCrmReleaseEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.SyncRequired, opts => opts.MapFrom(src => src.SyncRequired))
                ;
        }

        /// <summary>
        /// Map EMSCivCrmSeizure DTOs to EMSCivCrmSeizure Domain
        /// </summary>
        internal void MapEMSCivCrmSeizureToEMSCivCrmSeizureEntity()
        {
            Mapper.CreateMap<EMSCivCrmSeizure, EMSCivCrmSeizureEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.EMSAppointmentId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAppointmentId(src.EMSAppointment)))
                ;
        }

        /// <summary>
        /// Map EMSCivCrmSettlement DTOs to EMSCivCrmSettlement Domain
        /// </summary>
        internal void MapEMSCivCrmSettlementToEMSCivCrmSettlementEntity()
        {
            Mapper.CreateMap<EMSCivCrmSettlement, EMSCivCrmSettlementEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.EMSAppointmentId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAppointmentId(src.EMSAppointment)))
                .ForMember(desc => desc.CasePartyId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetCasePartyId(src.CaseParty)))
                ;
        }

        /// <summary>
        /// Map EMSCourtCommission DTOs to EMSCourtCommission Domain
        /// </summary>
        internal void MapEMSCourtCommissionToEMSCourtCommissionEntity()
        {
            Mapper.CreateMap<EMSCourtCommission, EMSCourtCommissionEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))
                ;
        }

        /// <summary>
        /// Map EMSCrmCaseExecAddr DTOs to EMSCrmCaseExecAddr Domain
        /// </summary>
        internal void MapEMSCrmCaseExecAddrToEMSCrmCaseExecAddrEntity()
        {
            Mapper.CreateMap<EMSCrmCaseExecAddr, EMSCrmCaseExecAddrEntity>()
                .ForMember(desc => desc.EMSCrmCaseId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSCrmCaseId(src.EMSCrmCase)))
                ;
        }

        /// <summary>
        /// Map EMSCrmCase DTOs to EMSCrmCase Domain
        /// </summary>
        internal void MapEMSCrmCaseToEMSCrmCaseEntity()
        {
            Mapper.CreateMap<EMSCrmCase, EMSCrmCaseEntity>()
                .ForMember(desc => desc.CaseInfoId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetCaseInfoId(src.CaseInfo)))
                .ForMember(desc => desc.CasePartyId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetCasePartyId(src.CaseParty)))
                ;
        }

        /// <summary>
        /// Map EMSCrmCaseWLDet DTOs to EMSCrmCaseWLDet Domain
        /// </summary>
        internal void MapEMSCrmCaseWLDetToEMSCrmCaseWLDetEntity()
        {
            Mapper.CreateMap<EMSCrmCaseWLDet, EMSCrmCaseWLDetEntity>()
                .ForMember(desc => desc.EMSCrmCaseId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSCrmCaseId(src.EMSCrmCase)))
                ;
        }

        /// <summary>
        /// Map EMSDisburseClaim DTOs to EMSDisburseClaim Domain
        /// </summary>
        internal void MapEMSDisburseClaimToEMSDisburseClaimEntity()
        {
            Mapper.CreateMap<EMSDisburseClaim, EMSDisburseClaimEntity>()
                .ForMember(desc => desc.BailiffId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.Bailiff)))
                .ForMember(desc => desc.EMSApptDateTimeId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSApptDateTimeId(src.EMSApptDateTime)))
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))
                ;
        }

        /// <summary>
        /// Map EMSExecLedger DTOs to EMSExecLedger Domain
        /// </summary>
        internal void MapEMSExecLedgerToEMSExecLedgerEntity()
        {
            Mapper.CreateMap<EMSExecLedger, EMSExecLedgerEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.EMSPaymentId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentId(src.EMSPayment)))
                .ForMember(desc => desc.EMSRecTransId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSRecTransId(src.EMSRecTrans)))
                ;
        }

        /// <summary>
        /// Map EMSFileMovement DTOs to EMSFileMovement Domain
        /// </summary>
        internal void MapEMSFileMovementToEMSFileMovementEntity()
        {
            Mapper.CreateMap<EMSFileMovement, EMSFileMovementEntity>()
                .ForMember(desc => desc.UpdatedByUserId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.UpdatedBy)))
                .ForMember(desc => desc.BailiffId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.Bailiff)))
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                ;
        }

        /// <summary>
        /// Map EMSMiscClaim DTOs to EMSMiscClaim Domain
        /// </summary>
        internal void MapEMSMiscClaimToEMSMiscClaimEntity()
        {
            Mapper.CreateMap<EMSMiscClaim, EMSMiscClaimEntity>()
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))
                .ForMember(desc => desc.EMSAppointmentId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAppointmentId(src.EMSAppointment)))
                .ForMember(desc => desc.BailiffId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.Bailiff)))
                ;
        }

        /// <summary>
        /// Map EMSOutstandingPayment DTOs to EMSOutstandingPayment Domain
        /// </summary>
        internal void MapEMSOutstandingPaymentToEMSOutstandingPaymentEntity()
        {
            Mapper.CreateMap<EMSOutstandingPayment, EMSOutstandingPaymentEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                ;
        }

        /// <summary>
        /// Map EMSPaymentCheque DTOs to EMSPaymentCheque Domain
        /// </summary>
        internal void MapEMSPaymentChequeToEMSPaymentChequeEntity()
        {
            Mapper.CreateMap<EMSPaymentCheque, EMSPaymentChequeEntity>()
                .ForMember(desc => desc.EMSChequeId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSChequeId(src.EMSCheque)))
                .ForMember(desc => desc.EMSPaymentId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentId(src.EMSPayment)))
                ;
        }

        /// <summary>
        /// Map EMSPayment DTOs to EMSPayment Domain
        /// </summary>
        internal void MapEMSPaymentToEMSPaymentEntity()
        {
            Mapper.CreateMap<EMSPayment, EMSPaymentEntity>()
                .ForMember(desc => desc.PaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))
                ;
        }

        /// <summary>
        /// Map EMSPaymentVoucherAdm DTOs to EMSPaymentVoucherAdm Domain
        /// </summary>
        internal void MapEMSPaymentVoucherAdmToEMSPaymentVoucherAdmEntity()
        {
            Mapper.CreateMap<EMSPaymentVoucherAdm, EMSPaymentVoucherAdmEntity>()
                .ForMember(desc => desc.EMSPaymentVoucherFinalId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherFinalId(src.EMSPaymentVoucherFinal)))
                .ForMember(desc => desc.EMSAdmChargeId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAdmChargeId(src.EMSAdmCharge)))
                ;
        }

        /// <summary>
        /// Map EMSPaymentVoucherCheque DTOs to EMSPaymentVoucherCheque Domain
        /// </summary>
        internal void MapEMSPaymentVoucherChequeToEMSPaymentVoucherChequeEntity()
        {
            Mapper.CreateMap<EMSPaymentVoucherCheque, EMSPaymentVoucherChequeEntity>()
                .ForMember(desc => desc.EMSPaymentId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentId(src.EMSPayment)))
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))
                ;
        }

        /// <summary>
        /// Map EMSPaymentVoucherFinalOther DTOs to EMSPaymentVoucherFinalOther Domain
        /// </summary>
        internal void MapEMSPaymentVoucherFinalOtherToEMSPaymentVoucherFinalOtherEntity()
        {
            Mapper.CreateMap<EMSPaymentVoucherFinalOther, EMSPaymentVoucherFinalOtherEntity>()
                //.ForMember(desc => desc.EMSPaymentVoucherFinalId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherFinalId(src.EMSPaymentVoucherFinal)))
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))
                .ForMember(desc => desc.CasePartyId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetCasePartyId(src.CaseParty)))
                ;
        }

        /// <summary>
        /// Map EMSPaymentVoucherFinal DTOs to EMSPaymentVoucherFinal Domain
        /// </summary>
        internal void MapEMSPaymentVoucherFinalToEMSPaymentVoucherFinalEntity()
        {
            Mapper.CreateMap<EMSPaymentVoucherFinal, EMSPaymentVoucherFinalEntity>()
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))
                .ForMember(desc => desc.CasePartyId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetCasePartyId(src.CaseParty)))
                .ForMember(desc => desc.LFId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetLawFirmId(src.LawFirm)))
                ;
        }

        /// <summary>
        /// Map EMSPaymentVoucherMisc DTOs to EMSPaymentVoucherMisc Domain
        /// </summary>
        internal void MapEMSPaymentVoucherMiscToEMSPaymentVoucherMiscEntity()
        {
            Mapper.CreateMap<EMSPaymentVoucherMisc, EMSPaymentVoucherMiscEntity>()
                .ForMember(desc => desc.EMSPaymentVoucherFinalId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherFinalId(src.EMSPaymentVoucherFinal)))
                ;
        }

        /// <summary>
        /// Map EMSPaymentVoucher DTOs to EMSPaymentVoucher Domain
        /// </summary>
        internal void MapEMSPaymentVoucherToEMSPaymentVoucherEntity()
        {
            Mapper.CreateMap<EMSPaymentVoucher, EMSPaymentVoucherEntity>()
                .ForMember(desc => desc.BailiffId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.Bailiff)))
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src =>EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                ;
        }

        /// <summary>
        /// Map EMSRecapitDetails DTOs to EMSRecapitDetails Domain
        /// </summary>
        internal void MapEMSRecapitDetailsToEMSRecapitDetailsEntity()
        {
            Mapper.CreateMap<EMSRecapitDetails, EMSRecapitDetailsEntity>()
                .ForMember(desc => desc.LastTransUserId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.LastTransUser)))
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.EMSRecapitulationId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GeteMSRecapitulationId(src.EMSRecapitulation)))
                ;
        }

        /// <summary>
        /// Map EMSRecapitulation DTOs to EMSRecapitulation Domain
        /// </summary>
        internal void MapEMSRecapitulationToEMSRecapitulationEntity()
        {
            Mapper.CreateMap<EMSRecapitulation, EMSRecapitulationEntity>()
                ;
        }

        /// <summary>
        /// Map EMSReceipt DTOs to EMSRecAudit Domain
        /// </summary>
        internal void MapEMSRecAuditToEMSRecAuditEntity()
        {
            Mapper.CreateMap<EMSRecAudit, EMSRecAuditEntity>()
                .ForMember(desc => desc.EMSReceiptId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSReceiptId(src.EMSReceipt)))
                ;
        }

        /// <summary>
        /// Map EMSRecChequeAudit DTOs to EMSRecChequeAudit Domain
        /// </summary>
        internal void MapEMSRecChequeAuditToEMSRecChequeAuditEntity()
        {
            Mapper.CreateMap<EMSRecChequeAudit, EMSRecChequeAuditEntity>()
                .ForMember(desc => desc.EMSRecTransId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSRecTransId(src.EMSRecTrans)))
                ;
        }

        /// <summary>
        /// Map EMSReceipt DTOs to EMSReceipt Domain
        /// </summary>
        internal void MapEMSReceiptToEMSReceiptEntity()
        {
            Mapper.CreateMap<EMSReceipt, EMSReceiptEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.CashierId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.Cashier)))
                ;
        }

        /// <summary>
        /// Map EMSRecTrans DTOs to EMSRecTrans Domain
        /// </summary>
        internal void MapEMSRecTransToEMSRecTransEntity()
        {
            Mapper.CreateMap<EMSRecTrans, EMSRecTransEntity>()
                .ForMember(desc => desc.EMSReceiptId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSReceiptId(src.EMSReceipt)))
                ;
        }

        /// <summary>
        /// Map EMSRoundRobinAuctioneer DTOs to EMSRoundRobinAuctioneer Domain
        /// </summary>
        internal void MapEMSRoundRobinAuctioneerToEMSRoundRobinAuctioneerEntity()
        {
            Mapper.CreateMap<EMSRoundRobinAuctioneer, EMSRoundRobinAuctioneerEntity>()
                ;
        }

        /// <summary>
        /// Map EMSSaleAdvert DTOs to EMSSaleAdvert Domain
        /// </summary>
        internal void MapEMSSaleAdvertToEMSSaleAdvertEntity()
        {
            Mapper.CreateMap<EMSSaleAdvert, EMSSaleAdvertEntity>()
                .ForMember(desc => desc.EMSSaleId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSSaleId(src.EMSSale)))
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))//CR-ENFUAT-2012071001 - Mantis: 0005505
                ;
        }

        /// <summary>
        /// Map EMSSaleAgent DTOs to EMSSaleAgent Domain
        /// </summary>
        internal void MapEMSSaleAgentToEMSSaleAgentEntity()
        {
            Mapper.CreateMap<EMSSaleAgent, EMSSaleAgentEntity>()
                .ForMember(desc => desc.EMSSaleId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSSaleId(src.EMSSale)))
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))//CR-ENFUAT-2012071001 - Mantis: 0005505
                ;
        }

        /// <summary>
        /// Map EMSSaleAppraiser DTOs to EMSSaleAppraiser Domain
        /// </summary>
        internal void MapEMSSaleAppraiserToEMSSaleAppraiserEntity()
        {
            Mapper.CreateMap<EMSSaleAppraiser, EMSSaleAppraiserEntity>()
                .ForMember(desc => desc.EMSSaleId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSSaleId(src.EMSSale)))
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))//CR-ENFUAT-2012071001 - Mantis: 0005505
                ;
        }

        /// <summary>
        /// Map EMSSaleAuctioneer DTOs to EMSSaleAuctioneer Domain
        /// </summary>
        internal void MapEMSSaleAuctioneerToEMSSaleAuctioneerEntity()
        {
            Mapper.CreateMap<EMSSaleAuctioneer, EMSSaleAuctioneerEntity>()
                .ForMember(desc => desc.EMSSaleId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSSaleId(src.EMSSale)))
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))
                ;
        }

        /// <summary>
        /// Map EMSSaleBuyer DTOs to EMSSaleBuyer Domain
        /// </summary>
        internal void MapEMSSaleBuyerToEMSSaleBuyerEntity()
        {
            Mapper.CreateMap<EMSSaleBuyer, EMSSaleBuyerEntity>()
                .ForMember(desc => desc.EMSSaleId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSSaleId(src.EMSSale)))
                ;
        }

        /// <summary>
        /// Map EMSSale DTOs to EMSSale Domain
        /// </summary>
        internal void MapEMSSaleToEMSSaleEntity()
        {
            Mapper.CreateMap<EMSSale, EMSSaleEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => src.EMSAccount.EMSAccountId))
                .ForMember(desc => desc.EMSAdmPropertyId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAdmPropertyId(src.EMSAdmProperty)))
                .ForMember(desc => desc.EMSAppointmentId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAppointmentId(src.EMSAppointment)))
                //.ForMember(desc => desc.EMSAdmChargeId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAdmChargeId(src.EMSAdmCharge)))
                .ForMember(dest => dest.SyncRequired, opts => opts.MapFrom(src => src.SyncRequired));
                ;
        }

        /// <summary>
        /// Map EMSStateFund DTOs to EMSStateFund Domain
        /// </summary>
        internal void MapEMSStateFundToEMSStateFundEntity()
        {
            Mapper.CreateMap<EMSStateFund, EMSStateFundEntity>()
                .ForMember(desc => desc.EMSAccountId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAccountId(src.EMSAccount)))
                .ForMember(desc => desc.EMSChequeId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSChequeId(src.EMSCheque)))
                ;
        }

        /// <summary>
        /// Map EMSTeamMgmt DTOs to EMSTeamMgmt Domain
        /// </summary>
        internal void MapEMSTeamMgmtToEMSTeamMgmtEntity()
        {
            Mapper.CreateMap<EMSTeamMgmt, EMSTeamMgmtEntity>()
                ;
        }

        /// <summary>
        /// Map EMSTptClaim DTOs to EMSTptClaim Domain
        /// </summary>
        internal void MapEMSTptClaimToEMSTptClaimEntity()
        {
            Mapper.CreateMap<EMSTptClaim, EMSTptClaimEntity>()
                .ForMember(desc => desc.BailiffId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetJudicialUserId(src.Bailiff)))
                .ForMember(desc => desc.EMSAppointmentId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSAppointmentId(src.EMSAppointment)))
                .ForMember(desc => desc.EMSPaymentVoucherId, opt => opt.MapFrom(src => EnfrocementMappingToDTOHelper.GetEMSPaymentVoucherId(src.EMSPaymentVoucher)))
                ;
        }

        internal void MapLawFirmToLawFirmEntity()
        {
            Mapper.CreateMap<LawFirm, LawFirmEntity>()
                   ;
        }

        /// <summary>
        /// Map Temp_EMSAppointment DTOs to Temp_EMSAppointment Domain
        /// </summary>
        internal void MapTemp_EMSAppointmentToTemp_EMSAppointmentEntity()
        {
            Mapper.CreateMap<Temp_EMSAppointment, Temp_EMSAppointmentEntity>()
                ;
        }

        #endregion Methods
    }

    internal class EnfrocementMappingToDTOHelper
    {
        #region Methods

        internal static string GetCaseInfoId(CaseInfo caseInfo)
        {
            if (caseInfo == null)
                return string.Empty;
            else
                return caseInfo.CaseInfoId.ToString();
        }

        internal static string GetCasePartyId(CaseParty caseParty)
        {
            if (caseParty == null)
                return string.Empty;
            else
                return caseParty.CasePartyId.ToString();
        }

        internal static string GetEMSAccountId(EMSAccount eMSAccount)
        {
            if (eMSAccount == null)
                return string.Empty;
            else
                return eMSAccount.EMSAccountId;
        }

        internal static string GetEMSAdmChargeId(EMSAdmCharge eMSAdmCharge)
        {
            if (eMSAdmCharge == null)
                return string.Empty;
            else
                return eMSAdmCharge.EMSAdmChargeId;
        }

        internal static string GetEMSAdmExecId(EMSAdmExec eMSAdmExec)
        {
            if (eMSAdmExec == null)
                return string.Empty;
            else
                return eMSAdmExec.EMSAdmExecId;
        }

        internal static string GetEMSAdmPropertyId(EMSAdmProperty eMSAdmProperty)
        {
            if (eMSAdmProperty == null)
                return string.Empty;
            else
                return eMSAdmProperty.EMSAdmPropertyId;
        }

        internal static string GetEMSAdmReleaseId(EMSAdmRelease eMSAdmRelease)
        {
            if (eMSAdmRelease == null)
                return string.Empty;
            else
                return eMSAdmRelease.EMSAdmReleaseId;
        }

        internal static string GetEMSAppointmentId(EMSAppointment eMSAppointment)
        {
            if (eMSAppointment == null)
                return string.Empty;
            else
                return eMSAppointment.EMSAppointmentId;
        }

        internal static string GetEMSApptDateTimeId(EMSApptDateTime eMSApptDateTime)
        {
            if (eMSApptDateTime == null)
                return string.Empty;
            else
                return eMSApptDateTime.EMSApptDateTimeId;
        }

        internal static string GetEMSCashBookReconcileId(EMSCashBookReconcile eMSCashBookReconcile)
        {
            if (eMSCashBookReconcile == null)
                return string.Empty;
            else
                return eMSCashBookReconcile.EMSCashBookReconcileId;
        }

        internal static string GetEMSChequeId(EMSCheque eMSCheque)
        {
            if (eMSCheque == null)
                return string.Empty;
            else
                return eMSCheque.EMSChequeId;
        }

        internal static string GetEMSCivCrmSeizureId(EMSCivCrmSeizure eMSCivCrmSeizure)
        {
            if (eMSCivCrmSeizure == null)
                return string.Empty;
            else
                return eMSCivCrmSeizure.EMSCivCrmSeizureId;
        }

        internal static string GetEMSCrmCaseId(EMSCrmCase eMSCrmCase)
        {
            if (eMSCrmCase == null)
                return string.Empty;
            else
                return eMSCrmCase.EMSCrmCaseId;
        }

        internal static string GetEMSPaymentId(EMSPayment eMSPayment)
        {
            if (eMSPayment == null)
                return string.Empty;
            else
                return eMSPayment.EMSPaymentId;
        }

        internal static string GetEMSPaymentVoucherFinalId(EMSPaymentVoucherFinal eMSPaymentVoucherFinal)
        {
            if (eMSPaymentVoucherFinal == null)
                return string.Empty;
            else
                return eMSPaymentVoucherFinal.EMSPaymentVoucherFinalId;
        }

        internal static string GetEMSPaymentVoucherId(EMSPaymentVoucher eMSPaymentVoucher)
        {
            if (eMSPaymentVoucher == null)
                return string.Empty;
            else
                return eMSPaymentVoucher.EMSPaymentVoucherId;
        }

        internal static string GeteMSRecapitulationId(EMSRecapitulation eMSRecapitulation)
        {
            if (eMSRecapitulation == null)
                return string.Empty;
            else
                return eMSRecapitulation.EMSRecapitulationId;
        }

        internal static string GetEMSReceiptId(EMSReceipt eMSReceipt)
        {
            if (eMSReceipt == null)
                return string.Empty;
            else
                return eMSReceipt.EMSReceiptId;
        }

        internal static string GetEMSRecTransId(EMSRecTrans eMSRecTrans)
        {
            if (eMSRecTrans == null)
                return string.Empty;
            else
                return eMSRecTrans.EMSRecTransId;
        }

        internal static string GetEMSSaleId(EMSSale eMSSale)
        {
            if (eMSSale == null)
                return string.Empty;
            else
                return eMSSale.EMSSaleId;
        }

        internal static string GetJudicialUserId(JudicialUser judicialUser)
        {
            if (judicialUser == null)
                return string.Empty;
            else
                return judicialUser.UserId;
        }

        internal static string GetLawFirmId(LawFirm lawFirm)
        {
            if (lawFirm == null)
                return string.Empty;
            else
                return lawFirm.LFID;
        }

        internal static string GetSubCaseInfoId(SubCaseInfo subCaseInfo)
        {
            if (subCaseInfo == null)
                return string.Empty;
            else
                return subCaseInfo.SubCaseInfoId.ToString();
        }

        internal static string GetSubCasePartyId(SubCaseParty subCaseParty)
        {
            if (subCaseParty == null)
                return string.Empty;
            else
                return subCaseParty.SubCasePartyId.ToString();
        }

        #endregion Methods
    }
}