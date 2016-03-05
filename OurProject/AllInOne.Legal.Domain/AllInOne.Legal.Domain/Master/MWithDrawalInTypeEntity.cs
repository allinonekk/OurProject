#region Header

/*****************************************************************************************************
* Description : This file represents a standard MWithDrawalInType entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   08/02/2011   		      Khin             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: MWithDrawalInTypeEntity.cs
// Description: Represents a standard MWithDrawalInType entity.
// </summary>
// <copyright file= "MWithDrawalInTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MWithDrawalInType.
    /// </summary>
    [Serializable]
    public class MWithDrawalInTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the WitInCode field.
        /// </summary>
        /// <value>The WitIn code.</value>
        public String WitInCode
        {
            get; set;
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

            MWithDrawalInTypeEntity toCompareWith = obj as MWithDrawalInTypeEntity;
            return toCompareWith == null ? false : ((this.WitInCode == toCompareWith.WitInCode));
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
            toReturn ^= this.WitInCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}