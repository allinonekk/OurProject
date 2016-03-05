#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for OriginatingCaseSummonsBankruptcyData case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   01/07/2011   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: OriginatingSummonsBankruptcyData.cs
// Description: Represents a standard data container object for OriginatingCaseSummonsBankruptcyData case type.
// </summary>
// <copyright file= "OriginatingSummonsBankruptcyData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseData
{
    using System;

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Common;
    using System.Collections.Generic;
    using AllInOne.Legal.Domain.CaseSpecific;

    /// <summary>
    /// Represents a standard data container object for SICCS case type.
    /// </summary>
    [Serializable]
    public class SICCSData : ICaseTypeInfo
    {
        #region Properties

        public List<LiquidatedClaimEntity> ListLiquidatedClaimEntity
        {
            get;
            set;
        }

        public List<NatureOfCaseEntity> ListNatureOfCaseEntity
        {
            get;
            set;
        }

        public List<OtherReliefsClaimEntity> ListOtherReliefsClaimEntity
        {
            get;
            set;
        }

        public List<RefOrderDetailEntity> ListRefOrderDetailEntity
        {
            get;
            set;
        }

        public List<UnliquidatedClaimEntity> ListUnliquidatedClaimEntity
        {
            get;
            set;
        }

        public WOSInfoEntity WOSInfoEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}