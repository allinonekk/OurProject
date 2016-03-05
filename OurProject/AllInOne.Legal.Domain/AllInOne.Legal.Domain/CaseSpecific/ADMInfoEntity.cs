#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for ADMInfo.
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
// File: ADMInfoEntity.cs
// Description: Represents a standard domain entity for ADMInfo.
// </summary>
// <copyright file= "ADMInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for AdmInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class ADMInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ADMInfoId field.
        /// </summary>
        /// <value>The ADM info id.</value>
        public String ADMInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AdmiraltyWritType field.
        /// </summary>
        /// <value>The type of the admiralty writ.</value>
        public AdmiraltyWritType AdmiraltyWritType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AttachmentType field.
        /// </summary>
        /// <value>The type of the attachment.</value>
        public StatementOrEndorsementInWrit AttachmentType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaveatSearchDateTime field.
        /// </summary>
        /// <value>The caveat search date time.</value>
        public DateTime? CaveatSearchDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaveatSearchResult field.
        /// </summary>
        /// <value>The caveat search result.</value>
        public YesNo CaveatSearchResult
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsInjunctionFiled field.
        /// </summary>
        /// <value>The is injunction filed.</value>
        public YesNo IsInjunctionFiled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsManagedEWT field.
        /// </summary>
        /// <value>The is managed EWT.</value>
        public YesNo IsManagedEWT
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsPartnerInFirm field.
        /// </summary>
        /// <value>The is partner in firm.</value>
        public YesNo IsPartnerInFirm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsServeOutJDC field.
        /// </summary>
        /// <value>The is serve out JDC.</value>
        public JurisdictionInSingapore IsServeOutJDC
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsWOARequired field.
        /// </summary>
        /// <value>The is WOA required.</value>
        public YesNo IsWOARequired
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TotalLIQAwardedAmount field.
        /// Amount awarded at the time of judgment.
        /// </summary>
        /// <value>The total LIQ awarded amount.</value>
        public Decimal? TotalLIQAwardedAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TotalLIQClaimAmount field.
        /// </summary>
        /// <value>The total LIQ claim amount.</value>
        public Decimal? TotalLIQClaimAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TotlaUnLIQAwardedAmount field.
        /// </summary>
        /// <value>The total un LIQ awarded amount.</value>
        public Decimal? TotalUnLIQAwardedAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TotalUnLIQESTAmount field.
        /// </summary>
        /// <value>The total un LIQEST amount.</value>
        public Decimal? TotalUnLIQESTAmount
        {
            get;
            set;
        }

        public Decimal? WritAmount
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

            ADMInfoEntity toCompareWith = obj as ADMInfoEntity;
            return toCompareWith == null ? false : ((this.ADMInfoId == toCompareWith.ADMInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ADMInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}