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

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

    /// <summary>
    /// Represents a standard domain entity for OtherITMO.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class OrdersMade : ICommon
    {
        #region Properties

        /// <summary> Gets or sets the BERemarks field. </summary>
        public virtual String BERemarks
        {
            get;
            set;
        }

        /// <summary> Gets or sets the DocId field. </summary>
        public virtual String DocId
        {
            get;
            set;
        }

        /// <summary> Gets or sets the HRGId field. </summary>
        public virtual Nullable<Int64> HRGId
        {
            get;
            set;
        }

        /// <summary> Gets or sets the LastModifiedBy field. </summary>
        public virtual String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary> Gets or sets the LastModifiedDate field. </summary>
        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary> Gets or sets the OrderDetails field. </summary>
        public virtual String OrderDetails
        {
            get;
            set;
        }

        /// <summary> Gets or sets the OrdersMadeId field. </summary>
        public virtual String OrdersMadeId
        {
            get;
            set;
        }

        /// <summary> Gets or sets the OrderStatus field. </summary>
        public virtual String OrderStatus
        {
            get;
            set;
        }

        /// <summary> Gets or sets the OrderType field. </summary>
        public virtual String OrderType
        {
            get;
            set;
        }

        /// <summary> Gets or sets the PrayerId field. </summary>
        public virtual String PrayerId
        {
            get;
            set;
        }

        #endregion Properties
    }
}