#region Header

/*****************************************************************************************************
 * Description : This file represents a standard OSPDRelationEntity.
 *----
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * Sep 20 2010  2:40PM        Japheth             	 	Created
 *****************************************************************************************************
 *	                                    File Usage
 *	Module
 *	1. Case Conversion
 *
 *****************************************************************************************************/
// <summary>
// File: OSPDRelationEntity.cs
// Description: Represents a standard OSPDRelationEntity.
// </summary>
// <copyright file= "OSPDRelationEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for OSPDRelation.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class OSPDRelationEntity : AbstractSubmissionGroup
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="OSPDRelationEntity"/> class.</summary> 
        public OSPDRelationEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public String DCPID
        {
            get; set;
        }

        public MRelationshipEntity MRelationship
        {
            get; set;
        }

        public String OtherRelation
        {
            get; set;
        }

        #endregion Properties
    }
}