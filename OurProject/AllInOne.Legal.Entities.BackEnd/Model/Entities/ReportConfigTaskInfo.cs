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

    /// <summary>Class which represents the entity 'BackEndSpecific.ReportConfigTaskInfo'</summary>
    public partial class ReportConfigTaskInfo : IBackEndSpecific
    {
        #region Properties

        /// <summary>Gets or sets the AASInfoId field. </summary>
        public virtual System.String ReportConfigTaskInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AASQualificationRemarks field. </summary>
        public virtual System.String ReportConfigInfoId
        {
            get;
            set;
        }


        /// <summary>Gets or sets the IsMLawExemptionApproved field. </summary>
        public virtual System.String Status
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get;
            set;
        }

        public virtual string GroupId
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
            ReportConfigTaskInfo toCompareWith = obj as ReportConfigTaskInfo;
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