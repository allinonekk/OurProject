#region Header

/*****************************************************************************************************
* Description : This file represents a standard BankruptcyOtherDefDetail entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   07/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: BankruptcyOtherDefDetailEntity.cs
// Description: Represents a standard BankruptcyOtherDefDetail entity.
// </summary>
// <copyright file= "BankruptcyOtherDefDetailEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for BankruptcyDebtInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class BankruptcyDebtInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CompanyName field.
        /// </summary>
        /// <value>The name of the company.</value>
        public String BankruptcyDebtInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfRegistration field.
        /// </summary>
        /// <value>The date of registration.</value>
        public long ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MCurrency field.
        /// </summary>
        /// <value>The MCurrency.</value>
        public MCurrencyEntity BKYDebtCurrencyCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdNumber field.
        /// </summary>
        /// <value>The id number.</value>
        public decimal? BKYDebtAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdRemarks field.
        /// </summary>
        /// <value>The id remarks.</value>
        public decimal? BKYDebtSGDAmount
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

            BankruptcyDebtInfoEntity toCompareWith = obj as BankruptcyDebtInfoEntity;
            return toCompareWith == null ? false : ((this.BankruptcyDebtInfoId == toCompareWith.BankruptcyDebtInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BankruptcyDebtInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}