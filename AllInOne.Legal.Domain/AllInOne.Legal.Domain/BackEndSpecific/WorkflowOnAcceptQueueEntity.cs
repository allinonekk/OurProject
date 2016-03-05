#region Header

/*****************************************************************************************************
* Description : This file represents a standard WorkflowPostAcceptQueueEntity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   17/11/2011  		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: WorkflowPostAcceptQueueEntity.cs
// Description: Represents a standard WorkflowPostAcceptQueueEntity.
// </summary>
// <copyright file= "WorkflowPostAcceptQueueEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for WorkitemDetails.
    /// It inherits from <see cref="AbstractCaseInfoSubCaseInfoDocId"/>
    /// </summary>
    [Serializable]
    public class WorkflowOnAcceptQueueEntity : AbstractCaseInfoSubCaseInfoDocId, IBackEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the WorkitemInd field.
        /// </summary>
        /// <value>The WorkitemInd.</value>
        public Int32? AttemptCount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkitemInd field.
        /// </summary>
        /// <value>The WorkitemInd.</value>
        public String CaseName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseInfoID field.
        /// </summary>
        /// <value>The CaseInfoID.</value>
        public String CaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoID field.
        /// </summary>
        /// <value>The SubCaseInfoID.</value>
        public String CaseType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocID field.
        /// </summary>
        /// <value>The doc id.</value>
        public String CaseTypeGroupCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkflowSerialNo field.
        /// </summary>
        /// <value>The Work flow Serial no.</value>
        public String CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkitemInd field.
        /// </summary>
        /// <value>The WorkitemInd.</value>
        public DateTime CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkflowSerialNo field.
        /// </summary>
        /// <value>The Work flow Serial no.</value>
        public String DOCCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkflowSerialNo field.
        /// </summary>
        /// <value>The Work flow Serial no.</value>
        public String ErrorMsg
        {
            get;
            set;
        }

        public Int64? HRGId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkitemInd field.
        /// </summary>
        /// <value>The WorkitemInd.</value>
        public String QueueStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkitemInd field.
        /// </summary>
        /// <value>The WorkitemInd.</value>
        public String SectionCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkflowSerialNo field.
        /// </summary>
        /// <value>The Work flow Serial no.</value>
        public String SourceUser
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocID field.
        /// </summary>
        /// <value>The doc id.</value>
        public String SubCaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkflowSerialNo field.
        /// </summary>
        /// <value>The Work flow Serial no.</value>
        public String SubCaseType
        {
            get;
            set;
        }

        public String SubmissionGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseInfoID field.
        /// </summary>
        /// <value>The CaseInfoID.</value>
        public String WorkflowOnAcceptQueueId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoID field.
        /// </summary>
        /// <value>The SubCaseInfoID.</value>
        public String WorkflowSerialNo
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
            WorkflowOnAcceptQueueEntity toCompareWith = obj as WorkflowOnAcceptQueueEntity;
            return toCompareWith == null ? false : ((this.WorkflowOnAcceptQueueId == toCompareWith.WorkflowOnAcceptQueueId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WorkflowOnAcceptQueueId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}