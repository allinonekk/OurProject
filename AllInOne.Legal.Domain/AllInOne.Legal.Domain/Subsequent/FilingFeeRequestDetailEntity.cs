#region Header

/*****************************************************************************************************
 * Description : This file represents a standard FilingFeeRequestDetailEntity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 11/05/2011   		      Nithin             	 	Created
 *****************************************************************************************************/
// <summary>
// File: FilingFeeRequestDetailEntity.cs
// Description: Represents a standard FilingFeeRequestDetailEntity.
// </summary>
// <copyright file= "FilingFeeRequestDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for FilingFeeRequestDetailEntity.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class FilingFeeRequestDetailEntity : AbstractLastModified, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AmtApproved field.
        /// </summary>
        /// <value>The AmtApproved.</value>
        public Decimal? AmtApproved
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AmtRequested field.
        /// </summary>
        /// <value>The AmtRequested.</value>
        public Decimal? AmtRequested
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BilledDate field.
        /// </summary>
        /// <value>The BilledDate.</value>
        public DateTime BilledDate
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Subsequent.FileInspection.DocumentInfo - Document.DocumentInfo.FileInspections (m:1)'
        /// </summary>
        /// <value>The doc id.</value>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FilingFeeRequestDetailId field.
        /// </summary>
        /// <value>The FilingFeeRequestDetailId.</value>
        public String FilingFeeRequestDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the isInterfaced field.
        /// </summary>
        /// <value>The isInterfacedr.</value>
        public YesNo isInterfaced
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RequestDocId field.
        /// </summary>
        /// <value>The RequestDocId.</value>
        public String RequestDocId
        {
            get;
            set;
        }

        public RequestType Type
        {
            get;
            set;
        }

        #endregion Properties
    }
}