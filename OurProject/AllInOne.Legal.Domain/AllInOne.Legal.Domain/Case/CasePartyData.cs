#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for CaseParty.
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
// File: CasePartyData.cs
// Description: Represents a standard data container object for CaseParty.
// </summary>
// <copyright file= "CasePartyData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard data container object for CaseParty.
    /// </summary>
    [Serializable]
    public class CasePartyData : ICasePartyData
    {
        #region Properties

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyAddress.CaseParty - Case.CaseParty.CasePartyAddresses (m:1)'
        /// </summary>
        /// <value>The case party addresses.</value>
        public List<CasePartyAddressEntity> CasePartyAddresses
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.CaseParty - Case.CaseParty.CasePartyAICDetails (m:1)'
        /// </summary>
        /// <value>The case party AIC details.</value>
        public List<CasePartyAICDetailsEntity> CasePartyAICDetails
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyAlias.CaseParty - Case.CaseParty.CasePartyAliases (m:1)'
        /// </summary>
        /// <value>The case party aliases.</value>
        public List<CasePartyAliasEntity> CasePartyAliases
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyAuthorisedOfficerDetail.CaseParty - Case.CaseParty.CasePartyAuthorisedOfficerDetails (m:1)'
        /// </summary>
        /// <value>The case party authorized officer details.</value>
        public List<CasePartyAuthorisedOfficerDetailsEntity> CasePartyAuthorisedOfficerDetails
        {
            get;
            set;
        }

        public List<CasePartyBailorAddressEntity> CasePartyBailorAddresses
        {
            get;
            set;
        }

        public List<CasePartyBailorInfoEntity> CasePartyBailorInfos
        {
            get;
            set;
        }

        public List<CasePartyCitizenshipEntity> CasePartyCitizenships
        {
            get;
            set;
        }

        public CasePartyCriminalInfoEntity CasePartyCriminalInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="CasePartyEntity"/> entity.
        /// </summary>
        /// <value>The AAS info entity.</value>
        public CasePartyEntity CasePartyEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyLACDetail.CaseParty - Case.CaseParty.CasePartyLACDetail (m:1)'
        /// </summary>
        /// <value>The CasePartyLACDetail.</value>
        public CasePartyLACDetailEntity CasePartyLACDetail
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CasePartyVesselDetail.CaseParty - Case.CaseParty.CasePartyVesselDetails (m:1)'
        /// </summary>
        /// <value>The case party vessel details.</value>
        public List<CasePartyVesselDetailsEntity> CasePartyVesselDetails
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseSolicitor.CaseParty - Case.CaseParty.CaseSolicitors (m:1)'
        /// </summary>
        /// <value>The case solicitors.</value>
        public List<CaseSolicitorEntity> CaseSolicitors
        {
            get;
            set;
        }

        public List<PartyCaseFileRefNumberEntity> PartyCaseFileRefNumber
        {
            get;
            set;
        }

        #endregion Properties
    }
}