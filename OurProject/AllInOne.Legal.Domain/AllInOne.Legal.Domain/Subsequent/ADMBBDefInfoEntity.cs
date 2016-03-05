#region Header

/*****************************************************************************************************
* Description : This file represents a standard ADMBBDefInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/11/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ADMBBDefInfoEntity.cs
// Description: Represents a standard ADMBBDefInfo entity.
// </summary>
// <copyright file= "ADMBBDefInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for ADMBBDefInfo.
    /// It inherits from <see cref="AbstractCaseParty"/>
    /// </summary>
    [Serializable]
    public class ADMBBDefInfoEntity : AbstractCaseParty, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ADMBBDefInfoId field.
        /// </summary>
        /// <value>The ADMBB def info id.</value>
        public String ADMBBDefInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ADMRSVCBBInfoId field.
        /// </summary>
        /// <value>The ADMRSVCBB info id.</value>
        public String ADMRSVCBBInfoId
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
            if(obj == null)
            {
                return false;
            }

            ADMBBDefInfoEntity toCompareWith = obj as ADMBBDefInfoEntity;
            return toCompareWith == null ? false : ((this.ADMBBDefInfoId == toCompareWith.ADMBBDefInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ADMBBDefInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}