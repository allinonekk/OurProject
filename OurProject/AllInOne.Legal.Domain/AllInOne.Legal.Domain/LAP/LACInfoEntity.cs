#region Header

/*****************************************************************************************************
* Description : This file represents a standard LACInfo entity.
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
// File: LACInfoEntity.cs
// Description: Represents a standard LACInfo entity.
// </summary>
// <copyright file= "LACInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LAP
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for LACInfo.
    /// It inherits from <see cref="AbstractCaseInfoLACInfoLABPartyId"/>
    /// </summary>
    [Serializable]
    public class LACInfoEntity : AbstractCaseInfoLACInfoLABPartyId, ILAPEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CancellationDateTime field.
        /// </summary>
        /// <value>The cancellation date time.</value>
        public DateTime? CancellationDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ClosedDateTime field.
        /// </summary>
        /// <value>The closed date time.</value>
        public DateTime? ClosedDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ConcludedDateTime field.
        /// </summary>
        /// <value>The concluded date time.</value>
        public DateTime? ConcludedDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ExpiredDateTime field.
        /// </summary>
        /// <value>The expired date time.</value>
        public DateTime? ExpiredDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IssuedDateTime field.
        /// </summary>
        /// <value>The issued date time.</value>
        public DateTime? IssuedDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LACConcludedStatus field.
        /// </summary>
        /// <value>The LAC concluded status.</value>
        public LACConcludedStatus LACConcludedStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LACNo field.
        /// </summary>
        /// <value>The LAC no.</value>
        public String LACNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LACStatus field.
        /// </summary>
        /// <value>The LAC status.</value>
        public LACStatus LACStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LACType field.
        /// </summary>
        /// <value>The type of the LAC.</value>
        public String LACType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RevocationDateTime field.
        /// </summary>
        /// <value>The revocation date time.</value>
        public DateTime? RevocationDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the concluded by court date time.
        /// </summary>
        /// <value>The concluded by court date time.</value>
        public DateTime? ConcludedByCourtDateTime
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

            LACInfoEntity toCompareWith = obj as LACInfoEntity;
            return toCompareWith == null ? false : ((this.LACInfoId == toCompareWith.LACInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LACInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}