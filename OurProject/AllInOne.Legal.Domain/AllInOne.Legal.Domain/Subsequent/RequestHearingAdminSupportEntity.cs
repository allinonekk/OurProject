#region Header

/*****************************************************************************************************
* Description : This file represents a standard ADMBBDefInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   17/06/2011   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ADMBBDefInfoEntity.cs
// Description: Represents a standard ADMBBDefInfo entity.
// </summary>
// <copyright file= "ADMBBDefInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for RequestHearingAdminSupport.
    /// It inherits from <see cref="AbstractCaseParty"/>
    /// </summary>
    [Serializable]
    public class RequestHearingAdminSupportEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group id.</value>
        public YesNo AudioPlaybackFacilities
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group id.</value>
        public YesNo DigitalTranscriptionService
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group id.</value>
        public YesNo EnhancedSecurityAndPolice
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ADMRSVCBBInfoId field.
        /// </summary>
        /// <value>The ADMRSVCBB info id.</value>
        public Int64? HRGID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group id.</value>
        public YesNo InterpretationService
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group id.</value>
        public YesNo JusticeOnline
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group id.</value>
        public YesNo MobileInfotechTrolley
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group id.</value>
        public YesNo OrderToBringPersonToCourt
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ADMBBDefInfoId field.
        /// </summary>
        /// <value>The ADMBB def info id.</value>
        public String RequestHearingAdminSupportId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group id.</value>
        public YesNo VideoPlaybackFacilities
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

            RequestHearingAdminSupportEntity toCompareWith = obj as RequestHearingAdminSupportEntity;
            return toCompareWith == null ? false : ((this.RequestHearingAdminSupportId == toCompareWith.RequestHearingAdminSupportId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RequestHearingAdminSupportId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}