#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for UnliquidatedClaim.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   19/12/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: UnliquidatedClaimEntity.cs
// Description: Represents a standard domain entity for UnliquidatedClaim.
// </summary>
// <copyright file= "UnliquidatedClaimEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for Solicitor.
    /// To Save Use---SaveOrUpdateLawFirmEntity
    /// </summary>
    [Serializable]
    public class SolicitorEntity : ILawFirmEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AdmissionDate field.
        /// </summary>
        /// <value>The admission date.</value>
        public DateTime? AdmissionDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Alias field.
        /// </summary>
        /// <value>The alias.</value>
        public String Alias
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AdmissionQualification field.
        /// </summary>
        /// <value>The admission qualification.</value>
        public String AdmissionQualification
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AffidavitFilingDate field.
        /// </summary>
        /// <value>The affidavit filing date.</value>
        public DateTime? AffidavitFilingDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UniversityName field.
        /// </summary>
        /// <value>The name of the university.</value>
        public String UniversityName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Degree field.
        /// </summary>
        /// <value>The degree.</value>
        public String Degree
        {
            get;
            set;
        }

        
        /// <summary>
        /// Gets or sets the AdmittedToBarInd field.
        /// </summary>
        /// <value>The admitted to bar ind.</value>
        public YesNo AdmittedToBarInd
        {
            get;
            set;
        }

       

        /// <summary>
        /// Gets or sets the BLERegistrationInd field.
        /// </summary>
        /// <value>The BLE registration ind.</value>
        public YesNo BLERegistrationInd
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the DegreeClass field.
        /// </summary>
        /// <value>The degree class.</value>
        public String DegreeClass
        {
            get;
            set;
        }
       

        /// <summary>
        /// Gets or sets the RulesCode field.
        /// </summary>
        /// <value>The rules code.</value>
        public String RulesCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseInfoId field.
        /// </summary>
        /// <value>The case info id.</value>
        public Int64? CaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CountryOfBirth field.
        /// </summary>
        /// <value>The country of birth.</value>
        public MCountryEntity CountryOfBirth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfBirth field.
        /// </summary>
        /// <value>The date of birth.</value>
        public DateTime? DateOfBirth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DeceasedDate field.
        /// </summary>
        /// <value>The deceased date.</value>
        public DateTime? DeceasedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Email field.
        /// </summary>
        /// <value>The email.</value>
        public String Email
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FaxAreaCode field.
        /// </summary>
        /// <value>The fax area code.</value>
        public String FaxAreaCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FaxCountryCode field.
        /// </summary>
        /// <value>The fax country code.</value>
        public String FaxCountryCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FaxNumber field.
        /// </summary>
        /// <value>The fax number.</value>
        public String FaxNumber
        {
            get;
            set;
        }

       
        /// <summary>
        /// Gets or sets the Gender field.
        /// </summary>
        /// <value>The gender.</value>
        public MGenderEntity Gender
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdCountryCode field.
        /// </summary>
        /// <value>The id country code.</value>
        public MCountryEntity IdCountryCode
        {
            get;
            set;
        }

       
        /// <summary>
        /// Gets or sets the IdNumber field.
        /// </summary>
        /// <value>The id number.</value>
        public String IdNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdTypeCode field.
        /// </summary>
        /// <value>The id type code.</value>
        public MPersonIDTypeEntity IdTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MaritalStatusCode field.
        /// </summary>
        /// <value>The marital status code.</value>
        public MMaritalStatusEntity MaritalStatusCode
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.Solicitor.SolicitorNationality - Master.MNationality.SolicitorNationality (m:1)'
        /// </summary>
        /// <value>The solicitor nationality.</value>
        public MNationalityEntity MNationalityEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MobileCountryCode field.
        /// </summary>
        /// <value>The mobile country code.</value>
        public String MobileCountryCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MobileNumber field.
        /// </summary>
        /// <value>The mobile number.</value>
        public String MobileNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Name field.
        /// </summary>
        /// <value>The name.</value>
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NationalityRemarks field.
        /// </summary>
        /// <value>The nationality remarks.</value>
        public String NationalityRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NoticePostingDate field.
        /// </summary>
        /// <value>The notice posting date.</value>
        public DateTime? NoticePostingDate
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
        /// Gets or sets the OSFilingDate field.
        /// </summary>
        /// <value>The OS filing date.</value>
        public DateTime? OSFilingDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the QualifiedPersonDate field.
        /// </summary>
        /// <value>The qualified person date.</value>
        public DateTime? QualifiedPersonDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RaceCode field.
        /// </summary>
        /// <value>The race code.</value>
        public MRaceEntity RaceCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RaceRemarks field.
        /// </summary>
        /// <value>The race remarks.</value>
        public String RaceRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ReligionCode field.
        /// </summary>
        /// <value>The religion code.</value>
        public MReligionEntity ReligionCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ReligionRemarks field.
        /// </summary>
        /// <value>The religion remarks.</value>
        public String ReligionRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SolicitorId field.
        /// </summary>
        /// <value>The solicitor id.</value>
        public Int64 SolicitorId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TelAreaCode field.
        /// </summary>
        /// <value>The tel area code.</value>
        public String TelAreaCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TelCountryCode field.
        /// </summary>
        /// <value>The tel country code.</value>
        public String TelCountryCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TelNumber field.
        /// </summary>
        /// <value>The tel number.</value>
        public String TelNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified date.
        /// </summary>
        /// <value>The last modified date.</value>
        public DateTime LastModifiedDate
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

            SolicitorEntity toCompareWith = obj as SolicitorEntity;
            return toCompareWith == null ? false : ((this.SolicitorId == toCompareWith.SolicitorId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SolicitorId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}