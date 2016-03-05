#region Header

/*****************************************************************************************************
* Description : This file represents a standard MNatureOfAppeal entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   27/01/2011   		      Nithin                 	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MNatureOfAppealEntity.cs
// Description: Represents a standard MNatureOfAppeal entity.
// </summary>
// <copyright file= "MNatureOfAppealEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MNatureOfInCapacity'</summary>
    [Serializable]
    public class MNatureOfInCapacityEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        public String NOICCode
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            MNatureOfInCapacityEntity toCompareWith = obj as MNatureOfInCapacityEntity;
            return toCompareWith == null ? false : ((this.NOICCode == toCompareWith.NOICCode));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NOICCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}