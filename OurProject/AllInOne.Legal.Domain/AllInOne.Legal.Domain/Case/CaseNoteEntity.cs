#region Header

/*****************************************************************************************************
 * Description : This file represents a standard CaseNote entity.
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
// File: CaseNoteEntity.cs
// Description: Represents a standard CaseNote entity.
// </summary>
// <copyright file= "CaseNoteEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;

    /// <summary>
    /// Represents a standard domain entity for CaseNote.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class CaseNoteEntity : AbstractCaseInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>The content.</value>
        public String Content
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the obs ind.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        public YesNo SyncRequired
        {
            get;
            set;
        }
        #endregion Properties
    }
}