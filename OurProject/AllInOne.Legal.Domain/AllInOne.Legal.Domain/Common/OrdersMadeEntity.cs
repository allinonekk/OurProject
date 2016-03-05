#region Header

/*****************************************************************************************************
 * Description : This file represents a standard OtherITMO.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 25/09/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: OtherITMOEntity.cs
// Description: Represents a standard OtherITMO.
// </summary>
// <copyright file= "OtherITMOEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for OtherITMO.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class OrdersMadeEntity : AbstractDocIdSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary> Gets or sets the BERemarks field. </summary>
        public String BERemarks
        {
            get;
            set;
        }

        /// <summary> Gets or sets the HRGId field. </summary>
        public Nullable<Int64> HRGId
        {
            get;
            set;
        }

        /// <summary> Gets or sets the OrderDetails field. </summary>
        public String OrderDetails
        {
            get;
            set;
        }

        /// <summary> Gets or sets the OrdersMadeId field. </summary>
        public String OrdersMadeId
        {
            get;
            set;
        }

        /// <summary> Gets or sets the OrderStatus field. </summary>
        public String OrderStatus
        {
            get;
            set;
        }

        /// <summary> Gets or sets the OrderType field. </summary>
        public String OrderType
        {
            get;
            set;
        }

        /// <summary> Gets or sets the PrayerId field. </summary>
        public String PrayerId
        {
            get;
            set;
        }

        #endregion Properties
    }
}