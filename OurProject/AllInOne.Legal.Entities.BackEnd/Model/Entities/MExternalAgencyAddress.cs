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

    /// <summary>Class which represents the entity 'Master.MExternalAgencyAddress'</summary>
    public partial class MExternalAgencyAddress : IMaster
    {
        #region Fields

        private System.String _address;
        private System.String _blkNo;
        private System.String _buildingName;
        private System.String _description;
        private System.String _externalAgencyAddressId;
        private System.String _floorNo;
        private System.String _formatInd;
        private System.Int32 _itemNo;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MExternalAgency _mExternalAgency;
        private System.String _obsInd;
        private System.String _postalCode;
        private System.String _streetName;
        private System.String _unitNo;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MExternalAgencyAddress"/> class.</summary>
        public MExternalAgencyAddress()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the Address field. </summary>
        public virtual System.String Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>Gets or sets the BlkNo field. </summary>
        public virtual System.String BlkNo
        {
            get { return _blkNo; }
            set { _blkNo = value; }
        }

        /// <summary>Gets or sets the BuildingName field. </summary>
        public virtual System.String BuildingName
        {
            get { return _buildingName; }
            set { _buildingName = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Gets or sets the ExternalAgencyAddressId field. </summary>
        public virtual System.String ExternalAgencyAddressId
        {
            get { return _externalAgencyAddressId; }
            set { _externalAgencyAddressId = value; }
        }

        /// <summary>Gets or sets the FloorNo field. </summary>
        public virtual System.String FloorNo
        {
            get { return _floorNo; }
            set { _floorNo = value; }
        }

        /// <summary>Gets or sets the FormatInd field. </summary>
        public virtual System.String FormatInd
        {
            get { return _formatInd; }
            set { _formatInd = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MExternalAgencyAddress.MExternalAgency - Master.MExternalAgency.MExternalAgencyAddresses (m:1)'</summary>
        public virtual MExternalAgency MExternalAgency
        {
            get { return _mExternalAgency; }
            set { _mExternalAgency = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the PostalCode field. </summary>
        public virtual System.String PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }

        /// <summary>Gets or sets the StreetName field. </summary>
        public virtual System.String StreetName
        {
            get { return _streetName; }
            set { _streetName = value; }
        }

        /// <summary>Gets or sets the UnitNo field. </summary>
        public virtual System.String UnitNo
        {
            get { return _unitNo; }
            set { _unitNo = value; }
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
            MExternalAgencyAddress toCompareWith = obj as MExternalAgencyAddress;
            return toCompareWith == null ? false : ((this.ExternalAgencyAddressId == toCompareWith.ExternalAgencyAddressId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ExternalAgencyAddressId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}