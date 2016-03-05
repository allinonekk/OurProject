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
    using AllInOne.Legal.Domain.Hospital;
    


    internal class PatientGateway
    {
        #region Fields

        private ISession applicationSession;

        private static readonly ILog Logger = LogManager.GetLogger(typeof(PatientGateway));

        #endregion Fields

        #region Constructors

        internal PatientGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;
        }

        #endregion Constructors

        #region Methods


        #endregion Methods

        internal PatientInfoEntity  GetPatientInfoEntity(string patientId)
        {
            try
            {
                PatientInfoEntity patientInfoEntity = new PatientInfoEntity();
                IRepository<PatientInfo> patientInfoRepository = new RepositoryImpl<PatientInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PatientInfo))
                                                                   .Add(Expression.Eq("PatientId", patientId));
                List<PatientInfo> listpatientInfo = patientInfoRepository.GetAll(detachedCriteria) as List<PatientInfo>;
                if (listpatientInfo != null && listpatientInfo.Count > 0)
                {
                    foreach (PatientInfo adMInfo in listpatientInfo)
                    {
                        patientInfoEntity = AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.HospitalMapper.GetPatientInfoEntity(adMInfo);
                    }
                }
                else
                    patientInfoEntity = null;

                return patientInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPatientInfoEntity", ex);
                throw;
            }
        }

        private List<T> GetAllFromRepository<T>()
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll() as List<T>;
        }       
    }
}