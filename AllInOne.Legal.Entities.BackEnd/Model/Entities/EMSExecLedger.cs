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

    /// <summary>Class which represents the entity 'Enforcement.EMSExecLedger'</summary>
    public partial class EMSExecLedger : IEnforcement
    {
        #region Fields

        private Nullable<System.Decimal> _amount;
        private System.DateTime _date;
        private EMSAccount _eMSAccount;
        private System.String _eMSExecLedgerId;
        private EMSPayment _eMSPayment;
        private EMSRecTrans _eMSRecTrans;
        private System.String _isDebitCredit;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;

        //private System.String _transDesc;
        private MEMSLedger _mEMSLedger;
        private System.String _obsInd;
        private System.String _referenceNo;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSExecLedger"/> class.</summary>
        public EMSExecLedger()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the Amount field. </summary>
        public virtual Nullable<System.Decimal> Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        /// <summary>Gets or sets the Date field. </summary>
        public virtual System.DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSExecLedger.EMSAccount - Enforcement.EMSAccount.EMSExecLedgers (m:1)'</summary>
        public virtual EMSAccount EMSAccount
        {
            get { return _eMSAccount; }
            set { _eMSAccount = value; }
        }

        /// <summary>Gets or sets the EMSExecLedgerId field. </summary>
        public virtual System.String EMSExecLedgerId
        {
            get { return _eMSExecLedgerId; }
            set { _eMSExecLedgerId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSExecLedger.EMSPayment - Enforcement.EMSPayment.EMSExecLedgers (m:1)'</summary>
        public virtual EMSPayment EMSPayment
        {
            get { return _eMSPayment; }
            set { _eMSPayment = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSExecLedger.EMSRecTrans - Enforcement.EMSRecTrans.EMSExecLedgers (m:1)'</summary>
        public virtual EMSRecTrans EMSRecTrans
        {
            get { return _eMSRecTrans; }
            set { _eMSRecTrans = value; }
        }

        /// <summary>Gets or sets the IsDebitCredit field. </summary>
        public virtual System.String IsDebitCredit
        {
            get { return _isDebitCredit; }
            set { _isDebitCredit = value; }
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

        /// <summary>Gets or sets the MEMSLedger field. </summary>
        public virtual MEMSLedger MEMSLedger
        {
            get { return _mEMSLedger; }
            set { _mEMSLedger = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the ReferenceNo field. </summary>
        public virtual System.String ReferenceNo
        {
            get { return _referenceNo; }
            set { _referenceNo = value; }
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
            EMSExecLedger toCompareWith = obj as EMSExecLedger;
            return toCompareWith == null ? false : ((this.EMSExecLedgerId == toCompareWith.EMSExecLedgerId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSExecLedgerId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}