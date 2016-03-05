#region Header

/*****************************************************************************************************
* Description : This file represents a standard interface for startup program or tasks.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   27/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: IStartUpTask.cs
// Description: Represents a standard interface for startup program or tasks.
// </summary>
// <copyright file= "IStartUpTask.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.BootStrapper.BackEnd
{
    /// <summary>
    /// Represents a standard interface for startup program or tasks.
    /// </summary>
    public interface IStartUpTask
    {
        #region Properties

        /// <summary>
        /// Gets a value indicating whether this instance is enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is enabled; otherwise, <c>false</c>.
        /// </value>
        bool IsEnabled
        {
            get;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Configures this instance.
        /// </summary>
        void Configure();

        #endregion Methods
    }
}