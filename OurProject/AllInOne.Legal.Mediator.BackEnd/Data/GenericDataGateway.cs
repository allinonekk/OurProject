#region Header

/*****************************************************************************************************
* Description : This file represents a standard data access gateway for generic call for Data objects.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/12/2010   		      Nithin.             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: GenericDataGateway.cs
// Description: Represents a standard data access gateway for generic call for Data objects.
// </summary>
// <copyright file= "GenericDataGateway.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;

    using AllInOne.Legal.Domain.CaseData;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCaseData;

    using log4net;

    /// <summary>
    /// Class represents a standard data access gateway for generic call for Data objects.
    /// </summary>
    internal class GenericDataGateway
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(GenericDataGateway));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method to Get <see cref="AppealsData"/> based on submissionGroupId.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns>Returns the <see cref="AppealsData"/> object.</returns>
        internal AppealsData GetAppealsData(string submissionGroupId)
        {
            AppealsData appealsData;

            try
            {
                AppealsGateway appealsGateway = new AppealsGateway();
                CommonGateway commonGateway = new CommonGateway();

                appealsData = new AppealsData();

                appealsData.DCACAInfoEntity = appealsGateway.GetDCACAInfoEntityBySGID(submissionGroupId);
                appealsData.ListLegislationProvisionsEntity = commonGateway.GetListLegislationProvisionsEntityBySGID(submissionGroupId);
                appealsData.ListNatureOfCaseEntity = commonGateway.GetListNatureOfCaseEntityBySGID(submissionGroupId);
                appealsData.ListRefOrderDetailEntity = commonGateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetAppealsData", ex);
                throw;
            }

            return appealsData;
        }

        /// <summary>
        /// Gets the registrars appeals data by SGID.
        /// </summary>
        /// <param name="submissionGroupId">The submission group id.</param>
        /// <returns></returns>
        internal ISubCaseTypeInfo GetRegistrarsAppealsDataBySGID(string submissionGroupId)
        {
            RegistrarsAppealsData registrarsAppealsData = null;

            try
            {
                AppealsGateway appealsGateway = new AppealsGateway();
                CommonGateway commonGateway = new CommonGateway();

                registrarsAppealsData = new RegistrarsAppealsData();

                registrarsAppealsData.ListLegislationProvisionsEntity = commonGateway.GetListLegislationProvisionsEntityBySGID(submissionGroupId);
                registrarsAppealsData.ListNatureOfCaseEntity = commonGateway.GetListNatureOfCaseEntityBySGID(submissionGroupId);
                registrarsAppealsData.ListRefOrderDetailEntity = commonGateway.GetListRefOrderDetailEntityBySGID(submissionGroupId);
                registrarsAppealsData.RARASInfoEntity = appealsGateway.GetRARASInfoEntityBySGID(submissionGroupId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetAppealsData", ex);
                throw;
            }

            return registrarsAppealsData;
        }

        /// <summary>
        /// Method to SaveOrUpdate <see cref="AppealsData"/>
        /// </summary>
        /// <param name="appealsData">The <see cref="AppealsData"/> object.</param>
        internal void SaveOrUpdateAppealsData(AppealsData appealsData)
        {
            try
            {
                AppealsGateway appealsGateway = new AppealsGateway();
                CommonGateway commonGateway = new CommonGateway();

                appealsGateway.SaveOrUpdateDCACAInfoEntity(appealsData.DCACAInfoEntity);
                commonGateway.SaveOrUpdateLegislationProvisionsList(appealsData.ListLegislationProvisionsEntity);
                commonGateway.SaveOrUpdateNatureOfCaseList(appealsData.ListNatureOfCaseEntity);
                commonGateway.SaveOrUpdateRefOrderDetailList(appealsData.ListRefOrderDetailEntity);
                commonGateway.SaveOrUpdateOtherITMOList(appealsData.ListOtherITMOEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateAppealsData", ex);
                throw;
            }
        }

        #endregion Methods
    }
}