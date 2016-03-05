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

namespace AllInOne.Legal.Domain.MRelationship
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'MRelationship.RMCaseTypeHRGTypeMSTypeEntity'</summary>
    [Serializable]
    public class RMCaseTypeForumHRGTypeMSTypeViewEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the NOACode field. </summary>
        public String CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseType field. </summary>
        public String CaseType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CourtId field. </summary>
        public String ForumId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Court field. </summary>
        public String Forum
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public String HRGTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGType field. </summary>
        public String HRGType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MSTypeDescription field. </summary>
        public String MSTypeDescription
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MSType field. </summary>
        public String MSType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MSTypeDesc field. </summary>
        public String MSTypeDesc
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
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
            RMCaseTypeForumHRGTypeMSTypeEntity toCompareWith = obj as RMCaseTypeForumHRGTypeMSTypeEntity;
            return toCompareWith == null ? false : ((this.CaseTypeCode == toCompareWith.CaseTypeCode)
                && (this.ForumId == toCompareWith.ForumId)
                && (this.HRGTypeCode == toCompareWith.HRGTypeCode)
                && (this.MSType == toCompareWith.MSType));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseTypeCode.GetHashCode();
            toReturn ^= this.ForumId.GetHashCode();
            toReturn ^= this.HRGTypeCode.GetHashCode();
            toReturn ^= this.MSType.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}