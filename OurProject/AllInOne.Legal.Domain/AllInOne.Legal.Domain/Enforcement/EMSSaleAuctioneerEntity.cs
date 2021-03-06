﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.Enforcement
{
    using System;

    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Enforcement.EMSSaleAuctioneer'</summary>
    [Serializable]
    public class EMSSaleAuctioneerEntity : IEnforcementEntity
    {
        #region Properties

        /// <summary>Gets or sets the AuctioneerCharges field. </summary>
        public virtual Nullable<System.Decimal> AuctioneerCharges
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AuctioneerDateEngaged field. </summary>
        public virtual Nullable<System.DateTime> AuctioneerDateEngaged
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSSaleAuctioneerId field. </summary>
        public virtual System.String EMSSaleAuctioneerId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSSaleId field. </summary>
        public System.String EMSSaleId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MEMSAuctioneer field. </summary>
        public virtual MEMSAuctioneerEntity MEMSAuctioneer
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

        /// <summary>Gets or sets the OtherAuctioneer field. </summary>
        public virtual System.String OtherAuctioneer
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
            EMSSaleAuctioneerEntity toCompareWith = obj as EMSSaleAuctioneerEntity;
            return toCompareWith == null ? false : ((this.EMSSaleAuctioneerId == toCompareWith.EMSSaleAuctioneerId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSSaleAuctioneerId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    } 
}