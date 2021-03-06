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

    /// <summary>Class which represents the entity 'Master.MCaseStatus'</summary>
    public partial class MCaseStatus : IMaster
    {
        #region Fields

        private System.Collections.Generic.ICollection<CaseInfo> _caseInfos;
        private System.String _caseStatusCode;
        private System.String _description;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.Collections.Generic.ICollection<SubCaseInfo> _subCaseInfos;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MCaseStatus"/> class.</summary>
        public MCaseStatus()
            : base()
        {
            _caseInfos = new System.Collections.Generic.HashSet<CaseInfo>();
            _subCaseInfos = new System.Collections.Generic.HashSet<SubCaseInfo>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CaseInfo.MCaseStatus - Master.MCaseStatus.CaseInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaseInfo> CaseInfos
        {
            get { return _caseInfos; }
            set { _caseInfos = value; }
        }

        /// <summary>Gets or sets the CaseStatusCode field. </summary>
        public virtual System.String CaseStatusCode
        {
            get { return _caseStatusCode; }
            set { _caseStatusCode = value; }
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

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'SubCase.SubCaseInfo.MCaseStatus - Master.MCaseStatus.SubCaseInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<SubCaseInfo> SubCaseInfos
        {
            get { return _subCaseInfos; }
            set { _subCaseInfos = value; }
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
            MCaseStatus toCompareWith = obj as MCaseStatus;
            return toCompareWith == null ? false : ((this.CaseStatusCode == toCompareWith.CaseStatusCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseStatusCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}