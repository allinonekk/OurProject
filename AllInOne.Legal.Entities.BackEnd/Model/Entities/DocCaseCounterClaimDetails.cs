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

    /// <summary>Class which represents the entity 'Common.DocCaseCounterClaimDetails'</summary>
    public partial class DocCaseCounterClaimDetails : ICommon
    {
        
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="CaseCounterClaim"/> class.</summary>
        public DocCaseCounterClaimDetails()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the DocCaseCounterClaimDetailID field. </summary>
        public virtual String DocCaseCounterClaimDetailID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DocCaseCounterClaimID field. </summary>
        public virtual String DocCaseCounterClaimID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DCPID field. </summary>
        public virtual String DCPID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CasePartyID field. </summary>
        public virtual String CasePartyID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CounterClaimOrdinalNumber field. </summary>
        public virtual System.Int64 CounterClaimOrdinalNumber
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CounterClaimPartyTypeCode field. </summary>
        public virtual String CounterClaimPartyTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CounterClaimPartyNo field. </summary>
        public virtual String CounterClaimPartyNo
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
            DocCaseCounterClaimDetails toCompareWith = obj as DocCaseCounterClaimDetails;
            return toCompareWith == null ? false : ((this.DocCaseCounterClaimDetailID == toCompareWith.DocCaseCounterClaimDetailID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocCaseCounterClaimDetailID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}