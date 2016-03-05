#region Header

/*****************************************************************************************************
 * Description : This file represents a standard CaseStatusHistory entity.
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
// File: CaseStatusHistoryEntity.cs
// Description: Represents a standard CaseStatusHistory entity.
// </summary>
// <copyright file= "CaseStatusHistoryEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for CaseStatusHistory.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class CaseStatusHistoryEntity : AbstractCaseInfo, ICaseEntity
    {
        #region Properties

        public String CaseStatusHistoryId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the M case status.
        /// </summary>
        /// <value>The M case status.</value>
        public MCaseStatusEntity MCaseStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the status date.
        /// </summary>
        /// <value>The status date.</value>
        public DateTime StatusDate
        {
            get;
            set;
        }

        public string Remarks { get; set; }

        #endregion Properties
    }
}