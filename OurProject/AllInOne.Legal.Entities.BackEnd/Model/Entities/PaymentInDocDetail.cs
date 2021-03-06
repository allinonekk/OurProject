﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>Class which represents the entity 'SubCaseSpecific.PaymentInDocDetail'</summary>
    public partial class PaymentInDocDetail : ISubCaseSpecific
    {
        #region Fields

        private System.String _aGRefNumber;
        private Nullable<System.Decimal> _amount;
        private Nullable<System.Decimal> _amountSGD;
        private System.String _hasTransferredOut;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MCurrency _mCurrency;
        private System.Collections.Generic.ICollection<NotPaymentToCourtDocDetail> _notPaymentToCourtDocDetails;
        private System.String _payingInType;
        private System.Collections.Generic.ICollection<PaymentInDocFSDetail> _paymentInDocFSDetails;
        private System.String _paymentInId;
        private System.String _paymentInReason;
        private System.Collections.Generic.ICollection<PaymentOutPayInDetail> _paymentOutPayInDetails;
        private System.String _reason;

        //private RefOrderDetail _refOrderDetail;
        private System.String _ruleNo;
        private System.String _ruleOrderNo;
        private System.String _submissionGroupId;
        private Nullable<System.Decimal> _transferredOutAmount;
        private Nullable<System.DateTime> _transferredOutDate;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="PaymentInDocDetail"/> class.</summary>
        public PaymentInDocDetail()
            : base()
        {
            _paymentInDocFSDetails = new System.Collections.Generic.HashSet<PaymentInDocFSDetail>();
            _paymentOutPayInDetails = new System.Collections.Generic.HashSet<PaymentOutPayInDetail>();
            _notPaymentToCourtDocDetails = new System.Collections.Generic.HashSet<NotPaymentToCourtDocDetail>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AGRefNumber field. </summary>
        public virtual System.String AGRefNumber
        {
            get { return _aGRefNumber; }
            set { _aGRefNumber = value; }
        }

        /// <summary>Gets or sets the Amount field. </summary>
        public virtual Nullable<System.Decimal> Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        /// <summary>Gets or sets the AmountSGD field. </summary>
        public virtual Nullable<System.Decimal> AmountSGD
        {
            get { return _amountSGD; }
            set { _amountSGD = value; }
        }

        /// <summary>Gets or sets the HasTransferredOut field. </summary>
        public virtual System.String HasTransferredOut
        {
            get { return _hasTransferredOut; }
            set { _hasTransferredOut = value; }
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get { return _lastModifiedBy; }
            set { _lastModifiedBy = value; }
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get { return _lastModifiedDate; }
            set { _lastModifiedDate = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCaseSpecific.PaymentInDocDetail.MCurrency - Master.MCurrency.PaymentInDocDetails (m:1)'</summary>
        public virtual MCurrency MCurrency
        {
            get { return _mCurrency; }
            set { _mCurrency = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Subsequent.NotPaymentToCourtDocDetail.PaymentInDocDetail - SubCaseSpecific.PaymentInDocDetail.NotPaymentToCourtDocDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<NotPaymentToCourtDocDetail> NotPaymentToCourtDocDetails
        {
            get { return _notPaymentToCourtDocDetails; }
            set { _notPaymentToCourtDocDetails = value; }
        }

        /// <summary>Gets or sets the PayingInType field. </summary>
        public virtual System.String PayingInType
        {
            get { return _payingInType; }
            set { _payingInType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCaseSpecific.PaymentInDocFSDetail.PaymentInDocDetail - SubCaseSpecific.PaymentInDocDetail.PaymentInDocFSDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<PaymentInDocFSDetail> PaymentInDocFSDetails
        {
            get { return _paymentInDocFSDetails; }
            set { _paymentInDocFSDetails = value; }
        }

        /// <summary>Gets or sets the PaymentInId field. </summary>
        public virtual System.String PaymentInId
        {
            get { return _paymentInId; }
            set { _paymentInId = value; }
        }

        /// <summary>Gets or sets the PaymentInReason field. </summary>
        public virtual System.String PaymentInReason
        {
            get { return _paymentInReason; }
            set { _paymentInReason = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCaseSpecific.PaymentOutPayInDetail.PaymentInDocDetail - SubCaseSpecific.PaymentInDocDetail.PaymentOutPayInDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<PaymentOutPayInDetail> PaymentOutPayInDetails
        {
            get { return _paymentOutPayInDetails; }
            set { _paymentOutPayInDetails = value; }
        }

        /// <summary>Gets or sets the Reason field. </summary>
        public virtual System.String Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCaseSpecific.PaymentInDocDetail.RefOrderDetail - Document.RefOrderDetail.PaymentInDocDetails (m:1)'</summary>
        //public virtual RefOrderDetail RefOrderDetail
        //{
        //    get { return _refOrderDetail; }
        //    set { _refOrderDetail = value; }
        //}
        public virtual System.String RefOrderDetailId
        {
            get; set;
        }

        /// <summary>Gets or sets the RuleNo field. </summary>
        public virtual System.String RuleNo
        {
            get { return _ruleNo; }
            set { _ruleNo = value; }
        }

        /// <summary>Gets or sets the RuleOrderNo field. </summary>
        public virtual System.String RuleOrderNo
        {
            get { return _ruleOrderNo; }
            set { _ruleOrderNo = value; }
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
        }

        /// <summary>Gets or sets the TransferredOutAmount field. </summary>
        public virtual Nullable<System.Decimal> TransferredOutAmount
        {
            get { return _transferredOutAmount; }
            set { _transferredOutAmount = value; }
        }

        /// <summary>Gets or sets the TransferredOutDate field. </summary>
        public virtual Nullable<System.DateTime> TransferredOutDate
        {
            get { return _transferredOutDate; }
            set { _transferredOutDate = value; }
        }

        public virtual int? ItemNo { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            PaymentInDocDetail toCompareWith = obj as PaymentInDocDetail;
            return toCompareWith == null ? false : ((this.PaymentInId == toCompareWith.PaymentInId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PaymentInId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}