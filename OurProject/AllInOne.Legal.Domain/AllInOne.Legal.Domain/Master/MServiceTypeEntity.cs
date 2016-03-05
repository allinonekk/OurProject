#region Header

/*****************************************************************************************************
* Description : This file represents a standard MServiceType entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   14/11/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MServiceTypeEntity.cs
// Description: Represents a standard MServiceType entity.
// </summary>
// <copyright file= "MServiceTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MServiceType.
    /// </summary>
    [Serializable]
    public class MServiceTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ServiceTypeCode field.
        /// </summary>
        /// <value>The service type code.</value>
        public String ServiceTypeCode
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

            MServiceTypeEntity toCompareWith = obj as MServiceTypeEntity;
            return toCompareWith == null ? false : ((this.ServiceTypeCode == toCompareWith.ServiceTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ServiceTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}