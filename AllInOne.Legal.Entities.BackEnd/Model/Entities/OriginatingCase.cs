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

    /// <summary>Class which represents the entity 'Common.OriginatingCase'</summary>
    public partial class OriginatingCase : ICommon
    {
        #region Fields

        //private CaseInfo _caseInfo;
        private System.Int64 _caseInfoId;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MCourtType _mCourtType;
        private System.String _obsInd;
        private Nullable<System.Int64> _originatingCaseInfoId;
        private System.String _originatingCaseName;
        private System.String _originatingCaseNo;
        private System.String _recId;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="OriginatingCase"/> class.</summary>
        public OriginatingCase()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Common.OriginatingCase.CaseInfo - Case.CaseInfo.OriginatingCases (m:1)'</summary>
        //public virtual CaseInfo CaseInfo
        //{
        //    get { return _caseInfo; }
        //    set { _caseInfo = value; }
        //}
        public virtual System.Int64 CaseInfoId
        {
            get { return _caseInfoId; }
            set { _caseInfoId = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'Common.OriginatingCase.MCourtType - Master.MCourtType.OriginatingCases (m:1)'</summary>
        public virtual MCourtType MCourtType
        {
            get { return _mCourtType; }
            set { _mCourtType = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the OriginatingCaseInfoId field. </summary>
        public virtual Nullable<System.Int64> OriginatingCaseInfoId
        {
            get { return _originatingCaseInfoId; }
            set { _originatingCaseInfoId = value; }
        }

        /// <summary>Gets or sets the OriginatingCaseName field. </summary>
        public virtual System.String OriginatingCaseName
        {
            get { return _originatingCaseName; }
            set { _originatingCaseName = value; }
        }

        /// <summary>Gets or sets the OriginatingCaseNo field. </summary>
        public virtual System.String OriginatingCaseNo
        {
            get { return _originatingCaseNo; }
            set { _originatingCaseNo = value; }
        }

        /// <summary>Gets or sets the RecId field. </summary>
        public virtual System.String RecId
        {
            get { return _recId; }
            set { _recId = value; }
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
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
            OriginatingCase toCompareWith = obj as OriginatingCase;
            return toCompareWith == null ? false : ((this.RecId == toCompareWith.RecId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RecId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}