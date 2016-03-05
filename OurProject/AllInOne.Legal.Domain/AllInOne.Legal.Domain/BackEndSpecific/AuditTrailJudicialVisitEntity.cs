﻿namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'BackEndSpecific.AuditTrailJudicialVisitEntity'</summary>
    public class AuditTrailJudicialVisitEntity : AbstractCaseInfoSubCaseInfoIdSubmissionGroup, IBackEndSpecificEntity,IAuditEntity
    {
        #region Properties

        public AuditTrialActionType ActionType
        {
            get;
            set;
        }

        public String AuditTrailVisitId
        {
            get;
            set;
        }

        public DateTime CreatedDateTime
        {
            get;
            set;
        }

        public AuditTrailBackEndFuctions FunctionType
        {
            get;
            set;
        }

        public String LoginSessionId
        {
            get;
            set;
        }

        public String MessageDescription
        {
            get;
            set;
        }

        public AuditTrailBackEndModule Module
        {
            get;
            set;
        }

        public AuditTrailBackEndSubModule SubModule
        {
            get;
            set;
        }

        public String UserId
        {
            get;
            set;
        }

        public String UserName
        {
            get;
            set;
        }

        public String VisitStatus
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
            AuditTrailJudicialVisitEntity toCompareWith = obj as AuditTrailJudicialVisitEntity;
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