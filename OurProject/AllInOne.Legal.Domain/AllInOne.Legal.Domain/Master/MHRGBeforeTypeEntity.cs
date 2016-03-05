#region Header

/*****************************************************************************************************
* Description : This file represents a standard MGender entity.
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
// File: MGenderEntity.cs
// Description: Represents a standard MGender entity.
// </summary>
// <copyright file= "MGenderEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MGender.
    /// </summary>
    [Serializable]
    public class MHRGBeforeTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MGender"/> class.
        /// </summary>
        public MHRGBeforeTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public string FilingFeeType
        {
            get;
            set;
        }

        public string ForumId
        {
            get;
            set;
        }

        public string HRGBeforeTypeCode
        {
            get;
            set;
        }

        public string AddHRGBeforeTypeCode
        {
            get;
            set;
        }

        #endregion Properties
    }
}