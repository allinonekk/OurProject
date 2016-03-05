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

    /// <summary>Class which represents the entity 'Document.RDocCaseParty'</summary>
    public partial class RDocCaseParty : IDocument
    {
        #region Fields

        //private DocCaseParty _docCaseParty;
        private System.String _dCPID;
        private System.String _docId;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _rDCPId;
        private System.String _updateInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="RDocCaseParty"/> class.</summary>
        public RDocCaseParty()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Document.RDocCaseParty.DocCaseParty - Document.DocCaseParty.RDocCaseParties (m:1)'</summary>
        //public virtual DocCaseParty DocCaseParty
        //{
        //    get { return _docCaseParty; }
        //    set { _docCaseParty = value; }
        //}
        /// <summary>Gets or sets the DCPID field. </summary>
        public virtual System.String DCPID
        {
            get { return _dCPID; }
            set { _dCPID = value; }
        }

        /// <summary>Gets or sets the DocId field. </summary>
        public virtual System.String DocId
        {
            get { return _docId; }
            set { _docId = value; }
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

        /// <summary>Gets or sets the RDCPId field. </summary>
        public virtual System.String RDCPId
        {
            get { return _rDCPId; }
            set { _rDCPId = value; }
        }

        /// <summary>Gets or sets the UpdateInd field. </summary>
        public virtual System.String UpdateInd
        {
            get { return _updateInd; }
            set { _updateInd = value; }
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
            RDocCaseParty toCompareWith = obj as RDocCaseParty;
            return toCompareWith == null ? false : ((this.RDCPId == toCompareWith.RDCPId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RDCPId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}