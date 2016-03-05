#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for ChecklistInstance.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   01/12/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ChecklistInstanceEntity.cs
// Description: Represents a standard domain entity for ChecklistInstance.
// </summary>
// <copyright file= "ChecklistInstanceEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for ChecklistInstance.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class CheckListCommentEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Status field.
        /// </summary>
        /// <value>The status.</value>
        public String CheckListSubmissionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        /// <value>The create date.</value>
        public String Comment
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ChecklistInstanceId field.
        /// </summary>
        /// <value>The checklist instance id.</value>
        public String CSCId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CurrentStage field.
        /// </summary>
        /// <value>The current stage.</value>
        public ChecklistCommentStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ChecklistInstance.MChecklist - Master.MChecklist.ChecklistInstances (m:1)'
        /// </summary>
        /// <value>The M checklist.</value>
        public ChecklistCommentType Type
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

            CheckListCommentEntity toCompareWith = obj as CheckListCommentEntity;
            return toCompareWith == null ? false : ((this.CSCId == toCompareWith.CSCId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CSCId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}