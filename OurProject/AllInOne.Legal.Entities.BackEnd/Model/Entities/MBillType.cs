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

    /// <summary>Class which represents the entity 'Master.MBillType'</summary>
    public partial class MBillType : IMaster
    {
        #region Fields

        private System.String _billTypeCode;
        private System.String _description;
        private System.String _isInterfaced;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MBillType"/> class.</summary>
        public MBillType()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the BillTypeCode field. </summary>
        public virtual System.String BillTypeCode
        {
            get { return _billTypeCode; }
            set { _billTypeCode = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Gets or sets the IsInterfaced field. </summary>
        public virtual System.String IsInterfaced
        {
            get { return _isInterfaced; }
            set { _isInterfaced = value; }
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
            MBillType toCompareWith = obj as MBillType;
            return toCompareWith == null ? false : ((this.BillTypeCode == toCompareWith.BillTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BillTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}