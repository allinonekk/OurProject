#region Header

/*****************************************************************************************************
* Description : This file represents a standard MFormTemplateLocation entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   20/10/2010   		      Rajendra             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MFormTemplateLocation.cs
// Description: Represents a standard MFormTemplateLocation entity.
// </summary>
// <copyright file= "MFormTemplateLocation.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MFormTemplateLocation.
    /// </summary>
    [Serializable]
    public class MFormTemplateLocationEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MFormTemplateLocation"/> class.
        /// </summary>
        public MFormTemplateLocationEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the DocCategoryCode.
        /// </summary>
        /// <value>The is interfaced.</value>
        public String DocCategoryCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocCode field.
        /// </summary>
        /// <value>The DocCode.</value>
        public String DocCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FormLocation field.
        /// </summary>
        /// <value>The FormLocation.</value>
        public String FormLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FormTemplateID.
        /// </summary>
        /// <value>The FormTemplateID</value>
        public String FormTemplateID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FormVersion.
        /// </summary>
        /// <value>The FormVersion</value>
        public String FormVersion
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FormXMLLocation.
        /// </summary>
        /// <value>The FormXMLLocation.</value>
        public String FormXMLLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SiteURL field.
        /// </summary>
        /// <value>The SiteURL.</value>
        public String SiteURL
        {
            get;
            set;
        }

        #endregion Properties
    }
}