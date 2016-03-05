#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for ChildInfo.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ChildInfoEntity.cs
// Description: Represents a standard domain entity for ChildInfo.
// </summary>
// <copyright file= "ChildInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for DSSOutgoingQueue.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class DSSOutgoingQueueEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Age field.
        /// </summary>
        /// <value>The age.</value>
        public String DSSOutgoingQueueId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ArrangementDetails field.
        /// </summary>
        /// <value>The arrangement details.</value>
        public String MessageXML
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ChildDisableDetail field.
        /// </summary>
        /// <value>The child disable detail.</value>
        public String SourcePayloadURI
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ChildInfoID field.
        /// </summary>
        /// <value>The child info id.</value>
        public String DSSTxnId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ChildOf field.
        /// </summary>
        /// <value>The child of Plaintiff or Defendant.</value>
        public String QueueStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ChildTrainingDetails field.
        /// </summary>
        /// <value>The child training details.</value>
        public String CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfBirth field.
        /// </summary>
        /// <value>The date of birth.</value>
        public DateTime CreatedDate
        {
            get;
            set;
        }

        public String Remarks
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
            DSSOutgoingQueueEntity toCompareWith = obj as DSSOutgoingQueueEntity;
            return toCompareWith == null ? false : ((this.DSSOutgoingQueueId == toCompareWith.DSSOutgoingQueueId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DSSOutgoingQueueId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}