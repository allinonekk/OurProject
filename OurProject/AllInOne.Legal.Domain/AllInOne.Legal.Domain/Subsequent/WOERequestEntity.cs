#region Header

/*****************************************************************************************************
* Description : This file represents a standard WOERequest entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   09/06/2011   		      CJ                 	 	Created
*
*****************************************************************************************************/
// <summary>
// File: WOERequestEntity.cs
// Description: Represents a standard WOERequest entity.
// </summary>
// <copyright file= "WOERequestEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Subsequent.WOERequestEntity'</summary>
    [Serializable]
    public partial class WOERequestEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        /// <summary>Gets or sets the ClaimantPartyId field. </summary>
        public String ClaimantPartyId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsExecOutOffHour field. </summary>
        public YesNo IsExecOutOffHour
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsPursuantToClaim field. </summary>
        public YesNo IsPursuantToClaim
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NCPEDocId field. </summary>
        public String NCPEDocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ReleaseTo field. </summary>
        public String ReleaseTo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ReleaseType field. </summary>
        public CriminalReleaseType ReleaseType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubCaseInfoID field. </summary>
        public Int64? SubCaseInfoID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WOERequestID field. </summary>
        public String WOERequestID
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
            WOERequestEntity toCompareWith = obj as WOERequestEntity;
            return toCompareWith == null ? false : (this.WOERequestID == toCompareWith.WOERequestID);
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WOERequestID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}