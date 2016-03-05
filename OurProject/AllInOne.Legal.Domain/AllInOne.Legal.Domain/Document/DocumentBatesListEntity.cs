#region Header

/*****************************************************************************************************
 * Description : This file represents a standard DocComments entity.
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
// File: DocCommentsEntity.cs
// Description: Represents a standard DocComments entity.
// </summary>
// <copyright file= "DocCommentsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for DocComments.
    /// It inherits from <see cref="AbstractDocId"/>
    /// </summary>
    [Serializable]
    public class DocumentBatesListEntity : AbstractCaseInfoDocId, IDocumentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>The comments.</value>
        public String BatesSequence
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>The action.</value>
        public String DocBatesId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the comment id.
        /// </summary>
        /// <value>The comment id.</value>
        public String SubmissiongroupId
        {
            get;
            set;
        }

        #endregion Properties
    }
}