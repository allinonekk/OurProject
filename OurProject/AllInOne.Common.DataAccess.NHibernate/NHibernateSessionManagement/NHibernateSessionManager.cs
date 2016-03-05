#region Header

/*****************************************************************************************************
* Description : This file handles creation and management of sessions and transactions for NHibernate.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   02/08/2010   		      Swaroop             	 	Created
*   05/08/2010                Nithin                    Logger Implementation
*****************************************************************************************************/
// <summary>
// File: NHibernateSessionManager.cs
// Description: Handles creation and management of sessions and transactions for NHibernate.
// Refer http://www.codeproject.com/KB/architecture/NHibernateBestPractices.aspx for original post.
// </summary>
// <copyright file= "NHibernateSessionManager.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

using System;
using System.Collections;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Web;

using AllInOne.Common.DataAccess.Utilities;

using log4net;

using NHibernate;
using NHibernate.Cache;
using NHibernate.Cfg;

namespace AllInOne.Common.DataAccess.NHibernate
{
    /// <summary>
    /// Handles creation and management of sessions and transactions.  It is a singleton because 
    /// building the initial session factory is very expensive. Inspiration for this class came 
    /// from Chapter 8 of Hibernate in Action by Bauer and King.  Although it is a sealed singleton
    /// you can use TypeMock (http://www.typemock.com) for more flexible testing.
    /// </summary>
    public sealed class NHibernateSessionManager
    {
        #region Fields

        /// <summary>
        /// Constant for Context Sessions
        /// </summary>
        private const string SESSION_KEY = "CONTEXT_SESSIONS";

        /// <summary>
        /// Constant for Context Transactions
        /// </summary>
        private const string TRANSACTION_KEY = "CONTEXT_TRANSACTIONS";

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(NHibernateSessionManager));

        /// <summary>
        /// Variable to hold the list of session factories data.
        /// </summary>
        private Hashtable sessionFactories = new Hashtable();

        private object LockMe = new object();
        #endregion Fields

        #region Constructors

        /// <summary>
        /// Private constructor to enforce singleton
        /// </summary>
        private NHibernateSessionManager()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// This is a thread-safe, lazy singleton.  See http://www.yoda.arachsys.com/csharp/singleton.html
        /// for more details about its implementation.
        /// </summary>
        public static NHibernateSessionManager Instance
        {
            get
            {
                return Nested.NHibernateSessionManager;
            }
        }

        /// <summary>
        /// Since multiple databases may be in use, there may be one session per database 
        /// persisted at any one time.  The easiest way to store them is via a hashtable
        /// with the key being tied to session factory.  If within a web context, this uses
        /// <see cref="HttpContext" /> instead of the WinForms specific <see cref="CallContext" />.  
        /// Discussion concerning this found at http://forum.springframework.net/showthread.php?t=572
        /// </summary>
        private Hashtable ContextSessions
        {
            get
            {
                if (IsInWebContext())
                {
                    if (HttpContext.Current.Items[SESSION_KEY] == null)
                    {
                        HttpContext.Current.Items[SESSION_KEY] = new Hashtable();
                    }

                    return (Hashtable)HttpContext.Current.Items[SESSION_KEY];
                }
                else
                {
                    if (CallContext.GetData(SESSION_KEY) == null)
                    {
                        CallContext.SetData(SESSION_KEY, new Hashtable());
                    }

                    return (Hashtable)CallContext.GetData(SESSION_KEY);
                }
            }
        }

        /// <summary>
        /// Since multiple databases may be in use, there may be one transaction per database 
        /// persisted at any one time.  The easiest way to store them is via a hashtable
        /// with the key being tied to session factory.  If within a web context, this uses
        /// <see cref="HttpContext" /> instead of the WinForms specific <see cref="CallContext" />.  
        /// Discussion concerning this found at http://forum.springframework.net/showthread.php?t=572
        /// </summary>
        private Hashtable ContextTransactions
        {
            get
            {
                if (IsInWebContext())
                {
                    if (HttpContext.Current.Items[TRANSACTION_KEY] == null)
                    {
                        HttpContext.Current.Items[TRANSACTION_KEY] = new Hashtable();
                    }

                    return (Hashtable)HttpContext.Current.Items[TRANSACTION_KEY];
                }
                else
                {
                    if (CallContext.GetData(TRANSACTION_KEY) == null)
                    {
                        CallContext.SetData(TRANSACTION_KEY, new Hashtable());
                    }

                    return (Hashtable)CallContext.GetData(TRANSACTION_KEY);
                }
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Begins a Transaction based on a config file.
        /// </summary>
        /// <param name="sessionFactoryConfigPath">SessionFactory's files config path</param>
        /// <returns>Returns <see cref="ITransaction" /></returns>
        public ITransaction BeginTransactionOn(string sessionFactoryConfigPath)
        {
            Logger.Debug("BeginTransactionOn started at " + DateTime.Now.ToString());

            ITransaction transaction;

            try
            {
                sessionFactoryConfigPath = this.GetConfigFullPath(sessionFactoryConfigPath);

                transaction = (ITransaction)ContextTransactions[sessionFactoryConfigPath];

                if (transaction == null)
                {
                    transaction = GetSessionFrom(sessionFactoryConfigPath).BeginTransaction();
                    ContextTransactions.Add(sessionFactoryConfigPath, transaction);
                }
            }
            catch (HibernateException hex)
            {
                Logger.Error("Error at BeginTransactionOn - HibernateException", hex);
                throw;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at BeginTransactionOn - Exception", ex);
                throw;
            }

            Logger.Debug("BeginTransactionOn ended at " + DateTime.Now.ToString());

            return transaction;
        }

        /// <summary>
        /// Flushes anything left in the session and closes the connection.
        /// </summary>
        public void CloseSessionOn(string sessionFactoryConfigPath)
        {
            Logger.Debug("CloseSessionOn started at " + DateTime.Now.ToString());

            try
            {
                sessionFactoryConfigPath = this.GetConfigFullPath(sessionFactoryConfigPath);
                ISession session = (ISession)ContextSessions[sessionFactoryConfigPath];

                if (session != null && session.IsOpen)
                {
                    //session.Flush(); Removed via http://www.codeproject.com/KB/architecture/NHibernateBestPractices.aspx?msg=2876684#xx2876684xx link.
                    session.Close();
                }

                ContextSessions.Remove(sessionFactoryConfigPath);
            }
            catch (HibernateException hex)
            {
                Logger.Error("Error at CloseSessionOn - HibernateException", hex);
                throw;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CloseSessionOn - Exception", ex);
                throw;
            }

            Logger.Debug("CloseSessionOn ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Commits a Transaction based on a config file.
        /// </summary>
        /// <param name="sessionFactoryConfigPath">SessionFactory's files config path</param>
        public void CommitOnlyTransactionOn(string sessionFactoryConfigPath)
        {
            Logger.Debug("CommitOnlyTransactionOn started at " + DateTime.Now.ToString());

            sessionFactoryConfigPath = this.GetConfigFullPath(sessionFactoryConfigPath);
            ITransaction transaction = (ITransaction)ContextTransactions[sessionFactoryConfigPath];

            try
            {
                if (HasOpenTransactionOn(sessionFactoryConfigPath))
                {
                    transaction.Commit();
                    ContextTransactions.Remove(sessionFactoryConfigPath);
                }
            }
            catch (HibernateException hex)
            {
                //RollbackTransactionOn(sessionFactoryConfigPath);
                Logger.Error("Error >> CommitOnlyTransactionOn", hex);
                throw;
            }

            Logger.Debug("CommitOnlyTransactionOn ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Commits a Transaction based on a config file.
        /// </summary>
        /// <param name="sessionFactoryConfigPath">SessionFactory's files config path</param>
        public void CommitTransactionOn(string sessionFactoryConfigPath)
        {
            Logger.Debug("CommitTransactionOn started at " + DateTime.Now.ToString());

            sessionFactoryConfigPath = this.GetConfigFullPath(sessionFactoryConfigPath);
            ITransaction transaction = (ITransaction)ContextTransactions[sessionFactoryConfigPath];

            try
            {
                if (HasOpenTransactionOn(sessionFactoryConfigPath))
                {
                    transaction.Commit();
                    ContextTransactions.Remove(sessionFactoryConfigPath);
                }
            }
            catch (HibernateException ex)
            {
                RollbackTransactionOn(sessionFactoryConfigPath);
                Logger.Error("Error at CommitTransactionOn", ex);
                throw;
            }

            Logger.Debug("CommitTransactionOn ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Gets the Session based on a config file.
        /// </summary>
        /// <param name="sessionFactoryConfigPath">SessionFactory's files config path</param>
        /// <returns>Returns <see cref="ISession" /></returns>
        public ISession GetSessionFrom(string sessionFactoryConfigPath)
        {
            ISession iSession;

            try
            {
                sessionFactoryConfigPath = this.GetConfigFullPath(sessionFactoryConfigPath);
                iSession = GetSessionFrom(sessionFactoryConfigPath, null);
            }
            catch (HibernateException hex)
            {
                Logger.Error("Error at GetSessionFrom - HibernateException", hex);
                throw;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSessionFrom - Exception", ex);
                throw;
            }

            return iSession;
        }

        /// <summary>
        /// Checks if there are any Transactions which are open based on the config file's path given.
        /// </summary>
        /// <param name="sessionFactoryConfigPath">SessionFactory's files config path</param>
        /// <returns>Returns true if any transaction is open, else false.</returns>
        public bool HasOpenTransactionOn(string sessionFactoryConfigPath)
        {
            sessionFactoryConfigPath = this.GetConfigFullPath(sessionFactoryConfigPath);
            ITransaction transaction = (ITransaction)ContextTransactions[sessionFactoryConfigPath];

            return transaction != null && !transaction.WasCommitted && !transaction.WasRolledBack;
        }

        /// <summary>
        /// Allows you to register an interceptor on a new session.  This may not be called if there is already
        /// an open session attached to the HttpContext.  If you have an interceptor to be used, modify
        /// the HttpModule to call this before calling BeginTransaction().
        /// </summary>
        public void RegisterInterceptorOn(string sessionFactoryConfigPath, IInterceptor interceptor)
        {
            sessionFactoryConfigPath = this.GetConfigFullPath(sessionFactoryConfigPath);
            ISession session = (ISession)ContextSessions[sessionFactoryConfigPath];

            if (session != null && session.IsOpen)
            {
                throw new CacheException("You cannot register an interceptor once a session has already been opened");
            }

            GetSessionFrom(sessionFactoryConfigPath, interceptor);
        }

        /// <summary>
        /// Rollback's the Transactions which are open based on the config file's path given.
        /// </summary>
        /// <param name="sessionFactoryConfigPath">SessionFactory's files config path</param>
        public void RollbackTransactionOn(string sessionFactoryConfigPath)
        {
            sessionFactoryConfigPath = this.GetConfigFullPath(sessionFactoryConfigPath);
            ITransaction transaction = (ITransaction)ContextTransactions[sessionFactoryConfigPath];

            try
            {
                if (HasOpenTransactionOn(sessionFactoryConfigPath))
                {
                    transaction.Rollback();
                }

                ContextTransactions.Remove(sessionFactoryConfigPath);
            }
            catch (HibernateException hex)
            {
                Logger.Error("Error at RollbackTransactionOn - HibernateException", hex);
                throw;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at RollbackTransactionOn - Exception", ex);
                throw;
            }
            finally
            {
                CloseSessionOn(sessionFactoryConfigPath);
            }
        }

        /// <summary>
        /// Gets the config full path.
        /// </summary>
        /// <param name="configRelativePath">The config relative path.</param>
        /// <returns>Returns the Hibernate.config's full path</returns>
        private string GetConfigFullPath(string configRelativePath)
        {
            string path;

            if (string.IsNullOrEmpty(configRelativePath))
                throw new ArgumentException("String is null or empty", "configRelativePath");

            path = Path.IsPathRooted(configRelativePath) ? configRelativePath : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configRelativePath);

            return path;
        }

        /// <summary>
        /// This method attempts to find a session factory stored in <see cref="sessionFactories" />
        /// via its name; if it can't be found it creates a new one and adds it the hashtable.
        /// </summary>
        /// <param name="sessionFactoryConfigPath">Path location of the factory config</param>
        private ISessionFactory GetSessionFactoryFor(string sessionFactoryConfigPath)
        {
            ISessionFactory sessionFactory;

            Check.Require(!string.IsNullOrEmpty(sessionFactoryConfigPath),
                "sessionFactoryConfigPath may not be null nor empty");

            sessionFactoryConfigPath = this.GetConfigFullPath(sessionFactoryConfigPath);

            try
            {
                //  Attempt to retrieve a stored SessionFactory from the hashtable.
                sessionFactory = (ISessionFactory)sessionFactories[sessionFactoryConfigPath];

                //  Failed to find a matching SessionFactory so make a new one.
                if (sessionFactory == null)
                {
                    Check.Require(File.Exists(sessionFactoryConfigPath),
                        "The config file at '" + sessionFactoryConfigPath + "' could not be found");

                    lock (LockMe)
                    {
                        if (!sessionFactories.ContainsKey(sessionFactoryConfigPath))
                        {

                            Logger.Error("Session Factory is null so creating a new SessionFactory");


                            Configuration cfg = new Configuration();
                            cfg.Configure(sessionFactoryConfigPath);

                            //  Now that we have our Configuration object, create a new SessionFactory
                            sessionFactory = cfg.BuildSessionFactory();

                            if (sessionFactory == null)
                            {
                                throw new InvalidOperationException("cfg.BuildSessionFactory() returned null.");
                            }
                            Logger.Error("Session Factory is built");
                            if (!sessionFactories.ContainsKey(sessionFactoryConfigPath))
                            {

                                sessionFactories.Add(sessionFactoryConfigPath, sessionFactory);
                                Logger.Error("SessionFactory Count is " + sessionFactories.Count);
                            }
                        }
                        else
                        {
                            Logger.Error("No Need to Build the SessionFactory ,Retrieving from Hashtable");
                            sessionFactory = (ISessionFactory)sessionFactories[sessionFactoryConfigPath];
                        }
                        
                    }
                }
                
            }
            catch (HibernateException hex)
            {
                Logger.Error("Error at GetSessionFactoryFor - HibernateException", hex);
                throw;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSessionFactoryFor - Exception", ex);
                throw;
            }

            return sessionFactory;
        }

        /// <summary>
        /// Gets a session with or without an interceptor.  This method is not called directly; instead,
        /// it gets invoked from other public methods.
        /// </summary>
        private ISession GetSessionFrom(string sessionFactoryConfigPath, IInterceptor interceptor)
        {
            sessionFactoryConfigPath = this.GetConfigFullPath(sessionFactoryConfigPath);
            ISession session = (ISession)ContextSessions[sessionFactoryConfigPath];

            if (session == null)
            {

                if (interceptor != null)
                {
                    session = GetSessionFactoryFor(sessionFactoryConfigPath).OpenSession(interceptor);
                }
                else
                {
                    session = GetSessionFactoryFor(sessionFactoryConfigPath).OpenSession();
                }

                ContextSessions[sessionFactoryConfigPath] = session;
            }

            Check.Ensure(session != null, "session was null");

            return session;
        }

        /// <summary>
        /// To check whether the context is running in web.
        /// </summary>
        /// <returns>Return's true if the Context is in web, else false.</returns>
        private bool IsInWebContext()
        {
            return HttpContext.Current != null;
        }

        #endregion Methods

        #region Nested Types

        /// <summary>
        /// Assists with ensuring thread-safe, lazy singleton
        /// </summary>
        private class Nested
        {
            #region Fields

            /// <summary>
            /// NHibernateSessionManager instance.
            /// </summary>
            internal static readonly NHibernateSessionManager NHibernateSessionManager =
                new NHibernateSessionManager();

            #endregion Fields

            #region Constructors

            /// <summary>
            /// Initializes the <see cref="Nested"/> class.
            /// </summary>
            static Nested()
            {
            }

            #endregion Constructors
        }

        #endregion Nested Types
    }
}