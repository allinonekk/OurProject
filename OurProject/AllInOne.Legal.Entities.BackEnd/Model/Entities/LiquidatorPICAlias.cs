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

    /// <summary>Class which represents the entity 'Common.LiquidatorPICAlias'</summary>
    public partial class LiquidatorPICAlias : ICommon
    {
        #region Fields

        private System.String _aliasName;
        private System.Int32 _itemNo;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;

        //private LiquidatorPIC _liquidatorPIC;
        private System.String _liquidatorPICAliasId;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="LiquidatorPICAlias"/> class.</summary>
        public LiquidatorPICAlias()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AliasName field. </summary>
        public virtual System.String AliasName
        {
            get { return _aliasName; }
            set { _aliasName = value; }
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

        /// <summary>Gets or sets the LiquidatorPICAliasId field. </summary>
        public virtual System.String LiquidatorPICAliasId
        {
            get { return _liquidatorPICAliasId; }
            set { _liquidatorPICAliasId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CWU.LiquidatorPICAlias.LiquidatorPIC - CWU.LiquidatorPIC.LiquidatorPICAliases (m:1)'</summary>
        //public virtual LiquidatorPIC LiquidatorPIC
        //{
        //    get { return _liquidatorPIC; }
        //    set { _liquidatorPIC = value; }
        //}
        public virtual System.String LiquidatorPICId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
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
            LiquidatorPICAlias toCompareWith = obj as LiquidatorPICAlias;
            return toCompareWith == null ? false : ((this.LiquidatorPICAliasId == toCompareWith.LiquidatorPICAliasId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LiquidatorPICAliasId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}