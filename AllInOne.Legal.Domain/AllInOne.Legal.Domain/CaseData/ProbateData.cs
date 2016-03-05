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
    public class ProbateData : ICaseTypeInfo
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

        public List<PBBeneficiaryDetailEntity> ListPBBeneficiaryDetailEntity
        {
            get;
            set;
        }

        public List<PBCoAdminDetailEntity> ListPBCoAdminDetailEntity
        {
            get;
            set;
        }

        public List<PBExecutorDetailEntity> ListPBExecutorDetailEntity
        {
            get;
            set;
        }

        public List<PBPrevGrantDetailEntity> ListPBPrevGrantDetailEntity
        {
            get;
            set;
        }

        public ProbateInfoEntity ProbateInfoEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}