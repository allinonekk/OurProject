#region Header

/*****************************************************************************************************
 * Description : This file represents a standard interface for creating instances of objects related
 *              with document.
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
// Description: Represents a standard interface for creating instances of objects related with document.
// </summary>
// <copyright file= "IDocumentFactory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory
{
    using AllInOne.Legal.Domain.Document;

    /// <summary>
    /// Represents a standard interface for creating instances of objects related with document.
    /// </summary>
    internal interface IDocumentFactory
    {
        #region Methods

        /// <summary>
        /// Gets the <see cref="DocCasePartyAddressEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyAddressEntity"/></returns>
        DocCasePartyAddressEntity GetDocCasePartyAddressEntityInstance();

        /// <summary>
        /// Gets the <see cref="DocCasePartyAICAddressEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyAICAddressEntity"/></returns>
        DocCasePartyAICAddressEntity GetDocCasePartyAICAddressEntityInstance();

        /// <summary>
        /// Gets the <see cref="DocCasePartyAICAliasEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyAICAliasEntity"/></returns>
        DocCasePartyAICAliasEntity GetDocCasePartyAICAliasEntityInstance();

        /// <summary>
        /// Gets the <see cref="DocCasePartyAICDetailsEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyAICDetailsEntity"/></returns>
        DocCasePartyAICDetailsEntity GetDocCasePartyAICDetailsEntityInstance();

        /// <summary>
        /// Gets the <see cref="DocCasePartyAliasEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyAliasEntity"/></returns>
        DocCasePartyAliasEntity GetDocCasePartyAliasEntityInstance();

        /// <summary>
        /// Gets the <see cref="DocCasePartyAuthorisedOfficerDetailsEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyAuthorisedOfficerDetailsEntity"/></returns>
        DocCasePartyAuthorisedOfficerDetailsEntity GetDocCasePartyAuthorisedOfficerDetailsEntityInstance();

        /// <summary>
        /// Gets the <see cref="DocCasePartyBailorAddressEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyBailorAddressEntity"/></returns>
        DocCasePartyBailorAddressEntity GetDocCasePartyBailorAddressEntityInstance();

        /// <summary>
        /// Gets the <see cref="DocCasePartyBailorInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyBailorInfoEntity"/></returns>
        DocCasePartyBailorInfoEntity GetDocCasePartyBailorInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="DocCasePartyCriminalInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyCriminalInfoEntity"/></returns>
        DocCasePartyCriminalInfoEntity GetDocCasePartyCriminalInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="DocCasePartyEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyEntity"/></returns>
        DocCasePartyEntity GetDocCasePartyEntityInstance();

        /// <summary>
        /// Gets the <see cref="DocCasePartyVesselDetailsEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyVesselDetailsEntity"/></returns>
        DocCasePartyVesselDetailsEntity GetDocCasePartyVesselDetailsEntityInstance();

        /// <summary>
        /// Gets the <see cref="DocCaseSolicitorEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCaseSolicitorEntity"/></returns>
        DocCaseSolicitorEntity GetDocCaseSolicitorEntityInstance();

        /// <summary>
        /// Gets the <see cref="DocumentInfoEntity"/> instance only with DocId filled.
        /// </summary>
        /// <returns>Returns <see cref="DocumentInfoEntity"/></returns>
        DocumentInfoEntity GetDocumentInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="DocumentInfoEntity"/> instance with DocId and SubmissionGroupId filled.
        /// </summary>
        /// <returns>Returns <see cref="DocumentInfoEntity"/></returns>
        DocumentInfoEntity GetDocumentInfoEntityWithSubmissionGroupIdInstance();

        /// <summary>
        /// Gets the <see cref="RDocCasePartyEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="RDocCasePartyEntity"/></returns>
        RDocCasePartyEntity GetRDocCasePartyEntityInstance();

        /// <summary>
        /// Gets the <see cref="RDocLawFirmEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="RDocLawFirmEntity"/></returns>
        RDocLawFirmEntity GetRDocLawFirmEntityInstance();

        /// <summary>
        /// Get the <see cref="LawFirmDocCaseFileRefNumberEntity"/>instance
        /// </summary>
        /// <returns>LawFirmDocCaseFileRefNumberEntity</returns>
        LawFirmDocCaseFileRefNumberEntity GetLawFirmDocCaseFileRefNumberInstance();
        #endregion Methods
    }
}