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

    /// <summary>Class which represents the entity 'Common.DegreeInfo'</summary>
    public partial class DegreeInfo : ICommon
    {
        #region Fields

        private Nullable<System.DateTime> _admissionOn;
        private System.String _classOfDegree;
        private Nullable<System.DateTime> _confermentOfDegree;
        private System.String _courseLength;
        private System.String _degreeInfoId;
        private System.String _degreeType;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _lawDegreeRemarks;
        private MAASLawDegree _mAASLawDegree;
        private MAASUniversity _mAASUniversity;
        private MCountry _mCountry;
        private System.String _remarks;
        private System.String _submissionGroupId;
        private System.String _universityRemarks;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="DegreeInfo"/> class.</summary>
        public DegreeInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AdmissionOn field. </summary>
        public virtual Nullable<System.DateTime> AdmissionOn
        {
            get { return _admissionOn; }
            set { _admissionOn = value; }
        }

        /// <summary>Gets or sets the ClassOfDegree field. </summary>
        public virtual System.String ClassOfDegree
        {
            get { return _classOfDegree; }
            set { _classOfDegree = value; }
        }

        /// <summary>Gets or sets the ConfermentOfDegree field. </summary>
        public virtual Nullable<System.DateTime> ConfermentOfDegree
        {
            get { return _confermentOfDegree; }
            set { _confermentOfDegree = value; }
        }

        /// <summary>Gets or sets the CourseLength field. </summary>
        public virtual System.String CourseLength
        {
            get { return _courseLength; }
            set { _courseLength = value; }
        }

        /// <summary>Gets or sets the DegreeInfoId field. </summary>
        public virtual System.String DegreeInfoId
        {
            get { return _degreeInfoId; }
            set { _degreeInfoId = value; }
        }

        /// <summary>Gets or sets the DegreeType field. </summary>
        public virtual System.String DegreeType
        {
            get { return _degreeType; }
            set { _degreeType = value; }
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

        /// <summary>Gets or sets the LawDegreeRemarks field. </summary>
        public virtual System.String LawDegreeRemarks
        {
            get { return _lawDegreeRemarks; }
            set { _lawDegreeRemarks = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.DegreeInfo.MAASLawDegree - Master.MAASLawDegree.DegreeInfos (m:1)'</summary>
        public virtual MAASLawDegree MAASLawDegree
        {
            get { return _mAASLawDegree; }
            set { _mAASLawDegree = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.DegreeInfo.MAASUniversity - Master.MAASUniversity.DegreeInfos (m:1)'</summary>
        public virtual MAASUniversity MAASUniversity
        {
            get { return _mAASUniversity; }
            set { _mAASUniversity = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.DegreeInfo.MCountry - Master.MCountry.DegreeInfos (m:1)'</summary>
        public virtual MCountry MCountry
        {
            get { return _mCountry; }
            set { _mCountry = value; }
        }

        public virtual String OtherDegree
        {
            get;
            set;
        }

        public virtual String OtherUniversity
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public virtual System.String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
        }

        /// <summary>Gets or sets the UniversityRemarks field. </summary>
        public virtual System.String UniversityRemarks
        {
            get { return _universityRemarks; }
            set { _universityRemarks = value; }
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
            DegreeInfo toCompareWith = obj as DegreeInfo;
            return toCompareWith == null ? false : ((this.DegreeInfoId == toCompareWith.DegreeInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DegreeInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}