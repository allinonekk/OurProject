#region Header

/*****************************************************************************************************
* Description : This file represents a standard data access gateway for LAP.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   11/10/2010   		      Yan Nai             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LAPGateway.cs
// Description: Represents a standard data access gateway for LAP.
// </summary>
// <copyright file= "LAPGateway.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LAP;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Class represents a standard data access gateway for LAP.
    /// </summary>
    internal class LAPGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LAPGateway));

        /// <summary>
        /// <see cref="ISession"/> instance for Session context.
        /// </summary>
        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LAPGateway"/> class.
        /// </summary>
        internal LAPGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Save the LABPartyEntity.
        /// </summary>
        /// <param name="LABPartyEntity">The LABParty domain object.</param>
        /// <returns></returns>
        internal void CreateLABParty(LABPartyEntity lABPartyEntity)
        {
            IRepository<LABParty> lABPartyRepository = new RepositoryImpl<LABParty>(applicationSession);
            lABPartyRepository.Create(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLABParty(lABPartyEntity));
        }

        /// <summary>
        /// Passes the NHibernate DetachedCriteria and delete the entity.
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        internal int DeleteEntityByDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            List<T> listEMSAccountToDelete = this.GetEntityByDetachedCriteria<T>(detachedCriteria);

            if (listEMSAccountToDelete.Count > 0)
            {
                IRepository<T> iEnforcementRepository = new RepositoryImpl<T>(applicationSession);
                iEnforcementRepository.DeleteAll(listEMSAccountToDelete);
            }

            return listEMSAccountToDelete.Count;
        }

        /// <summary>
        /// Passes the <paramref name="columnName"/> and <paramref name="value"/>. Get the <typeparam name="T"></typeparam> back.
        /// </summary>
        /// <typeparam name="V">Type of the value to use as a filter.</typeparam>
        /// <param name="columnName">The name of the filed to filter while retrieving objects.</param>
        /// <param name="value">The value of the filed to filter while retrieving objects.</param>
        /// <returns>List<T></returns>
        internal List<T> GetEntity<T, V>(string columnName, V value)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            return iRepository.GetAll(this.GetDetachedCriteria<T, V>(columnName, value)) as List<T>;
        }

        /// <summary>
        /// Passes the <paramref name="columnName"/> and <paramref name="value"/>. Get the <typeparam name="T"></typeparam> back.
        /// </summary>
        /// <typeparam name="V">Type of the value to use as a filter.</typeparam>
        /// <param name="columnName">The name of the filed to filter while retrieving objects.</param>
        /// <param name="value">The value of the filed to filter while retrieving objects.</param>
        /// <returns>List<T></returns>
        internal List<T> GetEntity<T, V>(string columnName, V valueFrom, V valueTo)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            return iRepository.GetAll(this.GetDetachedCriteria<T, V>(columnName, valueFrom, valueTo)) as List<T>;
        }

        /// <summary>
        /// Passes the <paramref name="columnName"/> and <paramref name="value"/>. Get the <typeparam name="T"></typeparam> back.
        /// </summary>
        /// <typeparam name="V">Type of the value to use as a filter.</typeparam>
        /// <param name="columnName">The name of the filed to filter while retrieving objects.</param>
        /// <param name="value">The value of the filed to filter while retrieving objects.</param>
        /// <returns>List<T></returns>
        internal List<T> GetEntity<T, V, V2>(string columnName, V valueFrom, V valueTo, string columnName2, V2 secondValue)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            return iRepository.GetAll(this.GetDetachedCriteria<T, V, V2>(columnName, valueFrom, valueTo, columnName2, secondValue)) as List<T>;
        }

        /// <summary>
        /// Passes the NHibernate DetachedCriteria and gets the entity 
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns>List<typeparam name="T"></typeparam></returns>
        internal List<T> GetEntityByDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> iEnforcementRepository = new RepositoryImpl<T>(applicationSession);
            return iEnforcementRepository.GetAll(detachedCriteria) as List<T>;
        }

        /// <summary>
        /// Passes the primaryKey and gets the LABPartyAddressEntity
        /// </summary>
        /// <param name="lABPartyAddressId">The primary key of LAB Party Address.<param>
        /// <returns></returns>
        internal LABPartyAddressEntity GetLABPartyAddressByPK(string lABPartyAddressId)
        {
            IRepository<LABPartyAddress> lABPartyAddressRepository = new RepositoryImpl<LABPartyAddress>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyAddressEntity(lABPartyAddressRepository.Get(lABPartyAddressId));
        }

        /// <summary>
        /// Passes the primaryKey and gets the LABPartyAddressHistoryEntity
        /// </summary>
        /// <param name="lABPartyAddressHistoryId">The primary key of LAB Party Address History.<param>
        /// <returns></returns>
        internal LABPartyAddressHistoryEntity GetLABPartyAddressHistoryByPK(string lABPartyAddressHistoryId)
        {
            IRepository<LABPartyAddressHistory> lABPartyAddressHistoryRepository = new RepositoryImpl<LABPartyAddressHistory>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyAddressHistoryEntity(lABPartyAddressHistoryRepository.Get(lABPartyAddressHistoryId));
        }

        /// <summary>
        /// Passes the primaryKey and gets the LABPartyEntity
        /// </summary>
        /// <param name="lABPartyId">The primary key of LAB Party.</param>
        /// <returns></returns>
        internal LABPartyEntity GetLABPartyByPK(string lABPartyId)
        {
            IRepository<LABParty> lABPartyRepository = new RepositoryImpl<LABParty>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyEntity(lABPartyRepository.Get(lABPartyId));
        }

        /// <summary>
        /// Passes the LABPartyId and gets the LABPartyData. It inlcludes LABParty, ListLABPartyAddress, ListLABPartySolicitors.
        /// </summary>
        /// <param name="lABPartyId">LABPartyId.</param>
        /// <returns></returns>
        internal ILABPartyData GetLABPartyData(string lABPartyId)
        {
            LABPartyData lABPartyData = new LABPartyData();
            try
            {
                lABPartyData.LABParty = this.GetLABPartyByPK(lABPartyId);
                lABPartyData.ListLABPartyAddress = this.GetListLABPartyAddressByLABPartyId(lABPartyId);
                lABPartyData.ListLABPartySolicitors = this.GetListLABPartySolicitorByLABPartyId(lABPartyId);
            }
            catch
            { throw; }

            return lABPartyData;
        }

        /// <summary>
        /// Passes the primaryKey and gets the LABPartyHistoryEntity
        /// </summary>
        /// <param name="lABPartyHistoryId">The primary key of LAB Party History.</param>
        /// <returns></returns>
        internal LABPartyHistoryEntity GetLABPartyHistoryByPK(string lABPartyHistoryId)
        {
            IRepository<LABPartyHistory> lABPartyHistoryRepository = new RepositoryImpl<LABPartyHistory>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyHistoryEntity(lABPartyHistoryRepository.Get(lABPartyHistoryId));
        }

        /// <summary>
        /// Passes the LAB Party History Id and gets the LABPartyData. It inlcludes LABParty, ListLABPartyAddress, ListLABPartySolicitors.
        /// </summary>
        /// <param name="lABPartyHistoryId">LAB Party History Id.</param>
        /// <returns></returns>
        internal ILABPartyHistoryData GetLABPartyHistoryData(string lABPartyHistoryId)
        {
            LABPartyHistoryData lABPartyHistoryData = new LABPartyHistoryData();
            try
            {
                lABPartyHistoryData.LABPartyHistory = this.GetLABPartyHistoryByPK(lABPartyHistoryId);
                lABPartyHistoryData.ListLABPartyAddressHistory = this.GetListLABPartyAddressHistoryByLABPartyHistoryId(lABPartyHistoryId);
                lABPartyHistoryData.ListLABPartySolicitorHistory = this.GetListLABPartySolicitorHistoryByLABPartyHistoryId(lABPartyHistoryId);
            }
            catch
            { throw; }

            return lABPartyHistoryData;
        }

        internal ILABPartyHistoryData GetLABPartyHistoryDataByLABPartyId(string lABPartyId)
        {
            LABPartyHistoryData lABPartyHistoryData = new LABPartyHistoryData();
            lABPartyHistoryData.LABPartyHistory = GetLABPartyHistoryByLABPartyId(lABPartyId);
            lABPartyHistoryData.ListLABPartyAddressHistory = GetListLABPartyAddressHistoryByLABPartyId(lABPartyId);
            lABPartyHistoryData.ListLABPartySolicitorHistory = GetListLABPartySolicitorHistoryByLABPartyId(lABPartyId);

            return lABPartyHistoryData;
        }

        /// <summary>
        /// Passes the primaryKey and gets the LABPartySolicitorEntity
        /// </summary>
        /// <param name="lABPartySolicitorId">The primary key of LAB Party Solicitor.</param>
        /// <returns></returns>
        internal LABPartySolicitorEntity GetLABPartySolicitorByPK(string lABPartySolicitorId)
        {
            IRepository<LABPartySolicitor> lABPartySolicitorRepository = new RepositoryImpl<LABPartySolicitor>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartySolicitorEntity(lABPartySolicitorRepository.Get(lABPartySolicitorId));
        }

        /// <summary>
        /// Passes the primaryKey and gets the LABPartySolicitorHistoryEntity
        /// </summary>
        /// <param name="lABPartySolicitorHistoryId">The primary key of LAB Party Solicitor.</param>
        /// <returns></returns>
        internal LABPartySolicitorHistoryEntity GetLABPartySolicitorHistoryByPK(string lABPartySolicitorHistoryId)
        {
            IRepository<LABPartySolicitorHistory> lABPartySolicitorHistoryRepository = new RepositoryImpl<LABPartySolicitorHistory>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartySolicitorHistoryEntity(lABPartySolicitorHistoryRepository.Get(lABPartySolicitorHistoryId));
        }

        /// <summary>
        /// Passes the primaryKey and gets the LABSection17CertInfoEntity
        /// </summary>
        /// <param name="LABSection17CertInfoId">The primary key of LAC Document Remark.<param>
        /// <returns></returns>
        internal LABSection17CertInfoEntity GetLABSection17CertInfoByPK(string LABSection17CertInfoId)
        {
            IRepository<LABSection17CertInfo> lABSection17CertInfoRepository = new RepositoryImpl<LABSection17CertInfo>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABSection17CertInfoEntity(lABSection17CertInfoRepository.Get(LABSection17CertInfoId));
        }

        internal LACCancellationInfoEntity GetLACCancellationInfoByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<LACCancellationInfo>()
                .Add(Expression.Eq("DocId", docId));
            List<LACCancellationInfo> listLACCancellationInfo = GetFromDetachedCriteria<LACCancellationInfo>(detachedCriteria);
            if (listLACCancellationInfo != null && listLACCancellationInfo.Count > 0)
            {
                return listLACCancellationInfo.Select(lACCancellationInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACCancellationInfoEntity(lACCancellationInfo)).ToList()[0];
            }
            return null;
        }

        /// <summary>
        /// Passes the primaryKey and gets the LACCancellationInfoEntity
        /// </summary>
        /// <param name="LACCancellationInfoId">The primary key of LAC Cancellation info.<param>
        /// <returns></returns>
        internal LACCancellationInfoEntity GetLACCancellationInfoByPK(string lACCancellationInfoId)
        {
            IRepository<LACCancellationInfo> lACCancellationInfoRepository = new RepositoryImpl<LACCancellationInfo>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACCancellationInfoEntity(lACCancellationInfoRepository.Get(lACCancellationInfoId));
        }

        /// <summary>
        /// Passes the primaryKey and gets the LACDocumentDetailEntity
        /// </summary>
        /// <param name="lACDocumentDetailId">The primary key of LAC Document Detail.<param>
        /// <returns></returns>
        internal LACDocumentDetailEntity GetLACDocumentDetailByPK(string lACDocumentDetailId)
        {
            IRepository<LACDocumentDetail> lACDocumentDetailRepository = new RepositoryImpl<LACDocumentDetail>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACDocumentDetailEntity(lACDocumentDetailRepository.Get(lACDocumentDetailId));
        }

        /// <summary>
        /// Passes the primaryKey and gets the LACDocumentDraftEntity
        /// </summary>
        /// <param name="lACDocumentDraftId">The primary key of LAC Document Draft.<param>
        /// <returns></returns>
        internal LACDocumentDraftEntity GetLACDocumentDraftByPK(string lACDocumentDraftId)
        {
            IRepository<LACDocumentDraft> lACDocumentDraftRepository = new RepositoryImpl<LACDocumentDraft>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACDocumentDraftEntity(lACDocumentDraftRepository.Get(lACDocumentDraftId));
        }

        /// <summary>
        /// Passes the primaryKey and gets the LACDocumentRemarkEntity
        /// </summary>
        /// <param name="lACDocumentRemarkId">The primary key of LAC Document Remark.<param>
        /// <returns></returns>
        internal LACDocumentRemarkEntity GetLACDocumentRemarkByPK(string lACDocumentRemarkId)
        {
            IRepository<LACDocumentRemark> lACDocumentRemarkRepository = new RepositoryImpl<LACDocumentRemark>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACDocumentRemarkEntity(lACDocumentRemarkRepository.Get(lACDocumentRemarkId));
        }

        /// <summary>
        /// Passes the primaryKey and gets the LACInfoEntity
        /// </summary>
        /// <param name="lABPartyAddressId">The primary key of LAC Info.<param>
        /// <returns></returns>
        internal LACInfoEntity GetLACInfoByPK(string lACInfoId)
        {
            IRepository<LACInfo> lACInfoRepository = new RepositoryImpl<LACInfo>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACInfoEntity(lACInfoRepository.Get(lACInfoId));
        }

        /// <summary>
        /// Get a list of LABPartyEntity by ID Number and ID Type Code.
        /// </summary>
        /// <param name="idNumber">ID Number</param>
        /// <param name="idType">MPersonIdType's IDTypeCode</param>
        /// <returns>List<LABPartyEntityEntity></returns> 
        internal List<LABPartyEntity> GetListLABParty(string idNumber, string idType)
        {
            MPersonIDType mPersonIDType = new MPersonIDType();
            mPersonIDType.IdTypeCode = idType;
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABParty))
                                        .Add(Expression.Eq("IdNumber", idNumber))

                                        .Add(Expression.Eq("MPersonIDType", mPersonIDType));

            List<LABParty> listLABPartyEntity = GetLABParty(detachedCriteria);

            if (listLABPartyEntity != null && listLABPartyEntity.Count > 0)
            {
                return listLABPartyEntity.Select(lABPartyEntity => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyEntity(lABPartyEntity)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LABPartyAddressEntity
        /// </summary>
        /// <param name="lABPartyId">The LAB Party Id.<param>
        /// <returns></returns>
        internal List<LABPartyAddressEntity> GetListLABPartyAddressByLABPartyId(string lABPartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABPartyAddress))
                                                                            .Add(Expression.Eq("LABPartyId", lABPartyId));

            List<LABPartyAddress> listLABPartyAddress = GetLABPartyAddress(detachedCriteria);

            if (listLABPartyAddress != null && listLABPartyAddress.Count > 0)
            {
                return listLABPartyAddress.Select(lABPartyAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyAddressEntity(lABPartyAddress)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LABPartyAddressHistoryEntity
        /// </summary>
        /// <param name="LABPartyHistoryId">The LAB Party History Id.<param>
        /// <returns></returns>
        internal List<LABPartyAddressHistoryEntity> GetListLABPartyAddressHistoryByLABPartyHistoryId(string lABPartyHistoryId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABPartyAddressHistory))
                                                                            .Add(Expression.Eq("LABPartyHistoryId", lABPartyHistoryId));

            List<LABPartyAddressHistory> listLABPartyAddressHistory = GetLABPartyAddressHistory(detachedCriteria);

            if (listLABPartyAddressHistory != null && listLABPartyAddressHistory.Count > 0)
            {
                return listLABPartyAddressHistory.Select(lABPartyAddressHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyAddressHistoryEntity(lABPartyAddressHistory)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LABPartyAddressHistoryEntity
        /// </summary>
        /// <param name="lABPartyId">The LAB Party Id.<param>
        /// <returns></returns>
        internal List<LABPartyAddressHistoryEntity> GetListLABPartyAddressHistoryByLABPartyId(string lABPartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABPartyAddressHistory))
                                                                            .Add(Expression.Eq("LABPartyId", lABPartyId));

            List<LABPartyAddressHistory> listLABPartyAddressHistory = GetLABPartyAddressHistory(detachedCriteria);

            if (listLABPartyAddressHistory != null && listLABPartyAddressHistory.Count > 0)
            {
                return listLABPartyAddressHistory.Select(lABPartyAddressHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyAddressHistoryEntity(lABPartyAddressHistory)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idNumber"></param>
        /// <param name="idType"></param>
        /// <returns></returns>
        internal List<LABPartyHistoryEntity> GetListLABPartyHistory(string idNumber, string idType)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABPartyHistory))
                                        .Add(Expression.Eq("IdNumber", idNumber))
                                        .CreateCriteria("MPersonIDType")
                                        .Add(Expression.Eq("IDTypeCode", idType));

            List<LABPartyHistory> listLABPartyHistory = GetLABPartyHistory(detachedCriteria);

            if (listLABPartyHistory != null && listLABPartyHistory.Count > 0)
            {
                return listLABPartyHistory.Select(lABPartyHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyHistoryEntity(lABPartyHistory)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LABPartyHistoryEntity
        /// </summary>
        /// <param name="lABPartyId">The LAB Party Id.<param>
        /// <returns></returns>
        internal List<LABPartyHistoryEntity> GetListLABPartyHistoryByLABPartyId(string lABPartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABPartyHistory))
                                                                            .Add(Expression.Eq("LABPartyId", lABPartyId));

            List<LABPartyHistory> listLABPartyHistory = GetLABPartyHistory(detachedCriteria);

            if (listLABPartyHistory != null && listLABPartyHistory.Count > 0)
            {
                return listLABPartyHistory.Select(lABPartyHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyHistoryEntity(lABPartyHistory)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LABPartyHistoryEntity
        /// </summary>
        /// <param name="lACDocDetailId">The LAC Document Detail Id.<param>
        /// <returns></returns>
        internal List<LABPartyHistoryEntity> GetListLABPartyHistoryByLACDocDetailId(string lACDocDetailId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABPartyHistory))
                                                                            .Add(Expression.Eq("LACDocDetailId", lACDocDetailId));

            List<LABPartyHistory> listLABPartyHistory = GetLABPartyHistory(detachedCriteria);

            if (listLABPartyHistory != null && listLABPartyHistory.Count > 0)
            {
                return listLABPartyHistory.Select(lABPartyHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyHistoryEntity(lABPartyHistory)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LABPartySolicitorEntity
        /// </summary>
        /// <param name="lABPartyId">The LAB Party Id.<param>
        /// <returns></returns>
        internal List<LABPartySolicitorEntity> GetListLABPartySolicitorByLABPartyId(string lABPartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABPartySolicitor))
                                                                            .Add(Expression.Eq("LABPartyId", lABPartyId));

            List<LABPartySolicitor> listLABPartySolicitor = GetLABPartySolicitor(detachedCriteria);

            if (listLABPartySolicitor != null && listLABPartySolicitor.Count > 0)
            {
                return listLABPartySolicitor.Select(lABPartySolicitor => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartySolicitorEntity(lABPartySolicitor)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAB Party History Id and gets the LABPartySolicitorHistoryEntity
        /// </summary>
        /// <param name="lABPartyHistoryId">The LAB Party History Id.<param>
        /// <returns></returns>
        internal List<LABPartySolicitorHistoryEntity> GetListLABPartySolicitorHistoryByLABPartyHistoryId(string lABPartyHistoryId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABPartySolicitorHistory))
                                                                            .Add(Expression.Eq("LABPartyHistoryId", lABPartyHistoryId));

            List<LABPartySolicitorHistory> listLABPartySolicitorHistory = GetLABPartySolicitorHistory(detachedCriteria);

            if (listLABPartySolicitorHistory != null && listLABPartySolicitorHistory.Count > 0)
            {
                return listLABPartySolicitorHistory.Select(lABPartySolicitorHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartySolicitorHistoryEntity(lABPartySolicitorHistory)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LABPartySolicitorHistoryEntity
        /// </summary>
        /// <param name="lABPartyId">The LAB Party Id.<param>
        /// <returns></returns>
        internal List<LABPartySolicitorHistoryEntity> GetListLABPartySolicitorHistoryByLABPartyId(string lABPartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABPartySolicitorHistory))
                                                                            .Add(Expression.Eq("LABPartyId", lABPartyId));

            List<LABPartySolicitorHistory> listLABPartySolicitorHistory = GetLABPartySolicitorHistory(detachedCriteria);

            if (listLABPartySolicitorHistory != null && listLABPartySolicitorHistory.Count > 0)
            {
                return listLABPartySolicitorHistory.Select(lABPartySolicitorHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartySolicitorHistoryEntity(lABPartySolicitorHistory)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LABPartySolicitorHistoryEntity
        /// </summary>
        /// <param name="solicitorId">The Solicitor Id.<param>
        /// <returns></returns>
        internal List<LABPartySolicitorHistoryEntity> GetListLABPartySolicitorHistoryByLABPartyId(long solicitorId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABPartySolicitorHistory))
                                                                            .Add(Expression.Eq("SolicitorID", solicitorId));

            List<LABPartySolicitorHistory> listLABPartySolicitorHistory = GetLABPartySolicitorHistory(detachedCriteria);

            if (listLABPartySolicitorHistory != null && listLABPartySolicitorHistory.Count > 0)
            {
                return listLABPartySolicitorHistory.Select(lABPartySolicitorHistory => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartySolicitorHistoryEntity(lABPartySolicitorHistory)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the Case Info Id and gets the LABSection17CertInfoEntity
        /// </summary>
        /// <param name="caseInfoId">The Case Info Id.<param>
        /// <returns></returns>
        internal List<LABSection17CertInfoEntity> GetListLABSection17CertInfoByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABSection17CertInfo))
                                                                            .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<LABSection17CertInfo> listLABSection17CertInfo = GetLABSection17CertInfo(detachedCriteria);

            if (listLABSection17CertInfo != null && listLABSection17CertInfo.Count > 0)
            {
                return listLABSection17CertInfo.Select(LABSection17CertInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABSection17CertInfoEntity(LABSection17CertInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the Case Party Id and gets the LABSection17CertInfoEntity
        /// </summary>
        /// <param name="CasePartyId">CasePartyId.<param>
        /// <returns></returns>
        internal List<LABSection17CertInfoEntity> GetListLABSection17CertInfoByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABSection17CertInfo))
                                                                            .Add(Expression.Eq("CasePartyId", casePartyId));

            List<LABSection17CertInfo> listLABSection17CertInfo = GetLABSection17CertInfo(detachedCriteria);

            if (listLABSection17CertInfo != null && listLABSection17CertInfo.Count > 0)
            {
                return listLABSection17CertInfo.Select(LABSection17CertInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABSection17CertInfoEntity(LABSection17CertInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the Document Id and gets the LABSection17CertInfoEntity
        /// </summary>
        /// <param name="docId">The Document Id.<param>
        /// <returns></returns>
        internal List<LABSection17CertInfoEntity> GetListLABSection17CertInfoByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABSection17CertInfo))
                                                                            .Add(Expression.Eq("DocId", docId));

            List<LABSection17CertInfo> listLABSection17CertInfo = GetLABSection17CertInfo(detachedCriteria);

            if (listLABSection17CertInfo != null && listLABSection17CertInfo.Count > 0)
            {
                return listLABSection17CertInfo.Select(LABSection17CertInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABSection17CertInfoEntity(LABSection17CertInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the User Id and gets the LACCancellationInfoEntity
        /// </summary>
        /// <param name="UserId">The User Id.<param>
        /// <returns></returns>
        internal List<LACCancellationInfoEntity> GetListLACCancellationInfoByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LACCancellationInfo))
                                                                            .Add(Expression.Eq("DocId", docId));

            List<LACCancellationInfo> listLACCancellationInfo = GetLACCancellationInfo(detachedCriteria);

            if (listLACCancellationInfo != null && listLACCancellationInfo.Count > 0)
            {
                return listLACCancellationInfo.Select(LACCancellationInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACCancellationInfoEntity(LACCancellationInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the Solicitor Id and gets the LACCancellationInfoEntity
        /// </summary>
        /// <param name="solicitorId">The Solicitor Id.<param>
        /// <returns></returns>
        internal List<LACCancellationInfoEntity> GetListLACCancellationInfoByLACInfoId(string lACInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LACCancellationInfo))
                                                                            .Add(Expression.Eq("LACInfoId", lACInfoId));

            List<LACCancellationInfo> listLACCancellationInfo = GetLACCancellationInfo(detachedCriteria);

            if (listLACCancellationInfo != null && listLACCancellationInfo.Count > 0)
            {
                return listLACCancellationInfo.Select(LACCancellationInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACCancellationInfoEntity(LACCancellationInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the Doc Id and gets the LACDocumentDetailEntity
        /// </summary>
        /// <param name="docId">The Document Id.<param>
        /// <returns></returns>
        internal List<LACDocumentDetailEntity> GetListLACDocumentDetailByDocId(string docId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LACDocumentDetail))
                                                                            .Add(Expression.Eq("DocId", docId));

            List<LACDocumentDetail> listLACDocumentDetail = GetLACDocumentDetail(detachedCriteria);

            if (listLACDocumentDetail != null && listLACDocumentDetail.Count > 0)
            {
                return listLACDocumentDetail.Select(lACDocumentDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACDocumentDetailEntity(lACDocumentDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAC info Id and gets the LACDocumentDetailEntity
        /// </summary>
        /// <param name="lACInfoId">The LAC Infor Id.<param>
        /// <returns></returns>
        internal List<LACDocumentDetailEntity> GetListLACDocumentDetailByLACInfoId(string lACInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LACDocumentDetail))
                                                                            .Add(Expression.Eq("LACInfoId", lACInfoId));

            List<LACDocumentDetail> listLACDocumentDetail = GetLACDocumentDetail(detachedCriteria);

            if (listLACDocumentDetail != null && listLACDocumentDetail.Count > 0)
            {
                return listLACDocumentDetail.Select(lACDocumentDetail => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACDocumentDetailEntity(lACDocumentDetail)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAC info Id and gets the LACDocumentDraftEntity
        /// </summary>
        /// <param name="caseInfoId">The Case Infor Id.<param>
        /// <returns></returns>
        internal List<LACDocumentDraftEntity> GetListLACDocumentDraftByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LACDocumentDraft))
                                                                            .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<LACDocumentDraft> listLACDocumentDraft = GetLACDocumentDraft(detachedCriteria);

            if (listLACDocumentDraft != null && listLACDocumentDraft.Count > 0)
            {
                return listLACDocumentDraft.Select(lACDocumentDraft => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACDocumentDraftEntity(lACDocumentDraft)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the Doc Id and gets the LACDocumentDraftEntity
        /// </summary>
        /// <param name="casePartyId">The Case Party Id.<param>
        /// <returns></returns>
        internal List<LACDocumentDraftEntity> GetListLACDocumentDraftByCasePartyId(string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LACDocumentDraft))
                                                                            .Add(Expression.Eq("CasePartyId", casePartyId));

            List<LACDocumentDraft> listLACDocumentDraft = GetLACDocumentDraft(detachedCriteria);

            if (listLACDocumentDraft != null && listLACDocumentDraft.Count > 0)
            {
                return listLACDocumentDraft.Select(lACDocumentDraft => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACDocumentDraftEntity(lACDocumentDraft)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the Doc Id and gets the LACDocumentDraftEntity
        /// </summary>
        /// <param name="lACDocDetailId">The Document Detail Id.<param>
        /// <returns></returns>
        internal List<LACDocumentDraftEntity> GetListLACDocumentDraftByLACDocDetailId(string lACDocDetailId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LACDocumentDraft))
                                                                            .Add(Expression.Eq("LACDocDetailId", lACDocDetailId));

            List<LACDocumentDraft> listLACDocumentDraft = GetLACDocumentDraft(detachedCriteria);

            if (listLACDocumentDraft != null && listLACDocumentDraft.Count > 0)
            {
                return listLACDocumentDraft.Select(lACDocumentDraft => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACDocumentDraftEntity(lACDocumentDraft)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAC Document Detail Id and gets the LACDocumentRemarkEntity
        /// </summary>
        /// <param name="LACDocDetailId">The LAC Document Detail Id.<param>
        /// <returns></returns>
        internal List<LACDocumentRemarkEntity> GetListLACDocumentRemarkByLACDocDetailId(string lACDocDetailId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LACDocumentRemark))
                                                                            .Add(Expression.Eq("LACDocDetailId", lACDocDetailId));

            List<LACDocumentRemark> listLACDocumentRemark = GetLACDocumentRemark(detachedCriteria);

            if (listLACDocumentRemark != null && listLACDocumentRemark.Count > 0)
            {
                return listLACDocumentRemark.Select(lACDocumentRemark => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACDocumentRemarkEntity(lACDocumentRemark)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LACInfoEntity
        /// </summary>
        /// <param name="lABPartyId">The Case Info Id.<param>
        /// <returns></returns>
        internal List<LACInfoEntity> GetListLACInfoByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LACInfo))
                                                                            .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<LACInfo> listLACInfo = GetLACInfo(detachedCriteria);

            if (listLACInfo != null && listLACInfo.Count > 0)
            {
                return listLACInfo.Select(lACInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACInfoEntity(lACInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LACInfoEntity
        /// </summary>
        /// <param name="lABPartyId">The LAB Party Id.<param>
        /// <returns></returns>
        internal List<LACInfoEntity> GetListLACInfoByLABPartyId(string lABPartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LACInfo))
                                                                            .Add(Expression.Eq("LABPartyId", lABPartyId));

            List<LACInfo> listLACInfo = GetLACInfo(detachedCriteria);

            if (listLACInfo != null && listLACInfo.Count > 0)
            {
                return listLACInfo.Select(lACInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLACInfoEntity(lACInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Save the LABPartyEntity.
        /// </summary>
        /// <param name="LABPartyEntity">The LABParty domain object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLABParty(LABPartyEntity lABPartyEntity)
        {
            IRepository<LABParty> lABPartyRepository = new RepositoryImpl<LABParty>(applicationSession);
            lABPartyRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLABParty(lABPartyEntity));
        }

        /// <summary>
        /// Save the LABPartyAddressEntity.
        /// </summary>
        /// <param name="LABPartyEntity">The LABPartyAddress domain object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLABPartyAddress(LABPartyAddressEntity lABPartyAddressEntity)
        {
            IRepository<LABPartyAddress> lABPartyAddressRepository = new RepositoryImpl<LABPartyAddress>(applicationSession);
            lABPartyAddressRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLABPartyAddress(lABPartyAddressEntity));
        }

        /// <summary>
        /// Save the LABPartyAddressHistoryEntity.
        /// </summary>
        /// <param name="LABPartyEntity">The LABPartyAddressHistory domain object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLABPartyAddressHistory(LABPartyAddressHistoryEntity lABPartyAddressHistoryEntity)
        {
            IRepository<LABPartyAddressHistory> lABPartyAddressHistoryRepository = new RepositoryImpl<LABPartyAddressHistory>(applicationSession);
            lABPartyAddressHistoryRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLABPartyAddressHistory(lABPartyAddressHistoryEntity));
        }

        /// <summary>
        /// Save the LABPartyData.
        /// </summary>
        /// <param name="ILABParty">The Interface for LAB Party Data object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLABPartyData(ILABPartyData iLABParty)
        {
            try
            {
                LABPartyData lABPartyData = iLABParty as LABPartyData;

                if (lABPartyData.LABParty != null)
                {
                    this.SaveOrUpdateLABParty(lABPartyData.LABParty);

                    if (lABPartyData.ListLABPartyAddress != null)
                    {
                        foreach (LABPartyAddressEntity lABPartyAddress in lABPartyData.ListLABPartyAddress)
                        {
                            this.SaveOrUpdateLABPartyAddress(lABPartyAddress);
                        }
                    }

                    if (lABPartyData.ListLABPartySolicitors != null)
                    {
                        foreach (LABPartySolicitorEntity lABPartySolicitor in lABPartyData.ListLABPartySolicitors)
                        {
                            this.SaveOrUpdateLABPartySolicitor(lABPartySolicitor);
                        }
                    }
                }
            }
            catch { throw; }
        }

        /// <summary>
        /// Save the LABPartyHistoryEntity.
        /// </summary>
        /// <param name="LABPartyEntity">The LABPartyHistory domain object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLABPartyHistory(LABPartyHistoryEntity lABPartyHistoryEntity)
        {
            IRepository<LABPartyHistory> lABPartyHistoryRepository = new RepositoryImpl<LABPartyHistory>(applicationSession);
            lABPartyHistoryRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLABPartyHistory(lABPartyHistoryEntity));
        }

        /// <summary>
        /// Save the LABPartyHistoryData.
        /// </summary>
        /// <param name="ILABPartyHistory">The Interface for LAB Party History Data object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLABPartyHistoryData(ILABPartyHistoryData iLABPartyHistory)
        {
            try
            {
                LABPartyHistoryData lABPartyHistoryData = iLABPartyHistory as LABPartyHistoryData;
                if (lABPartyHistoryData.LABPartyHistory != null)
                {
                    this.SaveOrUpdateLABPartyHistory(lABPartyHistoryData.LABPartyHistory);
                }
                if (lABPartyHistoryData.ListLABPartyAddressHistory != null && lABPartyHistoryData.ListLABPartyAddressHistory.Count > 0)
                {
                    foreach (LABPartyAddressHistoryEntity lABPartyAddressHistory in lABPartyHistoryData.ListLABPartyAddressHistory)
                    {
                        this.SaveOrUpdateLABPartyAddressHistory(lABPartyAddressHistory);
                    }
                }

                if (lABPartyHistoryData.ListLABPartySolicitorHistory != null && lABPartyHistoryData.ListLABPartySolicitorHistory.Count > 0)
                {
                    foreach (LABPartySolicitorHistoryEntity lABPartySolicitorHistory in lABPartyHistoryData.ListLABPartySolicitorHistory)
                    {
                        this.SaveOrUpdateLABPartySolicitorHistory(lABPartySolicitorHistory);
                    }
                }
            }
            catch { throw; }
        }

        /// <summary>
        /// Save the LABPartySolicitorEntity.
        /// </summary>
        /// <param name="LABPartyEntity">The LABPartySolicitor domain object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLABPartySolicitor(LABPartySolicitorEntity lABPartySolicitorEntity)
        {
            IRepository<LABPartySolicitor> lABPartySolicitorRepository = new RepositoryImpl<LABPartySolicitor>(applicationSession);
            lABPartySolicitorRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLABPartySolicitor(lABPartySolicitorEntity));
        }

        /// <summary>
        /// Save the LABPartySolicitorHistoryEntity.
        /// </summary>
        /// <param name="LABPartyEntity">The LABPartySolicitorHistory domain object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLABPartySolicitorHistory(LABPartySolicitorHistoryEntity lABPartySolicitorHistoryEntity)
        {
            IRepository<LABPartySolicitorHistory> lABPartySolicitorHistoryRepository = new RepositoryImpl<LABPartySolicitorHistory>(applicationSession);
            lABPartySolicitorHistoryRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLABPartySolicitorHistory(lABPartySolicitorHistoryEntity));
        }

        /// <summary>
        /// Save the LABSection17CertInfoEntity.
        /// </summary>
        /// <param name="LABPartyEntity">The LABSection17CertInfo domain object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLABSection17CertInfo(LABSection17CertInfoEntity lABSection17CertInfoEntity)
        {
            IRepository<LABSection17CertInfo> lABSection17CertInfoRepository = new RepositoryImpl<LABSection17CertInfo>(applicationSession);
            lABSection17CertInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLABSection17CertInfo(lABSection17CertInfoEntity));
        }

        /// <summary>
        /// Save the LACCancellationInfoEntity.
        /// </summary>
        /// <param name="LABPartyEntity">The LACCancellationInfo domain object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLACCancellationInfo(LACCancellationInfoEntity lACCancellationInfoEntity)
        {
            IRepository<LACCancellationInfo> lACCancellationInfoRepository = new RepositoryImpl<LACCancellationInfo>(applicationSession);
            lACCancellationInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLACCancellationInfo(lACCancellationInfoEntity));
        }

        /// <summary>
        /// Save the LACDocumentDetailEntity.
        /// </summary>
        /// <param name="LABPartyEntity">The LACDocumentDetail domain object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLACDocumentDetail(LACDocumentDetailEntity lACDocumentDetailEntity)
        {
            IRepository<LACDocumentDetail> lACDocumentDetailRepository = new RepositoryImpl<LACDocumentDetail>(applicationSession);
            lACDocumentDetailRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLACDocumentDetail(lACDocumentDetailEntity));
        }

        /// <summary>
        /// Save the LACDocumentDraftEntity.
        /// </summary>
        /// <param name="LABPartyEntity">The LACDocumentDraft domain object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLACDocumentDraft(LACDocumentDraftEntity lACDocumentDraftEntity)
        {
            IRepository<LACDocumentDraft> lACDocumentDraftRepository = new RepositoryImpl<LACDocumentDraft>(applicationSession);
            lACDocumentDraftRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLACDocumentDraft(lACDocumentDraftEntity));
        }

        /// <summary>
        /// Save the LACDocumentRemarkEntity.
        /// </summary>
        /// <param name="LABPartyEntity">The LACDocumentRemark domain object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLACDocumentRemark(LACDocumentRemarkEntity lACDocumentRemarkEntity)
        {
            IRepository<LACDocumentRemark> lACDocumentRemarkRepository = new RepositoryImpl<LACDocumentRemark>(applicationSession);
            lACDocumentRemarkRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLACDocumentRemark(lACDocumentRemarkEntity));
        }

        /// <summary>
        /// Save the LACInfoEntity.
        /// </summary>
        /// <param name="LABPartyEntity">The LACInfo domain object.</param>
        /// <returns></returns>
        internal void SaveOrUpdateLACInfo(LACInfoEntity lACInfoEntity)
        {
            IRepository<LACInfo> lACInfoRepository = new RepositoryImpl<LACInfo>(applicationSession);
            lACInfoRepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLACInfo(lACInfoEntity));
        }

        private List<LABPartyHistory> GetAllLABPartyHistory(DetachedCriteria detachedCriteria)
        {
            IRepository<LABPartyHistory> lABPartyHistoryRepository = new RepositoryImpl<LABPartyHistory>(applicationSession);
            return lABPartyHistoryRepository.GetAll(detachedCriteria).ToList();
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria 
        /// </summary>
        /// <typeparam name="T">Type to delete.</typeparam>
        /// <param name="columneNames">The fields name and values of domain entity to use for deletion.</param>
        /// <param name="value">The value to filter.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteria<T, V>(string columnName, V value)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(T))
                                                                 .Add(Expression.Eq(columnName, value));

            return detachedCriteria;
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
        private DetachedCriteria GetDetachedCriteria<T, V>(string fieldName, V fromValue, V toValue)
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
        /// Helper methods to get the DetachedCriteria for "between" values
        /// </summary>
        /// <typeparam name="T">Type to search.</typeparam>
        /// <typeparam name="V">Type to use for between.</typeparam>
        /// <param name="fieldName">The fields name of domain entity to use for deletion.</param>
        /// <param name="fromValue">The start value</param>
        /// <param name="toValue">The end value</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteria<T, V, V2>(string fieldName, V fromValue, V toValue, string columnName2, V2 secondValue)
        {
            Logger.Info("Get " + typeof(T).ToString() + " between: start - " + fieldName + " => end -" + toValue);

            DetachedCriteria detachedCriteria = null;
            try
            {
                detachedCriteria = DetachedCriteria.For(typeof(T))
                                    .Add(Expression.And(
                                        Expression.Between(fieldName, fromValue, toValue),
                                        Expression.Eq(columnName2, secondValue)))
                                    ;

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
        /// <typeparam name="V">The type of the parameter of 'firsValue'.</typeparam>
        /// <typeparam name="V2">The type of the parameter of 'secondValue'.</typeparam>
        /// <param name="firstFieldName">The name of the first field to filter while retrieving the object.</param>
        /// <param name="firstValue">The value of the first field to filter while retrieving the object.</param>
        /// <param name="sencondFieldName">The name of the second field to filter while retrieving the object.</param>
        /// <param name="secondValue">The value of the second field to filter while retrieving the object.</param>
        /// <param name="logicOperator">The logical operator used for query.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteria<T, V, V2>(string firstFieldName, V firstValue, string sencondFieldName, V2 secondValue, LogicalOperator logicOperator)
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

        private List<T> GetFromDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll(detachedCriteria).ToList();
        }

        /// <summary>
        /// Passes the DetachedCriteria and gets the LABParty
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private List<LABParty> GetLABParty(DetachedCriteria detachedCriteria)
        {
            IRepository<LABParty> lABPartyRepository = new RepositoryImpl<LABParty>(applicationSession);
            return lABPartyRepository.GetAll(detachedCriteria) as List<LABParty>;
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LABPartyAddress 
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private List<LABPartyAddress> GetLABPartyAddress(DetachedCriteria detachedCriteria)
        {
            IRepository<LABPartyAddress> lABPartyAddressRepository = new RepositoryImpl<LABPartyAddress>(applicationSession);
            return lABPartyAddressRepository.GetAll(detachedCriteria) as List<LABPartyAddress>;
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LABPartyAddressHistory
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private List<LABPartyAddressHistory> GetLABPartyAddressHistory(DetachedCriteria detachedCriteria)
        {
            IRepository<LABPartyAddressHistory> lABPartyAddressHistoryRepository = new RepositoryImpl<LABPartyAddressHistory>(applicationSession);
            return lABPartyAddressHistoryRepository.GetAll(detachedCriteria) as List<LABPartyAddressHistory>;
        }

        /// <summary>
        /// Passes the DetachedCriteria and gets the LABPartyHistory
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private List<LABPartyHistory> GetLABPartyHistory(DetachedCriteria detachedCriteria)
        {
            IRepository<LABPartyHistory> lABPartyHistoryRepository = new RepositoryImpl<LABPartyHistory>(applicationSession);
            return lABPartyHistoryRepository.GetAll(detachedCriteria) as List<LABPartyHistory>;
        }

        private LABPartyHistoryEntity GetLABPartyHistoryByLABPartyId(string lABPartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABPartyHistory))
                .Add(Expression.Eq("LABPartyId", lABPartyId));

            List<LABPartyHistory> listLABPartyHistory = GetAllLABPartyHistory(detachedCriteria);
            if (listLABPartyHistory != null && listLABPartyHistory.Count > 0)
            {
                return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyHistoryEntity(listLABPartyHistory[0]);
            }
            return null;
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LABPartySolicitor
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private List<LABPartySolicitor> GetLABPartySolicitor(DetachedCriteria detachedCriteria)
        {
            IRepository<LABPartySolicitor> lABPartySolicitorRepository = new RepositoryImpl<LABPartySolicitor>(applicationSession);
            return lABPartySolicitorRepository.GetAll(detachedCriteria) as List<LABPartySolicitor>;
        }

        /// <summary>
        /// Passes the LAB Party Id and gets the LABPartySolicitorHistory
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private List<LABPartySolicitorHistory> GetLABPartySolicitorHistory(DetachedCriteria detachedCriteria)
        {
            IRepository<LABPartySolicitorHistory> lABPartySolicitorHistoryRepository = new RepositoryImpl<LABPartySolicitorHistory>(applicationSession);
            return lABPartySolicitorHistoryRepository.GetAll(detachedCriteria) as List<LABPartySolicitorHistory>;
        }

        /// <summary>
        /// Passes NHibernate criteria and gets the LABSection17CertInfo
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private List<LABSection17CertInfo> GetLABSection17CertInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<LABSection17CertInfo> lABSection17CertInfoRepository = new RepositoryImpl<LABSection17CertInfo>(applicationSession);
            return lABSection17CertInfoRepository.GetAll(detachedCriteria) as List<LABSection17CertInfo>;
        }

        /// <summary>
        /// Passes NHibernate criteria and gets the LACCancellationInfo
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private List<LACCancellationInfo> GetLACCancellationInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<LACCancellationInfo> lACCancellationInfoRepository = new RepositoryImpl<LACCancellationInfo>(applicationSession);
            return lACCancellationInfoRepository.GetAll(detachedCriteria) as List<LACCancellationInfo>;
        }

        /// <summary>
        /// Passes NHibernate criteria and gets the LACDocumentDetail
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private List<LACDocumentDetail> GetLACDocumentDetail(DetachedCriteria detachedCriteria)
        {
            IRepository<LACDocumentDetail> lACDocumentDetailRepository = new RepositoryImpl<LACDocumentDetail>(applicationSession);
            return lACDocumentDetailRepository.GetAll(detachedCriteria) as List<LACDocumentDetail>;
        }

        /// <summary>
        /// Passes NHibernate criteria and gets the LACDocumentDraft
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private List<LACDocumentDraft> GetLACDocumentDraft(DetachedCriteria detachedCriteria)
        {
            IRepository<LACDocumentDraft> lACDocumentDraftRepository = new RepositoryImpl<LACDocumentDraft>(applicationSession);
            return lACDocumentDraftRepository.GetAll(detachedCriteria) as List<LACDocumentDraft>;
        }

        /// <summary>
        /// Passes NHibernate criteria and gets the LACDocumentRemark
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private List<LACDocumentRemark> GetLACDocumentRemark(DetachedCriteria detachedCriteria)
        {
            IRepository<LACDocumentRemark> lACDocumentRemarkRepository = new RepositoryImpl<LACDocumentRemark>(applicationSession);
            return lACDocumentRemarkRepository.GetAll(detachedCriteria) as List<LACDocumentRemark>;
        }

        /// <summary>
        /// Passes NHibernate criteria and gets the LACInfo
        /// </summary>
        /// <param name="detachedCriteria">The NHibernate criteria for retriving.<param>
        /// <returns></returns>
        private List<LACInfo> GetLACInfo(DetachedCriteria detachedCriteria)
        {
            IRepository<LACInfo> lACInfoRepository = new RepositoryImpl<LACInfo>(applicationSession);
            return lACInfoRepository.GetAll(detachedCriteria) as List<LACInfo>;
        }

        internal List<LABSection17CertInfoEntity> GetListLABSection17CertInfo(string caseInfoId, string casePartyId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<LABSection17CertInfo>()
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)))
                .Add(Expression.Eq("CasePartyId", casePartyId));

            List<LABSection17CertInfo> listLABSection17CertInfo = GetFromDetachedCriteria<LABSection17CertInfo>(detachedCriteria);

            if (listLABSection17CertInfo != null && listLABSection17CertInfo.Count > 0)
            {
                return listLABSection17CertInfo.Select(lABSection17CertInfo => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABSection17CertInfoEntity(lABSection17CertInfo)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal void DeleteSolicitorAddress(long solicitorId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<SolicitorAddress>()
                                      .Add(Expression.Eq("SolicitorID", solicitorId));


            Repository<SolicitorAddress>().DeleteAll(detachedCriteria);
        }

        #endregion Methods

        #region Other

        //General Methods
        /// <summary>
        /// Get a list of LABPartyHistoryEntity by ID Number and ID Type Code.
        /// </summary>
        /// <param name="idNumber">ID Number</param>
        /// <param name="idType">MPersonIdType's IDTypeCode</param>
        /// <returns>List<LABPartyHistoryEntity></returns> 
        //internal List<LABPartyHistoryEntity> GetListLABPartyHistory(string idNumber, string idType)
        //{
        //    DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABPartyHistory))
        //                                                                .Add(Expression.Eq("IdNumber", idNumber));
        //    List<LABPartyHistory> listLABPartyHistory = GetLABPartyHistory(detachedCriteria);
        //    if (listLABPartyHistory != null && listLABPartyHistory.Count > 0)
        //    {
        //        return listLABPartyHistory.Select(lABPartyHistory =>
        //            AllInOne.Legal.DataMapper.FrontEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyHistoryEntity(lABPartyHistory))
        //                                .Where(lABPartyHistory =>
        //                                        lABPartyHistory.IdNumber == idNumber &&
        //                                        lABPartyHistory.MPersonIDType.IDTypeCode == idType).ToList();
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        /// <summary>
        /// Get a list of LABPartyEntity by ID Number and ID Type Code.
        /// </summary>
        /// <param name="idNumber">ID Number</param>
        /// <param name="idType">MPersonIdType's IDTypeCode</param>
        /// <returns>List<LABPartyEntityEntity></returns> 
        //internal List<LABPartyEntity> GetListLABParty(string idNumber, string idType)
        //{
        //    DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LABParty))
        //                                                                .Add(Expression.Eq("IdNumber", idNumber));
        //    List<LABParty> listLABPartyEntity = GetLABParty(detachedCriteria);
        //    //Refactor -- search for a way to use DtachedCriteria instead of filtering out with Linq.
        //    if (listLABPartyEntity != null && listLABPartyEntity.Count > 0)
        //    {
        //        return listLABPartyEntity.Select(lABPartyEntity =>
        //            AllInOne.Legal.DataMapper.FrontEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLABPartyEntity(lABPartyEntity))
        //            //.Where(lABPartyEntity =>
        //            //        lABPartyEntity.IdNumber == idNumber &&
        //            //        lABPartyEntity.MPersonIDType.IDTypeCode == idType).ToList();
        //                                .Where(delegate(LABPartyEntity lABPartyEntity)
        //                                {
        //                                    return (lABPartyEntity.IdNumber == idNumber && lABPartyEntity.MPersonIDType.IDTypeCode == idType);
        //                                }).ToList();
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        #endregion Other



     
        /// <summary>
        /// Gets the repository.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private IRepository<T> Repository<T>()
        {
            return new RepositoryImpl<T>(applicationSession);
        }
    }
}