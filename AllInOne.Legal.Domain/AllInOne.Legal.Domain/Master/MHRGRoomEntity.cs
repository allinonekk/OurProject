#region Header

/*****************************************************************************************************
* Description : This file represents a standard MHRGRoom entity.
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
// File: MHRGRoomEntity.cs
// Description: Represents a standard MHRGRoom entity.
// </summary>
// <copyright file= "MHRGRoomEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MHRGRoom.
    /// </summary>
    [Serializable]
    public class MHRGRoomEntity : AbstractLastModified, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MHRGRoomEntity"/> class.
        /// </summary>
        public MHRGRoomEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the HRGRoomCode field.
        /// </summary>
        /// <value>The HRG room code.</value>
        public String HRGRoomCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the HRGRoomTypeCode field.
        /// </summary>
        /// <value>The HRG room type code.</value>
        public String HRGRoomTypeCode
        {
            get; set;
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
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public YesNo IsInterfaced
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the RoomCapacity field.
        /// </summary>
        /// <value>The room capacity.</value>
        public Decimal RoomCapacity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the RoomName field.
        /// </summary>
        /// <value>The name of the room.</value>
        public String RoomName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the UserId field.
        /// </summary>
        /// <value>The user id.</value>
        public String UserId
        {
            get; set;
        }

        public MCourtTypeEntity MCourtType
        {
            get;
            set;
        }

        public string LocationGroup
        {
            get;
            set;
        }

        public string HearingQueueRoomName
        {
            get;
            set;
        }

        public YesNo IsCrossCourtRoom
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
            MHRGRoomEntity toCompareWith = obj as MHRGRoomEntity;
            return toCompareWith == null ? false : ((this.HRGRoomCode == toCompareWith.HRGRoomCode));
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
            toReturn ^= this.HRGRoomCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}