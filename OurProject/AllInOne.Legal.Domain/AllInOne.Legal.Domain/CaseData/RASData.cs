#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for RegistrarsAppeals sub case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   19/12/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: RegistrarsAppealsData.cs
// Description: Represents a standard data container object for RegistrarsAppeals sub case type.
// </summary>
// <copyright file= "RegistrarsAppealsData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseData
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.CaseSpecific;

    /// <summary>
    /// Represents a standard data container object for RegistrarsAppeals sub case type.
    /// </summary>
    [Serializable]
    public class RASData : ICaseTypeInfo
    {
        #region Properties

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
        /// Gets or sets the List NatureOfApplication Entity.
        /// </summary>
        /// <value>The List of NatureOfApplication Entity.</value>
        public List<NatureOfApplicationEntity> ListNatureOfApplicationEntity
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
        /// Gets or sets the ref order details.
        /// </summary>
        /// <value>The ref order details.</value>
        public List<RefOrderDetailEntity> ListRefOrderDetailEntity
        {
            get;
            set;
        }

        public List<RefOrderJOInfoEntity> ListRefOrderJOInfoEntity
        {
            get;
            set;
        }

        public List<DCACAOriginatingCasePartyInfoEntity> ListDCACAOriginatingCasePartyInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RARAS info entity.
        /// </summary>
        /// <value>The RARAS info entity.</value>
        public RASInfoEntity RASInfoEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}