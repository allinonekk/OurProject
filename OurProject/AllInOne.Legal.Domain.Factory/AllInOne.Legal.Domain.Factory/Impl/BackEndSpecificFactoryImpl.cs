#region Header

/*****************************************************************************************************
 * Description : This file represents a standard implementation for BackEndSpecific factory.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 05/01/2011                 Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: BackEndSpecificFactoryImpl.cs
// Description: Represents a standard implementation for BackEndSpecific factory.
// </summary>
// <copyright file= "BackEndSpecificFactoryImpl.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory.Impl
{
    using AllInOne.Legal.Domain.BackEndSpecific;

    /// <summary>
    /// Represents a standard implementation for BackEndSpecific factory.
    /// It inherits from <see cref="IBackEndSpecificFactory"/>.
    /// </summary>
    public class BackEndSpecificFactoryImpl : IBackEndSpecificFactory
    {
        #region Fields

        /// <summary>
        /// Variable to store ApplicationEnvironment.
        /// </summary>
        private ApplicationEnvironment applicationEnvironment;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BackEndSpecificFactoryImpl"/> class.
        /// </summary>
        /// <param name="applicationEnvironment">The application environment.</param>
        public BackEndSpecificFactoryImpl(ApplicationEnvironment applicationEnvironment)
        {
            this.applicationEnvironment = applicationEnvironment;
        }

        #endregion Constructors

        #region Methods

        public BizMonitoringInfoEntity GetBizMonitoringInfoEntityInstance()
        {
            return new BizMonitoringInfoEntity { BizMonitoringInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public OGCIncomingQueueEntity GetOGCIncomingQueueEntityInstance()
        {
            return new OGCIncomingQueueEntity { OGCIncomingQueueId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public ReportConfigInfoEntity GetReportConfigInfoEntityInstance()
        {
            return new ReportConfigInfoEntity { ReportConfigInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public ReportConfigUserEntity GetReportConfigUserEntityInstance()
        {
            return new ReportConfigUserEntity { ReportConfigUserId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public TaskListEntity GetTaskListEntityInstance()
        {
            return new TaskListEntity { WorkflowSerialNo = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public AssessmentDamageEntity GetAssessmentDamageEntityInstance()
        {
            return new AssessmentDamageEntity { ADId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public CAReportEntity GetCAReportEntityInstance()
        {
            return new CAReportEntity { CAReportId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public NumberOfJudgeAssignDetailEntity GetNumberOfJudgeAssignDetailEntityInstance()
        {
            return new NumberOfJudgeAssignDetailEntity { NumberOfJudgeAssignDetailId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public NumberOfJudgeAssignDetailHistoryEntity GetNumberOfJudgeAssignDetailHistoryEntityInstance()
        {
            return new NumberOfJudgeAssignDetailHistoryEntity { NumberOfJudgeAssignDetailHistoryId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public ReportConfigTaskInfoEntity GetReportConfigTaskInfoEntityInstance()
        {
            return new ReportConfigTaskInfoEntity { ReportConfigTaskInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public ArchiveBEWorkitemRecipientEntity GetArchiveBEWorkitemRecipientEntityInstance()
        {
            return new ArchiveBEWorkitemRecipientEntity { ArchiveBEWorkitemRecipientId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public ArchiveWorkitemDetailsEntity GetArchiveWorkitemDetailsEntityInstance()
        {
            return new ArchiveWorkitemDetailsEntity { ArchiveWorkitemDetailId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public CaseStatusRuleInfoEntity GetCaseStatusRuleInfoEntityInstance()
        {
            return new CaseStatusRuleInfoEntity { CaseStatusRuleInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public WorkflowOutgoingQueueEntity GetWorkflowOutgoingQueueEntityInstance()
        {
            return new WorkflowOutgoingQueueEntity { WorkflowOutgoingQueueId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        #endregion Methods
    }
}