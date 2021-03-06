﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.Enforcement
{
    using System;

    using AllInOne.Legal.Domain.Case;

    /// <summary>Class which represents the entity 'Enforcement.EMSCivCrmSettlement'</summary>
    [Serializable]
    public class EMSCivCrmSettlementEntity : IEnforcementEntity
    {
        #region Properties

        /// <summary>Gets or sets the AmountSettled field. </summary>
        public Nullable<System.Decimal> AmountSettled
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CasePartyId field. </summary>
        public System.String CasePartyId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CauseShownCourtNo field. </summary>
        public System.String CauseShownCourtNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CauseShownDetails field. </summary>
        public System.String CauseShownDetails
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CauseShownOrderDate field. </summary>
        public Nullable<System.DateTime> CauseShownOrderDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CourtDirection field. </summary>
        public System.String CourtDirection
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DirectionDateTime field. </summary>
        public Nullable<System.DateTime> DirectionDateTime
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

        /// <summary>Gets or sets the EMSAppointmentId field. </summary>
        public System.String EMSAppointmentId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSCivCrmSettlementId field. </summary>
        public System.String EMSCivCrmSettlementId
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

        /// <summary>Gets or sets the OthersDetails field. </summary>
        public System.String OthersDetails
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PayeeName field. </summary>
        public System.String PayeeName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ReceiptNo field. </summary>
        public System.String ReceiptNo
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

        /// <summary>Gets or sets the SentenceCourtNo field. </summary>
        public System.String SentenceCourtNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SentenceDetails field. </summary>
        public System.String SentenceDetails
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SentenceOrderDate field. </summary>
        public Nullable<System.DateTime> SentenceOrderDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SettlementDateTime field. </summary>
        public Nullable<System.DateTime> SettlementDateTime
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SettlementOutcome field. </summary>
        public SettlementOutcomeType SettlementOutcome
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WCNo field. </summary>
        public System.String WCNo
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
            EMSCivCrmSettlementEntity toCompareWith = obj as EMSCivCrmSettlementEntity;
            return toCompareWith == null ? false : ((this.EMSCivCrmSettlementId == toCompareWith.EMSCivCrmSettlementId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSCivCrmSettlementId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}