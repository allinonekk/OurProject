#region Header

/*****************************************************************************************************
* Description : This file represents a object mapper Bankruptcy entities. This class will map Object to
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
// File: BankruptcyMapper.cs
// Description: This file represents a object mapper Bankruptcy entities. This class will map Object to
// Entity.
// </summary>
// <copyright file= "BankruptcyMapper.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;
    using log4net;

    public class BankruptcyMapper
    {
        #region Fields

        private static BankruptcyMapping bankruptcyMapping = new BankruptcyMapping();

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(BankruptcyMapper));

        #endregion Fields

        #region Methods

        public static BankruptcyInfo GetBankruptcyInfo(BankruptcyInfoEntity bankruptcyInfoEntity)
        {
            BankruptcyInfo bankruptcyInfo = null;

            try
            {
                bankruptcyInfo = Mapper.Map<BankruptcyInfoEntity, BankruptcyInfo>(bankruptcyInfoEntity);
                bankruptcyInfo.MBankruptcyBasis = Mapper.Map<MBankruptcyBasisEntity, MBankruptcyBasis>(bankruptcyInfoEntity.BankruptcyBasis);
                bankruptcyInfo.MBankruptcyType = Mapper.Map<MBankruptcyTypeEntity, MBankruptcyType>(bankruptcyInfoEntity.BankruptcyType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBankruptcyInfo", ex);
                throw;
            }

            return bankruptcyInfo;
        }

        /// <summary>
        /// Maps the entities to domain.
        /// </summary>
        /// <param name="BankruptcyInfoEntity">The case info.</param>
        /// <returns>Returns the <see cref="BankruptcyInfo"/>, else null.</returns>
        public static BankruptcyInfo GetBankruptcyInfoEntity(BankruptcyInfoEntity bankruptcyInfoDomainEntity)
        {
            BankruptcyInfo bankruptcyInfoNHibernateEntity = null;

            try
            {
                bankruptcyMapping.MapBankruptcyInfoEntityToBankruptcyInfo();
                bankruptcyInfoNHibernateEntity = Mapper.Map<BankruptcyInfoEntity, BankruptcyInfo>(bankruptcyInfoDomainEntity);
                bankruptcyInfoNHibernateEntity.MBankruptcyBasis = Mapper.Map<MBankruptcyBasisEntity, MBankruptcyBasis>(bankruptcyInfoDomainEntity.BankruptcyBasis);
                bankruptcyInfoNHibernateEntity.MBankruptcyType = Mapper.Map<MBankruptcyTypeEntity, MBankruptcyType>(bankruptcyInfoDomainEntity.BankruptcyType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBankruptcyInfoEntity", ex);
                throw;
            }

            return bankruptcyInfoNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="BankruptcyOtherDefDetail"/> from <see cref="BankruptcyOtherDefDetailEntity"/> input.
        /// </summary>
        /// <param name="bankruptcyOtherDefDetailEntity"><see cref="BankruptcyOtherDefDetailEntity"/></param>
        /// <returns>Returns <see cref="BankruptcyOtherDefDetail"/>, else null.</returns>
        public static BankruptcyOtherDefDetail GetBankruptcyOtherDefDetail(BankruptcyOtherDefDetailEntity bankruptcyOtherDefDetailEntity)
        {
            BankruptcyOtherDefDetail bankruptcyOtherDefDetail = null;

            try
            {
                bankruptcyOtherDefDetail = Mapper.Map<BankruptcyOtherDefDetailEntity, BankruptcyOtherDefDetail>(bankruptcyOtherDefDetailEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBankruptcyOtherDefDetail", ex);
                throw;
            }

            return bankruptcyOtherDefDetail;
        }

        #endregion Methods
    }
}