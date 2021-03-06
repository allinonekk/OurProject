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

    /// <summary>Class which represents the entity 'Master.MFunctions'</summary>
    public partial class MFunctions : IMaster
    {
        #region Fields

        private System.String _description;
        private System.String _functionCode;
        private System.String _functionControlName;
        private System.String _functionName;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _menuId;
        private System.String _obsInd;
        private System.String _parentFunctionCode;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MFunctions"/> class.</summary>
        public MFunctions()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public virtual string DenyAccessType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Gets or sets the FunctionCode field. </summary>
        public virtual System.String FunctionCode
        {
            get { return _functionCode; }
            set { _functionCode = value; }
        }

        /// <summary>Gets or sets the FunctionControlName field. </summary>
        public virtual System.String FunctionControlName
        {
            get { return _functionControlName; }
            set { _functionControlName = value; }
        }

        /// <summary>Gets or sets the FunctionName field. </summary>
        public virtual System.String FunctionName
        {
            get { return _functionName; }
            set { _functionName = value; }
        }

        public virtual string IsForMenu
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

        /// <summary>Gets or sets the MenuId field. </summary>
        public virtual System.String MenuId
        {
            get { return _menuId; }
            set { _menuId = value; }
        }

        /// <summary>Gets or sets the MenuURL field. </summary>
        public virtual String MenuURL
        {
            get;
            set;
        }

        public virtual String Module
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the ParentFunctionCode field. </summary>
        public virtual System.String ParentFunctionCode
        {
            get { return _parentFunctionCode; }
            set { _parentFunctionCode = value; }
        }

        public virtual Int32? SeqNo
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
            MFunctions toCompareWith = obj as MFunctions;
            return toCompareWith == null ? false : ((this.FunctionCode == toCompareWith.FunctionCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FunctionCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}