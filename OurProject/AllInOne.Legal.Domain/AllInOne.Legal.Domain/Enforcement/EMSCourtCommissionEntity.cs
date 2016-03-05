﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.Enforcement
{
    using System;

    /// <summary>Class which represents the entity 'Enforcement.EMSCourtCommission'</summary>
    [Serializable]
    public class EMSCourtCommissionEntity : IEnforcementEntity
    {
        #region Properties

        /// <summary>Gets or sets the Action field. </summary>
        public System.String Action
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ActionDate field. </summary>
        public System.DateTime ActionDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Amount field. </summary>
        public System.Decimal Amount
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

        /// <summary>Gets or sets the EMSCourtCommissionId field. </summary>
        public System.String EMSCourtCommissionId
        {
            get;
            set;
        }

        ///// <summary>Gets or sets the EMSPaymentVoucherFinalId field. </summary>
        //public System.String EMSPaymentVoucherFinalId
        //{
        //    get;
        //    set;
        //}

        /// <summary>Gets or sets the EMSPaymentVoucherId field. </summary>
        public System.String EMSPaymentVoucherId
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
            EMSCourtCommissionEntity toCompareWith = obj as EMSCourtCommissionEntity;
            return toCompareWith == null ? false : ((this.EMSCourtCommissionId == toCompareWith.EMSCourtCommissionId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSCourtCommissionId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}