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

    /// <summary>Class which represents the entity 'Common.CheckListComments'</summary>
    public partial class CheckListComments : ICommon
    {

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="CheckListSubmission"/> class.</summary>
        public CheckListComments()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the CheckListDocId field. </summary>
        public virtual string CSCID
        {
            get;
            set;
        }

       
        /// <summary>Gets or sets the CheckListSubmissionId field. </summary>
        public virtual string CheckListSubmissionId
        {
            get;
            set;
        }

        public virtual string Comment
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DocName field. </summary>
        public virtual string Status
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EFormInd field. </summary>
        public virtual string Type
        {
            get;
            set;
        }

       
        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

      
        /// <summary>Gets or sets the WFStatus field. </summary>
        public virtual string UserName
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
            CheckListComments toCompareWith = obj as CheckListComments;
            return toCompareWith == null ? false : ((this.CSCID == toCompareWith.CSCID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CSCID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}