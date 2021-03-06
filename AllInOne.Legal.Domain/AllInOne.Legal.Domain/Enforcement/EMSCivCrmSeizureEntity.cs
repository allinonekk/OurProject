﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.Enforcement
{
    using System;

    /// <summary>Class which represents the entity 'Enforcement.EMSCivCrmSeizure'</summary>
    [Serializable]
    public class EMSCivCrmSeizureEntity : IEnforcementEntity
    {
        #region Properties

        /// <summary>Gets or sets the EMSAccountId field. </summary>
        public System.String EMSAccountId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSAppointmentId field. </summary>
        public System.String EMSAppointmentId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSCivCrmSeizureId field. </summary>
        public System.String EMSCivCrmSeizureId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EstValue field. </summary>
        public System.Decimal EstValue
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemsSeized field. </summary>
        public System.Int32 ItemsSeized
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

        /// <summary>Gets or sets the OtherCourtFee field. </summary>
        public Nullable<System.Decimal> OtherCourtFee
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OtherLegalExpense field. </summary>
        public Nullable<System.Decimal> OtherLegalExpense
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

        /// <summary>Gets or sets the SeizureDateTime field. </summary>
        public System.DateTime SeizureDateTime
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WatchmanCharges field. </summary>
        public Nullable<System.Decimal> WatchmanCharges
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
            EMSCivCrmSeizureEntity toCompareWith = obj as EMSCivCrmSeizureEntity;
            return toCompareWith == null ? false : ((this.EMSCivCrmSeizureId == toCompareWith.EMSCivCrmSeizureId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSCivCrmSeizureId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}