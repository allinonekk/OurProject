namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    [Serializable]
    public class DocProcessingInfoEntity
    {
        #region Constructors

        public DocProcessingInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AdminFee field. </summary>	
        public Decimal? AdminFee
        {
            get; set;
        }

        /// <summary>Gets or sets the BackdateApprInd field. </summary>	
        public String BackdateApprInd
        {
            get; set;
        }

        /// <summary>Gets or sets the BackDateReasonFrCourt field. </summary>	
        public String BackDateReasonFrCourt
        {
            get; set;
        }

        /// <summary>Gets or sets the BackDateReasonFrLawFirm field. </summary>	
        public String BackDateReasonFrLawFirm
        {
            get; set;
        }

        /// <summary>Gets or sets the BackDateTime field. </summary>	
        public DateTime BackDateTime
        {
            get; set;
        }

        /// <summary>Gets or sets the DocFeeWaived field. </summary>	
        public Decimal? DocFeeWaived
        {
            get; set;
        }

        /// <summary>Gets or sets the DocID field. </summary>	
        public String DocID
        {
            get; set;
        }

        /// <summary>Gets or sets the HearingDateTime field. </summary>	
        public virtual Nullable<System.DateTime> HearingDateTime
        {
            get; set;
        }

        /// <summary>Gets or sets the JOUserIdApprBackDate field. </summary>	
        public String JOUserIdApprBackDate
        {
            get; set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>	
        public String LastModifiedBy
        {
            get; set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>	
        public DateTime LastModifiedDate
        {
            get; set;
        }

        /// <summary>Gets or sets the LFWaiverReqFee field. </summary>	
        public System.Decimal? LFWaiverReqFee
        {
            get; set;
        }

        /// <summary>Gets or sets the LFWaiverReqReason field. </summary>	
        public String LFWaiverReqReason
        {
            get; set;
        }

        /// <summary>Gets or sets the ProcessedBy field. </summary>	
        public String ProcessedBy
        {
            get; set;
        }

        /// <summary>Gets or sets the ProcessedTime field. </summary>	
        public DateTime ProcessedTime
        {
            get; set;
        }

        /// <summary>Gets or sets the ProcFeeWaived field. </summary>	
        public virtual Nullable<System.Decimal> ProcFeeWaived
        {
            get; set;
        }

        /// <summary>Gets or sets the RejectionReason field. </summary>	
        public String RejectionReason
        {
            get; set;
        }

        /// <summary>Gets or sets the Remarks field. </summary>	
        public String Remarks
        {
            get; set;
        }

        /// <summary>Gets or sets the SpecHandlingReqInd field. </summary>	
        public String SpecHandlingReqInd
        {
            get; set;
        }

        /// <summary>Gets or sets the SpecHandlingReqRem field. </summary>	
        public String SpecHandlingReqRem
        {
            get; set;
        }

        /// <summary>Gets or sets the SpecHandlingReqRsn field. </summary>	
        public String SpecHandlingReqRsn
        {
            get; set;
        }

        /// <summary>Gets or sets the TotalPayable field. </summary>	
        public Decimal? TotalPayable
        {
            get; set;
        }

        /// <summary>Gets or sets the TotalWaived field. </summary>	
        public Decimal? TotalWaived
        {
            get; set;
        }

        /// <summary>Gets or sets the TransFeeWaived field. </summary>	
        public Decimal? TransFeeWaived
        {
            get; set;
        }

        /// <summary>Gets or sets the UrgFeeWaived field. </summary>	
        public Decimal? UrgFeeWaived
        {
            get; set;
        }

        /// <summary>Gets or sets the WaiverApprFee field. </summary>	
        public Decimal? WaiverApprFee
        {
            get; set;
        }

        /// <summary>Gets or sets the WaiverApproveInd field. </summary>	
        public String WaiverApproveInd
        {
            get; set;
        }

        /// <summary>Gets or sets the WaiverApproveUserId field. </summary>	
        public String WaiverApproveUserId
        {
            get; set;
        }

        /// <summary>Gets or sets the WaiverApprReason field. </summary>	
        public String WaiverApprReason
        {
            get; set;
        }

        /// <summary>Gets or sets the WaiverInd field. </summary>	
        public String WaiverInd
        {
            get; set;
        }

        /// <summary>Gets or sets the WorkflowSerialNo field. </summary>	
        public String WorkflowSerialNo
        {
            get; set;
        }

        #endregion Properties

        #region Other

        ///// <summary>Represents the navigator which is mapped onto the association 'K2.TempProcessingInfo.MCurrency - Master.MCurrency.TempProcessingInfos (m:1)'</summary>
        //public virtual MCurrency MCurrency
        //{
        //    get;
        //    set;
        //}
        ///// <summary>Represents the navigator which is mapped onto the association 'K2.TempProcessingInfo.MDocStatu - Master.MDocStatus.TempProcessingInfos (m:1)'</summary>
        //public virtual MDocStatus MDocStatus
        //{
        //    get;
        //    set;
        //}

        #endregion Other
    }
}