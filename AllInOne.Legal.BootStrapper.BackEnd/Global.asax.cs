#region Header

/*****************************************************************************************************
* Description : This file represents a standard global class used for application startup functionalities.
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
// File: Global.cs
// Description: Represents a standard global class used for application startup functionalities.
// </summary>
// <copyright file= "Global.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.BootStrapper.BackEnd
{
    using System;
    using System.Configuration;
    using System.Web;
    using System.Web.Security;
    using System.Web.SessionState;

    //using Microsoft.SharePoint;
    //using Microsoft.SharePoint.ApplicationRuntime;

    /// <summary>
    /// Represents a standard global class used for application startup functionalities.
    /// </summary>
    public class Global : HttpApplication
    {
        #region Methods

        /// <summary>
        /// Handles the AuthenticateRequest event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the BeginRequest event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the End event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Application_End(object sender, EventArgs e)
        {
            // Code that runs on application shutdown
            // Call to BootStrapper for configuring various startups.
            BootStrapper.Shutdown();
        }

        /// <summary>
        /// Handles the Error event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
            HttpContext context = HttpContext.Current;
            Exception exception = Context.Server.GetLastError();

            BootStrapper.CatchApplicationError(exception);
            context.Server.ClearError();
        }

        /// <summary>
        /// Handles the Start event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Application_Start(object sender, EventArgs e)
        {
            // Call to BootStrapper for configuring various startups.
            // Code that runs on application startup
            string log4netConfigFile = ConfigurationManager.AppSettings["LogConfigFileLocation"];
            BootStrapper.ConfigLogger(log4netConfigFile);
            BootStrapper.StartUp();
        }

        /// <summary>
        /// Handles the End event of the Session control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Session_End(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Start event of the Session control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Session_Start(object sender, EventArgs e)
        {
        }

        #endregion Methods
    }
}