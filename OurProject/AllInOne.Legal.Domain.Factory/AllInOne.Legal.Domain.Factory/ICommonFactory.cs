#region Header

/*****************************************************************************************************
 * Description : This file represents a standard interface for creating instances of objects related
 *              with Common.
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
// File: ICommonFactory.cs
// Description: Represents a standard interface for creating instances of objects related with Common.
// </summary>
// <copyright file= "ICommonFactory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory
{
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.FrontEndSpecific;

    /// <summary>
    /// Represents a standard interface for creating instances of objects related with Common.
    /// </summary>
    public interface ICommonFactory
    {
        #region Methods
        /// <summary>
        /// Gets the <see cref="PrintDocumentQueueEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="PrintDocumentQueueEntity"/>
        /// </returns>
        /// 
        PrintDocumentQueueEntity GetPrintDocumentQueueEntityInstance();

        /// <summary>
        /// Gets the <see cref="PrintDocumentQueueDetailEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="PrintDocumentQueueDetailEntity"/>
        /// </returns>
        /// 
        PrintDocumentQueueDetailEntity GetPrintDocumentQueueDetailEntityInstance();

        /// <summary>
        /// Gets the <see cref="GetEFilingDraftStateEntityInstance"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="EFilingDraftStateEntity"/></returns>
        EFilingDraftStateEntity GetEFilingDraftStateEntityInstance();

        ScheduleJobFiredDetailEntity GetScheduleJobFiredDetailEntityInstance();

        ScheduleJobFiredInfoEntity GetScheduleJobFiredInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="WOECaseExecutionAddressEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="WOECaseExecutionAddressEntity"/></returns>
        WOECaseExecutionAddressEntity GetWOECaseExecutionAddressEntityInstance();

        /// <summary>
        /// Gets the ref order detail entity instance.
        /// </summary>
        /// <returns></returns>
        RefOrderDetailEntity GetRefOrderDetailEntityInstance();

        /// <summary>
        /// Gets the appeal time estimation detail entity instance.
        /// </summary>
        /// <returns></returns>
        AppealTimeEstimationDetailEntity GetAppealTimeEstimationDetailEntityInstance();
        #endregion Methods
    }
}