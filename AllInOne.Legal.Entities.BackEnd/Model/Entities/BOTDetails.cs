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

    /// <summary>Class which represents the entity 'CaseSpecific.BOTDetails'</summary>
    public partial class BOTDetails : ICaseSpecific
    {
        #region Properties

        /// <summary>Gets or sets the BOTRemarks field. </summary>
        public virtual String BOTRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public virtual Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BOTRemarks field. </summary>
        public virtual String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BOTRemarks field. </summary>
        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MBasisOfTaxationType field. </summary>
        public virtual MBasisOfTaxationType MBasisOfTaxationType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BOTRemarks field. </summary>
        public virtual String SubmissionGroupId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TaxationBOTDetailId field. </summary>
        public virtual String TaxationBOTDetailId
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
            BOTDetails toCompareWith = obj as BOTDetails;
            return toCompareWith == null ? false : ((this.TaxationBOTDetailId == toCompareWith.TaxationBOTDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.TaxationBOTDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}