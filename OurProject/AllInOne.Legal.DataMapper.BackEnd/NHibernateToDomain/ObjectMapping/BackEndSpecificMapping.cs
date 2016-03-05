#region Header

/*****************************************************************************************************
* Description : This file represents the mapping of objects for BackEndSpecific entities. This class will map
* Object to Entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   23/12/2010   		      Nithin                	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AppealMapping.cs
// Description: This file represents the mapping of objects for BackEndSpecific entities. This class will map
// Object to Entity.
// </summary>
// <copyright file= "BackEndSpecific.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    internal class BackEndSpecificMapping
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(BackEndSpecificMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method which maps the <see cref="RUserPA"/> to <see cref="RUserPAEntity"/>.
        /// </summary>
        internal void MapRUserPATRUserPAEntity()
        {
            try
            {
                Mapper.CreateMap<RUserPA, RUserPAEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRUserPATRUserPAEntity", ex);
                throw;
            }
        }

        /* End of Criminal Finance Mapping */
        /// <summary>
        /// Method which maps the <see cref="BankruptcyDRSInfo"/> to <see cref="BankruptcyDRSInfoEntity"/>.
        /// </summary>
        internal void MapBankruptcyDRSInfoToBankruptcyDRSInfoEntity()
        {
            try
            {
                Mapper.CreateMap<BankruptcyDRSInfo, BankruptcyDRSInfoEntity>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapBankruptcyDRSInfoToBankruptcyDRSInfoEntity", ex);
                throw;
            }
        }

        internal void MapBizMonitoringInfoToBizMonitoringInfoEntity()
        {
            try
            {
                Mapper.CreateMap<BizMonitoringInfo, BizMonitoringInfoEntity>()
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBizMonitoringInfoToBizMonitoringInfoEntity", ex);
                throw;
            }
        }

        /* Criminal Finance Mapping */
        /// <summary>
        /// Method which maps the <see cref="CriminalClaimHonorariumInfo"/> to <see cref="CriminalClaimHonorariumInfoEntity"/>.
        /// </summary>
        internal void MapCriminalClaimHonorariumInfoToCriminalClaimHonorariumInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CriminalClaimHonorariumInfo, CriminalClaimHonorariumInfoEntity>()
                    .ForMember(desc => desc.SolicitorEntity, opts => opts.MapFrom(src => src.Solicitor));
                //.ForMember(desc => desc.CriminalClaimInfoEntity, opts => opts.MapFrom(src => src.CriminalClaimInfo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalClaimHonorariumInfoToCriminalClaimHonorariumInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CriminalClaimInfo"/> to <see cref="CriminalClaimInfoEntity"/>.
        /// </summary>
        internal void MapCriminalClaimInfoToCriminalClaimInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CriminalClaimInfo, CriminalClaimInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalClaimInfoToCriminalClaimInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CriminalClaimInterpreterFeeInfo"/> to <see cref="CriminalClaimInterpreterFeeInfoEntity"/>.
        /// </summary>
        internal void MapCriminalClaimInterpreterFeeInfoToCriminalClaimInterpreterFeeInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CriminalClaimInterpreterFeeInfo, CriminalClaimInterpreterFeeInfoEntity>();
                //.ForMember(desc => desc.CriminalClaimInfoEntity, opts => opts.MapFrom(src => src.CriminalClaimInfo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalClaimInterpreterFeeInfoToCriminalClaimInterpreterFeeInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CriminalClaimMiscellaneousInfo"/> to <see cref="CriminalClaimMiscellaneousInfoEntity"/>.
        /// </summary>
        internal void MapCriminalClaimMiscellaneousInfoToCriminalClaimMiscellaneousInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CriminalClaimMiscellaneousInfo, CriminalClaimMiscellaneousInfoEntity>();
                //.ForMember(desc => desc.CriminalClaimInfoEntity, opts => opts.MapFrom(src => src.CriminalClaimInfo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalClaimMiscellaneousInfoToCriminalClaimMiscellaneousInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CriminalClaimProfessionalFeeInfo"/> to <see cref="CriminalClaimProfessionalFeeInfoEntity"/>.
        /// </summary>
        internal void MapCriminalClaimProfessionalFeeInfoToCriminalClaimProfessionalFeeInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CriminalClaimProfessionalFeeInfo, CriminalClaimProfessionalFeeInfoEntity>();
                //.ForMember(desc => desc.CriminalClaimInfoEntity, opts => opts.MapFrom(src => src.CriminalClaimInfo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalClaimProfessionalFeeInfoToCriminalClaimProfessionalFeeInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CriminalClaimWitnessInfo"/> to <see cref="CriminalClaimWitnessInfoEntity"/>.
        /// </summary>
        internal void MapCriminalClaimWitnessInfoToCriminalClaimWitnessInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CriminalClaimWitnessInfo, CriminalClaimWitnessInfoEntity>();
                //.ForMember(desc => desc.CriminalClaimInfoEntity, opts => opts.MapFrom(src => src.CriminalClaimInfo));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalClaimWitnessInfoToCriminalClaimWitnessInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DCADetail"/> to <see cref="DCADetailEntity"/>.
        /// </summary>
        internal void MapDCADetailToDCADetailEntity()
        {
            try
            {
                Mapper.CreateMap<DCADetail, DCADetailEntity>()
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDCADetailToDCADetailEntity", ex);
                throw;
            }
        }

        internal void MapIndexDocDetailToIndexDocDetailEntity()
        {
            try
            {
                Mapper.CreateMap<IndexDocDetail, IndexDocDetailEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.IndexDocInfoId, opts => opts.MapFrom(src => src.IndexDocInfoId))
                    .ForMember(dest => dest.IndexDocDetailId, opts => opts.MapFrom(src => src.IndexDocDetailId))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapIndexDocDetailToIndexDocDetailEntity", ex);
                throw;
            }
        }

        internal void MapIndexDocInfoToIndexDocInfoEntity()
        {
            try
            {
                Mapper.CreateMap<IndexDocInfo, IndexDocInfoEntity>()
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest=>dest.DocGroupID,opts=>opts.MapFrom(src=>src.DocGroupID))
                    .ForMember(dest => dest.IndexDocInfoId, opts => opts.MapFrom(src => src.IndexDocInfoId))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapIndexDocInfoToIndexDocInfoEntity", ex);
                throw;
            }
        }

        internal void MapInterfaceCriminalToInterfaceCriminalEntity()
        {
            try
            {
                Mapper.CreateMap<InterfaceCriminal, InterfaceCriminalEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapInterfaceCriminalToInterfaceCriminalEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="InterfaceICA"/> to <see cref="InterfaceICAEntity"/>.
        /// </summary>
        internal void MapInterfaceICAToInterfaceICAEntity()
        {
            Mapper.CreateMap<InterfaceICA, InterfaceICAEntity>()
                .ForMember(desc => desc.CaseNo, opts => opts.MapFrom(src => src.CaseNo))
                .ForMember(desc => desc.DateOfOrder, opts => opts.MapFrom(src => src.DateOfOrder))
                .ForMember(desc => desc.DocId, opts => opts.MapFrom(src => src.DocId))
                .ForMember(desc => desc.ICAInterfaceId, opts => opts.MapFrom(src => src.ICAInterfaceId))
                .ForMember(desc => desc.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(desc => desc.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(desc => desc.NoOfTry, opts => opts.MapFrom(src => src.NoOfTry))
                .ForMember(desc => desc.OrderNo, opts => opts.MapFrom(src => src.OrderNo))
                .ForMember(desc => desc.Status, opts => opts.MapFrom(src => src.Status));
        }

        /// <summary>
        /// Method which maps the <see cref="JudicialUser"/> to <see cref="JudicialUserEntity"/>.
        /// </summary>
        internal void MapJudicialUserToJudicialUserEntity()
        {
            try
            {
                Mapper.CreateMap<JudicialUser, JudicialUserEntity>()
                    .ForMember(dest => dest.AssignedDate, opts => opts.MapFrom(src => src.AssignedDate))
                    .ForMember(dest => dest.CaseFileInspectionInd, opts => opts.MapFrom(src => src.CaseFileInspectionInd))
                    .ForMember(dest => dest.DisplayName, opts => opts.MapFrom(src => src.DisplayName))
                    .ForMember(dest => dest.EMailAddress, opts => opts.MapFrom(src => src.EMailAddress))
                    .ForMember(dest => dest.EndDate, opts => opts.MapFrom(src => src.EndDate))
                    .ForMember(dest => dest.Initials, opts => opts.MapFrom(src => src.Initials))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.LawnetIndicator, opts => opts.MapFrom(src => src.LawnetIndicator))
                    .ForMember(dest => dest.LocalDownloadLocation, opts => opts.MapFrom(src => src.LocalDownloadLocation))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.SeniorityLevel, opts => opts.MapFrom(src => src.SeniorityLevel))
                    .ForMember(dest => dest.StartDate, opts => opts.MapFrom(src => src.StartDate))
                    .ForMember(dest => dest.UserId, opts => opts.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.UserName, opts => opts.MapFrom(src => src.UserName));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapJudicialUserToJudicialUserEntity", ex);
                throw;
            }
        }

        internal void MapOGCIncomingQueueToOGCIncomingQueueEntity()
        {
            try
            {
                Mapper.CreateMap<OGCIncomingQueue, OGCIncomingQueueEntity>()
                     .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                     .ForMember(dest => dest.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                     .ForMember(dest => dest.QueueStatus, opts => opts.MapFrom(src => src.QueueStatus))
                     .ForMember(dest => dest.isAutoSend, opts => opts.MapFrom(src => src.isAutoSend))
                     .ForMember(dest => dest.ProcessType, opts => opts.MapFrom(src => src.ProcessType));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWorkflowPostAcceptQueueEntityToWorkflowPostAcceptQueue", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RARASDetail"/> to <see cref="RARASDetailEntity"/>.
        /// </summary>
        internal void MapRARASDetailToRARASDetailEntity()
        {
            try
            {
                Mapper.CreateMap<RARASDetail, RARASDetailEntity>()
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRARASDetailToRARASDetailEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ReportConfigInfo"/> to <see cref="ReportConfigInfoEntity"/>.
        /// </summary>
        internal void MapReportConfigInfoToReportConfigInfoEntity()
        {
            try
            {
                Mapper.CreateMap<ReportConfigInfo, ReportConfigInfoEntity>()
                    .ForMember(dest => dest.BusinessRule, opts => opts.MapFrom(src => src.BusinessRule))
                    .ForMember(dest => dest.DayInTheMonth, opts => opts.MapFrom(src => src.DayInTheMonth))
                    .ForMember(dest => dest.DayInTheWeek, opts => opts.MapFrom(src => src.DayInTheWeek))
                    .ForMember(dest => dest.IsNoEndDate, opts => opts.MapFrom(src => src.IsNoEndDate))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.ReportConfigInfoId, opts => opts.MapFrom(src => src.ReportConfigInfoId))
                    .ForMember(dest => dest.ReportDescription, opts => opts.MapFrom(src => src.ReportDescription))
                    .ForMember(dest => dest.ReportTitle, opts => opts.MapFrom(src => src.ReportTitle))
                    .ForMember(dest => dest.ReportType, opts => opts.MapFrom(src => src.ReportType))
                    .ForMember(dest => dest.SchedularEndDate, opts => opts.MapFrom(src => src.SchedularEndDate))
                    .ForMember(dest => dest.SchedulerInfo, opts => opts.MapFrom(src => src.SchedulerInfo))
                    .ForMember(dest => dest.SchedulerStartDate, opts => opts.MapFrom(src => src.SchedulerStartDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.URL, opts => opts.MapFrom(src => src.URL));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapReportConfigInfoEntityToReportConfigInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ReportConfigUser"/> to <see cref="ReportConfigUserEntity"/>.
        /// </summary>
        internal void MapReportConfigUserToReportConfigUserEntity()
        {
            try
            {
                Mapper.CreateMap<ReportConfigUser, ReportConfigUserEntity>()
                    .ForMember(dest => dest.UserId, opts => opts.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.ReportConfigInfoId, opts => opts.MapFrom(src => src.ReportConfigInfoId))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.ReportConfigUserId, opts => opts.MapFrom(src => src.ReportConfigUserId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapReportConfigInfoToReportConfigInfoEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RMCDRAutoFixTimeLine"/> to <see cref="RMCDRAutoFixTimeLineEntity"/>.
        /// </summary>
        internal void MapRMCDRAutoFixTimeLineToRMCDRAutoFixTimeLineEntity()
        {
            try
            {
                Mapper.CreateMap<RMCDRAutoFixTimeLine, RMCDRAutoFixTimeLineEntity>()
                    .ForMember(dest => dest.CaseTypeCode, opts => opts.MapFrom(src => src.CaseTypeCode))
                    .ForMember(dest => dest.DocCode, opts => opts.MapFrom(src => src.DocCode))
                    .ForMember(dest => dest.NOCCode, opts => opts.MapFrom(src => src.NOCCode))
                    .ForMember(dest => dest.QuantumType, opts => opts.MapFrom(src => src.QuantumType))
                    .ForMember(dest => dest.QuantumValue, opts => opts.MapFrom(src => src.QuantumValue))
                    .ForMember(dest => dest.TimeLineDays, opts => opts.MapFrom(src => src.TimeLineDays))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRMCDRAutoFixTimeLineToRMCDRAutoFixTimeLineEntity", ex);
                throw;
            }
        }

        internal void MapTaskListToTaskListEntity()
        {
            try
            {
                Mapper.CreateMap<TaskList, TaskListEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapTaskListToTaskListEntity", ex);
                throw;
            }
        }

        internal void MapWorkflowOnAcceptQueueToWorkflowOnAcceptQueueEntity()
        {
            try
            {
                Mapper.CreateMap<WorkflowOnAcceptQueue, WorkflowOnAcceptQueueEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWorkflowOnAcceptQueueToWorkflowOnAcceptQueueEntity", ex);
                throw;
            }
        }

        internal void MapWorkflowPostAcceptQueueToWorkflowPostAcceptQueueEntity()
        {
            try
            {
                Mapper.CreateMap<WorkflowPostAcceptQueue, WorkflowPostAcceptQueueEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWorkflowPostAcceptQueueToWorkflowPostAcceptQueueEntity", ex);
                throw;
            }
        }

        internal void MapWorkitemDetailsToWorkitemDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<WorkitemDetails, BEWorkitemDetailsEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWorkitemDetailsToWorkitemDetailsEntity", ex);
                throw;
            }
        }

        internal void MapWorkitemRecipientToWorkitemRecipientEntity()
        {
            try
            {
                Mapper.CreateMap<WorkitemRecipient, BEWorkitemRecipientEntity>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWorkitemRecipientToWorkitemRecipientEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RMUserPS"/> to <see cref="RMUserPSEntity"/>.
        /// </summary>
        internal void MapRMUserPSToRMUserPSEntity()
        {
            try
            {
                Mapper.CreateMap<RMUserPS, RMUserPSEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRMUserPSToRMUserPSEntity", ex);
                throw ex;
            }
        }

        /// <summary>
        /// Maps the number of judge assign detail to number of judge assign detail entity.
        /// </summary>
        internal void MapNumberOfJudgeAssignDetailToNumberOfJudgeAssignDetailEntity()
        {
            try
            {
                Mapper.CreateMap<NumberOfJudgeAssignDetail, NumberOfJudgeAssignDetailEntity>()
                    .ForMember(dest => dest.AssignStatus, opts => opts.MapFrom(src => src.AssignStatus))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapNumberOfJudgeAssignDetailToNumberOfJudgeAssignDetailEntity", ex);
                throw;
            }
        }

        internal void MapNumberOfJudgeAssignDetailHistoryToNumberOfJudgeAssignDetailHistoryEntity()
        {
            try
            {
                Mapper.CreateMap<NumberOfJudgeAssignDetailHistory, NumberOfJudgeAssignDetailHistoryEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapNumberOfJudgeAssignDetailHistoryToNumberOfJudgeAssignDetailHistoryEntity", ex);
                throw;
            }
        }


        /// <summary>
        /// Maps the report config task info to report config task info entity.
        /// </summary>
        internal void MapReportConfigTaskInfoToReportConfigTaskInfoEntity()
        {
            try
            {
                Mapper.CreateMap<ReportConfigTaskInfo, ReportConfigTaskInfoEntity>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapReportConfigTaskInfoToReportConfigTaskInfoEntity", ex);
                throw;
            }

        }

        internal void MapCaseStatusRuleInfoToCaseStatusRuleInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CaseStatusRuleInfo, CaseStatusRuleInfoEntity>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseStatusRuleInfoToCaseStatusRuleInfoEntity", ex);
                throw;
            }
        }

        internal void MapWorkflowOutgoingQueueToWorkflowOutgoingQueueEntity()
        {
            try
            {
                Mapper.CreateMap<WorkflowOutgoingQueue, WorkflowOutgoingQueueEntity>()
                    .ForMember(dest => dest.AttemptCount, opts => opts.MapFrom(src => src.AttemptCount))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.MapFrom(src => src.CaseInfoId))
                    .ForMember(dest => dest.CaseTypeGroupCode, opts => opts.MapFrom(src => src.CaseTypeGroupCode))
                    .ForMember(dest => dest.CreatedBy, opts => opts.MapFrom(src => src.CreatedBy))
                    .ForMember(dest => dest.CreatedDate, opts => opts.MapFrom(src => src.CreatedDate))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.FilingMode, opts => opts.MapFrom(src => src.FilingMode))
                    .ForMember(dest => dest.FilingType, opts => opts.MapFrom(src => src.FilingType))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.QueueStatus, opts => opts.MapFrom(src => src.QueueStatus))
                    .ForMember(dest => dest.remarks, opts => opts.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(dest => dest.SubCaseType, opts => opts.MapFrom(src => src.SubCaseType))
                    .ForMember(dest => dest.SubFilingType, opts => opts.MapFrom(src => src.SubFilingType))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.WorkflowOutgoingQueueId, opts => opts.MapFrom(src => src.WorkflowOutgoingQueueId))
                    .ForMember(dest => dest.WorkflowSerialNo, opts => opts.MapFrom(src => src.WorkflowSerialNo));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWorkflowOutgoingQueueToWorkflowOutgoingQueueEntity", ex);
                throw;
            }
        }

        internal void MapDutyJudgeAssignmentToDutyJudgeAssignmentEntity()
        {
            try
            {
                Mapper.CreateMap<DutyJudgeAssignment, DutyJudgeAssignmentEntity>()
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd));
                    
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDutyJudgeAssignmentToDutyJudgeAssignmentEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the RPT disposal KPI config to RPT disposal KPI config entity.
        /// </summary>
        internal void MapRPTDisposalKPIConfigToRPTDisposalKPIConfigEntity()
        {
            try
            {
                Mapper.CreateMap<RPTDisposalKPIConfig, RPTDisposalKPIConfigEntity>()
                    .ForMember(dest => dest.RPTDisposalKPIConfigId, opts => opts.MapFrom(src => src.RPTDisposalKPIConfigId));

            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the RPTNOC group NOC to RPTNOC group NOC entity.
        /// </summary>
        internal void MapRPTNOCGroupNOCToRPTNOCGroupNOCEntity()
        {
            try
            {
                Mapper.CreateMap<RPTNOCGroupNOC, RPTNOCGroupNOCEntity>()
                    .ForMember(dest => dest.RPTNOCGroupNOCCode, opts => opts.MapFrom(src => src.RPTNOCGroupNOCCode));

            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the RPTNOC group entity.
        /// </summary>
        internal void MapRPTNOCGroupToRPTNOCGroupEntity()
        {
            try
            {
                Mapper.CreateMap<RPTNOCGroup, RPTNOCGroupEntity>()
                    .ForMember(dest => dest.RPTNOCGroupID, opts => opts.MapFrom(src => src.RPTNOCGroupID));
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }
        }

        #endregion Methods
    }
}