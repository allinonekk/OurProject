#region Header

/*****************************************************************************************************
 * Description : This file represents a standard HearingAdminSupport entity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			        Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010               Japheth             	Created
 *****************************************************************************************************/
// <summary>
// File: HearingAdminSupportEntity.cs
// Description: Represents a standard HearingAdminSupport entity.
// </summary>
// <copyright file= "HearingAdminSupportEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    [Serializable]
    public class HearingAdminSupportEntity : AbstractCaseInfo, ICaseEntity
    {
        #region Properties

        /// <summary>Gets or sets the AudioPlaybackFacilities field. </summary>
        public System.String AudioPlaybackFacilities
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DigitalTranscriptionService field. </summary>
        public System.String DigitalTranscriptionService
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EnhancedSecurityAndPolice field. </summary>
        public System.String EnhancedSecurityAndPolice
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HearingAdminSupportId field. </summary>
        public System.String HearingAdminSupportId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGID field. </summary>
        public Nullable<System.Int64> HRGID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the InterpretationService field. </summary>
        public System.String InterpretationService
        {
            get;
            set;
        }

        /// <summary>Gets or sets the JusticeOnline field. </summary>
        public System.String JusticeOnline
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MobileInfotechTrolley field. </summary>
        public System.String MobileInfotechTrolley
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OrderToBringPersonToCourt field. </summary>
        public System.String OrderToBringPersonToCourt
        {
            get;
            set;
        }

        /// <summary>Gets or sets the VideoPlaybackFacilities field. </summary>
        public System.String VideoPlaybackFacilities
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
            HearingAdminSupportEntity toCompareWith = obj as HearingAdminSupportEntity;
            return toCompareWith == null ? false : ((this.HearingAdminSupportId == toCompareWith.HearingAdminSupportId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HearingAdminSupportId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}