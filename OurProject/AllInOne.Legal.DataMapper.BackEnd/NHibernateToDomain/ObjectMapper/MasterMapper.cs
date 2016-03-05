#region Header

/*****************************************************************************************************
* Description : This file handles mapper for Master from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   23/09/2010   		      	Nai                	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MasterMapper.cs
// Description: This file handles mapper for Master from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "MasterMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.MRelationship;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Master from NHibernate entities to Domain objects.
    /// </summary>
    public class MasterMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MasterMapper));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the <see cref="MEMSADMExecLocationEntity"/> from <see cref="MEMSADMExecLocation"/> input.
        /// </summary>
        /// <param name="MEMSADMExecLocation"><see cref="MEMSADMExecLocation"/></param>
        /// <returns>Returns <see cref="MEMSADMExecLocationEntity"/>, else null.</returns>
        public static MEMSADMExecLocationEntity GetMEMSADMExecLocationEntity(MEMSADMExecLocation mEMSADMExecLocation)
        {
            MEMSADMExecLocationEntity mEMSADMExecLocationEntity = null;

            try
            {
                mEMSADMExecLocationEntity = Mapper.Map<MEMSADMExecLocation, MEMSADMExecLocationEntity>(mEMSADMExecLocation);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMEMSADMExecLocationEntity", ex);
                throw;
            }

            return mEMSADMExecLocationEntity;
        }

        /// <summary>
        /// Gets the <see cref="MEMSCrmCasePrefix"/> from <see cref="MEMSCrmCasePrefix"/> input.
        /// </summary>
        /// <param name="MEMSADMExecLocation"><see cref="mEMSCrmCasePrefix"/></param>
        /// <returns>Returns <see cref="MEMSCrmCasePrefixEntity"/>, else null.</returns>
        public static MEMSCrmCasePrefixEntity GetMEMSCrmCasePrefixEntity(MEMSCrmCasePrefix mEMSCrmCasePrefix)
        {
            MEMSCrmCasePrefixEntity mEMSCrmCasePrefixEntity = null;

            try
            {
                mEMSCrmCasePrefixEntity = Mapper.Map<MEMSCrmCasePrefix, MEMSCrmCasePrefixEntity>(mEMSCrmCasePrefix);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMEMSCrmCasePrefixEntity", ex);
                throw;
            }

            return mEMSCrmCasePrefixEntity;
        }

        /// <summary>
        /// Gets the <see cref="MPrinterEntity"/> from <see cref="MPrinter"/> input.
        /// </summary>
        /// <param name="MPrinter"><see cref="MPrinter"/></param>
        /// <returns>Returns <see cref="MPrinterEntity"/>, else null.</returns>
        public static MPrinterEntity GetMPrinterEntity(MPrinter mPrinter)
        {
            MPrinterEntity mPrinterEntity = null;

            try
            {
                mPrinterEntity = Mapper.Map<MPrinter, MPrinterEntity>(mPrinter);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPrinterEntity", ex);
                throw;
            }

            return mPrinterEntity;
        }


        /// <summary>
        /// Gets the M law firm group entity.
        /// </summary>
        /// <param name="mLawFirmGroup">The m law firm group.</param>
        /// <returns></returns>
        public static MLawFirmGroupEntity GetMLawFirmGroupEntity(MLawFirmGroup mLawFirmGroup)
        {
            MLawFirmGroupEntity mLawFirmGroupEntity = null;

            try
            {
                mLawFirmGroupEntity = Mapper.Map<MLawFirmGroup, MLawFirmGroupEntity>(mLawFirmGroup);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMLawFirmGroupEntity", ex);
                throw;
            }

            return mLawFirmGroupEntity;
        }

        /// <summary>
        /// Gets the <see cref="MAASDisciplinaryResultTypeEntity"/> from <see cref="MAASDisciplinaryResultTypeEntity"/> input.
        /// </summary>
        /// <param name="MAASDisciplinaryResultType"><see cref="mAASDisciplinaryResultType"/></param>
        /// <returns>Returns <see cref="MAASDisciplinaryResultTypeEntity"/>, else null.</returns>
        public static MAASDisciplinaryResultTypeEntity GetMAASDisciplinaryResultTypeEntity(MAASDisciplinaryResultType mAASDisciplinaryResultType)
        {
            MAASDisciplinaryResultTypeEntity mAASDisciplinaryResultTypeEntity = null;

            try
            {
                mAASDisciplinaryResultTypeEntity = Mapper.Map<MAASDisciplinaryResultType, MAASDisciplinaryResultTypeEntity>(mAASDisciplinaryResultType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAASDisciplinaryResultTypeEntity", ex);
                throw;
            }

            return mAASDisciplinaryResultTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MAASDisciplinaryResultTypeEntity"/> from <see cref="MAASDisciplinaryResultTypeEntity"/> input.
        /// </summary>
        /// <param name="MAASDisciplinaryResultType"><see cref="mAASDisciplinaryResultType"/></param>
        /// <returns>Returns <see cref="MAASDisciplinaryResultTypeEntity"/>, else null.</returns>
        public static MSummonsParamEntity GetMSummonsParamEntity(MSummonsParam mSummonsParam)
        {
            MSummonsParamEntity mSummonsParamEntity = null;

            try
            {
                mSummonsParamEntity = Mapper.Map<MSummonsParam, MSummonsParamEntity>(mSummonsParam);
                mSummonsParamEntity.MCourtType = Mapper.Map<MCourtType, MCourtTypeEntity>(mSummonsParam.MCourtType);
                mSummonsParamEntity.MNOACode = Mapper.Map<MNOACode, MNOACodeEntity>(mSummonsParam.MNOACode);
                mSummonsParamEntity.MCaseType = Mapper.Map<MCaseType, MCaseTypeEntity>(mSummonsParam.MCaseType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMSummonsParamEntity", ex);
                throw;
            }

            return mSummonsParamEntity;
        }

        /// <summary>
        /// Gets the <see cref="MAASLawDegreeEntity"/> from <see cref="MAASLawDegree"/> input.
        /// </summary>
        /// <param name="mAASLawDegree"><see cref="MAASLawDegree"/></param>
        /// <returns>Returns <see cref="MAASLawDegreeEntity"/>, else null.</returns>
        public static MAASLawDegreeEntity GetMAASLawDegreeEntity(MAASLawDegree mAASLawDegree)
        {
            MAASLawDegreeEntity mAASLawDegreeEntity = null;

            try
            {
                mAASLawDegreeEntity = Mapper.Map<MAASLawDegree, MAASLawDegreeEntity>(mAASLawDegree);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAASLawDegreeEntity", ex);
                throw;
            }

            return mAASLawDegreeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MAASOrganisationTypeEntity"/> from <see cref="MAASOrganisationType"/> input.
        /// </summary>
        /// <param name="mAASOrganisationType"><see cref="MAASOrganisationType"/></param>
        /// <returns>Returns <see cref="MAASOrganisationTypeEntity"/>, else null.</returns>
        public static MAASOrganisationTypeEntity GetMAASOrganisationTypeEntity(MAASOrganisationType mAASOrganisationType)
        {
            MAASOrganisationTypeEntity mAASOrganisationTypeEntity = null;

            try
            {
                mAASOrganisationTypeEntity = Mapper.Map<MAASOrganisationType, MAASOrganisationTypeEntity>(mAASOrganisationType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAASOrganisationTypeEntity", ex);
                throw;
            }

            return mAASOrganisationTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MAASQualificationEntity"/> from <see cref="MAASQualification"/> input.
        /// </summary>
        /// <param name="mAASQualification"><see cref="MAASQualification"/></param>
        /// <returns>Returns <see cref="MAASQualificationEntity"/>, else null.</returns>
        public static MAASQualificationEntity GetMAASQualificationEntity(MAASQualification mAASQualification)
        {
            MAASQualificationEntity mAASQualificationEntity = null;

            try
            {
                mAASQualificationEntity = Mapper.Map<MAASQualification, MAASQualificationEntity>(mAASQualification);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAASQualificationEntity", ex);
                throw;
            }

            return mAASQualificationEntity;
        }

        /// <summary>
        /// Gets the <see cref="MActingInCapacityEntity"/> from <see cref="MActingInCapacity"/> input.
        /// </summary>
        /// <param name="mActingInCapacity"><see cref="MActingInCapacity"/></param>
        /// <returns>Returns <see cref="MActingInCapacityEntity"/>, else null.</returns>
        public static MActingInCapacityEntity GetMActingInCapacityEntity(MActingInCapacity mActingInCapacity)
        {
            MActingInCapacityEntity mActingInCapacityEntity = null;

            try
            {
                mActingInCapacityEntity = Mapper.Map<MActingInCapacity, MActingInCapacityEntity>(mActingInCapacity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMActingInCapacityEntity", ex);
                throw;
            }

            return mActingInCapacityEntity;
        }

        /// <summary>
        /// Gets the <see cref="MActingInCapacityGroupEntity"/> from <see cref="MActingInCapacityGroup"/> input.
        /// </summary>
        /// <param name="mActingInCapacityGroup"><see cref="MActingInCapacityGroup"/></param>
        /// <returns>Returns <see cref="MActingInCapacityGroupEntity"/>, else null.</returns>
        public static MActingInCapacityGroupEntity GetMActingInCapacityGroupEntity(MActingInCapacityGroup mActingInCapacityGroup)
        {
            MActingInCapacityGroupEntity mActingInCapacityGroupEntity = null;

            try
            {
                mActingInCapacityGroupEntity = Mapper.Map<MActingInCapacityGroup, MActingInCapacityGroupEntity>(mActingInCapacityGroup);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMActingInCapacityGroupEntity", ex);
                throw;
            }

            return mActingInCapacityGroupEntity;
        }

        /// <summary>
        /// Gets the <see cref="MAdpPrayerEntity"/> from <see cref="MAdpPrayer"/> input.
        /// </summary>
        /// <param name="mAdpPrayer"><see cref="MAdpPrayer"/></param>
        /// <returns>Returns <see cref="MAdpPrayerEntity"/>, else null.</returns>
        public static MAdpPrayerEntity GetMAdpPrayerEntity(MAdpPrayer mAdpPrayer)
        {
            MAdpPrayerEntity mAdpPrayerEntity = null;

            try
            {
                mAdpPrayerEntity = Mapper.Map<MAdpPrayer, MAdpPrayerEntity>(mAdpPrayer);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAdpPrayerEntity", ex);
                throw;
            }

            return mAdpPrayerEntity;
        }

        /// <summary>
        /// Gets the <see cref="MAlertEventEntity"/> from <see cref="MAlertEvent"/> input.
        /// </summary>
        /// <param name="mAlertEvent"><see cref="MAlertEvent"/></param>
        /// <returns>Returns <see cref="MAlertEventEntity"/>, else null.</returns>
        public static MAlertEventEntity GetMAlertEventEntity(MAlertEvent mAlertEvent)
        {
            MAlertEventEntity mAlertEventEntity = null;

            try
            {
                mAlertEventEntity = Mapper.Map<MAlertEvent, MAlertEventEntity>(mAlertEvent);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAlertEventEntity", ex);
                throw;
            }

            return mAlertEventEntity;
        }

        /// <summary>
        /// Gets the <see cref="MAlertTypeEntity"/> from <see cref="MAlertType"/> input.
        /// </summary>
        /// <param name="mAlertType"><see cref="MAlertType"/></param>
        /// <returns>Returns <see cref="MAlertTypeEntity"/>, else null.</returns>
        public static MAlertTypeEntity GetMAlertTypeEntity(MAlertType mAlertType)
        {
            MAlertTypeEntity mAlertTypeEntity = null;

            try
            {
                mAlertTypeEntity = Mapper.Map<MAlertType, MAlertTypeEntity>(mAlertType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAlertTypeEntity", ex);
                throw;
            }

            return mAlertTypeEntity;
        }



        /// <summary>
        /// Gets the <see cref="MHearingTypeEntity"/> from <see cref="MHearingType"/> input.
        /// </summary>
        /// <param name="mHearingType"><see cref="mHearingType"/></param>
        /// <returns>Returns <see cref="MHearingTypeEntity"/>, else null.</returns>
        public static MHearingTypeEntity GetMHearingTypeEntity(MHearingType mHearingType)
        {
            MHearingTypeEntity mHearingTypeEntity = null;

            try
            {
                mHearingTypeEntity = Mapper.Map<MHearingType, MHearingTypeEntity>(mHearingType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMHearingTypeEntity", ex);
                throw;
            }

            return mHearingTypeEntity;
        }



        /// <summary>
        /// Gets the <see cref="GetMApplicantCapacityEntity"/> from <see cref="MApplicantCapacity"/> input.
        /// </summary>
        /// <param name="mApplicantCapacity"><see cref="MApplicantCapacity"/></param>
        /// <returns>Returns <see cref="GetMApplicantCapacityEntity"/>, else null.</returns>
        public static MApplicantCapacityEntity GetMApplicantCapacityEntity(MApplicantCapacity mApplicantCapacity)
        {
            MApplicantCapacityEntity mApplicantCapacityEntity = null;

            try
            {
                mApplicantCapacityEntity = Mapper.Map<MApplicantCapacity, MApplicantCapacityEntity>(mApplicantCapacity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMApplicantCapacityEntity", ex);
                throw;
            }

            return mApplicantCapacityEntity;
        }

        /// <summary>
        /// Gets the <see cref="MApptOrganisationEntity"/> from <see cref="MApptOrganisation"/> input.
        /// </summary>
        /// <param name="mApptOrganisation"><see cref="MApptOrganisation"/></param>
        /// <returns>Returns <see cref="MApptOrganisationEntity"/>, else null.</returns>
        public static MApptOrganisationEntity GetMApptOrganisationEntity(MApptOrganisation mApptOrganisation)
        {
            MApptOrganisationEntity mApptOrganisationEntity = null;

            try
            {
                mApptOrganisationEntity = Mapper.Map<MApptOrganisation, MApptOrganisationEntity>(mApptOrganisation);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMApptOrganisationEntity", ex);
                throw;
            }

            return mApptOrganisationEntity;
        }

        public static IMasterEntity GetMasterEntity<T>(T iMaster)
        {
            if (iMaster.GetType().Equals(typeof(MSection)))
                return (MasterMapper.GetMSectionEntity(iMaster as MSection));
            else if (iMaster.GetType().Equals(typeof(MEMSCrmCasePrefix)))
                return (MasterMapper.GetMEMSCrmCasePrefixEntity(iMaster as MEMSCrmCasePrefix));
            else if (iMaster.GetType().Equals(typeof(MEMSADMExecLocation)))
                return (MasterMapper.GetMEMSADMExecLocationEntity(iMaster as MEMSADMExecLocation));
            else if (iMaster.GetType().Equals(typeof(MPrinter)))
                return (MasterMapper.GetMPrinterEntity(iMaster as MPrinter));
            else if (iMaster.GetType().Equals(typeof(MLawFirmGroup)))
                return (MasterMapper.GetMLawFirmGroupEntity(iMaster as MLawFirmGroup));
            else if (iMaster.GetType().Equals(typeof(MHoliday)))
                return (MasterMapper.GetMHolidayEntity(iMaster as MHoliday));
            else if (iMaster.GetType().Equals(typeof(SerialNumber)))
                return (MasterMapper.GetSerialNumberEntity(iMaster as SerialNumber));
            else if (iMaster.GetType().Equals(typeof(MUserRole)))
                return (MasterMapper.GetMUserRoleDomain(iMaster as MUserRole));
            else if (iMaster.GetType().Equals(typeof(MFunctions)))
                return (MasterMapper.GetMFunctionsEntity(iMaster as MFunctions));
            else if (iMaster.GetType().Equals(typeof(RUserFunctions)))
                return (MasterMapper.GetRUserFunctionsEntity(iMaster as RUserFunctions));
            else if (iMaster.GetType().Equals(typeof(RUserRoleSection)))
                return (MasterMapper.GetRUserRoleSectionEntity(iMaster as RUserRoleSection));
            else if (iMaster.GetType().Equals(typeof(RRoleFunctions)))
                return (MasterMapper.GetRRoleFunctionsEntity(iMaster as RRoleFunctions));
            else if (iMaster.GetType().Equals(typeof(MEMSLedger)))
                return (MasterMapper.GetMEMSLedgerDomain(iMaster as MEMSLedger));
            else if (iMaster.GetType().Equals(typeof(MEMSRecTransType)))
                return (MasterMapper.GetMEMSRecTransTypeDomain(iMaster as MEMSRecTransType));
            else if (iMaster.GetType().Equals(typeof(MEMSRecTransMode)))
                return (MasterMapper.GetMEMSRecTransModeDomain(iMaster as MEMSRecTransMode));
            else if (iMaster.GetType().Equals(typeof(MEMSRecBank)))
                return (MasterMapper.GetMEMSRecBankDomain(iMaster as MEMSRecBank));
            else if (iMaster.GetType().Equals(typeof(MEMSParam)))
                return (MasterMapper.GetMEMSParamDomain(iMaster as MEMSParam));
            else if (iMaster.GetType().Equals(typeof(MEMSAuctioneer)))
                return (MasterMapper.GetMEMSAuctioneerDomain(iMaster as MEMSAuctioneer));
            else if (iMaster.GetType().Equals(typeof(MFormSignature)))
                return (MasterMapper.GetMFormSignatureEntity(iMaster as MFormSignature));
            else if (iMaster.GetType().Equals(typeof(MEMSApptType)))
                return (MasterMapper.GetMEMSApptTypeDomain(iMaster as MEMSApptType));
            else if (iMaster.GetType().Equals(typeof(MEMSApptReason)))
                return (MasterMapper.GetMEMSApptReasonDomain(iMaster as MEMSApptReason));
            else if (iMaster.GetType().Equals(typeof(MEMSApptOutcome)))
                return (MasterMapper.GetMEMSApptOutcomeDomain(iMaster as MEMSApptOutcome));
            else if (iMaster.GetType().Equals(typeof(MEMSAdvertIn)))
                return (MasterMapper.GetMEMSAdvertInDomain(iMaster as MEMSAdvertIn));
            else if (iMaster.GetType().Equals(typeof(MEMSAdvertiser)))
                return (MasterMapper.GetMEMSAdvertiserDomain(iMaster as MEMSAdvertiser));
            else if (iMaster.GetType().Equals(typeof(MEMSAppraiser)))
                return (MasterMapper.GetMEMSAppraiserDomain(iMaster as MEMSAppraiser));
            else if (iMaster.GetType().Equals(typeof(MEMSAttendanceFee)))
                return (MasterMapper.GetMEMSAttendanceFeeDomain(iMaster as MEMSAttendanceFee));
            else if (iMaster.GetType().Equals(typeof(MEMSCourtComm)))
                return (MasterMapper.GetMEMSCourtCommDomain(iMaster as MEMSCourtComm));
            else if (iMaster.GetType().Equals(typeof(MEMSDisburseRate)))
                return (MasterMapper.GetMEMSDisburseRateDomain(iMaster as MEMSDisburseRate));
            else if (iMaster.GetType().Equals(typeof(MEMSFileMoveDesc)))
                return (MasterMapper.GetMEMSFileMoveDescDomain(iMaster as MEMSFileMoveDesc));
            else if (iMaster.GetType().Equals(typeof(MEMSNatureOfPayment)))
                return (MasterMapper.GetMEMSNatureOfPaymentDomain(iMaster as MEMSNatureOfPayment));
            else if (iMaster.GetType().Equals(typeof(MEMSSalesAgent)))
                return (MasterMapper.GetMEMSSalesAgentDomain(iMaster as MEMSSalesAgent));
            else if (iMaster.GetType().Equals(typeof(MEMSWritAppt)))
                return (MasterMapper.GetMEMSWritApptDomain(iMaster as MEMSWritAppt));
            else if (iMaster.GetType().Equals(typeof(MWithDrawalInType)))
                return (MasterMapper.GetMWithDrawalInTypeEntity(iMaster as MWithDrawalInType));
            else if (iMaster.GetType().Equals(typeof(MWithDrawalOfType)))
                return (MasterMapper.GetMWithDrawalOfTypeEntity(iMaster as MWithDrawalOfType));
            else if (iMaster.GetType().Equals(typeof(MCaseIssue)))
                return (MasterMapper.GetMCaseIssueDomain(iMaster as MCaseIssue));
            else if (iMaster.GetType().Equals(typeof(MExternalAgencyAddress)))
                return (MasterMapper.GetMExternalAgencyAddressEntity(iMaster as MExternalAgencyAddress));
            else if (iMaster.GetType().Equals(typeof(MExternalAgency)))
                return (MasterMapper.GetMExternalAgencyEntity(iMaster as MExternalAgency));
            else if (iMaster.GetType().Equals(typeof(MPartyType)))
                return (MasterMapper.GetMPartyTypeEntity(iMaster as MPartyType));
            else if (iMaster.GetType().Equals(typeof(MCountry)))
                return (MasterMapper.GetMCountryEntity(iMaster as MCountry));
            else if (iMaster.GetType().Equals(typeof(RMRoutingSectionConfig)))
                return (MasterMapper.GetRMRoutingSectionConfigEntity(iMaster as RMRoutingSectionConfig));
            else if (iMaster.GetType().Equals(typeof(MAASLawDegree)))
                return (MasterMapper.GetMAASLawDegreeEntity(iMaster as MAASLawDegree));
            else if (iMaster.GetType().Equals(typeof(MSequenceKey)))
                return (MasterMapper.GetMSequenceKeyEntity(iMaster as MSequenceKey));
            else if (iMaster.GetType().Equals(typeof(MEMSSecurityGuard)))
                return (MasterMapper.GetMEMSSecurityGuardEntity(iMaster as MEMSSecurityGuard));
            else if (iMaster.GetType().Equals(typeof(MAASDisciplinaryResultType)))
                return (MasterMapper.GetMAASDisciplinaryResultTypeEntity(iMaster as MAASDisciplinaryResultType));
            else if (iMaster.GetType().Equals(typeof(MLimitations)))
                return (MasterMapper.GetMLimitationsEntity(iMaster as MLimitations));
            else if (iMaster.GetType().Equals(typeof(MHearingType)))
                return (MasterMapper.GetMHearingTypeEntity(iMaster as MHearingType));
            else if (iMaster.GetType().Equals(typeof(RMPartyTypeCaseType)))
                return (MasterMapper.GetRMPartyTypeCaseTypeEntity(iMaster as RMPartyTypeCaseType));
            else if (iMaster.GetType().Equals(typeof(MMassCallHrgDate)))
                return (MasterMapper.GetMMassCallHrgDateEntity(iMaster as MMassCallHrgDate));
            else if (iMaster.GetType().Equals(typeof(MChargeOutcome)))
                return (MasterMapper.GetMChargeOutcomeEntity(iMaster as MChargeOutcome));
            else if (iMaster.GetType().Equals(typeof(MForumType)))
                return (MasterMapper.GetMForumTypeEntity(iMaster as MForumType));

            else if (iMaster.GetType().Equals(typeof(MVSAConfigDetail)))
                return (MasterMapper.GetMVSAConfigDetailEntity(iMaster as MVSAConfigDetail));

            else if (iMaster.GetType().Equals(typeof(MVSAConfigGround)))
                return (MasterMapper.GetMVSAConfigGroundEntity(iMaster as MVSAConfigGround));

            else if (iMaster.GetType().Equals(typeof(MVSAConfigPrayer)))
                return (MasterMapper.GetMVSAConfigPrayerEntity(iMaster as MVSAConfigPrayer));

            else if (iMaster.GetType().Equals(typeof(MFilingFeeChargingMechanism)))
                return (MasterMapper.GetMFilingFeeChargingMechanismEntity(iMaster as MFilingFeeChargingMechanism));

            else if (iMaster.GetType().Equals(typeof(MFilingFeeLegislationAct)))
                return (MasterMapper.GetMFilingFeeLegislationActEntity(iMaster as MFilingFeeLegislationAct));

            else if (iMaster.GetType().Equals(typeof(MSummonsGrounds)))
                return (MasterMapper.GetMSummonsGroundsEntity(iMaster as MSummonsGrounds));

            else if (iMaster.GetType().Equals(typeof(MSummonsPrayers)))
                return (MasterMapper.GetMSummonsPrayersEntity(iMaster as MSummonsPrayers));

            else if (iMaster.GetType().Equals(typeof(RMDocFilterGroup)))
                return (MasterMapper.GetRMDocFilterGroupEntity(iMaster as RMDocFilterGroup));

            else if (iMaster.GetType().Equals(typeof(MHRGPredefinedDate)))
                return (MasterMapper.GetMHRGPredefinedDateEntity(iMaster as MHRGPredefinedDate));

            else if (iMaster.GetType().Equals(typeof(RMCaseTypeHRGTypeJOL)))
                return (MasterMapper.GetRMCaseTypeHRGTypeJOLEntity(iMaster as RMCaseTypeHRGTypeJOL));

            else if (iMaster.GetType().Equals(typeof(MHRGBeforeType)))
                return (MasterMapper.GetMHRGBeforeTypeEntity(iMaster as MHRGBeforeType));

            else if (iMaster.GetType().Equals(typeof(RMSubCaseTypeHRGTypeMSType)))
                return (MasterMapper.GetRMSubCaseTypeHRGTypeMSTypeEntity(iMaster as RMSubCaseTypeHRGTypeMSType));

            else if (iMaster.GetType().Equals(typeof(MSensitiveFilingACL)))
                return (MasterMapper.GetMSensitiveFilingACLEntity(iMaster as MSensitiveFilingACL));

            else if (iMaster.GetType().Equals(typeof(MAASDisciplinaryType)))
                return (MasterMapper.GetMAASDisciplinaryTypeEntity(iMaster as MAASDisciplinaryType));

            else if (iMaster.GetType().Equals(typeof(MAASUniversity)))
                return (MasterMapper.GetMAASUniversityEntity(iMaster as MAASUniversity));

            else if (iMaster.GetType().Equals(typeof(RMHrgSlotNOC)))
                return (MasterMapper.GetRMHrgSlotNOCEntity(iMaster as RMHrgSlotNOC));

            else if (iMaster.GetType().Equals(typeof(RMHrgSlotLegis)))
                return (MasterMapper.GetRMHrgSlotLegisEntity(iMaster as RMHrgSlotLegis));

            else if (iMaster.GetType().Equals(typeof(RMDocControlExclusion)))
                return (MasterMapper.GetRMDocControlExclusionEntity(iMaster as RMDocControlExclusion));

            else if (iMaster.GetType().Equals(typeof(MResidential)))
                return (MasterMapper.GetMResidentialEntity(iMaster as MResidential));

            else if (iMaster.GetType().Equals(typeof(MIncome)))
                return (MasterMapper.GetMIncomeEntity(iMaster as MIncome));

            else if (iMaster.GetType().Equals(typeof(MDirections)))
                return (MasterMapper.GetMDirectionsEntity(iMaster as MDirections));

            else if (iMaster.GetType().Equals(typeof(MHarassPlace)))
                return (MasterMapper.GetMHarassPlaceEntity(iMaster as MHarassPlace));

            else
                return null;
        }

        public static MAASUniversityEntity GetMAASUniversityEntity(MAASUniversity mAASUniversity)
        {
            MAASUniversityEntity mAASUniversityEntity = null;

            try
            {
                mAASUniversityEntity = Mapper.Map<MAASUniversity, MAASUniversityEntity>(mAASUniversity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAASUniversityEntity", ex);
                throw;
            }

            return mAASUniversityEntity;
        }

        /**Criminal Master Tables**/
        /// <summary>
        /// Gets the <see cref="MBailTypeEntity"/> from <see cref="MBailType"/> input.
        /// </summary>
        /// <param name="mBailType"><see cref="MBailType"/></param>
        /// <returns>Returns <see cref="MBailTypeEntity"/>, else null.</returns>
        public static MBailTypeEntity GetMBailTypeEntity(MBailType mBailType)
        {
            MBailTypeEntity mBailTypeEntity = null;

            try
            {
                mBailTypeEntity = Mapper.Map<MBailType, MBailTypeEntity>(mBailType);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMBailTypeEntity", ex);
                throw;
            }

            return mBailTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MBankruptcyBasisEntity"/> from <see cref="MBankruptcyBasis"/> input.
        /// </summary>
        /// <param name="mBankruptcyBasis"><see cref="MBankruptcyBasis"/></param>
        /// <returns>Returns <see cref="MBankruptcyBasisEntity"/>, else null.</returns>
        public static MBankruptcyBasisEntity GetMBankruptcyBasisEntity(MBankruptcyBasis mBankruptcyBasis)
        {
            MBankruptcyBasisEntity mBankruptcyBasisEntity = null;

            try
            {
                mBankruptcyBasisEntity = Mapper.Map<MBankruptcyBasis, MBankruptcyBasisEntity>(mBankruptcyBasis);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMBankruptcyBasisEntity", ex);
                throw;
            }

            return mBankruptcyBasisEntity;
        }

        /// <summary>
        /// Gets the <see cref="MBankruptcyTypeEntity"/> from <see cref="MBankruptcyType"/> input.
        /// </summary>
        /// <param name="mBankruptcyType"><see cref="MBankruptcyType"/></param>
        /// <returns>Returns <see cref="MBankruptcyTypeEntity"/>, else null.</returns>
        public static MBankruptcyTypeEntity GetMBankruptcyTypeEntity(MBankruptcyType mBankruptcyType)
        {
            MBankruptcyTypeEntity mBankruptcyTypeEntity = null;

            try
            {
                mBankruptcyTypeEntity = Mapper.Map<MBankruptcyType, MBankruptcyTypeEntity>(mBankruptcyType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMBankruptcyTypeEntity", ex);
                throw;
            }

            return mBankruptcyTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MBasisForTaxationEntity"/> from <see cref="MBasisForTaxation"/> input.
        /// </summary>
        /// <param name="mBasisForTaxation"><see cref="MBasisForTaxation"/></param>
        /// <returns>Returns <see cref="MBasisForTaxationEntity"/>, else null.</returns>
        public static MBasisForTaxationEntity GetMBasisForTaxationEntity(MBasisForTaxation mBasisForTaxation)
        {
            MBasisForTaxationEntity mBasisForTaxationEntity = null;

            try
            {
                mBasisForTaxationEntity = Mapper.Map<MBasisForTaxation, MBasisForTaxationEntity>(mBasisForTaxation);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMBasisForTaxationEntity", ex);
                throw;
            }

            return mBasisForTaxationEntity;
        }

        /// <summary>
        /// Gets the <see cref="MBasisOfTaxationTypeEntity"/> from <see cref="MBasisOfTaxationType"/> input.
        /// </summary>
        /// <param name="mBasisOfTaxationType"><see cref="MBasisOfTaxationType"/></param>
        /// <returns>Returns <see cref="MBasisOfTaxationTypeEntity"/>, else null.</returns>
        public static MBasisOfTaxationTypeEntity GetMBasisOfTaxationTypeEntity(MBasisOfTaxationType mBasisOfTaxationType)
        {
            MBasisOfTaxationTypeEntity mBasisOfTaxationTypeEntity = null;

            try
            {
                mBasisOfTaxationTypeEntity = Mapper.Map<MBasisOfTaxationType, MBasisOfTaxationTypeEntity>(mBasisOfTaxationType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMBasisOfTaxationTypeEntity", ex);
                throw;
            }

            return mBasisOfTaxationTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MBillNatureEntity"/> from <see cref="MBillNature"/> input.
        /// </summary>
        /// <param name="mBillNature"><see cref="MBillNature"/></param>
        /// <returns>Returns <see cref="MBillNatureEntity"/>, else null.</returns>
        public static MBillNatureEntity GetMBillNatureEntity(MBillNature mBillNature)
        {
            MBillNatureEntity mBillNatureEntity = null;

            try
            {
                mBillNatureEntity = Mapper.Map<MBillNature, MBillNatureEntity>(mBillNature);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMBillNatureEntity", ex);
                throw;
            }

            return mBillNatureEntity;
        }

        /// <summary>
        /// Gets the <see cref="MBillTypeEntity"/> from <see cref="MBillType"/> input.
        /// </summary>
        /// <param name="mBillType"><see cref="MBillType"/></param>
        /// <returns>Returns <see cref="MBillTypeEntity"/>, else null.</returns>
        public static MBillTypeEntity GetMBillTypeEntity(MBillType mBillType)
        {
            MBillTypeEntity mBillTypeEntity = null;

            try
            {
                mBillTypeEntity = Mapper.Map<MBillType, MBillTypeEntity>(mBillType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMBillTypeEntity", ex);
                throw;
            }

            return mBillTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MAASOrganisationTypeEntity"/> from <see cref="MAASOrganisationType"/> input.
        /// </summary>
        /// <param name="mAASOrganisationType"><see cref="MAASOrganisationType"/></param>
        /// <returns>Returns <see cref="MAASOrganisationTypeEntity"/>, else null.</returns>
        public static MBusinessJobLegalDetailEntity GetMBusinessJobLegalDetailEntity(MBusinessJobLegalDetail mBusinessJobLegalDetail)
        {
            MBusinessJobLegalDetailEntity mBusinessJobLegalDetailEntity = null;

            try
            {
                mBusinessJobLegalDetailEntity = Mapper.Map<MBusinessJobLegalDetail, MBusinessJobLegalDetailEntity>(mBusinessJobLegalDetail);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMBusinessJobLegalDetailEntity", ex);
                throw;
            }

            return mBusinessJobLegalDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="MAASOrganisationTypeEntity"/> from <see cref="MAASOrganisationType"/> input.
        /// </summary>
        /// <param name="mAASOrganisationType"><see cref="MAASOrganisationType"/></param>
        /// <returns>Returns <see cref="MAASOrganisationTypeEntity"/>, else null.</returns>
        public static MBusinessJobLegalInfoEntity GetMBusinessJobLegalInfoEntity(MBusinessJobLegalInfo mBusinessJobLegalInfo)
        {
            MBusinessJobLegalInfoEntity mBusinessJobLegalInfoEntity = null;

            try
            {
                mBusinessJobLegalInfoEntity = Mapper.Map<MBusinessJobLegalInfo, MBusinessJobLegalInfoEntity>(mBusinessJobLegalInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMBusinessJobLegalInfoEntity", ex);
                throw;
            }

            return mBusinessJobLegalInfoEntity;
        }

        /// <summary>
        /// Get the MCaseIssue.
        /// </summary>
        /// <param name="mCaseIssueNHibernateEntity"></param>
        /// <returns></returns>
        public static MCaseIssueEntity GetMCaseIssueDomain(MCaseIssue mCaseIssueNHibernateEntity)
        {
            MCaseIssueEntity mCaseIssueDomainEntity = null;

            try
            {
                mCaseIssueDomainEntity = Mapper.Map<MCaseIssue, MCaseIssueEntity>(mCaseIssueNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMCaseIssueDomain", ex);
                throw;
            }

            return mCaseIssueDomainEntity;
        }

        /// <summary>
        /// Get the MCaseIssue.
        /// </summary>
        /// <param name="mCaseIssueNHibernateEntity"></param>
        /// <returns></returns>
        public static MProbateNatureGroupEntity GetMCaseIssueDomain(MProbateNatureGroup mProbateNatureGroup)
        {
            MProbateNatureGroupEntity mProbateNatureGroupEntity = null;

            try
            {
                mProbateNatureGroupEntity = Mapper.Map<MProbateNatureGroup, MProbateNatureGroupEntity>(mProbateNatureGroup);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMCaseIssueDomain", ex);
                throw;
            }

            return mProbateNatureGroupEntity;
        }

        /// <summary>
        /// Gets the <see cref="MCaseSecurityEntity"/> from <see cref="MCaseSecurity"/> input.
        /// </summary>
        /// <param name="mCaseSecurity"><see cref="MCaseSecurity"/></param>
        /// <returns>Returns <see cref="MCaseSecurityEntity"/>, else null.</returns>
        public static MCaseSecurityEntity GetMCaseSecurityEntity(MCaseSecurity mCaseSecurity)
        {
            MCaseSecurityEntity mCaseSecurityEntity = null;

            try
            {
                mCaseSecurityEntity = Mapper.Map<MCaseSecurity, MCaseSecurityEntity>(mCaseSecurity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCaseSecurityEntity", ex);
                throw;
            }

            return mCaseSecurityEntity;
        }

        /// <summary>
        /// Gets the <see cref="MCaseStatusEntity"/> from <see cref="MCaseStatus"/> input.
        /// </summary>
        /// <param name="mCaseStatus"><see cref="MCaseStatus"/></param>
        /// <returns>Returns <see cref="MCaseStatusEntity"/>, else null.</returns>
        public static MCaseStatusEntity GetMCaseStatusEntity(MCaseStatus mCaseStatus)
        {
            MCaseStatusEntity mCaseStatusEntity = null;

            try
            {
                mCaseStatusEntity = Mapper.Map<MCaseStatus, MCaseStatusEntity>(mCaseStatus);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCaseStatusEntity", ex);
                throw;
            }

            return mCaseStatusEntity;
        }

        /// <summary>
        /// Gets the <see cref="MCaseTypeEntity"/> from <see cref="MCaseType"/> input.
        /// </summary>
        /// <param name="mCaseType"><see cref="MCaseType"/></param>
        /// <returns>Returns <see cref="MCaseTypeEntity"/>, else null.</returns>
        public static MCaseTypeEntity GetMCaseTypeEntity(MCaseType mCaseType)
        {
            MCaseTypeEntity mCaseTypeEntity = null;

            try
            {
                mCaseTypeEntity = Mapper.Map<MCaseType, MCaseTypeEntity>(mCaseType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCaseTypeEntity", ex);
                throw;
            }

            return mCaseTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MCaseTypeGroupEntity"/> from <see cref="MCaseTypeGroup"/> input.
        /// </summary>
        /// <param name="mCaseTypeGroup"><see cref="MCaseTypeGroup"/></param>
        /// <returns>Returns <see cref="MCaseTypeGroupEntity"/>, else null.</returns>
        public static MCaseTypeGroupEntity GetMCaseTypeGroupEntity(MCaseTypeGroup mCaseTypeGroup)
        {
            MCaseTypeGroupEntity mCaseTypeGroupEntity = null;

            try
            {
                mCaseTypeGroupEntity = Mapper.Map<MCaseTypeGroup, MCaseTypeGroupEntity>(mCaseTypeGroup);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCaseTypeGroupEntity", ex);
                throw;
            }

            return mCaseTypeGroupEntity;
        }

        /// <summary>
        /// Gets the <see cref="MChargeTypeEntity"/> from <see cref="MChargeType"/> input.
        /// </summary>
        /// <param name="mChargeType"><see cref="MChargeType"/></param>
        /// <returns>Returns <see cref="MChargeTypeEntity"/>, else null.</returns>
        public static MChargeTypeEntity GetMChargeTypeEntity(MChargeType mChargeType)
        {
            MChargeTypeEntity mChargeTypeEntity = null;

            try
            {
                mChargeTypeEntity = Mapper.Map<MChargeType, MChargeTypeEntity>(mChargeType);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMChargeTypeEntity", ex);
                throw;
            }

            return mChargeTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MChecklistDocumentEntity"/> from <see cref="MChecklistDocument"/> input.
        /// </summary>
        /// <param name="mChecklistDocument"><see cref="MChecklistDocument"/></param>
        /// <returns>Returns <see cref="MChecklistDocumentEntity"/>, else null.</returns>
        public static MChecklistDocumentEntity GetMChecklistDocumentEntity(MChecklistDocument mChecklistDocument)
        {
            MChecklistDocumentEntity mChecklistDocumentEntity = null;

            try
            {
                mChecklistDocumentEntity = Mapper.Map<MChecklistDocument, MChecklistDocumentEntity>(mChecklistDocument);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMChecklistDocumentEntity", ex);
                throw;
            }

            return mChecklistDocumentEntity;
        }

        /// <summary>
        /// Gets the <see cref="MChecklistEntity"/> from <see cref="MChecklist"/> input.
        /// </summary>
        /// <param name="mChecklist"><see cref="MChecklist"/></param>
        /// <returns>Returns <see cref="MChecklistEntity"/>, else null.</returns>
        public static MChecklistEntity GetMChecklistEntity(MChecklist mChecklist)
        {
            MChecklistEntity mChecklistEntity = null;

            try
            {
                mChecklistEntity = Mapper.Map<MChecklist, MChecklistEntity>(mChecklist);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMChecklistEntity", ex);
                throw;
            }

            return mChecklistEntity;
        }

        /// <summary>
        /// Gets the <see cref="MClaimTypeEntity"/> from <see cref="MClaimType"/> input.
        /// </summary>
        /// <param name="mClaimType"><see cref="MClaimType"/></param>
        /// <returns>Returns <see cref="MClaimTypeEntity"/>, else null.</returns>
        public static MClaimTypeEntity GetMClaimTypeEntity(MClaimType mClaimType)
        {
            MClaimTypeEntity mClaimTypeEntity = null;

            try
            {
                mClaimTypeEntity = Mapper.Map<MClaimType, MClaimTypeEntity>(mClaimType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMClaimTypeEntity", ex);
                throw;
            }

            return mClaimTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MCoramEntity"/> from <see cref="MCoram"/> input.
        /// </summary>
        /// <param name="MCoram"><see cref="MCoram"/></param>
        /// <returns>Returns <see cref="MCoramEntity"/>, else null.</returns>
        public static MCoramEntity GetMCoramEntity(MCoram mCoram)
        {
            MCoramEntity mCoramEntity = null;

            try
            {
                mCoramEntity = Mapper.Map<MCoram, MCoramEntity>(mCoram);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCoramEntity", ex);
                throw;
            }

            return mCoramEntity;
        }

        /// <summary>
        /// Gets the <see cref="MCountryEntity"/> from <see cref="MCountry"/> input.
        /// </summary>
        /// <param name="mCountry"><see cref="MCountry"/></param>
        /// <returns>Returns <see cref="MCountryEntity"/>, else null.</returns>
        public static MCountryEntity GetMCountryEntity(MCountry mCountry)
        {
            MCountryEntity mCountryEntity = null;

            try
            {
                mCountryEntity = Mapper.Map<MCountry, MCountryEntity>(mCountry);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCountryEntity", ex);
                throw;
            }

            return mCountryEntity;
        }

        /// <summary>
        /// Gets the <see cref="MCourtTypeEntity"/> from <see cref="MCourtType"/> input.
        /// </summary>
        /// <param name="mCourtType"><see cref="MCourtType"/></param>
        /// <returns>Returns <see cref="MCourtTypeEntity"/>, else null.</returns>
        public static MCourtTypeEntity GetMCourtTypeEntity(MCourtType mCourtType)
        {
            MCourtTypeEntity mCourtTypeEntity = null;

            try
            {
                mCourtTypeEntity = Mapper.Map<MCourtType, MCourtTypeEntity>(mCourtType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCourtTypeEntity", ex);
                throw;
            }

            return mCourtTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MCriminalClaimantTypeEntity"/> from <see cref="MCriminalClaimantType"/> input.
        /// </summary>
        /// <param name="mCriminalClaimantType"><see cref="MCriminalClaimantType"/></param>
        /// <returns>Returns <see cref="MCriminalClaimantTypeEntity"/>, else null.</returns>
        public static MCriminalClaimantTypeEntity GetMCriminalClaimantTypeEntity(MCriminalClaimantType mCriminalClaimantType)
        {
            MCriminalClaimantTypeEntity mCriminalClaimantTypeEntity = null;

            try
            {
                mCriminalClaimantTypeEntity = Mapper.Map<MCriminalClaimantType, MCriminalClaimantTypeEntity>(mCriminalClaimantType);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCriminalClaimantTypeEntity", ex);
                throw;
            }

            return mCriminalClaimantTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MCriminalClaimTypeEntity"/> from <see cref="MCriminalClaimType"/> input.
        /// </summary>
        /// <param name="mCriminalClaimType"><see cref="MCriminalClaimType"/></param>
        /// <returns>Returns <see cref="MCriminalClaimTypeEntity"/>, else null.</returns>
        public static MCriminalClaimTypeEntity GetMCriminalClaimTypeEntity(MCriminalClaimType mCriminalClaimType)
        {
            MCriminalClaimTypeEntity mCriminalClaimTypeEntity = null;

            try
            {
                mCriminalClaimTypeEntity = Mapper.Map<MCriminalClaimType, MCriminalClaimTypeEntity>(mCriminalClaimType);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCriminalClaimTypeEntity", ex);
                throw;
            }

            return mCriminalClaimTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MCriminalOrderEntity"/> from <see cref="MCriminalOrder"/> input.
        /// </summary>
        /// <param name="mCriminalOrder"><see cref="MCriminalOrder"/></param>
        /// <returns>Returns <see cref="MCriminalOrderEntity"/>, else null.</returns>
        public static MCriminalOrderEntity GetMCriminalOrderEntity(MCriminalOrder mCriminalOrder)
        {
            MCriminalOrderEntity mCriminalOrderEntity = null;

            try
            {
                mCriminalOrderEntity = Mapper.Map<MCriminalOrder, MCriminalOrderEntity>(mCriminalOrder);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCriminalOrderEntity", ex);
                throw;
            }

            return mCriminalOrderEntity;
        }

        /// <summary>
        /// Gets the <see cref="MCurrencyEntity"/> from <see cref="MCurrency"/> input.
        /// </summary>
        /// <param name="mCurrency"><see cref="MCurrency"/></param>
        /// <returns>Returns <see cref="MCurrencyEntity"/>, else null.</returns>
        public static MCurrencyEntity GetMCurrencyEntity(MCurrency mCurrency)
        {
            MCurrencyEntity mCurrencyEntity = null;

            try
            {
                mCurrencyEntity = Mapper.Map<MCurrency, MCurrencyEntity>(mCurrency);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCurrencyEntity", ex);
                throw;
            }

            return mCurrencyEntity;
        }

        /// <summary>
        /// Gets the <see cref="MDamageEntity"/> from <see cref="MDamage"/> input.
        /// </summary>
        /// <param name="mDamage"><see cref="MDamage"/></param>
        /// <returns>Returns <see cref="MDamageEntity"/>, else null.</returns>
        public static MDamageEntity GetMDamageEntity(MDamage mDamage)
        {
            MDamageEntity mDamageEntity = null;

            try
            {
                mDamageEntity = Mapper.Map<MDamage, MDamageEntity>(mDamage);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDamageEntity", ex);
                throw;
            }

            return mDamageEntity;
        }

        /// <summary>
        /// Gets the <see cref="MDeedTypeEntity"/> from <see cref="MDeedType"/> input.
        /// </summary>
        /// <param name="mDeedType"><see cref="MDeedType"/></param>
        /// <returns>Returns <see cref="MDeedTypeEntity"/>, else null.</returns>
        public static MDeedTypeEntity GetMDeedTypeEntity(MDeedType mDeedType)
        {
            MDeedTypeEntity mDeedTypeEntity = null;

            try
            {
                mDeedTypeEntity = Mapper.Map<MDeedType, MDeedTypeEntity>(mDeedType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDeedTypeEntity", ex);
                throw;
            }

            return mDeedTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MDesignationEntity"/> from <see cref="MDesignation"/> input.
        /// </summary>
        /// <param name="mDesignation"><see cref="MDesignation"/></param>
        /// <returns>Returns <see cref="MDesignationEntity"/>, else null.</returns>
        public static MDesignationEntity GetMDesignationEntity(MDesignation mDesignation)
        {
            MDesignationEntity mDesignationEntity = null;

            try
            {
                mDesignationEntity = Mapper.Map<MDesignation, MDesignationEntity>(mDesignation);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDesignationEntity", ex);
                throw;
            }

            return mDesignationEntity;
        }

        /// <summary>
        /// Gets the <see cref="MDialectEntity"/> from <see cref="MDialect"/> input.
        /// </summary>
        /// <param name="mDialect"><see cref="MDialect"/></param>
        /// <returns>Returns <see cref="MDialectEntity"/>, else null.</returns>
        public static MDialectEntity GetMDialectEntity(MDialect mDialect)
        {
            MDialectEntity mDialectEntity = null;

            try
            {
                mDialectEntity = Mapper.Map<MDialect, MDialectEntity>(mDialect);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDialectEntity", ex);
                throw;
            }

            return mDialectEntity;
        }

        /// <summary>
        /// Gets the <see cref="MDocCategoryEntity"/> from <see cref="MDocCategory"/> input.
        /// </summary>
        /// <param name="MDocCategory"><see cref="MDocCategory"/></param>
        /// <returns>Returns <see cref="MDocCategoryEntity"/>, else null.</returns>
        public static MDocCategoryEntity GetMDocCategoryEntity(MDocCategory mDocCategory)
        {
            MDocCategoryEntity mDocCategoryEntity = null;

            try
            {
                mDocCategoryEntity = Mapper.Map<MDocCategory, MDocCategoryEntity>(mDocCategory);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDocCategoryEntity", ex);
                throw;
            }

            return mDocCategoryEntity;
        }

        /// <summary>
        /// Gets the <see cref="MDocCodeEntity"/> from <see cref="MDocCode"/> input.
        /// </summary>
        /// <param name="mDocCode"><see cref="MDocCode"/></param>
        /// <returns>Returns <see cref="MDocCodeEntity"/>, else null.</returns>
        public static MDocCodeEntity GetMDocCodeEntity(MDocCode mDocCode)
        {
            MDocCodeEntity MDocCodeEntity = null;

            try
            {
                if (mDocCode != null)
                {
                    MDocCodeEntity = Mapper.Map<MDocCode, MDocCodeEntity>(mDocCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDocCodeEntity", ex);
                throw;
            }

            return MDocCodeEntity;
        }

        public static MDocControlEntity GetMDocControlEntity(MDocControl mDocControl)
        {
            MDocControlEntity mDocControlEntity = null;

            try
            {
                if (mDocControl != null)
                {
                    mDocControlEntity = Mapper.Map<MDocControl, MDocControlEntity>(mDocControl);
                    mDocControlEntity.CaseTypeCode = Mapper.Map<MCaseType, MCaseTypeEntity>(mDocControl.MDCCaseType);
                    mDocControlEntity.SubCaseTypeCode = Mapper.Map<MCaseType, MCaseTypeEntity>(mDocControl.MDCSubCaseType);
                    mDocControlEntity.CourtInd = Mapper.Map<MCourtType, MCourtTypeEntity>(mDocControl.MCourtType);
                    mDocControlEntity.MDocCode = Mapper.Map<MDocCode, MDocCodeEntity>(mDocControl.MDocCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDocControlEntity", ex);
                throw;
            }

            return mDocControlEntity;
        }

        /// <summary>
        /// Gets the <see cref="MDocLegislationEntity"/> from <see cref="MDocLegislation"/> input.
        /// </summary>
        /// <param name="mDocLegislation"><see cref="MDocLegislation"/></param>
        /// <returns>Returns <see cref="MDocLegislationEntity"/>, else null.</returns>
        public static MDocLegislationEntity GetMDocLegislationEntity(MDocLegislation mDocLegislation)
        {
            MDocLegislationEntity mDocLegislationEntity = null;

            try
            {
                mDocLegislationEntity = Mapper.Map<MDocLegislation, MDocLegislationEntity>(mDocLegislation);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDocLegislationEntity", ex);
                throw;
            }

            return mDocLegislationEntity;
        }

        /// <summary>
        /// Gets the <see cref="MDocNatureEntity"/> from <see cref="MDocNature"/> input.
        /// </summary>
        /// <param name="mDocNature"><see cref="MDocNature"/></param>
        /// <returns>Returns <see cref="MDocNatureEntity"/>, else null.</returns>
        public static MDocNatureEntity GetMDocNatureEntity(MDocNature mDocNature)
        {
            MDocNatureEntity mDocNatureEntity = null;

            try
            {
                mDocNatureEntity = Mapper.Map<MDocNature, MDocNatureEntity>(mDocNature);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDocNatureEntity", ex);
                throw;
            }

            return mDocNatureEntity;
        }

        /// <summary>
        /// Gets the <see cref="MDocSecurityEntity"/> from <see cref="MDocSecurity"/> input.
        /// </summary>
        /// <param name="mDocSecurity"><see cref="MDocSecurity"/></param>
        /// <returns>Returns <see cref="MDocSecurityEntity"/>, else null.</returns>
        public static MDocSecurityEntity GetMDocSecurityEntity(MDocSecurity mDocSecurity)
        {
            MDocSecurityEntity mDocSecurityEntity = null;

            try
            {
                mDocSecurityEntity = Mapper.Map<MDocSecurity, MDocSecurityEntity>(mDocSecurity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDocSecurityEntity", ex);
                throw;
            }

            return mDocSecurityEntity;
        }

        /// <summary>
        /// Gets the <see cref="MDocStatusEntity"/> from <see cref="MDocStatus"/> input.
        /// </summary>
        /// <param name="mDocStatus"><see cref="MDocStatus"/></param>
        /// <returns>Returns <see cref="MDocStatusEntity"/>, else null.</returns>
        public static MDocStatusEntity GetMDocStatusEntity(MDocStatus mDocStatus)
        {
            MDocStatusEntity mDocStatusEntity = null;

            try
            {
                mDocStatusEntity = Mapper.Map<MDocStatus, MDocStatusEntity>(mDocStatus);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDocStatusEntity", ex);
                throw;
            }

            return mDocStatusEntity;
        }

        /// <summary>
        /// Gets the <see cref="MDrivingLicenseEntity"/> from <see cref="MDrivingLicense"/> input.
        /// </summary>
        /// <param name="mDrivingLicense"><see cref="MDrivingLicense"/></param>
        /// <returns>Returns <see cref="MDrivingLicenseEntity"/>, else null.</returns>
        public static MDrivingLicenseEntity GetMDrivingLicenseEntity(MDrivingLicense mDrivingLicense)
        {
            MDrivingLicenseEntity mDrivingLicenseEntity = null;

            try
            {
                mDrivingLicenseEntity = Mapper.Map<MDrivingLicense, MDrivingLicenseEntity>(mDrivingLicense);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDrivingLicenseEntity", ex);
                throw;
            }

            return mDrivingLicenseEntity;
        }

        /// <summary>
        /// Gets the <see cref="MDrugEntity"/> from <see cref="MDrug"/> input.
        /// </summary>
        /// <param name="mDrug"><see cref="MDrug"/></param>
        /// <returns>Returns <see cref="MDrugEntity"/>, else null.</returns>
        public static MDrugEntity GetMDrugEntity(MDrug mDrug)
        {
            MDrugEntity mDrugEntity = null;

            try
            {
                mDrugEntity = Mapper.Map<MDrug, MDrugEntity>(mDrug);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDrugEntity", ex);
                throw;
            }

            return mDrugEntity;
        }

        /// <summary>
        /// Get the MEMSAdvertIn.
        /// </summary>
        /// <param name="mEMSAdvertInNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSAdvertInEntity GetMEMSAdvertInDomain(MEMSAdvertIn mEMSAdvertInNHibernateEntity)
        {
            MEMSAdvertInEntity mEMSAdvertInDomainEntity = null;

            try
            {
                mEMSAdvertInDomainEntity = Mapper.Map<MEMSAdvertIn, MEMSAdvertInEntity>(mEMSAdvertInNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSAdvertInDomain", ex);
                throw;
            }

            return mEMSAdvertInDomainEntity;
        }

        /// <summary>
        /// Get the MEMSAdvertiser.
        /// </summary>
        /// <param name="mEMSAdvertiserNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSAdvertiserEntity GetMEMSAdvertiserDomain(MEMSAdvertiser mEMSAdvertiserNHibernateEntity)
        {
            MEMSAdvertiserEntity mEMSAdvertiserDomainEntity = null;

            try
            {
                mEMSAdvertiserDomainEntity = Mapper.Map<MEMSAdvertiser, MEMSAdvertiserEntity>(mEMSAdvertiserNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSAdvertiserDomain", ex);
                throw;
            }

            return mEMSAdvertiserDomainEntity;
        }

        /// <summary>
        /// Get the MEMSAppraiser.
        /// </summary>
        /// <param name="mEMSAppraiserNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSAppraiserEntity GetMEMSAppraiserDomain(MEMSAppraiser mEMSAppraiserNHibernateEntity)
        {
            MEMSAppraiserEntity mEMSAppraiserDomainEntity = null;

            try
            {
                mEMSAppraiserDomainEntity = Mapper.Map<MEMSAppraiser, MEMSAppraiserEntity>(mEMSAppraiserNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSAppraiserDomain", ex);
                throw;
            }

            return mEMSAppraiserDomainEntity;
        }

        /// <summary>
        /// Get the MEMSApptOutcome.
        /// </summary>
        /// <param name="mEMSApptOutcomeNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSApptOutcomeEntity GetMEMSApptOutcomeDomain(MEMSApptOutcome mEMSApptOutcomeNHibernateEntity)
        {
            MEMSApptOutcomeEntity mEMSApptOutcomeDomainEntity = null;

            try
            {
                mEMSApptOutcomeDomainEntity = Mapper.Map<MEMSApptOutcome, MEMSApptOutcomeEntity>(mEMSApptOutcomeNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSApptOutcomeDomain", ex);
                throw;
            }

            return mEMSApptOutcomeDomainEntity;
        }

        /// <summary>
        /// Get the MEMSApptReason.
        /// </summary>
        /// <param name="mEMSApptReasonNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSApptReasonEntity GetMEMSApptReasonDomain(MEMSApptReason mEMSApptReasonNHibernateEntity)
        {
            MEMSApptReasonEntity mEMSApptReasonDomainEntity = null;

            try
            {
                mEMSApptReasonDomainEntity = Mapper.Map<MEMSApptReason, MEMSApptReasonEntity>(mEMSApptReasonNHibernateEntity);
                mEMSApptReasonDomainEntity.MEMSApptOutcome = Mapper.Map<MEMSApptOutcome, MEMSApptOutcomeEntity>(mEMSApptReasonNHibernateEntity.MEMSApptOutcome);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSApptReasonDomain", ex);
                throw;
            }

            return mEMSApptReasonDomainEntity;
        }

        /// <summary>
        /// Get the MEMSApptType.
        /// </summary>
        /// <param name="mEMSApptTypeNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSApptTypeEntity GetMEMSApptTypeDomain(MEMSApptType mEMSApptTypeNHibernateEntity)
        {
            MEMSApptTypeEntity mEMSApptTypeDomainEntity = null;

            try
            {
                mEMSApptTypeDomainEntity = Mapper.Map<MEMSApptType, MEMSApptTypeEntity>(mEMSApptTypeNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSApptTypeDomain", ex);
                throw;
            }

            return mEMSApptTypeDomainEntity;
        }

        /// <summary>
        /// Get the MEMSAttendanceFee.
        /// </summary>
        /// <param name="mEMSAttendanceFeeNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSAttendanceFeeEntity GetMEMSAttendanceFeeDomain(MEMSAttendanceFee mEMSAttendanceFeeNHibernateEntity)
        {
            MEMSAttendanceFeeEntity mEMSAttendanceFeeDomainEntity = null;

            try
            {
                mEMSAttendanceFeeDomainEntity = Mapper.Map<MEMSAttendanceFee, MEMSAttendanceFeeEntity>(mEMSAttendanceFeeNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSAttendanceFeeDomain", ex);
                throw;
            }

            return mEMSAttendanceFeeDomainEntity;
        }

        /// <summary>
        /// Get the MEMSAuctioneer.
        /// </summary>
        /// <param name="mEMSAuctioneerNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSAuctioneerEntity GetMEMSAuctioneerDomain(MEMSAuctioneer mEMSAuctioneerNHibernateEntity)
        {
            MEMSAuctioneerEntity mEMSAuctioneerDomainEntity = null;

            try
            {
                mEMSAuctioneerDomainEntity = Mapper.Map<MEMSAuctioneer, MEMSAuctioneerEntity>(mEMSAuctioneerNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSAuctioneerDomain", ex);
                throw;
            }

            return mEMSAuctioneerDomainEntity;
        }

        /// <summary>
        /// Get the MEMSCourtComm.
        /// </summary>
        /// <param name="mEMSCourtCommNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSCourtCommEntity GetMEMSCourtCommDomain(MEMSCourtComm mEMSCourtCommNHibernateEntity)
        {
            MEMSCourtCommEntity mEMSCourtCommDomainEntity = null;

            try
            {
                mEMSCourtCommDomainEntity = Mapper.Map<MEMSCourtComm, MEMSCourtCommEntity>(mEMSCourtCommNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSCourtCommDomain", ex);
                throw;
            }

            return mEMSCourtCommDomainEntity;
        }

        /// <summary>
        /// Get the MEMSDisburseRate.
        /// </summary>
        /// <param name="mEMSDisburseRateNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSDisburseRateEntity GetMEMSDisburseRateDomain(MEMSDisburseRate mEMSDisburseRateNHibernateEntity)
        {
            MEMSDisburseRateEntity mEMSDisburseRateDomainEntity = null;

            try
            {
                mEMSDisburseRateDomainEntity = Mapper.Map<MEMSDisburseRate, MEMSDisburseRateEntity>(mEMSDisburseRateNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSDisburseRateDomain", ex);
                throw;
            }

            return mEMSDisburseRateDomainEntity;
        }

        /// <summary>
        /// Get the MEMSFileMoveDesc.
        /// </summary>
        /// <param name="mEMSFileMoveDescNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSFileMoveDescEntity GetMEMSFileMoveDescDomain(MEMSFileMoveDesc mEMSFileMoveDescNHibernateEntity)
        {
            MEMSFileMoveDescEntity mEMSFileMoveDescDomainEntity = null;

            try
            {
                mEMSFileMoveDescDomainEntity = Mapper.Map<MEMSFileMoveDesc, MEMSFileMoveDescEntity>(mEMSFileMoveDescNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSFileMoveDescDomain", ex);
                throw;
            }

            return mEMSFileMoveDescDomainEntity;
        }

        /// <summary>
        /// Get the MEMSLedger.
        /// </summary>
        /// <param name="mEMSLedgerNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSLedgerEntity GetMEMSLedgerDomain(MEMSLedger mEMSLedgerNHibernateEntity)
        {
            MEMSLedgerEntity mEMSLedgerDomainEntity = null;

            try
            {
                mEMSLedgerDomainEntity = Mapper.Map<MEMSLedger, MEMSLedgerEntity>(mEMSLedgerNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSLedgerDomain", ex);
                throw;
            }

            return mEMSLedgerDomainEntity;
        }

        /// <summary>
        /// Get the MEMSNatureOfPayment.
        /// </summary>
        /// <NatureOfPayment name="mEMSNatureOfPaymentNHibernateEntity"></NatureOfPayment>
        /// <returns></returns>
        public static MEMSNatureOfPaymentEntity GetMEMSNatureOfPaymentDomain(MEMSNatureOfPayment mEMSNatureOfPaymentNHibernateEntity)
        {
            MEMSNatureOfPaymentEntity mEMSNatureOfPaymentDomainEntity = null;

            try
            {
                mEMSNatureOfPaymentDomainEntity = Mapper.Map<MEMSNatureOfPayment, MEMSNatureOfPaymentEntity>(mEMSNatureOfPaymentNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSNatureOfPaymentDomain", ex);
                throw;
            }

            return mEMSNatureOfPaymentDomainEntity;
        }

        /// <summary>
        /// Get the MEMSParam.
        /// </summary>
        /// <param name="mEMSParamNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSParamEntity GetMEMSParamDomain(MEMSParam mEMSParamNHibernateEntity)
        {
            MEMSParamEntity mEMSParamDomainEntity = null;

            try
            {
                mEMSParamDomainEntity = Mapper.Map<MEMSParam, MEMSParamEntity>(mEMSParamNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSParamDomain", ex);
                throw;
            }

            return mEMSParamDomainEntity;
        }

        /// <summary>
        /// Get the MEMSRecBank.
        /// </summary>
        /// <param name="mEMSRecBankNHibernateEntity"></param>
        /// <returns>MEMSRecBankEntity</returns>
        public static MEMSRecBankEntity GetMEMSRecBankDomain(MEMSRecBank mEMSRecBankNHibernateEntity)
        {
            MEMSRecBankEntity mEMSRecBankDomainEntity = null;

            try
            {
                mEMSRecBankDomainEntity = Mapper.Map<MEMSRecBank, MEMSRecBankEntity>(mEMSRecBankNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSRecBankDomain", ex);
                throw;
            }

            return mEMSRecBankDomainEntity;
        }

        /// <summary>
        /// Get the MEMSRecTransMode.
        /// </summary>
        /// <param name="mWorkPeriodNHibernateEntity"></param>
        /// <returns>MEMSRecTransModeEntity</returns>
        public static MEMSRecTransModeEntity GetMEMSRecTransModeDomain(MEMSRecTransMode mEMSRecTransModeNHibernateEntity)
        {
            MEMSRecTransModeEntity mEMSRecTransModeDomainEntity = null;

            try
            {
                mEMSRecTransModeDomainEntity = Mapper.Map<MEMSRecTransMode, MEMSRecTransModeEntity>(mEMSRecTransModeNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSRecTransModeDomain", ex);
                throw;
            }

            return mEMSRecTransModeDomainEntity;
        }

        /// <summary>
        /// Get the MEMSRecTransType.
        /// </summary>
        /// <param name="mWorkPeriodNHibernateEntity"></param>
        /// <returns>MEMSRecTransTypeEntity</returns>
        public static MEMSRecTransTypeEntity GetMEMSRecTransTypeDomain(MEMSRecTransType mEMSRecTransTypeNHibernateEntity)
        {
            MEMSRecTransTypeEntity mEMSRecTransTypeDomainEntity = null;

            try
            {
                mEMSRecTransTypeDomainEntity = Mapper.Map<MEMSRecTransType, MEMSRecTransTypeEntity>(mEMSRecTransTypeNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSRecTransTypeDomain", ex);
                throw;
            }

            return mEMSRecTransTypeDomainEntity;
        }

        /// <summary>
        /// Get the MEMSSalesAgent.
        /// </summary>
        /// <param name="mEMSSalesAgentNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSSalesAgentEntity GetMEMSSalesAgentDomain(MEMSSalesAgent mEMSSalesAgentNHibernateEntity)
        {
            MEMSSalesAgentEntity mEMSSalesAgentDomainEntity = null;

            try
            {
                mEMSSalesAgentDomainEntity = Mapper.Map<MEMSSalesAgent, MEMSSalesAgentEntity>(mEMSSalesAgentNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSSalesAgentDomain", ex);
                throw;
            }

            return mEMSSalesAgentDomainEntity;
        }

        /*
        /// <summary>
        /// Gets the <see cref="MAASBLECertificationEntity"/> from <see cref="MAASBLECertification"/> input.
        /// </summary>
        /// <param name="mAASBLECertification"><see cref="MAASBLECertification"/></param>
        /// <returns>Returns <see cref="MAASBLECertificationEntity"/>, else null.</returns>
        public static MAASBLECertificationEntity GetMAASBLECertificationEntity(MAASBLECertification mAASBLECertification)
        {
            MAASBLECertificationEntity mAASBLECertificationEntity = null;

            try
            {
                mAASBLECertificationEntity = Mapper.Map<MAASBLECertification, MAASBLECertificationEntity>(mAASBLECertification);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAASBLECertificationEntity", ex);
                throw;
            }

            return mAASBLECertificationEntity;
        }*/
        /// <summary>
        /// Gets the <see cref="MEMSSecurityGuard"/> from <see cref="MEMSSecurityGuard"/> input.
        /// </summary>
        /// <param name="mEMSSecurityGuard"><see cref="MEMSSecurityGuard"/></param>
        /// <returns>Returns <see cref="MEMSSecurityGuardEntity"/>, else null.</returns>
        public static MEMSSecurityGuardEntity GetMEMSSecurityGuardEntity(MEMSSecurityGuard mEMSSecurityGuard)
        {
            MEMSSecurityGuardEntity mEMSSecurityGuardEntity = null;

            try
            {
                mEMSSecurityGuardEntity = Mapper.Map<MEMSSecurityGuard, MEMSSecurityGuardEntity>(mEMSSecurityGuard);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMEMSSecurityGuardEntity", ex);
                throw;
            }

            return mEMSSecurityGuardEntity;
        }

        /// <summary>
        /// Get the MEMSWritAppt.
        /// </summary>
        /// <param name="mEMSWritApptNHibernateEntity"></param>
        /// <returns></returns>
        public static MEMSWritApptEntity GetMEMSWritApptDomain(MEMSWritAppt mEMSWritApptNHibernateEntity)
        {
            MEMSWritApptEntity mEMSWritApptDomainEntity = null;

            try
            {
                mEMSWritApptDomainEntity = Mapper.Map<MEMSWritAppt, MEMSWritApptEntity>(mEMSWritApptNHibernateEntity);
                mEMSWritApptDomainEntity.MCaseType = Mapper.Map<MCaseType, MCaseTypeEntity>(mEMSWritApptNHibernateEntity.MCaseType);
                mEMSWritApptDomainEntity.MEMSApptType = Mapper.Map<MEMSApptType, MEMSApptTypeEntity>(mEMSWritApptNHibernateEntity.MEMSApptType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSWritApptDomain", ex);
                throw;
            }

            return mEMSWritApptDomainEntity;
        }

        /// Gets the <see cref="MEntityTypeEntity"/> from <see cref="MEntityType"/> input.
        /// </summary>
        /// <param name="mEntityType"><see cref="MEntityType"/></param>
        /// <returns>Returns <see cref="MEntityTypeEntity"/>, else null.</returns>
        public static MEntityTypeEntity GetMEntityTypeEntity(MEntityType mEntityType)
        {
            MEntityTypeEntity mEntityTypeEntity = null;

            try
            {
                mEntityTypeEntity = Mapper.Map<MEntityType, MEntityTypeEntity>(mEntityType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMEntityTypeEntity", ex);
                throw;
            }

            return mEntityTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MExternalAgencyAddressEntity"/> from <see cref="MExternalAgencyAddress"/> input.
        /// </summary>
        /// <param name="mExternalAgencyAddress"><see cref="MExternalAgencyAddress"/></param>
        /// <returns>Returns <see cref="MExternalAgencyAddressEntity"/>, else null.</returns>
        public static MExternalAgencyAddressEntity GetMExternalAgencyAddressEntity(MExternalAgencyAddress mExternalAgencyAddress)
        {
            MExternalAgencyAddressEntity mExternalAgencyAddressEntity = null;

            try
            {
                mExternalAgencyAddressEntity = Mapper.Map<MExternalAgencyAddress, MExternalAgencyAddressEntity>(mExternalAgencyAddress);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMExternalAgencyAddressEntity", ex);
                throw;
            }

            return mExternalAgencyAddressEntity;
        }

        /// <summary>
        /// Gets the <see cref="MExternalAgencyEntity"/> from <see cref="MExternalAgency"/> input.
        /// </summary>
        /// <param name="mExternalAgency"><see cref="MExternalAgency"/></param>
        /// <returns>Returns <see cref="MExternalAgencyEntity"/>, else null.</returns>
        public static MExternalAgencyEntity GetMExternalAgencyEntity(MExternalAgency mExternalAgency)
        {
            MExternalAgencyEntity mExternalAgencyEntity = null;

            try
            {
                mExternalAgencyEntity = Mapper.Map<MExternalAgency, MExternalAgencyEntity>(mExternalAgency);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMExternalAgencyEntity", ex);
                throw;
            }

            return mExternalAgencyEntity;
        }

        /// <summary>
        /// Gets the <see cref="MUserGroup"/> from <see cref="MUserGroupEntity"/> input.
        /// </summary>
        /// <param name="mUserGroupDomainEntity"><see cref="MUserGroupEntity"/></param>
        /// <returns>Returns <see cref="MUserGroup"/>, else null.</returns>
        public static MFilingFeeEntity GetMFilingFeeEntity(MFilingFee mFilingFee)
        {
            MFilingFeeEntity mFilingFeeEntity = null;

            try
            {
                mFilingFeeEntity = Mapper.Map<MFilingFee, MFilingFeeEntity>(mFilingFee);

                mFilingFeeEntity.MFilingFeeType = Mapper.Map<MFilingFeeType, MFilingFeeTypeEntity>(mFilingFee.MFilingFeeType);
                mFilingFeeEntity.MFilingFeeLegislationAct = Mapper.Map<MFilingFeeLegislationAct, MFilingFeeLegislationActEntity>(mFilingFee.MFilingFeeLegislationAct);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMFilingFeeEntity", ex);
                throw;
            }

            return mFilingFeeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MFilterGroupEntity"/> from <see cref="MFilterGroup"/> input.
        /// </summary>
        /// <param name="mFilterGroup"><see cref="MFilterGroup"/></param>
        /// <returns>Returns <see cref="MFilterGroupEntity"/>, else null.</returns>
        public static MFilterGroupEntity GetMFilterGroupEntity(MFilterGroup mFilterGroup)
        {
            MFilterGroupEntity mFilterGroupEntity = null;

            try
            {
                mFilterGroupEntity = Mapper.Map<MFilterGroup, MFilterGroupEntity>(mFilterGroup);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMFilterGroupEntity", ex);
                throw;
            }

            return mFilterGroupEntity;
        }

        /// <summary>
        /// Gets the <see cref="MFormSignatureEntity"/> from <see cref="MFormSignatureEntity"/> input.
        /// </summary>
        /// <param name="MFormSignature"><see cref="MFormSignature"/></param>
        /// <returns>Returns <see cref="MFormSignatureEntity"/>, else null.</returns>
        public static MFormSignatureEntity GetMFormSignatureEntity(MFormSignature mFormSignature)
        {
            MFormSignatureEntity mFormSignatureEntity = null;

            try
            {
                mFormSignatureEntity = Mapper.Map<MFormSignature, MFormSignatureEntity>(mFormSignature);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMFormSignatureEntity", ex);
                throw;
            }

            return mFormSignatureEntity;
        }

        /// <summary>
        /// Gets the <see cref="MSequenceKey"/> from <see cref="MSequenceKey"/> input.
        /// </summary>
        /// <param name="mSequenceKey"><see cref="MSequenceKey"/></param>
        /// <returns>Returns <see cref="MSequenceKeyEntity"/>, else null.</returns>
        public static MFormTemplateLocationEntity GetMFormTemplateLocationEntity(MFormTemplateLocation mFormTemplateLocation)
        {
            MFormTemplateLocationEntity mFormTemplateLocationEntity = null;

            try
            {
                mFormTemplateLocationEntity = Mapper.Map<MFormTemplateLocation, MFormTemplateLocationEntity>(mFormTemplateLocation);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMFormTemplateLocationEntity", ex);
                throw;
            }

            return mFormTemplateLocationEntity;
        }

        /// <summary>
        /// Gets the <see cref="MForumTypeEntity"/> from <see cref="MForumType"/> input.
        /// </summary>
        /// <param name="mForumType"><see cref="MForumType"/></param>
        /// <returns>Returns <see cref="MForumTypeEntity"/>, else null.</returns>
        public static MForumTypeEntity GetMForumTypeEntity(MForumType mForumType)
        {
            MForumTypeEntity mForumTypeEntity = null;

            try
            {
                mForumTypeEntity = Mapper.Map<MForumType, MForumTypeEntity>(mForumType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMForumTypeEntity", ex);
                throw;
            }

            return mForumTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MFunctionsEntity"/> from <see cref="MFunctions"/> input.
        /// </summary>
        /// <param name="mFunctions"><see cref="MFunctions"/></param>
        /// <returns>Returns <see cref="MFunctionsEntity"/>, else null.</returns>
        public static MFunctionsEntity GetMFunctionsEntity(MFunctions mFunctions)
        {
            MFunctionsEntity mFunctionsEntity = null;

            try
            {
                mFunctionsEntity = Mapper.Map<MFunctions, MFunctionsEntity>(mFunctions);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMFunctionsEntity", ex);
                throw;
            }

            return mFunctionsEntity;
        }

        /// <summary>
        /// Gets the <see cref="MGenderEntity"/> from <see cref="MGender"/> input.
        /// </summary>
        /// <param name="mGender"><see cref="MGender"/></param>
        /// <returns>Returns <see cref="MGenderEntity"/>, else null.</returns>
        public static MGenderEntity GetMGenderEntity(MGender mGender)
        {
            MGenderEntity mGenderEntity = null;

            try
            {
                mGenderEntity = Mapper.Map<MGender, MGenderEntity>(mGender);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMGenderEntity", ex);
                throw;
            }

            return mGenderEntity;
        }

        /// <summary>
        /// Gets the <see cref="MHolidayEntity"/> from <see cref="MHolidayEntity"/> input.
        /// </summary>
        /// <param name="MHoliday"><see cref="MHoliday"/></param>
        /// <returns>Returns <see cref="MHolidayEntity"/>, else null.</returns>
        public static MHolidayEntity GetMHolidayEntity(MHoliday mHoliday)
        {
            MHolidayEntity mHolidayEntity = null;

            try
            {
                mHolidayEntity = Mapper.Map<MHoliday, MHolidayEntity>(mHoliday);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMHolidayEntity", ex);
                throw;
            }

            return mHolidayEntity;
        }

        /// <summary>
        /// Gets the <see cref="MHRGOutComeEntity"/> from <see cref="MHRGOutCome"/> input.
        /// </summary>
        /// <param name="mHRGOutCome"><see cref="MHRGOutCome"/></param>
        /// <returns>Returns <see cref="MHRGOutComeEntity"/>, else null.</returns>
        public static MHRGOutComeEntity GetMHRGOutComeEntity(MHRGOutCome mHRGOutCome)
        {
            MHRGOutComeEntity mHRGOutComeEntity = null;

            try
            {
                mHRGOutComeEntity = Mapper.Map<MHRGOutCome, MHRGOutComeEntity>(mHRGOutCome);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMHRGOutComeEntity", ex);
                throw;
            }

            return mHRGOutComeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MHRGOutComeReasonEntity"/> from <see cref="MHRGOutComeReason"/> input.
        /// </summary>
        /// <param name="mHRGOutComeReason"><see cref="MHRGOutComeReason"/></param>
        /// <returns>Returns <see cref="MHRGOutComeReasonEntity"/>, else null.</returns>
        public static MHRGOutComeReasonEntity GetMHRGOutComeReasonEntity(MHRGOutComeReason mHRGOutComeReason)
        {
            MHRGOutComeReasonEntity mHRGOutComeReasonEntity = null;

            try
            {
                mHRGOutComeReasonEntity = Mapper.Map<MHRGOutComeReason, MHRGOutComeReasonEntity>(mHRGOutComeReason);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMHRGOutComeReasonEntity", ex);
                throw;
            }

            return mHRGOutComeReasonEntity;
        }

        /// <summary>
        /// Gets the <see cref="MHRGRoomEntity"/> from <see cref="MHRGRoom"/> input.
        /// </summary>
        /// <param name="mHRGRoom"><see cref="MHRGRoom"/></param>
        /// <returns>Returns <see cref="MHRGRoomEntity"/>, else null.</returns>
        public static MHRGRoomEntity GetMHRGRoomEntity(MHRGRoom mHRGRoom)
        {
            MHRGRoomEntity mHRGRoomEntity = null;

            try
            {
                mHRGRoomEntity = Mapper.Map<MHRGRoom, MHRGRoomEntity>(mHRGRoom);
                mHRGRoomEntity.MCourtType = Mapper.Map<MCourtType, MCourtTypeEntity>(mHRGRoom.MCourtType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMHRGRoomEntity", ex);
                throw;
            }

            return mHRGRoomEntity;
        }

        /// <summary>
        /// Gets the <see cref="MHRGRoomTypeEntity"/> from <see cref="MHRGRoomType"/> input.
        /// </summary>
        /// <param name="mHRGRoomType"><see cref="MHRGRoomType"/></param>
        /// <returns>Returns <see cref="MHRGRoomTypeEntity"/>, else null.</returns>
        public static MHRGRoomTypeEntity GetMHRGRoomTypeEntity(MHRGRoomType mHRGRoomType)
        {
            MHRGRoomTypeEntity mHRGRoomTypeEntity = null;

            try
            {
                mHRGRoomTypeEntity = Mapper.Map<MHRGRoomType, MHRGRoomTypeEntity>(mHRGRoomType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMHRGRoomTypeEntity", ex);
                throw;
            }

            return mHRGRoomTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MHRGSlotEntity"/> from <see cref="MHRGSlot"/> input.
        /// </summary>
        /// <param name="mHRGSlot"><see cref="MHRGSlot"/></param>
        /// <returns>Returns <see cref="MHRGSlotEntity"/>, else null.</returns>
        public static MHRGSlotEntity GetMHRGSlotEntity(MHRGSlot mHRGSlot)
        {
            MHRGSlotEntity mHRGSlotEntity = null;

            try
            {
                mHRGSlotEntity = Mapper.Map<MHRGSlot, MHRGSlotEntity>(mHRGSlot);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMHRGSlotEntity", ex);
                throw;
            }

            return mHRGSlotEntity;
        }

        /// <summary>
        /// Gets the <see cref="MHRGTimeLineEntity"/> from <see cref="MHRGTimeLine"/> input.
        /// </summary>
        /// <param name="mHRGTimeLine"><see cref="MHRGTimeLine"/></param>
        /// <returns>Returns <see cref="MHRGTimeLineEntity"/>, else null.</returns>
        public static MHRGTimeLineEntity GetMHRGTimeLineEntity(MHRGTimeLine mHRGTimeLine)
        {
            MHRGTimeLineEntity mHRGTimeLineEntity = null;

            try
            {
                mHRGTimeLineEntity = Mapper.Map<MHRGTimeLine, MHRGTimeLineEntity>(mHRGTimeLine);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMHRGTimeLineEntity", ex);
                throw;
            }

            return mHRGTimeLineEntity;
        }

        /// <summary>
        /// Gets the <see cref="MHRGTypeEntity"/> from <see cref="MHRGType"/> input.
        /// </summary>
        /// <param name="mHRGType"><see cref="MHRGType"/></param>
        /// <returns>Returns <see cref="MHRGTypeEntity"/>, else null.</returns>
        public static MHRGTypeEntity GetMHRGTypeEntity(MHRGType mHRGType)
        {
            MHRGTypeEntity mHRGTypeEntity = null;

            try
            {
                mHRGTypeEntity = Mapper.Map<MHRGType, MHRGTypeEntity>(mHRGType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMHRGTypeEntity", ex);
                throw;
            }

            return mHRGTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MHRGUserAvailabilityEntity"/> from <see cref="MHRGUserAvailability"/> input.
        /// </summary>
        /// <param name="mHRGUserAvailability"><see cref="MHRGUserAvailability"/></param>
        /// <returns>Returns <see cref="mHRGUserAvailabilityEntity "/>, else null.</returns>
        public static MHRGUserAvailabilityEntity GetMHRGUserAvailabilityEntity(MHRGUserAvailability mHRGUserAvailability)
        {
            MHRGUserAvailabilityEntity mHRGUserAvailabilityEntity = null;

            try
            {
                mHRGUserAvailabilityEntity = Mapper.Map<MHRGUserAvailability, MHRGUserAvailabilityEntity>(mHRGUserAvailability);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMHRGUserAvailabilityEntity", ex);
                throw;
            }

            return mHRGUserAvailabilityEntity;
        }

        /// <summary>
        /// Get the MIconItem.
        /// </summary>
        /// <param name="mIconItemNHibernateEntity"></param>
        /// <returns></returns>
        public static MIconItemEntity GetMIconItemDomain(MIconItem mIconItemNHibernateEntity)
        {
            MIconItemEntity mIconItemDomainEntity = null;

            try
            {
                mIconItemDomainEntity = Mapper.Map<MIconItem, MIconItemEntity>(mIconItemNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMIconItemDomain", ex);
                throw;
            }

            return mIconItemDomainEntity;
        }

        /// <summary>
        /// Gets the <see cref="MIOOrganisationEntity"/> from <see cref="MIOOrganisation"/> input.
        /// </summary>
        /// <param name="mIOOrganisation"><see cref="MIOOrganisation"/></param>
        /// <returns>Returns <see cref="MIOOrganisationEntity"/>, else null.</returns>
        public static MIOOrganisationEntity GetMIOOrganisationEntity(MIOOrganisation mIOOrganisation)
        {
            MIOOrganisationEntity mIOOrganisationEntity = null;

            try
            {
                mIOOrganisationEntity = Mapper.Map<MIOOrganisation, MIOOrganisationEntity>(mIOOrganisation);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMIOOrganisationEntity", ex);
                throw;
            }

            return mIOOrganisationEntity;
        }

        /// <summary>
        /// Get the MJudGDCatchWord.
        /// </summary>
        /// <param name="mJudGDCatchWordNHibernateEntity"></param>
        /// <returns></returns>
        public static MJudGDCatchWordEntity GetMJudGDCatchWordDomain(MJudGDCatchWord mJudGDCatchWordNHibernateEntity)
        {
            MJudGDCatchWordEntity mJudGDCatchWordDomainEntity = null;

            try
            {
                mJudGDCatchWordDomainEntity = Mapper.Map<MJudGDCatchWord, MJudGDCatchWordEntity>(mJudGDCatchWordNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMJudGDCatchWordDomain", ex);
                throw;
            }

            return mJudGDCatchWordDomainEntity;
        }

        /// <summary>
        /// Gets the <see cref="MLegalPracticeEntity"/> from <see cref="MLegalPractice"/> input.
        /// </summary>
        /// <param name="mLegalPractice"><see cref="MLegalPractice"/></param>
        /// <returns>Returns <see cref="MLegalPracticeEntity"/>, else null.</returns>
        public static MLegalPracticeEntity GetMLegalPracticeEntity(MLegalPractice mLegalPractice)
        {
            MLegalPracticeEntity mLegalPracticeEntity = null;

            try
            {
                mLegalPracticeEntity = Mapper.Map<MLegalPractice, MLegalPracticeEntity>(mLegalPractice);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMLegalPracticeEntity", ex);
                throw;
            }

            return mLegalPracticeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MLegislationActEntity"/> from <see cref="MLegislationAct"/> input.
        /// </summary>
        /// <param name="mLegislationAct"><see cref="MLegislationAct"/></param>
        /// <returns>Returns <see cref="MLegislationActEntity"/>, else null.</returns>
        public static MLegislationActEntity GetMLegislationActEntity(MLegislationAct mLegislationAct)
        {
            MLegislationActEntity mLegislationActEntity = null;

            try
            {
                mLegislationActEntity = Mapper.Map<MLegislationAct, MLegislationActEntity>(mLegislationAct);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMLegislationActEntity", ex);
                throw;
            }

            return mLegislationActEntity;
        }

        /// <summary>
        /// Gets the <see cref="MLimitations"/> from <see cref="MLimitations"/> input.
        /// </summary>
        /// <param name="mLimitations"><see cref="MLimitations"/></param>
        /// <returns>Returns <see cref="MLimitationsEntity"/>, else null.</returns>
        public static MLimitationsEntity GetMLimitationsEntity(MLimitations mLimitations)
        {
            MLimitationsEntity mLimitationsEntity = null;

            try
            {
                mLimitationsEntity = Mapper.Map<MLimitations, MLimitationsEntity>(mLimitations);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMLimitationsEntity", ex);
                throw;
            }

            return mLimitationsEntity;
        }

        /// <summary>
        /// Gets the <see cref="MLocationEntity"/> from <see cref="MLocation"/> input.
        /// </summary>
        /// <param name="mLocation"><see cref="MLocation"/></param>
        /// <returns>Returns <see cref="MLocationEntity"/>, else null.</returns>
        public static MLocationEntity GetMLocationEntity(MLocation mLocation)
        {
            MLocationEntity mLocationEntity = null;

            try
            {
                mLocationEntity = Mapper.Map<MLocation, MLocationEntity>(mLocation);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMLocationEntity", ex);
                throw;
            }

            return mLocationEntity;
        }

        /// <summary>
        /// Gets the <see cref="MMaritalStatusEntity"/> from <see cref="MMaritalStatus"/> input.
        /// </summary>
        /// <param name="mMaritalStatus"><see cref="MMaritalStatus"/></param>
        /// <returns>Returns <see cref="MMaritalStatusEntity"/>, else null.</returns>
        public static MMaritalStatusEntity GetMMaritalStatusEntity(MMaritalStatus mMaritalStatus)
        {
            MMaritalStatusEntity mMaritalStatusEntity = null;

            try
            {
                mMaritalStatusEntity = Mapper.Map<MMaritalStatus, MMaritalStatusEntity>(mMaritalStatus);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMMaritalStatusEntity", ex);
                throw;
            }

            return mMaritalStatusEntity;
        }

        /// <summary>
        /// Get the MMessageType.
        /// </summary>
        /// <param name="mMessageTypeNHibernateEntity"></param>
        /// <returns></returns>
        public static MMessageTypeEntity GetMMessageTypeDomain(MMessageType mMessageTypeNHibernateEntity)
        {
            MMessageTypeEntity mMessageTypeDomainEntity = null;

            try
            {
                mMessageTypeDomainEntity = Mapper.Map<MMessageType, MMessageTypeEntity>(mMessageTypeNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMMessageTypeDomain", ex);
                throw;
            }

            return mMessageTypeDomainEntity;
        }

        /// <summary>
        /// Gets the <see cref="MModeOfTraffickingEntity"/> from <see cref="MModeOfTrafficking"/> input.
        /// </summary>
        /// <param name="mModeOfTrafficking"><see cref="MModeOfTrafficking"/></param>
        /// <returns>Returns <see cref="MModeOfTraffickingEntity"/>, else null.</returns>
        public static MModeOfTraffickingEntity GetMModeOfTraffickingEntity(MModeOfTrafficking mModeOfTrafficking)
        {
            MModeOfTraffickingEntity mModeOfTraffickingEntity = null;

            try
            {
                mModeOfTraffickingEntity = Mapper.Map<MModeOfTrafficking, MModeOfTraffickingEntity>(mModeOfTrafficking);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMModeOfTraffickingEntity", ex);
                throw;
            }

            return mModeOfTraffickingEntity;
        }

        /// <summary>
        /// Gets the <see cref="MAASOrganisationTypeEntity"/> from <see cref="MAASOrganisationType"/> input.
        /// </summary>
        /// <param name="mAASOrganisationType"><see cref="MAASOrganisationType"/></param>
        /// <returns>Returns <see cref="MAASOrganisationTypeEntity"/>, else null.</returns>
        public static MMonitoringTypeEntity GetMMonitoringTypeEntity(MMonitoringType mMonitoringType)
        {
            MMonitoringTypeEntity mMonitoringTypeEntity = null;

            try
            {
                mMonitoringTypeEntity = Mapper.Map<MMonitoringType, MMonitoringTypeEntity>(mMonitoringType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMMonitoringTypeEntity", ex);
                throw;
            }

            return mMonitoringTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MNAAAlertEventRecipientEntity"/> from <see cref="MNAAAlertEventRecipient"/> input.
        /// </summary>
        /// <param name="mNAAAlertEventRecipient"><see cref="MNAAAlertEventRecipient"/></param>
        /// <returns>Returns <see cref="MNAAAlertEventRecipientEntity"/>, else null.</returns>
        public static MNAAAlertEventRecipientEntity GetMNAAAlertEventRecipientEntity(MNAAAlertEventRecipient mNAAAlertEventRecipient)
        {
            MNAAAlertEventRecipientEntity mNAAAlertEventRecipientEntity = null;

            try
            {
                mNAAAlertEventRecipientEntity = Mapper.Map<MNAAAlertEventRecipient, MNAAAlertEventRecipientEntity>(mNAAAlertEventRecipient);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNAAAlertEventRecipientEntity", ex);
                throw;
            }

            return mNAAAlertEventRecipientEntity;
        }

        /// <summary>
        /// Gets the <see cref="MNAAAlertEventsTemplateEntity"/> from <see cref="MNAAAlertEventsTemplate"/> input.
        /// </summary>
        /// <param name="mNAAAlertEventsTemplate"><see cref="MNAAAlertEventsTemplate"/></param>
        /// <returns>Returns <see cref="MNAAAlertEventsTemplateEntity"/>, else null.</returns>
        public static MNAAAlertEventsTemplateEntity GetMNAAAlertEventsTemplateEntity(MNAAAlertEventsTemplate mNAAAlertEventsTemplate)
        {
            MNAAAlertEventsTemplateEntity mNAAAlertEventsTemplateEntity = null;

            try
            {
                mNAAAlertEventsTemplateEntity = Mapper.Map<MNAAAlertEventsTemplate, MNAAAlertEventsTemplateEntity>(mNAAAlertEventsTemplate);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNAAAlertEventsTemplateEntity", ex);
                throw;
            }

            return mNAAAlertEventsTemplateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MNAACategoryEntity"/> from <see cref="MNAACategory"/> input.
        /// </summary>
        /// <param name="mNAACategory"><see cref="MNAACategory"/></param>
        /// <returns>Returns <see cref="MNAACategoryEntity"/>, else null.</returns>
        public static MNAACategoryEntity GetMNAACategoryEntity(MNAACategory mNAACategory)
        {
            MNAACategoryEntity mNAACategoryEntity = null;

            try
            {
                mNAACategoryEntity = Mapper.Map<MNAACategory, MNAACategoryEntity>(mNAACategory);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNAACategoryEntity", ex);
                throw;
            }

            return mNAACategoryEntity;
        }

        /// <summary>
        /// Gets the <see cref="MNAAPlaceHolderEntity"/> from <see cref="MNAAPlaceHolder"/> input.
        /// </summary>
        /// <param name="mNAAPlaceHolder"><see cref="MNAAPlaceHolder"/></param>
        /// <returns>Returns <see cref="MNAAPlaceHolderEntity"/>, else null.</returns>
        public static MNAAPlaceHolderEntity GetMNAAPlaceHolderEntity(MNAAPlaceHolder mNAAPlaceHolder)
        {
            MNAAPlaceHolderEntity mNAAPlaceHolderEntity = null;

            try
            {
                mNAAPlaceHolderEntity = Mapper.Map<MNAAPlaceHolder, MNAAPlaceHolderEntity>(mNAAPlaceHolder);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNAAPlaceHolderEntity", ex);
                throw;
            }

            return mNAAPlaceHolderEntity;
        }

        /// <summary>
        /// Gets the <see cref="MNAASubCategoryEntity"/> from <see cref="MNAASubCategory"/> input.
        /// </summary>
        /// <param name="mNAASubCategory"><see cref="MNAASubCategory"/></param>
        /// <returns>Returns <see cref="MNAASubCategoryEntity"/>, else null.</returns>
        public static MNAASubCategoryEntity GetMNAASubCategoryEntity(MNAASubCategory mNAASubCategory)
        {
            MNAASubCategoryEntity mNAASubCategoryEntity = null;

            try
            {
                mNAASubCategoryEntity = Mapper.Map<MNAASubCategory, MNAASubCategoryEntity>(mNAASubCategory);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNAASubCategoryEntity", ex);
                throw;
            }

            return mNAASubCategoryEntity;
        }

        /// <summary>
        /// Gets the <see cref="MNationalityEntity"/> from <see cref="MNationality"/> input.
        /// </summary>
        /// <param name="mNationality"><see cref="MNationality"/></param>
        /// <returns>Returns <see cref="MNationalityEntity"/>, else null.</returns>
        public static MNationalityEntity GetMNationalityEntity(MNationality mNationality)
        {
            MNationalityEntity mNationalityEntity = null;

            try
            {
                mNationalityEntity = Mapper.Map<MNationality, MNationalityEntity>(mNationality);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNationalityEntity", ex);
                throw;
            }

            return mNationalityEntity;
        }

        /// <summary>
        /// Gets the <see cref="MNatureOfAppealEntity"/> from <see cref="MNatureOfAppeal"/> input.
        /// </summary>
        /// <param name="MNatureOfAppeal"><see cref="MNatureOfAppeal"/></param>
        /// <returns>Returns <see cref="MNatureOfAppealEntity"/>, else null.</returns>
        public static MNatureOfAppealEntity GetMNatureOfAppealEntity(MNatureOfAppeal mNatureOfAppeal)
        {
            MNatureOfAppealEntity mNatureOfAppealEntity = null;

            try
            {
                mNatureOfAppealEntity = Mapper.Map<MNatureOfAppeal, MNatureOfAppealEntity>(mNatureOfAppeal);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNatureOfAppealEntity", ex);
                throw;
            }

            return mNatureOfAppealEntity;
        }

        /// <summary>
        /// Get the <see cref=" MNatureofDeputyshipEntity"/>.
        /// </summary>
        /// <param name="mNatureOfDeputyShip"></param>
        /// <returns></returns>
        public static MNatureofDeputyshipEntity GetMNatureofDeputyshipEntity(MNatureOfDeputyShip mNatureOfDeputyShip)
        {
            MNatureofDeputyshipEntity mNatureofDeputyshipEntity = null;

            try
            {
                mNatureofDeputyshipEntity = Mapper.Map<MNatureOfDeputyShip, MNatureofDeputyshipEntity>(mNatureOfDeputyShip);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMNatureofDeputyshipEntity", ex);
                throw;
            }

            return mNatureofDeputyshipEntity;
        }

        /// <summary>
        /// Gets the <see cref="MNatureOfOffenceEntity"/> from <see cref="MNatureOfOffence"/> input.
        /// </summary>
        /// <param name="mNatureOfOffence"><see cref="MNatureOfOffence"/></param>
        /// <returns>Returns <see cref="MNatureOfOffenceEntity"/>, else null.</returns>
        public static MNatureOfOffenceEntity GetMNatureOfOffenceEntity(MNatureOfOffence mNatureOfOffence)
        {
            MNatureOfOffenceEntity mNatureOfOffenceEntity = null;

            try
            {
                mNatureOfOffenceEntity = Mapper.Map<MNatureOfOffence, MNatureOfOffenceEntity>(mNatureOfOffence);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNatureOfOffenceEntity", ex);
                throw;
            }

            return mNatureOfOffenceEntity;
        }

        /// <summary>
        /// Gets the <see cref="MNatureOfWorkEntity"/> from <see cref="MNatureOfWork"/> input.
        /// </summary>
        /// <param name="mNatureOfWork"><see cref="MNatureOfWork"/></param>
        /// <returns>Returns <see cref="MNatureOfWorkEntity"/>, else null.</returns>
        public static MNatureOfWorkEntity GetMNatureOfWorkEntity(MNatureOfWork mNatureOfWork)
        {
            MNatureOfWorkEntity mNatureOfWorkEntity = null;

            try
            {
                mNatureOfWorkEntity = Mapper.Map<MNatureOfWork, MNatureOfWorkEntity>(mNatureOfWork);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNatureOfWorkEntity", ex);
                throw;
            }

            return mNatureOfWorkEntity;
        }

        /// <summary>
        /// Gets the <see cref="MNOACodeEntity"/> from <see cref="MNOACode"/> input.
        /// </summary>
        /// <param name="mNOACode"><see cref="MNOACode"/></param>
        /// <returns>Returns <see cref="MNOACodeEntity"/>, else null.</returns>
        public static MNOACodeEntity GetMNOACodeEntity(MNOACode mNOACode)
        {
            MNOACodeEntity mNOACodeEntity = null;

            try
            {
                mNOACodeEntity = Mapper.Map<MNOACode, MNOACodeEntity>(mNOACode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNOACodeEntity", ex);
                throw;
            }

            return mNOACodeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MNOCEntity"/> from <see cref="MNOC"/> input.
        /// </summary>
        /// <param name="mNOC"><see cref="ADMInfo"/></param>
        /// <returns>Returns <see cref="MNOCEntity"/>, else null.</returns>
        public static MNOCEntity GetMNOCEntity(MNOC mNOC)
        {
            MNOCEntity mNOCEntity = null;

            try
            {
                mNOCEntity = Mapper.Map<MNOC, MNOCEntity>(mNOC);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNOCEntity", ex);
                throw;
            }

            return mNOCEntity;
        }

        /// <summary>
        /// Gets the <see cref="MOccupationEntity"/> from <see cref="MOccupation"/> input.
        /// </summary>
        /// <param name="mOccupation"><see cref="MOccupation"/></param>
        /// <returns>Returns <see cref="MOccupationEntity"/>, else null.</returns>
        public static MOccupationEntity GetMOccupationEntity(MOccupation mOccupation)
        {
            MOccupationEntity mOccupationEntity = null;

            try
            {
                mOccupationEntity = Mapper.Map<MOccupation, MOccupationEntity>(mOccupation);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMOccupationEntity", ex);
                throw;
            }

            return mOccupationEntity;
        }

        /*
        /// <summary>
        /// Gets the <see cref="MOrganizationAddrEntity"/> from <see cref="MOrganizationAddr"/> input.
        /// </summary>
        /// <param name="mOrganizationAddr"><see cref="MOrganizationAddr"/></param>
        /// <returns>Returns <see cref="MOrganizationAddrEntity"/>, else null.</returns>
        public static MOrganizationAddrEntity GetMOrganizationAddrEntity(MOrganizationAddr mOrganizationAddr)
        {
            MOrganizationAddrEntity mOrganizationAddrEntity = null;

            try
            {
                mOrganizationAddrEntity = Mapper.Map<MOrganizationAddr, MOrganizationAddrEntity>(mOrganizationAddr);
                mOrganizationAddrEntity.MOrganization = Mapper.Map<MOrganization, MOrganizationEntity>(mOrganizationAddr.MOrganization);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMOrganizationAddrEntity", ex);
                throw;
            }

            return mOrganizationAddrEntity;
        }

        /// <summary>
        /// Gets the <see cref="MOrganizationEntity"/> from <see cref="MOrganization"/> input.
        /// </summary>
        /// <param name="mOrganization"><see cref="MOrganization"/></param>
        /// <returns>Returns <see cref="MOrganizationEntity"/>, else null.</returns>
        public static MOrganizationEntity GetMOrganizationEntity(MOrganization mOrganization)
        {
            MOrganizationEntity mOrganizationEntity = null;

            try
            {
                mOrganizationEntity = Mapper.Map<MOrganization, MOrganizationEntity>(mOrganization);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMOrganizationEntity", ex);
                throw;
            }

            return mOrganizationEntity;
        }
        */
        /// <summary>
        /// Get the MOSType.
        /// </summary>
        /// <param name="mOSTypeNHibernateEntity"></param>
        /// <returns></returns>
        public static MOSTypeEntity GetMOSTypeDomain(MOSType mOSTypeNHibernateEntity)
        {
            MOSTypeEntity mOSTypeDomainEntity = null;

            try
            {
                mOSTypeDomainEntity = Mapper.Map<MOSType, MOSTypeEntity>(mOSTypeNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMOSTypeDomain", ex);
                throw;
            }

            return mOSTypeDomainEntity;
        }

        /// <summary>
        /// Gets the <see cref="MParameterListEntity"/> from <see cref="MParameterList"/> input.
        /// </summary>
        /// <param name="mParameterList"><see cref="MParameterList"/></param>
        /// <returns>Returns <see cref="MParameterListEntity"/>, else null.</returns>
        public static MParameterListEntity GetMParameterListEntity(MParameterList mParameterList)
        {
            MParameterListEntity mParameterListEntity = null;

            try
            {
                mParameterListEntity = Mapper.Map<MParameterList, MParameterListEntity>(mParameterList);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMParameterListEntity", ex);
                throw;
            }

            return mParameterListEntity;
        }

        /// <summary>
        /// Gets the <see cref="MPartyAmendmentConfigEntity"/> from <see cref="MPartyAmendmentConfig"/> input.
        /// </summary>
        /// <param name="mPartyAmendmentConfig"><see cref="MPartyAmendmentConfig"/></param>
        /// <returns>Returns <see cref="MPartyAmendmentConfigEntity"/>, else null.</returns>
        public static MPartyAmendmentConfigEntity GetMPartyAmendmentConfigEntity(MPartyAmendmentConfig mPartyAmendmentConfig)
        {
            MPartyAmendmentConfigEntity mPartyAmendmentConfigEntity = null;

            try
            {
                mPartyAmendmentConfigEntity = Mapper.Map<MPartyAmendmentConfig, MPartyAmendmentConfigEntity>(mPartyAmendmentConfig);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPartyAmendmentConfigEntity", ex);
                throw;
            }

            return mPartyAmendmentConfigEntity;
        }

        /// <summary>
        /// Gets the <see cref="MPartySectionEntity"/> from <see cref="MPartySection"/> input.
        /// </summary>
        /// <param name="mPartySection"><see cref="MPartySection"/></param>
        /// <returns>Returns <see cref="MPartySectionEntity"/>, else null.</returns>
        public static MPartySectionEntity GetMPartySectionEntity(MPartySection mPartySection)
        {
            MPartySectionEntity mPartySectionEntity = null;

            try
            {
                mPartySectionEntity = Mapper.Map<MPartySection, MPartySectionEntity>(mPartySection);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPartySectionEntity", ex);
                throw;
            }

            return mPartySectionEntity;
        }

        /// <summary>
        /// Gets the <see cref="MPartyStatusEntity"/> from <see cref="MPartyStatus"/> input.
        /// </summary>
        /// <param name="mPartyStatus"><see cref="MPartyStatus"/></param>
        /// <returns>Returns <see cref="MPartyStatusEntity"/>, else null.</returns>
        public static MPartyStatusEntity GetMPartyStatusEntity(MPartyStatus mPartyStatus)
        {
            MPartyStatusEntity mPartyStatusEntity = null;

            try
            {
                mPartyStatusEntity = Mapper.Map<MPartyStatus, MPartyStatusEntity>(mPartyStatus);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPartyStatusEntity", ex);
                throw;
            }

            return mPartyStatusEntity;
        }

        /// <summary>
        /// Gets the <see cref="MPartyTypeEntity"/> from <see cref="MPartyType"/> input.
        /// </summary>
        /// <param name="mPartyType"><see cref="MPartyType"/></param>
        /// <returns>Returns <see cref="MPartyTypeEntity"/>, else null.</returns>
        public static MPartyTypeEntity GetMPartyTypeEntity(MPartyType mPartyType)
        {
            MPartyTypeEntity mPartyTypeEntity = null;

            try
            {
                mPartyTypeEntity = Mapper.Map<MPartyType, MPartyTypeEntity>(mPartyType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPartyTypeEntity", ex);
                throw;
            }

            return mPartyTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MPCConditionEntity"/> from <see cref="MPCCondition"/> input.
        /// </summary>
        /// <param name="mPCCondition"><see cref="MPCCondition"/></param>
        /// <returns>Returns <see cref="MPCConditionEntity"/>, else null.</returns>
        public static MPCConditionEntity GetMPCConditionEntity(MPCCondition mPCCondition)
        {
            MPCConditionEntity mPCConditionEntity = null;

            try
            {
                mPCConditionEntity = Mapper.Map<MPCCondition, MPCConditionEntity>(mPCCondition);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPCConditionEntity", ex);
                throw;
            }

            return mPCConditionEntity;
        }

        /// <summary>
        /// Gets the <see cref="MPersonIDGroupEntity"/> from <see cref="MPersonIDGroup"/> input.
        /// </summary>
        /// <param name="mPersonIDGroup"><see cref="MPersonIDGroup"/></param>
        /// <returns>Returns <see cref="MPersonIDGroupEntity"/>, else null.</returns>
        public static MPersonIDGroupEntity GetMPersonIDGroupEntity(MPersonIDGroup mPersonIDGroup)
        {
            MPersonIDGroupEntity mPersonIDGroupEntity = null;

            try
            {
                mPersonIDGroupEntity = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(mPersonIDGroup);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPersonIDGroupEntity", ex);
                throw;
            }

            return mPersonIDGroupEntity;
        }

        /// <summary>
        /// Gets the <see cref="MPersonIDTypeEntity"/> from <see cref="MPersonIDType"/> input.
        /// </summary>
        /// <param name="mPersonIDType"><see cref="MPersonIDType"/></param>
        /// <returns>Returns <see cref="MPersonIDTypeEntity"/>, else null.</returns>
        public static MPersonIDTypeEntity GetMPersonIDTypeEntity(MPersonIDType mPersonIDType)
        {
            MPersonIDTypeEntity mPersonIDTypeEntity = null;

            try
            {
                mPersonIDTypeEntity = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(mPersonIDType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPersonIDTypeEntity", ex);
                throw;
            }

            return mPersonIDTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MPrayerOutcomeEntity"/> from <see cref="MPrayerOutcome"/> input.
        /// </summary>
        /// <param name="mPrayerOutcome"><see cref="MPrayerOutcome"/></param>
        /// <returns>Returns <see cref="MPrayerOutcomeEntity"/>, else null.</returns>
        public static MPrayerOutcomeEntity GetMPrayerOutcomeEntity(MPrayerOutcome mPrayerOutcome)
        {
            MPrayerOutcomeEntity mPrayerOutcomeEntity = null;

            try
            {
                mPrayerOutcomeEntity = Mapper.Map<MPrayerOutcome, MPrayerOutcomeEntity>(mPrayerOutcome);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPrayerOutcomeEntity", ex);
                throw;
            }

            return mPrayerOutcomeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MPrisonEntity"/> from <see cref="MPrison"/> input.
        /// </summary>
        /// <param name="mPrison"><see cref="MPrison"/></param>
        /// <returns>Returns <see cref="MPrisonEntity"/>, else null.</returns>
        public static MPrisonEntity GetMPrisonEntity(MPrison mPrison)
        {
            MPrisonEntity mPrisonEntity = null;

            try
            {
                mPrisonEntity = Mapper.Map<MPrison, MPrisonEntity>(mPrison);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPrisonEntity", ex);
                throw;
            }

            return mPrisonEntity;
        }

        /// <summary>
        /// Gets the <see cref="MProbateNatureEntity"/> from <see cref="MProbateNature"/> input.
        /// </summary>
        /// <param name="mProbateNature"><see cref="MProbateNature"/></param>
        /// <returns>Returns <see cref="MProbateNatureEntity"/>, else null.</returns>
        public static MProbateNatureEntity GetMProbateNatureEntity(MProbateNature mProbateNature)
        {
            MProbateNatureEntity mProbateNatureEntity = null;

            try
            {
                mProbateNatureEntity = Mapper.Map<MProbateNature, MProbateNatureEntity>(mProbateNature);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMProbateNatureEntity", ex);
                throw;
            }

            return mProbateNatureEntity;
        }

        /// <summary>
        /// Gets the <see cref="MProbatePrayerEntity"/> from <see cref="MProbatePrayer"/> input.
        /// </summary>
        /// <param name="mProbatePrayer"><see cref="MProbatePrayer"/></param>
        /// <returns>Returns <see cref="MProbatePrayerEntity"/>, else null.</returns>
        public static MProbatePrayerEntity GetMProbatePrayerEntity(MProbatePrayer mProbatePrayer)
        {
            MProbatePrayerEntity mProbatePrayerEntity = null;

            try
            {
                mProbatePrayerEntity = Mapper.Map<MProbatePrayer, MProbatePrayerEntity>(mProbatePrayer);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMProbatePrayerEntity", ex);
                throw;
            }

            return mProbatePrayerEntity;
        }

        /// <summary>
        /// Gets the <see cref="MPropertyTypeEntity"/> from <see cref="MPropertyType"/> input.
        /// </summary>
        /// <param name="mPropertyType"><see cref="MPropertyType"/></param>
        /// <returns>Returns <see cref="MPropertyTypeEntity"/>, else null.</returns>
        public static MPropertyTypeEntity GetMPropertyTypeEntity(MPropertyType mPropertyType)
        {
            MPropertyTypeEntity mPropertyTypeEntity = null;

            try
            {
                mPropertyTypeEntity = Mapper.Map<MPropertyType, MPropertyTypeEntity>(mPropertyType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPropertyTypeEntity", ex);
                throw;
            }

            return mPropertyTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MProvisionEntity"/> from <see cref="MProvision"/> input.
        /// </summary>
        /// <param name="mProvision"><see cref="MProvision"/></param>
        /// <returns>Returns <see cref="MProvisionEntity"/>, else null.</returns>
        public static MProvisionEntity GetMProvisionEntity(MProvision mProvision)
        {
            MProvisionEntity mProvisionEntity = null;

            try
            {
                mProvisionEntity = Mapper.Map<MProvision, MProvisionEntity>(mProvision);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMProvisionEntity", ex);
                throw;
            }

            return mProvisionEntity;
        }

        /// <summary>
        /// Get the MPTCMilestone.
        /// </summary>
        /// <param name="mPTCMilestoneNHibernateEntity"></param>
        /// <returns></returns>
        public static MPTCMilestoneEntity GetMPTCMilestoneDomain(MPTCMilestone mPTCMilestoneNHibernateEntity)
        {
            MPTCMilestoneEntity mPTCMilestoneDomainEntity = null;

            try
            {
                mPTCMilestoneDomainEntity = Mapper.Map<MPTCMilestone, MPTCMilestoneEntity>(mPTCMilestoneNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPTCMilestoneDomain", ex);
                throw;
            }

            return mPTCMilestoneDomainEntity;
        }

        /// <summary>
        /// Gets the <see cref="MQualificationEntity"/> from <see cref="MQualification"/> input.
        /// </summary>
        /// <param name="mQualification"><see cref="MQualification"/></param>
        /// <returns>Returns <see cref="MQualificationEntity"/>, else null.</returns>
        public static MQualificationEntity GetMQualificationEntity(MQualification mQualification)
        {
            MQualificationEntity mQualificationEntity = null;

            try
            {
                mQualificationEntity = Mapper.Map<MQualification, MQualificationEntity>(mQualification);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMQualificationEntity", ex);
                throw;
            }

            return mQualificationEntity;
        }

        /// <summary>
        /// Gets the <see cref="MRaceEntity"/> from <see cref="MRace"/> input.
        /// </summary>
        /// <param name="mRace"><see cref="MRace"/></param>
        /// <returns>Returns <see cref="MRaceEntity"/>, else null.</returns>
        public static MRaceEntity GetMRaceEntity(MRace mRace)
        {
            MRaceEntity mRaceEntity = null;

            try
            {
                mRaceEntity = Mapper.Map<MRace, MRaceEntity>(mRace);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMRaceEntity", ex);
                throw;
            }

            return mRaceEntity;
        }

        /// <summary>
        /// Get the MRDocCategoryCaseType.
        /// </summary>
        /// <param name="mRDocCategoryCaseTypeNHibernateEntity"></param>
        /// <returns></returns>
        public static MRDocCategoryCaseTypeEntity GetMRDocCategoryCaseTypeDomain(MRDocCategoryCaseType mRDocCategoryCaseTypeNHibernateEntity)
        {
            MRDocCategoryCaseTypeEntity mRDocCategoryCaseTypeDomainEntity = null;

            try
            {
                mRDocCategoryCaseTypeDomainEntity = Mapper.Map<MRDocCategoryCaseType, MRDocCategoryCaseTypeEntity>(mRDocCategoryCaseTypeNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRDocCategoryCaseTypeDomain", ex);
                throw;
            }

            return mRDocCategoryCaseTypeDomainEntity;
        }

        /// <summary>
        /// Gets the <see cref="MRelationshipEntity"/> from <see cref="MRelationship"/> input.
        /// </summary>
        /// <param name="mRelationship"><see cref="MRelationship"/></param>
        /// <returns>Returns <see cref="MRelationshipEntity"/>, else null.</returns>
        public static MRelationshipEntity GetMRelationshipEntity(MRelationship mRelationship)
        {
            MRelationshipEntity mRelationshipEntity = null;

            try
            {
                mRelationshipEntity = Mapper.Map<MRelationship, MRelationshipEntity>(mRelationship);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMRelationshipEntity", ex);
                throw;
            }

            return mRelationshipEntity;
        }

        /// <summary>
        /// Gets the <see cref="MReliefEntity"/> from <see cref="MRelief"/> input.
        /// </summary>
        /// <param name="mRelief"><see cref="MRelief"/></param>
        /// <returns>Returns <see cref="MReliefEntity"/>, else null.</returns>
        public static MReliefEntity GetMReliefEntity(MRelief mRelief)
        {
            MReliefEntity mReliefEntity = null;

            try
            {
                mReliefEntity = Mapper.Map<MRelief, MReliefEntity>(mRelief);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMReliefEntity", ex);
                throw;
            }

            return mReliefEntity;
        }

        /// <summary>
        /// Gets the <see cref="MReligionEntity"/> from <see cref="MReligion"/> input.
        /// </summary>
        /// <param name="mReligion"><see cref="MReligion"/></param>
        /// <returns>Returns <see cref="MReligionEntity"/>, else null.</returns>
        public static MReligionEntity GetMReligionEntity(MReligion mReligion)
        {
            MReligionEntity mReligionEntity = null;

            try
            {
                mReligionEntity = Mapper.Map<MReligion, MReligionEntity>(mReligion);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMReligionEntity", ex);
                throw;
            }

            return mReligionEntity;
        }

        /// <summary>
        /// Gets the <see cref="MRoutingTypeEntity"/> from <see cref="MRoutingType"/> input.
        /// </summary>
        /// <param name="mRoutingType"><see cref="MRoutingType"/></param>
        /// <returns>Returns <see cref="MRoutingTypeEntity"/>, else null.</returns>
        public static MRoutingTypeEntity GetMRoutingTypeEntity(MRoutingType mRoutingType)
        {
            MRoutingTypeEntity mRoutingTypeEntity = null;

            try
            {
                mRoutingTypeEntity = Mapper.Map<MRoutingType, MRoutingTypeEntity>(mRoutingType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMRoutingTypeEntity", ex);
                throw;
            }

            return mRoutingTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MSalutationEntity"/> from <see cref="MSalutation"/> input.
        /// </summary>
        /// <param name="mSalutation"><see cref="MSalutation"/></param>
        /// <returns>Returns <see cref="MSalutationEntity"/>, else null.</returns>
        public static MSalutationEntity GetMSalutationEntity(MSalutation mSalutation)
        {
            MSalutationEntity mSalutationEntity = null;

            try
            {
                mSalutationEntity = Mapper.Map<MSalutation, MSalutationEntity>(mSalutation);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMSalutationEntity", ex);
                throw;
            }

            return mSalutationEntity;
        }

        /// <summary>
        /// Get the MScheduleJobLegalDetail.
        /// </summary>
        /// <param name="mScheduleJobLegalDetailNHibernateEntity"></param>
        /// <returns></returns>
        public static MScheduleJobLegalDetailEntity GetMScheduleJobLegalDetailDomain(MScheduleJobLegalDetail mScheduleJobLegalDetailNHibernateEntity)
        {
            MScheduleJobLegalDetailEntity mScheduleJobLegalDetailDomainEntity = null;

            try
            {
                mScheduleJobLegalDetailDomainEntity = Mapper.Map<MScheduleJobLegalDetail, MScheduleJobLegalDetailEntity>(mScheduleJobLegalDetailNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMScheduleJobLegalDetailDomain", ex);
                throw;
            }

            return mScheduleJobLegalDetailDomainEntity;
        }

        /// <summary>
        /// Get the MScheduleJobLegalInfo.
        /// </summary>
        /// <param name="mScheduleJobLegalInfoNHibernateEntity"></param>
        /// <returns></returns>
        public static MScheduleJobLegalInfoEntity GetMScheduleJobLegalInfoDomain(MScheduleJobLegalInfo mScheduleJobLegalInfoNHibernateEntity)
        {
            MScheduleJobLegalInfoEntity mScheduleJobLegalInfoDomainEntity = null;

            try
            {
                mScheduleJobLegalInfoDomainEntity = Mapper.Map<MScheduleJobLegalInfo, MScheduleJobLegalInfoEntity>(mScheduleJobLegalInfoNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMScheduleJobLegalInfoDomain", ex);
                throw;
            }

            return mScheduleJobLegalInfoDomainEntity;
        }

        /// <summary>
        /// Get the MSection.
        /// </summary>
        /// <param name="mSectionNHibernateEntity"></param>
        /// <returns></returns>
        public static MSectionEntity GetMSectionEntity(MSection mSection)
        {
            MSectionEntity mSectionEntity = null;

            try
            {
                mSectionEntity = Mapper.Map<MSection, MSectionEntity>(mSection);
                mSectionEntity.MCourtType = Mapper.Map<MCourtType, MCourtTypeEntity>(mSection.MCourtType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSectionEntity", ex);
                throw;
            }

            return mSectionEntity;
        }

        /// <summary>
        /// Gets the <see cref="MSentenceEntity"/> from <see cref="MSentence"/> input.
        /// </summary>
        /// <param name="mSentence"><see cref="MSentence"/></param>
        /// <returns>Returns <see cref="MSentenceEntity"/>, else null.</returns>
        public static MSentenceEntity GetMSentenceEntity(MSentence mSentence)
        {
            MSentenceEntity mSentenceEntity = null;

            try
            {
                mSentenceEntity = Mapper.Map<MSentence, MSentenceEntity>(mSentence);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMSentenceEntity", ex);
                throw;
            }

            return mSentenceEntity;
        }

        /// <summary>
        /// Gets the <see cref="MSequenceKey"/> from <see cref="MSequenceKey"/> input.
        /// </summary>
        /// <param name="mSequenceKey"><see cref="MSequenceKey"/></param>
        /// <returns>Returns <see cref="MSequenceKeyEntity"/>, else null.</returns>
        public static MSequenceKeyEntity GetMSequenceKeyEntity(MSequenceKey mSequenceKey)
        {
            MSequenceKeyEntity mSequenceKeyEntity = null;

            try
            {
                mSequenceKeyEntity = Mapper.Map<MSequenceKey, MSequenceKeyEntity>(mSequenceKey);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMSequenceKeyEntity", ex);
                throw;
            }

            return mSequenceKeyEntity;
        }

        /// <summary>
        /// Gets the <see cref="MSubProvisionEntity"/> from <see cref="MSubProvision"/> input.
        /// </summary>
        /// <param name="mSubProvision"><see cref="MSubProvision"/></param>
        /// <returns>Returns <see cref="MSubProvisionEntity"/>, else null.</returns>
        public static MSubProvisionEntity GetMSubProvisionEntity(MSubProvision mSubProvision)
        {
            MSubProvisionEntity mSubProvisionEntity = null;

            try
            {
                mSubProvisionEntity = Mapper.Map<MSubProvision, MSubProvisionEntity>(mSubProvision);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMSubProvisionEntity", ex);
                throw;
            }

            return mSubProvisionEntity;
        }

        /// <summary>
        /// Gets the <see cref="MTaskListTypeEntity"/> from <see cref="MTaskListType"/> input.
        /// </summary>
        /// <param name="mTaskListType"><see cref="MTaskListType"/></param>
        /// <returns>Returns <see cref="MTaskListTypeEntity"/>, else null.</returns>
        public static MTaskListTypeEntity GetMTaskListTypeEntity(MTaskListType mTaskListType)
        {
            MTaskListTypeEntity mTaskListTypeEntity = null;

            try
            {
                mTaskListTypeEntity = Mapper.Map<MTaskListType, MTaskListTypeEntity>(mTaskListType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMTaskListTypeEntity", ex);
                throw;
            }

            return mTaskListTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MTypeOfForeignLawPracticeEntity"/> from <see cref="MTypeOfForeignLawPractice"/> input.
        /// </summary>
        /// <param name="mTypeOfForeignLawPractice"><see cref="MTypeOfForeignLawPractice"/></param>
        /// <returns>Returns <see cref="MTypeOfForeignLawPracticeEntity"/>, else null.</returns>
        public static MTypeOfForeignLawPracticeEntity GetMTypeOfForeignLawPracticeEntity(MTypeOfForeignLawPractice mTypeOfForeignLawPractice)
        {
            MTypeOfForeignLawPracticeEntity mTypeOfForeignLawPracticeEntity = null;

            try
            {
                mTypeOfForeignLawPracticeEntity = Mapper.Map<MTypeOfForeignLawPractice, MTypeOfForeignLawPracticeEntity>(mTypeOfForeignLawPractice);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMTypeOfForeignLawPracticeEntity", ex);
                throw;
            }

            return mTypeOfForeignLawPracticeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MUserGroupEntity"/> from <see cref="MUserGroup"/> input.
        /// </summary>
        /// <param name="mUserGroup"><see cref="MUserGroup"/></param>
        /// <returns>Returns <see cref="MUserGroupEntity"/>, else null.</returns>
        public static MUserGroupEntity GetMUserGroupEntity(MUserGroup mUserGroup)
        {
            MUserGroupEntity mUserGroupEntity = null;

            try
            {
                mUserGroupEntity = Mapper.Map<MUserGroup, MUserGroupEntity>(mUserGroup);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMUserGroupEntity", ex);
                throw;
            }

            return mUserGroupEntity;
        }

        /// <summary>
        /// Get the MUserRole.
        /// </summary>
        /// <param name="mUserRoleNHibernateEntity"></param>
        /// <returns></returns>
        public static MUserRoleEntity GetMUserRoleDomain(MUserRole mUserRoleNHibernateEntity)
        {
            MUserRoleEntity mUserRoleDomainEntity = null;

            try
            {
                mUserRoleDomainEntity = Mapper.Map<MUserRole, MUserRoleEntity>(mUserRoleNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMUserRoleDomain", ex);
                throw;
            }

            return mUserRoleDomainEntity;
        }

        /// <summary>
        /// Get the MScheduleJobLegalDetail.
        /// </summary>
        /// <param name="mScheduleJobLegalDetailNHibernateEntity"></param>
        /// <returns></returns>
        public static MWithDrawalInTypeEntity GetMWithDrawalInTypeEntity(MWithDrawalInType mWithDrawalInType)
        {
            MWithDrawalInTypeEntity mWithDrawalInTypeEntity = null;

            try
            {
                mWithDrawalInTypeEntity = Mapper.Map<MWithDrawalInType, MWithDrawalInTypeEntity>(mWithDrawalInType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMWithDrawalInTypeEntity", ex);
                throw;
            }

            return mWithDrawalInTypeEntity;
        }

        /// <summary>
        /// Get the MScheduleJobLegalDetail.
        /// </summary>
        /// <param name="mScheduleJobLegalDetailNHibernateEntity"></param>
        /// <returns></returns>
        public static MWithDrawalOfTypeEntity GetMWithDrawalOfTypeEntity(MWithDrawalOfType mWithdrawalOfType)
        {
            MWithDrawalOfTypeEntity mWithDrawalOfTypeEntity = null;

            try
            {
                mWithDrawalOfTypeEntity = Mapper.Map<MWithDrawalOfType, MWithDrawalOfTypeEntity>(mWithdrawalOfType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMWithDrawalOfTypeEntity", ex);
                throw;
            }

            return mWithDrawalOfTypeEntity;
        }

        /// <summary>
        /// Get the MWorkFlow.
        /// </summary>
        /// <param name="mWorkFlowNHibernateEntity"></param>
        /// <returns></returns>
        public static MWorkFlowEntity GetMWorkFlowDomain(MWorkFlow mWorkFlowNHibernateEntity)
        {
            MWorkFlowEntity mWorkFlowDomainEntity = null;

            try
            {
                mWorkFlowDomainEntity = Mapper.Map<MWorkFlow, MWorkFlowEntity>(mWorkFlowNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMWorkFlowDomain", ex);
                throw;
            }

            return mWorkFlowDomainEntity;
        }

        /// <summary>
        /// Get the MWorkPeriod.
        /// </summary>
        /// <param name="mWorkPeriodNHibernateEntity"></param>
        /// <returns></returns>
        public static MWorkPeriodEntity GetMWorkPeriodDomain(MWorkPeriod mWorkPeriodNHibernateEntity)
        {
            MWorkPeriodEntity mWorkPeriodDomainEntity = null;

            try
            {
                mWorkPeriodDomainEntity = Mapper.Map<MWorkPeriod, MWorkPeriodEntity>(mWorkPeriodNHibernateEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMWorkPeriodDomain", ex);
                throw;
            }

            return mWorkPeriodDomainEntity;
        }

        /// <summary>
        /// Gets the <see cref="MSequenceKey"/> from <see cref="MSequenceKey"/> input.
        /// </summary>
        /// <param name="mSequenceKey"><see cref="MSequenceKey"/></param>
        /// <returns>Returns <see cref="MSequenceKeyEntity"/>, else null.</returns>
        public static RMCaseTypeForumEntity GetRMCaseTypeForumEntity(RMCaseTypeForum rMCaseTypeForum)
        {
            RMCaseTypeForumEntity rMCaseTypeForumEntity = null;

            try
            {
                rMCaseTypeForumEntity = Mapper.Map<RMCaseTypeForum, RMCaseTypeForumEntity>(rMCaseTypeForum);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMCaseTypeForumEntity", ex);
                throw;
            }

            return rMCaseTypeForumEntity;
        }

        /// <summary>
        /// Gets the <see cref="RMCaseTypeNOA"/> from <see cref="RMCaseTypeNOAEntity"/> input.
        /// </summary>
        /// <param name="rmCaseTypeNOAEntity"><see cref="RMCaseTypeNOAEntity"/></param>
        /// <returns>Returns <see cref="RMCaseTypeNOA"/>, else null.</returns>
        public static RMCaseTypeNOAEntity GetRMCaseTypeNOAEntity(RMCaseTypeNOA rmCaseTypeNOA)
        {
            RMCaseTypeNOAEntity rmCaseTypeNOAEntity = null;

            try
            {
                rmCaseTypeNOAEntity = Mapper.Map<RMCaseTypeNOA, RMCaseTypeNOAEntity>(rmCaseTypeNOA);
                //rmCaseTypeNOAEntity.MCaseTypeEntity = Mapper.Map<MCaseType, MCaseTypeEntity>(rmCaseTypeNOA.MCaseType);
                //rmCaseTypeNOAEntity.MNOACodeEntity = Mapper.Map<MNOACode, MNOACodeEntity>(rmCaseTypeNOA.MNOACode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMCaseTypeNOA", ex);
                throw;
            }

            return rmCaseTypeNOAEntity;
        }

        /**End of Criminal Master Tables**/
        /// <summary>
        /// Gets the <see cref="RMDocCodeHrgTypeEntity"/> from <see cref="RMDocCodeHRGType"/> input.
        /// </summary>
        /// <param name="rMDocCodeHRGType"><see cref="RMDocCodeHRGType"/></param>
        /// <returns>Returns <see cref="RMDocCodeHrgTypeEntity"/>, else null.</returns>
        public static RMDocCodeHrgTypeEntity GetRMDocCodeHrgTypeEntity(RMDocCodeHRGType rMDocCodeHRGType)
        {
            RMDocCodeHrgTypeEntity rMDocCodeHrgTypeEntity = null;

            try
            {
                rMDocCodeHrgTypeEntity = Mapper.Map<RMDocCodeHRGType, RMDocCodeHrgTypeEntity>(rMDocCodeHRGType);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMDocCodeHrgTypeEntity", ex);
                throw;
            }

            return rMDocCodeHrgTypeEntity;
        }

        /// <summary>
        /// Gets the <see cref="RMHRGOutComePartyStatusEntity"/> from <see cref="RMHRGOutComePartyStatus"/> input.
        /// </summary>
        /// <param name="rMHRGOutComePartyStatus"><see cref="RMHRGOutComePartyStatus"/></param>
        /// <returns>Returns <see cref="RMHRGOutComePartyStatusEntity"/>, else null.</returns>
        public static RMHRGOutComePartyStatusEntity GetRMHRGOutComePartyStatusEntity(RMHRGOutComePartyStatus rMHRGOutComePartyStatus)
        {
            RMHRGOutComePartyStatusEntity rMHRGOutComePartyStatusEntity = null;

            try
            {
                rMHRGOutComePartyStatusEntity = Mapper.Map<RMHRGOutComePartyStatus, RMHRGOutComePartyStatusEntity>(rMHRGOutComePartyStatus);
                rMHRGOutComePartyStatusEntity.MCaseStatus = Mapper.Map<MCaseStatus, MCaseStatusEntity>(rMHRGOutComePartyStatus.MCaseStatus);
                rMHRGOutComePartyStatusEntity.MCaseTypeGroup = Mapper.Map<MCaseTypeGroup, MCaseTypeGroupEntity>(rMHRGOutComePartyStatus.MCaseTypeGroup);
                rMHRGOutComePartyStatusEntity.MHRGOutCome = Mapper.Map<MHRGOutCome, MHRGOutComeEntity>(rMHRGOutComePartyStatus.MHRGOutCome);
                rMHRGOutComePartyStatusEntity.MPartyStatus = Mapper.Map<MPartyStatus, MPartyStatusEntity>(rMHRGOutComePartyStatus.MPartyStatus);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMHRGOutComePartyStatusEntity", ex);
                throw;
            }

            return rMHRGOutComePartyStatusEntity;
        }

        /// <summary>
        /// Gets the <see cref="RMHRGTypeHRGSlotEntity"/> from <see cref="RMHRGTypeHRGSlot"/> input.
        /// </summary>
        /// <param name="rMHRGTypeHRGSlot"><see cref="RMHRGTypeHRGSlot"/></param>
        /// <returns>Returns <see cref="RMHRGTypeHRGSlotEntity"/>, else null.</returns>
        public static RMHRGTypeHRGSlotEntity GetRMHRGTypeHRGSlotEntity(RMHRGTypeHRGSlot rMHRGTypeHRGSlot)
        {
            RMHRGTypeHRGSlotEntity rMHRGTypeHRGSlotEntity = null;

            try
            {
                rMHRGTypeHRGSlotEntity = Mapper.Map<RMHRGTypeHRGSlot, RMHRGTypeHRGSlotEntity>(rMHRGTypeHRGSlot);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMHRGTypeHRGSlotEntity", ex);
                throw;
            }

            return rMHRGTypeHRGSlotEntity;
        }

        /// <summary>
        /// Gets the <see cref="RMHRGOutComePartyStatusEntity"/> from <see cref="RMHRGOutComePartyStatus"/> input.
        /// </summary>
        /// <param name="rMHRGOutComePartyStatus"><see cref="RMHRGOutComePartyStatus"/></param>
        /// <returns>Returns <see cref="RMHRGOutComePartyStatusEntity"/>, else null.</returns>
        //public static RMHRGOutComePartyStatusEntity GetRMHRGOutComePartyStatusEntity(RMHRGOutComePartyStatus rMHRGOutComePartyStatus)
        //{
        //    RMHRGOutComePartyStatusEntity rMHRGOutComePartyStatusEntity = null;
        //    try
        //    {
        //        rMHRGOutComePartyStatusEntity = Mapper.Map<RMHRGOutComePartyStatus, RMHRGOutComePartyStatusEntity>(rMHRGOutComePartyStatus);
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Error("Error at GetRMHRGOutComePartyStatusEntity", ex);
        //        throw;
        //    }
        //    return rMHRGOutComePartyStatusEntity;
        //}
        /// <summary>
        /// Gets the <see cref="RMNOAForumHrgTypeEntity"/> from <see cref="RMNOAForumHrgType"/> input.
        /// </summary>
        /// <param name="rMNOAForumHrgType"><see cref="RMNOAForumHrgType"/></param>
        /// <returns>Returns <see cref="RMNOAForumHrgTypeEntity"/>, else null.</returns>
        public static RMNOAForumHrgTypeEntity GetRMNOAForumHrgTypeEntity(RMNOAForumHrgType rMNOAForumHrgType)
        {
            RMNOAForumHrgTypeEntity rMNOAForumHrgTypeEntity = null;

            try
            {
                rMNOAForumHrgTypeEntity = Mapper.Map<RMNOAForumHrgType, RMNOAForumHrgTypeEntity>(rMNOAForumHrgType);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMNOAForumHrgTypeEntity", ex);
                throw;
            }

            return rMNOAForumHrgTypeEntity;
        }

        public static RMPartyStatusCaseTypeEntity GetRMPartyStatusCaseTypeEntity(RMPartyStatusCaseType rMPartyStatusCaseType)
        {
            RMPartyStatusCaseTypeEntity rMPartyStatusCaseTypeEntity = null;

            try
            {
                rMPartyStatusCaseTypeEntity = Mapper.Map<RMPartyStatusCaseType, RMPartyStatusCaseTypeEntity>(rMPartyStatusCaseType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMPartyStatusCaseTypeEntity", ex);
                throw;
            }

            return rMPartyStatusCaseTypeEntity;
        }

        /// <summary>
        /// Gets the RM routing section config entity.
        /// </summary>
        /// <param name="rMRoutingSectionConfig">The r M routing section config.</param>
        /// <returns></returns>
        public static RMRoutingSectionConfigEntity GetRMRoutingSectionConfigEntity(RMRoutingSectionConfig rMRoutingSectionConfig)
        {
            RMRoutingSectionConfigEntity rMRoutingSectionConfigEntity = null;

            try
            {
                rMRoutingSectionConfigEntity = Mapper.Map<RMRoutingSectionConfig, RMRoutingSectionConfigEntity>(rMRoutingSectionConfig);
                rMRoutingSectionConfigEntity.MCaseType = Mapper.Map<MCaseType, MCaseTypeEntity>(rMRoutingSectionConfig.MCaseType);
                rMRoutingSectionConfigEntity.MSection = Mapper.Map<MSection, MSectionEntity>(rMRoutingSectionConfig.MSection);
                rMRoutingSectionConfigEntity.MSubCaseType = Mapper.Map<MCaseType, MCaseTypeEntity>(rMRoutingSectionConfig.MSubCaseType);
                rMRoutingSectionConfigEntity.MNOC = Mapper.Map<MNOC, MNOCEntity>(rMRoutingSectionConfig.MNOC);
                rMRoutingSectionConfigEntity.MLegislationAct = Mapper.Map<MLegislationAct, MLegislationActEntity>(rMRoutingSectionConfig.MLegislationAct);            
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMRoutingSectionConfigEntity", ex);
                throw;
            }

            return rMRoutingSectionConfigEntity;
        }

        /// <summary>
        /// Gets the <see cref="RMSectionAccessCtrlEntity"/> from <see cref="RMSectionAccessCtrl"/> input.
        /// </summary>
        /// <param name="rMSectionAccessCtrl"><see cref="RMSectionAccessCtrl"/></param>
        /// <returns>Returns <see cref="RMSectionAccessCtrlEntity"/>, else null.</returns>
        public static RMSectionAccessCtrlEntity GetRMSectionAccessCtrlEntity(RMSectionAccessCtrl rMSectionAccessCtrl)
        {
            RMSectionAccessCtrlEntity rMSectionAccessCtrlEntity = null;

            try
            {
                rMSectionAccessCtrlEntity = Mapper.Map<RMSectionAccessCtrl, RMSectionAccessCtrlEntity>(rMSectionAccessCtrl);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMSectionAccessCtrlEntity", ex);
                throw;
            }

            return rMSectionAccessCtrlEntity;
        }

        /// <summary>
        /// Gets the <see cref="RRoleFunctionsEntity"/> from <see cref="RRoleFunctions"/> input.
        /// </summary>
        /// <param name="rRoleFunctions"><see cref="MAASOrganisationType"/></param>
        /// <returns>Returns <see cref="rRoleFunctionsEntity"/>, else null.</returns>
        public static RRoleFunctionsEntity GetRRoleFunctionsEntity(RRoleFunctions rRoleFunctions)
        {
            RRoleFunctionsEntity rRoleFunctionsEntity = null;

            try
            {
                rRoleFunctionsEntity = Mapper.Map<RRoleFunctions, RRoleFunctionsEntity>(rRoleFunctions);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRRoleFunctionsEntity", ex);
                throw;
            }

            return rRoleFunctionsEntity;
        }

        /// <summary>
        /// Gets the <see cref="RUserRoleSectionEntity"/> from <see cref="RUserRoleSection"/> input.
        /// </summary>
        /// <param name="rUserRoleSection"><see cref="MAASOrganisationType"/></param>
        /// <returns>Returns <see cref="rUserRoleSectionEntity"/>, else null.</returns>
        public static RUserFunctionsEntity GetRUserFunctionsEntity(RUserFunctions rUserFunctions)
        {
            RUserFunctionsEntity rUserFunctionsEntity = null;

            try
            {
                rUserFunctionsEntity = Mapper.Map<RUserFunctions, RUserFunctionsEntity>(rUserFunctions);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRUserFunctionsEntity", ex);
                throw;
            }

            return rUserFunctionsEntity;
        }

        /// <summary>
        /// Gets the <see cref="RUserRoleSectionEntity"/> from <see cref="RUserRoleSection"/> input.
        /// </summary>
        /// <param name="rUserRoleSection"><see cref="MAASOrganisationType"/></param>
        /// <returns>Returns <see cref="rUserRoleSectionEntity"/>, else null.</returns>
        public static RUserRoleSectionEntity GetRUserRoleSectionEntity(RUserRoleSection rUserRoleSection)
        {
            RUserRoleSectionEntity rUserRoleSectionEntity = null;

            try
            {
                rUserRoleSectionEntity = Mapper.Map<RUserRoleSection, RUserRoleSectionEntity>(rUserRoleSection);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRUserRoleSectionEntity", ex);
                throw;
            }

            return rUserRoleSectionEntity;
        }

        /// <summary>
        /// Gets the serial number entity.
        /// </summary>
        /// <param name="serialNumber">The serial number.</param>
        /// <returns></returns>
        public static SerialNumberEntity GetSerialNumberEntity(SerialNumber serialNumber)
        {
            SerialNumberEntity serialNumberEntity = null;

            try
            {
                serialNumberEntity = Mapper.Map<SerialNumber, SerialNumberEntity>(serialNumber);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSerialNumberEntity", ex);
                throw;
            }

            return serialNumberEntity;
        }

        /// <summary>
        /// Gets the RM case type HRG type MS type entity.
        /// </summary>
        /// <param name="rMCaseTypeHRGTypeMSType">Type of the r M case type HRG type MS.</param>
        /// <returns></returns>
        public static RMCaseTypeHRGTypeMSTypeEntity GetRMCaseTypeHRGTypeMSTypeEntity(RMCaseTypeHRGTypeMSType rMCaseTypeHRGTypeMSType)
        {
            RMCaseTypeHRGTypeMSTypeEntity rMCaseTypeHRGTypeMSTypeEntity = null;

            try
            {
                rMCaseTypeHRGTypeMSTypeEntity = Mapper.Map<RMCaseTypeHRGTypeMSType, RMCaseTypeHRGTypeMSTypeEntity>(rMCaseTypeHRGTypeMSType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMCaseTypeHRGTypeMSTypeEntity", ex);
                throw;
            }

            return rMCaseTypeHRGTypeMSTypeEntity;
        }

        public static RMCaseTypeForumHRGTypeMSTypeEntity GetRMCaseTypeForumHRGTypeMSTypeEntity(RMCaseTypeForumHRGTypeMSType rMCaseTypeForumHRGTypeMSType)
        {
            RMCaseTypeForumHRGTypeMSTypeEntity rMCaseTypeForumHRGTypeMSTypeEntity = null;

            try
            {
                rMCaseTypeForumHRGTypeMSTypeEntity = Mapper.Map<RMCaseTypeForumHRGTypeMSType, RMCaseTypeForumHRGTypeMSTypeEntity>(rMCaseTypeForumHRGTypeMSType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMCaseTypeForumHRGTypeMSTypeEntity", ex);
                throw;
            }

            return rMCaseTypeForumHRGTypeMSTypeEntity;
        }


        /// <summary>
        /// Gets the RM forum coram DSG entity.
        /// </summary>
        /// <param name="rMForumCoramDSG">The r M forum coram DSG.</param>
        /// <returns></returns>
        public static RMForumCoramDSGEntity GetRMForumCoramDSGEntity(RMForumCoramDSG rMForumCoramDSG)
        {
            RMForumCoramDSGEntity rMForumCoramDSGEntity = null;

            try
            {
                rMForumCoramDSGEntity = Mapper.Map<RMForumCoramDSG, RMForumCoramDSGEntity>(rMForumCoramDSG);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMForumCoramDSGEntity", ex);
                throw;
            }

            return rMForumCoramDSGEntity;
        }

        /// <summary>
        /// Gets the RM forum coram DSG entity.
        /// </summary>
        /// <param name="rMForumCoramDSG">The r M forum coram DSG.</param>
        /// <returns></returns>
        public static RMHearingTypeCourtTypeEntity GetRMHearingTypeCourtTypeEntity(RMHearingTypeCourtType rMHearingTypeCourtType)
        {
            RMHearingTypeCourtTypeEntity rMHearingTypeCourtTypeEntity = null;

            try
            {
                rMHearingTypeCourtTypeEntity = Mapper.Map<RMHearingTypeCourtType, RMHearingTypeCourtTypeEntity>(rMHearingTypeCourtType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMHearingTypeCourtTypeEntity", ex);
                throw;
            }

            return rMHearingTypeCourtTypeEntity;
        }

        /// <summary>
        /// Gets the RM forum coram DSG entity.
        /// </summary>
        /// <param name="rMForumCoramDSG">The r M forum coram DSG.</param>
        /// <returns></returns>
        public static RMHRGTypeHRGOutComeHRGOutComeFlagEntity GetRMHRGTypeHRGOutComeHRGOutComeFlagEntity(RMHRGTypeHRGOutComeHRGOutComeFlag rMHRGTypeHRGOutComeHRGOutComeFlag)
        {
            RMHRGTypeHRGOutComeHRGOutComeFlagEntity rMHRGTypeHRGOutComeHRGOutComeFlagEntity = null;

            try
            {
                rMHRGTypeHRGOutComeHRGOutComeFlagEntity = Mapper.Map<RMHRGTypeHRGOutComeHRGOutComeFlag, RMHRGTypeHRGOutComeHRGOutComeFlagEntity>(rMHRGTypeHRGOutComeHRGOutComeFlag);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMHRGTypeHRGOutComeHRGOutComeFlagEntity", ex);
                throw;
            }

            return rMHRGTypeHRGOutComeHRGOutComeFlagEntity;
        }


        /// <summary>
        /// Gets the MHRG out come flag entity.
        /// </summary>
        /// <param name="mHRGOutComeFlag">The m HRG out come flag.</param>
        /// <returns></returns>
        public static MHRGOutComeFlagEntity GetMHRGOutComeFlagEntity(MHRGOutComeFlag mHRGOutComeFlag)
        {
            MHRGOutComeFlagEntity mHRGOutComeFlagEntity = null;

            try
            {
                mHRGOutComeFlagEntity = Mapper.Map<MHRGOutComeFlag, MHRGOutComeFlagEntity>(mHRGOutComeFlag);


            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHRGOutComeFlagEntity", ex);
                throw;
            }

            return mHRGOutComeFlagEntity;
        }


        /// <summary>
        /// Gets the MEMS old SCT case prefix entity.
        /// </summary>
        /// <param name="mEMSOldSCTCasePrefix">The m EMS old SCT case prefix.</param>
        /// <returns></returns>
        public static MEMSOldSCTCasePrefixEntity GetMEMSOldSCTCasePrefixEntity(MEMSOldSCTCasePrefix mEMSOldSCTCasePrefix)
        {
            MEMSOldSCTCasePrefixEntity mEMSOldSCTCasePrefixEntity = null;

            try
            {
                mEMSOldSCTCasePrefixEntity = Mapper.Map<MEMSOldSCTCasePrefix, MEMSOldSCTCasePrefixEntity>(mEMSOldSCTCasePrefix);


            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSOldSCTCasePrefixEntity", ex);
                throw;
            }

            return mEMSOldSCTCasePrefixEntity;
        }

        /// <summary>
        /// Gets the MEMS old SCT case prefix entity.
        /// </summary>
        /// <param name="mEMSOldSCTCasePrefix">The m EMS old SCT case prefix.</param>
        /// <returns></returns>
        public static MIDTypeEntity GetMIDTypeEntity(MIDType mIDType)
        {
            MIDTypeEntity mIDTypeEntity = null;

            try
            {
                mIDTypeEntity = Mapper.Map<MIDType, MIDTypeEntity>(mIDType);


            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMIDTypeEntity", ex);
                throw;
            }

            return mIDTypeEntity;
        }

        public static RMPartyTypeCaseTypeEntity GetRMPartyTypeCaseTypeEntity(RMPartyTypeCaseType rMPartyTypeCaseType)
        {
            RMPartyTypeCaseTypeEntity rMPartyTypeCaseTypeEntity = null;
            try
            {
                rMPartyTypeCaseTypeEntity = Mapper.Map<RMPartyTypeCaseType, RMPartyTypeCaseTypeEntity>(rMPartyTypeCaseType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMPartyTypeCaseTypeEntity", ex);
                throw;
            }
            return rMPartyTypeCaseTypeEntity;
        }

        public static MMassCallHrgDateEntity GetMMassCallHrgDateEntity(MMassCallHrgDate mMassCallHrgDate)
        {
            MMassCallHrgDateEntity mMassCallHrgDateEntity = null;
            try
            {
                mMassCallHrgDateEntity = Mapper.Map<MMassCallHrgDate, MMassCallHrgDateEntity>(mMassCallHrgDate);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMMassCallHrgDateEntity", ex);
                throw;
            }
            return mMassCallHrgDateEntity;
        }

        /// <summary>
        /// Gets the M charge outcome entity.
        /// </summary>
        /// <param name="mChargeOutcome">The m charge outcome.</param>
        /// <returns></returns>
        public static MChargeOutcomeEntity GetMChargeOutcomeEntity(MChargeOutcome mChargeOutcome)
        {
            MChargeOutcomeEntity mChargeOutcomeEntity = null;
            try
            {
                mChargeOutcomeEntity = Mapper.Map<MChargeOutcome, MChargeOutcomeEntity>(mChargeOutcome);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMChargeOutcomeEntity", ex);
                throw;
            }
            return mChargeOutcomeEntity;
        }

        public static MVSAConfigDetailEntity GetMVSAConfigDetailEntity(MVSAConfigDetail mVSAConfigDetail)
        {
            MVSAConfigDetailEntity mVSAConfigDetailEntity = null;
            try
            {
                mVSAConfigDetailEntity = Mapper.Map<MVSAConfigDetail, MVSAConfigDetailEntity>(mVSAConfigDetail);
                mVSAConfigDetailEntity.MCourtType = Mapper.Map<MCourtType, MCourtTypeEntity>(mVSAConfigDetail.MCourtType);
                mVSAConfigDetailEntity.MDocCode = Mapper.Map<MDocCode, MDocCodeEntity>(mVSAConfigDetail.MDocCode);
                mVSAConfigDetailEntity.MNOACode = Mapper.Map<MNOACode, MNOACodeEntity>(mVSAConfigDetail.MNOACode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMVSAConfigDetailEntity", ex);
                throw;
            }
            return mVSAConfigDetailEntity;
        }


        public static MVSAConfigGroundEntity GetMVSAConfigGroundEntity(MVSAConfigGround mVSAConfigGround)
        {
            MVSAConfigGroundEntity mVSAConfigGroundEntity = null;
            try
            {
                mVSAConfigGroundEntity = Mapper.Map<MVSAConfigGround, MVSAConfigGroundEntity>(mVSAConfigGround);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMVSAConfigGroundEntity", ex);
                throw;
            }
            return mVSAConfigGroundEntity;
        }

        public static MVSAConfigPrayerEntity GetMVSAConfigPrayerEntity(MVSAConfigPrayer mVSAConfigPrayer)
        {
            MVSAConfigPrayerEntity mVSAConfigPrayerEntity = null;
            try
            {
                mVSAConfigPrayerEntity = Mapper.Map<MVSAConfigPrayer, MVSAConfigPrayerEntity>(mVSAConfigPrayer);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMVSAConfigPrayerEntity", ex);
                throw;
            }
            return mVSAConfigPrayerEntity;
        }

        public static MFilingFeeChargingMechanismEntity GetMFilingFeeChargingMechanismEntity(MFilingFeeChargingMechanism mFilingFeeChargingMechanism)
        {
            MFilingFeeChargingMechanismEntity mFilingFeeChargingMechanismEntity = null;
            try
            {
                mFilingFeeChargingMechanismEntity = Mapper.Map<MFilingFeeChargingMechanism, MFilingFeeChargingMechanismEntity>(mFilingFeeChargingMechanism);
                mFilingFeeChargingMechanismEntity.MFilingFeeEntity = Mapper.Map<MFilingFee, MFilingFeeEntity>(mFilingFeeChargingMechanism.MFilingFee);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMFilingFeeChargingMechanismEntity", ex);
                throw;
            }
            return mFilingFeeChargingMechanismEntity;
        }

        public static MFilingFeeLegislationActEntity GetMFilingFeeLegislationActEntity(MFilingFeeLegislationAct mFilingFeeLegislationAct)
        {
            MFilingFeeLegislationActEntity mFilingFeeLegislationActEntity = null;
            try
            {
                mFilingFeeLegislationActEntity = Mapper.Map<MFilingFeeLegislationAct, MFilingFeeLegislationActEntity>(mFilingFeeLegislationAct);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMFilingFeeLegislationActEntity", ex);
                throw;
            }
            return mFilingFeeLegislationActEntity;
        }

        /// <summary>
        /// Gets the M summons grounds entity.
        /// </summary>
        /// <param name="mSummonsGrounds">The m summons grounds.</param>
        /// <returns></returns>
        public static MSummonsGroundsEntity GetMSummonsGroundsEntity(MSummonsGrounds mSummonsGrounds)
        {
            MSummonsGroundsEntity mSummonsGroundsEntity = null;
            try
            {
                mSummonsGroundsEntity = Mapper.Map<MSummonsGrounds, MSummonsGroundsEntity>(mSummonsGrounds);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSummonsGroundsEntity", ex);
                throw;
            }
            return mSummonsGroundsEntity;
        }


        /// <summary>
        /// Gets the M summons prayers entity.
        /// </summary>
        /// <param name="mSummonsPrayers">The m summons prayers.</param>
        /// <returns></returns>
        public static MSummonsPrayersEntity GetMSummonsPrayersEntity(MSummonsPrayers mSummonsPrayers)
        {
            MSummonsPrayersEntity mMSummonsPrayersEntity = null;
            try
            {
                mMSummonsPrayersEntity = Mapper.Map<MSummonsPrayers, MSummonsPrayersEntity>(mSummonsPrayers);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSummonsPrayersEntity", ex);
                throw;
            }
            return mMSummonsPrayersEntity;
        }


        public static RMDocFilterGroupEntity GetRMDocFilterGroupEntity(RMDocFilterGroup rMDocFilterGroup)
        {
            RMDocFilterGroupEntity rMDocFilterGroupEntity = null;
            try
            {
                rMDocFilterGroupEntity = Mapper.Map<RMDocFilterGroup, RMDocFilterGroupEntity>(rMDocFilterGroup);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMDocFilterGroupEntity", ex);
                throw;
            }
            return rMDocFilterGroupEntity;
        }

        public static MHRGPredefinedDateEntity GetMHRGPredefinedDateEntity(MHRGPredefinedDate mHRGPredefinedDate)
        {
            MHRGPredefinedDateEntity mHRGPredefinedDateEntity = null;
            try
            {
                mHRGPredefinedDateEntity = Mapper.Map<MHRGPredefinedDate, MHRGPredefinedDateEntity>(mHRGPredefinedDate);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHRGPredefinedDateEntity", ex);
                throw;
            }
            return mHRGPredefinedDateEntity;
        }

        /// <summary>
        /// Gets the RM case type HRG type JOL entity.
        /// </summary>
        /// <param name="rMCaseTypeHRGTypeJOL">The r M case type HRG type JOL.</param>
        /// <returns></returns>
        public static RMCaseTypeHRGTypeJOLEntity GetRMCaseTypeHRGTypeJOLEntity(RMCaseTypeHRGTypeJOL rMCaseTypeHRGTypeJOL)
        {
            RMCaseTypeHRGTypeJOLEntity rMCaseTypeHRGTypeJOLEntity = null;
            try
            {
                rMCaseTypeHRGTypeJOLEntity = Mapper.Map<RMCaseTypeHRGTypeJOL, RMCaseTypeHRGTypeJOLEntity>(rMCaseTypeHRGTypeJOL);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMCaseTypeHRGTypeJOLEntity", ex);
                throw;
            }
            return rMCaseTypeHRGTypeJOLEntity;
        }

        public static MHRGBeforeTypeEntity GetMHRGBeforeTypeEntity(MHRGBeforeType mHRGBeforeType)
        {
            MHRGBeforeTypeEntity mHRGBeforeTypeEntity = null;
            try
            {
                mHRGBeforeTypeEntity = Mapper.Map<MHRGBeforeType, MHRGBeforeTypeEntity>(mHRGBeforeType);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHRGBeforeType", ex);
                throw;
            }
            return mHRGBeforeTypeEntity;
        }

        public static RMSubCaseTypeHRGTypeMSTypeEntity GetRMSubCaseTypeHRGTypeMSTypeEntity(RMSubCaseTypeHRGTypeMSType rMSubCaseTypeHRGTypeMSType)
        {
            RMSubCaseTypeHRGTypeMSTypeEntity rMSubCaseTypeHRGTypeMSTypeEntity = null;
            try
            {
                rMSubCaseTypeHRGTypeMSTypeEntity = Mapper.Map<RMSubCaseTypeHRGTypeMSType, RMSubCaseTypeHRGTypeMSTypeEntity>(rMSubCaseTypeHRGTypeMSType);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMSubCaseTypeHRGTypeMSTypeEntity", ex);
                throw;
            }
            return rMSubCaseTypeHRGTypeMSTypeEntity;
        }

        public static MSensitiveFilingACLEntity GetMSensitiveFilingACLEntity(MSensitiveFilingACL mSensitiveFilingACL)
        {
            MSensitiveFilingACLEntity mSensitiveFilingACLEntity = null;
            try
            {
                mSensitiveFilingACLEntity = Mapper.Map<MSensitiveFilingACL, MSensitiveFilingACLEntity>(mSensitiveFilingACL);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSensitiveFilingACLEntity", ex);
                throw;
            }
            return mSensitiveFilingACLEntity;
        }

        public static RMHearingRoutingSectionConfigEntity GetRMHearingRoutingSectionConfigEntity(RMHearingRoutingSectionConfig rMHearingRoutingSectionConfig)
        {
            RMHearingRoutingSectionConfigEntity rMHearingRoutingSectionConfigEntity = null;
            try
            {
                rMHearingRoutingSectionConfigEntity = Mapper.Map<RMHearingRoutingSectionConfig, RMHearingRoutingSectionConfigEntity>(rMHearingRoutingSectionConfig);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMHearingRoutingSectionConfigEntity", ex);
                throw;
            }
            return rMHearingRoutingSectionConfigEntity;
        }

        public static MAlertEventTypeEntity GetMAlertEventTypeEntity(MAlertEventType mAlertEventType)
        {
            MAlertEventTypeEntity mAlertEventTypeEntity = null;
            try
            {
                mAlertEventTypeEntity = Mapper.Map<MAlertEventType, MAlertEventTypeEntity>(mAlertEventType);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMAlertEventTypeEntity", ex);
                throw;
            }
            return mAlertEventTypeEntity;
        }

        public static RMAlertEventTypeRoleEntity GetRMAlertEventTypeRoleEntity(RMAlertEventTypeRole rMAlertEventTypeRole)
        {
            RMAlertEventTypeRoleEntity rMAlertEventTypeRoleEntity = null;
            try
            {
                rMAlertEventTypeRoleEntity = Mapper.Map<RMAlertEventTypeRole, RMAlertEventTypeRoleEntity>(rMAlertEventTypeRole);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMAlertEventTypeRoleEntity", ex);
                throw;
            }
            return rMAlertEventTypeRoleEntity;
        }

        public static RAlertEventSubscribersEntity GetRAlertEventSubscribersEntity(RAlertEventSubscribers rAlertEventSubscribers)
        {
            RAlertEventSubscribersEntity rAlertEventSubscribersEntity = null;
            try
            {
                rAlertEventSubscribersEntity = Mapper.Map<RAlertEventSubscribers, RAlertEventSubscribersEntity>(rAlertEventSubscribers);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRAlertEventSubscribersEntity", ex);
                throw;
            }
            return rAlertEventSubscribersEntity;
        }

        public static MPaperMinuteSheetTypeEntity GetMPaperMinuteSheetTypeEntity(MPaperMinuteSheetType mPaperMinuteSheetType)
        {
            MPaperMinuteSheetTypeEntity mPaperMinuteSheetTypeEntity = null;
            try
            {
                mPaperMinuteSheetTypeEntity = Mapper.Map<MPaperMinuteSheetType, MPaperMinuteSheetTypeEntity>(mPaperMinuteSheetType);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPaperMinuteSheetTypeEntity", ex);
                throw;
            }
            return mPaperMinuteSheetTypeEntity;
        }

        public static RMHRGTypePaperMinuteSheetTypeEntity GetRMHRGTypePaperMinuteSheetTypeEntity(RMHRGTypePaperMinuteSheetType rMHRGTypePaperMinuteSheetType)
        {
            RMHRGTypePaperMinuteSheetTypeEntity rmHRGTypePaperMinuteSheetTypeEntity = null;
            try
            {
                rmHRGTypePaperMinuteSheetTypeEntity = Mapper.Map<RMHRGTypePaperMinuteSheetType, RMHRGTypePaperMinuteSheetTypeEntity>(rMHRGTypePaperMinuteSheetType);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMHRGTypePaperMinuteSheetTypeEntity", ex);
                throw;
            }
            return rmHRGTypePaperMinuteSheetTypeEntity;
        }

        public static MFilingFeeTypeEntity GetMFilingFeeTypeEntity(MFilingFeeType mFilingFeeType)
        {
            MFilingFeeTypeEntity mFilingFeeTypeEntity = null;
            try
            {
                mFilingFeeTypeEntity = Mapper.Map<MFilingFeeType, MFilingFeeTypeEntity>(mFilingFeeType);
            }
            catch ( Exception ex)
            {
                Logger.Error("Error encountered at GetMFilingFeeTypeEntity", ex);
                    
                throw;
            }
            return mFilingFeeTypeEntity;
        }

        public static MCourtVacationEntity GetMCourtVacationEntity(MCourtVacation mCourtVacation)
        {
            MCourtVacationEntity mCourtVacationEntity = null;
            try
            {
                mCourtVacationEntity = Mapper.Map<MCourtVacation, MCourtVacationEntity>(mCourtVacation);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMCourtVacationEntity", ex);
                throw;
            }
            return mCourtVacationEntity;
        }

        /// <summary>
        /// Gets the m document control forum entity.
        /// </summary>
        /// <param name="mDocControlForum">The m document control forum.</param>
        /// <returns></returns>
        public static MDocControlForumEntity GetMDocControlForumEntity(MDocControlForum mDocControlForum)
        {
            MDocControlForumEntity mDocControlForumEntity = null;

            try
            {
                if (mDocControlForum != null)
                {
                    mDocControlForumEntity = Mapper.Map<MDocControlForum, MDocControlForumEntity>(mDocControlForum);
                    mDocControlForumEntity.CaseTypeCode = Mapper.Map<MCaseType, MCaseTypeEntity>(mDocControlForum.CaseTypeCode);
                    mDocControlForumEntity.SubCaseTypeCode = Mapper.Map<MCaseType, MCaseTypeEntity>(mDocControlForum.SubCaseTypeCode);
                    mDocControlForumEntity.MDocCode = Mapper.Map<MDocCode, MDocCodeEntity>(mDocControlForum.MDocCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDocControlForumEntity", ex);
                throw;
            }

            return mDocControlForumEntity;
        }

        public static MAASDisciplinaryTypeEntity GetMAASDisciplinaryTypeEntity(MAASDisciplinaryType mAASDisciplinaryType)
        {
            MAASDisciplinaryTypeEntity mAASDisciplinaryTypeEntity = null;
            try
            {
                mAASDisciplinaryTypeEntity = Mapper.Map<MAASDisciplinaryType, MAASDisciplinaryTypeEntity>(mAASDisciplinaryType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMCourtVacationEntity", ex);
                throw;
            }
            return mAASDisciplinaryTypeEntity;
        }

        /// <summary>
        /// Gets the m document control forum entity.
        /// </summary>
        /// <param name="mDocControlForum">The m document control forum.</param>
        /// <returns></returns>
        public static RMDocTierSensitiveEntity GetRMDocTierSensitiveEntity(RMDocTierSensitive rMDocTierSensitive)
        {
            RMDocTierSensitiveEntity rMDocTierSensitiveEntity = null;

            try
            {
                if (rMDocTierSensitive != null)
                {
                    rMDocTierSensitiveEntity = Mapper.Map<RMDocTierSensitive, RMDocTierSensitiveEntity>(rMDocTierSensitive);
                    rMDocTierSensitiveEntity.CaseTypeCode = Mapper.Map<MCaseType, MCaseTypeEntity>(rMDocTierSensitive.CaseTypeCode);
                    rMDocTierSensitiveEntity.MDocCode = Mapper.Map<MDocCode, MDocCodeEntity>(rMDocTierSensitive.MDocCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMDocTierSensitiveEntity", ex);
                throw;
            }

            return rMDocTierSensitiveEntity;
        }


        public static RMHrgSlotNOCEntity GetRMHrgSlotNOCEntity(RMHrgSlotNOC rMHrgSlotNOC)
        {
            RMHrgSlotNOCEntity rMHrgSlotNOCEntity = null;

            try
            {
                if (rMHrgSlotNOC != null)
                {
                    rMHrgSlotNOCEntity = Mapper.Map<RMHrgSlotNOC, RMHrgSlotNOCEntity>(rMHrgSlotNOC);
                   
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at NHibernateToDomain. RMHrgSlotNOCEntity", ex);
                throw;
            }

            return rMHrgSlotNOCEntity;
        }

        public static MDefaultLoginPageEntity GetMDefaultLoginPageEntity(MDefaultLoginPage mDefaultLoginPage)
        {
            MDefaultLoginPageEntity mDefaultLoginPageEntity = null;

            try
            {
                mDefaultLoginPageEntity = Mapper.Map<MDefaultLoginPage, MDefaultLoginPageEntity>(mDefaultLoginPage);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDefaultLoginPageEntity", ex);
                throw;
            }

            return mDefaultLoginPageEntity;
        }

        public static RMHrgSlotLegisEntity GetRMHrgSlotLegisEntity(RMHrgSlotLegis rMHrgSlotLegis)
        {
            RMHrgSlotLegisEntity rMHrgSlotLegisEntity = null;

            try
            {
                if (rMHrgSlotLegis != null)
                {
                    rMHrgSlotLegisEntity = Mapper.Map<RMHrgSlotLegis, RMHrgSlotLegisEntity>(rMHrgSlotLegis);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at NHibernateToDomain. rMHrgSlotLegisEntity", ex);
                throw;
            }

            return rMHrgSlotLegisEntity;
        }

        public static RMDocControlExclusionEntity GetRMDocControlExclusionEntity(RMDocControlExclusion rMDocControlExclusion)
        {
            RMDocControlExclusionEntity rMDocControlExclusionEntity = null;

            try
            {
                if (rMDocControlExclusion != null)
                {
                    rMDocControlExclusionEntity = Mapper.Map<RMDocControlExclusion, RMDocControlExclusionEntity>(rMDocControlExclusion);
                    rMDocControlExclusionEntity.ForumID = Mapper.Map<MForumType, MForumTypeEntity>(rMDocControlExclusion.MForumType);
                    rMDocControlExclusionEntity.CaseTypeCode = Mapper.Map<MCaseType, MCaseTypeEntity>(rMDocControlExclusion.MCaseType);
                    rMDocControlExclusionEntity.SubCaseTypeCode = Mapper.Map<MCaseType, MCaseTypeEntity>(rMDocControlExclusion.MSubCaseType);
                    rMDocControlExclusionEntity.DocCode = Mapper.Map<MDocCode, MDocCodeEntity>(rMDocControlExclusion.MDocCode);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at NHibernateToDomain. GetRMDocControlExclusionEntity", ex);
                throw;
            }

            return rMDocControlExclusionEntity;
        }

        /// <summary>
        /// Gets the <see cref="MResidentialEntity"/> from <see cref="MResidential"/> input.
        /// </summary>
        /// <param name="mResidential"><see cref="MResidential"/></param>
        /// <returns>Returns <see cref="MResidentialEntity"/>, else null.</returns>
        public static MResidentialEntity GetMResidentialEntity(MResidential mResidential)
        {
            MResidentialEntity mResidentialEntity = null;

            try
            {
                mResidentialEntity = Mapper.Map<MResidential, MResidentialEntity>(mResidential);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetResidentialEntity", ex);
                throw;
            }

            return mResidentialEntity;
        }

        /// <summary>
        /// Gets the <see cref="MIncomeEntity"/> from <see cref="MIncome"/> input.
        /// </summary>
        /// <param name="mIncome"><see cref="MIncome"/></param>
        /// <returns>Returns <see cref="MIncomeEntity"/>, else null.</returns>
        public static MIncomeEntity GetMIncomeEntity(MIncome mIncome)
        {
            MIncomeEntity mIncomeEntity = null;

            try
            {
                mIncomeEntity = Mapper.Map<MIncome, MIncomeEntity>(mIncome);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMIncomeEntity", ex);
                throw;
            }

            return mIncomeEntity;
        }

        /// <summary>
        /// Gets the <see cref="MDirectionsEntity"/> from <see cref="MDirections"/> input.
        /// </summary>
        /// <param name="mIncome"><see cref="MDirections"/></param>
        /// <returns>Returns <see cref="MDirectionsEntity"/>, else null.</returns>
        public static MDirectionsEntity GetMDirectionsEntity(MDirections mDirections)
        {
            MDirectionsEntity mDirectionsEntity = null;

            try
            {
                mDirectionsEntity = Mapper.Map<MDirections, MDirectionsEntity>(mDirections);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDirectionsEntity", ex);
                throw;
            }

            return mDirectionsEntity;
        }


        public static MHarassPlaceEntity GetMHarassPlaceEntity(MHarassPlace mHarassPlace)
        {
            MHarassPlaceEntity mHarassPlaceEntity = null;

            try
            {
                mHarassPlaceEntity = Mapper.Map<MHarassPlace, MHarassPlaceEntity>(mHarassPlace);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetmHarassPlaceEntity", ex);
                throw;
            }

            return mHarassPlaceEntity;
        }

        #endregion Methods

       
    }
}