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

    /// <summary>Class which represents the entity 'Subsequent.VacHRGDatesReqInfo'</summary>
    public partial class VacHRGDatesReqInfo : ISubsequent
    {
        #region Fields

        private System.String _isVacatingCDR;
        private System.String _isVacatingWNewDate;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _submissionGroupId;
        private System.String _vacHRGDatesReqInfoId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="VacHRGDatesReqInfo"/> class.</summary>
        public VacHRGDatesReqInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the IsVacatingCDR field. </summary>
        public virtual System.String IsVacatingCDR
        {
            get { return _isVacatingCDR; }
            set { _isVacatingCDR = value; }
        }

        /// <summary>Gets or sets the IsVacatingWNewDate field. </summary>
        public virtual System.String IsVacatingWNewDate
        {
            get { return _isVacatingWNewDate; }
            set { _isVacatingWNewDate = value; }
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

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
        }

        /// <summary>Gets or sets the VacHRGDatesReqInfoId field. </summary>
        public virtual System.String VacHRGDatesReqInfoId
        {
            get { return _vacHRGDatesReqInfoId; }
            set { _vacHRGDatesReqInfoId = value; }
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
            VacHRGDatesReqInfo toCompareWith = obj as VacHRGDatesReqInfo;
            return toCompareWith == null ? false : ((this.VacHRGDatesReqInfoId == toCompareWith.VacHRGDatesReqInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.VacHRGDatesReqInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}