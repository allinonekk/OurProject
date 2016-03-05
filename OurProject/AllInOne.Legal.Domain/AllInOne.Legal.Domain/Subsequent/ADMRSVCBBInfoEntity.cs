#region Header

/*****************************************************************************************************
* Description : This file represents a standard ADMRSVCBBInfo entity.
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
// File: ADMRSVCBBInfoEntity.cs
// Description: Represents a standard ADMRSVCBBInfo entity.
// </summary>
// <copyright file= "ADMRSVCBBInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for ADMRSVCBBInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class ADMRSVCBBInfoEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        /// <summary>Gets or sets the ADMRSVCBBInfoId field. </summary>
        public String ADMRSVCBBInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubCaseInfoId field. </summary>
        public string SubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubjectAICId field. </summary>
        public System.String SubjectAICId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubjectDCPAICId field. </summary>
        public System.String SubjectDCPAICId
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

            ADMRSVCBBInfoEntity toCompareWith = obj as ADMRSVCBBInfoEntity;
            return toCompareWith == null ? false : ((this.ADMRSVCBBInfoId == toCompareWith.ADMRSVCBBInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ADMRSVCBBInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}