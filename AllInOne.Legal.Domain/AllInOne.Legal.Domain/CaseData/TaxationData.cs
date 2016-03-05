#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for WOS case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/09/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: WOSData.cs
// Description: Represents a standard data container object for WOS case type.
// </summary>
// <copyright file= "WOSData.cs" company="AllInOne Pte Ltd">
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
    public class TaxationData : ICaseTypeInfo
    {
        #region Properties

        public List<BOTDetailEntity> ListBOTDetailEntity
        {
            get;
            set;
        }

        public List<LegislationProvisionsEntity> ListLegislationProvisionsEntity
        {
            get;
            set;
        }

        public List<NatureOfApplicationEntity> ListNatureOfApplicationEntity
        {
            get;
            set;
        }

        public List<RefOrderDetailEntity> ListRefOrderDetailEntity
        {
            get;
            set;
        }

        public List<TaxationClaimEntity> ListTaxationClaimEntity
        {
            get;
            set;
        }

        public TaxationInfoEntity TaxationInfoEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}