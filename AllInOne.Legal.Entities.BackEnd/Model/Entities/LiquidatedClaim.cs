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

    /// <summary>Class which represents the entity 'Common.LiquidatedClaim'</summary>
    public partial class LiquidatedClaim : ICommon
    {
        #region Fields

        private Nullable<System.Int64> _itemNo;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private Nullable<System.Decimal> _lIQAmount;
        private Nullable<System.Decimal> _lIQAwardedAmount;
        private Nullable<System.Decimal> _lIQSGDAmount;
        private System.String _liquidatedClaimId;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="LiquidatedClaim"/> class.</summary>
        public LiquidatedClaim()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ItemNo field. </summary>
        public virtual Nullable<System.Int64> ItemNo
        {
            get { return _itemNo; }
            set { _itemNo = value; }
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

        /// <summary>Gets or sets the LIQAmount field. </summary>
        public virtual Nullable<System.Decimal> LIQAmount
        {
            get { return _lIQAmount; }
            set { _lIQAmount = value; }
        }

        /// <summary>Gets or sets the LIQAwardedAmount field. </summary>
        public virtual Nullable<System.Decimal> LIQAwardedAmount
        {
            get { return _lIQAwardedAmount; }
            set { _lIQAwardedAmount = value; }
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'Common.LiquidatedClaim.MCurrency - Master.MCurrency.LiquidatedClaims (m:1)'</summary>
        //public virtual MCurrency MCurrency
        //{
        //    get { return _mCurrency; }
        //    set { _mCurrency = value; }
        //}
        public virtual String LIQCurrencyCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LIQSGDAmount field. </summary>
        public virtual Nullable<System.Decimal> LIQSGDAmount
        {
            get { return _lIQSGDAmount; }
            set { _lIQSGDAmount = value; }
        }

        /// <summary>Gets or sets the LiquidatedClaimId field. </summary>
        public virtual System.String LiquidatedClaimId
        {
            get { return _liquidatedClaimId; }
            set { _liquidatedClaimId = value; }
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
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
            LiquidatedClaim toCompareWith = obj as LiquidatedClaim;
            return toCompareWith == null ? false : ((this.LiquidatedClaimId == toCompareWith.LiquidatedClaimId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LiquidatedClaimId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}