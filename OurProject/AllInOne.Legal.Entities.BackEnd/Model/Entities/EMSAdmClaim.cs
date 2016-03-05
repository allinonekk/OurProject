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

    /// <summary>Class which represents the entity 'Enforcement.EMSAdmClaim'</summary>
    public partial class EMSAdmClaim : IEnforcement
    {
        #region Fields

        private JudicialUser _bailiff;
        private System.Decimal _claimAmt;
        private System.String _claimDesc;
        private System.String _claimType;
        private EMSAccount _eMSAccount;
        private System.String _eMSAdmClaimId;
        private EMSAdmExec _eMSAdmExec;
        private EMSAdmRelease _eMSAdmRelease;
        private EMSPaymentVoucher _eMSPaymentVoucher;
        private EMSSale _eMSSale;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _locationFrom;
        private System.String _locationTo;
        private System.String _obsInd;
        private System.String _timeFrom;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSAdmClaim"/> class.</summary>
        public EMSAdmClaim()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        ///// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSAdmClaim.JudicialUser (m:1)'</summary>
        public virtual JudicialUser Bailiff
        {
            get { return _bailiff; }
            set { _bailiff = value; }
        }

        /// <summary>Gets or sets the ClaimAmt field. </summary>
        public virtual System.Decimal ClaimAmt
        {
            get { return _claimAmt; }
            set { _claimAmt = value; }
        }

        /// <summary>Gets or sets the ClaimDesc field. </summary>
        public virtual System.String ClaimDesc
        {
            get { return _claimDesc; }
            set { _claimDesc = value; }
        }

        /// <summary>Gets or sets the ClaimType field. </summary>
        public virtual System.String ClaimType
        {
            get { return _claimType; }
            set { _claimType = value; }
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSAdmClaim.EMSAccount - Enforcement.EMSAccount.EMSAdmClaims (m:1)'</summary>
        public virtual EMSAccount EMSAccount
        {
            get { return _eMSAccount; }
            set { _eMSAccount = value; }
        }

        /// <summary>Gets or sets the EMSAdmClaimId field. </summary>
        public virtual System.String EMSAdmClaimId
        {
            get { return _eMSAdmClaimId; }
            set { _eMSAdmClaimId = value; }
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSAdmClaim.EMSAccount - Enforcement.EMSAccount.EMSAdmClaims (m:1)'</summary>
        public virtual EMSAdmExec EMSAdmExec
        {
            get { return _eMSAdmExec; }
            set { _eMSAdmExec = value; }
        }

        /// <summary>Gets or sets the EMSAdmRelease field. </summary>
        public virtual EMSAdmRelease EMSAdmRelease
        {
            get { return _eMSAdmRelease; }
            set { _eMSAdmRelease = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSAdmClaim.EMSAdmProperty - Enforcement.EMSAdmProperty.EMSAdmClaims (m:1)'</summary>
        public virtual EMSPaymentVoucher EMSPaymentVoucher
        {
            get { return _eMSPaymentVoucher; }
            set { _eMSPaymentVoucher = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSAdmClaim.EMSAdmProperty - Enforcement.EMSAdmProperty.EMSAdmClaims (m:1)'</summary>
        public virtual EMSSale EMSSale
        {
            get { return _eMSSale; }
            set { _eMSSale = value; }
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

        /// <summary>Gets or sets the LocationFrom field. </summary>
        public virtual System.String LocationFrom
        {
            get { return _locationFrom; }
            set { _locationFrom = value; }
        }

        /// <summary>Gets or sets the LocationTo field. </summary>
        public virtual System.String LocationTo
        {
            get { return _locationTo; }
            set { _locationTo = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the TimeFrom field. </summary>
        public virtual System.String TimeFrom
        {
            get { return _timeFrom; }
            set { _timeFrom = value; }
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
            EMSAdmClaim toCompareWith = obj as EMSAdmClaim;
            return toCompareWith == null ? false : ((this.EMSAdmClaimId == toCompareWith.EMSAdmClaimId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSAdmClaimId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}