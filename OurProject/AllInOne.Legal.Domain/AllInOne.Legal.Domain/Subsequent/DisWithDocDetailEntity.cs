#region Header

/*****************************************************************************************************
* Description : This file represents a standard DisWithDocDetail entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*    08/02/2011   		      Khin             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: DisWithDocDetailEntity.cs
// Description: Represents a standard DisWithDocDetail entity.
// </summary>
// <copyright file= "DisWithDocDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for DisWithDocDetail.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class DisWithDocDetailEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the DisWithDocDetailId field.
        /// </summary>
        /// <value>The DisWithDocDetail id.</value>
        public String DisWithDocDetailId
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

            DisWithDocDetailEntity toCompareWith = obj as DisWithDocDetailEntity;
            return toCompareWith == null ? false : ((this.DisWithDocDetailId == toCompareWith.DisWithDocDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DisWithDocDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}