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

    /// <summary>Class which represents the entity 'SubCaseSpecific.PaymentOutPayInDetail'</summary>
    public partial class PaymentOutPayInDetail : ISubCaseSpecific
    {
        #region Fields

        private Nullable<System.Decimal> _amountOut;
        private Nullable<System.Int64> _caseInfoId;
        private System.String _caseNo;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MCourtType _mCourtType;

        //private PaymentInDocDetail _paymentInDocDetail;
        //private PaymentOutDocDetail _paymentOutDocDetail;
        private System.String _paymentOutInId;
        private Nullable<System.Int64> _subCaseInfoId;
        private System.String _subCaseNo;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="PaymentOutPayInDetail"/> class.</summary>
        public PaymentOutPayInDetail()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AmountOut field. </summary>
        public virtual Nullable<System.Decimal> AmountOut
        {
            get { return _amountOut; }
            set { _amountOut = value; }
        }

        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public virtual Nullable<System.Int64> CaseInfoId
        {
            get { return _caseInfoId; }
            set { _caseInfoId = value; }
        }

        /// <summary>Gets or sets the CaseNo field. </summary>
        public virtual System.String CaseNo
        {
            get { return _caseNo; }
            set { _caseNo = value; }
        }

        /// <summary>Gets or sets the IsBackEndUserAdded field. </summary>
        public virtual System.String IsBackEndUserAdded
        {
            get;
            set;
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

        /// <summary>Represents the navigator which is mapped onto the association 'SubCaseSpecific.PaymentOutPayInDetail.MCourtType - Master.MCourtType.PaymentOutPayInDetails (m:1)'</summary>
        public virtual MCourtType MCourtType
        {
            get { return _mCourtType; }
            set { _mCourtType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCaseSpecific.PaymentOutPayInDetail.PaymentInDocDetail - SubCaseSpecific.PaymentInDocDetail.PaymentOutPayInDetails (m:1)'</summary>
        //public virtual PaymentInDocDetail PaymentInDocDetail
        //{
        //    get { return _paymentInDocDetail; }
        //    set { _paymentInDocDetail = value; }
        //}
        public virtual System.String PaymentInId
        {
            get; set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCaseSpecific.PaymentOutPayInDetail.PaymentOutDocDetail - SubCaseSpecific.PaymentOutDocDetail.PaymentOutPayInDetails (m:1)'</summary>
        //public virtual PaymentOutDocDetail PaymentOutDocDetail
        //{
        //    get { return _paymentOutDocDetail; }
        //    set { _paymentOutDocDetail = value; }
        //}
        public virtual System.String PaymentOutId
        {
            get; set;
        }

        /// <summary>Gets or sets the PaymentOutInId field. </summary>
        public virtual System.String PaymentOutInId
        {
            get { return _paymentOutInId; }
            set { _paymentOutInId = value; }
        }

        /// <summary>Gets or sets the SubCaseInfoId field. </summary>
        public virtual Nullable<System.Int64> SubCaseInfoId
        {
            get { return _subCaseInfoId; }
            set { _subCaseInfoId = value; }
        }

        /// <summary>Gets or sets the SubCaseNo field. </summary>
        public virtual System.String SubCaseNo
        {
            get { return _subCaseNo; }
            set { _subCaseNo = value; }
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
        }


        public virtual int? ItemNo { get; set; }

        public virtual MCurrency MCurrency { get; set; }
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
            PaymentOutPayInDetail toCompareWith = obj as PaymentOutPayInDetail;
            return toCompareWith == null ? false : ((this.PaymentOutInId == toCompareWith.PaymentOutInId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PaymentOutInId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}