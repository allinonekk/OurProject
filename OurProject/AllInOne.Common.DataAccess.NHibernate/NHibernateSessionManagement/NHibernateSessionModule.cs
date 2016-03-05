#region Header

/*****************************************************************************************************
* Description : This file handles implementation of Open-Session-In-View and Session per request pattern.
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
// File: NHibernateSessionModule.cs
// Description: Implements the Open-Session-In-View and Session per request pattern.
// Refer http://www.codeproject.com/KB/architecture/NHibernateBestPractices.aspx for original post.
// </summary>
// <copyright file= "NHibernateSessionModule.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Common.DataAccess.NHibernate
{
    using System;
    using System.Web;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;

    using log4net;

    /// <summary>
    /// Implements the Open-Session-In-View pattern using <see cref="NHibernateSessionManager" />.
    /// Inspiration for this class came from Ed Courtenay at 
    /// http://sourceforge.net/forum/message.php?msg_id=2847509.
    /// </summary>
    public class NHibernateSessionModule : IHttpModule
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(NHibernateSessionModule));

        /// <summary>
        /// ApplicationSessionManager instance for session.
        /// </summary>
        private ApplicationSessionManager applicationSessionManager;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Disposes the object.
        /// </summary>
        public void Dispose()
        {
        }

        /// <summary>
        /// Method invoked on the Load of the page, which initializes Begin and End Request.
        /// </summary>
        /// <param name="context">Current HTTP context <see cref="HttpApplication" /></param>
        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(BeginTransaction);
            context.EndRequest += new EventHandler(CommitAndCloseSession);
        }

        /// <summary>
        /// Opens a session within a transaction at the beginning of the HTTP request.  Note that 
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        /// <param name="sender"></param>
        private void BeginTransaction(object sender, EventArgs e)
        {
            this.applicationSessionManager = new ApplicationSessionManager();
            this.applicationSessionManager.BeginTransaction();
        }

        /// <summary>
        /// Commits and closes the NHibernate session provided by the supplied <see cref="NHibernateSessionManager"/>.
        /// Assumes a transaction was begun at the beginning of the request; but a transaction or session does
        /// not *have* to be opened for this to operate successfully.
        /// </summary>
        private void CommitAndCloseSession(object sender, EventArgs e)
        {
            this.applicationSessionManager = new ApplicationSessionManager();
            this.applicationSessionManager.CommitAndCloseSession();
        }

        #endregion Methods
    }
}