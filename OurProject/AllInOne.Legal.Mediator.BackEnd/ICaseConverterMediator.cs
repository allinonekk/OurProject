#region Header

/*****************************************************************************************************
* Description : This file represents a mediator interface for Case Converter module.
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
// File: ICaseConverterMediator.cs
// Description: Represents a mediator interface for Case Converter module.
// </summary>
// <copyright file= "ICaseConverterMediator.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd
{
    using AllInOne.Legal.Domain.Case;

    /// <summary>
    /// Represents a mediator interface for Case Converter module.
    /// </summary>
    public interface ICaseConverterMediator : IMediator
    {
        #region Methods

        CaseInfoEntity CreateCaseInfoID();

        object GetCaseConversionTypes(string caseType);

        CaseInfoEntity GetCaseInfo(string caseInfoId);

        object GetCaseLinkDetails(string caseInfoId);

        object GetCaseParty(string caseInfoId);

        object GetDocuments(string caseInfoId);

        object GetDocumentsPendingForApproval(string caseInfoId);

        // Get case related information
        HearingEntity GetHearing(string caseInfoId);

        bool SaveCaseInfo(CaseInfoEntity caseInfoEntity);

        #endregion Methods
    }
}