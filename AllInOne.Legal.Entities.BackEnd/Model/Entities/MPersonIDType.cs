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

    /// <summary>Class which represents the entity 'Master.MPersonIDType'</summary>
    public partial class MPersonIDType : IMaster
    {
        #region Fields

        private System.Collections.Generic.ICollection<CasePartyBailorInfo> _casePartyBailorInfos;
        private System.Collections.Generic.ICollection<ChildInfo> _childInfos;
        private System.Collections.Generic.ICollection<DeceasedIdentification> _deceasedIdentifications;
        private System.String _description;
        private System.Collections.Generic.ICollection<DocCasePartyBailorInfo> _docCasePartyBailorInfos;
        private System.String _entityTypeCode;
        private System.Collections.Generic.ICollection<FileInspection> _fileInspections;
        private System.String _idTypeCode;
        private System.Collections.Generic.ICollection<LABParty> _lABParties;
        private System.Collections.Generic.ICollection<LABPartyHistory> _lABPartyHistories;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.Collections.Generic.ICollection<LiquidatorPIC> _liquidatorPICs;
        private System.Collections.Generic.ICollection<BankruptcyOtherDefDetail> _mBODDCompanyIdType;
        private System.Collections.Generic.ICollection<BankruptcyOtherDefDetail> _mBODDPersonIdType;
        private System.Collections.Generic.ICollection<CasePartyAICDetail> _mCPAICDCompanyIdTypeCode;
        private System.Collections.Generic.ICollection<CasePartyAICDetail> _mCPAICDPersonIdTypeCode;
        private System.Collections.Generic.ICollection<CaseParty> _mCPCompanyIdType;
        private System.Collections.Generic.ICollection<CaseParty> _mCPPersonIdType;
        private System.Collections.Generic.ICollection<DocCasePartyAICDetail> _mDCPAICDCompanyIdTypeCode;
        private System.Collections.Generic.ICollection<DocCasePartyAICDetail> _mDCPAICDPersonIdTypeCode;
        private System.Collections.Generic.ICollection<DocCaseParty> _mDCPCompanyIdType;
        private System.Collections.Generic.ICollection<DocCaseParty> _mDCPPersonIdType;
        private System.Collections.Generic.ICollection<Liquidator> _mLCompanyIdType;
        private System.Collections.Generic.ICollection<Liquidator> _mLPersonIdType;
        private System.String _obsInd;
        private System.Collections.Generic.ICollection<TravelPassInfo> _travelPassInfos;
        private System.String _uIDescription;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MPersonIDType"/> class.</summary>
        public MPersonIDType()
            : base()
        {
            _mCPCompanyIdType = new System.Collections.Generic.HashSet<CaseParty>();
            _mCPPersonIdType = new System.Collections.Generic.HashSet<CaseParty>();
            _mCPAICDCompanyIdTypeCode = new System.Collections.Generic.HashSet<CasePartyAICDetail>();
            _mCPAICDPersonIdTypeCode = new System.Collections.Generic.HashSet<CasePartyAICDetail>();
            _casePartyBailorInfos = new System.Collections.Generic.HashSet<CasePartyBailorInfo>();
            _mBODDCompanyIdType = new System.Collections.Generic.HashSet<BankruptcyOtherDefDetail>();
            _mBODDPersonIdType = new System.Collections.Generic.HashSet<BankruptcyOtherDefDetail>();
            _childInfos = new System.Collections.Generic.HashSet<ChildInfo>();
            _deceasedIdentifications = new System.Collections.Generic.HashSet<DeceasedIdentification>();
            _mLCompanyIdType = new System.Collections.Generic.HashSet<Liquidator>();
            _mLPersonIdType = new System.Collections.Generic.HashSet<Liquidator>();
            _liquidatorPICs = new System.Collections.Generic.HashSet<LiquidatorPIC>();
            _travelPassInfos = new System.Collections.Generic.HashSet<TravelPassInfo>();
            _mDCPCompanyIdType = new System.Collections.Generic.HashSet<DocCaseParty>();
            _mDCPPersonIdType = new System.Collections.Generic.HashSet<DocCaseParty>();
            _mDCPAICDCompanyIdTypeCode = new System.Collections.Generic.HashSet<DocCasePartyAICDetail>();
            _mDCPAICDPersonIdTypeCode = new System.Collections.Generic.HashSet<DocCasePartyAICDetail>();
            _docCasePartyBailorInfos = new System.Collections.Generic.HashSet<DocCasePartyBailorInfo>();
            _lABParties = new System.Collections.Generic.HashSet<LABParty>();
            _lABPartyHistories = new System.Collections.Generic.HashSet<LABPartyHistory>();
            _fileInspections = new System.Collections.Generic.HashSet<FileInspection>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyBailorInfo.MPersonIDType - Master.MPersonIDType.CasePartyBailorInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CasePartyBailorInfo> CasePartyBailorInfos
        {
            get { return _casePartyBailorInfos; }
            set { _casePartyBailorInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.ChildInfo.MPersonIDType - Master.MPersonIDType.ChildInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<ChildInfo> ChildInfos
        {
            get { return _childInfos; }
            set { _childInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.DeceasedIdentification.MPersonIDType - Master.MPersonIDType.DeceasedIdentifications (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DeceasedIdentification> DeceasedIdentifications
        {
            get { return _deceasedIdentifications; }
            set { _deceasedIdentifications = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyBailorInfo.MPersonIDType - Master.MPersonIDType.DocCasePartyBailorInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCasePartyBailorInfo> DocCasePartyBailorInfos
        {
            get { return _docCasePartyBailorInfos; }
            set { _docCasePartyBailorInfos = value; }
        }

        /// <summary>Gets or sets the EntityTypeCode field. </summary>
        public virtual System.String EntityTypeCode
        {
            get { return _entityTypeCode; }
            set { _entityTypeCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Subsequent.FileInspection.MPersonIDType - Master.MPersonIDType.FileInspections (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<FileInspection> FileInspections
        {
            get { return _fileInspections; }
            set { _fileInspections = value; }
        }

        /// <summary>Gets or sets the IdTypeCode field. </summary>
        public virtual System.String IdTypeCode
        {
            get { return _idTypeCode; }
            set { _idTypeCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LAP.LABParty.MPersonIDType - Master.MPersonIDType.LABParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LABParty> LABParties
        {
            get { return _lABParties; }
            set { _lABParties = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LAP.LABPartyHistory.MPersonIDType - Master.MPersonIDType.LABPartyHistories (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LABPartyHistory> LABPartyHistories
        {
            get { return _lABPartyHistories; }
            set { _lABPartyHistories = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'Common.LiquidatorPIC.MPersonIDType - Master.MPersonIDType.LiquidatorPICs (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LiquidatorPIC> LiquidatorPICs
        {
            get { return _liquidatorPICs; }
            set { _liquidatorPICs = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.BankruptcyOtherDefDetail.MBODDCompanyIdType - Master.MPersonIDType.MBODDCompanyIdType (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<BankruptcyOtherDefDetail> MBODDCompanyIdType
        {
            get { return _mBODDCompanyIdType; }
            set { _mBODDCompanyIdType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.BankruptcyOtherDefDetail.MBODDPersonIdType - Master.MPersonIDType.MBODDPersonIdType (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<BankruptcyOtherDefDetail> MBODDPersonIdType
        {
            get { return _mBODDPersonIdType; }
            set { _mBODDPersonIdType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.MCPAICDCompanyIdTypeCode - Master.MPersonIDType.MCPAICDCompanyIdTypeCode (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CasePartyAICDetail> MCPAICDCompanyIdTypeCode
        {
            get { return _mCPAICDCompanyIdTypeCode; }
            set { _mCPAICDCompanyIdTypeCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.MCPAICDPersonIdTypeCode - Master.MPersonIDType.MCPAICDPersonIdTypeCode (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CasePartyAICDetail> MCPAICDPersonIdTypeCode
        {
            get { return _mCPAICDPersonIdTypeCode; }
            set { _mCPAICDPersonIdTypeCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CaseParty.MCPCompanyIdType - Master.MPersonIDType.MCPCompanyIdType (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaseParty> MCPCompanyIdType
        {
            get { return _mCPCompanyIdType; }
            set { _mCPCompanyIdType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CaseParty.MCPPersonIdType - Master.MPersonIDType.MCPPersonIdType (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaseParty> MCPPersonIdType
        {
            get { return _mCPPersonIdType; }
            set { _mCPPersonIdType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyAICDetail.MDCPAICDCompanyIdTypeCode - Master.MPersonIDType.MDCPAICDCompanyIdTypeCode (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCasePartyAICDetail> MDCPAICDCompanyIdTypeCode
        {
            get { return _mDCPAICDCompanyIdTypeCode; }
            set { _mDCPAICDCompanyIdTypeCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyAICDetail.MDCPAICDPersonIdTypeCode - Master.MPersonIDType.MDCPAICDPersonIdTypeCode (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCasePartyAICDetail> MDCPAICDPersonIdTypeCode
        {
            get { return _mDCPAICDPersonIdTypeCode; }
            set { _mDCPAICDPersonIdTypeCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCaseParty.MDCPCompanyIdType - Master.MPersonIDType.MDCPCompanyIdType (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCaseParty> MDCPCompanyIdType
        {
            get { return _mDCPCompanyIdType; }
            set { _mDCPCompanyIdType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCaseParty.MDCPPersonIdType - Master.MPersonIDType.MDCPPersonIdType (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCaseParty> MDCPPersonIdType
        {
            get { return _mDCPPersonIdType; }
            set { _mDCPPersonIdType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.Liquidator.MLCompanyIdType - Master.MPersonIDType.MLCompanyIdType (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<Liquidator> MLCompanyIdType
        {
            get { return _mLCompanyIdType; }
            set { _mLCompanyIdType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.Liquidator.MLPersonIdType - Master.MPersonIDType.MLPersonIdType (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<Liquidator> MLPersonIdType
        {
            get { return _mLPersonIdType; }
            set { _mLPersonIdType = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.TravelPassInfo.MPersonIDType - Master.MPersonIDType.TravelPassInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<TravelPassInfo> TravelPassInfos
        {
            get { return _travelPassInfos; }
            set { _travelPassInfos = value; }
        }

        /// <summary>Gets or sets the UIDescription field. </summary>
        public virtual System.String UIDescription
        {
            get { return _uIDescription; }
            set { _uIDescription = value; }
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
            MPersonIDType toCompareWith = obj as MPersonIDType;
            return toCompareWith == null ? false : ((this.IdTypeCode == toCompareWith.IdTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.IdTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}