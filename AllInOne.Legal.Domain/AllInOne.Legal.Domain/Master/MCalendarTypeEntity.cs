#region Header

/*****************************************************************************************************
* Description : This file represents a standard MCalendarType entity.
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
// File: MCalendarEntity.cs
// Description: Represents a standard MCalendarType entity.
// </summary>
// <copyright file= "MCalendarTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MCalendarType.
    /// </summary>
    [Serializable]
    public class MCalendarTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Fields

        private Int64 calendarTypeId;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MCalendarType"/> class.
        /// </summary>
        public MCalendarTypeEntity()
            : base()
        {
            calendarTypeId = default(Int64);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the CalendarTypeDesc field.
        /// </summary>
        /// <value>The calendar type desc.</value>
        public String CalendarTypeDesc
        {
            get; set;
        }

        /// <summary>
        /// Gets the CalendarTypeId field.
        /// </summary>
        /// <value>The calendar type Id.</value>
        public Int64 CalendarTypeId
        {
            get { return calendarTypeId; }
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Master.MCalendarType.MForumType - Master.MForumType.MCalendarTypes (m:1)'
        /// </summary>
        /// <value>The type of the M forum.</value>
        public MForumTypeEntity MForumType
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
            MCalendarTypeEntity toCompareWith = obj as MCalendarTypeEntity;
            return toCompareWith == null ? false : ((this.CalendarTypeId == toCompareWith.CalendarTypeId));
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
            toReturn ^= this.CalendarTypeId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}