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
    public class DocCommentsEntity : AbstractDocId,IDocumentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>The action.</value>
        public string Action
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the comment id.
        /// </summary>
        /// <value>The comment id.</value>
        public Int32 CommentId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>The comments.</value>
        public string Comments
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the comment.
        /// </summary>
        /// <value>The type of the comment.</value>
        public DocCommentType CommentType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the COM security code.
        /// </summary>
        /// <value>The COM security code.</value>
        public string ComSecurityCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the location id.
        /// </summary>
        /// <value>The location id.</value>
        public Int32? LocationId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName
        {
            get;
            set;
        }

        public DateTime? DirectedDate
        {
            get;
            set;
        }

        #endregion Properties
    }
}