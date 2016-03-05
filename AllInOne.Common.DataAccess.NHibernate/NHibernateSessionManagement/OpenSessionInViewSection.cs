#region Header

/*****************************************************************************************************
* Description : This file handles creation of session factories based on the configurations done in
* web.config file.
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
// File: OpenSessionInViewSection.cs
// Description: Creates session factories based on the configurations done in web.config file.
// Refer http://www.codeproject.com/KB/architecture/NHibernateBestPractices.aspx for original post.
// </summary>
// <copyright file= "OpenSessionInViewSection.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Common.DataAccess.NHibernate
{
    using System.Configuration;

    /// <summary>
    /// Encapsulates a section of Web/App.config to declare which session factories are to be created.
    /// Huge kudos go out to http://msdn2.microsoft.com/en-us/library/system.configuration.configurationcollectionattribute.aspx
    /// for this technique - it was by far the best overview of the subject.
    /// </summary>
    public class OpenSessionInViewSection : ConfigurationSection
    {
        #region Properties

        [ConfigurationProperty("sessionFactories", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(SessionFactoriesCollection), AddItemName = "sessionFactory",
            ClearItemsName = "clearFactories")]
        public SessionFactoriesCollection SessionFactories
        {
            get {
                SessionFactoriesCollection sessionFactoriesCollection =
                    (SessionFactoriesCollection)base["sessionFactories"];
                return sessionFactoriesCollection;
            }
        }

        #endregion Properties
    }
}