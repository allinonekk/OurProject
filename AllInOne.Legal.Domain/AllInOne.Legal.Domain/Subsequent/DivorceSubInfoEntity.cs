#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for DivorceInfo.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: DivorceInfoEntity.cs
// Description: Represents a standard domain entity for DivorceInfo.
// </summary>
// <copyright file= "DivorceInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for DivorceSubInfoEntity.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class DivorceSubInfoEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the DivorceSubInfoId field.
        /// </summary>
        /// <value>The divorce sub info id.</value>
        public String DivorceSubInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGID field.
        /// </summary>
        /// <value>The is hearing id field.</value>
        public Int64? HRGID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IntendToContest field.
        /// </summary>
        /// <value>The intention to contest.</value>
        public YesNo IntendToContest
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IntendToDefend field.
        /// </summary>
        /// <value>The intention to defend.</value>
        public YesNo IntendToDefend
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsBankrupt field.
        /// </summary>
        /// <value>To indiciate if bankrupt.</value>
        public YesNo IsBankrupt
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PartyAckStatus field.
        /// </summary>
        /// <value>The setting down field.</value>
        public AgreeOrNotAgree PartyAckStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SettingDown field.
        /// </summary>
        /// <value>The setting down field.</value>
        public SettingDownStatus SettingDown
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the filing for.
        /// </summary>
        /// <value>The filing for.</value>
        public DivorceFilingFor FilingFor
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the case party id on behalf of.
        /// </summary>
        /// <value>The case party id on behalf of.</value>
        public String CasePartyIdOnBehalfOf
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the filing DCO with set down.
        /// </summary>
        /// <value>The filing DCO with set down.</value>
        public YesNo FilingDCOWithSetDown
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the filing affidavit with set down.
        /// </summary>
        /// <value>The filing affidavit with set down.</value>
        public YesNo FilingAffidavitWithSetDown
        {
            get;
            set;
        }

        public YesNo AdjudicationOrderInd  { get; set; }

        public YesNo FacingBankruptcy  { get; set; }

        public YesNo PendingBankruptcyInd { get; set; }

        public YesNo AgreementOnAMInd { get; set; }
        public YesNo CertificateOfAttendanceInd { get; set; }
        public YesNo ExemptionCertificateInd { get; set; }
        public YesNo LeaveOfCourtToClaimInd { get; set; }
        public String LeaveOfCourtToClaimCaseNo { get; set; }
        public DateTime? LeaveOfCourtToClaimOrderDate { get; set; }

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

            DivorceSubInfoEntity toCompareWith = obj as DivorceSubInfoEntity;
            return toCompareWith == null ? false : ((this.DivorceSubInfoId == toCompareWith.DivorceSubInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DivorceSubInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}