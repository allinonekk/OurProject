#region Header

/*****************************************************************************************************
* Description : This file handles the collection of custom session factory <see cref="SessionFactoryElement" />.
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
// File: SessionFactoriesCollection.cs
// Description: Implements the <see cref="ConfigurationElementCollection" /> for managing custom
// session factory element <see cref="SessionFactoryElement" />.
// Refer http://www.codeproject.com/KB/architecture/NHibernateBestPractices.aspx for original post.
// </summary>
// <copyright file= "SessionFactoriesCollection.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Common.DataAccess.NHibernate
{
    using System.Configuration;

    /// <summary>
    /// Implements the <see cref="ConfigurationElementCollection" /> for managing custom
    /// session factory element <see cref="SessionFactoryElement" />
    /// </summary>
    [ConfigurationCollection(typeof(SessionFactoryElement))]
    public sealed class SessionFactoriesCollection : ConfigurationElementCollection
    {
        #region Constructors

        /// <summary>
        /// Creates <see cref="SessionFactoryElement" /> and adds the same.
        /// </summary>
        public SessionFactoriesCollection()
        {
            SessionFactoryElement sessionFactory = (SessionFactoryElement)CreateNewElement();
            Add(sessionFactory);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Overriding method from <see cref="ConfigurationElementCollection" />'s ConfigurationElementCollectionType.
        /// </summary>
        public override ConfigurationElementCollectionType CollectionType
        {
            get {
                return ConfigurationElementCollectionType.AddRemoveClearMap;
            }
        }

        #endregion Properties

        #region Indexers

        /// <summary>
        /// Method which returns <see cref="SessionFactoryElement" /> based on the index.
        /// </summary>
        /// <param name="index">Index based on which to get the <see cref="SessionFactoryElement" /></param>
        /// <returns>Returns <see cref="SessionFactoryElement" /></returns>
        public SessionFactoryElement this[int index]
        {
            get {
                return (SessionFactoryElement)BaseGet(index);
            }
            set {
                if (BaseGet(index) != null) {
                    BaseRemoveAt(index);
                }

                BaseAdd(index, value);
            }
        }

        /// <summary>
        /// Gets the <see cref="AllInOne.Common.DataAccess.NHibernate.SessionFactoryElement"/> with the specified name.
        /// </summary>
        /// <value></value>
        public new SessionFactoryElement this[string name]
        {
            get {
                return (SessionFactoryElement)BaseGet(name);
            }
        }

        #endregion Indexers

        #region Methods

        /// <summary>
        /// Adds the specified session factory.
        /// </summary>
        /// <param name="sessionFactory">The session factory.</param>
        public void Add(SessionFactoryElement sessionFactory)
        {
            BaseAdd(sessionFactory);
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            BaseClear();
        }

        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="sessionFactory">The session factory.</param>
        /// <returns></returns>
        public int IndexOf(SessionFactoryElement sessionFactory)
        {
            return BaseIndexOf(sessionFactory);
        }

        /// <summary>
        /// Removes the specified session factory.
        /// </summary>
        /// <param name="sessionFactory">The session factory.</param>
        public void Remove(SessionFactoryElement sessionFactory)
        {
            if (BaseIndexOf(sessionFactory) >= 0) {
                BaseRemove(sessionFactory.Name);
            }
        }

        /// <summary>
        /// Removes the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        public void Remove(string name)
        {
            BaseRemove(name);
        }

        /// <summary>
        /// Removes at.
        /// </summary>
        /// <param name="index">The index.</param>
        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        /// <summary>
        /// Adds a configuration element to the <see cref="T:System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="element">The <see cref="T:System.Configuration.ConfigurationElement"/> to add.</param>
        protected override void BaseAdd(ConfigurationElement element)
        {
            BaseAdd(element, false);
        }

        /// <summary>
        /// Overriding method from <see cref="ConfigurationElementCollection" />'s ConfigurationElement.
        /// </summary>
        /// <returns>Returns <see cref="SessionFactoryElement" /></returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new SessionFactoryElement();
        }

        /// <summary>
        /// Overriding method from <see cref="ConfigurationElementCollection" />'s GetElementKey.
        /// </summary>
        /// <param name="element"></param>
        /// <returns>Returns <see cref="SessionFactoryElement" />'s Name.</returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((SessionFactoryElement)element).Name;
        }

        #endregion Methods
    }
}