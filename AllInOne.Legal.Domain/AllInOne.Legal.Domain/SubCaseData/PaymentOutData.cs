#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for PaymentOut sub case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   21/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: PaymentOutData.cs
// Description: Represents a standard data container object for PaymentOut sub case type.
// </summary>
// <copyright file= "PaymentOutData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseData
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCaseSpecific;

    /// <summary>
    /// Represents a standard data container object for PaymentOut sub case type.
    /// </summary>
    [Serializable]
    public class PaymentOutData : ISubCaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="PaymentOutPayInDetailEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="PaymentOutPayInDetailEntity"/> entity.</value>
        public List<PaymentOutPayInDetailEntity> ListPaymentOutPayInDetailEntity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the <see cref="ListRefOrderDetailEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="ListRefOrderDetailEntity"/> entity.</value>
        public List<RefOrderDetailEntity> ListRefOrderDetailEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="PaymentOutDocDetailEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="PaymentOutDocDetailEntity"/> entity.</value>
        public List<PaymentOutDocDetailEntity> ListPaymentOutDocDetailEntity
        {
            get; set;
        }

        #endregion Properties
    }
}