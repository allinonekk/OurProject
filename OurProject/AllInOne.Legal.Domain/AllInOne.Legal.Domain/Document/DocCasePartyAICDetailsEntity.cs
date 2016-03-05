#region Header

/*****************************************************************************************************
 * Description : This file represents a standard DocCasePartyAICDetails.
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
// File: DocCasePartyAICDetailsEntity.cs
// Description: Represents a standard DocCasePartyAICDetails.
// </summary>
// <copyright file= "DocCasePartyAICDetailsEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for DocCasePartyAICDetails.
    /// It inherits from <see cref="AbstractDocCaseParty"/>
    /// </summary>
    [Serializable]
    public class DocCasePartyAICDetailsEntity : AbstractDocCaseParty, IDocumentEntity
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
        /// Gets or sets the AICRemarks field.
        /// </summary>
        /// <value>The AICRemarks.</value>
        public String AICRemarks
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
        public DateTime? DateOfRegistration
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DCPAICID field.
        /// </summary>
        /// <value>The DCPAICID.</value>
        public String DCPAICID
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Document.DocCasePartyAICAddress.DocCasePartyAICDetail - Document.DocCasePartyAICDetail.DocCasePartyAICAddresses (m:1)'
        /// </summary>
        /// <value>The doc case party AIC addresses.</value>
        public List<DocCasePartyAICAddressEntity> DocCasePartyAICAddresses
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Document.DocCasePartyAICAlias.DocCasePartyAICDetail - Document.DocCasePartyAICDetail.DocCasePartyAICAliases (m:1)'
        /// </summary>
        /// <value>The doc case party AIC aliases.</value>
        public List<DocCasePartyAICAliasEntity> DocCasePartyAICAliases
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
            if(obj == null)
            {
                return false;
            }

            DocCasePartyAICDetailsEntity toCompareWith = obj as DocCasePartyAICDetailsEntity;
            return toCompareWith == null ? false : ((this.DCPAICID == toCompareWith.DCPAICID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DCPAICID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}