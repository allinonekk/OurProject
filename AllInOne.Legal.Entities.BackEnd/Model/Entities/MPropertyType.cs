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

    /// <summary>Class which represents the entity 'Master.MPropertyType'</summary>
    public partial class MPropertyType : IMaster
    {
        #region Fields

        private System.String _description;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.String _propertyInd;
        private System.String _propertyTypeCode;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MPropertyType"/> class.</summary>
        public MPropertyType()
            : base()
        {
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

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the PropertyInd field. </summary>
        public virtual System.String PropertyInd
        {
            get { return _propertyInd; }
            set { _propertyInd = value; }
        }

        /// <summary>Gets or sets the PropertyTypeCode field. </summary>
        public virtual System.String PropertyTypeCode
        {
            get { return _propertyTypeCode; }
            set { _propertyTypeCode = value; }
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
            MPropertyType toCompareWith = obj as MPropertyType;
            return toCompareWith == null ? false : ((this.PropertyTypeCode == toCompareWith.PropertyTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PropertyTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}