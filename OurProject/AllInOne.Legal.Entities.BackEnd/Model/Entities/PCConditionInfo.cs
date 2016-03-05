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

    /// <summary>Class which represents the entity 'Common.PCConditionInfo'</summary>
    public partial class PCConditionInfo
    {
        #region Fields

        private Nullable<System.DateTime> _aGCProcDateTime;
        private System.String _description;
        private System.String _hasJudicialOffUpdated;
        private System.String _isAGCApproved;
        private System.String _isLAWSOCApproved;
        private System.String _isSALApproved;
        private System.Int32 _itemNo;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private Nullable<System.DateTime> _lAWSOCProcDateTime;
        private System.String _pCConditionInfoId;
        private Nullable<System.DateTime> _sALProcDateTime;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="PCConditionInfo"/> class.</summary>
        public PCConditionInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AGCProcDateTime field. </summary>
        public virtual Nullable<System.DateTime> AGCProcDateTime
        {
            get { return _aGCProcDateTime; }
            set { _aGCProcDateTime = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Gets or sets the HasJudicialOffUpdated field. </summary>
        public virtual System.String HasJudicialOffUpdated
        {
            get { return _hasJudicialOffUpdated; }
            set { _hasJudicialOffUpdated = value; }
        }

        /// <summary>Gets or sets the IsAGCApproved field. </summary>
        public virtual System.String IsAGCApproved
        {
            get { return _isAGCApproved; }
            set { _isAGCApproved = value; }
        }

        /// <summary>Gets or sets the IsLAWSOCApproved field. </summary>
        public virtual System.String IsLAWSOCApproved
        {
            get { return _isLAWSOCApproved; }
            set { _isLAWSOCApproved = value; }
        }

        /// <summary>Gets or sets the IsSALApproved field. </summary>
        public virtual System.String IsSALApproved
        {
            get { return _isSALApproved; }
            set { _isSALApproved = value; }
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public virtual System.Int32 ItemNo
        {
            get { return _itemNo; }
            set { _itemNo = value; }
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

        /// <summary>Gets or sets the LAWSOCProcDateTime field. </summary>
        public virtual Nullable<System.DateTime> LAWSOCProcDateTime
        {
            get { return _lAWSOCProcDateTime; }
            set { _lAWSOCProcDateTime = value; }
        }

        /// <summary>Gets or sets the PCConditionInfoId field. </summary>
        public virtual System.String PCConditionInfoId
        {
            get { return _pCConditionInfoId; }
            set { _pCConditionInfoId = value; }
        }

        /// <summary>Gets or sets the SALProcDateTime field. </summary>
        public virtual Nullable<System.DateTime> SALProcDateTime
        {
            get { return _sALProcDateTime; }
            set { _sALProcDateTime = value; }
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
            PCConditionInfo toCompareWith = obj as PCConditionInfo;
            return toCompareWith == null ? false : ((this.PCConditionInfoId == toCompareWith.PCConditionInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PCConditionInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}