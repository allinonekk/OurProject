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
*   20/01/2011   		      CJ                 	 	Created
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

    /// <summary>Class which represents the entity 'Master.MNatureOfAppeal'</summary>
    [Serializable]
    public class MNatureOfAppealEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the NatureOfAppealCode field. </summary>
        public String NatureOfAppealCode
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
            MNatureOfAppealEntity toCompareWith = obj as MNatureOfAppealEntity;
            return toCompareWith == null ? false : ((this.NatureOfAppealCode == toCompareWith.NatureOfAppealCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NatureOfAppealCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}