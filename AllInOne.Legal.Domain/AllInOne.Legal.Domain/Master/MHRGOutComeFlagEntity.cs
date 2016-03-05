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
    /// Represents a standard domain entity for MHRGOutComeFlag.
    /// </summary>
    [Serializable]
    public class MHRGOutComeFlagEntity : AbstractMasterInfo, IMasterEntity
    {
   
        #region Properties

        public string HRGOutComeFlagCode
        {
            get;
            set;
        }

       
        #endregion Properties
    }
}