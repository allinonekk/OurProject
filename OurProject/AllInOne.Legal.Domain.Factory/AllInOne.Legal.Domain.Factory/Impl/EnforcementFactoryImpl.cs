#region Header

/*****************************************************************************************************
 * Description : This file represents a standard implementation for Enforcement factory.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 30/11/2010                 Yan Nai             	 	Created
 *****************************************************************************************************/
// <summary>
// File: EnforcementFactory.cs
// Description: Represents a standard implementation for Enforcement factory.
// </summary>
// <copyright file= "EnforcementFactory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory.Impl
{
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Enforcement;

    /// <summary>
    /// Represents a standard implementation for Enforcement factory.
    /// It inherits from <see cref="IEnforcementFactory"/>.
    /// </summary>
    public class EnforcementFactoryImpl : IEnforcementFactory
    {
        #region Fields

        /// <summary>
        /// Variable to store ApplicationEnvironment.
        /// </summary>
        private ApplicationEnvironment applicationEnvironment;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseFactoryImpl"/> class.
        /// </summary>
        /// <param name="applicationEnvironment">The application environment.</param>
        public EnforcementFactoryImpl(ApplicationEnvironment applicationEnvironment)
        {
            this.applicationEnvironment = applicationEnvironment;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the <see cref="EMSRoundRobinAuctioneerEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSRoundRobinAuctioneerEntity"/>
        /// </returns>
        public EMSRoundRobinAuctioneerEntity GetEMSRoundRobinAuctioneerEntityInstance()
        {
            return new EMSRoundRobinAuctioneerEntity { RoundRobinAuctioneerId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSAttendanceFeeEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSAttendanceFeeEntity"/>
        /// </returns>
        public EMSAttendanceFeeEntity GetEMSAttendanceFeeEntityInstance()
        {
            return new EMSAttendanceFeeEntity { EMSAttendanceFeeId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSAccountEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSAccountEntity"/>
        /// </returns>
        public EMSAccountEntity GetEMSAccountEntityInstance()
        {
            return new EMSAccountEntity { EMSAccountId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSPaymentVoucherEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherEntity"/>
        /// </returns>
        public EMSAppointmentEntity GetEMSAppointmentEntityInstance()
        {
            return new EMSAppointmentEntity { EMSAppointmentId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSCashBookItemEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSCashBookItemEntity"/>
        /// </returns>
        public EMSCashBookItemEntity GetEMSCashBookItemEntityInstance()
        {
            return new EMSCashBookItemEntity { EMSCashBookItemId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSCashBookReconcileEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSCashBookReconcileEntity"/>
        /// </returns>
        public EMSCashBookReconcileEntity GetEMSCashBookReconcileEntityInstance()
        {
            return new EMSCashBookReconcileEntity { EMSCashBookReconcileId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSChequeEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSChequeEntity"/>
        /// </returns>
        public EMSChequeEntity GetEMSChequeEntityInstance()
        {
            return new EMSChequeEntity { EMSChequeId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSChequeHistoryEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSChequeHistoryEntity"/>
        /// </returns>
        public EMSChequeHistoryEntity GetEMSChequeHistoryEntityInstance()
        {
            return new EMSChequeHistoryEntity { EMSChequeHistoryId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public EMSCivCrmReleaseEntity GetEMSCivCrmReleaseEntityInstance()
        {
            return new EMSCivCrmReleaseEntity { EMSCivCrmReleaseId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSCourtCommissionEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSCourtCommissionEntity"/>
        /// </returns>
        public EMSCourtCommissionEntity GetEMSCourtCommissionEntityInstance()
        {
            return new EMSCourtCommissionEntity { EMSCourtCommissionId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSExecLedgerEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSExecLedgerEntity"/>
        /// </returns>
        public EMSExecLedgerEntity GetEMSExecLedgerEntityInstance()
        {
            return new EMSExecLedgerEntity { EMSExecLedgerId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSFileMovementEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSFileMovementEntity"/>
        /// </returns>
        public EMSFileMovementEntity GetEMSFileMovementEntityInstance()
        {
            return new EMSFileMovementEntity { EMSFileMovementId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSOutstandingPaymentEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSOutstandingPaymentEntity"/>
        /// </returns>
        public EMSOutstandingPaymentEntity GetEMSOutstandingPaymentEntityInstance()
        {
            return new EMSOutstandingPaymentEntity { EMSOutstandingPaymentId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSChequeEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSChequeEntity"/>
        /// </returns>
        public EMSPaymentChequeEntity GetEMSPaymentChequeEntityInstance()
        {
            return new EMSPaymentChequeEntity { EMSPaymentChequeId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentEntity"/>
        /// </returns>
        public EMSPaymentEntity GetEMSPaymentEntityInstance()
        {
            return new EMSPaymentEntity { EMSPaymentId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherChequeEntity"/>
        /// </returns>
        public EMSPaymentVoucherChequeEntity GetEMSPaymentVoucherChequeEntityInstance()
        {
            return new EMSPaymentVoucherChequeEntity { EMSPaymentVoucherChequeId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSPaymentVoucherEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherEntity"/>
        /// </returns>
        public EMSPaymentVoucherEntity GetEMSPaymentVoucherEntityInstance()
        {
            return new EMSPaymentVoucherEntity { EMSPaymentVoucherId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSPaymentVoucherEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherEntity"/>
        /// </returns>
        public EMSPaymentVoucherFinalEntity GetEMSPaymentVoucherFinalEntityInstance()
        {
            return new EMSPaymentVoucherFinalEntity { EMSPaymentVoucherFinalId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSPaymentVoucherFinalOtherEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherFinalOtherEntity"/>
        /// </returns>
        public EMSPaymentVoucherFinalOtherEntity GetEMSPaymentVoucherFinalOtherEntityInstance()
        {
            return new EMSPaymentVoucherFinalOtherEntity { EMSPaymentVoucherFinalOtherId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSPaymentVoucherMiscEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherMiscEntity"/>
        /// </returns>
        public EMSPaymentVoucherMiscEntity GetEMSPaymentVoucherMiscEntityInstance()
        {
            return new EMSPaymentVoucherMiscEntity { EMSPaymentVoucherMiscId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSRecapitDetailsEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSRecapitDetailsEntity"/>
        /// </returns>
        public EMSRecapitDetailsEntity GetEMSRecapitDetailsEntityInstance()
        {
            return new EMSRecapitDetailsEntity { EMSRecapitDetailsId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSRecapitulationEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSRecapitulationEntity"/>
        /// </returns>
        public EMSRecapitulationEntity GetEMSRecapitulationEntityInstance()
        {
            return new EMSRecapitulationEntity { EMSRecapitulationId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSRecAuditEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSRecAuditEntity"/>
        /// </returns>
        public EMSRecAuditEntity GetEMSRecAuditEntityInstance()
        {
            return new EMSRecAuditEntity { EMSRecAuditId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSPaymentVoucherEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherEntity"/>
        /// </returns>
        public EMSRecChequeAuditEntity GetEMSRecChequeAuditEntityInstance()
        {
            return new EMSRecChequeAuditEntity { EMSRecChequeAuditId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSReceiptEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSReceiptEntity"/>
        /// </returns>
        public EMSReceiptEntity GetEMSReceiptEntityInstance()
        {
            return new EMSReceiptEntity { EMSReceiptId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSRecTransEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSRecTransEntity"/>
        /// </returns>
        public EMSRecTransEntity GetEMSRecTransEntityInstance()
        {
            return new EMSRecTransEntity { EMSRecTransId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentEntity"/>
        /// </returns>
        public EMSStateFundEntity GetEMSStateFundEntityInstance()
        {
            return new EMSStateFundEntity { EMSStateFundId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="EMSTeamMgmtEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSTeamMgmtEntity"/>
        /// </returns>
        public EMSTeamMgmtEntity GetEMSTeamMgmtEntityInstance()
        {
            return new EMSTeamMgmtEntity { EMSTeamMgmtId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// </summary>
        /// <returns>
        /// Returns <see cref="TaskListEntity"/>
        /// </returns>
        public TaskListEntity GetTaskListEntityInstance()
        {
            return new TaskListEntity { WorkflowSerialNo = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSAdmChargesEntity"/>
        /// </returns>
        public EMSAdmChargesEntity GetEMSAdmChargesEntityInstance()
        {
            return new EMSAdmChargesEntity { EMSAdmChargesId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSSaleEntity"/>
        /// </returns>
        public EMSSaleEntity GetEMSSaleEntityInstance()
        {
            return new EMSSaleEntity { EMSSaleId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSSaleAdvertEntity"/>
        /// </returns>
        public EMSSaleAdvertEntity GetEMSSaleAdvertEntityInstance()
        {
            return new EMSSaleAdvertEntity { EMSSaleAdvertId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSSaleAuctioneerEntity"/>
        /// </returns>
        public EMSSaleAuctioneerEntity GetEMSSaleAuctioneerEntityInstance()
        {
            return new EMSSaleAuctioneerEntity { EMSSaleAuctioneerId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSSaleAppraiserEntity"/>
        /// </returns>
        public EMSSaleAppraiserEntity GetEMSSaleAppraiserEntityInstance()
        {
            return new EMSSaleAppraiserEntity { AppraiserDetailId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSSaleAgentEntity"/>
        /// </returns>
        public EMSSaleAgentEntity GetEMSSaleAgentEntityInstance()
        {
            return new EMSSaleAgentEntity { SalesAgentDetailId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        #endregion Methods
    }
}