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
    public class HearingEntity : AbstractSubCaseInfo, ICaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ComputedHearingFee field.
        /// </summary>
        /// <value>The ComputedHearingFee.</value>
        public Decimal? ComputedHearingFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ComputedHearingFeeDatetime field.
        /// </summary>
        /// <value>The ComputedHearingFeeDatetime.</value>
        public DateTime? ComputedHearingFeeDatetime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CountAsCDRSession field.
        /// </summary>
        /// <value>The count as CDR session.</value>
        public string CountAsCDRSession
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocId field.
        /// </summary>
        /// <value>The docId.</value>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DsgName field.
        /// </summary>
        /// <value>The name of the DSG.</value>
        public String DsgName
        {
            get;
            set;
        }

        public YesNo eHearingInd
        {
            get;
            set;
        }

        public EHearingStatus eHearingStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the EndDateTime field.
        /// </summary>
        /// <value>The end date time.</value>
        public DateTime? EndDateTime
        {
            get;
            set;
        }

        public Decimal? EstimatedHearingFee
        {
            get;
            set;
        }

        public DateTime? EstimatedHearingFeeDatetime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FinalAdjournment field.
        /// </summary>
        /// <value>The final adjournment.</value>
        public YesNo FinalAdjournment
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HearingModeInd field.
        /// </summary>
        /// <value>The hearing mode ind.</value>
        public YesNo HearingModeInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGApproveInd field.
        /// </summary>
        /// <value>The HRG approve ind.</value>
        public YesNo HRGApproveInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGDateTime field.
        /// </summary>
        /// <value>The HRG date time.</value>
        public DateTime HRGDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGID field.
        /// </summary>
        /// <value>The HRGID.</value>
        public Int64 HRGID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGInstructions field.
        /// </summary>
        /// <value>The HRG instructions.</value>
        public String HRGInstructions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGLockInd field.
        /// </summary>
        /// <value>The HRG lock ind.</value>
        public YesNo HRGLockInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGOutcomeApprInd field.
        /// </summary>
        /// <value>The HRG outcome appr ind.</value>
        public YesNo HRGOutcomeApprInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGOutComeCode field.
        /// </summary>
        /// <value>The HRG room code.</value>
        public String HRGOutComeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGOutcomeRemarks field.
        /// </summary>
        /// <value>The HRG outcome remarks.</value>
        public String HRGOutcomeRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGOutComeRSNCode field.
        /// </summary>
        /// <value>The HRG room code.</value>
        public String HRGOutComeRSNCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGRoomCode field.
        /// </summary>
        /// <value>The HRG room code.</value>
        public String HRGRoomCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGSlotcode field.
        /// </summary>
        /// <value>The HRG slotcode.</value>
        public String HRGSlotcode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGTrench field.
        /// </summary>
        /// <value>The HRG trench.</value>
        public Int64? HRGTrench
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGTypeCode field.
        /// </summary>
        /// <value>The HRG type code.</value>
        public String HRGTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IndicationsGiven field.
        /// </summary>
        /// <value>The indications given.</value>
        public YesNo IndicationsGiven
        {
            get;
            set;
        }

        public YesNo IsCDRRefixed
        {
            get;
            set;
        }

        public YesNo IsPartiesAbsent
        {
            get;
            set;
        }

        public MCoramEntity MCoram
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.Hearing.MCourtType - Master.MCourtType.Hearings (m:1)'
        /// </summary>
        /// <value>The type of the M court.</value>
        public MCourtTypeEntity MCourtType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.Hearing.MDesignation - Master.MDesignation.Hearings (m:1)'
        /// </summary>
        /// <value>The M designation.</value>
        public MDesignationEntity MDesignation
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.Hearing.MHRGBeforeType - Master.MHRGBeforeType.HrgBeforeTypeCode (m:1)'
        /// </summary>
        /// <value>The HrgBeforeTypeCode.</value>
        public MHRGBeforeTypeEntity MHRGBeforeType
        {
            get;
            set;
        }

        public MHRGBeforeTypeEntity MHRGBeforeTypeEstimatedHRGBeforeTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.Hearing.MHRGOutCome - Master.MHRGOutCome.Hearings (m:1)'
        /// </summary>
        /// <value>The MHRG out come entity.</value>
        public MHRGOutComeEntity MHRGOutCome
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.Hearing.MHRGOutComeReason - Master.MHRGOutComeReason.Hearings (m:1)'
        /// </summary>
        /// <value>The MHRG out come reason.</value>
        public MHRGOutComeReasonEntity MHRGOutComeReason
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MultiDayInd field.
        /// </summary>
        /// <value>To specific if the hearing record is of trench type.</value>
        public YesNo MultiDayInd
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

        /// <summary>
        /// Gets or sets the PartHeardInd field.
        /// </summary>
        /// <value>The part heard ind.</value>
        public YesNo PartHeardInd
        {
            get;
            set;
        }

        public String QueueNo
        {
            get;
            set;
        }

        public YesNo SCInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SpecialHrgDateInd field.
        /// </summary>
        /// <value>The special HRG date ind.</value>
        public YesNo SpecialHrgDateInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the StartDateTime field.
        /// </summary>
        /// <value>The start date time.</value>
        public DateTime? StartDateTime
        {
            get;
            set;
        }

        public YesNo ToShow
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UserId field.
        /// </summary>
        /// <value>The user id.</value>
        public String UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UserName field.
        /// </summary>
        /// <value>The name of the user.</value>
        public String UserName
        {
            get;
            set;
        }

        public String WorkflowSerialNo
        {
            get;
            set;
        }

        public MHearingTypeEntity MHearingType
        {
            get;
            set;
        }

        public string MSType
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
            HearingEntity toCompareWith = obj as HearingEntity;
            return toCompareWith == null ? false : ((this.HRGID == toCompareWith.HRGID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HRGID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}