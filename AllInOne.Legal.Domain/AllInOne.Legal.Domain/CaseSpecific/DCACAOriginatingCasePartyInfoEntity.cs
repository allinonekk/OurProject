#region Header

/*****************************************************************************************************
 * Description : This file represents a standard DocComments entity.
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
// File: DocCommentsEntity.cs
// Description: Represents a standard DocComments entity.
// </summary>
// <copyright file= "DocCommentsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;


    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class DCACAOriginatingCasePartyInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>The action.</value>
        public string DCPID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the comment id.
        /// </summary>
        /// <value>The comment id.</value>
        public MPartyTypeEntity MPartyType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>The comments.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        public string DCACAOriginatingCasePartyInfoId
        {
            get;
            set;
        }

        public decimal? OrdinalNumber
        {
            get;
            set;
        }
        #endregion Properties
    }
}