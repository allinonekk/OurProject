#region Header

/*****************************************************************************************************
 * Description : This file represents a standard LegislationProvisions.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 01/10/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: LegislationProvisionsEntity.cs
// Description: Represents a standard LegislationProvisions.
// </summary>
// <copyright file= "LegislationProvisionsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for LegislationProvisions.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class LegislationProvisionsEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LegislationProvisionsEntity"/> class.
        /// </summary>
        public LegislationProvisionsEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the sub CrimeCaseInd no.
        /// </summary>
        /// <value>The sub CrimeCaseInd no.</value>
        public CrimeCase CrimeCaseInd
        {
            get;
            set;
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
        /// Gets or sets the LegislationProvisionId field.
        /// </summary>
        /// <value>The legislation provision id.</value>
        public String LegislationProvisionId
        {
            get;
            set;
        }

        public YesNo MainLegInd
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the M legislation act.
        /// </summary>
        /// <value>The M legislation act.</value>
        public MLegislationActEntity MLegislationAct
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the M provision.
        /// </summary>
        /// <value>The M provision.</value>
        public MProvisionEntity MProvision
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the M sub provision.
        /// </summary>
        /// <value>The M sub provision.</value>
        public MSubProvisionEntity MSubProvision
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the provision no.
        /// </summary>
        /// <value>The provision no.</value>
        public string ProvisionNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the seq no.
        /// </summary>
        /// <value>The seq no.</value>
        public int SeqNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the sub provision no.
        /// </summary>
        /// <value>The sub provision no.</value>
        public string SubProvisionNo
        {
            get; set;
        }

        #endregion Properties
    }
}