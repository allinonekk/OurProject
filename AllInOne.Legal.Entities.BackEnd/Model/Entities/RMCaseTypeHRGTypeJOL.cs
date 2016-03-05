#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMCaseTypeHRGTypeJOL entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   26/07/2012   		      Nithin             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: RMCaseTypeHRGTypeJOLEntity.cs
// Description: Represents a standard RMCaseTypeHRGTypeJOL entity.
// </summary>
// <copyright file= "RMCaseTypeHRGTypeJOLEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

    /// <summary>Class which represents the entity 'MRelationship.RMCaseTypeHRGTypeJOL'</summary>
    [Serializable]
    public class RMCaseTypeHRGTypeJOL :  IMaster
    {
        #region Properties

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public virtual string RMCaseTypeHRGTypeJOLId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public virtual string ForumId
        {
            get;
            set;
        }

        public virtual string CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public virtual string HRGTypeCode
        {
            get;
            set;
        }

        public virtual string ObsInd
        {
            get;
            set;
        }

        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        public virtual DateTime LastModifiedDate
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
            RMCaseTypeHRGTypeJOL toCompareWith = obj as RMCaseTypeHRGTypeJOL;
            return toCompareWith == null ? false : ((this.RMCaseTypeHRGTypeJOLId == toCompareWith.RMCaseTypeHRGTypeJOLId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RMCaseTypeHRGTypeJOLId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}