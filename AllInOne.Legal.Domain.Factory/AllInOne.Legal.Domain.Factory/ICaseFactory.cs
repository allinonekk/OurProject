#region Header

/*****************************************************************************************************
 * Description : This file represents a standard interface for creating instances of objects related
 *              with case.
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
// File: IDocumentFactory.cs
// Description: Represents a standard interface for creating instances of objects related with case.
// </summary>
// <copyright file= "IDocumentFactory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory
{
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Document;

    /// <summary>
    /// Represents a standard interface for creating instances of objects related with document.
    /// </summary>
    public interface ICaseFactory
    {
        #region Methods

        /// <summary>
        /// Gets the <see cref="CaseIssueListEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CaseIssueListEntity"/></returns>
        CaseIssueListEntity GetCaseIssueListEntityInstance();

        /// <summary>
        /// Gets the <see cref="CasePartyAddressEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyAddressEntity"/></returns>
        CasePartyAddressEntity GetCasePartyAddressEntityInstance();

        /// <summary>
        /// Gets the <see cref="CasePartyAICAddressEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyAICAddressEntity"/></returns>
        CasePartyAICAddressEntity GetCasePartyAICAddressEntityInstance();

        /// <summary>
        /// Gets the <see cref="CasePartyAICAliasEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyAICAliasEntity"/></returns>
        CasePartyAICAliasEntity GetCasePartyAICAliasEntityInstance();

        /// <summary>
        /// Gets the <see cref="CasePartyAICDetailsEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyAICDetailsEntity"/></returns>
        CasePartyAICDetailsEntity GetCasePartyAICDetailsEntityInstance();

        /// <summary>
        /// Gets the <see cref="CasePartyAliasEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyAliasEntity"/></returns>
        CasePartyAliasEntity GetCasePartyAliasEntityInstance();

        /// <summary>
        /// Gets the <see cref="CasePartyAuthorisedOfficerDetailsEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyAuthorisedOfficerDetailsEntity"/></returns>
        CasePartyAuthorisedOfficerDetailsEntity GetCasePartyAuthorisedOfficerDetailsEntityInstance();

        /// <summary>
        /// Gets the <see cref="CasePartyBailorAddressEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyBailorAddressEntity"/></returns>
        CasePartyBailorAddressEntity GetCasePartyBailorAddressEntityInstance();

        /// <summary>
        /// Gets the <see cref="CasePartyBailorInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyBailorInfoEntity"/></returns>
        CasePartyBailorInfoEntity GetCasePartyBailorInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="CasePartyCriminalInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyCriminalInfoEntity"/></returns>
        CasePartyCriminalInfoEntity GetCasePartyCriminalInfoEntityInstance();

        ///// <summary>
        ///// Gets the <see cref="CaseInfoEntity"/> instance.
        ///// </summary>
        ///// <returns>Returns <see cref="CaseInfoEntity"/></returns>
        //CaseInfoEntity GetCaseInfoEntityInstance();
        /// <summary>
        /// Gets the <see cref="CasePartyEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyEntity"/></returns>
        CasePartyEntity GetCasePartyEntityInstance();

        /// <summary>
        /// Gets the <see cref="CasePartyVesselDetailsEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CasePartyVesselDetailsEntity"/></returns>
        CasePartyVesselDetailsEntity GetCasePartyVesselDetailsEntityInstance();

        /// <summary>
        /// Gets the <see cref="CaseSolicitorEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CaseSolicitorEntity"/></returns>
        CaseSolicitorEntity GetCaseSolicitorEntityInstance();

        /// <summary>
        /// Gets the <see cref="HearingAdminSupportEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="HearingAdminSupportEntity"/></returns>
        HearingAdminSupportEntity GetHearingAdminSupportEntityInstance();

        /// <summary>
        /// Gets the <see cref="RCaseLawFirmEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="RCaseLawFirmEntity"/></returns>
        RCaseLawFirmEntity GetRCaseLawFirmEntityInstance();

        /// <summary>
        /// Gets the <see cref="RDocLawFirmEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="RDocLawFirmEntity"/></returns>
        RDocLawFirmEntity GetRDocLawFirmEntityInstance();

        #endregion Methods
    }
}