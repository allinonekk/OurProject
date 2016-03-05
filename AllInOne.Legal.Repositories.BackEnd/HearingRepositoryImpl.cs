#region Header

/*****************************************************************************************************
* Description : This file represents a repository implementation for <see cref="Hearing"/> entity.
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
// File: HearingRepositoryImpl.cs
// Description: Class which implements <see cref="RepositoryImpl<T>"/> and <see cref="IHearingRepository"/>
// for <see cref="Hearing"/> entity.
// </summary>
// <copyright file= "HearingRepositoryImpl.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Repositories.BackEnd
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Entities.BackEnd;

    using NHibernate;
    using NHibernate.Criterion;

    /// <summary>
    /// Represents a implementation for <see cref="RepositoryImpl<T>"/> and <see cref="IHearingRepository"/>
    /// for <see cref="Hearing"/> entity.
    /// </summary>
    public sealed class HearingRepositoryImpl : RepositoryImpl<Hearing>, IHearingRepository
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HearingRepositoryImpl"/> class.
        /// </summary>
        /// <param name="session"><see cref="ISession"/>, based on which the querying will be performed.</param>
        public HearingRepositoryImpl(ISession session)
            : base(session)
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Get Hearing Details base on HRGID
        /// <para>Source : Hearing.HrgID/para>
        /// </summary>
        /// <param name="hrgId"></param>
        /// <returns></returns>
        public Hearing GetHearingDetails(string hrgId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the hearings based on date time.
        /// </summary>
        /// <param name="startDateTime">The start date time.</param>
        /// <param name="endDateTime">The end date time.</param>
        /// <returns>List of Hearing entities.</returns>
        /// Modules using the method.
        /// (1) PreFetch.
        public List<Hearing> GetHearingsBasedOnDateTime(DateTime startDateTime, DateTime endDateTime)
        {
            DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(Hearing))
                                 .Add(Expression.Between("HRGDateTime",startDateTime,endDateTime));
            return (List<Hearing>)FindAll(detachedCriteria);
        }

        #endregion Methods
    }
}