#region Header

/*****************************************************************************************************
* Description : This file represents a object mapper Common entities. This class will map Object to
* Entity.
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
// Description: This file represents a object mapper BackEndSpecific entities. This class will map Object to
// Entity.
// </summary>
// <copyright file= "BackEndSpecific.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping;
    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    public class BackEndSpecificMapper
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(CommonMapper));

        #endregion Fields

        #region Methods

        public static IBackEndSpecific GetBackEndSpecificEntity<T>(T backEndSpecificEntity)
        {
            try
            {
                if (backEndSpecificEntity.GetType().Equals(typeof(ReportConfigInfoEntity)))
                    return GetReportConfigInfo(backEndSpecificEntity as ReportConfigInfoEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(ReportConfigUserEntity)))
                    return GetReportConfigUser(backEndSpecificEntity as ReportConfigUserEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(AssessmentDamageEntity)))
                    return GetAssessmentDamage(backEndSpecificEntity as AssessmentDamageEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(IndexDocDetailEntity)))
                    return GetIndexDocDetail(backEndSpecificEntity as IndexDocDetailEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(IndexDocInfoEntity)))
                    return GetIndexDocInfo(backEndSpecificEntity as IndexDocInfoEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(TaskListEntity)))
                    return GetTaskList(backEndSpecificEntity as TaskListEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(CriminalClaimInfoEntity)))
                    return GetCriminalClaimInfo(backEndSpecificEntity as CriminalClaimInfoEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(CriminalClaimHonorariumInfoEntity)))
                    return GetCriminalClaimHonorariumInfo(backEndSpecificEntity as CriminalClaimHonorariumInfoEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(CriminalClaimWitnessInfoEntity)))
                    return GetCriminalClaimWitnessInfo(backEndSpecificEntity as CriminalClaimWitnessInfoEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(CriminalClaimInterpreterFeeInfoEntity)))
                    return GetCriminalClaimInterpreterFeeInfo(backEndSpecificEntity as CriminalClaimInterpreterFeeInfoEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(CriminalClaimProfessionalFeeInfoEntity)))
                    return GetCriminalClaimProfessionalFeeInfo(backEndSpecificEntity as CriminalClaimProfessionalFeeInfoEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(CriminalClaimMiscellaneousInfoEntity)))
                    return GetCriminalClaimMiscellaneousInfo(backEndSpecificEntity as CriminalClaimMiscellaneousInfoEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(DCADetailEntity)))
                    return GetDCADetail(backEndSpecificEntity as DCADetailEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(RARASDetailEntity)))
                    return GetRARASDetail(backEndSpecificEntity as RARASDetailEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(BankruptcyDRSInfoEntity)))
                    return GetBankruptcyDRSInfo(backEndSpecificEntity as BankruptcyDRSInfoEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(BEWorkitemDetailsEntity)))
                    return GetWorkitemDetails(backEndSpecificEntity as BEWorkitemDetailsEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(BEWorkitemRecipientEntity)))
                    return GetWorkitemRecipient(backEndSpecificEntity as BEWorkitemRecipientEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(InterfaceCriminalEntity)))
                    return GetInterfaceCriminal(backEndSpecificEntity as InterfaceCriminalEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(BizMonitoringInfoEntity)))
                    return GetBizMonitoringInfo(backEndSpecificEntity as BizMonitoringInfoEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(WorkflowOnAcceptQueueEntity)))
                    return GetWorkflowOnAcceptQueue(backEndSpecificEntity as WorkflowOnAcceptQueueEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(WorkflowPostAcceptQueueEntity)))
                    return GetWorkflowPostAcceptQueue(backEndSpecificEntity as WorkflowPostAcceptQueueEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(OGCIncomingQueueEntity)))
                    return GetOGCIncomingQueue(backEndSpecificEntity as OGCIncomingQueueEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(RMUserPSEntity)))
                    return GetRMUserPS(backEndSpecificEntity as RMUserPSEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(RUserPA)))
                    return GetRUserPA(backEndSpecificEntity as RUserPAEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(NumberOfJudgeAssignDetailEntity)))
                    return GetNumberOfJudgeAssignDetail(backEndSpecificEntity as NumberOfJudgeAssignDetailEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(NumberOfJudgeAssignDetailHistoryEntity)))
                    return GetNumberOfJudgeAssignDetailHistory(backEndSpecificEntity as NumberOfJudgeAssignDetailHistoryEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(ReportConfigTaskInfoEntity)))
                    return GetReportConfigTaskInfo(backEndSpecificEntity as ReportConfigTaskInfoEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(ArchiveNumberOfJudgeAssignDetailEntity)))
                    return GetArchiveNumberOfJudgeAssignDetail(backEndSpecificEntity as ArchiveNumberOfJudgeAssignDetailEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(ArchiveNumberOfJudgeAssignDetailHistoryEntity)))
                    return GetArchiveNumberOfJudgeAssignDetailHistory(backEndSpecificEntity as ArchiveNumberOfJudgeAssignDetailHistoryEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(ArchiveBEWorkitemRecipientEntity)))
                    return GetArchiveWorkitemRecipient(backEndSpecificEntity as ArchiveBEWorkitemRecipientEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(ArchiveWorkitemDetailsEntity)))
                    return GetArchiveWorkitemDetails(backEndSpecificEntity as ArchiveWorkitemDetailsEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(ArchiveTaskListEntity)))
                    return GetArchiveTaskList(backEndSpecificEntity as ArchiveTaskListEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(CaseStatusRuleInfoEntity)))
                    return GetCaseStatusRuleInfo(backEndSpecificEntity as CaseStatusRuleInfoEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(OGCProcessingInfoEntity)))
                    return GetOGCProcessingInfo(backEndSpecificEntity as OGCProcessingInfoEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(UsersEntity)))
                    return DomainMapperService.GetEntity<UsersEntity, Users>(backEndSpecificEntity as UsersEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(WorkflowOutgoingQueueEntity)))
                    return GetWorkflowOutgoingQueue(backEndSpecificEntity as WorkflowOutgoingQueueEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(DutyJudgeAssignmentEntity)))
                    return GetDutyJudgeAssignment(backEndSpecificEntity as DutyJudgeAssignmentEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(RPTNOCGroupNOCEntity)))
                    return GetRPTNOCGroupNOC(backEndSpecificEntity as RPTNOCGroupNOCEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(RPTDisposalKPIConfigEntity)))
                    return GetRPTDisposalKPIConfig(backEndSpecificEntity as RPTDisposalKPIConfigEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(RPTNOCGroupEntity)))
                    return GetRPTNOCGroupEntity(backEndSpecificEntity as RPTNOCGroupEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(UndoSerialNumberEntity)))
                    return GetUndoSerialNumber(backEndSpecificEntity as UndoSerialNumberEntity);

                else if (backEndSpecificEntity.GetType().Equals(typeof(JudicialUserEntity)))
                    return GetJudicialUser(backEndSpecificEntity as JudicialUserEntity);

                else
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetCommonEntity method in CommonMapper.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBackEndSpecificEntity", ex);
                return null;
            }
        }

        private static IBackEndSpecific GetJudicialUser(JudicialUserEntity judicialUserEntity)
        {
            JudicialUser judicialUser = null;

            try
            {
                if (judicialUserEntity != null)
                {
                    judicialUser = Mapper.Map<JudicialUserEntity, JudicialUser>(judicialUserEntity);
                    judicialUser.MCourtType = Mapper.Map<MCourtTypeEntity, MCourtType>(judicialUserEntity.MCourtType);
                    judicialUser.MUserGroup = Mapper.Map<MUserGroupEntity, MUserGroup>(judicialUserEntity.MUserGroup);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetJudicialUser", ex);
                throw;
            }

            return judicialUser;
        }

        /// <summary>
        /// Gets the <see cref="RUserPAEntity"/> from <see cref="RUserPA"/> input.
        /// </summary>
        /// <param name="RUserPA"><see cref="RUserPA"/></param>
        /// <returns>Returns <see cref="RUserPA"/>, else null.</returns>
        public static RUserPA GetRUserPA(RUserPAEntity rUserPAEntity)
        {
            RUserPA rUserPA = null;

            try
            {
                if (rUserPAEntity != null)
                {
                    rUserPA = Mapper.Map<RUserPAEntity, RUserPA>(rUserPAEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRUserPA", ex);
                throw;
            }

            return rUserPA;
        }

        /* End of Criminal Claim Getters */
        /// <summary>
        /// Get BankruptcyDRSInfo
        /// </summary>
        /// <param name="bankruptcyDRSInfoEntity"></param>
        /// <returns></returns>
        public static BankruptcyDRSInfo GetBankruptcyDRSInfo(BankruptcyDRSInfoEntity bankruptcyDRSInfoEntity)
        {
            BankruptcyDRSInfo bankruptcyDRSInfo = null;

            try
            {
                if (bankruptcyDRSInfoEntity != null)
                {
                    bankruptcyDRSInfo = Mapper.Map<BankruptcyDRSInfoEntity, BankruptcyDRSInfo>(bankruptcyDRSInfoEntity);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBankruptcyDRSInfo", ex);
                throw;
            }

            return bankruptcyDRSInfo;
        }


        /// <summary>
        /// Gets the <see cref="InterfaceCriminalEntity"/> from <see cref="InterfaceCriminal"/> input.
        /// </summary>
        /// <param name="InterfaceCriminal"><see cref="InterfaceCriminal"/></param>
        /// <returns>Returns <see cref="InterfaceCriminal"/>, else null.</returns>
        public static BizMonitoringInfo GetBizMonitoringInfo(BizMonitoringInfoEntity bizMonitoringInfoEntity)
        {
            BizMonitoringInfo bizMonitoringInfo = null;

            try
            {
                if (bizMonitoringInfoEntity != null)
                {
                    bizMonitoringInfo = Mapper.Map<BizMonitoringInfoEntity, BizMonitoringInfo>(bizMonitoringInfoEntity);
                    bizMonitoringInfo.MMonitoringType = Mapper.Map<MMonitoringTypeEntity, MMonitoringType>(bizMonitoringInfoEntity.MMonitoringType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBizMonitoringInfoEntity", ex);
                throw;
            }

            return bizMonitoringInfo;
        }

        /// <summary>
        /// Gets the <see cref="ContinuingLegalEducationInfo"/> from <see cref="ContinuingLegalEducationInfoEntity"/> input.
        /// </summary>
        /// <param name="continuingLegalEducationInfoEntity"><see cref="ContinuingLegalEducationInfoEntity"/></param>
        /// <returns>Returns <see cref="ContinuingLegalEducationInfo"/>, else null.</returns>
        public static ContinuingLegalEducationInfo GetContinuingLegalEducationInfo(ContinuingLegalEducationInfoEntity continuingLegalEducationInfoEntity)
        {
            ContinuingLegalEducationInfo continuingLegalEducationInfo = null;

            try
            {
                if (continuingLegalEducationInfoEntity != null)
                {
                    continuingLegalEducationInfo = Mapper.Map<ContinuingLegalEducationInfoEntity, ContinuingLegalEducationInfo>(continuingLegalEducationInfoEntity);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetContinuingLegalEducationInfo", ex);
                throw;
            }

            return continuingLegalEducationInfo;
        }

        /* Criminal Claim Getters */
        /// <summary>
        /// Get Criminal Claim - Honorarium Info.
        /// </summary>
        /// <param name="criminalClaimHonorariumInfoDomainEntity"></param>
        /// <returns></returns>
        public static CriminalClaimHonorariumInfo GetCriminalClaimHonorariumInfo(CriminalClaimHonorariumInfoEntity criminalClaimHonorariumInfoDomainEntity)
        {
            CriminalClaimHonorariumInfo criminalClaimHonorariumInfoNHibernateEntity = null;

            try
            {
                if (criminalClaimHonorariumInfoDomainEntity != null)
                {
                    criminalClaimHonorariumInfoNHibernateEntity = Mapper.Map<CriminalClaimHonorariumInfoEntity, CriminalClaimHonorariumInfo>(criminalClaimHonorariumInfoDomainEntity);
                    //criminalClaimHonorariumInfoNHibernateEntity.CriminalClaimInfo = Mapper.Map<CriminalClaimInfoEntity, CriminalClaimInfo>(criminalClaimHonorariumInfoDomainEntity.CriminalClaimInfoEntity);
                    criminalClaimHonorariumInfoNHibernateEntity.Solicitor = Mapper.Map<SolicitorEntity, Solicitor>(criminalClaimHonorariumInfoDomainEntity.SolicitorEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCriminalClaimHonorariumInfoEntity", ex);
                throw;
            }

            return criminalClaimHonorariumInfoNHibernateEntity;
        }

        /// <summary>
        /// Get Criminal Claim Info.
        /// </summary>
        /// <param name="criminalClaimInfoDomainEntity"></param>
        /// <returns></returns>
        public static CriminalClaimInfo GetCriminalClaimInfo(CriminalClaimInfoEntity criminalClaimInfoDomainEntity)
        {
            CriminalClaimInfo criminalClaimInfoNHibernateEntity = null;

            try
            {
                if (criminalClaimInfoDomainEntity != null)
                {
                    criminalClaimInfoNHibernateEntity = Mapper.Map<CriminalClaimInfoEntity, CriminalClaimInfo>(criminalClaimInfoDomainEntity);
                    criminalClaimInfoNHibernateEntity.MCriminalClaimType = Mapper.Map<MCriminalClaimTypeEntity, MCriminalClaimType>(criminalClaimInfoDomainEntity.MCriminalClaimTypeEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCriminalClaimInfoEntity", ex);
                throw;
            }

            return criminalClaimInfoNHibernateEntity;
        }

        /// <summary>
        /// Get Criminal Claim - Interpreter Fee Info.
        /// </summary>
        /// <param name="criminalClaimInterpreterFeeInfoDomainEntity"></param>
        /// <returns></returns>
        public static CriminalClaimInterpreterFeeInfo GetCriminalClaimInterpreterFeeInfo(CriminalClaimInterpreterFeeInfoEntity criminalClaimInterpreterFeeInfoDomainEntity)
        {
            CriminalClaimInterpreterFeeInfo criminalClaimInterpreterFeeInfoNHibernateEntity = null;

            try
            {
                if (criminalClaimInterpreterFeeInfoDomainEntity != null)
                {
                    criminalClaimInterpreterFeeInfoNHibernateEntity = Mapper.Map<CriminalClaimInterpreterFeeInfoEntity, CriminalClaimInterpreterFeeInfo>(criminalClaimInterpreterFeeInfoDomainEntity);
                    //criminalClaimInterpreterFeeInfoNHibernateEntity.CriminalClaimInfo = Mapper.Map<CriminalClaimInfoEntity, CriminalClaimInfo>(criminalClaimInterpreterFeeInfoDomainEntity.CriminalClaimInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCriminalClaimInterpreterFeeInfoEntity", ex);
                throw;
            }

            return criminalClaimInterpreterFeeInfoNHibernateEntity;
        }

        /// <summary>
        /// Get Criminal Claim - Miscellaneous Info.
        /// </summary>
        /// <param name="criminalClaimMiscellaneousInfoDomainEntity"></param>
        /// <returns></returns>
        public static CriminalClaimMiscellaneousInfo GetCriminalClaimMiscellaneousInfo(CriminalClaimMiscellaneousInfoEntity criminalClaimMiscellaneousInfoDomainEntity)
        {
            CriminalClaimMiscellaneousInfo criminalClaimMiscellaneousInfoNHibernateEntity = null;

            try
            {
                if (criminalClaimMiscellaneousInfoDomainEntity != null)
                {
                    criminalClaimMiscellaneousInfoNHibernateEntity = Mapper.Map<CriminalClaimMiscellaneousInfoEntity, CriminalClaimMiscellaneousInfo>(criminalClaimMiscellaneousInfoDomainEntity);
                    //criminalClaimMiscellaneousInfoNHibernateEntity.CriminalClaimInfo = Mapper.Map<CriminalClaimInfoEntity, CriminalClaimInfo>(criminalClaimMiscellaneousInfoDomainEntity.CriminalClaimInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCriminalClaimMiscellaneousInfoEntity", ex);
                throw;
            }

            return criminalClaimMiscellaneousInfoNHibernateEntity;
        }

        /// <summary>
        /// Get Criminal Claim - ProfessionalFee Info.
        /// </summary>
        /// <param name="criminalClaimProfessionalFeeInfoDomainEntity"></param>
        /// <returns></returns>
        public static CriminalClaimProfessionalFeeInfo GetCriminalClaimProfessionalFeeInfo(CriminalClaimProfessionalFeeInfoEntity criminalClaimProfessionalFeeInfoDomainEntity)
        {
            CriminalClaimProfessionalFeeInfo criminalClaimProfessionalFeeInfoNHibernateEntity = null;

            try
            {
                if (criminalClaimProfessionalFeeInfoDomainEntity != null)
                {
                    criminalClaimProfessionalFeeInfoNHibernateEntity = Mapper.Map<CriminalClaimProfessionalFeeInfoEntity, CriminalClaimProfessionalFeeInfo>(criminalClaimProfessionalFeeInfoDomainEntity);
                    //criminalClaimProfessionalFeeInfoNHibernateEntity.CriminalClaimInfo = Mapper.Map<CriminalClaimInfoEntity, CriminalClaimInfo>(criminalClaimProfessionalFeeInfoDomainEntity.CriminalClaimInfoEntity);
                    criminalClaimProfessionalFeeInfoNHibernateEntity.MCriminalClaimantType = Mapper.Map<MCriminalClaimantTypeEntity, MCriminalClaimantType>(criminalClaimProfessionalFeeInfoDomainEntity.MCriminalClaimantTypeEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCriminalClaimProfessionalFeeInfoEntity", ex);
                throw;
            }

            return criminalClaimProfessionalFeeInfoNHibernateEntity;
        }

        /// <summary>
        /// Get Criminal Claim - Witness Info.
        /// </summary>
        /// <param name="criminalClaimWitnessInfoDomainEntity"></param>
        /// <returns></returns>
        public static CriminalClaimWitnessInfo GetCriminalClaimWitnessInfo(CriminalClaimWitnessInfoEntity criminalClaimWitnessInfoDomainEntity)
        {
            CriminalClaimWitnessInfo criminalClaimWitnessInfoNHibernateEntity = null;

            try
            {
                if (criminalClaimWitnessInfoDomainEntity != null)
                {
                    criminalClaimWitnessInfoNHibernateEntity = Mapper.Map<CriminalClaimWitnessInfoEntity, CriminalClaimWitnessInfo>(criminalClaimWitnessInfoDomainEntity);
                    //criminalClaimWitnessInfoNHibernateEntity.CriminalClaimInfo = Mapper.Map<CriminalClaimInfoEntity, CriminalClaimInfo>(criminalClaimWitnessInfoDomainEntity.CriminalClaimInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCriminalClaimWitnessInfoEntity", ex);
                throw;
            }

            return criminalClaimWitnessInfoNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="DCADetail"/> from <see cref="dCADetailEntity"/> input.
        /// </summary>
        /// <param name="dCADetailEntity"><see cref="DCADetailEntity"/></param>
        /// <returns>Returns <see cref="DCADetail"/>, else null.</returns>
        public static DCADetail GetDCADetail(DCADetailEntity dCADetailEntity)
        {
            DCADetail dCADetail = null;

            try
            {
                if (dCADetailEntity != null)
                {
                    dCADetail = Mapper.Map<DCADetailEntity, DCADetail>(dCADetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDCADetail", ex);
                throw;
            }

            return dCADetail;
        }

        /// <summary>
        /// Gets the <see cref="DisciplinaryActionInfo"/> from <see cref="DisciplinaryActionInfoEntity"/> input.
        /// </summary>
        /// <param name="disciplinaryActionInfoEntity"><see cref="DisciplinaryActionInfoEntity"/></param>
        /// <returns>Returns <see cref="DisciplinaryActionInfo"/>, else null.</returns>
        public static DisciplinaryActionInfo GetDisciplinaryActionInfo(DisciplinaryActionInfoEntity disciplinaryActionInfoEntity)
        {
            DisciplinaryActionInfo disciplinaryActionInfo = null;

            try
            {
                if (disciplinaryActionInfoEntity != null)
                {
                    disciplinaryActionInfo = Mapper.Map<DisciplinaryActionInfoEntity, DisciplinaryActionInfo>(disciplinaryActionInfoEntity);
                    disciplinaryActionInfo.MAASDisciplinaryType = Mapper.Map<MAASDisciplinaryTypeEntity, MAASDisciplinaryType>(disciplinaryActionInfoEntity.MAASDisciplinaryType);
                    disciplinaryActionInfo.MAASDisciplinaryResultType = Mapper.Map<MAASDisciplinaryResultTypeEntity, MAASDisciplinaryResultType>(disciplinaryActionInfoEntity.MAASDisciplinaryResultType);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDisciplinaryActionInfo", ex);
                throw;
            }

            return disciplinaryActionInfo;
        }

        /// <summary>
        /// Gets the <see cref="ReportConfigUser"/> from <see cref="ReportConfigUserEntity"/> input.
        /// </summary>
        /// <param name="reportConfigUserEntity"><see cref="ReportConfigUserEntity"/></param>
        /// <returns>Returns <see cref="ReportConfigUser"/>, else null.</returns>
        public static IndexDocDetail GetIndexDocDetail(IndexDocDetailEntity indexDocDetailEntity)
        {
            IndexDocDetail indexDocDetail = null;

            try
            {
                if (indexDocDetailEntity != null)
                {
                    indexDocDetail = Mapper.Map<IndexDocDetailEntity, IndexDocDetail>(indexDocDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetIndexDocDetail", ex);
                throw;
            }

            return indexDocDetail;
        }

        /// <summary>
        /// Gets the <see cref="ReportConfigUser"/> from <see cref="ReportConfigUserEntity"/> input.
        /// </summary>
        /// <param name="reportConfigUserEntity"><see cref="ReportConfigUserEntity"/></param>
        /// <returns>Returns <see cref="ReportConfigUser"/>, else null.</returns>
        public static IndexDocInfo GetIndexDocInfo(IndexDocInfoEntity indexDocInfoEntity)
        {
            IndexDocInfo indexDocInfo = null;

            try
            {
                if (indexDocInfoEntity != null)
                {
                    indexDocInfo = Mapper.Map<IndexDocInfoEntity, IndexDocInfo>(indexDocInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetIndexDocInfo", ex);
                throw;
            }

            return indexDocInfo;
        }

        /// <summary>
        /// Gets the <see cref="workitemRecipient"/> from <see cref="InterfaceCriminal"/> input.
        /// </summary>
        /// <param name="workitemRecipientEntity"><see cref="InterfaceCriminalEntity"/></param>
        /// <returns>Returns <see cref="InterfaceCriminal"/>, else null.</returns>
        public static InterfaceCriminal GetInterfaceCriminal(InterfaceCriminalEntity iTCriminalEntity)
        {
            InterfaceCriminal iTCriminal = null;

            try
            {
                if (iTCriminalEntity != null)
                {
                    iTCriminal = Mapper.Map<InterfaceCriminalEntity, InterfaceCriminal>(iTCriminalEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetInterfaceCriminal", ex);
                throw;
            }

            return iTCriminal;
        }

        /// <summary>
        /// Gets the <see cref="workitemRecipient"/> from <see cref="WorkitemRecipient"/> input.
        /// </summary>
        /// <param name="workitemRecipientEntity"><see cref="WorkitemRecipientEntity"/></param>
        /// <returns>Returns <see cref="WorkitemRecipient"/>, else null.</returns>
        public static OGCIncomingQueue GetOGCIncomingQueue(OGCIncomingQueueEntity oGCIncomingQueueEntity)
        {
            OGCIncomingQueue oGCIncomingQueue = null;

            try
            {
                if (oGCIncomingQueueEntity != null)
                {
                    oGCIncomingQueue = Mapper.Map<OGCIncomingQueueEntity, OGCIncomingQueue>(oGCIncomingQueueEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetOGCIncomingQueue", ex);
                throw;
            }

            return oGCIncomingQueue;
        }

        /// <summary>
        /// Gets the <see cref="RARASDetail"/> from <see cref="RARASDetailEntity"/> input.
        /// </summary>
        /// <param name="rARASDetailEntity"><see cref="RARASDetailEntity"/></param>
        /// <returns>Returns <see cref="RARASDetail"/>, else null.</returns>
        public static RARASDetail GetRARASDetail(RARASDetailEntity rARASDetailEntity)
        {
            RARASDetail rARASDetail = null;

            try
            {
                if (rARASDetailEntity != null)
                {
                    rARASDetail = Mapper.Map<RARASDetailEntity, RARASDetail>(rARASDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRARASDetail", ex);
                throw;
            }

            return rARASDetail;
        }

        /// <summary>
        /// Gets the <see cref="ReportConfigInfo"/> from <see cref="ReportConfigInfoEntity"/> input.
        /// </summary>
        /// <param name="reportConfigInfoEntity"><see cref="ReportConfigInfoEntity"/></param>
        /// <returns>Returns <see cref="ReportConfigInfo"/>, else null.</returns>
        public static ReportConfigInfo GetReportConfigInfo(ReportConfigInfoEntity reportConfigInfoEntity)
        {
            ReportConfigInfo reportConfigInfo = null;

            try
            {
                if (reportConfigInfoEntity != null)
                {
                    reportConfigInfo = Mapper.Map<ReportConfigInfoEntity, ReportConfigInfo>(reportConfigInfoEntity);
                    reportConfigInfo.MSection = Mapper.Map<MSectionEntity, MSection>(reportConfigInfoEntity.MSectionEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetReportConfigInfo", ex);
                throw;
            }

            return reportConfigInfo;
        }

        /// <summary>
        /// Gets the <see cref="ReportConfigUser"/> from <see cref="ReportConfigUserEntity"/> input.
        /// </summary>
        /// <param name="reportConfigUserEntity"><see cref="ReportConfigUserEntity"/></param>
        /// <returns>Returns <see cref="ReportConfigUser"/>, else null.</returns>
        public static ReportConfigUser GetReportConfigUser(ReportConfigUserEntity reportConfigUserEntity)
        {
            ReportConfigUser reportConfigUser = null;

            try
            {
                if (reportConfigUserEntity != null)
                {
                    reportConfigUser = Mapper.Map<ReportConfigUserEntity, ReportConfigUser>(reportConfigUserEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetReportConfigUser", ex);
                throw;
            }

            return reportConfigUser;
        }

        /// <summary>
        /// Gets the <see cref="ReportConfigUser"/> from <see cref="ReportConfigUserEntity"/> input.
        /// </summary>
        /// <param name="reportConfigUserEntity"><see cref="ReportConfigUserEntity"/></param>
        /// <returns>Returns <see cref="ReportConfigUser"/>, else null.</returns>
        public static TaskList GetTaskList(TaskListEntity taskListEntity)
        {
            Logger.Debug("Mapping TaskList");
            TaskList taskList = null;

            try
            {
                if (taskListEntity != null)
                {
                    taskList = Mapper.Map<TaskListEntity, TaskList>(taskListEntity);
                    if (taskListEntity.MSectionEntity != null) taskList.MSection = Mapper.Map<MSectionEntity, MSection>(taskListEntity.MSectionEntity);
                    if (taskListEntity.MTaskListTypeEntity != null) taskList.MTaskListType = Mapper.Map<MTaskListTypeEntity, MTaskListType>(taskListEntity.MTaskListTypeEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetTaskList", ex);
                throw;
            }

            return taskList;
        }

        public static ArchiveTaskList GetArchiveTaskList(ArchiveTaskListEntity archiveTaskListEntity)
        {
            ArchiveTaskList archiveTaskList = null;

            try
            {
                if (archiveTaskListEntity != null)
                {
                    archiveTaskList = Mapper.Map<ArchiveTaskListEntity, ArchiveTaskList>(archiveTaskListEntity);
                    if (archiveTaskListEntity.MSectionEntity != null) archiveTaskList.MSection = Mapper.Map<MSectionEntity, MSection>(archiveTaskListEntity.MSectionEntity);
                    if (archiveTaskListEntity.MTaskListTypeEntity != null) archiveTaskList.MTaskListType = Mapper.Map<MTaskListTypeEntity, MTaskListType>(archiveTaskListEntity.MTaskListTypeEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetArchiveTaskList", ex);
                throw;
            }

            return archiveTaskList;
        }

        /// <summary>
        /// Gets the <see cref="workitemRecipient"/> from <see cref="WorkitemRecipient"/> input.
        /// </summary>
        /// <param name="workitemRecipientEntity"><see cref="WorkitemRecipientEntity"/></param>
        /// <returns>Returns <see cref="WorkitemRecipient"/>, else null.</returns>
        public static WorkflowOnAcceptQueue GetWorkflowOnAcceptQueue(WorkflowOnAcceptQueueEntity workflowOnAcceptQueueEntity)
        {
            WorkflowOnAcceptQueue workflowOnAcceptQueue = null;

            try
            {
                if (workflowOnAcceptQueueEntity != null)
                {
                    workflowOnAcceptQueue = Mapper.Map<WorkflowOnAcceptQueueEntity, WorkflowOnAcceptQueue>(workflowOnAcceptQueueEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetWorkflowOnAcceptQueue", ex);
                throw;
            }

            return workflowOnAcceptQueue;
        }

        /// <summary>
        /// Gets the <see cref="workitemRecipient"/> from <see cref="WorkitemRecipient"/> input.
        /// </summary>
        /// <param name="workitemRecipientEntity"><see cref="WorkitemRecipientEntity"/></param>
        /// <returns>Returns <see cref="WorkitemRecipient"/>, else null.</returns>
        public static WorkflowPostAcceptQueue GetWorkflowPostAcceptQueue(WorkflowPostAcceptQueueEntity workflowPostAcceptQueueEntity)
        {
            WorkflowPostAcceptQueue workflowPostAcceptQueue = null;

            try
            {
                if (workflowPostAcceptQueueEntity != null)
                {
                    workflowPostAcceptQueue = Mapper.Map<WorkflowPostAcceptQueueEntity, WorkflowPostAcceptQueue>(workflowPostAcceptQueueEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetWorkflowPostAcceptQueue", ex);
                throw;
            }

            return workflowPostAcceptQueue;
        }

        /// <summary>
        /// Gets the <see cref="workitemDetails"/> from <see cref="WorkitemDetails"/> input.
        /// </summary>
        /// <param name="workitemDetailsEntity"><see cref="WorkitemDetailsEntity"/></param>
        /// <returns>Returns <see cref="WorkitemDetails"/>, else null.</returns>
        public static WorkitemDetails GetWorkitemDetails(BEWorkitemDetailsEntity workitemDetailsEntity)
        {
            WorkitemDetails workitemDetails = null;

            try
            {
                if (workitemDetailsEntity != null)
                {
                    workitemDetails = Mapper.Map<BEWorkitemDetailsEntity, WorkitemDetails>(workitemDetailsEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetWorkitemDetails", ex);
                throw;
            }

            return workitemDetails;
        }

        /// <summary>
        /// Gets the <see cref="workitemRecipient"/> from <see cref="WorkitemRecipient"/> input.
        /// </summary>
        /// <param name="workitemRecipientEntity"><see cref="WorkitemRecipientEntity"/></param>
        /// <returns>Returns <see cref="WorkitemRecipient"/>, else null.</returns>
        public static WorkitemRecipient GetWorkitemRecipient(BEWorkitemRecipientEntity workitemRecipientEntity)
        {
            WorkitemRecipient workitemRecipient = null;

            try
            {
                if (workitemRecipientEntity != null)
                {
                    workitemRecipient = Mapper.Map<BEWorkitemRecipientEntity, WorkitemRecipient>(workitemRecipientEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetWorkitemRecipient", ex);
                throw;
            }

            return workitemRecipient;
        }

        /// <summary>
        /// Gets the <see cref="RMUserPS"/> from <see cref="RMUserPSEntity"/> input.
        /// </summary>
        /// <param name="RMUserPSEntity"><see cref="RMUserPSEntity"/></param>
        /// <returns>Returns <see cref="RMUserPS"/>, else null.</returns>
        public static RMUserPS GetRMUserPS(RMUserPSEntity entity)
        {
            RMUserPS data = null;

            try
            {
                if (entity != null)
                {
                    data = Mapper.Map<RMUserPSEntity, RMUserPS>(entity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMUserPS", ex);
                throw;
            }

            return data;
        }

        /// <summary>
        /// Gets the <see cref="AssessmentDamage"/> from <see cref="AssessmentDamageEntity"/> input.
        /// </summary>
        /// <param name="assessmentDamageEntity"><see cref="assessmentDamageEntity"/></param>
        /// <returns>Returns <see cref="AssessmentDamage"/>, else null.</returns>
        public static AssessmentDamage GetAssessmentDamage(AssessmentDamageEntity assessmentDamageEntity)
        {
            AssessmentDamage assessmentDamage = null;

            try
            {
                if (assessmentDamageEntity != null)
                {
                    assessmentDamage = Mapper.Map<AssessmentDamageEntity, AssessmentDamage>(assessmentDamageEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetAssessmentDamage", ex);
                throw;
            }

            return assessmentDamage;
        }


        /// <summary>
        /// Gets the number of judge assign detail.
        /// </summary>
        /// <param name="numberOfJudgeAssignDetailEntity">The number of judge assign detail entity.</param>
        /// <returns></returns>
        public static NumberOfJudgeAssignDetail GetNumberOfJudgeAssignDetail(NumberOfJudgeAssignDetailEntity numberOfJudgeAssignDetailEntity)
        {
            NumberOfJudgeAssignDetail numberOfJudgeAssignDetail = null;

            try
            {
                if (numberOfJudgeAssignDetailEntity != null)
                {
                    numberOfJudgeAssignDetail = Mapper.Map<NumberOfJudgeAssignDetailEntity, NumberOfJudgeAssignDetail>(numberOfJudgeAssignDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetNumberOfJudgeAssignDetail", ex);
                throw;
            }

            return numberOfJudgeAssignDetail;
        }

        /// <summary>
        /// Gets the number of judge assign detail.
        /// </summary>
        /// <param name="numberOfJudgeAssignDetailEntity">The number of judge assign detail entity.</param>
        /// <returns></returns>
        public static NumberOfJudgeAssignDetailHistory GetNumberOfJudgeAssignDetailHistory(NumberOfJudgeAssignDetailHistoryEntity numberOfJudgeAssignDetailHistoryEntity)
        {
            NumberOfJudgeAssignDetailHistory numberOfJudgeAssignDetailHistory = null;

            try
            {
                if (numberOfJudgeAssignDetailHistoryEntity != null)
                {
                    numberOfJudgeAssignDetailHistory = Mapper.Map<NumberOfJudgeAssignDetailHistoryEntity, NumberOfJudgeAssignDetailHistory>(numberOfJudgeAssignDetailHistoryEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetNumberOfJudgeAssignDetailHistory", ex);
                throw;
            }

            return numberOfJudgeAssignDetailHistory;
        }

        /// <summary>
        /// Gets the report config task info.
        /// </summary>
        /// <param name="reportConfigTaskInfoEntity">The report config task info entity.</param>
        /// <returns></returns>
        public static ReportConfigTaskInfo GetReportConfigTaskInfo(ReportConfigTaskInfoEntity reportConfigTaskInfoEntity)
        {
            ReportConfigTaskInfo reportConfigTaskInfo = null;
            try
            {
                if (reportConfigTaskInfoEntity != null)
                {
                    reportConfigTaskInfo = Mapper.Map<ReportConfigTaskInfoEntity, ReportConfigTaskInfo>(reportConfigTaskInfoEntity);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetReportConfigTaskInfo", ex);
                throw;
            }
            return reportConfigTaskInfo;
        }

        /// <summary>
        /// Gets the number of judge assign detail.
        /// </summary>
        /// <param name="numberOfJudgeAssignDetailEntity">The number of judge assign detail entity.</param>
        /// <returns></returns>
        public static ArchiveNumberOfJudgeAssignDetail GetArchiveNumberOfJudgeAssignDetail(ArchiveNumberOfJudgeAssignDetailEntity archiveNumberOfJudgeAssignDetailEntity)
        {
            ArchiveNumberOfJudgeAssignDetail archiveNumberOfJudgeAssignDetail = null;

            try
            {
                if (archiveNumberOfJudgeAssignDetailEntity != null)
                {
                    archiveNumberOfJudgeAssignDetail = Mapper.Map<ArchiveNumberOfJudgeAssignDetailEntity, ArchiveNumberOfJudgeAssignDetail>(archiveNumberOfJudgeAssignDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetArchiveNumberOfJudgeAssignDetail", ex);
                throw;
            }

            return archiveNumberOfJudgeAssignDetail;
        }

        public static ArchiveNumberOfJudgeAssignDetailHistory GetArchiveNumberOfJudgeAssignDetailHistory(ArchiveNumberOfJudgeAssignDetailHistoryEntity archiveNumberOfJudgeAssignDetailHistoryEntity)
        {
            ArchiveNumberOfJudgeAssignDetailHistory archiveNumberOfJudgeAssignDetailHistory = null;

            try
            {
                if (archiveNumberOfJudgeAssignDetailHistoryEntity != null)
                {
                    archiveNumberOfJudgeAssignDetailHistory = Mapper.Map<ArchiveNumberOfJudgeAssignDetailHistoryEntity, ArchiveNumberOfJudgeAssignDetailHistory>(archiveNumberOfJudgeAssignDetailHistoryEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetArchiveNumberOfJudgeAssignDetailHistory", ex);
                throw;
            }

            return archiveNumberOfJudgeAssignDetailHistory;
        }

        public static ArchiveWorkitemDetails GetArchiveWorkitemDetails(ArchiveWorkitemDetailsEntity archiveWorkitemDetailsEntity)
        {
            ArchiveWorkitemDetails archiveWorkitemDetails = null;

            try
            {
                if (archiveWorkitemDetailsEntity != null)
                {
                    archiveWorkitemDetails = Mapper.Map<ArchiveWorkitemDetailsEntity, ArchiveWorkitemDetails>(archiveWorkitemDetailsEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetArchiveWorkitemDetails", ex);
                throw;
            }

            return archiveWorkitemDetails;
        }

        public static ArchiveWorkitemRecipient GetArchiveWorkitemRecipient(ArchiveBEWorkitemRecipientEntity archiveBEWorkitemRecipientEntity)
        {
            ArchiveWorkitemRecipient archiveWorkitemRecipient = null;

            try
            {
                if (archiveBEWorkitemRecipientEntity != null)
                {
                    archiveWorkitemRecipient = Mapper.Map<ArchiveBEWorkitemRecipientEntity, ArchiveWorkitemRecipient>(archiveBEWorkitemRecipientEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetArchiveWorkitemRecipient", ex);
                throw;
            }

            return archiveWorkitemRecipient;
        }

        public static CaseStatusRuleInfo GetCaseStatusRuleInfo(CaseStatusRuleInfoEntity caseStatusRuleInfoEntity)
        {
            CaseStatusRuleInfo caseStatusRuleInfo = null;

            try
            {
                if (caseStatusRuleInfoEntity != null)
                {
                    caseStatusRuleInfo = Mapper.Map<CaseStatusRuleInfoEntity, CaseStatusRuleInfo>(caseStatusRuleInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCaseStatusRuleInfo", ex);
                throw;
            }

            return caseStatusRuleInfo;
        }


        public static OGCProcessingInfo GetOGCProcessingInfo(OGCProcessingInfoEntity oGCProcessingInfoEntity)
        {
            OGCProcessingInfo oGCProcessingInfo = null;

            try
            {
                if (oGCProcessingInfoEntity != null)
                {
                    oGCProcessingInfo = Mapper.Map<OGCProcessingInfoEntity, OGCProcessingInfo>(oGCProcessingInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetOGCProcessingInfo", ex);
                throw;
            }

            return oGCProcessingInfo;
        }

        public static WorkflowOutgoingQueue GetWorkflowOutgoingQueue(WorkflowOutgoingQueueEntity workflowOutgoingQueueEntity)
        {
            WorkflowOutgoingQueue workflowOutgoingQueue = null;

            try
            {
                if (workflowOutgoingQueueEntity != null)
                {
                    workflowOutgoingQueue = Mapper.Map<WorkflowOutgoingQueueEntity, WorkflowOutgoingQueue>(workflowOutgoingQueueEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetWorkflowOutgoingQueue", ex);
                throw;
            }

            return workflowOutgoingQueue;
        }

        public static DutyJudgeAssignment GetDutyJudgeAssignment(DutyJudgeAssignmentEntity dutyJudgeAssignmentEntity)
        {
            DutyJudgeAssignment dutyJudgeAssignment = null;

            try
            {
                if (dutyJudgeAssignmentEntity != null)
                {
                    dutyJudgeAssignment = Mapper.Map<DutyJudgeAssignmentEntity, DutyJudgeAssignment>(dutyJudgeAssignmentEntity);
                    dutyJudgeAssignment.MForumType = Mapper.Map<MForumTypeEntity, MForumType>(dutyJudgeAssignmentEntity.MForumType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDutyJudgeAssignment", ex);
                throw;
            }

            return dutyJudgeAssignment;
        }

        public static UndoSerialNumber GetUndoSerialNumber(UndoSerialNumberEntity undoSerialNumberEntity)
        {
            UndoSerialNumber undoSerialNumber = null;

            try
            {
                if (undoSerialNumberEntity != null)
                {
                    undoSerialNumber = Mapper.Map<UndoSerialNumberEntity, UndoSerialNumber>(undoSerialNumberEntity);
                    
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetUndoSerialNumber", ex);
                throw;
            }

            return undoSerialNumber;
        }

        /// <summary>
        /// Gets the RPTNOC group NOC.
        /// </summary>
        /// <param name="rptNOCGroupNOCEntity">The RPT NOC group NOC entity.</param>
        /// <returns></returns>
        public static RPTNOCGroupNOC GetRPTNOCGroupNOC(RPTNOCGroupNOCEntity rptNOCGroupNOCEntity)
        {
            RPTNOCGroupNOC rptNOCGroupNOC = null;

            try
            {
                if (rptNOCGroupNOCEntity != null)
                {
                    rptNOCGroupNOC = Mapper.Map<RPTNOCGroupNOCEntity, RPTNOCGroupNOC>(rptNOCGroupNOCEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }

            return rptNOCGroupNOC;
        }

        /// <summary>
        /// Gets the RPT disposal KPI config.
        /// </summary>
        /// <param name="rptDisposalKPIConfigEntity">The RPT disposal KPI config entity.</param>
        /// <returns></returns>
        public static RPTDisposalKPIConfig GetRPTDisposalKPIConfig(RPTDisposalKPIConfigEntity rptDisposalKPIConfigEntity)
        {
            RPTDisposalKPIConfig rptDisposalKPIConfig = null;

            try
            {
                if (rptDisposalKPIConfigEntity != null)
                {
                    rptDisposalKPIConfig = Mapper.Map<RPTDisposalKPIConfigEntity, RPTDisposalKPIConfig>(rptDisposalKPIConfigEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }

            return rptDisposalKPIConfig;
        }


        /// <summary>
        /// Gets the RPTNOC group entity.
        /// </summary>
        /// <param name="rptNOCGroupEntity">The RPT NOC group entity.</param>
        /// <returns></returns>
        public static RPTNOCGroup GetRPTNOCGroupEntity(RPTNOCGroupEntity rptNOCGroupEntity)
        {
            RPTNOCGroup rptNOCGroup = null;

            try
            {
                if (rptNOCGroupEntity != null)
                {
                    rptNOCGroup = Mapper.Map<RPTNOCGroupEntity, RPTNOCGroup>(rptNOCGroupEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format(@"Error encountered at {0}", System.Reflection.MethodBase.GetCurrentMethod().Name), ex);
                throw;
            }

            return rptNOCGroup;
        }
        #endregion Methods
    }
}