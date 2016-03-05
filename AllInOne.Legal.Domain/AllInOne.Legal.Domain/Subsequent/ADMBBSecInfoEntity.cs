#region Header

/*****************************************************************************************************
* Description : This file represents a standard ADMBBSecInfo entity.
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
// File: ADMBBSecInfoEntity.cs
// Description: Represents a standard ADMBBSecInfo entity.
// </summary>
// <copyright file= "ADMBBSecInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for ADMBBSecInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class ADMBBSecInfoEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ADMBBSecInfoId field.
        /// </summary>
        /// <value>The ADMBB sec info id.</value>
        public String ADMBBSecInfoId
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
        /// Gets or sets the IsMainSurety field.
        /// </summary>
        /// <value>The is main surety.</value>
        public YesNo IsMainSurety
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SecurityAddress field.
        /// </summary>
        /// <value>The security address.</value>
        public String SecurityAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SecurityName field.
        /// </summary>
        /// <value>The name of the security.</value>
        public String SecurityName
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

            ADMBBSecInfoEntity toCompareWith = obj as ADMBBSecInfoEntity;
            return toCompareWith == null ? false : ((this.ADMBBSecInfoId == toCompareWith.ADMBBSecInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ADMBBSecInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}