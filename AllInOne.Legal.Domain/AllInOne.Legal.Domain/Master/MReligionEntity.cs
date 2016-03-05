#region Header

/*****************************************************************************************************
* Description : This file represents a standard MReligion entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   26/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MReligionEntity.cs
// Description: Represents a standard MReligion entity.
// </summary>
// <copyright file= "MReligionEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MReligionEntity.
    /// </summary>
    [Serializable]
    public class MReligionEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MReligion"/> class.</summary>
        public MReligionEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the FrequencyInd field.
        /// </summary>
        /// <value>The frequency ind.</value>
        public Int32? FrequencyInd
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the ReligionCode field.
        /// </summary>
        /// <value>The religion code.</value>
        public String ReligionCode
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the SortingType field.
        /// </summary>
        /// <value>The type of the sorting.</value>
        public Int32? SortingType
        {
            get;set;
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
            MReligionEntity toCompareWith = obj as MReligionEntity;
            return toCompareWith == null ? false : ((this.ReligionCode == toCompareWith.ReligionCode));
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
            toReturn ^= this.ReligionCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}