namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System.Collections.Generic;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using NHibernate;
    using NHibernate.Criterion;

    internal class InterfaceICAGateway
    {
        #region Fields

        private ISession applicationSession;

        #endregion Fields

        #region Constructors

        internal InterfaceICAGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;

            //MappingToDTO mappingToDTO = new MappingToDTO();
            //mappingToDTO.MapAll();

            //MappingToDomain mappingToDomain = new MappingToDomain();
            //mappingToDomain.MapAll();
        }

        #endregion Constructors

        #region Methods

        internal void DeleteInterfaceICAByStatus(ICAInterfaceStatus iCAInterfaceStatus)
        {
            IRepository<InterfaceICA> interfaceICARepository = new RepositoryImpl<InterfaceICA>(applicationSession);

            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(InterfaceICA))
                                                                .Add(Expression.Eq("Status", iCAInterfaceStatus.ToString()));
            DeleteAll(detachedCriteria);
        }

        internal List<InterfaceICAEntity> GetAllInterfaceICAEntity()
        {
            List<InterfaceICA> listInterfaceICA;
            List<InterfaceICAEntity> listInterfaceICAEntity = new List<InterfaceICAEntity>();
            InterfaceICAEntity interfaceICAEntity = new InterfaceICAEntity();
            IRepository<InterfaceICA> interfaceICARepository = new RepositoryImpl<InterfaceICA>(applicationSession);
            listInterfaceICA = interfaceICARepository.GetAll() as List<InterfaceICA>;

            if (listInterfaceICA != null && listInterfaceICA.Count > 0)
            {
                foreach (InterfaceICA interfaceICA in listInterfaceICA)
                {
                    interfaceICAEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetInterfaceICAEntity(interfaceICA);
                    listInterfaceICAEntity.Add(interfaceICAEntity);
                }
            }
            else
                listInterfaceICAEntity = null;
            return listInterfaceICAEntity;
        }

        internal List<InterfaceICAEntity> GetAllInterfaceICAEntityByStatus()
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(InterfaceICA))
                .Add(Expression.Not(NHibernate.Criterion.Restrictions.Eq("Status", "C")));

            List<InterfaceICA> listInterfaceICA;
            List<InterfaceICAEntity> listInterfaceICAEntity = new List<InterfaceICAEntity>();
            InterfaceICAEntity interfaceICAEntity = new InterfaceICAEntity();
            IRepository<InterfaceICA> interfaceICARepository = new RepositoryImpl<InterfaceICA>(applicationSession);
            listInterfaceICA = interfaceICARepository.GetAll(detachedCriteria) as List<InterfaceICA>;
            if (listInterfaceICA != null && listInterfaceICA.Count > 0)
            {
                foreach (InterfaceICA interfaceICA in listInterfaceICA)
                {
                    interfaceICAEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetInterfaceICAEntity(interfaceICA);
                    listInterfaceICAEntity.Add(interfaceICAEntity);
                }
            }
            else
                listInterfaceICAEntity = null;
            return listInterfaceICAEntity;
        }

        internal InterfaceICAEntity GetInterfaceICAByPK(string iCAInterfaceId)
        {
            IRepository<InterfaceICA> interfaceICARepository = new RepositoryImpl<InterfaceICA>(applicationSession);
            InterfaceICA interfaceICA = interfaceICARepository.Get(iCAInterfaceId);

            return AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetInterfaceICAEntity(interfaceICA);
        }

        internal void SaveOrUpdateInterfaceICAEntity(InterfaceICAEntity interfaceICAEntity)
        {
            IRepository<InterfaceICA> interfaceICARepository = new RepositoryImpl<InterfaceICA>(applicationSession);
            interfaceICARepository.SaveOrUpdate(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.ExternalMapper.GetInterfaceICA(interfaceICAEntity));
        }

        private void DeleteAll(DetachedCriteria criteria)
        {
            foreach (object entity in criteria.GetExecutableCriteria(applicationSession).List())
            {
                applicationSession.Delete(entity);
            }
        }

        #endregion Methods
    }
}