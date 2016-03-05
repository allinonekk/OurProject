#region Header

/*****************************************************************************************************
* Description : This file represents a standard interface for creating an entity.
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
// File: ICreateRepository.cs
// Description: Represents a standard interface for creating an entity.
// </summary>
// <copyright file= "ICreateRepository.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Repositories.BackEnd
{
    using System;

    /// <summary>
    /// Provides a standard interface for creating an entity.
    /// </summary>
    /// <typeparam name="T">Type param</typeparam>
    public interface ICreateRepository<T>
    {
        #region Methods

        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>Returns the created entity.</returns>
        string Create(T entity);

        #endregion Methods
    }
}