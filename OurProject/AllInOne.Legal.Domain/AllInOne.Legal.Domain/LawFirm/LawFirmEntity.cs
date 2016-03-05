#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for LawFirmEntity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   13/11/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LawFirmEntity.cs
// Description: Represents a standard domain entity for LawFirmEntity.
// </summary>
// <copyright file= "LawFirmEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LawFirm
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for LawFirmRegistration.    
    /// </summary>
    [Serializable]
    public class LawFirmEntity : AbstractLastModified, ILawFirmEntity, ICommonEntity, IComparable
    {
        #region Properties

        /// <summary>
        /// Gets or sets the GST number.
        /// </summary>
        /// <value>The GST number.</value>
        public string GSTNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LawPracticeType.
        /// </summary>
        /// <value>The LawPracticeType.</value>
        public LawPracticeType LawPracticeType
        {
            get;

            set;
        }

        public MLawPracticeTypeEntity MLawPracticeType
        {
            get;
            set;
        }

        public String LFEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFID.
        /// </summary>
        /// <value>The LFID.</value>
        public string LFID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the obs ind.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the organization.
        /// </summary>
        /// <value>The name of the organization.</value>
        public string OrganizationName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UEN.
        /// </summary>
        /// <value>The UEN.</value>
        public string UEN
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the M law firm group.
        /// </summary>
        /// <value>The M law firm group.</value>
        public MLawFirmGroupEntity MLawFirmGroup
        {
            get;
            set;
        }

        public string LicenseNumber { get; set; }

        public int? LicenseYear
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
            LawFirmEntity toCompareWith = obj as LawFirmEntity;
            return toCompareWith == null ? false : ((this.LFID == toCompareWith.LFID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LFID.GetHashCode();
            return toReturn;
        }

        #endregion Methods

        #region IComparable Members

        public int CompareTo(object other)
        {
            int c = string.Compare(this.OrganizationName, ((LawFirmEntity)other).OrganizationName, true);
            return c;
        }

        #endregion
    }
}