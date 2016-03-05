#region Header

/*****************************************************************************************************
* Description : This file handles mapping for CWU from Domain objects to NHibernate entities.
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
// File: CWUMapping.cs
// Description: This file handles mapping for CWU from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "CWUMapping.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for CWU from Domain objects to NHibernate entities.
    /// </summary>
    internal class CWUMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CWUMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method which maps the <see cref="CWUInfoEntity"/> to <see cref="CWUInfo"/>.
        /// </summary>
        internal void MapCWUInfoEntityToCWUInfo()
        {
            try
            {
                Mapper.CreateMap<CWUInfoEntity, CWUInfo>()
                    .ForMember(desc => desc.CWUInfoId, opts => opts.MapFrom(src => src.CWUInfoId))
                    .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(desc => desc.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(desc => desc.WindingType, opts => opts.ResolveUsing<WindingTypeToStringResolver>().FromMember(src => src.WindingType));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCWUInfoEntityToCWUInfo", ex);
                throw;
            }
        }

        #endregion Methods
    }
}