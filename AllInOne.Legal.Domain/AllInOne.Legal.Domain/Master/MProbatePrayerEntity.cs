#region Header

/*****************************************************************************************************
* Description : This file represents a standard MProbatePrayer entity.
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
// File: MProbatePrayerEntity.cs
// Description: Represents a standard MProbatePrayer entity.
// </summary>
// <copyright file= "MProbatePrayerEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MProbatePrayerEntity.
    /// </summary>
    [Serializable]
    public class MProbatePrayerEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MProbatePrayer"/> class.
        /// </summary>
        public MProbatePrayerEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the InfancyNomination field.
        /// </summary>
        /// <value>The infancy nomination.</value>
        public String InfancyNomination
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public String IsInterfaced
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the ProbateNatureCode field.
        /// </summary>
        /// <value>The probate nature code.</value>
        public String ProbateNatureCode
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the ProbatePrayerCode field.
        /// </summary>
        /// <value>The probate prayer code.</value>
        public String ProbatePrayerCode
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the WithCoAdministrator field.
        /// </summary>
        /// <value>The with co administrator.</value>
        public String WithCoAdministrator
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the WithLimitations field.
        /// </summary>
        /// <value>The with limitations.</value>
        public String WithLimitations
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the WithReservation field.
        /// </summary>
        /// <value>The with reservation.</value>
        public String WithReservation
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
            MProbatePrayerEntity toCompareWith = obj as MProbatePrayerEntity;
            return toCompareWith == null ? false : ((this.ProbatePrayerCode == toCompareWith.ProbatePrayerCode));
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
            toReturn ^= this.ProbatePrayerCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}