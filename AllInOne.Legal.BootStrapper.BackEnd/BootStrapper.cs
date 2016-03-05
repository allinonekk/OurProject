#region Header

/*****************************************************************************************************
* Description : This file represents a standard global boot strapper for application startup calls.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   27/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: BootStrapper.cs
// Description: Represents a standard global boot strapper for application startup calls.
// </summary>
// <copyright file= "BootStrapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.BootStrapper.BackEnd
{
    using System;
    using System.IO;

    using AllInOne.Legal.Binder.BackEnd;

    using AllInOne.Common.Library.Binder;

    using log4net;
    using log4net.Config;

    /// <summary>
    /// Represents a standard global boot strapper for application startup calls.
    /// </summary>
    public class BootStrapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static ILog logger;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Catches application-wide error.
        /// </summary>
        /// <param name="exception">The exception.</param>
        public static void CatchApplicationError(Exception exception)
        {
            if (exception == null)
            {
                logger.Error("Unknown application error occurred!");
            }
            else
            {
                logger.Error("Caught application error: ", exception);
            }
        }

        /// <summary>
        /// Configures the Log4Net logger.
        /// </summary>
        /// <param name="path">The path.</param>
        public static void ConfigLogger(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                var configFile = new FileInfo(path);
                if (configFile.Exists)
                {
                    // The log4net config can be updated and take effect without refreshing the server.
                    XmlConfigurator.ConfigureAndWatch(configFile);
                }
                else
                {
                    XmlConfigurator.Configure();
                }              
            }
            logger = LogManager.GetLogger(typeof(BootStrapper));
            logger.Info("Configured the Log4Net Logging System!");
        }

        /// <summary>
        /// This method calls other project specific methods to perform action during application shutdown.
        /// </summary>
        public static void Shutdown()
        {
            logger.Info("Shutting down the application...");
            IBinder binder = BinderSingleton.Instance;

            if (binder == null)
            {
                logger.Fatal("Something serious happened to produce a null binder. Aborting application shutdown now!");
                return;
            }

            binder.Stop();
            binder.Cleanup();
        }

        /// <summary>
        /// This method calls other project specific methods to perform action during application startup.
        /// </summary>
        public static void StartUp()
        {
            logger.Info("Starting up the application...");
            // Call for binder.
            IBinder binder = BinderSingleton.Instance;

            if (binder == null)
            {
                logger.Fatal("Something serious happened to produce a null binder. Aborting application startup now!");
                return;
            }

            binder.Init();
            binder.Start();

            // Call for data mapper.
            logger.Info("DataMapper call");
            DataMapperConfigurator dataMapperConfigurator = new DataMapperConfigurator();
            if (dataMapperConfigurator.IsEnabled)
            {
                logger.Info("DataMapperConfigurator started at " + DateTime.Now);

                dataMapperConfigurator.Configure();

                logger.Info("DataMapperConfigurator ended at " + DateTime.Now);
            }
        }

        #endregion Methods
    }
}