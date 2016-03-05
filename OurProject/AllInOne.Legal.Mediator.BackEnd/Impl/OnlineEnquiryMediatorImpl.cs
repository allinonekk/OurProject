namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System.Collections.Generic;

    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Data;

    using log4net;

    public class OnlineEnquiryMediatorImpl : IOnlineEnquiryMediator
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OnlineEnquiryMediatorImpl));

        #endregion Fields

        #region Methods

        public List<JudicialUserEntity> GetAllJudicialUserEntity()
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetAllJudicialUserEntity();
        }

        public List<JudicialUserEntity> GetListJudicialUserEntity(string sectionCode)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListJudicialUserEntity(sectionCode);
        }

        public List<MSectionEntity> GetListMSectionEntityByUser(string userId)
        {
            MasterGateway masterGateway = new MasterGateway();
            return masterGateway.GetListMsectionByUser(userId);
        }

        public List<ReportConfigUserEntity> GetListReportConfigUserEntity(string reportConfigInfoId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListReportConfigUserEntityByReportConfigInfoId(reportConfigInfoId);
        }

        public List<ReportConfigInfoEntity> GetReportConfigInfoEntity(string reportTitle, OnlineEnquiryReportType reportType)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetReportConfigInfo(reportTitle, reportType);
        }

        public ReportConfigInfoEntity GetReportConfigInfoEntityByPk(string reportConfigInfoId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetReportConfigInfoByPK(reportConfigInfoId);
        }

        public void SaveOrUpdateBackEndSpecificEntity(IBackEndSpecificEntity ibackEndSpecificEntity, bool isCopy)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            if (isCopy)
                backEndSpecificGateway.SaveOrUpdateInMemoryEntity<IBackEndSpecific>(BackEndSpecificMapper.GetBackEndSpecificEntity<IBackEndSpecificEntity>(ibackEndSpecificEntity));
            else
                backEndSpecificGateway.SaveOrUpdateEntity<IBackEndSpecific>(BackEndSpecificMapper.GetBackEndSpecificEntity<IBackEndSpecificEntity>(ibackEndSpecificEntity));
        }


        public List<JudicialUserEntity> GetListJudicialUserEntity(string reportConfigInfoId, string sectionCode)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListReportConfigUserEntity(reportConfigInfoId, sectionCode);
        }

        public List<JudicialUserEntity> GetListJudicialUserEntityByReportConfigInfoId(string reportConfigInfoId)
        {
            BackEndSpecificGateway backEndSpecificGateway = new BackEndSpecificGateway();
            return backEndSpecificGateway.GetListJudicialUserEntityByReportConfigInfoId(reportConfigInfoId);
        }

        #endregion

    }
}