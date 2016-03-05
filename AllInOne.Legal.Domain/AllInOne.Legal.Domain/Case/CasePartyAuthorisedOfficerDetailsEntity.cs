#region Header

/*****************************************************************************************************
 * Description : This file represents a standard CasePartyAuthorisedOfficerDetails.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 25/09/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: CasePartyAuthorisedOfficerDetailsEntity.cs
// Description: Represents a standard CasePartyAuthorisedOfficerDetails.
// </summary>
// <copyright file= "CasePartyAuthorisedOfficerDetailsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for CasePartyAuthorisedOfficerDetails.
    /// It inherits from <see cref="AbstractCaseParty"/>
    /// </summary>
    [Serializable]
    public class CasePartyAuthorisedOfficerDetailsEntity : AbstractCaseParty, ICaseEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="CasePartyAuthorisedOfficerDetailsEntity"/> class.</summary>
        public CasePartyAuthorisedOfficerDetailsEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        // <summary>Gets or sets the IdNumber field. </summary>
        /// <summary>
        /// Gets or sets the id number.
        /// </summary>
        /// <value>The id number.</value>
        public String IdNumber
        {
            get;
            set;
        }

        public String IDRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public Int32 ItemNo
        {
            get;
            set;
        }

        public MCountryEntity MCountryEntity
        {
            get;
            set;
        }

        public MPersonIDGroupEntity MPersonIDGroupEntity
        {
            get;
            set;
        }

        public MPersonIDTypeEntity MPersonIDTypeEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Name field.
        /// </summary>
        /// <value>The name.</value>
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RecId field.
        /// </summary>
        /// <value>The rec id.</value>
        public String RecId
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

            CasePartyAuthorisedOfficerDetailsEntity toCompareWith = obj as CasePartyAuthorisedOfficerDetailsEntity;
            return toCompareWith == null ? false : ((this.RecId == toCompareWith.RecId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RecId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}