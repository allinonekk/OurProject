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

    /// <summary>Class which represents the entity 'Common.LiquidatorPICAddress'</summary>
    public partial class LiquidatorPICAddress : ICommon
    {
        #region Fields

        private System.String _addr1;
        private System.String _addr2;
        private System.String _addr3;
        private System.String _addr4;
        private System.String _address;
        private System.String _addrType;
        private System.String _blkNo;
        private System.String _buildingName;
        private System.String _countryCode;
        private System.String _floorNo;
        private System.String _formatInd;
        private System.Int32 _itemNo;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;

        //private LiquidatorPIC _liquidatorPIC;
        private System.String _liquidatorPICAddressId;
        private System.String _postalCode;
        private System.String _streetName;
        private System.String _submissionGroupId;
        private System.String _unitNo;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="LiquidatorPICAddress"/> class.</summary>
        public LiquidatorPICAddress()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the Addr1 field. </summary>
        public virtual System.String Addr1
        {
            get { return _addr1; }
            set { _addr1 = value; }
        }

        /// <summary>Gets or sets the Addr2 field. </summary>
        public virtual System.String Addr2
        {
            get { return _addr2; }
            set { _addr2 = value; }
        }

        /// <summary>Gets or sets the Addr3 field. </summary>
        public virtual System.String Addr3
        {
            get { return _addr3; }
            set { _addr3 = value; }
        }

        /// <summary>Gets or sets the Addr4 field. </summary>
        public virtual System.String Addr4
        {
            get { return _addr4; }
            set { _addr4 = value; }
        }

        /// <summary>Gets or sets the Address field. </summary>
        public virtual System.String Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>Gets or sets the AddrType field. </summary>
        public virtual System.String AddrType
        {
            get { return _addrType; }
            set { _addrType = value; }
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

        /// <summary>Gets or sets the CountryCode field. </summary>
        public virtual System.String CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
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

        /// <summary>Gets or sets the LiquidatorPICAddressId field. </summary>
        public virtual System.String LiquidatorPICAddressId
        {
            get { return _liquidatorPICAddressId; }
            set { _liquidatorPICAddressId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CWU.LiquidatorPICAddress.LiquidatorPIC - CWU.LiquidatorPIC.LiquidatorPICAddresses (m:1)'</summary>
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

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
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
            LiquidatorPICAddress toCompareWith = obj as LiquidatorPICAddress;
            return toCompareWith == null ? false : ((this.LiquidatorPICAddressId == toCompareWith.LiquidatorPICAddressId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LiquidatorPICAddressId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}