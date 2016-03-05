#region Header

/*****************************************************************************************************
* Description : This file represents a standard RespondentCaseDetailInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   13/03/2012   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: RespondentCaseDetailInfoEntity.cs
// Description: Represents a standard RespondentCaseDetailInfo entity.
// </summary>
// <copyright file= "RespondentCaseDetailInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Abstract;

    /// <summary>
    /// Represents a standard domain entity for RespondentCaseDetailInfoEntity.
    /// </summary>
    [Serializable]
    public class RespondentCaseDetailInfoEntity : AbstractSubmissionGroup,ICommonEntity
    {

        #region Properties


        /// <summary>
        /// Gets or sets the respondent case detail info id.
        /// </summary>
        /// <value>The respondent case detail info id.</value>
        public String RespondentCaseDetailInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the date of service of appellant case.
        /// </summary>
        /// <value>The date of service of appellant case.</value>
        public DateTime? DateOfServiceOfAppellantCase
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
            RespondentCaseDetailInfoEntity toCompareWith = obj as RespondentCaseDetailInfoEntity;
            return toCompareWith == null ? false : ((this.RespondentCaseDetailInfoId == toCompareWith.RespondentCaseDetailInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RespondentCaseDetailInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}