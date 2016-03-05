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
*   04/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: RepositoryUtil.cs
// Description: Represents a standard set of Repository utilities.
// </summary>
// <copyright file= "RepositoryUtil.cs" company="CrimsonLogic Pte Ltd">
// Copyright (C) 2010 CrimsonLogic Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Common.Library.Repository
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    using log4net;

    /// <summary>
    /// Class for providing common utility methods, which can be used within any .net environment.
    /// </summary>
    public sealed class RepositoryUtil
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RepositoryUtil));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the Cryptographic Random Character generated string.
        /// Developed by http://www.codeproject.com/KB/aspnet/UniqueKeys.aspx.
        /// </summary>
        /// <param name="characterLength">Length of the character.</param>
        /// <returns>A string with generated key.</returns>
        public static string GetCryptographicRandomCharacterGenerator(int characterLength)
        {
            StringBuilder returnValue;

            try
            {
                int maxSize = characterLength;
                const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                char[] chars = characters.ToCharArray();
                var data = new byte[1];

                var crypto = new RNGCryptoServiceProvider();
                crypto.GetNonZeroBytes(data);

                int size = maxSize;
                data = new byte[size];
                crypto.GetNonZeroBytes(data);
                var result = new StringBuilder(size);

                foreach (var b in data)
                {
                    result.Append(chars[b % (chars.Length - 1)]);
                }

                returnValue = result;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCryptographicRandomCharacterGenerator", ex);
                throw;
            }

            return returnValue.ToString();
        }

        /// <summary>
        /// Gets the Full date time in the specified format.
        /// Example: yyyyMMddHHmmssffffff, ffffffssmmHHddMMyyyy, etc.
        /// </summary>
        /// <returns></returns>
        public static string GetFormattedLongDateTime(string format)
        {
            string returnValue;

            try
            {
                returnValue = DateTime.Now.ToString(format);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetFullDateTime", ex);
                throw;
            }

            return returnValue;
        }

        #endregion Methods
    }
}