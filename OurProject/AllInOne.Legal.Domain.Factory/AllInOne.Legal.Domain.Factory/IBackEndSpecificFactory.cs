#region Header

/*****************************************************************************************************
 * Description : This file represents a standard interface for creating instances of objects related
 *              with BackEndSpecific.
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
// File: IBackEndSpecificFactory.cs
// Description: Represents a standard interface for creating instances of objects related with BackEndSpecific.
// </summary>
// <copyright file= "IBackEndSpecificFactory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory
{
    using AllInOne.Legal.Domain.BackEndSpecific;

    /// <summary>
    /// Represents a standard interface for creating instances of objects related with BackEndSpecific.
    /// </summary>
    public interface IBackEndSpecificFactory
    {
        #region Methods

        /// <summary>
        /// Gets the <see cref="BizMonitoringInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="BizMonitoringInfoEntity"/></returns>
        BizMonitoringInfoEntity GetBizMonitoringInfoEntityInstance();

        /// <summary>
        /// Gets the IncomingQueueEntity 
        /// </summary>
        /// <returns></returns>
        OGCIncomingQueueEntity GetOGCIncomingQueueEntityInstance();

        /// <summary>
        /// Gets the <see cref="ReportConfigInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="ReportConfigInfoEntity"/></returns>
        ReportConfigInfoEntity GetReportConfigInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="ReportConfigUserEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="ReportConfigUserEntity"/></returns>
        ReportConfigUserEntity GetReportConfigUserEntityInstance();

        /// <summary>
        /// Gets the <see cref="TaskListEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="TaskListEntity"/></returns>
        TaskListEntity GetTaskListEntityInstance();

        /// <summary>
        /// Gets the CA report entity instance.
        /// </summary>
        /// <returns></returns>
        CAReportEntity GetCAReportEntityInstance();

        NumberOfJudgeAssignDetailEntity GetNumberOfJudgeAssignDetailEntityInstance();

        NumberOfJudgeAssignDetailHistoryEntity GetNumberOfJudgeAssignDetailHistoryEntityInstance();

        ReportConfigTaskInfoEntity GetReportConfigTaskInfoEntityInstance();

        ArchiveBEWorkitemRecipientEntity GetArchiveBEWorkitemRecipientEntityInstance();

        ArchiveWorkitemDetailsEntity GetArchiveWorkitemDetailsEntityInstance();

        /// <summary>
        /// Gets the case status rule info entity instance.
        /// </summary>
        /// <returns></returns>
        CaseStatusRuleInfoEntity GetCaseStatusRuleInfoEntityInstance();

        WorkflowOutgoingQueueEntity GetWorkflowOutgoingQueueEntityInstance();
        #endregion Methods
    }
}