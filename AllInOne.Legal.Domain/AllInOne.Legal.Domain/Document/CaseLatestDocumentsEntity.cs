#region Header

/*****************************************************************************************************
 * Description : This file represents a standard CaseLatestDocuments entity.
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
// File: CaseLatestDocumentsEntity.cs
// Description: Represents a standard CaseLatestDocuments entity.
// </summary>
// <copyright file= "CaseLatestDocumentsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for CaseLatestDocuments.
    /// It inherits from <see cref="AbstractCaseInfoDocId"/>
    /// </summary>
    [Serializable]
    public class CaseLatestDocumentsEntity : AbstractCaseInfoDocId
    {
        #region Properties

        /// <summary>
        /// Gets or sets the M doc code.
        /// </summary>
        /// <value>The M doc code.</value>
        public MDocCodeEntity MDocCode
        {
            get;
            set;
        }

        #endregion Properties
    }
}