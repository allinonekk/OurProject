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

    /// <summary>Class which represents the entity 'Common.LegalExperienceInfo'</summary>
    public partial class LegalExperienceInfo : ICommon
    {
        #region Fields

        private Nullable<System.DateTime> _employmentEndDate;
        private Nullable<System.DateTime> _employmentStartDate;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private LawFirm _lawFirm;
        private System.String _legalExperienceInfoId;
        private System.String _legalExperienceType;
        private System.String _submissionGroupId;
        private System.String _designation;
        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="LegalExperienceInfo"/> class.</summary>
        public LegalExperienceInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the EmploymentEndDate field. </summary>
        public virtual Nullable<System.DateTime> EmploymentEndDate
        {
            get { return _employmentEndDate; }
            set { _employmentEndDate = value; }
        }

        /// <summary>Gets or sets the EmploymentStartDate field. </summary>
        public virtual Nullable<System.DateTime> EmploymentStartDate
        {
            get { return _employmentStartDate; }
            set { _employmentStartDate = value; }
        }

        /// <summary>Gets or sets the ExperienceLength field. </summary>
        public virtual String ExperienceLength
        {
            get;
            set;
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

        /// <summary>Represents the navigator which is mapped onto the association 'Common.LegalExperienceInfo.LawFirm - LawFirm.LawFirm.LegalExperienceInfos (m:1)'</summary>
        public virtual string LFID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LegalExperienceInfoId field. </summary>
        public virtual System.String LegalExperienceInfoId
        {
            get { return _legalExperienceInfoId; }
            set { _legalExperienceInfoId = value; }
        }

        /// <summary>Gets or sets the LegalExperienceType field. </summary>
        public virtual System.String LegalExperienceType
        {
            get { return _legalExperienceType; }
            set { _legalExperienceType = value; }
        }

        public virtual String OrganisationName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
        }

        public virtual String TypeofOrganization
        {
            get;
            set;
        }
        
        public virtual String Designation
        {

            get { return _designation; }
            set { _designation = value; }
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
            LegalExperienceInfo toCompareWith = obj as LegalExperienceInfo;
            return toCompareWith == null ? false : ((this.LegalExperienceInfoId == toCompareWith.LegalExperienceInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LegalExperienceInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}