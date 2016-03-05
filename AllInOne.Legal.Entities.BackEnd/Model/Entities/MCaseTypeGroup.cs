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

    /// <summary>Class which represents the entity 'Master.MCaseTypeGroup'</summary>
    public partial class MCaseTypeGroup : IMaster
    {
        #region Fields

        private System.String _caseLevelInd;
        private System.String _caseTypeGroupCode;
        private System.String _description;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.Collections.Generic.ICollection<MCaseType> _mCaseTypes;
        private System.String _obsInd;
        private System.Int32 _seqNo;
        private Nullable<System.Int32> _sortingType;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MCaseTypeGroup"/> class.</summary>
        public MCaseTypeGroup()
            : base()
        {
            _mCaseTypes = new System.Collections.Generic.HashSet<MCaseType>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the CaseLevelInd field. </summary>
        public virtual System.String CaseLevelInd
        {
            get { return _caseLevelInd; }
            set { _caseLevelInd = value; }
        }

        /// <summary>Gets or sets the CaseTypeGroupCode field. </summary>
        public virtual System.String CaseTypeGroupCode
        {
            get { return _caseTypeGroupCode; }
            set { _caseTypeGroupCode = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MCaseType.MCaseTypeGroup - Master.MCaseTypeGroup.MCaseTypes (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<MCaseType> MCaseTypes
        {
            get { return _mCaseTypes; }
            set { _mCaseTypes = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the SeqNo field. </summary>
        public virtual System.Int32 SeqNo
        {
            get { return _seqNo; }
            set { _seqNo = value; }
        }

        /// <summary>Gets or sets the SortingType field. </summary>
        public virtual Nullable<System.Int32> SortingType
        {
            get { return _sortingType; }
            set { _sortingType = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String DisplayInd
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
            MCaseTypeGroup toCompareWith = obj as MCaseTypeGroup;
            return toCompareWith == null ? false : ((this.CaseTypeGroupCode == toCompareWith.CaseTypeGroupCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseTypeGroupCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}