#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for UnliquidatedClaim.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   19/12/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: UnliquidatedClaimEntity.cs
// Description: Represents a standard domain entity for UnliquidatedClaim.
// </summary>
// <copyright file= "UnliquidatedClaimEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

    /// <summary>
    /// Represents a standard domain entity for Solicitor.
    /// </summary>
    [Serializable]
    public class SolicitorAddress:ILawFirm
    {
        #region Properties

     
        /// <summary>
        /// Gets or sets the CaseInfoId field.
        /// </summary>
        /// <value>The case info id.</value>
        public virtual int ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CountryOfBirth field.
        /// </summary>
        /// <value>The country of birth.</value>
        public virtual long SolicitorID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfBirth field.
        /// </summary>
        /// <value>The date of birth.</value>
        public virtual string FormatInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Email field.
        /// </summary>
        /// <value>The email.</value>
        public virtual string AddrType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FaxAreaCode field.
        /// </summary>
        /// <value>The fax area code.</value>
        public virtual string BlkNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FaxCountryCode field.
        /// </summary>
        /// <value>The fax country code.</value>
        public virtual string StreetName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FaxNumber field.
        /// </summary>
        /// <value>The fax number.</value>
        public virtual string FloorNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Gender field.
        /// </summary>
        /// <value>The gender.</value>
        public virtual string UnitNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdCountryCode field.
        /// </summary>
        /// <value>The id country code.</value>
        public virtual string BuildingName
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or sets the IdNumber field.
        /// </summary>
        /// <value>The id number.</value>
        public virtual string PostalCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdTypeCode field.
        /// </summary>
        /// <value>The id type code.</value>
        public virtual string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MaritalStatusCode field.
        /// </summary>
        /// <value>The marital status code.</value>
        public virtual string ObsInd
        {
            get;
            set;
        }


        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        public virtual DateTime LastModifiedDate
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

            SolicitorAddress toCompareWith = obj as SolicitorAddress;
            return toCompareWith == null ? false : ((this.SolicitorID == toCompareWith.SolicitorID) && (this.ItemNo == toCompareWith.ItemNo));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SolicitorID.GetHashCode();
            toReturn ^= this.ItemNo.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}