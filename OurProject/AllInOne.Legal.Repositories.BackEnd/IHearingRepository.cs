#region Header

/*****************************************************************************************************
* Description : This file represents a repository interface for <see cref="Hearing"/> entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   30/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: IHearingRepository.cs
// Description: Represents a repository interface for <see cref="Hearing"/> entity.
// </summary>
// <copyright file= "IHearingRepository.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Repositories.BackEnd
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Entities.BackEnd;

    /// <summary>
    /// Represents a repository interface for <see cref="Hearing"/> entity.
    /// </summary>
    public interface IHearingRepository : IRepository<Hearing>
    {
        #region Methods

        /// <summary>
        /// Get a particular Hearing based on HRGID
        /// <para>Source : Hearing.HRGID</para>
        /// </summary>
        /// <param name="strHrgID"></param>
        /// <returns>Hearing Entity</returns>
        Hearing GetHearingDetails(string strHrgID);

        /// <summary>
        /// Gets the hearings based on date time.
        /// </summary>
        /// Modules using the method.
        /// (1) PreFetch.
        /// <param name="startDateTime">The start date time.</param>
        /// <param name="endDateTime">The end date time.</param>
        /// <returns>List of Hearing entities.</returns>
        List<Hearing> GetHearingsBasedOnDateTime(DateTime startDateTime, DateTime endDateTime);

        #endregion Methods
    }
}