#region Header

/*****************************************************************************************************
* Description : This file handles methods for retrieving the SessionFactory, which is configured.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   02/08/2010   		        Swaroop             	Created
*   05/08/2010                  Nithin                  Logger Implementation
*   28/09/2010                  Swaroop                 Changed name of the method GetSessionFactoryFromName
 *                                                      to GetSessionFactoryElementFromName
*****************************************************************************************************/
// <summary>
// File: SessionFactoryManager.cs
// Description: Handles methods for retrieving the SessionFactory, which is configured.
// </summary>
// <copyright file= "SessionFactoryManager.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Common.DataAccess.NHibernate
{
    using System;
    using System.Configuration;

    using AllInOne.Common.DataAccess.Utilities;

    using log4net;

    /// <summary>
    /// Handles methods for retrieving the SessionFactory, which is configured.
    /// </summary>
    public sealed class SessionFactoryManager : IDisposable
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SessionFactoryManager));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
        }

        /// <summary>
        /// Method to get <see cref="OpenSessionInViewSection" /> which gives <see cref="SessionFactoriesCollection" />.
        /// </summary>s
        /// <returns></returns>
        public OpenSessionInViewSection GetOpenSessionInViewSection()
        {
            OpenSessionInViewSection openSessionInViewSection = ConfigurationManager
                .GetSection("nhibernateSettings") as OpenSessionInViewSection;

            Check.Ensure(openSessionInViewSection != null,
                "The nhibernateSettings section was not found with ConfigurationManager.");

            return openSessionInViewSection;
        }

        /// <summary>
        /// Method to get the <see cref="SessionFactoryElement" /> based on the <see cref="DataBaseConnectivity" />.
        /// </summary>
        /// <param name="dataBaseConnectivity">DataBaseConnectivity for which <see cref="SessionFactoryElement" /> to be retrieved.</param>
        /// <returns>Returns <see cref="SessionFactoryElement" />.</returns>
        public SessionFactoryElement GetSessionFactoryElementFromName(DataBaseConnectivity dataBaseConnectivity)
        {
            Check.Require(!string.IsNullOrEmpty(dataBaseConnectivity.ToString()),
                "DataBaseConnectivity should not be null nor empty");

            OpenSessionInViewSection openSessionInViewSection = GetOpenSessionInViewSection();

            SessionFactoryElement sessionFactoryElement = null;

            try
            {
                // Loop through all the SessionFactoryElements and find the one which matched with the DataBaseConnectivity.
                foreach (SessionFactoryElement sessionFactorySettings in openSessionInViewSection.SessionFactories)
                {
                    if (sessionFactorySettings.Name == dataBaseConnectivity.ToString())
                    {
                        sessionFactoryElement = sessionFactorySettings;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSessionFactoryFromName: ", ex);
                throw;
            }

            Check.Require(sessionFactoryElement != null,
                "SessionFactoryElement should not be null nor empty");

            return sessionFactoryElement;
        }

        #endregion Methods
    }
}