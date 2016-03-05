#region Header

/*****************************************************************************************************
* Description : This file provides all the different NHibernate querying methods.
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
// File: NHibernateRepositoryImpl.cs
// Description: Provides all the different NHibernate querying methods.
// This class implements from <see cref="INHibernateRepository"/>.
// </summary>
// <copyright file= "NHibernateRepositoryImpl.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

using System;
using System.Collections;
using System.Collections.Generic;

using log4net;

using NHibernate;
using NHibernate.Criterion;

namespace AllInOne.Common.DataAccess.NHibernate
{
    /// <summary>
    /// Provides all the different NHibernate querying methods.
    /// This class implements from <see cref="INHibernateRepository<T>"/>
    /// </summary>
    /// <typeparam name="T">Type param</typeparam>
    public class NHibernateRepositoryImpl<T> : INHibernateRepository<T>
    {
        #region Fields

        /// <summary>
        /// To store ISession instance.
        /// </summary>
        private readonly ISession session;

        /// <summary>
        /// To store Logger instance.
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(typeof(NHibernateRepositoryImpl<T>));

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NHibernateRepositoryImpl"/> class.
        /// </summary>
        /// <param name="session"><see cref="ISession"/>, based on which the querying will be performed.</param>
        public NHibernateRepositoryImpl(ISession session)
        {
            this.session = session;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Creates a specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public string Create(T entity)
        {
            return this.session.Save(entity).ToString();
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Delete(T entity)
        {
            this.session.Delete(entity);
        }

        /// <summary>
        /// Finds all.
        /// </summary>
        /// <param name="detachedCriteria">The detached criteria.</param>
        /// <returns></returns>
        public ICollection<T> FindAll(DetachedCriteria detachedCriteria)
        {
            ICriteria criteria = RepositoryHelper<T>.GetExecutableCriteria(this.session, detachedCriteria);
            return criteria.List<T>();
        }

        /// <summary>
        /// Finds all.
        /// </summary>
        /// <param name="iCriteria">The ICriteria criteria.</param>
        /// <returns></returns>
        public ICollection<T> FindAll(ICriteria iCriteria)
        {
            ICriteria criteria = iCriteria;
            return criteria.List<T>();
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
            return (T)this.session.Get(typeof(T), id);
        }

        /// <summary>
        /// To get the list of items of the given type.
        /// </summary>
        /// <returns>List of entity.</returns>
        public ICollection<T> GetAll()
        {
            ICriteria criteria = this.session.CreateCriteria(typeof(T));
            return criteria.List<T>();
        }

        /// <summary>
        /// To get the list of items of the given type, sorted by Order.
        /// </summary>
        /// <param name="order">The order based on which list of entities to be sorted.</param>
        /// <returns>List of entity.</returns>
        public ICollection<T> GetAll(Order order)
        {
            ICriteria criteria = this.session.CreateCriteria(typeof(T));
            criteria.AddOrder(order);
            return criteria.List<T>();
        }

        /// <summary>
        /// To get the list of items of the given type with Criteria.
        /// </summary>
        /// <param name="detachedCriteria">The detached criteria.</param>
        /// <returns></returns>
        public ICollection<T> GetAll(DetachedCriteria detachedCriteria)
        {
            ICriteria criteria = RepositoryHelper<T>.GetExecutableCriteria(this.session, detachedCriteria);
            return criteria.List<T>();
        }

        /// <summary>
        /// Loads the entity.
        /// </summary>
        /// <param name="id">Primary key of the entity</param>
        /// <returns>Returns the entity</returns>
        public T Load(object id)
        {
            return (T)this.session.Load(typeof(T), id);
        }

        /// <summary>
        /// Locks the specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public T Lock(object id)
        {
            return (T) this.session.Get(typeof(T),id,LockMode.Upgrade);
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void SaveOrUpdate(T entity)
        {
            this.session.SaveOrUpdate(entity);
        }

        /// <summary>
        /// Saves or Updates the specified entity. If isCopy is true SaveOrUpdateCopy would be called,
        /// else just SaveOrUpdate.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        public void SaveOrUpdate(T entity, bool isCopy)
        {
            if (isCopy)
            {
                this.session.SaveOrUpdateCopy(entity);
            }
            else
            {
                this.session.SaveOrUpdate(entity);
            }
        }

        /// <summary>
        /// Saves or Updates the specified entity list. If isCopy is true SaveOrUpdateCopy would be called,
        /// else just SaveOrUpdate.
        /// </summary>
        /// <param name="entity">The entity list.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        public void SaveOrUpdate(IList<T> entities, bool isCopy)
        {
            if (isCopy)
            {
                foreach (var entity in entities)
                {
                    this.session.SaveOrUpdateCopy(entity);
                }
            }
            else
            {
                foreach (var entity in entities)
                {
                    this.session.SaveOrUpdate(entity);
                }
            }
        }

        /// <summary>
        /// Updates the specified entity (for the test purpose).
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void SaveOrUpdateCopy(T entity)
        {
            try
            {
                this.session.SaveOrUpdateCopy(entity);
            }
            catch (Exception ex)
            {
                logger.Error("Error at SaveOrUpdateCopy", ex);
                throw;
            }
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Update(T entity)
        {
            this.session.Update(entity);
        }

        /// <summary>
        /// To get the list of items of the given type with Criteria.
        /// </summary>
        /// <param name="detachedCriteria">The detached criteria.</param>
        /// <returns></returns>
        public IEnumerable<T> GetAllUsingFuture(DetachedCriteria detachedCriteria)
        {
            ICriteria criteria = RepositoryHelper<T>.GetExecutableCriteria(this.session, detachedCriteria);
            //return criteria.Future<T>();
            return criteria.List<T>();
        }

        /// <summary>
        /// To get the list of items of the given type with Criteria.
        /// </summary>
        /// <param name="detachedCriteria">The detached criteria.</param>
        /// <returns></returns>
        public Int32 GetCountUsingFuture(DetachedCriteria detachedCriteria)
        {
            ICriteria criteria = RepositoryHelper<T>.GetExecutableCriteria(this.session, detachedCriteria);
            //return CriteriaTransformer.TransformToRowCount(criteria).UniqueResult<Int32>();
            //return CriteriaTransformer.TransformToRowCount(criteria).FutureValue<Int32>().Value;
            return criteria
                .SetProjection(Projections.Count(Projections.Id()))
                //.FutureValue<Int32>().Value;
                .UniqueResult<Int32>();
        }

        /// <summary>
        /// To get the list of items of the given type with MultiCriteria.
        /// </summary>
        /// <param name="detachedCriteria">The detached criteria.</param>
        /// <returns></returns>
        public IList GetAllWithPagingMultiCriteria(DetachedCriteria detachedCriteria)
        {
            IMultiCriteria multiCriteria = this.session.CreateMultiCriteria();
            ICriteria criteria = RepositoryHelper<T>.GetExecutableCriteria(this.session, detachedCriteria);
            ICriteria rowCountCriteria = CriteriaTransformer.TransformToRowCount(criteria);

            multiCriteria.Add(criteria);
            multiCriteria.Add(rowCountCriteria);
            return multiCriteria.List();
        }

        #endregion Methods
    }
}