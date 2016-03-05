#region Header

/*****************************************************************************************************
* Description : This file represents a standard MBailType entity.
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
// File: MBailTypeEntity.cs
// Description: Represents a standard MBailType entity.
// </summary>
// <copyright file= "MBailTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MBailType'</summary>
    [Serializable]
    public class MBailTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the BailTypeCode field. </summary>
        public String BailTypeCode
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
            MBailTypeEntity toCompareWith = obj as MBailTypeEntity;
            return toCompareWith == null ? false : ((this.BailTypeCode == toCompareWith.BailTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BailTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}