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

    /// <summary>Class which represents the entity 'Subsequent.BillOfSaleSubInfo'</summary>
    public partial class BillOfSaleSubInfo : ICommon
    {
        #region Fields

        private System.String _billOfSaleSubInfoId;
        private Nullable<System.DateTime> _instrumentDate;
        private System.String _isSeekingBorrower;
        private System.String _isSeekingInstrumentDate;
        private System.String _isSeekingLeaveOfCourt;
        private System.String _isSeekingLender;
        private System.String _isSeekingOthers;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _otherText;
        private System.String _submissionGroupId;
        private Nullable<System.DateTime> _satisfactionDate;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BillOfSaleSubInfo"/> class.</summary>
        public BillOfSaleSubInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the BillOfSaleSubInfoId field. </summary>
        public virtual System.String BillOfSaleSubInfoId
        {
            get { return _billOfSaleSubInfoId; }
            set { _billOfSaleSubInfoId = value; }
        }

        /// <summary>Gets or sets the InstrumentDate field. </summary>
        public virtual Nullable<System.DateTime> InstrumentDate
        {
            get { return _instrumentDate; }
            set { _instrumentDate = value; }
        }

        /// <summary>Gets or sets the IsSeekingBorrower field. </summary>
        public virtual System.String IsSeekingBorrower
        {
            get { return _isSeekingBorrower; }
            set { _isSeekingBorrower = value; }
        }

        /// <summary>Gets or sets the IsSeekingInstrumentDate field. </summary>
        public virtual System.String IsSeekingInstrumentDate
        {
            get { return _isSeekingInstrumentDate; }
            set { _isSeekingInstrumentDate = value; }
        }

        /// <summary>Gets or sets the IsSeekingLeaveOfCourt field. </summary>
        public virtual System.String IsSeekingLeaveOfCourt
        {
            get { return _isSeekingLeaveOfCourt; }
            set { _isSeekingLeaveOfCourt = value; }
        }

        /// <summary>Gets or sets the IsSeekingLender field. </summary>
        public virtual System.String IsSeekingLender
        {
            get { return _isSeekingLender; }
            set { _isSeekingLender = value; }
        }

        /// <summary>Gets or sets the IsSeekingOthers field. </summary>
        public virtual System.String IsSeekingOthers
        {
            get { return _isSeekingOthers; }
            set { _isSeekingOthers = value; }
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

        /// <summary>Gets or sets the OtherText field. </summary>
        public virtual System.String OtherText
        {
            get { return _otherText; }
            set { _otherText = value; }
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
        }

        /// <summary>Gets or sets the SatisfactionDate field. </summary>
        public virtual Nullable<System.DateTime> SatisfactionDate
        {
            get { return _satisfactionDate; }
            set { _satisfactionDate = value; }
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
            BillOfSaleSubInfo toCompareWith = obj as BillOfSaleSubInfo;
            return toCompareWith == null ? false : ((this.BillOfSaleSubInfoId == toCompareWith.BillOfSaleSubInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BillOfSaleSubInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}