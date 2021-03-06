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

    /// <summary>Class which represents the entity 'BackEndSpecific.CriminalClaimInfo'</summary>
    public partial class CriminalClaimInfo : IBackEndSpecific
    {
        #region Fields

        private System.String _arApprover;
        private System.Int64 _caseInfoId;
        private System.String _claimStatus;
        private System.Collections.Generic.ICollection<CriminalClaimHonorariumInfo> _criminalClaimHonorariumInfos;
        private System.String _criminalClaimInfoId;
        private System.Collections.Generic.ICollection<CriminalClaimInterpreterFeeInfo> _criminalClaimInterpreterFeeInfos;
        private System.Collections.Generic.ICollection<CriminalClaimMiscellaneousInfo> _criminalClaimMiscellaneousInfos;
        private System.Collections.Generic.ICollection<CriminalClaimProfessionalFeeInfo> _criminalClaimProfessionalFeeInfos;
        private System.Collections.Generic.ICollection<CriminalClaimWitnessInfo> _criminalClaimWitnessInfos;
        private Nullable<System.DateTime> _dateApprovedByAR;
        private Nullable<System.DateTime> _dateApprovedBySup;
        private Nullable<System.DateTime> _datePaid;
        private Nullable<System.DateTime> _dateSubmitted;
        private System.String _financeApprover;
        private Nullable<System.Decimal> _grandTotalClaimsAmountApprovedByAR;
        private Nullable<System.Decimal> _grandTotalClaimsAmountApprovedBySup;
        private System.Decimal _grandTotalClaimsAmountEntered;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MCriminalClaimType _mCriminalClaimType;
        private System.String _remarks;
        private System.String _submittedBy;
        private Nullable<System.Decimal> _subTotal;
        private System.String _supApprover;
        private Nullable<System.Decimal> _totalAmountPaid;
        private Nullable<System.Decimal> _totalGSTAmount;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="CriminalClaimInfo"/> class.</summary>
        public CriminalClaimInfo()
            : base()
        {
            _criminalClaimHonorariumInfos = new System.Collections.Generic.HashSet<CriminalClaimHonorariumInfo>();
            _criminalClaimInterpreterFeeInfos = new System.Collections.Generic.HashSet<CriminalClaimInterpreterFeeInfo>();
            _criminalClaimMiscellaneousInfos = new System.Collections.Generic.HashSet<CriminalClaimMiscellaneousInfo>();
            _criminalClaimProfessionalFeeInfos = new System.Collections.Generic.HashSet<CriminalClaimProfessionalFeeInfo>();
            _criminalClaimWitnessInfos = new System.Collections.Generic.HashSet<CriminalClaimWitnessInfo>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ARApprover field. </summary>
        public virtual System.String ARApprover
        {
            get { return _arApprover; }
            set { _arApprover = value; }
        }

        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public virtual System.Int64 CaseInfoId
        {
            get { return _caseInfoId; }
            set { _caseInfoId = value; }
        }

        /// <summary>Gets or sets the ClaimStatus field. </summary>
        public virtual System.String ClaimStatus
        {
            get { return _claimStatus; }
            set { _claimStatus = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.CriminalClaimHonorariumInfo.CriminalClaimInfo - BackEndSpecific.CriminalClaimInfo.CriminalClaimHonorariumInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CriminalClaimHonorariumInfo> CriminalClaimHonorariumInfos
        {
            get { return _criminalClaimHonorariumInfos; }
            set { _criminalClaimHonorariumInfos = value; }
        }

        /// <summary>Gets or sets the CriminalClaimInfoId field. </summary>
        public virtual System.String CriminalClaimInfoId
        {
            get { return _criminalClaimInfoId; }
            set { _criminalClaimInfoId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.CriminalClaimInterpreterFeeInfo.CriminalClaimInfo - BackEndSpecific.CriminalClaimInfo.CriminalClaimInterpreterFeeInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CriminalClaimInterpreterFeeInfo> CriminalClaimInterpreterFeeInfos
        {
            get { return _criminalClaimInterpreterFeeInfos; }
            set { _criminalClaimInterpreterFeeInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.CriminalClaimMiscellaneousInfo.CriminalClaimInfo - BackEndSpecific.CriminalClaimInfo.CriminalClaimMiscellaneousInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CriminalClaimMiscellaneousInfo> CriminalClaimMiscellaneousInfos
        {
            get { return _criminalClaimMiscellaneousInfos; }
            set { _criminalClaimMiscellaneousInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.CriminalClaimProfessionalFeeInfo.CriminalClaimInfo - BackEndSpecific.CriminalClaimInfo.CriminalClaimProfessionalFeeInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CriminalClaimProfessionalFeeInfo> CriminalClaimProfessionalFeeInfos
        {
            get { return _criminalClaimProfessionalFeeInfos; }
            set { _criminalClaimProfessionalFeeInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.CriminalClaimWitnessInfo.CriminalClaimInfo - BackEndSpecific.CriminalClaimInfo.CriminalClaimWitnessInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CriminalClaimWitnessInfo> CriminalClaimWitnessInfos
        {
            get { return _criminalClaimWitnessInfos; }
            set { _criminalClaimWitnessInfos = value; }
        }

        /// <summary>Gets or sets the DateApprovedByAR field. </summary>
        public virtual Nullable<System.DateTime> DateApprovedByAR
        {
            get { return _dateApprovedByAR; }
            set { _dateApprovedByAR = value; }
        }

        /// <summary>Gets or sets the DateApprovedBySup field. </summary>
        public virtual Nullable<System.DateTime> DateApprovedBySup
        {
            get { return _dateApprovedBySup; }
            set { _dateApprovedBySup = value; }
        }

        /// <summary>Gets or sets the DatePaid field. </summary>
        public virtual Nullable<System.DateTime> DatePaid
        {
            get { return _datePaid; }
            set { _datePaid = value; }
        }

        /// <summary>Gets or sets the DateSubmitted field. </summary>
        public virtual Nullable<System.DateTime> DateSubmitted
        {
            get { return _dateSubmitted; }
            set { _dateSubmitted = value; }
        }

        /// <summary>Gets or sets the FinanceApprover field. </summary>
        public virtual System.String FinanceApprover
        {
            get { return _financeApprover; }
            set { _financeApprover = value; }
        }

        /// <summary>Gets or sets the GrandTotalClaimsAmountApprovedByAR field. </summary>
        public virtual Nullable<System.Decimal> GrandTotalClaimsAmountApprovedByAR
        {
            get { return _grandTotalClaimsAmountApprovedByAR; }
            set { _grandTotalClaimsAmountApprovedByAR = value; }
        }

        /// <summary>Gets or sets the GrandTotalClaimsAmountApprovedBySup field. </summary>
        public virtual Nullable<System.Decimal> GrandTotalClaimsAmountApprovedBySup
        {
            get { return _grandTotalClaimsAmountApprovedBySup; }
            set { _grandTotalClaimsAmountApprovedBySup = value; }
        }

        /// <summary>Gets or sets the GrandTotalClaimsAmountEntered field. </summary>
        public virtual System.Decimal GrandTotalClaimsAmountEntered
        {
            get { return _grandTotalClaimsAmountEntered; }
            set { _grandTotalClaimsAmountEntered = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.CriminalClaimInfo.MCriminalClaimType - Master.MCriminalClaimType.CriminalClaimInfos (m:1)'</summary>
        public virtual MCriminalClaimType MCriminalClaimType
        {
            get { return _mCriminalClaimType; }
            set { _mCriminalClaimType = value; }
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public virtual System.String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        /// <summary>Gets or sets the SubmittedBy field. </summary>
        public virtual System.String SubmittedBy
        {
            get { return _submittedBy; }
            set { _submittedBy = value; }
        }

        /// <summary>Gets or sets the SubTotal field. </summary>
        public virtual Nullable<System.Decimal> SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }

        /// <summary>Gets or sets the SupApprover field. </summary>
        public virtual System.String SupApprover
        {
            get { return _supApprover; }
            set { _supApprover = value; }
        }

        /// <summary>Gets or sets the TotalAmountPaid field. </summary>
        public virtual Nullable<System.Decimal> TotalAmountPaid
        {
            get { return _totalAmountPaid; }
            set { _totalAmountPaid = value; }
        }

        /// <summary>Gets or sets the TotalGSTAmount field. </summary>
        public virtual Nullable<System.Decimal> TotalGSTAmount
        {
            get { return _totalGSTAmount; }
            set { _totalGSTAmount = value; }
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
            CriminalClaimInfo toCompareWith = obj as CriminalClaimInfo;
            return toCompareWith == null ? false : ((this.CriminalClaimInfoId == toCompareWith.CriminalClaimInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CriminalClaimInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}