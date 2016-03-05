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
// File: EnforcementMapping.cs
// Description: his file represents a object to object mapping for Enforcement entities.
// </summary>
// <copyright file= "EnforcementMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
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

    internal class EnforcementMappingToDomain
    {
        #region Methods

        /// <summary>
        /// Map EMSAccount DTOs to EMSAccount Domain
        /// </summary>
        internal void MapEMSAccountEntityToEMSAccount()
        {
            Mapper.CreateMap<EMSAccountEntity, EMSAccount>()
                .ForMember(desc => desc.EMSType, opt => opt.ResolveUsing<EMSTypeToStringResolver>().FromMember(src => src.EMSType))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(dest => dest.SubCaseInfo, opts => opts.ResolveUsing<StringToSubCaseInfoResolver>().FromMember(src => src.SubCaseInfoId))
                .ForMember(dest => dest.JudicialUser, opts => opts.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.BailiffId))
                .ForMember(dest => dest.CaseInfo, opts => opts.ResolveUsing<StringToCaseInfoResolver>().FromMember(src => src.CaseInfoId))
                .ForMember(desc => desc.IsOnHold, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsOnHold))
                .ForMember(desc => desc.IsWaiver, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsWaiver))
                .ForMember(desc => desc.IsWSeizure, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsWSeizure))
                .ForMember(desc => desc.IsUrgent, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsUrgent))
                .ForMember(desc => desc.SyncRequired, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SyncRequired))
                ;
        }

        ///// <summary>
        ///// Map EMSAdmCharge DTOs to EMSAdmCharge Domain
        ///// </summary>
        //internal void MapEMSAdmChargeEntityToEMSAdmCharge()
        //{
        //    Mapper.CreateMap<EMSAdmChargeEntity, EMSAdmCharge>()
        //        .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
        //        .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))//CR-ENFUAT-2012071001 - Mantis: 0005505
        //        .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
        //        .ForMember(desc => desc.IsCharged, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCharged))
        //        ;
        //}

        /// <summary>
        /// Map EMSAdmCharges DTOs to EMSAdmCharges Domain
        /// </summary>
        internal void MapEMSAdmChargesEntityToEMSAdmCharges()
        {
            Mapper.CreateMap<EMSAdmChargesEntity, EMSAdmCharges>()
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))//CR-ENFUAT-2012071001 - Mantis: 0005505
                .ForMember(desc => desc.EMSSale, opt => opt.ResolveUsing<StringToEMSSaleResolver>().FromMember(src => src.EMSSaleId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.IsCharged, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCharged))
                .ForMember(desc => desc.ChargesType, opt => opt.ResolveUsing<AdmChargeTypeToStringResolver>().FromMember(src => src.ChargesType))
                ;
        }

        /// <summary>
        /// Map EMSAdmCharges DTOs to EMSAttendanceFee Domain
        /// </summary>
        internal void MapEMSAttendanceFeeEntityToEMSAttendanceFee()
        {
            Mapper.CreateMap<EMSAttendanceFeeEntity, EMSAttendanceFee>()
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))//CR-ENFUAT-2012071001 - Mantis: 0005505
                .ForMember(desc => desc.EMSAppointment, opt => opt.ResolveUsing<StringToEMSAppointmentResolver>().FromMember(src => src.EMSAppointmentId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                ;
        }


        /// <summary>
        /// Map EMSAdmClaim DTOs to EMSAdmClaim Domain
        /// </summary>
        internal void MapEMSAdmClaimEntityToEMSAdmClaim()
        {
            Mapper.CreateMap<EMSAdmClaimEntity, EMSAdmClaim>()
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.Bailiff, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.BailiffId))
                .ForMember(desc => desc.EMSAdmExec, opt => opt.ResolveUsing<StringToEMSAdmExecResolver>().FromMember(src => src.EMSAdmExecId))
                .ForMember(desc => desc.EMSAdmRelease, opt => opt.ResolveUsing<StringToEMSAdmReleaseResolver>().FromMember(src => src.EMSAdmReleaseId))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.PaymentVoucherId))
                .ForMember(desc => desc.EMSSale, opt => opt.ResolveUsing<StringToEMSSaleResolver>().FromMember(src => src.EMSSaleId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.ClaimType, opt => opt.ResolveUsing<ClaimTypeToStringResolver>().FromMember(src => src.ClaimType))
                ;
        }

        /// <summary>
        /// Map EMSAdmExec DTOs to EMSAdmExec Domain
        /// </summary>
        internal void MapEMSAdmExecEntityToEMSAdmExec()
        {
            Mapper.CreateMap<EMSAdmExecEntity, EMSAdmExec>()
                .ForMember(desc => desc.Bailiff, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.BailiffId))
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.EMSAdmProperty, opt => opt.ResolveUsing<StringToEMSAdmPropertyResolver>().FromMember(src => src.EMSAdmPropertyId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.FormatInd, opt => opt.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                .ForMember(desc => desc.SyncRequired, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SyncRequired))
                ;
        }

        /// <summary>
        /// Map EMSAdmProperty DTOs to EMSAdmProperty Domain
        /// </summary>
        internal void MapEMSAdmPropertyEntityToEMSAdmProperty()
        {
            Mapper.CreateMap<EMSAdmPropertyEntity, EMSAdmProperty>()
                .ForMember(desc => desc.AdmType, opt => opt.ResolveUsing<AdmiralityTypeToStringResolver>().FromMember(src => src.AdmType))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.SyncRequired, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SyncRequired))
                ;
        }

        /// <summary>
        /// Map EMSAdmPropertyList DTOs to EMSAdmPropertyList Domain
        /// </summary>
        internal void MapEMSAdmPropertyListEntityToEMSAdmPropertyList()
        {
            Mapper.CreateMap<EMSAdmPropertyListEntity, EMSAdmPropertyList>()
              .ForMember(desc => desc.PropertyType, opt => opt.ResolveUsing<PropertyTypeToStringResolver>().FromMember(src => src.PropertyType))
              .ForMember(desc => desc.EMSAdmProperty, opt => opt.ResolveUsing<StringToEMSAdmPropertyResolver>().FromMember(src => src.EMSAdmPropertyId))
                ;
        }

        /// <summary>
        /// Map EMSAdmRelease DTOs to EMSAdmRelease Domain
        /// </summary>
        internal void MapEMSAdmReleaseEntityToEMSAdmRelease()
        {
            Mapper.CreateMap<EMSAdmReleaseEntity, EMSAdmRelease>()
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.EMSReceipt, opt => opt.ResolveUsing<StringToEMSReceiptResolver>().FromMember(src => src.EMSReceiptId))
                .ForMember(desc => desc.EMSAdmProperty, opt => opt.ResolveUsing<StringToEMSAdmPropertyResolver>().FromMember(src => src.EMSAdmPropertyId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.ReleaseRequester, opt => opt.ResolveUsing<ReleaseTypeToStringResolver>().FromMember(src => src.ReleaseRequester))
                .ForMember(desc => desc.ReleaseTo, opt => opt.ResolveUsing<ReleaseTypeToStringResolver>().FromMember(src => src.ReleaseTo))
                .ForMember(desc => desc.LetterUsed, opt => opt.ResolveUsing<RAdmLetterUsedToStringResolver>().FromMember(src => src.LetterUsed))
                .ForMember(desc => desc.SyncRequired, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SyncRequired))
                ;
        }

        /// <summary>
        /// Map EMSADMSaleOthers DTOs to EMSADMSaleOthers Domain
        /// </summary>
        internal void MapEMSADMSaleOthersEntityToEMSADMSaleOthers()
        {
            Mapper.CreateMap<EMSADMSaleOthersEntity, EMSADMSaleOthers>()
                .ForMember(desc => desc.EMSSale, opt => opt.ResolveUsing<StringToEMSSaleResolver>().FromMember(src => src.EMSSaleId))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))
                ;
        }

        /// <summary>
        /// Map EMSAppointment DTOs to EMSAppointment Domain
        /// </summary>
        internal void MapEMSAppointmentEntityToEMSAppointment()
        {
            Mapper.CreateMap<EMSAppointmentEntity, EMSAppointment>()
                .ForMember(desc => desc.Bailiff, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.BailiffId))
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.IsHidden, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsHidden))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.ExecAddrFormatInd, opt => opt.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.ExecAddrFormatInd))
                .ForMember(desc => desc.OutOfcHrStatus, opt => opt.ResolveUsing<OutOfOfficeStatusToStringResolver>().FromMember(src => src.OutOfcHrStatus))
                .ForMember(desc => desc.SyncRequired, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SyncRequired))
                ;
        }

        /// <summary>
        /// Map EMSApptDateTime DTOs to EMSApptDateTime Domain
        /// </summary>
        internal void MapEMSApptDateTimeEntityToEMSApptDateTime()
        {
            Mapper.CreateMap<EMSApptDateTimeEntity, EMSApptDateTime>()
                .ForMember(desc => desc.EMSAppointment, opt => opt.ResolveUsing<StringToEMSAppointmentResolver>().FromMember(src => src.EMSAppointmentId))
                ;
        }

        /// <summary>
        /// Map EMSApptDebtor DTOs to EMSApptDebtor Domain
        /// </summary>
        internal void MapEMSApptDebtorEntityToEMSApptDebtor()
        {
            Mapper.CreateMap<EMSApptDebtorEntity, EMSApptDebtor>()
                .ForMember(desc => desc.EMSAppointment, opt => opt.ResolveUsing<StringToEMSAppointmentResolver>().FromMember(src => src.EMSAppointmentId))
                .ForMember(desc => desc.CaseParty, opt => opt.ResolveUsing<StringToCasePartyResolver>().FromMember(src => src.CasePartyId))
                ;
        }

        /// <summary>
        /// Map EMSBailiffUnavailability DTOs to EMSBailiffUnavailability Domain
        /// </summary>
        internal void MapEMSBailiffUnavailabilityEntityToEMSBailiffUnavailability()
        {
            Mapper.CreateMap<EMSBailiffUnavailabilityEntity, EMSBailiffUnavailability>()
                .ForMember(desc => desc.Bailiff, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.BailiffId))
                ;
        }

        /// <summary>
        /// Map EMSCashBookItem DTOs to EMSCashBookItem Domain
        /// </summary>
        internal void MapEMSCashBookItemEntityToEMSCashBookItem()
        {
            Mapper.CreateMap<EMSCashBookItemEntity, EMSCashBookItem>()
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.AddLess, opt => opt.ResolveUsing<AddLessToStringResolver>().FromMember(src => src.AddLess))
                .ForMember(desc => desc.Type, opt => opt.ResolveUsing<CashBookItemTypeToStringResolver>().FromMember(src => src.Type))
                .ForMember(desc => desc.EMSCashBookReconcile, opt => opt.ResolveUsing<StringToEMSCashBookReconcileResolver>().FromMember(src => src.EMSCashBookReconcileId))
                ;
        }

        /// <summary>
        /// Map EMSCashBookReconcile DTOs to EMSCashBookReconcile Domain
        /// </summary>
        internal void MapEMSCashBookReconcileEntityToEMSCashBookReconcile()
        {
            Mapper.CreateMap<EMSCashBookReconcileEntity, EMSCashBookReconcile>()
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.Status, opt => opt.ResolveUsing<CaseBookReconcileStatusToStringResolver>().FromMember(src => src.Status))
                ;
        }

        /// <summary>
        /// Map EMSCheque DTOs to EMSCheque Domain
        /// </summary>
        internal void MapEMSChequeEntityToEMSCheque()
        {
            Mapper.CreateMap<EMSChequeEntity, EMSCheque>()
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.ChequeStatus, opt => opt.ResolveUsing<PaymentChequeStatusToStringResolver>().FromMember(src => src.ChequeStatus))
                .ForMember(desc => desc.PaymentOfficer, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.PaymentOfficerID))
                ;
        }

        /// <summary>
        /// Map EMSChequeHistory DTOs to EMSChequeHistory Domain
        /// </summary>
        internal void MapEMSChequeHistoryEntityToEMSChequeHistory()
        {
            Mapper.CreateMap<EMSChequeHistoryEntity, EMSChequeHistory>()
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.OrgChequeStatus, opt => opt.ResolveUsing<PaymentChequeStatusToStringResolver>().FromMember(src => src.OrgChequeStatus))
                .ForMember(desc => desc.OrgPaymentOfficer, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.OrgPaymentOfficerID))
                .ForMember(desc => desc.EMSCheque, opt => opt.ResolveUsing<StringToEMSChequeResolver>().FromMember(src => src.EMSChequeId))
                ;
        }

        /// <summary>
        /// Map EMSCivCaseAbort DTOs to EMSCivCaseAbort Domain
        /// </summary>
        internal void MapEMSCivCaseAbortEntityToEMSCivCaseAbort()
        {
            Mapper.CreateMap<EMSCivCaseAbortEntity, EMSCivCaseAbort>()
              .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
              .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                ;
        }

        /// <summary>
        /// Map EMSCivCrmMissing DTOs to EMSCivCrmMissing Domain
        /// </summary>
        internal void MapEMSCivCrmMissingEntityToEMSCivCrmMissing()
        {
            Mapper.CreateMap<EMSCivCrmMissingEntity, EMSCivCrmMissing>()
              .ForMember(desc => desc.EMSCivCrmSeizure, opt => opt.ResolveUsing<StringToEMSCivCrmSeizureResolver>().FromMember(src => src.EMSCivCrmSeizureId))
              .ForMember(desc => desc.User, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.DRId))
              .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
              .ForMember(desc => desc.IsMakeReport, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsMakeReport))
              .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                ;
        }

        /// <summary>
        /// Map EMSCivCrmRelease DTOs to EMSCivCrmRelease Domain
        /// </summary>
        internal void MapEMSCivCrmReleaseEntityToEMSCivCrmRelease()
        {
            Mapper.CreateMap<EMSCivCrmReleaseEntity, EMSCivCrmRelease>()
              .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.ReleaseType, opt => opt.ResolveUsing<CriminalReleaseTypeToStringResolver>().FromMember(src => src.ReleaseType))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.SyncRequired, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SyncRequired))
                ;
        }

        /// <summary>
        /// Map EMSCivCrmSeizure DTOs to EMSCivCrmSeizure Domain
        /// </summary>
        internal void MapEMSCivCrmSeizureEntityToEMSCivCrmSeizure()
        {
            Mapper.CreateMap<EMSCivCrmSeizureEntity, EMSCivCrmSeizure>()
              .ForMember(desc => desc.EMSAppointment, opt => opt.ResolveUsing<StringToEMSAppointmentResolver>().FromMember(src => src.EMSAppointmentId))
              .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                ;
        }

        /// <summary>
        /// Map EMSCivCrmSettlement DTOs to EMSCivCrmSettlement Domain
        /// </summary>
        internal void MapEMSCivCrmSettlementEntityToEMSCivCrmSettlement()
        {
            Mapper.CreateMap<EMSCivCrmSettlementEntity, EMSCivCrmSettlement>()
                .ForMember(desc => desc.CaseParty, opt => opt.ResolveUsing<StringToCasePartyResolver>().FromMember(src => src.CasePartyId))
                .ForMember(desc => desc.EMSAppointment, opt => opt.ResolveUsing<StringToEMSAppointmentResolver>().FromMember(src => src.EMSAppointmentId))
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.SettlementOutcome, opt => opt.ResolveUsing<SettlementOutcomeTypeToStringResolver>().FromMember(src => src.SettlementOutcome))
                ;
        }

        /// <summary>
        /// Map EMSCourtCommission DTOs to EMSCourtCommission Domain
        /// </summary>
        internal void MapEMSCourtCommissionEntityToEMSCourtCommission()
        {
            Mapper.CreateMap<EMSCourtCommissionEntity, EMSCourtCommission>()
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                ;
        }

        /// <summary>
        /// Map EMSCrmCase DTOs to EMSCrmCase Domain
        /// </summary>
        internal void MapEMSCrmCaseEntityToEMSCrmCase()
        {
            Mapper.CreateMap<EMSCrmCaseEntity, EMSCrmCase>()
              .ForMember(desc => desc.CaseInfo, opt => opt.ResolveUsing<StringToCaseInfoResolver>().FromMember(src => src.CaseInfoId))
              .ForMember(desc => desc.CaseParty, opt => opt.ResolveUsing<StringToCasePartyResolver>().FromMember(src => src.CasePartyId))
              .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
              .ForMember(desc => desc.AccusedFormatInd, opt => opt.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.AccusedFormatInd))
                ;
        }

        /// <summary>
        /// Map EMSCrmCaseExecAddr DTOs to EMSCrmCaseExecAddr Domain
        /// </summary>
        internal void MapEMSCrmCaseExecAddrEntityToEMSCrmCaseExecAddr()
        {
            Mapper.CreateMap<EMSCrmCaseExecAddrEntity, EMSCrmCaseExecAddr>()
              .ForMember(desc => desc.EMSCrmCase, opt => opt.ResolveUsing<StringToEMSCrmCaseResolver>().FromMember(src => src.EMSCrmCaseId))
              .ForMember(desc => desc.FormatInd, opt => opt.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
              .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
        }

        /// <summary>
        /// Map EMSCrmCaseWLDet DTOs to EMSCrmCaseWLDet Domain
        /// </summary>
        internal void MapEMSCrmCaseWLDetEntityToEMSCrmCaseWLDet()
        {
            Mapper.CreateMap<EMSCrmCaseWLDetEntity, EMSCrmCaseWLDet>()
              .ForMember(desc => desc.EMSCrmCase, opt => opt.ResolveUsing<StringToEMSCrmCaseResolver>().FromMember(src => src.EMSCrmCaseId))
                ;
        }

        /// <summary>
        /// Map EMSDisburseClaim DTOs to EMSDisburseClaim Domain
        /// </summary>
        internal void MapEMSDisburseClaimEntityToEMSDisburseClaim()
        {
            Mapper.CreateMap<EMSDisburseClaimEntity, EMSDisburseClaim>()
                .ForMember(desc => desc.Bailiff, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.BailiffId))
                .ForMember(desc => desc.EMSApptDateTime, opt => opt.ResolveUsing<StringToEMSApptDateTimeResolver>().FromMember(src => src.EMSApptDateTimeId))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                ;
        }

        /// <summary>
        /// Map EMSDisburseClaim DTOs to EMSDisburseClaim Domain
        /// </summary>
        internal void MapEMSExecLedgerEntityToEMSExecLedger()
        {
            Mapper.CreateMap<EMSExecLedgerEntity, EMSExecLedger>()
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.EMSPayment, opt => opt.ResolveUsing<StringToEMSPaymentResolver>().FromMember(src => src.EMSPaymentId))
                .ForMember(desc => desc.EMSRecTrans, opt => opt.ResolveUsing<StringToEMSRecTransResolver>().FromMember(src => src.EMSRecTransId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.IsDebitCredit, opt => opt.ResolveUsing<CreditDebitToStringResolver>().FromMember(src => src.IsDebitCredit))
                ;
        }

        /// <summary>
        /// Map EMSFileMovement DTOs to EMSFileMovement Domain
        /// </summary>
        internal void MapEMSFileMovementEntityToEMSFileMovement()
        {
            Mapper.CreateMap<EMSFileMovementEntity, EMSFileMovement>()
                .ForMember(desc => desc.UpdatedBy, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.UpdatedByUserId))
                .ForMember(desc => desc.Bailiff, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.BailiffId))
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                ;
        }

        /// <summary>
        /// Map EMSMiscClaim DTOs to EMSMiscClaim Domain
        /// </summary>
        internal void MapEMSMiscClaimEntityToEMSMiscClaim()
        {
            Mapper.CreateMap<EMSMiscClaimEntity, EMSMiscClaim>()
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))
                .ForMember(desc => desc.EMSAppointment, opt => opt.ResolveUsing<StringToEMSAppointmentResolver>().FromMember(src => src.EMSAppointmentId))
                .ForMember(desc => desc.Bailiff, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.BailiffId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.Status, opt => opt.ResolveUsing<BailiffClaimStatusToStringResolver>().FromMember(src => src.Status))
                ;
        }

        /// <summary>
        /// Map EMSOutstandingPayment DTOs to EMSOutstandingPayment Domain
        /// </summary>
        internal void MapEMSOutstandingPaymentEntityToEMSOutstandingPayment()
        {
            Mapper.CreateMap<EMSOutstandingPaymentEntity, EMSOutstandingPayment>()
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.OutstandingPaymentType, opt => opt.ResolveUsing<OutstandingPaymentTypeToStringResolver>().FromMember(src => src.OutstandingPaymentType))
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                ;
        }

        /// <summary>
        /// Map EMSCheque DTOs to EMSCheque Domain
        /// </summary>
        internal void MapEMSPaymentChequeEntityToEMSPaymentCheque()
        {
            Mapper.CreateMap<EMSPaymentChequeEntity, EMSPaymentCheque>()
                .ForMember(desc => desc.EMSCheque, opt => opt.ResolveUsing<StringToEMSChequeResolver>().FromMember(src => src.EMSChequeId))
                .ForMember(desc => desc.EMSPayment, opt => opt.ResolveUsing<StringToEMSPaymentResolver>().FromMember(src => src.EMSPaymentId))
                ;
        }

        /// <summary>
        /// Map EMSPayment DTOs to EMSPayment Domain
        /// </summary>
        internal void MapEMSPaymentEntityToEMSPayment()
        {
            Mapper.CreateMap<EMSPaymentEntity, EMSPayment>()
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.PaymentStatus, opt => opt.ResolveUsing<PaymentStatusToStringResolver>().FromMember(src => src.PaymentStatus))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.PaymentVoucherId))
                ;
        }

        /// <summary>
        /// Map EMSPaymentVoucherAdm DTOs to EMSPaymentVoucherAdm Domain
        /// </summary>
        internal void MapEMSPaymentVoucherAdmEntityToEMSPaymentVoucherAdm()
        {
            Mapper.CreateMap<EMSPaymentVoucherAdmEntity, EMSPaymentVoucherAdm>()
                .ForMember(desc => desc.EMSPaymentVoucherFinal, opt => opt.ResolveUsing<StringToEMSPaymentVoucherFinalResolver>().FromMember(src => src.EMSPaymentVoucherFinalId))
                .ForMember(desc => desc.EMSAdmCharge, opt => opt.ResolveUsing<StringToEMSAdmChargeResolver>().FromMember(src => src.EMSAdmChargeId))
                ;
        }

        /// <summary>
        /// Map EMSPaymentVoucherCheque DTOs to EMSPaymentVoucherCheque Domain
        /// </summary>
        internal void MapEMSPaymentVoucherChequeEntityToEMSPaymentVoucherCheque()
        {
            Mapper.CreateMap<EMSPaymentVoucherChequeEntity, EMSPaymentVoucherCheque>()
                .ForMember(desc => desc.EMSPayment, opt => opt.ResolveUsing<StringToEMSPaymentResolver>().FromMember(src => src.EMSPaymentId))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))
                ;
        }

        /// <summary>
        /// Map EMSPaymentVoucher DTOs to EMSPaymentVoucher Domain
        /// </summary>
        internal void MapEMSPaymentVoucherEntityToEMSPaymentVoucher()
        {
            Mapper.CreateMap<EMSPaymentVoucherEntity, EMSPaymentVoucher>()
                .ForMember(desc => desc.Bailiff, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.BailiffId))
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.PaymentVoucherType, opt => opt.ResolveUsing<PaymentVoucherTypeToStringResolver>().FromMember(src => src.PaymentVoucherType))
                .ForMember(desc => desc.Status, opt => opt.ResolveUsing<PaymentVoucherStatusToStringResolver>().FromMember(src => src.Status))
                ;
        }

        /// <summary>
        /// Map EMSPaymentVoucherFinal DTOs to EMSPaymentVoucherFinal Domain
        /// </summary>
        internal void MapEMSPaymentVoucherFinalEntityToEMSPaymentVoucherFinal()
        {
            Mapper.CreateMap<EMSPaymentVoucherFinalEntity, EMSPaymentVoucherFinal>()
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))
                .ForMember(desc => desc.CaseParty, opt => opt.ResolveUsing<StringToCasePartyResolver>().FromMember(src => src.CasePartyId))
                .ForMember(desc => desc.LawFirm, opt => opt.ResolveUsing<StringToLawFirmResolver>().FromMember(src => src.LFId))
                .ForMember(desc => desc.AttendanceFeeVarAddLess, opt => opt.ResolveUsing<AddLessToStringResolver>().FromMember(src => src.AttendanceFeeVarAddLess))
                .ForMember(desc => desc.CourtCommissionVarAddLess, opt => opt.ResolveUsing<AddLessToStringResolver>().FromMember(src => src.CourtCommissionVarAddLess))
                .ForMember(desc => desc.MiscVarAddLess, opt => opt.ResolveUsing<AddLessToStringResolver>().FromMember(src => src.MiscVarAddLess))
                ;
        }

        /// <summary>
        /// Map EMSPaymentVoucherFinal DTOs to EMSPaymentVoucherFinal Domain
        /// </summary>
        internal void MapEMSPaymentVoucherFinalOtherEntityToEMSPaymentVoucherFinalOther()
        {
            Mapper.CreateMap<EMSPaymentVoucherFinalOtherEntity, EMSPaymentVoucherFinalOther>()
                .ForMember(desc => desc.PaymentToOtherIdentifier, opt => opt.ResolveUsing<OtherPartyTypeTypeToStringResolver>().FromMember(src => src.PaymentToOtherIdentifier))
                .ForMember(desc => desc.FormatInd, opt => opt.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                //.ForMember(desc => desc.EMSPaymentVoucherFinal, opt => opt.ResolveUsing<StringToEMSPaymentVoucherFinalResolver>().FromMember(src => src.EMSPaymentVoucherFinalId))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))
                .ForMember(desc => desc.CaseParty, opt => opt.ResolveUsing<StringToCasePartyResolver>().FromMember(src => src.CasePartyId))
                ;
        }

        /// <summary>
        /// Map EMSPaymentVoucherMisc DTOs to EMSPaymentVoucherMisc Domain
        /// </summary>
        internal void MapEMSPaymentVoucherMiscEntityToEMSPaymentVoucherMisc()
        {
            Mapper.CreateMap<EMSPaymentVoucherMiscEntity, EMSPaymentVoucherMisc>()
                .ForMember(desc => desc.AddLess, opt => opt.ResolveUsing<AddLessToStringResolver>().FromMember(src => src.AddLess))
                .ForMember(desc => desc.EMSPaymentVoucherFinal, opt => opt.ResolveUsing<StringToEMSPaymentVoucherFinalResolver>().FromMember(src => src.EMSPaymentVoucherFinalId))
                ;
        }

        /// <summary>
        /// Map EMSRecapitDetails DTOs to EMSRecapitDetails Domain
        /// </summary>
        internal void MapEMSRecapitDetailsEntityToEMSRecapitDetails()
        {
            Mapper.CreateMap<EMSRecapitDetailsEntity, EMSRecapitDetails>()
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.LastTransUser, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.LastTransUserId))
                .ForMember(desc => desc.EMSRecapitulation, opt => opt.ResolveUsing<StringToEMSRecapitulationResolver>().FromMember(src => src.EMSRecapitulationId))
                ;
        }

        /// <summary>
        /// Map EMSRecapitulation DTOs to EMSRecapitulation Domain
        /// </summary>
        internal void MapEMSRecapitulationEntityToEMSRecapitulation()
        {
            Mapper.CreateMap<EMSRecapitulationEntity, EMSRecapitulation>()
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                ;
        }

        /// <summary>
        /// Map EMSRecAudit DTOs to EMSRecAudit Domain
        /// </summary>
        internal void MapEMSRecAuditEntityToEMSRecAudit()
        {
            Mapper.CreateMap<EMSRecAuditEntity, EMSRecAudit>()
                .ForMember(desc => desc.EMSReceipt, opt => opt.ResolveUsing<StringToEMSReceiptResolver>().FromMember(src => src.EMSReceiptId))
                .ForMember(desc => desc.VoidReason, opt => opt.ResolveUsing<VoidReasonToStringResolver>().FromMember(src => src.VoidReason))
                .ForMember(desc => desc.ReprintType, opt => opt.ResolveUsing<ReprintTypeToStringResolver>().FromMember(src => src.ReprintType))
                .ForMember(desc => desc.AuditType, opt => opt.ResolveUsing<ReceiptAduitTypeToStringResolver>().FromMember(src => src.AuditType))
                ;
        }

        /// <summary>
        /// Map EMSRecChequeAudit DTOs to EMSRecChequeAudit Domain
        /// </summary>
        internal void MapEMSRecChequeAuditEntityToEMSRecChequeAudit()
        {
            Mapper.CreateMap<EMSRecChequeAuditEntity, EMSRecChequeAudit>()
                .ForMember(desc => desc.EMSRecTrans, opt => opt.ResolveUsing<StringToEMSRecTransResolver>().FromMember(src => src.EMSRecTransId))
                ;
        }

        /// <summary>
        /// Map EMSReceipt DTOs to EMSReceipt Domain
        /// </summary>
        internal void MapEMSReceiptEntityToEMSReceipt()
        {
            Mapper.CreateMap<EMSReceiptEntity, EMSReceipt>()
                .ForMember(desc => desc.Cashier, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.CashierId))
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.Status, opt => opt.ResolveUsing<ReceiptStatusToStringResolver>().FromMember(src => src.Status))
                ;
        }

        /// <summary>
        /// Map EMSRecTrans DTOs to EMSRecTrans Domain
        /// </summary>
        internal void MapEMSRecTransEntityToEMSRecTrans()
        {
            Mapper.CreateMap<EMSRecTransEntity, EMSRecTrans>()
                .ForMember(desc => desc.EMSReceipt, opt => opt.ResolveUsing<StringToEMSReceiptResolver>().FromMember(src => src.EMSReceiptId))
                ;
        }

        /// <summary>
        /// Map EMSRoundRobinAuctioneer DTOs to EMSRoundRobinAuctioneer Domain
        /// </summary>
        internal void MapEMSRoundRobinAuctioneerEntityToEMSRoundRobinAuctioneer()
        {
            Mapper.CreateMap<EMSRoundRobinAuctioneerEntity, EMSRoundRobinAuctioneer>()
                ;
        }

        /// <summary>
        /// Map EMSSaleAdvert DTOs to EMSSaleAdvert Domain
        /// </summary>
        internal void MapEMSSaleAdvertEntityToEMSSaleAdvert()
        {
            Mapper.CreateMap<EMSSaleAdvertEntity, EMSSaleAdvert>()
                .ForMember(desc => desc.EMSSale, opt => opt.ResolveUsing<StringToEMSSaleResolver>().FromMember(src => src.EMSSaleId))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))//CR-ENFUAT-2012071001 - Mantis: 0005505
                ;
        }

        /// <summary>
        /// Map EMSSaleAgent DTOs to EMSSaleAgent Domain
        /// </summary>
        internal void MapEMSSaleAgentEntityToEMSSaleAgent()
        {
            Mapper.CreateMap<EMSSaleAgentEntity, EMSSaleAgent>()
                .ForMember(desc => desc.EMSSale, opt => opt.ResolveUsing<StringToEMSSaleResolver>().FromMember(src => src.EMSSaleId))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))//CR-ENFUAT-2012071001 - Mantis: 0005505
                ;
        }

        /// <summary>
        /// Map EMSSaleAppraiser DTOs to EMSSaleAppraiser Domain
        /// </summary>
        internal void MapEMSSaleAppraiserEntityToEMSSaleAppraiser()
        {
            Mapper.CreateMap<EMSSaleAppraiserEntity, EMSSaleAppraiser>()
                .ForMember(desc => desc.EMSSale, opt => opt.ResolveUsing<StringToEMSSaleResolver>().FromMember(src => src.EMSSaleId))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))//CR-ENFUAT-2012071001 - Mantis: 0005505
                ;
        }

        /// <summary>
        /// Map EMSSaleAuctioneer DTOs to EMSSaleAuctioneer Domain
        /// </summary>
        internal void MapEMSSaleAuctioneerEntityToEMSSaleAuctioneer()
        {
            Mapper.CreateMap<EMSSaleAuctioneerEntity, EMSSaleAuctioneer>()
                .ForMember(desc => desc.EMSSale, opt => opt.ResolveUsing<StringToEMSSaleResolver>().FromMember(src => src.EMSSaleId))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))//CR-ENFUAT-2012071001 - Mantis: 0005505
                ;
        }

        /// <summary>
        /// Map EMSSaleBuyer DTOs to EMSSaleBuyer Domain
        /// </summary>
        internal void MapEMSSaleBuyerEntityToEMSSaleBuyer()
        {
            Mapper.CreateMap<EMSSaleBuyerEntity, EMSSaleBuyer>()
                .ForMember(desc => desc.EMSSale, opt => opt.ResolveUsing<StringToEMSSaleResolver>().FromMember(src => src.EMSSaleId))
                ;
        }

        /// <summary>
        /// Map EMSSale DTOs to EMSSale Domain
        /// </summary>
        internal void MapEMSSaleEntityToEMSSale()
        {
            Mapper.CreateMap<EMSSaleEntity, EMSSale>()
                .ForMember(desc => desc.TypeOfAuction, opt => opt.ResolveUsing<AutionTypeToStringResolver>().FromMember(src => src.TypeOfAuction))
                .ForMember(desc => desc.AdmSaleFormatInd, opt => opt.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.AdmSaleFormatInd))
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.EMSAppointment, opt => opt.ResolveUsing<StringToEMSAppointmentResolver>().FromMember(src => src.EMSAppointmentId))
                .ForMember(desc => desc.EMSAdmProperty, opt => opt.ResolveUsing<StringToEMSAdmPropertyResolver>().FromMember(src => src.EMSAdmPropertyId))
                //.ForMember(desc => desc.EMSAdmCharge, opt => opt.ResolveUsing<StringToEMSAdmChargeResolver>().FromMember(src => src.EMSAdmChargeId))
                .ForMember(desc => desc.SyncRequired, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SyncRequired))
                ;
        }

        /// <summary>
        /// Map EMSStateFund DTOs to EMSStateFund Domain
        /// </summary>
        internal void MapEMSStateFundEntityToEMSStateFund()
        {
            Mapper.CreateMap<EMSStateFundEntity, EMSStateFund>()
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.EMSAccount, opt => opt.ResolveUsing<StringToEMSAccountResolver>().FromMember(src => src.EMSAccountId))
                .ForMember(desc => desc.EMSCheque, opt => opt.ResolveUsing<StringToEMSChequeResolver>().FromMember(src => src.EMSChequeId))
                .ForMember(desc => desc.TransferStatus, opt => opt.ResolveUsing<TransferStateFundStatusToStringResolver>().FromMember(src => src.TransferStatus))
                ;
        }

        /// <summary>
        /// Map EMSTeamMgmt DTOs to EMSTeamMgmt Domain
        /// </summary>
        internal void MapEMSTeamMgmtEntityToEMSTeamMgmt()
        {
            Mapper.CreateMap<EMSTeamMgmtEntity, EMSTeamMgmt>()
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.ProceedingType, opt => opt.ResolveUsing<TeamManagementProceedingTypeToStringResolver>().FromMember(src => src.ProceedingType))
                ;
        }

        /// <summary>
        /// Map EMSTptClaim DTOs to EMSTptClaim Domain
        /// </summary>
        internal void MapEMSTptClaimEntityToEMSTptClaim()
        {
            Mapper.CreateMap<EMSTptClaimEntity, EMSTptClaim>()
                .ForMember(desc => desc.Bailiff, opt => opt.ResolveUsing<StringToJudicialUserResolver>().FromMember(src => src.BailiffId))
                .ForMember(desc => desc.EMSAppointment, opt => opt.ResolveUsing<StringToEMSAppointmentResolver>().FromMember(src => src.EMSAppointmentId))
                .ForMember(desc => desc.EMSPaymentVoucher, opt => opt.ResolveUsing<StringToEMSPaymentVoucherResolver>().FromMember(src => src.EMSPaymentVoucherId))
                .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                .ForMember(desc => desc.Status, opt => opt.ResolveUsing<BailiffClaimStatusToStringResolver>().FromMember(src => src.Status))
                ;
        }

        internal void MapLawFirmEntityToLawFirm()
        {
            Mapper.CreateMap<LawFirmEntity, LawFirm>()
                   .ForMember(desc => desc.ObsInd, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                   ;
        }

        /// <summary>
        /// Map Temp_EMSAppointment DTOs to Temp_EMSAppointment Domain
        /// </summary>
        internal void MapTemp_EMSAppointmentEntityToTemp_EMSAppointment()
        {
            Mapper.CreateMap<Temp_EMSAppointmentEntity, Temp_EMSAppointment>()
                .ForMember(desc => desc.EMSType, opt => opt.ResolveUsing<EMSTypeToStringResolver>().FromMember(src => src.EMSType))
                .ForMember(desc => desc.IsOnHold, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsOnHold))
                .ForMember(desc => desc.IsWaiver, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsWaiver))
                .ForMember(desc => desc.IsWSeizure, opt => opt.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsWSeizure))
                .ForMember(desc => desc.ExecAddrFormatInd, opt => opt.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.ExecAddrFormatInd))
                .ForMember(desc => desc.OutOfcHrStatus, opt => opt.ResolveUsing<OutOfOfficeStatusToStringResolver>().FromMember(src => src.OutOfcHrStatus))
                .ForMember(desc => desc.CaseInfoId, opt => opt.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                .ForMember(desc => desc.SubCaseInfoId, opt => opt.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                ;
        }

        #endregion Methods
    }
}