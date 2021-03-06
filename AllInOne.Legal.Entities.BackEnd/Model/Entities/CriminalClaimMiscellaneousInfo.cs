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

    /// <summary>Class which represents the entity 'BackEndSpecific.CriminalClaimMiscellaneousInfo'</summary>
    public partial class CriminalClaimMiscellaneousInfo : IBackEndSpecific
    {
        #region Fields

        private Nullable<System.Decimal> _amountClaimed;

        //private CriminalClaimInfo _criminalClaimInfo;
        private System.String _criminalClaimInfoId;
        private System.String _criminalClaimMiscellaneousInfoId;
        private System.String _description;
        private Nullable<System.Decimal> _gSTAmount;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="CriminalClaimMiscellaneousInfo"/> class.</summary>
        public CriminalClaimMiscellaneousInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AmountClaimed field. </summary>
        public virtual Nullable<System.Decimal> AmountClaimed
        {
            get { return _amountClaimed; }
            set { _amountClaimed = value; }
        }

        /*
        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.CriminalClaimMiscellaneousInfo.CriminalClaimInfo - BackEndSpecific.CriminalClaimInfo.CriminalClaimMiscellaneousInfos (m:1)'</summary>
        public virtual CriminalClaimInfo CriminalClaimInfo
        {
            get { return _criminalClaimInfo; }
            set { _criminalClaimInfo = value; }
        }*/
        /// <summary>Gets or sets the CriminalClaimInfoId field. </summary>
        public virtual System.String CriminalClaimInfoId
        {
            get { return _criminalClaimInfoId; }
            set { _criminalClaimInfoId = value; }
        }

        /// <summary>Gets or sets the CriminalClaimMiscellaneousInfoId field. </summary>
        public virtual System.String CriminalClaimMiscellaneousInfoId
        {
            get { return _criminalClaimMiscellaneousInfoId; }
            set { _criminalClaimMiscellaneousInfoId = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Gets or sets the GSTAmount field. </summary>
        public virtual Nullable<System.Decimal> GSTAmount
        {
            get { return _gSTAmount; }
            set { _gSTAmount = value; }
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
            CriminalClaimMiscellaneousInfo toCompareWith = obj as CriminalClaimMiscellaneousInfo;
            return toCompareWith == null ? false : ((this.CriminalClaimMiscellaneousInfoId == toCompareWith.CriminalClaimMiscellaneousInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CriminalClaimMiscellaneousInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}