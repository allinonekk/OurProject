#region Header

/*****************************************************************************************************
* Description : This file represents a standard MAccomodationType entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   04/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MAccomodationTypeEntity.cs
// Description: Represents a standard MAccomodationType entity.
// </summary>
// <copyright file= "MAccomodationTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MAccomodationType.
    /// </summary>
    [Serializable]
    public class MAccomodationTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MAccomodationTypeEntity"/> class.
        /// </summary>
        public MAccomodationTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the accomodation type code.
        /// </summary>
        /// <value>The accomodation type code.</value>
        public String AccTypeCode
        {
            get; set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            MAccomodationTypeEntity toCompareWith = obj as MAccomodationTypeEntity;
            return toCompareWith == null ? false : ((this.AccTypeCode == toCompareWith.AccTypeCode));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AccTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}