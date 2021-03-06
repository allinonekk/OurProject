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

    /// <summary>Class which represents the entity 'Master.MPartyAmendmentFieldConfig'</summary>
    public partial class MPartyAmendmentFieldConfig : IMaster
    {
        #region Fields

        private System.String _configId;
        private System.String _fieldName;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MPartySection _mPartySection;
        private System.String _obsInd;
        private System.String _tableName;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MPartyAmendmentFieldConfig"/> class.</summary>
        public MPartyAmendmentFieldConfig()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ConfigId field. </summary>
        public virtual System.String ConfigId
        {
            get { return _configId; }
            set { _configId = value; }
        }

        /// <summary>Gets or sets the FieldName field. </summary>
        public virtual System.String FieldName
        {
            get { return _fieldName; }
            set { _fieldName = value; }
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
        public virtual MPartySection MPartySection
        {
            get { return _mPartySection; }
            set { _mPartySection = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the TableName field. </summary>
        public virtual System.String TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
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
            MPartyAmendmentFieldConfig toCompareWith = obj as MPartyAmendmentFieldConfig;
            return toCompareWith == null ? false : ((this.ConfigId == toCompareWith.ConfigId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ConfigId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}