#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for Prayer.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   30/11/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: PrayerEntity.cs
// Description: Represents a standard domain entity for Prayer.
// </summary>
// <copyright file= "PrayerEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for Prayer.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class PrayerEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the DocId field.
        /// </summary>
        /// <value>The DocId.</value>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the GrantedPara field.
        /// </summary>
        /// <value>The granted para.</value>
        public YesNo GrantedPara
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the GrantedPrayer field.
        /// </summary>
        /// <value>The granted prayer.</value>
        public String GrantedPrayer
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGID field.
        /// </summary>
        /// <value>The hearing id.</value>
        public Int64? HRGID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Level field.
        /// </summary>
        /// <value>The level.</value>
        public Int32 Level
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.Prayer.MPrayerOutcome - Master.MPrayerOutcome.Prayers (m:1)'
        /// </summary>
        /// <value>The M prayer outcome.</value>
        public MPrayerOutcomeEntity MPrayerOutcome
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PrayerCode field.
        /// </summary>
        /// <value>The prayer code.</value>
        public String PrayerCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PrayerParaNo field.
        /// </summary>
        /// <value>The prayer para no.</value>
        public String PrayerParaNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PrayersID field.
        /// </summary>
        /// <value>The prayers id.</value>
        public String PrayersId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the prayer title.
        /// </summary>
        /// <value>The prayer title.</value>
        public String PrayerTitle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RequestedPrayer field.
        /// </summary>
        /// <value>The requested prayer.</value>
        public String RequestedPrayer
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubLevel field.
        /// </summary>
        /// <value>The sub level.</value>
        public Int32? SubLevel
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

            PrayerEntity toCompareWith = obj as PrayerEntity;
            return toCompareWith == null ? false : ((this.PrayersId == toCompareWith.PrayersId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PrayersId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}