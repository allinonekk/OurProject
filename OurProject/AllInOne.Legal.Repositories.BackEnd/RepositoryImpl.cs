#region Header

/*****************************************************************************************************
* Description : This file represents a class which implements <see cref="IRepository" />, where it gets
* the session and performs transaction for database insert, update, delete, read, find, etc. through
* NHibernate.
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
// File: RepositoryImpl.cs
// Description: Class which implements <see cref="IRepository" />, where it gets the session and
// performs transaction for database insert, update, delete, read, find, etc. through NHibernate.
// </summary>
// <copyright file= "RepositoryImpl.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Repositories.BackEnd
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using AllInOne.Common.DataAccess.NHibernate;
    using AllInOne.Common.DataAccess.Utilities;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Class which implements <see cref="IRepository<T>" />, where it gets the session and
    /// performs transaction for database insert, update, delete, read, find, etc. through NHibernate.
    /// </summary>
    /// <typeparam name="T">Type param</typeparam>
    public class RepositoryImpl<T> : IRepository<T>
    {
        #region Fields

        /// <summary>
        /// To store <see cref="ISession"/>.
        /// </summary>
        private readonly ISession session;

        /// <summary>
        /// To store <see cref="INHibernateRepository"/>.
        /// </summary>
        private INHibernateRepository<T> INHibernateRepository = null;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryImpl<T>"/> class.
        /// </summary>
        /// <param name="session">The session.</param>
        public RepositoryImpl(ISession session)
        {
            Check.RequireWithNullException(session != null,
                "session was null or empty");

            this.session = session;
            this.INHibernateRepository = new NHibernateRepositoryImpl<T>(this.session);
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>Returns the created entity.</returns>
        public string Create(T entity)
        {
            Check.RequireWithNullException(entity != null,
                "entity was null or empty; " + "it has to have value within it");

            return this.INHibernateRepository.Create(entity).ToString();
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Delete(T entity)
        {
            Check.RequireWithNullException(entity != null,
                "entity was null or empty; " + "it has to have value within it");

            this.INHibernateRepository.Delete(entity);
        }

        /// <summary>
        /// Deletes all the specified entities.
        /// </summary>
        /// <param name="entityList">The entity list.</param>
        public void DeleteAll(IList<T> entityList)
        {
            Check.RequireWithNullException(entityList != null || entityList.Count > 0,
                "entityList was null or empty; " +
                "it has to have value within it");

            foreach (var entity in entityList)
            {
                this.INHibernateRepository.Delete(entity);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        public void DeleteAll(DetachedCriteria criteria)
        {
            foreach (T entity in FindAll(criteria))
            {
                Delete(entity);

            }
        }

        /// <summary>
        /// Method to get the result based on criteria.
        /// </summary>
        /// <param name="criteria">criteria</param>
        /// <returns>List of objects.</returns>
        public ICollection<T> FindAll(DetachedCriteria criteria)
        {
            return this.INHibernateRepository.FindAll(criteria) as IList<T>;
        }

        /// <summary>
        /// Method to get the result based on ICriteria.
        /// </summary>
        /// <param name="iCriteria">ICriterion</param>
        /// <returns>List of objects.</returns>
        public ICollection<T> FindAll(ICriteria iCriteria)
        {
            return this.INHibernateRepository.FindAll(iCriteria) as IList<T>;
        }

        /// <summary>
        /// Gets the entity.
        /// </summary>
        /// <param name="id">Primary key of the entity</param>
        /// <returns>
        /// Returns null if a row is not found matching the provided Id, else the entity is returned.
        /// </returns>
        public T Get(object id)
        {
            Check.RequireWithNullException(id != null,
                "id was null or empty; " + "it has to have value wihtin it");

            return this.INHibernateRepository.Get(id);
        }

        /// <summary>
        /// Returns all of the items of a given type.
        /// </summary>
        /// <returns>List of entity.</returns>
        public IList<T> GetAll()
        {
            return this.INHibernateRepository.GetAll() as IList<T>;
        }

        /// <summary>
        /// Method to get the result based on criteria.
        /// </summary>
        /// <param name="detachedCriteria">criteria</param>
        /// <returns>List of objects.</returns>
        public ICollection<T> GetAll(DetachedCriteria detachedCriteria)
        {
            return this.INHibernateRepository.FindAll(detachedCriteria) as IList<T>;
        }

        /// <summary>
        /// Method to get the result based on criteria.
        /// </summary>
        /// <param name="detachedCriteria">criteria</param>
        /// <returns>List of objects.</returns>
        public ICollection<T> GetAllUsingFuture(DetachedCriteria detachedCriteria)
        {
            return this.INHibernateRepository.GetAllUsingFuture(detachedCriteria) as IList<T>;
        }

        /// <summary>
        /// Method to get the total number of result based on MultiCriteria.
        /// </summary>
        /// <param name="detachedCriteria">criteria</param>
        /// <returns>A collection which contains a list of objects and total number of objects.</returns>
        public IList GetAllWithPagingMultiCriteria(DetachedCriteria detachedCriteria)
        {
            return this.INHibernateRepository.GetAllWithPagingMultiCriteria(detachedCriteria);
        }

        /// <summary>
        /// Method to get the total number of result based on criteria.
        /// </summary>
        /// <param name="detachedCriteria">criteria</param>
        /// <returns>List of objects.</returns>
        public Int32 GetCountUsingFuture(DetachedCriteria detachedCriteria)
        {
            return this.INHibernateRepository.GetCountUsingFuture(detachedCriteria);
        }

        /// <summary>
        /// Loads the entity.
        /// </summary>
        /// <param name="id">Primary key of the entity</param>
        /// <returns>Returns the entity</returns>
        public T Load(object id)
        {
            Check.RequireWithNullException(id != null,
                "id was null or empty; " + "it has to have value wihtin it");

            return this.INHibernateRepository.Load(id);
        }

        /// <summary>
        /// Saves or update.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void SaveOrUpdate(T entity)
        {
            Check.RequireWithNullException(entity != null,
                "Entity was null or empty; " + " It has to have value within it");

            this.INHibernateRepository.SaveOrUpdate(entity);
        }

        /// <summary>
        /// Saves or Updates the Specified Entity. If isCopy is true SaveOrUpdateCopy would be called,
        /// else just SaveOrUpdate.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        public void SaveOrUpdate(T entity, bool isCopy)
        {
            Check.RequireWithNullException(entity != null,
                "Entity was null or empty; " + " It has to have value within it.");

            this.INHibernateRepository.SaveOrUpdate(entity, isCopy);
        }

        /// <summary>
        /// Saves or Updates the specified entity list. If isCopy is true SaveOrUpdateCopy would be called,
        /// else just SaveOrUpdate.
        /// </summary>
        /// <param name="entity">The entity list.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        public void SaveOrUpdate(IList<T> entities, bool isCopy)
        {
            Check.RequireWithNullException(entities != null,
                "entities was null or empty; " + " It has to have value within it.");

            this.INHibernateRepository.SaveOrUpdate(entities, isCopy);
        }

        /// <summary>
        /// Saves or update.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void SaveOrUpdateCopy(T entity)
        {
            Check.RequireWithNullException(entity != null,
                "Entity was null or empty; " + " It has to have value within it");

            this.INHibernateRepository.SaveOrUpdateCopy(entity);
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Update(T entity)
        {
            Check.RequireWithNullException(entity != null,
                "entity was null or empty; " + "it has to have value within it");

            this.INHibernateRepository.Update(entity);
        }

        #endregion Methods
    }
}