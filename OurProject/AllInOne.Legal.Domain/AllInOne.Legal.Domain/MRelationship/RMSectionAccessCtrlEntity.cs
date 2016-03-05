#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMSectionAccessCtrl entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   11/01/2012   		      Nithin             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: RMSectionAccessCtrlEntity.cs
// Description: Represents a standard RMSectionAccessCtrl entity.
// </summary>
// <copyright file= "RMSectionAccessCtrlEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.MRelationship
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'MRelationship.RMSectionAccessCtrlEntity'</summary>
    [Serializable]
    public class RMSectionAccessCtrlEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public String CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public String ForumID
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

        /// <summary>Gets or sets the NOACode field. </summary>
        public String SectionCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public String SubCaseTypeCode
        {
            get;
            set;
        }

        public string RMSectionAccessCtrlId
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
            RMSectionAccessCtrlEntity toCompareWith = obj as RMSectionAccessCtrlEntity;
            return toCompareWith == null ? false : ((this.RMSectionAccessCtrlId == toCompareWith.RMSectionAccessCtrlId));

        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RMSectionAccessCtrlId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}