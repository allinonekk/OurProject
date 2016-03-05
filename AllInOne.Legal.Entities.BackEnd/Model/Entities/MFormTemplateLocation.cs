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

    /// <summary>Class which represents the entity 'Master.MFormTemplateLocation'</summary>
    public partial class MFormTemplateLocation : IMaster
    {
        #region Properties

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual String DeploymentStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual String DocCategoryCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LimitationCode field. </summary>
        public virtual System.String DocCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String FormLocation
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual String FormTemplateID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual String FormVersion
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual String FormXMLLocation
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual DateTime LastModifiedDate
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

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String SiteURL
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
            MFormTemplateLocation toCompareWith = obj as MFormTemplateLocation;
            return toCompareWith == null ? false : ((this.FormTemplateID == toCompareWith.FormTemplateID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FormTemplateID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}