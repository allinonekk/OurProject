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

    /// <summary>Class which represents the entity 'Master.MPrayerOutcome'</summary>
    public partial class MPrayerOutcome : IMaster
    {
        #region Fields

        private System.String _description;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.Collections.Generic.ICollection<Prayer> _prayers;
        private System.String _prayerStatusCode;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MPrayerOutcome"/> class.</summary>
        public MPrayerOutcome()
            : base()
        {
            _prayers = new System.Collections.Generic.HashSet<Prayer>();
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

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.Prayer.MPrayerOutcome - Master.MPrayerOutcome.Prayers (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<Prayer> Prayers
        {
            get { return _prayers; }
            set { _prayers = value; }
        }

        /// <summary>Gets or sets the PrayerStatusCode field. </summary>
        public virtual System.String PrayerStatusCode
        {
            get { return _prayerStatusCode; }
            set { _prayerStatusCode = value; }
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
            MPrayerOutcome toCompareWith = obj as MPrayerOutcome;
            return toCompareWith == null ? false : ((this.PrayerStatusCode == toCompareWith.PrayerStatusCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PrayerStatusCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}