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

    /// <summary>Class which represents the entity 'Master.MCriminalOrder'</summary>
    public partial class MCriminalOrder
    {
        #region Fields

        private System.String _criminalOrderCode;
        private System.String _description;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.Collections.Generic.ICollection<SentenceInfo> _sentenceInfos;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MCriminalOrder"/> class.</summary>
        public MCriminalOrder()
            : base()
        {
            _sentenceInfos = new System.Collections.Generic.HashSet<SentenceInfo>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the CriminalOrderCode field. </summary>
        public virtual System.String CriminalOrderCode
        {
            get { return _criminalOrderCode; }
            set { _criminalOrderCode = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.SentenceInfo.MCriminalOrder - Master.MCriminalOrder.SentenceInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<SentenceInfo> SentenceInfos
        {
            get { return _sentenceInfos; }
            set { _sentenceInfos = value; }
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
            MCriminalOrder toCompareWith = obj as MCriminalOrder;
            return toCompareWith == null ? false : ((this.CriminalOrderCode == toCompareWith.CriminalOrderCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CriminalOrderCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}