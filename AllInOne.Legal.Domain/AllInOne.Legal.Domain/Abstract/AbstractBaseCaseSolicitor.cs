#region Header

/*****************************************************************************************************
* Description : This file represents a abstract class for BaseCaseSolicitor details.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AbstractBaseCaseSolicitor.cs
// Description: Represents a abstract class for BaseCaseSolicitor details.
// </summary>
// <copyright file= "AbstractBaseCaseSolicitor.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Abstract
{
    using System;

    /// <summary>
    /// Represents a abstract class for BaseCaseSolicitor details.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public abstract class AbstractBaseCaseSolicitor : AbstractCaseInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ACLASInd.
        /// </summary>
        /// <value>The ACLASInd.</value>
        public YesNo ACLASInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CLASInd.
        /// </summary>
        /// <value>The CLASInd.</value>
        public YesNo CLASInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CounselInd.
        /// </summary>
        /// <value>The CounselInd.</value>
        public CriminalCounselTypes CounselInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Date Appointed.
        /// </summary>
        /// <value>The Date Appointed.</value>
        public DateTime? DateAppointed
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Date Discharged.
        /// </summary>
        /// <value>The Date Discharged.</value>
        public DateTime? DateDischarged
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the JACInd.
        /// </summary>
        /// <value>The JACInd.</value>
        public YesNo JACInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LASCOInd.
        /// </summary>
        /// <value>The LASCOInd.</value>
        public YesNo LASCOInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LF id.
        /// </summary>
        /// <value>The LF id.</value>
        public string LFId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the rec id.
        /// </summary>
        /// <value>The rec id.</value>
        public string RecId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the represented by.
        /// </summary>
        /// <value>The represented by.</value>
        public CasePartyRepresentedBy RepresentedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the solicitor id.
        /// </summary>
        /// <value>The solicitor id.</value>
        public string SolicitorId
        {
            get;
            set;
        }

        #endregion Properties
    }
}