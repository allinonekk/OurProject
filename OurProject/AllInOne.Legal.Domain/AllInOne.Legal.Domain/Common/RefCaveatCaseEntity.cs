#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for RefCaveatCase.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: RefCaveatCaseEntity.cs
// Description: Represents a standard domain entity for RefCaveatCase.
// </summary>
// <copyright file= "RefCaveatCaseEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for RefCaveatCase.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class RefCaveatCaseEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ADMCaveatNoId field.
        /// </summary>
        /// <value>The ADM caveat no id.</value>s
        public String ADMCaveatNoId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the CaseNo field.
        /// </summary>
        /// <value>The case no.</value>
        public String CaseNo
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

            RefCaveatCaseEntity toCompareWith = obj as RefCaveatCaseEntity;
            return toCompareWith == null ? false : ((this.ADMCaveatNoId == toCompareWith.ADMCaveatNoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ADMCaveatNoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}