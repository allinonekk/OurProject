﻿#region Header

/*****************************************************************************************************
* Description : This file represents a standard WorkitemRecipient entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   21/06/2011  		      CJ             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: FEWorkitemRecipientEntity.cs
// Description: Represents a standard WorkitemRecipient entity (FE).
// </summary>
// <copyright file= "FEWorkitemRecipientEntity.cs" company="AllInOne Pte Ltd">
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
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class ArchiveBEWorkitemRecipientEntity : AbstractLastModified, IBackEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the FileRefNo field.
        /// </summary>
        /// <value>The FileRefNo.</value>
        public String FileRefNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFID field.
        /// </summary>
        /// <value>The LFID.</value>
        public String LFID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SolicitorID field.
        /// </summary>
        /// <value>The SolicitorID.</value>
        public Int64? SolicitorID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Status field.
        /// </summary>
        /// <value>The Status.</value>
        public WorkItemRecipientStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkflowSerialNo field.
        /// </summary>
        /// <value>The Workflow Serial no.</value>
        public String WorkflowSerialNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the archive BE workitem recipient id.
        /// </summary>
        /// <value>The archive BE workitem recipient id.</value>
        public string ArchiveBEWorkitemRecipientId
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
            ArchiveBEWorkitemRecipientEntity toCompareWith = obj as ArchiveBEWorkitemRecipientEntity;
            return toCompareWith == null ? false : ((this.ArchiveBEWorkitemRecipientId == toCompareWith.ArchiveBEWorkitemRecipientId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ArchiveBEWorkitemRecipientId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}