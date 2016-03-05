#region Header

/*****************************************************************************************************
* Description : This file represents a standard MLawFirmGroup entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   18/05/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MLawFirmGroup.cs
// Description: Represents a standard MLawFirmGroup entity.
// </summary>
// <copyright file= "MLawFirmGroup.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MLawFirmGroup.
    /// </summary>
    [Serializable]
    public class MLawFirmGroupEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        public String LFGroupCode
        {
            get;
            set;
        }

        #endregion Properties
    }
}