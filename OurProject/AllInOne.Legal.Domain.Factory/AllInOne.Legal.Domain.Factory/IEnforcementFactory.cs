#region Header

/*****************************************************************************************************
 * Description : This file represents a standard interface for creating instances of objects related
 *              with Enforcement.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 31/12/2010                 Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: IEnforcementFactory.cs
// Description: Represents a standard interface for creating instances of objects related with Enforcement.
// </summary>
// <copyright file= "IEnforcementFactory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory
{
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Enforcement;

    /// <summary>
    /// Represents a standard interface for creating instances of objects related with Enforcement.
    /// </summary>
    public interface IEnforcementFactory
    {
        #region Methods
        
        /// <summary>
        /// Gets the <see cref="EMSRoundRobinAuctioneerEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSRoundRobinAuctioneerEntity"/>
        /// </returns>
        EMSRoundRobinAuctioneerEntity GetEMSRoundRobinAuctioneerEntityInstance();
        
        /// <summary>
        /// Gets the <see cref="EMSAttendanceFeeEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSAttendanceFeeEntity"/>
        /// </returns>
        EMSAttendanceFeeEntity GetEMSAttendanceFeeEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSAccountEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSAccountEntity"/>
        /// </returns>
        EMSAccountEntity GetEMSAccountEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSPaymentVoucherEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherEntity"/>
        /// </returns>
        EMSAppointmentEntity GetEMSAppointmentEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSCashBookItemEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSCashBookItemEntity"/>
        /// </returns>
        EMSCashBookItemEntity GetEMSCashBookItemEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSCashBookReconcileEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSCashBookReconcileEntity"/>
        /// </returns>
        EMSCashBookReconcileEntity GetEMSCashBookReconcileEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSChequeEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSChequeEntity"/>
        /// </returns>
        EMSChequeEntity GetEMSChequeEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSCivCrmReleaseEntity"/> instance.
        /// </summary>
        /// <returns> <see cref="EMSCivCrmReleaseEntity"/>
        /// </returns>
        EMSCivCrmReleaseEntity GetEMSCivCrmReleaseEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSChequeHistoryEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSChequeHistoryEntity"/>
        /// </returns>
        EMSChequeHistoryEntity GetEMSChequeHistoryEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSCourtCommissionEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSCourtCommissionEntity"/>
        /// </returns>
        EMSCourtCommissionEntity GetEMSCourtCommissionEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSExecLedgerEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSExecLedgerEntity"/>
        /// </returns>
        EMSExecLedgerEntity GetEMSExecLedgerEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSFileMovementEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSFileMovementEntity"/>
        /// </returns>
        EMSFileMovementEntity GetEMSFileMovementEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSOutstandingPaymentEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSOutstandingPaymentEntity"/>
        /// </returns>
        EMSOutstandingPaymentEntity GetEMSOutstandingPaymentEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSChequeEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSChequeEntity"/>
        /// </returns>
        EMSPaymentChequeEntity GetEMSPaymentChequeEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSPaymentEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentEntity"/>
        /// </returns>
        EMSPaymentEntity GetEMSPaymentEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSPaymentVoucherChequeEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherChequeEntity"/>
        /// </returns>
        EMSPaymentVoucherChequeEntity GetEMSPaymentVoucherChequeEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSPaymentVoucherEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherEntity"/>
        /// </returns>
        EMSPaymentVoucherEntity GetEMSPaymentVoucherEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSPaymentVoucherEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherEntity"/>
        /// </returns>
        EMSPaymentVoucherFinalEntity GetEMSPaymentVoucherFinalEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSPaymentVoucherEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherEntity"/>
        /// </returns>
        EMSPaymentVoucherFinalOtherEntity GetEMSPaymentVoucherFinalOtherEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSPaymentVoucherMiscEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherMiscEntity"/>
        /// </returns>
        EMSPaymentVoucherMiscEntity GetEMSPaymentVoucherMiscEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSRecapitDetailsEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSRecapitDetailsEntity"/>
        /// </returns>
        EMSRecapitDetailsEntity GetEMSRecapitDetailsEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSRecapitulationEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSRecapitulationEntity"/>
        /// </returns>
        EMSRecapitulationEntity GetEMSRecapitulationEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSRecAuditEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSRecAuditEntity"/>
        /// </returns>
        EMSRecAuditEntity GetEMSRecAuditEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSPaymentVoucherEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentVoucherEntity"/>
        /// </returns>
        EMSRecChequeAuditEntity GetEMSRecChequeAuditEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSReceiptEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSReceiptEntity"/>
        /// </returns>
        EMSReceiptEntity GetEMSReceiptEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSRecTransEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSRecTransEntity"/>
        /// </returns>
        EMSRecTransEntity GetEMSRecTransEntityInstance();

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSPaymentEntity"/>
        /// </returns>
        EMSStateFundEntity GetEMSStateFundEntityInstance();

        /// <summary>
        /// Gets the <see cref="EMSTeamMgmtEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSTeamMgmtEntity"/>
        /// </returns>
        EMSTeamMgmtEntity GetEMSTeamMgmtEntityInstance();

        /// </summary>
        /// <returns>
        /// Returns <see cref="TaskListEntity"/>
        /// </returns>
        TaskListEntity GetTaskListEntityInstance();

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSAdmChargesEntity"/>
        /// </returns>
        EMSAdmChargesEntity GetEMSAdmChargesEntityInstance();
        
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSSaleEntity"/>
        /// </returns>
        EMSSaleEntity GetEMSSaleEntityInstance();
        
        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSSaleAdvertEntity"/>
        /// </returns>
        EMSSaleAdvertEntity GetEMSSaleAdvertEntityInstance();

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSSaleAuctioneerEntity"/>
        /// </returns>
        EMSSaleAuctioneerEntity GetEMSSaleAuctioneerEntityInstance();

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSSaleAppraiserEntity"/>
        /// </returns>
        EMSSaleAppraiserEntity GetEMSSaleAppraiserEntityInstance();

        /// </summary>
        /// <returns>
        /// Returns <see cref="EMSSaleAgentEntity"/>
        /// </returns>
        EMSSaleAgentEntity GetEMSSaleAgentEntityInstance();
        #endregion Methods
    }
}