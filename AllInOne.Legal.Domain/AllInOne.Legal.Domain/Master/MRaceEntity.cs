﻿#region Header

/*****************************************************************************************************
* Description : This file represents a standard MRace entity.
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
// File: MRaceEntity.cs
// Description: Represents a standard MRace entity.
// </summary>
// <copyright file= "MRaceEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MRaceEntity.
    /// </summary>
    [Serializable]
    public class MRaceEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MRace"/> class.
        /// </summary>
        public MRaceEntity()
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
            get; set;
        }

        /// <summary>
        /// Gets or sets the RaceCode field.
        /// </summary>
        /// <value>The race code.</value>
        public String RaceCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SortingType field.
        /// </summary>
        /// <value>The type of the sorting.</value>
        public Int32? SortingType
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
            MRaceEntity toCompareWith = obj as MRaceEntity;
            return toCompareWith == null ? false : ((this.RaceCode == toCompareWith.RaceCode));
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
            toReturn ^= this.RaceCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}