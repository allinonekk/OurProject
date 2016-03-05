#region Header

/*****************************************************************************************************
* Description : Class which implements <see cref="IUnitOfWork" />, where it gets the session and
* related transaction for database insert, update, etc. through NHibernate.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   02/08/2010   		        Swaroop             	Created
*   28/09/2010                  Swaroop                 Removed unused DataBaseConnectivity property.
*
*****************************************************************************************************/
// <summary>
// File: UnitOfWorkImpl.cs
// Description: Class which implements <see cref="IUnitOfWork" />, where it gets the session and
// related transaction for database insert, update, etc. through NHibernate.
// </summary>
// <copyright file= "UnitOfWorkImpl.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

using System;

using AllInOne.Common.DataAccess.Utilities;

using log4net;

using NHibernate;

namespace AllInOne.Common.DataAccess.NHibernate
{
    /// <summary>
    /// Class which implements <see cref="IUnitOfWork" />, where it gets the session and related transaction for
    /// database insert, update, etc. through NHibernate.
    /// </summary>
    public class UnitOfWorkImpl : IUnitOfWork
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
        /// Initializes a new instance of the <see cref="UnitOfWorkImpl"/> class.
        /// </summary>
        /// <param name="dataBaseConnectivity"><see cref="DataBaseConnectivity" /> to be used for getting the <see cref="SessionFactoryElement" /></param>
        public UnitOfWorkImpl(DataBaseConnectivity dataBaseConnectivity)
        {
            Check.Require(!string.IsNullOrEmpty(dataBaseConnectivity.ToString()),
                "DataBaseConnectivity should not be null nor empty");

            this.sessionFactoryElement = this.GetSessionFactoryElementFromName(dataBaseConnectivity);

            Check.Require(!string.IsNullOrEmpty(this.sessionFactoryElement.Name) && !string.IsNullOrEmpty(this.sessionFactoryElement.FactoryConfigPath),
                "SessionFactoryElement's Name and FactoryConfigPath should not be null nor empty");

            this.Session = NHibernateSessionManager.Instance.GetSessionFrom(this.sessionFactoryElement.FactoryConfigPath);
            NHibernateSessionManager.Instance.BeginTransactionOn(this.sessionFactoryElement.FactoryConfigPath);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// To store <see cref="ISession" />
        /// </summary>
        public ISession Session
        {
            get; set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Method which commits the data into DB, for the related transaction.
        /// If the referenced transaction is not Active or is null, it will throw
        /// <see cref="InvalidOperationException" /> exception.
        /// </summary>
        public void Commit()
        {
            NHibernateSessionManager.Instance.CommitTransactionOn(this.sessionFactoryElement.FactoryConfigPath);
        }

        /// <summary>
        /// Method which disposes the transaction.
        /// If the referenced transaction is not Active or is null, it will throw
        /// <see cref="InvalidOperationException" /> exception.
        /// </summary>
        public void Dispose()
        {
            // No specific session.close() is called, as session will be closed when
            // NHibernateSessionManager.CloseSessionOn method is called from NHibernateSessionModule.
            NHibernateSessionManager.Instance.CloseSessionOn(this.sessionFactoryElement.FactoryConfigPath);
        }

        /// <summary>
        /// Method which rollbacks the data in DB, for the related transaction.
        /// If the referenced transaction is not Active or is null, it will throw
        /// <see cref="InvalidOperationException" /> exception.
        /// </summary>
        public void Rollback()
        {
            NHibernateSessionManager.Instance.RollbackTransactionOn(this.sessionFactoryElement.FactoryConfigPath);
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

            using (SessionFactoryManager sfm = new SessionFactoryManager())
            {
                sessionFactoryElement = sfm.GetSessionFactoryElementFromName(dataBaseConnectivity);
            }

            Check.Require(sessionFactoryElement != null,
                "SessionFactoryElement should not be null.");

            return sessionFactoryElement;
        }

        #endregion Methods
    }
}