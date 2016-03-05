#region Header

/*****************************************************************************************************
* Description : This file represents a standard RCriminalLegislationInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   20/01/2011   		      CJ                 	 	Created
*
*****************************************************************************************************/
// <summary>
// File: RCriminalLegislationInfoEntity.cs
// Description: Represents a standard RCriminalLegislationInfo entity.
// </summary>
// <copyright file= "RCriminalLegislationInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'CaseSpecific.RCriminalLegislationInfo'</summary>
    [Serializable]
    public class RCriminalLegislationInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.RCriminalLegislationInfo.ChargeInfo - CaseSpecific.ChargeInfo.RCriminalLegislationInfos (m:1)'</summary>
        public String ChargeInfoId
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.RCriminalLegislationInfo.LegislationProvision - Common.LegislationProvision.RCriminalLegislationInfos (m:1)'</summary>
        public String LegislationProvisionsId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the RCriminalLegislationInfoId field. </summary>
        public String RCriminalLegislationInfoId
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
            RCriminalLegislationInfoEntity toCompareWith = obj as RCriminalLegislationInfoEntity;
            return toCompareWith == null ? false : ((this.RCriminalLegislationInfoId == toCompareWith.RCriminalLegislationInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RCriminalLegislationInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}