﻿#region Header

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

namespace AllInOne.Legal.Domain.MRelationship
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'MRelationship.RMCaseTypeForumEntity'</summary>
    [Serializable]
    public class RMHearingRoutingSectionConfigEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public String RMHearingRoutingSectionConfigId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public String ForumID
        {
            get;
            set;
        }

        public string CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public string SubCaseType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public String NOCCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public String LegislationActCode
        {
            get;
            set;
        }

        public string HRGTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public string SectionCode
        {
            get;
            set;
        }

        public YesNo ObsInd
        {
            get;
            set;
        }

        public string CaseTypeAdditionalAttrType
        {
            get;
            set;
        }

        public string CaseTypeAdditionalAttrValue
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
            RMHearingRoutingSectionConfigEntity toCompareWith = obj as RMHearingRoutingSectionConfigEntity;
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