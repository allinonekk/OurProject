#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for PaymentIn sub case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   06/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: PaymentInData.cs
// Description: Represents a standard data container object for PaymentIn sub case type.
// </summary>
// <copyright file= "PaymentInData.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard data container object for PaymentIn sub case type.
    /// </summary>
    [Serializable]
    public class PaymentInData : ISubCaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="PaymentInDocFSDetailEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="PaymentInDocFSDetailEntity"/> entity.</value>
        public List<PaymentInDocFSDetailEntity> ListPaymentInDocFSDetailEntity
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
        /// Gets or sets the <see cref="PaymentInDocDetailEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="PaymentInDocDetailEntity"/> entity.</value>
        public List<PaymentInDocDetailEntity> ListPaymentInDocDetailEntity
        {
            get; set;
        }

        #endregion Properties
    }
}