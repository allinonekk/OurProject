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

    /// <summary>Class which represents the entity 'Master.MGender'</summary>
    public partial class MGender : IMaster
    {
        #region Fields

        private System.Collections.Generic.ICollection<CaseParty> _caseParties;
        private System.Collections.Generic.ICollection<CasePartyAICDetail> _casePartyAICDetails;
        private System.Collections.Generic.ICollection<ChildInfo> _childInfos;
        private System.String _description;
        private System.Collections.Generic.ICollection<DocCaseParty> _docCaseParties;
        private System.Collections.Generic.ICollection<DocCasePartyAICDetail> _docCasePartyAICDetails;
        private System.String _genderCode;
        private System.Collections.Generic.ICollection<InfantInfo> _infantInfos;
        private System.Collections.Generic.ICollection<LABParty> _lABParties;
        private System.Collections.Generic.ICollection<LABPartyHistory> _lABPartyHistories;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.Collections.Generic.ICollection<LiquidatorPIC> _liquidatorPICs;
        private System.Collections.Generic.ICollection<Liquidator> _liquidators;
        private System.String _obsInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MGender"/> class.</summary>
        public MGender()
            : base()
        {
            _caseParties = new System.Collections.Generic.HashSet<CaseParty>();
            _casePartyAICDetails = new System.Collections.Generic.HashSet<CasePartyAICDetail>();
            _childInfos = new System.Collections.Generic.HashSet<ChildInfo>();
            _infantInfos = new System.Collections.Generic.HashSet<InfantInfo>();
            _liquidators = new System.Collections.Generic.HashSet<Liquidator>();
            _liquidatorPICs = new System.Collections.Generic.HashSet<LiquidatorPIC>();
            _docCaseParties = new System.Collections.Generic.HashSet<DocCaseParty>();
            _docCasePartyAICDetails = new System.Collections.Generic.HashSet<DocCasePartyAICDetail>();
            _lABParties = new System.Collections.Generic.HashSet<LABParty>();
            _lABPartyHistories = new System.Collections.Generic.HashSet<LABPartyHistory>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CaseParty.MGender - Master.MGender.CaseParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaseParty> CaseParties
        {
            get { return _caseParties; }
            set { _caseParties = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.MGender - Master.MGender.CasePartyAICDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CasePartyAICDetail> CasePartyAICDetails
        {
            get { return _casePartyAICDetails; }
            set { _casePartyAICDetails = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.ChildInfo.MGender - Master.MGender.ChildInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<ChildInfo> ChildInfos
        {
            get { return _childInfos; }
            set { _childInfos = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCaseParty.MGender - Master.MGender.DocCaseParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCaseParty> DocCaseParties
        {
            get { return _docCaseParties; }
            set { _docCaseParties = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyAICDetail.MGender - Master.MGender.DocCasePartyAICDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCasePartyAICDetail> DocCasePartyAICDetails
        {
            get { return _docCasePartyAICDetails; }
            set { _docCasePartyAICDetails = value; }
        }

        /// <summary>Gets or sets the GenderCode field. </summary>
        public virtual System.String GenderCode
        {
            get { return _genderCode; }
            set { _genderCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.InfantInfo.MGender - Master.MGender.InfantInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<InfantInfo> InfantInfos
        {
            get { return _infantInfos; }
            set { _infantInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LAP.LABParty.MGender - Master.MGender.LABParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LABParty> LABParties
        {
            get { return _lABParties; }
            set { _lABParties = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LAP.LABPartyHistory.MGender - Master.MGender.LABPartyHistories (m:1)'</summary>
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

        /// <summary>Represents the navigator which is mapped onto the association 'Common.LiquidatorPIC.MGender - Master.MGender.LiquidatorPICs (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LiquidatorPIC> LiquidatorPICs
        {
            get { return _liquidatorPICs; }
            set { _liquidatorPICs = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.Liquidator.MGender - Master.MGender.Liquidators (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<Liquidator> Liquidators
        {
            get { return _liquidators; }
            set { _liquidators = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        public virtual Int32 SeqNo
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
            MGender toCompareWith = obj as MGender;
            return toCompareWith == null ? false : ((this.GenderCode == toCompareWith.GenderCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.GenderCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}