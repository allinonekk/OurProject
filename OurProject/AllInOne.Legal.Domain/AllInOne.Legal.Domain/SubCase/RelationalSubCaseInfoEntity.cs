#region Header

/*****************************************************************************************************
* Description : This file represents a standard RelationalSubCaseInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   15/10/2011   		      Nithin             	 	Created

*****************************************************************************************************/
// <summary>
// File: RelationalSubCaseInfoEntity.cs
// Description: Represents a standard RelationalSubCaseInfo entity.
// </summary>
// <copyright file= "RelationalSubCaseInfoEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for RelationalSubCaseInfo.
    /// It inherits from <see cref="AbstractSubCaseInfo"/>
    /// </summary>
    [Serializable]
    public class RelationalSubCaseInfoEntity : AbstractSubCaseInfoLastModified, ISubCaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the relational sub case info id.
        /// </summary>
        /// <value>The relational sub case info id.</value>
        public String RelationalSubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the rel sub case info id.
        /// </summary>
        /// <value>The rel sub case info id.</value>
        public String RelSubCaseInfoId
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

            RelationalSubCaseInfoEntity toCompareWith = obj as RelationalSubCaseInfoEntity;
            return toCompareWith == null ? false : ((this.RelationalSubCaseInfoId == toCompareWith.RelationalSubCaseInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RelationalSubCaseInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}