#region Header

/*****************************************************************************************************
* Description : This file represents a standard data access gateway for PaymentInOut.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   15/11/2010   		      Rajeev             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: PaymentInOutGateway.cs
// Description: Represents a standard data access gateway for PaymentInOut.
// </summary>
// <copyright file= "PaymentInOutGateway.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Class represents a standard data access gateway for PaymentInOut.
    /// </summary>
    internal class PaymentInOutGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PaymentInOutGateway));

        /// <summary>
        /// <see cref="ISession"/> instance for Session context.
        /// </summary>
        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInOutGateway"/> class.
        /// </summary>
        internal PaymentInOutGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

            //AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.MappingToDTO nHibernateToDomainMapping =
            //                    new AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.MappingToDTO();
            //nHibernateToDomainMapping.MapAll();

            //AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.MappingToDomain domainToNHibernateMapping =
            //                    new AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.MappingToDomain();
            //domainToNHibernateMapping.MapAll();
        }

        #endregion Constructors

        #region Methods

        internal void DeletePaymentOutPayInDetail(string paymentOutInId)
        {
            IRepository<PaymentOutPayInDetail> paymentOutPayInDetailRepository = new RepositoryImpl<PaymentOutPayInDetail>(applicationSession);
            paymentOutPayInDetailRepository.Delete(paymentOutPayInDetailRepository.Get(paymentOutInId));
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

        internal List<PaymentInDocFSDetailEntity> GetListPaymentInDocFSDetailEntityBySGID(string submissionGroupId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PaymentInDocFSDetail))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<PaymentInDocFSDetail> listPaymentInDocFSDetail = GetPaymentInDocFSDetail(detachedCriteria);

            if (listPaymentInDocFSDetail != null && listPaymentInDocFSDetail.Count > 0)
            {
                return listPaymentInDocFSDetail.Select(paymentInDocFSDetail => SubCaseSpecificMapper.GetPaymentInDocFSDetail(paymentInDocFSDetail)).ToList();
            }
            else
                return null;
        }

        internal List<PaymentOutPayInDetailEntity> GetListPaymentOutPayInDetailEntityBySGID(string submissionGroupID)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PaymentOutPayInDetail))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupID));
            List<PaymentOutPayInDetail> listPaymentOutPayInDetail = GetPaymentOutPayInDetail(detachedCriteria);

            if (listPaymentOutPayInDetail != null && listPaymentOutPayInDetail.Count > 0)
            {
                return listPaymentOutPayInDetail.Select(paymentOutPayInDetail => SubCaseSpecificMapper.GetPaymentOutPaymentInDetail(paymentOutPayInDetail)).ToList();
            }
            else
                return null;
        }

        internal PaymentInDocDetailEntity GetPaymentInDocDetailEntityByPK(string PaymentInId)
        {
            IRepository<PaymentInDocDetail> paymentInDocDetailRepository = new RepositoryImpl<PaymentInDocDetail>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetPaymentInDocDetailEntity(paymentInDocDetailRepository.Get(PaymentInId));
        }

        internal List<PaymentInDocDetailEntity> GetListPaymentInDocDetailEntityBySGID(string submissionGroupId)
        {
            PaymentInDocDetailEntity paymentInDocDetailEntity = new PaymentInDocDetailEntity();
            IRepository<PaymentInDocDetail> paymentInDocDetailRepository = new RepositoryImpl<PaymentInDocDetail>(applicationSession);

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PaymentInDocDetail))
                                                                 .Add(Expression.Eq("SubmissionGroupId", submissionGroupId));
            List<PaymentInDocDetail> listPaymentInDocDetail = paymentInDocDetailRepository.GetAll(detachedCriteria) as List<PaymentInDocDetail>;

            if (listPaymentInDocDetail != null && listPaymentInDocDetail.Count > 0)
            {
                return listPaymentInDocDetail.Select(paymentInDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetPaymentInDocDetailEntity(paymentInDocDetail)).ToList();
            }
            else

                return null;
        }

        internal PaymentOutDocDetailEntity GetPaymentOutDocDetailEntityByPk(string PaymentOutId)
        {
            IRepository<PaymentOutDocDetail> paymentOutDocDetailRepository = new RepositoryImpl<PaymentOutDocDetail>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetPaymentOutDocEntity(paymentOutDocDetailRepository.Get(PaymentOutId));
        }

        internal List<PaymentOutDocDetailEntity> GetListPaymentOutDocDetailEntityBySGID(string submissionGroupID)
        {
            PaymentOutDocDetailEntity paymentOutDocDetailEntity = new PaymentOutDocDetailEntity();
            IRepository<PaymentOutDocDetail> paymentOutDocDetailRepository = new RepositoryImpl<PaymentOutDocDetail>(applicationSession);

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PaymentOutDocDetail))
                                                                .Add(Expression.Eq("SubmissionGroupId", submissionGroupID));
            List<PaymentOutDocDetail> listPaymentOutDocDetail = paymentOutDocDetailRepository.GetAll(detachedCriteria) as List<PaymentOutDocDetail>;

            if (listPaymentOutDocDetail != null && listPaymentOutDocDetail.Count > 0)
            {
               return  listPaymentOutDocDetail.Select(paymentOutDocDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetPaymentOutDocEntity(paymentOutDocDetail)).ToList();
            }
            else
            {
                return null;
            }

        }

        internal void SaveOrUpdateCopyPaymentOutPayInDetail(PaymentOutPayInDetailEntity paymentOutPayInDetailEntity)
        {
            IRepository<PaymentOutPayInDetail> paymentOutPayInDetailRepository = new RepositoryImpl<PaymentOutPayInDetail>(applicationSession);
            paymentOutPayInDetailRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.PaymentInOutMapper.GetPaymentOutPaymentInDetail(paymentOutPayInDetailEntity));
        }

        /// <summary>
        /// Passes the domain object and save it.
        /// </summary>
        /// <param name="entityToSave">The domain object to be saved.<param>
        /// <returns></returns>
        internal void SaveOrUpdateEntity<T>(T entityToSave)
        {
            IRepository<T> fESpecificRepository = new RepositoryImpl<T>(applicationSession);
            fESpecificRepository.SaveOrUpdate(entityToSave);
        }

        /// <summary>
        /// Passes the domain object and save it.
        /// </summary>
        /// <param name="entityToSave">The domain object to be saved.<param>
        /// <returns></returns>
        internal void SaveOrUpdateInMemoryEntity<T>(T entityToSave)
        {
            IRepository<T> fESpecificRepository = new RepositoryImpl<T>(applicationSession);
            fESpecificRepository.SaveOrUpdateCopy(entityToSave);
        }

        internal void SaveOrUpdatePaymentInDocDetail(PaymentInDocDetailEntity paymentInDocDetailEntity)
        {
            IRepository<PaymentInDocDetail> paymentInDocDetailRepository = new RepositoryImpl<PaymentInDocDetail>(applicationSession);
            paymentInDocDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.PaymentInOutMapper.GetPaymentInDocDetail(paymentInDocDetailEntity));
        }

        internal void SaveOrUpdatePaymentInDocFSDetail(PaymentInDocFSDetailEntity paymentInDocFSDetailEntity)
        {
            IRepository<PaymentInDocFSDetail> paymentInDocFSDetailRepository = new RepositoryImpl<PaymentInDocFSDetail>(applicationSession);
            paymentInDocFSDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.PaymentInOutMapper.GetPaymentInDocFSDetail(paymentInDocFSDetailEntity));
        }

        internal void SaveOrUpdatePaymentOutDocDetail(PaymentOutDocDetailEntity paymentOutDocDetailEntity)
        {
            IRepository<PaymentOutDocDetail> paymentOutDocDetailRepository = new RepositoryImpl<PaymentOutDocDetail>(applicationSession);
            paymentOutDocDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.PaymentInOutMapper.GetPaymentOutDocDetail(paymentOutDocDetailEntity));
        }

        internal void SaveOrUpdatePaymentOutDocDetailCopy(PaymentOutDocDetailEntity paymentOutDocDetailEntity)
        {
            IRepository<PaymentOutDocDetail> paymentOutDocDetailRepository = new RepositoryImpl<PaymentOutDocDetail>(applicationSession);
            paymentOutDocDetailRepository.SaveOrUpdateCopy(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.PaymentInOutMapper.GetPaymentOutDocDetail(paymentOutDocDetailEntity));
        }

        internal void SaveOrUpdatePaymentOutPayInDetail(PaymentOutPayInDetailEntity paymentOutPayInDetailEntity)
        {
            IRepository<PaymentOutPayInDetail> paymentOutPayInDetailRepository = new RepositoryImpl<PaymentOutPayInDetail>(applicationSession);
            paymentOutPayInDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.PaymentInOutMapper.GetPaymentOutPaymentInDetail(paymentOutPayInDetailEntity));
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
                Logger.Error("Get " + typeof(T).ToString() + ". Constructing the query criteria have some error.",e);
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

        private List<PaymentInDocFSDetail> GetPaymentInDocFSDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<PaymentInDocFSDetail> paymentInDocFSDetailRepository = new RepositoryImpl<PaymentInDocFSDetail>(applicationSession);
            return paymentInDocFSDetailRepository.GetAll(detachedCriteria) as List<PaymentInDocFSDetail>;
        }

        private List<PaymentOutPayInDetail> GetPaymentOutPayInDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<PaymentOutPayInDetail> paymentOutPayInDetailRepository = new RepositoryImpl<PaymentOutPayInDetail>(applicationSession);
            return paymentOutPayInDetailRepository.GetAll(detachedCriteria) as List<PaymentOutPayInDetail>;
        }

        #endregion Methods
    }
}