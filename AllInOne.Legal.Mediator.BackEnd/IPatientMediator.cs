
namespace AllInOne.Legal.Mediator.BackEnd
{
    using System.Collections.Generic;
    using AllInOne.Legal.Domain.Audit;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Hospital;

    public interface IPatientMediator
    {
        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        /// <param name="sender"></param>
        void BeginTransaction();

        /// <summary>
        /// Method to Close the session.
        /// </summary>
        void CloseSession();

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        void CommitAndCloseSession();

        /// <summary>
        /// Saves the or update audit entity.
        /// </summary>
        /// <param name="auditEntity">The audit entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdatePatientInfoEntity(PatientInfoEntity  patientEntity, bool isCopy);

        /// <summary>
        /// Gets all audit module visit.
        /// </summary>
        /// <returns></returns>
        PatientInfoEntity GetPatientInfoEntity(string patientId);

        #endregion
    }
}