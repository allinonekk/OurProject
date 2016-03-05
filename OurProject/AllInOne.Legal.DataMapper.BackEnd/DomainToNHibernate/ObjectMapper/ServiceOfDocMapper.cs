#region Header

/*****************************************************************************************************
* Description : This file represents a object mapper Case entities. This class will map Object to
* Entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   29/10/2010   		      Narayan                	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CaseMapper.cs
// Description: This file represents a object mapper Service Of Doc Info entities. This class will map Object to
// Entity.
// </summary>
// <copyright file= "ServiceOfDocMapper.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using log4net;

    public class ServiceOfDocMapper
    {
        #region Fields

        private static ServiceOfDocMapping serviceOfDocMapping = new ServiceOfDocMapping();

        private static readonly ILog Logger = LogManager.GetLogger(typeof(ServiceOfDocMapper));
        #endregion Fields

        #region Constructors

        public ServiceOfDocMapper()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Maps the entities to domain.
        /// </summary>
        /// <param name="ServiceOfDocDocStatusHistoryEntity">The Service Of Document Status History.</param>
        /// <returns>Returns the <see cref="ServiceOfDocDocStatusHistoryEntity"/>, else null.</returns>
        public static ServiceOfDocDocStatusHistory GetServiceOfDocDocStatusHistory(ServiceOfDocDocStatusHistoryEntity serviceOfDocDocStatusHistoryDomainEntity)
        {
            ServiceOfDocDocStatusHistory serviceOfDocDocStatusHistoryNHibernateEntity = null;

            try
            {
                if (serviceOfDocDocStatusHistoryDomainEntity != null)
                {
                    serviceOfDocDocStatusHistoryNHibernateEntity = Mapper.Map<ServiceOfDocDocStatusHistoryEntity, ServiceOfDocDocStatusHistory>(serviceOfDocDocStatusHistoryDomainEntity);
                    serviceOfDocDocStatusHistoryNHibernateEntity.MServeStatus = Mapper.Map<MServeStatusEntity, MServeStatus>(serviceOfDocDocStatusHistoryDomainEntity.MServeStatus);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetServiceOfDocDocStatusHistory", ex);
                throw;
            }

            return serviceOfDocDocStatusHistoryNHibernateEntity;
        }

        public static ServiceOfDocDocument GetServiceOfDocDocument(ServiceOfDocDocumentEntity serviceOfDocDocumentEntity)
        {
            ServiceOfDocDocument serviceOfDocDocument = null;

            try
            {
                if (serviceOfDocDocumentEntity != null)
                {
                    serviceOfDocDocument = Mapper.Map<ServiceOfDocDocumentEntity, ServiceOfDocDocument>(serviceOfDocDocumentEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetServiceOfDocDocument", ex);
                throw;
            }

            return serviceOfDocDocument;
        }

        /// <summary>
        /// Maps the entities to domain.
        /// </summary>
        /// <param name="ServiceOfDocInfoEntity">The Service Of Document.</param>
        /// <returns>Returns the <see cref="ServiceOfDocInfoEntity"/>, else null.</returns>
        public static ServiceOfDocInfo GetServiceOfDocInfo(ServiceOfDocInfoEntity serviceOfDocInfoDomainEntity)
        {
            ServiceOfDocInfo serviceOfDocInfoNHibernateEntity = null;

            try
            {
                if (serviceOfDocInfoDomainEntity != null)
                {
                    serviceOfDocInfoNHibernateEntity = Mapper.Map<ServiceOfDocInfoEntity, ServiceOfDocInfo>(serviceOfDocInfoDomainEntity);
                    serviceOfDocInfoNHibernateEntity.MServeStatus = Mapper.Map<MServeStatusEntity, MServeStatus>(serviceOfDocInfoDomainEntity.MServeStatus);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetServiceOfDocInfo", ex);
                throw;
            }

            return serviceOfDocInfoNHibernateEntity;
        }

        public static ServiceOfDocInfoDetail GetServiceOfDocInfoDetail(ServiceOfDocInfoDetailEntity serviceOfDocInfoDetailEntity)
        {
            ServiceOfDocInfoDetail serviceOfDocInfoDetail = null;

            try
            {
                if (serviceOfDocInfoDetailEntity != null)
                {
                    serviceOfDocInfoDetail = Mapper.Map<ServiceOfDocInfoDetailEntity, ServiceOfDocInfoDetail>(serviceOfDocInfoDetailEntity);
                    serviceOfDocInfoDetail.MCountry = Mapper.Map<MCountryEntity, MCountry>(serviceOfDocInfoDetailEntity.MCountry);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetServiceOfDocInfoDetail", ex);
                throw;
            }

            return serviceOfDocInfoDetail;
        }

        #endregion Methods
    }
}