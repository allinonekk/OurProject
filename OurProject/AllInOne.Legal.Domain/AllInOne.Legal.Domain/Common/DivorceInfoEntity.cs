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

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for DivorceInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class DivorceInfoEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CaseNatureInd field.
        /// </summary>
        /// <value>The case nature ind.</value>
        public DivorceCaseNature CaseNatureInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfEnquiryCPFB field.
        /// </summary>
        /// <value>The date of enquiry CPFB.</value>
        public DateTime? DateOfEnquiryCPFB
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfEnquiryHDB field.
        /// </summary>
        /// <value>The date of enquiry HDB.</value>
        public DateTime? DateOfEnquiryHDB
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfMarriage field.
        /// </summary>
        /// <value>The date of marriage.</value>
        public DateTime? DateOfMarriage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfOrder field.
        /// </summary>
        /// <value>The date of order.</value>
        public DateTime? DateOfOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfSolemnization field.
        /// </summary>
        /// <value>The date of solemnization.</value>
        public DateTime? DateOfSolemnization
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DivorceInfoId field.
        /// </summary>
        /// <value>The divorce info id.</value>
        public String DivorceInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HDBPropertyInd field.
        /// </summary>
        /// <value>Type of v.</value>
        public YesNo HDBPropertyInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsConsentFiled field.
        /// </summary>
        /// <value>The is consent filed.</value>
        public YesNo IsConsentFiled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsDivorceWrit field.
        /// </summary>
        /// <value>The is divorce writ.</value>
        public YesNo IsDivorceWrit
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsJudicialSeperationWrit field.
        /// </summary>
        /// <value>The is judicial separation writ.</value>
        public YesNo IsJudicialSeparationWrit
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsNullityOfMarriageWrit field.
        /// </summary>
        /// <value>The is nullity of marriage writ.</value>
        public YesNo IsNullityOfMarriageWrit
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsOrderExists field.
        /// </summary>
        /// <value>The is order exists.</value>
        public YesNo IsOrderExists
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsPreDeathDivorce field.
        /// </summary>
        /// <value>The is pre death divorce.</value>
        public YesNo IsPreDeathDivorce
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsResJudicialSeperation field.
        /// </summary>
        /// <value>The is res judicial separation.</value>
        public YesNo IsResJudicialSeparation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the JurDomicileInfoForDefendant field.
        /// </summary>
        /// <value>The jur domicile info for defendant.</value>
        public JurisdictionDomicileForParty JurDomicileInfoForDefendant
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the JurDomicileInfoForPlaintiff field.
        /// </summary>
        /// <value>The jur domicile info for plaintiff.</value>
        public JurisdictionDomicileForParty JurDomicileInfoForPlaintiff
        {
            get;
            set;
        }

        /// <summary>Gets or sets the JurisdictionInfo field. </summary>
        public System.String JurisdictionInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MarriageCertNo field.
        /// </summary>
        /// <value>The marriage cert no.</value>
        public String MarriageCertNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MatrimonialPropInd field.
        /// </summary>
        /// <value>The matrimonial prop ind.</value>
        public ParentingPlan MatrimonialPropInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NOA filed within.
        /// </summary>
        /// <value>The NOA filed within.</value>
        public String NOAFiledWithin
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OrderNumber field.
        /// </summary>
        /// <value>The order number.</value>
        public String OrderNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OSCaseNo field.
        /// </summary>
        /// <value>The OS case no.</value>
        public String OSCaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ParentingPlanInd field.
        /// </summary>
        /// <value>The parenting plan ind.</value>
        public ParentingPlan ParentingPlanInd
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Divorce.DivorceInfo.MCountry - Master.MCountry.DivorceInfos (m:1)'
        /// </summary>
        /// <value>The country.</value>
        public MCountryEntity PlaceOfMarriage
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Divorce.DivorceInfo.MCountry - Master.MCountry.DivorceInfos (m:1)'
        /// </summary>
        /// <value>The country.</value>
        public MCountryEntity PlaceOfSolemnization
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TypeofJurDefendant field.
        /// </summary>
        /// <value>The type of jur defendant.</value>
        public TypeOfJurisdiction TypeofJurDefendant
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TypeofJurPlaintiff field.
        /// </summary>
        /// <value>Type of Jurisdiction  for plaintiff.</value>
        public TypeOfJurisdiction TypeofJurPlaintiff
        {
            get;
            set;
        }

        public YesNo RelatedProceedingInd  { get; set; }
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

            DivorceInfoEntity toCompareWith = obj as DivorceInfoEntity;
            return toCompareWith == null ? false : ((this.DivorceInfoId == toCompareWith.DivorceInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DivorceInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}