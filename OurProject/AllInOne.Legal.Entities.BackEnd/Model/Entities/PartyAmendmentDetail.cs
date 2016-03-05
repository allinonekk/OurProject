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

    /// <summary>Class which represents the entity 'Case.PartyAmendmentDetail'</summary>
    public partial class PartyAmendmentDetail : ISubsequent
    {
        #region Fields

        private System.String _amendmentId;
        private System.Int32 _itemNo;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MPartyAmendmentConfig _mPartyAmendmentConfig;
        private PartyAmendment _partyAmendment;
        private System.String _previousInfo;
        private System.String _updatedBy;
        private System.String _updatedInfo;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="PartyAmendmentDetail"/> class.</summary>
        public PartyAmendmentDetail()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AmendmentId field. </summary>
        public virtual System.String AmendmentId
        {
            get { return _amendmentId; }
            set { _amendmentId = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'Case.PartyAmendmentDetail.MPartyAmendmentConfig - Master.MPartyAmendmentConfig.PartyAmendmentDetails (m:1)'</summary>
        public virtual MPartyAmendmentConfig MPartyAmendmentConfig
        {
            get { return _mPartyAmendmentConfig; }
            set { _mPartyAmendmentConfig = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.PartyAmendmentDetail.PartyAmendment - Case.PartyAmendment.PartyAmendmentDetails (m:1)'</summary>
        public virtual PartyAmendment PartyAmendment
        {
            get { return _partyAmendment; }
            set { _partyAmendment = value; }
        }

        /// <summary>Gets or sets the PreviousInfo field. </summary>
        public virtual System.String PreviousInfo
        {
            get { return _previousInfo; }
            set { _previousInfo = value; }
        }

        /// <summary>Gets or sets the UpdatedBy field. </summary>
        public virtual System.String UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }

        /// <summary>Gets or sets the UpdatedInfo field. </summary>
        public virtual System.String UpdatedInfo
        {
            get { return _updatedInfo; }
            set { _updatedInfo = value; }
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
            PartyAmendmentDetail toCompareWith = obj as PartyAmendmentDetail;
            return toCompareWith == null ? false : ((this.AmendmentId == toCompareWith.AmendmentId) && (this.ItemNo == toCompareWith.ItemNo));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AmendmentId.GetHashCode();
            toReturn ^= this.ItemNo.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}