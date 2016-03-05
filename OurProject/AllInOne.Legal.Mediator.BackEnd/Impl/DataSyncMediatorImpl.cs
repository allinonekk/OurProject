#region Header

/*****************************************************************************************************
* Description : This file represents a standard DataSync mediator implementation.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   09/03/2011   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: DataSyncMediatorImpl.cs
// Description: Represents a standard DataSync mediator implementation.
// </summary>
// <copyright file= "DataSyncMediatorImpl.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Mediator.BackEnd.Data;

    using log4net;
    using AllInOne.Legal.Domain.Document;

    /// <summary>
    /// Class represents a standard DataSync mediator implementation.
    /// Inherits from <see cref="IDataSyncMediator"/> interface.
    /// </summary>
    public class DataSyncMediatorImpl : IDataSyncMediator
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(DataSyncMediatorImpl));

        /// <summary>
        /// ApplicationSessionManager instance for session.
        /// </summary>
        private ApplicationSessionManager applicationSessionManager = new ApplicationSessionManager();

        #endregion Fields

        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that 
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        /// <param name="sender"></param>
        public void BeginTransaction()
        {
            Logger.Info("DataSyncMediatorImpl - BeginTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager.BeginTransaction();

            Logger.Info("DataSyncMediatorImpl - BeginTransaction ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        public void CommitAndCloseSession()
        {
            Logger.Info("DataSyncMediatorImpl - CommitAndCloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager = new ApplicationSessionManager();
            this.applicationSessionManager.CommitAndCloseSession();

            Logger.Info("DataSyncMediatorImpl - CommitAndCloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ICaseTypeInfo"/> interface.
        /// </summary>
        /// <param name="iCaseTypeInfo"><see cref="ICaseTypeInfo"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateCaseData(ICaseTypeInfo iCaseTypeInfo, bool isCopy)
        {
            try
            {
                CaseDataGateway caseDataGateway = new CaseDataGateway();
                caseDataGateway.SaveOrUpdateCaseData(iCaseTypeInfo, isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateCaseData", ex);
                Logger.Error("Error in SaveOrUpdateCaseData: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ICaseEntity"/> interface.
        /// </summary>
        /// <param name="iCaseEntity"><see cref="ICaseEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateCaseEntity(ICaseEntity iCaseEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<ICase>(CaseMapper.GetCaseEntity<ICaseEntity>(iCaseEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateCaseEntity", ex);
                Logger.Error("Error in SaveOrUpdateCaseEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ICaseSpecificEntity"/> interface.
        /// </summary>
        /// <param name="iCaseSpecificEntity"><see cref="ICaseSpecificEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateCaseSpecificEntity(ICaseSpecificEntity iCaseSpecificEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<ICaseSpecific>(CaseSpecificMapper.GetCaseSpecificEntity<ICaseSpecificEntity>(iCaseSpecificEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateCaseSpecificEntity", ex);
                Logger.Error("Error in SaveOrUpdateCaseSpecificEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ICommonEntity"/> interface.
        /// </summary>
        /// <param name="iCommonEntity"><see cref="ICommonEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateCommonEntity(ICommonEntity iCommonEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<ICommon>(CommonMapper.GetCommonEntity<ICommonEntity>(iCommonEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateCommonEntity", ex);
                Logger.Error("Error in SaveOrUpdateCommonEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="IDocumentEntity"/> interface.
        /// </summary>
        /// <param name="iDocumentEntity"><see cref="IDocumentEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateDocumentEntity(IDocumentEntity iDocumentEntity, bool isCopy)
        {
            try
            {
                DocumentGateway documentGateway = new DocumentGateway();
                if (iDocumentEntity.GetType().Equals(typeof(DocumentInfoEntity)))
                {
                    documentGateway.SaveOrUpdateDocumentInfoSP(iDocumentEntity);
                }
                else if (isCopy)
                    documentGateway.SaveOrUpdateInMemoryEntity<IDocument>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocumentEntity<IDocumentEntity>(iDocumentEntity));
                else
                    documentGateway.SaveOrUpdateEntity<IDocument>(AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocumentEntity<IDocumentEntity>(iDocumentEntity));

            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateDocumentEntity", ex);
                Logger.Error("Error in SaveOrUpdateDocumentEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ILAPEntity"/> interface.
        /// </summary>
        /// <param name="iLAPEntity"><see cref="ILAPEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateLAPEntity(ILAPEntity iLAPEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<ILAP>(LAPMapper.GetLAP<ILAPEntity>(iLAPEntity), isCopy);

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at SaveOrUpdateLAPEntity", ex);
                Logger.Error("Error encountered at SaveOrUpdateLAPEntity : Message --> " + ex.Message + " Inner Exception - " + ex.InnerException.Message);
                throw;
            }
        }

        /// <summary>
        /// Saves the or update sub case data.
        /// </summary>
        /// <param name="iSubCaseTypeInfo">The i sub case type info.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        public void SaveOrUpdateSubCaseData(ISubCaseTypeInfo iSubCaseTypeInfo, bool isCopy)
        {
            try
            {
                SubCaseDataGateway subCaseDataGateway = new SubCaseDataGateway();
                subCaseDataGateway.SaveOrUpdateSubCaseData(iSubCaseTypeInfo, isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateSubCaseData", ex);
                Logger.Error("Error in SaveOrUpdateSubCaseData: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubCaseEntity"/> interface.
        /// </summary>
        /// <param name="iSubCaseEntity"><see cref="ISubCaseEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateSubCaseEntity(ISubCaseEntity iSubCaseEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<ISubCase>(SubCaseMapper.GetSubCase<ISubCaseEntity>(iSubCaseEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateSubCaseEntity", ex);
                Logger.Error("Error in SaveOrUpdateSubCaseEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubCaseSpecificEntity"/> interface.
        /// </summary>
        /// <param name="iSubCaseSpecificEntity"><see cref="ISubCaseSpecificEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateSubCaseSpecificEntity(ISubCaseSpecificEntity iSubCaseSpecificEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<ISubCaseSpecific>(SubCaseSpecificMapper.GetSubCaseSpecific<ISubCaseSpecificEntity>(iSubCaseSpecificEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateSubCaseSpecificEntity", ex);
                Logger.Error("Error in SaveOrUpdateSubCaseSpecificEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubsequentEntity"/> interface.
        /// </summary>
        /// <param name="iSubsequentEntity"><see cref="ISubsequentEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        public void SaveOrUpdateSubsequentEntity(ISubsequentEntity iSubsequentEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<ISubsequent>(SubsequentMapper.GetSubsequent<ISubsequentEntity>(iSubsequentEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateSubsequentEntity", ex);
                Logger.Error("Error in SaveOrUpdateSubsequentEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        #endregion Methods
    }
}