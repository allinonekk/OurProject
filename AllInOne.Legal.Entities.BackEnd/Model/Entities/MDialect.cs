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

    /// <summary>Class which represents the entity 'Master.MDialect'</summary>
    public partial class MDialect : IMaster
    {
        #region Fields

        private System.Collections.Generic.ICollection<CaseParty> _caseParties;
        private System.String _description;
        private System.String _dialectCode;
        private System.Collections.Generic.ICollection<DocCaseParty> _docCaseParties;
        private Nullable<System.Int32> _frequencyInd;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private Nullable<System.Int32> _sortingType;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MDialect"/> class.</summary>
        public MDialect()
            : base()
        {
            _caseParties = new System.Collections.Generic.HashSet<CaseParty>();
            _docCaseParties = new System.Collections.Generic.HashSet<DocCaseParty>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CaseParty.MDialect - Master.MDialect.CaseParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaseParty> CaseParties
        {
            get { return _caseParties; }
            set { _caseParties = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Gets or sets the DialectCode field. </summary>
        public virtual System.String DialectCode
        {
            get { return _dialectCode; }
            set { _dialectCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCaseParty.MDialect - Master.MDialect.DocCaseParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCaseParty> DocCaseParties
        {
            get { return _docCaseParties; }
            set { _docCaseParties = value; }
        }

        /// <summary>Gets or sets the FrequencyInd field. </summary>
        public virtual Nullable<System.Int32> FrequencyInd
        {
            get { return _frequencyInd; }
            set { _frequencyInd = value; }
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

        /// <summary>Gets or sets the SortingType field. </summary>
        public virtual Nullable<System.Int32> SortingType
        {
            get { return _sortingType; }
            set { _sortingType = value; }
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
            MDialect toCompareWith = obj as MDialect;
            return toCompareWith == null ? false : ((this.DialectCode == toCompareWith.DialectCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DialectCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}