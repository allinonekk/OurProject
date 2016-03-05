#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for BillOfSale case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   16/11/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: BillOfSaleData.cs
// Description: Represents a standard data container object for BillOfSale case type.
// </summary>
// <copyright file= "BillOfSaleData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseData
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Subsequent;

    /// <summary>
    /// Represents a standard data container object for BillOfSale case type.
    /// </summary>
    [Serializable]
    public class BillOfSaleData : ICaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the bill of sale info entity.
        /// </summary>
        /// <value>The bill of sale info entity.</value>
        public BillOfSaleInfoEntity BillOfSaleInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="BillOfSaleSubInfoEntity"/>
        /// </summary>
        /// <value>The BillOfSaleSubInfoEntity.</value>
        public BillOfSaleSubInfoEntity BillOfSaleSubInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ref order details.
        /// </summary>
        /// <value>The ref order details.</value>
        public List<RefOrderDetailEntity> ListRefOrderDetailEntity
        {
            get;
            set;
        }

        public List<RefOrderJOInfoEntity> ListRefOrderJOInfoEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}