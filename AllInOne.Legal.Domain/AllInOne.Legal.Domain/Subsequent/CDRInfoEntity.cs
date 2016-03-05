#region Header

/*****************************************************************************************************
 * Description : This file represents a standard CDRInfo.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 19/12/2010   		      Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: CDRInfoEntity.cs
// Description: Represents a standard CDRInfo.
// </summary>
// <copyright file= "CDRInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for CDRInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class CDRInfoEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CDRInfoId field.
        /// </summary>
        /// <value>The CDR info id.</value>
        public String CDRInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NatureOfCDR field.
        /// </summary>
        /// <value>The nature of CDR.</value>
        public NatureOfCDR NatureOfCDR
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Remarks field.
        /// </summary>
        /// <value>The remarks.</value>
        public String Remarks
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

            CDRInfoEntity toCompareWith = obj as CDRInfoEntity;
            return toCompareWith == null ? false : ((this.CDRInfoId == toCompareWith.CDRInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CDRInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}