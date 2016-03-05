#region Header

/*****************************************************************************************************
* Description : This file represents a standard Hearing entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   30/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: HearingEntity.cs
// Description: Represents a standard Hearing entity.
// </summary>
// <copyright file= "HearingEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for Hearing.
    /// It inherits from <see cref="AbstractSubCaseInfo"/>
    /// </summary>
    [Serializable]
    public class HearingCoramEntity : AbstractLastModified, ICaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ComputedHearingFee field.
        /// </summary>
        /// <value>The ComputedHearingFee.</value>
        public string HearingCoramId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ComputedHearingFeeDatetime field.
        /// </summary>
        /// <value>The ComputedHearingFeeDatetime.</value>
        public long HRGId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CountAsCDRSession field.
        /// </summary>
        /// <value>The count as CDR session.</value>
        public string UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocId field.
        /// </summary>
        /// <value>The docId.</value>
        public MDesignationEntity MDesignationEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DsgName field.
        /// </summary>
        /// <value>The name of the DSG.</value>
        public YesNo MainCoramIndicator
        {
            get;
            set;
        }

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
            if (obj == null)
            {
                return false;
            }
            HearingCoramEntity toCompareWith = obj as HearingCoramEntity;
            return toCompareWith == null ? false : ((this.HearingCoramId == toCompareWith.HearingCoramId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HearingCoramId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}