namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate;
    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper;
    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.CaseData;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Enforcement;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LAP;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.MRelationship;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Domain.SubCaseData;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Domain.WritOfSummons;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;
    using NHibernate.Impl;
    using NHibernate.SqlCommand;
    using NHibernate.Transaction;
    using NHibernate.Transform;

    internal class FinderGatewayService
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(FinderGatewayService));

        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        internal FinderGatewayService()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;
        }

        #endregion Constructors

        #region Methods

        internal int DeleteAll<T>(DetachedCriteria criteria)
        {
            List<T> list = FindAll<T>(criteria);

            if (list.Count > 0)
            {
                IRepository<T> repo = new RepositoryImpl<T>(applicationSession);
                repo.DeleteAll(list);
            }

            return list.Count;
        }

        internal List<T> FindAll<T>(DetachedCriteria criteria)
        {
            List<T> list = new List<T>();
            RepositoryImpl<T> repo = new RepositoryImpl<T>(applicationSession);

            list = repo.FindAll(criteria) as List<T>;

            return list;
        }

        internal List<V> FindAllEntity<T, V>(DetachedCriteria criteria)
        {
            List<T> lst = FindAll<T>(criteria);

            if (lst != null && lst.Count > 0)
                return lst.Select(data => HibernateMapperService.GetEntity<T, V>(data)).ToList();

            return new List<V>();
        }

        internal List<T> FindAsGroup<T>(DetachedCriteria criteria)
        {
            List<T> list = new List<T>();
            RepositoryImpl<T> repo = new RepositoryImpl<T>(applicationSession);

            list = repo.FindAll(criteria) as List<T>;

            return list;
        }

        #endregion Methods
    }
}