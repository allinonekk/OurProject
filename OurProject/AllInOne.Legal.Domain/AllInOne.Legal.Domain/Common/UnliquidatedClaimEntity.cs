#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for UnliquidatedClaim.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: UnliquidatedClaimEntity.cs
// Description: Represents a standard domain entity for UnliquidatedClaim.
// </summary>
// <copyright file= "UnliquidatedClaimEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for UnliquidatedClaim.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class UnliquidatedClaimEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="UnliquidatedClaimEntity"/> class.</summary>
        public UnliquidatedClaimEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the Description field.
        /// </summary>
        /// <value>The description.</value>
        public String Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The unliquidated claim id.</value>
        public Int64 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UnLIQClaimType field.
        /// </summary>
        /// <value>The type of the un LIQ claim.</value>
        public UnliquidatedClaimType UnLIQClaimType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UnliquidatedClaimId field.
        /// </summary>
        /// <value>The unliquidated claim id.</value>
        public String UnliquidatedClaimId
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

            UnliquidatedClaimEntity toCompareWith = obj as UnliquidatedClaimEntity;
            return toCompareWith == null ? false : ((this.UnliquidatedClaimId == toCompareWith.UnliquidatedClaimId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.UnliquidatedClaimId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}