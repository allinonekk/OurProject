#region Header

/*****************************************************************************************************
* Description : This file represents a mediator interface for PreFetch module.
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
// File: IPreFetchMediator.cs
// Description: Represents a mediator interface for Pre Fetch module.
// </summary>
// <copyright file= "IPreFetchMediator.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain.Case;

    public interface IPreFetcherMediator : IMediator
    {
        #region Methods

        /// <summary>
        /// Gets the case info details.
        /// </summary>
        /// <param name="criteria">Criteria contains the CaseInfoID</param>
        /// <returns></returns>
        CaseInfoEntity GetCaseInfoDetails(Criteria criteria);

        /// <summary>
        /// Gets the hearings.
        /// </summary>
        /// <param name="startDateTime">The start date time.</param>
        /// <param name="endDateTime">The end date time.</param>
        /// <returns></returns>
        List<HearingEntity> GetHearings(DateTime startDateTime, DateTime endDateTime);

        #endregion Methods
    }
}