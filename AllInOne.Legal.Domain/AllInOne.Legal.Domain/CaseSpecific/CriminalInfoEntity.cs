#region Header

/*****************************************************************************************************
* Description : This file represents a standard CriminalInfo entity.
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
// File: CriminalInfoEntity.cs
// Description: Represents a standard CriminalInfo entity.
// </summary>
// <copyright file= "CriminalInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'CaseSpecific.CriminalInfo'</summary>
    [Serializable]
    public class CriminalInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the AppealMadeAgainstCoram field. </summary>
        public String AppealMadeAgainstCoram
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CCDCFromHC field. </summary>
        public YesNo CCDCFromHC
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CMCaseNo field. </summary>
        public String CMCaseNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CMDecisionBy field. </summary>
        public String CMDecisionBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CMHearingDate field. </summary>
        public DateTime? CMHearingDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CoronerNoticeInd field. </summary>
        public YesNo CoronerNoticeInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CriminalInfoId field. </summary>
        public String CriminalInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfOrder field. </summary>
        public DateTime? DateOfOrder
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DetailsOfApplication field. </summary>
        public String DetailsOfApplication
        {
            get;
            set;
        }

        public DateTime? FiatFiledDate
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.CriminalInfo.MNatureOfAppeal - Master.MNatureOfAppeal.CriminalInfos (m:1)'</summary>
        public MNatureOfAppealEntity MNatureOfAppeal
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public String NOACode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OtherNatureOfAppeal field. </summary>
        public String OtherNatureOfAppeal
        {
            get;
            set;
        }

        /// <summary>Gets or sets the RevisionFromCCDC field. </summary>
        public YesNo RevisionFromCCDC
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
            CriminalInfoEntity toCompareWith = obj as CriminalInfoEntity;
            return toCompareWith == null ? false : ((this.CriminalInfoId == toCompareWith.CriminalInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CriminalInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}