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

    /// <summary>Class which represents the entity 'Master.MChargeType'</summary>
    public partial class MChargeType : IMaster
    {
        #region Fields

        private System.Collections.Generic.ICollection<ChargeInfo> _chargeInfos;
        private System.String _chargeTypeCode;
        private System.String _description;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MChargeType"/> class.</summary>
        public MChargeType()
            : base()
        {
            _chargeInfos = new System.Collections.Generic.HashSet<ChargeInfo>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.ChargeInfo.MChargeType - Master.MChargeType.ChargeInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<ChargeInfo> ChargeInfos
        {
            get { return _chargeInfos; }
            set { _chargeInfos = value; }
        }

        /// <summary>Gets or sets the ChargeTypeCode field. </summary>
        public virtual System.String ChargeTypeCode
        {
            get { return _chargeTypeCode; }
            set { _chargeTypeCode = value; }
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
            MChargeType toCompareWith = obj as MChargeType;
            return toCompareWith == null ? false : ((this.ChargeTypeCode == toCompareWith.ChargeTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ChargeTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}