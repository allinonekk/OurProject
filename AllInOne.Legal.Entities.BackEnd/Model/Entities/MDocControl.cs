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

    /// <summary>Class which represents the entity 'Master.MDocControl'</summary>
    public partial class MDocControl : IMaster
    {
        #region Fields

        private System.String _amendPartyInd;
        private System.String _autoAcceptInd;
        private System.String _comDocGroupInd;
        private System.String _dIYInd;
        private System.String _docControlId;
        private System.String _docPrefix;
        private System.String _feeRuleCode;
        private System.String _hearingInd;
        private System.String _isMandatory;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MCourtType _mCourtType;
        private MCaseType _mDCCaseType;
        private MCaseType _mDCSubCaseType;
        private MDocCode _mDocCode;
        private System.String _obsInd;
        private System.String _specialReqInd;
        private System.String _subDocGroupInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MDocControl"/> class.</summary>
        public MDocControl()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AmendPartyInd field. </summary>
        public virtual System.String AmendPartyInd
        {
            get { return _amendPartyInd; }
            set { _amendPartyInd = value; }
        }

        /// <summary>Gets or sets the AutoAcceptInd field. </summary>
        public virtual System.String AutoAcceptInd
        {
            get { return _autoAcceptInd; }
            set { _autoAcceptInd = value; }
        }

        /// <summary>Gets or sets the ComDocGroupInd field. </summary>
        public virtual System.String ComDocGroupInd
        {
            get { return _comDocGroupInd; }
            set { _comDocGroupInd = value; }
        }

        /// <summary>Gets or sets the DIYInd field. </summary>
        public virtual System.String DIYInd
        {
            get { return _dIYInd; }
            set { _dIYInd = value; }
        }

        /// <summary>Gets or sets the DocControlId field. </summary>
        public virtual System.String DocControlId
        {
            get { return _docControlId; }
            set { _docControlId = value; }
        }

        /// <summary>Gets or sets the DocPrefix field. </summary>
        public virtual System.String DocPrefix
        {
            get { return _docPrefix; }
            set { _docPrefix = value; }
        }

        /// <summary>Gets or sets the FeeRuleCode field. </summary>
        public virtual System.String FeeRuleCode
        {
            get { return _feeRuleCode; }
            set { _feeRuleCode = value; }
        }

        /// <summary>Gets or sets the HearingInd field. </summary>
        public virtual System.String HearingInd
        {
            get { return _hearingInd; }
            set { _hearingInd = value; }
        }

        /// <summary>Gets or sets the IsMandatory field. </summary>
        public virtual System.String IsMandatory
        {
            get { return _isMandatory; }
            set { _isMandatory = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MDocControl.MCourtType - Master.MCourtType.MDocControls (m:1)'</summary>
        public virtual MCourtType MCourtType
        {
            get { return _mCourtType; }
            set { _mCourtType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MDocControl.MDCCaseType - Master.MCaseType.MCTCaseType (m:1)'</summary>
        public virtual MCaseType MDCCaseType
        {
            get { return _mDCCaseType; }
            set { _mDCCaseType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MDocControl.MDCSubCaseType - Master.MCaseType.MCTSubCaseType (m:1)'</summary>
        public virtual MCaseType MDCSubCaseType
        {
            get { return _mDCSubCaseType; }
            set { _mDCSubCaseType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MDocControl.MDocCode - Master.MDocCode.MDocControls (m:1)'</summary>
        public virtual MDocCode MDocCode
        {
            get { return _mDocCode; }
            set { _mDocCode = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the SpecialReqInd field. </summary>
        public virtual System.String SpecialReqInd
        {
            get { return _specialReqInd; }
            set { _specialReqInd = value; }
        }

        /// <summary>Gets or sets the SubDocGroupInd field. </summary>
        public virtual System.String SubDocGroupInd
        {
            get { return _subDocGroupInd; }
            set { _subDocGroupInd = value; }
        }

        public virtual string AmendFeeRuleCode
        {
            get;
            set;
        }

        public virtual string ProcessPartyStatusUpdateInd
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
            MDocControl toCompareWith = obj as MDocControl;
            return toCompareWith == null ? false : ((this.DocControlId == toCompareWith.DocControlId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocControlId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}