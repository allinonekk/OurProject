#region Header

/*****************************************************************************************************
 * Description : This file represents a standard VacHRGDatesReqInfo.
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
// File: VacHRGDatesReqInfoEntity.cs
// Description: Represents a standard VacHRGDatesReqInfo.
// </summary>
// <copyright file= "VacHRGDatesReqInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for VacHRGDatesReqInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class VacHRGDatesReqInfoEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the IsVacatingCDR field.
        /// </summary>
        /// <value>The is vacating CDR.</value>
        public YesNo IsVacatingCDR
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsVacatingWNewDate field.
        /// </summary>
        /// <value>The is vacating W new date.</value>
        public YesNo IsVacatingWNewDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the VacHRGDatesReqInfoId field.
        /// </summary>
        /// <value>The vac HRG dates req info id.</value>
        public String VacHRGDatesReqInfoId
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

            VacHRGDatesReqInfoEntity toCompareWith = obj as VacHRGDatesReqInfoEntity;
            return toCompareWith == null ? false : ((this.VacHRGDatesReqInfoId == toCompareWith.VacHRGDatesReqInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.VacHRGDatesReqInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}