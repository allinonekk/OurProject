#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RCaseLinked.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 04/10/2010   		      Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: RCaseLinkedEntity.cs
// Description: Represents a standard RCaseLinked.
// </summary>
// <copyright file= "RCaseLinkedEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for RCaseLinked.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class RCaseLinkedEntity : AbstractCaseInfo, ICaseEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RCaseLinkedEntity"/> class.
        /// </summary>
        public RCaseLinkedEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the CrossCourtInd field. </summary>
        public System.String CrossCourtInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkedDate field. </summary>
        public System.DateTime LinkedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkGroupId field. </summary>
        public System.String LinkGroupId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public YesNo ObsInd
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

            RCaseLinkedEntity toCompareWith = obj as RCaseLinkedEntity;
            return toCompareWith == null ? false : ((this.LinkGroupId == toCompareWith.LinkGroupId) && (this.CaseInfoId == toCompareWith.CaseInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LinkGroupId.GetHashCode();
            toReturn ^= this.CaseInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}