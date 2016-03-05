#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMNOAForumHrgType entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   06/04/2011   		      Nithin             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: RMNOAForumHrgTypeEntity.cs
// Description: Represents a standard RMNOAForumHrgType entity.
// </summary>
// <copyright file= "RMNOAForumHrgTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.RMNOAForumHrgTypeEntity'</summary>
    [Serializable]
    public class RMNOAForumHrgTypeEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the ForumID field. </summary>
        public String ForumID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGTypeCode field. </summary>
        public String HRGTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public String NOACode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the case type code.
        /// </summary>
        /// <value>The case type code.</value>
        public String CaseTypeCode
        {
            get;
            set;
        }

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
            RMNOAForumHrgTypeEntity toCompareWith = obj as RMNOAForumHrgTypeEntity;
            return toCompareWith == null ? false : ((this.NOACode == toCompareWith.NOACode) && (this.ForumID == toCompareWith.ForumID) && (this.HRGTypeCode==toCompareWith.HRGTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NOACode.GetHashCode();
            toReturn ^= this.ForumID.GetHashCode();
            toReturn ^= this.HRGTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}