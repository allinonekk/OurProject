#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for ChecklistSubmission.
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
// File: ChildInfoEntity.cs
// Description: Represents a standard domain entity for ChecklistSubmission.
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
    /// Represents a standard domain entity for ChecklistSubmission.
    /// It inherits from <see cref="AbstractDocIdSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class ChecklistSubmissionEntity : AbstractDocIdSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ChecklistDocId field.
        /// </summary>
        /// <value>The checklist doc id.</value>
        public Int64? ChecklistDocId
        {
            get;
            set;
        }

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
        /// Gets or sets the ChecklistSubmissionId field.
        /// </summary>
        /// <value>The checklist submission id.</value>
        public String ChecklistSubmissionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocName field.
        /// </summary>
        /// <value>The name of the doc.</value>
        public String DocName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the EformInd field.
        /// </summary>
        /// <value>The eform ind.</value>
        public YesNo EformInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item no.</value>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MandatoryInd field.
        /// </summary>
        /// <value>The mandatory ind.</value>
        public YesNo MandatoryInd
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ChecklistSubmission.MDocCode - Master.MDocCode.ChecklistSubmissions (m:1)'
        /// </summary>
        /// <value>The M doc code.</value>
        public MDocCodeEntity MDocCode
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
        /// Gets or sets the ProcessedInd field.
        /// </summary>
        /// <value>The processed ind.</value>
        public String ProcessedInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Remarks field.
        /// </summary>
        /// <value>The remarks.</value>
        public String Remarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Status field.
        /// </summary>
        /// <value>The status.</value>
        public String Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TemplateId field.
        /// </summary>
        /// <value>The template id.</value>
        public String TemplateId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Version field.
        /// </summary>
        /// <value>The version.</value>
        public Int32 Version
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WFInstanceId field.
        /// </summary>
        /// <value>The WF instance id.</value>
        public String WFInstanceId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WFstatus field.
        /// </summary>
        /// <value>The W fstatus.</value>
        public String WFstatus
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

            ChecklistSubmissionEntity toCompareWith = obj as ChecklistSubmissionEntity;
            return toCompareWith == null ? false : ((this.ChecklistSubmissionId == toCompareWith.ChecklistSubmissionId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ChecklistSubmissionId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}