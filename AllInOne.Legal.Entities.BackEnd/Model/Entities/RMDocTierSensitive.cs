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

    /// <summary>Class which represents the entity 'Master.RMDocTierSensitive'</summary>
    public partial class RMDocTierSensitive:IMaster
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="RMDocTierSensitive"/> class.</summary>
        public RMDocTierSensitive()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public virtual string RDocTierSensitiveID { get; set; }
        public virtual string ForumID { get; set; }
        public virtual MDocCode MDocCode { get; set; }
        public virtual MCaseType CaseTypeCode { get; set; }
        public virtual string LastModifiedBy { get; set; }
        public virtual System.DateTime LastModifiedDate { get; set; }
        public virtual string ObsInd { get; set; }

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
            RMDocTierSensitive toCompareWith = obj as RMDocTierSensitive;
            return toCompareWith == null ? false : ((this.RDocTierSensitiveID == toCompareWith.RDocTierSensitiveID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RDocTierSensitiveID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}