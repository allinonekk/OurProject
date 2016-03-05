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

    /// <summary>Class which represents the entity 'Enforcement.EMSStateFund'</summary>
    public partial class EMSStateFund : IEnforcement
    {
        #region Fields

        private EMSAccount _eMSAccount;
        private EMSCheque _eMSCheque;
        private System.String _eMSStateFundId;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.Decimal _transAmt;
        private System.String _transferStatus;
        private System.String _transferApprovedBy;
        private Nullable<System.DateTime> _transferDate;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSStateFund"/> class.</summary>
        public EMSStateFund()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the EMSAccount field. </summary>
        public virtual EMSAccount EMSAccount
        {
            get { return _eMSAccount; }
            set { _eMSAccount = value; }
        }

        /// <summary>Gets or sets the EMSCheque field. </summary>
        public virtual EMSCheque EMSCheque
        {
            get { return _eMSCheque; }
            set { _eMSCheque = value; }
        }

        /// <summary>Gets or sets the EMSStateFundId field. </summary>
        public virtual System.String EMSStateFundId
        {
            get { return _eMSStateFundId; }
            set { _eMSStateFundId = value; }
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

        /// <summary>Gets or sets the TransAmt field. </summary>
        public virtual System.Decimal TransAmt
        {
            get { return _transAmt; }
            set { _transAmt = value; }
        }

        /// <summary>Gets or sets the TransferStatus field. </summary>
        public virtual System.String TransferStatus
        {
            get { return _transferStatus; }
            set { _transferStatus = value; }
        }

        /// <summary>Gets or sets the TransferApprovedBy field. </summary>
        public virtual System.String TransferApprovedBy
        {
            get { return _transferApprovedBy; }
            set { _transferApprovedBy = value; }
        }

        /// <summary>Gets or sets the TransferDate field. </summary>
        public virtual Nullable<System.DateTime> TransferDate
        {
            get { return _transferDate; }
            set { _transferDate = value; }
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
            EMSStateFund toCompareWith = obj as EMSStateFund;
            return toCompareWith == null ? false : ((this.EMSStateFundId == toCompareWith.EMSStateFundId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSStateFundId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}