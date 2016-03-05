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
    public class EMSAccountData
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSAccount.</value>
        public List<EMSAccountEntity> EMSAccount
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSPaymentVoucher.</value>
        public List<EMSPaymentVoucherData> EMSPaymentVoucherData
        {
            get;
            set;
        }

        #endregion Properties
    }
}