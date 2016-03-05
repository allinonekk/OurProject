#region Header

/*****************************************************************************************************
* Description : This file represents a standard MPrayerOutcome entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   26/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MPrayerOutcomeEntity.cs
// Description: Represents a standard MPrayerOutcome entity.
// </summary>
// <copyright file= "MPrayerOutcomeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MPrayerOutcomeEntity.
    /// </summary>
    [Serializable]
    public class MPrayerOutcomeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the PrayerStatusCode field.
        /// </summary>
        /// <value>The prayer status code.</value>
        public String PrayerStatusCode
        {
            get;set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            MPrayerOutcomeEntity toCompareWith = obj as MPrayerOutcomeEntity;
            return toCompareWith == null ? false : ((this.PrayerStatusCode == toCompareWith.PrayerStatusCode));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PrayerStatusCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}