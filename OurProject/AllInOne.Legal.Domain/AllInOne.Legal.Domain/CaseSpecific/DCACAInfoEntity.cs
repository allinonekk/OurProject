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
*   23/09/2010   		      Swaroop             	 	Created
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
    /// Represents a standard domain entity for DCACAInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class DCACAInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AppealAgainstJudOrder field.
        /// </summary>
        /// <value>The appeal against jud order.</value>
        public String AppealAgainstJudOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AppealAgainstME field.
        /// </summary>
        /// <value>The appeal against ME.</value>
        public String AppealAgainstME
        {
            get;
            set;
        }

        public String AppealAgainstUserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AppealIsAgainst field.
        /// </summary>
        /// <value>The is AppealIsAgainst.</value>
        public AppealsAgainst AppealIsAgainst
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AppealIsAgainstRemarks field.
        /// </summary>
        /// <value>The is AppealIsAgainstRemarks.</value>
        public String AppealIsAgainstRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateofOrder field.
        /// </summary>
        /// <value>The date of order.</value>
        public DateTime? DateofOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DCACAInfoId field.
        /// </summary>
        /// <value>The DCACA info id.</value>
        public String DCACAInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsDCANonIELS field.
        /// </summary>
        /// <value>The is DCA non IELS.</value>
        public YesNo IsDCANOnIELS
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is EOT order obtained.
        /// </summary>
        /// <value>The is EOT order obtained.</value>
        public YesNo IsEOTOrderObtained
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is LOC order obtainted.
        /// </summary>
        /// <value>The is LOC order obtainted.</value>
        public YesNo IsLOCOrderObtainted
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsSecurityByUndertaking field.
        /// </summary>
        /// <value>The is security by undertaking.</value>
        public YesNo IsSecurityByUndertaking
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsSecurityCertFiled field.
        /// </summary>
        /// <value>The is security cert filed.</value>
        public YesNo IsSecurityCertFiled
        {
            get;
            set;
        }

        public MDesignationEntity MDesignation
        {
            get;
            set;
        }

        public YesNo SeekDirectionInd
        {
            get;
            set;
        }

        public MCoramEntity MCoram
        {
            get;
            set;
        }
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

            DCACAInfoEntity toCompareWith = obj as DCACAInfoEntity;
            return toCompareWith == null ? false : ((this.DCACAInfoId == toCompareWith.DCACAInfoId));
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
            toReturn ^= this.DCACAInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}