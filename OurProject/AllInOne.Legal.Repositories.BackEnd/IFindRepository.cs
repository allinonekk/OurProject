#region Header

/*****************************************************************************************************
* Description : This file represents a standard interface for finding an entity or list of entities.
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
// File: IFindRepository.cs
// Description: Represents a standard interface for finding an entity or list of entities.
// </summary>
// <copyright file= "IFindRepository.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Repositories.BackEnd
{
    using System;
    using System.Collections.Generic;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Provides a standard interface for finding an entity or list of entities.
    /// </summary>
    /// <typeparam name="T">Type param</typeparam>
    public interface IFindRepository<T>
    {
        #region Methods

        /// <summary>
        /// Method to get the result based on criteria.
        /// </summary>
        /// <param name="criteria">criteria</param>
        /// <returns>List of objects.</returns>
        ICollection<T> FindAll(DetachedCriteria criteria);

        /// <summary>
        /// Method to get the result based on ICriterion.
        /// </summary>
        /// <param name="iCriteria">ICriteria</param>
        /// <returns>List of objects.</returns>
        ICollection<T> FindAll(ICriteria iCriteria);

        #endregion Methods
    }
}