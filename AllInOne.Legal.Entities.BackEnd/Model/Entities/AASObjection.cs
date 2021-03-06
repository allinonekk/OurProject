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

    /// <summary>Class which represents the entity 'CaseSpecific.AASObjection'</summary>
    public partial class AASObjection : ICaseSpecific
    {
        #region Fields

        private System.String _aASObjectionId;
        private System.String _bLEObjection;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _lawSocObjection;
        private System.String _publicObjection;
        private System.String _sALObjection;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="AASObjection"/> class.</summary>
        public AASObjection()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AASObjectionId field. </summary>
        public virtual System.String AASObjectionId
        {
            get { return _aASObjectionId; }
            set { _aASObjectionId = value; }
        }

        /// <summary>Gets or sets the BLEObjection field. </summary>
        public virtual System.String BLEObjection
        {
            get { return _bLEObjection; }
            set { _bLEObjection = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.AASObjection.CaseInfo - Case.CaseInfo.AASObjections (m:1)'</summary>
        //public virtual CaseInfo CaseInfo
        //{
        //    get { return _caseInfo; }
        //    set { _caseInfo = value; }
        //}
        public virtual Int64 CaseInfoId
        {
            get;
            set;
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

        /// <summary>Gets or sets the LawSocObjection field. </summary>
        public virtual System.String LawSocObjection
        {
            get { return _lawSocObjection; }
            set { _lawSocObjection = value; }
        }

        /// <summary>Gets or sets the PublicObjection field. </summary>
        public virtual System.String PublicObjection
        {
            get { return _publicObjection; }
            set { _publicObjection = value; }
        }

        /// <summary>Gets or sets the SALObjection field. </summary>
        public virtual System.String SALObjection
        {
            get { return _sALObjection; }
            set { _sALObjection = value; }
        }

        public virtual String SubmissionGroupId
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
            if (obj == null)
            {
                return false;
            }
            AASObjection toCompareWith = obj as AASObjection;
            return toCompareWith == null ? false : ((this.AASObjectionId == toCompareWith.AASObjectionId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AASObjectionId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}