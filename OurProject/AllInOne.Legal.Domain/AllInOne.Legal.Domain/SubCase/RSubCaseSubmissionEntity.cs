#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RSubCaseSubmission entity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 10/11/2010                 Swaroop             	 	Created
 *
 *****************************************************************************************************/
// <summary>
// File: RSubCaseSubmissionEntity.cs
// Description: Represents a standard RSubCaseSubmission entity.
// </summary>
// <copyright file= "RSubCaseSubmissionEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCase
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for RSubCaseSubmission.
    /// It inherits from <see cref="AbstractSubCaseInfo"/>
    /// </summary>
    [Serializable]
    public class RSubCaseSubmissionEntity : AbstractSubCaseInfo, ISubCaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the RSubCaseSubmissionId field.
        /// </summary>
        /// <value>The R sub case submission id.</value>
        public String RSubCaseSubmissionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group id.</value>
        public String SubmissionGroupId
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

            RSubCaseSubmissionEntity toCompareWith = obj as RSubCaseSubmissionEntity;
            return toCompareWith == null ? false : ((this.RSubCaseSubmissionId == toCompareWith.RSubCaseSubmissionId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RSubCaseSubmissionId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}