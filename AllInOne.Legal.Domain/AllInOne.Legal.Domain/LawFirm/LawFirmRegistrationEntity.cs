#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for LawFirmRegistration.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   20/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: DivorceInfoEntity.cs
// Description: Represents a standard domain entity for LawFirmRegistration.
// </summary>
// <copyright file= "DivorceInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LawFirm
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for LawFirmRegistration.    
    /// </summary>
    [Serializable]
    public class LawFirmRegistrationEntity : AbstractLastModified, ILawFirmEntity, ICommonEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="LawFirmRegistration"/> class.</summary>
        public LawFirmRegistrationEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public String AccountID
        {
            get;
            set;
        }

        public String AuthorizedSignatoryURL
        {
            get;
            set;
        }

        public String DDANo
        {
            get;
            set;
        }

        public DateTime? DREffectiveDate
        {
            get;
            set;
        }

        public DateTime? EffectiveDate
        {
            get;
            set;
        }

        public YesNo JOLInd
        {
            get;
            set;
        }

        public String LFID
        {
            get;
            set;
        }

        public String LFRegID
        {
            get ;
            set ;
        }

        public MLawFirmGroupEntity MLawFirmGroup
        {
            get;
            set;
        }

        public YesNo ObsInd
        {
            get;
            set;
        }

        public String OrganizationName
        {
            get;
            set;
        }

        public String OutboxLibraryName
        {
            get;
            set;
        }

        public DateTime? RREffectiveDate
        {
            get;
            set;
        }

        public String SentLibraryName
        {
            get;
            set;
        }

        public String SiteURL
        {
            get;
            set;
        }

        public StatusCode StatusCode
        {
            get;
            set;
        }

        public DateTime? SubmissionDate
        {
            get;
            set;
        }

        public Decimal? SubmissionSeqNo
        {
            get;
            set;
        }

        public String UEN
        {
            get;
            set;
        }

        public String VerComments
        {
            get;
            set;
        }

        public VerStatus VerStatus
        {
            get;
            set;
        }

        public String WebURL
        {
            get;
            set;
        }

        public DateTime? StartDate
        {
            get;
            set;
        }

        public String Remarks
        {
            get;
            set;
        }
        public String AccountName
        {
            get;
            set;
        }
        public String WaivedBy
        {
            get;
            set;
        }
        public YesNo WaivedAccount
        {
            get;
            set;
        }
        public Int32? LawFirmSize
        {
            get;
            set;
        }
        #endregion Properties
    }
}