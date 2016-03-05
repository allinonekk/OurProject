#region Header

/*****************************************************************************************************
* Description : This file represents a object mapper Master entities. This class will map Object to
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
// File: MasterMapper.cs
// Description: This file represents a object mapper Master entities. This class will map Object to
// Entity.
// </summary>
// <copyright file= "MasterMapper.cs" company="AllInOne Pte Ltd">
// Copyright (CDomainEntity) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.MRelationship;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    public class MasterMapper
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(MasterMapper));

        private static MasterMapping masterMapping = new MasterMapping();

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the <see cref="MEMSADMExecLocation"/> from <see cref="MEMSADMExecLocationEntity"/> input.
        /// </summary>
        /// <param name="MEMSADMExecLocationEntity"><see cref="MEMSADMExecLocationEntity"/></param>
        /// <returns>Returns <see cref="MEMSADMExecLocation"/>, else null.</returns>
        public static MEMSADMExecLocation GetMEMSADMExecLocation(MEMSADMExecLocationEntity mEMSADMExecLocationEntity)
        {
            MEMSADMExecLocation mEMSADMExecLocation = null;

            try
            {
                mEMSADMExecLocation = Mapper.Map<MEMSADMExecLocationEntity, MEMSADMExecLocation>(mEMSADMExecLocationEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMEMSADMExecLocation", ex);
                throw;
            }

            return mEMSADMExecLocation;
        }

        /// <summary>
        /// Gets the <see cref="MPrinter"/> from <see cref="mPrinterEntity"/> input.
        /// </summary>
        /// <param name="MPrinterEntity"><see cref="MPrinterEntity"/></param>
        /// <returns>Returns <see cref="MPrinter"/>, else null.</returns>
        public static MPrinter GetMPrinter(MPrinterEntity mPrinterEntity)
        {
            MPrinter mPrinter = null;

            try
            {
                mPrinter = Mapper.Map<MPrinterEntity, MPrinter>(mPrinterEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPrinter", ex);
                throw;
            }

            return mPrinter;
        }


        /// <summary>
        /// Gets the M law firm group.
        /// </summary>
        /// <param name="mLawFirmGroupEntity">The m law firm group entity.</param>
        /// <returns></returns>
        public static MLawFirmGroup GetMLawFirmGroup(MLawFirmGroupEntity mLawFirmGroupEntity)
        {
            MLawFirmGroup mLawFirmGroup = null;

            try
            {
                mLawFirmGroup = Mapper.Map<MLawFirmGroupEntity, MLawFirmGroup>(mLawFirmGroupEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMLawFirmGroup", ex);
                throw;
            }

            return mLawFirmGroup;
        }

        /// <summary>
        /// Gets the MEMSCrmCasePrefix group.
        /// </summary>
        /// <param name="mEMSCrmCasePrefixEntity">The m law firm group entity.</param>
        /// <returns></returns>
        public static MEMSCrmCasePrefix GetMEMSCrmCasePrefix(MEMSCrmCasePrefixEntity mEMSCrmCasePrefixEntity)
        {
            MEMSCrmCasePrefix mEMSCrmCasePrefix = null;

            try
            {
                mEMSCrmCasePrefix = Mapper.Map<MEMSCrmCasePrefixEntity, MEMSCrmCasePrefix>(mEMSCrmCasePrefixEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMEMSCrmCasePrefix", ex);
                throw;
            }

            return mEMSCrmCasePrefix;
        }

        /// <summary>
        /// Gets the <see cref="MAASDisciplinaryResultType"/> from <see cref="mAASDisciplinaryResultTypeEntity"/> input.
        /// </summary>
        /// <param name="mAASDisciplinaryResultTypeEntity"><see cref="mAASDisciplinaryResultTypeEntity"/></param>
        /// <returns>Returns <see cref="MSequenceKey"/>, else null.</returns>
        public static MAASDisciplinaryResultType GetMAASDisciplinaryResultType(MAASDisciplinaryResultTypeEntity mAASDisciplinaryResultTypeEntity)
        {
            MAASDisciplinaryResultType mAASDisciplinaryResultType = null;

            try
            {
                mAASDisciplinaryResultType = Mapper.Map<MAASDisciplinaryResultTypeEntity, MAASDisciplinaryResultType>(mAASDisciplinaryResultTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAASDisciplinaryResultType", ex);
                throw;
            }

            return mAASDisciplinaryResultType;
        }

        /// <summary>
        /// Gets the <see cref="RMNOAForumHrgType"/> from <see cref="RMNOAForumHrgTypeEntity"/> input.
        /// </summary>
        /// <param name="rMNOAForumHrgTypeEntity"><see cref="rMNOAForumHrgTypeEntity"/></param>
        /// <returns>Returns <see cref="RMNOAForumHrgType"/>, else null.</returns>
        public static RMNOAForumHrgType GetRMNOAForumHrgType(RMNOAForumHrgTypeEntity rMNOAForumHrgTypeEntity)
        {
            RMNOAForumHrgType rMNOAForumHrgType = null;

            try
            {
                rMNOAForumHrgType = Mapper.Map<RMNOAForumHrgTypeEntity, RMNOAForumHrgType>(rMNOAForumHrgTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMNOAForumHrgType", ex);
                throw;
            }

            return rMNOAForumHrgType;
        }

        /// <summary>
        /// Gets the <see cref="MAASDisciplinaryType"/> from <see cref="MAASDisciplinaryTypeEntity"/> input.
        /// </summary>
        /// <param name="mAASDisciplinaryTypeEntity"><see cref="MAASDisciplinaryTypeEntity"/></param>
        /// <returns>Returns <see cref="MAASDisciplinaryType"/>, else null.</returns>
        public static MAASDisciplinaryType GetMAASDisciplinaryType(MAASDisciplinaryTypeEntity mAASDisciplinaryTypeEntity)
        {
            MAASDisciplinaryType mAASDisciplinaryType = null;

            try
            {
                mAASDisciplinaryType = Mapper.Map<MAASDisciplinaryTypeEntity, MAASDisciplinaryType>(mAASDisciplinaryTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAASDisciplinaryType", ex);
                throw;
            }

            return mAASDisciplinaryType;
        }

        /// <summary>
        /// Gets the <see cref="MAASDisciplinaryType"/> from <see cref="MAASLawDegreeEntity"/> input.
        /// </summary>
        /// <param name="mAASLawDegreeEntity"><see cref="MAASLawDegreeEntity"/></param>
        /// <returns>Returns <see cref="MAASLawDegree"/>, else null.</returns>
        public static MAASLawDegree GetMAASLawDegree(MAASLawDegreeEntity mAASLawDegreeEntity)
        {
            MAASLawDegree mAASLawDegree = null;

            try
            {
                mAASLawDegree = Mapper.Map<MAASLawDegreeEntity, MAASLawDegree>(mAASLawDegreeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAASLawDegree", ex);
                throw;
            }

            return mAASLawDegree;
        }

        /// <summary>
        /// Gets the <see cref="MAASQualification"/> from <see cref="MAASQualificationEntity"/> input.
        /// </summary>
        /// <param name="mAASQualificationDomainEntity"><see cref="MAASQualificationEntity"/></param>
        /// <returns>Returns <see cref="MAASQualification"/>, else null.</returns>
        public static MAASQualification GetMAASQualification(MAASQualificationEntity mAASQualificationDomainEntity)
        {
            MAASQualification mAASQualificationNHibernateEntity = null;

            try
            {
                mAASQualificationNHibernateEntity = Mapper.Map<MAASQualificationEntity, MAASQualification>(mAASQualificationDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAASQualification", ex);
                throw;
            }

            return mAASQualificationNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MAASSection"/> from <see cref="MAASSectionEntity"/> input.
        /// </summary>
        /// <param name="mAASSectionEntity"><see cref="MAASSectionEntity"/></param>
        /// <returns>Returns <see cref="MAASSection"/>, else null.</returns>
        public static MAASSection GetMAASSection(MAASSectionEntity mAASSectionEntity)
        {
            MAASSection mAASSection = null;

            try
            {
                mAASSection = Mapper.Map<MAASSectionEntity, MAASSection>(mAASSectionEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAASSection", ex);
                throw;
            }

            return mAASSection;
        }

        /// <summary>
        /// Gets the <see cref="MHearingType"/> from <see cref="mHearingTypeEntity"/> input.
        /// </summary>
        /// <param name="mHearingTypeEntity"><see cref="mHearingTypeEntity"/></param>
        /// <returns>Returns <see cref="MHearingType"/>, else null.</returns>
        public static MHearingType GetMHearingType(MHearingTypeEntity mHearingTypeEntity)
        {
            MHearingType mHearingType = null;

            try
            {
                mHearingType = Mapper.Map<MHearingTypeEntity, MHearingType>(mHearingTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMHearingType", ex);
                throw;
            }

            return mHearingType;
        }

        /// <summary>
        /// Gets the <see cref="MAASUniversity"/> from <see cref="MAASUniversityEntity"/> input.
        /// </summary>
        /// <param name="mAASUniversityEntity"><see cref="MAASUniversityEntity"/></param>
        /// <returns>Returns <see cref="MAASUniversity"/>, else null.</returns>
        public static MAASUniversity GetMAASUniversity(MAASUniversityEntity mAASUniversityEntity)
        {
            MAASUniversity mAASUniversity = null;

            try
            {
                mAASUniversity = Mapper.Map<MAASUniversityEntity, MAASUniversity>(mAASUniversityEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMAASUniversity", ex);
                throw;
            }

            return mAASUniversity;
        }

        /// <summary>
        /// Maps the entities to domain.
        /// </summary>
        /// <param name="caseInfo">The case info.</param>
        /// <returns>Returns the <see cref="CaseInfoEntity"/>, else null.</returns>
        public static MActingInCapacity GetMActingInCapacity(MActingInCapacityEntity mActingInCapacityEntity)
        {
            MActingInCapacity mActingInCapacity = null;

            try
            {
                mActingInCapacity = Mapper.Map<MActingInCapacityEntity, MActingInCapacity>(mActingInCapacityEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMActingInCapacity", ex);
                throw;
            }

            return mActingInCapacity;
        }

        public static MActingInCapacityGroup GetmActingInCapacityGroup(MActingInCapacityGroupEntity mActingInCapacityGroupEntity)
        {
            MActingInCapacityGroup mActingInCapacityGroup = null;

            try
            {
                ////masterMapping.MasterEntityToMasterMapping();
                mActingInCapacityGroup = Mapper.Map<MActingInCapacityGroupEntity, MActingInCapacityGroup>(mActingInCapacityGroupEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetmActingInCapacityGroup", ex);
                throw;
            }

            return mActingInCapacityGroup;
        }

        public static MAdpPrayer GetMAdpPrayer(MAdpPrayerEntity mAdpPrayerEntity)
        {
            MAdpPrayer mAdpPrayer = null;

            try
            {
                ////masterMapping.MasterEntityToMasterMapping();
                mAdpPrayer = Mapper.Map<MAdpPrayerEntity, MAdpPrayer>(mAdpPrayerEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetMAdpPrayer", ex);
                throw;
            }

            return mAdpPrayer;
        }

        public static MAlertEvent GetMAlertEvent(MAlertEventEntity mAlertEventEntity)
        {
            MAlertEvent mAlertEvent = null;

            try
            {
                mAlertEvent = Mapper.Map<MAlertEventEntity, MAlertEvent>(mAlertEventEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetMAlertEvent", ex);
                throw;
            }

            return mAlertEvent;
        }

        public static MAlertType GetMAlertType(MAlertTypeEntity mAlertTypeEntity)
        {
            MAlertType mAlertType = null;

            try
            {
                ////masterMapping.MAlertTypeEntityToMAlertTypeMapping();
                mAlertType = Mapper.Map<MAlertTypeEntity, MAlertType>(mAlertTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetMAlertType", ex);
                throw;
            }

            return mAlertType;
        }

        public static MApplicantCapacity GetMApplicantCapacity(MApplicantCapacityEntity mApplicantCapacityEntity)
        {
            MApplicantCapacity mApplicantCapacity = null;

            try
            {
                ////masterMapping.MasterEntityToMasterMapping();
                mApplicantCapacity = Mapper.Map<MApplicantCapacityEntity, MApplicantCapacity>(mApplicantCapacityEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMApplicantCapacity", ex);
                throw;
            }

            return mApplicantCapacity;
        }

        /// <summary>
        /// Gets the <see cref="MAASDisciplinaryType"/> from <see cref="MAASDisciplinaryTypeEntity"/> input.
        /// </summary>
        /// <param name="mAASDisciplinaryTypeEntity"><see cref="MAASDisciplinaryTypeEntity"/></param>
        /// <returns>Returns <see cref="MAASDisciplinaryType"/>, else null.</returns>
        public static MApptOrganisation GetMApptOrganisation(MApptOrganisationEntity mApptOrganisationEntity)
        {
            MApptOrganisation mApptOrganisation = null;

            try
            {
                mApptOrganisation = Mapper.Map<MApptOrganisationEntity, MApptOrganisation>(mApptOrganisationEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMApptOrganisation", ex);
                throw;
            }

            return mApptOrganisation;
        }

        /// <summary>
        /// Gets the master entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="masterEntity">The master entity.</param>
        /// <returns></returns>
        public static IMaster GetMasterEntity<T>(T masterEntity)
        {
            if (masterEntity.GetType().Equals(typeof(MCoramEntity)))
                return MasterMapper.GetMCoram(masterEntity as MCoramEntity);

            else if (masterEntity.GetType().Equals(typeof(MEMSCrmCasePrefixEntity)))
                return MasterMapper.GetMEMSCrmCasePrefix(masterEntity as MEMSCrmCasePrefixEntity);

            else if (masterEntity.GetType().Equals(typeof(MEMSAttendanceFeeEntity)))
                return MasterMapper.GetMEMSAttendanceFee(masterEntity as MEMSAttendanceFeeEntity);

            else if (masterEntity.GetType().Equals(typeof(MEMSADMExecLocationEntity)))
                return MasterMapper.GetMEMSADMExecLocation(masterEntity as MEMSADMExecLocationEntity);

            else if (masterEntity.GetType().Equals(typeof(MPrinterEntity)))
                return MasterMapper.GetMPrinter(masterEntity as MPrinterEntity);

            else if (masterEntity.GetType().Equals(typeof(MLawFirmGroupEntity)))
                return MasterMapper.GetMLawFirmGroup(masterEntity as MLawFirmGroupEntity);

            else if (masterEntity.GetType().Equals(typeof(RMNOAForumHrgTypeEntity)))
                return MasterMapper.GetRMNOAForumHrgType(masterEntity as RMNOAForumHrgTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MSummonsParamEntity)))
                return MasterMapper.GetMSummonsParam(masterEntity as MSummonsParamEntity);

            else if (masterEntity.GetType().Equals(typeof(MHRGOutComeFlagEntity)))
                return MasterMapper.GetMHRGOutComeFlag(masterEntity as MHRGOutComeFlagEntity);

            else if (masterEntity.GetType().Equals(typeof(RMHRGTypeHRGOutComeHRGOutComeFlagEntity)))
                return MasterMapper.GetRMHRGTypeHRGOutComeHRGOutComeFlag(masterEntity as RMHRGTypeHRGOutComeHRGOutComeFlagEntity);

            else if (masterEntity.GetType().Equals(typeof(RMDocCodeHrgTypeEntity)))
                return MasterMapper.GetRMDocCodeHRGType(masterEntity as RMDocCodeHrgTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(RMForumCoramDSGEntity)))
                return MasterMapper.GetRMForumCoramDSG(masterEntity as RMForumCoramDSGEntity);

            else if (masterEntity.GetType().Equals(typeof(RMHearingTypeCourtTypeEntity)))
                return MasterMapper.GetRMHearingTypeCourtType(masterEntity as RMHearingTypeCourtTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MDocCategoryEntity)))
                return MasterMapper.GetMDocCategory(masterEntity as MDocCategoryEntity);

            else if (masterEntity.GetType().Equals(typeof(MAASDisciplinaryTypeEntity)))
                return MasterMapper.GetMAASDisciplinaryType(masterEntity as MAASDisciplinaryTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MEMSSecurityGuardEntity)))
                return MasterMapper.GetMEMSSecurityGuard(masterEntity as MEMSSecurityGuardEntity);

            else if (masterEntity.GetType().Equals(typeof(MSequenceKeyEntity)))
                return MasterMapper.GetMSequenceKey(masterEntity as MSequenceKeyEntity);

            else if (masterEntity.GetType().Equals(typeof(MHolidayEntity)))
                return MasterMapper.GetMHoliday(masterEntity as MHolidayEntity);

            else if (masterEntity.GetType().Equals(typeof(MFormSignatureEntity)))
                return MasterMapper.GetMFormSignature(masterEntity as MFormSignatureEntity);

            else if (masterEntity.GetType().Equals(typeof(SerialNumberEntity)))
                return MasterMapper.GetSerialNumber(masterEntity as SerialNumberEntity);

            else if (masterEntity.GetType().Equals(typeof(RUserFunctionsEntity)))
                return MasterMapper.GetRUserFunctions(masterEntity as RUserFunctionsEntity);

            else if (masterEntity.GetType().Equals(typeof(RUserRoleSectionEntity)))
                return MasterMapper.GetRUserRoleSection(masterEntity as RUserRoleSectionEntity);

            else if (masterEntity.GetType().Equals(typeof(RRoleFunctionsEntity)))
                return MasterMapper.GetRRoleFunctions(masterEntity as RRoleFunctionsEntity);

            else if (masterEntity.GetType().Equals(typeof(MAASQualificationEntity)))
                return MasterMapper.GetMAASQualification(masterEntity as MAASQualificationEntity);

            else if (masterEntity.GetType().Equals(typeof(MAASLawDegreeEntity)))
                return MasterMapper.GetMAASLawDegree(masterEntity as MAASLawDegreeEntity);

            else if (masterEntity.GetType().Equals(typeof(MAASSectionEntity)))
                return MasterMapper.GetMAASSection(masterEntity as MAASSectionEntity);

            else if (masterEntity.GetType().Equals(typeof(MAASUniversityEntity)))
                return MasterMapper.GetMAASUniversity(masterEntity as MAASUniversityEntity);

            else if (masterEntity.GetType().Equals(typeof(MExternalAgencyEntity)))
                return MasterMapper.GetMExternalAgency(masterEntity as MExternalAgencyEntity);

            else if (masterEntity.GetType().Equals(typeof(MExternalAgencyAddressEntity)))
                return MasterMapper.GetMExternalAgencyAddress(masterEntity as MExternalAgencyAddressEntity);

            else if (masterEntity.GetType().Equals(typeof(RMAASSectionExternalAgencyEntity)))
                return MasterMapper.GetRMAASSectionExternalAgency(masterEntity as RMAASSectionExternalAgencyEntity);

            else if (masterEntity.GetType().Equals(typeof(MActingInCapacityEntity)))
                return MasterMapper.GetMActingInCapacity(masterEntity as MActingInCapacityEntity);

            else if (masterEntity.GetType().Equals(typeof(MActingInCapacityGroupEntity)))
                return MasterMapper.GetmActingInCapacityGroup(masterEntity as MActingInCapacityGroupEntity);

            else if (masterEntity.GetType().Equals(typeof(MAdpPrayerEntity)))
                return MasterMapper.GetMAdpPrayer(masterEntity as MAdpPrayerEntity);

            else if (masterEntity.GetType().Equals(typeof(MAlertEventEntity)))
                return MasterMapper.GetMAlertEvent(masterEntity as MAlertEventEntity);

            else if (masterEntity.GetType().Equals(typeof(MAlertTypeEntity)))
                return MasterMapper.GetMAlertType(masterEntity as MAlertTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MApplicantCapacityEntity)))
                return MasterMapper.GetMApplicantCapacity(masterEntity as MApplicantCapacityEntity);

            else if (masterEntity.GetType().Equals(typeof(MBasisForTaxationEntity)))
                return MasterMapper.GetMBasisForTaxation(masterEntity as MBasisForTaxationEntity);

            else if (masterEntity.GetType().Equals(typeof(MBasisOfTaxationTypeEntity)))
                return MasterMapper.GetMBasisOfTaxationType(masterEntity as MBasisOfTaxationTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MFilingFeeEntity)))
                return MasterMapper.GetMFilingFee(masterEntity as MFilingFeeEntity);

            //else if (masterEntity.GetType().Equals(typeof(MBillNatureEntity)))
            //    return MasterMapper.GetMBillNature(masterEntity as MBillNatureEntity); //TODO:Mapping for MBillNature

            else if (masterEntity.GetType().Equals(typeof(MBillTypeEntity)))
                return MasterMapper.GetMBillType(masterEntity as MBillTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MCaseSecurityEntity)))
                return MasterMapper.GetMCaseSecurity(masterEntity as MCaseSecurityEntity);

            else if (masterEntity.GetType().Equals(typeof(MCaseStatusEntity)))
                return MasterMapper.GetMCaseStatus(masterEntity as MCaseStatusEntity);

            else if (masterEntity.GetType().Equals(typeof(MCaseTypeEntity)))
                return MasterMapper.GetMCaseType(masterEntity as MCaseTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MCaseTypeGroupEntity)))
                return MasterMapper.GetMCaseTypeGroup(masterEntity as MCaseTypeGroupEntity);

            else if (masterEntity.GetType().Equals(typeof(MChecklistEntity)))
                return MasterMapper.GetMChecklist(masterEntity as MChecklistEntity);

            else if (masterEntity.GetType().Equals(typeof(MChecklistDocumentEntity)))
                return MasterMapper.GetMChecklistDocument(masterEntity as MChecklistDocumentEntity);

            else if (masterEntity.GetType().Equals(typeof(MClaimTypeEntity)))
                return MasterMapper.GetMClaimType(masterEntity as MClaimTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MCountryEntity)))
                return MasterMapper.GetMCountry(masterEntity as MCountryEntity);

            else if (masterEntity.GetType().Equals(typeof(MCourtTypeEntity)))
                return MasterMapper.GetMCourtType(masterEntity as MCourtTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MCurrencyEntity)))
                return MasterMapper.GetMCurrency(masterEntity as MCurrencyEntity);

            else if (masterEntity.GetType().Equals(typeof(MDamageEntity)))
                return MasterMapper.GetMDamage(masterEntity as MDamageEntity);

            else if (masterEntity.GetType().Equals(typeof(MDeedTypeEntity)))
                return MasterMapper.GetMDeedType(masterEntity as MDeedTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MDesignationEntity)))
                return MasterMapper.GetMDesignation(masterEntity as MDesignationEntity);

            else if (masterEntity.GetType().Equals(typeof(MDialectEntity)))
                return MasterMapper.GetMDialect(masterEntity as MDialectEntity);

            else if (masterEntity.GetType().Equals(typeof(MDocCodeEntity)))
                return MasterMapper.GetMDocCode(masterEntity as MDocCodeEntity);

            else if (masterEntity.GetType().Equals(typeof(MDocLegislationEntity)))
                return MasterMapper.GetMDocLegislation(masterEntity as MDocLegislationEntity);

            else if (masterEntity.GetType().Equals(typeof(MDocNatureEntity)))
                return MasterMapper.GetMDocNature(masterEntity as MDocNatureEntity);

            else if (masterEntity.GetType().Equals(typeof(MDocSecurityEntity)))
                return MasterMapper.GetMDocSecurity(masterEntity as MDocSecurityEntity);

            else if (masterEntity.GetType().Equals(typeof(MDocStatusEntity)))
                return MasterMapper.GetMDocStatus(masterEntity as MDocStatusEntity);

            else if (masterEntity.GetType().Equals(typeof(MFilterGroupEntity)))
                return MasterMapper.GetMFilterGroup(masterEntity as MFilterGroupEntity);

            else if (masterEntity.GetType().Equals(typeof(MForumTypeEntity)))
                return MasterMapper.GetMForumType(masterEntity as MForumTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MFunctionsEntity)))
                return MasterMapper.GetMFunctions(masterEntity as MFunctionsEntity);

            else if (masterEntity.GetType().Equals(typeof(MGenderEntity)))
                return MasterMapper.GetMGender(masterEntity as MGenderEntity);

            else if (masterEntity.GetType().Equals(typeof(MHRGOutComeEntity)))
                return MasterMapper.GetMHRGOutComeEntity(masterEntity as MHRGOutComeEntity);

            else if (masterEntity.GetType().Equals(typeof(MHRGOutComeReasonEntity)))
                return MasterMapper.GetMHRGOutComeReasonEntity(masterEntity as MHRGOutComeReasonEntity);

            else if (masterEntity.GetType().Equals(typeof(MHRGRoomEntity)))
                return MasterMapper.GetMHRGRoomEntity(masterEntity as MHRGRoomEntity);

            else if (masterEntity.GetType().Equals(typeof(MHRGRoomTypeEntity)))
                return MasterMapper.GetMHRGRoomTypeEntity(masterEntity as MHRGRoomTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MHRGSlotEntity)))
                return MasterMapper.GetMHRGSlotEntity(masterEntity as MHRGSlotEntity);

            else if (masterEntity.GetType().Equals(typeof(MHRGTimeLineEntity)))
                return MasterMapper.GetMHRGTimeLineEntity(masterEntity as MHRGTimeLineEntity);

            else if (masterEntity.GetType().Equals(typeof(MHRGTypeEntity)))
                return MasterMapper.GetMHRGTypeEntity(masterEntity as MHRGTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MIconItemEntity)))
                return MasterMapper.GetMIconItemEntity(masterEntity as MIconItemEntity);

            else if (masterEntity.GetType().Equals(typeof(MJudGDCatchWordEntity)))
                return MasterMapper.GetMJudGDCatchWordEntity(masterEntity as MJudGDCatchWordEntity);

            else if (masterEntity.GetType().Equals(typeof(MLegislationActEntity)))
                return MasterMapper.GetMLegislationActEntity(masterEntity as MLegislationActEntity);

            else if (masterEntity.GetType().Equals(typeof(MLocationEntity)))
                return MasterMapper.GetMLocationEntity(masterEntity as MLocationEntity);

            else if (masterEntity.GetType().Equals(typeof(MMaritalStatusEntity)))
                return MasterMapper.GetMMaritalStatusEntity(masterEntity as MMaritalStatusEntity);

            else if (masterEntity.GetType().Equals(typeof(MMessageTypeEntity)))
                return MasterMapper.GetMMessageTypeEntity(masterEntity as MMessageTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MNAAAlertEventRecipientEntity)))
                return MasterMapper.GetMNAAAlertEventRecipientEntity(masterEntity as MNAAAlertEventRecipientEntity);

            else if (masterEntity.GetType().Equals(typeof(MNAAAlertEventsTemplateEntity)))
                return MasterMapper.GetMNAAAlertEventsTemplateEntity(masterEntity as MNAAAlertEventsTemplateEntity);

            else if (masterEntity.GetType().Equals(typeof(MNAACategoryEntity)))
                return MasterMapper.GetMNAACategoryEntity(masterEntity as MNAACategoryEntity);

            else if (masterEntity.GetType().Equals(typeof(MNAAPlaceHolderEntity)))
                return MasterMapper.GetMNAAPlaceHolderEntity(masterEntity as MNAAPlaceHolderEntity);

            else if (masterEntity.GetType().Equals(typeof(MNAASubCategoryEntity)))
                return MasterMapper.GetMNAASubCategoryEntity(masterEntity as MNAASubCategoryEntity);

            else if (masterEntity.GetType().Equals(typeof(MNationalityEntity)))
                return MasterMapper.GetMNationalityEntity(masterEntity as MNationalityEntity);

            else if (masterEntity.GetType().Equals(typeof(MNatureOfWorkEntity)))
                return MasterMapper.GetMNatureOfWorkEntity(masterEntity as MNatureOfWorkEntity);

            else if (masterEntity.GetType().Equals(typeof(MNOACodeEntity)))
                return MasterMapper.GetMNOACodeEntity(masterEntity as MNOACodeEntity);

            else if (masterEntity.GetType().Equals(typeof(MNOCEntity)))
                return MasterMapper.GetMNOCEntity(masterEntity as MNOCEntity);

            else if (masterEntity.GetType().Equals(typeof(MOccupationEntity)))
                return MasterMapper.GetMOccupationEntity(masterEntity as MOccupationEntity);

            else if (masterEntity.GetType().Equals(typeof(MOSDocDetailEntity)))
                return MasterMapper.GetMOSDocDetailEntity(masterEntity as MOSDocDetailEntity);

            else if (masterEntity.GetType().Equals(typeof(MOSTypeEntity)))
                return MasterMapper.GetMOSTypeEntity(masterEntity as MOSTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MParameterListEntity)))
                return MasterMapper.GetMParameterListEntity(masterEntity as MParameterListEntity);

            else if (masterEntity.GetType().Equals(typeof(MPartyAmendmentConfigEntity)))
                return MasterMapper.GetMPartyAmendmentConfigEntity(masterEntity as MPartyAmendmentConfigEntity);

            else if (masterEntity.GetType().Equals(typeof(MPartySectionEntity)))
                return MasterMapper.GetMPartySectionEntity(masterEntity as MPartySectionEntity);

            else if (masterEntity.GetType().Equals(typeof(MPartyStatusEntity)))
                return MasterMapper.GetMPartyStatusEntity(masterEntity as MPartyStatusEntity);

            else if (masterEntity.GetType().Equals(typeof(MPartyTypeEntity)))
                return MasterMapper.GetMPartyTypeEntity(masterEntity as MPartyTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MPersonIDGroupEntity)))
                return MasterMapper.GetMPersonIDGroupEntity(masterEntity as MPersonIDGroupEntity);

            else if (masterEntity.GetType().Equals(typeof(MPersonIDTypeEntity)))
                return MasterMapper.GetMPersonIDTypeEntity(masterEntity as MPersonIDTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MPrayerOutcomeEntity)))
                return MasterMapper.GetMPrayerOutcomeEntity(masterEntity as MPrayerOutcomeEntity);

            else if (masterEntity.GetType().Equals(typeof(MProbateNatureEntity)))
                return MasterMapper.GetMProbateNatureEntity(masterEntity as MProbateNatureEntity);

            else if (masterEntity.GetType().Equals(typeof(MProbatePrayerEntity)))
                return MasterMapper.GetMProbatePrayerEntity(masterEntity as MProbatePrayerEntity);

            else if (masterEntity.GetType().Equals(typeof(MPropertyTypeEntity)))
                return MasterMapper.GetMPropertyTypeEntity(masterEntity as MPropertyTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MProvisionEntity)))
                return MasterMapper.GetMProvisionEntity(masterEntity as MProvisionEntity);

            else if (masterEntity.GetType().Equals(typeof(MPTCMilestoneEntity)))
                return MasterMapper.GetMPTCMilestoneEntity(masterEntity as MPTCMilestoneEntity);

            else if (masterEntity.GetType().Equals(typeof(MQualificationEntity)))
                return MasterMapper.GetMQualificationEntity(masterEntity as MQualificationEntity);

            else if (masterEntity.GetType().Equals(typeof(MRaceEntity)))
                return MasterMapper.GetMRaceEntity(masterEntity as MRaceEntity);

            else if (masterEntity.GetType().Equals(typeof(MRDocCategoryCaseTypeEntity)))
                return MasterMapper.GetMRDocCategoryCaseTypeEntity(masterEntity as MRDocCategoryCaseTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MRelationshipEntity)))
                return MasterMapper.GetMRelationshipEntity(masterEntity as MRelationshipEntity);

            else if (masterEntity.GetType().Equals(typeof(MReliefEntity)))
                return MasterMapper.GetMReliefEntity(masterEntity as MReliefEntity);

            else if (masterEntity.GetType().Equals(typeof(MReligionEntity)))
                return MasterMapper.GetMReligionEntity(masterEntity as MReligionEntity);

            else if (masterEntity.GetType().Equals(typeof(MRoutingTypeEntity)))
                return MasterMapper.GetMRoutingTypeEntity(masterEntity as MRoutingTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MSalutationEntity)))
                return MasterMapper.GetMSalutationEntity(masterEntity as MSalutationEntity);

            else if (masterEntity.GetType().Equals(typeof(MSectionEntity)))
                return MasterMapper.GetMSectionEntity(masterEntity as MSectionEntity);

            else if (masterEntity.GetType().Equals(typeof(MSubProvisionEntity)))
                return MasterMapper.GetMSubProvisionEntity(masterEntity as MSubProvisionEntity);

            else if (masterEntity.GetType().Equals(typeof(MUserGroupEntity)))
                return MasterMapper.GetMUserGroupEntity(masterEntity as MUserGroupEntity);

            else if (masterEntity.GetType().Equals(typeof(MUserRoleEntity)))
                return MasterMapper.GetMUserRoleEntity(masterEntity as MUserRoleEntity);

            else if (masterEntity.GetType().Equals(typeof(MWorkFlowEntity)))
                return MasterMapper.GetMWorkFlowEntity(masterEntity as MWorkFlowEntity);

            else if (masterEntity.GetType().Equals(typeof(MWorkPeriodEntity)))
                return MasterMapper.GetMWorkPeriodEntity(masterEntity as MWorkPeriodEntity);

            else if (masterEntity.GetType().Equals(typeof(MScheduleJobLegalInfoEntity)))
                return MasterMapper.GetMScheduleJobLegalInfo(masterEntity as MScheduleJobLegalInfoEntity);

            else if (masterEntity.GetType().Equals(typeof(MScheduleJobLegalDetailEntity)))
                return MasterMapper.GetMScheduleJobLegalDetail(masterEntity as MScheduleJobLegalDetailEntity);

            else if (masterEntity.GetType().Equals(typeof(MEMSCourtCommEntity)))
                return MasterMapper.GetMEMSCourtComm(masterEntity as MEMSCourtCommEntity);

            else if (masterEntity.GetType().Equals(typeof(MEMSCourtCommEntity)))
                return MasterMapper.GetMEMSCourtComm(masterEntity as MEMSCourtCommEntity);

            else if (masterEntity.GetType().Equals(typeof(MEMSDisburseRateEntity)))
                return MasterMapper.GetMEMSDisburseRate(masterEntity as MEMSDisburseRateEntity);

            else if (masterEntity.GetType().Equals(typeof(MEMSWritApptEntity)))
                return MasterMapper.GetMEMSWritAppt(masterEntity as MEMSWritApptEntity);

            else if (masterEntity.GetType().Equals(typeof(MCaseIssueEntity)))
                return MasterMapper.GetMCaseIssue(masterEntity as MCaseIssueEntity);

            else if (masterEntity.GetType().Equals(typeof(RUserFunctionsEntity)))
                return MasterMapper.GetRUserFunctions(masterEntity as RUserFunctionsEntity);

            else if (masterEntity.GetType().Equals(typeof(MEMSAuctioneerEntity)))
                return MasterMapper.GetMEMSAuctioneer(masterEntity as MEMSAuctioneerEntity);

            else if (masterEntity.GetType().Equals(typeof(MEMSAppraiserEntity)))
                return MasterMapper.GetMEMSAppraiser(masterEntity as MEMSAppraiserEntity);

            else if (masterEntity.GetType().Equals(typeof(MEMSAdvertInEntity)))
                return MasterMapper.GetMEMSAdvertIn(masterEntity as MEMSAdvertInEntity);

            else if (masterEntity.GetType().Equals(typeof(MEMSAdvertiserEntity)))
                return MasterMapper.GetMEMSAdvertiser(masterEntity as MEMSAdvertiserEntity);

            else if (masterEntity.GetType().Equals(typeof(RMSectionAccessCtrlEntity)))
                return MasterMapper.GetRMSectionAccessCtrl(masterEntity as RMSectionAccessCtrlEntity);

            else if (masterEntity.GetType().Equals(typeof(RMRoutingSectionConfigEntity)))
                return MasterMapper.GetRMRoutingSectionConfig(masterEntity as RMRoutingSectionConfigEntity);

            else if (masterEntity.GetType().Equals(typeof(MAASDisciplinaryResultTypeEntity)))
                return MasterMapper.GetMAASDisciplinaryResultType(masterEntity as MAASDisciplinaryResultTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(MLimitationsEntity)))
                return MasterMapper.GetMLimitations(masterEntity as MLimitationsEntity);

            else if (masterEntity.GetType().Equals(typeof(MFormTemplateLocationEntity)))
                return MasterMapper.GetMFormTemplateLocation(masterEntity as MFormTemplateLocationEntity);

            else if (masterEntity.GetType().Equals(typeof(MMinuteSheetTypeEntity)))
                return MasterMapper.GetMMinuteSheetType(masterEntity as MMinuteSheetTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(RMCaseTypeHRGTypeMSTypeEntity)))
                return MasterMapper.GetRMCaseTypeHRGTypeMSType(masterEntity as RMCaseTypeHRGTypeMSTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(RMCaseTypeForumHRGTypeMSTypeEntity)))
                return MasterMapper.GetRMCaseTypeForumHRGTypeMSType(masterEntity as RMCaseTypeForumHRGTypeMSTypeEntity);


            else if (masterEntity.GetType().Equals(typeof(MLegalPracticeEntity)))
                return MasterMapper.GetMLegalPractice(masterEntity as MLegalPracticeEntity);

            else if (masterEntity.GetType().Equals(typeof(MCoramEntity)))
                return MasterMapper.GetMCoram(masterEntity as MCoramEntity);

            else if (masterEntity.GetType().Equals(typeof(MHearingTypeEntity)))
                return MasterMapper.GetMHearingType(masterEntity as MHearingTypeEntity);

            else if (masterEntity.GetType().Equals(typeof(RMForumCoramDSGEntity)))
                return MasterMapper.GetRMForumCoramDSG(masterEntity as RMForumCoramDSGEntity);

            else if (masterEntity.GetType().Equals(typeof(RMCaseTypeNOCEntity)))
                return MasterMapper.GetRMCaseTypeNOC(masterEntity as RMCaseTypeNOCEntity);

            else if (masterEntity.GetType().Equals(typeof(RMHRGTypeHRGSlotEntity)))
                return MasterMapper.GetRMHRGTypeHRGSlot(masterEntity as RMHRGTypeHRGSlotEntity);

            else if (masterEntity.GetType().Equals(typeof(MMassCallHrgDateEntity)))
                return MasterMapper.GetMMassCallHrgDate(masterEntity as MMassCallHrgDateEntity);

            else if (masterEntity.GetType().Equals(typeof(MChargeOutcomeEntity)))
                return MasterMapper.GetMChargeOutcome(masterEntity as MChargeOutcomeEntity);

            else if (masterEntity.GetType().Equals(typeof(MDocControlEntity)))
                return MasterMapper.GetMDocControl(masterEntity as MDocControlEntity);

            else if (masterEntity.GetType().Equals(typeof(MVSAConfigDetailEntity)))
                return (MasterMapper.GetMVSAConfigDetail(masterEntity as MVSAConfigDetailEntity));

            else if (masterEntity.GetType().Equals(typeof(MVSAConfigGroundEntity)))
                return (MasterMapper.GetMVSAConfigGround(masterEntity as MVSAConfigGroundEntity));

            else if (masterEntity.GetType().Equals(typeof(MVSAConfigPrayerEntity)))
                return (MasterMapper.GetMVSAConfigPrayer(masterEntity as MVSAConfigPrayerEntity));

            else if (masterEntity.GetType().Equals(typeof(MFilingFeeChargingMechanismEntity)))
                return (MasterMapper.GetMFilingFeeChargingMechanism(masterEntity as MFilingFeeChargingMechanismEntity));

            else if (masterEntity.GetType().Equals(typeof(MFilingFeeLegislationActEntity)))
                return (MasterMapper.GetMFilingFeeLegislationAct(masterEntity as MFilingFeeLegislationActEntity));

            else if (masterEntity.GetType().Equals(typeof(MHRGPredefinedDateEntity)))
                return (MasterMapper.GetMHRGPredefinedDate(masterEntity as MHRGPredefinedDateEntity));

            else if (masterEntity.GetType().Equals(typeof(RMCaseTypeHRGTypeJOLEntity)))
                return (MasterMapper.GetRMCaseTypeHRGTypeJOL(masterEntity as RMCaseTypeHRGTypeJOLEntity));

            else if (masterEntity.GetType().Equals(typeof(MHRGBeforeTypeEntity)))
                return (MasterMapper.GetMHRGBeforeType(masterEntity as MHRGBeforeTypeEntity));

            else if (masterEntity.GetType().Equals(typeof(RMSubCaseTypeHRGTypeMSTypeEntity)))
                return (MasterMapper.GetRMSubCaseTypeHRGTypeMSType(masterEntity as RMSubCaseTypeHRGTypeMSTypeEntity));

            else if (masterEntity.GetType().Equals(typeof(MFilingFeeLegislationActEntity)))
                return (MasterMapper.GetMFilingFeeLegislationAct(masterEntity as MFilingFeeLegislationActEntity));

            else if (masterEntity.GetType().Equals(typeof(RMAlertEventTypeRoleEntity)))
                return (MasterMapper.GetRMAlertEventTypeRole(masterEntity as RMAlertEventTypeRoleEntity));

            else if (masterEntity.GetType().Equals(typeof(RAlertEventSubscribersEntity)))
                return (MasterMapper.GetRAlertEventSubscribers(masterEntity as RAlertEventSubscribersEntity));

            else if (masterEntity.GetType().Equals(typeof(MBusinessJobLegalInfoEntity)))
                return (MasterMapper.GetMBusinessJobLegalInfo(masterEntity as MBusinessJobLegalInfoEntity));

            else if (masterEntity.GetType().Equals(typeof(MBusinessJobLegalDetailEntity)))
                return (MasterMapper.GetMBusinessJobLegalDetail(masterEntity as MBusinessJobLegalDetailEntity));

            else if (masterEntity.GetType().Equals(typeof(RMHearingRoutingSectionConfigEntity)))
                return (MasterMapper.GetRMHearingRoutingSectionConfig(masterEntity as RMHearingRoutingSectionConfigEntity));

            else if (masterEntity.GetType().Equals(typeof(MPaperMinuteSheetTypeEntity)))
                return (MasterMapper.GetMPaperMinuteSheetType(masterEntity as MPaperMinuteSheetTypeEntity));

            else if (masterEntity.GetType().Equals(typeof(RMHRGTypePaperMinuteSheetTypeEntity)))
                return (MasterMapper.GetRMHRGTypePaperMinuteSheetType(masterEntity as RMHRGTypePaperMinuteSheetTypeEntity));

            else if (masterEntity.GetType().Equals(typeof(MCourtVacationEntity)))
                return (MasterMapper.GetMCourtVacation(masterEntity as MCourtVacationEntity));

            else if (masterEntity.GetType().Equals(typeof(MPrisonEntity)))
                return (MasterMapper.GetMPrison(masterEntity as MPrisonEntity));

            else if (masterEntity.GetType().Equals(typeof(MEMSRecTransModeEntity)))
                return (MasterMapper.GetMEMSRecTransMode(masterEntity as MEMSRecTransModeEntity));

            else if (masterEntity.GetType().Equals(typeof(MEMSSalesAgentEntity)))
                return (MasterMapper.GetMEMSSalesAgent(masterEntity as MEMSSalesAgentEntity));

            else if (masterEntity.GetType().Equals(typeof(RMHrgSlotNOCEntity)))
                return (MasterMapper.GetRMHrgSlotNOC(masterEntity as RMHrgSlotNOCEntity));

            else if (masterEntity.GetType().Equals(typeof(RMHrgSlotLegisEntity)))
                return (MasterMapper.GetRMHrgSlotLegis(masterEntity as RMHrgSlotLegisEntity));

            else if (masterEntity.GetType().Equals(typeof(RMDocControlExclusionEntity)))
                return (MasterMapper.GetRMDocControlExclusion(masterEntity as RMDocControlExclusionEntity));

            else if (masterEntity.GetType().Equals(typeof(MResidentialEntity)))
                return MasterMapper.GetMResidential(masterEntity as MResidentialEntity);

            else if (masterEntity.GetType().Equals(typeof(MIncomeEntity)))
                return MasterMapper.GetMIncome(masterEntity as MIncomeEntity);

            else if (masterEntity.GetType().Equals(typeof(MDirectionsEntity)))
                return MasterMapper.GetMDirections(masterEntity as MDirectionsEntity);

            else if (masterEntity.GetType().Equals(typeof(MHarassPlaceEntity)))
                return MasterMapper.GetMHarassPlace(masterEntity as MHarassPlaceEntity);

            else

                throw new MissingMethodException("This Master Entity is not Implemented");
        }

        /// <summary>
        /// Gets the RM forum coram DSG.
        /// </summary>
        /// <param name="rMForumCoramDSGEntity">The r M forum coram DSG entity.</param>
        /// <returns></returns>
        private static RMForumCoramDSG GetRMForumCoramDSG(RMForumCoramDSGEntity rMForumCoramDSGEntity)
        {
            RMForumCoramDSG rMForumCoramDSG = null;

            try
            {
                rMForumCoramDSG = Mapper.Map<RMForumCoramDSGEntity, RMForumCoramDSG>(rMForumCoramDSGEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMForumCoramDSG", ex);
                throw;
            }

            return rMForumCoramDSG;
        }

        /**Criminal Master Tables**/
        /// <summary>
        /// Gets the <see cref="MBailType"/> from <see cref="MBailTypeEntity"/> input.
        /// </summary>
        /// <param name="mBailTypeEntity"><see cref="MBailTypeEntity"/></param>
        /// <returns>Returns <see cref="MBailType"/>, else null.</returns>
        public static MBailType GetMBailType(MBailTypeEntity mBailTypeEntity)
        {
            MBailType mBailType = null;

            try
            {
                mBailType = Mapper.Map<MBailTypeEntity, MBailType>(mBailTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMBailType", ex);
                throw;
            }

            return mBailType;
        }

        public static MBasisForTaxation GetMBasisForTaxation(MBasisForTaxationEntity mBasisForTaxationEntity)
        {
            MBasisForTaxation mBasisForTaxation = null;

            try
            {
                mBasisForTaxation = Mapper.Map<MBasisForTaxationEntity, MBasisForTaxation>(mBasisForTaxationEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetMBasisForTaxation", ex);
                throw;
            }

            return mBasisForTaxation;
        }

        public static MBasisOfTaxationType GetMBasisOfTaxationType(MBasisOfTaxationTypeEntity mBasisOfTaxationTypeEntity)
        {
            MBasisOfTaxationType mBasisOfTaxationType = null;

            try
            {
                mBasisOfTaxationType = Mapper.Map<MBasisOfTaxationTypeEntity, MBasisOfTaxationType>(mBasisOfTaxationTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMBasisOfTaxationType", ex);
                throw;
            }

            return mBasisOfTaxationType;
        }

        public static MBillNature GetMBasisOfTaxationType(MBillNatureEntity mBillNatureEntity)
        {
            MBillNature mBillNature = null;

            try
            {
                mBillNature = Mapper.Map<MBillNatureEntity, MBillNature>(mBillNatureEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMBasisOfTaxationType", ex);
                throw;
            }

            return mBillNature;
        }

        public static MBillType GetMBillType(MBillTypeEntity mBillTypeEntity)
        {
            MBillType mBillType = null;

            try
            {
                mBillType = Mapper.Map<MBillTypeEntity, MBillType>(mBillTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMBillType", ex);
                throw;
            }

            return mBillType;
        }

        /// <summary>
        /// Gets the <see cref="MCaseIssue"/> from <see cref="CaseIssueEntity"/> input.
        /// </summary>
        /// <param name="mCaseIssueDomainEntity"><see cref="MCaseIssueEntity"/></param>
        /// <returns>Returns <see cref="MCaseIssue"/>, else null.</returns>
        public static MCaseIssue GetMCaseIssue(MCaseIssueEntity mCaseIssueDomainEntity)
        {
            MCaseIssue mCaseIssueNHibernateEntity = null;

            try
            {
                mCaseIssueNHibernateEntity = Mapper.Map<MCaseIssueEntity, MCaseIssue>(mCaseIssueDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCaseIssue", ex);
                throw;
            }

            return mCaseIssueNHibernateEntity;
        }

        public static MCaseSecurity GetMCaseSecurity(MCaseSecurityEntity mCaseSecurityEntity)
        {
            MCaseSecurity mCaseSecurity = null;

            try
            {
                mCaseSecurity = Mapper.Map<MCaseSecurityEntity, MCaseSecurity>(mCaseSecurityEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMCaseSecurity", ex);
                throw;
            }

            return mCaseSecurity;
        }

        public static MCaseStatus GetMCaseStatus(MCaseStatusEntity mCaseStatusEntity)
        {
            MCaseStatus mCaseStatus = null;

            try
            {
                mCaseStatus = Mapper.Map<MCaseStatusEntity, MCaseStatus>(mCaseStatusEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMCaseStatus", ex);
                throw;
            }

            return mCaseStatus;
        }

        public static MCaseType GetMCaseType(MCaseTypeEntity mCaseTypeEntity)
        {
            MCaseType mCaseType = null;

            try
            {
                mCaseType = Mapper.Map<MCaseTypeEntity, MCaseType>(mCaseTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMCaseType", ex);
                throw;
            }

            return mCaseType;
        }

        public static MCaseTypeGroup GetMCaseTypeGroup(MCaseTypeGroupEntity mCaseTypeGroupEntity)
        {
            MCaseTypeGroup mCaseTypeGroup = null;

            try
            {
                mCaseTypeGroup = Mapper.Map<MCaseTypeGroupEntity, MCaseTypeGroup>(mCaseTypeGroupEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMCaseTypeGroup", ex);
                throw;
            }

            return mCaseTypeGroup;
        }

        /// <summary>
        /// Gets the <see cref="MChargeType"/> from <see cref="MChargeTypeEntity"/> input.
        /// </summary>
        /// <param name="mChargeTypeEntity"><see cref="MChargeTypeEntity"/></param>
        /// <returns>Returns <see cref="MChargeType"/>, else null.</returns>
        public static MChargeType GetMChargeType(MChargeTypeEntity mChargeTypeEntity)
        {
            MChargeType mChargeType = null;

            try
            {
                mChargeType = Mapper.Map<MChargeTypeEntity, MChargeType>(mChargeTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMChargeType", ex);
                throw;
            }

            return mChargeType;
        }

        public static MChecklist GetMChecklist(MChecklistEntity mChecklistEntity)
        {
            MChecklist mChecklist = null;

            try
            {
                mChecklist = Mapper.Map<MChecklistEntity, MChecklist>(mChecklistEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMChecklist", ex);
                throw;
            }

            return mChecklist;
        }

        public static MChecklistDocument GetMChecklistDocument(MChecklistDocumentEntity mChecklistDocumentEntity)
        {
            MChecklistDocument mChecklistDocument = null;

            try
            {
                mChecklistDocument = Mapper.Map<MChecklistDocumentEntity, MChecklistDocument>(mChecklistDocumentEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMChecklistDocument", ex);
                throw;
            }

            return mChecklistDocument;
        }

        public static MClaimType GetMClaimType(MClaimTypeEntity mClaimTypeEntity)
        {
            MClaimType mClaimType = null;

            try
            {
                mClaimType = Mapper.Map<MClaimTypeEntity, MClaimType>(mClaimTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMClaimType", ex);
                throw;
            }

            return mClaimType;
        }

        /// <summary>
        /// Gets the <see cref="MCoram"/> from <see cref="MCoramEntity"/> input.
        /// </summary>
        /// <param name="mCoramEntity"><see cref="mCoramEntity"/></param>
        /// <returns>Returns <see cref="MCoram"/>, else null.</returns>
        public static MCoram GetMCoram(MCoramEntity mCoramEntity)
        {
            MCoram mCoram = null;

            try
            {
                mCoram = Mapper.Map<MCoramEntity, MCoram>(mCoramEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCoram", ex);
                throw;
            }

            return mCoram;
        }

        public static MCountry GetMCountry(MCountryEntity mCountryEntity)
        {
            MCountry mCountry = null;

            try
            {
                mCountry = Mapper.Map<MCountryEntity, MCountry>(mCountryEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMCountry", ex);
                throw;
            }

            return mCountry;
        }

        public static MCourtType GetMCourtType(MCourtTypeEntity mCourtTypeEntity)
        {
            MCourtType mCourtType = null;

            try
            {
                mCourtType = Mapper.Map<MCourtTypeEntity, MCourtType>(mCourtTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMCourtType", ex);
                throw;
            }

            return mCourtType;
        }

        /// <summary>
        /// Gets the <see cref="MCriminalClaimantType"/> from <see cref="MCriminalClaimantTypeEntity"/> input.
        /// </summary>
        /// <param name="mCriminalClaimantTypeEntity"><see cref="MCriminalClaimantTypeEntity"/></param>
        /// <returns>Returns <see cref="MCriminalClaimantType"/>, else null.</returns>
        public static MCriminalClaimantType GetMCriminalClaimantType(MCriminalClaimantTypeEntity mCriminalClaimantTypeEntity)
        {
            MCriminalClaimantType mCriminalClaimantType = null;

            try
            {
                mCriminalClaimantType = Mapper.Map<MCriminalClaimantTypeEntity, MCriminalClaimantType>(mCriminalClaimantTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCriminalClaimantType", ex);
                throw;
            }

            return mCriminalClaimantType;
        }

        /// <summary>
        /// Gets the <see cref="MCriminalClaimType"/> from <see cref="MCriminalClaimTypeEntity"/> input.
        /// </summary>
        /// <param name="mCriminalClaimTypeEntity"><see cref="MCriminalClaimTypeEntity"/></param>
        /// <returns>Returns <see cref="MCriminalClaimType"/>, else null.</returns>
        public static MCriminalClaimType GetMCriminalClaimType(MCriminalClaimTypeEntity mCriminalClaimTypeEntity)
        {
            MCriminalClaimType mCriminalClaimType = null;

            try
            {
                mCriminalClaimType = Mapper.Map<MCriminalClaimTypeEntity, MCriminalClaimType>(mCriminalClaimTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCriminalClaimType", ex);
                throw;
            }

            return mCriminalClaimType;
        }

        /// <summary>
        /// Gets the <see cref="MCriminalOrder"/> from <see cref="MCriminalOrderEntity"/> input.
        /// </summary>
        /// <param name="mCriminalOrderEntity"><see cref="MCriminalOrderEntity"/></param>
        /// <returns>Returns <see cref="MCriminalOrder"/>, else null.</returns>
        public static MCriminalOrder GetMCriminalOrder(MCriminalOrderEntity mCriminalOrderEntity)
        {
            MCriminalOrder mCriminalOrder = null;

            try
            {
                mCriminalOrder = Mapper.Map<MCriminalOrderEntity, MCriminalOrder>(mCriminalOrderEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMCriminalOrderEntity", ex);
                throw;
            }

            return mCriminalOrder;
        }

        public static MCurrency GetMCurrency(MCurrencyEntity mCurrencyEntity)
        {
            MCurrency mCurrency = null;

            try
            {
                mCurrency = Mapper.Map<MCurrencyEntity, MCurrency>(mCurrencyEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetMCurrency", ex);
                throw;
            }

            return mCurrency;
        }

        public static MDamage GetMDamage(MDamageEntity mDamageEntity)
        {
            MDamage mDamage = null;

            try
            {
                mDamage = Mapper.Map<MDamageEntity, MDamage>(mDamageEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMDamage", ex);
                throw;
            }

            return mDamage;
        }

        public static MDeedType GetMDeedType(MDeedTypeEntity mDeedTypeEntity)
        {
            MDeedType mDeedType = null;

            try
            {
                mDeedType = Mapper.Map<MDeedTypeEntity, MDeedType>(mDeedTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMDeedType", ex);
                throw;
            }

            return mDeedType;
        }

        public static MDesignation GetMDesignation(MDesignationEntity mDesignationEntity)
        {
            MDesignation mDesignation = null;

            try
            {
                mDesignation = Mapper.Map<MDesignationEntity, MDesignation>(mDesignationEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMDesignation", ex);
                throw;
            }

            return mDesignation;
        }

        public static MDialect GetMDialect(MDialectEntity mDialectEntity)
        {
            MDialect mDialect = null;

            try
            {
                mDialect = Mapper.Map<MDialectEntity, MDialect>(mDialectEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMDialect", ex);
                throw;
            }

            return mDialect;
        }

        /// <summary>
        /// Gets the <see cref="MDocCategory"/> from <see cref="MDocCategoryEntity"/> input.
        /// </summary>
        /// <param name="mDocCategoryEntity"><see cref="MDocCategoryEntity"/></param>
        /// <returns>Returns <see cref="MDocCategory"/>, else null.</returns>
        public static MDocCategory GetMDocCategory(MDocCategoryEntity mDocCategoryEntity)
        {
            MDocCategory mDocCategory = null;

            try
            {
                mDocCategory = Mapper.Map<MDocCategoryEntity, MDocCategory>(mDocCategoryEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDocCategory", ex);
                throw;
            }

            return mDocCategory;
        }

        public static MDocCode GetMDocCode(MDocCodeEntity mDocCodeEntity)
        {
            MDocCode MDocCode = null;

            try
            {
                MDocCode = Mapper.Map<MDocCodeEntity, MDocCode>(mDocCodeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMDocSecurity", ex);
                throw;
            }

            return MDocCode;
        }

        public static MDocLegislation GetMDocLegislation(MDocLegislationEntity mDocLegislationEntity)
        {
            MDocLegislation mDocLegislation = null;

            try
            {
                //masterMapping.MasterEntityToMasterMapping();
                mDocLegislation = Mapper.Map<MDocLegislationEntity, MDocLegislation>(mDocLegislationEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMDocLegislation", ex);
                throw;
            }

            return mDocLegislation;
        }

        public static MDocNature GetMDocNature(MDocNatureEntity mDocNatureEntity)
        {
            MDocNature mDocNature = null;

            try
            {
                mDocNature = Mapper.Map<MDocNatureEntity, MDocNature>(mDocNatureEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMDocNature", ex);
                throw;
            }

            return mDocNature;
        }

        public static MDocSecurity GetMDocSecurity(MDocSecurityEntity mDocSecurityEntity)
        {
            MDocSecurity mDocSecurity = null;

            try
            {
                mDocSecurity = Mapper.Map<MDocSecurityEntity, MDocSecurity>(mDocSecurityEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMDocSecurity", ex);
                throw;
            }

            return mDocSecurity;
        }

        public static MDocStatus GetMDocStatus(MDocStatusEntity mDocStatusEntity)
        {
            MDocStatus mDocStatus = null;

            try
            {
                mDocStatus = Mapper.Map<MDocStatusEntity, MDocStatus>(mDocStatusEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMDocStatus", ex);
                throw;
            }

            return mDocStatus;
        }

        /// <summary>
        /// Gets the <see cref="MDrivingLicense"/> from <see cref="MDrivingLicenseEntity"/> input.
        /// </summary>
        /// <param name="mDrivingLicenseEntity"><see cref="MDrivingLicenseEntity"/></param>
        /// <returns>Returns <see cref="MDrivingLicense"/>, else null.</returns>
        public static MDrivingLicense GetMDrivingLicense(MDrivingLicenseEntity mDrivingLicenseEntity)
        {
            MDrivingLicense mDrivingLicense = null;

            try
            {
                mDrivingLicense = Mapper.Map<MDrivingLicenseEntity, MDrivingLicense>(mDrivingLicenseEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDrivingLicense", ex);
                throw;
            }

            return mDrivingLicense;
        }

        /// <summary>
        /// Gets the <see cref="MDrug"/> from <see cref="MDrugEntity"/> input.
        /// </summary>
        /// <param name="mDrugEntity"><see cref="MDrugEntity"/></param>
        /// <returns>Returns <see cref="MDrug"/>, else null.</returns>
        public static MDrug GetMDrug(MDrugEntity mDrugEntity)
        {
            MDrug mDrug = null;

            try
            {
                mDrug = Mapper.Map<MDrugEntity, MDrug>(mDrugEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDrug", ex);
                throw;
            }

            return mDrug;
        }

        /// <summary>
        /// Get the MEMSAdvertIn.
        /// </summary>
        /// <param name="mEMSAdvertInDomainEntity"></param>
        /// <returns></returns>
        public static MEMSAdvertIn GetMEMSAdvertIn(MEMSAdvertInEntity mEMSAdvertInDomainEntity)
        {
            MEMSAdvertIn mEMSAdvertInNHibernateEntity = null;

            try
            {
                mEMSAdvertInNHibernateEntity = Mapper.Map<MEMSAdvertInEntity, MEMSAdvertIn>(mEMSAdvertInDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSAdvertIn", ex);
                throw;
            }

            return mEMSAdvertInNHibernateEntity;
        }

        /// <summary>
        /// Get the MEMSAdvertiser.
        /// </summary>
        /// <param name="mEMSAdvertiserDomainEntity"></param>
        /// <returns></returns>
        public static MEMSAdvertiser GetMEMSAdvertiser(MEMSAdvertiserEntity mEMSAdvertiserDomainEntity)
        {
            MEMSAdvertiser mEMSAdvertiserNHibernateEntity = null;

            try
            {
                mEMSAdvertiserNHibernateEntity = Mapper.Map<MEMSAdvertiserEntity, MEMSAdvertiser>(mEMSAdvertiserDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSAdvertiser", ex);
                throw;
            }

            return mEMSAdvertiserNHibernateEntity;
        }

        /// <summary>
        /// Get the MEMSAppraiser.
        /// </summary>
        /// <param name="mEMSAppraiserDomainEntity"></param>
        /// <returns></returns>
        public static MEMSAppraiser GetMEMSAppraiser(MEMSAppraiserEntity mEMSAppraiserDomainEntity)
        {
            MEMSAppraiser mEMSAppraiserNHibernateEntity = null;

            try
            {
                mEMSAppraiserNHibernateEntity = Mapper.Map<MEMSAppraiserEntity, MEMSAppraiser>(mEMSAppraiserDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSAppraiser", ex);
                throw;
            }

            return mEMSAppraiserNHibernateEntity;
        }

        /// <summary>
        /// Get the MEMSApptOutcome.
        /// </summary>
        /// <param name="mEMSApptOutcomeDomainEntity"></param>
        /// <returns></returns>
        public static MEMSApptOutcome GetMEMSApptOutcome(MEMSApptOutcomeEntity mEMSApptOutcomeDomainEntity)
        {
            MEMSApptOutcome mEMSApptOutcomeNHibernateEntity = null;

            try
            {
                mEMSApptOutcomeNHibernateEntity = Mapper.Map<MEMSApptOutcomeEntity, MEMSApptOutcome>(mEMSApptOutcomeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSApptOutcome", ex);
                throw;
            }

            return mEMSApptOutcomeNHibernateEntity;
        }

        /// <summary>
        /// Get the MEMSApptReason.
        /// </summary>
        /// <param name="mEMSApptReasonDomainEntity"></param>
        /// <returns></returns>
        public static MEMSApptReason GetMEMSApptReason(MEMSApptReasonEntity mEMSApptReasonDomainEntity)
        {
            MEMSApptReason mEMSApptReasonNHibernateEntity = null;

            try
            {
                mEMSApptReasonNHibernateEntity = Mapper.Map<MEMSApptReasonEntity, MEMSApptReason>(mEMSApptReasonDomainEntity);
                mEMSApptReasonNHibernateEntity.MEMSApptOutcome = Mapper.Map<MEMSApptOutcomeEntity, MEMSApptOutcome>(mEMSApptReasonDomainEntity.MEMSApptOutcome);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetMEMSApptReason", ex);
                throw;
            }

            return mEMSApptReasonNHibernateEntity;
        }

        /// <summary>
        /// Get the MEMSApptType.
        /// </summary>
        /// <param name="mEMSApptTypeDomainEntity"></param>
        /// <returns></returns>
        public static MEMSApptType GetMEMSApptType(MEMSApptTypeEntity mEMSApptTypeDomainEntity)
        {
            MEMSApptType mEMSApptTypeNHibernateEntity = null;

            try
            {
                mEMSApptTypeNHibernateEntity = Mapper.Map<MEMSApptTypeEntity, MEMSApptType>(mEMSApptTypeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetMEMSApptType", ex);
                throw;
            }
            return mEMSApptTypeNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MEMSAttendanceFee"/> from <see cref="MEMSAttendanceFeeEntity"/> input.
        /// </summary>
        /// <param name="mEMSAttendanceFeeDomainEntity"><see cref="MEMSAttendanceFeeEntity"/></param>
        /// <returns>Returns <see cref="MEMSAttendanceFee"/>, else null.</returns>
        public static MEMSAttendanceFee GetMEMSAttendanceFee(MEMSAttendanceFeeEntity mEMSAttendanceFeeDomainEntity)
        {
            MEMSAttendanceFee mEMSAttendanceFeeNHibernateEntity = null;

            try
            {
                mEMSAttendanceFeeNHibernateEntity = Mapper.Map<MEMSAttendanceFeeEntity, MEMSAttendanceFee>(mEMSAttendanceFeeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMEMSAttendanceFee", ex);
                throw;
            }

            return mEMSAttendanceFeeNHibernateEntity;
        }

        /// <summary>
        /// Get the MEMSAuctioneer.
        /// </summary>
        /// <param name="mEMSAuctioneerDomainEntity"></param>
        /// <returns></returns>
        public static MEMSAuctioneer GetMEMSAuctioneer(MEMSAuctioneerEntity mEMSAuctioneerDomainEntity)
        {
            MEMSAuctioneer mEMSAuctioneerNHibernateEntity = null;

            try
            {
                mEMSAuctioneerNHibernateEntity = Mapper.Map<MEMSAuctioneerEntity, MEMSAuctioneer>(mEMSAuctioneerDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetMEMSAuctioneer", ex);
                throw;
            }
            return mEMSAuctioneerNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MEMSCourtComm"/> from <see cref="MEMSCourtCommEntity"/> input.
        /// </summary>
        /// <param name="mEMSCourtCommDomainEntity"><see cref="MEMSCourtCommEntity"/></param>
        /// <returns>Returns <see cref="MEMSCourtComm"/>, else null.</returns>
        public static MEMSCourtComm GetMEMSCourtComm(MEMSCourtCommEntity mEMSCourtCommDomainEntity)
        {
            MEMSCourtComm mEMSCourtCommNHibernateEntity = null;

            try
            {
                mEMSCourtCommNHibernateEntity = Mapper.Map<MEMSCourtCommEntity, MEMSCourtComm>(mEMSCourtCommDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMEMSCourtComm", ex);
                throw;
            }

            return mEMSCourtCommNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MEMSDisburseRate"/> from <see cref="MEMSDisburseRateEntity"/> input.
        /// </summary>
        /// <param name="mEMSDisburseRateDomainEntity"><see cref="MEMSDisburseRateEntity"/></param>
        /// <returns>Returns <see cref="MEMSDisburseRate"/>, else null.</returns>
        public static MEMSDisburseRate GetMEMSDisburseRate(MEMSDisburseRateEntity mEMSDisburseRateDomainEntity)
        {
            MEMSDisburseRate mEMSDisburseRateNHibernateEntity = null;

            try
            {
                mEMSDisburseRateNHibernateEntity = Mapper.Map<MEMSDisburseRateEntity, MEMSDisburseRate>(mEMSDisburseRateDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMEMSDisburseRate", ex);
                throw;
            }

            return mEMSDisburseRateNHibernateEntity;
        }

        /// <summary>
        /// Get the MEMSFileMoveDesc.
        /// </summary>
        /// <param name="mEMSFileMoveDescDomainEntity"></param>
        /// <returns></returns>
        public static MEMSFileMoveDesc GetMEMSFileMoveDesc(MEMSFileMoveDescEntity mEMSFileMoveDescDomainEntity)
        {
            MEMSFileMoveDesc mEMSFileMoveDescNHibernateEntity = null;

            try
            {
                mEMSFileMoveDescNHibernateEntity = Mapper.Map<MEMSFileMoveDescEntity, MEMSFileMoveDesc>(mEMSFileMoveDescDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSFileMoveDesc", ex);
                throw;
            }
            return mEMSFileMoveDescNHibernateEntity;
        }

        public static MEMSLedger GetMEMSLedger(MEMSLedgerEntity mEMSLedgerEntity)
        {
            MEMSLedger mEMSLedger = null;

            try
            {
                mEMSLedger = Mapper.Map<MEMSLedgerEntity, MEMSLedger>(mEMSLedgerEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSLedger", ex);
                throw;
            }

            return mEMSLedger;
        }

        /// <summary>
        /// Get the MEMSNatureOfPayment.
        /// </summary>
        /// <NatureOfPayment name="mEMSNatureOfPaymentDomainEntity"></NatureOfPayment>
        /// <returns></returns>
        public static MEMSNatureOfPayment GetMEMSNatureOfPayment(MEMSNatureOfPaymentEntity mEMSNatureOfPaymentDomainEntity)
        {
            MEMSNatureOfPayment mEMSNatureOfPaymentNHibernateEntity = null;

            try
            {
                mEMSNatureOfPaymentNHibernateEntity = Mapper.Map<MEMSNatureOfPaymentEntity, MEMSNatureOfPayment>(mEMSNatureOfPaymentDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetMEMSNatureOfPayment", ex);
                throw;
            }
            return mEMSNatureOfPaymentNHibernateEntity;
        }

        /// <summary>
        /// Get the MEMSParam.
        /// </summary>
        /// <param name="mEMSParamDomainEntity"></param>
        /// <returns></returns>
        public static MEMSParam GetMEMSParam(MEMSParamEntity mEMSParamDomainEntity)
        {
            MEMSParam mEMSParamNHibernateEntity = null;

            try
            {
                mEMSParamNHibernateEntity = Mapper.Map<MEMSParamEntity, MEMSParam>(mEMSParamDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetMEMSParam", ex);
                throw;
            }
            return mEMSParamNHibernateEntity;
        }

        /// <summary>
        /// Get the MEMSSalesAgent.
        /// </summary>
        /// <param name="mEMSSalesAgentDomainEntity"></param>
        /// <returns></returns>
        public static MEMSSalesAgent GetMEMSSalesAgent(MEMSSalesAgentEntity mEMSSalesAgentDomainEntity)
        {
            MEMSSalesAgent mEMSSalesAgentNHibernateEntity = null;

            try
            {
                mEMSSalesAgentNHibernateEntity = Mapper.Map<MEMSSalesAgentEntity, MEMSSalesAgent>(mEMSSalesAgentDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetMEMSSalesAgent", ex);
                throw;
            }
            return mEMSSalesAgentNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MEMSSecurityGuard"/> from <see cref="MEMSSecurityGuardEntity"/> input.
        /// </summary>
        /// <param name="mEMSSecurityGuardEntity"><see cref="MEMSSecurityGuardEntity"/></param>
        /// <returns>Returns <see cref="MEMSSecurityGuard"/>, else null.</returns>
        public static MEMSSecurityGuard GetMEMSSecurityGuard(MEMSSecurityGuardEntity mEMSSecurityGuardEntity)
        {
            MEMSSecurityGuard mEMSSecurityGuard = null;

            try
            {
                mEMSSecurityGuard = Mapper.Map<MEMSSecurityGuardEntity, MEMSSecurityGuard>(mEMSSecurityGuardEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMEMSSecurityGuard", ex);
                throw;
            }

            return mEMSSecurityGuard;
        }

        /// <summary>
        /// Gets the <see cref="MEMSWritAppt"/> from <see cref="MEMSWritApptEntity"/> input.
        /// </summary>
        /// <param name="mEMSWritApptDomainEntity"><see cref="MEMSWritApptEntity"/></param>
        /// <returns>Returns <see cref="MEMSWritAppt"/>, else null.</returns>
        public static MEMSWritAppt GetMEMSWritAppt(MEMSWritApptEntity mEMSWritApptDomainEntity)
        {
            MEMSWritAppt mEMSWritApptNHibernateEntity = null;

            try
            {
                mEMSWritApptNHibernateEntity = Mapper.Map<MEMSWritApptEntity, MEMSWritAppt>(mEMSWritApptDomainEntity);
                mEMSWritApptNHibernateEntity.MCaseType = Mapper.Map<MCaseTypeEntity, MCaseType>(mEMSWritApptDomainEntity.MCaseType);
                mEMSWritApptNHibernateEntity.MEMSApptType = Mapper.Map<MEMSApptTypeEntity, MEMSApptType>(mEMSWritApptDomainEntity.MEMSApptType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMEMSWritAppt", ex);
                throw;
            }

            return mEMSWritApptNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MExternalAgency"/> from <see cref="MExternalAgencyEntity"/> input.
        /// </summary>
        /// <param name="mExternalAgencyEntity"><see cref="MExternalAgencyEntity"/></param>
        /// <returns>Returns <see cref="MExternalAgency"/>, else null.</returns>
        public static MExternalAgency GetMExternalAgency(MExternalAgencyEntity mExternalAgencyEntity)
        {
            MExternalAgency mExternalAgency = null;

            try
            {
                mExternalAgency = Mapper.Map<MExternalAgencyEntity, MExternalAgency>(mExternalAgencyEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMExternalAgency", ex);
                throw;
            }

            return mExternalAgency;
        }

        /// <summary>
        /// Gets the <see cref="MExternalAgencyAddress"/> from <see cref="MExternalAgencyAddressEntity"/> input.
        /// </summary>
        /// <param name="mExternalAgencyAddressEntity"><see cref="MExternalAgencyAddressEntity"/></param>
        /// <returns>Returns <see cref="MExternalAgencyAddress"/>, else null.</returns>
        public static MExternalAgencyAddress GetMExternalAgencyAddress(MExternalAgencyAddressEntity mExternalAgencyAddressEntity)
        {
            MExternalAgencyAddress mExternalAgencyAddress = null;

            try
            {
                mExternalAgencyAddress = Mapper.Map<MExternalAgencyAddressEntity, MExternalAgencyAddress>(mExternalAgencyAddressEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMExternalAgencyAddress", ex);
                throw;
            }

            return mExternalAgencyAddress;
        }

        public static MFilterGroup GetMFilterGroup(MFilterGroupEntity mFilterGroupEntity)
        {
            MFilterGroup mFilterGroup = null;

            try
            {
                mFilterGroup = Mapper.Map<MFilterGroupEntity, MFilterGroup>(mFilterGroupEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMFilterGroup", ex);
                throw;
            }

            return mFilterGroup;
        }

        /// <summary>
        /// Gets the <see cref="MFormSignature"/> from <see cref="MFormSignatureEntity"/> input.
        /// </summary>
        /// <param name="MFormSignatureEntity"><see cref="MFormSignatureEntity"/></param>
        /// <returns>Returns <see cref="MFormSignature"/>, else null.</returns>
        public static MFormSignature GetMFormSignature(MFormSignatureEntity mFormSignatureEntity)
        {
            MFormSignature mFormSignature = null;

            try
            {
                mFormSignature = Mapper.Map<MFormSignatureEntity, MFormSignature>(mFormSignatureEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMFormSignature", ex);
                throw;
            }

            return mFormSignature;
        }

        /// <summary>
        /// Gets the <see cref="MFormTemplateLocation"/> from <see cref="MFormTemplateLocationEntity"/> input.
        /// </summary>
        /// <param name="MFormTemplateLocationEntity"><see cref="MFormTemplateLocationEntity"/></param>
        /// <returns>Returns <see cref="MFormTemplateLocation"/>, else null.</returns>
        public static MFormTemplateLocation GetMFormTemplateLocation(MFormTemplateLocationEntity mFormTemplateLocationEntity)
        {
            MFormTemplateLocation mFormTemplateLocation = null;

            try
            {
                mFormTemplateLocation = Mapper.Map<MFormTemplateLocationEntity, MFormTemplateLocation>(mFormTemplateLocationEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMFormTemplateLocation", ex);
                throw;
            }

            return mFormTemplateLocation;
        }

        public static MForumType GetMForumType(MForumTypeEntity mForumTypeEntity)
        {
            MForumType mForumType = null;

            try
            {
                mForumType = Mapper.Map<MForumTypeEntity, MForumType>(mForumTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMForumType", ex);
                throw;
            }

            return mForumType;
        }

        public static MFunctions GetMFunctions(MFunctionsEntity mFunctionsEntity)
        {
            MFunctions mFunctions = null;

            try
            {
                mFunctions = Mapper.Map<MFunctionsEntity, MFunctions>(mFunctionsEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetMFunctions", ex);
                throw;
            }

            return mFunctions;
        }

        public static MGender GetMGender(MGenderEntity mGenderEntity)
        {
            MGender mGender = null;

            try
            {
                mGender = Mapper.Map<MGenderEntity, MGender>(mGenderEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMGender", ex);
                throw;
            }

            return mGender;
        }

        /// <summary>
        /// Gets the <see cref="MHoliday"/> from <see cref="MHolidayEntity"/> input.
        /// </summary>
        /// <param name="MHolidayEntity"><see cref="MHolidayEntity"/></param>
        /// <returns>Returns <see cref="MHoliday"/>, else null.</returns>
        public static MHoliday GetMHoliday(MHolidayEntity mHolidayEntity)
        {
            MHoliday mHoliday = null;

            try
            {
                mHoliday = Mapper.Map<MHolidayEntity, MHoliday>(mHolidayEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMHoliday", ex);
                throw;
            }

            return mHoliday;
        }

        /// <summary>
        /// Get the MHRGOutCome.
        /// </summary>
        /// <param name="mHRGOutComeDomainEntity"></param>
        /// <returns></returns>
        public static MHRGOutCome GetMHRGOutComeEntity(MHRGOutComeEntity mHRGOutComeDomainEntity)
        {
            MHRGOutCome mHRGOutComeNHibernateEntity = null;

            try
            {
                mHRGOutComeNHibernateEntity = Mapper.Map<MHRGOutComeEntity, MHRGOutCome>(mHRGOutComeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encounterd at GetMHRGOutComeEntity", ex);
                throw;
            }

            return mHRGOutComeNHibernateEntity;
        }

        /// <summary>
        /// Get the MHRGOutComeReason.
        /// </summary>
        /// <param name="mHRGOutComeReasonDomainEntity"></param>
        /// <returns></returns>
        public static MHRGOutComeReason GetMHRGOutComeReasonEntity(MHRGOutComeReasonEntity mHRGOutComeReasonDomainEntity)
        {
            MHRGOutComeReason mHRGOutComeReasonNHibernateEntity = null;

            try
            {
                mHRGOutComeReasonNHibernateEntity = Mapper.Map<MHRGOutComeReasonEntity, MHRGOutComeReason>(mHRGOutComeReasonDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHRGOutComeReasonEntity", ex);
                throw;
            }

            return mHRGOutComeReasonNHibernateEntity;
        }

        /// <summary>
        /// Get the MHRGRoom.
        /// </summary>
        /// <param name="mHRGRoomDomainEntity"></param>
        /// <returns></returns>
        public static MHRGRoom GetMHRGRoomEntity(MHRGRoomEntity mHRGRoomDomainEntity)
        {
            MHRGRoom mHRGRoomNHibernateEntity = null;

            try
            {
                mHRGRoomNHibernateEntity = Mapper.Map<MHRGRoomEntity, MHRGRoom>(mHRGRoomDomainEntity);
                mHRGRoomNHibernateEntity.MCourtType = Mapper.Map<MCourtTypeEntity, MCourtType>(mHRGRoomDomainEntity.MCourtType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHRGRoomEntity", ex);
                throw;
            }

            return mHRGRoomNHibernateEntity;
        }

        /// <summary>
        /// Get the MHRGRoomType.
        /// </summary>
        /// <param name="mHRGRoomTypeDomainEntity"></param>
        /// <returns></returns>
        public static MHRGRoomType GetMHRGRoomTypeEntity(MHRGRoomTypeEntity mHRGRoomTypeDomainEntity)
        {
            MHRGRoomType mHRGRoomTypeNHibernateEntity = null;

            try
            {
                mHRGRoomTypeNHibernateEntity = Mapper.Map<MHRGRoomTypeEntity, MHRGRoomType>(mHRGRoomTypeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHRGRoomTypeEntity", ex);
                throw;
            }

            return mHRGRoomTypeNHibernateEntity;
        }

        /// <summary>
        /// Get the MHRGSlot.
        /// </summary>
        /// <param name="mHRGSlotDomainEntity"></param>
        /// <returns></returns>
        public static MHRGSlot GetMHRGSlotEntity(MHRGSlotEntity mHRGSlotDomainEntity)
        {
            MHRGSlot mHRGSlotNHibernateEntity = null;

            try
            {
                mHRGSlotNHibernateEntity = Mapper.Map<MHRGSlotEntity, MHRGSlot>(mHRGSlotDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHRGSlotEntity", ex);
                throw;
            }

            return mHRGSlotNHibernateEntity;
        }

        /// <summary>
        /// Get the MHRGTimeLine.
        /// </summary>
        /// <param name="mHRGTimeLineDomainEntity"></param>
        /// <returns></returns>
        public static MHRGTimeLine GetMHRGTimeLineEntity(MHRGTimeLineEntity mHRGTimeLineDomainEntity)
        {
            MHRGTimeLine mHRGTimeLineNHibernateEntity = null;

            try
            {
                mHRGTimeLineNHibernateEntity = Mapper.Map<MHRGTimeLineEntity, MHRGTimeLine>(mHRGTimeLineDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHRGTimeLineEntity", ex);
                throw;
            }

            return mHRGTimeLineNHibernateEntity;
        }

        /// <summary>
        /// Get the MHRGType.
        /// </summary>
        /// <param name="mHRGTypeDomainEntity"></param>
        /// <returns></returns>
        public static MHRGType GetMHRGTypeEntity(MHRGTypeEntity mHRGTypeDomainEntity)
        {
            MHRGType mHRGTypeNHibernateEntity = null;

            try
            {
                mHRGTypeNHibernateEntity = Mapper.Map<MHRGTypeEntity, MHRGType>(mHRGTypeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHRGTypeEntity", ex);
                throw;
            }

            return mHRGTypeNHibernateEntity;
        }

        /// <summary>
        /// Get the MIconItem.
        /// </summary>
        /// <param name="mIconItemDomainEntity"></param>
        /// <returns></returns>
        public static MIconItem GetMIconItemEntity(MIconItemEntity mIconItemDomainEntity)
        {
            MIconItem mIconItemNHibernateEntity = null;

            try
            {
                mIconItemNHibernateEntity = Mapper.Map<MIconItemEntity, MIconItem>(mIconItemDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMIconItemEntity", ex);
                throw;
            }

            return mIconItemNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MIOOrganisation"/> from <see cref="MIOOrganisationEntity"/> input.
        /// </summary>
        /// <param name="mIOOrganisationEntity"><see cref="MIOOrganisationEntity"/></param>
        /// <returns>Returns <see cref="MIOOrganisation"/>, else null.</returns>
        public static MIOOrganisation GetMIOOrganisation(MIOOrganisationEntity mIOOrganisationEntity)
        {
            MIOOrganisation mIOOrganisation = null;

            try
            {
                mIOOrganisation = Mapper.Map<MIOOrganisationEntity, MIOOrganisation>(mIOOrganisationEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMIOOrganisation", ex);
                throw;
            }

            return mIOOrganisation;
        }

        /// <summary>
        /// Get the MJudGDCatchWord.
        /// </summary>
        /// <param name="mJudGDCatchWordDomainEntity"></param>
        /// <returns></returns>
        public static MJudGDCatchWord GetMJudGDCatchWordEntity(MJudGDCatchWordEntity mJudGDCatchWordDomainEntity)
        {
            MJudGDCatchWord mJudGDCatchWordNHibernateEntity = null;

            try
            {
                mJudGDCatchWordNHibernateEntity = Mapper.Map<MJudGDCatchWordEntity, MJudGDCatchWord>(mJudGDCatchWordDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMJudGDCatchWordEntity", ex);
                throw;
            }

            return mJudGDCatchWordNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MLegalPractice"/> from <see cref="MLegalPracticeEntity"/> input.
        /// </summary>
        /// <param name="MLegalPracticeEntity"><see cref="MLegalPracticeEntity"/></param>
        /// <returns>Returns <see cref="MLegalPractice"/>, else null.</returns>
        public static MLegalPractice GetMLegalPractice(MLegalPracticeEntity entity)
        {
            MLegalPractice data = null;

            try
            {
                if (entity != null)
                {
                    data = Mapper.Map<MLegalPracticeEntity, MLegalPractice>(entity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMLegalPractice", ex);
                throw;
            }

            return data;
        }

        /// <summary>
        /// Get the MLegislationAct.
        /// </summary>
        /// <param name="mLegislationActDomainEntity"></param>
        /// <returns></returns>
        public static MLegislationAct GetMLegislationActEntity(MLegislationActEntity mLegislationActDomainEntity)
        {
            MLegislationAct mLegislationActNHibernateEntity = null;

            try
            {
                mLegislationActNHibernateEntity = Mapper.Map<MLegislationActEntity, MLegislationAct>(mLegislationActDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMLegislationActEntity", ex);
                throw;
            }

            return mLegislationActNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MLimitations"/> from <see cref="MLimitationsEntity"/> input.
        /// </summary>
        /// <param name="mLimitationsEntity"><see cref="MLimitationsEntity"/></param>
        /// <returns>Returns <see cref="MLimitations"/>, else null.</returns>
        public static MLimitations GetMLimitations(MLimitationsEntity mLimitationsEntity)
        {
            MLimitations mLimitations = null;

            try
            {
                mLimitations = Mapper.Map<MLimitationsEntity, MLimitations>(mLimitationsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMLimitations", ex);
                throw;
            }

            return mLimitations;
        }

        /// <summary>
        /// Get the MLocation.
        /// </summary>
        /// <param name="mLocationDomainEntity"></param>
        /// <returns></returns>
        public static MLocation GetMLocationEntity(MLocationEntity mLocationDomainEntity)
        {
            MLocation mLocationNHibernateEntity = null;

            try
            {
                mLocationNHibernateEntity = Mapper.Map<MLocationEntity, MLocation>(mLocationDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMLocationEntity", ex);
                throw;
            }

            return mLocationNHibernateEntity;
        }

        /// <summary>
        /// Get the MMaritalStatus.
        /// </summary>
        /// <param name="mMaritalStatusDomainEntity"></param>
        /// <returns></returns>
        public static MMaritalStatus GetMMaritalStatusEntity(MMaritalStatusEntity mMaritalStatusDomainEntity)
        {
            MMaritalStatus mMaritalStatusNHibernateEntity = null;

            try
            {
                mMaritalStatusNHibernateEntity = Mapper.Map<MMaritalStatusEntity, MMaritalStatus>(mMaritalStatusDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMMaritalStatusEntity", ex);
                throw;
            }

            return mMaritalStatusNHibernateEntity;
        }

        /// <summary>
        /// Get the MMessageType.
        /// </summary>
        /// <param name="mMessageTypeDomainEntity"></param>
        /// <returns></returns>
        public static MMessageType GetMMessageTypeEntity(MMessageTypeEntity mMessageTypeDomainEntity)
        {
            MMessageType mMessageTypeNHibernateEntity = null;

            try
            {
                mMessageTypeNHibernateEntity = Mapper.Map<MMessageTypeEntity, MMessageType>(mMessageTypeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMMessageTypeEntity", ex);
                throw;
            }

            return mMessageTypeNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MMinuteSheetType"/> from <see cref="MMinuteSheetTypeEntity"/> input.
        /// </summary>
        /// <param name="mMinuteSheetTypeEntity"><see cref="MMinuteSheetTypeEntity"/></param>
        /// <returns>Returns <see cref="MMinuteSheetType"/>, else null.</returns>
        public static MMinuteSheetType GetMMinuteSheetType(MMinuteSheetTypeEntity mMinuteSheetTypeEntity)
        {
            MMinuteSheetType mMinuteSheetType = null;

            try
            {
                mMinuteSheetType = Mapper.Map<MMinuteSheetTypeEntity, MMinuteSheetType>(mMinuteSheetTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMMinuteSheetType", ex);
                throw;
            }

            return mMinuteSheetType;
        }

        /// <summary>
        /// Gets the <see cref="MModeOfTrafficking"/> from <see cref="MModeOfTraffickingEntity"/> input.
        /// </summary>
        /// <param name="mModeOfTraffickingEntity"><see cref="MModeOfTraffickingEntity"/></param>
        /// <returns>Returns <see cref="MModeOfTrafficking"/>, else null.</returns>
        public static MModeOfTrafficking GetMModeOfTrafficking(MModeOfTraffickingEntity mModeOfTraffickingEntity)
        {
            MModeOfTrafficking mModeOfTrafficking = null;

            try
            {
                mModeOfTrafficking = Mapper.Map<MModeOfTraffickingEntity, MModeOfTrafficking>(mModeOfTraffickingEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMModeOfTrafficking", ex);
                throw;
            }

            return mModeOfTrafficking;
        }

        /// <summary>
        /// Gets the <see cref="MAASOrganisationTypeEntity"/> from <see cref="MAASOrganisationType"/> input.
        /// </summary>
        /// <param name="mAASOrganisationType"><see cref="MAASOrganisationType"/></param>
        /// <returns>Returns <see cref="MAASOrganisationTypeEntity"/>, else null.</returns>
        public static MMonitoringType GetMMonitoringType(MMonitoringTypeEntity mMonitoringTypeEntity)
        {
            MMonitoringType mMonitoringType = null;

            try
            {
                mMonitoringType = Mapper.Map<MMonitoringTypeEntity, MMonitoringType>(mMonitoringTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMMonitoringType", ex);
                throw;
            }

            return mMonitoringType;
        }

        /// <summary>
        /// Get the MNAAAlertEventRecipient.
        /// </summary>
        /// <param name="mNAAAlertEventRecipientDomainEntity"></param>
        /// <returns></returns>
        public static MNAAAlertEventRecipient GetMNAAAlertEventRecipientEntity(MNAAAlertEventRecipientEntity mNAAAlertEventRecipientDomainEntity)
        {
            MNAAAlertEventRecipient mNAAAlertEventRecipientNHibernateEntity = null;

            try
            {
                mNAAAlertEventRecipientNHibernateEntity = Mapper.Map<MNAAAlertEventRecipientEntity, MNAAAlertEventRecipient>(mNAAAlertEventRecipientDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMNAAAlertEventRecipientEntity", ex);
                throw;
            }

            return mNAAAlertEventRecipientNHibernateEntity;
        }

        /// <summary>
        /// Get the MNAAAlertEventsTemplate.
        /// </summary>
        /// <param name="mNAAAlertEventsTemplateDomainEntity"></param>
        /// <returns></returns>
        public static MNAAAlertEventsTemplate GetMNAAAlertEventsTemplateEntity(MNAAAlertEventsTemplateEntity mNAAAlertEventsTemplateDomainEntity)
        {
            MNAAAlertEventsTemplate mNAAAlertEventsTemplateNHibernateEntity = null;

            try
            {
                mNAAAlertEventsTemplateNHibernateEntity = Mapper.Map<MNAAAlertEventsTemplateEntity, MNAAAlertEventsTemplate>(mNAAAlertEventsTemplateDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMNAAAlertEventsTemplateEntity", ex);
                throw;
            }

            return mNAAAlertEventsTemplateNHibernateEntity;
        }

        /// <summary>
        /// Get the MNAACategory.
        /// </summary>
        /// <param name="mNAACategoryDomainEntity"></param>
        /// <returns></returns>
        public static MNAACategory GetMNAACategoryEntity(MNAACategoryEntity mNAACategoryDomainEntity)
        {
            MNAACategory mNAACategoryNHibernateEntity = null;

            try
            {
                mNAACategoryNHibernateEntity = Mapper.Map<MNAACategoryEntity, MNAACategory>(mNAACategoryDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMNAACategoryEntity", ex);
                throw;
            }

            return mNAACategoryNHibernateEntity;
        }

        /// <summary>
        /// Get the MNAAPlaceHolder.
        /// </summary>
        /// <param name="mNAAPlaceHolderDomainEntity"></param>
        /// <returns></returns>
        public static MNAAPlaceHolder GetMNAAPlaceHolderEntity(MNAAPlaceHolderEntity mNAAPlaceHolderDomainEntity)
        {
            MNAAPlaceHolder mNAAPlaceHolderNHibernateEntity = null;

            try
            {
                mNAAPlaceHolderNHibernateEntity = Mapper.Map<MNAAPlaceHolderEntity, MNAAPlaceHolder>(mNAAPlaceHolderDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMNAAPlaceHolderEntity", ex);
                throw;
            }

            return mNAAPlaceHolderNHibernateEntity;
        }

        /// <summary>
        /// Get the MNAASubCategory.
        /// </summary>
        /// <param name="mNAASubCategoryDomainEntity"></param>
        /// <returns></returns>
        public static MNAASubCategory GetMNAASubCategoryEntity(MNAASubCategoryEntity mNAASubCategoryDomainEntity)
        {
            MNAASubCategory mNAASubCategoryNHibernateEntity = null;

            try
            {
                mNAASubCategoryNHibernateEntity = Mapper.Map<MNAASubCategoryEntity, MNAASubCategory>(mNAASubCategoryDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMNAASubCategoryEntity", ex);
                throw;
            }

            return mNAASubCategoryNHibernateEntity;
        }

        /// <summary>
        /// Get the MNationality.
        /// </summary>
        /// <param name="MNationalityDomainEntity"></param>
        /// <returns></returns>
        public static MNationality GetMNationalityEntity(MNationalityEntity mNationalityDomainEntity)
        {
            MNationality mNationalityNHibernateEntity = null;

            try
            {
                mNationalityNHibernateEntity = Mapper.Map<MNationalityEntity, MNationality>(mNationalityDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMNationalityEntity", ex);
                throw;
            }

            return mNationalityNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MNatureOfAppeal"/> from <see cref="MNatureOfAppealEntity"/> input.
        /// </summary>
        /// <param name="MNatureOfAppealEntity"><see cref="MNatureOfAppealEntity"/></param>
        /// <returns>Returns <see cref="MNatureOfAppeal"/>, else null.</returns>
        public static MNatureOfAppeal GetMNatureOfAppeal(MNatureOfAppealEntity mNatureOfAppealEntity)
        {
            MNatureOfAppeal mNatureOfAppeal = null;

            try
            {
                mNatureOfAppeal = Mapper.Map<MNatureOfAppealEntity, MNatureOfAppeal>(mNatureOfAppealEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNatureOfAppeal", ex);
                throw;
            }

            return mNatureOfAppeal;
        }

        /// <summary>
        /// Gets the <see cref="MNatureOfOffence"/> from <see cref="MNatureOfOffenceEntity"/> input.
        /// </summary>
        /// <param name="mNatureOfOffenceEntity"><see cref="MNatureOfOffenceEntity"/></param>
        /// <returns>Returns <see cref="MNatureOfOffence"/>, else null.</returns>
        public static MNatureOfOffence GetMNatureOfOffence(MNatureOfOffenceEntity mNatureOfOffenceEntity)
        {
            MNatureOfOffence mNatureOfOffence = null;

            try
            {
                mNatureOfOffence = Mapper.Map<MNatureOfOffenceEntity, MNatureOfOffence>(mNatureOfOffenceEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNatureOfOffence", ex);
                throw;
            }

            return mNatureOfOffence;
        }

        /// <summary>
        /// Gets the <see cref="MNatureOfWork"/> from <see cref="MNatureOfWorkEntity"/> input.
        /// </summary>
        /// <param name="mNatureOfWorkEntity"><see cref="MNatureOfWorkEntity"/></param>
        /// <returns>Returns <see cref="MNatureOfWork"/>, else null.</returns>
        public static MNatureOfWork GetMNatureOfWork(MNatureOfWorkEntity mNatureOfWorkEntity)
        {
            MNatureOfWork mNatureOfWork = null;

            try
            {
                mNatureOfWork = Mapper.Map<MNatureOfWorkEntity, MNatureOfWork>(mNatureOfWorkEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMNatureOfWork", ex);
                throw;
            }

            return mNatureOfWork;
        }

        /// <summary>
        /// Get the MNatureOfWork.
        /// </summary>
        /// <param name="mNatureOfWorkDomainEntity"></param>
        /// <returns></returns>
        public static MNatureOfWork GetMNatureOfWorkEntity(MNatureOfWorkEntity mNatureOfWorkDomainEntity)
        {
            MNatureOfWork mNatureOfWorkNHibernateEntity = null;

            try
            {
                mNatureOfWorkNHibernateEntity = Mapper.Map<MNatureOfWorkEntity, MNatureOfWork>(mNatureOfWorkDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMNatureOfWorkEntity", ex);
                throw;
            }

            return mNatureOfWorkNHibernateEntity;
        }

        /// <summary>
        /// Get the MNOACode.
        /// </summary>
        /// <param name="mNOACodeDomainEntity"></param>
        /// <returns></returns>
        public static MNOACode GetMNOACodeEntity(MNOACodeEntity mNOACodeDomainEntity)
        {
            MNOACode mNOACodeNHibernateEntity = null;

            try
            {
                mNOACodeNHibernateEntity = Mapper.Map<MNOACodeEntity, MNOACode>(mNOACodeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMNOACodeEntity", ex);
                throw;
            }

            return mNOACodeNHibernateEntity;
        }

        /// <summary>
        /// Get the MNOC.
        /// </summary>
        /// <param name="mNOCDomainEntity"></param>
        /// <returns></returns>
        public static MNOC GetMNOCEntity(MNOCEntity mNOCDomainEntity)
        {
            MNOC mNOCNHibernateEntity = null;

            try
            {
                mNOCNHibernateEntity = Mapper.Map<MNOCEntity, MNOC>(mNOCDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMNOCEntity", ex);
                throw;
            }

            return mNOCNHibernateEntity;
        }

        /// <summary>
        /// Get the MOccupation.
        /// </summary>
        /// <param name="mOccupationDomainEntity"></param>
        /// <returns></returns>
        public static MOccupation GetMOccupationEntity(MOccupationEntity mOccupationDomainEntity)
        {
            MOccupation mOccupationNHibernateEntity = null;

            try
            {
                mOccupationNHibernateEntity = Mapper.Map<MOccupationEntity, MOccupation>(mOccupationDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMOccupationEntity", ex);
                throw;
            }

            return mOccupationNHibernateEntity;
        }

        /*
        /// <summary>
        /// Get the MOrganizationAddr.
        /// </summary>
        /// <param name="mOrganizationAddrDomainEntity"></param>
        /// <returns></returns>
        public static MOrganizationAddr GetMOrganizationAddrEntity(MOrganizationAddrEntity mOrganizationAddrDomainEntity)
        {
            MOrganizationAddr mOrganizationAddrNHibernateEntity = null;

            try
            {
                mOrganizationAddrNHibernateEntity = Mapper.Map<MOrganizationAddrEntity, MOrganizationAddr>(mOrganizationAddrDomainEntity);
                mOrganizationAddrNHibernateEntity.MOrganization = Mapper.Map<MOrganizationEntity, MOrganization>(mOrganizationAddrDomainEntity.MOrganization);
            }
            catch (Exception ex)
            {
                throw;
            }

            return mOrganizationAddrNHibernateEntity;
        }

        /// <summary>
        /// Get the MOrganization.
        /// </summary>
        /// <param name="mOrganizationDomainEntity"></param>
        /// <returns></returns>
        public static MOrganization GetMOrganizationEntity(MOrganizationEntity mOrganizationDomainEntity)
        {
            MOrganization mOrganizationNHibernateEntity = null;

            try
            {
                mOrganizationNHibernateEntity = Mapper.Map<MOrganizationEntity, MOrganization>(mOrganizationDomainEntity);
            }
            catch (Exception ex)
            {
                throw;
            }

            return mOrganizationNHibernateEntity;
        }
        */
        /// <summary>
        /// Get the MOSDocDetail.
        /// </summary>
        /// <param name="mOSDocDetailDomainEntity"></param>
        /// <returns></returns>
        public static MOSDocDetail GetMOSDocDetailEntity(MOSDocDetailEntity mOSDocDetailDomainEntity)
        {
            MOSDocDetail mOSDocDetailNHibernateEntity = null;

            try
            {
                mOSDocDetailNHibernateEntity = Mapper.Map<MOSDocDetailEntity, MOSDocDetail>(mOSDocDetailDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMOSDocDetailEntity", ex);
                throw;
            }

            return mOSDocDetailNHibernateEntity;
        }

        /// <summary>
        /// Get the MOSType.
        /// </summary>
        /// <param name="mOSTypeDomainEntity"></param>
        /// <returns></returns>
        public static MOSType GetMOSTypeEntity(MOSTypeEntity mOSTypeDomainEntity)
        {
            MOSType mOSTypeNHibernateEntity = null;

            try
            {
                mOSTypeNHibernateEntity = Mapper.Map<MOSTypeEntity, MOSType>(mOSTypeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMOSTypeEntity", ex);
                throw;
            }

            return mOSTypeNHibernateEntity;
        }

        /// <summary>
        /// Get the MParameterList.
        /// </summary>
        /// <param name="mParameterListDomainEntity"></param>
        /// <returns></returns>
        public static MParameterList GetMParameterListEntity(MParameterListEntity mParameterListDomainEntity)
        {
            MParameterList mParameterListNHibernateEntity = null;

            try
            {
                mParameterListNHibernateEntity = Mapper.Map<MParameterListEntity, MParameterList>(mParameterListDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMParameterListEntity", ex);
                throw;
            }

            return mParameterListNHibernateEntity;
        }

        /// <summary>
        /// Get the MPartyAmendmentConfig.
        /// </summary>
        /// <param name="mPartyAmendmentConfigDomainEntity"></param>
        /// <returns></returns>
        public static MPartyAmendmentConfig GetMPartyAmendmentConfigEntity(MPartyAmendmentConfigEntity mPartyAmendmentConfigDomainEntity)
        {
            MPartyAmendmentConfig mPartyAmendmentConfigNHibernateEntity = null;

            try
            {
                mPartyAmendmentConfigNHibernateEntity = Mapper.Map<MPartyAmendmentConfigEntity, MPartyAmendmentConfig>(mPartyAmendmentConfigDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPartyAmendmentConfigEntity", ex);
                throw;
            }

            return mPartyAmendmentConfigNHibernateEntity;
        }

        /// <summary>
        /// Get the MPartySection.
        /// </summary>
        /// <param name="mPartySectionDomainEntity"></param>
        /// <returns></returns>
        public static MPartySection GetMPartySectionEntity(MPartySectionEntity mPartySectionDomainEntity)
        {
            MPartySection mPartySectionNHibernateEntity = null;

            try
            {
                mPartySectionNHibernateEntity = Mapper.Map<MPartySectionEntity, MPartySection>(mPartySectionDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPartySectionEntity", ex);
                throw;
            }

            return mPartySectionNHibernateEntity;
        }

        /// <summary>
        /// Get the MPartyStatus.
        /// </summary>
        /// <param name="mPartyStatusDomainEntity"></param>
        /// <returns></returns>
        public static MPartyStatus GetMPartyStatusEntity(MPartyStatusEntity mPartyStatusDomainEntity)
        {
            MPartyStatus mPartyStatusNHibernateEntity = null;

            try
            {
                mPartyStatusNHibernateEntity = Mapper.Map<MPartyStatusEntity, MPartyStatus>(mPartyStatusDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPartyStatusEntity", ex);
                throw;
            }

            return mPartyStatusNHibernateEntity;
        }

        /// <summary>
        /// Get the MPartyType.
        /// </summary>
        /// <param name="mPartyTypeDomainEntity"></param>
        /// <returns></returns>
        public static MPartyType GetMPartyTypeEntity(MPartyTypeEntity mPartyTypeDomainEntity)
        {
            MPartyType mPartyTypeNHibernateEntity = null;

            try
            {
                mPartyTypeNHibernateEntity = Mapper.Map<MPartyTypeEntity, MPartyType>(mPartyTypeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPartyTypeEntity", ex);
                throw;
            }

            return mPartyTypeNHibernateEntity;
        }

        /// <summary>
        /// Get the MPersonIDGroup.
        /// </summary>
        /// <param name="mPersonIDGroupDomainEntity"></param>
        /// <returns></returns>
        public static MPersonIDGroup GetMPersonIDGroupEntity(MPersonIDGroupEntity mPersonIDGroupDomainEntity)
        {
            MPersonIDGroup mPersonIDGroupNHibernateEntity = null;

            try
            {
                mPersonIDGroupNHibernateEntity = Mapper.Map<MPersonIDGroupEntity, MPersonIDGroup>(mPersonIDGroupDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPersonIDGroupEntity", ex);
                throw;
            }

            return mPersonIDGroupNHibernateEntity;
        }

        /// <summary>
        /// Get the MPersonIDType.
        /// </summary>
        /// <param name="mPersonIDTypeDomainEntity"></param>
        /// <returns></returns>
        public static MPersonIDType GetMPersonIDTypeEntity(MPersonIDTypeEntity mPersonIDTypeDomainEntity)
        {
            MPersonIDType mPersonIDTypeNHibernateEntity = null;

            try
            {
                mPersonIDTypeNHibernateEntity = Mapper.Map<MPersonIDTypeEntity, MPersonIDType>(mPersonIDTypeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPersonIDTypeEntity", ex);
                throw;
            }

            return mPersonIDTypeNHibernateEntity;
        }

        /// <summary>
        /// Get the MPrayerOutcome.
        /// </summary>
        /// <param name="mPrayerOutcomeDomainEntity"></param>
        /// <returns></returns>
        public static MPrayerOutcome GetMPrayerOutcomeEntity(MPrayerOutcomeEntity mPrayerOutcomeDomainEntity)
        {
            MPrayerOutcome mPrayerOutcomeNHibernateEntity = null;

            try
            {
                mPrayerOutcomeNHibernateEntity = Mapper.Map<MPrayerOutcomeEntity, MPrayerOutcome>(mPrayerOutcomeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPrayerOutcomeEntity", ex);
                throw;
            }

            return mPrayerOutcomeNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MPrison"/> from <see cref="MPrisonEntity"/> input.
        /// </summary>
        /// <param name="mPrisonEntity"><see cref="MPrisonEntity"/></param>
        /// <returns>Returns <see cref="MPrison"/>, else null.</returns>
        public static MPrison GetMPrison(MPrisonEntity mPrisonEntity)
        {
            MPrison mPrison = null;

            try
            {
                mPrison = Mapper.Map<MPrisonEntity, MPrison>(mPrisonEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPrison", ex);
                throw;
            }

            return mPrison;
        }

        /// <summary>
        /// Get the MProbateNature.
        /// </summary>
        /// <param name="mProbateNatureDomainEntity"></param>
        /// <returns></returns>
        public static MProbateNature GetMProbateNatureEntity(MProbateNatureEntity mProbateNatureDomainEntity)
        {
            MProbateNature mProbateNatureNHibernateEntity = null;

            try
            {
                mProbateNatureNHibernateEntity = Mapper.Map<MProbateNatureEntity, MProbateNature>(mProbateNatureDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMProbateNatureEntity", ex);
                throw;
            }

            return mProbateNatureNHibernateEntity;
        }

        /// <summary>
        /// Get the RUserRoleSection.
        /// </summary>
        /// <param name="rUserRoleSectionEntity"></param>
        /// <returns></returns>
        public static MProbateNatureGroup GetMProbateNatureGroup(MProbateNatureGroupEntity mProbateNatureGroupEntity)
        {
            MProbateNatureGroup mProbateNatureGroup = null;

            try
            {
                mProbateNatureGroup = Mapper.Map<MProbateNatureGroupEntity, MProbateNatureGroup>(mProbateNatureGroupEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMProbateNatureGroup", ex);
                throw;
            }

            return mProbateNatureGroup;
        }

        /// <summary>
        /// Get the MProbatePrayer.
        /// </summary>
        /// <param name="mProbatePrayerDomainEntity"></param>
        /// <returns></returns>
        public static MProbatePrayer GetMProbatePrayerEntity(MProbatePrayerEntity mProbatePrayerDomainEntity)
        {
            MProbatePrayer mProbatePrayerNHibernateEntity = null;

            try
            {
                mProbatePrayerNHibernateEntity = Mapper.Map<MProbatePrayerEntity, MProbatePrayer>(mProbatePrayerDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMProbatePrayerEntity", ex);
                throw;
            }

            return mProbatePrayerNHibernateEntity;
        }

        /// <summary>
        /// Get the MPropertyType.
        /// </summary>
        /// <param name="mPropertyTypeDomainEntity"></param>
        /// <returns></returns>
        public static MPropertyType GetMPropertyTypeEntity(MPropertyTypeEntity mPropertyTypeDomainEntity)
        {
            MPropertyType mPropertyTypeNHibernateEntity = null;

            try
            {
                mPropertyTypeNHibernateEntity = Mapper.Map<MPropertyTypeEntity, MPropertyType>(mPropertyTypeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPropertyTypeEntity", ex);
                throw;
            }

            return mPropertyTypeNHibernateEntity;
        }

        /// <summary>
        /// Get the MProvision.
        /// </summary>
        /// <param name="mProvisionDomainEntity"></param>
        /// <returns></returns>
        public static MProvision GetMProvisionEntity(MProvisionEntity mProvisionDomainEntity)
        {
            MProvision mProvisionNHibernateEntity = null;

            try
            {
                mProvisionNHibernateEntity = Mapper.Map<MProvisionEntity, MProvision>(mProvisionDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMProvisionEntity", ex);
                throw;
            }

            return mProvisionNHibernateEntity;
        }

        /// <summary>
        /// Get the MPTCMilestone.
        /// </summary>
        /// <param name="mPTCMilestoneDomainEntity"></param>
        /// <returns></returns>
        public static MPTCMilestone GetMPTCMilestoneEntity(MPTCMilestoneEntity mPTCMilestoneDomainEntity)
        {
            MPTCMilestone mPTCMilestoneNHibernateEntity = null;

            try
            {
                mPTCMilestoneNHibernateEntity = Mapper.Map<MPTCMilestoneEntity, MPTCMilestone>(mPTCMilestoneDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPTCMilestoneEntity", ex);
                throw;
            }

            return mPTCMilestoneNHibernateEntity;
        }

        /// <summary>
        /// Get the MQualification.
        /// </summary>
        /// <param name="mQualificationDomainEntity"></param>
        /// <returns></returns>
        public static MQualification GetMQualificationEntity(MQualificationEntity mQualificationDomainEntity)
        {
            MQualification mQualificationNHibernateEntity = null;

            try
            {
                mQualificationNHibernateEntity = Mapper.Map<MQualificationEntity, MQualification>(mQualificationDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMQualificationEntity", ex);
                throw;
            }

            return mQualificationNHibernateEntity;
        }

        /// <summary>
        /// Get the MRace.
        /// </summary>
        /// <param name="mRaceDomainEntity"></param>
        /// <returns></returns>
        public static MRace GetMRaceEntity(MRaceEntity mRaceDomainEntity)
        {
            MRace mRaceNHibernateEntity = null;

            try
            {
                mRaceNHibernateEntity = Mapper.Map<MRaceEntity, MRace>(mRaceDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRaceEntity", ex);
                throw;
            }

            return mRaceNHibernateEntity;
        }

        /// <summary>
        /// Get the MRDocCategoryCaseType.
        /// </summary>
        /// <param name="mRDocCategoryCaseTypeDomainEntity"></param>
        /// <returns></returns>
        public static MRDocCategoryCaseType GetMRDocCategoryCaseTypeEntity(MRDocCategoryCaseTypeEntity mRDocCategoryCaseTypeDomainEntity)
        {
            MRDocCategoryCaseType mRDocCategoryCaseTypeNHibernateEntity = null;

            try
            {
                mRDocCategoryCaseTypeNHibernateEntity = Mapper.Map<MRDocCategoryCaseTypeEntity, MRDocCategoryCaseType>(mRDocCategoryCaseTypeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRDocCategoryCaseTypeEntity", ex);
                throw;
            }

            return mRDocCategoryCaseTypeNHibernateEntity;
        }

        /// <summary>
        /// Get the MRelationship.
        /// </summary>
        /// <param name="mRelationshipDomainEntity"></param>
        /// <returns></returns>
        public static MRelationship GetMRelationshipEntity(MRelationshipEntity mRelationshipDomainEntity)
        {
            MRelationship mRelationshipNHibernateEntity = null;

            try
            {
                mRelationshipNHibernateEntity = Mapper.Map<MRelationshipEntity, MRelationship>(mRelationshipDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRelationshipEntity", ex);
                throw;
            }

            return mRelationshipNHibernateEntity;
        }

        /// <summary>
        /// Get the MRelief.
        /// </summary>
        /// <param name="mReliefDomainEntity"></param>
        /// <returns></returns>
        public static MRelief GetMReliefEntity(MReliefEntity mReliefDomainEntity)
        {
            MRelief mReliefNHibernateEntity = null;

            try
            {
                mReliefNHibernateEntity = Mapper.Map<MReliefEntity, MRelief>(mReliefDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMReliefEntity", ex);
                throw;
            }

            return mReliefNHibernateEntity;
        }

        /// <summary>
        /// Get the MReligion.
        /// </summary>
        /// <param name="mReligionDomainEntity"></param>
        /// <returns></returns>
        public static MReligion GetMReligionEntity(MReligionEntity mReligionDomainEntity)
        {
            MReligion mReligionNHibernateEntity = null;

            try
            {
                mReligionNHibernateEntity = Mapper.Map<MReligionEntity, MReligion>(mReligionDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMReligionEntity", ex);
                throw;
            }

            return mReligionNHibernateEntity;
        }

        /// <summary>
        /// Get the MRoutingType.
        /// </summary>
        /// <param name="mRoutingTypeDomainEntity"></param>
        /// <returns></returns>
        public static MRoutingType GetMRoutingTypeEntity(MRoutingTypeEntity mRoutingTypeDomainEntity)
        {
            MRoutingType mRoutingTypeNHibernateEntity = null;

            try
            {
                mRoutingTypeNHibernateEntity = Mapper.Map<MRoutingTypeEntity, MRoutingType>(mRoutingTypeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRoutingTypeEntity", ex);
                throw;
            }

            return mRoutingTypeNHibernateEntity;
        }

        /// <summary>
        /// Get the MSalutation.
        /// </summary>
        /// <param name="mSalutationDomainEntity"></param>
        /// <returns></returns>
        public static MSalutation GetMSalutationEntity(MSalutationEntity mSalutationDomainEntity)
        {
            MSalutation mSalutationNHibernateEntity = null;

            try
            {
                mSalutationNHibernateEntity = Mapper.Map<MSalutationEntity, MSalutation>(mSalutationDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSalutationEntity", ex);
                throw;
            }

            return mSalutationNHibernateEntity;
        }

        /// <summary>
        /// Get the MScheduleJobLegalDetail.
        /// </summary>
        /// <param name="mScheduleJobLegalDetailDomainEntity"></param>
        /// <returns></returns>
        public static MScheduleJobLegalDetail GetMScheduleJobLegalDetail(MScheduleJobLegalDetailEntity mScheduleJobLegalDetailDomainEntity)
        {
            MScheduleJobLegalDetail mScheduleJobLegalDetailNHibernateEntity = null;

            try
            {
                mScheduleJobLegalDetailNHibernateEntity = Mapper.Map<MScheduleJobLegalDetailEntity, MScheduleJobLegalDetail>(mScheduleJobLegalDetailDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMScheduleJobLegalDetail", ex);
                throw;
            }

            return mScheduleJobLegalDetailNHibernateEntity;
        }

        /// <summary>
        /// Get the MScheduleJobLegalInfo.
        /// </summary>
        /// <param name="mScheduleJobLegalInfoDomainEntity"></param>
        /// <returns></returns>
        public static MScheduleJobLegalInfo GetMScheduleJobLegalInfo(MScheduleJobLegalInfoEntity mScheduleJobLegalInfoDomainEntity)
        {
            MScheduleJobLegalInfo mScheduleJobLegalInfoNHibernateEntity = null;

            try
            {
                mScheduleJobLegalInfoNHibernateEntity = Mapper.Map<MScheduleJobLegalInfoEntity, MScheduleJobLegalInfo>(mScheduleJobLegalInfoDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMScheduleJobLegalInfo", ex);
                throw;
            }

            return mScheduleJobLegalInfoNHibernateEntity;
        }

        /// <summary>
        /// Get the MSection.
        /// </summary>
        /// <param name="mSectionDomainEntity"></param>
        /// <returns></returns>
        public static MSection GetMSectionEntity(MSectionEntity mSectionDomainEntity)
        {
            MSection mSectionNHibernateEntity = null;

            try
            {
                mSectionNHibernateEntity = Mapper.Map<MSectionEntity, MSection>(mSectionDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSectionEntity", ex);
                throw;
            }

            return mSectionNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="MSentence"/> from <see cref="MSentenceEntity"/> input.
        /// </summary>
        /// <param name="mSentenceEntity"><see cref="MSentenceEntity"/></param>
        /// <returns>Returns <see cref="MSentence"/>, else null.</returns>
        public static MSentence GetMSentence(MSentenceEntity mSentenceEntity)
        {
            MSentence mSentence = null;

            try
            {
                mSentence = Mapper.Map<MSentenceEntity, MSentence>(mSentenceEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMSentence", ex);
                throw;
            }

            return mSentence;
        }

        /// <summary>
        /// Gets the <see cref="MSequenceKey"/> from <see cref="MSequenceKeyEntity"/> input.
        /// </summary>
        /// <param name="mSequenceKeyEntity"><see cref="MSequenceKeyEntity"/></param>
        /// <returns>Returns <see cref="MSequenceKey"/>, else null.</returns>
        public static MSequenceKey GetMSequenceKey(MSequenceKeyEntity mSequenceKeyEntity)
        {
            MSequenceKey mSequenceKey = null;

            try
            {
                mSequenceKey = Mapper.Map<MSequenceKeyEntity, MSequenceKey>(mSequenceKeyEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMSequenceKey", ex);
                throw;
            }

            return mSequenceKey;
        }

        /// <summary>
        /// Get the MSubProvision.
        /// </summary>
        /// <param name="MSubProvisionDomainEntity"></param>
        /// <returns></returns>
        public static MSubProvision GetMSubProvisionEntity(MSubProvisionEntity mSubProvisionDomainEntity)
        {
            MSubProvision mSubProvisionNHibernateEntity = null;

            try
            {
                mSubProvisionNHibernateEntity = Mapper.Map<MSubProvisionEntity, MSubProvision>(mSubProvisionDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSubProvisionEntity", ex);
                throw;
            }

            return mSubProvisionNHibernateEntity;
        }

        /// <summary>
        /// Get the MTaskListType.
        /// </summary>
        /// <param name="mTaskListTypeDomainEntity"></param>
        /// <returns></returns>
        public static MTaskListType GetMTaskListType(MTaskListTypeEntity mTaskListTypeDomainEntity)
        {
            MTaskListType mTaskListTypeNHibernateEntity = null;

            try
            {
                mTaskListTypeNHibernateEntity = Mapper.Map<MTaskListTypeEntity, MTaskListType>(mTaskListTypeDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMTaskListType", ex);
                throw;
            }

            return mTaskListTypeNHibernateEntity;
        }

        /// <summary>
        /// Get the MUserGroup.
        /// </summary>
        /// <param name="mUserGroupDomainEntity"></param>
        /// <returns></returns>
        public static MUserGroup GetMUserGroupEntity(MUserGroupEntity mUserGroupDomainEntity)
        {
            MUserGroup mUserGroupNHibernateEntity = null;

            try
            {
                mUserGroupNHibernateEntity = Mapper.Map<MUserGroupEntity, MUserGroup>(mUserGroupDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMUserGroupEntity", ex);
                throw;
            }

            return mUserGroupNHibernateEntity;
        }

        /// <summary>
        /// Get the MUserRole.
        /// </summary>
        /// <param name="mUserRoleDomainEntity"></param>
        /// <returns></returns>
        public static MUserRole GetMUserRoleEntity(MUserRoleEntity mUserRoleDomainEntity)
        {
            MUserRole mUserRoleNHibernateEntity = null;

            try
            {
                mUserRoleNHibernateEntity = Mapper.Map<MUserRoleEntity, MUserRole>(mUserRoleDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMUserRoleEntity", ex);
                throw;
            }

            return mUserRoleNHibernateEntity;
        }

        /// <summary>
        /// Get the MWorkFlow.
        /// </summary>
        /// <param name="mWorkFlowDomainEntity"></param>
        /// <returns></returns>
        public static MWorkFlow GetMWorkFlowEntity(MWorkFlowEntity mWorkFlowDomainEntity)
        {
            MWorkFlow mWorkFlowNHibernateEntity = null;

            try
            {
                mWorkFlowNHibernateEntity = Mapper.Map<MWorkFlowEntity, MWorkFlow>(mWorkFlowDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMWorkFlowEntity", ex);
                throw;
            }

            return mWorkFlowNHibernateEntity;
        }

        /// <summary>
        /// Get the MWorkPeriod.
        /// </summary>
        /// <param name="mWorkPeriodDomainEntity"></param>
        /// <returns></returns>
        public static MWorkPeriod GetMWorkPeriodEntity(MWorkPeriodEntity mWorkPeriodDomainEntity)
        {
            MWorkPeriod mWorkPeriodNHibernateEntity = null;

            try
            {
                mWorkPeriodNHibernateEntity = Mapper.Map<MWorkPeriodEntity, MWorkPeriod>(mWorkPeriodDomainEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMWorkPeriodEntity", ex);
                throw;
            }

            return mWorkPeriodNHibernateEntity;
        }

        /// <summary>
        /// Gets the <see cref="RMAASSectionExternalAgency"/> from <see cref="RMAASSectionExternalAgencyEntity"/> input.
        /// </summary>
        /// <param name="rMAASSectionExternalAgencyEntity"><see cref="RMAASSectionExternalAgencyEntity"/></param>
        /// <returns>Returns <see cref="RMAASSectionExternalAgency"/>, else null.</returns>
        public static RMAASSectionExternalAgency GetRMAASSectionExternalAgency(RMAASSectionExternalAgencyEntity rMAASSectionExternalAgencyEntity)
        {
            RMAASSectionExternalAgency rMAASSectionExternalAgency = null;

            try
            {
                rMAASSectionExternalAgency = Mapper.Map<RMAASSectionExternalAgencyEntity, RMAASSectionExternalAgency>(rMAASSectionExternalAgencyEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMAASSectionExternalAgency", ex);
                throw;
            }

            return rMAASSectionExternalAgency;
        }

        /// <summary>
        /// Gets the <see cref="MSequenceKey"/> from <see cref="MSequenceKeyEntity"/> input.
        /// </summary>
        /// <param name="mSequenceKeyEntity"><see cref="MSequenceKeyEntity"/></param>
        /// <returns>Returns <see cref="MSequenceKey"/>, else null.</returns>
        public static RMCaseTypeForum GetRMCaseTypeForum(RMCaseTypeForumEntity rMCaseTypeForumEntity)
        {
            RMCaseTypeForum rMCaseTypeForum = null;

            try
            {
                rMCaseTypeForum = Mapper.Map<RMCaseTypeForumEntity, RMCaseTypeForum>(rMCaseTypeForumEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMCaseTypeForum", ex);
                throw;
            }

            return rMCaseTypeForum;
        }

        /// <summary>
        /// Gets the <see cref="RMCaseTypeHRGTypeMSType"/> from <see cref="RMCaseTypeHRGTypeMSTypeEntity"/> input.
        /// </summary>
        /// <param name="rMCaseTypeHRGTypeMSTypeEntity"><see cref="RMCaseTypeHRGTypeMSTypeEntity"/></param>
        /// <returns>Returns <see cref="RMCaseTypeHRGTypeMSType"/>, else null.</returns>
        public static RMCaseTypeHRGTypeMSType GetRMCaseTypeHRGTypeMSType(RMCaseTypeHRGTypeMSTypeEntity rMCaseTypeHRGTypeMSTypeEntity)
        {
            RMCaseTypeHRGTypeMSType rMCaseTypeHRGTypeMSType = null;

            try
            {
                rMCaseTypeHRGTypeMSType = Mapper.Map<RMCaseTypeHRGTypeMSTypeEntity, RMCaseTypeHRGTypeMSType>(rMCaseTypeHRGTypeMSTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMCaseTypeHRGTypeMSType", ex);
                throw;
            }

            return rMCaseTypeHRGTypeMSType;
        }

        public static RMCaseTypeForumHRGTypeMSType GetRMCaseTypeForumHRGTypeMSType(RMCaseTypeForumHRGTypeMSTypeEntity rMCaseTypeForumHRGTypeMSTypeEntity)
        {
            RMCaseTypeForumHRGTypeMSType rMCaseTypeForumHRGTypeMSType = null;

            try
            {
                rMCaseTypeForumHRGTypeMSType = Mapper.Map<RMCaseTypeForumHRGTypeMSTypeEntity, RMCaseTypeForumHRGTypeMSType>(rMCaseTypeForumHRGTypeMSTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMCaseTypeForumHRGTypeMSType", ex);
                throw;
            }

            return rMCaseTypeForumHRGTypeMSType;
        }


        /**End of Criminal Master Tables**/
        /// <summary>
        /// Gets the <see cref="RMCaseTypeNOA"/> from <see cref="RMCaseTypeNOAEntity"/> input.
        /// </summary>
        /// <param name="rmCaseTypeNOAEntity"><see cref="RMCaseTypeNOAEntity"/></param>
        /// <returns>Returns <see cref="RMCaseTypeNOA"/>, else null.</returns>
        public static RMCaseTypeNOA GetRMCaseTypeNOA(RMCaseTypeNOAEntity rmCaseTypeNOAEntity)
        {
            RMCaseTypeNOA rmCaseTypeNOA = null;

            try
            {
                rmCaseTypeNOA = Mapper.Map<RMCaseTypeNOAEntity, RMCaseTypeNOA>(rmCaseTypeNOAEntity);
                //rmCaseTypeNOA.MCaseType = Mapper.Map<MCaseTypeEntity, MCaseType>(rmCaseTypeNOAEntity.MCaseTypeEntity);
                //rmCaseTypeNOA.MNOACode = Mapper.Map<MNOACodeEntity, MNOACode>(rmCaseTypeNOAEntity.MNOACodeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMCaseTypeNOA", ex);
                throw;
            }

            return rmCaseTypeNOA;
        }

        /// <summary>
        /// Gets the <see cref="RMHRGOutComePartyStatusEntity"/> from <see cref="CaseIssueEntity"/> input.
        /// </summary>
        /// <param name="mCaseIssueDomainEntity"><see cref="MCaseIssueEntity"/></param>
        /// <returns>Returns <see cref="RMHRGOutComePartyStatusEntity"/>, else null.</returns>
        public static RMHRGOutComePartyStatus GetRMHRGOutComePartyStatus(RMHRGOutComePartyStatusEntity rMHRGOutComePartyStatusEntity)
        {
            RMHRGOutComePartyStatus rMHRGOutComePartyStatusNHibernateEntity = null;

            try
            {
                rMHRGOutComePartyStatusNHibernateEntity = Mapper.Map<RMHRGOutComePartyStatusEntity, RMHRGOutComePartyStatus>(rMHRGOutComePartyStatusEntity);
                rMHRGOutComePartyStatusNHibernateEntity.MCaseStatus = Mapper.Map<MCaseStatusEntity, MCaseStatus>(rMHRGOutComePartyStatusEntity.MCaseStatus);
                rMHRGOutComePartyStatusNHibernateEntity.MCaseTypeGroup = Mapper.Map<MCaseTypeGroupEntity, MCaseTypeGroup>(rMHRGOutComePartyStatusEntity.MCaseTypeGroup);
                rMHRGOutComePartyStatusNHibernateEntity.MHRGOutCome = Mapper.Map<MHRGOutComeEntity, MHRGOutCome>(rMHRGOutComePartyStatusEntity.MHRGOutCome);
                rMHRGOutComePartyStatusNHibernateEntity.MPartyStatus = Mapper.Map<MPartyStatusEntity, MPartyStatus>(rMHRGOutComePartyStatusEntity.MPartyStatus);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMHRGOutComePartyStatus", ex);
                throw;
            }

            return rMHRGOutComePartyStatusNHibernateEntity;
        }

        public static RMRoutingSectionConfig GetRMRoutingSectionConfig(RMRoutingSectionConfigEntity rMRoutingSectionConfigEntity)
        {
            RMRoutingSectionConfig rMRoutingSectionConfig = null;

            try
            {
                rMRoutingSectionConfig = Mapper.Map<RMRoutingSectionConfigEntity, RMRoutingSectionConfig>(rMRoutingSectionConfigEntity);
                rMRoutingSectionConfig.MNOC = Mapper.Map<MNOCEntity, MNOC>(rMRoutingSectionConfigEntity.MNOC);
                rMRoutingSectionConfig.MLegislationAct = Mapper.Map<MLegislationActEntity, MLegislationAct>(rMRoutingSectionConfigEntity.MLegislationAct);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMRoutingSectionConfig", ex);
                throw;
            }

            return rMRoutingSectionConfig;
        }

        public static RMSectionAccessCtrl GetRMSectionAccessCtrl(RMSectionAccessCtrlEntity rMSectionAccessCtrlEntity)
        {
            RMSectionAccessCtrl rMSectionAccessCtrl = null;

            try
            {
                rMSectionAccessCtrl = Mapper.Map<RMSectionAccessCtrlEntity, RMSectionAccessCtrl>(rMSectionAccessCtrlEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMSectionAccessCtrl", ex);
                throw;
            }

            return rMSectionAccessCtrl;
        }

        /// <summary>
        /// Get the RRoleFunctions.
        /// </summary>
        /// <param name="rRoleFunctionsEntity"></param>
        /// <returns></returns>
        public static RRoleFunctions GetRRoleFunctions(RRoleFunctionsEntity rRoleFunctionsEntity)
        {
            RRoleFunctions rRoleFunctions = null;

            try
            {
                rRoleFunctions = Mapper.Map<RRoleFunctionsEntity, RRoleFunctions>(rRoleFunctionsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRRoleFunctions", ex);
                throw;
            }

            return rRoleFunctions;
        }

        /// <summary>
        /// Get the RUserRoleSection.
        /// </summary>
        /// <param name="rUserRoleSectionEntity"></param>
        /// <returns></returns>
        public static RUserFunctions GetRUserFunctions(RUserFunctionsEntity rUserFunctionsEntity)
        {
            RUserFunctions rUserFunctions = null;

            try
            {
                rUserFunctions = Mapper.Map<RUserFunctionsEntity, RUserFunctions>(rUserFunctionsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRUserFunctions", ex);
                throw;
            }

            return rUserFunctions;
        }

        /// <summary>
        /// Get the RUserRoleSection.
        /// </summary>
        /// <param name="rUserRoleSectionEntity"></param>
        /// <returns></returns>
        public static RUserRoleSection GetRUserRoleSection(RUserRoleSectionEntity rUserRoleSectionEntity)
        {
            RUserRoleSection rUserRoleSection = null;

            try
            {
                rUserRoleSection = Mapper.Map<RUserRoleSectionEntity, RUserRoleSection>(rUserRoleSectionEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRUserRoleSection", ex);
                throw;
            }

            return rUserRoleSection;
        }

        /// <summary>
        /// Gets the serial number.
        /// </summary>
        /// <param name="serialNumberEntity">The serial number entity.</param>
        /// <returns></returns>
        public static SerialNumber GetSerialNumber(SerialNumberEntity serialNumberEntity)
        {
            SerialNumber serialNumber = null;

            try
            {
                serialNumber = Mapper.Map<SerialNumberEntity, SerialNumber>(serialNumberEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSerialNumber", ex);
                throw;
            }

            return serialNumber;
        }

        /// <summary>
        /// Gets the type of the RM hearing type court.
        /// </summary>
        /// <param name="rMHearingTypeCourtTypeEntity">The r M hearing type court type entity.</param>
        /// <returns></returns>
        public static RMHearingTypeCourtType GetRMHearingTypeCourtType(RMHearingTypeCourtTypeEntity rMHearingTypeCourtTypeEntity)
        {
            RMHearingTypeCourtType rMHearingTypeCourtType = null;

            try
            {
                rMHearingTypeCourtType = Mapper.Map<RMHearingTypeCourtTypeEntity, RMHearingTypeCourtType>(rMHearingTypeCourtTypeEntity);
                rMHearingTypeCourtType.MCoram = Mapper.Map<MCoramEntity, MCoram>(rMHearingTypeCourtTypeEntity.MCoram);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMHearingTypeCourtType", ex);
                throw;
            }

            return rMHearingTypeCourtType;
        }

        /// <summary>
        /// Gets the RMHRG type HRG out come HRG out come flag.
        /// </summary>
        /// <param name="rMHRGTypeHRGOutComeHRGOutComeFlagEntity">The r MHRG type HRG out come HRG out come flag entity.</param>
        /// <returns></returns>
        public static RMHRGTypeHRGOutComeHRGOutComeFlag GetRMHRGTypeHRGOutComeHRGOutComeFlag(RMHRGTypeHRGOutComeHRGOutComeFlagEntity rMHRGTypeHRGOutComeHRGOutComeFlagEntity)
        {
            RMHRGTypeHRGOutComeHRGOutComeFlag rMHRGTypeHRGOutComeHRGOutComeFlag = null;

            try
            {
                rMHRGTypeHRGOutComeHRGOutComeFlag = Mapper.Map<RMHRGTypeHRGOutComeHRGOutComeFlagEntity, RMHRGTypeHRGOutComeHRGOutComeFlag>(rMHRGTypeHRGOutComeHRGOutComeFlagEntity);


            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMHRGTypeHRGOutComeHRGOutComeFlag", ex);
                throw;
            }

            return rMHRGTypeHRGOutComeHRGOutComeFlag;
        }

        /// <summary>
        /// Gets the RMHRG type HRG out come HRG out come flag.
        /// </summary>
        /// <param name="rMHRGTypeHRGOutComeHRGOutComeFlagEntity">The r MHRG type HRG out come HRG out come flag entity.</param>
        /// <returns></returns>
        public static RMDocCodeHRGType GetRMDocCodeHRGType(RMDocCodeHrgTypeEntity rMDocCodeHrgTypeEntity)
        {
            RMDocCodeHRGType rMDocCodeHRGType = null;

            try
            {
                rMDocCodeHRGType = Mapper.Map<RMDocCodeHrgTypeEntity, RMDocCodeHRGType>(rMDocCodeHrgTypeEntity);


            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMDocCodeHRGType", ex);
                throw;
            }

            return rMDocCodeHRGType;
        }

        /// <summary>
        /// Gets the MHRG out come flag.
        /// </summary>
        /// <param name="mHRGOutComeFlagEntity">The m HRG out come flag entity.</param>
        /// <returns></returns>
        public static MHRGOutComeFlag GetMHRGOutComeFlag(MHRGOutComeFlagEntity mHRGOutComeFlagEntity)
        {
            MHRGOutComeFlag mHRGOutComeFlag = null;

            try
            {
                mHRGOutComeFlag = Mapper.Map<MHRGOutComeFlagEntity, MHRGOutComeFlag>(mHRGOutComeFlagEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHRGOutComeFlag", ex);
                throw;
            }

            return mHRGOutComeFlag;
        }


        /// <summary>
        /// Gets the MIDType.
        /// </summary>
        /// <param name="mHRGOutComeFlagEntity">The MIDType.</param>
        /// <returns></returns>
        public static MIDType GetMIDType(MIDTypeEntity mIDTypeEntity)
        {
            MIDType mIDType = null;

            try
            {
                mIDType = Mapper.Map<MIDTypeEntity, MIDType>(mIDTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMIDType", ex);
                throw;
            }

            return mIDType;
        }


        /// <summary>
        /// Gets the MEMS old SCT case prefix.
        /// </summary>
        /// <param name="mEMSOldSCTCasePrefixEntity">The m EMS old SCT case prefix entity.</param>
        /// <returns></returns>
        public static MEMSOldSCTCasePrefix GetMEMSOldSCTCasePrefix(MEMSOldSCTCasePrefixEntity mEMSOldSCTCasePrefixEntity)
        {
            MEMSOldSCTCasePrefix mEMSOldSCTCasePrefix = null;

            try
            {
                mEMSOldSCTCasePrefix = Mapper.Map<MEMSOldSCTCasePrefixEntity, MEMSOldSCTCasePrefix>(mEMSOldSCTCasePrefixEntity);


            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSOldSCTCasePrefix", ex);
                throw;
            }

            return mEMSOldSCTCasePrefix;
        }

        /// <summary>
        /// Gets the <see cref="RMCaseTypeNOC"/> from <see cref="RMCaseTypeNOCEntity"/> input.
        /// </summary>
        /// <param name="RMCaseTypeNOCEntity"><see cref="RMCaseTypeNOCEntity"/></param>
        /// <returns>Returns <see cref="RMCaseTypeNOC"/>, else null.</returns>
        public static RMCaseTypeNOC GetRMCaseTypeNOC(RMCaseTypeNOCEntity entity)
        {
            RMCaseTypeNOC data = null;

            try
            {
                if (entity != null)
                {
                    data = Mapper.Map<RMCaseTypeNOCEntity, RMCaseTypeNOC>(entity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMCaseTypeNOC", ex);
                throw;
            }

            return data;
        }

        /// <summary>
        /// Gets the <see cref="RMPartyTypeCaseType"/> from <see cref="RMPartyTypeCaseTypeEntity"/> input.
        /// </summary>
        /// <param name="rMPartyTypeCaseTypeEntity"><see cref="RMPartyTypeCaseTypeEntity"/></param>
        /// <returns>Returns <see cref="RMPartyTypeCaseType"/>, else null.</returns>
        public static RMPartyTypeCaseType GetRMPartyTypeCaseType(RMPartyTypeCaseTypeEntity rMPartyTypeCaseTypeEntity)
        {
            RMPartyTypeCaseType rMPartyTypeCaseType = null;

            try
            {
                if (rMPartyTypeCaseTypeEntity != null)
                {
                    rMPartyTypeCaseType = Mapper.Map<RMPartyTypeCaseTypeEntity, RMPartyTypeCaseType>(rMPartyTypeCaseTypeEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMPartyTypeCaseType", ex);
                throw;
            }

            return rMPartyTypeCaseType;
        }

        public static MDocControl GetMDocControl(MDocControlEntity mDocControlEntity)
        {
            MDocControl mDocControl = null;

            try
            {
                if (mDocControlEntity != null)
                {
                    mDocControl = Mapper.Map<MDocControlEntity, MDocControl>(mDocControlEntity);
                    mDocControl.MCourtType = Mapper.Map<MCourtTypeEntity, MCourtType>(mDocControlEntity.CourtInd);
                    mDocControl.MDCCaseType = Mapper.Map<MCaseTypeEntity, MCaseType>(mDocControlEntity.CaseTypeCode);
                    mDocControl.MDCSubCaseType = Mapper.Map<MCaseTypeEntity, MCaseType>(mDocControlEntity.SubCaseTypeCode);
                    mDocControl.MDocCode = Mapper.Map<MDocCodeEntity, MDocCode>(mDocControlEntity.MDocCode);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDocControl", ex);
                throw;
            }

            return mDocControl;
        }

        public static MFilingFee GetMFilingFee(MFilingFeeEntity mFilingFeeEntity)
        {
            MFilingFee mFilingFee = null;

            try
            {
                if (mFilingFeeEntity != null)
                {
                    mFilingFee = Mapper.Map<MFilingFeeEntity, MFilingFee>(mFilingFeeEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMFilingFee", ex);
                throw;
            }

            return mFilingFee;
        }

        public static MSummonsParam GetMSummonsParam(MSummonsParamEntity mSummonsParamEntity)
        {
            MSummonsParam mSummonsParam = null;

            try
            {
                if (mSummonsParamEntity != null)
                {
                    mSummonsParam = Mapper.Map<MSummonsParamEntity, MSummonsParam>(mSummonsParamEntity);
                    mSummonsParam.MCourtType = Mapper.Map<MCourtTypeEntity, MCourtType>(mSummonsParamEntity.MCourtType);
                    mSummonsParam.MNOACode = Mapper.Map<MNOACodeEntity, MNOACode>(mSummonsParamEntity.MNOACode);
                    mSummonsParam.MCaseType = Mapper.Map<MCaseTypeEntity, MCaseType>(mSummonsParamEntity.MCaseType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMSummonsParam", ex);
                throw;
            }

            return mSummonsParam;
        }

        public static RMHRGTypeHRGSlot GetRMHRGTypeHRGSlot(RMHRGTypeHRGSlotEntity rMHRGTypeHRGSlotEntity)
        {
            RMHRGTypeHRGSlot rMHRGTypeHRGSlot = null;

            try
            {
                if (rMHRGTypeHRGSlotEntity != null)
                {
                    rMHRGTypeHRGSlot = Mapper.Map<RMHRGTypeHRGSlotEntity, RMHRGTypeHRGSlot>(rMHRGTypeHRGSlotEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRMHRGTypeHRGSlot", ex);
                throw;
            }

            return rMHRGTypeHRGSlot;
        }

        /// <summary>
        /// Gets the M mass call HRG date.
        /// </summary>
        /// <param name="mMassCallHrgDateEntity">The m mass call HRG date entity.</param>
        /// <returns></returns>
        public static MMassCallHrgDate GetMMassCallHrgDate(MMassCallHrgDateEntity mMassCallHrgDateEntity)
        {
            MMassCallHrgDate mMassCallHrgDate = null;

            try
            {
                if (mMassCallHrgDateEntity != null)
                {
                    mMassCallHrgDate = Mapper.Map<MMassCallHrgDateEntity, MMassCallHrgDate>(mMassCallHrgDateEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMMassCallHrgDate", ex);
                throw;
            }

            return mMassCallHrgDate;
        }

        /// <summary>
        /// Gets the M charge outcome.
        /// </summary>
        /// <param name="mChargeOutcomeEntity">The m charge outcome entity.</param>
        /// <returns></returns>
        public static MChargeOutcome GetMChargeOutcome(MChargeOutcomeEntity mChargeOutcomeEntity)
        {
            MChargeOutcome mChargeOutcome = null;

            try
            {
                if (mChargeOutcomeEntity != null)
                {
                    mChargeOutcome = Mapper.Map<MChargeOutcomeEntity, MChargeOutcome>(mChargeOutcomeEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMChargeOutcome", ex);
                throw;
            }

            return mChargeOutcome;
        }


        public static MVSAConfigDetail GetMVSAConfigDetail(MVSAConfigDetailEntity mVSAConfigDetailEntity)
        {
            MVSAConfigDetail mVSAConfigDetail = null;
            try
            {
                mVSAConfigDetail = Mapper.Map<MVSAConfigDetailEntity, MVSAConfigDetail>(mVSAConfigDetailEntity);
                mVSAConfigDetail.MCourtType = Mapper.Map<MCourtTypeEntity, MCourtType>(mVSAConfigDetailEntity.MCourtType);
                mVSAConfigDetail.MDocCode = Mapper.Map<MDocCodeEntity, MDocCode>(mVSAConfigDetailEntity.MDocCode);
                mVSAConfigDetail.MNOACode = Mapper.Map<MNOACodeEntity, MNOACode>(mVSAConfigDetailEntity.MNOACode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMVSAConfigDetail", ex);
                throw;
            }
            return mVSAConfigDetail;
        }


        public static MVSAConfigGround GetMVSAConfigGround(MVSAConfigGroundEntity mVSAConfigGroundEntity)
        {
            MVSAConfigGround mVSAConfigGround = null;
            try
            {
                mVSAConfigGround = Mapper.Map<MVSAConfigGroundEntity, MVSAConfigGround>(mVSAConfigGroundEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMVSAConfigGround", ex);
                throw;
            }
            return mVSAConfigGround;
        }

        public static MVSAConfigPrayer GetMVSAConfigPrayer(MVSAConfigPrayerEntity mVSAConfigPrayerEntity)
        {
            MVSAConfigPrayer mVSAConfigPrayer = null;
            try
            {
                mVSAConfigPrayer = Mapper.Map<MVSAConfigPrayerEntity, MVSAConfigPrayer>(mVSAConfigPrayerEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMVSAConfigPrayer", ex);
                throw;
            }
            return mVSAConfigPrayer;
        }

        public static MFilingFeeChargingMechanism GetMFilingFeeChargingMechanism(MFilingFeeChargingMechanismEntity mFilingFeeChargingMechanismEntity)
        {
            MFilingFeeChargingMechanism mFilingFeeChargingMechanism = null;
            try
            {
                mFilingFeeChargingMechanism = Mapper.Map<MFilingFeeChargingMechanismEntity, MFilingFeeChargingMechanism>(mFilingFeeChargingMechanismEntity);
                mFilingFeeChargingMechanism.MFilingFee = Mapper.Map<MFilingFeeEntity, MFilingFee>(mFilingFeeChargingMechanismEntity.MFilingFeeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMFilingFeeChargingMechanism", ex);
                throw;
            }
            return mFilingFeeChargingMechanism;
        }

        public static MFilingFeeLegislationAct GetMFilingFeeLegislationAct(MFilingFeeLegislationActEntity mFilingFeeLegislationActEntity)
        {
            MFilingFeeLegislationAct mFilingFeeLegislationAct = null;
            try
            {
                mFilingFeeLegislationAct = Mapper.Map<MFilingFeeLegislationActEntity, MFilingFeeLegislationAct>(mFilingFeeLegislationActEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMFilingFeeLegislationActEntity", ex);
                throw;
            }
            return mFilingFeeLegislationAct;
        }

        public static RMDocFilterGroup GetRMDocFilterGroup(RMDocFilterGroupEntity rMDocFilterGroupEntity)
        {
            RMDocFilterGroup rMDocFilterGroup = null;
            try
            {
                rMDocFilterGroup = Mapper.Map<RMDocFilterGroupEntity, RMDocFilterGroup>(rMDocFilterGroupEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMDocFilterGroup", ex);
                throw;
            }
            return rMDocFilterGroup;
        }

        public static MSummonsGrounds GetMSummonsGrounds(MSummonsGroundsEntity mSummonsGroundsEntity)
        {
            MSummonsGrounds mSummonsGrounds = null;
            try
            {
                mSummonsGrounds = Mapper.Map<MSummonsGroundsEntity, MSummonsGrounds>(mSummonsGroundsEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSummonsGrounds", ex);
                throw;
            }
            return mSummonsGrounds;
        }


        public static MSummonsPrayers GetMSummonsPrayers(MSummonsPrayersEntity mSummonsPrayersEntity)
        {
            MSummonsPrayers mSummonsPrayers = null;
            try
            {
                mSummonsPrayers = Mapper.Map<MSummonsPrayersEntity, MSummonsPrayers>(mSummonsPrayersEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSummonsPrayers", ex);
                throw;
            }
            return mSummonsPrayers;
        }

        public static MHRGPredefinedDate GetMHRGPredefinedDate(MHRGPredefinedDateEntity mHRGPredefinedDateEntity)
        {
            MHRGPredefinedDate mHRGPredefinedDate = null;
            try
            {
                mHRGPredefinedDate = Mapper.Map<MHRGPredefinedDateEntity, MHRGPredefinedDate>(mHRGPredefinedDateEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHRGPredefinedDate", ex);
                throw;
            }
            return mHRGPredefinedDate;
        }

        public static RMCaseTypeHRGTypeJOL GetRMCaseTypeHRGTypeJOL(RMCaseTypeHRGTypeJOLEntity rMCaseTypeHRGTypeJOLEntity)
        {
            RMCaseTypeHRGTypeJOL rMCaseTypeHRGTypeJOL = null;
            try
            {
                rMCaseTypeHRGTypeJOL = Mapper.Map<RMCaseTypeHRGTypeJOLEntity, RMCaseTypeHRGTypeJOL>(rMCaseTypeHRGTypeJOLEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMCaseTypeHRGTypeJOL", ex);
                throw;
            }
            return rMCaseTypeHRGTypeJOL;
        }

        public static MHRGBeforeType GetMHRGBeforeType(MHRGBeforeTypeEntity mHRGBeforeTypeEntity)
        {
            MHRGBeforeType mHRGBeforeType = null;
            try
            {
                mHRGBeforeType = Mapper.Map<MHRGBeforeTypeEntity, MHRGBeforeType>(mHRGBeforeTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHRGBeforeType", ex);
                throw;
            }
            return mHRGBeforeType;
        }

        public static RMSubCaseTypeHRGTypeMSType GetRMSubCaseTypeHRGTypeMSType(RMSubCaseTypeHRGTypeMSTypeEntity rMSubCaseTypeHRGTypeMSTypeEntity)
        {
            RMSubCaseTypeHRGTypeMSType rMSubCaseTypeHRGTypeMSType = null;
            try
            {
                rMSubCaseTypeHRGTypeMSType = Mapper.Map<RMSubCaseTypeHRGTypeMSTypeEntity, RMSubCaseTypeHRGTypeMSType>(rMSubCaseTypeHRGTypeMSTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMSubCaseTypeHRGTypeMSType", ex);
                throw;
            }
            return rMSubCaseTypeHRGTypeMSType;
        }


        public static MAlertEventType GetMAlertEventType(MAlertEventTypeEntity mAlertEventTypeEntity)
        {
            MAlertEventType mAlertEventType = null;
            try
            {
                mAlertEventType = Mapper.Map<MAlertEventTypeEntity, MAlertEventType>(mAlertEventTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMAlertEventType", ex);
                throw;
            }
            return mAlertEventType;
        }

        public static RMAlertEventTypeRole GetRMAlertEventTypeRole(RMAlertEventTypeRoleEntity rMAlertEventTypeRoleEntity)
        {
            RMAlertEventTypeRole rMAlertEventTypeRole = null;
            try
            {
                rMAlertEventTypeRole = Mapper.Map<RMAlertEventTypeRoleEntity, RMAlertEventTypeRole>(rMAlertEventTypeRoleEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMAlertEventTypeRole", ex);
                throw;
            }
            return rMAlertEventTypeRole;
        }

        public static RAlertEventSubscribers GetRAlertEventSubscribers(RAlertEventSubscribersEntity rAlertEventSubscribersEntity)
        {
            RAlertEventSubscribers rAlertEventSubscribers = null;
            try
            {
                rAlertEventSubscribers = Mapper.Map<RAlertEventSubscribersEntity, RAlertEventSubscribers>(rAlertEventSubscribersEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRAlertEventSubscribers", ex);
                throw;
            }
            return rAlertEventSubscribers;
        }

        public static MBusinessJobLegalInfo GetMBusinessJobLegalInfo(MBusinessJobLegalInfoEntity mBusinessJobLegalInfoEntity)
        {
            MBusinessJobLegalInfo mBusinessJobLegalInfo = null;
            try
            {
                mBusinessJobLegalInfo = Mapper.Map<MBusinessJobLegalInfoEntity, MBusinessJobLegalInfo>(mBusinessJobLegalInfoEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMBusinessJobLegalInfo", ex);
                throw;
            }
            return mBusinessJobLegalInfo;
        }

        public static MBusinessJobLegalDetail GetMBusinessJobLegalDetail(MBusinessJobLegalDetailEntity mBusinessJobLegalDetailEntity)
        {
            MBusinessJobLegalDetail mBusinessJobLegalDetail = null;
            try
            {
                mBusinessJobLegalDetail = Mapper.Map<MBusinessJobLegalDetailEntity, MBusinessJobLegalDetail>(mBusinessJobLegalDetailEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMBusinessJobLegalInfo", ex);
                throw;
            }
            return mBusinessJobLegalDetail;
        }

        public static MLawPracticeType GetMLawPracticeType(MLawPracticeTypeEntity mLawPracticeTypeEntity)
        {
            MLawPracticeType mLawPracticeType = null;
            try
            {
                mLawPracticeType = Mapper.Map<MLawPracticeTypeEntity, MLawPracticeType>(mLawPracticeTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMLawPracticeType", ex);
                throw;
            }
            return mLawPracticeType;
        }

        public static RMHearingRoutingSectionConfig GetRMHearingRoutingSectionConfig(RMHearingRoutingSectionConfigEntity rmHearingRoutingSectionConfigEntity)
        {
            RMHearingRoutingSectionConfig rmHearingRoutingSectionConfig = null;
            try
            {
                rmHearingRoutingSectionConfig = Mapper.Map<RMHearingRoutingSectionConfigEntity, RMHearingRoutingSectionConfig>(rmHearingRoutingSectionConfigEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMHearingRoutingSectionConfig", ex);
                throw;
            }
            return rmHearingRoutingSectionConfig;
        }


        public static MPaperMinuteSheetType GetMPaperMinuteSheetType(MPaperMinuteSheetTypeEntity mPaperMinuteSheetTypeEntity)
        {
            MPaperMinuteSheetType mPaperMinuteSheetType = null;
            try
            {
                mPaperMinuteSheetType = Mapper.Map<MPaperMinuteSheetTypeEntity, MPaperMinuteSheetType>(mPaperMinuteSheetTypeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPaperMinuteSheetType", ex);
                throw;
            }
            return mPaperMinuteSheetType;
        }


        public static RMHRGTypePaperMinuteSheetType GetRMHRGTypePaperMinuteSheetType(RMHRGTypePaperMinuteSheetTypeEntity rMHRGTypePaperMinuteSheetTypeEntity)
        {
            RMHRGTypePaperMinuteSheetType rmHRGTypePaperMinuteSheetType = null;
            try
            {
                rmHRGTypePaperMinuteSheetType = Mapper.Map<RMHRGTypePaperMinuteSheetTypeEntity, RMHRGTypePaperMinuteSheetType>(rMHRGTypePaperMinuteSheetTypeEntity);
                rmHRGTypePaperMinuteSheetType.MDesignation = Mapper.Map<MDesignationEntity, MDesignation>(rMHRGTypePaperMinuteSheetTypeEntity.MDesignation);
                rmHRGTypePaperMinuteSheetType.MHearingType = Mapper.Map<MHearingTypeEntity, MHearingType>(rMHRGTypePaperMinuteSheetTypeEntity.MHearingType);
                rmHRGTypePaperMinuteSheetType.MPaperMinuteSheetType = Mapper.Map<MPaperMinuteSheetTypeEntity, MPaperMinuteSheetType>(rMHRGTypePaperMinuteSheetTypeEntity.MPaperMinuteSheetType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMHRGTypePaperMinuteSheetType", ex);
                throw;
            }
            return rmHRGTypePaperMinuteSheetType;
        }

        public static MCourtVacation GetMCourtVacation(MCourtVacationEntity mCourtVacationEntity)
        {
            MCourtVacation mCourtVacation = null;
            try
            {
                mCourtVacation = Mapper.Map<MCourtVacationEntity, MCourtVacation>(mCourtVacationEntity);
                mCourtVacation.MForumType = Mapper.Map<MForumTypeEntity, MForumType>(mCourtVacationEntity.MForumType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMCourtVacation", ex);
                throw;
            }
            return mCourtVacation;
        }

        public static MEMSRecTransMode GetMEMSRecTransMode(MEMSRecTransModeEntity mEMSRecTransModeEntity)
        {
            MEMSRecTransMode mEMSRecTransMode = null;
            try
            {
                mEMSRecTransMode = Mapper.Map<MEMSRecTransModeEntity, MEMSRecTransMode>(mEMSRecTransModeEntity);
                
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEMSRecTransMode", ex);
                throw;
            }
            return mEMSRecTransMode;
        }

        public static RMDocTierSensitive GetRMDocTierSensitive(RMDocTierSensitiveEntity rMDocTierSensitiveEntity)
        {
            RMDocTierSensitive rMDocTierSensitive = null;
            try
            {
                rMDocTierSensitive = Mapper.Map<RMDocTierSensitiveEntity, RMDocTierSensitive>(rMDocTierSensitiveEntity);
                rMDocTierSensitive.MDocCode = Mapper.Map<MDocCodeEntity, MDocCode>(rMDocTierSensitiveEntity.MDocCode);
                rMDocTierSensitive.CaseTypeCode = Mapper.Map<MCaseTypeEntity, MCaseType>(rMDocTierSensitiveEntity.CaseTypeCode);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRMDocTierSensitive", ex);
                throw;
            }
            return rMDocTierSensitive;
        }

        public static RMHrgSlotNOC GetRMHrgSlotNOC(RMHrgSlotNOCEntity rMHrgSlotNOCEntity)
        {
            RMHrgSlotNOC rMHrgSlotNOC = null;
            try
            {
                rMHrgSlotNOC = Mapper.Map<RMHrgSlotNOCEntity, RMHrgSlotNOC>(rMHrgSlotNOCEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at DomainToNHibernate - RMHrgSlotNOC", ex);
                throw;
            }
            return rMHrgSlotNOC;
        }

        public static RMHrgSlotLegis GetRMHrgSlotLegis(RMHrgSlotLegisEntity rMHrgSlotLegisEntity)
        {
            RMHrgSlotLegis rMHrgSlotLegis = null;
            try
            {
                rMHrgSlotLegis = Mapper.Map<RMHrgSlotLegisEntity, RMHrgSlotLegis>(rMHrgSlotLegisEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at DomainToNHibernate - RMHrgSlotLegis", ex);
                throw;
            }
            return rMHrgSlotLegis;
        }

        public static RMDocControlExclusion GetRMDocControlExclusion(RMDocControlExclusionEntity rMDocControlExclusionEntity)
        {
            RMDocControlExclusion rMDocControlExclusion = null;
            try
            {
                rMDocControlExclusion = Mapper.Map<RMDocControlExclusionEntity, RMDocControlExclusion>(rMDocControlExclusionEntity);
                rMDocControlExclusion.MForumType = Mapper.Map<MForumTypeEntity, MForumType>(rMDocControlExclusionEntity.ForumID);
                rMDocControlExclusion.MCaseType = Mapper.Map<MCaseTypeEntity, MCaseType>(rMDocControlExclusionEntity.CaseTypeCode);
                rMDocControlExclusion.MSubCaseType = Mapper.Map<MCaseTypeEntity, MCaseType>(rMDocControlExclusionEntity.SubCaseTypeCode);
                rMDocControlExclusion.MDocCode = Mapper.Map<MDocCodeEntity, MDocCode>(rMDocControlExclusionEntity.DocCode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at DomainToNHibernate - GetRMDocControlExclusion", ex);
                throw;
            }
            return rMDocControlExclusion;
        }

        public static MResidential GetMResidential(MResidentialEntity mResidentialEntity)
        {
            MResidential mResidential = null;

            try
            {
                mResidential = Mapper.Map<MResidentialEntity, MResidential>(mResidentialEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMResidential", ex);
                throw;
            }

            return mResidential;
        }

        public static MIncome GetMIncome(MIncomeEntity mIncomeEntity)
        {
            MIncome mIncome = null;

            try
            {
                mIncome = Mapper.Map<MIncomeEntity, MIncome>(mIncomeEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMIncome", ex);
                throw;
            }

            return mIncome;
        }


        public static MDirections GetMDirections(MDirectionsEntity mDirectionsEntity)
        {
            MDirections mDirections = null;

            try
            {
                mDirections = Mapper.Map<MDirectionsEntity, MDirections>(mDirectionsEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMDirections", ex);
                throw;
            }

            return mDirections;
        }

        public static MHarassPlace GetMHarassPlace(MHarassPlaceEntity mHarassPlaceEntity)
        {
            MHarassPlace mHarassPlace = null;

            try
            {
                mHarassPlace = Mapper.Map<MHarassPlaceEntity, MHarassPlace>(mHarassPlaceEntity);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMHarassPlace", ex);
                throw;
            }

            return mHarassPlace;
        }

        #endregion Methods
    }
}