#region Header

/*****************************************************************************************************
* Description : This file represents a standard OtherReliefsClaim entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   27/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: OtherReliefsClaimEntity.cs
// Description: Represents a standard OtherReliefsClaim entity.
// </summary>
// <copyright file= "OtherReliefsClaimEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for OtherReliefsClaim.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class OtherReliefsClaimEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherReliefsClaimEntity"/> class.
        /// </summary>
        public OtherReliefsClaimEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>ItemNo.</value>
        public Int64 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.OtherReliefsClaim.MRelief - Master.MRelief.OtherReliefsClaims (m:1)'
        /// </summary>
        /// <value>The M relief.</value>
        public virtual MReliefEntity MRelief
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OtherReliefsClaimId field.
        /// </summary>
        /// <value>The other reliefs claim id.</value>
        public String OtherReliefsClaimId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ReliefRemarks field.
        /// </summary>
        /// <value>The relief remarks.</value>
        public String ReliefRemarks
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

            OtherReliefsClaimEntity toCompareWith = obj as OtherReliefsClaimEntity;
            return toCompareWith == null ? false : ((this.OtherReliefsClaimId == toCompareWith.OtherReliefsClaimId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.OtherReliefsClaimId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}