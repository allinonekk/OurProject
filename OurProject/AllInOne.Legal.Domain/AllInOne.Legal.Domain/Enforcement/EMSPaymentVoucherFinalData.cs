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
    public class EMSPaymentVoucherFinalData
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSPaymentVoucher.</value>
        public List<EMSPaymentVoucherAdmEntity> EMSPaymentVoucherAdmEntity
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSPaymentVoucher.</value>
        public List<EMSPaymentVoucherFinalEntity> EMSPaymentVoucherFinalEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}