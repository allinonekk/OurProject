#region Header

/*****************************************************************************************************
* Description : This file represents a standard OffenceInfo entity.
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
// File: OffenceInfoEntity.cs
// Description: Represents a standard OffenceInfo entity.
// </summary>
// <copyright file= "OffenceInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'CaseSpecific.OffenceInfo'</summary>
    [Serializable]
    public class OffenceInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.OffenceInfo.ChargeInfo - CaseSpecific.ChargeInfo.OffenceInfos (m:1)'</summary>
        public String ChargeInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LocationOfOffence field. </summary>
        public String LocationOfOffence
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.OffenceInfo.MNatureOfOffence - Master.MNatureOfOffence.OffenceInfos (m:1)'</summary>
        public MNatureOfOffenceEntity MNatureOfOffence
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OffenceDateRemarks field. </summary>
        public String OffenceDateRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OffenceFromDate field. </summary>
        public DateTime? OffenceFromDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OffenceInfoId field. </summary>
        public String OffenceInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OffenceToDate field. </summary>
        public DateTime? OffenceToDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OtherText field. </summary>
        public String OtherText
        {
            get;
            set;
        }

        public YesNo MainOffenceInd
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
            OffenceInfoEntity toCompareWith = obj as OffenceInfoEntity;
            return toCompareWith == null ? false : ((this.OffenceInfoId == toCompareWith.OffenceInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.OffenceInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}