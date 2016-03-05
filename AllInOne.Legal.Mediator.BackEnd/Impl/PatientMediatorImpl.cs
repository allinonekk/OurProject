
namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Data;

    using log4net;
using AllInOne.Legal.Domain.Audit;
using System.Collections.Generic;
    using AllInOne.Legal.Domain.Hospital;
    using AllInOne.Legal.Entities.BackEnd;

    public class PatientMediatorImpl:IPatientMediator
    {
        public IPatientInfoMapper mapper;
        public PatientMediatorImpl(IPatientInfoMapper mapper)
        {
            this.mapper = mapper;
        }

        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(PatientMediatorImpl));

        /// </summary>
        private ApplicationSessionManager applicationSessionManager = new ApplicationSessionManager();        

        #endregion Fields

        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        /// <param name="sender"></param>
        public void BeginTransaction()
        {
            Logger.Info("AuditMediatorImpl - BeginTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager.BeginTransaction();

            Logger.Info("AuditMediatorImpl - BeginTransaction ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Close the session.
        /// </summary>
        public void CloseSession()
        {
            Logger.Info("AuditMediatorImpl - CloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CloseSession();

            Logger.Info("AuditMediatorImpl - CloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        public void CommitAndCloseSession()
        {
            Logger.Info("AuditMediatorImpl - CommitAndCloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CommitAndCloseSession();

            Logger.Info("AuditMediatorImpl - CommitAndCloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Saves the or update audit entity.
        /// </summary>
        /// <param name="auditEntity">The audit entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        public void SaveOrUpdatePatientInfoEntity(PatientInfoEntity patientEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<PatientInfo>(mapper.GetPatientInfo(patientEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdatePatientInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdatePatientInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Gets all audit module visit.
        /// </summary>
        /// <returns></returns>
        public PatientInfoEntity GetPatientInfoEntity(string patientInfoId)
        {
            PatientGateway auditGateway=new PatientGateway();
            return auditGateway.GetPatientInfoEntity(patientInfoId);
        }

        #endregion       
    }
}
