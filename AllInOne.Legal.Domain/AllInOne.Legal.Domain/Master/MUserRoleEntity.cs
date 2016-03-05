#region Header

/*****************************************************************************************************
* Description : This file represents a standard MUserRole entity.
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
// File: MUserRoleEntity.cs
// Description: Represents a standard MUserRole entity.
// </summary>
// <copyright file= "MUserRoleEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MUserRoleEntity.
    /// </summary>
    [Serializable]
    public class MUserRoleEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MUserRole"/> class.
        /// </summary>
        public MUserRoleEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the EndDate field.
        /// </summary>
        /// <value>The end date.</value>
        public DateTime? EndDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the RoleCode field.
        /// </summary>
        /// <value>The role code.</value>
        public String RoleCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the RoleDescription field.
        /// </summary>
        /// <value>The role description.</value>
        public String RoleDescription
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the RoleName field.
        /// </summary>
        /// <value>The name of the role.</value>
        public String RoleName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the StartDate field.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime? StartDate
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
            MUserRoleEntity toCompareWith = obj as MUserRoleEntity;
            return toCompareWith == null ? false : ((this.RoleCode == toCompareWith.RoleCode));
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
            toReturn ^= this.RoleCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}