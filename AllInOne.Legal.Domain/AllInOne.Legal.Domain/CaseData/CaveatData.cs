#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for Probate case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   06/07/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: WOSData.cs
// Description: Represents a standard data container object for Probate case type.
// </summary>
// <copyright file= "ProbateData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseData
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;

    [Serializable]
    public class CaveatData : ICaseTypeInfo
    {
        #region Properties

        public List<DeceasedAliasEntity> ListDeceasedAliasEntity
        {
            get;
            set;
        }

        public List<DeceasedIdentificationsEntity> ListDeceasedIdentificationsEntity
        {
            get;
            set;
        }

        public List<DeceasedInfoEntity> ListDeceasedInfoEntity
        {
            get;
            set;
        }

        public List<RefCaveatCaseEntity> ListRefCaveatCaseEntity
        {
            get;
            set;
        }
        public CaveatAAInfoEntity CaveatAAInfoEntity 
        {
            get;
            set;
        }

        public CaveatInfoEntity CaveatInfoEntity
        {
            get;
            set;
        }



        #endregion Properties
    }
}