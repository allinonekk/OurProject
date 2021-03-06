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

    /// <summary>Class which represents the entity 'Case.JMOtherInfo'</summary>
    public partial class JMOtherInfo : ICaseSpecific
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="RCaseLinked"/> class.</summary>
        public JMOtherInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the JMOtherInfoId field. </summary>
        public virtual System.String JMOtherInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the caseinfoid field. </summary>
        public virtual Int64 caseinfoid
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsPCRCompliedWith field. </summary>
        public virtual System.String IsPCRCompliedWith
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AnyOtherInfoRem field. </summary>
        public virtual System.String AnyOtherInfoRem
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsInfoSent field. </summary>
        public virtual System.String IsInfoSent
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

        /// <summary>Gets or sets the LastModifiedby field. </summary>
        public virtual System.String LastModifiedby
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifieddate field. </summary>
        public virtual DateTime LastModifieddate
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
            JMOtherInfo toCompareWith = obj as JMOtherInfo;
            return toCompareWith == null ? false : (this.JMOtherInfoId == toCompareWith.JMOtherInfoId);
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.JMOtherInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}