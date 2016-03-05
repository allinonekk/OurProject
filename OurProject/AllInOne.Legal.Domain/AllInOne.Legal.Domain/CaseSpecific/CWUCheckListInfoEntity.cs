#region Header

/*****************************************************************************************************
* Description : This file represents a standard CriminalOtherOrderInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   20/01/2011   		      CJ                 	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CriminalOtherOrderInfoEntity.cs
// Description: Represents a standard CriminalOtherOrderInfo entity.
// </summary>
// <copyright file= "CriminalOtherOrderInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'CaseSpecific.CriminalOtherOrderInfo'</summary>
    [Serializable]
    public class CWUCheckListInfoEntity : AbstractLastModified, ICaseSpecificEntity
    {
        #region Properties

        public Decimal? AmountOfDeposit
        {
            get;
            set;
        }

        public String ChineseNewspaperName
        {
            get;
            set;
        }

        public DateTime? ChineseNewspaperPubDate
        {
            get;
            set;
        }

        public String CWUChecklistInfoId
        {
            get;
            set;
        }

        public DateTime? DateOfConsent
        {
            get;
            set;
        }

        public DateTime? DateofDeposit
        {
            get;
            set;
        }

        public DateTime? DateOfService
        {
            get;
            set;
        }

        public String DocId
        {
            get;
            set;
        }

        public String EnglishNewspaperName
        {
            get;
            set;
        }

        public DateTime? EnglishNewspaperPubDate
        {
            get;
            set;
        }

        public DateTime? GazetteNotificationDate
        {
            get;
            set;
        }

        public String ReceiptNumber
        {
            get;
            set;
        }

        #endregion Properties
    }
}