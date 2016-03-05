#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RCaseSubmission.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 04/10/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: RCaseSubmissionEntity.cs
// Description: Represents a standard RCaseSubmission.
// </summary>
// <copyright file= "RCaseSubmissionEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for RCaseSubmission.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class RCaseSubmissionEntity : AbstractCaseInfoSubmissionGroup, ICaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the R case submission id.
        /// </summary>
        /// <value>The R case submission id.</value>
        public String RCaseSubmissionId
        {
            get; set;
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            RCaseSubmissionEntity toCompareWith = obj as RCaseSubmissionEntity;
            return toCompareWith == null ? false : ((this.RCaseSubmissionId == toCompareWith.RCaseSubmissionId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RCaseSubmissionId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}