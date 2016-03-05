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
    /// Represents a standard domain entity for BankruptcyOtherDefDetail.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class BankruptcyOtherDefDetailEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CompanyName field.
        /// </summary>
        /// <value>The name of the company.</value>
        public String CompanyName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfRegistration field.
        /// </summary>
        /// <value>The date of registration.</value>
        public DateTime? DateOfRegistration
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FullName field.
        /// </summary>
        /// <value>The full name.</value>
        public String FullName
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
        /// Gets or sets the IdRemarks field.
        /// </summary>
        /// <value>The id remarks.</value>
        public String IdRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Bankruptcy.BankruptcyOtherDefDetail.MPersonIDTypeCompanyIdTypeCode - Master.MPersonIDType.BankruptcyOtherDefDetailsCompanyIdTypeCode (m:1)'
        /// </summary>
        /// <value>The M person ID type company id type code.</value>
        public MPersonIDTypeEntity MCompanyIdType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Bankruptcy.BankruptcyOtherDefDetail.MCountryCountryOfRegistration - Master.MCountry.BankruptcyOtherDefDetailsCountryOfRegistration (m:1)'
        /// </summary>
        /// <value>The M country country of registration.</value>
        public MCountryEntity MCountryOfRegistration
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Bankruptcy.BankruptcyOtherDefDetail.MEntityType - Master.MEntityType.BankruptcyOtherDefDetails (m:1)'
        /// </summary>
        /// <value>The type of the M entity.</value>
        public MEntityTypeEntity MEntityType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Bankruptcy.BankruptcyOtherDefDetail.MCountryIdCountryCode - Master.MCountry.BankruptcyOtherDefDetailsIdCountryCode (m:1)'
        /// </summary>
        /// <value>The M country id country code.</value>
        public MCountryEntity MIdCountry
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Bankruptcy.BankruptcyOtherDefDetail.MPersonIDGroup - Master.MPersonIDGroup.BankruptcyOtherDefDetails (m:1)'
        /// </summary>
        /// <value>The M person id group.</value>
        public MPersonIDGroupEntity MPersonIdGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Bankruptcy.BankruptcyOtherDefDetail.MPersonIDTypePersonIdTypeCode - Master.MPersonIDType.BankruptcyOtherDefDetailsPersonIdTypeCode (m:1)'
        /// </summary>
        /// <value>The M person ID type person id type code.</value>
        public MPersonIDTypeEntity MPersonIdType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OtherDefendantId field.
        /// </summary>
        /// <value>The other defendant id.</value>
        public String OtherDefendantId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UEN field.
        /// </summary>
        /// <value>The UEN.</value>
        public String UEN
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

            BankruptcyOtherDefDetailEntity toCompareWith = obj as BankruptcyOtherDefDetailEntity;
            return toCompareWith == null ? false : ((this.OtherDefendantId == toCompareWith.OtherDefendantId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.OtherDefendantId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}