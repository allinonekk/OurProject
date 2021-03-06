﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.Enforcement
{
    using System;

    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.SubCase;

    /// <summary>Class which represents the entity 'Enforcement.EMSAccount'</summary>
    [Serializable]
    public class EMSAccountEntity : IEnforcementEntity
    {
        #region Properties

        /// <summary>Gets or sets the AccountSerialNo field. </summary>
        public System.Int32 AccountSerialNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AccountYear field. </summary>
        public System.Int32 AccountYear
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AccountNo field. </summary>
        public System.String AccountNo
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

        /// <summary>Gets or sets the Balance field. </summary>
        public Nullable<System.Decimal> Balance
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public System.String CaseInfoId
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

        /// <summary>Gets or sets the EMSType field. </summary>
        public EMSType EMSType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Interest field. </summary>
        public Nullable<System.Decimal> Interest
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsOnHold field. </summary>
        public YesNo IsOnHold
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsUrgent field. </summary>
        public YesNo IsUrgent
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsWaiver field. </summary>
        public YesNo IsWaiver
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsWSeizure field. </summary>
        public YesNo IsWSeizure
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

        /// <summary>Gets or sets the LedgerRemarks field. </summary>
        public System.String LedgerRemarks
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

        /// <summary>Gets or sets the SerialNumber field. </summary>
        public System.Int32 SerialNumber
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubCaseInfoId field. </summary>
        public System.String SubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WritAmount field. </summary>
        public Nullable<System.Decimal> WritAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WritCost field. </summary>
        public Nullable<System.Decimal> WritCost
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WritExpiryDate field. </summary>
        public System.DateTime WritExpiryDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WritFilingDate field. </summary>
        public System.DateTime WritFilingDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AccountNoCreatedDate field. </summary>
        public Nullable<System.DateTime> AccountNoCreatedDate
        {
            get;
            set;
        }

        public YesNo SyncRequired
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
            EMSAccountEntity toCompareWith = obj as EMSAccountEntity;
            return toCompareWith == null ? false : ((this.EMSAccountId == toCompareWith.EMSAccountId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSAccountId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}