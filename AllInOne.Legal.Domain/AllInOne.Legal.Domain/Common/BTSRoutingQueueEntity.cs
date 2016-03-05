#region Header

/*****************************************************************************************************
* Description : This file represents a standard BTSRoutingQueue entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   24/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: BTSRoutingQueueEntity.cs
// Description: Represents a standard BTSRoutingQueue entity.
// </summary>
// <copyright file= "BTSRoutingQueueEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for BTSRoutingQueue.
    /// </summary>
    [Serializable]
    public class BTSRoutingQueueEntity : ICommonEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BTSRoutingQueueEntity"/> class.</summary>
        public BTSRoutingQueueEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the CreatedDateTime field.
        /// </summary>
        /// <value>The created date time.</value>
        public DateTime CreatedDateTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedDateTime field.
        /// </summary>
        /// <value>The last modified date time.</value>
        public DateTime? LastModifiedDateTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the MessageId field.
        /// </summary>
        /// <value>The message Id.</value>
        public String MessageId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the MessageXML field.
        /// </summary>
        /// <value>The message XML.</value>
        public String MessageXml
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ProcessingStatus field.
        /// </summary>
        /// <value>The processing status.</value>
        public String ProcessingStatus
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Recipient field.
        /// </summary>
        /// <value>The recipient.</value>
        public Int32 Recipient
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the RecoveryCount field.
        /// </summary>
        /// <value>The recovery count.</value>
        public Int32 RecoveryCount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the RetryCount field.
        /// </summary>
        /// <value>The retry count.</value>
        public Int32 RetryCount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the RoutingTypeId field.
        /// </summary>
        /// <value>The routing type Id.</value>
        public Int32 RoutingTypeId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Sender field.
        /// </summary>
        /// <value>The sender.</value>
        public Int32 Sender
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SourcePayloadURI field.
        /// </summary>
        /// <value>The source payload URI.</value>
        public String SourcePayloadURI
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Status field.
        /// </summary>
        /// <value>The status.</value>
        public String Status
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the StatusCode field.
        /// </summary>
        /// <value>The status code.</value>
        public String StatusCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group Id.</value>
        public String SubmissionGroupId
        {
            get; set;
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
            BTSRoutingQueueEntity toCompareWith = obj as BTSRoutingQueueEntity;
            return toCompareWith == null ? false : ((this.MessageId == toCompareWith.MessageId) && (this.Recipient == toCompareWith.Recipient) && (this.RetryCount == toCompareWith.RetryCount) && (this.RoutingTypeId == toCompareWith.RoutingTypeId) && (this.Sender == toCompareWith.Sender));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.MessageId.GetHashCode();
            toReturn ^= this.Recipient.GetHashCode();
            toReturn ^= this.RetryCount.GetHashCode();
            toReturn ^= this.RoutingTypeId.GetHashCode();
            toReturn ^= this.Sender.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}