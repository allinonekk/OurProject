#region Header

/*****************************************************************************************************
* Description : This file represents a mediator for Case Converter module.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   30/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CaseConverterMediatorImpl.cs
// Description: Represents a mediator for Case Converter module.
// </summary>
// <copyright file= "CaseConverterMediatorImpl.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System;

    using AllInOne.Legal.Domain.Case;

    /// <summary>
    /// Represents a mediator for Case Converter module.
    /// Implements <see cref="ICaseConverterMediator"/>.
    /// </summary>
    public class CaseConverterMediatorImpl : ICaseConverterMediator
    {
        #region Methods

        public CaseInfoEntity CreateCaseInfoID()
        {
            throw new NotImplementedException();
        }

        public object GetCaseConversionTypes(string caseType)
        {
            throw new NotImplementedException();
        }

        public CaseInfoEntity GetCaseInfo(string caseInfoId)
        {
            throw new NotImplementedException();
        }

        public object GetCaseLinkDetails(string caseInfoId)
        {
            throw new NotImplementedException();
        }

        public object GetCaseParty(string caseInfoId)
        {
            throw new NotImplementedException();
        }

        public object GetDocuments(string caseInfoId)
        {
            throw new NotImplementedException();
        }

        public object GetDocumentsPendingForApproval(string caseInfoId)
        {
            throw new NotImplementedException();
        }

        public HearingEntity GetHearing(string caseInfoId)
        {
            throw new NotImplementedException();
        }

        public bool SaveCaseInfo(CaseInfoEntity caseInfoEntity)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}