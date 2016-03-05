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

    /// <summary>Class which represents the entity 'Common.DocCaseCounterClaim'</summary>
    public partial class DocCaseCounterClaim : ICommon
    {
        
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="DocCaseCounterClaim"/> class.</summary>
        public DocCaseCounterClaim()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the DocCaseCounterClaimID field. </summary>
        public virtual String DocCaseCounterClaimID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubmissionGroupID field. </summary>
        public virtual String SubmissionGroupID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DocID field. </summary>
        public virtual String DocID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseCounterClaimID field. </summary>
        public virtual System.String CaseCounterClaimID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseInfoID field. </summary>
        public virtual System.Int64 CaseInfoID
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

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UpdateInd field. </summary>
        public virtual System.String UpdateInd
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
            DocCaseCounterClaim toCompareWith = obj as DocCaseCounterClaim;
            return toCompareWith == null ? false : ((this.DocCaseCounterClaimID == toCompareWith.DocCaseCounterClaimID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocCaseCounterClaimID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}