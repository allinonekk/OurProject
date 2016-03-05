#region Header

/*****************************************************************************************************
* Description : This file represents <see cref="SessionFactoryElement" /> having property of Name,
* ConfigPath and whether Transactional or not.
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
// File: SessionFactoryElement.cs
// Description: Class which represents <see cref="SessionFactoryElement" /> having property of Name,
// ConfigPath and whether Transactional or not.
// Refer http://www.codeproject.com/KB/architecture/NHibernateBestPractices.aspx for original post.
// </summary>
// <copyright file= "SessionFactoryElement.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Common.DataAccess.NHibernate
{
    using System.Configuration;

    using Configuration_StringValidator = System.Configuration.StringValidator;

    /// <summary>
    /// Implements the <see cref="SessionFactoryElement" /> for managing custom
    /// session factory, having property of Name,
    /// ConfigPath and whether Transactional or not.
    /// </summary>
    public class SessionFactoryElement : ConfigurationElement
    {
        #region Constructors

        /// <summary>
        /// Base Constructor
        /// </summary>
        public SessionFactoryElement()
        {
        }

        /// <summary>
        /// Constructor which depends on the name and configpath of the file.
        /// </summary>
        /// <param name="name">Name of the session.</param>
        /// <param name="configPath">Session Providers file's config path</param>
        public SessionFactoryElement(string name, string configPath)
        {
            Name = name;
            FactoryConfigPath = configPath;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Property FactoryConfigPath.
        /// </summary>
        [ConfigurationProperty("factoryConfigPath", IsRequired = true, DefaultValue = "Not Supplied")]
        public string FactoryConfigPath
        {
            get { return (string)this["factoryConfigPath"]; }
            set { this["factoryConfigPath"] = value; }
        }

        /// <summary>
        /// Property IsTransactional.
        /// </summary>
        [ConfigurationProperty("isTransactional", IsRequired = false, DefaultValue = false)]
        public bool IsTransactional
        {
            get { return (bool)this["isTransactional"]; }
            set { this["isTransactional"] = value; }
        }

        /// <summary>
        /// Property Name.
        /// </summary>
        [ConfigurationProperty("name", IsRequired = true, IsKey = true, DefaultValue = "Not Supplied")]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        #endregion Properties
    }
}