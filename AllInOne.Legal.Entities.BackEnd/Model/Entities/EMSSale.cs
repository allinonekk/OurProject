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

    /// <summary>Class which represents the entity 'Enforcement.EMSSale'</summary>
    public partial class EMSSale : IEnforcement
    {
        #region Fields

        private System.String _admSaleAddr1;
        private System.String _admSaleAddr2;
        private System.String _admSaleAddr3;
        private System.String _admSaleAddr4;
        private System.String _admSaleAddress;
        private System.String _admSaleBlkNo;
        private System.String _admSaleBuildingName;
        private System.String _admSaleFloorNo;
        private System.String _admSaleFormatInd;
        private System.String _admSalePostalCode;
        private System.String _admSaleStreetName;
        private System.String _admSaleUnitNo;
        private System.Decimal _amountSold;
        private Nullable<System.Decimal> _auctioneerCharges;
        private Nullable<System.DateTime> _auctioneerDateEngaged;
        private Nullable<System.DateTime> _belowValueOrderDate;
        private Nullable<System.DateTime> _cFASDate;
        private System.String _commissionRemarks;
        private System.String _conductedBy;
        private System.String _conductedByOthers;
        private System.String _debtSatisfied;
        private EMSAccount _eMSAccount;
        private EMSAdmCharge _eMSAdmCharge;
        private System.Collections.Generic.ICollection<EMSAdmClaim> _eMSAdmClaims;
        private EMSAdmProperty _eMSAdmProperty;
        private EMSAppointment _eMSAppointment;
        private System.Collections.Generic.ICollection<EMSSaleAdvert> _eMSSaleAdverts;
        private System.Collections.Generic.ICollection<EMSSaleAgent> _eMSSaleAgents;
        private System.Collections.Generic.ICollection<EMSSaleAppraiser> _eMSSaleAppraisers;
        private System.Collections.Generic.ICollection<EMSSaleBuyer> _eMSSaleBuyers;
        private System.String _eMSSaleId;
        private System.String _itemSold;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MEMSAuctioneer _mEMSAuctioneer;
        private System.String _obsInd;
        private System.String _otherAuctioneer;
        private System.String _remarks;
        private Nullable<System.DateTime> _saleDateTime;
        private Nullable<System.DateTime> _saleOrderDate;
        private System.String _saleType;
        private System.String _typeOfAuction;
        private System.String _othersaleDetails;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSSale"/> class.</summary>
        public EMSSale()
            : base()
        {
            _eMSSaleAdverts = new System.Collections.Generic.HashSet<EMSSaleAdvert>();
            _eMSSaleAppraisers = new System.Collections.Generic.HashSet<EMSSaleAppraiser>();
            _eMSSaleAgents = new System.Collections.Generic.HashSet<EMSSaleAgent>();
            _eMSSaleBuyers = new System.Collections.Generic.HashSet<EMSSaleBuyer>();
            _eMSAdmClaims = new System.Collections.Generic.HashSet<EMSAdmClaim>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the OthersaleDetails field. </summary>
        public virtual System.String OthersaleDetails
        {
            get { return _othersaleDetails; }
            set { _othersaleDetails = value; }
        }

        /// <summary>Gets or sets the AdmSaleAddr1 field. </summary>
        public virtual System.String AdmSaleAddr1
        {
            get { return _admSaleAddr1; }
            set { _admSaleAddr1 = value; }
        }

        /// <summary>Gets or sets the AdmSaleAddr2 field. </summary>
        public virtual System.String AdmSaleAddr2
        {
            get { return _admSaleAddr2; }
            set { _admSaleAddr2 = value; }
        }

        /// <summary>Gets or sets the AdmSaleAddr3 field. </summary>
        public virtual System.String AdmSaleAddr3
        {
            get { return _admSaleAddr3; }
            set { _admSaleAddr3 = value; }
        }

        /// <summary>Gets or sets the AdmSaleAddr4 field. </summary>
        public virtual System.String AdmSaleAddr4
        {
            get { return _admSaleAddr4; }
            set { _admSaleAddr4 = value; }
        }

        /// <summary>Gets or sets the AdmSaleAddress field. </summary>
        public virtual System.String AdmSaleAddress
        {
            get { return _admSaleAddress; }
            set { _admSaleAddress = value; }
        }

        /// <summary>Gets or sets the AdmSaleBlkNo field. </summary>
        public virtual System.String AdmSaleBlkNo
        {
            get { return _admSaleBlkNo; }
            set { _admSaleBlkNo = value; }
        }

        /// <summary>Gets or sets the AdmSaleBuildingName field. </summary>
        public virtual System.String AdmSaleBuildingName
        {
            get { return _admSaleBuildingName; }
            set { _admSaleBuildingName = value; }
        }

        /// <summary>Gets or sets the AdmSaleFloorNo field. </summary>
        public virtual System.String AdmSaleFloorNo
        {
            get { return _admSaleFloorNo; }
            set { _admSaleFloorNo = value; }
        }

        /// <summary>Gets or sets the AdmSaleFormatInd field. </summary>
        public virtual System.String AdmSaleFormatInd
        {
            get { return _admSaleFormatInd; }
            set { _admSaleFormatInd = value; }
        }

        /// <summary>Gets or sets the AdmSalePostalCode field. </summary>
        public virtual System.String AdmSalePostalCode
        {
            get { return _admSalePostalCode; }
            set { _admSalePostalCode = value; }
        }

        /// <summary>Gets or sets the AdmSaleStreetName field. </summary>
        public virtual System.String AdmSaleStreetName
        {
            get { return _admSaleStreetName; }
            set { _admSaleStreetName = value; }
        }

        /// <summary>Gets or sets the AdmSaleUnitNo field. </summary>
        public virtual System.String AdmSaleUnitNo
        {
            get { return _admSaleUnitNo; }
            set { _admSaleUnitNo = value; }
        }

        /// <summary>Gets or sets the AmountSold field. </summary>
        public virtual System.Decimal AmountSold
        {
            get { return _amountSold; }
            set { _amountSold = value; }
        }

        /// <summary>Gets or sets the AuctioneerCharges field. </summary>
        public virtual Nullable<System.Decimal> AuctioneerCharges
        {
            get { return _auctioneerCharges; }
            set { _auctioneerCharges = value; }
        }

        /// <summary>Gets or sets the AuctioneerDateEngaged field. </summary>
        public virtual Nullable<System.DateTime> AuctioneerDateEngaged
        {
            get { return _auctioneerDateEngaged; }
            set { _auctioneerDateEngaged = value; }
        }

        /// <summary>Gets or sets the BelowValueOrderDate field. </summary>
        public virtual Nullable<System.DateTime> BelowValueOrderDate
        {
            get { return _belowValueOrderDate; }
            set { _belowValueOrderDate = value; }
        }

        /// <summary>Gets or sets the CFASDate field. </summary>
        public virtual Nullable<System.DateTime> CFASDate
        {
            get { return _cFASDate; }
            set { _cFASDate = value; }
        }

        /// <summary>Gets or sets the CommissionRemarks field. </summary>
        public virtual System.String CommissionRemarks
        {
            get { return _commissionRemarks; }
            set { _commissionRemarks = value; }
        }

        /// <summary>Gets or sets the ConductedBy field. </summary>
        public virtual System.String ConductedBy
        {
            get { return _conductedBy; }
            set { _conductedBy = value; }
        }

        /// <summary>Gets or sets the ConductedByOthers field. </summary>
        public virtual System.String ConductedByOthers
        {
            get { return _conductedByOthers; }
            set { _conductedByOthers = value; }
        }

        /// <summary>Gets or sets the DebtSatisfied field. </summary>
        public virtual System.String DebtSatisfied
        {
            get { return _debtSatisfied; }
            set { _debtSatisfied = value; }
        }

        /// <summary>Gets or sets the EMSAccount field. </summary>
        public virtual EMSAccount EMSAccount
        {
            get { return _eMSAccount; }
            set { _eMSAccount = value; }
        }

        /// <summary>Gets or sets the EMSAdmCharge field. </summary>
        public virtual EMSAdmCharge EMSAdmCharge
        {
            get { return _eMSAdmCharge; }
            set { _eMSAdmCharge = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSAdmClaim.EMSSale - Enforcement.EMSSale.EMSAdmClaims (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSAdmClaim> EMSAdmClaims
        {
            get { return _eMSAdmClaims; }
            set { _eMSAdmClaims = value; }
        }

        /// <summary>Gets or sets the EMSAdmProperty field. </summary>
        public virtual EMSAdmProperty EMSAdmProperty
        {
            get { return _eMSAdmProperty; }
            set { _eMSAdmProperty = value; }
        }

        /// <summary>Gets or sets the EMSAppointment field. </summary>
        public virtual EMSAppointment EMSAppointment
        {
            get { return _eMSAppointment; }
            set { _eMSAppointment = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSSaleAdvert.EMSSale - Enforcement.EMSSale.EMSSaleAdverts (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSSaleAdvert> EMSSaleAdverts
        {
            get { return _eMSSaleAdverts; }
            set { _eMSSaleAdverts = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSSaleAgent.EMSSale - Enforcement.EMSSale.EMSSaleAgents (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSSaleAgent> EMSSaleAgents
        {
            get { return _eMSSaleAgents; }
            set { _eMSSaleAgents = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSSaleAppraiser.EMSSale - Enforcement.EMSSale.EMSSaleAppraiser (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSSaleAppraiser> EMSSaleAppraisers
        {
            get { return _eMSSaleAppraisers; }
            set { _eMSSaleAppraisers = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSSaleBuyer.EMSSale - Enforcement.EMSSale.EMSSaleBuyers (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSSaleBuyer> EMSSaleBuyers
        {
            get { return _eMSSaleBuyers; }
            set { _eMSSaleBuyers = value; }
        }

        /// <summary>Gets or sets the EMSSaleId field. </summary>
        public virtual System.String EMSSaleId
        {
            get { return _eMSSaleId; }
            set { _eMSSaleId = value; }
        }

        /// <summary>Gets or sets the ItemSold field. </summary>
        public virtual System.String ItemSold
        {
            get { return _itemSold; }
            set { _itemSold = value; }
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

        /// <summary>Gets or sets the MEMSAuctioneer field. </summary>
        public virtual MEMSAuctioneer MEMSAuctioneer
        {
            get { return _mEMSAuctioneer; }
            set { _mEMSAuctioneer = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the OtherAuctioneer field. </summary>
        public virtual System.String OtherAuctioneer
        {
            get { return _otherAuctioneer; }
            set { _otherAuctioneer = value; }
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public virtual System.String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        /// <summary>Gets or sets the SaleDateTime field. </summary>
        public virtual Nullable<System.DateTime> SaleDateTime
        {
            get { return _saleDateTime; }
            set { _saleDateTime = value; }
        }

        /// <summary>Gets or sets the SaleOrderDate field. </summary>
        public virtual Nullable<System.DateTime> SaleOrderDate
        {
            get { return _saleOrderDate; }
            set { _saleOrderDate = value; }
        }

        /// <summary>Gets or sets the SaleType field. </summary>
        public virtual System.String SaleType
        {
            get { return _saleType; }
            set { _saleType = value; }
        }

        /// <summary>Gets or sets the TypeOfAuction field. </summary>
        public virtual System.String TypeOfAuction
        {
            get { return _typeOfAuction; }
            set { _typeOfAuction = value; }
        }

        public virtual string SyncRequired
        {
            get;
            set;
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
            EMSSale toCompareWith = obj as EMSSale;
            return toCompareWith == null ? false : ((this.EMSSaleId == toCompareWith.EMSSaleId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSSaleId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}