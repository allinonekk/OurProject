#region Header

/*****************************************************************************************************
* Description : This file handles mapper for SubCase from Domain objects to NHibernate entities.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/11/2010   		        Nithin                  Created
*****************************************************************************************************/
// <summary>
// File: SubCaseMapper.cs
// Description: This file handles mapper for SubCase from Domain objects to NHibernate entities.
// </summary>
// <copyright file= "SubCaseMapper.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for SubCase from Domain objects to NHibernate entities.
    /// </summary>
    public class SubCaseMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SubCaseMapper));

        #endregion Fields

        #region Methods

        public static RelationalSubCaseInfo GetRelationalSubCaseInfo(RelationalSubCaseInfoEntity relationalSubCaseInfoEntity)
        {
            RelationalSubCaseInfo relationalSubCaseInfo = null;
            try
            {
                relationalSubCaseInfo = Mapper.Map<RelationalSubCaseInfoEntity, RelationalSubCaseInfo>(relationalSubCaseInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRelationalSubCaseInfo", ex);
                throw;
            }
            return relationalSubCaseInfo;
        }

        /// <summary>
        /// Gets the R case submission.
        /// </summary>
        /// <param name="rCaseSubmissionEntity">The r case submission entity.</param>
        /// <returns></returns>
        public static RSubCaseSubmission GetRSubCaseSubmission(RSubCaseSubmissionEntity rSubCaseSubmissionEntity)
        {
            RSubCaseSubmission rSubCaseSubmission = null;
            try
            {
                rSubCaseSubmission = Mapper.Map<RSubCaseSubmissionEntity, RSubCaseSubmission>(rSubCaseSubmissionEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRSubCaseSubmission", ex);
                throw;
            }
            return rSubCaseSubmission;
        }

        /// <summary>
        /// Gets the sub case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="subCaseEntity">The sub case entity.</param>
        /// <returns></returns>
        public static ISubCase GetSubCase<T>(T subCaseEntity)
        {
            if (subCaseEntity.GetType().Equals(typeof(RSubCaseSubmissionEntity)))
                return (SubCaseMapper.GetRSubCaseSubmission(subCaseEntity as RSubCaseSubmissionEntity));

            else if (subCaseEntity.GetType().Equals(typeof(SubCaseInfoEntity)))
                return (SubCaseMapper.GetSubCaseInfo(subCaseEntity as SubCaseInfoEntity));

            else if (subCaseEntity.GetType().Equals(typeof(SubCasePartyEntity)))
                return (SubCaseMapper.GetSubCaseParty(subCaseEntity as SubCasePartyEntity));

            else if (subCaseEntity.GetType().Equals(typeof(RelationalSubCaseInfoEntity)))
                return (SubCaseMapper.GetRelationalSubCaseInfo(subCaseEntity as RelationalSubCaseInfoEntity));

            else if (subCaseEntity.GetType().Equals(typeof(SubCaseStatusHistoryEntity)))
                return (SubCaseMapper.GetSubCaseStatusHistory(subCaseEntity as SubCaseStatusHistoryEntity));

            else
                throw new ArgumentNullException("Invalid object sent.");
        }

        public static SubCaseInfo GetSubCaseInfo(SubCaseInfoEntity subCaseInfoEntity)
        {
            SubCaseInfo subCaseInfo = null;
            try
            {
                subCaseInfo = Mapper.Map<SubCaseInfoEntity, SubCaseInfo>(subCaseInfoEntity);
                subCaseInfo.MCaseStatus = Mapper.Map<MCaseStatusEntity, MCaseStatus>(subCaseInfoEntity.MCaseStatus);
                subCaseInfo.MCaseType = Mapper.Map<MCaseTypeEntity, MCaseType>(subCaseInfoEntity.MSubCaseType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSubCaseInfo", ex);
                throw;
            }
            return subCaseInfo;
        }

        public static SubCaseParty GetSubCaseParty(SubCasePartyEntity subCasePartyEntity)
        {
            SubCaseParty subCaseParty = null;
            try
            {
                subCaseParty = Mapper.Map<SubCasePartyEntity, SubCaseParty>(subCasePartyEntity);
                subCaseParty.MPartyType = Mapper.Map<MPartyTypeEntity, MPartyType>(subCasePartyEntity.MSubCasePartyType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSubCaseParty", ex);
                throw;
            }
            return subCaseParty;
        }

        /// <summary>
        /// Gets the sub case status history.
        /// </summary>
        /// <param name="subCaseStatusHistoryEntity">The sub case status history entity.</param>
        /// <returns></returns>
        public static SubCaseStatusHistory GetSubCaseStatusHistory(SubCaseStatusHistoryEntity subCaseStatusHistoryEntity)
        {
            SubCaseStatusHistory subCaseStatusHistory = null;
            try
            {
                subCaseStatusHistory = Mapper.Map<SubCaseStatusHistoryEntity, SubCaseStatusHistory>(subCaseStatusHistoryEntity);
                subCaseStatusHistory.MCaseStatus = Mapper.Map<MCaseStatusEntity, MCaseStatus>(subCaseStatusHistoryEntity.MCaseStatus);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSubCaseStatusHistory", ex);
                throw;
            }
            return subCaseStatusHistory;
        }


        #endregion Methods
    }
}