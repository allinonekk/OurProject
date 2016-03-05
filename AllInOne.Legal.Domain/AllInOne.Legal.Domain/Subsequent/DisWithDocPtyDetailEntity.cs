#region Header

/*****************************************************************************************************
* Description : This file represents a standard DisWithDocPtyDetail entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*    08/02/2011   		      Khin             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: DisWithDocPtyDetailEntity.cs
// Description: Represents a standard DisWithDocPtyDetail entity.
// </summary>
// <copyright file= "DisWithDocPtyDetailEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for DisWithDocPtyDetail.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class DisWithDocPtyDetailEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the WithPartyAgainst field.
        /// </summary>
        /// <value>The WithPartyAgainst field.</value>
        public String CasePartyIdAgainstWithdrawn
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the WithPartyID field.
        /// </summary>
        /// <value>The WithParty Id.</value>
        public String CasePartyIdWithdrawing
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ConsentInd field.
        /// </summary>
        /// <value>The ConsentInd field.</value>
        public YesNo ConsentInd
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the DisWithDocDetailId field.
        /// </summary>
        /// <value>The DisWithDocDetail Id.</value>
        public String DisWithDocDetailId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the DisWithDocPtyDetailId field.
        /// </summary>
        /// <value>The DisWithDocPtyDetail id.</value>
        public String DisWithDocPtyDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'DisWithDocDetailEntity.WithInCode - MWithdrawalInTypeEntity.WithInCode'
        /// </summary>
        /// <value>The WithdrawalIn Type.</value>
        public MWithDrawalInTypeEntity MWithDrawalInTypeEntity
        {
            get; set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'DisWithDocDetailEntity.WithOfCode - MWithdrawalOfTypeEntity.WithOfCode'
        /// </summary>
        /// <value>The WithdrawalOf Type.</value>
        public MWithDrawalOfTypeEntity MWithDrawalOfTypeEntity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the WithPartyAgainst field.
        /// </summary>
        /// <value>The WithPartyAgainst field.</value>
        public String WithInRemarks
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

            DisWithDocPtyDetailEntity toCompareWith = obj as DisWithDocPtyDetailEntity;
            return toCompareWith == null ? false : ((this.DisWithDocPtyDetailId == toCompareWith.DisWithDocPtyDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DisWithDocPtyDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}