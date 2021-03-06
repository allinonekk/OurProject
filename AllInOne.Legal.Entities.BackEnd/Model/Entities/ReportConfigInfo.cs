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

    /// <summary>Class which represents the entity 'BackEndSpecific.ReportConfigInfo'</summary>
    public partial class ReportConfigInfo : IBackEndSpecific
    {
        #region Fields

        private System.String _businessRule;
        private Nullable<System.Int32> _dayInTheMonth;
        private System.String _dayInTheWeek;
        private System.String _isNoEndDate;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MSection _mSection;
        private System.String _obsInd;
        private System.String _reportConfigInfoId;
        private System.Collections.Generic.ICollection<ReportConfigUser> _reportConfigUsers;
        private System.String _reportDescription;
        private System.String _reportTitle;
        private System.String _reportType;
        private Nullable<System.DateTime> _schedularEndDate;
        private System.String _schedulerInfo;
        private System.DateTime _schedulerStartDate;
        private System.String _uRL;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ReportConfigInfo"/> class.</summary>
        public ReportConfigInfo()
            : base()
        {
            _reportConfigUsers = new System.Collections.Generic.HashSet<ReportConfigUser>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the BusinessRule field. </summary>
        public virtual System.String BusinessRule
        {
            get { return _businessRule; }
            set { _businessRule = value; }
        }

        /// <summary>Gets or sets the DayInTheMonth field. </summary>
        public virtual Nullable<System.Int32> DayInTheMonth
        {
            get { return _dayInTheMonth; }
            set { _dayInTheMonth = value; }
        }

        /// <summary>Gets or sets the DayInTheWeek field. </summary>
        public virtual System.String DayInTheWeek
        {
            get { return _dayInTheWeek; }
            set { _dayInTheWeek = value; }
        }

        /// <summary>Gets or sets the IsNoEndDate field. </summary>
        public virtual System.String IsNoEndDate
        {
            get { return _isNoEndDate; }
            set { _isNoEndDate = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.ReportConfigInfo.MSection - Master.MSection.ReportConfigInfos (m:1)'</summary>
        public virtual MSection MSection
        {
            get { return _mSection; }
            set { _mSection = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the ReportConfigInfoId field. </summary>
        public virtual System.String ReportConfigInfoId
        {
            get { return _reportConfigInfoId; }
            set { _reportConfigInfoId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.ReportConfigUser.ReportConfigInfo - BackEndSpecific.ReportConfigInfo.ReportConfigUsers (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<ReportConfigUser> ReportConfigUsers
        {
            get { return _reportConfigUsers; }
            set { _reportConfigUsers = value; }
        }

        /// <summary>Gets or sets the ReportDescription field. </summary>
        public virtual System.String ReportDescription
        {
            get { return _reportDescription; }
            set { _reportDescription = value; }
        }

        /// <summary>Gets or sets the ReportTitle field. </summary>
        public virtual System.String ReportTitle
        {
            get { return _reportTitle; }
            set { _reportTitle = value; }
        }

        /// <summary>Gets or sets the ReportType field. </summary>
        public virtual System.String ReportType
        {
            get { return _reportType; }
            set { _reportType = value; }
        }

        /// <summary>Gets or sets the SchedularEndDate field. </summary>
        public virtual Nullable<System.DateTime> SchedularEndDate
        {
            get { return _schedularEndDate; }
            set { _schedularEndDate = value; }
        }

        /// <summary>Gets or sets the SchedulerInfo field. </summary>
        public virtual System.String SchedulerInfo
        {
            get { return _schedulerInfo; }
            set { _schedulerInfo = value; }
        }

        /// <summary>Gets or sets the SchedulerStartDate field. </summary>
        public virtual System.DateTime SchedulerStartDate
        {
            get { return _schedulerStartDate; }
            set { _schedulerStartDate = value; }
        }

        /// <summary>Gets or sets the URL field. </summary>
        public virtual System.String URL
        {
            get { return _uRL; }
            set { _uRL = value; }
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
            ReportConfigInfo toCompareWith = obj as ReportConfigInfo;
            return toCompareWith == null ? false : ((this.ReportConfigInfoId == toCompareWith.ReportConfigInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ReportConfigInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}