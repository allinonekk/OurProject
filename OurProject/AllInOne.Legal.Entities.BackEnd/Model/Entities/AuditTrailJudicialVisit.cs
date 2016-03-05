namespace AllInOne.Legal.Entities.BackEnd
{
	using System;


    public class AuditTrailJudicialVisit : IAudit
    {

        #region Fields

        public virtual string AuditTrailVisitId
        {
            get;
            set;
        }

        public virtual string LoginSessionId
        {
            get;
            set;
        }

        public virtual string UserId
        {
            get;
            set;
        }

        public virtual string UserName
        {

            get;
            set;
        }

        public virtual string VisitStatus
        {
            get;
            set;
        }

        public virtual string Module
        {
            get;
            set;
        }

        public virtual string SubModule
        {
            get;
            set;
        }

        public virtual string FunctionType
        {
            get;
            set;
        }

        public virtual string ActionType
        {
            get;
            set;
        }

        public virtual string MessageDescription
        {
            get;
            set;
        }

        public virtual Int64? CaseInfoId
        {
            get;
            set;
        }

        public virtual Int64? SubCaseInfoId
        {
            get;
            set;
        }

        public virtual string SubmissionGroupId
        {
            get;
            set;
        }

        public virtual DateTime CreatedDateTime
        {
            get;
            set;
        }

        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        #endregion

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
            AuditTrailJudicialVisit toCompareWith = obj as AuditTrailJudicialVisit;
            return toCompareWith == null ? false : ((this.AuditTrailVisitId == toCompareWith.AuditTrailVisitId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AuditTrailVisitId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}
