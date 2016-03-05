#region Header

/*****************************************************************************************************
* Description : Interface to define the Unit Of Work implementation.
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
// File: IUnitOfWork.cs
// Description: Interface to define the <see cref="UnitOfWork" /> implementation.
// </summary>
// <copyright file= "IUnitOfWork.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

using System;

using NHibernate;

namespace AllInOne.Common.DataAccess.NHibernate
{
    /// <summary>
    /// Interface to defined the Unit Of Work.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        #region Properties

        /// <summary>
        /// <see cref="ISession" /> to store the current session.
        /// </summary>
        ISession Session
        {
            get; set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// To commit the current data inserts/updates.
        /// </summary>
        void Commit();

        /// <summary>
        /// To Rollback the current data inserts/updates.
        /// </summary>
        void Rollback();

        #endregion Methods
    }
}