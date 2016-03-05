namespace AllInOne.Legal.Domain.Enforcement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Legal.Domain.HQuery;

    public class EnforcementHQueryResultEntity : QueryResultEntity
    {
        #region Properties

        /// <summary>Gets or sets the EMSAccountId field. </summary>
        public System.String EMSAccountId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSAccountNo field. </summary>
        public System.String EMSAccountNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AccountSerialNo field. </summary>
        public System.Int32 AccountSerialNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AccountYear field. </summary>
        public System.Int32 AccountYear
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AccountNoCreatedDate field. </summary>
        public System.DateTime AccountNoCreatedDate
        {//CR-ENFUAT-2012082901 - Mantis: 0006104
            get;
            set;
        }

        /// <summary>Gets or sets the LastUpdatedBy field. </summary>
        public System.String LastUpdatedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastUpdatedDate field. </summary>
        public System.DateTime LastUpdatedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PartyName field. </summary>
        public System.String PartyName
        {
            get;
            set;
        }

        #endregion Properties
    }

    public class EnfrocementMaintainChequeQREntity : EnforcementHQueryResultEntity
    {
        #region Properties

        /// <summary>Gets or sets the ApprovedDate field. </summary>
        public System.DateTime ApprovedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSChequeAmount field. </summary>
        public System.Decimal ChequeAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ChequeNo field. </summary>
        public System.String ChequeNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ChequeRemarks field. </summary>
        public System.String ChequeRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ChequeStatus field. </summary>
        public PaymentChequeStatus ChequeStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSChequeHistoryId field. </summary>
        public System.String EMSChequeHistoryId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSPaymentId field. </summary>
        public System.String EMSChequeId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSPaymentId field. </summary>
        public System.String EMSPaymentId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSPaymentAmount field. </summary>
        public System.Decimal PaymentAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PaymentDate field. </summary>
        public System.DateTime PaymentDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PaymentOfficerName field. </summary>
        public System.String PaymentOfficerName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PaymentVoucherId field. </summary>
        public System.String PaymentVoucherId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PaymentVoucherNo field. </summary>
        public System.String PaymentVoucherNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsReIssued field. </summary>
        public System.String IsReIssued
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsHistoryRecord field. </summary>
        public MaintainChequeType MaintainChequeType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSPaymentVoucherType field. </summary>
        public PaymentVoucherType PaymentVoucherType
        {
            get;
            set;
        }

        #endregion Properties
    }

    public class EnfrocementProcessPaymentQREntity : EnforcementHQueryResultEntity
    {
        #region Properties

        /// <summary>Gets or sets the ApprovedDate field. </summary>
        public System.DateTime ApprovedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ChequeNo field. </summary>
        public System.String ChequeNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ChequeStatus field. </summary>
        public PaymentChequeStatus ChequeStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSChequeAmount field. </summary>
        public System.Decimal EMSChequeAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSPaymentAmount field. </summary>
        public System.Decimal EMSPaymentAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSPaymentId field. </summary>
        public System.String EMSPaymentId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSPaymentVoucherId field. </summary>
        public System.String EMSPaymentVoucherId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSPaymentVoucherNo field. </summary>
        public System.String EMSPaymentVoucherNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PaymentDate field. </summary>
        public System.DateTime PaymentDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PaymentStatus field. </summary>
        public System.String PaymentStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PaymentType field. </summary>
        public PaymentType PaymentType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSPaymentVoucherType field. </summary>
        public PaymentVoucherType PaymentVoucherType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OCDocId field. </summary>
        public System.String OCDocId
        {//CR-ENFUAT-2012090101
            get;
            set;
        }

        #endregion Properties
    }
}