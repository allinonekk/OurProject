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

    /// <summary>Class which represents the entity 'Enforcement.EMSOutstandingPayment'</summary>
    public partial class EMSOutstandingPayment : IEnforcement
    {
        #region Fields

        private System.Decimal _amount;
        private EMSAccount _eMSAccount;
        private System.String _eMSOutstandingPaymentId;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.String _outstandingPaymentType;
        private System.DateTime _requestedDate;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSOutstandingPayment"/> class.</summary>
        public EMSOutstandingPayment()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the Amount field. </summary>
        public virtual System.Decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSOutstandingPayment.EMSAccount - Enforcement.EMSAccount.EMSOutstandingPayments (m:1)'</summary>
        public virtual EMSAccount EMSAccount
        {
            get { return _eMSAccount; }
            set { _eMSAccount = value; }
        }

        /// <summary>Gets or sets the EMSOutstandingPaymentId field. </summary>
        public virtual System.String EMSOutstandingPaymentId
        {
            get { return _eMSOutstandingPaymentId; }
            set { _eMSOutstandingPaymentId = value; }
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

        /// <summary>Gets or sets the OutstandingPaymentType field. </summary>
        public virtual System.String OutstandingPaymentType
        {
            get { return _outstandingPaymentType; }
            set { _outstandingPaymentType = value; }
        }

        /// <summary>Gets or sets the RequestedDate field. </summary>
        public virtual System.DateTime RequestedDate
        {
            get { return _requestedDate; }
            set { _requestedDate = value; }
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            EMSOutstandingPayment toCompareWith = obj as EMSOutstandingPayment;
            return toCompareWith == null ? false : ((this.EMSOutstandingPaymentId == toCompareWith.EMSOutstandingPaymentId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSOutstandingPaymentId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}