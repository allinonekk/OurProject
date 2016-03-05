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

    /// <summary>Class which represents the entity 'Common.InfantOriginalName'</summary>
    public partial class InfantOriginalName
    {
        #region Fields

        private System.String _documentName;
        private System.String _idNumber;
        private InfantInfo _infantInfo;
        private System.String _infantOriginalNameId;
        private System.Int32 _itemNo;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.String _otherName;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="InfantOriginalName"/> class.</summary>
        public InfantOriginalName()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the DocumentName field. </summary>
        public virtual System.String DocumentName
        {
            get { return _documentName; }
            set { _documentName = value; }
        }

        /// <summary>Gets or sets the IdNumber field. </summary>
        public virtual System.String IdNumber
        {
            get { return _idNumber; }
            set { _idNumber = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.InfantOriginalName.InfantInfo - Common.InfantInfo.InfantOriginalNames (m:1)'</summary>
        public virtual InfantInfo InfantInfo
        {
            get { return _infantInfo; }
            set { _infantInfo = value; }
        }

        /// <summary>Gets or sets the InfantOriginalNameId field. </summary>
        public virtual System.String InfantOriginalNameId
        {
            get { return _infantOriginalNameId; }
            set { _infantOriginalNameId = value; }
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

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the OtherName field. </summary>
        public virtual System.String OtherName
        {
            get { return _otherName; }
            set { _otherName = value; }
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
            InfantOriginalName toCompareWith = obj as InfantOriginalName;
            return toCompareWith == null ? false : ((this.InfantOriginalNameId == toCompareWith.InfantOriginalNameId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.InfantOriginalNameId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}