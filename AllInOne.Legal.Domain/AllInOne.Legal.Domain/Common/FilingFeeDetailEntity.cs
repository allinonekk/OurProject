#region Header

/*****************************************************************************************************
* Description : This file represents a standard FilingFeeDetail entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   14/11/2010                 Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: FilingFeeDetailEntity.cs
// Description: Represents a standard FilingFeeDetail entity.
// </summary>
// <copyright file= "FilingFeeDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for FilingFeeDetail.
    /// It inherits from <see cref="AbstractDocId"/>
    /// </summary>
    [Serializable]
    public class FilingFeeDetailEntity : AbstractDocId, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AdminFee field.
        /// </summary>
        /// <value>The admin fee.</value>
        public Decimal? AdminFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BilledDate field.
        /// </summary>
        /// <value>The billed date.</value>
        public DateTime BilledDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocFee field.
        /// </summary>
        /// <value>The doc fee.</value>
        public Decimal DocFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocFeeWaived field.
        /// </summary>
        /// <value>The doc fee waived.</value>
        public Decimal? DocFeeWaived
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocFeeWaiverReq field.
        /// </summary>
        /// <value>The doc fee waiver req.</value>
        public Decimal? DocFeeWaiverReq
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FeeCode field.
        /// </summary>
        /// <value>The fee code.</value>
        public String FeeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FeePaid field.
        /// </summary>
        /// <value>The fee paid.</value>
        public Decimal? FeePaid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FilingFeeDetailId field.
        /// </summary>
        /// <value>The filing fee detail id.</value>
        public String FilingFeeDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsEstimated field.
        /// </summary>
        /// <value>The is estimated.</value>
        public YesNo IsEstimated
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public YesNo IsInterfaced
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsUrgentHandling field.
        /// </summary>
        /// <value>The is urgent handling.</value>
        public YesNo IsUrgentHandling
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawSocietyComFundAppWaiver field.
        /// </summary>
        /// <value>The LawSocietyComFundAppWaiver.</value>
        public Decimal? LawSocietyComFundAppWaiver
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawSocietyComFundFee field.
        /// </summary>
        /// <value>The LawSocietyComFundFee.</value>
        public Decimal? LawSocietyComFundFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawSocietyComFundWaiverReq field.
        /// </summary>
        /// <value>The LawSocietyComFundWaiverReq.</value>
        public Decimal? LawSocietyComFundWaiverReq
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawSocietyMemFee field.
        /// </summary>
        /// <value>The LawSocietyMemFee.</value>
        public Decimal? LawSocietyMemFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawSocietyMemFeeAppWaiver field.
        /// </summary>
        /// <value>The LawSocietyMemFeeAppWaiver.</value>
        public Decimal? LawSocietyMemFeeAppWaiver
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawSocietyMemFeeWaiverReq field.
        /// </summary>
        /// <value>The LawSocietyMemFeeWaiverReq.</value>
        public Decimal? LawSocietyMemFeeWaiverReq
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawSocietyPenaltyAppWaiver field.
        /// </summary>
        /// <value>The LawSocietyPenaltyAppWaiver.</value>
        public Decimal? LawSocietyPenaltyAppWaiver
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawSocietyPenaltyFee field.
        /// </summary>
        /// <value>The LawSocietyPenaltyFee.</value>
        public Decimal? LawSocietyPenaltyFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawSocietyPenaltyWaiverReq field.
        /// </summary>
        /// <value>The LawSocietyPenaltyWaiverReq.</value>
        public Decimal? LawSocietyPenaltyWaiverReq
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawSocietyRejFeeType field.
        /// </summary>
        /// <value>The LawSocietyRejFeeType.</value>
        public YesNo LawSocietyRejFeeType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawSocietyWaiverAppInd field.
        /// </summary>
        /// <value>The LawSocietyWaiverAppInd.</value>
        public WaiverInd LawSocietyWaiverAppInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawSocietyWaiverReason field.
        /// </summary>
        /// <value>The LawSocietyWaiverReason.</value>
        public String LawSocietyWaiverReason
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ProcFee field.
        /// </summary>
        /// <value>The proc fee.</value>
        public Decimal ProcFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ProcFeeWaived field.
        /// </summary>
        /// <value>The proc fee waived.</value>
        public Decimal? ProcFeeWaived
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ProcFeeWaiverReq field.
        /// </summary>
        /// <value>The proc fee waiver req.</value>
        public Decimal? ProcFeeWaiverReq
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ReasonForDeduction field.
        /// </summary>
        /// <value>The reason for deduction.</value>
        public String ReasonForDeduction
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SALRejFeeType field.
        /// </summary>
        /// <value>The SALRejFeeType.</value>
        public YesNo SALRejFeeType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SALSubscriptionAppWaiver field.
        /// </summary>
        /// <value>The SALSubscriptionAppWaiver.</value>
        public Decimal? SALSubscriptionAppWaiver
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SALSubscriptionFee field.
        /// </summary>
        /// <value>The SALSubscriptionFee.</value>
        public Decimal? SALSubscriptionFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SALSubscriptionWaiverReq field.
        /// </summary>
        /// <value>The SALSubscriptionWaiverReq.</value>
        public Decimal? SALSubscriptionWaiverReq
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SALWaiverAppInd field.
        /// </summary>
        /// <value>The SALWaiverAppInd.</value>
        public WaiverInd SALWaiverAppInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SALWaiverReason field.
        /// </summary>
        /// <value>The SALWaiverReason.</value>
        public String SALWaiverReason
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SBFee field.
        /// </summary>
        /// <value>The SB fee.</value>
        public Decimal? SBFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SBFeeWaived field.
        /// </summary>
        /// <value>The SB fee waived.</value>
        public Decimal? SBFeeWaived
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SBFeeWaiverReq field.
        /// </summary>
        /// <value>The SB fee waiver req.</value>
        public Decimal? SBFeeWaiverReq
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SBHandlingFee field.
        /// </summary>
        /// <value>The SB handling fee.</value>
        public Decimal? SBHandlingFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SBScanningFee field.
        /// </summary>
        /// <value>The SB scanning fee.</value>
        public Decimal? SBScanningFee
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SILEFee field. </summary>
        public Decimal? SILEFee
        {
            get; set;
        }

        /// <summary>Gets or sets the SILEFeeAppWaiver field. </summary>
        public Decimal? SILEFeeAppWaiver
        {
            get; set;
        }

        /// <summary>Gets or sets the SILEFeeWaiverReq field. </summary>
        public Decimal? SILEFeeWaiverReq
        {
            get; set;
        }

        /// <summary>Gets or sets the SILERejFeeType field. </summary>
        public YesNo SILERejFeeType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the TotalFeeComp field.
        /// </summary>
        /// <value>The total fee comp.</value>
        public Decimal? TotalFeeComp
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TotalPayable field.
        /// </summary>
        /// <value>The total payable.</value>
        public Decimal TotalPayable
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TotalWaived field.
        /// </summary>
        /// <value>The total waived.</value>
        public Decimal TotalWaived
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TotalWaiverReq field.
        /// </summary>
        /// <value>The total waiver req.</value>
        public Decimal? TotalWaiverReq
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TransFee field.
        /// </summary>
        /// <value>The trans fee.</value>
        public Decimal TransFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TransFeeWaived field.
        /// </summary>
        /// <value>The trans fee waived.</value>
        public Decimal? TransFeeWaived
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TransFeeWaiverReq field.
        /// </summary>
        /// <value>The trans fee waiver req.</value>
        public Decimal? TransFeeWaiverReq
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UrgFee field.
        /// </summary>
        /// <value>The urg fee.</value>
        public Decimal? UrgFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UrgFeeWaived field.
        /// </summary>
        /// <value>The urg fee waived.</value>
        public Decimal? UrgFeeWaived
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UrgFeeWaiverReq field.
        /// </summary>
        /// <value>The urg fee waiver req.</value>
        public Decimal? UrgFeeWaiverReq
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WaiverType field.
        /// </summary>
        /// <value>The type of the waiver.</value>
        public WaiverType WaiverType
        {
            get;
            set;
        }

        public String ModeofPayment //TODO: NOt sure of the possible value Later Need to change to enum.
        {
            get;
            set;
        }

        public YesNo IsPaymentCollected
        {
            get;
            set;
        }

        public Decimal? ColorPageFee
        {
            get;
            set;
        }

        public Decimal?  ColorPageFeeWaived
        {
            get;
            set;
        }

        public decimal? TierType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ct HRG date.
        /// </summary>
        /// <value>
        /// The ct HRG date.
        /// </value>
        public DateTime? CTHrgDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the actual filing date.
        /// </summary>
        /// <value>
        /// The actual filing date.
        /// </value>
        public DateTime? ActualFilingDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the taxation claim amt.
        /// </summary>
        /// <value>
        /// The taxation claim amt.
        /// </value>
        public Decimal? TaxationClaimAmt
        {
            get;
            set;
        }

        public string SubCaseFeeForumID { get; set; }

        public decimal? SubCaseFeeTierType { get; set; }

        public DateTime? ActualProcTime { get; set; }

        /// <summary>
        /// Gets or sets the IsPOHARelated field.
        /// </summary>
        /// <value>The is POHA related.</value>
        public YesNo IsPOHARelated
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            FilingFeeDetailEntity toCompareWith = obj as FilingFeeDetailEntity;
            return toCompareWith == null ? false : ((this.FilingFeeDetailId == toCompareWith.FilingFeeDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FilingFeeDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}