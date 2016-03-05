#region Header

/*****************************************************************************************************
* Description : This file represents a standard interface Repositories which are data-access mechanism
* agnostic. This provides for Create, Update, Delete, Read and Find declarations.
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
// File: IRepository.cs
// Description: Represents a standard interface Repositories which are data-access mechanism agnostic.
// This provides for Create, Update, Delete, Read and Find declarations.
// </summary>
// <copyright file= "IRepository.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Repositories.BackEnd
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Provides a standard interface for Repositories which are data-access mechanism agnostic.
    /// This provides for Create, Update, Delete, Read and Find declarations.
    /// </summary>
    /// <typeparam name="T">Type param</typeparam>
    public interface IRepository<T> : ICreateRepository<T>, IUpdateRepository<T>, IDeleteRepository<T>, IReadRepository<T>, IFindRepository<T>
    {
    }
}