#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for CriminalDocCasePartyData.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/05/2011   		      Chun Jie             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CriminalDocCasePartyData.cs
// Description: Represents a standard data container object for CriminalDocCasePartyData.
// </summary>
// <copyright file= "CriminalDocCasePartyData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard data container object for CriminalDocCasePartyData.
    /// </summary>
    [Serializable]
    public class CriminalDocCasePartyData : IDocCasePartyData
    {
        #region Properties

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty - Case.CaseParty.DocCasePartyBailorAddress (m:1)'
        /// </summary>
        /// <value>The criminal case party's bailor address information.</value>
        public List<DocCasePartyBailorAddressEntity> ListDocCasePartyBailorAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty - Case.CaseParty.DocCasePartyBailorInfo (m:1)'
        /// </summary>
        /// <value>The criminal case party's bailor information.</value>
        public List<DocCasePartyBailorInfoEntity> ListDocCasePartyBailorInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty - Case.CaseParty.DocCasePartyCriminalInfo (m:1)'
        /// </summary>
        /// <value>The criminal case party information.</value>
        public List<DocCasePartyCriminalInfoEntity> ListDocCasePartyCriminalInfo
        {
            get;
            set;
        }

        #endregion Properties
    }
}