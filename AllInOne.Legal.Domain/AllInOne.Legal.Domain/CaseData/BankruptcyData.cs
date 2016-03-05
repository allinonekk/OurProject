#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for Bankruptcy case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   23/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: BankruptcyData.cs
// Description: Represents a standard data container object for Bankruptcy case type.
// </summary>
// <copyright file= "BankruptcyData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseData
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.FrontEndSpecific;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard data container object for Bankruptcy case type.
    /// </summary>
    [Serializable]
    public class BankruptcyData : ICaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the bankruptcy info entity.
        /// </summary>
        /// <value>The bankruptcy info entity.</value>
        public BankruptcyInfoEntity BankruptcyInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list bankruptcy other def detail entity.
        /// </summary>
        /// <value>The list bankruptcy other def detail entity.</value>
        public List<BankruptcyOtherDefDetailEntity> ListBankruptcyOtherDefDetailEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list legislation provisions entity.
        /// </summary>
        /// <value>The list legislation provisions entity.</value>
        public List<LegislationProvisionsEntity> ListLegislationProvisionsEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list nature of case entity.
        /// </summary>
        /// <value>The list nature of case entity.</value>
        public List<NatureOfCaseEntity> ListNatureOfCaseEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list other ITMO entity.
        /// </summary>
        /// <value>The list other ITMO entity.</value>
        public List<OtherITMOEntity> ListOtherITMOEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="PrayerEntity"/> entity list.
        /// </summary>
        /// <value>The <see cref="PrayerEntity"/> entity list.</value>
        public List<PrayerEntity> ListPrayerEntity
        {
            get;
            set;
        }

        public List<BankruptcyDebtInfoEntity> ListBankruptcyDebtInfoEntity
        {
            get;
            set;
        }
        #endregion Properties
    }
}