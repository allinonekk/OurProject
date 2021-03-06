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

    /// <summary>Class which represents the entity 'LAP.LABSection17CertInfo'</summary>
    public partial class LABSection17CertInfo : ILAP
    {
        #region Fields

        private System.String _isGAPGAFiled;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _section17CertId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="LABSection17CertInfo"/> class.</summary>
        public LABSection17CertInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        ///// <summary>Represents the navigator which is mapped onto the association 'LAP.LABSection17CertInfo.CaseInfo - Case.CaseInfo.LABSection17CertInfos (m:1)'</summary>
        //public virtual CaseInfo CaseInfo
        //{
        //    get { return _caseInfo; }
        //    set { _caseInfo = value; }
        //}
        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public virtual Int64? CaseInfoId
        {
            get;
            set;
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'LAP.LABSection17CertInfo.CaseParty - Case.CaseParty.LABSection17CertInfos (m:1)'</summary>
        //public virtual CaseParty CaseParty
        //{
        //    get { return _caseParty; }
        //    set { _caseParty = value; }
        //}
        /// <summary>Gets or sets the CasePartyId field. </summary>
        public virtual System.String CasePartyId
        {
            get;
            set;
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'LAP.LABSection17CertInfo.DocumentInfo - Document.DocumentInfo.LABSection17CertInfos (m:1)'</summary>
        //public virtual DocumentInfo DocumentInfo
        //{
        //    get { return _documentInfo; }
        //    set { _documentInfo = value; }
        //}
        /// <summary>Gets or sets the DocId field. </summary>
        public virtual System.String DocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsGAPGAFiled field. </summary>
        public virtual System.String IsGAPGAFiled
        {
            get { return _isGAPGAFiled; }
            set { _isGAPGAFiled = value; }
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

        /// <summary>Gets or sets the Section17CertId field. </summary>
        public virtual System.String Section17CertId
        {
            get { return _section17CertId; }
            set { _section17CertId = value; }
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
            LABSection17CertInfo toCompareWith = obj as LABSection17CertInfo;
            return toCompareWith == null ? false : ((this.Section17CertId == toCompareWith.Section17CertId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.Section17CertId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}