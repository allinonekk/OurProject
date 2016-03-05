#region Header

/*****************************************************************************************************
* Description : This file represents a standard MAlertEvent entity.
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
// File: MAlertEventEntity.cs
// Description: Represents a standard MAlertEvent entity.
// </summary>
// <copyright file= "MAlertEventEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MAlertEvent.
    /// </summary>
    [Serializable]
    public class MAlertEventEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Fields

        private Int32 alertEventId;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MAlertEvent"/> class.
        /// </summary>
        public MAlertEventEntity()
            : base()
        {
            alertEventId = default(Int32);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the AlertEventId field.
        /// </summary>
        /// <value>The alert event Id.</value>
        public Int32 AlertEventId
        {
            get { return alertEventId; }
        }

        /// <summary>
        /// Gets or sets the AlertTypeId field.
        /// </summary>
        /// <value>The alert type Id.</value>
        public Int32 AlertTypeId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Source field.
        /// </summary>
        /// <value>The source.</value>
        public String Source
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Target field.
        /// </summary>
        /// <value>The target.</value>
        public String Target
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
            MAlertEventEntity toCompareWith = obj as MAlertEventEntity;
            return toCompareWith == null ? false : ((this.AlertEventId == toCompareWith.AlertEventId));
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
            toReturn ^= this.AlertEventId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}