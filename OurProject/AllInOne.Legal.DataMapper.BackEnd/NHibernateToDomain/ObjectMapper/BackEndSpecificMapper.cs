#region Header

/*****************************************************************************************************
* Description : This file handles mapper for BackEndSpecific from NHibernate entities to Domain objects.
*
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   21/12/2010   		      Nithin                	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CommonMapper.cs
// Description: This file handles mapper for BackEndSpecific from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "BackEndSpecificMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;
    using AllInOne.Legal.Domain.SubCaseSpecific;

    /// <summary>
    /// Class handles mapping for BackEndSpecific from NHibernate entities to Domain objects.
    /// </summary>
    public class BackEndSpecificMapper
    {
        #region Fields

            /// <summary>
            /// ILog instance for logging.
            /// </summary>
            private static readonly ILog Logger = LogManager.GetLogger(typeof(BackEndSpecificMapper));

        #endregion Fields

        #region Methods

        public static IBackEndSpecificEntity GetBackEndSpecificEntity<T>(T backEndSpecific)
        {
            try
            {
                if (backEndSpecific.GetType().Equals(typeof(ReportConfigInfo)))
                    return GetReportConfigInfoEntity(backEndSpecific as ReportConfigInfo);

                else if (backEndSpecific.GetType().Equals(typeof(ReportConfigUser)))
                    return GetReportConfigUserEntity(backEndSpecific as ReportConfigUser);

                else if (backEndSpecific.GetType().Equals(typeof(IndexDocDetail)))
                    return GetIndexDocDetailEntity(backEndSpecific as IndexDocDetail);

                else if (backEndSpecific.GetType().Equals(typeof(IndexDocInfo)))
                    return GetIndexDocInfoEntity(backEndSpecific as IndexDocInfo);

                else if (backEndSpecific.GetType().Equals(typeof(CriminalClaimHonorariumInfo)))
                    return (GetCriminalClaimHonorariumInfoEntity(backEndSpecific as CriminalClaimHonorariumInfo));

                else if (backEndSpecific.GetType().Equals(typeof(CriminalClaimInfo)))
                    return (GetCriminalClaimInfoEntity(backEndSpecific as CriminalClaimInfo));

                else if (backEndSpecific.GetType().Equals(typeof(CriminalClaimInterpreterFeeInfo)))
                    return (GetCriminalClaimInterpreterFeeInfoEntity(backEndSpecific as CriminalClaimInterpreterFeeInfo));

                else if (backEndSpecific.GetType().Equals(typeof(CriminalClaimMiscellaneousInfo)))
                    return (GetCriminalClaimMiscellaneousInfoEntity(backEndSpecific as CriminalClaimMiscellaneousInfo));

                else if (backEndSpecific.GetType().Equals(typeof(CriminalClaimProfessionalFeeInfo)))
                    return (GetCriminalClaimProfessionalFeeInfoEntity(backEndSpecific as CriminalClaimProfessionalFeeInfo));

                else if (backEndSpecific.GetType().Equals(typeof(CriminalClaimWitnessInfo)))
                    return (GetCriminalClaimWitnessInfoEntity(backEndSpecific as CriminalClaimWitnessInfo));

                else if (backEndSpecific.GetType().Equals(typeof(JudicialUser)))
                    return GetJudicialUserEntity(backEndSpecific as JudicialUser);

                else if (backEndSpecific.GetType().Equals(typeof(WorkitemDetails)))
                    return (GetWorkitemDetailsEntity(backEndSpecific as WorkitemDetails));

                else if (backEndSpecific.GetType().Equals(typeof(WorkitemRecipient)))
                    return (GetWorkitemRecipientEntity(backEndSpecific as WorkitemRecipient));

                else if (backEndSpecific.GetType().Equals(typeof(InterfaceCriminal)))
                    return (GetInterfaceCriminalEntity(backEndSpecific as InterfaceCriminal));

                else if (backEndSpecific.GetType().Equals(typeof(TaskList)))
                    return (GetTaskListEntity(backEndSpecific as TaskList));

                else if (backEndSpecific.GetType().Equals(typeof(RUserPA)))
                    return (GetRUserPAEntity(backEndSpecific as RUserPA));

                else if (backEndSpecific.GetType().Equals(typeof(WorkflowOnAcceptQueue)))
                    return (GetWorkflowOnAcceptQueueEntity(backEndSpecific as WorkflowOnAcceptQueue));

                else if (backEndSpecific.GetType().Equals(typeof(WorkflowPostAcceptQueue)))
                    return (GetWorkflowPostAcceptQueueEntity(backEndSpecific as WorkflowPostAcceptQueue));

                else if (backEndSpecific.GetType().Equals(typeof(RMUserPS)))
                    return (GetRMUserPSEntity(backEndSpecific as RMUserPS));

                else if (backEndSpecific.GetType().Equals(typeof(NumberOfJudgeAssignDetail)))
                    return (GetNumberOfJudgeAssignDetailEntity(backEndSpecific as NumberOfJudgeAssignDetail));

                else if (backEndSpecific.GetType().Equals(typeof(ReportConfigTaskInfo)))
                    return (GetReportConfigTaskInfoEntity(backEndSpecific as ReportConfigTaskInfo));

                else if (backEndSpecific.GetType().Equals(typeof(CaseStatusRuleInfo)))
                    return (GetCaseStatusRuleInfoEntity(backEndSpecific as CaseStatusRuleInfo));

                else if (backEndSpecific.GetType().Equals(typeof(BizMonitoringInfo)))
                    return GetBizMonitoringInfoEntity(backEndSpecific as BizMonitoringInfo);

                else if (backEndSpecific.GetType().Equals(typeof(WorkflowOutgoingQueue)))
                    return GetWorkflowOutgoingQueueEntity(backEndSpecific as WorkflowOutgoingQueue);

                else if (backEndSpecific.GetType().Equals(typeof(DutyJudgeAssignment)))
                    return GetDutyJudgeAssignmentEntity(backEndSpecific as DutyJudgeAssignment);

                else if (backEndSpecific.GetType().Equals(typeof(RPTNOCGroupNOC)))
                    return GetRPTNOCGroupNOCEntity(backEndSpecific as RPTNOCGroupNOC);

                else if (backEndSpecific.GetType().Equals(typeof(RPTNOCGroup)))
                    return GetRPTNOCGroupEntity(backEndSpecific as RPTNOCGroup);

                else if (backEndSpecific.GetType().Equals(typeof(RPTDisposalKPIConfig)))
                    return GetRPTDisposalKPIConfigEntity(backEndSpecific as RPTDisposalKPIConfig);

                else
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetCommonEntity method in CommonMapper.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBackEndSpecificEntity", ex);
                return null;
            }
        }

        /// <summary>
        /// Get RUserPAEntity
        /// </summary>
        /// <param name="rUserPA">RUserPA</param>
        /// <returns>RUserPAEntity</returns>
        public static RUserPAEntity GetRUserPAEntity(RUserPA rUserPA)
        {
            RUserPAEntity rUserPAEntity = null;

            try
            {
                if (rUserPA != null)
                {
                    rUserPAEntity = Mapper.Map<RUserPA, RUserPAEntity>(rUserPA);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRUserPAEntity", ex);
                throw;
            }

            return rUserPAEntity;
        }

        /// <summary>
        /// Get BankruptcyDRSInfo
        /// </summary>
        /// <param name="bankruptcyDRSInfoEntity"></param>
        /// <returns></returns>
        public static BankruptcyDRSInfoEntity GetBankruptcyDRSInfoEntity(BankruptcyDRSInfo bankruptcyDRSInfo)
        {
            BankruptcyDRSInfoEntity bankruptcyDRSInfoEntity = null;

            try
            {
                if (bankruptcyDRSInfo != null)
                {
                    bankruptcyDRSInfoEntity = Mapper.Map<BankruptcyDRSInfo, BankruptcyDRSInfoEntity>(bankruptcyDRSInfo);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBankruptcyDRSInfoEntity", ex);
                throw;
            }

            return bankruptcyDRSInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="InterfaceCriminalEntity"/> from <see cref="InterfaceCriminal"/> input.
        /// </summary>
        /// <param name="InterfaceCriminal"><see cref="InterfaceCriminal"/></param>
        /// <returns>Returns <see cref="InterfaceCriminal"/>, else null.</returns>
        public static BizMonitoringInfoEntity GetBizMonitoringInfoEntity(BizMonitoringInfo bizMonitoringInfo)
        {
            BizMonitoringInfoEntity bizMonitoringInfoEntity = null;

            try
            {
                if (bizMonitoringInfo != null)
                {
                    bizMonitoringInfoEntity = Mapper.Map<BizMonitoringInfo, BizMonitoringInfoEntity>(bizMonitoringInfo);
                    bizMonitoringInfoEntity.MMonitoringType = Mapper.Map<MMonitoringType, MMonitoringTypeEntity>(bizMonitoringInfo.MMonitoringType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBizMonitoringInfoEntity", ex);
                throw;
            }

            return bizMonitoringInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimHonorariumInfoEntity"/> from <see cref="CriminalClaimHonorariumInfo"/> input.
        /// </summary>
        /// <param name="criminalClaimHonorariumInfo"><see cref="CriminalClaimHonorariumInfo"/></param>
        /// <returns>Returns <see cref="CriminalClaimHonorariumInfoEntity"/>, else null.</returns>
        public static CriminalClaimHonorariumInfoEntity GetCriminalClaimHonorariumInfoEntity(CriminalClaimHonorariumInfo criminalClaimHonorariumInfo)
        {
            CriminalClaimHonorariumInfoEntity criminalClaimHonorariumInfoEntity = null;

            try
            {
                if (criminalClaimHonorariumInfo != null)
                {
                    criminalClaimHonorariumInfoEntity = Mapper.Map<CriminalClaimHonorariumInfo, CriminalClaimHonorariumInfoEntity>(criminalClaimHonorariumInfo);
                    //criminalClaimHonorariumInfoEntity.CriminalClaimInfoEntity = Mapper.Map<CriminalClaimInfo, CriminalClaimInfoEntity>(criminalClaimHonorariumInfo.CriminalClaimInfo);
                    criminalClaimHonorariumInfoEntity.SolicitorEntity = Mapper.Map<Solicitor, SolicitorEntity>(criminalClaimHonorariumInfo.Solicitor);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalClaimHonorariumInfoEntity", ex);
                throw;
            }

            return criminalClaimHonorariumInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimInfoEntity"/> from <see cref="CriminalClaimInfo"/> input.
        /// </summary>
        /// <param name="criminalClaimInfo"><see cref="CriminalClaimInfo"/></param>
        /// <returns>Returns <see cref="CriminalClaimInfoEntity"/>, else null.</returns>
        public static CriminalClaimInfoEntity GetCriminalClaimInfoEntity(CriminalClaimInfo criminalClaimInfo)
        {
            CriminalClaimInfoEntity criminalClaimInfoEntity = null;

            try
            {
                if (criminalClaimInfo != null)
                {
                    criminalClaimInfoEntity = Mapper.Map<CriminalClaimInfo, CriminalClaimInfoEntity>(criminalClaimInfo);
                    criminalClaimInfoEntity.MCriminalClaimTypeEntity = Mapper.Map<MCriminalClaimType, MCriminalClaimTypeEntity>(criminalClaimInfo.MCriminalClaimType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalClaimInfoEntity", ex);
                throw;
            }

            return criminalClaimInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimInterpreterFeeInfoEntity"/> from <see cref="CriminalClaimInterpreterFeeInfo"/> input.
        /// </summary>
        /// <param name="criminalClaimInterpreterFeeInfo"><see cref="CriminalClaimInterpreterFeeInfo"/></param>
        /// <returns>Returns <see cref="CriminalClaimInterpreterFeeInfoEntity"/>, else null.</returns>
        public static CriminalClaimInterpreterFeeInfoEntity GetCriminalClaimInterpreterFeeInfoEntity(CriminalClaimInterpreterFeeInfo criminalClaimInterpreterFeeInfo)
        {
            CriminalClaimInterpreterFeeInfoEntity criminalClaimInterpreterFeeInfoEntity = null;

            try
            {
                if (criminalClaimInterpreterFeeInfo != null)
                {
                    criminalClaimInterpreterFeeInfoEntity = Mapper.Map<CriminalClaimInterpreterFeeInfo, CriminalClaimInterpreterFeeInfoEntity>(criminalClaimInterpreterFeeInfo);
                    //criminalClaimInterpreterFeeInfoEntity.CriminalClaimInfoEntity = Mapper.Map<CriminalClaimInfo, CriminalClaimInfoEntity>(criminalClaimInterpreterFeeInfo.CriminalClaimInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalClaimInterpreterFeeInfoEntity", ex);
                throw;
            }

            return criminalClaimInterpreterFeeInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimMiscellaneousInfoEntity"/> from <see cref="CriminalClaimMiscellaneousInfo"/> input.
        /// </summary>
        /// <param name="criminalClaimMiscellaneousInfo"><see cref="CriminalClaimMiscellaneousInfo"/></param>
        /// <returns>Returns <see cref="CriminalClaimMiscellaneousInfoEntity"/>, else null.</returns>
        public static CriminalClaimMiscellaneousInfoEntity GetCriminalClaimMiscellaneousInfoEntity(CriminalClaimMiscellaneousInfo criminalClaimMiscellaneousInfo)
        {
            CriminalClaimMiscellaneousInfoEntity criminalClaimMiscellaneousInfoEntity = null;

            try
            {
                if (criminalClaimMiscellaneousInfo != null)
                {
                    criminalClaimMiscellaneousInfoEntity = Mapper.Map<CriminalClaimMiscellaneousInfo, CriminalClaimMiscellaneousInfoEntity>(criminalClaimMiscellaneousInfo);
                    //criminalClaimMiscellaneousInfoEntity.CriminalClaimInfoEntity = Mapper.Map<CriminalClaimInfo, CriminalClaimInfoEntity>(criminalClaimMiscellaneousInfo.CriminalClaimInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalClaimMiscellaneousInfoEntity", ex);
                throw;
            }

            return criminalClaimMiscellaneousInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimProfessionalFeeInfoEntity"/> from <see cref="CriminalClaimProfessionalFeeInfo"/> input.
        /// </summary>
        /// <param name="criminalClaimProfessionalFeeInfo"><see cref="CriminalClaimProfessionalFeeInfo"/></param>
        /// <returns>Returns <see cref="CriminalClaimProfessionalFeeInfoEntity"/>, else null.</returns>
        public static CriminalClaimProfessionalFeeInfoEntity GetCriminalClaimProfessionalFeeInfoEntity(CriminalClaimProfessionalFeeInfo criminalClaimProfessionalFeeInfo)
        {
            CriminalClaimProfessionalFeeInfoEntity criminalClaimProfessionalFeeInfoEntity = null;

            try
            {
                if (criminalClaimProfessionalFeeInfo != null)
                {
                    criminalClaimProfessionalFeeInfoEntity = Mapper.Map<CriminalClaimProfessionalFeeInfo, CriminalClaimProfessionalFeeInfoEntity>(criminalClaimProfessionalFeeInfo);
                    //criminalClaimProfessionalFeeInfoEntity.CriminalClaimInfoEntity = Mapper.Map<CriminalClaimInfo, CriminalClaimInfoEntity>(criminalClaimProfessionalFeeInfo.CriminalClaimInfo);
                    criminalClaimProfessionalFeeInfoEntity.MCriminalClaimantTypeEntity = Mapper.Map<MCriminalClaimantType, MCriminalClaimantTypeEntity>(criminalClaimProfessionalFeeInfo.MCriminalClaimantType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalClaimProfessionalFeeInfoEntity", ex);
                throw;
            }

            return criminalClaimProfessionalFeeInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimWitnessInfoEntity"/> from <see cref="CriminalClaimWitnessInfo"/> input.
        /// </summary>
        /// <param name="criminalClaimWitnessInfo"><see cref="CriminalClaimWitnessInfo"/></param>
        /// <returns>Returns <see cref="CriminalClaimWitnessInfoEntity"/>, else null.</returns>
        public static CriminalClaimWitnessInfoEntity GetCriminalClaimWitnessInfoEntity(CriminalClaimWitnessInfo criminalClaimWitnessInfo)
        {
            CriminalClaimWitnessInfoEntity criminalClaimWitnessInfoEntity = null;

            try
            {
                if (criminalClaimWitnessInfo != null)
                {
                    criminalClaimWitnessInfoEntity = Mapper.Map<CriminalClaimWitnessInfo, CriminalClaimWitnessInfoEntity>(criminalClaimWitnessInfo);
                    //criminalClaimWitnessInfoEntity.CriminalClaimInfoEntity = Mapper.Map<CriminalClaimInfo, CriminalClaimInfoEntity>(criminalClaimWitnessInfo.CriminalClaimInfo);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalClaimWitnessInfoEntity", ex);
                throw;
            }

            return criminalClaimWitnessInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="DCADetailEntity"/> from <see cref="DCADetail"/> input.
        /// </summary>
        /// <param name="dCADetail"><see cref="DCADetail"/></param>
        /// <returns>Returns <see cref="DCADetailEntity"/>, else null.</returns>
        public static DCADetailEntity GetDCADetailEntity(DCADetail dCADetail)
        {
            DCADetailEntity dCADetailEntity = null;

            try
            {
                if (dCADetail != null)
                {
                    dCADetailEntity = Mapper.Map<DCADetail, DCADetailEntity>(dCADetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDCADetailEntity", ex);
                throw;
            }

            return dCADetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="ReportConfigUser"/> from <see cref="ReportConfigUserEntity"/> input.
        /// </summary>
        /// <param name="reportConfigUserEntity"><see cref="ReportConfigUserEntity"/></param>
        /// <returns>Returns <see cref="ReportConfigUser"/>, else null.</returns>
        public static IndexDocDetailEntity GetIndexDocDetailEntity(IndexDocDetail indexDocDetail)
        {
            IndexDocDetailEntity indexDocDetailEntity = null;

            try
            {
                if (indexDocDetail != null)
                {
                    indexDocDetailEntity = Mapper.Map<IndexDocDetail, IndexDocDetailEntity>(indexDocDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetIndexDocDetailEntity", ex);
                throw;
            }

            return indexDocDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="ReportConfigUser"/> from <see cref="ReportConfigUserEntity"/> input.
        /// </summary>
        /// <param name="reportConfigUserEntity"><see cref="ReportConfigUserEntity"/></param>
        /// <returns>Returns <see cref="ReportConfigUser"/>, else null.</returns>
        public static IndexDocInfoEntity GetIndexDocInfoEntity(IndexDocInfo indexDocInfo)
        {
            IndexDocInfoEntity indexDocInfoEntity = null;

            try
            {
                if (indexDocInfo != null)
                {
                    indexDocInfoEntity = Mapper.Map<IndexDocInfo, IndexDocInfoEntity>(indexDocInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetIndexDocInfoEntity", ex);
                throw;
            }

            return indexDocInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="InterfaceCriminalEntity"/> from <see cref="InterfaceCriminal"/> input.
        /// </summary>
        /// <param name="InterfaceCriminal"><see cref="InterfaceCriminal"/></param>
        /// <returns>Returns <see cref="InterfaceCriminal"/>, else null.</returns>
        public static InterfaceCriminalEntity GetInterfaceCriminalEntity(InterfaceCriminal workitemRecipient)
        {
            InterfaceCriminalEntity workitemRecipientEntity = null;

            try
            {
                if (workitemRecipient != null)
                {
                    workitemRecipientEntity = Mapper.Map<InterfaceCriminal, InterfaceCriminalEntity>(workitemRecipient);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetInterfaceCriminalEntity", ex);
                throw;
            }

            return workitemRecipientEntity;
        }

        /// <summary>
        /// Gets the <see cref="InterfaceICAEntity"/> from <see cref="InterfaceICA"/> input.
        /// </summary>
        /// <param name="interfaceICA"><see cref="InterfaceICA"/></param>
        /// <returns>Returns <see cref="InterfaceICAEntity"/>, else null.</returns>
        public static InterfaceICAEntity GetInterfaceICAEntity(InterfaceICA interfaceICA)
        {
            InterfaceICAEntity interfaceICAEntity = null;

            try
            {
                if (interfaceICA != null)
                {
                    interfaceICAEntity = Mapper.Map<InterfaceICA, InterfaceICAEntity>(interfaceICA);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetInterfaceICAEntity", ex);
                throw;
            }

            return interfaceICAEntity;
        }

        /// <summary>
        /// Gets the <see cref="JudicialUserEntity"/> from <see cref="JudicialUser"/> input.
        /// </summary>
        /// <param name="judicialUser"><see cref="JudicialUser"/></param>
        /// <returns>Returns <see cref="JudicialUserEntity"/>, else null.</returns>
        public static JudicialUserEntity GetJudicialUserEntity(JudicialUser judicialUser)
        {
            JudicialUserEntity judicialUserEntity = null;

            try
            {
                if (judicialUser != null)
                {
                    judicialUserEntity = Mapper.Map<JudicialUser, JudicialUserEntity>(judicialUser);
                    judicialUserEntity.MCourtType = Mapper.Map<MCourtType, MCourtTypeEntity>(judicialUser.MCourtType);
                    judicialUserEntity.MUserGroup = Mapper.Map<MUserGroup, MUserGroupEntity>(judicialUser.MUserGroup);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetJudicialUserEntity", ex);
                throw;
            }

            return judicialUserEntity;
        }

        /// <summary>
        /// Gets the <see cref="WorkitemRecipientEntity"/> from <see cref="WorkitemRecipient"/> input.
        /// </summary>
        /// <param name="WorkitemRecipient"><see cref="WorkitemRecipient"/></param>
        /// <returns>Returns <see cref="WorkitemRecipient"/>, else null.</returns>
        public static OGCIncomingQueueEntity GetOGCIncomingQueueEntity(OGCIncomingQueue oGCIncomingQueue)
        {
            OGCIncomingQueueEntity oGCIncomingQueueEntity = null;

            try
            {
                if (oGCIncomingQueue != null)
                {
                    oGCIncomingQueueEntity = Mapper.Map<OGCIncomingQueue, OGCIncomingQueueEntity>(oGCIncomingQueue);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetOGCIncomingQueueEntity", ex);
                throw;
            }

            return oGCIncomingQueueEntity;
        }

        /// <summary>
        /// Gets the <see cref="RARASDetailEntity"/> from <see cref="RARASDetail"/> input.
        /// </summary>
        /// <param name="rARASDetail"><see cref="RARASDetail"/></param>
        /// <returns>Returns <see cref="RARASDetailEntity"/>, else null.</returns>
        public static RARASDetailEntity GetRARASDetailEntity(RARASDetail rARASDetail)
        {
            RARASDetailEntity rARASDetailEntity = null;

            try
            {
                if (rARASDetail != null)
                {
                    rARASDetailEntity = Mapper.Map<RARASDetail, RARASDetailEntity>(rARASDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRARASDetailEntity", ex);
                throw;
            }

            return rARASDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="ReportConfigInfoEntity"/> from <see cref="ReportConfigInfo"/> input.
        /// </summary>
        /// <param name="reportConfigInfo"><see cref="ReportConfigInfo"/></param>
        /// <returns>Returns <see cref="ReportConfigInfoEntity"/>, else null.</returns>
        public static ReportConfigInfoEntity GetReportConfigInfoEntity(ReportConfigInfo reportConfigInfo)
        {
            ReportConfigInfoEntity reportConfigInfoEntity = null;

            try
            {
                if (reportConfigInfo != null)
                {
                    reportConfigInfoEntity = Mapper.Map<ReportConfigInfo, ReportConfigInfoEntity>(reportConfigInfo);
                    reportConfigInfoEntity.MSectionEntity = Mapper.Map<MSection, MSectionEntity>(reportConfigInfo.MSection);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetReportConfigInfoEntity", ex);
                throw;
            }

            return reportConfigInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="ReportConfigUser"/> from <see cref="ReportConfigUserEntity"/> input.
        /// </summary>
        /// <param name="reportConfigUserEntity"><see cref="ReportConfigUserEntity"/></param>
        /// <returns>Returns <see cref="ReportConfigUser"/>, else null.</returns>
        public static ReportConfigUserEntity GetReportConfigUserEntity(ReportConfigUser reportConfigUser)
        {
            ReportConfigUserEntity reportConfigUserEntity = null;

            try
            {
                if (reportConfigUser != null)
                {
                    reportConfigUserEntity = Mapper.Map<ReportConfigUser, ReportConfigUserEntity>(reportConfigUser);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetReportConfigUserEntity", ex);
                throw;
            }

            return reportConfigUserEntity;
        }

        /// <summary>
        /// Gets the <see cref="RMCDRAutoFixTimeLineEntity"/> from <see cref="RMCDRAutoFixTimeLine"/> input.
        /// </summary>
        /// <param name="rMCDRAutoFixTimeLine"><see cref="RMCDRAutoFixTimeLine"/></param>
        /// <returns>Returns <see cref="RMCDRAutoFixTimeLineEntity"/>, else null.</returns>
        public static RMCDRAutoFixTimeLineEntity GetRMCDRAutoFixTimeLineEntity(RMCDRAutoFixTimeLine rMCDRAutoFixTimeLine)
        {
            RMCDRAutoFixTimeLineEntity rMCDRAutoFixTimeLineEntity = null;

            try
            {
                if (rMCDRAutoFixTimeLine != null)
                {
                    rMCDRAutoFixTimeLineEntity = Mapper.Map<RMCDRAutoFixTimeLine, RMCDRAutoFixTimeLineEntity>(rMCDRAutoFixTimeLine);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMCDRAutoFixTimeLineEntity", ex);
                throw;
            }

            return rMCDRAutoFixTimeLineEntity;
        }

        /// <summary>
        /// Gets the <see cref="TaskListEntity"/> from <see cref="TaskList"/> input.
        /// </summary>
        /// <param name="taskList"><see cref="TaskList"/></param>
        /// <returns>Returns <see cref="TaskListEntity"/>, else null.</returns>
        public static TaskListEntity GetTaskListEntity(TaskList taskList)
        {
            TaskListEntity taskListEntity = null;

            try
            {
                if (taskList != null)
                {
                    taskListEntity = Mapper.Map<TaskList, TaskListEntity>(taskList);
                    if (taskList.MSection != null) taskListEntity.MSectionEntity = Mapper.Map<MSection, MSectionEntity>(taskList.MSection);
                    if (taskList.MTaskListType != null) taskListEntity.MTaskListTypeEntity = Mapper.Map<MTaskListType, MTaskListTypeEntity>(taskList.MTaskListType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetTaskList", ex);
                throw;
            }

            return taskListEntity;
        }

        /// <summary>
        /// Gets the <see cref="WorkitemRecipientEntity"/> from <see cref="WorkitemRecipient"/> input.
        /// </summary>
        /// <param name="WorkitemRecipient"><see cref="WorkitemRecipient"/></param>
        /// <returns>Returns <see cref="WorkitemRecipient"/>, else null.</returns>
        public static WorkflowOnAcceptQueueEntity GetWorkflowOnAcceptQueueEntity(WorkflowOnAcceptQueue workflowOnAcceptQueue)
        {
            WorkflowOnAcceptQueueEntity workflowOnAcceptQueueEntity = null;

            try
            {
                if (workflowOnAcceptQueue != null)
                {
                    workflowOnAcceptQueueEntity = Mapper.Map<WorkflowOnAcceptQueue, WorkflowOnAcceptQueueEntity>(workflowOnAcceptQueue);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetWorkflowOnAcceptQueueEntity", ex);
                throw;
            }

            return workflowOnAcceptQueueEntity;
        }

        /// <summary>
        /// Gets the <see cref="WorkitemRecipientEntity"/> from <see cref="WorkitemRecipient"/> input.
        /// </summary>
        /// <param name="WorkitemRecipient"><see cref="WorkitemRecipient"/></param>
        /// <returns>Returns <see cref="WorkitemRecipient"/>, else null.</returns>
        public static WorkflowPostAcceptQueueEntity GetWorkflowPostAcceptQueueEntity(WorkflowPostAcceptQueue workflowPostAcceptQueue)
        {
            WorkflowPostAcceptQueueEntity workflowPostAcceptQueueEntity = null;

            try
            {
                if (workflowPostAcceptQueue != null)
                {
                    workflowPostAcceptQueueEntity = Mapper.Map<WorkflowPostAcceptQueue, WorkflowPostAcceptQueueEntity>(workflowPostAcceptQueue);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetWorkflowPostAcceptQueueEntity", ex);
                throw;
            }

            return workflowPostAcceptQueueEntity;
        }

        /// <summary>
        /// Gets the <see cref="WorkitemDetailsEntity"/> from <see cref="WorkitemDetails"/> input.
        /// </summary>
        /// <param name="WorkitemDetails"><see cref="WorkitemDetails"/></param>
        /// <returns>Returns <see cref="WorkitemDetails"/>, else null.</returns>
        public static BEWorkitemDetailsEntity GetWorkitemDetailsEntity(WorkitemDetails workitemDetails)
        {
            BEWorkitemDetailsEntity workitemDetailsEntity = null;

            try
            {
                if (workitemDetails != null)
                {
                    workitemDetailsEntity = Mapper.Map<WorkitemDetails, BEWorkitemDetailsEntity>(workitemDetails);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetWorkitemDetailsEntity", ex);
                throw;
            }

            return workitemDetailsEntity;
        }

        /// <summary>
        /// Gets the <see cref="WorkitemRecipientEntity"/> from <see cref="WorkitemRecipient"/> input.
        /// </summary>
        /// <param name="WorkitemRecipient"><see cref="WorkitemRecipient"/></param>
        /// <returns>Returns <see cref="WorkitemRecipient"/>, else null.</returns>
        public static BEWorkitemRecipientEntity GetWorkitemRecipientEntity(WorkitemRecipient workitemRecipient)
        {
            BEWorkitemRecipientEntity workitemRecipientEntity = null;

            try
            {
                if (workitemRecipient != null)
                {
                    workitemRecipientEntity = Mapper.Map<WorkitemRecipient, BEWorkitemRecipientEntity>(workitemRecipient);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetWorkitemRecipientEntity", ex);
                throw;
            }

            return workitemRecipientEntity;
        }


        /// <summary>
        /// Gets the RM user PS entity.
        /// </summary>
        /// <param name="rMUserPS">The r M user PS.</param>
        /// <returns></returns>
        public static RMUserPSEntity GetRMUserPSEntity(RMUserPS rMUserPS)
        {
            RMUserPSEntity rMUserPSEntity = null;

            try
            {
                if (rMUserPS != null)
                {
                    rMUserPSEntity = Mapper.Map<RMUserPS, RMUserPSEntity>(rMUserPS);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMUserPSEntity", ex);
                throw;
            }

            return rMUserPSEntity;
        }


        /// <summary>
        /// Gets the number of judge assign detail entity.
        /// </summary>
        /// <param name="numberOfJudgeAssignDetail">The number of judge assign detail.</param>
        /// <returns></returns>
        public static NumberOfJudgeAssignDetailEntity GetNumberOfJudgeAssignDetailEntity(NumberOfJudgeAssignDetail numberOfJudgeAssignDetail)
        {
            NumberOfJudgeAssignDetailEntity numberOfJudgeAssignDetailEntity = null;

            try
            {
                if (numberOfJudgeAssignDetail != null)
                {
                    numberOfJudgeAssignDetailEntity = Mapper.Map<NumberOfJudgeAssignDetail, NumberOfJudgeAssignDetailEntity>(numberOfJudgeAssignDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetNumberOfJudgeAssignDetailEntity", ex);
                throw;
            }

            return numberOfJudgeAssignDetailEntity;
        }


        /// <summary>
        /// Gets the number of judge assign detail history entity.
        /// </summary>
        /// <param name="numberOfJudgeAssignDetailHistory">The number of judge assign detail history.</param>
        /// <returns></returns>
        public static NumberOfJudgeAssignDetailHistoryEntity GetNumberOfJudgeAssignDetailHistoryEntity(NumberOfJudgeAssignDetailHistory numberOfJudgeAssignDetailHistory)
        {
            NumberOfJudgeAssignDetailHistoryEntity numberOfJudgeAssignDetailHistoryEntity = null;

            try
            {
                if (numberOfJudgeAssignDetailHistory != null)
                {
                    numberOfJudgeAssignDetailHistoryEntity = Mapper.Map<NumberOfJudgeAssignDetailHistory, NumberOfJudgeAssignDetailHistoryEntity>(numberOfJudgeAssignDetailHistory);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetNumberOfJudgeAssignDetailHistoryEntity", ex);
                throw;
            }

            return numberOfJudgeAssignDetailHistoryEntity;
        }

        public static ReportConfigTaskInfoEntity GetReportConfigTaskInfoEntity(ReportConfigTaskInfo reportConfigTaskInfo)
        {
            ReportConfigTaskInfoEntity reportConfigTaskInfoEntity = null;
            try
            {
                if (reportConfigTaskInfo != null)
                {
                    reportConfigTaskInfoEntity = Mapper.Map<ReportConfigTaskInfo, ReportConfigTaskInfoEntity>(reportConfigTaskInfo);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetReportConfigTaskInfoEntity", ex);
                throw;
            }
            return reportConfigTaskInfoEntity;
        }

        public static CaseStatusRuleInfoEntity GetCaseStatusRuleInfoEntity(CaseStatusRuleInfo caseStatusRuleInfo)
        {
            CaseStatusRuleInfoEntity caseStatusRuleInfoEntity = null;
            try
            {
                if (caseStatusRuleInfo != null)
                {
                    caseStatusRuleInfoEntity = Mapper.Map<CaseStatusRuleInfo, CaseStatusRuleInfoEntity>(caseStatusRuleInfo);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetReportConfigTaskInfoEntity", ex);
                throw;
            }
            return caseStatusRuleInfoEntity;
        }

        public static WorkflowOutgoingQueueEntity GetWorkflowOutgoingQueueEntity(WorkflowOutgoingQueue workflowOutgoingQueue)
        {
            WorkflowOutgoingQueueEntity workflowOutgoingQueueEntity = null;
            try
            {
                if (workflowOutgoingQueue != null)
                {
                    workflowOutgoingQueueEntity = Mapper.Map<WorkflowOutgoingQueue, WorkflowOutgoingQueueEntity>(workflowOutgoingQueue);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWorkflowOutgoingQueueEntity", ex);
                throw;
            }
            return workflowOutgoingQueueEntity;
        }


        public static DutyJudgeAssignmentEntity GetDutyJudgeAssignmentEntity(DutyJudgeAssignment dutyJudgeAssignment)
        {
            DutyJudgeAssignmentEntity dutyJudgeAssignmentEntity = null;
            try
            {
                if (dutyJudgeAssignment != null)
                {
                    dutyJudgeAssignmentEntity = Mapper.Map<DutyJudgeAssignment, DutyJudgeAssignmentEntity>(dutyJudgeAssignment);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDutyJudgeAssignmentEntity", ex);
                throw;
            }
            return dutyJudgeAssignmentEntity;
        }

        /// <summary>
        /// Gets the RPT disposal KPI config entity.
        /// </summary>
        /// <param name="rptDisposalKPIConfig">The RPT disposal KPI config.</param>
        /// <returns></returns>
        public static RPTDisposalKPIConfigEntity GetRPTDisposalKPIConfigEntity(RPTDisposalKPIConfig rptDisposalKPIConfig)
        {
            RPTDisposalKPIConfigEntity rptDisposalKPIConfigEntity = null;
            try
            {
                if (rptDisposalKPIConfig != null)
                {
                    rptDisposalKPIConfigEntity = Mapper.Map<RPTDisposalKPIConfig, RPTDisposalKPIConfigEntity>(rptDisposalKPIConfig);

                }
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }
            return rptDisposalKPIConfigEntity;
        }

        /// <summary>
        /// Gets the RPTNOC group NOC entity.
        /// </summary>
        /// <param name="rptNOCGroupNOC">The RPT NOC group NOC.</param>
        /// <returns></returns>
        public static RPTNOCGroupNOCEntity GetRPTNOCGroupNOCEntity(RPTNOCGroupNOC rptNOCGroupNOC)
        {
            RPTNOCGroupNOCEntity rptNOCGroupNOCEntity = null;
            try
            {
                if (rptNOCGroupNOC != null)
                {
                    rptNOCGroupNOCEntity = Mapper.Map<RPTNOCGroupNOC, RPTNOCGroupNOCEntity>(rptNOCGroupNOC);

                }
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }
            return rptNOCGroupNOCEntity;
        }

        /// <summary>
        /// Gets the RPTNOC group NOC entity.
        /// </summary>
        /// <param name="rptNOCGroup">The RPT NOC group.</param>
        /// <returns></returns>
        public static RPTNOCGroupEntity GetRPTNOCGroupEntity(RPTNOCGroup rptNOCGroup)
        {
            RPTNOCGroupEntity rptNOCGroupEntity = null;
            try
            {
                if (rptNOCGroup != null)
                {
                    rptNOCGroupEntity = Mapper.Map<RPTNOCGroup, RPTNOCGroupEntity>(rptNOCGroup);

                }
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }
            return rptNOCGroupEntity;
        }
        #endregion Methods

       
    }
}