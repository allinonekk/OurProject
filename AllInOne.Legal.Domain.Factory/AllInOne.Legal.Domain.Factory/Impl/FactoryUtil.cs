#region Header

/*****************************************************************************************************
 * Description : This file represents a standard set of utilities.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 04/10/2010                 Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: FactoryUtil.cs
// Description: Represents a standard set of utilities.
// </summary>
// <copyright file= "FactoryUtil.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory.Impl
{
    using System;

    using AllInOne.Common.Library.Repository;

    using log4net;

    /// <summary>
    /// Represents a standard set of utilities.
    /// </summary>
    internal class FactoryUtil
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(FactoryUtil));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method to create the primary key.
        /// </summary>
        /// <param name="applicationEnvironment">The application environment.</param>
        /// <returns>Returns primary key value.</returns>
        public static string GetPrimaryKey(ApplicationEnvironment applicationEnvironment)
        {
            string primaryKey;

            try
            {
                primaryKey = string.Format("{0}{1}{2}", applicationEnvironment.ToString(),
                    RepositoryUtil.GetFormattedLongDateTime("yyyyMMddHHmmssffffff"),
                    RepositoryUtil.GetCryptographicRandomCharacterGenerator(8));
            }
            catch (Exception exception)
            {
                Logger.Error("Error at GetPrimaryKey", exception);
                throw;
            }

            return primaryKey;
        }

        #endregion Methods
    }
}