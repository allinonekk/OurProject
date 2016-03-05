namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class ArchiveNumberOfJudgeAssignDetail: IBackEndSpecific
    {
        #region Properties


        /// <summary>
        /// Gets or sets the number of judge assign detail id.
        /// </summary>
        /// <value>The number of judge assign detail id.</value>
        public virtual string ArchiveNumberOfJudgeAssignDetailId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the case info id.
        /// </summary>
        /// <value>The case info id.</value>
        public virtual long CaseInfoId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the sub case info id.
        /// </summary>
        /// <value>The sub case info id.</value>
        public virtual Int64? SubCaseInfoId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public virtual Int64 ItemNo
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the number of judge count.
        /// </summary>
        /// <value>The number of judge count.</value>
        public virtual Int64 NumberOfJudgeCount
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the assign status.
        /// </summary>
        /// <value>The assign status.</value>
        public virtual string AssignStatus
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>The created by.</value>
        public virtual string CreatedBy
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>The created date.</value>
        public virtual DateTime CreatedDate
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the confirmed by.
        /// </summary>
        /// <value>The confirmed by.</value>
        public virtual string ConfirmedBy
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the confirmed date.
        /// </summary>
        /// <value>The confirmed date.</value>
        public virtual DateTime? ConfirmedDate
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public virtual string LastModifiedBy
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
        /// Gets or sets the workflow serial no.
        /// </summary>
        /// <value>The workflow serial no.</value>
        public virtual string WorkflowSerialNo
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the remarks.
        /// </summary>
        /// <value>The remarks.</value>
        public virtual string Remarks
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
            ArchiveNumberOfJudgeAssignDetail toCompareWith = obj as ArchiveNumberOfJudgeAssignDetail;
            return toCompareWith == null ? false : ((this.ArchiveNumberOfJudgeAssignDetailId == toCompareWith.ArchiveNumberOfJudgeAssignDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ArchiveNumberOfJudgeAssignDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}