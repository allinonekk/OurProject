namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Common.DataAccess.NHibernate;

    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;
    using AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper;
    
    using AllInOne.Legal.Domain.FrontEndSpecific;
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
    
    using log4net;

    using NHibernate;
    using NHibernate.Criterion;
    using NHibernate.SqlCommand;
    using NHibernate.Transform;
    
    internal class SQLGatewayService
    {

        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(SQLGatewayService));
        private ISession applicationSession;
        private Dictionary<String, ArrayList> _parameter;
        #endregion Fields

        #region Constructors

        internal SQLGatewayService()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

            _parameter = new Dictionary<String, ArrayList>();
        }

        #endregion Constructors

        internal List<T> FindAll<T>(string namequery, Dictionary<String, ArrayList> paramlist)
        {
            IQuery sql = applicationSession.GetNamedQuery(namequery);

            foreach (string param in paramlist.Keys)
            {
                ArrayList values = null;

                if (paramlist.TryGetValue(param, out values))
                    sql.SetParameterList(param, values);
            }

            sql = sql.SetResultTransformer(Transformers.AliasToBean<T>());

            return sql.List<T>() as List<T>;
        }

        internal int ExecuteCommitUpdate(string namequery, Dictionary<String, ArrayList> paramlist)
        {
            int update = 0;

            IQuery sql = applicationSession.GetNamedQuery(namequery);

            foreach (string param in paramlist.Keys)
            {
                ArrayList values = null;
                if (paramlist.TryGetValue(param, out values))
                    sql.SetParameterList(param, values);
            }

            update = sql.ExecuteUpdate();
            return update;
        }
    }
}
