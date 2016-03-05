#region Header

/*****************************************************************************************************
* Description : This file represents a standard interface for reading an entity or list of entities.
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
// File: IReadRepository.cs
// Description: Represents a standard interface for reading an entity or list of entities.
// </summary>
// <copyright file= "IReadRepository.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Repositories.BackEnd
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using AllInOne.Common.DataAccess.Utilities;

    using NHibernate.Criterion;

    /// <summary>
    /// Provides a standard interface for reading an entity or list of entities.
    /// </summary>
    /// <typeparam name="T">Type param</typeparam>
    public interface IReadRepository<T>
    {
        #region Methods

        /// <summary>
        /// Gets the entity.
        /// </summary>
        /// <param name="id">Primary key of the entity</param>
        /// <returns>Returns null if a row is not found matching the provided Id, else the entity is returned.</returns>
        T Get(object id);

        /// <summary>
        /// Returns all of the items of a given type.
        /// </summary>
        /// <returns>List of entity.</returns>
        IList<T> GetAll();

        /// <summary>
        /// To get the list of items of the given type with Criteria.
        /// </summary>
        /// <param name="detachedCriteria">The detached Criteria.</param>
        /// <returns>List of entity.</returns>
        ICollection<T> GetAll(DetachedCriteria detachedCriteria);

        /// <summary>
        /// Method to get the result based on criteria.
        /// </summary>
        /// <param name="detachedCriteria">criteria</param>
        /// <returns>List of objects.</returns>
        ICollection<T> GetAllUsingFuture(DetachedCriteria detachedCriteria);

        /// Method to get the total number of result based on MultiCriteria.
        /// </summary>
        /// <param name="detachedCriteria">criteria</param>
        /// <returns>A collection which contains a list of objects and total number of objects.</returns>
        IList GetAllWithPagingMultiCriteria(DetachedCriteria detachedCriteria);

        /// <summary>
        /// Method to get the total number of result based on criteria.
        /// </summary>
        /// <param name="detachedCriteria">criteria</param>
        /// <returns>List of objects.</returns>
        Int32 GetCountUsingFuture(DetachedCriteria detachedCriteria);

        /// <summary>
        /// Loads the entity.
        /// </summary>
        /// <param name="id">Primary key of the entity</param>
        /// <returns>Returns the entity</returns>
        T Load(object id);

        #endregion Methods
    }
}