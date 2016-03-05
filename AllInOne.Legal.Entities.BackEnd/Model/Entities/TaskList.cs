﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>Class which represents the entity 'Subsequent.SubpoenaWitnessDetail'</summary>
    public partial class TaskList : IBackEndSpecific
    {
        #region Properties

        /// <summary>
        /// Gets or sets the assigned no.
        /// </summary>
        /// <value>The assigned no.</value>
        public virtual Int32? AssignedNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the assigned to.
        /// </summary>
        /// <value>The assigned to.</value>
        public virtual String AssignedTo
        {
            get;
            set;
        }

        public virtual Int64? CaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the case.
        /// </summary>
        /// <value>The name of the case.</value>
        public virtual String CaseName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the case no.
        /// </summary>
        /// <value>The case no.</value>
        public virtual String CaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the check list instance ID.
        /// </summary>
        /// <value>The check list instance ID.</value>
        public virtual String CheckListInstanceID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the COM doc ID.
        /// </summary>
        /// <value>The COM doc ID.</value>
        public virtual String ComDocID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the date of filing.
        /// </summary>
        /// <value>The date of filing.</value>
        public virtual DateTime? DateOfFiling
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the date send.
        /// </summary>
        /// <value>The date send.</value>
        public virtual DateTime? DateSend
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the doc ID.
        /// </summary>
        /// <value>The doc ID.</value>
        public virtual String DocID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the group ID.
        /// </summary>
        /// <value>The group ID.</value>
        public virtual String GroupID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRG ID.
        /// </summary>
        /// <value>The HRG ID.</value>
        public virtual Int64? HrgID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is cross court.
        /// </summary>
        /// <value>The is cross court.</value>
        public virtual String IsCrossCourt
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is urgent ind.
        /// </summary>
        /// <value>The is urgent ind.</value>
        public virtual String IsUrgentInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public virtual String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified date.
        /// </summary>
        /// <value>The last modified date.</value>
        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFID.
        /// </summary>
        /// <value>The LFID.</value>
        public virtual String LFID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the message description.
        /// </summary>
        /// <value>The message description.</value>
        public virtual String MessageDescription
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the message.
        /// </summary>
        /// <value>The type of the message.</value>
        public virtual String MessageType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the section code.
        /// </summary>
        /// <value>The section code.</value>
        public virtual MSection MSection
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the tasklist type.
        /// </summary>
        /// <value>The tasklist type.</value>
        public virtual MTaskListType MTaskListType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the org case no.
        /// </summary>
        /// <value>The org case no.</value>
        public virtual String OrgCaseNo
        {
            get;
            set;
        }

        public virtual String ParentWFSNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the priority ind.
        /// </summary>
        /// <value>The priority ind.</value>
        public virtual String PriorityInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the priorty icon code.
        /// </summary>
        /// <value>The priorty icon code.</value>
        public virtual String PriortyIconCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the remarks.
        /// </summary>
        /// <value>The remarks.</value>
        public virtual String Remarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the reminder date.
        /// </summary>
        /// <value>The reminder date.</value>
        public virtual DateTime? ReminderDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the reminder ID.
        /// </summary>
        /// <value>The reminder ID.</value>
        public virtual String ReminderID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        /// <value>The role.</value>
        public virtual String Role
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the source user.
        /// </summary>
        /// <value>The source user.</value>
        public virtual String SourceUser
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public virtual String Status
        {
            get;
            set;
        }

        public virtual Int64? SubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the sub case no.
        /// </summary>
        /// <value>The sub case no.</value>
        public virtual String SubCaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the task display main ind.
        /// </summary>
        /// <value>The task display main ind.</value>
        public virtual String TaskDisplayMainInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the display name of the task.
        /// </summary>
        /// <value>The display name of the task.</value>
        public virtual String TaskDisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the task location.
        /// </summary>
        /// <value>The task location.</value>
        public virtual String TaskLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the task.
        /// </summary>
        /// <value>The name of the task.</value>
        public virtual String TaskName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the workflow serial no.
        /// </summary>
        /// <value>The workflow serial no.</value>
        public virtual String WorkflowSerialNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the work item iconcode.
        /// </summary>
        /// <value>The work item iconcode.</value>
        public virtual String WorkItemIconcode
        {
            get;
            set;
        }


        public virtual string TaskOwnerId
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
            TaskList toCompareWith = obj as TaskList;
            return toCompareWith == null ? false : ((this.WorkflowSerialNo == toCompareWith.WorkflowSerialNo));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WorkflowSerialNo.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}