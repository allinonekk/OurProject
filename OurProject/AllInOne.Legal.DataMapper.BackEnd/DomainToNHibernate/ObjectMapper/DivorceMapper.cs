#region Header

/*****************************************************************************************************
* Description : This file represents a object mapper Divorce entities. This class will map Object to
* Entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   23/09/2010   		      Nai                	 	Created
*
*****************************************************************************************************/
// <summary>
// File: DivorceMapper.cs
// Description: This file represents a object mapper Divorce entities. This class will map Object to
// Entity.
// </summary>
// <copyright file= "DivorceMapper.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Entities.BackEnd;
    using log4net;

    class DivorceMapper
    {
        #region Fields

        private static DivorceMapping divorceMapping = new DivorceMapping();

        private static readonly ILog Logger = LogManager.GetLogger(typeof(ExternalMapper));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Get the Child Info Domain Entity.
        /// </summary>
        /// <param name="childInfoDomainEntity"></param>
        /// <returns></returns>
        public static ChildInfoEntity GetChildInfoEntity(ChildInfo childInfoDomainEntity)
        {
            ChildInfoEntity childInfoNHibernateEntity = null;

            try
            {
                //divorceMapping.MapChildInfoToChildInfoEntity();
                childInfoNHibernateEntity = Mapper.Map<ChildInfo, ChildInfoEntity>(childInfoDomainEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetChildInfoEntity", ex);
                throw;
            }

            return childInfoNHibernateEntity;
        }

        /// <summary>
        /// Get the Divorce Info Domain Entity.
        /// </summary>
        /// <param name="divorceInfoDomainEntity"></param>
        /// <returns></returns>
        public static DivorceInfoEntity GetDivorceInfoEntity(DivorceInfo divorceInfoDomainEntity)
        {
            DivorceInfoEntity dcacaInfoNHibernateEntity = null;

            try
            {
               dcacaInfoNHibernateEntity = Mapper.Map<DivorceInfo, DivorceInfoEntity>(divorceInfoDomainEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDivorceInfoEntity", ex);
                throw;
            }

            return dcacaInfoNHibernateEntity;
        }

        /// <summary>
        /// Get the Related Procedding Domain Entity.
        /// </summary>
        /// <param name="relatedProceedingNHibernateEntity"></param>
        /// <returns></returns>
        public static RelatedProceedingEntity GetRelatedProceedingEntity(RelatedProceeding relatedProceedingNHibernateEntity)
        {
            RelatedProceedingEntity relatedProceedingDomainEntity = null;

            try
            {
                //divorceMapping.MapRelatedProceedingToRelatedProceedingEntity();
                relatedProceedingDomainEntity = Mapper.Map<RelatedProceeding, RelatedProceedingEntity>(relatedProceedingNHibernateEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRelatedProceedingEntity", ex);
                throw;
            }

            return relatedProceedingDomainEntity;
        }

        #endregion Methods
    }
}