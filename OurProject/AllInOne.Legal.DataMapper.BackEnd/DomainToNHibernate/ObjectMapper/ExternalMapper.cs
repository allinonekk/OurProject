#region Header

/*****************************************************************************************************
* Description : This file represents a object mapper Document entities. This class will map Object to InterfaceICAEntity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   15/10/2010   		      Nithin                	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ExternalMapper.cs
// Description: This file represents a object mapper Document entities. This class will map Object to InterfaceICAEntity.
// </summary>
// <copyright file= "ExternalMapper.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;
    using log4net;

    public class ExternalMapper
    {
        #region Fields

        private static ExternalMapping externalMapping = new ExternalMapping();

        private static readonly ILog Logger = LogManager.GetLogger(typeof(ExternalMapper));
        #endregion Fields

        #region Methods

        public static InterfaceICA GetInterfaceICA(InterfaceICAEntity interfaceICAEntity)
        {
            InterfaceICA interfaceICA = null;
            try
            {

                interfaceICA = Mapper.Map<InterfaceICAEntity, InterfaceICA>(interfaceICAEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetInterfaceICA", ex);
                throw;
            }
            return interfaceICA;
        }

        #endregion Methods
    }
}