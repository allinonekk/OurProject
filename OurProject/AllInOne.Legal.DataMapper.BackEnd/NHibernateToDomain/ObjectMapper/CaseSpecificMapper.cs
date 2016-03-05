#region Header

/*****************************************************************************************************
* Description : This file handles mapper for Case Specific from NHibernate entities to Domain objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   14/01/2011   		        Nithin                 Created

*****************************************************************************************************/
// <summary>
// File: CaseSpecificMapper.cs
// Description: This file handles mapper for Case Specific from NHibernate entities to Domain objects.
// </summary>
// <copyright file= "CaseSpecificMapper.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Class handles mapping for Case Specific from NHibernate entities to Domain objects.
    /// </summary>
    public class CaseSpecificMapper
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CaseSpecificMapper));

        #endregion Fields

        #region Methods

        /** End of Criminal Entities **/
        /// <summary>
        /// Gets the <see cref="AASInfoEntity"/>
        /// </summary>
        /// <param name="aASInfo">The AASInfo.</param>
        /// <returns></returns>
        public static AASInfoEntity GetAASInfoEntity(AASInfo aASInfo)
        {
            AASInfoEntity aASInfoEntity = null;
            try
            {
                aASInfoEntity = Mapper.Map<AASInfo, AASInfoEntity>(aASInfo);
                aASInfoEntity.MAASLawDegree = Mapper.Map<MAASLawDegree, MAASLawDegreeEntity>(aASInfo.MAASLawDegree);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAASInfoEntity", ex);
                throw;
            }
            return aASInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="ADMInfoEntity"/> from <see cref="ADMInfo"/> input.
        /// </summary>
        /// <param name="aDMInfo"><see cref="ADMInfo"/></param>
        /// <returns>Returns <see cref="ADMInfoEntity"/>, else null.</returns>
        public static ADMInfoEntity GetADMInfoEntity(ADMInfo aDMInfo)
        {
            ADMInfoEntity aDMInfoEntity = null;

            try
            {
                if (aDMInfo != null)
                {
                    aDMInfoEntity = Mapper.Map<ADMInfo, ADMInfoEntity>(aDMInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetADMInfoEntity", ex);
                throw;
            }

            return aDMInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="BankruptcyInfoEntity"/> from <see cref="BankruptcyInfo"/> input.
        /// </summary>
        /// <param name="bankruptcyInfo"><see cref="BankruptcyInfo"/></param>
        /// <returns>Returns <see cref="BankruptcyInfoEntity"/>, else null.</returns>
        public static BankruptcyInfoEntity GetBankruptcyInfoEntity(BankruptcyInfo bankruptcyInfo)
        {
            BankruptcyInfoEntity bankruptcyInfoEntity = null;

            try
            {
                if (bankruptcyInfo != null)
                {
                    bankruptcyInfoEntity = Mapper.Map<BankruptcyInfo, BankruptcyInfoEntity>(bankruptcyInfo);
                    bankruptcyInfoEntity.BankruptcyBasis = Mapper.Map<MBankruptcyBasis, MBankruptcyBasisEntity>(bankruptcyInfo.MBankruptcyBasis);
                    bankruptcyInfoEntity.BankruptcyType = Mapper.Map<MBankruptcyType, MBankruptcyTypeEntity>(bankruptcyInfo.MBankruptcyType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBankruptcyInfoEntity", ex);
                throw;
            }

            return bankruptcyInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="BankruptcyOtherDefDetailEntity"/> from <see cref="BankruptcyOtherDefDetail"/> input.
        /// </summary>
        /// <param name="bankruptcyOtherDefDetail"><see cref="BankruptcyOtherDefDetail"/></param>
        /// <returns>Returns <see cref="BankruptcyOtherDefDetailEntity"/>, else null.</returns>
        public static BankruptcyOtherDefDetailEntity GetBankruptcyOtherDefDetailEntity(BankruptcyOtherDefDetail bankruptcyOtherDefDetail)
        {
            BankruptcyOtherDefDetailEntity bankruptcyOtherDefDetailEntity = null;

            try
            {
                if (bankruptcyOtherDefDetail != null)
                {
                    bankruptcyOtherDefDetailEntity = Mapper.Map<BankruptcyOtherDefDetail, BankruptcyOtherDefDetailEntity>(bankruptcyOtherDefDetail);
                    bankruptcyOtherDefDetailEntity.MCompanyIdType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(bankruptcyOtherDefDetail.MBODDCompanyIdType);
                    bankruptcyOtherDefDetailEntity.MCountryOfRegistration = Mapper.Map<MCountry, MCountryEntity>(bankruptcyOtherDefDetail.MBODDCountryOfRegistration);
                    bankruptcyOtherDefDetailEntity.MEntityType = Mapper.Map<MEntityType, MEntityTypeEntity>(bankruptcyOtherDefDetail.MEntityType);
                    bankruptcyOtherDefDetailEntity.MIdCountry = Mapper.Map<MCountry, MCountryEntity>(bankruptcyOtherDefDetail.MBODDIdCountry);
                    bankruptcyOtherDefDetailEntity.MPersonIdGroup = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(bankruptcyOtherDefDetail.MPersonIDGroup);
                    bankruptcyOtherDefDetailEntity.MPersonIdType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(bankruptcyOtherDefDetail.MBODDPersonIdType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBankruptcyOtherDefDetailEntity", ex);
                throw;
            }

            return bankruptcyOtherDefDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="BillOfSaleInfoEntity"/> from <see cref="BillOfSaleInfo"/> input.
        /// </summary>
        /// <param name="billOfSaleInfo"><see cref="BillOfSaleInfo"/></param>
        /// <returns>Returns <see cref="BillOfSaleInfoEntity"/>, else null.</returns>
        public static BillOfSaleInfoEntity GetBillOfSaleInfoEntity(BillOfSaleInfo billOfSaleInfo)
        {
            BillOfSaleInfoEntity billOfSaleInfoEntity = null;
            try
            {
                if (billOfSaleInfo != null)
                {
                    billOfSaleInfoEntity = Mapper.Map<BillOfSaleInfo, BillOfSaleInfoEntity>(billOfSaleInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBillOfSaleInfoEntity", ex);
                throw;
            }
            return billOfSaleInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="BOTDetails"/>
        /// </summary>
        /// <param name="bOTDetailEntity">The BOTDetailEntity.</param>
        /// <returns></returns>
        public static BOTDetailEntity GetBOTDetails(BOTDetails bOTDetails)
        {
            BOTDetailEntity bOTDetailEntity = null;
            try
            {
                bOTDetailEntity = Mapper.Map<BOTDetails, BOTDetailEntity>(bOTDetails);
                bOTDetailEntity.MBasisOfTaxationType = Mapper.Map<MBasisOfTaxationType, MBasisOfTaxationTypeEntity>(bOTDetails.MBasisOfTaxationType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBOTDetails", ex);
                throw;
            }
            return bOTDetailEntity;
        }

        /// <summary>
        /// Method returns the <see cref="ICaseSpecific"/> tagged entity from <see cref="ICaseSpecificEntity"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="ICaseSpecificEntity"/> type</typeparam>
        /// <param name="caseSpecificEntity"><see cref="ICaseSpecificEntity"/> object.</param>
        /// <returns>Returns the <see cref="ICaseSpecificEntity"/></returns>
        public static ICaseSpecificEntity GetCaseSpecificEntity<T>(T caseSpecificEntity)
        {
            try
            {
                if (caseSpecificEntity.GetType().Equals(typeof(ADMInfo)))
                    return (GetADMInfoEntity(caseSpecificEntity as ADMInfo));

                else if (caseSpecificEntity.GetType().Equals(typeof(BankruptcyInfo)))
                    return (GetBankruptcyInfoEntity(caseSpecificEntity as BankruptcyInfo));

                else if (caseSpecificEntity.GetType().Equals(typeof(BankruptcyOtherDefDetail)))
                    return (GetBankruptcyOtherDefDetailEntity(caseSpecificEntity as BankruptcyOtherDefDetail));

                else if (caseSpecificEntity.GetType().Equals(typeof(BillOfSaleInfo)))
                    return (GetBillOfSaleInfoEntity(caseSpecificEntity as BillOfSaleInfo));

                else if (caseSpecificEntity.GetType().Equals(typeof(CWUInfo)))
                    return (GetCWUInfoEntity(caseSpecificEntity as CWUInfo));

                else if (caseSpecificEntity.GetType().Equals(typeof(DCACAInfo)))
                    return (GetDCACAInfoEntity(caseSpecificEntity as DCACAInfo));

                else if (caseSpecificEntity.GetType().Equals(typeof(ChargeInfo)))
                    return (GetChargeInfoEntity(caseSpecificEntity as ChargeInfo));

                else if (caseSpecificEntity.GetType().Equals(typeof(CriminalInfo)))
                    return (GetCriminalInfoEntity(caseSpecificEntity as CriminalInfo));

                else if (caseSpecificEntity.GetType().Equals(typeof(OffenceInfo)))
                    return (GetOffenceInfoEntity(caseSpecificEntity as OffenceInfo));

                else if (caseSpecificEntity.GetType().Equals(typeof(DrugInfo)))
                    return (GetDrugInfoEntity(caseSpecificEntity as DrugInfo));

                else if (caseSpecificEntity.GetType().Equals(typeof(SentenceInfo)))
                    return (GetSentenceInfoEntity(caseSpecificEntity as SentenceInfo));

                else if (caseSpecificEntity.GetType().Equals(typeof(CriminalOtherOrderInfo)))
                    return (GetCriminalOtherOrderInfoEntity(caseSpecificEntity as CriminalOtherOrderInfo));

                else if (caseSpecificEntity.GetType().Equals(typeof(InvestigatingOfficerInfo)))
                    return (GetInvestigatingOfficerInfoEntity(caseSpecificEntity as InvestigatingOfficerInfo));

                else if (caseSpecificEntity.GetType().Equals(typeof(RCriminalLegislationInfo)))
                    return (GetRCriminalLegislationInfoEntity(caseSpecificEntity as RCriminalLegislationInfo));

                else if (caseSpecificEntity.GetType().Equals(typeof(WOEMOMSCTInfo)))
                    return GetWOEMOMSCTInfoEntity(caseSpecificEntity as WOEMOMSCTInfo);

                else if (caseSpecificEntity.GetType().Equals(typeof(DCACAOriginatingCasePartyInfo)))
                    return GetDCACAOriginatingCasePartyInfoEntity(caseSpecificEntity as DCACAOriginatingCasePartyInfo);

                else if (caseSpecificEntity.GetType().Equals(typeof(RASInfo)))
                    return GetRASInfoEntity(caseSpecificEntity as RASInfo);

                else if (caseSpecificEntity.GetType().Equals(typeof(PBPADetails)))
                    return GetPBPADetailEntity(caseSpecificEntity as PBPADetails);

                else if (caseSpecificEntity.GetType().Equals(typeof(PBSupNExm)))
                    return GetPBSupNExmEntity(caseSpecificEntity as PBSupNExm);

                else if (caseSpecificEntity.GetType().Equals(typeof(PBAdminBond)))
                    return GetPBAdminBondEntity(caseSpecificEntity as PBAdminBond);

                else if (caseSpecificEntity.GetType().Equals(typeof(CaseRegister )))
                    return GetCaseRegisterEntity(caseSpecificEntity as CaseRegister);

                else if (caseSpecificEntity.GetType().Equals(typeof(CaseRegisterHistory)))
                    return GetCaseRegisterHistoryEntity(caseSpecificEntity as CaseRegisterHistory);

                else if (caseSpecificEntity.GetType().Equals(typeof(DashboardCaseMilestoneDetail)))
                    return GetDashboardCaseMilestoneDetailEntity(caseSpecificEntity as DashboardCaseMilestoneDetail);

                else if (caseSpecificEntity.GetType().Equals(typeof(DashboardCaseMilestoneDetailHistory)))
                    return GetDashboardCaseMilestoneDetailHistoryEntity(caseSpecificEntity as DashboardCaseMilestoneDetailHistory);

                else if (caseSpecificEntity.GetType().Equals(typeof(JMChecklistInfo)))
                    return GetJMChecklistInfoEntity(caseSpecificEntity as JMChecklistInfo);

                else if (caseSpecificEntity.GetType().Equals(typeof(JMOtherInfo)))
                    return GetJMOtherInfoEntity(caseSpecificEntity as JMOtherInfo);

                else if (caseSpecificEntity.GetType().Equals(typeof(DirectionDetails)))
                    return GetDirectionDetailsEntity(caseSpecificEntity as DirectionDetails);

                else
                    throw new ArgumentNullException("The referenced object is invalid or not implemented at GetCaseSpecificEntity method in CaseSpecificMapper.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCaseSpecificEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the <see cref="ChargeInfoEntity"/> from <see cref="ChargeInfo"/> input.
        /// </summary>
        /// <param name="chargeInfo"><see cref="ChargeInfo"/></param>
        /// <returns>Returns <see cref="ChargeInfoEntity"/>, else null.</returns>
        public static ChargeInfoEntity GetChargeInfoEntity(ChargeInfo chargeInfo)
        {
            ChargeInfoEntity chargeInfoEntity = null;

            try
            {
                if (chargeInfo != null)
                {
                    chargeInfoEntity = Mapper.Map<ChargeInfo, ChargeInfoEntity>(chargeInfo);
                    chargeInfoEntity.MChargeType = Mapper.Map<MChargeType, MChargeTypeEntity>(chargeInfo.MChargeType);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetChargeInfoEntity", ex);
                throw;
            }

            return chargeInfoEntity;
        }

        /** Start of Criminal Entities**/
        /// <summary>
        /// Gets the <see cref="CriminalInfoEntity"/> from <see cref="CriminalInfo"/> input.
        /// </summary>
        /// <param name="criminalInfo"><see cref="CriminalInfo"/></param>
        /// <returns>Returns <see cref="CriminalInfoEntity"/>, else null.</returns>
        public static CriminalInfoEntity GetCriminalInfoEntity(CriminalInfo criminalInfo)
        {
            CriminalInfoEntity criminalInfoEntity = null;

            try
            {
                if (criminalInfo != null)
                {
                    criminalInfoEntity = Mapper.Map<CriminalInfo, CriminalInfoEntity>(criminalInfo);
                    criminalInfoEntity.MNatureOfAppeal = Mapper.Map<MNatureOfAppeal, MNatureOfAppealEntity>(criminalInfo.MNatureOfAppeal);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalInfoEntity", ex);
                throw;
            }

            return criminalInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CriminalOtherOrderInfoEntity"/> from <see cref="CriminalOtherOrderInfo"/> input.
        /// </summary>
        /// <param name="CriminalOtherOrderInfo"><see cref="CriminalOtherOrderInfo"/></param>
        /// <returns>Returns <see cref="CriminalOtherOrderInfoEntity"/>, else null.</returns>
        public static CriminalOtherOrderInfoEntity GetCriminalOtherOrderInfoEntity(CriminalOtherOrderInfo criminalOtherOrderInfo)
        {
            CriminalOtherOrderInfoEntity criminalOtherOrderInfoEntity = null;

            try
            {
                if (criminalOtherOrderInfo != null)
                {
                    criminalOtherOrderInfoEntity = Mapper.Map<CriminalOtherOrderInfo, CriminalOtherOrderInfoEntity>(criminalOtherOrderInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCriminalOtherOrderInfoEntity", ex);
                throw;
            }

            return criminalOtherOrderInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CWUCheckListInfoEntity"/> from <see cref="CWUChecklistInfo"/> input.
        /// </summary>
        /// <param name="cWUChecklistInfo"><see cref="CWUChecklistInfo"/></param>
        /// <returns>Returns <see cref="CWUCheckListInfoEntity"/>, else null.</returns>
        public static CWUCheckListInfoEntity GetCWUCheckListInfoEntity(CWUChecklistInfo cWUChecklistInfo)
        {
            CWUCheckListInfoEntity cWUCheckListInfoEntity = null;

            try
            {
                if (cWUChecklistInfo != null)
                {
                    cWUCheckListInfoEntity = Mapper.Map<CWUChecklistInfo, CWUCheckListInfoEntity>(cWUChecklistInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCWUCheckListInfoEntity", ex);
                throw;
            }

            return cWUCheckListInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="CWUInfoEntity"/> from <see cref="CWUInfo"/> input.
        /// </summary>
        /// <param name="cWUInfo"><see cref="CWUInfo"/></param>
        /// <returns>Returns <see cref="CWUInfoEntity"/>, else null.</returns>
        public static CWUInfoEntity GetCWUInfoEntity(CWUInfo cWUInfo)
        {
            CWUInfoEntity cWUInfoEntity = null;

            try
            {
                if (cWUInfo != null)
                {
                    cWUInfoEntity = Mapper.Map<CWUInfo, CWUInfoEntity>(cWUInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCWUInfoEntity", ex);
                throw;
            }

            return cWUInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="DCACAInfoEntity"/> from <see cref="DCACAInfo"/> input.
        /// </summary>
        /// <param name="dCACAInfo"><see cref="DCACAInfo"/></param>
        /// <returns>Returns <see cref="DCACAInfoEntity"/>, else null.</returns>
        public static DCACAInfoEntity GetDCACAInfoEntity(DCACAInfo dCACAInfo)
        {
            DCACAInfoEntity dCACAInfoEntity = null;

            try
            {
                if (dCACAInfo != null)
                {
                    dCACAInfoEntity = Mapper.Map<DCACAInfo, DCACAInfoEntity>(dCACAInfo);
                    dCACAInfoEntity.MDesignation = Mapper.Map<MDesignation, MDesignationEntity>(dCACAInfo.MDesignation);
                    dCACAInfoEntity.MCoram = Mapper.Map<MCoram, MCoramEntity>(dCACAInfo.MCoram);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDCACAInfoEntity", ex);
                throw;
            }

            return dCACAInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="DrugInfoEntity"/> from <see cref="DrugInfo"/> input.
        /// </summary>
        /// <param name="drugInfo"><see cref="DrugInfo"/></param>
        /// <returns>Returns <see cref="DrugInfoEntity"/>, else null.</returns>
        public static DrugInfoEntity GetDrugInfoEntity(DrugInfo drugInfo)
        {
            DrugInfoEntity drugInfoEntity = null;

            try
            {
                if (drugInfo != null)
                {
                    drugInfoEntity = Mapper.Map<DrugInfo, DrugInfoEntity>(drugInfo);
                    drugInfoEntity.MDrug = Mapper.Map<MDrug, MDrugEntity>(drugInfo.MDrug);
                    drugInfoEntity.MModeOfTrafficking = Mapper.Map<MModeOfTrafficking, MModeOfTraffickingEntity>(drugInfo.MModeOfTrafficking);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDrugInfoEntity", ex);
                throw;
            }

            return drugInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="InvestigatingOfficerInfoEntity"/> from <see cref="InvestigatingOfficerInfo"/> input.
        /// </summary>
        /// <param name="InvestigatingOfficerInfo"><see cref="InvestigatingOfficerInfo"/></param>
        /// <returns>Returns <see cref="InvestigatingOfficerInfoEntity"/>, else null.</returns>
        public static InvestigatingOfficerInfoEntity GetInvestigatingOfficerInfoEntity(InvestigatingOfficerInfo investigatingOfficerInfo)
        {
            InvestigatingOfficerInfoEntity investigatingOfficerInfoEntity = null;

            try
            {
                if (investigatingOfficerInfo != null)
                {
                    investigatingOfficerInfoEntity = Mapper.Map<InvestigatingOfficerInfo, InvestigatingOfficerInfoEntity>(investigatingOfficerInfo);
                    investigatingOfficerInfoEntity.MIOOrganisation = Mapper.Map<MIOOrganisation, MIOOrganisationEntity>(investigatingOfficerInfo.MIOOrganisation);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetInvestigatingOfficerInfoEntity", ex);
                throw;
            }

            return investigatingOfficerInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="OffenceInfoEntity"/> from <see cref="OffenceInfo"/> input.
        /// </summary>
        /// <param name="offenceInfo"><see cref="OffenceInfo"/></param>
        /// <returns>Returns <see cref="OffenceInfoEntity"/>, else null.</returns>
        public static OffenceInfoEntity GetOffenceInfoEntity(OffenceInfo offenceInfo)
        {
            OffenceInfoEntity offenceInfoEntity = null;

            try
            {
                if (offenceInfo != null)
                {
                    offenceInfoEntity = Mapper.Map<OffenceInfo, OffenceInfoEntity>(offenceInfo);
                    offenceInfoEntity.MNatureOfOffence = Mapper.Map<MNatureOfOffence, MNatureOfOffenceEntity>(offenceInfo.MNatureOfOffence);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetOffenceInfoEntity", ex);
                throw;
            }

            return offenceInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="OSInfoEntity"/> from <see cref="OSInfo"/> input.
        /// </summary>
        /// <param name="oSInfo"><see cref="OSInfo"/></param>
        /// <returns>Returns <see cref="OSInfoEntity"/>, else null.</returns>
        public static OSInfoEntity GetOSInfoEntity(OSInfo oSInfo)
        {
            OSInfoEntity oSInfoEntity = null;

            try
            {
                if (oSInfo != null)
                {
                    oSInfoEntity = Mapper.Map<OSInfo, OSInfoEntity>(oSInfo);
                    oSInfoEntity.CompanyRegType = Mapper.Map<MEntityType, MEntityTypeEntity>(oSInfo.MEntityType);
                    oSInfoEntity.CountryOfIssue = Mapper.Map<MCountry, MCountryEntity>(oSInfo.MCountry);
                    oSInfoEntity.NatureOfDeputyShip = Mapper.Map<MNatureOfDeputyShip, MNatureofDeputyshipEntity>(oSInfo.MNatureOfDeputyShip);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetOSInfoEntity", ex);
                throw;
            }

            return oSInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="OSJudicialManagerDetailsEntity"/>
        /// </summary>
        /// <param name="oSJudicialManagerDetails">The OSJudicialManagerDetails.</param>
        /// <returns></returns>
        public static OSJudicialManagerDetailsEntity GetOSJudicialManagerDetailEntity(OSJudicialManagerDetails oSJudicialManagerDetails)
        {
            OSJudicialManagerDetailsEntity oSJudicialManagerDetailsEntity = null;
            try
            {
                oSJudicialManagerDetailsEntity = Mapper.Map<OSJudicialManagerDetails, OSJudicialManagerDetailsEntity>(oSJudicialManagerDetails);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOSJudicialManagerDetailEntity", ex);
                throw;
            }
            return oSJudicialManagerDetailsEntity;
        }

        /// <summary>
        /// Gets the <see cref="OSJudicialManagerDetails"/>
        /// </summary>
        /// <param name="oSJudicialManagerDetailsEntity">The OSJudicialManagerDetailsEntity.</param>
        /// <returns></returns>
        public static OSMADetailsEntity GetOSMADetailsEntity(OSMADetails oSMADetails)
        {
            OSMADetailsEntity oSMADetailsEntity = null;
            try
            {
                oSMADetailsEntity = Mapper.Map<OSMADetails, OSMADetailsEntity>(oSMADetails);
                oSMADetailsEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(oSMADetails.MCountry);
                oSMADetailsEntity.MPropertyType = Mapper.Map<MPropertyType, MPropertyTypeEntity>(oSMADetails.MPropertyType);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOSMADetailsEntity", ex);
                throw;
            }
            return oSMADetailsEntity;
        }

        /// <summary>
        /// Gets the <see cref="PBBeneficiaryDetailEntity"/>
        /// </summary>
        /// <param name="pBBeneficiaryDetails">The PBBeneficiaryDetails.</param>
        /// <returns></returns>
        public static PBBeneficiaryDetailEntity GetPBBeneficiaryDetailEntity(PBBeneficiaryDetails pBBeneficiaryDetails)
        {
            PBBeneficiaryDetailEntity pBBeneficiaryDetailEntity = null;
            try
            {
                pBBeneficiaryDetailEntity = Mapper.Map<PBBeneficiaryDetails, PBBeneficiaryDetailEntity>(pBBeneficiaryDetails);
                pBBeneficiaryDetailEntity.MGender = Mapper.Map<MGender, MGenderEntity>(pBBeneficiaryDetails.MGender);
                pBBeneficiaryDetailEntity.MRelationship = Mapper.Map<MRelationship, MRelationshipEntity>(pBBeneficiaryDetails.MRelationship);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPBBeneficiaryDetailEntity", ex);
                throw;
            }
            return pBBeneficiaryDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="PBCoAdminDetailEntity"/>
        /// </summary>
        /// <param name="pBCoAdminDetails">The PBCoAdminDetails.</param>
        /// <returns></returns>
        public static PBCoAdminDetailEntity GetPBCoAdminDetailEntity(PBCoAdminDetails pBCoAdminDetails)
        {
            PBCoAdminDetailEntity pBCoAdminDetailEntity = null;
            try
            {
                pBCoAdminDetailEntity = Mapper.Map<PBCoAdminDetails, PBCoAdminDetailEntity>(pBCoAdminDetails);
                pBCoAdminDetailEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(pBCoAdminDetails.MCountry);
                pBCoAdminDetailEntity.MGender = Mapper.Map<MGender, MGenderEntity>(pBCoAdminDetails.MGender);
                pBCoAdminDetailEntity.MPersonIDGroup = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(pBCoAdminDetails.MPersonIDGroup);
                pBCoAdminDetailEntity.MPersonIDType = Mapper.Map<MPersonIDType, MPersonIDTypeEntity>(pBCoAdminDetails.MPersonIDType);
                pBCoAdminDetailEntity.MRelationship = Mapper.Map<MRelationship, MRelationshipEntity>(pBCoAdminDetails.MRelationship);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPBCoAdminDetails", ex);
                throw;
            }
            return pBCoAdminDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="PBExecutorDetailEntity"/>
        /// </summary>
        /// <param name="pBExecutorDetails">The PBExecutorDetails.</param>
        /// <returns></returns>
        public static PBExecutorDetailEntity GetPBExecutorDetailEntity(PBExecutorDetails pBExecutorDetails)
        {
            PBExecutorDetailEntity pBExecutorDetailEntity = null;
            try
            {
                pBExecutorDetailEntity = Mapper.Map<PBExecutorDetails, PBExecutorDetailEntity>(pBExecutorDetails);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPBExecutorDetails", ex);
                throw;
            }
            return pBExecutorDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="PBExecutorDetailEntity"/>
        /// </summary>
        /// <param name="pBExecutorDetails">The PBExecutorDetails.</param>
        /// <returns></returns>
        public static PBPrevGrantDetailEntity GetPBPrevGrantDetailEntity(PBPrevGrantDetails pBPrevGrantDetails)
        {
            PBPrevGrantDetailEntity pBPrevGrantDetailEntity = null;
            try
            {
                pBPrevGrantDetailEntity = Mapper.Map<PBPrevGrantDetails, PBPrevGrantDetailEntity>(pBPrevGrantDetails);
                pBPrevGrantDetailEntity.MCourtType = Mapper.Map<MCourtType, MCourtTypeEntity>(pBPrevGrantDetails.MCourtType);
                pBPrevGrantDetailEntity.MGender = Mapper.Map<MGender, MGenderEntity>(pBPrevGrantDetails.MGender);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPBExecutorDetails", ex);
                throw;
            }
            return pBPrevGrantDetailEntity;
        }

        /// <summary>
        /// Gets the <see cref="PBWillCodicilEntity"/>
        /// </summary>
        /// <param name="pBWillCodicil">The PBWillCodicil.</param>
        /// <returns></returns>
        public static PBWillCodicilEntity GetPBWillCodicilEntity(PBWillCodicil pBWillCodicil)
        {
            PBWillCodicilEntity pBWillCodicilEntity = null;
            try
            {
                pBWillCodicilEntity = Mapper.Map<PBWillCodicil, PBWillCodicilEntity>(pBWillCodicil);
                pBWillCodicilEntity.MDocCode = Mapper.Map<MDocCode, MDocCodeEntity>(pBWillCodicil.MDocCode);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPBWillCodicilEntity", ex);
                throw;
            }
            return pBWillCodicilEntity;
        }

        /// <summary>
        /// Gets the <see cref="PracticeOfLawInfoEntity"/>
        /// </summary>
        /// <param name="practiceOfLawInfo">The PracticeOfLawInfo.</param>
        /// <returns></returns>
        public static PracticeOfLawInfoEntity GetPracticeOfLawInfoEntity(PracticeOfLawInfo practiceOfLawInfo)
        {
            PracticeOfLawInfoEntity practiceOfLawInfoEntity = null;
            try
            {
                practiceOfLawInfoEntity = Mapper.Map<PracticeOfLawInfo, PracticeOfLawInfoEntity>(practiceOfLawInfo);
                practiceOfLawInfoEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(practiceOfLawInfo.MCountry);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPracticeOfLawInfoEntity", ex);
                throw;
            }
            return practiceOfLawInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="PracticeTrainingPeriodInfoEntity"/>
        /// </summary>
        /// <param name="practiceTrainingPeriodInfo">The PracticeTrainingPeriodInfo.</param>
        /// <returns></returns>
        public static PracticeTrainingPeriodInfoEntity GetPracticeTrainingPeriodInfoEntity(PracticeTrainingPeriodInfo practiceTrainingPeriodInfo)
        {
            PracticeTrainingPeriodInfoEntity practiceTrainingPeriodInfoEntity = null;
            try
            {
                practiceTrainingPeriodInfoEntity = Mapper.Map<PracticeTrainingPeriodInfo, PracticeTrainingPeriodInfoEntity>(practiceTrainingPeriodInfo);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPracticeTrainingPeriodInfoEntity", ex);
                throw;
            }
            return practiceTrainingPeriodInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="ProbateInfoEntity"/>
        /// </summary>
        /// <param name="probateInfo">The ProbateInfo.</param>
        /// <returns></returns>
        public static ProbateInfoEntity GetProbateInfoEntity(ProbateInfo probateInfo)
        {
            ProbateInfoEntity probateInfoEntity = null;
            try
            {
                probateInfoEntity = Mapper.Map<ProbateInfo, ProbateInfoEntity>(probateInfo);
                probateInfoEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(probateInfo.MCountry);
                probateInfoEntity.MProbateNature = Mapper.Map<MProbateNature, MProbateNatureEntity>(probateInfo.MProbateNature);
                probateInfoEntity.MProbateNatureGroup = Mapper.Map<MProbateNatureGroup, MProbateNatureGroupEntity>(probateInfo.MProbateNatureGroup);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetProbateInfoEntity", ex);
                throw;
            }
            return probateInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="RCriminalLegislationInfoEntity"/> from <see cref="InvestigatingOfficerInfo"/> input.
        /// </summary>
        /// <param name="InvestigatingOfficerInfo"><see cref="InvestigatingOfficerInfo"/></param>
        /// <returns>Returns <see cref="RCriminalLegislationInfoEntity"/>, else null.</returns>
        public static RCriminalLegislationInfoEntity GetRCriminalLegislationInfoEntity(RCriminalLegislationInfo rCriminalLegislationInfo)
        {
            RCriminalLegislationInfoEntity rCriminalLegislationInfoEntity = null;

            try
            {
                if (rCriminalLegislationInfo != null)
                {
                    rCriminalLegislationInfoEntity = Mapper.Map<RCriminalLegislationInfo, RCriminalLegislationInfoEntity>(rCriminalLegislationInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRCriminalLegislationInfoEntity", ex);
                throw;
            }

            return rCriminalLegislationInfoEntity;
        }

        public static SentenceCriminalOrderInfoEntity GetSentenceCriminalOrderInfoEntity(SentenceCriminalOrderInfo sentenceCriminalOrderInfo)
        {
            SentenceCriminalOrderInfoEntity sentenceCriminalOrderInfoEntity = null;
            try
            {
                sentenceCriminalOrderInfoEntity = Mapper.Map<SentenceCriminalOrderInfo, SentenceCriminalOrderInfoEntity>(sentenceCriminalOrderInfo);
                sentenceCriminalOrderInfoEntity.MCriminalOrder = Mapper.Map<MCriminalOrder, MCriminalOrderEntity>(sentenceCriminalOrderInfo.MCriminalOrder);
                sentenceCriminalOrderInfoEntity.MSentence = Mapper.Map<MSentence, MSentenceEntity>(sentenceCriminalOrderInfo.MSentence);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSentenceCriminalOrderInfoEntity", ex);
                throw;
            }
            return sentenceCriminalOrderInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="SentenceInfoEntity"/> from <see cref="SentenceInfo"/> input.
        /// </summary>
        /// <param name="sentenceInfo"><see cref="SentenceInfo"/></param>
        /// <returns>Returns <see cref="SentenceInfoEntity"/>, else null.</returns>
        public static SentenceInfoEntity GetSentenceInfoEntity(SentenceInfo sentenceInfo)
        {
            SentenceInfoEntity sentenceInfoEntity = null;
            try
            {
                if (sentenceInfo != null)
                {
                    sentenceInfoEntity = Mapper.Map<SentenceInfo, SentenceInfoEntity>(sentenceInfo);
                    sentenceInfoEntity.MDrivingLicense = Mapper.Map<MDrivingLicense, MDrivingLicenseEntity>(sentenceInfo.MDrivingLicense);
                    sentenceInfoEntity.MCriminalOrder = Mapper.Map<MCriminalOrder, MCriminalOrderEntity>(sentenceInfo.MCriminalOrder);
                    sentenceInfoEntity.MSentence = Mapper.Map<MSentence, MSentenceEntity>(sentenceInfo.MSentence);
                    sentenceInfoEntity.MCourtType = Mapper.Map<MCourtType, MCourtTypeEntity>(sentenceInfo.MCourtType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSentenceInfoEntity", ex);
                throw;
            }

            return sentenceInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="TaxationClaimEntity"/>
        /// </summary>
        /// <param name="taxationClaim">The TaxationClaim.</param>
        /// <returns></returns>
        public static TaxationClaimEntity GetTaxationClaimEntity(TaxationClaim taxationClaim)
        {
            TaxationClaimEntity taxationClaimEntity = null;
            try
            {
                taxationClaimEntity = Mapper.Map<TaxationClaim, TaxationClaimEntity>(taxationClaim);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetTaxationClaimEntity", ex);
                throw;
            }
            return taxationClaimEntity;
        }

        /// <summary>
        /// Gets the <see cref="TaxationInfoEntity"/>
        /// </summary>
        /// <param name="taxationInfo">The TaxationInfo.</param>
        /// <returns></returns>
        public static TaxationInfoEntity GetTaxationInfoEntity(TaxationInfo taxationInfo)
        {
            TaxationInfoEntity taxationInfoEntity = null;
            try
            {
                taxationInfoEntity = Mapper.Map<TaxationInfo, TaxationInfoEntity>(taxationInfo);
                taxationInfoEntity.MBillNature = Mapper.Map<MBillNature, MBillNatureEntity>(taxationInfo.MBillNature);
                taxationInfoEntity.MBillType = Mapper.Map<MBillType, MBillTypeEntity>(taxationInfo.MBillType);
                taxationInfoEntity.MCurrency = Mapper.Map<MCurrency, MCurrencyEntity>(taxationInfo.MCurrency);
                taxationInfoEntity.MNatureOfWork = Mapper.Map<MNatureOfWork, MNatureOfWorkEntity>(taxationInfo.MNatureOfWork);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetTaxationInfoEntity", ex);
                throw;
            }
            return taxationInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="WOEMOMSCTInfoEntity"/>
        /// </summary>
        /// <param name="woeMOMSCTInfo">The WOEMOMSCTInfo.</param>
        /// <returns></returns>
        public static WOEMOMSCTInfoEntity GetWOEMOMSCTInfoEntity(WOEMOMSCTInfo woeMOMSCTInfo)
        {
            WOEMOMSCTInfoEntity woeMOMSCTInfoEntity = null;
            try
            {
                woeMOMSCTInfoEntity = Mapper.Map<WOEMOMSCTInfo, WOEMOMSCTInfoEntity>(woeMOMSCTInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetWOEMOMSCTInfoEntity", ex);
                throw;
            }
            return woeMOMSCTInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="WOSInfoEntity"/>
        /// </summary>
        /// <param name="wOSInfo">The WOSInfo.</param>
        /// <returns></returns>
        public static WOSInfoEntity GetWOSInfoEntity(WOSInfo wOSInfo)
        {
            WOSInfoEntity wOSInfoEntity = null;
            try
            {
                wOSInfoEntity = Mapper.Map<WOSInfo, WOSInfoEntity>(wOSInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at WOSInfoEntity", ex);
                throw;
            }
            return wOSInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="WOSInfoEntity"/>
        /// </summary>
        /// <param name="wOSInfo">The WOSInfo.</param>
        /// <returns></returns>
        public static DCACAOriginatingCasePartyInfoEntity GetDCACAOriginatingCasePartyInfoEntity(DCACAOriginatingCasePartyInfo dCACAOriginatingCasePartyInfo)
        {
            DCACAOriginatingCasePartyInfoEntity dCACAOriginatingCasePartyInfoEntity = null;
            try
            {
                dCACAOriginatingCasePartyInfoEntity = Mapper.Map<DCACAOriginatingCasePartyInfo, DCACAOriginatingCasePartyInfoEntity>(dCACAOriginatingCasePartyInfo);
                dCACAOriginatingCasePartyInfoEntity.MPartyType = Mapper.Map<MPartyType, MPartyTypeEntity>(dCACAOriginatingCasePartyInfo.MPartyType);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDCACAOriginatingCasePartyInfoEntity", ex);
                throw;
            }
            return dCACAOriginatingCasePartyInfoEntity;
        }

        /// <summary>
        /// Gets the <see cref="RARASInfoEntity"/> from <see cref="RARASInfo"/> input.
        /// </summary>
        /// <param name="rARASInfo"><see cref="RARASInfo"/></param>
        /// <returns>Returns <see cref="RARASInfoEntity"/>, else null.</returns>
        public static RASInfoEntity GetRASInfoEntity(RASInfo rASInfo)
        {
            RASInfoEntity rASInfoEntity = null;

            try
            {
                if (rASInfo != null)
                {
                    rASInfoEntity = Mapper.Map<RASInfo, RASInfoEntity>(rASInfo);
                    rASInfoEntity.MDesignation = Mapper.Map<MDesignation, MDesignationEntity>(rASInfo.MDesignation);
                    rASInfoEntity.MCoram = Mapper.Map<MCoram, MCoramEntity>(rASInfo.MCoram);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRASInfoEntity", ex);
                throw;
            }

            return rASInfoEntity;
        }

        /// <summary>
        /// Gets the bankruptcy debt info entity.
        /// </summary>
        /// <param name="bankruptcyDebtInfo">The bankruptcy debt info.</param>
        /// <returns></returns>
        public static BankruptcyDebtInfoEntity GetBankruptcyDebtInfoEntity(BankruptcyDebtInfo bankruptcyDebtInfo)
        {
            BankruptcyDebtInfoEntity bankruptcyDebtInfoEntity = null;

            try
            {
                if (bankruptcyDebtInfo != null)
                {
                    bankruptcyDebtInfoEntity = Mapper.Map<BankruptcyDebtInfo, BankruptcyDebtInfoEntity>(bankruptcyDebtInfo);
                    bankruptcyDebtInfoEntity.BKYDebtCurrencyCode = Mapper.Map<MCurrency, MCurrencyEntity>(bankruptcyDebtInfo.MCurrency);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBankruptcyDebtInfoEntity", ex);
                throw;
            }

            return bankruptcyDebtInfoEntity;
        }

        public static PBPADetailEntity GetPBPADetailEntity(PBPADetails pBPADetails)
        {
            PBPADetailEntity pBPADetailEntity = null;

            try
            {
                if (pBPADetails != null)
                {
                    pBPADetailEntity = Mapper.Map<PBPADetails, PBPADetailEntity>(pBPADetails);
                    pBPADetailEntity.MGenderEntity= Mapper.Map<MGender, MGenderEntity>(pBPADetails.MGender);
                    pBPADetailEntity.MApplicantCapacityEntity = Mapper.Map<MApplicantCapacity, MApplicantCapacityEntity>(pBPADetails.MApplicantCapacity);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPBPADetailEntity", ex);
                throw;
            }

            return pBPADetailEntity;
        }

        public static PBSupNExmEntity GetPBSupNExmEntity(PBSupNExm pBSupNExm)
        {
            PBSupNExmEntity pBSupNExmEntity = null;

            try
            {
                if (pBSupNExm != null)
                {
                    pBSupNExmEntity = Mapper.Map<PBSupNExm, PBSupNExmEntity>(pBSupNExm);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPBSupNExmEntity", ex);
                throw;
            }

            return pBSupNExmEntity;
        }

        public static PBAdminBondEntity GetPBAdminBondEntity(PBAdminBond PBAdminBond)
        {
            PBAdminBondEntity PBAdminBondEntity = null;

            try
            {
                if (PBAdminBond != null)
                {
                    PBAdminBondEntity = Mapper.Map<PBAdminBond, PBAdminBondEntity>(PBAdminBond);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPBAdminBondEntity", ex);
                throw;
            }

            return PBAdminBondEntity;
        }

        public static CaseRegisterEntity GetCaseRegisterEntity(CaseRegister caseRegister)
        {
            CaseRegisterEntity caseRegisterEntity = null;
            try
            {
                if (caseRegister != null)
                {
                    caseRegisterEntity = Mapper.Map<CaseRegister, CaseRegisterEntity>(caseRegister);
                    caseRegisterEntity.MForumTypeEntity = Mapper.Map<MForumType, MForumTypeEntity>(caseRegister.MForumType);
                    caseRegisterEntity.MPartyStatusEntity = Mapper.Map<MPartyStatus, MPartyStatusEntity>(caseRegister.MPartyStatus);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseRegisterEntity", ex);
                throw;
            }
            return caseRegisterEntity;
        }

        public static CaseRegisterHistoryEntity GetCaseRegisterHistoryEntity(CaseRegisterHistory caseRegisterHistory)
        {
            CaseRegisterHistoryEntity caseRegisterHistoryEntity = null;
            try
            {
                if (caseRegisterHistory != null)
                {
                    caseRegisterHistoryEntity = Mapper.Map<CaseRegisterHistory, CaseRegisterHistoryEntity>(caseRegisterHistory);
                    caseRegisterHistoryEntity.MForumTypeEntity = Mapper.Map<MForumType, MForumTypeEntity>(caseRegisterHistory.MForumType);
                    caseRegisterHistoryEntity.MPartyStatusEntity = Mapper.Map<MPartyStatus, MPartyStatusEntity>(caseRegisterHistory.MPartyStatus);

                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaseRegisterHistoryEntity", ex);
                throw;
            }
            return caseRegisterHistoryEntity;
        }

        public static DashboardCaseMilestoneDetailEntity GetDashboardCaseMilestoneDetailEntity(DashboardCaseMilestoneDetail dashboardCaseMilestoneDetail)
        {
            DashboardCaseMilestoneDetailEntity dashboardCaseMilestoneDetailEntity = null;
            try
            {
                if (dashboardCaseMilestoneDetail != null)
                {
                    dashboardCaseMilestoneDetailEntity = Mapper.Map<DashboardCaseMilestoneDetail, DashboardCaseMilestoneDetailEntity>(dashboardCaseMilestoneDetail);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDashboardCaseMilestoneDetailEntity", ex);
                throw;
            }
            return dashboardCaseMilestoneDetailEntity;
        }

        public static DashboardCaseMilestoneDetailHistoryEntity GetDashboardCaseMilestoneDetailHistoryEntity(DashboardCaseMilestoneDetailHistory dashboardCaseMilestoneDetailHistory)
        {
            DashboardCaseMilestoneDetailHistoryEntity dashboardCaseMilestoneDetailHistoryEntity = null;
            try
            {
                if (dashboardCaseMilestoneDetailHistory != null)
                {
                    dashboardCaseMilestoneDetailHistoryEntity = Mapper.Map<DashboardCaseMilestoneDetailHistory, DashboardCaseMilestoneDetailHistoryEntity>(dashboardCaseMilestoneDetailHistory);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDashboardCaseMilestoneDetailHistoryEntity", ex);
                throw;
            }
            return dashboardCaseMilestoneDetailHistoryEntity;
        }

        public static CaveatInfoEntity GetCaveatInfoEntity(CaveatInfo caveatInfo)
        {
            CaveatInfoEntity caveatInfoEntity = null;
            try
            {
                if (caveatInfo != null)
                {
                    caveatInfoEntity = Mapper.Map<CaveatInfo, CaveatInfoEntity>(caveatInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaveatInfoEntity", ex);
                throw;
            }
            return caveatInfoEntity;
        }

        public static CaveatAAInfoEntity GetCaveatAAInfoEntity(CaveatAAInfo caveatAAInfo)
        {
            CaveatAAInfoEntity caveatAAInfoEntity = null;
            try
            {
                if (caveatAAInfo != null)
                {
                    caveatAAInfoEntity = Mapper.Map<CaveatAAInfo, CaveatAAInfoEntity>(caveatAAInfo);
                    caveatAAInfoEntity.MCountry = Mapper.Map<MCountry, MCountryEntity>(caveatAAInfo.MCountry);
                    caveatAAInfoEntity.MPersonIDGroup = Mapper.Map<MPersonIDGroup, MPersonIDGroupEntity>(caveatAAInfo.MPersonIDGroup);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCaveatAAInfoEntity", ex);
                throw;
            }
            return caveatAAInfoEntity;
        }

        public static JMChecklistInfoEntity GetJMChecklistInfoEntity(JMChecklistInfo jMChecklistInfo)
        {
            JMChecklistInfoEntity jMChecklistInfoEntity = null;

            try
            {
                jMChecklistInfoEntity = Mapper.Map<JMChecklistInfo, JMChecklistInfoEntity>(jMChecklistInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetJMChecklistInfoEntity", ex);
                throw;
            }

            return jMChecklistInfoEntity;
        }

        public static JMOtherInfoEntity GetJMOtherInfoEntity(JMOtherInfo jMOtherInfo)
        {
            JMOtherInfoEntity jMOtherInfoEntity = null;

            try
            {
                jMOtherInfoEntity = Mapper.Map<JMOtherInfo, JMOtherInfoEntity>(jMOtherInfo);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetJMOtherInfoEntity", ex);
                throw;
            }

            return jMOtherInfoEntity;
        }

        public static DirectionDetailsEntity GetDirectionDetailsEntity(DirectionDetails directionDetails)
        {
            DirectionDetailsEntity directionDetailsEntity = null;

            try
            {
                directionDetailsEntity = Mapper.Map<DirectionDetails, DirectionDetailsEntity>(directionDetails);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDirectionDetailsEntity", ex);
                throw;
            }

            return directionDetailsEntity;
        }

        #endregion Methods
    }
}