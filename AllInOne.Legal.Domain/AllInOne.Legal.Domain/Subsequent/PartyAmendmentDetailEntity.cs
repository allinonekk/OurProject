#region Header

/*****************************************************************************************************
 * Description : This file represents a standard PartyAmendmentDetailEntity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 23/01/2011   		      Nithin             	 	Created
 *****************************************************************************************************/
// <summary>
// File: PartyAmendmentDetailEntity.cs
// Description: Represents a standard PartyAmendmentDetailEntity.
// </summary>
// <copyright file= "PartyAmendmentDetailEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for CDRInfo.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class PartyAmendmentDetailEntity : AbstractCaseInfo, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AmendmentId field.
        /// </summary>
        /// <value>The amendment id.</value>
        public String AmendmentId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CoramDesignation field.
        /// </summary>
        /// <value>The coram designation.</value>
        public String CoramDesignation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseInfoId field.
        /// </summary>
        /// <value>The item no.</value>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.PartyAmendmentDetail.MPartyAmendmentConfig - Master.MPartyAmendmentConfig.PartyAmendmentDetails (m:1)'
        /// </summary>
        /// <value>The M party amendment config.</value>
        public MPartyAmendmentConfigEntity MPartyAmendmentConfig
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PreviousInfo field.
        /// </summary>
        /// <value>The previous info.</value>
        public String PreviousInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UpdatedBy field.
        /// </summary>
        /// <value>The updated by.</value>
        public String UpdatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UpdatedInfo field.
        /// </summary>
        /// <value>The updated info.</value>
        public String UpdatedInfo
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
            PartyAmendmentDetailEntity toCompareWith = obj as PartyAmendmentDetailEntity;
            return toCompareWith == null ? false : ((this.AmendmentId == toCompareWith.AmendmentId) && (this.ItemNo == toCompareWith.ItemNo));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AmendmentId.GetHashCode();
            toReturn ^= this.ItemNo.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}