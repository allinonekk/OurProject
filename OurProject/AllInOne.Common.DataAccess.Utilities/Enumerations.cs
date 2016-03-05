#region Header

/*****************************************************************************************************
* Description : This file represents a list of generic enumerations.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   02/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: Enumerations.cs
// Description: Class representing a list of generic enumerations.
// </summary>
// <copyright file= "Enumerations.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Common.DataAccess.Utilities
{
    using System;

    #region Enumerations

    /// <summary>
    /// Enum defined for database connection.
    /// </summary>
    public enum DataBaseConnectivity
    {
        /// <summary>
        /// For FrontEnd or BackEnd application context.
        /// </summary>
        Application,

        /// <summary>
        /// For FrontEnd's or BackEnd's biztalk context.
        /// </summary>
        Biztalk,

        /// <summary>
        /// For BackEnd's Cross Court context.
        /// </summary>
        CrossCourt
    }

    /// <summary>
    /// Enum defined for Order of Sorting.
    /// </summary>
    public enum PropertyOrder
    {
        /// <summary>
        /// For sorting as ascending.
        /// </summary>
        Asc,

        /// <summary>
        /// For sorting as descending.
        /// </summary>
        Desc
    }

    #endregion Enumerations
}