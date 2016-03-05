#region Header

/*****************************************************************************************************
* Description : This file represents a standard CasePartyCitizenshipEntity entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   01/04/2011   		      Nithin                 	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CasePartyCitizenshipEntity.cs
// Description: Represents a standard CasePartyCitizenshipEntity entity.
// </summary>
// <copyright file= "CasePartyBailorInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Case.CasePartyCitizenshipEntity'</summary>
    [Serializable]
    public class CasePartyCitizenshipEntity : AbstractCaseParty, ICaseEntity
    {
        #region Properties

        /// <summary>Gets or sets the CasePartyCitizenshipId field. </summary>
        public String CasePartyCitizenshipId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CitizenshipStatus field. </summary>
        public CitizenshipStatus CitizenshipStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MCountry field. </summary>
        public MCountryEntity MCountry
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
            CasePartyCitizenshipEntity toCompareWith = obj as CasePartyCitizenshipEntity;
            return toCompareWith == null ? false : ((this.CasePartyCitizenshipId == toCompareWith.CasePartyCitizenshipId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CasePartyCitizenshipId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}