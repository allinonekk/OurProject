#region Header

/*****************************************************************************************************
 * Description : This file represents a standard CaseNameIndHistory Entity.
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
// File: CaseNameIndHistoryEntity.cs
// Description: Represents a standard CaseNameIndHistoryEntity.
// </summary>
// <copyright file= "CaseNameIndHistoryEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;

    /// <summary>
    /// Represents a standard domain entity for CaseNameIndHistory.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class CaseNameIndHistoryEntity : AbstractCaseInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public String Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the history id.
        /// </summary>
        /// <value>The history id.</value>
        public String HistoryId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the indicator.
        /// </summary>
        /// <value>The name of the indicator.</value>
        public String IndicatorName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ind value.
        /// </summary>
        /// <value>The ind value.</value>
        public CaseIndType IndValue
        {
            get;
            set;
        }

        #endregion Properties
    }
}