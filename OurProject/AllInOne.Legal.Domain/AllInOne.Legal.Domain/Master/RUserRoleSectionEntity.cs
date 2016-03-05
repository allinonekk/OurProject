#region Header

/*****************************************************************************************************
* Description : This file represents a standard RUserRoleSection entity.
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
// File: RUserRoleSectionEntity.cs
// Description: Represents a standard RUserRoleSection entity.
// </summary>
// <copyright file= "RUserRoleSectionEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.RMAASSectionExternalAgencyEntity'</summary>
    [Serializable]
    public class RUserRoleSectionEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AssignedDate field.
        /// </summary>
        /// <value>The AssignedDate</value>
        public DateTime? AssignedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AssignTaskInd field.
        /// </summary>
        /// <value>The AssignTaskInd</value>
        public String AssignTaskInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the EndDate field.
        /// </summary>
        /// <value>The EndDate</value>
        public DateTime? EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PreferredSection field.
        /// </summary>
        /// <value>The PreferredSection</value>
        public String PreferredSection
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RoleCode field.
        /// </summary>
        /// <value>The RoleCode</value>
        public String RoleCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SectionCode field.
        /// </summary>
        /// <value>The SectionCode</value>
        public String SectionCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SeqNo field.
        /// </summary>
        /// <value>The SeqNo</value>
        public Int32 SeqNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the StartDate field.
        /// </summary>
        /// <value>The StartDate</value>
        public DateTime? StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UserId field.
        /// </summary>
        /// <value>The UserId</value>
        public String UserId
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

            RUserRoleSectionEntity toCompareWith = obj as RUserRoleSectionEntity;
            return toCompareWith == null ? false : ((this.SectionCode == toCompareWith.SectionCode) && (this.UserId == toCompareWith.UserId) && (this.RoleCode == toCompareWith.RoleCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SectionCode.GetHashCode();
            toReturn ^= this.UserId.GetHashCode();
            toReturn ^= this.RoleCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}