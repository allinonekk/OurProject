#region Header

/*****************************************************************************************************
* Description : This file handles mapper for SubCase from NHibernate entities to Domain objects.
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
// Description: This file handles mapper for SubCase from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "SubCaseMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for SubCase from NHibernate entities to Domain objects.
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

        /// <summary>
        /// Gets the <see cref="RelationalSubCaseInfoEntity"/> from <see cref="RelationSubCaseInfo"/> input.
        /// </summary>
        /// <param name="relationalSubCaseInfo"><see cref="RelationalSubCaseInfo"/></param>
        /// <returns>Returns <see cref="RelationalSubCaseInfoEntity"/>, else null.</returns>
        public static RelationalSubCaseInfoEntity GetRelationalSubCaseInfoEntity(RelationalSubCaseInfo relationalSubCaseInfo)
        {
            RelationalSubCaseInfoEntity relationalSubCaseInfoEntity = null;

            try
            {
                if (relationalSubCaseInfo != null)
                {
                    relationalSubCaseInfoEntity = Mapper.Map<RelationalSubCaseInfo, RelationalSubCaseInfoEntity>(relationalSubCaseInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRelationalSubCaseInfoEntity", ex);
                throw;
            }

            return relationalSubCaseInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="RSubCaseSubmissionEntity"/> from <see cref="RSubCaseSubmission"/> input.
        /// </summary>
        /// <param name="rSubCaseSubmission"><see cref="RSubCaseSubmission"/></param>
        /// <returns>Returns <see cref="RSubCaseSubmissionEntity"/>, else null.</returns>
        public static RSubCaseSubmissionEntity GetRSubCaseSubmissionEntity(RSubCaseSubmission rSubCaseSubmission)
        {
            RSubCaseSubmissionEntity rSubCaseSubmissionEntity = null;

            try
            {
                if (rSubCaseSubmission != null)
                {
                    rSubCaseSubmissionEntity = Mapper.Map<RSubCaseSubmission, RSubCaseSubmissionEntity>(rSubCaseSubmission);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRSubCaseSubmissionEntity", ex);
                throw;
            }

            return rSubCaseSubmissionEntity;
        }

        /// <summary>
        /// Method returns the <see cref="ISubCaseEntity"/> tagged entity from <see cref="ISubCaseEntity"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="ISubCaseEntity"/> type</typeparam>
        /// <param name="subCaseEntity"><see cref="ISubCaseEntity"/> object.</param>
        /// <returns>Returns the <see cref="ISubCaseEntity"/></returns>
        public static ISubCaseEntity GetSubCaseEntity<T>(T subCaseEntity)
        {
            try
            {
                if (subCaseEntity.GetType().Equals(typeof(RSubCaseSubmission)))
                    return (GetRSubCaseSubmissionEntity(subCaseEntity as RSubCaseSubmission));

                else if (subCaseEntity.GetType().Equals(typeof(SubCaseInfo)))
                    return (GetSubCaseInfoEntity(subCaseEntity as SubCaseInfo));

                else if (subCaseEntity.GetType().Equals(typeof(SubCaseParty)))
                    return (GetSubCasePartyEntity(subCaseEntity as SubCaseParty));

                else if (subCaseEntity.GetType().Equals(typeof(SubCaseStatusHistory)))
                    return (GetSubCaseStatusHistoryEntity(subCaseEntity as SubCaseStatusHistory));

                else
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetSubCaseSpecificEntity method in SubCaseSpecificMapper.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSubCaseSpecificEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the <see cref="SubCaseInfoEntity"/> from <see cref="SubCaseInfo"/> input.
        /// </summary>
        /// <param name="subCaseInfo"><see cref="SubCaseInfo"/></param>
        /// <returns>Returns <see cref="SubCaseInfoEntity"/>, else null.</returns>
        public static SubCaseInfoEntity GetSubCaseInfoEntity(SubCaseInfo subCaseInfo)
        {
            SubCaseInfoEntity subCaseInfoEntity = null;

            try
            {
                if (subCaseInfo != null)
                {
                    subCaseInfoEntity = Mapper.Map<SubCaseInfo, SubCaseInfoEntity>(subCaseInfo);
                    subCaseInfoEntity.MCaseStatus = Mapper.Map<MCaseStatus, MCaseStatusEntity>(subCaseInfo.MCaseStatus);
                    subCaseInfoEntity.MSubCaseType = Mapper.Map<MCaseType, MCaseTypeEntity>(subCaseInfo.MCaseType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSubCaseInfoEntity", ex);
                throw;
            }

            return subCaseInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="SubCasePartyEntity"/> from <see cref="SubCaseParty"/> input.
        /// </summary>
        /// <param name="subCaseParty"><see cref="SubCaseParty"/></param>
        /// <returns>Returns <see cref="SubCasePartyEntity"/>, else null.</returns>
        public static SubCasePartyEntity GetSubCasePartyEntity(SubCaseParty subCaseParty)
        {
            SubCasePartyEntity subCasePartyEntity = null;

            try
            {
                if (subCaseParty != null)
                {
                    subCasePartyEntity = Mapper.Map<SubCaseParty, SubCasePartyEntity>(subCaseParty);
                    subCasePartyEntity.MSubCasePartyType = Mapper.Map<MPartyType, MPartyTypeEntity>(subCaseParty.MPartyType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSubCasePartyEntity", ex);
                throw;
            }

            return subCasePartyEntity;
        }

        /// <summary>
        /// Gets the sub case status history entity.
        /// </summary>
        /// <param name="subCaseStatusHistory">The sub case status history.</param>
        /// <returns></returns>
        public static SubCaseStatusHistoryEntity GetSubCaseStatusHistoryEntity(SubCaseStatusHistory subCaseStatusHistory)
        {
            SubCaseStatusHistoryEntity subCaseStatusHistoryEntity = null;

            try
            {
                if (subCaseStatusHistory != null)
                {
                    subCaseStatusHistoryEntity = Mapper.Map<SubCaseStatusHistory, SubCaseStatusHistoryEntity>(subCaseStatusHistory);
                    subCaseStatusHistoryEntity.MCaseStatus = Mapper.Map<MCaseStatus, MCaseStatusEntity>(subCaseStatusHistory.MCaseStatus);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSubCaseStatusHistoryEntity", ex);
                throw;
            }

            return subCaseStatusHistoryEntity;
        }

        #endregion Methods
    }
}