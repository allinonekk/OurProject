namespace AllInOne.Legal.Domain.Enforcement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AllInOne.Legal.Domain.SubCase;

    public class ProcessPaymentData
    {
        #region Properties

        public string AccountNo
        {
            get; set;
        }

        public decimal Amount
        {
            get; set;
        }

        public DateTime ApprovedDate
        {
            get; set;
        }

        public string ChequeNo
        {
            get; set;
        }

        //public EMSPaymentVoucherEntity EMSPaymentVoucher
        //{ get; set; }
        //public EMSAccountEntity EMSAccount
        //{ get; set; }
        //public SubCaseInfoEntity SubCaseInfo
        //{ get; set; }
        //public List<EMSPaymentVoucherFinalEntity> EMSPaymentVoucherFinal
        //{ get; set; }
        //public List<EMSPaymentOtherEntity> EMSPaymentOther
        //{ get; set; }
        public string EMSAccountId
        {
            get; set;
        }

        public string EMSPaymentId
        {
            get; set;
        }

        public string EMSPaymentVoucherId
        {
            get; set;
        }

        public string PayeeName
        {
            get; set;
        }

        public string PaymentVoucherNo
        {
            get; set;
        }

        public string SubCaseNo
        {
            get; set;
        }

        #endregion Properties
    }
}