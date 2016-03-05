#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMCaseTypeForum entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   30/01/2012   		      Nithin             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: RMCaseTypeForumEntity.cs
// Description: Represents a standard RMCaseTypeForum entity.
// </summary>
// <copyright file= "RMCaseTypeForumEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

   
    /// <summary>Class which represents the entity 'MRelationship.RMCaseTypeForumEntity'</summary>
    
    public class RMHearingRoutingSectionConfig:IMaster
    {
        #region Properties

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public virtual String RMHearingRoutingSectionConfigId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public virtual String ForumID
        {
            get;
            set;
        }

        public virtual String CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public virtual String SubCaseType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public virtual String NOCCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public virtual String LegislationActCode
        {
            get;
            set;
        }

        public virtual String HRGTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public virtual String SectionCode
        {
            get;
            set;
        }

        public virtual string ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedBy field.
        /// </summary>
        /// <value>The last modified by.</value>
        public virtual String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedDate field.
        /// </summary>
        /// <value>The last modified date.</value>
        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        public virtual String CaseTypeAdditionalAttrType
        {
            get;
            set;
        }

        public virtual String CaseTypeAdditionalAttrValue
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
            RMHearingRoutingSectionConfig toCompareWith = obj as RMHearingRoutingSectionConfig;
            return toCompareWith == null ? false : ((this.RMHearingRoutingSectionConfigId == toCompareWith.RMHearingRoutingSectionConfigId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RMHearingRoutingSectionConfigId.GetHashCode();
             return toReturn;
        }

        #endregion Methods
    }
}