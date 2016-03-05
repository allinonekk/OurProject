#region Header

/*****************************************************************************************************
 * Description : This file represents a standard CaseIssueList entity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			        Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010               Japheth             	Created
 *****************************************************************************************************/
// <summary>
// File: CaseIssueListEntity.cs
// Description: Represents a standard CaseIssueList entity.
// </summary>
// <copyright file= "CaseIssueListEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for CaseIssueList.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class CaseIssueListEntity : AbstractCaseInfo, ICaseEntity
    {
        #region Properties

        /// <summary>Gets or sets the CaseIssueListId field. </summary>
        public System.String CaseIssueListId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGID field. </summary>
        public System.String HRGID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IssueOutcome field. </summary>
        public System.String IssueOutcome
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MCaseIssue field. </summary>
        public MCaseIssueEntity MCaseIssue
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OtherDetails field. </summary>
        public System.String OtherDetails
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PriorityOrder field. </summary>
        public Nullable<System.Int32> PriorityOrder
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubCaseInfoId field. </summary>
        public System.String SubCaseInfoId
        {
            get;
            set;
        }

        #endregion Properties
    }
}