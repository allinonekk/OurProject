#region Header

/*****************************************************************************************************
* Description : This file represents all the standard generic methods within gateway classes.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   11/01/2011   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: GenericGateway.cs
// Description: Represents all the standard generic methods within gateway classes.
// </summary>
// <copyright file= "GenericGateway.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Class represents all the standard generic methods within gateway classes.
    /// </summary>
    internal class GenericGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(GenericGateway));

        /// <summary>
        /// <see cref="ISession"/> instance for Session context.
        /// </summary>
        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericGateway"/> class.
        /// </summary>
        public GenericGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            this.applicationSession = applicationSessionManager.Session;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Creates the entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">The entity.</param>
        internal void CreateEntity<T>(T entity)
        {
            try
            {
                Check.RequireWithNullException(entity != null,
                "Parameter 'entity' cannot be null at CreateEntity method.");
                IRepository<T> iRepository = new RepositoryImpl<T>(this.applicationSession);
                iRepository.Create(entity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CreateEntity", ex);
                throw;
            }
        }

        internal ICaseEntity GetEntity<T>(string value)
        {
            ICase iCase = this.GetICaseTypeConverter<T>();
            if (typeof(T).Equals(typeof(CasePartyEntity)))
                GetByRepository<CaseParty>(value);

            return null;
        }

        /// <summary>
        /// Gets the List of <see cref="ICaseEntity "/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values">FieldName and Value Within Dictionary.</param>
        /// <returns>List<ICaseEntity></IcaseEntity></returns>
        internal List<ICaseEntity> GetListCaseEntity<T>(Dictionary<string, object> values)
        {
            ICase iCase = this.GetICaseTypeConverter<T>();

            DetachedCriteria detachedCriteria = GetDetachedCriteriaGeneric(iCase, values);
            return GetCaseEntityByDetachedCriteria<ICase>(detachedCriteria);
        }

        internal List<IDocumentEntity> GetListDocumentEntity<T>(Dictionary<string, object> values)
        {
            IDocument iDocument = this.GetIDocumentTypeConverter<T>();

            DetachedCriteria detachedCriteria = GetDetachedCriteriaGeneric(iDocument, values);
            return GetDocumentEntityByDetachedCriteria<IDocument>(detachedCriteria);
        }

        /// <summary>
        /// Saves the or update entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">The entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        internal void SaveOrUpdateEntity<T>(T entity, bool isCopy)
        {
            try
            {
                Check.RequireWithNullException(entity != null,
                "Parameter 'entity' cannot be null at SaveOrUpdateEntity method.");

                IRepository<T> iRepository = new RepositoryImpl<T>(this.applicationSession);
                iRepository.SaveOrUpdate(entity, isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Saves the or update entity list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entities">The entity list.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        internal void SaveOrUpdateEntityList<T>(List<T> entities, bool isCopy)
        {
            try
            {
                Check.RequireWithNullException(entities != null && entities.Count > 0,
                "Parameter 'entities' cannot be null at SaveOrUpdateEntity method.");

                IRepository<T> iRepository = new RepositoryImpl<T>(this.applicationSession);
                iRepository.SaveOrUpdate(entities, isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateEntityList", ex);
                throw;
            }
        }

        internal void UpdateEntity<T>(T entity)
        {
            try
            {
                Check.RequireWithNullException(entity != null,
                "Parameter 'entity' cannot be null at UpdateEntity method.");
                IRepository<T> iRepository = new RepositoryImpl<T>(this.applicationSession);
                iRepository.Update(entity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at UpdateEntity", ex);
                throw;
            }
        }

        private void GetByRepository<T>(string value)
        {
            RepositoryImpl<T> repositiry = new RepositoryImpl<T>(applicationSession);
            ICase case1 = (ICase)repositiry.Get(value);
        }

        //internal List<ICaseEntity> GetListByList<T>(List<Properties> list)
        //{
        //    ICase iCase = this.GetICaseTypeConverter<T>();
        //    DetachedCriteria detachedCriteria = GetDetachedCriteriaGeneric(iCase, list);
        //    return GetCaseEntityByDetachedCriteria<ICase>(detachedCriteria);
        //}
        //private DetachedCriteria GetDetachedCriteriaGeneric(ICase iCase, List<Properties> list)
        //{
        //    DetachedCriteria detachedCriteria = DetachedCriteria.For(iCase.GetType());
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //    }
        //    return detachedCriteria;
        //}
        /// <summary>
        /// Gets the List<see cref="ICaseEntity"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="detachedCriteria">The detached criteria.</param>
        /// <returns></returns>
        private List<ICaseEntity> GetCaseEntityByDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);
            List<T> listICommon = iRepository.GetAll(detachedCriteria) as List<T>;
            if (listICommon != null && listICommon.Count > 0)
            {
                return listICommon.Select(iCommon => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseEntity<T>(iCommon)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the DetachedCriteria.
        /// </summary>
        /// <param name="iCase">The iCase.</param>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        private DetachedCriteria GetDetachedCriteriaGeneric(ICase iCase, Dictionary<string, object> values)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(iCase.GetType());

            foreach (KeyValuePair<string, object> fieldnames in values)
            {
                detachedCriteria.Add(Expression.Eq(fieldnames.Key, fieldnames.Value));
            }
            return detachedCriteria;
        }

        private DetachedCriteria GetDetachedCriteriaGeneric(IDocument iDocument, Dictionary<string, object> values)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(iDocument.GetType());

            foreach (KeyValuePair<string, object> fieldnames in values)
            {
                detachedCriteria.Add(Expression.Eq(fieldnames.Key, fieldnames.Value));
            }
            return detachedCriteria;
        }

        private List<IDocumentEntity> GetDocumentEntityByDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);
            List<T> listIDocument = iRepository.GetAll(detachedCriteria) as List<T>;
            if (listIDocument != null && listIDocument.Count > 0)
            {
                return listIDocument.Select(iDocument => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentEntity<T>(iDocument)).ToList();
            }
            else
            {
                return null;
            }
        }

        private ICaseEntity GetICaseEntityTypeConverter<T>()
        {
            if (typeof(T).Equals(typeof(CaseParty)))
                return new CasePartyEntity();
            else if (typeof(T).Equals(typeof(CasePartyAddress)))
                return new CasePartyAddressEntity();
            else
                return null;
        }

        /// <summary>
        /// Gets the <see cref="ICase"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private ICase GetICaseTypeConverter<T>()
        {
            if (typeof(T).Equals(typeof(CasePartyEntity)))
                return new CaseParty();
            else if (typeof(T).Equals(typeof(CasePartyAddressEntity)))
                return new CasePartyAddress();
            else
                return null;
        }

        private IDocument GetIDocumentTypeConverter<T>()
        {
            if (typeof(T).Equals(typeof(DocCasePartyEntity)))
                return new DocCaseParty();
            else if (typeof(T).Equals(typeof(DocCasePartyAddressEntity)))
                return new DocCasePartyAddress();
            else
                return null;
        }

        #endregion Methods
    }
}