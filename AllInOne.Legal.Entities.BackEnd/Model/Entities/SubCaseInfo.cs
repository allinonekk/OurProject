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

    /// <summary>Class which represents the entity 'SubCase.SubCaseInfo'</summary>
    public partial class SubCaseInfo : ISubCase
    {
        #region Fields

        private System.Collections.Generic.ICollection<ADMRSVCBBInfo> _aDMRSVCBBInfos;
        private System.Collections.Generic.ICollection<AffidavitInfo> _affidavitInfos;
        private System.Collections.Generic.ICollection<AssessmentDamage> _assessmentDamages;

        //private CaseInfo _caseInfo;
        private System.Int64 _caseInfoId;
        private System.Collections.Generic.ICollection<CaveatInfo> _caveatInfos;
        private System.Collections.Generic.ICollection<DocCaseParty> _docCaseParties;
        private System.Collections.Generic.ICollection<DocOrderDetail> _docOrderDetails;
        private System.Collections.Generic.ICollection<DocumentInfo> _documentInfos;
        private System.Collections.Generic.ICollection<EMSAccount> _eMSAccounts;
        private System.Collections.Generic.ICollection<FileInspectionDocDetail> _fileInspectionDocDetails;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MCaseStatus _mCaseStatus;
        private MCaseType _mCaseType;
        private System.Collections.Generic.ICollection<NatureOfApplication> _natureOfApplications;
        private System.Collections.Generic.ICollection<OSInfo> _oSInfos;
        private System.Collections.Generic.ICollection<PCAppDatesFromSAL> _pCAppDatesFromSALs;
        private System.Collections.Generic.ICollection<PCAppDetailsFromLawSoc> _pCAppDetailsFromLawSocs;
        private System.Collections.Generic.ICollection<RDocCase> _rDocCases;
        private System.Collections.Generic.ICollection<RSubCaseSubmission> _rSubCaseSubmissions;
        private System.Int64 _subCaseInfoId;
        private System.String _subCaseNo;
        private System.Collections.Generic.ICollection<SubCaseParty> _subCaseParties;
        private Nullable<System.Decimal> _subCaseSerialNo;
        private Nullable<System.DateTime> _subCaseStatusDate;
        private Nullable<System.Decimal> _subCaseYear;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="SubCaseInfo"/> class.</summary>
        public SubCaseInfo()
            : base()
        {
            _assessmentDamages = new System.Collections.Generic.HashSet<AssessmentDamage>();
            _caveatInfos = new System.Collections.Generic.HashSet<CaveatInfo>();
            _oSInfos = new System.Collections.Generic.HashSet<OSInfo>();
            _affidavitInfos = new System.Collections.Generic.HashSet<AffidavitInfo>();
            _natureOfApplications = new System.Collections.Generic.HashSet<NatureOfApplication>();
            _pCAppDatesFromSALs = new System.Collections.Generic.HashSet<PCAppDatesFromSAL>();
            _pCAppDetailsFromLawSocs = new System.Collections.Generic.HashSet<PCAppDetailsFromLawSoc>();
            _docCaseParties = new System.Collections.Generic.HashSet<DocCaseParty>();
            _docOrderDetails = new System.Collections.Generic.HashSet<DocOrderDetail>();
            _documentInfos = new System.Collections.Generic.HashSet<DocumentInfo>();
            _rDocCases = new System.Collections.Generic.HashSet<RDocCase>();
            _eMSAccounts = new System.Collections.Generic.HashSet<EMSAccount>();
            _rSubCaseSubmissions = new System.Collections.Generic.HashSet<RSubCaseSubmission>();
            _subCaseParties = new System.Collections.Generic.HashSet<SubCaseParty>();
            _aDMRSVCBBInfos = new System.Collections.Generic.HashSet<ADMRSVCBBInfo>();
            _fileInspectionDocDetails = new System.Collections.Generic.HashSet<FileInspectionDocDetail>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Subsequent.ADMRSVCBBInfo.SubCaseInfo - SubCase.SubCaseInfo.ADMRSVCBBInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<ADMRSVCBBInfo> ADMRSVCBBInfos
        {
            get { return _aDMRSVCBBInfos; }
            set { _aDMRSVCBBInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.AffidavitInfo.SubCaseInfo - SubCase.SubCaseInfo.AffidavitInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<AffidavitInfo> AffidavitInfos
        {
            get { return _affidavitInfos; }
            set { _affidavitInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.AssessmentDamage.SubCaseInfo - SubCase.SubCaseInfo.AssessmentDamages (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<AssessmentDamage> AssessmentDamages
        {
            get { return _assessmentDamages; }
            set { _assessmentDamages = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCase.SubCaseInfo.CaseInfo - Case.CaseInfo.SubCaseInfos (m:1)'</summary>
        //public virtual CaseInfo CaseInfo
        //{
        //    get { return _caseInfo; }
        //    set { _caseInfo = value; }
        //}
        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public virtual System.Int64 CaseInfoId
        {
            get { return _caseInfoId; }
            set { _caseInfoId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.CaveatInfo.SubCaseInfo - SubCase.SubCaseInfo.CaveatInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaveatInfo> CaveatInfos
        {
            get { return _caveatInfos; }
            set { _caveatInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCaseParty.SubCaseInfo - SubCase.SubCaseInfo.DocCaseParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCaseParty> DocCaseParties
        {
            get { return _docCaseParties; }
            set { _docCaseParties = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocOrderDetail.SubCaseInfo - SubCase.SubCaseInfo.DocOrderDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocOrderDetail> DocOrderDetails
        {
            get { return _docOrderDetails; }
            set { _docOrderDetails = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocumentInfo.SubCaseInfo - SubCase.SubCaseInfo.DocumentInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocumentInfo> DocumentInfos
        {
            get { return _documentInfos; }
            set { _documentInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSAccount.SubCaseInfo - SubCase.SubCaseInfo.EMSAccounts (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSAccount> EMSAccounts
        {
            get { return _eMSAccounts; }
            set { _eMSAccounts = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'SubCase.SubCaseInfo.MCaseStatus - Master.MCaseStatus.SubCaseInfos (m:1)'</summary>
        public virtual MCaseStatus MCaseStatus
        {
            get { return _mCaseStatus; }
            set { _mCaseStatus = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCase.SubCaseInfo.MCaseType - Master.MCaseType.SubCaseInfos (m:1)'</summary>
        public virtual MCaseType MCaseType
        {
            get { return _mCaseType; }
            set { _mCaseType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.NatureOfApplication.SubCaseInfo - SubCase.SubCaseInfo.NatureOfApplications (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<NatureOfApplication> NatureOfApplications
        {
            get { return _natureOfApplications; }
            set { _natureOfApplications = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.OSInfo.SubCaseInfo - SubCase.SubCaseInfo.OSInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<OSInfo> OSInfos
        {
            get { return _oSInfos; }
            set { _oSInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.PCAppDatesFromSAL.SubCaseInfo - SubCase.SubCaseInfo.PCAppDatesFromSALs (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<PCAppDatesFromSAL> PCAppDatesFromSALs
        {
            get { return _pCAppDatesFromSALs; }
            set { _pCAppDatesFromSALs = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.PCAppDetailsFromLawSoc.SubCaseInfo - SubCase.SubCaseInfo.PCAppDetailsFromLawSocs (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<PCAppDetailsFromLawSoc> PCAppDetailsFromLawSocs
        {
            get { return _pCAppDetailsFromLawSocs; }
            set { _pCAppDetailsFromLawSocs = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.RDocCase.SubCaseInfo - SubCase.SubCaseInfo.RDocCases (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<RDocCase> RDocCases
        {
            get { return _rDocCases; }
            set { _rDocCases = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCase.RSubCaseSubmission.SubCaseInfo - SubCase.SubCaseInfo.RSubCaseSubmissions (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<RSubCaseSubmission> RSubCaseSubmissions
        {
            get { return _rSubCaseSubmissions; }
            set { _rSubCaseSubmissions = value; }
        }

        /// <summary>Gets or sets the SubCaseInfoId field. </summary>
        public virtual System.Int64 SubCaseInfoId
        {
            get { return _subCaseInfoId; }
            set { _subCaseInfoId = value; }
        }

        /// <summary>Gets or sets the SubCaseNo field. </summary>
        public virtual System.String SubCaseNo
        {
            get { return _subCaseNo; }
            set { _subCaseNo = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCase.SubCaseParty.SubCaseInfo - SubCase.SubCaseInfo.SubCaseParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<SubCaseParty> SubCaseParties
        {
            get { return _subCaseParties; }
            set { _subCaseParties = value; }
        }

        /// <summary>Gets or sets the SubCaseSerialNo field. </summary>
        public virtual Nullable<System.Decimal> SubCaseSerialNo
        {
            get { return _subCaseSerialNo; }
            set { _subCaseSerialNo = value; }
        }

        /// <summary>Gets or sets the SubCaseStatusDate field. </summary>
        public virtual Nullable<System.DateTime> SubCaseStatusDate
        {
            get { return _subCaseStatusDate; }
            set { _subCaseStatusDate = value; }
        }

        /// <summary>Gets or sets the SubCaseYear field. </summary>
        public virtual Nullable<System.Decimal> SubCaseYear
        {
            get { return _subCaseYear; }
            set { _subCaseYear = value; }
        }


        public virtual DateTime? HideDocAccessTillDate
        {
            get;
            set;
        }

        public virtual string SubCaseFeeForumID { get; set; }

        public virtual decimal? SubCaseFeeTierType { get; set; }

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
            SubCaseInfo toCompareWith = obj as SubCaseInfo;
            return toCompareWith == null ? false : ((this.SubCaseInfoId == toCompareWith.SubCaseInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SubCaseInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}