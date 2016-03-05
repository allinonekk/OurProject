#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMCaseTypeForum entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   30/01/2012   		      Nithin             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: RMCaseTypeForumEntity.cs
// Description: Represents a standard RMCaseTypeForum entity.
// </summary>
// <copyright file= "RMCaseTypeForumEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.MRelationship
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'MRelationship.RMHearingTypeCourtTypeEntity'</summary>
    [Serializable]
    public class RMHearingTypeCourtTypeEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public String CourtId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public String HRGTypeCode
        {
            get;
            set;
        }

        public YesNo IsInterfaced
        {
            get;
            set;
        }

        public String HeardByIndicator
        {
            get;
            set;
        }
        public Int32? TimeLineDays
        {
            get;
            set;
        }

        public MCoramEntity MCoram
        {
            get;
            set;
        }

        public YesNo IsMultiJOHrg
        {
            get;
            set;
        }

        public Int32? MinTimeLine
        {
            get;
            set;
        }

        public Int32? MaxTimeLine
        {
            get;
            set;
        }

        public string DefaultVenueType
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
            RMHearingTypeCourtTypeEntity toCompareWith = obj as RMHearingTypeCourtTypeEntity;
            return toCompareWith == null ? false : ((this.CourtId == toCompareWith.CourtId)
                && (this.HRGTypeCode == toCompareWith.HRGTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HRGTypeCode.GetHashCode();
            toReturn ^= this.CourtId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}