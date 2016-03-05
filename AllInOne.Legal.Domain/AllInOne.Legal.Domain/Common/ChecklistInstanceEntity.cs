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
    public class ChecklistInstanceEntity : AbstractCaseInfo, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ChecklistInstanceId field.
        /// </summary>
        /// <value>The checklist instance id.</value>
        public String ChecklistInstanceId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Status field.
        /// </summary>
        /// <value>The status.</value>
        public ChecklistStatus ChecklistStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        /// <value>The create date.</value>
        public DateTime? CreateDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CurrentStage field.
        /// </summary>
        /// <value>The current stage.</value>
        public Int32 CurrentStage
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ChecklistInstance.MChecklist - Master.MChecklist.ChecklistInstances (m:1)'
        /// </summary>
        /// <value>The M checklist.</value>
        public MChecklistEntity MChecklist
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ProcessedBy field.
        /// </summary>
        /// <value>The processed by.</value>
        public String ProcessedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the SNO field.
        /// </summary>
        /// <value>The SNO.</value>
        public Int64 SNO
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
            if(obj == null)
            {
                return false;
            }

            ChecklistInstanceEntity toCompareWith = obj as ChecklistInstanceEntity;
            return toCompareWith == null ? false : ((this.ChecklistInstanceId == toCompareWith.ChecklistInstanceId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ChecklistInstanceId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}