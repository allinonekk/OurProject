#region Header

/*****************************************************************************************************
* Description : This file represents a standard MServeStatus entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MServeStatusEntity.cs
// Description: Represents a standard MServeStatus entity.
// </summary>
// <copyright file= "MServeStatusEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MServeStatus.
    /// </summary>
    [Serializable]
    public class MServeStatusEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the SerStatusCode field.
        /// </summary>
        /// <value>The ser status code.</value>
        public String SerStatusCode
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

            MServeStatusEntity toCompareWith = obj as MServeStatusEntity;
            return toCompareWith == null ? false : ((this.SerStatusCode == toCompareWith.SerStatusCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SerStatusCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}