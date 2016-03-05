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

    /// <summary>Class which represents the entity 'Master.MPartySection'</summary>
    public partial class MPartySection : IMaster
    {
        #region Fields

        private System.String _description;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.Collections.Generic.ICollection<MPartyAmendmentFieldConfig> _mPartyAmendmentFieldConfigs;
        private System.String _obsInd;
        private System.String _partySectionId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MPartySection"/> class.</summary>
        public MPartySection()
            : base()
        {
            _mPartyAmendmentFieldConfigs = new System.Collections.Generic.HashSet<MPartyAmendmentFieldConfig>();
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

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MPartyAmendmentFieldConfig.MPartySection - Master.MPartySection.MPartyAmendmentFieldConfigs (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<MPartyAmendmentFieldConfig> MPartyAmendmentFieldConfigs
        {
            get { return _mPartyAmendmentFieldConfigs; }
            set { _mPartyAmendmentFieldConfigs = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the PartySectionId field. </summary>
        public virtual System.String PartySectionId
        {
            get { return _partySectionId; }
            set { _partySectionId = value; }
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
            MPartySection toCompareWith = obj as MPartySection;
            return toCompareWith == null ? false : ((this.PartySectionId == toCompareWith.PartySectionId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PartySectionId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}