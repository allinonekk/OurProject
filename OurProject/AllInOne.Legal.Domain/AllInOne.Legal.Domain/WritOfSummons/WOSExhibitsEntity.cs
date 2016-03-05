#region Header

/*****************************************************************************************************
 * Description : This file represents a standard WOSExhibitsEntity.
 *----
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * Sep 20 2010  2:56PM        Japheth             	 	Created
 *****************************************************************************************************
 *	                                    File Usage
 *	Module
 *	1. Case Conversion
 *
 *****************************************************************************************************/
// <summary>
// File: WOSExhibitsEntity.cs
// Description: Represents a standard WOSExhibitsEntity.
// </summary>
// <copyright file= "WOSExhibitsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.WritOfSummons
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for WOSExhibits.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class WOSExhibitsEntity : AbstractCaseInfo
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="WOSExhibitsEntity"/> class.</summary> 
        public WOSExhibitsEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public string Description
        {
            get; set;
        }

        public DateTime HearingDate
        {
            get; set;
        }

        public string Notes
        {
            get; set;
        }

        public string ProvidingParty
        {
            get; set;
        }

        public string ProvingWitness
        {
            get; set;
        }

        public string SubmissionGroupID
        {
            get; set;
        }

        public int WOSExhibitsID
        {
            get; set;
        }

        #endregion Properties
    }
}