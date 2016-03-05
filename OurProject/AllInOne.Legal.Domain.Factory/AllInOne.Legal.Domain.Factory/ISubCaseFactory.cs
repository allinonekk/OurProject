#region Header

/*****************************************************************************************************
 * Description : This file represents a standard interface for creating instances of objects related
 *              with SubCase.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 02/11/2010                 Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: ISubCaseFactory.cs
// Description: Represents a standard interface for creating instances of objects related with SubCase.
// </summary>
// <copyright file= "ISubCaseFactory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory
{
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.SubCase;

    /// <summary>
    /// Represents a standard interface for creating instances of objects related with SubCase.
    /// </summary>
    internal interface ISubCaseFactory
    {
        #region Methods

        RelationalSubCaseInfoEntity GetRelationalSubCaseInfoEntityInstance();

        RSubCaseSubmissionEntity GetRSubCaseSubmissionEntityInstance();

        SubCasePartyEntity GetSubCasePartyEntityInstance();

        SubCaseStatusHistoryEntity GetSubCaseStatusHistoryEntityInstance();

        #endregion Methods
    }
}