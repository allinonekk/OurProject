#region Header

/*****************************************************************************************************
* Description : This file represents a standard data access gateway for SubCase.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/11/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: SubCaseGateway.cs
// Description: Represents a standard data access gateway for SubCase.
// </summary>
// <copyright file= "SubCaseGateway.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Class represents a standard data access gateway for SubCase.
    /// </summary>
    internal class SubCaseGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SubCaseGateway));

        /// <summary>
        /// <see cref="ISession"/> instance for Session context.
        /// </summary>
        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOfDocGateway"/> class.
        /// </summary>
        internal SubCaseGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

            //AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.MappingToDTO nHibernateToDomainMapping = new AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.MappingToDTO();
            //nHibernateToDomainMapping.MapAll();

            //AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.MappingToDomain domainToNHibernateMapping = new AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.MappingToDomain();
            //domainToNHibernateMapping.MapAll();
        }

        #endregion Constructors

        #region Methods

        internal void DeleteSubCaseInfoList(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<SubCaseInfo>()
                   .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));
            List<SubCaseInfo> listSubCaseInfo = GetFromDetachedCriteria<SubCaseInfo>(detachedCriteria);
            if (listSubCaseInfo != null && listSubCaseInfo.Count > 0)
            {
                Repository<SubCaseInfo>().DeleteAll(listSubCaseInfo);
            }
        }

        /// <summary>
        /// Passes the <paramref name="columnName"/> and <paramref name="value"/>. Get the <typeparam name="T"></typeparam> back.
        /// </summary>
        /// <typeparam name="V">Type of the value to use as a filter.</typeparam>
        /// <param name="columnName">The name of the filed to filter while retrieving objects.</param>
        /// <param name="value">The value of the filed to filter while retrieving objects.</param>
        /// <returns>List<T></returns>
        internal List<T> GetEntity<T, V>(string fieldName, V value)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            if (string.IsNullOrEmpty(fieldName))
                return iRepository.GetAll() as List<T>;

            return iRepository.GetAll(this.GetDetachedCriteriaGeneric<T, V>(fieldName, value)) as List<T>;
        }

        /// <summary>
        /// Passes the <paramref name="columnName"/> and <paramref name="value"/>. Get the <typeparam name="T"></typeparam> back.
        /// </summary>
        /// <typeparam name="V">Type of the value to use as a filter.</typeparam>
        /// <param name="columnName">The name of the filed to filter while retrieving objects.</param>
        /// <param name="value">The value of the filed to filter while retrieving objects.</param>
        /// <returns>List<T></returns>
        internal List<T> GetEntity<T, V>(string fieldName, V value, string fullNameOfChildObj)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            return iRepository.GetAll(this.GetDetachedCriteriaGeneric<T, V>(fieldName, value, fullNameOfChildObj)) as List<T>;
        }

        /// <summary>
        /// Passes the <paramref name="columnName"/> and <paramref name="value"/>. Get the <typeparam name="T"></typeparam> back.
        /// </summary>
        /// <typeparam name="V">Type of the value to use as a filter.</typeparam>
        /// <param name="columnName">The name of the filed to filter while retrieving objects.</param>
        /// <param name="value">The value of the filed to filter while retrieving objects.</param>
        /// <returns>List<T></returns>
        internal List<T> GetEntity<T, V1, V2>(string firstFieldName, V1 firstValue, string sencondFieldName, V2 secondValue, LogicalOperator logicOperator)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            if (string.IsNullOrEmpty(firstFieldName) || string.IsNullOrEmpty(sencondFieldName))
                return iRepository.GetAll() as List<T>;

            return iRepository.GetAll(this.GetDetachedCriteriaGeneric<T, V1, V2>(firstFieldName, firstValue, sencondFieldName, secondValue, logicOperator)) as List<T>;
        }

        internal List<RelationalSubCaseInfoEntity> GetListRelationalSubCaseInfoBySubCaseInfoId(string subCaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RelationalSubCaseInfo))
                 .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(subCaseInfoId)));
            List<RelationalSubCaseInfo> listRelationalSubCaseInfo = GetFromDetachedCriteria<RelationalSubCaseInfo>(detachedCriteria);
            if (listRelationalSubCaseInfo != null && listRelationalSubCaseInfo.Count > 0)
            {
                return listRelationalSubCaseInfo.Select(relationalSubCaseInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetRelationalSubCaseInfoEntity(relationalSubCaseInfo)).ToList();
            }
            else
                return null;
        }

        internal List<RSubCaseSubmissionEntity> GetListRSubCaseSubmission(string subCaseInfoId, string sGId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RSubCaseSubmission))
                 .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(subCaseInfoId)))
                 .Add(Expression.Eq("SubmissionGroupId", sGId));
            List<RSubCaseSubmission> listRSubCaseSubmission = GetFromDetachedCriteria<RSubCaseSubmission>(detachedCriteria);
            if (listRSubCaseSubmission != null && listRSubCaseSubmission.Count > 0)
            {
                return listRSubCaseSubmission.Select(rSubCaseSubmission => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetRSubCaseSubmissionEntity(rSubCaseSubmission)).ToList();
            }
            else
                return null;
        }

        internal List<RSubCaseSubmissionEntity> GetListRSubCaseSubmissionEntityBySubCaseInfoId(long subCaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RSubCaseSubmission))
                                                                .Add(Expression.Eq("SubCaseInfoId", subCaseInfoId));

            List<RSubCaseSubmission> listRSubCaseSubmission = GetFromDetachedCriteria<RSubCaseSubmission>(detachedCriteria);
            if (listRSubCaseSubmission != null && listRSubCaseSubmission.Count > 0)
            {
                return listRSubCaseSubmission.Select(rSubCaseSubmission => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetRSubCaseSubmissionEntity(rSubCaseSubmission)).ToList();
            }
            else
                return null;
        }

        internal List<RSubCaseSubmissionEntity> GetRSubCaseSubmission<V>(string fieldName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RSubCaseSubmission))
               .Add(Expression.Eq(fieldName, value));
            List<RSubCaseSubmission> listRSubCaseSubmission = GetFromDetachedCriteria<RSubCaseSubmission>(detachedCriteria);
            if (listRSubCaseSubmission != null && listRSubCaseSubmission.Count > 0)
            {
                return listRSubCaseSubmission.Select(rSubCaseSubmission => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetRSubCaseSubmissionEntity(rSubCaseSubmission)).ToList();
            }
            else
                return null;
        }

        internal List<SubCaseInfoEntity> GetSubCaseInfoEntityByCaseInfoId(string caseInfoId)
        {
            List<SubCaseInfo> listSubCaseInfo = null;
            List<SubCaseInfoEntity> listSubCaseInfoEntity = new List<SubCaseInfoEntity>();

            SubCaseInfoEntity subCaseInfoEntity = null;
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SubCaseInfo))
                                                                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            IRepository<SubCaseInfo> subCaseInfoRepository = new RepositoryImpl<SubCaseInfo>(applicationSession);
            listSubCaseInfo = subCaseInfoRepository.GetAll(detachedCriteria) as List<SubCaseInfo>;
            if (listSubCaseInfo != null && listSubCaseInfo.Count > 0)
            {
                foreach (SubCaseInfo subCaseInfo in listSubCaseInfo)
                {
                    subCaseInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCaseInfoEntity(subCaseInfo);
                    listSubCaseInfoEntity.Add(subCaseInfoEntity);
                }
                return listSubCaseInfoEntity;
            }
            else
                return null;
        }

        //TODO :Need to Modify this method as it is a GetbyPK
        internal SubCaseInfoEntity GetSubCaseInfoEntityBySubCaseInfoId(long subCaseInfoId)
        {
            List<SubCaseInfo> listSubCaseInfo = null;
            SubCaseInfoEntity subCaseInfoEntity = null;
            
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SubCaseInfo))
                                                                .Add(Expression.Eq("SubCaseInfoId", subCaseInfoId));

            IRepository<SubCaseInfo> subCaseInfoRepository = new RepositoryImpl<SubCaseInfo>(applicationSession);
            listSubCaseInfo = subCaseInfoRepository.GetAll(detachedCriteria) as List<SubCaseInfo>;
            
            if (listSubCaseInfo != null && listSubCaseInfo.Count > 0)
            {
                foreach (SubCaseInfo subCaseInfo in listSubCaseInfo)
                {
                    applicationSession.Evict(subCaseInfo);
                    subCaseInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCaseInfoEntity(subCaseInfo);
                }
            }
            return subCaseInfoEntity;
        }

        internal List<SubCaseInfoEntity> GetSubCaseInfoEntityBySubCaseNo(string subCaseNo)
        {
            List<SubCaseInfo> listSubCaseInfo = null;
            List<SubCaseInfoEntity> listSubCaseInfoEntity = new List<SubCaseInfoEntity>();

            SubCaseInfoEntity subCaseInfoEntity = null;
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SubCaseInfo))
                                                                .Add(Expression.Eq("SubCaseNo", subCaseNo));
                                                                

            IRepository<SubCaseInfo> subCaseInfoRepository = new RepositoryImpl<SubCaseInfo>(applicationSession);
            listSubCaseInfo = subCaseInfoRepository.GetAll(detachedCriteria) as List<SubCaseInfo>;
            if (listSubCaseInfo != null && listSubCaseInfo.Count > 0)
            {
                foreach (SubCaseInfo subCaseInfo in listSubCaseInfo)
                {
                    subCaseInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCaseInfoEntity(subCaseInfo);
                    listSubCaseInfoEntity.Add(subCaseInfoEntity);
                }
                return listSubCaseInfoEntity;
            }
            else
                return null;
        }

        internal SubCasePartyEntity GetSubCasePartyEntityEntityByPK(string subCasePartyId)
        {
            IRepository<SubCaseParty> subCasePartyRepository = new RepositoryImpl<SubCaseParty>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCasePartyEntity(subCasePartyRepository.Get(subCasePartyId));
        }

        internal List<SubCasePartyEntity> GetSubCasePartyEntityEntityBySubCaseInfoId(long subCaseInfoId)
        {
            List<SubCaseParty> listSubCaseParty = null;
            List<SubCasePartyEntity> listSubCasePartyEntity = new List<SubCasePartyEntity>();

            SubCasePartyEntity subCasePartyEntity = null;
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SubCaseParty))
                                                                .Add(Expression.Eq("SubCaseInfoId", subCaseInfoId));

            IRepository<SubCaseParty> subCasePartyRepository = new RepositoryImpl<SubCaseParty>(applicationSession);
            listSubCaseParty = subCasePartyRepository.GetAll(detachedCriteria) as List<SubCaseParty>;
            if (listSubCaseParty != null && listSubCaseParty.Count > 0)
            {
                foreach (SubCaseParty subCaseParty in listSubCaseParty)
                {
                    subCasePartyEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCasePartyEntity(subCaseParty);
                    listSubCasePartyEntity.Add(subCasePartyEntity);
                }
            }
            return listSubCasePartyEntity;
        }

        internal void SaveOrUpdateRSubCaseSubmissionEntity(RSubCaseSubmissionEntity rSubCaseSubmissionEntity)
        {
            IRepository<RSubCaseSubmission> rSubCaseSubmissionRepository = new RepositoryImpl<RSubCaseSubmission>(applicationSession);
            rSubCaseSubmissionRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseMapper.GetRSubCaseSubmission(rSubCaseSubmissionEntity));
        }

        internal void SaveOrUpdateSubCaseInfoEntity(SubCaseInfoEntity subCaseInfoEntity)
        {
            IRepository<SubCaseInfo> subCaseInfoRepository = new RepositoryImpl<SubCaseInfo>(applicationSession);
            subCaseInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseMapper.GetSubCaseInfo(subCaseInfoEntity));
        }

        internal void SaveOrUpdateSubCasePartyEntity(SubCasePartyEntity subCasePartyEntity)
        {
            IRepository<SubCaseParty> subCasePartyRepository = new RepositoryImpl<SubCaseParty>(applicationSession);
            subCasePartyRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseMapper.GetSubCaseParty(subCasePartyEntity));
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria for "between" values
        /// </summary>
        /// <typeparam name="T">Type to search.</typeparam>
        /// <typeparam name="V">Type to use for between.</typeparam>
        /// <param name="fieldName">The fields name of domain entity to use for deletion.</param>
        /// <param name="fromValue">The start value</param>
        /// <param name="toValue">The end value</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetBetweenDetachedCriteria<T, V>(string fieldName, V fromValue, V toValue)
        {
            Logger.Info("Get " + typeof(T).ToString() + " between: start - " + fieldName + " => end -" + toValue);

            DetachedCriteria detachedCriteria = null;
            try
            {
                detachedCriteria = DetachedCriteria.For(typeof(T)).Add(Expression.Between(fieldName, fromValue, toValue));

                if (detachedCriteria == null)
                {
                    Logger.Error("Get " + typeof(T).ToString() + ". Property names to query are not provided");
                    throw new Exception("Constructing the query criteria have some error.");
                }
            }
            catch (Exception e)
            {
                Logger.Error("Get " + typeof(T).ToString() + ". Constructing the query criteria have some error.", e);
                throw;
            }

            return detachedCriteria;
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria 
        /// </summary>
        /// <typeparam name="T">The type of the object to get.</typeparam> 
        /// <typeparam name="V">The type of the parameter 'value'.</typeparam>
        /// <param name="columneNames">The name of the field to filter while retrieving the object.</param>
        /// <param name="value">The value of the field to filter while retrieving the object.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteriaGeneric<T, V>(string fieldName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(T))
                                                                 .Add(Expression.Eq(fieldName, value));

            return detachedCriteria;
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria 
        /// </summary>
        /// <typeparam name="T">The type of the object to get.</typeparam> 
        /// <typeparam name="V1">The type of the parameter of 'firsValue'.</typeparam>
        /// <typeparam name="V2">The type of the parameter of 'secondValue'.</typeparam>
        /// <param name="firstFieldName">The name of the first field to filter while retrieving the object.</param>
        /// <param name="firstValue">The value of the first field to filter while retrieving the object.</param>
        /// <param name="sencondFieldName">The name of the second field to filter while retrieving the object.</param>
        /// <param name="secondValue">The value of the second field to filter while retrieving the object.</param>
        /// <param name="logicOperator">The logical operator used for query.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteriaGeneric<T, V1, V2>(string firstFieldName, V1 firstValue, string sencondFieldName, V2 secondValue, LogicalOperator logicOperator)
        {
            DetachedCriteria detachedCriteria = null;
            switch (logicOperator)
            {
                case LogicalOperator.AND:
                    detachedCriteria = DetachedCriteria.For(typeof(T))
                                            .Add(Expression.And(Expression.Eq(firstFieldName, firstValue), Expression.Eq(sencondFieldName, secondValue)));
                    break;
                case LogicalOperator.OR:
                    detachedCriteria = DetachedCriteria.For(typeof(T))
                                            .Add(Expression.Or(Expression.Eq(firstFieldName, firstValue), Expression.Eq(sencondFieldName, secondValue)));
                    break;
                //case LogicalOperator.NOT:
                //    detachedCriteria = DetachedCriteria.For(typeof(T))
                //                            .Add(Expression.Not(Expression.Eq(firstFieldName, firstValue), Expression.Eq(sencondFieldName, secondValue)));
                default:
                    detachedCriteria = null;
                    break;
            }

            return detachedCriteria;
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria which filter on the field of the child object.
        /// </summary>
        /// <typeparam name="T">The type of the object to get.</typeparam> 
        /// <typeparam name="V">The type of the parameter 'value'.</typeparam>
        /// <param name="columneNames">The name of the field to filter while retrieving the object.</param>
        /// <param name="value">The value of the field to filter while retrieving the object.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteriaGeneric<T, V>(string fieldName, V value, string fullNameOfChildObj)
        {
            return DetachedCriteria.For(typeof(T))
                                        .CreateCriteria(fullNameOfChildObj)
                                        .Add(Expression.Eq(fieldName, value));
        }

        private List<T> GetFromDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll(detachedCriteria) as List<T>;
        }

        /// <summary>
        /// Gets the repository.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private IRepository<T> Repository<T>()
        {
            return new RepositoryImpl<T>(applicationSession);
        }


        internal List<RSubCaseSubmissionEntity> GetRSubCaseSubmission(string subCaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RSubCaseSubmission>()
                .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(subCaseInfoId)));
            List<RSubCaseSubmission> listRSubCaseSubmission = GetFromDetachedCriteria<RSubCaseSubmission>(detachedCriteria);
            if (listRSubCaseSubmission != null && listRSubCaseSubmission.Count > 0)
            {
                return listRSubCaseSubmission.Select(rSubCaseSubmission => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetRSubCaseSubmissionEntity(rSubCaseSubmission)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<SubCasePartyEntity> GetListSubCasePartyByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<SubCaseParty>()
                .Add(Expression.Eq("CasePartyId", casePartyId));

            List<SubCaseParty> listSubCaseParty = GetFromDetachedCriteria<SubCaseParty>(detachedCriteria);
            if (listSubCaseParty != null && listSubCaseParty.Count > 0)
            {
                return listSubCaseParty.Select(subCaseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCasePartyEntity(subCaseParty)).ToList();

            }
            else
            {
                return null;
            }
        }

        internal List<SubCasePartyEntity> GetListSubCaseParty(string casePartyId, string caseInfoId, string subCaseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<SubCaseParty>()
                .Add(Expression.Eq("CasePartyId", casePartyId))
                .Add(Expression.Eq("CaseInfoId",Convert.ToInt64(caseInfoId)))
                .Add(Expression.Eq("SubCaseInfoId", Convert.ToInt64(subCaseInfoId)));

            List<SubCaseParty> listSubCaseParty = GetFromDetachedCriteria<SubCaseParty>(detachedCriteria);
            if (listSubCaseParty != null && listSubCaseParty.Count > 0)
            {
                return listSubCaseParty.Select(subCaseParty => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCasePartyEntity(subCaseParty)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<SubCaseStatusHistoryEntity> GetSubCaseStatusHistoryEntityBySubCaseStatusHistoryId(string SubCaseStatusHistoryId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<SubCaseStatusHistory>()
                           .Add(Expression.Eq("SubCaseStatusHistoryId", SubCaseStatusHistoryId));
            List<SubCaseStatusHistory> listSubCaseStatusHistory = GetFromDetachedCriteria<SubCaseStatusHistory>(detachedCriteria);
            if (listSubCaseStatusHistory != null && listSubCaseStatusHistory.Count > 0)
            {
                return listSubCaseStatusHistory.Select(subCaseStatusHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCaseStatusHistoryEntity(subCaseStatusHistory)).ToList();
            }
            else
                return null;
        }

        #endregion Methods





       
    }
}