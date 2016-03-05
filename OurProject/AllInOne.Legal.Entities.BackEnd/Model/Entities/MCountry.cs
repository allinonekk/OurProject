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

    /// <summary>Class which represents the entity 'Master.MCountry'</summary>
    public partial class MCountry : IMaster
    {
        #region Fields

        private System.Collections.Generic.ICollection<AreaOfLegalPractice> _areaOfLegalPractices;
        private System.Collections.Generic.ICollection<CasePartyBailorAddress> _casePartyBailorAddresses;
        private System.Collections.Generic.ICollection<CasePartyBailorInfo> _casePartyBailorInfos;
        private System.Collections.Generic.ICollection<CasePartyCitizenship> _casePartyCitizenships;
        private System.String _category;
        private System.Collections.Generic.ICollection<CaveatAAInfo> _caveatAAInfos;
        private System.Collections.Generic.ICollection<ChildInfo> _childInfos;
        private System.String _countryCode;
        private System.Collections.Generic.ICollection<DeceasedIdentification> _deceasedIdentifications;
        private System.Collections.Generic.ICollection<DegreeInfo> _degreeInfos;
        private System.String _description;
        private System.Collections.Generic.ICollection<DivorceInfo> _divorceInfosPlaceOfMarriage;
        private System.Collections.Generic.ICollection<DivorceInfo> _divorceInfosPlaceOfSolemnization;
        private System.Collections.Generic.ICollection<DocCasePartyBailorAddress> _docCasePartyBailorAddresses;
        private System.Collections.Generic.ICollection<DocCasePartyBailorInfo> _docCasePartyBailorInfos;
        private System.Collections.Generic.ICollection<DocCasePartyCitizenship> _docCasePartyCitizenships;
        private System.Collections.Generic.ICollection<FileInspection> _fileInspections;
        private Nullable<System.Int32> _frequencyInd;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.Collections.Generic.ICollection<LiquidatorPIC> _liquidatorPICs;
        private System.Collections.Generic.ICollection<BankruptcyOtherDefDetail> _mBODDCountryOfRegistration;
        private System.Collections.Generic.ICollection<BankruptcyOtherDefDetail> _mBODDIdCountry;
        private System.Collections.Generic.ICollection<CasePartyAICDetail> _mCPAICDCountryOfRegistration;
        private System.Collections.Generic.ICollection<CasePartyAICDetail> _mCPAICDIdCountryCode;
        private System.Collections.Generic.ICollection<CaseParty> _mCPBirthCountry;
        private System.Collections.Generic.ICollection<CaseParty> _mCPCountryOfRegistration;
        private System.Collections.Generic.ICollection<CaseParty> _mCPIdCountry;
        private System.Collections.Generic.ICollection<CaseParty> _mCPMarriageCountry;
        private System.Collections.Generic.ICollection<DocCasePartyAICDetail> _mDCPAICDCountryOfRegistration;
        private System.Collections.Generic.ICollection<DocCasePartyAICDetail> _mDCPAICDIdCountryCode;
        private System.Collections.Generic.ICollection<DocCaseParty> _mDCPBirthCountry;
        private System.Collections.Generic.ICollection<DocCaseParty> _mDCPCountryOfRegistration;
        private System.Collections.Generic.ICollection<DocCaseParty> _mDCPIdCountry;
        private System.Collections.Generic.ICollection<DocCaseParty> _mDCPMarriageCountry;
        private System.Collections.Generic.ICollection<DeceasedInfo> _mDICountry;
        private System.Collections.Generic.ICollection<DeceasedInfo> _mDIDomicileCountry;
        private System.Collections.Generic.ICollection<InfantInfo> _mIIBirthCountry;
        private System.Collections.Generic.ICollection<InfantInfo> _mIIResidenceCountry;
        private System.Collections.Generic.ICollection<Liquidator> _mLIdCountry;
        private System.Collections.Generic.ICollection<Liquidator> _mLIdCountryOfRegistration;
        private System.String _obsInd;
        private System.Collections.Generic.ICollection<OSInfo> _oSInfos;
        private System.Collections.Generic.ICollection<PracticeOfLawInfo> _practiceOfLawInfos;
        private System.Collections.Generic.ICollection<RelatedProceeding> _relatedProceedings;
        private System.Collections.Generic.ICollection<ServiceOfDocInfoDetail> _serviceOfDocInfoDetails;
        private Nullable<System.Int32> _sortingType;
        private System.Collections.Generic.ICollection<SubpoenaWitnessDetail> _subpoenaWitnessDetails;
        private System.Collections.Generic.ICollection<TravelPassInfo> _travelPassInfos;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MCountry"/> class.</summary>
        public MCountry()
            : base()
        {
            _mCPBirthCountry = new System.Collections.Generic.HashSet<CaseParty>();
            _mCPCountryOfRegistration = new System.Collections.Generic.HashSet<CaseParty>();
            _mCPIdCountry = new System.Collections.Generic.HashSet<CaseParty>();
            _mCPMarriageCountry = new System.Collections.Generic.HashSet<CaseParty>();
            _mCPAICDCountryOfRegistration = new System.Collections.Generic.HashSet<CasePartyAICDetail>();
            _mCPAICDIdCountryCode = new System.Collections.Generic.HashSet<CasePartyAICDetail>();
            _casePartyBailorAddresses = new System.Collections.Generic.HashSet<CasePartyBailorAddress>();
            _casePartyBailorInfos = new System.Collections.Generic.HashSet<CasePartyBailorInfo>();
            _casePartyCitizenships = new System.Collections.Generic.HashSet<CasePartyCitizenship>();
            _mBODDCountryOfRegistration = new System.Collections.Generic.HashSet<BankruptcyOtherDefDetail>();
            _mBODDIdCountry = new System.Collections.Generic.HashSet<BankruptcyOtherDefDetail>();
            _caveatAAInfos = new System.Collections.Generic.HashSet<CaveatAAInfo>();
            _oSInfos = new System.Collections.Generic.HashSet<OSInfo>();
            _practiceOfLawInfos = new System.Collections.Generic.HashSet<PracticeOfLawInfo>();
            _childInfos = new System.Collections.Generic.HashSet<ChildInfo>();
            _deceasedIdentifications = new System.Collections.Generic.HashSet<DeceasedIdentification>();
            _mDICountry = new System.Collections.Generic.HashSet<DeceasedInfo>();
            _mDIDomicileCountry = new System.Collections.Generic.HashSet<DeceasedInfo>();
            _degreeInfos = new System.Collections.Generic.HashSet<DegreeInfo>();
            _divorceInfosPlaceOfMarriage = new System.Collections.Generic.HashSet<DivorceInfo>();
            _divorceInfosPlaceOfSolemnization = new System.Collections.Generic.HashSet<DivorceInfo>();
            _mIIBirthCountry = new System.Collections.Generic.HashSet<InfantInfo>();
            _mIIResidenceCountry = new System.Collections.Generic.HashSet<InfantInfo>();
            _mLIdCountry = new System.Collections.Generic.HashSet<Liquidator>();
            _mLIdCountryOfRegistration = new System.Collections.Generic.HashSet<Liquidator>();
            _liquidatorPICs = new System.Collections.Generic.HashSet<LiquidatorPIC>();
            _relatedProceedings = new System.Collections.Generic.HashSet<RelatedProceeding>();
            _travelPassInfos = new System.Collections.Generic.HashSet<TravelPassInfo>();
            _mDCPBirthCountry = new System.Collections.Generic.HashSet<DocCaseParty>();
            _mDCPCountryOfRegistration = new System.Collections.Generic.HashSet<DocCaseParty>();
            _mDCPIdCountry = new System.Collections.Generic.HashSet<DocCaseParty>();
            _mDCPMarriageCountry = new System.Collections.Generic.HashSet<DocCaseParty>();
            _mDCPAICDCountryOfRegistration = new System.Collections.Generic.HashSet<DocCasePartyAICDetail>();
            _mDCPAICDIdCountryCode = new System.Collections.Generic.HashSet<DocCasePartyAICDetail>();
            _docCasePartyBailorAddresses = new System.Collections.Generic.HashSet<DocCasePartyBailorAddress>();
            _docCasePartyBailorInfos = new System.Collections.Generic.HashSet<DocCasePartyBailorInfo>();
            _docCasePartyCitizenships = new System.Collections.Generic.HashSet<DocCasePartyCitizenship>();
            _areaOfLegalPractices = new System.Collections.Generic.HashSet<AreaOfLegalPractice>();
            _serviceOfDocInfoDetails = new System.Collections.Generic.HashSet<ServiceOfDocInfoDetail>();
            _fileInspections = new System.Collections.Generic.HashSet<FileInspection>();
            _subpoenaWitnessDetails = new System.Collections.Generic.HashSet<SubpoenaWitnessDetail>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'SubCaseSpecific.AreaOfLegalPractice.MCountry - Master.MCountry.AreaOfLegalPractices (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<AreaOfLegalPractice> AreaOfLegalPractices
        {
            get { return _areaOfLegalPractices; }
            set { _areaOfLegalPractices = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyBailorAddress.MCountry - Master.MCountry.CasePartyBailorAddresses (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CasePartyBailorAddress> CasePartyBailorAddresses
        {
            get { return _casePartyBailorAddresses; }
            set { _casePartyBailorAddresses = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyBailorInfo.MCountry - Master.MCountry.CasePartyBailorInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CasePartyBailorInfo> CasePartyBailorInfos
        {
            get { return _casePartyBailorInfos; }
            set { _casePartyBailorInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyCitizenship.MCountry - Master.MCountry.CasePartyCitizenships (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CasePartyCitizenship> CasePartyCitizenships
        {
            get { return _casePartyCitizenships; }
            set { _casePartyCitizenships = value; }
        }

        /// <summary>Gets or sets the Category field. </summary>
        public virtual System.String Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.CaveatAAInfo.MCountry - Master.MCountry.CaveatAAInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaveatAAInfo> CaveatAAInfos
        {
            get { return _caveatAAInfos; }
            set { _caveatAAInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.ChildInfo.MCountry - Master.MCountry.ChildInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<ChildInfo> ChildInfos
        {
            get { return _childInfos; }
            set { _childInfos = value; }
        }

        /// <summary>Gets or sets the CountryCode field. </summary>
        public virtual System.String CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.DeceasedIdentification.MCountry - Master.MCountry.DeceasedIdentifications (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DeceasedIdentification> DeceasedIdentifications
        {
            get { return _deceasedIdentifications; }
            set { _deceasedIdentifications = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.DegreeInfo.MCountry - Master.MCountry.DegreeInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DegreeInfo> DegreeInfos
        {
            get { return _degreeInfos; }
            set { _degreeInfos = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.DivorceInfo.MCountryPlaceOfMarriage - Master.MCountry.DivorceInfosPlaceOfMarriage (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DivorceInfo> DivorceInfosPlaceOfMarriage
        {
            get { return _divorceInfosPlaceOfMarriage; }
            set { _divorceInfosPlaceOfMarriage = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.DivorceInfo.MCountryPlaceOfSolemnization - Master.MCountry.DivorceInfosPlaceOfSolemnization (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DivorceInfo> DivorceInfosPlaceOfSolemnization
        {
            get { return _divorceInfosPlaceOfSolemnization; }
            set { _divorceInfosPlaceOfSolemnization = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyBailorAddress.MCountry - Master.MCountry.DocCasePartyBailorAddresses (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCasePartyBailorAddress> DocCasePartyBailorAddresses
        {
            get { return _docCasePartyBailorAddresses; }
            set { _docCasePartyBailorAddresses = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyBailorInfo.MCountry - Master.MCountry.DocCasePartyBailorInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCasePartyBailorInfo> DocCasePartyBailorInfos
        {
            get { return _docCasePartyBailorInfos; }
            set { _docCasePartyBailorInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyCitizenship.MCountry - Master.MCountry.DocCasePartyCitizenships (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCasePartyCitizenship> DocCasePartyCitizenships
        {
            get { return _docCasePartyCitizenships; }
            set { _docCasePartyCitizenships = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Subsequent.FileInspection.MCountry - Master.MCountry.FileInspections (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<FileInspection> FileInspections
        {
            get { return _fileInspections; }
            set { _fileInspections = value; }
        }

        /// <summary>Gets or sets the FrequencyInd field. </summary>
        public virtual Nullable<System.Int32> FrequencyInd
        {
            get { return _frequencyInd; }
            set { _frequencyInd = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'Common.LiquidatorPIC.MCountry - Master.MCountry.LiquidatorPICs (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LiquidatorPIC> LiquidatorPICs
        {
            get { return _liquidatorPICs; }
            set { _liquidatorPICs = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.BankruptcyOtherDefDetail.MBODDCountryOfRegistration - Master.MCountry.MBODDCountryOfRegistration (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<BankruptcyOtherDefDetail> MBODDCountryOfRegistration
        {
            get { return _mBODDCountryOfRegistration; }
            set { _mBODDCountryOfRegistration = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.BankruptcyOtherDefDetail.MBODDIdCountry - Master.MCountry.MBODDIdCountry (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<BankruptcyOtherDefDetail> MBODDIdCountry
        {
            get { return _mBODDIdCountry; }
            set { _mBODDIdCountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.MCPAICDCountryOfRegistration - Master.MCountry.MCPAICDCountryOfRegistration (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CasePartyAICDetail> MCPAICDCountryOfRegistration
        {
            get { return _mCPAICDCountryOfRegistration; }
            set { _mCPAICDCountryOfRegistration = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.MCPAICDIdCountryCode - Master.MCountry.MCPAICDIdCountryCode (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CasePartyAICDetail> MCPAICDIdCountryCode
        {
            get { return _mCPAICDIdCountryCode; }
            set { _mCPAICDIdCountryCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CaseParty.MCPBirthCountry - Master.MCountry.MCPBirthCountry (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaseParty> MCPBirthCountry
        {
            get { return _mCPBirthCountry; }
            set { _mCPBirthCountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CaseParty.MCPCountryOfRegistration - Master.MCountry.MCPCountryOfRegistration (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaseParty> MCPCountryOfRegistration
        {
            get { return _mCPCountryOfRegistration; }
            set { _mCPCountryOfRegistration = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CaseParty.MCPIdCountry - Master.MCountry.MCPIdCountry (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaseParty> MCPIdCountry
        {
            get { return _mCPIdCountry; }
            set { _mCPIdCountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CaseParty.MCPMarriageCountry - Master.MCountry.MCPMarriageCountry (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaseParty> MCPMarriageCountry
        {
            get { return _mCPMarriageCountry; }
            set { _mCPMarriageCountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyAICDetail.MDCPAICDCountryOfRegistration - Master.MCountry.MDCPAICDCountryOfRegistration (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCasePartyAICDetail> MDCPAICDCountryOfRegistration
        {
            get { return _mDCPAICDCountryOfRegistration; }
            set { _mDCPAICDCountryOfRegistration = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyAICDetail.MDCPAICDIdCountryCode - Master.MCountry.MDCPAICDIdCountryCode (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCasePartyAICDetail> MDCPAICDIdCountryCode
        {
            get { return _mDCPAICDIdCountryCode; }
            set { _mDCPAICDIdCountryCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCaseParty.MDCPBirthCountry - Master.MCountry.MDCPBirthCountry (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCaseParty> MDCPBirthCountry
        {
            get { return _mDCPBirthCountry; }
            set { _mDCPBirthCountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCaseParty.MDCPCountryOfRegistration - Master.MCountry.MDCPCountryOfRegistration (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCaseParty> MDCPCountryOfRegistration
        {
            get { return _mDCPCountryOfRegistration; }
            set { _mDCPCountryOfRegistration = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCaseParty.MDCPIdCountry - Master.MCountry.MDCPIdCountry (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCaseParty> MDCPIdCountry
        {
            get { return _mDCPIdCountry; }
            set { _mDCPIdCountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCaseParty.MDCPMarriageCountry - Master.MCountry.MDCPMarriageCountry (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCaseParty> MDCPMarriageCountry
        {
            get { return _mDCPMarriageCountry; }
            set { _mDCPMarriageCountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.DeceasedInfo.MDICountry - Master.MCountry.MDICountry (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DeceasedInfo> MDICountry
        {
            get { return _mDICountry; }
            set { _mDICountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.DeceasedInfo.MDIDomicileCountry - Master.MCountry.MDIDomicileCountry (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DeceasedInfo> MDIDomicileCountry
        {
            get { return _mDIDomicileCountry; }
            set { _mDIDomicileCountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.InfantInfo.MIIBirthCountry - Master.MCountry.MIIBirthCountry (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<InfantInfo> MIIBirthCountry
        {
            get { return _mIIBirthCountry; }
            set { _mIIBirthCountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.InfantInfo.MIIResidenceCountry - Master.MCountry.MIIResidenceCountry (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<InfantInfo> MIIResidenceCountry
        {
            get { return _mIIResidenceCountry; }
            set { _mIIResidenceCountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.Liquidator.MLIdCountry - Master.MCountry.MLIdCountry (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<Liquidator> MLIdCountry
        {
            get { return _mLIdCountry; }
            set { _mLIdCountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.Liquidator.MLIdCountryOfRegistration - Master.MCountry.MLIdCountryOfRegistration (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<Liquidator> MLIdCountryOfRegistration
        {
            get { return _mLIdCountryOfRegistration; }
            set { _mLIdCountryOfRegistration = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.OSInfo.MCountry - Master.MCountry.OSInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<OSInfo> OSInfos
        {
            get { return _oSInfos; }
            set { _oSInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.PracticeOfLawInfo.MCountry - Master.MCountry.PracticeOfLawInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<PracticeOfLawInfo> PracticeOfLawInfos
        {
            get { return _practiceOfLawInfos; }
            set { _practiceOfLawInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.RelatedProceeding.MCountry - Master.MCountry.RelatedProceedings (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<RelatedProceeding> RelatedProceedings
        {
            get { return _relatedProceedings; }
            set { _relatedProceedings = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCaseSpecific.ServiceOfDocInfoDetail.MCountry - Master.MCountry.ServiceOfDocInfoDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<ServiceOfDocInfoDetail> ServiceOfDocInfoDetails
        {
            get { return _serviceOfDocInfoDetails; }
            set { _serviceOfDocInfoDetails = value; }
        }

        /// <summary>Gets or sets the SortingType field. </summary>
        public virtual Nullable<System.Int32> SortingType
        {
            get { return _sortingType; }
            set { _sortingType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Subsequent.SubpoenaWitnessDetail.MCountry - Master.MCountry.SubpoenaWitnessDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<SubpoenaWitnessDetail> SubpoenaWitnessDetails
        {
            get { return _subpoenaWitnessDetails; }
            set { _subpoenaWitnessDetails = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.TravelPassInfo.MCountry - Master.MCountry.TravelPassInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<TravelPassInfo> TravelPassInfos
        {
            get { return _travelPassInfos; }
            set { _travelPassInfos = value; }
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
            MCountry toCompareWith = obj as MCountry;
            return toCompareWith == null ? false : ((this.CountryCode == toCompareWith.CountryCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CountryCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}