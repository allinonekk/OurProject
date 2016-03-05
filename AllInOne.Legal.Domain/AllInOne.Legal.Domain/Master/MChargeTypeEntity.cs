#region Header

/*****************************************************************************************************
* Description : This file represents a standard MChargeType entity.
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
// File: MChargeTypeEntity.cs
// Description: Represents a standard MChargeType entity.
// </summary>
// <copyright file= "MChargeTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MChargeType'</summary>
    [Serializable]
    public class MChargeTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the ChargeTypeCode field. </summary>
        public String ChargeTypeCode
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
            MChargeTypeEntity toCompareWith = obj as MChargeTypeEntity;
            return toCompareWith == null ? false : ((this.ChargeTypeCode == toCompareWith.ChargeTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ChargeTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}