#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for SetDown sub case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/12/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: SetDownData.cs
// Description: Represents a standard data container object for SetDown sub case type.
// </summary>
// <copyright file= "SetDownData.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.Subsequent;

    /// <summary>
    /// Represents a standard data container object for SetDown sub case type.
    /// </summary>
    [Serializable]
    public class SetDownData : ISubCaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="RefOrderDetailEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="RefOrderDetailEntity"/> entity.</value>
        public List<RefOrderDetailEntity> ListRefOrderDetailEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="PaymentHRGDatesDocDetailEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="PaymentHRGDatesDocDetailEntity"/> entity.</value>
        public PaymentHRGDatesDocDetailEntity PaymentHRGDatesDocDetailEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the set down info.
        /// </summary>
        /// <value>The set down info.</value>
        public SetDownInfoEntity SetDownInfo
        {
            get;
            set;
        }

        #endregion Properties
    }
}