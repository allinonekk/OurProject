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

    /// <summary>Class which represents the entity 'Master.MEMSDisburseRate'</summary>
    public partial class MEMSDisburseRate : IMaster
    {
        #region Fields

        private System.String _dayOfWeek;
        private System.String _description;
        private System.String _eMSDisburseRateCode;
        private System.String _eMSType;
        private System.String _endTime;
        private Nullable<System.Int32> _frequencyInd;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private Nullable<System.Decimal> _rate;
        private System.String _startTime;
        private System.String _appCode;
        private System.String _courtId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MEMSDisburseRate"/> class.</summary>
        public MEMSDisburseRate()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the DayOfWeek field. </summary>
        public virtual System.String DayOfWeek
        {
            get { return _dayOfWeek; }
            set { _dayOfWeek = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Gets or sets the EMSDisburseRateCode field. </summary>
        public virtual System.String EMSDisburseRateCode
        {
            get { return _eMSDisburseRateCode; }
            set { _eMSDisburseRateCode = value; }
        }

        /// <summary>Gets or sets the EMSType field. </summary>
        public virtual System.String EMSType
        {
            get { return _eMSType; }
            set { _eMSType = value; }
        }

        /// <summary>Gets or sets the EndTime field. </summary>
        public virtual System.String EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        /// <summary>Gets or sets the FrequencyInd field. </summary>
        public virtual Nullable<System.Int32> FrequencyInd
        {
            get { return _frequencyInd; }
            set { _frequencyInd = value; }
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

        /// <summary>Gets or sets the Rate field. </summary>
        public virtual Nullable<System.Decimal> Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        /// <summary>Gets or sets the StartTime field. </summary>
        public virtual System.String StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MSection.MCourtType - Master.MCourtType.MSections (m:1)'</summary>
        public virtual System.String CourtId
        {
            get { return _courtId; }
            set { _courtId = value; }
        }

        /// <summary>Gets or sets the AppCode field. </summary>
        public virtual System.String AppCode
        {
            get { return _appCode; }
            set { _appCode = value; }
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
            MEMSDisburseRate toCompareWith = obj as MEMSDisburseRate;
            return toCompareWith == null ? false : ((this.EMSDisburseRateCode == toCompareWith.EMSDisburseRateCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSDisburseRateCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}