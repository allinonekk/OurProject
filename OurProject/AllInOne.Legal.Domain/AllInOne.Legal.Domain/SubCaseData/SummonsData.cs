#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for Summons sub case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   04/01/2011   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: SummonsData.cs
// Description: Represents a standard data container object for Summons sub case type.
// </summary>
// <copyright file= "SummonsData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseData
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard data container object for Summons sub case type.
    /// </summary>
    [Serializable]
    public class SummonsData : ISubCaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="NatureOfApplicationEntity"/> entity list.
        /// </summary>
        /// <value>The <see cref="NatureOfApplicationEntity"/> entity list.</value>
        public List<NatureOfApplicationEntity> ListNatureOfApplicationEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="PrayerEntity"/> entity list.
        /// </summary>
        /// <value>The <see cref="PrayerEntity"/> entity list.</value>
        public List<PrayerEntity> ListPrayerEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="RefOrderDetailEntity"/> entity list.
        /// </summary>
        /// <value>The <see cref="RefOrderDetailEntity"/> entity list.</value>
        public List<RefOrderDetailEntity> ListRefOrderDetailEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}