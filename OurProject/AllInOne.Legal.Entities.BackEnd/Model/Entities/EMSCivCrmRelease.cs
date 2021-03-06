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

    /// <summary>Class which represents the entity 'Enforcement.EMSCivCrmRelease'</summary>
    public partial class EMSCivCrmRelease : IEnforcement
    {
        #region Fields

        private EMSAccount _eMSAccount;
        private System.String _eMSCivCrmReleaseId;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.DateTime _releaseDate;
        private System.String _releaseTo;
        private System.String _releaseType;
        private System.String _remarks;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSCivCrmRelease"/> class.</summary>
        public EMSCivCrmRelease()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSCivCrmRelease.EMSAccount - Enforcement.EMSAccount.EMSCivCrmReleases (m:1)'</summary>
        public virtual EMSAccount EMSAccount
        {
            get { return _eMSAccount; }
            set { _eMSAccount = value; }
        }

        /// <summary>Gets or sets the EMSCivCrmReleaseId field. </summary>
        public virtual System.String EMSCivCrmReleaseId
        {
            get { return _eMSCivCrmReleaseId; }
            set { _eMSCivCrmReleaseId = value; }
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

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the ReleaseDate field. </summary>
        public virtual System.DateTime ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }

        /// <summary>Gets or sets the ReleaseTo field. </summary>
        public virtual System.String ReleaseTo
        {
            get { return _releaseTo; }
            set { _releaseTo = value; }
        }

        /// <summary>Gets or sets the ReleaseType field. </summary>
        public virtual System.String ReleaseType
        {
            get { return _releaseType; }
            set { _releaseType = value; }
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public virtual System.String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        public virtual string SyncRequired
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
            EMSCivCrmRelease toCompareWith = obj as EMSCivCrmRelease;
            return toCompareWith == null ? false : ((this.EMSCivCrmReleaseId == toCompareWith.EMSCivCrmReleaseId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSCivCrmReleaseId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}