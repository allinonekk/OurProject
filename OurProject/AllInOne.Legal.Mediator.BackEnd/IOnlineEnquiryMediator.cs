namespace AllInOne.Legal.Mediator.BackEnd
{
    using System.Collections.Generic;

    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    public interface IOnlineEnquiryMediator
    {
        #region Methods

        /// <summary>
        /// Gets the list of <see cref="UsersEntity "/>
        /// </summary>
        /// <returns>List<see cref="UsersEntity"></see>/></returns>
        List<JudicialUserEntity> GetAllJudicialUserEntity();

        /// <summary>
        /// Gets the list of <see cref="UsersEntity "/>
        /// </summary>
        /// <param name="sectionCode">The sectionCode.</param>
        /// <returns>List<see cref="UsersEntity"></see>/></returns>
        List<JudicialUserEntity> GetListJudicialUserEntity(string sectionCode);

        List<MSectionEntity> GetListMSectionEntityByUser(string userId);

        /// <summary>
        /// Gets the list report config user entity by report config info id.
        /// </summary>
        /// <param name="reportConfigInfoId">The report config info id.</param>
        /// <returns></returns>
        List<ReportConfigUserEntity> GetListReportConfigUserEntity(string reportConfigInfoId);

        /// <summary>
        /// Gets the report config info entity.
        /// </summary>
        /// <param name="reportTitle">The report title.</param>
        /// <param name="reportType">Type of the report.</param>
        /// <returns></returns>
        List<ReportConfigInfoEntity> GetReportConfigInfoEntity(string reportTitle, OnlineEnquiryReportType reportType);

        /// <summary>
        /// Gets the report config info entity by pk.
        /// </summary>
        /// <param name="reportConfigInfoId">The report config info id.</param>
        /// <returns></returns>
        ReportConfigInfoEntity GetReportConfigInfoEntityByPk(string reportConfigInfoId);

        /// <summary>
        /// Saves the or update back end specific entity.
        /// </summary>
        /// <param name="backEndSpecificEntity">The back end specific entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        void SaveOrUpdateBackEndSpecificEntity(IBackEndSpecificEntity backEndSpecificEntity, bool isCopy);

        List<JudicialUserEntity> GetListJudicialUserEntity(string reportConfigInfoId, string sectionCode);

        List<JudicialUserEntity> GetListJudicialUserEntityByReportConfigInfoId(string reportConfigInfoId);
        #endregion Methods
    }
}