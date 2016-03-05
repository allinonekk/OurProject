#region Header

/*****************************************************************************************************
* Description : This file represents a standard interface for deleting an entity.
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
// File: IDeleteRepository.cs
// Description: Represents a standard interface for deleting an entity.
// </summary>
// <copyright file= "IDeleteRepository.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Repositories.BackEnd
{
    using System;
    using System.Collections.Generic;

    using NHibernate.Criterion;

    /// <summary>
    /// Provides a standard interface for deleting an entity.
    /// </summary>
    /// <typeparam name="T">Type param</typeparam>
    public interface IDeleteRepository<T>
    {
        #region Methods

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Delete(T entity);

        /// <summary>
        /// Method to get the result based on criteria.
        /// </summary>
        /// <param name="criteria">criteria</param>
        /// <returns>List of objects.</returns>
        void DeleteAll(DetachedCriteria criteria);

        /// <summary>
        /// Deletes all the specified entities.
        /// </summary>
        /// <param name="entityList">The entity list.</param>
        void DeleteAll(IList<T> entityList);

        #endregion Methods
    }
}