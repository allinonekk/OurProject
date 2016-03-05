#region Header

/*****************************************************************************************************
* Description : This file represents a list of generic enumerations, referenced in factory.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/18/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: Enumerations.cs
// Description: Representing a list of generic enumerations, referenced in factory.
// </summary>
// <copyright file= "Enumerations.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory
{
    using System;

    #region Enumerations

    /// <summary>
    /// Defines a set of enumerations to describe the application environment.
    /// </summary>
    [Serializable]
    public enum ApplicationEnvironment
    {
        /// <summary>
        /// Front End application environment.
        /// </summary>
        FE,
        /// <summary>
        /// High Court application environment.
        /// </summary>
        HC,
        /// <summary>
        /// Subordinate Courts application environment.
        /// </summary>
        SU,
        /// <summary>
        /// Family Justice Court application environment.
        /// </summary>
        FJ
    }

    #endregion Enumerations
}