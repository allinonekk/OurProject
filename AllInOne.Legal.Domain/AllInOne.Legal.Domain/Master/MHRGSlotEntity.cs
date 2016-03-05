#region Header

/*****************************************************************************************************
* Description : This file represents a standard MHRGSlotEntity entity.
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
// File: MHRGSlotEntityEntity.cs
// Description: Represents a standard MHRGSlotEntity entity.
// </summary>
// <copyright file= "MHRGSlotEntityEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MHRGSlotEntity.
    /// </summary>
    [Serializable]
    public class MHRGSlotEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MHRGSlot"/> class.
        /// </summary>
        public MHRGSlotEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the CourtInd field.
        /// </summary>
        /// <value>The court ind.</value>
        public String CourtInd
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Day field.
        /// </summary>
        /// <value>The day.</value>
        public String Day
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the EffectiveDate field.
        /// </summary>
        /// <value>The effective date.</value>
        public DateTime EffectiveDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the EndTime field.
        /// </summary>
        /// <value>The end time.</value>
        public DateTime EndTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the FrequencyCode field.
        /// </summary>
        /// <value>The frequency code.</value>
        public String FrequencyCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the HardQuota field.
        /// </summary>
        /// <value>The hard quota.</value>
        public Decimal HardQuota
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the HRGSlotCode field.
        /// </summary>
        /// <value>The HRG slot code.</value>
        public String HRGSlotCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the HRGSlotName field.
        /// </summary>
        /// <value>The name of the HRG slot.</value>
        public String HRGSlotName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SoftQuota field.
        /// </summary>
        /// <value>The soft quota.</value>
        public Decimal SoftQuota
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the StartTime field.
        /// </summary>
        /// <value>The start time.</value>
        public DateTime StartTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the EffectiveToDate field.
        /// </summary>
        /// <value>The EffectiveToDate.</value>
        public DateTime? EffectiveToDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ColorCode field.
        /// </summary>
        /// <value>The ColorCode.</value>
        public String ColorCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LocationGroup field.
        /// </summary>
        /// <value>The LocationGroup.</value>
        public String LocationGroup 
        {
            get;
            set;
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
            MHRGSlotEntity toCompareWith = obj as MHRGSlotEntity;
            return toCompareWith == null ? false : ((this.HRGSlotCode == toCompareWith.HRGSlotCode));
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
            toReturn ^= this.HRGSlotCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}