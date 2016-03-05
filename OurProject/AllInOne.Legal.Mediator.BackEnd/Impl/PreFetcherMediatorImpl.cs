#region Header

/*****************************************************************************************************
* Description : This file represents a mediator interface for PreFetch File module.
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

namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Common.DataAccess.NHibernate;
    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Data;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    public class PreFetcherMediatorImpl : IPreFetcherMediator
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PreFetcherMediatorImpl));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Gets the CaseInfoDetails
        /// </summary>
        /// <param name="criteria">Criteria contains CaseInfoId</param>
        /// <returns></returns>
        public CaseInfoEntity GetCaseInfoDetails(Criteria criteria)
        {
            Check.RequireWithNullException(criteria != null, "criteria was null or empty; it has to have value within it.");

            var caseInfoEntity = new CaseInfoEntity();

            using (var unitOfWork = new UnitOfWorkImpl(DataBaseConnectivity.Application))
            {
                try
                {
                    var icaseinfoRepository = new RepositoryImpl<CaseInfo>(unitOfWork.Session);
                    caseInfoEntity = CaseMapper.GetCaseInfoEntity(icaseinfoRepository.Get(Convert.ToInt64(criteria.Value)));
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    Logger.Error("Error encountered at GetCaseInfoDetails", ex);
                    throw;
                }
            }

            return caseInfoEntity;
        }

        /// <summary>
        /// Gets the hearings.
        /// </summary>
        /// <param name="startDateTime">The start date time.</param>
        /// <param name="endDateTime">The end date time.</param>
        /// <returns></returns>
        public List<HearingEntity> GetHearings(DateTime startDateTime, DateTime endDateTime)
        {
            CaseGateway caseGateway = new CaseGateway();
            List<HearingEntity> hearingEntityList = new List<HearingEntity>();

            using(IUnitOfWork unitOfWork=new UnitOfWorkImpl(DataBaseConnectivity.Application))
            {
                try
                {

                    IHearingRepository ihearingRepository = new HearingRepositoryImpl(unitOfWork.Session);
                    hearingEntityList = caseGateway.GetHearingEntityList(startDateTime, endDateTime);
                        //(ihearingRepository.GetHearingsBasedOnDateTime(startDateTime, endDateTime));
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    Logger.Error("Error encountered at GetHearings", ex);
                    throw;
                }
            }

            return hearingEntityList;
        }

        #endregion Methods
    }
}