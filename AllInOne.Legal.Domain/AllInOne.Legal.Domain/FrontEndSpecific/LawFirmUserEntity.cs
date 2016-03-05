#region Header

/*****************************************************************************************************
* Description : This file represents a standard LawFirmUser entity.
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
// File: LawFirmUserEntity.cs
// Description: Represents a standard LawFirmUser entity.
// </summary>
// <copyright file= "LawFirmUserEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for LawFirmUser.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class LawFirmUserEntity : IFrontEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AdminUserInd field.
        /// </summary>
        /// <value>The admin user ind.</value>
        public YesNo AdminUserInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseFileInspectionInd field.
        /// </summary>
        /// <value>The case file inspection ind.</value>
        public YesNo CaseFileInspectionInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CommDate field.
        /// </summary>
        /// <value>The comm date.</value>
        public DateTime? CommDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfAdmission field.
        /// </summary>
        /// <value>The date of admission.</value>
        public DateTime? DateOfAdmission
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Designation field.
        /// </summary>
        /// <value>The designation.</value>
        public String Designation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DraftLibraryName field.
        /// </summary>
        /// <value>The name of the draft library.</value>
        public String DraftLibraryName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the EffectiveDate field.
        /// </summary>
        /// <value>The effective date.</value>
        public DateTime EffectiveDate
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
        /// Gets or sets the Initials field.
        /// </summary>
        /// <value>The initials.</value>
        public String Initials
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawnetIndicator field.
        /// </summary>
        /// <value>The lawnet indicator.</value>
        public YesNo LawnetIndicator
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFRegID field.
        /// </summary>
        /// <value>The LF reg ID.</value>
        public Int32 LFRegId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LoginAddress field.
        /// </summary>
        /// <value>The login address.</value>
        public String LoginAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LoginTime field.
        /// </summary>
        /// <value>The login time.</value>
        public DateTime? LoginTime
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'FrontEndSpecific.LawFirmUser.MAccess - Master.MAccess.LawFirmUsers (m:1)'
        /// </summary>
        /// <value>The M access.</value>
        public MAccessEntity MAccess
        {
            get;
            set;
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'FrontEndSpecific.LawFirmUser.MStatu - Master.MStatus.LawFirmUsers (m:1)'</summary>
        //public MStatus MStatus
        //{
        //    get;
        //    set;
        //}
        /// <summary>
        /// Represents the navigator which is mapped onto the association 'FrontEndSpecific.LawFirmUser.MUserGroup - Master.MUserGroup.LawFirmUsers (m:1)'
        /// </summary>
        /// <value>The M user group.</value>
        public MUserGroupEntity MUserGroup
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
        /// Gets or sets the RegDeregComments field.
        /// </summary>
        /// <value>The reg dereg comments.</value>
        public String RegDeregComments
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
        /// Gets or sets the UserDetailID field.
        /// </summary>
        /// <value>The user detail ID.</value>
        public Int64 UserDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UserID field.
        /// </summary>
        /// <value>The user ID.</value>
        public String UserId
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

            LawFirmUserEntity toCompareWith = obj as LawFirmUserEntity;
            return toCompareWith == null ? false : ((this.UserId == toCompareWith.UserId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.UserId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}