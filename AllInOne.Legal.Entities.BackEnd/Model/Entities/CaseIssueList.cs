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

    /// <summary>Class which represents the entity 'Case.CaseIssueList'</summary>
    public partial class CaseIssueList : ICase
    {
        #region Fields

        private System.Int64 _caseInfoId;
        private System.String _caseIssueListId;
        private Nullable<System.Int64> _hRGID;
        private System.String _issueOutcome;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MCaseIssue _mCaseIssue;
        private System.String _otherDetails;
        private Nullable<System.Int32> _priorityOrder;
        private Nullable<System.Int64> _subCaseInfoId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="CaseIssueList"/> class.</summary>
        public CaseIssueList()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public virtual System.Int64 CaseInfoId
        {
            get { return _caseInfoId; }
            set { _caseInfoId = value; }
        }

        /// <summary>Gets or sets the CaseIssueListId field. </summary>
        public virtual System.String CaseIssueListId
        {
            get { return _caseIssueListId; }
            set { _caseIssueListId = value; }
        }

        /// <summary>Gets or sets the HRGID field. </summary>
        public virtual Nullable<System.Int64> HRGID
        {
            get { return _hRGID; }
            set { _hRGID = value; }
        }

        /// <summary>Gets or sets the IssueOutcome field. </summary>
        public virtual System.String IssueOutcome
        {
            get { return _issueOutcome; }
            set { _issueOutcome = value; }
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

        /// <summary>Gets or sets the MCaseIssue field. </summary>
        public virtual MCaseIssue MCaseIssue
        {
            get { return _mCaseIssue; }
            set { _mCaseIssue = value; }
        }

        /// <summary>Gets or sets the OtherDetails field. </summary>
        public virtual System.String OtherDetails
        {
            get { return _otherDetails; }
            set { _otherDetails = value; }
        }

        /// <summary>Gets or sets the SubCaseInfoId field. </summary>
        public virtual Nullable<System.Int32> PriorityOrder
        {
            get { return _priorityOrder; }
            set { _priorityOrder = value; }
        }

        /// <summary>Gets or sets the SubCaseInfoId field. </summary>
        public virtual Nullable<System.Int64> SubCaseInfoId
        {
            get { return _subCaseInfoId; }
            set { _subCaseInfoId = value; }
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
            CaseIssueList toCompareWith = obj as CaseIssueList;
            return toCompareWith == null ? false : ((this.CaseIssueListId == toCompareWith.CaseIssueListId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseIssueListId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}