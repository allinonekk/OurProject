#region Header

/*****************************************************************************************************
* Description : This file represents a standard interface for Repositories which are data-access
* mechanism agnostic through NHibernate.
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
// File: INHibernateRepository.cs
// Description: Represents a standard interface for Repositories which are data-access
// mechanism agnostic through NHibernate.
// </summary>
// <copyright file= "INHibernateRepository.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

using System;
using System.Collections;
using System.Collections.Generic;

using NHibernate;
using NHibernate.Criterion;

namespace AllInOne.Common.DataAccess.NHibernate
{
    /// <summary>
    /// Provides a standard interface for Repositories which are data-access mechanism agnostic through NHibernate.
    /// </summary>
    /// <typeparam name="T">Type param</typeparam>
    public interface INHibernateRepository<T>
    {
        #region Methods

        /// <summary>
        /// Creates a specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        string Create(T entity);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Delete(T entity);

        /// <summary>
        /// Finds all.
        /// </summary>
        /// <param name="detachedCriteria">The detached Criteria.</param>
        /// <returns></returns>
        ICollection<T> FindAll(DetachedCriteria detachedCriteria);

        /// <summary>
        /// Method to get the result based on ICriteria.
        /// </summary>
        /// <param name="iCriteria">ICriteria</param>
        /// <returns>List of objects.</returns>
        ICollection<T> FindAll(ICriteria iCriteria);

        /// <summary>
        /// Gets the entity.
        /// </summary>
        /// <param name="id">Primary key of the entity</param>
        /// <returns>Returns null if a row is not found matching the provided Id, else the entity is returned.</returns>
        T Get(object id);

        /// <summary>
        /// To get the list of items of the given type.
        /// </summary>
        /// <returns>List of entity.</returns>
        ICollection<T> GetAll();

        /// <summary>
        /// To get the list of items of the given type, sorted by Order.
        /// </summary>
        /// <returns>List of entity.</returns>
        ICollection<T> GetAll(Order order);

        /// <summary>
        /// To get the list of items of the given type with Criteria.
        /// </summary>
        /// <param name="detachedCriteria">The detached Criteria.</param>
        /// <returns>List of entity.</returns>
        ICollection<T> GetAll(DetachedCriteria detachedCriteria);

        /// <summary>
        /// Loads the entity.
        /// </summary>
        /// <param name="id">Primary key of the entity</param>
        /// <returns>Returns the entity</returns>
        T Load(object id);

        /// <summary>
        /// Locks the specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        T Lock(object id);

        /// <summary>
        /// Saves or Updates the Specified Entity
        /// </summary>
        /// <param name="entity">The entity.</param>
        void SaveOrUpdate(T entity);

        /// <summary>
        /// Saves or Updates the specified entity. If isCopy is true SaveOrUpdateCopy would be called,
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
        /// Saves or Updates the Specified Entity (for test purpose)
        /// </summary>
        /// <param name="entity">The entity.</param>
        void SaveOrUpdateCopy(T entity);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Update(T entity);
        
        /// <summary>
        /// To get the list of items of the given type with Criteria.
        /// </summary>
        /// <param name="detachedCriteria">The detached criteria.</param>
        /// <returns></returns>
        IEnumerable<T> GetAllUsingFuture(DetachedCriteria detachedCriteria);
        
        /// <summary>
        /// To get the list of items of the given type with Criteria.
        /// </summary>
        /// <param name="detachedCriteria">The detached criteria.</param>
        /// <returns></returns>
        Int32 GetCountUsingFuture(DetachedCriteria detachedCriteria);
        
        /// <summary>
        /// To get the list of items of the given type with MultiCriteria.
        /// </summary>
        /// <param name="detachedCriteria">The detached criteria.</param>
        /// <returns></returns>
        IList GetAllWithPagingMultiCriteria(DetachedCriteria detachedCriteria);
        #endregion Methods
    }
}