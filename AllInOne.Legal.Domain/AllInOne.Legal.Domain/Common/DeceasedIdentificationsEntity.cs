#region Header

/*****************************************************************************************************
 * Description : This file represents a standard DeceasedIdentifications entity.
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
// File: DeceasedIdentificationsEntity.cs
// Description: Represents a standard DeceasedIdentifications entity.
// </summary>
// <copyright file= "DeceasedIdentificationsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for DeceasedIdentifications.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class DeceasedIdentificationsEntity : AbstractSubmissionGroup
    {
        #region Properties

        /// <summary>
        /// Gets or sets the deceased identification id.
        /// </summary>
        /// <value>The deceased identification id.</value>
        public String DeceasedIdentificationId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the id number.
        /// </summary>
        /// <value>The id number.</value>
        public String IdNumber
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the id remarks.
        /// </summary>
        /// <value>The id remarks.</value>
        public String IdRemarks
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public int ItemNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the M country.
        /// </summary>
        /// <value>The M country.</value>
        public MCountryEntity MCountry
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the type of the M person id.
        /// </summary>
        /// <value>The type of the M person id.</value>
        public MPersonIDTypeEntity MPersonIdType
        {
            get; set;
        }

        public string IdCountryOtherText { get; set; }

        #endregion Properties
    }
}