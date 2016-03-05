#region Header

/*****************************************************************************************************
* Description : This file represents a standard DocCaseParty entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: DocCasePartyEntity.cs
// Description: Represents a standard DocCaseParty entity.
// </summary>
// <copyright file= "DocCasePartyEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for DocCaseParty.
    /// It inherits from <see cref="AbstractDocCaseParty"/>
    /// </summary>
    [Serializable]
    public class DocCasePartyEntity : AbstractDocCaseParty, IDocumentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ApplicantCapacityRemarks field.
        /// </summary>
        /// <value>The applicant capacity remarks.</value>
        public String ApplicantCapacityRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BirthCountryRemarks field.
        /// </summary>
        /// <value>The birth country remarks.</value>
        public String BirthCountryRemarks
        {
            get;
            set;
        }

        public YesNo CapacityInd
        {
            get;
            set;
        }

        public String CapacityInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseInfoId field.
        /// </summary>
        /// <value>The case info id.</value>
        public string CaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the case party id.
        /// </summary>
        /// <value>The case party id.</value>
        public string CasePartyId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CompanyName field.
        /// </summary>
        /// <value>The name of the company.</value>
        public String CompanyName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ContactTypeInd field.
        /// </summary>
        /// <value>The contact type ind.</value>
        public ContactType ContactTypeInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfBirth field.
        /// </summary>
        /// <value>The date of birth.</value>
        public DateTime? DateOfBirth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfRegistration field.
        /// </summary>
        /// <value>The date of registration.</value>
        public DateTime? DateOfRegistration
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateofService field.
        /// </summary>
        /// <value>The date of service.</value>
        public DateTime? DateofService
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DialectRemarks field.
        /// </summary>
        /// <value>The dialect remarks.</value>
        public String DialectRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DisablePersonInd field.
        /// </summary>
        /// <value>The disable person ind.</value>
        public YesNo DisablePersonInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DisablePersonRemarks field.
        /// </summary>
        /// <value>The disable person remarks.</value>
        public String DisablePersonRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Email field.
        /// </summary>
        /// <value>The email.</value>
        public String Email
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FaxAreaCode field.
        /// </summary>
        /// <value>The fax area code.</value>
        public String FaxAreaCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FaxCountryCode field.
        /// </summary>
        /// <value>The fax country code.</value>
        public String FaxCountryCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FaxNumber field.
        /// </summary>
        /// <value>The fax number.</value>
        public String FaxNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FilingInd field.
        /// </summary>
        /// <value>The filing ind.</value>
        public FilingPartyInd FilingInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FormerCompanyName field.
        /// </summary>
        /// <value>The name of the former company.</value>
        public String FormerCompanyName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FormerPersonName field.
        /// </summary>
        /// <value>The name of the former person.</value>
        public String FormerPersonName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FullName field.
        /// </summary>
        /// <value>The full name.</value>
        public String FullName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HasLAC field.
        /// </summary>
        /// <value>The has LAC.</value>
        public YesNo HasLAC
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdNumber field.
        /// </summary>
        /// <value>The id number.</value>
        public String IdNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdRemarks field.
        /// </summary>
        /// <value>The id remarks.</value>
        public String IdRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IMONumber field. </summary>
        public System.String IMONumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the InvolvementInd field.
        /// </summary>
        /// <value>The involvement ind.</value>
        public InvolvementInd InvolvementInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsPartyServiedWrit field.
        /// </summary>
        /// <value>The is party served writ.</value>
        public YesNo IsPartyServiedWrit
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is singaporean PR.
        /// </summary>
        /// <value>The is singaporean PR.</value>
        /// <remarks>To determine whether the case party is a Singaporean Permanent Resident or not. Used in AAS track.</remarks>
        public YesNo IsSingaporeanPR
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LanguageCode field.
        /// </summary>
        /// <value>The language code.</value>
        /// TODO: Map with Master entity.
        public String LanguageCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LanguageRemarks field.
        /// </summary>
        /// <value>The language remarks.</value>
        public String LanguageRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFAddressID field.
        /// </summary>
        /// <value>The LF address id.</value>
        public String LFAddressId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.MApplicantCapacity - Master.MApplicantCapacity.CaseParties (m:1)'
        /// </summary>
        /// <value>The M applicant capacity.</value>
        public MApplicantCapacityEntity MApplicantCapacity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MarriageCertNo field.
        /// </summary>
        /// <value>The marriage cert no.</value>
        public String MarriageCertNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MarriageDt field.
        /// </summary>
        /// <value>The marriage dt.</value>
        public DateTime? MarriageDt
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.BirthCountryCode - Master.MCountry.CaseParties (m:1)'
        /// </summary>
        /// <value>The birth country.</value>
        public MCountryEntity MBirthCountry
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.CompanyIdType - Master.MPersonIDType.CompanyIdType (m:1)'
        /// </summary>
        /// <value>The type of the company id.</value>
        public MPersonIDTypeEntity MCompanyIdType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.CountryOfRegistration - Master.MCountry.CountryOfRegistration (m:1)'
        /// </summary>
        /// <value>The country of registration.</value>
        public MCountryEntity MCountryOfRegistration
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.MDialect - Master.MDialect.CaseParties (m:1)'
        /// </summary>
        /// <value>The M dialect.</value>
        public MDialectEntity MDialect
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CaseParty.MEntityType - Master.MEntityType.CaseParties (m:1)'</summary>
        public MEntityTypeEntity MEntityType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.MGender - Master.MGender.CaseParties (m:1)'
        /// </summary>
        /// <value>The M gender.</value>
        public MGenderEntity MGender
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.IdCountry - Master.MCountry.IdCountry (m:1)'
        /// </summary>
        /// <value>The id country.</value>
        public MCountryEntity MIdCountry
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.MMaritalStatu - Master.MMaritalStatus.CaseParties (m:1)'
        /// </summary>
        /// <value>The M marital status.</value>
        public MMaritalStatusEntity MMaritalStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.MarriageCountry - Master.MCountry.MarriageCountry (m:1)'
        /// </summary>
        /// <value>The marriage country.</value>
        public MCountryEntity MMarriageCountry
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.MNationality - Master.MNationality.CaseParties (m:1)'
        /// </summary>
        /// <value>The M nationality.</value>
        public MNationalityEntity MNationality
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MobileCountryCode field.
        /// </summary>
        /// <value>The mobile country code.</value>
        public String MobileCountryCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MobileNumber field.
        /// </summary>
        /// <value>The mobile number.</value>
        public String MobileNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.MOccupation - Master.MOccupation.CaseParties (m:1)'
        /// </summary>
        /// <value>The M occupation.</value>
        public MOccupationEntity MOccupation
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.MPartyType - Master.MPartyType.CaseParties (m:1)'
        /// </summary>
        /// <value>The type of the M party.</value>
        public MPartyTypeEntity MPartyType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.MPersonIDGroup - Master.MPersonIDGroup.CaseParties (m:1)'
        /// </summary>
        /// <value>The M person id group.</value>
        public MPersonIDGroupEntity MPersonIdGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.MPersonIDType - Master.MPersonIDType.CaseParties (m:1)'
        /// </summary>
        /// <value>The type of the person id.</value>
        public MPersonIDTypeEntity MPersonIdType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.EducationLevelCode - Master.MQualification.CaseParties (m:1)'
        /// </summary>
        /// <value>The qualification.</value>
        public MQualificationEntity MQualification
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.MRace - Master.MRace.CaseParties (m:1)'
        /// </summary>
        /// <value>The race.</value>
        public MRaceEntity MRace
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the M relationship.
        /// </summary>
        /// <value>The M relationship.</value>
        public MRelationshipEntity MRelationship
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.MReligion - Master.MReligion.CaseParties (m:1)'
        /// </summary>
        /// <value>The religion.</value>
        public MReligionEntity MReligion
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty.MPartyType - Master.MPartyType.CaseParties (m:1)'
        /// </summary>
        /// <value>The type of the M party.</value>
        public MPartyTypeEntity MSubCasePartyType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NationalityRemarks field.
        /// </summary>
        /// <value>The nationality remarks.</value>
        public String NationalityRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OccupationRemarks field.
        /// </summary>
        /// <value>The occupation remarks.</value>
        public String OccupationRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OrdinalNumber field.
        /// </summary>
        /// <value>The ordinal number.</value>
        public Decimal OrdinalNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PartyNo field.
        /// </summary>
        /// <value>The party no.</value>
        public String PartyNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PortOfRegistration field. </summary>
        public System.String PortOfRegistration
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RaceRemarks field.
        /// </summary>
        /// <value>The race remarks.</value>
        public String RaceRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ref DCPID.
        /// </summary>
        /// <value>The ref DCPID.</value>
        public string RefDCPID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the RegistrationNumber field. </summary>
        public System.String RegistrationNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RelationshipRemarks field.
        /// </summary>
        /// <value>The relationship remarks.</value>
        public String RelationshipRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ReligionRemarks field.
        /// </summary>
        /// <value>The religion remarks.</value>
        public String ReligionRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the sub case info id.
        /// </summary>
        /// <value>The sub case info id.</value>
        public string SubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the sub case ordinal number.
        /// </summary>
        /// <value>The sub case ordinal number.</value>
        public Decimal? SubCaseOrdinalNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the sub case party update ind.
        /// </summary>
        /// <value>The sub case party update ind.</value>
        public PartyUpdateInd SubCasePartyUpdateInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TelAreaCode field.
        /// </summary>
        /// <value>The tel area code.</value>
        public String TelAreaCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TelCountryCode field.
        /// </summary>
        /// <value>The tel country code.</value>
        public String TelCountryCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TelNumber field.
        /// </summary>
        /// <value>The tel number.</value>
        public String TelNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UEN field.
        /// </summary>
        /// <value>The UEN.</value>
        public String UEN
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UpdateInd field.
        /// </summary>
        /// <value>The update ind.</value>
        public PartyUpdateInd UpdateInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the VesselIDType field. </summary>
        public VesselIdType VesselIDType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the VesselName field.
        /// </summary>
        /// <value>The name of the vessel.</value>
        public String VesselName
        {
            get;
            set;
        }

        public RoleCode RoleCode
        {
            get;
            set;
        }

        public YesNo IsSubCaseOnlyParty
        {
            get;
            set;
        }

        public YesNo ObsInd
        {
            get;
            set;
        }

        public string ComDCPId { get; set; }

        public decimal CounterClaimOrdinalNumber { get; set; }

        public MPartyTypeEntity CounterClaimPartyTypeCode { get; set; }

        public string  CounterClaimPartyNo { get; set; }

        public string IncomeCode { get; set; }

        public string IncomeRemarks { get; set; }

        public string ResidentStatusRemarks { get; set; }

        public string ResidentStatusCode { get; set; }

        public string HarassPlaceCode { get; set; }
        public string HarassPlaceRemarks { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            DocCasePartyEntity toCompareWith = obj as DocCasePartyEntity;
            return toCompareWith == null ? false : ((this.DCPID == toCompareWith.DCPID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DCPID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}