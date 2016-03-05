#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for LiquidatedClaim.
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
// File: LiquidatedClaimEntity.cs
// Description: Represents a standard domain entity for LiquidatedClaim.
// </summary>
// <copyright file= "LiquidatedClaimEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for AdmInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class LiquidatedClaimEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="LiquidatedClaimEntity"/> class.</summary>
        public LiquidatedClaimEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item no.</value>
        public Int64 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LIQAmount field.
        /// </summary>
        /// <value>The LIQ amount.</value>
        public Decimal? LIQAmount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the LIQAwardedAmount field.
        /// </summary>
        /// <value>The LIQ awarded amount.</value>
        public Decimal? LIQAwardedAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LIQSGDAmount field.
        /// </summary>
        /// <value>The LIQSGD amount.</value>
        public Decimal? LIQSGDAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LiquidatedClaimId field.
        /// </summary>
        /// <value>The liquidated claim id.</value>
        public String LiquidatedClaimId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.LiquidatedClaim.MCurrency - Master.MCurrency.LiquidatedClaims (m:1)'
        /// </summary>
        /// <value>The M currency.</value>
        public MCurrencyEntity MCurrency
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
            LiquidatedClaimEntity toCompareWith = obj as LiquidatedClaimEntity;
            return toCompareWith == null ? false : ((this.LiquidatedClaimId == toCompareWith.LiquidatedClaimId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LiquidatedClaimId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}