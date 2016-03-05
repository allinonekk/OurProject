#region Header

/*****************************************************************************************************
* Description : This file represents a standard MRelief entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/01/2010   		      Nap            	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MReliefEntity.cs
// Description: Represents a standard MRelief entity.
// </summary>
// <copyright file= "MConfigPrayerEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MReliefEntity.
    /// </summary>
    [Serializable]
    public class MConfigPrayerEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MRelief"/> class.
        /// </summary>
        public MConfigPrayerEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the OrderNumber field.
        /// </summary>
        /// <value>The order number.</value>
        public String DocCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Level field.
        /// </summary>
        /// <value>The Level.</value>
        public int Level
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PrayersText field.
        /// </summary>
        /// <value>The PrayersText.</value>
        public String PrayersText
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PrayersTitle field.
        /// </summary>
        /// <value>The PrayersTitle.</value>
        public String PrayerTitle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the VSAConfigDetailId field.
        /// </summary>
        /// <value>The VSAConfigDetail Id.</value>
        public String VSAConfigDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the VSAConfigPrayerId field.
        /// </summary>
        /// <value>The VSAConfigPrayer Id.</value>
        public String VSAConfigPrayerId
        {
            get;
            set;
        }

        #endregion Properties
    }
}