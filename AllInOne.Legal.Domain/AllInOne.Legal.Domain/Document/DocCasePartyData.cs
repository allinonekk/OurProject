#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for DocCaseParty.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   08/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: DocCasePartyData.cs
// Description: Represents a standard data container object for DocCaseParty.
// </summary>
// <copyright file= "DocCasePartyData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard data container object for DocCaseParty.
    /// </summary>
    [Serializable]
    public class DocCasePartyData : IDocCasePartyData
    {
        #region Properties

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.DocCasePartyAddress.DocCaseParty - Case.DocCaseParty.DocCasePartyAddresses (m:1)'
        /// </summary>
        /// <value>The case party addresses.</value>
        public List<DocCasePartyAddressEntity> DocCasePartyAddresses
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.DocCasePartyAICDetail.DocCaseParty - Case.DocCaseParty.DocCasePartyAICDetails (m:1)'
        /// </summary>
        /// <value>The case party AIC details.</value>
        public List<DocCasePartyAICDetailsEntity> DocCasePartyAICDetails
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.DocCasePartyAlias.DocCaseParty - Case.DocCaseParty.DocCasePartyAliases (m:1)'
        /// </summary>
        /// <value>The case party aliases.</value>
        public List<DocCasePartyAliasEntity> DocCasePartyAliases
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.DocCasePartyAuthorisedOfficerDetail.DocCaseParty - Case.DocCaseParty.DocCasePartyAuthorisedOfficerDetails (m:1)'
        /// </summary>
        /// <value>The case party authorized officer details.</value>
        public List<DocCasePartyAuthorisedOfficerDetailsEntity> DocCasePartyAuthorisedOfficerDetails
        {
            get;
            set;
        }

        public List<DocCasePartyBailorAddressEntity> DocCasePartyBailorAddresses
        {
            get;
            set;
        }

        public List<DocCasePartyBailorInfoEntity> DocCasePartyBailorInfos
        {
            get;
            set;
        }

        public List<DocCasePartyCitizenshipEntity> DocCasePartyCitizenships
        {
            get;
            set;
        }

        public DocCasePartyCriminalInfoEntity DocCasePartyCriminalInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="DocCasePartyEntity"/> entity.
        /// </summary>
        /// <value>The AAS info entity.</value>
        public DocCasePartyEntity DocCasePartyEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.DocCasePartyLACDetail.DocCaseParty - Case.DocCasePartyLACDetail.CaseSolicitors (m:1)'
        /// </summary>
        /// <value>The case solicitors.</value>
        public DocCasePartyLACDetailEntity DocCasePartyLACDetail
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.DocCasePartyVesselDetail.DocCaseParty - Case.DocCaseParty.DocCasePartyVesselDetails (m:1)'
        /// </summary>
        /// <value>The case party vessel details.</value>
        public List<DocCasePartyVesselDetailsEntity> DocCasePartyVesselDetails
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseSolicitor.DocCaseParty - Case.DocCaseParty.CaseSolicitors (m:1)'
        /// </summary>
        /// <value>The case solicitors.</value>
        public List<DocCaseSolicitorEntity> DocCaseSolicitors
        {
            get;
            set;
        }

        public DocPartyCaseFileRefNumberEntity DocPartyCaseFileRefNumberEntity
        {
            get;
            set;
        }


        #endregion Properties
    }
}