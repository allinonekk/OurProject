#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for ChildInfo.
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
// File: ChildInfoEntity.cs
// Description: Represents a standard domain entity for ChildInfo.
// </summary>
// <copyright file= "ChildInfoEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for ChildInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class ChildInfoEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Age field.
        /// </summary>
        /// <value>The age.</value>
        public String Age
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ArrangementDetails field.
        /// </summary>
        /// <value>The arrangement details.</value>
        public String ArrangementDetails
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ChildDisableDetail field.
        /// </summary>
        /// <value>The child disable detail.</value>
        public String ChildDisableDetail
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ChildInfoID field.
        /// </summary>
        /// <value>The child info id.</value>
        public String ChildInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ChildOf field.
        /// </summary>
        /// <value>The child of Plaintiff or Defendant.</value>
        public ChildOf ChildOf
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ChildTrainingDetails field.
        /// </summary>
        /// <value>The child training details.</value>
        public String ChildTrainingDetails
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
        /// Gets or sets the DisputeDetails field.
        /// </summary>
        /// <value>The dispute details.</value>
        public String DisputeDetails
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Divorce.ChildInfo.MGender - Master.MGender.ChildInfos (m:1)'
        /// </summary>
        /// <value>The M gender.</value>
        public MGenderEntity Gender
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Divorce.ChildInfo.MCountry - Master.MCountry.ChildInfos (m:1)'
        /// </summary>
        /// <value>The M id type country.</value>
        public MCountryEntity IdCountry
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
        /// Gets or sets the IsChildOfCurrentMarriageInd field.
        /// </summary>
        /// <value>Is child of current marriage ind.</value>
        public YesNo IsChildOfCurrentMarriageInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item no.</value>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Divorce.ChildInfo.MMaritalStatu - Master.MMaritalStatus.ChildInfos (m:1)'
        /// </summary>
        /// <value>The M marital status.</value>
        public MMaritalStatusEntity MaritalStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Divorce.ChildInfo.MOccupation - Master.MOccupation.ChildInfos (m:1)'
        /// </summary>
        /// <value>The M occupation.</value>
        public MOccupationEntity MOccupation
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Divorce.ChildInfo.MPersonIDType - Master.MPersonIDType.ChildInfos (m:1)'
        /// </summary>
        /// <value>The type of the person ID.</value>
        public MPersonIDTypeEntity MPersonIdType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Divorce.ChildInfo.MQualification - Master.MQualification.ChildInfos (m:1)'
        /// </summary>
        /// <value>The qualification.</value>
        public MQualificationEntity MQualification
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Divorce.ChildInfo.MRace - Master.MRace.ChildInfos (m:1)'
        /// </summary>
        /// <value>The race.</value>
        public MRaceEntity MRace
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Divorce.ChildInfo.MReligion - Master.MReligion.ChildInfos (m:1)'
        /// </summary>
        /// <value>The religion.</value>
        public MReligionEntity MReligion
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
        /// Represents the navigator which is mapped onto the association 'Divorce.ChildInfo.MNationality - Master.MNationality.ChildInfos (m:1)'
        /// </summary>
        /// <value>The M nationality.</value>
        public MNationalityEntity Nationality
        {
            get;
            set;
        }

        public String NationalityRemarks
        {
            get;
            set;
        }

        public String OccupationRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OtherFacts field.
        /// </summary>
        /// <value>The other facts.</value>
        public String OtherFacts
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ProtectionDetails field.
        /// </summary>
        /// <value>The protection details.</value>
        public String ProtectionDetails
        {
            get;
            set;
        }

        public String RaceRemarks
        {
            get;
            set;
        }

        public String ReligionRemarks
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
            ChildInfoEntity toCompareWith = obj as ChildInfoEntity;
            return toCompareWith == null ? false : ((this.ChildInfoId == toCompareWith.ChildInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ChildInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}