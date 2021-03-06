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

    /// <summary>Class which represents the entity 'SubCaseSpecific.RARASInfo'</summary>
    public partial class RARASInfo : ISubCaseSpecific
    {
        #region Fields

        private System.String _appealAgainstJudOrder;
        private System.String _appealAgainstME;
        private Nullable<System.DateTime> _dateofOrder;
        private System.String _isEOTOrderObtained;
        private System.String _isLOCOrderObtainted;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _rARASInfoId;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="RARASInfo"/> class.</summary>
        public RARASInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AppealAgainstJudOrder field. </summary>
        public virtual System.String AppealAgainstJudOrder
        {
            get { return _appealAgainstJudOrder; }
            set { _appealAgainstJudOrder = value; }
        }

        /// <summary>Gets or sets the AppealAgainstME field. </summary>
        public virtual System.String AppealAgainstME
        {
            get { return _appealAgainstME; }
            set { _appealAgainstME = value; }
        }

        /// <summary>Gets or sets the AppealAgainstUserId field. </summary>
        public virtual String AppealAgainstUserId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateofOrder field. </summary>
        public virtual Nullable<System.DateTime> DateofOrder
        {
            get { return _dateofOrder; }
            set { _dateofOrder = value; }
        }

        /// <summary>Gets or sets the IsEOTOrderObtained field. </summary>
        public virtual System.String IsEOTOrderObtained
        {
            get { return _isEOTOrderObtained; }
            set { _isEOTOrderObtained = value; }
        }

        /// <summary>Gets or sets the IsLOCOrderObtainted field. </summary>
        public virtual System.String IsLOCOrderObtainted
        {
            get { return _isLOCOrderObtainted; }
            set { _isLOCOrderObtainted = value; }
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

        public virtual MDesignation MDesignation
        {
            get;
            set;
        }

        /// <summary>Gets or sets the RARASInfoId field. </summary>
        public virtual System.String RARASInfoId
        {
            get { return _rARASInfoId; }
            set { _rARASInfoId = value; }
        }

        public virtual String SeekDirectionInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
        }

        public virtual MCoram MCoram
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
            RARASInfo toCompareWith = obj as RARASInfo;
            return toCompareWith == null ? false : ((this.RARASInfoId == toCompareWith.RARASInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RARASInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}