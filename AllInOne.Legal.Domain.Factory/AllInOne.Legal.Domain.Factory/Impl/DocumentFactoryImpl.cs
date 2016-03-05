#region Header

/*****************************************************************************************************
 * Description : This file represents a standard implementation for document factory.
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
// File: DocumentFactory.cs
// Description: Represents a standard implementation for document factory.
// </summary>
// <copyright file= "DocumentFactory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory.Impl
{
    using AllInOne.Legal.Domain.Document;

    /// <summary>
    /// Represents a standard implementation for document factory.
    /// It inherits from <see cref="IDocumentFactory"/>.
    /// </summary>
    public class DocumentFactoryImpl : IDocumentFactory
    {
        #region Fields

        /// <summary>
        /// Variable to store ApplicationEnvironment.
        /// </summary>
        private ApplicationEnvironment applicationEnvironment;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentFactoryImpl"/> class.
        /// </summary>
        /// <param name="applicationEnvironment">The application environment.</param>
        public DocumentFactoryImpl(ApplicationEnvironment applicationEnvironment)
        {
            this.applicationEnvironment = applicationEnvironment;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the <see cref="DocCasePartyAddressEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DocCasePartyAddressEntity"/>
        /// </returns>
        public DocCasePartyAddressEntity GetDocCasePartyAddressEntityInstance()
        {
            return new DocCasePartyAddressEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyAICAddressEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DocCasePartyAICAddressEntity"/>
        /// </returns>
        public DocCasePartyAICAddressEntity GetDocCasePartyAICAddressEntityInstance()
        {
            return new DocCasePartyAICAddressEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyAICAliasEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DocCasePartyAICAliasEntity"/>
        /// </returns>
        public DocCasePartyAICAliasEntity GetDocCasePartyAICAliasEntityInstance()
        {
            return new DocCasePartyAICAliasEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyAICDetailsEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DocCasePartyAICDetailsEntity"/>
        /// </returns>
        public DocCasePartyAICDetailsEntity GetDocCasePartyAICDetailsEntityInstance()
        {
            return new DocCasePartyAICDetailsEntity { DCPAICID = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyAliasEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DocCasePartyAliasEntity"/>
        /// </returns>
        public DocCasePartyAliasEntity GetDocCasePartyAliasEntityInstance()
        {
            return new DocCasePartyAliasEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyAuthorisedOfficerDetailsEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DocCasePartyAuthorisedOfficerDetailsEntity"/>
        /// </returns>
        public DocCasePartyAuthorisedOfficerDetailsEntity GetDocCasePartyAuthorisedOfficerDetailsEntityInstance()
        {
            return new DocCasePartyAuthorisedOfficerDetailsEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyBailorAddressEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyBailorAddressEntity"/></returns>
        public DocCasePartyBailorAddressEntity GetDocCasePartyBailorAddressEntityInstance()
        {
            return new DocCasePartyBailorAddressEntity { DocCasePartyBailorAddressId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyBailorInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyBailorInfoEntity"/></returns>
        public DocCasePartyBailorInfoEntity GetDocCasePartyBailorInfoEntityInstance()
        {
            return new DocCasePartyBailorInfoEntity { DocCasePartyBailorInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyCriminalInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="DocCasePartyCriminalInfoEntity"/></returns>
        public DocCasePartyCriminalInfoEntity GetDocCasePartyCriminalInfoEntityInstance()
        {
            return new DocCasePartyCriminalInfoEntity { DocCasePartyCriminalInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DocCasePartyEntity"/>
        /// </returns>
        public DocCasePartyEntity GetDocCasePartyEntityInstance()
        {
            return new DocCasePartyEntity { DCPID = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyVesselDetailsEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DocCasePartyVesselDetailsEntity"/>
        /// </returns>
        public DocCasePartyVesselDetailsEntity GetDocCasePartyVesselDetailsEntityInstance()
        {
            return new DocCasePartyVesselDetailsEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocCaseSolicitorEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DocCaseSolicitorEntity"/>
        /// </returns>
        public DocCaseSolicitorEntity GetDocCaseSolicitorEntityInstance()
        {
            return new DocCaseSolicitorEntity { RecId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocumentInfoEntity"/> instance only with DocId filled.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DocumentInfoEntity"/>
        /// </returns>
        public DocumentInfoEntity GetDocumentInfoEntityInstance()
        {
            return new DocumentInfoEntity { DocId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocumentInfoEntity"/> instance with DocId and SubmissionGroupId filled.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DocumentInfoEntity"/>
        /// </returns>
        public DocumentInfoEntity GetDocumentInfoEntityWithSubmissionGroupIdInstance()
        {
            return new DocumentInfoEntity
            {
                DocId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment),
                SubmissionGroupId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment)
            };
        }

        /// <summary>
        /// Gets the <see cref="RDocCasePartyEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="RDocCasePartyEntity"/>
        /// </returns>
        public RDocCasePartyEntity GetRDocCasePartyEntityInstance()
        {
            return new RDocCasePartyEntity { RDCPId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="RDocLawFirmEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="RDocLawFirmEntity"/></returns>
        public RDocLawFirmEntity GetRDocLawFirmEntityInstance()
        {
            return new RDocLawFirmEntity { RDLFId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        public LawFirmDocCaseFileRefNumberEntity GetLawFirmDocCaseFileRefNumberInstance()
        {
            return new LawFirmDocCaseFileRefNumberEntity { LFDCFRNId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        #endregion Methods
    }
}