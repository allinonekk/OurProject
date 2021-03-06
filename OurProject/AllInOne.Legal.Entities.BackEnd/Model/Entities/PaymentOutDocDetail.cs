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

    /// <summary>Class which represents the entity 'SubCaseSpecific.PaymentOutDocDetail'</summary>
    public partial class PaymentOutDocDetail : ISubCaseSpecific
    {
        #region Fields

        private System.String _aGRefNumber;
        private Nullable<System.Decimal> _amount;
        private Nullable<System.Decimal> _amountApproved;
        private System.String _designation;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _partyName;
        private System.String _paymentOutId;
        private System.Collections.Generic.ICollection<PaymentOutPayInDetail> _paymentOutPayInDetails;
        private System.String _pOReason;

        //private RefOrderDetail _refOrderDetail;
        private System.String _remarks;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="PaymentOutDocDetail"/> class.</summary>
        public PaymentOutDocDetail()
            : base()
        {
            _paymentOutPayInDetails = new System.Collections.Generic.HashSet<PaymentOutPayInDetail>();
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

        /// <summary>Gets or sets the AmountApproved field. </summary>
        public virtual Nullable<System.Decimal> AmountApproved
        {
            get { return _amountApproved; }
            set { _amountApproved = value; }
        }

        /// <summary>Gets or sets the Designation field. </summary>
        public virtual System.String Designation
        {
            get { return _designation; }
            set { _designation = value; }
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

        /// <summary>Gets or sets the PartyName field. </summary>
        public virtual System.String PartyName
        {
            get { return _partyName; }
            set { _partyName = value; }
        }

        /// <summary>Gets or sets the PaymentOutId field. </summary>
        public virtual System.String PaymentOutId
        {
            get { return _paymentOutId; }
            set { _paymentOutId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCaseSpecific.PaymentOutPayInDetail.PaymentOutDocDetail - SubCaseSpecific.PaymentOutDocDetail.PaymentOutPayInDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<PaymentOutPayInDetail> PaymentOutPayInDetails
        {
            get { return _paymentOutPayInDetails; }
            set { _paymentOutPayInDetails = value; }
        }

        /// <summary>Gets or sets the POReason field. </summary>
        public virtual System.String POReason
        {
            get { return _pOReason; }
            set { _pOReason = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCaseSpecific.PaymentOutDocDetail.RefOrderDetail - Document.RefOrderDetail.PaymentOutDocDetails (m:1)'</summary>
        //public virtual RefOrderDetail RefOrderDetail
        //{
        //    get { return _refOrderDetail; }
        //    set { _refOrderDetail = value; }
        //}
        public virtual System.String RefOrderDetailId
        {
            get; set;
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public virtual System.String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
        }

        /// <summary>Gets or sets the PIRemarks field. </summary>
        public virtual System.String PIRemarks
        {
            get;
            set;
        }

        public virtual MCurrency MCurrency
        {
            get;
            set;
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
            PaymentOutDocDetail toCompareWith = obj as PaymentOutDocDetail;
            return toCompareWith == null ? false : ((this.PaymentOutId == toCompareWith.PaymentOutId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PaymentOutId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}