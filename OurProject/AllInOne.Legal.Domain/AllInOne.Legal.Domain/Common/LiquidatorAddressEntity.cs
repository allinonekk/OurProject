﻿#region Header

/*****************************************************************************************************
* Description : This file represents a standard LiquidatorAddress entity.
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
// File: LiquidatorAddressEntity.cs
// Description: Represents a standard LiquidatorAddress entity.
// </summary>
// <copyright file= "LiquidatorAddressEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for LiquidatorAddress.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class LiquidatorAddressEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LiquidatorAddressEntity"/> class.
        /// </summary>
        public LiquidatorAddressEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the Addr1 field.
        /// </summary>
        /// <value>The addr1.</value>
        public String Addr1
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Addr2 field.
        /// </summary>
        /// <value>The addr2.</value>
        public String Addr2
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Addr3 field.
        /// </summary>
        /// <value>The addr3.</value>
        public String Addr3
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Addr4 field.
        /// </summary>
        /// <value>The addr4.</value>
        public String Addr4
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Address field.
        /// </summary>
        /// <value>The address.</value>
        public String Address
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AddrType field.
        /// </summary>
        /// <value>The type of the address.</value>
        public AddressType AddrType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BlkNo field.
        /// </summary>
        /// <value>The BLK no.</value>
        public String BlkNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BuildingName field.
        /// </summary>
        /// <value>The name of the building.</value>
        public String BuildingName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CountryCode field.
        /// </summary>
        /// <value>The country code.</value>
        public String CountryCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FloorNo field.
        /// </summary>
        /// <value>The floor no.</value>
        public String FloorNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FormatInd field.
        /// </summary>
        /// <value>The format ind.</value>
        public AddressFormatType FormatInd
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
        /// Gets or sets the LiquidatorAddressId field.
        /// </summary>
        /// <value>The liquidator address id.</value>
        public String LiquidatorAddressId
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
        /// Gets or sets the MailingInd field.
        /// </summary>
        /// <value>The mailing ind.</value>
        public YesNo MailingInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PostalCode field.
        /// </summary>
        /// <value>The postal code.</value>
        public String PostalCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the StreetName field.
        /// </summary>
        /// <value>The name of the street.</value>
        public String StreetName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UnitNo field.
        /// </summary>
        /// <value>The unit no.</value>
        public String UnitNo
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

            LiquidatorAddressEntity toCompareWith = obj as LiquidatorAddressEntity;
            return toCompareWith == null ? false : ((this.LiquidatorAddressId == toCompareWith.LiquidatorAddressId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LiquidatorAddressId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}