#region Header

/*****************************************************************************************************
* Description : This file represents a standard data access gateway for LawFirm.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   21/01/2011   		       Nithin            	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LawFirmGateway.cs
// Description: Represents a standard data access gateway for LawFirm.
// </summary>
// <copyright file= "LawFirmGateway.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Class represents a standard data access gateway for LawFirm.
    /// </summary>
    internal class LawFirmGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LawFirmGateway));

        /// <summary>
        /// <see cref="ISession"/> instance for Session context.
        /// </summary>
        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LAPGateway"/> class.
        /// </summary>
        internal LawFirmGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;
        }

        #endregion Constructors

        #region Methods

        internal List<LawFirmEntity> GetAllLawFirm()
        {
            List<LawFirm> listLawFirm = GetAllFromRepository<LawFirm>();
            if (listLawFirm != null && listLawFirm.Count > 0)
            {
                return listLawFirm.Select(lawFirm => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LawFirmMapper.GetLawFirmEntity(lawFirm)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal LawFirmEntity GetLawFirmByPK(string lFID)
        {
            IRepository<LawFirm> lawFirmRepository = new RepositoryImpl<LawFirm>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LawFirmMapper.GetLawFirmEntity(lawFirmRepository.Get(lFID));
        }

        internal List<LawFirmAddressEntity> GetListLawFirmAddressByLFID(string lFId)
        {
            LawFirm objLawFirm = new LawFirm();
            objLawFirm.LFID = lFId;
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LawFirmAddress))
                                                                .Add(Expression.Eq("LawFirm", objLawFirm));
            List<LawFirmAddress> listLawFirm = GetAllLawFirmAddress(detachedCriteria);
            if (listLawFirm != null && listLawFirm.Count > 0)
            {
                return listLawFirm.Select(lawFirm => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LawFirmMapper.GetLawFirmAddressEntity(lawFirm)).ToList();
            }
            else
                return null;
        }

        //TODO : Need to Refactor this method
        internal List<SolicitorEntity> GetListSolicitorEntityByLFId(string LFId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<RLawFirmSolicitors>()
                 .Add(Expression.Eq("LFID", LFId));

            IRepository<RLawFirmSolicitors> rLawFirmSolicitorRepository = new RepositoryImpl<RLawFirmSolicitors>(applicationSession);
            IRepository<Solicitor> solicitorRepository = new RepositoryImpl<Solicitor>(applicationSession);
            List<RLawFirmSolicitors> listRLawFirmSolicitors = GetFromDetachedCriteria<RLawFirmSolicitors>(detachedCriteria);

            List<Solicitor> listSolicitor = new List<Solicitor>();
            if (listRLawFirmSolicitors != null && listRLawFirmSolicitors.Count > 0)
            {
                foreach (RLawFirmSolicitors rLawFirmSolicitors in listRLawFirmSolicitors)
                {
                    Solicitor s = solicitorRepository.Get(rLawFirmSolicitors.SolicitorID);
                    if (s != null)
                        listSolicitor.Add(s);
                }

                return listSolicitor.Select(solicitor => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetSolicitorEntity(solicitor)).ToList();
            }
            else
                return null;

            //return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetSolicitorEntity(solicitorRepository.Get(solicitorId));
        }

        internal List<LawFirmEntity> GetSortedLawFirm()
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<LawFirm>()
                .Add(Expression.Eq("ObsInd", YesNo.N.ToString()))
                .AddOrder(new Order("OrganizationName", true));
            List<LawFirm> listLawFirm = GetFromDetachedCriteria<LawFirm>(detachedCriteria);
            if (listLawFirm != null && listLawFirm.Count > 0)
            {
                return listLawFirm.Select(lawFirm => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LawFirmMapper.GetLawFirmEntity(lawFirm)).ToList();
            }
            else
            {
                return null;
            }
        }

        private List<LawFirmAddress> GetAllLawFirmAddress(DetachedCriteria detachedCriteria)
        {
            IRepository<LawFirmAddress> lawFirmAddressRepository = new RepositoryImpl<LawFirmAddress>(applicationSession);
            return lawFirmAddressRepository.GetAll(detachedCriteria).ToList();
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


        internal List<LawFirmAddressEntity> GetAllLawFirmAddress()
        {
            List<LawFirmAddress> listLawFirmAddress = GetAllFromRepository<LawFirmAddress>();
            if (listLawFirmAddress != null && listLawFirmAddress.Count > 0)
            {
                return listLawFirmAddress.Select(lawFirmAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LawFirmMapper.GetLawFirmAddressEntity(lawFirmAddress)).ToList();
            }
            else
            {
                return null;
            }
        }

        private List<T> GetAllFromRepository<T>()
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll() as List<T>;
        }

        internal ILawFirmEntity GetLawFirmEntityByPK<T>(string primaryKey)
        {
            string entityName = typeof(T).Name;
            switch (entityName)
            {
                case ("LawFirmEntity"):
                    return GetLawFirmEntityByPK(primaryKey);
                case ("LawFirmAddressEntity"):
                    return GetLawFirmAddressEntityByPK(primaryKey);
                case ("InterfaceLawSocLawFirmEntity"):
                    return GetInterfaceLawSocLawFirmEntityByPK(primaryKey);
                case ("InterfaceLawSocLawFirmAddressEntity"):
                    return GetInterfaceLawSocLawFirmAddressEntityByPK(primaryKey);
                default:
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetLawFirmEntityByPK");

            }
        }

        private ILawFirmEntity GetInterfaceLawSocLawFirmEntityByPK(string primaryKey)
        {
            IRepository<InterfaceLawSocLawFirm> repository = new RepositoryImpl<InterfaceLawSocLawFirm>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LawFirmMapper.GetInterfaceLawSocLawFirmEntity(repository.Get(primaryKey));

        }

        private ILawFirmEntity GetInterfaceLawSocLawFirmAddressEntityByPK(string primaryKey)
        {
            IRepository<InterfaceLawSocLawFirmAddress> repository = new RepositoryImpl<InterfaceLawSocLawFirmAddress>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LawFirmMapper.GetInterfaceLawSocLawFirmAddressEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the law firm address entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private ILawFirmEntity GetLawFirmAddressEntityByPK(string primaryKey)
        {
            IRepository<LawFirmAddress> repository = new RepositoryImpl<LawFirmAddress>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LawFirmMapper.GetLawFirmAddressEntity(repository.Get(primaryKey));

        }

        /// <summary>
        /// Gets the law firm entity by PK.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        private ILawFirmEntity GetLawFirmEntityByPK(string primaryKey)
        {
            IRepository<LawFirm> repository = new RepositoryImpl<LawFirm>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LawFirmMapper.GetLawFirmEntity(repository.Get(primaryKey));

        }

        
        internal void SaveOrUpdateSolicitorAddress(SolicitorAddressEntity solicitorAddressEntity)
        {
            Logger.Debug("Flushing Session to Sync With DB");
            applicationSession.Flush();
            Logger.Debug("Flushing Session Completed");

            Logger.Debug("SaveOrUpdateSolicitorAddressSP");

            try
            {
                if (solicitorAddressEntity != null)
                {
                    SolicitorAddress solicitorAddress = AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LawFirmMapper.GetSolicitorAddress(solicitorAddressEntity);

                    applicationSession.GetNamedQuery("SaveOrUpdateSolicitorAddressProcedure")
                   .SetParameter("ItemNo", solicitorAddress.ItemNo)
                      .SetParameter("SolicitorID", solicitorAddress.SolicitorID)
                      .SetParameter("FormatInd", solicitorAddress.FormatInd)
                      .SetParameter("AddrType", solicitorAddress.AddrType)
                      .SetParameter("BlkNo", solicitorAddress.BlkNo)
                      .SetParameter("StreetName", solicitorAddress.StreetName)
                      .SetParameter("FloorNo", solicitorAddress.FloorNo)
                      .SetParameter("UnitNo", solicitorAddress.UnitNo)
                      .SetParameter("BuildingName", solicitorAddress.BuildingName)
                      .SetParameter("PostalCode", solicitorAddress.PostalCode)
                      .SetParameter("Address", solicitorAddress.Address)
                      .SetParameter("ObsInd", solicitorAddress.ObsInd)
                      .SetParameter("LastModifiedBy", solicitorAddress.LastModifiedBy)
                      .SetParameter("LastModifiedDate", solicitorAddress.LastModifiedDate)
                      .ExecuteUpdate();
                }
            }
            catch (Exception ex)
            {
                Logger.Error("ERror encountered at SaveOrupdateSolicitorAddress", ex);
                throw;
            }
        }

        internal List<SolicitorEntity> GetListSolicitorByCaseInfoId(string caseInfoId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<Solicitor>()
                .Add(Expression.Eq("CaseInfoId", Convert.ToInt64(caseInfoId)));

            List<Solicitor> listSolicitor = GetFromDetachedCriteria<Solicitor>(detachedCriteria);
            if (listSolicitor != null && listSolicitor.Count > 0)
            {
                return listSolicitor.Select(solicitor => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
                    .LawFirmMapper.GetSolicitorEntity(solicitor)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<SolicitorAddressEntity> GetListSolicitorAddressBySolicitorId(long solicitorId)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<SolicitorAddress>()
                .Add(Expression.Eq("SolicitorID", solicitorId));

            List<SolicitorAddress> listSolicitorAddress = GetFromDetachedCriteria<SolicitorAddress>(detachedCriteria);
            if (listSolicitorAddress != null && listSolicitorAddress.Count > 0)
            {
                return listSolicitorAddress.Select(solicitorAddress => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
                    .LawFirmMapper.GetSolicitorAddressEntity(solicitorAddress)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal List<LawFirmRegistrationEntity> GetAllLawFirmRegistration()
        {
            List<LawFirmRegistration> listLawFirmRegistration = GetAllFromRepository<LawFirmRegistration>();

            if (listLawFirmRegistration != null && listLawFirmRegistration.Count > 0)
            {
                return listLawFirmRegistration.Select(lawFirmRegistration => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain
                    .ObjectMapper.CommonMapper.GetLawFirmRegistrationEntity(lawFirmRegistration)).ToList();

            }
            else
            {
                return null;
            }
        }

        internal List<LawFirmRegistrationEntity> GetListLawFirmRegistrationEntityByLFID(string lfid)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For<LawFirmRegistration>()
                .Add(Expression.Eq("LFID", lfid));
            List<LawFirmRegistration> listLawFirmRegistration = GetFromDetachedCriteria<LawFirmRegistration>(detachedCriteria);
            if (listLawFirmRegistration != null && listLawFirmRegistration.Count > 0)
            {
                return listLawFirmRegistration.Select(lawFirmRegistration => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetLawFirmRegistrationEntity(lawFirmRegistration)).ToList();
            }
            else
            {
                return null;
            }
        }

        internal void UpdateListOfLawFirmRegistration(IList<LawFirmRegistrationEntity> lstLawFirmRegistrationEntity)
        {
            if (lstLawFirmRegistrationEntity != null && lstLawFirmRegistrationEntity.Count > 0)
            {
                var list = lstLawFirmRegistrationEntity.Select(lawFirmRegistrationEntity => AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetLawFirmRegistration(lawFirmRegistrationEntity)).ToList();

                IRepository<LawFirmRegistration> lawFirmRegistrationRepository = new RepositoryImpl<LawFirmRegistration>(applicationSession);
                lawFirmRegistrationRepository.SaveOrUpdate(list, true);
            }
        }

        internal List<LawFirmAddressEntity> GetListLawFirmAddressByLFID(string lFId, string obsInd)
        {
            LawFirm objLawFirm = new LawFirm();
            objLawFirm.LFID = lFId;
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(LawFirmAddress))
                .Add(Expression.Eq("ObsInd", YesNo.N.ToString()) || Expression.IsNull("ObsInd"))
                .Add(Expression.Eq("LawFirm", objLawFirm));
            List<LawFirmAddress> listLawFirm = GetAllLawFirmAddress(detachedCriteria);
            if (listLawFirm != null && listLawFirm.Count > 0)
            {
                return listLawFirm.Select(lawFirm => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LawFirmMapper.GetLawFirmAddressEntity(lawFirm)).ToList();
            }
            else
                return null;
        }

        #endregion Methods



        
    }
}