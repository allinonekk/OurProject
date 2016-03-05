#region Header

/*****************************************************************************************************
 * Description : This file represents a standard CasePartyStatusHistory entity.
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
// File: CasePartyStatusHistoryEntity.cs
// Description: Represents a standard CasePartyStatusHistory entity.
// </summary>
// <copyright file= "CasePartyStatusHistoryEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for CasePartyStatusHistory.
    /// It inherits from <see cref="AbstractCaseParty"/>
    /// </summary>
    [Serializable]
    public class CasePartyStatusHistoryEntity : AbstractCaseParty, ICaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public int ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the M party status.
        /// </summary>
        /// <value>The M party status.</value>
        public MPartyStatusEntity MPartyStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the party status date.
        /// </summary>
        /// <value>The party status date.</value>
        public DateTime PartyStatusDate
        {
            get;
            set;
        }

        public String Remarks
        {
            get;
            set;
        }

        #endregion Properties
    }
}