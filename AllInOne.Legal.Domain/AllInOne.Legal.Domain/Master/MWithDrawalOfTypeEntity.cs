#region Header

/*****************************************************************************************************
* Description : This file represents a standard MWithDrawalOfType entity.
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
// File: MWithDrawalOfTypeEntity.cs
// Description: Represents a standard MWithDrawalOfType entity.
// </summary>
// <copyright file= "MWithDrawalOfTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MWithDrawalOfType.
    /// </summary>
    [Serializable]
    public class MWithDrawalOfTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the WitOfCode field.
        /// </summary>
        /// <value>The WitOf code.</value>
        public String WitOfCode
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

            MWithDrawalOfTypeEntity toCompareWith = obj as MWithDrawalOfTypeEntity;
            return toCompareWith == null ? false : ((this.WitOfCode == toCompareWith.WitOfCode));
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
            toReturn ^= this.WitOfCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}