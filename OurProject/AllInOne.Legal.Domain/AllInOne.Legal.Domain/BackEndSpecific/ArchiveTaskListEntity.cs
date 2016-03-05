namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    [Serializable]
    public class ArchiveTaskListEntity : AbstractCaseInfoSubCaseInfoDocId, IBackEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AssignedNo field.
        /// </summary>
        /// <value>The assigned no.</value>
        public Int32? AssignedNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the AssignedTo field.
        /// </summary>
        /// <value>The assigned to.</value>
        public String AssignedTo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the CaseName field.
        /// </summary>
        /// <value>The name of the case.</value>
        public String CaseName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the CaseNo field.
        /// </summary>
        /// <value>The case no.</value>
        public String CaseNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the check list instance id.
        /// </summary>
        /// <value>The check list instance id.</value>
        public String CheckListInstanceId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the COM doc id.
        /// </summary>
        /// <value>The COM doc id.</value>
        public String ComDocId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the DateOfFiling field.
        /// </summary>
        /// <value>The date of filing.</value>
        public DateTime? DateOfFiling
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the DateSend field.
        /// </summary>
        /// <value>The date send.</value>
        public DateTime? DateSend
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the GroupID field.
        /// </summary>
        /// <value>The group id.</value>
        public String GroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the HRGID field.
        /// </summary>
        /// <value>The HRGID.</value>
        public Int64? HRGID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is cross court.
        /// </summary>
        /// <value>The is cross court.</value>
        public YesNo IsCrossCourt
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is urgent ind.
        /// </summary>
        /// <value>The is urgent ind.</value>
        public YesNo IsUrgentInd
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the LFID field.
        /// </summary>
        /// <value>The LFID.</value>
        public String LFID
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the MessageDescription field.
        /// </summary>
        /// <value>The message description.</value>
        public String MessageDescription
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the MessageType field.
        /// </summary>
        /// <value>The type of the message.</value>
        public TasklistMessageType MessageType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SectionCode field.
        /// </summary>
        /// <value>The section code.</value>
        public MSectionEntity MSectionEntity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the TaskListType field.
        /// </summary>
        /// <value>The task list type.</value>
        public MTaskListTypeEntity MTaskListTypeEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OrgCaseNo field.
        /// </summary>
        /// <value>The org case no.</value>
        public String OrgCaseNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ParentWFSNo field.
        /// </summary>
        /// <value>The parent WFS no.</value>
        public String ParentWFSNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the PriorityInd field.
        /// </summary>
        /// <value>The priority ind.</value>
        public YesNo PriorityInd
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the PriortyIconCode field.
        /// </summary>
        /// <value>The priorty icon code.</value>
        public String PriortyIconCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Remarks field.
        /// </summary>
        /// <value>The remarks.</value>
        public String Remarks
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ReminderDate field.
        /// </summary>
        /// <value>The reminder date.</value>
        public DateTime? ReminderDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ReminderId field.
        /// </summary>
        /// <value>The reminder id.</value>
        public String ReminderId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Role field.
        /// </summary>
        /// <value>The role.</value>
        public String Role
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SourceUser field.
        /// </summary>
        /// <value>The source user.</value>
        public String SourceUser
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Status field.
        /// </summary>
        /// <value>The status.</value>
        public TaskListStatus Status
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SubCaseNo field.
        /// </summary>
        /// <value>The sub case no.</value>
        public String SubCaseNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the task display main ind.
        /// </summary>
        /// <value>The task display main ind.</value>
        public YesNo TaskDisplayMainInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the display name of the task.
        /// </summary>
        /// <value>The display name of the task.</value>
        public String TaskDisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TaskLocation field.
        /// </summary>
        /// <value>The task location.</value>
        public String TaskLocation
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the TaskName field.
        /// </summary>
        /// <value>The name of the task.</value>
        public String TaskName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the WorkflowSerialNo field.
        /// </summary>
        /// <value>The workflow serial no.</value>
        public String WorkflowSerialNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the WorkItemIconcode field.
        /// </summary>
        /// <value>The work item iconcode.</value>
        public String WorkItemIconcode
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

            TaskListEntity toCompareWith = obj as TaskListEntity;
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