namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;

    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;
    using AllInOne.Legal.Domain.Abstract;

    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.CaseData;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Enforcement;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LAP;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.MRelationship;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Domain.SubCaseData;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Domain.WritOfSummons;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Data;

    using log4net;

    using NHibernate.Criterion;
    using NHibernate.SqlCommand;
    using NHibernate.Transform;
    using AllInOne.Legal.Domain.Audit;

    public class FinderMediatorService<T>
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(FinderMediatorService<T>));

        DetachedCriteria _Criteria;
        ProjectionList _Projections;

        #endregion Fields

        #region Methods

        public void AddAliases(string path, string alias)
        {
            _Criteria.CreateAlias(path, alias);
        }

        public void AddAliases(string path, string alias, JoinType jointype)
        {
            _Criteria.CreateAlias(path, alias, jointype);
        }

        public void AddCriteria(ICriterion criteria)
        {
            _Criteria.Add(criteria);
        }

        public void AddProjection(IProjection projection, string alias)
        {
            if (_Projections == null)
                _Projections = Projections.ProjectionList();

            _Projections.Add(projection, alias);
        }

        public int DeleteEntity()
        {
            FinderGatewayService gateway = new FinderGatewayService();

            if (typeof(T).Equals(typeof(RUserFunctionsEntity)))
                return gateway.DeleteAll<RUserFunctions>(_Criteria);

            if (typeof(T).Equals(typeof(RUserRoleSectionEntity)))
                return gateway.DeleteAll<RUserRoleSection>(_Criteria);

            if (typeof(T).Equals(typeof(RMUserPSEntity)))
                return gateway.DeleteAll<RMUserPS>(_Criteria);

            return 0;
        }

        public List<V> FindList<V>()
        {
            FinderGatewayService gateway = new FinderGatewayService();

            return gateway.FindAll<V>(_Criteria) as List<V>;
        }

        public List<V> FindListAsGroup<V>()
        {
            FinderGatewayService gateway = new FinderGatewayService();

            if (_Projections != null)
                _Criteria.SetProjection(_Projections);

            _Criteria.SetResultTransformer(Transformers.AliasToBean<V>());

            return gateway.FindAll<V>(_Criteria) as List<V>;
        }

        public List<T> FindListEntity()
        {
            FinderGatewayService gateway = new FinderGatewayService();

            if (typeof(T).Equals(typeof(FunctionsByUserEntity)))
                return gateway.FindAllEntity<FunctionsByUser, FunctionsByUserEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(FunctionsByRoleEntity)))
                return gateway.FindAllEntity<FunctionsByRole, FunctionsByRoleEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MCourtTypeEntity)))
                return gateway.FindAllEntity<MCourtType, MCourtTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MForumTypeEntity)))
                return gateway.FindAllEntity<MForumType, MForumTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MFunctionsEntity)))
                return gateway.FindAllEntity<MFunctions, MFunctionsEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MSectionEntity)))
                return gateway.FindAllEntity<MSection, MSectionEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MUserRoleEntity)))
                return gateway.FindAllEntity<MUserRole, MUserRoleEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RRoleFunctionsEntity)))
                return gateway.FindAllEntity<RRoleFunctions, RRoleFunctionsEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RUserRoleSectionEntity)))
                return gateway.FindAllEntity<RUserRoleSection, RUserRoleSectionEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RUserFunctionsEntity)))
                return gateway.FindAllEntity<RUserFunctions, RUserFunctionsEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(UsersEntity)))
                return gateway.FindAllEntity<Users, UsersEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(VSectionUserACLEntity)))
                return gateway.FindAllEntity<VSectionUserACL, VSectionUserACLEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(VSecuredCaseAccessInfoEntity)))
                return gateway.FindAllEntity<VSecuredCaseAccessInfo, VSecuredCaseAccessInfoEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(VSecuredDocAccessInfoEntity)))
                return gateway.FindAllEntity<VSecuredDocAccessInfo, VSecuredDocAccessInfoEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMSectionAccessCtrlEntity)))
                return gateway.FindAllEntity<RMSectionAccessCtrl, RMSectionAccessCtrlEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MCaseTypeEntity)))
                return gateway.FindAllEntity<MCaseType, MCaseTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MCountryEntity)))
                return gateway.FindAllEntity<MCountry, MCountryEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MCurrencyEntity)))
                return gateway.FindAllEntity<MCurrency, MCurrencyEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MDialectEntity)))
                return gateway.FindAllEntity<MDialect, MDialectEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MGenderEntity)))
                return gateway.FindAllEntity<MGender, MGenderEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MReligionEntity)))
                return gateway.FindAllEntity<MReligion, MReligionEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MHolidayEntity)))
                return gateway.FindAllEntity<MHoliday, MHolidayEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MLegalPracticeEntity)))
                return gateway.FindAllEntity<MLegalPractice, MLegalPracticeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MLegislationActEntity)))
                return gateway.FindAllEntity<MLegislationAct, MLegislationActEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MMaritalStatusEntity)))
                return gateway.FindAllEntity<MMaritalStatus, MMaritalStatusEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MNationalityEntity)))
                return gateway.FindAllEntity<MNationality, MNationalityEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MQualificationEntity)))
                return gateway.FindAllEntity<MQualification, MQualificationEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MRaceEntity)))
                return gateway.FindAllEntity<MRace, MRaceEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MReligionEntity)))
                return gateway.FindAllEntity<MReligion, MReligionEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MNOACodeEntity)))
                return gateway.FindAllEntity<MNOACode, MNOACodeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MDocCategoryEntity)))
                return gateway.FindAllEntity<MDocCategory, MDocCategoryEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MFilterGroupEntity)))
                return gateway.FindAllEntity<MFilterGroup, MFilterGroupEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MDesignationEntity)))
                return gateway.FindAllEntity<MDesignation, MDesignationEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MLimitationsEntity)))
                return gateway.FindAllEntity<MLimitations, MLimitationsEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MFormTemplateLocationEntity)))
                return gateway.FindAllEntity<MFormTemplateLocation, MFormTemplateLocationEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMCaseTypeForumEntity)))
                return gateway.FindAllEntity<RMCaseTypeForum, RMCaseTypeForumEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MMinuteSheetTypeEntity)))
                return gateway.FindAllEntity<MMinuteSheetType, MMinuteSheetTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MJudicialOfficerEntity)))
                return gateway.FindAllEntity<MJudicialOfficer, MJudicialOfficerEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(SystemParametersEntity)))
                return gateway.FindAllEntity<SystemParameters, SystemParametersEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MCoramEntity)))
                return gateway.FindAllEntity<MCoram, MCoramEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMUserPSEntity)))
                return gateway.FindAllEntity<RMUserPS, RMUserPSEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MHearingTypeEntity)))
                return gateway.FindAllEntity<MHearingType, MHearingTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MHRGOutComeEntity)))
                return gateway.FindAllEntity<MHRGOutCome, MHRGOutComeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MHRGRoomTypeEntity)))
                return gateway.FindAllEntity<MHRGRoomType, MHRGRoomTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MHRGRoomEntity)))
                return gateway.FindAllEntity<MHRGRoom, MHRGRoomEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MHRGOutComeFlagEntity)))
                return gateway.FindAllEntity<MHRGOutComeFlag, MHRGOutComeFlagEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MHRGOutComeReasonEntity)))
                return gateway.FindAllEntity<MHRGOutComeReason, MHRGOutComeReasonEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMForumCoramDSGEntity)))
                return gateway.FindAllEntity<RMForumCoramDSG, RMForumCoramDSGEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMCaseTypeHRGTypeMSTypeEntity)))
                return gateway.FindAllEntity<RMCaseTypeHRGTypeMSType, RMCaseTypeHRGTypeMSTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMCaseTypeForumHRGTypeMSTypeEntity)))
                return gateway.FindAllEntity<RMCaseTypeForumHRGTypeMSType, RMCaseTypeForumHRGTypeMSTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMHearingTypeCourtTypeEntity)))
                return gateway.FindAllEntity<RMHearingTypeCourtType, RMHearingTypeCourtTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMHRGTypeHRGOutComeHRGOutComeFlagEntity)))
                return gateway.FindAllEntity<RMHRGTypeHRGOutComeHRGOutComeFlag, RMHRGTypeHRGOutComeHRGOutComeFlagEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMDocCodeHrgTypeEntity)))
                return gateway.FindAllEntity<RMDocCodeHRGType, RMDocCodeHrgTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMNOAForumHrgTypeEntity)))
                return gateway.FindAllEntity<RMNOAForumHrgType, RMNOAForumHrgTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MDocCodeEntity)))
                return gateway.FindAllEntity<MDocCode, MDocCodeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MDocControlEntity)))
                return gateway.FindAllEntity<MDocControl, MDocControlEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MNOCEntity)))
                return gateway.FindAllEntity<MNOC, MNOCEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMCaseTypeNOCEntity)))
                return gateway.FindAllEntity<RMCaseTypeNOC, RMCaseTypeNOCEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MHRGSlotEntity)))
                return gateway.FindAllEntity<MHRGSlot, MHRGSlotEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MMassCallHrgDateEntity)))
                return gateway.FindAllEntity<MMassCallHrgDate, MMassCallHrgDateEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMHRGTypeHRGSlotEntity)))
                return gateway.FindAllEntity<RMHRGTypeHRGSlot, RMHRGTypeHRGSlotEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MFilingFeeEntity)))
                return gateway.FindAllEntity<MFilingFee, MFilingFeeEntity>(_Criteria) as List<T>;

            if(typeof(T).Equals(typeof(MFilingFeeChargingMechanismEntity)))
                return gateway.FindAllEntity<MFilingFeeChargingMechanism,MFilingFeeChargingMechanismEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MSummonsParamEntity)))
                return gateway.FindAllEntity<MSummonsParam, MSummonsParamEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MSummonsGroundsEntity)))
                return gateway.FindAllEntity<MSummonsGrounds, MSummonsGroundsEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MSummonsPrayersEntity)))
                return gateway.FindAllEntity<MSummonsPrayers, MSummonsPrayersEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMDocFilterGroupEntity)))
                return gateway.FindAllEntity<RMDocFilterGroup, RMDocFilterGroupEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MVSAConfigDetailEntity)))
                return gateway.FindAllEntity<MVSAConfigDetail, MVSAConfigDetailEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MVSAConfigGroundEntity)))
                return gateway.FindAllEntity<MVSAConfigGround, MVSAConfigGroundEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MVSAConfigPrayerEntity)))
                return gateway.FindAllEntity<MVSAConfigPrayer, MVSAConfigPrayerEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(LawFirmEntity)))
                return gateway.FindAllEntity<LawFirm, LawFirmEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(LawFirmAddressEntity)))
                return gateway.FindAllEntity<LawFirmAddress, LawFirmAddressEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(SolicitorEntity)))
                return gateway.FindAllEntity<Solicitor, SolicitorEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(SolicitorAddressEntity)))
                return gateway.FindAllEntity<SolicitorAddress, SolicitorAddressEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MLawFirmGroupEntity)))
                return gateway.FindAllEntity<MLawFirmGroup, MLawFirmGroupEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MIDTypeEntity)))
                return gateway.FindAllEntity<MIDType, MIDTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MPersonIDTypeEntity)))
                return gateway.FindAllEntity<MPersonIDType, MPersonIDTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MHRGPredefinedDateEntity)))
                return gateway.FindAllEntity<MHRGPredefinedDate, MHRGPredefinedDateEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMCaseTypeHRGTypeJOLEntity)))
                return gateway.FindAllEntity<RMCaseTypeHRGTypeJOL, RMCaseTypeHRGTypeJOLEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(AuditModuleVisitEntity)))
                return gateway.FindAllEntity<AuditModuleVisit, AuditModuleVisitEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(InterfaceLawSocLawFirmEntity)))
                return gateway.FindAllEntity<InterfaceLawSocLawFirm, InterfaceLawSocLawFirmEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(InterfaceLawSocLawFirmAddressEntity)))
                return gateway.FindAllEntity<InterfaceLawSocLawFirmAddress, InterfaceLawSocLawFirmAddressEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMSubCaseTypeHRGTypeMSTypeEntity)))
                return gateway.FindAllEntity<RMSubCaseTypeHRGTypeMSType, RMSubCaseTypeHRGTypeMSTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RAlertEventSubscribersEntity)))
                return gateway.FindAllEntity<RAlertEventSubscribers, RAlertEventSubscribersEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(UsersEntity)))
                return gateway.FindAllEntity<Users, UsersEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MAlertEventTypeEntity)))
                return gateway.FindAllEntity<MAlertEventType, MAlertEventTypeEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MEMSParamEntity)))
                return gateway.FindAllEntity<MEMSParam, MEMSParamEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RPTNOCGroupEntity)))
                return gateway.FindAllEntity<RPTNOCGroup, RPTNOCGroupEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RPTNOCGroupNOCEntity)))
                return gateway.FindAllEntity<RPTNOCGroupNOC, RPTNOCGroupNOCEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RPTDisposalKPIConfigEntity)))
                return gateway.FindAllEntity<RPTDisposalKPIConfig, RPTDisposalKPIConfigEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MProvisionEntity)))
                return gateway.FindAllEntity<MProvision, MProvisionEntity>(_Criteria) as List<T>;
            if (typeof(T).Equals(typeof(MPrisonEntity)))
                return gateway.FindAllEntity<MPrison, MPrisonEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(MDefaultLoginPageEntity)))
                return gateway.FindAllEntity<MDefaultLoginPage, MDefaultLoginPageEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMHrgSlotNOCEntity)))
                return gateway.FindAllEntity<RMHrgSlotNOC, RMHrgSlotNOCEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMHrgSlotLegisEntity)))
                return gateway.FindAllEntity<RMHrgSlotLegis, RMHrgSlotLegisEntity>(_Criteria) as List<T>;

            if (typeof(T).Equals(typeof(RMRoutingSectionConfigEntity)))
                return gateway.FindAllEntity<RMRoutingSectionConfig, RMRoutingSectionConfigEntity>(_Criteria) as List<T>;

            return gateway.FindAll<T>(_Criteria) as List<T>;
        }

        public void InitCriteria(Type entity)
        {
            _Criteria = DetachedCriteria.For(entity, entity.Name);
        }

        public void SetCacheable(bool cacheable)
        {
            _Criteria.SetCacheable(cacheable);
        }

        public void SetFirstResult(int FirstResult)
        {
            _Criteria.SetFirstResult(FirstResult);
        }

        public void SetMaxResult(int MaxResults)
        {
            _Criteria.SetMaxResults(MaxResults);
        }

        #endregion Methods
    }
}