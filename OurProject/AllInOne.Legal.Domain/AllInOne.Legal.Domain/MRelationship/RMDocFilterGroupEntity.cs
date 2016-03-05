#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMDocFilterGroup entity.
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
// File: RMDocFilterGroupEntity.cs
// Description: Represents a standard RMDocFilterGroup entity.
// </summary>
// <copyright file= "RMDocFilterGroupEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.MRelationship
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for RMDocFilterGroup.
    /// </summary>
    [Serializable]
    public class RMDocFilterGroupEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the DocCode field. </summary>
        public string DocCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FilterGroupId field. </summary>
        public string FilterGroupId
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
    }
}