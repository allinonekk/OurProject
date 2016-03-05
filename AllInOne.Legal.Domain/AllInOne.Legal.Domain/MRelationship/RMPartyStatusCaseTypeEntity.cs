#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMCaseTypeNOA entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   08/06/2011   		      CJ             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: RMCaseTypeNOAEntity.cs
// Description: Represents a standard RMCaseTypeNOA entity.
// </summary>
// <copyright file= "RMNOAForumHrgTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.MRelationship
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'MRelationship.RMPartyStatusCaseTypeEntity'</summary>
    [Serializable]
    public class RMPartyStatusCaseTypeEntity : AbstractLastModified, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RMCaseTypeNOAEntity"/> class.
        /// </summary>
        public RMPartyStatusCaseTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public String CaseStatusCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public String CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public String PartyStatusCode
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            RMPartyStatusCaseTypeEntity toCompareWith = obj as RMPartyStatusCaseTypeEntity;
            return toCompareWith == null ? false : ((this.CaseStatusCode == toCompareWith.CaseStatusCode) && (this.CaseTypeCode == toCompareWith.CaseTypeCode) && (this.PartyStatusCode== toCompareWith.PartyStatusCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseStatusCode.GetHashCode();
            toReturn ^= this.CaseTypeCode.GetHashCode();
            toReturn ^= this.PartyStatusCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}