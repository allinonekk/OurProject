namespace AllInOne.Legal.Mediator.BackEnd.Data
{

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using System;
    using NHibernate;
    using log4net;
    using System.Collections.Generic;
    using AllInOne.Legal.Domain.Audit;
    using NHibernate.Criterion;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;
    using System.Linq;
    using AllInOne.Legal.Domain.Interfaces;

    internal class AuditGateway
    {
        #region Fields

        private ISession applicationSession;

        private static readonly ILog Logger = LogManager.GetLogger(typeof(AuditGateway));

        #endregion Fields

        #region Constructors

        internal AuditGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

        }

        #endregion Constructors

        #region Methods


        #endregion Methods

        internal List<AuditModuleVisitEntity> GetAllAuditModuleVisit()
        {
            try
            {
                List<AuditModuleVisit> listAuditModuleVisit = GetAllFromRepository<AuditModuleVisit>();
                if (listAuditModuleVisit != null && listAuditModuleVisit.Count > 0)
                {
                    return listAuditModuleVisit.Select(auditModuleVisit => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.AuditMapper.GetAuditModuleVisitEntity(auditModuleVisit)).ToList();
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAllAuditModuleVisit", ex);
                throw;
            }
        }

        private List<T> GetAllFromRepository<T>()
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll() as List<T>;
        }

        internal IAuditEntity GetAuditEntityByPK<T>(string primaryKey)
        {
            string entityName = typeof(T).Name;

            switch (entityName)
            {
                case ("AuditModuleVisitEntity"):
                    return GeAuditModuleVisitEntityByPK(primaryKey);
                default:
                    throw new MissingMethodException("The referenced object is invalid or not implemented at GetMasterEntityByPK");

            }
        }


        private IAuditEntity GeAuditModuleVisitEntityByPK(string primaryKey)
        {
            IRepository<AuditModuleVisit> repository = new RepositoryImpl<AuditModuleVisit>(applicationSession);
            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.AuditMapper.GetAuditModuleVisitEntity(repository.Get(primaryKey));

        }
    }
}