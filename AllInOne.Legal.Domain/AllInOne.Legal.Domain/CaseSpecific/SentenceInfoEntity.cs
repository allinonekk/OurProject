#region Header

/*****************************************************************************************************
* Description : This file represents a standard SentenceInfo entity.
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
// File: SentenceInfoEntity.cs
// Description: Represents a standard SentenceInfo entity.
// </summary>
// <copyright file= "SentenceInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'CaseSpecific.SentenceInfo'</summary>
    [Serializable]
    public class SentenceInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.SentenceInfo.ChargeInfo - CaseSpecific.ChargeInfo.SentenceInfos (m:1)'</summary>
        public String ChargeInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CommencementOfSentenceDate field. </summary>
        public DateTime? CommencementOfSentenceDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateFinePaid field. </summary>
        public DateTime? DateFinePaid
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfConviction field. </summary>
        public DateTime? DateOfConviction
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

        /// <summary>Gets or sets the DatePenaltyPaid field. </summary>
        public DateTime? DatePenaltyPaid
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DefaultSentenceDay field. </summary>
        public Decimal? DefaultSentenceDay
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DefaultSentenceMonth field. </summary>
        public Decimal? DefaultSentenceMonth
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DefaultSentenceWeek field. </summary>
        public Decimal? DefaultSentenceWeek
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DefaultSentenceYear field. </summary>
        public Decimal? DefaultSentenceYear
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DisqualificationPeriodDay field. </summary>
        public Decimal? DisqualificationPeriodDay
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DisqualificationPeriodMonth field. </summary>
        public Decimal? DisqualificationPeriodMonth
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DisqualificationPeriodWeek field. </summary>
        public Decimal? DisqualificationPeriodWeek
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DisqualificationPeriodYear field. </summary>
        public Decimal? DisqualificationPeriodYear
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FineAmount field. </summary>
        public Decimal? FineAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FinePaidInd field. </summary>
        public YesNo FinePaidInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ImprisonmentTermDay field. </summary>
        public Decimal? ImprisonmentTermDay
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ImprisonmentTermMonth field. </summary>
        public Decimal? ImprisonmentTermMonth
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ImprisonmentTermWeek field. </summary>
        public Decimal? ImprisonmentTermWeek
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ImprisonmentTermYear field. </summary>
        public Decimal? ImprisonmentTermYear
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.SentenceInfo.MCriminalOrder - Master.MDrivingLicense.SentenceInfos (m:1)'</summary>
        public MCriminalOrderEntity MCriminalOrder
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.SentenceInfo.MDrivingLicense - Master.MDrivingLicense.SentenceInfos (m:1)'</summary>
        public MDrivingLicenseEntity MDrivingLicense
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.SentenceInfo.MSentence - Master.MDrivingLicense.SentenceInfos (m:1)'</summary>
        public MSentenceEntity MSentence
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NatureOfSentence field. </summary>
        public CriminalNatureOfSentence NatureOfSentence
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NumberOfStrokes field. </summary>
        public Decimal? NumberOfStrokes
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OrderRemarks field. </summary>
        public String OrderRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PenaltyAmount field. </summary>
        public Decimal? PenaltyAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PenaltyPaidInd field. </summary>
        public YesNo PenaltyPaidInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SentenceDescription field. </summary>
        public String SentenceDescription
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SentenceInfoId field. </summary>
        public String SentenceInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SentenceNo field. </summary>
        public String SentenceNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SentencingJudgeName field. </summary>
        public String SentencingJudgeName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SentencingUserId field. </summary>
        public String SentencingUserId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the StatusOfSentence field. </summary>
        public CriminalStatusOfSentence StatusOfSentence
        {
            get;
            set;
        }

        public MCourtTypeEntity MCourtType
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
            SentenceInfoEntity toCompareWith = obj as SentenceInfoEntity;
            return toCompareWith == null ? false : ((this.SentenceInfoId == toCompareWith.SentenceInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SentenceInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}