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

    /// <summary>Class which represents the entity 'Case.RLawFirmSolicitors'</summary>
    public partial class RLawFirmSolicitors : ICase
    {
        #region Fields

        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;

        //private LawFirm _lawFirm;
        private System.String _lFID;

        //private Solicitor _solicitor;
        private long _solicitorID;
        private System.DateTime _startDate;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="RLawFirmSolicitors"/> class.</summary>
        public RLawFirmSolicitors()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

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

        ///<summary>Represents the navigator which is mapped onto the association 'Case.RCaseLawFirm.LawFirm - LawFirm.LawFirm.RCaseLawFirms (m:1)'</summary>
        //public virtual LawFirm LawFirm
        //{
        //   get { return _lawFirm; }
        //   set { _lawFirm = value; }
        //}
        ///<summary>Gets or sets the LFID field. </summary>
        public virtual System.String LFID
        {
            get { return _lFID; }
            set { _lFID = value; }
        }

        //public virtual Solicitor Solicitor
        //{
        //    get { return _solicitor; }
        //    set { _solicitor = value; }
        //}
        ///<summary>Gets or sets the SolicitorID field. </summary>
        public virtual long SolicitorID
        {
            get { return _solicitorID; }
            set { _solicitorID = value; }
        }

        public virtual System.DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public virtual long? PCID { get; set; }

        public virtual MDesignation MDesignation { get; set; }

        public virtual string UserID { get; set; }
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
            RLawFirmSolicitors toCompareWith = obj as RLawFirmSolicitors;
            return toCompareWith == null ? false : ((this.LFID == toCompareWith.LFID) && (this.SolicitorID == toCompareWith.SolicitorID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LFID.GetHashCode();
            toReturn ^= this.SolicitorID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}