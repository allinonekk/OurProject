#region Header

/*****************************************************************************************************
* Description : This file represents a standard MWorkPeriod entity.
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
// File: MWorkPeriodEntity.cs
// Description: Represents a standard MWorkPeriod entity.
// </summary>
// <copyright file= "MWorkPeriodEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MWorkPeriodEntity.
    /// </summary>
    [Serializable]
    public class MWorkPeriodEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MWorkPeriod"/> class.
        /// </summary>
        public MWorkPeriodEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the EndHour field.
        /// </summary>
        /// <value>The end hour.</value>
        public Int32 EndHour
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the EndMinute field.
        /// </summary>
        /// <value>The end minute.</value>
        public Int32 EndMinute
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SlotMeridianCode field.
        /// </summary>
        /// <value>The slot meridian code.</value>
        public String SlotMeridianCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the StartHour field.
        /// </summary>
        /// <value>The start hour.</value>
        public Int32 StartHour
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the StartMinute field.
        /// </summary>
        /// <value>The start minute.</value>
        public Int32 StartMinute
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
            if (obj == null)
            {
                return false;
            }
            MWorkPeriodEntity toCompareWith = obj as MWorkPeriodEntity;
            return toCompareWith == null ? false : ((this.SlotMeridianCode == toCompareWith.SlotMeridianCode));
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
            toReturn ^= this.SlotMeridianCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}