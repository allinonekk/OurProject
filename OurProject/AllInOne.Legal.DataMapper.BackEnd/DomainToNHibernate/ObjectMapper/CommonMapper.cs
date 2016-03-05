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
*   23/09/2010   		      Nai                	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CommonMapper.cs
// Description: This file represents a object mapper Common entities. This class will map Object to
// Entity.
// </summary>
// <copyright file= "CommonMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// 
    /// </summary>
    public class CommonMapper
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(CommonMapper));

        private static CommonMapping commonMapping = new CommonMapping();

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the affidavit deponent detail.
        /// </summary>
        /// <param name="affidavitDeponentDetailEntity">The affidavit deponent detail entity.</param>
        /// <returns></returns>
        public static AffidavitDeponentDetail GetAffidavitDeponentDetail(AffidavitDeponentDetailEntity affidavitDeponentDetailEntity)
        {
            AffidavitDeponentDetail affidavitDeponentDetail = new AffidavitDeponentDetail();
            try
            {
                affidavitDeponentDetail = Mapper.Map<AffidavitDeponentDetailEntity, AffidavitDeponentDetail>(affidavitDeponentDetailEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAffidavitDeponentDetail", ex);
                throw;
            }
            return affidavitDeponentDetail;
        }

        /// <summary>
        /// Gets the affidavit info.
        /// </summary>
        /// <param name="affidavitInfoEntity">The affidavit info entity.</param>
        /// <returns></returns>
        public static AffidavitInfo GetAffidavitInfo(AffidavitInfoEntity affidavitInfoEntity)
        {
            AffidavitInfo affidavitInfo = new AffidavitInfo();
            try
            {
                affidavitInfo = Mapper.Map<AffidavitInfoEntity, AffidavitInfo>(affidavitInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAffidavitInfo", ex);
                throw;
            }
            return affidavitInfo;
        }

        /// <summary>
        /// Gets the <see cref="BillOfSaleSubInfo"/> from <see cref="BillOfSaleSubInfoEntity"/> input.
        /// </summary>
        /// <param name="billOfSaleSubInfoEntity"><see cref="BillOfSaleSubInfoEntity"/></param>
        /// <returns>Returns <see cref="BillOfSaleSubInfo"/>, else null.</returns>
        public static BillOfSaleSubInfo GetBillOfSaleSubInfo(BillOfSaleSubInfoEntity billOfSaleSubInfoEntity)
        {
            BillOfSaleSubInfo billOfSaleSubInfo = null;

            try
            {
                if (billOfSaleSubInfoEntity != null)
                {
                    billOfSaleSubInfo = Mapper.Map<BillOfSaleSubInfoEntity, BillOfSaleSubInfo>(billOfSaleSubInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBillOfSaleSubInfo", ex);
                throw;
            }

            return billOfSaleSubInfo;
        }

        /// <summary>
        /// Gets the <see cref="BTSRoutingQueue"/>
        /// </summary>
        /// <param name="bTSRoutingQueueEntity">The bTSRoutingQueueEntity.</param>
        /// <returns></returns>
        public static BTSRoutingQueue GetBTSRoutingQueue(BTSRoutingQueueEntity bTSRoutingQueueEntity)
        {
            BTSRoutingQueue bTSRoutingQueue = null;
            try
            {
                bTSRoutingQueue = Mapper.Map<BTSRoutingQueueEntity, BTSRoutingQueue>(bTSRoutingQueueEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBTSRoutingQueue", ex);
                throw;
            }
            return bTSRoutingQueue;
        }

        /// <summary>
        /// Gets the <see cref="CertSecurityOfCostsInfo"/> from <see cref="CertSecurityOfCostsInfoEntity"/> input.
        /// </summary>
        /// <param name="certSecurityOfCostsInfoEntity"><see cref="CertSecurityOfCostsInfoEntity"/></param>
        /// <returns>Returns <see cref="CertSecurityOfCostsInfo"/>, else null.</returns>
        public static CertSecurityOfCostsInfo GetCertSecurityOfCostsInfo(CertSecurityOfCostsInfoEntity certSecurityOfCostsInfoEntity)
        {
            CertSecurityOfCostsInfo certSecurityOfCostsInfo = null;

            try
            {
                if (certSecurityOfCostsInfoEntity != null)
                {
                    certSecurityOfCostsInfo = Mapper.Map<CertSecurityOfCostsInfoEntity, CertSecurityOfCostsInfo>(certSecurityOfCostsInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCertSecurityOfCostsInfo", ex);
                throw;
            }

            return certSecurityOfCostsInfo;
        }

        /// <summary>
        /// Gets the checklist instance.
        /// </summary>
        /// <param name="checklistInstanceEntity">The checklist instance entity.</param>
        /// <returns></returns>
        public static CheckListInstance GetChecklistInstance(ChecklistInstanceEntity checklistInstanceEntity)
        {
            CheckListInstance checklistInstance = null;

            try
            {
                checklistInstance = Mapper.Map<ChecklistInstanceEntity, CheckListInstance>(checklistInstanceEntity);
                checklistInstance.MChecklist = Mapper.Map<MChecklistEntity, MChecklist>(checklistInstanceEntity.MChecklist);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetChecklistInstance", ex);
                throw;
            }

            return checklistInstance;
        }

        public static CheckListSubmission GetChecklistSubmission(ChecklistSubmissionEntity checklistSubmissionEntity)
        {
            CheckListSubmission checklistSubmission = null;
            try
            {
                checklistSubmission = Mapper.Map<ChecklistSubmissionEntity, CheckListSubmission>(checklistSubmissionEntity);
                checklistSubmission.MDocCode = Mapper.Map<MDocCodeEntity, MDocCode>(checklistSubmissionEntity.MDocCode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetChecklistSubmission", ex);
                throw;
            }
            return checklistSubmission;
        }

        /// <summary>
        /// Gets the <see cref="ChildInfo"/> from <see cref="ChildInfoEntity"/> input.
        /// </summary>
        /// <param name="childInfoEntity"><see cref="ChildInfoEntity"/></param>
        /// <returns>Returns <see cref="ChildInfo"/>, else null.</returns>
        public static ChildInfo GetChildInfo(ChildInfoEntity childInfoEntity)
        {
            ChildInfo childInfo = null;

            try
            {
                if (childInfoEntity != null)
                {
                    childInfo = Mapper.Map<ChildInfoEntity, ChildInfo>(childInfoEntity);
                    childInfo.MOccupation = Mapper.Map<MOccupationEntity, MOccupation>(childInfoEntity.MOccupation);
                    childInfo.MPersonIDType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(childInfoEntity.MPersonIdType);
                    childInfo.MQualification = Mapper.Map<MQualificationEntity, MQualification>(childInfoEntity.MQualification);
                    childInfo.MRace = Mapper.Map<MRaceEntity, MRace>(childInfoEntity.MRace);
                    childInfo.MReligion = Mapper.Map<MReligionEntity, MReligion>(childInfoEntity.MReligion);
                    childInfo.MCountry = Mapper.Map<MCountryEntity, MCountry>(childInfoEntity.IdCountry);
                    childInfo.MGender = Mapper.Map<MGenderEntity, MGender>(childInfoEntity.Gender);
                    childInfo.MMaritalStatus = Mapper.Map<MMaritalStatusEntity, MMaritalStatus>(childInfoEntity.MaritalStatus);
                    childInfo.MNationality = Mapper.Map<MNationalityEntity, MNationality>(childInfoEntity.Nationality);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetChildInfo", ex);
                throw;
            }

            return childInfo;
        }

        /// <summary>
        /// Gets the common entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="commonEntity">The common entity.</param>
        /// <returns></returns>
        public static ICommon GetCommonEntity<T>(T commonEntity)
        {
            if (commonEntity.GetType().Equals(typeof(BTSRoutingQueueEntity)))
                return CommonMapper.GetBTSRoutingQueue(commonEntity as BTSRoutingQueueEntity);

            else if (commonEntity.GetType().Equals(typeof(WOECaseExecutionAddressEntity)))
                return CommonMapper.GetWOECaseExecutionAddress(commonEntity as WOECaseExecutionAddressEntity);

            else if (commonEntity.GetType().Equals(typeof(CertSecurityOfCostsInfoEntity)))
                return CommonMapper.GetCertSecurityOfCostsInfo(commonEntity as CertSecurityOfCostsInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(DivorceInfoEntity)))
                return CommonMapper.GetDivorceInfo(commonEntity as DivorceInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(DocAppProcessByExAgencyEntity)))
                return CommonMapper.GetDocAppProcessByExAgency(commonEntity as DocAppProcessByExAgencyEntity);

               //else if (commonEntity.GetType().Equals(typeof(PaymentHRGDatesDocDetailEntity)))
            //    return (CommonMapper.GetPaymentHRGDatesDocDetail(commonEntity as PaymentHRGDatesDocDetailEntity));

            else if (commonEntity.GetType().Equals(typeof(ChildInfoEntity)))
                return CommonMapper.GetChildInfo(commonEntity as ChildInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(RelatedProceedingEntity)))
                return CommonMapper.GetRelatedProceeding(commonEntity as RelatedProceedingEntity);

            else if (commonEntity.GetType().Equals(typeof(GroundInfoEntity)))
                return CommonMapper.GetGroundInfo(commonEntity as GroundInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(PrayerEntity)))
                return CommonMapper.GetPrayer(commonEntity as PrayerEntity);

            else if (commonEntity.GetType().Equals(typeof(ChecklistInstanceEntity)))
                return CommonMapper.GetChecklistInstance(commonEntity as ChecklistInstanceEntity);

            else if (commonEntity.GetType().Equals(typeof(ChecklistSubmissionEntity)))
                return CommonMapper.GetChecklistSubmission(commonEntity as ChecklistSubmissionEntity);

            else if (commonEntity.GetType().Equals(typeof(AffidavitDeponentDetailEntity)))
                return CommonMapper.GetAffidavitDeponentDetail(commonEntity as AffidavitDeponentDetailEntity);

            //else if (commonEntity.GetType().Equals(typeof(ADMBBDefInfoEntity)))
            //    return CommonMapper.GetADMBBDefInfo(commonEntity as ADMBBDefInfoEntity);//TODO:Nithin

            else if (commonEntity.GetType().Equals(typeof(AffidavitInfoEntity)))
                return CommonMapper.GetAffidavitInfo(commonEntity as AffidavitInfoEntity);

            //else if (commonEntity.GetType().Equals(typeof(ADMBBSecInfoEntity)))
            //    return CommonMapper.GetADMBBSecInfo(commonEntity as ADMBBSecInfoEntity);//TODI:Nithin

            //else if (commonEntity.GetType().Equals(typeof(ADMRSVCBBInfoEntity)))
            //    return CommonMapper.GetADMRSVCBBInfo(commonEntity as ADMRSVCBBInfoEntity);//TODI:Nithin

            else if (commonEntity.GetType().Equals(typeof(BillOfSaleSubInfoEntity)))
                return CommonMapper.GetBillOfSaleSubInfo(commonEntity as BillOfSaleSubInfoEntity);//TODI:Nithin

            else if (commonEntity.GetType().Equals(typeof(FilingFeeDetailEntity)))
                return CommonMapper.GetFilingFeeDetail(commonEntity as FilingFeeDetailEntity);

            else if (commonEntity.GetType().Equals(typeof(LegislationProvisionsEntity)))
                return CommonMapper.GetLegislationProvision(commonEntity as LegislationProvisionsEntity);

            else if (commonEntity.GetType().Equals(typeof(LiquidatedClaimEntity)))
                return CommonMapper.GetLiquidatedClaim(commonEntity as LiquidatedClaimEntity);

            else if (commonEntity.GetType().Equals(typeof(LiquidatorEntity)))
                return CommonMapper.GetLiquidator(commonEntity as LiquidatorEntity);

            else if (commonEntity.GetType().Equals(typeof(LiquidatorPICAddressEntity)))
                return CommonMapper.GetLiquidatorPICAddress(commonEntity as LiquidatorPICAddressEntity);

            else if (commonEntity.GetType().Equals(typeof(LiquidatorAddressEntity)))
                return CommonMapper.GetLiquidatorAddress(commonEntity as LiquidatorAddressEntity);

            else if (commonEntity.GetType().Equals(typeof(LiquidatorAliasEntity)))
                return CommonMapper.GetLiquidatorAlias(commonEntity as LiquidatorAliasEntity);

            else if (commonEntity.GetType().Equals(typeof(LiquidatorPICEntity)))
                return CommonMapper.GetLiquidatorPIC(commonEntity as LiquidatorPICEntity);

            else if (commonEntity.GetType().Equals(typeof(LiquidatorPICAliasEntity)))
                return CommonMapper.GetLiquidatorPICAlias(commonEntity as LiquidatorPICAliasEntity);

            //else if (commonEntity.GetType().Equals(typeof(MailboxEntity)))
            //    return CommonMapper.GetMailbox(commonEntity as MailboxEntity);//TODO:Nithin

            else if (commonEntity.GetType().Equals(typeof(NatureOfCaseEntity)))
                return CommonMapper.GetNatureOfCase(commonEntity as NatureOfCaseEntity);

            //else if (commonEntity.GetType().Equals(typeof(NoOfSupportingDocEntity)))
            //    return CommonMapper.GetNoOfSupportingDoc(commonEntity as NoOfSupportingDocEntity);

            else if (commonEntity.GetType().Equals(typeof(OriginatingCaseEntity)))
                return CommonMapper.GetOriginatingCase(commonEntity as OriginatingCaseEntity);

            else if (commonEntity.GetType().Equals(typeof(OtherITMOEntity)))
                return CommonMapper.GetOtherITMO(commonEntity as OtherITMOEntity);

            else if (commonEntity.GetType().Equals(typeof(OtherReliefsClaimEntity)))
                return CommonMapper.GetOtherReliefsClaim(commonEntity as OtherReliefsClaimEntity);

            else if (commonEntity.GetType().Equals(typeof(RefOrderDetailEntity)))
                return CommonMapper.GetRefOrderDetail(commonEntity as RefOrderDetailEntity);

            else if (commonEntity.GetType().Equals(typeof(RefSubCaseEntity)))
                return CommonMapper.GetRefSubCase(commonEntity as RefSubCaseEntity);

            else if (commonEntity.GetType().Equals(typeof(RelatedProceedingEntity)))
                return CommonMapper.GetRelatedProceeding(commonEntity as RelatedProceedingEntity);//TODO:Nithin

            else if (commonEntity.GetType().Equals(typeof(UnliquidatedClaimEntity)))
                return CommonMapper.GetUnliquidatedClaim(commonEntity as UnliquidatedClaimEntity);

            else if (commonEntity.GetType().Equals(typeof(SubmissionInfoEntity)))
                return CommonMapper.GetSubmissionInfo(commonEntity as SubmissionInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(NatureOfApplicationEntity)))
                return CommonMapper.GetNatureOfApplication(commonEntity as NatureOfApplicationEntity);

            else if (commonEntity.GetType().Equals(typeof(NotPaymenttoCourtDocDetailEntity)))
                return CommonMapper.GetNotPaymentToCourtDocDetail(commonEntity as NotPaymenttoCourtDocDetailEntity);

            else if (commonEntity.GetType().Equals(typeof(DegreeInfoEntity)))
                return GetDegreeInfo(commonEntity as DegreeInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(LegalExperienceInfoEntity)))
                return GetLegalExperienceInfo(commonEntity as LegalExperienceInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(WOEExecutionAddressEntity)))
                return GetWOEExecutionAddress(commonEntity as WOEExecutionAddressEntity);

            else if (commonEntity.GetType().Equals(typeof(MinuteSheetInfoEntity)))
                return GetMinuteSheetInfo(commonEntity as MinuteSheetInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(MinuteSheetDocListEntity)))
                return GetMinuteSheetDocList(commonEntity as MinuteSheetDocListEntity);

            else if (commonEntity.GetType().Equals(typeof(MinuteSheetPartyRepInfoEntity)))
                return GetMinuteSheetPartyRepInfo(commonEntity as MinuteSheetPartyRepInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(MinuteSheetPartySolicitorInfoEntity)))
                return GetMinuteSheetPartySolicitorInfo(commonEntity as MinuteSheetPartySolicitorInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(MinuteSheetFamilyRelatedInfoEntity)))
                return GetMinuteSheetFamilyRelatedInfo(commonEntity as MinuteSheetFamilyRelatedInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(MinuteSheetGroundInfoEntity)))
                return GetMinuteSheetGroundInfo(commonEntity as MinuteSheetGroundInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(OrdersMadeEntity)))
                return GetOrdersMade(commonEntity as OrdersMadeEntity);

            else if (commonEntity.GetType().Equals(typeof(AppealTimeEstimationDetailEntity)))
                return GetAppealTimeEstimationDetail(commonEntity as AppealTimeEstimationDetailEntity);

            else if (commonEntity.GetType().Equals(typeof(NoticeToReferAffidavitEntity)))
                return GetNoticeToReferAffidavit(commonEntity as NoticeToReferAffidavitEntity);

            else if (commonEntity.GetType().Equals(typeof(PrintDocumentQueueEntity)))
                return GetPrintDocumentQueue(commonEntity as PrintDocumentQueueEntity);

            else if (commonEntity.GetType().Equals(typeof(PrintDocumentQueueDetailEntity)))
                return GetPrintDocumentQueueDetail(commonEntity as PrintDocumentQueueDetailEntity);

            else if (commonEntity.GetType().Equals(typeof(ClaimAmountEntity)))
                return GetClaimAmount(commonEntity as ClaimAmountEntity);

            else if (commonEntity.GetType().Equals(typeof(RespondentCaseDetailInfoEntity)))
                return GetRespondentCaseDetailInfo(commonEntity as RespondentCaseDetailInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(CheckListCommentEntity)))
                return GetCheckListComments(commonEntity as CheckListCommentEntity);

            else if (commonEntity.GetType().Equals(typeof(RefOrderJOInfoEntity)))
                return GetRefOrderJOInfo(commonEntity as RefOrderJOInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(ForeignLPSolicitorRegEntity)))
                return GetForeignLPSolicitorReg(commonEntity as ForeignLPSolicitorRegEntity);

            else if (commonEntity.GetType().Equals(typeof(InterfaceNBSReportEntity)))
                return GetInterfaceNBSReport(commonEntity as InterfaceNBSReportEntity);

            else if (commonEntity.GetType().Equals(typeof(ReqExaminationFeeDetailEntity)))
                return GetReqExaminationFeedetail(commonEntity as ReqExaminationFeeDetailEntity);

            else if (commonEntity.GetType().Equals(typeof(ForeignUserRegAddressDetailsEntity)))
                return GetForeignUserRegAddressDetails(commonEntity as ForeignUserRegAddressDetailsEntity);

            else if (commonEntity.GetType().Equals(typeof(ForeignUserPracticeInformationEntity)))
                return GetForeignUserPracticeInformation(commonEntity as ForeignUserPracticeInformationEntity);

            else if (commonEntity.GetType().Equals(typeof(RegistrationOfForeignLawyerEntity)))
                return GetRegistrationOfForeignLawyer(commonEntity as RegistrationOfForeignLawyerEntity);

            else if (commonEntity.GetType().Equals(typeof(RFLValidityAndNotificationEntity)))
                return GetRFLValidityAndNotification(commonEntity as RFLValidityAndNotificationEntity);

            else if (commonEntity.GetType().Equals(typeof(SICCFeeLedgerEntity)))
                return GetSICCFeeLedger(commonEntity as SICCFeeLedgerEntity);

            else if (commonEntity.GetType().Equals(typeof(SystemParametersEntity)))
                return GetSystemParameters(commonEntity as SystemParametersEntity);

            else if (commonEntity.GetType().Equals(typeof(RequestForExemptionEntity)))
                return GetRequestForExemption(commonEntity as RequestForExemptionEntity);

            else if (commonEntity.GetType().Equals(typeof(PCAppDatesFromSALEntity)))
                return GetPCAppDatesFromSAL(commonEntity as PCAppDatesFromSALEntity);

            else if (commonEntity.GetType().Equals(typeof(FeeCollectionDetailEntity)))
                return GetFeeCollectionDetail(commonEntity as FeeCollectionDetailEntity);

            else if (commonEntity.GetType().Equals(typeof(OutgoingCorrespondenceInfoEntity)))
                return GetOutgoingCorrespondenceInfo(commonEntity as OutgoingCorrespondenceInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(OutgoingCorrespondenceCourtFeeEntity)))
                return GetOutgoingCorrespondenceCourtFee(commonEntity as OutgoingCorrespondenceCourtFeeEntity);

            else if (commonEntity.GetType().Equals(typeof(LawFirmRegistrationEntity)))
                return GetLawFirmRegistration(commonEntity as LawFirmRegistrationEntity);

            else if (commonEntity.GetType().Equals(typeof(DocLegalExperienceInfoEntity)))
                return GetDocLegalExperienceInfo(commonEntity as DocLegalExperienceInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(CaseLegalExperienceInfoEntity)))
                return GetCaseLegalExperienceInfo(commonEntity as CaseLegalExperienceInfoEntity);

            else if (commonEntity.GetType().Equals(typeof(CORSolicitorRegEntity)))
                return GetCORSolicitorReg(commonEntity as CORSolicitorRegEntity);

            else if (commonEntity.GetType().Equals(typeof(CORSolicitorRegDetailsEntity)))
                return GetCORSolicitorRegDetails(commonEntity as CORSolicitorRegDetailsEntity);

            else if (commonEntity.GetType().Equals(typeof(DocCaseCounterClaimDetailsEntity)))
                return GetDocCaseCounterClaimDetails(commonEntity as DocCaseCounterClaimDetailsEntity);

            else if (commonEntity.GetType().Equals(typeof(DocCaseCounterClaimEntity)))
                return GetDocCaseCounterClaim(commonEntity as DocCaseCounterClaimEntity);

            else if (commonEntity.GetType().Equals(typeof(CaseCounterClaimEntity)))
                return GetCaseCounterClaim(commonEntity as CaseCounterClaimEntity);

            else if (commonEntity.GetType().Equals(typeof(CaseCounterClaimDetailsEntity)))
                return GetCaseCounterClaimDetails(commonEntity as CaseCounterClaimDetailsEntity);

            else
                throw new ArgumentNullException("Invalid object sent.");
        }

        /// <summary>
        /// Gets the <see cref="DeceasedAlias"/>
        /// </summary>
        /// <param name="deceasedAliasEntity">The DeceasedAliasEntity.</param>
        /// <returns></returns>
        public static DeceasedAlias GetDeceasedAlias(DeceasedAliasEntity deceasedAliasEntity)
        {
            DeceasedAlias deceasedAlias = null;
            try
            {
                deceasedAlias = Mapper.Map<DeceasedAliasEntity, DeceasedAlias>(deceasedAliasEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDeceasedAlias", ex);
                throw;
            }
            return deceasedAlias;
        }

        /// <summary>
        /// Gets the <see cref="DeceasedIdentification"/>
        /// </summary>
        /// <param name="deceasedAliasEntity">The DeceasedAliasEntity.</param>
        /// <returns></returns>
        public static DeceasedIdentification GetDeceasedIdentification(DeceasedIdentificationsEntity deceasedIdentificationsEntity)
        {
            DeceasedIdentification deceasedIdentification = null;
            try
            {
                deceasedIdentification = Mapper.Map<DeceasedIdentificationsEntity, DeceasedIdentification>(deceasedIdentificationsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDeceasedIdentification", ex);
                throw;
            }
            return deceasedIdentification;
        }

        /// <summary>
        /// Gets the <see cref="DeceasedInfo"/>
        /// </summary>
        /// <param name="deceasedInfoEntity">The DeceasedInfoEntity.</param>
        /// <returns></returns>
        public static DeceasedInfo GetDeceasedInfo(DeceasedInfoEntity deceasedInfoEntity)
        {
            DeceasedInfo deceasedInfo = null;
            try
            {
                deceasedInfo = Mapper.Map<DeceasedInfoEntity, DeceasedInfo>(deceasedInfoEntity);
                deceasedInfo.MCountry = Mapper.Map<MCountryEntity, MCountry>(deceasedInfoEntity.MCountry);
                deceasedInfo.MDomicileCountry = Mapper.Map<MCountryEntity, MCountry>(deceasedInfoEntity.MDomicileCountry);
                deceasedInfo.MGender = Mapper.Map<MGenderEntity, MGender>(deceasedInfoEntity.MGender);
                deceasedInfo.MMaritalStatus = Mapper.Map<MMaritalStatusEntity, MMaritalStatus>(deceasedInfoEntity.MMaritalStatus);
                deceasedInfo.MNationality = Mapper.Map<MNationalityEntity, MNationality>(deceasedInfoEntity.MNationality);
                deceasedInfo.MPersonIDGroup = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(deceasedInfoEntity.MPersonIdGroup);
                deceasedInfo.MReligion = Mapper.Map<MReligionEntity, MReligion>(deceasedInfoEntity.MReligion);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDeceasedInfo", ex);
                throw;
            }
            return deceasedInfo;
        }

        /// <summary>
        /// Gets the <see cref="AASStatingObjOrNoObjDetail"/>
        /// </summary>
        /// <param name="aASStatingObjOrNoObjDetailEntity">The AASStatingObjOrNoObjDetailEntity.</param>
        /// <returns></returns>
        public static DegreeInfo GetDegreeInfo(DegreeInfoEntity degreeInfoEntity)
        {
            DegreeInfo degreeInfo = null;
            try
            {
                degreeInfo = Mapper.Map<DegreeInfoEntity, DegreeInfo>(degreeInfoEntity);
                degreeInfo.MAASLawDegree = Mapper.Map<MAASLawDegreeEntity, MAASLawDegree>(degreeInfoEntity.MAASLawDegree);
                degreeInfo.MAASUniversity = Mapper.Map<MAASUniversityEntity, MAASUniversity>(degreeInfoEntity.MAASUniversity);
                degreeInfo.MCountry = Mapper.Map<MCountryEntity, MCountry>(degreeInfoEntity.MCountry);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDegreeInfo", ex);
                throw;
            }
            return degreeInfo;
        }

        /// <summary>
        /// Gets the divorce info.
        /// </summary>
        /// <param name="divorceInfoEntity">The divorce info entity.</param>
        /// <returns></returns>
        public static DivorceInfo GetDivorceInfo(DivorceInfoEntity divorceInfoEntity)
        {
            DivorceInfo divorceInfo = null;
            try
            {
                divorceInfo = Mapper.Map<DivorceInfoEntity, DivorceInfo>(divorceInfoEntity);
                divorceInfo.MCountryPlaceOfMarriage = Mapper.Map<MCountryEntity, MCountry>(divorceInfoEntity.PlaceOfMarriage);
                divorceInfo.MCountryPlaceOfSolemnization = Mapper.Map<MCountryEntity, MCountry>(divorceInfoEntity.PlaceOfSolemnization);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDivorceInfo", ex);
                throw;
            }
            return divorceInfo;
        }

        /// <summary>
        /// Gets the <see cref="DocAppProcessByExAgency"/> from <see cref="docAppProcessByExAgencyEntity"/> input.
        /// </summary>
        /// <param name="docAppProcessByExAgencyEntity"><see cref="docAppProcessByExAgencyEntity"/></param>
        /// <returns>Returns <see cref="DocAppProcessByExAgency"/>, else null.</returns>
        public static DocAppProcessByExAgency GetDocAppProcessByExAgency(DocAppProcessByExAgencyEntity docAppProcessByExAgencyEntity)
        {
            DocAppProcessByExAgency docAppProcessByExAgency = null;

            try
            {
                if (docAppProcessByExAgencyEntity != null)
                {
                    docAppProcessByExAgency = Mapper.Map<DocAppProcessByExAgencyEntity, DocAppProcessByExAgency>(docAppProcessByExAgencyEntity);
                    docAppProcessByExAgency.MDocStatus = Mapper.Map<MDocStatusEntity, MDocStatus>(docAppProcessByExAgencyEntity.MDocStatus);
                    docAppProcessByExAgency.MExternalAgency = Mapper.Map<MExternalAgencyEntity, MExternalAgency>(docAppProcessByExAgencyEntity.MExternalAgency);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDocAppProcessByExAgency", ex);
                throw;
            }

            return docAppProcessByExAgency;
        }

        /// <summary>
        /// Gets the <see cref="EmploymentInfo"/> from <see cref="employmentInfoEntity"/> input.
        /// </summary>
        /// <param name="employmentInfoEntity"><see cref="employmentInfoEntity"/></param>
        /// <returns>Returns <see cref="EmploymentInfo"/>, else null.</returns>
        public static EmploymentInfo GetEmploymentInfo(EmploymentInfoEntity employmentInfoEntity)
        {
            EmploymentInfo employmentInfo = null;

            try
            {
                if (employmentInfoEntity != null)
                {
                    employmentInfo = Mapper.Map<EmploymentInfoEntity, EmploymentInfo>(employmentInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetEmploymentInfo", ex);
                throw;
            }

            return employmentInfo;
        }

        /// <summary>
        /// Gets the <see cref="FilingFeeDetail"/> from <see cref="FilingFeeDetailEntity"/> input.
        /// </summary>
        /// <param name="FilingFeeDetailEntity"><see cref="FilingFeeDetailEntity"/></param>
        /// <returns>Returns <see cref="FilingFeeDetail"/>, else null.</returns>
        public static FilingFeeDetail GetFilingFeeDetail(FilingFeeDetailEntity filingFeeDetailEntity)
        {
            FilingFeeDetail filingFeeDetail = null;

            try
            {
                if (filingFeeDetailEntity != null)
                {
                    filingFeeDetail = Mapper.Map<FilingFeeDetailEntity, FilingFeeDetail>(filingFeeDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetfilingFeeDetail", ex);
                throw;
            }

            return filingFeeDetail;
        }

        /// <summary>
        /// Gets the <see cref="ForeignLawPracticeReg"/> from <see cref="foreignLawPracticeRegEntity"/> input.
        /// </summary>
        /// <param name="foreignLawPracticeRegEntity"><see cref="foreignLawPracticeRegEntity"/></param>
        /// <returns>Returns <see cref="ForeignLawPracticeReg"/>, else null.</returns>
        public static ForeignLPSolicitorRegDetail GetForeignLPSolicitorRegDetail(ForeignLPSolicitorRegDetailEntity foreignLPSolicitorRegDetailEntity)
        {
            ForeignLPSolicitorRegDetail foreignLPSolicitorRegDetail = null;

            try
            {
                if (foreignLPSolicitorRegDetailEntity != null)
                {
                    foreignLPSolicitorRegDetail = Mapper.Map<ForeignLPSolicitorRegDetailEntity, ForeignLPSolicitorRegDetail>(foreignLPSolicitorRegDetailEntity);
                    foreignLPSolicitorRegDetail.MLawPracticeType = Mapper.Map<MLawPracticeTypeEntity, MLawPracticeType>(foreignLPSolicitorRegDetailEntity.MLawPracticeType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetForeignLPSolicitorRegDetail", ex);
                throw;
            }

            return foreignLPSolicitorRegDetail;
        }

        /// <summary>
        /// Gets the <see cref="GroundInfo"/> from <see cref="GroundInfoEntity"/> input.
        /// </summary>
        /// <param name="groundInfoEntity"><see cref="GroundInfoEntity"/></param>
        /// <returns>Returns <see cref="GroundInfo"/>, else null.</returns>
        public static GroundInfo GetGroundInfo(GroundInfoEntity groundInfoEntity)
        {
            GroundInfo groundInfo = null;

            try
            {
                if (groundInfoEntity != null)
                {
                    groundInfo = Mapper.Map<GroundInfoEntity, GroundInfo>(groundInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetGroundInfo", ex);
                throw;
            }

            return groundInfo;
        }

        /// <summary>
        /// Gets the <see cref="InfantInfo"/>
        /// </summary>
        /// <param name="infantInfoEntity">The InfantInfoEntity.</param>
        /// <returns></returns>
        public static InfantInfo GetInfantInfo(InfantInfoEntity infantInfoEntity)
        {
            InfantInfo infantInfo = null;
            try
            {
                infantInfo = Mapper.Map<InfantInfoEntity, InfantInfo>(infantInfoEntity);
                infantInfo.MBirthCountry = Mapper.Map<MCountryEntity, MCountry>(infantInfoEntity.BirthCountry);
                infantInfo.MCountry = Mapper.Map<MCountryEntity, MCountry>(infantInfoEntity.MCountry);
                infantInfo.MGender = Mapper.Map<MGenderEntity, MGender>(infantInfoEntity.MGender);
                infantInfo.MNationality = Mapper.Map<MNationalityEntity, MNationality>(infantInfoEntity.MNationality);
                infantInfo.MRace = Mapper.Map<MRaceEntity, MRace>(infantInfoEntity.MRace);
                infantInfo.MResidenceCountry = Mapper.Map<MCountryEntity, MCountry>(infantInfoEntity.ResidenceCountry);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetInfantInfo", ex);
                throw;
            }
            return infantInfo;
        }

        /// <summary>
        /// Gets the <see cref="LegalExperienceInfo"/>
        /// </summary>
        /// <param name="legalExperienceInfoEntity">The LegalExperienceInfoEntity.</param>
        /// <returns></returns>
        public static LegalExperienceInfo GetLegalExperienceInfo(LegalExperienceInfoEntity legalExperienceInfoEntity)
        {
            LegalExperienceInfo legalExperienceInfo = null;
            try
            {
                legalExperienceInfo = Mapper.Map<LegalExperienceInfoEntity, LegalExperienceInfo>(legalExperienceInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetLegalExperienceInfo", ex);
                throw;
            }
            return legalExperienceInfo;
        }

        public static LegislationProvision GetLegislationProvision(LegislationProvisionsEntity legislationProvisionsEntity)
        {
            LegislationProvision legislationProvision = null;

            try
            {
                //commonMapping.MapLegislationProvisionEntityToLegislationProvision();
                legislationProvision = Mapper.Map<LegislationProvisionsEntity, LegislationProvision>(legislationProvisionsEntity);
                legislationProvision.MProvision = Mapper.Map<MProvisionEntity, MProvision>(legislationProvisionsEntity.MProvision);
                legislationProvision.MLegislationAct = Mapper.Map<MLegislationActEntity, MLegislationAct>(legislationProvisionsEntity.MLegislationAct);
                legislationProvision.MSubProvision = Mapper.Map<MSubProvisionEntity, MSubProvision>(legislationProvisionsEntity.MSubProvision);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLegislationProvision", ex);
                throw;
            }

            return legislationProvision;
        }

        /// <summary>
        /// Get the Liquidated Claim Domain Entity.
        /// </summary>
        /// <param name="LiquidatedClaimDomainEntity"></param>
        /// <returns></returns>
        public static LiquidatedClaim GetLiquidatedClaim(LiquidatedClaimEntity liquidatedClaimDomainEntity)
        {
            LiquidatedClaim liquidatedClaimNHibernateEntity = null;

            try
            {

                liquidatedClaimNHibernateEntity = Mapper.Map<LiquidatedClaimEntity, LiquidatedClaim>(liquidatedClaimDomainEntity);
                //liquidatedClaimNHibernateEntity.MCurrency = Mapper.Map<MCurrencyEntity, MCurrency>(liquidatedClaimDomainEntity.MCurrency);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetLiquidatedClaim", ex);
                throw;
            }

            return liquidatedClaimNHibernateEntity;
        }

        public static Liquidator GetLiquidator(LiquidatorEntity liquidatorEntity)
        {
            Liquidator liquidator = null;

            try
            {
                liquidator = Mapper.Map<LiquidatorEntity, Liquidator>(liquidatorEntity);
                liquidator.MEntityType = Mapper.Map<MEntityTypeEntity, MEntityType>(liquidatorEntity.MEntityType);
                liquidator.MGender = Mapper.Map<MGenderEntity, MGender>(liquidatorEntity.MGender);
                liquidator.MLCompanyIdType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(liquidatorEntity.MCompanyIdType);
                liquidator.MLIdCountryOfRegistration = Mapper.Map<MCountryEntity, MCountry>(liquidatorEntity.MCountryOfRegistration);
                liquidator.MLIdCountry = Mapper.Map<MCountryEntity, MCountry>(liquidatorEntity.MIdCountry);
                liquidator.MLPersonIdType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(liquidatorEntity.MPersonIdType);
                liquidator.MPersonIDGroup = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(liquidatorEntity.MPersonIdGroup);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLiquidator", ex);
                throw;
            }

            return liquidator;
        }

        public static LiquidatorAddress GetLiquidatorAddress(LiquidatorAddressEntity liquidatorAddressEntity)
        {
            LiquidatorAddress liquidatorAddress = null;

            try
            {
                //commonMapping.MapLiquidatorAddressEntityToLiquidatorAddress();
                liquidatorAddress = Mapper.Map<LiquidatorAddressEntity, LiquidatorAddress>(liquidatorAddressEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLiquidatorAddress", ex);
                throw;
            }

            return liquidatorAddress;
        }

        public static LiquidatorAlias GetLiquidatorAlias(LiquidatorAliasEntity liquidatorAliasEntity)
        {
            LiquidatorAlias LiquidatorAlias = null;

            try
            {
                // commonMapping.MapLiquidatorAliasEntityToLiquidatorAlias();
                LiquidatorAlias = Mapper.Map<LiquidatorAliasEntity, LiquidatorAlias>(liquidatorAliasEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLiquidatorAlias", ex);
                throw;
            }

            return LiquidatorAlias;
        }

        public static LiquidatorPIC GetLiquidatorPIC(LiquidatorPICEntity liquidatorPICEntity)
        {
            LiquidatorPIC liquidatorPIC = null;

            try
            {
                //commonMapping.MapLiquidatorPICEntityToLiquidatorPIC();
                liquidatorPIC = Mapper.Map<LiquidatorPICEntity, LiquidatorPIC>(liquidatorPICEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLiquidatorPIC", ex);
                throw;
            }

            return liquidatorPIC;
        }

        public static LiquidatorPICAddress GetLiquidatorPICAddress(LiquidatorPICAddressEntity liquidatorPICAddressEntity)
        {
            LiquidatorPICAddress liquidatorPICAddress = null;

            try
            {
                // commonMapping.MapLiquidatorPICAddressEntityToLiquidatorPICAddress();
                liquidatorPICAddress = Mapper.Map<LiquidatorPICAddressEntity, LiquidatorPICAddress>(liquidatorPICAddressEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLiquidatorPICAddress", ex);
                throw;
            }

            return liquidatorPICAddress;
        }

        public static LiquidatorPICAlias GetLiquidatorPICAlias(LiquidatorPICAliasEntity liquidatorPICAliasEntity)
        {
            LiquidatorPICAlias liquidatorPICAlias = null;

            try
            {
                liquidatorPICAlias = Mapper.Map<LiquidatorPICAliasEntity, LiquidatorPICAlias>(liquidatorPICAliasEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLiquidatorPICAlias", ex);
                throw;
            }

            return liquidatorPICAlias;
        }

        /// <summary>
        /// Gets the <see cref="MinuteSheetDocList"/>
        /// </summary>
        /// <param name="minuteSheetDocListEntity">The MinuteSheetDocListEntity.</param>
        /// <returns></returns>
        public static MinuteSheetDocList GetMinuteSheetDocList(MinuteSheetDocListEntity minuteSheetDocListEntity)
        {
            MinuteSheetDocList minuteSheetDocList = null;
            try
            {
                minuteSheetDocList = Mapper.Map<MinuteSheetDocListEntity, MinuteSheetDocList>(minuteSheetDocListEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMinuteSheetDocList", ex);
                throw;
            }
            return minuteSheetDocList;
        }

        /// <summary>
        /// Gets the <see cref="MinuteSheetFamilyRelatedInfo"/>
        /// </summary>
        /// <param name="minuteSheetFamilyRelatedInfoEntity">The MinuteSheetFamilyRelatedInfoEntity.</param>
        /// <returns></returns>
        public static MinuteSheetFamilyRelatedInfo GetMinuteSheetFamilyRelatedInfo(MinuteSheetFamilyRelatedInfoEntity minuteSheetFamilyRelatedInfoEntity)
        {
            MinuteSheetFamilyRelatedInfo minuteSheetFamilyRelatedInfo = null;
            try
            {
                minuteSheetFamilyRelatedInfo = Mapper.Map<MinuteSheetFamilyRelatedInfoEntity, MinuteSheetFamilyRelatedInfo>(minuteSheetFamilyRelatedInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMinuteSheetFamilyRelatedInfo", ex);
                throw;
            }
            return minuteSheetFamilyRelatedInfo;
        }

        /// <summary>
        /// Gets the <see cref="MinuteSheetGroundInfo"/>
        /// </summary>
        /// <param name="minuteSheetGroundInfoEntity">The MinuteSheetGroundInfoEntity.</param>
        /// <returns></returns>
        public static MinuteSheetGroundInfo GetMinuteSheetGroundInfo(MinuteSheetGroundInfoEntity minuteSheetGroundInfoEntity)
        {
            MinuteSheetGroundInfo minuteSheetGroundInfo = null;
            try
            {
                minuteSheetGroundInfo = Mapper.Map<MinuteSheetGroundInfoEntity, MinuteSheetGroundInfo>(minuteSheetGroundInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMinuteSheetGroundInfo", ex);
                throw;
            }
            return minuteSheetGroundInfo;
        }

        /// <summary>
        /// Gets the <see cref="MinuteSheetInfo"/>
        /// </summary>
        /// <param name="minuteSheetInfoEntity">The MinuteSheetInfoEntity.</param>
        /// <returns></returns>
        public static MinuteSheetInfo GetMinuteSheetInfo(MinuteSheetInfoEntity minuteSheetInfoEntity)
        {
            MinuteSheetInfo minuteSheetInfo = null;
            try
            {
                minuteSheetInfo = Mapper.Map<MinuteSheetInfoEntity, MinuteSheetInfo>(minuteSheetInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMinuteSheetInfo", ex);
                throw;
            }
            return minuteSheetInfo;
        }

        /// <summary>
        /// Gets the <see cref="MinuteSheetPartyRepInfo"/>
        /// </summary>
        /// <param name="minuteSheetPartyRepInfoEntity">The MinuteSheetPartyRepInfoEntity.</param>
        /// <returns></returns>
        public static MinuteSheetPartyRepInfo GetMinuteSheetPartyRepInfo(MinuteSheetPartyRepInfoEntity minuteSheetPartyRepInfoEntity)
        {
            MinuteSheetPartyRepInfo minuteSheetPartyRepInfo = null;
            try
            {
                minuteSheetPartyRepInfo = Mapper.Map<MinuteSheetPartyRepInfoEntity, MinuteSheetPartyRepInfo>(minuteSheetPartyRepInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMinuteSheetPartyRepInfo", ex);
                throw;
            }
            return minuteSheetPartyRepInfo;
        }

        /// <summary>
        /// Gets the <see cref="MinuteSheetPartySolicitorInfo"/>
        /// </summary>
        /// <param name="minuteSheetPartySolicitorInfoEntity">The MinuteSheetPartySolicitorInfoEntity.</param>
        /// <returns></returns>
        public static MinuteSheetPartySolicitorInfo GetMinuteSheetPartySolicitorInfo(MinuteSheetPartySolicitorInfoEntity minuteSheetPartySolicitorInfoEntity)
        {
            MinuteSheetPartySolicitorInfo minuteSheetPartySolicitorInfo = null;
            try
            {
                minuteSheetPartySolicitorInfo = Mapper.Map<MinuteSheetPartySolicitorInfoEntity, MinuteSheetPartySolicitorInfo>(minuteSheetPartySolicitorInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMinuteSheetPartySolicitorInfo", ex);
                throw;
            }
            return minuteSheetPartySolicitorInfo;
        }

        /// <summary>
        /// Gets the <see cref="NatureOfAppeal"/> from <see cref="NatureOfAppealEntity"/> input.
        /// </summary>
        /// <param name="natureOfAppealEntity"><see cref="NatureOfAppealEntity"/></param>
        /// <returns>Returns <see cref="NatureOfAppeal"/>, else null.</returns>
        public static NatureOfAppeal GetNatureOfAppeal(NatureOfAppealEntity natureOfAppealEntity)
        {
            NatureOfAppeal natureOfAppeal = null;

            try
            {
                natureOfAppeal = Mapper.Map<NatureOfAppealEntity, NatureOfAppeal>(natureOfAppealEntity);
                natureOfAppeal.MNatureOfAppeal = Mapper.Map<MNatureOfAppealEntity, MNatureOfAppeal>(natureOfAppealEntity.MNatureOfAppeal);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetNatureOfAppeal", ex);
                throw;
            }

            return natureOfAppeal;
        }

        /// <summary>
        /// Gets the <see cref="NatureOfApplication"/> from <see cref="NatureOfApplicationEntity"/> input.
        /// </summary>
        /// <param name="natureOfApplicationEntity"><see cref="NatureOfApplicationEntity"/></param>
        /// <returns>Returns <see cref="NatureOfApplication"/>, else null.</returns>
        public static NatureOfApplication GetNatureOfApplication(NatureOfApplicationEntity natureOfApplicationEntity)
        {
            NatureOfApplication natureOfApplication = null;

            try
            {
                if (natureOfApplicationEntity != null)
                {
                    natureOfApplication = Mapper.Map<NatureOfApplicationEntity, NatureOfApplication>(natureOfApplicationEntity);
                    natureOfApplication.MNOACode = Mapper.Map<MNOACodeEntity, MNOACode>(natureOfApplicationEntity.MNOACodeEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetNatureOfApplication", ex);
                throw;
            }

            return natureOfApplication;
        }

        /// <summary>
        /// Gets the <see cref="NatureOfCase"/> from <see cref="NatureOfCaseEntity"/> input.
        /// </summary>
        /// <param name="natureOfCaseEntity"><see cref="NatureOfCaseEntity"/></param>
        /// <returns>Returns <see cref="NatureOfCase"/>, else null.</returns>
        public static NatureOfCase GetNatureOfCase(NatureOfCaseEntity natureOfCaseEntity)
        {
            NatureOfCase natureOfCase = null;

            try
            {
                natureOfCase = Mapper.Map<NatureOfCaseEntity, NatureOfCase>(natureOfCaseEntity);
                natureOfCase.MNOC = Mapper.Map<MNOCEntity, MNOC>(natureOfCaseEntity.MNatureOfCase);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetNatureOfCase", ex);
                throw;
            }

            return natureOfCase;
        }

        /// <summary>
        /// Get the Nature Of Case Domain Entity.
        /// </summary>
        /// <param name="natureOfCaseDomainEntity"></param>
        /// <returns></returns>
        public static NatureOfCase GetNatureOfCaseEntity(NatureOfCaseEntity natureOfCaseDomainEntity)
        {
            NatureOfCase natureOfCaseNHibernateEntity = null;

            try
            {
                natureOfCaseNHibernateEntity = Mapper.Map<NatureOfCaseEntity, NatureOfCase>(natureOfCaseDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetNatureOfCaseEntity", ex);
                throw;
            }

            return natureOfCaseNHibernateEntity;
        }

        /// <summary>
        /// Gets the NotPaymentToCourtDocDetail.
        /// </summary>
        /// <param name="NotPaymenttoCourtDocDetailEntity">The NotPaymenttoCourtDocDetailEntity.</param>
        /// <returns></returns>
        public static NotPaymentToCourtDocDetail GetNotPaymentToCourtDocDetail(NotPaymenttoCourtDocDetailEntity notPaymenttoCourtDocDetailEntity)
        {
            NotPaymentToCourtDocDetail notPaymentToCourtDocDetail = null;
            try
            {
                notPaymentToCourtDocDetail = Mapper.Map<NotPaymenttoCourtDocDetailEntity, NotPaymentToCourtDocDetail>(notPaymenttoCourtDocDetailEntity);
                notPaymentToCourtDocDetail.MCurrency = Mapper.Map<MCurrencyEntity, MCurrency>(notPaymenttoCourtDocDetailEntity.MCurrency);
                notPaymentToCourtDocDetail.PICurrencyCode = Mapper.Map<MCurrencyEntity, MCurrency>(notPaymenttoCourtDocDetailEntity.PICurrencyCode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetNotPaymentToCourtDocDetail", ex);
                throw;
            }
            return notPaymentToCourtDocDetail;
        }

        public static OrdersMade GetOrdersMade(OrdersMadeEntity ordersMadeEntity)
        {
            OrdersMade ordersMade = null;
            try
            {
                ordersMade = Mapper.Map<OrdersMadeEntity, OrdersMade>(ordersMadeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOrdersMade", ex);
                throw;
            }
            return ordersMade;
        }

        //public static NoOfSupportingDoc GetNoOfSupportingDoc(NoOfSupportingDocEntity noOfSupportingDocEntity)
        //{
        //    NoOfSupportingDoc noOfSupportingDoc = null;
        //    try
        //    {
        //        //commonMapping.MapNoOfSupportingDocEntityToNoOfSupportingDoc();
        //        noOfSupportingDoc = Mapper.Map<NoOfSupportingDocEntity, NoOfSupportingDoc>(noOfSupportingDocEntity);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    return noOfSupportingDoc;
        //}
        public static OriginatingCase GetOriginatingCase(OriginatingCaseEntity originatingCaseEntity)
        {
            OriginatingCase originatingCase = null;
            try
            {
                originatingCase = Mapper.Map<OriginatingCaseEntity, OriginatingCase>(originatingCaseEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOriginatingCase", ex);
                throw;
            }
            return originatingCase;
        }

        public static OtherITMO GetOtherITMO(OtherITMOEntity otherITMOEntity)
        {
            OtherITMO otherITMO = null;

            try
            {
                otherITMO = Mapper.Map<OtherITMOEntity, OtherITMO>(otherITMOEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetOtherITMO", ex);
                throw;
            }

            return otherITMO;
        }

        public static OtherReliefsClaim GetOtherReliefsClaim(OtherReliefsClaimEntity otherReliefsClaimEntity)
        {
            OtherReliefsClaim otherReliefsClaim = null;

            try
            {
                otherReliefsClaim = Mapper.Map<OtherReliefsClaimEntity, OtherReliefsClaim>(otherReliefsClaimEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetOtherReliefsClaim", ex);
                throw;
            }

            return otherReliefsClaim;
        }

        /// <summary>
        /// Get the Other Reliefs Claim Domain Entity.
        /// </summary>
        /// <param name="otherReliefsClaimDomainEntity"></param>
        /// <returns></returns>
        public static OtherReliefsClaim GetOtherReliefsClaimEntityEntity(OtherReliefsClaimEntity otherReliefsClaimDomainEntity)
        {
            OtherReliefsClaim otherReliefsClaimNHibernateEntity = null;

            try
            {
                otherReliefsClaimNHibernateEntity = Mapper.Map<OtherReliefsClaimEntity, OtherReliefsClaim>(otherReliefsClaimDomainEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOtherReliefsClaimEntityEntity", ex);
                throw;
            }

            return otherReliefsClaimNHibernateEntity;
        }

        /// <summary>
        /// Get the Unliquidated Claim Domain Entity.
        /// </summary>
        /// <param name="unliquidatedClaimDomainEntity"></param>
        /// <returns></returns>
        public static UnliquidatedClaim GetOtherReliefsClaimEntityEntity(UnliquidatedClaimEntity unliquidatedClaimDomainEntity)
        {
            UnliquidatedClaim unliquidatedClaimNHibernateEntity = null;

            try
            {
                unliquidatedClaimNHibernateEntity = Mapper.Map<UnliquidatedClaimEntity, UnliquidatedClaim>(unliquidatedClaimDomainEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOtherReliefsClaimEntityEntity", ex);
                throw;
            }

            return unliquidatedClaimNHibernateEntity;
        }


        /// <summary>
        /// Gets the <see cref="PCAppDatesFromSAL"/> from <see cref="pCAppDatesFromSALEntity"/> input.
        /// </summary>
        /// <param name="pCAppDatesFromSALEntity"><see cref="pCAppDatesFromSALEntity"/></param>
        /// <returns>Returns <see cref="PCAppDatesFromSAL"/>, else null.</returns>
        public static PCAppDatesFromSAL GetPCAppDatesFromSAL(PCAppDatesFromSALEntity pCAppDatesFromSALEntity)
        {
            PCAppDatesFromSAL pCAppDatesFromSAL = null;

            try
            {
                if (pCAppDatesFromSALEntity != null)
                {
                    pCAppDatesFromSAL = Mapper.Map<PCAppDatesFromSALEntity, PCAppDatesFromSAL>(pCAppDatesFromSALEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPCAppDatesFromSAL", ex);
                throw;
            }

            return pCAppDatesFromSAL;
        }

        /// <summary>
        /// Gets the <see cref="PCAppDetailsFromSAL"/> from <see cref="pCAppDetailsFromSALEntity"/> input.
        /// </summary>
        /// <param name="pCAppDetailsFromSALEntity"><see cref="pCAppDetailsFromSALEntity"/></param>
        /// <returns>Returns <see cref="PCAppDetailsFromSAL"/>, else null.</returns>
        public static PCAppDetailsFromLawSoc GetPCAppDetailsFromSAL(PCAppDetailsFromLawSocEntity pCAppDetailsFromLawSocEntity)
        {
            PCAppDetailsFromLawSoc pCAppDetailsFromSAL = null;

            try
            {
                if (pCAppDetailsFromLawSocEntity != null)
                {
                    pCAppDetailsFromSAL = Mapper.Map<PCAppDetailsFromLawSocEntity, PCAppDetailsFromLawSoc>(pCAppDetailsFromLawSocEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPCAppDetailsFromSAL", ex);
                throw;
            }

            return pCAppDetailsFromSAL;
        }

        /// <summary>
        /// Gets the <see cref="PCConditionInfo"/> from <see cref="pCConditionInfoEntity"/> input.
        /// </summary>
        /// <param name="pCConditionInfoEntity"><see cref="pCConditionInfoEntity"/></param>
        /// <returns>Returns <see cref="PCConditionInfo"/>, else null.</returns>
        public static PCConditionInfo GetPCConditionInfo(PCConditionInfoEntity pCConditionInfoEntity)
        {
            PCConditionInfo pCConditionInfo = null;

            try
            {
                if (pCConditionInfoEntity != null)
                {
                    pCConditionInfo = Mapper.Map<PCConditionInfoEntity, PCConditionInfo>(pCConditionInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPCConditionInfo", ex);
                throw;
            }

            return pCConditionInfo;
        }

        /// <summary>
        /// Gets the <see cref="Prayer"/> from <see cref="PrayerEntity"/> input.
        /// </summary>
        /// <param name="prayerEntity"><see cref="PrayerEntity"/></param>
        /// <returns>Returns <see cref="Prayer"/>, else null.</returns>
        public static Prayer GetPrayer(PrayerEntity prayerEntity)
        {
            Prayer prayer = null;
            try
            {
                if (prayerEntity != null)
                {
                    prayer = Mapper.Map<PrayerEntity, Prayer>(prayerEntity);
                    prayer.MPrayerOutcome = Mapper.Map<MPrayerOutcomeEntity, MPrayerOutcome>(prayerEntity.MPrayerOutcome);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPrayer", ex);
                throw;
            }
            return prayer;
        }

        /// <summary>
        /// Get Ref Caveat Case.
        /// </summary>
        /// <param name="refCaveatCaseDomainEntity"></param>
        /// <returns></returns>
        public static RefCaveatCase GetRefCaveatCase(RefCaveatCaseEntity refCaveatCaseDomainEntity)
        {
            RefCaveatCase refCaveatCaseNHibernateEntity = null;

            try
            {
                refCaveatCaseNHibernateEntity = Mapper.Map<RefCaveatCaseEntity, RefCaveatCase>(refCaveatCaseDomainEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRefCaveatCase", ex);
                throw;
            }

            return refCaveatCaseNHibernateEntity;
        }

        /*
        /// <summary>
        /// Gets the <see cref="QualificationInfo"/> from <see cref="qualificationInfoEntity"/> input.
        /// </summary>
        /// <param name="qualificationInfoEntity"><see cref="qualificationInfoEntity"/></param>
        /// <returns>Returns <see cref="QualificationInfo"/>, else null.</returns>
        public static QualificationInfo GetQualificationInfo(QualificationInfoEntity qualificationInfoEntity)
        {
            QualificationInfo qualificationInfo = null;

            try
            {
                if (qualificationInfoEntity != null)
                {
                    qualificationInfo = Mapper.Map<QualificationInfoEntity, QualificationInfo>(qualificationInfoEntity);
                    qualificationInfo.MAASQualification = Mapper.Map<MAASQualificationEntity, MAASQualification>(qualificationInfoEntity.MAASQualification);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetQualificationInfo", ex);
                throw;
            }

            return qualificationInfo;
        }*/
        public static RefOrderDetail GetRefOrderDetail(RefOrderDetailEntity refOrderDetailEntity)
        {
            RefOrderDetail refOrderDetailHibernateEntity = null;

            try
            {
                refOrderDetailHibernateEntity = Mapper.Map<RefOrderDetailEntity, RefOrderDetail>(refOrderDetailEntity);
                refOrderDetailHibernateEntity.MDesignation = Mapper.Map<MDesignationEntity, MDesignation>(refOrderDetailEntity.MDesignation);
                refOrderDetailHibernateEntity.MCoram = Mapper.Map<MCoramEntity, MCoram>(refOrderDetailEntity.MCoram);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRefOrderDetail", ex);
                throw;
            }
            return refOrderDetailHibernateEntity;
        }

        public static RefSubCase GetRefSubCase(RefSubCaseEntity refSubCaseEntity)
        {
            RefSubCase refSubCaseHibernateEntity = null;

            try
            {
                refSubCaseHibernateEntity = Mapper.Map<RefSubCaseEntity, RefSubCase>(refSubCaseEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRefSubCase", ex);
                throw;
            }
            return refSubCaseHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="RelatedProceeding"/> from <see cref="RelatedProceedingEntity"/> input.
        /// </summary>
        /// <param name="relatedProceedingEntity"><see cref="RelatedProceedingEntity"/></param>
        /// <returns>Returns <see cref="RelatedProceeding"/>, else null.</returns>
        public static RelatedProceeding GetRelatedProceeding(RelatedProceedingEntity relatedProceedingEntity)
        {
            RelatedProceeding relatedProceeding = null;

            try
            {
                if (relatedProceedingEntity != null)
                {
                    relatedProceeding = Mapper.Map<RelatedProceedingEntity, RelatedProceeding>(relatedProceedingEntity);
                    relatedProceeding.MCountry = Mapper.Map<MCountryEntity, MCountry>(relatedProceedingEntity.MCountry);
                    relatedProceeding.MNatureOfProceeding = Mapper.Map<MNatureOfProceedingEntity, MNatureOfProceeding>(relatedProceedingEntity.NatureOfProceeding);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRelatedProceeding", ex);
                throw;
            }

            return relatedProceeding;
        }

        /// <summary>
        /// Gets the <see cref="SubmissionInfo"/> from <see cref="SubmissionInfoEntity"/> input.
        /// </summary>
        /// <param name="submissionInfoEntity"><see cref="SubmissionInfoEntity"/></param>
        /// <returns>Returns <see cref="SubmissionInfo"/>, else null.</returns>
        public static SubmissionInfo GetSubmissionInfo(SubmissionInfoEntity submissionInfoEntity)
        {
            SubmissionInfo submissionInfo = null;

            try
            {
                submissionInfo = Mapper.Map<SubmissionInfoEntity, SubmissionInfo>(submissionInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSubmissionInfo", ex);
                throw;
            }

            return submissionInfo;
        }

        /// <summary>
        /// Gets the <see cref="TravelPassInfo"/> from <see cref="travelPassInfoEntity"/> input.
        /// </summary>
        /// <param name="travelPassInfoEntity"><see cref="travelPassInfoEntity"/></param>
        /// <returns>Returns <see cref="TravelPassInfo"/>, else null.</returns>
        public static TravelPassInfo GetTravelPassInfo(TravelPassInfoEntity travelPassInfoEntity)
        {
            TravelPassInfo travelPassInfo = null;

            try
            {
                if (travelPassInfoEntity != null)
                {
                    travelPassInfo = Mapper.Map<TravelPassInfoEntity, TravelPassInfo>(travelPassInfoEntity);
                    travelPassInfo.MCountry = Mapper.Map<MCountryEntity, MCountry>(travelPassInfoEntity.MCountry);
                    travelPassInfo.MPersonIDType = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(travelPassInfoEntity.MPersonIDType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetTravelPassInfo", ex);
                throw;
            }

            return travelPassInfo;
        }

        /// <summary>
        /// Gets the unliquidated claim.
        /// </summary>
        /// <param name="unliquidatedClaimEntity">The unliquidated claim entity.</param>
        /// <returns></returns>
        public static UnliquidatedClaim GetUnliquidatedClaim(UnliquidatedClaimEntity unliquidatedClaimEntity)
        {
            UnliquidatedClaim unliquidatedClaim = null;
            try
            {
                unliquidatedClaim = Mapper.Map<UnliquidatedClaimEntity, UnliquidatedClaim>(unliquidatedClaimEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetUnliquidatedClaim", ex);
                throw;
            }
            return unliquidatedClaim;
        }

        /// <summary>
        /// Gets the WOECaseExecutionAddress.
        /// </summary>
        /// <param name="WOECaseExecutionAddressEntity">WOECaseExecutionAddress entity.</param>
        /// <returns></returns>
        public static WOECaseExecutionAddress GetWOECaseExecutionAddress(WOECaseExecutionAddressEntity wOECaseExecutionAddressEntity)
        {
            WOECaseExecutionAddress wOECaseExecutionAddress = new WOECaseExecutionAddress();
            try
            {
                wOECaseExecutionAddress = Mapper.Map<WOECaseExecutionAddressEntity, WOECaseExecutionAddress>(wOECaseExecutionAddressEntity);
            }
            catch
            {
                // Logger.Error("Error encountered at GetWOECaseExecutionAddress", ex);
                throw;
            }
            return wOECaseExecutionAddress;
        }

        /// <summary>
        /// Gets the <see cref="WOEExecutionAddress"/>
        /// </summary>
        /// <param name="woeExecutionAddressEntity">The WOEExecutionAddressEntity.</param>
        /// <returns></returns>
        public static WOEExecutionAddress GetWOEExecutionAddress(WOEExecutionAddressEntity woeExecutionAddressEntity)
        {
            WOEExecutionAddress woeExecutionAddress = null;
            try
            {
                woeExecutionAddress = Mapper.Map<WOEExecutionAddressEntity, WOEExecutionAddress>(woeExecutionAddressEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOEExecutionAddress", ex);
                throw;
            }
            return woeExecutionAddress;
        }

        /// <summary>
        /// Gets the <see cref="AppealTimeEstimationDetail"/>
        /// </summary>
        /// <param name="appealTimeEstimationDetailEntity">The AppealTimeEstimationDetailEntity.</param>
        /// <returns></returns>
        public static AppealTimeEstimationDetail GetAppealTimeEstimationDetail(AppealTimeEstimationDetailEntity appealTimeEstimationDetailEntity)
        {
            AppealTimeEstimationDetail appealTimeEstimationDetail = null;
            try
            {
                appealTimeEstimationDetail = Mapper.Map<AppealTimeEstimationDetailEntity, AppealTimeEstimationDetail>(appealTimeEstimationDetailEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAppealTimeEstimationDetail", ex);
                throw;
            }
            return appealTimeEstimationDetail;
        }

        /// <summary>
        /// Gets the <see cref="AppealTimeEstimationDetail"/>
        /// </summary>
        /// <param name="appealTimeEstimationDetailEntity">The AppealTimeEstimationDetailEntity.</param>
        /// <returns></returns>
        public static NoticeToReferAffidavit GetNoticeToReferAffidavit(NoticeToReferAffidavitEntity noticeToReferAffidavitEntity)
        {
            NoticeToReferAffidavit noticeToReferAffidavit = null;
            try
            {
                noticeToReferAffidavit = Mapper.Map<NoticeToReferAffidavitEntity, NoticeToReferAffidavit>(noticeToReferAffidavitEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetNoticeToReferAffidavit", ex);
                throw;
            }
            return noticeToReferAffidavit;
        }

        /// <summary>
        /// Gets the <see cref="PrintDocumentQueue"/>
        /// </summary>
        /// <param name="PrintDocumentQueueEntity">The PrintDocumentQueueEntity.</param>
        /// <returns>PrintDocumentQueue</returns>
        public static PrintDocumentQueue GetPrintDocumentQueue(PrintDocumentQueueEntity printDocumentQueueEntity)
        {
            PrintDocumentQueue printDocumentQueue = null;
            try
            {
                printDocumentQueue = Mapper.Map<PrintDocumentQueueEntity, PrintDocumentQueue>(printDocumentQueueEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPrintDocumentQueue", ex);
                throw;
            }
            return printDocumentQueue;
        }

        /// <summary>
        /// Gets the <see cref="PrintDocumentQueueDetail"/>
        /// </summary>
        /// <param name="PrintDocumentQueueDetailEntity">The PrintDocumentQueueDetailEntity.</param>
        /// <returns>PrintDocumentQueueDetail</returns>
        public static PrintDocumentQueueDetail GetPrintDocumentQueueDetail(PrintDocumentQueueDetailEntity printDocumentQueueDetailEntity)
        {
            PrintDocumentQueueDetail printDocumentQueueDetail = null;
            try
            {
                printDocumentQueueDetail = Mapper.Map<PrintDocumentQueueDetailEntity, PrintDocumentQueueDetail>(printDocumentQueueDetailEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPrintDocumentQueueDetail", ex);
                throw;
            }
            return printDocumentQueueDetail;
        }


        /// <summary>
        /// Gets the claim amount.
        /// </summary>
        /// <param name="claimAmountEntity">The claim amount entity.</param>
        /// <returns></returns>
        public static ClaimAmount GetClaimAmount(ClaimAmountEntity claimAmountEntity)
        {
            ClaimAmount claimAmount = null;
            try
            {
                claimAmount = Mapper.Map<ClaimAmountEntity, ClaimAmount>(claimAmountEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetClaimAmount", ex);
                throw;
            }
            return claimAmount;
        }

        public static RespondentCaseDetailInfo GetRespondentCaseDetailInfo(RespondentCaseDetailInfoEntity respondentCaseDetailInfoEntity)
        {
            RespondentCaseDetailInfo respondentCaseDetailInfo = null;
            try
            {
                respondentCaseDetailInfo = Mapper.Map<RespondentCaseDetailInfoEntity, RespondentCaseDetailInfo>(respondentCaseDetailInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRespondentCaseDetailInfo", ex);
                throw;
            }
            return respondentCaseDetailInfo;
        }

        public static CheckListComments GetCheckListComments(CheckListCommentEntity checkListCommentEntity)
        {
            CheckListComments checkListComments = null;
            try
            {
                checkListComments = Mapper.Map<CheckListCommentEntity, CheckListComments>(checkListCommentEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCheckListComments", ex);
                throw;
            }
            return checkListComments;
        }

        /// <summary>
        /// Gets the <see cref="AppealTimeEstimationDetail"/>
        /// </summary>
        /// <param name="appealTimeEstimationDetailEntity">The AppealTimeEstimationDetailEntity.</param>
        /// <returns></returns>
        public static RefOrderJOInfo GetRefOrderJOInfo(RefOrderJOInfoEntity refOrderJOInfoEntity)
        {
            RefOrderJOInfo refOrderJOInfo = null;
            try
            {
                refOrderJOInfo = Mapper.Map<RefOrderJOInfoEntity, RefOrderJOInfo>(refOrderJOInfoEntity);
                refOrderJOInfo.MCoram = Mapper.Map<MCoramEntity, MCoram>(refOrderJOInfoEntity.MCoram);
                refOrderJOInfo.MDesignation = Mapper.Map<MDesignationEntity, MDesignation>(refOrderJOInfoEntity.MDesignation);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRefOrderJOInfo", ex);
                throw;
            }
            return refOrderJOInfo;
        }

        /// <summary>
        /// Gets the <see cref="ForeignLPSolicitorReg"/> from <see cref="foreignLPSolicitorRegEntity"/> input.
        /// </summary>
        /// <param name="foreignLPSolicitorRegEntity"><see cref="foreignLPSolicitorRegEntity"/></param>
        /// <returns>Returns <see cref="ForeignLPSolicitorReg"/>, else null.</returns>
        public static ForeignLPSolicitorReg GetForeignLPSolicitorReg(ForeignLPSolicitorRegEntity foreignLPSolicitorRegEntity)
        {
            ForeignLPSolicitorReg foreignLPSolicitorReg = null;

            try
            {
                if (foreignLPSolicitorRegEntity != null)
                {
                    foreignLPSolicitorReg = Mapper.Map<ForeignLPSolicitorRegEntity, ForeignLPSolicitorReg>(foreignLPSolicitorRegEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetForeignLPSolicitorReg", ex);
                throw;
            }

            return foreignLPSolicitorReg;
        }

        /// <summary>
        /// Gets the <see cref="AppealTimeEstimationDetail"/>
        /// </summary>
        /// <param name="appealTimeEstimationDetailEntity">The AppealTimeEstimationDetailEntity.</param>
        /// <returns></returns>
        public static InterfaceNBSReport GetInterfaceNBSReport(InterfaceNBSReportEntity interfaceNBSReportEntity)
        {
            InterfaceNBSReport interfaceNBSReport = null;
            try
            {
                interfaceNBSReport = Mapper.Map<InterfaceNBSReportEntity, InterfaceNBSReport>(interfaceNBSReportEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetInterfaceNBSReport", ex);
                throw;
            }
            return interfaceNBSReport;
        }



        /// <summary>
        /// Gets the foreign user registration detail.
        /// </summary>
        /// <param name="foreignUserRegistrationDetailsEntity">The foreign user registration details entity.</param>
        /// <returns></returns>
        public static ForeignUserRegistrationDetails GetForeignUserRegistrationDetail(ForeignUserRegistrationDetailsEntity foreignUserRegistrationDetailsEntity)
        {
            ForeignUserRegistrationDetails foreignUserRegistrationDetails = null;
            try
            {
                foreignUserRegistrationDetails = Mapper.Map<ForeignUserRegistrationDetailsEntity, ForeignUserRegistrationDetails>(foreignUserRegistrationDetailsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetForeignUserRegistrationDetailEntity", ex);
                throw;
            }
            return foreignUserRegistrationDetails;
        }


        /// <summary>
        /// Gets the foreign user reg address details.
        /// </summary>
        /// <param name="foreignUserRegAddressDetailsEntity">The foreign user reg address details entity.</param>
        /// <returns></returns>
        public static ForeignUserRegAddressDetails GetForeignUserRegAddressDetails(ForeignUserRegAddressDetailsEntity foreignUserRegAddressDetailsEntity)
        {
            ForeignUserRegAddressDetails foreignUserRegAddressDetails = null;
            try
            {
                foreignUserRegAddressDetails = Mapper.Map<ForeignUserRegAddressDetailsEntity, ForeignUserRegAddressDetails>(foreignUserRegAddressDetailsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetForeignUserRegAddressDetails", ex);
                throw;
            }
            return foreignUserRegAddressDetails;
        }

        /// <summary>
        /// Gets the foreign user practice information entity.
        /// </summary>
        /// <param name="foreignUserPracticeInformation">The foreign user practice information.</param>
        /// <returns></returns>
        public static ForeignUserPracticeInformation GetForeignUserPracticeInformation(ForeignUserPracticeInformationEntity foreignUserPracticeInformationEntity)
        {
            ForeignUserPracticeInformation foreignUserPracticeInformation = null;
            try
            {
                foreignUserPracticeInformation = Mapper.Map<ForeignUserPracticeInformationEntity, ForeignUserPracticeInformation>(foreignUserPracticeInformationEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetForeignUserPracticeInformation", ex);
                throw;
            }
            return foreignUserPracticeInformation;
        }

        /// <summary>
        /// Gets the req examination feedetail.
        /// </summary>
        /// <param name="reqExaminationFeedetailEntity">The req examination feedetail entity.</param>
        /// <returns></returns>
        private static ReqExaminationFeeDetail GetReqExaminationFeedetail(ReqExaminationFeeDetailEntity reqExaminationFeedetailEntity)
        {
            ReqExaminationFeeDetail reqExaminationFeedetail = null;

            try
            {
                if (reqExaminationFeedetailEntity != null)
                {
                    reqExaminationFeedetail = Mapper.Map<ReqExaminationFeeDetailEntity, ReqExaminationFeeDetail>(reqExaminationFeedetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetReqExaminationFeedetail", ex);
                throw;
            }

            return reqExaminationFeedetail;
        }

        public static RegistrationOfForeignLawyer GetRegistrationOfForeignLawyer(RegistrationOfForeignLawyerEntity registrationOfForeignLawyerEntity)
        {
            RegistrationOfForeignLawyer registrationOfForeignLawyer = null;

            try
            {
                if (registrationOfForeignLawyerEntity != null)
                {
                    registrationOfForeignLawyer = Mapper.Map<RegistrationOfForeignLawyerEntity, RegistrationOfForeignLawyer>(registrationOfForeignLawyerEntity);
                    registrationOfForeignLawyer.MGender = Mapper.Map<MGenderEntity, MGender>(registrationOfForeignLawyerEntity.Gender);
                    registrationOfForeignLawyer.MNationality = Mapper.Map<MNationalityEntity, MNationality>(registrationOfForeignLawyerEntity.Nationality);
                    registrationOfForeignLawyer.MCaseType = Mapper.Map<MCaseTypeEntity, MCaseType>(registrationOfForeignLawyerEntity.CaseType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRegistrationOfForeignLawyer", ex);
                throw;
            }

            return registrationOfForeignLawyer;
        }

        public static RFLValidityAndNotification GetRFLValidityAndNotification(RFLValidityAndNotificationEntity rFLValidityAndNotificationEntity)
        {
            RFLValidityAndNotification rFLValidityAndNotification = null;

            try
            {
                if (rFLValidityAndNotificationEntity != null)
                {
                    rFLValidityAndNotification = Mapper.Map<RFLValidityAndNotificationEntity, RFLValidityAndNotification>(rFLValidityAndNotificationEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRFLValidityAndNotification", ex);
                throw;
            }

            return rFLValidityAndNotification;
        }

        public static SICCFeeLedger GetSICCFeeLedger(SICCFeeLedgerEntity sICCFeeLedgerEntity)
        {
            SICCFeeLedger sICCFeeLedger = null;

            try
            {
                if (sICCFeeLedgerEntity != null)
                {
                    sICCFeeLedger = Mapper.Map<SICCFeeLedgerEntity, SICCFeeLedger>(sICCFeeLedgerEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSICCFeeLedger", ex);
                throw;
            }
            return sICCFeeLedger;
        }


        public static SystemParameters GetSystemParameters(SystemParametersEntity systemParametersEntity)
        {
            SystemParameters systemParameters = null;

            try
            {
                if (systemParametersEntity != null)
                {
                    systemParameters = Mapper.Map<SystemParametersEntity, SystemParameters>(systemParametersEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSystemParameters", ex);
                throw;
            }

            return systemParameters;
        }

        /// <summary>
        /// Gets the Request For Exemption detail.
        /// </summary>
        /// <param name="RequestForExemption">The Request for Exemption entity.</param>
        /// <returns></returns>
        public static RequestForExemption GetRequestForExemption(RequestForExemptionEntity requestForExemptionEntity)
        {
            RequestForExemption requestForExemption = null;
            try
            {
                if (requestForExemptionEntity != null)
                {
                    requestForExemption = Mapper.Map<RequestForExemptionEntity, RequestForExemption>(requestForExemptionEntity);
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRequestForExemption", ex);
                throw;
            }
            return requestForExemption;
        }

        /// <summary>
        /// Gets the Fee Collection Detail.
        /// </summary>
        /// <param name="FeeCollectionDetailEntity">The req Fee Collection Detail entity.</param>
        /// <returns></returns>
        private static FeeCollectionDetail GetFeeCollectionDetail(FeeCollectionDetailEntity feeCollectionDetailEntity)
        {
            FeeCollectionDetail feeCollectionDetail = null;

            try
            {
                if (feeCollectionDetailEntity != null)
                {
                    feeCollectionDetail = Mapper.Map<FeeCollectionDetailEntity, FeeCollectionDetail>(feeCollectionDetailEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetFeeCollectionDetail", ex);
                throw;
            }

            return feeCollectionDetail;
        }

        /// <summary>
        /// Gets the <see cref="OutgoingCorrespondenceInfoList"/>
        /// </summary>
        /// <param name="OutgoingCorrespondenceInfoEntity">The OutgoingCorrespondenceInfoEntity.</param>
        /// <returns></returns>
        public static OutgoingCorrespondenceInfo GetOutgoingCorrespondenceInfo(OutgoingCorrespondenceInfoEntity outgoingCorrespondenceInfoEntity)
        {
            OutgoingCorrespondenceInfo outgoingCorrespondenceInfo = null;
            try
            {
                outgoingCorrespondenceInfo = Mapper.Map<OutgoingCorrespondenceInfoEntity, OutgoingCorrespondenceInfo>(outgoingCorrespondenceInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOutgoingCorrespondenceInfo", ex);
                throw;
            }
            return outgoingCorrespondenceInfo;
        }

        /// <summary>
        /// Gets the <see cref="Outgoing Correspondence CourtFee List"/>
        /// </summary>
        /// <param name="OutgoingCorrespondenceCourtFeeEntity">The OutgoingCorrespondenceCourtFeeEntity.</param>
        /// <returns></returns>
        public static OutgoingCorrespondenceCourtFee GetOutgoingCorrespondenceCourtFee(OutgoingCorrespondenceCourtFeeEntity outgoingCorrespondenceCourtFeeEntity)
        {
            OutgoingCorrespondenceCourtFee outgoingCorrespondenceCourtFee = null;
            try
            {
                outgoingCorrespondenceCourtFee = Mapper.Map<OutgoingCorrespondenceCourtFeeEntity, OutgoingCorrespondenceCourtFee>(outgoingCorrespondenceCourtFeeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOutgoingCorrespondenceCourtFee", ex);
                throw;
            }
            return outgoingCorrespondenceCourtFee;
        }

        /// <summary>
        /// Gets the Law firm registration Detail.
        /// </summary>
        /// <param name="LawFirmRegistrationEntity">The Law firm registration Detail entity.</param>
        /// <returns></returns>
        public static LawFirmRegistration GetLawFirmRegistration(LawFirmRegistrationEntity lawFirmRegistrationEntity)
        {
            LawFirmRegistration lawFirmRegistration = null;

            try
            {
                if (lawFirmRegistrationEntity != null)
                {
                    lawFirmRegistration = Mapper.Map<LawFirmRegistrationEntity, LawFirmRegistration>(lawFirmRegistrationEntity);
                    lawFirmRegistration.MLawFirmGroup = Mapper.Map<MLawFirmGroupEntity, MLawFirmGroup>(lawFirmRegistrationEntity.MLawFirmGroup);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLawFirmRegistration", ex);
                throw;
            }

            return lawFirmRegistration;
        }


        /// <summary>
        /// Gets the <see cref="DocLegalExperienceInfo"/>
        /// </summary>
        /// <param name="DoclegalExperienceInfoEntity">The DocLegalExperienceInfoEntity.</param>
        /// <returns></returns>
        public static DocLegalExperienceInfo GetDocLegalExperienceInfo(DocLegalExperienceInfoEntity docLegalExperienceInfoEntity)
        {
            DocLegalExperienceInfo docLegalExperienceInfo = null;
            try
            {
                if (docLegalExperienceInfoEntity != null)
                {
                    docLegalExperienceInfo = Mapper.Map<DocLegalExperienceInfoEntity, DocLegalExperienceInfo>(docLegalExperienceInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocLegalExperienceInfo", ex);
                throw;
            }
            return docLegalExperienceInfo;
        }

        /// <summary>
        /// Gets the <see cref="CaseLegalExperienceInfo"/>
        /// </summary>
        /// <param name="DoclegalExperienceInfoEntity">The DocLegalExperienceInfoEntity.</param>
        /// <returns></returns>
        public static CaseLegalExperienceInfo GetCaseLegalExperienceInfo(CaseLegalExperienceInfoEntity caseLegalExperienceInfoEntity)
        {
            CaseLegalExperienceInfo caseLegalExperienceInfo = null;
            try
            {
                if (caseLegalExperienceInfoEntity != null)
                {
                    caseLegalExperienceInfo = Mapper.Map<CaseLegalExperienceInfoEntity, CaseLegalExperienceInfo>(caseLegalExperienceInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseLegalExperienceInfo", ex);
                throw;
            }
            return caseLegalExperienceInfo;
        }

        /// <summary>
        /// Gets the <see cref="CORSolicitorReg"/>
        /// </summary>
        /// <param name="CORSolicitorRegEntity">The CORSolicitorRegEntity.</param>
        /// <returns></returns>
        public static CORSolicitorReg GetCORSolicitorReg(CORSolicitorRegEntity cORSolicitorRegEntity)
        {
            CORSolicitorReg cORSolicitorReg = null;
            try
            {
                if (cORSolicitorRegEntity != null)
                {
                    cORSolicitorReg = Mapper.Map<CORSolicitorRegEntity, CORSolicitorReg>(cORSolicitorRegEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCORSolicitorReg", ex);
                throw;
            }
            return cORSolicitorReg;
        }

        /// <summary>
        /// Gets the <see cref="CORSolicitorRegDetails"/>
        /// </summary>
        /// <param name="CORSolicitorRegDetailsEntity">The CORSolicitorRegDetailsEntity.</param>
        /// <returns></returns>
        public static CORSolicitorRegDetails GetCORSolicitorRegDetails(CORSolicitorRegDetailsEntity cORSolicitorRegDetailsEntity)
        {
            CORSolicitorRegDetails cORSolicitorRegDetails = null;
            try
            {
                if (cORSolicitorRegDetailsEntity != null)
                {
                    cORSolicitorRegDetails = Mapper.Map<CORSolicitorRegDetailsEntity, CORSolicitorRegDetails>(cORSolicitorRegDetailsEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCORSolicitorRegDetails", ex);
                throw;
            }
            return cORSolicitorRegDetails;
        }

        /// <summary>
        /// Gets the <see cref="DocCaseCounterClaimDetails"/>
        /// </summary>
        /// <param name="DocCaseCounterClaimDetailsEntity">The DocCaseCounterClaimDetailsEntity.</param>
        /// <returns></returns>
        public static DocCaseCounterClaimDetails GetDocCaseCounterClaimDetails(DocCaseCounterClaimDetailsEntity docCaseCounterClaimDetailsEntity)
        {
            DocCaseCounterClaimDetails docCaseCounterClaimDetails = null;
            try
            {
                if (docCaseCounterClaimDetailsEntity != null)
                {
                    docCaseCounterClaimDetails = Mapper.Map<DocCaseCounterClaimDetailsEntity, DocCaseCounterClaimDetails>(docCaseCounterClaimDetailsEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at DocCaseCounterClaimDetails", ex);
                throw;
            }
            return docCaseCounterClaimDetails;
        }

        /// <summary>
        /// Gets the <see cref="DocCaseCounterClaim"/>
        /// </summary>
        /// <param name="DocCaseCounterClaimEntity">The DocCaseCounterClaimEntity.</param>
        /// <returns></returns>
        public static DocCaseCounterClaim GetDocCaseCounterClaim(DocCaseCounterClaimEntity docCaseCounterClaimEntity)
        {
            DocCaseCounterClaim docCaseCounterClaim = null;
            try
            {
                if (docCaseCounterClaimEntity != null)
                {
                    docCaseCounterClaim = Mapper.Map<DocCaseCounterClaimEntity, DocCaseCounterClaim>(docCaseCounterClaimEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at DocCaseCounterClaim", ex);
                throw;
            }
            return docCaseCounterClaim;
        }

        /// <summary>
        /// Gets the <see cref="CaseCounterClaim"/>
        /// </summary>
        /// <param name="CaseCounterClaimEntity">The CaseCounterClaimEntity.</param>
        /// <returns></returns>
        public static CaseCounterClaim GetCaseCounterClaim(CaseCounterClaimEntity caseCounterClaimEntity)
        {
            CaseCounterClaim caseCounterClaim = null;
            try
            {
                if (caseCounterClaimEntity != null)
                {
                    caseCounterClaim = Mapper.Map<CaseCounterClaimEntity, CaseCounterClaim>(caseCounterClaimEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at CaseCounterClaim", ex);
                throw;
            }
            return caseCounterClaim;
        }

        /// <summary>
        /// Gets the <see cref="CaseCounterClaimDetails"/>
        /// </summary>
        /// <param name="CaseCounterClaimDetailsEntity">The CaseCounterClaimDetailsEntity.</param>
        /// <returns></returns>
        public static CaseCounterClaimDetails GetCaseCounterClaimDetails(CaseCounterClaimDetailsEntity caseCounterClaimDetailsEntity)
        {
            CaseCounterClaimDetails caseCounterClaimDetails = null;
            try
            {
                if (caseCounterClaimDetailsEntity != null)
                {
                    caseCounterClaimDetails = Mapper.Map<CaseCounterClaimDetailsEntity, CaseCounterClaimDetails>(caseCounterClaimDetailsEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at CaseCounterClaimDetails", ex);
                throw;
            }
            return caseCounterClaimDetails;
        }

        #endregion Methods
    }
}