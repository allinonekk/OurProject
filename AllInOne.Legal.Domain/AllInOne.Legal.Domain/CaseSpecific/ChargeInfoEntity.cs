#region Header

/*****************************************************************************************************
* Description : This file represents a standard ChargeInfo entity.
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
// File: ChargeInfoEntity.cs
// Description: Represents a standard ChargeInfo entity.
// </summary>
// <copyright file= "ChargeInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'CaseSpecific.ChargeInfo'</summary>
    [Serializable]
    public class ChargeInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the CapitalChargeInd field. </summary>
        public YesNo CapitalChargeInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the case party id.
        /// </summary>
        /// <value>The case party id.</value>
        public String CasePartyId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ChargeDescription field. </summary>
        public String ChargeDescription
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ChargeInfoId field. </summary>
        public String ChargeInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ChargeNumber field. </summary>
        public Decimal? ChargeNumber
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ChargeSerialNumber field. </summary>
        public Decimal? ChargeSerialNumber
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ChargeStatus field. </summary>
        public ChargeStatusType ChargeStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ChargeStatusHrg field. </summary>
        public HearingEntity ChargeStatusHrg
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ChargeYear field. </summary>
        public Decimal? ChargeYear
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

        /// <summary>
        /// Gets or sets the doc case party id.
        /// </summary>
        /// <value>The doc case party id.</value>
        public String DCPID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public Int32? ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the drug info data.
        /// </summary>
        /// <value>The drug info data.</value>
        public List<DrugInfoEntity> ListDrugInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the offence info data.
        /// </summary>
        /// <value>The offence info data.</value>
        public List<OffenceInfoEntity> ListOffenceInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the sentence info data.
        /// </summary>
        /// <value>The sentence info data.</value>
        public List<SentenceInfoEntity> ListSentenceInfoEntity
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MainChargeInd field. </summary>
        public YesNo MainChargeInd
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.ChargeInfo.MChargeType - Master.MChargeType.ChargeInfos (m:1)'</summary>
        public MChargeTypeEntity MChargeType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PIChargeInd field. </summary>
        public YesNo PIChargeInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the RelatedPICChargeNumber field. </summary>
        public String RelatedPICChargeNumber
        {
            get;
            set;
        }

        public string OutcomeCode
        {
            get;
            set;
        }

        public string OutcomeRemarks
        {
            get;
            set;
        }

        public string ChargeNo
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
            ChargeInfoEntity toCompareWith = obj as ChargeInfoEntity;
            return toCompareWith == null ? false : ((this.ChargeInfoId == toCompareWith.ChargeInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ChargeInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}