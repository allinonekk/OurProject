﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.Enforcement
{
    using System;

    /// <summary>Class which represents the entity 'Enforcement.EMSStateFund'</summary>
    [Serializable]
    public class EMSStateFundEntity : IEnforcementEntity
    {
        #region Properties

        /// <summary>Gets or sets the EMSAccountId field. </summary>
        public System.String EMSAccountId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSChequeId field. </summary>
        public System.String EMSChequeId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSStateFundId field. </summary>
        public System.String EMSStateFundId
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

        /// <summary>Gets or sets the TransAmt field. </summary>
        public System.Decimal TransAmt
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TransferStatus field. </summary>
        public TransferStateFundStatus TransferStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TransferApprovedBy field. </summary>
        public System.String TransferApprovedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TransferDate field. </summary>
        public Nullable<System.DateTime> TransferDate
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
            if (obj == null)
            {
                return false;
            }
            EMSStateFundEntity toCompareWith = obj as EMSStateFundEntity;
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