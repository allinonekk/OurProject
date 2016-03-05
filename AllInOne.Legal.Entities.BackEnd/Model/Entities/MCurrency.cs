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

    /// <summary>Class which represents the entity 'Master.MCurrency'</summary>
    public partial class MCurrency : IMaster
    {
        #region Fields

        private System.Collections.Generic.ICollection<BankruptcyInfo> _bankruptcyInfos;
        private System.String _currencyCode;
        private System.String _description;
        private System.Collections.Generic.ICollection<DocumentInfo> _documentInfos;
        private Nullable<System.Int32> _frequencyInd;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.Collections.Generic.ICollection<LiquidatedClaim> _liquidatedClaims;
        private System.Collections.Generic.ICollection<NotPaymentToCourtDocDetail> _notPaymenttoCourtDocDetails;
        private System.String _obsInd;
        private System.Collections.Generic.ICollection<PaymentInDocDetail> _paymentInDocDetails;
        private System.Collections.Generic.ICollection<PaymentInDocFSDetail> _paymentInDocFSDetails;
        private Nullable<System.Int32> _sortingType;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MCurrency"/> class.</summary>
        public MCurrency()
            : base()
        {
            _bankruptcyInfos = new System.Collections.Generic.HashSet<BankruptcyInfo>();
            _liquidatedClaims = new System.Collections.Generic.HashSet<LiquidatedClaim>();
            _documentInfos = new System.Collections.Generic.HashSet<DocumentInfo>();
            _paymentInDocDetails = new System.Collections.Generic.HashSet<PaymentInDocDetail>();
            _paymentInDocFSDetails = new System.Collections.Generic.HashSet<PaymentInDocFSDetail>();
            _notPaymenttoCourtDocDetails = new System.Collections.Generic.HashSet<NotPaymentToCourtDocDetail>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.BankruptcyInfo.MCurrency - Master.MCurrency.BankruptcyInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<BankruptcyInfo> BankruptcyInfos
        {
            get { return _bankruptcyInfos; }
            set { _bankruptcyInfos = value; }
        }

        /// <summary>Gets or sets the CurrencyCode field. </summary>
        public virtual System.String CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocumentInfo.MCurrency - Master.MCurrency.DocumentInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocumentInfo> DocumentInfos
        {
            get { return _documentInfos; }
            set { _documentInfos = value; }
        }

        /// <summary>Gets or sets the FrequencyInd field. </summary>
        public virtual Nullable<System.Int32> FrequencyInd
        {
            get { return _frequencyInd; }
            set { _frequencyInd = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'Common.LiquidatedClaim.MCurrency - Master.MCurrency.LiquidatedClaims (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LiquidatedClaim> LiquidatedClaims
        {
            get { return _liquidatedClaims; }
            set { _liquidatedClaims = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Subsequent.NotPaymentToCourtDocDetail.MCurrency - Master.MCurrency.NotPaymenttoCourtDocDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<NotPaymentToCourtDocDetail> NotPaymenttoCourtDocDetails
        {
            get { return _notPaymenttoCourtDocDetails; }
            set { _notPaymenttoCourtDocDetails = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCaseSpecific.PaymentInDocDetail.MCurrency - Master.MCurrency.PaymentInDocDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<PaymentInDocDetail> PaymentInDocDetails
        {
            get { return _paymentInDocDetails; }
            set { _paymentInDocDetails = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCaseSpecific.PaymentInDocFSDetail.MCurrency - Master.MCurrency.PaymentInDocFSDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<PaymentInDocFSDetail> PaymentInDocFSDetails
        {
            get { return _paymentInDocFSDetails; }
            set { _paymentInDocFSDetails = value; }
        }

        /// <summary>Gets or sets the SortingType field. </summary>
        public virtual Nullable<System.Int32> SortingType
        {
            get { return _sortingType; }
            set { _sortingType = value; }
        }

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
            MCurrency toCompareWith = obj as MCurrency;
            return toCompareWith == null ? false : ((this.CurrencyCode == toCompareWith.CurrencyCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CurrencyCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}