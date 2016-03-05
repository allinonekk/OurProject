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

    /// <summary>Class which represents the entity 'LAP.LABPartySolicitorHistory'</summary>
    public partial class LABPartySolicitorHistory : ILAP
    {
        #region Fields

        private System.String _lABPartySolicitorHistoryId;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;

        //private LawFirm _lawFirm;
        private System.String _lFID;
        private System.String _representedBy;

        //private Solicitor _solicitor;
        private Nullable<System.Int64> _solicitorId;
        private System.String _solicitorName;
        private System.String _uEN;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="LABPartySolicitorHistory"/> class.</summary>
        public LABPartySolicitorHistory()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the LABPartyHistoryId field. </summary>
        public virtual System.String LABPartyHistoryId
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'LAP.LABPartySolicitorHistory.LABParty - LAP.LABParty.LABPartySolicitorHistories (m:1)'</summary>
        //public virtual LABParty LABParty
        //{
        //    get { return _lABParty; }
        //    set { _lABParty = value; }
        //}
        public virtual System.String LABPartyId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LABPartySolicitorHistoryId field. </summary>
        public virtual System.String LABPartySolicitorHistoryId
        {
            get { return _lABPartySolicitorHistoryId; }
            set { _lABPartySolicitorHistoryId = value; }
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

        ///// <summary>Represents the navigator which is mapped onto the association 'LAP.LABPartySolicitorHistory.LawFirm - LawFirm.LawFirm.LABPartySolicitorHistories (m:1)'</summary>
        //public virtual LawFirm LawFirm
        //{
        //    get { return _lawFirm; }
        //    set { _lawFirm = value; }
        //}
        /// <summary>Gets or sets the LFID field. </summary>
        public virtual System.String LFID
        {
            get { return _lFID; }
            set { _lFID = value; }
        }

        /// <summary>Gets or sets the RepresentedBy field. </summary>
        public virtual System.String RepresentedBy
        {
            get { return _representedBy; }
            set { _representedBy = value; }
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'LAP.LABPartySolicitorHistory.Solicitor - Common.Solicitor.LABPartySolicitorHistories (m:1)'</summary>
        //public virtual Solicitor Solicitor
        //{
        //    get { return _solicitor; }
        //    set { _solicitor = value; }
        //}
        /// <summary>Gets or sets the SolicitorId field. </summary>
        public virtual Nullable<System.Int64> SolicitorId
        {
            get { return _solicitorId; }
            set { _solicitorId = value; }
        }

        /// <summary>Gets or sets the SolicitorName field. </summary>
        public virtual System.String SolicitorName
        {
            get { return _solicitorName; }
            set { _solicitorName = value; }
        }

        /// <summary>Gets or sets the UEN field. </summary>
        public virtual System.String UEN
        {
            get { return _uEN; }
            set { _uEN = value; }
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
            LABPartySolicitorHistory toCompareWith = obj as LABPartySolicitorHistory;
            return toCompareWith == null ? false : ((this.LABPartySolicitorHistoryId == toCompareWith.LABPartySolicitorHistoryId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LABPartySolicitorHistoryId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}