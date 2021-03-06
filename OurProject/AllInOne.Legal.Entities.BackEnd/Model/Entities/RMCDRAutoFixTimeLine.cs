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

    /// <summary>Class which represents the entity 'Master.RMCaseTypeNOA'</summary>
    public partial class RMCDRAutoFixTimeLine
    {
        #region Properties

        public virtual MCaseType CaseTypeCode
        {
            get;
            set;
        }

        public virtual MDocCode DocCode
        {
            get;
            set;
        }

        public virtual String LastModifiedBy
        {
            get;
            set;
        }

        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        public virtual MNOC NOCCode
        {
            get;
            set;
        }

        public virtual String ObsInd
        {
            get;
            set;
        }

        public virtual String QuantumType
        {
            get;
            set;
        }

        public virtual Decimal? QuantumValue
        {
            get;
            set;
        }

        public virtual Int32 TimeLineDays
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
            if (obj == null)
            {
                return false;
            }
            RMCDRAutoFixTimeLine toCompareWith = obj as RMCDRAutoFixTimeLine;
            return toCompareWith == null ? false : ((this.CaseTypeCode == toCompareWith.CaseTypeCode) && (this.DocCode == toCompareWith.DocCode) && (this.NOCCode == toCompareWith.NOCCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseTypeCode.GetHashCode();
            toReturn ^= this.DocCode.GetHashCode();
            toReturn ^= this.NOCCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}