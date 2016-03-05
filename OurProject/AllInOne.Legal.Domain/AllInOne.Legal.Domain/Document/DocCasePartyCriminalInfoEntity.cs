#region Header

/*****************************************************************************************************
* Description : This file represents a standard DocCasePartyCriminalInfo entity.
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
// File: DocCasePartyCriminalInfoEntity.cs
// Description: Represents a standard DocCasePartyCriminalInfo entity.
// </summary>
// <copyright file= "DocCasePartyCriminalInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Document.DocCasePartyCriminalInfo'</summary>
    [Serializable]
    public class DocCasePartyCriminalInfoEntity : AbstractDocCaseParty, IDocumentEntity
    {
        #region Properties

        /// <summary>Gets or sets the AcquittalDetails field. </summary>
        public String AcquittalDetails
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AgeAtTimeOfOffence field. </summary>
        public Int32? AgeAtTimeOfOffence
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BailAmount field. </summary>
        public Decimal? BailAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BailRemarks field. </summary>
        public String BailRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateAcquitted field. </summary>
        public DateTime? DateAcquitted
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateBailGranted field. </summary>
        public DateTime? DateBailGranted
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateFiatFiled field. </summary>
        public DateTime? DateFiatFiled
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateInCustody field. </summary>
        public DateTime? DateInCustody
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfCommittalHearing field. </summary>
        public DateTime? DateOfCommittalHearing
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfDisposal field. </summary>
        public DateTime? DateOfDisposal
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfFirstActualTrial field. </summary>
        public DateTime? DateOfFirstActualTrial
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfFirstCCDC field. </summary>
        public DateTime? DateOfFirstCCDC
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfFirstFixedTrial field. </summary>
        public DateTime? DateOfFirstFixedTrial
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfFirstMentioned field. </summary>
        public DateTime? DateOfFirstMentioned
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfGD field. </summary>
        public DateTime? DateOfGD
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfLastCCDC field. </summary>
        public DateTime? DateOfLastCCDC
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfNoticeOfAppeal field. </summary>
        public DateTime? DateOfNoticeOfAppeal
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfPetitionOfAppeal field. </summary>
        public DateTime? DateOfPetitionOfAppeal
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfSentence field. </summary>
        public DateTime? DateOfSentence
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfVerdict field. </summary>
        public DateTime? DateOfVerdict
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateRemanded field. </summary>
        public DateTime? DateRemanded
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateWAEffected field. </summary>
        public DateTime? DateWAEffected
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateWAIssued field. </summary>
        public DateTime? DateWAIssued
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DocCasePartyCriminalInfoId field. </summary>
        public String DocCasePartyCriminalInfoId
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyCriminalInfo.MPrison_ - Master.MPrison.DocCasePartyCriminalInfos_ (m:1)'</summary>
        public MPrisonEntity MPrisonCustody
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyCriminalInfo.MPrison - Master.MPrison.DocCasePartyCriminalInfos (m:1)'</summary>
        public MPrisonEntity MPrisonRemand
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PartyInOthers field. </summary>
        public String PartyInOthers
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PartyInType field. </summary>
        public CriminalPartyInType PartyInType
        {
            get;
            set;
        }

        public string CustodyPrisonOthers
        {
            get;
            set;
        }

        public string RemandPrisonOthers
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
            DocCasePartyCriminalInfoEntity toCompareWith = obj as DocCasePartyCriminalInfoEntity;
            return toCompareWith == null ? false : ((this.DocCasePartyCriminalInfoId == toCompareWith.DocCasePartyCriminalInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocCasePartyCriminalInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}