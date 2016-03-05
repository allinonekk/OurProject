#region Header

/*****************************************************************************************************
* Description : This file represents a standard CaseInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   18/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CaseInfoEntity.cs
// Description: Represents a standard CaseInfo entity.
// </summary>
// <copyright file= "CaseInfoEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for CaseInfo.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class CaseInfoEntity : AbstractCaseInfo, ICaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CannotCaneInd field.
        /// </summary>
        /// <value>The cannot cane ind.</value>
        public YesNo CannotCaneInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CapitalCaseInd field.
        /// </summary>
        /// <value>The CapitalCaseInd .</value>
        public YesNo CapitalCaseInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseFiledDate field.
        /// </summary>
        /// <value>The case filed date.</value>
        public DateTime? CaseFiledDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Casefilelocation field.
        /// </summary>
        /// <value>The case file location.</value>
        public String CaseFileLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseName field.
        /// </summary>
        /// <value>The name of the case.</value>
        public String CaseName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseNo field.
        /// </summary>
        /// <value>The case no.</value>
        public String CaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseOfficerAssignedDate field.
        /// </summary>
        /// <value>The case officer assigned date.</value>
        public DateTime? CaseOfficerAssignedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseOfficerUserId
        /// </summary>
        /// <value>The case officer user Id.</value>
        public string CaseOfficerUserId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CaseInfo.CaseSecurityCode - MCaseSecurity.CaseSecurityCode'
        /// </summary>
        /// <value>The case security.</value>
        public MCaseSecurityEntity CaseSecurity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseSerialNo field.
        /// </summary>
        /// <value>The case serial no.</value>
        public decimal? CaseSerialNo
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CaseInfo.CaseStatusCode - MCaseStatus.CaseStatusCode'
        /// </summary>
        /// <value>The case status.</value>
        public MCaseStatusEntity CaseStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseStatusDate field.
        /// </summary>
        /// <value>The case status date.</value>
        public DateTime? CaseStatusDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseSummary field.
        /// </summary>
        /// <value>The case summary.</value>
        public String CaseSummary
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CaseInfo.CaseTypeCode - MCaseType.CaseTypeCode'
        /// </summary>
        /// <value>The type of the case.</value>
        public MCaseTypeEntity CaseType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseYear field.
        /// </summary>
        /// <value>The case year.</value>
        public decimal? CaseYear
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ConsolidatedTypeInd field.
        /// </summary>
        /// <value>The consolidated type ind.</value>
        public ConsolidatedTypeInd ConsolidatedTypeInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ConvertedTypeInd field.
        /// </summary>
        /// <value>The converted type ind.</value>
        /// TODO: Convert to enum.
        public String ConvertedTypeInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DCMInd field.
        /// </summary>
        /// <value>The DCM ind.</value>
        public YesNo DCMInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocPhysicalLoc field.
        /// </summary>
        /// <value>The doc physical loc.</value>
        public String DocPhysicalLoc
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the File System's CaseFileLocation field.
        /// </summary>
        /// <value>The FS case file location.</value>
        public String FileSystemCaseFileLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ForeignInterpreterInd field.
        /// </summary>
        /// <value>The foreign interpreter ind.</value>
        public YesNo ForeignInterpreterInd
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CaseInfo.ForumId - MForumType.ForumId'
        /// </summary>
        /// <value>The type of the forum.</value>
        public MForumTypeEntity ForumType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HandicapInd field.
        /// </summary>
        /// <value>The handicap ind.</value>
        public YesNo HandicapInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WithdrawnDate field.
        /// </summary>
        /// <value>The withdrawn date.</value>
        public YesNo HasObjection
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HighProfileInd field.
        /// </summary>
        /// <value>The high profile ind.</value>
        public YesNo HighProfileInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the InterpreterLanguage field.
        /// </summary>
        /// <value>The interpreter language.</value>
        public InterpreterLanguage InterpreterLanguage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsCrossCourt field.
        /// </summary>
        /// <value>The IsCrossCourt.</value>
        public YesNo IsCrossCourt
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is instrument generated.
        /// </summary>
        /// <value>The is instrument generated.</value>
        public YesNo IsInstrumentGenerated
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is registrar notice sent.
        /// </summary>
        /// <value>The is registrar notice sent.</value>
        public YesNo IsRegistrarNoticeSent
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsReviewed field.
        /// </summary>
        /// <value>The is reviewed.</value>
        public YesNo IsReviewed
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MinorInvolvedInd field.
        /// </summary>
        /// <value>The minor involved ind.</value>
        public YesNo MinorInvolvedInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MRUCounter field.
        /// </summary>
        /// <value>The MRU counter.</value>
        public Int32 MRUCounter
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MuslimInd field.
        /// </summary>
        /// <value>The muslim ind.</value>
        public YesNo MuslimInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NIMAInd field.
        /// </summary>
        /// <value>The NIMA ind.</value>
        public YesNo NIMAInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NoDeathSentenceInd field.
        /// </summary>
        /// <value>The no death sentence ind.</value>
        public YesNo NoDeathSentenceInd
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
        /// Gets or sets the PoliceAssistReqInd field.
        /// </summary>
        /// <value>The police assist req ind.</value>
        public YesNo PoliceAssistReqInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RedActCaseName field.
        /// </summary>
        /// <value>The name of the red act case.</value>
        public String RedActCaseName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RelatedTypeInd field.
        /// </summary>
        /// <value>The related type ind.</value>
        public YesNo RelatedTypeInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ROCInd field.
        /// </summary>
        /// <value>The ROC ind.</value>
        public YesNo ROCInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SMCLInd field.
        /// </summary>
        /// <value>The SMCL ind.</value>
        public YesNo SMCLInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SystemInd field.
        /// </summary>
        /// <value>The system ind.</value>
        public SystemInd SystemInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TempCaseNo field.
        /// </summary>
        /// <value>The temp case no.</value>
        public String TempCaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WithdrawnDate field.
        /// </summary>
        /// <value>The withdrawn date.</value>
        public Decimal? TierType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Track field.
        /// </summary>
        /// <value>The track.</value>
        public CaseTrack Track
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TransferTypeInd field.
        /// </summary>
        /// <value>The transfer type ind.</value>
        public TransferTypeInd TransferTypeInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TribunalCaseNo field.
        /// </summary>
        /// <value>The tribunal case no.</value>
        public String TribunalCaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TribunalType field.
        /// </summary>
        /// <value>The type of the tribunal.</value>
        public String TribunalType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WithdrawnDate field.
        /// </summary>
        /// <value>The withdrawn date.</value>
        public DateTime? WithdrawnDate
        {
            get;
            set;
        }

        public DateTime? HideDocAccessTillDate
        {
            get;
            set;
        }

        public YesNo IsFileInspectionActive
        {
            get;
            set;
        }

        public YesNo IsCaseArchived
        {
            get;
            set;
        }

        public YesNo CFRCInd
        {
            get;
            set;
        }


        public YesNo Order2BringUpAPrisonerInd { get; set; }

        public YesNo DigitalTranscriptionServicesInd { get; set; }

        public YesNo JOLInd { get; set; }

        public YesNo BankruptInd { get; set; }

        public string FilingFeeRuleType
        {
            get;
            set;
        }
        public YesNo SimplifiedTrackInd { get; set; }
        public YesNo ChildTrackInd { get; set; }
        public YesNo ViolenceTrackInd { get; set; }
        public YesNo InternationalTrackInd { get; set; }
        public YesNo HighConflictTrackInd { get; set; }
        public YesNo CFRCnFRCInd { get; set; }
        public YesNo ChildRepresentativeInd { get; set; }
        public PaymentMode PaymentMode { get; set; }
        public MSectionEntity CaseOfficerAssignedSectionCode { get; set; }
        //public YesNo IsPOHAPOIssued { get; set; }

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

            CaseInfoEntity toCompareWith = obj as CaseInfoEntity;
            return toCompareWith == null ? false : ((this.CaseInfoId == toCompareWith.CaseInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}