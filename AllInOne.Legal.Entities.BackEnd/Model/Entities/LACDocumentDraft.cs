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

    /// <summary>Class which represents the entity 'LAP.LACDocumentDraft'</summary>
    public partial class LACDocumentDraft : ILAP
    {
        #region Fields

        private System.String _lACDocDraftId;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="LACDocumentDraft"/> class.</summary>
        public LACDocumentDraft()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        ///// <summary>Represents the navigator which is mapped onto the association 'LAP.LACDocumentDraft.CaseInfo - Case.CaseInfo.LACDocumentDrafts (m:1)'</summary>
        //public virtual CaseInfo CaseInfo
        //{
        //    get { return _caseInfo; }
        //    set { _caseInfo = value; }
        //}
        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public virtual System.Int64 CaseInfoId
        {
            get;
            set;
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'LAP.LACDocumentDraft.CaseParty - Case.CaseParty.LACDocumentDrafts (m:1)'</summary>
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

        ///// <summary>Represents the navigator which is mapped onto the association 'LAP.LACDocumentDraft.LACDocumentDetail - LAP.LACDocumentDetail.LACDocumentDrafts (m:1)'</summary>
        //public virtual LACDocumentDetail LACDocumentDetail
        //{
        //    get { return _lACDocumentDetail; }
        //    set { _lACDocumentDetail = value; }
        //}
        /// <summary>Gets or sets the LACDocDetailId field. </summary>
        public virtual System.String LACDocDetailId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LACDocDraftId field. </summary>
        public virtual System.String LACDocDraftId
        {
            get { return _lACDocDraftId; }
            set { _lACDocDraftId = value; }
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
            LACDocumentDraft toCompareWith = obj as LACDocumentDraft;
            return toCompareWith == null ? false : ((this.LACDocDraftId == toCompareWith.LACDocDraftId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LACDocDraftId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}