﻿#region Header

/*****************************************************************************************************
* Description : This file represents a standard MSalutation entity.
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
// File: MSalutationEntity.cs
// Description: Represents a standard MSalutation entity.
// </summary>
// <copyright file= "MSalutationEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MHarassPlaceEntity.
    /// </summary>
    [Serializable]
    public class MHarassPlaceEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MHarassPlaceEntity"/> class.
        /// </summary>
        public MHarassPlaceEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties


        public String HarassPlaceCode
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
            MHarassPlaceEntity toCompareWith = obj as MHarassPlaceEntity;
            return toCompareWith == null ? false : ((this.HarassPlaceCode == toCompareWith.HarassPlaceCode));
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
            toReturn ^= this.HarassPlaceCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}