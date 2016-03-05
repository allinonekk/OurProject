#region Header

/*****************************************************************************************************
* Description : This file represents a standard interface for updating an entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   02/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: IUpdateRepository.cs
// Description: Represents a standard interface for updating an entity.
// </summary>
// <copyright file= "IUpdateRepository.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Repositories.BackEnd
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Provides a standard interface for updating an entity.
    /// </summary>
    /// <typeparam name="T">Type param</typeparam>
    public interface IUpdateRepository<T>
    {
        #region Methods

        /// <summary>
        /// Saves or updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void SaveOrUpdate(T entity);

        /// <summary>
        /// Saves or Updates the Specified Entity. If isCopy is true SaveOrUpdateCopy would be called,
        /// else just SaveOrUpdate.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdate(T entity, bool isCopy);

        /// <summary>
        /// Saves or Updates the specified entity list. If isCopy is true SaveOrUpdateCopy would be called,
        /// else just SaveOrUpdate.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdate(IList<T> entities, bool isCopy);

        /// <summary>
        /// Saves or updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void SaveOrUpdateCopy(T entity);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Update(T entity);

        #endregion Methods
    }
}