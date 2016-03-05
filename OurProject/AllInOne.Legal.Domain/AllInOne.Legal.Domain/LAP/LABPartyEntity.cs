#region Header

/*****************************************************************************************************
* Description : This file represents a standard LABParty entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LABPartyEntity.cs
// Description: Represents a standard LABParty entity.
// </summary>
// <copyright file= "LABPartyEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LAP
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for LABParty.
    /// It inherits from <see cref="AbstractLABParty"/>
    /// </summary>
    [Serializable]
    public class LABPartyEntity : AbstractLABParty, ILAPEntity
    {
        #region Properties

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
        /// Represents the navigator which is mapped onto the association 'LAP.LABParty.MGender - Master.MGender.LABParties (m:1)'
        /// </summary>
        /// <value>The M gender.</value>
        public MGenderEntity MGender
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
        /// Represents the navigator which is mapped onto the association 'LAP.LABParty.MPersonIDType - Master.MPersonIDType.LABParties (m:1)'
        /// </summary>
        /// <value>The type of the M person ID.</value>
        public MPersonIDTypeEntity MPersonIDType
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
        public String LFFileRefNumber
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

            LABPartyEntity toCompareWith = obj as LABPartyEntity;
            return toCompareWith == null ? false : ((this.LABPartyId == toCompareWith.LABPartyId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LABPartyId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}