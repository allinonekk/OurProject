#region Header

/*****************************************************************************************************
* Description : This file represents a standard MAdpPrayer entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MAdpPrayerEntity.cs
// Description: Represents a standard MAdpPrayer entity.
// </summary>
// <copyright file= "MAdpPrayerEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MAdpPrayer.
    /// </summary>
    [Serializable]
    public class MAdpPrayerEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MAdpPrayer"/> class.
        /// </summary>
        public MAdpPrayerEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AdpPrayerCode field.
        /// </summary>
        /// <value>The adp prayer code.</value>
        public String AdpPrayerCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public String IsInterfaced
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the IsMandatory field.
        /// </summary>
        /// <value>The is mandatory.</value>
        public String IsMandatory
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
            MAdpPrayerEntity toCompareWith = obj as MAdpPrayerEntity;
            return toCompareWith == null ? false : ((this.AdpPrayerCode == toCompareWith.AdpPrayerCode));
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
            toReturn ^= this.AdpPrayerCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}