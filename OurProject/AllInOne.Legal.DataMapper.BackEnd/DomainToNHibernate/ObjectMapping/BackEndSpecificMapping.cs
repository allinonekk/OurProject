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

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
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
        /// Method which maps the <see cref="RUserPAEntity"/> to <see cref="RUserPA"/>.
        /// </summary>
        internal void MapRUserPAEntityToRUserPA()
        {
            try
            {
                Mapper.CreateMap<RUserPAEntity, RUserPA>()
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRUserPAEntityToRUserPA", ex);
                throw;
            }
        }


        /* End of Criminal Finance Mapping */
        /// <summary>
        /// Method which maps the <see cref="BankruptcyDRSInfoEntity"/> to <see cref="BankruptcyDRSInfo"/>.
        /// </summary>
        internal void MapBankruptcyDRSInfoEntityToBankruptcyDRSInfo()
        {
            try
            {
                Mapper.CreateMap<BankruptcyDRSInfoEntity, BankruptcyDRSInfo>()
                    .ForMember(desc => desc.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapBankruptcyDRSInfoEntityToBankruptcyDRSInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the RPTNOC group NOC entity to RPTNOC group NOC.
        /// </summary>
        internal void MapRPTNOCGroupNOCEntityToRPTNOCGroupNOC()
        {
            try
            {
                Mapper.CreateMap<RPTNOCGroupNOCEntity, RPTNOCGroupNOC>();
                    

            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the RPT disposal KPI config entity to RPT disposal KPI config.
        /// </summary>
        internal void MapRPTDisposalKPIConfigEntityToRPTDisposalKPIConfig()
        {
            try
            {
                Mapper.CreateMap<RPTDisposalKPIConfigEntity, RPTDisposalKPIConfig>();
                    
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the RPTNOC group entity to RPTNOC group.
        /// </summary>
        internal void MapRPTNOCGroupEntityToRPTNOCGroup()
        {
            try
            {
                Mapper.CreateMap<RPTNOCGroupEntity, RPTNOCGroup>();

            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }
        }

        internal void MapBizMonitoringInfoEntityToBizMonitoringInfo()
        {
            try
            {
                Mapper.CreateMap<BizMonitoringInfoEntity, BizMonitoringInfo>()
                    .ForMember(dest => dest.Status, opts => opts.ResolveUsing<BizMonStatusToStringResolver>().FromMember(src => src.Status));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBizMonitoringInfoToBizMonitoringInfoEntity", ex);
                throw;
            }
        }

        internal void MapContinuingLegalEducationInfoEntityToContinuingLegalEducationInfo()
        {
            try
            {
                Mapper.CreateMap<ContinuingLegalEducationInfoEntity, ContinuingLegalEducationInfo>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapContinuingLegalEducationInfoEntityToContinuingLegalEducationInfo", ex);
                throw;
            }
        }

        /* Criminal Finance Mapping */
        /// <summary>
        /// Method which maps the <see cref="CriminalClaimHonorariumInfoEntity"/> to <see cref="CriminalClaimHonorariumInfo"/>.
        /// </summary>
        internal void MapCriminalClaimHonorariumInfoEntityToCriminalClaimHonorariumInfo()
        {
            try
            {
                Mapper.CreateMap<CriminalClaimHonorariumInfoEntity, CriminalClaimHonorariumInfo>()
                    .ForMember(desc => desc.Solicitor, opts => opts.MapFrom(src => src.SolicitorEntity))
                    //.ForMember(desc => desc.CriminalClaimInfo, opts => opts.MapFrom(src => src.CriminalClaimInfoEntity))
                    .ForMember(desc => desc.CriminalClaimHearingTypeCode, opts => opts.ResolveUsing<CrimeClaimHearingTypeToStringResolver>().FromMember(src => src.CriminalClaimHearingTypeCode));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalClaimHonorariumInfoEntityToCriminalClaimHonorariumInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CriminalClaimInfoEntity"/> to <see cref="CriminalClaimInfo"/>.
        /// </summary>
        internal void MapCriminalClaimInfoEntityToCriminalClaimInfo()
        {
            try
            {
                Mapper.CreateMap<CriminalClaimInfoEntity, CriminalClaimInfo>()
                    .ForMember(desc => desc.ClaimStatus, opts => opts.ResolveUsing<CriminalClaimStatusToStringResolver>().FromMember(src => src.ClaimStatus));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalClaimInfoEntityToCriminalClaimInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CriminalClaimInterpreterFeeInfoEntity"/> to <see cref="CriminalClaimInterpreterFeeInfo"/>.
        /// </summary>
        internal void MapCriminalClaimInterpreterFeeInfoEntityToCriminalClaimInterpreterFeeInfo()
        {
            try
            {
                Mapper.CreateMap<CriminalClaimInterpreterFeeInfoEntity, CriminalClaimInterpreterFeeInfo>();
                //.ForMember(desc => desc.CriminalClaimInfo, opts => opts.MapFrom(src => src.CriminalClaimInfoEntity));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalClaimInterpreterFeeInfoEntityToCriminalClaimInterpreterFeeInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CriminalClaimMiscellaneousInfoEntity"/> to <see cref="CriminalClaimMiscellaneousInfo"/>.
        /// </summary>
        internal void MapCriminalClaimMiscellaneousInfoEntityToCriminalClaimMiscellaneousInfo()
        {
            try
            {
                Mapper.CreateMap<CriminalClaimMiscellaneousInfoEntity, CriminalClaimMiscellaneousInfo>();
                //.ForMember(desc => desc.CriminalClaimInfo, opts => opts.MapFrom(src => src.CriminalClaimInfoEntity));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalClaimMiscellaneousInfoEntityToCriminalClaimMiscellaneousInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CriminalClaimProfessionalFeeInfoEntity"/> to <see cref="CriminalClaimProfessionalFeeInfo"/>.
        /// </summary>
        internal void MapCriminalClaimProfessionalFeeInfoEntityToCriminalClaimProfessionalFeeInfo()
        {
            try
            {
                Mapper.CreateMap<CriminalClaimProfessionalFeeInfoEntity, CriminalClaimProfessionalFeeInfo>();
                //.ForMember(desc => desc.CriminalClaimInfo, opts => opts.MapFrom(src => src.CriminalClaimInfoEntity));
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalClaimProfessionalFeeInfoEntityToCriminalClaimProfessionalFeeInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="CriminalClaimWitnessInfoEntity"/> to <see cref="CriminalClaimWitnessInfo"/>.
        /// </summary>
        internal void MapCriminalClaimWitnessInfoEntityToCriminalClaimWitnessInfo()
        {
            try
            {
                Mapper.CreateMap<CriminalClaimWitnessInfoEntity, CriminalClaimWitnessInfo>()
                    //.ForMember(desc => desc.CriminalClaimInfo, opts => opts.MapFrom(src => src.CriminalClaimInfoEntity))
                    .ForMember(desc => desc.WitnessType, opts => opts.ResolveUsing<WitnessTypeToStringResolver>().FromMember(src => src.WitnessType));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapCriminalClaimWitnessInfoEntityToCriminalClaimWitnessInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="DCADetailEntity"/> to <see cref="DCADetail"/>.
        /// </summary>
        internal void MapDCADetailEntityToDCADetail()
        {
            try
            {
                Mapper.CreateMap<DCADetailEntity, DCADetail>()
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapDCADetailEntityToDCADetail", ex);
                throw;
            }
        }

        internal void MapDisciplinaryActionInfoEntityToDisciplinaryActionInfo()
        {
            try
            {
                Mapper.CreateMap<DisciplinaryActionInfoEntity, DisciplinaryActionInfo>();

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDisciplinaryActionInfoEntityToDisciplinaryActionInfo", ex);
                throw;
            }
        }

        internal void MapIndexDocDetailEntityToIndexDocDetail()
        {
            try
            {
                Mapper.CreateMap<IndexDocDetailEntity, IndexDocDetail>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.IndexDocInfoId, opts => opts.MapFrom(src => src.IndexDocInfoId))
                    .ForMember(dest => dest.IndexDocDetailId, opts => opts.MapFrom(src => src.IndexDocDetailId))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapIndexDocInfoEntityToIndexDocInfo", ex);
                throw;
            }
        }

        internal void MapIndexDocInfoEntityToIndexDocInfo()
        {
            try
            {
                Mapper.CreateMap<IndexDocInfoEntity, IndexDocInfo>()
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.IndexDocInfoId, opts => opts.MapFrom(src => src.IndexDocInfoId))
                    .ForMember(dest=>dest.DocGroupID ,opts=>opts.MapFrom(src=>src.DocGroupID))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapIndexDocInfoEntityToIndexDocInfo", ex);
                throw;
            }
        }

        internal void MapInterfaceCriminalEntityToInterfaceCriminal()
        {
            try
            {
                Mapper.CreateMap<InterfaceCriminalEntity, InterfaceCriminal>()
                    .ForMember(dest => dest.StatusInd, opts => opts.ResolveUsing<InterfaceCriminalStatusToStringResolver>().FromMember(src => src.StatusInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapInterfaceCriminalEntityToInterfaceCriminal", ex);
                throw;
            }
        }

        internal void MapOGCIncomingQueueEntityToOGCIncomingQueue()
        {
            try
            {
                Mapper.CreateMap<OGCIncomingQueueEntity, OGCIncomingQueue>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId))
                    .ForMember(dest => dest.isAutoSend, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.isAutoSend))
                    .ForMember(dest => dest.QueueStatus, opts => opts.ResolveUsing<OGCQueueStatusToStringResolver>().FromMember(src => src.QueueStatus))
                    .ForMember(dest => dest.ProcessType, opts => opts.ResolveUsing<OGCProcessTypeToStringResolver>().FromMember(src => src.ProcessType));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOGCIncomingQueueEntityToOGCIncomingQueue", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RARASDetailEntity"/> to <see cref="RARASDetail"/>.
        /// </summary>
        internal void MapRARASDetailEntityToRARASDetail()
        {
            try
            {
                Mapper.CreateMap<RARASDetailEntity, RARASDetail>()
                    .ForMember(desc => desc.SendAutoNotification, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.SendAutoNotification))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error at MapRARASDetailEntityToRARASDetail", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ReportConfigInfoEntity"/> to <see cref="ReportConfigInfo"/>.
        /// </summary>
        internal void MapReportConfigInfoEntityToReportConfigInfo()
        {
            try
            {
                Mapper.CreateMap<ReportConfigInfoEntity, ReportConfigInfo>()
                    .ForMember(dest => dest.BusinessRule, opts => opts.MapFrom(src => src.BusinessRule))
                    .ForMember(dest => dest.DayInTheMonth, opts => opts.MapFrom(src => src.DayInTheMonth))
                    .ForMember(dest => dest.DayInTheWeek, opts => opts.ResolveUsing<DayInTheWeekToStringResolver>().FromMember(src => src.DayInTheWeek))
                    .ForMember(dest => dest.IsNoEndDate, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsNoEndDate))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.ReportConfigInfoId, opts => opts.MapFrom(src => src.ReportConfigInfoId))
                    .ForMember(dest => dest.ReportDescription, opts => opts.MapFrom(src => src.ReportDescription))
                    .ForMember(dest => dest.ReportTitle, opts => opts.MapFrom(src => src.ReportTitle))
                    .ForMember(dest => dest.ReportType, opts => opts.ResolveUsing<OnlineEnquiryReportTypeToStringResolver>().FromMember(src => src.ReportType))
                    .ForMember(dest => dest.SchedularEndDate, opts => opts.MapFrom(src => src.SchedularEndDate))
                    .ForMember(dest => dest.SchedulerInfo, opts => opts.ResolveUsing<OnlineEnquirySchedulerInfoToStringResolver>().FromMember(src => src.SchedulerInfo))
                    .ForMember(dest => dest.SchedulerStartDate, opts => opts.MapFrom(src => src.SchedulerStartDate))
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.URL, opts => opts.MapFrom(src => src.URL));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapReportConfigInfoEntityToReportConfigInfo", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="ReportConfigUserEntity"/> to <see cref="ReportConfigUser"/>.
        /// </summary>
        internal void MapReportConfigUserEntityToReportConfigUser()
        {
            try
            {
                Mapper.CreateMap<ReportConfigUserEntity, ReportConfigUser>()
                    .ForMember(dest => dest.UserId, opts => opts.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.ReportConfigInfoId, opts => opts.MapFrom(src => src.ReportConfigInfoId))
                    .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.ReportConfigUserId, opts => opts.MapFrom(src => src.ReportConfigUserId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapReportConfigInfoEntityToReportConfigInfo", ex);
                throw;
            }
        }

        internal void MapTaskListEntityToTaskList()
        {
            try
            {
                Mapper.CreateMap<TaskListEntity, TaskList>()
                    .ForMember(dest => dest.CheckListInstanceID, opts => opts.MapFrom(src => src.CheckListInstanceId))
                    .ForMember(dest => dest.ComDocID, opts => opts.MapFrom(src => src.ComDocId))
                    .ForMember(dest => dest.DocID, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.GroupID, opts => opts.MapFrom(src => src.GroupId))
                    .ForMember(dest => dest.HrgID, opts => opts.MapFrom(src => src.HRGID))
                    .ForMember(dest => dest.IsCrossCourt, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCrossCourt))
                    .ForMember(dest => dest.IsUrgentInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsUrgentInd))
                    .ForMember(dest => dest.MessageType, opts => opts.ResolveUsing<TasklistMessageTypeToStringResolver>().FromMember(src => src.MessageType))
                    .ForMember(dest => dest.PriorityInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PriorityInd))
                    .ForMember(dest => dest.ReminderID, opts => opts.MapFrom(src => src.ReminderId))
                    .ForMember(dest => dest.Status, opts => opts.ResolveUsing<TaskListStatusToStringResolver>().FromMember(src => src.Status))
                    .ForMember(dest => dest.TaskDisplayMainInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.TaskDisplayMainInd))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapTaskListEntityToTaskList", ex);
                throw;
            }
        }

        internal void MapWorkflowOnAcceptQueueEntityToWorkflowOnAcceptQueue()
        {
            try
            {
                Mapper.CreateMap<WorkflowOnAcceptQueueEntity, WorkflowOnAcceptQueue>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWorkflowOnAcceptQueueEntityToWorkflowOnAcceptQueue", ex);
                throw;
            }
        }

        internal void MapWorkflowPostAcceptQueueEntityToWorkflowPostAcceptQueue()
        {
            try
            {
                Mapper.CreateMap<WorkflowPostAcceptQueueEntity, WorkflowPostAcceptQueue>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWorkflowPostAcceptQueueEntityToWorkflowPostAcceptQueue", ex);
                throw;
            }
        }

        internal void MapWorkitemDetailsEntityToWorkitemDetails()
        {
            try
            {
                Mapper.CreateMap<BEWorkitemDetailsEntity, WorkitemDetails>()
                    .ForMember(dest => dest.WorkitemInd, opts => opts.ResolveUsing<WorkItemDetailsIndTypeToStringResolver>().FromMember(src => src.WorkitemInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWorkitemDetailsEntityToWorkitemDetails", ex);
                throw;
            }
        }

        internal void MapWorkitemRecipientEntityToWorkitemRecipient()
        {
            try
            {
                Mapper.CreateMap<BEWorkitemRecipientEntity, WorkitemRecipient>()
                    .ForMember(dest => dest.Status, opts => opts.ResolveUsing<WorkItemRecipientStatusToStringResolver>().FromMember(src => src.Status));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWorkitemRecipientEntityToWorkitemRecipient", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="RMUserPSEntity"/> to <see cref="RMUserPS"/>.
        /// </summary>
        internal void MapRMUserPSEntityToRMUserPS()
        {
            try
            {
                Mapper.CreateMap<RMUserPSEntity, RMUserPS>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRMUserPSEntityToRMUserPS", ex);
                throw ex;
            }
        }

        internal void MapAssessmentDamageEntityToAssessmentDamage()
        {
            try
            {
                Mapper.CreateMap<AssessmentDamageEntity, AssessmentDamage>()
                    .ForMember(dest => dest.IsDependencyClaimed, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsDependencyClaimed));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAssessmentDamageEntityToAssessmentDamage", ex);
                throw;
            }
        }

        internal void MapNumberOfJudgeAssignDetailEntityToNumberOfJudgeAssignDetail()
        {
            try
            {
                Mapper.CreateMap<NumberOfJudgeAssignDetailEntity, NumberOfJudgeAssignDetail>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.AssignStatus, opts => opts.ResolveUsing<JudgeAssignStatusToStringResolver>().FromMember(src => src.AssignStatus))
                    .ForMember(dest => dest.IsJLC, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsJLC))
                    .ForMember(dest => dest.IsHeardby5Judge, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsHeardby5Judge))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAssessmentDamageEntityToAssessmentDamage", ex);
                throw;
            }
        }

        internal void MapNumberOfJudgeAssignDetailHistoryEntityToNumberOfJudgeAssignDetailHistory()
        {
            try
            {
                Mapper.CreateMap<NumberOfJudgeAssignDetailHistoryEntity, NumberOfJudgeAssignDetailHistory>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapNumberOfJudgeAssignDetailHistoryEntityToNumberOfJudgeAssignDetailHistory", ex);
                throw;
            }
        }

        /// <summary>
        /// Maps the report config task info entity to report config task info.
        /// </summary>
        internal void MapReportConfigTaskInfoEntityToReportConfigTaskInfo()
        {
            try
            {
                Mapper.CreateMap<ReportConfigTaskInfoEntity, ReportConfigTaskInfo>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapReportConfigTaskInfoEntityToReportConfigTaskInfo", ex);
                throw;
            }

        }

        internal void MapArchiveNumberOfJudgeAssignDetailEntityToArchiveNumberOfJudgeAssignDetail()
        {
            try
            {
                Mapper.CreateMap<ArchiveNumberOfJudgeAssignDetailEntity, ArchiveNumberOfJudgeAssignDetail>()
                    .ForMember(dest => dest.AssignStatus, opts => opts.ResolveUsing<JudgeAssignStatusToStringResolver>().FromMember(src => src.AssignStatus))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId));
                    
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapNumberOfJudgeAssignDetailEntityToNumberOfJudgeAssignDetail", ex);
                throw;
            }
        }

        internal void MapArchiveNumberOfJudgeAssignDetailHistoryEntityToArchiveNumberOfJudgeAssignDetailHistory()
        {
            try
            {
                Mapper.CreateMap<ArchiveNumberOfJudgeAssignDetailHistoryEntity, ArchiveNumberOfJudgeAssignDetailHistory>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapArchiveNumberOfJudgeAssignDetailHistoryEntityToArchiveNumberOfJudgeAssignDetailHistory", ex);
                throw;
            }
        }

        internal void MapArchiveWorkitemDetailsEntityToArchiveWorkitemDetails()
        {
            try
            {
                Mapper.CreateMap<ArchiveWorkitemDetailsEntity, ArchiveWorkitemDetails>()
                    .ForMember(dest => dest.WorkitemInd, opts => opts.ResolveUsing<WorkItemDetailsIndTypeToStringResolver>().FromMember(src => src.WorkitemInd));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapArchiveWorkitemDetailsEntityToArchiveWorkitemDetails", ex);
                throw;
            }
        }

        internal void MapArchiveWorkitemRecipientEntityToArchiveWorkitemRecipient()
        {
            try
            {
                Mapper.CreateMap<ArchiveBEWorkitemRecipientEntity, ArchiveWorkitemRecipient>()
                    .ForMember(dest => dest.Status, opts => opts.ResolveUsing<WorkItemRecipientStatusToStringResolver>().FromMember(src => src.Status));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapArchiveWorkitemRecipientEntityToArchiveWorkitemRecipient", ex);
                throw;
            }
        }

        internal void MapArchiveTaskListEntityToArchiveTaskList()
        {
            try
            {
                Mapper.CreateMap<ArchiveTaskListEntity, ArchiveTaskList>()
                    .ForMember(dest => dest.CheckListInstanceID, opts => opts.MapFrom(src => src.CheckListInstanceId))
                    .ForMember(dest => dest.ComDocID, opts => opts.MapFrom(src => src.ComDocId))
                    .ForMember(dest => dest.DocID, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.GroupID, opts => opts.MapFrom(src => src.GroupId))
                    .ForMember(dest => dest.HrgID, opts => opts.MapFrom(src => src.HRGID))
                    .ForMember(dest => dest.IsCrossCourt, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsCrossCourt))
                    .ForMember(dest => dest.IsUrgentInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.IsUrgentInd))
                    .ForMember(dest => dest.MessageType, opts => opts.ResolveUsing<TasklistMessageTypeToStringResolver>().FromMember(src => src.MessageType))
                    .ForMember(dest => dest.PriorityInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.PriorityInd))
                    .ForMember(dest => dest.ReminderID, opts => opts.MapFrom(src => src.ReminderId))
                    .ForMember(dest => dest.Status, opts => opts.ResolveUsing<TaskListStatusToStringResolver>().FromMember(src => src.Status))
                    .ForMember(dest => dest.TaskDisplayMainInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.TaskDisplayMainInd))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapArchiveTaskListEntityToArchiveTaskList", ex);
                throw;
            }
        }

        internal void MapCaseStatusRuleInfoEntityToCaseStatusRuleInfo()
        {
            try
            {
                Mapper.CreateMap<CaseStatusRuleInfoEntity, CaseStatusRuleInfo>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCaseStatusRuleInfoEntityToCaseStatusRuleInfo", ex);
                throw;
            }
        }

        internal void MapOGCProcessingInfoEntityToOGCProcessingInfo()
        {
            try
            {
                Mapper.CreateMap<OGCProcessingInfoEntity, OGCProcessingInfo>()
                    .ForMember(dest => dest.CaseInfoID, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.HrgID, opts => opts.MapFrom(src => src.HrgId))
                    .ForMember(dest => dest.ProcessingStatus, opts => opts.ResolveUsing<OGCQueueStatusToStringResolver>().FromMember(src => src.ProcessingStatus))
                    .ForMember(dest => dest.SubCaseInfoID, opts => opts.MapFrom(src=>src.SubCaseInfoId))
                    .ForMember(dest => dest.SubmissionGroupID, opts => opts.MapFrom(src => src.SubmissionGroupId));
                    
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOGCProcessingInfoEntityToOGCProcessingInfo", ex);
                throw;
            }
        }

        internal void MapWorkFlowOutgoingQueueEntityToWorkFlowOutgoingQueue()
        {
            try
            {
                Mapper.CreateMap<WorkflowOutgoingQueueEntity, WorkflowOutgoingQueue>()
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                    .ForMember(dest => dest.QueueStatus, opts => opts.ResolveUsing<FilingbrokerQueueStatusToStringResolver>().FromMember(src=>src.QueueStatus))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.MapFrom(src => src.SubCaseInfoId))
                    .ForMember(dest => dest.SubmissionGroupId, opts => opts.MapFrom(src => src.SubmissionGroupId))
                    .ForMember(dest => dest.AttemptCount, opts => opts.MapFrom(src => src.AttemptCount))
                    .ForMember(dest => dest.CaseTypeGroupCode, opts => opts.MapFrom(src => src.CaseTypeGroupCode))
                    .ForMember(dest => dest.FilingMode, opts => opts.MapFrom(src => src.FilingMode))
                    .ForMember(dest => dest.FilingType, opts => opts.MapFrom(src => src.FilingType))
                    .ForMember(dest => dest.SubCaseType, opts => opts.MapFrom(src => src.SubCaseType))
                    .ForMember(dest => dest.SubFilingType, opts => opts.MapFrom(src => src.SubFilingType));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapWorkFlowOutgoingQueueEntityToWorkFlowOutgoingQueue", ex);
                throw;
            }
        }

        internal void MapDutyJudgeAssignmentEntityToDutyJudgeAssignment()
        {
            try
            {
                Mapper.CreateMap<DutyJudgeAssignmentEntity, DutyJudgeAssignment>()
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
                    
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDutyJudgeAssignmentEntityToDutyJudgeAssignment", ex);
                throw;
            }
        }

        internal void MapUndoSerialNumberEntityToUndoSerialNumber()
        {
            try
            {
                Mapper.CreateMap<UndoSerialNumberEntity, UndoSerialNumber>();
                    
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapUndoSerialNumberEntityToUndoSerialNumber", ex);
                throw;
            }
        }

        internal void MapJudicialUserEntityToJudicialUser()
        {
            try
            {
                Mapper.CreateMap<JudicialUserEntity, JudicialUser>()
                    .ForMember(dest => dest.AssignedDate, opts => opts.MapFrom(src => src.AssignedDate))
                    .ForMember(dest => dest.CaseFileInspectionInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src=>src.CaseFileInspectionInd))
                    .ForMember(dest => dest.DisplayName, opts => opts.MapFrom(src => src.DisplayName))
                    .ForMember(dest => dest.EMailAddress, opts => opts.MapFrom(src => src.EMailAddress))
                    .ForMember(dest => dest.EndDate, opts => opts.MapFrom(src => src.EndDate))
                    .ForMember(dest => dest.Initials, opts => opts.MapFrom(src => src.Initials))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.LawnetIndicator, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src=>src.LawnetIndicator))
                    .ForMember(dest => dest.LocalDownloadLocation, opts => opts.MapFrom(src => src.LocalDownloadLocation))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.SeniorityLevel, opts => opts.MapFrom(src => src.SeniorityLevel))
                    .ForMember(dest => dest.StartDate, opts => opts.MapFrom(src => src.StartDate))
                    .ForMember(dest => dest.UserId, opts => opts.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.UserName, opts => opts.MapFrom(src => src.UserName));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapJudicialUserEntityToJudicialUser", ex);
                throw;
            }
        }

        #endregion Methods
    }
}