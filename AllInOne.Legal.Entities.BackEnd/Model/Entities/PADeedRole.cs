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

    /// <summary>Class which represents the entity 'Common.PADeedRole'</summary>
    public partial class PADeedRole
    {
        #region Fields

        private System.Int64 _deedInfoId;
        private DocCaseParty _docCaseParty;
        private System.Int32 _itemNo;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _pADeedRoleId;
        private System.String _role;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="PADeedRole"/> class.</summary>
        public PADeedRole()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the DeedInfoId field. </summary>
        public virtual System.Int64 DeedInfoId
        {
            get { return _deedInfoId; }
            set { _deedInfoId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.PADeedRole.DocCaseParty - Document.DocCaseParty.PADeedRoles (m:1)'</summary>
        public virtual DocCaseParty DocCaseParty
        {
            get { return _docCaseParty; }
            set { _docCaseParty = value; }
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public virtual System.Int32 ItemNo
        {
            get { return _itemNo; }
            set { _itemNo = value; }
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

        /// <summary>Gets or sets the PADeedRoleId field. </summary>
        public virtual System.String PADeedRoleId
        {
            get { return _pADeedRoleId; }
            set { _pADeedRoleId = value; }
        }

        /// <summary>Gets or sets the Role field. </summary>
        public virtual System.String Role
        {
            get { return _role; }
            set { _role = value; }
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
            PADeedRole toCompareWith = obj as PADeedRole;
            return toCompareWith == null ? false : ((this.PADeedRoleId == toCompareWith.PADeedRoleId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PADeedRoleId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}