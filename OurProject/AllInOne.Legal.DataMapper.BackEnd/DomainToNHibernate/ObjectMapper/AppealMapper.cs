#region Header

/*****************************************************************************************************
* Description : This file represents a object mapper Appeal entities. This class will map Object to
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
// File: AppealMapper.cs
// Description: This file represents a object mapper Appeal entities. This class will map Object to
// Entity.
// </summary>
// <copyright file= "AppealMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using log4net;

    public class AppealsMapper
    {
        #region Fields

        private static AppealMapping appealMapping = new AppealMapping();

        private static readonly ILog Logger = LogManager.GetLogger(typeof(AppealsMapper));

        #endregion Fields

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="admInfoDomainEntity"></param>
        /// <returns></returns>
        public static DCACAInfo GetDCACAInfoEntity(DCACAInfoEntity dcacaInfoDomainEntity)
        {
            DCACAInfo dcacaInfoNHibernateEntity = null;

            try
            {
                //appealMapping.MapDCACAInfoToDCACAInfoEntity();
                dcacaInfoNHibernateEntity = Mapper.Map<DCACAInfoEntity, DCACAInfo>(dcacaInfoDomainEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDCACAInfoEntity", ex);
                throw;
            }

            return dcacaInfoNHibernateEntity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="refCaveatCase"></param>
        /// <returns></returns>
        public static RARASInfo GetRARASInfoEntity(RARASInfoEntity rarasInfoDomainEntity)
        {
            RARASInfo rarasInfoNHibernateEntity = null;

            try
            {
                //appealMapping.MapRARASInfoToRARASInfoEntity();
                rarasInfoNHibernateEntity = Mapper.Map<RARASInfoEntity, RARASInfo>(rarasInfoDomainEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRARASInfoEntity", ex);
                throw;
            }

            return rarasInfoNHibernateEntity;
        }

        #endregion Methods
    }
}