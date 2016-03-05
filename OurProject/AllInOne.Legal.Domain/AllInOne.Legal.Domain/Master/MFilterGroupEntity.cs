#region Header

/*****************************************************************************************************
* Description : This file represents a standard MFilterGroup entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/08/2010   		      Phani             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MFilterGroupEntity.cs
// Description: Represents a standard MFilterGroup entity.
// </summary>
// <copyright file= "MFilterGroupEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MFilterGroup.
    /// </summary>
    [Serializable]
    public class MFilterGroupEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MFilterGroupEntity"/> class.
        /// </summary>
        public MFilterGroupEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the FilterGroupID field.
        /// </summary>
        /// <value>The filter group id.</value>
        public string FilterGroupId
        {
            get;
            set;
        }

        #endregion Properties
    }
}