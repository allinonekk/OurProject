#region Header

/*****************************************************************************************************
* Description : This file provides all the inner operations of query
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   31/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: RepositoryHelper.cs
// Description: Provides all the different NHibernate querying methods.
// This class implements from <see cref="INHibernateRepository"/>.
// </summary>
// <copyright file= "RepositoryHelper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

using System;
using System.Collections.Generic;

using NHibernate;
using NHibernate.Criterion;

namespace AllInOne.Common.DataAccess.NHibernate
{
    /// <summary>
    /// Represents a clas which provides common repository helpers utitlites.
    /// </summary>
    /// <typeparam name="T">Represents an entity</typeparam>
    public class RepositoryHelper<T>
    {
        #region Methods

        /// <summary>
        /// Creates the criteria from array.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="criteria">The criteria.</param>
        /// <param name="orders">The orders.</param>
        /// <returns>Returns <see cref="ICriteria"/></returns>
        public static ICriteria CreateCriteriaFromArray(ISession session, ICriterion[] criteria, Order[] orders)
        {
            ICriteria crit = session.CreateCriteria(typeof(T));
            foreach (ICriterion criterion in criteria)
            {

                if (criterion == null)
                {
                    continue;
                }

                crit.Add(criterion);
            }

            if (orders != null)
            {
                foreach (Order order in orders)
                {
                    crit.AddOrder(order);
                }
            }

            return crit;
        }

        /// <summary>
        /// Gets the executable criteria.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="criteria">The criteria.</param>
        /// <param name="orders">The orders.</param>
        /// <returns>Returns <see cref="ICriteria"/></returns>
        public static ICriteria GetExecutableCriteria(ISession session, DetachedCriteria criteria, Order[] orders)
        {
            ICriteria executableCriteria;
            if (criteria != null)
            {
                executableCriteria = criteria.GetExecutableCriteria(session);
            }
            else
            {
                executableCriteria = session.CreateCriteria(typeof(T));
            }

            if (orders != null)
            {
                foreach (Order order in orders)
                {
                    executableCriteria.AddOrder(order);
                }
            }

            return executableCriteria;
        }

        /// <summary>
        /// Gets the executable criteria.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="criteria">The criteria.</param>
        /// <returns>Returns <see cref="ICriteria"/></returns>
        public static ICriteria GetExecutableCriteria(ISession session, DetachedCriteria criteria)
        {
            ICriteria executableCriteria;

            if (criteria != null)
            {
                executableCriteria = criteria.GetExecutableCriteria(session);
            }
            else
            {
                executableCriteria = session.CreateCriteria(typeof(T));
            }

            return executableCriteria;
        }

        #endregion Methods
    }
}