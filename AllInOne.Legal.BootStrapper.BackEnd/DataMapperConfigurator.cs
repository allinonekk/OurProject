#region Header

/*****************************************************************************************************
* Description : This file represents a standard global call to data mapper.
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
// File: DataMapperConfigurator.cs
// Description: Represents a standard global call to data mapper.
// </summary>
// <copyright file= "DataMapperConfigurator.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.BootStrapper.BackEnd
{
    using System;

    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate;
    using AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain;

    /// <summary>
    /// Represents a standard global call to data mapper.
    /// </summary>
    public class DataMapperConfigurator : IStartUpTask
    {
        #region Properties

        /// <summary>
        /// Gets a value indicating whether this instance is enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsEnabled
        {
            get { return true; }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Configures this instance.
        /// </summary>
        public void Configure()
        {
            MapAllNHibernateToDomain nHibernateToDomainMapping = new MapAllNHibernateToDomain();
            nHibernateToDomainMapping.MapAll();

            MapAllDomainToNHibernate domainToNHibernateMapping = new MapAllDomainToNHibernate();
            domainToNHibernateMapping.MapAll();
        }

        #endregion Methods
    }
}