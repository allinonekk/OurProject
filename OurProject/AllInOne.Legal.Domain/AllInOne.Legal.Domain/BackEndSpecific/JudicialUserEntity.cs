#region Header

/*****************************************************************************************************
 * Description : This file represents a Judicial user's entity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 22/11/2010                 ArunSankar           	 	Created
 * 23/11/2010                 Swaroop           	 	Updated
 *****************************************************************************************************/
// <summary>
// File: JudicialUserEntity.cs
// Description: Represents a Judicial user's entity.
// </summary>
// <copyright file= "JudicialUserEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for Judicial user.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class JudicialUserEntity : AbstractLastModified, IBackEndSpecificEntity
    {

        #region Constructors

        public JudicialUserEntity(string UserID, String Username)
        {
            UserId = UserID;
            UserName = Username;
        }

        public JudicialUserEntity()
        {

        }
        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the SignaturePath field. </summary>
        public System.String SignaturePath
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AssignedDate field.
        /// </summary>
        /// <value>The Assigned Date</value>
        public DateTime? AssignedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseFileInspectionInd field.
        /// </summary>
        /// <value>The CaseFile Inspection Ind</value>
        public YesNo CaseFileInspectionInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DisplayName field.
        /// </summary>
        /// <value>The Display mName</value>
        public String DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the eMailAddress field.
        /// </summary>
        /// <value>The EMail Address</value>
        public String EMailAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the EndDate field.
        /// </summary>
        /// <value>The End Date</value>
        public DateTime? EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Initials field.
        /// </summary>
        /// <value>The Initials</value>
        public String Initials
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawnetIndicator field.
        /// </summary>
        /// <value>The Lawnet Indicator</value>
        public YesNo LawnetIndicator
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LocalDownloadLocation field.
        /// </summary>
        /// <value>The Local Download Location</value>
        public String LocalDownloadLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.JudicialUserEntity.CourtID - Master.MCourtTypeEntity.CourtID (m:1)'
        /// </summary>
        /// <value>The Court ID</value>
        public MCourtTypeEntity MCourtType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.JudicialUserEntity.GroupCode - Master.MUserGroupEntity.GroupCode (m:1)'
        /// </summary>
        /// <value>The Group Code</value>
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
        /// Gets or sets the SeniorityLevel field.
        /// </summary>
        /// <value>The Seniority Level</value>
        public Int32? SeniorityLevel
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the StartDate field.
        /// </summary>
        /// <value>The Start Date</value>
        public DateTime? StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UserId field.
        /// </summary>
        /// <value>The User Id</value>
        public String UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UserName field.
        /// </summary>
        /// <value>The User Name</value>
        public String UserName
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

            JudicialUserEntity toCompareWith = obj as JudicialUserEntity;
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