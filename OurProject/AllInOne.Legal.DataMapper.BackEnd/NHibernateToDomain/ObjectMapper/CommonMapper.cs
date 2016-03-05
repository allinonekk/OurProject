#region Header

/*****************************************************************************************************
* Description : This file handles mapper for Common from NHibernate entities to Domain objects.
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
// Description: This file handles mapper for Common from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "CommonMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Common from NHibernate entities to Domain objects.
    /// </summary>
    public class CommonMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CommonMapper));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the <see cref="PrintDocumentQueueEntity"/> from <see cref="PrintDocumentQueue"/> input.
        /// </summary>
        /// <param name="PrintDocumentQueue"><see cref="PrintDocumentQueue"/></param>
        /// <returns>Returns <see cref="PrintDocumentQueueEntity"/>, else null.</returns>
        public static PrintDocumentQueueEntity GetPrintDocumentQueueEntity(PrintDocumentQueue printDocumentQueue)
        {
            PrintDocumentQueueEntity printDocumentQueueEntity = null;

            try
            {
                if (printDocumentQueue != null)
                {
                    printDocumentQueueEntity = Mapper.Map<PrintDocumentQueue, PrintDocumentQueueEntity>(printDocumentQueue);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPrintDocumentQueueEntity", ex);
                throw;
            }

            return printDocumentQueueEntity;
        }

        /// <summary>
        /// Gets the <see cref="PrintDocumentQueueDetailEntity"/> from <see cref="PrintDocumentQueueDetail"/> input.
        /// </summary>
        /// <param name="PrintDocumentQueueDetail"><see cref="PrintDocumentQueueDetail"/></param>
        /// <returns>Returns <see cref="PrintDocumentQueueDetailEntity"/>, else null.</returns>
        public static PrintDocumentQueueDetailEntity GetPrintDocumentQueueDetailEntity(PrintDocumentQueueDetail printDocumentQueueDetail)
        {
            PrintDocumentQueueDetailEntity printDocumentQueueDetailEntity = null;

            try
            {
                if (printDocumentQueueDetail != null)
                {
                    printDocumentQueueDetailEntity = Mapper.Map<PrintDocumentQueueDetail, PrintDocumentQueueDetailEntity>(printDocumentQueueDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPrintDocumentQueueDetailEntity", ex);
                throw;
            }

            return printDocumentQueueDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="AffidavitDeponentDetailEntity"/> from <see cref="AffidavitDeponentDetail"/> input.
        /// </summary>
        /// <param name="affidavitDeponentDetail"><see cref="AffidavitDeponentDetail"/></param>
        /// <returns>Returns <see cref="AffidavitDeponentDetailEntity"/>, else null.</returns>
        public static AffidavitDeponentDetailEntity GetAffidavitDeponentDetailEntity(AffidavitDeponentDetail affidavitDeponentDetail)
        {
            AffidavitDeponentDetailEntity affidavitDeponentDetailEntity = null;

            try
            {
                if (affidavitDeponentDetail != null)
                {
                    affidavitDeponentDetailEntity = Mapper.Map<AffidavitDeponentDetail, AffidavitDeponentDetailEntity>(affidavitDeponentDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAffidavitDeponentDetailEntity", ex);
                throw;
            }

            return affidavitDeponentDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="AffidavitInfoEntity"/> from <see cref="AffidavitInfo"/> input.
        /// </summary>
        /// <param name="affidavitInfo"><see cref="AffidavitInfo"/></param>
        /// <returns>Returns <see cref="AffidavitInfoEntity"/>, else null.</returns>
        public static AffidavitInfoEntity GetAffidavitInfoEntity(AffidavitInfo affidavitInfo)
        {
            AffidavitInfoEntity affidavitInfoEntity = null;

            try
            {
                if (affidavitInfo != null)
                {
                    affidavitInfoEntity = Mapper.Map<AffidavitInfo, AffidavitInfoEntity>(affidavitInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAffidavitInfoEntity", ex);
                throw;
            }

            return affidavitInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="BTSRoutingQueueEntity"/>
        /// </summary>
        /// <param name="bTSRoutingQueue">The bTSRoutingQueue.</param>
        /// <returns></returns>
        public static BTSRoutingQueueEntity GetBTSRoutingQueueEntity(BTSRoutingQueue bTSRoutingQueue)
        {
            BTSRoutingQueueEntity bTSRoutingQueueEntity = null;
            try
            {
                bTSRoutingQueueEntity = Mapper.Map<BTSRoutingQueue, BTSRoutingQueueEntity>(bTSRoutingQueue);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBTSRoutingQueueEntity", ex);
                throw;
            }
            return bTSRoutingQueueEntity;
        }

        /// <summary>
        /// Gets the <see cref="CertSecurityOfCostsInfoEntity"/> from <see cref="CertSecurityOfCostsInfo"/> input.
        /// </summary>
        /// <param name="certSecurityOfCostsInfo"><see cref="CertSecurityOfCostsInfo"/></param>
        /// <returns>Returns <see cref="CertSecurityOfCostsInfoEntity"/>, else null.</returns>
        public static CertSecurityOfCostsInfoEntity GetCertSecurityOfCostsInfoEntity(CertSecurityOfCostsInfo certSecurityOfCostsInfo)
        {
            CertSecurityOfCostsInfoEntity certSecurityOfCostsInfoEntity = null;

            try
            {
                if (certSecurityOfCostsInfo != null)
                {
                    certSecurityOfCostsInfoEntity = Mapper.Map<CertSecurityOfCostsInfo, CertSecurityOfCostsInfoEntity>(certSecurityOfCostsInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCertSecurityOfCostsInfoEntity", ex);
                throw;
            }

            return certSecurityOfCostsInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="ChecklistInstanceEntity"/> from <see cref="ChecklistInstance"/> input.
        /// </summary>
        /// <param name="checklistInstance"><see cref="ChecklistInstance"/></param>
        /// <returns>Returns <see cref="ChecklistInstanceEntity"/>, else null.</returns>
        public static ChecklistInstanceEntity GetChecklistInstanceEntity(CheckListInstance checklistInstance)
        {
            ChecklistInstanceEntity checklistInstanceEntity = null;

            try
            {
                if (checklistInstance != null)
                {
                    checklistInstanceEntity = Mapper.Map<CheckListInstance, ChecklistInstanceEntity>(checklistInstance);
                    checklistInstanceEntity.MChecklist = Mapper.Map<MChecklist, MChecklistEntity>(checklistInstance.MChecklist);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetChecklistInstanceEntity", ex);
                throw;
            }

            return checklistInstanceEntity;
        }

        /// <summary>
        /// Gets the <see cref="ChecklistSubmissionEntity"/> from <see cref="ChecklistSubmission"/> input.
        /// </summary>
        /// <param name="checklistSubmission"><see cref="ChecklistSubmission"/></param>
        /// <returns>Returns <see cref="ChecklistSubmissionEntity"/>, else null.</returns>
        public static ChecklistSubmissionEntity GetChecklistSubmissionEntity(CheckListSubmission checklistSubmission)
        {
            ChecklistSubmissionEntity checklistSubmissionEntity = null;

            try
            {
                if (checklistSubmission != null)
                {
                    checklistSubmissionEntity = Mapper.Map<CheckListSubmission, ChecklistSubmissionEntity>(checklistSubmission);
                    checklistSubmissionEntity.MDocCode = Mapper.Map<MDocCode, MDocCodeEntity>(checklistSubmission.MDocCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetChecklistSubmissionEntity", ex);
                throw;
            }

            return checklistSubmissionEntity;
        }

        /// <summary>
        /// Gets the child info entity.
        /// </summary>
        /// <param name="childInfo">The child info.</param>
        /// <returns></returns>
        public static ChildInfoEntity GetChildInfoEntity(ChildInfo childInfo)
        {
            ChildInfoEntity childInfoEntity = null;
            try
            {
                childInfoEntity = Mapper.Map<ChildInfo, ChildInfoEntity>(childInfo);
                childInfoEntity.IdCountry = Mapper.Map<MCountry, MCountryEntity>(childInfo.MCountry);
                childInfoEntity.Gender = Mapper.Map<MGender, MGenderEntity>(childInfo.MGender);
                childInfoEntity.MaritalStatus = Mapper.Map<MMaritalStatus, MMaritalStatusEntity>(childInfo.MMaritalStatus);
                childInfoEntity.MOccupation = Mapper.Map<MOccupation, MOccupationEntity>(childInfo.MOccupation);
                childInfoEntity.MPersonIdType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(childInfo.MPersonIDType);
                childInfoEntity.MQualification = Mapper.Map<MQualification, MQualificationEntity>(childInfo.MQualification);
                childInfoEntity.MRace = Mapper.Map<MRace, MRaceEntity>(childInfo.MRace);
                childInfoEntity.MReligion = Mapper.Map<MReligion, MReligionEntity>(childInfo.MReligion);
                childInfoEntity.Nationality = Mapper.Map<MNationality, MNationalityEntity>(childInfo.MNationality);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetChildInfoEntity", ex);
                throw;
            }
            return childInfoEntity;
        }

        /// <summary>
        /// Method returns the <see cref="ICommonEntity"/> tagged entity from <see cref="ICommonEntity"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="ICommonEntity"/> type</typeparam>
        /// <param name="commonEntity"><see cref="ICommonEntity"/> object.</param>
        /// <returns>Returns the <see cref="ICommonEntity"/></returns>
        public static ICommonEntity GetCommonEntity<T>(T commonEntity)
        {
            try
            {
                //if (commonEntity.GetType().Equals(typeof(AASCertification)))
                //    return (GetAASCertificationEntity(commonEntity as AASCertification));
                
                if (commonEntity.GetType().Equals(typeof(PrintDocumentQueue)))
                    return (GetPrintDocumentQueueEntity(commonEntity as PrintDocumentQueue));

                if (commonEntity.GetType().Equals(typeof(PrintDocumentQueueDetail)))
                    return (GetPrintDocumentQueueDetailEntity(commonEntity as PrintDocumentQueueDetail));

                else if (commonEntity.GetType().Equals(typeof(AffidavitDeponentDetail)))
                    return (GetAffidavitDeponentDetailEntity(commonEntity as AffidavitDeponentDetail));

                else if (commonEntity.GetType().Equals(typeof(DocAppProcessByExAgency)))
                    return (GetDocAppProcessByExAgencyEntity(commonEntity as DocAppProcessByExAgency));

                else if (commonEntity.GetType().Equals(typeof(WOECaseExecutionAddress)))
                    return (GetWOECaseExecutionAddressEntity(commonEntity as WOECaseExecutionAddress));

                else if (commonEntity.GetType().Equals(typeof(AffidavitInfo)))
                    return (GetAffidavitInfoEntity(commonEntity as AffidavitInfo));

                else if (commonEntity.GetType().Equals(typeof(CertSecurityOfCostsInfo)))
                    return (GetCertSecurityOfCostsInfoEntity(commonEntity as CertSecurityOfCostsInfo));

                else if (commonEntity.GetType().Equals(typeof(CheckListInstance)))
                    return (GetChecklistInstanceEntity(commonEntity as CheckListInstance));

                else if (commonEntity.GetType().Equals(typeof(CheckListSubmission)))
                    return (GetChecklistSubmissionEntity(commonEntity as CheckListSubmission));

                else if (commonEntity.GetType().Equals(typeof(ChildInfo)))
                    return (GetChildInfoEntity(commonEntity as ChildInfo));

                else if (commonEntity.GetType().Equals(typeof(DivorceInfo)))
                    return (GetDivorceInfoEntity(commonEntity as DivorceInfo));

                else if (commonEntity.GetType().Equals(typeof(EmploymentInfo)))
                    return (GetEmploymentInfoEntity(commonEntity as EmploymentInfo));

                else if (commonEntity.GetType().Equals(typeof(FilingFeeDetail)))
                    return (GetFilingFeeDetailEntity(commonEntity as FilingFeeDetail));

                //else if (commonEntity.GetType().Equals(typeof(ForeignLawPractice)))
                //    return (GetForeignLawPracticeEntity(commonEntity as ForeignLawPractice));

                else if (commonEntity.GetType().Equals(typeof(ForeignLawPracticeRegAddress)))
                    return (GetForeignLawPracticeRegAddressEntity(commonEntity as ForeignLawPracticeRegAddress));

                else if (commonEntity.GetType().Equals(typeof(ForeignLawPracticeReg)))
                    return (GetForeignLawPracticeRegEntity(commonEntity as ForeignLawPracticeReg));

                else if (commonEntity.GetType().Equals(typeof(ForeignLPSolicitorReg)))
                    return (GetForeignLPSolicitorRegEntity(commonEntity as ForeignLPSolicitorReg));

                else if (commonEntity.GetType().Equals(typeof(GroundInfo)))
                    return (GetGroundInfoEntity(commonEntity as GroundInfo));

                else if (commonEntity.GetType().Equals(typeof(LegislationProvision)))
                    return (GetLegislationProvisionEntity(commonEntity as LegislationProvision));

                else if (commonEntity.GetType().Equals(typeof(LiquidatedClaim)))
                    return (GetLiquidatedClaimEntity(commonEntity as LiquidatedClaim));

                else if (commonEntity.GetType().Equals(typeof(LiquidatorAddress)))
                    return (GetLiquidatorAddressEntity(commonEntity as LiquidatorAddress));

                else if (commonEntity.GetType().Equals(typeof(LiquidatorAlias)))
                    return (GetLiquidatorAliasEntity(commonEntity as LiquidatorAlias));

                else if (commonEntity.GetType().Equals(typeof(LiquidatorPICAddress)))
                    return (GetLiquidatorPICAddressEntity(commonEntity as LiquidatorPICAddress));

                else if (commonEntity.GetType().Equals(typeof(LiquidatorPICAlias)))
                    return (GetLiquidatorPICAliasEntity(commonEntity as LiquidatorPICAlias));

                else if (commonEntity.GetType().Equals(typeof(LiquidatorPIC)))
                    return (GetLiquidatorPICEntity(commonEntity as LiquidatorPIC));

                else if (commonEntity.GetType().Equals(typeof(Liquidator)))
                    return (GetLiquidatorEntity(commonEntity as Liquidator));

                else if (commonEntity.GetType().Equals(typeof(NatureOfCase)))
                    return (GetNatureOfCaseEntity(commonEntity as NatureOfCase));

                else if (commonEntity.GetType().Equals(typeof(OriginatingCase)))
                    return (GetOriginatingCaseEntity(commonEntity as OriginatingCase));

                else if (commonEntity.GetType().Equals(typeof(OtherITMO)))
                    return (GetOtherITMOEntity(commonEntity as OtherITMO));

                else if (commonEntity.GetType().Equals(typeof(OtherReliefsClaim)))
                    return (GetOtherReliefsClaimEntity(commonEntity as OtherReliefsClaim));

                else if (commonEntity.GetType().Equals(typeof(PCAppDatesFromSAL)))
                    return (GetPCAppDatesFromSALEntity(commonEntity as PCAppDatesFromSAL));

                //else if (commonEntity.GetType().Equals(typeof(PCAppDetailsFromSAL)))
                //    return (GetPCAppDetailsFromSALEntity(commonEntity as PCAppDetailsFromSAL));

                else if (commonEntity.GetType().Equals(typeof(PCConditionInfo)))
                    return (GetPCConditionInfoEntity(commonEntity as PCConditionInfo));

                else if (commonEntity.GetType().Equals(typeof(Prayer)))
                    return (GetPrayerEntity(commonEntity as Prayer));

                //else if (commonEntity.GetType().Equals(typeof(QualificationInfo)))
                //    return (GetQualificationInfoEntity(commonEntity as QualificationInfo));

                else if (commonEntity.GetType().Equals(typeof(RefCaveatCase)))
                    return (GetRefCaveatCaseEntity(commonEntity as RefCaveatCase));

                else if (commonEntity.GetType().Equals(typeof(RefOrderDetail)))
                    return (GetRefOrderDetailEntity(commonEntity as RefOrderDetail));

                else if (commonEntity.GetType().Equals(typeof(RefSubCase)))
                    return (GetRefSubCaseEntity(commonEntity as RefSubCase));

                else if (commonEntity.GetType().Equals(typeof(RelatedProceeding)))
                    return (GetRelatedProceedingEntity(commonEntity as RelatedProceeding));

                else if (commonEntity.GetType().Equals(typeof(SubmissionInfo)))
                    return (GetSubmissionInfoEntity(commonEntity as SubmissionInfo));

                else if (commonEntity.GetType().Equals(typeof(TravelPassInfo)))
                    return (GetTravelPassInfoEntity(commonEntity as TravelPassInfo));

                else if (commonEntity.GetType().Equals(typeof(UnliquidatedClaim)))
                    return (GetUnliquidatedClaimEntity(commonEntity as UnliquidatedClaim));

                else if (commonEntity.GetType().Equals(typeof(ForeignLPSolicitorRegDetail)))
                    return (GetForeignLPSolicitorRegDetailEntity(commonEntity as ForeignLPSolicitorRegDetail));

                else if (commonEntity.GetType().Equals(typeof(WOEExecutionAddress)))
                    return (GetWOEExecutionAddressEntity(commonEntity as WOEExecutionAddress));

                else if (commonEntity.GetType().Equals(typeof(MinuteSheetFamilyRelatedInfo)))
                    return GetMinuteSheetFamilyRelatedInfoEntity(commonEntity as MinuteSheetFamilyRelatedInfo);

                else if (commonEntity.GetType().Equals(typeof(MinuteSheetGroundInfo)))
                    return GetMinuteSheetGroundInfoEntity(commonEntity as MinuteSheetGroundInfo);

                else if (commonEntity.GetType().Equals(typeof(MinuteSheetInfo)))
                    return GetMinuteSheetInfoEntity(commonEntity as MinuteSheetInfo);

                else if (commonEntity.GetType().Equals(typeof(MinuteSheetDocList)))
                    return GetMinuteSheetDocListEntity(commonEntity as MinuteSheetDocList);

                else if (commonEntity.GetType().Equals(typeof(MinuteSheetPartyRepInfo)))
                    return GetMinuteSheetPartyRepInfoEntity(commonEntity as MinuteSheetPartyRepInfo);

                else if (commonEntity.GetType().Equals(typeof(MinuteSheetPartySolicitorInfo)))
                    return GetMinuteSheetPartySolicitorInfoEntity(commonEntity as MinuteSheetPartySolicitorInfo);

                else if (commonEntity.GetType().Equals(typeof(LawFirm)))
                    return GetLawFirmEntity(commonEntity as LawFirm);

                else if (commonEntity.GetType().Equals(typeof(NoticeToReferAffidavit)))
                    return GetNoticeToReferAffidavitEntity(commonEntity as NoticeToReferAffidavit);

                else if (commonEntity.GetType().Equals(typeof(CheckListComments)))
                    return GetCheckListCommentEntity(commonEntity as CheckListComments);

                else if (commonEntity.GetType().Equals(typeof(RefOrderJOInfo)))
                    return GetRefOrderJOInfoEntity(commonEntity as RefOrderJOInfo);

                else if (commonEntity.GetType().Equals(typeof(InterfaceNBSReport)))
                    return GetInterfaceNBSReportEntity(commonEntity as InterfaceNBSReport);

                else if (commonEntity.GetType().Equals(typeof(ForeignUserRegistrationDetails)))
                    return (GetForeignUserRegistrationDetailsEntity(commonEntity as ForeignUserRegistrationDetails));

                else if (commonEntity.GetType().Equals(typeof(ForeignUserRegAddressDetails)))
                    return (GetForeignUserRegAddressDetailsEntity(commonEntity as ForeignUserRegAddressDetails));

                else if (commonEntity.GetType().Equals(typeof(ForeignUserPracticeInformation)))
                    return (GetForeignUserPracticeInformationEntity(commonEntity as ForeignUserPracticeInformation));

                else if (commonEntity.GetType().Equals(typeof(RegistrationOfForeignLawyer)))
                    return (GetRegistrationOfForeignLawyerEntity(commonEntity as RegistrationOfForeignLawyer));

                else if (commonEntity.GetType().Equals(typeof(RFLValidityAndNotification)))
                    return (GetRFLValidityAndNotificationEntity(commonEntity as RFLValidityAndNotification));

                else if (commonEntity.GetType().Equals(typeof(RequestForExemption)))
                    return(GetRequestForExemptionEntity(commonEntity as RequestForExemption));

                else if (commonEntity.GetType().Equals(typeof(FeeCollectionDetail)))
                    return (GetFeeCollectionDetailEntity(commonEntity as FeeCollectionDetail));

                else if (commonEntity.GetType().Equals(typeof(OutgoingCorrespondenceInfo)))
                    return (GetOutgoingCorrespondenceInfoEntity(commonEntity as OutgoingCorrespondenceInfo));

                else if (commonEntity.GetType().Equals(typeof(OutgoingCorrespondenceCourtFee)))
                    return (GetOutgoingCorrespondenceCourtFeeEntity(commonEntity as OutgoingCorrespondenceCourtFee));

                else if (commonEntity.GetType().Equals(typeof(LawFirmRegistration)))
                    return (GetLawFirmRegistrationEntity(commonEntity as LawFirmRegistration));

                else if (commonEntity.GetType().Equals(typeof(LegalExperienceInfo)))
                    return GetLegalExperienceInfoEntity(commonEntity as LegalExperienceInfo);

                else if (commonEntity.GetType().Equals(typeof(DocLegalExperienceInfo)))
                    return GetDocLegalExperienceInfoEntity(commonEntity as DocLegalExperienceInfo);

                else if (commonEntity.GetType().Equals(typeof(CaseLegalExperienceInfo)))
                    return GetCaseLegalExperienceInfoEntity(commonEntity as CaseLegalExperienceInfo);

                else if (commonEntity.GetType().Equals(typeof(CORSolicitorReg)))
                    return GetCORSolicitorRegEntity(commonEntity as CORSolicitorReg);

                else if (commonEntity.GetType().Equals(typeof(CORSolicitorRegDetails)))
                    return GetCORSolicitorRegDetailsEntity(commonEntity as CORSolicitorRegDetails);

                else if (commonEntity.GetType().Equals(typeof(DocCaseCounterClaimDetails)))
                    return GetDocCaseCounterClaimDetailsEntity(commonEntity as DocCaseCounterClaimDetails);

                else if (commonEntity.GetType().Equals(typeof(DocCaseCounterClaim)))
                    return GetDocCaseCounterClaimEntity(commonEntity as DocCaseCounterClaim);

                else if (commonEntity.GetType().Equals(typeof(CaseCounterClaim)))
                    return GetCaseCounterClaimEntity(commonEntity as CaseCounterClaim);

                else if (commonEntity.GetType().Equals(typeof(CaseCounterClaimDetails)))
                    return GetCaseCounterClaimDetailsEntity(commonEntity as CaseCounterClaimDetails);


                else
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetCommonEntity method in CommonMapper.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCommonEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the <see cref="DeceasedAliasEntity"/>
        /// </summary>
        /// <param name="deceasedAlias">The DeceasedAlias.</param>
        /// <returns></returns>
        public static DeceasedAliasEntity GetDeceasedAliasEntity(DeceasedAlias deceasedAlias)
        {
            DeceasedAliasEntity deceasedAliasEntity = null;
            try
            {
                deceasedAliasEntity = Mapper.Map<DeceasedAlias, DeceasedAliasEntity>(deceasedAlias);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDeceasedAliasEntity", ex);
                throw;
            }
            return deceasedAliasEntity;
        }

        /// <summary>
        /// Gets the <see cref="DeceasedIdentificationsEntity"/>
        /// </summary>
        /// <param name="deceasedIdentification">The DeceasedIdentification.</param>
        /// <returns></returns>
        public static DeceasedIdentificationsEntity GetDeceasedIdentificationsEntity(DeceasedIdentification deceasedIdentification)
        {
            DeceasedIdentificationsEntity deceasedIdentificationsEntity = null;
            try
            {
                deceasedIdentificationsEntity = Mapper.Map<DeceasedIdentification, DeceasedIdentificationsEntity>(deceasedIdentification);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDeceasedIdentificationsEntity", ex);
                throw;
            }
            return deceasedIdentificationsEntity;
        }

        /// <summary>
        /// Gets the <see cref="DeceasedInfoEntity"/>
        /// </summary>
        /// <param name="deceasedInfo">The DeceasedInfo.</param>
        /// <returns></returns>
        public static DeceasedInfoEntity GetDeceasedInfoEntity(DeceasedInfo deceasedInfo)
        {
            DeceasedInfoEntity deceasedInfoEntity = null;
            try
            {
                deceasedInfoEntity = Mapper.Map<DeceasedInfo, DeceasedInfoEntity>(deceasedInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDeceasedInfoEntity", ex);
                throw;
            }
            return deceasedInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="DegreeInfoEntity"/>
        /// </summary>
        /// <param name="degreeInfo">The DegreeInfo.</param>
        /// <returns></returns>
        public static DegreeInfoEntity GetDegreeInfoEntity(DegreeInfo degreeInfo)
        {
            DegreeInfoEntity degreeInfoEntity = null;
            try
            {
                degreeInfoEntity = Mapper.Map<DegreeInfo, DegreeInfoEntity>(degreeInfo);
                degreeInfoEntity.MAASLawDegree = Mapper.Map<MAASLawDegree, MAASLawDegreeEntity>(degreeInfo.MAASLawDegree);
                degreeInfoEntity.MAASUniversity = Mapper.Map<MAASUniversity, MAASUniversityEntity>(degreeInfo.MAASUniversity);
                degreeInfoEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(degreeInfo.MCountry);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDegreeInfoEntity", ex);
                throw;
            }
            return degreeInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="DivorceInfoEntity"/> from <see cref="DivorceInfo"/> input.
        /// </summary>
        /// <param name="divorceInfo"><see cref="DivorceInfo"/></param>
        /// <returns>Returns <see cref="DivorceInfoEntity"/>, else null.</returns>
        public static DivorceInfoEntity GetDivorceInfoEntity(DivorceInfo divorceInfo)
        {
            DivorceInfoEntity divorceInfoEntity = null;

            try
            {
                if (divorceInfo != null)
                {
                    divorceInfoEntity = Mapper.Map<DivorceInfo, DivorceInfoEntity>(divorceInfo);
                    divorceInfoEntity.PlaceOfMarriage = Mapper.Map<MCountry, MCountryEntity>(divorceInfo.MCountryPlaceOfMarriage);
                    divorceInfoEntity.PlaceOfSolemnization = Mapper.Map<MCountry, MCountryEntity>(divorceInfo.MCountryPlaceOfSolemnization);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDivorceInfoEntity", ex);
                throw;
            }

            return divorceInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocAppProcessByExAgency"/> from <see cref="DocAppProcessByExAgency"/> input.
        /// </summary>
        /// <param name="DocAppProcessByExAgency"><see cref="DocAppProcessByExAgency"/></param>
        /// <returns>Returns <see cref="DocAppProcessByExAgency"/>, else null.</returns>
        public static DocAppProcessByExAgencyEntity GetDocAppProcessByExAgencyEntity(DocAppProcessByExAgency docAppProcessByExAgency)
        {
            DocAppProcessByExAgencyEntity docAppProcessByExAgencyEntity = null;

            try
            {
                if (docAppProcessByExAgency != null)
                {
                    docAppProcessByExAgencyEntity = Mapper.Map<DocAppProcessByExAgency, DocAppProcessByExAgencyEntity>(docAppProcessByExAgency);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPCAppDetailsFromSALEntity", ex);
                throw;
            }

            return docAppProcessByExAgencyEntity;
        }

        /// <summary>
        /// Gets the <see cref="EmploymentInfo"/> from <see cref="EmploymentInfo"/> input.
        /// </summary>
        /// <param name="EmploymentInfo"><see cref="EmploymentInfo"/></param>
        /// <returns>Returns <see cref="EmploymentInfoEntity"/>, else null.</returns>
        public static EmploymentInfoEntity GetEmploymentInfoEntity(EmploymentInfo employmentInfo)
        {
            EmploymentInfoEntity employmentInfoEntity = null;

            try
            {
                if (employmentInfo != null)
                {
                    employmentInfoEntity = Mapper.Map<EmploymentInfo, EmploymentInfoEntity>(employmentInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetEmploymentInfoEntity", ex);
                throw;
            }

            return employmentInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="FilingFeeDetailEntity"/> from <see cref="FilingFeeDetail"/> input.
        /// </summary>
        /// <param name="filingFeeDetail"><see cref="FilingFeeDetail"/></param>
        /// <returns>Returns <see cref="FilingFeeDetailEntity"/>, else null.</returns>
        public static FilingFeeDetailEntity GetFilingFeeDetailEntity(FilingFeeDetail filingFeeDetail)
        {
            FilingFeeDetailEntity filingFeeDetailEntity = null;

            try
            {
                if (filingFeeDetail != null)
                {
                    filingFeeDetailEntity = Mapper.Map<FilingFeeDetail, FilingFeeDetailEntity>(filingFeeDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetFilingFeeDetailEntity", ex);
                throw;
            }

            return filingFeeDetailEntity;
        }

        /*
        /// <summary>
        /// Gets the <see cref="ForeignLawPractice"/> from <see cref="ForeignLawPractice"/> input.
        /// </summary>
        /// <param name="ForeignLawPractice"><see cref="ForeignLawPractice"/></param>
        /// <returns>Returns <see cref="ForeignLawPracticeEntity"/>, else null.</returns>
        public static ForeignLawPracticeEntity GetForeignLawPracticeEntity(ForeignLawPractice foreignLawPractice)
        {
            ForeignLawPracticeEntity foreignLawPracticeEntity = null;

            try
            {
                if (foreignLawPractice != null)
                {
                    foreignLawPracticeEntity = Mapper.Map<ForeignLawPractice, ForeignLawPracticeEntity>(foreignLawPractice);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetForeignLawPracticeEntity", ex);
                throw;
            }

            return foreignLawPracticeEntity;
        }*/
        /// <summary>
        /// Gets the <see cref="ForeignLawPracticeRegAddress"/> from <see cref="ForeignLawPracticeRegAddress"/> input.
        /// </summary>
        /// <param name="ForeignLawPracticeRegAddress"><see cref="ForeignLawPracticeRegAddress"/></param>
        /// <returns>Returns <see cref="ForeignLawPracticeRegAddressEntity"/>, else null.</returns>
        public static ForeignLawPracticeRegAddressEntity GetForeignLawPracticeRegAddressEntity(ForeignLawPracticeRegAddress foreignLawPracticeRegAddress)
        {
            ForeignLawPracticeRegAddressEntity foreignLawPracticeRegAddressEntity = null;

            try
            {
                if (foreignLawPracticeRegAddress != null)
                {
                    foreignLawPracticeRegAddressEntity = Mapper.Map<ForeignLawPracticeRegAddress, ForeignLawPracticeRegAddressEntity>(foreignLawPracticeRegAddress);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetForeignLawPracticeRegAddressEntity", ex);
                throw;
            }

            return foreignLawPracticeRegAddressEntity;
        }

        /// <summary>
        /// Gets the <see cref="ForeignLawPracticeReg"/> from <see cref="ForeignLawPracticeReg"/> input.
        /// </summary>
        /// <param name="ForeignLawPracticeReg"><see cref="ForeignLawPracticeReg"/></param>
        /// <returns>Returns <see cref="ForeignLawPracticeRegEntity"/>, else null.</returns>
        public static ForeignLawPracticeRegEntity GetForeignLawPracticeRegEntity(ForeignLawPracticeReg foreignLawPracticeReg)
        {
            ForeignLawPracticeRegEntity foreignLawPracticeRegEntity = null;

            try
            {
                if (foreignLawPracticeReg != null)
                {
                    foreignLawPracticeRegEntity = Mapper.Map<ForeignLawPracticeReg, ForeignLawPracticeRegEntity>(foreignLawPracticeReg);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetForeignLawPracticeRegEntity", ex);
                throw;
            }

            return foreignLawPracticeRegEntity;
        }

        /// <summary>
        /// Gets the <see cref="ForeignLPSolicitorRegDetailEntity"/> from <see cref="ForeignLPSolicitorRegDetail"/> input.
        /// </summary>
        /// <param name="foreignLPSolicitorRegDetail"><see cref="ForeignLPSolicitorRegDetail"/></param>
        /// <returns>Returns <see cref="ForeignLPSolicitorRegDetailEntity"/>, else null.</returns>
        public static ForeignLPSolicitorRegDetailEntity GetForeignLPSolicitorRegDetailEntity(ForeignLPSolicitorRegDetail foreignLPSolicitorRegDetail)
        {
            ForeignLPSolicitorRegDetailEntity foreignLPSolicitorRegDetailEntity = null;

            try
            {
                if (foreignLPSolicitorRegDetail != null)
                {
                    foreignLPSolicitorRegDetailEntity = Mapper.Map<ForeignLPSolicitorRegDetail, ForeignLPSolicitorRegDetailEntity>(foreignLPSolicitorRegDetail);
                    foreignLPSolicitorRegDetailEntity.MLawPracticeType = Mapper.Map<MLawPracticeType, MLawPracticeTypeEntity>(foreignLPSolicitorRegDetail.MLawPracticeType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetForeignLPSolicitorRegDetailEntity", ex);
                throw;
            }

            return foreignLPSolicitorRegDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="ForeignLPSolicitorReg"/> from <see cref="ForeignLPSolicitorReg"/> input.
        /// </summary>
        /// <param name="ForeignLPSolicitorReg"><see cref="ForeignLPSolicitorReg"/></param>
        /// <returns>Returns <see cref="ForeignLPSolicitorRegEntity"/>, else null.</returns>
        public static ForeignLPSolicitorRegEntity GetForeignLPSolicitorRegEntity(ForeignLPSolicitorReg foreignLPSolicitorReg)
        {
            ForeignLPSolicitorRegEntity foreignLPSolicitorRegEntity = null;

            try
            {
                if (foreignLPSolicitorReg != null)
                {
                    foreignLPSolicitorRegEntity = Mapper.Map<ForeignLPSolicitorReg, ForeignLPSolicitorRegEntity>(foreignLPSolicitorReg);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetForeignLPSolicitorRegEntity", ex);
                throw;
            }

            return foreignLPSolicitorRegEntity;
        }

        /// <summary>
        /// Gets the <see cref="GroundInfoEntity"/> from <see cref="GroundInfo"/> input.
        /// </summary>
        /// <param name="groundInfo"><see cref="GroundInfo"/></param>
        /// <returns>Returns <see cref="GroundInfoEntity"/>, else null.</returns>
        public static GroundInfoEntity GetGroundInfoEntity(GroundInfo groundInfo)
        {
            GroundInfoEntity groundInfoEntity = null;

            try
            {
                if (groundInfo != null)
                {
                    groundInfoEntity = Mapper.Map<GroundInfo, GroundInfoEntity>(groundInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetGroundInfoEntity", ex);
                throw;
            }

            return groundInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="InfantInfoEntity"/>
        /// </summary>
        /// <param name="infantInfo">The InfantInfo.</param>
        /// <returns></returns>
        public static InfantInfoEntity GetInfantInfoEntity(InfantInfo infantInfo)
        {
            InfantInfoEntity infantInfoEntity = null;
            try
            {
                infantInfoEntity = Mapper.Map<InfantInfo, InfantInfoEntity>(infantInfo);
                infantInfoEntity.BirthCountry = Mapper.Map<MCountry, MCountryEntity>(infantInfo.MBirthCountry);
                infantInfoEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(infantInfo.MCountry);
                infantInfoEntity.MGender = Mapper.Map<MGender, MGenderEntity>(infantInfo.MGender);
                infantInfoEntity.MNationality = Mapper.Map<MNationality, MNationalityEntity>(infantInfo.MNationality);
                infantInfoEntity.MRace = Mapper.Map<MRace, MRaceEntity>(infantInfo.MRace);
                infantInfoEntity.ResidenceCountry = Mapper.Map<MCountry, MCountryEntity>(infantInfo.MResidenceCountry);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetInfantInfoEntity", ex);
                throw;
            }
            return infantInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="LawFirmEntity"/> from <see cref="LawFirm"/> input.
        /// </summary>
        /// <param name="LawFirm"><see cref="LawFirm"/></param>
        /// <returns>Returns <see cref="LawFirmEntity"/>, else null.</returns>
        public static LawFirmEntity GetLawFirmEntity(LawFirm lawFirm)
        {
            LawFirmEntity lawFirmEntity = null;

            try
            {
                if (lawFirm != null)
                {
                    lawFirmEntity = Mapper.Map<LawFirm, LawFirmEntity>(lawFirm);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetLawFirmEntity", ex);
                throw;
            }

            return lawFirmEntity;
        }

        /// <summary>
        /// Gets the <see cref="LegalExperienceInfoEntity"/>
        /// </summary>
        /// <param name="legalExperienceInfo">The LegalExperienceInfo.</param>
        /// <returns></returns>
        public static LegalExperienceInfoEntity GetLegalExperienceInfoEntity(LegalExperienceInfo legalExperienceInfo)
        {
            LegalExperienceInfoEntity legalExperienceInfoEntity = null;
            try
            {
                legalExperienceInfoEntity = Mapper.Map<LegalExperienceInfo, LegalExperienceInfoEntity>(legalExperienceInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetLegalExperienceInfoEntity", ex);
                throw;
            }
            return legalExperienceInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="LegislationProvisionsEntity"/> from <see cref="LegislationProvision"/> input.
        /// </summary>
        /// <param name="legislationProvision"><see cref="LegislationProvision"/></param>
        /// <returns>Returns <see cref="LegislationProvisionsEntity"/>, else null.</returns>
        public static LegislationProvisionsEntity GetLegislationProvisionEntity(LegislationProvision legislationProvision)
        {
            LegislationProvisionsEntity legislationProvisionsEntity = null;

            try
            {
                if (legislationProvision != null)
                {
                    legislationProvisionsEntity = Mapper.Map<LegislationProvision, LegislationProvisionsEntity>(legislationProvision);
                    legislationProvisionsEntity.MProvision = Mapper.Map<MProvision, MProvisionEntity>(legislationProvision.MProvision);
                    legislationProvisionsEntity.MLegislationAct = Mapper.Map<MLegislationAct, MLegislationActEntity>(legislationProvision.MLegislationAct);
                    legislationProvisionsEntity.MSubProvision = Mapper.Map<MSubProvision, MSubProvisionEntity>(legislationProvision.MSubProvision);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLegislationProvisionEntity", ex);
                throw;
            }

            return legislationProvisionsEntity;
        }

        /// <summary>
        /// Gets the <see cref="LiquidatedClaimEntity"/> from <see cref="LiquidatedClaim"/> input.
        /// </summary>
        /// <param name="liquidatedClaim"><see cref="LiquidatedClaim"/></param>
        /// <returns>Returns <see cref="LiquidatedClaimEntity"/>, else null.</returns>
        public static LiquidatedClaimEntity GetLiquidatedClaimEntity(LiquidatedClaim liquidatedClaim)
        {
            LiquidatedClaimEntity liquidatedClaimEntity = null;

            try
            {
                if (liquidatedClaim != null)
                {
                    liquidatedClaimEntity = Mapper.Map<LiquidatedClaim, LiquidatedClaimEntity>(liquidatedClaim);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLiquidatedClaimEntity", ex);
                throw;
            }

            return liquidatedClaimEntity;
        }

        /// <summary>
        /// Gets the <see cref="LiquidatorAddressEntity"/> from <see cref="LiquidatorAddress"/> input.
        /// </summary>
        /// <param name="liquidatorAddress"><see cref="LiquidatorAddress"/></param>
        /// <returns>Returns <see cref="LiquidatorAddressEntity"/>, else null.</returns>
        public static LiquidatorAddressEntity GetLiquidatorAddressEntity(LiquidatorAddress liquidatorAddress)
        {
            LiquidatorAddressEntity liquidatorAddressEntity = null;

            try
            {
                if (liquidatorAddress != null)
                {
                    liquidatorAddressEntity = Mapper.Map<LiquidatorAddress, LiquidatorAddressEntity>(liquidatorAddress);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLiquidatorAddressEntity", ex);
                throw;
            }

            return liquidatorAddressEntity;
        }

        /// <summary>
        /// Gets the <see cref="LiquidatorAliasEntity"/> from <see cref="LiquidatorAlias"/> input.
        /// </summary>
        /// <param name="liquidatorAlias"><see cref="LiquidatorAlias"/></param>
        /// <returns>Returns <see cref="LiquidatorAliasEntity"/>, else null.</returns>
        public static LiquidatorAliasEntity GetLiquidatorAliasEntity(LiquidatorAlias liquidatorAlias)
        {
            LiquidatorAliasEntity liquidatorAliasEntity = null;

            try
            {
                if (liquidatorAlias != null)
                {
                    liquidatorAliasEntity = Mapper.Map<LiquidatorAlias, LiquidatorAliasEntity>(liquidatorAlias);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLiquidatorAliasEntity", ex);
                throw;
            }

            return liquidatorAliasEntity;
        }

        /// <summary>
        /// Gets the <see cref="LiquidatorEntity"/> from <see cref="Liquidator"/> input.
        /// </summary>
        /// <param name="liquidator"><see cref="Liquidator"/></param>
        /// <returns>Returns <see cref="LiquidatorEntity"/>, else null.</returns>
        public static LiquidatorEntity GetLiquidatorEntity(Liquidator liquidator)
        {
            LiquidatorEntity liquidatorEntity = null;

            try
            {
                if (liquidator != null)
                {
                    liquidatorEntity = Mapper.Map<Liquidator, LiquidatorEntity>(liquidator);
                    liquidatorEntity.MCompanyIdType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(liquidator.MLCompanyIdType);
                    liquidatorEntity.MCountryOfRegistration = Mapper.Map<MCountry, MCountryEntity>(liquidator.MLIdCountryOfRegistration);
                    liquidatorEntity.MIdCountry = Mapper.Map<MCountry, MCountryEntity>(liquidator.MLIdCountry);
                    liquidatorEntity.MEntityType = Mapper.Map<MEntityType, MEntityTypeEntity>(liquidator.MEntityType);
                    liquidatorEntity.MGender = Mapper.Map<MGender, MGenderEntity>(liquidator.MGender);
                    liquidatorEntity.MPersonIdType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(liquidator.MLPersonIdType);
                    liquidatorEntity.MPersonIdGroup = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(liquidator.MPersonIDGroup);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLiquidatorEntity", ex);
                throw;
            }

            return liquidatorEntity;
        }

        /// <summary>
        /// Gets the <see cref="LiquidatorPICAddressEntity"/> from <see cref="LiquidatorPICAddress"/> input.
        /// </summary>
        /// <param name="liquidatorPICAddress"><see cref="LiquidatorPICAddress"/></param>
        /// <returns>Returns <see cref="LiquidatorPICAddressEntity"/>, else null.</returns>
        public static LiquidatorPICAddressEntity GetLiquidatorPICAddressEntity(LiquidatorPICAddress liquidatorPICAddress)
        {
            LiquidatorPICAddressEntity liquidatorPICAddressEntity = null;

            try
            {
                if (liquidatorPICAddress != null)
                {
                    liquidatorPICAddressEntity = Mapper.Map<LiquidatorPICAddress, LiquidatorPICAddressEntity>(liquidatorPICAddress);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLiquidatorPICAddressEntity", ex);
                throw;
            }

            return liquidatorPICAddressEntity;
        }

        /// <summary>
        /// Gets the <see cref="LiquidatorPICAliasEntity"/> from <see cref="LiquidatorPICAlias"/> input.
        /// </summary>
        /// <param name="liquidatorPICAlias"><see cref="LiquidatorPICAlias"/></param>
        /// <returns>Returns <see cref="LiquidatorPICAliasEntity"/>, else null.</returns>
        public static LiquidatorPICAliasEntity GetLiquidatorPICAliasEntity(LiquidatorPICAlias liquidatorPICAlias)
        {
            LiquidatorPICAliasEntity liquidatorPICAliasEntity = null;

            try
            {
                if (liquidatorPICAlias != null)
                {
                    liquidatorPICAliasEntity = Mapper.Map<LiquidatorPICAlias, LiquidatorPICAliasEntity>(liquidatorPICAlias);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLiquidatorPICAliasEntity", ex);
                throw;
            }

            return liquidatorPICAliasEntity;
        }

        /// <summary>
        /// Gets the <see cref="LiquidatorPICEntity"/> from <see cref="LiquidatorPIC"/> input.
        /// </summary>
        /// <param name="liquidatorPIC"><see cref="LiquidatorPIC"/></param>
        /// <returns>Returns <see cref="LiquidatorPICEntity"/>, else null.</returns>
        public static LiquidatorPICEntity GetLiquidatorPICEntity(LiquidatorPIC liquidatorPIC)
        {
            LiquidatorPICEntity liquidatorPICEntity = null;

            try
            {
                if (liquidatorPIC != null)
                {
                    liquidatorPICEntity = Mapper.Map<LiquidatorPIC, LiquidatorPICEntity>(liquidatorPIC);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLiquidatorPICEntity", ex);
                throw;
            }

            return liquidatorPICEntity;
        }

        /// <summary>
        /// Gets the <see cref="MinuteSheetDocListEntity"/>
        /// </summary>
        /// <param name="minuteSheetDocList">The MinuteSheetDocList.</param>
        /// <returns></returns>
        public static MinuteSheetDocListEntity GetMinuteSheetDocListEntity(MinuteSheetDocList minuteSheetDocList)
        {
            MinuteSheetDocListEntity minuteSheetDocListEntity = null;
            try
            {
                minuteSheetDocListEntity = Mapper.Map<MinuteSheetDocList, MinuteSheetDocListEntity>(minuteSheetDocList);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMinuteSheetDocListEntity", ex);
                throw;
            }
            return minuteSheetDocListEntity;
        }

        /// <summary>
        /// Gets the <see cref="MinuteSheetFamilyRelatedInfoEntity"/>
        /// </summary>
        /// <param name="minuteSheetFamilyRelatedInfo">The MinuteSheetFamilyRelatedInfo.</param>
        /// <returns></returns>
        public static MinuteSheetFamilyRelatedInfoEntity GetMinuteSheetFamilyRelatedInfoEntity(MinuteSheetFamilyRelatedInfo minuteSheetFamilyRelatedInfo)
        {
            MinuteSheetFamilyRelatedInfoEntity minuteSheetFamilyRelatedInfoEntity = null;
            try
            {
                minuteSheetFamilyRelatedInfoEntity = Mapper.Map<MinuteSheetFamilyRelatedInfo, MinuteSheetFamilyRelatedInfoEntity>(minuteSheetFamilyRelatedInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMinuteSheetFamilyRelatedInfoEntity", ex);
                throw;
            }
            return minuteSheetFamilyRelatedInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="MinuteSheetGroundInfoEntity"/>
        /// </summary>
        /// <param name="minuteSheetGroundInfo">The MinuteSheetGroundInfo.</param>
        /// <returns></returns>
        public static MinuteSheetGroundInfoEntity GetMinuteSheetGroundInfoEntity(MinuteSheetGroundInfo minuteSheetGroundInfo)
        {
            MinuteSheetGroundInfoEntity minuteSheetGroundInfoEntity = null;
            try
            {
                minuteSheetGroundInfoEntity = Mapper.Map<MinuteSheetGroundInfo, MinuteSheetGroundInfoEntity>(minuteSheetGroundInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMinuteSheetGroundInfoEntity", ex);
                throw;
            }
            return minuteSheetGroundInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="MinuteSheetInfoEntity"/>
        /// </summary>
        /// <param name="minuteSheetInfo">The MinuteSheetInfo.</param>
        /// <returns></returns>
        public static MinuteSheetInfoEntity GetMinuteSheetInfoEntity(MinuteSheetInfo minuteSheetInfo)
        {
            MinuteSheetInfoEntity minuteSheetInfoEntity = null;
            try
            {
                minuteSheetInfoEntity = Mapper.Map<MinuteSheetInfo, MinuteSheetInfoEntity>(minuteSheetInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMinuteSheetInfoEntity", ex);
                throw;
            }
            return minuteSheetInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="MinuteSheetPartyRepInfoEntity"/>
        /// </summary>
        /// <param name="minuteSheetPartyRepInfo">The MinuteSheetPartyRepInfo.</param>
        /// <returns></returns>
        public static MinuteSheetPartyRepInfoEntity GetMinuteSheetPartyRepInfoEntity(MinuteSheetPartyRepInfo minuteSheetPartyRepInfo)
        {
            MinuteSheetPartyRepInfoEntity minuteSheetPartyRepInfoEntity = null;
            try
            {
                minuteSheetPartyRepInfoEntity = Mapper.Map<MinuteSheetPartyRepInfo, MinuteSheetPartyRepInfoEntity>(minuteSheetPartyRepInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMinuteSheetPartyRepInfoEntity", ex);
                throw;
            }
            return minuteSheetPartyRepInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="MinuteSheetPartySolicitorInfoEntity"/>
        /// </summary>
        /// <param name="minuteSheetPartySolicitorInfo">The MinuteSheetPartySolicitorInfo.</param>
        /// <returns></returns>
        public static MinuteSheetPartySolicitorInfoEntity GetMinuteSheetPartySolicitorInfoEntity(MinuteSheetPartySolicitorInfo minuteSheetPartySolicitorInfo)
        {
            MinuteSheetPartySolicitorInfoEntity minuteSheetPartySolicitorInfoEntity = null;
            try
            {
                minuteSheetPartySolicitorInfoEntity = Mapper.Map<MinuteSheetPartySolicitorInfo, MinuteSheetPartySolicitorInfoEntity>(minuteSheetPartySolicitorInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMinuteSheetPartySolicitorInfoEntity", ex);
                throw;
            }
            return minuteSheetPartySolicitorInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="NatureOfAppealEntity"/> from <see cref="NatureOfAppeal"/> input.
        /// </summary>
        /// <param name="natureOfAppeal"><see cref="NatureOfAppeal"/></param>
        /// <returns>Returns <see cref="NatureOfAppealEntity"/>, else null.</returns>
        public static NatureOfAppealEntity GetNatureOfAppealEntity(NatureOfAppeal natureOfAppeal)
        {
            NatureOfAppealEntity natureOfAppealEntity = null;

            try
            {
                if (natureOfAppeal != null)
                {
                    natureOfAppealEntity = Mapper.Map<NatureOfAppeal, NatureOfAppealEntity>(natureOfAppeal);
                    natureOfAppealEntity.MNatureOfAppeal = Mapper.Map<MNatureOfAppeal, MNatureOfAppealEntity>(natureOfAppeal.MNatureOfAppeal);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetNatureOfAppealEntity", ex);
                throw;
            }

            return natureOfAppealEntity;
        }

        /// <summary>
        /// Gets the <see cref="NatureOfApplicationEntity"/> from <see cref="NatureOfApplication"/> input.
        /// </summary>
        /// <param name="natureOfApplication"><see cref="NatureOfApplication"/></param>
        /// <returns>Returns <see cref="NatureOfApplicationEntity"/>, else null.</returns>
        public static NatureOfApplicationEntity GetNatureOfApplicationEntity(NatureOfApplication natureOfApplication)
        {
            NatureOfApplicationEntity natureOfApplicationEntity = null;

            try
            {
                if (natureOfApplication != null)
                {
                    natureOfApplicationEntity = Mapper.Map<NatureOfApplication, NatureOfApplicationEntity>(natureOfApplication);
                    natureOfApplicationEntity.MNOACodeEntity = Mapper.Map<MNOACode, MNOACodeEntity>(natureOfApplication.MNOACode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetNatureOfApplicationEntity", ex);
                throw;
            }

            return natureOfApplicationEntity;
        }

        /// <summary>
        /// Gets the <see cref="NatureOfCaseEntity"/> from <see cref="NatureOfCase"/> input.
        /// </summary>
        /// <param name="natureOfCase"><see cref="NatureOfCase"/></param>
        /// <returns>Returns <see cref="NatureOfCaseEntity"/>, else null.</returns>
        public static NatureOfCaseEntity GetNatureOfCaseEntity(NatureOfCase natureOfCase)
        {
            NatureOfCaseEntity natureOfCaseEntity = null;

            try
            {
                if (natureOfCase != null)
                {
                    natureOfCaseEntity = Mapper.Map<NatureOfCase, NatureOfCaseEntity>(natureOfCase);
                    natureOfCaseEntity.MNatureOfCase = Mapper.Map<MNOC, MNOCEntity>(natureOfCase.MNOC);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetNatureOfCaseEntity", ex);
                throw;
            }

            return natureOfCaseEntity;
        }

        public static NotPaymenttoCourtDocDetailEntity GetNotPaymenttoCourtDocDetailEntity(NotPaymentToCourtDocDetail notPaymentToCourtDocDetail)
        {
            NotPaymenttoCourtDocDetailEntity notPaymenttoCourtDocDetailEntity = null;
            try
            {
                if (notPaymentToCourtDocDetail != null)
                {
                    notPaymenttoCourtDocDetailEntity = Mapper.Map<NotPaymentToCourtDocDetail, NotPaymenttoCourtDocDetailEntity>(notPaymentToCourtDocDetail);
                    notPaymenttoCourtDocDetailEntity.MCurrency = Mapper.Map<MCurrency, MCurrencyEntity>(notPaymentToCourtDocDetail.MCurrency);
                    notPaymenttoCourtDocDetailEntity.PICurrencyCode = Mapper.Map<MCurrency, MCurrencyEntity>(notPaymentToCourtDocDetail.PICurrencyCode);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetNotPaymenttoCourtDocDetailEntity", ex);
                throw;
            }
            return notPaymenttoCourtDocDetailEntity;
        }

        public static OrdersMadeEntity GetOrdersMadeEntity(OrdersMade ordersMade)
        {
            OrdersMadeEntity ordersMadeEntity = null;
            try
            {
                ordersMadeEntity = Mapper.Map<OrdersMade, OrdersMadeEntity>(ordersMade);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOrdersMadeEntity", ex);
                throw;
            }
            return ordersMadeEntity;
        }

        /// <summary>
        /// Gets the <see cref="OriginatingCaseEntity"/> from <see cref="OriginatingCase"/> input.
        /// </summary>
        /// <param name="originatingCase"><see cref="OriginatingCase"/></param>
        /// <returns>Returns <see cref="OriginatingCaseEntity"/>, else null.</returns>
        public static OriginatingCaseEntity GetOriginatingCaseEntity(OriginatingCase originatingCase)
        {
            OriginatingCaseEntity originatingCaseEntity = null;

            try
            {
                if (originatingCase != null)
                {
                    originatingCaseEntity = Mapper.Map<OriginatingCase, OriginatingCaseEntity>(originatingCase);
                    originatingCaseEntity.CourtId = Mapper.Map<MCourtType, MCourtTypeEntity>(originatingCase.MCourtType);
                    
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetOriginatingCaseEntity", ex);
                throw;
            }

            return originatingCaseEntity;
        }

        /// <summary>
        /// Gets the <see cref="OtherITMOEntity"/> from <see cref="OtherITMO"/> input.
        /// </summary>
        /// <param name="otherITMO"><see cref="OtherITMO"/></param>
        /// <returns>Returns <see cref="OtherITMOEntity"/>, else null.</returns>
        public static OtherITMOEntity GetOtherITMOEntity(OtherITMO otherITMO)
        {
            OtherITMOEntity otherITMOEntity = null;

            try
            {
                if (otherITMO != null)
                {
                    otherITMOEntity = Mapper.Map<OtherITMO, OtherITMOEntity>(otherITMO);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetOtherITMOEntity", ex);
                throw;
            }

            return otherITMOEntity;
        }

        /// <summary>
        /// Gets the <see cref="OtherReliefsClaimEntity"/> from <see cref="OtherReliefsClaim"/> input.
        /// </summary>
        /// <param name="otherReliefsClaim"><see cref="OtherReliefsClaim"/></param>
        /// <returns>Returns <see cref="OtherReliefsClaimEntity"/>, else null.</returns>
        public static OtherReliefsClaimEntity GetOtherReliefsClaimEntity(OtherReliefsClaim otherReliefsClaim)
        {
            OtherReliefsClaimEntity otherReliefsClaimEntity = null;

            try
            {
                if (otherReliefsClaim != null)
                {
                    otherReliefsClaimEntity = Mapper.Map<OtherReliefsClaim, OtherReliefsClaimEntity>(otherReliefsClaim);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetOtherReliefsClaimEntity", ex);
                throw;
            }

            return otherReliefsClaimEntity;
        }

        /// <summary>
        /// Gets the <see cref="OutgoingCorrespondenceCourtFeeEntity"/>
        /// </summary>
        /// <param name="OutgoingCorrespondenceCourtFee">The OutgoingCorrespondenceCourtFee.</param>
        /// <returns></returns>
        public static OutgoingCorrespondenceCourtFeeEntity GetOutgoingCorrespondenceCourtFeeEntity(OutgoingCorrespondenceCourtFee outgoingCorrespondenceCourtFee)
        {
            OutgoingCorrespondenceCourtFeeEntity outgoingCorrespondenceCourtFeeEntity = null;
            try
            {
                outgoingCorrespondenceCourtFeeEntity = Mapper.Map<OutgoingCorrespondenceCourtFee, OutgoingCorrespondenceCourtFeeEntity>(outgoingCorrespondenceCourtFee);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOutgoingCorrespondenceCourtFeeEntity", ex);
                throw;
            }
            return outgoingCorrespondenceCourtFeeEntity;
        }

        /// <summary>
        /// Gets the <see cref="OutgoingCorrespondenceInfoEntity"/>
        /// </summary>
        /// <param name="outgoingCorrespondenceInfo">The OutgoingCorrespondenceInfo.</param>
        /// <returns></returns>
        public static OutgoingCorrespondenceInfoEntity GetOutgoingCorrespondenceInfoEntity(OutgoingCorrespondenceInfo outgoingCorrespondenceInfo)
        {
            OutgoingCorrespondenceInfoEntity outgoingCorrespondenceInfoEntity = null;
            try
            {
                outgoingCorrespondenceInfoEntity = Mapper.Map<OutgoingCorrespondenceInfo, OutgoingCorrespondenceInfoEntity>(outgoingCorrespondenceInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOutgoingCorrespondenceInfoEntity", ex);
                throw;
            }
            return outgoingCorrespondenceInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="PCAppDatesFromSAL"/> from <see cref="PCAppDatesFromSAL"/> input.
        /// </summary>
        /// <param name="PCAppDatesFromSAL"><see cref="PCAppDatesFromSAL"/></param>
        /// <returns>Returns <see cref="PCAppDatesFromSALEntity"/>, else null.</returns>
        public static PCAppDatesFromSALEntity GetPCAppDatesFromSALEntity(PCAppDatesFromSAL pCAppDatesFromSAL)
        {
            PCAppDatesFromSALEntity pCAppDatesFromSALEntity = null;

            try
            {
                if (pCAppDatesFromSAL != null)
                {
                    pCAppDatesFromSALEntity = Mapper.Map<PCAppDatesFromSAL, PCAppDatesFromSALEntity>(pCAppDatesFromSAL);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPCAppDatesFromSALEntity", ex);
                throw;
            }

            return pCAppDatesFromSALEntity;
        }

        /*
        /// <summary>
        /// Gets the <see cref="PCAppDetailsFromSAL"/> from <see cref="PCAppDetailsFromSAL"/> input.
        /// </summary>
        /// <param name="PCAppDetailsFromSAL"><see cref="PCAppDetailsFromSAL"/></param>
        /// <returns>Returns <see cref="PCAppDetailsFromSALEntity"/>, else null.</returns>
        public static PCAppDetailsFromLawSocEntity GetPCAppDetailsFromSALEntity(PCAppDetailsFromSAL pCAppDetailsFromSAL)
        {
            PCAppDetailsFromLawSocEntity pCAppDetailsFromSALEntity = null;

            try
            {
                if (pCAppDetailsFromSAL != null)
                {
                    pCAppDetailsFromSALEntity = Mapper.Map<PCAppDetailsFromSAL, PCAppDetailsFromLawSocEntity>(pCAppDetailsFromSAL);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPCAppDetailsFromSALEntity", ex);
                throw;
            }

            return pCAppDetailsFromSALEntity;
        }*/
        /// <summary>
        /// Gets the <see cref="PCConditionInfo"/> from <see cref="PCConditionInfo"/> input.
        /// </summary>
        /// <param name="PCConditionInfo"><see cref="PCConditionInfo"/></param>
        /// <returns>Returns <see cref="PCConditionInfoEntity"/>, else null.</returns>
        public static PCConditionInfoEntity GetPCConditionInfoEntity(PCConditionInfo pCConditionInfo)
        {
            PCConditionInfoEntity pCConditionInfoEntity = null;

            try
            {
                if (pCConditionInfo != null)
                {
                    pCConditionInfoEntity = Mapper.Map<PCConditionInfo, PCConditionInfoEntity>(pCConditionInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPCConditionInfoEntity", ex);
                throw;
            }

            return pCConditionInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="PrayerEntity"/> from <see cref="Prayer"/> input.
        /// </summary>
        /// <param name="prayer"><see cref="Prayer"/></param>
        /// <returns>Returns <see cref="PrayerEntity"/>, else null.</returns>
        public static PrayerEntity GetPrayerEntity(Prayer prayer)
        {
            PrayerEntity prayerEntity = null;

            try
            {
                if (prayer != null)
                {
                    prayerEntity = Mapper.Map<Prayer, PrayerEntity>(prayer);
                    prayerEntity.MPrayerOutcome = Mapper.Map<MPrayerOutcome, MPrayerOutcomeEntity>(prayer.MPrayerOutcome);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPrayerEntity", ex);
                throw;
            }

            return prayerEntity;
        }

        /*
        /// <summary>
        /// Gets the <see cref="EmploymentInfo"/> from <see cref="QualificationInfo"/> input.
        /// </summary>
        /// <param name="QualificationInfo"><see cref="QualificationInfo"/></param>
        /// <returns>Returns <see cref="QualificationInfoEntity"/>, else null.</returns>
        public static QualificationInfoEntity GetQualificationInfoEntity(QualificationInfo qualificationInfo)
        {
            QualificationInfoEntity qualificationInfoEntity = null;

            try
            {
                if (qualificationInfo != null)
                {
                    qualificationInfoEntity = Mapper.Map<QualificationInfo, QualificationInfoEntity>(qualificationInfo);
                    qualificationInfoEntity.MAASQualification = Mapper.Map<MAASQualification, MAASQualificationEntity>(qualificationInfo.MAASQualification);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetQualificationInfoEntity", ex);
                throw;
            }

            return qualificationInfoEntity;
        }*/
        /// <summary>
        /// Gets the <see cref="RefCaveatCaseEntity"/> from <see cref="RefCaveatCase"/> input.
        /// </summary>
        /// <param name="refCaveatCase"><see cref="RefCaveatCase"/></param>
        /// <returns>Returns <see cref="RefCaveatCaseEntity"/>, else null.</returns>
        public static RefCaveatCaseEntity GetRefCaveatCaseEntity(RefCaveatCase refCaveatCase)
        {
            RefCaveatCaseEntity refCaveatCaseEntity = null;

            try
            {
                if (refCaveatCase != null)
                {
                    refCaveatCaseEntity = Mapper.Map<RefCaveatCase, RefCaveatCaseEntity>(refCaveatCase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRefCaveatCaseEntity", ex);
                throw;
            }

            return refCaveatCaseEntity;
        }

        /// <summary>
        /// Gets the <see cref="RefOrderDetailEntity"/> from <see cref="RefOrderDetail"/> input.
        /// </summary>
        /// <param name="refOrderDetail"><see cref="RefOrderDetail"/></param>
        /// <returns>Returns <see cref="RefOrderDetailEntity"/>, else null.</returns>
        public static RefOrderDetailEntity GetRefOrderDetailEntity(RefOrderDetail refOrderDetail)
        {
            RefOrderDetailEntity refOrderDetailEntity = null;

            try
            {
                if (refOrderDetail != null)
                {
                    refOrderDetailEntity = Mapper.Map<RefOrderDetail, RefOrderDetailEntity>(refOrderDetail);
                    refOrderDetailEntity.MDesignation = Mapper.Map<MDesignation, MDesignationEntity>(refOrderDetail.MDesignation);
                    refOrderDetailEntity.MCoram = Mapper.Map<MCoram, MCoramEntity>(refOrderDetail.MCoram);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRefOrderDetailEntity", ex);
                throw;
            }

            return refOrderDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="RefSubCaseEntity"/> from <see cref="RefSubCase"/> input.
        /// </summary>
        /// <param name="refSubCase"><see cref="RefSubCase"/></param>
        /// <returns>Returns <see cref="RefSubCaseEntity"/>, else null.</returns>
        public static RefSubCaseEntity GetRefSubCaseEntity(RefSubCase refSubCase)
        {
            RefSubCaseEntity refSubCaseEntity = null;

            try
            {
                if (refSubCase != null)
                {
                    refSubCaseEntity = Mapper.Map<RefSubCase, RefSubCaseEntity>(refSubCase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRefSubCaseEntity", ex);
                throw;
            }

            return refSubCaseEntity;
        }

        /// <summary>
        /// Gets the <see cref="RelatedProceedingEntity"/> from <see cref="RelatedProceeding"/> input.
        /// </summary>
        /// <param name="relatedProceeding"><see cref="RelatedProceeding"/></param>
        /// <returns>Returns <see cref="RelatedProceedingEntity"/>, else null.</returns>
        public static RelatedProceedingEntity GetRelatedProceedingEntity(RelatedProceeding relatedProceeding)
        {
            RelatedProceedingEntity relatedProceedingEntity = null;

            try
            {
                if (relatedProceeding != null)
                {
                    relatedProceedingEntity = Mapper.Map<RelatedProceeding, RelatedProceedingEntity>(relatedProceeding);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRelatedProceedingEntity", ex);
                throw;
            }

            return relatedProceedingEntity;
        }

        /// <summary>
        /// Gets the <see cref="SolicitorEntity"/> from <see cref="Solicitor"/> input.
        /// </summary>
        /// <param name="solicitor"><see cref="Solicitor"/></param>
        /// <returns>Returns <see cref="SolicitorEntity"/>, else null.</returns>
        public static SolicitorEntity GetSolicitorEntity(Solicitor solicitor)
        {
            SolicitorEntity solicitorEntity = null;

            try
            {
                if (solicitor != null)
                {
                    solicitorEntity = Mapper.Map<Solicitor, SolicitorEntity>(solicitor);
                    solicitorEntity.MaritalStatusCode = Mapper.Map<MMaritalStatus, MMaritalStatusEntity>(solicitor.MaritalStatusCode);
                   // solicitorEntity.MNationalityEntity = Mapper.Map<MNationality, MNationalityEntity>(solicitor.SolicitorNationality);
                    solicitorEntity.RaceCode = Mapper.Map<MRace, MRaceEntity>(solicitor.RaceCode);
                    solicitorEntity.ReligionCode = Mapper.Map<MReligion, MReligionEntity>(solicitor.ReligionCode);
                    solicitorEntity.IdCountryCode = Mapper.Map<MCountry, MCountryEntity>(solicitor.IdCountryCode);
                    solicitorEntity.IdTypeCode = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(solicitor.IdTypeCode);
                    //solicitorEntity.MPersonIDGroupEntity=Mapper.Map<MPersonIDGroup,MPersonIDGroupEntity>(solicitor.IdGroupCode);
                    solicitorEntity.CountryOfBirth = Mapper.Map<MCountry, MCountryEntity>(solicitor.CountryOfBirth);
                    solicitorEntity.Gender = Mapper.Map<MGender, MGenderEntity>(solicitor.Gender);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSolicitorEntity", ex);
                throw;
            }

            return solicitorEntity;
        }

        /// <summary>
        /// Gets the <see cref="SubmissionInfoEntity"/> from <see cref="SubmissionInfo"/> input.
        /// </summary>
        /// <param name="submissionInfo"><see cref="SubmissionInfo"/></param>
        /// <returns>Returns <see cref="SubmissionInfoEntity"/>, else null.</returns>
        public static SubmissionInfoEntity GetSubmissionInfoEntity(SubmissionInfo submissionInfo)
        {
            SubmissionInfoEntity submissionInfoEntity = null;

            try
            {
                if (submissionInfo != null)
                {
                    submissionInfoEntity = Mapper.Map<SubmissionInfo, SubmissionInfoEntity>(submissionInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSubmissionInfoEntity", ex);
                throw;
            }

            return submissionInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="EmploymentInfo"/> from <see cref="TravelPassInfo"/> input.
        /// </summary>
        /// <param name="TravelPassInfo"><see cref="TravelPassInfo"/></param>
        /// <returns>Returns <see cref="TravelPassInfoEntity"/>, else null.</returns>
        public static TravelPassInfoEntity GetTravelPassInfoEntity(TravelPassInfo travelPassInfo)
        {
            TravelPassInfoEntity travelPassInfoEntity = null;

            try
            {
                if (travelPassInfo != null)
                {
                    travelPassInfoEntity = Mapper.Map<TravelPassInfo, TravelPassInfoEntity>(travelPassInfo);
                    travelPassInfoEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(travelPassInfo.MCountry);
                    travelPassInfoEntity.MPersonIDType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(travelPassInfo.MPersonIDType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetTravelPassInfoEntity", ex);
                throw;
            }

            return travelPassInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="UnliquidatedClaimEntity"/> from <see cref="UnliquidatedClaim"/> input.
        /// </summary>
        /// <param name="unliquidatedClaim"><see cref="UnliquidatedClaim"/></param>
        /// <returns>Returns <see cref="UnliquidatedClaimEntity"/>, else null.</returns>
        public static UnliquidatedClaimEntity GetUnliquidatedClaimEntity(UnliquidatedClaim unliquidatedClaim)
        {
            UnliquidatedClaimEntity unliquidatedClaimEntity = null;

            try
            {
                if (unliquidatedClaim != null)
                {
                    unliquidatedClaimEntity = Mapper.Map<UnliquidatedClaim, UnliquidatedClaimEntity>(unliquidatedClaim);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetUnliquidatedClaimEntity", ex);
                throw;
            }

            return unliquidatedClaimEntity;
        }

        /// <summary>
        /// Gets the <see cref="WOECaseExecutionAddressEntity"/> from <see cref="WOECaseExecutionAddress"/> input.
        /// </summary>
        /// <param name="wOECaseExecutionAddress"><see cref="WOECaseExecutionAddress"/></param>
        /// <returns>Returns <see cref="WOECaseExecutionAddressEntity"/>, else null.</returns>
        public static WOECaseExecutionAddressEntity GetWOECaseExecutionAddressEntity(WOECaseExecutionAddress wOECaseExecutionAddress)
        {
            WOECaseExecutionAddressEntity wOECaseExecutionAddressEntity = null;

            try
            {
                if (wOECaseExecutionAddress != null)
                {
                    wOECaseExecutionAddressEntity = Mapper.Map<WOECaseExecutionAddress, WOECaseExecutionAddressEntity>(wOECaseExecutionAddress);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOECaseExecutionAddressEntity", ex);
                throw;
            }

            return wOECaseExecutionAddressEntity;
        }

        /// <summary>
        /// Gets the <see cref="WOEExecutionAddressEntity"/>
        /// </summary>
        /// <param name="woeExecutionAddress">The WOEExecutionAddress.</param>
        /// <returns></returns>
        public static WOEExecutionAddressEntity GetWOEExecutionAddressEntity(WOEExecutionAddress woeExecutionAddress)
        {
            WOEExecutionAddressEntity woeExecutionAddressEntity = null;
            try
            {
                woeExecutionAddressEntity = Mapper.Map<WOEExecutionAddress, WOEExecutionAddressEntity>(woeExecutionAddress);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOEExecutionAddressEntity", ex);
                throw;
            }
            return woeExecutionAddressEntity;
        }

        /// <summary>
        /// Gets the appeal time estimation detail entity.
        /// </summary>
        /// <param name="appealTimeEstimationDetail">The appeal time estimation detail.</param>
        /// <returns></returns>
        public static AppealTimeEstimationDetailEntity GetAppealTimeEstimationDetailEntity(AppealTimeEstimationDetail appealTimeEstimationDetail)
        {
            AppealTimeEstimationDetailEntity appealTimeEstimationDetailEntity = null;
            try
            {
                appealTimeEstimationDetailEntity = Mapper.Map<AppealTimeEstimationDetail, AppealTimeEstimationDetailEntity>(appealTimeEstimationDetail);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAppealTimeEstimationDetailEntity", ex);
                throw;
            }
            return appealTimeEstimationDetailEntity;
        }

        /// <summary>
        /// Gets the notice to refer affidavit entity.
        /// </summary>
        /// <param name="noticeToReferAffidavit">The notice to refer affidavit.</param>
        /// <returns></returns>
        public static NoticeToReferAffidavitEntity GetNoticeToReferAffidavitEntity(NoticeToReferAffidavit noticeToReferAffidavit)
        {
            NoticeToReferAffidavitEntity noticeToReferAffidavitEntity = null;
            try
            {
                noticeToReferAffidavitEntity = Mapper.Map<NoticeToReferAffidavit, NoticeToReferAffidavitEntity>(noticeToReferAffidavit);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetNoticeToReferAffidavitEntity", ex);
                throw;
            }
            return noticeToReferAffidavitEntity;
        }

        /// <summary>
        /// Gets the claim amount entity.
        /// </summary>
        /// <param name="claimAmount">The claim amount.</param>
        /// <returns></returns>
        public static ClaimAmountEntity GetClaimAmountEntity(ClaimAmount claimAmount)
        {
            ClaimAmountEntity claimAmountEntity = null;
            try
            {
                claimAmountEntity = Mapper.Map<ClaimAmount, ClaimAmountEntity>(claimAmount);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetClaimAmountEntity", ex);
                throw;
            }
            return claimAmountEntity;

        }

        public static CheckListCommentEntity GetCheckListCommentEntity(CheckListComments checkListComments)
        {
            CheckListCommentEntity checkListCommentEntity = null;
            try
            {
                checkListCommentEntity = Mapper.Map<CheckListComments, CheckListCommentEntity>(checkListComments);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCheckListCommentEntity", ex);
                throw;
            }
            return checkListCommentEntity;

        }

        /// <summary>
        /// Gets the <see cref="AppealTimeEstimationDetail"/>
        /// </summary>
        /// <param name="appealTimeEstimationDetailEntity">The AppealTimeEstimationDetailEntity.</param>
        /// <returns></returns>
        public static RefOrderJOInfoEntity GetRefOrderJOInfoEntity(RefOrderJOInfo refOrderJOInfo)
        {
            RefOrderJOInfoEntity refOrderJOInfoEntity = null;
            try
            {
                refOrderJOInfoEntity = Mapper.Map<RefOrderJOInfo, RefOrderJOInfoEntity>(refOrderJOInfo);
                refOrderJOInfoEntity.MCoram = Mapper.Map<MCoram, MCoramEntity>(refOrderJOInfo.MCoram);
                refOrderJOInfoEntity.MDesignation = Mapper.Map<MDesignation, MDesignationEntity>(refOrderJOInfo.MDesignation);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRefOrderJOInfoEntity", ex);
                throw;
            }
            return refOrderJOInfoEntity;
        }


        /// <summary>
        /// Gets the <see cref="AppealTimeEstimationDetail"/>
        /// </summary>
        /// <param name="appealTimeEstimationDetailEntity">The AppealTimeEstimationDetailEntity.</param>
        /// <returns></returns>
        public static SystemParametersEntity GetSystemParametersEntity(SystemParameters systemParameters)
        {
            SystemParametersEntity systemParametersEntity = null;
            try
            {
                systemParametersEntity = Mapper.Map<SystemParameters, SystemParametersEntity>(systemParameters);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSystemParametersEntity", ex);
                throw;
            }
            return systemParametersEntity;
        }

        public static InterfaceNBSReportEntity GetInterfaceNBSReportEntity(InterfaceNBSReport interfaceNBSReport)
        {
            InterfaceNBSReportEntity interfaceNBSReportEntity = null;
            try
            {
                interfaceNBSReportEntity = Mapper.Map<InterfaceNBSReport, InterfaceNBSReportEntity>(interfaceNBSReport);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetInterfaceNBSReportEntity", ex);
                throw;
            }
            return interfaceNBSReportEntity;
        }

        /// <summary>
        /// Gets the foreign user registration details entity.
        /// </summary>
        /// <param name="foreignUserRegistrationDetails">The foreign user registration details.</param>
        /// <returns></returns>
        private static ForeignUserRegistrationDetailsEntity GetForeignUserRegistrationDetailsEntity(ForeignUserRegistrationDetails foreignUserRegistrationDetails)
        {
            ForeignUserRegistrationDetailsEntity foreignUserRegistrationDetailsEntity = null;
            try
            {
                foreignUserRegistrationDetailsEntity = Mapper.Map<ForeignUserRegistrationDetails, ForeignUserRegistrationDetailsEntity>(foreignUserRegistrationDetails);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetForeignUserRegistrationDetailsEntity", ex);
                throw;
            }
            return foreignUserRegistrationDetailsEntity;
        }

        /// <summary>
        /// Gets the foreign user reg address details entity.
        /// </summary>
        /// <param name="foreignUserRegAddressDetails">The foreign user reg address details.</param>
        /// <returns></returns>
        public static ForeignUserRegAddressDetailsEntity GetForeignUserRegAddressDetailsEntity(ForeignUserRegAddressDetails foreignUserRegAddressDetails)
        {
            ForeignUserRegAddressDetailsEntity foreignUserRegAddressDetailsEntity = null;
            try
            {
                foreignUserRegAddressDetailsEntity = Mapper.Map<ForeignUserRegAddressDetails, ForeignUserRegAddressDetailsEntity>(foreignUserRegAddressDetails);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetForeignUserRegAddressDetailsEntity", ex);
                throw;
            }
            return foreignUserRegAddressDetailsEntity;
        }

        /// <summary>
        /// Gets the foreign user practice information entity.
        /// </summary>
        /// <param name="foreignUserPracticeInformation">The foreign user practice information.</param>
        /// <returns></returns>
        public static ForeignUserPracticeInformationEntity GetForeignUserPracticeInformationEntity(ForeignUserPracticeInformation foreignUserPracticeInformation)
        {
            ForeignUserPracticeInformationEntity foreignUserPracticeInformationEntity = null;
            try
            {
                foreignUserPracticeInformationEntity = Mapper.Map<ForeignUserPracticeInformation, ForeignUserPracticeInformationEntity>(foreignUserPracticeInformation);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetForeignUserPracticeInformationEntity", ex);
                throw;
            }
            return foreignUserPracticeInformationEntity;
        }


        /// <summary>
        /// Gets the foreign user registration detail entity.
        /// </summary>
        /// <param name="foreignUserRegistrationDetails">The foreign user registration details.</param>
        /// <returns></returns>
        public static ForeignUserRegistrationDetailsEntity GetForeignUserRegistrationDetailEntity(ForeignUserRegistrationDetails foreignUserRegistrationDetails)
        {
            ForeignUserRegistrationDetailsEntity foreignUserRegistrationDetailsEntity = null;
            try
            {
                foreignUserRegistrationDetailsEntity = Mapper.Map<ForeignUserRegistrationDetails, ForeignUserRegistrationDetailsEntity>(foreignUserRegistrationDetails);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetForeignUserRegistrationDetailEntity", ex);
                throw;
            }
            return foreignUserRegistrationDetailsEntity;
        }

        /// <summary>
        /// Gets the req examination feedetail entity.
        /// </summary>
        /// <param name="reqExaminationFeedetail">The req examination feedetail.</param>
        /// <returns></returns>
        public static ReqExaminationFeeDetailEntity GetReqExaminationFeedetailEntity(ReqExaminationFeeDetail reqExaminationFeedetail)
        {
            ReqExaminationFeeDetailEntity reqExaminationFeedetailEntity = null;
            try
            {
                reqExaminationFeedetailEntity = Mapper.Map<ReqExaminationFeeDetail, ReqExaminationFeeDetailEntity>(reqExaminationFeedetail);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetReqExaminationFeedetailEntity", ex);
                throw;
            }
            return reqExaminationFeedetailEntity;
        }

        public static RegistrationOfForeignLawyerEntity GetRegistrationOfForeignLawyerEntity(RegistrationOfForeignLawyer registrationOfForeignLawyer)
        {
            RegistrationOfForeignLawyerEntity registrationOfForeignLawyerEntity = null;
            try
            {
                registrationOfForeignLawyerEntity = Mapper.Map<RegistrationOfForeignLawyer, RegistrationOfForeignLawyerEntity>(registrationOfForeignLawyer);
                registrationOfForeignLawyerEntity.Nationality = Mapper.Map<MNationality, MNationalityEntity>(registrationOfForeignLawyer.MNationality);
                registrationOfForeignLawyerEntity.Gender = Mapper.Map<MGender, MGenderEntity>(registrationOfForeignLawyer.MGender);
                registrationOfForeignLawyerEntity.CaseType = Mapper.Map<MCaseType, MCaseTypeEntity>(registrationOfForeignLawyer.MCaseType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRegistrationOfForeignLawyerEntity", ex);
                throw;
            }
            return registrationOfForeignLawyerEntity;
        }

        public static RFLValidityAndNotificationEntity GetRFLValidityAndNotificationEntity(RFLValidityAndNotification rFLValidityAndNotification)
        {
            RFLValidityAndNotificationEntity rFLValidityAndNotificationEntity = null;
            try
            {
                rFLValidityAndNotificationEntity = Mapper.Map<RFLValidityAndNotification, RFLValidityAndNotificationEntity>(rFLValidityAndNotification);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRFLValidityAndNotificationEntity", ex);
                throw;
            }
            return rFLValidityAndNotificationEntity;
        }
        /// <summary>
        /// Gets the sicc fee ledger entity.
        /// </summary>
        /// <param name="sICCFeeLedger">The s icc fee ledger.</param>
        /// <returns></returns>
        public static SICCFeeLedgerEntity GetSICCFeeLedgerEntity(SICCFeeLedger sICCFeeLedger)
        {
            SICCFeeLedgerEntity sICCFeeLedgerEntity = null;
            try
            {
                sICCFeeLedgerEntity = Mapper.Map<SICCFeeLedger, SICCFeeLedgerEntity>(sICCFeeLedger);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSICCFeeLedgerEntity", ex);
                throw;
            }
            return sICCFeeLedgerEntity;

        }


        /// <summary>
        /// Gets the Request For Exemption entity.
        /// </summary>
        /// <param name="RequestForExemption">The Request For Exemption details.</param>
        /// <returns></returns>
        public static RequestForExemptionEntity GetRequestForExemptionEntity(RequestForExemption requestForExemption)
        {
            RequestForExemptionEntity requestForExemptionEntity = null;
            try
            {
                requestForExemptionEntity = Mapper.Map<RequestForExemption, RequestForExemptionEntity>(requestForExemption);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRequestForExemptionEntity", ex);
                throw;
            }
            return requestForExemptionEntity;
        }

        /// <summary>
        /// Gets the Fee Collection Detail entity.
        /// </summary>
        /// <param name="FeeCollectionDetail">The Fee Collection Detail.</param>
        /// <returns></returns>
        public static FeeCollectionDetailEntity GetFeeCollectionDetailEntity(FeeCollectionDetail feeCollectionDetail)
        {
            FeeCollectionDetailEntity feeCollectionDetailEntity = null;
            try
            {
                feeCollectionDetailEntity = Mapper.Map<FeeCollectionDetail, FeeCollectionDetailEntity>(feeCollectionDetail);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetFeeCollectionDetailEntity", ex);
                throw;
            }
            return feeCollectionDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="NatureOfAppealEntity"/> from <see cref="NatureOfAppeal"/> input.
        /// </summary>
        /// <param name="natureOfAppeal"><see cref="NatureOfAppeal"/></param>
        /// <returns>Returns <see cref="NatureOfAppealEntity"/>, else null.</returns>
        public static LawFirmRegistrationEntity GetLawFirmRegistrationEntity(LawFirmRegistration lawFirmRegistration)
        {
            LawFirmRegistrationEntity lawFirmRegistrationEntity = null;

            try
            {
                if (lawFirmRegistration != null)
                {
                    lawFirmRegistrationEntity = Mapper.Map<LawFirmRegistration, LawFirmRegistrationEntity>(lawFirmRegistration);
                    lawFirmRegistrationEntity.MLawFirmGroup = Mapper.Map<MLawFirmGroup, MLawFirmGroupEntity>(lawFirmRegistration.MLawFirmGroup);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetLawFirmRegistrationEntity", ex);
                throw;
            }

            return lawFirmRegistrationEntity;
        }


        /// <summary>
        /// Gets the <see cref="DocLegalExperienceInfoEntity"/>
        /// </summary>
        /// <param name="DoclegalExperienceInfo">The DocLegalExperienceInfo.</param>
        /// <returns></returns>
        public static DocLegalExperienceInfoEntity GetDocLegalExperienceInfoEntity(DocLegalExperienceInfo docLegalExperienceInfo)
        {
            DocLegalExperienceInfoEntity docLegalExperienceInfoEntity = null;
            try
            {
                if (docLegalExperienceInfo != null)
                {
                    docLegalExperienceInfoEntity = Mapper.Map<DocLegalExperienceInfo, DocLegalExperienceInfoEntity>(docLegalExperienceInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocLegalExperienceInfoEntity", ex);
                throw;
            }
            return docLegalExperienceInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CaseLegalExperienceInfoEntity"/>
        /// </summary>
        /// <param name="CaselegalExperienceInfo">The CaseLegalExperienceInfo.</param>
        /// <returns></returns>
        public static CaseLegalExperienceInfoEntity GetCaseLegalExperienceInfoEntity(CaseLegalExperienceInfo caseLegalExperienceInfo)
        {
            CaseLegalExperienceInfoEntity caseLegalExperienceInfoEntity = null;
            try
            {
                if (caseLegalExperienceInfo != null)
                {
                    caseLegalExperienceInfoEntity = Mapper.Map<CaseLegalExperienceInfo, CaseLegalExperienceInfoEntity>(caseLegalExperienceInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseLegalExperienceInfoEntity", ex);
                throw;
            }
            return caseLegalExperienceInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CORSolicitorRegEntity"/>
        /// </summary>
        /// <param name="CORSolicitorReg">The CORSolicitorReg.</param>
        /// <returns></returns>
        public static CORSolicitorRegEntity GetCORSolicitorRegEntity(CORSolicitorReg cORSolicitorReg)
        {
            CORSolicitorRegEntity cORSolicitorRegEntity = null;
            try
            {
                if (cORSolicitorReg != null)
                {
                    cORSolicitorRegEntity = Mapper.Map<CORSolicitorReg, CORSolicitorRegEntity>(cORSolicitorReg);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCORSolicitorRegEntity", ex);
                throw;
            }
            return cORSolicitorRegEntity;
        }

        /// <summary>
        /// Gets the <see cref="CORSolicitorRegDetailsEntity"/>
        /// </summary>
        /// <param name="CORSolicitorRegDetails">The CORSolicitorRegDetails.</param>
        /// <returns></returns>
        public static CORSolicitorRegDetailsEntity GetCORSolicitorRegDetailsEntity(CORSolicitorRegDetails cORSolicitorRegDetails)
        {
            CORSolicitorRegDetailsEntity cORSolicitorRegDetailsEntity = null;
            try
            {
                if (cORSolicitorRegDetails != null)
                {
                    cORSolicitorRegDetailsEntity = Mapper.Map<CORSolicitorRegDetails, CORSolicitorRegDetailsEntity>(cORSolicitorRegDetails);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCORSolicitorRegDetailsEntity", ex);
                throw;
            }
            return cORSolicitorRegDetailsEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCaseCounterClaimDetailsEntity"/>
        /// </summary>
        /// <param name="DocCaseCounterClaimDetails">The DocCaseCounterClaimDetails.</param>
        /// <returns></returns>
        public static DocCaseCounterClaimDetailsEntity GetDocCaseCounterClaimDetailsEntity(DocCaseCounterClaimDetails docCaseCounterClaimDetails)
        {
            DocCaseCounterClaimDetailsEntity docCaseCounterClaimDetailsEntity = null;
            try
            {
                if (docCaseCounterClaimDetails != null)
                {
                    docCaseCounterClaimDetailsEntity = Mapper.Map<DocCaseCounterClaimDetails, DocCaseCounterClaimDetailsEntity>(docCaseCounterClaimDetails);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCaseCounterClaimDetailsEntity", ex);
                throw;
            }
            return docCaseCounterClaimDetailsEntity;
        }

        /// <summary>
        /// Gets the <see cref="DocCaseCounterClaimEntity"/>
        /// </summary>
        /// <param name="DocCaseCounterClaim">The DocCaseCounterClaim.</param>
        /// <returns></returns>
        public static DocCaseCounterClaimEntity GetDocCaseCounterClaimEntity(DocCaseCounterClaim docCaseCounterClaim)
        {
            DocCaseCounterClaimEntity docCaseCounterClaimEntity = null;
            try
            {
                if (docCaseCounterClaim != null)
                {
                    docCaseCounterClaimEntity = Mapper.Map<DocCaseCounterClaim, DocCaseCounterClaimEntity>(docCaseCounterClaim);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDocCaseCounterClaimEntity", ex);
                throw;
            }
            return docCaseCounterClaimEntity;
        }

        /// <summary>
        /// Gets the <see cref="CaseCounterClaimEntity"/>
        /// </summary>
        /// <param name="CaseCounterClaim">The CaseCounterClaim.</param>
        /// <returns></returns>
        public static CaseCounterClaimEntity GetCaseCounterClaimEntity(CaseCounterClaim caseCounterClaim)
        {
            CaseCounterClaimEntity caseCounterClaimEntity = null;
            try
            {
                if (caseCounterClaim != null)
                {
                    caseCounterClaimEntity = Mapper.Map<CaseCounterClaim, CaseCounterClaimEntity>(caseCounterClaim);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseCounterClaimEntity", ex);
                throw;
            }
            return caseCounterClaimEntity;
        }

        /// <summary>
        /// Gets the <see cref="CaseCounterClaimDetailsEntity"/>
        /// </summary>
        /// <param name="CaseCounterClaimDetails">The CaseCounterClaimDetails.</param>
        /// <returns></returns>
        public static CaseCounterClaimDetailsEntity GetCaseCounterClaimDetailsEntity(CaseCounterClaimDetails caseCounterClaimDetails)
        {
            CaseCounterClaimDetailsEntity caseCounterClaimDetailsEntity = null;
            try
            {
                if (caseCounterClaimDetails != null)
                {
                    caseCounterClaimDetailsEntity = Mapper.Map<CaseCounterClaimDetails, CaseCounterClaimDetailsEntity>(caseCounterClaimDetails);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseCounterClaimDetailsEntity", ex);
                throw;
            }
            return caseCounterClaimDetailsEntity;
        }

        #endregion Methods

        
    }
}