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

    /// <summary>Class which represents the entity 'Enforcement.EMSCheque'</summary>
    public partial class EMSCheque : IEnforcement
    {
        #region Fields

        private System.Decimal _chequeAmount;
        private System.String _chequeNo;
        private System.String _chequeStatus;
        private System.Collections.Generic.ICollection<EMSChequeHistory> _eMSChequeHistorys;
        private System.String _eMSChequeId;
        private System.Collections.Generic.ICollection<EMSPaymentCheque> _eMSPaymentCheques;
        private System.Collections.Generic.ICollection<EMSStateFund> _eMSStateFunds;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.DateTime _paymentDate;
        private JudicialUser _paymentOfficer;
        private System.String _remarks;
        private System.DateTime _statusDate;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSCheque"/> class.</summary>
        public EMSCheque()
            : base()
        {
            _eMSPaymentCheques = new System.Collections.Generic.HashSet<EMSPaymentCheque>();
            _eMSChequeHistorys = new System.Collections.Generic.HashSet<EMSChequeHistory>();
            _eMSStateFunds = new System.Collections.Generic.HashSet<EMSStateFund>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ChequeAmount field. </summary>
        public virtual System.Decimal ChequeAmount
        {
            get { return _chequeAmount; }
            set { _chequeAmount = value; }
        }

        /// <summary>Gets or sets the ChequeNo field. </summary>
        public virtual System.String ChequeNo
        {
            get { return _chequeNo; }
            set { _chequeNo = value; }
        }

        /// <summary>Gets or sets the _chequeStatus field. </summary>
        public virtual System.String ChequeStatus
        {
            get { return _chequeStatus; }
            set { _chequeStatus = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSChequeHistorys.EMSCheque - Enforcement.EMSCheque.EMSChequeHistorys (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSChequeHistory> EMSChequeHistorys
        {
            get { return _eMSChequeHistorys; }
            set { _eMSChequeHistorys = value; }
        }

        /// <summary>Gets or sets the EMSChequeId field. </summary>
        public virtual System.String EMSChequeId
        {
            get { return _eMSChequeId; }
            set { _eMSChequeId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSPaymentCheque.EMSCheque - Enforcement.EMSCheque.EMSPaymentCheques (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSPaymentCheque> EMSPaymentCheques
        {
            get { return _eMSPaymentCheques; }
            set { _eMSPaymentCheques = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSStateFund.EMSCheque - Enforcement.EMSCheque.EMSStateFunds (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSStateFund> EMSStateFunds
        {
            get { return _eMSStateFunds; }
            set { _eMSStateFunds = value; }
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

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the PaymentDate field. </summary>
        public virtual System.DateTime PaymentDate
        {
            get { return _paymentDate; }
            set { _paymentDate = value; }
        }

        /// <summary>Gets or sets the PaymentOfficer field. </summary>
        public virtual JudicialUser PaymentOfficer
        {
            get { return _paymentOfficer; }
            set { _paymentOfficer = value; }
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public virtual System.String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        /// <summary>Gets or sets the StatusDate field. </summary>
        public virtual System.DateTime StatusDate
        {
            get { return _statusDate; }
            set { _statusDate = value; }
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
            EMSCheque toCompareWith = obj as EMSCheque;
            return toCompareWith == null ? false : ((this.EMSChequeId == toCompareWith.EMSChequeId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSChequeId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}