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

    /// <summary>Class which represents the entity 'Enforcement.EMSTptClaim'</summary>
    public partial class EMSTptClaim : IEnforcement
    {
        #region Fields

        private System.String _approvedBy;
        private Nullable<System.DateTime> _approvedDate;
        private JudicialUser _bailiff;
        private EMSAppointment _eMSAppointment;
        private EMSPaymentVoucher _eMSPaymentVoucher;
        private System.String _eMSTptClaimId;
        private System.Decimal _expense;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.String _placeFrom;
        private System.String _placeTo;
        private System.String _remarks;
        private System.String _status;
        private System.String _timeStart;
        private Nullable<System.DateTime> _transportDate;
        private System.String _miscReceiptNo;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSTptClaim"/> class.</summary>
        public EMSTptClaim()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ApprovedBy field. </summary>
        public virtual System.String ApprovedBy
        {
            get { return _approvedBy; }
            set { _approvedBy = value; }
        }

        /// <summary>Gets or sets the ApprovedDate field. </summary>
        public virtual Nullable<System.DateTime> ApprovedDate
        {
            get { return _approvedDate; }
            set { _approvedDate = value; }
        }

        /// <summary>Gets or sets the Bailiff field. </summary>
        public virtual JudicialUser Bailiff
        {
            get { return _bailiff; }
            set { _bailiff = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSTptClaim.EMSAppointment - Enforcement.EMSAppointment.EMSTptClaims (m:1)'</summary>
        public virtual EMSAppointment EMSAppointment
        {
            get { return _eMSAppointment; }
            set { _eMSAppointment = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSTptClaim.EMSPaymentVoucher - Enforcement.EMSPaymentVoucher.EMSTptClaims (m:1)'</summary>
        public virtual EMSPaymentVoucher EMSPaymentVoucher
        {
            get { return _eMSPaymentVoucher; }
            set { _eMSPaymentVoucher = value; }
        }

        /// <summary>Gets or sets the EMSTptClaimId field. </summary>
        public virtual System.String EMSTptClaimId
        {
            get { return _eMSTptClaimId; }
            set { _eMSTptClaimId = value; }
        }

        /// <summary>Gets or sets the Expense field. </summary>
        public virtual System.Decimal Expense
        {
            get { return _expense; }
            set { _expense = value; }
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

        /// <summary>Gets or sets the PlaceFrom field. </summary>
        public virtual System.String PlaceFrom
        {
            get { return _placeFrom; }
            set { _placeFrom = value; }
        }

        /// <summary>Gets or sets the PlaceTo field. </summary>
        public virtual System.String PlaceTo
        {
            get { return _placeTo; }
            set { _placeTo = value; }
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public virtual System.String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        /// <summary>Gets or sets the Status field. </summary>
        public virtual System.String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>Gets or sets the TimeStart field. </summary>
        public virtual System.String TimeStart
        {
            get { return _timeStart; }
            set { _timeStart = value; }
        }

        /// <summary>Gets or sets the TransportDate field. </summary>
        public virtual Nullable<DateTime> TransportDate
        {
            get { return _transportDate; }
            set { _transportDate = value; }
        }

        /// <summary>Gets or sets the MiscReceiptNo field. </summary>
        public virtual System.String MiscReceiptNo
        {
            get { return _miscReceiptNo; }
            set { _miscReceiptNo = value; }
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
            EMSTptClaim toCompareWith = obj as EMSTptClaim;
            return toCompareWith == null ? false : ((this.EMSTptClaimId == toCompareWith.EMSTptClaimId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSTptClaimId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}