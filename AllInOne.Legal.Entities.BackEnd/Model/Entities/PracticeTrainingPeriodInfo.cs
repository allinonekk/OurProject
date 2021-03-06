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

    /// <summary>Class which represents the entity 'CaseSpecific.PracticeTrainingPeriodInfo'</summary>
    public partial class PracticeTrainingPeriodInfo : ICaseSpecific
    {
        #region Fields

        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private LawFirm _lawFirm;
        private System.String _nameOfPupilMaster;
        private System.String _otherLawPractice;
        private System.String _practiceTrainingPeriodInfoId;
        private Nullable<System.DateTime> _pupillageFromDate;
        private Nullable<System.DateTime> _pupillageToDate;
        private System.String _submissionGroupId;
        private Nullable<System.Int64> _caseInfoId;
        private Nullable<System.Int64> _solicitorId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="PracticeTrainingPeriodInfo"/> class.</summary>
        public PracticeTrainingPeriodInfo()
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

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.PracticeTrainingPeriodInfo.LawFirm - LawFirm.LawFirm.PracticeTrainingPeriodInfos (m:1)'</summary>
        public virtual LawFirm LawFirm
        {
            get { return _lawFirm; }
            set { _lawFirm = value; }
        }

        /// <summary>Gets or sets the NameOfPupilMaster field. </summary>
        public virtual System.String NameOfPupilMaster
        {
            get { return _nameOfPupilMaster; }
            set { _nameOfPupilMaster = value; }
        }

        /// <summary>Gets or sets the OtherLawPractice field. </summary>
        public virtual System.String OtherLawPractice
        {
            get { return _otherLawPractice; }
            set { _otherLawPractice = value; }
        }

        /// <summary>Gets or sets the PracticeTrainingPeriodInfoId field. </summary>
        public virtual System.String PracticeTrainingPeriodInfoId
        {
            get { return _practiceTrainingPeriodInfoId; }
            set { _practiceTrainingPeriodInfoId = value; }
        }

        /// <summary>Gets or sets the PupillageFromDate field. </summary>
        public virtual Nullable<System.DateTime> PupillageFromDate
        {
            get { return _pupillageFromDate; }
            set { _pupillageFromDate = value; }
        }

        /// <summary>Gets or sets the PupillageToDate field. </summary>
        public virtual Nullable<System.DateTime> PupillageToDate
        {
            get { return _pupillageToDate; }
            set { _pupillageToDate = value; }
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
        }

        /// <summary>
        /// Gets or sets the case information identifier.
        /// </summary>
        /// <value>
        /// The case information identifier.
        /// </value>
        public virtual Nullable<System.Int64> CaseInfoId
        {
            get { return _caseInfoId; }
            set { _caseInfoId = value; }
        }

        /// <summary>
        /// Gets or sets the solicitor identifier.
        /// </summary>
        /// <value>
        /// The solicitor identifier.
        /// </value>
        public virtual Nullable<System.Int64> SolicitorId
        {
            get { return _solicitorId; }
            set { _solicitorId = value; }
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
            PracticeTrainingPeriodInfo toCompareWith = obj as PracticeTrainingPeriodInfo;
            return toCompareWith == null ? false : ((this.PracticeTrainingPeriodInfoId == toCompareWith.PracticeTrainingPeriodInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PracticeTrainingPeriodInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}