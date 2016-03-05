#region Header

/*****************************************************************************************************
 * Description : This file represents a standard DocRequestDetailsEntity.
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
// File: DocRequestDetailsEntity.cs
// Description: Represents a standard DocRequestDetailsEntity.
// </summary>
// <copyright file= "DocRequestDetailsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for DocRequestDetails.
    /// It inherits from <see cref="AbstractDocId"/>
    /// </summary>
    [Serializable]
    public class DocRequestDetailsEntity : AbstractDocId,IDocumentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the meta data.
        /// </summary>
        /// <value>The meta data.</value>
        public object MetaData
        {
            get;
            set;
        }

        #endregion Properties
    }
}