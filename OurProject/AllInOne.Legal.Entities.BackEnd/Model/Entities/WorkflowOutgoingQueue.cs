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

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    /// <summary>
    /// Represents a standard domain entity for WorkflowOutgoing.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class WorkflowOutgoingQueue: IBackEndSpecific
    {
        #region Properties

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public virtual string WorkflowOutgoingQueueId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public virtual String CaseTypeGroupCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public virtual long? SubCaseInfoId
        {
            get;
            set;
        }

        public virtual string SubmissionGroupId { get; set; }

        public virtual string QueueStatus { get; set; }
        /// <summary>
        /// Gets or sets the ExecutionDate field.
        /// </summary>
        /// <value>The ExecutionDate.</value>
        public virtual string FilingType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public virtual string FilingMode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CreatedDate field.
        /// </summary>
        /// <value>The CreatedDate.</value>
        public virtual string SubFilingType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MMonitoringTypeEntity.
        /// </summary>
        /// <value>The MMonitoringTypeEntity.</value>
        public virtual string CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the completion date.
        /// </summary>
        /// <value>The completion date.</value>
        public virtual DateTime CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the remarks.
        /// </summary>
        /// <value>The remarks.</value>
        public virtual string SubCaseType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public virtual string WorkflowSerialNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OGCIncomingQueueId.
        /// </summary>
        /// <value>The BizMonitoringInfoId.</value>
        public virtual string Remarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public virtual int? AttemptCount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the doc id.
        /// </summary>
        /// <value>The doc id.</value>
        public virtual string DocId { get; set; }

        /// <summary>
        /// Gets or sets the case info id.
        /// </summary>
        /// <value>The case info id.</value>
        public virtual long CaseInfoId { get; set; }

        /// <summary>
        /// Gets or sets the last modified date.
        /// </summary>
        /// <value>The last modified date.</value>
        public virtual DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public virtual string LastModifiedBy { get; set; }
       
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

            WorkflowOutgoingQueue toCompareWith = obj as WorkflowOutgoingQueue;
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