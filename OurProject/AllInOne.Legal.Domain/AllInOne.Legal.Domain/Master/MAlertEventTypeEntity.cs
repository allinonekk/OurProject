#region Header

/*****************************************************************************************************
* Description : This file represents a standard MAlertType entity.
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
// File: MAlertTypeEntity.cs
// Description: Represents a standard MAlertType entity.
// </summary>
// <copyright file= "MAlertTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MAlertType.
    /// </summary>
    [Serializable]
    public class MAlertEventTypeEntity : IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MAlertType"/> class.
        /// </summary>
        public MAlertEventTypeEntity()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AlertTypeId field.
        /// </summary>
        /// <value>The alert type Id.</value>
        public string AlertEventTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedBy field.
        /// </summary>
        /// <value>The last modified by.</value>
        public String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedDate field.
        /// </summary>
        /// <value>The last modified date.</value>
        public DateTime LastModifiedDate
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the Description field.
        /// </summary>
        /// <value>The description.</value>
        public String AlertEventTypeDescription
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
            if (obj == null)
            {
                return false;
            }
            MAlertEventTypeEntity toCompareWith = obj as MAlertEventTypeEntity;
            return toCompareWith == null ? false : ((this.AlertEventTypeCode == toCompareWith.AlertEventTypeCode));
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
            toReturn ^= this.AlertEventTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}