#region Header

/*****************************************************************************************************
* Description : This file represents a standard RRoleFunctions entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: RRoleFunctionsEntity.cs
// Description: Represents a standard RRoleFunctions entity.
// </summary>
// <copyright file= "RRoleFunctionsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for RRoleFunctions.
    /// </summary>
    [Serializable]
    public class RRoleFunctionsEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the FunctionCode field. </summary>
        public System.String FunctionCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the RoleCode field. </summary>
        public System.String RoleCode
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
            RRoleFunctionsEntity toCompareWith = obj as RRoleFunctionsEntity;
            return toCompareWith == null ? false : ((this.RoleCode == toCompareWith.RoleCode) && (this.FunctionCode == toCompareWith.FunctionCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RoleCode.GetHashCode();
            toReturn ^= this.FunctionCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}