namespace AllInOne.Legal.Domain.Enforcement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Represents a standard data container object for CaseParty.
    /// </summary>
    [Serializable]
    public class EMSPaymentVoucherData
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSDisburseClaimEntity.</value>
        public List<EMSDisburseClaimEntity> EMSDisburseClaimEntity
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSFileMovementEntity.</value>
        public List<EMSPaymentVoucherAdmEntity> EMSPaymentVoucherAdmEntity
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSPaymentVoucher.</value>
        public List<EMSPaymentVoucherChequeEntity> EMSPaymentVoucherChequeEntity
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSPaymentVoucher.</value>
        public List<EMSPaymentVoucherEntity> EMSPaymentVoucherEntity
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSPaymentVoucher.</value>
        public List<EMSPaymentVoucherFinalData> EMSPaymentVoucherFinalData
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSPaymentVoucherFinalEntity.</value>
        public List<EMSPaymentVoucherFinalEntity> EMSPaymentVoucherFinalEntity
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSReceiptEntity.</value>
        public List<EMSReceiptEntity> EMSReceiptEntity
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSTptClaimEntity.</value>
        public List<EMSTptClaimEntity> EMSTptClaimEntity
        {
            get;
            set;
        }

        #endregion Properties

        #region Other

        //This is to User. But User Entity is not created yet as the database schema has not comfirmed.
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <value>The EMSPaymentVoucher.</value>
        //public List<User> EMSPaymentVoucherFinalData
        //{
        //    get;
        //    set;
        //}

        #endregion Other
    }
}