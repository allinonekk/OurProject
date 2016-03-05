#region Header

/*****************************************************************************************************
* Description : This file handles calls to all the Mapping DTOs to Domain entities
* and Repository for database transaction.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			            Description
*-----------------------------------------------------------------------------------------------------
*   11/Mar/2011   		        Yan Nai                	 	Created
*****************************************************************************************************/
// <summary>
// File: AbstractGateway.cs
// Description: This file handles calls to all the Mapping DTOs to Domain entities
// and Repository for database transaction.
// </summary>
// <copyright file= "AbstractGateway.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    abstract class AbstractGateway
    {
        #region Fields

        protected static readonly ILog Logger = LogManager.GetLogger(typeof(AbstractGateway));

        protected ISession applicationSession;

        #endregion Fields

        #region Constructors

        protected AbstractGateway()
        {
            ApplicationSessionManager applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;
        }

        protected AbstractGateway(ISession session)
        {
            this.applicationSession = session;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Passes the <paramref name="columnName"/> and <paramref name="value"/>. Get the <typeparam name="T"></typeparam> back.
        /// </summary>
        /// <typeparam name="V">Type of the value to use as a filter.</typeparam>
        /// <param name="columnName">The name of the filed to filter while retrieving objects.</param>
        /// <param name="value">The value of the filed to filter while retrieving objects.</param>
        /// <returns>List<T></returns>
        internal abstract List<T> GetEntity<T, V>(string columnName, V value, bool isNotObs);

        /// <summary>
        /// Passes the domain object and save it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityToSave">The domain object to be saved.<param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        /// <returns></returns>
        internal virtual void SaveOrUpdateEntity<T>(T entityToSave, bool isCopy)
        {
            if (entityToSave == null)
                throw new Exception("Invalid (empty) data to save. (SaveOrUpdateEntity in EnforcementGateWay)");

            IRepository<T> iEnforcementRepository = new RepositoryImpl<T>(applicationSession);
            iEnforcementRepository.SaveOrUpdate(entityToSave, isCopy);
        }

        /// <summary>
        /// Saves the or update entity list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entities">The collection of an entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        internal virtual void SaveOrUpdateEntityCollection<T>(List<T> entities, bool isCopy)
        {
            if (entities == null || entities.Count < 1)
                throw new Exception("Invalid (empty) data to save. (SaveOrUpdateEntityCollection in EnforcementGateWay)");

            try
            {
                IRepository<T> iRepository = new RepositoryImpl<T>(this.applicationSession);
                iRepository.SaveOrUpdate(entities, isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateEntityCollection", ex);
                throw;
            }
        }

        #endregion Methods
    }
}