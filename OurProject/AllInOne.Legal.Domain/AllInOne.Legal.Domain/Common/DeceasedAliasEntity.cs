#region Header

/*****************************************************************************************************
 * Description : This file represents a standard DeceasedAlias entity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			        Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010               Japheth             	Created
 *****************************************************************************************************/
// <summary>
// File: DeceasedAliasEntity.cs
// Description: Represents a standard DeceasedAlias entity.
// </summary>
// <copyright file= "DeceasedAliasEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;

    /// <summary>
    /// Represents a standard domain entity for DeceasedAlias.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class DeceasedAliasEntity : AbstractSubmissionGroup
    {
        #region Properties

        /// <summary>
        /// Gets or sets the alias property details.
        /// </summary>
        /// <value>The alias property details.</value>
        public String AliasPropertyDetails
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the deceased alias id.
        /// </summary>
        /// <value>The deceased alias id.</value>
        public String DeceasedAliasId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the decsd alias.
        /// </summary>
        /// <value>The name of the decsd alias.</value>
        public String DecsdAliasName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public int ItemNo
        {
            get; set;
        }

        #endregion Properties
    }
}