#region Header

/*****************************************************************************************************
 * Description : This file represents a standard CasePartyAICDetails.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 25/09/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: CasePartyAICDetailsEntity.cs
// Description: Represents a standard CasePartyAICDetails.
// </summary>
// <copyright file= "CasePartyAICDetailsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for CasePartyAICDetails.
    /// It inherits from <see cref="AbstractCaseParty"/>
    /// </summary>
    [Serializable]
    public class CasePartyAICDetailsEntity : AbstractCaseParty, ICaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AddressAvailabilityInd field.
        /// </summary>
        /// <value>The address availability ind.</value>
        public AddressAvailabilityType AddressAvailabilityInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AICID field.
        /// </summary>
        /// <value>The AICID.</value>
        public String AICID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AICRemarks field.
        /// </summary>
        /// <value>AICRemarks</value>
        public String AICRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyAICAddress.CasePartyAICDetail - Case.CasePartyAICDetail.CasePartyAICAddresses (m:1)'
        /// </summary>
        /// <value>The case party AIC addresses.</value>
        public List<CasePartyAICAddressEntity> CasePartyAICAddresses
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyAICAlias.CasePartyAICDetail - Case.CasePartyAICDetail.CasePartyAICAliases (m:1)'
        /// </summary>
        /// <value>The case party AIC aliases.</value>
        public List<CasePartyAICAliasEntity> CasePartyAICAliases
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
        /// Gets or sets the DateOfRegistration field.
        /// </summary>
        /// <value>The date of registration.</value>
        public Nullable<System.DateTime> DateOfRegistration
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

        /// <summary>
        /// Gets or sets the IMONumber field.
        /// </summary>
        /// <value>The IMO number.</value>
        public String IMONumber
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.MActingInCapacity - Master.MActingInCapacity.CasePartyAICDetails (m:1)'
        /// </summary>
        /// <value>The M acting in capacity.</value>
        public MActingInCapacityEntity MActingInCapacity
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.MCPAICDCompanyIdTypeCode - Master.MPersonIDType.MCPAICDCompanyIdTypeCode (m:1)'
        /// </summary>
        /// <value>The M company id type code.</value>
        public MPersonIDTypeEntity MCompanyIdTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.MCPAICDCountryOfRegistration - Master.MCountry.MCPAICDCountryOfRegistration (m:1)'
        /// </summary>
        /// <value>The MCountry of registration.</value>
        public MCountryEntity MCountryOfRegistration
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the M entity.
        /// </summary>
        /// <value>The type of the M entity.</value>
        public MEntityTypeEntity MEntityType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.MGender - Master.MGender.CasePartyAICDetails (m:1)'
        /// </summary>
        /// <value>The M gender.</value>
        public MGenderEntity MGender
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.MCountry - Master.MCountry.CasePartyAICDetails (m:1)'
        /// </summary>
        /// <value>The M id country.</value>
        public MCountryEntity MIdCountry
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.MPersonIDGroup - Master.MPersonIDGroup.CasePartyAICDetails (m:1)'
        /// </summary>
        /// <value>The M person ID group.</value>
        public MPersonIDGroupEntity MPersonIdGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.MPersonIDType - Master.MPersonIDType.CasePartyAICDetails (m:1)'
        /// </summary>
        /// <value>The type of the M person id.</value>
        public MPersonIDTypeEntity MPersonIdType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PortOfRegistration field.
        /// </summary>
        /// <value>The port of registration.</value>
        public String PortOfRegistration
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RegistrationNumber field.
        /// </summary>
        /// <value>The registration number.</value>
        public String RegistrationNumber
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
        /// Gets or sets the VesselIdType field.
        /// </summary>
        /// <value>The type of the vessel id.</value>
        public VesselIdType VesselIdType
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

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            CasePartyAICDetailsEntity toCompareWith = obj as CasePartyAICDetailsEntity;
            return toCompareWith == null ? false : ((this.AICID == toCompareWith.AICID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AICID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}