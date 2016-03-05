#region Header

/*****************************************************************************************************
 * Description : This file represents a standard CaseHearingAccessibility entity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			        Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010               Japheth             	Created
 *****************************************************************************************************/
// <summary>
// File: CaseHearingAccessibilityEntity.cs
// Description: Represents a standard CaseHearingAccessibility entity.
// </summary>
// <copyright file= "CaseHearingAccessibilityEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for CaseHearingAccessibility.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class CaseHearingAccessibilityEntity : AbstractCaseInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the assign date.
        /// </summary>
        /// <value>The assign date.</value>
        public DateTime AssignDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the hearing access ind.
        /// </summary>
        /// <value>The hearing access ind.</value>
        public HearingAccessInd HearingAccessInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the M designation.
        /// </summary>
        /// <value>The M designation.</value>
        public MDesignationEntity MDesignation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the MHRG.
        /// </summary>
        /// <value>The type of the MHRG.</value>
        public MHRGTypeEntity MHRGType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UserId field.
        /// </summary>
        /// <value>The User Id</value>
        public String UserId
        {
            get;
            set;
        }

        #endregion Properties
    }
}