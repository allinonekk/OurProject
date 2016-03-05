#region Header

/*****************************************************************************************************
* Description : This file represents a standard SubCaseStatusHistory entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   27/10/2014   		      Aaron             	 	Created
*****************************************************************************************************/
// <summary>
// File: SubCaseStatusHistoryEntity.cs
// Description: Represents a standard SubCaseStatusHistory entity.
// </summary>
// <copyright file= "SubCaseStatusHistoryEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2014 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCase
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    /// <summary>

    /// Represents a standard domain entity for SubCaseStatusHistory.
    /// It inherits from <see cref="AbstractSubCaseInfo"/>
    /// </summary>
    [Serializable]
    public class SubCaseStatusHistoryEntity : AbstractSubCaseInfo, ISubCaseEntity
    {

        #region Properties

        public string SubCaseStatusHistoryId { get; set; }
        public MCaseStatusEntity MCaseStatus { get; set; }
        public DateTime SubCaseStatusDate { get; set; }
        public string Remarks { get; set; }

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

            SubCaseStatusHistoryEntity toCompareWith = obj as SubCaseStatusHistoryEntity;
            return toCompareWith == null ? false : ((this.SubCaseStatusHistoryId == toCompareWith.SubCaseStatusHistoryId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SubCaseStatusHistoryId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}