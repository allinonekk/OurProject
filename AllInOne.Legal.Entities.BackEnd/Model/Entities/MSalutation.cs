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

    /// <summary>Class which represents the entity 'Master.MSalutation'</summary>
    public partial class MSalutation : IMaster
    {
        #region Fields

        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.String _salutation;
        private System.Collections.Generic.ICollection<Solicitor> _solicitors;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MSalutation"/> class.</summary>
        public MSalutation()
            : base()
        {
            _solicitors = new System.Collections.Generic.HashSet<Solicitor>();
        }

        #endregion Constructors

        #region Properties

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

        /// <summary>Gets or sets the Salutation field. </summary>
        public virtual System.String Salutation
        {
            get { return _salutation; }
            set { _salutation = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.Solicitor.MSalutation - Master.MSalutation.Solicitors (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<Solicitor> Solicitors
        {
            get { return _solicitors; }
            set { _solicitors = value; }
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
            MSalutation toCompareWith = obj as MSalutation;
            return toCompareWith == null ? false : ((this.Salutation == toCompareWith.Salutation));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.Salutation.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}