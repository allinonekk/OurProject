#region Header

/*****************************************************************************************************
 * Description : This file represents a standard implementation for case factory.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 04/10/2010                 Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: CaseFactory.cs
// Description: Represents a standard implementation for case factory.
// </summary>
// <copyright file= "CaseFactory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory.Impl
{
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Document;

    /// <summary>
    /// Represents a standard implementation for case factory.
    /// It inherits from <see cref="ICaseFactory"/>.
    /// </summary>
    public class CaseFactoryImpl : ICaseFactory
    {
        #region Fields

        /// <summary>
        /// Variable to store ApplicationEnvironment.
        /// </summary>
        private ApplicationEnvironment applicationEnvironment;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseFactoryImpl"/> class.
        /// </summary>
        /// <param name="applicationEnvironment">The application environment.</param>
        public CaseFactoryImpl(ApplicationEnvironment applicationEnvironment)
        {
            this.applicationEnvironment = applicationEnvironment;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the <see cref="CaseIssueListEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CaseIssueListEntity"/></returns>
        public CaseIssueListEntity GetCaseIssueListEntityInstance()
        {
            return new CaseIssueListEntity { CaseIssueListId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CasePartyAddressEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CasePartyAddressEntity"/>
        /// </returns>
        public CasePartyAddressEntity GetCasePartyAddressEntityInstance()
        {
            return new CasePartyAddressEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CasePartyAICAddressEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CasePartyAICAddressEntity"/>
        /// </returns>
        public CasePartyAICAddressEntity GetCasePartyAICAddressEntityInstance()
        {
            return new CasePartyAICAddressEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CasePartyAICAliasEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CasePartyAICAliasEntity"/>
        /// </returns>
        public CasePartyAICAliasEntity GetCasePartyAICAliasEntityInstance()
        {
            return new CasePartyAICAliasEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CasePartyAICDetailsEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CasePartyAICDetailsEntity"/>
        /// </returns>
        public CasePartyAICDetailsEntity GetCasePartyAICDetailsEntityInstance()
        {
            return new CasePartyAICDetailsEntity { AICID = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CasePartyAliasEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CasePartyAliasEntity"/>
        /// </returns>
        public CasePartyAliasEntity GetCasePartyAliasEntityInstance()
        {
            return new CasePartyAliasEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CasePartyAuthorisedOfficerDetailsEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CasePartyAuthorisedOfficerDetailsEntity"/>
        /// </returns>
        public CasePartyAuthorisedOfficerDetailsEntity GetCasePartyAuthorisedOfficerDetailsEntityInstance()
        {
            return new CasePartyAuthorisedOfficerDetailsEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CasePartyBailorAddressEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyBailorAddressEntity"/></returns>
        public CasePartyBailorAddressEntity GetCasePartyBailorAddressEntityInstance()
        {
            return new CasePartyBailorAddressEntity { CasePartyBailorAddressId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CasePartyBailorInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyBailorInfoEntity"/></returns>
        public CasePartyBailorInfoEntity GetCasePartyBailorInfoEntityInstance()
        {
            return new CasePartyBailorInfoEntity { CasePartyBailorInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CasePartyCriminalInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyCriminalInfoEntity"/></returns>
        public CasePartyCriminalInfoEntity GetCasePartyCriminalInfoEntityInstance()
        {
            return new CasePartyCriminalInfoEntity { CasePartyCriminalInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CaseInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CaseInfoEntity"/></returns>
        //public CaseInfoEntity GetCaseInfoEntityInstance()
        //{
        //    throw new NotImplementedException();
        //}
        /// <summary>
        /// Gets the <see cref="CasePartyEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyEntity"/></returns>
        public CasePartyEntity GetCasePartyEntityInstance()
        {
            return new CasePartyEntity { CasePartyId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CasePartyVesselDetailsEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CasePartyVesselDetailsEntity"/>
        /// </returns>
        public CasePartyVesselDetailsEntity GetCasePartyVesselDetailsEntityInstance()
        {
            return new CasePartyVesselDetailsEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CaseSolicitorEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CaseSolicitorEntity"/>
        /// </returns>
        public CaseSolicitorEntity GetCaseSolicitorEntityInstance()
        {
            return new CaseSolicitorEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CaseStatusHistoryEntity"/> instance.
        /// </summary>
        /// <returns></returns>
        public CaseStatusHistoryEntity GetCaseStatusHistoryEntityInstance()
        {
            return new CaseStatusHistoryEntity { CaseStatusHistoryId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="HearingAdminSupportEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="HearingAdminSupportEntity"/></returns>
        public HearingAdminSupportEntity GetHearingAdminSupportEntityInstance()
        {
            return new HearingAdminSupportEntity { HearingAdminSupportId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="RCaseLawFirmEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="RCaseLawFirmEntity"/>
        /// </returns>
        public RCaseLawFirmEntity GetRCaseLawFirmEntityInstance()
        {
            return new RCaseLawFirmEntity { RCLFId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="RDocLawFirmEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="RDocLawFirmEntity"/>
        /// </returns>
        public RDocLawFirmEntity GetRDocLawFirmEntityInstance()
        {
            return new RDocLawFirmEntity { RDLFId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        #endregion Methods
    }
}