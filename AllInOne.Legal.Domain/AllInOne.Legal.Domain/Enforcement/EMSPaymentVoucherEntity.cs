﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.Enforcement
{
    using System;

    /// <summary>Class which represents the entity 'Enforcement.EMSPaymentVoucher'</summary>
    [Serializable]
    public class EMSPaymentVoucherEntity : IEnforcementEntity
    {
        #region Properties

        /// <summary>Gets or sets the DocId field. </summary>
        public System.String OCDocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubmittedBySigPath field. </summary>
        public System.String SubmittedBySigPath
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ApprovedBySigPath field. </summary>
        public System.String ApprovedBySigPath
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ApprovedBy field. </summary>
        public System.String ApprovedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ApprovedDate field. </summary>
        public Nullable<System.DateTime> ApprovedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BailiffDisburse field. </summary>
        public Nullable<System.Decimal> BailiffDisburse
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BailiffId field. </summary>
        public System.String BailiffId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BailiffMisc field. </summary>
        public Nullable<System.Decimal> BailiffMisc
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BailiffTransport field. </summary>
        public Nullable<System.Decimal> BailiffTransport
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSAccountId field. </summary>
        public System.String EMSAccountId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSPaymentVoucherId field. </summary>
        public System.String EMSPaymentVoucherId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IssueDate field. </summary>
        public System.DateTime IssueDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsUrgent field. </summary>
        public System.String IsUrgent
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public System.DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PaymentVoucherNo field. </summary>
        public System.String PaymentVoucherNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PaymentVoucherType field. </summary>
        public PaymentVoucherType PaymentVoucherType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public System.String Remarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Status field. </summary>
        public PaymentVoucherStatus Status
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TransDateFrom field. </summary>
        public System.DateTime TransDateFrom
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TransDateTo field. </summary>
        public System.DateTime TransDateTo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the VettedBy field. </summary>
        public System.String VettedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the VettedDate field. </summary>
        public Nullable<System.DateTime> VettedDate
        {
            get;
            set;
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
            EMSPaymentVoucherEntity toCompareWith = obj as EMSPaymentVoucherEntity;
            return toCompareWith == null ? false : ((this.EMSPaymentVoucherId == toCompareWith.EMSPaymentVoucherId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSPaymentVoucherId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}