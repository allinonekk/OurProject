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

    /// <summary>Class which represents the entity 'Enforcement.EMSRecapitDetails'</summary>
    public partial class EMSRecapitDetails : IEnforcement
    {
        #region Fields

        private EMSAccount eMSAccount;
        private System.Decimal _currBal;
        private System.String _eMSRecapitDetailsId;
        private EMSRecapitulation _eMSRecapitulation;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.DateTime _lastTransDate;
        private JudicialUser _lastTransUser;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSRecapitDetails"/> class.</summary>
        public EMSRecapitDetails()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the CurrBal field. </summary>
        public virtual System.Decimal CurrBal
        {
            get { return _currBal; }
            set { _currBal = value; }
        }

        /// <summary>Gets or sets the EMSAccount field. </summary>
        public virtual EMSAccount EMSAccount
        {
            get { return eMSAccount; }
            set { eMSAccount = value; }
        }

        /// <summary>Gets or sets the EMSRecapitDetailsId field. </summary>
        public virtual System.String EMSRecapitDetailsId
        {
            get { return _eMSRecapitDetailsId; }
            set { _eMSRecapitDetailsId = value; }
        }

        /// <summary>Gets or sets the EMSRecapitulation field. </summary>
        public virtual EMSRecapitulation EMSRecapitulation
        {
            get { return _eMSRecapitulation; }
            set { _eMSRecapitulation = value; }
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

        /// <summary>Gets or sets the LastTransDate field. </summary>
        public virtual System.DateTime LastTransDate
        {
            get { return _lastTransDate; }
            set { _lastTransDate = value; }
        }

        /// <summary>Gets or sets the JudicialUser field. </summary>
        public virtual JudicialUser LastTransUser
        {
            get { return _lastTransUser; }
            set { _lastTransUser = value; }
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
            EMSRecapitDetails toCompareWith = obj as EMSRecapitDetails;
            return toCompareWith == null ? false : ((this.EMSRecapitDetailsId == toCompareWith.EMSRecapitDetailsId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSRecapitDetailsId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}