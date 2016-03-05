#region Header

/*****************************************************************************************************
* Description : This file represents a standard Liquidator entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   01/10/2010  		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LiquidatorEntity.cs
// Description: Represents a standard Liquidator entity.
// </summary>
// <copyright file= "LiquidatorEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for Liquidator.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class LiquidatorEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LiquidatorEntity"/> class.
        /// </summary>
        public LiquidatorEntity()
            : base()
        {
        }

        #endregion Constructors

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
        /// Gets or sets the ContactTypeInd field.
        /// </summary>
        /// <value>The contact type ind.</value>
        public ContactType ContactTypeInd
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
        /// Gets or sets the FormerCompanyName field.
        /// </summary>
        /// <value>The name of the former company.</value>
        public String FormerCompanyName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FormerPersonName field.
        /// </summary>
        /// <value>The name of the former person.</value>
        public String FormerPersonName
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
        /// Represents the navigator which is mapped onto the association 'CWU.LiquidatorAddress.Liquidator - CWU.Liquidator.LiquidatorAddresses (m:1)'
        /// </summary>
        /// <value>The liquidator addresses.</value>
        public List<LiquidatorAddressEntity> LiquidatorAddresses
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.LiquidatorAlias.Liquidator - CWU.Liquidator.LiquidatorAliases (m:1)'
        /// </summary>
        /// <value>The liquidator aliases.</value>
        public List<LiquidatorAliasEntity> LiquidatorAliases
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LiquidatorId field.
        /// </summary>
        /// <value>The liquidator id.</value>
        public String LiquidatorId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.LiquidatorPIC.Liquidator - CWU.Liquidator.LiquidatorPICs (m:1)'
        /// </summary>
        /// <value>The liquidator PI cs.</value>
        public List<LiquidatorPICEntity> LiquidatorPICs
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.Liquidator.MLCompanyIdType - Master.MPersonIDType.MLCompanyIdType (m:1)'
        /// </summary>
        /// <value>The type of the ML company id.</value>
        public MPersonIDTypeEntity MCompanyIdType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.Liquidator.MLCountryOfRegistration - Master.MCountry.MLCountryOfRegistration (m:1)'
        /// </summary>
        /// <value>The ML country of registration.</value>
        public MCountryEntity MCountryOfRegistration
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.Liquidator.MEntityType - Master.MEntityType.Liquidators (m:1)'
        /// </summary>
        /// <value>The type of the M entity.</value>
        public MEntityTypeEntity MEntityType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.Liquidator.MGender - Master.MGender.Liquidators (m:1)'
        /// </summary>
        /// <value>The M gender.</value>
        public MGenderEntity MGender
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.Liquidator.MLIdCountry - Master.MCountry.MLIdCountry (m:1)'
        /// </summary>
        /// <value>The ML id country.</value>
        public MCountryEntity MIdCountry
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
        /// Represents the navigator which is mapped onto the association 'CWU.Liquidator.MPersonIdGroup - Master.MPersonIDGroup.Liquidators (m:1)'
        /// </summary>
        /// <value>The M person id group.</value>
        public MPersonIDGroupEntity MPersonIdGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.Liquidator.MLPersonIdType - Master.MPersonIDType.MLPersonIdType (m:1)'
        /// </summary>
        /// <value>The type of the ML person id.</value>
        public MPersonIDTypeEntity MPersonIdType
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

            LiquidatorEntity toCompareWith = obj as LiquidatorEntity;
            return toCompareWith == null ? false : ((this.LiquidatorId == toCompareWith.LiquidatorId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LiquidatorId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}