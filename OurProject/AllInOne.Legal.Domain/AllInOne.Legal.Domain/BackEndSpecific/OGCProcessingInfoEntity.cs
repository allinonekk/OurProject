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
    /// Represents a standard domain entity for OGCIncomingQueue.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class OGCProcessingInfoEntity : AbstractCaseInfoDocId, IBackEndSpecificEntity
    {
        #region Properties

        public string OGCProcessingInfoId
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
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public long? SubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public string SubmissionGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ExecutionDate field.
        /// </summary>
        /// <value>The ExecutionDate.</value>
        public long? HrgId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
        public string ProcessedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CreatedDate field.
        /// </summary>
        /// <value>The CreatedDate.</value>
        public DateTime ProcessedTime
        {
            get;
            set;
        }

        public string Remarks { get; set; }

        public string ErrorMsg{ get; set; }

        public OGCQueueStatus ProcessingStatus { get; set; }

        public int? AttemptCount { get; set; }


        
       
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

            OGCProcessingInfoEntity toCompareWith = obj as OGCProcessingInfoEntity;
            return toCompareWith == null ? false : ((this.OGCProcessingInfoId == toCompareWith.OGCProcessingInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.OGCProcessingInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}