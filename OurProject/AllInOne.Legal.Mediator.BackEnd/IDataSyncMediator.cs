#region Header

/*****************************************************************************************************
* Description : This file represents a standard DataSync mediator interface.
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
// File: IDataSyncMediator.cs
// Description: Represents a standard DataSync mediator interface.
// </summary>
// <copyright file= "IDataSyncMediator.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd
{
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Class represents a standard DataSync mediator interface.
    /// </summary>
    public interface IDataSyncMediator
    {
        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that 
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        void CommitAndCloseSession();

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ICaseTypeInfo"/> interface.
        /// </summary>
        /// <param name="iCaseTypeInfo"><see cref="ICaseTypeInfo"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateCaseData(ICaseTypeInfo iCaseTypeInfo, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ICaseEntity"/> interface.
        /// </summary>
        /// <param name="iCaseEntity"><see cref="ICaseEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateCaseEntity(ICaseEntity iCaseEntity, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ICaseSpecificEntity"/> interface.
        /// </summary>
        /// <param name="iCaseSpecificEntity"><see cref="ICaseSpecificEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateCaseSpecificEntity(ICaseSpecificEntity iCaseSpecificEntity, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ICommonEntity"/> interface.
        /// </summary>
        /// <param name="iCommonEntity"><see cref="ICommonEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateCommonEntity(ICommonEntity iCommonEntity, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="IDocumentEntity"/> interface.
        /// </summary>
        /// <param name="iDocumentEntity"><see cref="IDocumentEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateDocumentEntity(IDocumentEntity iDocumentEntity, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ILAPEntity"/> interface.
        /// </summary>
        /// <param name="iLAPEntity"><see cref="ILAPEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateLAPEntity(ILAPEntity iLAPEntity, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubCaseTypeInfo"/> interface.
        /// </summary>
        /// <param name="iSubCaseTypeInfo"><see cref="ISubCaseTypeInfo"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateSubCaseData(ISubCaseTypeInfo iSubCaseTypeInfo, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubCaseEntity"/> interface.
        /// </summary>
        /// <param name="iSubCaseEntity"><see cref="ISubCaseEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateSubCaseEntity(ISubCaseEntity iSubCaseEntity, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubCaseSpecificEntity"/> interface.
        /// </summary>
        /// <param name="iSubCaseSpecificEntity"><see cref="ISubCaseSpecificEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateSubCaseSpecificEntity(ISubCaseSpecificEntity iSubCaseSpecificEntity, bool isCopy);

        /// <summary>
        /// Saves or updates the entities having reference to <see cref="ISubsequentEntity"/> interface.
        /// </summary>
        /// <param name="iSubsequentEntity"><see cref="ISubsequentEntity"/> interface</param>
        /// <param name="isCopy">If set to <c>true</c> SaveOrUpdateCopy will be used, else SaveOrUpdate.</param>
        void SaveOrUpdateSubsequentEntity(ISubsequentEntity iSubsequentEntity, bool isCopy);

        #endregion Methods
    }
}