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

    /// <summary>Class which represents the entity 'Master.MAASLawDegree'</summary>
    public partial class MAASLawDegree : IMaster
    {
        #region Fields

        private System.String _aASLawDegreeCode;
        private System.Collections.Generic.ICollection<DegreeInfo> _degreeInfos;
        private System.String _description;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MAASLawDegree"/> class.</summary>
        public MAASLawDegree()
            : base()
        {
            _degreeInfos = new System.Collections.Generic.HashSet<DegreeInfo>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AASLawDegreeCode field. </summary>
        public virtual System.String AASLawDegreeCode
        {
            get { return _aASLawDegreeCode; }
            set { _aASLawDegreeCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.DegreeInfo.MAASLawDegree - Master.MAASLawDegree.DegreeInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DegreeInfo> DegreeInfos
        {
            get { return _degreeInfos; }
            set { _degreeInfos = value; }
        }

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

        public virtual string CountryCode
        {
            get;
            set;
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
            MAASLawDegree toCompareWith = obj as MAASLawDegree;
            return toCompareWith == null ? false : ((this.AASLawDegreeCode == toCompareWith.AASLawDegreeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AASLawDegreeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}