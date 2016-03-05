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
*   08/08/2012   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LawFirmEntity.cs
// Description: Represents a standard domain entity for InterfaceLawSocLawFirm.
// </summary>
// <copyright file= "InterfaceLawSocLawFirmEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LawFirm
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for InterfaceLawSocLawFirmEntity.    
    /// </summary>
    [Serializable]
    public class InterfaceLawSocLawFirmEntity : AbstractLastModified, ILawFirmEntity
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

        public string LFEmail
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
            InterfaceLawSocLawFirmEntity toCompareWith = obj as InterfaceLawSocLawFirmEntity;
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
    }
}