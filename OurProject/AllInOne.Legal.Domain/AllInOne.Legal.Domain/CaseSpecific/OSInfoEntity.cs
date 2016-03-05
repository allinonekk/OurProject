#region Header

/*****************************************************************************************************
* Description : This file represents a standard DCACAInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   14/01/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: DCACAInfoEntity.cs
// Description: Represents a standard DCACAInfo entity.
// </summary>
// <copyright file= "DCACAInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for OSInfoEntity.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class OSInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AppAgstDecOf Field.
        /// </summary>
        /// <value>The AppAgstDecOf.</value>
        public String AppAgstDecOf
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AppAgstJudOrderDate Field.
        /// </summary>
        /// <value>The AppAgstJudOrderDate.</value>
        public DateTime? AppAgstJudOrderDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CompanyName Field.
        /// </summary>
        /// <value>The CompanyName.</value>
        public String CompanyName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CompanyRegType Field.
        /// </summary>
        /// <value>The CompanyRegType.</value>
        public MEntityTypeEntity CompanyRegType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CountryOfIssue Field.
        /// </summary>
        /// <value>The CountryOfIssue.</value>
        public MCountryEntity CountryOfIssue
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfCommCertIssued Field.
        /// </summary>
        /// <value>The DateOfCommCertIssued.</value>
        public DateTime? DateOfCommCertIssued
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfMarriage Field.
        /// </summary>
        /// <value>The DateOfMarriage.</value>
        public DateTime? DateOfMarriage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsCourtPermissionReq Field.
        /// </summary>
        /// <value>The IsCourtPermissionReq.</value>
        public Decimal DIRAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ESCOSubNOC Field.
        /// </summary>
        /// <value>The ESCOSubNOC.</value>
        public String ESCOSubNOC
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the EstAccBillClaimed Field.
        /// </summary>
        /// <value>The EstAccBillClaimed.</value>
        public Decimal? EstAccBillClaimed
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsAppeaToHC Field.
        /// </summary>
        /// <value>The IsAppeaToHC.</value>
        public YesNo IsAppealToHC
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsCommCertIssued Field.
        /// </summary>
        /// <value>The IsCommCertIssued.</value>
        public YesNo IsCommCertIssued
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsCourtPermissionReq Field.
        /// </summary>
        /// <value>The IsCourtPermissionReq.</value>
        public YesNo IsCourtPermissionReq
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsFilingCOSSFCWNOA Field.
        /// </summary>
        /// <value>The IsFilingForHRGBef3Judges.</value>
        public YesNo IsFilingCOSSFCWNOA
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsFilingForHRGBef3Judges Field.
        /// </summary>
        /// <value>The IsFilingForHRGBef3Judges.</value>
        public YesNo IsFilingForHRGBef3Judges
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsFilingtoEnfSCT Field.
        /// </summary>
        /// <value>The IsFilingtoEnfSCT.</value>
        public YesNo IsFilingtoEnfSCT
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsInjunctionFiled Field.
        /// </summary>
        /// <value>The IsInjunctionFiled.</value>
        public YesNo IsInjunctionFiled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsMuslimMarriage Field.
        /// </summary>
        /// <value>The IsMuslimMarriage.</value>
        public YesNo IsMuslimMarriage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsSceurityByUndertaking Field.
        /// </summary>
        /// <value>The IsSceurityByUndertaking.</value>
        public YesNo IsSceurityByUndertaking
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsServiceOutJur Field.
        /// </summary>
        /// <value>The IsServiceOutJur.</value>
        public YesNo IsServiceOutJur
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MCASubNOC Field.
        /// </summary>
        /// <value>The MCASubNOC.</value>
        public String MCASubNOC
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NatureOfDeputyShip Field.
        /// </summary>
        /// <value>The NatureOfDeputyShip.</value>
        public MNatureofDeputyshipEntity NatureOfDeputyShip
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OSInfoId Field.
        /// </summary>
        /// <value>The OSInfoId.</value>
        public String OSInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ProceedingInSyariahCourt Field.
        /// </summary>
        /// <value>The ProceedingInSyariahCourt.</value>
        public YesNo ProceedingInSyariahCourt
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId Field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public String SubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UENNumber Field.
        /// </summary>
        /// <value>The UENNumber.</value>
        public String UENNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is seeking enf protection.
        /// </summary>
        /// <value>
        /// The is seeking enf protection.
        /// </value>
        public String IsSeekingEnfProtection
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is orderfor relocation.
        /// </summary>
        /// <value>
        /// isorderforrelocation.
        /// </value>
        public string IsOrderforRelocation { get; set; }
        public YesNo IsProbateOSP  { get; set; }
        public YesNo IsJudicialManagement { get; set; }

        public string PHAType { get; set; }
        public YesNo HasPendingMCCases { get; set; }
        public YesNo HasPendingFJCCases { get; set; }
        public YesNo HasPendingCJDCases { get; set; }
        public YesNo HasPendingSCTCases { get; set; }
        public YesNo HasPendingCDRACases { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            OSInfoEntity toCompareWith = obj as OSInfoEntity;
            return toCompareWith == null ? false : ((this.OSInfoId == toCompareWith.OSInfoId));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.OSInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}