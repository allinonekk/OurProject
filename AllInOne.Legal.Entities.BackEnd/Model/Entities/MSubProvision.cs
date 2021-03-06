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

    /// <summary>Class which represents the entity 'Master.MSubProvision'</summary>
    public partial class MSubProvision : IMaster
    {
        #region Fields

        private System.String _description;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.Collections.Generic.ICollection<LegislationProvision> _legislationProvisions;
        private System.Int32 _seqNo;
        private System.String _subProvisionCode;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MSubProvision"/> class.</summary>
        public MSubProvision()
            : base()
        {
            _legislationProvisions = new System.Collections.Generic.HashSet<LegislationProvision>();
        }

        #endregion Constructors

        #region Properties

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

        /// <summary>Represents the navigator which is mapped onto the association 'Common.LegislationProvision.MSubProvision - Master.MSubProvision.LegislationProvisions (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LegislationProvision> LegislationProvisions
        {
            get { return _legislationProvisions; }
            set { _legislationProvisions = value; }
        }

        /// <summary>Gets or sets the SeqNo field. </summary>
        public virtual System.Int32 SeqNo
        {
            get { return _seqNo; }
            set { _seqNo = value; }
        }

        /// <summary>Gets or sets the SubProvisionCode field. </summary>
        public virtual System.String SubProvisionCode
        {
            get { return _subProvisionCode; }
            set { _subProvisionCode = value; }
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
            MSubProvision toCompareWith = obj as MSubProvision;
            return toCompareWith == null ? false : ((this.SubProvisionCode == toCompareWith.SubProvisionCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SubProvisionCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}