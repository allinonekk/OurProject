#region Header

/*****************************************************************************************************
* Description : This file represents a standard MUserGroup entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   26/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MUserGroupEntity.cs
// Description: Represents a standard MUserGroup entity.
// </summary>
// <copyright file= "MUserGroupEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MUserGroupEntity.
    /// </summary>
    [Serializable]
    public class MUserGroupEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the GroupCode field.
        /// </summary>
        /// <value>The group code.</value>
        public String GroupCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the GroupName field.
        /// </summary>
        /// <value>The name of the group.</value>
        public String GroupName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SignatureMandatory field.
        /// </summary>
        /// <value>The signature mandatory.</value>
        public String SignatureMandatory
        {
            get; set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            MUserGroupEntity toCompareWith = obj as MUserGroupEntity;
            return toCompareWith == null ? false : ((this.GroupCode == toCompareWith.GroupCode));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.GroupCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}