#region Header

/*****************************************************************************************************
* Description : This file represents a standard LACCancellationInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LACCancellationInfoEntity.cs
// Description: Represents a standard LACCancellationInfo entity.
// </summary>
// <copyright file= "LACCancellationInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LAP
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for LACCancellationInfo.
    /// It inherits from <see cref="AbstractLACInfoDocId"/>
    /// </summary>
    [Serializable]
    public class LACCancellationInfoEntity : AbstractLACInfoDocId, ILAPEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CancellationId field.
        /// </summary>
        /// <value>The cancellation id.</value>
        public String CancellationId
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

            LACCancellationInfoEntity toCompareWith = obj as LACCancellationInfoEntity;
            return toCompareWith == null ? false : ((this.CancellationId == toCompareWith.CancellationId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CancellationId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}