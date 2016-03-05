#region Header

/*****************************************************************************************************
* Description : This file handles getting the sessions and transactions from existing or open session factories.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   28/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ApplicationSessionManager.cs
// Description: Handles getting the sessions and transactions from existing or open session factories.
// </summary>
// <copyright file= "ApplicationSessionManager.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

using System;
using System.Configuration;

using AllInOne.Common.DataAccess.Utilities;

using log4net;

using NHibernate;

namespace AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement
{
    /// <summary>
    /// Handles getting the sessions and transactions from existing or open session factories.
    /// </summary>
    public class ApplicationSessionManager
    {
        #region Fields

        /// <summary>
        /// To store Logger instance.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SessionFactoryManager));

        /// <summary>
        /// To store <see cref="SessionFactoryElement" />
        /// </summary>
        private SessionFactoryElement sessionFactoryElement = null;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationSessionManager"/> class.
        /// </summary>
        public ApplicationSessionManager()
        {
            // Blank const...
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationSessionManager"/> class.
        /// </summary>
        /// <param name="dataBaseConnectivity"><see cref="DataBaseConnectivity" /> to be used for getting the <see cref="SessionFactoryElement" /></param>
        public ApplicationSessionManager(DataBaseConnectivity dataBaseConnectivity)
        {
            try
            {
                Check.Require(!string.IsNullOrEmpty(dataBaseConnectivity.ToString()),
                    "DataBaseConnectivity should not be null nor empty");

                this.sessionFactoryElement = this.GetSessionFactoryElementFromName(dataBaseConnectivity);

                Check.Require(!string.IsNullOrEmpty(this.sessionFactoryElement.Name) && !string.IsNullOrEmpty(this.sessionFactoryElement.FactoryConfigPath),
                    "SessionFactoryElement's Name and FactoryConfigPath should not be null nor empty");

                this.Session = NHibernateSessionManager.Instance.GetSessionFrom(this.sessionFactoryElement.FactoryConfigPath);
            }
            catch (HibernateException hex)
            {
                Logger.Error("Error at ApplicationSessionManager - HibernateException", hex);
                throw;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ApplicationSessionManager - Exception", ex);
                throw;
            }
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// To store <see cref="ISession" />
        /// </summary>
        public ISession Session
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning of the HTTP request.  Note that 
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        /// <param name="sender"></param>
        public void BeginTransaction()
        {
            OpenSessionInViewSection openSessionInViewSection = this.GetOpenSessionInViewSection();

            foreach (SessionFactoryElement sessionFactorySettings in openSessionInViewSection.SessionFactories)
            {
                if (sessionFactorySettings.IsTransactional)
                {
                    NHibernateSessionManager.Instance.BeginTransactionOn(sessionFactorySettings.FactoryConfigPath);
                }
            }
        }

        /// <summary>
        /// Closes the NHibernate session provided by the supplied <see cref="NHibernateSessionManager"/>.
        /// Assumes a transaction was begun at the start; but a transaction or session does
        /// not *have* to be opened for this to operate successfully.
        /// </summary>
        public void CloseSession()
        {
            OpenSessionInViewSection openSessionInViewSection = this.GetOpenSessionInViewSection();

            // No matter what happens, make sure all the sessions get closed
            foreach (SessionFactoryElement sessionFactorySettings in openSessionInViewSection.SessionFactories)
            {
                NHibernateSessionManager.Instance.CloseSessionOn(sessionFactorySettings.FactoryConfigPath);
            }
        }

        public void RollBackTransaction()
        {
            OpenSessionInViewSection openSessionInViewSection = this.GetOpenSessionInViewSection();

            // RollBack every session factory that's holding a transactional session
            foreach (SessionFactoryElement sessionFactorySettings in openSessionInViewSection.SessionFactories)
            {
                if (sessionFactorySettings.IsTransactional)
                {
                    NHibernateSessionManager.Instance.RollbackTransactionOn(
                        sessionFactorySettings.FactoryConfigPath);
                }
            }
        }

        /// <summary>
        /// Closes the NHibernate session provided by the supplied <see cref="NHibernateSessionManager"/>.
        /// Assumes a transaction was begun at the start; but a transaction or session does
        /// not *have* to be opened for this to operate successfully.
        /// </summary>
        public void CloseTransaction()
        {
            OpenSessionInViewSection openSessionInViewSection = this.GetOpenSessionInViewSection();

            // No matter what happens, make sure all the sessions get closed
            foreach (SessionFactoryElement sessionFactorySettings in openSessionInViewSection.SessionFactories)
            {
                NHibernateSessionManager.Instance.CloseSessionOn(sessionFactorySettings.FactoryConfigPath);
            }
        }

        /// <summary>
        /// Commits and closes the NHibernate session provided by the supplied <see cref="NHibernateSessionManager"/>.
        /// Assumes a transaction was begun at the beginning of the request; but a transaction or session does
        /// not *have* to be opened for this to operate successfully.
        /// </summary>
        public void CommitAndCloseSession()
        {
            OpenSessionInViewSection openSessionInViewSection = this.GetOpenSessionInViewSection();

            try
            {
                // Commit every session factory that's holding a transactional session
                foreach (SessionFactoryElement sessionFactorySettings in openSessionInViewSection.SessionFactories)
                {
                    if (sessionFactorySettings.IsTransactional)
                    {
                        NHibernateSessionManager.Instance.CommitTransactionOn(sessionFactorySettings.FactoryConfigPath);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CommitAndCloseSession method", ex);
                throw;
            }
            finally
            {
                // No matter what happens, make sure all the sessions get closed
                foreach (SessionFactoryElement sessionFactorySettings in openSessionInViewSection.SessionFactories)
                {
                    NHibernateSessionManager.Instance.CloseSessionOn(sessionFactorySettings.FactoryConfigPath);
                }
            }
        }

        /// <summary>
        /// Commits the transaction.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        public void CommitTransaction()
        {
            OpenSessionInViewSection openSessionInViewSection = this.GetOpenSessionInViewSection();

            // Commit every session factory that's holding a transactional session
            foreach (SessionFactoryElement sessionFactorySettings in openSessionInViewSection.SessionFactories)
            {
                if (sessionFactorySettings.IsTransactional)
                {
                    NHibernateSessionManager.Instance.CommitTransactionOn(
                        sessionFactorySettings.FactoryConfigPath);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationSessionManager"/> class.
        /// </summary>
        /// <param name="dataBaseConnectivity"><see cref="DataBaseConnectivity" /> to be used for getting the <see cref="SessionFactoryElement" /></param>
        public ISession SessionManager(DataBaseConnectivity dataBaseConnectivity)
        {
            try
            {
                Check.Require(!string.IsNullOrEmpty(dataBaseConnectivity.ToString()),
                    "DataBaseConnectivity should not be null nor empty");

                this.sessionFactoryElement = this.GetSessionFactoryElementFromName(dataBaseConnectivity);

                Check.Require(!string.IsNullOrEmpty(this.sessionFactoryElement.Name) && !string.IsNullOrEmpty(this.sessionFactoryElement.FactoryConfigPath),
                    "SessionFactoryElement's Name and FactoryConfigPath should not be null nor empty");

                return NHibernateSessionManager.Instance.GetSessionFrom(this.sessionFactoryElement.FactoryConfigPath);
            }
            catch (HibernateException hex)
            {
                Logger.Error("Error at ApplicationSessionManager - HibernateException", hex);
                throw;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ApplicationSessionManager - Exception", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the <see cref="OpenSessionInViewSection" /> based on all the nhibernateSettings done in web.config.
        /// </summary>
        /// <returns>Returns <see cref="OpenSessionInViewSection" /></returns>
        private OpenSessionInViewSection GetOpenSessionInViewSection()
        {
            OpenSessionInViewSection openSessionInViewSection = ConfigurationManager
                .GetSection("nhibernateSettings") as OpenSessionInViewSection;

            Check.Ensure(openSessionInViewSection != null,
                "The nhibernateSettings section was not found within ConfigurationManager.");
            return openSessionInViewSection;
        }

        /// <summary>
        /// Method to get the <see cref="SessionFactoryElement" /> object based on the <see cref="DataBaseConnectivity" />.
        /// </summary>
        /// <param name="dataBaseConnectivity"><see cref="DataBaseConnectivity" /> to be used for getting the <see cref="SessionFactoryElement" /></param>
        /// <returns>Returns <see cref="SessionFactoryElement" /></returns>
        private SessionFactoryElement GetSessionFactoryElementFromName(DataBaseConnectivity dataBaseConnectivity)
        {
            Check.Require(!string.IsNullOrEmpty(dataBaseConnectivity.ToString()),
                "DataBaseConnectivity should not be null nor empty");

            SessionFactoryElement sessionFactoryElement = null;

            try
            {

                using (SessionFactoryManager sfm = new SessionFactoryManager())
                {
                    sessionFactoryElement = sfm.GetSessionFactoryElementFromName(dataBaseConnectivity);
                }

                Check.Require(sessionFactoryElement != null,
                    "SessionFactoryElement should not be null.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSessionFactoryElementFromName method", ex);
                throw;
            }

            return sessionFactoryElement;
        }

        #endregion Methods
    }
}