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

    /// <summary>Class which represents the entity 'IBackEndSpecific.RPTNOCGroupNOC'</summary>
    public partial class RPTNOCGroupNOC : IBackEndSpecific
    {
        #region Properties
        /// <summary>
        /// Gets or sets the RPTNOC group NOC code.
        /// </summary>
        /// <value>The RPTNOC group NOC code.</value>
        public virtual string RPTNOCGroupNOCCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the noc group code.
        /// </summary>
        /// <value>The noc group code.</value>
        public virtual string NocGroupCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NOC code.
        /// </summary>
        /// <value>The NOC code.</value>
        public virtual string NOCCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the obsInd.
        /// </summary>
        /// <value>The obs ind.</value>
        public virtual string ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedDate.
        /// </summary>
        /// <value>The LastModifiedDate.</value>
        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        public virtual string ActCode
        {
            get;
            set;
        }

        public virtual string NocGroupName
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
            RPTNOCGroupNOC toCompareWith = obj as RPTNOCGroupNOC;
            return toCompareWith == null ? false : ((this.RPTNOCGroupNOCCode == toCompareWith.RPTNOCGroupNOCCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RPTNOCGroupNOCCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}