#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RDocLawFirm.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 04/10/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: RDocLawFirmEntity.cs
// Description: Represents a standard RDocLawFirm.
// </summary>
// <copyright file= "RDocLawFirmEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for RDocLawFirm.
    /// It inherits from <see cref="AbstractDocId"/>
    /// </summary>
    [Serializable]
    public class Temp_ProcessingInfoEntity : IDocumentEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Temp_ProcessingInfoEntity"/> class.
        /// </summary>
        public Temp_ProcessingInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public string WorkflowSerialNo { get; set; }
        public string DocID { get; set; }
        public string ProcessedBy { get; set; }
        public DateTime ProcessedTime { get; set; }
        public string DocStatusCode { get; set; }
        public string BackdateApprInd { get; set; }
        public DateTime? BackDateTime { get; set; }
        public string JOUserIdApprBackDate { get; set; }
        public string BackDateReasonFrLawFirm { get; set; }
        public string BackDateReasonFrCourt { get; set; }
        public DateTime? HearingDateTime { get; set; }
        public string SpecHandlingReqInd { get; set; }
        public string SpecHandlingReqRsn { get; set; }
        public string SpecHandlingReqRem { get; set; }
        public string WaiverInd { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? LFWaiverReqFee { get; set; }
        public string LFWaiverReqReason { get; set; }
        public string WaiverApproveInd { get; set; }
        public string WaiverApproveUserId { get; set; }
        public decimal? WaiverApprFee { get; set; }
        public string WaiverApprReason { get; set; }
        public string Remarks { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public decimal? DocFeeWaived { get; set; }
        public decimal? TransFeeWaived { get; set; }
        public decimal? ProcFeeWaived { get; set; }
        public decimal? UrgFeeWaived { get; set; }
        public decimal? TotalWaived { get; set; }
        public decimal? TotalPayable { get; set; }
        public decimal? AdminFee { get; set; }
        public string RejectionReason { get; set; }
        public string processingstatus { get; set; }
        public string ErrorMsg { get; set; }
        public int? AttemptCount { get; set; }
        public string ReqDecision { get; set; }
        public string ReqDecisionRemark { get; set; }
        public string HrgDateToBeFixedInd { get; set; }
        public string IsFinalAdjournment { get; set; }
        public decimal? ColorPageFee { get; set; }
        public decimal? DocFee { get; set; }
        public decimal? TotalFeeComp { get; set; }
        public string RejectionFeeActionType { get; set; }
        public DateTime? ActualTaskProcessingDateTime { get; set; }

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

            Temp_ProcessingInfoEntity toCompareWith = obj as Temp_ProcessingInfoEntity;
            return toCompareWith == null ? false : ((this.WorkflowSerialNo == toCompareWith.WorkflowSerialNo) && (this.DocID == toCompareWith.DocID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocID.GetHashCode();
            toReturn ^= this.WorkflowSerialNo.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}