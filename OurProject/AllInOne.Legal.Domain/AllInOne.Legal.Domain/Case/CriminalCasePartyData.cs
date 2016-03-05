#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for CriminalCasePartyData.
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
// File: CriminalCasePartyData.cs
// Description: Represents a standard data container object for CriminalCasePartyData.
// </summary>
// <copyright file= "CriminalCasePartyData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard data container object for CriminalCasePartyData.
    /// </summary>
    [Serializable]
    public class CriminalCasePartyData : ICasePartyData
    {
        #region Properties

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty - Case.CaseParty.CasePartyBailorAddress (m:1)'
        /// </summary>
        /// <value>The criminal case party's bailor address information.</value>
        public List<CasePartyBailorAddressEntity> ListCasePartyBailorAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty - Case.CaseParty.CasePartyBailorInfo (m:1)'
        /// </summary>
        /// <value>The criminal case party's bailor information.</value>
        public List<CasePartyBailorInfoEntity> ListCasePartyBailorInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.CaseParty - Case.CaseParty.CasePartyCriminalInfo (m:1)'
        /// </summary>
        /// <value>The criminal case party information.</value>
        public List<CasePartyCriminalInfoEntity> ListCasePartyCriminalInfo
        {
            get;
            set;
        }

        #endregion Properties
    }
}