#region Header

/*****************************************************************************************************
* Description : This file handles mapper for CWU from Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   11/10/2010   		        Nithin                  Created
*   27/10/2010                  Swaroop                 Added logging and comments.
*****************************************************************************************************/
// <summary>
// File: CWUMapper.cs
// Description: This file handles mapper for CWU from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "CWUMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for CWU from Domain objects to NHibernate entities.
    /// </summary>
    public class CWUMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CWUMapper));

        /// <summary>
        /// CWUMapping instance.
        /// </summary>
        private static CWUMapping cwuMapping = new CWUMapping();

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the <see cref="CWUInfo"/> from <see cref="CWUInfoEntity"/> input.
        /// </summary>
        /// <param name="cWUInfoEntity"><see cref="CWUInfoEntity"/></param>
        /// <returns>Returns <see cref="CWUInfo"/>, else null.</returns>
        public static CWUInfo GetCWUInfo(CWUInfoEntity cWUInfoEntity)
        {
            CWUInfo cWUInfo = null;

            try
            {
                cwuMapping.MapCWUInfoEntityToCWUInfo();
                cWUInfo = Mapper.Map<CWUInfoEntity, CWUInfo>(cWUInfoEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCWUInfo", ex);
                throw;
            }

            return cWUInfo;
        }

        #endregion Methods
    }
}