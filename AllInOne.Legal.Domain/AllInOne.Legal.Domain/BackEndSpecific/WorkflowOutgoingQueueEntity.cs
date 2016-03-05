#region Header

/*****************************************************************************************************
* Description : This file represents a standard OGCIncomingQueueEntity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   24/11/2011   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: BizMonitoringInfoEntity.cs
// Description: Represents a standard OGCIncomingQueue entity.
// </summary>
// <copyright file= "OGCIncomingQueueEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for WorkflowOutgoing.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class WorkflowOutgoingQueueEntity :AbstractCaseInfoDocId , IBackEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public string WorkflowOutgoingQueueId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public String CaseTypeGroupCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public long? SubCaseInfoId
        {
            get;
            set;
        }

        public string SubmissionGroupId { get; set; }

        public FilingbrokerQueueStatus QueueStatus { get; set; }
        /// <summary>
        /// Gets or sets the ExecutionDate field.
        /// </summary>
        /// <value>The ExecutionDate.</value>
        public string FilingType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public string FilingMode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CreatedDate field.
        /// </summary>
        /// <value>The CreatedDate.</value>
        public string SubFilingType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MMonitoringTypeEntity.
        /// </summary>
        /// <value>The MMonitoringTypeEntity.</value>
        public string CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the completion date.
        /// </summary>
        /// <value>The completion date.</value>
        public DateTime CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the remarks.
        /// </summary>
        /// <value>The remarks.</value>
        public string SubCaseType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public string WorkflowSerialNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OGCIncomingQueueId.
        /// </summary>
        /// <value>The BizMonitoringInfoId.</value>
        public string remarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public int? AttemptCount
        {
            get;
            set;
        }

       
        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            WorkflowOutgoingQueueEntity toCompareWith = obj as WorkflowOutgoingQueueEntity;
            return toCompareWith == null ? false : ((this.WorkflowOutgoingQueueId == toCompareWith.WorkflowOutgoingQueueId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WorkflowOutgoingQueueId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}