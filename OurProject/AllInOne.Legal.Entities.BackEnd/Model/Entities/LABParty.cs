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

    /// <summary>Class which represents the entity 'LAP.LABParty'</summary>
    public partial class LABParty : ILAP
    {
        #region Fields

        private System.String _contactTypeInd;
        private System.String _email;
        private System.String _faxAreaCode;
        private System.String _faxCountryCode;
        private System.String _faxNumber;
        private System.String _fullName;
        private System.String _idNumber;
        private System.Collections.Generic.ICollection<LABPartyAddress> _lABPartyAddresses;
        private System.Collections.Generic.ICollection<LABPartyAddressHistory> _lABPartyAddressHistories;
        private System.Collections.Generic.ICollection<LABPartyHistory> _lABPartyHistories;
        private System.String _lABPartyId;
        private System.Collections.Generic.ICollection<LABPartySolicitorHistory> _lABPartySolicitorHistories;
        private System.Collections.Generic.ICollection<LABPartySolicitor> _lABPartySolicitors;
        private System.Collections.Generic.ICollection<LACInfo> _lACInfos;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MGender _mGender;
        private System.String _mobileCountryCode;
        private System.String _mobileNumber;
        private MPersonIDType _mPersonIDType;
        private System.String _telAreaCode;
        private System.String _telCountryCode;
        private System.String _telNumber;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="LABParty"/> class.</summary>
        public LABParty()
            : base()
        {
            _lABPartyAddresses = new System.Collections.Generic.HashSet<LABPartyAddress>();
            _lABPartyAddressHistories = new System.Collections.Generic.HashSet<LABPartyAddressHistory>();
            _lABPartyHistories = new System.Collections.Generic.HashSet<LABPartyHistory>();
            _lABPartySolicitors = new System.Collections.Generic.HashSet<LABPartySolicitor>();
            _lABPartySolicitorHistories = new System.Collections.Generic.HashSet<LABPartySolicitorHistory>();
            _lACInfos = new System.Collections.Generic.HashSet<LACInfo>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ContactTypeInd field. </summary>
        public virtual System.String ContactTypeInd
        {
            get { return _contactTypeInd; }
            set { _contactTypeInd = value; }
        }

        /// <summary>Gets or sets the Email field. </summary>
        public virtual System.String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>Gets or sets the FaxAreaCode field. </summary>
        public virtual System.String FaxAreaCode
        {
            get { return _faxAreaCode; }
            set { _faxAreaCode = value; }
        }

        /// <summary>Gets or sets the FaxCountryCode field. </summary>
        public virtual System.String FaxCountryCode
        {
            get { return _faxCountryCode; }
            set { _faxCountryCode = value; }
        }

        /// <summary>Gets or sets the FaxNumber field. </summary>
        public virtual System.String FaxNumber
        {
            get { return _faxNumber; }
            set { _faxNumber = value; }
        }

        /// <summary>Gets or sets the FullName field. </summary>
        public virtual System.String FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        /// <summary>Gets or sets the IdNumber field. </summary>
        public virtual System.String IdNumber
        {
            get { return _idNumber; }
            set { _idNumber = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LAP.LABPartyAddress.LABParty - LAP.LABParty.LABPartyAddresses (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LABPartyAddress> LABPartyAddresses
        {
            get { return _lABPartyAddresses; }
            set { _lABPartyAddresses = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LAP.LABPartyAddressHistory.LABParty - LAP.LABParty.LABPartyAddressHistories (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LABPartyAddressHistory> LABPartyAddressHistories
        {
            get { return _lABPartyAddressHistories; }
            set { _lABPartyAddressHistories = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LAP.LABPartyHistory.LABParty - LAP.LABParty.LABPartyHistories (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LABPartyHistory> LABPartyHistories
        {
            get { return _lABPartyHistories; }
            set { _lABPartyHistories = value; }
        }

        /// <summary>Gets or sets the LABPartyId field. </summary>
        public virtual System.String LABPartyId
        {
            get { return _lABPartyId; }
            set { _lABPartyId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LAP.LABPartySolicitorHistory.LABParty - LAP.LABParty.LABPartySolicitorHistories (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LABPartySolicitorHistory> LABPartySolicitorHistories
        {
            get { return _lABPartySolicitorHistories; }
            set { _lABPartySolicitorHistories = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LAP.LABPartySolicitor.LABParty - LAP.LABParty.LABPartySolicitors (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LABPartySolicitor> LABPartySolicitors
        {
            get { return _lABPartySolicitors; }
            set { _lABPartySolicitors = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LAP.LACInfo.LABParty - LAP.LABParty.LACInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LACInfo> LACInfos
        {
            get { return _lACInfos; }
            set { _lACInfos = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'LAP.LABParty.MGender - Master.MGender.LABParties (m:1)'</summary>
        public virtual MGender MGender
        {
            get { return _mGender; }
            set { _mGender = value; }
        }

        /// <summary>Gets or sets the MobileCountryCode field. </summary>
        public virtual System.String MobileCountryCode
        {
            get { return _mobileCountryCode; }
            set { _mobileCountryCode = value; }
        }

        /// <summary>Gets or sets the MobileNumber field. </summary>
        public virtual System.String MobileNumber
        {
            get { return _mobileNumber; }
            set { _mobileNumber = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LAP.LABParty.MPersonIDType - Master.MPersonIDType.LABParties (m:1)'</summary>
        public virtual MPersonIDType MPersonIDType
        {
            get { return _mPersonIDType; }
            set { _mPersonIDType = value; }
        }

        /// <summary>Gets or sets the TelAreaCode field. </summary>
        public virtual System.String TelAreaCode
        {
            get { return _telAreaCode; }
            set { _telAreaCode = value; }
        }

        /// <summary>Gets or sets the TelCountryCode field. </summary>
        public virtual System.String TelCountryCode
        {
            get { return _telCountryCode; }
            set { _telCountryCode = value; }
        }

        /// <summary>Gets or sets the TelNumber field. </summary>
        public virtual System.String TelNumber
        {
            get { return _telNumber; }
            set { _telNumber = value; }
        }

        public virtual System.String LFFileRefNumber { get; set; }

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
            LABParty toCompareWith = obj as LABParty;
            return toCompareWith == null ? false : ((this.LABPartyId == toCompareWith.LABPartyId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LABPartyId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}