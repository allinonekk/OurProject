#region Header

/*****************************************************************************************************
* Description : This file represents a standard SubCaseInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   20/09/2010   		      Japheth             	 	Created
*   10/11/2010   		      Swaroop             	 	Updated properties list.
*****************************************************************************************************/
// <summary>
// File: SubCasePartyEntity.cs
// Description: Represents a standard SubCaseInfo entity.
// </summary>
// <copyright file= "SubCasePartyEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCase
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for SubCaseParty.
    /// It inherits from <see cref="AbstractCaseInfoSubCaseInfoCaseParty"/>
    /// </summary>
    [Serializable]
    public class SubCasePartyEntity : AbstractCaseInfoSubCaseInfoCaseParty, ISubCaseEntity
    {
        #region Properties

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'SubCase.SubCaseParty.MPartyType - Master.MPartyType.SubCaseParties (m:1)'
        /// </summary>
        /// <value>The type of the M party.</value>
        public MPartyTypeEntity MSubCasePartyType
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

        /// <summary>
        /// Gets or sets the SubCaseOrdinalNumber field.
        /// </summary>
        /// <value>The sub case ordinal number.</value>
        public String SubCaseOrdinalNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCasePartyId field.
        /// </summary>
        /// <value>The SubCasePartyId.</value>
        public String SubCasePartyId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCasePartyNo field.
        /// </summary>
        /// <value>The sub case party no.</value>
        public String SubCasePartyNo
        {
            get;
            set;
        }

        public RoleCode RoleCode
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

            SubCasePartyEntity toCompareWith = obj as SubCasePartyEntity;
            return toCompareWith == null ? false : ((this.SubCasePartyId == toCompareWith.SubCasePartyId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SubCasePartyId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}