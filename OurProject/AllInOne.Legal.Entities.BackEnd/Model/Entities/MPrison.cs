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

    /// <summary>Class which represents the entity 'Master.MPrison'</summary>
    public partial class MPrison : IMaster
    {
        #region Fields

        private System.Collections.Generic.ICollection<CasePartyCriminalInfo> _casePartyCriminalInfoCustodyPrisonCode;
        private System.Collections.Generic.ICollection<CasePartyCriminalInfo> _casePartyCriminalInfoRemandPrisonCode;
        private System.String _cRInd;
        private System.String _description;
        private System.Collections.Generic.ICollection<DocCasePartyCriminalInfo> _docCasePartyCriminalInfoCustodyPrisonCode;
        private System.Collections.Generic.ICollection<DocCasePartyCriminalInfo> _docCasePartyCriminalInfoRemandPrisonCode;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.String _prisonCode;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MPrison"/> class.</summary>
        public MPrison()
            : base()
        {
            _casePartyCriminalInfoCustodyPrisonCode = new System.Collections.Generic.HashSet<CasePartyCriminalInfo>();
            _casePartyCriminalInfoRemandPrisonCode = new System.Collections.Generic.HashSet<CasePartyCriminalInfo>();
            _docCasePartyCriminalInfoCustodyPrisonCode = new System.Collections.Generic.HashSet<DocCasePartyCriminalInfo>();
            _docCasePartyCriminalInfoRemandPrisonCode = new System.Collections.Generic.HashSet<DocCasePartyCriminalInfo>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyCriminalInfo.MPrisonCustodyPrisonCode - Master.MPrison.CasePartyCriminalInfoCustodyPrisonCode (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CasePartyCriminalInfo> CasePartyCriminalInfoCustodyPrisonCode
        {
            get { return _casePartyCriminalInfoCustodyPrisonCode; }
            set { _casePartyCriminalInfoCustodyPrisonCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyCriminalInfo.MPrisonRemandPrisonCode - Master.MPrison.CasePartyCriminalInfoRemandPrisonCode (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CasePartyCriminalInfo> CasePartyCriminalInfoRemandPrisonCode
        {
            get { return _casePartyCriminalInfoRemandPrisonCode; }
            set { _casePartyCriminalInfoRemandPrisonCode = value; }
        }

        /// <summary>Gets or sets the CRInd field. </summary>
        public virtual System.String CRInd
        {
            get { return _cRInd; }
            set { _cRInd = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyCriminalInfo.MPrisonCustodyPrisonCode - Master.MPrison.DocCasePartyCriminalInfoCustodyPrisonCode (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCasePartyCriminalInfo> DocCasePartyCriminalInfoCustodyPrisonCode
        {
            get { return _docCasePartyCriminalInfoCustodyPrisonCode; }
            set { _docCasePartyCriminalInfoCustodyPrisonCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyCriminalInfo.MPrisonRemandPrisonCode - Master.MPrison.DocCasePartyCriminalInfoRemandPrisonCode (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCasePartyCriminalInfo> DocCasePartyCriminalInfoRemandPrisonCode
        {
            get { return _docCasePartyCriminalInfoRemandPrisonCode; }
            set { _docCasePartyCriminalInfoRemandPrisonCode = value; }
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

        /// <summary>Gets or sets the PrisonCode field. </summary>
        public virtual System.String PrisonCode
        {
            get { return _prisonCode; }
            set { _prisonCode = value; }
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
            MPrison toCompareWith = obj as MPrison;
            return toCompareWith == null ? false : ((this.PrisonCode == toCompareWith.PrisonCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PrisonCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}