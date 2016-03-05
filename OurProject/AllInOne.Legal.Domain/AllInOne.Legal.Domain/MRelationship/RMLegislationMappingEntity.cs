#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMLegislationMapping entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   19/04/2012   		      Nithin             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: RMLegislationMappingEntity.cs
// Description: Represents a standard RMLegislationMapping entity.
// </summary>
// <copyright file= "RMLegislationMappingEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.MRelationship
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'MRelationship.RMLegislationMappingEntity'</summary>
    [Serializable]
    public class RMLegislationMappingEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the RMLegislationMappingId field. </summary>
        public System.String RMLegislationMappingId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ActCode field. </summary>
        public System.String ActCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ProvisionCode field. </summary>
        public System.String ProvisionCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ProvisionValue field. </summary>
        public System.String ProvisionValue
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubProvisionCode field. </summary>
        public System.String SubProvisionCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubProvisionValue field. </summary>
        public System.String SubProvisionValue
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ITMODescription field. </summary>
        public System.String ITMODescription
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
            RMLegislationMappingEntity toCompareWith = obj as RMLegislationMappingEntity;
            return toCompareWith == null ? false : (this.RMLegislationMappingId == toCompareWith.RMLegislationMappingId);
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RMLegislationMappingId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}