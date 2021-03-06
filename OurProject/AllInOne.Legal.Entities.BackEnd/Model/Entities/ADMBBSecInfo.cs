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

    /// <summary>Class which represents the entity 'Subsequent.ADMBBSecInfo'</summary>
    public partial class ADMBBSecInfo
    {
        #region Fields

        private System.String _aDMBBSecInfoId;

        //private ADMRSVCBBInfo _aDMRSVCBBInfo;
        private System.String _isMainSurety;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _securityAddress;
        private System.String _securityName;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ADMBBSecInfo"/> class.</summary>
        public ADMBBSecInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ADMBBSecInfoId field. </summary>
        public virtual System.String ADMBBSecInfoId
        {
            get { return _aDMBBSecInfoId; }
            set { _aDMBBSecInfoId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Subsequent.ADMBBSecInfo.ADMRSVCBBInfo - Subsequent.ADMRSVCBBInfo.ADMBBSecInfos (m:1)'</summary>
        //public virtual ADMRSVCBBInfo ADMRSVCBBInfo
        //{
        //    get { return _aDMRSVCBBInfo; }
        //    set { _aDMRSVCBBInfo = value; }
        //}
        public virtual System.String ADMRSVCBBInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsMainSurety field. </summary>
        public virtual System.String IsMainSurety
        {
            get { return _isMainSurety; }
            set { _isMainSurety = value; }
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

        /// <summary>Gets or sets the SecurityAddress field. </summary>
        public virtual System.String SecurityAddress
        {
            get { return _securityAddress; }
            set { _securityAddress = value; }
        }

        /// <summary>Gets or sets the SecurityName field. </summary>
        public virtual System.String SecurityName
        {
            get { return _securityName; }
            set { _securityName = value; }
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
            ADMBBSecInfo toCompareWith = obj as ADMBBSecInfo;
            return toCompareWith == null ? false : ((this.ADMBBSecInfoId == toCompareWith.ADMBBSecInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ADMBBSecInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}